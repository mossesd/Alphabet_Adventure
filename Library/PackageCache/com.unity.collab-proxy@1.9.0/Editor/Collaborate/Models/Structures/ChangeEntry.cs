rmFactorD);
#endif
            ltcValue *= lightData.diffuseDimmer;

            // Only apply cookie if there is one
            if ( lightData.cookieMode != COOKIEMODE_NONE )
            {
#ifndef APPROXIMATE_POLY_LIGHT_AS_SPHERE_LIGHT
                formFactorD = PolygonFormFactor(LD);
#endif
                ltcValue *= SampleAreaLightCookie(lightData.cookieScaleOffset, LD, formFactorD);
            }

            // We don't multiply by 'bsdfData.diffuseColor' here. It's done only once in PostEvaluateBSDF().
            // See comment for specular magnitude, it apply to diffuse as well
            lighting.diffuse = preLightData.diffuseFGD * ltcValue;

            if (HasFlag(bsdfData.materialFeatures, MATERIALFEATUREFLAGS_FABRIC_TRANSMISSION))
            {
                // Flip the view vector and the normal. The bitangent stays the same.
                float3x3 flipMatrix = float3x3(-1,  0,  0,
                                                0,  1,  0,
                                                0,  0, -1);

                // Use the Lambertian approximation for performance reasons.
                // The matrix multiplication should not generate any extra ALU on GCN.
                float3x3 ltcTransform = mul(flipMatrix, k_identity3x3);

                // Polygon irradiance in the transformed configuration.
                // TODO: double evaluation is very inefficient! This is a temporary solution.
                float4x3 LTD = mul(lightVerts, ltcTransform);
                ltcValue  = PolygonIrradiance(LTD);
                ltcValue *= lightData.diffuseDimmer;

                // Only apply cookie if there is one
                if ( lightData.cookieMode != COOKIEMODE_NONE )
                {
                    // Compute the cookie data for the transmission diffuse term
                    float3 formFactorTD = PolygonFormFactor(LTD);
                    ltcValue *= SampleAreaLightCookie(lightData.cookieScaleOf