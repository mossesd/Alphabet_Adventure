¤ãæ¸ã¿ã§ãããã©ãããæ¤åºãã
      ã¦ã¼ã¶ã¼ã«ãã¡ã¤ã«ã®å ´æãå¥åããããæ±ãã¾ãã
      ã¦ã¼ã¶ã¼ã¯ãã¢ã¼ã«ã¤ãæ¸ã¿ã®ãã¼ã¿ãç½®ããã¦ããå ´æã®ãã¹ãå«ã¾ãã
      externaldata.conf ã¨ããååã®ãã¡ã¤ã«ã (æ¨æºã®è¨­å®ãã¡ã¤ã«ã®å ´æã«ã
      client.conf ã«é©ç¨ãããã®ã¨åãã«ã¼ã«ãä½¿ç¨ãã¦) ä½æãããã¨ã§ã
      å¤é¨ãã¼ã¿ã®å ´æãè¨­å®ã§ãã¾ãã

    - ãµã¼ãã¼ãã: ãã®æ¹æ³ã§ã¯ããªã¯ã¨ã¹ãã¯ãµã¼ãã¼ã«ãã£ã¦ééçã«è§£æ±ºãããããã
      ã¦ã¼ã¶ã¼ã¯ãã¼ã¿ãã¢ã¼ã«ã¤ãæ¸ã¿ã§ãããã©ãããç¥ã£ã¦ããå¿è¦ã
      ããã¾ããããã®ããã«ããã«ã¯ãç®¡çèããµã¼ãã¼ãã£ã¬ã¯ããªã«
       externaldata.conf ã¨ããååã®ãã¡ã¤ã«ãä½æããããã«
      ã¢ã¼ã«ã¤ãæ¸ã¿ã®ããªã¥ã¼ã ããããã¹ãå¥åãã¾ãã

    ãªãã¸ã§ã³ (ã¾ãã¯ãªãã¸ã§ã³ã®ã»ãã) ã®ã¢ã¼ã«ã¤ããè§£é¤ (å¾©å) ããã«ã¯ããã®ã¢ã¼ã«ã¤ãæ¸ã¿ã®
    ãã¡ã¤ã«ã«ã¯ã©ã¤ã¢ã³ãããã¢ã¯ã»ã¹ã§ããå¿è¦ãããã¾ãããã®ããããµã¼ãã¼ (æ¹æ³ 2) ã«ãã£ã¦
    è§£æ±ºããã¦ãããã¼ã¿ã®ã¢ã¼ã«ã¤ããè§£é¤ãããã¨ã¯ã§ãã¾ãããã¯ã©ã¤ã¢ã³ãã
    ãããã¢ã¼ã«ã¤ãæ¸ã¿ã§ãããã¨ãè­å¥ã§ããªãããã§ããæ¹æ³ 2 ãä½¿ç¨ãããå ´åã
    ã¢ã¼ã«ã¤ããæ­£å¸¸ã«è§£é¤ããã«ã¯ãåã«ç®¡çèã
    externaldata.conf ãµã¼ãã¼ãã¡ã¤ã«ãç·¨éããã¢ã¼ã«ã¤ããè§£é¤ããå¿è¦ãããã¢ã¼ã«ã¤ãæ¸ã¿ã®
    ãã¡ã¤ã«ã¸ã®ã¢ã¯ã»ã¹ãåé¤ããå¿è¦ãããã¾ãã

    PLASTICEDITOR ç°å¢å¤æ°ãè¨­å®ãã¦ãã³ã¡ã³ããå¥åããã¨ãã£ã¿ã¼ã
    æå®ãã¾ãã

ä¾:

    cm ^archive bigfile.zip#^br:/main
    (ãã©ã³ã 'main' ã«ãã 'bigfile.zip' ã®ææ°ã®ãªãã¸ã§ã³ãã¢ã¼ã«ã¤ããã¾ãã)

    cm ^archive ^rev:myfile.pdf#^cs:2 -^c="å¤§ããª PDF ãã¡ã¤ã«" --^file=c:\arch_files\arch
    (myfile.pdf ã®å¤æ´ã»ãã 2 ã§ã®ãªãã¸ã§ã³ã 'c:\archived_files' ãã©ã«ãã¼ã«
    ã¢ã¼ã«ã¤ããã¾ããã¢ã¼ã«ã¤ãæ¸ã¿ã®ãã¡ã¤ã«ã®ååã¯ 'arch' ã§å§ã¾ãå¿è¦ãããã¾ã (ä¾: arch_11_56)ã)

    cm ^find "^revs ^where ^size > 26214400" --^format="{^item}#{^branch}" \
      --^nototal | cm ^archive --^comment="volume00" --^file="volume00" -
    (ååã 'volume00' ã§å§ã¾ãããµã¤ãºã 25 Mb ä»¥ä¸ã®ãã¡ã¤ã«ããã¹ã¦
    ã¢ã¼ã«ã¤ããã¾ãã)

    cm ^find "^revs ^where ^size > 26214400 ^and ^archived='true'" \
      --^format="{^item}#{^branch}" --^nototal | cm ^archive --^restore
    (ãµã¤ãºã 25 Mb ä»¥ä¸ã®ã¢ã¼ã«ã¤ãæ¸ã¿ã®ãã¡ã¤ã«ããã¹ã¦å¾©åãã¾ãã)

== CMD_DESCRIPTION_ATTRIBUTE ==
ã¦ã¼ã¶ã¼ãå±æ§ãç®¡çã§ããããã«ãã¾ãã

== CMD_USAGE_ATTRIBUTE ==
ä½¿ç¨æ¹æ³:

    cm ^attribute | ^att <ã³ãã³ã> [ãªãã·ã§ã³]

ã³ãã³ã:

    ^create | ^mk
    ^delete | ^rm
    ^set
    ^unset
    ^rename
    ^edit

    åã³ãã³ãã®è©³ç´°æå ±ãåå¾ããã«ã¯ãæ¬¡ã®ã³ãã³ããå®è¡ãã¾ã:
    cm ^attribute <ã³ãã³ã> --^usage
    cm ^attribute <ã³ãã³ã> --^help

== CMD_HELP_ATTRIBUTE ==
ä¾:

    cm ^attribute ^create ã¹ãã¼ã¿ã¹
    cm ^attribute ^set ^att:status ^br:/main/SCM105 æªå¦ç
    cm ^attribute ^unset ^att:status ^br:/main/SCM105
    cm ^attribute ^delete ^att:status
    cm ^attribute ^rename ^att:status "ãã«ãã¹ãã¼ã¿ã¹"
    cm ^attribute ^edit ^att:status "CI ãã¤ãã©ã¤ã³åã®ã¿ã¹ã¯ã®ã¹ãã¼ã¿ã¹"

== CMD_DESCRIPTION_CHANGELIST ==
å¤æ´ãªã¹ãåã®ã°ã«ã¼ãã®ä¿çä¸­ã®å¤æ´ã

== CMD_USAGE_CHANGELIST ==
ä½¿ç¨æ¹æ³:

    a) å¤æ´ãªã¹ãã®ãªãã¸ã§ã¯ãã®ç®¡ç:

       cm ^changelist | ^clist [--^symlink]
       (ãã¹ã¦ã®å¤æ´ãªã¹ããè¡¨ç¤ºãã¾ãã)

       cm ^changelist | ^clist ^add <å¤æ´ãªã¹ãå>
          [<å¤æ´ãªã¹ãèª¬æ>] [--^persistent | --^notpersistent] [--^symlink]
       (å¤æ´ãªã¹ããä½æãã¾ãã)

       cm ^changelist | ^clist ^rm <å¤æ´ãªã¹ãå> [--^symlink]
       (é¸æãããå¤æ´ãªã¹ããåé¤ãã¾ãããã®å¤æ´ãªã¹ãã«ä¿çä¸­ã®å¤æ´ãå«ã¾ãã¦ãã
       å ´åããããã¯ ^default å¤æ´ãªã¹ãã«ç§»åããã¾ãã)

       cm ^changelist | ^clist ^edit <å¤æ´ãªã¹ãå> [<ã¢ã¯ã·ã§ã³å> <ã¢ã¯ã·ã§ã³å¤>]
                             [--^persistent | --^notpersistent] [--^symlink]
       (é¸æãããå¤æ´ãªã¹ããç·¨éãã¾ãã)

    b) æå®ã®å¤æ´ãªã¹ãã®ã³ã³ãã³ãã®ç®¡ç:

       cm ^changelist | ^clist <å¤æ´ãªã¹ãå> (^add | ^rm) <ãã¹å>[ ...]
                             [--^symlink]
       (æå®ããããã¹åã¨ä¸è´ããå¤æ´ãè¿½å  ('^add') ã¾ãã¯åé¤ ('^rm') ãããã¨ã§ã
       é¸æãããå¤æ´ãªã¹ããè¿½å ã¾ãã¯åé¤ãã¾ããç©ºç½ãä½¿ç¨ãã¦
       ãã¹åãåºåãã¾ããç©ºç½ãå«ã¾ãããã¹ãæå®ããã«ã¯
       äºéå¼ç¨ç¬¦ (" ") ãä½¿ç¨ãã¾ãããã¹ã®ã¹ãã¼ã¿ã¹ã¯ã'^Added' ã¾ãã¯ '^Checked-out' ã§ããå¿è¦ãããã¾ãã)

ãªãã·ã§ã³:

    å¤æ´ãªã¹ãå        å¤æ´ãªã¹ãã®ååã
    å¤æ´ãªã¹ãèª¬æ      å¤æ´ãªã¹ãã®èª¬æã
    ã¢ã¯ã·ã§ã³å        å¤æ´ãªã¹ããç·¨éããã®ã« '^rename' ã '^description' ã®éãã
                        é¸æãã¾ãã
    ã¢ã¯ã·ã§ã³å¤        å¤æ´ãªã¹ããç·¨éä¸­ã«ãæ°ããååã¾ãã¯æ°ããèª¬æã
                        é©ç¨ãã¾ãã
    --^persistent        ãã®ã³ã³ãã³ãããã§ãã¯ã¤ã³ã¾ãã¯åã«æ»ããã¦ããå ´åã§ãã
                        å¤æ´ãªã¹ãã¯ã¯ã¼ã¯ã¹ãã¼ã¹åã«æ®ãã¾ãã
    --^notpersistent     (ããã©ã«ã) ãã®ã³ã³ãã³ãããã§ãã¯ã¤ã³ã¾ãã¯åã«æ»ããã¦ãã
                        å ´åã§ããå¤æ´ãªã¹ãã¯ã¯ã¼ã¯ã¹ãã¼ã¹åã«
                        æ®ãã¾ããã
    --^symlink           æä½ãã¿ã¼ã²ããã§ã¯ãªãã·ã³ããªãã¯ãªã³ã¯ã«
                        é©ç¨ãã¾ãã

== CMD_HELP_CHANGELIST ==
åè:

    '^changelist' ã³ãã³ãã¯ãã¯ã¼ã¯ã¹ãã¼ã¹ã®ä¿çä¸­ã®å¤æ´ã¨ãå¤æ´ãªã¹ãã«
    å«ã¾ãã¦ããå¤æ´ã®ä¸¡æ¹ãå¦çãã¾ãã

ä¾:

    cm ^changelist
    (ç¾å¨ã®ã¯ã¼ã¯ã¹ãã¼ã¹ã®å¤æ´ãªã¹ããè¡¨ç¤ºãã¾ãã)

    cm ^changelist ^add è¨­å®å¤æ´ "dotConf ãã¡ã¤ã«" --^persistent
    (ãè¨­å®å¤æ´ãã¨ããååã®æ°ããå¤æ´ãªã¹ãã¨ãdotConf
    ãã¡ã¤ã«ãã¨ããååã®èª¬æãä½æãã¾ãããã®ä¿çä¸­ã®å¤æ´ãªã¹ãããã§ãã¯ã¤ã³ã¾ãã¯åã«æ»ãããã¨ã
    ç¾å¨ã®ã¯ã¼ã¯ã¹ãã¼ã¹ã«æ°¸ç¶çã«æ®ãã¾ãã)

    cm ^changelist ^edit è¨­å®å¤æ´ ^rename è¨­å®ãã¡ã¤ã« --^notpersistent
    (ãè¨­å®å¤æ´ãã¨ããååã®å¤æ´ãªã¹ããç·¨éãããã®ååããè¨­å®ãã¡ã¤ã«ãã«
    å¤æ´ãã¾ããã¾ãããã®å¤æ´ãªã¹ãããéæ°¸ç¶çãã«ãªãããã«å¤æ´ãã¾ãã)
        
    cm ^changelist ^edit è¨­å®å¤æ´ --^notpersistent
    (ãè¨­å®å¤æ´ãã¨ããååã®å¤æ´ãªã¹ããç·¨éããããããéæ°¸ç¶çãã«ãªãããã«å¤æ´ãã¾ãã)

    cm ^changelist ^rm è¨­å®ãã¡ã¤ã«
    (ä¿çä¸­ã®å¤æ´ãªã¹ããè¨­å®ãã¡ã¤ã«ããç¾å¨ã®ã¯ã¼ã¯ã¹ãã¼ã¹ããåé¤ãã¾ãã)

    cm ^changelist è¨­å®ãã¡ã¤ã« ^add foo.conf
    (ãã¡ã¤ã«ãfoo.confãããè¨­å®ãã¡ã¤ã«ãå¤æ´ãªã¹ãã«è¿½å ãã¾ãã)

    cm ^changelist è¨­å®ãã¡ã¤ã« ^rm foo.conf readme.txt
    (ãã¡ã¤ã«ãfoo.confãã¨ãreadme.txtãããè¨­å®ãã¡ã¤ã«ã
    å¤æ´ãªã¹ãããåé¤ãããããã®ãã¡ã¤ã«ãã·ã¹ãã ã®ããã©ã«ãã®å¤æ´ãªã¹ãã«ç§»åãã¾ãã)

== CMD_DESCRIPTION_CHANGESET ==
å¤æ´ã»ããã«å¯¾ãã¦é«åº¦ãªæä½ãå®è¡ãã¾ãã

== CMD_USAGE_CHANGESET ==
ä½¿ç¨æ¹æ³:

    cm ^changeset <ã³ãã³ã> [ãªãã·ã§ã³]

ã³ãã³ã:

    ^move        | ^mv
    ^delete      | ^rm
    ^editcomment | ^edit

    åã³ãã³ãã®è©³ç´°æå ±ãåå¾ããã«ã¯ãæ¬¡ã®ã³ãã³ããå®è¡ãã¾ã:
    cm ^changeset <ã³ãã³ã> --^usage
    cm ^changeset <ã³ãã³ã> --^help

== CMD_HELP_CHANGESET ==
ä¾:

    cm ^changeset ^move ^cs:15@myrepo ^br:/main/scm005@myrepo
    cm ^changeset ^delete ^cs:2b55f8aa-0b29-410f-b99c-60e573a309ca@devData

== CMD_DESCRIPTION_CHANGESET_EDIT_COMMENT ==
å¤æ´ã»ããã®ã³ã¡ã³ããå¤æ´ãã¾ãã

== CMD_USAGE_CHANGESET_EDIT_COMMENT ==
ä½¿ç¨æ¹æ³:

    cm ^changeset ^editcomment | ^edit <å¤æ´ã»ããæå®> <æ°ããã³ã¡ã³ã>

ãªãã·ã§ã³:

    å¤æ´ã»ããæå®      ã³ã¡ã³ããç·¨éãããã¿ã¼ã²ããå¤æ´ã»ããã
                        (ãcm ^help ^objectspecããä½¿ç¨ãã¦å¤æ´ã»ããæå®ã®è©³ç´°ã
                        ç¢ºèªã§ãã¾ãã)
    æ°ããã³ã¡ã³ã      ã¿ã¼ã²ããã®å¤æ´ã»ããã«è¿½å ãããæ°ãã
                        ã³ã¡ã³ãã

== CMD_HELP_CHANGESET_EDIT_COMMENT ==
åè:

    - ã¿ã¼ã²ããã®å¤æ´ã»ããæå®ãæå¹ã§ããå¿è¦ãããã¾ãã

ä¾:

    cm ^changeset ^editcomment ^cs:15@myrepo "ãã§ãã¯ã¤ã³ã®è©³ç´°ãè¿½å ããã®ãå¿ãã¦ãã¾ãã"
    cm ^changeset ^edit ^cs:cb11ecdb-1aa9-4f11-8698-dcab14e5885a \
         "ãã®ã³ã¡ã³ããã­ã¹ããåã®ã³ã¡ã³ãã«ç½®ãæããã¾ãã"

== CMD_DESCRIPTION_CHANGESET_MOVE ==
å¤æ´ã»ããã¨ãã®ãã¹ã¦ã®å­å­«ãå¥ã®ãã©ã³ãã«ç§»åãã¾ãã

== CMD_USAGE_CHANGESET_MOVE ==
ä½¿ç¨æ¹æ³:

    cm ^changeset ^move | ^mv <å¤æ´ã»ããæå®> <ãã©ã³ãæå®>

ãªãã·ã§ã³:

    å¤æ´ã»ããæå®      å¥ã®ãã©ã³ãã«ç§»åãããæåã®å¤æ´ã»ãããåã
                        ãã©ã³ãåã®ãã¹ã¦ã®å­å­«ã®å¤æ´ã»ãããåæ§ã«
                        ãã®ã³ãã³ãã®ã¿ã¼ã²ããã«ãªãã¾ãã
                        (ãcm ^help ^objectspecããä½¿ç¨ãã¦å¤æ´ã»ããæå®ã®è©³ç´°ã
                        ç¢ºèªã§ãã¾ãã)
    ãã©ã³ãæå®        ã¿ã¼ã²ããã®å¤æ´ã»ãããæ ¼ç´ãããã¿ã¼ã²ãã
                        ãã©ã³ããç©ºã§ãããå­å¨ãã¦ããªãå¿è¦ãããã¾ãã
                        åæåãã©ã³ããå­å¨ããªãå ´åã¯ããã®ã³ãã³ãã«ãã£ã¦
                        ä½æããã¾ãã
                        ('cm ^help ^objectspec' ãä½¿ç¨ãã¦ãã©ã³ãæå®ã®è©³ç´°ã
                        ç¢ºèªã§ãã¾ãã)

== CMD_HELP_CHANGESET_MOVE ==
åè:

    - ã¿ã¼ã²ããã®å¤æ´ã»ããæå®ãæå¹ã§ããå¿è¦ãããã¾ãã
    - åæåãã©ã³ãã¯ç©ºã§ãããå­å¨ãã¦ããªãå¿è¦ãããã¾ãã
    - åæåãã©ã³ããå­å¨ããªãå ´åã¯ãä½æããã¾ãã
    - ãã¼ã¸ãªã³ã¯ã¯ãã©ã³ãã®å½±é¿ãåããªããããå¤æ´ããã¾ããã

ä¾:

    cm ^changeset ^move ^cs:15@myrepo ^br:/main/scm005@myrepo
    cm ^changeset ^move ^cs:cb11ecdb-1aa9-4f11-8698-dcab14e5885a ^br:/hotfix/TL-352

== CMD_DESCRIPTION_CHANGESET_DELETE ==
å¤æ´ã»ããããªãã¸ããªããåé¤ãã¾ãã

== CMD_USAGE_CHANGESET_DELETE ==
ä½¿ç¨æ¹æ³:

    cm ^changeset ^delete | ^rm <å¤æ´ã»ããæå®>

ãªãã·ã§ã³:

    å¤æ´ã»ããæå®      åé¤ãããã¿ã¼ã²ããå¤æ´ã»ãããç¹å®ã®æ¡ä»¶ã®ä¸é¨ã
                       æºããã¦ããå¿è¦ãããã¾ããè©³ç´°ã«ã¤ãã¦ã¯ããåèããåç§ãã¦ãã ããã
                       (ãcm ^help ^objectspecããä½¿ç¨ãã¦å¤æ´ã»ããæå®ã®è©³ç´°ã
                        ç¢ºèªã§ãã¾ãã)

== CMD_HELP_CHANGESET_DELETE ==
åè:

    - ã¿ã¼ã²ããå¤æ´ã»ããã¯ããã®ãã©ã³ãåã§æå¾ã§ããå¿è¦ãããã¾ãã
    - ã¿ã¼ã²ããå¤æ´ã»ããã¯ããã®ä»ã®å¤æ´ã»ããã®è¦ªã§ãã£ã¦ã¯ãªãã¾ããã
    - ã¿ã¼ã²ããå¤æ´ã»ããã¯ããã¼ã¸ãªã³ã¯ã®ã½ã¼ã¹ã§ãã£ã¦ããã½ã¼ã¹ã¨ãã¦ã®
      ééãã¼ã¸ã®ä¸é¨ã§ãã£ã¦ããªãã¾ããã
    - ã¿ã¼ã²ããå¤æ´ã»ããã«ãã©ãã«ãé©ç¨ããã¦ãã¦ã¯ãªãã¾ããã
    - ã¿ã¼ã²ããå¤æ´ã»ããã¯ãã«ã¼ãå¤æ´ã»ãã ('^cs:0') ã§ãã£ã¦ã¯ãªãã¾ããã

ä¾:

    cm ^changeset ^rm ^cs:4525@myrepo@myserver
    cm ^changeset ^delete ^cs:cb11ecdb-1aa9-4f11-8698-dcab14e5885a

== CMD_DESCRIPTION_CHANGEUSERPASSWORD ==
ã¦ã¼ã¶ã¼ãã¹ã¯ã¼ã (UP) ãå¤æ´ãã¾ãã

== CMD_USAGE_CHANGEUSERPASSWORD ==
ä½¿ç¨æ¹æ³:

    cm ^changepassword | ^passwd

== CMD_HELP_CHANGEUSERPASSWORD ==
åè:

    ãã®ã³ãã³ãã¯ãã»ã­ã¥ãªãã£è¨­å®ã UP (ã¦ã¼ã¶ã¼/ãã¹ã¯ã¼ã) ã®ã¨ãã«ã®ã¿
    ä½¿ç¨ã§ãã¾ããè©³ç´°ã«ã¤ãã¦ã¯ãç®¡çã¬ã¤ããç¢ºèªãã¦ãã ããã
    æ°æ§ã®ãã¹ã¯ã¼ããå¿è¦ã§ãã

ä¾:

    cm ^passwd

== CMD_DESCRIPTION_CHECKCONNECTION ==
ãµã¼ãã¼ã¸ã®æ¥ç¶ãç¢ºèªãã¾ãã

== CMD_USAGE_CHECKCONNECTION ==
ä½¿ç¨æ¹æ³:

      cm ^checkconnection | ^cc

== CMD_HELP_CHECKCONNECTION ==
åè:

    - ãã®ã³ãã³ãã¯ãè¨­å®ããã Plastic SCM ãµã¼ãã¼ã¸ã®æå¹ãªæ¥ç¶ã
      ãããã©ãããç¤ºãã¡ãã»ã¼ã¸ãè¿ãã¾ãã
    - ã³ãã³ãã¯ãè¨­å®ãããã¦ã¼ã¶ã¼ãæå¹ã§ãããã©ãããç¢ºèªãã¾ããã¾ãã
      ãµã¼ãã¼ã®ãã¼ã¸ã§ã³ã®äºææ§ãç¢ºèªãã¾ãã

== CMD_DESCRIPTION_CHECKDB ==
ãªãã¸ããªã®æ´åæ§ãç¢ºèªãã¾ãã

== CMD_USAGE_CHECKDB ==
ä½¿ç¨æ¹æ³:

    cm ^checkdatabase | ^chkdb [<ãªãã¸ããªãµã¼ãã¼æå®> | <ãªãã¸ããªæå®>]

'cm ^help ^objectspec' ãä½¿ç¨ãã¦ãªãã¸ããªãµã¼ãã¼æå®ã¨ãªãã¸ããªæå®ã®è©³ç´°ãç¢ºèªã§ãã¾ãã

== CMD_HELP_CHECKDB ==
åè:

    - ãªãã¸ããªãµã¼ãã¼æå®ããªãã¸ããªæå®ãæå®ããã¦ããªãå ´åã
      client.conf ãã¡ã¤ã«ã§æå®ããããµã¼ãã¼ã§ãã§ãã¯ãè¡ããã¾ãã

ä¾:

    cm ^checkdatabase ^repserver:localhost:8084
    cm ^chkdb ^rep:default@localhost:8084

== CMD_DESCRIPTION_CHECKIN ==
å¤æ´ããªãã¸ããªã«æ ¼ç´ãã¾ãã

== CMD_USAGE_CHECKIN ==
ä½¿ç¨æ¹æ³:

    cm ^checkin | ^ci [<é ç®ãã¹>[ ...]]
        [-^c=<ã³ã¡ã³ãæå­å> | -^commentsfile=<ã³ã¡ã³ããã¡ã¤ã«>]
        [--^all|-^a] [--^applychanged] [--^private] [--^update] [--^symlink]
        [--^noshowchangeset]
        [--^machinereadable [--^startlineseparator=<ã»ãã¬ã¼ã¿ã¼>]
          [--^endlineseparator=<ã»ãã¬ã¼ã¿ã¼>] [--^fieldseparator=<ã»ãã¬ã¼ã¿ã¼>]]

ãªãã·ã§ã³:

    é ç®ãã¹             ãã§ãã¯ã¤ã³ãããé ç®ãç©ºç½ãå«ã¾ãããã¹ãæå®ããã«ã¯
                          äºéå¼ç¨ç¬¦ (" ") ãä½¿ç¨ãã¾ããç©ºç½ãä½¿ç¨ãã¦
                          é ç®ãã¹ãåºåãã¾ãã
                          ãã§ãã¯ã¤ã³ãç¾å¨ã®ãã£ã¬ã¯ããªã«é©ç¨ããã«ã¯ã. ãä½¿ç¨ãã¾ãã
    -^c                    æå®ãããã³ã¡ã³ãããã§ãã¯ã¤ã³æä½ã§ä½æããã
                          å¤æ´ã»ããã«é©ç¨ãã¾ãã
    -^commentsfile         æå®ããããã¡ã¤ã«åã®ã³ã¡ã³ãããã§ãã¯ã¤ã³æä½ã§
                          ä½æãããå¤æ´ã»ããã«é©ç¨ãã¾ãã
    --^all | -^a            æå®ããããã¹ã§ã­ã¼ã«ã«ã«å¤æ´ãç§»åãããã³åé¤ããã
                          é ç®ãå«ãã¾ãã
    --^applychanged        ãã§ãã¯ã¢ã¦ãæ¸ã¿ã®é ç®ã¨ã¨ãã«ã¯ã¼ã¯ã¹ãã¼ã¹ã§
                          æ¤åºãããå¤æ´æ¸ã¿é ç®ã«ãã§ãã¯ã¤ã³æä½ã
                          é©ç¨ãã¾ãã
    --^private             ã¯ã¼ã¯ã¹ãã¼ã¹ã§æ¤åºãããéå¬éã®é ç®ã
                          å«ã¾ãã¾ãã
    --^update              æçµçã«çºçããå ´åã¯ãæ´æ°/ãã¼ã¸ãèªåçã«
                          å¦çãã¾ãã
    --^symlink             ãã§ãã¯ã¤ã³æä½ãã¿ã¼ã²ããã§ã¯ãªãã·ã³ããªãã¯ãªã³ã¯ã«
                          é©ç¨ãã¾ãã
    --^noshowchangeset     çµæã®å¤æ´ã»ãããåºåãã¾ããã
    --^machinereadable     çµæãè§£æããããå½¢å¼ã§åºåãã¾ãã
    --^startlineseparator  '--^machinereadable' ãã©ã°ã¨ã¨ãã«ä½¿ç¨ããããã®è¡ãã©ã®ããã«éå§ãã
                          å¿è¦ãããããæå®ãã¾ãã
    --^endlineseparator    '--^machinereadable' ãã©ã°ã¨ã¨ãã«ä½¿ç¨ããããã®è¡ãã©ã®ããã«çµäºãã
                          å¿è¦ãããããæå®ãã¾ãã
    --^fieldseparator      '--^machinereadable' ãã©ã°ã¨ã¨ãã«ä½¿ç¨ããããã®ãã£ã¼ã«ããã©ã®ããã«åºåã
                          å¿è¦ãããããæå®ãã¾ãã

== CMD_HELP_CHECKIN ==
åè:

    - <é ç®ãã¹>ãæå®ããã¦ããªãå ´åããã§ãã¯ã¤ã³ã«ã¯ãã®ã¯ã¼ã¯ã¹ãã¼ã¹åã®
      ãã¹ã¦ã®ä¿çä¸­ã®å¤æ´ãé¢ä¸ãã¾ãã
    - ãã§ãã¯ã¤ã³æä½ã¯å¸¸ã«æå®ããããã¹ããåå¸°çã«é©ç¨ããã¾ãã
    - é ç®ããã§ãã¯ã¤ã³ããã«ã¯:
      - é ç®ãã½ã¼ã¹ã³ã¼ãç®¡çã®å¯¾è±¡ã«ãªã£ã¦ããå¿è¦ãããã¾ãã
      - é ç®ãéå¬éã® (ã½ã¼ã¹ã³ã¼ãç®¡çã®å¯¾è±¡ã§ãªã) å ´åããã§ãã¯ã¤ã³
        ããã«ã¯ --^private ãã©ã°ãå¿é ã§ãã
      - é ç®ããã§ãã¯ã¢ã¦ãããã¦ããå¿è¦ãããã¾ãã
      - é ç®ãå¤æ´ããã¦ãããã®ã®ãã§ãã¯ã¢ã¦ãããã¦ããªãå ´åã<é ç®ãã¹> ã
        ãã£ã¬ã¯ããªã§ããããã¯ã¤ã«ãã«ã¼ã ('*') ãå«ã¾ãã¦ããå ´åãé¤ãã--^applychanged ãã©ã°ã¯
        ä¸è¦ã§ãã

    ãã§ãã¯ã¤ã³ããã«ã¯ãªãã¸ã§ã³ã³ã³ãã³ããåã®ãªãã¸ã§ã³ã¨ç°ãªã£ã¦ããå¿è¦ã
    ããã¾ãã

    PLASTICEDITOR ç°å¢å¤æ°ãè¨­å®ãã¦ãã³ã¡ã³ããå¥åããã¨ãã£ã¿ã¼ã
    æå®ãã¾ãã

stdin ããå¥åãèª­ã¿åã:

    '^checkin' ã³ãã³ãã¯ stdin ãããã¹ãèª­ã¿åããã¨ãã§ãã¾ãããããè¡ãã«ã¯ãã·ã³ã°ã«
    ããã·ã¥ã-ããæ¸¡ãã¾ãã
    ä¾: cm ^checkin -

    ãã¹ã¯ç©ºã®è¡ãå¥åãããã¾ã§èª­ã¿åããã¾ãã
    ããã«ããããã¤ããä½¿ç¨ãã¦ãã§ãã¯ã¤ã³ãããã¡ã¤ã«ãæå®ã§ãã¾ãã
    ä¾:
      dir /S /B *.c | cm ^checkin --^all -
      (Windows ã§ããã¹ã¦ã® .c ãã¡ã¤ã«ãã¯ã¼ã¯ã¹ãã¼ã¹ã«ãã§ãã¯ã¤ã³ãã¾ãã)

ä¾:

    cm ^checkin file1.txt file2.txt
    ('file1.txt' ã¨ 'file2.txt' ã®ãã§ãã¯ã¢ã¦ãæ¸ã¿ã®ãã¡ã¤ã«ããã§ãã¯ã¤ã³ãã¾ãã)

    cm ^checkin .-^commentsfile=mycomment.txt
    (ç¾å¨ã®ãã£ã¬ã¯ããªããã§ãã¯ã¤ã³ãã'mycomment.txt' ãã¡ã¤ã«ã«
    ã³ã¡ã³ããè¨­å®ãã¾ãã)

    cm ^checkin ãªã³ã¯ --^symlink
    (ã¿ã¼ã²ããã§ã¯ãªãããªã³ã¯ããã¡ã¤ã«ããã§ãã¯ã¤ã³ãã¾ããUNIX ç°å¢ã§
    æå¹ã§ãã)

    cm ^ci file1.txt -^c="my comment"
    ('file1.txt' ããã§ãã¯ã¤ã³ããã³ã¡ã³ããå«ãã¾ãã)

    cm ^status --^short --^compact --^changelist=ã¬ãã¥ã¼å¾ã¡ | cm ^checkin -
    (ãã¬ãã¥ã¼å¾ã¡ãã¨ããååã®å¤æ´ãªã¹ãåã®ãã¹ããªã¹ããããã®ãªã¹ãã
    ãã§ãã¯ã¤ã³ã³ãã³ãã®å¥åã«ãªãã¤ã¬ã¯ããã¾ãã)

    cm ^ci .--^machinereadable
    (ç¾å¨ã®ãã£ã¬ã¯ããªããã§ãã¯ã¤ã³ãããã®çµæãç°¡ç¥åãããã
    ããè§£æããããå½¢å¼ã§åºåãã¾ãã)

    cm ^ci .--^machinereadable --^startlineseparator=">" --^endlineseparator="<" --^fieldseparator=","
    (ç¾å¨ã®ãã£ã¬ã¯ããªããã§ãã¯ã¤ã³ãããã®çµæãç°¡ç¥åãããã
    ããè§£æããããå½¢å¼ã§åºåãã¾ããæå®ãããæå­åã§
    è¡ãéå§ããã³çµäºãããã£ã¼ã«ããåºåãã¾ãã)

== CMD_DESCRIPTION_CHECKOUT ==
ãã¡ã¤ã«ãå¤æ´æºåå®äºã¨ãã¦ãã¼ã¯ã