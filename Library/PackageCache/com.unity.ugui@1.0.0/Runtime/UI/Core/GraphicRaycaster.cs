                                                   ŕyŻ                                                                                    TestListGuiHelper     using System;
using System.IO;
using System.Linq;
using UnityEditor.ProjectWindowCallback;
using UnityEditor.Scripting.ScriptCompilation;
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.GUI
{
    internal class TestListGUIHelper
    {
        private const string kResourcesTemplatePath = "Resources/ScriptTemplates";
        private const string kAssemblyDefinitionTestTemplate = "92-Assembly Definition-NewTestAssembly.asmdef.txt";

        private const string kAssemblyDefinitionEditModeTestTemplate =
            "92-Assembly Definition-NewEditModeTestAssembly.asmdef.txt";

        private const string kTestScriptTemplate = "83-C# Script-NewTestScript.cs.txt";
        private const string kNewTestScriptName = "NewTestScript.cs";
        private const string kNunit = "nunit.framework.dll";

        [MenuItem("Assets/Create/Testing/Tests Assembly Folder", false, 83)]
        public static void MenuItemAddFolderAndAsmDefForTesting()
        {
            AddFolderAndAsmDefForTesting();
        }

        [MenuItem("Assets/Create/Testing/Tests Assembly Folder", true, 83)]
        public static bool MenuItemAddFolderAndAsmDefForTestingWithValidation()
        {
            return !SelectedFolderContainsTestAssembly();
        }

        public static void AddFolderAndAsmDefForTesting(bool isEditorOnly = false)
        {
            ProjectWindowUtil.CreateFolderWithTemplates("Tests",
                isEditorOnly ? kAssemblyDefinitionEditModeTestTemplate : kAssemblyDefinitionTestTemplate);
        }

        public static bool SelectedFolderContainsTestAssembly()
        {
            var theNearestCustomScriptAssembly = GetTheNearestCustomScriptAssembly();
            if (theNearestCustomScriptAssembly != null)
            {
                return theNearestCustomScriptAssembly.PrecompiledReferences != null && theNearestCustomScriptAssembly.PrecompiledReferences.Any(x => Path.GetFileName(x) == kNunit);
            }

            return false;
        }

        [MenuItem("Assets/Create/Testing/C# Test Script", false, 83)]
        public static void AddTest()
        {
            var basePath = Path.Combine(EditorApplication.applicationContentsPath, kResourcesTemplatePath);
            var destPath = Path.Combine(GetActiveFolderPath(), kNewTestScriptName);
            var templatePath = Path.Combine(basePath, kTestScriptTemplate);
            var icon = EditorGUIUtility.IconContent("cs Script Icon").image as Texture2D;
            ProjectWindowUtil.StartNameEditingIfProjectWindowExists(0,
                ScriptableObject.CreateInstance<DoCreateScriptAsset>(), destPath, icon, templatePath);

            AssetDatabase.Refresh();
        }

        [MenuItem("Assets/Create/Testing/C# Test Script", true, 83)]
        public static bool CanAddScriptAndItWillCompile()
        {
            return CanAddEditModeTestScriptAndItWillCompile() || CanAddPlayModeTestScriptAndItWillCompile();
        }

        public static bool CanAddEditModeTestScriptAndItWillCompile()
        {
            var theNearestCustomScriptAssembly = GetTheNearestCustomScriptAssembly();
            if (theNearestCustomScriptAssembly != null)
            {
                return (theNearestCustomScriptAssembly.AssemblyFlags & AssemblyFlags.EditorOnly) ==
                    AssemblyFlags.EditorOnly;
            }

            var activeFolderPath = GetActiveFolderPath();
            return activeFolderPath.ToLower().Contains("/editor");
        }

        public static bool CanAddPlayModeTestScriptAndItWillCompile()
        {
            if (PlayerSettings.playModeTestRunnerEnabled)
            {
                return true;
            }

            var theNearestCustomScriptAssembly = GetTheNearestCustomScriptAssembly();

            if (theNearestCustomScriptAssembly == null)
            {
                return false;
            }

            var hasTestAssemblyFlag = theNearestCustomScriptAssembly.PrecompiledReferences != null && theNearestCustomScriptAssembly.PrecompiledReferences.Any(x => Path.GetFileName(x) == kNunit);;
            var editorOnlyAssembly = (theNearestCustomScriptAssembly.AssemblyFlags & AssemblyFlags.EditorOnly) != 0;

            return hasTestAssemblyFlag && !editorOnlyAssembly;
        }

        public static string GetActiveFolderPath()
        {
            var path = "Assets";

            foreach (var obj in Selection.GetFiltered(typeof(UnityEngine.Object), SelectionMode.Assets))
            {
                path = AssetDatabase.GetAssetPath(obj);
                if (!string.IsNullOrEmpty(path) && File.Exists(path))
                {
                    path = Path.GetDirectoryName(path);
                    break;
                }
            }
            return path;
        }

        private static CustomScriptAssembly GetTheNearestCustomScriptAssembly()
        {
            CustomScriptAssembly findCustomScriptAssemblyFromScriptPath;
            try
            {
                findCustomScriptAssemblyFromScriptPath =
                    EditorCompilationInterface.Instance.FindCustomScriptAssemblyFromScriptPath(
                        Path.Combine(GetActiveFolderPath(), "Foo.cs"));
            }
            catch (Exception)
            {
                return null;
            }
            return findCustomScriptAssemblyFromScriptPath;
        }
    }
}
                       TestListGuiHelper                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      l               0.0.0 ţ˙˙˙      ˙˙f!ë59Ý4QÁóB   í          7  ˙˙˙˙                 Ś ˛                       E                    Ţ  #                     . ,                     5   a                    Ţ  #                     . ,                      r                    Ţ  #      	               . ,      
               H Ť ˙˙˙˙             1  1  ˙˙˙˙   @           Ţ                     Q  j                    ń  J   ˙˙˙˙   Ŕ           1  1  ˙˙˙˙               Ţ                       j  ˙˙˙˙               \     ˙˙˙˙               H r   ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     H w   ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     H    ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     y 
                     Ţ  #      !               . ,      "                   ˙˙˙˙#   @          1  1  ˙˙˙˙$               Ţ      %               . j     &               Ő    ˙˙˙˙'               1  1  ˙˙˙˙(    Ŕ            Ţ      )                  j  ˙˙˙˙*                H   ˙˙˙˙+               1  1  ˙˙˙˙,   @            Ţ      -                Q  j     .                y 
    /                 Ţ  #      0               . ,      1                 §      2    @            ž ś      3    @            Ţ  #      4               . ,      5               H ť   ˙˙˙˙6              1  1  ˙˙˙˙7   @            Ţ      8                Q  j     9                H Ć   ˙˙˙˙:              1  1  ˙˙˙˙;   @            Ţ      <                Q  j     =                H Ř   ˙˙˙˙>              1  1  ˙˙˙˙?   @            Ţ      @                Q  j     A              MonoImporter PPtr<EditorExtension> m_FileID m_PathID PPtr<PrefabInstance> m_ExternalObjects SourceAssetIdentifier type assembly name m_UsedFileIDs m_DefaultReferences executionOrder icon m_UserData m_AssetBundleName m_AssetBundleVariant     s    ˙˙ŁGń×ÜZ56 :!@iÁJ*          7  ˙˙˙˙                 Ś ˛                        E                    Ţ                       .                      (   a                    Ţ                       .                       r                    Ţ        	               .       
               H Ť ˙˙˙˙             1  1  ˙˙˙˙   @           Ţ                     Q  j                    H ę ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     ń  =   ˙˙˙˙              1  1  ˙˙˙˙               Ţ                       j  ˙˙˙˙               H   ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     y 
                    Ţ                       .                      y Q                       Ţ                       .                       Ţ  X      !                H i   ˙˙˙˙"              1  1  ˙˙˙˙#   @            Ţ      $                Q  j     %                H u   ˙˙˙˙&              1  1  ˙˙˙˙'   @            Ţ      (                Q  j     )              PPtr<EditorExtension> m_FileID m_PathID PPtr<PrefabInstance> m_DefaultReferences m_Icon m_ExecutionOrder m_ClassName m_Namespace                        \       ŕyŻ     `       	                                                                                                                                                ŕyŻ                                                                                 
   Assignment    using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Unity.VisualScripting
{
    public sealed class Assignment
    {
        public Assignment(Member assigner, Type assigneeType)
        {
            Ensure.That(nameof(assigneeType)).IsNotNull(assigneeType);

            this.assigner = assigner;

            var assignsAttribute = assigner.info.GetAttribute<AssignsAttribute>();
            assignee = new Member(assigneeType, assignsAttribute?.memberName ?? assigner.name.FirstCharacterToLower());
            requiresAPI = assigner.info.HasAttribute<RequiresUnityAPIAttribute>();
            cache = assignsAttribute?.cache ?? true;

            assigner.Prewarm();
            assignee.Prewarm();
        }

        public Member assigner { get; }
        public Member assignee { get; }
        public bool requiresAPI { get; }
        public bool cache { get; }

        public void Run(object assigner, object assignee)
        {
            if (requiresAPI)
            {
                UnityAPI.Async(() => _Run(assigner, assignee));
            }
            else
            {
                _Run(assigner, assignee);
            }
        }

        private void _Run(object assigner, object assignee)
        {
            var oldValue = this.assignee.Get(assignee);
            var newValue = ConversionUtility.Convert(this.assigner.Invoke(assigner), this.assignee.type);

            this.assignee.Set(assignee, newValue);

            if (!Equals(oldValue, newValue))
            {
                if (assigner is IAssigner _assigner)
                {
                    _assigner.ValueChanged();
                }
            }
        }

        public static IEnumerable<Assignment> Fetch(Type descriptorType, Type descriptionType)
        {
            var bindingFl