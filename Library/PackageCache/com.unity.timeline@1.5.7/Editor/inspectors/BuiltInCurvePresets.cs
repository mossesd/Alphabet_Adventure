en
        stdErr.WriteLine GetResource("L_ERR_Message") & GetResource("L_ARGNOVAL_Message") & namedArg
        WScript.Quit(ERR_GENERAL_FAILURE)
    end if
end sub

private sub ASSERTBOOL(bool, msg)
    if Not bool then
        stdErr.WriteLine GetResource("L_ERR_Message") & msg
        WScript.Quit(ERR_GENERAL_FAILURE)
    end if
end sub

private function ReFormat(rawStr,formattedStr,formatOption)
    dim xslFile
    dim xmlFile
    dim xmlFileName
    dim xslFileName 
    dim FORMAT_XSL_PATH

    if Len(rawStr) = 0 then
        ReFormat = false
        exit function
    end if
    
    on error resume next
    err.clear
    
    if LCase(formatOption) = VAL_FORMAT_XML then
        formattedStr = rawStr
    else
        set xmlFile = CreateObject("MSXML2.DOMDOCUMENT.6.0")
        if Err.number <> 0 then
            stdErr.WriteLine GetResource("L_MSXML6MISSING_Message")
            on error goto 0
            ReFormat = false
            exit function
        end if
 
        set xslFile = CreateObject("MSXML2.DOMDOCUMENT.6.0")
        if Err.number <> 0 then
            stdErr.WriteLine GetResource("L_MSXML6MISSING_Message")
            on error goto 0
            ReFormat = false
            exit function
        end if
        
        xmlFile.async = false
        xslFile.async = false
            
        xmlFile.LoadXML(rawStr)
        if (xmlFile.parseError.errorCode <> 0) then
            stdErr.WriteLine GetResource("L_XMLERROR_Message") & xmlFile.parseError.reason
            on error goto 0
            ReFormat = false
            exit function
        end If
        
        FORMAT_XSL_PATH = WSHShell.ExpandEnvironmentStrings("%systemroot%\system32\")
        if InStr(LCase(WScript.Path),"\syswow64") > 0 then
            FORMAT_XSL_PATH = WSHShell.ExpandEnvironmentStrings("%systemroot%\syswow64\")
        end if
             
        if LCase(formatOption) = VAL_FORMAT_TEXT then
            FORMAT_XSL_PATH = FORMAT_XSL_PATH & VAL_FORMAT_TEXT_XSLT
        elseif LCase(formatOption) = VAL_FORMAT_PRETTY then
            FORMAT_XSL_PATH = FORMAT_XSL_PATH & VAL_FORMAT_PRETTY_XSLT
        else
            stdErr.WriteLine GetResource("L_FORMATLERROR_Message") & formatOption
            stdErr.WriteLine 
            on error goto 0
            ReFormat = false
            exit function
        end If

        if Not xslFile.load(FORMAT_