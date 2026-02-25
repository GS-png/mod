# Assembly: UnityEngine.UnityCurlModule
- Path: tools/WorldBox.Managed/UnityEngine.UnityCurlModule.dll
- Types: 3

## Namespace: Unity.Curl

### internal enum Unity.Curl.BufferOwnership
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Copy = 0
- External = 2
- Transfer = 1

### internal enum Unity.Curl.CurlEasyHandleFlags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- kFollowRedirects = 8
- kReceiveBody = 4
- kReceiveHeaders = 2
- kSendBody = 1

### internal static class Unity.Curl.UnityCurl

#### Methods
- internal static void AbortRequest(System.IntPtr handle)
- internal static System.IntPtr AppendHeader(System.IntPtr headerList, byte* header)
- internal static System.IntPtr CreateEasyHandle(byte* method, byte* url, out uint curlMethod)
- internal static System.IntPtr CreateMultiHandle()
- internal static void DestroyEasyHandle(System.IntPtr handle)
- internal static void DestroyMultiHandle(System.IntPtr handle)
- internal static void FreeHeaderList(System.IntPtr headerList)
- internal static void GetDownloadSize(System.IntPtr request, out ulong downloaded, out ulong expected)
- internal static byte* GetMoreBody(System.IntPtr handle, out int length)
- internal static int GetRequestErrorCode(System.IntPtr request)
- internal static int GetRequestStatus(System.IntPtr request)
- internal static uint GetRequestStatusCode(System.IntPtr request)
- internal static byte* GetResponseHeader(System.IntPtr request, uint index, out uint length)
- internal static void QueueRequest(System.IntPtr multiHandle, System.IntPtr easyHandle)
- internal static void SendMoreBody(System.IntPtr handle, byte* chunk, uint length, Unity.Curl.BufferOwnership ownership)
- private static void SendMoreBody(System.IntPtr handle, byte* chunk, uint length, int ownership)
- internal static void SetupEasyHandle(System.IntPtr handle, uint curlMethod, System.IntPtr headers, ulong contentLen, uint flags)

