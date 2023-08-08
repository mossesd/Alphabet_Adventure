/5.0 (Macintosh; Intel Mac OS X 10_7_2) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.100 Safari/535.2"
    // safari: "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_7_2) AppleWebKit/534.51.22 (KHTML, like Gecko) Version/5.1.1 Safari/534.51.22"
    //
    // WINDOWS:
    // chrome: "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.102 Safari/535.2"
    // IE: "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; WOW64; Trident/5.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; .NET4.0C; .NET4.0E; MS-RTC LM 8; InfoPath.3; Zune 4.7)" 
    // Opera:	"Opera/9.80 (Windows NT 6.1; U; en) Presto/2.9.168 Version/11.52"
    // FF: "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:8.0) Gecko/20100101 Firefox/8.0"
    // LINUX:
    // chrome: "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/39.0.2171.71 Safari/537.36"
    // firefox: "Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:34.0) Gecko/20100101 Firefox/34.0"
    var userAgent = navigator.userAgent;
    var isTest = !!global.isTest;
    var isPseudo = global.document && global.document.URL.match(/[^\?]*\?[^\#]*pseudo=true/);
    // DOCUMENTED FOR FUTURE REFERENCE:
    // When running IE11 in IE10 document mode, the code below will identify the browser as being I