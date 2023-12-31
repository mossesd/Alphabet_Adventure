       {
            TextEditor textEditor = typeof(EditorGUI)
              .GetField("activeEditor", BindingFlags.Static | BindingFlags.NonPublic)
              .GetValue(null) as TextEditor;

            // text editor is null when it is not focused
            if (textEditor == null)
                return false;

            // restore the selection the first time that has selected text
            // because it is done automatically by Unity
            if (isTextAreaFocused)
                return true;

            if (string.IsNullOrEmpty(textEditor.SelectedText))
                return false;

            textEditor.SelectNone();
            textEditor.MoveTextEnd();
            return true;
        }

        static string GetRulesText(string[] rules)
        {
            if (rules == null)
                return string.Empty;

            return string.Join(Environment.NewLine, rules)
                 + Environment.NewLine;
        }

        static FilterRulesConfirmationDialog Create(
            string explanation,
            string rulesText,
            bool isApplicableToAllWorkspaces)
        {
            var instance = CreateInstance<FilterRulesConfirmationDialog>();
            instance.mDialogExplanation = explanation;
            instance.mRulesText = rulesText;
            instance.mIsApplicableToAllWorkspaces = isApplicableToAllWorkspaces;
            instance.mEnterKeyAction = instance.OkButtonAction;
            instance.mEscapeKeyAction = instance.CancelButtonAction;
            return instance;
        }

        bool mIsTextAreaFocused;
        Vector2 mScrollPosition;

        bool mApplyRulesToAllWorkspace;

        bool mIsApplicableToAllWorkspaces;
        string mRulesText;
        string mDialogExplanation;
    }
}
                       FilterRulesConfirmationDialog   4   Unity.PlasticSCM.Editor.Views.PendingChanges.Dialogs                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        