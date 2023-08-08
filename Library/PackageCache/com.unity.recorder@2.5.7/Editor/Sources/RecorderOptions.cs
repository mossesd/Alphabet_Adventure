                    http://msdn.microsoft.com/en-us/library/system.text.encoding.aspx
                        にある MSDN のドキュメントを参照してください
                        (ページの最後、「名前」列)。

== CMD_HELP_REVISION_HISTORY ==
備考:

    このコマンドは、指定された項目のリビジョンのリストと、各リビジョンのラベル、
    ブランチ、およびコメント情報を表示します。

    このコマンドは、出力を表示する形式の文字列を受け取ります。
    このコマンドの出力パラメーターは次のとおりです。
        {0} | {^date}              日付。
        {1} | {^changesetid}       変更セット番号。
        {2} | {^branch}            ブランチ。
        {4} | {^comment}           コメント。
        {5} | {^owner}             所有者。
        {6} | {^id}                リビジョン ID。
        {7} | {^repository}        リポジトリ。
        {8} | {^server}            サーバー。
        {9} | {^repspec}           リポジトリ指定。
        {^tab}                     タブスペースを挿入します。
        {^newline}                 改行を挿入します。

例:

    cm ^history file1.txt "file 2.txt"

    cm ^hist c:\workspace --^long
    (すべての情報を表示します。)

    cm ^history リンク --^symlink
    (ターゲットにではなくリンクファイルに履歴操作を適用します。
    UNIX 環境で利用できます。)

    cm ^history ^serverpath:/src/foo/bar.c#^br:/main/task001@myserver
    (指定されたブランチのサーバーパスからリビジョン履歴を取得します。)

== CMD_DESCRIPTION_REVISION_TREE ==
項目のリビジョンツリーを表示します。

== CMD_USAGE_REVISION_TREE ==
使用方法:

    cm ^tree <パス> [--^symlink]

    パス        項目パス。

オプション:

    --^symlink   操作をターゲットではなくリンクファイルに適用します。

== CMD_HELP_REVISION_TREE ==
例:

    cm ^tree fichero1.txt
    cm ^tree c:\workspace
    cm ^tree リンク --^symlink
    (ターゲットにではなくリンクファイルに操作を適用します。UNIX 環境で
    有効です。)

== CMD_DESCRIPTION_RM ==
ユーザーにファイルとディレクトリの削除を許可します。

== CMD_USAGE_RM ==
使用方法:

    cm ^remove | ^rm <コマンド> [オプション]

コマンド:

    ^controlled (オプション)
    ^private

    各コマンドの詳細情報を取得するには、次のコマンドを実行します:
    cm ^remove <コマンド> --^usage
    cm ^remove <コマンド> --^help

== CMD_HELP_RM ==
例:

    cm ^remove \path\controlled_file.txt
    cm ^remove ^private \path\private_file.txt

== CMD_DESCRIPTION_RM_CONTROLLED ==
ファイルまたはディレクトリをバージョン管理から削除します。

== CMD_USAGE_RM_CONTROLLED ==
使用方法:

    cm ^remove | ^rm <項目パス>[ ...][--^format=<文字列形式>]
                   [--^errorformat=<文字列形式>] [--^nodisk]

    項目パス            削除する項目パス。空白が含まれるパスを指定するには
                        二重引用符 (" ") を使用します。空白を使用してパスを
                        区切ります。

オプション:

    --^format            出力の進捗メッセージを特定の形式で
                        取得します。詳細については、「例」を参照してください。
    --^errorformat       エラーメッセージ (ある場合) を特定の形式で
                        取得します。詳細については、「例」を参照してください。
    --^nodisk            バージョン管理から項目を削除しますが、ディスク上には
                        保持します。

== CMD_HELP_RM_CONTROLLED ==
備考:

    項目はディスクから削除されます。削除された項目はソースコード管理の親
    ディレクトリから削除されます。

    要件:
    - 項目がソースコード管理の対象になっている必要があります。

stdin から入力を読み取る:

    「^remove」コマンドは stdin からパスを読み取ることができます。これを行うには、シングル
    ダッシュ「-」を渡します。
    例: cm ^remove -

    パスは空の行が入力されるまで読み取られます。
    これにより、パイプを使用して削除するファイルを指定できます。
    例:
      dir /S /B *.c | cm ^remove -
      (Windows で、ワークスペース内のすべての .c ファイルを削除します。)

例:

    cm ^remove src
    (「src」を削除します。src がディレクトリの場合、これは
    「cm ^remove -^R src」と同じです。)

    cm ^remove c:\workspace\file.txt --^format="{0} - 削除済み" \
        --^errorformat="{0} - 削除エラー"
    (バージョン管理とディスクか�