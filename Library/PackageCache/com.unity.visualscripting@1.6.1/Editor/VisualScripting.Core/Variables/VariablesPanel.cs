取ります。
    このコマンドのパラメーターは次のとおりです。
        {^path}              項目パス。
        {^date}              日付/時間を変更します。
        {^owner}             作成者を変更します。
        {^revid}             差分で同期先として見なされるリビジョンの
                            リビジョン ID。
        {^parentrevid}       差分で同期先として見なされるリビジョンの親の
                            リビジョン ID。
        {^baserevid}         差分でソースとして見なされるリビジョンの
                            リビジョン ID。
        {^srccmpath}         項目を移動する前のサーバーパス (移動操作)。
        {^dstcmpath}         項目を移動した後のサーバーパス (移動操作)。
        {^type}              項目のタイプ:
            ^D   ディレクトリ、
            ^B   バイナリファイル、
            ^F   テキストファイル、
            ^S   シンボリックリンク、
            ^X   Xlink。
        {^repository}        その項目のリポジトリ。
        {^status}            項目のステータス:
            ^A   追加済み、
            ^D   削除済み、
            ^M   移動済み、
            ^C   変更済み。
        {^fsprotection}      項目の権限を表示します (Linux/Mac chmod)。
        {^srcfsprotection}   親リビジョン項目の権限を表示します。
        {^newline}           改行を挿入します。

「^revid」に関するメモ:
    追加済みの項目については、「^baserevid」と「^parentrevid」は -1 になります。このケースでは
    前のリビジョンが存在しないためです。
    削除済みの項目については、「^revid」はソースリビジョンの ID になり、
    「^baserevid」は同期先リビジョンがないため -1 になります。
    Xlink については、「^baserevid」と「^parentrevid」は両方とも常に -1 になります。

例:

  次はブランチを比較しています。

    cm ^diff ^br:/main/task001
    cm ^diff ^br:/main/task001 \doc\readme.txt

  次は変更セットツリーを比較しています。

    cm ^diff 19
    cm ^diff 19 25
    cm ^diff ^cs:19 ^cs:25 --^format="{^path} {^parentrevid}"
    cm ^diff ^cs:19 ^cs:23 --^format="{^date} {^path}" --^dateformat="yy/dd/MM HH:mm:ss"
    cm ^diff ^cs:19 ^cs:23 --^changed
    cm ^diff ^cs:19 ^cs:23 --^repositorypaths
    cm ^diff ^cs:19 ^cs:23 --^download="D:\temp"
    cm ^diff ^cs:19 ^cs:23 --^clean
    cm ^diff ^cs:19 ^cs:23 \doc\readme.txt

  次はラベルツリーを比較しています。

    cm ^diff ^lb:FirstReleaseLabel ^lb:SecondReleaseLabel
    cm ^diff ^lb:tag_193.2 ^cs:34214
    cm ^diff ^cs:31492 ^lb:tag_193.2

  次はシェルブツリーを比較しています。

    cm ^diff ^sh:2
    cm ^diff ^sh:2 ^sh:4

  次はリビジョン指定を比較しています。
    cm ^diff ^rev:readme.txt#^cs:19 ^rev:readme.txt#^cs:20
    cm ^diff ^serverpath:/doc/readme.txt#^cs:19@myrepo \
        ^serverpath:/doc/readme.txt#^br:/main@myrepo@localhost:8084

== CMD_DESCRIPTION_DIFFMETRICS ==
2 つのリビジョン間の差分の指標を表示します。

== CMD_USAGE_DIFFMETRICS ==
使用方法:

    cm ^diffmetrics | ^dm <リビジョン指定 1> <リビジョン指定 2> [--^format=<文字列形式>]
                        [--^encoding=<名前>]
                        [--^ignore=(^eol | ^whitespaces | ^"eol&whitespaces" | ^none)]

    リビジョン指定    比較に使用したリビジョン。
                      (「cm ^help ^objectspec」を使用してリビジョン指定の詳細を確認できます。)

オプション:

    --^format          出力メッセージを特定の形式で取得します。詳細については
                      「備考」を参照してください。
    --^encoding        出力のエンコーディング (utf-8 など) を指定します。
                        サポートされるエンコーディングとその形式のテーブルを取得するには、
                        http://msdn.microsoft.com/en-us/library/system.text.encoding.aspx
                        にある MSDN のドキュメントを参照してください
                        (ページの最後、「名前」列)。
    --^ignore          指定された比較方法を設定します。
                      詳細については、「備考」を参照してください。

== CMD_HELP_DIFFMETRICS ==
備考:

    指標は、変更、追加、削除された行数です。

    このコマンドは、出力を表示する形式の文字列を受け取ります。
    このコマンドの出力パラメーターは次のとおりです。
        {0}             変更された行数。
        {1}             追加された行数。
        {2}             削除された行数。

例:

    cm ^diffmetrics file.txt#^cs:2 file.txt#^br:/main/scm0211 \
    --^format="変更された行数は {0}、追加された行数は {1}、削除された行数は {2} です。"
    (形式化された差分の指標の結果を受け取ります。)

    cm ^dm file.txt#^cs:2 file.txt#^cs:3 --^encoding=utf-8 --^ignore=^whitespaces

== CMD_DESCRIPTION_FASTEXPORT ==
リポジトリを高速エクスポート形式でエクスポートします。

== CMD_USAGE_FASTEXPORT ==
使用方法:

    cm ^fast-export | ^fe <リポジトリ指定> <高速エクスポートファイル>
                        [--^import-marks=<マークファイル>]
                        [--^export-marks=<マークファイル>]
                        [--^branchseparator=<文字セパレーター>]
                        [--^nodata] [--^from=<変更セット ID>] [--^to=<変更セット ID>]

オプション:

    リポジトリ指定      データのエクスポート元のリポジトリ。
                        (「cm ^help ^objectspec」を使用してリポジトリ指定の詳細を確認できます。)
    高速エクスポートファイル  Git 高速エクスポート形式のリポジトリデータがある
                        ファイル。
    --^import-marks      インクリメンタルインポートに使用されるマークファイル。このファイルは
                        以前に「--^export-marks」によってエクスポートされています。この
                        ファイルに記述されている変更セットは、すでに前のインポートに
                        入っていたためインポートされません。
    --^export-marks      インポートされた変更セットが保存されるファイル。
                        このファイルは後の高速インポートで、すでにインポート済みの
                        変更セットを知らせるために使用されます。
    --^branchseparator   Plastic SCM はブランチ階層のデフォルトのセパレーターとして
                        「/」を使用します。このオプションにより、文字を階層のセパレーターとして
                        使用できるため、main-task-sub は Plastic
                        SCM に /main/task/sub としてマップされます。
    --^nodata            データを含まないリポジトリをエクスポートします。これは
                        エクスポートが正しく実行されるかどうかを確認するのに役立ちます。
    --^from              特定の変更セットからエクスポートします。
    --^to                特定の変更セットにエクスポートします。

== CMD_HELP_FASTEXPORT ==
備考:

    - Plastic SCM リポジトリを Git にインポートするには、次のようなコマンドを使用します。
      ^cat repo.fe.00 | ^git ^fast-import --^export-marks=marks.git  --^import-marks=marks.git

    - インクリメンタルエクスポートは、以前にインポートされた変更セット
      (「--^import-marks」ファイルと「--^export-marks」ファイル) が含まれるマークファイルを使用することで
      サポートされます。
      これは、前の高速エクスポートでエクスポートされなかった新しい変更セットのみが
      エクスポートされることを意味します。

例:

    cm ^fast-export repo@localhost:8087 repo.fe.00 --^import-marks=marks.cm \
      --^export-marks=marks.cm
    (ローカルサーバーにあるリポジトリ「repo」を「repo.fe.00」ファイルに Git 高速エクスポート形式で
    エクスポートし、後でインクリメンタルエクスポートを実行するために
    マークファイルを作成します。)

    cm ^fast-export repo@localhost:8087 repo.fe.00 --^from=20
    (ローカルサーバーにあるリポジトリ「repo」を「repo.fe.00」ファイルに 
    Git 高速エクスポート形式で変更セット「20」からエクスポートします。)

== CMD_DESCRIPTION_FASTIMPORT ==
Git 高速エクスポートデータをリポジトリにインポートします。

== CMD_USAGE_FASTIMPORT ==
使用方法:

    cm ^fast-import | ^fi <リポジトリ指定> <高速エクスポートファイル>
                        [--^import-marks=<マークファイル>]
                        [--^export-marks=<マークファイル>]
                        [--^stats] [--^branchseparator=<文字セパレーター>]
                        [--^nodata] [--^ignoremissingchangesets] [--^mastertomain]

オプション:

    リポジトリ指定              データのインポート先となるリポジトリ。
                                前もって存在していない場合は
                                作成されます。(「'cm ^help ^objectspec'」を使用して
                                リポジトリ指定の詳細を確認できます。)
    fast-export-file            GIT 高速エクスポート形式のリポジトリデータ
                                があるファイル。
    --^import-marks              インクリメンタルインポートに使用されるマークファイル。
                                このファイルは以前に「--^export-marks'」によって
                                エクスポートされています。このファイルに記述されている
                                変更セットは、すでに前のインポートに
                                入っていたためインポートされません。
    --^export-marks             インポートされた変更セットが保存されるファイル。
                                このファイルは後の高速インポートで、
                                すでにインポート済みの変更セットを
                                知らせるために使用されます。
    --^stats                    インポートプロセスに関するいくつかの統計を出力します。
    --^branchseparator           Plastic SCM はブランチ階層のデフォルトの
                                セパレーターとして「/」を使用します。このオプションにより、
                                文字を階層のセパレーターとして使用できるため、main-task-sub
                                は Plastic SCM に /main/task/sub としてマップされます。
    --^nodata                    データを含めずに Git 高速エクスポートを
                                インポートします。これはインポートが正しく実行されるかどうかを
                                確認するのに役立ちます。
    --^ignoremissingchangesets   インポートできない変更セットは破棄され、
                                高速インポート操作はそれらの変更セット
                                なしで続行されます。
    --^mastertomain              「^master」ではなく「^main」を使用してインポートします。

== CMD_HELP_FASTIMPORT ==
備考:

    - git リポジトリをエクスポートするには、次のようなコマンドを使用します。
      ^git ^fast-export --^all -^M --^signed-tags=^strip --^tag-of-filtered-object=^drop> ..\git-fast-export.dat
      -^M オプションは移動された項目を検出するのに重要です。

    - 指定されたリポジトリが存在しなかった場合は作成されます。

    - インクリメンタルインポートは、以前にインポートされた変更セット
      (「--^import-marks」ファイルと「--^export-marks」ファイル) が含まれるマークファイルを使用することで
      サポートされます。
      これは、前の高速インポートでインポートされなかった新しい変更セットのみが
      インポートされることを意味します。

例:

    cm ^fast-import mynewrepo@atenea:8084  repo.fast-export
    (「repo.fast-export」ファイルにエクスポートされたコンテンツを
    サーバー「atenea:8084」上の「mynewrepo」リポジトリにインポートします。)

    cm ^fast-import repo@atenea:8084  repo.fast-export --^export-marks=rep.marks
    (「repo.fast-export」ファイルにエクスポートされたコンテンツを、
    サーバー「atenea:8084」上の「repo」リポジトリにインポートし、
    後でインクリメンタルインポートを実行するためにマークファイルを作成します。)

    cm ^fast-import repo@server:8084  repo.fast-export --^import-marks=repo.marks \
      --^export-marks=repo.marks
    (「repo.fast-export」ファイルのコンテンツをインポートします。マークファイルになかった
    新しい変更セットのみがインポートされます。次回の
    インクリメンタルインポートで変更セットのリストを再度保存するのに
    同じマークファイルが使用されます。

== CMD_DESCRIPTION_FILEINFO ==
ワークスペース内の項目に関する詳細情報を取得します。

== CMD_USAGE_FILEINFO ==
使用方法:

    cm ^fileinfo <項目パス>[ ...][--^fields=<フィールド値>[,...]]
                [[--^xml | -^x [=<出力ファイル>]] | [--^format=<文字列形式>]]
                [--^symlink] [--^encoding=<名前>]

    項目パス            表示する項目。空白を使用して項目を
                        区切ります。
                        空白が含まれるパスを指定するには
                        二重引用符 (" ") を使用します。

オプション:

    --^fields            コンマ区切りの値の文字列。これは、各項目で
                        どのフィールドを出力するかを選択します。詳細については、「備考」を
                        参照してください。
    --^xml | -^x          出力を XML 形式で標準出力に出力します。
                        出力ファイルを指定することができます。このオプションを
                        「--^format」と組み合わせることはできません。
    --^format            出力メッセージを特定の形式で取得します。詳細については
                        「備考」を参照してください。このオプションを「--^xml」と
                        組み合わせることはできません。
                        両方が指定された場合、この「--^format」オプションは「--^fields」よりも
                        優先されます。
    --^symlink           ファイル情報操作をターゲットではなくシンボリックリンクに
                        適用します。
    --^encoding          出力のエンコーディング (utf-8 など) を指定します。
                        サポートされるエンコーディングとその形式のテーブルを取得するには、
                        http://msdn.microsoft.com/en-us/library/system.text.encoding.aspx
                        にある MSDN のドキュメントを参照してください
                        (ページの最後、「名前」列)。


== CMD_HELP_FILEINFO ==
備考:

    このコマンドは、選択された各項目の詳細な属性のリストを出力します。
    各属性はデフォルトで新しい行に出力されます。

    属性のリストは、ユーザーが必要とする属性のみを表示するよう
    変更できます。これは、「--^fields=<フィールドリスト>」を使用することで実現できます。ここでは
    コンマ区切りの属性名の文字列を受け取ります。この方法により、それらの属性のうち
    名前が指定されている属性のみが表示されます。

    リビジョンヘッドの変更セット:

    このオプションはデフォルトでは無効になっています。この属性を取得するのは
    他の残りの属性を取得するよりも大幅に時間がかかるため、ユーザーにはできるだけ多くの項目を
    グループ化することをお勧めしています。これにより、
    数多くの「cm ^fileinfo」を別々に実行するのを回避することで、実行時間が改善されます。
    また、この機能は現在、管理対象ディレクトリでは利用できません。

    以下で利用できる属性名の全一覧を確認できます。
    アスタリスク (「*」) 付きの名前はデフォルトでは表示されません。
        ^ClientPath              その項目のディスク上のローカルパス。
        ^RelativePath            ワークスペースに対する相対パス。
        ^ServerPath              その項目のリポジトリパス。
                                (注: トランスフォームされているワークスペースは
                                このオプションでは現在サポートされていません。)
        ^Size                    項目のサイズ。
        ^Hash                    項目のハッシュの合計。
        ^Owner                   その項目が属するユーザー。
        ^RevisionHeadChangeset   (*) ブランチのヘッド変更セットにロードされた
                                リビジョンの変更セット。
                                (上の注記を参照。)
        ^RevisionChangeset       ワークスペースに現在ロードされているリビジョンの
                                変更セット。
        ^RepSpec                 その項目のリポジトリ指定。
                                (「cm ^help ^objectspec」を使用してリポジトリ指定の詳細を
                                確認できます。)
        ^Status                  ワークスペース項目のステータス (追加済み、チェックアウト済み、
                                削除済みなど)。
        ^Type                    リビジョンタイプ (テキスト、バイナリ、ディレクトリ、シンボリックリンク、
                                または不明)。
        ^Changelist              その項目が属する変更リスト (ある場合)。
        ^IsLocked                (*) その項目が排他的チェックアウトによって
                                ロックされているかどうか。
        ^LockedBy                (*) その項目を排他的チェックアウトしたユーザー。
        ^LockedWhere             (*) その項目が排他的チェックアウトされた
                                場所。
        ^IsUnderXlink            その項目が Xlink の下に
                                あるかどうか。
        ^UnderXlinkTarget        その項目が下にある Xlink のターゲット
                                (ある場合)。
        ^UnderXlinkPath          Xlink でリンクされたリポジトリ内の項目サーバーパLibrary\Bee\artifacts\mvdfrm\UnityEngine.TestRunner.ref.dll_E55D0F7C63F01D9E.mvfrm
Library\Bee\artifacts\mvdfrm\UnityEditor.Graphs.dll_B13857CF6B647FE2.mvfrm
Library\Bee\artifacts\mvdfrm\UnityEditor.CoreModule.dll_F1AF3067332BA5B0.mvfrm
Library\Bee\artifacts\mvdfrm\UnityEditor.DeviceSimulatorModule.dll_0BCC777D0C046711.mvfrm
Library\Bee\artifacts\mvdfrm\UnityEditor.DiagnosticsModule.dll_ABDDEDD0EB2EED1F.mvfrm
Library\Bee\artifacts\mvdfrm\UnityEditor.dll_DB05EC16BFE614