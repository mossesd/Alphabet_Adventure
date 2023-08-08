�径。

== CMD_HELP_ARCHIVE ==
备注：

    此命令从存储库数据库中提取数据并将这些数据存储在
    外部存储中，从而节省数据库空间。
    此命令还可以将以前存档的修订还原到
    存储库数据库中 (--^restore)。

    使用 'cm ^help ^objectspec' 可了解如何指定修订规格。

    运行此命令的用户必须是 Unity VCS 服务器管理员
    （存储库服务器所有者）才能完成操作。

    来自指定修订中的每个数据段都将存储在
    不同的文件中，且文件名以 --^file
    参数定义的值开头。此参数可以包含完整路径值，其中包括
    未来存档文件的前缀，也可以仅包含此前缀值。

    存档后可以通过两种方式访问来自指定修订中的
    数据：

    - 从客户端：客户端将检测数据是否已存档，
      并提示用户输入文件的位置。
      用户可以通过创建一个名为 externaldata.conf 的
      文件（在标准配置文件位置，使用适用于
      client.conf 文件的相同规则）来配置外部数据位置，
      其中包含已存档数据所在的路径。

    - 从服务器：通过这种方式，用户将不必知道数据
      是否已存档，因为请求将以透明的方式由服务器
      解析。为此，管理员将在服务器目录中创建一个
      名为 externaldata.conf 的文件，并在该文件中填充
      已存档的卷所在的路径。

    要取消存档（还原）一个修订（或一组修订），必须能够
    从客户端访问已存档的文件。因此，无法取消存档
    服务器正在解析的数据（方法 2），原因是客户端
    无法将数据识别为已存档。如果使用了方法 2，
    为了成功取消存档，管理员必须首先编辑
    externaldata.conf 服务器文件，以便删除对必须取消存档的
    已存档文件的访问权限。

    设置 PLASTICEDITOR 环境变量可指定用于键入注释的
    编辑器。

示例：

    cm ^archive bigfile.zip#^br:/main
    （在分支 'main' 中存档 'bigfile.zip' 的最后一个修订。）

    cm ^archive ^rev:myfile.pdf#^cs:2 -^c="大型 PDF 文件" --^file=c:\arch_files\arch
    （将变更集 2 中 myfile.pdf 的修订存档在 'c:\archived_files'
    文件夹中。存档的文件名将以 'arch' 开头（例如 arch_11_56）。）

    cm ^find "^revs ^where ^size > 26214400" --^format="{^item}#{^branch}" \
      --^nototal | cm ^archive --^comment="volume00" --^file="volume00" -
    （将所有大于 25Mb 的文件存档在名称 'volume00' 开头的
    文件中。）

    cm ^find "^revs ^where ^size > 26214400 ^and ^archived='true'" \
      --^format="{^item}#{^branch}" --^nototal | cm ^archive --^restore
    （还原所有大于 25Mb 的存档文件。）

== CMD_DESCRIPTION_ATTRIBUTE ==
允许用户管理属性。

== CMD_USAGE_ATTRIBUTE ==
用法：

    cm ^attribute | ^att <命令> [选项]

命令：

    ^create | ^mk
    ^delete | ^rm
    ^set
    ^unset
    ^rename
    ^edit

    要获取有关每条命令的更多信息，请运行：
    cm ^attribute <命令> --^usage
    cm ^attribute <命令> --^help

== CMD_HELP_ATTRIBUTE ==
示例：

    cm ^attribute ^create 状态
    cm ^attribute ^set ^att:status ^br:/main/SCM105 未完成
    cm ^attribute ^unset ^att:status ^br:/main/SCM105
    cm ^attribute ^delete ^att:status
    cm ^attribute ^rename ^att:status "构建状态"
    cm ^attribute ^edit ^att:status "CI 管道中任务的状态"

== CMD_DESCRIPTION_CHANGELIST ==
对更改列表中的待定更改进行分组。

== CMD_USAGE_CHANGELIST ==
用法：

    a) 管理更改列表对象：

       cm ^changelist | ^clist [--^symlink]
       （显示所有更改列表。）

       cm ^changelist | ^clist ^add <更改列表名称>
          [<更改列表描述>] [--^persistent | --^notpersistent] [--^symlink]
       （创建更改列表。）

       cm ^changelist | ^clist ^rm <更改列表名称> [--^symlink]
       （删除所选的更改列表。如果此更改列表包含待定更改，
       这些更改将移至 ^default 更改列表。）

       cm ^changelist | ^clist ^edit <更改列表名称> [<操作名称> <操作值>]
                             [--^persistent | --^notpersistent] [--^symlink]
       （编辑所选的更改列表。）

    b) 管理给定更改列表的内容：

       cm ^changelist | ^clist <更改列表名称> (^add | ^rm) <路径名称>[ ...]
                             [--^symlink]
       （通过添加 ('^add') 或删除 ('^rm') 与给定路径名称匹配的更改
       来添加所选的更改列表。使用空格
       对各个路径名称进行分隔。使用双引号 (" ") 指定包含空格的
       路径。路径的状态必须为 '^Added' 或 '^Checked-out'。）

选项：

    更改列表名称          更改列表的名称。
    更改列表描述          更改列表的描述。
    操作名称         选择 '^rename' 或 '^description' 来编辑
                        更改列表。
    操作值        在编辑更改列表时应用新名称或
                        新描述。
    --^persistent        即使更改列表的内容已被签入或还原，
                        更改列表也会保留在工作区中。
    --^notpersistent     （默认值）即使更改列表的内容已被签入
                        或还原，更改列表也不会保留在
                        工作区中。
    --^symlink           将操作应用于符号链接而不是
                        目标。

== CMD_HELP_CHANGELIST ==
备注：

    '^changelist' 命令会处理工作区待定更改列表以及更改列表中
    包含的更改。

示例：

    cm ^changelist
    （显示当前工作区更改列表。）

    cm ^changelist ^add 配置更改 "dotConf 文件" --^persistent
    （创建一个名为 '配置更改' 和描述为 'dotConf
    文件' 的新更改列表，该更改列表在待定更改列表被签入
    或还原后将在当前工作区中持久保留。）

    cm ^changelist ^edit 配置更改 ^rename 配置文件 --^notpersistent
    （编辑名为 '配置更改' 的更改列表，并将该更改列表重命名为
    '配置文件'。此外还会将更改列表变为“非持久性”。）
        
    cm ^changelist ^edit 配置更改 --^notpersistent
    （编辑名为 '配置更改' 的更改列表，并将该更改列表变为“非持久性”。）

    cm ^changelist ^rm 配置文件
    （从当前工作区中删除待定更改列表 '配置文件'。）

    cm ^changelist 配置文件 ^add foo.conf
    （将文件 'foo.conf' 添加到 '配置文件' 更改列表中。）

    cm ^changelist 配置文件 ^rm foo.conf readme.txt
    （从 '配置文件' 更改列表中删除文件 'foo.conf' 和 'readme.txt'，
    并将这些文件移至系统默认更改列表。）

== CMD_DESCRIPTION_CHANGESET ==
对变更集执行高级操作。

== CMD_USAGE_CHANGESET ==
用法：

    cm ^changeset <命令> [选项]

命令：

    ^move        | ^mv
    ^delete      | ^rm
    ^editcomment | ^edit

    要获取有关每条命令的更多信息，请运行：
    cm ^changeset <命令> --^usage
    cm ^changeset <命令> --^help

== CMD_HELP_CHANGESET ==
示例：

    cm ^changeset ^move ^cs:15@myrepo ^br:/main/scm005@myrepo
    cm ^changeset ^delete ^cs:2b55f8aa-0b29-410f-b99c-60e573a309ca@devData

== CMD_DESCRIPTION_CHANGESET_EDITCOMMENT ==
修改变更集的注释。

== CMD_USAGE_CHANGESET_EDITCOMMENT ==
用法：

    cm ^changeset ^editcomment | ^edit <变更集规格> <新注释>

选项：

    变更集规格            要修改注释的目标变更集。
                        （使用 'cm ^help ^objectspec' 可进一步了解变更集
                        规格。）
    新注释         要添加到目标变更集的
                        新注释。

== CMD_HELP_CHANGESET_EDITCOMMENT ==
备注：

    - 目标变更集规格必须有效。

示例：

    cm ^changeset ^editcomment ^cs:15@myrepo "我忘了添加签入详细信息"
    cm ^changeset ^edit ^cs:cb11ecdb-1aa9-4f11-8698-dcab14e5885a \
         "此注释文本将替代先前的注释文本。"

== CMD_DESCRIPTION_CHANGESET_MOVE ==
将变更集及其所有后代移动到另一个分支。

== CMD_USAGE_CHANGESET_MOVE ==
用法：

    cm ^changeset ^move | ^mv <变更集规格> <分支规格>

选项：

    变更�