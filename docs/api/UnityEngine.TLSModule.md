# Assembly: UnityEngine.TLSModule
- Path: tools/WorldBox.Managed/UnityEngine.TLSModule.dll
- Types: 12

## Namespace: Unity.TLS

### internal static class Unity.TLS.UnityTLSNativeLibrary

## Namespace: Unity.TLS.LowLevel

### internal static class Unity.TLS.LowLevel.Binding

#### Fields
- public static const int UnityTLSClientAuth_None
- public static const int UnityTLSClientAuth_Optional
- public static const int UnityTLSClientAuth_Required
- public static const int UnityTLSClientState_Fail
- public static const int UnityTLSClientState_Handshake
- public static const int UnityTLSClientState_Init
- public static const int UnityTLSClientState_Messaging
- public static const int UnityTLSClientState_None
- public static const int UnityTLSRole_Client
- public static const int UnityTLSRole_None
- public static const int UnityTLSRole_Server
- public static const int UnityTLSTransportProtocol_Datagram
- public static const int UnityTLSTransportProtocol_Stream
- public static const int UNITYTLS_BUFFER_OVERFLOW
- public static const int UNITYTLS_DER_PARSE_ERROR
- public static const int UNITYTLS_ENTROPY_SOURCE_FAILED
- public static const int UNITYTLS_HANDSHAKE_STEP
- public static const int UNITYTLS_INTERNAL_ERROR
- public static const int UNITYTLS_INVALID_ARGUMENT
- public static const int UNITYTLS_INVALID_FORMAT
- public static const int UNITYTLS_INVALID_PASSWORD
- public static const int UNITYTLS_INVALID_STATE
- public static const int UNITYTLS_KEY_PARSE_ERROR
- public static const int UNITYTLS_LOGLEVEL_DEBUG
- public static const int UNITYTLS_LOGLEVEL_ERROR
- public static const int UNITYTLS_LOGLEVEL_FATAL
- public static const int UNITYTLS_LOGLEVEL_INFO
- public static const int UNITYTLS_LOGLEVEL_MAX
- public static const int UNITYTLS_LOGLEVEL_MIN
- public static const int UNITYTLS_LOGLEVEL_TRACE
- public static const int UNITYTLS_LOGLEVEL_WARN
- public static const int UNITYTLS_NOT_SUPPORTED
- public static const int UNITYTLS_OUT_OF_MEMORY
- public static const int UNITYTLS_SSL_ERROR
- public static const int UNITYTLS_SSL_HANDSHAKE_BEGIN
- public static const int UNITYTLS_SSL_HANDSHAKE_CERTIFICATE_REQUEST
- public static const int UNITYTLS_SSL_HANDSHAKE_CERTIFICATE_VERIFY
- public static const int UNITYTLS_SSL_HANDSHAKE_CLIENT_CERTIFICATE
- public static const int UNITYTLS_SSL_HANDSHAKE_CLIENT_CHANGE_CIPHER_SPEC
- public static const int UNITYTLS_SSL_HANDSHAKE_CLIENT_FINISHED
- public static const int UNITYTLS_SSL_HANDSHAKE_CLIENT_HELLO
- public static const int UNITYTLS_SSL_HANDSHAKE_CLIENT_KEY_EXCHANGE
- public static const int UNITYTLS_SSL_HANDSHAKE_COUNT
- public static const int UNITYTLS_SSL_HANDSHAKE_DONE
- public static const int UNITYTLS_SSL_HANDSHAKE_FLUSH_BUFFERS
- public static const int UNITYTLS_SSL_HANDSHAKE_HANDSHAKE_FLUSH_BUFFERS
- public static const int UNITYTLS_SSL_HANDSHAKE_HANDSHAKE_OVER
- public static const int UNITYTLS_SSL_HANDSHAKE_HANDSHAKE_WRAPUP
- public static const int UNITYTLS_SSL_HANDSHAKE_HELLO_REQUEST
- public static const int UNITYTLS_SSL_HANDSHAKE_HELLO_VERIFY_REQUIRED
- public static const int UNITYTLS_SSL_HANDSHAKE_OVER
- public static const int UNITYTLS_SSL_HANDSHAKE_SERVER_CERTIFICATE
- public static const int UNITYTLS_SSL_HANDSHAKE_SERVER_CHANGE_CIPHER_SPEC
- public static const int UNITYTLS_SSL_HANDSHAKE_SERVER_FINISHED
- public static const int UNITYTLS_SSL_HANDSHAKE_SERVER_HELLO
- public static const int UNITYTLS_SSL_HANDSHAKE_SERVER_HELLO_DONE
- public static const int UNITYTLS_SSL_HANDSHAKE_SERVER_KEY_EXCHANGE
- public static const int UNITYTLS_SSL_HANDSHAKE_SERVER_NEW_SESSION_TICKET
- public static const int UNITYTLS_SSL_HANDSHAKE_WRAPUP
- public static const int UNITYTLS_SSL_NEEDS_VERIFY
- public static const int UNITYTLS_STREAM_CLOSED
- public static const int UNITYTLS_SUCCESS
- public static const int UNITYTLS_USER_CUSTOM_ERROR_END
- public static const int UNITYTLS_USER_CUSTOM_ERROR_START
- public static const int UNITYTLS_USER_READ_FAILED
- public static const int UNITYTLS_USER_UNKNOWN_ERROR
- public static const int UNITYTLS_USER_WOULD_BLOCK
- public static const int UNITYTLS_USER_WOULD_BLOCK_READ
- public static const int UNITYTLS_USER_WOULD_BLOCK_WRITE
- public static const int UNITYTLS_USER_WRITE_FAILED

#### Methods
- public static void unitytls_client_add_ciphersuite(Unity.TLS.LowLevel.Binding.unitytls_client* clientInstance, uint suite)
- public static Unity.TLS.LowLevel.Binding.unitytls_client* unitytls_client_create(uint role, Unity.TLS.LowLevel.Binding.unitytls_client_config* config)
- public static void unitytls_client_destroy(Unity.TLS.LowLevel.Binding.unitytls_client* clientInstance)
- public static uint unitytls_client_get_ciphersuite(Unity.TLS.LowLevel.Binding.unitytls_client* clientInstance, int ndx)
- public static int unitytls_client_get_ciphersuite_cnt(Unity.TLS.LowLevel.Binding.unitytls_client* clientInstance)
- public static uint unitytls_client_get_errorsState(Unity.TLS.LowLevel.Binding.unitytls_client* clientInstance, ulong* reserved)
- public static uint unitytls_client_get_handshake_state(Unity.TLS.LowLevel.Binding.unitytls_client* clientInstance)
- public static uint unitytls_client_get_role(Unity.TLS.LowLevel.Binding.unitytls_client* clientInstance)
- public static uint unitytls_client_get_state(Unity.TLS.LowLevel.Binding.unitytls_client* clientInstance)
- public static uint unitytls_client_handshake(Unity.TLS.LowLevel.Binding.unitytls_client* clientInstance)
- public static int unitytls_client_init(Unity.TLS.LowLevel.Binding.unitytls_client* clientInstance)
- public static void unitytls_client_init_config(Unity.TLS.LowLevel.Binding.unitytls_client_config* config)
- public static uint unitytls_client_read_data(Unity.TLS.LowLevel.Binding.unitytls_client* clientInstance, byte* buffer, System.UIntPtr bufferLen, System.UIntPtr* bytesRead)
- public static uint unitytls_client_send_data(Unity.TLS.LowLevel.Binding.unitytls_client* clientInstance, byte* data, System.UIntPtr dataLen)
- public static uint unitytls_client_set_cookie_info(Unity.TLS.LowLevel.Binding.unitytls_client* clientInstance, byte* peerIdDataPtr, int peerIdDataLen)

### public struct Unity.TLS.LowLevel.Binding.unitytls_client

#### Fields
- public Unity.TLS.LowLevel.Binding.unitytls_client_config* config
- public System.IntPtr ctx
- public uint handshakeState
- public System.IntPtr internalCtx
- public uint role
- public uint state

### public struct Unity.TLS.LowLevel.Binding.unitytls_client_config

#### Fields
- public System.IntPtr applicationUserData
- public Unity.TLS.LowLevel.Binding.unitytls_dataRef caPEM
- public uint clientAuth
- public System.IntPtr dataReceiveCB
- public System.IntPtr dataReceiveTimeoutCB
- public System.IntPtr dataSendCB
- public int handshakeReturnsIfWouldBlock
- public int handshakeReturnsOnStep
- public byte* hostname
- public System.IntPtr logCallback
- public ushort mtu
- public System.IntPtr onDataCB
- public Unity.TLS.LowLevel.Binding.unitytls_dataRef privateKeyPEM
- public Unity.TLS.LowLevel.Binding.unitytls_dataRef psk
- public Unity.TLS.LowLevel.Binding.unitytls_dataRef pskIdentity
- public Unity.TLS.LowLevel.Binding.unitytls_dataRef serverPEM
- public uint ssl_handshake_timeout_max
- public uint ssl_handshake_timeout_min
- public uint ssl_read_timeout_ms
- public uint tracelevel
- public uint transportProtocol
- public System.IntPtr transportUserData

### public delegate Unity.TLS.LowLevel.Binding.unitytls_client_data_receive_callback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public Binding.unitytls_client_data_receive_callback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr arg0, byte* arg1, System.UIntPtr arg2, uint arg3, System.AsyncCallback callback, object object)
- public virtual int EndInvoke(System.IAsyncResult result)
- public virtual int Invoke(System.IntPtr arg0, byte* arg1, System.UIntPtr arg2, uint arg3)

### public delegate Unity.TLS.LowLevel.Binding.unitytls_client_data_receive_timeout_callback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public Binding.unitytls_client_data_receive_timeout_callback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr arg0, byte* arg1, System.UIntPtr arg2, uint arg3, uint arg4, System.AsyncCallback callback, object object)
- public virtual int EndInvoke(System.IAsyncResult result)
- public virtual int Invoke(System.IntPtr arg0, byte* arg1, System.UIntPtr arg2, uint arg3, uint arg4)

### public delegate Unity.TLS.LowLevel.Binding.unitytls_client_data_send_callback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public Binding.unitytls_client_data_send_callback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr arg0, byte* arg1, System.UIntPtr arg2, uint arg3, System.AsyncCallback callback, object object)
- public virtual int EndInvoke(System.IAsyncResult result)
- public virtual int Invoke(System.IntPtr arg0, byte* arg1, System.UIntPtr arg2, uint arg3)

### public delegate Unity.TLS.LowLevel.Binding.unitytls_client_log_callback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public Binding.unitytls_client_log_callback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(int arg0, byte* arg1, System.UIntPtr arg2, byte* arg3, byte* arg4, System.UIntPtr arg5, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(int arg0, byte* arg1, System.UIntPtr arg2, byte* arg3, byte* arg4, System.UIntPtr arg5)

### public delegate Unity.TLS.LowLevel.Binding.unitytls_client_on_data_callback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public Binding.unitytls_client_on_data_callback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(System.IntPtr arg0, byte* arg1, System.UIntPtr arg2, uint arg3, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(System.IntPtr arg0, byte* arg1, System.UIntPtr arg2, uint arg3)

### public struct Unity.TLS.LowLevel.Binding.unitytls_dataRef

#### Fields
- public System.UIntPtr dataLen
- public byte* dataPtr

### public struct Unity.TLS.LowLevel.Binding.unitytls_errorstate

#### Fields
- public uint code
- public uint magic
- public ulong reserved

### public delegate Unity.TLS.LowLevel.Binding.unitytls_tlsctx_handshake_on_blocking_callback
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public Binding.unitytls_tlsctx_handshake_on_blocking_callback(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Unity.TLS.LowLevel.Binding.unitytls_client* arg0, System.IntPtr arg1, int arg2, System.AsyncCallback callback, object object)
- public virtual int EndInvoke(System.IAsyncResult result)
- public virtual int Invoke(Unity.TLS.LowLevel.Binding.unitytls_client* arg0, System.IntPtr arg1, int arg2)

