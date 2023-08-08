��ブ済みであるかどうかを検出し、
      ユーザーにファイルの場所を入力するよう求めます。
      ユーザーは、アーカイブ済みのデータが置かれている場所のパスが含まれる
      externaldata.conf という名前のファイルを (標準の設定ファイルの場所に、
      client.conf に適用されるのと同じルールを使用して) 作成することで、
      外部データの場所を設定できます。

    - サーバーから: この方法では、リクエストはサーバーによって透過的に解決されるため、
      ユーザーはデータがアーカイブ済みであるかどうかを知っている必要が
      ありません。このようにするには、管理者がサーバーディレクトリに
       externaldata.conf という名前のファイルを作成し、そこに
      アーカイブ済みのボリュームがあるパスを入力します。

    リビジョン (またはリビジョンのセット) のアーカイブを解除 (復元) するには、そのアーカイブ済みの
    ファイルにクライアントからアクセスできる必要があります。このため、サーバー (方法 2) によって
    解決されているデータのアーカイブを解除することはできません。クライアントが
    それがアーカイブ済みであることを識別できないためです。方法 2 が使用された場合、
    アーカイブを正常に解除するには、先に管理者が
    externaldata.conf サーバーファイルを編集し、アーカイブを解除する必要があるアーカイブ済みの
    ファイルへのアクセスを削除する必要があります。

    PLASTICEDITOR 環境変数を設定して、コメントを入力するエディターを
    指定します。

例:

    cm ^archive bigfile.zip#^br:/main
    (ブランチ 'main' にある 'bigfile.zip' の最新のリビジョンをアーカイブします。)

    cm ^archive ^rev:myfile.pdf#^cs:2 -^c="大きな PDF ファイル" --^file=c:\arch_files\arch
    (myfile.pdf の変更セット 2 でのリビジョンを 'c:\archived_files' フォルダーに
    アーカイブします。アーカイブ済みのファイルの名前は 'arch' で始まる必要があります (例: arch_11_56)。)

    cm ^find "^revs ^where ^size > 26214400" --^format="{^item}#{^branch}" \
      --^nototal | cm ^archive --^comment="volume00" --^file="volume00" -
    (名前が 'volume00' で始まる、サイズが 25 Mb 以上のファイルをすべて
    アーカイブします。)

    cm ^find "^revs ^where ^size > 26214400 ^and ^archived='true'" \
      --^format="{^item}#{^branch}" --^nototal | cm ^archive --^restore
    (サイズが 25 Mb 以上のアーカイブ済みのファイルをすべて復元します。)

== CMD_DESCRIPTION_ATTRIBUTE ==
ユーザーが属性を管理できるようにします。

== CMD_USAGE_ATTRIBUTE ==
使用方法:

    cm ^attribute | ^att <コマンド> [オプション]

コマンド:

    ^create | ^mk
    ^delete | ^rm
    ^set
    ^unset
    ^rename
    ^edit

    各コマンドの詳細情報を取得するには、次のコマンドを実行します:
    cm ^attribute <コマンド> --^usage
    cm ^attribute <コマンド> --^help

== CMD_HELP_ATTRIBUTE ==
例:

    cm ^attribute ^create ステータス
    cm ^attribute ^set ^att:status ^br:/main/SCM105 未処理
    cm ^attribute ^unset ^att:status ^br:/main/SCM105
    cm ^attribute ^delete ^att:status
    cm ^attribute ^rename ^att:status "ビルドステータス"
    cm ^attribute ^edit ^att:status "CI パイプライン内のタスクのステータス"

== CMD_DESCRIPTION_CHANGELIST ==
変更リスト内のグループの保留中の変更。

== CMD_USAGE_CHANGELIST ==
使用方法:

    a) 変更リストのオブジェクトの管理:

       cm ^changelist | ^clist [--^symlink]
       (すべての変更リストを表示します。)

       cm ^changelist | ^clist ^add <変更リスト名>
          [<変更リスト説明>] [--^persistent | --^notpersistent] [--^symlink]
       (変更リストを作成します。)

       cm ^changelist | ^clist ^rm <変更リスト名> [--^symlink]
       (選択された変更リストを削除します。この変更リストに保留中の変更が含まれている
       場合、それらは ^default 変更リストに移動されます。)

       cm ^changelist | ^clist ^edit <変更リスト名> [<アクション名> <アクション値>]
                             [--^persistent | --^notpersistent] [--^symlink]
       (選択された変更リストを編集します。)

    b) 指定の変更リストのコンテンツの管理:

       cm ^changelist | ^clist <変更リスト名> (^add | ^rm) <パス名>[ ...]
                             [--^symlink]
       (指定されたパス名と一致する変更を追加 ('^add') または削除 ('^rm') することで、
       選択された変更リストを追加または削除します。空白を使用して
       パス名を区切ります。空白が含まれるパスを指定するには
       二重引用符 (" ") を使用します。パスのステータスは、'^Added' または '^Checked-out' である必要があります。)

オプション:

    変更リスト名        変更リストの名前。
    変更リスト説明      変更リストの説明。
    アクション名        変更リストを編集するのに '^rename' か '^description' の間から
                        選択します。
    アクション値        変更リストを編集中に、新しい名前または新しい説明を
                        適用します。
    --^persistent        そのコンテンツがチェックインまたは元に戻されている場合でも、
                        変更リストはワークスペース内に残ります。
    --^notpersistent     (デフォルト) そのコンテンツがチェックインまたは元に戻されている
                        場合でも、変更リストはワークスペース内に
                        残りません。
    --^symlink           操作をターゲットではなくシンボリックリンクに
                        適用します。

== CMD_HELP_CHANGELIST ==
備考:

    '^changelist' コマンドは、ワークスペースの保留中の変更と、変更リストに
    含まれている変更の両方を処理します。

例:

    cm ^changelist
    (現在のワークスペースの変更リストを表示します。)

    cm ^changelist ^add 設定変更 "dotConf ファイル" --^persistent
    (「設定変更」という名前の新しい変更リストと「dotConf
    ファイル」という名前の説明を作成します。その保留中の変更リストがチェックインまたは元に戻されると、
    現在のワークスペースに永続的に残ります。)

    cm ^changelist ^edit 設定変更 ^rename 設定ファイル --^notpersistent
    (「設定変更」という名前の変更リストを編集し、その名前を「設定ファイル」に
    変更します。また、その変更リストを「非永続的」になるように変更します。)
        
    cm ^changelist ^edit 設定変更 --^notpersistent
    (「設定変更」という名前の変更リストを編集し、それを「非永続的」になるように変更します。)

    cm ^changelist ^rm 設定ファイル
    (保留中の変更リスト「設定ファイル」を現在のワークスペースから削除します。)

    cm ^changelist 設定ファイル ^add foo.conf
    (ファイル「foo.conf」を「設定ファイル」変更リストに追加します。)

    cm ^changelist 設定ファイル ^rm foo.conf readme.txt
    (ファイル「foo.conf」と「readme.txt」を「設定ファイル」
    変更リストから削除し、それらのファイルをシステムのデフォルトの変更リストに移動します。)

== CMD_DESCRIPTION_CHANGESET ==
変更セットに対して高度な操作を実行します。

== CMD_USAGE_CHANGESET ==
使用方法:

    cm ^changeset <コマンド> [オプション]

コマンド:

    ^move        | ^mv
    ^delete      | ^rm
    ^editcomment | ^edit

    各コマンドの詳細情報を取得するには、次のコマンドを実行します:
    cm ^changeset <コマンド> --^usage
    cm ^changeset <コマンド> --^help

== CMD_HELP_CHANGESET ==
例:

    cm ^changeset ^move ^cs:15@myrepo ^br:/main/scm005@myrepo
    cm ^changeset ^delete ^cs:2b55f8aa-0b29-410f-b99c-60e573a309ca@devData

== CMD_DESCRIPTION_CHANGESET_EDIT_COMMENT ==
変更セットのコメントを変更します。

== CMD_USAGE_CHANGESET_EDIT_COMMENT ==
使用方法:

    cm ^changeset ^editcomment | ^edit <変更セット指定> <新しいコメント>

オプション:

    変更セット指定      コメントが編集されるターゲット変更セット。
                        (「cm ^help ^objectspec」を使用して変更セット指定の詳細を
                        確認できます。)
    新しいコメント      ターゲットの変更セットに追加される新しい
                        コメント。

== CMD_HELP_CHANGESET_EDIT_COMMENT ==
備考:

    - ターゲットの変更セット指定が有効である必要があります。

例:

    cm ^changeset ^editcomment ^cs:15@myrepo "チェックインの詳細を追加するのを忘れていました"
    cm ^changeset ^edit ^cs:cb11ecdb-1aa9-4f11-8698-dcab14e5885a \
         "このコメントテキストが前のコメントに置き換わります。"

== CMD_DESCRIPTION_CHANGESET_MOVE ==
変更セットとそのすべての子孫を別のブランチに移動します。

== CMD_USAGE_CHANGESET_MOVE ==
使用方法:

    cm ^changeset ^move | ^mv <変更セット指定> <ブランチ指定>

オプション:

    変更セット指定      別のブランチに移動される最初の変更セット。同じ
                        ブランチ内のすべての子孫の変更セットも同様に
                        このコマンドのターゲットになります。
                        (「cm ^help ^objectspec」を使用して変更セット指定の詳細を
                        確認できます。)
    ブランチ指定        ターゲットの変更セットが格納されるターゲット
                        ブランチ。空であるか存在していない必要があります。
                        同期先ブランチが存在しない場合は、そのコマンドによって
                        作成されます。
                        ('cm ^help ^objectspec' を使用してブランチ指定の詳細を
                        確認できます。)

== CMD_HELP_CHANGESET_MOVE ==
備考:

    - ターゲットの変更セット指定が有効である必要があります。
    - 同期先ブランチは空であるか存在していない必要があります。
    - 同期先ブランチが存在しない場合は、作成されます。
    - マージリンクはブランチの影響を受けないため、変更されません。

例:

    cm ^changeset ^move ^cs:15@myrepo ^br:/main/scm005@myrepo
    cm ^changeset ^move ^cs:cb11ecdb-1aa9-4f11-8698-dcab14e5885a ^br:/hotfix/TL-352

== CMD_DESCRIPTION_CHANGESET_DELETE ==
変更セットをリポジトリから削除します。

== CMD_USAGE_CHANGESET_DELETE ==
使用方法:

    cm ^changeset ^delete | ^rm <変更セット指定>

オプション:

    変更セット指定      削除されるターゲット変更セット。特定の条件の一部を
                       満たしている必要があります。詳細については、「備考」を参照してください。
                       (「cm ^help ^objectspec」を使用して変更セット指定の詳細を
                        確認できます。)

== CMD_HELP_CHANGESET_DELETE ==
備考:

    - ターゲット変更セットは、そのブランチ内で最後である必要があります。
    - ターゲット変更セットは、その他の変更セットの親であってはなりません。
    - ターゲット変更セットは、マージリンクのソースであっても、ソースとしての
      間隔マージの一部であってもなりません。
    - ターゲット変更セットに、ラベルが適用されていてはなりません。
    - ターゲット変更セットは、ルート変更セット ('^cs:0') であってはなりません。

例:

    cm ^changeset ^rm ^cs:4525@myrepo@myserver
    cm ^changeset ^delete ^cs:cb11ecdb-1aa9-4f11-8698-dcab14e5885a

== CMD_DESCRIPTION_CHANGEUSERPASSWORD ==
ユーザーパスワード (UP) を変更します。

== CMD_USAGE_CHANGEUSERPASSWORD ==
使用方法:

    cm ^changepassword | ^passwd

== CMD_HELP_CHANGEUSERPASSWORD ==
備考:

    このコマンドは、セキュリティ設定が UP (ユーザー/パスワード) のときにのみ
    使用できます。詳細については、管理ガイドを確認してください。
    新旧のパスワードが必要です。

例:

    cm ^passwd

== CMD_DESCRIPTION_CHECKCONNECTION ==
サーバーへの接続を確認します。

== CMD_USAGE_CHECKCONNECTION ==
使用方法:

      cm ^checkconnection | ^cc

== CMD_HELP_CHECKCONNECTION ==
備考:

    - このコマンドは、設定された Plastic SCM サーバーへの有効な接続が
      あるかどうかを示すメッセージを返します。
    - コマンドは、設定されたユーザーが有効であるかどうかを確認します。また、
      サーバーのバージョンの互換性を確認します。

== CMD_DESCRIPTION_CHECKDB ==
リポジトリの整合性を確認します。

== CMD_USAGE_CHECKDB ==
使用方法:

    cm ^checkdatabase | ^chkdb [<リポジトリサーバー指定> | <リポジトリ指定>]

'cm ^help ^objectspec' を使用してリポジトリサーバー指定とリポジトリ指定の詳細を確認できます。

== CMD_HELP_CHECKDB ==
備考:

    - リポジトリサーバー指定もリポジトリ指定も指定されていない場合、
      client.conf ファイルで指定されたサーバーでチェックが行われます。

例:

    cm ^checkdatabase ^repserver:localhost:8084
    cm ^chkdb ^rep:default@localhost:8084

== CMD_DESCRIPTION_CHECKIN ==
変更をリポジトリに格納します。

== CMD_USAGE_CHECKIN ==
使用方法:

    cm ^checkin | ^ci [<項目パス>[ ...]]
        [-^c=<コメント文字列> | -^commentsfile=<コメントファイル>]
        [--^all|-^a] [--^applychanged] [--^private] [--^update] [--^symlink]
        [--^noshowchangeset]
        [--^machinereadable [--^startlineseparator=<セパレーター>]
          [--^endlineseparator=<セパレーター>] [--^fieldseparator=<セパレーター>]]

オプション:

    項目パス             チェックインされる項目。空白が含まれるパスを指定するには
                          二重引用符 (" ") を使用します。空白を使用して
                          項目パスを区切ります。
                          チェックインを現在のディレクトリに適用するには、. を使用します。
    -^c                    指定されたコメントをチェックイン操作で作成された
                          変更セットに適用します。
    -^commentsfile         指定されたファイル内のコメントをチェックイン操作で
                          作成された変更セットに適用します。
    --^all | -^a            指定されたパスでローカルに変更、移動、および削除された
                          項目も含めます。
    --^applychanged        チェックアウト済みの項目とともにワークスペースで
                          検出された変更済み項目にチェックイン操作を
                          適用します。
    --^private             ワークスペースで検出された非公開の項目も
                          含まれます。
    --^update              最終的に発生する場合は、更新/マージを自動的に
                          処理します。
    --^symlink             チェックイン操作をターゲットではなくシンボリックリンクに
                          適用します。
    --^noshowchangeset     結果の変更セットを出力しません。
    --^machinereadable     結果を解析しやすい形式で出力します。
    --^startlineseparator  '--^machinereadable' フラグとともに使用され、その行をどのように開始する
                          必要があるかを指定します。
    --^endlineseparator    '--^machinereadable' フラグとともに使用され、その行をどのように終了する
                          必要があるかを指定します。
    --^fieldseparator      '--^machinereadable' フラグとともに使用され、そのフィールドをどのように区切る
                          必要があるかを指定します。

== CMD_HELP_CHECKIN ==
備考:

    - <項目パス>が指定されていない場合、チェックインにはそのワークスペース内の
      すべての保留中の変更が関与します。
    - チェックイン操作は常に指定されたパスから再帰的に適用されます。
    - 項目をチェックインするには:
      - 項目がソースコード管理の対象になっている必要があります。
      - 項目が非公開の (ソースコード管理の対象でない) 場合、チェックイン
        するには --^private フラグが必須です。
      - 項目がチェックアウトされている必要があります。
      - 項目が変更されているもののチェックアウトされていない場合、<項目パス> が
        ディレクトリであるか、ワイルドカード ('*') が含まれている場合を除き、--^applychanged フラグは
        不要です。

    チェックインするにはリビジョンコンテンツが前のリビジョンと異なっている必要が
    あります。

    PLASTICEDITOR 環境変数を設定して、コメントを入力するエディターを
    指定します。

stdin から入力を読み取る:

    '^checkin' コマンドは stdin からパスを読み取ることができます。これを行うには、シングル
    ダッシュ「-」を渡します。
    例: cm ^checkin -

    パスは空の行が入力されるまで読み取られます。
    これにより、パイプを使用してチェックインするファイルを指定できます。
    例:
      dir /S /B *.c | cm ^checkin --^all -
      (Windows で、すべての .c ファイルをワークスペースにチェックインします。)

例:

    cm ^checkin file1.txt file2.txt
    ('file1.txt' と 'file2.txt' のチェックアウト済みのファイルをチェックインします。)

    cm ^checkin .-^commentsfile=mycomment.txt
    (現在のディレクトリをチェックインし、'mycomment.txt' ファイルに
    コメントを設定します。)

    cm ^checkin リンク --^symlink
    (ターゲットではなく「リンク」ファイルをチェックインします。UNIX 環境で
    有効です。)

    cm ^ci file1.txt -^c="my comment"
    ('file1.txt' をチェックインし、コメントを含めます。)

    cm ^status --^short --^compact --^changelist=レビュー待ち | cm ^checkin -
    (「レビュー待ち」という名前の変更リスト内のパスをリストし、このリストを
    チェックインコマンドの入力にリダイレクトします。)

    cm ^ci .--^machinereadable
    (現在のディレクトリをチェックインし、その結果を簡略化された、
    より解析しやすい形式で出力します。)

    cm ^ci .--^machinereadable --^startlineseparator=">" --^endlineseparator="<" --^fieldseparator=","
    (現在のディレクトリをチェックインし、その結果を簡略化された、
    より解析しやすい形式で出力します。指定された文字列で
    行を開始および終了し、フィールドを区切ります。)

== CMD_DESCRIPTION_CHECKOUT ==
ファイルを変更準備完了としてマーク�