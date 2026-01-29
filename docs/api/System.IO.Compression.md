# Assembly: System.IO.Compression
- Path: tools/WorldBox.Managed/System.IO.Compression.dll
- Types: 70

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=19 111B15B20E0428A22EEAA1E54B0D3B008A7A3E79C8F7F4E783710F569E9CEF15
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=29 5A9C295A20121AFD94328DC04C59836D4CE002766129B4A0A996F2DE248201CF
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64_Align=2 B16FE01EC40E68586BEBFC5DEDB192DF48250670E3B83B2DAAA02FE500EDD9BD2
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=29 B672541D472D0DF45EA7ADFD9CBBEEF9C1EBA5995647FEBC9C983D5B4190B36B
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 B8E85B9CF5A7912BB02F1CF93F5F7FEBAC206CF473FC768F8D541FF3F4D0C00E

### internal static class Interop

### internal static class Interop.ZLib

#### Methods
- internal static uint crc32(uint crc, byte* buffer, int len)
- internal static System.IO.Compression.ZLibNative.ErrorCode Deflate(System.IO.Compression.ZLibNative.ZStream* stream, System.IO.Compression.ZLibNative.FlushCode flush)
- internal static System.IO.Compression.ZLibNative.ErrorCode DeflateEnd(System.IO.Compression.ZLibNative.ZStream* stream)
- internal static System.IO.Compression.ZLibNative.ErrorCode DeflateInit2_(System.IO.Compression.ZLibNative.ZStream* stream, System.IO.Compression.ZLibNative.CompressionLevel level, System.IO.Compression.ZLibNative.CompressionMethod method, int windowBits, int memLevel, System.IO.Compression.ZLibNative.CompressionStrategy strategy)
- internal static System.IO.Compression.ZLibNative.ErrorCode Inflate(System.IO.Compression.ZLibNative.ZStream* stream, System.IO.Compression.ZLibNative.FlushCode flush)
- internal static System.IO.Compression.ZLibNative.ErrorCode InflateEnd(System.IO.Compression.ZLibNative.ZStream* stream)
- internal static System.IO.Compression.ZLibNative.ErrorCode InflateInit2_(System.IO.Compression.ZLibNative.ZStream* stream, int windowBits)

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=19

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=29

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64_Align=2

## Namespace: FxResources.System.IO.Compression

### internal static class FxResources.System.IO.Compression.SR

## Namespace: System

### internal static class System.SR

#### Fields
- private static System.Resources.ResourceManager s_resourceManager
- private static readonly bool s_usingResourceKeys

#### Properties
- internal static string ArgumentOutOfRange_Enum { get; }
- internal static string CannotReadFromDeflateStream { get; }
- internal static string CannotWriteToDeflateStream { get; }
- internal static string CDCorrupt { get; }
- internal static string CentralDirectoryInvalid { get; }
- internal static string CreateInReadMode { get; }
- internal static string CreateModeCapabilities { get; }
- internal static string CreateModeCreateEntryWhileOpen { get; }
- internal static string CreateModeWriteOnceAndOneEntryAtATime { get; }
- internal static string DateTimeOutOfRange { get; }
- internal static string DeletedEntry { get; }
- internal static string DeleteOnlyInUpdate { get; }
- internal static string DeleteOpenEntry { get; }
- internal static string EntriesInCreateMode { get; }
- internal static string EntryNameAndCommentEncodingNotSupported { get; }
- internal static string EntryNamesTooLong { get; }
- internal static string EntryTooLarge { get; }
- internal static string EOCDNotFound { get; }
- internal static string FieldTooBigCompressedSize { get; }
- internal static string FieldTooBigLocalHeaderOffset { get; }
- internal static string FieldTooBigNumEntries { get; }
- internal static string FieldTooBigOffsetToCD { get; }
- internal static string FieldTooBigOffsetToZip64EOCD { get; }
- internal static string FieldTooBigUncompressedSize { get; }
- internal static string FrozenAfterWrite { get; }
- internal static string GenericInvalidData { get; }
- internal static string HiddenStreamName { get; }
- internal static string InvalidBeginCall { get; }
- internal static string InvalidBlockLength { get; }
- internal static string InvalidHuffmanData { get; }
- internal static string LengthAfterWrite { get; }
- internal static string LocalFileHeaderCorrupt { get; }
- internal static string NotSupported { get; }
- internal static string NotSupported_UnreadableStream { get; }
- internal static string NotSupported_UnwritableStream { get; }
- internal static string NumEntriesWrong { get; }
- internal static string ReadingNotSupported { get; }
- internal static string ReadModeCapabilities { get; }
- internal static string ReadOnlyArchive { get; }
- internal static System.Resources.ResourceManager ResourceManager { get; }
- internal static string SeekingNotSupported { get; }
- internal static string SetLengthRequiresSeekingAndWriting { get; }
- internal static string SplitSpanned { get; }
- internal static string TruncatedData { get; }
- internal static string UnexpectedEndOfStream { get; }
- internal static string UnknownBlockType { get; }
- internal static string UnknownState { get; }
- internal static string UnsupportedCompression { get; }
- internal static string UnsupportedCompressionMethod { get; }
- internal static string UpdateModeCapabilities { get; }
- internal static string UpdateModeOneStream { get; }
- internal static string WritingNotSupported { get; }
- internal static string Zip64EOCDNotWhereExpected { get; }
- internal static string ZLibErrorDLLLoadError { get; }
- internal static string ZLibErrorInconsistentStream { get; }
- internal static string ZLibErrorIncorrectInitParameters { get; }
- internal static string ZLibErrorNotEnoughMemory { get; }
- internal static string ZLibErrorUnexpected { get; }
- internal static string ZLibErrorVersionMismatch { get; }

#### Constructors
- private static SR()

#### Methods
- internal static string Format(string resourceFormat, object p1)
- private static string GetResourceString(string resourceKey)
- internal static bool UsingResourceKeys()

## Namespace: System.IO.Compression

### private struct System.IO.Compression.DeflateStream.<<DisposeAsync>g__Core|61_0>d
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.IO.Compression.DeflateStream <>4__this
- private object <>7__wrap1
- private int <>7__wrap2
- public System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__1

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct System.IO.Compression.DeflateStream.<<FlushAsync>g__Core|33_0>d
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.IO.Compression.DeflateStream <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__1
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2
- private bool <flushSuccessful>5__2
- public System.Threading.CancellationToken cancellationToken

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct System.IO.Compression.SubReadStream.<<ReadAsync>g__Core|24_0>d
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.IO.Compression.SubReadStream <>4__this
- public System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder<int> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter<int> <>u__1
- public System.Memory<byte> buffer
- public System.Threading.CancellationToken cancellationToken

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct System.IO.Compression.DeflateStream.<<ReadAsyncMemory>g__Core|51_0>d
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.IO.Compression.DeflateStream <>4__this
- public System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder<int> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter<int> <>u__1
- private int <bytesRead>5__2
- public System.Memory<byte> buffer
- public System.Threading.CancellationToken cancellationToken

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct System.IO.Compression.ZipArchiveEntry.DirectToArchiveWriterStream.<<WriteAsync>g__Core|27_0>d
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.IO.Compression.ZipArchiveEntry.DirectToArchiveWriterStream <>4__this
- public System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__1
- public System.ReadOnlyMemory<byte> buffer
- public System.Threading.CancellationToken cancellationToken

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct System.IO.Compression.CheckSumAndSizeWriteStream.<<WriteAsync>g__Core|32_0>d
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.IO.Compression.CheckSumAndSizeWriteStream <>4__this
- public System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__1
- public System.ReadOnlyMemory<byte> buffer
- public System.Threading.CancellationToken cancellationToken

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct System.IO.Compression.DeflateStream.<<WriteAsyncMemory>g__Core|66_0>d
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.IO.Compression.DeflateStream <>4__this
- public System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__1
- public System.ReadOnlyMemory<byte> buffer
- public System.Threading.CancellationToken cancellationToken

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class System.IO.Compression.ZipArchiveEntry.<>c

#### Fields
- public static readonly System.IO.Compression.ZipArchiveEntry.<>c <>9
- public static System.Action<long, long, uint, System.IO.Stream, System.IO.Compression.ZipArchiveEntry, System.EventHandler> <>9__72_0
- public static System.EventHandler <>9__75_0
- public static System.Action<System.IO.Compression.ZipArchiveEntry> <>9__76_0

#### Constructors
- private static ZipArchiveEntry.<>c()
- public ZipArchiveEntry.<>c()

#### Methods
- internal void <GetDataCompressor>b__72_0(long initialPosition, long currentPosition, uint checkSum, System.IO.Stream backing, System.IO.Compression.ZipArchiveEntry thisRef, System.EventHandler closeHandler)
- internal void <OpenInUpdateMode>b__76_0(System.IO.Compression.ZipArchiveEntry thisRef)
- internal void <OpenInWriteMode>b__75_0(object o, System.EventArgs e)

### private class System.IO.Compression.Zip64ExtraField.<>c

#### Fields
- public static readonly System.IO.Compression.Zip64ExtraField.<>c <>9
- public static System.Predicate<System.IO.Compression.ZipGenericExtraField> <>9__24_0

#### Constructors
- private static Zip64ExtraField.<>c()
- public Zip64ExtraField.<>c()

#### Methods
- internal bool <RemoveZip64Blocks>b__24_0(System.IO.Compression.ZipGenericExtraField field)

### private class System.IO.Compression.Zip64ExtraField.<>c__DisplayClass23_0

#### Fields
- public bool readCompressedSize
- public bool readLocalHeaderOffset
- public bool readStartDiskNumber
- public bool readUncompressedSize
- public System.IO.Compression.Zip64ExtraField zip64Field
- public bool zip64FieldFound

#### Constructors
- public Zip64ExtraField.<>c__DisplayClass23_0()

#### Methods
- internal bool <GetAndRemoveZip64Block>b__0(System.IO.Compression.ZipGenericExtraField ef)

### private struct System.IO.Compression.DeflateStream.CopyToStream.<CopyFromSourceToDestinationAsync>d__6
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.IO.Compression.DeflateStream.CopyToStream <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__1
- private System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct System.IO.Compression.DeflateStream.<PurgeBuffersAsync>d__59
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.IO.Compression.DeflateStream <>4__this
- public System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__1
- private bool <finished>5__2

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct System.IO.Compression.DeflateManagedStream.<ReadAsyncCore>d__28
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.IO.Compression.DeflateManagedStream <>4__this
- public System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder<int> <>t__builder
- private System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter<int> <>u__1
- public System.Memory<byte> buffer
- public System.Threading.CancellationToken cancellationToken
- public System.Threading.Tasks.ValueTask<int> readTask

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct System.IO.Compression.DeflateStream.CopyToStream.<WriteAsyncCore>d__10
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.IO.Compression.DeflateStream.CopyToStream <>4__this
- public System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__1
- public System.ReadOnlyMemory<byte> buffer
- public System.Threading.CancellationToken cancellationToken

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private struct System.IO.Compression.DeflateStream.<WriteDeflaterOutputAsync>d__67
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.IO.Compression.DeflateStream <>4__this
- public System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__1
- public System.Threading.CancellationToken cancellationToken

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### internal enum System.IO.Compression.ZipArchiveEntry.BitFlagValues
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DataDescriptor = 8
- IsEncrypted = 1
- UnicodeFileNameAndComment = 2048

### internal enum System.IO.Compression.BlockType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Dynamic = 2
- Static = 1
- Uncompressed = 0

### internal class System.IO.Compression.CheckSumAndSizeWriteStream
- Base: System.IO.Stream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- private readonly System.IO.Stream _baseBaseStream
- private readonly System.IO.Stream _baseStream
- private readonly bool _canWrite
- private uint _checksum
- private bool _everWritten
- private long _initialPosition
- private bool _isDisposed
- private readonly bool _leaveOpenOnClose
- private readonly System.EventHandler _onClose
- private long _position
- private readonly System.Action<long, long, uint, System.IO.Stream, System.IO.Compression.ZipArchiveEntry, System.EventHandler> _saveCrcAndSizes
- private readonly System.IO.Compression.ZipArchiveEntry _zipArchiveEntry

#### Properties
- public bool CanRead { get; }
- public bool CanSeek { get; }
- public bool CanWrite { get; }
- public long Length { get; }
- public long Position { get; set; }

#### Constructors
- public CheckSumAndSizeWriteStream(System.IO.Stream baseStream, System.IO.Stream baseBaseStream, bool leaveOpenOnClose, System.IO.Compression.ZipArchiveEntry entry, System.EventHandler onClose, System.Action<long, long, uint, System.IO.Stream, System.IO.Compression.ZipArchiveEntry, System.EventHandler> saveCrcAndSizes)

#### Methods
- private System.Threading.Tasks.ValueTask <WriteAsync>g__Core|32_0(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken = null)
- protected override void Dispose(bool disposing)
- public override void Flush()
- public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken)
- public override int Read(byte[] buffer, int offset, int count)
- public override long Seek(long offset, System.IO.SeekOrigin origin)
- public override void SetLength(long value)
- private void ThrowIfDisposed()
- public override void Write(byte[] buffer, int offset, int count)
- public override void Write(System.ReadOnlySpan<byte> source)
- public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
- public override System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken = null)
- public override void WriteByte(byte value)

### public enum System.IO.Compression.ZLibNative.CompressionLevel
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BestCompression = 9
- BestSpeed = 1
- DefaultCompression = -1
- NoCompression = 0

### public enum System.IO.Compression.CompressionLevel
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Fastest = 1
- NoCompression = 2
- Optimal = 0
- SmallestSize = 3

### public enum System.IO.Compression.ZLibNative.CompressionMethod
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Deflated = 8

### internal enum System.IO.Compression.ZipArchiveEntry.CompressionMethodValues
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BZip2 = 12
- Deflate = 8
- Deflate64 = 9
- LZMA = 14
- Stored = 0

### public enum System.IO.Compression.CompressionMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Compress = 1
- Decompress = 0

### public enum System.IO.Compression.ZLibNative.CompressionStrategy
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DefaultStrategy = 0

### private class System.IO.Compression.DeflateStream.CopyToStream
- Base: System.IO.Stream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- private byte[] _arrayPoolBuffer
- private readonly System.Threading.CancellationToken _cancellationToken
- private readonly System.IO.Compression.DeflateStream _deflateStream
- private readonly System.IO.Stream _destination

#### Properties
- public bool CanRead { get; }
- public bool CanSeek { get; }
- public bool CanWrite { get; }
- public long Length { get; }
- public long Position { get; set; }

#### Constructors
- public DeflateStream.CopyToStream(System.IO.Compression.DeflateStream deflateStream, System.IO.Stream destination, int bufferSize)
- public DeflateStream.CopyToStream(System.IO.Compression.DeflateStream deflateStream, System.IO.Stream destination, int bufferSize, System.Threading.CancellationToken cancellationToken)

#### Methods
- public void CopyFromSourceToDestination()
- public System.Threading.Tasks.Task CopyFromSourceToDestinationAsync()
- public override void Flush()
- public override int Read(byte[] buffer, int offset, int count)
- public override long Seek(long offset, System.IO.SeekOrigin origin)
- public override void SetLength(long value)
- public override void Write(byte[] buffer, int offset, int count)
- public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
- public override System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken = null)
- private System.Threading.Tasks.ValueTask WriteAsyncCore(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken)

### internal static class System.IO.Compression.Crc32Helper

#### Methods
- public static uint UpdateCrc32(uint crc32, byte[] buffer, int offset, int length)
- public static uint UpdateCrc32(uint crc32, System.ReadOnlySpan<byte> buffer)

### internal class System.IO.Compression.DeflateManagedStream
- Base: System.IO.Stream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- private int _asyncOperations
- private readonly byte[] _buffer
- private System.IO.Compression.InflaterManaged _inflater
- private System.IO.Stream _stream

#### Properties
- public bool CanRead { get; }
- public bool CanSeek { get; }
- public bool CanWrite { get; }
- public long Length { get; }
- public long Position { get; set; }

#### Constructors
- internal DeflateManagedStream(System.IO.Stream stream, System.IO.Compression.ZipArchiveEntry.CompressionMethodValues method, long uncompressedSize = -1)

#### Methods
- public override System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState)
- protected override void Dispose(bool disposing)
- public override int EndRead(System.IAsyncResult asyncResult)
- private void EnsureNotDisposed()
- public override void Flush()
- public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken)
- private void PurgeBuffers(bool disposing)
- public override int Read(byte[] buffer, int offset, int count)
- public override int Read(System.Span<byte> buffer)
- public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
- public override System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken = null)
- private System.Threading.Tasks.ValueTask<int> ReadAsyncCore(System.Threading.Tasks.ValueTask<int> readTask, System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken)
- private System.Threading.Tasks.ValueTask<int> ReadAsyncInternal(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken)
- public override int ReadByte()
- public override long Seek(long offset, System.IO.SeekOrigin origin)
- public override void SetLength(long value)
- public override void Write(byte[] buffer, int offset, int count)

### internal class System.IO.Compression.Deflater
- Interfaces: System.IDisposable

#### Fields
- private System.Buffers.MemoryHandle _inputBufferHandle
- private bool _isDisposed
- private readonly System.IO.Compression.ZLibNative.ZLibStreamHandle _zlibStream

#### Properties
- private object SyncLock { get; }

#### Constructors
- internal Deflater(System.IO.Compression.CompressionLevel compressionLevel, int windowBits)

#### Methods
- private void DeallocateInputBufferHandle()
- private System.IO.Compression.ZLibNative.ErrorCode Deflate(System.IO.Compression.ZLibNative.FlushCode flushCode)
- public void Dispose()
- private void Dispose(bool disposing)
- protected override void Finalize()
- internal bool Finish(byte[] outputBuffer, out int bytesRead)
- internal bool Flush(byte[] outputBuffer, out int bytesRead)
- internal int GetDeflateOutput(byte[] outputBuffer)
- public bool NeedsInput()
- private System.IO.Compression.ZLibNative.ErrorCode ReadDeflateOutput(byte[] outputBuffer, System.IO.Compression.ZLibNative.FlushCode flushCode, out int bytesRead)
- internal void SetInput(System.ReadOnlyMemory<byte> inputBuffer)
- internal void SetInput(byte* inputBufferPtr, int count)

### public class System.IO.Compression.DeflateStream
- Base: System.IO.Stream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- private static readonly bool s_useStrictValidation
- private int _activeAsyncOperation
- private byte[] _buffer
- private System.IO.Compression.Deflater _deflater
- private System.IO.Compression.Inflater _inflater
- private bool _leaveOpen
- private System.IO.Compression.CompressionMode _mode
- private System.IO.Stream _stream
- private bool _wroteBytes

#### Properties
- private bool AsyncOperationIsActive { get; }
- public System.IO.Stream BaseStream { get; }
- public bool CanRead { get; }
- public bool CanSeek { get; }
- public bool CanWrite { get; }
- private bool InflatorIsFinished { get; }
- public long Length { get; }
- public long Position { get; set; }

#### Constructors
- private static DeflateStream()
- public DeflateStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode)
- public DeflateStream(System.IO.Stream stream, System.IO.Compression.CompressionLevel compressionLevel)
- internal DeflateStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, long uncompressedSize)
- public DeflateStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, bool leaveOpen)
- public DeflateStream(System.IO.Stream stream, System.IO.Compression.CompressionLevel compressionLevel, bool leaveOpen)
- internal DeflateStream(System.IO.Stream stream, System.IO.Compression.CompressionLevel compressionLevel, bool leaveOpen, int windowBits)
- internal DeflateStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, bool leaveOpen, int windowBits, long uncompressedSize = -1)

#### Methods
- private System.Threading.Tasks.ValueTask <DisposeAsync>g__Core|61_0()
- internal static void <EnsureCompressionMode>g__ThrowCannotWriteToDeflateStreamException|44_0()
- internal static void <EnsureDecompressionMode>g__ThrowCannotReadFromDeflateStreamException|43_0()
- private System.Threading.Tasks.Task <FlushAsync>g__Core|33_0(System.Threading.CancellationToken cancellationToken)
- private System.Threading.Tasks.ValueTask<int> <ReadAsyncMemory>g__Core|51_0(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken)
- private System.Threading.Tasks.ValueTask <WriteAsyncMemory>g__Core|66_0(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken)
- private void AsyncOperationCompleting()
- private void AsyncOperationStarting()
- public override System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState)
- public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState)
- public override void CopyTo(System.IO.Stream destination, int bufferSize)
- public override System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize, System.Threading.CancellationToken cancellationToken)
- protected override void Dispose(bool disposing)
- public override System.Threading.Tasks.ValueTask DisposeAsync()
- public override int EndRead(System.IAsyncResult asyncResult)
- public override void EndWrite(System.IAsyncResult asyncResult)
- private void EnsureBufferInitialized()
- private void EnsureCompressionMode()
- private void EnsureDecompressionMode()
- private void EnsureNoActiveAsyncOperation()
- private void EnsureNotDisposed()
- public override void Flush()
- public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken)
- private void FlushBuffers()
- private void InitializeBuffer()
- internal void InitializeDeflater(System.IO.Stream stream, bool leaveOpen, int windowBits, System.IO.Compression.CompressionLevel compressionLevel)
- private void PurgeBuffers(bool disposing)
- private System.Threading.Tasks.ValueTask PurgeBuffersAsync()
- public override int Read(byte[] buffer, int offset, int count)
- public override int Read(System.Span<byte> buffer)
- public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
- public override System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken = null)
- internal System.Threading.Tasks.ValueTask<int> ReadAsyncMemory(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken)
- public override int ReadByte()
- internal int ReadCore(System.Span<byte> buffer)
- public override long Seek(long offset, System.IO.SeekOrigin origin)
- public override void SetLength(long value)
- private static void ThrowGenericInvalidData()
- private static void ThrowInvalidBeginCall()
- private static void ThrowTruncatedInvalidData()
- public override void Write(byte[] buffer, int offset, int count)
- public override void Write(System.ReadOnlySpan<byte> buffer)
- public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
- public override System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken)
- internal System.Threading.Tasks.ValueTask WriteAsyncMemory(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken)
- public override void WriteByte(byte value)
- internal void WriteCore(System.ReadOnlySpan<byte> buffer)
- private void WriteDeflaterOutput()
- private System.Threading.Tasks.ValueTask WriteDeflaterOutputAsync(System.Threading.CancellationToken cancellationToken)

### private class System.IO.Compression.ZipArchiveEntry.DirectToArchiveWriterStream
- Base: System.IO.Stream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- private bool _canWrite
- private readonly System.IO.Compression.CheckSumAndSizeWriteStream _crcSizeStream
- private readonly System.IO.Compression.ZipArchiveEntry _entry
- private bool _everWritten
- private bool _isDisposed
- private long _position
- private bool _usedZip64inLH

#### Properties
- public bool CanRead { get; }
- public bool CanSeek { get; }
- public bool CanWrite { get; }
- public long Length { get; }
- public long Position { get; set; }

#### Constructors
- public ZipArchiveEntry.DirectToArchiveWriterStream(System.IO.Compression.CheckSumAndSizeWriteStream crcSizeStream, System.IO.Compression.ZipArchiveEntry entry)

#### Methods
- private System.Threading.Tasks.ValueTask <WriteAsync>g__Core|27_0(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken)
- protected override void Dispose(bool disposing)
- public override void Flush()
- public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken)
- public override int Read(byte[] buffer, int offset, int count)
- public override long Seek(long offset, System.IO.SeekOrigin origin)
- public override void SetLength(long value)
- private void ThrowIfDisposed()
- public override void Write(byte[] buffer, int offset, int count)
- public override void Write(System.ReadOnlySpan<byte> source)
- public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
- public override System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken = null)
- public override void WriteByte(byte value)

### public enum System.IO.Compression.ZLibNative.ErrorCode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BufError = -5
- DataError = -3
- MemError = -4
- Ok = 0
- StreamEnd = 1
- StreamError = -2
- VersionError = -6

### public enum System.IO.Compression.ZLibNative.FlushCode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Block = 5
- Finish = 4
- NoFlush = 0
- SyncFlush = 2

### public class System.IO.Compression.GZipStream
- Base: System.IO.Stream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- private System.IO.Compression.DeflateStream _deflateStream

#### Properties
- public System.IO.Stream BaseStream { get; }
- public bool CanRead { get; }
- public bool CanSeek { get; }
- public bool CanWrite { get; }
- public long Length { get; }
- public long Position { get; set; }

#### Constructors
- public GZipStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode)
- public GZipStream(System.IO.Stream stream, System.IO.Compression.CompressionLevel compressionLevel)
- public GZipStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, bool leaveOpen)
- public GZipStream(System.IO.Stream stream, System.IO.Compression.CompressionLevel compressionLevel, bool leaveOpen)

#### Methods
- public override System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState)
- public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState)
- private void CheckDeflateStream()
- public override void CopyTo(System.IO.Stream destination, int bufferSize)
- public override System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize, System.Threading.CancellationToken cancellationToken)
- protected override void Dispose(bool disposing)
- public override System.Threading.Tasks.ValueTask DisposeAsync()
- public override int EndRead(System.IAsyncResult asyncResult)
- public override void EndWrite(System.IAsyncResult asyncResult)
- public override void Flush()
- public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken)
- public override int Read(byte[] buffer, int offset, int count)
- public override int Read(System.Span<byte> buffer)
- public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
- public override System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken = null)
- public override int ReadByte()
- public override long Seek(long offset, System.IO.SeekOrigin origin)
- public override void SetLength(long value)
- public override void Write(byte[] buffer, int offset, int count)
- public override void Write(System.ReadOnlySpan<byte> buffer)
- public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
- public override System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken = null)
- public override void WriteByte(byte value)

### internal class System.IO.Compression.HuffmanTree

#### Fields
- private static readonly System.IO.Compression.HuffmanTree <StaticDistanceTree>k__BackingField
- private static readonly System.IO.Compression.HuffmanTree <StaticLiteralLengthTree>k__BackingField
- private readonly byte[] _codeLengthArray
- private readonly short[] _left
- private readonly short[] _right
- private readonly short[] _table
- private readonly int _tableBits
- private readonly int _tableMask

#### Properties
- public static System.IO.Compression.HuffmanTree StaticDistanceTree { get; }
- public static System.IO.Compression.HuffmanTree StaticLiteralLengthTree { get; }

#### Constructors
- private static HuffmanTree()
- public HuffmanTree(byte[] codeLengths)

#### Methods
- private static uint BitReverse(uint code, int length)
- private uint[] CalculateHuffmanCode()
- private void CreateTable()
- public int GetNextSymbol(System.IO.Compression.InputBuffer input)
- private static byte[] GetStaticDistanceTreeLength()
- private static byte[] GetStaticLiteralTreeLength()

### internal class System.IO.Compression.Inflater
- Interfaces: System.IDisposable

#### Fields
- private long _currentInflatedCount
- private bool _finished
- private System.Buffers.MemoryHandle _inputBufferHandle
- private bool _isDisposed
- private bool _nonEmptyInput
- private readonly long _uncompressedSize
- private readonly int _windowBits
- private System.IO.Compression.ZLibNative.ZLibStreamHandle _zlibStream

#### Properties
- private bool IsInputBufferHandleAllocated { get; }
- private object SyncLock { get; }

#### Constructors
- internal Inflater(int windowBits, long uncompressedSize = -1)

#### Methods
- private void DeallocateInputBufferHandle()
- private void Dispose(bool disposing)
- public void Dispose()
- protected override void Finalize()
- public bool Finished()
- public bool Inflate(out byte b)
- public int Inflate(byte[] bytes, int offset, int length)
- public int Inflate(System.Span<byte> destination)
- private System.IO.Compression.ZLibNative.ErrorCode Inflate(System.IO.Compression.ZLibNative.FlushCode flushCode)
- private void InflateInit(int windowBits)
- public int InflateVerified(byte* bufPtr, int length)
- internal bool IsGzipStream()
- public bool NeedsInput()
- public bool NonEmptyInput()
- private System.IO.Compression.ZLibNative.ErrorCode ReadInflateOutput(byte* bufPtr, int length, System.IO.Compression.ZLibNative.FlushCode flushCode, out int bytesRead)
- private void ReadOutput(byte* bufPtr, int length, out int bytesRead)
- private bool ResetStreamForLeftoverInput()
- public void SetInput(byte[] inputBuffer, int startIndex, int count)
- public void SetInput(System.ReadOnlyMemory<byte> inputBuffer)

### internal class System.IO.Compression.InflaterManaged

#### Fields
- private int _bfinal
- private int _blockLength
- private readonly byte[] _blockLengthBuffer
- private System.IO.Compression.BlockType _blockType
- private int _codeArraySize
- private int _codeLengthCodeCount
- private System.IO.Compression.HuffmanTree _codeLengthTree
- private readonly byte[] _codeLengthTreeCodeLength
- private readonly byte[] _codeList
- private long _currentInflatedCount
- private readonly bool _deflate64
- private int _distanceCode
- private int _distanceCodeCount
- private System.IO.Compression.HuffmanTree _distanceTree
- private int _extraBits
- private readonly System.IO.Compression.InputBuffer _input
- private int _length
- private int _lengthCode
- private int _literalLengthCodeCount
- private System.IO.Compression.HuffmanTree _literalLengthTree
- private int _loopCounter
- private readonly System.IO.Compression.OutputWindow _output
- private System.IO.Compression.InflaterState _state
- private readonly long _uncompressedSize

#### Properties
- private static System.ReadOnlySpan<byte> CodeOrder { get; }
- private static System.ReadOnlySpan<ushort> DistanceBasePosition { get; }
- private static System.ReadOnlySpan<byte> ExtraLengthBits { get; }
- private static System.ReadOnlySpan<byte> LengthBase { get; }
- private static System.ReadOnlySpan<byte> StaticDistanceTreeTable { get; }

#### Constructors
- internal InflaterManaged(bool deflate64, long uncompressedSize)

#### Methods
- private bool Decode()
- private bool DecodeBlock(out bool end_of_block_code_seen)
- private bool DecodeDynamicBlockHeader()
- private bool DecodeUncompressedBlock(out bool end_of_block)
- public bool Finished()
- public int Inflate(System.Span<byte> bytes)
- public void SetInput(byte[] inputBytes, int offset, int length)

### internal enum System.IO.Compression.InflaterState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DecodeTop = 10
- DecodingUncompressed = 20
- Done = 24
- HaveDistCode = 13
- HaveFullLength = 12
- HaveInitialLength = 11
- ReadingBFinal = 2
- ReadingBType = 3
- ReadingCodeLengthCodes = 7
- ReadingFooter = 22
- ReadingHeader = 0
- ReadingNumCodeLengthCodes = 6
- ReadingNumDistCodes = 5
- ReadingNumLitCodes = 4
- ReadingTreeCodesAfter = 9
- ReadingTreeCodesBefore = 8
- StartReadingFooter = 21
- UncompressedAligning = 15
- UncompressedByte1 = 16
- UncompressedByte2 = 17
- UncompressedByte3 = 18
- UncompressedByte4 = 19
- VerifyingFooter = 23

### internal class System.IO.Compression.InputBuffer

#### Fields
- private uint _bitBuffer
- private int _bitsInBuffer
- private System.Memory<byte> _buffer

#### Properties
- public int AvailableBits { get; }
- public int AvailableBytes { get; }

#### Constructors
- public InputBuffer()

#### Methods
- public int CopyTo(System.Memory<byte> output)
- public int CopyTo(byte[] output, int offset, int length)
- public bool EnsureBitsAvailable(int count)
- private static uint GetBitMask(int count)
- public int GetBits(int count)
- public bool NeedsInput()
- public void SetInput(System.Memory<byte> buffer)
- public void SetInput(byte[] buffer, int offset, int length)
- public void SkipBits(int n)
- public void SkipToByteBoundary()
- public uint TryLoad16Bits()

### internal class System.IO.Compression.OutputWindow

#### Fields
- private int _bytesUsed
- private int _end
- private readonly byte[] _window

#### Properties
- public int FreeBytes { get; }

#### Constructors
- public OutputWindow()

#### Methods
- internal void ClearBytesUsed()
- public int CopyFrom(System.IO.Compression.InputBuffer input, int length)
- public int CopyTo(System.Span<byte> output)
- public void Write(byte b)
- public void WriteLengthDistance(int length, int distance)

### internal class System.IO.Compression.PositionPreservingWriteOnlyStreamWrapper
- Base: System.IO.Stream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- private long _position
- private readonly System.IO.Stream _stream

#### Properties
- public bool CanRead { get; }
- public bool CanSeek { get; }
- public bool CanTimeout { get; }
- public bool CanWrite { get; }
- public long Length { get; }
- public long Position { get; set; }
- public int ReadTimeout { get; set; }
- public int WriteTimeout { get; set; }

#### Constructors
- public PositionPreservingWriteOnlyStreamWrapper(System.IO.Stream stream)

#### Methods
- public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state)
- public override void Close()
- protected override void Dispose(bool disposing)
- public override void EndWrite(System.IAsyncResult asyncResult)
- public override void Flush()
- public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken)
- public override int Read(byte[] buffer, int offset, int count)
- public override long Seek(long offset, System.IO.SeekOrigin origin)
- public override void SetLength(long value)
- public override void Write(byte[] buffer, int offset, int count)
- public override void Write(System.ReadOnlySpan<byte> buffer)
- public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
- public override System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken = null)
- public override void WriteByte(byte value)

### public enum System.IO.Compression.ZLibNative.ZLibStreamHandle.State
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Disposed = 3
- InitializedForDeflate = 1
- InitializedForInflate = 2
- NotInitialized = 0

### internal class System.IO.Compression.SubReadStream
- Base: System.IO.Stream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- private bool _canRead
- private readonly long _endInSuperStream
- private bool _isDisposed
- private long _positionInSuperStream
- private readonly long _startInSuperStream
- private readonly System.IO.Stream _superStream

#### Properties
- public bool CanRead { get; }
- public bool CanSeek { get; }
- public bool CanWrite { get; }
- public long Length { get; }
- public long Position { get; set; }

#### Constructors
- public SubReadStream(System.IO.Stream superStream, long startPosition, long maxLength)

#### Methods
- private System.Threading.Tasks.ValueTask<int> <ReadAsync>g__Core|24_0(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken)
- protected override void Dispose(bool disposing)
- public override void Flush()
- public override int Read(byte[] buffer, int offset, int count)
- public override int Read(System.Span<byte> destination)
- public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
- public override System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken = null)
- public override int ReadByte()
- public override long Seek(long offset, System.IO.SeekOrigin origin)
- public override void SetLength(long value)
- private void ThrowIfCantRead()
- private void ThrowIfDisposed()
- public override void Write(byte[] buffer, int offset, int count)

### internal class System.IO.Compression.WrappedStream
- Base: System.IO.Stream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- private readonly System.IO.Stream _baseStream
- private readonly bool _closeBaseStream
- private bool _isDisposed
- private readonly System.Action<System.IO.Compression.ZipArchiveEntry> _onClosed
- private readonly System.IO.Compression.ZipArchiveEntry _zipArchiveEntry

#### Properties
- public bool CanRead { get; }
- public bool CanSeek { get; }
- public bool CanWrite { get; }
- public long Length { get; }
- public long Position { get; set; }

#### Constructors
- internal WrappedStream(System.IO.Stream baseStream, bool closeBaseStream)
- internal WrappedStream(System.IO.Stream baseStream, System.IO.Compression.ZipArchiveEntry entry, System.Action<System.IO.Compression.ZipArchiveEntry> onClosed)
- private WrappedStream(System.IO.Stream baseStream, bool closeBaseStream, System.IO.Compression.ZipArchiveEntry entry, System.Action<System.IO.Compression.ZipArchiveEntry> onClosed)

#### Methods
- protected override void Dispose(bool disposing)
- public override void Flush()
- public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken)
- public override int Read(byte[] buffer, int offset, int count)
- public override int Read(System.Span<byte> buffer)
- public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
- public override System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken = null)
- public override int ReadByte()
- public override long Seek(long offset, System.IO.SeekOrigin origin)
- public override void SetLength(long value)
- private void ThrowIfCantRead()
- private void ThrowIfCantSeek()
- private void ThrowIfCantWrite()
- private void ThrowIfDisposed()
- public override void Write(byte[] buffer, int offset, int count)
- public override void Write(System.ReadOnlySpan<byte> source)
- public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
- public override System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken = null)
- public override void WriteByte(byte value)

### internal struct System.IO.Compression.Zip64EndOfCentralDirectoryLocator

#### Fields
- public uint NumberOfDiskWithZip64EOCD
- public ulong OffsetOfZip64EOCD
- public uint TotalNumberOfDisks

#### Methods
- public static bool TryReadBlock(System.IO.BinaryReader reader, out System.IO.Compression.Zip64EndOfCentralDirectoryLocator zip64EOCDLocator)
- public static void WriteBlock(System.IO.Stream stream, long zip64EOCDRecordStart)

### internal struct System.IO.Compression.Zip64EndOfCentralDirectoryRecord

#### Fields
- public uint NumberOfDiskWithStartOfCD
- public ulong NumberOfEntriesOnThisDisk
- public ulong NumberOfEntriesTotal
- public uint NumberOfThisDisk
- public ulong OffsetOfCentralDirectory
- public ulong SizeOfCentralDirectory
- public ulong SizeOfThisRecord
- public ushort VersionMadeBy
- public ushort VersionNeededToExtract

#### Methods
- public static bool TryReadBlock(System.IO.BinaryReader reader, out System.IO.Compression.Zip64EndOfCentralDirectoryRecord zip64EOCDRecord)
- public static void WriteBlock(System.IO.Stream stream, long numberOfEntries, long startOfCentralDirectory, long sizeOfCentralDirectory)

### internal struct System.IO.Compression.Zip64ExtraField

#### Fields
- private System.Nullable<long> _compressedSize
- private System.Nullable<long> _localHeaderOffset
- private ushort _size
- private System.Nullable<uint> _startDiskNumber
- private System.Nullable<long> _uncompressedSize

#### Properties
- public System.Nullable<long> CompressedSize { get; set; }
- public System.Nullable<long> LocalHeaderOffset { get; set; }
- public System.Nullable<uint> StartDiskNumber { get; }
- public ushort TotalSize { get; }
- public System.Nullable<long> UncompressedSize { get; set; }

#### Methods
- public static System.IO.Compression.Zip64ExtraField GetAndRemoveZip64Block(System.Collections.Generic.List<System.IO.Compression.ZipGenericExtraField> extraFields, bool readUncompressedSize, bool readCompressedSize, bool readLocalHeaderOffset, bool readStartDiskNumber)
- public static System.IO.Compression.Zip64ExtraField GetJustZip64Block(System.IO.Stream extraFieldStream, bool readUncompressedSize, bool readCompressedSize, bool readLocalHeaderOffset, bool readStartDiskNumber)
- public static void RemoveZip64Blocks(System.Collections.Generic.List<System.IO.Compression.ZipGenericExtraField> extraFields)
- private static bool TryGetZip64BlockFromGenericExtraField(System.IO.Compression.ZipGenericExtraField extraField, bool readUncompressedSize, bool readCompressedSize, bool readLocalHeaderOffset, bool readStartDiskNumber, out System.IO.Compression.Zip64ExtraField zip64Block)
- private void UpdateSize()
- public void WriteBlock(System.IO.Stream stream)

### public class System.IO.Compression.ZipArchive
- Interfaces: System.IDisposable

#### Fields
- private byte[] _archiveComment
- private readonly System.IO.BinaryReader _archiveReader
- private readonly System.IO.Stream _archiveStream
- private System.IO.Compression.ZipArchiveEntry _archiveStreamOwner
- private readonly System.IO.Stream _backingStream
- private long _centralDirectoryStart
- private readonly System.Collections.Generic.List<System.IO.Compression.ZipArchiveEntry> _entries
- private readonly System.Collections.ObjectModel.ReadOnlyCollection<System.IO.Compression.ZipArchiveEntry> _entriesCollection
- private readonly System.Collections.Generic.Dictionary<string, System.IO.Compression.ZipArchiveEntry> _entriesDictionary
- private System.Text.Encoding _entryNameAndCommentEncoding
- private long _expectedNumberOfEntries
- private bool _isDisposed
- private readonly bool _leaveOpen
- private readonly System.IO.Compression.ZipArchiveMode _mode
- private uint _numberOfThisDisk
- private bool _readEntries

#### Properties
- internal System.IO.BinaryReader ArchiveReader { get; }
- internal System.IO.Stream ArchiveStream { get; }
- public string Comment { get; set; }
- public System.Collections.ObjectModel.ReadOnlyCollection<System.IO.Compression.ZipArchiveEntry> Entries { get; }
- internal System.Text.Encoding EntryNameAndCommentEncoding { get; private set; }
- public System.IO.Compression.ZipArchiveMode Mode { get; }
- internal uint NumberOfThisDisk { get; }

#### Constructors
- public ZipArchive(System.IO.Stream stream)
- public ZipArchive(System.IO.Stream stream, System.IO.Compression.ZipArchiveMode mode)
- public ZipArchive(System.IO.Stream stream, System.IO.Compression.ZipArchiveMode mode, bool leaveOpen)
- public ZipArchive(System.IO.Stream stream, System.IO.Compression.ZipArchiveMode mode, bool leaveOpen, System.Text.Encoding entryNameEncoding)

#### Methods
- internal void AcquireArchiveStream(System.IO.Compression.ZipArchiveEntry entry)
- private void AddEntry(System.IO.Compression.ZipArchiveEntry entry)
- private void CloseStreams()
- public System.IO.Compression.ZipArchiveEntry CreateEntry(string entryName)
- public System.IO.Compression.ZipArchiveEntry CreateEntry(string entryName, System.IO.Compression.CompressionLevel compressionLevel)
- protected virtual void Dispose(bool disposing)
- public void Dispose()
- private System.IO.Compression.ZipArchiveEntry DoCreateEntry(string entryName, System.Nullable<System.IO.Compression.CompressionLevel> compressionLevel)
- private void EnsureCentralDirectoryRead()
- public System.IO.Compression.ZipArchiveEntry GetEntry(string entryName)
- private void ReadCentralDirectory()
- private void ReadEndOfCentralDirectory()
- internal void ReleaseArchiveStream(System.IO.Compression.ZipArchiveEntry entry)
- internal void RemoveEntry(System.IO.Compression.ZipArchiveEntry entry)
- internal void ThrowIfDisposed()
- private void TryReadZip64EndOfCentralDirectory(System.IO.Compression.ZipEndOfCentralDirectoryBlock eocd, long eocdStart)
- private void WriteArchiveEpilogue(long startOfCentralDirectory, long sizeOfCentralDirectory)
- private void WriteFile()

### public class System.IO.Compression.ZipArchiveEntry

#### Fields
- private static readonly bool s_allowLargeZipArchiveEntriesInUpdateMode
- private System.IO.Compression.ZipArchive _archive
- private System.Collections.Generic.List<System.IO.Compression.ZipGenericExtraField> _cdUnknownExtraFields
- private byte[][] _compressedBytes
- private long _compressedSize
- private readonly System.Nullable<System.IO.Compression.CompressionLevel> _compressionLevel
- private uint _crc32
- private bool _currentlyOpenForWrite
- private readonly uint _diskNumberStart
- private bool _everOpenedForWrite
- private uint _externalFileAttr
- private byte[] _fileComment
- private System.IO.Compression.ZipArchiveEntry.BitFlagValues _generalPurposeBitFlag
- private readonly bool _isEncrypted
- private System.DateTimeOffset _lastModified
- private System.Collections.Generic.List<System.IO.Compression.ZipGenericExtraField> _lhUnknownExtraFields
- private long _offsetOfLocalHeader
- private readonly bool _originallyInArchive
- private System.IO.Stream _outstandingWriteStream
- private System.IO.Compression.ZipArchiveEntry.CompressionMethodValues _storedCompressionMethod
- private string _storedEntryName
- private byte[] _storedEntryNameBytes
- private System.Nullable<long> _storedOffsetOfCompressedData
- private System.IO.MemoryStream _storedUncompressedData
- private long _uncompressedSize
- private readonly System.IO.Compression.ZipVersionMadeByPlatform _versionMadeByPlatform
- private System.IO.Compression.ZipVersionNeededValues _versionMadeBySpecification
- internal System.IO.Compression.ZipVersionNeededValues _versionToExtract

#### Properties
- public System.IO.Compression.ZipArchive Archive { get; }
- private bool AreSizesTooLarge { get; }
- public string Comment { get; set; }
- public long CompressedLength { get; }
- private System.IO.Compression.ZipArchiveEntry.CompressionMethodValues CompressionMethod { get; set; }
- public uint Crc32 { get; }
- internal bool EverOpenedForWrite { get; }
- public int ExternalAttributes { get; set; }
- public string FullName { get; private set; }
- public bool IsEncrypted { get; }
- private bool IsOffsetTooLarge { get; }
- public System.DateTimeOffset LastWriteTime { get; set; }
- public long Length { get; }
- public string Name { get; }
- private long OffsetOfCompressedData { get; }
- private bool ShouldUseZIP64 { get; }
- private System.IO.MemoryStream UncompressedData { get; }

#### Constructors
- private static ZipArchiveEntry()
- internal ZipArchiveEntry(System.IO.Compression.ZipArchive archive, System.IO.Compression.ZipCentralDirectoryFileHeader cd)
- internal ZipArchiveEntry(System.IO.Compression.ZipArchive archive, string entryName)
- internal ZipArchiveEntry(System.IO.Compression.ZipArchive archive, string entryName, System.IO.Compression.CompressionLevel compressionLevel)

#### Methods
- private void CloseStreams()
- public void Delete()
- private void DetectEntryNameVersion()
- private System.IO.Compression.CheckSumAndSizeWriteStream GetDataCompressor(System.IO.Stream backingStream, bool leaveBackingStreamOpen, System.EventHandler onClose)
- private System.IO.Stream GetDataDecompressor(System.IO.Stream compressedStreamToRead)
- private static string GetFileName_Unix(string path)
- private static string GetFileName_Windows(string path)
- private bool IsOpenable(bool needToUncompress, bool needToLoadIntoMemory, out string message)
- internal bool LoadLocalHeaderExtraFieldAndCompressedBytesIfNeeded()
- public System.IO.Stream Open()
- private System.IO.Stream OpenInReadMode(bool checkOpenable)
- private System.IO.Compression.WrappedStream OpenInUpdateMode()
- private System.IO.Compression.WrappedStream OpenInWriteMode()
- internal static string ParseFileName(string path, System.IO.Compression.ZipVersionMadeByPlatform madeByPlatform)
- private void ThrowIfInvalidArchive()
- internal void ThrowIfNotOpenable(bool needToUncompress, bool needToLoadIntoMemory)
- public override string ToString()
- private void UnloadStreams()
- private void VersionToExtractAtLeast(System.IO.Compression.ZipVersionNeededValues value)
- internal void WriteAndFinishLocalEntry()
- internal void WriteCentralDirectoryFileHeader()
- private void WriteCrcAndSizesInLocalHeader(bool zip64HeaderUsed)
- private void WriteDataDescriptor()
- private bool WriteLocalFileHeader(bool isEmptyFile)
- private void WriteLocalFileHeaderAndDataIfNeeded()

### public enum System.IO.Compression.ZipArchiveMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Create = 1
- Read = 0
- Update = 2

### internal struct System.IO.Compression.ZipCentralDirectoryFileHeader

#### Fields
- public long CompressedSize
- public ushort CompressionMethod
- public uint Crc32
- public uint DiskNumberStart
- public uint ExternalFileAttributes
- public ushort ExtraFieldLength
- public System.Collections.Generic.List<System.IO.Compression.ZipGenericExtraField> ExtraFields
- public byte[] FileComment
- public ushort FileCommentLength
- public byte[] Filename
- public ushort FilenameLength
- public ushort GeneralPurposeBitFlag
- public ushort InternalFileAttributes
- public uint LastModified
- public long RelativeOffsetOfLocalHeader
- public long UncompressedSize
- public byte VersionMadeByCompatibility
- public byte VersionMadeBySpecification
- public ushort VersionNeededToExtract

#### Methods
- public static bool TryReadBlock(System.IO.BinaryReader reader, bool saveExtraFieldsAndComments, out System.IO.Compression.ZipCentralDirectoryFileHeader header)

### internal struct System.IO.Compression.ZipEndOfCentralDirectoryBlock

#### Fields
- public byte[] ArchiveComment
- public ushort NumberOfEntriesInTheCentralDirectory
- public ushort NumberOfEntriesInTheCentralDirectoryOnThisDisk
- public ushort NumberOfTheDiskWithTheStartOfTheCentralDirectory
- public ushort NumberOfThisDisk
- public uint OffsetOfStartOfCentralDirectoryWithRespectToTheStartingDiskNumber
- public uint Signature
- public uint SizeOfCentralDirectory

#### Methods
- public static bool TryReadBlock(System.IO.BinaryReader reader, out System.IO.Compression.ZipEndOfCentralDirectoryBlock eocdBlock)
- public static void WriteBlock(System.IO.Stream stream, long numberOfEntries, long startOfCentralDirectory, long sizeOfCentralDirectory, byte[] archiveComment)

### internal struct System.IO.Compression.ZipGenericExtraField

#### Fields
- private byte[] _data
- private ushort _size
- private ushort _tag

#### Properties
- public byte[] Data { get; }
- public ushort Size { get; }
- public ushort Tag { get; }

#### Methods
- public static System.Collections.Generic.List<System.IO.Compression.ZipGenericExtraField> ParseExtraField(System.IO.Stream extraFieldData)
- public static int TotalSize(System.Collections.Generic.List<System.IO.Compression.ZipGenericExtraField> fields)
- public static bool TryReadBlock(System.IO.BinaryReader reader, long endExtraField, out System.IO.Compression.ZipGenericExtraField field)
- public static void WriteAllBlocks(System.Collections.Generic.List<System.IO.Compression.ZipGenericExtraField> fields, System.IO.Stream stream)
- public void WriteBlock(System.IO.Stream stream)

### internal static class System.IO.Compression.ZipHelper

#### Fields
- private static readonly System.DateTime s_invalidDateIndicator

#### Constructors
- private static ZipHelper()

#### Methods
- internal static void AdvanceToPosition(System.IO.Stream stream, long position)
- internal static uint DateTimeToDosTime(System.DateTime dateTime)
- internal static System.DateTime DosTimeToDateTime(uint dateTime)
- internal static byte[] GetEncodedTruncatedBytesFromString(string text, System.Text.Encoding encoding, int maxBytes, out bool isUTF8)
- internal static System.Text.Encoding GetEncoding(string text)
- internal static void ReadBytes(System.IO.Stream stream, byte[] buffer, int bytesToRead)
- private static bool SeekBackwardsAndRead(System.IO.Stream stream, byte[] buffer, out int bufferPointer)
- internal static bool SeekBackwardsToSignature(System.IO.Stream stream, uint signatureToFind, int maxBytesToRead)

### internal struct System.IO.Compression.ZipLocalFileHeader

#### Methods
- public static System.Collections.Generic.List<System.IO.Compression.ZipGenericExtraField> GetExtraFields(System.IO.BinaryReader reader)
- public static bool TrySkipBlock(System.IO.BinaryReader reader)

### internal enum System.IO.Compression.ZipVersionMadeByPlatform
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Unix = 3
- Windows = 0

### internal enum System.IO.Compression.ZipVersionNeededValues
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Default = 10
- Deflate = 20
- Deflate64 = 21
- ExplicitDirectory = 20
- Zip64 = 45

### public class System.IO.Compression.ZLibException
- Base: System.IO.IOException
- Interfaces: System.Runtime.Serialization.ISerializable

#### Fields
- private readonly System.IO.Compression.ZLibNative.ErrorCode _zlibErrorCode
- private readonly string _zlibErrorContext
- private readonly string _zlibErrorMessage

#### Constructors
- public ZLibException()
- public ZLibException(string message, System.Exception innerException)
- protected ZLibException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
- public ZLibException(string message, string zlibErrorContext, int zlibErrorCode, string zlibErrorMessage)

#### Methods
- private void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext context)

### internal static class System.IO.Compression.ZLibNative

#### Fields
- internal static readonly System.IntPtr ZNullPtr

#### Constructors
- private static ZLibNative()

#### Methods
- public static System.IO.Compression.ZLibNative.ErrorCode CreateZLibStreamForDeflate(out System.IO.Compression.ZLibNative.ZLibStreamHandle zLibStreamHandle, System.IO.Compression.ZLibNative.CompressionLevel level, int windowBits, int memLevel, System.IO.Compression.ZLibNative.CompressionStrategy strategy)
- public static System.IO.Compression.ZLibNative.ErrorCode CreateZLibStreamForInflate(out System.IO.Compression.ZLibNative.ZLibStreamHandle zLibStreamHandle, int windowBits)

### public class System.IO.Compression.ZLibStream
- Base: System.IO.Stream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- private System.IO.Compression.DeflateStream _deflateStream

#### Properties
- public System.IO.Stream BaseStream { get; }
- public bool CanRead { get; }
- public bool CanSeek { get; }
- public bool CanWrite { get; }
- public long Length { get; }
- public long Position { get; set; }

#### Constructors
- public ZLibStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode)
- public ZLibStream(System.IO.Stream stream, System.IO.Compression.CompressionLevel compressionLevel)
- public ZLibStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, bool leaveOpen)
- public ZLibStream(System.IO.Stream stream, System.IO.Compression.CompressionLevel compressionLevel, bool leaveOpen)

#### Methods
- public override System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState)
- public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState)
- public override void CopyTo(System.IO.Stream destination, int bufferSize)
- public override System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize, System.Threading.CancellationToken cancellationToken)
- protected override void Dispose(bool disposing)
- public override System.Threading.Tasks.ValueTask DisposeAsync()
- public override int EndRead(System.IAsyncResult asyncResult)
- public override void EndWrite(System.IAsyncResult asyncResult)
- public override void Flush()
- public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken)
- public override int Read(byte[] buffer, int offset, int count)
- public override int Read(System.Span<byte> buffer)
- public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
- public override System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken = null)
- public override int ReadByte()
- public override long Seek(long offset, System.IO.SeekOrigin origin)
- public override void SetLength(long value)
- private void ThrowIfClosed()
- public override void Write(byte[] buffer, int offset, int count)
- public override void Write(System.ReadOnlySpan<byte> buffer)
- public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken)
- public override System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken = null)
- public override void WriteByte(byte value)

### public class System.IO.Compression.ZLibNative.ZLibStreamHandle
- Base: System.Runtime.InteropServices.SafeHandle
- Interfaces: System.IDisposable

#### Fields
- private System.IO.Compression.ZLibNative.ZLibStreamHandle.State _initializationState
- private System.IO.Compression.ZLibNative.ZStream _zStream

#### Properties
- public uint AvailIn { get; set; }
- public uint AvailOut { get; set; }
- public System.IO.Compression.ZLibNative.ZLibStreamHandle.State InitializationState { get; }
- public bool IsInvalid { get; }
- public System.IntPtr NextIn { get; set; }
- public System.IntPtr NextOut { set; }

#### Constructors
- public ZLibNative.ZLibStreamHandle()

#### Methods
- public System.IO.Compression.ZLibNative.ErrorCode Deflate(System.IO.Compression.ZLibNative.FlushCode flush)
- public System.IO.Compression.ZLibNative.ErrorCode DeflateEnd()
- public System.IO.Compression.ZLibNative.ErrorCode DeflateInit2_(System.IO.Compression.ZLibNative.CompressionLevel level, int windowBits, int memLevel, System.IO.Compression.ZLibNative.CompressionStrategy strategy)
- private void EnsureNotDisposed()
- private void EnsureState(System.IO.Compression.ZLibNative.ZLibStreamHandle.State requiredState)
- public string GetErrorMessage()
- public System.IO.Compression.ZLibNative.ErrorCode Inflate(System.IO.Compression.ZLibNative.FlushCode flush)
- public System.IO.Compression.ZLibNative.ErrorCode InflateEnd()
- public System.IO.Compression.ZLibNative.ErrorCode InflateInit2_(int windowBits)
- protected override bool ReleaseHandle()

### internal struct System.IO.Compression.ZLibNative.ZStream

#### Fields
- internal uint availIn
- internal uint availOut
- private readonly System.IntPtr internalState
- internal System.IntPtr msg
- internal System.IntPtr nextIn
- internal System.IntPtr nextOut

