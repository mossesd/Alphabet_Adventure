n (expires in 31622399 seconds)
2023-07-13 09:58:55.453 - [ 10868] - [    16] - INFO  - [Unity.Licensing.Client.Communication.ApiPipeHandler#2] REQ-23 | Sending AccessTokenResponse for request AccessTokenRequest from UnityEditor/2021.3.23f1 (Windows; U; Windows NT 10.0; en) (LocalIPC/1.12) [200]:  (null)
2023-07-13 09:58:55.761 - [ 10868] - [    20] - WARN  - [GenesisClient.HttpRequests] Handled response: [404 | Not Found | {
  "type" : "https://httpstatuses.com/404",
  "title" : "Invalid context",
  "status" : 404,
  "errorCode" : 404005,
  "detail" : "Machine bindings in context was not registered before",
  "instance" : "/licenses/v1/context",
  "results" : [ ]
}] from request: [POST | https://license.unity3d.com/licenses/v1/context | {"context":{"DeviceName":"DESKTOP-LDQ8VOV","DeviceModel":"OptiPlex 3090 (Dell Inc.)","PhysicalMemoryMB":"7904","SystemLanguageISO":"en","ProcessorCount":"12","ProcessorType":"Intel(R) Core(TM) i5-10505 CPU @ 3.20GHz","OperatingSystem":"Windows 10  (10.0.0) 64bit","OperatingSystemNumeric":"1000","Legacy.MachineBinding1":"00331-10000-00001-AA434","Legacy.MachineBinding2":"NZS13G66","Legacy.MachineBinding4":"NUNOUktMMw==","Legacy.MachineBinding5":"c0:25:a5:cc:8f:18","EnvironmentUser":"user","EnvironmentDomain":"DESKTOP-LDQ8VOV","EnvironmentHostname":"DESKTOP-LDQ8VOV"}}]
2023-07-13 09:58:55.770 - [ 10868] - [    16] - WARN  - [Unity.Licensing.EntitlementResolver.ContextValidator] The following fields of your context don't match:
	Legacy.MachineBinding1: License value (00331-10000-00001-AA866) != Current context (00331-10000-00001-AA434)
2023-07-13 09:58:55.77