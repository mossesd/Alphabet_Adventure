 newSequencePath = EditorUtility.SaveFilePanelInProject(DirectorStyles.createNewTimelineText.text, defaultName, "playable", message, defaultPath);
                    if (!string.IsNullOrEmpty(newSequencePath))
                    {
                        var newAsset = TimelineUtility.CreateAndSaveTimelineAsset(newSequencePath);

                        Undo.IncrementCurrentGroup();

                        if (existingDirector == null)
                        {
                            existingDirector = Undo.AddComponent<PlayableDirector>(currentlySelectedGo);
                        }

                        existingDirector.playableAsset = newAsset;
                        SetTimeline(existingDirector);
                        windowState.previewMode = false;
                    }

                    // If we reach this point, the state of the panel has changed; skip the rest of this GUI phase
                    // Fixes: case 955831 - [OSX] NullReferenceException when creating a timeline on a selected object
                    GUIUtility.ExitGUI();
                }
                GUILayout.EndHorizontal();
            }
            GUILayout.FlexibleSpace();
            GUILayout.EndVertical();
            GUILayout.FlexibleSpace();
        }

        internal List<OverlayDrawer> OverlayDrawData = new List<OverlayDrawer>();

        void DrawTracksGUI(Rect clientRect, TimelineModeGUIState trackState)
        {
            GUILayout.BeginVertical(GUILayout.Height(clientRect.height));
            if (treeView != null)
            {
                if (Event.current.type == EventType.Layout)
                {
                    OverlayDrawData.Clear();
                }

                treeView.OnGUI(clientRect);

                if (Event.current.type == EventType.Repaint)
                {
                    foreach (var overlayData in OverlayDrawData)
                    {
                        using (new GUIViewportScope(sequenceContentRect))
                            overlayData.Draw();
                    }
                }
            }
            GUILayout.EndVertical();
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    using UnityEditor;
using UnityEngine;

using Codice.Utils;
using PlasticGui;
using Unity.PlasticSCM.Editor.UI;

namespace Unity.PlasticSCM.Editor.Configuration
{
    internal class EncryptionConfigurationDialog : PlasticDialog
    {
        protected override Rect DefaultRect
        {
            get
            {
                var baseRect = base.DefaultRect;
                return new Rect(baseRect.x, baseRect.y, 650, 425);
            }
        }

        internal static EncryptionConfigurationDialogData RequestEncryptionPassword(
            string server,
            EditorWindow parentWindow)
        {
            EncryptionConfigurationDialog dialog = Create(server);

            ResponseType dialogResult = dialog.RunModal(parentWindow);

            EncryptionConfigurationDialogData result =
                dialog.BuildEncryptionConfigurationData();

            result.Result = dialogResult == ResponseType.Ok;
            return result;
        }

        protected override void OnModalGUI()
        {
            Title(PlasticLocalization.GetString(
                PlasticLocalization.Name.EncryptionConfiguration));

            GUILayout.Space(20);

            Paragraph(PlasticLocalization.GetString(
                PlasticLocalization.Name.EncryptionConfigurationExplanation, mServer));

            DoPasswordArea();

            Paragraph(PlasticLocalization.GetString(
                PlasticLocalization.Name.EncryptionConfigurationRemarks, mServer));

            GUILayout.Space(10);

            DoNotificationArea();

            GUILayout.Space(10);

            DoButtonsArea();
        }

        protected override string GetTitle()
        {
            return PlasticLocalization.GetString(
                PlasticLocalization.Name.EncryptionConfiguration);
        }

        EncryptionConfigurationDialogData BuildEncryptionConfigurationData()
        {
            return new EncryptionConfigurationDialogData(
                CryptoServices.GetEncryptedPassword(mPassword.Trim()));
        }

        void DoPasswordArea()
        {
            Paragraph(PlasticLocalization.GetString(
                PlasticLocalization.Name.EncryptionConfigurationEnterPassword));

            GUILayout.Space(5);

            mPassword = PasswordEntry(PlasticLocalization.GetString(
                PlasticLocalization.Name.Password), mPassword,
                PASSWORD_TEXT_WIDTH, PASSWORD_TEXT_X);

            GUILayout.Space(5);

            mRetypePassword = PasswordEntry(PlasticLocalization.GetString(
                PlasticLocalization.Name.RetypePassword), mRetypePassword,
                PASSWORD_TEXT_WIDTH, PASSWORD_TEXT_X);

            GUILayout.Space(18f);
        }

        void DoNotificationArea()
        {
            if (string.IsNullOrEmpty(mErrorMessage))
                return;

            var rect = GUILayoutUtility.GetRect(
                GUILayoutUtility.GetLastRect().width, 30);

            EditorGUI.HelpBox(rect, mErrorMessage, MessageType.Error);
        }

        void DoButtonsArea()
        {
            using (new EditorGUILayout.HorizontalScope())
         