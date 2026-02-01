# Assembly: UnityEngine.GameCenterModule
- Path: tools/WorldBox.Managed/UnityEngine.GameCenterModule.dll
- Types: 22

## Namespace: UnityEngine

### public static class UnityEngine.Social

#### Properties
- public static UnityEngine.SocialPlatforms.ISocialPlatform Active { get; set; }
- public static UnityEngine.SocialPlatforms.ILocalUser localUser { get; }

#### Methods
- public static UnityEngine.SocialPlatforms.IAchievement CreateAchievement()
- public static UnityEngine.SocialPlatforms.ILeaderboard CreateLeaderboard()
- public static void LoadAchievementDescriptions(System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]> callback)
- public static void LoadAchievements(System.Action<UnityEngine.SocialPlatforms.IAchievement[]> callback)
- public static void LoadScores(string leaderboardID, System.Action<UnityEngine.SocialPlatforms.IScore[]> callback)
- public static void LoadUsers(string[] userIDs, System.Action<UnityEngine.SocialPlatforms.IUserProfile[]> callback)
- public static void ReportProgress(string achievementID, double progress, System.Action<bool> callback)
- public static void ReportScore(long score, string board, System.Action<bool> callback)
- public static void ShowAchievementsUI()
- public static void ShowLeaderboardUI()

## Namespace: UnityEngine.SocialPlatforms

### private class UnityEngine.SocialPlatforms.Local.<>c

#### Fields
- public static readonly UnityEngine.SocialPlatforms.Local.<>c <>9
- public static System.Comparison<UnityEngine.SocialPlatforms.Impl.Score> <>9__20_0

#### Constructors
- private static Local.<>c()
- public Local.<>c()

#### Methods
- internal int <SortScores>b__20_0(UnityEngine.SocialPlatforms.Impl.Score s1, UnityEngine.SocialPlatforms.Impl.Score s2)

### private class UnityEngine.SocialPlatforms.Local.<>c__DisplayClass10_0

#### Fields
- public System.Action<bool, string> callback

#### Constructors
- public Local.<>c__DisplayClass10_0()

#### Methods
- internal void <UnityEngine.SocialPlatforms.ISocialPlatform.Authenticate>b__0(bool success)

### internal static class UnityEngine.SocialPlatforms.ActivePlatform

#### Fields
- private static UnityEngine.SocialPlatforms.ISocialPlatform _active

#### Properties
- internal static UnityEngine.SocialPlatforms.ISocialPlatform Instance { get; set; }

#### Methods
- private static UnityEngine.SocialPlatforms.ISocialPlatform SelectSocialPlatform()

### public interface UnityEngine.SocialPlatforms.IAchievement

#### Properties
- public bool completed { get; }
- public bool hidden { get; }
- public string id { get; set; }
- public System.DateTime lastReportedDate { get; }
- public double percentCompleted { get; set; }

#### Methods
- public void ReportProgress(System.Action<bool> callback)

### public interface UnityEngine.SocialPlatforms.IAchievementDescription

#### Properties
- public string achievedDescription { get; }
- public bool hidden { get; }
- public string id { get; set; }
- public UnityEngine.Texture2D image { get; }
- public int points { get; }
- public string title { get; }
- public string unachievedDescription { get; }

### public interface UnityEngine.SocialPlatforms.ILeaderboard

#### Properties
- public string id { get; set; }
- public bool loading { get; }
- public UnityEngine.SocialPlatforms.IScore localUserScore { get; }
- public uint maxRange { get; }
- public UnityEngine.SocialPlatforms.Range range { get; set; }
- public UnityEngine.SocialPlatforms.IScore[] scores { get; }
- public UnityEngine.SocialPlatforms.TimeScope timeScope { get; set; }
- public string title { get; }
- public UnityEngine.SocialPlatforms.UserScope userScope { get; set; }

#### Methods
- public void LoadScores(System.Action<bool> callback)
- public void SetUserFilter(string[] userIDs)

### public interface UnityEngine.SocialPlatforms.ILocalUser
- Interfaces: UnityEngine.SocialPlatforms.IUserProfile

#### Properties
- public bool authenticated { get; }
- public UnityEngine.SocialPlatforms.IUserProfile[] friends { get; }
- public bool underage { get; }

#### Methods
- public void Authenticate(System.Action<bool> callback)
- public void Authenticate(System.Action<bool, string> callback)
- public void LoadFriends(System.Action<bool> callback)

### public interface UnityEngine.SocialPlatforms.IScore

#### Properties
- public System.DateTime date { get; }
- public string formattedValue { get; }
- public string leaderboardID { get; set; }
- public int rank { get; }
- public string userID { get; }
- public long value { get; set; }

#### Methods
- public void ReportScore(System.Action<bool> callback)

### public interface UnityEngine.SocialPlatforms.ISocialPlatform

#### Properties
- public UnityEngine.SocialPlatforms.ILocalUser localUser { get; }

#### Methods
- public void Authenticate(UnityEngine.SocialPlatforms.ILocalUser user, System.Action<bool> callback)
- public void Authenticate(UnityEngine.SocialPlatforms.ILocalUser user, System.Action<bool, string> callback)
- public UnityEngine.SocialPlatforms.IAchievement CreateAchievement()
- public UnityEngine.SocialPlatforms.ILeaderboard CreateLeaderboard()
- public bool GetLoading(UnityEngine.SocialPlatforms.ILeaderboard board)
- public void LoadAchievementDescriptions(System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]> callback)
- public void LoadAchievements(System.Action<UnityEngine.SocialPlatforms.IAchievement[]> callback)
- public void LoadFriends(UnityEngine.SocialPlatforms.ILocalUser user, System.Action<bool> callback)
- public void LoadScores(string leaderboardID, System.Action<UnityEngine.SocialPlatforms.IScore[]> callback)
- public void LoadScores(UnityEngine.SocialPlatforms.ILeaderboard board, System.Action<bool> callback)
- public void LoadUsers(string[] userIDs, System.Action<UnityEngine.SocialPlatforms.IUserProfile[]> callback)
- public void ReportProgress(string achievementID, double progress, System.Action<bool> callback)
- public void ReportScore(long score, string board, System.Action<bool> callback)
- public void ShowAchievementsUI()
- public void ShowLeaderboardUI()

### public interface UnityEngine.SocialPlatforms.IUserProfile

#### Properties
- public string id { get; }
- public UnityEngine.Texture2D image { get; }
- public bool isFriend { get; }
- public UnityEngine.SocialPlatforms.UserState state { get; }
- public string userName { get; }

### public class UnityEngine.SocialPlatforms.Local
- Interfaces: UnityEngine.SocialPlatforms.ISocialPlatform

#### Fields
- private System.Collections.Generic.List<UnityEngine.SocialPlatforms.Impl.AchievementDescription> m_AchievementDescriptions
- private System.Collections.Generic.List<UnityEngine.SocialPlatforms.Impl.Achievement> m_Achievements
- private UnityEngine.Texture2D m_DefaultTexture
- private System.Collections.Generic.List<UnityEngine.SocialPlatforms.Impl.UserProfile> m_Friends
- private System.Collections.Generic.List<UnityEngine.SocialPlatforms.Impl.Leaderboard> m_Leaderboards
- private static UnityEngine.SocialPlatforms.Impl.LocalUser m_LocalUser
- private System.Collections.Generic.List<UnityEngine.SocialPlatforms.Impl.UserProfile> m_Users

#### Properties
- public UnityEngine.SocialPlatforms.ILocalUser localUser { get; }

#### Constructors
- public Local()

#### Methods
- public UnityEngine.SocialPlatforms.IAchievement CreateAchievement()
- private UnityEngine.Texture2D CreateDummyTexture(int width, int height)
- public UnityEngine.SocialPlatforms.ILeaderboard CreateLeaderboard()
- public void LoadAchievementDescriptions(System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]> callback)
- public void LoadAchievements(System.Action<UnityEngine.SocialPlatforms.IAchievement[]> callback)
- public void LoadScores(string leaderboardID, System.Action<UnityEngine.SocialPlatforms.IScore[]> callback)
- public void LoadUsers(string[] userIDs, System.Action<UnityEngine.SocialPlatforms.IUserProfile[]> callback)
- private void PopulateStaticData()
- public void ReportProgress(string id, double progress, System.Action<bool> callback)
- public void ReportScore(long score, string board, System.Action<bool> callback)
- private void SetLocalPlayerScore(UnityEngine.SocialPlatforms.Impl.Leaderboard board)
- public void ShowAchievementsUI()
- public void ShowLeaderboardUI()
- private void SortScores(UnityEngine.SocialPlatforms.Impl.Leaderboard board)
- private void UnityEngine.SocialPlatforms.ISocialPlatform.Authenticate(UnityEngine.SocialPlatforms.ILocalUser user, System.Action<bool> callback)
- private void UnityEngine.SocialPlatforms.ISocialPlatform.Authenticate(UnityEngine.SocialPlatforms.ILocalUser user, System.Action<bool, string> callback)
- private bool UnityEngine.SocialPlatforms.ISocialPlatform.GetLoading(UnityEngine.SocialPlatforms.ILeaderboard board)
- private void UnityEngine.SocialPlatforms.ISocialPlatform.LoadFriends(UnityEngine.SocialPlatforms.ILocalUser user, System.Action<bool> callback)
- private void UnityEngine.SocialPlatforms.ISocialPlatform.LoadScores(UnityEngine.SocialPlatforms.ILeaderboard board, System.Action<bool> callback)
- private bool VerifyUser()

### public struct UnityEngine.SocialPlatforms.Range

#### Fields
- public int count
- public int from

#### Constructors
- public Range(int fromValue, int valueCount)

### public enum UnityEngine.SocialPlatforms.TimeScope
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- AllTime = 2
- Today = 0
- Week = 1

### public enum UnityEngine.SocialPlatforms.UserScope
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- FriendsOnly = 1
- Global = 0

### public enum UnityEngine.SocialPlatforms.UserState
- Interfaces: System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible

#### Enum Values
- Offline = 3
- Online = 0
- OnlineAndAway = 1
- OnlineAndBusy = 2
- Playing = 4

## Namespace: UnityEngine.SocialPlatforms.Impl

### public class UnityEngine.SocialPlatforms.Impl.Achievement
- Interfaces: UnityEngine.SocialPlatforms.IAchievement

#### Fields
- private string <id>k__BackingField
- private double <percentCompleted>k__BackingField
- private bool m_Completed
- private bool m_Hidden
- private System.DateTime m_LastReportedDate

#### Properties
- public bool completed { get; }
- public bool hidden { get; }
- public string id { get; set; }
- public System.DateTime lastReportedDate { get; }
- public double percentCompleted { get; set; }

#### Constructors
- public Achievement()
- public Achievement(string id, double percent)
- public Achievement(string id, double percentCompleted, bool completed, bool hidden, System.DateTime lastReportedDate)

#### Methods
- public void ReportProgress(System.Action<bool> callback)
- public void SetCompleted(bool value)
- public void SetHidden(bool value)
- public void SetLastReportedDate(System.DateTime date)
- public override string ToString()

### public class UnityEngine.SocialPlatforms.Impl.AchievementDescription
- Interfaces: UnityEngine.SocialPlatforms.IAchievementDescription

#### Fields
- private string <id>k__BackingField
- private string m_AchievedDescription
- private bool m_Hidden
- private UnityEngine.Texture2D m_Image
- private int m_Points
- private string m_Title
- private string m_UnachievedDescription

#### Properties
- public string achievedDescription { get; }
- public bool hidden { get; }
- public string id { get; set; }
- public UnityEngine.Texture2D image { get; }
- public int points { get; }
- public string title { get; }
- public string unachievedDescription { get; }

#### Constructors
- public AchievementDescription(string id, string title, UnityEngine.Texture2D image, string achievedDescription, string unachievedDescription, bool hidden, int points)

#### Methods
- public void SetImage(UnityEngine.Texture2D image)
- public override string ToString()

### public class UnityEngine.SocialPlatforms.Impl.Leaderboard
- Interfaces: UnityEngine.SocialPlatforms.ILeaderboard

#### Fields
- private string <id>k__BackingField
- private UnityEngine.SocialPlatforms.Range <range>k__BackingField
- private UnityEngine.SocialPlatforms.TimeScope <timeScope>k__BackingField
- private UnityEngine.SocialPlatforms.UserScope <userScope>k__BackingField
- private bool m_Loading
- private UnityEngine.SocialPlatforms.IScore m_LocalUserScore
- private uint m_MaxRange
- private UnityEngine.SocialPlatforms.IScore[] m_Scores
- private string m_Title
- private string[] m_UserIDs

#### Properties
- public string id { get; set; }
- public bool loading { get; }
- public UnityEngine.SocialPlatforms.IScore localUserScore { get; }
- public uint maxRange { get; }
- public UnityEngine.SocialPlatforms.Range range { get; set; }
- public UnityEngine.SocialPlatforms.IScore[] scores { get; }
- public UnityEngine.SocialPlatforms.TimeScope timeScope { get; set; }
- public string title { get; }
- public UnityEngine.SocialPlatforms.UserScope userScope { get; set; }

#### Constructors
- public Leaderboard()

#### Methods
- public string[] GetUserFilter()
- public void LoadScores(System.Action<bool> callback)
- public void SetLocalUserScore(UnityEngine.SocialPlatforms.IScore score)
- public void SetMaxRange(uint maxRange)
- public void SetScores(UnityEngine.SocialPlatforms.IScore[] scores)
- public void SetTitle(string title)
- public void SetUserFilter(string[] userIDs)
- public override string ToString()

### public class UnityEngine.SocialPlatforms.Impl.LocalUser
- Base: UnityEngine.SocialPlatforms.Impl.UserProfile
- Interfaces: UnityEngine.SocialPlatforms.IUserProfile, UnityEngine.SocialPlatforms.ILocalUser

#### Fields
- private bool m_Authenticated
- private UnityEngine.SocialPlatforms.IUserProfile[] m_Friends
- private bool m_Underage

#### Properties
- public bool authenticated { get; }
- public UnityEngine.SocialPlatforms.IUserProfile[] friends { get; }
- public bool underage { get; }

#### Constructors
- public LocalUser()

#### Methods
- public void Authenticate(System.Action<bool> callback)
- public void Authenticate(System.Action<bool, string> callback)
- public void LoadFriends(System.Action<bool> callback)
- public void SetAuthenticated(bool value)
- public void SetFriends(UnityEngine.SocialPlatforms.IUserProfile[] friends)
- public void SetUnderage(bool value)

### public class UnityEngine.SocialPlatforms.Impl.Score
- Interfaces: UnityEngine.SocialPlatforms.IScore

#### Fields
- private string <leaderboardID>k__BackingField
- private long <value>k__BackingField
- private System.DateTime m_Date
- private string m_FormattedValue
- private int m_Rank
- private string m_UserID

#### Properties
- public System.DateTime date { get; }
- public string formattedValue { get; }
- public string leaderboardID { get; set; }
- public int rank { get; }
- public string userID { get; }
- public long value { get; set; }

#### Constructors
- public Score()
- public Score(string leaderboardID, long value)
- public Score(string leaderboardID, long value, string userID, System.DateTime date, string formattedValue, int rank)

#### Methods
- public void ReportScore(System.Action<bool> callback)
- public void SetDate(System.DateTime date)
- public void SetFormattedValue(string value)
- public void SetRank(int rank)
- public void SetUserID(string userID)
- public override string ToString()

### public class UnityEngine.SocialPlatforms.Impl.UserProfile
- Interfaces: UnityEngine.SocialPlatforms.IUserProfile

#### Fields
- private static const string legacyIdObsoleteMessage
- private string m_gameID
- protected string m_ID
- protected UnityEngine.Texture2D m_Image
- protected bool m_IsFriend
- private string m_legacyID
- protected UnityEngine.SocialPlatforms.UserState m_State
- protected string m_UserName

#### Properties
- public string gameId { get; }
- public string id { get; }
- public UnityEngine.Texture2D image { get; }
- public bool isFriend { get; }
- public string legacyId { get; }
- public UnityEngine.SocialPlatforms.UserState state { get; }
- public string userName { get; }

#### Constructors
- public UserProfile()
- public UserProfile(string name, string id, bool friend)
- public UserProfile(string name, string id, bool friend, UnityEngine.SocialPlatforms.UserState state, UnityEngine.Texture2D image)
- public UserProfile(string name, string teamId, string gameId, bool friend, UnityEngine.SocialPlatforms.UserState state, UnityEngine.Texture2D image)

#### Methods
- public void SetImage(UnityEngine.Texture2D image)
- public void SetIsFriend(bool value)
- public void SetLegacyUserID(string id)
- public void SetState(UnityEngine.SocialPlatforms.UserState state)
- public void SetUserGameID(string id)
- public void SetUserID(string id)
- public void SetUserName(string name)
- public override string ToString()

