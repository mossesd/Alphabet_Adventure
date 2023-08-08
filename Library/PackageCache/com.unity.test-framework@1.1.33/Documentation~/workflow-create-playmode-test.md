#pragma kernel RayMarchKernel RAY_MARCH_KERNEL=RayMarchKernel
#pragma kernel RayMarchHalfKernel RAY_MARCH_KERNEL=RayMarchHalfKernel HALF_RESOLUTION

#pragma only_renderers d3d11 ps5

// Include and define the shader pass
#include "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/ShaderPass/ShaderPass.cs.hlsl"
#define SHADERPASS SHADERPASS_RAYTRACING_GBUFFER

// HDRP generic includes
#include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Common.hlsl"
#include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Color.hlsl"
#include "Packages/com.unity.render-pipelines.high-definition/Runtime/ShaderLibrary/ShaderVariables.hlsl"
#include "Packages/com.unity.render-pipelines.high-definition/Runtime/Lighting/Lighting.hlsl"
#include "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/Material.hlsl"
#include "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/NormalBuffer.hlsl"
#include "Packages/com.unity.render-pipelines.high-definition/Runtime/Lighting/LightLoop/LightLoopDef.hlsl"
#include "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/Lit/Lit.hlsl"
#include "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/StandardLit/StandardLit.hlsl"
#include "Packages/com.unity.render-pipelines.high-definition/Runtime/Material/Lit/LitRaytracing.hlsl"

// Raytracing includes (should probably be in generic files)
#include "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/ShaderVariablesRaytracing.hlsl"
#include "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/RaytracingSampling.hlsl"
#include "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/Raytracing/Shaders/RayTracingCommon.hlsl"

// The dispatch tile resolution
#define RAY_MARCHING_TILE_SIZE 8

// Input depth pyramid texture
TEXTURE2D_X(_DepthTexture);
// Stencil texture
TEXTURE2D_X_UINT2(_StencilTexture);
// Input direction buffer
RW_TEXTURE2D_X(float4, _RaytracingDirectionBuffer);
// Input texture that holds the offset for every level of the depth pyramid
StructuredBuffer<int2>  _DepthPyramidMipLevelOffsets;

// Constant buffer that holds all scalar that we need
CBUFFER_START(UnityScreenSpaceRayMarching)
    int _DeferredStencilBit;
    int _RayMarchingSteps;
    float _RayMarchingThicknessScale;
    float _RayMarchingThicknessBias;
    int _RayMarchingReflectsSky;
CBUFFER_END

// Must be included after the declaration of variables
#include "Packages/com.unity.render-pipelines.high-definition/Runtime/Lighting/ScreenSpaceLighting/RayMarching.hlsl"

// Output textures
RW_TEXTURE2D_X(float4, _GBufferTexture0RW);
RW_TEXTURE2D_X(float4, _GBufferTexture1