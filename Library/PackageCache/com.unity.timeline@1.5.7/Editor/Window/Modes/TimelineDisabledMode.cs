                                                   �y�                                                                                    TMP_FontAssetCommon �9  using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.TextCore;
using UnityEngine.TextCore.LowLevel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace TMPro
{
    /// <summary>
    /// Class that contains the basic information about the font.
    /// </summary>
    [Serializable]
    public class FaceInfo_Legacy
    {
        public string Name;
        public float PointSize;
        public float Scale;

        public int CharacterCount;

        public float LineHeight;
        public float Baseline;
        public float Ascender;
        public float CapHeight;
        public float Descender;
        public float CenterLine;

        public float SuperscriptOffset;
        public float SubscriptOffset;
        public float SubSize;

        public float Underline;
        public float UnderlineThickness;

        public float strikethrough;
        public float strikethroughThickness;

        public float TabWidth;

        public float Pad