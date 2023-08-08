Duration: 0
    m_BlendInDuration: -1
    m_BlendOutDuration: -1
    m_MixInCurve:
      serializedVersion: 2
      m_Curve: []
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    m_MixOutCurve:
      serializedVersion: 2
      m_Curve: []
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    m_BlendInCurveMode: 0
    m_BlendOutCurveMode: 0
    m_ExposedParameterNames: []
    m_AnimationCurves: {fileID: 0}
    m_Recordable: 0
    m_PostExtrapolationMode: 0
    m_PreExtrapolationMode: 0
    m_PostExtrapolationTime: 0
    m_PreExtrapolationTime: 0
    m_DisplayName: jog
  - m_Version: 1
    m_Start: 13.333333333333334
    m_ClipIn: 0.8499999999999996
    m_Asset: {fileID: -6648620376184312894}
    m_Duration: 0.21666666666666679
    m_TimeScale: 1
    m_ParentTrack: {fileID: 3531369346975828429}
    m_EaseInDuration: 0
    m_EaseOutDuration: 0
    m_BlendInDuration: -1
    m_BlendOutDuration: -1
    m_MixInCurve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 0
        inSlope: 0
        outSlope: 0
        tangentMode: 0
        weightedMode: 0
        inWeight: 0
        outWeight: 0
      - serializedVersion: 3
        time: 1
        value: 1
        inSlope: 0
        outSlope: 0
        tangentMode: 0
        weightedMode: 0
        inWeight: 0
        outWeight: 0
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    m_MixOutCurve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: 1
        inSlope: 0
        outSlope: 0
        tangentMode: 0
        weightedMode: 0
        inWeight: 0
        outWeight: 0
      - serializedVersion: 3
        time: 1
        value: 0
        inSlope: 0
        outSlope: 0
        tangentMode: 0
        weightedMode: 0
        inWeight: 0
        outWeight: 0
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    m_BlendInCurveMode: 0
    m_BlendOutCurveMode: 0
    m_ExposedParameterNames: []
    m_AnimationCurves: {fileID: 0}
    m_Recordable: 0
    m_PostExtrapolationMode: 0
    m_PreExtrapolationMode: 0
    m_PostExtrapolationTime: 0
    m_PreExtrapolationTime: 0
    m_DisplayName: bump
  m_Markers:
    m_Objects: []
  m_TrackProperties:
    volume: 0.2
    stereoPan: 0
    spatialBlend: 0
--- !u!114 &3553579667615640771
MonoBehaviour:
  m_ObjectHideFlags: 1
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 48853ae485fa386428341ac1ea122570, type: 3}
  m_Name: ControlPlayableAsset
  m_EditorClassIdentifier: 
  sourceGameObject:
    exposedName: 
    defaultValue: {fileID: 0}
  prefabGameObject: {fileID: 6001888412346327162, guid: b8f5cceebfbd24fc78b8d1f907a8c7be,
    type: 3}
  updateParticle: 1
  particleRandomSeed: 7355
  updateDirector: 1
  updateITimeControl: 1
  searchHierarchy: 0
  active: 1
  postPlayback: 2
--- !u!114 &3630249793367199414
MonoBehaviour:
  m_ObjectHideFlags: 1
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 030f85c3f73729f4f976f66ffb23b875, type: 3}
  m_Name: AnimationPlayableAsset
  m_EditorClassIdentifier: 
  m_Clip: {fileID: 7400000, guid: 5b7b714b6737a4aaba70f3a993f5bd02, type: 3}
  m_Position: {x: -14.684364, y: 0.8739548, z: -0.051126704}
  m_EulerAngles: {x: 0, y: -247.039, z: 0}
  m_UseTrackMatchFields: 1
  m_MatchTargetFields: 63
  m_RemoveStartOffset: 1
  m_ApplyFootIK: 1
  m_Loop: 0
  m_Version: 1
  m_Rotation: {x: 0, y: 0, z: 0, w: 1}
--- !u!74 &4843695496207817774
AnimationClip:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_Name: Recorded (6)
  serializedVersion: 6
  m_Legacy: 0
  m_Compressed: 0
  m_UseHighQualityCurve: 1
  m_RotationCurves: []
  m_CompressedRotationCurves: []
  m_EulerCurves:
  - curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: {x: -0.2053489, y: -153.3526, z: -0.1239823}
        inSlope: {x: 0, y: 0, z: 0}
        outSlope: {x: 0, y: 0, z: 0}
        tangentMode: 0
        weightedMode: 0
        inWeight: {x: 0, y: 0.33333334, z: 0.33333334}
        outWeight: {x: 0, y: 0.33333334, z: 0.33333334}
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    path: 
  m_PositionCurves:
  - curve:
      serializedVersion: 2
      m_Curve:
      - serializedVersion: 3
        time: 0
        value: {x: -0.5573421, y: 1.3783529, z: -0.84403443}
        inSlope: {x: 0, y: 0, z: 0}
        outSlope: {x: 0, y: 0, z: 0}
        tangentMode: 0
        weightedMode: 0
        inWeight: {x: 0.33333334, y: 0.33333334, z: 0.33333334}
        outWeight: {x: 0.33333334, y: 0.33333334, z: 0.33333334}
      - serializedVersion: 3
        time: 0.75
        value: {x: -0.7568426, y: 1.3976339, z: -0.4477911}
        inSlope: {x: 0, y: 0, z: 0.144863}
        outSlope: {x: 0, y: 0, z: 0.144863}
        tangentMode: 0
        weightedMode: 0
        inWeight: {x: 0.33333334, y: 0.33333334, z: 0.33333334}
        outWeight: {x: 0.33333334, y: 0.33333334, z: 0.33333334}
      - serializedVersion: 3
        time: 1.2333333
        value: {x: -0.649857, y: 1.3974825, z: -0.40312502}
        inSlope: {x: 0, y: 0, z: 0}
        outSlope: {x: 0, y: 0, z: 0}
        tangentMode: 0
        weightedMode: 0
        inWeight: {x: 0.33333334, y: 0.33333334, z: 0.33333334}
        outWeight: {x: 0.33333334, y: 0.33333334, z: 0.33333334}
      m_PreInfinity: 2
      m_PostInfinity: 2
      m_RotationOrder: 4
    path: 
  m_ScaleCurves: []
  m_FloatCurves: []
  m_PPtrCurves: []
  m_SampleRate: 60
  m_WrapMode: 0
  m_Bounds:
    m_Center: {x: 0, y: 0, z: 0}
    m_Extent: {x: 0, y: 0, z: 0}
  m_ClipBindingConstant:
    genericBindings:
    - serializedVersion: 2
      path: 0
      attribute: 1
      script: {fileID: 0}
      typeID: 4
      customType: 0
      isPPtrCurve: 0
    - serializedVersion: 2
      path: 0
      attribute: 4
      script: {fileID: 0}
      typeID: 4
      customType: 4
      isPPtrCurve: 0
