                           \               0.0.0 ţ˙˙˙      ˙˙f!ë59Ý4QÁóB   í          7  ˙˙˙˙                 Ś ˛                       E                    Ţ  #                     . ,                     5   a                    Ţ  #                     . ,                      r                    Ţ  #      	               . ,      
               H Ť ˙˙˙˙             1  1  ˙˙˙˙   @           Ţ                     Q  j                    ń  J   ˙˙˙˙   Ŕ           1  1  ˙˙˙˙               Ţ                       j  ˙˙˙˙               \     ˙˙˙˙               H r   ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     H w   ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     H    ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     y 
                     Ţ  #      !               . ,      "                   ˙˙˙˙#   @          1  1  ˙˙˙˙$               Ţ      %               . j     &               Ő    ˙˙˙˙'               1  1  ˙˙˙˙(    Ŕ            Ţ      )                  j  ˙˙˙˙*                H   ˙˙˙˙+               1  1  ˙˙˙˙,   @            Ţ      -                Q  j     .                y 
    /                 Ţ  #      0               . ,      1                 §      2    @            ž ś      3    @            Ţ  #      4               . ,      5               H ť   ˙˙˙˙6              1  1  ˙˙˙˙7   @            Ţ      8                Q  j     9                H Ć   ˙˙˙˙:              1  1  ˙˙˙˙;   @            Ţ      <                Q  j     =                H Ř   ˙˙˙˙>              1  1  ˙˙˙˙?   @            Ţ      @                Q  j     A              MonoImporter PPtr<EditorExtension> m_FileID m_PathID PPtr<PrefabInstance> m_ExternalObjects SourceAssetIdentifier type assembly name m_UsedFileIDs m_DefaultReferences executionOrder icon m_UserData m_AssetBundleName m_AssetBundleVariant     s    ˙˙ŁGń×ÜZ56 :!@iÁJ*          7  ˙˙˙˙                 Ś ˛                        E                    Ţ                       .                      (   a                    Ţ                       .                       r                    Ţ        	               .       
               H Ť ˙˙˙˙             1  1  ˙˙˙˙   @           Ţ                     Q  j                    H ę ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     ń  =   ˙˙˙˙              1  1  ˙˙˙˙               Ţ                       j  ˙˙˙˙               H   ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     y 
                    Ţ                       .                      y Q                       Ţ                       .                       Ţ  X      !                H i   ˙˙˙˙"              1  1  ˙˙˙˙#   @            Ţ      $                Q  j     %                H u   ˙˙˙˙&              1  1  ˙˙˙˙'   @            Ţ      (                Q  j     )              PPtr<EditorExtension> m_FileID m_PathID PPtr<PrefabInstance> m_DefaultReferences m_Icon m_ExecutionOrder m_ClassName m_Namespace                        \       ŕyŻ     `       ü
                                                                                                                                                ŕyŻ                                                                                    InvokeMemberDescriptor  g
  using System.Linq;

namespace Unity.VisualScripting
{
    [Descriptor(typeof(InvokeMember))]
    public class InvokeMemberDescriptor : MemberUnitDescriptor<InvokeMember>
    {
        public InvokeMemberDescriptor(InvokeMember unit) : base(unit) { }

        protected override ActionDirection direction => ActionDirection.Any;

        protected override string DefinedShortTitle()
        {
            if (member.isConstructor)
            {
                return BoltCore.Configuration.humanNaming ? "Create" : "new";
            }

            return base.DefinedShortTitle();
        }

        protected override void DefinedPort(IUnitPort port, UnitPortDescription description)
        {
            base.DefinedPort(port, description);

            var documentation = member.info.Documentation();

            if (port == unit.enter)
            {
                description.label = "Invoke";
                description.summary = "The entry point to invoke the method.";

                if (member.isGettable)
                {
                    description.summary += " You can still get the return value without connecting this port.";
                }
            }
            else if (port == unit.exit)
            {
                description.summary = "The action to call once the method has been invoked.";
            }
            else if (port == unit.result)
            {
                if (member.isGettable)
                {
                    description.summary = documentation?.returns;
                }

                if (unit.supportsChaining && unit.chainable)
                {
                    description.showLabel = true;
                }
            }
            else if (port == unit.targetOutput)
            {
                if (member.isGettable)
                {
                    description.showLabel = true;
                }
            }
            else if (port is ValueInput && unit.inputParameters.ContainsValue((ValueInput)port))
            {
                var parameter = member.GetParameterInfos().Single(p => "%" + p.Name == port.key);

                description.label = parameter.DisplayName();
                description.summary = documentation?.ParameterSummary(parameter);
            }
            else if (port is ValueOutput && unit.outputParameters.ContainsValue((ValueOutput)port))
            {
                var parameter = member.GetParameterInfos().Single(p => "&" + p.Name == port.key);

                description.label = parameter.DisplayName();
                description.summary = documentation?.ParameterSummary(parameter);
            }
        }
    }
}
                        InvokeMemberDescriptor     Unity.VisualScripting                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            
u      P               0.0.0 ţ˙˙˙   ć'q ˙˙Lŕť[>CŃxěSxúŃ3   Đ          7  ˙˙˙˙                 Ś ˛                       E                    Ţ  .                     . 7                     @   a                    Ţ  .                     . 7                      r                    Ţ  .      	               . 7      
               H Ť ˙˙˙˙             1  1  ˙˙˙˙   @           Ţ                     Q  j                    ń  U   ˙˙˙˙   Ŕ           1  1  ˙˙˙˙               Ţ                       j  ˙˙˙˙               g     ˙˙˙˙               H }   ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     H    ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     H    ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     y 
                     Ţ  .      !               . 7      "                   ˙˙˙˙#   @          1  1  ˙˙˙˙$               Ţ      %               . j     &               H    ˙˙˙˙'              1  1  ˙˙˙˙(   @            Ţ      )                Q  j     *                H Š   ˙˙˙˙+              1  1  ˙˙˙˙,   @            Ţ      -                Q  j     .                H ť   ˙˙˙˙/              1  1  ˙˙˙˙0   @            Ţ      1                Q  j     2              PackageManifestImporter PPtr<EditorExtension> m_FileID m_PathID PPtr<PrefabInstance> m_ExternalObjects SourceAssetIdentifier type assembly name m_UsedFileIDs m_UserData m_AssetBundleName m_AssetBundleVariant     ĺ'q ˙˙ JAŚntó5ĂÔ7V   M          7  ˙˙˙˙                 Ś ˛                       E                    Ţ  &                     . /                     8   a                    Ţ  &                     . /                      r                    Ţ  &      	               . /      
               H Ť ˙˙˙˙             1  1  ˙˙˙˙   @           Ţ                     Q  j                    H ę ˙˙˙˙             1  1  ˙˙˙˙   @           Ţ                     Q  j                  PackageManifest PPtr<EditorExtension> m_FileID m_PathID PPtr<PrefabInstance>                         H       ţ%Ű:Š_tH                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       ţ%Ű:Š_t                                                      package Î  {
  "name": "com.unity.textmeshpro",
  "displayName": "TextMeshPro",
  "version": "3.0.6",
  "unity": "2020.1",
  "unityRelease": "0a10",
  "description": "TextMeshPro is the ultimate text solution for Unity. It's the perfect replacement for Unity's UI Text and the legacy Text Mesh.\n\nPowerful and easy to use, TextMeshPro (also known as TMP) uses Advanced Text Rendering techniques along with a set of custom shaders; delivering substantial visual quality improvements while giving users incredible flexibility when it comes to text styling and texturing.\n\nTextMeshPro provides Improved Control over text formatting and layout with features like character, word, line and paragraph spacing, kerning, justified text, Links, over 30 Rich Text Tags available, support for Multi Font & Sprites, Custom Styles and more.\n\nGreat performance. Since the geometry created by TextMeshPro uses two triangles per character just like Unity's text components, this improved visual quality and flexibility comes at no additional performance cost.",
  "keywords": [
    "TextMeshPro",
    "TextMesh Pro",
    "TMP",
    "Text",
    "SDF"
  ],
  "category": "Text Rendering",
  "dependencies": {
    "com.unity.ugui": "1.0.0"
  },
  "repository": {
    "url": "https://github.cds.internal.unity3d.com/unity/com.unity.textmeshpro.git",
    "type": "git",
    "revision": "01e57e3b7de18af9dfe9baaa0a0ff5cc4765c899"
  },
  "upmCi": {
    "footprint": "bfe9ad7192cdd29486fc5980b5ac7d0b3fafcec6"
  }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            0.0.0 ţ˙˙˙      ˙˙f!ë59Ý4QÁóB   í          7  ˙˙˙˙                 Ś ˛                       E                    Ţ  #                     . ,                     5   a                    Ţ  #                     . ,                      r                    Ţ  #      	               . ,      
               H Ť ˙˙˙˙             1  1  ˙˙˙˙   @           Ţ                     Q  j                    ń  J   ˙˙˙˙   Ŕ           1  1  ˙˙˙˙               Ţ                       j  ˙˙˙˙               \     ˙˙˙˙               H r   ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     H w   ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     H    ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     y 
                     Ţ  #      !               . ,      "                   ˙˙˙˙#   @          1  1  ˙˙˙˙$               Ţ      %               . j     &               Ő    ˙˙˙˙'               1  1  ˙˙˙˙(    Ŕ            Ţ      )                  j  ˙˙˙˙*                H   ˙˙˙˙+               1  1  ˙˙˙˙,   @            Ţ      -                Q  j     .                y 
    /                 Ţ  #      0               . ,      1                 §      2    @            ž ś      3    @            Ţ  #      4               . ,      5               H ť   ˙˙˙˙6              1  1  ˙˙˙˙7   @            Ţ      8                Q  j     9                H Ć   ˙˙˙˙:              1  1  ˙˙˙˙;   @            Ţ      <                Q  j     =                H Ř   ˙˙˙˙>              1  1  ˙˙˙˙?   @            Ţ      @                Q  j     A              MonoImporter PPtr<EditorExtension> m_FileID m_PathID PPtr<PrefabInstance> m_ExternalObjects SourceAssetIdentifier type assembly name m_UsedFileIDs m_DefaultReferences executionOrder icon m_UserData m_AssetBundleName m_AssetBundleVariant     s    ˙˙ŁGń×ÜZ56 :!@iÁJ*          7  ˙˙˙˙                 Ś ˛                        E                    Ţ                       .                      (   a                    Ţ                       .                       r                    Ţ        	               .       
               H Ť ˙˙˙˙             1  1  ˙˙˙˙   @           Ţ                     Q  j                    H ę ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     ń  =   ˙˙˙˙              1  1  ˙˙˙˙               Ţ                       j  ˙˙˙˙               H   ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     y 
                    Ţ                       .                      y Q                       Ţ                       .                       Ţ  X      !                H i   ˙˙˙˙"              1  1  ˙˙˙˙#   @            Ţ      $                Q  j     %                H u   ˙˙˙˙&              1  1  ˙˙˙˙'   @            Ţ      (                Q  j     )              PPtr<EditorExtension> m_FileID m_PathID PPtr<PrefabInstance> m_DefaultReferences m_Icon m_ExecutionOrder m_ClassName m_Namespace                        \       ŕyŻ     `       ¸                                                                                                                                                ŕyŻ                                                                                    OnDropdownValueChanged  #  using System;
using UnityEngine.UI;

namespace Unity.VisualScripting
{
    /// <summary>
    /// Called when the current value of the dropdown has changed.
    /// </summary>
    [UnitCategory("Events/GUI")]
    [TypeIcon(typeof(Dropdown))]
    [UnitOrder(4)]
    public sealed class OnDropdownValueChanged : GameObjectEventUnit<int>
    {
        public override Type MessageListenerType => typeof(UnityOnDropdownValueChangedMessageListener);
        protected override string hookName => EventHooks.OnDropdownValueChanged;

        /// <summary>
        /// The index of the newly selected option.
        /// </summary>
        [DoNotSerialize]
        public ValueOutput index { get; private set; }

        /// <summary>
        /// The text of the newly selected option.
        /// </summary>
        [DoNotSerialize]
        public ValueOutput text { get; private set; }

        protected override void Definition()
        {
            base.Definition();

            index = ValueOutput<int>(nameof(index));
            text = ValueOutput<string>(nameof(text));
        }

        protected override void AssignArguments(Flow flow, int index)
        {
            flow.SetValue(this.index, index);
            flow.SetValue(text, flow.GetValue<Dropdown>(target).options[index].text);
        }
    }
}
                        OnDropdownValueChanged     Unity.VisualScripting                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Unity.Tutorials.Core.Editor
{
    /// <summary>
    /// Holder for SerializedType and Criterion.
    /// </summary>
    [Serializable]
    public class TypedCriterion
    {
        /// <summary>
        /// The Type.
        /// </summary>
        [SerializeField, FormerlySerializedAs("type")]
        [SerializedTypeFilter(typeof(Criterion), true)]
        public SerializedType Type;

        /// <summary>
        /// The Criterion.
        /// </summary>
        [SerializeField, FormerlySeria