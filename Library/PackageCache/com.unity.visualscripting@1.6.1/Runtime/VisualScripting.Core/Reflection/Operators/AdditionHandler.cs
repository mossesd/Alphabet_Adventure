                                                   ŕyŻ                                                                                    CubemapInputMaterialSlot°  using System;
using System.Collections.Generic;
using UnityEditor.Graphing;
using UnityEditor.ShaderGraph.Drawing.Slots;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

using UnityEngine.UIElements;

namespace UnityEditor.ShaderGraph
{
    [Serializable]
    [HasDependencies(typeof(MinimalCubemapInputMaterialSlot))]
    class CubemapInputMaterialSlot : CubemapMaterialSlot
    {
        [SerializeField]
        private SerializableCubemap m_Cubemap = new SerializableCubemap();

        public Cubemap cubemap
        {
            get { return m_Cubemap.cubemap; }
            set { m_Cubemap.cubemap = value; }
        }

        public override bool isDefaultValue => cubemap == null;

        public CubemapInputMaterialSlot()
        { }

        public CubemapInputMaterialSlot(
            int slotId,
            string displayName,
            string shaderOutputName,
            ShaderStageCapability stageCapability = ShaderStageCapability.All,
            bool hidden = false)
            : base(slotId, displayName, shaderOutputName, SlotType.Input, stageCapability, hidden)
        { }

        public override VisualElement InstantiateControl()
        {
            return new CubemapSlotControlView(this);
        }

        public override string GetDefaultValue(GenerationMode generationMode)
        {
            var nodeOwner = owner as AbstractMaterialNode;
            if (nodeOwner == null)
                throw new Exception(string.Format("Slot {0} either has no owner, or the owner is not a {1}", this, typeof(AbstractMaterialNode)));

            return $"UnityBuildTextureCubeStruct({nodeOwner.GetVariableNameForSlot(id)})";
        }

        public override void AddDefaultProperty(PropertyCollector properties, GenerationMode generationMode)
        {
            var nodeOwner = owner as AbstractMaterialNode;
            if (nodeOwner == null)
                throw new Exception(string.Format("Slot {0} either has no owner, or the owner is not a {1}", this, typeof(AbstractMaterialNode)));

            var prop = new CubemapShaderProperty();
            prop.overrideReferenceName = nodeOwner.GetVariableNameForSlot(id);
            prop.modifiable = false;
            prop.generatePropertyBlock = true;
            prop.value.cubemap = cubemap;
            properties.AddShaderProperty(prop);
        }

        public override void GetPreviewProperties(List<PreviewProperty> properties, string name)
        {
            var pp = new PreviewProperty(PropertyType.Cubemap)
            {
                name = name,
                cubemapValue = cubemap
            };
            properties.Add(pp);
        }

        public override void CopyValuesFrom(MaterialSlot foundSlot)
        {
            var slot = foundSlot as CubemapInputMaterialSlot;
            if (slot != null)
            {
                m_Cubemap = slot.m_Cubemap;
                bareResource = slot.bareResource;
            }
        }
    }

    class MinimalCubemapInputMaterialSlot : IHasDependencies
    {
        [SerializeField]
        private SerializableCubemap m_Cubemap = null;

        public void GetSourceAssetDependencies(AssetCollection assetCollection)
        {
            var guidString = m_Cubemap.guid;
            if (!string.IsNullOrEmpty(guidString) && GUID.TryParse(guidString, out var guid))
            {
                assetCollection.AddAssetDependency(guid, AssetCollection.Flags.IncludeInExportPackage);
            }
        }
    }
}
                       CubemapInputMaterialSlot   UnityEditor.ShaderGraph                                                                                                                                                                                                                                                                                                                                                                                        P               0.0.0 ţ˙˙˙      ˙˙f!ë59Ý4QÁóB   í          7  ˙˙˙˙                 Ś ˛                       E                    Ţ  #                     . ,                     5   a                    Ţ  #                     . ,                      r                    Ţ  #      	               . ,      
               H Ť ˙˙˙˙             1  1  ˙˙˙˙   @           Ţ                     Q  j                    ń  J   ˙˙˙˙   Ŕ           1  1  ˙˙˙˙               Ţ                       j  ˙˙˙˙               \     ˙˙˙˙               H r   ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     H w   ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     H    ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     y 
                     Ţ  #      !               . ,      "                   ˙˙˙˙#   @          1  1  ˙˙˙˙$               Ţ      %               . j     &               Ő    ˙˙˙˙'               1  1  ˙˙˙˙(    Ŕ            Ţ      )                  j  ˙˙˙˙*                H   ˙˙˙˙+               1  1  ˙˙˙˙,   @            Ţ      -                Q  j     .                y 
    /                 Ţ  #      0               . ,      1                 §      2    @            ž ś      3    @            Ţ  #      4               . ,      5               H ť   ˙˙˙˙6              1  1  ˙˙˙˙7   @            Ţ      8                Q  j     9                H Ć   ˙˙˙˙:              1  1  ˙˙˙˙;   @            Ţ      <                Q  j     =                H Ř   ˙˙˙˙>              1  1  ˙˙˙˙?   @            Ţ      @                Q  j     A              MonoImporter PPtr<EditorExtension> m_FileID m_PathID PPtr<PrefabInstance> m_ExternalObjects SourceAssetIdentifier type assembly name m_UsedFileIDs m_DefaultReferences executionOrder icon m_UserData m_AssetBundleName m_AssetBundleVariant     s    ˙˙ŁGń×ÜZ56 :!@iÁJ*          7  ˙˙˙˙                 Ś ˛                        E                    Ţ                       .                 