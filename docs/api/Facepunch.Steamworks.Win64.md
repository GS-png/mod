# Assembly: Facepunch.Steamworks.Win64
- Path: tools/WorldBox.Managed/Facepunch.Steamworks.Win64.dll
- Types: 661

## Namespace: (global)

### internal class <PrivateImplementationDetails>

#### Fields
- internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5 B1A9AA820F353E1BEF1F7D40CD3F58447AA91D123BC2539918BC70F8A66E75B9

#### Methods
- internal static uint ComputeStringHash(string s)

### private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5

## Namespace: Microsoft.CodeAnalysis

### internal class Microsoft.CodeAnalysis.EmbeddedAttribute
- Base: System.Attribute

#### Constructors
- public EmbeddedAttribute()

## Namespace: Steamworks

### private class Steamworks.Dispatch.<>c

#### Fields
- public static readonly Steamworks.Dispatch.<>c <>9
- public static System.Func<System.Reflection.FieldInfo, int> <>9__20_0
- public static System.Func<System.Collections.Generic.KeyValuePair<ulong, Steamworks.Dispatch.ResultCallback>, bool> <>9__30_0
- public static System.Func<System.Collections.Generic.KeyValuePair<ulong, Steamworks.Dispatch.ResultCallback>, ulong> <>9__30_1
- public static System.Func<System.Collections.Generic.KeyValuePair<ulong, Steamworks.Dispatch.ResultCallback>, Steamworks.Dispatch.ResultCallback> <>9__30_2
- public static System.Predicate<Steamworks.Dispatch.Callback> <>9__30_3
- public static System.Func<System.Collections.Generic.KeyValuePair<ulong, Steamworks.Dispatch.ResultCallback>, bool> <>9__31_0
- public static System.Func<System.Collections.Generic.KeyValuePair<ulong, Steamworks.Dispatch.ResultCallback>, ulong> <>9__31_1
- public static System.Func<System.Collections.Generic.KeyValuePair<ulong, Steamworks.Dispatch.ResultCallback>, Steamworks.Dispatch.ResultCallback> <>9__31_2
- public static System.Predicate<Steamworks.Dispatch.Callback> <>9__31_3

#### Constructors
- private static Dispatch.<>c()
- public Dispatch.<>c()

#### Methods
- internal int <CallbackToString>b__20_0(System.Reflection.FieldInfo x)
- internal bool <ShutdownClient>b__31_0(System.Collections.Generic.KeyValuePair<ulong, Steamworks.Dispatch.ResultCallback> x)
- internal ulong <ShutdownClient>b__31_1(System.Collections.Generic.KeyValuePair<ulong, Steamworks.Dispatch.ResultCallback> x)
- internal Steamworks.Dispatch.ResultCallback <ShutdownClient>b__31_2(System.Collections.Generic.KeyValuePair<ulong, Steamworks.Dispatch.ResultCallback> x)
- internal bool <ShutdownClient>b__31_3(Steamworks.Dispatch.Callback x)
- internal bool <ShutdownServer>b__30_0(System.Collections.Generic.KeyValuePair<ulong, Steamworks.Dispatch.ResultCallback> x)
- internal ulong <ShutdownServer>b__30_1(System.Collections.Generic.KeyValuePair<ulong, Steamworks.Dispatch.ResultCallback> x)
- internal Steamworks.Dispatch.ResultCallback <ShutdownServer>b__30_2(System.Collections.Generic.KeyValuePair<ulong, Steamworks.Dispatch.ResultCallback> x)
- internal bool <ShutdownServer>b__30_3(Steamworks.Dispatch.Callback x)

### private class Steamworks.SteamApps.<>c

#### Fields
- public static readonly Steamworks.SteamApps.<>c <>9
- public static System.Action<Steamworks.Data.DlcInstalled_t> <>9__3_0
- public static System.Action<Steamworks.Data.NewUrlLaunchParameters_t> <>9__3_1
- public static System.Func<byte, string> <>9__44_0

#### Constructors
- private static SteamApps.<>c()
- public SteamApps.<>c()

#### Methods
- internal string <GetFileDetailsAsync>b__44_0(byte x)
- internal void <InstallEvents>b__3_0(Steamworks.Data.DlcInstalled_t x)
- internal void <InstallEvents>b__3_1(Steamworks.Data.NewUrlLaunchParameters_t x)

### private class Steamworks.SteamFriends.<>c

#### Fields
- public static readonly Steamworks.SteamFriends.<>c <>9
- public static System.Action<Steamworks.Data.PersonaStateChange_t> <>9__4_0
- public static System.Action<Steamworks.Data.GameRichPresenceJoinRequested_t> <>9__4_1
- public static System.Action<Steamworks.Data.GameOverlayActivated_t> <>9__4_2
- public static System.Action<Steamworks.Data.GameServerChangeRequested_t> <>9__4_3
- public static System.Action<Steamworks.Data.GameLobbyJoinRequested_t> <>9__4_4
- public static System.Action<Steamworks.Data.FriendRichPresenceUpdate_t> <>9__4_5

#### Constructors
- private static SteamFriends.<>c()
- public SteamFriends.<>c()

#### Methods
- internal void <InstallEvents>b__4_0(Steamworks.Data.PersonaStateChange_t x)
- internal void <InstallEvents>b__4_1(Steamworks.Data.GameRichPresenceJoinRequested_t x)
- internal void <InstallEvents>b__4_2(Steamworks.Data.GameOverlayActivated_t x)
- internal void <InstallEvents>b__4_3(Steamworks.Data.GameServerChangeRequested_t x)
- internal void <InstallEvents>b__4_4(Steamworks.Data.GameLobbyJoinRequested_t x)
- internal void <InstallEvents>b__4_5(Steamworks.Data.FriendRichPresenceUpdate_t x)

### private class Steamworks.SteamInventory.<>c

#### Fields
- public static readonly Steamworks.SteamInventory.<>c <>9
- public static System.Func<Steamworks.Data.InventoryDefId, Steamworks.InventoryDef> <>9__19_0
- public static System.Func<Steamworks.Data.InventoryDefId, Steamworks.InventoryDef> <>9__29_0
- public static System.Func<Steamworks.InventoryItem, Steamworks.Data.InventoryItemId> <>9__33_0
- public static System.Func<Steamworks.InventoryItem, uint> <>9__33_1
- public static System.Func<Steamworks.InventoryItem.Amount, Steamworks.Data.InventoryItemId> <>9__34_0
- public static System.Func<Steamworks.InventoryItem.Amount, uint> <>9__34_1
- public static System.Func<Steamworks.InventoryDef, Steamworks.Data.InventoryDefId> <>9__39_0
- public static System.Func<Steamworks.InventoryDef, uint> <>9__39_1
- public static System.Action<Steamworks.Data.SteamInventoryFullUpdate_t> <>9__3_0
- public static System.Action<Steamworks.Data.SteamInventoryDefinitionUpdate_t> <>9__3_1

#### Constructors
- private static SteamInventory.<>c()
- public SteamInventory.<>c()

#### Methods
- internal Steamworks.Data.InventoryItemId <CraftItemAsync>b__33_0(Steamworks.InventoryItem x)
- internal uint <CraftItemAsync>b__33_1(Steamworks.InventoryItem x)
- internal Steamworks.Data.InventoryItemId <CraftItemAsync>b__34_0(Steamworks.InventoryItem.Amount x)
- internal uint <CraftItemAsync>b__34_1(Steamworks.InventoryItem.Amount x)
- internal Steamworks.InventoryDef <GetDefinitions>b__29_0(Steamworks.Data.InventoryDefId x)
- internal Steamworks.InventoryDef <GetDefinitionsWithPricesAsync>b__19_0(Steamworks.Data.InventoryDefId x)
- internal void <InstallEvents>b__3_0(Steamworks.Data.SteamInventoryFullUpdate_t x)
- internal void <InstallEvents>b__3_1(Steamworks.Data.SteamInventoryDefinitionUpdate_t x)
- internal Steamworks.Data.InventoryDefId <StartPurchaseAsync>b__39_0(Steamworks.InventoryDef x)
- internal uint <StartPurchaseAsync>b__39_1(Steamworks.InventoryDef x)

### private class Steamworks.SteamMatchmaking.<>c

#### Fields
- public static readonly Steamworks.SteamMatchmaking.<>c <>9
- public static System.Action<Steamworks.Data.LobbyInvite_t> <>9__5_0
- public static System.Action<Steamworks.Data.LobbyEnter_t> <>9__5_1
- public static System.Action<Steamworks.Data.LobbyCreated_t> <>9__5_2
- public static System.Action<Steamworks.Data.LobbyGameCreated_t> <>9__5_3
- public static System.Action<Steamworks.Data.LobbyDataUpdate_t> <>9__5_4
- public static System.Action<Steamworks.Data.LobbyChatUpdate_t> <>9__5_5

#### Constructors
- private static SteamMatchmaking.<>c()
- public SteamMatchmaking.<>c()

#### Methods
- internal void <InstallEvents>b__5_0(Steamworks.Data.LobbyInvite_t x)
- internal void <InstallEvents>b__5_1(Steamworks.Data.LobbyEnter_t x)
- internal void <InstallEvents>b__5_2(Steamworks.Data.LobbyCreated_t x)
- internal void <InstallEvents>b__5_3(Steamworks.Data.LobbyGameCreated_t x)
- internal void <InstallEvents>b__5_4(Steamworks.Data.LobbyDataUpdate_t x)
- internal void <InstallEvents>b__5_5(Steamworks.Data.LobbyChatUpdate_t x)

### private class Steamworks.SteamMusic.<>c

#### Fields
- public static readonly Steamworks.SteamMusic.<>c <>9
- public static System.Action<Steamworks.Data.PlaybackStatusHasChanged_t> <>9__3_0
- public static System.Action<Steamworks.Data.VolumeHasChanged_t> <>9__3_1

#### Constructors
- private static SteamMusic.<>c()
- public SteamMusic.<>c()

#### Methods
- internal void <InstallEvents>b__3_0(Steamworks.Data.PlaybackStatusHasChanged_t x)
- internal void <InstallEvents>b__3_1(Steamworks.Data.VolumeHasChanged_t x)

### private class Steamworks.SteamNetworking.<>c

#### Fields
- public static readonly Steamworks.SteamNetworking.<>c <>9
- public static System.Action<Steamworks.Data.P2PSessionRequest_t> <>9__3_0
- public static System.Action<Steamworks.Data.P2PSessionConnectFail_t> <>9__3_1

#### Constructors
- private static SteamNetworking.<>c()
- public SteamNetworking.<>c()

#### Methods
- internal void <InstallEvents>b__3_0(Steamworks.Data.P2PSessionRequest_t x)
- internal void <InstallEvents>b__3_1(Steamworks.Data.P2PSessionConnectFail_t x)

### private class Steamworks.SteamNetworkingUtils.<>c

#### Fields
- public static readonly Steamworks.SteamNetworkingUtils.<>c <>9
- public static System.Action<Steamworks.Data.SteamRelayNetworkStatus_t> <>9__3_0

#### Constructors
- private static SteamNetworkingUtils.<>c()
- public SteamNetworkingUtils.<>c()

#### Methods
- internal void <InstallCallbacks>b__3_0(Steamworks.Data.SteamRelayNetworkStatus_t x)

### private class Steamworks.SteamParental.<>c

#### Fields
- public static readonly Steamworks.SteamParental.<>c <>9
- public static System.Action<Steamworks.Data.SteamParentalSettingsChanged_t> <>9__3_0

#### Constructors
- private static SteamParental.<>c()
- public SteamParental.<>c()

#### Methods
- internal void <InstallEvents>b__3_0(Steamworks.Data.SteamParentalSettingsChanged_t x)

### private class Steamworks.SteamParties.<>c

#### Fields
- public static readonly Steamworks.SteamParties.<>c <>9
- public static System.Action<Steamworks.Data.AvailableBeaconLocationsUpdated_t> <>9__3_0
- public static System.Action<Steamworks.Data.ActiveBeaconsUpdated_t> <>9__3_1

#### Constructors
- private static SteamParties.<>c()
- public SteamParties.<>c()

#### Methods
- internal void <InstallEvents>b__3_0(Steamworks.Data.AvailableBeaconLocationsUpdated_t x)
- internal void <InstallEvents>b__3_1(Steamworks.Data.ActiveBeaconsUpdated_t x)

### private class Steamworks.SteamRemotePlay.<>c

#### Fields
- public static readonly Steamworks.SteamRemotePlay.<>c <>9
- public static System.Action<Steamworks.Data.SteamRemotePlaySessionConnected_t> <>9__3_0
- public static System.Action<Steamworks.Data.SteamRemotePlaySessionDisconnected_t> <>9__3_1

#### Constructors
- private static SteamRemotePlay.<>c()
- public SteamRemotePlay.<>c()

#### Methods
- internal void <InstallEvents>b__3_0(Steamworks.Data.SteamRemotePlaySessionConnected_t x)
- internal void <InstallEvents>b__3_1(Steamworks.Data.SteamRemotePlaySessionDisconnected_t x)

### private class Steamworks.SteamScreenshots.<>c

#### Fields
- public static readonly Steamworks.SteamScreenshots.<>c <>9
- public static System.Action<Steamworks.Data.ScreenshotRequested_t> <>9__3_0
- public static System.Action<Steamworks.Data.ScreenshotReady_t> <>9__3_1

#### Constructors
- private static SteamScreenshots.<>c()
- public SteamScreenshots.<>c()

#### Methods
- internal void <InstallEvents>b__3_0(Steamworks.Data.ScreenshotRequested_t x)
- internal void <InstallEvents>b__3_1(Steamworks.Data.ScreenshotReady_t x)

### private class Steamworks.SteamServer.<>c

#### Fields
- public static readonly Steamworks.SteamServer.<>c <>9
- public static System.Action<Steamworks.Data.ValidateAuthTicketResponse_t> <>9__5_0
- public static System.Action<Steamworks.Data.SteamServersConnected_t> <>9__5_1
- public static System.Action<Steamworks.Data.SteamServerConnectFailure_t> <>9__5_2
- public static System.Action<Steamworks.Data.SteamServersDisconnected_t> <>9__5_3

#### Constructors
- private static SteamServer.<>c()
- public SteamServer.<>c()

#### Methods
- internal void <InstallEvents>b__5_0(Steamworks.Data.ValidateAuthTicketResponse_t x)
- internal void <InstallEvents>b__5_1(Steamworks.Data.SteamServersConnected_t x)
- internal void <InstallEvents>b__5_2(Steamworks.Data.SteamServerConnectFailure_t x)
- internal void <InstallEvents>b__5_3(Steamworks.Data.SteamServersDisconnected_t x)

### private class Steamworks.SteamUGC.<>c

#### Fields
- public static readonly Steamworks.SteamUGC.<>c <>9
- public static System.Action<Steamworks.Data.DownloadItemResult_t> <>9__3_0

#### Constructors
- private static SteamUGC.<>c()
- public SteamUGC.<>c()

#### Methods
- internal void <InstallEvents>b__3_0(Steamworks.Data.DownloadItemResult_t x)

### private class Steamworks.SteamUser.<>c

#### Fields
- public static readonly Steamworks.SteamUser.<>c <>9
- public static System.Action<Steamworks.Data.SteamServersConnected_t> <>9__4_0
- public static System.Action<Steamworks.Data.SteamServerConnectFailure_t> <>9__4_1
- public static System.Action<Steamworks.Data.SteamServersDisconnected_t> <>9__4_2
- public static System.Action<Steamworks.Data.ClientGameServerDeny_t> <>9__4_3
- public static System.Action<Steamworks.Data.LicensesUpdated_t> <>9__4_4
- public static System.Action<Steamworks.Data.ValidateAuthTicketResponse_t> <>9__4_5
- public static System.Action<Steamworks.Data.MicroTxnAuthorizationResponse_t> <>9__4_6
- public static System.Action<Steamworks.Data.GameWebCallback_t> <>9__4_7
- public static System.Action<Steamworks.Data.GetAuthSessionTicketResponse_t> <>9__4_8
- public static System.Action<Steamworks.Data.DurationControl_t> <>9__4_9

#### Constructors
- private static SteamUser.<>c()
- public SteamUser.<>c()

#### Methods
- internal void <InstallEvents>b__4_0(Steamworks.Data.SteamServersConnected_t x)
- internal void <InstallEvents>b__4_1(Steamworks.Data.SteamServerConnectFailure_t x)
- internal void <InstallEvents>b__4_2(Steamworks.Data.SteamServersDisconnected_t x)
- internal void <InstallEvents>b__4_3(Steamworks.Data.ClientGameServerDeny_t x)
- internal void <InstallEvents>b__4_4(Steamworks.Data.LicensesUpdated_t x)
- internal void <InstallEvents>b__4_5(Steamworks.Data.ValidateAuthTicketResponse_t x)
- internal void <InstallEvents>b__4_6(Steamworks.Data.MicroTxnAuthorizationResponse_t x)
- internal void <InstallEvents>b__4_7(Steamworks.Data.GameWebCallback_t x)
- internal void <InstallEvents>b__4_8(Steamworks.Data.GetAuthSessionTicketResponse_t x)
- internal void <InstallEvents>b__4_9(Steamworks.Data.DurationControl_t x)

### private class Steamworks.SteamUserStats.<>c

#### Fields
- public static readonly Steamworks.SteamUserStats.<>c <>9
- public static System.Action<Steamworks.Data.UserStatsReceived_t> <>9__7_0
- public static System.Action<Steamworks.Data.UserStatsStored_t> <>9__7_1
- public static System.Action<Steamworks.Data.UserAchievementStored_t> <>9__7_2
- public static System.Action<Steamworks.Data.UserStatsUnloaded_t> <>9__7_3
- public static System.Action<Steamworks.Data.UserAchievementIconFetched_t> <>9__7_4

#### Constructors
- private static SteamUserStats.<>c()
- public SteamUserStats.<>c()

#### Methods
- internal void <InstallEvents>b__7_0(Steamworks.Data.UserStatsReceived_t x)
- internal void <InstallEvents>b__7_1(Steamworks.Data.UserStatsStored_t x)
- internal void <InstallEvents>b__7_2(Steamworks.Data.UserAchievementStored_t x)
- internal void <InstallEvents>b__7_3(Steamworks.Data.UserStatsUnloaded_t x)
- internal void <InstallEvents>b__7_4(Steamworks.Data.UserAchievementIconFetched_t x)

### private class Steamworks.SteamUtils.<>c

#### Fields
- public static readonly Steamworks.SteamUtils.<>c <>9
- public static System.Action<Steamworks.Data.IPCountry_t> <>9__3_0
- public static System.Action<Steamworks.Data.LowBatteryPower_t> <>9__3_1
- public static System.Action<Steamworks.Data.SteamShutdown_t> <>9__3_2
- public static System.Action<Steamworks.Data.GamepadTextInputDismissed_t> <>9__3_3

#### Constructors
- private static SteamUtils.<>c()
- public SteamUtils.<>c()

#### Methods
- internal void <InstallEvents>b__3_0(Steamworks.Data.IPCountry_t x)
- internal void <InstallEvents>b__3_1(Steamworks.Data.LowBatteryPower_t x)
- internal void <InstallEvents>b__3_2(Steamworks.Data.SteamShutdown_t x)
- internal void <InstallEvents>b__3_3(Steamworks.Data.GamepadTextInputDismissed_t x)

### private class Steamworks.SteamVideo.<>c

#### Fields
- public static readonly Steamworks.SteamVideo.<>c <>9
- public static System.Action<Steamworks.Data.BroadcastUploadStart_t> <>9__3_0
- public static System.Action<Steamworks.Data.BroadcastUploadStop_t> <>9__3_1

#### Constructors
- private static SteamVideo.<>c()
- public SteamVideo.<>c()

#### Methods
- internal void <InstallEvents>b__3_0(Steamworks.Data.BroadcastUploadStart_t x)
- internal void <InstallEvents>b__3_1(Steamworks.Data.BroadcastUploadStop_t x)

### private class Steamworks.InventoryDef.<>c

#### Fields
- public static readonly Steamworks.InventoryDef.<>c <>9
- public static System.Func<Steamworks.InventoryDef, Steamworks.InventoryRecipe[]> <>9__44_0
- public static System.Func<Steamworks.InventoryRecipe[], bool> <>9__44_1
- public static System.Func<Steamworks.InventoryRecipe[], System.Collections.Generic.IEnumerable<Steamworks.InventoryRecipe>> <>9__44_2

#### Constructors
- private static InventoryDef.<>c()
- public InventoryDef.<>c()

#### Methods
- internal Steamworks.InventoryRecipe[] <GetRecipesContainingThis>b__44_0(Steamworks.InventoryDef x)
- internal bool <GetRecipesContainingThis>b__44_1(Steamworks.InventoryRecipe[] x)
- internal System.Collections.Generic.IEnumerable<Steamworks.InventoryRecipe> <GetRecipesContainingThis>b__44_2(Steamworks.InventoryRecipe[] x)

### private class Steamworks.InventoryRecipe.<>c

#### Fields
- public static readonly Steamworks.InventoryRecipe.<>c <>9
- public static System.Func<string, Steamworks.InventoryRecipe.Ingredient> <>9__4_0
- public static System.Func<Steamworks.InventoryRecipe.Ingredient, bool> <>9__4_1

#### Constructors
- private static InventoryRecipe.<>c()
- public InventoryRecipe.<>c()

#### Methods
- internal Steamworks.InventoryRecipe.Ingredient <FromString>b__4_0(string x)
- internal bool <FromString>b__4_1(Steamworks.InventoryRecipe.Ingredient x)

### private class Steamworks.SourceServerQuery.<>c

#### Fields
- public static readonly Steamworks.SourceServerQuery.<>c <>9
- public static System.Func<byte[], bool> <>9__6_0
- public static System.Func<byte[], int> <>9__9_0

#### Constructors
- private static SourceServerQuery.<>c()
- public SourceServerQuery.<>c()

#### Methods
- internal int <Combine>b__9_0(byte[] a)
- internal bool <Receive>b__6_0(byte[] p)

### private class Steamworks.Dispatch.<>c__DisplayClass29_0<T>

#### Fields
- public System.Action<T> p

#### Constructors
- public Dispatch.<>c__DisplayClass29_0<T>()

#### Methods
- internal void <Install>b__0(System.IntPtr x)

### private class Steamworks.SourceServerQuery.<>c__DisplayClass3_0

#### Fields
- public System.Net.IPEndPoint endpoint

#### Constructors
- public SourceServerQuery.<>c__DisplayClass3_0()

#### Methods
- internal System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string>> <GetRules>b__0(System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string>> t)

### private class Steamworks.SteamUser.<>c__DisplayClass53_0

#### Fields
- public Steamworks.Result result
- public Steamworks.AuthTicket ticket

#### Constructors
- public SteamUser.<>c__DisplayClass53_0()

#### Methods
- internal void <GetAuthSessionTicketAsync>g__f|0(Steamworks.Data.GetAuthSessionTicketResponse_t t)

### private class Steamworks.SteamFriends.<>c__DisplayClass56_0

#### Fields
- public System.Collections.Generic.List<Steamworks.SteamId> steamIds

#### Constructors
- public SteamFriends.<>c__DisplayClass56_0()

#### Methods
- internal void <GetFollowingList>b__0(ulong id)

### private class Steamworks.InventoryRecipe.<>c__DisplayClass5_0

#### Fields
- public Steamworks.InventoryDef inventoryDef

#### Constructors
- public InventoryRecipe.<>c__DisplayClass5_0()

#### Methods
- internal bool <ContainsIngredient>b__0(Steamworks.InventoryRecipe.Ingredient x)

### private class Steamworks.SteamUGC.<>c__DisplayClass9_0

#### Fields
- public bool downloadStarted

#### Constructors
- public SteamUGC.<>c__DisplayClass9_0()

#### Methods
- internal void <DownloadAsync>b__0(Steamworks.Result r)

### private class Steamworks.InventoryItem.<AddAsync>d__23
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.InventoryItem <>4__this
- private System.Nullable<Steamworks.InventoryResult> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.InventoryResult>> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<System.Nullable<Steamworks.InventoryResult>> <>u__1
- private Steamworks.Data.SteamInventoryResult_t <sresult>5__1
- public Steamworks.InventoryItem add
- public int quantity

#### Constructors
- public InventoryItem.<AddAsync>d__23()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamInventory.<AddPromoItemAsync>d__38
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.InventoryResult> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.InventoryResult>> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<System.Nullable<Steamworks.InventoryResult>> <>u__1
- private Steamworks.Data.SteamInventoryResult_t <sresult>5__1
- public Steamworks.Data.InventoryDefId id

#### Constructors
- public SteamInventory.<AddPromoItemAsync>d__38()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamFriends.<CacheUserInformationAsync>d__43
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1
- public bool nameonly
- public Steamworks.SteamId steamid

#### Constructors
- public SteamFriends.<CacheUserInformationAsync>d__43()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamUtils.<CheckFileSignatureAsync>d__41
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.Data.CheckFileSignature_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Steamworks.CheckFileSignature> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.CheckFileSignature_t> <>u__1
- private System.Nullable<Steamworks.Data.CheckFileSignature_t> <r>5__1
- public string filename

#### Constructors
- public SteamUtils.<CheckFileSignatureAsync>d__41()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.InventoryItem.<ConsumeAsync>d__21
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.InventoryItem <>4__this
- private System.Nullable<Steamworks.InventoryResult> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.InventoryResult>> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<System.Nullable<Steamworks.InventoryResult>> <>u__1
- private Steamworks.Data.SteamInventoryResult_t <sresult>5__1
- public int amount

#### Constructors
- public InventoryItem.<ConsumeAsync>d__21()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamInventory.<CraftItemAsync>d__33
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.InventoryResult> <>s__6
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.InventoryResult>> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<System.Nullable<Steamworks.InventoryResult>> <>u__1
- private Steamworks.Data.InventoryDefId[] <give>5__2
- private uint[] <givec>5__3
- private Steamworks.Data.InventoryItemId[] <sell>5__4
- private uint[] <sellc>5__5
- private Steamworks.Data.SteamInventoryResult_t <sresult>5__1
- public Steamworks.InventoryItem[] list
- public Steamworks.InventoryDef target

#### Constructors
- public SteamInventory.<CraftItemAsync>d__33()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamInventory.<CraftItemAsync>d__34
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.InventoryResult> <>s__6
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.InventoryResult>> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<System.Nullable<Steamworks.InventoryResult>> <>u__1
- private Steamworks.Data.InventoryDefId[] <give>5__2
- private uint[] <givec>5__3
- private Steamworks.Data.InventoryItemId[] <sell>5__4
- private uint[] <sellc>5__5
- private Steamworks.Data.SteamInventoryResult_t <sresult>5__1
- public Steamworks.InventoryItem.Amount[] list
- public Steamworks.InventoryDef target

#### Constructors
- public SteamInventory.<CraftItemAsync>d__34()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamMatchmaking.<CreateLobbyAsync>d__45
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.Data.LobbyCreated_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.Data.Lobby>> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.LobbyCreated_t> <>u__1
- private System.Nullable<Steamworks.Data.LobbyCreated_t> <lobby>5__1
- public int maxMembers

#### Constructors
- public SteamMatchmaking.<CreateLobbyAsync>d__45()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamUGC.<DeleteFileAsync>d__7
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.Data.DeleteItemResult_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.DeleteItemResult_t> <>u__1
- private System.Nullable<Steamworks.Data.DeleteItemResult_t> <r>5__1
- public Steamworks.Data.PublishedFileId fileId

#### Constructors
- public SteamUGC.<DeleteFileAsync>d__7()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamInventory.<DeserializeAsync>d__35
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.InventoryResult> <>s__3
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.InventoryResult>> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<System.Nullable<Steamworks.InventoryResult>> <>u__1
- private System.IntPtr <ptr>5__1
- private Steamworks.Data.SteamInventoryResult_t <sresult>5__2
- public byte[] data
- public int dataLength

#### Constructors
- public SteamInventory.<DeserializeAsync>d__35()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamApps.<DlcInformation>d__29
- Interfaces: System.Collections.Generic.IEnumerable<Steamworks.Data.DlcInformation>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Steamworks.Data.DlcInformation>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private Steamworks.Data.DlcInformation <>2__current
- private int <>l__initialThreadId
- private Steamworks.AppId <appid>5__1
- private bool <available>5__2
- private int <i>5__3
- private string <strVal>5__4

#### Properties
- private Steamworks.Data.DlcInformation System.Collections.Generic.IEnumerator<Steamworks.Data.DlcInformation>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public SteamApps.<DlcInformation>d__29(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<Steamworks.Data.DlcInformation> System.Collections.Generic.IEnumerable<Steamworks.Data.DlcInformation>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class Steamworks.SteamUGC.<DownloadAsync>d__9
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private Steamworks.SteamUGC.<>c__DisplayClass9_0 <>8__3
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1
- private Steamworks.Ugc.Item <item>5__1
- private System.Action<Steamworks.Result> <onDownloadStarted>5__2
- public System.Threading.CancellationToken ct
- public Steamworks.Data.PublishedFileId fileId
- public int milisecondsUpdateDelay
- public System.Action<float> progress

#### Constructors
- public SteamUGC.<DownloadAsync>d__9()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamUserStats.<FindLeaderboardAsync>d__31
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.Data.LeaderboardFindResult_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.Data.Leaderboard>> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.LeaderboardFindResult_t> <>u__1
- private System.Nullable<Steamworks.Data.LeaderboardFindResult_t> <result>5__1
- public string name

#### Constructors
- public SteamUserStats.<FindLeaderboardAsync>d__31()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamUserStats.<FindOrCreateLeaderboardAsync>d__30
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.Data.LeaderboardFindResult_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.Data.Leaderboard>> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.LeaderboardFindResult_t> <>u__1
- private System.Nullable<Steamworks.Data.LeaderboardFindResult_t> <result>5__1
- public Steamworks.Data.LeaderboardDisplay display
- public string name
- public Steamworks.Data.LeaderboardSort sort

#### Constructors
- public SteamUserStats.<FindOrCreateLeaderboardAsync>d__30()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamInventory.<GenerateItemAsync>d__32
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.InventoryResult> <>s__4
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.InventoryResult>> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<System.Nullable<Steamworks.InventoryResult>> <>u__1
- private uint[] <cnts>5__3
- private Steamworks.Data.InventoryDefId[] <defs>5__2
- private Steamworks.Data.SteamInventoryResult_t <sresult>5__1
- public int amount
- public Steamworks.InventoryDef target

#### Constructors
- public SteamInventory.<GenerateItemAsync>d__32()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamInventory.<GetAllItemsAsync>d__31
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.InventoryResult> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.InventoryResult>> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<System.Nullable<Steamworks.InventoryResult>> <>u__1
- private Steamworks.Data.SteamInventoryResult_t <sresult>5__1

#### Constructors
- public SteamInventory.<GetAllItemsAsync>d__31()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.InventoryResult.<GetAsync>d__11
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.InventoryResult>> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1
- private Steamworks.Result <_result>5__1
- public Steamworks.Data.SteamInventoryResult_t sresult

#### Constructors
- public InventoryResult.<GetAsync>d__11()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamUser.<GetAuthSessionTicketAsync>d__53
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private Steamworks.SteamUser.<>c__DisplayClass53_0 <>8__1
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Steamworks.AuthTicket> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1
- private System.Diagnostics.Stopwatch <stopwatch>5__2
- public double timeoutSeconds

#### Constructors
- public SteamUser.<GetAuthSessionTicketAsync>d__53()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SourceServerQuery.<GetChallengeData>d__7
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private byte[] <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<byte[]> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1
- private System.Runtime.CompilerServices.TaskAwaiter<byte[]> <>u__2
- private byte[] <challengeData>5__1
- public System.Net.Sockets.UdpClient client

#### Constructors
- public SourceServerQuery.<GetChallengeData>d__7()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamInventory.<GetDefinitionsWithPricesAsync>d__19
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.Data.SteamInventoryRequestPricesResult_t> <>s__7
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Steamworks.InventoryDef[]> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.SteamInventoryRequestPricesResult_t> <>u__1
- private ulong[] <baseprices>5__5
- private ulong[] <currentPrices>5__4
- private Steamworks.Data.InventoryDefId[] <defs>5__3
- private bool <gotPrices>5__6
- private uint <num>5__2
- private System.Nullable<Steamworks.Data.SteamInventoryRequestPricesResult_t> <priceRequest>5__1

#### Constructors
- public SteamInventory.<GetDefinitionsWithPricesAsync>d__19()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamUser.<GetDurationControl>d__71
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.Data.DurationControl_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Steamworks.Data.DurationControl> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.DurationControl_t> <>u__1
- private System.Nullable<Steamworks.Data.DurationControl_t> <response>5__1

#### Constructors
- public SteamUser.<GetDurationControl>d__71()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamMatchmaking.<GetFavoriteServers>d__47
- Interfaces: System.Collections.Generic.IEnumerable<Steamworks.Data.ServerInfo>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Steamworks.Data.ServerInfo>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private Steamworks.Data.ServerInfo <>2__current
- private int <>l__initialThreadId
- private Steamworks.AppId <appid>5__8
- private int <count>5__1
- private ushort <cport>5__6
- private uint <flags>5__4
- private int <i>5__2
- private uint <ip>5__7
- private ushort <qport>5__5
- private uint <timeplayed>5__3

#### Properties
- private Steamworks.Data.ServerInfo System.Collections.Generic.IEnumerator<Steamworks.Data.ServerInfo>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public SteamMatchmaking.<GetFavoriteServers>d__47(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<Steamworks.Data.ServerInfo> System.Collections.Generic.IEnumerable<Steamworks.Data.ServerInfo>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class Steamworks.SteamApps.<GetFileDetailsAsync>d__44
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.Data.FileDetailsResult_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.Data.FileDetails>> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.FileDetailsResult_t> <>u__1
- private System.Nullable<Steamworks.Data.FileDetailsResult_t> <r>5__1
- public string filename

#### Constructors
- public SteamApps.<GetFileDetailsAsync>d__44()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamFriends.<GetFollowerCount>d__55
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.Data.FriendsGetFollowerCount_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.FriendsGetFollowerCount_t> <>u__1
- private System.Nullable<Steamworks.Data.FriendsGetFollowerCount_t> <r>5__1
- public Steamworks.SteamId steamID

#### Constructors
- public SteamFriends.<GetFollowerCount>d__55()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamFriends.<GetFollowingList>d__56
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private Steamworks.SteamFriends.<>c__DisplayClass56_0 <>8__1
- private System.Nullable<Steamworks.Data.FriendsEnumerateFollowingList_t> <>s__4
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Steamworks.SteamId[]> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.FriendsEnumerateFollowingList_t> <>u__1
- private System.Nullable<Steamworks.Data.FriendsEnumerateFollowingList_t> <result>5__3
- private int <resultCount>5__2

#### Constructors
- public SteamFriends.<GetFollowingList>d__56()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamFriends.<GetFriendsWithFlag>d__27
- Interfaces: System.Collections.Generic.IEnumerable<Steamworks.Friend>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Steamworks.Friend>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private Steamworks.Friend <>2__current
- public Steamworks.FriendFlags <>3__flag
- private int <>l__initialThreadId
- private int <i>5__1
- private Steamworks.FriendFlags flag

#### Properties
- private Steamworks.Friend System.Collections.Generic.IEnumerator<Steamworks.Friend>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public SteamFriends.<GetFriendsWithFlag>d__27(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<Steamworks.Friend> System.Collections.Generic.IEnumerable<Steamworks.Friend>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class Steamworks.SteamFriends.<GetFromSource>d__35
- Interfaces: System.Collections.Generic.IEnumerable<Steamworks.Friend>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Steamworks.Friend>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private Steamworks.Friend <>2__current
- public Steamworks.SteamId <>3__steamid
- private int <>l__initialThreadId
- private int <i>5__1
- private Steamworks.SteamId steamid

#### Properties
- private Steamworks.Friend System.Collections.Generic.IEnumerator<Steamworks.Friend>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public SteamFriends.<GetFromSource>d__35(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<Steamworks.Friend> System.Collections.Generic.IEnumerable<Steamworks.Friend>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class Steamworks.SteamMatchmaking.<GetHistoryServers>d__48
- Interfaces: System.Collections.Generic.IEnumerable<Steamworks.Data.ServerInfo>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Steamworks.Data.ServerInfo>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private Steamworks.Data.ServerInfo <>2__current
- private int <>l__initialThreadId
- private Steamworks.AppId <appid>5__8
- private int <count>5__1
- private ushort <cport>5__6
- private uint <flags>5__4
- private int <i>5__2
- private uint <ip>5__7
- private ushort <qport>5__5
- private uint <timeplayed>5__3

#### Properties
- private Steamworks.Data.ServerInfo System.Collections.Generic.IEnumerator<Steamworks.Data.ServerInfo>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public SteamMatchmaking.<GetHistoryServers>d__48(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<Steamworks.Data.ServerInfo> System.Collections.Generic.IEnumerable<Steamworks.Data.ServerInfo>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class Steamworks.Friend.<GetLargeAvatarAsync>d__36
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.Friend <>4__this
- private System.Nullable<Steamworks.Data.Image> <>s__1
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.Data.Image>> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<System.Nullable<Steamworks.Data.Image>> <>u__1

#### Constructors
- public Friend.<GetLargeAvatarAsync>d__36()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamFriends.<GetLargeAvatarAsync>d__46
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.Data.Image>> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1
- private int <imageid>5__1
- public Steamworks.SteamId steamid

#### Constructors
- public SteamFriends.<GetLargeAvatarAsync>d__46()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.Friend.<GetMediumAvatarAsync>d__35
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.Friend <>4__this
- private System.Nullable<Steamworks.Data.Image> <>s__1
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.Data.Image>> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<System.Nullable<Steamworks.Data.Image>> <>u__1

#### Constructors
- public Friend.<GetMediumAvatarAsync>d__35()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamFriends.<GetMediumAvatarAsync>d__45
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.Data.Image>> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1
- public Steamworks.SteamId steamid

#### Constructors
- public SteamFriends.<GetMediumAvatarAsync>d__45()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamFriends.<GetPlayedWith>d__34
- Interfaces: System.Collections.Generic.IEnumerable<Steamworks.Friend>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Steamworks.Friend>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private Steamworks.Friend <>2__current
- private int <>l__initialThreadId
- private int <i>5__1

#### Properties
- private Steamworks.Friend System.Collections.Generic.IEnumerator<Steamworks.Friend>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public SteamFriends.<GetPlayedWith>d__34(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<Steamworks.Friend> System.Collections.Generic.IEnumerable<Steamworks.Friend>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class Steamworks.SourceServerQuery.<GetRules>d__5
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private byte[] <>s__4
- private byte[] <>s__5
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<string, string>> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<byte[]> <>u__1
- private System.Runtime.CompilerServices.TaskAwaiter <>u__2
- private System.IO.BinaryReader <br>5__6
- private byte[] <challengeBytes>5__1
- private int <index>5__8
- private ushort <numRules>5__7
- private byte[] <ruleData>5__2
- private System.Collections.Generic.Dictionary<string, string> <rules>5__3
- public System.Net.Sockets.UdpClient client

#### Constructors
- public SourceServerQuery.<GetRules>d__5()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SourceServerQuery.<GetRulesImpl>d__4
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Collections.Generic.Dictionary<string, string> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<string, string>> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.Dictionary<string, string>> <>u__1
- private System.Net.Sockets.UdpClient <client>5__1
- public System.Net.IPEndPoint endpoint

#### Constructors
- public SourceServerQuery.<GetRulesImpl>d__4()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.Friend.<GetSmallAvatarAsync>d__34
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.Friend <>4__this
- private System.Nullable<Steamworks.Data.Image> <>s__1
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.Data.Image>> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<System.Nullable<Steamworks.Data.Image>> <>u__1

#### Constructors
- public Friend.<GetSmallAvatarAsync>d__34()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamFriends.<GetSmallAvatarAsync>d__44
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.Data.Image>> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1
- public Steamworks.SteamId steamid

#### Constructors
- public SteamFriends.<GetSmallAvatarAsync>d__44()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamUser.<GetStoreAuthUrlAsync>d__60
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.Data.StoreAuthURLResponse_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<string> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.StoreAuthURLResponse_t> <>u__1
- private System.Nullable<Steamworks.Data.StoreAuthURLResponse_t> <response>5__1
- public string url

#### Constructors
- public SteamUser.<GetStoreAuthUrlAsync>d__60()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamUserStats.<get_Achievements>d__24
- Interfaces: System.Collections.Generic.IEnumerable<Steamworks.Data.Achievement>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Steamworks.Data.Achievement>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private Steamworks.Data.Achievement <>2__current
- private int <>l__initialThreadId
- private int <i>5__1

#### Properties
- private Steamworks.Data.Achievement System.Collections.Generic.IEnumerator<Steamworks.Data.Achievement>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public SteamUserStats.<get_Achievements>d__24(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<Steamworks.Data.Achievement> System.Collections.Generic.IEnumerable<Steamworks.Data.Achievement>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class Steamworks.SteamParties.<get_ActiveBeacons>d__13
- Interfaces: System.Collections.Generic.IEnumerable<Steamworks.PartyBeacon>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Steamworks.PartyBeacon>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private Steamworks.PartyBeacon <>2__current
- private int <>l__initialThreadId
- private uint <i>5__1

#### Properties
- private Steamworks.PartyBeacon System.Collections.Generic.IEnumerator<Steamworks.PartyBeacon>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public SteamParties.<get_ActiveBeacons>d__13(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<Steamworks.PartyBeacon> System.Collections.Generic.IEnumerable<Steamworks.PartyBeacon>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class Steamworks.SteamInput.<get_Controllers>d__7
- Interfaces: System.Collections.Generic.IEnumerable<Steamworks.Controller>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Steamworks.Controller>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private Steamworks.Controller <>2__current
- private int <>l__initialThreadId
- private int <i>5__2
- private int <num>5__1

#### Properties
- private Steamworks.Controller System.Collections.Generic.IEnumerator<Steamworks.Controller>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public SteamInput.<get_Controllers>d__7(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<Steamworks.Controller> System.Collections.Generic.IEnumerable<Steamworks.Controller>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class Steamworks.SteamRemoteStorage.<get_Files>d__27
- Interfaces: System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<string>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private string <>2__current
- private int <>l__initialThreadId
- private string <filename>5__3
- private int <i>5__2
- private int <_>5__1

#### Properties
- private string System.Collections.Generic.IEnumerator<System.String>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public SteamRemoteStorage.<get_Files>d__27(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class Steamworks.Friend.<get_NameHistory>d__27
- Interfaces: System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<string>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private string <>2__current
- public Steamworks.Friend <>3__<>4__this
- public Steamworks.Friend <>4__this
- private int <>l__initialThreadId
- private int <i>5__1
- private string <n>5__2

#### Properties
- private string System.Collections.Generic.IEnumerator<System.String>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public Friend.<get_NameHistory>d__27(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class Steamworks.InventoryDef.<get_Properties>d__34
- Interfaces: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private System.Collections.Generic.KeyValuePair<string, string> <>2__current
- public Steamworks.InventoryDef <>4__this
- private int <>l__initialThreadId
- private string[] <>s__3
- private int <>s__4
- private string <key>5__5
- private string[] <keys>5__2
- private string <list>5__1

#### Properties
- private System.Collections.Generic.KeyValuePair<string, string> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public InventoryDef.<get_Properties>d__34(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class Steamworks.SteamInventory.<GrantPromoItemsAsync>d__36
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.InventoryResult> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.InventoryResult>> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<System.Nullable<Steamworks.InventoryResult>> <>u__1
- private Steamworks.Data.SteamInventoryResult_t <sresult>5__1

#### Constructors
- public SteamInventory.<GrantPromoItemsAsync>d__36()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamApps.<InstalledDepots>d__35
- Interfaces: System.Collections.Generic.IEnumerable<Steamworks.Data.DepotId>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Steamworks.Data.DepotId>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private Steamworks.Data.DepotId <>2__current
- public Steamworks.AppId <>3__appid
- private int <>l__initialThreadId
- private uint <count>5__2
- private Steamworks.Data.DepotId_t[] <depots>5__1
- private int <i>5__3
- private Steamworks.AppId appid

#### Properties
- private Steamworks.Data.DepotId System.Collections.Generic.IEnumerator<Steamworks.Data.DepotId>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public SteamApps.<InstalledDepots>d__35(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<Steamworks.Data.DepotId> System.Collections.Generic.IEnumerable<Steamworks.Data.DepotId>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class Steamworks.SteamFriends.<IsFollowing>d__54
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.Data.FriendsIsFollowing_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.FriendsIsFollowing_t> <>u__1
- private System.Nullable<Steamworks.Data.FriendsIsFollowing_t> <r>5__1
- public Steamworks.SteamId steamID

#### Constructors
- public SteamFriends.<IsFollowing>d__54()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.PartyBeacon.<JoinAsync>d__7
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.PartyBeacon <>4__this
- private System.Nullable<Steamworks.Data.JoinPartyCallback_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<string> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.JoinPartyCallback_t> <>u__1
- private System.Nullable<Steamworks.Data.JoinPartyCallback_t> <result>5__1

#### Constructors
- public PartyBeacon.<JoinAsync>d__7()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamMatchmaking.<JoinLobbyAsync>d__46
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.Data.LobbyEnter_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.Data.Lobby>> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.LobbyEnter_t> <>u__1
- private System.Nullable<Steamworks.Data.LobbyEnter_t> <lobby>5__1
- public Steamworks.SteamId lobbyId

#### Constructors
- public SteamMatchmaking.<JoinLobbyAsync>d__46()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.Dispatch.<LoopClientAsync>d__22
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1

#### Constructors
- public Dispatch.<LoopClientAsync>d__22()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.Dispatch.<LoopServerAsync>d__23
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1

#### Constructors
- public Dispatch.<LoopServerAsync>d__23()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamUserStats.<PlayerCountAsync>d__26
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.Data.NumberOfCurrentPlayers_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.NumberOfCurrentPlayers_t> <>u__1
- private System.Nullable<Steamworks.Data.NumberOfCurrentPlayers_t> <result>5__1

#### Constructors
- public SteamUserStats.<PlayerCountAsync>d__26()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamUGC.<QueryFileAsync>d__10
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.Ugc.ResultPage> <>s__3
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.Ugc.Item>> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<System.Nullable<Steamworks.Ugc.ResultPage>> <>u__1
- private Steamworks.Ugc.Item <item>5__2
- private System.Nullable<Steamworks.Ugc.ResultPage> <result>5__1
- public Steamworks.Data.PublishedFileId fileId

#### Constructors
- public SteamUGC.<QueryFileAsync>d__10()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SourceServerQuery.<Receive>d__6
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Net.Sockets.UdpReceiveResult <>s__7
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<byte[]> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<System.Net.Sockets.UdpReceiveResult> <>u__1
- private System.IO.BinaryReader <br>5__8
- private byte[] <buffer>5__6
- private byte[] <combinedData>5__4
- private byte[] <data>5__10
- private int <header>5__9
- private byte <packetCount>5__3
- private byte <packetNumber>5__2
- private byte[][] <packets>5__1
- private int <requestId>5__12
- private System.Net.Sockets.UdpReceiveResult <result>5__5
- private int <splitSize>5__13
- private byte[] <unsplitdata>5__11
- public System.Net.Sockets.UdpClient client

#### Constructors
- public SourceServerQuery.<Receive>d__6()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamUser.<RequestEncryptedAppTicketAsync>d__69
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.Data.EncryptedAppTicketResponse_t> <>s__6
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<byte[]> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.EncryptedAppTicketResponse_t> <>u__1
- private byte[] <data>5__5
- private System.IntPtr <dataPtr>5__1
- private uint <outSize>5__4
- private System.Nullable<Steamworks.Data.EncryptedAppTicketResponse_t> <result>5__2
- private System.IntPtr <ticketData>5__3
- public byte[] dataToInclude

#### Constructors
- public SteamUser.<RequestEncryptedAppTicketAsync>d__69()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamUser.<RequestEncryptedAppTicketAsync>d__70
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.Data.EncryptedAppTicketResponse_t> <>s__5
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<byte[]> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.EncryptedAppTicketResponse_t> <>u__1
- private byte[] <data>5__4
- private uint <outSize>5__3
- private System.Nullable<Steamworks.Data.EncryptedAppTicketResponse_t> <result>5__1
- private System.IntPtr <ticketData>5__2

#### Constructors
- public SteamUser.<RequestEncryptedAppTicketAsync>d__70()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamUserStats.<RequestGlobalStatsAsync>d__29
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.Data.GlobalStatsReceived_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Steamworks.Result> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.GlobalStatsReceived_t> <>u__1
- private System.Nullable<Steamworks.Data.GlobalStatsReceived_t> <result>5__1
- public int days

#### Constructors
- public SteamUserStats.<RequestGlobalStatsAsync>d__29()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.Friend.<RequestInfoAsync>d__13
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.Friend <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1

#### Constructors
- public Friend.<RequestInfoAsync>d__13()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamServerStats.<RequestUserStatsAsync>d__3
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.Data.GSStatsReceived_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Steamworks.Result> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.GSStatsReceived_t> <>u__1
- private System.Nullable<Steamworks.Data.GSStatsReceived_t> <r>5__1
- public Steamworks.SteamId steamid

#### Constructors
- public SteamServerStats.<RequestUserStatsAsync>d__3()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.Friend.<RequestUserStatsAsync>d__40
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.Friend <>4__this
- private System.Nullable<Steamworks.Data.UserStatsReceived_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.UserStatsReceived_t> <>u__1
- private System.Nullable<Steamworks.Data.UserStatsReceived_t> <result>5__1

#### Constructors
- public Friend.<RequestUserStatsAsync>d__40()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SourceServerQuery.<Send>d__8
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<int> <>u__1
- private byte[] <sendBuffer>5__1
- public System.Net.Sockets.UdpClient client
- public byte[] message

#### Constructors
- public SourceServerQuery.<Send>d__8()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.InventoryItem.<SplitStackAsync>d__22
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.InventoryItem <>4__this
- private System.Nullable<Steamworks.InventoryResult> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.InventoryResult>> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<System.Nullable<Steamworks.InventoryResult>> <>u__1
- private Steamworks.Data.SteamInventoryResult_t <sresult>5__1
- public int quantity

#### Constructors
- public InventoryItem.<SplitStackAsync>d__22()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamUGC.<StartPlaytimeTracking>d__11
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.Data.StartPlaytimeTrackingResult_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.StartPlaytimeTrackingResult_t> <>u__1
- private System.Nullable<Steamworks.Data.StartPlaytimeTrackingResult_t> <result>5__1
- public Steamworks.Data.PublishedFileId fileId

#### Constructors
- public SteamUGC.<StartPlaytimeTracking>d__11()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamInventory.<StartPurchaseAsync>d__39
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.Data.SteamInventoryStartPurchaseResult_t> <>s__4
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.Data.InventoryPurchaseResult>> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.SteamInventoryStartPurchaseResult_t> <>u__1
- private Steamworks.Data.InventoryDefId[] <item_i>5__1
- private uint[] <item_q>5__2
- private System.Nullable<Steamworks.Data.SteamInventoryStartPurchaseResult_t> <r>5__3
- public Steamworks.InventoryDef[] items

#### Constructors
- public SteamInventory.<StartPurchaseAsync>d__39()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamUGC.<StopPlaytimeTracking>d__12
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.Data.StopPlaytimeTrackingResult_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.StopPlaytimeTrackingResult_t> <>u__1
- private System.Nullable<Steamworks.Data.StopPlaytimeTrackingResult_t> <result>5__1
- public Steamworks.Data.PublishedFileId fileId

#### Constructors
- public SteamUGC.<StopPlaytimeTracking>d__12()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamUGC.<StopPlaytimeTrackingForAllItems>d__13
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.Data.StopPlaytimeTrackingResult_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.StopPlaytimeTrackingResult_t> <>u__1
- private System.Nullable<Steamworks.Data.StopPlaytimeTrackingResult_t> <result>5__1

#### Constructors
- public SteamUGC.<StopPlaytimeTrackingForAllItems>d__13()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamServerStats.<StoreUserStats>d__11
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.Data.GSStatsStored_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Steamworks.Result> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.GSStatsStored_t> <>u__1
- private System.Nullable<Steamworks.Data.GSStatsStored_t> <r>5__1
- public Steamworks.SteamId steamid

#### Constructors
- public SteamServerStats.<StoreUserStats>d__11()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamInventory.<TriggerItemDropAsync>d__37
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.InventoryResult> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.InventoryResult>> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<System.Nullable<Steamworks.InventoryResult>> <>u__1
- private Steamworks.Data.SteamInventoryResult_t <sresult>5__1
- public Steamworks.Data.InventoryDefId id

#### Constructors
- public SteamInventory.<TriggerItemDropAsync>d__37()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamInventory.<WaitForDefinitions>d__13
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1
- private System.Diagnostics.Stopwatch <sw>5__1
- public float timeoutSeconds

#### Constructors
- public SteamInventory.<WaitForDefinitions>d__13()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.SteamNetworkingUtils.<WaitForPingDataAsync>d__15
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1
- private Steamworks.Data.SteamRelayNetworkStatus_t <status>5__1
- public float maxAgeInSeconds

#### Constructors
- public SteamNetworkingUtils.<WaitForPingDataAsync>d__15()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### internal enum Steamworks.AccountType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AnonGameServer = 4
- AnonUser = 10
- Chat = 8
- Clan = 7
- ConsoleUser = 9
- ContentServer = 6
- GameServer = 3
- Individual = 1
- Invalid = 0
- Max = 11
- Multiseat = 2
- Pending = 5

### internal enum Steamworks.ActivateGameOverlayToWebPageMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Default = 0
- Modal = 1

### public struct Steamworks.InventoryItem.Amount

#### Fields
- public Steamworks.InventoryItem Item
- public int Quantity

### public struct Steamworks.AnalogState

#### Fields
- internal byte BActive
- public Steamworks.InputSourceMode EMode
- public float X
- public float Y

#### Properties
- public bool Active { get; }

### public struct Steamworks.AppId

#### Fields
- public uint Value

#### Methods
- public static Steamworks.AppId op_Implicit(uint value)
- public static Steamworks.AppId op_Implicit(int value)
- public static uint op_Implicit(Steamworks.AppId value)
- public override string ToString()

### internal enum Steamworks.AppOwnershipFlags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AutoGrant = 16384
- FreeLicense = 2
- FreeWeekend = 64
- InvalidOSType = 1048576
- InvalidPlatform = 16
- LegacyFreeSub = 524288
- LicenseCanceled = 8192
- LicenseExpired = 1024
- LicenseLocked = 256
- LicensePending = 512
- LicensePermanent = 2048
- LicenseRecurring = 4096
- LowViolence = 8
- None = 0
- OwnsLicense = 1
- PendingGift = 32768
- RegionRestricted = 4
- Rental = 131072
- RentalNotActivated = 65536
- RetailLicense = 128
- SharedLicense = 32
- SiteLicense = 262144

### internal enum Steamworks.AppReleaseState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- PreloadOnly = 3
- Prerelease = 2
- Released = 4
- Unavailable = 1
- Unknown = 0

### internal enum Steamworks.AppType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Application = 2
- Beta = 65536
- Comic_UNUSED = 32768
- Config = 256
- Demo = 8
- DepotOnly = -2147483648
- DLC = 32
- Driver = 128
- Franchise = 1024
- Game = 1
- Guide = 64
- Hardware = 512
- Invalid = 0
- Media_DEPRECATED = 16
- MusicAlbum = 8192
- Plugin = 4096
- Series = 16384
- Shortcut = 1073741824
- Tool = 4
- Video = 2048

### public enum Steamworks.AuthResponse
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AuthTicketCanceled = 6
- AuthTicketInvalid = 8
- AuthTicketInvalidAlreadyUsed = 7
- LoggedInElseWhere = 4
- NoLicenseOrExpired = 2
- OK = 0
- PublisherIssuedBan = 9
- UserNotConnectedToSteam = 1
- VACBanned = 3
- VACCheckTimedOut = 5

### public class Steamworks.AuthTicket
- Interfaces: System.IDisposable

#### Fields
- public byte[] Data
- public uint Handle

#### Constructors
- public AuthTicket()

#### Methods
- public void Cancel()
- public void Dispose()

### public enum Steamworks.BeginAuthResult
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DuplicateRequest = 2
- ExpiredTicket = 5
- GameMismatch = 4
- InvalidTicket = 1
- InvalidVersion = 3
- OK = 0

### public enum Steamworks.BroadcastUploadResult
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AlreadyActive = 17
- AudioBehind = 19
- AudioInitFailed = 23
- BandwidthExceeded = 5
- Banned = 16
- Busy = 15
- Disconnect = 21
- ForcedOff = 18
- FrameFailed = 3
- InitFailed = 2
- LowFPS = 6
- MissingAudio = 11
- MissingKeyFrames = 7
- NoConnection = 8
- None = 0
- NotAllowedToPlay = 14
- OK = 1
- RelayFailed = 9
- SettingsChanged = 10
- Shutdown = 20
- Timeout = 4
- TooFarBehind = 12
- TranscodeBehind = 13
- VideoInitFailed = 22

### private struct Steamworks.Dispatch.Callback

#### Fields
- public System.Action<System.IntPtr> action
- public bool server

### internal struct Steamworks.Dispatch.CallbackMsg_t

#### Fields
- public System.IntPtr Data
- public int DataSize
- public Steamworks.Data.HSteamUser m_hSteamUser
- public Steamworks.CallbackType Type

### public enum Steamworks.CallbackType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ActiveBeaconsUpdated = 5306
- AddAppDependencyResult = 3414
- AddUGCDependencyResult = 3412
- AppProofOfPurchaseKeyResponse = 1021
- AssociateWithClanResult = 210
- AvailableBeaconLocationsUpdated = 5305
- AvatarImageLoaded = 334
- BroadcastUploadStart = 4604
- BroadcastUploadStop = 4605
- ChangeNumOpenSlotsCallback = 5304
- CheckFileSignature = 705
- ClanOfficerListResponse = 335
- ClientGameServerDeny = 113
- ComputeNewPlayerCompatibilityResult = 211
- CreateBeaconCallback = 5302
- CreateItemResult = 3403
- DeleteItemResult = 3417
- DlcInstalled = 1005
- DownloadClanActivityCountsResult = 341
- DownloadItemResult = 3406
- DurationControl = 167
- EncryptedAppTicketResponse = 154
- EndGameResultCallback = 5215
- FavoritesListAccountsUpdated = 516
- FavoritesListChanged = 502
- FileDetailsResult = 1023
- FriendRichPresenceUpdate = 336
- FriendsEnumerateFollowingList = 346
- FriendsGetFollowerCount = 344
- FriendsIsFollowing = 345
- GameConnectedChatJoin = 339
- GameConnectedChatLeave = 340
- GameConnectedClanChatMsg = 338
- GameConnectedFriendChatMsg = 343
- GameLobbyJoinRequested = 333
- GameOverlayActivated = 331
- GamepadTextInputDismissed = 714
- GameRichPresenceJoinRequested = 337
- GameServerChangeRequested = 332
- GameWebCallback = 164
- GetAppDependenciesResult = 3416
- GetAuthSessionTicketResponse = 163
- GetOPFSettingsResult = 4624
- GetUserItemVoteResult = 3409
- GetVideoURLResult = 4611
- GlobalAchievementPercentagesReady = 1110
- GlobalStatsReceived = 1112
- GSClientAchievementStatus = 206
- GSClientApprove = 201
- GSClientDeny = 202
- GSClientGroupStatus = 208
- GSClientKick = 203
- GSGameplayStats = 207
- GSPolicyResponse = 115
- GSReputation = 209
- GSStatsReceived = 1800
- GSStatsStored = 1801
- GSStatsUnloaded = 1108
- HTML_BrowserReady = 4501
- HTML_BrowserRestarted = 4527
- HTML_CanGoBackAndForward = 4510
- HTML_ChangedTitle = 4508
- HTML_CloseBrowser = 4504
- HTML_FileOpenDialog = 4516
- HTML_FinishedRequest = 4506
- HTML_HideToolTip = 4526
- HTML_HorizontalScroll = 4511
- HTML_JSAlert = 4514
- HTML_JSConfirm = 4515
- HTML_LinkAtPosition = 4513
- HTML_NeedsPaint = 4502
- HTML_NewWindow = 4521
- HTML_OpenLinkInNewTab = 4507
- HTML_SearchResults = 4509
- HTML_SetCursor = 4522
- HTML_ShowToolTip = 4524
- HTML_StartRequest = 4503
- HTML_StatusText = 4523
- HTML_UpdateToolTip = 4525
- HTML_URLChanged = 4505
- HTML_VerticalScroll = 4512
- HTTPRequestCompleted = 2101
- HTTPRequestDataReceived = 2103
- HTTPRequestHeadersReceived = 2102
- IPCFailure = 117
- IPCountry = 701
- ItemInstalled = 3405
- JoinClanChatRoomCompletionResult = 342
- JoinPartyCallback = 5301
- LeaderboardFindResult = 1104
- LeaderboardScoresDownloaded = 1105
- LeaderboardScoreUploaded = 1106
- LeaderboardUGCSet = 1111
- LicensesUpdated = 125
- LobbyChatMsg = 507
- LobbyChatUpdate = 506
- LobbyCreated = 513
- LobbyDataUpdate = 505
- LobbyEnter = 504
- LobbyGameCreated = 509
- LobbyInvite = 503
- LobbyKicked = 512
- LobbyMatchList = 510
- LowBatteryPower = 702
- MarketEligibilityResponse = 166
- MicroTxnAuthorizationResponse = 152
- MusicPlayerRemoteToFront = 4103
- MusicPlayerRemoteWillActivate = 4101
- MusicPlayerRemoteWillDeactivate = 4102
- MusicPlayerSelectsPlaylistEntry = 4013
- MusicPlayerSelectsQueueEntry = 4012
- MusicPlayerWantsLooped = 4110
- MusicPlayerWantsPause = 4106
- MusicPlayerWantsPlay = 4105
- MusicPlayerWantsPlayingRepeatStatus = 4114
- MusicPlayerWantsPlayNext = 4108
- MusicPlayerWantsPlayPrevious = 4107
- MusicPlayerWantsShuffled = 4109
- MusicPlayerWantsVolume = 4011
- MusicPlayerWillQuit = 4104
- NewUrlLaunchParameters = 1014
- NumberOfCurrentPlayers = 1107
- P2PSessionConnectFail = 1203
- P2PSessionRequest = 1202
- PersonaStateChange = 304
- PlaybackStatusHasChanged = 4001
- PSNGameBootInviteResult = 515
- RegisterActivationCodeResponse = 1008
- RemoteStorageAppSyncedClient = 1301
- RemoteStorageAppSyncedServer = 1302
- RemoteStorageAppSyncProgress = 1303
- RemoteStorageAppSyncStatusCheck = 1305
- RemoteStorageDeletePublishedFileResult = 1311
- RemoteStorageDownloadUGCResult = 1317
- RemoteStorageEnumeratePublishedFilesByUserActionResult = 1328
- RemoteStorageEnumerateUserPublishedFilesResult = 1312
- RemoteStorageEnumerateUserSharedWorkshopFilesResult = 1326
- RemoteStorageEnumerateUserSubscribedFilesResult = 1314
- RemoteStorageEnumerateWorkshopFilesResult = 1319
- RemoteStorageFileReadAsyncComplete = 1332
- RemoteStorageFileShareResult = 1307
- RemoteStorageFileWriteAsyncComplete = 1331
- RemoteStorageGetPublishedFileDetailsResult = 1318
- RemoteStorageGetPublishedItemVoteDetailsResult = 1320
- RemoteStoragePublishedFileDeleted = 1323
- RemoteStoragePublishedFileSubscribed = 1321
- RemoteStoragePublishedFileUnsubscribed = 1322
- RemoteStoragePublishedFileUpdated = 1330
- RemoteStoragePublishFileProgress = 1329
- RemoteStoragePublishFileResult = 1309
- RemoteStorageSetUserPublishedFileActionResult = 1327
- RemoteStorageSubscribePublishedFileResult = 1313
- RemoteStorageUnsubscribePublishedFileResult = 1315
- RemoteStorageUpdatePublishedFileResult = 1316
- RemoteStorageUpdateUserPublishedItemVoteResult = 1324
- RemoteStorageUserVoteDetails = 1325
- RemoveAppDependencyResult = 3415
- RemoveUGCDependencyResult = 3413
- RequestPlayersForGameFinalResultCallback = 5213
- RequestPlayersForGameProgressCallback = 5211
- RequestPlayersForGameResultCallback = 5212
- ReservationNotificationCallback = 5303
- ScreenshotReady = 2301
- ScreenshotRequested = 2302
- SearchForGameProgressCallback = 5201
- SearchForGameResultCallback = 5202
- SetPersonaNameResponse = 347
- SetUserItemVoteResult = 3408
- StartPlaytimeTrackingResult = 3410
- SteamAPICallCompleted = 703
- SteamAppInstalled = 3901
- SteamAppUninstalled = 3902
- SteamInventoryDefinitionUpdate = 4702
- SteamInventoryEligiblePromoItemDefIDs = 4703
- SteamInventoryFullUpdate = 4701
- SteamInventoryRequestPricesResult = 4705
- SteamInventoryResultReady = 4700
- SteamInventoryStartPurchaseResult = 4704
- SteamNetAuthenticationStatus = 1222
- SteamNetConnectionStatusChangedCallback = 1221
- SteamParentalSettingsChanged = 5001
- SteamRelayNetworkStatus = 1281
- SteamRemotePlaySessionConnected = 5701
- SteamRemotePlaySessionDisconnected = 5702
- SteamServerConnectFailure = 102
- SteamServersConnected = 101
- SteamServersDisconnected = 103
- SteamShutdown = 704
- SteamUGCQueryCompleted = 3401
- SteamUGCRequestUGCDetailsResult = 3402
- StopPlaytimeTrackingResult = 3411
- StoreAuthURLResponse = 165
- SubmitItemUpdateResult = 3404
- SubmitPlayerResultResultCallback = 5214
- UnreadChatMessagesChanged = 348
- UserAchievementIconFetched = 1109
- UserAchievementStored = 1103
- UserFavoriteItemsListChanged = 3407
- UserStatsReceived = 1101
- UserStatsStored = 1102
- UserStatsUnloaded = 1108
- ValidateAuthTicketResponse = 143
- VolumeHasChanged = 4002

### internal static class Steamworks.CallbackTypeFactory

#### Fields
- internal static System.Collections.Generic.Dictionary<Steamworks.CallbackType, System.Type> All

#### Constructors
- private static CallbackTypeFactory()

### internal struct Steamworks.CallResult<T>
- Interfaces: System.Runtime.CompilerServices.INotifyCompletion

#### Fields
- private Steamworks.Data.SteamAPICall_t call
- private bool server
- private Steamworks.ISteamUtils utils

#### Properties
- public bool IsCompleted { get; }

#### Constructors
- public CallResult<T>(Steamworks.Data.SteamAPICall_t call, bool server)

#### Methods
- internal Steamworks.CallResult<T> GetAwaiter()
- public System.Nullable<T> GetResult()
- public void OnCompleted(System.Action continuation)

### internal enum Steamworks.ChatEntryType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ChatMsg = 1
- Disconnected = 10
- Emote = 4
- Entered = 7
- HistoricalChat = 11
- Invalid = 0
- InviteGame = 3
- LeftConversation = 6
- LinkBlocked = 14
- Typing = 2
- WasBanned = 9
- WasKicked = 8

### internal enum Steamworks.ChatMemberStateChange
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Banned = 16
- Disconnected = 4
- Entered = 1
- Kicked = 8
- Left = 2

### internal enum Steamworks.ChatSteamIDInstanceFlags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AccountInstanceMask = 4095
- InstanceFlagClan = 524288
- InstanceFlagLobby = 262144
- InstanceFlagMMSLobby = 131072

### public enum Steamworks.CheckFileSignature
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- FileNotFound = 2
- InvalidSignature = 0
- NoSignaturesFoundForThisApp = 3
- NoSignaturesFoundForThisFile = 4
- ValidSignature = 1

### public class Steamworks.ConnectionManager

#### Fields
- private Steamworks.Data.ConnectionInfo <ConnectionInfo>k__BackingField
- private Steamworks.IConnectionManager <Interface>k__BackingField
- public bool Connected
- public bool Connecting
- public Steamworks.Data.Connection Connection

#### Properties
- public Steamworks.Data.ConnectionInfo ConnectionInfo { get; internal set; }
- public string ConnectionName { get; set; }
- public Steamworks.IConnectionManager Interface { get; set; }
- public long UserData { get; set; }

#### Constructors
- public ConnectionManager()

#### Methods
- public void Close()
- public virtual void OnConnected(Steamworks.Data.ConnectionInfo info)
- public virtual void OnConnecting(Steamworks.Data.ConnectionInfo info)
- public virtual void OnConnectionChanged(Steamworks.Data.ConnectionInfo info)
- public virtual void OnDisconnected(Steamworks.Data.ConnectionInfo info)
- public virtual void OnMessage(System.IntPtr data, int size, long messageNum, long recvTime, int channel)
- public void Receive(int bufferSize = 32)
- internal void ReceiveMessage(System.IntPtr msgPtr)
- public override string ToString()

### public enum Steamworks.ConnectionState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ClosedByPeer = 4
- Connected = 3
- Connecting = 1
- Dead = -3
- FindingRoute = 2
- FinWait = -1
- Linger = -2
- None = 0
- ProblemDetectedLocally = 5

### public struct Steamworks.Controller

#### Fields
- internal Steamworks.Data.InputHandle_t Handle

#### Properties
- public string ActionSet { set; }
- public ulong Id { get; }
- public Steamworks.InputType InputType { get; }

#### Constructors
- internal Controller(Steamworks.Data.InputHandle_t inputHandle_t)

#### Methods
- public void ActivateLayer(string layer)
- public void ClearLayers()
- public void DeactivateLayer(string layer)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Controller p)
- public Steamworks.AnalogState GetAnalogState(string actionName)
- public Steamworks.DigitalState GetDigitalState(string actionName)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Controller a, Steamworks.Controller b)
- public static bool op_Inequality(Steamworks.Controller a, Steamworks.Controller b)
- public override string ToString()

### internal enum Steamworks.ControllerActionOrigin
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- A = 1
- B = 2
- Back = 10
- Count = 245
- Gyro_Move = 35
- Gyro_Pitch = 36
- Gyro_Roll = 38
- Gyro_Yaw = 37
- LeftBumper = 5
- LeftGrip = 7
- LeftPad_Click = 13
- LeftPad_DPadEast = 17
- LeftPad_DPadNorth = 14
- LeftPad_DPadSouth = 15
- LeftPad_DPadWest = 16
- LeftPad_Swipe = 12
- LeftPad_Touch = 11
- LeftStick_Click = 30
- LeftStick_DPadEast = 34
- LeftStick_DPadNorth = 31
- LeftStick_DPadSouth = 32
- LeftStick_DPadWest = 33
- LeftStick_Move = 29
- LeftTrigger_Click = 26
- LeftTrigger_Pull = 25
- MaximumPossibleValue = 32767
- None = 0
- PS4_CenterPad_Click = 63
- PS4_CenterPad_DPadEast = 67
- PS4_CenterPad_DPadNorth = 64
- PS4_CenterPad_DPadSouth = 65
- PS4_CenterPad_DPadWest = 66
- PS4_CenterPad_Swipe = 62
- PS4_CenterPad_Touch = 61
- PS4_Circle = 40
- PS4_DPad_East = 87
- PS4_DPad_Move = 241
- PS4_DPad_North = 84
- PS4_DPad_South = 85
- PS4_DPad_West = 86
- PS4_Gyro_Move = 88
- PS4_Gyro_Pitch = 89
- PS4_Gyro_Roll = 91
- PS4_Gyro_Yaw = 90
- PS4_LeftBumper = 43
- PS4_LeftPad_Click = 49
- PS4_LeftPad_DPadEast = 53
- PS4_LeftPad_DPadNorth = 50
- PS4_LeftPad_DPadSouth = 51
- PS4_LeftPad_DPadWest = 52
- PS4_LeftPad_Swipe = 48
- PS4_LeftPad_Touch = 47
- PS4_LeftStick_Click = 73
- PS4_LeftStick_DPadEast = 77
- PS4_LeftStick_DPadNorth = 74
- PS4_LeftStick_DPadSouth = 75
- PS4_LeftStick_DPadWest = 76
- PS4_LeftStick_Move = 72
- PS4_LeftTrigger_Click = 69
- PS4_LeftTrigger_Pull = 68
- PS4_Options = 45
- PS4_RightBumper = 44
- PS4_RightPad_Click = 56
- PS4_RightPad_DPadEast = 60
- PS4_RightPad_DPadNorth = 57
- PS4_RightPad_DPadSouth = 58
- PS4_RightPad_DPadWest = 59
- PS4_RightPad_Swipe = 55
- PS4_RightPad_Touch = 54
- PS4_RightStick_Click = 79
- PS4_RightStick_DPadEast = 83
- PS4_RightStick_DPadNorth = 80
- PS4_RightStick_DPadSouth = 81
- PS4_RightStick_DPadWest = 82
- PS4_RightStick_Move = 78
- PS4_RightTrigger_Click = 71
- PS4_RightTrigger_Pull = 70
- PS4_Share = 46
- PS4_Square = 42
- PS4_Triangle = 41
- PS4_X = 39
- RightBumper = 6
- RightGrip = 8
- RightPad_Click = 20
- RightPad_DPadEast = 24
- RightPad_DPadNorth = 21
- RightPad_DPadSouth = 22
- RightPad_DPadWest = 23
- RightPad_Swipe = 19
- RightPad_Touch = 18
- RightTrigger_Click = 28
- RightTrigger_Pull = 27
- Start = 9
- SteamV2_A = 148
- SteamV2_B = 149
- SteamV2_Back = 165
- SteamV2_Gyro_Move = 192
- SteamV2_Gyro_Pitch = 193
- SteamV2_Gyro_Roll = 195
- SteamV2_Gyro_Yaw = 194
- SteamV2_LeftBumper = 152
- SteamV2_LeftBumper_Pressure = 158
- SteamV2_LeftGrip_Lower = 154
- SteamV2_LeftGrip_Pressure = 160
- SteamV2_LeftGrip_Upper = 155
- SteamV2_LeftGrip_Upper_Pressure = 162
- SteamV2_LeftPad_Click = 168
- SteamV2_LeftPad_DPadEast = 173
- SteamV2_LeftPad_DPadNorth = 170
- SteamV2_LeftPad_DPadSouth = 171
- SteamV2_LeftPad_DPadWest = 172
- SteamV2_LeftPad_Pressure = 169
- SteamV2_LeftPad_Swipe = 167
- SteamV2_LeftPad_Touch = 166
- SteamV2_LeftStick_Click = 187
- SteamV2_LeftStick_DPadEast = 191
- SteamV2_LeftStick_DPadNorth = 188
- SteamV2_LeftStick_DPadSouth = 189
- SteamV2_LeftStick_DPadWest = 190
- SteamV2_LeftStick_Move = 186
- SteamV2_LeftTrigger_Click = 183
- SteamV2_LeftTrigger_Pull = 182
- SteamV2_RightBumper = 153
- SteamV2_RightBumper_Pressure = 159
- SteamV2_RightGrip_Lower = 156
- SteamV2_RightGrip_Pressure = 161
- SteamV2_RightGrip_Upper = 157
- SteamV2_RightGrip_Upper_Pressure = 163
- SteamV2_RightPad_Click = 176
- SteamV2_RightPad_DPadEast = 181
- SteamV2_RightPad_DPadNorth = 178
- SteamV2_RightPad_DPadSouth = 179
- SteamV2_RightPad_DPadWest = 180
- SteamV2_RightPad_Pressure = 177
- SteamV2_RightPad_Swipe = 175
- SteamV2_RightPad_Touch = 174
- SteamV2_RightTrigger_Click = 185
- SteamV2_RightTrigger_Pull = 184
- SteamV2_Start = 164
- SteamV2_X = 150
- SteamV2_Y = 151
- Switch_A = 196
- Switch_B = 197
- Switch_Capture = 204
- Switch_DPad_East = 224
- Switch_DPad_Move = 244
- Switch_DPad_North = 221
- Switch_DPad_South = 222
- Switch_DPad_West = 223
- Switch_LeftBumper = 200
- Switch_LeftGrip_Lower = 237
- Switch_LeftGrip_Upper = 238
- Switch_LeftGyro_Move = 233
- Switch_LeftGyro_Pitch = 234
- Switch_LeftGyro_Roll = 236
- Switch_LeftGyro_Yaw = 235
- Switch_LeftStick_Click = 210
- Switch_LeftStick_DPadEast = 214
- Switch_LeftStick_DPadNorth = 211
- Switch_LeftStick_DPadSouth = 212
- Switch_LeftStick_DPadWest = 213
- Switch_LeftStick_Move = 209
- Switch_LeftTrigger_Click = 206
- Switch_LeftTrigger_Pull = 205
- Switch_Minus = 203
- Switch_Plus = 202
- Switch_ProGyro_Move = 225
- Switch_ProGyro_Pitch = 226
- Switch_ProGyro_Roll = 228
- Switch_ProGyro_Yaw = 227
- Switch_RightBumper = 201
- Switch_RightGrip_Lower = 239
- Switch_RightGrip_Upper = 240
- Switch_RightGyro_Move = 229
- Switch_RightGyro_Pitch = 230
- Switch_RightGyro_Roll = 232
- Switch_RightGyro_Yaw = 231
- Switch_RightStick_Click = 216
- Switch_RightStick_DPadEast = 220
- Switch_RightStick_DPadNorth = 217
- Switch_RightStick_DPadSouth = 218
- Switch_RightStick_DPadWest = 219
- Switch_RightStick_Move = 215
- Switch_RightTrigger_Click = 208
- Switch_RightTrigger_Pull = 207
- Switch_X = 198
- Switch_Y = 199
- X = 3
- XBox360_A = 120
- XBox360_B = 121
- XBox360_Back = 127
- XBox360_DPad_East = 147
- XBox360_DPad_Move = 243
- XBox360_DPad_North = 144
- XBox360_DPad_South = 145
- XBox360_DPad_West = 146
- XBox360_LeftBumper = 124
- XBox360_LeftStick_Click = 133
- XBox360_LeftStick_DPadEast = 137
- XBox360_LeftStick_DPadNorth = 134
- XBox360_LeftStick_DPadSouth = 135
- XBox360_LeftStick_DPadWest = 136
- XBox360_LeftStick_Move = 132
- XBox360_LeftTrigger_Click = 129
- XBox360_LeftTrigger_Pull = 128
- XBox360_RightBumper = 125
- XBox360_RightStick_Click = 139
- XBox360_RightStick_DPadEast = 143
- XBox360_RightStick_DPadNorth = 140
- XBox360_RightStick_DPadSouth = 141
- XBox360_RightStick_DPadWest = 142
- XBox360_RightStick_Move = 138
- XBox360_RightTrigger_Click = 131
- XBox360_RightTrigger_Pull = 130
- XBox360_Start = 126
- XBox360_X = 122
- XBox360_Y = 123
- XBoxOne_A = 92
- XBoxOne_B = 93
- XBoxOne_DPad_East = 119
- XBoxOne_DPad_Move = 242
- XBoxOne_DPad_North = 116
- XBoxOne_DPad_South = 117
- XBoxOne_DPad_West = 118
- XBoxOne_LeftBumper = 96
- XBoxOne_LeftStick_Click = 105
- XBoxOne_LeftStick_DPadEast = 109
- XBoxOne_LeftStick_DPadNorth = 106
- XBoxOne_LeftStick_DPadSouth = 107
- XBoxOne_LeftStick_DPadWest = 108
- XBoxOne_LeftStick_Move = 104
- XBoxOne_LeftTrigger_Click = 101
- XBoxOne_LeftTrigger_Pull = 100
- XBoxOne_Menu = 98
- XBoxOne_RightBumper = 97
- XBoxOne_RightStick_Click = 111
- XBoxOne_RightStick_DPadEast = 115
- XBoxOne_RightStick_DPadNorth = 112
- XBoxOne_RightStick_DPadSouth = 113
- XBoxOne_RightStick_DPadWest = 114
- XBoxOne_RightStick_Move = 110
- XBoxOne_RightTrigger_Click = 103
- XBoxOne_RightTrigger_Pull = 102
- XBoxOne_View = 99
- XBoxOne_X = 94
- XBoxOne_Y = 95
- Y = 4

### private struct Steamworks.SteamNetworkingUtils.DebugMessage

#### Fields
- public string Msg
- public Steamworks.NetDebugOutput Type

### internal enum Steamworks.DenyReason
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Cheater = 5
- Generic = 2
- IncompatibleAnticheat = 8
- IncompatibleSoftware = 10
- Invalid = 0
- InvalidVersion = 1
- LoggedInElseWhere = 6
- MemoryCorruption = 9
- NoLicense = 4
- NotLoggedOn = 3
- SteamConnectionError = 12
- SteamConnectionLost = 11
- SteamOwnerLeftGuestUser = 15
- SteamResponseTimedOut = 13
- SteamValidationStalled = 14
- UnknownText = 7

### public struct Steamworks.DigitalState

#### Fields
- internal byte BActive
- internal byte BState

#### Properties
- public bool Active { get; }
- public bool Pressed { get; }

### public static class Steamworks.Dispatch

#### Fields
- private static Steamworks.Data.HSteamPipe <ClientPipe>k__BackingField
- private static Steamworks.Data.HSteamPipe <ServerPipe>k__BackingField
- private static System.Collections.Generic.List<System.Action<System.IntPtr>> actionsToCall
- private static System.Collections.Generic.Dictionary<Steamworks.CallbackType, System.Collections.Generic.List<Steamworks.Dispatch.Callback>> Callbacks
- public static System.Action<Steamworks.CallbackType, string, bool> OnDebugCallback
- public static System.Action<System.Exception> OnException
- private static System.Collections.Generic.Dictionary<ulong, Steamworks.Dispatch.ResultCallback> ResultCallbacks
- private static bool runningFrame

#### Properties
- internal static Steamworks.Data.HSteamPipe ClientPipe { get; set; }
- internal static Steamworks.Data.HSteamPipe ServerPipe { get; set; }

#### Constructors
- private static Dispatch()

#### Methods
- internal static string CallbackToString(Steamworks.CallbackType type, System.IntPtr data, int expectedsize)
- internal static void Frame(Steamworks.Data.HSteamPipe pipe)
- internal static void Init()
- internal static void Install<T>(System.Action<T> p, bool server = false)
- internal static void LoopClientAsync()
- internal static void LoopServerAsync()
- internal static void OnCallComplete<T>(Steamworks.Data.SteamAPICall_t call, System.Action continuation, bool server)
- private static void ProcessCallback(Steamworks.Dispatch.CallbackMsg_t msg, bool isServer)
- private static void ProcessResult(Steamworks.Dispatch.CallbackMsg_t msg)
- internal static void ShutdownClient()
- internal static void ShutdownServer()
- internal static bool SteamAPI_ManualDispatch_FreeLastCallback(Steamworks.Data.HSteamPipe pipe)
- internal static bool SteamAPI_ManualDispatch_GetNextCallback(Steamworks.Data.HSteamPipe pipe, out Steamworks.Dispatch.CallbackMsg_t msg)
- internal static void SteamAPI_ManualDispatch_Init()
- internal static void SteamAPI_ManualDispatch_RunFrame(Steamworks.Data.HSteamPipe pipe)

### internal enum Steamworks.DurationControlNotification
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DurationControlNotification1Hour = 1
- DurationControlNotification3Hours = 2
- ExitSoon_3h = 5
- ExitSoon_5h = 6
- ExitSoon_Night = 7
- HalfProgress = 3
- None = 0
- NoProgress = 4

### public enum Steamworks.DurationControlProgress
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ExitSoon_3h = 3
- ExitSoon_5h = 4
- ExitSoon_Night = 5
- Progress_Full = 0
- Progress_Half = 1
- Progress_None = 2

### internal static class Steamworks.Epoch

#### Fields
- private static readonly System.DateTime epoch

#### Properties
- public static int Current { get; }

#### Constructors
- private static Epoch()

#### Methods
- public static uint FromDateTime(System.DateTime dt)
- public static System.DateTime ToDateTime(decimal unixTime)

### public struct Steamworks.Friend

#### Fields
- public Steamworks.SteamId Id

#### Properties
- public System.Nullable<Steamworks.Friend.FriendGameInfo> GameInfo { get; }
- public bool IsAway { get; }
- public bool IsBlocked { get; }
- public bool IsBusy { get; }
- public bool IsFriend { get; }
- public bool IsMe { get; }
- public bool IsOnline { get; }
- public bool IsPlayingThisGame { get; }
- public bool IsSnoozing { get; }
- public string Name { get; }
- public System.Collections.Generic.IEnumerable<string> NameHistory { get; }
- public Steamworks.Relationship Relationship { get; }
- public Steamworks.FriendState State { get; }
- public int SteamLevel { get; }

#### Constructors
- public Friend(Steamworks.SteamId steamid)

#### Methods
- public bool GetAchievement(string statName, bool defult = false)
- public System.DateTime GetAchievementUnlockTime(string statName)
- public System.Threading.Tasks.Task<System.Nullable<Steamworks.Data.Image>> GetLargeAvatarAsync()
- public System.Threading.Tasks.Task<System.Nullable<Steamworks.Data.Image>> GetMediumAvatarAsync()
- public string GetRichPresence(string key)
- public System.Threading.Tasks.Task<System.Nullable<Steamworks.Data.Image>> GetSmallAvatarAsync()
- public float GetStatFloat(string statName, float defult = 0)
- public int GetStatInt(string statName, int defult = 0)
- public bool InviteToGame(string Text)
- public bool IsIn(Steamworks.SteamId group_or_room)
- public System.Threading.Tasks.Task RequestInfoAsync()
- public System.Threading.Tasks.Task<bool> RequestUserStatsAsync()
- public bool SendMessage(string message)
- public override string ToString()

### internal enum Steamworks.FriendFlags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- All = 65535
- Blocked = 1
- ChatMember = 4096
- ClanMember = 8
- FriendshipRequested = 2
- Ignored = 512
- IgnoredFriend = 1024
- Immediate = 4
- None = 0
- OnGameServer = 16
- RequestingFriendship = 128
- RequestingInfo = 256

### public struct Steamworks.Friend.FriendGameInfo

#### Fields
- public int ConnectionPort
- internal ulong GameID
- internal uint GameIP
- public int QueryPort
- internal ulong SteamIDLobby

#### Properties
- public System.Net.IPAddress IpAddress { get; }
- public uint IpAddressRaw { get; }
- public System.Nullable<Steamworks.Data.Lobby> Lobby { get; }

#### Methods
- internal static Steamworks.Friend.FriendGameInfo From(Steamworks.Data.FriendGameInfo_t i)

### public enum Steamworks.FriendState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Away = 3
- Busy = 2
- Invisible = 7
- LookingToPlay = 6
- LookingToTrade = 5
- Max = 8
- Offline = 0
- Online = 1
- Snooze = 4

### public enum Steamworks.GamepadTextInputLineMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- MultipleLines = 1
- SingleLine = 0

### public enum Steamworks.GamepadTextInputMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Normal = 0
- Password = 1

### internal enum Steamworks.GameSearchErrorCode_t
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Failed_NotAuthorized = 8
- Failed_Not_Lobby_Leader = 4
- Failed_No_Host_Available = 5
- Failed_No_Search_In_Progress = 3
- Failed_Offline = 7
- Failed_Search_Already_In_Progress = 2
- Failed_Search_Params_Invalid = 6
- Failed_Unknown_Error = 9
- OK = 1

### internal static class Steamworks.Helpers

#### Fields
- private static byte[][] BufferPool
- private static int BufferPoolIndex
- public static const int MaxStringSize
- private static System.IntPtr[] MemoryPool
- private static int MemoryPoolIndex

#### Methods
- internal static string MemoryToString(System.IntPtr ptr)
- public static byte[] TakeBuffer(int minSize)
- public static System.IntPtr TakeMemory()

### internal enum Steamworks.HTTPMethod
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DELETE = 5
- GET = 1
- HEAD = 2
- Invalid = 0
- OPTIONS = 6
- PATCH = 7
- POST = 3
- PUT = 4

### internal enum Steamworks.HTTPStatusCode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Code100Continue = 100
- Code101SwitchingProtocols = 101
- Code200OK = 200
- Code201Created = 201
- Code202Accepted = 202
- Code203NonAuthoritative = 203
- Code204NoContent = 204
- Code205ResetContent = 205
- Code206PartialContent = 206
- Code300MultipleChoices = 300
- Code301MovedPermanently = 301
- Code302Found = 302
- Code303SeeOther = 303
- Code304NotModified = 304
- Code305UseProxy = 305
- Code307TemporaryRedirect = 307
- Code400BadRequest = 400
- Code401Unauthorized = 401
- Code402PaymentRequired = 402
- Code403Forbidden = 403
- Code404NotFound = 404
- Code405MethodNotAllowed = 405
- Code406NotAcceptable = 406
- Code407ProxyAuthRequired = 407
- Code408RequestTimeout = 408
- Code409Conflict = 409
- Code410Gone = 410
- Code411LengthRequired = 411
- Code412PreconditionFailed = 412
- Code413RequestEntityTooLarge = 413
- Code414RequestURITooLong = 414
- Code415UnsupportedMediaType = 415
- Code416RequestedRangeNotSatisfiable = 416
- Code417ExpectationFailed = 417
- Code429TooManyRequests = 429
- Code4xxUnknown = 418
- Code500InternalServerError = 500
- Code501NotImplemented = 501
- Code502BadGateway = 502
- Code503ServiceUnavailable = 503
- Code504GatewayTimeout = 504
- Code505HTTPVersionNotSupported = 505
- Code5xxUnknown = 599
- Invalid = 0

### internal interface Steamworks.ICallbackData

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

### public interface Steamworks.IConnectionManager

#### Methods
- public void OnConnected(Steamworks.Data.ConnectionInfo info)
- public void OnConnecting(Steamworks.Data.ConnectionInfo info)
- public void OnDisconnected(Steamworks.Data.ConnectionInfo info)
- public void OnMessage(System.IntPtr data, int size, long messageNum, long recvTime, int channel)

### public struct Steamworks.InventoryRecipe.Ingredient

#### Fields
- public int Count
- public Steamworks.InventoryDef Definition
- public int DefinitionId

#### Methods
- internal static Steamworks.InventoryRecipe.Ingredient FromString(string part)

### internal enum Steamworks.InputActionOrigin
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Count = 258
- MaximumPossibleValue = 32767
- None = 0
- PS4_CenterPad_Click = 74
- PS4_CenterPad_DPadEast = 78
- PS4_CenterPad_DPadNorth = 75
- PS4_CenterPad_DPadSouth = 76
- PS4_CenterPad_DPadWest = 77
- PS4_CenterPad_Swipe = 73
- PS4_CenterPad_Touch = 72
- PS4_Circle = 51
- PS4_DPad_East = 98
- PS4_DPad_Move = 103
- PS4_DPad_North = 95
- PS4_DPad_South = 96
- PS4_DPad_West = 97
- PS4_Gyro_Move = 99
- PS4_Gyro_Pitch = 100
- PS4_Gyro_Roll = 102
- PS4_Gyro_Yaw = 101
- PS4_LeftBumper = 54
- PS4_LeftPad_Click = 60
- PS4_LeftPad_DPadEast = 64
- PS4_LeftPad_DPadNorth = 61
- PS4_LeftPad_DPadSouth = 62
- PS4_LeftPad_DPadWest = 63
- PS4_LeftPad_Swipe = 59
- PS4_LeftPad_Touch = 58
- PS4_LeftStick_Click = 84
- PS4_LeftStick_DPadEast = 88
- PS4_LeftStick_DPadNorth = 85
- PS4_LeftStick_DPadSouth = 86
- PS4_LeftStick_DPadWest = 87
- PS4_LeftStick_Move = 83
- PS4_LeftTrigger_Click = 80
- PS4_LeftTrigger_Pull = 79
- PS4_Options = 56
- PS4_Reserved1 = 104
- PS4_Reserved10 = 113
- PS4_Reserved2 = 105
- PS4_Reserved3 = 106
- PS4_Reserved4 = 107
- PS4_Reserved5 = 108
- PS4_Reserved6 = 109
- PS4_Reserved7 = 110
- PS4_Reserved8 = 111
- PS4_Reserved9 = 112
- PS4_RightBumper = 55
- PS4_RightPad_Click = 67
- PS4_RightPad_DPadEast = 71
- PS4_RightPad_DPadNorth = 68
- PS4_RightPad_DPadSouth = 69
- PS4_RightPad_DPadWest = 70
- PS4_RightPad_Swipe = 66
- PS4_RightPad_Touch = 65
- PS4_RightStick_Click = 90
- PS4_RightStick_DPadEast = 94
- PS4_RightStick_DPadNorth = 91
- PS4_RightStick_DPadSouth = 92
- PS4_RightStick_DPadWest = 93
- PS4_RightStick_Move = 89
- PS4_RightTrigger_Click = 82
- PS4_RightTrigger_Pull = 81
- PS4_Share = 57
- PS4_Square = 53
- PS4_Triangle = 52
- PS4_X = 50
- SteamController_A = 1
- SteamController_B = 2
- SteamController_Back = 10
- SteamController_Gyro_Move = 35
- SteamController_Gyro_Pitch = 36
- SteamController_Gyro_Roll = 38
- SteamController_Gyro_Yaw = 37
- SteamController_LeftBumper = 5
- SteamController_LeftGrip = 7
- SteamController_LeftPad_Click = 13
- SteamController_LeftPad_DPadEast = 17
- SteamController_LeftPad_DPadNorth = 14
- SteamController_LeftPad_DPadSouth = 15
- SteamController_LeftPad_DPadWest = 16
- SteamController_LeftPad_Swipe = 12
- SteamController_LeftPad_Touch = 11
- SteamController_LeftStick_Click = 30
- SteamController_LeftStick_DPadEast = 34
- SteamController_LeftStick_DPadNorth = 31
- SteamController_LeftStick_DPadSouth = 32
- SteamController_LeftStick_DPadWest = 33
- SteamController_LeftStick_Move = 29
- SteamController_LeftTrigger_Click = 26
- SteamController_LeftTrigger_Pull = 25
- SteamController_Reserved0 = 39
- SteamController_Reserved1 = 40
- SteamController_Reserved10 = 49
- SteamController_Reserved2 = 41
- SteamController_Reserved3 = 42
- SteamController_Reserved4 = 43
- SteamController_Reserved5 = 44
- SteamController_Reserved6 = 45
- SteamController_Reserved7 = 46
- SteamController_Reserved8 = 47
- SteamController_Reserved9 = 48
- SteamController_RightBumper = 6
- SteamController_RightGrip = 8
- SteamController_RightPad_Click = 20
- SteamController_RightPad_DPadEast = 24
- SteamController_RightPad_DPadNorth = 21
- SteamController_RightPad_DPadSouth = 22
- SteamController_RightPad_DPadWest = 23
- SteamController_RightPad_Swipe = 19
- SteamController_RightPad_Touch = 18
- SteamController_RightTrigger_Click = 28
- SteamController_RightTrigger_Pull = 27
- SteamController_Start = 9
- SteamController_X = 3
- SteamController_Y = 4
- Switch_A = 192
- Switch_B = 193
- Switch_Capture = 200
- Switch_DPad_East = 220
- Switch_DPad_Move = 225
- Switch_DPad_North = 217
- Switch_DPad_South = 218
- Switch_DPad_West = 219
- Switch_LeftBumper = 196
- Switch_LeftGrip_Lower = 244
- Switch_LeftGrip_Upper = 245
- Switch_LeftGyro_Move = 240
- Switch_LeftGyro_Pitch = 241
- Switch_LeftGyro_Roll = 243
- Switch_LeftGyro_Yaw = 242
- Switch_LeftStick_Click = 206
- Switch_LeftStick_DPadEast = 210
- Switch_LeftStick_DPadNorth = 207
- Switch_LeftStick_DPadSouth = 208
- Switch_LeftStick_DPadWest = 209
- Switch_LeftStick_Move = 205
- Switch_LeftTrigger_Click = 202
- Switch_LeftTrigger_Pull = 201
- Switch_Minus = 199
- Switch_Plus = 198
- Switch_ProGyro_Move = 221
- Switch_ProGyro_Pitch = 222
- Switch_ProGyro_Roll = 224
- Switch_ProGyro_Yaw = 223
- Switch_Reserved1 = 226
- Switch_Reserved10 = 235
- Switch_Reserved11 = 248
- Switch_Reserved12 = 249
- Switch_Reserved13 = 250
- Switch_Reserved14 = 251
- Switch_Reserved15 = 252
- Switch_Reserved16 = 253
- Switch_Reserved17 = 254
- Switch_Reserved18 = 255
- Switch_Reserved19 = 256
- Switch_Reserved2 = 227
- Switch_Reserved20 = 257
- Switch_Reserved3 = 228
- Switch_Reserved4 = 229
- Switch_Reserved5 = 230
- Switch_Reserved6 = 231
- Switch_Reserved7 = 232
- Switch_Reserved8 = 233
- Switch_Reserved9 = 234
- Switch_RightBumper = 197
- Switch_RightGrip_Lower = 246
- Switch_RightGrip_Upper = 247
- Switch_RightGyro_Move = 236
- Switch_RightGyro_Pitch = 237
- Switch_RightGyro_Roll = 239
- Switch_RightGyro_Yaw = 238
- Switch_RightStick_Click = 212
- Switch_RightStick_DPadEast = 216
- Switch_RightStick_DPadNorth = 213
- Switch_RightStick_DPadSouth = 214
- Switch_RightStick_DPadWest = 215
- Switch_RightStick_Move = 211
- Switch_RightTrigger_Click = 204
- Switch_RightTrigger_Pull = 203
- Switch_X = 194
- Switch_Y = 195
- XBox360_A = 153
- XBox360_B = 154
- XBox360_Back = 160
- XBox360_DPad_East = 180
- XBox360_DPad_Move = 181
- XBox360_DPad_North = 177
- XBox360_DPad_South = 178
- XBox360_DPad_West = 179
- XBox360_LeftBumper = 157
- XBox360_LeftStick_Click = 166
- XBox360_LeftStick_DPadEast = 170
- XBox360_LeftStick_DPadNorth = 167
- XBox360_LeftStick_DPadSouth = 168
- XBox360_LeftStick_DPadWest = 169
- XBox360_LeftStick_Move = 165
- XBox360_LeftTrigger_Click = 162
- XBox360_LeftTrigger_Pull = 161
- XBox360_Reserved1 = 182
- XBox360_Reserved10 = 191
- XBox360_Reserved2 = 183
- XBox360_Reserved3 = 184
- XBox360_Reserved4 = 185
- XBox360_Reserved5 = 186
- XBox360_Reserved6 = 187
- XBox360_Reserved7 = 188
- XBox360_Reserved8 = 189
- XBox360_Reserved9 = 190
- XBox360_RightBumper = 158
- XBox360_RightStick_Click = 172
- XBox360_RightStick_DPadEast = 176
- XBox360_RightStick_DPadNorth = 173
- XBox360_RightStick_DPadSouth = 174
- XBox360_RightStick_DPadWest = 175
- XBox360_RightStick_Move = 171
- XBox360_RightTrigger_Click = 164
- XBox360_RightTrigger_Pull = 163
- XBox360_Start = 159
- XBox360_X = 155
- XBox360_Y = 156
- XBoxOne_A = 114
- XBoxOne_B = 115
- XBoxOne_DPad_East = 141
- XBoxOne_DPad_Move = 142
- XBoxOne_DPad_North = 138
- XBoxOne_DPad_South = 139
- XBoxOne_DPad_West = 140
- XBoxOne_LeftBumper = 118
- XBoxOne_LeftStick_Click = 127
- XBoxOne_LeftStick_DPadEast = 131
- XBoxOne_LeftStick_DPadNorth = 128
- XBoxOne_LeftStick_DPadSouth = 129
- XBoxOne_LeftStick_DPadWest = 130
- XBoxOne_LeftStick_Move = 126
- XBoxOne_LeftTrigger_Click = 123
- XBoxOne_LeftTrigger_Pull = 122
- XBoxOne_Menu = 120
- XBoxOne_Reserved1 = 143
- XBoxOne_Reserved10 = 152
- XBoxOne_Reserved2 = 144
- XBoxOne_Reserved3 = 145
- XBoxOne_Reserved4 = 146
- XBoxOne_Reserved5 = 147
- XBoxOne_Reserved6 = 148
- XBoxOne_Reserved7 = 149
- XBoxOne_Reserved8 = 150
- XBoxOne_Reserved9 = 151
- XBoxOne_RightBumper = 119
- XBoxOne_RightStick_Click = 133
- XBoxOne_RightStick_DPadEast = 137
- XBoxOne_RightStick_DPadNorth = 134
- XBoxOne_RightStick_DPadSouth = 135
- XBoxOne_RightStick_DPadWest = 136
- XBoxOne_RightStick_Move = 132
- XBoxOne_RightTrigger_Click = 125
- XBoxOne_RightTrigger_Pull = 124
- XBoxOne_View = 121
- XBoxOne_X = 116
- XBoxOne_Y = 117

### public enum Steamworks.InputSourceMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AbsoluteMouse = 4
- Buttons = 2
- Dpad = 1
- FourButtons = 3
- JoystickCamera = 8
- JoystickMouse = 7
- JoystickMove = 6
- MouseJoystick = 12
- MouseRegion = 13
- None = 0
- RadialMenu = 14
- RelativeMouse = 5
- ScrollWheel = 9
- SingleButton = 15
- Switches = 16
- TouchMenu = 11
- Trigger = 10

### public enum Steamworks.InputType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AndroidController = 7
- AppleMFiController = 6
- Count = 13
- GenericGamepad = 4
- MaximumPossibleValue = 255
- MobileTouch = 11
- PS3Controller = 12
- PS4Controller = 5
- SteamController = 1
- SwitchJoyConPair = 8
- SwitchJoyConSingle = 9
- SwitchProController = 10
- Unknown = 0
- XBox360Controller = 2
- XBoxOneController = 3

### public class Steamworks.InventoryDef
- Interfaces: System.IEquatable<Steamworks.InventoryDef>

#### Fields
- internal Steamworks.Data.InventoryDefId _id
- internal System.Collections.Generic.Dictionary<string, string> _properties
- private Steamworks.InventoryRecipe[] _recContaining

#### Properties
- public System.DateTime Created { get; }
- public string Description { get; }
- public string ExchangeSchema { get; }
- public string IconUrl { get; }
- public string IconUrlLarge { get; }
- public int Id { get; }
- public bool IsGenerator { get; }
- public int LocalBasePrice { get; }
- public string LocalBasePriceFormatted { get; }
- public int LocalPrice { get; }
- public string LocalPriceFormatted { get; }
- public bool Marketable { get; }
- public System.DateTime Modified { get; }
- public string Name { get; }
- public string PriceCategory { get; }
- public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> Properties { get; }
- public bool Tradable { get; }
- public string Type { get; }

#### Constructors
- public InventoryDef(Steamworks.Data.InventoryDefId defId)

#### Methods
- private Steamworks.InventoryRecipe <GetRecipes>b__21_0(string x)
- private bool <GetRecipesContainingThis>b__44_3(Steamworks.InventoryRecipe x)
- public override bool Equals(object p)
- public bool Equals(Steamworks.InventoryDef p)
- public bool GetBoolProperty(string name)
- public override int GetHashCode()
- public string GetProperty(string name)
- public T GetProperty<T>(string name)
- public Steamworks.InventoryRecipe[] GetRecipes()
- public Steamworks.InventoryRecipe[] GetRecipesContainingThis()
- public static bool op_Equality(Steamworks.InventoryDef a, Steamworks.InventoryDef b)
- public static bool op_Inequality(Steamworks.InventoryDef a, Steamworks.InventoryDef b)

### public struct Steamworks.InventoryItem
- Interfaces: System.IEquatable<Steamworks.InventoryItem>

#### Fields
- internal Steamworks.Data.InventoryDefId _def
- internal Steamworks.SteamItemFlags _flags
- internal Steamworks.Data.InventoryItemId _id
- internal System.Collections.Generic.Dictionary<string, string> _properties
- internal ushort _quantity

#### Properties
- public System.DateTime Acquired { get; }
- public Steamworks.InventoryDef Def { get; }
- public Steamworks.Data.InventoryDefId DefId { get; }
- public Steamworks.Data.InventoryItemId Id { get; }
- public bool IsConsumed { get; }
- public bool IsNoTrade { get; }
- public bool IsRemoved { get; }
- public string Origin { get; }
- public System.Collections.Generic.Dictionary<string, string> Properties { get; }
- public int Quantity { get; }

#### Methods
- public System.Threading.Tasks.Task<System.Nullable<Steamworks.InventoryResult>> AddAsync(Steamworks.InventoryItem add, int quantity = 1)
- public System.Threading.Tasks.Task<System.Nullable<Steamworks.InventoryResult>> ConsumeAsync(int amount = 1)
- public override bool Equals(object p)
- public bool Equals(Steamworks.InventoryItem p)
- internal static Steamworks.InventoryItem From(Steamworks.Data.SteamItemDetails_t details)
- public override int GetHashCode()
- internal static System.Collections.Generic.Dictionary<string, string> GetProperties(Steamworks.Data.SteamInventoryResult_t result, int index)
- public static bool op_Equality(Steamworks.InventoryItem a, Steamworks.InventoryItem b)
- public static bool op_Inequality(Steamworks.InventoryItem a, Steamworks.InventoryItem b)
- public System.Threading.Tasks.Task<System.Nullable<Steamworks.InventoryResult>> SplitStackAsync(int quantity = 1)

### public struct Steamworks.InventoryRecipe
- Interfaces: System.IEquatable<Steamworks.InventoryRecipe>

#### Fields
- public Steamworks.InventoryRecipe.Ingredient[] Ingredients
- public Steamworks.InventoryDef Result
- public string Source

#### Methods
- internal bool ContainsIngredient(Steamworks.InventoryDef inventoryDef)
- public override bool Equals(object p)
- public bool Equals(Steamworks.InventoryRecipe p)
- internal static Steamworks.InventoryRecipe FromString(string part, Steamworks.InventoryDef Result)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.InventoryRecipe a, Steamworks.InventoryRecipe b)
- public static bool op_Inequality(Steamworks.InventoryRecipe a, Steamworks.InventoryRecipe b)

### public struct Steamworks.InventoryResult
- Interfaces: System.IDisposable

#### Fields
- private bool <Expired>k__BackingField
- internal Steamworks.Data.SteamInventoryResult_t _id

#### Properties
- public bool Expired { get; internal set; }
- public int ItemCount { get; }

#### Constructors
- internal InventoryResult(Steamworks.Data.SteamInventoryResult_t id, bool expired)

#### Methods
- public bool BelongsTo(Steamworks.SteamId steamId)
- public void Dispose()
- internal static System.Threading.Tasks.Task<System.Nullable<Steamworks.InventoryResult>> GetAsync(Steamworks.Data.SteamInventoryResult_t sresult)
- public Steamworks.InventoryItem[] GetItems(bool includeProperties = false)
- public byte[] Serialize()

### public interface Steamworks.ISocketManager

#### Methods
- public void OnConnected(Steamworks.Data.Connection connection, Steamworks.Data.ConnectionInfo info)
- public void OnConnecting(Steamworks.Data.Connection connection, Steamworks.Data.ConnectionInfo info)
- public void OnDisconnected(Steamworks.Data.Connection connection, Steamworks.Data.ConnectionInfo info)
- public void OnMessage(Steamworks.Data.Connection connection, Steamworks.Data.NetIdentity identity, System.IntPtr data, int size, long messageNum, long recvTime, int channel)

### internal class Steamworks.ISteamAppList
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamAppList(bool IsGameServer)

#### Methods
- internal int GetAppBuildId(Steamworks.AppId nAppID)
- internal int GetAppInstallDir(Steamworks.AppId nAppID, out string pchDirectory)
- internal int GetAppName(Steamworks.AppId nAppID, out string pchName)
- internal uint GetInstalledApps(Steamworks.AppId[] pvecAppID, uint unMaxAppIDs)
- internal uint GetNumInstalledApps()
- public override System.IntPtr GetUserInterfacePointer()
- internal static System.IntPtr SteamAPI_SteamAppList_v001()
- private static int _GetAppBuildId(System.IntPtr self, Steamworks.AppId nAppID)
- private static int _GetAppInstallDir(System.IntPtr self, Steamworks.AppId nAppID, System.IntPtr pchDirectory, int cchNameMax)
- private static int _GetAppName(System.IntPtr self, Steamworks.AppId nAppID, System.IntPtr pchName, int cchNameMax)
- private static uint _GetInstalledApps(System.IntPtr self, Steamworks.AppId[] pvecAppID, uint unMaxAppIDs)
- private static uint _GetNumInstalledApps(System.IntPtr self)

### internal class Steamworks.ISteamApps
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamApps(bool IsGameServer)

#### Methods
- internal bool BGetDLCDataByIndex(int iDLC, ref Steamworks.AppId pAppID, ref bool pbAvailable, out string pchName)
- internal bool BIsAppInstalled(Steamworks.AppId appID)
- internal bool BIsCybercafe()
- internal bool BIsDlcInstalled(Steamworks.AppId appID)
- internal bool BIsLowViolence()
- internal bool BIsSubscribed()
- internal bool BIsSubscribedApp(Steamworks.AppId appID)
- internal bool BIsSubscribedFromFamilySharing()
- internal bool BIsSubscribedFromFreeWeekend()
- internal bool BIsVACBanned()
- internal int GetAppBuildId()
- internal uint GetAppInstallDir(Steamworks.AppId appID, out string pchFolder)
- internal Steamworks.SteamId GetAppOwner()
- internal string GetAvailableGameLanguages()
- internal bool GetCurrentBetaName(out string pchName)
- internal string GetCurrentGameLanguage()
- internal int GetDLCCount()
- internal bool GetDlcDownloadProgress(Steamworks.AppId nAppID, ref ulong punBytesDownloaded, ref ulong punBytesTotal)
- internal uint GetEarliestPurchaseUnixTime(Steamworks.AppId nAppID)
- internal Steamworks.CallResult<Steamworks.Data.FileDetailsResult_t> GetFileDetails(string pszFileName)
- internal uint GetInstalledDepots(Steamworks.AppId appID, Steamworks.Data.DepotId_t[] pvecDepots, uint cMaxDepots)
- internal int GetLaunchCommandLine(out string pszCommandLine)
- internal string GetLaunchQueryParam(string pchKey)
- public override System.IntPtr GetServerInterfacePointer()
- public override System.IntPtr GetUserInterfacePointer()
- internal void InstallDLC(Steamworks.AppId nAppID)
- internal bool MarkContentCorrupt(bool bMissingFilesOnly)
- internal void RequestAllProofOfPurchaseKeys()
- internal void RequestAppProofOfPurchaseKey(Steamworks.AppId nAppID)
- internal static System.IntPtr SteamAPI_SteamApps_v008()
- internal static System.IntPtr SteamAPI_SteamGameServerApps_v008()
- internal void UninstallDLC(Steamworks.AppId nAppID)
- private static bool _BGetDLCDataByIndex(System.IntPtr self, int iDLC, ref Steamworks.AppId pAppID, ref bool pbAvailable, System.IntPtr pchName, int cchNameBufferSize)
- private static bool _BIsAppInstalled(System.IntPtr self, Steamworks.AppId appID)
- private static bool _BIsCybercafe(System.IntPtr self)
- private static bool _BIsDlcInstalled(System.IntPtr self, Steamworks.AppId appID)
- private static bool _BIsLowViolence(System.IntPtr self)
- private static bool _BIsSubscribed(System.IntPtr self)
- private static bool _BIsSubscribedApp(System.IntPtr self, Steamworks.AppId appID)
- private static bool _BIsSubscribedFromFamilySharing(System.IntPtr self)
- private static bool _BIsSubscribedFromFreeWeekend(System.IntPtr self)
- private static bool _BIsVACBanned(System.IntPtr self)
- private static int _GetAppBuildId(System.IntPtr self)
- private static uint _GetAppInstallDir(System.IntPtr self, Steamworks.AppId appID, System.IntPtr pchFolder, uint cchFolderBufferSize)
- private static Steamworks.SteamId _GetAppOwner(System.IntPtr self)
- private static Steamworks.Utf8StringPointer _GetAvailableGameLanguages(System.IntPtr self)
- private static bool _GetCurrentBetaName(System.IntPtr self, System.IntPtr pchName, int cchNameBufferSize)
- private static Steamworks.Utf8StringPointer _GetCurrentGameLanguage(System.IntPtr self)
- private static int _GetDLCCount(System.IntPtr self)
- private static bool _GetDlcDownloadProgress(System.IntPtr self, Steamworks.AppId nAppID, ref ulong punBytesDownloaded, ref ulong punBytesTotal)
- private static uint _GetEarliestPurchaseUnixTime(System.IntPtr self, Steamworks.AppId nAppID)
- private static Steamworks.Data.SteamAPICall_t _GetFileDetails(System.IntPtr self, string pszFileName)
- private static uint _GetInstalledDepots(System.IntPtr self, Steamworks.AppId appID, Steamworks.Data.DepotId_t[] pvecDepots, uint cMaxDepots)
- private static int _GetLaunchCommandLine(System.IntPtr self, System.IntPtr pszCommandLine, int cubCommandLine)
- private static Steamworks.Utf8StringPointer _GetLaunchQueryParam(System.IntPtr self, string pchKey)
- private static void _InstallDLC(System.IntPtr self, Steamworks.AppId nAppID)
- private static bool _MarkContentCorrupt(System.IntPtr self, bool bMissingFilesOnly)
- private static void _RequestAllProofOfPurchaseKeys(System.IntPtr self)
- private static void _RequestAppProofOfPurchaseKey(System.IntPtr self, Steamworks.AppId nAppID)
- private static void _UninstallDLC(System.IntPtr self, Steamworks.AppId nAppID)

### internal class Steamworks.ISteamClient
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamClient(bool IsGameServer)

#### Methods
- internal bool BReleaseSteamPipe(Steamworks.Data.HSteamPipe hSteamPipe)
- internal bool BShutdownIfAllPipesClosed()
- internal Steamworks.Data.HSteamUser ConnectToGlobalUser(Steamworks.Data.HSteamPipe hSteamPipe)
- internal Steamworks.Data.HSteamUser CreateLocalUser(ref Steamworks.Data.HSteamPipe phSteamPipe, Steamworks.AccountType eAccountType)
- internal Steamworks.Data.HSteamPipe CreateSteamPipe()
- internal uint GetIPCCallCount()
- internal System.IntPtr GetISteamAppList(Steamworks.Data.HSteamUser hSteamUser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- internal System.IntPtr GetISteamApps(Steamworks.Data.HSteamUser hSteamUser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- internal System.IntPtr GetISteamController(Steamworks.Data.HSteamUser hSteamUser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- internal System.IntPtr GetISteamFriends(Steamworks.Data.HSteamUser hSteamUser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- internal System.IntPtr GetISteamGameSearch(Steamworks.Data.HSteamUser hSteamuser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- internal System.IntPtr GetISteamGameServer(Steamworks.Data.HSteamUser hSteamUser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- internal System.IntPtr GetISteamGameServerStats(Steamworks.Data.HSteamUser hSteamuser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- internal System.IntPtr GetISteamGenericInterface(Steamworks.Data.HSteamUser hSteamUser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- internal System.IntPtr GetISteamHTMLSurface(Steamworks.Data.HSteamUser hSteamuser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- internal System.IntPtr GetISteamHTTP(Steamworks.Data.HSteamUser hSteamuser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- internal System.IntPtr GetISteamInput(Steamworks.Data.HSteamUser hSteamUser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- internal System.IntPtr GetISteamInventory(Steamworks.Data.HSteamUser hSteamuser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- internal System.IntPtr GetISteamMatchmaking(Steamworks.Data.HSteamUser hSteamUser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- internal System.IntPtr GetISteamMatchmakingServers(Steamworks.Data.HSteamUser hSteamUser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- internal System.IntPtr GetISteamMusic(Steamworks.Data.HSteamUser hSteamuser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- internal System.IntPtr GetISteamMusicRemote(Steamworks.Data.HSteamUser hSteamuser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- internal System.IntPtr GetISteamNetworking(Steamworks.Data.HSteamUser hSteamUser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- internal System.IntPtr GetISteamParentalSettings(Steamworks.Data.HSteamUser hSteamuser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- internal System.IntPtr GetISteamParties(Steamworks.Data.HSteamUser hSteamUser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- internal System.IntPtr GetISteamRemotePlay(Steamworks.Data.HSteamUser hSteamUser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- internal System.IntPtr GetISteamRemoteStorage(Steamworks.Data.HSteamUser hSteamuser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- internal System.IntPtr GetISteamScreenshots(Steamworks.Data.HSteamUser hSteamuser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- internal System.IntPtr GetISteamUGC(Steamworks.Data.HSteamUser hSteamUser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- internal System.IntPtr GetISteamUser(Steamworks.Data.HSteamUser hSteamUser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- internal System.IntPtr GetISteamUserStats(Steamworks.Data.HSteamUser hSteamUser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- internal System.IntPtr GetISteamUtils(Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- internal System.IntPtr GetISteamVideo(Steamworks.Data.HSteamUser hSteamuser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- internal void ReleaseUser(Steamworks.Data.HSteamPipe hSteamPipe, Steamworks.Data.HSteamUser hUser)
- internal void SetLocalIPBinding(ref Steamworks.Data.SteamIPAddress unIP, ushort usPort)
- internal void SetWarningMessageHook(System.IntPtr pFunction)
- private static bool _BReleaseSteamPipe(System.IntPtr self, Steamworks.Data.HSteamPipe hSteamPipe)
- private static bool _BShutdownIfAllPipesClosed(System.IntPtr self)
- private static Steamworks.Data.HSteamUser _ConnectToGlobalUser(System.IntPtr self, Steamworks.Data.HSteamPipe hSteamPipe)
- private static Steamworks.Data.HSteamUser _CreateLocalUser(System.IntPtr self, ref Steamworks.Data.HSteamPipe phSteamPipe, Steamworks.AccountType eAccountType)
- private static Steamworks.Data.HSteamPipe _CreateSteamPipe(System.IntPtr self)
- private static uint _GetIPCCallCount(System.IntPtr self)
- private static System.IntPtr _GetISteamAppList(System.IntPtr self, Steamworks.Data.HSteamUser hSteamUser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- private static System.IntPtr _GetISteamApps(System.IntPtr self, Steamworks.Data.HSteamUser hSteamUser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- private static System.IntPtr _GetISteamController(System.IntPtr self, Steamworks.Data.HSteamUser hSteamUser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- private static System.IntPtr _GetISteamFriends(System.IntPtr self, Steamworks.Data.HSteamUser hSteamUser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- private static System.IntPtr _GetISteamGameSearch(System.IntPtr self, Steamworks.Data.HSteamUser hSteamuser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- private static System.IntPtr _GetISteamGameServer(System.IntPtr self, Steamworks.Data.HSteamUser hSteamUser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- private static System.IntPtr _GetISteamGameServerStats(System.IntPtr self, Steamworks.Data.HSteamUser hSteamuser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- private static System.IntPtr _GetISteamGenericInterface(System.IntPtr self, Steamworks.Data.HSteamUser hSteamUser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- private static System.IntPtr _GetISteamHTMLSurface(System.IntPtr self, Steamworks.Data.HSteamUser hSteamuser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- private static System.IntPtr _GetISteamHTTP(System.IntPtr self, Steamworks.Data.HSteamUser hSteamuser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- private static System.IntPtr _GetISteamInput(System.IntPtr self, Steamworks.Data.HSteamUser hSteamUser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- private static System.IntPtr _GetISteamInventory(System.IntPtr self, Steamworks.Data.HSteamUser hSteamuser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- private static System.IntPtr _GetISteamMatchmaking(System.IntPtr self, Steamworks.Data.HSteamUser hSteamUser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- private static System.IntPtr _GetISteamMatchmakingServers(System.IntPtr self, Steamworks.Data.HSteamUser hSteamUser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- private static System.IntPtr _GetISteamMusic(System.IntPtr self, Steamworks.Data.HSteamUser hSteamuser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- private static System.IntPtr _GetISteamMusicRemote(System.IntPtr self, Steamworks.Data.HSteamUser hSteamuser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- private static System.IntPtr _GetISteamNetworking(System.IntPtr self, Steamworks.Data.HSteamUser hSteamUser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- private static System.IntPtr _GetISteamParentalSettings(System.IntPtr self, Steamworks.Data.HSteamUser hSteamuser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- private static System.IntPtr _GetISteamParties(System.IntPtr self, Steamworks.Data.HSteamUser hSteamUser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- private static System.IntPtr _GetISteamRemotePlay(System.IntPtr self, Steamworks.Data.HSteamUser hSteamUser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- private static System.IntPtr _GetISteamRemoteStorage(System.IntPtr self, Steamworks.Data.HSteamUser hSteamuser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- private static System.IntPtr _GetISteamScreenshots(System.IntPtr self, Steamworks.Data.HSteamUser hSteamuser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- private static System.IntPtr _GetISteamUGC(System.IntPtr self, Steamworks.Data.HSteamUser hSteamUser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- private static System.IntPtr _GetISteamUser(System.IntPtr self, Steamworks.Data.HSteamUser hSteamUser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- private static System.IntPtr _GetISteamUserStats(System.IntPtr self, Steamworks.Data.HSteamUser hSteamUser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- private static System.IntPtr _GetISteamUtils(System.IntPtr self, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- private static System.IntPtr _GetISteamVideo(System.IntPtr self, Steamworks.Data.HSteamUser hSteamuser, Steamworks.Data.HSteamPipe hSteamPipe, string pchVersion)
- private static void _ReleaseUser(System.IntPtr self, Steamworks.Data.HSteamPipe hSteamPipe, Steamworks.Data.HSteamUser hUser)
- private static void _SetLocalIPBinding(System.IntPtr self, ref Steamworks.Data.SteamIPAddress unIP, ushort usPort)
- private static void _SetWarningMessageHook(System.IntPtr self, System.IntPtr pFunction)

### internal class Steamworks.ISteamController
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamController(bool IsGameServer)

#### Methods
- internal void ActivateActionSet(Steamworks.Data.ControllerHandle_t controllerHandle, Steamworks.Data.ControllerActionSetHandle_t actionSetHandle)
- internal void ActivateActionSetLayer(Steamworks.Data.ControllerHandle_t controllerHandle, Steamworks.Data.ControllerActionSetHandle_t actionSetLayerHandle)
- internal void DeactivateActionSetLayer(Steamworks.Data.ControllerHandle_t controllerHandle, Steamworks.Data.ControllerActionSetHandle_t actionSetLayerHandle)
- internal void DeactivateAllActionSetLayers(Steamworks.Data.ControllerHandle_t controllerHandle)
- internal Steamworks.ControllerActionOrigin GetActionOriginFromXboxOrigin(Steamworks.Data.ControllerHandle_t controllerHandle, Steamworks.XboxOrigin eOrigin)
- internal Steamworks.Data.ControllerActionSetHandle_t GetActionSetHandle(string pszActionSetName)
- internal int GetActiveActionSetLayers(Steamworks.Data.ControllerHandle_t controllerHandle, Steamworks.Data.ControllerActionSetHandle_t[] handlesOut)
- internal Steamworks.AnalogState GetAnalogActionData(Steamworks.Data.ControllerHandle_t controllerHandle, Steamworks.Data.ControllerAnalogActionHandle_t analogActionHandle)
- internal Steamworks.Data.ControllerAnalogActionHandle_t GetAnalogActionHandle(string pszActionName)
- internal int GetAnalogActionOrigins(Steamworks.Data.ControllerHandle_t controllerHandle, Steamworks.Data.ControllerActionSetHandle_t actionSetHandle, Steamworks.Data.ControllerAnalogActionHandle_t analogActionHandle, ref Steamworks.ControllerActionOrigin originsOut)
- internal int GetConnectedControllers(Steamworks.Data.ControllerHandle_t[] handlesOut)
- internal bool GetControllerBindingRevision(Steamworks.Data.ControllerHandle_t controllerHandle, ref int pMajor, ref int pMinor)
- internal Steamworks.Data.ControllerHandle_t GetControllerForGamepadIndex(int nIndex)
- internal Steamworks.Data.ControllerActionSetHandle_t GetCurrentActionSet(Steamworks.Data.ControllerHandle_t controllerHandle)
- internal Steamworks.DigitalState GetDigitalActionData(Steamworks.Data.ControllerHandle_t controllerHandle, Steamworks.Data.ControllerDigitalActionHandle_t digitalActionHandle)
- internal Steamworks.Data.ControllerDigitalActionHandle_t GetDigitalActionHandle(string pszActionName)
- internal int GetDigitalActionOrigins(Steamworks.Data.ControllerHandle_t controllerHandle, Steamworks.Data.ControllerActionSetHandle_t actionSetHandle, Steamworks.Data.ControllerDigitalActionHandle_t digitalActionHandle, ref Steamworks.ControllerActionOrigin originsOut)
- internal int GetGamepadIndexForController(Steamworks.Data.ControllerHandle_t ulControllerHandle)
- internal string GetGlyphForActionOrigin(Steamworks.ControllerActionOrigin eOrigin)
- internal string GetGlyphForXboxOrigin(Steamworks.XboxOrigin eOrigin)
- internal Steamworks.InputType GetInputTypeForHandle(Steamworks.Data.ControllerHandle_t controllerHandle)
- internal Steamworks.MotionState GetMotionData(Steamworks.Data.ControllerHandle_t controllerHandle)
- internal string GetStringForActionOrigin(Steamworks.ControllerActionOrigin eOrigin)
- internal string GetStringForXboxOrigin(Steamworks.XboxOrigin eOrigin)
- public override System.IntPtr GetUserInterfacePointer()
- internal bool Init()
- internal void RunFrame()
- internal void SetLEDColor(Steamworks.Data.ControllerHandle_t controllerHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags)
- internal bool ShowBindingPanel(Steamworks.Data.ControllerHandle_t controllerHandle)
- internal bool Shutdown()
- internal static System.IntPtr SteamAPI_SteamController_v007()
- internal void StopAnalogActionMomentum(Steamworks.Data.ControllerHandle_t controllerHandle, Steamworks.Data.ControllerAnalogActionHandle_t eAction)
- internal Steamworks.ControllerActionOrigin TranslateActionOrigin(Steamworks.InputType eDestinationInputType, Steamworks.ControllerActionOrigin eSourceOrigin)
- internal void TriggerHapticPulse(Steamworks.Data.ControllerHandle_t controllerHandle, Steamworks.SteamControllerPad eTargetPad, ushort usDurationMicroSec)
- internal void TriggerRepeatedHapticPulse(Steamworks.Data.ControllerHandle_t controllerHandle, Steamworks.SteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags)
- internal void TriggerVibration(Steamworks.Data.ControllerHandle_t controllerHandle, ushort usLeftSpeed, ushort usRightSpeed)
- private static void _ActivateActionSet(System.IntPtr self, Steamworks.Data.ControllerHandle_t controllerHandle, Steamworks.Data.ControllerActionSetHandle_t actionSetHandle)
- private static void _ActivateActionSetLayer(System.IntPtr self, Steamworks.Data.ControllerHandle_t controllerHandle, Steamworks.Data.ControllerActionSetHandle_t actionSetLayerHandle)
- private static void _DeactivateActionSetLayer(System.IntPtr self, Steamworks.Data.ControllerHandle_t controllerHandle, Steamworks.Data.ControllerActionSetHandle_t actionSetLayerHandle)
- private static void _DeactivateAllActionSetLayers(System.IntPtr self, Steamworks.Data.ControllerHandle_t controllerHandle)
- private static Steamworks.ControllerActionOrigin _GetActionOriginFromXboxOrigin(System.IntPtr self, Steamworks.Data.ControllerHandle_t controllerHandle, Steamworks.XboxOrigin eOrigin)
- private static Steamworks.Data.ControllerActionSetHandle_t _GetActionSetHandle(System.IntPtr self, string pszActionSetName)
- private static int _GetActiveActionSetLayers(System.IntPtr self, Steamworks.Data.ControllerHandle_t controllerHandle, Steamworks.Data.ControllerActionSetHandle_t[] handlesOut)
- private static Steamworks.AnalogState _GetAnalogActionData(System.IntPtr self, Steamworks.Data.ControllerHandle_t controllerHandle, Steamworks.Data.ControllerAnalogActionHandle_t analogActionHandle)
- private static Steamworks.Data.ControllerAnalogActionHandle_t _GetAnalogActionHandle(System.IntPtr self, string pszActionName)
- private static int _GetAnalogActionOrigins(System.IntPtr self, Steamworks.Data.ControllerHandle_t controllerHandle, Steamworks.Data.ControllerActionSetHandle_t actionSetHandle, Steamworks.Data.ControllerAnalogActionHandle_t analogActionHandle, ref Steamworks.ControllerActionOrigin originsOut)
- private static int _GetConnectedControllers(System.IntPtr self, Steamworks.Data.ControllerHandle_t[] handlesOut)
- private static bool _GetControllerBindingRevision(System.IntPtr self, Steamworks.Data.ControllerHandle_t controllerHandle, ref int pMajor, ref int pMinor)
- private static Steamworks.Data.ControllerHandle_t _GetControllerForGamepadIndex(System.IntPtr self, int nIndex)
- private static Steamworks.Data.ControllerActionSetHandle_t _GetCurrentActionSet(System.IntPtr self, Steamworks.Data.ControllerHandle_t controllerHandle)
- private static Steamworks.DigitalState _GetDigitalActionData(System.IntPtr self, Steamworks.Data.ControllerHandle_t controllerHandle, Steamworks.Data.ControllerDigitalActionHandle_t digitalActionHandle)
- private static Steamworks.Data.ControllerDigitalActionHandle_t _GetDigitalActionHandle(System.IntPtr self, string pszActionName)
- private static int _GetDigitalActionOrigins(System.IntPtr self, Steamworks.Data.ControllerHandle_t controllerHandle, Steamworks.Data.ControllerActionSetHandle_t actionSetHandle, Steamworks.Data.ControllerDigitalActionHandle_t digitalActionHandle, ref Steamworks.ControllerActionOrigin originsOut)
- private static int _GetGamepadIndexForController(System.IntPtr self, Steamworks.Data.ControllerHandle_t ulControllerHandle)
- private static Steamworks.Utf8StringPointer _GetGlyphForActionOrigin(System.IntPtr self, Steamworks.ControllerActionOrigin eOrigin)
- private static Steamworks.Utf8StringPointer _GetGlyphForXboxOrigin(System.IntPtr self, Steamworks.XboxOrigin eOrigin)
- private static Steamworks.InputType _GetInputTypeForHandle(System.IntPtr self, Steamworks.Data.ControllerHandle_t controllerHandle)
- private static Steamworks.MotionState _GetMotionData(System.IntPtr self, Steamworks.Data.ControllerHandle_t controllerHandle)
- private static Steamworks.Utf8StringPointer _GetStringForActionOrigin(System.IntPtr self, Steamworks.ControllerActionOrigin eOrigin)
- private static Steamworks.Utf8StringPointer _GetStringForXboxOrigin(System.IntPtr self, Steamworks.XboxOrigin eOrigin)
- private static bool _Init(System.IntPtr self)
- private static void _RunFrame(System.IntPtr self)
- private static void _SetLEDColor(System.IntPtr self, Steamworks.Data.ControllerHandle_t controllerHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags)
- private static bool _ShowBindingPanel(System.IntPtr self, Steamworks.Data.ControllerHandle_t controllerHandle)
- private static bool _Shutdown(System.IntPtr self)
- private static void _StopAnalogActionMomentum(System.IntPtr self, Steamworks.Data.ControllerHandle_t controllerHandle, Steamworks.Data.ControllerAnalogActionHandle_t eAction)
- private static Steamworks.ControllerActionOrigin _TranslateActionOrigin(System.IntPtr self, Steamworks.InputType eDestinationInputType, Steamworks.ControllerActionOrigin eSourceOrigin)
- private static void _TriggerHapticPulse(System.IntPtr self, Steamworks.Data.ControllerHandle_t controllerHandle, Steamworks.SteamControllerPad eTargetPad, ushort usDurationMicroSec)
- private static void _TriggerRepeatedHapticPulse(System.IntPtr self, Steamworks.Data.ControllerHandle_t controllerHandle, Steamworks.SteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags)
- private static void _TriggerVibration(System.IntPtr self, Steamworks.Data.ControllerHandle_t controllerHandle, ushort usLeftSpeed, ushort usRightSpeed)

### internal class Steamworks.ISteamFriends
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamFriends(bool IsGameServer)

#### Methods
- internal void ActivateGameOverlay(string pchDialog)
- internal void ActivateGameOverlayInviteDialog(Steamworks.SteamId steamIDLobby)
- internal void ActivateGameOverlayRemotePlayTogetherInviteDialog(Steamworks.SteamId steamIDLobby)
- internal void ActivateGameOverlayToStore(Steamworks.AppId nAppID, Steamworks.OverlayToStoreFlag eFlag)
- internal void ActivateGameOverlayToUser(string pchDialog, Steamworks.SteamId steamID)
- internal void ActivateGameOverlayToWebPage(string pchURL, Steamworks.ActivateGameOverlayToWebPageMode eMode)
- internal void ClearRichPresence()
- internal bool CloseClanChatWindowInSteam(Steamworks.SteamId steamIDClanChat)
- internal Steamworks.CallResult<Steamworks.Data.DownloadClanActivityCountsResult_t> DownloadClanActivityCounts(Steamworks.SteamId[] psteamIDClans, int cClansToRequest)
- internal Steamworks.CallResult<Steamworks.Data.FriendsEnumerateFollowingList_t> EnumerateFollowingList(uint unStartIndex)
- internal Steamworks.SteamId GetChatMemberByIndex(Steamworks.SteamId steamIDClan, int iUser)
- internal bool GetClanActivityCounts(Steamworks.SteamId steamIDClan, ref int pnOnline, ref int pnInGame, ref int pnChatting)
- internal Steamworks.SteamId GetClanByIndex(int iClan)
- internal int GetClanChatMemberCount(Steamworks.SteamId steamIDClan)
- internal int GetClanChatMessage(Steamworks.SteamId steamIDClanChat, int iMessage, System.IntPtr prgchText, int cchTextMax, ref Steamworks.ChatEntryType peChatEntryType, ref Steamworks.SteamId psteamidChatter)
- internal int GetClanCount()
- internal string GetClanName(Steamworks.SteamId steamIDClan)
- internal Steamworks.SteamId GetClanOfficerByIndex(Steamworks.SteamId steamIDClan, int iOfficer)
- internal int GetClanOfficerCount(Steamworks.SteamId steamIDClan)
- internal Steamworks.SteamId GetClanOwner(Steamworks.SteamId steamIDClan)
- internal string GetClanTag(Steamworks.SteamId steamIDClan)
- internal Steamworks.SteamId GetCoplayFriend(int iCoplayFriend)
- internal int GetCoplayFriendCount()
- internal Steamworks.CallResult<Steamworks.Data.FriendsGetFollowerCount_t> GetFollowerCount(Steamworks.SteamId steamID)
- internal Steamworks.SteamId GetFriendByIndex(int iFriend, int iFriendFlags)
- internal Steamworks.AppId GetFriendCoplayGame(Steamworks.SteamId steamIDFriend)
- internal int GetFriendCoplayTime(Steamworks.SteamId steamIDFriend)
- internal int GetFriendCount(int iFriendFlags)
- internal int GetFriendCountFromSource(Steamworks.SteamId steamIDSource)
- internal Steamworks.SteamId GetFriendFromSourceByIndex(Steamworks.SteamId steamIDSource, int iFriend)
- internal bool GetFriendGamePlayed(Steamworks.SteamId steamIDFriend, ref Steamworks.Data.FriendGameInfo_t pFriendGameInfo)
- internal int GetFriendMessage(Steamworks.SteamId steamIDFriend, int iMessageID, System.IntPtr pvData, int cubData, ref Steamworks.ChatEntryType peChatEntryType)
- internal string GetFriendPersonaName(Steamworks.SteamId steamIDFriend)
- internal string GetFriendPersonaNameHistory(Steamworks.SteamId steamIDFriend, int iPersonaName)
- internal Steamworks.FriendState GetFriendPersonaState(Steamworks.SteamId steamIDFriend)
- internal Steamworks.Relationship GetFriendRelationship(Steamworks.SteamId steamIDFriend)
- internal string GetFriendRichPresence(Steamworks.SteamId steamIDFriend, string pchKey)
- internal string GetFriendRichPresenceKeyByIndex(Steamworks.SteamId steamIDFriend, int iKey)
- internal int GetFriendRichPresenceKeyCount(Steamworks.SteamId steamIDFriend)
- internal int GetFriendsGroupCount()
- internal Steamworks.Data.FriendsGroupID_t GetFriendsGroupIDByIndex(int iFG)
- internal int GetFriendsGroupMembersCount(Steamworks.Data.FriendsGroupID_t friendsGroupID)
- internal void GetFriendsGroupMembersList(Steamworks.Data.FriendsGroupID_t friendsGroupID, Steamworks.SteamId[] pOutSteamIDMembers, int nMembersCount)
- internal string GetFriendsGroupName(Steamworks.Data.FriendsGroupID_t friendsGroupID)
- internal int GetFriendSteamLevel(Steamworks.SteamId steamIDFriend)
- internal int GetLargeFriendAvatar(Steamworks.SteamId steamIDFriend)
- internal int GetMediumFriendAvatar(Steamworks.SteamId steamIDFriend)
- internal int GetNumChatsWithUnreadPriorityMessages()
- internal string GetPersonaName()
- internal Steamworks.FriendState GetPersonaState()
- internal string GetPlayerNickname(Steamworks.SteamId steamIDPlayer)
- internal int GetSmallFriendAvatar(Steamworks.SteamId steamIDFriend)
- public override System.IntPtr GetUserInterfacePointer()
- internal uint GetUserRestrictions()
- internal bool HasFriend(Steamworks.SteamId steamIDFriend, int iFriendFlags)
- internal bool InviteUserToGame(Steamworks.SteamId steamIDFriend, string pchConnectString)
- internal bool IsClanChatAdmin(Steamworks.SteamId steamIDClanChat, Steamworks.SteamId steamIDUser)
- internal bool IsClanChatWindowOpenInSteam(Steamworks.SteamId steamIDClanChat)
- internal bool IsClanOfficialGameGroup(Steamworks.SteamId steamIDClan)
- internal bool IsClanPublic(Steamworks.SteamId steamIDClan)
- internal Steamworks.CallResult<Steamworks.Data.FriendsIsFollowing_t> IsFollowing(Steamworks.SteamId steamID)
- internal bool IsUserInSource(Steamworks.SteamId steamIDUser, Steamworks.SteamId steamIDSource)
- internal Steamworks.CallResult<Steamworks.Data.JoinClanChatRoomCompletionResult_t> JoinClanChatRoom(Steamworks.SteamId steamIDClan)
- internal bool LeaveClanChatRoom(Steamworks.SteamId steamIDClan)
- internal bool OpenClanChatWindowInSteam(Steamworks.SteamId steamIDClanChat)
- internal bool ReplyToFriendMessage(Steamworks.SteamId steamIDFriend, string pchMsgToSend)
- internal Steamworks.CallResult<Steamworks.Data.ClanOfficerListResponse_t> RequestClanOfficerList(Steamworks.SteamId steamIDClan)
- internal void RequestFriendRichPresence(Steamworks.SteamId steamIDFriend)
- internal bool RequestUserInformation(Steamworks.SteamId steamIDUser, bool bRequireNameOnly)
- internal bool SendClanChatMessage(Steamworks.SteamId steamIDClanChat, string pchText)
- internal void SetInGameVoiceSpeaking(Steamworks.SteamId steamIDUser, bool bSpeaking)
- internal bool SetListenForFriendsMessages(bool bInterceptEnabled)
- internal Steamworks.CallResult<Steamworks.Data.SetPersonaNameResponse_t> SetPersonaName(string pchPersonaName)
- internal void SetPlayedWith(Steamworks.SteamId steamIDUserPlayedWith)
- internal bool SetRichPresence(string pchKey, string pchValue)
- internal static System.IntPtr SteamAPI_SteamFriends_v017()
- private static void _ActivateGameOverlay(System.IntPtr self, string pchDialog)
- private static void _ActivateGameOverlayInviteDialog(System.IntPtr self, Steamworks.SteamId steamIDLobby)
- private static void _ActivateGameOverlayRemotePlayTogetherInviteDialog(System.IntPtr self, Steamworks.SteamId steamIDLobby)
- private static void _ActivateGameOverlayToStore(System.IntPtr self, Steamworks.AppId nAppID, Steamworks.OverlayToStoreFlag eFlag)
- private static void _ActivateGameOverlayToUser(System.IntPtr self, string pchDialog, Steamworks.SteamId steamID)
- private static void _ActivateGameOverlayToWebPage(System.IntPtr self, string pchURL, Steamworks.ActivateGameOverlayToWebPageMode eMode)
- private static void _ClearRichPresence(System.IntPtr self)
- private static bool _CloseClanChatWindowInSteam(System.IntPtr self, Steamworks.SteamId steamIDClanChat)
- private static Steamworks.Data.SteamAPICall_t _DownloadClanActivityCounts(System.IntPtr self, Steamworks.SteamId[] psteamIDClans, int cClansToRequest)
- private static Steamworks.Data.SteamAPICall_t _EnumerateFollowingList(System.IntPtr self, uint unStartIndex)
- private static Steamworks.SteamId _GetChatMemberByIndex(System.IntPtr self, Steamworks.SteamId steamIDClan, int iUser)
- private static bool _GetClanActivityCounts(System.IntPtr self, Steamworks.SteamId steamIDClan, ref int pnOnline, ref int pnInGame, ref int pnChatting)
- private static Steamworks.SteamId _GetClanByIndex(System.IntPtr self, int iClan)
- private static int _GetClanChatMemberCount(System.IntPtr self, Steamworks.SteamId steamIDClan)
- private static int _GetClanChatMessage(System.IntPtr self, Steamworks.SteamId steamIDClanChat, int iMessage, System.IntPtr prgchText, int cchTextMax, ref Steamworks.ChatEntryType peChatEntryType, ref Steamworks.SteamId psteamidChatter)
- private static int _GetClanCount(System.IntPtr self)
- private static Steamworks.Utf8StringPointer _GetClanName(System.IntPtr self, Steamworks.SteamId steamIDClan)
- private static Steamworks.SteamId _GetClanOfficerByIndex(System.IntPtr self, Steamworks.SteamId steamIDClan, int iOfficer)
- private static int _GetClanOfficerCount(System.IntPtr self, Steamworks.SteamId steamIDClan)
- private static Steamworks.SteamId _GetClanOwner(System.IntPtr self, Steamworks.SteamId steamIDClan)
- private static Steamworks.Utf8StringPointer _GetClanTag(System.IntPtr self, Steamworks.SteamId steamIDClan)
- private static Steamworks.SteamId _GetCoplayFriend(System.IntPtr self, int iCoplayFriend)
- private static int _GetCoplayFriendCount(System.IntPtr self)
- private static Steamworks.Data.SteamAPICall_t _GetFollowerCount(System.IntPtr self, Steamworks.SteamId steamID)
- private static Steamworks.SteamId _GetFriendByIndex(System.IntPtr self, int iFriend, int iFriendFlags)
- private static Steamworks.AppId _GetFriendCoplayGame(System.IntPtr self, Steamworks.SteamId steamIDFriend)
- private static int _GetFriendCoplayTime(System.IntPtr self, Steamworks.SteamId steamIDFriend)
- private static int _GetFriendCount(System.IntPtr self, int iFriendFlags)
- private static int _GetFriendCountFromSource(System.IntPtr self, Steamworks.SteamId steamIDSource)
- private static Steamworks.SteamId _GetFriendFromSourceByIndex(System.IntPtr self, Steamworks.SteamId steamIDSource, int iFriend)
- private static bool _GetFriendGamePlayed(System.IntPtr self, Steamworks.SteamId steamIDFriend, ref Steamworks.Data.FriendGameInfo_t pFriendGameInfo)
- private static int _GetFriendMessage(System.IntPtr self, Steamworks.SteamId steamIDFriend, int iMessageID, System.IntPtr pvData, int cubData, ref Steamworks.ChatEntryType peChatEntryType)
- private static Steamworks.Utf8StringPointer _GetFriendPersonaName(System.IntPtr self, Steamworks.SteamId steamIDFriend)
- private static Steamworks.Utf8StringPointer _GetFriendPersonaNameHistory(System.IntPtr self, Steamworks.SteamId steamIDFriend, int iPersonaName)
- private static Steamworks.FriendState _GetFriendPersonaState(System.IntPtr self, Steamworks.SteamId steamIDFriend)
- private static Steamworks.Relationship _GetFriendRelationship(System.IntPtr self, Steamworks.SteamId steamIDFriend)
- private static Steamworks.Utf8StringPointer _GetFriendRichPresence(System.IntPtr self, Steamworks.SteamId steamIDFriend, string pchKey)
- private static Steamworks.Utf8StringPointer _GetFriendRichPresenceKeyByIndex(System.IntPtr self, Steamworks.SteamId steamIDFriend, int iKey)
- private static int _GetFriendRichPresenceKeyCount(System.IntPtr self, Steamworks.SteamId steamIDFriend)
- private static int _GetFriendsGroupCount(System.IntPtr self)
- private static Steamworks.Data.FriendsGroupID_t _GetFriendsGroupIDByIndex(System.IntPtr self, int iFG)
- private static int _GetFriendsGroupMembersCount(System.IntPtr self, Steamworks.Data.FriendsGroupID_t friendsGroupID)
- private static void _GetFriendsGroupMembersList(System.IntPtr self, Steamworks.Data.FriendsGroupID_t friendsGroupID, Steamworks.SteamId[] pOutSteamIDMembers, int nMembersCount)
- private static Steamworks.Utf8StringPointer _GetFriendsGroupName(System.IntPtr self, Steamworks.Data.FriendsGroupID_t friendsGroupID)
- private static int _GetFriendSteamLevel(System.IntPtr self, Steamworks.SteamId steamIDFriend)
- private static int _GetLargeFriendAvatar(System.IntPtr self, Steamworks.SteamId steamIDFriend)
- private static int _GetMediumFriendAvatar(System.IntPtr self, Steamworks.SteamId steamIDFriend)
- private static int _GetNumChatsWithUnreadPriorityMessages(System.IntPtr self)
- private static Steamworks.Utf8StringPointer _GetPersonaName(System.IntPtr self)
- private static Steamworks.FriendState _GetPersonaState(System.IntPtr self)
- private static Steamworks.Utf8StringPointer _GetPlayerNickname(System.IntPtr self, Steamworks.SteamId steamIDPlayer)
- private static int _GetSmallFriendAvatar(System.IntPtr self, Steamworks.SteamId steamIDFriend)
- private static uint _GetUserRestrictions(System.IntPtr self)
- private static bool _HasFriend(System.IntPtr self, Steamworks.SteamId steamIDFriend, int iFriendFlags)
- private static bool _InviteUserToGame(System.IntPtr self, Steamworks.SteamId steamIDFriend, string pchConnectString)
- private static bool _IsClanChatAdmin(System.IntPtr self, Steamworks.SteamId steamIDClanChat, Steamworks.SteamId steamIDUser)
- private static bool _IsClanChatWindowOpenInSteam(System.IntPtr self, Steamworks.SteamId steamIDClanChat)
- private static bool _IsClanOfficialGameGroup(System.IntPtr self, Steamworks.SteamId steamIDClan)
- private static bool _IsClanPublic(System.IntPtr self, Steamworks.SteamId steamIDClan)
- private static Steamworks.Data.SteamAPICall_t _IsFollowing(System.IntPtr self, Steamworks.SteamId steamID)
- private static bool _IsUserInSource(System.IntPtr self, Steamworks.SteamId steamIDUser, Steamworks.SteamId steamIDSource)
- private static Steamworks.Data.SteamAPICall_t _JoinClanChatRoom(System.IntPtr self, Steamworks.SteamId steamIDClan)
- private static bool _LeaveClanChatRoom(System.IntPtr self, Steamworks.SteamId steamIDClan)
- private static bool _OpenClanChatWindowInSteam(System.IntPtr self, Steamworks.SteamId steamIDClanChat)
- private static bool _ReplyToFriendMessage(System.IntPtr self, Steamworks.SteamId steamIDFriend, string pchMsgToSend)
- private static Steamworks.Data.SteamAPICall_t _RequestClanOfficerList(System.IntPtr self, Steamworks.SteamId steamIDClan)
- private static void _RequestFriendRichPresence(System.IntPtr self, Steamworks.SteamId steamIDFriend)
- private static bool _RequestUserInformation(System.IntPtr self, Steamworks.SteamId steamIDUser, bool bRequireNameOnly)
- private static bool _SendClanChatMessage(System.IntPtr self, Steamworks.SteamId steamIDClanChat, string pchText)
- private static void _SetInGameVoiceSpeaking(System.IntPtr self, Steamworks.SteamId steamIDUser, bool bSpeaking)
- private static bool _SetListenForFriendsMessages(System.IntPtr self, bool bInterceptEnabled)
- private static Steamworks.Data.SteamAPICall_t _SetPersonaName(System.IntPtr self, string pchPersonaName)
- private static void _SetPlayedWith(System.IntPtr self, Steamworks.SteamId steamIDUserPlayedWith)
- private static bool _SetRichPresence(System.IntPtr self, string pchKey, string pchValue)

### internal class Steamworks.ISteamGameSearch
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamGameSearch(bool IsGameServer)

#### Methods
- internal Steamworks.GameSearchErrorCode_t AcceptGame()
- internal Steamworks.GameSearchErrorCode_t AddGameSearchParams(string pchKeyToFind, string pchValuesToFind)
- internal Steamworks.GameSearchErrorCode_t CancelRequestPlayersForGame()
- internal Steamworks.GameSearchErrorCode_t DeclineGame()
- internal Steamworks.GameSearchErrorCode_t EndGame(ulong ullUniqueGameID)
- internal Steamworks.GameSearchErrorCode_t EndGameSearch()
- public override System.IntPtr GetUserInterfacePointer()
- internal Steamworks.GameSearchErrorCode_t HostConfirmGameStart(ulong ullUniqueGameID)
- internal Steamworks.GameSearchErrorCode_t RequestPlayersForGame(int nPlayerMin, int nPlayerMax, int nMaxTeamSize)
- internal Steamworks.GameSearchErrorCode_t RetrieveConnectionDetails(Steamworks.SteamId steamIDHost, out string pchConnectionDetails)
- internal Steamworks.GameSearchErrorCode_t SearchForGameSolo(int nPlayerMin, int nPlayerMax)
- internal Steamworks.GameSearchErrorCode_t SearchForGameWithLobby(Steamworks.SteamId steamIDLobby, int nPlayerMin, int nPlayerMax)
- internal Steamworks.GameSearchErrorCode_t SetConnectionDetails(string pchConnectionDetails, int cubConnectionDetails)
- internal Steamworks.GameSearchErrorCode_t SetGameHostParams(string pchKey, string pchValue)
- internal static System.IntPtr SteamAPI_SteamGameSearch_v001()
- internal Steamworks.GameSearchErrorCode_t SubmitPlayerResult(ulong ullUniqueGameID, Steamworks.SteamId steamIDPlayer, Steamworks.PlayerResult_t EPlayerResult)
- private static Steamworks.GameSearchErrorCode_t _AcceptGame(System.IntPtr self)
- private static Steamworks.GameSearchErrorCode_t _AddGameSearchParams(System.IntPtr self, string pchKeyToFind, string pchValuesToFind)
- private static Steamworks.GameSearchErrorCode_t _CancelRequestPlayersForGame(System.IntPtr self)
- private static Steamworks.GameSearchErrorCode_t _DeclineGame(System.IntPtr self)
- private static Steamworks.GameSearchErrorCode_t _EndGame(System.IntPtr self, ulong ullUniqueGameID)
- private static Steamworks.GameSearchErrorCode_t _EndGameSearch(System.IntPtr self)
- private static Steamworks.GameSearchErrorCode_t _HostConfirmGameStart(System.IntPtr self, ulong ullUniqueGameID)
- private static Steamworks.GameSearchErrorCode_t _RequestPlayersForGame(System.IntPtr self, int nPlayerMin, int nPlayerMax, int nMaxTeamSize)
- private static Steamworks.GameSearchErrorCode_t _RetrieveConnectionDetails(System.IntPtr self, Steamworks.SteamId steamIDHost, System.IntPtr pchConnectionDetails, int cubConnectionDetails)
- private static Steamworks.GameSearchErrorCode_t _SearchForGameSolo(System.IntPtr self, int nPlayerMin, int nPlayerMax)
- private static Steamworks.GameSearchErrorCode_t _SearchForGameWithLobby(System.IntPtr self, Steamworks.SteamId steamIDLobby, int nPlayerMin, int nPlayerMax)
- private static Steamworks.GameSearchErrorCode_t _SetConnectionDetails(System.IntPtr self, string pchConnectionDetails, int cubConnectionDetails)
- private static Steamworks.GameSearchErrorCode_t _SetGameHostParams(System.IntPtr self, string pchKey, string pchValue)
- private static Steamworks.GameSearchErrorCode_t _SubmitPlayerResult(System.IntPtr self, ulong ullUniqueGameID, Steamworks.SteamId steamIDPlayer, Steamworks.PlayerResult_t EPlayerResult)

### internal class Steamworks.ISteamGameServer
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamGameServer(bool IsGameServer)

#### Methods
- internal Steamworks.CallResult<Steamworks.Data.AssociateWithClanResult_t> AssociateWithClan(Steamworks.SteamId steamIDClan)
- internal Steamworks.BeginAuthResult BeginAuthSession(System.IntPtr pAuthTicket, int cbAuthTicket, Steamworks.SteamId steamID)
- internal bool BLoggedOn()
- internal bool BSecure()
- internal bool BUpdateUserData(Steamworks.SteamId steamIDUser, string pchPlayerName, uint uScore)
- internal void CancelAuthTicket(Steamworks.Data.HAuthTicket hAuthTicket)
- internal void ClearAllKeyValues()
- internal Steamworks.CallResult<Steamworks.Data.ComputeNewPlayerCompatibilityResult_t> ComputeNewPlayerCompatibility(Steamworks.SteamId steamIDNewPlayer)
- internal Steamworks.SteamId CreateUnauthenticatedUserConnection()
- internal void EnableHeartbeats(bool bActive)
- internal void EndAuthSession(Steamworks.SteamId steamID)
- internal void ForceHeartbeat()
- internal Steamworks.Data.HAuthTicket GetAuthSessionTicket(System.IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket)
- internal void GetGameplayStats()
- internal int GetNextOutgoingPacket(System.IntPtr pOut, int cbMaxOut, ref uint pNetAdr, ref ushort pPort)
- internal Steamworks.Data.SteamIPAddress GetPublicIP()
- public override System.IntPtr GetServerInterfacePointer()
- internal Steamworks.CallResult<Steamworks.Data.GSReputation_t> GetServerReputation()
- internal Steamworks.SteamId GetSteamID()
- internal bool HandleIncomingPacket(System.IntPtr pData, int cbData, uint srcIP, ushort srcPort)
- internal void LogOff()
- internal void LogOn(string pszToken)
- internal void LogOnAnonymous()
- internal bool RequestUserGroupStatus(Steamworks.SteamId steamIDUser, Steamworks.SteamId steamIDGroup)
- internal bool SendUserConnectAndAuthenticate(uint unIPClient, System.IntPtr pvAuthBlob, uint cubAuthBlobSize, ref Steamworks.SteamId pSteamIDUser)
- internal void SendUserDisconnect(Steamworks.SteamId steamIDUser)
- internal void SetBotPlayerCount(int cBotplayers)
- internal void SetDedicatedServer(bool bDedicated)
- internal void SetGameData(string pchGameData)
- internal void SetGameDescription(string pszGameDescription)
- internal void SetGameTags(string pchGameTags)
- internal void SetHeartbeatInterval(int iHeartbeatInterval)
- internal void SetKeyValue(string pKey, string pValue)
- internal void SetMapName(string pszMapName)
- internal void SetMaxPlayerCount(int cPlayersMax)
- internal void SetModDir(string pszModDir)
- internal void SetPasswordProtected(bool bPasswordProtected)
- internal void SetProduct(string pszProduct)
- internal void SetRegion(string pszRegion)
- internal void SetServerName(string pszServerName)
- internal void SetSpectatorPort(ushort unSpectatorPort)
- internal void SetSpectatorServerName(string pszSpectatorServerName)
- internal static System.IntPtr SteamAPI_SteamGameServer_v013()
- internal Steamworks.UserHasLicenseForAppResult UserHasLicenseForApp(Steamworks.SteamId steamID, Steamworks.AppId appID)
- internal bool WasRestartRequested()
- private static Steamworks.Data.SteamAPICall_t _AssociateWithClan(System.IntPtr self, Steamworks.SteamId steamIDClan)
- private static Steamworks.BeginAuthResult _BeginAuthSession(System.IntPtr self, System.IntPtr pAuthTicket, int cbAuthTicket, Steamworks.SteamId steamID)
- private static bool _BLoggedOn(System.IntPtr self)
- private static bool _BSecure(System.IntPtr self)
- private static bool _BUpdateUserData(System.IntPtr self, Steamworks.SteamId steamIDUser, string pchPlayerName, uint uScore)
- private static void _CancelAuthTicket(System.IntPtr self, Steamworks.Data.HAuthTicket hAuthTicket)
- private static void _ClearAllKeyValues(System.IntPtr self)
- private static Steamworks.Data.SteamAPICall_t _ComputeNewPlayerCompatibility(System.IntPtr self, Steamworks.SteamId steamIDNewPlayer)
- private static Steamworks.SteamId _CreateUnauthenticatedUserConnection(System.IntPtr self)
- private static void _EnableHeartbeats(System.IntPtr self, bool bActive)
- private static void _EndAuthSession(System.IntPtr self, Steamworks.SteamId steamID)
- private static void _ForceHeartbeat(System.IntPtr self)
- private static Steamworks.Data.HAuthTicket _GetAuthSessionTicket(System.IntPtr self, System.IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket)
- private static void _GetGameplayStats(System.IntPtr self)
- private static int _GetNextOutgoingPacket(System.IntPtr self, System.IntPtr pOut, int cbMaxOut, ref uint pNetAdr, ref ushort pPort)
- private static Steamworks.Data.SteamIPAddress _GetPublicIP(System.IntPtr self)
- private static Steamworks.Data.SteamAPICall_t _GetServerReputation(System.IntPtr self)
- private static Steamworks.SteamId _GetSteamID(System.IntPtr self)
- private static bool _HandleIncomingPacket(System.IntPtr self, System.IntPtr pData, int cbData, uint srcIP, ushort srcPort)
- private static void _LogOff(System.IntPtr self)
- private static void _LogOn(System.IntPtr self, string pszToken)
- private static void _LogOnAnonymous(System.IntPtr self)
- private static bool _RequestUserGroupStatus(System.IntPtr self, Steamworks.SteamId steamIDUser, Steamworks.SteamId steamIDGroup)
- private static bool _SendUserConnectAndAuthenticate(System.IntPtr self, uint unIPClient, System.IntPtr pvAuthBlob, uint cubAuthBlobSize, ref Steamworks.SteamId pSteamIDUser)
- private static void _SendUserDisconnect(System.IntPtr self, Steamworks.SteamId steamIDUser)
- private static void _SetBotPlayerCount(System.IntPtr self, int cBotplayers)
- private static void _SetDedicatedServer(System.IntPtr self, bool bDedicated)
- private static void _SetGameData(System.IntPtr self, string pchGameData)
- private static void _SetGameDescription(System.IntPtr self, string pszGameDescription)
- private static void _SetGameTags(System.IntPtr self, string pchGameTags)
- private static void _SetHeartbeatInterval(System.IntPtr self, int iHeartbeatInterval)
- private static void _SetKeyValue(System.IntPtr self, string pKey, string pValue)
- private static void _SetMapName(System.IntPtr self, string pszMapName)
- private static void _SetMaxPlayerCount(System.IntPtr self, int cPlayersMax)
- private static void _SetModDir(System.IntPtr self, string pszModDir)
- private static void _SetPasswordProtected(System.IntPtr self, bool bPasswordProtected)
- private static void _SetProduct(System.IntPtr self, string pszProduct)
- private static void _SetRegion(System.IntPtr self, string pszRegion)
- private static void _SetServerName(System.IntPtr self, string pszServerName)
- private static void _SetSpectatorPort(System.IntPtr self, ushort unSpectatorPort)
- private static void _SetSpectatorServerName(System.IntPtr self, string pszSpectatorServerName)
- private static Steamworks.UserHasLicenseForAppResult _UserHasLicenseForApp(System.IntPtr self, Steamworks.SteamId steamID, Steamworks.AppId appID)
- private static bool _WasRestartRequested(System.IntPtr self)

### internal class Steamworks.ISteamGameServerStats
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamGameServerStats(bool IsGameServer)

#### Methods
- internal bool ClearUserAchievement(Steamworks.SteamId steamIDUser, string pchName)
- public override System.IntPtr GetServerInterfacePointer()
- internal bool GetUserAchievement(Steamworks.SteamId steamIDUser, string pchName, ref bool pbAchieved)
- internal bool GetUserStat(Steamworks.SteamId steamIDUser, string pchName, ref int pData)
- internal bool GetUserStat(Steamworks.SteamId steamIDUser, string pchName, ref float pData)
- internal Steamworks.CallResult<Steamworks.Data.GSStatsReceived_t> RequestUserStats(Steamworks.SteamId steamIDUser)
- internal bool SetUserAchievement(Steamworks.SteamId steamIDUser, string pchName)
- internal bool SetUserStat(Steamworks.SteamId steamIDUser, string pchName, int nData)
- internal bool SetUserStat(Steamworks.SteamId steamIDUser, string pchName, float fData)
- internal static System.IntPtr SteamAPI_SteamGameServerStats_v001()
- internal Steamworks.CallResult<Steamworks.Data.GSStatsStored_t> StoreUserStats(Steamworks.SteamId steamIDUser)
- internal bool UpdateUserAvgRateStat(Steamworks.SteamId steamIDUser, string pchName, float flCountThisSession, double dSessionLength)
- private static bool _ClearUserAchievement(System.IntPtr self, Steamworks.SteamId steamIDUser, string pchName)
- private static bool _GetUserAchievement(System.IntPtr self, Steamworks.SteamId steamIDUser, string pchName, ref bool pbAchieved)
- private static bool _GetUserStat(System.IntPtr self, Steamworks.SteamId steamIDUser, string pchName, ref int pData)
- private static bool _GetUserStat(System.IntPtr self, Steamworks.SteamId steamIDUser, string pchName, ref float pData)
- private static Steamworks.Data.SteamAPICall_t _RequestUserStats(System.IntPtr self, Steamworks.SteamId steamIDUser)
- private static bool _SetUserAchievement(System.IntPtr self, Steamworks.SteamId steamIDUser, string pchName)
- private static bool _SetUserStat(System.IntPtr self, Steamworks.SteamId steamIDUser, string pchName, int nData)
- private static bool _SetUserStat(System.IntPtr self, Steamworks.SteamId steamIDUser, string pchName, float fData)
- private static Steamworks.Data.SteamAPICall_t _StoreUserStats(System.IntPtr self, Steamworks.SteamId steamIDUser)
- private static bool _UpdateUserAvgRateStat(System.IntPtr self, Steamworks.SteamId steamIDUser, string pchName, float flCountThisSession, double dSessionLength)

### internal class Steamworks.ISteamHTMLSurface
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamHTMLSurface(bool IsGameServer)

#### Methods
- internal void AddHeader(Steamworks.Data.HHTMLBrowser unBrowserHandle, string pchKey, string pchValue)
- internal void AllowStartRequest(Steamworks.Data.HHTMLBrowser unBrowserHandle, bool bAllowed)
- internal void CopyToClipboard(Steamworks.Data.HHTMLBrowser unBrowserHandle)
- internal Steamworks.CallResult<Steamworks.Data.HTML_BrowserReady_t> CreateBrowser(string pchUserAgent, string pchUserCSS)
- internal void ExecuteJavascript(Steamworks.Data.HHTMLBrowser unBrowserHandle, string pchScript)
- internal void FileLoadDialogResponse(Steamworks.Data.HHTMLBrowser unBrowserHandle, string pchSelectedFiles)
- internal void Find(Steamworks.Data.HHTMLBrowser unBrowserHandle, string pchSearchStr, bool bCurrentlyInFind, bool bReverse)
- internal void GetLinkAtPosition(Steamworks.Data.HHTMLBrowser unBrowserHandle, int x, int y)
- public override System.IntPtr GetUserInterfacePointer()
- internal void GoBack(Steamworks.Data.HHTMLBrowser unBrowserHandle)
- internal void GoForward(Steamworks.Data.HHTMLBrowser unBrowserHandle)
- internal bool Init()
- internal void JSDialogResponse(Steamworks.Data.HHTMLBrowser unBrowserHandle, bool bResult)
- internal void KeyChar(Steamworks.Data.HHTMLBrowser unBrowserHandle, uint cUnicodeChar, System.IntPtr eHTMLKeyModifiers)
- internal void KeyDown(Steamworks.Data.HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, System.IntPtr eHTMLKeyModifiers, bool bIsSystemKey)
- internal void KeyUp(Steamworks.Data.HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, System.IntPtr eHTMLKeyModifiers)
- internal void LoadURL(Steamworks.Data.HHTMLBrowser unBrowserHandle, string pchURL, string pchPostData)
- internal void MouseDoubleClick(Steamworks.Data.HHTMLBrowser unBrowserHandle, System.IntPtr eMouseButton)
- internal void MouseDown(Steamworks.Data.HHTMLBrowser unBrowserHandle, System.IntPtr eMouseButton)
- internal void MouseMove(Steamworks.Data.HHTMLBrowser unBrowserHandle, int x, int y)
- internal void MouseUp(Steamworks.Data.HHTMLBrowser unBrowserHandle, System.IntPtr eMouseButton)
- internal void MouseWheel(Steamworks.Data.HHTMLBrowser unBrowserHandle, int nDelta)
- internal void OpenDeveloperTools(Steamworks.Data.HHTMLBrowser unBrowserHandle)
- internal void PasteFromClipboard(Steamworks.Data.HHTMLBrowser unBrowserHandle)
- internal void Reload(Steamworks.Data.HHTMLBrowser unBrowserHandle)
- internal void RemoveBrowser(Steamworks.Data.HHTMLBrowser unBrowserHandle)
- internal void SetBackgroundMode(Steamworks.Data.HHTMLBrowser unBrowserHandle, bool bBackgroundMode)
- internal void SetCookie(string pchHostname, string pchKey, string pchValue, string pchPath, Steamworks.Data.RTime32 nExpires, bool bSecure, bool bHTTPOnly)
- internal void SetDPIScalingFactor(Steamworks.Data.HHTMLBrowser unBrowserHandle, float flDPIScaling)
- internal void SetHorizontalScroll(Steamworks.Data.HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll)
- internal void SetKeyFocus(Steamworks.Data.HHTMLBrowser unBrowserHandle, bool bHasKeyFocus)
- internal void SetPageScaleFactor(Steamworks.Data.HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY)
- internal void SetSize(Steamworks.Data.HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight)
- internal void SetVerticalScroll(Steamworks.Data.HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll)
- internal bool Shutdown()
- internal static System.IntPtr SteamAPI_SteamHTMLSurface_v005()
- internal void StopFind(Steamworks.Data.HHTMLBrowser unBrowserHandle)
- internal void StopLoad(Steamworks.Data.HHTMLBrowser unBrowserHandle)
- internal void ViewSource(Steamworks.Data.HHTMLBrowser unBrowserHandle)
- private static void _AddHeader(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle, string pchKey, string pchValue)
- private static void _AllowStartRequest(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle, bool bAllowed)
- private static void _CopyToClipboard(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle)
- private static Steamworks.Data.SteamAPICall_t _CreateBrowser(System.IntPtr self, string pchUserAgent, string pchUserCSS)
- private static void _ExecuteJavascript(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle, string pchScript)
- private static void _FileLoadDialogResponse(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle, string pchSelectedFiles)
- private static void _Find(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle, string pchSearchStr, bool bCurrentlyInFind, bool bReverse)
- private static void _GetLinkAtPosition(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle, int x, int y)
- private static void _GoBack(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle)
- private static void _GoForward(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle)
- private static bool _Init(System.IntPtr self)
- private static void _JSDialogResponse(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle, bool bResult)
- private static void _KeyChar(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle, uint cUnicodeChar, System.IntPtr eHTMLKeyModifiers)
- private static void _KeyDown(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, System.IntPtr eHTMLKeyModifiers, bool bIsSystemKey)
- private static void _KeyUp(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, System.IntPtr eHTMLKeyModifiers)
- private static void _LoadURL(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle, string pchURL, string pchPostData)
- private static void _MouseDoubleClick(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle, System.IntPtr eMouseButton)
- private static void _MouseDown(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle, System.IntPtr eMouseButton)
- private static void _MouseMove(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle, int x, int y)
- private static void _MouseUp(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle, System.IntPtr eMouseButton)
- private static void _MouseWheel(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle, int nDelta)
- private static void _OpenDeveloperTools(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle)
- private static void _PasteFromClipboard(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle)
- private static void _Reload(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle)
- private static void _RemoveBrowser(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle)
- private static void _SetBackgroundMode(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle, bool bBackgroundMode)
- private static void _SetCookie(System.IntPtr self, string pchHostname, string pchKey, string pchValue, string pchPath, Steamworks.Data.RTime32 nExpires, bool bSecure, bool bHTTPOnly)
- private static void _SetDPIScalingFactor(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle, float flDPIScaling)
- private static void _SetHorizontalScroll(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll)
- private static void _SetKeyFocus(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle, bool bHasKeyFocus)
- private static void _SetPageScaleFactor(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY)
- private static void _SetSize(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight)
- private static void _SetVerticalScroll(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll)
- private static bool _Shutdown(System.IntPtr self)
- private static void _StopFind(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle)
- private static void _StopLoad(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle)
- private static void _ViewSource(System.IntPtr self, Steamworks.Data.HHTMLBrowser unBrowserHandle)

### internal class Steamworks.ISteamHTTP
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamHTTP(bool IsGameServer)

#### Methods
- internal Steamworks.Data.HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify)
- internal Steamworks.Data.HTTPRequestHandle CreateHTTPRequest(Steamworks.HTTPMethod eHTTPRequestMethod, string pchAbsoluteURL)
- internal bool DeferHTTPRequest(Steamworks.Data.HTTPRequestHandle hRequest)
- internal bool GetHTTPDownloadProgressPct(Steamworks.Data.HTTPRequestHandle hRequest, ref float pflPercentOut)
- internal bool GetHTTPRequestWasTimedOut(Steamworks.Data.HTTPRequestHandle hRequest, ref bool pbWasTimedOut)
- internal bool GetHTTPResponseBodyData(Steamworks.Data.HTTPRequestHandle hRequest, ref byte pBodyDataBuffer, uint unBufferSize)
- internal bool GetHTTPResponseBodySize(Steamworks.Data.HTTPRequestHandle hRequest, ref uint unBodySize)
- internal bool GetHTTPResponseHeaderSize(Steamworks.Data.HTTPRequestHandle hRequest, string pchHeaderName, ref uint unResponseHeaderSize)
- internal bool GetHTTPResponseHeaderValue(Steamworks.Data.HTTPRequestHandle hRequest, string pchHeaderName, ref byte pHeaderValueBuffer, uint unBufferSize)
- internal bool GetHTTPStreamingResponseBodyData(Steamworks.Data.HTTPRequestHandle hRequest, uint cOffset, ref byte pBodyDataBuffer, uint unBufferSize)
- public override System.IntPtr GetServerInterfacePointer()
- public override System.IntPtr GetUserInterfacePointer()
- internal bool PrioritizeHTTPRequest(Steamworks.Data.HTTPRequestHandle hRequest)
- internal bool ReleaseCookieContainer(Steamworks.Data.HTTPCookieContainerHandle hCookieContainer)
- internal bool ReleaseHTTPRequest(Steamworks.Data.HTTPRequestHandle hRequest)
- internal bool SendHTTPRequest(Steamworks.Data.HTTPRequestHandle hRequest, ref Steamworks.Data.SteamAPICall_t pCallHandle)
- internal bool SendHTTPRequestAndStreamResponse(Steamworks.Data.HTTPRequestHandle hRequest, ref Steamworks.Data.SteamAPICall_t pCallHandle)
- internal bool SetCookie(Steamworks.Data.HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie)
- internal bool SetHTTPRequestAbsoluteTimeoutMS(Steamworks.Data.HTTPRequestHandle hRequest, uint unMilliseconds)
- internal bool SetHTTPRequestContextValue(Steamworks.Data.HTTPRequestHandle hRequest, ulong ulContextValue)
- internal bool SetHTTPRequestCookieContainer(Steamworks.Data.HTTPRequestHandle hRequest, Steamworks.Data.HTTPCookieContainerHandle hCookieContainer)
- internal bool SetHTTPRequestGetOrPostParameter(Steamworks.Data.HTTPRequestHandle hRequest, string pchParamName, string pchParamValue)
- internal bool SetHTTPRequestHeaderValue(Steamworks.Data.HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue)
- internal bool SetHTTPRequestNetworkActivityTimeout(Steamworks.Data.HTTPRequestHandle hRequest, uint unTimeoutSeconds)
- internal bool SetHTTPRequestRawPostBody(Steamworks.Data.HTTPRequestHandle hRequest, string pchContentType, byte[] pubBody, uint unBodyLen)
- internal bool SetHTTPRequestRequiresVerifiedCertificate(Steamworks.Data.HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate)
- internal bool SetHTTPRequestUserAgentInfo(Steamworks.Data.HTTPRequestHandle hRequest, string pchUserAgentInfo)
- internal static System.IntPtr SteamAPI_SteamGameServerHTTP_v003()
- internal static System.IntPtr SteamAPI_SteamHTTP_v003()
- private static Steamworks.Data.HTTPCookieContainerHandle _CreateCookieContainer(System.IntPtr self, bool bAllowResponsesToModify)
- private static Steamworks.Data.HTTPRequestHandle _CreateHTTPRequest(System.IntPtr self, Steamworks.HTTPMethod eHTTPRequestMethod, string pchAbsoluteURL)
- private static bool _DeferHTTPRequest(System.IntPtr self, Steamworks.Data.HTTPRequestHandle hRequest)
- private static bool _GetHTTPDownloadProgressPct(System.IntPtr self, Steamworks.Data.HTTPRequestHandle hRequest, ref float pflPercentOut)
- private static bool _GetHTTPRequestWasTimedOut(System.IntPtr self, Steamworks.Data.HTTPRequestHandle hRequest, ref bool pbWasTimedOut)
- private static bool _GetHTTPResponseBodyData(System.IntPtr self, Steamworks.Data.HTTPRequestHandle hRequest, ref byte pBodyDataBuffer, uint unBufferSize)
- private static bool _GetHTTPResponseBodySize(System.IntPtr self, Steamworks.Data.HTTPRequestHandle hRequest, ref uint unBodySize)
- private static bool _GetHTTPResponseHeaderSize(System.IntPtr self, Steamworks.Data.HTTPRequestHandle hRequest, string pchHeaderName, ref uint unResponseHeaderSize)
- private static bool _GetHTTPResponseHeaderValue(System.IntPtr self, Steamworks.Data.HTTPRequestHandle hRequest, string pchHeaderName, ref byte pHeaderValueBuffer, uint unBufferSize)
- private static bool _GetHTTPStreamingResponseBodyData(System.IntPtr self, Steamworks.Data.HTTPRequestHandle hRequest, uint cOffset, ref byte pBodyDataBuffer, uint unBufferSize)
- private static bool _PrioritizeHTTPRequest(System.IntPtr self, Steamworks.Data.HTTPRequestHandle hRequest)
- private static bool _ReleaseCookieContainer(System.IntPtr self, Steamworks.Data.HTTPCookieContainerHandle hCookieContainer)
- private static bool _ReleaseHTTPRequest(System.IntPtr self, Steamworks.Data.HTTPRequestHandle hRequest)
- private static bool _SendHTTPRequest(System.IntPtr self, Steamworks.Data.HTTPRequestHandle hRequest, ref Steamworks.Data.SteamAPICall_t pCallHandle)
- private static bool _SendHTTPRequestAndStreamResponse(System.IntPtr self, Steamworks.Data.HTTPRequestHandle hRequest, ref Steamworks.Data.SteamAPICall_t pCallHandle)
- private static bool _SetCookie(System.IntPtr self, Steamworks.Data.HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie)
- private static bool _SetHTTPRequestAbsoluteTimeoutMS(System.IntPtr self, Steamworks.Data.HTTPRequestHandle hRequest, uint unMilliseconds)
- private static bool _SetHTTPRequestContextValue(System.IntPtr self, Steamworks.Data.HTTPRequestHandle hRequest, ulong ulContextValue)
- private static bool _SetHTTPRequestCookieContainer(System.IntPtr self, Steamworks.Data.HTTPRequestHandle hRequest, Steamworks.Data.HTTPCookieContainerHandle hCookieContainer)
- private static bool _SetHTTPRequestGetOrPostParameter(System.IntPtr self, Steamworks.Data.HTTPRequestHandle hRequest, string pchParamName, string pchParamValue)
- private static bool _SetHTTPRequestHeaderValue(System.IntPtr self, Steamworks.Data.HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue)
- private static bool _SetHTTPRequestNetworkActivityTimeout(System.IntPtr self, Steamworks.Data.HTTPRequestHandle hRequest, uint unTimeoutSeconds)
- private static bool _SetHTTPRequestRawPostBody(System.IntPtr self, Steamworks.Data.HTTPRequestHandle hRequest, string pchContentType, byte[] pubBody, uint unBodyLen)
- private static bool _SetHTTPRequestRequiresVerifiedCertificate(System.IntPtr self, Steamworks.Data.HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate)
- private static bool _SetHTTPRequestUserAgentInfo(System.IntPtr self, Steamworks.Data.HTTPRequestHandle hRequest, string pchUserAgentInfo)

### internal class Steamworks.ISteamInput
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamInput(bool IsGameServer)

#### Methods
- internal void ActivateActionSet(Steamworks.Data.InputHandle_t inputHandle, Steamworks.Data.InputActionSetHandle_t actionSetHandle)
- internal void ActivateActionSetLayer(Steamworks.Data.InputHandle_t inputHandle, Steamworks.Data.InputActionSetHandle_t actionSetLayerHandle)
- internal void DeactivateActionSetLayer(Steamworks.Data.InputHandle_t inputHandle, Steamworks.Data.InputActionSetHandle_t actionSetLayerHandle)
- internal void DeactivateAllActionSetLayers(Steamworks.Data.InputHandle_t inputHandle)
- internal Steamworks.InputActionOrigin GetActionOriginFromXboxOrigin(Steamworks.Data.InputHandle_t inputHandle, Steamworks.XboxOrigin eOrigin)
- internal Steamworks.Data.InputActionSetHandle_t GetActionSetHandle(string pszActionSetName)
- internal int GetActiveActionSetLayers(Steamworks.Data.InputHandle_t inputHandle, Steamworks.Data.InputActionSetHandle_t[] handlesOut)
- internal Steamworks.AnalogState GetAnalogActionData(Steamworks.Data.InputHandle_t inputHandle, Steamworks.Data.InputAnalogActionHandle_t analogActionHandle)
- internal Steamworks.Data.InputAnalogActionHandle_t GetAnalogActionHandle(string pszActionName)
- internal int GetAnalogActionOrigins(Steamworks.Data.InputHandle_t inputHandle, Steamworks.Data.InputActionSetHandle_t actionSetHandle, Steamworks.Data.InputAnalogActionHandle_t analogActionHandle, ref Steamworks.InputActionOrigin originsOut)
- internal int GetConnectedControllers(Steamworks.Data.InputHandle_t[] handlesOut)
- internal Steamworks.Data.InputHandle_t GetControllerForGamepadIndex(int nIndex)
- internal Steamworks.Data.InputActionSetHandle_t GetCurrentActionSet(Steamworks.Data.InputHandle_t inputHandle)
- internal bool GetDeviceBindingRevision(Steamworks.Data.InputHandle_t inputHandle, ref int pMajor, ref int pMinor)
- internal Steamworks.DigitalState GetDigitalActionData(Steamworks.Data.InputHandle_t inputHandle, Steamworks.Data.InputDigitalActionHandle_t digitalActionHandle)
- internal Steamworks.Data.InputDigitalActionHandle_t GetDigitalActionHandle(string pszActionName)
- internal int GetDigitalActionOrigins(Steamworks.Data.InputHandle_t inputHandle, Steamworks.Data.InputActionSetHandle_t actionSetHandle, Steamworks.Data.InputDigitalActionHandle_t digitalActionHandle, ref Steamworks.InputActionOrigin originsOut)
- internal int GetGamepadIndexForController(Steamworks.Data.InputHandle_t ulinputHandle)
- internal string GetGlyphForActionOrigin(Steamworks.InputActionOrigin eOrigin)
- internal string GetGlyphForXboxOrigin(Steamworks.XboxOrigin eOrigin)
- internal Steamworks.InputType GetInputTypeForHandle(Steamworks.Data.InputHandle_t inputHandle)
- internal Steamworks.MotionState GetMotionData(Steamworks.Data.InputHandle_t inputHandle)
- internal uint GetRemotePlaySessionID(Steamworks.Data.InputHandle_t inputHandle)
- internal string GetStringForActionOrigin(Steamworks.InputActionOrigin eOrigin)
- internal string GetStringForXboxOrigin(Steamworks.XboxOrigin eOrigin)
- public override System.IntPtr GetUserInterfacePointer()
- internal bool Init()
- internal void RunFrame()
- internal void SetLEDColor(Steamworks.Data.InputHandle_t inputHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags)
- internal bool ShowBindingPanel(Steamworks.Data.InputHandle_t inputHandle)
- internal bool Shutdown()
- internal static System.IntPtr SteamAPI_SteamInput_v001()
- internal void StopAnalogActionMomentum(Steamworks.Data.InputHandle_t inputHandle, Steamworks.Data.InputAnalogActionHandle_t eAction)
- internal Steamworks.InputActionOrigin TranslateActionOrigin(Steamworks.InputType eDestinationInputType, Steamworks.InputActionOrigin eSourceOrigin)
- internal void TriggerHapticPulse(Steamworks.Data.InputHandle_t inputHandle, Steamworks.SteamControllerPad eTargetPad, ushort usDurationMicroSec)
- internal void TriggerRepeatedHapticPulse(Steamworks.Data.InputHandle_t inputHandle, Steamworks.SteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags)
- internal void TriggerVibration(Steamworks.Data.InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed)
- private static void _ActivateActionSet(System.IntPtr self, Steamworks.Data.InputHandle_t inputHandle, Steamworks.Data.InputActionSetHandle_t actionSetHandle)
- private static void _ActivateActionSetLayer(System.IntPtr self, Steamworks.Data.InputHandle_t inputHandle, Steamworks.Data.InputActionSetHandle_t actionSetLayerHandle)
- private static void _DeactivateActionSetLayer(System.IntPtr self, Steamworks.Data.InputHandle_t inputHandle, Steamworks.Data.InputActionSetHandle_t actionSetLayerHandle)
- private static void _DeactivateAllActionSetLayers(System.IntPtr self, Steamworks.Data.InputHandle_t inputHandle)
- private static Steamworks.InputActionOrigin _GetActionOriginFromXboxOrigin(System.IntPtr self, Steamworks.Data.InputHandle_t inputHandle, Steamworks.XboxOrigin eOrigin)
- private static Steamworks.Data.InputActionSetHandle_t _GetActionSetHandle(System.IntPtr self, string pszActionSetName)
- private static int _GetActiveActionSetLayers(System.IntPtr self, Steamworks.Data.InputHandle_t inputHandle, Steamworks.Data.InputActionSetHandle_t[] handlesOut)
- private static Steamworks.AnalogState _GetAnalogActionData(System.IntPtr self, Steamworks.Data.InputHandle_t inputHandle, Steamworks.Data.InputAnalogActionHandle_t analogActionHandle)
- private static Steamworks.Data.InputAnalogActionHandle_t _GetAnalogActionHandle(System.IntPtr self, string pszActionName)
- private static int _GetAnalogActionOrigins(System.IntPtr self, Steamworks.Data.InputHandle_t inputHandle, Steamworks.Data.InputActionSetHandle_t actionSetHandle, Steamworks.Data.InputAnalogActionHandle_t analogActionHandle, ref Steamworks.InputActionOrigin originsOut)
- private static int _GetConnectedControllers(System.IntPtr self, Steamworks.Data.InputHandle_t[] handlesOut)
- private static Steamworks.Data.InputHandle_t _GetControllerForGamepadIndex(System.IntPtr self, int nIndex)
- private static Steamworks.Data.InputActionSetHandle_t _GetCurrentActionSet(System.IntPtr self, Steamworks.Data.InputHandle_t inputHandle)
- private static bool _GetDeviceBindingRevision(System.IntPtr self, Steamworks.Data.InputHandle_t inputHandle, ref int pMajor, ref int pMinor)
- private static Steamworks.DigitalState _GetDigitalActionData(System.IntPtr self, Steamworks.Data.InputHandle_t inputHandle, Steamworks.Data.InputDigitalActionHandle_t digitalActionHandle)
- private static Steamworks.Data.InputDigitalActionHandle_t _GetDigitalActionHandle(System.IntPtr self, string pszActionName)
- private static int _GetDigitalActionOrigins(System.IntPtr self, Steamworks.Data.InputHandle_t inputHandle, Steamworks.Data.InputActionSetHandle_t actionSetHandle, Steamworks.Data.InputDigitalActionHandle_t digitalActionHandle, ref Steamworks.InputActionOrigin originsOut)
- private static int _GetGamepadIndexForController(System.IntPtr self, Steamworks.Data.InputHandle_t ulinputHandle)
- private static Steamworks.Utf8StringPointer _GetGlyphForActionOrigin(System.IntPtr self, Steamworks.InputActionOrigin eOrigin)
- private static Steamworks.Utf8StringPointer _GetGlyphForXboxOrigin(System.IntPtr self, Steamworks.XboxOrigin eOrigin)
- private static Steamworks.InputType _GetInputTypeForHandle(System.IntPtr self, Steamworks.Data.InputHandle_t inputHandle)
- private static Steamworks.MotionState _GetMotionData(System.IntPtr self, Steamworks.Data.InputHandle_t inputHandle)
- private static uint _GetRemotePlaySessionID(System.IntPtr self, Steamworks.Data.InputHandle_t inputHandle)
- private static Steamworks.Utf8StringPointer _GetStringForActionOrigin(System.IntPtr self, Steamworks.InputActionOrigin eOrigin)
- private static Steamworks.Utf8StringPointer _GetStringForXboxOrigin(System.IntPtr self, Steamworks.XboxOrigin eOrigin)
- private static bool _Init(System.IntPtr self)
- private static void _RunFrame(System.IntPtr self)
- private static void _SetLEDColor(System.IntPtr self, Steamworks.Data.InputHandle_t inputHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags)
- private static bool _ShowBindingPanel(System.IntPtr self, Steamworks.Data.InputHandle_t inputHandle)
- private static bool _Shutdown(System.IntPtr self)
- private static void _StopAnalogActionMomentum(System.IntPtr self, Steamworks.Data.InputHandle_t inputHandle, Steamworks.Data.InputAnalogActionHandle_t eAction)
- private static Steamworks.InputActionOrigin _TranslateActionOrigin(System.IntPtr self, Steamworks.InputType eDestinationInputType, Steamworks.InputActionOrigin eSourceOrigin)
- private static void _TriggerHapticPulse(System.IntPtr self, Steamworks.Data.InputHandle_t inputHandle, Steamworks.SteamControllerPad eTargetPad, ushort usDurationMicroSec)
- private static void _TriggerRepeatedHapticPulse(System.IntPtr self, Steamworks.Data.InputHandle_t inputHandle, Steamworks.SteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags)
- private static void _TriggerVibration(System.IntPtr self, Steamworks.Data.InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed)

### internal class Steamworks.ISteamInventory
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamInventory(bool IsGameServer)

#### Methods
- internal bool AddPromoItem(ref Steamworks.Data.SteamInventoryResult_t pResultHandle, Steamworks.Data.InventoryDefId itemDef)
- internal bool AddPromoItems(ref Steamworks.Data.SteamInventoryResult_t pResultHandle, Steamworks.Data.InventoryDefId[] pArrayItemDefs, uint unArrayLength)
- internal bool CheckResultSteamID(Steamworks.Data.SteamInventoryResult_t resultHandle, Steamworks.SteamId steamIDExpected)
- internal bool ConsumeItem(ref Steamworks.Data.SteamInventoryResult_t pResultHandle, Steamworks.Data.InventoryItemId itemConsume, uint unQuantity)
- internal bool DeserializeResult(ref Steamworks.Data.SteamInventoryResult_t pOutResultHandle, System.IntPtr pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE)
- internal void DestroyResult(Steamworks.Data.SteamInventoryResult_t resultHandle)
- internal bool ExchangeItems(ref Steamworks.Data.SteamInventoryResult_t pResultHandle, Steamworks.Data.InventoryDefId[] pArrayGenerate, uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, Steamworks.Data.InventoryItemId[] pArrayDestroy, uint[] punArrayDestroyQuantity, uint unArrayDestroyLength)
- internal bool GenerateItems(ref Steamworks.Data.SteamInventoryResult_t pResultHandle, Steamworks.Data.InventoryDefId[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength)
- internal bool GetAllItems(ref Steamworks.Data.SteamInventoryResult_t pResultHandle)
- internal bool GetEligiblePromoItemDefinitionIDs(Steamworks.SteamId steamID, Steamworks.Data.InventoryDefId[] pItemDefIDs, ref uint punItemDefIDsArraySize)
- internal bool GetItemDefinitionIDs(Steamworks.Data.InventoryDefId[] pItemDefIDs, ref uint punItemDefIDsArraySize)
- internal bool GetItemDefinitionProperty(Steamworks.Data.InventoryDefId iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut)
- internal bool GetItemPrice(Steamworks.Data.InventoryDefId iDefinition, ref ulong pCurrentPrice, ref ulong pBasePrice)
- internal bool GetItemsByID(ref Steamworks.Data.SteamInventoryResult_t pResultHandle, ref Steamworks.Data.InventoryItemId pInstanceIDs, uint unCountInstanceIDs)
- internal bool GetItemsWithPrices(Steamworks.Data.InventoryDefId[] pArrayItemDefs, ulong[] pCurrentPrices, ulong[] pBasePrices, uint unArrayLength)
- internal uint GetNumItemsWithPrices()
- internal bool GetResultItemProperty(Steamworks.Data.SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut)
- internal bool GetResultItems(Steamworks.Data.SteamInventoryResult_t resultHandle, Steamworks.Data.SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize)
- internal Steamworks.Result GetResultStatus(Steamworks.Data.SteamInventoryResult_t resultHandle)
- internal uint GetResultTimestamp(Steamworks.Data.SteamInventoryResult_t resultHandle)
- public override System.IntPtr GetServerInterfacePointer()
- public override System.IntPtr GetUserInterfacePointer()
- internal bool GrantPromoItems(ref Steamworks.Data.SteamInventoryResult_t pResultHandle)
- internal bool LoadItemDefinitions()
- internal bool RemoveProperty(Steamworks.Data.SteamInventoryUpdateHandle_t handle, Steamworks.Data.InventoryItemId nItemID, string pchPropertyName)
- internal Steamworks.CallResult<Steamworks.Data.SteamInventoryEligiblePromoItemDefIDs_t> RequestEligiblePromoItemDefinitionsIDs(Steamworks.SteamId steamID)
- internal Steamworks.CallResult<Steamworks.Data.SteamInventoryRequestPricesResult_t> RequestPrices()
- internal void SendItemDropHeartbeat()
- internal bool SerializeResult(Steamworks.Data.SteamInventoryResult_t resultHandle, System.IntPtr pOutBuffer, ref uint punOutBufferSize)
- internal bool SetProperty(Steamworks.Data.SteamInventoryUpdateHandle_t handle, Steamworks.Data.InventoryItemId nItemID, string pchPropertyName, string pchPropertyValue)
- internal bool SetProperty(Steamworks.Data.SteamInventoryUpdateHandle_t handle, Steamworks.Data.InventoryItemId nItemID, string pchPropertyName, bool bValue)
- internal bool SetProperty(Steamworks.Data.SteamInventoryUpdateHandle_t handle, Steamworks.Data.InventoryItemId nItemID, string pchPropertyName, long nValue)
- internal bool SetProperty(Steamworks.Data.SteamInventoryUpdateHandle_t handle, Steamworks.Data.InventoryItemId nItemID, string pchPropertyName, float flValue)
- internal Steamworks.CallResult<Steamworks.Data.SteamInventoryStartPurchaseResult_t> StartPurchase(Steamworks.Data.InventoryDefId[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength)
- internal Steamworks.Data.SteamInventoryUpdateHandle_t StartUpdateProperties()
- internal static System.IntPtr SteamAPI_SteamGameServerInventory_v003()
- internal static System.IntPtr SteamAPI_SteamInventory_v003()
- internal bool SubmitUpdateProperties(Steamworks.Data.SteamInventoryUpdateHandle_t handle, ref Steamworks.Data.SteamInventoryResult_t pResultHandle)
- internal bool TradeItems(ref Steamworks.Data.SteamInventoryResult_t pResultHandle, Steamworks.SteamId steamIDTradePartner, Steamworks.Data.InventoryItemId[] pArrayGive, uint[] pArrayGiveQuantity, uint nArrayGiveLength, Steamworks.Data.InventoryItemId[] pArrayGet, uint[] pArrayGetQuantity, uint nArrayGetLength)
- internal bool TransferItemQuantity(ref Steamworks.Data.SteamInventoryResult_t pResultHandle, Steamworks.Data.InventoryItemId itemIdSource, uint unQuantity, Steamworks.Data.InventoryItemId itemIdDest)
- internal bool TriggerItemDrop(ref Steamworks.Data.SteamInventoryResult_t pResultHandle, Steamworks.Data.InventoryDefId dropListDefinition)
- private static bool _AddPromoItem(System.IntPtr self, ref Steamworks.Data.SteamInventoryResult_t pResultHandle, Steamworks.Data.InventoryDefId itemDef)
- private static bool _AddPromoItems(System.IntPtr self, ref Steamworks.Data.SteamInventoryResult_t pResultHandle, Steamworks.Data.InventoryDefId[] pArrayItemDefs, uint unArrayLength)
- private static bool _CheckResultSteamID(System.IntPtr self, Steamworks.Data.SteamInventoryResult_t resultHandle, Steamworks.SteamId steamIDExpected)
- private static bool _ConsumeItem(System.IntPtr self, ref Steamworks.Data.SteamInventoryResult_t pResultHandle, Steamworks.Data.InventoryItemId itemConsume, uint unQuantity)
- private static bool _DeserializeResult(System.IntPtr self, ref Steamworks.Data.SteamInventoryResult_t pOutResultHandle, System.IntPtr pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE)
- private static void _DestroyResult(System.IntPtr self, Steamworks.Data.SteamInventoryResult_t resultHandle)
- private static bool _ExchangeItems(System.IntPtr self, ref Steamworks.Data.SteamInventoryResult_t pResultHandle, Steamworks.Data.InventoryDefId[] pArrayGenerate, uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, Steamworks.Data.InventoryItemId[] pArrayDestroy, uint[] punArrayDestroyQuantity, uint unArrayDestroyLength)
- private static bool _GenerateItems(System.IntPtr self, ref Steamworks.Data.SteamInventoryResult_t pResultHandle, Steamworks.Data.InventoryDefId[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength)
- private static bool _GetAllItems(System.IntPtr self, ref Steamworks.Data.SteamInventoryResult_t pResultHandle)
- private static bool _GetEligiblePromoItemDefinitionIDs(System.IntPtr self, Steamworks.SteamId steamID, Steamworks.Data.InventoryDefId[] pItemDefIDs, ref uint punItemDefIDsArraySize)
- private static bool _GetItemDefinitionIDs(System.IntPtr self, Steamworks.Data.InventoryDefId[] pItemDefIDs, ref uint punItemDefIDsArraySize)
- private static bool _GetItemDefinitionProperty(System.IntPtr self, Steamworks.Data.InventoryDefId iDefinition, string pchPropertyName, System.IntPtr pchValueBuffer, ref uint punValueBufferSizeOut)
- private static bool _GetItemPrice(System.IntPtr self, Steamworks.Data.InventoryDefId iDefinition, ref ulong pCurrentPrice, ref ulong pBasePrice)
- private static bool _GetItemsByID(System.IntPtr self, ref Steamworks.Data.SteamInventoryResult_t pResultHandle, ref Steamworks.Data.InventoryItemId pInstanceIDs, uint unCountInstanceIDs)
- private static bool _GetItemsWithPrices(System.IntPtr self, Steamworks.Data.InventoryDefId[] pArrayItemDefs, ulong[] pCurrentPrices, ulong[] pBasePrices, uint unArrayLength)
- private static uint _GetNumItemsWithPrices(System.IntPtr self)
- private static bool _GetResultItemProperty(System.IntPtr self, Steamworks.Data.SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, System.IntPtr pchValueBuffer, ref uint punValueBufferSizeOut)
- private static bool _GetResultItems(System.IntPtr self, Steamworks.Data.SteamInventoryResult_t resultHandle, Steamworks.Data.SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize)
- private static Steamworks.Result _GetResultStatus(System.IntPtr self, Steamworks.Data.SteamInventoryResult_t resultHandle)
- private static uint _GetResultTimestamp(System.IntPtr self, Steamworks.Data.SteamInventoryResult_t resultHandle)
- private static bool _GrantPromoItems(System.IntPtr self, ref Steamworks.Data.SteamInventoryResult_t pResultHandle)
- private static bool _LoadItemDefinitions(System.IntPtr self)
- private static bool _RemoveProperty(System.IntPtr self, Steamworks.Data.SteamInventoryUpdateHandle_t handle, Steamworks.Data.InventoryItemId nItemID, string pchPropertyName)
- private static Steamworks.Data.SteamAPICall_t _RequestEligiblePromoItemDefinitionsIDs(System.IntPtr self, Steamworks.SteamId steamID)
- private static Steamworks.Data.SteamAPICall_t _RequestPrices(System.IntPtr self)
- private static void _SendItemDropHeartbeat(System.IntPtr self)
- private static bool _SerializeResult(System.IntPtr self, Steamworks.Data.SteamInventoryResult_t resultHandle, System.IntPtr pOutBuffer, ref uint punOutBufferSize)
- private static bool _SetProperty(System.IntPtr self, Steamworks.Data.SteamInventoryUpdateHandle_t handle, Steamworks.Data.InventoryItemId nItemID, string pchPropertyName, string pchPropertyValue)
- private static bool _SetProperty(System.IntPtr self, Steamworks.Data.SteamInventoryUpdateHandle_t handle, Steamworks.Data.InventoryItemId nItemID, string pchPropertyName, bool bValue)
- private static bool _SetProperty(System.IntPtr self, Steamworks.Data.SteamInventoryUpdateHandle_t handle, Steamworks.Data.InventoryItemId nItemID, string pchPropertyName, long nValue)
- private static bool _SetProperty(System.IntPtr self, Steamworks.Data.SteamInventoryUpdateHandle_t handle, Steamworks.Data.InventoryItemId nItemID, string pchPropertyName, float flValue)
- private static Steamworks.Data.SteamAPICall_t _StartPurchase(System.IntPtr self, Steamworks.Data.InventoryDefId[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength)
- private static Steamworks.Data.SteamInventoryUpdateHandle_t _StartUpdateProperties(System.IntPtr self)
- private static bool _SubmitUpdateProperties(System.IntPtr self, Steamworks.Data.SteamInventoryUpdateHandle_t handle, ref Steamworks.Data.SteamInventoryResult_t pResultHandle)
- private static bool _TradeItems(System.IntPtr self, ref Steamworks.Data.SteamInventoryResult_t pResultHandle, Steamworks.SteamId steamIDTradePartner, Steamworks.Data.InventoryItemId[] pArrayGive, uint[] pArrayGiveQuantity, uint nArrayGiveLength, Steamworks.Data.InventoryItemId[] pArrayGet, uint[] pArrayGetQuantity, uint nArrayGetLength)
- private static bool _TransferItemQuantity(System.IntPtr self, ref Steamworks.Data.SteamInventoryResult_t pResultHandle, Steamworks.Data.InventoryItemId itemIdSource, uint unQuantity, Steamworks.Data.InventoryItemId itemIdDest)
- private static bool _TriggerItemDrop(System.IntPtr self, ref Steamworks.Data.SteamInventoryResult_t pResultHandle, Steamworks.Data.InventoryDefId dropListDefinition)

### internal class Steamworks.ISteamMatchmaking
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamMatchmaking(bool IsGameServer)

#### Methods
- internal int AddFavoriteGame(Steamworks.AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer)
- internal void AddRequestLobbyListCompatibleMembersFilter(Steamworks.SteamId steamIDLobby)
- internal void AddRequestLobbyListDistanceFilter(Steamworks.LobbyDistanceFilter eLobbyDistanceFilter)
- internal void AddRequestLobbyListFilterSlotsAvailable(int nSlotsAvailable)
- internal void AddRequestLobbyListNearValueFilter(string pchKeyToMatch, int nValueToBeCloseTo)
- internal void AddRequestLobbyListNumericalFilter(string pchKeyToMatch, int nValueToMatch, Steamworks.LobbyComparison eComparisonType)
- internal void AddRequestLobbyListResultCountFilter(int cMaxResults)
- internal void AddRequestLobbyListStringFilter(string pchKeyToMatch, string pchValueToMatch, Steamworks.LobbyComparison eComparisonType)
- internal Steamworks.CallResult<Steamworks.Data.LobbyCreated_t> CreateLobby(Steamworks.LobbyType eLobbyType, int cMaxMembers)
- internal bool DeleteLobbyData(Steamworks.SteamId steamIDLobby, string pchKey)
- internal bool GetFavoriteGame(int iGame, ref Steamworks.AppId pnAppID, ref uint pnIP, ref ushort pnConnPort, ref ushort pnQueryPort, ref uint punFlags, ref uint pRTime32LastPlayedOnServer)
- internal int GetFavoriteGameCount()
- internal Steamworks.SteamId GetLobbyByIndex(int iLobby)
- internal int GetLobbyChatEntry(Steamworks.SteamId steamIDLobby, int iChatID, ref Steamworks.SteamId pSteamIDUser, System.IntPtr pvData, int cubData, ref Steamworks.ChatEntryType peChatEntryType)
- internal string GetLobbyData(Steamworks.SteamId steamIDLobby, string pchKey)
- internal bool GetLobbyDataByIndex(Steamworks.SteamId steamIDLobby, int iLobbyData, out string pchKey, out string pchValue)
- internal int GetLobbyDataCount(Steamworks.SteamId steamIDLobby)
- internal bool GetLobbyGameServer(Steamworks.SteamId steamIDLobby, ref uint punGameServerIP, ref ushort punGameServerPort, ref Steamworks.SteamId psteamIDGameServer)
- internal Steamworks.SteamId GetLobbyMemberByIndex(Steamworks.SteamId steamIDLobby, int iMember)
- internal string GetLobbyMemberData(Steamworks.SteamId steamIDLobby, Steamworks.SteamId steamIDUser, string pchKey)
- internal int GetLobbyMemberLimit(Steamworks.SteamId steamIDLobby)
- internal Steamworks.SteamId GetLobbyOwner(Steamworks.SteamId steamIDLobby)
- internal int GetNumLobbyMembers(Steamworks.SteamId steamIDLobby)
- public override System.IntPtr GetUserInterfacePointer()
- internal bool InviteUserToLobby(Steamworks.SteamId steamIDLobby, Steamworks.SteamId steamIDInvitee)
- internal Steamworks.CallResult<Steamworks.Data.LobbyEnter_t> JoinLobby(Steamworks.SteamId steamIDLobby)
- internal void LeaveLobby(Steamworks.SteamId steamIDLobby)
- internal bool RemoveFavoriteGame(Steamworks.AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags)
- internal bool RequestLobbyData(Steamworks.SteamId steamIDLobby)
- internal Steamworks.CallResult<Steamworks.Data.LobbyMatchList_t> RequestLobbyList()
- internal bool SendLobbyChatMsg(Steamworks.SteamId steamIDLobby, System.IntPtr pvMsgBody, int cubMsgBody)
- internal bool SetLinkedLobby(Steamworks.SteamId steamIDLobby, Steamworks.SteamId steamIDLobbyDependent)
- internal bool SetLobbyData(Steamworks.SteamId steamIDLobby, string pchKey, string pchValue)
- internal void SetLobbyGameServer(Steamworks.SteamId steamIDLobby, uint unGameServerIP, ushort unGameServerPort, Steamworks.SteamId steamIDGameServer)
- internal bool SetLobbyJoinable(Steamworks.SteamId steamIDLobby, bool bLobbyJoinable)
- internal void SetLobbyMemberData(Steamworks.SteamId steamIDLobby, string pchKey, string pchValue)
- internal bool SetLobbyMemberLimit(Steamworks.SteamId steamIDLobby, int cMaxMembers)
- internal bool SetLobbyOwner(Steamworks.SteamId steamIDLobby, Steamworks.SteamId steamIDNewOwner)
- internal bool SetLobbyType(Steamworks.SteamId steamIDLobby, Steamworks.LobbyType eLobbyType)
- internal static System.IntPtr SteamAPI_SteamMatchmaking_v009()
- private static int _AddFavoriteGame(System.IntPtr self, Steamworks.AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer)
- private static void _AddRequestLobbyListCompatibleMembersFilter(System.IntPtr self, Steamworks.SteamId steamIDLobby)
- private static void _AddRequestLobbyListDistanceFilter(System.IntPtr self, Steamworks.LobbyDistanceFilter eLobbyDistanceFilter)
- private static void _AddRequestLobbyListFilterSlotsAvailable(System.IntPtr self, int nSlotsAvailable)
- private static void _AddRequestLobbyListNearValueFilter(System.IntPtr self, string pchKeyToMatch, int nValueToBeCloseTo)
- private static void _AddRequestLobbyListNumericalFilter(System.IntPtr self, string pchKeyToMatch, int nValueToMatch, Steamworks.LobbyComparison eComparisonType)
- private static void _AddRequestLobbyListResultCountFilter(System.IntPtr self, int cMaxResults)
- private static void _AddRequestLobbyListStringFilter(System.IntPtr self, string pchKeyToMatch, string pchValueToMatch, Steamworks.LobbyComparison eComparisonType)
- private static Steamworks.Data.SteamAPICall_t _CreateLobby(System.IntPtr self, Steamworks.LobbyType eLobbyType, int cMaxMembers)
- private static bool _DeleteLobbyData(System.IntPtr self, Steamworks.SteamId steamIDLobby, string pchKey)
- private static bool _GetFavoriteGame(System.IntPtr self, int iGame, ref Steamworks.AppId pnAppID, ref uint pnIP, ref ushort pnConnPort, ref ushort pnQueryPort, ref uint punFlags, ref uint pRTime32LastPlayedOnServer)
- private static int _GetFavoriteGameCount(System.IntPtr self)
- private static Steamworks.SteamId _GetLobbyByIndex(System.IntPtr self, int iLobby)
- private static int _GetLobbyChatEntry(System.IntPtr self, Steamworks.SteamId steamIDLobby, int iChatID, ref Steamworks.SteamId pSteamIDUser, System.IntPtr pvData, int cubData, ref Steamworks.ChatEntryType peChatEntryType)
- private static Steamworks.Utf8StringPointer _GetLobbyData(System.IntPtr self, Steamworks.SteamId steamIDLobby, string pchKey)
- private static bool _GetLobbyDataByIndex(System.IntPtr self, Steamworks.SteamId steamIDLobby, int iLobbyData, System.IntPtr pchKey, int cchKeyBufferSize, System.IntPtr pchValue, int cchValueBufferSize)
- private static int _GetLobbyDataCount(System.IntPtr self, Steamworks.SteamId steamIDLobby)
- private static bool _GetLobbyGameServer(System.IntPtr self, Steamworks.SteamId steamIDLobby, ref uint punGameServerIP, ref ushort punGameServerPort, ref Steamworks.SteamId psteamIDGameServer)
- private static Steamworks.SteamId _GetLobbyMemberByIndex(System.IntPtr self, Steamworks.SteamId steamIDLobby, int iMember)
- private static Steamworks.Utf8StringPointer _GetLobbyMemberData(System.IntPtr self, Steamworks.SteamId steamIDLobby, Steamworks.SteamId steamIDUser, string pchKey)
- private static int _GetLobbyMemberLimit(System.IntPtr self, Steamworks.SteamId steamIDLobby)
- private static Steamworks.SteamId _GetLobbyOwner(System.IntPtr self, Steamworks.SteamId steamIDLobby)
- private static int _GetNumLobbyMembers(System.IntPtr self, Steamworks.SteamId steamIDLobby)
- private static bool _InviteUserToLobby(System.IntPtr self, Steamworks.SteamId steamIDLobby, Steamworks.SteamId steamIDInvitee)
- private static Steamworks.Data.SteamAPICall_t _JoinLobby(System.IntPtr self, Steamworks.SteamId steamIDLobby)
- private static void _LeaveLobby(System.IntPtr self, Steamworks.SteamId steamIDLobby)
- private static bool _RemoveFavoriteGame(System.IntPtr self, Steamworks.AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags)
- private static bool _RequestLobbyData(System.IntPtr self, Steamworks.SteamId steamIDLobby)
- private static Steamworks.Data.SteamAPICall_t _RequestLobbyList(System.IntPtr self)
- private static bool _SendLobbyChatMsg(System.IntPtr self, Steamworks.SteamId steamIDLobby, System.IntPtr pvMsgBody, int cubMsgBody)
- private static bool _SetLinkedLobby(System.IntPtr self, Steamworks.SteamId steamIDLobby, Steamworks.SteamId steamIDLobbyDependent)
- private static bool _SetLobbyData(System.IntPtr self, Steamworks.SteamId steamIDLobby, string pchKey, string pchValue)
- private static void _SetLobbyGameServer(System.IntPtr self, Steamworks.SteamId steamIDLobby, uint unGameServerIP, ushort unGameServerPort, Steamworks.SteamId steamIDGameServer)
- private static bool _SetLobbyJoinable(System.IntPtr self, Steamworks.SteamId steamIDLobby, bool bLobbyJoinable)
- private static void _SetLobbyMemberData(System.IntPtr self, Steamworks.SteamId steamIDLobby, string pchKey, string pchValue)
- private static bool _SetLobbyMemberLimit(System.IntPtr self, Steamworks.SteamId steamIDLobby, int cMaxMembers)
- private static bool _SetLobbyOwner(System.IntPtr self, Steamworks.SteamId steamIDLobby, Steamworks.SteamId steamIDNewOwner)
- private static bool _SetLobbyType(System.IntPtr self, Steamworks.SteamId steamIDLobby, Steamworks.LobbyType eLobbyType)

### internal class Steamworks.ISteamMatchmakingPingResponse
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamMatchmakingPingResponse(bool IsGameServer)

#### Methods
- internal void ServerFailedToRespond()
- internal void ServerResponded(ref Steamworks.Data.gameserveritem_t server)
- private static void _ServerFailedToRespond(System.IntPtr self)
- private static void _ServerResponded(System.IntPtr self, ref Steamworks.Data.gameserveritem_t server)

### internal class Steamworks.ISteamMatchmakingPlayersResponse
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamMatchmakingPlayersResponse(bool IsGameServer)

#### Methods
- internal void AddPlayerToList(string pchName, int nScore, float flTimePlayed)
- internal void PlayersFailedToRespond()
- internal void PlayersRefreshComplete()
- private static void _AddPlayerToList(System.IntPtr self, string pchName, int nScore, float flTimePlayed)
- private static void _PlayersFailedToRespond(System.IntPtr self)
- private static void _PlayersRefreshComplete(System.IntPtr self)

### internal class Steamworks.ISteamMatchmakingRulesResponse
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamMatchmakingRulesResponse(bool IsGameServer)

#### Methods
- internal void RulesFailedToRespond()
- internal void RulesRefreshComplete()
- internal void RulesResponded(string pchRule, string pchValue)
- private static void _RulesFailedToRespond(System.IntPtr self)
- private static void _RulesRefreshComplete(System.IntPtr self)
- private static void _RulesResponded(System.IntPtr self, string pchRule, string pchValue)

### internal class Steamworks.ISteamMatchmakingServerListResponse
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamMatchmakingServerListResponse(bool IsGameServer)

#### Methods
- internal void RefreshComplete(Steamworks.Data.HServerListRequest hRequest, Steamworks.MatchMakingServerResponse response)
- internal void ServerFailedToRespond(Steamworks.Data.HServerListRequest hRequest, int iServer)
- internal void ServerResponded(Steamworks.Data.HServerListRequest hRequest, int iServer)
- private static void _RefreshComplete(System.IntPtr self, Steamworks.Data.HServerListRequest hRequest, Steamworks.MatchMakingServerResponse response)
- private static void _ServerFailedToRespond(System.IntPtr self, Steamworks.Data.HServerListRequest hRequest, int iServer)
- private static void _ServerResponded(System.IntPtr self, Steamworks.Data.HServerListRequest hRequest, int iServer)

### internal class Steamworks.ISteamMatchmakingServers
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamMatchmakingServers(bool IsGameServer)

#### Methods
- internal void CancelQuery(Steamworks.Data.HServerListRequest hRequest)
- internal void CancelServerQuery(Steamworks.Data.HServerQuery hServerQuery)
- internal int GetServerCount(Steamworks.Data.HServerListRequest hRequest)
- internal Steamworks.Data.gameserveritem_t GetServerDetails(Steamworks.Data.HServerListRequest hRequest, int iServer)
- public override System.IntPtr GetUserInterfacePointer()
- internal bool IsRefreshing(Steamworks.Data.HServerListRequest hRequest)
- internal Steamworks.Data.HServerQuery PingServer(uint unIP, ushort usPort, System.IntPtr pRequestServersResponse)
- internal Steamworks.Data.HServerQuery PlayerDetails(uint unIP, ushort usPort, System.IntPtr pRequestServersResponse)
- internal void RefreshQuery(Steamworks.Data.HServerListRequest hRequest)
- internal void RefreshServer(Steamworks.Data.HServerListRequest hRequest, int iServer)
- internal void ReleaseRequest(Steamworks.Data.HServerListRequest hServerListRequest)
- internal Steamworks.Data.HServerListRequest RequestFavoritesServerList(Steamworks.AppId iApp, out Steamworks.Data.MatchMakingKeyValuePair[] ppchFilters, uint nFilters, System.IntPtr pRequestServersResponse)
- internal Steamworks.Data.HServerListRequest RequestFriendsServerList(Steamworks.AppId iApp, out Steamworks.Data.MatchMakingKeyValuePair[] ppchFilters, uint nFilters, System.IntPtr pRequestServersResponse)
- internal Steamworks.Data.HServerListRequest RequestHistoryServerList(Steamworks.AppId iApp, out Steamworks.Data.MatchMakingKeyValuePair[] ppchFilters, uint nFilters, System.IntPtr pRequestServersResponse)
- internal Steamworks.Data.HServerListRequest RequestInternetServerList(Steamworks.AppId iApp, out Steamworks.Data.MatchMakingKeyValuePair[] ppchFilters, uint nFilters, System.IntPtr pRequestServersResponse)
- internal Steamworks.Data.HServerListRequest RequestLANServerList(Steamworks.AppId iApp, System.IntPtr pRequestServersResponse)
- internal Steamworks.Data.HServerListRequest RequestSpectatorServerList(Steamworks.AppId iApp, out Steamworks.Data.MatchMakingKeyValuePair[] ppchFilters, uint nFilters, System.IntPtr pRequestServersResponse)
- internal Steamworks.Data.HServerQuery ServerRules(uint unIP, ushort usPort, System.IntPtr pRequestServersResponse)
- internal static System.IntPtr SteamAPI_SteamMatchmakingServers_v002()
- private static void _CancelQuery(System.IntPtr self, Steamworks.Data.HServerListRequest hRequest)
- private static void _CancelServerQuery(System.IntPtr self, Steamworks.Data.HServerQuery hServerQuery)
- private static int _GetServerCount(System.IntPtr self, Steamworks.Data.HServerListRequest hRequest)
- private static System.IntPtr _GetServerDetails(System.IntPtr self, Steamworks.Data.HServerListRequest hRequest, int iServer)
- private static bool _IsRefreshing(System.IntPtr self, Steamworks.Data.HServerListRequest hRequest)
- private static Steamworks.Data.HServerQuery _PingServer(System.IntPtr self, uint unIP, ushort usPort, System.IntPtr pRequestServersResponse)
- private static Steamworks.Data.HServerQuery _PlayerDetails(System.IntPtr self, uint unIP, ushort usPort, System.IntPtr pRequestServersResponse)
- private static void _RefreshQuery(System.IntPtr self, Steamworks.Data.HServerListRequest hRequest)
- private static void _RefreshServer(System.IntPtr self, Steamworks.Data.HServerListRequest hRequest, int iServer)
- private static void _ReleaseRequest(System.IntPtr self, Steamworks.Data.HServerListRequest hServerListRequest)
- private static Steamworks.Data.HServerListRequest _RequestFavoritesServerList(System.IntPtr self, Steamworks.AppId iApp, out Steamworks.Data.MatchMakingKeyValuePair[] ppchFilters, uint nFilters, System.IntPtr pRequestServersResponse)
- private static Steamworks.Data.HServerListRequest _RequestFriendsServerList(System.IntPtr self, Steamworks.AppId iApp, out Steamworks.Data.MatchMakingKeyValuePair[] ppchFilters, uint nFilters, System.IntPtr pRequestServersResponse)
- private static Steamworks.Data.HServerListRequest _RequestHistoryServerList(System.IntPtr self, Steamworks.AppId iApp, out Steamworks.Data.MatchMakingKeyValuePair[] ppchFilters, uint nFilters, System.IntPtr pRequestServersResponse)
- private static Steamworks.Data.HServerListRequest _RequestInternetServerList(System.IntPtr self, Steamworks.AppId iApp, out Steamworks.Data.MatchMakingKeyValuePair[] ppchFilters, uint nFilters, System.IntPtr pRequestServersResponse)
- private static Steamworks.Data.HServerListRequest _RequestLANServerList(System.IntPtr self, Steamworks.AppId iApp, System.IntPtr pRequestServersResponse)
- private static Steamworks.Data.HServerListRequest _RequestSpectatorServerList(System.IntPtr self, Steamworks.AppId iApp, out Steamworks.Data.MatchMakingKeyValuePair[] ppchFilters, uint nFilters, System.IntPtr pRequestServersResponse)
- private static Steamworks.Data.HServerQuery _ServerRules(System.IntPtr self, uint unIP, ushort usPort, System.IntPtr pRequestServersResponse)

### internal class Steamworks.ISteamMusic
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamMusic(bool IsGameServer)

#### Methods
- internal bool BIsEnabled()
- internal bool BIsPlaying()
- internal Steamworks.MusicStatus GetPlaybackStatus()
- public override System.IntPtr GetUserInterfacePointer()
- internal float GetVolume()
- internal void Pause()
- internal void Play()
- internal void PlayNext()
- internal void PlayPrevious()
- internal void SetVolume(float flVolume)
- internal static System.IntPtr SteamAPI_SteamMusic_v001()
- private static bool _BIsEnabled(System.IntPtr self)
- private static bool _BIsPlaying(System.IntPtr self)
- private static Steamworks.MusicStatus _GetPlaybackStatus(System.IntPtr self)
- private static float _GetVolume(System.IntPtr self)
- private static void _Pause(System.IntPtr self)
- private static void _Play(System.IntPtr self)
- private static void _PlayNext(System.IntPtr self)
- private static void _PlayPrevious(System.IntPtr self)
- private static void _SetVolume(System.IntPtr self, float flVolume)

### internal class Steamworks.ISteamMusicRemote
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamMusicRemote(bool IsGameServer)

#### Methods
- internal bool BActivationSuccess(bool bValue)
- internal bool BIsCurrentMusicRemote()
- internal bool CurrentEntryDidChange()
- internal bool CurrentEntryIsAvailable(bool bAvailable)
- internal bool CurrentEntryWillChange()
- internal bool DeregisterSteamMusicRemote()
- internal bool EnableLooped(bool bValue)
- internal bool EnablePlaylists(bool bValue)
- internal bool EnablePlayNext(bool bValue)
- internal bool EnablePlayPrevious(bool bValue)
- internal bool EnableQueue(bool bValue)
- internal bool EnableShuffled(bool bValue)
- public override System.IntPtr GetUserInterfacePointer()
- internal bool PlaylistDidChange()
- internal bool PlaylistWillChange()
- internal bool QueueDidChange()
- internal bool QueueWillChange()
- internal bool RegisterSteamMusicRemote(string pchName)
- internal bool ResetPlaylistEntries()
- internal bool ResetQueueEntries()
- internal bool SetCurrentPlaylistEntry(int nID)
- internal bool SetCurrentQueueEntry(int nID)
- internal bool SetDisplayName(string pchDisplayName)
- internal bool SetPlaylistEntry(int nID, int nPosition, string pchEntryText)
- internal bool SetPNGIcon_64x64(System.IntPtr pvBuffer, uint cbBufferLength)
- internal bool SetQueueEntry(int nID, int nPosition, string pchEntryText)
- internal static System.IntPtr SteamAPI_SteamMusicRemote_v001()
- internal bool UpdateCurrentEntryCoverArt(System.IntPtr pvBuffer, uint cbBufferLength)
- internal bool UpdateCurrentEntryElapsedSeconds(int nValue)
- internal bool UpdateCurrentEntryText(string pchText)
- internal bool UpdateLooped(bool bValue)
- internal bool UpdatePlaybackStatus(Steamworks.MusicStatus nStatus)
- internal bool UpdateShuffled(bool bValue)
- internal bool UpdateVolume(float flValue)
- private static bool _BActivationSuccess(System.IntPtr self, bool bValue)
- private static bool _BIsCurrentMusicRemote(System.IntPtr self)
- private static bool _CurrentEntryDidChange(System.IntPtr self)
- private static bool _CurrentEntryIsAvailable(System.IntPtr self, bool bAvailable)
- private static bool _CurrentEntryWillChange(System.IntPtr self)
- private static bool _DeregisterSteamMusicRemote(System.IntPtr self)
- private static bool _EnableLooped(System.IntPtr self, bool bValue)
- private static bool _EnablePlaylists(System.IntPtr self, bool bValue)
- private static bool _EnablePlayNext(System.IntPtr self, bool bValue)
- private static bool _EnablePlayPrevious(System.IntPtr self, bool bValue)
- private static bool _EnableQueue(System.IntPtr self, bool bValue)
- private static bool _EnableShuffled(System.IntPtr self, bool bValue)
- private static bool _PlaylistDidChange(System.IntPtr self)
- private static bool _PlaylistWillChange(System.IntPtr self)
- private static bool _QueueDidChange(System.IntPtr self)
- private static bool _QueueWillChange(System.IntPtr self)
- private static bool _RegisterSteamMusicRemote(System.IntPtr self, string pchName)
- private static bool _ResetPlaylistEntries(System.IntPtr self)
- private static bool _ResetQueueEntries(System.IntPtr self)
- private static bool _SetCurrentPlaylistEntry(System.IntPtr self, int nID)
- private static bool _SetCurrentQueueEntry(System.IntPtr self, int nID)
- private static bool _SetDisplayName(System.IntPtr self, string pchDisplayName)
- private static bool _SetPlaylistEntry(System.IntPtr self, int nID, int nPosition, string pchEntryText)
- private static bool _SetPNGIcon_64x64(System.IntPtr self, System.IntPtr pvBuffer, uint cbBufferLength)
- private static bool _SetQueueEntry(System.IntPtr self, int nID, int nPosition, string pchEntryText)
- private static bool _UpdateCurrentEntryCoverArt(System.IntPtr self, System.IntPtr pvBuffer, uint cbBufferLength)
- private static bool _UpdateCurrentEntryElapsedSeconds(System.IntPtr self, int nValue)
- private static bool _UpdateCurrentEntryText(System.IntPtr self, string pchText)
- private static bool _UpdateLooped(System.IntPtr self, bool bValue)
- private static bool _UpdatePlaybackStatus(System.IntPtr self, Steamworks.MusicStatus nStatus)
- private static bool _UpdateShuffled(System.IntPtr self, bool bValue)
- private static bool _UpdateVolume(System.IntPtr self, float flValue)

### internal class Steamworks.ISteamNetworking
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamNetworking(bool IsGameServer)

#### Methods
- internal bool AcceptP2PSessionWithUser(Steamworks.SteamId steamIDRemote)
- internal bool AllowP2PPacketRelay(bool bAllow)
- internal bool CloseP2PChannelWithUser(Steamworks.SteamId steamIDRemote, int nChannel)
- internal bool CloseP2PSessionWithUser(Steamworks.SteamId steamIDRemote)
- internal Steamworks.Data.SNetSocket_t CreateP2PConnectionSocket(Steamworks.SteamId steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay)
- internal bool GetP2PSessionState(Steamworks.SteamId steamIDRemote, ref Steamworks.Data.P2PSessionState_t pConnectionState)
- public override System.IntPtr GetServerInterfacePointer()
- public override System.IntPtr GetUserInterfacePointer()
- internal bool IsP2PPacketAvailable(ref uint pcubMsgSize, int nChannel)
- internal bool ReadP2PPacket(System.IntPtr pubDest, uint cubDest, ref uint pcubMsgSize, ref Steamworks.SteamId psteamIDRemote, int nChannel)
- internal bool SendP2PPacket(Steamworks.SteamId steamIDRemote, System.IntPtr pubData, uint cubData, Steamworks.P2PSend eP2PSendType, int nChannel)
- internal static System.IntPtr SteamAPI_SteamGameServerNetworking_v006()
- internal static System.IntPtr SteamAPI_SteamNetworking_v006()
- private static bool _AcceptP2PSessionWithUser(System.IntPtr self, Steamworks.SteamId steamIDRemote)
- private static bool _AllowP2PPacketRelay(System.IntPtr self, bool bAllow)
- private static bool _CloseP2PChannelWithUser(System.IntPtr self, Steamworks.SteamId steamIDRemote, int nChannel)
- private static bool _CloseP2PSessionWithUser(System.IntPtr self, Steamworks.SteamId steamIDRemote)
- private static Steamworks.Data.SNetSocket_t _CreateP2PConnectionSocket(System.IntPtr self, Steamworks.SteamId steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay)
- private static bool _GetP2PSessionState(System.IntPtr self, Steamworks.SteamId steamIDRemote, ref Steamworks.Data.P2PSessionState_t pConnectionState)
- private static bool _IsP2PPacketAvailable(System.IntPtr self, ref uint pcubMsgSize, int nChannel)
- private static bool _ReadP2PPacket(System.IntPtr self, System.IntPtr pubDest, uint cubDest, ref uint pcubMsgSize, ref Steamworks.SteamId psteamIDRemote, int nChannel)
- private static bool _SendP2PPacket(System.IntPtr self, Steamworks.SteamId steamIDRemote, System.IntPtr pubData, uint cubData, Steamworks.P2PSend eP2PSendType, int nChannel)

### internal class Steamworks.ISteamNetworkingConnectionCustomSignaling
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamNetworkingConnectionCustomSignaling(bool IsGameServer)

#### Methods
- internal void Release()
- internal bool SendSignal(Steamworks.Data.Connection hConn, ref Steamworks.Data.ConnectionInfo info, System.IntPtr pMsg, int cbMsg)
- private static void _Release(System.IntPtr self)
- private static bool _SendSignal(System.IntPtr self, Steamworks.Data.Connection hConn, ref Steamworks.Data.ConnectionInfo info, System.IntPtr pMsg, int cbMsg)

### internal class Steamworks.ISteamNetworkingCustomSignalingRecvContext
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamNetworkingCustomSignalingRecvContext(bool IsGameServer)

#### Methods
- internal System.IntPtr OnConnectRequest(Steamworks.Data.Connection hConn, ref Steamworks.Data.NetIdentity identityPeer)
- internal void SendRejectionSignal(ref Steamworks.Data.NetIdentity identityPeer, System.IntPtr pMsg, int cbMsg)
- private static System.IntPtr _OnConnectRequest(System.IntPtr self, Steamworks.Data.Connection hConn, ref Steamworks.Data.NetIdentity identityPeer)
- private static void _SendRejectionSignal(System.IntPtr self, ref Steamworks.Data.NetIdentity identityPeer, System.IntPtr pMsg, int cbMsg)

### internal class Steamworks.ISteamNetworkingSockets
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamNetworkingSockets(bool IsGameServer)

#### Methods
- internal Steamworks.Result AcceptConnection(Steamworks.Data.Connection hConn)
- internal bool CloseConnection(Steamworks.Data.Connection hPeer, int nReason, string pszDebug, bool bEnableLinger)
- internal bool CloseListenSocket(Steamworks.Data.Socket hSocket)
- internal Steamworks.Data.Connection ConnectByIPAddress(ref Steamworks.Data.NetAddress address, int nOptions, Steamworks.Data.NetKeyValue[] pOptions)
- internal Steamworks.Data.Connection ConnectP2P(ref Steamworks.Data.NetIdentity identityRemote, int nVirtualPort, int nOptions, Steamworks.Data.NetKeyValue[] pOptions)
- internal Steamworks.Data.Connection ConnectP2PCustomSignaling(System.IntPtr pSignaling, ref Steamworks.Data.NetIdentity pPeerIdentity, int nOptions, Steamworks.Data.NetKeyValue[] pOptions)
- internal Steamworks.Data.Connection ConnectToHostedDedicatedServer(ref Steamworks.Data.NetIdentity identityTarget, int nVirtualPort, int nOptions, Steamworks.Data.NetKeyValue[] pOptions)
- internal Steamworks.Data.Socket CreateHostedDedicatedServerListenSocket(int nVirtualPort, int nOptions, Steamworks.Data.NetKeyValue[] pOptions)
- internal Steamworks.Data.Socket CreateListenSocketIP(ref Steamworks.Data.NetAddress localAddress, int nOptions, Steamworks.Data.NetKeyValue[] pOptions)
- internal Steamworks.Data.Socket CreateListenSocketP2P(int nVirtualPort, int nOptions, Steamworks.Data.NetKeyValue[] pOptions)
- internal Steamworks.Data.HSteamNetPollGroup CreatePollGroup()
- internal bool CreateSocketPair(Steamworks.Data.Connection[] pOutConnection1, Steamworks.Data.Connection[] pOutConnection2, bool bUseNetworkLoopback, ref Steamworks.Data.NetIdentity pIdentity1, ref Steamworks.Data.NetIdentity pIdentity2)
- internal bool DestroyPollGroup(Steamworks.Data.HSteamNetPollGroup hPollGroup)
- internal int FindRelayAuthTicketForServer(ref Steamworks.Data.NetIdentity identityGameServer, int nVirtualPort, Steamworks.Data.SteamDatagramRelayAuthTicket[] pOutParsedTicket)
- internal Steamworks.Result FlushMessagesOnConnection(Steamworks.Data.Connection hConn)
- internal Steamworks.SteamNetworkingAvailability GetAuthenticationStatus(ref Steamworks.Data.SteamNetAuthenticationStatus_t pDetails)
- internal bool GetCertificateRequest(ref int pcbBlob, System.IntPtr pBlob, ref Steamworks.Data.NetErrorMessage errMsg)
- internal bool GetConnectionInfo(Steamworks.Data.Connection hConn, ref Steamworks.Data.ConnectionInfo pInfo)
- internal bool GetConnectionName(Steamworks.Data.Connection hPeer, out string pszName)
- internal long GetConnectionUserData(Steamworks.Data.Connection hPeer)
- internal int GetDetailedConnectionStatus(Steamworks.Data.Connection hConn, out string pszBuf)
- internal Steamworks.Result GetGameCoordinatorServerLogin(ref Steamworks.Data.SteamDatagramGameCoordinatorServerLogin pLoginInfo, ref int pcbSignedBlob, System.IntPtr pBlob)
- internal Steamworks.Result GetHostedDedicatedServerAddress(ref Steamworks.Data.SteamDatagramHostedAddress pRouting)
- internal Steamworks.Data.SteamNetworkingPOPID GetHostedDedicatedServerPOPID()
- internal ushort GetHostedDedicatedServerPort()
- internal bool GetIdentity(ref Steamworks.Data.NetIdentity pIdentity)
- internal bool GetListenSocketAddress(Steamworks.Data.Socket hSocket, ref Steamworks.Data.NetAddress address)
- internal bool GetQuickConnectionStatus(Steamworks.Data.Connection hConn, ref Steamworks.Data.SteamNetworkingQuickConnectionStatus pStats)
- public override System.IntPtr GetServerInterfacePointer()
- public override System.IntPtr GetUserInterfacePointer()
- internal Steamworks.SteamNetworkingAvailability InitAuthentication()
- internal bool ReceivedP2PCustomSignal(System.IntPtr pMsg, int cbMsg, System.IntPtr pContext)
- internal bool ReceivedRelayAuthTicket(System.IntPtr pvTicket, int cbTicket, Steamworks.Data.SteamDatagramRelayAuthTicket[] pOutParsedTicket)
- internal int ReceiveMessagesOnConnection(Steamworks.Data.Connection hConn, System.IntPtr ppOutMessages, int nMaxMessages)
- internal int ReceiveMessagesOnPollGroup(Steamworks.Data.HSteamNetPollGroup hPollGroup, System.IntPtr ppOutMessages, int nMaxMessages)
- internal void SendMessages(int nMessages, ref Steamworks.Data.NetMsg pMessages, long[] pOutMessageNumberOrResult)
- internal Steamworks.Result SendMessageToConnection(Steamworks.Data.Connection hConn, System.IntPtr pData, uint cbData, int nSendFlags, ref long pOutMessageNumber)
- internal bool SetCertificate(System.IntPtr pCertificate, int cbCertificate, ref Steamworks.Data.NetErrorMessage errMsg)
- internal void SetConnectionName(Steamworks.Data.Connection hPeer, string pszName)
- internal bool SetConnectionPollGroup(Steamworks.Data.Connection hConn, Steamworks.Data.HSteamNetPollGroup hPollGroup)
- internal bool SetConnectionUserData(Steamworks.Data.Connection hPeer, long nUserData)
- internal static System.IntPtr SteamAPI_SteamGameServerNetworkingSockets_v008()
- internal static System.IntPtr SteamAPI_SteamNetworkingSockets_v008()
- private static Steamworks.Result _AcceptConnection(System.IntPtr self, Steamworks.Data.Connection hConn)
- private static bool _CloseConnection(System.IntPtr self, Steamworks.Data.Connection hPeer, int nReason, string pszDebug, bool bEnableLinger)
- private static bool _CloseListenSocket(System.IntPtr self, Steamworks.Data.Socket hSocket)
- private static Steamworks.Data.Connection _ConnectByIPAddress(System.IntPtr self, ref Steamworks.Data.NetAddress address, int nOptions, Steamworks.Data.NetKeyValue[] pOptions)
- private static Steamworks.Data.Connection _ConnectP2P(System.IntPtr self, ref Steamworks.Data.NetIdentity identityRemote, int nVirtualPort, int nOptions, Steamworks.Data.NetKeyValue[] pOptions)
- private static Steamworks.Data.Connection _ConnectP2PCustomSignaling(System.IntPtr self, System.IntPtr pSignaling, ref Steamworks.Data.NetIdentity pPeerIdentity, int nOptions, Steamworks.Data.NetKeyValue[] pOptions)
- private static Steamworks.Data.Connection _ConnectToHostedDedicatedServer(System.IntPtr self, ref Steamworks.Data.NetIdentity identityTarget, int nVirtualPort, int nOptions, Steamworks.Data.NetKeyValue[] pOptions)
- private static Steamworks.Data.Socket _CreateHostedDedicatedServerListenSocket(System.IntPtr self, int nVirtualPort, int nOptions, Steamworks.Data.NetKeyValue[] pOptions)
- private static Steamworks.Data.Socket _CreateListenSocketIP(System.IntPtr self, ref Steamworks.Data.NetAddress localAddress, int nOptions, Steamworks.Data.NetKeyValue[] pOptions)
- private static Steamworks.Data.Socket _CreateListenSocketP2P(System.IntPtr self, int nVirtualPort, int nOptions, Steamworks.Data.NetKeyValue[] pOptions)
- private static Steamworks.Data.HSteamNetPollGroup _CreatePollGroup(System.IntPtr self)
- private static bool _CreateSocketPair(System.IntPtr self, Steamworks.Data.Connection[] pOutConnection1, Steamworks.Data.Connection[] pOutConnection2, bool bUseNetworkLoopback, ref Steamworks.Data.NetIdentity pIdentity1, ref Steamworks.Data.NetIdentity pIdentity2)
- private static bool _DestroyPollGroup(System.IntPtr self, Steamworks.Data.HSteamNetPollGroup hPollGroup)
- private static int _FindRelayAuthTicketForServer(System.IntPtr self, ref Steamworks.Data.NetIdentity identityGameServer, int nVirtualPort, Steamworks.Data.SteamDatagramRelayAuthTicket[] pOutParsedTicket)
- private static Steamworks.Result _FlushMessagesOnConnection(System.IntPtr self, Steamworks.Data.Connection hConn)
- private static Steamworks.SteamNetworkingAvailability _GetAuthenticationStatus(System.IntPtr self, ref Steamworks.Data.SteamNetAuthenticationStatus_t pDetails)
- private static bool _GetCertificateRequest(System.IntPtr self, ref int pcbBlob, System.IntPtr pBlob, ref Steamworks.Data.NetErrorMessage errMsg)
- private static bool _GetConnectionInfo(System.IntPtr self, Steamworks.Data.Connection hConn, ref Steamworks.Data.ConnectionInfo pInfo)
- private static bool _GetConnectionName(System.IntPtr self, Steamworks.Data.Connection hPeer, System.IntPtr pszName, int nMaxLen)
- private static long _GetConnectionUserData(System.IntPtr self, Steamworks.Data.Connection hPeer)
- private static int _GetDetailedConnectionStatus(System.IntPtr self, Steamworks.Data.Connection hConn, System.IntPtr pszBuf, int cbBuf)
- private static Steamworks.Result _GetGameCoordinatorServerLogin(System.IntPtr self, ref Steamworks.Data.SteamDatagramGameCoordinatorServerLogin pLoginInfo, ref int pcbSignedBlob, System.IntPtr pBlob)
- private static Steamworks.Result _GetHostedDedicatedServerAddress(System.IntPtr self, ref Steamworks.Data.SteamDatagramHostedAddress pRouting)
- private static Steamworks.Data.SteamNetworkingPOPID _GetHostedDedicatedServerPOPID(System.IntPtr self)
- private static ushort _GetHostedDedicatedServerPort(System.IntPtr self)
- private static bool _GetIdentity(System.IntPtr self, ref Steamworks.Data.NetIdentity pIdentity)
- private static bool _GetListenSocketAddress(System.IntPtr self, Steamworks.Data.Socket hSocket, ref Steamworks.Data.NetAddress address)
- private static bool _GetQuickConnectionStatus(System.IntPtr self, Steamworks.Data.Connection hConn, ref Steamworks.Data.SteamNetworkingQuickConnectionStatus pStats)
- private static Steamworks.SteamNetworkingAvailability _InitAuthentication(System.IntPtr self)
- private static bool _ReceivedP2PCustomSignal(System.IntPtr self, System.IntPtr pMsg, int cbMsg, System.IntPtr pContext)
- private static bool _ReceivedRelayAuthTicket(System.IntPtr self, System.IntPtr pvTicket, int cbTicket, Steamworks.Data.SteamDatagramRelayAuthTicket[] pOutParsedTicket)
- private static int _ReceiveMessagesOnConnection(System.IntPtr self, Steamworks.Data.Connection hConn, System.IntPtr ppOutMessages, int nMaxMessages)
- private static int _ReceiveMessagesOnPollGroup(System.IntPtr self, Steamworks.Data.HSteamNetPollGroup hPollGroup, System.IntPtr ppOutMessages, int nMaxMessages)
- private static void _SendMessages(System.IntPtr self, int nMessages, ref Steamworks.Data.NetMsg pMessages, long[] pOutMessageNumberOrResult)
- private static Steamworks.Result _SendMessageToConnection(System.IntPtr self, Steamworks.Data.Connection hConn, System.IntPtr pData, uint cbData, int nSendFlags, ref long pOutMessageNumber)
- private static bool _SetCertificate(System.IntPtr self, System.IntPtr pCertificate, int cbCertificate, ref Steamworks.Data.NetErrorMessage errMsg)
- private static void _SetConnectionName(System.IntPtr self, Steamworks.Data.Connection hPeer, string pszName)
- private static bool _SetConnectionPollGroup(System.IntPtr self, Steamworks.Data.Connection hConn, Steamworks.Data.HSteamNetPollGroup hPollGroup)
- private static bool _SetConnectionUserData(System.IntPtr self, Steamworks.Data.Connection hPeer, long nUserData)

### internal class Steamworks.ISteamNetworkingUtils
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamNetworkingUtils(bool IsGameServer)

#### Methods
- internal Steamworks.Data.NetMsg AllocateMessage(int cbAllocateBuffer)
- internal bool CheckPingDataUpToDate(float flMaxAgeSeconds)
- internal void ConvertPingLocationToString(ref Steamworks.Data.NetPingLocation location, out string pszBuf)
- internal int EstimatePingTimeBetweenTwoLocations(ref Steamworks.Data.NetPingLocation location1, ref Steamworks.Data.NetPingLocation location2)
- internal int EstimatePingTimeFromLocalHost(ref Steamworks.Data.NetPingLocation remoteLocation)
- internal Steamworks.NetConfigResult GetConfigValue(Steamworks.NetConfig eValue, Steamworks.NetConfigScope eScopeType, System.IntPtr scopeObj, ref Steamworks.NetConfigType pOutDataType, System.IntPtr pResult, ref System.UIntPtr cbResult)
- internal bool GetConfigValueInfo(Steamworks.NetConfig eValue, string pOutName, ref Steamworks.NetConfigType pOutDataType, Steamworks.NetConfigScope[] pOutScope, Steamworks.NetConfig[] pOutNextValue)
- internal int GetDirectPingToPOP(Steamworks.Data.SteamNetworkingPOPID popID)
- internal Steamworks.NetConfig GetFirstConfigValue()
- public override System.IntPtr GetGlobalInterfacePointer()
- internal float GetLocalPingLocation(ref Steamworks.Data.NetPingLocation result)
- internal long GetLocalTimestamp()
- internal int GetPingToDataCenter(Steamworks.Data.SteamNetworkingPOPID popID, ref Steamworks.Data.SteamNetworkingPOPID pViaRelayPoP)
- internal int GetPOPCount()
- internal int GetPOPList(ref Steamworks.Data.SteamNetworkingPOPID list, int nListSz)
- internal Steamworks.SteamNetworkingAvailability GetRelayNetworkStatus(ref Steamworks.Data.SteamRelayNetworkStatus_t pDetails)
- internal void InitRelayNetworkAccess()
- internal bool ParsePingLocationString(string pszString, ref Steamworks.Data.NetPingLocation result)
- internal bool SetConfigValue(Steamworks.NetConfig eValue, Steamworks.NetConfigScope eScopeType, System.IntPtr scopeObj, Steamworks.NetConfigType eDataType, System.IntPtr pArg)
- internal bool SetConfigValueStruct(ref Steamworks.Data.NetKeyValue opt, Steamworks.NetConfigScope eScopeType, System.IntPtr scopeObj)
- internal bool SetConnectionConfigValueFloat(Steamworks.Data.Connection hConn, Steamworks.NetConfig eValue, float val)
- internal bool SetConnectionConfigValueInt32(Steamworks.Data.Connection hConn, Steamworks.NetConfig eValue, int val)
- internal bool SetConnectionConfigValueString(Steamworks.Data.Connection hConn, Steamworks.NetConfig eValue, string val)
- internal void SetDebugOutputFunction(Steamworks.NetDebugOutput eDetailLevel, Steamworks.Data.NetDebugFunc pfnFunc)
- internal bool SetGlobalConfigValueFloat(Steamworks.NetConfig eValue, float val)
- internal bool SetGlobalConfigValueInt32(Steamworks.NetConfig eValue, int val)
- internal bool SetGlobalConfigValueString(Steamworks.NetConfig eValue, string val)
- internal static System.IntPtr SteamAPI_SteamNetworkingUtils_v003()
- internal bool SteamNetworkingIdentity_ParseString(ref Steamworks.Data.NetIdentity pIdentity, string pszStr)
- internal void SteamNetworkingIdentity_ToString(ref Steamworks.Data.NetIdentity identity, out string buf)
- internal bool SteamNetworkingIPAddr_ParseString(ref Steamworks.Data.NetAddress pAddr, string pszStr)
- internal void SteamNetworkingIPAddr_ToString(ref Steamworks.Data.NetAddress addr, out string buf, bool bWithPort)
- private static System.IntPtr _AllocateMessage(System.IntPtr self, int cbAllocateBuffer)
- private static bool _CheckPingDataUpToDate(System.IntPtr self, float flMaxAgeSeconds)
- private static void _ConvertPingLocationToString(System.IntPtr self, ref Steamworks.Data.NetPingLocation location, System.IntPtr pszBuf, int cchBufSize)
- private static int _EstimatePingTimeBetweenTwoLocations(System.IntPtr self, ref Steamworks.Data.NetPingLocation location1, ref Steamworks.Data.NetPingLocation location2)
- private static int _EstimatePingTimeFromLocalHost(System.IntPtr self, ref Steamworks.Data.NetPingLocation remoteLocation)
- private static Steamworks.NetConfigResult _GetConfigValue(System.IntPtr self, Steamworks.NetConfig eValue, Steamworks.NetConfigScope eScopeType, System.IntPtr scopeObj, ref Steamworks.NetConfigType pOutDataType, System.IntPtr pResult, ref System.UIntPtr cbResult)
- private static bool _GetConfigValueInfo(System.IntPtr self, Steamworks.NetConfig eValue, string pOutName, ref Steamworks.NetConfigType pOutDataType, Steamworks.NetConfigScope[] pOutScope, Steamworks.NetConfig[] pOutNextValue)
- private static int _GetDirectPingToPOP(System.IntPtr self, Steamworks.Data.SteamNetworkingPOPID popID)
- private static Steamworks.NetConfig _GetFirstConfigValue(System.IntPtr self)
- private static float _GetLocalPingLocation(System.IntPtr self, ref Steamworks.Data.NetPingLocation result)
- private static long _GetLocalTimestamp(System.IntPtr self)
- private static int _GetPingToDataCenter(System.IntPtr self, Steamworks.Data.SteamNetworkingPOPID popID, ref Steamworks.Data.SteamNetworkingPOPID pViaRelayPoP)
- private static int _GetPOPCount(System.IntPtr self)
- private static int _GetPOPList(System.IntPtr self, ref Steamworks.Data.SteamNetworkingPOPID list, int nListSz)
- private static Steamworks.SteamNetworkingAvailability _GetRelayNetworkStatus(System.IntPtr self, ref Steamworks.Data.SteamRelayNetworkStatus_t pDetails)
- private static void _InitRelayNetworkAccess(System.IntPtr self)
- private static bool _ParsePingLocationString(System.IntPtr self, string pszString, ref Steamworks.Data.NetPingLocation result)
- private static bool _SetConfigValue(System.IntPtr self, Steamworks.NetConfig eValue, Steamworks.NetConfigScope eScopeType, System.IntPtr scopeObj, Steamworks.NetConfigType eDataType, System.IntPtr pArg)
- private static bool _SetConfigValueStruct(System.IntPtr self, ref Steamworks.Data.NetKeyValue opt, Steamworks.NetConfigScope eScopeType, System.IntPtr scopeObj)
- private static bool _SetConnectionConfigValueFloat(System.IntPtr self, Steamworks.Data.Connection hConn, Steamworks.NetConfig eValue, float val)
- private static bool _SetConnectionConfigValueInt32(System.IntPtr self, Steamworks.Data.Connection hConn, Steamworks.NetConfig eValue, int val)
- private static bool _SetConnectionConfigValueString(System.IntPtr self, Steamworks.Data.Connection hConn, Steamworks.NetConfig eValue, string val)
- private static void _SetDebugOutputFunction(System.IntPtr self, Steamworks.NetDebugOutput eDetailLevel, Steamworks.Data.NetDebugFunc pfnFunc)
- private static bool _SetGlobalConfigValueFloat(System.IntPtr self, Steamworks.NetConfig eValue, float val)
- private static bool _SetGlobalConfigValueInt32(System.IntPtr self, Steamworks.NetConfig eValue, int val)
- private static bool _SetGlobalConfigValueString(System.IntPtr self, Steamworks.NetConfig eValue, string val)
- private static bool _SteamNetworkingIdentity_ParseString(System.IntPtr self, ref Steamworks.Data.NetIdentity pIdentity, string pszStr)
- private static void _SteamNetworkingIdentity_ToString(System.IntPtr self, ref Steamworks.Data.NetIdentity identity, System.IntPtr buf, uint cbBuf)
- private static bool _SteamNetworkingIPAddr_ParseString(System.IntPtr self, ref Steamworks.Data.NetAddress pAddr, string pszStr)
- private static void _SteamNetworkingIPAddr_ToString(System.IntPtr self, ref Steamworks.Data.NetAddress addr, System.IntPtr buf, uint cbBuf, bool bWithPort)

### internal class Steamworks.ISteamParentalSettings
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamParentalSettings(bool IsGameServer)

#### Methods
- internal bool BIsAppBlocked(Steamworks.AppId nAppID)
- internal bool BIsAppInBlockList(Steamworks.AppId nAppID)
- internal bool BIsFeatureBlocked(Steamworks.ParentalFeature eFeature)
- internal bool BIsFeatureInBlockList(Steamworks.ParentalFeature eFeature)
- internal bool BIsParentalLockEnabled()
- internal bool BIsParentalLockLocked()
- public override System.IntPtr GetUserInterfacePointer()
- internal static System.IntPtr SteamAPI_SteamParentalSettings_v001()
- private static bool _BIsAppBlocked(System.IntPtr self, Steamworks.AppId nAppID)
- private static bool _BIsAppInBlockList(System.IntPtr self, Steamworks.AppId nAppID)
- private static bool _BIsFeatureBlocked(System.IntPtr self, Steamworks.ParentalFeature eFeature)
- private static bool _BIsFeatureInBlockList(System.IntPtr self, Steamworks.ParentalFeature eFeature)
- private static bool _BIsParentalLockEnabled(System.IntPtr self)
- private static bool _BIsParentalLockLocked(System.IntPtr self)

### internal class Steamworks.ISteamParties
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamParties(bool IsGameServer)

#### Methods
- internal void CancelReservation(Steamworks.Data.PartyBeaconID_t ulBeacon, Steamworks.SteamId steamIDUser)
- internal Steamworks.CallResult<Steamworks.Data.ChangeNumOpenSlotsCallback_t> ChangeNumOpenSlots(Steamworks.Data.PartyBeaconID_t ulBeacon, uint unOpenSlots)
- internal Steamworks.CallResult<Steamworks.Data.CreateBeaconCallback_t> CreateBeacon(uint unOpenSlots, Steamworks.Data.SteamPartyBeaconLocation_t pBeaconLocation, string pchConnectString, string pchMetadata)
- internal bool DestroyBeacon(Steamworks.Data.PartyBeaconID_t ulBeacon)
- internal bool GetAvailableBeaconLocations(ref Steamworks.Data.SteamPartyBeaconLocation_t pLocationList, uint uMaxNumLocations)
- internal Steamworks.Data.PartyBeaconID_t GetBeaconByIndex(uint unIndex)
- internal bool GetBeaconDetails(Steamworks.Data.PartyBeaconID_t ulBeaconID, ref Steamworks.SteamId pSteamIDBeaconOwner, ref Steamworks.Data.SteamPartyBeaconLocation_t pLocation, out string pchMetadata)
- internal bool GetBeaconLocationData(Steamworks.Data.SteamPartyBeaconLocation_t BeaconLocation, Steamworks.SteamPartyBeaconLocationData eData, out string pchDataStringOut)
- internal uint GetNumActiveBeacons()
- internal bool GetNumAvailableBeaconLocations(ref uint puNumLocations)
- public override System.IntPtr GetUserInterfacePointer()
- internal Steamworks.CallResult<Steamworks.Data.JoinPartyCallback_t> JoinParty(Steamworks.Data.PartyBeaconID_t ulBeaconID)
- internal void OnReservationCompleted(Steamworks.Data.PartyBeaconID_t ulBeacon, Steamworks.SteamId steamIDUser)
- internal static System.IntPtr SteamAPI_SteamParties_v002()
- private static void _CancelReservation(System.IntPtr self, Steamworks.Data.PartyBeaconID_t ulBeacon, Steamworks.SteamId steamIDUser)
- private static Steamworks.Data.SteamAPICall_t _ChangeNumOpenSlots(System.IntPtr self, Steamworks.Data.PartyBeaconID_t ulBeacon, uint unOpenSlots)
- private static Steamworks.Data.SteamAPICall_t _CreateBeacon(System.IntPtr self, uint unOpenSlots, ref Steamworks.Data.SteamPartyBeaconLocation_t pBeaconLocation, string pchConnectString, string pchMetadata)
- private static bool _DestroyBeacon(System.IntPtr self, Steamworks.Data.PartyBeaconID_t ulBeacon)
- private static bool _GetAvailableBeaconLocations(System.IntPtr self, ref Steamworks.Data.SteamPartyBeaconLocation_t pLocationList, uint uMaxNumLocations)
- private static Steamworks.Data.PartyBeaconID_t _GetBeaconByIndex(System.IntPtr self, uint unIndex)
- private static bool _GetBeaconDetails(System.IntPtr self, Steamworks.Data.PartyBeaconID_t ulBeaconID, ref Steamworks.SteamId pSteamIDBeaconOwner, ref Steamworks.Data.SteamPartyBeaconLocation_t pLocation, System.IntPtr pchMetadata, int cchMetadata)
- private static bool _GetBeaconLocationData(System.IntPtr self, Steamworks.Data.SteamPartyBeaconLocation_t BeaconLocation, Steamworks.SteamPartyBeaconLocationData eData, System.IntPtr pchDataStringOut, int cchDataStringOut)
- private static uint _GetNumActiveBeacons(System.IntPtr self)
- private static bool _GetNumAvailableBeaconLocations(System.IntPtr self, ref uint puNumLocations)
- private static Steamworks.Data.SteamAPICall_t _JoinParty(System.IntPtr self, Steamworks.Data.PartyBeaconID_t ulBeaconID)
- private static void _OnReservationCompleted(System.IntPtr self, Steamworks.Data.PartyBeaconID_t ulBeacon, Steamworks.SteamId steamIDUser)

### internal class Steamworks.ISteamRemotePlay
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamRemotePlay(bool IsGameServer)

#### Methods
- internal bool BGetSessionClientResolution(Steamworks.Data.RemotePlaySessionID_t unSessionID, ref int pnResolutionX, ref int pnResolutionY)
- internal bool BSendRemotePlayTogetherInvite(Steamworks.SteamId steamIDFriend)
- internal Steamworks.SteamDeviceFormFactor GetSessionClientFormFactor(Steamworks.Data.RemotePlaySessionID_t unSessionID)
- internal string GetSessionClientName(Steamworks.Data.RemotePlaySessionID_t unSessionID)
- internal uint GetSessionCount()
- internal Steamworks.Data.RemotePlaySessionID_t GetSessionID(int iSessionIndex)
- internal Steamworks.SteamId GetSessionSteamID(Steamworks.Data.RemotePlaySessionID_t unSessionID)
- public override System.IntPtr GetUserInterfacePointer()
- internal static System.IntPtr SteamAPI_SteamRemotePlay_v001()
- private static bool _BGetSessionClientResolution(System.IntPtr self, Steamworks.Data.RemotePlaySessionID_t unSessionID, ref int pnResolutionX, ref int pnResolutionY)
- private static bool _BSendRemotePlayTogetherInvite(System.IntPtr self, Steamworks.SteamId steamIDFriend)
- private static Steamworks.SteamDeviceFormFactor _GetSessionClientFormFactor(System.IntPtr self, Steamworks.Data.RemotePlaySessionID_t unSessionID)
- private static Steamworks.Utf8StringPointer _GetSessionClientName(System.IntPtr self, Steamworks.Data.RemotePlaySessionID_t unSessionID)
- private static uint _GetSessionCount(System.IntPtr self)
- private static Steamworks.Data.RemotePlaySessionID_t _GetSessionID(System.IntPtr self, int iSessionIndex)
- private static Steamworks.SteamId _GetSessionSteamID(System.IntPtr self, Steamworks.Data.RemotePlaySessionID_t unSessionID)

### internal class Steamworks.ISteamRemoteStorage
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamRemoteStorage(bool IsGameServer)

#### Methods
- internal bool FileDelete(string pchFile)
- internal bool FileExists(string pchFile)
- internal bool FileForget(string pchFile)
- internal bool FilePersisted(string pchFile)
- internal int FileRead(string pchFile, System.IntPtr pvData, int cubDataToRead)
- internal Steamworks.CallResult<Steamworks.Data.RemoteStorageFileReadAsyncComplete_t> FileReadAsync(string pchFile, uint nOffset, uint cubToRead)
- internal bool FileReadAsyncComplete(Steamworks.Data.SteamAPICall_t hReadCall, System.IntPtr pvBuffer, uint cubToRead)
- internal Steamworks.CallResult<Steamworks.Data.RemoteStorageFileShareResult_t> FileShare(string pchFile)
- internal bool FileWrite(string pchFile, System.IntPtr pvData, int cubData)
- internal Steamworks.CallResult<Steamworks.Data.RemoteStorageFileWriteAsyncComplete_t> FileWriteAsync(string pchFile, System.IntPtr pvData, uint cubData)
- internal bool FileWriteStreamCancel(Steamworks.Data.UGCFileWriteStreamHandle_t writeHandle)
- internal bool FileWriteStreamClose(Steamworks.Data.UGCFileWriteStreamHandle_t writeHandle)
- internal Steamworks.Data.UGCFileWriteStreamHandle_t FileWriteStreamOpen(string pchFile)
- internal bool FileWriteStreamWriteChunk(Steamworks.Data.UGCFileWriteStreamHandle_t writeHandle, System.IntPtr pvData, int cubData)
- internal int GetCachedUGCCount()
- internal Steamworks.Data.UGCHandle_t GetCachedUGCHandle(int iCachedContent)
- internal int GetFileCount()
- internal string GetFileNameAndSize(int iFile, ref int pnFileSizeInBytes)
- internal int GetFileSize(string pchFile)
- internal long GetFileTimestamp(string pchFile)
- internal bool GetQuota(ref ulong pnTotalBytes, ref ulong puAvailableBytes)
- internal Steamworks.RemoteStoragePlatform GetSyncPlatforms(string pchFile)
- internal bool GetUGCDetails(Steamworks.Data.UGCHandle_t hContent, ref Steamworks.AppId pnAppID, out char[] ppchName, ref int pnFileSizeInBytes, ref Steamworks.SteamId pSteamIDOwner)
- internal bool GetUGCDownloadProgress(Steamworks.Data.UGCHandle_t hContent, ref int pnBytesDownloaded, ref int pnBytesExpected)
- public override System.IntPtr GetUserInterfacePointer()
- internal bool IsCloudEnabledForAccount()
- internal bool IsCloudEnabledForApp()
- internal void SetCloudEnabledForApp(bool bEnabled)
- internal bool SetSyncPlatforms(string pchFile, Steamworks.RemoteStoragePlatform eRemoteStoragePlatform)
- internal static System.IntPtr SteamAPI_SteamRemoteStorage_v014()
- internal Steamworks.CallResult<Steamworks.Data.RemoteStorageDownloadUGCResult_t> UGCDownload(Steamworks.Data.UGCHandle_t hContent, uint unPriority)
- internal Steamworks.CallResult<Steamworks.Data.RemoteStorageDownloadUGCResult_t> UGCDownloadToLocation(Steamworks.Data.UGCHandle_t hContent, string pchLocation, uint unPriority)
- internal int UGCRead(Steamworks.Data.UGCHandle_t hContent, System.IntPtr pvData, int cubDataToRead, uint cOffset, Steamworks.UGCReadAction eAction)
- private static bool _FileDelete(System.IntPtr self, string pchFile)
- private static bool _FileExists(System.IntPtr self, string pchFile)
- private static bool _FileForget(System.IntPtr self, string pchFile)
- private static bool _FilePersisted(System.IntPtr self, string pchFile)
- private static int _FileRead(System.IntPtr self, string pchFile, System.IntPtr pvData, int cubDataToRead)
- private static Steamworks.Data.SteamAPICall_t _FileReadAsync(System.IntPtr self, string pchFile, uint nOffset, uint cubToRead)
- private static bool _FileReadAsyncComplete(System.IntPtr self, Steamworks.Data.SteamAPICall_t hReadCall, System.IntPtr pvBuffer, uint cubToRead)
- private static Steamworks.Data.SteamAPICall_t _FileShare(System.IntPtr self, string pchFile)
- private static bool _FileWrite(System.IntPtr self, string pchFile, System.IntPtr pvData, int cubData)
- private static Steamworks.Data.SteamAPICall_t _FileWriteAsync(System.IntPtr self, string pchFile, System.IntPtr pvData, uint cubData)
- private static bool _FileWriteStreamCancel(System.IntPtr self, Steamworks.Data.UGCFileWriteStreamHandle_t writeHandle)
- private static bool _FileWriteStreamClose(System.IntPtr self, Steamworks.Data.UGCFileWriteStreamHandle_t writeHandle)
- private static Steamworks.Data.UGCFileWriteStreamHandle_t _FileWriteStreamOpen(System.IntPtr self, string pchFile)
- private static bool _FileWriteStreamWriteChunk(System.IntPtr self, Steamworks.Data.UGCFileWriteStreamHandle_t writeHandle, System.IntPtr pvData, int cubData)
- private static int _GetCachedUGCCount(System.IntPtr self)
- private static Steamworks.Data.UGCHandle_t _GetCachedUGCHandle(System.IntPtr self, int iCachedContent)
- private static int _GetFileCount(System.IntPtr self)
- private static Steamworks.Utf8StringPointer _GetFileNameAndSize(System.IntPtr self, int iFile, ref int pnFileSizeInBytes)
- private static int _GetFileSize(System.IntPtr self, string pchFile)
- private static long _GetFileTimestamp(System.IntPtr self, string pchFile)
- private static bool _GetQuota(System.IntPtr self, ref ulong pnTotalBytes, ref ulong puAvailableBytes)
- private static Steamworks.RemoteStoragePlatform _GetSyncPlatforms(System.IntPtr self, string pchFile)
- private static bool _GetUGCDetails(System.IntPtr self, Steamworks.Data.UGCHandle_t hContent, ref Steamworks.AppId pnAppID, out char[] ppchName, ref int pnFileSizeInBytes, ref Steamworks.SteamId pSteamIDOwner)
- private static bool _GetUGCDownloadProgress(System.IntPtr self, Steamworks.Data.UGCHandle_t hContent, ref int pnBytesDownloaded, ref int pnBytesExpected)
- private static bool _IsCloudEnabledForAccount(System.IntPtr self)
- private static bool _IsCloudEnabledForApp(System.IntPtr self)
- private static void _SetCloudEnabledForApp(System.IntPtr self, bool bEnabled)
- private static bool _SetSyncPlatforms(System.IntPtr self, string pchFile, Steamworks.RemoteStoragePlatform eRemoteStoragePlatform)
- private static Steamworks.Data.SteamAPICall_t _UGCDownload(System.IntPtr self, Steamworks.Data.UGCHandle_t hContent, uint unPriority)
- private static Steamworks.Data.SteamAPICall_t _UGCDownloadToLocation(System.IntPtr self, Steamworks.Data.UGCHandle_t hContent, string pchLocation, uint unPriority)
- private static int _UGCRead(System.IntPtr self, Steamworks.Data.UGCHandle_t hContent, System.IntPtr pvData, int cubDataToRead, uint cOffset, Steamworks.UGCReadAction eAction)

### internal class Steamworks.ISteamScreenshots
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamScreenshots(bool IsGameServer)

#### Methods
- internal Steamworks.Data.ScreenshotHandle AddScreenshotToLibrary(string pchFilename, string pchThumbnailFilename, int nWidth, int nHeight)
- internal Steamworks.Data.ScreenshotHandle AddVRScreenshotToLibrary(Steamworks.VRScreenshotType eType, string pchFilename, string pchVRFilename)
- public override System.IntPtr GetUserInterfacePointer()
- internal void HookScreenshots(bool bHook)
- internal bool IsScreenshotsHooked()
- internal bool SetLocation(Steamworks.Data.ScreenshotHandle hScreenshot, string pchLocation)
- internal static System.IntPtr SteamAPI_SteamScreenshots_v003()
- internal bool TagPublishedFile(Steamworks.Data.ScreenshotHandle hScreenshot, Steamworks.Data.PublishedFileId unPublishedFileID)
- internal bool TagUser(Steamworks.Data.ScreenshotHandle hScreenshot, Steamworks.SteamId steamID)
- internal void TriggerScreenshot()
- internal Steamworks.Data.ScreenshotHandle WriteScreenshot(System.IntPtr pubRGB, uint cubRGB, int nWidth, int nHeight)
- private static Steamworks.Data.ScreenshotHandle _AddScreenshotToLibrary(System.IntPtr self, string pchFilename, string pchThumbnailFilename, int nWidth, int nHeight)
- private static Steamworks.Data.ScreenshotHandle _AddVRScreenshotToLibrary(System.IntPtr self, Steamworks.VRScreenshotType eType, string pchFilename, string pchVRFilename)
- private static void _HookScreenshots(System.IntPtr self, bool bHook)
- private static bool _IsScreenshotsHooked(System.IntPtr self)
- private static bool _SetLocation(System.IntPtr self, Steamworks.Data.ScreenshotHandle hScreenshot, string pchLocation)
- private static bool _TagPublishedFile(System.IntPtr self, Steamworks.Data.ScreenshotHandle hScreenshot, Steamworks.Data.PublishedFileId unPublishedFileID)
- private static bool _TagUser(System.IntPtr self, Steamworks.Data.ScreenshotHandle hScreenshot, Steamworks.SteamId steamID)
- private static void _TriggerScreenshot(System.IntPtr self)
- private static Steamworks.Data.ScreenshotHandle _WriteScreenshot(System.IntPtr self, System.IntPtr pubRGB, uint cubRGB, int nWidth, int nHeight)

### internal class Steamworks.ISteamTV
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamTV(bool IsGameServer)

#### Methods
- internal void AddBroadcastGameData(string pchKey, string pchValue)
- internal uint AddRegion(string pchElementName, string pchTimelineDataSection, ref Steamworks.Data.SteamTVRegion_t pSteamTVRegion, Steamworks.SteamTVRegionBehavior eSteamTVRegionBehavior)
- internal void AddTimelineMarker(string pchTemplateName, bool bPersistent, byte nColorR, byte nColorG, byte nColorB)
- public override System.IntPtr GetUserInterfacePointer()
- internal bool IsBroadcasting(ref int pnNumViewers)
- internal void RemoveBroadcastGameData(string pchKey)
- internal void RemoveRegion(uint unRegionHandle)
- internal void RemoveTimelineMarker()
- internal static System.IntPtr SteamAPI_SteamTV_v001()
- private static void _AddBroadcastGameData(System.IntPtr self, string pchKey, string pchValue)
- private static uint _AddRegion(System.IntPtr self, string pchElementName, string pchTimelineDataSection, ref Steamworks.Data.SteamTVRegion_t pSteamTVRegion, Steamworks.SteamTVRegionBehavior eSteamTVRegionBehavior)
- private static void _AddTimelineMarker(System.IntPtr self, string pchTemplateName, bool bPersistent, byte nColorR, byte nColorG, byte nColorB)
- private static bool _IsBroadcasting(System.IntPtr self, ref int pnNumViewers)
- private static void _RemoveBroadcastGameData(System.IntPtr self, string pchKey)
- private static void _RemoveRegion(System.IntPtr self, uint unRegionHandle)
- private static void _RemoveTimelineMarker(System.IntPtr self)

### internal class Steamworks.ISteamUGC
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamUGC(bool IsGameServer)

#### Methods
- internal Steamworks.CallResult<Steamworks.Data.AddAppDependencyResult_t> AddAppDependency(Steamworks.Data.PublishedFileId nPublishedFileID, Steamworks.AppId nAppID)
- internal Steamworks.CallResult<Steamworks.Data.AddUGCDependencyResult_t> AddDependency(Steamworks.Data.PublishedFileId nParentPublishedFileID, Steamworks.Data.PublishedFileId nChildPublishedFileID)
- internal bool AddExcludedTag(Steamworks.Data.UGCQueryHandle_t handle, string pTagName)
- internal bool AddItemKeyValueTag(Steamworks.Data.UGCUpdateHandle_t handle, string pchKey, string pchValue)
- internal bool AddItemPreviewFile(Steamworks.Data.UGCUpdateHandle_t handle, string pszPreviewFile, Steamworks.ItemPreviewType type)
- internal bool AddItemPreviewVideo(Steamworks.Data.UGCUpdateHandle_t handle, string pszVideoID)
- internal Steamworks.CallResult<Steamworks.Data.UserFavoriteItemsListChanged_t> AddItemToFavorites(Steamworks.AppId nAppId, Steamworks.Data.PublishedFileId nPublishedFileID)
- internal bool AddRequiredKeyValueTag(Steamworks.Data.UGCQueryHandle_t handle, string pKey, string pValue)
- internal bool AddRequiredTag(Steamworks.Data.UGCQueryHandle_t handle, string pTagName)
- internal bool AddRequiredTagGroup(Steamworks.Data.UGCQueryHandle_t handle, ref Steamworks.Data.SteamParamStringArray_t pTagGroups)
- internal bool BInitWorkshopForGameServer(Steamworks.Data.DepotId_t unWorkshopDepotID, string pszFolder)
- internal Steamworks.CallResult<Steamworks.Data.CreateItemResult_t> CreateItem(Steamworks.AppId nConsumerAppId, Steamworks.WorkshopFileType eFileType)
- internal Steamworks.Data.UGCQueryHandle_t CreateQueryAllUGCRequest(Steamworks.UGCQuery eQueryType, Steamworks.UgcType eMatchingeMatchingUGCTypeFileType, Steamworks.AppId nCreatorAppID, Steamworks.AppId nConsumerAppID, uint unPage)
- internal Steamworks.Data.UGCQueryHandle_t CreateQueryAllUGCRequest(Steamworks.UGCQuery eQueryType, Steamworks.UgcType eMatchingeMatchingUGCTypeFileType, Steamworks.AppId nCreatorAppID, Steamworks.AppId nConsumerAppID, string pchCursor)
- internal Steamworks.Data.UGCQueryHandle_t CreateQueryUGCDetailsRequest(Steamworks.Data.PublishedFileId[] pvecPublishedFileID, uint unNumPublishedFileIDs)
- internal Steamworks.Data.UGCQueryHandle_t CreateQueryUserUGCRequest(Steamworks.Data.AccountID_t unAccountID, Steamworks.UserUGCList eListType, Steamworks.UgcType eMatchingUGCType, Steamworks.UserUGCListSortOrder eSortOrder, Steamworks.AppId nCreatorAppID, Steamworks.AppId nConsumerAppID, uint unPage)
- internal Steamworks.CallResult<Steamworks.Data.DeleteItemResult_t> DeleteItem(Steamworks.Data.PublishedFileId nPublishedFileID)
- internal bool DownloadItem(Steamworks.Data.PublishedFileId nPublishedFileID, bool bHighPriority)
- internal Steamworks.CallResult<Steamworks.Data.GetAppDependenciesResult_t> GetAppDependencies(Steamworks.Data.PublishedFileId nPublishedFileID)
- internal bool GetItemDownloadInfo(Steamworks.Data.PublishedFileId nPublishedFileID, ref ulong punBytesDownloaded, ref ulong punBytesTotal)
- internal bool GetItemInstallInfo(Steamworks.Data.PublishedFileId nPublishedFileID, ref ulong punSizeOnDisk, out string pchFolder, ref uint punTimeStamp)
- internal uint GetItemState(Steamworks.Data.PublishedFileId nPublishedFileID)
- internal Steamworks.ItemUpdateStatus GetItemUpdateProgress(Steamworks.Data.UGCUpdateHandle_t handle, ref ulong punBytesProcessed, ref ulong punBytesTotal)
- internal uint GetNumSubscribedItems()
- internal bool GetQueryUGCAdditionalPreview(Steamworks.Data.UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, out string pchOriginalFileName, ref Steamworks.ItemPreviewType pPreviewType)
- internal bool GetQueryUGCChildren(Steamworks.Data.UGCQueryHandle_t handle, uint index, Steamworks.Data.PublishedFileId[] pvecPublishedFileID, uint cMaxEntries)
- internal bool GetQueryUGCKeyValueTag(Steamworks.Data.UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, out string pchValue)
- internal bool GetQueryUGCKeyValueTag(Steamworks.Data.UGCQueryHandle_t handle, uint index, string pchKey, out string pchValue)
- internal bool GetQueryUGCMetadata(Steamworks.Data.UGCQueryHandle_t handle, uint index, out string pchMetadata)
- internal uint GetQueryUGCNumAdditionalPreviews(Steamworks.Data.UGCQueryHandle_t handle, uint index)
- internal uint GetQueryUGCNumKeyValueTags(Steamworks.Data.UGCQueryHandle_t handle, uint index)
- internal bool GetQueryUGCPreviewURL(Steamworks.Data.UGCQueryHandle_t handle, uint index, out string pchURL)
- internal bool GetQueryUGCResult(Steamworks.Data.UGCQueryHandle_t handle, uint index, ref Steamworks.Data.SteamUGCDetails_t pDetails)
- internal bool GetQueryUGCStatistic(Steamworks.Data.UGCQueryHandle_t handle, uint index, Steamworks.ItemStatistic eStatType, ref ulong pStatValue)
- public override System.IntPtr GetServerInterfacePointer()
- internal uint GetSubscribedItems(Steamworks.Data.PublishedFileId[] pvecPublishedFileID, uint cMaxEntries)
- public override System.IntPtr GetUserInterfacePointer()
- internal Steamworks.CallResult<Steamworks.Data.GetUserItemVoteResult_t> GetUserItemVote(Steamworks.Data.PublishedFileId nPublishedFileID)
- internal bool ReleaseQueryUGCRequest(Steamworks.Data.UGCQueryHandle_t handle)
- internal bool RemoveAllItemKeyValueTags(Steamworks.Data.UGCUpdateHandle_t handle)
- internal Steamworks.CallResult<Steamworks.Data.RemoveAppDependencyResult_t> RemoveAppDependency(Steamworks.Data.PublishedFileId nPublishedFileID, Steamworks.AppId nAppID)
- internal Steamworks.CallResult<Steamworks.Data.RemoveUGCDependencyResult_t> RemoveDependency(Steamworks.Data.PublishedFileId nParentPublishedFileID, Steamworks.Data.PublishedFileId nChildPublishedFileID)
- internal Steamworks.CallResult<Steamworks.Data.UserFavoriteItemsListChanged_t> RemoveItemFromFavorites(Steamworks.AppId nAppId, Steamworks.Data.PublishedFileId nPublishedFileID)
- internal bool RemoveItemKeyValueTags(Steamworks.Data.UGCUpdateHandle_t handle, string pchKey)
- internal bool RemoveItemPreview(Steamworks.Data.UGCUpdateHandle_t handle, uint index)
- internal Steamworks.CallResult<Steamworks.Data.SteamUGCRequestUGCDetailsResult_t> RequestUGCDetails(Steamworks.Data.PublishedFileId nPublishedFileID, uint unMaxAgeSeconds)
- internal Steamworks.CallResult<Steamworks.Data.SteamUGCQueryCompleted_t> SendQueryUGCRequest(Steamworks.Data.UGCQueryHandle_t handle)
- internal bool SetAllowCachedResponse(Steamworks.Data.UGCQueryHandle_t handle, uint unMaxAgeSeconds)
- internal bool SetAllowLegacyUpload(Steamworks.Data.UGCUpdateHandle_t handle, bool bAllowLegacyUpload)
- internal bool SetCloudFileNameFilter(Steamworks.Data.UGCQueryHandle_t handle, string pMatchCloudFileName)
- internal bool SetItemContent(Steamworks.Data.UGCUpdateHandle_t handle, string pszContentFolder)
- internal bool SetItemDescription(Steamworks.Data.UGCUpdateHandle_t handle, string pchDescription)
- internal bool SetItemMetadata(Steamworks.Data.UGCUpdateHandle_t handle, string pchMetaData)
- internal bool SetItemPreview(Steamworks.Data.UGCUpdateHandle_t handle, string pszPreviewFile)
- internal bool SetItemTags(Steamworks.Data.UGCUpdateHandle_t updateHandle, ref Steamworks.Data.SteamParamStringArray_t pTags)
- internal bool SetItemTitle(Steamworks.Data.UGCUpdateHandle_t handle, string pchTitle)
- internal bool SetItemUpdateLanguage(Steamworks.Data.UGCUpdateHandle_t handle, string pchLanguage)
- internal bool SetItemVisibility(Steamworks.Data.UGCUpdateHandle_t handle, Steamworks.RemoteStoragePublishedFileVisibility eVisibility)
- internal bool SetLanguage(Steamworks.Data.UGCQueryHandle_t handle, string pchLanguage)
- internal bool SetMatchAnyTag(Steamworks.Data.UGCQueryHandle_t handle, bool bMatchAnyTag)
- internal bool SetRankedByTrendDays(Steamworks.Data.UGCQueryHandle_t handle, uint unDays)
- internal bool SetReturnAdditionalPreviews(Steamworks.Data.UGCQueryHandle_t handle, bool bReturnAdditionalPreviews)
- internal bool SetReturnChildren(Steamworks.Data.UGCQueryHandle_t handle, bool bReturnChildren)
- internal bool SetReturnKeyValueTags(Steamworks.Data.UGCQueryHandle_t handle, bool bReturnKeyValueTags)
- internal bool SetReturnLongDescription(Steamworks.Data.UGCQueryHandle_t handle, bool bReturnLongDescription)
- internal bool SetReturnMetadata(Steamworks.Data.UGCQueryHandle_t handle, bool bReturnMetadata)
- internal bool SetReturnOnlyIDs(Steamworks.Data.UGCQueryHandle_t handle, bool bReturnOnlyIDs)
- internal bool SetReturnPlaytimeStats(Steamworks.Data.UGCQueryHandle_t handle, uint unDays)
- internal bool SetReturnTotalOnly(Steamworks.Data.UGCQueryHandle_t handle, bool bReturnTotalOnly)
- internal bool SetSearchText(Steamworks.Data.UGCQueryHandle_t handle, string pSearchText)
- internal Steamworks.CallResult<Steamworks.Data.SetUserItemVoteResult_t> SetUserItemVote(Steamworks.Data.PublishedFileId nPublishedFileID, bool bVoteUp)
- internal Steamworks.Data.UGCUpdateHandle_t StartItemUpdate(Steamworks.AppId nConsumerAppId, Steamworks.Data.PublishedFileId nPublishedFileID)
- internal Steamworks.CallResult<Steamworks.Data.StartPlaytimeTrackingResult_t> StartPlaytimeTracking(Steamworks.Data.PublishedFileId[] pvecPublishedFileID, uint unNumPublishedFileIDs)
- internal static System.IntPtr SteamAPI_SteamGameServerUGC_v014()
- internal static System.IntPtr SteamAPI_SteamUGC_v014()
- internal Steamworks.CallResult<Steamworks.Data.StopPlaytimeTrackingResult_t> StopPlaytimeTracking(Steamworks.Data.PublishedFileId[] pvecPublishedFileID, uint unNumPublishedFileIDs)
- internal Steamworks.CallResult<Steamworks.Data.StopPlaytimeTrackingResult_t> StopPlaytimeTrackingForAllItems()
- internal Steamworks.CallResult<Steamworks.Data.SubmitItemUpdateResult_t> SubmitItemUpdate(Steamworks.Data.UGCUpdateHandle_t handle, string pchChangeNote)
- internal Steamworks.CallResult<Steamworks.Data.RemoteStorageSubscribePublishedFileResult_t> SubscribeItem(Steamworks.Data.PublishedFileId nPublishedFileID)
- internal void SuspendDownloads(bool bSuspend)
- internal Steamworks.CallResult<Steamworks.Data.RemoteStorageUnsubscribePublishedFileResult_t> UnsubscribeItem(Steamworks.Data.PublishedFileId nPublishedFileID)
- internal bool UpdateItemPreviewFile(Steamworks.Data.UGCUpdateHandle_t handle, uint index, string pszPreviewFile)
- internal bool UpdateItemPreviewVideo(Steamworks.Data.UGCUpdateHandle_t handle, uint index, string pszVideoID)
- private static Steamworks.Data.SteamAPICall_t _AddAppDependency(System.IntPtr self, Steamworks.Data.PublishedFileId nPublishedFileID, Steamworks.AppId nAppID)
- private static Steamworks.Data.SteamAPICall_t _AddDependency(System.IntPtr self, Steamworks.Data.PublishedFileId nParentPublishedFileID, Steamworks.Data.PublishedFileId nChildPublishedFileID)
- private static bool _AddExcludedTag(System.IntPtr self, Steamworks.Data.UGCQueryHandle_t handle, string pTagName)
- private static bool _AddItemKeyValueTag(System.IntPtr self, Steamworks.Data.UGCUpdateHandle_t handle, string pchKey, string pchValue)
- private static bool _AddItemPreviewFile(System.IntPtr self, Steamworks.Data.UGCUpdateHandle_t handle, string pszPreviewFile, Steamworks.ItemPreviewType type)
- private static bool _AddItemPreviewVideo(System.IntPtr self, Steamworks.Data.UGCUpdateHandle_t handle, string pszVideoID)
- private static Steamworks.Data.SteamAPICall_t _AddItemToFavorites(System.IntPtr self, Steamworks.AppId nAppId, Steamworks.Data.PublishedFileId nPublishedFileID)
- private static bool _AddRequiredKeyValueTag(System.IntPtr self, Steamworks.Data.UGCQueryHandle_t handle, string pKey, string pValue)
- private static bool _AddRequiredTag(System.IntPtr self, Steamworks.Data.UGCQueryHandle_t handle, string pTagName)
- private static bool _AddRequiredTagGroup(System.IntPtr self, Steamworks.Data.UGCQueryHandle_t handle, ref Steamworks.Data.SteamParamStringArray_t pTagGroups)
- private static bool _BInitWorkshopForGameServer(System.IntPtr self, Steamworks.Data.DepotId_t unWorkshopDepotID, string pszFolder)
- private static Steamworks.Data.SteamAPICall_t _CreateItem(System.IntPtr self, Steamworks.AppId nConsumerAppId, Steamworks.WorkshopFileType eFileType)
- private static Steamworks.Data.UGCQueryHandle_t _CreateQueryAllUGCRequest(System.IntPtr self, Steamworks.UGCQuery eQueryType, Steamworks.UgcType eMatchingeMatchingUGCTypeFileType, Steamworks.AppId nCreatorAppID, Steamworks.AppId nConsumerAppID, uint unPage)
- private static Steamworks.Data.UGCQueryHandle_t _CreateQueryAllUGCRequest(System.IntPtr self, Steamworks.UGCQuery eQueryType, Steamworks.UgcType eMatchingeMatchingUGCTypeFileType, Steamworks.AppId nCreatorAppID, Steamworks.AppId nConsumerAppID, string pchCursor)
- private static Steamworks.Data.UGCQueryHandle_t _CreateQueryUGCDetailsRequest(System.IntPtr self, Steamworks.Data.PublishedFileId[] pvecPublishedFileID, uint unNumPublishedFileIDs)
- private static Steamworks.Data.UGCQueryHandle_t _CreateQueryUserUGCRequest(System.IntPtr self, Steamworks.Data.AccountID_t unAccountID, Steamworks.UserUGCList eListType, Steamworks.UgcType eMatchingUGCType, Steamworks.UserUGCListSortOrder eSortOrder, Steamworks.AppId nCreatorAppID, Steamworks.AppId nConsumerAppID, uint unPage)
- private static Steamworks.Data.SteamAPICall_t _DeleteItem(System.IntPtr self, Steamworks.Data.PublishedFileId nPublishedFileID)
- private static bool _DownloadItem(System.IntPtr self, Steamworks.Data.PublishedFileId nPublishedFileID, bool bHighPriority)
- private static Steamworks.Data.SteamAPICall_t _GetAppDependencies(System.IntPtr self, Steamworks.Data.PublishedFileId nPublishedFileID)
- private static bool _GetItemDownloadInfo(System.IntPtr self, Steamworks.Data.PublishedFileId nPublishedFileID, ref ulong punBytesDownloaded, ref ulong punBytesTotal)
- private static bool _GetItemInstallInfo(System.IntPtr self, Steamworks.Data.PublishedFileId nPublishedFileID, ref ulong punSizeOnDisk, System.IntPtr pchFolder, uint cchFolderSize, ref uint punTimeStamp)
- private static uint _GetItemState(System.IntPtr self, Steamworks.Data.PublishedFileId nPublishedFileID)
- private static Steamworks.ItemUpdateStatus _GetItemUpdateProgress(System.IntPtr self, Steamworks.Data.UGCUpdateHandle_t handle, ref ulong punBytesProcessed, ref ulong punBytesTotal)
- private static uint _GetNumSubscribedItems(System.IntPtr self)
- private static bool _GetQueryUGCAdditionalPreview(System.IntPtr self, Steamworks.Data.UGCQueryHandle_t handle, uint index, uint previewIndex, System.IntPtr pchURLOrVideoID, uint cchURLSize, System.IntPtr pchOriginalFileName, uint cchOriginalFileNameSize, ref Steamworks.ItemPreviewType pPreviewType)
- private static bool _GetQueryUGCChildren(System.IntPtr self, Steamworks.Data.UGCQueryHandle_t handle, uint index, Steamworks.Data.PublishedFileId[] pvecPublishedFileID, uint cMaxEntries)
- private static bool _GetQueryUGCKeyValueTag(System.IntPtr self, Steamworks.Data.UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, System.IntPtr pchKey, uint cchKeySize, System.IntPtr pchValue, uint cchValueSize)
- private static bool _GetQueryUGCKeyValueTag(System.IntPtr self, Steamworks.Data.UGCQueryHandle_t handle, uint index, string pchKey, System.IntPtr pchValue, uint cchValueSize)
- private static bool _GetQueryUGCMetadata(System.IntPtr self, Steamworks.Data.UGCQueryHandle_t handle, uint index, System.IntPtr pchMetadata, uint cchMetadatasize)
- private static uint _GetQueryUGCNumAdditionalPreviews(System.IntPtr self, Steamworks.Data.UGCQueryHandle_t handle, uint index)
- private static uint _GetQueryUGCNumKeyValueTags(System.IntPtr self, Steamworks.Data.UGCQueryHandle_t handle, uint index)
- private static bool _GetQueryUGCPreviewURL(System.IntPtr self, Steamworks.Data.UGCQueryHandle_t handle, uint index, System.IntPtr pchURL, uint cchURLSize)
- private static bool _GetQueryUGCResult(System.IntPtr self, Steamworks.Data.UGCQueryHandle_t handle, uint index, ref Steamworks.Data.SteamUGCDetails_t pDetails)
- private static bool _GetQueryUGCStatistic(System.IntPtr self, Steamworks.Data.UGCQueryHandle_t handle, uint index, Steamworks.ItemStatistic eStatType, ref ulong pStatValue)
- private static uint _GetSubscribedItems(System.IntPtr self, Steamworks.Data.PublishedFileId[] pvecPublishedFileID, uint cMaxEntries)
- private static Steamworks.Data.SteamAPICall_t _GetUserItemVote(System.IntPtr self, Steamworks.Data.PublishedFileId nPublishedFileID)
- private static bool _ReleaseQueryUGCRequest(System.IntPtr self, Steamworks.Data.UGCQueryHandle_t handle)
- private static bool _RemoveAllItemKeyValueTags(System.IntPtr self, Steamworks.Data.UGCUpdateHandle_t handle)
- private static Steamworks.Data.SteamAPICall_t _RemoveAppDependency(System.IntPtr self, Steamworks.Data.PublishedFileId nPublishedFileID, Steamworks.AppId nAppID)
- private static Steamworks.Data.SteamAPICall_t _RemoveDependency(System.IntPtr self, Steamworks.Data.PublishedFileId nParentPublishedFileID, Steamworks.Data.PublishedFileId nChildPublishedFileID)
- private static Steamworks.Data.SteamAPICall_t _RemoveItemFromFavorites(System.IntPtr self, Steamworks.AppId nAppId, Steamworks.Data.PublishedFileId nPublishedFileID)
- private static bool _RemoveItemKeyValueTags(System.IntPtr self, Steamworks.Data.UGCUpdateHandle_t handle, string pchKey)
- private static bool _RemoveItemPreview(System.IntPtr self, Steamworks.Data.UGCUpdateHandle_t handle, uint index)
- private static Steamworks.Data.SteamAPICall_t _RequestUGCDetails(System.IntPtr self, Steamworks.Data.PublishedFileId nPublishedFileID, uint unMaxAgeSeconds)
- private static Steamworks.Data.SteamAPICall_t _SendQueryUGCRequest(System.IntPtr self, Steamworks.Data.UGCQueryHandle_t handle)
- private static bool _SetAllowCachedResponse(System.IntPtr self, Steamworks.Data.UGCQueryHandle_t handle, uint unMaxAgeSeconds)
- private static bool _SetAllowLegacyUpload(System.IntPtr self, Steamworks.Data.UGCUpdateHandle_t handle, bool bAllowLegacyUpload)
- private static bool _SetCloudFileNameFilter(System.IntPtr self, Steamworks.Data.UGCQueryHandle_t handle, string pMatchCloudFileName)
- private static bool _SetItemContent(System.IntPtr self, Steamworks.Data.UGCUpdateHandle_t handle, string pszContentFolder)
- private static bool _SetItemDescription(System.IntPtr self, Steamworks.Data.UGCUpdateHandle_t handle, string pchDescription)
- private static bool _SetItemMetadata(System.IntPtr self, Steamworks.Data.UGCUpdateHandle_t handle, string pchMetaData)
- private static bool _SetItemPreview(System.IntPtr self, Steamworks.Data.UGCUpdateHandle_t handle, string pszPreviewFile)
- private static bool _SetItemTags(System.IntPtr self, Steamworks.Data.UGCUpdateHandle_t updateHandle, ref Steamworks.Data.SteamParamStringArray_t pTags)
- private static bool _SetItemTitle(System.IntPtr self, Steamworks.Data.UGCUpdateHandle_t handle, string pchTitle)
- private static bool _SetItemUpdateLanguage(System.IntPtr self, Steamworks.Data.UGCUpdateHandle_t handle, string pchLanguage)
- private static bool _SetItemVisibility(System.IntPtr self, Steamworks.Data.UGCUpdateHandle_t handle, Steamworks.RemoteStoragePublishedFileVisibility eVisibility)
- private static bool _SetLanguage(System.IntPtr self, Steamworks.Data.UGCQueryHandle_t handle, string pchLanguage)
- private static bool _SetMatchAnyTag(System.IntPtr self, Steamworks.Data.UGCQueryHandle_t handle, bool bMatchAnyTag)
- private static bool _SetRankedByTrendDays(System.IntPtr self, Steamworks.Data.UGCQueryHandle_t handle, uint unDays)
- private static bool _SetReturnAdditionalPreviews(System.IntPtr self, Steamworks.Data.UGCQueryHandle_t handle, bool bReturnAdditionalPreviews)
- private static bool _SetReturnChildren(System.IntPtr self, Steamworks.Data.UGCQueryHandle_t handle, bool bReturnChildren)
- private static bool _SetReturnKeyValueTags(System.IntPtr self, Steamworks.Data.UGCQueryHandle_t handle, bool bReturnKeyValueTags)
- private static bool _SetReturnLongDescription(System.IntPtr self, Steamworks.Data.UGCQueryHandle_t handle, bool bReturnLongDescription)
- private static bool _SetReturnMetadata(System.IntPtr self, Steamworks.Data.UGCQueryHandle_t handle, bool bReturnMetadata)
- private static bool _SetReturnOnlyIDs(System.IntPtr self, Steamworks.Data.UGCQueryHandle_t handle, bool bReturnOnlyIDs)
- private static bool _SetReturnPlaytimeStats(System.IntPtr self, Steamworks.Data.UGCQueryHandle_t handle, uint unDays)
- private static bool _SetReturnTotalOnly(System.IntPtr self, Steamworks.Data.UGCQueryHandle_t handle, bool bReturnTotalOnly)
- private static bool _SetSearchText(System.IntPtr self, Steamworks.Data.UGCQueryHandle_t handle, string pSearchText)
- private static Steamworks.Data.SteamAPICall_t _SetUserItemVote(System.IntPtr self, Steamworks.Data.PublishedFileId nPublishedFileID, bool bVoteUp)
- private static Steamworks.Data.UGCUpdateHandle_t _StartItemUpdate(System.IntPtr self, Steamworks.AppId nConsumerAppId, Steamworks.Data.PublishedFileId nPublishedFileID)
- private static Steamworks.Data.SteamAPICall_t _StartPlaytimeTracking(System.IntPtr self, Steamworks.Data.PublishedFileId[] pvecPublishedFileID, uint unNumPublishedFileIDs)
- private static Steamworks.Data.SteamAPICall_t _StopPlaytimeTracking(System.IntPtr self, Steamworks.Data.PublishedFileId[] pvecPublishedFileID, uint unNumPublishedFileIDs)
- private static Steamworks.Data.SteamAPICall_t _StopPlaytimeTrackingForAllItems(System.IntPtr self)
- private static Steamworks.Data.SteamAPICall_t _SubmitItemUpdate(System.IntPtr self, Steamworks.Data.UGCUpdateHandle_t handle, string pchChangeNote)
- private static Steamworks.Data.SteamAPICall_t _SubscribeItem(System.IntPtr self, Steamworks.Data.PublishedFileId nPublishedFileID)
- private static void _SuspendDownloads(System.IntPtr self, bool bSuspend)
- private static Steamworks.Data.SteamAPICall_t _UnsubscribeItem(System.IntPtr self, Steamworks.Data.PublishedFileId nPublishedFileID)
- private static bool _UpdateItemPreviewFile(System.IntPtr self, Steamworks.Data.UGCUpdateHandle_t handle, uint index, string pszPreviewFile)
- private static bool _UpdateItemPreviewVideo(System.IntPtr self, Steamworks.Data.UGCUpdateHandle_t handle, uint index, string pszVideoID)

### internal class Steamworks.ISteamUser
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamUser(bool IsGameServer)

#### Methods
- internal void AdvertiseGame(Steamworks.SteamId steamIDGameServer, uint unIPServer, ushort usPortServer)
- internal Steamworks.BeginAuthResult BeginAuthSession(System.IntPtr pAuthTicket, int cbAuthTicket, Steamworks.SteamId steamID)
- internal bool BIsBehindNAT()
- internal bool BIsPhoneIdentifying()
- internal bool BIsPhoneRequiringVerification()
- internal bool BIsPhoneVerified()
- internal bool BIsTwoFactorEnabled()
- internal bool BLoggedOn()
- internal void CancelAuthTicket(Steamworks.Data.HAuthTicket hAuthTicket)
- internal Steamworks.VoiceResult DecompressVoice(System.IntPtr pCompressed, uint cbCompressed, System.IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, uint nDesiredSampleRate)
- internal void EndAuthSession(Steamworks.SteamId steamID)
- internal Steamworks.Data.HAuthTicket GetAuthSessionTicket(System.IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket)
- internal Steamworks.VoiceResult GetAvailableVoice(ref uint pcbCompressed, ref uint pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated)
- internal Steamworks.CallResult<Steamworks.Data.DurationControl_t> GetDurationControl()
- internal bool GetEncryptedAppTicket(System.IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket)
- internal int GetGameBadgeLevel(int nSeries, bool bFoil)
- internal Steamworks.Data.HSteamUser GetHSteamUser()
- internal Steamworks.CallResult<Steamworks.Data.MarketEligibilityResponse_t> GetMarketEligibility()
- internal int GetPlayerSteamLevel()
- internal Steamworks.SteamId GetSteamID()
- internal bool GetUserDataFolder(out string pchBuffer)
- public override System.IntPtr GetUserInterfacePointer()
- internal Steamworks.VoiceResult GetVoice(bool bWantCompressed, System.IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, bool bWantUncompressed_Deprecated, System.IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, ref uint nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated)
- internal uint GetVoiceOptimalSampleRate()
- internal int InitiateGameConnection(System.IntPtr pAuthBlob, int cbMaxAuthBlob, Steamworks.SteamId steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure)
- internal Steamworks.CallResult<Steamworks.Data.EncryptedAppTicketResponse_t> RequestEncryptedAppTicket(System.IntPtr pDataToInclude, int cbDataToInclude)
- internal Steamworks.CallResult<Steamworks.Data.StoreAuthURLResponse_t> RequestStoreAuthURL(string pchRedirectURL)
- internal void StartVoiceRecording()
- internal static System.IntPtr SteamAPI_SteamUser_v020()
- internal void StopVoiceRecording()
- internal void TerminateGameConnection(uint unIPServer, ushort usPortServer)
- internal void TrackAppUsageEvent(Steamworks.Data.GameId gameID, int eAppUsageEvent, string pchExtraInfo)
- internal Steamworks.UserHasLicenseForAppResult UserHasLicenseForApp(Steamworks.SteamId steamID, Steamworks.AppId appID)
- private static void _AdvertiseGame(System.IntPtr self, Steamworks.SteamId steamIDGameServer, uint unIPServer, ushort usPortServer)
- private static Steamworks.BeginAuthResult _BeginAuthSession(System.IntPtr self, System.IntPtr pAuthTicket, int cbAuthTicket, Steamworks.SteamId steamID)
- private static bool _BIsBehindNAT(System.IntPtr self)
- private static bool _BIsPhoneIdentifying(System.IntPtr self)
- private static bool _BIsPhoneRequiringVerification(System.IntPtr self)
- private static bool _BIsPhoneVerified(System.IntPtr self)
- private static bool _BIsTwoFactorEnabled(System.IntPtr self)
- private static bool _BLoggedOn(System.IntPtr self)
- private static void _CancelAuthTicket(System.IntPtr self, Steamworks.Data.HAuthTicket hAuthTicket)
- private static Steamworks.VoiceResult _DecompressVoice(System.IntPtr self, System.IntPtr pCompressed, uint cbCompressed, System.IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, uint nDesiredSampleRate)
- private static void _EndAuthSession(System.IntPtr self, Steamworks.SteamId steamID)
- private static Steamworks.Data.HAuthTicket _GetAuthSessionTicket(System.IntPtr self, System.IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket)
- private static Steamworks.VoiceResult _GetAvailableVoice(System.IntPtr self, ref uint pcbCompressed, ref uint pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated)
- private static Steamworks.Data.SteamAPICall_t _GetDurationControl(System.IntPtr self)
- private static bool _GetEncryptedAppTicket(System.IntPtr self, System.IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket)
- private static int _GetGameBadgeLevel(System.IntPtr self, int nSeries, bool bFoil)
- private static Steamworks.Data.HSteamUser _GetHSteamUser(System.IntPtr self)
- private static Steamworks.Data.SteamAPICall_t _GetMarketEligibility(System.IntPtr self)
- private static int _GetPlayerSteamLevel(System.IntPtr self)
- private static Steamworks.SteamId _GetSteamID(System.IntPtr self)
- private static bool _GetUserDataFolder(System.IntPtr self, System.IntPtr pchBuffer, int cubBuffer)
- private static Steamworks.VoiceResult _GetVoice(System.IntPtr self, bool bWantCompressed, System.IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, bool bWantUncompressed_Deprecated, System.IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, ref uint nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated)
- private static uint _GetVoiceOptimalSampleRate(System.IntPtr self)
- private static int _InitiateGameConnection(System.IntPtr self, System.IntPtr pAuthBlob, int cbMaxAuthBlob, Steamworks.SteamId steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure)
- private static Steamworks.Data.SteamAPICall_t _RequestEncryptedAppTicket(System.IntPtr self, System.IntPtr pDataToInclude, int cbDataToInclude)
- private static Steamworks.Data.SteamAPICall_t _RequestStoreAuthURL(System.IntPtr self, string pchRedirectURL)
- private static void _StartVoiceRecording(System.IntPtr self)
- private static void _StopVoiceRecording(System.IntPtr self)
- private static void _TerminateGameConnection(System.IntPtr self, uint unIPServer, ushort usPortServer)
- private static void _TrackAppUsageEvent(System.IntPtr self, Steamworks.Data.GameId gameID, int eAppUsageEvent, string pchExtraInfo)
- private static Steamworks.UserHasLicenseForAppResult _UserHasLicenseForApp(System.IntPtr self, Steamworks.SteamId steamID, Steamworks.AppId appID)

### internal class Steamworks.ISteamUserStats
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamUserStats(bool IsGameServer)

#### Methods
- internal Steamworks.CallResult<Steamworks.Data.LeaderboardUGCSet_t> AttachLeaderboardUGC(Steamworks.Data.SteamLeaderboard_t hSteamLeaderboard, Steamworks.Data.UGCHandle_t hUGC)
- internal bool ClearAchievement(string pchName)
- internal Steamworks.CallResult<Steamworks.Data.LeaderboardScoresDownloaded_t> DownloadLeaderboardEntries(Steamworks.Data.SteamLeaderboard_t hSteamLeaderboard, Steamworks.LeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd)
- internal Steamworks.CallResult<Steamworks.Data.LeaderboardScoresDownloaded_t> DownloadLeaderboardEntriesForUsers(Steamworks.Data.SteamLeaderboard_t hSteamLeaderboard, Steamworks.SteamId[] prgUsers, int cUsers)
- internal Steamworks.CallResult<Steamworks.Data.LeaderboardFindResult_t> FindLeaderboard(string pchLeaderboardName)
- internal Steamworks.CallResult<Steamworks.Data.LeaderboardFindResult_t> FindOrCreateLeaderboard(string pchLeaderboardName, Steamworks.Data.LeaderboardSort eLeaderboardSortMethod, Steamworks.Data.LeaderboardDisplay eLeaderboardDisplayType)
- internal bool GetAchievement(string pchName, ref bool pbAchieved)
- internal bool GetAchievementAchievedPercent(string pchName, ref float pflPercent)
- internal bool GetAchievementAndUnlockTime(string pchName, ref bool pbAchieved, ref uint punUnlockTime)
- internal string GetAchievementDisplayAttribute(string pchName, string pchKey)
- internal int GetAchievementIcon(string pchName)
- internal string GetAchievementName(uint iAchievement)
- internal bool GetDownloadedLeaderboardEntry(Steamworks.Data.SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, ref Steamworks.Data.LeaderboardEntry_t pLeaderboardEntry, int[] pDetails, int cDetailsMax)
- internal bool GetGlobalStat(string pchStatName, ref long pData)
- internal bool GetGlobalStat(string pchStatName, ref double pData)
- internal int GetGlobalStatHistory(string pchStatName, long[] pData, uint cubData)
- internal int GetGlobalStatHistory(string pchStatName, double[] pData, uint cubData)
- internal Steamworks.Data.LeaderboardDisplay GetLeaderboardDisplayType(Steamworks.Data.SteamLeaderboard_t hSteamLeaderboard)
- internal int GetLeaderboardEntryCount(Steamworks.Data.SteamLeaderboard_t hSteamLeaderboard)
- internal string GetLeaderboardName(Steamworks.Data.SteamLeaderboard_t hSteamLeaderboard)
- internal Steamworks.Data.LeaderboardSort GetLeaderboardSortMethod(Steamworks.Data.SteamLeaderboard_t hSteamLeaderboard)
- internal int GetMostAchievedAchievementInfo(out string pchName, ref float pflPercent, ref bool pbAchieved)
- internal int GetNextMostAchievedAchievementInfo(int iIteratorPrevious, out string pchName, ref float pflPercent, ref bool pbAchieved)
- internal uint GetNumAchievements()
- internal Steamworks.CallResult<Steamworks.Data.NumberOfCurrentPlayers_t> GetNumberOfCurrentPlayers()
- internal bool GetStat(string pchName, ref int pData)
- internal bool GetStat(string pchName, ref float pData)
- internal bool GetUserAchievement(Steamworks.SteamId steamIDUser, string pchName, ref bool pbAchieved)
- internal bool GetUserAchievementAndUnlockTime(Steamworks.SteamId steamIDUser, string pchName, ref bool pbAchieved, ref uint punUnlockTime)
- public override System.IntPtr GetUserInterfacePointer()
- internal bool GetUserStat(Steamworks.SteamId steamIDUser, string pchName, ref int pData)
- internal bool GetUserStat(Steamworks.SteamId steamIDUser, string pchName, ref float pData)
- internal bool IndicateAchievementProgress(string pchName, uint nCurProgress, uint nMaxProgress)
- internal bool RequestCurrentStats()
- internal Steamworks.CallResult<Steamworks.Data.GlobalAchievementPercentagesReady_t> RequestGlobalAchievementPercentages()
- internal Steamworks.CallResult<Steamworks.Data.GlobalStatsReceived_t> RequestGlobalStats(int nHistoryDays)
- internal Steamworks.CallResult<Steamworks.Data.UserStatsReceived_t> RequestUserStats(Steamworks.SteamId steamIDUser)
- internal bool ResetAllStats(bool bAchievementsToo)
- internal bool SetAchievement(string pchName)
- internal bool SetStat(string pchName, int nData)
- internal bool SetStat(string pchName, float fData)
- internal static System.IntPtr SteamAPI_SteamUserStats_v011()
- internal bool StoreStats()
- internal bool UpdateAvgRateStat(string pchName, float flCountThisSession, double dSessionLength)
- internal Steamworks.CallResult<Steamworks.Data.LeaderboardScoreUploaded_t> UploadLeaderboardScore(Steamworks.Data.SteamLeaderboard_t hSteamLeaderboard, Steamworks.LeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, int[] pScoreDetails, int cScoreDetailsCount)
- private static Steamworks.Data.SteamAPICall_t _AttachLeaderboardUGC(System.IntPtr self, Steamworks.Data.SteamLeaderboard_t hSteamLeaderboard, Steamworks.Data.UGCHandle_t hUGC)
- private static bool _ClearAchievement(System.IntPtr self, string pchName)
- private static Steamworks.Data.SteamAPICall_t _DownloadLeaderboardEntries(System.IntPtr self, Steamworks.Data.SteamLeaderboard_t hSteamLeaderboard, Steamworks.LeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd)
- private static Steamworks.Data.SteamAPICall_t _DownloadLeaderboardEntriesForUsers(System.IntPtr self, Steamworks.Data.SteamLeaderboard_t hSteamLeaderboard, Steamworks.SteamId[] prgUsers, int cUsers)
- private static Steamworks.Data.SteamAPICall_t _FindLeaderboard(System.IntPtr self, string pchLeaderboardName)
- private static Steamworks.Data.SteamAPICall_t _FindOrCreateLeaderboard(System.IntPtr self, string pchLeaderboardName, Steamworks.Data.LeaderboardSort eLeaderboardSortMethod, Steamworks.Data.LeaderboardDisplay eLeaderboardDisplayType)
- private static bool _GetAchievement(System.IntPtr self, string pchName, ref bool pbAchieved)
- private static bool _GetAchievementAchievedPercent(System.IntPtr self, string pchName, ref float pflPercent)
- private static bool _GetAchievementAndUnlockTime(System.IntPtr self, string pchName, ref bool pbAchieved, ref uint punUnlockTime)
- private static Steamworks.Utf8StringPointer _GetAchievementDisplayAttribute(System.IntPtr self, string pchName, string pchKey)
- private static int _GetAchievementIcon(System.IntPtr self, string pchName)
- private static Steamworks.Utf8StringPointer _GetAchievementName(System.IntPtr self, uint iAchievement)
- private static bool _GetDownloadedLeaderboardEntry(System.IntPtr self, Steamworks.Data.SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, ref Steamworks.Data.LeaderboardEntry_t pLeaderboardEntry, int[] pDetails, int cDetailsMax)
- private static bool _GetGlobalStat(System.IntPtr self, string pchStatName, ref long pData)
- private static bool _GetGlobalStat(System.IntPtr self, string pchStatName, ref double pData)
- private static int _GetGlobalStatHistory(System.IntPtr self, string pchStatName, long[] pData, uint cubData)
- private static int _GetGlobalStatHistory(System.IntPtr self, string pchStatName, double[] pData, uint cubData)
- private static Steamworks.Data.LeaderboardDisplay _GetLeaderboardDisplayType(System.IntPtr self, Steamworks.Data.SteamLeaderboard_t hSteamLeaderboard)
- private static int _GetLeaderboardEntryCount(System.IntPtr self, Steamworks.Data.SteamLeaderboard_t hSteamLeaderboard)
- private static Steamworks.Utf8StringPointer _GetLeaderboardName(System.IntPtr self, Steamworks.Data.SteamLeaderboard_t hSteamLeaderboard)
- private static Steamworks.Data.LeaderboardSort _GetLeaderboardSortMethod(System.IntPtr self, Steamworks.Data.SteamLeaderboard_t hSteamLeaderboard)
- private static int _GetMostAchievedAchievementInfo(System.IntPtr self, System.IntPtr pchName, uint unNameBufLen, ref float pflPercent, ref bool pbAchieved)
- private static int _GetNextMostAchievedAchievementInfo(System.IntPtr self, int iIteratorPrevious, System.IntPtr pchName, uint unNameBufLen, ref float pflPercent, ref bool pbAchieved)
- private static uint _GetNumAchievements(System.IntPtr self)
- private static Steamworks.Data.SteamAPICall_t _GetNumberOfCurrentPlayers(System.IntPtr self)
- private static bool _GetStat(System.IntPtr self, string pchName, ref int pData)
- private static bool _GetStat(System.IntPtr self, string pchName, ref float pData)
- private static bool _GetUserAchievement(System.IntPtr self, Steamworks.SteamId steamIDUser, string pchName, ref bool pbAchieved)
- private static bool _GetUserAchievementAndUnlockTime(System.IntPtr self, Steamworks.SteamId steamIDUser, string pchName, ref bool pbAchieved, ref uint punUnlockTime)
- private static bool _GetUserStat(System.IntPtr self, Steamworks.SteamId steamIDUser, string pchName, ref int pData)
- private static bool _GetUserStat(System.IntPtr self, Steamworks.SteamId steamIDUser, string pchName, ref float pData)
- private static bool _IndicateAchievementProgress(System.IntPtr self, string pchName, uint nCurProgress, uint nMaxProgress)
- private static bool _RequestCurrentStats(System.IntPtr self)
- private static Steamworks.Data.SteamAPICall_t _RequestGlobalAchievementPercentages(System.IntPtr self)
- private static Steamworks.Data.SteamAPICall_t _RequestGlobalStats(System.IntPtr self, int nHistoryDays)
- private static Steamworks.Data.SteamAPICall_t _RequestUserStats(System.IntPtr self, Steamworks.SteamId steamIDUser)
- private static bool _ResetAllStats(System.IntPtr self, bool bAchievementsToo)
- private static bool _SetAchievement(System.IntPtr self, string pchName)
- private static bool _SetStat(System.IntPtr self, string pchName, int nData)
- private static bool _SetStat(System.IntPtr self, string pchName, float fData)
- private static bool _StoreStats(System.IntPtr self)
- private static bool _UpdateAvgRateStat(System.IntPtr self, string pchName, float flCountThisSession, double dSessionLength)
- private static Steamworks.Data.SteamAPICall_t _UploadLeaderboardScore(System.IntPtr self, Steamworks.Data.SteamLeaderboard_t hSteamLeaderboard, Steamworks.LeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, int[] pScoreDetails, int cScoreDetailsCount)

### internal class Steamworks.ISteamUtils
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamUtils(bool IsGameServer)

#### Methods
- internal bool BOverlayNeedsPresent()
- internal Steamworks.CallResult<Steamworks.Data.CheckFileSignature_t> CheckFileSignature(string szFileName)
- internal int FilterText(out string pchOutFilteredText, string pchInputMessage, bool bLegalOnly)
- internal Steamworks.SteamAPICallFailure GetAPICallFailureReason(Steamworks.Data.SteamAPICall_t hSteamAPICall)
- internal bool GetAPICallResult(Steamworks.Data.SteamAPICall_t hSteamAPICall, System.IntPtr pCallback, int cubCallback, int iCallbackExpected, ref bool pbFailed)
- internal uint GetAppID()
- internal Steamworks.Universe GetConnectedUniverse()
- internal bool GetCSERIPPort(ref uint unIP, ref ushort usPort)
- internal byte GetCurrentBatteryPower()
- internal bool GetEnteredGamepadTextInput(out string pchText)
- internal uint GetEnteredGamepadTextLength()
- internal bool GetImageRGBA(int iImage, byte[] pubDest, int nDestBufferSize)
- internal bool GetImageSize(int iImage, ref uint pnWidth, ref uint pnHeight)
- internal uint GetIPCCallCount()
- internal string GetIPCountry()
- internal Steamworks.SteamIPv6ConnectivityState GetIPv6ConnectivityState(Steamworks.SteamIPv6ConnectivityProtocol eProtocol)
- internal uint GetSecondsSinceAppActive()
- internal uint GetSecondsSinceComputerActive()
- public override System.IntPtr GetServerInterfacePointer()
- internal uint GetServerRealTime()
- internal string GetSteamUILanguage()
- public override System.IntPtr GetUserInterfacePointer()
- internal bool InitFilterText()
- internal bool IsAPICallCompleted(Steamworks.Data.SteamAPICall_t hSteamAPICall, ref bool pbFailed)
- internal bool IsOverlayEnabled()
- internal bool IsSteamChinaLauncher()
- internal bool IsSteamInBigPictureMode()
- internal bool IsSteamRunningInVR()
- internal bool IsVRHeadsetStreamingEnabled()
- internal void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset)
- internal void SetOverlayNotificationPosition(Steamworks.NotificationPosition eNotificationPosition)
- internal void SetVRHeadsetStreamingEnabled(bool bEnabled)
- internal void SetWarningMessageHook(System.IntPtr pFunction)
- internal bool ShowGamepadTextInput(Steamworks.GamepadTextInputMode eInputMode, Steamworks.GamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText)
- internal void StartVRDashboard()
- internal static System.IntPtr SteamAPI_SteamGameServerUtils_v009()
- internal static System.IntPtr SteamAPI_SteamUtils_v009()
- private static bool _BOverlayNeedsPresent(System.IntPtr self)
- private static Steamworks.Data.SteamAPICall_t _CheckFileSignature(System.IntPtr self, string szFileName)
- private static int _FilterText(System.IntPtr self, System.IntPtr pchOutFilteredText, uint nByteSizeOutFilteredText, string pchInputMessage, bool bLegalOnly)
- private static Steamworks.SteamAPICallFailure _GetAPICallFailureReason(System.IntPtr self, Steamworks.Data.SteamAPICall_t hSteamAPICall)
- private static bool _GetAPICallResult(System.IntPtr self, Steamworks.Data.SteamAPICall_t hSteamAPICall, System.IntPtr pCallback, int cubCallback, int iCallbackExpected, ref bool pbFailed)
- private static uint _GetAppID(System.IntPtr self)
- private static Steamworks.Universe _GetConnectedUniverse(System.IntPtr self)
- private static bool _GetCSERIPPort(System.IntPtr self, ref uint unIP, ref ushort usPort)
- private static byte _GetCurrentBatteryPower(System.IntPtr self)
- private static bool _GetEnteredGamepadTextInput(System.IntPtr self, System.IntPtr pchText, uint cchText)
- private static uint _GetEnteredGamepadTextLength(System.IntPtr self)
- private static bool _GetImageRGBA(System.IntPtr self, int iImage, byte[] pubDest, int nDestBufferSize)
- private static bool _GetImageSize(System.IntPtr self, int iImage, ref uint pnWidth, ref uint pnHeight)
- private static uint _GetIPCCallCount(System.IntPtr self)
- private static Steamworks.Utf8StringPointer _GetIPCountry(System.IntPtr self)
- private static Steamworks.SteamIPv6ConnectivityState _GetIPv6ConnectivityState(System.IntPtr self, Steamworks.SteamIPv6ConnectivityProtocol eProtocol)
- private static uint _GetSecondsSinceAppActive(System.IntPtr self)
- private static uint _GetSecondsSinceComputerActive(System.IntPtr self)
- private static uint _GetServerRealTime(System.IntPtr self)
- private static Steamworks.Utf8StringPointer _GetSteamUILanguage(System.IntPtr self)
- private static bool _InitFilterText(System.IntPtr self)
- private static bool _IsAPICallCompleted(System.IntPtr self, Steamworks.Data.SteamAPICall_t hSteamAPICall, ref bool pbFailed)
- private static bool _IsOverlayEnabled(System.IntPtr self)
- private static bool _IsSteamChinaLauncher(System.IntPtr self)
- private static bool _IsSteamInBigPictureMode(System.IntPtr self)
- private static bool _IsSteamRunningInVR(System.IntPtr self)
- private static bool _IsVRHeadsetStreamingEnabled(System.IntPtr self)
- private static void _SetOverlayNotificationInset(System.IntPtr self, int nHorizontalInset, int nVerticalInset)
- private static void _SetOverlayNotificationPosition(System.IntPtr self, Steamworks.NotificationPosition eNotificationPosition)
- private static void _SetVRHeadsetStreamingEnabled(System.IntPtr self, bool bEnabled)
- private static void _SetWarningMessageHook(System.IntPtr self, System.IntPtr pFunction)
- private static bool _ShowGamepadTextInput(System.IntPtr self, Steamworks.GamepadTextInputMode eInputMode, Steamworks.GamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText)
- private static void _StartVRDashboard(System.IntPtr self)

### internal class Steamworks.ISteamVideo
- Base: Steamworks.SteamInterface

#### Constructors
- internal ISteamVideo(bool IsGameServer)

#### Methods
- internal void GetOPFSettings(Steamworks.AppId unVideoAppID)
- internal bool GetOPFStringForApp(Steamworks.AppId unVideoAppID, out string pchBuffer, ref int pnBufferSize)
- public override System.IntPtr GetUserInterfacePointer()
- internal void GetVideoURL(Steamworks.AppId unVideoAppID)
- internal bool IsBroadcasting(ref int pnNumViewers)
- internal static System.IntPtr SteamAPI_SteamVideo_v002()
- private static void _GetOPFSettings(System.IntPtr self, Steamworks.AppId unVideoAppID)
- private static bool _GetOPFStringForApp(System.IntPtr self, Steamworks.AppId unVideoAppID, System.IntPtr pchBuffer, ref int pnBufferSize)
- private static void _GetVideoURL(System.IntPtr self, Steamworks.AppId unVideoAppID)
- private static bool _IsBroadcasting(System.IntPtr self, ref int pnNumViewers)

### internal enum Steamworks.ItemPreviewType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- EnvironmentMap_HorizontalCross = 3
- EnvironmentMap_LatLong = 4
- Image = 0
- ReservedMax = 255
- Sketchfab = 2
- YouTubeVideo = 1

### internal enum Steamworks.ItemState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Downloading = 16
- DownloadPending = 32
- Installed = 4
- LegacyItem = 2
- NeedsUpdate = 8
- None = 0
- Subscribed = 1

### internal enum Steamworks.ItemStatistic
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- NumComments = 10
- NumFavorites = 1
- NumFollowers = 2
- NumPlaytimeSessions = 9
- NumPlaytimeSessionsDuringTimePeriod = 12
- NumSecondsPlayed = 8
- NumSecondsPlayedDuringTimePeriod = 11
- NumSubscriptions = 0
- NumUniqueFavorites = 4
- NumUniqueFollowers = 5
- NumUniqueSubscriptions = 3
- NumUniqueWebsiteViews = 6
- ReportScore = 7

### internal enum Steamworks.ItemUpdateStatus
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CommittingChanges = 5
- Invalid = 0
- PreparingConfig = 1
- PreparingContent = 2
- UploadingContent = 3
- UploadingPreviewFile = 4

### internal enum Steamworks.LaunchOptionType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Benchmark = 9
- Config = 4
- Default = 1
- Dialog = 1000
- Editor = 7
- Manual = 8
- Multiplayer = 3
- None = 0
- OculusVR = 13
- OpenVR = 5
- OpenVROverlay = 14
- Option1 = 10
- Option2 = 11
- Option3 = 12
- OSVR = 15
- SafeMode = 2
- Server = 6

### internal enum Steamworks.LeaderboardDataRequest
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Friends = 2
- Global = 0
- GlobalAroundUser = 1
- Users = 3

### internal enum Steamworks.LeaderboardUploadScoreMethod
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ForceUpdate = 2
- KeepBest = 1
- None = 0

### internal enum Steamworks.LobbyComparison
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Equal = 0
- EqualToOrGreaterThan = 2
- EqualToOrLessThan = -2
- GreaterThan = 1
- LessThan = -1
- NotEqual = 3

### internal enum Steamworks.LobbyDistanceFilter
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Close = 0
- Default = 1
- Far = 2
- Worldwide = 3

### internal enum Steamworks.LobbyType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- FriendsOnly = 1
- Invisible = 3
- Private = 0
- PrivateUnique = 4
- Public = 2

### internal enum Steamworks.MarketingMessageFlags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- HighPriority = 1
- None = 0
- PlatformLinux = 8
- PlatformMac = 4
- PlatformRestrictions = 14
- PlatformWindows = 2

### internal enum Steamworks.MarketNotAllowedReasonFlags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AcceptedWalletGift = 32768
- AccountDisabled = 2
- AccountLimited = 8
- AccountLockedDown = 4
- AccountNotTrusted = 32
- InvalidCookie = 1024
- NewPaymentMethod = 512
- NewPaymentMethodCannotBeVerified = 8192
- None = 0
- NoRecentPurchases = 16384
- RecentPasswordReset = 256
- RecentSelfRefund = 4096
- SteamGuardNotEnabled = 64
- SteamGuardOnlyRecentlyEnabled = 128
- TemporaryFailure = 1
- TradeBanned = 16
- UsingNewDevice = 2048

### internal enum Steamworks.MatchMakingServerResponse
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- NoServersListedOnMasterServer = 2
- ServerFailedToRespond = 1
- ServerResponded = 0

### internal class Steamworks.MonoPInvokeCallbackAttribute
- Base: System.Attribute

#### Constructors
- public MonoPInvokeCallbackAttribute()

### internal struct Steamworks.MotionState

#### Fields
- public float PosAccelX
- public float PosAccelY
- public float PosAccelZ
- public float RotQuatW
- public float RotQuatX
- public float RotQuatY
- public float RotQuatZ
- public float RotVelX
- public float RotVelY
- public float RotVelZ

### public enum Steamworks.MusicStatus
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Idle = 3
- Paused = 2
- Playing = 1
- Undefined = 0

### internal static class Steamworks.SteamAPI.Native

#### Methods
- public static Steamworks.Data.HSteamPipe SteamAPI_GetHSteamPipe()
- public static bool SteamAPI_Init()
- public static bool SteamAPI_RestartAppIfNecessary(uint unOwnAppID)
- public static void SteamAPI_Shutdown()

### internal static class Steamworks.SteamGameServer.Native

#### Methods
- public static Steamworks.Data.HSteamPipe SteamGameServer_GetHSteamPipe()
- public static void SteamGameServer_RunCallbacks()
- public static void SteamGameServer_Shutdown()

### internal static class Steamworks.SteamInternal.Native

#### Methods
- public static bool SteamInternal_GameServer_Init(uint unIP, ushort usPort, ushort usGamePort, ushort usQueryPort, int eServerMode, string pchVersionString)

### internal enum Steamworks.NetConfig
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- EnumerateDevVars = 35
- FakePacketDup_Recv = 27
- FakePacketDup_Send = 26
- FakePacketDup_TimeMax = 28
- FakePacketLag_Recv = 5
- FakePacketLag_Send = 4
- FakePacketLoss_Recv = 3
- FakePacketLoss_Send = 2
- FakePacketReorder_Recv = 7
- FakePacketReorder_Send = 6
- FakePacketReorder_Time = 8
- Invalid = 0
- IP_AllowWithoutAuth = 23
- LogLevel_AckRTT = 13
- LogLevel_Message = 15
- LogLevel_P2PRendezvous = 17
- LogLevel_PacketDecode = 14
- LogLevel_PacketGaps = 16
- LogLevel_SDRRelayPings = 18
- MTU_DataSize = 33
- MTU_PacketSize = 32
- NagleTime = 12
- SDRClient_ConsecutitivePingTimeoutsFail = 20
- SDRClient_ConsecutitivePingTimeoutsFailInitial = 19
- SDRClient_DebugTicketAddress = 30
- SDRClient_FakeClusterPing = 36
- SDRClient_ForceProxyAddr = 31
- SDRClient_ForceRelayCluster = 29
- SDRClient_MinPingsBeforePingAccurate = 21
- SDRClient_SingleSocket = 22
- SendBufferSize = 9
- SendRateMax = 11
- SendRateMin = 10
- TimeoutConnected = 25
- TimeoutInitial = 24
- Unencrypted = 34

### internal enum Steamworks.NetConfigResult
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BadScopeObj = -2
- BadValue = -1
- BufferTooSmall = -3
- OK = 1
- OKInherited = 2

### internal enum Steamworks.NetConfigScope
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Connection = 4
- Global = 1
- ListenSocket = 3
- SocketsInterface = 2

### internal enum Steamworks.NetConfigType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Float = 3
- FunctionPtr = 5
- Int32 = 1
- Int64 = 2
- String = 4

### public enum Steamworks.NetConnectionEnd
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AppException_Generic = 2000
- AppException_Max = 2999
- AppException_Min = 2000
- App_Generic = 1000
- App_Max = 1999
- App_Min = 1000
- Invalid = 0
- Local_HostedServerPrimaryRelay = 3003
- Local_ManyRelayConnectivity = 3002
- Local_Max = 3999
- Local_Min = 3000
- Local_NetworkConfig = 3004
- Local_OfflineMode = 3001
- Local_Rights = 3005
- Misc_Generic = 5001
- Misc_InternalError = 5002
- Misc_Max = 5999
- Misc_Min = 5000
- Misc_NoRelaySessionsToClient = 5006
- Misc_RelayConnectivity = 5004
- Misc_SteamConnectivity = 5005
- Misc_Timeout = 5003
- Remote_BadCert = 4003
- Remote_BadCrypt = 4002
- Remote_BadProtocolVersion = 4006
- Remote_Max = 4999
- Remote_Min = 4000
- Remote_NotLoggedIn = 4004
- Remote_NotRunningApp = 4005
- Remote_Timeout = 4001

### public enum Steamworks.NetDebugOutput
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Bug = 1
- Debug = 7
- Error = 2
- Everything = 8
- Important = 3
- Msg = 5
- None = 0
- Verbose = 6
- Warning = 4

### internal enum Steamworks.NetIdentityType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Force32bit = 2147483647
- GenericBytes = 3
- GenericString = 2
- Invalid = 0
- IPAddress = 1
- SteamID = 16
- UnknownType = 4
- XboxPairwiseID = 17

### public enum Steamworks.NotificationPosition
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BottomLeft = 2
- BottomRight = 3
- TopLeft = 0
- TopRight = 1

### internal enum Steamworks.OverlayToStoreFlag
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AddToCart = 1
- AddToCartAndShow = 2
- None = 0

### public enum Steamworks.P2PSend
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Reliable = 2
- ReliableWithBuffering = 3
- Unreliable = 0
- UnreliableNoDelay = 1

### public enum Steamworks.P2PSessionError
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DestinationNotLoggedIn = 3
- Max = 5
- None = 0
- NoRightsToApp = 2
- NotRunningApp = 1
- Timeout = 4

### public enum Steamworks.ParentalFeature
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Browser = 9
- Community = 2
- Console = 8
- Friends = 4
- Invalid = 0
- Library = 11
- Max = 14
- News = 5
- ParentalSetup = 10
- Profile = 3
- Settings = 7
- SiteLicense = 13
- Store = 1
- Test = 12
- Trading = 6

### public struct Steamworks.PartyBeacon

#### Fields
- internal Steamworks.Data.PartyBeaconID_t Id

#### Properties
- private static Steamworks.ISteamParties Internal { get; }
- public string MetaData { get; }
- public Steamworks.SteamId Owner { get; }

#### Methods
- public void CancelReservation(Steamworks.SteamId steamid)
- public bool Destroy()
- public System.Threading.Tasks.Task<string> JoinAsync()
- public void OnReservationCompleted(Steamworks.SteamId steamid)

### internal enum Steamworks.PersonaChange
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Avatar = 64
- Broadcast = 2048
- ComeOnline = 4
- GamePlayed = 16
- GameServer = 32
- GoneOffline = 8
- JoinedSource = 128
- LeftSource = 256
- Name = 1
- NameFirstSet = 1024
- Nickname = 4096
- RelationshipChanged = 512
- RichPresence = 16384
- Status = 2
- SteamLevel = 8192

### internal static class Steamworks.Platform

#### Fields
- public static const System.Runtime.InteropServices.CallingConvention CC
- public static const string LibraryName
- public static const int StructPackSize
- public static const int StructPlatformPackSize

### internal enum Steamworks.PlayerResult_t
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Abandoned = 2
- Completed = 5
- FailedToConnect = 1
- Incomplete = 4
- Kicked = 3

### internal class Steamworks.PreserveAttribute
- Base: System.Attribute

#### Constructors
- public PreserveAttribute()

### internal enum Steamworks.RegisterActivationCodeResult
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AlreadyOwned = 4
- ResultAlreadyRegistered = 2
- ResultFail = 1
- ResultOK = 0
- ResultTimeout = 3

### public enum Steamworks.Relationship
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Blocked = 1
- Friend = 3
- Ignored = 5
- IgnoredFriend = 6
- Max = 8
- None = 0
- RequestInitiator = 4
- RequestRecipient = 2
- Suggested_DEPRECATED = 7

### internal enum Steamworks.RemoteStoragePlatform
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- All = -1
- Android = 32
- IOS = 64
- Linux = 8
- None = 0
- OSX = 2
- PS3 = 4
- Switch = 16
- Windows = 1

### internal enum Steamworks.RemoteStoragePublishedFileVisibility
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- FriendsOnly = 1
- Private = 2
- Public = 0
- Unlisted = 3

### public enum Steamworks.Result
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AccessDenied = 15
- AccountActivityLimitExceeded = 96
- AccountAssociatedToMultiplePartners = 90
- AccountDeleted = 114
- AccountDisabled = 43
- AccountLimitExceeded = 95
- AccountLockedDown = 73
- AccountLoginDeniedNeedTwoFactor = 85
- AccountLoginDeniedThrottle = 87
- AccountLogonDenied = 63
- AccountLogonDeniedNoMail = 66
- AccountLogonDeniedVerifiedEmailRequired = 74
- AccountNotFeatured = 45
- AccountNotFound = 18
- AccountNotFriends = 111
- AdministratorOK = 46
- AlreadyLoggedInElsewhere = 50
- AlreadyOwned = 30
- AlreadyRedeemed = 28
- BadResponse = 76
- Banned = 17
- Blocked = 40
- Busy = 10
- Cancelled = 52
- CannotUseOldPassword = 64
- CantRemoveItem = 113
- ConnectFailed = 35
- ContentVersion = 47
- DataCorruption = 53
- Disabled = 80
- DiskFull = 54
- DuplicateName = 14
- DuplicateRequest = 29
- EmailSendFailure = 99
- EncryptionFailure = 23
- ExistingUserCancelledLicense = 115
- Expired = 27
- ExpiredLoginAuthCode = 71
- ExternalAccountAlreadyLinked = 59
- ExternalAccountUnlinked = 57
- FacebookQueryError = 70
- Fail = 2
- FileNotFound = 9
- GSLTDenied = 102
- GSLTExpired = 106
- GSOwnerDenied = 103
- HandshakeFailed = 36
- HardwareNotCapableOfIPT = 67
- Ignored = 41
- IllegalPassword = 61
- InsufficientFunds = 107
- InsufficientPrivilege = 24
- InvalidCEGSubmission = 81
- InvalidEmail = 13
- InvalidItemType = 104
- InvalidLoginAuthCode = 65
- InvalidName = 12
- InvalidParam = 8
- InvalidPassword = 5
- InvalidProtocolVer = 7
- InvalidState = 11
- InvalidSteamID = 19
- IOFailure = 37
- IPBanned = 105
- IPLoginRestrictionFailed = 72
- IPNotFound = 31
- IPTInitError = 68
- ItemDeleted = 86
- LimitedUserAccount = 112
- LimitExceeded = 25
- LockingFailed = 33
- LoggedInElsewhere = 6
- LogonSessionReplaced = 34
- NeedCaptcha = 101
- NoConnection = 3
- NoMatch = 42
- NoMatchingURL = 75
- NoMobileDevice = 92
- None = 0
- NoSiteLicensesFound = 109
- NotLoggedOn = 21
- NotModified = 91
- NotSettled = 100
- OK = 1
- ParentalControlRestricted = 69
- PasswordRequiredToKickSession = 49
- PasswordUnset = 56
- Pending = 22
- PersistFailed = 32
- PhoneActivityLimitExceeded = 97
- PSNTicketInvalid = 58
- RateLimitExceeded = 84
- RefundToWallet = 98
- RegionLocked = 83
- RemoteCallFailed = 55
- RemoteDisconnect = 38
- RemoteFileConflict = 60
- RequirePasswordReEntry = 77
- RestrictedDevice = 82
- Revoked = 26
- SameAsPreviousValue = 62
- ServiceReadOnly = 44
- ServiceUnavailable = 20
- ShoppingCartNotFound = 39
- SmsCodeFailed = 94
- Suspended = 51
- TimeNotSynced = 93
- Timeout = 16
- TooManyPending = 108
- TryAnotherCM = 48
- TwoFactorActivationCodeMismatch = 89
- TwoFactorCodeMismatch = 88
- UnexpectedError = 79
- ValueOutOfRange = 78
- WGNetworkSendExceeded = 110

### private struct Steamworks.Dispatch.ResultCallback

#### Fields
- public System.Action continuation
- public bool server

### public enum Steamworks.RoomEnter
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Banned = 6
- ClanDisabled = 8
- CommunityBan = 9
- DoesntExist = 2
- Error = 5
- Full = 4
- Limited = 7
- MemberBlockedYou = 10
- NotAllowed = 3
- RatelimitExceeded = 15
- Success = 1
- YouBlockedMember = 11

### internal enum Steamworks.ServerMode
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Authentication = 2
- AuthenticationAndSecure = 3
- Invalid = 0
- NoAuthentication = 1

### public class Steamworks.SocketManager

#### Fields
- private Steamworks.ISocketManager <Interface>k__BackingField
- private Steamworks.Data.Socket <Socket>k__BackingField
- public System.Collections.Generic.List<Steamworks.Data.Connection> Connected
- public System.Collections.Generic.List<Steamworks.Data.Connection> Connecting
- internal Steamworks.Data.HSteamNetPollGroup pollGroup

#### Properties
- public Steamworks.ISocketManager Interface { get; set; }
- public Steamworks.Data.Socket Socket { get; internal set; }

#### Constructors
- public SocketManager()

#### Methods
- public bool Close()
- internal void Initialize()
- public virtual void OnConnected(Steamworks.Data.Connection connection, Steamworks.Data.ConnectionInfo info)
- public virtual void OnConnecting(Steamworks.Data.Connection connection, Steamworks.Data.ConnectionInfo info)
- public virtual void OnConnectionChanged(Steamworks.Data.Connection connection, Steamworks.Data.ConnectionInfo info)
- public virtual void OnDisconnected(Steamworks.Data.Connection connection, Steamworks.Data.ConnectionInfo info)
- public virtual void OnMessage(Steamworks.Data.Connection connection, Steamworks.Data.NetIdentity identity, System.IntPtr data, int size, long messageNum, long recvTime, int channel)
- public void Receive(int bufferSize = 32)
- internal void ReceiveMessage(System.IntPtr msgPtr)
- public override string ToString()

### internal static class Steamworks.SourceServerQuery

#### Fields
- private static const byte A2S_RULES
- private static readonly byte[] A2S_SERVERQUERY_GETCHALLENGE
- private static readonly System.Collections.Generic.Dictionary<System.Net.IPEndPoint, System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string>>> PendingQueries

#### Constructors
- private static SourceServerQuery()

#### Methods
- private static byte[] Combine(byte[][] arrays)
- private static System.Threading.Tasks.Task<byte[]> GetChallengeData(System.Net.Sockets.UdpClient client)
- internal static System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string>> GetRules(Steamworks.Data.ServerInfo server)
- private static System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string>> GetRules(System.Net.Sockets.UdpClient client)
- private static System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string>> GetRulesImpl(System.Net.IPEndPoint endpoint)
- private static System.Threading.Tasks.Task<byte[]> Receive(System.Net.Sockets.UdpClient client)
- private static System.Threading.Tasks.Task Send(System.Net.Sockets.UdpClient client, byte[] message)

### internal static class Steamworks.SteamAPI

#### Methods
- internal static Steamworks.Data.HSteamPipe GetHSteamPipe()
- internal static bool Init()
- internal static bool RestartAppIfNecessary(uint unOwnAppID)
- internal static void Shutdown()

### internal enum Steamworks.SteamAPICallFailure
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- InvalidHandle = 2
- MismatchedCallback = 3
- NetworkFailure = 1
- None = -1
- SteamGone = 0

### public class Steamworks.SteamApps
- Base: Steamworks.SteamSharedClass<Steamworks.SteamApps>

#### Fields
- private static System.Action<Steamworks.AppId> OnDlcInstalled
- private static System.Action OnNewLaunchParameters

#### Properties
- public static Steamworks.SteamId AppOwner { get; }
- public static string[] AvailableLanguages { get; }
- public static int BuildId { get; }
- public static string CommandLine { get; }
- public static string CurrentBetaName { get; }
- public static string GameLanguage { get; }
- internal static Steamworks.ISteamApps Internal { get; }
- public static bool IsCybercafe { get; }
- public static bool IsLowVoilence { get; }
- public static bool IsSubscribed { get; }
- public static bool IsSubscribedFromFamilySharing { get; }
- public static bool IsSubscribedFromFreeWeekend { get; }
- public static bool IsVACBanned { get; }

#### Events
- public static event System.Action<Steamworks.AppId> OnDlcInstalled
- public static event System.Action OnNewLaunchParameters

#### Constructors
- public SteamApps()

#### Methods
- public static string AppInstallDir(Steamworks.AppId appid = null)
- public static Steamworks.Data.DownloadProgress DlcDownloadProgress(Steamworks.AppId appid)
- public static System.Collections.Generic.IEnumerable<Steamworks.Data.DlcInformation> DlcInformation()
- public static System.Threading.Tasks.Task<System.Nullable<Steamworks.Data.FileDetails>> GetFileDetailsAsync(string filename)
- public static string GetLaunchParam(string param)
- internal override void InitializeInterface(bool server)
- public static void InstallDlc(Steamworks.AppId appid)
- public static System.Collections.Generic.IEnumerable<Steamworks.Data.DepotId> InstalledDepots(Steamworks.AppId appid = null)
- internal static void InstallEvents()
- public static bool IsAppInstalled(Steamworks.AppId appid)
- public static bool IsDlcInstalled(Steamworks.AppId appid)
- public static bool IsSubscribedToApp(Steamworks.AppId appid)
- public static void MarkContentCorrupt(bool missingFilesOnly)
- public static System.DateTime PurchaseTime(Steamworks.AppId appid = null)
- public static void UninstallDlc(Steamworks.AppId appid)

### public class Steamworks.SteamClass

#### Constructors
- protected SteamClass()

#### Methods
- internal abstract void DestroyInterface(bool server)
- internal abstract void InitializeInterface(bool server)

### public static class Steamworks.SteamClient

#### Fields
- private static Steamworks.AppId <AppId>k__BackingField
- private static bool initialized
- private static readonly System.Collections.Generic.List<Steamworks.SteamClass> openInterfaces

#### Properties
- public static Steamworks.AppId AppId { get; internal set; }
- public static bool IsLoggedOn { get; }
- public static bool IsValid { get; }
- public static string Name { get; }
- public static Steamworks.FriendState State { get; }
- public static Steamworks.SteamId SteamId { get; }

#### Constructors
- private static SteamClient()

#### Methods
- internal static void AddInterface<T>()
- internal static void Cleanup()
- public static void Init(uint appid, bool asyncCallbacks = true)
- public static bool RestartAppIfNecessary(uint appid)
- public static void RunCallbacks()
- public static void Shutdown()
- internal static void ShutdownInterfaces()
- internal static void ValidCheck()

### public class Steamworks.SteamClientClass<T>
- Base: Steamworks.SteamClass

#### Fields
- internal static Steamworks.SteamInterface Interface

#### Constructors
- public SteamClientClass<T>()

#### Methods
- internal override void DestroyInterface(bool server)
- internal override void InitializeInterface(bool server)
- internal virtual void SetInterface(bool server, Steamworks.SteamInterface iface)

### internal enum Steamworks.SteamControllerLEDFlag
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- RestoreUserDefault = 1
- SetColor = 0

### internal enum Steamworks.SteamControllerPad
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Left = 0
- Right = 1

### public enum Steamworks.SteamDeviceFormFactor
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Computer = 3
- Phone = 1
- Tablet = 2
- TV = 4
- Unknown = 0

### public class Steamworks.SteamFriends
- Base: Steamworks.SteamClientClass<Steamworks.SteamFriends>

#### Fields
- private static System.Action<Steamworks.Friend, string, string> OnChatMessage
- private static System.Action<Steamworks.Friend> OnFriendRichPresenceUpdate
- private static System.Action<Steamworks.Data.Lobby, Steamworks.SteamId> OnGameLobbyJoinRequested
- private static System.Action<bool> OnGameOverlayActivated
- private static System.Action<Steamworks.Friend, string> OnGameRichPresenceJoinRequested
- private static System.Action<string, string> OnGameServerChangeRequested
- private static System.Action<Steamworks.Friend> OnPersonaStateChange
- private static System.Collections.Generic.Dictionary<string, string> richPresence
- private static bool _listenForFriendsMessages

#### Properties
- internal static Steamworks.ISteamFriends Internal { get; }
- public static bool ListenForFriendsMessages { get; set; }

#### Events
- public static event System.Action<Steamworks.Friend, string, string> OnChatMessage
- public static event System.Action<Steamworks.Friend> OnFriendRichPresenceUpdate
- public static event System.Action<Steamworks.Data.Lobby, Steamworks.SteamId> OnGameLobbyJoinRequested
- public static event System.Action<bool> OnGameOverlayActivated
- public static event System.Action<Steamworks.Friend, string> OnGameRichPresenceJoinRequested
- public static event System.Action<string, string> OnGameServerChangeRequested
- public static event System.Action<Steamworks.Friend> OnPersonaStateChange

#### Constructors
- public SteamFriends()

#### Methods
- internal static System.Threading.Tasks.Task CacheUserInformationAsync(Steamworks.SteamId steamid, bool nameonly)
- public static void ClearRichPresence()
- public static System.Collections.Generic.IEnumerable<Steamworks.Friend> GetBlocked()
- public static System.Threading.Tasks.Task<int> GetFollowerCount(Steamworks.SteamId steamID)
- public static System.Threading.Tasks.Task<Steamworks.SteamId[]> GetFollowingList()
- public static System.Collections.Generic.IEnumerable<Steamworks.Friend> GetFriends()
- public static System.Collections.Generic.IEnumerable<Steamworks.Friend> GetFriendsClanMembers()
- public static System.Collections.Generic.IEnumerable<Steamworks.Friend> GetFriendsOnGameServer()
- public static System.Collections.Generic.IEnumerable<Steamworks.Friend> GetFriendsRequested()
- public static System.Collections.Generic.IEnumerable<Steamworks.Friend> GetFriendsRequestingFriendship()
- private static System.Collections.Generic.IEnumerable<Steamworks.Friend> GetFriendsWithFlag(Steamworks.FriendFlags flag)
- public static System.Collections.Generic.IEnumerable<Steamworks.Friend> GetFromSource(Steamworks.SteamId steamid)
- public static System.Threading.Tasks.Task<System.Nullable<Steamworks.Data.Image>> GetLargeAvatarAsync(Steamworks.SteamId steamid)
- public static System.Threading.Tasks.Task<System.Nullable<Steamworks.Data.Image>> GetMediumAvatarAsync(Steamworks.SteamId steamid)
- public static System.Collections.Generic.IEnumerable<Steamworks.Friend> GetPlayedWith()
- public static string GetRichPresence(string key)
- public static System.Threading.Tasks.Task<System.Nullable<Steamworks.Data.Image>> GetSmallAvatarAsync(Steamworks.SteamId steamid)
- internal override void InitializeInterface(bool server)
- internal void InstallEvents()
- public static System.Threading.Tasks.Task<bool> IsFollowing(Steamworks.SteamId steamID)
- private static void OnFriendChatMessage(Steamworks.Data.GameConnectedFriendChatMsg_t data)
- public static void OpenGameInviteOverlay(Steamworks.SteamId lobby)
- public static void OpenOverlay(string type)
- public static void OpenStoreOverlay(Steamworks.AppId id)
- public static void OpenUserOverlay(Steamworks.SteamId id, string type)
- public static void OpenWebOverlay(string url, bool modal = false)
- public static bool RequestUserInformation(Steamworks.SteamId steamid, bool nameonly = true)
- public static void SetPlayedWith(Steamworks.SteamId steamid)
- public static bool SetRichPresence(string key, string value)

### internal static class Steamworks.SteamGameServer

#### Methods
- internal static Steamworks.Data.HSteamPipe GetHSteamPipe()
- internal static void RunCallbacks()
- internal static void Shutdown()

### public struct Steamworks.SteamId

#### Fields
- public ulong Value

#### Properties
- public uint AccountId { get; }
- public bool IsValid { get; }

#### Methods
- public static Steamworks.SteamId op_Implicit(ulong value)
- public static ulong op_Implicit(Steamworks.SteamId value)
- public override string ToString()

### public class Steamworks.SteamInput
- Base: Steamworks.SteamClientClass<Steamworks.SteamInput>

#### Fields
- internal static System.Collections.Generic.Dictionary<string, Steamworks.Data.InputActionSetHandle_t> ActionSets
- internal static System.Collections.Generic.Dictionary<string, Steamworks.Data.InputAnalogActionHandle_t> AnalogHandles
- internal static System.Collections.Generic.Dictionary<string, Steamworks.Data.InputDigitalActionHandle_t> DigitalHandles
- private static readonly Steamworks.Data.InputHandle_t[] queryArray
- internal static const int STEAM_CONTROLLER_MAX_COUNT

#### Properties
- public static System.Collections.Generic.IEnumerable<Steamworks.Controller> Controllers { get; }
- internal static Steamworks.ISteamInput Internal { get; }

#### Constructors
- public SteamInput()
- private static SteamInput()

#### Methods
- internal static Steamworks.Data.InputActionSetHandle_t GetActionSetHandle(string name)
- internal static Steamworks.Data.InputAnalogActionHandle_t GetAnalogActionHandle(string name)
- public static string GetDigitalActionGlyph(Steamworks.Controller controller, string action)
- internal static Steamworks.Data.InputDigitalActionHandle_t GetDigitalActionHandle(string name)
- internal override void InitializeInterface(bool server)
- public static void RunFrame()

### internal enum Steamworks.SteamInputLEDFlag
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- RestoreUserDefault = 1
- SetColor = 0

### internal class Steamworks.SteamInterface

#### Fields
- private bool <IsServer>k__BackingField
- public System.IntPtr Self
- public System.IntPtr SelfClient
- public System.IntPtr SelfGlobal
- public System.IntPtr SelfServer

#### Properties
- public bool IsServer { get; private set; }
- public bool IsValid { get; }

#### Constructors
- protected SteamInterface()

#### Methods
- public virtual System.IntPtr GetGlobalInterfacePointer()
- public virtual System.IntPtr GetServerInterfacePointer()
- public virtual System.IntPtr GetUserInterfacePointer()
- internal void SetupInterface(bool gameServer)
- internal void ShutdownInterface()

### internal static class Steamworks.SteamInternal

#### Methods
- internal static bool GameServer_Init(uint unIP, ushort usPort, ushort usGamePort, ushort usQueryPort, int eServerMode, string pchVersionString)

### public class Steamworks.SteamInventory
- Base: Steamworks.SteamSharedClass<Steamworks.SteamInventory>

#### Fields
- private static string <Currency>k__BackingField
- private static Steamworks.InventoryDef[] <Definitions>k__BackingField
- private static Steamworks.InventoryItem[] <Items>k__BackingField
- private static System.Action OnDefinitionsUpdated
- private static System.Action<Steamworks.InventoryResult> OnInventoryUpdated
- private static System.Collections.Generic.Dictionary<int, Steamworks.InventoryDef> _defMap

#### Properties
- public static string Currency { get; internal set; }
- public static Steamworks.InventoryDef[] Definitions { get; internal set; }
- internal static Steamworks.ISteamInventory Internal { get; }
- public static Steamworks.InventoryItem[] Items { get; internal set; }

#### Events
- public static event System.Action OnDefinitionsUpdated
- public static event System.Action<Steamworks.InventoryResult> OnInventoryUpdated

#### Constructors
- public SteamInventory()

#### Methods
- public static System.Threading.Tasks.Task<System.Nullable<Steamworks.InventoryResult>> AddPromoItemAsync(Steamworks.Data.InventoryDefId id)
- public static System.Threading.Tasks.Task<System.Nullable<Steamworks.InventoryResult>> CraftItemAsync(Steamworks.InventoryItem[] list, Steamworks.InventoryDef target)
- public static System.Threading.Tasks.Task<System.Nullable<Steamworks.InventoryResult>> CraftItemAsync(Steamworks.InventoryItem.Amount[] list, Steamworks.InventoryDef target)
- public static System.Threading.Tasks.Task<System.Nullable<Steamworks.InventoryResult>> DeserializeAsync(byte[] data, int dataLength = -1)
- public static Steamworks.InventoryDef FindDefinition(Steamworks.Data.InventoryDefId defId)
- public static System.Threading.Tasks.Task<System.Nullable<Steamworks.InventoryResult>> GenerateItemAsync(Steamworks.InventoryDef target, int amount)
- public static bool GetAllItems()
- public static System.Threading.Tasks.Task<System.Nullable<Steamworks.InventoryResult>> GetAllItemsAsync()
- internal static Steamworks.InventoryDef[] GetDefinitions()
- public static System.Threading.Tasks.Task<Steamworks.InventoryDef[]> GetDefinitionsWithPricesAsync()
- public static System.Threading.Tasks.Task<System.Nullable<Steamworks.InventoryResult>> GrantPromoItemsAsync()
- internal override void InitializeInterface(bool server)
- internal static void InstallEvents(bool server)
- private static void InventoryUpdated(Steamworks.Data.SteamInventoryFullUpdate_t x)
- private static void LoadDefinitions()
- public static void LoadItemDefinitions()
- public static System.Threading.Tasks.Task<System.Nullable<Steamworks.Data.InventoryPurchaseResult>> StartPurchaseAsync(Steamworks.InventoryDef[] items)
- public static System.Threading.Tasks.Task<System.Nullable<Steamworks.InventoryResult>> TriggerItemDropAsync(Steamworks.Data.InventoryDefId id)
- public static System.Threading.Tasks.Task<bool> WaitForDefinitions(float timeoutSeconds = 30)

### internal enum Steamworks.SteamIPType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Type4 = 0
- Type6 = 1

### internal enum Steamworks.SteamIPv6ConnectivityProtocol
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- HTTP = 1
- Invalid = 0
- UDP = 2

### internal enum Steamworks.SteamIPv6ConnectivityState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Bad = 2
- Good = 1
- Unknown = 0

### internal enum Steamworks.SteamItemFlags
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Consumed = 512
- NoTrade = 1
- Removed = 256

### public class Steamworks.SteamMatchmaking
- Base: Steamworks.SteamClientClass<Steamworks.SteamMatchmaking>

#### Fields
- private static System.Action<Steamworks.Data.Lobby, Steamworks.Friend, string> OnChatMessage
- private static System.Action<Steamworks.Result, Steamworks.Data.Lobby> OnLobbyCreated
- private static System.Action<Steamworks.Data.Lobby> OnLobbyDataChanged
- private static System.Action<Steamworks.Data.Lobby> OnLobbyEntered
- private static System.Action<Steamworks.Data.Lobby, uint, ushort, Steamworks.SteamId> OnLobbyGameCreated
- private static System.Action<Steamworks.Friend, Steamworks.Data.Lobby> OnLobbyInvite
- private static System.Action<Steamworks.Data.Lobby, Steamworks.Friend, Steamworks.Friend> OnLobbyMemberBanned
- private static System.Action<Steamworks.Data.Lobby, Steamworks.Friend> OnLobbyMemberDataChanged
- private static System.Action<Steamworks.Data.Lobby, Steamworks.Friend> OnLobbyMemberDisconnected
- private static System.Action<Steamworks.Data.Lobby, Steamworks.Friend> OnLobbyMemberJoined
- private static System.Action<Steamworks.Data.Lobby, Steamworks.Friend, Steamworks.Friend> OnLobbyMemberKicked
- private static System.Action<Steamworks.Data.Lobby, Steamworks.Friend> OnLobbyMemberLeave

#### Properties
- internal static Steamworks.ISteamMatchmaking Internal { get; }
- public static Steamworks.Data.LobbyQuery LobbyList { get; }
- internal static int MaxLobbyKeyLength { get; }

#### Events
- public static event System.Action<Steamworks.Data.Lobby, Steamworks.Friend, string> OnChatMessage
- public static event System.Action<Steamworks.Result, Steamworks.Data.Lobby> OnLobbyCreated
- public static event System.Action<Steamworks.Data.Lobby> OnLobbyDataChanged
- public static event System.Action<Steamworks.Data.Lobby> OnLobbyEntered
- public static event System.Action<Steamworks.Data.Lobby, uint, ushort, Steamworks.SteamId> OnLobbyGameCreated
- public static event System.Action<Steamworks.Friend, Steamworks.Data.Lobby> OnLobbyInvite
- public static event System.Action<Steamworks.Data.Lobby, Steamworks.Friend, Steamworks.Friend> OnLobbyMemberBanned
- public static event System.Action<Steamworks.Data.Lobby, Steamworks.Friend> OnLobbyMemberDataChanged
- public static event System.Action<Steamworks.Data.Lobby, Steamworks.Friend> OnLobbyMemberDisconnected
- public static event System.Action<Steamworks.Data.Lobby, Steamworks.Friend> OnLobbyMemberJoined
- public static event System.Action<Steamworks.Data.Lobby, Steamworks.Friend, Steamworks.Friend> OnLobbyMemberKicked
- public static event System.Action<Steamworks.Data.Lobby, Steamworks.Friend> OnLobbyMemberLeave

#### Constructors
- public SteamMatchmaking()

#### Methods
- public static System.Threading.Tasks.Task<System.Nullable<Steamworks.Data.Lobby>> CreateLobbyAsync(int maxMembers = 100)
- public static System.Collections.Generic.IEnumerable<Steamworks.Data.ServerInfo> GetFavoriteServers()
- public static System.Collections.Generic.IEnumerable<Steamworks.Data.ServerInfo> GetHistoryServers()
- internal override void InitializeInterface(bool server)
- internal static void InstallEvents()
- public static System.Threading.Tasks.Task<System.Nullable<Steamworks.Data.Lobby>> JoinLobbyAsync(Steamworks.SteamId lobbyId)
- private static void OnLobbyChatMessageRecievedAPI(Steamworks.Data.LobbyChatMsg_t callback)

### public class Steamworks.SteamMatchmakingServers
- Base: Steamworks.SteamClientClass<Steamworks.SteamMatchmakingServers>

#### Properties
- internal static Steamworks.ISteamMatchmakingServers Internal { get; }

#### Constructors
- public SteamMatchmakingServers()

#### Methods
- internal override void InitializeInterface(bool server)

### public class Steamworks.SteamMusic
- Base: Steamworks.SteamClientClass<Steamworks.SteamMusic>

#### Fields
- private static System.Action OnPlaybackChanged
- private static System.Action<float> OnVolumeChanged

#### Properties
- internal static Steamworks.ISteamMusic Internal { get; }
- public static bool IsEnabled { get; }
- public static bool IsPlaying { get; }
- public static Steamworks.MusicStatus Status { get; }
- public static float Volume { get; set; }

#### Events
- public static event System.Action OnPlaybackChanged
- public static event System.Action<float> OnVolumeChanged

#### Constructors
- public SteamMusic()

#### Methods
- internal override void InitializeInterface(bool server)
- internal static void InstallEvents()
- public static void Pause()
- public static void Play()
- public static void PlayNext()
- public static void PlayPrevious()

### public class Steamworks.SteamNetworking
- Base: Steamworks.SteamSharedClass<Steamworks.SteamNetworking>

#### Fields
- public static System.Action<Steamworks.SteamId, Steamworks.P2PSessionError> OnP2PConnectionFailed
- public static System.Action<Steamworks.SteamId> OnP2PSessionRequest

#### Properties
- internal static Steamworks.ISteamNetworking Internal { get; }

#### Constructors
- public SteamNetworking()

#### Methods
- public static bool AcceptP2PSessionWithUser(Steamworks.SteamId user)
- public static bool AllowP2PPacketRelay(bool allow)
- public static bool CloseP2PSessionWithUser(Steamworks.SteamId user)
- internal override void InitializeInterface(bool server)
- internal static void InstallEvents(bool server)
- public static bool IsP2PPacketAvailable(int channel = 0)
- public static System.Nullable<Steamworks.Data.P2Packet> ReadP2PPacket(int channel = 0)
- public static bool ReadP2PPacket(byte[] buffer, ref uint size, ref Steamworks.SteamId steamid, int channel = 0)
- public static bool ReadP2PPacket(byte* buffer, uint cbuf, ref uint size, ref Steamworks.SteamId steamid, int channel = 0)
- public static bool SendP2PPacket(Steamworks.SteamId steamid, byte[] data, int length = -1, int nChannel = 0, Steamworks.P2PSend sendType = Reliable)
- public static bool SendP2PPacket(Steamworks.SteamId steamid, byte* data, uint length, int nChannel = 1, Steamworks.P2PSend sendType = Reliable)

### public enum Steamworks.SteamNetworkingAvailability
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Attempting = 3
- CannotTry = -102
- Current = 100
- Failed = -101
- Force32bit = 2147483647
- NeverTried = 1
- Previously = -100
- Retrying = -10
- Unknown = 0
- Waiting = 2

### public class Steamworks.SteamNetworkingSockets
- Base: Steamworks.SteamSharedClass<Steamworks.SteamNetworkingSockets>

#### Fields
- private static readonly System.Collections.Generic.Dictionary<uint, Steamworks.ConnectionManager> ConnectionInterfaces
- private static System.Action<Steamworks.Data.Connection, Steamworks.Data.ConnectionInfo> OnConnectionStatusChanged
- private static readonly System.Collections.Generic.Dictionary<uint, Steamworks.SocketManager> SocketInterfaces

#### Properties
- internal static Steamworks.ISteamNetworkingSockets Internal { get; }

#### Events
- public static event System.Action<Steamworks.Data.Connection, Steamworks.Data.ConnectionInfo> OnConnectionStatusChanged

#### Constructors
- public SteamNetworkingSockets()
- private static SteamNetworkingSockets()

#### Methods
- private static void ConnectionStatusChanged(Steamworks.Data.SteamNetConnectionStatusChangedCallback_t data)
- public static T ConnectNormal<T>(Steamworks.Data.NetAddress address)
- public static Steamworks.ConnectionManager ConnectNormal(Steamworks.Data.NetAddress address, Steamworks.IConnectionManager iface)
- public static T ConnectRelay<T>(Steamworks.SteamId serverId, int virtualport = 0)
- public static T CreateNormalSocket<T>(Steamworks.Data.NetAddress address)
- public static Steamworks.SocketManager CreateNormalSocket(Steamworks.Data.NetAddress address, Steamworks.ISocketManager intrface)
- public static T CreateRelaySocket<T>(int virtualport = 0)
- internal static Steamworks.ConnectionManager GetConnectionManager(uint id)
- internal static Steamworks.SocketManager GetSocketManager(uint id)
- internal override void InitializeInterface(bool server)
- internal void InstallEvents(bool server)
- internal static void SetConnectionManager(uint id, Steamworks.ConnectionManager manager)
- internal static void SetSocketManager(uint id, Steamworks.SocketManager manager)

### public class Steamworks.SteamNetworkingUtils
- Base: Steamworks.SteamSharedClass<Steamworks.SteamNetworkingUtils>

#### Fields
- private static Steamworks.SteamNetworkingAvailability <Status>k__BackingField
- private static System.Collections.Concurrent.ConcurrentQueue<Steamworks.SteamNetworkingUtils.DebugMessage> debugMessages
- private static System.Action<Steamworks.NetDebugOutput, string> OnDebugOutput
- private static Steamworks.Data.NetDebugFunc _debugFunc
- private static Steamworks.NetDebugOutput _debugLevel

#### Properties
- public static int ConnectionTimeout { get; set; }
- public static Steamworks.NetDebugOutput DebugLevel { get; set; }
- public static float FakeRecvPacketLag { get; set; }
- public static float FakeRecvPacketLoss { get; set; }
- public static float FakeSendPacketLag { get; set; }
- public static float FakeSendPacketLoss { get; set; }
- internal static Steamworks.ISteamNetworkingUtils Internal { get; }
- public static System.Nullable<Steamworks.Data.NetPingLocation> LocalPingLocation { get; }
- public static long LocalTimestamp { get; }
- public static int SendBufferSize { get; set; }
- public static Steamworks.SteamNetworkingAvailability Status { get; private set; }
- public static int Timeout { get; set; }

#### Events
- public static event System.Action<Steamworks.NetDebugOutput, string> OnDebugOutput

#### Constructors
- public SteamNetworkingUtils()
- private static SteamNetworkingUtils()

#### Methods
- public static int EstimatePingTo(Steamworks.Data.NetPingLocation target)
- internal static float GetConfigFloat(Steamworks.NetConfig type)
- internal static int GetConfigInt(Steamworks.NetConfig type)
- internal override void InitializeInterface(bool server)
- public static void InitRelayNetworkAccess()
- private static void InstallCallbacks(bool server)
- private static void OnDebugMessage(Steamworks.NetDebugOutput nType, System.IntPtr str)
- internal static void OutputDebugMessages()
- internal static bool SetConfigFloat(Steamworks.NetConfig type, float value)
- internal static bool SetConfigInt(Steamworks.NetConfig type, int value)
- internal static bool SetConfigString(Steamworks.NetConfig type, string value)
- public static System.Threading.Tasks.Task WaitForPingDataAsync(float maxAgeInSeconds = 300)

### public class Steamworks.SteamParental
- Base: Steamworks.SteamSharedClass<Steamworks.SteamParental>

#### Fields
- private static System.Action OnSettingsChanged

#### Properties
- internal static Steamworks.ISteamParentalSettings Internal { get; }
- public static bool IsParentalLockEnabled { get; }
- public static bool IsParentalLockLocked { get; }

#### Events
- public static event System.Action OnSettingsChanged

#### Constructors
- public SteamParental()

#### Methods
- public static bool BIsAppInBlockList(Steamworks.AppId app)
- public static bool BIsFeatureInBlockList(Steamworks.ParentalFeature feature)
- internal override void InitializeInterface(bool server)
- internal static void InstallEvents(bool server)
- public static bool IsAppBlocked(Steamworks.AppId app)
- public static bool IsFeatureBlocked(Steamworks.ParentalFeature feature)

### public class Steamworks.SteamParties
- Base: Steamworks.SteamClientClass<Steamworks.SteamParties>

#### Fields
- private static System.Action OnActiveBeaconsUpdated
- private static System.Action OnBeaconLocationsUpdated

#### Properties
- public static int ActiveBeaconCount { get; }
- public static System.Collections.Generic.IEnumerable<Steamworks.PartyBeacon> ActiveBeacons { get; }
- internal static Steamworks.ISteamParties Internal { get; }

#### Events
- public static event System.Action OnActiveBeaconsUpdated
- public static event System.Action OnBeaconLocationsUpdated

#### Constructors
- public SteamParties()

#### Methods
- internal override void InitializeInterface(bool server)
- internal void InstallEvents(bool server)

### internal enum Steamworks.SteamPartyBeaconLocationData
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- IconURLLarge = 4
- IconURLMedium = 3
- IconURLSmall = 2
- Invalid = 0
- Name = 1

### internal enum Steamworks.SteamPartyBeaconLocationType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ChatGroup = 1
- Invalid = 0
- Max = 2

### public class Steamworks.SteamRemotePlay
- Base: Steamworks.SteamClientClass<Steamworks.SteamRemotePlay>

#### Fields
- private static System.Action<Steamworks.Data.RemotePlaySession> OnSessionConnected
- private static System.Action<Steamworks.Data.RemotePlaySession> OnSessionDisconnected

#### Properties
- internal static Steamworks.ISteamRemotePlay Internal { get; }
- public static int SessionCount { get; }

#### Events
- public static event System.Action<Steamworks.Data.RemotePlaySession> OnSessionConnected
- public static event System.Action<Steamworks.Data.RemotePlaySession> OnSessionDisconnected

#### Constructors
- public SteamRemotePlay()

#### Methods
- public static Steamworks.Data.RemotePlaySession GetSession(int index)
- internal override void InitializeInterface(bool server)
- internal void InstallEvents(bool server)
- public static bool SendInvite(Steamworks.SteamId steamid)

### public class Steamworks.SteamRemoteStorage
- Base: Steamworks.SteamClientClass<Steamworks.SteamRemoteStorage>

#### Properties
- public static int FileCount { get; }
- public static System.Collections.Generic.IEnumerable<string> Files { get; }
- internal static Steamworks.ISteamRemoteStorage Internal { get; }
- public static bool IsCloudEnabled { get; }
- public static bool IsCloudEnabledForAccount { get; }
- public static bool IsCloudEnabledForApp { get; set; }
- public static ulong QuotaBytes { get; }
- public static ulong QuotaRemainingBytes { get; }
- public static ulong QuotaUsedBytes { get; }

#### Constructors
- public SteamRemoteStorage()

#### Methods
- public static bool FileDelete(string filename)
- public static bool FileExists(string filename)
- public static bool FileForget(string filename)
- public static bool FilePersisted(string filename)
- public static byte[] FileRead(string filename)
- public static int FileSize(string filename)
- public static System.DateTime FileTime(string filename)
- public static bool FileWrite(string filename, byte[] data)
- internal override void InitializeInterface(bool server)

### public class Steamworks.SteamScreenshots
- Base: Steamworks.SteamClientClass<Steamworks.SteamScreenshots>

#### Fields
- private static System.Action<Steamworks.Result> OnScreenshotFailed
- private static System.Action<Steamworks.Data.Screenshot> OnScreenshotReady
- private static System.Action OnScreenshotRequested

#### Properties
- public static bool Hooked { get; set; }
- internal static Steamworks.ISteamScreenshots Internal { get; }

#### Events
- public static event System.Action<Steamworks.Result> OnScreenshotFailed
- public static event System.Action<Steamworks.Data.Screenshot> OnScreenshotReady
- public static event System.Action OnScreenshotRequested

#### Constructors
- public SteamScreenshots()

#### Methods
- public static System.Nullable<Steamworks.Data.Screenshot> AddScreenshot(string filename, string thumbnail, int width, int height)
- internal override void InitializeInterface(bool server)
- internal static void InstallEvents()
- public static void TriggerScreenshot()
- public static System.Nullable<Steamworks.Data.Screenshot> WriteScreenshot(byte[] data, int width, int height)

### public class Steamworks.SteamServer
- Base: Steamworks.SteamServerClass<Steamworks.SteamServer>

#### Fields
- private static System.Collections.Generic.Dictionary<string, string> KeyValue
- private static System.Action<Steamworks.Result, bool> OnSteamServerConnectFailure
- private static System.Action OnSteamServersConnected
- private static System.Action<Steamworks.Result> OnSteamServersDisconnected
- private static System.Action<Steamworks.SteamId, Steamworks.SteamId, Steamworks.AuthResponse> OnValidateAuthTicketResponse
- private static readonly System.Collections.Generic.List<Steamworks.SteamClass> openInterfaces
- private static int _botcount
- private static bool _dedicatedServer
- private static string _gameDescription
- private static string _gametags
- private static string _mapname
- private static int _maxplayers
- private static string _modDir
- private static bool _passworded
- private static string _product
- private static string _serverName

#### Properties
- public static int AutomaticHeartbeatRate { set; }
- public static bool AutomaticHeartbeats { set; }
- public static int BotCount { get; set; }
- public static bool DedicatedServer { get; set; }
- public static string GameDescription { get; internal set; }
- public static string GameTags { get; set; }
- internal static Steamworks.ISteamGameServer Internal { get; }
- public static bool IsValid { get; }
- public static bool LoggedOn { get; }
- public static string MapName { get; set; }
- public static int MaxPlayers { get; set; }
- public static string ModDir { get; internal set; }
- public static bool Passworded { get; set; }
- public static string Product { get; internal set; }
- public static System.Net.IPAddress PublicIp { get; }
- public static string ServerName { get; set; }

#### Events
- public static event System.Action<Steamworks.Result, bool> OnSteamServerConnectFailure
- public static event System.Action OnSteamServersConnected
- public static event System.Action<Steamworks.Result> OnSteamServersDisconnected
- public static event System.Action<Steamworks.SteamId, Steamworks.SteamId, Steamworks.AuthResponse> OnValidateAuthTicketResponse

#### Constructors
- public SteamServer()
- private static SteamServer()

#### Methods
- internal static void AddInterface<T>()
- public static bool BeginAuthSession(byte[] data, Steamworks.SteamId steamid)
- public static void ClearKeys()
- public static void EndSession(Steamworks.SteamId steamid)
- public static void ForceHeartbeat()
- public static bool GetOutgoingPacket(out Steamworks.Data.OutgoingPacket packet)
- public static void HandleIncomingPacket(byte[] data, int size, uint address, ushort port)
- public static void HandleIncomingPacket(System.IntPtr ptr, int size, uint address, ushort port)
- public static void Init(Steamworks.AppId appid, Steamworks.SteamServerInit init, bool asyncCallbacks = true)
- internal override void InitializeInterface(bool server)
- internal static void InstallEvents()
- public static void LogOff()
- public static void LogOnAnonymous()
- public static void RunCallbacks()
- public static void SetKey(string Key, string Value)
- public static void Shutdown()
- internal static void ShutdownInterfaces()
- public static void UpdatePlayer(Steamworks.SteamId steamid, string name, int score)
- public static Steamworks.UserHasLicenseForAppResult UserHasLicenseForApp(Steamworks.SteamId steamid, Steamworks.AppId appid)

### public class Steamworks.SteamServerClass<T>
- Base: Steamworks.SteamClass

#### Fields
- internal static Steamworks.SteamInterface Interface

#### Constructors
- public SteamServerClass<T>()

#### Methods
- internal override void DestroyInterface(bool server)
- internal override void InitializeInterface(bool server)
- internal virtual void SetInterface(bool server, Steamworks.SteamInterface iface)

### public struct Steamworks.SteamServerInit

#### Fields
- public bool DedicatedServer
- public string GameDescription
- public ushort GamePort
- public System.Net.IPAddress IpAddress
- public string ModDir
- public ushort QueryPort
- public bool Secure
- public ushort SteamPort
- public string VersionString

#### Constructors
- public SteamServerInit(string modDir, string gameDesc)

#### Methods
- public Steamworks.SteamServerInit WithQueryShareGamePort()
- public Steamworks.SteamServerInit WithRandomSteamPort()

### public class Steamworks.SteamServerStats
- Base: Steamworks.SteamServerClass<Steamworks.SteamServerStats>

#### Properties
- internal static Steamworks.ISteamGameServerStats Internal { get; }

#### Constructors
- public SteamServerStats()

#### Methods
- public static bool ClearAchievement(Steamworks.SteamId steamid, string name)
- public static bool GetAchievement(Steamworks.SteamId steamid, string name)
- public static float GetFloat(Steamworks.SteamId steamid, string name, float defaultValue = 0)
- public static int GetInt(Steamworks.SteamId steamid, string name, int defaultValue = 0)
- internal override void InitializeInterface(bool server)
- public static System.Threading.Tasks.Task<Steamworks.Result> RequestUserStatsAsync(Steamworks.SteamId steamid)
- public static bool SetAchievement(Steamworks.SteamId steamid, string name)
- public static bool SetFloat(Steamworks.SteamId steamid, string name, float stat)
- public static bool SetInt(Steamworks.SteamId steamid, string name, int stat)
- public static System.Threading.Tasks.Task<Steamworks.Result> StoreUserStats(Steamworks.SteamId steamid)

### public class Steamworks.SteamSharedClass<T>
- Base: Steamworks.SteamClass

#### Fields
- internal static Steamworks.SteamInterface InterfaceClient
- internal static Steamworks.SteamInterface InterfaceServer

#### Properties
- internal static Steamworks.SteamInterface Interface { get; }

#### Constructors
- public SteamSharedClass<T>()

#### Methods
- internal override void DestroyInterface(bool server)
- internal override void InitializeInterface(bool server)
- internal virtual void SetInterface(bool server, Steamworks.SteamInterface iface)

### internal enum Steamworks.SteamTVRegionBehavior
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ClickPopup = 1
- ClickSurroundingRegion = 2
- Hover = 0
- Invalid = -1

### public class Steamworks.SteamUGC
- Base: Steamworks.SteamSharedClass<Steamworks.SteamUGC>

#### Fields
- private static System.Action<Steamworks.Result> OnDownloadItemResult

#### Properties
- internal static Steamworks.ISteamUGC Internal { get; }

#### Events
- public static event System.Action<Steamworks.Result> OnDownloadItemResult

#### Constructors
- public SteamUGC()

#### Methods
- public static System.Threading.Tasks.Task<bool> DeleteFileAsync(Steamworks.Data.PublishedFileId fileId)
- public static bool Download(Steamworks.Data.PublishedFileId fileId, bool highPriority = false)
- public static System.Threading.Tasks.Task<bool> DownloadAsync(Steamworks.Data.PublishedFileId fileId, System.Action<float> progress = null, int milisecondsUpdateDelay = 60, System.Threading.CancellationToken ct = null)
- internal override void InitializeInterface(bool server)
- internal static void InstallEvents(bool server)
- public static System.Threading.Tasks.Task<System.Nullable<Steamworks.Ugc.Item>> QueryFileAsync(Steamworks.Data.PublishedFileId fileId)
- public static System.Threading.Tasks.Task<bool> StartPlaytimeTracking(Steamworks.Data.PublishedFileId fileId)
- public static System.Threading.Tasks.Task<bool> StopPlaytimeTracking(Steamworks.Data.PublishedFileId fileId)
- public static System.Threading.Tasks.Task<bool> StopPlaytimeTrackingForAllItems()

### public class Steamworks.SteamUser
- Base: Steamworks.SteamClientClass<Steamworks.SteamUser>

#### Fields
- private static System.Action OnClientGameServerDeny
- private static System.Action<Steamworks.Data.DurationControl> OnDurationControl
- private static System.Action<string> OnGameWebCallback
- private static System.Action<Steamworks.Data.GetAuthSessionTicketResponse_t> OnGetAuthSessionTicketResponse
- private static System.Action OnLicensesUpdated
- private static System.Action<Steamworks.AppId, ulong, bool> OnMicroTxnAuthorizationResponse
- private static System.Action OnSteamServerConnectFailure
- private static System.Action OnSteamServersConnected
- private static System.Action OnSteamServersDisconnected
- private static System.Action<Steamworks.SteamId, Steamworks.SteamId, Steamworks.AuthResponse> OnValidateAuthTicketResponse
- private static byte[] readBuffer
- private static System.Collections.Generic.Dictionary<string, string> richPresence
- private static uint sampleRate
- private static bool _recordingVoice

#### Properties
- public static bool HasVoiceData { get; }
- internal static Steamworks.ISteamUser Internal { get; }
- public static bool IsBehindNAT { get; }
- public static bool IsPhoneIdentifying { get; }
- public static bool IsPhoneRequiringVerification { get; }
- public static bool IsPhoneVerified { get; }
- public static bool IsTwoFactorEnabled { get; }
- public static uint OptimalSampleRate { get; }
- public static uint SampleRate { get; set; }
- public static int SteamLevel { get; }
- public static bool VoiceRecord { get; set; }

#### Events
- public static event System.Action OnClientGameServerDeny
- public static event System.Action<Steamworks.Data.DurationControl> OnDurationControl
- public static event System.Action<string> OnGameWebCallback
- internal static event System.Action<Steamworks.Data.GetAuthSessionTicketResponse_t> OnGetAuthSessionTicketResponse
- public static event System.Action OnLicensesUpdated
- public static event System.Action<Steamworks.AppId, ulong, bool> OnMicroTxnAuthorizationResponse
- public static event System.Action OnSteamServerConnectFailure
- public static event System.Action OnSteamServersConnected
- public static event System.Action OnSteamServersDisconnected
- public static event System.Action<Steamworks.SteamId, Steamworks.SteamId, Steamworks.AuthResponse> OnValidateAuthTicketResponse

#### Constructors
- public SteamUser()
- private static SteamUser()

#### Methods
- public static Steamworks.BeginAuthResult BeginAuthSession(byte[] ticketData, Steamworks.SteamId steamid)
- public static int DecompressVoice(System.IO.Stream input, int length, System.IO.Stream output)
- public static int DecompressVoice(byte[] from, System.IO.Stream output)
- public static void EndAuthSession(Steamworks.SteamId steamid)
- public static Steamworks.AuthTicket GetAuthSessionTicket()
- public static System.Threading.Tasks.Task<Steamworks.AuthTicket> GetAuthSessionTicketAsync(double timeoutSeconds = 10)
- public static System.Threading.Tasks.Task<Steamworks.Data.DurationControl> GetDurationControl()
- public static System.Threading.Tasks.Task<string> GetStoreAuthUrlAsync(string url)
- internal override void InitializeInterface(bool server)
- internal static void InstallEvents()
- public static int ReadVoiceData(System.IO.Stream stream)
- public static byte[] ReadVoiceDataBytes()
- public static System.Threading.Tasks.Task<byte[]> RequestEncryptedAppTicketAsync(byte[] dataToInclude)
- public static System.Threading.Tasks.Task<byte[]> RequestEncryptedAppTicketAsync()

### public class Steamworks.SteamUserStats
- Base: Steamworks.SteamClientClass<Steamworks.SteamUserStats>

#### Fields
- private static bool <StatsRecieved>k__BackingField
- private static System.Action<string, int> OnAchievementIconFetched
- private static System.Action<Steamworks.Data.Achievement, int, int> OnAchievementProgress
- private static System.Action<Steamworks.SteamId, Steamworks.Result> OnUserStatsReceived
- private static System.Action<Steamworks.Result> OnUserStatsStored
- private static System.Action<Steamworks.SteamId> OnUserStatsUnloaded

#### Properties
- public static System.Collections.Generic.IEnumerable<Steamworks.Data.Achievement> Achievements { get; }
- internal static Steamworks.ISteamUserStats Internal { get; }
- public static bool StatsRecieved { get; internal set; }

#### Events
- internal static event System.Action<string, int> OnAchievementIconFetched
- public static event System.Action<Steamworks.Data.Achievement, int, int> OnAchievementProgress
- public static event System.Action<Steamworks.SteamId, Steamworks.Result> OnUserStatsReceived
- public static event System.Action<Steamworks.Result> OnUserStatsStored
- public static event System.Action<Steamworks.SteamId> OnUserStatsUnloaded

#### Constructors
- public SteamUserStats()

#### Methods
- public static bool AddStat(string name, int amount = 1)
- public static bool AddStat(string name, float amount = 1)
- public static System.Threading.Tasks.Task<System.Nullable<Steamworks.Data.Leaderboard>> FindLeaderboardAsync(string name)
- public static System.Threading.Tasks.Task<System.Nullable<Steamworks.Data.Leaderboard>> FindOrCreateLeaderboardAsync(string name, Steamworks.Data.LeaderboardSort sort, Steamworks.Data.LeaderboardDisplay display)
- public static float GetStatFloat(string name)
- public static int GetStatInt(string name)
- public static bool IndicateAchievementProgress(string achName, int curProg, int maxProg)
- internal override void InitializeInterface(bool server)
- internal static void InstallEvents()
- public static System.Threading.Tasks.Task<int> PlayerCountAsync()
- public static bool RequestCurrentStats()
- public static System.Threading.Tasks.Task<Steamworks.Result> RequestGlobalStatsAsync(int days)
- public static bool ResetAll(bool includeAchievements)
- public static bool SetStat(string name, int value)
- public static bool SetStat(string name, float value)
- public static bool StoreStats()

### internal enum Steamworks.SteamUserStatType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ACHIEVEMENTS = 4
- AVGRATE = 3
- FLOAT = 2
- GROUPACHIEVEMENTS = 5
- INT = 1
- INVALID = 0
- MAX = 6

### public class Steamworks.SteamUtils
- Base: Steamworks.SteamSharedClass<Steamworks.SteamUtils>

#### Fields
- private static System.Action<bool> OnGamepadTextInputDismissed
- private static System.Action OnIpCountryChanged
- private static System.Action<int> OnLowBatteryPower
- private static System.Action OnSteamShutdown
- private static Steamworks.NotificationPosition overlayNotificationPosition

#### Properties
- public static Steamworks.Universe ConnectedUniverse { get; }
- public static float CurrentBatteryPower { get; }
- public static bool DoesOverlayNeedPresent { get; }
- internal static Steamworks.ISteamUtils Internal { get; }
- public static string IpCountry { get; }
- public static bool IsOverlayEnabled { get; }
- public static bool IsSteamChinaLauncher { get; }
- public static bool IsSteamInBigPictureMode { get; }
- public static bool IsSteamRunningInVR { get; }
- public static Steamworks.NotificationPosition OverlayNotificationPosition { get; set; }
- public static uint SecondsSinceAppActive { get; }
- public static uint SecondsSinceComputerActive { get; }
- public static System.DateTime SteamServerTime { get; }
- public static string SteamUILanguage { get; }
- public static bool UsingBatteryPower { get; }
- public static bool VrHeadsetStreaming { get; set; }

#### Events
- public static event System.Action<bool> OnGamepadTextInputDismissed
- public static event System.Action OnIpCountryChanged
- public static event System.Action<int> OnLowBatteryPower
- public static event System.Action OnSteamShutdown

#### Constructors
- public SteamUtils()
- private static SteamUtils()

#### Methods
- public static System.Threading.Tasks.Task<Steamworks.CheckFileSignature> CheckFileSignatureAsync(string filename)
- public static string GetEnteredGamepadText()
- public static System.Nullable<Steamworks.Data.Image> GetImage(int image)
- public static bool GetImageSize(int image, out uint width, out uint height)
- internal override void InitializeInterface(bool server)
- internal static void InstallEvents(bool server)
- internal static bool IsCallComplete(Steamworks.Data.SteamAPICall_t call, out bool failed)
- public static void SetOverlayNotificationInset(int x, int y)
- public static bool ShowGamepadTextInput(Steamworks.GamepadTextInputMode inputMode, Steamworks.GamepadTextInputLineMode lineInputMode, string description, int maxChars, string existingText = "")
- public static void StartVRDashboard()
- private static void SteamClosed()

### public class Steamworks.SteamVideo
- Base: Steamworks.SteamClientClass<Steamworks.SteamVideo>

#### Fields
- private static System.Action OnBroadcastStarted
- private static System.Action<Steamworks.BroadcastUploadResult> OnBroadcastStopped

#### Properties
- internal static Steamworks.ISteamVideo Internal { get; }
- public static bool IsBroadcasting { get; }
- public static int NumViewers { get; }

#### Events
- public static event System.Action OnBroadcastStarted
- public static event System.Action<Steamworks.BroadcastUploadResult> OnBroadcastStopped

#### Constructors
- public SteamVideo()

#### Methods
- internal override void InitializeInterface(bool server)
- internal static void InstallEvents()

### internal enum Steamworks.UGCQuery
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AcceptedForGameRankedByAcceptanceDate = 2
- CreatedByFollowedUsersRankedByPublicationDate = 7
- CreatedByFriendsRankedByPublicationDate = 5
- FavoritedByFriendsRankedByPublicationDate = 4
- NotYetRated = 8
- RankedByAveragePlaytimeTrend = 15
- RankedByLifetimeAveragePlaytime = 16
- RankedByLifetimePlaytimeSessions = 18
- RankedByNumTimesReported = 6
- RankedByPlaytimeSessionsTrend = 17
- RankedByPlaytimeTrend = 13
- RankedByPublicationDate = 1
- RankedByTextSearch = 11
- RankedByTotalPlaytime = 14
- RankedByTotalUniqueSubscriptions = 12
- RankedByTotalVotesAsc = 9
- RankedByTrend = 3
- RankedByVote = 0
- RankedByVotesUp = 10

### internal enum Steamworks.UGCReadAction
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- lose = 2
- ontinueReading = 1
- ontinueReadingUntilFinished = 0

### public enum Steamworks.UgcType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- All = -1
- AllGuides = 7
- Artwork = 4
- Collections = 3
- ControllerBindings = 11
- GameManagedItems = 12
- IntegratedGuides = 9
- Items = 0
- Items_Mtx = 1
- Items_ReadyToUse = 2
- Screenshots = 6
- UsableInGame = 10
- Videos = 5
- WebGuides = 8

### public enum Steamworks.Universe
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Beta = 2
- Dev = 4
- Internal = 3
- Invalid = 0
- Max = 5
- Public = 1

### public enum Steamworks.UserHasLicenseForAppResult
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- DoesNotHaveLicense = 1
- HasLicense = 0
- NoAuth = 2

### internal enum Steamworks.UserRestriction
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AnyChat = 2
- GameInvites = 32
- GroupChat = 8
- None = 0
- Rating = 16
- Trading = 64
- Unknown = 1
- VoiceChat = 4

### internal enum Steamworks.UserUGCList
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Favorited = 5
- Followed = 8
- Published = 0
- Subscribed = 6
- UsedOrPlayed = 7
- VotedDown = 3
- VotedOn = 1
- VotedUp = 2
- WillVoteLater = 4

### internal enum Steamworks.UserUGCListSortOrder
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- CreationOrderAsc = 1
- CreationOrderDesc = 0
- ForModeration = 6
- LastUpdatedDesc = 3
- SubscriptionDateDesc = 4
- TitleAsc = 2
- VoteScoreDesc = 5

### internal struct Steamworks.Utf8StringPointer

#### Fields
- internal System.IntPtr ptr

#### Methods
- public static string op_Implicit(Steamworks.Utf8StringPointer p)

### internal class Steamworks.Utf8StringToNative
- Interfaces: System.Runtime.InteropServices.ICustomMarshaler

#### Constructors
- public Utf8StringToNative()

#### Methods
- public void CleanUpManagedData(object managedObj)
- public void CleanUpNativeData(System.IntPtr pNativeData)
- public static System.Runtime.InteropServices.ICustomMarshaler GetInstance(string cookie)
- public int GetNativeDataSize()
- public System.IntPtr MarshalManagedToNative(object managedObj)
- public object MarshalNativeToManaged(System.IntPtr pNativeData)

### public static class Steamworks.Utility

#### Fields
- private static readonly byte[] readBuffer

#### Constructors
- private static Utility()

#### Methods
- public static string FormatPrice(string currency, double price)
- public static System.Net.IPAddress Int32ToIp(uint ipAddress)
- public static uint IpToInt32(System.Net.IPAddress ipAddress)
- public static string ReadNullTerminatedUTF8String(System.IO.BinaryReader br)
- internal static uint Swap(uint x)
- internal static T ToType<T>(System.IntPtr ptr)
- internal static object ToType(System.IntPtr ptr, System.Type t)

### internal enum Steamworks.VoiceResult
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- BufferTooSmall = 4
- DataCorrupted = 5
- NoData = 3
- NotInitialized = 1
- NotRecording = 2
- OK = 0
- ReceiverDidNotAnswer = 9
- ReceiverOutOfDate = 8
- Restricted = 6
- UnsupportedCodec = 7

### internal enum Steamworks.VRHMDType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- MDType_Acer_Unknown = 50
- MDType_Acer_WindowsMR = 51
- MDType_Dell_Unknown = 60
- MDType_Dell_Visor = 61
- MDType_HP_Reverb = 82
- MDType_HP_Unknown = 80
- MDType_HP_WindowsMR = 81
- MDType_HTC_Dev = 1
- MDType_HTC_Unknown = 20
- MDType_HTC_Vive = 3
- MDType_HTC_ViveCosmos = 5
- MDType_HTC_VivePre = 2
- MDType_HTC_VivePro = 4
- MDType_Huawei_EndOfRange = 129
- MDType_Huawei_Unknown = 120
- MDType_Huawei_VR2 = 121
- MDType_Lenovo_Explorer = 71
- MDType_Lenovo_Unknown = 70
- MDType_None = -1
- MDType_Oculus_DK1 = 21
- MDType_Oculus_DK2 = 22
- MDType_Oculus_Quest = 25
- MDType_Oculus_Rift = 23
- MDType_Oculus_RiftS = 24
- MDType_Oculus_Unknown = 40
- MDType_Samsung_Odyssey = 91
- MDType_Samsung_Unknown = 90
- MDType_Unannounced_Unknown = 100
- MDType_Unannounced_WindowsMR = 101
- MDType_Unknown = 0
- mdType_Valve_Index = 131
- mdType_Valve_Unknown = 130
- MDType_vridge = 110

### internal enum Steamworks.VRScreenshotType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Mono = 1
- MonoCubemap = 3
- MonoPanorama = 4
- None = 0
- Stereo = 2
- StereoPanorama = 5

### internal enum Steamworks.WorkshopEnumerationType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- ContentByFriends = 5
- FavoritesOfFriends = 3
- RankedByVote = 0
- Recent = 1
- RecentFromFollowedUsers = 6
- Trending = 2
- VotedByFriends = 4

### internal enum Steamworks.WorkshopFileAction
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Completed = 1
- Played = 0

### internal enum Steamworks.WorkshopFileType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Art = 3
- Collection = 2
- Community = 0
- Concept = 8
- ControllerBinding = 12
- First = 0
- Game = 6
- GameManagedItem = 15
- IntegratedGuide = 10
- Max = 16
- Merch = 11
- Microtransaction = 1
- Screenshot = 5
- Software = 7
- SteamVideo = 14
- SteamworksAccessInvite = 13
- Video = 4
- WebGuide = 9

### internal enum Steamworks.WorkshopVideoProvider
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- None = 0
- Youtube = 1

### internal enum Steamworks.WorkshopVote
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Against = 2
- For = 1
- Later = 3
- Unvoted = 0

### internal enum Steamworks.XboxOrigin
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- A = 0
- B = 1
- Count = 28
- DPad_East = 27
- DPad_North = 24
- DPad_South = 25
- DPad_West = 26
- LeftBumper = 4
- LeftStick_Click = 13
- LeftStick_DPadEast = 17
- LeftStick_DPadNorth = 14
- LeftStick_DPadSouth = 15
- LeftStick_DPadWest = 16
- LeftStick_Move = 12
- LeftTrigger_Click = 9
- LeftTrigger_Pull = 8
- Menu = 6
- RightBumper = 5
- RightStick_Click = 19
- RightStick_DPadEast = 23
- RightStick_DPadNorth = 20
- RightStick_DPadSouth = 21
- RightStick_DPadWest = 22
- RightStick_Move = 18
- RightTrigger_Click = 11
- RightTrigger_Pull = 10
- View = 7
- X = 2
- Y = 3

## Namespace: Steamworks.Data

### private class Steamworks.Data.Achievement.<>c__DisplayClass14_0

#### Fields
- public bool gotCallback
- public int i
- public string ident

#### Constructors
- public Achievement.<>c__DisplayClass14_0()

#### Methods
- internal void <GetIconAsync>g__f|0(string x, int icon)

### private class Steamworks.Data.Leaderboard.<AttachUgc>d__13
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.Data.Leaderboard <>4__this
- private System.Nullable<Steamworks.Data.LeaderboardUGCSet_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Steamworks.Result> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.LeaderboardUGCSet_t> <>u__1
- private System.Nullable<Steamworks.Data.LeaderboardUGCSet_t> <r>5__1
- public Steamworks.Data.Ugc file

#### Constructors
- public Leaderboard.<AttachUgc>d__13()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.Data.Stat.<GetGlobalFloatDays>d__14
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.Data.Stat <>4__this
- private System.Nullable<Steamworks.Data.GlobalStatsReceived_t> <>s__4
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<double[]> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.GlobalStatsReceived_t> <>u__1
- private double[] <r>5__2
- private System.Nullable<Steamworks.Data.GlobalStatsReceived_t> <result>5__1
- private int <rows>5__3
- public int days

#### Constructors
- public Stat.<GetGlobalFloatDays>d__14()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.Data.Stat.<GetGlobalIntDaysAsync>d__13
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.Data.Stat <>4__this
- private System.Nullable<Steamworks.Data.GlobalStatsReceived_t> <>s__4
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<long[]> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.GlobalStatsReceived_t> <>u__1
- private long[] <r>5__2
- private System.Nullable<Steamworks.Data.GlobalStatsReceived_t> <result>5__1
- private int <rows>5__3
- public int days

#### Constructors
- public Stat.<GetGlobalIntDaysAsync>d__13()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.Data.Achievement.<GetIconAsync>d__14
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.Data.Achievement <>4__this
- private Steamworks.Data.Achievement.<>c__DisplayClass14_0 <>8__1
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.Data.Image>> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1
- private int <waited>5__2
- public int timeout

#### Constructors
- public Achievement.<GetIconAsync>d__14()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.Data.Leaderboard.<GetScoresAroundUserAsync>d__15
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.Data.Leaderboard <>4__this
- private System.Nullable<Steamworks.Data.LeaderboardScoresDownloaded_t> <>s__2
- private Steamworks.Data.LeaderboardEntry[] <>s__3
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Steamworks.Data.LeaderboardEntry[]> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.LeaderboardScoresDownloaded_t> <>u__1
- private System.Runtime.CompilerServices.TaskAwaiter<Steamworks.Data.LeaderboardEntry[]> <>u__2
- private System.Nullable<Steamworks.Data.LeaderboardScoresDownloaded_t> <r>5__1
- public int end
- public int start

#### Constructors
- public Leaderboard.<GetScoresAroundUserAsync>d__15()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.Data.Leaderboard.<GetScoresAsync>d__14
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.Data.Leaderboard <>4__this
- private System.Nullable<Steamworks.Data.LeaderboardScoresDownloaded_t> <>s__2
- private Steamworks.Data.LeaderboardEntry[] <>s__3
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Steamworks.Data.LeaderboardEntry[]> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.LeaderboardScoresDownloaded_t> <>u__1
- private System.Runtime.CompilerServices.TaskAwaiter<Steamworks.Data.LeaderboardEntry[]> <>u__2
- private System.Nullable<Steamworks.Data.LeaderboardScoresDownloaded_t> <r>5__1
- public int count
- public int offset

#### Constructors
- public Leaderboard.<GetScoresAsync>d__14()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.Data.Leaderboard.<GetScoresFromFriendsAsync>d__16
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.Data.Leaderboard <>4__this
- private System.Nullable<Steamworks.Data.LeaderboardScoresDownloaded_t> <>s__2
- private Steamworks.Data.LeaderboardEntry[] <>s__3
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Steamworks.Data.LeaderboardEntry[]> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.LeaderboardScoresDownloaded_t> <>u__1
- private System.Runtime.CompilerServices.TaskAwaiter<Steamworks.Data.LeaderboardEntry[]> <>u__2
- private System.Nullable<Steamworks.Data.LeaderboardScoresDownloaded_t> <r>5__1

#### Constructors
- public Leaderboard.<GetScoresFromFriendsAsync>d__16()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.Data.Lobby.<get_Data>d__16
- Interfaces: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private System.Collections.Generic.KeyValuePair<string, string> <>2__current
- public Steamworks.Data.Lobby <>3__<>4__this
- public Steamworks.Data.Lobby <>4__this
- private int <>l__initialThreadId
- private string <a>5__3
- private string <b>5__4
- private int <cnt>5__1
- private int <i>5__2

#### Properties
- private System.Collections.Generic.KeyValuePair<string, string> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public Lobby.<get_Data>d__16(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class Steamworks.Data.Lobby.<get_Members>d__11
- Interfaces: System.Collections.Generic.IEnumerable<Steamworks.Friend>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Steamworks.Friend>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private Steamworks.Friend <>2__current
- public Steamworks.Data.Lobby <>3__<>4__this
- public Steamworks.Data.Lobby <>4__this
- private int <>l__initialThreadId
- private int <i>5__1

#### Properties
- private Steamworks.Friend System.Collections.Generic.IEnumerator<Steamworks.Friend>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public Lobby.<get_Members>d__11(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<Steamworks.Friend> System.Collections.Generic.IEnumerable<Steamworks.Friend>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class Steamworks.Data.Lobby.<Join>d__5
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.Data.Lobby <>4__this
- private System.Nullable<Steamworks.Data.LobbyEnter_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Steamworks.RoomEnter> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.LobbyEnter_t> <>u__1
- private System.Nullable<Steamworks.Data.LobbyEnter_t> <result>5__1

#### Constructors
- public Lobby.<Join>d__5()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.Data.Leaderboard.<LeaderboardResultToEntries>d__17
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.Data.Leaderboard <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Steamworks.Data.LeaderboardEntry[]> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1
- private Steamworks.Data.LeaderboardEntry_t <e>5__2
- private int <i>5__3
- private Steamworks.Data.LeaderboardEntry[] <output>5__1
- public Steamworks.Data.LeaderboardScoresDownloaded_t r

#### Constructors
- public Leaderboard.<LeaderboardResultToEntries>d__17()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.Data.ServerInfo.<QueryRulesAsync>d__85
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.Data.ServerInfo <>4__this
- private System.Collections.Generic.Dictionary<string, string> <>s__1
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<string, string>> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.Dictionary<string, string>> <>u__1

#### Constructors
- public ServerInfo.<QueryRulesAsync>d__85()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.Data.Leaderboard.<ReplaceScore>d__11
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.Data.Leaderboard <>4__this
- private System.Nullable<Steamworks.Data.LeaderboardScoreUploaded_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.Data.LeaderboardUpdate>> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.LeaderboardScoreUploaded_t> <>u__1
- private System.Nullable<Steamworks.Data.LeaderboardScoreUploaded_t> <r>5__1
- public int[] details
- public int score

#### Constructors
- public Leaderboard.<ReplaceScore>d__11()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.Data.LobbyQuery.<RequestAsync>d__19
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.Data.LobbyQuery <>4__this
- private System.Nullable<Steamworks.Data.LobbyMatchList_t> <>s__3
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Steamworks.Data.Lobby[]> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.LobbyMatchList_t> <>u__1
- private int <i>5__4
- private System.Nullable<Steamworks.Data.LobbyMatchList_t> <list>5__1
- private Steamworks.Data.Lobby[] <lobbies>5__2

#### Constructors
- public LobbyQuery.<RequestAsync>d__19()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.Data.Leaderboard.<SubmitScoreAsync>d__12
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.Data.Leaderboard <>4__this
- private System.Nullable<Steamworks.Data.LeaderboardScoreUploaded_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.Data.LeaderboardUpdate>> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.LeaderboardScoreUploaded_t> <>u__1
- private System.Nullable<Steamworks.Data.LeaderboardScoreUploaded_t> <r>5__1
- public int[] details
- public int score

#### Constructors
- public Leaderboard.<SubmitScoreAsync>d__12()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### public struct Steamworks.Data.NetErrorMessage.<Value>e__FixedBuffer

#### Fields
- public char FixedElementField

### private class Steamworks.Data.Leaderboard.<WaitForUserNames>d__18
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private Steamworks.Data.LeaderboardEntry[] <>s__2
- private int <>s__3
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1
- private Steamworks.Data.LeaderboardEntry <entry>5__4
- private bool <gotAll>5__1
- public Steamworks.Data.LeaderboardEntry[] entries

#### Constructors
- public Leaderboard.<WaitForUserNames>d__18()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### internal struct Steamworks.Data.AccountID_t
- Interfaces: System.IEquatable<Steamworks.Data.AccountID_t>, System.IComparable<Steamworks.Data.AccountID_t>

#### Fields
- public uint Value

#### Methods
- public int CompareTo(Steamworks.Data.AccountID_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.AccountID_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.AccountID_t a, Steamworks.Data.AccountID_t b)
- public static Steamworks.Data.AccountID_t op_Implicit(uint value)
- public static uint op_Implicit(Steamworks.Data.AccountID_t value)
- public static bool op_Inequality(Steamworks.Data.AccountID_t a, Steamworks.Data.AccountID_t b)
- public override string ToString()

### public struct Steamworks.Data.Achievement

#### Fields
- internal string Value

#### Properties
- public string Description { get; }
- public float GlobalUnlocked { get; }
- public string Identifier { get; }
- public string Name { get; }
- public bool State { get; }
- public System.Nullable<System.DateTime> UnlockTime { get; }

#### Constructors
- public Achievement(string name)

#### Methods
- public bool Clear()
- public System.Nullable<Steamworks.Data.Image> GetIcon()
- public System.Threading.Tasks.Task<System.Nullable<Steamworks.Data.Image>> GetIconAsync(int timeout = 5000)
- public override string ToString()
- public bool Trigger(bool apply = true)

### internal struct Steamworks.Data.ActiveBeaconsUpdated_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static ActiveBeaconsUpdated_t()

### internal struct Steamworks.Data.AddAppDependencyResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.AppId AppID
- internal Steamworks.Data.PublishedFileId PublishedFileId
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static AddAppDependencyResult_t()

### internal struct Steamworks.Data.AddUGCDependencyResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Data.PublishedFileId ChildPublishedFileId
- internal Steamworks.Data.PublishedFileId PublishedFileId
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static AddUGCDependencyResult_t()

### internal struct Steamworks.Data.AppProofOfPurchaseKeyResponse_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal uint AppID
- internal uint CchKeyLength
- internal byte[] Key
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static AppProofOfPurchaseKeyResponse_t()

#### Methods
- internal string KeyUTF8()

### internal struct Steamworks.Data.AssetClassId_t
- Interfaces: System.IEquatable<Steamworks.Data.AssetClassId_t>, System.IComparable<Steamworks.Data.AssetClassId_t>

#### Fields
- public ulong Value

#### Methods
- public int CompareTo(Steamworks.Data.AssetClassId_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.AssetClassId_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.AssetClassId_t a, Steamworks.Data.AssetClassId_t b)
- public static Steamworks.Data.AssetClassId_t op_Implicit(ulong value)
- public static ulong op_Implicit(Steamworks.Data.AssetClassId_t value)
- public static bool op_Inequality(Steamworks.Data.AssetClassId_t a, Steamworks.Data.AssetClassId_t b)
- public override string ToString()

### internal struct Steamworks.Data.AssociateWithClanResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static AssociateWithClanResult_t()

### internal struct Steamworks.Data.AvailableBeaconLocationsUpdated_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static AvailableBeaconLocationsUpdated_t()

### internal struct Steamworks.Data.AvatarImageLoaded_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal int Image
- internal ulong SteamID
- internal int Tall
- internal int Wide
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static AvatarImageLoaded_t()

### internal struct Steamworks.Data.BREAKPAD_HANDLE
- Interfaces: System.IEquatable<Steamworks.Data.BREAKPAD_HANDLE>, System.IComparable<Steamworks.Data.BREAKPAD_HANDLE>

#### Fields
- public System.IntPtr Value

#### Methods
- public int CompareTo(Steamworks.Data.BREAKPAD_HANDLE other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.BREAKPAD_HANDLE p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.BREAKPAD_HANDLE a, Steamworks.Data.BREAKPAD_HANDLE b)
- public static Steamworks.Data.BREAKPAD_HANDLE op_Implicit(System.IntPtr value)
- public static System.IntPtr op_Implicit(Steamworks.Data.BREAKPAD_HANDLE value)
- public static bool op_Inequality(Steamworks.Data.BREAKPAD_HANDLE a, Steamworks.Data.BREAKPAD_HANDLE b)
- public override string ToString()

### internal struct Steamworks.Data.BroadcastUploadStart_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal bool IsRTMP
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static BroadcastUploadStart_t()

### internal struct Steamworks.Data.BroadcastUploadStop_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.BroadcastUploadResult Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static BroadcastUploadStop_t()

### internal struct Steamworks.Data.BundleId_t
- Interfaces: System.IEquatable<Steamworks.Data.BundleId_t>, System.IComparable<Steamworks.Data.BundleId_t>

#### Fields
- public uint Value

#### Methods
- public int CompareTo(Steamworks.Data.BundleId_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.BundleId_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.BundleId_t a, Steamworks.Data.BundleId_t b)
- public static Steamworks.Data.BundleId_t op_Implicit(uint value)
- public static uint op_Implicit(Steamworks.Data.BundleId_t value)
- public static bool op_Inequality(Steamworks.Data.BundleId_t a, Steamworks.Data.BundleId_t b)
- public override string ToString()

### internal struct Steamworks.Data.CellID_t
- Interfaces: System.IEquatable<Steamworks.Data.CellID_t>, System.IComparable<Steamworks.Data.CellID_t>

#### Fields
- public uint Value

#### Methods
- public int CompareTo(Steamworks.Data.CellID_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.CellID_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.CellID_t a, Steamworks.Data.CellID_t b)
- public static Steamworks.Data.CellID_t op_Implicit(uint value)
- public static uint op_Implicit(Steamworks.Data.CellID_t value)
- public static bool op_Inequality(Steamworks.Data.CellID_t a, Steamworks.Data.CellID_t b)
- public override string ToString()

### internal struct Steamworks.Data.ChangeNumOpenSlotsCallback_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static ChangeNumOpenSlotsCallback_t()

### internal struct Steamworks.Data.CheckFileSignature_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.CheckFileSignature CheckFileSignature
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static CheckFileSignature_t()

### internal struct Steamworks.Data.ClanOfficerListResponse_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal int COfficers
- internal ulong SteamIDClan
- internal byte Success
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static ClanOfficerListResponse_t()

### internal struct Steamworks.Data.ClientGameServerDeny_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal uint AppID
- internal uint GameServerIP
- internal ushort GameServerPort
- internal uint Reason
- internal ushort Secure
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static ClientGameServerDeny_t()

### public struct Steamworks.Data.Color

#### Fields
- public byte a
- public byte b
- public byte g
- public byte r

### internal struct Steamworks.Data.ComputeNewPlayerCompatibilityResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal int CClanPlayersThatDontLikeCandidate
- internal int CPlayersThatCandidateDoesntLike
- internal int CPlayersThatDontLikeCandidate
- internal Steamworks.Result Result
- internal ulong SteamIDCandidate
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static ComputeNewPlayerCompatibilityResult_t()

### public struct Steamworks.Data.Connection

#### Fields
- private uint <Id>k__BackingField

#### Properties
- public string ConnectionName { get; set; }
- public uint Id { get; set; }
- public long UserData { get; set; }

#### Methods
- public Steamworks.Result Accept()
- public bool Close(bool linger = false, int reasonCode = 0, string debugString = "Closing Connection")
- public string DetailedStatus()
- public Steamworks.Result Flush()
- public static Steamworks.Data.Connection op_Implicit(uint value)
- public static uint op_Implicit(Steamworks.Data.Connection value)
- public Steamworks.Result SendMessage(System.IntPtr ptr, int size, Steamworks.Data.SendType sendType = Reliable)
- public Steamworks.Result SendMessage(byte[] data, Steamworks.Data.SendType sendType = Reliable)
- public Steamworks.Result SendMessage(byte[] data, int offset, int length, Steamworks.Data.SendType sendType = Reliable)
- public Steamworks.Result SendMessage(string str, Steamworks.Data.SendType sendType = Reliable)
- public override string ToString()

### public struct Steamworks.Data.ConnectionInfo

#### Fields
- internal Steamworks.Data.NetAddress address
- internal string connectionDescription
- internal string endDebug
- internal int endReason
- internal Steamworks.Data.NetIdentity identity
- internal Steamworks.Data.Socket listenSocket
- internal ushort pad
- internal Steamworks.Data.SteamNetworkingPOPID popRelay
- internal Steamworks.Data.SteamNetworkingPOPID popRemote
- internal Steamworks.ConnectionState state
- internal long userData

#### Properties
- public Steamworks.Data.NetAddress Address { get; }
- public Steamworks.NetConnectionEnd EndReason { get; }
- public Steamworks.Data.NetIdentity Identity { get; }
- public Steamworks.ConnectionState State { get; }

### internal struct Steamworks.Data.ControllerActionSetHandle_t
- Interfaces: System.IEquatable<Steamworks.Data.ControllerActionSetHandle_t>, System.IComparable<Steamworks.Data.ControllerActionSetHandle_t>

#### Fields
- public ulong Value

#### Methods
- public int CompareTo(Steamworks.Data.ControllerActionSetHandle_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.ControllerActionSetHandle_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.ControllerActionSetHandle_t a, Steamworks.Data.ControllerActionSetHandle_t b)
- public static Steamworks.Data.ControllerActionSetHandle_t op_Implicit(ulong value)
- public static ulong op_Implicit(Steamworks.Data.ControllerActionSetHandle_t value)
- public static bool op_Inequality(Steamworks.Data.ControllerActionSetHandle_t a, Steamworks.Data.ControllerActionSetHandle_t b)
- public override string ToString()

### internal struct Steamworks.Data.ControllerAnalogActionHandle_t
- Interfaces: System.IEquatable<Steamworks.Data.ControllerAnalogActionHandle_t>, System.IComparable<Steamworks.Data.ControllerAnalogActionHandle_t>

#### Fields
- public ulong Value

#### Methods
- public int CompareTo(Steamworks.Data.ControllerAnalogActionHandle_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.ControllerAnalogActionHandle_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.ControllerAnalogActionHandle_t a, Steamworks.Data.ControllerAnalogActionHandle_t b)
- public static Steamworks.Data.ControllerAnalogActionHandle_t op_Implicit(ulong value)
- public static ulong op_Implicit(Steamworks.Data.ControllerAnalogActionHandle_t value)
- public static bool op_Inequality(Steamworks.Data.ControllerAnalogActionHandle_t a, Steamworks.Data.ControllerAnalogActionHandle_t b)
- public override string ToString()

### internal struct Steamworks.Data.ControllerDigitalActionHandle_t
- Interfaces: System.IEquatable<Steamworks.Data.ControllerDigitalActionHandle_t>, System.IComparable<Steamworks.Data.ControllerDigitalActionHandle_t>

#### Fields
- public ulong Value

#### Methods
- public int CompareTo(Steamworks.Data.ControllerDigitalActionHandle_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.ControllerDigitalActionHandle_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.ControllerDigitalActionHandle_t a, Steamworks.Data.ControllerDigitalActionHandle_t b)
- public static Steamworks.Data.ControllerDigitalActionHandle_t op_Implicit(ulong value)
- public static ulong op_Implicit(Steamworks.Data.ControllerDigitalActionHandle_t value)
- public static bool op_Inequality(Steamworks.Data.ControllerDigitalActionHandle_t a, Steamworks.Data.ControllerDigitalActionHandle_t b)
- public override string ToString()

### internal struct Steamworks.Data.ControllerHandle_t
- Interfaces: System.IEquatable<Steamworks.Data.ControllerHandle_t>, System.IComparable<Steamworks.Data.ControllerHandle_t>

#### Fields
- public ulong Value

#### Methods
- public int CompareTo(Steamworks.Data.ControllerHandle_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.ControllerHandle_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.ControllerHandle_t a, Steamworks.Data.ControllerHandle_t b)
- public static Steamworks.Data.ControllerHandle_t op_Implicit(ulong value)
- public static ulong op_Implicit(Steamworks.Data.ControllerHandle_t value)
- public static bool op_Inequality(Steamworks.Data.ControllerHandle_t a, Steamworks.Data.ControllerHandle_t b)
- public override string ToString()

### internal struct Steamworks.Data.CreateBeaconCallback_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal ulong BeaconID
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static CreateBeaconCallback_t()

### internal struct Steamworks.Data.CreateItemResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Data.PublishedFileId PublishedFileId
- internal Steamworks.Result Result
- internal bool UserNeedsToAcceptWorkshopLegalAgreement
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static CreateItemResult_t()

### internal static class Steamworks.Data.Defines

#### Fields
- internal static readonly int HSERVERQUERY_INVALID
- internal static readonly uint INVALID_HTMLBROWSER
- internal static readonly uint kNumUGCResultsPerPage
- internal static readonly int k_cbMaxGameServerGameData
- internal static readonly int k_cbMaxGameServerGameDescription
- internal static readonly int k_cbMaxGameServerGameDir
- internal static readonly int k_cbMaxGameServerMapName
- internal static readonly int k_cbMaxGameServerName
- internal static readonly int k_cbMaxGameServerTags
- internal static readonly uint k_cbMaxSteamDatagramGameCoordinatorServerLoginAppData
- internal static readonly uint k_cbMaxSteamDatagramGameCoordinatorServerLoginSerialized
- internal static readonly int k_cbMaxSteamNetworkingSocketsMessageSizeSend
- internal static readonly uint k_cbSteamDatagramMaxSerializedTicket
- internal static readonly uint k_cchDeveloperMetadataMax
- internal static readonly uint k_cchFilenameMax
- internal static readonly int k_cchGameExtraInfoMax
- internal static readonly int k_cchMaxFriendsGroupName
- internal static readonly int k_cchMaxSteamNetworkingErrMsg
- internal static readonly int k_cchMaxSteamNetworkingPingLocationString
- internal static readonly uint k_cchPublishedDocumentChangeDescriptionMax
- internal static readonly uint k_cchPublishedDocumentDescriptionMax
- internal static readonly uint k_cchPublishedDocumentTitleMax
- internal static readonly uint k_cchPublishedFileURLMax
- internal static readonly int k_cchSteamNetworkingMaxConnectionCloseReason
- internal static readonly int k_cchSteamNetworkingMaxConnectionDescription
- internal static readonly uint k_cchTagListMax
- internal static readonly int k_cEnumerateFollowersMax
- internal static readonly int k_cFriendsGroupLimit
- internal static readonly int k_cubAppProofOfPurchaseKeyMax
- internal static readonly uint k_cubChatMetadataMax
- internal static readonly int k_cubSaltSize
- internal static readonly int k_cubUFSTagTypeMax
- internal static readonly int k_cubUFSTagValueMax
- internal static readonly Steamworks.Data.FriendsGroupID_t k_FriendsGroupID_Invalid
- internal static readonly Steamworks.Data.GID_t k_GIDNil
- internal static readonly Steamworks.Data.HAuthTicket k_HAuthTicketInvalid
- internal static readonly Steamworks.Data.Socket k_HSteamListenSocket_Invalid
- internal static readonly Steamworks.Data.Connection k_HSteamNetConnection_Invalid
- internal static readonly Steamworks.Data.HSteamNetPollGroup k_HSteamNetPollGroup_Invalid
- internal static readonly Steamworks.Data.JobID_t k_JobIDNil
- internal static readonly uint k_nScreenshotMaxTaggedPublishedFiles
- internal static readonly uint k_nScreenshotMaxTaggedUsers
- internal static readonly int k_nSteamNetworkingPing_Failed
- internal static readonly int k_nSteamNetworkingPing_Unknown
- internal static readonly int k_nSteamNetworkingSend_NoDelay
- internal static readonly int k_nSteamNetworkingSend_NoNagle
- internal static readonly int k_nSteamNetworkingSend_Reliable
- internal static readonly int k_nSteamNetworkingSend_ReliableNoNagle
- internal static readonly int k_nSteamNetworkingSend_Unreliable
- internal static readonly int k_nSteamNetworkingSend_UnreliableNoDelay
- internal static readonly int k_nSteamNetworkingSend_UnreliableNoNagle
- internal static readonly int k_nSteamNetworkingSend_UseCurrentThread
- internal static readonly Steamworks.Data.PublishedFileId k_PublishedFileIdInvalid
- internal static readonly Steamworks.Data.PublishedFileUpdateHandle_t k_PublishedFileUpdateHandleInvalid
- internal static readonly int k_ScreenshotThumbWidth
- internal static readonly Steamworks.Data.SteamNetworkingPOPID k_SteamDatagramPOPID_dev
- internal static readonly Steamworks.Data.SteamInventoryResult_t k_SteamInventoryResultInvalid
- internal static readonly Steamworks.Data.SteamInventoryUpdateHandle_t k_SteamInventoryUpdateHandleInvalid
- internal static readonly Steamworks.Data.InventoryItemId k_SteamItemInstanceIDInvalid
- internal static readonly Steamworks.Data.GID_t k_TxnIDNil
- internal static readonly Steamworks.Data.GID_t k_TxnIDUnknown
- internal static readonly Steamworks.Data.SteamAPICall_t k_uAPICallInvalid
- internal static readonly Steamworks.AppId k_uAppIdInvalid
- internal static readonly Steamworks.Data.BundleId_t k_uBundleIdInvalid
- internal static readonly Steamworks.Data.CellID_t k_uCellIDInvalid
- internal static readonly Steamworks.Data.DepotId_t k_uDepotIdInvalid
- internal static readonly Steamworks.Data.UGCFileWriteStreamHandle_t k_UGCFileStreamHandleInvalid
- internal static readonly Steamworks.Data.UGCHandle_t k_UGCHandleInvalid
- internal static readonly Steamworks.Data.UGCQueryHandle_t k_UGCQueryHandleInvalid
- internal static readonly Steamworks.Data.UGCUpdateHandle_t k_UGCUpdateHandleInvalid
- internal static readonly Steamworks.Data.AssetClassId_t k_ulAssetClassIdInvalid
- internal static readonly Steamworks.Data.PartyBeaconID_t k_ulPartyBeaconIdInvalid
- internal static readonly Steamworks.Data.SiteId_t k_ulSiteIdInvalid
- internal static readonly Steamworks.Data.ManifestId_t k_uManifestIdInvalid
- internal static readonly uint k_unEnumeratePublishedFilesMaxResults
- internal static readonly uint k_unFavoriteFlagFavorite
- internal static readonly uint k_unFavoriteFlagHistory
- internal static readonly uint k_unFavoriteFlagNone
- internal static readonly uint k_unMaxCloudFileChunkSize
- internal static readonly uint k_unServerFlagActive
- internal static readonly uint k_unServerFlagDedicated
- internal static readonly uint k_unServerFlagLinux
- internal static readonly uint k_unServerFlagNone
- internal static readonly uint k_unServerFlagPassworded
- internal static readonly uint k_unServerFlagPrivate
- internal static readonly uint k_unServerFlagSecure
- internal static readonly uint k_unSteamAccountIDMask
- internal static readonly uint k_unSteamAccountInstanceMask
- internal static readonly uint k_unSteamUserDefaultInstance
- internal static readonly Steamworks.Data.PackageId_t k_uPackageIdInvalid
- internal static readonly Steamworks.Data.PartnerId_t k_uPartnerIdInvalid
- internal static readonly Steamworks.Data.PhysicalItemId_t k_uPhysicalItemIdInvalid

#### Constructors
- private static Defines()

### internal struct Steamworks.Data.DeleteItemResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Data.PublishedFileId PublishedFileId
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static DeleteItemResult_t()

### public struct Steamworks.Data.DepotId

#### Fields
- public uint Value

#### Methods
- public static Steamworks.Data.DepotId op_Implicit(uint value)
- public static Steamworks.Data.DepotId op_Implicit(int value)
- public static uint op_Implicit(Steamworks.Data.DepotId value)
- public override string ToString()

### internal struct Steamworks.Data.DepotId_t
- Interfaces: System.IEquatable<Steamworks.Data.DepotId_t>, System.IComparable<Steamworks.Data.DepotId_t>

#### Fields
- public uint Value

#### Methods
- public int CompareTo(Steamworks.Data.DepotId_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.DepotId_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.DepotId_t a, Steamworks.Data.DepotId_t b)
- public static Steamworks.Data.DepotId_t op_Implicit(uint value)
- public static uint op_Implicit(Steamworks.Data.DepotId_t value)
- public static bool op_Inequality(Steamworks.Data.DepotId_t a, Steamworks.Data.DepotId_t b)
- public override string ToString()

### public struct Steamworks.Data.DlcInformation

#### Fields
- private Steamworks.AppId <AppId>k__BackingField
- private bool <Available>k__BackingField
- private string <Name>k__BackingField

#### Properties
- public Steamworks.AppId AppId { get; internal set; }
- public bool Available { get; internal set; }
- public string Name { get; internal set; }

### internal struct Steamworks.Data.DlcInstalled_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.AppId AppID
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static DlcInstalled_t()

### internal struct Steamworks.Data.DownloadClanActivityCountsResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal bool Success
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static DownloadClanActivityCountsResult_t()

### internal struct Steamworks.Data.DownloadItemResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.AppId AppID
- internal Steamworks.Data.PublishedFileId PublishedFileId
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static DownloadItemResult_t()

### public struct Steamworks.Data.DownloadProgress

#### Fields
- public bool Active
- public ulong BytesDownloaded
- public ulong BytesTotal

### public struct Steamworks.Data.DurationControl

#### Fields
- internal Steamworks.Data.DurationControl_t _inner

#### Properties
- public Steamworks.AppId Appid { get; }
- public bool Applicable { get; }
- internal System.TimeSpan PlaytimeInLastFiveHours { get; }
- internal System.TimeSpan PlaytimeToday { get; }
- internal Steamworks.DurationControlProgress Progress { get; }

### internal struct Steamworks.Data.DurationControl_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.AppId Appid
- internal bool Applicable
- internal int CsecsLast5h
- internal int CsecsRemaining
- internal int CsecsToday
- internal Steamworks.DurationControlNotification Otification
- internal Steamworks.DurationControlProgress Progress
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static DurationControl_t()

### internal enum Steamworks.Data.IPCFailure_t.EFailureType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- FlushedCallbackQueue = 0
- PipeFail = 1

### internal struct Steamworks.Data.EncryptedAppTicketResponse_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static EncryptedAppTicketResponse_t()

### internal struct Steamworks.Data.EndGameResultCallback_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Result Result
- internal ulong UllUniqueGameID
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static EndGameResultCallback_t()

### internal struct Steamworks.Data.FavoritesListAccountsUpdated_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static FavoritesListAccountsUpdated_t()

### internal struct Steamworks.Data.FavoritesListChanged_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal uint AccountId
- internal bool Add
- internal uint AppID
- internal uint ConnPort
- internal uint Flags
- internal uint IP
- internal uint QueryPort
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static FavoritesListChanged_t()

### public struct Steamworks.Data.FileDetails

#### Fields
- public uint Flags
- public string Sha1
- public ulong SizeInBytes

### internal struct Steamworks.Data.FileDetailsResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal byte[] FileSHA
- internal ulong FileSize
- internal uint Flags
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static FileDetailsResult_t()

### internal struct Steamworks.Data.FriendGameInfo_t

#### Fields
- internal Steamworks.Data.GameId GameID
- internal uint GameIP
- internal ushort GamePort
- internal ushort QueryPort
- internal ulong SteamIDLobby

### internal struct Steamworks.Data.FriendRichPresenceUpdate_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.AppId AppID
- internal ulong SteamIDFriend
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static FriendRichPresenceUpdate_t()

### internal struct Steamworks.Data.FriendsEnumerateFollowingList_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal ulong[] GSteamID
- internal Steamworks.Result Result
- internal int ResultsReturned
- internal int TotalResultCount
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static FriendsEnumerateFollowingList_t()

### internal struct Steamworks.Data.FriendSessionStateInfo_t

#### Fields
- internal uint IOnlineSessionInstances
- internal byte IPublishedToFriendsSessionInstance

### internal struct Steamworks.Data.FriendsGetFollowerCount_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal int Count
- internal Steamworks.Result Result
- internal ulong SteamID
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static FriendsGetFollowerCount_t()

### internal struct Steamworks.Data.FriendsGroupID_t
- Interfaces: System.IEquatable<Steamworks.Data.FriendsGroupID_t>, System.IComparable<Steamworks.Data.FriendsGroupID_t>

#### Fields
- public short Value

#### Methods
- public int CompareTo(Steamworks.Data.FriendsGroupID_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.FriendsGroupID_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.FriendsGroupID_t a, Steamworks.Data.FriendsGroupID_t b)
- public static Steamworks.Data.FriendsGroupID_t op_Implicit(short value)
- public static short op_Implicit(Steamworks.Data.FriendsGroupID_t value)
- public static bool op_Inequality(Steamworks.Data.FriendsGroupID_t a, Steamworks.Data.FriendsGroupID_t b)
- public override string ToString()

### internal struct Steamworks.Data.FriendsIsFollowing_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal bool IsFollowing
- internal Steamworks.Result Result
- internal ulong SteamID
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static FriendsIsFollowing_t()

### internal struct Steamworks.Data.GameConnectedChatJoin_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal ulong SteamIDClanChat
- internal ulong SteamIDUser
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static GameConnectedChatJoin_t()

### internal struct Steamworks.Data.GameConnectedChatLeave_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal bool Dropped
- internal bool Kicked
- internal ulong SteamIDClanChat
- internal ulong SteamIDUser
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static GameConnectedChatLeave_t()

### internal struct Steamworks.Data.GameConnectedClanChatMsg_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal int MessageID
- internal ulong SteamIDClanChat
- internal ulong SteamIDUser
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static GameConnectedClanChatMsg_t()

### internal struct Steamworks.Data.GameConnectedFriendChatMsg_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal int MessageID
- internal ulong SteamIDUser
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static GameConnectedFriendChatMsg_t()

### public struct Steamworks.Data.GameId

#### Fields
- public ulong Value

#### Methods
- public static Steamworks.Data.GameId op_Implicit(ulong value)
- public static ulong op_Implicit(Steamworks.Data.GameId value)

### internal struct Steamworks.Data.GameLobbyJoinRequested_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal ulong SteamIDFriend
- internal ulong SteamIDLobby
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static GameLobbyJoinRequested_t()

### internal struct Steamworks.Data.GameOverlayActivated_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal byte Active
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static GameOverlayActivated_t()

### internal struct Steamworks.Data.GamepadTextInputDismissed_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal bool Submitted
- internal uint SubmittedText
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static GamepadTextInputDismissed_t()

### internal struct Steamworks.Data.GameRichPresenceJoinRequested_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal byte[] Connect
- internal ulong SteamIDFriend
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static GameRichPresenceJoinRequested_t()

#### Methods
- internal string ConnectUTF8()

### internal struct Steamworks.Data.GameServerChangeRequested_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal byte[] Password
- internal byte[] Server
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static GameServerChangeRequested_t()

#### Methods
- internal string PasswordUTF8()
- internal string ServerUTF8()

### internal struct Steamworks.Data.gameserveritem_t

#### Fields
- internal uint AppID
- internal int BotPlayers
- internal bool DoNotRefresh
- internal byte[] GameDescription
- internal byte[] GameDir
- internal byte[] GameTags
- internal bool HadSuccessfulResponse
- internal byte[] Map
- internal int MaxPlayers
- internal Steamworks.Data.servernetadr_t NetAdr
- internal bool Password
- internal int Ping
- internal int Players
- internal bool Secure
- internal byte[] ServerName
- internal int ServerVersion
- internal ulong SteamID
- internal uint TimeLastPlayed

#### Methods
- internal string GameDescriptionUTF8()
- internal string GameDirUTF8()
- internal string GameTagsUTF8()
- internal static void InternalConstruct(ref Steamworks.Data.gameserveritem_t self)
- internal static Steamworks.Utf8StringPointer InternalGetName(ref Steamworks.Data.gameserveritem_t self)
- internal static void InternalSetName(ref Steamworks.Data.gameserveritem_t self, string pName)
- internal string MapUTF8()
- internal string ServerNameUTF8()

### internal struct Steamworks.Data.GameWebCallback_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal byte[] URL
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static GameWebCallback_t()

#### Methods
- internal string URLUTF8()

### internal struct Steamworks.Data.GetAppDependenciesResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.AppId[] GAppIDs
- internal uint NumAppDependencies
- internal Steamworks.Data.PublishedFileId PublishedFileId
- internal Steamworks.Result Result
- internal uint TotalNumAppDependencies
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static GetAppDependenciesResult_t()

### internal struct Steamworks.Data.GetAuthSessionTicketResponse_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal uint AuthTicket
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static GetAuthSessionTicketResponse_t()

### internal struct Steamworks.Data.GetOPFSettingsResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Result Result
- internal Steamworks.AppId VideoAppID
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static GetOPFSettingsResult_t()

### internal struct Steamworks.Data.GetUserItemVoteResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Data.PublishedFileId PublishedFileId
- internal Steamworks.Result Result
- internal bool VotedDown
- internal bool VotedUp
- internal bool VoteSkipped
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static GetUserItemVoteResult_t()

### internal struct Steamworks.Data.GetVideoURLResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Result Result
- internal byte[] URL
- internal Steamworks.AppId VideoAppID
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static GetVideoURLResult_t()

#### Methods
- internal string URLUTF8()

### internal struct Steamworks.Data.GID_t
- Interfaces: System.IEquatable<Steamworks.Data.GID_t>, System.IComparable<Steamworks.Data.GID_t>

#### Fields
- public ulong Value

#### Methods
- public int CompareTo(Steamworks.Data.GID_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.GID_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.GID_t a, Steamworks.Data.GID_t b)
- public static Steamworks.Data.GID_t op_Implicit(ulong value)
- public static ulong op_Implicit(Steamworks.Data.GID_t value)
- public static bool op_Inequality(Steamworks.Data.GID_t a, Steamworks.Data.GID_t b)
- public override string ToString()

### internal struct Steamworks.Data.GlobalAchievementPercentagesReady_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal ulong GameID
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static GlobalAchievementPercentagesReady_t()

### internal struct Steamworks.Data.GlobalStatsReceived_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal ulong GameID
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static GlobalStatsReceived_t()

### internal struct Steamworks.Data.GSClientAchievementStatus_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal byte[] PchAchievement
- internal ulong SteamID
- internal bool Unlocked
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static GSClientAchievementStatus_t()

#### Methods
- internal string PchAchievementUTF8()

### internal struct Steamworks.Data.GSClientApprove_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal ulong OwnerSteamID
- internal ulong SteamID
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static GSClientApprove_t()

### internal struct Steamworks.Data.GSClientDeny_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.DenyReason DenyReason
- internal byte[] OptionalText
- internal ulong SteamID
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static GSClientDeny_t()

#### Methods
- internal string OptionalTextUTF8()

### internal struct Steamworks.Data.GSClientGroupStatus_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal bool Member
- internal bool Officer
- internal ulong SteamIDGroup
- internal ulong SteamIDUser
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static GSClientGroupStatus_t()

### internal struct Steamworks.Data.GSClientKick_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.DenyReason DenyReason
- internal ulong SteamID
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static GSClientKick_t()

### internal struct Steamworks.Data.GSGameplayStats_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal int Rank
- internal Steamworks.Result Result
- internal uint TotalConnects
- internal uint TotalMinutesPlayed
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static GSGameplayStats_t()

### internal struct Steamworks.Data.GSPolicyResponse_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal byte Secure
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static GSPolicyResponse_t()

### internal struct Steamworks.Data.GSReputation_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal uint BanExpires
- internal bool Banned
- internal ulong BannedGameID
- internal uint BannedIP
- internal ushort BannedPort
- internal uint ReputationScore
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static GSReputation_t()

### internal struct Steamworks.Data.GSStatsReceived_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Result Result
- internal ulong SteamIDUser
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static GSStatsReceived_t()

### internal struct Steamworks.Data.GSStatsStored_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Result Result
- internal ulong SteamIDUser
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static GSStatsStored_t()

### internal struct Steamworks.Data.GSStatsUnloaded_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal ulong SteamIDUser
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static GSStatsUnloaded_t()

### internal struct Steamworks.Data.HAuthTicket
- Interfaces: System.IEquatable<Steamworks.Data.HAuthTicket>, System.IComparable<Steamworks.Data.HAuthTicket>

#### Fields
- public uint Value

#### Methods
- public int CompareTo(Steamworks.Data.HAuthTicket other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.HAuthTicket p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.HAuthTicket a, Steamworks.Data.HAuthTicket b)
- public static Steamworks.Data.HAuthTicket op_Implicit(uint value)
- public static uint op_Implicit(Steamworks.Data.HAuthTicket value)
- public static bool op_Inequality(Steamworks.Data.HAuthTicket a, Steamworks.Data.HAuthTicket b)
- public override string ToString()

### internal struct Steamworks.Data.HHTMLBrowser
- Interfaces: System.IEquatable<Steamworks.Data.HHTMLBrowser>, System.IComparable<Steamworks.Data.HHTMLBrowser>

#### Fields
- public uint Value

#### Methods
- public int CompareTo(Steamworks.Data.HHTMLBrowser other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.HHTMLBrowser p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.HHTMLBrowser a, Steamworks.Data.HHTMLBrowser b)
- public static Steamworks.Data.HHTMLBrowser op_Implicit(uint value)
- public static uint op_Implicit(Steamworks.Data.HHTMLBrowser value)
- public static bool op_Inequality(Steamworks.Data.HHTMLBrowser a, Steamworks.Data.HHTMLBrowser b)
- public override string ToString()

### internal struct Steamworks.Data.HServerListRequest
- Interfaces: System.IEquatable<Steamworks.Data.HServerListRequest>, System.IComparable<Steamworks.Data.HServerListRequest>

#### Fields
- public System.IntPtr Value

#### Methods
- public int CompareTo(Steamworks.Data.HServerListRequest other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.HServerListRequest p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.HServerListRequest a, Steamworks.Data.HServerListRequest b)
- public static Steamworks.Data.HServerListRequest op_Implicit(System.IntPtr value)
- public static System.IntPtr op_Implicit(Steamworks.Data.HServerListRequest value)
- public static bool op_Inequality(Steamworks.Data.HServerListRequest a, Steamworks.Data.HServerListRequest b)
- public override string ToString()

### internal struct Steamworks.Data.HServerQuery
- Interfaces: System.IEquatable<Steamworks.Data.HServerQuery>, System.IComparable<Steamworks.Data.HServerQuery>

#### Fields
- public int Value

#### Methods
- public int CompareTo(Steamworks.Data.HServerQuery other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.HServerQuery p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.HServerQuery a, Steamworks.Data.HServerQuery b)
- public static Steamworks.Data.HServerQuery op_Implicit(int value)
- public static int op_Implicit(Steamworks.Data.HServerQuery value)
- public static bool op_Inequality(Steamworks.Data.HServerQuery a, Steamworks.Data.HServerQuery b)
- public override string ToString()

### internal struct Steamworks.Data.HSteamNetPollGroup
- Interfaces: System.IEquatable<Steamworks.Data.HSteamNetPollGroup>, System.IComparable<Steamworks.Data.HSteamNetPollGroup>

#### Fields
- public uint Value

#### Methods
- public int CompareTo(Steamworks.Data.HSteamNetPollGroup other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.HSteamNetPollGroup p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.HSteamNetPollGroup a, Steamworks.Data.HSteamNetPollGroup b)
- public static Steamworks.Data.HSteamNetPollGroup op_Implicit(uint value)
- public static uint op_Implicit(Steamworks.Data.HSteamNetPollGroup value)
- public static bool op_Inequality(Steamworks.Data.HSteamNetPollGroup a, Steamworks.Data.HSteamNetPollGroup b)
- public override string ToString()

### internal struct Steamworks.Data.HSteamPipe
- Interfaces: System.IEquatable<Steamworks.Data.HSteamPipe>, System.IComparable<Steamworks.Data.HSteamPipe>

#### Fields
- public int Value

#### Methods
- public int CompareTo(Steamworks.Data.HSteamPipe other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.HSteamPipe p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.HSteamPipe a, Steamworks.Data.HSteamPipe b)
- public static Steamworks.Data.HSteamPipe op_Implicit(int value)
- public static int op_Implicit(Steamworks.Data.HSteamPipe value)
- public static bool op_Inequality(Steamworks.Data.HSteamPipe a, Steamworks.Data.HSteamPipe b)
- public override string ToString()

### internal struct Steamworks.Data.HSteamUser
- Interfaces: System.IEquatable<Steamworks.Data.HSteamUser>, System.IComparable<Steamworks.Data.HSteamUser>

#### Fields
- public int Value

#### Methods
- public int CompareTo(Steamworks.Data.HSteamUser other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.HSteamUser p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.HSteamUser a, Steamworks.Data.HSteamUser b)
- public static Steamworks.Data.HSteamUser op_Implicit(int value)
- public static int op_Implicit(Steamworks.Data.HSteamUser value)
- public static bool op_Inequality(Steamworks.Data.HSteamUser a, Steamworks.Data.HSteamUser b)
- public override string ToString()

### internal struct Steamworks.Data.HTML_BrowserReady_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal uint UnBrowserHandle
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static HTML_BrowserReady_t()

### internal struct Steamworks.Data.HTML_BrowserRestarted_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal uint UnBrowserHandle
- internal uint UnOldBrowserHandle
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static HTML_BrowserRestarted_t()

### internal struct Steamworks.Data.HTML_CanGoBackAndForward_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal bool BCanGoBack
- internal bool BCanGoForward
- internal uint UnBrowserHandle
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static HTML_CanGoBackAndForward_t()

### internal struct Steamworks.Data.HTML_ChangedTitle_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal string PchTitle
- internal uint UnBrowserHandle
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static HTML_ChangedTitle_t()

### internal struct Steamworks.Data.HTML_CloseBrowser_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal uint UnBrowserHandle
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static HTML_CloseBrowser_t()

### internal struct Steamworks.Data.HTML_FileOpenDialog_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal string PchInitialFile
- internal string PchTitle
- internal uint UnBrowserHandle
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static HTML_FileOpenDialog_t()

### internal struct Steamworks.Data.HTML_FinishedRequest_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal string PchPageTitle
- internal string PchURL
- internal uint UnBrowserHandle
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static HTML_FinishedRequest_t()

### internal struct Steamworks.Data.HTML_HideToolTip_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal uint UnBrowserHandle
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static HTML_HideToolTip_t()

### internal struct Steamworks.Data.HTML_HorizontalScroll_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal bool BVisible
- internal float FlPageScale
- internal uint UnBrowserHandle
- internal uint UnPageSize
- internal uint UnScrollCurrent
- internal uint UnScrollMax
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static HTML_HorizontalScroll_t()

### internal struct Steamworks.Data.HTML_JSAlert_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal string PchMessage
- internal uint UnBrowserHandle
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static HTML_JSAlert_t()

### internal struct Steamworks.Data.HTML_JSConfirm_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal string PchMessage
- internal uint UnBrowserHandle
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static HTML_JSConfirm_t()

### internal struct Steamworks.Data.HTML_LinkAtPosition_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal bool BInput
- internal bool BLiveLink
- internal string PchURL
- internal uint UnBrowserHandle
- internal uint X
- internal uint Y
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static HTML_LinkAtPosition_t()

### internal struct Steamworks.Data.HTML_NeedsPaint_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal float FlPageScale
- internal string PBGRA
- internal uint UnBrowserHandle
- internal uint UnPageSerial
- internal uint UnScrollX
- internal uint UnScrollY
- internal uint UnTall
- internal uint UnUpdateTall
- internal uint UnUpdateWide
- internal uint UnUpdateX
- internal uint UnUpdateY
- internal uint UnWide
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static HTML_NeedsPaint_t()

### internal struct Steamworks.Data.HTML_NewWindow_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal string PchURL
- internal uint UnBrowserHandle
- internal uint UnNewWindow_BrowserHandle_IGNORE
- internal uint UnTall
- internal uint UnWide
- internal uint UnX
- internal uint UnY
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static HTML_NewWindow_t()

### internal struct Steamworks.Data.HTML_OpenLinkInNewTab_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal string PchURL
- internal uint UnBrowserHandle
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static HTML_OpenLinkInNewTab_t()

### internal struct Steamworks.Data.HTML_SearchResults_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal uint UnBrowserHandle
- internal uint UnCurrentMatch
- internal uint UnResults
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static HTML_SearchResults_t()

### internal struct Steamworks.Data.HTML_SetCursor_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal uint EMouseCursor
- internal uint UnBrowserHandle
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static HTML_SetCursor_t()

### internal struct Steamworks.Data.HTML_ShowToolTip_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal string PchMsg
- internal uint UnBrowserHandle
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static HTML_ShowToolTip_t()

### internal struct Steamworks.Data.HTML_StartRequest_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal bool BIsRedirect
- internal string PchPostData
- internal string PchTarget
- internal string PchURL
- internal uint UnBrowserHandle
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static HTML_StartRequest_t()

### internal struct Steamworks.Data.HTML_StatusText_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal string PchMsg
- internal uint UnBrowserHandle
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static HTML_StatusText_t()

### internal struct Steamworks.Data.HTML_UpdateToolTip_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal string PchMsg
- internal uint UnBrowserHandle
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static HTML_UpdateToolTip_t()

### internal struct Steamworks.Data.HTML_URLChanged_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal bool BIsRedirect
- internal bool BNewNavigation
- internal string PchPageTitle
- internal string PchPostData
- internal string PchURL
- internal uint UnBrowserHandle
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static HTML_URLChanged_t()

### internal struct Steamworks.Data.HTML_VerticalScroll_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal bool BVisible
- internal float FlPageScale
- internal uint UnBrowserHandle
- internal uint UnPageSize
- internal uint UnScrollCurrent
- internal uint UnScrollMax
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static HTML_VerticalScroll_t()

### internal struct Steamworks.Data.HTTPCookieContainerHandle
- Interfaces: System.IEquatable<Steamworks.Data.HTTPCookieContainerHandle>, System.IComparable<Steamworks.Data.HTTPCookieContainerHandle>

#### Fields
- public uint Value

#### Methods
- public int CompareTo(Steamworks.Data.HTTPCookieContainerHandle other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.HTTPCookieContainerHandle p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.HTTPCookieContainerHandle a, Steamworks.Data.HTTPCookieContainerHandle b)
- public static Steamworks.Data.HTTPCookieContainerHandle op_Implicit(uint value)
- public static uint op_Implicit(Steamworks.Data.HTTPCookieContainerHandle value)
- public static bool op_Inequality(Steamworks.Data.HTTPCookieContainerHandle a, Steamworks.Data.HTTPCookieContainerHandle b)
- public override string ToString()

### internal struct Steamworks.Data.HTTPRequestCompleted_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal uint BodySize
- internal ulong ContextValue
- internal uint Request
- internal bool RequestSuccessful
- internal Steamworks.HTTPStatusCode StatusCode
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static HTTPRequestCompleted_t()

### internal struct Steamworks.Data.HTTPRequestDataReceived_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal uint CBytesReceived
- internal uint COffset
- internal ulong ContextValue
- internal uint Request
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static HTTPRequestDataReceived_t()

### internal struct Steamworks.Data.HTTPRequestHandle
- Interfaces: System.IEquatable<Steamworks.Data.HTTPRequestHandle>, System.IComparable<Steamworks.Data.HTTPRequestHandle>

#### Fields
- public uint Value

#### Methods
- public int CompareTo(Steamworks.Data.HTTPRequestHandle other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.HTTPRequestHandle p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.HTTPRequestHandle a, Steamworks.Data.HTTPRequestHandle b)
- public static Steamworks.Data.HTTPRequestHandle op_Implicit(uint value)
- public static uint op_Implicit(Steamworks.Data.HTTPRequestHandle value)
- public static bool op_Inequality(Steamworks.Data.HTTPRequestHandle a, Steamworks.Data.HTTPRequestHandle b)
- public override string ToString()

### internal struct Steamworks.Data.HTTPRequestHeadersReceived_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal ulong ContextValue
- internal uint Request
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static HTTPRequestHeadersReceived_t()

### internal enum Steamworks.Data.NetIdentity.IdentityType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- GenericBytes = 3
- GenericString = 2
- Invalid = 0
- IPAddress = 1
- SteamID = 16

### public struct Steamworks.Data.Image

#### Fields
- public byte[] Data
- public uint Height
- public uint Width

#### Methods
- public Steamworks.Data.Color GetPixel(int x, int y)
- public override string ToString()

### internal struct Steamworks.Data.InputActionSetHandle_t
- Interfaces: System.IEquatable<Steamworks.Data.InputActionSetHandle_t>, System.IComparable<Steamworks.Data.InputActionSetHandle_t>

#### Fields
- public ulong Value

#### Methods
- public int CompareTo(Steamworks.Data.InputActionSetHandle_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.InputActionSetHandle_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.InputActionSetHandle_t a, Steamworks.Data.InputActionSetHandle_t b)
- public static Steamworks.Data.InputActionSetHandle_t op_Implicit(ulong value)
- public static ulong op_Implicit(Steamworks.Data.InputActionSetHandle_t value)
- public static bool op_Inequality(Steamworks.Data.InputActionSetHandle_t a, Steamworks.Data.InputActionSetHandle_t b)
- public override string ToString()

### internal struct Steamworks.Data.InputAnalogActionHandle_t
- Interfaces: System.IEquatable<Steamworks.Data.InputAnalogActionHandle_t>, System.IComparable<Steamworks.Data.InputAnalogActionHandle_t>

#### Fields
- public ulong Value

#### Methods
- public int CompareTo(Steamworks.Data.InputAnalogActionHandle_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.InputAnalogActionHandle_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.InputAnalogActionHandle_t a, Steamworks.Data.InputAnalogActionHandle_t b)
- public static Steamworks.Data.InputAnalogActionHandle_t op_Implicit(ulong value)
- public static ulong op_Implicit(Steamworks.Data.InputAnalogActionHandle_t value)
- public static bool op_Inequality(Steamworks.Data.InputAnalogActionHandle_t a, Steamworks.Data.InputAnalogActionHandle_t b)
- public override string ToString()

### internal struct Steamworks.Data.InputDigitalActionHandle_t
- Interfaces: System.IEquatable<Steamworks.Data.InputDigitalActionHandle_t>, System.IComparable<Steamworks.Data.InputDigitalActionHandle_t>

#### Fields
- public ulong Value

#### Methods
- public int CompareTo(Steamworks.Data.InputDigitalActionHandle_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.InputDigitalActionHandle_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.InputDigitalActionHandle_t a, Steamworks.Data.InputDigitalActionHandle_t b)
- public static Steamworks.Data.InputDigitalActionHandle_t op_Implicit(ulong value)
- public static ulong op_Implicit(Steamworks.Data.InputDigitalActionHandle_t value)
- public static bool op_Inequality(Steamworks.Data.InputDigitalActionHandle_t a, Steamworks.Data.InputDigitalActionHandle_t b)
- public override string ToString()

### internal struct Steamworks.Data.InputHandle_t
- Interfaces: System.IEquatable<Steamworks.Data.InputHandle_t>, System.IComparable<Steamworks.Data.InputHandle_t>

#### Fields
- public ulong Value

#### Methods
- public int CompareTo(Steamworks.Data.InputHandle_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.InputHandle_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.InputHandle_t a, Steamworks.Data.InputHandle_t b)
- public static Steamworks.Data.InputHandle_t op_Implicit(ulong value)
- public static ulong op_Implicit(Steamworks.Data.InputHandle_t value)
- public static bool op_Inequality(Steamworks.Data.InputHandle_t a, Steamworks.Data.InputHandle_t b)
- public override string ToString()

### public struct Steamworks.Data.InventoryDefId
- Interfaces: System.IEquatable<Steamworks.Data.InventoryDefId>, System.IComparable<Steamworks.Data.InventoryDefId>

#### Fields
- public int Value

#### Methods
- public int CompareTo(Steamworks.Data.InventoryDefId other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.InventoryDefId p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.InventoryDefId a, Steamworks.Data.InventoryDefId b)
- public static Steamworks.Data.InventoryDefId op_Implicit(int value)
- public static int op_Implicit(Steamworks.Data.InventoryDefId value)
- public static bool op_Inequality(Steamworks.Data.InventoryDefId a, Steamworks.Data.InventoryDefId b)
- public override string ToString()

### public struct Steamworks.Data.InventoryItemId
- Interfaces: System.IEquatable<Steamworks.Data.InventoryItemId>, System.IComparable<Steamworks.Data.InventoryItemId>

#### Fields
- public ulong Value

#### Methods
- public int CompareTo(Steamworks.Data.InventoryItemId other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.InventoryItemId p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.InventoryItemId a, Steamworks.Data.InventoryItemId b)
- public static Steamworks.Data.InventoryItemId op_Implicit(ulong value)
- public static ulong op_Implicit(Steamworks.Data.InventoryItemId value)
- public static bool op_Inequality(Steamworks.Data.InventoryItemId a, Steamworks.Data.InventoryItemId b)
- public override string ToString()

### public struct Steamworks.Data.InventoryPurchaseResult

#### Fields
- public ulong OrderID
- public Steamworks.Result Result
- public ulong TransID

### internal struct Steamworks.Data.IPCFailure_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal byte FailureType
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static IPCFailure_t()

### internal struct Steamworks.Data.IPCountry_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static IPCountry_t()

### internal struct Steamworks.Data.NetAddress.IPV4

#### Fields
- internal byte ip0
- internal byte ip1
- internal byte ip2
- internal byte ip3
- internal ushort m_0000
- internal ulong m_8zeros
- internal ushort m_ffff

### internal struct Steamworks.Data.ItemInstalled_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.AppId AppID
- internal Steamworks.Data.PublishedFileId PublishedFileId
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static ItemInstalled_t()

### internal struct Steamworks.Data.JobID_t
- Interfaces: System.IEquatable<Steamworks.Data.JobID_t>, System.IComparable<Steamworks.Data.JobID_t>

#### Fields
- public ulong Value

#### Methods
- public int CompareTo(Steamworks.Data.JobID_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.JobID_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.JobID_t a, Steamworks.Data.JobID_t b)
- public static Steamworks.Data.JobID_t op_Implicit(ulong value)
- public static ulong op_Implicit(Steamworks.Data.JobID_t value)
- public static bool op_Inequality(Steamworks.Data.JobID_t a, Steamworks.Data.JobID_t b)
- public override string ToString()

### internal struct Steamworks.Data.JoinClanChatRoomCompletionResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.RoomEnter ChatRoomEnterResponse
- internal ulong SteamIDClanChat
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static JoinClanChatRoomCompletionResult_t()

### internal struct Steamworks.Data.JoinPartyCallback_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal ulong BeaconID
- internal byte[] ConnectString
- internal Steamworks.Result Result
- internal ulong SteamIDBeaconOwner
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static JoinPartyCallback_t()

#### Methods
- internal string ConnectStringUTF8()

### public struct Steamworks.Data.Leaderboard

#### Fields
- private static int[] detailsBuffer
- internal Steamworks.Data.SteamLeaderboard_t Id
- private static int[] noDetails

#### Properties
- public Steamworks.Data.LeaderboardDisplay Display { get; }
- public int EntryCount { get; }
- public string Name { get; }
- public Steamworks.Data.LeaderboardSort Sort { get; }

#### Constructors
- private static Leaderboard()

#### Methods
- public System.Threading.Tasks.Task<Steamworks.Result> AttachUgc(Steamworks.Data.Ugc file)
- public System.Threading.Tasks.Task<Steamworks.Data.LeaderboardEntry[]> GetScoresAroundUserAsync(int start = -10, int end = 10)
- public System.Threading.Tasks.Task<Steamworks.Data.LeaderboardEntry[]> GetScoresAsync(int count, int offset = 1)
- public System.Threading.Tasks.Task<Steamworks.Data.LeaderboardEntry[]> GetScoresFromFriendsAsync()
- internal System.Threading.Tasks.Task<Steamworks.Data.LeaderboardEntry[]> LeaderboardResultToEntries(Steamworks.Data.LeaderboardScoresDownloaded_t r)
- public System.Threading.Tasks.Task<System.Nullable<Steamworks.Data.LeaderboardUpdate>> ReplaceScore(int score, int[] details = null)
- public System.Threading.Tasks.Task<System.Nullable<Steamworks.Data.LeaderboardUpdate>> SubmitScoreAsync(int score, int[] details = null)
- internal static System.Threading.Tasks.Task WaitForUserNames(Steamworks.Data.LeaderboardEntry[] entries)

### public enum Steamworks.Data.LeaderboardDisplay
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Numeric = 1
- TimeMilliSeconds = 3
- TimeSeconds = 2

### public struct Steamworks.Data.LeaderboardEntry

#### Fields
- public int[] Details
- public int GlobalRank
- public int Score
- public Steamworks.Friend User

#### Methods
- internal static Steamworks.Data.LeaderboardEntry From(Steamworks.Data.LeaderboardEntry_t e, int[] detailsBuffer)

### internal struct Steamworks.Data.LeaderboardEntry_t

#### Fields
- internal int CDetails
- internal int GlobalRank
- internal int Score
- internal ulong SteamIDUser
- internal ulong UGC

### internal struct Steamworks.Data.LeaderboardFindResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal byte LeaderboardFound
- internal ulong SteamLeaderboard
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static LeaderboardFindResult_t()

### internal struct Steamworks.Data.LeaderboardScoresDownloaded_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal int CEntryCount
- internal ulong SteamLeaderboard
- internal ulong SteamLeaderboardEntries
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static LeaderboardScoresDownloaded_t()

### internal struct Steamworks.Data.LeaderboardScoreUploaded_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal int GlobalRankNew
- internal int GlobalRankPrevious
- internal int Score
- internal byte ScoreChanged
- internal ulong SteamLeaderboard
- internal byte Success
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static LeaderboardScoreUploaded_t()

### public enum Steamworks.Data.LeaderboardSort
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Ascending = 1
- Descending = 2

### internal struct Steamworks.Data.LeaderboardUGCSet_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Result Result
- internal ulong SteamLeaderboard
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static LeaderboardUGCSet_t()

### public struct Steamworks.Data.LeaderboardUpdate

#### Fields
- public bool Changed
- public int NewGlobalRank
- public int OldGlobalRank
- public int Score

#### Properties
- public int RankChange { get; }

#### Methods
- internal static Steamworks.Data.LeaderboardUpdate From(Steamworks.Data.LeaderboardScoreUploaded_t e)

### internal struct Steamworks.Data.LicensesUpdated_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static LicensesUpdated_t()

### public struct Steamworks.Data.Lobby

#### Fields
- private Steamworks.SteamId <Id>k__BackingField

#### Properties
- public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> Data { get; }
- public Steamworks.SteamId Id { get; internal set; }
- public int MaxMembers { get; set; }
- public int MemberCount { get; }
- public System.Collections.Generic.IEnumerable<Steamworks.Friend> Members { get; }
- public Steamworks.Friend Owner { get; set; }

#### Constructors
- public Lobby(Steamworks.SteamId id)

#### Methods
- public bool DeleteData(string key)
- public string GetData(string key)
- public bool GetGameServer(ref uint ip, ref ushort port, ref Steamworks.SteamId serverId)
- public string GetMemberData(Steamworks.Friend member, string key)
- public bool InviteFriend(Steamworks.SteamId steamid)
- public bool IsOwnedBy(Steamworks.SteamId k)
- public System.Threading.Tasks.Task<Steamworks.RoomEnter> Join()
- public void Leave()
- public bool Refresh()
- internal bool SendChatBytes(byte[] data)
- public bool SendChatString(string message)
- public bool SetData(string key, string value)
- public bool SetFriendsOnly()
- public void SetGameServer(Steamworks.SteamId steamServer)
- public void SetGameServer(string ip, ushort port)
- public bool SetInvisible()
- public bool SetJoinable(bool b)
- public void SetMemberData(string key, string value)
- public bool SetPrivate()
- public bool SetPublic()

### internal struct Steamworks.Data.LobbyChatMsg_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal byte ChatEntryType
- internal uint ChatID
- internal ulong SteamIDLobby
- internal ulong SteamIDUser
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static LobbyChatMsg_t()

### internal struct Steamworks.Data.LobbyChatUpdate_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal uint GfChatMemberStateChange
- internal ulong SteamIDLobby
- internal ulong SteamIDMakingChange
- internal ulong SteamIDUserChanged
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static LobbyChatUpdate_t()

### internal struct Steamworks.Data.LobbyCreated_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Result Result
- internal ulong SteamIDLobby
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static LobbyCreated_t()

### internal struct Steamworks.Data.LobbyDataUpdate_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal ulong SteamIDLobby
- internal ulong SteamIDMember
- internal byte Success
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static LobbyDataUpdate_t()

### internal struct Steamworks.Data.LobbyEnter_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal uint EChatRoomEnterResponse
- internal uint GfChatPermissions
- internal bool Locked
- internal ulong SteamIDLobby
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static LobbyEnter_t()

### internal struct Steamworks.Data.LobbyGameCreated_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal uint IP
- internal ushort Port
- internal ulong SteamIDGameServer
- internal ulong SteamIDLobby
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static LobbyGameCreated_t()

### internal struct Steamworks.Data.LobbyInvite_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal ulong GameID
- internal ulong SteamIDLobby
- internal ulong SteamIDUser
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static LobbyInvite_t()

### internal struct Steamworks.Data.LobbyKicked_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal byte KickedDueToDisconnect
- internal ulong SteamIDAdmin
- internal ulong SteamIDLobby
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static LobbyKicked_t()

### internal struct Steamworks.Data.LobbyMatchList_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal uint LobbiesMatching
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static LobbyMatchList_t()

### public struct Steamworks.Data.LobbyQuery

#### Fields
- internal System.Nullable<Steamworks.LobbyDistanceFilter> distance
- internal System.Nullable<int> maxResults
- internal System.Collections.Generic.Dictionary<string, int> nearValFilters
- internal System.Collections.Generic.List<Steamworks.Data.NumericalFilter> numericalFilters
- internal System.Nullable<int> slotsAvailable
- internal System.Collections.Generic.Dictionary<string, string> stringFilters

#### Methods
- internal void AddNumericalFilter(string key, int value, Steamworks.LobbyComparison compare)
- private void ApplyFilters()
- public Steamworks.Data.LobbyQuery FilterDistanceClose()
- public Steamworks.Data.LobbyQuery FilterDistanceFar()
- public Steamworks.Data.LobbyQuery FilterDistanceWorldwide()
- public Steamworks.Data.LobbyQuery OrderByNear(string key, int value)
- public System.Threading.Tasks.Task<Steamworks.Data.Lobby[]> RequestAsync()
- public Steamworks.Data.LobbyQuery WithEqual(string key, int value)
- public Steamworks.Data.LobbyQuery WithHigher(string key, int value)
- public Steamworks.Data.LobbyQuery WithKeyValue(string key, string value)
- public Steamworks.Data.LobbyQuery WithLower(string key, int value)
- public Steamworks.Data.LobbyQuery WithMaxResults(int max)
- public Steamworks.Data.LobbyQuery WithNotEqual(string key, int value)
- public Steamworks.Data.LobbyQuery WithSlotsAvailable(int minSlots)

### internal struct Steamworks.Data.LowBatteryPower_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal byte MinutesBatteryLeft
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static LowBatteryPower_t()

### internal struct Steamworks.Data.ManifestId_t
- Interfaces: System.IEquatable<Steamworks.Data.ManifestId_t>, System.IComparable<Steamworks.Data.ManifestId_t>

#### Fields
- public ulong Value

#### Methods
- public int CompareTo(Steamworks.Data.ManifestId_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.ManifestId_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.ManifestId_t a, Steamworks.Data.ManifestId_t b)
- public static Steamworks.Data.ManifestId_t op_Implicit(ulong value)
- public static ulong op_Implicit(Steamworks.Data.ManifestId_t value)
- public static bool op_Inequality(Steamworks.Data.ManifestId_t a, Steamworks.Data.ManifestId_t b)
- public override string ToString()

### internal struct Steamworks.Data.MarketEligibilityResponse_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal bool Allowed
- internal int CdayNewDeviceCooldown
- internal int CdaySteamGuardRequiredDays
- internal Steamworks.MarketNotAllowedReasonFlags NotAllowedReason
- internal uint TAllowedAtTime
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static MarketEligibilityResponse_t()

### internal struct Steamworks.Data.MatchMakingKeyValuePair

#### Fields
- internal string Key
- internal string Value

#### Methods
- internal static void InternalConstruct(ref Steamworks.Data.MatchMakingKeyValuePair self)

### internal struct Steamworks.Data.MicroTxnAuthorizationResponse_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal uint AppID
- internal byte Authorized
- internal ulong OrderID
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static MicroTxnAuthorizationResponse_t()

### internal struct Steamworks.Data.MusicPlayerRemoteToFront_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static MusicPlayerRemoteToFront_t()

### internal struct Steamworks.Data.MusicPlayerRemoteWillActivate_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static MusicPlayerRemoteWillActivate_t()

### internal struct Steamworks.Data.MusicPlayerRemoteWillDeactivate_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static MusicPlayerRemoteWillDeactivate_t()

### internal struct Steamworks.Data.MusicPlayerSelectsPlaylistEntry_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal int NID
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static MusicPlayerSelectsPlaylistEntry_t()

### internal struct Steamworks.Data.MusicPlayerSelectsQueueEntry_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal int NID
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static MusicPlayerSelectsQueueEntry_t()

### internal struct Steamworks.Data.MusicPlayerWantsLooped_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal bool Looped
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static MusicPlayerWantsLooped_t()

### internal struct Steamworks.Data.MusicPlayerWantsPause_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static MusicPlayerWantsPause_t()

### internal struct Steamworks.Data.MusicPlayerWantsPlayingRepeatStatus_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal int PlayingRepeatStatus
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static MusicPlayerWantsPlayingRepeatStatus_t()

### internal struct Steamworks.Data.MusicPlayerWantsPlayNext_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static MusicPlayerWantsPlayNext_t()

### internal struct Steamworks.Data.MusicPlayerWantsPlayPrevious_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static MusicPlayerWantsPlayPrevious_t()

### internal struct Steamworks.Data.MusicPlayerWantsPlay_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static MusicPlayerWantsPlay_t()

### internal struct Steamworks.Data.MusicPlayerWantsShuffled_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal bool Shuffled
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static MusicPlayerWantsShuffled_t()

### internal struct Steamworks.Data.MusicPlayerWantsVolume_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal float NewVolume
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static MusicPlayerWantsVolume_t()

### internal struct Steamworks.Data.MusicPlayerWillQuit_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static MusicPlayerWillQuit_t()

### public struct Steamworks.Data.NetAddress

#### Fields
- internal Steamworks.Data.NetAddress.IPV4 ip
- internal ushort port

#### Properties
- public System.Net.IPAddress Address { get; }
- public static Steamworks.Data.NetAddress Cleared { get; }
- public bool IsIPv4 { get; }
- public bool IsIPv6AllZeros { get; }
- public bool IsLocalHost { get; }
- public ushort Port { get; }

#### Methods
- public static Steamworks.Data.NetAddress AnyIp(ushort port)
- public static Steamworks.Data.NetAddress From(string addrStr, ushort port)
- public static Steamworks.Data.NetAddress From(System.Net.IPAddress address, ushort port)
- internal static void InternalClear(ref Steamworks.Data.NetAddress self)
- internal static uint InternalGetIPv4(ref Steamworks.Data.NetAddress self)
- internal static bool InternalIsEqualTo(ref Steamworks.Data.NetAddress self, ref Steamworks.Data.NetAddress x)
- internal static bool InternalIsIPv4(ref Steamworks.Data.NetAddress self)
- internal static bool InternalIsIPv6AllZeros(ref Steamworks.Data.NetAddress self)
- internal static bool InternalIsLocalHost(ref Steamworks.Data.NetAddress self)
- internal static bool InternalParseString(ref Steamworks.Data.NetAddress self, string pszStr)
- internal static void InternalSetIPv4(ref Steamworks.Data.NetAddress self, uint nIP, ushort nPort)
- internal static void InternalSetIPv6(ref Steamworks.Data.NetAddress self, ref byte ipv6, ushort nPort)
- internal static void InternalSetIPv6LocalHost(ref Steamworks.Data.NetAddress self, ushort nPort)
- internal static void InternalToString(ref Steamworks.Data.NetAddress self, System.IntPtr buf, uint cbBuf, bool bWithPort)
- public static Steamworks.Data.NetAddress LocalHost(ushort port)
- public override string ToString()

### internal delegate Steamworks.Data.NetDebugFunc
- Base: System.MulticastDelegate
- Interfaces: System.ICloneable, System.Runtime.Serialization.ISerializable

#### Constructors
- public NetDebugFunc(object object, System.IntPtr method)

#### Methods
- public virtual System.IAsyncResult BeginInvoke(Steamworks.NetDebugOutput nType, System.IntPtr pszMsg, System.AsyncCallback callback, object object)
- public virtual void EndInvoke(System.IAsyncResult result)
- public virtual void Invoke(Steamworks.NetDebugOutput nType, System.IntPtr pszMsg)

### internal struct Steamworks.Data.NetErrorMessage

#### Fields
- public Steamworks.Data.NetErrorMessage.<Value>e__FixedBuffer Value

### public struct Steamworks.Data.NetIdentity

#### Fields
- internal Steamworks.Data.NetAddress netaddress
- internal int size
- internal ulong steamid
- internal Steamworks.Data.NetIdentity.IdentityType type

#### Properties
- public Steamworks.Data.NetAddress Address { get; }
- public bool IsIpAddress { get; }
- public bool IsLocalHost { get; }
- public bool IsSteamId { get; }
- public static Steamworks.Data.NetIdentity LocalHost { get; }
- public Steamworks.SteamId SteamId { get; }

#### Methods
- internal static void InternalClear(ref Steamworks.Data.NetIdentity self)
- internal static byte InternalGetGenericBytes(ref Steamworks.Data.NetIdentity self, ref int cbLen)
- internal static Steamworks.Utf8StringPointer InternalGetGenericString(ref Steamworks.Data.NetIdentity self)
- internal static System.IntPtr InternalGetIPAddr(ref Steamworks.Data.NetIdentity self)
- internal static Steamworks.SteamId InternalGetSteamID(ref Steamworks.Data.NetIdentity self)
- internal static ulong InternalGetSteamID64(ref Steamworks.Data.NetIdentity self)
- internal static Steamworks.Utf8StringPointer InternalGetXboxPairwiseID(ref Steamworks.Data.NetIdentity self)
- internal static bool InternalIsEqualTo(ref Steamworks.Data.NetIdentity self, ref Steamworks.Data.NetIdentity x)
- internal static bool InternalIsInvalid(ref Steamworks.Data.NetIdentity self)
- internal static bool InternalIsLocalHost(ref Steamworks.Data.NetIdentity self)
- internal static bool InternalParseString(ref Steamworks.Data.NetIdentity self, string pszStr)
- internal static bool InternalSetGenericBytes(ref Steamworks.Data.NetIdentity self, System.IntPtr data, uint cbLen)
- internal static bool InternalSetGenericString(ref Steamworks.Data.NetIdentity self, string pszString)
- internal static void InternalSetIPAddr(ref Steamworks.Data.NetIdentity self, ref Steamworks.Data.NetAddress addr)
- internal static void InternalSetLocalHost(ref Steamworks.Data.NetIdentity self)
- internal static void InternalSetSteamID(ref Steamworks.Data.NetIdentity self, Steamworks.SteamId steamID)
- internal static void InternalSetSteamID64(ref Steamworks.Data.NetIdentity self, ulong steamID)
- internal static bool InternalSetXboxPairwiseID(ref Steamworks.Data.NetIdentity self, string pszString)
- internal static void InternalToString(ref Steamworks.Data.NetIdentity self, System.IntPtr buf, uint cbBuf)
- public static Steamworks.Data.NetIdentity op_Implicit(Steamworks.SteamId value)
- public static Steamworks.Data.NetIdentity op_Implicit(Steamworks.Data.NetAddress address)
- public static Steamworks.SteamId op_Implicit(Steamworks.Data.NetIdentity value)
- public override string ToString()

### internal struct Steamworks.Data.NetKeyValue

#### Fields
- internal Steamworks.NetConfigType DataType
- internal float FloatValue
- internal int Int32Value
- internal long Int64Value
- internal System.IntPtr PointerValue
- internal Steamworks.NetConfig Value

### internal struct Steamworks.Data.NetMsg

#### Fields
- internal int Channel
- internal Steamworks.Data.Connection Connection
- internal long ConnectionUserData
- internal System.IntPtr DataPtr
- internal int DataSize
- internal System.IntPtr FreeDataPtr
- internal Steamworks.Data.NetIdentity Identity
- internal long MessageNumber
- internal long RecvTime
- internal System.IntPtr ReleasePtr

#### Methods
- internal static void InternalRelease(Steamworks.Data.NetMsg* self)

### public struct Steamworks.Data.NetPingLocation

#### Methods
- public int EstimatePingTo(Steamworks.Data.NetPingLocation target)
- public override string ToString()
- public static System.Nullable<Steamworks.Data.NetPingLocation> TryParseFromString(string str)

### internal struct Steamworks.Data.NewUrlLaunchParameters_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static NewUrlLaunchParameters_t()

### internal struct Steamworks.Data.NumberOfCurrentPlayers_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal int CPlayers
- internal byte Success
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static NumberOfCurrentPlayers_t()

### internal struct Steamworks.Data.NumericalFilter

#### Fields
- private Steamworks.LobbyComparison <Comparer>k__BackingField
- private string <Key>k__BackingField
- private int <Value>k__BackingField

#### Properties
- public Steamworks.LobbyComparison Comparer { get; internal set; }
- public string Key { get; internal set; }
- public int Value { get; internal set; }

#### Constructors
- internal NumericalFilter(string k, int v, Steamworks.LobbyComparison c)

### public struct Steamworks.Data.OutgoingPacket

#### Fields
- private uint <Address>k__BackingField
- private byte[] <Data>k__BackingField
- private ushort <Port>k__BackingField
- private int <Size>k__BackingField

#### Properties
- public uint Address { get; internal set; }
- public byte[] Data { get; internal set; }
- public ushort Port { get; internal set; }
- public int Size { get; internal set; }

### public struct Steamworks.Data.P2Packet

#### Fields
- public byte[] Data
- public Steamworks.SteamId SteamId

### internal struct Steamworks.Data.P2PSessionConnectFail_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal byte P2PSessionError
- internal ulong SteamIDRemote
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static P2PSessionConnectFail_t()

### internal struct Steamworks.Data.P2PSessionRequest_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal ulong SteamIDRemote
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static P2PSessionRequest_t()

### internal struct Steamworks.Data.P2PSessionState_t

#### Fields
- internal int BytesQueuedForSend
- internal byte Connecting
- internal byte ConnectionActive
- internal byte P2PSessionError
- internal int PacketsQueuedForSend
- internal uint RemoteIP
- internal ushort RemotePort
- internal byte UsingRelay

### internal struct Steamworks.Data.PackageId_t
- Interfaces: System.IEquatable<Steamworks.Data.PackageId_t>, System.IComparable<Steamworks.Data.PackageId_t>

#### Fields
- public uint Value

#### Methods
- public int CompareTo(Steamworks.Data.PackageId_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.PackageId_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.PackageId_t a, Steamworks.Data.PackageId_t b)
- public static Steamworks.Data.PackageId_t op_Implicit(uint value)
- public static uint op_Implicit(Steamworks.Data.PackageId_t value)
- public static bool op_Inequality(Steamworks.Data.PackageId_t a, Steamworks.Data.PackageId_t b)
- public override string ToString()

### internal struct Steamworks.Data.PartnerId_t
- Interfaces: System.IEquatable<Steamworks.Data.PartnerId_t>, System.IComparable<Steamworks.Data.PartnerId_t>

#### Fields
- public uint Value

#### Methods
- public int CompareTo(Steamworks.Data.PartnerId_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.PartnerId_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.PartnerId_t a, Steamworks.Data.PartnerId_t b)
- public static Steamworks.Data.PartnerId_t op_Implicit(uint value)
- public static uint op_Implicit(Steamworks.Data.PartnerId_t value)
- public static bool op_Inequality(Steamworks.Data.PartnerId_t a, Steamworks.Data.PartnerId_t b)
- public override string ToString()

### internal struct Steamworks.Data.PartyBeaconID_t
- Interfaces: System.IEquatable<Steamworks.Data.PartyBeaconID_t>, System.IComparable<Steamworks.Data.PartyBeaconID_t>

#### Fields
- public ulong Value

#### Methods
- public int CompareTo(Steamworks.Data.PartyBeaconID_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.PartyBeaconID_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.PartyBeaconID_t a, Steamworks.Data.PartyBeaconID_t b)
- public static Steamworks.Data.PartyBeaconID_t op_Implicit(ulong value)
- public static ulong op_Implicit(Steamworks.Data.PartyBeaconID_t value)
- public static bool op_Inequality(Steamworks.Data.PartyBeaconID_t a, Steamworks.Data.PartyBeaconID_t b)
- public override string ToString()

### internal struct Steamworks.Data.PersonaStateChange_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal int ChangeFlags
- internal ulong SteamID
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static PersonaStateChange_t()

### internal struct Steamworks.Data.PhysicalItemId_t
- Interfaces: System.IEquatable<Steamworks.Data.PhysicalItemId_t>, System.IComparable<Steamworks.Data.PhysicalItemId_t>

#### Fields
- public uint Value

#### Methods
- public int CompareTo(Steamworks.Data.PhysicalItemId_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.PhysicalItemId_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.PhysicalItemId_t a, Steamworks.Data.PhysicalItemId_t b)
- public static Steamworks.Data.PhysicalItemId_t op_Implicit(uint value)
- public static uint op_Implicit(Steamworks.Data.PhysicalItemId_t value)
- public static bool op_Inequality(Steamworks.Data.PhysicalItemId_t a, Steamworks.Data.PhysicalItemId_t b)
- public override string ToString()

### internal struct Steamworks.Data.PlaybackStatusHasChanged_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static PlaybackStatusHasChanged_t()

### internal enum Steamworks.Data.RequestPlayersForGameResultCallback_t.PlayerAcceptState_t
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- PlayerAccepted = 1
- PlayerDeclined = 2
- Unknown = 0

### internal struct Steamworks.Data.PSNGameBootInviteResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal bool GameBootInviteExists
- internal ulong SteamIDLobby
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static PSNGameBootInviteResult_t()

### public struct Steamworks.Data.PublishedFileId
- Interfaces: System.IEquatable<Steamworks.Data.PublishedFileId>, System.IComparable<Steamworks.Data.PublishedFileId>

#### Fields
- public ulong Value

#### Methods
- public int CompareTo(Steamworks.Data.PublishedFileId other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.PublishedFileId p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.PublishedFileId a, Steamworks.Data.PublishedFileId b)
- public static Steamworks.Data.PublishedFileId op_Implicit(ulong value)
- public static ulong op_Implicit(Steamworks.Data.PublishedFileId value)
- public static bool op_Inequality(Steamworks.Data.PublishedFileId a, Steamworks.Data.PublishedFileId b)
- public override string ToString()

### internal struct Steamworks.Data.PublishedFileUpdateHandle_t
- Interfaces: System.IEquatable<Steamworks.Data.PublishedFileUpdateHandle_t>, System.IComparable<Steamworks.Data.PublishedFileUpdateHandle_t>

#### Fields
- public ulong Value

#### Methods
- public int CompareTo(Steamworks.Data.PublishedFileUpdateHandle_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.PublishedFileUpdateHandle_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.PublishedFileUpdateHandle_t a, Steamworks.Data.PublishedFileUpdateHandle_t b)
- public static Steamworks.Data.PublishedFileUpdateHandle_t op_Implicit(ulong value)
- public static ulong op_Implicit(Steamworks.Data.PublishedFileUpdateHandle_t value)
- public static bool op_Inequality(Steamworks.Data.PublishedFileUpdateHandle_t a, Steamworks.Data.PublishedFileUpdateHandle_t b)
- public override string ToString()

### internal struct Steamworks.Data.RegisterActivationCodeResponse_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal uint PackageRegistered
- internal Steamworks.RegisterActivationCodeResult Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RegisterActivationCodeResponse_t()

### public struct Steamworks.Data.RemotePlaySession

#### Fields
- private uint <Id>k__BackingField

#### Properties
- public string ClientName { get; }
- public Steamworks.SteamDeviceFormFactor FormFactor { get; }
- public uint Id { get; set; }
- public bool IsValid { get; }
- public Steamworks.SteamId SteamId { get; }

#### Methods
- public static Steamworks.Data.RemotePlaySession op_Implicit(uint value)
- public static uint op_Implicit(Steamworks.Data.RemotePlaySession value)
- public override string ToString()

### internal struct Steamworks.Data.RemotePlaySessionID_t
- Interfaces: System.IEquatable<Steamworks.Data.RemotePlaySessionID_t>, System.IComparable<Steamworks.Data.RemotePlaySessionID_t>

#### Fields
- public uint Value

#### Methods
- public int CompareTo(Steamworks.Data.RemotePlaySessionID_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.RemotePlaySessionID_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.RemotePlaySessionID_t a, Steamworks.Data.RemotePlaySessionID_t b)
- public static Steamworks.Data.RemotePlaySessionID_t op_Implicit(uint value)
- public static uint op_Implicit(Steamworks.Data.RemotePlaySessionID_t value)
- public static bool op_Inequality(Steamworks.Data.RemotePlaySessionID_t a, Steamworks.Data.RemotePlaySessionID_t b)
- public override string ToString()

### internal struct Steamworks.Data.RemoteStorageAppSyncedClient_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.AppId AppID
- internal int NumDownloads
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RemoteStorageAppSyncedClient_t()

### internal struct Steamworks.Data.RemoteStorageAppSyncedServer_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.AppId AppID
- internal int NumUploads
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RemoteStorageAppSyncedServer_t()

### internal struct Steamworks.Data.RemoteStorageAppSyncProgress_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.AppId AppID
- internal uint BytesTransferredThisChunk
- internal byte[] CurrentFile
- internal double DAppPercentComplete
- internal bool Uploading
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RemoteStorageAppSyncProgress_t()

#### Methods
- internal string CurrentFileUTF8()

### internal struct Steamworks.Data.RemoteStorageAppSyncStatusCheck_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.AppId AppID
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RemoteStorageAppSyncStatusCheck_t()

### internal struct Steamworks.Data.RemoteStorageDeletePublishedFileResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Data.PublishedFileId PublishedFileId
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RemoteStorageDeletePublishedFileResult_t()

### internal struct Steamworks.Data.RemoteStorageDownloadUGCResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.AppId AppID
- internal ulong File
- internal byte[] PchFileName
- internal Steamworks.Result Result
- internal int SizeInBytes
- internal ulong SteamIDOwner
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RemoteStorageDownloadUGCResult_t()

#### Methods
- internal string PchFileNameUTF8()

### internal struct Steamworks.Data.RemoteStorageEnumeratePublishedFilesByUserActionResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.WorkshopFileAction Action
- internal Steamworks.Data.PublishedFileId[] GPublishedFileId
- internal uint[] GRTimeUpdated
- internal Steamworks.Result Result
- internal int ResultsReturned
- internal int TotalResultCount
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RemoteStorageEnumeratePublishedFilesByUserActionResult_t()

### internal struct Steamworks.Data.RemoteStorageEnumerateUserPublishedFilesResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Data.PublishedFileId[] GPublishedFileId
- internal Steamworks.Result Result
- internal int ResultsReturned
- internal int TotalResultCount
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RemoteStorageEnumerateUserPublishedFilesResult_t()

### internal struct Steamworks.Data.RemoteStorageEnumerateUserSharedWorkshopFilesResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Data.PublishedFileId[] GPublishedFileId
- internal Steamworks.Result Result
- internal int ResultsReturned
- internal int TotalResultCount
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RemoteStorageEnumerateUserSharedWorkshopFilesResult_t()

### internal struct Steamworks.Data.RemoteStorageEnumerateUserSubscribedFilesResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Data.PublishedFileId[] GPublishedFileId
- internal uint[] GRTimeSubscribed
- internal Steamworks.Result Result
- internal int ResultsReturned
- internal int TotalResultCount
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RemoteStorageEnumerateUserSubscribedFilesResult_t()

### internal struct Steamworks.Data.RemoteStorageEnumerateWorkshopFilesResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.AppId AppId
- internal Steamworks.Data.PublishedFileId[] GPublishedFileId
- internal float[] GScore
- internal Steamworks.Result Result
- internal int ResultsReturned
- internal uint StartIndex
- internal int TotalResultCount
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RemoteStorageEnumerateWorkshopFilesResult_t()

### internal struct Steamworks.Data.RemoteStorageFileReadAsyncComplete_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal ulong FileReadAsync
- internal uint Offset
- internal uint Read
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RemoteStorageFileReadAsyncComplete_t()

### internal struct Steamworks.Data.RemoteStorageFileShareResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal ulong File
- internal byte[] Filename
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RemoteStorageFileShareResult_t()

#### Methods
- internal string FilenameUTF8()

### internal struct Steamworks.Data.RemoteStorageFileWriteAsyncComplete_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RemoteStorageFileWriteAsyncComplete_t()

### internal struct Steamworks.Data.RemoteStorageGetPublishedFileDetailsResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal bool AcceptedForUse
- internal bool Banned
- internal Steamworks.AppId ConsumerAppID
- internal Steamworks.AppId CreatorAppID
- internal byte[] Description
- internal ulong File
- internal int FileSize
- internal Steamworks.WorkshopFileType FileType
- internal byte[] PchFileName
- internal ulong PreviewFile
- internal int PreviewFileSize
- internal Steamworks.Data.PublishedFileId PublishedFileId
- internal Steamworks.Result Result
- internal ulong SteamIDOwner
- internal byte[] Tags
- internal bool TagsTruncated
- internal uint TimeCreated
- internal uint TimeUpdated
- internal byte[] Title
- internal byte[] URL
- internal Steamworks.RemoteStoragePublishedFileVisibility Visibility
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RemoteStorageGetPublishedFileDetailsResult_t()

#### Methods
- internal string DescriptionUTF8()
- internal string PchFileNameUTF8()
- internal string TagsUTF8()
- internal string TitleUTF8()
- internal string URLUTF8()

### internal struct Steamworks.Data.RemoteStorageGetPublishedItemVoteDetailsResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal float FScore
- internal Steamworks.Data.PublishedFileId PublishedFileId
- internal int Reports
- internal Steamworks.Result Result
- internal int VotesAgainst
- internal int VotesFor
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RemoteStorageGetPublishedItemVoteDetailsResult_t()

### internal struct Steamworks.Data.RemoteStoragePublishedFileDeleted_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.AppId AppID
- internal Steamworks.Data.PublishedFileId PublishedFileId
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RemoteStoragePublishedFileDeleted_t()

### internal struct Steamworks.Data.RemoteStoragePublishedFileSubscribed_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.AppId AppID
- internal Steamworks.Data.PublishedFileId PublishedFileId
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RemoteStoragePublishedFileSubscribed_t()

### internal struct Steamworks.Data.RemoteStoragePublishedFileUnsubscribed_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.AppId AppID
- internal Steamworks.Data.PublishedFileId PublishedFileId
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RemoteStoragePublishedFileUnsubscribed_t()

### internal struct Steamworks.Data.RemoteStoragePublishedFileUpdated_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.AppId AppID
- internal Steamworks.Data.PublishedFileId PublishedFileId
- internal ulong Unused
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RemoteStoragePublishedFileUpdated_t()

### internal struct Steamworks.Data.RemoteStoragePublishFileProgress_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal double DPercentFile
- internal bool Preview
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RemoteStoragePublishFileProgress_t()

### internal struct Steamworks.Data.RemoteStoragePublishFileResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Data.PublishedFileId PublishedFileId
- internal Steamworks.Result Result
- internal bool UserNeedsToAcceptWorkshopLegalAgreement
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RemoteStoragePublishFileResult_t()

### internal struct Steamworks.Data.RemoteStorageSetUserPublishedFileActionResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.WorkshopFileAction Action
- internal Steamworks.Data.PublishedFileId PublishedFileId
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RemoteStorageSetUserPublishedFileActionResult_t()

### internal struct Steamworks.Data.RemoteStorageSubscribePublishedFileResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Data.PublishedFileId PublishedFileId
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RemoteStorageSubscribePublishedFileResult_t()

### internal struct Steamworks.Data.RemoteStorageUnsubscribePublishedFileResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Data.PublishedFileId PublishedFileId
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RemoteStorageUnsubscribePublishedFileResult_t()

### internal struct Steamworks.Data.RemoteStorageUpdatePublishedFileResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Data.PublishedFileId PublishedFileId
- internal Steamworks.Result Result
- internal bool UserNeedsToAcceptWorkshopLegalAgreement
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RemoteStorageUpdatePublishedFileResult_t()

### internal struct Steamworks.Data.RemoteStorageUpdateUserPublishedItemVoteResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Data.PublishedFileId PublishedFileId
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RemoteStorageUpdateUserPublishedItemVoteResult_t()

### internal struct Steamworks.Data.RemoteStorageUserVoteDetails_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Data.PublishedFileId PublishedFileId
- internal Steamworks.Result Result
- internal Steamworks.WorkshopVote Vote
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RemoteStorageUserVoteDetails_t()

### internal struct Steamworks.Data.RemoveAppDependencyResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.AppId AppID
- internal Steamworks.Data.PublishedFileId PublishedFileId
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RemoveAppDependencyResult_t()

### internal struct Steamworks.Data.RemoveUGCDependencyResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Data.PublishedFileId ChildPublishedFileId
- internal Steamworks.Data.PublishedFileId PublishedFileId
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RemoveUGCDependencyResult_t()

### internal struct Steamworks.Data.RequestPlayersForGameFinalResultCallback_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal ulong LSearchID
- internal ulong LUniqueGameID
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RequestPlayersForGameFinalResultCallback_t()

### internal struct Steamworks.Data.RequestPlayersForGameProgressCallback_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal ulong LSearchID
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RequestPlayersForGameProgressCallback_t()

### internal struct Steamworks.Data.RequestPlayersForGameResultCallback_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal ulong LSearchID
- internal ulong LUniqueGameID
- internal Steamworks.Data.RequestPlayersForGameResultCallback_t.PlayerAcceptState_t PlayerAcceptState
- internal int PlayerIndex
- internal Steamworks.Result Result
- internal ulong SteamIDLobby
- internal ulong SteamIDPlayerFound
- internal int SuggestedTeamIndex
- internal int TotalPlayersAcceptedGame
- internal int TotalPlayersFound
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static RequestPlayersForGameResultCallback_t()

### internal struct Steamworks.Data.ReservationNotificationCallback_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal ulong BeaconID
- internal ulong SteamIDJoiner
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static ReservationNotificationCallback_t()

### internal struct Steamworks.Data.RTime32
- Interfaces: System.IEquatable<Steamworks.Data.RTime32>, System.IComparable<Steamworks.Data.RTime32>

#### Fields
- public uint Value

#### Methods
- public int CompareTo(Steamworks.Data.RTime32 other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.RTime32 p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.RTime32 a, Steamworks.Data.RTime32 b)
- public static Steamworks.Data.RTime32 op_Implicit(uint value)
- public static uint op_Implicit(Steamworks.Data.RTime32 value)
- public static bool op_Inequality(Steamworks.Data.RTime32 a, Steamworks.Data.RTime32 b)
- public override string ToString()

### public struct Steamworks.Data.Screenshot

#### Fields
- internal Steamworks.Data.ScreenshotHandle Value

#### Methods
- public bool SetLocation(string location)
- public bool TagPublishedFile(Steamworks.Data.PublishedFileId file)
- public bool TagUser(Steamworks.SteamId user)

### internal struct Steamworks.Data.ScreenshotHandle
- Interfaces: System.IEquatable<Steamworks.Data.ScreenshotHandle>, System.IComparable<Steamworks.Data.ScreenshotHandle>

#### Fields
- public uint Value

#### Methods
- public int CompareTo(Steamworks.Data.ScreenshotHandle other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.ScreenshotHandle p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.ScreenshotHandle a, Steamworks.Data.ScreenshotHandle b)
- public static Steamworks.Data.ScreenshotHandle op_Implicit(uint value)
- public static uint op_Implicit(Steamworks.Data.ScreenshotHandle value)
- public static bool op_Inequality(Steamworks.Data.ScreenshotHandle a, Steamworks.Data.ScreenshotHandle b)
- public override string ToString()

### internal struct Steamworks.Data.ScreenshotReady_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal uint Local
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static ScreenshotReady_t()

### internal struct Steamworks.Data.ScreenshotRequested_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static ScreenshotRequested_t()

### internal struct Steamworks.Data.SearchForGameProgressCallback_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal int CPlayersSearching
- internal ulong LobbyID
- internal ulong LSearchID
- internal Steamworks.Result Result
- internal int SecondsRemainingEstimate
- internal ulong SteamIDEndedSearch
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static SearchForGameProgressCallback_t()

### internal struct Steamworks.Data.SearchForGameResultCallback_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal int CountAcceptedGame
- internal int CountPlayersInGame
- internal bool FinalCallback
- internal ulong LSearchID
- internal Steamworks.Result Result
- internal ulong SteamIDHost
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static SearchForGameResultCallback_t()

### public enum Steamworks.Data.SendType
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- NoDelay = 4
- NoNagle = 1
- Reliable = 8
- Unreliable = 0

### public struct Steamworks.Data.ServerInfo
- Interfaces: System.IEquatable<Steamworks.Data.ServerInfo>

#### Fields
- private System.Net.IPAddress <Address>k__BackingField
- private uint <AddressRaw>k__BackingField
- private uint <AppId>k__BackingField
- private int <BotPlayers>k__BackingField
- private int <ConnectionPort>k__BackingField
- private string <Description>k__BackingField
- private string <GameDir>k__BackingField
- private uint <LastTimePlayed>k__BackingField
- private string <Map>k__BackingField
- private int <MaxPlayers>k__BackingField
- private string <Name>k__BackingField
- private bool <Passworded>k__BackingField
- private int <Ping>k__BackingField
- private int <Players>k__BackingField
- private int <QueryPort>k__BackingField
- private bool <Secure>k__BackingField
- private ulong <SteamId>k__BackingField
- private string <TagString>k__BackingField
- private int <Version>k__BackingField
- internal static const uint k_unFavoriteFlagFavorite
- internal static const uint k_unFavoriteFlagHistory
- internal static const uint k_unFavoriteFlagNone
- private string[] _tags

#### Properties
- public System.Net.IPAddress Address { get; set; }
- public uint AddressRaw { get; set; }
- public uint AppId { get; set; }
- public int BotPlayers { get; set; }
- public int ConnectionPort { get; set; }
- public string Description { get; set; }
- public string GameDir { get; set; }
- public uint LastTimePlayed { get; set; }
- public string Map { get; set; }
- public int MaxPlayers { get; set; }
- public string Name { get; set; }
- public bool Passworded { get; set; }
- public int Ping { get; set; }
- public int Players { get; set; }
- public int QueryPort { get; set; }
- public bool Secure { get; set; }
- public ulong SteamId { get; set; }
- public string[] Tags { get; }
- public string TagString { get; set; }
- public int Version { get; set; }

#### Constructors
- public ServerInfo(uint ip, ushort cport, ushort qport, uint timeplayed)

#### Methods
- public void AddToFavourites()
- public void AddToHistory()
- public bool Equals(Steamworks.Data.ServerInfo other)
- internal static Steamworks.Data.ServerInfo From(Steamworks.Data.gameserveritem_t item)
- public override int GetHashCode()
- public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string>> QueryRulesAsync()
- public void RemoveFromFavourites()
- public void RemoveFromHistory()

### internal struct Steamworks.Data.servernetadr_t

#### Fields
- internal ushort ConnectionPort
- internal uint IP
- internal ushort QueryPort

#### Methods
- internal static void InternalAssign(ref Steamworks.Data.servernetadr_t self, ref Steamworks.Data.servernetadr_t that)
- internal static void InternalConstruct(ref Steamworks.Data.servernetadr_t self)
- internal static Steamworks.Utf8StringPointer InternalGetConnectionAddressString(ref Steamworks.Data.servernetadr_t self)
- internal static ushort InternalGetConnectionPort(ref Steamworks.Data.servernetadr_t self)
- internal static uint InternalGetIP(ref Steamworks.Data.servernetadr_t self)
- internal static Steamworks.Utf8StringPointer InternalGetQueryAddressString(ref Steamworks.Data.servernetadr_t self)
- internal static ushort InternalGetQueryPort(ref Steamworks.Data.servernetadr_t self)
- internal static void InternalInit(ref Steamworks.Data.servernetadr_t self, uint ip, ushort usQueryPort, ushort usConnectionPort)
- internal static bool InternalIsLessThan(ref Steamworks.Data.servernetadr_t self, ref Steamworks.Data.servernetadr_t netadr)
- internal static void InternalSetConnectionPort(ref Steamworks.Data.servernetadr_t self, ushort usPort)
- internal static void InternalSetIP(ref Steamworks.Data.servernetadr_t self, uint unIP)
- internal static void InternalSetQueryPort(ref Steamworks.Data.servernetadr_t self, ushort usPort)

### internal struct Steamworks.Data.SetPersonaNameResponse_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal bool LocalSuccess
- internal Steamworks.Result Result
- internal bool Success
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static SetPersonaNameResponse_t()

### internal struct Steamworks.Data.SetUserItemVoteResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Data.PublishedFileId PublishedFileId
- internal Steamworks.Result Result
- internal bool VoteUp
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static SetUserItemVoteResult_t()

### internal struct Steamworks.Data.SiteId_t
- Interfaces: System.IEquatable<Steamworks.Data.SiteId_t>, System.IComparable<Steamworks.Data.SiteId_t>

#### Fields
- public ulong Value

#### Methods
- public int CompareTo(Steamworks.Data.SiteId_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.SiteId_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.SiteId_t a, Steamworks.Data.SiteId_t b)
- public static Steamworks.Data.SiteId_t op_Implicit(ulong value)
- public static ulong op_Implicit(Steamworks.Data.SiteId_t value)
- public static bool op_Inequality(Steamworks.Data.SiteId_t a, Steamworks.Data.SiteId_t b)
- public override string ToString()

### internal struct Steamworks.Data.SNetListenSocket_t
- Interfaces: System.IEquatable<Steamworks.Data.SNetListenSocket_t>, System.IComparable<Steamworks.Data.SNetListenSocket_t>

#### Fields
- public uint Value

#### Methods
- public int CompareTo(Steamworks.Data.SNetListenSocket_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.SNetListenSocket_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.SNetListenSocket_t a, Steamworks.Data.SNetListenSocket_t b)
- public static Steamworks.Data.SNetListenSocket_t op_Implicit(uint value)
- public static uint op_Implicit(Steamworks.Data.SNetListenSocket_t value)
- public static bool op_Inequality(Steamworks.Data.SNetListenSocket_t a, Steamworks.Data.SNetListenSocket_t b)
- public override string ToString()

### internal struct Steamworks.Data.SNetSocket_t
- Interfaces: System.IEquatable<Steamworks.Data.SNetSocket_t>, System.IComparable<Steamworks.Data.SNetSocket_t>

#### Fields
- public uint Value

#### Methods
- public int CompareTo(Steamworks.Data.SNetSocket_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.SNetSocket_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.SNetSocket_t a, Steamworks.Data.SNetSocket_t b)
- public static Steamworks.Data.SNetSocket_t op_Implicit(uint value)
- public static uint op_Implicit(Steamworks.Data.SNetSocket_t value)
- public static bool op_Inequality(Steamworks.Data.SNetSocket_t a, Steamworks.Data.SNetSocket_t b)
- public override string ToString()

### public struct Steamworks.Data.Socket

#### Fields
- internal uint Id

#### Properties
- public Steamworks.SocketManager Manager { get; set; }

#### Methods
- public bool Close()
- public static Steamworks.Data.Socket op_Implicit(uint value)
- public static uint op_Implicit(Steamworks.Data.Socket value)
- public override string ToString()

### internal struct Steamworks.Data.StartPlaytimeTrackingResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static StartPlaytimeTrackingResult_t()

### public struct Steamworks.Data.Stat

#### Fields
- private string <Name>k__BackingField
- private Steamworks.SteamId <UserId>k__BackingField

#### Properties
- public string Name { get; internal set; }
- public Steamworks.SteamId UserId { get; internal set; }

#### Constructors
- public Stat(string name)
- public Stat(string name, Steamworks.SteamId user)

#### Methods
- public bool Add(int val)
- public bool Add(float val)
- public float GetFloat()
- public double GetGlobalFloat()
- public System.Threading.Tasks.Task<double[]> GetGlobalFloatDays(int days)
- public long GetGlobalInt()
- public System.Threading.Tasks.Task<long[]> GetGlobalIntDaysAsync(int days)
- public int GetInt()
- internal void LocalUserOnly(string caller = null)
- public bool Set(int val)
- public bool Set(float val)
- public bool Store()
- public bool UpdateAverageRate(float count, float sessionlength)

### internal struct Steamworks.Data.SteamAPICallCompleted_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal ulong AsyncCall
- internal int Callback
- internal uint ParamCount
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static SteamAPICallCompleted_t()

### internal struct Steamworks.Data.SteamAPICall_t
- Interfaces: System.IEquatable<Steamworks.Data.SteamAPICall_t>, System.IComparable<Steamworks.Data.SteamAPICall_t>

#### Fields
- public ulong Value

#### Methods
- public int CompareTo(Steamworks.Data.SteamAPICall_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.SteamAPICall_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.SteamAPICall_t a, Steamworks.Data.SteamAPICall_t b)
- public static Steamworks.Data.SteamAPICall_t op_Implicit(ulong value)
- public static ulong op_Implicit(Steamworks.Data.SteamAPICall_t value)
- public static bool op_Inequality(Steamworks.Data.SteamAPICall_t a, Steamworks.Data.SteamAPICall_t b)
- public override string ToString()

### internal struct Steamworks.Data.SteamAppInstalled_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.AppId AppID
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static SteamAppInstalled_t()

### internal struct Steamworks.Data.SteamAppUninstalled_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.AppId AppID
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static SteamAppUninstalled_t()

### internal struct Steamworks.Data.SteamDatagramGameCoordinatorServerLogin

#### Fields
- internal byte[] AppData
- internal Steamworks.AppId AppID
- internal int CbAppData
- internal Steamworks.Data.NetIdentity Dentity
- internal Steamworks.Data.SteamDatagramHostedAddress Outing
- internal uint Time

#### Methods
- internal string AppDataUTF8()

### internal struct Steamworks.Data.SteamDatagramHostedAddress

#### Fields
- internal int CbSize
- internal byte[] Data

#### Methods
- internal string DataUTF8()
- internal static void InternalClear(ref Steamworks.Data.SteamDatagramHostedAddress self)
- internal static Steamworks.Data.SteamNetworkingPOPID InternalGetPopID(ref Steamworks.Data.SteamDatagramHostedAddress self)
- internal static void InternalSetDevAddress(ref Steamworks.Data.SteamDatagramHostedAddress self, uint nIP, ushort nPort, Steamworks.Data.SteamNetworkingPOPID popid)

### internal struct Steamworks.Data.SteamDatagramRelayAuthTicket

### internal struct Steamworks.Data.SteamInventoryDefinitionUpdate_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static SteamInventoryDefinitionUpdate_t()

### internal struct Steamworks.Data.SteamInventoryEligiblePromoItemDefIDs_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal bool CachedData
- internal Steamworks.Result Result
- internal ulong SteamID
- internal int UmEligiblePromoItemDefs
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static SteamInventoryEligiblePromoItemDefIDs_t()

### internal struct Steamworks.Data.SteamInventoryFullUpdate_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal int Handle
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static SteamInventoryFullUpdate_t()

### internal struct Steamworks.Data.SteamInventoryRequestPricesResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal byte[] Currency
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static SteamInventoryRequestPricesResult_t()

#### Methods
- internal string CurrencyUTF8()

### internal struct Steamworks.Data.SteamInventoryResultReady_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal int Handle
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static SteamInventoryResultReady_t()

### internal struct Steamworks.Data.SteamInventoryResult_t
- Interfaces: System.IEquatable<Steamworks.Data.SteamInventoryResult_t>, System.IComparable<Steamworks.Data.SteamInventoryResult_t>

#### Fields
- public int Value

#### Methods
- public int CompareTo(Steamworks.Data.SteamInventoryResult_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.SteamInventoryResult_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.SteamInventoryResult_t a, Steamworks.Data.SteamInventoryResult_t b)
- public static Steamworks.Data.SteamInventoryResult_t op_Implicit(int value)
- public static int op_Implicit(Steamworks.Data.SteamInventoryResult_t value)
- public static bool op_Inequality(Steamworks.Data.SteamInventoryResult_t a, Steamworks.Data.SteamInventoryResult_t b)
- public override string ToString()

### internal struct Steamworks.Data.SteamInventoryStartPurchaseResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal ulong OrderID
- internal Steamworks.Result Result
- internal ulong TransID
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static SteamInventoryStartPurchaseResult_t()

### internal struct Steamworks.Data.SteamInventoryUpdateHandle_t
- Interfaces: System.IEquatable<Steamworks.Data.SteamInventoryUpdateHandle_t>, System.IComparable<Steamworks.Data.SteamInventoryUpdateHandle_t>

#### Fields
- public ulong Value

#### Methods
- public int CompareTo(Steamworks.Data.SteamInventoryUpdateHandle_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.SteamInventoryUpdateHandle_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.SteamInventoryUpdateHandle_t a, Steamworks.Data.SteamInventoryUpdateHandle_t b)
- public static Steamworks.Data.SteamInventoryUpdateHandle_t op_Implicit(ulong value)
- public static ulong op_Implicit(Steamworks.Data.SteamInventoryUpdateHandle_t value)
- public static bool op_Inequality(Steamworks.Data.SteamInventoryUpdateHandle_t a, Steamworks.Data.SteamInventoryUpdateHandle_t b)
- public override string ToString()

### internal struct Steamworks.Data.SteamIPAddress

#### Fields
- public uint Ip4Address
- internal Steamworks.SteamIPType Type

#### Methods
- internal static bool InternalIsSet(ref Steamworks.Data.SteamIPAddress self)
- public static System.Net.IPAddress op_Implicit(Steamworks.Data.SteamIPAddress value)

### internal struct Steamworks.Data.SteamItemDetails_t

#### Fields
- internal Steamworks.Data.InventoryDefId Definition
- internal ushort Flags
- internal Steamworks.Data.InventoryItemId ItemId
- internal ushort Quantity

### internal struct Steamworks.Data.SteamLeaderboardEntries_t
- Interfaces: System.IEquatable<Steamworks.Data.SteamLeaderboardEntries_t>, System.IComparable<Steamworks.Data.SteamLeaderboardEntries_t>

#### Fields
- public ulong Value

#### Methods
- public int CompareTo(Steamworks.Data.SteamLeaderboardEntries_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.SteamLeaderboardEntries_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.SteamLeaderboardEntries_t a, Steamworks.Data.SteamLeaderboardEntries_t b)
- public static Steamworks.Data.SteamLeaderboardEntries_t op_Implicit(ulong value)
- public static ulong op_Implicit(Steamworks.Data.SteamLeaderboardEntries_t value)
- public static bool op_Inequality(Steamworks.Data.SteamLeaderboardEntries_t a, Steamworks.Data.SteamLeaderboardEntries_t b)
- public override string ToString()

### internal struct Steamworks.Data.SteamLeaderboard_t
- Interfaces: System.IEquatable<Steamworks.Data.SteamLeaderboard_t>, System.IComparable<Steamworks.Data.SteamLeaderboard_t>

#### Fields
- public ulong Value

#### Methods
- public int CompareTo(Steamworks.Data.SteamLeaderboard_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.SteamLeaderboard_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.SteamLeaderboard_t a, Steamworks.Data.SteamLeaderboard_t b)
- public static Steamworks.Data.SteamLeaderboard_t op_Implicit(ulong value)
- public static ulong op_Implicit(Steamworks.Data.SteamLeaderboard_t value)
- public static bool op_Inequality(Steamworks.Data.SteamLeaderboard_t a, Steamworks.Data.SteamLeaderboard_t b)
- public override string ToString()

### internal struct Steamworks.Data.SteamNetAuthenticationStatus_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.SteamNetworkingAvailability Avail
- internal byte[] DebugMsg
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static SteamNetAuthenticationStatus_t()

#### Methods
- internal string DebugMsgUTF8()

### internal struct Steamworks.Data.SteamNetConnectionStatusChangedCallback_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Data.Connection Conn
- internal Steamworks.Data.ConnectionInfo Nfo
- internal Steamworks.ConnectionState OldState
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static SteamNetConnectionStatusChangedCallback_t()

### internal struct Steamworks.Data.SteamNetworkingPOPID
- Interfaces: System.IEquatable<Steamworks.Data.SteamNetworkingPOPID>, System.IComparable<Steamworks.Data.SteamNetworkingPOPID>

#### Fields
- public uint Value

#### Methods
- public int CompareTo(Steamworks.Data.SteamNetworkingPOPID other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.SteamNetworkingPOPID p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.SteamNetworkingPOPID a, Steamworks.Data.SteamNetworkingPOPID b)
- public static Steamworks.Data.SteamNetworkingPOPID op_Implicit(uint value)
- public static uint op_Implicit(Steamworks.Data.SteamNetworkingPOPID value)
- public static bool op_Inequality(Steamworks.Data.SteamNetworkingPOPID a, Steamworks.Data.SteamNetworkingPOPID b)
- public override string ToString()

### internal struct Steamworks.Data.SteamNetworkingQuickConnectionStatus

#### Fields
- internal int CbPendingReliable
- internal int CbPendingUnreliable
- internal int CbSentUnackedReliable
- internal float ConnectionQualityLocal
- internal float ConnectionQualityRemote
- internal long EcQueueTime
- internal float InBytesPerSec
- internal float InPacketsPerSec
- internal float OutBytesPerSec
- internal float OutPacketsPerSec
- internal int Ping
- internal uint[] Reserved
- internal int SendRateBytesPerSecond
- internal Steamworks.ConnectionState State

### internal struct Steamworks.Data.SteamParamStringArray_t

#### Fields
- internal int NumStrings
- internal System.IntPtr Strings

### internal struct Steamworks.Data.SteamParentalSettingsChanged_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static SteamParentalSettingsChanged_t()

### internal struct Steamworks.Data.SteamPartyBeaconLocation_t

#### Fields
- internal ulong LocationID
- internal Steamworks.SteamPartyBeaconLocationType Type

### internal struct Steamworks.Data.SteamRelayNetworkStatus_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.SteamNetworkingAvailability Avail
- internal Steamworks.SteamNetworkingAvailability AvailAnyRelay
- internal Steamworks.SteamNetworkingAvailability AvailNetworkConfig
- internal byte[] DebugMsg
- internal int PingMeasurementInProgress
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static SteamRelayNetworkStatus_t()

#### Methods
- internal string DebugMsgUTF8()

### internal struct Steamworks.Data.SteamRemotePlaySessionConnected_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal uint SessionID
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static SteamRemotePlaySessionConnected_t()

### internal struct Steamworks.Data.SteamRemotePlaySessionDisconnected_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal uint SessionID
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static SteamRemotePlaySessionDisconnected_t()

### internal struct Steamworks.Data.SteamServerConnectFailure_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Result Result
- internal bool StillRetrying
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static SteamServerConnectFailure_t()

### internal struct Steamworks.Data.SteamServersConnected_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static SteamServersConnected_t()

### internal struct Steamworks.Data.SteamServersDisconnected_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static SteamServersDisconnected_t()

### internal struct Steamworks.Data.SteamShutdown_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static SteamShutdown_t()

### internal struct Steamworks.Data.SteamTVRegion_t

#### Fields
- internal uint UnMaxX
- internal uint UnMaxY
- internal uint UnMinX
- internal uint UnMinY

### internal struct Steamworks.Data.SteamUGCDetails_t

#### Fields
- internal bool AcceptedForUse
- internal bool Banned
- internal Steamworks.AppId ConsumerAppID
- internal Steamworks.AppId CreatorAppID
- internal byte[] Description
- internal ulong File
- internal int FileSize
- internal Steamworks.WorkshopFileType FileType
- internal uint NumChildren
- internal byte[] PchFileName
- internal ulong PreviewFile
- internal int PreviewFileSize
- internal Steamworks.Data.PublishedFileId PublishedFileId
- internal Steamworks.Result Result
- internal float Score
- internal ulong SteamIDOwner
- internal byte[] Tags
- internal bool TagsTruncated
- internal uint TimeAddedToUserList
- internal uint TimeCreated
- internal uint TimeUpdated
- internal byte[] Title
- internal byte[] URL
- internal Steamworks.RemoteStoragePublishedFileVisibility Visibility
- internal uint VotesDown
- internal uint VotesUp

#### Methods
- internal string DescriptionUTF8()
- internal string PchFileNameUTF8()
- internal string TagsUTF8()
- internal string TitleUTF8()
- internal string URLUTF8()

### internal struct Steamworks.Data.SteamUGCQueryCompleted_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal bool CachedData
- internal ulong Handle
- internal byte[] NextCursor
- internal uint NumResultsReturned
- internal Steamworks.Result Result
- internal uint TotalMatchingResults
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static SteamUGCQueryCompleted_t()

#### Methods
- internal string NextCursorUTF8()

### internal struct Steamworks.Data.SteamUGCRequestUGCDetailsResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal bool CachedData
- internal Steamworks.Data.SteamUGCDetails_t Details
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static SteamUGCRequestUGCDetailsResult_t()

### internal struct Steamworks.Data.StopPlaytimeTrackingResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static StopPlaytimeTrackingResult_t()

### internal struct Steamworks.Data.StoreAuthURLResponse_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal byte[] URL
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static StoreAuthURLResponse_t()

#### Methods
- internal string URLUTF8()

### internal struct Steamworks.Data.SubmitItemUpdateResult_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Data.PublishedFileId PublishedFileId
- internal Steamworks.Result Result
- internal bool UserNeedsToAcceptWorkshopLegalAgreement
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static SubmitItemUpdateResult_t()

### internal struct Steamworks.Data.SubmitPlayerResultResultCallback_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Result Result
- internal ulong SteamIDPlayer
- internal ulong UllUniqueGameID
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static SubmitPlayerResultResultCallback_t()

### internal struct Steamworks.Data.TxnID_t
- Interfaces: System.IEquatable<Steamworks.Data.TxnID_t>, System.IComparable<Steamworks.Data.TxnID_t>

#### Fields
- public ulong Value

#### Methods
- public int CompareTo(Steamworks.Data.TxnID_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.TxnID_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.TxnID_t a, Steamworks.Data.TxnID_t b)
- public static Steamworks.Data.TxnID_t op_Implicit(ulong value)
- public static ulong op_Implicit(Steamworks.Data.TxnID_t value)
- public static bool op_Inequality(Steamworks.Data.TxnID_t a, Steamworks.Data.TxnID_t b)
- public override string ToString()

### public struct Steamworks.Data.Ugc

#### Fields
- internal Steamworks.Data.UGCHandle_t Handle

### internal struct Steamworks.Data.UGCFileWriteStreamHandle_t
- Interfaces: System.IEquatable<Steamworks.Data.UGCFileWriteStreamHandle_t>, System.IComparable<Steamworks.Data.UGCFileWriteStreamHandle_t>

#### Fields
- public ulong Value

#### Methods
- public int CompareTo(Steamworks.Data.UGCFileWriteStreamHandle_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.UGCFileWriteStreamHandle_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.UGCFileWriteStreamHandle_t a, Steamworks.Data.UGCFileWriteStreamHandle_t b)
- public static Steamworks.Data.UGCFileWriteStreamHandle_t op_Implicit(ulong value)
- public static ulong op_Implicit(Steamworks.Data.UGCFileWriteStreamHandle_t value)
- public static bool op_Inequality(Steamworks.Data.UGCFileWriteStreamHandle_t a, Steamworks.Data.UGCFileWriteStreamHandle_t b)
- public override string ToString()

### internal struct Steamworks.Data.UGCHandle_t
- Interfaces: System.IEquatable<Steamworks.Data.UGCHandle_t>, System.IComparable<Steamworks.Data.UGCHandle_t>

#### Fields
- public ulong Value

#### Methods
- public int CompareTo(Steamworks.Data.UGCHandle_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.UGCHandle_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.UGCHandle_t a, Steamworks.Data.UGCHandle_t b)
- public static Steamworks.Data.UGCHandle_t op_Implicit(ulong value)
- public static ulong op_Implicit(Steamworks.Data.UGCHandle_t value)
- public static bool op_Inequality(Steamworks.Data.UGCHandle_t a, Steamworks.Data.UGCHandle_t b)
- public override string ToString()

### internal struct Steamworks.Data.UGCQueryHandle_t
- Interfaces: System.IEquatable<Steamworks.Data.UGCQueryHandle_t>, System.IComparable<Steamworks.Data.UGCQueryHandle_t>

#### Fields
- public ulong Value

#### Methods
- public int CompareTo(Steamworks.Data.UGCQueryHandle_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.UGCQueryHandle_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.UGCQueryHandle_t a, Steamworks.Data.UGCQueryHandle_t b)
- public static Steamworks.Data.UGCQueryHandle_t op_Implicit(ulong value)
- public static ulong op_Implicit(Steamworks.Data.UGCQueryHandle_t value)
- public static bool op_Inequality(Steamworks.Data.UGCQueryHandle_t a, Steamworks.Data.UGCQueryHandle_t b)
- public override string ToString()

### internal struct Steamworks.Data.UGCUpdateHandle_t
- Interfaces: System.IEquatable<Steamworks.Data.UGCUpdateHandle_t>, System.IComparable<Steamworks.Data.UGCUpdateHandle_t>

#### Fields
- public ulong Value

#### Methods
- public int CompareTo(Steamworks.Data.UGCUpdateHandle_t other)
- public override bool Equals(object p)
- public bool Equals(Steamworks.Data.UGCUpdateHandle_t p)
- public override int GetHashCode()
- public static bool op_Equality(Steamworks.Data.UGCUpdateHandle_t a, Steamworks.Data.UGCUpdateHandle_t b)
- public static Steamworks.Data.UGCUpdateHandle_t op_Implicit(ulong value)
- public static ulong op_Implicit(Steamworks.Data.UGCUpdateHandle_t value)
- public static bool op_Inequality(Steamworks.Data.UGCUpdateHandle_t a, Steamworks.Data.UGCUpdateHandle_t b)
- public override string ToString()

### internal struct Steamworks.Data.UnreadChatMessagesChanged_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static UnreadChatMessagesChanged_t()

### internal struct Steamworks.Data.UserAchievementIconFetched_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal bool Achieved
- internal byte[] AchievementName
- internal Steamworks.Data.GameId GameID
- internal int IconHandle
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static UserAchievementIconFetched_t()

#### Methods
- internal string AchievementNameUTF8()

### internal struct Steamworks.Data.UserAchievementStored_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal byte[] AchievementName
- internal uint CurProgress
- internal ulong GameID
- internal bool GroupAchievement
- internal uint MaxProgress
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static UserAchievementStored_t()

#### Methods
- internal string AchievementNameUTF8()

### internal struct Steamworks.Data.UserFavoriteItemsListChanged_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.Data.PublishedFileId PublishedFileId
- internal Steamworks.Result Result
- internal bool WasAddRequest
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static UserFavoriteItemsListChanged_t()

### internal struct Steamworks.Data.UserStatsReceived_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal ulong GameID
- internal Steamworks.Result Result
- internal ulong SteamIDUser
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static UserStatsReceived_t()

### internal struct Steamworks.Data.UserStatsStored_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal ulong GameID
- internal Steamworks.Result Result
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static UserStatsStored_t()

### internal struct Steamworks.Data.UserStatsUnloaded_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal ulong SteamIDUser
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static UserStatsUnloaded_t()

### internal struct Steamworks.Data.ValidateAuthTicketResponse_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal Steamworks.AuthResponse AuthSessionResponse
- internal ulong OwnerSteamID
- internal ulong SteamID
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static ValidateAuthTicketResponse_t()

### internal struct Steamworks.Data.VolumeHasChanged_t
- Interfaces: Steamworks.ICallbackData

#### Fields
- internal float NewVolume
- public static int _datasize

#### Properties
- public Steamworks.CallbackType CallbackType { get; }
- public int DataSize { get; }

#### Constructors
- private static VolumeHasChanged_t()

## Namespace: Steamworks.ServerList

### private class Steamworks.ServerList.Base.<RunQueryAsync>d__15
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.ServerList.Base <>4__this
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter <>u__1
- private int <r>5__3
- private System.Diagnostics.Stopwatch <stopwatch>5__1
- private Steamworks.Data.HServerListRequest <thisRequest>5__2
- public float timeoutSeconds

#### Constructors
- public Base.<RunQueryAsync>d__15()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.ServerList.IpList.<RunQueryAsync>d__4
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.ServerList.IpList <>4__this
- private System.Collections.Generic.IEnumerator<string> <>s__6
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<bool> <>u__1
- private int <blockSize>5__1
- private string[] <ips>5__3
- private Steamworks.ServerList.Internet <list>5__5
- private int <pointer>5__2
- private string <server>5__7
- private System.Collections.Generic.IEnumerable<string> <sublist>5__4
- public float timeoutSeconds

#### Constructors
- public IpList.<RunQueryAsync>d__4()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### public class Steamworks.ServerList.Base
- Interfaces: System.IDisposable

#### Fields
- private Steamworks.AppId <AppId>k__BackingField
- internal System.Collections.Generic.List<Steamworks.Data.MatchMakingKeyValuePair> filters
- internal int LastCount
- private System.Action OnChanges
- private System.Action<Steamworks.Data.ServerInfo> OnResponsiveServer
- internal Steamworks.Data.HServerListRequest request
- public System.Collections.Generic.List<Steamworks.Data.ServerInfo> Responsive
- public System.Collections.Generic.List<Steamworks.Data.ServerInfo> Unresponsive
- internal System.Collections.Generic.List<int> watchList

#### Properties
- public Steamworks.AppId AppId { get; set; }
- internal int Count { get; }
- internal static Steamworks.ISteamMatchmakingServers Internal { get; }
- internal bool IsRefreshing { get; }

#### Events
- public event System.Action OnChanges
- public event System.Action<Steamworks.Data.ServerInfo> OnResponsiveServer

#### Constructors
- public Base()

#### Methods
- private bool <MovePendingToUnresponsive>b__34_0(int x)
- private bool <UpdateResponsive>b__33_0(int x)
- public void AddFilter(string key, string value)
- public virtual void Cancel()
- public void Dispose()
- internal virtual Steamworks.Data.MatchMakingKeyValuePair[] GetFilters()
- internal void InvokeChanges()
- internal abstract void LaunchQuery()
- private void MovePendingToUnresponsive()
- private void OnServer(Steamworks.Data.ServerInfo serverInfo, bool responded)
- private void ReleaseQuery()
- private void Reset()
- public virtual System.Threading.Tasks.Task<bool> RunQueryAsync(float timeoutSeconds = 10)
- private void UpdatePending()
- public void UpdateResponsive()

### public class Steamworks.ServerList.Favourites
- Base: Steamworks.ServerList.Base
- Interfaces: System.IDisposable

#### Constructors
- public Favourites()

#### Methods
- internal override void LaunchQuery()

### public class Steamworks.ServerList.Friends
- Base: Steamworks.ServerList.Base
- Interfaces: System.IDisposable

#### Constructors
- public Friends()

#### Methods
- internal override void LaunchQuery()

### public class Steamworks.ServerList.History
- Base: Steamworks.ServerList.Base
- Interfaces: System.IDisposable

#### Constructors
- public History()

#### Methods
- internal override void LaunchQuery()

### public class Steamworks.ServerList.Internet
- Base: Steamworks.ServerList.Base
- Interfaces: System.IDisposable

#### Constructors
- public Internet()

#### Methods
- internal override void LaunchQuery()

### public class Steamworks.ServerList.IpList
- Base: Steamworks.ServerList.Internet
- Interfaces: System.IDisposable

#### Fields
- public System.Collections.Generic.List<string> Ips
- private bool wantsCancel

#### Constructors
- public IpList(System.Collections.Generic.IEnumerable<string> list)
- public IpList(params string[] list)

#### Methods
- public override void Cancel()
- public override System.Threading.Tasks.Task<bool> RunQueryAsync(float timeoutSeconds = 10)

### public class Steamworks.ServerList.LocalNetwork
- Base: Steamworks.ServerList.Base
- Interfaces: System.IDisposable

#### Constructors
- public LocalNetwork()

#### Methods
- internal override void LaunchQuery()

## Namespace: Steamworks.Ugc

### private class Steamworks.Ugc.Item.<AddFavorite>d__72
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.Ugc.Item <>4__this
- private System.Nullable<Steamworks.Data.UserFavoriteItemsListChanged_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.UserFavoriteItemsListChanged_t> <>u__1
- private System.Nullable<Steamworks.Data.UserFavoriteItemsListChanged_t> <result>5__1

#### Constructors
- public Item.<AddFavorite>d__72()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.Ugc.Item.<DownloadAsync>d__70
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.Ugc.Item <>4__this
- private bool <>s__1
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder
- private System.Runtime.CompilerServices.TaskAwaiter<bool> <>u__1
- public System.Threading.CancellationToken ct
- public int milisecondsUpdateDelay
- public System.Action<float> progress

#### Constructors
- public Item.<DownloadAsync>d__70()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.Ugc.Item.<GetAsync>d__66
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- private System.Nullable<Steamworks.Data.SteamUGCRequestUGCDetailsResult_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.Ugc.Item>> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.SteamUGCRequestUGCDetailsResult_t> <>u__1
- private System.Nullable<Steamworks.Data.SteamUGCRequestUGCDetailsResult_t> <result>5__1
- public Steamworks.Data.PublishedFileId id
- public int maxageseconds

#### Constructors
- public Item.<GetAsync>d__66()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.Ugc.Query.<GetPageAsync>d__76
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.Ugc.Query <>4__this
- private System.Nullable<Steamworks.Data.SteamUGCQueryCompleted_t> <>s__3
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.Ugc.ResultPage>> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.SteamUGCQueryCompleted_t> <>u__1
- private Steamworks.Data.UGCQueryHandle_t <handle>5__1
- private System.Nullable<Steamworks.Data.SteamUGCQueryCompleted_t> <result>5__2
- public int page

#### Constructors
- public Query.<GetPageAsync>d__76()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.Ugc.Item.<GetUserVote>d__75
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.Ugc.Item <>4__this
- private System.Nullable<Steamworks.Data.GetUserItemVoteResult_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.Ugc.UserItemVote>> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.GetUserItemVoteResult_t> <>u__1
- private System.Nullable<Steamworks.Data.GetUserItemVoteResult_t> <result>5__1

#### Constructors
- public Item.<GetUserVote>d__75()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.Ugc.ResultPage.<get_Entries>d__5
- Interfaces: System.Collections.Generic.IEnumerable<Steamworks.Ugc.Item>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Steamworks.Ugc.Item>, System.IDisposable, System.Collections.IEnumerator

#### Fields
- private int <>1__state
- private Steamworks.Ugc.Item <>2__current
- public Steamworks.Ugc.ResultPage <>3__<>4__this
- public Steamworks.Ugc.ResultPage <>4__this
- private int <>l__initialThreadId
- private Steamworks.Data.SteamUGCDetails_t <details>5__1
- private uint <i>5__2
- private Steamworks.Ugc.Item <item>5__3
- private string <preview>5__4

#### Properties
- private Steamworks.Ugc.Item System.Collections.Generic.IEnumerator<Steamworks.Ugc.Item>.Current { get; }
- private object System.Collections.IEnumerator.Current { get; }

#### Constructors
- public ResultPage.<get_Entries>d__5(int <>1__state)

#### Methods
- private bool MoveNext()
- private System.Collections.Generic.IEnumerator<Steamworks.Ugc.Item> System.Collections.Generic.IEnumerable<Steamworks.Ugc.Item>.GetEnumerator()
- private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
- private void System.Collections.IEnumerator.Reset()
- private void System.IDisposable.Dispose()

### private class Steamworks.Ugc.Item.<RemoveFavorite>d__73
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.Ugc.Item <>4__this
- private System.Nullable<Steamworks.Data.UserFavoriteItemsListChanged_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.UserFavoriteItemsListChanged_t> <>u__1
- private System.Nullable<Steamworks.Data.UserFavoriteItemsListChanged_t> <result>5__1

#### Constructors
- public Item.<RemoveFavorite>d__73()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.Ugc.Editor.<SubmitAsync>d__34
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.Ugc.Editor <>4__this
- private Steamworks.ItemUpdateStatus <>s__14
- private System.Nullable<Steamworks.Data.CreateItemResult_t> <>s__3
- private System.Collections.Generic.Dictionary<TKey, TValue>.Enumerator<string, string> <>s__9
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Steamworks.Ugc.PublishResult> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.CreateItemResult_t> <>u__1
- private System.Runtime.CompilerServices.TaskAwaiter <>u__2
- private Steamworks.Ugc.SteamParamStringArray <a>5__7
- private System.Nullable<Steamworks.Data.CreateItemResult_t> <created>5__2
- private Steamworks.Data.UGCUpdateHandle_t <handle>5__4
- private System.Collections.Generic.KeyValuePair<string, string> <keyValueTag>5__10
- private ulong <processed>5__12
- private Steamworks.ItemUpdateStatus <r>5__13
- private Steamworks.Ugc.PublishResult <result>5__1
- private ulong <total>5__11
- private System.Nullable<Steamworks.Data.SubmitItemUpdateResult_t> <updated>5__6
- private Steamworks.CallResult<Steamworks.Data.SubmitItemUpdateResult_t> <updating>5__5
- private float <uploaded>5__15
- private Steamworks.Data.SteamParamStringArray_t <val>5__8
- public System.IProgress<float> progress

#### Constructors
- public Editor.<SubmitAsync>d__34()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.Ugc.Item.<Subscribe>d__69
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.Ugc.Item <>4__this
- private System.Nullable<Steamworks.Data.RemoteStorageSubscribePublishedFileResult_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.RemoteStorageSubscribePublishedFileResult_t> <>u__1
- private System.Nullable<Steamworks.Data.RemoteStorageSubscribePublishedFileResult_t> <result>5__1

#### Constructors
- public Item.<Subscribe>d__69()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.Ugc.Item.<Unsubscribe>d__71
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.Ugc.Item <>4__this
- private System.Nullable<Steamworks.Data.RemoteStorageUnsubscribePublishedFileResult_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.RemoteStorageUnsubscribePublishedFileResult_t> <>u__1
- private System.Nullable<Steamworks.Data.RemoteStorageUnsubscribePublishedFileResult_t> <result>5__1

#### Constructors
- public Item.<Unsubscribe>d__71()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### private class Steamworks.Ugc.Item.<Vote>d__74
- Interfaces: System.Runtime.CompilerServices.IAsyncStateMachine

#### Fields
- public int <>1__state
- public Steamworks.Ugc.Item <>4__this
- private System.Nullable<Steamworks.Data.SetUserItemVoteResult_t> <>s__2
- public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<Steamworks.Result>> <>t__builder
- private Steamworks.CallResult<Steamworks.Data.SetUserItemVoteResult_t> <>u__1
- private System.Nullable<Steamworks.Data.SetUserItemVoteResult_t> <r>5__1
- public bool up

#### Constructors
- public Item.<Vote>d__74()

#### Methods
- private void MoveNext()
- private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)

### public struct Steamworks.Ugc.Editor

#### Fields
- private string ChangeLog
- private Steamworks.AppId consumerAppId
- private System.IO.DirectoryInfo ContentFolder
- private bool creatingNew
- private Steamworks.WorkshopFileType creatingType
- private string Description
- private Steamworks.Data.PublishedFileId fileId
- private System.Collections.Generic.Dictionary<string, string> KeyValueTags
- private string Language
- private string MetaData
- private string PreviewFile
- private System.Collections.Generic.List<string> Tags
- private string Title
- private System.Nullable<Steamworks.RemoteStoragePublishedFileVisibility> Visibility

#### Properties
- public static Steamworks.Ugc.Editor NewCommunityFile { get; }
- public static Steamworks.Ugc.Editor NewMicrotransactionFile { get; }

#### Constructors
- internal Editor(Steamworks.WorkshopFileType filetype)
- public Editor(Steamworks.Data.PublishedFileId fileId)

#### Methods
- public Steamworks.Ugc.Editor AddKeyValueTag(string key, string value)
- public Steamworks.Ugc.Editor ForAppId(Steamworks.AppId id)
- public Steamworks.Ugc.Editor InLanguage(string t)
- public System.Threading.Tasks.Task<Steamworks.Ugc.PublishResult> SubmitAsync(System.IProgress<float> progress = null)
- public Steamworks.Ugc.Editor WithChangeLog(string t)
- public Steamworks.Ugc.Editor WithContent(System.IO.DirectoryInfo t)
- public Steamworks.Ugc.Editor WithContent(string folderName)
- public Steamworks.Ugc.Editor WithDescription(string t)
- public Steamworks.Ugc.Editor WithFriendsOnlyVisibility()
- public Steamworks.Ugc.Editor WithMetaData(string t)
- public Steamworks.Ugc.Editor WithPreviewFile(string t)
- public Steamworks.Ugc.Editor WithPrivateVisibility()
- public Steamworks.Ugc.Editor WithPublicVisibility()
- public Steamworks.Ugc.Editor WithTag(string tag)
- public Steamworks.Ugc.Editor WithTitle(string t)

### public struct Steamworks.Ugc.Item

#### Fields
- private string <Description>k__BackingField
- private ulong <NumComments>k__BackingField
- private ulong <NumFavorites>k__BackingField
- private ulong <NumFollowers>k__BackingField
- private ulong <NumPlaytimeSessions>k__BackingField
- private ulong <NumPlaytimeSessionsDuringTimePeriod>k__BackingField
- private ulong <NumSecondsPlayed>k__BackingField
- private ulong <NumSecondsPlayedDuringTimePeriod>k__BackingField
- private ulong <NumSubscriptions>k__BackingField
- private ulong <NumUniqueFavorites>k__BackingField
- private ulong <NumUniqueFollowers>k__BackingField
- private ulong <NumUniqueSubscriptions>k__BackingField
- private ulong <NumUniqueWebsiteViews>k__BackingField
- private string <PreviewImageUrl>k__BackingField
- private ulong <ReportScore>k__BackingField
- private string[] <Tags>k__BackingField
- private string <Title>k__BackingField
- internal Steamworks.Data.SteamUGCDetails_t details
- internal Steamworks.Data.PublishedFileId _id

#### Properties
- public string ChangelogUrl { get; }
- public string CommentsUrl { get; }
- public Steamworks.AppId ConsumerApp { get; }
- public System.DateTime Created { get; }
- public Steamworks.AppId CreatorApp { get; }
- public string Description { get; internal set; }
- public string Directory { get; }
- public string DiscussUrl { get; }
- public float DownloadAmount { get; }
- public long DownloadBytesDownloaded { get; }
- public long DownloadBytesTotal { get; }
- public Steamworks.Data.PublishedFileId Id { get; }
- public bool IsAcceptedForUse { get; }
- public bool IsBanned { get; }
- public bool IsDownloading { get; }
- public bool IsDownloadPending { get; }
- public bool IsFriendsOnly { get; }
- public bool IsInstalled { get; }
- public bool IsPrivate { get; }
- public bool IsPublic { get; }
- public bool IsSubscribed { get; }
- public bool NeedsUpdate { get; }
- public ulong NumComments { get; internal set; }
- public ulong NumFavorites { get; internal set; }
- public ulong NumFollowers { get; internal set; }
- public ulong NumPlaytimeSessions { get; internal set; }
- public ulong NumPlaytimeSessionsDuringTimePeriod { get; internal set; }
- public ulong NumSecondsPlayed { get; internal set; }
- public ulong NumSecondsPlayedDuringTimePeriod { get; internal set; }
- public ulong NumSubscriptions { get; internal set; }
- public ulong NumUniqueFavorites { get; internal set; }
- public ulong NumUniqueFollowers { get; internal set; }
- public ulong NumUniqueSubscriptions { get; internal set; }
- public ulong NumUniqueWebsiteViews { get; internal set; }
- public Steamworks.Friend Owner { get; }
- public string PreviewImageUrl { get; internal set; }
- public ulong ReportScore { get; internal set; }
- public Steamworks.Result Result { get; }
- public float Score { get; }
- public long SizeBytes { get; }
- private Steamworks.ItemState State { get; }
- public string StatsUrl { get; }
- public string[] Tags { get; internal set; }
- public string Title { get; internal set; }
- public System.DateTime Updated { get; }
- public string Url { get; }
- public uint VotesDown { get; }
- public uint VotesUp { get; }

#### Constructors
- public Item(Steamworks.Data.PublishedFileId id)

#### Methods
- public System.Threading.Tasks.Task<bool> AddFavorite()
- public bool Download(bool highPriority = false)
- public System.Threading.Tasks.Task<bool> DownloadAsync(System.Action<float> progress = null, int milisecondsUpdateDelay = 60, System.Threading.CancellationToken ct = null)
- public Steamworks.Ugc.Editor Edit()
- internal static Steamworks.Ugc.Item From(Steamworks.Data.SteamUGCDetails_t details)
- public static System.Threading.Tasks.Task<System.Nullable<Steamworks.Ugc.Item>> GetAsync(Steamworks.Data.PublishedFileId id, int maxageseconds = 1800)
- public System.Threading.Tasks.Task<System.Nullable<Steamworks.Ugc.UserItemVote>> GetUserVote()
- public bool HasTag(string find)
- public System.Threading.Tasks.Task<bool> RemoveFavorite()
- public System.Threading.Tasks.Task<bool> Subscribe()
- public System.Threading.Tasks.Task<bool> Unsubscribe()
- public System.Threading.Tasks.Task<System.Nullable<Steamworks.Result>> Vote(bool up)

### public struct Steamworks.Ugc.PublishResult

#### Fields
- public Steamworks.Data.PublishedFileId FileId
- public bool NeedsWorkshopAgreement
- public Steamworks.Result Result

#### Properties
- public bool Success { get; }

### public struct Steamworks.Ugc.Query

#### Fields
- private Steamworks.AppId consumerApp
- private Steamworks.AppId creatorApp
- private System.Collections.Generic.List<string> excludedTags
- private Steamworks.Data.PublishedFileId[] Files
- private string language
- private System.Nullable<bool> matchAnyTag
- private Steamworks.UgcType matchingType
- private System.Nullable<int> maxCacheAge
- private Steamworks.UGCQuery queryType
- private System.Collections.Generic.Dictionary<string, string> requiredKv
- private System.Collections.Generic.List<string> requiredTags
- private string searchText
- private System.Nullable<Steamworks.SteamId> steamid
- private System.Nullable<int> trendDays
- private Steamworks.UserUGCListSortOrder userSort
- private Steamworks.UserUGCList userType
- private System.Nullable<bool> WantsReturnAdditionalPreviews
- private System.Nullable<bool> WantsReturnChildren
- private System.Nullable<bool> WantsReturnKeyValueTags
- private System.Nullable<bool> WantsReturnLongDescription
- private System.Nullable<bool> WantsReturnMetadata
- private System.Nullable<bool> WantsReturnOnlyIDs
- private System.Nullable<uint> WantsReturnPlaytimeStats
- private System.Nullable<bool> WantsReturnTotalOnly

#### Properties
- public static Steamworks.Ugc.Query All { get; }
- public static Steamworks.Ugc.Query AllGuides { get; }
- public static Steamworks.Ugc.Query Artwork { get; }
- public static Steamworks.Ugc.Query Collections { get; }
- public static Steamworks.Ugc.Query ControllerBindings { get; }
- public static Steamworks.Ugc.Query GameManagedItems { get; }
- public static Steamworks.Ugc.Query IntegratedGuides { get; }
- public static Steamworks.Ugc.Query Items { get; }
- public static Steamworks.Ugc.Query ItemsMtx { get; }
- public static Steamworks.Ugc.Query ItemsReadyToUse { get; }
- public static Steamworks.Ugc.Query Screenshots { get; }
- public static Steamworks.Ugc.Query UsableInGame { get; }
- public static Steamworks.Ugc.Query Videos { get; }
- public static Steamworks.Ugc.Query WebGuides { get; }

#### Constructors
- public Query(Steamworks.UgcType type)

#### Methods
- public Steamworks.Ugc.Query AddRequiredKeyValueTag(string key, string value)
- public Steamworks.Ugc.Query AllowCachedResponse(int maxSecondsAge)
- private void ApplyConstraints(Steamworks.Data.UGCQueryHandle_t handle)
- private void ApplyReturns(Steamworks.Data.UGCQueryHandle_t handle)
- public Steamworks.Ugc.Query CreatedByFollowedUsers()
- public Steamworks.Ugc.Query CreatedByFriends()
- public Steamworks.Ugc.Query FavoritedByFriends()
- public System.Threading.Tasks.Task<System.Nullable<Steamworks.Ugc.ResultPage>> GetPageAsync(int page)
- public Steamworks.Ugc.Query InLanguage(string lang)
- internal Steamworks.Ugc.Query LimitUser(Steamworks.SteamId steamid)
- public Steamworks.Ugc.Query MatchAllTags()
- public Steamworks.Ugc.Query MatchAnyTag()
- public Steamworks.Ugc.Query NotYetRated()
- public Steamworks.Ugc.Query RankedByAcceptanceDate()
- public Steamworks.Ugc.Query RankedByAveragePlaytimeTrend()
- public Steamworks.Ugc.Query RankedByLifetimeAveragePlaytime()
- public Steamworks.Ugc.Query RankedByLifetimePlaytimeSessions()
- public Steamworks.Ugc.Query RankedByNumTimesReported()
- public Steamworks.Ugc.Query RankedByPlaytimeSessionsTrend()
- public Steamworks.Ugc.Query RankedByPlaytimeTrend()
- public Steamworks.Ugc.Query RankedByPublicationDate()
- public Steamworks.Ugc.Query RankedByTextSearch()
- public Steamworks.Ugc.Query RankedByTotalPlaytime()
- public Steamworks.Ugc.Query RankedByTotalUniqueSubscriptions()
- public Steamworks.Ugc.Query RankedByTotalVotesAsc()
- public Steamworks.Ugc.Query RankedByTrend()
- public Steamworks.Ugc.Query RankedByVote()
- public Steamworks.Ugc.Query RankedByVotesUp()
- public Steamworks.Ugc.Query SortByCreationDate()
- public Steamworks.Ugc.Query SortByCreationDateAsc()
- public Steamworks.Ugc.Query SortByModeration()
- public Steamworks.Ugc.Query SortBySubscriptionDate()
- public Steamworks.Ugc.Query SortByTitleAsc()
- public Steamworks.Ugc.Query SortByUpdateDate()
- public Steamworks.Ugc.Query SortByVoteScore()
- public Steamworks.Ugc.Query WhereSearchText(string searchText)
- public Steamworks.Ugc.Query WhereUserFavorited(Steamworks.SteamId user = null)
- public Steamworks.Ugc.Query WhereUserFollowed(Steamworks.SteamId user = null)
- public Steamworks.Ugc.Query WhereUserPublished(Steamworks.SteamId user = null)
- public Steamworks.Ugc.Query WhereUserSubscribed(Steamworks.SteamId user = null)
- public Steamworks.Ugc.Query WhereUserUsedOrPlayed(Steamworks.SteamId user = null)
- public Steamworks.Ugc.Query WhereUserVotedDown(Steamworks.SteamId user = null)
- public Steamworks.Ugc.Query WhereUserVotedOn(Steamworks.SteamId user = null)
- public Steamworks.Ugc.Query WhereUserVotedUp(Steamworks.SteamId user = null)
- public Steamworks.Ugc.Query WhereUserWillVoteLater(Steamworks.SteamId user = null)
- public Steamworks.Ugc.Query WithAdditionalPreviews(bool b)
- public Steamworks.Ugc.Query WithChildren(bool b)
- public Steamworks.Ugc.Query WithFileId(params Steamworks.Data.PublishedFileId[] files)
- public Steamworks.Ugc.Query WithKeyValueTag(bool b)
- public Steamworks.Ugc.Query WithLongDescription(bool b)
- public Steamworks.Ugc.Query WithMetadata(bool b)
- public Steamworks.Ugc.Query WithOnlyIDs(bool b)
- public Steamworks.Ugc.Query WithoutTag(string tag)
- public Steamworks.Ugc.Query WithPlaytimeStats(uint unDays)
- public Steamworks.Ugc.Query WithTag(string tag)
- public Steamworks.Ugc.Query WithTotalOnly(bool b)
- public Steamworks.Ugc.Query WithTrendDays(int days)
- public Steamworks.Ugc.Query WithType(Steamworks.UgcType type)

### public struct Steamworks.Ugc.ResultPage
- Interfaces: System.IDisposable

#### Fields
- public bool CachedData
- internal Steamworks.Data.UGCQueryHandle_t Handle
- public int ResultCount
- public int TotalCount

#### Properties
- public System.Collections.Generic.IEnumerable<Steamworks.Ugc.Item> Entries { get; }

#### Methods
- public void Dispose()
- private ulong GetStat(uint index, Steamworks.ItemStatistic stat)

### internal struct Steamworks.Ugc.SteamParamStringArray
- Interfaces: System.IDisposable

#### Fields
- private System.IntPtr NativeArray
- private System.IntPtr[] NativeStrings
- public Steamworks.Data.SteamParamStringArray_t Value

#### Methods
- public void Dispose()
- public static Steamworks.Ugc.SteamParamStringArray From(string[] array)

### public struct Steamworks.Ugc.UserItemVote

#### Fields
- public bool VotedDown
- public bool VotedUp
- public bool VoteSkipped

#### Methods
- internal static System.Nullable<Steamworks.Ugc.UserItemVote> From(Steamworks.Data.GetUserItemVoteResult_t result)

## Namespace: System.Runtime.CompilerServices

### internal class System.Runtime.CompilerServices.IsReadOnlyAttribute
- Base: System.Attribute

#### Constructors
- public IsReadOnlyAttribute()

