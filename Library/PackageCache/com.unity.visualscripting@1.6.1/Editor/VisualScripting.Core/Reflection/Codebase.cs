ºèªãã¦ãã ããã

stdin ããå¥åãèª­ã¿åã:

    '^checkout' ã³ãã³ãã¯ stdin ãããã¹ãèª­ã¿åããã¨ãã§ãã¾ãããããè¡ãã«ã¯ãã·ã³ã°ã«
    ããã·ã¥ã-ããæ¸¡ãã¾ãã
    ä¾: cm ^checkout -

    ãã¹ã¯ç©ºã®è¡ãå¥åãããã¾ã§èª­ã¿åããã¾ãã
    ããã«ããããã¤ããä½¿ç¨ãã¦ãã§ãã¯ã¢ã¦ããããã¡ã¤ã«ãæå®ã§ãã¾ãã
    ä¾:
      dir /S /B *.c | cm ^checkout -
      (Windows ã§ããã¹ã¦ã® .c ãã¡ã¤ã«ãã¯ã¼ã¯ã¹ãã¼ã¹ã«ãã§ãã¯ã¢ã¦ããã¾ãã)

ä¾:

    cm ^checkout file1.txt file2.txt
    ('file1.txt' ã¨ 'file2.txt' ã®ãã¡ã¤ã«ããã§ãã¯ã¢ã¦ããã¾ãã)

    cm ^co *.txt
    (ãã¹ã¦ã® txt ãã¡ã¤ã«ããã§ãã¯ã¢ã¦ããã¾ãã)

    cm ^checkout .
    (ç¾å¨ã®ãã£ã¬ã¯ããªããã§ãã¯ã¢ã¦ããã¾ãã)

    cm ^checkout -^R c:\workspace\src
    ('src' ãã©ã«ãã¼ãåå¸°çã«ãã§ãã¯ã¢ã¦ããã¾ãã)

    cm ^co file.txt --^format="é ç® {0} ããã§ãã¯ã¢ã¦ããã¦ãã¾ã"
        --^errorformat="é ç® {0} ã®ãã§ãã¯ã¢ã¦ãä¸­ã«ã¨ã©ã¼ãçºçãã¾ãã" /
        --^resultformat="é ç® {0} ããã§ãã¯ã¢ã¦ããã¾ãã"
    (æå®ãããå½¢å¼åæå­åãä½¿ç¨ãã¦ 'file.txt' ããã§ãã¯ã¢ã¦ããã
    é²æãçµæãæä½ã®ã¨ã©ã¼ãè¡¨ç¤ºãã¾ãã)

    cm ^checkout ãªã³ã¯ --^symlink
    (ã¿ã¼ã²ããã«ã§ã¯ãªã 'ãªã³ã¯' ãã¡ã¤ã«ããã§ãã¯ã¢ã¦ããã¾ããUNIX ç°å¢ã§
    æå¹ã§ãã)

    cm ^checkout .-^R --^ignorefailed
    (ç¾å¨ã®ãã©ã«ãã¼ããã§ãã¯ã¢ã¦ããã¾ãããã§ãã¯ã¢ã¦ãã§ããªããã¡ã¤ã«ã¯
    ç¡è¦ããã¾ãã)

    cm ^co .--^machinereadable --^startlineseparator=">"
    (ç¾å¨ã®ãã£ã¬ã¯ããªããã§ãã¯ã¢ã¦ããããã®çµæãç°¡ç¥åãããã
    ããè§£æããããå½¢å¼ã§åºåãã¾ããæå®ãããæå­åã§è¡ãéå§ãã¾ãã)

== CMD_DESCRIPTION_CHECKSELECTORSYNTAX ==
ã»ã¬ã¯ã¿ã¼ã®æ§æããã§ãã¯ãã¾ãã

== CMD_USAGE_CHECKSELECTORSYNTAX ==
ä½¿ç¨æ¹æ³:

    cm ^checkselectorsyntax | ^css --^file=<ã»ã¬ã¯ã¿ã¼ãã¡ã¤ã«>
    (ã»ã¬ã¯ã¿ã¼ãã¡ã¤ã«ã®æ§æããã§ãã¯ãã¾ãã)

    ^cat <ã»ã¬ã¯ã¿ã¼ãã¡ã¤ã«> | cm ^checkselectorsyntax | ^css -
    (Unixãæ¨æºã®å¥åããã»ã¬ã¯ã¿ã¼ãã¡ã¤ã«ããã§ãã¯ãã¾ãã)

    ^type <ã»ã¬ã¯ã¿ã¼ãã¡ã¤ã«> | cm ^checkselectorsyntax | ^css -
    (Windowsãæ¨æºã®å¥åããã»ã¬ã¯ã¿ã¼ãã¡ã¤ã«ããã§ãã¯ãã¾ãã)


    --^file     ã»ã¬ã¯ã¿ã¼ã®èª­ã¿åãåã®ãã¡ã¤ã«ã

== CMD_HELP_CHECKSELECTORSYNTAX ==
åè:

    ãã®ã³ãã³ãã¯ãã¡ã¤ã«ã¾ãã¯æ¨æºã®å¥åã®ããããã®ã»ã¬ã¯ã¿ã¼ãèª­ã¿åãã
    æå¹ãªæ§æã§ãããã¨ããã§ãã¯ãã¾ããæ§æãã§ãã¯ã«åæ ¼ããªãã£ãå ´åããã®çç±ã
    æ¨æºåºåã«åºåããã¾ãã

ä¾:

    cm ^checkselectorsyntax --^file=myselector.txt
    ('myselector.txt' ãã¡ã¤ã«ã®æ§æããã§ãã¯ãã¾ãã)

    ^cat myselector.txt | cm ^checkselectorsyntax
    (æ¨æºã®å¥åãã 'myselector.txt' ã®æ§æããã§ãã¯ãã¾ãã)

== CMD_DESCRIPTION_CHGREVTYPE ==
é ç®ã®ãªãã¸ã§ã³ã¿ã¤ã (ãã¤ããªã¾ãã¯ãã­ã¹ã) ãå¤æ´ãã¾ãã

== CMD_USAGE_CHGREVTYPE ==
ä½¿ç¨æ¹æ³:

    cm ^changerevisiontype | ^chgrevtype | ^crt <é ç®ãã¹>[ ...]--^type=(^bin | ^txt)

    é ç®ãã¹            ãªãã¸ã§ã³ã¿ã¤ããå¤æ´ããé ç®ãç©ºç½ãå«ã¾ãããã¹ãæå®ããã«ã¯
                        äºéå¼ç¨ç¬¦ (" ") ãä½¿ç¨ãã¾ããç©ºç½ãä½¿ç¨ãã¦
                        é ç®ãã¹ãåºåãã¾ãã
    --^type              ã¿ã¼ã²ãããªãã¸ã§ã³ã¿ã¤ãã'^bin' ã¾ãã¯ '^txt' ãé¸æãã¾ãã

== CMD_HELP_CHGREVTYPE ==
åè:

    ãã®ã³ãã³ãã¯ãã£ã¬ã¯ããªã§ã¯ãªãããã¡ã¤ã«ã«ã®ã¿é©ç¨ã§ãã¾ãã
    æå®ãããã¿ã¤ãã¯ã·ã¹ãã ã§ãµãã¼ãå¯¾è±¡ã®ã^binãã¾ãã¯ã^txtã(ãã¤ããª
    ã¾ãã¯ãã­ã¹ã) ã§ããå¿è¦ãããã¾ãã

ä¾:

    cm ^changerevisiontype c:\workspace\file.txt --^type=^txt
    (ãfile.txtããªãã¸ã§ã³ã¿ã¤ãããã­ã¹ãã«å¤æ´ãã¾ãã)

    cm ^chgrevtype comp.zip "image file.jpg" --^type=^bin
    (ãcomp.zipãã¨ãimage file.jpgããªãã¸ã§ã³ã¿ã¤ãããã¤ããªã«å¤æ´ãã¾ãã)

    cm ^crt *.* --^type=^txt
    (ãã¹ã¦ã®ãã¡ã¤ã«ã®ãªãã¸ã§ã³ã¿ã¤ãããã­ã¹ãã«å¤æ´ãã¾ãã)

== CMD_DESCRIPTION_TRIGGER_EDIT ==
ããªã¬ã¼ãç·¨éãã¾ãã

== CMD_USAGE_TRIGGER_EDIT ==
ä½¿ç¨æ¹æ³:

    cm ^trigger | ^tr ^edit <ãµãã¿ã¤ãã®ã¿ã¤ã> <ä½ç½®çªå·>
                         [--^position=<æ°ããä½ç½®>]
                         [--^name=<æ°ããåå>] [--^script=<ã¹ã¯ãªãããã¹>]
                         [--^filter=<æå­åãã£ã«ã¿ã¼>] [--^server=<ãªãã¸ããªãµã¼ãã¼æå®>]

    ãµãã¿ã¤ãã®ã¿ã¤ã  ããªã¬ã¼å®è¡ã¨ããªã¬ã¼æä½ã
                        ããªã¬ã¼ã¿ã¤ãã®ãªã¹ããè¡¨ç¤ºããã«ã¯ãcm ^showtriggertypesã
                        ã¨å¥åãã¾ãã
    ä½ç½®çªå·            å¤æ´ãããããªã¬ã¼ãå ããä½ç½®ã

ãªãã·ã§ã³:

    --^position          æå®ãããããªã¬ã¼ã®æ°ããä½ç½®ã
                        ãã®ä½ç½®ã¯ãåãã¿ã¤ãã®å¥ã®ããªã¬ã¼ã«ãã£ã¦ä½¿ç¨ä¸­ã§ãªã
                        å¿è¦ãããã¾ãã
    --^name              æå®ãããããªã¬ã¼ã®æ°ããååã
    --^script            æå®ãããããªã¬ã¼ã¹ã¯ãªããã®æ°ããå®è¡ãã¹ã
                        ã¹ã¯ãªãããã^webtriggerãã§å§ã¾ãå ´åãããã¯
                        ã¦ã§ãããªã¬ã¼ã¨è¦ãªããã¾ããè©³ç´°ã«ã¤ãã¦ã¯ããåèãã
                        åç§ãã¦ãã ããã
    --^filter            æå®ããããã£ã«ã¿ã¼ã«ä¸è´ããé ç®ã®ã¿ããã§ãã¯ãã¾ãã
    --^server            æå®ããããµã¼ãã¼ã®ããªã¬ã¼ãç·¨éãã¾ãã
                        ãµã¼ãã¼ãæå®ããã¦ããªãå ´åã¯ãã¯ã©ã¤ã¢ã³ãã«è¨­å®ããã¦ãã
                        ãµã¼ãã¼ã§ã³ãã³ããå®è¡ãã¾ãã
                        (ãcm ^help ^objectspecããä½¿ç¨ãã¦ãµã¼ãã¼æå®ã®
                        è©³ç´°ãç¢ºèªã§ãã¾ãã)

== CMD_HELP_TRIGGER_EDIT ==
åè:

    ã¦ã§ãããªã¬ã¼: ã¦ã§ãããªã¬ã¼ã¯ãã^webtrigger <ã¿ã¼ã²ãã URI>ããããªã¬ã¼ã³ãã³ã
    ã¨ãã¦å¥åãããã¨ã§ä½æãã¾ãããã®å ´åãããªã¬ã¼ã¯æå®ããã URI ã«å¯¾ãã¦ 
    POST ã¯ã¨ãªãå®è¡ãã¾ãããªã¯ã¨ã¹ãæ¬æã«ã¯ãJSON ãã£ã¯ã·ã§ããªã¨
    ããªã¬ã¼ç°å¢å¤æ°ãããã³æå­åã®éåãæã
    åºå®ã®å¥åã­ã¼ãå«ã¾ãã¾ãã

ä¾:

    cm ^trigger ^edit ^after-setselector 6 --^name="Backup2 ããã¼ã¸ã£ã¼" --^script="/new/path/al/script"
    cm ^tr ^edit ^before-mklabel 7 --^position=4 --^server=myserver:8084
    cm ^trigger ^edit ^after-add 2 --^script="^webtrigger http://myserver.org/api"

== CMD_DESCRIPTION_CODEREVIEW ==
ã³ã¼ãã¬ãã¥ã¼ãä½æãç·¨éãåé¤ãã¾ãã

== CMD_USAGE_CODEREVIEW ==
ä½¿ç¨æ¹æ³:

    cm ^codereview <æå®> <ã¿ã¤ãã«> [--^status=<ã¹ãã¼ã¿ã¹å>]
                [--^assignee=<ã¦ã¼ã¶ã¼å>] [--^format=<æå­åå½¢å¼>]
                [--^repository=<ãªãã¸ããªæå®>]
    (ã³ã¼ãã¬ãã¥ã¼ãä½æãã¾ãã)

    cm ^codereview -^e <ID> [--^status=<ã¹ãã¼ã¿ã¹å>] [--^assignee=<ã¦ã¼ã¶ã¼å>]
                [--^repository=<ãªãã¸ããªæå®>]
    (ã³ã¼ãã¬ãã¥ã¼ãç·¨éãã¾ãã)

    cm ^codereview -^d <ID> [ ...][--^repository=<ãªãã¸ããªæå®>]
    (1 ã¤ä»¥ä¸ã®ã³ã¼ãã¬ãã¥ã¼ãåé¤ãã¾ãã)


    æå®                å¤æ´ã»ããæå®ã¾ãã¯ãã©ã³ãæå®ã®ããããã«ã§ãã¾ãã
                        ãããæ°ããã³ã¼ãã¬ãã¥ã¼ã®ã¿ã¼ã²ããã«ãªãã¾ãã(
                        ãcm ^help ^objectspecããä½¿ç¨ãã¦å¤æ´ã»ããæå®ã¾ãã¯ãã©ã³ãæå®ã®
                        è©³ç´°ãç¢ºèªã§ãã¾ãã)
    ã¿ã¤ãã«            æ°ããã³ã¼ãã¬ãã¥ã¼ã®ã¿ã¤ãã«ã¨ãã¦ä½¿ç¨ããã
                        ãã­ã¹ãæå­åã
    ID                  ã³ã¼ãã¬ãã¥ã¼ã®è­å¥çªå·ãGUID ãä½¿ç¨ãããã¨ã
                        ã§ãã¾ãã

ãªãã·ã§ã³:

    -^e                  æ¢å­ã®ã³ã¼ãã¬ãã¥ã¼ã®ãã©ã¡ã¼ã¿ã¼ãç·¨éãã¾ãã
    -^d                  1 ã¤ä»¥ä¸ã®æ¢å­ã®ã³ã¼ãã¬ãã¥ã¼ãåé¤ãã¾ããç©ºç½ã
                        ä½¿ç¨ãã¦ã³ã¼ãã¬ãã¥ã¼ã® ID ãåºåãã¾ãã
    --^status            ã³ã¼ãã¬ãã¥ã¼ã®æ°ããã¹ãã¼ã¿ã¹ãè¨­å®ãã¾ããè©³ç´°ã«ã¤ãã¦ã¯ããåèãã
                        åç§ãã¦ãã ããã
    --^assignee          ã³ã¼ãã¬ãã¥ã¼ã®æ°ããæå½èãè¨­å®ãã¾ãã
    --^format            åºåã¡ãã»ã¼ã¸ãç¹å®ã®å½¢å¼ã§åå¾ãã¾ããè©³ç´°ã«ã¤ãã¦ã¯
                        ãåèããåç§ãã¦ãã ããã
    --^repository        ããã©ã«ãã¨ãã¦ä½¿ç¨ããããªãã¸ããªãè¨­å®ãã¾ãã(
                        ãcm ^help ^objectspecããä½¿ç¨ãã¦ãªãã¸ããªæå®ã®è©³ç´°ã
                        ç¢ºèªã§ãã¾ãã)

== CMD_HELP_CODEREVIEW ==
åè:

    ãã®ã³ãã³ãã«ãããã¦ã¼ã¶ã¼ã¯ã³ã¼ãã¬ãã¥ã¼ãç®¡çã§ãã¾ããå¤æ´ã»ããã¾ãã¯ãã©ã³ãã®
    ã³ã¼ãã¬ãã¥ã¼ãä½æãç·¨éãåé¤ãã¾ãã

    æ°ããã³ã¼ãã¬ãã¥ã¼ãä½æããã«ã¯ãå¤æ´ã»ããæå®/ãã©ã³ãæå®ã¨ã¿ã¤ãã«ã
    å¿é ã§ããåæã¹ãã¼ã¿ã¹ã¨æå½èãè¨­å®ã§ãã¾ããID (ã¾ãã¯
    ãªã¯ã¨ã¹ããããå ´åã¯ GUID) ãçµæã¨ãã¦è¿ããã¾ãã

    æ¢å­ã®ã³ã¼ãã¬ãã¥ã¼ãç·¨éã¾ãã¯åé¤ããã«ã¯ãã¿ã¼ã²ããã®ã³ã¼ãã¬ãã¥ã¼ã® ID
    (ã¾ãã¯ GUID) ãå¿è¦ã§ããã¨ã©ã¼ããªãå ´åãã¡ãã»ã¼ã¸ã¯è¡¨ç¤ºããã¾ããã

    ã¹ãã¼ã¿ã¹ãã©ã¡ã¼ã¿ã¼ã¯ãã^Under reviewã
    (ããã©ã«ã)ãã^Reviewedããã¾ãã¯ã^Rework requiredãã®ããããã®ã¿ã«ãªãã¾ãã

    ãªãã¸ããªãã©ã¡ã¼ã¿ã¼ã§ã¯ãããã©ã«ãã®ä½æ¥­ãªãã¸ããªã
    è¨­å®ã§ãã¾ããããã¯ãç¾å¨ã®ã¯ã¼ã¯ã¹ãã¼ã¹ã«é¢é£ä»ãããã¦ãããµã¼ãã¼ã¨ã¯
    å¥ã®ãµã¼ãã¼ã®ã¬ãã¥ã¼ãç®¡çããã¨ãããç¾å¨ã®ã¯ã¼ã¯ã¹ãã¼ã¹ã
    ã¾ã£ãããªãã¨ãã«ä¾¿å©ã§ãã

    åºåå½¢å¼ã®ã«ã¹ã¿ãã¤ãº:

    ãã®ã³ãã³ãã¯ãåºåãè¡¨ç¤ºããå½¢å¼ã®æå­åãåãåãã¾ãã
    ãã®ã³ãã³ãã®åºåãã©ã¡ã¼ã¿ã¼ã¯æ¬¡ã®ã¨ããã§ãã
        {0}             ID
        {1}             GUID

    ã--^formatããã©ã¡ã¼ã¿ã¼ã¯ãæ°ããã³ã¼ãã¬ãã¥ã¼ãä½æãã¦ããã¨ãã«ã®ã¿æå¹ã§ãããã¨ã«
    æ³¨æãã¦ãã ããã

ä¾:

    cm ^codereview ^cs:1856@myrepo@myserver:8084 "My code review" --^assignee=dummy
    cm ^codereview ^br:/main/task001@myrepo@myserver:8084 "My code review" \
    --^status=^"Rework required" --^assignee=æ°å¥ã --^format="{^id} -> {^guid}"

    cm ^codereview 1367 -^e --^assignee=æ°ããæå½è
    cm ^codereview -^e 27658884-5dcc-49b7-b0ef-a5760ae740a3 --^status=ã¬ãã¥ã¼æ¸ã¿

    cm ^codereview -^d 1367 --^repository=myremoterepo@myremoteserver:18084
    cm ^codereview 27658884-5dcc-49b7-b0ef-a5760ae740a3 -^d

== CMD_DESCRIPTION_CRYPT ==
ãã¹ã¯ã¼ããæå·åãã¾ãã

== CMD_USAGE_CRYPT ==
ä½¿ç¨æ¹æ³:

    cm ^crypt <èªåã®ãã¹ã¯ã¼ã>

    èªåã®ãã¹ã¯ã¼ã    æå·åããããã¹ã¯ã¼ãã

== CMD_HELP_CRYPT ==
åè:

    ãã®ã³ãã³ãã¯ãå¼æ°ã¨ãã¦æ¸¡ãããæå®ã®ãã¹ã¯ã¼ããæå·åãã¾ãã
    ããã¯ãè¨­å®ãã¡ã¤ã«åã®ãã¹ã¯ã¼ããæå·åããå®å¨æ§ãé«ããããã«
    è¨­è¨ããã¦ãã¾ãã

ä¾:

    cm ^crypt dbconfpassword -> ENCRYPTED: encrypteddbconfpassword
    (ãã¼ã¿ãã¼ã¹è¨­å®ãã¡ã¤ã«ãdb.confãåã®ãã¹ã¯ã¼ããæå·åãã¾ãã)

== CMD_DESCRIPTION_DEACTIVATEUSER ==
ã©ã¤ã»ã³ã¹ãä»ä¸ãããã¦ã¼ã¶ã¼ã®ã¢ã¯ãã£ãã¼ããè§£é¤ãã¾ãã

== CMD_USAGE_DEACTIVATEUSER ==
ä½¿ç¨æ¹æ³:

    cm ^deactivateuser | ^du <ã¦ã¼ã¶ã¼å>[ ...][--^server=<åå:ãã¼ã>]
                           [--^nosolveuser]

    ã¦ã¼ã¶ã¼å          ã¢ã¯ãã£ãã¼ããè§£é¤ããã¦ã¼ã¶ã¼ã®ååãç©ºç½ãä½¿ç¨ãã¦
                        ã¦ã¼ã¶ã¼åãåºåãã¾ãã
                        SID ã®å ´åã¯ãã--^nosolveuserããå¿é ã§ãã

ãªãã·ã§ã³:

    --^server            æå®ããããµã¼ãã¼ä¸ã®ã¦ã¼ã¶ã¼ã®ã¢ã¯ãã£ãã¼ããè§£é¤ãã¾ãã
                        ãµã¼ãã¼ãæå®ããã¦ããªãå ´åã¯ãã¯ã©ã¤ã¢ã³ãã«è¨­å®ããã¦ãã
                        ãµã¼ãã¼ã§ã³ãã³ããå®è¡ãã¾ãã
    --^nosolveuser       ãã®ãªãã·ã§ã³ãä½¿ç¨ããã¨ãã³ãã³ãã¯ãã®ã¦ã¼ã¶ã¼åãèªè¨¼ã·ã¹ãã ä¸ã«
                        å­å¨ãããã©ããããã§ãã¯ãã¾ããããã®
                        <ã¦ã¼ã¶ã¼å> ã¯ã¦ã¼ã¶ã¼ SID ã§ããå¿è¦ãããã¾ãã

== CMD_HELP_DEACTIVATEUSER ==
åè:

    ãã®ã³ãã³ãã¯ã¦ã¼ã¶ã¼ãéã¢ã¯ãã£ãã«è¨­å®ãããã®ã¦ã¼ã¶ã¼ã Plastic SCM ã
    ä½¿ç¨ã§ããªããªãã¾ãã

    Plastic SCM ã¦ã¼ã¶ã¼ã®ã¢ã¯ãã£ãã¼ãè§£é¤ã®è©³ç´°ã«ã¤ãã¦ã¯ããcm ^activateuserãã³ãã³ãã
    åç§ãã¦ãã ããã

    ãã®ã³ãã³ãã¯ããã®ã¦ã¼ã¶ã¼ãåºç¤ã®èªè¨¼ã·ã¹ãã  (ä¾: ActiveDirectoryãLDAPãã¦ã¼ã¶ã¼/ãã¹ã¯ã¼ã...) ä¸ã«
    å­å¨ãããã©ããããã§ãã¯ãã¾ãã
    èªè¨¼ã·ã¹ãã ä¸ã«å­å¨ããªããªã£ãã¦ã¼ã¶ã¼ã®ã¢ã¯ãã£ãã¼ãè§£é¤ã
    é©ç¨ããã«ã¯ãã--^nosolveuserããªãã·ã§ã³ãä½¿ç¨ã§ãã¾ãã

ä¾:

    cm ^deactivateuser john
    cm ^du peter "mary collins"
    cm ^deactivateuser john --^server=myserver:8084
    cm ^deactivateuser S-1-5-21-3631250224-3045023395-1892523819-1107 --^nosolveuser

== CMD_DESCRIPTION_DIFF ==
ãã¡ã¤ã«ãå¤æ´ã»ãããã©ãã«éã®å·®åãè¡¨ç¤ºãã¾ãã

== CMD_USAGE_DIFF ==
ä½¿ç¨æ¹æ³:

    cm ^diff <å¤æ´ã»ããæå®> | <ã©ãã«æå®> | <ã·ã§ã«ãæå®> [<å¤æ´ã»ããæå®> | <ã©ãã«æå®> | <ã·ã§ã«ãæå®>]
            [<ãã¹>]
            [--^added] [--^changed] [--^moved] [--^deleted]
            [--^repositorypaths] [--^download=<ãã¦ã³ã­ã¼ãã®ãã¹>]
            [--^encoding=<åå>]
            [--^ignore=(^eol | ^whitespaces | ^"eol&whitespaces" | ^none)]
            [--^clean]
            [--^format=<æå­åå½¢å¼>] [--^dateformat=<æå­åå½¢å¼>]

        ãã½ã¼ã¹ãå¤æ´ã»ããã¾ãã¯ã·ã§ã«ãã»ããã¨ããåæåãå¤æ´ã»ãã
        ã¾ãã¯ã·ã§ã«ãã»ããã®éã®å·®åãè¡¨ç¤ºãã¾ããå¤æ´ã»ããã¯ãå¤æ´ã»ããæå®
        ã¾ãã¯ã©ãã«æå®ã®ãããããä½¿ç¨ãã¦æå®ã§ãã¾ãã
        2 ã¤ã®æå®ãæå®ãããå ´æã§ã¯ãæåã®æå®ãå·®åã®ãã½ã¼ã¹ãã«ãªãã
        2 ã¤ç®ã®æå®ããåæåãã«ãªãã¾ãã
        1 ã¤ã®æå®ã®ã¿ãæå®ãããå ´åããã®ãã½ã¼ã¹ããæå®ããããåæåãã®
        è¦ªå¤æ´ã»ããã«ãªãã¾ãã
        ãªãã·ã§ã³ã®ãã¹ãæå®ãããå ´åãå·®åã¦ã£ã³ãã¦ãèµ·åãã
        ãã®ãã¡ã¤ã«ã® 2 ã¤ã®ãªãã¸ã§ã³éã®å·®åãè¡¨ç¤ºããã¾ãã

    cm ^diff <ãªãã¸ã§ã³æå® 1> <ãªãã¸ã§ã³æå® 2>

        ãªãã¸ã§ã³ã®ãã¢éã®å·®åãè¡¨ç¤ºãã¾ãããã®å·®åã¯
        å·®åã¦ã£ã³ãã¦ã«è¡¨ç¤ºããã¾ããæå®ãããæåã®ãªãã¸ã§ã³ã
        å·¦ã«è¡¨ç¤ºããã¾ãã

    cm ^diff <ãã©ã³ãæå®> [--^added] [--^changed] [--^moved] [--^deleted]
            [--^repositorypaths] [--^download=<ãã¦ã³ã­ã¼ãã®ãã¹>]
            [--^encoding=<åå>]
            [--^ignore=(^eol | ^whitespaces | ^"eol&whitespaces" | ^none)]
            [--^clean]
            [--^format=<æå­åå½¢å¼>] [--^dateformat=<æå­åå½¢å¼>]
            [--^fullpaths | --^fp]

        ãã©ã³ãã®å·®åãè¡¨ç¤ºãã¾ãã

    (ãcm ^help ^objectspecããä½¿ç¨ãã¦æå®ã®è©³ç´°ãç¢ºèªã§ãã¾ãã)

ãªãã·ã§ã³:

    --^added             ãã®ãªãã¸ããªã«è¿½å ãããé ç®ã§æ§æãããå·®åã®ã¿ã
                        åºåãã¾ãã
    --^changed           å¤æ´ãããé ç®ã§æ§æãããå·®åã®ã¿ã
                        åºåãã¾ãã
    --^moved             ç§»åã¾ãã¯ååãå¤æ´ãããé ç®ã§æ§æãããå·®åã®ã¿ã
                        åºåãã¾ãã
    --^deleted           åé¤ãããé ç®ã§æ§æãããå·®åã®ã¿ã
                        åºåãã¾ãã

                        ã--^addedããã--^changedããã--^movedããã--^deletedãã®ãããã
                        æå®ãããªãã£ãå ´åããã®ã³ãã³ãã¯ãã¹ã¦ã®å·®åãåºåãã¾ãã
                            ã^Aãã¯è¿½å ãããé ç®ãæå³ãã¾ãã
                            ã^Cãã¯å¤