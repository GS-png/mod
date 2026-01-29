# Assembly: Ionic.Zlib.CF
- Path: tools/WorldBox.Managed/Ionic.Zlib.CF.dll
- Types: 44

## Namespace: (global)

### internal class <PrivateImplementationDetails>{02134F98-739C-44D1-A1F4-BF457D86AE9E}

#### Fields
- internal static <PrivateImplementationDetails>{02134F98-739C-44D1-A1F4-BF457D86AE9E}.__StaticArrayInitTypeSize=1152 $$method0x6000096-1
- internal static <PrivateImplementationDetails>{02134F98-739C-44D1-A1F4-BF457D86AE9E}.__StaticArrayInitTypeSize=120 $$method0x6000096-2
- internal static <PrivateImplementationDetails>{02134F98-739C-44D1-A1F4-BF457D86AE9E}.__StaticArrayInitTypeSize=76 $$method0x600010f-1
- internal static <PrivateImplementationDetails>{02134F98-739C-44D1-A1F4-BF457D86AE9E}.__StaticArrayInitTypeSize=68 $$method0x6000110-1
- internal static <PrivateImplementationDetails>{02134F98-739C-44D1-A1F4-BF457D86AE9E}.__StaticArrayInitTypeSize=6144 $$method0x6000112-1
- internal static <PrivateImplementationDetails>{02134F98-739C-44D1-A1F4-BF457D86AE9E}.__StaticArrayInitTypeSize=384 $$method0x6000112-2
- internal static <PrivateImplementationDetails>{02134F98-739C-44D1-A1F4-BF457D86AE9E}.__StaticArrayInitTypeSize=124 $$method0x6000112-3
- internal static <PrivateImplementationDetails>{02134F98-739C-44D1-A1F4-BF457D86AE9E}.__StaticArrayInitTypeSize=124 $$method0x6000112-4
- internal static <PrivateImplementationDetails>{02134F98-739C-44D1-A1F4-BF457D86AE9E}.__StaticArrayInitTypeSize=120 $$method0x6000112-5
- internal static <PrivateImplementationDetails>{02134F98-739C-44D1-A1F4-BF457D86AE9E}.__StaticArrayInitTypeSize=120 $$method0x6000112-6
- internal static <PrivateImplementationDetails>{02134F98-739C-44D1-A1F4-BF457D86AE9E}.__StaticArrayInitTypeSize=116 $$method0x6000113-1
- internal static <PrivateImplementationDetails>{02134F98-739C-44D1-A1F4-BF457D86AE9E}.__StaticArrayInitTypeSize=120 $$method0x6000113-2
- internal static <PrivateImplementationDetails>{02134F98-739C-44D1-A1F4-BF457D86AE9E}.__StaticArrayInitTypeSize=76 $$method0x6000113-3
- internal static <PrivateImplementationDetails>{02134F98-739C-44D1-A1F4-BF457D86AE9E}.__StaticArrayInitTypeSize=19 $$method0x6000113-4
- internal static <PrivateImplementationDetails>{02134F98-739C-44D1-A1F4-BF457D86AE9E}.__StaticArrayInitTypeSize=512 $$method0x6000113-5
- internal static <PrivateImplementationDetails>{02134F98-739C-44D1-A1F4-BF457D86AE9E}.__StaticArrayInitTypeSize=256 $$method0x6000113-6
- internal static <PrivateImplementationDetails>{02134F98-739C-44D1-A1F4-BF457D86AE9E}.__StaticArrayInitTypeSize=116 $$method0x6000113-7
- internal static <PrivateImplementationDetails>{02134F98-739C-44D1-A1F4-BF457D86AE9E}.__StaticArrayInitTypeSize=120 $$method0x6000113-8

### private struct <PrivateImplementationDetails>{02134F98-739C-44D1-A1F4-BF457D86AE9E}.__StaticArrayInitTypeSize=1152

### private struct <PrivateImplementationDetails>{02134F98-739C-44D1-A1F4-BF457D86AE9E}.__StaticArrayInitTypeSize=116

### private struct <PrivateImplementationDetails>{02134F98-739C-44D1-A1F4-BF457D86AE9E}.__StaticArrayInitTypeSize=120

### private struct <PrivateImplementationDetails>{02134F98-739C-44D1-A1F4-BF457D86AE9E}.__StaticArrayInitTypeSize=124

### private struct <PrivateImplementationDetails>{02134F98-739C-44D1-A1F4-BF457D86AE9E}.__StaticArrayInitTypeSize=19

### private struct <PrivateImplementationDetails>{02134F98-739C-44D1-A1F4-BF457D86AE9E}.__StaticArrayInitTypeSize=256

### private struct <PrivateImplementationDetails>{02134F98-739C-44D1-A1F4-BF457D86AE9E}.__StaticArrayInitTypeSize=384

### private struct <PrivateImplementationDetails>{02134F98-739C-44D1-A1F4-BF457D86AE9E}.__StaticArrayInitTypeSize=512

### private struct <PrivateImplementationDetails>{02134F98-739C-44D1-A1F4-BF457D86AE9E}.__StaticArrayInitTypeSize=6144

### private struct <PrivateImplementationDetails>{02134F98-739C-44D1-A1F4-BF457D86AE9E}.__StaticArrayInitTypeSize=68

### private struct <PrivateImplementationDetails>{02134F98-739C-44D1-A1F4-BF457D86AE9E}.__StaticArrayInitTypeSize=76

## Namespace: Ionic.Crc

### public class Ionic.Crc.CRC32

#### Fields
- private static const int BUFFER_SIZE
- private uint[] crc32Table
- private uint dwPolynomial
- private bool reverseBits
- private uint _register
- private long _TotalBytesRead

#### Properties
- public int Crc32Result { get; }
- public long TotalBytesRead { get; }

#### Constructors
- public CRC32()
- public CRC32(bool reverseBits)
- public CRC32(int polynomial, bool reverseBits)

#### Methods
- public void Combine(int crc, int length)
- public int ComputeCrc32(int W, byte B)
- private void GenerateLookupTable()
- public int GetCrc32(System.IO.Stream input)
- public int GetCrc32AndCopy(System.IO.Stream input, System.IO.Stream output)
- private void gf2_matrix_square(uint[] square, uint[] mat)
- private uint gf2_matrix_times(uint[] matrix, uint vec)
- public void Reset()
- private static uint ReverseBits(uint data)
- private static byte ReverseBits(byte data)
- public void SlurpBlock(byte[] block, int offset, int count)
- public void UpdateCRC(byte b)
- public void UpdateCRC(byte b, int n)
- internal int _InternalComputeCrc32(uint W, byte B)

### public class Ionic.Crc.CrcCalculatorStream
- Base: System.IO.Stream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- private static readonly long UnsetLengthLimit
- private Ionic.Crc.CRC32 _Crc32
- internal System.IO.Stream _innerStream
- private bool _leaveOpen
- private long _lengthLimit

#### Properties
- public bool CanRead { get; }
- public bool CanSeek { get; }
- public bool CanWrite { get; }
- public int Crc { get; }
- public bool LeaveOpen { get; set; }
- public long Length { get; }
- public long Position { get; set; }
- public long TotalBytesSlurped { get; }

#### Constructors
- private static CrcCalculatorStream()
- public CrcCalculatorStream(System.IO.Stream stream)
- public CrcCalculatorStream(System.IO.Stream stream, bool leaveOpen)
- public CrcCalculatorStream(System.IO.Stream stream, long length)
- public CrcCalculatorStream(System.IO.Stream stream, long length, bool leaveOpen)
- public CrcCalculatorStream(System.IO.Stream stream, long length, bool leaveOpen, Ionic.Crc.CRC32 crc32)
- private CrcCalculatorStream(bool leaveOpen, long length, System.IO.Stream stream, Ionic.Crc.CRC32 crc32)

#### Methods
- public override void Close()
- public override void Flush()
- public override int Read(byte[] buffer, int offset, int count)
- public override long Seek(long offset, System.IO.SeekOrigin origin)
- public override void SetLength(long value)
- private void System.IDisposable.Dispose()
- public override void Write(byte[] buffer, int offset, int count)

## Namespace: Ionic.Zlib

### public class Ionic.Zlib.Adler

#### Fields
- private static readonly uint BASE
- private static readonly int NMAX

#### Constructors
- public Adler()
- private static Adler()

#### Methods
- public static uint Adler32(uint adler, byte[] buf, int index, int len)

### internal enum Ionic.Zlib.BlockState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BlockDone = 1
- FinishDone = 3
- FinishStarted = 2
- NeedMore = 0

### internal delegate Ionic.Zlib.DeflateManager.CompressFunc
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public DeflateManager.CompressFunc(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Ionic.Zlib.FlushType flush, System.AsyncCallback callback, object object)
- public virtual Ionic.Zlib.BlockState EndInvoke(System.IAsyncResult result)
- public virtual Ionic.Zlib.BlockState Invoke(Ionic.Zlib.FlushType flush)

### public enum Ionic.Zlib.CompressionLevel
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BestCompression = 9
- BestSpeed = 1
- Default = 6
- Level0 = 0
- Level1 = 1
- Level2 = 2
- Level3 = 3
- Level4 = 4
- Level5 = 5
- Level6 = 6
- Level7 = 7
- Level8 = 8
- Level9 = 9
- None = 0

### public enum Ionic.Zlib.CompressionMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Compress = 0
- Decompress = 1

### public enum Ionic.Zlib.CompressionStrategy
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Default = 0
- Filtered = 1
- HuffmanOnly = 2

### internal class Ionic.Zlib.DeflateManager.Config

#### Fields
- internal Ionic.Zlib.DeflateFlavor Flavor
- internal int GoodLength
- internal int MaxChainLength
- internal int MaxLazy
- internal int NiceLength
- private static readonly Ionic.Zlib.DeflateManager.Config[] Table

#### Constructors
- private static DeflateManager.Config()
- private DeflateManager.Config(int goodLength, int maxLazy, int niceLength, int maxChainLength, Ionic.Zlib.DeflateFlavor flavor)

#### Methods
- public static Ionic.Zlib.DeflateManager.Config Lookup(Ionic.Zlib.CompressionLevel level)

### internal enum Ionic.Zlib.DeflateFlavor
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Fast = 1
- Slow = 2
- Store = 0

### internal class Ionic.Zlib.DeflateManager

#### Fields
- internal short bi_buf
- internal int bi_valid
- internal int block_start
- internal short[] bl_count
- internal short[] bl_tree
- private static readonly int Buf_size
- private static readonly int BUSY_STATE
- internal Ionic.Zlib.CompressionLevel compressionLevel
- internal Ionic.Zlib.CompressionStrategy compressionStrategy
- private Ionic.Zlib.DeflateManager.Config config
- internal sbyte data_type
- private Ionic.Zlib.DeflateManager.CompressFunc DeflateFunction
- internal sbyte[] depth
- internal short[] dyn_dtree
- internal short[] dyn_ltree
- private static readonly int DYN_TREES
- private static readonly int END_BLOCK
- private static readonly int FINISH_STATE
- internal int hash_bits
- internal int hash_mask
- internal int hash_shift
- internal int hash_size
- internal short[] head
- internal int[] heap
- internal int heap_len
- internal int heap_max
- private static readonly int HEAP_SIZE
- private static readonly int INIT_STATE
- internal int ins_h
- internal int last_eob_len
- internal int last_flush
- internal int last_lit
- internal int lit_bufsize
- internal int lookahead
- internal int matches
- internal int match_available
- internal int match_length
- internal int match_start
- private static readonly int MAX_MATCH
- private static readonly int MEM_LEVEL_DEFAULT
- private static readonly int MEM_LEVEL_MAX
- private static readonly int MIN_LOOKAHEAD
- private static readonly int MIN_MATCH
- internal int nextPending
- internal int opt_len
- internal byte[] pending
- internal int pendingCount
- private static readonly int PRESET_DICT
- internal short[] prev
- internal int prev_length
- internal int prev_match
- private bool Rfc1950BytesEmitted
- internal int static_len
- private static readonly int STATIC_TREES
- internal int status
- private static readonly int STORED_BLOCK
- internal int strstart
- internal Ionic.Zlib.Tree treeBitLengths
- internal Ionic.Zlib.Tree treeDistances
- internal Ionic.Zlib.Tree treeLiterals
- internal byte[] window
- internal int window_size
- internal int w_bits
- internal int w_mask
- internal int w_size
- private static readonly int Z_ASCII
- private static readonly int Z_BINARY
- private static readonly int Z_DEFLATED
- private static readonly int Z_UNKNOWN
- internal Ionic.Zlib.ZlibCodec _codec
- internal int _distanceOffset
- private static readonly string[] _ErrorMessage
- internal int _lengthOffset
- private bool _WantRfc1950HeaderBytes

#### Properties
- internal bool WantRfc1950HeaderBytes { get; set; }

#### Constructors
- internal DeflateManager()
- private static DeflateManager()

#### Methods
- internal void bi_flush()
- internal void bi_windup()
- internal int build_bl_tree()
- internal void copy_block(int buf, int len, bool header)
- internal int Deflate(Ionic.Zlib.FlushType flush)
- internal Ionic.Zlib.BlockState DeflateFast(Ionic.Zlib.FlushType flush)
- internal Ionic.Zlib.BlockState DeflateNone(Ionic.Zlib.FlushType flush)
- internal Ionic.Zlib.BlockState DeflateSlow(Ionic.Zlib.FlushType flush)
- internal int End()
- internal void flush_block_only(bool eof)
- internal int Initialize(Ionic.Zlib.ZlibCodec codec, Ionic.Zlib.CompressionLevel level)
- internal int Initialize(Ionic.Zlib.ZlibCodec codec, Ionic.Zlib.CompressionLevel level, int bits)
- internal int Initialize(Ionic.Zlib.ZlibCodec codec, Ionic.Zlib.CompressionLevel level, int bits, Ionic.Zlib.CompressionStrategy compressionStrategy)
- internal int Initialize(Ionic.Zlib.ZlibCodec codec, Ionic.Zlib.CompressionLevel level, int windowBits, int memLevel, Ionic.Zlib.CompressionStrategy strategy)
- internal int longest_match(int cur_match)
- internal void pqdownheap(short[] tree, int k)
- private void put_bytes(byte[] p, int start, int len)
- internal void Reset()
- internal void scan_tree(short[] tree, int max_code)
- internal void send_all_trees(int lcodes, int dcodes, int blcodes)
- internal void send_bits(int value, int length)
- internal void send_code(int c, short[] tree)
- internal void send_compressed_block(short[] ltree, short[] dtree)
- internal void send_tree(short[] tree, int max_code)
- private void SetDeflater()
- internal int SetDictionary(byte[] dictionary)
- internal int SetParams(Ionic.Zlib.CompressionLevel level, Ionic.Zlib.CompressionStrategy strategy)
- internal void set_data_type()
- private void _fillWindow()
- internal void _InitializeBlocks()
- private void _InitializeLazyMatch()
- private void _InitializeTreeData()
- internal static bool _IsSmaller(short[] tree, int n, int m, sbyte[] depth)
- internal void _tr_align()
- internal void _tr_flush_block(int buf, int stored_len, bool eof)
- internal void _tr_stored_block(int buf, int stored_len, bool eof)
- internal bool _tr_tally(int dist, int lc)

### public class Ionic.Zlib.DeflateStream
- Base: System.IO.Stream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- internal Ionic.Zlib.ZlibBaseStream _baseStream
- private bool _disposed
- internal System.IO.Stream _innerStream

#### Properties
- public int BufferSize { get; set; }
- public bool CanRead { get; }
- public bool CanSeek { get; }
- public bool CanWrite { get; }
- public Ionic.Zlib.FlushType FlushMode { get; set; }
- public long Length { get; }
- public long Position { get; set; }
- public Ionic.Zlib.CompressionStrategy Strategy { get; set; }
- public long TotalIn { get; }
- public long TotalOut { get; }

#### Constructors
- public DeflateStream(System.IO.Stream stream, Ionic.Zlib.CompressionMode mode)
- public DeflateStream(System.IO.Stream stream, Ionic.Zlib.CompressionMode mode, Ionic.Zlib.CompressionLevel level)
- public DeflateStream(System.IO.Stream stream, Ionic.Zlib.CompressionMode mode, bool leaveOpen)
- public DeflateStream(System.IO.Stream stream, Ionic.Zlib.CompressionMode mode, Ionic.Zlib.CompressionLevel level, bool leaveOpen)

#### Methods
- public static byte[] CompressBuffer(byte[] b)
- public static byte[] CompressString(string s)
- protected override void Dispose(bool disposing)
- public override void Flush()
- public override int Read(byte[] buffer, int offset, int count)
- public override long Seek(long offset, System.IO.SeekOrigin origin)
- public override void SetLength(long value)
- public static byte[] UncompressBuffer(byte[] compressed)
- public static string UncompressString(byte[] compressed)
- public override void Write(byte[] buffer, int offset, int count)

### public enum Ionic.Zlib.FlushType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Finish = 4
- Full = 3
- None = 0
- Partial = 1
- Sync = 2

### public class Ionic.Zlib.GZipStream
- Base: System.IO.Stream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- internal static readonly System.Text.Encoding iso8859dash1
- public System.Nullable<System.DateTime> LastModified
- internal Ionic.Zlib.ZlibBaseStream _baseStream
- private string _Comment
- private int _Crc32
- private bool _disposed
- private string _FileName
- private bool _firstReadDone
- private int _headerByteCount
- internal static readonly System.DateTime _unixEpoch

#### Properties
- public int BufferSize { get; set; }
- public bool CanRead { get; }
- public bool CanSeek { get; }
- public bool CanWrite { get; }
- public string Comment { get; set; }
- public int Crc32 { get; }
- public string FileName { get; set; }
- public Ionic.Zlib.FlushType FlushMode { get; set; }
- public long Length { get; }
- public long Position { get; set; }
- public long TotalIn { get; }
- public long TotalOut { get; }

#### Constructors
- private static GZipStream()
- public GZipStream(System.IO.Stream stream, Ionic.Zlib.CompressionMode mode)
- public GZipStream(System.IO.Stream stream, Ionic.Zlib.CompressionMode mode, Ionic.Zlib.CompressionLevel level)
- public GZipStream(System.IO.Stream stream, Ionic.Zlib.CompressionMode mode, bool leaveOpen)
- public GZipStream(System.IO.Stream stream, Ionic.Zlib.CompressionMode mode, Ionic.Zlib.CompressionLevel level, bool leaveOpen)

#### Methods
- public static byte[] CompressBuffer(byte[] b)
- public static byte[] CompressString(string s)
- protected override void Dispose(bool disposing)
- private int EmitHeader()
- public override void Flush()
- public override int Read(byte[] buffer, int offset, int count)
- public override long Seek(long offset, System.IO.SeekOrigin origin)
- public override void SetLength(long value)
- public static byte[] UncompressBuffer(byte[] compressed)
- public static string UncompressString(byte[] compressed)
- public override void Write(byte[] buffer, int offset, int count)

### private enum Ionic.Zlib.InflateBlocks.InflateBlockMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BAD = 9
- BTREE = 4
- CODES = 6
- DONE = 8
- DRY = 7
- DTREE = 5
- LENS = 1
- STORED = 2
- TABLE = 3
- TYPE = 0

### internal class Ionic.Zlib.InflateBlocks

#### Fields
- internal int[] bb
- internal int bitb
- internal int bitk
- internal int[] blens
- internal static readonly int[] border
- internal uint check
- internal object checkfn
- internal Ionic.Zlib.InflateCodes codes
- internal int end
- internal int[] hufts
- internal int index
- internal Ionic.Zlib.InfTree inftree
- internal int last
- internal int left
- private static const int MANY
- private Ionic.Zlib.InflateBlocks.InflateBlockMode mode
- internal int readAt
- internal int table
- internal int[] tb
- internal byte[] window
- internal int writeAt
- internal Ionic.Zlib.ZlibCodec _codec

#### Constructors
- private static InflateBlocks()
- internal InflateBlocks(Ionic.Zlib.ZlibCodec codec, object checkfn, int w)

#### Methods
- internal int Flush(int r)
- internal void Free()
- internal int Process(int r)
- internal uint Reset()
- internal void SetDictionary(byte[] d, int start, int n)
- internal int SyncPoint()

### internal class Ionic.Zlib.InflateCodes

#### Fields
- private static const int BADCODE
- internal int bitsToGet
- private static const int COPY
- internal byte dbits
- internal int dist
- private static const int DIST
- private static const int DISTEXT
- internal int[] dtree
- internal int dtree_index
- private static const int END
- internal byte lbits
- internal int len
- private static const int LEN
- private static const int LENEXT
- internal int lit
- private static const int LIT
- internal int[] ltree
- internal int ltree_index
- internal int mode
- internal int need
- private static const int START
- internal int[] tree
- internal int tree_index
- private static const int WASH

#### Constructors
- internal InflateCodes()

#### Methods
- internal int InflateFast(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index, Ionic.Zlib.InflateBlocks s, Ionic.Zlib.ZlibCodec z)
- internal void Init(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index)
- internal int Process(Ionic.Zlib.InflateBlocks blocks, int r)

### internal class Ionic.Zlib.InflateManager

#### Fields
- internal Ionic.Zlib.InflateBlocks blocks
- internal uint computedCheck
- internal uint expectedCheck
- private static readonly byte[] mark
- internal int marker
- internal int method
- private Ionic.Zlib.InflateManager.InflateManagerMode mode
- private static const int PRESET_DICT
- internal int wbits
- private static const int Z_DEFLATED
- internal Ionic.Zlib.ZlibCodec _codec
- private bool _handleRfc1950HeaderBytes

#### Properties
- internal bool HandleRfc1950HeaderBytes { get; set; }

#### Constructors
- public InflateManager()
- private static InflateManager()
- public InflateManager(bool expectRfc1950HeaderBytes)

#### Methods
- internal int End()
- internal int Inflate(Ionic.Zlib.FlushType flush)
- internal int Initialize(Ionic.Zlib.ZlibCodec codec, int w)
- internal int Reset()
- internal int SetDictionary(byte[] dictionary)
- internal int Sync()
- internal int SyncPoint(Ionic.Zlib.ZlibCodec z)

### private enum Ionic.Zlib.InflateManager.InflateManagerMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BAD = 13
- BLOCKS = 7
- CHECK1 = 11
- CHECK2 = 10
- CHECK3 = 9
- CHECK4 = 8
- DICT0 = 6
- DICT1 = 5
- DICT2 = 4
- DICT3 = 3
- DICT4 = 2
- DONE = 12
- FLAG = 1
- METHOD = 0

### internal class Ionic.Zlib.InfTree

#### Fields
- internal static const int BMAX
- internal int[] c
- internal static readonly int[] cpdext
- internal static readonly int[] cpdist
- internal static readonly int[] cplens
- internal static readonly int[] cplext
- internal static const int fixed_bd
- internal static const int fixed_bl
- internal static readonly int[] fixed_td
- internal static readonly int[] fixed_tl
- internal int[] hn
- private static const int MANY
- internal int[] r
- internal int[] u
- internal int[] v
- internal int[] x
- private static const int Z_BUF_ERROR
- private static const int Z_DATA_ERROR
- private static const int Z_ERRNO
- private static const int Z_MEM_ERROR
- private static const int Z_NEED_DICT
- private static const int Z_OK
- private static const int Z_STREAM_END
- private static const int Z_STREAM_ERROR
- private static const int Z_VERSION_ERROR

#### Constructors
- public InfTree()
- private static InfTree()

#### Methods
- private int huft_build(int[] b, int bindex, int n, int s, int[] d, int[] e, int[] t, int[] m, int[] hp, int[] hn, int[] v)
- internal int inflate_trees_bits(int[] c, int[] bb, int[] tb, int[] hp, Ionic.Zlib.ZlibCodec z)
- internal int inflate_trees_dynamic(int nl, int nd, int[] c, int[] bl, int[] bd, int[] tl, int[] td, int[] hp, Ionic.Zlib.ZlibCodec z)
- internal static int inflate_trees_fixed(int[] bl, int[] bd, int[][] tl, int[][] td, Ionic.Zlib.ZlibCodec z)
- private void initWorkArea(int vsize)

### internal static class Ionic.Zlib.InternalConstants

#### Fields
- internal static readonly int BL_CODES
- internal static readonly int D_CODES
- internal static readonly int LENGTH_CODES
- internal static readonly int LITERALS
- internal static readonly int L_CODES
- internal static readonly int MAX_BITS
- internal static readonly int MAX_BL_BITS
- internal static readonly int REPZ_11_138
- internal static readonly int REPZ_3_10
- internal static readonly int REP_3_6

#### Constructors
- private static InternalConstants()

### internal static class Ionic.Zlib.InternalInflateConstants

#### Fields
- internal static readonly int[] InflateMask

#### Constructors
- private static InternalInflateConstants()

### internal class Ionic.Zlib.SharedUtils

#### Constructors
- public SharedUtils()

#### Methods
- public static int ReadInput(System.IO.TextReader sourceTextReader, byte[] target, int start, int count)
- internal static byte[] ToByteArray(string sourceString)
- internal static char[] ToCharArray(byte[] byteArray)
- public static int URShift(int number, int bits)

### internal class Ionic.Zlib.StaticTree

#### Fields
- internal static readonly Ionic.Zlib.StaticTree BitLengths
- internal static readonly Ionic.Zlib.StaticTree Distances
- internal static readonly short[] distTreeCodes
- internal int elems
- internal int extraBase
- internal int[] extraBits
- internal static readonly short[] lengthAndLiteralsTreeCodes
- internal static readonly Ionic.Zlib.StaticTree Literals
- internal int maxLength
- internal short[] treeCodes

#### Constructors
- private static StaticTree()
- private StaticTree(short[] treeCodes, int[] extraBits, int extraBase, int elems, int maxLength)

### internal enum Ionic.Zlib.ZlibBaseStream.StreamMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Reader = 1
- Undefined = 2
- Writer = 0

### internal class Ionic.Zlib.Tree

#### Fields
- internal static readonly sbyte[] bl_order
- internal static const int Buf_size
- internal static readonly int[] DistanceBase
- internal short[] dyn_tree
- internal static readonly int[] ExtraDistanceBits
- internal static readonly int[] ExtraLengthBits
- internal static readonly int[] extra_blbits
- private static readonly int HEAP_SIZE
- internal static readonly int[] LengthBase
- internal static readonly sbyte[] LengthCode
- internal int max_code
- internal Ionic.Zlib.StaticTree staticTree
- private static readonly sbyte[] _dist_code

#### Constructors
- public Tree()
- private static Tree()

#### Methods
- internal static int bi_reverse(int code, int len)
- internal void build_tree(Ionic.Zlib.DeflateManager s)
- internal static int DistanceCode(int dist)
- internal void gen_bitlen(Ionic.Zlib.DeflateManager s)
- internal static void gen_codes(short[] tree, int max_code, short[] bl_count)

### internal class Ionic.Zlib.ZlibBaseStream
- Base: System.IO.Stream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- private Ionic.Crc.CRC32 crc
- private bool nomoreinput
- protected internal Ionic.Zlib.CompressionStrategy Strategy
- protected internal byte[] _buf1
- protected internal int _bufferSize
- protected internal Ionic.Zlib.CompressionMode _compressionMode
- protected internal Ionic.Zlib.ZlibStreamFlavor _flavor
- protected internal Ionic.Zlib.FlushType _flushMode
- protected internal string _GzipComment
- protected internal string _GzipFileName
- protected internal int _gzipHeaderByteCount
- protected internal System.DateTime _GzipMtime
- protected internal bool _leaveOpen
- protected internal Ionic.Zlib.CompressionLevel _level
- protected internal System.IO.Stream _stream
- protected internal Ionic.Zlib.ZlibBaseStream.StreamMode _streamMode
- protected internal byte[] _workingBuffer
- protected internal Ionic.Zlib.ZlibCodec _z

#### Properties
- public bool CanRead { get; }
- public bool CanSeek { get; }
- public bool CanWrite { get; }
- internal int Crc32 { get; }
- public long Length { get; }
- public long Position { get; set; }
- private byte[] workingBuffer { get; }
- private Ionic.Zlib.ZlibCodec z { get; }
- protected internal bool _wantCompress { get; }

#### Constructors
- public ZlibBaseStream(System.IO.Stream stream, Ionic.Zlib.CompressionMode compressionMode, Ionic.Zlib.CompressionLevel level, Ionic.Zlib.ZlibStreamFlavor flavor, bool leaveOpen)

#### Methods
- public override void Close()
- public static void CompressBuffer(byte[] b, System.IO.Stream compressor)
- public static void CompressString(string s, System.IO.Stream compressor)
- private void end()
- private void finish()
- public override void Flush()
- public override int Read(byte[] buffer, int offset, int count)
- private string ReadZeroTerminatedString()
- public override long Seek(long offset, System.IO.SeekOrigin origin)
- public override void SetLength(long value)
- public static byte[] UncompressBuffer(byte[] compressed, System.IO.Stream decompressor)
- public static string UncompressString(byte[] compressed, System.IO.Stream decompressor)
- public override void Write(byte[] buffer, int offset, int count)
- private int _ReadAndValidateGzipHeader()

### public class Ionic.Zlib.ZlibCodec

#### Fields
- public int AvailableBytesIn
- public int AvailableBytesOut
- public Ionic.Zlib.CompressionLevel CompressLevel
- internal Ionic.Zlib.DeflateManager dstate
- public byte[] InputBuffer
- internal Ionic.Zlib.InflateManager istate
- public string Message
- public int NextIn
- public int NextOut
- public byte[] OutputBuffer
- public Ionic.Zlib.CompressionStrategy Strategy
- public long TotalBytesIn
- public long TotalBytesOut
- public int WindowBits
- internal uint _Adler32

#### Properties
- public int Adler32 { get; }

#### Constructors
- public ZlibCodec()
- public ZlibCodec(Ionic.Zlib.CompressionMode mode)

#### Methods
- public int Deflate(Ionic.Zlib.FlushType flush)
- public int EndDeflate()
- public int EndInflate()
- internal void flush_pending()
- public int Inflate(Ionic.Zlib.FlushType flush)
- public int InitializeDeflate()
- public int InitializeDeflate(Ionic.Zlib.CompressionLevel level)
- public int InitializeDeflate(Ionic.Zlib.CompressionLevel level, bool wantRfc1950Header)
- public int InitializeDeflate(Ionic.Zlib.CompressionLevel level, int bits)
- public int InitializeDeflate(Ionic.Zlib.CompressionLevel level, int bits, bool wantRfc1950Header)
- public int InitializeInflate()
- public int InitializeInflate(bool expectRfc1950Header)
- public int InitializeInflate(int windowBits)
- public int InitializeInflate(int windowBits, bool expectRfc1950Header)
- internal int read_buf(byte[] buf, int start, int size)
- public void ResetDeflate()
- public int SetDeflateParams(Ionic.Zlib.CompressionLevel level, Ionic.Zlib.CompressionStrategy strategy)
- public int SetDictionary(byte[] dictionary)
- public int SyncInflate()
- private int _InternalInitializeDeflate(bool wantRfc1950Header)

### public static class Ionic.Zlib.ZlibConstants

#### Fields
- public static const int WindowBitsDefault
- public static const int WindowBitsMax
- public static const int WorkingBufferSizeDefault
- public static const int WorkingBufferSizeMin
- public static const int Z_BUF_ERROR
- public static const int Z_DATA_ERROR
- public static const int Z_NEED_DICT
- public static const int Z_OK
- public static const int Z_STREAM_END
- public static const int Z_STREAM_ERROR

### public class Ionic.Zlib.ZlibException
- Base: System.Exception
- Interfaces: System.Runtime.Serialization.ISerializable

#### Constructors
- public ZlibException()
- public ZlibException(string s)

### public class Ionic.Zlib.ZlibStream
- Base: System.IO.Stream
- Interfaces: System.IDisposable, System.IAsyncDisposable

#### Fields
- internal Ionic.Zlib.ZlibBaseStream _baseStream
- private bool _disposed

#### Properties
- public int BufferSize { get; set; }
- public bool CanRead { get; }
- public bool CanSeek { get; }
- public bool CanWrite { get; }
- public Ionic.Zlib.FlushType FlushMode { get; set; }
- public long Length { get; }
- public long Position { get; set; }
- public long TotalIn { get; }
- public long TotalOut { get; }

#### Constructors
- public ZlibStream(System.IO.Stream stream, Ionic.Zlib.CompressionMode mode)
- public ZlibStream(System.IO.Stream stream, Ionic.Zlib.CompressionMode mode, Ionic.Zlib.CompressionLevel level)
- public ZlibStream(System.IO.Stream stream, Ionic.Zlib.CompressionMode mode, bool leaveOpen)
- public ZlibStream(System.IO.Stream stream, Ionic.Zlib.CompressionMode mode, Ionic.Zlib.CompressionLevel level, bool leaveOpen)

#### Methods
- public static byte[] CompressBuffer(byte[] b)
- public static byte[] CompressString(string s)
- protected override void Dispose(bool disposing)
- public override void Flush()
- public override int Read(byte[] buffer, int offset, int count)
- public override long Seek(long offset, System.IO.SeekOrigin origin)
- public override void SetLength(long value)
- public static byte[] UncompressBuffer(byte[] compressed)
- public static string UncompressString(byte[] compressed)
- public override void Write(byte[] buffer, int offset, int count)

### internal enum Ionic.Zlib.ZlibStreamFlavor
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DEFLATE = 1951
- GZIP = 1952
- ZLIB = 1950

