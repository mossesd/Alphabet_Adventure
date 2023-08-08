�認してください。

stdin から入力を読み取る:

    '^checkout' コマンドは stdin からパスを読み取ることができます。これを行うには、シングル
    ダッシュ「-」を渡します。
    例: cm ^checkout -

    パスは空の行が入力されるまで読み取られます。
    これにより、パイプを使用してチェックアウトするファイルを指定できます。
    例:
      dir /S /B *.c | cm ^checkout -
      (Windows で、すべての .c ファイルをワークスペースにチェックアウトします。)

例:

    cm ^checkout file1.txt file2.txt
    ('file1.txt' と 'file2.txt' のファイルをチェックアウトします。)

    cm ^co *.txt
    (すべての txt ファイルをチェックアウトします。)

    cm ^checkout .
    (現在のディレクトリをチェックアウトします。)

    cm ^checkout -^R c:\workspace\src
    ('src' フォルダーを再帰的にチェックアウトします。)

    cm ^co file.txt --^format="項目 {0} をチェックアウトしています"
        --^errorformat="項目 {0} のチェックアウト中にエラーが発生しました" /
        --^resultformat="項目 {0} をチェックアウトしました"
    (指定された形式化文字列を使用して 'file.txt' をチェックアウトし、
    進捗、結果、操作のエラーを表示します。)

    cm ^checkout リンク --^symlink
    (ターゲットにではなく 'リンク' ファイルをチェックアウトします。UNIX 環境で
    有効です。)

    cm ^checkout .-^R --^ignorefailed
    (現在のフォルダーをチェックアウトします。チェックアウトできないファイルは
    無視されます。)

    cm ^co .--^machinereadable --^startlineseparator=">"
    (現在のディレクトリをチェックアウトし、その結果を簡略化された、
    より解析しやすい形式で出力します。指定された文字列で行を開始します。)

== CMD_DESCRIPTION_CHECKSELECTORSYNTAX ==
セレクターの構文をチェックします。

== CMD_USAGE_CHECKSELECTORSYNTAX ==
使用方法:

    cm ^checkselectorsyntax | ^css --^file=<セレクターファイル>
    (セレクターファイルの構文をチェックします。)

    ^cat <セレクターファイル> | cm ^checkselectorsyntax | ^css -
    (Unix。標準の入力からセレクターファイルをチェックします。)

    ^type <セレクターファイル> | cm ^checkselectorsyntax | ^css -
    (Windows。標準の入力からセレクターファイルをチェックします。)


    --^file     セレクターの読み取り元のファイル。

== CMD_HELP_CHECKSELECTORSYNTAX ==
備考:

    このコマンドはファイルまたは標準の入力のいずれかのセレクターを読み取り、
    有効な構文であることをチェックします。構文チェックに合格しなかった場合、その理由が
    標準出力に出力されます。

例:

    cm ^checkselectorsyntax --^file=myselector.txt
    ('myselector.txt' ファイルの構文をチェックします。)

    ^cat myselector.txt | cm ^checkselectorsyntax
    (標準の入力から 'myselector.txt' の構文をチェックします。)

== CMD_DESCRIPTION_CHGREVTYPE ==
項目のリビジョンタイプ (バイナリまたはテキスト) を変更します。

== CMD_USAGE_CHGREVTYPE ==
使用方法:

    cm ^changerevisiontype | ^chgrevtype | ^crt <項目パス>[ ...]--^type=(^bin | ^txt)

    項目パス            リビジョンタイプを変更する項目。空白が含まれるパスを指定するには
                        二重引用符 (" ") を使用します。空白を使用して
                        項目パスを区切ります。
    --^type              ターゲットリビジョンタイプ。'^bin' または '^txt' を選択します。

== CMD_HELP_CHGREVTYPE ==
備考:

    このコマンドはディレクトリではなく、ファイルにのみ適用できます。
    指定されたタイプはシステムでサポート対象の「^bin」または「^txt」(バイナリ
    またはテキスト) である必要があります。

例:

    cm ^changerevisiontype c:\workspace\file.txt --^type=^txt
    (「file.txt」リビジョンタイプをテキストに変更します。)

    cm ^chgrevtype comp.zip "image file.jpg" --^type=^bin
    (「comp.zip」と「image file.jpg」リビジョンタイプをバイナリに変更します。)

    cm ^crt *.* --^type=^txt
    (すべてのファイルのリビジョンタイプをテキストに変更します。)

== CMD_DESCRIPTION_TRIGGER_EDIT ==
トリガーを編集します。

== CMD_USAGE_TRIGGER_EDIT ==
使用方法:

    cm ^trigger | ^tr ^edit <サブタイプのタイプ> <位置番号>
                         [--^position=<新しい位置>]
                         [--^name=<新しい名前>] [--^script=<スクリプトパス>]
                         [--^filter=<文字列フィルター>] [--^server=<リポジトリサーバー指定>]

    サブタイプのタイプ  トリガー実行とトリガー操作。
                        トリガータイプのリストを表示するには「cm ^showtriggertypes」
                        と入力します。
    位置番号            変更されるトリガーが占める位置。

オプション:

    --^position          指定されたトリガーの新しい位置。
                        この位置は、同じタイプの別のトリガーによって使用中でない
                        必要があります。
    --^name              指定されたトリガーの新しい名前。
    --^script            指定されたトリガースクリプトの新しい実行パス。
                        スクリプトが「^webtrigger」で始まる場合、それは
                        ウェブトリガーと見なされます。詳細については、「備考」を
                        参照してください。
    --^filter            指定されたフィルターに一致する項目のみをチェックします。
    --^server            指定されたサーバーのトリガーを編集します。
                        サーバーが指定されていない場合は、クライアントに設定されている
                        サーバーでコマンドを実行します。
                        (「cm ^help ^objectspec」を使用してサーバー指定の
                        詳細を確認できます。)

== CMD_HELP_TRIGGER_EDIT ==
備考:

    ウェブトリガー: ウェブトリガーは、「^webtrigger <ターゲット URI>」をトリガーコマンド
    として入力することで作成します。この場合、トリガーは指定された URI に対して 
    POST クエリを実行します。リクエスト本文には、JSON ディクショナリと
    トリガー環境変数、および文字列の配列を指す
    固定の入力キーが含まれます。

例:

    cm ^trigger ^edit ^after-setselector 6 --^name="Backup2 マネージャー" --^script="/new/path/al/script"
    cm ^tr ^edit ^before-mklabel 7 --^position=4 --^server=myserver:8084
    cm ^trigger ^edit ^after-add 2 --^script="^webtrigger http://myserver.org/api"

== CMD_DESCRIPTION_CODEREVIEW ==
コードレビューを作成、編集、削除します。

== CMD_USAGE_CODEREVIEW ==
使用方法:

    cm ^codereview <指定> <タイトル> [--^status=<ステータス名>]
                [--^assignee=<ユーザー名>] [--^format=<文字列形式>]
                [--^repository=<リポジトリ指定>]
    (コードレビューを作成します。)

    cm ^codereview -^e <ID> [--^status=<ステータス名>] [--^assignee=<ユーザー名>]
                [--^repository=<リポジトリ指定>]
    (コードレビューを編集します。)

    cm ^codereview -^d <ID> [ ...][--^repository=<リポジトリ指定>]
    (1 つ以上のコードレビューを削除します。)


    指定                変更セット指定またはブランチ指定のいずれかにできます。
                        それが新しいコードレビューのターゲットになります。(
                        「cm ^help ^objectspec」を使用して変更セット指定またはブランチ指定の
                        詳細を確認できます。)
    タイトル            新しいコードレビューのタイトルとして使用される
                        テキスト文字列。
    ID                  コードレビューの識別番号。GUID を使用することも
                        できます。

オプション:

    -^e                  既存のコードレビューのパラメーターを編集します。
    -^d                  1 つ以上の既存のコードレビューを削除します。空白を
                        使用してコードレビューの ID を区切ります。
    --^status            コードレビューの新しいステータスを設定します。詳細については、「備考」を
                        参照してください。
    --^assignee          コードレビューの新しい担当者を設定します。
    --^format            出力メッセージを特定の形式で取得します。詳細については
                        「備考」を参照してください。
    --^repository        デフォルトとして使用されるリポジトリを設定します。(
                        「cm ^help ^objectspec」を使用してリポジトリ指定の詳細を
                        確認できます。)

== CMD_HELP_CODEREVIEW ==
備考:

    このコマンドにより、ユーザーはコードレビューを管理できます。変更セットまたはブランチの
    コードレビューを作成、編集、削除します。

    新しいコードレビューを作成するには、変更セット指定/ブランチ指定とタイトルが
    必須です。初期ステータスと担当者も設定できます。ID (または
    リクエストされた場合は GUID) が結果として返されます。

    既存のコードレビューを編集または削除するには、ターゲットのコードレビューの ID
    (または GUID) が必要です。エラーがない場合、メッセージは表示されません。

    ステータスパラメーターは、「^Under review」
    (デフォルト)、「^Reviewed」、または「^Rework required」のいずれかのみになります。

    リポジトリパラメーターでは、デフォルトの作業リポジトリを
    設定できます。これは、現在のワークスペースに関連付けられているサーバーとは
    別のサーバーのレビューを管理するときや、現在のワークスペースが
    まったくないときに便利です。

    出力形式のカスタマイズ:

    このコマンドは、出力を表示する形式の文字列を受け取ります。
    このコマンドの出力パラメーターは次のとおりです。
        {0}             ID
        {1}             GUID

    「--^format」パラメーターは、新しいコードレビューを作成しているときにのみ有効であることに
    注意してください。

例:

    cm ^codereview ^cs:1856@myrepo@myserver:8084 "My code review" --^assignee=dummy
    cm ^codereview ^br:/main/task001@myrepo@myserver:8084 "My code review" \
    --^status=^"Rework required" --^assignee=新入り --^format="{^id} -> {^guid}"

    cm ^codereview 1367 -^e --^assignee=新しい担当者
    cm ^codereview -^e 27658884-5dcc-49b7-b0ef-a5760ae740a3 --^status=レビュー済み

    cm ^codereview -^d 1367 --^repository=myremoterepo@myremoteserver:18084
    cm ^codereview 27658884-5dcc-49b7-b0ef-a5760ae740a3 -^d

== CMD_DESCRIPTION_CRYPT ==
パスワードを暗号化します。

== CMD_USAGE_CRYPT ==
使用方法:

    cm ^crypt <自分のパスワード>

    自分のパスワード    暗号化されるパスワード。

== CMD_HELP_CRYPT ==
備考:

    このコマンドは、引数として渡された指定のパスワードを暗号化します。
    これは、設定ファイル内のパスワードを暗号化し、安全性を高めるように
    設計されています。

例:

    cm ^crypt dbconfpassword -> ENCRYPTED: encrypteddbconfpassword
    (データベース設定ファイル「db.conf」内のパスワードを暗号化します。)

== CMD_DESCRIPTION_DEACTIVATEUSER ==
ライセンスが付与されたユーザーのアクティベートを解除します。

== CMD_USAGE_DEACTIVATEUSER ==
使用方法:

    cm ^deactivateuser | ^du <ユーザー名>[ ...][--^server=<名前:ポート>]
                           [--^nosolveuser]

    ユーザー名          アクティベートを解除するユーザーの名前。空白を使用して
                        ユーザー名を区切ります。
                        SID の場合は、「--^nosolveuser」が必須です。

オプション:

    --^server            指定されたサーバー上のユーザーのアクティベートを解除します。
                        サーバーが指定されていない場合は、クライアントに設定されている
                        サーバーでコマンドを実行します。
    --^nosolveuser       このオプションを使用すると、コマンドはそのユーザー名が認証システム上に
                        存在するかどうかをチェックしません。その
                        <ユーザー名> はユーザー SID である必要があります。

== CMD_HELP_DEACTIVATEUSER ==
備考:

    このコマンドはユーザーを非アクティブに設定し、そのユーザーが Plastic SCM を
    使用できなくなります。

    Plastic SCM ユーザーのアクティベート解除の詳細については、「cm ^activateuser」コマンドを
    参照してください。

    このコマンドは、そのユーザーが基盤の認証システム (例: ActiveDirectory、LDAP、ユーザー/パスワード...) 上に
    存在するかどうかをチェックします。
    認証システム上に存在しなくなったユーザーのアクティベート解除を
    適用するには、「--^nosolveuser」オプションを使用できます。

例:

    cm ^deactivateuser john
    cm ^du peter "mary collins"
    cm ^deactivateuser john --^server=myserver:8084
    cm ^deactivateuser S-1-5-21-3631250224-3045023395-1892523819-1107 --^nosolveuser

== CMD_DESCRIPTION_DIFF ==
ファイル、変更セット、ラベル間の差分を表示します。

== CMD_USAGE_DIFF ==
使用方法:

    cm ^diff <変更セット指定> | <ラベル指定> | <シェルブ指定> [<変更セット指定> | <ラベル指定> | <シェルブ指定>]
            [<パス>]
            [--^added] [--^changed] [--^moved] [--^deleted]
            [--^repositorypaths] [--^download=<ダウンロードのパス>]
            [--^encoding=<名前>]
            [--^ignore=(^eol | ^whitespaces | ^"eol&whitespaces" | ^none)]
            [--^clean]
            [--^format=<文字列形式>] [--^dateformat=<文字列形式>]

        「ソース」変更セットまたはシェルブセットと、「同期先」変更セット
        またはシェルブセットの間の差分を表示します。変更セットは、変更セット指定
        またはラベル指定のいずれかを使用して指定できます。
        2 つの指定が指定される場所では、最初の指定が差分の「ソース」になり、
        2 つ目の指定が「同期先」になります。
        1 つの指定のみが指定された場合、その「ソース」が指定された「同期先」の
        親変更セットになります。
        オプションのパスが指定された場合、差分ウィンドウが起動し、
        そのファイルの 2 つのリビジョン間の差分が表示されます。

    cm ^diff <リビジョン指定 1> <リビジョン指定 2>

        リビジョンのペア間の差分を表示します。その差分は
        差分ウィンドウに表示されます。指定された最初のリビジョンが
        左に表示されます。

    cm ^diff <ブランチ指定> [--^added] [--^changed] [--^moved] [--^deleted]
            [--^repositorypaths] [--^download=<ダウンロードのパス>]
            [--^encoding=<名前>]
            [--^ignore=(^eol | ^whitespaces | ^"eol&whitespaces" | ^none)]
            [--^clean]
            [--^format=<文字列形式>] [--^dateformat=<文字列形式>]
            [--^fullpaths | --^fp]

        ブランチの差分を表示します。

    (「cm ^help ^objectspec」を使用して指定の詳細を確認できます。)

オプション:

    --^added             そのリポジトリに追加された項目で構成される差分のみを
                        出力します。
    --^changed           変更された項目で構成される差分のみを
                        出力します。
    --^moved             移動または名前が変更された項目で構成される差分のみを
                        出力します。
    --^deleted           削除された項目で構成される差分のみを
                        出力します。

                        「--^added」、「--^changed」、「--^moved」、「--^deleted」のいずれも
                        指定されなかった場合、そのコマンドはすべての差分を出力します。
                            「^A」は追加された項目を意味します。
                            「^C」は変