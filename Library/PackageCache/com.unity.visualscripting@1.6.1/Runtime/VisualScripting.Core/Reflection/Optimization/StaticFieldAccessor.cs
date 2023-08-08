��细信息[/link]。

== PlasticMergeIncomingFromCheckin ==
[title]为什么我不能签入？[/title]

因为您的工作分支中有[bold]新的更改[/bold]。

您需要先更新到最新版本，然后再完成签入（如果有冲突，还要解决冲突）。

完成更新并解决冲突后，只需转到待定更改视图并签入。

== PlasticMergeIncomingFromUpdate ==
[title]为什么我不能更新？[/title]

因为您的工作分支中有[bold]新的更改[/bold]，并且您在工作区中更改了文件。

您需要使用分支中的最新更改来更新待定更改（如果有冲突，还要解决冲突）

完成后，工作区将在工作分支上更新为最新版本。

== PlasticMergeWithConflicts ==
[title]您有冲突要解决！[/title]

[bold]专家提示[/bold]：只需单击[action:MergeProcessAllMerges]解决冲突[/action]即可开始解决所有可能的合并冲突。
（无需右键单击每个文件并逐个启动合并。）

如需了解高级选项，请查看每个冲突文件的上下文菜单。

单击[action:MergeExplainMerge]解释合并[/action]可更好地了解合并工作原理以及了解参与者。

[link:https://plasticscm.com/download/help/merges]此处提供了有关合并的更多详细信息[/link]。

== PlasticMergeWithDirectoryConflicts ==
[title]您有目录冲突！[/title]

不要慌，Plastic 非常擅长处理此问题。

当目录结构需要合并时，便会发生这种情况。

例如，如果您在两个分支中以迥异的方式重命名同一文件。

只需选择适当的“解决方法”。

如果您对这方面不熟悉，请花点时间[link:https://www.plasticscm.com/download/help/directorymerges]阅读有关可能的目录合并冲突的更多信息[/link]，然后再继续。

== PlasticMergeRecursiveMergeDetected ==
[title]您遇到了罕见的难题[/title]
您有一个递归合并冲突。

不用担心，但这个问题极具挑战性，因为三向合并工具可能会显示多次。

只需照常单击“解决冲突”。

但是，如果您不熟悉递归合并，最好先[link:https://plasticscm.com/help/recursivemerge]了解有关递归合并的更多信息[/link]。

此后，您便真正掌握了合并。

== PlasticMergeServerSideMergeFinished ==
[title]合并已完成[/title]

单击[action:MergeProcessAllMerges]签入合并！[/action]向存储库[bold]提交合并[/bold]。

单击[action:MergeCloseView]关闭[/action]将取消。

== PlasticMergeGeneralHelp ==
[title]合并预览[/title]

这是合并的预览。

此预览可以帮助您了解将要合并的内容，并解决可能的冲突。

请浏览每个元素的上下文菜单以真正了解相关选项。

[bold]专家提示[/bold]：请使用“解决冲突”，而不是逐个合并文件。

== PlasticWkExplPendingChangesUnityFirstTime ==
[title]与 Unity 结合使用时的有用提示[/title]

* 配置锁定。很有可能您希望以独占方式锁定 .prefabs。请转到 [action:WebAdminOpenInLocks]WebAdmin 并配置锁[/action]。
* 使用签出。为了锁定，您必须在编辑之前签出（锁定）文件。签出操作相当于告诉 Plastic“我要修改文件”。每个文件的右键菜单中都提供了此操作。
* 配置要忽略的文件。有些文件您不想添加到版本控制下。[action:IgnoreConfCreateUnity]单击此处[/action]可为 Unity 创建一个 ignore.conf。[link:https://plasticscm.com/download/help/ignored-hidden-etc.html]了解有关 ignore.conf 的更多信息[/link]。

== PlasticWkExplPendingChangesVisualStudioFirstTime ==
[title]与 Visual Studio 项目结合使用时的提示[/title]
忽略“bin”和“debug”目录以及某些文件（例如“.csproj.user”）会很有帮助。

[action:IgnoreConfCreateVisualStudio]单击此处[/action]向您的 ignore.conf 中添加适当的规则，并获得更好的 Visual Studio 使用体验 :-)

== PlasticQueryViewsExplainFilterAndAdvanced ==
[title]通过在上方键入“筛选”来快速筛选列表[/title]

筛选功能在本地对查询结果起作用。

[bold]筛选提示[/bold]：请使用“[italic]字段名称[/italic]:值”按给定字段进行筛选。
例如：
  "created by:maria"
  "creation date:10/25/2018"
  name:111923

还可以单击[action:QueryViewClickAdvanced]高级[/action]对查询进行自定义。

在[link:https://plasticscm.com/download/help/cmfind]此处[/link]了解有关查询的更多信息。

请注意，列表中元素的上下文菜单中有其他选项（只需右键单击）。

== PlasticQueryViewsFrustrationCustomQuery ==
[title]您启用了自定义查询[/title]

这可能就是为什么找不到想要的结果 :-O

单击[action:QueryViewClickAdvanced]高级[/action]进行自定义。

== PlasticFrustrationFilterEnabled ==
[title]您启用了筛选功能[/title]

这可能就是为什么找不到想要的结果 :-O

== PlasticNewVersionAvailableWithDownloadAction ==
[title]有新版本可用[/title]

[bold]新版 {version} - {releaseDate}[/bold] ({versionsBehind})

[action:DownloadNewVersion]下载[/action] - [link:{releaseNotesLink}]查看发行说明[/link]

{releaseNotes}

== PlasticNewVersionAvailable ==
[title]有新版本可用[/title]

[bold]新版 {vers