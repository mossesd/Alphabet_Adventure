using UnityEditor.Rendering;
using UnityEngine.Rendering.HighDefinition;

namespace UnityEditor.Rendering.HighDefinition
{
    class SerializedLightingQualitySettings
    {
        public SerializedProperty root;

        // AO
        public SerializedProperty AOStepCount;
        public SerializedProperty AOFullRes;
        public SerializedProperty AOMaximumRadiusPixels;
        public SerializedProperty AODirectionCount;
        public SerializedProperty AOBilateralUpsample;

        // Ray Traced Ambient Occlusion
        public SerializedProperty RTAORayLength;
        public SerializedProperty RTAOSampleCount;
        public SerializedProperty RTAODenoise;
        public SerializedProperty RTAODenoiserRadius;

        // Contact Shadows
        public SerializedProperty ContactShadowSampleCount;

        // SSR
        public SerializedProperty SSRMaxRaySteps;

        // Ray Traced reflections
        public SerializedProperty RTRMinSmoothness;
        public SerializedProperty RTRSmoothnessFadeStart;
        public SerializedProperty RTRRayLength;
        public SerializedProperty RTRClampValue;
        public SerializedProperty RTRFullResolution;
        public SerializedProperty RTRRayMaxIterations;
        public SerializedProperty RTRDenoise;
        public SerializedProperty RTRDenoiserRadius;
        public SerializedProperty RTRSmoothDenoising;

        // Ray Traced Global Illumination
        public SerializedProperty RTGIRayLength;
        public SerializedProperty RTGIFullResolution;
        public SerializedProperty RTGIClampValue;
        public SerializedProperty RTGIRaySteps;
        public SerializedProperty RTGIDenoise;
        public SerializedProperty RTGIHalfResDenoise;
        public SerializedProperty RTGIDenoiserRadius;
        public SerializedProperty RTGISecondDenoise;

        // Screen Space Global Illumination
        public SerializedProperty SSGIRaySteps;
        public SerializedProperty SSGIDenoise;
        public SerializedProperty SSGIHalfResDenoise;
        public SerializedProperty SSGIDenoiserRadius;
        public SerializedProperty SSGISecondDenoise;

        // Fog
        public SerializedProperty VolumetricFogBudget;
        public SerializedProperty VolumetricFogRatio;

        public SerializedLightingQualitySettings(SerializedProperty root)
        {
            this.root = root;

            // AO
            AOStepCount = root.Find((GlobalLightingQualitySettings s) => s.AOStepCount);
            AOFullRes = root.Find