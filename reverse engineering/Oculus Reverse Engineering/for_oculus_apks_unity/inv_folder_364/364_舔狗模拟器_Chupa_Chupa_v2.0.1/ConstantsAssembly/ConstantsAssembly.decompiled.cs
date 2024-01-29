using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyVersion("0.0.0.0")]
public static class AddressableAssetLabel
{
	public const string PREFAB = "Prefab";
}
public static class AudioPath
{
	public const string BGM_BEFORE = "Audio/BGM/BGM_Before";

	public const string BGM_PLAYING1 = "Audio/BGM/BGM_Playing1";

	public const string BGM_PLAYING2 = "Audio/BGM/BGM_Playing2";

	public const string BGM_PLAYING3 = "Audio/BGM/BGM_Playing3";

	public const string BGM_PLAYING4 = "Audio/BGM/BGM_Playing4";

	public const string BGM_PLAYING5 = "Audio/BGM/BGM_Playing5";

	public const string BGM_PLAYING6 = "Audio/BGM/BGM_Playing6";

	public const string BGM_SETTING = "Audio/BGM/BGM_Setting";

	public const string SE_CHIME = "Audio/SE/SE_Chime";

	public const string SE_CLACKER = "Audio/SE/SE_Clacker";

	public const string SE_CLACKER_ONE = "Audio/SE/SE_ClackerOne";

	public const string SE_CLAP1 = "Audio/SE/SE_Clap1";

	public const string SE_CLAP2 = "Audio/SE/SE_Clap2";

	public const string SE_CLAP3 = "Audio/SE/SE_Clap3";

	public const string SE_CLAP4 = "Audio/SE/SE_Clap4";

	public const string SE_CLOCK1 = "Audio/SE/SE_Clock1";

	public const string SE_CLOCK2 = "Audio/SE/SE_Clock2";

	public const string SE_CLOSE_CLOCK = "Audio/SE/SE_CloseClock";

	public const string SE_CLOSE_LOCKER = "Audio/SE/SE_CloseLocker";

	public const string SE_CLOSE_SHELF_DOOR = "Audio/SE/SE_CloseShelfDoor";

	public const string SE_COMBO_ELECTRICAL = "Audio/SE/SE_ComboElectrical";

	public const string SE_COUNT_DOWN_SCORE = "Audio/SE/SE_CountDownScore";

	public const string SE_COUNT_UP_SCORE = "Audio/SE/SE_CountUpScore";

	public const string SE_CURSE = "Audio/SE/SE_Curse";

	public const string SE_DISCOVER = "Audio/SE/SE_Discover";

	public const string SE_ELECTRIFICATION = "Audio/SE/SE_Electrification";

	public const string SE_FEVER = "Audio/SE/SE_Fever";

	public const string SE_FLY_HOLD = "Audio/SE/SE_FlyHold";

	public const string SE_FOOT_STEP1 = "Audio/SE/SE_FootStep1";

	public const string SE_FOOT_STEP2 = "Audio/SE/SE_FootStep2";

	public const string SE_FOOT_STEP3 = "Audio/SE/SE_FootStep3";

	public const string SE_FOOT_STEP4 = "Audio/SE/SE_FootStep4";

	public const string SE_FOOT_STEP5 = "Audio/SE/SE_FootStep5";

	public const string SE_FOOT_STEP6 = "Audio/SE/SE_FootStep6";

	public const string SE_FOOT_STEP7 = "Audio/SE/SE_FootStep7";

	public const string SE_FOOT_STEP8 = "Audio/SE/SE_FootStep8";

	public const string SE_GAUGE = "Audio/SE/SE_Gauge";

	public const string SE_HEART = "Audio/SE/SE_Heart";

	public const string SE_HEART_BEAT = "Audio/SE/SE_HeartBeat";

	public const string SE_HIDE_SMART_PHONE_TEXT = "Audio/SE/SE_HideSmartPhoneText";

	public const string SE_HIT_CHEST = "Audio/SE/SE_HitChest";

	public const string SE_HIT_SLAP = "Audio/SE/SE_HitSlap";

	public const string SE_JUMP = "Audio/SE/SE_Jump";

	public const string SE_KAN_KIKUCHI_VOICE = "Audio/SE/SE_KanKikuchiVoice";

	public const string SE_KO = "Audio/SE/SE_KO";

	public const string SE_LANDING = "Audio/SE/SE_Landing";

	public const string SE_LANDING_SHORT = "Audio/SE/SE_LandingShort";

	public const string SE_LICKE_FEVER_EFFECT = "Audio/SE/SE_LickeFeverEffect";

	public const string SE_LICK_MINUS = "Audio/SE/SE_lickMinus";

	public const string SE_LICK_PLUS = "Audio/SE/SE_lickPlus";

	public const string SE_MICROWAVE_CHIN = "Audio/SE/SE_MicrowaveChin";

	public const string SE_MICROWAVE_CLOSE = "Audio/SE/SE_MicrowaveClose";

	public const string SE_MICROWAVE_OPEN = "Audio/SE/SE_MicrowaveOpen";

	public const string SE_MISS = "Audio/SE/SE_Miss";

	public const string SE_OPEN_CLOCK = "Audio/SE/SE_OpenClock";

	public const string SE_OPEN_LOCKER = "Audio/SE/SE_OpenLocker";

	public const string SE_OPEN_SHELF_DOOR = "Audio/SE/SE_OpenShelfDoor";

	public const string SE_POPUP_SPEECH_BUBBLE = "Audio/SE/SE_PopupSpeechBubble";

	public const string SE_RETURN_SMART_PHONE = "Audio/SE/SE_ReturnSmartPhone";

	public const string SE_RETURN_TIME = "Audio/SE/SE_ReturnTime";

	public const string SE_SELECT_MENU = "Audio/SE/SE_SelectMenu";

	public const string SE_SHOW_ANSWER = "Audio/SE/SE_ShowAnswer";

	public const string SE_SHOW_SMART_PHONE_TEXT = "Audio/SE/SE_ShowSmartPhoneText";

	public const string SE_SPAWN_BAG_ITEM = "Audio/SE/SE_SpawnBagItem";

	public const string SE_SPAWN_SPECIAL_ITEM = "Audio/SE/SE_SpawnSpecialItem";

	public const string SE_SUCCESS = "Audio/SE/SE_Success";

	public const string SE_SWING_SLAP = "Audio/SE/SE_SwingSlap";

	public const string SE_THUNDER = "Audio/SE/SE_Thunder";

	public const string SE_TIME_RESUME_EFFECT = "Audio/SE/SE_TimeResumeEffect";

	public const string SE_TIME_STOP_EFFECT = "Audio/SE/SE_TimeStopEffect";

	public const string SE_TRANSFORM = "Audio/SE/SE_Transform";

	public const string SE_WING = "Audio/SE/SE_Wing";
}
public static class DefineValue
{
}
public static class LayerMaskNo
{
	public const int DEFAULT = 1;

	public const int EYE_WALL = 131072;

	public const int GIRL_CLAP_HAND = 524288;

	public const int HAND = 512;

	public const int IGNORE_RAYCAST = 4;

	public const int IGNORE_HAND = 1024;

	public const int INSTRUCTION_UI = 262144;

	public const int ONLY_HAND = 2048;

	public const int OUTER_FRAME = 8192;

	public const int POST_PROCESSING = 256;

	public const int SLAP = 16384;

	public const int SLAP_TARGET = 32768;

	public const int STEREO_RENDER_IGNORE = 65536;

	public const int TELEPORT_AREA = 4096;

	public const int TRANSPARENT_FX = 2;

	public const int UI = 32;

	public const int WATER = 16;
}
public static class LayerNo
{
	public const int DEFAULT = 0;

	public const int EYE_WALL = 17;

	public const int GIRL_CLAP_HAND = 19;

	public const int HAND = 9;

	public const int IGNORE_RAYCAST = 2;

	public const int IGNORE_HAND = 10;

	public const int INSTRUCTION_UI = 18;

	public const int ONLY_HAND = 11;

	public const int OUTER_FRAME = 13;

	public const int POST_PROCESSING = 8;

	public const int SLAP = 14;

	public const int SLAP_TARGET = 15;

	public const int STEREO_RENDER_IGNORE = 16;

	public const int TELEPORT_AREA = 12;

	public const int TRANSPARENT_FX = 1;

	public const int UI = 5;

	public const int WATER = 4;
}
public enum LickableObjectType
{
	Attendancebook,
	BabyBottle,
	BlackboardEraser,
	BlackboardEraserCleaner,
	Book1,
	Book2,
	Bra,
	Broom,
	Burma,
	Candy,
	Catfish,
	ChalkBlue,
	ChalkPink,
	ChalkRainbow,
	ChalkWhite,
	ChalkYellow,
	ChocoBanana,
	Choker,
	Compass,
	Cutter,
	Dictionary1,
	Dictionary2,
	Dustpan,
	Eraser,
	EyeShadowPalette,
	FlutterBoard,
	Fork,
	Girl,
	GirlDrink,
	GirlSchoolBag,
	GirlSmartPhone,
	Glasses,
	HeadPhone,
	HiddenCamera,
	Ice,
	Ingot,
	KanCrow,
	Lip,
	Loafer,
	Lucky,
	LuckyBox,
	LunchBox,
	Mask,
	Money,
	Panty,
	Pen,
	Pillow,
	Pointer,
	Projector,
	Protractor,
	Recorder,
	RemoteControler,
	RoseBlack,
	RoseBlue,
	RoseRed,
	RulerSquare1,
	SamuraiSoccer,
	ScreenHook,
	Shirt,
	ShoesL,
	ShoesR,
	Spoon,
	SwimCap,
	SwimSuitBoy,
	SwimSuitGirl,
	Taionkei,
	TapiocaTea,
	TapiocaTeaRainbow,
	TimeStopClock,
	Toast,
	ToothBrush,
	TopBox,
	TransparentTube,
	Uchiwa,
	Umbrella,
	Usachan,
	Whip
}
public static class LocalizedTextKey
{
	public const string ACHIEVEMENT = "Achievement";

	public const string ACHIEVEMENT_TITLE_TEXT = "AchievementTitleText";

	public const string BAG_CONTENTS_DESCRIPTION = "BagContentsDescription";

	public const string BAG_CONTENTS_TITLE = "BagContentsTitle";

	public const string BGMSETTING_TITLE = "BGMSettingTitle";

	public const string CHALK_RAINBOW_DESCRIPTION = "ChalkRainbowDescription";

	public const string CHALK_RAINBOW_TITLE = "ChalkRainbowTitle";

	public const string CHARACTER_SETTING_TITLE = "CharacterSettingTitle";

	public const string CHOKER_MIRROR_DESCRIPTION = "ChokerMirrorDescription";

	public const string CHOKER_MIRROR_TITLE = "ChokerMirrorTitle";

	public const string CLOTHES_SETTING_TITLE = "ClothesSettingTitle";

	public const string COMBO = "Combo";

	public const string COMBO_BONUS = "ComboBonus";

	public const string CRITICAL_BONUS = "CriticalBonus";

	public const string DISTANCE_BONUS = "DistanceBonus";

	public const string DLCINVALID_MESSAGE = "DLCInvalidMessage";

	public const string DLCNAME = "DLCName";

	public const string FEVER_BONUS = "FeverBonus";

	public const string FIRST_FEVER_DESCRIPTION = "FirstFeverDescription";

	public const string FIRST_FEVER_TITLE = "FirstFeverTitle";

	public const string FIRST_INGOT_DESCRIPTION = "FirstIngotDescription";

	public const string FIRST_INGOT_TITLE = "FirstIngotTitle";

	public const string FIRST_LICK_DESCRIPTION = "FirstLickDescription";

	public const string FIRST_LICKED_GIRL_GAME_OVER_DESCRIPTION = "FirstLickedGirlGameOverDescription";

	public const string FIRST_LICKED_GIRL_GAME_OVER_TITLE = "FirstLickedGirlGameOverTitle";

	public const string FIRST_LICKED_GIRL_SUCCESS_DESCRIPTION = "FirstLickedGirlSuccessDescription";

	public const string FIRST_LICKED_GIRL_SUCCESS_TITLE = "FirstLickedGirlSuccessTitle";

	public const string FIRST_LICK_TITLE = "FirstLickTitle";

	public const string FIRST_MONEY_DESCRIPTION = "FirstMoneyDescription";

	public const string FIRST_MONEY_TITLE = "FirstMoneyTitle";

	public const string FIRST_SPECIAL_ITEM_DESCRIPTION = "FirstSpecialItemDescription";

	public const string FIRST_SPECIAL_ITEM_TITLE = "FirstSpecialItemTitle";

	public const string FIRST_STOLE_GAME_OVER_DESCRIPTION = "FirstStoleGameOverDescription";

	public const string FIRST_STOLE_GAME_OVER_TITLE = "FirstStoleGameOverTitle";

	public const string FIRST_STOP_TIME_DESCRIPTION = "FirstStopTimeDescription";

	public const string FIRST_STOP_TIME_TITLE = "FirstStopTimeTitle";

	public const string FIRST_STRIKE_DESCRIPTION = "FirstStrikeDescription";

	public const string FIRST_STRIKE_TITLE = "FirstStrikeTitle";

	public const string FIRST_TIME_UP_DESCRIPTION = "FirstTimeUpDescription";

	public const string FIRST_TIME_UP_TITLE = "FirstTimeUpTitle";

	public const string FIRST_TRANSPARENT_DESCRIPTION = "FirstTransparentDescription";

	public const string FIRST_TRANSPARENT_TITLE = "FirstTransparentTitle";

	public const string GIRL_BONUS = "GirlBonus";

	public const string GOLD_BONUS = "GoldBonus";

	public const string HIDDEN_CAMERA_DESCRIPTION = "HiddenCameraDescription";

	public const string HIDDEN_CAMERA_TITLE = "HiddenCameraTitle";

	public const string HIGH_SCORE_TEXT = "HighScoreText";

	public const string HINT_INFO1 = "HintInfo1";

	public const string HINT_INFO10 = "HintInfo10";

	public const string HINT_INFO11 = "HintInfo11";

	public const string HINT_INFO12 = "HintInfo12";

	public const string HINT_INFO13 = "HintInfo13";

	public const string HINT_INFO14 = "HintInfo14";

	public const string HINT_INFO15 = "HintInfo15";

	public const string HINT_INFO16 = "HintInfo16";

	public const string HINT_INFO17 = "HintInfo17";

	public const string HINT_INFO18 = "HintInfo18";

	public const string HINT_INFO19 = "HintInfo19";

	public const string HINT_INFO2 = "HintInfo2";

	public const string HINT_INFO20 = "HintInfo20";

	public const string HINT_INFO3 = "HintInfo3";

	public const string HINT_INFO4 = "HintInfo4";

	public const string HINT_INFO5 = "HintInfo5";

	public const string HINT_INFO6 = "HintInfo6";

	public const string HINT_INFO7 = "HintInfo7";

	public const string HINT_INFO8 = "HintInfo8";

	public const string HINT_INFO9 = "HintInfo9";

	public const string HINT_KILL_CAT_FISH = "HintKillCatFish";

	public const string HINT_TITLE = "HintTitle";

	public const string KAN_CROW_DESCRIPTION = "KanCrowDescription";

	public const string KAN_CROW_TITLE = "KanCrowTitle";

	public const string KILL_CAT_FISH_DESCRIPTION = "KillCatFishDescription";

	public const string KILL_CAT_FISH_TITLE = "KillCatFishTitle";

	public const string LANGUAGE = "Language";

	public const string LANGUAGE_SETTING_TITLE = "LanguageSettingTitle";

	public const string LICKED_COUNT1_DESCRIPTION = "LickedCount1Description";

	public const string LICKED_COUNT1_TITLE = "LickedCount1Title";

	public const string LICKED_COUNT2_DESCRIPTION = "LickedCount2Description";

	public const string LICKED_COUNT2_TITLE = "LickedCount2Title";

	public const string LICKED_COUNT3_DESCRIPTION = "LickedCount3Description";

	public const string LICKED_COUNT3_TITLE = "LickedCount3Title";

	public const string LICKED_COUNT4_DESCRIPTION = "LickedCount4Description";

	public const string LICKED_COUNT4_TITLE = "LickedCount4Title";

	public const string LICKED_COUNT5_DESCRIPTION = "LickedCount5Description";

	public const string LICKED_COUNT5_TITLE = "LickedCount5Title";

	public const string LICKED_COUNT6_DESCRIPTION = "LickedCount6Description";

	public const string LICKED_COUNT6_TITLE = "LickedCount6Title";

	public const string LICKED_OBJECT_TITLE_TEXT = "LickedObjectTitleText";

	public const string LICKED_TYPES1_DESCRIPTION = "LickedTypes1Description";

	public const string LICKED_TYPES1_TITLE = "LickedTypes1Title";

	public const string LICKED_TYPES2_DESCRIPTION = "LickedTypes2Description";

	public const string LICKED_TYPES2_TITLE = "LickedTypes2Title";

	public const string LICKED_TYPES3_DESCRIPTION = "LickedTypes3Description";

	public const string LICKED_TYPES3_TITLE = "LickedTypes3Title";

	public const string LICKED_TYPES4_DESCRIPTION = "LickedTypes4Description";

	public const string LICKED_TYPES4_TITLE = "LickedTypes4Title";

	public const string LICKED_TYPES5_DESCRIPTION = "LickedTypes5Description";

	public const string LICKED_TYPES5_TITLE = "LickedTypes5Title";

	public const string LICKED_TYPES6_DESCRIPTION = "LickedTypes6Description";

	public const string LICKED_TYPES6_TITLE = "LickedTypes6Title";

	public const string MONEY_BONUS = "MoneyBonus";

	public const string MY_RANKING_TEXT = "MyRankingText";

	public const string NEW_RECORD = "NewRecord";

	public const string OPERATION_SETTING_TITLE = "OperationSettingTitle";

	public const string PLACE_SETTING_TITLE = "PlaceSettingTitle";

	public const string POINT1_DESCRIPTION = "Point1Description";

	public const string POINT1_TITLE = "Point1Title";

	public const string POINT2_DESCRIPTION = "Point2Description";

	public const string POINT2_TITLE = "Point2Title";

	public const string POINT3_DESCRIPTION = "Point3Description";

	public const string POINT3_TITLE = "Point3Title";

	public const string POINT4_DESCRIPTION = "Point4Description";

	public const string POINT4_TITLE = "Point4Title";

	public const string POINT5_DESCRIPTION = "Point5Description";

	public const string POINT5_TITLE = "Point5Title";

	public const string POINT6_DESCRIPTION = "Point6Description";

	public const string POINT6_TITLE = "Point6Title";

	public const string RANKING_TITLE_TEXT = "RankingTitleText";

	public const string ROTATION = "Rotation";

	public const string SERIF_ACTION1 = "SerifAction1";

	public const string SERIF_ACTION1_BOY = "SerifAction1_Boy";

	public const string SERIF_ACTION10 = "SerifAction10";

	public const string SERIF_ACTION10_BOY = "SerifAction10_Boy";

	public const string SERIF_ACTION2 = "SerifAction2";

	public const string SERIF_ACTION2_BOY = "SerifAction2_Boy";

	public const string SERIF_ACTION3 = "SerifAction3";

	public const string SERIF_ACTION3_BOY = "SerifAction3_Boy";

	public const string SERIF_ACTION4 = "SerifAction4";

	public const string SERIF_ACTION4_BOY = "SerifAction4_Boy";

	public const string SERIF_ACTION5 = "SerifAction5";

	public const string SERIF_ACTION5_BOY = "SerifAction5_Boy";

	public const string SERIF_ACTION6 = "SerifAction6";

	public const string SERIF_ACTION6_BOY = "SerifAction6_Boy";

	public const string SERIF_ACTION7 = "SerifAction7";

	public const string SERIF_ACTION7_BOY = "SerifAction7_Boy";

	public const string SERIF_ACTION8 = "SerifAction8";

	public const string SERIF_ACTION8_BOY = "SerifAction8_Boy";

	public const string SERIF_ACTION9 = "SerifAction9";

	public const string SERIF_ACTION9_BOY = "SerifAction9_Boy";

	public const string SERIF_FOUND_GAME_OVER_HIGH_SCORE1 = "SerifFoundGameOverHighScore1";

	public const string SERIF_FOUND_GAME_OVER_HIGH_SCORE1_BOY = "SerifFoundGameOverHighScore1_Boy";

	public const string SERIF_FOUND_GAME_OVER_HIGH_SCORE2 = "SerifFoundGameOverHighScore2";

	public const string SERIF_FOUND_GAME_OVER_HIGH_SCORE2_BOY = "SerifFoundGameOverHighScore2_Boy";

	public const string SERIF_FOUND_GAME_OVER_HIGH_SCORE3 = "SerifFoundGameOverHighScore3";

	public const string SERIF_FOUND_GAME_OVER_HIGH_SCORE3_BOY = "SerifFoundGameOverHighScore3_Boy";

	public const string SERIF_FOUND_GAME_OVER_HIGH_SCORE4 = "SerifFoundGameOverHighScore4";

	public const string SERIF_FOUND_GAME_OVER_HIGH_SCORE4_BOY = "SerifFoundGameOverHighScore4_Boy";

	public const string SERIF_FOUND_GAME_OVER_HIGH_SCORE5 = "SerifFoundGameOverHighScore5";

	public const string SERIF_FOUND_GAME_OVER_HIGH_SCORE5_BOY = "SerifFoundGameOverHighScore5_Boy";

	public const string SERIF_FOUND_GAME_OVER_LOW_SCORE1 = "SerifFoundGameOverLowScore1";

	public const string SERIF_FOUND_GAME_OVER_LOW_SCORE1_BOY = "SerifFoundGameOverLowScore1_Boy";

	public const string SERIF_FOUND_GAME_OVER_LOW_SCORE2 = "SerifFoundGameOverLowScore2";

	public const string SERIF_FOUND_GAME_OVER_LOW_SCORE2_BOY = "SerifFoundGameOverLowScore2_Boy";

	public const string SERIF_FOUND_GAME_OVER_LOW_SCORE3 = "SerifFoundGameOverLowScore3";

	public const string SERIF_FOUND_GAME_OVER_LOW_SCORE3_BOY = "SerifFoundGameOverLowScore3_Boy";

	public const string SERIF_FOUND_GAME_OVER_LOW_SCORE4 = "SerifFoundGameOverLowScore4";

	public const string SERIF_FOUND_GAME_OVER_LOW_SCORE4_BOY = "SerifFoundGameOverLowScore4_Boy";

	public const string SERIF_FOUND_GAME_OVER_LOW_SCORE5 = "SerifFoundGameOverLowScore5";

	public const string SERIF_FOUND_GAME_OVER_LOW_SCORE5_BOY = "SerifFoundGameOverLowScore5_Boy";

	public const string SERIF_FOUND_GAME_OVER_QUITE_HIGH_SCORE1 = "SerifFoundGameOverQuiteHighScore1";

	public const string SERIF_FOUND_GAME_OVER_QUITE_HIGH_SCORE1_BOY = "SerifFoundGameOverQuiteHighScore1_Boy";

	public const string SERIF_FOUND_GAME_OVER_QUITE_HIGH_SCORE2 = "SerifFoundGameOverQuiteHighScore2";

	public const string SERIF_FOUND_GAME_OVER_QUITE_HIGH_SCORE2_BOY = "SerifFoundGameOverQuiteHighScore2_Boy";

	public const string SERIF_FOUND_GAME_OVER_QUITE_HIGH_SCORE3 = "SerifFoundGameOverQuiteHighScore3";

	public const string SERIF_FOUND_GAME_OVER_QUITE_HIGH_SCORE3_BOY = "SerifFoundGameOverQuiteHighScore3_Boy";

	public const string SERIF_FOUND_GAME_OVER_QUITE_HIGH_SCORE4 = "SerifFoundGameOverQuiteHighScore4";

	public const string SERIF_FOUND_GAME_OVER_QUITE_HIGH_SCORE4_BOY = "SerifFoundGameOverQuiteHighScore4_Boy";

	public const string SERIF_FOUND_GAME_OVER_QUITE_HIGH_SCORE5 = "SerifFoundGameOverQuiteHighScore5";

	public const string SERIF_FOUND_GAME_OVER_QUITE_HIGH_SCORE5_BOY = "SerifFoundGameOverQuiteHighScore5_Boy";

	public const string SERIF_FOUND_GAME_OVER_QUITE_LOW_SCORE1 = "SerifFoundGameOverQuiteLowScore1";

	public const string SERIF_FOUND_GAME_OVER_QUITE_LOW_SCORE1_BOY = "SerifFoundGameOverQuiteLowScore1_Boy";

	public const string SERIF_FOUND_GAME_OVER_QUITE_LOW_SCORE2 = "SerifFoundGameOverQuiteLowScore2";

	public const string SERIF_FOUND_GAME_OVER_QUITE_LOW_SCORE2_BOY = "SerifFoundGameOverQuiteLowScore2_Boy";

	public const string SERIF_FOUND_GAME_OVER_QUITE_LOW_SCORE3 = "SerifFoundGameOverQuiteLowScore3";

	public const string SERIF_FOUND_GAME_OVER_QUITE_LOW_SCORE3_BOY = "SerifFoundGameOverQuiteLowScore3_Boy";

	public const string SERIF_FOUND_GAME_OVER_QUITE_LOW_SCORE4 = "SerifFoundGameOverQuiteLowScore4";

	public const string SERIF_FOUND_GAME_OVER_QUITE_LOW_SCORE4_BOY = "SerifFoundGameOverQuiteLowScore4_Boy";

	public const string SERIF_FOUND_GAME_OVER_QUITE_LOW_SCORE5 = "SerifFoundGameOverQuiteLowScore5";

	public const string SERIF_FOUND_GAME_OVER_QUITE_LOW_SCORE5_BOY = "SerifFoundGameOverQuiteLowScore5_Boy";

	public const string SERIF_LICKED_GIRL_GAME_OVER1 = "SerifLickedGirlGameOver1";

	public const string SERIF_LICKED_GIRL_GAME_OVER1_BOY = "SerifLickedGirlGameOver1_Boy";

	public const string SERIF_LICKED_GIRL_GAME_OVER10 = "SerifLickedGirlGameOver10";

	public const string SERIF_LICKED_GIRL_GAME_OVER10_BOY = "SerifLickedGirlGameOver10_Boy";

	public const string SERIF_LICKED_GIRL_GAME_OVER2 = "SerifLickedGirlGameOver2";

	public const string SERIF_LICKED_GIRL_GAME_OVER2_BOY = "SerifLickedGirlGameOver2_Boy";

	public const string SERIF_LICKED_GIRL_GAME_OVER3 = "SerifLickedGirlGameOver3";

	public const string SERIF_LICKED_GIRL_GAME_OVER3_BOY = "SerifLickedGirlGameOver3_Boy";

	public const string SERIF_LICKED_GIRL_GAME_OVER4 = "SerifLickedGirlGameOver4";

	public const string SERIF_LICKED_GIRL_GAME_OVER4_BOY = "SerifLickedGirlGameOver4_Boy";

	public const string SERIF_LICKED_GIRL_GAME_OVER5 = "SerifLickedGirlGameOver5";

	public const string SERIF_LICKED_GIRL_GAME_OVER5_BOY = "SerifLickedGirlGameOver5_Boy";

	public const string SERIF_LICKED_GIRL_GAME_OVER6 = "SerifLickedGirlGameOver6";

	public const string SERIF_LICKED_GIRL_GAME_OVER6_BOY = "SerifLickedGirlGameOver6_Boy";

	public const string SERIF_LICKED_GIRL_GAME_OVER7 = "SerifLickedGirlGameOver7";

	public const string SERIF_LICKED_GIRL_GAME_OVER7_BOY = "SerifLickedGirlGameOver7_Boy";

	public const string SERIF_LICKED_GIRL_GAME_OVER8 = "SerifLickedGirlGameOver8";

	public const string SERIF_LICKED_GIRL_GAME_OVER8_BOY = "SerifLickedGirlGameOver8_Boy";

	public const string SERIF_LICKED_GIRL_GAME_OVER9 = "SerifLickedGirlGameOver9";

	public const string SERIF_LICKED_GIRL_GAME_OVER9_BOY = "SerifLickedGirlGameOver9_Boy";

	public const string SERIF_START_GAME1 = "SerifStartGame1";

	public const string SERIF_START_GAME1_BOY = "SerifStartGame1_Boy";

	public const string SERIF_START_GAME10 = "SerifStartGame10";

	public const string SERIF_START_GAME10_BOY = "SerifStartGame10_Boy";

	public const string SERIF_START_GAME2 = "SerifStartGame2";

	public const string SERIF_START_GAME2_BOY = "SerifStartGame2_Boy";

	public const string SERIF_START_GAME3 = "SerifStartGame3";

	public const string SERIF_START_GAME3_BOY = "SerifStartGame3_Boy";

	public const string SERIF_START_GAME4 = "SerifStartGame4";

	public const string SERIF_START_GAME4_BOY = "SerifStartGame4_Boy";

	public const string SERIF_START_GAME5 = "SerifStartGame5";

	public const string SERIF_START_GAME5_BOY = "SerifStartGame5_Boy";

	public const string SERIF_START_GAME6 = "SerifStartGame6";

	public const string SERIF_START_GAME6_BOY = "SerifStartGame6_Boy";

	public const string SERIF_START_GAME7 = "SerifStartGame7";

	public const string SERIF_START_GAME7_BOY = "SerifStartGame7_Boy";

	public const string SERIF_START_GAME8 = "SerifStartGame8";

	public const string SERIF_START_GAME8_BOY = "SerifStartGame8_Boy";

	public const string SERIF_START_GAME9 = "SerifStartGame9";

	public const string SERIF_START_GAME9_BOY = "SerifStartGame9_Boy";

	public const string SERIF_STOLE_GAME_OVER1 = "SerifStoleGameOver1";

	public const string SERIF_STOLE_GAME_OVER1_BOY = "SerifStoleGameOver1_Boy";

	public const string SERIF_STOLE_GAME_OVER10 = "SerifStoleGameOver10";

	public const string SERIF_STOLE_GAME_OVER10_BOY = "SerifStoleGameOver10_Boy";

	public const string SERIF_STOLE_GAME_OVER2 = "SerifStoleGameOver2";

	public const string SERIF_STOLE_GAME_OVER2_BOY = "SerifStoleGameOver2_Boy";

	public const string SERIF_STOLE_GAME_OVER3 = "SerifStoleGameOver3";

	public const string SERIF_STOLE_GAME_OVER3_BOY = "SerifStoleGameOver3_Boy";

	public const string SERIF_STOLE_GAME_OVER4 = "SerifStoleGameOver4";

	public const string SERIF_STOLE_GAME_OVER4_BOY = "SerifStoleGameOver4_Boy";

	public const string SERIF_STOLE_GAME_OVER5 = "SerifStoleGameOver5";

	public const string SERIF_STOLE_GAME_OVER5_BOY = "SerifStoleGameOver5_Boy";

	public const string SERIF_STOLE_GAME_OVER6 = "SerifStoleGameOver6";

	public const string SERIF_STOLE_GAME_OVER6_BOY = "SerifStoleGameOver6_Boy";

	public const string SERIF_STOLE_GAME_OVER7 = "SerifStoleGameOver7";

	public const string SERIF_STOLE_GAME_OVER7_BOY = "SerifStoleGameOver7_Boy";

	public const string SERIF_STOLE_GAME_OVER8 = "SerifStoleGameOver8";

	public const string SERIF_STOLE_GAME_OVER8_BOY = "SerifStoleGameOver8_Boy";

	public const string SERIF_STOLE_GAME_OVER9 = "SerifStoleGameOver9";

	public const string SERIF_STOLE_GAME_OVER9_BOY = "SerifStoleGameOver9_Boy";

	public const string SERIF_SURPRISE1 = "SerifSurprise1";

	public const string SERIF_SURPRISE1_BOY = "SerifSurprise1_Boy";

	public const string SERIF_SURPRISE10 = "SerifSurprise10";

	public const string SERIF_SURPRISE10_BOY = "SerifSurprise10_Boy";

	public const string SERIF_SURPRISE2 = "SerifSurprise2";

	public const string SERIF_SURPRISE2_BOY = "SerifSurprise2_Boy";

	public const string SERIF_SURPRISE3 = "SerifSurprise3";

	public const string SERIF_SURPRISE3_BOY = "SerifSurprise3_Boy";

	public const string SERIF_SURPRISE4 = "SerifSurprise4";

	public const string SERIF_SURPRISE4_BOY = "SerifSurprise4_Boy";

	public const string SERIF_SURPRISE5 = "SerifSurprise5";

	public const string SERIF_SURPRISE5_BOY = "SerifSurprise5_Boy";

	public const string SERIF_SURPRISE6 = "SerifSurprise6";

	public const string SERIF_SURPRISE6_BOY = "SerifSurprise6_Boy";

	public const string SERIF_SURPRISE7 = "SerifSurprise7";

	public const string SERIF_SURPRISE7_BOY = "SerifSurprise7_Boy";

	public const string SERIF_SURPRISE8 = "SerifSurprise8";

	public const string SERIF_SURPRISE8_BOY = "SerifSurprise8_Boy";

	public const string SERIF_SURPRISE9 = "SerifSurprise9";

	public const string SERIF_SURPRISE9_BOY = "SerifSurprise9_Boy";

	public const string SERIF_TIME_UP_GAME_OVER_HIGH_SCORE1 = "SerifTimeUpGameOverHighScore1";

	public const string SERIF_TIME_UP_GAME_OVER_HIGH_SCORE1_BOY = "SerifTimeUpGameOverHighScore1_Boy";

	public const string SERIF_TIME_UP_GAME_OVER_HIGH_SCORE2 = "SerifTimeUpGameOverHighScore2";

	public const string SERIF_TIME_UP_GAME_OVER_HIGH_SCORE2_BOY = "SerifTimeUpGameOverHighScore2_Boy";

	public const string SERIF_TIME_UP_GAME_OVER_HIGH_SCORE3 = "SerifTimeUpGameOverHighScore3";

	public const string SERIF_TIME_UP_GAME_OVER_HIGH_SCORE3_BOY = "SerifTimeUpGameOverHighScore3_Boy";

	public const string SERIF_TIME_UP_GAME_OVER_HIGH_SCORE4 = "SerifTimeUpGameOverHighScore4";

	public const string SERIF_TIME_UP_GAME_OVER_HIGH_SCORE4_BOY = "SerifTimeUpGameOverHighScore4_Boy";

	public const string SERIF_TIME_UP_GAME_OVER_HIGH_SCORE5 = "SerifTimeUpGameOverHighScore5";

	public const string SERIF_TIME_UP_GAME_OVER_HIGH_SCORE5_BOY = "SerifTimeUpGameOverHighScore5_Boy";

	public const string SERIF_TIME_UP_GAME_OVER_LOW_SCORE1 = "SerifTimeUpGameOverLowScore1";

	public const string SERIF_TIME_UP_GAME_OVER_LOW_SCORE1_BOY = "SerifTimeUpGameOverLowScore1_Boy";

	public const string SERIF_TIME_UP_GAME_OVER_LOW_SCORE2 = "SerifTimeUpGameOverLowScore2";

	public const string SERIF_TIME_UP_GAME_OVER_LOW_SCORE2_BOY = "SerifTimeUpGameOverLowScore2_Boy";

	public const string SERIF_TIME_UP_GAME_OVER_LOW_SCORE3 = "SerifTimeUpGameOverLowScore3";

	public const string SERIF_TIME_UP_GAME_OVER_LOW_SCORE3_BOY = "SerifTimeUpGameOverLowScore3_Boy";

	public const string SERIF_TIME_UP_GAME_OVER_LOW_SCORE4 = "SerifTimeUpGameOverLowScore4";

	public const string SERIF_TIME_UP_GAME_OVER_LOW_SCORE4_BOY = "SerifTimeUpGameOverLowScore4_Boy";

	public const string SERIF_TIME_UP_GAME_OVER_LOW_SCORE5 = "SerifTimeUpGameOverLowScore5";

	public const string SERIF_TIME_UP_GAME_OVER_LOW_SCORE5_BOY = "SerifTimeUpGameOverLowScore5_Boy";

	public const string SERIF_TIME_UP_GAME_OVER_QUITE_HIGH_SCORE1 = "SerifTimeUpGameOverQuiteHighScore1";

	public const string SERIF_TIME_UP_GAME_OVER_QUITE_HIGH_SCORE1_BOY = "SerifTimeUpGameOverQuiteHighScore1_Boy";

	public const string SERIF_TIME_UP_GAME_OVER_QUITE_HIGH_SCORE2 = "SerifTimeUpGameOverQuiteHighScore2";

	public const string SERIF_TIME_UP_GAME_OVER_QUITE_HIGH_SCORE2_BOY = "SerifTimeUpGameOverQuiteHighScore2_Boy";

	public const string SERIF_TIME_UP_GAME_OVER_QUITE_HIGH_SCORE3 = "SerifTimeUpGameOverQuiteHighScore3";

	public const string SERIF_TIME_UP_GAME_OVER_QUITE_HIGH_SCORE3_BOY = "SerifTimeUpGameOverQuiteHighScore3_Boy";

	public const string SERIF_TIME_UP_GAME_OVER_QUITE_HIGH_SCORE4 = "SerifTimeUpGameOverQuiteHighScore4";

	public const string SERIF_TIME_UP_GAME_OVER_QUITE_HIGH_SCORE4_BOY = "SerifTimeUpGameOverQuiteHighScore4_Boy";

	public const string SERIF_TIME_UP_GAME_OVER_QUITE_HIGH_SCORE5 = "SerifTimeUpGameOverQuiteHighScore5";

	public const string SERIF_TIME_UP_GAME_OVER_QUITE_HIGH_SCORE5_BOY = "SerifTimeUpGameOverQuiteHighScore5_Boy";

	public const string SERIF_TIME_UP_GAME_OVER_QUITE_LOW_SCORE1 = "SerifTimeUpGameOverQuiteLowScore1";

	public const string SERIF_TIME_UP_GAME_OVER_QUITE_LOW_SCORE1_BOY = "SerifTimeUpGameOverQuiteLowScore1_Boy";

	public const string SERIF_TIME_UP_GAME_OVER_QUITE_LOW_SCORE2 = "SerifTimeUpGameOverQuiteLowScore2";

	public const string SERIF_TIME_UP_GAME_OVER_QUITE_LOW_SCORE2_BOY = "SerifTimeUpGameOverQuiteLowScore2_Boy";

	public const string SERIF_TIME_UP_GAME_OVER_QUITE_LOW_SCORE3 = "SerifTimeUpGameOverQuiteLowScore3";

	public const string SERIF_TIME_UP_GAME_OVER_QUITE_LOW_SCORE3_BOY = "SerifTimeUpGameOverQuiteLowScore3_Boy";

	public const string SERIF_TIME_UP_GAME_OVER_QUITE_LOW_SCORE4 = "SerifTimeUpGameOverQuiteLowScore4";

	public const string SERIF_TIME_UP_GAME_OVER_QUITE_LOW_SCORE4_BOY = "SerifTimeUpGameOverQuiteLowScore4_Boy";

	public const string SERIF_TIME_UP_GAME_OVER_QUITE_LOW_SCORE5 = "SerifTimeUpGameOverQuiteLowScore5";

	public const string SERIF_TIME_UP_GAME_OVER_QUITE_LOW_SCORE5_BOY = "SerifTimeUpGameOverQuiteLowScore5_Boy";

	public const string SETTING_SCENE_MESSAGE = "SettingSceneMessage";

	public const string TIME_BACK = "TimeBack";

	public const string TITLE_NOTE = "TitleNote";

	public const string TO_MAIN = "ToMain";

	public const string TOP_RANKING_TEXT = "TopRankingText";

	public const string TO_SETTING = "ToSetting";

	public const string TOTAL_SCORE_TEXT = "TotalScoreText";

	public const string UNPURCHASED = "Unpurchased";

	public const string UP_DOWN = "UpDown";

	public const string VOLUME_BGM = "VolumeBGM";

	public const string VOLUME_ETC = "VolumeEtc";

	public const string VOLUME_FOOT_STEP = "VolumeFootStep";

	public const string VOLUME_HEART_BEAT = "VolumeHeartBeat";

	public const string VOLUME_SETTING_TITLE = "VolumeSettingTitle";

	public const string VOLUME_VOICE = "VolumeVoice";
}
public static class PlayerSettingsValue
{
	public const string BUNDLE_VERSION = "2.0";

	public const string PRODUCT_NAME = "Chupa Chupa VR";
}
public static class ResourcesDirectoryPath
{
	public const string AUDIO = "Audio";

	public const string AUDIO_BGM = "Audio/BGM";

	public const string AUDIO_SE = "Audio/SE";

	public const string DATA = "Data";

	public const string DATA_LOCALIZED_TEXT_DATA = "Data/LocalizedTextData";

	public const string DEFAULT_STMMATERIALS = "DefaultSTMMaterials";

	public const string ES3 = "ES3";

	public const string ICONS = "Icons";

	public const string MATERIAL = "Material";

	public const string PREFAB = "Prefab";

	public const string PREFAB_CHARACTER = "Prefab/Character";

	public const string PREFAB_CHARACTER_MAIN = "Prefab/Character/Main";

	public const string PREFAB_CHARACTER_SETTING = "Prefab/Character/Setting";

	public const string PREFAB_LICKABLE_OBJECT = "Prefab/LickableObject";

	public const string PREFAB_PRODUCTION = "Prefab/Production";

	public const string PREFAB_PRODUCTION_CACHE = "Prefab/Production/Cache";

	public const string PREFAB_PRODUCTION_CACHE_PARTICLE = "Prefab/Production/Cache/Particle";

	public const string PREFAB_PRODUCTION_MESH_EFFECT = "Prefab/Production/MeshEffect";

	public const string PREFAB_PRODUCTION_REUSE = "Prefab/Production/Reuse";

	public const string PREFAB_PRODUCTION_REUSE_PARTICLE = "Prefab/Production/Reuse/Particle";

	public const string PREFAB_PRODUCTION_REUSE_SCORE_PRODUCTION = "Prefab/Production/Reuse/ScoreProduction";

	public const string PREFABS = "Prefabs";

	public const string PREFABS_BLACK_SQUARED_SKIN_POPUPS = "Prefabs/BlackSquaredSkin-Popups";

	public const string PREFABS_DARK_SKIN_POPUPS = "Prefabs/DarkSkin-Popups";

	public const string PREFABS_LIGHT_SKIN_POPUPS = "Prefabs/LightSkin-Popups";

	public const string SHADER = "Shader";

	public const string SHADERS = "Shaders";

	public const string SIRENIX = "Sirenix";

	public const string STMAUDIO_CLIPS = "STMAudioClips";

	public const string STMAUTO_CLIPS = "STMAutoClips";

	public const string STMAUTO_DELAYS = "STMAutoDelays";

	public const string STMCOLORS = "STMColors";

	public const string STMDELAYS = "STMDelays";

	public const string STMDRAW_ANIMS = "STMDrawAnims";

	public const string STMFONTS = "STMFonts";

	public const string STMGRADIENTS = "STMGradients";

	public const string STMJITTERS = "STMJitters";

	public const string STMMATERIALS = "STMMaterials";

	public const string STMPREFABS = "STMPrefabs";

	public const string STMQUADS = "STMQuads";

	public const string STMSOUND_CLIPS = "STMSoundClips";

	public const string STMTEXTURES = "STMTextures";

	public const string STMVOICES = "STMVoices";

	public const string STMWAVES = "STMWaves";

	public const string TEXTURE = "Texture";

	public const string VOICE = "Voice";

	public const string VOICE_BOY = "Voice/Boy";

	public const string VOICE_GIRL = "Voice/Girl";
}
public static class ResourcesFilePath
{
	public const string ASSET3_DWAVE = "STMWaves/3Dwave";

	public const string ASSET_AMAZED = "STMGradients/Amazed";

	public const string ASSETANYBUTTON = "STMQuads/anybutton";

	public const string ASSET_APPEAR = "STMDrawAnims/Appear";

	public const string ASSETARIAL = "STMFonts/arial";

	public const string ASSETARIALLO = "STMFonts/arial-lo";

	public const string ASSETARROW = "STMQuads/arrow";

	public const string ASSET_AUDIO_VOLUME_SETTING = "Data/AudioVolumeSetting";

	public const string ASSETBLINK = "STMGradients/blink";

	public const string ASSET_BLINK = "STMDrawAnims/Blink";

	public const string ASSETBLOOD = "STMTextures/blood";

	public const string ASSET_BRAZILIAN = "Data/LocalizedTextData/Brazilian";

	public const string ASSETBUBBLE = "STMQuads/bubble";

	public const string ASSET_CHINESE_SIMPLIFIED = "Data/LocalizedTextData/ChineseSimplified";

	public const string ASSET_CHINESE_TRADITIONAL = "Data/LocalizedTextData/ChineseTraditional";

	public const string ASSETCIRCLE = "STMQuads/circle";

	public const string ASSETCLAP = "STMQuads/clap";

	public const string ASSETCOLON = "STMAutoDelays/colon";

	public const string ASSETCOMMA = "STMAutoDelays/comma";

	public const string ASSETCRAZY = "STMJitters/crazy";

	public const string ASSETCROSS = "STMQuads/cross";

	public const string ASSETDEFAULT = "STMWaves/default";

	public const string ASSET_DOTWEEN_SETTINGS = "DOTweenSettings";

	public const string ASSETDROPSHADOW = "STMMaterials/dropshadow";

	public const string ASSET_ENGLISH = "Data/LocalizedTextData/English";

	public const string ASSETEXCLAMATIONPOINT = "STMAutoDelays/exclamation point";

	public const string ASSET_FADE = "STMDrawAnims/Fade";

	public const string ASSETFANCY = "STMWaves/fancy";

	public const string ASSET_FILL = "STMDrawAnims/Fill";

	public const string ASSETFIRE = "STMTextures/fire";

	public const string ASSETFIRE2 = "STMTextures/fire2";

	public const string ASSET_FLY = "STMDrawAnims/Fly";

	public const string ASSET_FONT_MASTER_DATA = "Data/FontMasterData";

	public const string ASSET_FRENCH = "Data/LocalizedTextData/French";

	public const string ASSET_GERMAN = "Data/LocalizedTextData/German";

	public const string ASSET_GLOBAL_SERIALIZATION_CONFIG = "Sirenix/GlobalSerializationConfig";

	public const string ASSET_GOLD = "STMGradients/Gold";

	public const string ASSET_GOLD_EYE_MARK = "STMTextures/GoldEyeMark";

	public const string ASSET_GROW = "STMDrawAnims/Grow";

	public const string ASSET_HEART_EYE_MARK = "STMTextures/HeartEyeMark";

	public const string ASSETITIM = "STMFonts/itim";

	public const string ASSET_JAPANESE = "Data/LocalizedTextData/Japanese";

	public const string ASSET_KOREAN = "Data/LocalizedTextData/Korean";

	public const string ASSET_LIGHTNING = "STMTextures/Lightning";

	public const string ASSETLINEBREAK = "STMAutoClips/line break";

	public const string ASSETLOGO = "STMQuads/logo";

	public const string ASSET_MONEY_EYE_MARK = "STMTextures/MoneyEyeMark";

	public const string ASSETONCE = "STMWaves/once";

	public const string ASSETPERIOD = "STMAutoDelays/period";

	public const string ASSET_POLISH = "Data/LocalizedTextData/Polish";

	public const string ASSETPRESS_A = "STMQuads/pressA";

	public const string ASSETQUESTIONMARK = "STMAutoDelays/question mark";

	public const string ASSETRAINBOW = "STMGradients/rainbow";

	public const string ASSET_RAINBOW_VERTICAL = "STMTextures/RainbowVertical";

	public const string ASSETREDOUTLINE = "STMMaterials/redoutline";

	public const string ASSET_REFERENCE_POSE_BIND_POSE = "ReferencePose_BindPose";

	public const string ASSET_REFERENCE_POSE_FIST = "ReferencePose_Fist";

	public const string ASSET_REFERENCE_POSE_OPEN_HAND = "ReferencePose_OpenHand";

	public const string ASSETREV = "STMColors/rev";

	public const string ASSETROYALTY = "STMVoices/royalty";

	public const string ASSET_RUSSIAN = "Data/LocalizedTextData/Russian";

	public const string ASSETSAMPLE = "STMVoices/sample";

	public const string ASSETSASSY = "STMWaves/sassy";

	public const string ASSETSEASICK = "STMWaves/seasick";

	public const string ASSETSEMICOLON = "STMAutoDelays/semicolon";

	public const string ASSET_SILVER = "STMGradients/Silver";

	public const string ASSET_SLOW_SEASICK = "STMWaves/SlowSeasick";

	public const string ASSETSPACE = "STMAutoClips/space";

	public const string ASSET_SPANISH = "Data/LocalizedTextData/Spanish";

	public const string ASSET_SPRING = "STMDrawAnims/Spring";

	public const string ASSETSQUARE = "STMQuads/square";

	public const string ASSET_STAMP = "STMDrawAnims/Stamp";

	public const string ASSET_STEAM_VR_SETTINGS = "SteamVR_Settings";

	public const string ASSET_SUPER_TEXT_MESH_DATA = "SuperTextMeshData";

	public const string ASSETTAB = "STMAutoClips/tab";

	public const string ASSETTAK = "STMColors/tak";

	public const string ASSET_TEXT_DATA = "STMQuads/TextData";

	public const string ASSETTRIANGLE = "STMQuads/triangle";

	public const string ASSETTYPEWRITER = "STMVoices/typewriter";

	public const string ASSETUNDERGROUND = "STMJitters/underground";

	public const string ASSETWALIBI = "STMFonts/walibi";

	public const string ASSETWATERMELON = "STMGradients/watermelon";

	public const string ASSETWOOD = "STMQuads/wood";

	public const string AUDIO_BGM_BEFORE = "Audio/BGM/BGM_Before";

	public const string AUDIO_BGM_PLAYING = "Audio/BGM/BGM_Playing";

	public const string AUDIO_BGM_SETTING = "Audio/BGM/BGM_Setting";

	public const string AUDIO_SE_CHIME = "Audio/SE/SE_Chime";

	public const string AUDIO_SE_CLACKER = "Audio/SE/SE_Clacker";

	public const string AUDIO_SE_CLACKER_ONE = "Audio/SE/SE_ClackerOne";

	public const string AUDIO_SE_CLAP1 = "Audio/SE/SE_Clap1";

	public const string AUDIO_SE_CLAP2 = "Audio/SE/SE_Clap2";

	public const string AUDIO_SE_CLAP3 = "Audio/SE/SE_Clap3";

	public const string AUDIO_SE_CLAP4 = "Audio/SE/SE_Clap4";

	public const string AUDIO_SE_CLOCK1 = "Audio/SE/SE_Clock1";

	public const string AUDIO_SE_CLOCK2 = "Audio/SE/SE_Clock2";

	public const string AUDIO_SE_CLOSE_CLOCK = "Audio/SE/SE_CloseClock";

	public const string AUDIO_SE_CLOSE_LOCKER = "Audio/SE/SE_CloseLocker";

	public const string AUDIO_SE_CLOSE_SHELF_DOOR = "Audio/SE/SE_CloseShelfDoor";

	public const string AUDIO_SE_COMBO_ELECTRICAL = "Audio/SE/SE_ComboElectrical";

	public const string AUDIO_SE_COUNT_DOWN_SCORE = "Audio/SE/SE_CountDownScore";

	public const string AUDIO_SE_COUNT_UP_SCORE = "Audio/SE/SE_CountUpScore";

	public const string AUDIO_SE_CURSE = "Audio/SE/SE_Curse";

	public const string AUDIO_SE_DISCOVER = "Audio/SE/SE_Discover";

	public const string AUDIO_SE_ELECTRIFICATION = "Audio/SE/SE_Electrification";

	public const string AUDIO_SE_FEVER = "Audio/SE/SE_Fever";

	public const string AUDIO_SE_FLY_HOLD = "Audio/SE/SE_FlyHold";

	public const string AUDIO_SE_FOOT_STEP1 = "Audio/SE/SE_FootStep1";

	public const string AUDIO_SE_FOOT_STEP2 = "Audio/SE/SE_FootStep2";

	public const string AUDIO_SE_FOOT_STEP3 = "Audio/SE/SE_FootStep3";

	public const string AUDIO_SE_FOOT_STEP4 = "Audio/SE/SE_FootStep4";

	public const string AUDIO_SE_FOOT_STEP5 = "Audio/SE/SE_FootStep5";

	public const string AUDIO_SE_FOOT_STEP6 = "Audio/SE/SE_FootStep6";

	public const string AUDIO_SE_FOOT_STEP7 = "Audio/SE/SE_FootStep7";

	public const string AUDIO_SE_FOOT_STEP8 = "Audio/SE/SE_FootStep8";

	public const string AUDIO_SE_GAUGE = "Audio/SE/SE_Gauge";

	public const string AUDIO_SE_HEART = "Audio/SE/SE_Heart";

	public const string AUDIO_SE_HEART_BEAT = "Audio/SE/SE_HeartBeat";

	public const string AUDIO_SE_HIDE_SMART_PHONE_TEXT = "Audio/SE/SE_HideSmartPhoneText";

	public const string AUDIO_SE_HIT_CHEST = "Audio/SE/SE_HitChest";

	public const string AUDIO_SE_HIT_SLAP = "Audio/SE/SE_HitSlap";

	public const string AUDIO_SE_JUMP = "Audio/SE/SE_Jump";

	public const string AUDIO_SE_KAN_KIKUCHI_VOICE = "Audio/SE/SE_KanKikuchiVoice";

	public const string AUDIO_SE_KO = "Audio/SE/SE_KO";

	public const string AUDIO_SE_LANDING = "Audio/SE/SE_Landing";

	public const string AUDIO_SE_LANDING_SHORT = "Audio/SE/SE_LandingShort";

	public const string AUDIO_SE_LICKE_FEVER_EFFECT = "Audio/SE/SE_LickeFeverEffect";

	public const string AUDIO_SE_LICK_MINUS = "Audio/SE/SE_lickMinus";

	public const string AUDIO_SE_LICK_PLUS = "Audio/SE/SE_lickPlus";

	public const string AUDIO_SE_MICROWAVE_CHIN = "Audio/SE/SE_MicrowaveChin";

	public const string AUDIO_SE_MICROWAVE_CLOSE = "Audio/SE/SE_MicrowaveClose";

	public const string AUDIO_SE_MICROWAVE_OPEN = "Audio/SE/SE_MicrowaveOpen";

	public const string AUDIO_SE_MISS = "Audio/SE/SE_Miss";

	public const string AUDIO_SE_OPEN_CLOCK = "Audio/SE/SE_OpenClock";

	public const string AUDIO_SE_OPEN_LOCKER = "Audio/SE/SE_OpenLocker";

	public const string AUDIO_SE_OPEN_SHELF_DOOR = "Audio/SE/SE_OpenShelfDoor";

	public const string AUDIO_SE_POPUP_SPEECH_BUBBLE = "Audio/SE/SE_PopupSpeechBubble";

	public const string AUDIO_SE_RETURN_SMART_PHONE = "Audio/SE/SE_ReturnSmartPhone";

	public const string AUDIO_SE_RETURN_TIME = "Audio/SE/SE_ReturnTime";

	public const string AUDIO_SE_SELECT_MENU = "Audio/SE/SE_SelectMenu";

	public const string AUDIO_SE_SHOW_ANSWER = "Audio/SE/SE_ShowAnswer";

	public const string AUDIO_SE_SHOW_SMART_PHONE_TEXT = "Audio/SE/SE_ShowSmartPhoneText";

	public const string AUDIO_SE_SPAWN_BAG_ITEM = "Audio/SE/SE_SpawnBagItem";

	public const string AUDIO_SE_SPAWN_SPECIAL_ITEM = "Audio/SE/SE_SpawnSpecialItem";

	public const string AUDIO_SE_SUCCESS = "Audio/SE/SE_Success";

	public const string AUDIO_SE_SWING_SLAP = "Audio/SE/SE_SwingSlap";

	public const string AUDIO_SE_THUNDER = "Audio/SE/SE_Thunder";

	public const string AUDIO_SE_TIME_RESUME_EFFECT = "Audio/SE/SE_TimeResumeEffect";

	public const string AUDIO_SE_TIME_STOP_EFFECT = "Audio/SE/SE_TimeStopEffect";

	public const string AUDIO_SE_TRANSFORM = "Audio/SE/SE_Transform";

	public const string AUDIO_SE_WING = "Audio/SE/SE_Wing";

	public const string AUDIO_VOICE_SAMPLE_VOICE = "Voice/Girl/Voice_SampleVoice";

	public const string AUDIO_VOICE_SERIF_ACTION1 = "Voice/Girl/Voice_SerifAction1";

	public const string AUDIO_VOICE_SERIF_ACTION10 = "Voice/Girl/Voice_SerifAction10";

	public const string AUDIO_VOICE_SERIF_ACTION2 = "Voice/Girl/Voice_SerifAction2";

	public const string AUDIO_VOICE_SERIF_ACTION3 = "Voice/Girl/Voice_SerifAction3";

	public const string AUDIO_VOICE_SERIF_ACTION4 = "Voice/Girl/Voice_SerifAction4";

	public const string AUDIO_VOICE_SERIF_ACTION5 = "Voice/Girl/Voice_SerifAction5";

	public const string AUDIO_VOICE_SERIF_ACTION6 = "Voice/Girl/Voice_SerifAction6";

	public const string AUDIO_VOICE_SERIF_ACTION7 = "Voice/Girl/Voice_SerifAction7";

	public const string AUDIO_VOICE_SERIF_ACTION8 = "Voice/Girl/Voice_SerifAction8";

	public const string AUDIO_VOICE_SERIF_ACTION9 = "Voice/Girl/Voice_SerifAction9";

	public const string AUDIO_VOICE_SERIF_FOUND_GAME_OVER_HIGH_SCORE1 = "Voice/Girl/Voice_SerifFoundGameOverHighScore1";

	public const string AUDIO_VOICE_SERIF_FOUND_GAME_OVER_HIGH_SCORE2 = "Voice/Girl/Voice_SerifFoundGameOverHighScore2";

	public const string AUDIO_VOICE_SERIF_FOUND_GAME_OVER_HIGH_SCORE3 = "Voice/Girl/Voice_SerifFoundGameOverHighScore3";

	public const string AUDIO_VOICE_SERIF_FOUND_GAME_OVER_HIGH_SCORE4 = "Voice/Girl/Voice_SerifFoundGameOverHighScore4";

	public const string AUDIO_VOICE_SERIF_FOUND_GAME_OVER_HIGH_SCORE5 = "Voice/Girl/Voice_SerifFoundGameOverHighScore5";

	public const string AUDIO_VOICE_SERIF_FOUND_GAME_OVER_LOW_SCORE1 = "Voice/Girl/Voice_SerifFoundGameOverLowScore1";

	public const string AUDIO_VOICE_SERIF_FOUND_GAME_OVER_LOW_SCORE2 = "Voice/Girl/Voice_SerifFoundGameOverLowScore2";

	public const string AUDIO_VOICE_SERIF_FOUND_GAME_OVER_LOW_SCORE3 = "Voice/Girl/Voice_SerifFoundGameOverLowScore3";

	public const string AUDIO_VOICE_SERIF_FOUND_GAME_OVER_LOW_SCORE4 = "Voice/Girl/Voice_SerifFoundGameOverLowScore4";

	public const string AUDIO_VOICE_SERIF_FOUND_GAME_OVER_LOW_SCORE5 = "Voice/Girl/Voice_SerifFoundGameOverLowScore5";

	public const string AUDIO_VOICE_SERIF_FOUND_GAME_OVER_QUITE_HIGH_SCORE1 = "Voice/Girl/Voice_SerifFoundGameOverQuiteHighScore1";

	public const string AUDIO_VOICE_SERIF_FOUND_GAME_OVER_QUITE_HIGH_SCORE2 = "Voice/Girl/Voice_SerifFoundGameOverQuiteHighScore2";

	public const string AUDIO_VOICE_SERIF_FOUND_GAME_OVER_QUITE_HIGH_SCORE3 = "Voice/Girl/Voice_SerifFoundGameOverQuiteHighScore3";

	public const string AUDIO_VOICE_SERIF_FOUND_GAME_OVER_QUITE_HIGH_SCORE4 = "Voice/Girl/Voice_SerifFoundGameOverQuiteHighScore4";

	public const string AUDIO_VOICE_SERIF_FOUND_GAME_OVER_QUITE_HIGH_SCORE5 = "Voice/Girl/Voice_SerifFoundGameOverQuiteHighScore5";

	public const string AUDIO_VOICE_SERIF_FOUND_GAME_OVER_QUITE_LOW_SCORE1 = "Voice/Girl/Voice_SerifFoundGameOverQuiteLowScore1";

	public const string AUDIO_VOICE_SERIF_FOUND_GAME_OVER_QUITE_LOW_SCORE2 = "Voice/Girl/Voice_SerifFoundGameOverQuiteLowScore2";

	public const string AUDIO_VOICE_SERIF_FOUND_GAME_OVER_QUITE_LOW_SCORE3 = "Voice/Girl/Voice_SerifFoundGameOverQuiteLowScore3";

	public const string AUDIO_VOICE_SERIF_FOUND_GAME_OVER_QUITE_LOW_SCORE4 = "Voice/Girl/Voice_SerifFoundGameOverQuiteLowScore4";

	public const string AUDIO_VOICE_SERIF_FOUND_GAME_OVER_QUITE_LOW_SCORE5 = "Voice/Girl/Voice_SerifFoundGameOverQuiteLowScore5";

	public const string AUDIO_VOICE_SERIF_LICKED_GIRL_GAME_OVER1 = "Voice/Girl/Voice_SerifLickedGirlGameOver1";

	public const string AUDIO_VOICE_SERIF_LICKED_GIRL_GAME_OVER10 = "Voice/Girl/Voice_SerifLickedGirlGameOver10";

	public const string AUDIO_VOICE_SERIF_LICKED_GIRL_GAME_OVER2 = "Voice/Girl/Voice_SerifLickedGirlGameOver2";

	public const string AUDIO_VOICE_SERIF_LICKED_GIRL_GAME_OVER3 = "Voice/Girl/Voice_SerifLickedGirlGameOver3";

	public const string AUDIO_VOICE_SERIF_LICKED_GIRL_GAME_OVER4 = "Voice/Girl/Voice_SerifLickedGirlGameOver4";

	public const string AUDIO_VOICE_SERIF_LICKED_GIRL_GAME_OVER5 = "Voice/Girl/Voice_SerifLickedGirlGameOver5";

	public const string AUDIO_VOICE_SERIF_LICKED_GIRL_GAME_OVER6 = "Voice/Girl/Voice_SerifLickedGirlGameOver6";

	public const string AUDIO_VOICE_SERIF_LICKED_GIRL_GAME_OVER7 = "Voice/Girl/Voice_SerifLickedGirlGameOver7";

	public const string AUDIO_VOICE_SERIF_LICKED_GIRL_GAME_OVER8 = "Voice/Girl/Voice_SerifLickedGirlGameOver8";

	public const string AUDIO_VOICE_SERIF_LICKED_GIRL_GAME_OVER9 = "Voice/Girl/Voice_SerifLickedGirlGameOver9";

	public const string AUDIO_VOICE_SERIF_START_GAME1 = "Voice/Girl/Voice_SerifStartGame1";

	public const string AUDIO_VOICE_SERIF_START_GAME10 = "Voice/Girl/Voice_SerifStartGame10";

	public const string AUDIO_VOICE_SERIF_START_GAME2 = "Voice/Girl/Voice_SerifStartGame2";

	public const string AUDIO_VOICE_SERIF_START_GAME3 = "Voice/Girl/Voice_SerifStartGame3";

	public const string AUDIO_VOICE_SERIF_START_GAME4 = "Voice/Girl/Voice_SerifStartGame4";

	public const string AUDIO_VOICE_SERIF_START_GAME5 = "Voice/Girl/Voice_SerifStartGame5";

	public const string AUDIO_VOICE_SERIF_START_GAME6 = "Voice/Girl/Voice_SerifStartGame6";

	public const string AUDIO_VOICE_SERIF_START_GAME7 = "Voice/Girl/Voice_SerifStartGame7";

	public const string AUDIO_VOICE_SERIF_START_GAME8 = "Voice/Girl/Voice_SerifStartGame8";

	public const string AUDIO_VOICE_SERIF_START_GAME9 = "Voice/Girl/Voice_SerifStartGame9";

	public const string AUDIO_VOICE_SERIF_STOLE_GAME_OVER1 = "Voice/Girl/Voice_SerifStoleGameOver1";

	public const string AUDIO_VOICE_SERIF_STOLE_GAME_OVER10 = "Voice/Girl/Voice_SerifStoleGameOver10";

	public const string AUDIO_VOICE_SERIF_STOLE_GAME_OVER2 = "Voice/Girl/Voice_SerifStoleGameOver2";

	public const string AUDIO_VOICE_SERIF_STOLE_GAME_OVER3 = "Voice/Girl/Voice_SerifStoleGameOver3";

	public const string AUDIO_VOICE_SERIF_STOLE_GAME_OVER4 = "Voice/Girl/Voice_SerifStoleGameOver4";

	public const string AUDIO_VOICE_SERIF_STOLE_GAME_OVER5 = "Voice/Girl/Voice_SerifStoleGameOver5";

	public const string AUDIO_VOICE_SERIF_STOLE_GAME_OVER6 = "Voice/Girl/Voice_SerifStoleGameOver6";

	public const string AUDIO_VOICE_SERIF_STOLE_GAME_OVER7 = "Voice/Girl/Voice_SerifStoleGameOver7";

	public const string AUDIO_VOICE_SERIF_STOLE_GAME_OVER8 = "Voice/Girl/Voice_SerifStoleGameOver8";

	public const string AUDIO_VOICE_SERIF_STOLE_GAME_OVER9 = "Voice/Girl/Voice_SerifStoleGameOver9";

	public const string AUDIO_VOICE_SERIF_SURPRISE1 = "Voice/Girl/Voice_SerifSurprise1";

	public const string AUDIO_VOICE_SERIF_SURPRISE10 = "Voice/Girl/Voice_SerifSurprise10";

	public const string AUDIO_VOICE_SERIF_SURPRISE2 = "Voice/Girl/Voice_SerifSurprise2";

	public const string AUDIO_VOICE_SERIF_SURPRISE3 = "Voice/Girl/Voice_SerifSurprise3";

	public const string AUDIO_VOICE_SERIF_SURPRISE4 = "Voice/Girl/Voice_SerifSurprise4";

	public const string AUDIO_VOICE_SERIF_SURPRISE5 = "Voice/Girl/Voice_SerifSurprise5";

	public const string AUDIO_VOICE_SERIF_SURPRISE6 = "Voice/Girl/Voice_SerifSurprise6";

	public const string AUDIO_VOICE_SERIF_SURPRISE7 = "Voice/Girl/Voice_SerifSurprise7";

	public const string AUDIO_VOICE_SERIF_SURPRISE8 = "Voice/Girl/Voice_SerifSurprise8";

	public const string AUDIO_VOICE_SERIF_SURPRISE9 = "Voice/Girl/Voice_SerifSurprise9";

	public const string AUDIO_VOICE_SERIF_TIME_UP_GAME_OVER_HIGH_SCORE1 = "Voice/Girl/Voice_SerifTimeUpGameOverHighScore1";

	public const string AUDIO_VOICE_SERIF_TIME_UP_GAME_OVER_HIGH_SCORE2 = "Voice/Girl/Voice_SerifTimeUpGameOverHighScore2";

	public const string AUDIO_VOICE_SERIF_TIME_UP_GAME_OVER_HIGH_SCORE3 = "Voice/Girl/Voice_SerifTimeUpGameOverHighScore3";

	public const string AUDIO_VOICE_SERIF_TIME_UP_GAME_OVER_HIGH_SCORE4 = "Voice/Girl/Voice_SerifTimeUpGameOverHighScore4";

	public const string AUDIO_VOICE_SERIF_TIME_UP_GAME_OVER_HIGH_SCORE5 = "Voice/Girl/Voice_SerifTimeUpGameOverHighScore5";

	public const string AUDIO_VOICE_SERIF_TIME_UP_GAME_OVER_LOW_SCORE1 = "Voice/Girl/Voice_SerifTimeUpGameOverLowScore1";

	public const string AUDIO_VOICE_SERIF_TIME_UP_GAME_OVER_LOW_SCORE2 = "Voice/Girl/Voice_SerifTimeUpGameOverLowScore2";

	public const string AUDIO_VOICE_SERIF_TIME_UP_GAME_OVER_LOW_SCORE3 = "Voice/Girl/Voice_SerifTimeUpGameOverLowScore3";

	public const string AUDIO_VOICE_SERIF_TIME_UP_GAME_OVER_LOW_SCORE4 = "Voice/Girl/Voice_SerifTimeUpGameOverLowScore4";

	public const string AUDIO_VOICE_SERIF_TIME_UP_GAME_OVER_LOW_SCORE5 = "Voice/Girl/Voice_SerifTimeUpGameOverLowScore5";

	public const string AUDIO_VOICE_SERIF_TIME_UP_GAME_OVER_QUITE_HIGH_SCORE1 = "Voice/Girl/Voice_SerifTimeUpGameOverQuiteHighScore1";

	public const string AUDIO_VOICE_SERIF_TIME_UP_GAME_OVER_QUITE_HIGH_SCORE2 = "Voice/Girl/Voice_SerifTimeUpGameOverQuiteHighScore2";

	public const string AUDIO_VOICE_SERIF_TIME_UP_GAME_OVER_QUITE_HIGH_SCORE3 = "Voice/Girl/Voice_SerifTimeUpGameOverQuiteHighScore3";

	public const string AUDIO_VOICE_SERIF_TIME_UP_GAME_OVER_QUITE_HIGH_SCORE4 = "Voice/Girl/Voice_SerifTimeUpGameOverQuiteHighScore4";

	public const string AUDIO_VOICE_SERIF_TIME_UP_GAME_OVER_QUITE_HIGH_SCORE5 = "Voice/Girl/Voice_SerifTimeUpGameOverQuiteHighScore5";

	public const string AUDIO_VOICE_SERIF_TIME_UP_GAME_OVER_QUITE_LOW_SCORE1 = "Voice/Girl/Voice_SerifTimeUpGameOverQuiteLowScore1";

	public const string AUDIO_VOICE_SERIF_TIME_UP_GAME_OVER_QUITE_LOW_SCORE2 = "Voice/Girl/Voice_SerifTimeUpGameOverQuiteLowScore2";

	public const string AUDIO_VOICE_SERIF_TIME_UP_GAME_OVER_QUITE_LOW_SCORE3 = "Voice/Girl/Voice_SerifTimeUpGameOverQuiteLowScore3";

	public const string AUDIO_VOICE_SERIF_TIME_UP_GAME_OVER_QUITE_LOW_SCORE4 = "Voice/Girl/Voice_SerifTimeUpGameOverQuiteLowScore4";

	public const string AUDIO_VOICE_SERIF_TIME_UP_GAME_OVER_QUITE_LOW_SCORE5 = "Voice/Girl/Voice_SerifTimeUpGameOverQuiteLowScore5";

	public const string MATERIAL_BONUS_TEXT = "Material/BonusText";

	public const string MATERIAL_CAMERA_FADER = "Material/CameraFader";

	public const string MATERIAL_DEFAULT = "DefaultSTMMaterials/Default";

	public const string MATERIAL_SCORE_TEXT = "Material/ScoreText";

	public const string MATERIAL_STEAM_VR_HOVER_HIGHLIGHT = "SteamVR_HoverHighlight";

	public const string MATERIAL_STEREO_RENDER_MATERIAL = "StereoRenderMaterial";

	public const string MATERIAL_UIDEFAULT = "DefaultSTMMaterials/UIDefault";

	public const string PREFAB_ADMIRATION_PARTICLE = "Prefab/Production/Reuse/Particle/AdmirationParticle";

	public const string PREFAB_ATTENDANCEBOOK = "Prefab/LickableObject/Attendancebook";

	public const string PREFAB_BABY_BOTTLE = "Prefab/LickableObject/BabyBottle";

	public const string PREFAB_BLACKBOARD_ERASER = "Prefab/LickableObject/BlackboardEraser";

	public const string PREFAB_BLACKBOARD_ERASER_CLEANER = "Prefab/LickableObject/BlackboardEraserCleaner";

	public const string PREFAB_BOOK1 = "Prefab/LickableObject/Book1";

	public const string PREFAB_BOOK2 = "Prefab/LickableObject/Book2";

	public const string PREFAB_BOY = "Prefab/Character/Main/Boy";

	public const string PREFAB_BRA = "Prefab/LickableObject/Bra";

	public const string PREFAB_BROOM = "Prefab/LickableObject/Broom";

	public const string PREFAB_BURMA = "Prefab/LickableObject/Burma";

	public const string PREFAB_CANDY = "Prefab/LickableObject/Candy";

	public const string PREFAB_CATFISH = "Prefab/LickableObject/Catfish";

	public const string PREFAB_CHALK_BLUE = "Prefab/LickableObject/ChalkBlue";

	public const string PREFAB_CHALK_LINE = "Prefab/ChalkLine";

	public const string PREFAB_CHALK_LINE_RAINBOW = "Prefab/ChalkLineRainbow";

	public const string PREFAB_CHALK_PINK = "Prefab/LickableObject/ChalkPink";

	public const string PREFAB_CHALK_RAINBOW = "Prefab/LickableObject/ChalkRainbow";

	public const string PREFAB_CHALK_WHITE = "Prefab/LickableObject/ChalkWhite";

	public const string PREFAB_CHALK_YELLOW = "Prefab/LickableObject/ChalkYellow";

	public const string PREFAB_CHAT_FRIENDS_BLACK_SQUARE_POPUP = "Prefabs/BlackSquaredSkin-Popups/Chat-Friends-BlackSquare-Popup";

	public const string PREFAB_CHAT_FRIENDS_LIGHT_SKIN_POPUP = "Prefabs/LightSkin-Popups/Chat-Friends-LightSkin-Popup";

	public const string PREFAB_CHAT_FRIENDS_POPUP = "Prefabs/DarkSkin-Popups/Chat-Friends-Popup";

	public const string PREFAB_CHOCO_BANANA = "Prefab/LickableObject/ChocoBanana";

	public const string PREFAB_CHOKER = "Prefab/LickableObject/Choker";

	public const string PREFAB_COINS_SHOP_BLACK_SQUARE_POPUP = "Prefabs/BlackSquaredSkin-Popups/CoinsShop-BlackSquare-Popup";

	public const string PREFAB_COINS_SHOP_LIGHT_SKIN_POPUP = "Prefabs/LightSkin-Popups/CoinsShop-LightSkin-Popup";

	public const string PREFAB_COINS_SHOP_POPUP = "Prefabs/DarkSkin-Popups/CoinsShop-Popup";

	public const string PREFAB_COMBO_TEXT = "Prefab/ComboText";

	public const string PREFAB_COMPASS = "Prefab/LickableObject/Compass";

	public const string PREFAB_COUNT_DOWN_PARTICLE = "Prefab/Production/Reuse/Particle/CountDownParticle";

	public const string PREFAB_COUNT_UP_PARTICLE = "Prefab/Production/Reuse/Particle/CountUpParticle";

	public const string PREFAB_CUTTER = "Prefab/LickableObject/Cutter";

	public const string PREFAB_DICTIONARY1 = "Prefab/LickableObject/Dictionary1";

	public const string PREFAB_DICTIONARY2 = "Prefab/LickableObject/Dictionary2";

	public const string PREFAB_DUSTPAN = "Prefab/LickableObject/Dustpan";

	public const string PREFAB_EASY_SAVE3_MANAGER = "Prefab/EasySave3Manager";

	public const string PREFAB_ERASER = "Prefab/LickableObject/Eraser";

	public const string PREFAB_ES3_DEFAULT_SETTINGS = "ES3/ES3 Default Settings";

	public const string PREFAB_EYE_SHADOW_PALETTE = "Prefab/LickableObject/EyeShadowPalette";

	public const string PREFAB_FLUTTER_BOARD = "Prefab/LickableObject/FlutterBoard";

	public const string PREFAB_FLYING_COMBO_EFFECT = "Prefab/Production/Reuse/FlyingComboEffect";

	public const string PREFAB_FORK = "Prefab/LickableObject/Fork";

	public const string PREFAB_GEMS_SHOP_BLACK_SQUARE_POPUP = "Prefabs/BlackSquaredSkin-Popups/GemsShop-BlackSquare-Popup";

	public const string PREFAB_GEMS_SHOP_LIGHT_SKIN_POPUP = "Prefabs/LightSkin-Popups/GemsShop-LightSkin-Popup";

	public const string PREFAB_GEMS_SHOP_POPUP = "Prefabs/DarkSkin-Popups/GemsShop-Popup";

	public const string PREFAB_GIRL = "Prefab/LickableObject/Girl";

	public const string PREFAB_GIRL_DRINK = "Prefab/LickableObject/GirlDrink";

	public const string PREFAB_GIRL_SCHOOL_BAG = "Prefab/LickableObject/GirlSchoolBag";

	public const string PREFAB_GIRL_SMART_PHONE = "Prefab/LickableObject/GirlSmartPhone";

	public const string PREFAB_GLASSES = "Prefab/LickableObject/Glasses";

	public const string PREFAB_HEAD_PHONE = "Prefab/LickableObject/HeadPhone";

	public const string PREFAB_HIDDEN_CAMERA = "Prefab/LickableObject/HiddenCamera";

	public const string PREFAB_ICE = "Prefab/LickableObject/Ice";

	public const string PREFAB_INFO_BLACK_SQUARE_POPUP = "Prefabs/BlackSquaredSkin-Popups/Info-BlackSquare-Popup";

	public const string PREFAB_INFO_LIGHT_SKIN_POPUP = "Prefabs/LightSkin-Popups/Info-LightSkin-Popup";

	public const string PREFAB_INFO_POPUP = "Prefabs/DarkSkin-Popups/Info-Popup";

	public const string PREFAB_INGOT = "Prefab/LickableObject/Ingot";

	public const string PREFAB_INVALID_BOY = "Prefab/Character/Setting/InvalidBoy";

	public const string PREFAB_INVALID_GIRL = "Prefab/Character/Setting/InvalidGirl";

	public const string PREFAB_INVENTORY_BLACK_SQUARE_POPUP = "Prefabs/BlackSquaredSkin-Popups/Inventory-BlackSquare-Popup";

	public const string PREFAB_INVENTORY_LIGHT_SKIN_POPUP = "Prefabs/LightSkin-Popups/Inventory-LightSkin-Popup";

	public const string PREFAB_INVENTORY_POPUP = "Prefabs/DarkSkin-Popups/Inventory-Popup";

	public const string PREFAB_ITEM_GUN_BLACK_SQUARE_POPUP = "Prefabs/BlackSquaredSkin-Popups/Item-Gun-BlackSquare-Popup";

	public const string PREFAB_ITEM_GUN_LIGHT_SKIN_POPUP = "Prefabs/LightSkin-Popups/Item-Gun-LightSkin-Popup";

	public const string PREFAB_ITEM_GUN_POPUP = "Prefabs/DarkSkin-Popups/Item-Gun-Popup";

	public const string PREFAB_KAN_CROW = "Prefab/LickableObject/KanCrow";

	public const string PREFAB_LEADERBOARD_BLACK_SQUARE_POPUP = "Prefabs/BlackSquaredSkin-Popups/Leaderboard-BlackSquare-Popup";

	public const string PREFAB_LEADERBOARD_LIGHT_SKIN_POPUP = "Prefabs/LightSkin-Popups/Leaderboard-LightSkin-Popup";

	public const string PREFAB_LEADERBOARD_POPUP = "Prefabs/DarkSkin-Popups/Leaderboard-Popup";

	public const string PREFAB_LEVEL_BLACK_SQUARE_POPUP = "Prefabs/BlackSquaredSkin-Popups/Level-BlackSquare-Popup";

	public const string PREFAB_LEVEL_LIGHT_SKIN_POPUP = "Prefabs/LightSkin-Popups/Level-LightSkin-Popup";

	public const string PREFAB_LEVEL_POPUP = "Prefabs/DarkSkin-Popups/Level-Popup";

	public const string PREFAB_LEVEL_UP_BLACK_SQUARE_POPUP = "Prefabs/BlackSquaredSkin-Popups/LevelUp-BlackSquare-Popup";

	public const string PREFAB_LEVEL_UP_LIGHT_SKIN_POPUP = "Prefabs/LightSkin-Popups/LevelUp-LightSkin-Popup";

	public const string PREFAB_LEVEL_UP_POPUP = "Prefabs/DarkSkin-Popups/LevelUp-Popup";

	public const string PREFAB_LICK_CRITICAL_EFFECT = "Prefab/Production/MeshEffect/LickCriticalEffect";

	public const string PREFAB_LICKE_FEVER_EFFECT = "Prefab/Production/Reuse/Particle/LickeFeverEffect";

	public const string PREFAB_LICK_EFFECT = "Prefab/Production/MeshEffect/LickEffect";

	public const string PREFAB_LICKE_MINUS_EFFECT = "Prefab/Production/Reuse/Particle/LickeMinusEffect";

	public const string PREFAB_LICKE_PLUS_EFFECT = "Prefab/Production/Reuse/Particle/LickePlusEffect";

	public const string PREFAB_LIP = "Prefab/LickableObject/Lip";

	public const string PREFAB_LIVES_SHOP_BLACK_SQUARE_POPUP = "Prefabs/BlackSquaredSkin-Popups/LivesShop-BlackSquare-Popup";

	public const string PREFAB_LIVES_SHOP_LIGHT_SKIN_POPUP = "Prefabs/LightSkin-Popups/LivesShop-LightSkin-Popup";

	public const string PREFAB_LIVES_SHOP_POPUP = "Prefabs/DarkSkin-Popups/LivesShop-Popup";

	public const string PREFAB_LOAFER = "Prefab/LickableObject/Loafer";

	public const string PREFAB_LOGIN_BLACK_SQUARE_POPUP = "Prefabs/BlackSquaredSkin-Popups/Login-BlackSquare-Popup";

	public const string PREFAB_LOGIN_LIGHT_SKIN_POPUP = "Prefabs/LightSkin-Popups/Login-LightSkin-Popup";

	public const string PREFAB_LOGIN_POPUP = "Prefabs/DarkSkin-Popups/Login-Popup";

	public const string PREFAB_LOSE_BLACK_SQUARE_POPUP = "Prefabs/BlackSquaredSkin-Popups/Lose-BlackSquare-Popup";

	public const string PREFAB_LOSE_LIGHT_SKIN_POPUP = "Prefabs/LightSkin-Popups/Lose-LightSkin-Popup";

	public const string PREFAB_LOSE_POPUP = "Prefabs/DarkSkin-Popups/Lose-Popup";

	public const string PREFAB_LUCKY = "Prefab/LickableObject/Lucky";

	public const string PREFAB_LUCKY_BOX = "Prefab/LickableObject/LuckyBox";

	public const string PREFAB_LUNCH_BOX = "Prefab/LickableObject/LunchBox";

	public const string PREFAB_MASK = "Prefab/LickableObject/Mask";

	public const string PREFAB_MESSAGES_BLACK_SQUARE_POPUP = "Prefabs/BlackSquaredSkin-Popups/Messages-BlackSquare-Popup";

	public const string PREFAB_MESSAGES_LIGHT_SKIN_POPUP = "Prefabs/LightSkin-Popups/Messages-LightSkin-Popup";

	public const string PREFAB_MESSAGES_POPUP = "Prefabs/DarkSkin-Popups/Messages-Popup";

	public const string PREFAB_MISSIONS_BLACK_SQUARE_POPUP = "Prefabs/BlackSquaredSkin-Popups/Missions-BlackSquare-Popup";

	public const string PREFAB_MISSIONS_LIGHT_SKIN_POPUP = "Prefabs/LightSkin-Popups/Missions-LightSkin-Popup";

	public const string PREFAB_MISSIONS_POPUP = "Prefabs/DarkSkin-Popups/Missions-Popup";

	public const string PREFAB_MONEY = "Prefab/LickableObject/Money";

	public const string PREFAB_NEW_SUPER_TEXT = "STMPrefabs/New Super Text";

	public const string PREFAB_NORMAL_SCORE_ACQUISITION_PRODUCTION = "Prefab/Production/Reuse/ScoreProduction/NormalScoreAcquisitionProduction";

	public const string PREFAB_PANTY = "Prefab/LickableObject/Panty";

	public const string PREFAB_PEN = "Prefab/LickableObject/Pen";

	public const string PREFAB_PILLOW = "Prefab/LickableObject/Pillow";

	public const string PREFAB_POINTER = "Prefab/LickableObject/Pointer";

	public const string PREFAB_PROFILE2_BLACK_SQUARE_POPUP = "Prefabs/BlackSquaredSkin-Popups/Profile2-BlackSquare-Popup";

	public const string PREFAB_PROFILE_BLACK_SQUARE_POPUP = "Prefabs/BlackSquaredSkin-Popups/Profile-BlackSquare-Popup";

	public const string PREFAB_PROFILE_LIGHT_SKIN_POPUP = "Prefabs/LightSkin-Popups/Profile-LightSkin-Popup";

	public const string PREFAB_PROFILE_POPUP = "Prefabs/DarkSkin-Popups/Profile-Popup";

	public const string PREFAB_PROJECTOR = "Prefab/LickableObject/Projector";

	public const string PREFAB_PROTRACTOR = "Prefab/LickableObject/Protractor";

	public const string PREFAB_RECORDER = "Prefab/LickableObject/Recorder";

	public const string PREFAB_REMOTE_CONTROLER = "Prefab/LickableObject/RemoteControler";

	public const string PREFAB_RESPOND_EFFECT = "Prefab/Production/MeshEffect/RespondEffect";

	public const string PREFAB_ROSE_BLACK = "Prefab/LickableObject/RoseBlack";

	public const string PREFAB_ROSE_BLUE = "Prefab/LickableObject/RoseBlue";

	public const string PREFAB_ROSE_RED = "Prefab/LickableObject/RoseRed";

	public const string PREFAB_RULER_SQUARE1 = "Prefab/LickableObject/RulerSquare1";

	public const string PREFAB_SAMURAI_SOCCER = "Prefab/LickableObject/SamuraiSoccer";

	public const string PREFAB_SCORE_ACQUISITION_PRODUCTION_CHARACTER = "Prefab/Production/Reuse/ScoreProduction/ScoreAcquisitionProductionCharacter";

	public const string PREFAB_SCREEN_HOOK = "Prefab/LickableObject/ScreenHook";

	public const string PREFAB_SETTING_BOY = "Prefab/Character/Setting/SettingBoy";

	public const string PREFAB_SETTING_GIRL = "Prefab/Character/Setting/SettingGirl";

	public const string PREFAB_SETTINGS_BLACK_SQUARE_POPUP = "Prefabs/BlackSquaredSkin-Popups/Settings-BlackSquare-Popup";

	public const string PREFAB_SETTINGS_LIGHT_SKIN_POPUP = "Prefabs/LightSkin-Popups/Settings-LightSkin-Popup";

	public const string PREFAB_SETTINGS_POPUP = "Prefabs/DarkSkin-Popups/Settings-Popup";

	public const string PREFAB_SHIRT = "Prefab/LickableObject/Shirt";

	public const string PREFAB_SHOES_L = "Prefab/LickableObject/ShoesL";

	public const string PREFAB_SHOES_R = "Prefab/LickableObject/ShoesR";

	public const string PREFAB_SHOP_BLACK_SQUARE_POPUP = "Prefabs/BlackSquaredSkin-Popups/Shop-BlackSquare-Popup";

	public const string PREFAB_SHOP_LIGHT_SKIN_POPUP = "Prefabs/LightSkin-Popups/Shop-LightSkin-Popup";

	public const string PREFAB_SHOP_POPUP = "Prefabs/DarkSkin-Popups/Shop-Popup";

	public const string PREFAB_SIGN_UP_BLACK_SQUARE_POPUP = "Prefabs/BlackSquaredSkin-Popups/SignUp-BlackSquare-Popup";

	public const string PREFAB_SIGN_UP_LIGHT_SKIN_POPUP = "Prefabs/LightSkin-Popups/SignUp-LightSkin-Popup";

	public const string PREFAB_SIGN_UP_POPUP = "Prefabs/DarkSkin-Popups/SignUp-Popup";

	public const string PREFAB_SLAP_TARGET = "Prefab/SlapTarget";

	public const string PREFAB_SPOON = "Prefab/LickableObject/Spoon";

	public const string PREFAB_STATISTIC_BLACK_SQUARE_POPUP = "Prefabs/BlackSquaredSkin-Popups/Statistic-BlackSquare-Popup";

	public const string PREFAB_STATISTIC_LIGHT_SKIN_POPUP = "Prefabs/LightSkin-Popups/Statistic-LightSkin-Popup";

	public const string PREFAB_STATISTIC_POPUP = "Prefabs/DarkSkin-Popups/Statistic-Popup";

	public const string PREFAB_STEAM_VR_EXTERNAL_CAMERA = "SteamVR_ExternalCamera";

	public const string PREFAB_SUPER_BUTTON = "STMPrefabs/Super Button";

	public const string PREFAB_SUPER_DROPDOWN = "STMPrefabs/Super Dropdown";

	public const string PREFAB_SUPER_INPUT_FIELD = "STMPrefabs/Super InputField";

	public const string PREFAB_SUPER_TEXT = "STMPrefabs/Super Text";

	public const string PREFAB_SUPER_TOGGLE = "STMPrefabs/Super Toggle";

	public const string PREFAB_SWIM_CAP = "Prefab/LickableObject/SwimCap";

	public const string PREFAB_SWIM_SUIT_BOY = "Prefab/LickableObject/SwimSuitBoy";

	public const string PREFAB_SWIM_SUIT_GIRL = "Prefab/LickableObject/SwimSuitGirl";

	public const string PREFAB_TAIONKEI = "Prefab/LickableObject/Taionkei";

	public const string PREFAB_TAPIOCA_TEA = "Prefab/LickableObject/TapiocaTea";

	public const string PREFAB_TAPIOCA_TEA_RAINBOW = "Prefab/LickableObject/TapiocaTeaRainbow";

	public const string PREFAB_TIME_RESUME_EFFECT = "Prefab/Production/Cache/Particle/TimeResumeEffect";

	public const string PREFAB_TIME_STOP_CLOCK = "Prefab/LickableObject/TimeStopClock";

	public const string PREFAB_TIME_STOP_EFFECT = "Prefab/Production/Cache/Particle/TimeStopEffect";

	public const string PREFAB_TOAST = "Prefab/LickableObject/Toast";

	public const string PREFAB_TONGUE = "Prefab/Tongue";

	public const string PREFAB_TOOTH_BRUSH = "Prefab/LickableObject/ToothBrush";

	public const string PREFAB_TOP_BOX = "Prefab/LickableObject/TopBox";

	public const string PREFAB_TRANSPARENT_TUBE = "Prefab/LickableObject/TransparentTube";

	public const string PREFAB_UCHIWA = "Prefab/LickableObject/Uchiwa";

	public const string PREFAB_UMBRELLA = "Prefab/LickableObject/Umbrella";

	public const string PREFAB_USACHAN = "Prefab/LickableObject/Usachan";

	public const string PREFAB_VIDEO_PLAYER_BLACK_SQUARE_POPUP = "Prefabs/BlackSquaredSkin-Popups/VideoPlayer-BlackSquare-Popup";

	public const string PREFAB_VIDEO_PLAYER_LIGHT_SKIN_POPUP = "Prefabs/LightSkin-Popups/VideoPlayer-LightSkin-Popup";

	public const string PREFAB_VIDEO_PLAYER_POPUP = "Prefabs/DarkSkin-Popups/VideoPlayer-Popup";

	public const string PREFAB_VRDEBUG_UIMANAGER = "Prefab/VRDebugUIManager";

	public const string PREFAB_WARNING_BLACK_SQUARE_POPUP = "Prefabs/BlackSquaredSkin-Popups/Warning-BlackSquare-Popup";

	public const string PREFAB_WARNING_LIGHT_SKIN_POPUP = "Prefabs/LightSkin-Popups/Warning-LightSkin-Popup";

	public const string PREFAB_WARNING_POPUP = "Prefabs/DarkSkin-Popups/Warning-Popup";

	public const string PREFAB_WHIP = "Prefab/LickableObject/Whip";

	public const string PREFAB_WIN_BLACK_SQUARE_POPUP = "Prefabs/BlackSquaredSkin-Popups/Win-BlackSquare-Popup";

	public const string PREFAB_WIN_LIGHT_SKIN_POPUP = "Prefabs/LightSkin-Popups/Win-LightSkin-Popup";

	public const string PREFAB_WIN_POPUP = "Prefabs/DarkSkin-Popups/Win-Popup";

	public const string SHADER_ALBEDO_SHADER = "Shaders/AlbedoShader";

	public const string SHADER_ALL_IN1_SPRITE_SHADER = "AllIn1SpriteShader";

	public const string SHADER_ALL_IN1_SPRITE_SHADER_LIGHT = "AllIn1SpriteShaderLight";

	public const string SHADER_ALL_IN1_SPRITE_SHADER_SCROLL_VIEW = "AllIn1SpriteShaderScrollView";

	public const string SHADER_NORMAL_MAP_SHADER = "Shaders/NormalMapShader";

	public const string SHADER_STEAM_VR_ALPHA_OUT = "SteamVR_AlphaOut";

	public const string SHADER_STEAM_VR_CLEAR_ALL = "SteamVR_ClearAll";

	public const string SHADER_STEAM_VR_COLOR_OUT = "SteamVR_ColorOut";

	public const string SHADER_STEAM_VR_FADE = "SteamVR_Fade";

	public const string SHADER_STEAM_VR_SPHERICAL_PROJECTION = "SteamVR_SphericalProjection";

	public const string SHADER_STEREO_RENDER_SHADER = "Shader/StereoRenderShader";

	public const string SHADER_STEREO_RENDER_SHADER_FADE = "Shader/StereoRenderShader-Fade";

	public const string SHADER_STEREO_RENDER_SHADER_SINGLE_TEXTURE = "Shader/StereoRenderShader-SingleTexture";

	public const string SHADER_STEREO_RENDER_SHADER_SINGLE_TEXTURE_UNLIT = "Shader/StereoRenderShader-SingleTexture-Unlit";

	public const string SHADER_STEREO_RENDER_SHADER_UNLIT = "Shader/StereoRenderShader-Unlit";

	public const string SHADER_UNLIT_WITH_ALPHA = "Shaders/UnlitWithAlpha";

	public const string SPRITEATLAS_ACCESSORY_ICON = "Texture/AccessoryIcon";

	public const string SPRITEATLAS_ACHIEVEMENT_ICON = "Texture/AchievementIcon";

	public const string SPRITEATLAS_CHARACTER_SETTING_ICON = "Texture/CharacterSettingIcon";

	public const string SPRITEATLAS_INSTRUCTION_ICON = "Texture/InstructionIcon";

	public const string SPRITEATLAS_PLACE_SETTING_ICON = "Texture/PlaceSettingIcon";

	public const string TEXTURE_BLENDER_BEHAVIOUR_ANALOG_ICON = "Icons/BlenderBehaviour_Analog_Icon";

	public const string TEXTURE_BLENDER_BEHAVIOUR_BOOLEAN_ICON = "Icons/BlenderBehaviour_Boolean_Icon";

	public const string TEXTURE_BLENDER_BEHAVIOUR_MANUAL_ICON = "Icons/BlenderBehaviour_Manual_Icon";

	public const string TEXTURE_HAND_LEFT_ICON = "Icons/HandLeftIcon";

	public const string TEXTUREHANDMASK = "Icons/handmask";

	public const string TEXTUREHANDMASK_INDEX = "Icons/handmask_Index";

	public const string TEXTUREHANDMASK_MIDDLE = "Icons/handmask_Middle";

	public const string TEXTUREHANDMASK_PALM = "Icons/handmask_Palm";

	public const string TEXTUREHANDMASK_PINKY = "Icons/handmask_Pinky";

	public const string TEXTUREHANDMASK_RING = "Icons/handmask_Ring";

	public const string TEXTUREHANDMASK_THUMB = "Icons/handmask_Thumb";

	public const string TEXTURE_HAND_RIGHT_ICON = "Icons/HandRightIcon";
}
public enum ReuseParticleType
{
	AdmirationParticle,
	CountDownParticle,
	CountUpParticle,
	LickeFeverEffect,
	LickeMinusEffect,
	LickePlusEffect
}
public static class SceneName
{
	public const string MAIN = "Main";

	public const string SETTING = "Setting";

	public const string TITLE = "Title";
}
public static class SceneNo
{
	public const int MAIN = 2;

	public const int SETTING = 1;

	public const int TITLE = 0;
}
public static class SortingLayerName
{
	public const string DEFAULT = "Default";
}
public static class TagName
{
	public const string CHALK = "Chalk";

	public const string EDITOR_ONLY = "EditorOnly";

	public const string EFFECTS = "Effects";

	public const string FINISH = "Finish";

	public const string GAME_CONTROLLER = "GameController";

	public const string INGOT = "Ingot";

	public const string INSTRUCTION_UICAMERA = "InstructionUICamera";

	public const string KAN_CROW = "KanCrow";

	public const string MAIN_CAMERA = "MainCamera";

	public const string MIRROR_CAMERA = "MirrorCamera";

	public const string MONEY = "Money";

	public const string PLAYER = "Player";

	public const string RESPAWN = "Respawn";

	public const string UNTAGGED = "Untagged";

	public const string VRCAMERA = "VRCamera";
}
public enum DLCType
{
	DressUp,
	Boy
}
public enum RankingType
{
	Ranking
}
public enum AchievementType
{
	FirstLick,
	FirstStrike,
	FirstTimeUp,
	FirstStoleGameOver,
	FirstLickedGirlGameOver,
	FirstLickedGirlSuccess,
	FirstSpecialItem,
	FirstFever,
	FirstMoney,
	FirstIngot,
	FirstTransparent,
	FirstStopTime,
	KanCrow,
	KillCatFish,
	ChalkRainbow,
	BagContents,
	HiddenCamera,
	ChokerMirror,
	Point1,
	Point2,
	Point3,
	Point4,
	Point5,
	Point6,
	LickedCount1,
	LickedCount2,
	LickedCount3,
	LickedCount4,
	LickedCount5,
	LickedCount6,
	LickedTypes1,
	LickedTypes2,
	LickedTypes3,
	LickedTypes4,
	LickedTypes5,
	LickedTypes6
}
public enum CharacterType
{
	Girl,
	Boy
}
public enum GirlBodyAnimationType
{
	Normal,
	Put,
	FlyHold,
	Bow,
	DiveRoll,
	DiveRollShort,
	Jump,
	Surprise,
	Cry,
	FallLoop,
	Land,
	HeelDrop,
	RoundhouseKick,
	JumpingKick,
	SummerSalt,
	KO,
	ProvocationAttack,
	NotYet,
	Clap,
	Cheer,
	GlorySpin,
	Liedown,
	LiedownSide,
	LiedownOver,
	Looking,
	LookDown
}
public enum GirlFaceAnimationType
{
	Normal,
	Smile,
	Sad,
	Anger,
	Surprise,
	Doubt,
	KO,
	TimeUp1,
	TimeUp2,
	TimeUp3,
	TimeUp4,
	Sleep
}
public enum GirlMoverType
{
	Initial,
	Homecoming,
	NormalReturn,
	ReverseReturn,
	WindowReturn,
	BackDoorReturn,
	BackWindowReturn,
	CorridorBackWindowReturn,
	CorridorWindowReturn,
	GarbageBoxReturn,
	CrouchingReturn,
	ReverseCrouchingReturn,
	CreepingReturn,
	ReverseCreepingReturn,
	TeacherReturn,
	LockerReturn,
	ShelfReturn,
	CeilingReturn,
	ReverseCeilingReturn
}
public enum GirlVoiceType
{
	SerifStartGame,
	SerifFoundGameOverQuiteLowScore,
	SerifFoundGameOverLowScore,
	SerifFoundGameOverHighScore,
	SerifFoundGameOverQuiteHighScore,
	SerifLickedGirlGameOver,
	SerifStoleGameOver,
	SerifTimeUpGameOverQuiteLowScore,
	SerifTimeUpGameOverLowScore,
	SerifTimeUpGameOverHighScore,
	SerifTimeUpGameOverQuiteHighScore,
	SerifAction,
	SerifSurprise
}
public enum GirlEyeMarkType
{
	None,
	Gold,
	Money,
	Heart
}
public enum GirlClothesType
{
	Unique1,
	Unique2,
	Unique3,
	Bra,
	Panty,
	Burma,
	Headphones,
	CatCap,
	CatEar,
	Glasses,
	Sunglasses,
	Goggles,
	EyePatchLeft,
	EyePatchRight,
	Tail,
	Mask,
	GasMask,
	Hannya
}
public enum SettingGirlPlaceType
{
	Initial,
	Bench,
	Bed,
	SimpleBed,
	WeightScale,
	Shelf
}
[Flags]
public enum BonusType
{
	Critical = 1,
	Gold = 2,
	Money = 4,
	Combo = 8,
	Distance = 0x10,
	Girl = 0x20,
	Fever = 0x40
}
public enum GameOverType
{
	Found,
	LickedGirl,
	Stole,
	TimeUp
}
public enum VolumeType
{
	Etc,
	BGM,
	Voice,
	HeartBeat,
	FootStep
}
public enum OperationSettingType
{
	UpDown,
	Rotation
}
public static class Config
{
}
public static class Extension
{
	public const string ASSET = ".asset";

	public const string TXT = ".txt";

	public const string JSON = ".json";

	public const string SCRIPT = ".cs";

	public const string EXCEL = ".xls";

	public const string META = ".meta";

	public const string ARCHIVE = ".a";

	public const string FRAMEWORK = ".framework";

	public const string BUNDLE = ".bundle";

	public const string PREFAB = ".prefab";

	public const string PNG = ".png";

	public const string WAV = ".wav";

	public const string OGG = ".ogg";
}
public static class UserDataKey
{
	public const string LAUNCH_COUNT = "LaunchCount";

	public const string PLAY_COUNT = "PlayCount";

	public const string PLAYING_TIME = "PlayingTime";

	public const string HIGH_SCORE = "HighScore";

	public const string HIGH_SCORE_RECORD = "HighScoreRecord";

	public const string LICKED_COUNT = "LickedCount";

	public const string LICKED_OBJECT_TYPES = "LickedObjectTypes";

	public const string GIRL_VOICE_NO = "GirlVoiceNo";

	public const string HINT_NO = "HintNo";

	public const string ACHIEVEMENT = "Achievement";

	public const string LANGUAGE = "CurrentLanguage";

	public const string STEAM_LANGUAGE = "SteamLanguage";

	public const string IS_INITIALIZED_LANGUAGE = "IsInitializedLanguage";

	public const string VOLUME = "Volume";

	public const string GIRL_CLOTHES = "GirlClothes";

	public const string CHARACTER_TYPE = "CharacterType";

	public const string BGM_NO = "BGMNo";

	public const string SQUAT_FLAG = "SquatFlag";

	public const string SQUAT_VALUE = "SquatValue";

	public const string ROTATION_FLAG = "RotationSquatFlag";

	public const string ROTATION_VALUE = "RotationSquatValue";
}
