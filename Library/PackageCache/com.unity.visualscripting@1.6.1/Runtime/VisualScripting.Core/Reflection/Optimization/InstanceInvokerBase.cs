           clientDiffInfo.DiffWithMount.Difference.Path,
                clientDiffInfo.DiffWithMount.Difference.IsDirectory);
        }

        void IDiffTreeViewMenuOperations.RevertChanges()
        {
            RevertClientDiffsOperation.RevertChanges(
                mWkInfo,
                DiffSelection.GetSelectedDiffs(mDiffTreeView),
                mWorkspaceWindow,
                mProgressControls,
                mGuiMessage,
                AfterRevertOrUndeleteOperation);
        }

        void IDiffTreeViewMenuOperations.Undelete()
        {
            UndeleteClientDiffsOperation.Undelete(
                mWkInfo,
                DiffSelection.GetSelectedDiffs(mDiffTreeView),
                mWorkspaceWindow,
                mProgressControls,
                this,
                mGuiMessage,
                AfterRevertOrUndeleteOperation);
        }

        void IDiffTreeViewMenuOperations.UndeleteToSpecifiedPaths()
        {
            UndeleteClientDiffsOperation.UndeleteToSpecifiedPaths(
                mWkInfo,
                DiffSelection.GetSelectedDiffs(mDiffTreeView),
                mWorkspaceWindow,
                mProgressControls,
                this,
                mGuiMessage,
                AfterRevertOrUndeleteOperation);
        }

        bool DiffTreeViewMenu.IMetaMenuOperations.SelectionHasMeta()
        {
            return mDiffTreeView.SelectionHasMeta();
        }

        void DiffTreeViewMenu.IMetaMenuOperations.DiffMeta()
        {
            if (LaunchTool.ShowDownloadPlasticExeWindow(mIsGluonMode))
                return;

            ClientDiffInfo clientDiffInfo =
                DiffSelection.GetSelectedDiff(mDiffTreeView);

            ClientDiffInfo clientDiffInfoMeta =
       