4; // projectedPosition
  float4 custompack3 : TEXCOORD5; // grabPassPosition
  #if UNITY_SHOULD_SAMPLE_SH
  half3 sh : TEXCOORD6; // SH
  #endif
  UNITY_FOG_COORDS(7)
  UNITY_SHADOW_COORDS(8)
  UNITY_VERTEX_INPUT_INSTANCE_ID
  UNITY_VERTEX_OUTPUT_STEREO
};
#endif
#endif
// with lightmaps:
#ifdef LIGHTMAP_ON
// half-precision fragment shader registers:
#ifdef UNITY_HALF_PRECISION_FRAGMENT_SHADER_REGISTERS
#define FOG_COMBINED_WITH_WORLD_POS
struct v2f_surf {
  UNITY_POSITION(pos);
  float3 worldNormal : TEXCOORD0;
  float4 worldPos : TEXCOORD1;
  fixed4 color : COLOR0;
  float2 custompack0 : TEXCOORD2; // texcoord
  float3 custompack1 : TEXCOORD3; // texcoord2AndBlend
  float4 custompack2 : TEXCOORD4; // projectedPosition
  float4 custompack3 : TEXCOORD5; // grabPassPosition
  float4 lmap : TEXCOORD6;
  UNITY_LIGHTING_COORDS(7,8)
  UNITY_VERTEX_INPUT_INSTANCE_ID
  UNITY_VERTEX_OUTPUT_STEREO
};
#endif
// high-precision fragment shader registers:
#ifndef UNITY_HALF_PRECISION_FRAGMENT_SHADER_REGISTERS
struct v2f_surf {
  UNITY_POSITION(pos);
  float3 worldNormal : TEXCOORD0;
  float3 worldPos : TEXCOORD1;
  fixed4 color : COLOR0;
  float2 custompack0 : TEXCOORD2; // texcoord
  float3 custompack1 : TEXCOORD3; // texcoord2AndBlend
  float4 custompack2 : TEXCOORD4; // projectedPosition
  float4 custompack3 : TEXCOORD5; // grabPassPosition
  float4 lmap : TEXCOORD6;
  UNITY_FOG_COORDS(7)
  UNITY_SHADOW_COORDS(8)
  UNITY_VERTEX_INPUT_INSTANCE_ID
  UNITY_VERTEX_OUTPUT_STEREO
};
#endif
#endif

// vertex shader
v2f_surf vert_surf (appdata_particles v) {
  UNITY_SETUP_INSTANCE_ID(v);
  v2f_surf o;
  UNITY_INITIALIZE_OUTPUT(v2f_surf,o);
  UNITY_TRANSFER_INSTANCE_ID(v,o);
  UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(o);
  Input customInputData;
  vert (v, customInputData);
  o.custompack0.xy = customInputData.texcoord;
  o.custompack1.xyz = customInputData.texcoord2AndBlend;
  o.custompack2.xyzw = customInputData.projectedPosition;
  o.custompack3.xyzw = customInputData.grabPassPosition;
  o.pos = UnityObjectToClipPos(v.vertex);
  float3 worldPos = mul