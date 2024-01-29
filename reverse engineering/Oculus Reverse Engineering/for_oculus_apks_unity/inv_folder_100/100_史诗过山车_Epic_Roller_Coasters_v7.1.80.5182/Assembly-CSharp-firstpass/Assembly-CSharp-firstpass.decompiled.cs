using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("6.500.7948.23894")]
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000002")]
	public class FollowTarget : MonoBehaviour
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2522B08", Offset = "0x2522B08", VA = "0x2522B08")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2522BE8", Offset = "0x2522BE8", VA = "0x2522BE8")]
		public FollowTarget()
		{
		}
	}
	[Token(Token = "0x2000003")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float height;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float rotationDamping;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float heightDamping;

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2522C48", Offset = "0x2522C48", VA = "0x2522C48")]
		private void Start()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2522C4C", Offset = "0x2522C4C", VA = "0x2522C4C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2522F78", Offset = "0x2522F78", VA = "0x2522F78")]
		public SmoothFollow()
		{
		}
	}
}
namespace UnityStandardAssets.Water
{
	[Token(Token = "0x2000004")]
	[ExecuteInEditMode]
	public class WaterBasic : MonoBehaviour
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2522F8C", Offset = "0x2522F8C", VA = "0x2522F8C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x25231D0", Offset = "0x25231D0", VA = "0x25231D0")]
		public WaterBasic()
		{
		}
	}
}
namespace Sony.NP
{
	[Token(Token = "0x2000005")]
	public class ActivityFeed
	{
		[Token(Token = "0x2000041")]
		public enum FeedType
		{
			[Token(Token = "0x40003BE")]
			Invalid,
			[Token(Token = "0x40003BF")]
			UserFeed,
			[Token(Token = "0x40003C0")]
			UserNews,
			[Token(Token = "0x40003C1")]
			TitleFeed,
			[Token(Token = "0x40003C2")]
			TitleNews
		}

		[Token(Token = "0x2000042")]
		public enum StoryType
		{
			[Token(Token = "0x40003C4")]
			InGamePost,
			[Token(Token = "0x40003C5")]
			PlayedWith,
			[Token(Token = "0x40003C6")]
			VideoUpload,
			[Token(Token = "0x40003C7")]
			Broadcasting
		}

		[Token(Token = "0x2000043")]
		public enum ActionType
		{
			[Token(Token = "0x40003C9")]
			Invalid,
			[Token(Token = "0x40003CA")]
			Url,
			[Token(Token = "0x40003CB")]
			Store,
			[Token(Token = "0x40003CC")]
			StartGame
		}

		[Token(Token = "0x2000044")]
		public struct StoryId
		{
			[Token(Token = "0x40003CD")]
			public const int STORY_ID_LEN = 64;

			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal string id;

			[Token(Token = "0x1700003C")]
			public string Id
			{
				[Token(Token = "0x60001A0")]
				[Address(RVA = "0x24D9640", Offset = "0x24D9640", VA = "0x24D9640")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001A1")]
				[Address(RVA = "0x24D9648", Offset = "0x24D9648", VA = "0x24D9648")]
				set
				{
				}
			}

			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x24D87BC", Offset = "0x24D87BC", VA = "0x24D87BC")]
			internal void Read(MemoryBuffer buffer)
			{
			}
		}

		[Token(Token = "0x2000045")]
		public struct Caption
		{
			[Token(Token = "0x40003CF")]
			public const int CAPTION_MAX_LEN = 511;

			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal string languageCode;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal string caption;

			[Token(Token = "0x1700003D")]
			public Core.LanguageCode LanguageCode
			{
				[Token(Token = "0x60001A3")]
				[Address(RVA = "0x24D7ABC", Offset = "0x24D7ABC", VA = "0x24D7ABC")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001A4")]
				[Address(RVA = "0x24D7B28", Offset = "0x24D7B28", VA = "0x24D7B28")]
				set
				{
				}
			}

			[Token(Token = "0x1700003E")]
			public string CaptionText
			{
				[Token(Token = "0x60001A5")]
				[Address(RVA = "0x24D7B44", Offset = "0x24D7B44", VA = "0x24D7B44")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001A6")]
				[Address(RVA = "0x24D7B4C", Offset = "0x24D7B4C", VA = "0x24D7B4C")]
				set
				{
				}
			}

			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x24D7C30", Offset = "0x24D7C30", VA = "0x24D7C30")]
			internal void Read(MemoryBuffer buffer)
			{
			}
		}

		[Token(Token = "0x2000046")]
		public struct Media
		{
			[Token(Token = "0x40003D2")]
			public const int URL_MAX_LEN = 255;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal string largeImageUrl;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal string videoUrl;

			[Token(Token = "0x1700003F")]
			public string LargeImageUrl
			{
				[Token(Token = "0x60001A8")]
				[Address(RVA = "0x24D8118", Offset = "0x24D8118", VA = "0x24D8118")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001A9")]
				[Address(RVA = "0x24D8120", Offset = "0x24D8120", VA = "0x24D8120")]
				set
				{
				}
			}

			[Token(Token = "0x17000040")]
			public string VideoUrl
			{
				[Token(Token = "0x60001AA")]
				[Address(RVA = "0x24D8204", Offset = "0x24D8204", VA = "0x24D8204")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001AB")]
				[Address(RVA = "0x24D820C", Offset = "0x24D820C", VA = "0x24D820C")]
				set
				{
				}
			}

			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x24D82F0", Offset = "0x24D82F0", VA = "0x24D82F0")]
			internal void Read(MemoryBuffer buffer)
			{
			}
		}

		[Token(Token = "0x2000047")]
		public struct ButtonCaption
		{
			[Token(Token = "0x40003D5")]
			public const int TEXT_MAX_LEN = 20;

			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal string languageCode;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal string text;

			[Token(Token = "0x17000041")]
			public Core.LanguageCode LanguageCode
			{
				[Token(Token = "0x60001AD")]
				[Address(RVA = "0x24D78EC", Offset = "0x24D78EC", VA = "0x24D78EC")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001AE")]
				[Address(RVA = "0x24D79B4", Offset = "0x24D79B4", VA = "0x24D79B4")]
				set
				{
				}
			}

			[Token(Token = "0x17000042")]
			public string Text
			{
				[Token(Token = "0x60001AF")]
				[Address(RVA = "0x24D79D0", Offset = "0x24D79D0", VA = "0x24D79D0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001B0")]
				[Address(RVA = "0x24D79D8", Offset = "0x24D79D8", VA = "0x24D79D8")]
				set
				{
				}
			}
		}

		[Token(Token = "0x2000048")]
		public struct Action
		{
			[Token(Token = "0x40003D8")]
			public const int MAX_BUTTON_CAPTIONS = 32;

			[Token(Token = "0x40003D9")]
			public const int URL_MAX_LEN = 255;

			[Token(Token = "0x40003DA")]
			public const int STORE_LABEL_MAX_LEN = 31;

			[Token(Token = "0x40003DB")]
			public const int START_GAME_ARGS_MAX = 2083;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal string imageUrl;

			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal string uri;

			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal string storeLabel;

			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal string startGameArguments;

			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal ButtonCaption[] buttonCaptions;

			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal uint storeServiceLabel;

			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal ActionType type;

			[Token(Token = "0x17000043")]
			public string ImageUrl
			{
				[Token(Token = "0x60001B1")]
				[Address(RVA = "0x24D73A0", Offset = "0x24D73A0", VA = "0x24D73A0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001B2")]
				[Address(RVA = "0x24D73A8", Offset = "0x24D73A8", VA = "0x24D73A8")]
				set
				{
				}
			}

			[Token(Token = "0x17000044")]
			public string Uri
			{
				[Token(Token = "0x60001B3")]
				[Address(RVA = "0x24D748C", Offset = "0x24D748C", VA = "0x24D748C")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001B4")]
				[Address(RVA = "0x24D7494", Offset = "0x24D7494", VA = "0x24D7494")]
				set
				{
				}
			}

			[Token(Token = "0x17000045")]
			public string StoreLabel
			{
				[Token(Token = "0x60001B5")]
				[Address(RVA = "0x24D7578", Offset = "0x24D7578", VA = "0x24D7578")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001B6")]
				[Address(RVA = "0x24D7580", Offset = "0x24D7580", VA = "0x24D7580")]
				set
				{
				}
			}

			[Token(Token = "0x17000046")]
			public string StartGameArguments
			{
				[Token(Token = "0x60001B7")]
				[Address(RVA = "0x24D7664", Offset = "0x24D7664", VA = "0x24D7664")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001B8")]
				[Address(RVA = "0x24D766C", Offset = "0x24D766C", VA = "0x24D766C")]
				set
				{
				}
			}

			[Token(Token = "0x17000047")]
			public ButtonCaption[] ButtonCaptions
			{
				[Token(Token = "0x60001B9")]
				[Address(RVA = "0x24D7750", Offset = "0x24D7750", VA = "0x24D7750")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001BA")]
				[Address(RVA = "0x24D77C4", Offset = "0x24D77C4", VA = "0x24D77C4")]
				set
				{
				}
			}

			[Token(Token = "0x17000048")]
			public uint StoreServiceLabel
			{
				[Token(Token = "0x60001BB")]
				[Address(RVA = "0x24D78CC", Offset = "0x24D78CC", VA = "0x24D78CC")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x60001BC")]
				[Address(RVA = "0x24D78D4", Offset = "0x24D78D4", VA = "0x24D78D4")]
				set
				{
				}
			}

			[Token(Token = "0x17000049")]
			public ActionType ActionType
			{
				[Token(Token = "0x60001BD")]
				[Address(RVA = "0x24D78DC", Offset = "0x24D78DC", VA = "0x24D78DC")]
				get
				{
					return default(ActionType);
				}
				[Token(Token = "0x60001BE")]
				[Address(RVA = "0x24D78E4", Offset = "0x24D78E4", VA = "0x24D78E4")]
				set
				{
				}
			}
		}

		[Token(Token = "0x2000049")]
		public class StoryUser
		{
			[Token(Token = "0x40003E3")]
			public const int URL_MAX_LEN = 255;

			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Core.OnlineUser user;

			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal string avatarUrl;

			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Profiles.RealName realName;

			[Token(Token = "0x1700004A")]
			public Core.OnlineUser User
			{
				[Token(Token = "0x60001BF")]
				[Address(RVA = "0x24D972C", Offset = "0x24D972C", VA = "0x24D972C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004B")]
			public string AvatarUrl
			{
				[Token(Token = "0x60001C0")]
				[Address(RVA = "0x24D9734", Offset = "0x24D9734", VA = "0x24D9734")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004C")]
			public Profiles.RealName RealName
			{
				[Token(Token = "0x60001C1")]
				[Address(RVA = "0x24D973C", Offset = "0x24D973C", VA = "0x24D973C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x24D8864", Offset = "0x24D8864", VA = "0x24D8864")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x24D87E0", Offset = "0x24D87E0", VA = "0x24D87E0")]
			public StoryUser()
			{
			}
		}

		[Token(Token = "0x200004A")]
		public class Story
		{
			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal string creationDate;

			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal string userComment;

			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Media media;

			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal StoryId storyId;

			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal Caption caption;

			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal StoryType storyType;

			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			internal int subType;

			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal StoryUser postCreator;

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal uint numLikes;

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			internal uint numComments;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal bool isReshareable;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
			internal bool isLiked;

			[Token(Token = "0x1700004D")]
			public string CreationDate
			{
				[Token(Token = "0x60001C4")]
				[Address(RVA = "0x24D95D8", Offset = "0x24D95D8", VA = "0x24D95D8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004E")]
			public string UserComment
			{
				[Token(Token = "0x60001C5")]
				[Address(RVA = "0x24D95E0", Offset = "0x24D95E0", VA = "0x24D95E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004F")]
			public Media Media
			{
				[Token(Token = "0x60001C6")]
				[Address(RVA = "0x24D95E8", Offset = "0x24D95E8", VA = "0x24D95E8")]
				get
				{
					return default(Media);
				}
			}

			[Token(Token = "0x17000050")]
			public StoryId StoryId
			{
				[Token(Token = "0x60001C7")]
				[Address(RVA = "0x24D95F4", Offset = "0x24D95F4", VA = "0x24D95F4")]
				get
				{
					return default(StoryId);
				}
			}

			[Token(Token = "0x17000051")]
			public Caption Caption
			{
				[Token(Token = "0x60001C8")]
				[Address(RVA = "0x24D95FC", Offset = "0x24D95FC", VA = "0x24D95FC")]
				get
				{
					return default(Caption);
				}
			}

			[Token(Token = "0x17000052")]
			public StoryType StoryType
			{
				[Token(Token = "0x60001C9")]
				[Address(RVA = "0x24D9608", Offset = "0x24D9608", VA = "0x24D9608")]
				get
				{
					return default(StoryType);
				}
			}

			[Token(Token = "0x17000053")]
			public int SubType
			{
				[Token(Token = "0x60001CA")]
				[Address(RVA = "0x24D9610", Offset = "0x24D9610", VA = "0x24D9610")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000054")]
			public StoryUser PostCreator
			{
				[Token(Token = "0x60001CB")]
				[Address(RVA = "0x24D9618", Offset = "0x24D9618", VA = "0x24D9618")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000055")]
			public uint NumLikes
			{
				[Token(Token = "0x60001CC")]
				[Address(RVA = "0x24D9620", Offset = "0x24D9620", VA = "0x24D9620")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x17000056")]
			public uint NumComments
			{
				[Token(Token = "0x60001CD")]
				[Address(RVA = "0x24D9628", Offset = "0x24D9628", VA = "0x24D9628")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x17000057")]
			public bool IsReshareable
			{
				[Token(Token = "0x60001CE")]
				[Address(RVA = "0x24D9630", Offset = "0x24D9630", VA = "0x24D9630")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000058")]
			public bool IsLiked
			{
				[Token(Token = "0x60001CF")]
				[Address(RVA = "0x24D9638", Offset = "0x24D9638", VA = "0x24D9638")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x24D7F00", Offset = "0x24D7F00", VA = "0x24D7F00")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x24D7E9C", Offset = "0x24D7E9C", VA = "0x24D7E9C")]
			public Story()
			{
			}
		}

		[Token(Token = "0x200004B")]
		public class PlayedWithStory
		{
			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal StoryId storyId;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal StoryUser[] users;

			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal string titleName;

			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal string date;

			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Core.TitleId titleId;

			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal string playedWithDescription;

			[Token(Token = "0x17000059")]
			public StoryId StoryId
			{
				[Token(Token = "0x60001D2")]
				[Address(RVA = "0x24D878C", Offset = "0x24D878C", VA = "0x24D878C")]
				get
				{
					return default(StoryId);
				}
			}

			[Token(Token = "0x1700005A")]
			public StoryUser[] Users
			{
				[Token(Token = "0x60001D3")]
				[Address(RVA = "0x24D8794", Offset = "0x24D8794", VA = "0x24D8794")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005B")]
			public string TitleName
			{
				[Token(Token = "0x60001D4")]
				[Address(RVA = "0x24D879C", Offset = "0x24D879C", VA = "0x24D879C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005C")]
			public string Date
			{
				[Token(Token = "0x60001D5")]
				[Address(RVA = "0x24D87A4", Offset = "0x24D87A4", VA = "0x24D87A4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005D")]
			public Core.TitleId TitleId
			{
				[Token(Token = "0x60001D6")]
				[Address(RVA = "0x24D87AC", Offset = "0x24D87AC", VA = "0x24D87AC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005E")]
			public string PlayedWithDescription
			{
				[Token(Token = "0x60001D7")]
				[Address(RVA = "0x24D87B4", Offset = "0x24D87B4", VA = "0x24D87B4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x24D85C0", Offset = "0x24D85C0", VA = "0x24D85C0")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x24D855C", Offset = "0x24D855C", VA = "0x24D855C")]
			public PlayedWithStory()
			{
			}
		}

		[Token(Token = "0x200004C")]
		public class SharedVideo
		{
			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal StoryId storyId;

			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Caption caption;

			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal StoryUser sourceCreator;

			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal string snType;

			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal string videoId;

			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal string creationDate;

			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal string videoDuration;

			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal string comment;

			[Token(Token = "0x1700005F")]
			public StoryId StoryId
			{
				[Token(Token = "0x60001DA")]
				[Address(RVA = "0x24D9240", Offset = "0x24D9240", VA = "0x24D9240")]
				get
				{
					return default(StoryId);
				}
			}

			[Token(Token = "0x17000060")]
			public Caption Caption
			{
				[Token(Token = "0x60001DB")]
				[Address(RVA = "0x24D9248", Offset = "0x24D9248", VA = "0x24D9248")]
				get
				{
					return default(Caption);
				}
			}

			[Token(Token = "0x17000061")]
			public StoryUser SourceCreator
			{
				[Token(Token = "0x60001DC")]
				[Address(RVA = "0x24D9254", Offset = "0x24D9254", VA = "0x24D9254")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000062")]
			public string SNType
			{
				[Token(Token = "0x60001DD")]
				[Address(RVA = "0x24D925C", Offset = "0x24D925C", VA = "0x24D925C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000063")]
			public string VideoId
			{
				[Token(Token = "0x60001DE")]
				[Address(RVA = "0x24D9264", Offset = "0x24D9264", VA = "0x24D9264")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000064")]
			public string CreationDate
			{
				[Token(Token = "0x60001DF")]
				[Address(RVA = "0x24D926C", Offset = "0x24D926C", VA = "0x24D926C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000065")]
			public string VideoDuration
			{
				[Token(Token = "0x60001E0")]
				[Address(RVA = "0x24D9274", Offset = "0x24D9274", VA = "0x24D9274")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			public string Comment
			{
				[Token(Token = "0x60001E1")]
				[Address(RVA = "0x24D927C", Offset = "0x24D927C", VA = "0x24D927C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x24D9284", Offset = "0x24D9284", VA = "0x24D9284")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x24D9344", Offset = "0x24D9344", VA = "0x24D9344")]
			public SharedVideo()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x200004D")]
		public class GetFeedRequest : RequestBase
		{
			[Token(Token = "0x4000401")]
			public const int MAX_PAGE_SIZE = 100;

			[Token(Token = "0x4000402")]
			public const int DEFAULT_PAGE_SIZE = 20;

			[Token(Token = "0x4000403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Core.NpAccountId user;

			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal FeedType feedType;

			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal uint offset;

			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal uint pageSize;

			[Token(Token = "0x17000067")]
			public Core.NpAccountId User
			{
				[Token(Token = "0x60001E4")]
				[Address(RVA = "0x24D8010", Offset = "0x24D8010", VA = "0x24D8010")]
				get
				{
					return default(Core.NpAccountId);
				}
				[Token(Token = "0x60001E5")]
				[Address(RVA = "0x24D8018", Offset = "0x24D8018", VA = "0x24D8018")]
				set
				{
				}
			}

			[Token(Token = "0x17000068")]
			public FeedType FeedType
			{
				[Token(Token = "0x60001E6")]
				[Address(RVA = "0x24D8020", Offset = "0x24D8020", VA = "0x24D8020")]
				get
				{
					return default(FeedType);
				}
				[Token(Token = "0x60001E7")]
				[Address(RVA = "0x24D8028", Offset = "0x24D8028", VA = "0x24D8028")]
				set
				{
				}
			}

			[Token(Token = "0x17000069")]
			public uint Offset
			{
				[Token(Token = "0x60001E8")]
				[Address(RVA = "0x24D8030", Offset = "0x24D8030", VA = "0x24D8030")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x60001E9")]
				[Address(RVA = "0x24D8038", Offset = "0x24D8038", VA = "0x24D8038")]
				set
				{
				}
			}

			[Token(Token = "0x1700006A")]
			public uint PageSize
			{
				[Token(Token = "0x60001EA")]
				[Address(RVA = "0x24D8040", Offset = "0x24D8040", VA = "0x24D8040")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x60001EB")]
				[Address(RVA = "0x24D8048", Offset = "0x24D8048", VA = "0x24D8048")]
				set
				{
				}
			}

			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x24D8050", Offset = "0x24D8050", VA = "0x24D8050")]
			public GetFeedRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x200004E")]
		public class PostInGameStoryRequest : RequestBase
		{
			[Token(Token = "0x4000407")]
			public const int USER_COMMENT_MAX_LEN = 1000;

			[Token(Token = "0x4000408")]
			public const int MAX_ACTIONS = 3;

			[Token(Token = "0x4000409")]
			public const int MAX_CAPTIONS = 1024;

			[Token(Token = "0x400040A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Action[] actions;

			[Token(Token = "0x400040B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Caption[] captions;

			[Token(Token = "0x400040C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private uint numCaptions;

			[Token(Token = "0x400040D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal Caption[] condensedCaptions;

			[Token(Token = "0x400040E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private uint numCondensedCaptions;

			[Token(Token = "0x400040F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal Media media;

			[Token(Token = "0x4000410")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal int subType;

			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			internal string userComment;

			[Token(Token = "0x1700006B")]
			public Action[] Actions
			{
				[Token(Token = "0x60001ED")]
				[Address(RVA = "0x24D8994", Offset = "0x24D8994", VA = "0x24D8994")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001EE")]
				[Address(RVA = "0x24D8A08", Offset = "0x24D8A08", VA = "0x24D8A08")]
				set
				{
				}
			}

			[Token(Token = "0x1700006C")]
			public Caption[] Captions
			{
				[Token(Token = "0x60001EF")]
				[Address(RVA = "0x24D8B10", Offset = "0x24D8B10", VA = "0x24D8B10")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001F0")]
				[Address(RVA = "0x24D8B84", Offset = "0x24D8B84", VA = "0x24D8B84")]
				set
				{
				}
			}

			[Token(Token = "0x1700006D")]
			public Caption[] CondensedCaptions
			{
				[Token(Token = "0x60001F1")]
				[Address(RVA = "0x24D8C90", Offset = "0x24D8C90", VA = "0x24D8C90")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001F2")]
				[Address(RVA = "0x24D8D04", Offset = "0x24D8D04", VA = "0x24D8D04")]
				set
				{
				}
			}

			[Token(Token = "0x1700006E")]
			public Media Media
			{
				[Token(Token = "0x60001F3")]
				[Address(RVA = "0x24D8E10", Offset = "0x24D8E10", VA = "0x24D8E10")]
				get
				{
					return default(Media);
				}
				[Token(Token = "0x60001F4")]
				[Address(RVA = "0x24D8E1C", Offset = "0x24D8E1C", VA = "0x24D8E1C")]
				set
				{
				}
			}

			[Token(Token = "0x1700006F")]
			public int SubType
			{
				[Token(Token = "0x60001F5")]
				[Address(RVA = "0x24D8E24", Offset = "0x24D8E24", VA = "0x24D8E24")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60001F6")]
				[Address(RVA = "0x24D8E2C", Offset = "0x24D8E2C", VA = "0x24D8E2C")]
				set
				{
				}
			}

			[Token(Token = "0x17000070")]
			public string UserComment
			{
				[Token(Token = "0x60001F7")]
				[Address(RVA = "0x24D8E34", Offset = "0x24D8E34", VA = "0x24D8E34")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001F8")]
				[Address(RVA = "0x24D8E3C", Offset = "0x24D8E3C", VA = "0x24D8E3C")]
				set
				{
				}
			}

			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x24D8F20", Offset = "0x24D8F20", VA = "0x24D8F20")]
			public PostInGameStoryRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x200004F")]
		public class SetLikedRequest : RequestBase
		{
			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal StoryId storyId;

			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal bool isLiked;

			[Token(Token = "0x17000071")]
			public StoryId StoryId
			{
				[Token(Token = "0x60001FA")]
				[Address(RVA = "0x24D920C", Offset = "0x24D920C", VA = "0x24D920C")]
				get
				{
					return default(StoryId);
				}
				[Token(Token = "0x60001FB")]
				[Address(RVA = "0x24D9214", Offset = "0x24D9214", VA = "0x24D9214")]
				set
				{
				}
			}

			[Token(Token = "0x17000072")]
			public bool IsLiked
			{
				[Token(Token = "0x60001FC")]
				[Address(RVA = "0x24D921C", Offset = "0x24D921C", VA = "0x24D921C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001FD")]
				[Address(RVA = "0x24D9224", Offset = "0x24D9224", VA = "0x24D9224")]
				set
				{
				}
			}

			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x24D9230", Offset = "0x24D9230", VA = "0x24D9230")]
			public SetLikedRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x2000050")]
		public class GetWhoLikedRequest : RequestBase
		{
			[Token(Token = "0x4000414")]
			public const int MAX_PAGE_SIZE = 100;

			[Token(Token = "0x4000415")]
			public const int DEFAULT_PAGE_SIZE = 20;

			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Core.NpAccountId lastUserRetrieved;

			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal StoryId storyId;

			[Token(Token = "0x4000418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal uint pageSize;

			[Token(Token = "0x17000073")]
			public Core.NpAccountId LastUserRetrieved
			{
				[Token(Token = "0x60001FF")]
				[Address(RVA = "0x24D80B4", Offset = "0x24D80B4", VA = "0x24D80B4")]
				get
				{
					return default(Core.NpAccountId);
				}
				[Token(Token = "0x6000200")]
				[Address(RVA = "0x24D80BC", Offset = "0x24D80BC", VA = "0x24D80BC")]
				set
				{
				}
			}

			[Token(Token = "0x17000074")]
			public StoryId StoryId
			{
				[Token(Token = "0x6000201")]
				[Address(RVA = "0x24D80C4", Offset = "0x24D80C4", VA = "0x24D80C4")]
				get
				{
					return default(StoryId);
				}
				[Token(Token = "0x6000202")]
				[Address(RVA = "0x24D80CC", Offset = "0x24D80CC", VA = "0x24D80CC")]
				set
				{
				}
			}

			[Token(Token = "0x17000075")]
			public uint PageSize
			{
				[Token(Token = "0x6000203")]
				[Address(RVA = "0x24D80D4", Offset = "0x24D80D4", VA = "0x24D80D4")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x6000204")]
				[Address(RVA = "0x24D80DC", Offset = "0x24D80DC", VA = "0x24D80DC")]
				set
				{
				}
			}

			[Token(Token = "0x6000205")]
			[Address(RVA = "0x24D80E4", Offset = "0x24D80E4", VA = "0x24D80E4")]
			public GetWhoLikedRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x2000051")]
		public class PostPlayedWithRequest : RequestBase
		{
			[Token(Token = "0x4000419")]
			public const int DESCRIPTION_MAX_LEN = 2083;

			[Token(Token = "0x400041A")]
			public const int MAX_USERS = 19;

			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Core.NpAccountId[] userIds;

			[Token(Token = "0x400041C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal uint numUsers;

			[Token(Token = "0x400041D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal string playedWithDescription;

			[Token(Token = "0x17000076")]
			public Core.NpAccountId[] UserIds
			{
				[Token(Token = "0x6000206")]
				[Address(RVA = "0x24D8F8C", Offset = "0x24D8F8C", VA = "0x24D8F8C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000207")]
				[Address(RVA = "0x24D9000", Offset = "0x24D9000", VA = "0x24D9000")]
				set
				{
				}
			}

			[Token(Token = "0x17000077")]
			public string PlayedWithDescription
			{
				[Token(Token = "0x6000208")]
				[Address(RVA = "0x24D9110", Offset = "0x24D9110", VA = "0x24D9110")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000209")]
				[Address(RVA = "0x24D9118", Offset = "0x24D9118", VA = "0x24D9118")]
				set
				{
				}
			}

			[Token(Token = "0x600020A")]
			[Address(RVA = "0x24D91FC", Offset = "0x24D91FC", VA = "0x24D91FC")]
			public PostPlayedWithRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x2000052")]
		public class GetPlayedWithRequest : RequestBase
		{
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x24D8084", Offset = "0x24D8084", VA = "0x24D8084")]
			public GetPlayedWithRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x2000053")]
		public class GetSharedVideosRequest : RequestBase
		{
			[Token(Token = "0x400041E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Core.NpAccountId user;

			[Token(Token = "0x17000078")]
			public Core.NpAccountId User
			{
				[Token(Token = "0x600020C")]
				[Address(RVA = "0x24D8094", Offset = "0x24D8094", VA = "0x24D8094")]
				get
				{
					return default(Core.NpAccountId);
				}
				[Token(Token = "0x600020D")]
				[Address(RVA = "0x24D809C", Offset = "0x24D809C", VA = "0x24D809C")]
				set
				{
				}
			}

			[Token(Token = "0x600020E")]
			[Address(RVA = "0x24D80A4", Offset = "0x24D80A4", VA = "0x24D80A4")]
			public GetSharedVideosRequest()
			{
			}
		}

		[Token(Token = "0x2000054")]
		public class FeedResponse : ResponseBase
		{
			[Token(Token = "0x400041F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Story[] stories;

			[Token(Token = "0x17000079")]
			public Story[] Stories
			{
				[Token(Token = "0x600020F")]
				[Address(RVA = "0x24D7C74", Offset = "0x24D7C74", VA = "0x24D7C74")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000210")]
			[Address(RVA = "0x24D7C7C", Offset = "0x24D7C7C", VA = "0x24D7C7C", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x6000211")]
			[Address(RVA = "0x24D8008", Offset = "0x24D8008", VA = "0x24D8008")]
			public FeedResponse()
			{
			}
		}

		[Token(Token = "0x2000055")]
		public class UsersWhoLikedResponse : ResponseBase
		{
			[Token(Token = "0x4000420")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal StoryUser[] users;

			[Token(Token = "0x1700007A")]
			public StoryUser[] Users
			{
				[Token(Token = "0x6000212")]
				[Address(RVA = "0x24D9814", Offset = "0x24D9814", VA = "0x24D9814")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000213")]
			[Address(RVA = "0x24D981C", Offset = "0x24D981C", VA = "0x24D981C", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x6000214")]
			[Address(RVA = "0x24D9A3C", Offset = "0x24D9A3C", VA = "0x24D9A3C")]
			public UsersWhoLikedResponse()
			{
			}
		}

		[Token(Token = "0x2000056")]
		public class PlayedWithFeedResponse : ResponseBase
		{
			[Token(Token = "0x4000421")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal PlayedWithStory[] stories;

			[Token(Token = "0x1700007B")]
			public PlayedWithStory[] Stories
			{
				[Token(Token = "0x6000215")]
				[Address(RVA = "0x24D8334", Offset = "0x24D8334", VA = "0x24D8334")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000216")]
			[Address(RVA = "0x24D833C", Offset = "0x24D833C", VA = "0x24D833C", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x6000217")]
			[Address(RVA = "0x24D8784", Offset = "0x24D8784", VA = "0x24D8784")]
			public PlayedWithFeedResponse()
			{
			}
		}

		[Token(Token = "0x2000057")]
		public class SharedVideosResponse : ResponseBase
		{
			[Token(Token = "0x4000422")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal SharedVideo[] videos;

			[Token(Token = "0x1700007C")]
			public SharedVideo[] Videos
			{
				[Token(Token = "0x6000218")]
				[Address(RVA = "0x24D93A8", Offset = "0x24D93A8", VA = "0x24D93A8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000219")]
			[Address(RVA = "0x24D93B0", Offset = "0x24D93B0", VA = "0x24D93B0", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x600021A")]
			[Address(RVA = "0x24D95D0", Offset = "0x24D95D0", VA = "0x24D95D0")]
			public SharedVideosResponse()
			{
			}
		}

		[PreserveSig]
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x24D6600", Offset = "0x24D6600", VA = "0x24D6600")]
		private static extern int PrxGetFeed(GetFeedRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x24D66D8", Offset = "0x24D66D8", VA = "0x24D66D8")]
		private static extern int PrxPostInGameStory(PostInGameStoryRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x24D67A8", Offset = "0x24D67A8", VA = "0x24D67A8")]
		private static extern int PrxSetLiked(SetLikedRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x24D686C", Offset = "0x24D686C", VA = "0x24D686C")]
		private static extern int PrxGetWhoLiked(GetWhoLikedRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x24D6930", Offset = "0x24D6930", VA = "0x24D6930")]
		private static extern int PrxPostPlayedWith(PostPlayedWithRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x24D69F4", Offset = "0x24D69F4", VA = "0x24D69F4")]
		private static extern int PrxGetPlayedWith(GetPlayedWithRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x24D6AAC", Offset = "0x24D6AAC", VA = "0x24D6AAC")]
		private static extern int PrxGetSharedVideos(GetSharedVideosRequest request, out APIResult result);

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x24D6B70", Offset = "0x24D6B70", VA = "0x24D6B70")]
		public static int PostInGameStory(PostInGameStoryRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x24D6C7C", Offset = "0x24D6C7C", VA = "0x24D6C7C")]
		public static int GetFeed(GetFeedRequest request, FeedResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x24D6E5C", Offset = "0x24D6E5C", VA = "0x24D6E5C")]
		public static int SetLiked(SetLikedRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x24D6F68", Offset = "0x24D6F68", VA = "0x24D6F68")]
		public static int GetWhoLiked(GetWhoLikedRequest request, UsersWhoLikedResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x24D7074", Offset = "0x24D7074", VA = "0x24D7074")]
		public static int PostPlayedWith(PostPlayedWithRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x24D7180", Offset = "0x24D7180", VA = "0x24D7180")]
		public static int GetPlayedWith(GetPlayedWithRequest request, PlayedWithFeedResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x24D728C", Offset = "0x24D728C", VA = "0x24D728C")]
		public static int GetSharedVideos(GetSharedVideosRequest request, SharedVideosResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x24D7398", Offset = "0x24D7398", VA = "0x24D7398")]
		public ActivityFeed()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class Auth
	{
		[Token(Token = "0x2000058")]
		public struct NpClientId
		{
			[Token(Token = "0x4000423")]
			public const int NP_CLIENT_ID_MAX_LEN = 128;

			[Token(Token = "0x4000424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal string id;

			[Token(Token = "0x1700007D")]
			public string Id
			{
				[Token(Token = "0x600021B")]
				[Address(RVA = "0x24DA424", Offset = "0x24DA424", VA = "0x24DA424")]
				get
				{
					return null;
				}
				[Token(Token = "0x600021C")]
				[Address(RVA = "0x24DA42C", Offset = "0x24DA42C", VA = "0x24DA42C")]
				set
				{
				}
			}
		}

		[Token(Token = "0x2000059")]
		public struct NpClientSecret
		{
			[Token(Token = "0x4000425")]
			public const int NP_CLIENT_SECRET_MAX_LEN = 256;

			[Token(Token = "0x4000426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal string secret;

			[Token(Token = "0x1700007E")]
			public string Secret
			{
				[Token(Token = "0x600021D")]
				[Address(RVA = "0x24DA510", Offset = "0x24DA510", VA = "0x24DA510")]
				get
				{
					return null;
				}
				[Token(Token = "0x600021E")]
				[Address(RVA = "0x24DA518", Offset = "0x24DA518", VA = "0x24DA518")]
				set
				{
				}
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x200005A")]
		public class GetAuthCodeRequest : RequestBase
		{
			[Token(Token = "0x4000427")]
			public const int MAX_SIZE_SCOPE = 511;

			[Token(Token = "0x4000428")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal NpClientId clientId;

			[Token(Token = "0x4000429")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal string scope;

			[Token(Token = "0x1700007F")]
			public NpClientId ClientId
			{
				[Token(Token = "0x600021F")]
				[Address(RVA = "0x24DA0B8", Offset = "0x24DA0B8", VA = "0x24DA0B8")]
				get
				{
					return default(NpClientId);
				}
				[Token(Token = "0x6000220")]
				[Address(RVA = "0x24DA0C0", Offset = "0x24DA0C0", VA = "0x24DA0C0")]
				set
				{
				}
			}

			[Token(Token = "0x17000080")]
			public string Scope
			{
				[Token(Token = "0x6000221")]
				[Address(RVA = "0x24DA0C8", Offset = "0x24DA0C8", VA = "0x24DA0C8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000222")]
				[Address(RVA = "0x24DA0D0", Offset = "0x24DA0D0", VA = "0x24DA0D0")]
				set
				{
				}
			}

			[Token(Token = "0x6000223")]
			[Address(RVA = "0x24DA1B4", Offset = "0x24DA1B4", VA = "0x24DA1B4")]
			public GetAuthCodeRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x200005B")]
		public class GetIdTokenRequest : RequestBase
		{
			[Token(Token = "0x400042A")]
			public const int MAX_SIZE_SCOPE = 511;

			[Token(Token = "0x400042B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal NpClientId clientId;

			[Token(Token = "0x400042C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal NpClientSecret clientSecret;

			[Token(Token = "0x400042D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal string scope;

			[Token(Token = "0x17000081")]
			public NpClientId ClientId
			{
				[Token(Token = "0x6000224")]
				[Address(RVA = "0x24DA1C4", Offset = "0x24DA1C4", VA = "0x24DA1C4")]
				get
				{
					return default(NpClientId);
				}
				[Token(Token = "0x6000225")]
				[Address(RVA = "0x24DA1CC", Offset = "0x24DA1CC", VA = "0x24DA1CC")]
				set
				{
				}
			}

			[Token(Token = "0x17000082")]
			public NpClientSecret ClientSecret
			{
				[Token(Token = "0x6000226")]
				[Address(RVA = "0x24DA1D4", Offset = "0x24DA1D4", VA = "0x24DA1D4")]
				get
				{
					return default(NpClientSecret);
				}
				[Token(Token = "0x6000227")]
				[Address(RVA = "0x24DA1DC", Offset = "0x24DA1DC", VA = "0x24DA1DC")]
				set
				{
				}
			}

			[Token(Token = "0x17000083")]
			public string Scope
			{
				[Token(Token = "0x6000228")]
				[Address(RVA = "0x24DA1E4", Offset = "0x24DA1E4", VA = "0x24DA1E4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000229")]
				[Address(RVA = "0x24DA1EC", Offset = "0x24DA1EC", VA = "0x24DA1EC")]
				set
				{
				}
			}

			[Token(Token = "0x600022A")]
			[Address(RVA = "0x24DA2D0", Offset = "0x24DA2D0", VA = "0x24DA2D0")]
			public GetIdTokenRequest()
			{
			}
		}

		[Token(Token = "0x200005C")]
		public enum IssuerIdType
		{
			[Token(Token = "0x400042F")]
			Invalid = -1,
			[Token(Token = "0x4000430")]
			Development = 1,
			[Token(Token = "0x4000431")]
			Certification = 8,
			[Token(Token = "0x4000432")]
			Live = 256
		}

		[Token(Token = "0x200005D")]
		public class AuthCodeResponse : ResponseBase
		{
			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal string authCode;

			[Token(Token = "0x4000434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal IssuerIdType issuerId;

			[Token(Token = "0x17000084")]
			public string AuthCode
			{
				[Token(Token = "0x600022B")]
				[Address(RVA = "0x24D9F5C", Offset = "0x24D9F5C", VA = "0x24D9F5C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000085")]
			public IssuerIdType IssuerId
			{
				[Token(Token = "0x600022C")]
				[Address(RVA = "0x24D9F64", Offset = "0x24D9F64", VA = "0x24D9F64")]
				get
				{
					return default(IssuerIdType);
				}
			}

			[Token(Token = "0x600022D")]
			[Address(RVA = "0x24D9F6C", Offset = "0x24D9F6C", VA = "0x24D9F6C", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x600022E")]
			[Address(RVA = "0x24DA0B0", Offset = "0x24DA0B0", VA = "0x24DA0B0")]
			public AuthCodeResponse()
			{
			}
		}

		[Token(Token = "0x200005E")]
		public class IdTokenResponse : ResponseBase
		{
			[Token(Token = "0x4000435")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal string idToken;

			[Token(Token = "0x17000086")]
			public string IdToken
			{
				[Token(Token = "0x600022F")]
				[Address(RVA = "0x24DA2E0", Offset = "0x24DA2E0", VA = "0x24DA2E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000230")]
			[Address(RVA = "0x24DA2E8", Offset = "0x24DA2E8", VA = "0x24DA2E8", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x6000231")]
			[Address(RVA = "0x24DA41C", Offset = "0x24DA41C", VA = "0x24DA41C")]
			public IdTokenResponse()
			{
			}
		}

		[PreserveSig]
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x24D9BB4", Offset = "0x24D9BB4", VA = "0x24D9BB4")]
		private static extern int PrxGetAuthCode(GetAuthCodeRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x24D9C78", Offset = "0x24D9C78", VA = "0x24D9C78")]
		private static extern int PrxGetIdToken(GetIdTokenRequest request, out APIResult result);

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x24D9D3C", Offset = "0x24D9D3C", VA = "0x24D9D3C")]
		public static int GetAuthCode(GetAuthCodeRequest request, AuthCodeResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x24D9E48", Offset = "0x24D9E48", VA = "0x24D9E48")]
		public static int GetIdToken(GetIdTokenRequest request, IdTokenResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x24D9F54", Offset = "0x24D9F54", VA = "0x24D9F54")]
		public Auth()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public class Commerce
	{
		[Token(Token = "0x200005F")]
		public struct CategoryLabel
		{
			[Token(Token = "0x4000436")]
			public const int CATEGORY_LABEL_MAX_LEN = 16;

			[Token(Token = "0x4000437")]
			public const int SDK4_0_CATEGORY_LABEL_MAX_LEN = 55;

			[Token(Token = "0x4000438")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal string internalValue;

			[Token(Token = "0x17000087")]
			public string Value
			{
				[Token(Token = "0x6000232")]
				[Address(RVA = "0x24DBF34", Offset = "0x24DBF34", VA = "0x24DBF34")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000233")]
				[Address(RVA = "0x24DBF3C", Offset = "0x24DBF3C", VA = "0x24DBF3C")]
				set
				{
				}
			}

			[Token(Token = "0x6000234")]
			[Address(RVA = "0x24DBF10", Offset = "0x24DBF10", VA = "0x24DBF10")]
			internal void Read(MemoryBuffer buffer)
			{
			}
		}

		[Token(Token = "0x2000060")]
		public struct ServiceEntitlementLabel
		{
			[Token(Token = "0x4000439")]
			public const int SERVICE_ENTITLEMENT_LABEL_MAX_LEN = 6;

			[Token(Token = "0x400043A")]
			public const int SDK4_0_SERVICE_ENTITLEMENT_LABEL_MAX_LEN = 31;

			[Token(Token = "0x400043B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal string internalValue;

			[Token(Token = "0x17000088")]
			public string Value
			{
				[Token(Token = "0x6000235")]
				[Address(RVA = "0x24DD698", Offset = "0x24DD698", VA = "0x24DD698")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000236")]
				[Address(RVA = "0x24DD6A0", Offset = "0x24DD6A0", VA = "0x24DD6A0")]
				set
				{
				}
			}

			[Token(Token = "0x6000237")]
			[Address(RVA = "0x24DD66C", Offset = "0x24DD66C", VA = "0x24DD66C")]
			internal void Read(MemoryBuffer buffer)
			{
			}
		}

		[Token(Token = "0x2000061")]
		public struct ProductLabel
		{
			[Token(Token = "0x400043C")]
			public const int PRODUCT_LABEL_MAX_LEN = 16;

			[Token(Token = "0x400043D")]
			public const int SDK4_0_PRODUCT_LABEL_MAX_LEN = 47;

			[Token(Token = "0x400043E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal string internalValue;

			[Token(Token = "0x17000089")]
			public string Value
			{
				[Token(Token = "0x6000238")]
				[Address(RVA = "0x24DD244", Offset = "0x24DD244", VA = "0x24DD244")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000239")]
				[Address(RVA = "0x24DD24C", Offset = "0x24DD24C", VA = "0x24DD24C")]
				set
				{
				}
			}

			[Token(Token = "0x600023A")]
			[Address(RVA = "0x24DCD80", Offset = "0x24DCD80", VA = "0x24DCD80")]
			internal void Read(MemoryBuffer buffer)
			{
			}
		}

		[Token(Token = "0x2000062")]
		public struct SkuLabel
		{
			[Token(Token = "0x400043F")]
			public const int SKU_LABEL_MAX_LEN = 4;

			[Token(Token = "0x4000440")]
			public const int SDK4_0_SKU_LABEL_MAX_LEN = 55;

			[Token(Token = "0x4000441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal string internalValue;

			[Token(Token = "0x1700008A")]
			public string Value
			{
				[Token(Token = "0x600023B")]
				[Address(RVA = "0x24DDA9C", Offset = "0x24DDA9C", VA = "0x24DDA9C")]
				get
				{
					return null;
				}
				[Token(Token = "0x600023C")]
				[Address(RVA = "0x24DDAA4", Offset = "0x24DDAA4", VA = "0x24DDAA4")]
				set
				{
				}
			}

			[Token(Token = "0x600023D")]
			[Address(RVA = "0x24DDA78", Offset = "0x24DDA78", VA = "0x24DDA78")]
			internal void Read(MemoryBuffer buffer)
			{
			}
		}

		[Token(Token = "0x2000063")]
		public struct DownloadListTarget
		{
			[Token(Token = "0x4000442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ProductLabel productLabel;

			[Token(Token = "0x4000443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal SkuLabel skuLabel;

			[Token(Token = "0x1700008B")]
			public ProductLabel ProductLabel
			{
				[Token(Token = "0x600023E")]
				[Address(RVA = "0x24DC5FC", Offset = "0x24DC5FC", VA = "0x24DC5FC")]
				get
				{
					return default(ProductLabel);
				}
				[Token(Token = "0x600023F")]
				[Address(RVA = "0x24DC604", Offset = "0x24DC604", VA = "0x24DC604")]
				set
				{
				}
			}

			[Token(Token = "0x1700008C")]
			public SkuLabel SkuLabel
			{
				[Token(Token = "0x6000240")]
				[Address(RVA = "0x24DC60C", Offset = "0x24DC60C", VA = "0x24DC60C")]
				get
				{
					return default(SkuLabel);
				}
				[Token(Token = "0x6000241")]
				[Address(RVA = "0x24DC614", Offset = "0x24DC614", VA = "0x24DC614")]
				set
				{
				}
			}
		}

		[Token(Token = "0x2000064")]
		public struct CheckoutTarget
		{
			[Token(Token = "0x4000444")]
			public const uint NP_INVALID_SERVICE_LABEL = uint.MaxValue;

			[Token(Token = "0x4000445")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ProductLabel productLabel;

			[Token(Token = "0x4000446")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal SkuLabel skuLabel;

			[Token(Token = "0x4000447")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal uint serviceLabel;

			[Token(Token = "0x1700008D")]
			public ProductLabel ProductLabel
			{
				[Token(Token = "0x6000242")]
				[Address(RVA = "0x24DC044", Offset = "0x24DC044", VA = "0x24DC044")]
				get
				{
					return default(ProductLabel);
				}
				[Token(Token = "0x6000243")]
				[Address(RVA = "0x24DC04C", Offset = "0x24DC04C", VA = "0x24DC04C")]
				set
				{
				}
			}

			[Token(Token = "0x1700008E")]
			public SkuLabel SkuLabel
			{
				[Token(Token = "0x6000244")]
				[Address(RVA = "0x24DC054", Offset = "0x24DC054", VA = "0x24DC054")]
				get
				{
					return default(SkuLabel);
				}
				[Token(Token = "0x6000245")]
				[Address(RVA = "0x24DC05C", Offset = "0x24DC05C", VA = "0x24DC05C")]
				set
				{
				}
			}

			[Token(Token = "0x1700008F")]
			public uint ServiceLabel
			{
				[Token(Token = "0x6000246")]
				[Address(RVA = "0x24DC064", Offset = "0x24DC064", VA = "0x24DC064")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x6000247")]
				[Address(RVA = "0x24DC06C", Offset = "0x24DC06C", VA = "0x24DC06C")]
				set
				{
				}
			}
		}

		[Token(Token = "0x2000065")]
		public class SubCategory
		{
			[Token(Token = "0x4000448")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal string categoryName;

			[Token(Token = "0x4000449")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal string categoryDescription;

			[Token(Token = "0x400044A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal string imageUrl;

			[Token(Token = "0x400044B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal CategoryLabel categoryLabel;

			[Token(Token = "0x17000090")]
			public string CategoryName
			{
				[Token(Token = "0x6000248")]
				[Address(RVA = "0x24DDBAC", Offset = "0x24DDBAC", VA = "0x24DDBAC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000091")]
			public string CategoryDescription
			{
				[Token(Token = "0x6000249")]
				[Address(RVA = "0x24DDBB4", Offset = "0x24DDBB4", VA = "0x24DDBB4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000092")]
			public string ImageUrl
			{
				[Token(Token = "0x600024A")]
				[Address(RVA = "0x24DDBBC", Offset = "0x24DDBBC", VA = "0x24DDBBC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000093")]
			public CategoryLabel CategoryLabel
			{
				[Token(Token = "0x600024B")]
				[Address(RVA = "0x24DDBC4", Offset = "0x24DDBC4", VA = "0x24DDBC4")]
				get
				{
					return default(CategoryLabel);
				}
			}

			[Token(Token = "0x600024C")]
			[Address(RVA = "0x24DBE8C", Offset = "0x24DBE8C", VA = "0x24DBE8C")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x600024D")]
			[Address(RVA = "0x24DBE84", Offset = "0x24DBE84", VA = "0x24DBE84")]
			public SubCategory()
			{
			}
		}

		[Token(Token = "0x2000066")]
		public class Category
		{
			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal SubCategory[] subCategories;

			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal ulong countOfProducts;

			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal string categoryName;

			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal string categoryDescription;

			[Token(Token = "0x4000450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal string imageUrl;

			[Token(Token = "0x4000451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal CategoryLabel categoryLabel;

			[Token(Token = "0x17000094")]
			public SubCategory[] SubCategories
			{
				[Token(Token = "0x600024E")]
				[Address(RVA = "0x24DBE54", Offset = "0x24DBE54", VA = "0x24DBE54")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000095")]
			public ulong CountOfProducts
			{
				[Token(Token = "0x600024F")]
				[Address(RVA = "0x24DBE5C", Offset = "0x24DBE5C", VA = "0x24DBE5C")]
				get
				{
					return default(ulong);
				}
			}

			[Token(Token = "0x17000096")]
			public string CategoryName
			{
				[Token(Token = "0x6000250")]
				[Address(RVA = "0x24DBE64", Offset = "0x24DBE64", VA = "0x24DBE64")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000097")]
			public string CategoryDescription
			{
				[Token(Token = "0x6000251")]
				[Address(RVA = "0x24DBE6C", Offset = "0x24DBE6C", VA = "0x24DBE6C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000098")]
			public string ImageUrl
			{
				[Token(Token = "0x6000252")]
				[Address(RVA = "0x24DBE74", Offset = "0x24DBE74", VA = "0x24DBE74")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000099")]
			public CategoryLabel CategoryLabel
			{
				[Token(Token = "0x6000253")]
				[Address(RVA = "0x24DBE7C", Offset = "0x24DBE7C", VA = "0x24DBE7C")]
				get
				{
					return default(CategoryLabel);
				}
			}

			[Token(Token = "0x6000254")]
			[Address(RVA = "0x24DBC7C", Offset = "0x24DBC7C", VA = "0x24DBC7C")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x6000255")]
			[Address(RVA = "0x24DBC74", Offset = "0x24DBC74", VA = "0x24DBC74")]
			public Category()
			{
			}
		}

		[Token(Token = "0x2000067")]
		public class Product
		{
			[Token(Token = "0x4000452")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal ProductLabel productLabel;

			[Token(Token = "0x4000453")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal string productName;

			[Token(Token = "0x4000454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal string imageUrl;

			[Token(Token = "0x4000455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal bool hasDetails;

			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal ProductDetails details;

			[Token(Token = "0x1700009A")]
			public ProductLabel ProductLabel
			{
				[Token(Token = "0x6000256")]
				[Address(RVA = "0x24DCC70", Offset = "0x24DCC70", VA = "0x24DCC70")]
				get
				{
					return default(ProductLabel);
				}
			}

			[Token(Token = "0x1700009B")]
			public string ProductName
			{
				[Token(Token = "0x6000257")]
				[Address(RVA = "0x24DCC78", Offset = "0x24DCC78", VA = "0x24DCC78")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009C")]
			public string ImageUrl
			{
				[Token(Token = "0x6000258")]
				[Address(RVA = "0x24DCC80", Offset = "0x24DCC80", VA = "0x24DCC80")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009D")]
			public bool HasDetails
			{
				[Token(Token = "0x6000259")]
				[Address(RVA = "0x24DCC88", Offset = "0x24DCC88", VA = "0x24DCC88")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700009E")]
			public ProductDetails Details
			{
				[Token(Token = "0x600025A")]
				[Address(RVA = "0x24DCC90", Offset = "0x24DCC90", VA = "0x24DCC90")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600025B")]
			[Address(RVA = "0x24DCC98", Offset = "0x24DCC98", VA = "0x24DCC98")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x600025C")]
			[Address(RVA = "0x24DD0A0", Offset = "0x24DD0A0", VA = "0x24DD0A0")]
			public Product()
			{
			}
		}

		[Token(Token = "0x2000068")]
		public enum PurchasabilityStatus
		{
			[Token(Token = "0x4000458")]
			NotPurchased,
			[Token(Token = "0x4000459")]
			PurchasedCanPurchaseAgain,
			[Token(Token = "0x400045A")]
			PurchasedCannotPurchaseAgain
		}

		[Token(Token = "0x2000069")]
		public class RatingDescriptor
		{
			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal string name;

			[Token(Token = "0x400045C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal string imageUrl;

			[Token(Token = "0x1700009F")]
			public string Name
			{
				[Token(Token = "0x600025D")]
				[Address(RVA = "0x24DD590", Offset = "0x24DD590", VA = "0x24DD590")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A0")]
			public string ImageUrl
			{
				[Token(Token = "0x600025E")]
				[Address(RVA = "0x24DD598", Offset = "0x24DD598", VA = "0x24DD598")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600025F")]
			[Address(RVA = "0x24DD144", Offset = "0x24DD144", VA = "0x24DD144")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x6000260")]
			[Address(RVA = "0x24DD13C", Offset = "0x24DD13C", VA = "0x24DD13C")]
			public RatingDescriptor()
			{
			}
		}

		[Token(Token = "0x200006A")]
		public class ProductDetails
		{
			[Token(Token = "0x400045D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal DateTime releaseDate;

			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal string longDescription;

			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal string spName;

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal string ratingSystemId;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal string ratingImageUrl;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal RatingDescriptor[] ratingDescriptors;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal SkuInfo[] skuinfo;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal PurchasabilityStatus purchasabilityStatus;

			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			internal uint starRatingsTotal;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal double starRatingScore;

			[Token(Token = "0x170000A1")]
			public DateTime ReleaseDate
			{
				[Token(Token = "0x6000261")]
				[Address(RVA = "0x24DD0A8", Offset = "0x24DD0A8", VA = "0x24DD0A8")]
				get
				{
					return default(DateTime);
				}
			}

			[Token(Token = "0x170000A2")]
			public string LongDescription
			{
				[Token(Token = "0x6000262")]
				[Address(RVA = "0x24DD0B0", Offset = "0x24DD0B0", VA = "0x24DD0B0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A3")]
			public string SpName
			{
				[Token(Token = "0x6000263")]
				[Address(RVA = "0x24DD0B8", Offset = "0x24DD0B8", VA = "0x24DD0B8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A4")]
			public string RatingSystemId
			{
				[Token(Token = "0x6000264")]
				[Address(RVA = "0x24DD0C0", Offset = "0x24DD0C0", VA = "0x24DD0C0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A5")]
			public string RatingImageUrl
			{
				[Token(Token = "0x6000265")]
				[Address(RVA = "0x24DD0C8", Offset = "0x24DD0C8", VA = "0x24DD0C8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A6")]
			public RatingDescriptor[] RatingDescriptors
			{
				[Token(Token = "0x6000266")]
				[Address(RVA = "0x24DD0D0", Offset = "0x24DD0D0", VA = "0x24DD0D0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A7")]
			public SkuInfo[] Skuinfo
			{
				[Token(Token = "0x6000267")]
				[Address(RVA = "0x24DD0D8", Offset = "0x24DD0D8", VA = "0x24DD0D8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A8")]
			[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE1C5C", Offset = "0xCE1C5C")]
			public PurchasabilityStatus PurchasabilityStatus
			{
				[Token(Token = "0x6000268")]
				[Address(RVA = "0x24DD0E0", Offset = "0x24DD0E0", VA = "0x24DD0E0")]
				get
				{
					return default(PurchasabilityStatus);
				}
			}

			[Token(Token = "0x170000A9")]
			public uint StarRatingsTotal
			{
				[Token(Token = "0x6000269")]
				[Address(RVA = "0x24DD0E8", Offset = "0x24DD0E8", VA = "0x24DD0E8")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x170000AA")]
			public double StarRatingScore
			{
				[Token(Token = "0x600026A")]
				[Address(RVA = "0x24DD0F0", Offset = "0x24DD0F0", VA = "0x24DD0F0")]
				get
				{
					return default(double);
				}
			}

			[Token(Token = "0x600026B")]
			[Address(RVA = "0x24DCDAC", Offset = "0x24DCDAC", VA = "0x24DCDAC")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x600026C")]
			[Address(RVA = "0x24DCDA4", Offset = "0x24DCDA4", VA = "0x24DCDA4")]
			public ProductDetails()
			{
			}
		}

		[Token(Token = "0x200006B")]
		public enum SkuType
		{
			[Token(Token = "0x4000468")]
			Invalid,
			[Token(Token = "0x4000469")]
			Standard,
			[Token(Token = "0x400046A")]
			Preorder
		}

		[Token(Token = "0x200006C")]
		public class SkuInfo
		{
			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal SkuType type;

			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal PurchasabilityStatus purchasabilityStatus;

			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal SkuLabel label;

			[Token(Token = "0x400046E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal string name;

			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal string price;

			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal ulong intPrice;

			[Token(Token = "0x4000471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal uint consumableUseCount;

			[Token(Token = "0x170000AB")]
			public SkuType Type
			{
				[Token(Token = "0x600026D")]
				[Address(RVA = "0x24DDA40", Offset = "0x24DDA40", VA = "0x24DDA40")]
				get
				{
					return default(SkuType);
				}
			}

			[Token(Token = "0x170000AC")]
			public PurchasabilityStatus PurchasabilityStatus
			{
				[Token(Token = "0x600026E")]
				[Address(RVA = "0x24DDA48", Offset = "0x24DDA48", VA = "0x24DDA48")]
				get
				{
					return default(PurchasabilityStatus);
				}
			}

			[Token(Token = "0x170000AD")]
			public SkuLabel Label
			{
				[Token(Token = "0x600026F")]
				[Address(RVA = "0x24DDA50", Offset = "0x24DDA50", VA = "0x24DDA50")]
				get
				{
					return default(SkuLabel);
				}
			}

			[Token(Token = "0x170000AE")]
			public string Name
			{
				[Token(Token = "0x6000270")]
				[Address(RVA = "0x24DDA58", Offset = "0x24DDA58", VA = "0x24DDA58")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AF")]
			public string Price
			{
				[Token(Token = "0x6000271")]
				[Address(RVA = "0x24DDA60", Offset = "0x24DDA60", VA = "0x24DDA60")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B0")]
			public ulong IntPrice
			{
				[Token(Token = "0x6000272")]
				[Address(RVA = "0x24DDA68", Offset = "0x24DDA68", VA = "0x24DDA68")]
				get
				{
					return default(ulong);
				}
			}

			[Token(Token = "0x170000B1")]
			public uint ConsumableUseCount
			{
				[Token(Token = "0x6000273")]
				[Address(RVA = "0x24DDA70", Offset = "0x24DDA70", VA = "0x24DDA70")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x6000274")]
			[Address(RVA = "0x24DD190", Offset = "0x24DD190", VA = "0x24DD190")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x6000275")]
			[Address(RVA = "0x24DD188", Offset = "0x24DD188", VA = "0x24DD188")]
			public SkuInfo()
			{
			}
		}

		[Token(Token = "0x200006D")]
		public enum EntitlementType
		{
			[Token(Token = "0x4000473")]
			Invalid,
			[Token(Token = "0x4000474")]
			Service,
			[Token(Token = "0x4000475")]
			ServiceConsumable,
			[Token(Token = "0x4000476")]
			Unified
		}

		[Token(Token = "0x200006E")]
		public class ServiceEntitlement
		{
			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal ServiceEntitlementLabel entitlementLabel;

			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal DateTime createdDate;

			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal DateTime expireDate;

			[Token(Token = "0x400047A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal long remainingCount;

			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal uint consumedCount;

			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal EntitlementType type;

			[Token(Token = "0x170000B2")]
			public ServiceEntitlementLabel EntitlementLabel
			{
				[Token(Token = "0x6000276")]
				[Address(RVA = "0x24DD5A0", Offset = "0x24DD5A0", VA = "0x24DD5A0")]
				get
				{
					return default(ServiceEntitlementLabel);
				}
			}

			[Token(Token = "0x170000B3")]
			public DateTime CreatedDate
			{
				[Token(Token = "0x6000277")]
				[Address(RVA = "0x24DD5A8", Offset = "0x24DD5A8", VA = "0x24DD5A8")]
				get
				{
					return default(DateTime);
				}
			}

			[Token(Token = "0x170000B4")]
			public DateTime ExpireDate
			{
				[Token(Token = "0x6000278")]
				[Address(RVA = "0x24DD5B0", Offset = "0x24DD5B0", VA = "0x24DD5B0")]
				get
				{
					return default(DateTime);
				}
			}

			[Token(Token = "0x170000B5")]
			public long RemainingCount
			{
				[Token(Token = "0x6000279")]
				[Address(RVA = "0x24DD5B8", Offset = "0x24DD5B8", VA = "0x24DD5B8")]
				get
				{
					return default(long);
				}
			}

			[Token(Token = "0x170000B6")]
			public uint ConsumedCount
			{
				[Token(Token = "0x600027A")]
				[Address(RVA = "0x24DD5C0", Offset = "0x24DD5C0", VA = "0x24DD5C0")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x170000B7")]
			public EntitlementType Type
			{
				[Token(Token = "0x600027B")]
				[Address(RVA = "0x24DD5C8", Offset = "0x24DD5C8", VA = "0x24DD5C8")]
				get
				{
					return default(EntitlementType);
				}
			}

			[Token(Token = "0x600027C")]
			[Address(RVA = "0x24DD5D0", Offset = "0x24DD5D0", VA = "0x24DD5D0")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x600027D")]
			[Address(RVA = "0x24DD690", Offset = "0x24DD690", VA = "0x24DD690")]
			public ServiceEntitlement()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x200006F")]
		public class GetCategoriesRequest : RequestBase
		{
			[Token(Token = "0x400047D")]
			public const int MAX_CATEGORIES = 8;

			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ulong numCategories;

			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal CategoryLabel[] categoryLabels;

			[Token(Token = "0x170000B8")]
			public CategoryLabel[] CategoryLabels
			{
				[Token(Token = "0x600027E")]
				[Address(RVA = "0x24DC61C", Offset = "0x24DC61C", VA = "0x24DC61C")]
				get
				{
					return null;
				}
				[Token(Token = "0x600027F")]
				[Address(RVA = "0x24DC6B4", Offset = "0x24DC6B4", VA = "0x24DC6B4")]
				set
				{
				}
			}

			[Token(Token = "0x6000280")]
			[Address(RVA = "0x24DC7A8", Offset = "0x24DC7A8", VA = "0x24DC7A8")]
			public GetCategoriesRequest()
			{
			}
		}

		[Token(Token = "0x2000070")]
		public enum ProductSortOrders
		{
			[Token(Token = "0x4000481")]
			DefaultOrder,
			[Token(Token = "0x4000482")]
			Name,
			[Token(Token = "0x4000483")]
			Price,
			[Token(Token = "0x4000484")]
			ReleaseDate
		}

		[Token(Token = "0x2000071")]
		public enum ProductSortDirections
		{
			[Token(Token = "0x4000486")]
			Ascending,
			[Token(Token = "0x4000487")]
			Descending
		}

		[StructLayout(0)]
		[Token(Token = "0x2000072")]
		public class GetProductsRequest : RequestBase
		{
			[Token(Token = "0x4000488")]
			public const int MAX_PRODUCTS = 32;

			[Token(Token = "0x4000489")]
			public const int MAX_CATEGORIES = 8;

			[Token(Token = "0x400048A")]
			public const int DEFAULT_PAGE_SIZE = 32;

			[Token(Token = "0x400048B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ulong numProducts;

			[Token(Token = "0x400048C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal ProductLabel[] productLabels;

			[Token(Token = "0x400048D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal ulong numCategories;

			[Token(Token = "0x400048E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal CategoryLabel[] categoryLabels;

			[Token(Token = "0x400048F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal uint offset;

			[Token(Token = "0x4000490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			internal uint pageSize;

			[Token(Token = "0x4000491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal ProductSortOrders sortOrder;

			[Token(Token = "0x4000492")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			internal ProductSortDirections sortDirection;

			[Token(Token = "0x4000493")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal bool keepHtmlTags;

			[Token(Token = "0x4000494")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
			internal bool useCurrencySymbol;

			[Token(Token = "0x170000B9")]
			public ProductLabel[] ProductLabels
			{
				[Token(Token = "0x6000281")]
				[Address(RVA = "0x24DC810", Offset = "0x24DC810", VA = "0x24DC810")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000282")]
				[Address(RVA = "0x24DC8A8", Offset = "0x24DC8A8", VA = "0x24DC8A8")]
				set
				{
				}
			}

			[Token(Token = "0x170000BA")]
			public CategoryLabel[] CategoryLabels
			{
				[Token(Token = "0x6000283")]
				[Address(RVA = "0x24DC99C", Offset = "0x24DC99C", VA = "0x24DC99C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000284")]
				[Address(RVA = "0x24DCA34", Offset = "0x24DCA34", VA = "0x24DCA34")]
				set
				{
				}
			}

			[Token(Token = "0x170000BB")]
			public uint Offset
			{
				[Token(Token = "0x6000285")]
				[Address(RVA = "0x24DCB28", Offset = "0x24DCB28", VA = "0x24DCB28")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x6000286")]
				[Address(RVA = "0x24DCB30", Offset = "0x24DCB30", VA = "0x24DCB30")]
				set
				{
				}
			}

			[Token(Token = "0x170000BC")]
			public uint PageSize
			{
				[Token(Token = "0x6000287")]
				[Address(RVA = "0x24DCB38", Offset = "0x24DCB38", VA = "0x24DCB38")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x6000288")]
				[Address(RVA = "0x24DCB40", Offset = "0x24DCB40", VA = "0x24DCB40")]
				set
				{
				}
			}

			[Token(Token = "0x170000BD")]
			public ProductSortOrders SortOrder
			{
				[Token(Token = "0x6000289")]
				[Address(RVA = "0x24DCB48", Offset = "0x24DCB48", VA = "0x24DCB48")]
				get
				{
					return default(ProductSortOrders);
				}
				[Token(Token = "0x600028A")]
				[Address(RVA = "0x24DCB50", Offset = "0x24DCB50", VA = "0x24DCB50")]
				set
				{
				}
			}

			[Token(Token = "0x170000BE")]
			public ProductSortDirections SortDirection
			{
				[Token(Token = "0x600028B")]
				[Address(RVA = "0x24DCB58", Offset = "0x24DCB58", VA = "0x24DCB58")]
				get
				{
					return default(ProductSortDirections);
				}
				[Token(Token = "0x600028C")]
				[Address(RVA = "0x24DCB60", Offset = "0x24DCB60", VA = "0x24DCB60")]
				set
				{
				}
			}

			[Token(Token = "0x170000BF")]
			public bool KeepHtmlTags
			{
				[Token(Token = "0x600028D")]
				[Address(RVA = "0x24DCB68", Offset = "0x24DCB68", VA = "0x24DCB68")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600028E")]
				[Address(RVA = "0x24DCB70", Offset = "0x24DCB70", VA = "0x24DCB70")]
				set
				{
				}
			}

			[Token(Token = "0x170000C0")]
			public bool UseCurrencySymbol
			{
				[Token(Token = "0x600028F")]
				[Address(RVA = "0x24DCB7C", Offset = "0x24DCB7C", VA = "0x24DCB7C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000290")]
				[Address(RVA = "0x24DCB84", Offset = "0x24DCB84", VA = "0x24DCB84")]
				set
				{
				}
			}

			[Token(Token = "0x6000291")]
			[Address(RVA = "0x24DCB90", Offset = "0x24DCB90", VA = "0x24DCB90")]
			public GetProductsRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x2000073")]
		public class GetServiceEntitlementsRequest : RequestBase
		{
			[Token(Token = "0x4000495")]
			public const int DEFAULT_PAGE_SIZE = 64;

			[Token(Token = "0x4000496")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal uint offset;

			[Token(Token = "0x4000497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal uint pageSize;

			[Token(Token = "0x170000C1")]
			public uint Offset
			{
				[Token(Token = "0x6000292")]
				[Address(RVA = "0x24DCC1C", Offset = "0x24DCC1C", VA = "0x24DCC1C")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x6000293")]
				[Address(RVA = "0x24DCC24", Offset = "0x24DCC24", VA = "0x24DCC24")]
				set
				{
				}
			}

			[Token(Token = "0x170000C2")]
			public uint PageSize
			{
				[Token(Token = "0x6000294")]
				[Address(RVA = "0x24DCC2C", Offset = "0x24DCC2C", VA = "0x24DCC2C")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x6000295")]
				[Address(RVA = "0x24DCC34", Offset = "0x24DCC34", VA = "0x24DCC34")]
				set
				{
				}
			}

			[Token(Token = "0x6000296")]
			[Address(RVA = "0x24DCC3C", Offset = "0x24DCC3C", VA = "0x24DCC3C")]
			public GetServiceEntitlementsRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x2000074")]
		public class ConsumeServiceEntitlementRequest : RequestBase
		{
			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ServiceEntitlementLabel entitlementLabel;

			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal uint consumedCount;

			[Token(Token = "0x170000C3")]
			public ServiceEntitlementLabel EntitlementLabel
			{
				[Token(Token = "0x6000297")]
				[Address(RVA = "0x24DC074", Offset = "0x24DC074", VA = "0x24DC074")]
				get
				{
					return default(ServiceEntitlementLabel);
				}
				[Token(Token = "0x6000298")]
				[Address(RVA = "0x24DC07C", Offset = "0x24DC07C", VA = "0x24DC07C")]
				set
				{
				}
			}

			[Token(Token = "0x170000C4")]
			public uint ConsumedCount
			{
				[Token(Token = "0x6000299")]
				[Address(RVA = "0x24DC084", Offset = "0x24DC084", VA = "0x24DC084")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x600029A")]
				[Address(RVA = "0x24DC08C", Offset = "0x24DC08C", VA = "0x24DC08C")]
				set
				{
				}
			}

			[Token(Token = "0x600029B")]
			[Address(RVA = "0x24DC094", Offset = "0x24DC094", VA = "0x24DC094")]
			public ConsumeServiceEntitlementRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x2000075")]
		public class DisplayCategoryBrowseDialogRequest : RequestBase
		{
			[Token(Token = "0x400049A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal CategoryLabel categoryLabel;

			[Token(Token = "0x170000C5")]
			public CategoryLabel CategoryLabel
			{
				[Token(Token = "0x600029C")]
				[Address(RVA = "0x24DC0A4", Offset = "0x24DC0A4", VA = "0x24DC0A4")]
				get
				{
					return default(CategoryLabel);
				}
				[Token(Token = "0x600029D")]
				[Address(RVA = "0x24DC0AC", Offset = "0x24DC0AC", VA = "0x24DC0AC")]
				set
				{
				}
			}

			[Token(Token = "0x600029E")]
			[Address(RVA = "0x24DC0B4", Offset = "0x24DC0B4", VA = "0x24DC0B4")]
			public DisplayCategoryBrowseDialogRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x2000076")]
		public class DisplayProductBrowseDialogRequest : RequestBase
		{
			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ProductLabel productLabel;

			[Token(Token = "0x170000C6")]
			public ProductLabel ProductLabel
			{
				[Token(Token = "0x600029F")]
				[Address(RVA = "0x24DC4E0", Offset = "0x24DC4E0", VA = "0x24DC4E0")]
				get
				{
					return default(ProductLabel);
				}
				[Token(Token = "0x60002A0")]
				[Address(RVA = "0x24DC4E8", Offset = "0x24DC4E8", VA = "0x24DC4E8")]
				set
				{
				}
			}

			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x24DC4F0", Offset = "0x24DC4F0", VA = "0x24DC4F0")]
			public DisplayProductBrowseDialogRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x2000077")]
		public class DisplayVoucherCodeInputDialogRequest : RequestBase
		{
			[Token(Token = "0x400049C")]
			public const int VOUCHER_CODE_LEN = 63;

			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal string voucherCode;

			[Token(Token = "0x170000C7")]
			public string VoucherCode
			{
				[Token(Token = "0x60002A2")]
				[Address(RVA = "0x24DC500", Offset = "0x24DC500", VA = "0x24DC500")]
				get
				{
					return null;
				}
				[Token(Token = "0x60002A3")]
				[Address(RVA = "0x24DC508", Offset = "0x24DC508", VA = "0x24DC508")]
				set
				{
				}
			}

			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x24DC5EC", Offset = "0x24DC5EC", VA = "0x24DC5EC")]
			public DisplayVoucherCodeInputDialogRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x2000078")]
		public class DisplayCheckoutDialogRequest : RequestBase
		{
			[Token(Token = "0x400049E")]
			public const int MAX_TARGETS = 10;

			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ulong numTargets;

			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal CheckoutTarget[] targets;

			[Token(Token = "0x170000C8")]
			public CheckoutTarget[] Targets
			{
				[Token(Token = "0x60002A5")]
				[Address(RVA = "0x24DC0C4", Offset = "0x24DC0C4", VA = "0x24DC0C4")]
				get
				{
					return null;
				}
				[Token(Token = "0x60002A6")]
				[Address(RVA = "0x24DC15C", Offset = "0x24DC15C", VA = "0x24DC15C")]
				set
				{
				}
			}

			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x24DC250", Offset = "0x24DC250", VA = "0x24DC250")]
			public DisplayCheckoutDialogRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x2000079")]
		public class DisplayDownloadListDialogRequest : RequestBase
		{
			[Token(Token = "0x40004A1")]
			public const int MAX_TARGETS = 10;

			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ulong numTargets;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal DownloadListTarget[] targets;

			[Token(Token = "0x170000C9")]
			public DownloadListTarget[] Targets
			{
				[Token(Token = "0x60002A8")]
				[Address(RVA = "0x24DC2B8", Offset = "0x24DC2B8", VA = "0x24DC2B8")]
				get
				{
					return null;
				}
				[Token(Token = "0x60002A9")]
				[Address(RVA = "0x24DC350", Offset = "0x24DC350", VA = "0x24DC350")]
				set
				{
				}
			}

			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x24DC444", Offset = "0x24DC444", VA = "0x24DC444")]
			public DisplayDownloadListDialogRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x200007A")]
		public class DisplayJoinPlusDialogRequest : RequestBase
		{
			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ulong features;

			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x24DC4AC", Offset = "0x24DC4AC", VA = "0x24DC4AC")]
			public DisplayJoinPlusDialogRequest()
			{
			}
		}

		[Token(Token = "0x200007B")]
		public enum PsStoreIconPos
		{
			[Token(Token = "0x40004A6")]
			Center,
			[Token(Token = "0x40004A7")]
			Left,
			[Token(Token = "0x40004A8")]
			Right
		}

		[StructLayout(0)]
		[Token(Token = "0x200007C")]
		public class SetPsStoreIconDisplayStateRequest : RequestBase
		{
			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal PsStoreIconPos iconPosition;

			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal bool showIcon;

			[Token(Token = "0x170000CA")]
			public PsStoreIconPos IconPosition
			{
				[Token(Token = "0x60002AC")]
				[Address(RVA = "0x24DDA0C", Offset = "0x24DDA0C", VA = "0x24DDA0C")]
				get
				{
					return default(PsStoreIconPos);
				}
				[Token(Token = "0x60002AD")]
				[Address(RVA = "0x24DDA14", Offset = "0x24DDA14", VA = "0x24DDA14")]
				set
				{
				}
			}

			[Token(Token = "0x170000CB")]
			public bool ShowIcon
			{
				[Token(Token = "0x60002AE")]
				[Address(RVA = "0x24DDA1C", Offset = "0x24DDA1C", VA = "0x24DDA1C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60002AF")]
				[Address(RVA = "0x24DDA24", Offset = "0x24DDA24", VA = "0x24DDA24")]
				set
				{
				}
			}

			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x24DDA30", Offset = "0x24DDA30", VA = "0x24DDA30")]
			public SetPsStoreIconDisplayStateRequest()
			{
			}
		}

		[Token(Token = "0x200007D")]
		public class CategoriesResponse : ResponseBase
		{
			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Category[] categories;

			[Token(Token = "0x170000CC")]
			public Category[] Categories
			{
				[Token(Token = "0x60002B1")]
				[Address(RVA = "0x24DBA40", Offset = "0x24DBA40", VA = "0x24DBA40")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x24DBA48", Offset = "0x24DBA48", VA = "0x24DBA48", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x24DBE4C", Offset = "0x24DBE4C", VA = "0x24DBE4C")]
			public CategoriesResponse()
			{
			}
		}

		[Token(Token = "0x200007E")]
		public class ProductsResponse : ResponseBase
		{
			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Product[] products;

			[Token(Token = "0x170000CD")]
			public Product[] Products
			{
				[Token(Token = "0x60002B4")]
				[Address(RVA = "0x24DD354", Offset = "0x24DD354", VA = "0x24DD354")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x24DD35C", Offset = "0x24DD35C", VA = "0x24DD35C", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x24DD588", Offset = "0x24DD588", VA = "0x24DD588")]
			public ProductsResponse()
			{
			}
		}

		[Token(Token = "0x200007F")]
		public class ServiceEntitlementsResponse : ResponseBase
		{
			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal ServiceEntitlement[] entitlements;

			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ulong totalEntitlementsAvailable;

			[Token(Token = "0x170000CE")]
			public ServiceEntitlement[] Entitlements
			{
				[Token(Token = "0x60002B7")]
				[Address(RVA = "0x24DD7A8", Offset = "0x24DD7A8", VA = "0x24DD7A8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CF")]
			public ulong TotalEntitlementsAvailable
			{
				[Token(Token = "0x60002B8")]
				[Address(RVA = "0x24DD7B0", Offset = "0x24DD7B0", VA = "0x24DD7B0")]
				get
				{
					return default(ulong);
				}
			}

			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x24DD7B8", Offset = "0x24DD7B8", VA = "0x24DD7B8", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x24DDA04", Offset = "0x24DDA04", VA = "0x24DDA04")]
			public ServiceEntitlementsResponse()
			{
			}
		}

		[PreserveSig]
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x24DA5FC", Offset = "0x24DA5FC", VA = "0x24DA5FC")]
		private static extern int PrxGetCategories(GetCategoriesRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x24DA6BC", Offset = "0x24DA6BC", VA = "0x24DA6BC")]
		private static extern int PrxGetProducts(GetProductsRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x24DA780", Offset = "0x24DA780", VA = "0x24DA780")]
		private static extern int PrxGetServiceEntitlements(GetServiceEntitlementsRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x24DA844", Offset = "0x24DA844", VA = "0x24DA844")]
		private static extern int PrxConsumeServiceEntitlement(ConsumeServiceEntitlementRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x24DA904", Offset = "0x24DA904", VA = "0x24DA904")]
		private static extern int PrxDisplayCategoryBrowseDialog(DisplayCategoryBrowseDialogRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x24DA9E4", Offset = "0x24DA9E4", VA = "0x24DA9E4")]
		private static extern int PrxDisplayProductBrowseDialog(DisplayProductBrowseDialogRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x24DAAC4", Offset = "0x24DAAC4", VA = "0x24DAAC4")]
		private static extern int PrxDisplayVoucherCodeInputDialog(DisplayVoucherCodeInputDialogRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x24DABA4", Offset = "0x24DABA4", VA = "0x24DABA4")]
		private static extern int PrxDisplayCheckoutDialog(DisplayCheckoutDialogRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x24DAC68", Offset = "0x24DAC68", VA = "0x24DAC68")]
		private static extern int PrxDisplayDownloadListDialog(DisplayDownloadListDialogRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x24DAD2C", Offset = "0x24DAD2C", VA = "0x24DAD2C")]
		private static extern int PrxDisplayJoinPlusDialog(DisplayJoinPlusDialogRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x24DADF0", Offset = "0x24DADF0", VA = "0x24DADF0")]
		private static extern int PrxSetPsStoreIconDisplayState(SetPsStoreIconDisplayStateRequest request, out APIResult result);

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x24DAEB4", Offset = "0x24DAEB4", VA = "0x24DAEB4")]
		public static int GetCategories(GetCategoriesRequest request, CategoriesResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x24DAFC0", Offset = "0x24DAFC0", VA = "0x24DAFC0")]
		public static int GetProducts(GetProductsRequest request, ProductsResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x24DB0CC", Offset = "0x24DB0CC", VA = "0x24DB0CC")]
		public static int GetServiceEntitlements(GetServiceEntitlementsRequest request, ServiceEntitlementsResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x24DB1D8", Offset = "0x24DB1D8", VA = "0x24DB1D8")]
		public static int ConsumeServiceEntitlement(ConsumeServiceEntitlementRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x24DB2E4", Offset = "0x24DB2E4", VA = "0x24DB2E4")]
		public static int DisplayCategoryBrowseDialog(DisplayCategoryBrowseDialogRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x24DB3F0", Offset = "0x24DB3F0", VA = "0x24DB3F0")]
		public static int DisplayProductBrowseDialog(DisplayProductBrowseDialogRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x24DB4FC", Offset = "0x24DB4FC", VA = "0x24DB4FC")]
		public static int DisplayVoucherCodeInputDialog(DisplayVoucherCodeInputDialogRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x24DB608", Offset = "0x24DB608", VA = "0x24DB608")]
		public static int DisplayCheckoutDialog(DisplayCheckoutDialogRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x24DB714", Offset = "0x24DB714", VA = "0x24DB714")]
		public static int DisplayDownloadListDialog(DisplayDownloadListDialogRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x24DB820", Offset = "0x24DB820", VA = "0x24DB820")]
		public static int DisplayJoinPlusDialog(DisplayJoinPlusDialogRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x24DB92C", Offset = "0x24DB92C", VA = "0x24DB92C")]
		public static int SetPsStoreIconDisplayState(SetPsStoreIconDisplayStateRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x24DBA38", Offset = "0x24DBA38", VA = "0x24DBA38")]
		public Commerce()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class NpCallbackEvent
	{
		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal ServiceTypes service;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal FunctionTypes apiCalled;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal uint npRequestId;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal ResponseBase response;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal Core.UserServiceUserId userId;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal RequestBase request;

		[Token(Token = "0x17000001")]
		public ServiceTypes Service
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x24E73B4", Offset = "0x24E73B4", VA = "0x24E73B4")]
			get
			{
				return default(ServiceTypes);
			}
		}

		[Token(Token = "0x17000002")]
		public FunctionTypes ApiCalled
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x24E73BC", Offset = "0x24E73BC", VA = "0x24E73BC")]
			get
			{
				return default(FunctionTypes);
			}
		}

		[Token(Token = "0x17000003")]
		public uint NpRequestId
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x24E73C4", Offset = "0x24E73C4", VA = "0x24E73C4")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000004")]
		public ResponseBase Response
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x24E73CC", Offset = "0x24E73CC", VA = "0x24E73CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		public RequestBase Request
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x24E73D4", Offset = "0x24E73D4", VA = "0x24E73D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public Core.UserServiceUserId UserId
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x24E73DC", Offset = "0x24E73DC", VA = "0x24E73DC")]
			get
			{
				return default(Core.UserServiceUserId);
			}
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x24E73E4", Offset = "0x24E73E4", VA = "0x24E73E4")]
		public NpCallbackEvent()
		{
		}
	}
	[Token(Token = "0x2000009")]
	internal static class PendingCallbackQueue
	{
		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Queue<NpCallbackEvent> pendingEvents;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static object syncObject;

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x24E9784", Offset = "0x24E9784", VA = "0x24E9784")]
		public static void AddEvent(NpCallbackEvent callbackEvent)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x24E9830", Offset = "0x24E9830", VA = "0x24E9830")]
		public static NpCallbackEvent PopEvent()
		{
			return null;
		}
	}
	[Token(Token = "0x200000A")]
	internal static class Compatibility
	{
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x24DDBCC", Offset = "0x24DDBCC", VA = "0x24DDBCC")]
		internal static ServiceTypes ConvertServiceToEnum(int serviceType)
		{
			return default(ServiceTypes);
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x24DE19C", Offset = "0x24DE19C", VA = "0x24DE19C")]
		internal static FunctionTypes ConvertFunctionToEnum(int functionType)
		{
			return default(FunctionTypes);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x24DE938", Offset = "0x24DE938", VA = "0x24DE938")]
		internal static int ConvertFromEnum(ServiceTypes serviceType)
		{
			return default(int);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x24DEF08", Offset = "0x24DEF08", VA = "0x24DEF08")]
		internal static int ConvertFromEnum(FunctionTypes functionType)
		{
			return default(int);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x24DDFEC", Offset = "0x24DDFEC", VA = "0x24DDFEC")]
		private static ServiceTypes ConvertFrom(ServiceTypes_SDK4_5 oldServiceType)
		{
			return default(ServiceTypes);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x24DDE3C", Offset = "0x24DDE3C", VA = "0x24DDE3C")]
		private static ServiceTypes ConvertFrom(ServiceTypes_SDK6_5 oldServiceType)
		{
			return default(ServiceTypes);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x24DDC8C", Offset = "0x24DDC8C", VA = "0x24DDC8C")]
		private static ServiceTypes ConvertFrom(ServiceTypes_SDK7_0 oldServiceType)
		{
			return default(ServiceTypes);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x24DE788", Offset = "0x24DE788", VA = "0x24DE788")]
		private static FunctionTypes ConvertFrom(FunctionTypes_SDK4_5 oldFunctionType)
		{
			return default(FunctionTypes);
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x24DE5D8", Offset = "0x24DE5D8", VA = "0x24DE5D8")]
		private static FunctionTypes ConvertFrom(FunctionTypes_SDK6_0 oldFunctionType)
		{
			return default(FunctionTypes);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x24DE428", Offset = "0x24DE428", VA = "0x24DE428")]
		private static FunctionTypes ConvertFrom(FunctionTypes_SDK6_5 oldFunctionType)
		{
			return default(FunctionTypes);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x24DE278", Offset = "0x24DE278", VA = "0x24DE278")]
		private static FunctionTypes ConvertFrom(FunctionTypes_SDK7_0 oldFunctionType)
		{
			return default(FunctionTypes);
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x24DED58", Offset = "0x24DED58", VA = "0x24DED58")]
		private static ServiceTypes_SDK4_5 ConvertToSDK45(ServiceTypes serviceType)
		{
			return default(ServiceTypes_SDK4_5);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x24DE9F8", Offset = "0x24DE9F8", VA = "0x24DE9F8")]
		private static ServiceTypes_SDK7_0 ConvertToSDK70(ServiceTypes serviceType)
		{
			return default(ServiceTypes_SDK7_0);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x24DEBA8", Offset = "0x24DEBA8", VA = "0x24DEBA8")]
		private static ServiceTypes_SDK6_5 ConvertToSDK65(ServiceTypes serviceType)
		{
			return default(ServiceTypes_SDK6_5);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x24DF4F4", Offset = "0x24DF4F4", VA = "0x24DF4F4")]
		private static FunctionTypes_SDK4_5 ConvertToSDK45(FunctionTypes functionType)
		{
			return default(FunctionTypes_SDK4_5);
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x24DF344", Offset = "0x24DF344", VA = "0x24DF344")]
		private static FunctionTypes_SDK6_0 ConvertToSDK60(FunctionTypes functionType)
		{
			return default(FunctionTypes_SDK6_0);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x24DF194", Offset = "0x24DF194", VA = "0x24DF194")]
		private static FunctionTypes_SDK6_5 ConvertToSDK65(FunctionTypes functionType)
		{
			return default(FunctionTypes_SDK6_5);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x24DEFE4", Offset = "0x24DEFE4", VA = "0x24DEFE4")]
		private static FunctionTypes_SDK7_0 ConvertToSDK70(FunctionTypes functionType)
		{
			return default(FunctionTypes_SDK7_0);
		}
	}
	[Token(Token = "0x200000B")]
	internal enum ServiceTypes_SDK4_5
	{
		[Token(Token = "0x4000011")]
		Invalid,
		[Token(Token = "0x4000012")]
		Auth,
		[Token(Token = "0x4000013")]
		Presence,
		[Token(Token = "0x4000014")]
		Ranking,
		[Token(Token = "0x4000015")]
		Trophy,
		[Token(Token = "0x4000016")]
		NetworkUtils,
		[Token(Token = "0x4000017")]
		NpUtils,
		[Token(Token = "0x4000018")]
		WordFilter,
		[Token(Token = "0x4000019")]
		UserProfile,
		[Token(Token = "0x400001A")]
		EventsClient,
		[Token(Token = "0x400001B")]
		Messaging,
		[Token(Token = "0x400001C")]
		Matching,
		[Token(Token = "0x400001D")]
		Commerce,
		[Token(Token = "0x400001E")]
		Challenge,
		[Token(Token = "0x400001F")]
		Tus,
		[Token(Token = "0x4000020")]
		Tss,
		[Token(Token = "0x4000021")]
		Friends,
		[Token(Token = "0x4000022")]
		Session,
		[Token(Token = "0x4000023")]
		ActivityFeed,
		[Token(Token = "0x4000024")]
		SocialMedia,
		[Token(Token = "0x4000025")]
		SharedMedia,
		[Token(Token = "0x4000026")]
		Core,
		[Token(Token = "0x4000027")]
		Notification,
		[Token(Token = "0x4000028")]
		Size
	}
	[Token(Token = "0x200000C")]
	public enum ServiceTypes_SDK7_0
	{
		[Token(Token = "0x400002A")]
		Invalid,
		[Token(Token = "0x400002B")]
		ActivityFeed,
		[Token(Token = "0x400002C")]
		Auth,
		[Token(Token = "0x400002D")]
		Challenge,
		[Token(Token = "0x400002E")]
		Commerce,
		[Token(Token = "0x400002F")]
		Core,
		[Token(Token = "0x4000030")]
		EventsClient,
		[Token(Token = "0x4000031")]
		Friends,
		[Token(Token = "0x4000032")]
		Matching,
		[Token(Token = "0x4000033")]
		Messaging,
		[Token(Token = "0x4000034")]
		NetworkUtils,
		[Token(Token = "0x4000035")]
		Notification,
		[Token(Token = "0x4000036")]
		NpUtils,
		[Token(Token = "0x4000037")]
		Presence,
		[Token(Token = "0x4000038")]
		Ranking,
		[Token(Token = "0x4000039")]
		Session,
		[Token(Token = "0x400003A")]
		SharedMedia,
		[Token(Token = "0x400003B")]
		Tournament,
		[Token(Token = "0x400003C")]
		Trophy,
		[Token(Token = "0x400003D")]
		Tss,
		[Token(Token = "0x400003E")]
		Tus,
		[Token(Token = "0x400003F")]
		UserProfile,
		[Token(Token = "0x4000040")]
		WordFilter,
		[Token(Token = "0x4000041")]
		Size
	}
	[Token(Token = "0x200000D")]
	internal enum ServiceTypes_SDK6_5
	{
		[Token(Token = "0x4000043")]
		Invalid,
		[Token(Token = "0x4000044")]
		ActivityFeed,
		[Token(Token = "0x4000045")]
		Auth,
		[Token(Token = "0x4000046")]
		Challenge,
		[Token(Token = "0x4000047")]
		Commerce,
		[Token(Token = "0x4000048")]
		Core,
		[Token(Token = "0x4000049")]
		EventsClient,
		[Token(Token = "0x400004A")]
		Friends,
		[Token(Token = "0x400004B")]
		Matching,
		[Token(Token = "0x400004C")]
		Messaging,
		[Token(Token = "0x400004D")]
		NetworkUtils,
		[Token(Token = "0x400004E")]
		Notification,
		[Token(Token = "0x400004F")]
		NpUtils,
		[Token(Token = "0x4000050")]
		Presence,
		[Token(Token = "0x4000051")]
		Ranking,
		[Token(Token = "0x4000052")]
		Session,
		[Token(Token = "0x4000053")]
		SharedMedia,
		[Token(Token = "0x4000054")]
		SocialMedia,
		[Token(Token = "0x4000055")]
		Tournament,
		[Token(Token = "0x4000056")]
		Trophy,
		[Token(Token = "0x4000057")]
		Tss,
		[Token(Token = "0x4000058")]
		Tus,
		[Token(Token = "0x4000059")]
		UserProfile,
		[Token(Token = "0x400005A")]
		WordFilter,
		[Token(Token = "0x400005B")]
		Size
	}
	[Token(Token = "0x200000E")]
	internal enum FunctionTypes_SDK4_5
	{
		[Token(Token = "0x400005D")]
		Invalid,
		[Token(Token = "0x400005E")]
		ActivityFeedGetSharedVideos,
		[Token(Token = "0x400005F")]
		ActivityFeedGetPlayedWith,
		[Token(Token = "0x4000060")]
		ActivityFeedPostPlayedWith,
		[Token(Token = "0x4000061")]
		ActivityFeedGetWhoLiked,
		[Token(Token = "0x4000062")]
		ActivityFeedSetLiked,
		[Token(Token = "0x4000063")]
		ActivityFeedGetFeed,
		[Token(Token = "0x4000064")]
		ActivityFeedPostInGameStory,
		[Token(Token = "0x4000065")]
		AuthGetAuthCode,
		[Token(Token = "0x4000066")]
		AuthGetIdToken,
		[Token(Token = "0x4000067")]
		ChallengeConsumeChallenge,
		[Token(Token = "0x4000068")]
		ChallengeSendChallenge,
		[Token(Token = "0x4000069")]
		ChallengeGetReceivedChallenges,
		[Token(Token = "0x400006A")]
		ChallengeGetChallengeData,
		[Token(Token = "0x400006B")]
		ChallengeGetChallengeThumbnail,
		[Token(Token = "0x400006C")]
		CommerceGetCategories,
		[Token(Token = "0x400006D")]
		CommerceGetProducts,
		[Token(Token = "0x400006E")]
		CommerceGetServiceEntitlements,
		[Token(Token = "0x400006F")]
		CommerceConsumeServiceEntitlement,
		[Token(Token = "0x4000070")]
		CommerceDisplayCategoryBrowseDialog,
		[Token(Token = "0x4000071")]
		CommerceDisplayProductBrowseDialog,
		[Token(Token = "0x4000072")]
		CommerceDisplayVoucherCodeInputDialog,
		[Token(Token = "0x4000073")]
		CommerceDisplayCheckoutDialog,
		[Token(Token = "0x4000074")]
		CommerceDisplayJoinPlusDialog,
		[Token(Token = "0x4000075")]
		CommerceDisplayDownloadListDialog,
		[Token(Token = "0x4000076")]
		CommerceSetPsStoreIconDisplayState,
		[Token(Token = "0x4000077")]
		EventsClientGetEvent,
		[Token(Token = "0x4000078")]
		FriendsGetFriends,
		[Token(Token = "0x4000079")]
		FriendsGetFriendsOfFriends,
		[Token(Token = "0x400007A")]
		FriendsGetBlockedUsers,
		[Token(Token = "0x400007B")]
		FriendsDisplayFriendRequestDialog,
		[Token(Token = "0x400007C")]
		FriendsDisplayBlockUserDialog,
		[Token(Token = "0x400007D")]
		MatchingSetInitConfiguration,
		[Token(Token = "0x400007E")]
		MatchingGetWorlds,
		[Token(Token = "0x400007F")]
		MatchingCreateRoom,
		[Token(Token = "0x4000080")]
		MatchingLeaveRoom,
		[Token(Token = "0x4000081")]
		MatchingSearchRooms,
		[Token(Token = "0x4000082")]
		MatchingJoinRoom,
		[Token(Token = "0x4000083")]
		MatchingGetRoomPingTime,
		[Token(Token = "0x4000084")]
		MatchingKickOutRoomMember,
		[Token(Token = "0x4000085")]
		MatchingSendRoomMessage,
		[Token(Token = "0x4000086")]
		MatchingGetAttributes,
		[Token(Token = "0x4000087")]
		MatchingSetRoomInfo,
		[Token(Token = "0x4000088")]
		MatchingSendInvitation,
		[Token(Token = "0x4000089")]
		MatchingGetData,
		[Token(Token = "0x400008A")]
		MatchingSetMembersAsRecentlyMet,
		[Token(Token = "0x400008B")]
		MessagingSendInGameMessage,
		[Token(Token = "0x400008C")]
		MessagingSendGameDataMessage,
		[Token(Token = "0x400008D")]
		MessagingDisplayReceivedGameDataMessagesDialog,
		[Token(Token = "0x400008E")]
		MessagingGetReceivedGameDataMessages,
		[Token(Token = "0x400008F")]
		MessagingConsumeGameDataMessage,
		[Token(Token = "0x4000090")]
		MessagingGetGameDataMessageThumbnail,
		[Token(Token = "0x4000091")]
		MessagingGetGameDataMessageAttachment,
		[Token(Token = "0x4000092")]
		NetworkUtilsGetBandwidthInfo,
		[Token(Token = "0x4000093")]
		NetworkUtilsGetBasicNetworkInfo,
		[Token(Token = "0x4000094")]
		NetworkUtilsGetDetailedNetworkInfo,
		[Token(Token = "0x4000095")]
		NpUtilsDisplaySigninDialog,
		[Token(Token = "0x4000096")]
		NpUtilsSetTitleIdForDevelopment,
		[Token(Token = "0x4000097")]
		NpUtilsCheckAvailability,
		[Token(Token = "0x4000098")]
		PresenceSetPresence,
		[Token(Token = "0x4000099")]
		PresenceGetPresence,
		[Token(Token = "0x400009A")]
		PresenceDeletePresence,
		[Token(Token = "0x400009B")]
		RankingSetScore,
		[Token(Token = "0x400009C")]
		RankingGetRangeOfRanks,
		[Token(Token = "0x400009D")]
		RankingGetFriendsRanks,
		[Token(Token = "0x400009E")]
		RankingGetUsersRanks,
		[Token(Token = "0x400009F")]
		RankingSetGameData,
		[Token(Token = "0x40000A0")]
		RankingGetGameData,
		[Token(Token = "0x40000A1")]
		SessionSendInvitation,
		[Token(Token = "0x40000A2")]
		SessionDisplayReceivedInvitationsDialog,
		[Token(Token = "0x40000A3")]
		SessionGetReceivedInvitations,
		[Token(Token = "0x40000A4")]
		SessionGetInvitationData,
		[Token(Token = "0x40000A5")]
		SessionConsumeInvitation,
		[Token(Token = "0x40000A6")]
		SessionGetData,
		[Token(Token = "0x40000A7")]
		SessionLeave,
		[Token(Token = "0x40000A8")]
		SessionUpdate,
		[Token(Token = "0x40000A9")]
		SessionGetInfo,
		[Token(Token = "0x40000AA")]
		SessionJoin,
		[Token(Token = "0x40000AB")]
		SessionSearch,
		[Token(Token = "0x40000AC")]
		SessionCreate,
		[Token(Token = "0x40000AD")]
		SocialMediaPostMessageToFacebook,
		[Token(Token = "0x40000AE")]
		SharedMediaGetScreenshots,
		[Token(Token = "0x40000AF")]
		SharedMediaGetBroadcasts,
		[Token(Token = "0x40000B0")]
		SharedMediaGetVideos,
		[Token(Token = "0x40000B1")]
		TrophyRegisterTrophyPack,
		[Token(Token = "0x40000B2")]
		TrophyUnlock,
		[Token(Token = "0x40000B3")]
		TrophySetScreenshot,
		[Token(Token = "0x40000B4")]
		TrophyGetUnlockedTrophies,
		[Token(Token = "0x40000B5")]
		TrophyDisplayTrophyListDialog,
		[Token(Token = "0x40000B6")]
		TrophyGetTrophyPackSummary,
		[Token(Token = "0x40000B7")]
		TrophyGetTrophyPackGroup,
		[Token(Token = "0x40000B8")]
		TrophyGetTrophyPackTrophy,
		[Token(Token = "0x40000B9")]
		TssGetData,
		[Token(Token = "0x40000BA")]
		TusSetVariables,
		[Token(Token = "0x40000BB")]
		TusGetVariables,
		[Token(Token = "0x40000BC")]
		TusAddToAndGetVariable,
		[Token(Token = "0x40000BD")]
		TusSetData,
		[Token(Token = "0x40000BE")]
		TusGetData,
		[Token(Token = "0x40000BF")]
		TusDeleteData,
		[Token(Token = "0x40000C0")]
		UserProfileGetNpProfiles,
		[Token(Token = "0x40000C1")]
		UserProfileGetVerifiedAccountsForTitle,
		[Token(Token = "0x40000C2")]
		UserProfileDisplayUserProfileDialog,
		[Token(Token = "0x40000C3")]
		UserProfileDisplayGriefReportingDialog,
		[Token(Token = "0x40000C4")]
		WordfilterFilterComment,
		[Token(Token = "0x40000C5")]
		CoreTerminateService,
		[Token(Token = "0x40000C6")]
		NotificationRefreshRoom,
		[Token(Token = "0x40000C7")]
		NotificationNewRoomMessage,
		[Token(Token = "0x40000C8")]
		NotificationDialogOpened,
		[Token(Token = "0x40000C9")]
		NotificationDialogClosed,
		[Token(Token = "0x40000CA")]
		NotificationUserStateChange,
		[Token(Token = "0x40000CB")]
		NotificationNetStateChange,
		[Token(Token = "0x40000CC")]
		NotificationNewInGameMessage,
		[Token(Token = "0x40000CD")]
		NotificationUpdateFriendsList,
		[Token(Token = "0x40000CE")]
		NotificationNewInvitation,
		[Token(Token = "0x40000CF")]
		NotificationNewGameDataMessage,
		[Token(Token = "0x40000D0")]
		NotificationUpdateFriendPresence,
		[Token(Token = "0x40000D1")]
		NotificationUpdateBlockedUsersList,
		[Token(Token = "0x40000D2")]
		NotificationAborted,
		[Token(Token = "0x40000D3")]
		NumFunctionTypes,
		[Token(Token = "0x40000D4")]
		NotificationSessionInvitationEvent,
		[Token(Token = "0x40000D5")]
		NotificationPlayTogetherHostEvent,
		[Token(Token = "0x40000D6")]
		NotificationGameCustomDataEvent,
		[Token(Token = "0x40000D7")]
		NotificationLaunchAppEvent,
		[Token(Token = "0x40000D8")]
		NpUtilsCheckPlus,
		[Token(Token = "0x40000D9")]
		NpUtilsGetParentalControlInfo
	}
	[Token(Token = "0x200000F")]
	public enum FunctionTypes_SDK6_0
	{
		[Token(Token = "0x40000DB")]
		Invalid,
		[Token(Token = "0x40000DC")]
		ActivityFeedGetSharedVideos,
		[Token(Token = "0x40000DD")]
		ActivityFeedGetPlayedWith,
		[Token(Token = "0x40000DE")]
		ActivityFeedPostPlayedWith,
		[Token(Token = "0x40000DF")]
		ActivityFeedGetWhoLiked,
		[Token(Token = "0x40000E0")]
		ActivityFeedSetLiked,
		[Token(Token = "0x40000E1")]
		ActivityFeedGetFeed,
		[Token(Token = "0x40000E2")]
		ActivityFeedPostInGameStory,
		[Token(Token = "0x40000E3")]
		AuthGetAuthCode,
		[Token(Token = "0x40000E4")]
		AuthGetIdToken,
		[Token(Token = "0x40000E5")]
		ChallengeConsumeChallenge,
		[Token(Token = "0x40000E6")]
		ChallengeSendChallenge,
		[Token(Token = "0x40000E7")]
		ChallengeGetReceivedChallenges,
		[Token(Token = "0x40000E8")]
		ChallengeGetChallengeData,
		[Token(Token = "0x40000E9")]
		ChallengeGetChallengeThumbnail,
		[Token(Token = "0x40000EA")]
		CommerceGetCategories,
		[Token(Token = "0x40000EB")]
		CommerceGetProducts,
		[Token(Token = "0x40000EC")]
		CommerceGetServiceEntitlements,
		[Token(Token = "0x40000ED")]
		CommerceConsumeServiceEntitlement,
		[Token(Token = "0x40000EE")]
		CommerceDisplayCategoryBrowseDialog,
		[Token(Token = "0x40000EF")]
		CommerceDisplayProductBrowseDialog,
		[Token(Token = "0x40000F0")]
		CommerceDisplayVoucherCodeInputDialog,
		[Token(Token = "0x40000F1")]
		CommerceDisplayCheckoutDialog,
		[Token(Token = "0x40000F2")]
		CommerceDisplayJoinPlusDialog,
		[Token(Token = "0x40000F3")]
		CommerceDisplayDownloadListDialog,
		[Token(Token = "0x40000F4")]
		CommerceSetPsStoreIconDisplayState,
		[Token(Token = "0x40000F5")]
		CommerceGetContainers,
		[Token(Token = "0x40000F6")]
		CoreTerminateService,
		[Token(Token = "0x40000F7")]
		EventsClientGetEvent,
		[Token(Token = "0x40000F8")]
		FriendsGetFriends,
		[Token(Token = "0x40000F9")]
		FriendsGetFriendsOfFriends,
		[Token(Token = "0x40000FA")]
		FriendsGetBlockedUsers,
		[Token(Token = "0x40000FB")]
		FriendsDisplayFriendRequestDialog,
		[Token(Token = "0x40000FC")]
		FriendsDisplayBlockUserDialog,
		[Token(Token = "0x40000FD")]
		MatchingSetInitConfiguration,
		[Token(Token = "0x40000FE")]
		MatchingGetWorlds,
		[Token(Token = "0x40000FF")]
		MatchingCreateRoom,
		[Token(Token = "0x4000100")]
		MatchingLeaveRoom,
		[Token(Token = "0x4000101")]
		MatchingSearchRooms,
		[Token(Token = "0x4000102")]
		MatchingJoinRoom,
		[Token(Token = "0x4000103")]
		MatchingGetRoomPingTime,
		[Token(Token = "0x4000104")]
		MatchingKickOutRoomMember,
		[Token(Token = "0x4000105")]
		MatchingSendRoomMessage,
		[Token(Token = "0x4000106")]
		MatchingGetAttributes,
		[Token(Token = "0x4000107")]
		MatchingSetRoomInfo,
		[Token(Token = "0x4000108")]
		MatchingSendInvitation,
		[Token(Token = "0x4000109")]
		MatchingGetData,
		[Token(Token = "0x400010A")]
		MatchingSetMembersAsRecentlyMet,
		[Token(Token = "0x400010B")]
		MessagingSendInGameMessage,
		[Token(Token = "0x400010C")]
		MessagingSendGameDataMessage,
		[Token(Token = "0x400010D")]
		MessagingDisplayReceivedGameDataMessagesDialog,
		[Token(Token = "0x400010E")]
		MessagingGetReceivedGameDataMessages,
		[Token(Token = "0x400010F")]
		MessagingConsumeGameDataMessage,
		[Token(Token = "0x4000110")]
		MessagingGetGameDataMessageThumbnail,
		[Token(Token = "0x4000111")]
		MessagingGetGameDataMessageAttachment,
		[Token(Token = "0x4000112")]
		NetworkUtilsGetBandwidthInfo,
		[Token(Token = "0x4000113")]
		NetworkUtilsGetBasicNetworkInfo,
		[Token(Token = "0x4000114")]
		NetworkUtilsGetDetailedNetworkInfo,
		[Token(Token = "0x4000115")]
		NotificationRefreshRoom,
		[Token(Token = "0x4000116")]
		NotificationNewRoomMessage,
		[Token(Token = "0x4000117")]
		NotificationDialogOpened,
		[Token(Token = "0x4000118")]
		NotificationDialogClosed,
		[Token(Token = "0x4000119")]
		NotificationUserStateChange,
		[Token(Token = "0x400011A")]
		NotificationNetStateChange,
		[Token(Token = "0x400011B")]
		NotificationNewInGameMessage,
		[Token(Token = "0x400011C")]
		NotificationUpdateFriendsList,
		[Token(Token = "0x400011D")]
		NotificationNewInvitation,
		[Token(Token = "0x400011E")]
		NotificationNewGameDataMessage,
		[Token(Token = "0x400011F")]
		NotificationUpdateFriendPresence,
		[Token(Token = "0x4000120")]
		NotificationUpdateBlockedUsersList,
		[Token(Token = "0x4000121")]
		NotificationAborted,
		[Token(Token = "0x4000122")]
		NpUtilsDisplaySigninDialog,
		[Token(Token = "0x4000123")]
		NpUtilsSetTitleIdForDevelopment,
		[Token(Token = "0x4000124")]
		NpUtilsCheckAvailability,
		[Token(Token = "0x4000125")]
		NpUtilsCheckPsPlusAccess,
		[Token(Token = "0x4000126")]
		NpUtilsGetAccountIdByOnlineId,
		[Token(Token = "0x4000127")]
		NpUtilsGetOnlineIdByAccountId,
		[Token(Token = "0x4000128")]
		PresenceSetPresence,
		[Token(Token = "0x4000129")]
		PresenceGetPresence,
		[Token(Token = "0x400012A")]
		PresenceDeletePresence,
		[Token(Token = "0x400012B")]
		RankingSetScore,
		[Token(Token = "0x400012C")]
		RankingGetRangeOfRanks,
		[Token(Token = "0x400012D")]
		RankingGetFriendsRanks,
		[Token(Token = "0x400012E")]
		RankingGetUsersRanks,
		[Token(Token = "0x400012F")]
		RankingSetGameData,
		[Token(Token = "0x4000130")]
		RankingGetGameData,
		[Token(Token = "0x4000131")]
		SessionSendInvitation,
		[Token(Token = "0x4000132")]
		SessionDisplayReceivedInvitationsDialog,
		[Token(Token = "0x4000133")]
		SessionGetReceivedInvitations,
		[Token(Token = "0x4000134")]
		SessionGetInvitationData,
		[Token(Token = "0x4000135")]
		SessionConsumeInvitation,
		[Token(Token = "0x4000136")]
		SessionGetData,
		[Token(Token = "0x4000137")]
		SessionLeave,
		[Token(Token = "0x4000138")]
		SessionUpdate,
		[Token(Token = "0x4000139")]
		SessionGetInfo,
		[Token(Token = "0x400013A")]
		SessionJoin,
		[Token(Token = "0x400013B")]
		SessionSearch,
		[Token(Token = "0x400013C")]
		SessionCreate,
		[Token(Token = "0x400013D")]
		SharedMediaGetScreenshots,
		[Token(Token = "0x400013E")]
		SharedMediaGetBroadcasts,
		[Token(Token = "0x400013F")]
		SharedMediaGetVideos,
		[Token(Token = "0x4000140")]
		SocialMediaPostMessageToFacebook,
		[Token(Token = "0x4000141")]
		TournamentSearchEvents,
		[Token(Token = "0x4000142")]
		TournamentGetEvent,
		[Token(Token = "0x4000143")]
		TournamentGetRegisteredUsers,
		[Token(Token = "0x4000144")]
		TournamentGetRegisteredTeams,
		[Token(Token = "0x4000145")]
		TournamentGetRegisteredRoster,
		[Token(Token = "0x4000146")]
		TournamentGetBracket,
		[Token(Token = "0x4000147")]
		TournamentSendUserMatchReport,
		[Token(Token = "0x4000148")]
		TournamentSendTeamMatchReport,
		[Token(Token = "0x4000149")]
		TrophyRegisterTrophyPack,
		[Token(Token = "0x400014A")]
		TrophyUnlock,
		[Token(Token = "0x400014B")]
		TrophySetScreenshot,
		[Token(Token = "0x400014C")]
		TrophyGetUnlockedTrophies,
		[Token(Token = "0x400014D")]
		TrophyDisplayTrophyListDialog,
		[Token(Token = "0x400014E")]
		TrophyGetTrophyPackSummary,
		[Token(Token = "0x400014F")]
		TrophyGetTrophyPackGroup,
		[Token(Token = "0x4000150")]
		TrophyGetTrophyPackTrophy,
		[Token(Token = "0x4000151")]
		TssGetData,
		[Token(Token = "0x4000152")]
		TusGetVariables,
		[Token(Token = "0x4000153")]
		TusSetVariables,
		[Token(Token = "0x4000154")]
		TusGetFriendsVariable,
		[Token(Token = "0x4000155")]
		TusAddToAndGetVariable,
		[Token(Token = "0x4000156")]
		TusTryAndSetVariable,
		[Token(Token = "0x4000157")]
		TusGetData,
		[Token(Token = "0x4000158")]
		TusSetData,
		[Token(Token = "0x4000159")]
		TusDeleteData,
		[Token(Token = "0x400015A")]
		TusGetUsersVariable,
		[Token(Token = "0x400015B")]
		TusGetUsersDataStatus,
		[Token(Token = "0x400015C")]
		TusGetFriendsDataStatus,
		[Token(Token = "0x400015D")]
		UserProfileGetNpProfiles,
		[Token(Token = "0x400015E")]
		UserProfileGetVerifiedAccountsForTitle,
		[Token(Token = "0x400015F")]
		UserProfileDisplayUserProfileDialog,
		[Token(Token = "0x4000160")]
		UserProfileDisplayGriefReportingDialog,
		[Token(Token = "0x4000161")]
		WordfilterFilterComment,
		[Token(Token = "0x4000162")]
		NumFunctionTypes,
		[Token(Token = "0x4000163")]
		NotificationSessionInvitationEvent,
		[Token(Token = "0x4000164")]
		NotificationPlayTogetherHostEvent,
		[Token(Token = "0x4000165")]
		NotificationGameCustomDataEvent,
		[Token(Token = "0x4000166")]
		NotificationLaunchAppEvent,
		[Token(Token = "0x4000167")]
		NpUtilsCheckPlus,
		[Token(Token = "0x4000168")]
		NpUtilsGetParentalControlInfo
	}
	[Token(Token = "0x2000010")]
	public enum FunctionTypes_SDK6_5
	{
		[Token(Token = "0x400016A")]
		Invalid,
		[Token(Token = "0x400016B")]
		ActivityFeedGetSharedVideos,
		[Token(Token = "0x400016C")]
		ActivityFeedGetPlayedWith,
		[Token(Token = "0x400016D")]
		ActivityFeedPostPlayedWith,
		[Token(Token = "0x400016E")]
		ActivityFeedGetWhoLiked,
		[Token(Token = "0x400016F")]
		ActivityFeedSetLiked,
		[Token(Token = "0x4000170")]
		ActivityFeedGetFeed,
		[Token(Token = "0x4000171")]
		ActivityFeedPostInGameStory,
		[Token(Token = "0x4000172")]
		AuthGetAuthCode,
		[Token(Token = "0x4000173")]
		AuthGetIdToken,
		[Token(Token = "0x4000174")]
		ChallengeConsumeChallenge,
		[Token(Token = "0x4000175")]
		ChallengeSendChallenge,
		[Token(Token = "0x4000176")]
		ChallengeGetReceivedChallenges,
		[Token(Token = "0x4000177")]
		ChallengeGetChallengeData,
		[Token(Token = "0x4000178")]
		ChallengeGetChallengeThumbnail,
		[Token(Token = "0x4000179")]
		CommerceGetCategories,
		[Token(Token = "0x400017A")]
		CommerceGetProducts,
		[Token(Token = "0x400017B")]
		CommerceGetServiceEntitlements,
		[Token(Token = "0x400017C")]
		CommerceConsumeServiceEntitlement,
		[Token(Token = "0x400017D")]
		CommerceDisplayCategoryBrowseDialog,
		[Token(Token = "0x400017E")]
		CommerceDisplayProductBrowseDialog,
		[Token(Token = "0x400017F")]
		CommerceDisplayVoucherCodeInputDialog,
		[Token(Token = "0x4000180")]
		CommerceDisplayCheckoutDialog,
		[Token(Token = "0x4000181")]
		CommerceDisplayJoinPlusDialog,
		[Token(Token = "0x4000182")]
		CommerceDisplayDownloadListDialog,
		[Token(Token = "0x4000183")]
		CommerceSetPsStoreIconDisplayState,
		[Token(Token = "0x4000184")]
		CommerceGetContainers,
		[Token(Token = "0x4000185")]
		CoreTerminateService,
		[Token(Token = "0x4000186")]
		EventsClientGetEvent,
		[Token(Token = "0x4000187")]
		FriendsGetFriends,
		[Token(Token = "0x4000188")]
		FriendsGetFriendsOfFriends,
		[Token(Token = "0x4000189")]
		FriendsGetBlockedUsers,
		[Token(Token = "0x400018A")]
		FriendsDisplayFriendRequestDialog,
		[Token(Token = "0x400018B")]
		FriendsDisplayBlockUserDialog,
		[Token(Token = "0x400018C")]
		MatchingSetInitConfiguration,
		[Token(Token = "0x400018D")]
		MatchingGetWorlds,
		[Token(Token = "0x400018E")]
		MatchingCreateRoom,
		[Token(Token = "0x400018F")]
		MatchingLeaveRoom,
		[Token(Token = "0x4000190")]
		MatchingSearchRooms,
		[Token(Token = "0x4000191")]
		MatchingJoinRoom,
		[Token(Token = "0x4000192")]
		MatchingGetRoomPingTime,
		[Token(Token = "0x4000193")]
		MatchingKickOutRoomMember,
		[Token(Token = "0x4000194")]
		MatchingSendRoomMessage,
		[Token(Token = "0x4000195")]
		MatchingGetAttributes,
		[Token(Token = "0x4000196")]
		MatchingSetRoomInfo,
		[Token(Token = "0x4000197")]
		MatchingSendInvitation,
		[Token(Token = "0x4000198")]
		MatchingGetData,
		[Token(Token = "0x4000199")]
		MatchingSetMembersAsRecentlyMet,
		[Token(Token = "0x400019A")]
		MessagingSendInGameMessage,
		[Token(Token = "0x400019B")]
		MessagingSendGameDataMessage,
		[Token(Token = "0x400019C")]
		MessagingDisplayReceivedGameDataMessagesDialog,
		[Token(Token = "0x400019D")]
		MessagingGetReceivedGameDataMessages,
		[Token(Token = "0x400019E")]
		MessagingConsumeGameDataMessage,
		[Token(Token = "0x400019F")]
		MessagingGetGameDataMessageThumbnail,
		[Token(Token = "0x40001A0")]
		MessagingGetGameDataMessageAttachment,
		[Token(Token = "0x40001A1")]
		NetworkUtilsGetBandwidthInfo,
		[Token(Token = "0x40001A2")]
		NetworkUtilsGetBasicNetworkInfo,
		[Token(Token = "0x40001A3")]
		NetworkUtilsGetDetailedNetworkInfo,
		[Token(Token = "0x40001A4")]
		NotificationRefreshRoom,
		[Token(Token = "0x40001A5")]
		NotificationNewRoomMessage,
		[Token(Token = "0x40001A6")]
		NotificationDialogOpened,
		[Token(Token = "0x40001A7")]
		NotificationDialogClosed,
		[Token(Token = "0x40001A8")]
		NotificationUserStateChange,
		[Token(Token = "0x40001A9")]
		NotificationNetStateChange,
		[Token(Token = "0x40001AA")]
		NotificationNewInGameMessage,
		[Token(Token = "0x40001AB")]
		NotificationUpdateFriendsList,
		[Token(Token = "0x40001AC")]
		NotificationNewInvitation,
		[Token(Token = "0x40001AD")]
		NotificationNewGameDataMessage,
		[Token(Token = "0x40001AE")]
		NotificationUpdateFriendPresence,
		[Token(Token = "0x40001AF")]
		NotificationUpdateBlockedUsersList,
		[Token(Token = "0x40001B0")]
		NotificationAborted,
		[Token(Token = "0x40001B1")]
		NpUtilsDisplaySigninDialog,
		[Token(Token = "0x40001B2")]
		NpUtilsSetTitleIdForDevelopment,
		[Token(Token = "0x40001B3")]
		NpUtilsCheckAvailability,
		[Token(Token = "0x40001B4")]
		NpUtilsCheckPsPlusAccess,
		[Token(Token = "0x40001B5")]
		NpUtilsGetAccountIdByOnlineId,
		[Token(Token = "0x40001B6")]
		NpUtilsGetOnlineIdByAccountId,
		[Token(Token = "0x40001B7")]
		PresenceSetPresence,
		[Token(Token = "0x40001B8")]
		PresenceGetPresence,
		[Token(Token = "0x40001B9")]
		PresenceDeletePresence,
		[Token(Token = "0x40001BA")]
		RankingSetScore,
		[Token(Token = "0x40001BB")]
		RankingGetRangeOfRanks,
		[Token(Token = "0x40001BC")]
		RankingGetFriendsRanks,
		[Token(Token = "0x40001BD")]
		RankingGetUsersRanks,
		[Token(Token = "0x40001BE")]
		RankingSetGameData,
		[Token(Token = "0x40001BF")]
		RankingGetGameData,
		[Token(Token = "0x40001C0")]
		SessionSendInvitation,
		[Token(Token = "0x40001C1")]
		SessionDisplayReceivedInvitationsDialog,
		[Token(Token = "0x40001C2")]
		SessionGetReceivedInvitations,
		[Token(Token = "0x40001C3")]
		SessionGetInvitationData,
		[Token(Token = "0x40001C4")]
		SessionConsumeInvitation,
		[Token(Token = "0x40001C5")]
		SessionGetData,
		[Token(Token = "0x40001C6")]
		SessionLeave,
		[Token(Token = "0x40001C7")]
		SessionUpdate,
		[Token(Token = "0x40001C8")]
		SessionGetInfo,
		[Token(Token = "0x40001C9")]
		SessionJoin,
		[Token(Token = "0x40001CA")]
		SessionSearch,
		[Token(Token = "0x40001CB")]
		SessionCreate,
		[Token(Token = "0x40001CC")]
		SharedMediaGetScreenshots,
		[Token(Token = "0x40001CD")]
		SharedMediaGetBroadcasts,
		[Token(Token = "0x40001CE")]
		SharedMediaGetVideos,
		[Token(Token = "0x40001CF")]
		SocialMediaPostMessageToFacebook,
		[Token(Token = "0x40001D0")]
		TournamentSearchEvents,
		[Token(Token = "0x40001D1")]
		TournamentGetEvent,
		[Token(Token = "0x40001D2")]
		TournamentGetRegisteredUsers,
		[Token(Token = "0x40001D3")]
		TournamentGetRegisteredTeams,
		[Token(Token = "0x40001D4")]
		TournamentGetRegisteredRoster,
		[Token(Token = "0x40001D5")]
		TournamentGetBracket,
		[Token(Token = "0x40001D6")]
		TournamentSendUserMatchReport,
		[Token(Token = "0x40001D7")]
		TournamentSendTeamMatchReport,
		[Token(Token = "0x40001D8")]
		TrophyRegisterTrophyPack,
		[Token(Token = "0x40001D9")]
		TrophyUnlock,
		[Token(Token = "0x40001DA")]
		TrophySetScreenshot,
		[Token(Token = "0x40001DB")]
		TrophyGetUnlockedTrophies,
		[Token(Token = "0x40001DC")]
		TrophyDisplayTrophyListDialog,
		[Token(Token = "0x40001DD")]
		TrophyGetTrophyPackSummary,
		[Token(Token = "0x40001DE")]
		TrophyGetTrophyPackGroup,
		[Token(Token = "0x40001DF")]
		TrophyGetTrophyPackTrophy,
		[Token(Token = "0x40001E0")]
		TssGetData,
		[Token(Token = "0x40001E1")]
		TusGetVariables,
		[Token(Token = "0x40001E2")]
		TusSetVariables,
		[Token(Token = "0x40001E3")]
		TusGetFriendsVariable,
		[Token(Token = "0x40001E4")]
		TusAddToAndGetVariable,
		[Token(Token = "0x40001E5")]
		TusTryAndSetVariable,
		[Token(Token = "0x40001E6")]
		TusGetData,
		[Token(Token = "0x40001E7")]
		TusSetData,
		[Token(Token = "0x40001E8")]
		TusDeleteData,
		[Token(Token = "0x40001E9")]
		TusGetUsersVariable,
		[Token(Token = "0x40001EA")]
		TusGetUsersDataStatus,
		[Token(Token = "0x40001EB")]
		TusGetFriendsDataStatus,
		[Token(Token = "0x40001EC")]
		UserProfileGetNpProfiles,
		[Token(Token = "0x40001ED")]
		UserProfileGetVerifiedAccountsForTitle,
		[Token(Token = "0x40001EE")]
		UserProfileDisplayUserProfileDialog,
		[Token(Token = "0x40001EF")]
		UserProfileDisplayGriefReportingDialog,
		[Token(Token = "0x40001F0")]
		WordfilterFilterComment,
		[Token(Token = "0x40001F1")]
		Internal1,
		[Token(Token = "0x40001F2")]
		Internal2,
		[Token(Token = "0x40001F3")]
		NumFunctionTypes,
		[Token(Token = "0x40001F4")]
		NotificationSessionInvitationEvent,
		[Token(Token = "0x40001F5")]
		NotificationPlayTogetherHostEvent,
		[Token(Token = "0x40001F6")]
		NotificationGameCustomDataEvent,
		[Token(Token = "0x40001F7")]
		NotificationLaunchAppEvent,
		[Token(Token = "0x40001F8")]
		NpUtilsCheckPlus,
		[Token(Token = "0x40001F9")]
		NpUtilsGetParentalControlInfo
	}
	[Token(Token = "0x2000011")]
	public enum FunctionTypes_SDK7_0
	{
		[Token(Token = "0x40001FB")]
		Invalid,
		[Token(Token = "0x40001FC")]
		ActivityFeedGetSharedVideos,
		[Token(Token = "0x40001FD")]
		ActivityFeedGetPlayedWith,
		[Token(Token = "0x40001FE")]
		ActivityFeedPostPlayedWith,
		[Token(Token = "0x40001FF")]
		ActivityFeedGetWhoLiked,
		[Token(Token = "0x4000200")]
		ActivityFeedSetLiked,
		[Token(Token = "0x4000201")]
		ActivityFeedGetFeed,
		[Token(Token = "0x4000202")]
		ActivityFeedPostInGameStory,
		[Token(Token = "0x4000203")]
		AuthGetAuthCode,
		[Token(Token = "0x4000204")]
		AuthGetIdToken,
		[Token(Token = "0x4000205")]
		ChallengeConsumeChallenge,
		[Token(Token = "0x4000206")]
		ChallengeSendChallenge,
		[Token(Token = "0x4000207")]
		ChallengeGetReceivedChallenges,
		[Token(Token = "0x4000208")]
		ChallengeGetChallengeData,
		[Token(Token = "0x4000209")]
		ChallengeGetChallengeThumbnail,
		[Token(Token = "0x400020A")]
		CommerceGetCategories,
		[Token(Token = "0x400020B")]
		CommerceGetProducts,
		[Token(Token = "0x400020C")]
		CommerceGetServiceEntitlements,
		[Token(Token = "0x400020D")]
		CommerceConsumeServiceEntitlement,
		[Token(Token = "0x400020E")]
		CommerceDisplayCategoryBrowseDialog,
		[Token(Token = "0x400020F")]
		CommerceDisplayProductBrowseDialog,
		[Token(Token = "0x4000210")]
		CommerceDisplayVoucherCodeInputDialog,
		[Token(Token = "0x4000211")]
		CommerceDisplayCheckoutDialog,
		[Token(Token = "0x4000212")]
		CommerceDisplayJoinPlusDialog,
		[Token(Token = "0x4000213")]
		CommerceDisplayDownloadListDialog,
		[Token(Token = "0x4000214")]
		CommerceSetPsStoreIconDisplayState,
		[Token(Token = "0x4000215")]
		CommerceGetContainers,
		[Token(Token = "0x4000216")]
		CoreTerminateService,
		[Token(Token = "0x4000217")]
		EventsClientGetEvent,
		[Token(Token = "0x4000218")]
		FriendsGetFriends,
		[Token(Token = "0x4000219")]
		FriendsGetFriendsOfFriends,
		[Token(Token = "0x400021A")]
		FriendsGetBlockedUsers,
		[Token(Token = "0x400021B")]
		FriendsDisplayFriendRequestDialog,
		[Token(Token = "0x400021C")]
		FriendsDisplayBlockUserDialog,
		[Token(Token = "0x400021D")]
		MatchingSetInitConfiguration,
		[Token(Token = "0x400021E")]
		MatchingGetWorlds,
		[Token(Token = "0x400021F")]
		MatchingCreateRoom,
		[Token(Token = "0x4000220")]
		MatchingLeaveRoom,
		[Token(Token = "0x4000221")]
		MatchingSearchRooms,
		[Token(Token = "0x4000222")]
		MatchingJoinRoom,
		[Token(Token = "0x4000223")]
		MatchingGetRoomPingTime,
		[Token(Token = "0x4000224")]
		MatchingKickOutRoomMember,
		[Token(Token = "0x4000225")]
		MatchingSendRoomMessage,
		[Token(Token = "0x4000226")]
		MatchingGetAttributes,
		[Token(Token = "0x4000227")]
		MatchingSetRoomInfo,
		[Token(Token = "0x4000228")]
		MatchingSendInvitation,
		[Token(Token = "0x4000229")]
		MatchingGetData,
		[Token(Token = "0x400022A")]
		MatchingSetMembersAsRecentlyMet,
		[Token(Token = "0x400022B")]
		MessagingSendInGameMessage,
		[Token(Token = "0x400022C")]
		MessagingSendGameDataMessage,
		[Token(Token = "0x400022D")]
		MessagingDisplayReceivedGameDataMessagesDialog,
		[Token(Token = "0x400022E")]
		MessagingGetReceivedGameDataMessages,
		[Token(Token = "0x400022F")]
		MessagingConsumeGameDataMessage,
		[Token(Token = "0x4000230")]
		MessagingGetGameDataMessageThumbnail,
		[Token(Token = "0x4000231")]
		MessagingGetGameDataMessageAttachment,
		[Token(Token = "0x4000232")]
		NetworkUtilsGetBandwidthInfo,
		[Token(Token = "0x4000233")]
		NetworkUtilsGetBasicNetworkInfo,
		[Token(Token = "0x4000234")]
		NetworkUtilsGetDetailedNetworkInfo,
		[Token(Token = "0x4000235")]
		NotificationRefreshRoom,
		[Token(Token = "0x4000236")]
		NotificationNewRoomMessage,
		[Token(Token = "0x4000237")]
		NotificationDialogOpened,
		[Token(Token = "0x4000238")]
		NotificationDialogClosed,
		[Token(Token = "0x4000239")]
		NotificationUserStateChange,
		[Token(Token = "0x400023A")]
		NotificationNetStateChange,
		[Token(Token = "0x400023B")]
		NotificationNewInGameMessage,
		[Token(Token = "0x400023C")]
		NotificationUpdateFriendsList,
		[Token(Token = "0x400023D")]
		NotificationNewInvitation,
		[Token(Token = "0x400023E")]
		NotificationNewGameDataMessage,
		[Token(Token = "0x400023F")]
		NotificationUpdateFriendPresence,
		[Token(Token = "0x4000240")]
		NotificationUpdateBlockedUsersList,
		[Token(Token = "0x4000241")]
		NotificationAborted,
		[Token(Token = "0x4000242")]
		NpUtilsDisplaySigninDialog,
		[Token(Token = "0x4000243")]
		NpUtilsSetTitleIdForDevelopment,
		[Token(Token = "0x4000244")]
		NpUtilsCheckAvailability,
		[Token(Token = "0x4000245")]
		NpUtilsCheckPsPlusAccess,
		[Token(Token = "0x4000246")]
		NpUtilsGetAccountIdByOnlineId,
		[Token(Token = "0x4000247")]
		NpUtilsGetOnlineIdByAccountId,
		[Token(Token = "0x4000248")]
		PresenceSetPresence,
		[Token(Token = "0x4000249")]
		PresenceGetPresence,
		[Token(Token = "0x400024A")]
		PresenceDeletePresence,
		[Token(Token = "0x400024B")]
		RankingSetScore,
		[Token(Token = "0x400024C")]
		RankingGetRangeOfRanks,
		[Token(Token = "0x400024D")]
		RankingGetFriendsRanks,
		[Token(Token = "0x400024E")]
		RankingGetUsersRanks,
		[Token(Token = "0x400024F")]
		RankingSetGameData,
		[Token(Token = "0x4000250")]
		RankingGetGameData,
		[Token(Token = "0x4000251")]
		SessionSendInvitation,
		[Token(Token = "0x4000252")]
		SessionDisplayReceivedInvitationsDialog,
		[Token(Token = "0x4000253")]
		SessionGetReceivedInvitations,
		[Token(Token = "0x4000254")]
		SessionGetInvitationData,
		[Token(Token = "0x4000255")]
		SessionConsumeInvitation,
		[Token(Token = "0x4000256")]
		SessionGetData,
		[Token(Token = "0x4000257")]
		SessionLeave,
		[Token(Token = "0x4000258")]
		SessionUpdate,
		[Token(Token = "0x4000259")]
		SessionGetInfo,
		[Token(Token = "0x400025A")]
		SessionJoin,
		[Token(Token = "0x400025B")]
		SessionSearch,
		[Token(Token = "0x400025C")]
		SessionCreate,
		[Token(Token = "0x400025D")]
		SharedMediaGetScreenshots,
		[Token(Token = "0x400025E")]
		SharedMediaGetBroadcasts,
		[Token(Token = "0x400025F")]
		SharedMediaGetVideos,
		[Token(Token = "0x4000260")]
		TournamentSearchEvents,
		[Token(Token = "0x4000261")]
		TournamentGetEvent,
		[Token(Token = "0x4000262")]
		TournamentGetRegisteredUsers,
		[Token(Token = "0x4000263")]
		TournamentGetRegisteredTeams,
		[Token(Token = "0x4000264")]
		TournamentGetRegisteredRoster,
		[Token(Token = "0x4000265")]
		TournamentGetBracket,
		[Token(Token = "0x4000266")]
		TournamentSendUserMatchReport,
		[Token(Token = "0x4000267")]
		TournamentSendTeamMatchReport,
		[Token(Token = "0x4000268")]
		TrophyRegisterTrophyPack,
		[Token(Token = "0x4000269")]
		TrophyUnlock,
		[Token(Token = "0x400026A")]
		TrophySetScreenshot,
		[Token(Token = "0x400026B")]
		TrophyGetUnlockedTrophies,
		[Token(Token = "0x400026C")]
		TrophyDisplayTrophyListDialog,
		[Token(Token = "0x400026D")]
		TrophyGetTrophyPackSummary,
		[Token(Token = "0x400026E")]
		TrophyGetTrophyPackGroup,
		[Token(Token = "0x400026F")]
		TrophyGetTrophyPackTrophy,
		[Token(Token = "0x4000270")]
		TssGetData,
		[Token(Token = "0x4000271")]
		TusGetVariables,
		[Token(Token = "0x4000272")]
		TusSetVariables,
		[Token(Token = "0x4000273")]
		TusGetFriendsVariable,
		[Token(Token = "0x4000274")]
		TusAddToAndGetVariable,
		[Token(Token = "0x4000275")]
		TusTryAndSetVariable,
		[Token(Token = "0x4000276")]
		TusGetData,
		[Token(Token = "0x4000277")]
		TusSetData,
		[Token(Token = "0x4000278")]
		TusDeleteData,
		[Token(Token = "0x4000279")]
		TusGetUsersVariable,
		[Token(Token = "0x400027A")]
		TusGetUsersDataStatus,
		[Token(Token = "0x400027B")]
		TusGetFriendsDataStatus,
		[Token(Token = "0x400027C")]
		UserProfileGetNpProfiles,
		[Token(Token = "0x400027D")]
		UserProfileGetVerifiedAccountsForTitle,
		[Token(Token = "0x400027E")]
		UserProfileDisplayUserProfileDialog,
		[Token(Token = "0x400027F")]
		UserProfileDisplayGriefReportingDialog,
		[Token(Token = "0x4000280")]
		WordfilterFilterComment,
		[Token(Token = "0x4000281")]
		Internal1,
		[Token(Token = "0x4000282")]
		Internal2,
		[Token(Token = "0x4000283")]
		NumFunctionTypes,
		[Token(Token = "0x4000284")]
		NotificationSessionInvitationEvent,
		[Token(Token = "0x4000285")]
		NotificationPlayTogetherHostEvent,
		[Token(Token = "0x4000286")]
		NotificationGameCustomDataEvent,
		[Token(Token = "0x4000287")]
		NotificationLaunchAppEvent,
		[Token(Token = "0x4000288")]
		NpUtilsCheckPlus,
		[Token(Token = "0x4000289")]
		NpUtilsGetParentalControlInfo
	}
	[Token(Token = "0x2000012")]
	public class Core
	{
		[StructLayout(0)]
		[Token(Token = "0x2000080")]
		public class TerminateServiceRequest : RequestBase
		{
			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal int service;

			[Token(Token = "0x170000D0")]
			public ServiceTypes Service
			{
				[Token(Token = "0x60002BB")]
				[Address(RVA = "0x24E07B4", Offset = "0x24E07B4", VA = "0x24E07B4")]
				get
				{
					return default(ServiceTypes);
				}
				[Token(Token = "0x60002BC")]
				[Address(RVA = "0x24E07BC", Offset = "0x24E07BC", VA = "0x24E07BC")]
				set
				{
				}
			}

			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x24E07E4", Offset = "0x24E07E4", VA = "0x24E07E4")]
			public TerminateServiceRequest()
			{
			}
		}

		[Token(Token = "0x2000081")]
		public enum OptionalBoolean
		{
			[Token(Token = "0x40004B1")]
			notSet,
			[Token(Token = "0x40004B2")]
			setTrue,
			[Token(Token = "0x40004B3")]
			setFalse
		}

		[Token(Token = "0x2000082")]
		public enum PlatformType
		{
			[Token(Token = "0x40004B5")]
			none,
			[Token(Token = "0x40004B6")]
			ps3,
			[Token(Token = "0x40004B7")]
			psVita,
			[Token(Token = "0x40004B8")]
			ps4
		}

		[Token(Token = "0x2000083")]
		public enum OnlineStatus
		{
			[Token(Token = "0x40004BA")]
			notRequested,
			[Token(Token = "0x40004BB")]
			online,
			[Token(Token = "0x40004BC")]
			standBy,
			[Token(Token = "0x40004BD")]
			offline
		}

		[Token(Token = "0x2000084")]
		public enum ReturnCodes : uint
		{
			[Token(Token = "0x40004BF")]
			SUCCESS = 0u,
			[Token(Token = "0x40004C0")]
			DIALOG_RESULT_OK = 0u,
			[Token(Token = "0x40004C1")]
			DIALOG_RESULT_USER_CANCELED = 1u,
			[Token(Token = "0x40004C2")]
			DIALOG_RESULT_USER_PURCHASED = 2u,
			[Token(Token = "0x40004C3")]
			DIALOG_RESULT_ALREADY_SIGNED_IN = 3u,
			[Token(Token = "0x40004C4")]
			DIALOG_RESULT_NOT_SIGNED_IN = 4u,
			[Token(Token = "0x40004C5")]
			DIALOG_RESULT_ABORTED = 10u,
			[Token(Token = "0x40004C6")]
			TROPHY_PLATINUM_UNLOCKED = 1u,
			[Token(Token = "0x40004C7")]
			MATCHING_CREATE_SYSTEM_SESSION_FAILED = 160u,
			[Token(Token = "0x40004C8")]
			MATCHING_JOIN_SYSTEM_SESSION_FAILED = 176u,
			[Token(Token = "0x40004C9")]
			MATCHING_UPDATE_SYSTEM_SESSION_FAILED = 192u,
			[Token(Token = "0x40004CA")]
			MATCHING_UPDATE_EXTERNAL_NOTIFICATION_FAILED = 208u,
			[Token(Token = "0x40004CB")]
			ERROR_FAILED_TO_ALLOCATE = 2153065984u,
			[Token(Token = "0x40004CC")]
			ERROR_TOO_MANY_REQUESTS = 2153065985u,
			[Token(Token = "0x40004CD")]
			ERROR_LOCKED_RESPONSE = 2153065986u,
			[Token(Token = "0x40004CE")]
			ERROR_ALREADY_INITIALIZED = 2153065987u,
			[Token(Token = "0x40004CF")]
			ERROR_NOT_INITIALIZED = 2153065988u,
			[Token(Token = "0x40004D0")]
			ERROR_INCORRECT_ARGUMENTS = 2153065989u,
			[Token(Token = "0x40004D1")]
			ERROR_MODIFICATION_NOT_ALLOWED = 2153065990u,
			[Token(Token = "0x40004D2")]
			ERROR_MAX_USERS_REACHED = 2153065991u,
			[Token(Token = "0x40004D3")]
			ERROR_INVALID_IMAGE = 2153065992u,
			[Token(Token = "0x40004D4")]
			ERROR_MEM_POOLS_INCORRECT = 2153065993u,
			[Token(Token = "0x40004D5")]
			ERROR_EXT_ALLOCATOR_INCORRECT = 2153065994u,
			[Token(Token = "0x40004D6")]
			ERROR_MAX_NUM_CALLBACKS_REACHED = 2153065995u,
			[Token(Token = "0x40004D7")]
			ERROR_CALLBACK_NOT_REGISTERED = 2153065996u,
			[Token(Token = "0x40004D8")]
			ERROR_TROPHY_HOME_DIRECTORY_NOT_CONFIGURED = 2153066096u,
			[Token(Token = "0x40004D9")]
			ERROR_MATCHING_ROOM_DESTROYED = 2153066240u,
			[Token(Token = "0x40004DA")]
			ERROR_MATCHING_INVALID_ATTRIBUTE_SCOPE = 2153066241u,
			[Token(Token = "0x40004DB")]
			ERROR_MATCHING_INVALID_ATTRIBUTE_TYP = 2153066242u,
			[Token(Token = "0x40004DC")]
			ERROR_MATCHING_INVALID_ROOM_ATTRIBUTE_VISIBILITY = 2153066243u,
			[Token(Token = "0x40004DD")]
			ERROR_MATCHING_SUM_OF_MEMBER_ATTRIBUTES_SIZES_IS_MORE_THAN_64 = 2153066244u,
			[Token(Token = "0x40004DE")]
			ERROR_MATCHING_MORE_THAN_1_BINARY_SEARCH_ATTRIBUTE_PROVIDED = 2153066245u,
			[Token(Token = "0x40004DF")]
			ERROR_MATCHING_SEARCH_BINARY_ATTRIBUTE_SIZE_IS_MORE_THAN_64 = 2153066246u,
			[Token(Token = "0x40004E0")]
			ERROR_MATCHING_MORE_THAN_8_INTEGER_SEARCH_ATTRIBUTES_PROVIDED = 2153066247u,
			[Token(Token = "0x40004E1")]
			ERROR_MATCHING_SUM_OF_EXTERNAL_ROOM_ATTRIBUTES_SIZES_IS_MORE_THAN_512 = 2153066248u,
			[Token(Token = "0x40004E2")]
			ERROR_MATCHING_SUM_OF_INTERNAL_ROOM_ATTRIBUTES_SIZES_IS_MORE_THAN_512 = 2153066249u,
			[Token(Token = "0x40004E3")]
			ERROR_MATCHING_NAMES_OF_ATTRIBUTES_MUST_BE_UNIQUE = 2153066250u,
			[Token(Token = "0x40004E4")]
			ERROR_MATCHING_INTERNAL_ATTRIBUTES_DONT_FIT_IN_256_ARRAYS = 2153066251u,
			[Token(Token = "0x40004E5")]
			ERROR_MATCHING_EXTERNAL_ATTRIBUTES_DONT_FIT_IN_256_ARRAYS = 2153066252u,
			[Token(Token = "0x40004E6")]
			ERROR_MATCHING_BIN_ATTRIBUTE_CANNOT_BE_SIZE_0 = 2153066253u,
			[Token(Token = "0x40004E7")]
			ERROR_MATCHING_INIT_CONFIGURATION_ALREADY_SET = 2153066254u,
			[Token(Token = "0x40004E8")]
			ERROR_MATCHING_INIT_CONFIGURATION_NOT_SET = 2153066255u,
			[Token(Token = "0x40004E9")]
			ERROR_MATCHING_USER_IS_ALREADY_IN_A_ROOM = 2153066256u,
			[Token(Token = "0x40004EA")]
			ERROR_MATCHING_USER_IS_NOT_IN_A_ROOM = 2153066257u,
			[Token(Token = "0x40004EB")]
			ERROR_MATCHING_NO_SESSION_BOUND_TO_ROOM = 2153066258u,
			[Token(Token = "0x40004EC")]
			ERROR_MATCHING_INVALID_WORLD_NUMBER = 2153066259u,
			[Token(Token = "0x40004ED")]
			ERROR_MATCHING_ATTRIBUTE_IS_NOT_SEARCHABLE_TYPE = 2153066260u,
			[Token(Token = "0x40004EE")]
			ERROR_MATCHING_INVALID_ATTRIBUTE = 2153066261u,
			[Token(Token = "0x40004EF")]
			ERROR_MATCHING_INVALID_MEMBER_ID = 2153066262u,
			[Token(Token = "0x40004F0")]
			NP_ERROR_INVALID_ARGUMENT = 2153054211u,
			[Token(Token = "0x40004F1")]
			NP_ERROR_UNKNOWN_PLATFORM_TYPE = 2153054212u,
			[Token(Token = "0x40004F2")]
			NP_ERROR_OUT_OF_MEMORY = 2153054213u,
			[Token(Token = "0x40004F3")]
			NP_ERROR_SIGNED_OUT = 2153054214u,
			[Token(Token = "0x40004F4")]
			NP_ERROR_USER_NOT_FOUND = 2153054215u,
			[Token(Token = "0x40004F5")]
			NP_ERROR_CALLBACK_ALREADY_REGISTERED = 2153054216u,
			[Token(Token = "0x40004F6")]
			NP_ERROR_CALLBACK_NOT_REGISTERED = 2153054217u,
			[Token(Token = "0x40004F7")]
			NP_ERROR_NOT_SIGNED_UP = 2153054218u,
			[Token(Token = "0x40004F8")]
			NP_ERROR_AGE_RESTRICTION = 2153054219u,
			[Token(Token = "0x40004F9")]
			NP_ERROR_LOGOUT = 2153054220u,
			[Token(Token = "0x40004FA")]
			NP_ERROR_LATEST_SYSTEM_SOFTWARE_EXIST = 2153054221u,
			[Token(Token = "0x40004FB")]
			NP_ERROR_LATEST_SYSTEM_SOFTWARE_EXIST_FOR_TITLE = 2153054222u,
			[Token(Token = "0x40004FC")]
			NP_ERROR_LATEST_PATCH_PKG_EXIST = 2153054223u,
			[Token(Token = "0x40004FD")]
			NP_ERROR_LATEST_PATCH_PKG_DOWNLOADED = 2153054224u,
			[Token(Token = "0x40004FE")]
			NP_ERROR_INVALID_SIZE = 2153054225u,
			[Token(Token = "0x40004FF")]
			NP_ERROR_ABORTED = 2153054226u,
			[Token(Token = "0x4000500")]
			NP_ERROR_REQUEST_MAX = 2153054227u,
			[Token(Token = "0x4000501")]
			NP_ERROR_REQUEST_NOT_FOUND = 2153054228u,
			[Token(Token = "0x4000502")]
			NP_ERROR_INVALID_ID = 2153054229u,
			[Token(Token = "0x4000503")]
			NP_ERROR_PATCH_NOT_CHECKED = 2153054232u,
			[Token(Token = "0x4000504")]
			NP_ERROR_TIMEOUT = 2153054234u,
			[Token(Token = "0x4000505")]
			NP_UTIL_ERROR_INVALID_NP_ID = 2153055749u,
			[Token(Token = "0x4000506")]
			NP_UTIL_ERROR_NOT_MATCH = 2153055753u,
			[Token(Token = "0x4000507")]
			NP_WEBAPI_ERROR_LIB_CONTEXT_NOT_FOUND = 2153064708u,
			[Token(Token = "0x4000508")]
			NP_TROPHY_ERROR_INVALID_ARGUMENT = 2153059844u,
			[Token(Token = "0x4000509")]
			NP_TROPHY_ERROR_ALREADY_REGISTERED = 2153059856u,
			[Token(Token = "0x400050A")]
			NP_TROPHY_ERROR_INVALID_GROUP_ID = 2153059851u,
			[Token(Token = "0x400050B")]
			NP_TROPHY_ERROR_TROPHY_ALREADY_UNLOCKED = 2153059852u,
			[Token(Token = "0x400050C")]
			NP_TROPHY_ERROR_NOT_REGISTERED = 2153059855u,
			[Token(Token = "0x400050D")]
			NP_TROPHY_ERROR_TROPHY_NOT_UNLOCKED = 2153059866u,
			[Token(Token = "0x400050E")]
			TOOLKIT_NP_V2_ERROR_INCORRECT_ARGUMENTS = 2153065989u,
			[Token(Token = "0x400050F")]
			NET_ERROR_RESOLVER_ENODNS = 2151743969u,
			[Token(Token = "0x4000510")]
			NET_CTL_ERROR_NOT_CONNECTED = 2151751944u,
			[Token(Token = "0x4000511")]
			NET_CTL_ERROR_NOT_AVAIL = 2151751945u,
			[Token(Token = "0x4000512")]
			NP_COMMUNITY_SERVER_ERROR_NOT_BEST_SCORE = 2153056277u,
			[Token(Token = "0x4000513")]
			NP_COMMUNITY_SERVER_ERROR_INVALID_SCORE = 2153056291u,
			[Token(Token = "0x4000514")]
			NP_COMMUNITY_SERVER_ERROR_GAME_DATA_ALREADY_EXISTS = 2153056300u,
			[Token(Token = "0x4000515")]
			NP_COMMUNITY_SERVER_ERROR_RANKING_GAME_DATA_MASTER_NOT_FOUND = 2153056280u,
			[Token(Token = "0x4000516")]
			NP_MATCHING2_ERROR_CONTEXT_NOT_STARTED = 2153057288u,
			[Token(Token = "0x4000517")]
			NP_COMMUNITY_SERVER_ERROR_FORBIDDEN = 2153056262u
		}

		[Token(Token = "0x2000085")]
		public struct UserServiceUserId
		{
			[Token(Token = "0x4000518")]
			public const int UserIdInvalid = -1;

			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int id;

			[Token(Token = "0x170000D1")]
			public int Id
			{
				[Token(Token = "0x60002BE")]
				[Address(RVA = "0x24E0884", Offset = "0x24E0884", VA = "0x24E0884")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60002BF")]
				[Address(RVA = "0x24E088C", Offset = "0x24E088C", VA = "0x24E088C")]
				set
				{
				}
			}

			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x24E0894", Offset = "0x24E0894", VA = "0x24E0894", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x24E0904", Offset = "0x24E0904", VA = "0x24E0904")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x24E0938", Offset = "0x24E0938", VA = "0x24E0938")]
			public static implicit operator UserServiceUserId(int value)
			{
				return default(UserServiceUserId);
			}
		}

		[Token(Token = "0x2000086")]
		public struct NpAccountId
		{
			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ulong id;

			[Token(Token = "0x170000D2")]
			public ulong Id
			{
				[Token(Token = "0x60002C3")]
				[Address(RVA = "0x24E0184", Offset = "0x24E0184", VA = "0x24E0184")]
				get
				{
					return default(ulong);
				}
				[Token(Token = "0x60002C4")]
				[Address(RVA = "0x24E018C", Offset = "0x24E018C", VA = "0x24E018C")]
				set
				{
				}
			}

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x24E0194", Offset = "0x24E0194", VA = "0x24E0194", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x24E0204", Offset = "0x24E0204", VA = "0x24E0204")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x24E0238", Offset = "0x24E0238", VA = "0x24E0238")]
			public static implicit operator NpAccountId(ulong value)
			{
				return default(NpAccountId);
			}

			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x24E023C", Offset = "0x24E023C", VA = "0x24E023C")]
			public static bool operator ==(NpAccountId a, NpAccountId b)
			{
				return default(bool);
			}

			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x24E02D0", Offset = "0x24E02D0", VA = "0x24E02D0")]
			public static bool operator !=(NpAccountId a, NpAccountId b)
			{
				return default(bool);
			}

			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x24E02EC", Offset = "0x24E02EC", VA = "0x24E02EC", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x24E037C", Offset = "0x24E037C", VA = "0x24E037C", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000087")]
		public struct NpId
		{
			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal OnlineID handle;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal byte[] opt;

			[Token(Token = "0x170000D3")]
			public OnlineID Handle
			{
				[Token(Token = "0x60002CC")]
				[Address(RVA = "0x24E0384", Offset = "0x24E0384", VA = "0x24E0384")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D4")]
			public byte[] Opt
			{
				[Token(Token = "0x60002CD")]
				[Address(RVA = "0x24E038C", Offset = "0x24E038C", VA = "0x24E038C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x24E0394", Offset = "0x24E0394", VA = "0x24E0394", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x24E03B4", Offset = "0x24E03B4", VA = "0x24E03B4")]
			internal void Read(MemoryBuffer buffer)
			{
			}
		}

		[Token(Token = "0x2000088")]
		public class OnlineID
		{
			[Token(Token = "0x400051D")]
			public const int SCE_NP_ONLINEID_MAX_LENGTH = 16;

			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal byte[] data;

			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal string name;

			[Token(Token = "0x170000D5")]
			public string Name
			{
				[Token(Token = "0x60002D0")]
				[Address(RVA = "0x24E052C", Offset = "0x24E052C", VA = "0x24E052C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x24E0534", Offset = "0x24E0534", VA = "0x24E0534")]
			public OnlineID()
			{
			}

			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x24E0418", Offset = "0x24E0418", VA = "0x24E0418")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x24E05A8", Offset = "0x24E05A8", VA = "0x24E05A8", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x24E05B0", Offset = "0x24E05B0", VA = "0x24E05B0")]
			public static bool operator ==(OnlineID a, OnlineID b)
			{
				return default(bool);
			}

			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x24E05E4", Offset = "0x24E05E4", VA = "0x24E05E4")]
			public static bool operator !=(OnlineID a, OnlineID b)
			{
				return default(bool);
			}

			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x24E0628", Offset = "0x24E0628", VA = "0x24E0628", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x24E06E0", Offset = "0x24E06E0", VA = "0x24E06E0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000089")]
		public class OnlineUser
		{
			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal NpAccountId accountId;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal OnlineID onlineId;

			[Token(Token = "0x170000D6")]
			public NpAccountId AccountId
			{
				[Token(Token = "0x60002D8")]
				[Address(RVA = "0x24E0700", Offset = "0x24E0700", VA = "0x24E0700")]
				get
				{
					return default(NpAccountId);
				}
			}

			[Token(Token = "0x170000D7")]
			public OnlineID OnlineID
			{
				[Token(Token = "0x60002D9")]
				[Address(RVA = "0x24E0708", Offset = "0x24E0708", VA = "0x24E0708")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x24D97AC", Offset = "0x24D97AC", VA = "0x24D97AC")]
			public OnlineUser()
			{
			}

			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x24D9744", Offset = "0x24D9744", VA = "0x24D9744")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x24E0710", Offset = "0x24E0710", VA = "0x24E0710", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x200008A")]
		public class CountryCode
		{
			[Token(Token = "0x4000522")]
			public const int SCE_NP_COUNTRY_CODE_LENGTH = 2;

			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal string code;

			[Token(Token = "0x170000D8")]
			public string Code
			{
				[Token(Token = "0x60002DF")]
				[Address(RVA = "0x24DFE3C", Offset = "0x24DFE3C", VA = "0x24DFE3C")]
				get
				{
					return null;
				}
				[Token(Token = "0x60002E0")]
				[Address(RVA = "0x24DFD9C", Offset = "0x24DFD9C", VA = "0x24DFD9C")]
				set
				{
				}
			}

			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x24D9AB0", Offset = "0x24D9AB0", VA = "0x24D9AB0")]
			public CountryCode()
			{
			}

			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x24DFD2C", Offset = "0x24DFD2C", VA = "0x24DFD2C")]
			public CountryCode(string countryCode)
			{
			}

			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x24DFE44", Offset = "0x24DFE44", VA = "0x24DFE44")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x24DFE98", Offset = "0x24DFE98", VA = "0x24DFE98", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x24DFEA0", Offset = "0x24DFEA0", VA = "0x24DFEA0")]
			public static implicit operator CountryCode(string countryCode)
			{
				return null;
			}
		}

		[Token(Token = "0x200008B")]
		public class LanguageCode
		{
			[Token(Token = "0x4000524")]
			public const int SCE_NP_LANGUAGE_CODE_MAX_LEN = 5;

			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal string code;

			[Token(Token = "0x170000D9")]
			public string Code
			{
				[Token(Token = "0x60002E5")]
				[Address(RVA = "0x24E0010", Offset = "0x24E0010", VA = "0x24E0010")]
				get
				{
					return null;
				}
				[Token(Token = "0x60002E6")]
				[Address(RVA = "0x24E0018", Offset = "0x24E0018", VA = "0x24E0018")]
				set
				{
				}
			}

			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x24D7958", Offset = "0x24D7958", VA = "0x24D7958")]
			public LanguageCode()
			{
			}

			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x24E00B8", Offset = "0x24E00B8", VA = "0x24E00B8")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x24E010C", Offset = "0x24E010C", VA = "0x24E010C", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x24E0114", Offset = "0x24E0114", VA = "0x24E0114")]
			public static implicit operator LanguageCode(string languageCode)
			{
				return null;
			}
		}

		[Token(Token = "0x200008C")]
		public class TitleId
		{
			[Token(Token = "0x4000526")]
			public const int SCE_NP_TITLE_ID_LEN = 12;

			[Token(Token = "0x4000527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal byte[] data;

			[Token(Token = "0x170000DA")]
			public string Id
			{
				[Token(Token = "0x60002EA")]
				[Address(RVA = "0x24E07F4", Offset = "0x24E07F4", VA = "0x24E07F4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x24D8930", Offset = "0x24D8930", VA = "0x24D8930")]
			public TitleId()
			{
			}

			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x24D88DC", Offset = "0x24D88DC", VA = "0x24D88DC")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x24E083C", Offset = "0x24E083C", VA = "0x24E083C", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x200008D")]
		public class EmptyResponse : ResponseBase
		{
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x24DFF10", Offset = "0x24DFF10", VA = "0x24DFF10", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x24E0008", Offset = "0x24E0008", VA = "0x24E0008")]
			public EmptyResponse()
			{
			}
		}

		[PreserveSig]
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x24DF93C", Offset = "0x24DF93C", VA = "0x24DF93C")]
		private static extern int PrxTerminateService(TerminateServiceRequest request, out APIResult result);

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x24DF9FC", Offset = "0x24DF9FC", VA = "0x24DF9FC")]
		public static int TerminateService(TerminateServiceRequest request, EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x24DFB08", Offset = "0x24DFB08", VA = "0x24DFB08")]
		public static string ConvertSceErrorToString(int errorCode)
		{
			return null;
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x24DD0F8", Offset = "0x24DD0F8", VA = "0x24DD0F8")]
		internal static DateTime ReadRtcTick(MemoryBuffer buffer)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x24DFCEC", Offset = "0x24DFCEC", VA = "0x24DFCEC")]
		internal static ulong DateTimeToRtcTicks(DateTime dateTime)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x24DFCB8", Offset = "0x24DFCB8", VA = "0x24DFCB8")]
		internal static DateTime RtcTicksToDateTime(ulong rtcTick)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x24DFD24", Offset = "0x24DFD24", VA = "0x24DFD24")]
		public Core()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class Icon
	{
		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal byte[] rawBytes;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int width;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal int height;

		[Token(Token = "0x17000007")]
		public byte[] RawBytes
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x24E22C4", Offset = "0x24E22C4", VA = "0x24E22C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		public int Width
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x24E22CC", Offset = "0x24E22CC", VA = "0x24E22CC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000009")]
		public int Height
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x24E22D4", Offset = "0x24E22D4", VA = "0x24E22D4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x24E22DC", Offset = "0x24E22DC", VA = "0x24E22DC")]
		internal static Icon ReadAndCreate(MemoryBuffer buffer)
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x24E23C4", Offset = "0x24E23C4", VA = "0x24E23C4")]
		public Icon()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public enum APIResultTypes
	{
		[Token(Token = "0x400028E")]
		Success,
		[Token(Token = "0x400028F")]
		Warning,
		[Token(Token = "0x4000290")]
		Error
	}
	[Token(Token = "0x2000015")]
	internal struct APIResult
	{
		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public APIResultTypes apiResult;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private IntPtr _message;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr _filename;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int lineNumber;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int sceErrorCode;

		[Token(Token = "0x1700000A")]
		public string message
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x24D6518", Offset = "0x24D6518", VA = "0x24D6518")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000B")]
		public string filename
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x24D6584", Offset = "0x24D6584", VA = "0x24D6584")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		public bool RaiseException
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x24D65F0", Offset = "0x24D65F0", VA = "0x24D65F0")]
			get
			{
				return default(bool);
			}
		}
	}
	[Token(Token = "0x2000016")]
	public class NpToolkitException : Exception
	{
		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal APIResultTypes resultType;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal string filename;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal int lineNumber;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		internal int sceErrorCode;

		[Token(Token = "0x1700000D")]
		public APIResultTypes ResultType
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x24E7810", Offset = "0x24E7810", VA = "0x24E7810")]
			get
			{
				return default(APIResultTypes);
			}
		}

		[Token(Token = "0x1700000E")]
		public string Filename
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x24E7818", Offset = "0x24E7818", VA = "0x24E7818")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		public int LineNumber
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x24E7820", Offset = "0x24E7820", VA = "0x24E7820")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000010")]
		public int SceErrorCode
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x24E7828", Offset = "0x24E7828", VA = "0x24E7828")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000011")]
		public string ExtendedMessage
		{
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x24E7928", Offset = "0x24E7928", VA = "0x24E7928")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x24E7830", Offset = "0x24E7830", VA = "0x24E7830")]
		public NpToolkitException()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x24E574C", Offset = "0x24E574C", VA = "0x24E574C")]
		public NpToolkitException(string message)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x24E78A0", Offset = "0x24E78A0", VA = "0x24E78A0")]
		public NpToolkitException(string message, Exception inner)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x24E5BF8", Offset = "0x24E5BF8", VA = "0x24E5BF8")]
		internal NpToolkitException(APIResult apiResult)
		{
		}
	}
	[Token(Token = "0x2000017")]
	public struct AgeRestriction
	{
		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal string countryCode;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int age;

		[Token(Token = "0x17000012")]
		public Core.CountryCode CountryCode
		{
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x24D9A44", Offset = "0x24D9A44", VA = "0x24D9A44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x24D9B14", Offset = "0x24D9B14", VA = "0x24D9B14")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public int Age
		{
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x24D9B30", Offset = "0x24D9B30", VA = "0x24D9B30")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x24D9B38", Offset = "0x24D9B38", VA = "0x24D9B38")]
			set
			{
			}
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x24D9B40", Offset = "0x24D9B40", VA = "0x24D9B40")]
		public AgeRestriction(int age, Core.CountryCode countryCode)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x24D9B60", Offset = "0x24D9B60", VA = "0x24D9B60")]
		public void Init()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public struct ContentRestriction
	{
		[Token(Token = "0x400029C")]
		public const int MAX_AGE_RESTRICTIONS = 100;

		[Token(Token = "0x400029D")]
		public const int NP_NO_AGE_RESTRICTION = 0;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal int defaultAgeRestriction;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal AgeRestriction[] ageRestrictions;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int numAgeRestictions;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal bool applyContentRestriction;

		[Token(Token = "0x17000014")]
		public int DefaultAgeRestriction
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x24DF6A4", Offset = "0x24DF6A4", VA = "0x24DF6A4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x24DF6AC", Offset = "0x24DF6AC", VA = "0x24DF6AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public AgeRestriction[] AgeRestrictions
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x24DF6B4", Offset = "0x24DF6B4", VA = "0x24DF6B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x24DF734", Offset = "0x24DF734", VA = "0x24DF734")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public bool ApplyContentRestriction
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x24DF828", Offset = "0x24DF828", VA = "0x24DF828")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x24DF830", Offset = "0x24DF830", VA = "0x24DF830")]
			set
			{
			}
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x24DF83C", Offset = "0x24DF83C", VA = "0x24DF83C")]
		public void Init()
		{
		}
	}
	[Token(Token = "0x2000019")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE1908", Offset = "0xCE1908")]
	public struct ServerPushNotifications
	{
		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal bool newGameDataMessage;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		internal bool newInvitation;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		internal bool updateBlockedUsersList;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		internal bool updateFriendPresence;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		internal bool updateFriendsList;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		internal bool newInGameMessage;

		[Token(Token = "0x17000017")]
		public bool NewGameDataMessage
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x24F0518", Offset = "0x24F0518", VA = "0x24F0518")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x24F0520", Offset = "0x24F0520", VA = "0x24F0520")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public bool NewInvitation
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x24F052C", Offset = "0x24F052C", VA = "0x24F052C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x24F0534", Offset = "0x24F0534", VA = "0x24F0534")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public bool UpdateBlockedUsersList
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x24F0540", Offset = "0x24F0540", VA = "0x24F0540")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x24F0548", Offset = "0x24F0548", VA = "0x24F0548")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public bool UpdateFriendPresence
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x24F0554", Offset = "0x24F0554", VA = "0x24F0554")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x24F055C", Offset = "0x24F055C", VA = "0x24F055C")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public bool UpdateFriendsList
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x24F0568", Offset = "0x24F0568", VA = "0x24F0568")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x24F0570", Offset = "0x24F0570", VA = "0x24F0570")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public bool NewInGameMessage
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x24F057C", Offset = "0x24F057C", VA = "0x24F057C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x24F0584", Offset = "0x24F0584", VA = "0x24F0584")]
			set
			{
			}
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x24F0590", Offset = "0x24F0590", VA = "0x24F0590")]
		public void Init()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public enum PushNotificationsFlags
	{
		[Token(Token = "0x40002A9")]
		None = 0,
		[Token(Token = "0x40002AA")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE1ABC", Offset = "0xCE1ABC")]
		NewGameDataMessage = 1,
		[Token(Token = "0x40002AB")]
		NewInvitation = 2,
		[Token(Token = "0x40002AC")]
		UpdateBlockedUsersList = 4,
		[Token(Token = "0x40002AD")]
		UpdateFriendPresence = 8,
		[Token(Token = "0x40002AE")]
		UpdateFriendsList = 0x10,
		[Token(Token = "0x40002AF")]
		NewInGameMessage = 0x20
	}
	[Token(Token = "0x200001B")]
	public enum Affinity
	{
		[Token(Token = "0x40002B1")]
		Core2 = 4,
		[Token(Token = "0x40002B2")]
		Core3 = 8,
		[Token(Token = "0x40002B3")]
		Core4 = 16,
		[Token(Token = "0x40002B4")]
		Core5 = 32,
		[Token(Token = "0x40002B5")]
		AllCores = 60
	}
	[Token(Token = "0x200001C")]
	public struct ThreadSettings
	{
		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Affinity affinity;

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x24F05A4", Offset = "0x24F05A4", VA = "0x24F05A4")]
		public void Init()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public struct MemoryPools
	{
		[Token(Token = "0x40002B7")]
		public const int TOOLKIT_MEM_DEFAULT_SIZE = 16777216;

		[Token(Token = "0x40002B8")]
		public const int JSON_MEM_MINIMUM_SIZE = 16384;

		[Token(Token = "0x40002B9")]
		public const int JSON_MEM_DEFAULT_SIZE = 4194304;

		[Token(Token = "0x40002BA")]
		public const int WEB_API_MEM_DEFAULT_SIZE = 1048576;

		[Token(Token = "0x40002BB")]
		public const int HTTP_MEM_DEFAULT_SIZE = 65536;

		[Token(Token = "0x40002BC")]
		public const int HTTP_MEM_MINIMUM_SIZE = 16384;

		[Token(Token = "0x40002BD")]
		public const int SSL_MEM_DEFAULT_SIZE = 262144;

		[Token(Token = "0x40002BE")]
		public const int SSL_MEM_MINIMUM_SIZE = 32768;

		[Token(Token = "0x40002BF")]
		public const int NET_MEM_DEFAULT_SIZE = 32768;

		[Token(Token = "0x40002C0")]
		public const int NET_MEM_MINIMUM_SIZE = 4096;

		[Token(Token = "0x40002C1")]
		public const int MATCHING_MEM_DEFAULT_SIZE = 524288;

		[Token(Token = "0x40002C2")]
		public const int MATCHING_SSL_MEM_DEFAULT_SIZE = 196608;

		[Token(Token = "0x40002C3")]
		public const int IN_GAME_MESSAGE_MEM_DEFAULT_SIZE = 16384;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ulong toolkitPoolSize;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private ulong jsonPoolSize;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ulong webApiPoolSize;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ulong httpPoolSize;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ulong sslPoolSize;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ulong netPoolSize;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ulong matchingPoolSize;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ulong matchingSslPoolSize;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ulong inGameMessagePoolSize;

		[Token(Token = "0x1700001D")]
		public ulong ToolkitPoolSize
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x2519F14", Offset = "0x2519F14", VA = "0x2519F14")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x2519F1C", Offset = "0x2519F1C", VA = "0x2519F1C")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public ulong JsonPoolSize
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x251A15C", Offset = "0x251A15C", VA = "0x251A15C")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x251A164", Offset = "0x251A164", VA = "0x251A164")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public ulong WebApiPoolSize
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x251A1DC", Offset = "0x251A1DC", VA = "0x251A1DC")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x251A1E4", Offset = "0x251A1E4", VA = "0x251A1E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public ulong HttpPoolSize
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x251A25C", Offset = "0x251A25C", VA = "0x251A25C")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x251A264", Offset = "0x251A264", VA = "0x251A264")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public ulong SslPoolSize
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x251A2DC", Offset = "0x251A2DC", VA = "0x251A2DC")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x251A2E4", Offset = "0x251A2E4", VA = "0x251A2E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public ulong NetPoolSize
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x251A35C", Offset = "0x251A35C", VA = "0x251A35C")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x251A364", Offset = "0x251A364", VA = "0x251A364")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public ulong MatchingPoolSize
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x251A3DC", Offset = "0x251A3DC", VA = "0x251A3DC")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x251A3E4", Offset = "0x251A3E4", VA = "0x251A3E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public ulong MatchingSslPoolSize
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x251A45C", Offset = "0x251A45C", VA = "0x251A45C")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x251A464", Offset = "0x251A464", VA = "0x251A464")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public ulong InGameMessagePoolSize
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x251A4DC", Offset = "0x251A4DC", VA = "0x251A4DC")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x251A4E4", Offset = "0x251A4E4", VA = "0x251A4E4")]
			set
			{
			}
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2519F94", Offset = "0x2519F94", VA = "0x2519F94")]
		private void Validate(string propertyName, ulong size, ulong minSize, string minSizeName, bool mustBe16kbAlligned)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x251A55C", Offset = "0x251A55C", VA = "0x251A55C")]
		public void Init()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public struct NpToolkitMemoryPoolStats
	{
		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong poolSize;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong maxInUseSize;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ulong currentInUseSize;
	}
	[Token(Token = "0x200001F")]
	public struct JsonMemoryPoolStats
	{
		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong poolSize;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong maxInUseSize;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ulong currentInUseSize;
	}
	[Token(Token = "0x2000020")]
	public struct MemoryPoolStats
	{
		[Token(Token = "0x200008E")]
		public struct HttpStats
		{
			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ulong poolSize;

			[Token(Token = "0x4000529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ulong maxInUseSize;

			[Token(Token = "0x400052A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong currentInUseSize;

			[Token(Token = "0x400052B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int reserved;
		}

		[Token(Token = "0x200008F")]
		public struct InGameMessageMemoryPoolStatistics
		{
			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ulong poolSize;

			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ulong maxInUseSize;

			[Token(Token = "0x400052E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong currentInUseSize;

			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int reserved;
		}

		[Token(Token = "0x2000090")]
		public struct Matching2MemoryInfo
		{
			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ulong totalMemSize;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ulong curMemUsage;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong maxMemUsage;

			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public byte[] reserved;
		}

		[Token(Token = "0x2000091")]
		public struct NetMemoryPoolStats
		{
			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ulong poolSize;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ulong maxInUseSize;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong currentInUseSize;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int reserved;
		}

		[Token(Token = "0x2000092")]
		public struct SslMemoryPoolStats
		{
			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ulong poolSize;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ulong maxInUseSize;

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong currentInUseSize;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int reserved;
		}

		[Token(Token = "0x2000093")]
		public struct WebApiMemoryPoolStats
		{
			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ulong poolSize;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ulong maxInUseSize;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong currentInUseSize;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int reserved;
		}

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HttpStats httpPoolStats;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SslMemoryPoolStats sslPoolStats;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public WebApiMemoryPoolStats webApiPoolStats;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public NetMemoryPoolStats netPoolStats;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public NpToolkitMemoryPoolStats npToolkitPoolStats;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public JsonMemoryPoolStats jsonPoolStats;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Matching2MemoryInfo matchingPoolStats;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Matching2MemoryInfo matchingSslPoolStats;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public InGameMessageMemoryPoolStatistics inGameMsgPoolStats;
	}
	[Token(Token = "0x2000021")]
	public enum SDKVersions
	{
		[Token(Token = "0x40002DD")]
		SDK_4 = 0x4000000
	}
	[Token(Token = "0x2000022")]
	public struct SceSDKVersion
	{
		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint Major;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint Minor;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint Patch;

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x24F0248", Offset = "0x24F0248", VA = "0x24F0248", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000023")]
	internal struct NativeInitResult
	{
		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal bool initialized;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		internal uint sceSDKVersion;
	}
	[Token(Token = "0x2000024")]
	public struct InitResult
	{
		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal bool initialized;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		internal uint sceSDKVersion;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Version dllVersion;

		[Token(Token = "0x17000026")]
		public bool Initialized
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x24E23CC", Offset = "0x24E23CC", VA = "0x24E23CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000027")]
		public uint SceSDKVersionValue
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x24E23D4", Offset = "0x24E23D4", VA = "0x24E23D4")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000028")]
		public Version DllVersion
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x24E23DC", Offset = "0x24E23DC", VA = "0x24E23DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		public SceSDKVersion SceSDKVersion
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x24D6E44", Offset = "0x24D6E44", VA = "0x24D6E44")]
			get
			{
				return default(SceSDKVersion);
			}
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x24E23E4", Offset = "0x24E23E4", VA = "0x24E23E4")]
		internal void Initialise(NativeInitResult nativeResult)
		{
		}
	}
	[StructLayout(0)]
	[Token(Token = "0x2000025")]
	public class InitToolkit
	{
		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ContentRestriction contentRestrictions;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE1AF4", Offset = "0xCE1AF4")]
		public ServerPushNotifications serverPushNotifications;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PushNotificationsFlags serverPushNotificationsFlags;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool notificationsFlagsSet;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ThreadSettings threadSettings;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MemoryPools memoryPools;

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x24E2478", Offset = "0x24E2478", VA = "0x24E2478")]
		public InitToolkit()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x24E24D0", Offset = "0x24E24D0", VA = "0x24E24D0")]
		public void SetPushNotificationsFlags(PushNotificationsFlags pushNotifications)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x24E24E0", Offset = "0x24E24E0", VA = "0x24E24E0")]
		public void CheckValid()
		{
		}
	}
	[Token(Token = "0x2000026")]
	internal struct NpMemoryBuffer
	{
		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint size;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr data;
	}
	[Token(Token = "0x2000027")]
	internal class MemoryBuffer
	{
		[Token(Token = "0x2000094")]
		public enum BufferIntegrityChecks
		{
			[Token(Token = "0x4000541")]
			BufferBegin,
			[Token(Token = "0x4000542")]
			BufferEnd,
			[Token(Token = "0x4000543")]
			OnlineUserBegin,
			[Token(Token = "0x4000544")]
			OnlineUserEnd,
			[Token(Token = "0x4000545")]
			NpOnlineIdBegin,
			[Token(Token = "0x4000546")]
			NpOnlineIdEnd,
			[Token(Token = "0x4000547")]
			SceNpIdBegin,
			[Token(Token = "0x4000548")]
			SceNpIdEnd,
			[Token(Token = "0x4000549")]
			NpCountryCodeBegin,
			[Token(Token = "0x400054A")]
			NpCountryCodeEnd,
			[Token(Token = "0x400054B")]
			NpTitleIdBegin,
			[Token(Token = "0x400054C")]
			NpTitleIdEnd,
			[Token(Token = "0x400054D")]
			NpLanguageCodeBegin,
			[Token(Token = "0x400054E")]
			NpLanguageCodeEnd,
			[Token(Token = "0x400054F")]
			PNGBegin,
			[Token(Token = "0x4000550")]
			PNGEnd,
			[Token(Token = "0x4000551")]
			FriendsBegin,
			[Token(Token = "0x4000552")]
			FriendsEnd,
			[Token(Token = "0x4000553")]
			FriendBegin,
			[Token(Token = "0x4000554")]
			FriendEnd,
			[Token(Token = "0x4000555")]
			FriendsOfFriendsBegin,
			[Token(Token = "0x4000556")]
			FriendsOfFriendsEnd,
			[Token(Token = "0x4000557")]
			BlockedUsersBegin,
			[Token(Token = "0x4000558")]
			BlockedUsersEnd,
			[Token(Token = "0x4000559")]
			ProfileBegin,
			[Token(Token = "0x400055A")]
			ProfileEnd,
			[Token(Token = "0x400055B")]
			RealNameBegin,
			[Token(Token = "0x400055C")]
			RealNameEnd,
			[Token(Token = "0x400055D")]
			PresenceBegin,
			[Token(Token = "0x400055E")]
			PresenceEnd,
			[Token(Token = "0x400055F")]
			PlatformPresenceBegin,
			[Token(Token = "0x4000560")]
			PlatformPresenceEnd,
			[Token(Token = "0x4000561")]
			NpProfilesBegin,
			[Token(Token = "0x4000562")]
			NpProfilesEnd,
			[Token(Token = "0x4000563")]
			BandwidthInfoBegin,
			[Token(Token = "0x4000564")]
			BandwidthInfoEnd,
			[Token(Token = "0x4000565")]
			NetStateBasicBegin,
			[Token(Token = "0x4000566")]
			NetStateBasicEnd,
			[Token(Token = "0x4000567")]
			NetStateDetailedBegin,
			[Token(Token = "0x4000568")]
			NetStateDetailedEnd,
			[Token(Token = "0x4000569")]
			UnlockedTrophiesBegin,
			[Token(Token = "0x400056A")]
			UnlockedTrophiesEnd,
			[Token(Token = "0x400056B")]
			TrophyPackSummaryBegin,
			[Token(Token = "0x400056C")]
			TrophyPackSummaryEnd,
			[Token(Token = "0x400056D")]
			TrophyPackGroupBegin,
			[Token(Token = "0x400056E")]
			TrophyPackGroupEnd,
			[Token(Token = "0x400056F")]
			TrophyPackTrophyBegin,
			[Token(Token = "0x4000570")]
			TrophyPackTrophyEnd,
			[Token(Token = "0x4000571")]
			TempRankBegin,
			[Token(Token = "0x4000572")]
			TempRankEnd,
			[Token(Token = "0x4000573")]
			RangeOfRanksBegin,
			[Token(Token = "0x4000574")]
			RangeOfRanksEnd,
			[Token(Token = "0x4000575")]
			FriendsRanksBegin,
			[Token(Token = "0x4000576")]
			FriendsRanksEnd,
			[Token(Token = "0x4000577")]
			UsersRanksBegin,
			[Token(Token = "0x4000578")]
			UsersRanksEnd,
			[Token(Token = "0x4000579")]
			SetGameDataBegin,
			[Token(Token = "0x400057A")]
			SetGameDataEnd,
			[Token(Token = "0x400057B")]
			GetGameDataBegin,
			[Token(Token = "0x400057C")]
			GetGameDataEnd,
			[Token(Token = "0x400057D")]
			WorldsBegin,
			[Token(Token = "0x400057E")]
			WorldsEnd,
			[Token(Token = "0x400057F")]
			CreateRoomBegin,
			[Token(Token = "0x4000580")]
			CreateRoomEnd,
			[Token(Token = "0x4000581")]
			RoomBegin,
			[Token(Token = "0x4000582")]
			RoomEnd,
			[Token(Token = "0x4000583")]
			RoomsBegin,
			[Token(Token = "0x4000584")]
			RoomsEnd,
			[Token(Token = "0x4000585")]
			RoomPingTimeBegin,
			[Token(Token = "0x4000586")]
			RoomPingTimeEnd,
			[Token(Token = "0x4000587")]
			GetDataBegin,
			[Token(Token = "0x4000588")]
			GetDataEnd,
			[Token(Token = "0x4000589")]
			TssDataBegin,
			[Token(Token = "0x400058A")]
			TssDataEnd,
			[Token(Token = "0x400058B")]
			TusVariablesBegin,
			[Token(Token = "0x400058C")]
			TusVariablesEnd,
			[Token(Token = "0x400058D")]
			TusAtomicAddToAndGetVariableBegin,
			[Token(Token = "0x400058E")]
			TusAtomicAddToAndGetVariableEnd,
			[Token(Token = "0x400058F")]
			TusDataBegin,
			[Token(Token = "0x4000590")]
			TusDataEnd,
			[Token(Token = "0x4000591")]
			TusFriendsVariablesBegin,
			[Token(Token = "0x4000592")]
			TusFriendsVariablesEnd,
			[Token(Token = "0x4000593")]
			TusDataStatusesBegin,
			[Token(Token = "0x4000594")]
			TusDataStatusesEnd,
			[Token(Token = "0x4000595")]
			TusFriendsDataStatusesBegin,
			[Token(Token = "0x4000596")]
			TusFriendsDataStatusesEnd,
			[Token(Token = "0x4000597")]
			GameDataMessagesBegin,
			[Token(Token = "0x4000598")]
			GameDataMessagesEnd,
			[Token(Token = "0x4000599")]
			GameDataMessageThumbnailBegin,
			[Token(Token = "0x400059A")]
			GameDataMessageThumbnailEnd,
			[Token(Token = "0x400059B")]
			GameDataMessageAttachmentBegin,
			[Token(Token = "0x400059C")]
			GameDataMessageAttachmentEnd,
			[Token(Token = "0x400059D")]
			GameDataMessageBegin,
			[Token(Token = "0x400059E")]
			GameDataMessageEnd,
			[Token(Token = "0x400059F")]
			GameDataMessageDetailsBegin,
			[Token(Token = "0x40005A0")]
			GameDataMessageDetailsEnd,
			[Token(Token = "0x40005A1")]
			CategoriesBegin,
			[Token(Token = "0x40005A2")]
			CategoriesEnd,
			[Token(Token = "0x40005A3")]
			CategoryBegin,
			[Token(Token = "0x40005A4")]
			CategoryEnd,
			[Token(Token = "0x40005A5")]
			SubCategoryBegin,
			[Token(Token = "0x40005A6")]
			SubCategoryEnd,
			[Token(Token = "0x40005A7")]
			ProductsBegin,
			[Token(Token = "0x40005A8")]
			ProductsEnd,
			[Token(Token = "0x40005A9")]
			ProductBegin,
			[Token(Token = "0x40005AA")]
			ProductEnd,
			[Token(Token = "0x40005AB")]
			ProductDetailsBegin,
			[Token(Token = "0x40005AC")]
			ProductDetailsEnd,
			[Token(Token = "0x40005AD")]
			SkuInfoBegin,
			[Token(Token = "0x40005AE")]
			SkuInfoEnd,
			[Token(Token = "0x40005AF")]
			ServiceEntitlementsBegin,
			[Token(Token = "0x40005B0")]
			ServiceEntitlementsEnd,
			[Token(Token = "0x40005B1")]
			ServiceEntitlementBegin,
			[Token(Token = "0x40005B2")]
			ServiceEntitlementEnd,
			[Token(Token = "0x40005B3")]
			AuthCodeBegin,
			[Token(Token = "0x40005B4")]
			AuthCodeEnd,
			[Token(Token = "0x40005B5")]
			IdTokenBegin,
			[Token(Token = "0x40005B6")]
			IdTokenEnd,
			[Token(Token = "0x40005B7")]
			WordFilterBegin,
			[Token(Token = "0x40005B8")]
			WordFilterEnd,
			[Token(Token = "0x40005B9")]
			FriendListUpdateBegin,
			[Token(Token = "0x40005BA")]
			FriendListUpdateEnd,
			[Token(Token = "0x40005BB")]
			BlocklistUpdateBegin,
			[Token(Token = "0x40005BC")]
			BlocklistUpdateEnd,
			[Token(Token = "0x40005BD")]
			PresenceUpdateBegin,
			[Token(Token = "0x40005BE")]
			PresenceUpdateEnd,
			[Token(Token = "0x40005BF")]
			UserStateChangeBegin,
			[Token(Token = "0x40005C0")]
			UserStateChangeEnd,
			[Token(Token = "0x40005C1")]
			NetStateChangeBegin,
			[Token(Token = "0x40005C2")]
			NetStateChangeEnd,
			[Token(Token = "0x40005C3")]
			RefreshRoomBegin,
			[Token(Token = "0x40005C4")]
			RefreshRoomEnd,
			[Token(Token = "0x40005C5")]
			InvitationReceivedBegin,
			[Token(Token = "0x40005C6")]
			InvitationReceivedEnd,
			[Token(Token = "0x40005C7")]
			NewRoomMessageBegin,
			[Token(Token = "0x40005C8")]
			NewRoomMessageEnd,
			[Token(Token = "0x40005C9")]
			NewInGameMessageBegin,
			[Token(Token = "0x40005CA")]
			NewInGameMessageEnd,
			[Token(Token = "0x40005CB")]
			NewGameDataMessageBegin,
			[Token(Token = "0x40005CC")]
			NewGameDataMessageEnd,
			[Token(Token = "0x40005CD")]
			SessionInvitationEventBegin,
			[Token(Token = "0x40005CE")]
			SessionInvitationEventEnd,
			[Token(Token = "0x40005CF")]
			PlayTogetherHostEventBegin,
			[Token(Token = "0x40005D0")]
			PlayTogetherHostEventEnd,
			[Token(Token = "0x40005D1")]
			GameCustomDataEventBegin,
			[Token(Token = "0x40005D2")]
			GameCustomDataEventEnd,
			[Token(Token = "0x40005D3")]
			LaunchAppEventBegin,
			[Token(Token = "0x40005D4")]
			LaunchAppEventEnd,
			[Token(Token = "0x40005D5")]
			CheckPlusBegin,
			[Token(Token = "0x40005D6")]
			CheckPlusEnd,
			[Token(Token = "0x40005D7")]
			GetParentalControlInfoBegin,
			[Token(Token = "0x40005D8")]
			GetParentalControlInfoEnd,
			[Token(Token = "0x40005D9")]
			GetFeedBegin,
			[Token(Token = "0x40005DA")]
			GetFeedEnd,
			[Token(Token = "0x40005DB")]
			StoryBegin,
			[Token(Token = "0x40005DC")]
			StoryEnd,
			[Token(Token = "0x40005DD")]
			StoryUserBegin,
			[Token(Token = "0x40005DE")]
			StoryUserEnd,
			[Token(Token = "0x40005DF")]
			UsersWhoLikedBegin,
			[Token(Token = "0x40005E0")]
			UsersWhoLikedEnd,
			[Token(Token = "0x40005E1")]
			PlayedWithFeedBegin,
			[Token(Token = "0x40005E2")]
			PlayedWithFeedEnd,
			[Token(Token = "0x40005E3")]
			SharedVideosBegin,
			[Token(Token = "0x40005E4")]
			SharedVideosEnd,
			[Token(Token = "0x40005E5")]
			SharedVideoBegin,
			[Token(Token = "0x40005E6")]
			SharedVideoEnd
		}

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private NpMemoryBuffer rawBuffer;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IntPtr pos;

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x25194D8", Offset = "0x25194D8", VA = "0x25194D8")]
		public MemoryBuffer(NpMemoryBuffer pointer)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2519514", Offset = "0x2519514", VA = "0x2519514")]
		public void CheckStartMarker()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x251951C", Offset = "0x251951C", VA = "0x251951C")]
		public void CheckEndMarker()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2513C40", Offset = "0x2513C40", VA = "0x2513C40")]
		public void CheckMarker(BufferIntegrityChecks value)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2519524", Offset = "0x2519524", VA = "0x2519524")]
		public void CheckBufferOverflow(string method)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2514D48", Offset = "0x2514D48", VA = "0x2514D48")]
		public bool ReadBool()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x251976C", Offset = "0x251976C", VA = "0x251976C")]
		public sbyte ReadInt8()
		{
			return default(sbyte);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2519828", Offset = "0x2519828", VA = "0x2519828")]
		public byte ReadUInt8()
		{
			return default(byte);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x25198E4", Offset = "0x25198E4", VA = "0x25198E4")]
		public short ReadInt16()
		{
			return default(short);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2514C8C", Offset = "0x2514C8C", VA = "0x2514C8C")]
		public ushort ReadUInt16()
		{
			return default(ushort);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2512890", Offset = "0x2512890", VA = "0x2512890")]
		public int ReadInt32()
		{
			return default(int);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2513094", Offset = "0x2513094", VA = "0x2513094")]
		public uint ReadUInt32()
		{
			return default(uint);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2515E14", Offset = "0x2515E14", VA = "0x2515E14")]
		public long ReadInt64()
		{
			return default(long);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2514B5C", Offset = "0x2514B5C", VA = "0x2514B5C")]
		public ulong ReadUInt64()
		{
			return default(ulong);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x25199A0", Offset = "0x25199A0", VA = "0x25199A0")]
		public IntPtr ReadPtr()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2519A70", Offset = "0x2519A70", VA = "0x2519A70")]
		public double ReadDouble()
		{
			return default(double);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x251294C", Offset = "0x251294C", VA = "0x251294C")]
		public uint ReadData(ref byte[] data)
		{
			return default(uint);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2519B6C", Offset = "0x2519B6C", VA = "0x2519B6C")]
		public uint ReadData(ref byte[] data, uint startIndex)
		{
			return default(uint);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2512FD8", Offset = "0x2512FD8", VA = "0x2512FD8")]
		public void ReadString(ref string str)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2519CA0", Offset = "0x2519CA0", VA = "0x2519CA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000028")]
	public enum ServiceTypes
	{
		[Token(Token = "0x40002F1")]
		Invalid,
		[Token(Token = "0x40002F2")]
		ActivityFeed,
		[Token(Token = "0x40002F3")]
		Auth,
		[Token(Token = "0x40002F4")]
		Commerce,
		[Token(Token = "0x40002F5")]
		Core,
		[Token(Token = "0x40002F6")]
		EventsClient,
		[Token(Token = "0x40002F7")]
		Friends,
		[Token(Token = "0x40002F8")]
		Matching,
		[Token(Token = "0x40002F9")]
		Messaging,
		[Token(Token = "0x40002FA")]
		NetworkUtils,
		[Token(Token = "0x40002FB")]
		Notification,
		[Token(Token = "0x40002FC")]
		NpUtils,
		[Token(Token = "0x40002FD")]
		Presence,
		[Token(Token = "0x40002FE")]
		Ranking,
		[Token(Token = "0x40002FF")]
		Session,
		[Token(Token = "0x4000300")]
		SharedMedia,
		[Token(Token = "0x4000301")]
		Tournament,
		[Token(Token = "0x4000302")]
		Trophy,
		[Token(Token = "0x4000303")]
		Tss,
		[Token(Token = "0x4000304")]
		Tus,
		[Token(Token = "0x4000305")]
		UserProfile,
		[Token(Token = "0x4000306")]
		WordFilter,
		[Token(Token = "0x4000307")]
		Challenge,
		[Token(Token = "0x4000308")]
		Size
	}
	[Token(Token = "0x2000029")]
	public enum FunctionTypes
	{
		[Token(Token = "0x400030A")]
		Invalid,
		[Token(Token = "0x400030B")]
		ActivityFeedGetSharedVideos,
		[Token(Token = "0x400030C")]
		ActivityFeedGetPlayedWith,
		[Token(Token = "0x400030D")]
		ActivityFeedPostPlayedWith,
		[Token(Token = "0x400030E")]
		ActivityFeedGetWhoLiked,
		[Token(Token = "0x400030F")]
		ActivityFeedSetLiked,
		[Token(Token = "0x4000310")]
		ActivityFeedGetFeed,
		[Token(Token = "0x4000311")]
		ActivityFeedPostInGameStory,
		[Token(Token = "0x4000312")]
		AuthGetAuthCode,
		[Token(Token = "0x4000313")]
		AuthGetIdToken,
		[Token(Token = "0x4000314")]
		CommerceGetCategories,
		[Token(Token = "0x4000315")]
		CommerceGetProducts,
		[Token(Token = "0x4000316")]
		CommerceGetServiceEntitlements,
		[Token(Token = "0x4000317")]
		CommerceConsumeServiceEntitlement,
		[Token(Token = "0x4000318")]
		CommerceDisplayCategoryBrowseDialog,
		[Token(Token = "0x4000319")]
		CommerceDisplayProductBrowseDialog,
		[Token(Token = "0x400031A")]
		CommerceDisplayVoucherCodeInputDialog,
		[Token(Token = "0x400031B")]
		CommerceDisplayCheckoutDialog,
		[Token(Token = "0x400031C")]
		CommerceDisplayJoinPlusDialog,
		[Token(Token = "0x400031D")]
		CommerceDisplayDownloadListDialog,
		[Token(Token = "0x400031E")]
		CommerceSetPsStoreIconDisplayState,
		[Token(Token = "0x400031F")]
		CommerceGetContainers,
		[Token(Token = "0x4000320")]
		CoreTerminateService,
		[Token(Token = "0x4000321")]
		EventsClientGetEvent,
		[Token(Token = "0x4000322")]
		FriendsGetFriends,
		[Token(Token = "0x4000323")]
		FriendsGetFriendsOfFriends,
		[Token(Token = "0x4000324")]
		FriendsGetBlockedUsers,
		[Token(Token = "0x4000325")]
		FriendsDisplayFriendRequestDialog,
		[Token(Token = "0x4000326")]
		FriendsDisplayBlockUserDialog,
		[Token(Token = "0x4000327")]
		MatchingSetInitConfiguration,
		[Token(Token = "0x4000328")]
		MatchingGetWorlds,
		[Token(Token = "0x4000329")]
		MatchingCreateRoom,
		[Token(Token = "0x400032A")]
		MatchingLeaveRoom,
		[Token(Token = "0x400032B")]
		MatchingSearchRooms,
		[Token(Token = "0x400032C")]
		MatchingJoinRoom,
		[Token(Token = "0x400032D")]
		MatchingGetRoomPingTime,
		[Token(Token = "0x400032E")]
		MatchingKickOutRoomMember,
		[Token(Token = "0x400032F")]
		MatchingSendRoomMessage,
		[Token(Token = "0x4000330")]
		MatchingGetAttributes,
		[Token(Token = "0x4000331")]
		MatchingSetRoomInfo,
		[Token(Token = "0x4000332")]
		MatchingSendInvitation,
		[Token(Token = "0x4000333")]
		MatchingGetData,
		[Token(Token = "0x4000334")]
		MatchingSetMembersAsRecentlyMet,
		[Token(Token = "0x4000335")]
		MessagingSendInGameMessage,
		[Token(Token = "0x4000336")]
		NetworkUtilsGetBandwidthInfo,
		[Token(Token = "0x4000337")]
		NetworkUtilsGetBasicNetworkInfo,
		[Token(Token = "0x4000338")]
		NetworkUtilsGetDetailedNetworkInfo,
		[Token(Token = "0x4000339")]
		NotificationRefreshRoom,
		[Token(Token = "0x400033A")]
		NotificationNewRoomMessage,
		[Token(Token = "0x400033B")]
		NotificationDialogOpened,
		[Token(Token = "0x400033C")]
		NotificationDialogClosed,
		[Token(Token = "0x400033D")]
		NotificationUserStateChange,
		[Token(Token = "0x400033E")]
		NotificationNetStateChange,
		[Token(Token = "0x400033F")]
		NotificationNewInGameMessage,
		[Token(Token = "0x4000340")]
		NotificationUpdateFriendsList,
		[Token(Token = "0x4000341")]
		NotificationNewInvitation,
		[Token(Token = "0x4000342")]
		NotificationUpdateFriendPresence,
		[Token(Token = "0x4000343")]
		NotificationUpdateBlockedUsersList,
		[Token(Token = "0x4000344")]
		NotificationAborted,
		[Token(Token = "0x4000345")]
		NpUtilsDisplaySigninDialog,
		[Token(Token = "0x4000346")]
		NpUtilsSetTitleIdForDevelopment,
		[Token(Token = "0x4000347")]
		NpUtilsCheckAvailability,
		[Token(Token = "0x4000348")]
		NpUtilsCheckPsPlusAccess,
		[Token(Token = "0x4000349")]
		NpUtilsGetAccountIdByOnlineId,
		[Token(Token = "0x400034A")]
		NpUtilsGetOnlineIdByAccountId,
		[Token(Token = "0x400034B")]
		PresenceSetPresence,
		[Token(Token = "0x400034C")]
		PresenceGetPresence,
		[Token(Token = "0x400034D")]
		PresenceDeletePresence,
		[Token(Token = "0x400034E")]
		RankingSetScore,
		[Token(Token = "0x400034F")]
		RankingGetRangeOfRanks,
		[Token(Token = "0x4000350")]
		RankingGetFriendsRanks,
		[Token(Token = "0x4000351")]
		RankingGetUsersRanks,
		[Token(Token = "0x4000352")]
		RankingSetGameData,
		[Token(Token = "0x4000353")]
		RankingGetGameData,
		[Token(Token = "0x4000354")]
		SessionSendInvitation,
		[Token(Token = "0x4000355")]
		SessionDisplayReceivedInvitationsDialog,
		[Token(Token = "0x4000356")]
		SessionGetReceivedInvitations,
		[Token(Token = "0x4000357")]
		SessionGetInvitationData,
		[Token(Token = "0x4000358")]
		SessionConsumeInvitation,
		[Token(Token = "0x4000359")]
		SessionGetData,
		[Token(Token = "0x400035A")]
		SessionLeave,
		[Token(Token = "0x400035B")]
		SessionUpdate,
		[Token(Token = "0x400035C")]
		SessionGetInfo,
		[Token(Token = "0x400035D")]
		SessionJoin,
		[Token(Token = "0x400035E")]
		SessionSearch,
		[Token(Token = "0x400035F")]
		SessionCreate,
		[Token(Token = "0x4000360")]
		SharedMediaGetScreenshots,
		[Token(Token = "0x4000361")]
		SharedMediaGetBroadcasts,
		[Token(Token = "0x4000362")]
		SharedMediaGetVideos,
		[Token(Token = "0x4000363")]
		TournamentSearchEvents,
		[Token(Token = "0x4000364")]
		TournamentGetEvent,
		[Token(Token = "0x4000365")]
		TournamentGetRegisteredUsers,
		[Token(Token = "0x4000366")]
		TournamentGetRegisteredTeams,
		[Token(Token = "0x4000367")]
		TournamentGetRegisteredRoster,
		[Token(Token = "0x4000368")]
		TournamentGetBracket,
		[Token(Token = "0x4000369")]
		TournamentSendUserMatchReport,
		[Token(Token = "0x400036A")]
		TournamentSendTeamMatchReport,
		[Token(Token = "0x400036B")]
		TrophyRegisterTrophyPack,
		[Token(Token = "0x400036C")]
		TrophyUnlock,
		[Token(Token = "0x400036D")]
		TrophySetScreenshot,
		[Token(Token = "0x400036E")]
		TrophyGetUnlockedTrophies,
		[Token(Token = "0x400036F")]
		TrophyDisplayTrophyListDialog,
		[Token(Token = "0x4000370")]
		TrophyGetTrophyPackSummary,
		[Token(Token = "0x4000371")]
		TrophyGetTrophyPackGroup,
		[Token(Token = "0x4000372")]
		TrophyGetTrophyPackTrophy,
		[Token(Token = "0x4000373")]
		TssGetData,
		[Token(Token = "0x4000374")]
		TusGetVariables,
		[Token(Token = "0x4000375")]
		TusSetVariables,
		[Token(Token = "0x4000376")]
		TusGetFriendsVariable,
		[Token(Token = "0x4000377")]
		TusAddToAndGetVariable,
		[Token(Token = "0x4000378")]
		TusTryAndSetVariable,
		[Token(Token = "0x4000379")]
		TusGetData,
		[Token(Token = "0x400037A")]
		TusSetData,
		[Token(Token = "0x400037B")]
		TusDeleteData,
		[Token(Token = "0x400037C")]
		TusGetUsersVariable,
		[Token(Token = "0x400037D")]
		TusGetUsersDataStatus,
		[Token(Token = "0x400037E")]
		TusGetFriendsDataStatus,
		[Token(Token = "0x400037F")]
		UserProfileGetNpProfiles,
		[Token(Token = "0x4000380")]
		UserProfileGetVerifiedAccountsForTitle,
		[Token(Token = "0x4000381")]
		UserProfileDisplayUserProfileDialog,
		[Token(Token = "0x4000382")]
		UserProfileDisplayGriefReportingDialog,
		[Token(Token = "0x4000383")]
		WordfilterFilterComment,
		[Token(Token = "0x4000384")]
		Internal1,
		[Token(Token = "0x4000385")]
		Internal2,
		[Token(Token = "0x4000386")]
		NumFunctionTypes,
		[Token(Token = "0x4000387")]
		NotificationSessionInvitationEvent,
		[Token(Token = "0x4000388")]
		NotificationPlayTogetherHostEvent,
		[Token(Token = "0x4000389")]
		NotificationGameCustomDataEvent,
		[Token(Token = "0x400038A")]
		NotificationLaunchAppEvent,
		[Token(Token = "0x400038B")]
		NpUtilsCheckPlus,
		[Token(Token = "0x400038C")]
		NpUtilsGetParentalControlInfo,
		[Token(Token = "0x400038D")]
		ChallengeConsumeChallenge,
		[Token(Token = "0x400038E")]
		ChallengeSendChallenge,
		[Token(Token = "0x400038F")]
		ChallengeGetReceivedChallenges,
		[Token(Token = "0x4000390")]
		ChallengeGetChallengeData,
		[Token(Token = "0x4000391")]
		ChallengeGetChallengeThumbnail,
		[Token(Token = "0x4000392")]
		MessagingSendGameDataMessage,
		[Token(Token = "0x4000393")]
		MessagingDisplayReceivedGameDataMessagesDialog,
		[Token(Token = "0x4000394")]
		MessagingGetReceivedGameDataMessages,
		[Token(Token = "0x4000395")]
		MessagingConsumeGameDataMessage,
		[Token(Token = "0x4000396")]
		MessagingGetGameDataMessageThumbnail,
		[Token(Token = "0x4000397")]
		MessagingGetGameDataMessageAttachment,
		[Token(Token = "0x4000398")]
		NotificationNewGameDataMessage
	}
	[StructLayout(0)]
	[Token(Token = "0x200002A")]
	public class RequestBase
	{
		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int serviceType;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal int functionType;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal uint serviceLabel;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal Core.UserServiceUserId userId;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal bool async;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal uint padding;

		[Token(Token = "0x1700002A")]
		public ServiceTypes ServiceType
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x24EF9EC", Offset = "0x24EF9EC", VA = "0x24EF9EC")]
			get
			{
				return default(ServiceTypes);
			}
		}

		[Token(Token = "0x1700002B")]
		public FunctionTypes FunctionType
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x24EA954", Offset = "0x24EA954", VA = "0x24EA954")]
			get
			{
				return default(FunctionTypes);
			}
		}

		[Token(Token = "0x1700002C")]
		public uint ServiceLabel
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x24EF9F8", Offset = "0x24EF9F8", VA = "0x24EF9F8")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x24EFA00", Offset = "0x24EFA00", VA = "0x24EFA00")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public Core.UserServiceUserId UserId
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x24EFA08", Offset = "0x24EFA08", VA = "0x24EFA08")]
			get
			{
				return default(Core.UserServiceUserId);
			}
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x24EFA10", Offset = "0x24EFA10", VA = "0x24EFA10")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public bool Async
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x24EFA18", Offset = "0x24EFA18", VA = "0x24EFA18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x24EFA20", Offset = "0x24EFA20", VA = "0x24EFA20")]
			set
			{
			}
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x24E5850", Offset = "0x24E5850", VA = "0x24E5850")]
		internal RequestBase(ServiceTypes serviceType, FunctionTypes functionType)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x24E5CB8", Offset = "0x24E5CB8", VA = "0x24E5CB8")]
		internal static void FinaliseRequest(RequestBase request, ResponseBase response, int npRequestId)
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class PendingRequest
	{
		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal uint npRequestId;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal RequestBase request;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal bool abortPending;

		[Token(Token = "0x1700002F")]
		public uint NpRequestId
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x24E99FC", Offset = "0x24E99FC", VA = "0x24E99FC")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000030")]
		public RequestBase Request
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x24E9A04", Offset = "0x24E9A04", VA = "0x24E9A04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public bool AbortPending
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x24E9A0C", Offset = "0x24E9A0C", VA = "0x24E9A0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x24E8F54", Offset = "0x24E8F54", VA = "0x24E8F54")]
		public PendingRequest()
		{
		}
	}
	[Token(Token = "0x200002C")]
	internal static class PendingAsyncRequestList
	{
		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<uint, PendingRequest> requestsLookup;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<PendingRequest> pendingRequests;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static object syncObject;

		[Token(Token = "0x17000032")]
		public static List<PendingRequest> PendingRequests
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x24E8A74", Offset = "0x24E8A74", VA = "0x24E8A74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x24E8B98", Offset = "0x24E8B98", VA = "0x24E8B98")]
		internal static void Shutdown()
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x24E8CA4", Offset = "0x24E8CA4", VA = "0x24E8CA4")]
		public static bool IsPending(uint npRequestId)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x24E8DC8", Offset = "0x24E8DC8", VA = "0x24E8DC8")]
		internal static void AddRequest(uint npRequestId, RequestBase request)
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x24E8F5C", Offset = "0x24E8F5C", VA = "0x24E8F5C")]
		internal static RequestBase RemoveRequest(uint npRequestId)
		{
			return null;
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x24E9124", Offset = "0x24E9124", VA = "0x24E9124")]
		internal static bool MarkRequestAsAborting(uint npRequestId)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x24E927C", Offset = "0x24E927C", VA = "0x24E927C")]
		internal static void RequestHasBeenAborted(uint npRequestId)
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class ServerErrorManaged
	{
		[Token(Token = "0x40003A5")]
		private const int JSON_DATA_MAX_LEN = 512;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal byte[] jsonData;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal long webApiNextAvailableTime;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal int httpStatusCode;

		[Token(Token = "0x17000033")]
		public string JsonData
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x24F04C0", Offset = "0x24F04C0", VA = "0x24F04C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public long WebApiNextAvailableTime
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x24F0508", Offset = "0x24F0508", VA = "0x24F0508")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000035")]
		public int HttpStatusCode
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x24F0510", Offset = "0x24F0510", VA = "0x24F0510")]
			get
			{
				return default(int);
			}
		}

		[PreserveSig]
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x24F03F8", Offset = "0x24F03F8", VA = "0x24F03F8")]
		private static extern void PrxReadServerError(uint responseId, int apiCalled, out long webApiNextAvailableTime, out int httpStatusCode, [In][Out] byte[] jsonData, out APIResult result);

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x24EFEFC", Offset = "0x24EFEFC", VA = "0x24EFEFC")]
		internal void ReadResult(uint unqiueId, FunctionTypes apiCalled)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x24EFE9C", Offset = "0x24EFE9C", VA = "0x24EFE9C")]
		public ServerErrorManaged()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class ResponseBase
	{
		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int returnCode;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal bool locked;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal ServerErrorManaged serverError;

		[Token(Token = "0x17000036")]
		public int ReturnCodeValue
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x24EFE5C", Offset = "0x24EFE5C", VA = "0x24EFE5C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000037")]
		public Core.ReturnCodes ReturnCode
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x24EFE64", Offset = "0x24EFE64", VA = "0x24EFE64")]
			get
			{
				return default(Core.ReturnCodes);
			}
		}

		[Token(Token = "0x17000038")]
		public bool Locked
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x24EFE6C", Offset = "0x24EFE6C", VA = "0x24EFE6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000039")]
		public ServerErrorManaged ServerError
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x24EFE74", Offset = "0x24EFE74", VA = "0x24EFE74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public bool IsErrorCode
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x24EFE7C", Offset = "0x24EFE7C", VA = "0x24EFE7C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003B")]
		public bool HasServerError
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x24EFE8C", Offset = "0x24EFE8C", VA = "0x24EFE8C")]
			get
			{
				return default(bool);
			}
		}

		[PreserveSig]
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x24EFAFC", Offset = "0x24EFAFC", VA = "0x24EFAFC")]
		private static extern void PrxReadResponseBase(uint nptRequestId, int apiCalled, out int returnCode, out bool locked, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x24EFBC0", Offset = "0x24EFBC0", VA = "0x24EFBC0")]
		private static extern void PrxReadResponseBaseLockedState(uint nptRequestId, int apiCalled, out bool locked, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x24EFC7C", Offset = "0x24EFC7C", VA = "0x24EFC7C")]
		private static extern void PrxReadResponseCompleted(uint nptRequestId, int apiCalled, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x24EFD14", Offset = "0x24EFD14", VA = "0x24EFD14")]
		private static extern bool PrxReadHasServerError(uint nptRequestId, int apiCalled, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x24EFDB4", Offset = "0x24EFDB4", VA = "0x24EFDB4")]
		private static extern void PrxMarshalResponse(uint npRequestId, int apiCalled, out NpMemoryBuffer data, out APIResult result);

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x24E63EC", Offset = "0x24E63EC", VA = "0x24E63EC")]
		internal ResponseBase()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x24EA860", Offset = "0x24EA860", VA = "0x24EA860")]
		internal void PopulateFromNative(uint nptRequestId, FunctionTypes apiCalled, RequestBase request)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x24E60FC", Offset = "0x24E60FC", VA = "0x24E60FC", Slot = "4")]
		protected internal virtual void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x24EFA2C", Offset = "0x24EFA2C", VA = "0x24EFA2C")]
		internal void UpdateAsyncState(uint nptRequestId, FunctionTypes apiCalled)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x24E6264", Offset = "0x24E6264", VA = "0x24E6264")]
		internal MemoryBuffer BeginReadResponseBuffer(uint id, FunctionTypes apiCalled, out APIResult result)
		{
			return null;
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x24E63C8", Offset = "0x24E63C8", VA = "0x24E63C8")]
		internal void EndReadResponseBuffer(MemoryBuffer readBuffer)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x24EFFD4", Offset = "0x24EFFD4", VA = "0x24EFFD4")]
		public string ConvertReturnCodeToString(FunctionTypes apiCalled)
		{
			return null;
		}
	}
	[Token(Token = "0x200002F")]
	internal static class PendingAsyncResponseList
	{
		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<uint, ResponseBase> responseLookup;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static object syncObject;

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x24E943C", Offset = "0x24E943C", VA = "0x24E943C")]
		public static void AddResponse(uint npRequestId, ResponseBase response)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x24E9560", Offset = "0x24E9560", VA = "0x24E9560")]
		public static ResponseBase FindAndRemoveResponse(uint npRequestId)
		{
			return null;
		}
	}
	[Token(Token = "0x2000030")]
	public class Friends
	{
		[Token(Token = "0x2000095")]
		public class Friend
		{
			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Profiles.Profile profile;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Presence.UserPresence presence;

			[Token(Token = "0x170000DB")]
			public Profiles.Profile Profile
			{
				[Token(Token = "0x60002F0")]
				[Address(RVA = "0x24E16B8", Offset = "0x24E16B8", VA = "0x24E16B8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DC")]
			public Presence.UserPresence Presence
			{
				[Token(Token = "0x60002F1")]
				[Address(RVA = "0x24E16C0", Offset = "0x24E16C0", VA = "0x24E16C0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x24E16C8", Offset = "0x24E16C8", VA = "0x24E16C8")]
			public Friend()
			{
			}

			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x24E1750", Offset = "0x24E1750", VA = "0x24E1750", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x24E17F8", Offset = "0x24E17F8", VA = "0x24E17F8")]
			internal void Read(MemoryBuffer buffer)
			{
			}
		}

		[Token(Token = "0x2000096")]
		public enum FriendsRetrievalModes
		{
			[Token(Token = "0x40005EA")]
			invalid,
			[Token(Token = "0x40005EB")]
			all,
			[Token(Token = "0x40005EC")]
			online,
			[Token(Token = "0x40005ED")]
			inContext,
			[Token(Token = "0x40005EE")]
			tryCached
		}

		[StructLayout(0)]
		[Token(Token = "0x2000097")]
		public class GetFriendsRequest : RequestBase
		{
			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal FriendsRetrievalModes mode;

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal uint limit;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal uint offset;

			[Token(Token = "0x170000DD")]
			public FriendsRetrievalModes Mode
			{
				[Token(Token = "0x60002F5")]
				[Address(RVA = "0x24E2260", Offset = "0x24E2260", VA = "0x24E2260")]
				get
				{
					return default(FriendsRetrievalModes);
				}
				[Token(Token = "0x60002F6")]
				[Address(RVA = "0x24E2268", Offset = "0x24E2268", VA = "0x24E2268")]
				set
				{
				}
			}

			[Token(Token = "0x170000DE")]
			public uint Limit
			{
				[Token(Token = "0x60002F7")]
				[Address(RVA = "0x24E2270", Offset = "0x24E2270", VA = "0x24E2270")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x60002F8")]
				[Address(RVA = "0x24E2278", Offset = "0x24E2278", VA = "0x24E2278")]
				set
				{
				}
			}

			[Token(Token = "0x170000DF")]
			public uint Offset
			{
				[Token(Token = "0x60002F9")]
				[Address(RVA = "0x24E2280", Offset = "0x24E2280", VA = "0x24E2280")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x60002FA")]
				[Address(RVA = "0x24E2288", Offset = "0x24E2288", VA = "0x24E2288")]
				set
				{
				}
			}

			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x24E2290", Offset = "0x24E2290", VA = "0x24E2290")]
			public GetFriendsRequest()
			{
			}
		}

		[Token(Token = "0x2000098")]
		public class FriendsResponse : ResponseBase
		{
			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Friend[] friends;

			[Token(Token = "0x170000E0")]
			public Friend[] Friends
			{
				[Token(Token = "0x60002FC")]
				[Address(RVA = "0x24E1E38", Offset = "0x24E1E38", VA = "0x24E1E38")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x24E1E40", Offset = "0x24E1E40", VA = "0x24E1E40", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x24E2010", Offset = "0x24E2010", VA = "0x24E2010")]
			public FriendsResponse()
			{
			}
		}

		[Token(Token = "0x2000099")]
		public class FriendsOfFriend
		{
			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Core.OnlineUser originalFriend;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Core.OnlineUser[] users;

			[Token(Token = "0x170000E1")]
			public Core.OnlineUser OriginalFriend
			{
				[Token(Token = "0x60002FF")]
				[Address(RVA = "0x24E1A68", Offset = "0x24E1A68", VA = "0x24E1A68")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E2")]
			public Core.OnlineUser[] Users
			{
				[Token(Token = "0x6000300")]
				[Address(RVA = "0x24E1A70", Offset = "0x24E1A70", VA = "0x24E1A70")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000301")]
			[Address(RVA = "0x24E1A78", Offset = "0x24E1A78", VA = "0x24E1A78")]
			public FriendsOfFriend()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x200009A")]
		public class GetFriendsOfFriendsRequest : RequestBase
		{
			[Token(Token = "0x40005F5")]
			public const int MAX_ACCOUNT_IDS = 10;

			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Core.NpAccountId[] accountIds;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal uint numAccountIds;

			[Token(Token = "0x170000E3")]
			public Core.NpAccountId[] AccountIds
			{
				[Token(Token = "0x6000302")]
				[Address(RVA = "0x24E207C", Offset = "0x24E207C", VA = "0x24E207C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000303")]
				[Address(RVA = "0x24E20FC", Offset = "0x24E20FC", VA = "0x24E20FC")]
				set
				{
				}
			}

			[Token(Token = "0x6000304")]
			[Address(RVA = "0x24E21F0", Offset = "0x24E21F0", VA = "0x24E21F0")]
			public GetFriendsOfFriendsRequest()
			{
			}
		}

		[Token(Token = "0x200009B")]
		public class FriendsOfFriendsResponse : ResponseBase
		{
			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal FriendsOfFriend[] friendsOfFriends;

			[Token(Token = "0x170000E4")]
			public FriendsOfFriend[] FriendsOfFriends
			{
				[Token(Token = "0x6000305")]
				[Address(RVA = "0x24E1AE0", Offset = "0x24E1AE0", VA = "0x24E1AE0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000306")]
			[Address(RVA = "0x24E1AE8", Offset = "0x24E1AE8", VA = "0x24E1AE8", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x6000307")]
			[Address(RVA = "0x24E1E30", Offset = "0x24E1E30", VA = "0x24E1E30")]
			public FriendsOfFriendsResponse()
			{
			}
		}

		[Token(Token = "0x200009C")]
		public enum BlockedUsersRetrievalMode
		{
			[Token(Token = "0x40005FA")]
			invalid,
			[Token(Token = "0x40005FB")]
			all,
			[Token(Token = "0x40005FC")]
			tryCached
		}

		[StructLayout(0)]
		[Token(Token = "0x200009D")]
		public class GetBlockedUsersRquest : RequestBase
		{
			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal BlockedUsersRetrievalMode mode;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal uint limit;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal uint offset;

			[Token(Token = "0x170000E5")]
			public BlockedUsersRetrievalMode Mode
			{
				[Token(Token = "0x6000308")]
				[Address(RVA = "0x24E2018", Offset = "0x24E2018", VA = "0x24E2018")]
				get
				{
					return default(BlockedUsersRetrievalMode);
				}
				[Token(Token = "0x6000309")]
				[Address(RVA = "0x24E2020", Offset = "0x24E2020", VA = "0x24E2020")]
				set
				{
				}
			}

			[Token(Token = "0x170000E6")]
			public uint Limit
			{
				[Token(Token = "0x600030A")]
				[Address(RVA = "0x24E2028", Offset = "0x24E2028", VA = "0x24E2028")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x600030B")]
				[Address(RVA = "0x24E2030", Offset = "0x24E2030", VA = "0x24E2030")]
				set
				{
				}
			}

			[Token(Token = "0x170000E7")]
			public uint Offset
			{
				[Token(Token = "0x600030C")]
				[Address(RVA = "0x24E2038", Offset = "0x24E2038", VA = "0x24E2038")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x600030D")]
				[Address(RVA = "0x24E2040", Offset = "0x24E2040", VA = "0x24E2040")]
				set
				{
				}
			}

			[Token(Token = "0x600030E")]
			[Address(RVA = "0x24E2048", Offset = "0x24E2048", VA = "0x24E2048")]
			public GetBlockedUsersRquest()
			{
			}
		}

		[Token(Token = "0x200009E")]
		public class BlockedUsersResponse : ResponseBase
		{
			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Core.OnlineUser[] users;

			[Token(Token = "0x170000E8")]
			public Core.OnlineUser[] Users
			{
				[Token(Token = "0x600030F")]
				[Address(RVA = "0x24E1250", Offset = "0x24E1250", VA = "0x24E1250")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000310")]
			[Address(RVA = "0x24E1258", Offset = "0x24E1258", VA = "0x24E1258", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x6000311")]
			[Address(RVA = "0x24E1478", Offset = "0x24E1478", VA = "0x24E1478")]
			public BlockedUsersResponse()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x200009F")]
		public class DisplayFriendRequestDialogRequest : RequestBase
		{
			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Core.NpAccountId targetUser;

			[Token(Token = "0x170000E9")]
			public Core.NpAccountId TargetUser
			{
				[Token(Token = "0x6000312")]
				[Address(RVA = "0x24E1678", Offset = "0x24E1678", VA = "0x24E1678")]
				get
				{
					return default(Core.NpAccountId);
				}
				[Token(Token = "0x6000313")]
				[Address(RVA = "0x24E1680", Offset = "0x24E1680", VA = "0x24E1680")]
				set
				{
				}
			}

			[Token(Token = "0x6000314")]
			[Address(RVA = "0x24E1688", Offset = "0x24E1688", VA = "0x24E1688")]
			public DisplayFriendRequestDialogRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x20000A0")]
		public class DisplayBlockUserDialogRequest : RequestBase
		{
			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Core.NpAccountId targetUser;

			[Token(Token = "0x170000EA")]
			public Core.NpAccountId TargetUser
			{
				[Token(Token = "0x6000315")]
				[Address(RVA = "0x24E1638", Offset = "0x24E1638", VA = "0x24E1638")]
				get
				{
					return default(Core.NpAccountId);
				}
				[Token(Token = "0x6000316")]
				[Address(RVA = "0x24E1640", Offset = "0x24E1640", VA = "0x24E1640")]
				set
				{
				}
			}

			[Token(Token = "0x6000317")]
			[Address(RVA = "0x24E1648", Offset = "0x24E1648", VA = "0x24E1648")]
			public DisplayBlockUserDialogRequest()
			{
			}
		}

		[Token(Token = "0x20000A1")]
		public enum FriendListUpdateEvents
		{
			[Token(Token = "0x4000604")]
			none,
			[Token(Token = "0x4000605")]
			friendAdded,
			[Token(Token = "0x4000606")]
			friendRemoved,
			[Token(Token = "0x4000607")]
			friendOnlineStatusChanged
		}

		[Token(Token = "0x20000A2")]
		public class FriendListUpdateResponse : ResponseBase
		{
			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Core.OnlineUser localUpdatedUser;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Core.OnlineUser remoteUser;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Core.UserServiceUserId userId;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal FriendListUpdateEvents eventType;

			[Token(Token = "0x170000EB")]
			public Core.OnlineUser LocalUpdatedUser
			{
				[Token(Token = "0x6000318")]
				[Address(RVA = "0x24E1864", Offset = "0x24E1864", VA = "0x24E1864")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EC")]
			public Core.OnlineUser RemoteUser
			{
				[Token(Token = "0x6000319")]
				[Address(RVA = "0x24E186C", Offset = "0x24E186C", VA = "0x24E186C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000ED")]
			public Core.UserServiceUserId UserId
			{
				[Token(Token = "0x600031A")]
				[Address(RVA = "0x24E1874", Offset = "0x24E1874", VA = "0x24E1874")]
				get
				{
					return default(Core.UserServiceUserId);
				}
			}

			[Token(Token = "0x170000EE")]
			public FriendListUpdateEvents EventType
			{
				[Token(Token = "0x600031B")]
				[Address(RVA = "0x24E187C", Offset = "0x24E187C", VA = "0x24E187C")]
				get
				{
					return default(FriendListUpdateEvents);
				}
			}

			[Token(Token = "0x600031C")]
			[Address(RVA = "0x24E1884", Offset = "0x24E1884", VA = "0x24E1884", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x600031D")]
			[Address(RVA = "0x24E19E8", Offset = "0x24E19E8", VA = "0x24E19E8")]
			public FriendListUpdateResponse()
			{
			}
		}

		[Token(Token = "0x20000A3")]
		public class BlocklistUpdateResponse : ResponseBase
		{
			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Core.OnlineUser localUpdatedUser;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Core.UserServiceUserId userId;

			[Token(Token = "0x170000EF")]
			public Core.OnlineUser LocalUpdatedUser
			{
				[Token(Token = "0x600031E")]
				[Address(RVA = "0x24E1480", Offset = "0x24E1480", VA = "0x24E1480")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F0")]
			public Core.UserServiceUserId UserId
			{
				[Token(Token = "0x600031F")]
				[Address(RVA = "0x24E1488", Offset = "0x24E1488", VA = "0x24E1488")]
				get
				{
					return default(Core.UserServiceUserId);
				}
			}

			[Token(Token = "0x6000320")]
			[Address(RVA = "0x24E1490", Offset = "0x24E1490", VA = "0x24E1490", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x6000321")]
			[Address(RVA = "0x24E15D4", Offset = "0x24E15D4", VA = "0x24E15D4")]
			public BlocklistUpdateResponse()
			{
			}
		}

		[PreserveSig]
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x24E0940", Offset = "0x24E0940", VA = "0x24E0940")]
		private static extern int PrxGetFriends(GetFriendsRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x24E0A00", Offset = "0x24E0A00", VA = "0x24E0A00")]
		private static extern int PrxGetFriendsOfFriends(GetFriendsOfFriendsRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x24E0AC4", Offset = "0x24E0AC4", VA = "0x24E0AC4")]
		private static extern int PrxGetBlockedUsers(GetBlockedUsersRquest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x24E0B84", Offset = "0x24E0B84", VA = "0x24E0B84")]
		private static extern int PrxDisplayFriendRequestDialog(DisplayFriendRequestDialogRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x24E0C48", Offset = "0x24E0C48", VA = "0x24E0C48")]
		private static extern int PrxDisplayBlockUserDialog(DisplayBlockUserDialogRequest request, out APIResult result);

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x24E0D0C", Offset = "0x24E0D0C", VA = "0x24E0D0C")]
		public static int GetFriends(GetFriendsRequest request, FriendsResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x24E0E18", Offset = "0x24E0E18", VA = "0x24E0E18")]
		public static int GetFriendsOfFriends(GetFriendsOfFriendsRequest request, FriendsOfFriendsResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x24E0F24", Offset = "0x24E0F24", VA = "0x24E0F24")]
		public static int GetBlockedUsers(GetBlockedUsersRquest request, BlockedUsersResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x24E1030", Offset = "0x24E1030", VA = "0x24E1030")]
		public static int DisplayFriendRequestDialog(DisplayFriendRequestDialogRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x24E113C", Offset = "0x24E113C", VA = "0x24E113C")]
		public static int DisplayBlockUserDialog(DisplayBlockUserDialogRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x24E1248", Offset = "0x24E1248", VA = "0x24E1248")]
		public Friends()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class Main
	{
		[Token(Token = "0x20000A4")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xCE1940", Offset = "0xCE1940")]
		internal delegate void OnPrxCallbackEvent();

		[StructLayout(0)]
		[Token(Token = "0x20000A5")]
		internal class ValidationChecks
		{
			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal uint expectedNumFunctionTypes;

			[Token(Token = "0x6000326")]
			[Address(RVA = "0x24E2BC8", Offset = "0x24E2BC8", VA = "0x24E2BC8")]
			public void Init()
			{
			}

			[Token(Token = "0x6000327")]
			[Address(RVA = "0x24E2BC0", Offset = "0x24E2BC0", VA = "0x24E2BC0")]
			public ValidationChecks()
			{
			}
		}

		[Token(Token = "0x20000A6")]
		public delegate void EventHandler(NpCallbackEvent npEvent);

		[Token(Token = "0x20000A7")]
		public class LaunchAppEventResponse : ResponseBase
		{
			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal string args;

			[Token(Token = "0x170000F1")]
			public string Args
			{
				[Token(Token = "0x600032C")]
				[Address(RVA = "0x24E36C8", Offset = "0x24E36C8", VA = "0x24E36C8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600032D")]
			[Address(RVA = "0x24E36D0", Offset = "0x24E36D0", VA = "0x24E36D0", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x600032E")]
			[Address(RVA = "0x24E3854", Offset = "0x24E3854", VA = "0x24E3854")]
			public LaunchAppEventResponse()
			{
			}
		}

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static InitResult initResult;

		[Token(Token = "0x14000001")]
		public static event EventHandler OnAsyncEvent
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x24E2C74", Offset = "0x24E2C74", VA = "0x24E2C74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE1B3C", Offset = "0xCE1B3C")]
			add
			{
			}
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x24E2D2C", Offset = "0x24E2D2C", VA = "0x24E2D2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCE1B4C", Offset = "0xCE1B4C")]
			remove
			{
			}
		}

		[PreserveSig]
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x24E2568", Offset = "0x24E2568", VA = "0x24E2568")]
		private static extern void PrxInitialize(InitToolkit initParams, out NativeInitResult initResult, OnPrxCallbackEvent toolkitEventCallback, OnPrxCallbackEvent npRequestEventCallback, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x24E26C0", Offset = "0x24E26C0", VA = "0x24E26C0")]
		private static extern void PrxValidateToolkit(ValidationChecks checks, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x24E2768", Offset = "0x24E2768", VA = "0x24E2768")]
		private static extern void PrxShutDown();

		[PreserveSig]
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x24E27D8", Offset = "0x24E27D8", VA = "0x24E27D8")]
		private static extern int PrxUpdate();

		[PreserveSig]
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x24E284C", Offset = "0x24E284C", VA = "0x24E284C")]
		private static extern bool PrxAbortRequest(uint npRequestId, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x24E28E0", Offset = "0x24E28E0", VA = "0x24E28E0")]
		private static extern int PrxGetMemoryPoolStats(out MemoryPoolStats result);

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x24E29B4", Offset = "0x24E29B4", VA = "0x24E29B4")]
		public static InitResult Initialize(InitToolkit initParams)
		{
			return default(InitResult);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x24E2DE4", Offset = "0x24E2DE4", VA = "0x24E2DE4")]
		internal static void InternalEventHandler(NpCallbackEvent npEvent)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x24E2E7C", Offset = "0x24E2E7C", VA = "0x24E2E7C")]
		internal static void CallOnAsyncEvent(NpCallbackEvent npEvent)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x24E3384", Offset = "0x24E3384", VA = "0x24E3384")]
		public static void Update()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x24E3388", Offset = "0x24E3388", VA = "0x24E3388")]
		private static void PumpAsyncEvents()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x24E3460", Offset = "0x24E3460", VA = "0x24E3460")]
		public static int GetMemoryPoolStats(out MemoryPoolStats res)
		{
			return default(int);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x24E3464", Offset = "0x24E3464", VA = "0x24E3464")]
		public static void ShutDown()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x24E3518", Offset = "0x24E3518", VA = "0x24E3518")]
		public static List<PendingRequest> GetPendingRequests()
		{
			return null;
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x24E3578", Offset = "0x24E3578", VA = "0x24E3578")]
		public static bool AbortRequest(uint npRequestId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x24E3680", Offset = "0x24E3680", VA = "0x24E3680")]
		public Main()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class Matching
	{
		[Token(Token = "0x20000A8")]
		public enum AttributeType
		{
			[Token(Token = "0x4000611")]
			Invalid,
			[Token(Token = "0x4000612")]
			Integer,
			[Token(Token = "0x4000613")]
			Binary
		}

		[Token(Token = "0x20000A9")]
		public enum AttributeScope
		{
			[Token(Token = "0x4000615")]
			Invalid,
			[Token(Token = "0x4000616")]
			Room,
			[Token(Token = "0x4000617")]
			Member
		}

		[Token(Token = "0x20000AA")]
		public enum RoomAttributeVisibility
		{
			[Token(Token = "0x4000619")]
			Invalid,
			[Token(Token = "0x400061A")]
			Internal,
			[Token(Token = "0x400061B")]
			External,
			[Token(Token = "0x400061C")]
			Search
		}

		[Token(Token = "0x20000AB")]
		public enum RoomVisibility
		{
			[Token(Token = "0x400061E")]
			Invalid,
			[Token(Token = "0x400061F")]
			PublicRoom,
			[Token(Token = "0x4000620")]
			PrivateRoom,
			[Token(Token = "0x4000621")]
			ReserveSlots
		}

		[Token(Token = "0x20000AC")]
		public enum RoomMigrationType
		{
			[Token(Token = "0x4000623")]
			OwnerBind,
			[Token(Token = "0x4000624")]
			OwnerMigration
		}

		[Token(Token = "0x20000AD")]
		public enum TopologyType
		{
			[Token(Token = "0x4000626")]
			Invalid,
			[Token(Token = "0x4000627")]
			None,
			[Token(Token = "0x4000628")]
			Mesh,
			[Token(Token = "0x4000629")]
			Star
		}

		[Token(Token = "0x20000AE")]
		public struct AttributeMetadata
		{
			[Token(Token = "0x400062A")]
			public const int MAX_SIZE_NAME = 31;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal string name;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal AttributeType type;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal AttributeScope scope;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal RoomAttributeVisibility roomAttributeVisibility;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal uint size;

			[Token(Token = "0x170000F2")]
			public string Name
			{
				[Token(Token = "0x600032F")]
				[Address(RVA = "0x2512AFC", Offset = "0x2512AFC", VA = "0x2512AFC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F3")]
			public AttributeType Type
			{
				[Token(Token = "0x6000330")]
				[Address(RVA = "0x2512B04", Offset = "0x2512B04", VA = "0x2512B04")]
				get
				{
					return default(AttributeType);
				}
			}

			[Token(Token = "0x170000F4")]
			public AttributeScope Scope
			{
				[Token(Token = "0x6000331")]
				[Address(RVA = "0x2512B0C", Offset = "0x2512B0C", VA = "0x2512B0C")]
				get
				{
					return default(AttributeScope);
				}
			}

			[Token(Token = "0x170000F5")]
			public RoomAttributeVisibility RoomVisibility
			{
				[Token(Token = "0x6000332")]
				[Address(RVA = "0x2512B14", Offset = "0x2512B14", VA = "0x2512B14")]
				get
				{
					return default(RoomAttributeVisibility);
				}
			}

			[Token(Token = "0x170000F6")]
			public uint Size
			{
				[Token(Token = "0x6000333")]
				[Address(RVA = "0x2512B1C", Offset = "0x2512B1C", VA = "0x2512B1C")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x6000334")]
			[Address(RVA = "0x2512B24", Offset = "0x2512B24", VA = "0x2512B24")]
			private void InternalSetAttribute(string name, AttributeType type, AttributeScope scope, RoomAttributeVisibility roomAttributeVisibility, uint size)
			{
			}

			[Token(Token = "0x6000335")]
			[Address(RVA = "0x251282C", Offset = "0x251282C", VA = "0x251282C")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x6000336")]
			[Address(RVA = "0x2513150", Offset = "0x2513150", VA = "0x2513150")]
			public static AttributeMetadata CreateIntegerAttribute(string name, AttributeScope scope, RoomAttributeVisibility roomAttributeVisibility)
			{
				return default(AttributeMetadata);
			}

			[Token(Token = "0x6000337")]
			[Address(RVA = "0x25131A4", Offset = "0x25131A4", VA = "0x25131A4")]
			public static AttributeMetadata CreateBinaryAttribute(string name, AttributeScope scope, RoomAttributeVisibility roomAttributeVisibility, uint size)
			{
				return default(AttributeMetadata);
			}
		}

		[Token(Token = "0x20000AF")]
		public struct Attribute
		{
			[Token(Token = "0x4000630")]
			public const int MAX_SIZE_BIN_VALUE = 256;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal AttributeMetadata metadata;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int intValue;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal byte[] binValue;

			[Token(Token = "0x170000F7")]
			public AttributeMetadata Metadata
			{
				[Token(Token = "0x6000338")]
				[Address(RVA = "0x25121D0", Offset = "0x25121D0", VA = "0x25121D0")]
				get
				{
					return default(AttributeMetadata);
				}
			}

			[Token(Token = "0x170000F8")]
			public int IntValue
			{
				[Token(Token = "0x6000339")]
				[Address(RVA = "0x25121E4", Offset = "0x25121E4", VA = "0x25121E4")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600033A")]
				[Address(RVA = "0x2512294", Offset = "0x2512294", VA = "0x2512294")]
				set
				{
				}
			}

			[Token(Token = "0x170000F9")]
			public byte[] BinValue
			{
				[Token(Token = "0x600033B")]
				[Address(RVA = "0x2512350", Offset = "0x2512350", VA = "0x2512350")]
				get
				{
					return null;
				}
				[Token(Token = "0x600033C")]
				[Address(RVA = "0x2512438", Offset = "0x2512438", VA = "0x2512438")]
				set
				{
				}
			}

			[Token(Token = "0x600033D")]
			[Address(RVA = "0x25127C8", Offset = "0x25127C8", VA = "0x25127C8")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x600033E")]
			[Address(RVA = "0x2512A5C", Offset = "0x2512A5C", VA = "0x2512A5C")]
			public static Attribute CreateIntegerAttribute(AttributeMetadata metadata, int intValue)
			{
				return default(Attribute);
			}

			[Token(Token = "0x600033F")]
			[Address(RVA = "0x2512AAC", Offset = "0x2512AAC", VA = "0x2512AAC")]
			public static Attribute CreateBinaryAttribute(AttributeMetadata metadata, byte[] binValue)
			{
				return default(Attribute);
			}
		}

		[Token(Token = "0x20000B0")]
		public struct SessionImage
		{
			[Token(Token = "0x4000634")]
			public const int IMAGE_PATH_MAX_LEN = 255;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal string sessionImgPath;

			[Token(Token = "0x170000FA")]
			public string SessionImgPath
			{
				[Token(Token = "0x6000340")]
				[Address(RVA = "0x2517934", Offset = "0x2517934", VA = "0x2517934")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000341")]
				[Address(RVA = "0x251793C", Offset = "0x251793C", VA = "0x251793C")]
				set
				{
				}
			}

			[Token(Token = "0x6000342")]
			[Address(RVA = "0x2517A20", Offset = "0x2517A20", VA = "0x2517A20")]
			internal bool IsValid()
			{
				return default(bool);
			}

			[Token(Token = "0x6000343")]
			[Address(RVA = "0x2517A40", Offset = "0x2517A40", VA = "0x2517A40")]
			internal bool Exists()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000B1")]
		public struct LocalizedSessionInfo
		{
			[Token(Token = "0x4000636")]
			public const int SESSION_NAME_LEN = 63;

			[Token(Token = "0x4000637")]
			public const int STATUS_LEN = 255;

			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private string sessionName;

			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private string status;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal string languageCode;

			[Token(Token = "0x170000FB")]
			public string SessionName
			{
				[Token(Token = "0x6000344")]
				[Address(RVA = "0x25146C8", Offset = "0x25146C8", VA = "0x25146C8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000345")]
				[Address(RVA = "0x25146D0", Offset = "0x25146D0", VA = "0x25146D0")]
				set
				{
				}
			}

			[Token(Token = "0x170000FC")]
			public string Status
			{
				[Token(Token = "0x6000346")]
				[Address(RVA = "0x25147B4", Offset = "0x25147B4", VA = "0x25147B4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000347")]
				[Address(RVA = "0x25147BC", Offset = "0x25147BC", VA = "0x25147BC")]
				set
				{
				}
			}

			[Token(Token = "0x170000FD")]
			public Core.LanguageCode LanguageCode
			{
				[Token(Token = "0x6000348")]
				[Address(RVA = "0x25148A0", Offset = "0x25148A0", VA = "0x25148A0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000349")]
				[Address(RVA = "0x2514910", Offset = "0x2514910", VA = "0x2514910")]
				set
				{
				}
			}

			[Token(Token = "0x600034A")]
			[Address(RVA = "0x251492C", Offset = "0x251492C", VA = "0x251492C")]
			public LocalizedSessionInfo(string sessionName, string status, Core.LanguageCode languageCode)
			{
			}
		}

		[Token(Token = "0x20000B2")]
		public struct PresenceOptionData
		{
			[Token(Token = "0x400063B")]
			public const int NP_MATCHING2_PRESENCE_OPTION_DATA_SIZE = 16;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal byte[] data;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal byte length;

			[Token(Token = "0x170000FE")]
			public byte[] Data
			{
				[Token(Token = "0x600034C")]
				[Address(RVA = "0x2515698", Offset = "0x2515698", VA = "0x2515698")]
				get
				{
					return null;
				}
				[Token(Token = "0x600034D")]
				[Address(RVA = "0x2515718", Offset = "0x2515718", VA = "0x2515718")]
				set
				{
				}
			}

			[Token(Token = "0x170000FF")]
			public string DataAsString
			{
				[Token(Token = "0x600034E")]
				[Address(RVA = "0x2515830", Offset = "0x2515830", VA = "0x2515830")]
				get
				{
					return null;
				}
				[Token(Token = "0x600034F")]
				[Address(RVA = "0x25158B8", Offset = "0x25158B8", VA = "0x25158B8")]
				set
				{
				}
			}

			[Token(Token = "0x600034B")]
			[Address(RVA = "0x2514564", Offset = "0x2514564", VA = "0x2514564")]
			internal void Init()
			{
			}

			[Token(Token = "0x6000350")]
			[Address(RVA = "0x2515A2C", Offset = "0x2515A2C", VA = "0x2515A2C")]
			internal void Read(MemoryBuffer buffer)
			{
			}
		}

		[Token(Token = "0x20000B3")]
		public enum SearchOperatorTypes
		{
			[Token(Token = "0x400063F")]
			Invalid,
			[Token(Token = "0x4000640")]
			Equals,
			[Token(Token = "0x4000641")]
			NotEquals,
			[Token(Token = "0x4000642")]
			LessThan,
			[Token(Token = "0x4000643")]
			LessEqualsThan,
			[Token(Token = "0x4000644")]
			GreaterThan,
			[Token(Token = "0x4000645")]
			GreaterEqualsThan
		}

		[Token(Token = "0x20000B4")]
		public struct SearchClause
		{
			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Attribute attributeToCompare;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal SearchOperatorTypes operatorType;

			[Token(Token = "0x17000100")]
			public Attribute AttributeToCompare
			{
				[Token(Token = "0x6000351")]
				[Address(RVA = "0x2516AE0", Offset = "0x2516AE0", VA = "0x2516AE0")]
				get
				{
					return default(Attribute);
				}
				[Token(Token = "0x6000352")]
				[Address(RVA = "0x2516AF4", Offset = "0x2516AF4", VA = "0x2516AF4")]
				set
				{
				}
			}

			[Token(Token = "0x17000101")]
			public SearchOperatorTypes OperatorType
			{
				[Token(Token = "0x6000353")]
				[Address(RVA = "0x2516B08", Offset = "0x2516B08", VA = "0x2516B08")]
				get
				{
					return default(SearchOperatorTypes);
				}
				[Token(Token = "0x6000354")]
				[Address(RVA = "0x2516B10", Offset = "0x2516B10", VA = "0x2516B10")]
				set
				{
				}
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x20000B5")]
		public class SetInitConfigurationRequest : RequestBase
		{
			[Token(Token = "0x4000648")]
			public const int MAX_ATTRIBUTES = 64;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ulong numAttributes;

			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private AttributeMetadata[] attributes;

			[Token(Token = "0x17000102")]
			public AttributeMetadata[] Attributes
			{
				[Token(Token = "0x6000355")]
				[Address(RVA = "0x2517CB8", Offset = "0x2517CB8", VA = "0x2517CB8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000356")]
				[Address(RVA = "0x2517D50", Offset = "0x2517D50", VA = "0x2517D50")]
				set
				{
				}
			}

			[Token(Token = "0x6000357")]
			[Address(RVA = "0x2517E48", Offset = "0x2517E48", VA = "0x2517E48")]
			private void ValidateAttributes()
			{
			}

			[Token(Token = "0x6000358")]
			[Address(RVA = "0x25181F0", Offset = "0x25181F0", VA = "0x25181F0")]
			public SetInitConfigurationRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x20000B6")]
		public class GetWorldsRequest : RequestBase
		{
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x2513FC0", Offset = "0x2513FC0", VA = "0x2513FC0")]
			public GetWorldsRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x20000B7")]
		public class CreateRoomRequest : RequestBase
		{
			[Token(Token = "0x400064B")]
			public const int MAX_ATTRIBUTES = 64;

			[Token(Token = "0x400064C")]
			public const int MAX_SIZE_ROOM_NAME = 63;

			[Token(Token = "0x400064D")]
			public const int MAX_SIZE_ROOM_STATUS = 255;

			[Token(Token = "0x400064E")]
			public const int MAX_SIZE_FIXED_DATA = 1047552;

			[Token(Token = "0x400064F")]
			public const int MAX_SIZE_CHANGEABLE_DATA = 1024;

			[Token(Token = "0x4000650")]
			public const int MAX_SIZE_LOCALIZATIONS = 10;

			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ulong numAttributes;

			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Attribute[] attributes;

			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal string name;

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal NpMatching2SessionPassword password;

			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal RoomVisibility visibility;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			internal uint numReservedSlots;

			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal ulong fixedDataSize;

			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal byte[] fixedData;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal ulong changeableDataSize;

			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			internal byte[] changeableData;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			internal string status;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			internal LocalizedSessionInfo[] localizations;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			internal SessionImage image;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			internal RoomMigrationType ownershipMigration;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			internal TopologyType topology;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			internal uint maxNumMembers;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			internal NpMatching2WorldNumber worldNumber;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x96")]
			internal bool displayOnSystem;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x97")]
			internal bool isSystemJoinable;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			internal bool joinAllLocalUsers;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
			internal bool isNatRestricted;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9A")]
			internal bool isCrossplatform;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9B")]
			internal bool allowBlockedUsersOfOwner;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			internal bool allowBlockedUsersOfMembers;

			[Token(Token = "0x17000103")]
			public Attribute[] Attributes
			{
				[Token(Token = "0x600035A")]
				[Address(RVA = "0x25131F8", Offset = "0x25131F8", VA = "0x25131F8")]
				get
				{
					return null;
				}
				[Token(Token = "0x600035B")]
				[Address(RVA = "0x2513290", Offset = "0x2513290", VA = "0x2513290")]
				set
				{
				}
			}

			[Token(Token = "0x17000104")]
			public string Name
			{
				[Token(Token = "0x600035C")]
				[Address(RVA = "0x2513384", Offset = "0x2513384", VA = "0x2513384")]
				get
				{
					return null;
				}
				[Token(Token = "0x600035D")]
				[Address(RVA = "0x251338C", Offset = "0x251338C", VA = "0x251338C")]
				set
				{
				}
			}

			[Token(Token = "0x17000105")]
			public NpMatching2SessionPassword Password
			{
				[Token(Token = "0x600035E")]
				[Address(RVA = "0x2513470", Offset = "0x2513470", VA = "0x2513470")]
				get
				{
					return default(NpMatching2SessionPassword);
				}
				[Token(Token = "0x600035F")]
				[Address(RVA = "0x2513478", Offset = "0x2513478", VA = "0x2513478")]
				set
				{
				}
			}

			[Token(Token = "0x17000106")]
			public RoomVisibility Visibility
			{
				[Token(Token = "0x6000360")]
				[Address(RVA = "0x2513480", Offset = "0x2513480", VA = "0x2513480")]
				get
				{
					return default(RoomVisibility);
				}
				[Token(Token = "0x6000361")]
				[Address(RVA = "0x2513488", Offset = "0x2513488", VA = "0x2513488")]
				set
				{
				}
			}

			[Token(Token = "0x17000107")]
			public uint NumReservedSlots
			{
				[Token(Token = "0x6000362")]
				[Address(RVA = "0x2513490", Offset = "0x2513490", VA = "0x2513490")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x6000363")]
				[Address(RVA = "0x2513498", Offset = "0x2513498", VA = "0x2513498")]
				set
				{
				}
			}

			[Token(Token = "0x17000108")]
			public byte[] FixedData
			{
				[Token(Token = "0x6000364")]
				[Address(RVA = "0x25134A0", Offset = "0x25134A0", VA = "0x25134A0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000365")]
				[Address(RVA = "0x25134A8", Offset = "0x25134A8", VA = "0x25134A8")]
				set
				{
				}
			}

			[Token(Token = "0x17000109")]
			public byte[] ChangeableData
			{
				[Token(Token = "0x6000366")]
				[Address(RVA = "0x25135A0", Offset = "0x25135A0", VA = "0x25135A0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000367")]
				[Address(RVA = "0x25135A8", Offset = "0x25135A8", VA = "0x25135A8")]
				set
				{
				}
			}

			[Token(Token = "0x1700010A")]
			public string Status
			{
				[Token(Token = "0x6000368")]
				[Address(RVA = "0x2513698", Offset = "0x2513698", VA = "0x2513698")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000369")]
				[Address(RVA = "0x25136A0", Offset = "0x25136A0", VA = "0x25136A0")]
				set
				{
				}
			}

			[Token(Token = "0x1700010B")]
			public LocalizedSessionInfo[] Localizations
			{
				[Token(Token = "0x600036A")]
				[Address(RVA = "0x2513784", Offset = "0x2513784", VA = "0x2513784")]
				get
				{
					return null;
				}
				[Token(Token = "0x600036B")]
				[Address(RVA = "0x25137F8", Offset = "0x25137F8", VA = "0x25137F8")]
				set
				{
				}
			}

			[Token(Token = "0x1700010C")]
			public SessionImage Image
			{
				[Token(Token = "0x600036C")]
				[Address(RVA = "0x25138E8", Offset = "0x25138E8", VA = "0x25138E8")]
				get
				{
					return default(SessionImage);
				}
				[Token(Token = "0x600036D")]
				[Address(RVA = "0x25138F0", Offset = "0x25138F0", VA = "0x25138F0")]
				set
				{
				}
			}

			[Token(Token = "0x1700010D")]
			public bool DisplayOnSystem
			{
				[Token(Token = "0x600036E")]
				[Address(RVA = "0x25138F8", Offset = "0x25138F8", VA = "0x25138F8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600036F")]
				[Address(RVA = "0x2513900", Offset = "0x2513900", VA = "0x2513900")]
				set
				{
				}
			}

			[Token(Token = "0x1700010E")]
			public bool IsSystemJoinable
			{
				[Token(Token = "0x6000370")]
				[Address(RVA = "0x251390C", Offset = "0x251390C", VA = "0x251390C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000371")]
				[Address(RVA = "0x2513914", Offset = "0x2513914", VA = "0x2513914")]
				set
				{
				}
			}

			[Token(Token = "0x1700010F")]
			public bool JoinAllLocalUsers
			{
				[Token(Token = "0x6000372")]
				[Address(RVA = "0x2513920", Offset = "0x2513920", VA = "0x2513920")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000373")]
				[Address(RVA = "0x2513928", Offset = "0x2513928", VA = "0x2513928")]
				set
				{
				}
			}

			[Token(Token = "0x17000110")]
			public bool IsNatRestricted
			{
				[Token(Token = "0x6000374")]
				[Address(RVA = "0x2513934", Offset = "0x2513934", VA = "0x2513934")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000375")]
				[Address(RVA = "0x251393C", Offset = "0x251393C", VA = "0x251393C")]
				set
				{
				}
			}

			[Token(Token = "0x17000111")]
			public RoomMigrationType OwnershipMigration
			{
				[Token(Token = "0x6000376")]
				[Address(RVA = "0x2513948", Offset = "0x2513948", VA = "0x2513948")]
				get
				{
					return default(RoomMigrationType);
				}
				[Token(Token = "0x6000377")]
				[Address(RVA = "0x2513950", Offset = "0x2513950", VA = "0x2513950")]
				set
				{
				}
			}

			[Token(Token = "0x17000112")]
			public TopologyType Topology
			{
				[Token(Token = "0x6000378")]
				[Address(RVA = "0x2513958", Offset = "0x2513958", VA = "0x2513958")]
				get
				{
					return default(TopologyType);
				}
				[Token(Token = "0x6000379")]
				[Address(RVA = "0x2513960", Offset = "0x2513960", VA = "0x2513960")]
				set
				{
				}
			}

			[Token(Token = "0x17000113")]
			public uint MaxNumMembers
			{
				[Token(Token = "0x600037A")]
				[Address(RVA = "0x2513968", Offset = "0x2513968", VA = "0x2513968")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x600037B")]
				[Address(RVA = "0x2513970", Offset = "0x2513970", VA = "0x2513970")]
				set
				{
				}
			}

			[Token(Token = "0x17000114")]
			public NpMatching2WorldNumber WorldNumber
			{
				[Token(Token = "0x600037C")]
				[Address(RVA = "0x2513978", Offset = "0x2513978", VA = "0x2513978")]
				get
				{
					return default(NpMatching2WorldNumber);
				}
				[Token(Token = "0x600037D")]
				[Address(RVA = "0x2513980", Offset = "0x2513980", VA = "0x2513980")]
				set
				{
				}
			}

			[Token(Token = "0x17000115")]
			public bool IsCrossplatform
			{
				[Token(Token = "0x600037E")]
				[Address(RVA = "0x2513988", Offset = "0x2513988", VA = "0x2513988")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600037F")]
				[Address(RVA = "0x2513990", Offset = "0x2513990", VA = "0x2513990")]
				set
				{
				}
			}

			[Token(Token = "0x17000116")]
			public bool AllowBlockedUsersOfOwner
			{
				[Token(Token = "0x6000380")]
				[Address(RVA = "0x251399C", Offset = "0x251399C", VA = "0x251399C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000381")]
				[Address(RVA = "0x25139A4", Offset = "0x25139A4", VA = "0x25139A4")]
				set
				{
				}
			}

			[Token(Token = "0x17000117")]
			public bool AllowBlockedUsersOfMembers
			{
				[Token(Token = "0x6000382")]
				[Address(RVA = "0x25139B0", Offset = "0x25139B0", VA = "0x25139B0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000383")]
				[Address(RVA = "0x25139B8", Offset = "0x25139B8", VA = "0x25139B8")]
				set
				{
				}
			}

			[Token(Token = "0x6000384")]
			[Address(RVA = "0x25139C4", Offset = "0x25139C4", VA = "0x25139C4")]
			public CreateRoomRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x20000B8")]
		public class LeaveRoomRequest : RequestBase
		{
			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ulong roomId;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal PresenceOptionData notificationDataToMembers;

			[Token(Token = "0x17000118")]
			public ulong RoomId
			{
				[Token(Token = "0x6000385")]
				[Address(RVA = "0x2514674", Offset = "0x2514674", VA = "0x2514674")]
				get
				{
					return default(ulong);
				}
				[Token(Token = "0x6000386")]
				[Address(RVA = "0x251467C", Offset = "0x251467C", VA = "0x251467C")]
				set
				{
				}
			}

			[Token(Token = "0x17000119")]
			public PresenceOptionData NotificationDataToMembers
			{
				[Token(Token = "0x6000387")]
				[Address(RVA = "0x2514684", Offset = "0x2514684", VA = "0x2514684")]
				get
				{
					return default(PresenceOptionData);
				}
				[Token(Token = "0x6000388")]
				[Address(RVA = "0x2514690", Offset = "0x2514690", VA = "0x2514690")]
				set
				{
				}
			}

			[Token(Token = "0x6000389")]
			[Address(RVA = "0x2514698", Offset = "0x2514698", VA = "0x2514698")]
			public LeaveRoomRequest()
			{
			}
		}

		[Token(Token = "0x20000B9")]
		public enum RoomsSearchScope
		{
			[Token(Token = "0x400066C")]
			All,
			[Token(Token = "0x400066D")]
			FriendsRooms,
			[Token(Token = "0x400066E")]
			RecentlyMetRooms,
			[Token(Token = "0x400066F")]
			CustomUsersList
		}

		[StructLayout(0)]
		[Token(Token = "0x20000BA")]
		public class SearchRoomsRequest : RequestBase
		{
			[Token(Token = "0x4000670")]
			public const int MAX_SEARCH_CLAUSES = 64;

			[Token(Token = "0x4000671")]
			public const int MAX_PAGE_SIZE = 20;

			[Token(Token = "0x4000672")]
			public const int MIN_OFFSET = 1;

			[Token(Token = "0x4000673")]
			public const int MAX_NUM_USERS_TO_SEARCH_IN_ROOMS = 20;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ulong numSearchClauses;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal SearchClause[] searchClauses;

			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal ulong numUsersToSearchInRooms;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal Core.NpAccountId[] usersToSearchInRooms;

			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal int offset;

			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			internal int pageSize;

			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal RoomsSearchScope searchScope;

			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			internal NpMatching2WorldNumber worldNumber;

			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
			internal bool provideRandomRooms;

			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x57")]
			internal bool quickJoin;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal bool applyNatTypeFilter;

			[Token(Token = "0x1700011A")]
			public SearchClause[] SearchClauses
			{
				[Token(Token = "0x600038A")]
				[Address(RVA = "0x2516B18", Offset = "0x2516B18", VA = "0x2516B18")]
				get
				{
					return null;
				}
				[Token(Token = "0x600038B")]
				[Address(RVA = "0x2516BB0", Offset = "0x2516BB0", VA = "0x2516BB0")]
				set
				{
				}
			}

			[Token(Token = "0x1700011B")]
			public Core.NpAccountId[] UsersToSearchInRooms
			{
				[Token(Token = "0x600038C")]
				[Address(RVA = "0x2516CA4", Offset = "0x2516CA4", VA = "0x2516CA4")]
				get
				{
					return null;
				}
				[Token(Token = "0x600038D")]
				[Address(RVA = "0x2516D3C", Offset = "0x2516D3C", VA = "0x2516D3C")]
				set
				{
				}
			}

			[Token(Token = "0x1700011C")]
			public int Offset
			{
				[Token(Token = "0x600038E")]
				[Address(RVA = "0x2516E30", Offset = "0x2516E30", VA = "0x2516E30")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600038F")]
				[Address(RVA = "0x2516E38", Offset = "0x2516E38", VA = "0x2516E38")]
				set
				{
				}
			}

			[Token(Token = "0x1700011D")]
			public int PageSize
			{
				[Token(Token = "0x6000390")]
				[Address(RVA = "0x2516E40", Offset = "0x2516E40", VA = "0x2516E40")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000391")]
				[Address(RVA = "0x2516E48", Offset = "0x2516E48", VA = "0x2516E48")]
				set
				{
				}
			}

			[Token(Token = "0x1700011E")]
			public RoomsSearchScope SearchScope
			{
				[Token(Token = "0x6000392")]
				[Address(RVA = "0x2516E50", Offset = "0x2516E50", VA = "0x2516E50")]
				get
				{
					return default(RoomsSearchScope);
				}
				[Token(Token = "0x6000393")]
				[Address(RVA = "0x2516E58", Offset = "0x2516E58", VA = "0x2516E58")]
				set
				{
				}
			}

			[Token(Token = "0x1700011F")]
			public NpMatching2WorldNumber WorldNumber
			{
				[Token(Token = "0x6000394")]
				[Address(RVA = "0x2516E60", Offset = "0x2516E60", VA = "0x2516E60")]
				get
				{
					return default(NpMatching2WorldNumber);
				}
				[Token(Token = "0x6000395")]
				[Address(RVA = "0x2516E68", Offset = "0x2516E68", VA = "0x2516E68")]
				set
				{
				}
			}

			[Token(Token = "0x17000120")]
			public bool ProvideRandomRooms
			{
				[Token(Token = "0x6000396")]
				[Address(RVA = "0x2516E70", Offset = "0x2516E70", VA = "0x2516E70")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000397")]
				[Address(RVA = "0x2516E78", Offset = "0x2516E78", VA = "0x2516E78")]
				set
				{
				}
			}

			[Token(Token = "0x17000121")]
			public bool QuickJoin
			{
				[Token(Token = "0x6000398")]
				[Address(RVA = "0x2516E84", Offset = "0x2516E84", VA = "0x2516E84")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000399")]
				[Address(RVA = "0x2516E8C", Offset = "0x2516E8C", VA = "0x2516E8C")]
				set
				{
				}
			}

			[Token(Token = "0x17000122")]
			public bool ApplyNatTypeFilter
			{
				[Token(Token = "0x600039A")]
				[Address(RVA = "0x2516E98", Offset = "0x2516E98", VA = "0x2516E98")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600039B")]
				[Address(RVA = "0x2516EA0", Offset = "0x2516EA0", VA = "0x2516EA0")]
				set
				{
				}
			}

			[Token(Token = "0x600039C")]
			[Address(RVA = "0x2516EAC", Offset = "0x2516EAC", VA = "0x2516EAC")]
			public SearchRoomsRequest()
			{
			}
		}

		[Token(Token = "0x20000BB")]
		public enum RoomJoiningType
		{
			[Token(Token = "0x4000680")]
			Room,
			[Token(Token = "0x4000681")]
			BoundSessionId
		}

		[StructLayout(0)]
		[Token(Token = "0x20000BC")]
		public class JoinRoomRequest : RequestBase
		{
			[Token(Token = "0x4000682")]
			public const int MAX_ATTRIBUTES = 64;

			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal NpMatching2SessionPassword password;

			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal ulong numMemberAttributes;

			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal Attribute[] memberAttributes;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal PresenceOptionData notificationDataToMembers;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal ulong roomId;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal NpSessionId boundSessionId;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal RoomJoiningType identifyRoomBy;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			internal bool joinAllLocalUsers;

			[Token(Token = "0x400068B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
			internal bool allowBlockedUsers;

			[Token(Token = "0x17000123")]
			public NpMatching2SessionPassword Password
			{
				[Token(Token = "0x600039D")]
				[Address(RVA = "0x25141C8", Offset = "0x25141C8", VA = "0x25141C8")]
				get
				{
					return default(NpMatching2SessionPassword);
				}
				[Token(Token = "0x600039E")]
				[Address(RVA = "0x25141D0", Offset = "0x25141D0", VA = "0x25141D0")]
				set
				{
				}
			}

			[Token(Token = "0x17000124")]
			public Attribute[] MemberAttributes
			{
				[Token(Token = "0x600039F")]
				[Address(RVA = "0x25141D8", Offset = "0x25141D8", VA = "0x25141D8")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003A0")]
				[Address(RVA = "0x2514270", Offset = "0x2514270", VA = "0x2514270")]
				set
				{
				}
			}

			[Token(Token = "0x17000125")]
			public PresenceOptionData NotificationDataToMembers
			{
				[Token(Token = "0x60003A1")]
				[Address(RVA = "0x2514364", Offset = "0x2514364", VA = "0x2514364")]
				get
				{
					return default(PresenceOptionData);
				}
				[Token(Token = "0x60003A2")]
				[Address(RVA = "0x2514370", Offset = "0x2514370", VA = "0x2514370")]
				set
				{
				}
			}

			[Token(Token = "0x17000126")]
			public ulong RoomId
			{
				[Token(Token = "0x60003A3")]
				[Address(RVA = "0x2514378", Offset = "0x2514378", VA = "0x2514378")]
				get
				{
					return default(ulong);
				}
				[Token(Token = "0x60003A4")]
				[Address(RVA = "0x2514380", Offset = "0x2514380", VA = "0x2514380")]
				set
				{
				}
			}

			[Token(Token = "0x17000127")]
			public NpSessionId BoundSessionId
			{
				[Token(Token = "0x60003A5")]
				[Address(RVA = "0x2514414", Offset = "0x2514414", VA = "0x2514414")]
				get
				{
					return default(NpSessionId);
				}
				[Token(Token = "0x60003A6")]
				[Address(RVA = "0x251441C", Offset = "0x251441C", VA = "0x251441C")]
				set
				{
				}
			}

			[Token(Token = "0x17000128")]
			public RoomJoiningType IdentifyRoomBy
			{
				[Token(Token = "0x60003A7")]
				[Address(RVA = "0x25144B4", Offset = "0x25144B4", VA = "0x25144B4")]
				get
				{
					return default(RoomJoiningType);
				}
				[Token(Token = "0x60003A8")]
				[Address(RVA = "0x25144BC", Offset = "0x25144BC", VA = "0x25144BC")]
				set
				{
				}
			}

			[Token(Token = "0x17000129")]
			public bool JoinAllLocalUsers
			{
				[Token(Token = "0x60003A9")]
				[Address(RVA = "0x25144C4", Offset = "0x25144C4", VA = "0x25144C4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60003AA")]
				[Address(RVA = "0x25144CC", Offset = "0x25144CC", VA = "0x25144CC")]
				set
				{
				}
			}

			[Token(Token = "0x1700012A")]
			public bool AllowBlockedUsers
			{
				[Token(Token = "0x60003AB")]
				[Address(RVA = "0x25144D8", Offset = "0x25144D8", VA = "0x25144D8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60003AC")]
				[Address(RVA = "0x25144E0", Offset = "0x25144E0", VA = "0x25144E0")]
				set
				{
				}
			}

			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x25144EC", Offset = "0x25144EC", VA = "0x25144EC")]
			public JoinRoomRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x20000BD")]
		public class GetRoomPingTimeRequest : RequestBase
		{
			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ulong roomId;

			[Token(Token = "0x1700012B")]
			public ulong RoomId
			{
				[Token(Token = "0x60003AE")]
				[Address(RVA = "0x2513E60", Offset = "0x2513E60", VA = "0x2513E60")]
				get
				{
					return default(ulong);
				}
				[Token(Token = "0x60003AF")]
				[Address(RVA = "0x2513E68", Offset = "0x2513E68", VA = "0x2513E68")]
				set
				{
				}
			}

			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x2513E70", Offset = "0x2513E70", VA = "0x2513E70")]
			public GetRoomPingTimeRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x20000BE")]
		public class KickOutRoomMemberRequest : RequestBase
		{
			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ulong roomId;

			[Token(Token = "0x400068E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal PresenceOptionData notificationDataToMembers;

			[Token(Token = "0x400068F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal ushort memberId;

			[Token(Token = "0x4000690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
			internal bool allowRejoin;

			[Token(Token = "0x1700012C")]
			public ulong RoomId
			{
				[Token(Token = "0x60003B1")]
				[Address(RVA = "0x25145BC", Offset = "0x25145BC", VA = "0x25145BC")]
				get
				{
					return default(ulong);
				}
				[Token(Token = "0x60003B2")]
				[Address(RVA = "0x25145C4", Offset = "0x25145C4", VA = "0x25145C4")]
				set
				{
				}
			}

			[Token(Token = "0x1700012D")]
			public PresenceOptionData NotificationDataToMembers
			{
				[Token(Token = "0x60003B3")]
				[Address(RVA = "0x25145CC", Offset = "0x25145CC", VA = "0x25145CC")]
				get
				{
					return default(PresenceOptionData);
				}
				[Token(Token = "0x60003B4")]
				[Address(RVA = "0x25145D8", Offset = "0x25145D8", VA = "0x25145D8")]
				set
				{
				}
			}

			[Token(Token = "0x1700012E")]
			public ushort MemberId
			{
				[Token(Token = "0x60003B5")]
				[Address(RVA = "0x2514620", Offset = "0x2514620", VA = "0x2514620")]
				get
				{
					return default(ushort);
				}
				[Token(Token = "0x60003B6")]
				[Address(RVA = "0x2514628", Offset = "0x2514628", VA = "0x2514628")]
				set
				{
				}
			}

			[Token(Token = "0x1700012F")]
			public bool AllowRejoin
			{
				[Token(Token = "0x60003B7")]
				[Address(RVA = "0x2514630", Offset = "0x2514630", VA = "0x2514630")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60003B8")]
				[Address(RVA = "0x2514638", Offset = "0x2514638", VA = "0x2514638")]
				set
				{
				}
			}

			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x2514644", Offset = "0x2514644", VA = "0x2514644")]
			public KickOutRoomMemberRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x20000BF")]
		public class SendRoomMessageRequest : RequestBase
		{
			[Token(Token = "0x4000691")]
			public const int MESSAGE_MAX_SIZE = 1023;

			[Token(Token = "0x4000692")]
			public const int MAX_MEMBERS = 32;

			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ulong roomId;

			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal ulong numMembers;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal ushort[] members;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal ulong dataSize;

			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal byte[] data;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal bool isChatMsg;

			[Token(Token = "0x17000130")]
			public ulong RoomId
			{
				[Token(Token = "0x60003BA")]
				[Address(RVA = "0x2517358", Offset = "0x2517358", VA = "0x2517358")]
				get
				{
					return default(ulong);
				}
				[Token(Token = "0x60003BB")]
				[Address(RVA = "0x2517360", Offset = "0x2517360", VA = "0x2517360")]
				set
				{
				}
			}

			[Token(Token = "0x17000131")]
			public ushort[] Members
			{
				[Token(Token = "0x60003BC")]
				[Address(RVA = "0x2517368", Offset = "0x2517368", VA = "0x2517368")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003BD")]
				[Address(RVA = "0x2517400", Offset = "0x2517400", VA = "0x2517400")]
				set
				{
				}
			}

			[Token(Token = "0x17000132")]
			public byte[] Data
			{
				[Token(Token = "0x60003BE")]
				[Address(RVA = "0x25174F4", Offset = "0x25174F4", VA = "0x25174F4")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003BF")]
				[Address(RVA = "0x251758C", Offset = "0x251758C", VA = "0x251758C")]
				set
				{
				}
			}

			[Token(Token = "0x17000133")]
			public string DataAsString
			{
				[Token(Token = "0x60003C0")]
				[Address(RVA = "0x25176A4", Offset = "0x25176A4", VA = "0x25176A4")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003C1")]
				[Address(RVA = "0x251772C", Offset = "0x251772C", VA = "0x251772C")]
				set
				{
				}
			}

			[Token(Token = "0x17000134")]
			public bool IsChatMsg
			{
				[Token(Token = "0x60003C2")]
				[Address(RVA = "0x25178A0", Offset = "0x25178A0", VA = "0x25178A0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60003C3")]
				[Address(RVA = "0x25178A8", Offset = "0x25178A8", VA = "0x25178A8")]
				set
				{
				}
			}

			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x25178B4", Offset = "0x25178B4", VA = "0x25178B4")]
			public SendRoomMessageRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x20000C0")]
		public class GetAttributesRequest : RequestBase
		{
			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ulong roomId;

			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal AttributeScope scope;

			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal RoomAttributeVisibility roomAttributeVisibility;

			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal ushort memberId;

			[Token(Token = "0x17000135")]
			public ulong RoomId
			{
				[Token(Token = "0x60003C5")]
				[Address(RVA = "0x2513A70", Offset = "0x2513A70", VA = "0x2513A70")]
				get
				{
					return default(ulong);
				}
				[Token(Token = "0x60003C6")]
				[Address(RVA = "0x2513A78", Offset = "0x2513A78", VA = "0x2513A78")]
				set
				{
				}
			}

			[Token(Token = "0x17000136")]
			public AttributeScope Scope
			{
				[Token(Token = "0x60003C7")]
				[Address(RVA = "0x2513A80", Offset = "0x2513A80", VA = "0x2513A80")]
				get
				{
					return default(AttributeScope);
				}
			}

			[Token(Token = "0x17000137")]
			public RoomAttributeVisibility RoomAttributeVisibility
			{
				[Token(Token = "0x60003C8")]
				[Address(RVA = "0x2513A88", Offset = "0x2513A88", VA = "0x2513A88")]
				get
				{
					return default(RoomAttributeVisibility);
				}
				[Token(Token = "0x60003C9")]
				[Address(RVA = "0x2513A90", Offset = "0x2513A90", VA = "0x2513A90")]
				set
				{
				}
			}

			[Token(Token = "0x17000138")]
			public ushort MemberId
			{
				[Token(Token = "0x60003CA")]
				[Address(RVA = "0x2513A9C", Offset = "0x2513A9C", VA = "0x2513A9C")]
				get
				{
					return default(ushort);
				}
				[Token(Token = "0x60003CB")]
				[Address(RVA = "0x2513AA4", Offset = "0x2513AA4", VA = "0x2513AA4")]
				set
				{
				}
			}

			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x2513AB4", Offset = "0x2513AB4", VA = "0x2513AB4")]
			public GetAttributesRequest()
			{
			}
		}

		[Token(Token = "0x20000C1")]
		public enum DataType
		{
			[Token(Token = "0x400069E")]
			Fixed,
			[Token(Token = "0x400069F")]
			Changeable
		}

		[StructLayout(0)]
		[Token(Token = "0x20000C2")]
		public class GetDataRequest : RequestBase
		{
			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ulong roomId;

			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal DataType type;

			[Token(Token = "0x17000139")]
			public ulong RoomId
			{
				[Token(Token = "0x60003CD")]
				[Address(RVA = "0x2513AC4", Offset = "0x2513AC4", VA = "0x2513AC4")]
				get
				{
					return default(ulong);
				}
				[Token(Token = "0x60003CE")]
				[Address(RVA = "0x2513ACC", Offset = "0x2513ACC", VA = "0x2513ACC")]
				set
				{
				}
			}

			[Token(Token = "0x1700013A")]
			public DataType Type
			{
				[Token(Token = "0x60003CF")]
				[Address(RVA = "0x2513AD4", Offset = "0x2513AD4", VA = "0x2513AD4")]
				get
				{
					return default(DataType);
				}
				[Token(Token = "0x60003D0")]
				[Address(RVA = "0x2513ADC", Offset = "0x2513ADC", VA = "0x2513ADC")]
				set
				{
				}
			}

			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x2513AE4", Offset = "0x2513AE4", VA = "0x2513AE4")]
			public GetDataRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x20000C3")]
		public class SetMembersAsRecentlyMetRequest : RequestBase
		{
			[Token(Token = "0x40006A2")]
			public const int NUM_RECENTLY_MET_MAX_LEN = 19;

			[Token(Token = "0x40006A3")]
			public const int TEXT_MAX_LEN = 2083;

			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ulong numMembers;

			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal ushort[] members;

			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal ulong roomId;

			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal string text;

			[Token(Token = "0x1700013B")]
			public ushort[] Members
			{
				[Token(Token = "0x60003D2")]
				[Address(RVA = "0x2518258", Offset = "0x2518258", VA = "0x2518258")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003D3")]
				[Address(RVA = "0x25182F0", Offset = "0x25182F0", VA = "0x25182F0")]
				set
				{
				}
			}

			[Token(Token = "0x1700013C")]
			public ulong RoomId
			{
				[Token(Token = "0x60003D4")]
				[Address(RVA = "0x25183E4", Offset = "0x25183E4", VA = "0x25183E4")]
				get
				{
					return default(ulong);
				}
				[Token(Token = "0x60003D5")]
				[Address(RVA = "0x25183EC", Offset = "0x25183EC", VA = "0x25183EC")]
				set
				{
				}
			}

			[Token(Token = "0x1700013D")]
			public string Text
			{
				[Token(Token = "0x60003D6")]
				[Address(RVA = "0x25183F4", Offset = "0x25183F4", VA = "0x25183F4")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003D7")]
				[Address(RVA = "0x25183FC", Offset = "0x25183FC", VA = "0x25183FC")]
				set
				{
				}
			}

			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x25184E0", Offset = "0x25184E0", VA = "0x25184E0")]
			public SetMembersAsRecentlyMetRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x20000C4")]
		public class SendInvitationRequest : RequestBase
		{
			[Token(Token = "0x40006A8")]
			public const int MAX_SIZE_ATTACHMENT = 1048576;

			[Token(Token = "0x40006A9")]
			public const int MAX_NUM_RECIPIENTS = 16;

			[Token(Token = "0x40006AA")]
			public const int MAX_SIZE_USER_MESSAGE = 511;

			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ulong roomId;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal ulong numRecipients;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal Core.NpAccountId[] recipients;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal string userMessage;

			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal ulong attachmentSize;

			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal byte[] attachment;

			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal int maxNumberRecipientsToAdd;

			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			internal bool recipientsEditableByUser;

			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
			internal bool enableDialog;

			[Token(Token = "0x1700013E")]
			public ulong RoomId
			{
				[Token(Token = "0x60003D9")]
				[Address(RVA = "0x2516F48", Offset = "0x2516F48", VA = "0x2516F48")]
				get
				{
					return default(ulong);
				}
				[Token(Token = "0x60003DA")]
				[Address(RVA = "0x2516F50", Offset = "0x2516F50", VA = "0x2516F50")]
				set
				{
				}
			}

			[Token(Token = "0x1700013F")]
			public Core.NpAccountId[] Recipients
			{
				[Token(Token = "0x60003DB")]
				[Address(RVA = "0x2516F58", Offset = "0x2516F58", VA = "0x2516F58")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003DC")]
				[Address(RVA = "0x2516FF0", Offset = "0x2516FF0", VA = "0x2516FF0")]
				set
				{
				}
			}

			[Token(Token = "0x17000140")]
			public string UserMessage
			{
				[Token(Token = "0x60003DD")]
				[Address(RVA = "0x25170E4", Offset = "0x25170E4", VA = "0x25170E4")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003DE")]
				[Address(RVA = "0x25170EC", Offset = "0x25170EC", VA = "0x25170EC")]
				set
				{
				}
			}

			[Token(Token = "0x17000141")]
			public byte[] Attachment
			{
				[Token(Token = "0x60003DF")]
				[Address(RVA = "0x25171D0", Offset = "0x25171D0", VA = "0x25171D0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003E0")]
				[Address(RVA = "0x25171D8", Offset = "0x25171D8", VA = "0x25171D8")]
				set
				{
				}
			}

			[Token(Token = "0x17000142")]
			public int MaxNumberRecipientsToAdd
			{
				[Token(Token = "0x60003E1")]
				[Address(RVA = "0x25172B8", Offset = "0x25172B8", VA = "0x25172B8")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60003E2")]
				[Address(RVA = "0x25172C0", Offset = "0x25172C0", VA = "0x25172C0")]
				set
				{
				}
			}

			[Token(Token = "0x17000143")]
			public bool RecipientsEditableByUser
			{
				[Token(Token = "0x60003E3")]
				[Address(RVA = "0x25172C8", Offset = "0x25172C8", VA = "0x25172C8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60003E4")]
				[Address(RVA = "0x25172D0", Offset = "0x25172D0", VA = "0x25172D0")]
				set
				{
				}
			}

			[Token(Token = "0x17000144")]
			public bool EnableDialog
			{
				[Token(Token = "0x60003E5")]
				[Address(RVA = "0x25172DC", Offset = "0x25172DC", VA = "0x25172DC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60003E6")]
				[Address(RVA = "0x25172E4", Offset = "0x25172E4", VA = "0x25172E4")]
				set
				{
				}
			}

			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x25172F0", Offset = "0x25172F0", VA = "0x25172F0")]
			public SendInvitationRequest()
			{
			}
		}

		[Token(Token = "0x20000C5")]
		public enum SetRoomInfoType
		{
			[Token(Token = "0x40006B5")]
			Invalid,
			[Token(Token = "0x40006B6")]
			MemberInfo,
			[Token(Token = "0x40006B7")]
			RoomExternalInfo,
			[Token(Token = "0x40006B8")]
			RoomInternalInfo,
			[Token(Token = "0x40006B9")]
			RoomSessionInfo,
			[Token(Token = "0x40006BA")]
			RoomTopology
		}

		[StructLayout(0)]
		[Token(Token = "0x20000C6")]
		public class SetRoomInfoRequest : RequestBase
		{
			[Token(Token = "0x2000170")]
			public struct MemberInformation
			{
				[Token(Token = "0x4000973")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				internal ulong numMemberAttributes;

				[Token(Token = "0x4000974")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				internal Attribute[] memberAttributes;

				[Token(Token = "0x4000975")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				internal ushort memberId;

				[Token(Token = "0x1700034B")]
				public Attribute[] MemberAttributes
				{
					[Token(Token = "0x6000772")]
					[Address(RVA = "0x2518D48", Offset = "0x2518D48", VA = "0x2518D48")]
					get
					{
						return null;
					}
					[Token(Token = "0x6000773")]
					[Address(RVA = "0x2518DE0", Offset = "0x2518DE0", VA = "0x2518DE0")]
					set
					{
					}
				}

				[Token(Token = "0x1700034C")]
				public ushort MemberId
				{
					[Token(Token = "0x6000774")]
					[Address(RVA = "0x2518EF8", Offset = "0x2518EF8", VA = "0x2518EF8")]
					get
					{
						return default(ushort);
					}
					[Token(Token = "0x6000775")]
					[Address(RVA = "0x2518F00", Offset = "0x2518F00", VA = "0x2518F00")]
					set
					{
					}
				}

				[Token(Token = "0x6000771")]
				[Address(RVA = "0x2518668", Offset = "0x2518668", VA = "0x2518668")]
				internal void Init()
				{
				}
			}

			[Token(Token = "0x2000171")]
			public struct ExternalRoomInformation
			{
				[Token(Token = "0x4000976")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				internal ulong numExternalAttributes;

				[Token(Token = "0x4000977")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				internal Attribute[] externalAttributes;

				[Token(Token = "0x4000978")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				internal ulong numSearchAttributes;

				[Token(Token = "0x4000979")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				internal Attribute[] searchAttributes;

				[Token(Token = "0x1700034D")]
				public Attribute[] ExternalAttributes
				{
					[Token(Token = "0x6000777")]
					[Address(RVA = "0x25187D8", Offset = "0x25187D8", VA = "0x25187D8")]
					get
					{
						return null;
					}
					[Token(Token = "0x6000778")]
					[Address(RVA = "0x2518870", Offset = "0x2518870", VA = "0x2518870")]
					set
					{
					}
				}

				[Token(Token = "0x1700034E")]
				public Attribute[] SearchAttributes
				{
					[Token(Token = "0x6000779")]
					[Address(RVA = "0x2518988", Offset = "0x2518988", VA = "0x2518988")]
					get
					{
						return null;
					}
					[Token(Token = "0x600077A")]
					[Address(RVA = "0x2518A20", Offset = "0x2518A20", VA = "0x2518A20")]
					set
					{
					}
				}

				[Token(Token = "0x6000776")]
				[Address(RVA = "0x25186C0", Offset = "0x25186C0", VA = "0x25186C0")]
				internal void Init()
				{
				}
			}

			[Token(Token = "0x2000172")]
			public struct InternalRoomInformation
			{
				[Token(Token = "0x400097A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				internal ulong numInternalAttributes;

				[Token(Token = "0x400097B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				internal Attribute[] internalAttributes;

				[Token(Token = "0x400097C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				internal Core.OptionalBoolean allowBlockedUsersOfMembers;

				[Token(Token = "0x400097D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				internal Core.OptionalBoolean joinAllLocalUsers;

				[Token(Token = "0x400097E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				internal Core.OptionalBoolean isNatRestricted;

				[Token(Token = "0x400097F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				internal uint numReservedSlots;

				[Token(Token = "0x4000980")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				internal RoomVisibility visibility;

				[Token(Token = "0x4000981")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				internal Core.OptionalBoolean closeRoom;

				[Token(Token = "0x1700034F")]
				public Attribute[] InternalAttributes
				{
					[Token(Token = "0x600077C")]
					[Address(RVA = "0x2518B38", Offset = "0x2518B38", VA = "0x2518B38")]
					get
					{
						return null;
					}
					[Token(Token = "0x600077D")]
					[Address(RVA = "0x2518BD0", Offset = "0x2518BD0", VA = "0x2518BD0")]
					set
					{
					}
				}

				[Token(Token = "0x17000350")]
				public Core.OptionalBoolean AllowBlockedUsersOfMembers
				{
					[Token(Token = "0x600077E")]
					[Address(RVA = "0x2518CE8", Offset = "0x2518CE8", VA = "0x2518CE8")]
					get
					{
						return default(Core.OptionalBoolean);
					}
					[Token(Token = "0x600077F")]
					[Address(RVA = "0x2518CF0", Offset = "0x2518CF0", VA = "0x2518CF0")]
					set
					{
					}
				}

				[Token(Token = "0x17000351")]
				public Core.OptionalBoolean JoinAllLocalUsers
				{
					[Token(Token = "0x6000780")]
					[Address(RVA = "0x2518CF8", Offset = "0x2518CF8", VA = "0x2518CF8")]
					get
					{
						return default(Core.OptionalBoolean);
					}
					[Token(Token = "0x6000781")]
					[Address(RVA = "0x2518D00", Offset = "0x2518D00", VA = "0x2518D00")]
					set
					{
					}
				}

				[Token(Token = "0x17000352")]
				public Core.OptionalBoolean IsNatRestricted
				{
					[Token(Token = "0x6000782")]
					[Address(RVA = "0x2518D08", Offset = "0x2518D08", VA = "0x2518D08")]
					get
					{
						return default(Core.OptionalBoolean);
					}
					[Token(Token = "0x6000783")]
					[Address(RVA = "0x2518D10", Offset = "0x2518D10", VA = "0x2518D10")]
					set
					{
					}
				}

				[Token(Token = "0x17000353")]
				public uint NumReservedSlots
				{
					[Token(Token = "0x6000784")]
					[Address(RVA = "0x2518D18", Offset = "0x2518D18", VA = "0x2518D18")]
					get
					{
						return default(uint);
					}
					[Token(Token = "0x6000785")]
					[Address(RVA = "0x2518D20", Offset = "0x2518D20", VA = "0x2518D20")]
					set
					{
					}
				}

				[Token(Token = "0x17000354")]
				public RoomVisibility Visibility
				{
					[Token(Token = "0x6000786")]
					[Address(RVA = "0x2518D28", Offset = "0x2518D28", VA = "0x2518D28")]
					get
					{
						return default(RoomVisibility);
					}
					[Token(Token = "0x6000787")]
					[Address(RVA = "0x2518D30", Offset = "0x2518D30", VA = "0x2518D30")]
					set
					{
					}
				}

				[Token(Token = "0x17000355")]
				public Core.OptionalBoolean CloseRoom
				{
					[Token(Token = "0x6000788")]
					[Address(RVA = "0x2518D38", Offset = "0x2518D38", VA = "0x2518D38")]
					get
					{
						return default(Core.OptionalBoolean);
					}
					[Token(Token = "0x6000789")]
					[Address(RVA = "0x2518D40", Offset = "0x2518D40", VA = "0x2518D40")]
					set
					{
					}
				}

				[Token(Token = "0x600077B")]
				[Address(RVA = "0x2518728", Offset = "0x2518728", VA = "0x2518728")]
				internal void Init()
				{
				}
			}

			[Token(Token = "0x2000173")]
			public struct RoomSessionInformation
			{
				[Token(Token = "0x4000982")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				internal Core.OptionalBoolean displayOnSystem;

				[Token(Token = "0x4000983")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				internal Core.OptionalBoolean isSystemJoinable;

				[Token(Token = "0x4000984")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				internal ulong changeableDataSize;

				[Token(Token = "0x4000985")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				internal byte[] changeableData;

				[Token(Token = "0x4000986")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				internal string status;

				[Token(Token = "0x4000987")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				internal ulong numLocalizations;

				[Token(Token = "0x4000988")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				internal LocalizedSessionInfo[] localizations;

				[Token(Token = "0x4000989")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				internal SessionImage image;

				[Token(Token = "0x17000356")]
				public Core.OptionalBoolean DisplayOnSystem
				{
					[Token(Token = "0x600078B")]
					[Address(RVA = "0x2518F08", Offset = "0x2518F08", VA = "0x2518F08")]
					get
					{
						return default(Core.OptionalBoolean);
					}
					[Token(Token = "0x600078C")]
					[Address(RVA = "0x2518F10", Offset = "0x2518F10", VA = "0x2518F10")]
					set
					{
					}
				}

				[Token(Token = "0x17000357")]
				public Core.OptionalBoolean IsSystemJoinable
				{
					[Token(Token = "0x600078D")]
					[Address(RVA = "0x2518F18", Offset = "0x2518F18", VA = "0x2518F18")]
					get
					{
						return default(Core.OptionalBoolean);
					}
					[Token(Token = "0x600078E")]
					[Address(RVA = "0x2518F20", Offset = "0x2518F20", VA = "0x2518F20")]
					set
					{
					}
				}

				[Token(Token = "0x17000358")]
				public byte[] ChangeableData
				{
					[Token(Token = "0x600078F")]
					[Address(RVA = "0x2518F28", Offset = "0x2518F28", VA = "0x2518F28")]
					get
					{
						return null;
					}
					[Token(Token = "0x6000790")]
					[Address(RVA = "0x2518F30", Offset = "0x2518F30", VA = "0x2518F30")]
					set
					{
					}
				}

				[Token(Token = "0x17000359")]
				public string Status
				{
					[Token(Token = "0x6000791")]
					[Address(RVA = "0x251901C", Offset = "0x251901C", VA = "0x251901C")]
					get
					{
						return null;
					}
					[Token(Token = "0x6000792")]
					[Address(RVA = "0x2519024", Offset = "0x2519024", VA = "0x2519024")]
					set
					{
					}
				}

				[Token(Token = "0x1700035A")]
				public LocalizedSessionInfo[] Localizations
				{
					[Token(Token = "0x6000793")]
					[Address(RVA = "0x2519108", Offset = "0x2519108", VA = "0x2519108")]
					get
					{
						return null;
					}
					[Token(Token = "0x6000794")]
					[Address(RVA = "0x25191A0", Offset = "0x25191A0", VA = "0x25191A0")]
					set
					{
					}
				}

				[Token(Token = "0x1700035B")]
				public SessionImage Image
				{
					[Token(Token = "0x6000795")]
					[Address(RVA = "0x2519294", Offset = "0x2519294", VA = "0x2519294")]
					get
					{
						return default(SessionImage);
					}
					[Token(Token = "0x6000796")]
					[Address(RVA = "0x251929C", Offset = "0x251929C", VA = "0x251929C")]
					set
					{
					}
				}

				[Token(Token = "0x600078A")]
				[Address(RVA = "0x2518780", Offset = "0x2518780", VA = "0x2518780")]
				internal void Init()
				{
				}
			}

			[Token(Token = "0x40006BB")]
			public const int MAX_MEMBER_ATTRIBUTES = 8;

			[Token(Token = "0x40006BC")]
			public const int MAX_ATTRIBUTES = 64;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ulong roomId;

			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal SetRoomInfoType roomInfoType;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal MemberInformation memberInfo;

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal ExternalRoomInformation externalRoomInfo;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			internal InternalRoomInformation internalRoomInfo;

			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			internal RoomSessionInformation roomSessionInfo;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			internal TopologyType roomTopology;

			[Token(Token = "0x17000145")]
			public ulong RoomId
			{
				[Token(Token = "0x60003E8")]
				[Address(RVA = "0x2518548", Offset = "0x2518548", VA = "0x2518548")]
				get
				{
					return default(ulong);
				}
				[Token(Token = "0x60003E9")]
				[Address(RVA = "0x2518550", Offset = "0x2518550", VA = "0x2518550")]
				set
				{
				}
			}

			[Token(Token = "0x17000146")]
			public SetRoomInfoType RoomInfoType
			{
				[Token(Token = "0x60003EA")]
				[Address(RVA = "0x2518558", Offset = "0x2518558", VA = "0x2518558")]
				get
				{
					return default(SetRoomInfoType);
				}
				[Token(Token = "0x60003EB")]
				[Address(RVA = "0x2518560", Offset = "0x2518560", VA = "0x2518560")]
				set
				{
				}
			}

			[Token(Token = "0x17000147")]
			public MemberInformation MemberInfo
			{
				[Token(Token = "0x60003EC")]
				[Address(RVA = "0x2518568", Offset = "0x2518568", VA = "0x2518568")]
				get
				{
					return default(MemberInformation);
				}
				[Token(Token = "0x60003ED")]
				[Address(RVA = "0x251857C", Offset = "0x251857C", VA = "0x251857C")]
				set
				{
				}
			}

			[Token(Token = "0x17000148")]
			public ExternalRoomInformation ExternalRoomInfo
			{
				[Token(Token = "0x60003EE")]
				[Address(RVA = "0x2518590", Offset = "0x2518590", VA = "0x2518590")]
				get
				{
					return default(ExternalRoomInformation);
				}
				[Token(Token = "0x60003EF")]
				[Address(RVA = "0x251859C", Offset = "0x251859C", VA = "0x251859C")]
				set
				{
				}
			}

			[Token(Token = "0x17000149")]
			public InternalRoomInformation InternalRoomInfo
			{
				[Token(Token = "0x60003F0")]
				[Address(RVA = "0x25185A8", Offset = "0x25185A8", VA = "0x25185A8")]
				get
				{
					return default(InternalRoomInformation);
				}
				[Token(Token = "0x60003F1")]
				[Address(RVA = "0x25185BC", Offset = "0x25185BC", VA = "0x25185BC")]
				set
				{
				}
			}

			[Token(Token = "0x1700014A")]
			public RoomSessionInformation RoomSessionInfo
			{
				[Token(Token = "0x60003F2")]
				[Address(RVA = "0x25185D0", Offset = "0x25185D0", VA = "0x25185D0")]
				get
				{
					return default(RoomSessionInformation);
				}
				[Token(Token = "0x60003F3")]
				[Address(RVA = "0x25185F0", Offset = "0x25185F0", VA = "0x25185F0")]
				set
				{
				}
			}

			[Token(Token = "0x1700014B")]
			public TopologyType RoomTopology
			{
				[Token(Token = "0x60003F4")]
				[Address(RVA = "0x2518610", Offset = "0x2518610", VA = "0x2518610")]
				get
				{
					return default(TopologyType);
				}
				[Token(Token = "0x60003F5")]
				[Address(RVA = "0x2518618", Offset = "0x2518618", VA = "0x2518618")]
				set
				{
				}
			}

			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x2518620", Offset = "0x2518620", VA = "0x2518620")]
			public SetRoomInfoRequest()
			{
			}
		}

		[Token(Token = "0x20000C7")]
		public struct NpMatching2SessionPassword
		{
			[Token(Token = "0x40006C4")]
			public const int NP_MATCHING2_SESSION_PASSWORD_SIZE = 8;

			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal string password;

			[Token(Token = "0x1700014C")]
			public string Password
			{
				[Token(Token = "0x60003F7")]
				[Address(RVA = "0x2515160", Offset = "0x2515160", VA = "0x2515160")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003F8")]
				[Address(RVA = "0x2515168", Offset = "0x2515168", VA = "0x2515168")]
				set
				{
				}
			}

			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x251524C", Offset = "0x251524C", VA = "0x251524C")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x251526C", Offset = "0x251526C", VA = "0x251526C", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x2515274", Offset = "0x2515274", VA = "0x2515274")]
			public static implicit operator NpMatching2SessionPassword(string value)
			{
				return default(NpMatching2SessionPassword);
			}
		}

		[Token(Token = "0x20000C8")]
		public struct NpSessionId
		{
			[Token(Token = "0x40006C6")]
			public const int NP_SESSION_ID_MAX_SIZE = 45;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal string data;

			[Token(Token = "0x1700014D")]
			public string Data
			{
				[Token(Token = "0x60003FC")]
				[Address(RVA = "0x25153C8", Offset = "0x25153C8", VA = "0x25153C8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x25153D0", Offset = "0x25153D0", VA = "0x25153D0")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x25153F0", Offset = "0x25153F0", VA = "0x25153F0")]
			public void SetFromBuffer(byte[] raw)
			{
			}

			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x2515488", Offset = "0x2515488", VA = "0x2515488")]
			public byte[] GetRawBuffer()
			{
				return null;
			}

			[Token(Token = "0x6000400")]
			[Address(RVA = "0x25154C4", Offset = "0x25154C4", VA = "0x25154C4", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x20000C9")]
		public struct NpMatching2WorldId
		{
			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal uint id;

			[Token(Token = "0x1700014E")]
			public uint Id
			{
				[Token(Token = "0x6000401")]
				[Address(RVA = "0x25152A0", Offset = "0x25152A0", VA = "0x25152A0")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x6000402")]
				[Address(RVA = "0x25152A8", Offset = "0x25152A8", VA = "0x25152A8")]
				set
				{
				}
			}

			[Token(Token = "0x6000403")]
			[Address(RVA = "0x25152B0", Offset = "0x25152B0", VA = "0x25152B0")]
			internal void Read(MemoryBuffer buffer)
			{
			}
		}

		[Token(Token = "0x20000CA")]
		public struct NpMatching2WorldNumber
		{
			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ushort num;

			[Token(Token = "0x1700014F")]
			public ushort Num
			{
				[Token(Token = "0x6000404")]
				[Address(RVA = "0x25152E0", Offset = "0x25152E0", VA = "0x25152E0")]
				get
				{
					return default(ushort);
				}
				[Token(Token = "0x6000405")]
				[Address(RVA = "0x25152E8", Offset = "0x25152E8", VA = "0x25152E8")]
				set
				{
				}
			}

			[Token(Token = "0x6000406")]
			[Address(RVA = "0x25152F0", Offset = "0x25152F0", VA = "0x25152F0")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x6000407")]
			[Address(RVA = "0x2515320", Offset = "0x2515320", VA = "0x2515320")]
			public static implicit operator NpMatching2WorldNumber(ushort value)
			{
				return default(NpMatching2WorldNumber);
			}
		}

		[Token(Token = "0x20000CB")]
		public struct World
		{
			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal NpMatching2WorldId worldId;

			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal uint currentNumberOfRooms;

			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal uint currentNumberOfMembers;

			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal NpMatching2WorldNumber worldNumber;

			[Token(Token = "0x17000150")]
			public NpMatching2WorldId WorldId
			{
				[Token(Token = "0x6000408")]
				[Address(RVA = "0x25192A4", Offset = "0x25192A4", VA = "0x25192A4")]
				get
				{
					return default(NpMatching2WorldId);
				}
			}

			[Token(Token = "0x17000151")]
			public uint CurrentNumberOfRooms
			{
				[Token(Token = "0x6000409")]
				[Address(RVA = "0x25192AC", Offset = "0x25192AC", VA = "0x25192AC")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x17000152")]
			public uint CurrentNumberOfMembers
			{
				[Token(Token = "0x600040A")]
				[Address(RVA = "0x25192B4", Offset = "0x25192B4", VA = "0x25192B4")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x17000153")]
			public NpMatching2WorldNumber WorldNumber
			{
				[Token(Token = "0x600040B")]
				[Address(RVA = "0x25192BC", Offset = "0x25192BC", VA = "0x25192BC")]
				get
				{
					return default(NpMatching2WorldNumber);
				}
			}

			[Token(Token = "0x600040C")]
			[Address(RVA = "0x25192C4", Offset = "0x25192C4", VA = "0x25192C4")]
			internal void Read(MemoryBuffer buffer)
			{
			}
		}

		[Token(Token = "0x20000CC")]
		public enum SignalingStatus
		{
			[Token(Token = "0x40006CF")]
			NotApplicable,
			[Token(Token = "0x40006D0")]
			Established,
			[Token(Token = "0x40006D1")]
			EstablishedFailToGetInformation,
			[Token(Token = "0x40006D2")]
			Dead
		}

		[Token(Token = "0x20000CD")]
		public enum NatType
		{
			[Token(Token = "0x40006D4")]
			Invalid,
			[Token(Token = "0x40006D5")]
			NatType1,
			[Token(Token = "0x40006D6")]
			NatType2,
			[Token(Token = "0x40006D7")]
			NatType3
		}

		[Token(Token = "0x20000CE")]
		public class MemberSignalingInformation
		{
			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal NatType natType;

			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal SignalingStatus status;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal uint roundTripTime;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal NetworkUtils.NetInAddr ipAddress;

			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal ushort port;

			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
			internal ushort portNetworkOrder;

			[Token(Token = "0x17000154")]
			public NatType NatType
			{
				[Token(Token = "0x600040D")]
				[Address(RVA = "0x2514E98", Offset = "0x2514E98", VA = "0x2514E98")]
				get
				{
					return default(NatType);
				}
			}

			[Token(Token = "0x17000155")]
			public SignalingStatus Status
			{
				[Token(Token = "0x600040E")]
				[Address(RVA = "0x2514EA0", Offset = "0x2514EA0", VA = "0x2514EA0")]
				get
				{
					return default(SignalingStatus);
				}
			}

			[Token(Token = "0x17000156")]
			public uint RoundTripTime
			{
				[Token(Token = "0x600040F")]
				[Address(RVA = "0x2514EA8", Offset = "0x2514EA8", VA = "0x2514EA8")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x17000157")]
			public NetworkUtils.NetInAddr IpAddress
			{
				[Token(Token = "0x6000410")]
				[Address(RVA = "0x2514EB0", Offset = "0x2514EB0", VA = "0x2514EB0")]
				get
				{
					return default(NetworkUtils.NetInAddr);
				}
			}

			[Token(Token = "0x17000158")]
			public ushort Port
			{
				[Token(Token = "0x6000411")]
				[Address(RVA = "0x2514EB8", Offset = "0x2514EB8", VA = "0x2514EB8")]
				get
				{
					return default(ushort);
				}
			}

			[Token(Token = "0x17000159")]
			public ushort PortNetworkOrder
			{
				[Token(Token = "0x6000412")]
				[Address(RVA = "0x2514EC0", Offset = "0x2514EC0", VA = "0x2514EC0")]
				get
				{
					return default(ushort);
				}
			}

			[Token(Token = "0x6000413")]
			[Address(RVA = "0x2514C18", Offset = "0x2514C18", VA = "0x2514C18")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x6000414")]
			[Address(RVA = "0x2514E90", Offset = "0x2514E90", VA = "0x2514E90")]
			public MemberSignalingInformation()
			{
			}
		}

		[Token(Token = "0x20000CF")]
		public class Member
		{
			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Core.OnlineUser onlineUser;

			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Attribute[] memberAttributes;

			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal DateTime joinedDate;

			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal MemberSignalingInformation signalingInformation;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Core.PlatformType platform;

			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal ushort roomMemberId;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
			internal bool isOwner;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
			internal bool isMe;

			[Token(Token = "0x1700015A")]
			public Core.OnlineUser OnlineUser
			{
				[Token(Token = "0x6000415")]
				[Address(RVA = "0x25149C8", Offset = "0x25149C8", VA = "0x25149C8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700015B")]
			public Attribute[] MemberAttributes
			{
				[Token(Token = "0x6000416")]
				[Address(RVA = "0x25149D0", Offset = "0x25149D0", VA = "0x25149D0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700015C")]
			public DateTime JoinedDate
			{
				[Token(Token = "0x6000417")]
				[Address(RVA = "0x25149D8", Offset = "0x25149D8", VA = "0x25149D8")]
				get
				{
					return default(DateTime);
				}
			}

			[Token(Token = "0x1700015D")]
			public MemberSignalingInformation SignalingInformation
			{
				[Token(Token = "0x6000418")]
				[Address(RVA = "0x25149E0", Offset = "0x25149E0", VA = "0x25149E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700015E")]
			public Core.PlatformType Platform
			{
				[Token(Token = "0x6000419")]
				[Address(RVA = "0x25149E8", Offset = "0x25149E8", VA = "0x25149E8")]
				get
				{
					return default(Core.PlatformType);
				}
			}

			[Token(Token = "0x1700015F")]
			public ushort RoomMemberId
			{
				[Token(Token = "0x600041A")]
				[Address(RVA = "0x25149F0", Offset = "0x25149F0", VA = "0x25149F0")]
				get
				{
					return default(ushort);
				}
			}

			[Token(Token = "0x17000160")]
			public bool IsOwner
			{
				[Token(Token = "0x600041B")]
				[Address(RVA = "0x25149F8", Offset = "0x25149F8", VA = "0x25149F8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000161")]
			public bool IsMe
			{
				[Token(Token = "0x600041C")]
				[Address(RVA = "0x2514A00", Offset = "0x2514A00", VA = "0x2514A00")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600041D")]
			[Address(RVA = "0x2514A08", Offset = "0x2514A08", VA = "0x2514A08")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x600041E")]
			[Address(RVA = "0x2514E08", Offset = "0x2514E08", VA = "0x2514E08")]
			public Member()
			{
			}
		}

		[Token(Token = "0x20000D0")]
		public class Room
		{
			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal ushort matchingContext;

			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			internal ushort serverId;

			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal uint worldId;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal ulong roomId;

			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Attribute[] attributes;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal string name;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Member[] currentMembers;

			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal ulong numMaxMembers;

			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal TopologyType topology;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			internal uint numReservedSlots;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal bool isNatRestricted;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
			internal bool allowBlockedUsersOfOwner;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
			internal bool allowBlockedUsersOfMembers;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
			internal bool joinAllLocalUsers;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			internal RoomMigrationType ownershipMigration;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal RoomVisibility visibility;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal NpMatching2SessionPassword password;

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal NpSessionId boundSessionId;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			internal bool isSystemJoinable;

			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
			internal bool displayOnSystem;

			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
			internal bool hasChangeableData;

			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
			internal bool hasFixedData;

			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			internal bool isCrossplatform;

			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
			internal bool isClosed;

			[Token(Token = "0x17000162")]
			public ushort MatchingContext
			{
				[Token(Token = "0x600041F")]
				[Address(RVA = "0x251620C", Offset = "0x251620C", VA = "0x251620C")]
				get
				{
					return default(ushort);
				}
			}

			[Token(Token = "0x17000163")]
			public ushort ServerId
			{
				[Token(Token = "0x6000420")]
				[Address(RVA = "0x2516214", Offset = "0x2516214", VA = "0x2516214")]
				get
				{
					return default(ushort);
				}
			}

			[Token(Token = "0x17000164")]
			public uint WorldId
			{
				[Token(Token = "0x6000421")]
				[Address(RVA = "0x251621C", Offset = "0x251621C", VA = "0x251621C")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x17000165")]
			public ulong RoomId
			{
				[Token(Token = "0x6000422")]
				[Address(RVA = "0x2516224", Offset = "0x2516224", VA = "0x2516224")]
				get
				{
					return default(ulong);
				}
			}

			[Token(Token = "0x17000166")]
			public Attribute[] Attributes
			{
				[Token(Token = "0x6000423")]
				[Address(RVA = "0x251622C", Offset = "0x251622C", VA = "0x251622C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000167")]
			public string Name
			{
				[Token(Token = "0x6000424")]
				[Address(RVA = "0x2516234", Offset = "0x2516234", VA = "0x2516234")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000168")]
			public Member[] CurrentMembers
			{
				[Token(Token = "0x6000425")]
				[Address(RVA = "0x251623C", Offset = "0x251623C", VA = "0x251623C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000169")]
			public ulong NumMaxMembers
			{
				[Token(Token = "0x6000426")]
				[Address(RVA = "0x2516244", Offset = "0x2516244", VA = "0x2516244")]
				get
				{
					return default(ulong);
				}
			}

			[Token(Token = "0x1700016A")]
			public TopologyType Topology
			{
				[Token(Token = "0x6000427")]
				[Address(RVA = "0x251624C", Offset = "0x251624C", VA = "0x251624C")]
				get
				{
					return default(TopologyType);
				}
			}

			[Token(Token = "0x1700016B")]
			public uint NumReservedSlots
			{
				[Token(Token = "0x6000428")]
				[Address(RVA = "0x2516254", Offset = "0x2516254", VA = "0x2516254")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x1700016C")]
			public bool IsNatRestricted
			{
				[Token(Token = "0x6000429")]
				[Address(RVA = "0x251625C", Offset = "0x251625C", VA = "0x251625C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700016D")]
			public bool AllowBlockedUsersOfOwner
			{
				[Token(Token = "0x600042A")]
				[Address(RVA = "0x2516264", Offset = "0x2516264", VA = "0x2516264")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700016E")]
			public bool AllowBlockedUsersOfMembers
			{
				[Token(Token = "0x600042B")]
				[Address(RVA = "0x251626C", Offset = "0x251626C", VA = "0x251626C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700016F")]
			public bool JoinAllLocalUsers
			{
				[Token(Token = "0x600042C")]
				[Address(RVA = "0x2516274", Offset = "0x2516274", VA = "0x2516274")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000170")]
			public RoomMigrationType OwnershipMigration
			{
				[Token(Token = "0x600042D")]
				[Address(RVA = "0x251627C", Offset = "0x251627C", VA = "0x251627C")]
				get
				{
					return default(RoomMigrationType);
				}
			}

			[Token(Token = "0x17000171")]
			public RoomVisibility Visibility
			{
				[Token(Token = "0x600042E")]
				[Address(RVA = "0x2516284", Offset = "0x2516284", VA = "0x2516284")]
				get
				{
					return default(RoomVisibility);
				}
			}

			[Token(Token = "0x17000172")]
			public NpMatching2SessionPassword Password
			{
				[Token(Token = "0x600042F")]
				[Address(RVA = "0x251628C", Offset = "0x251628C", VA = "0x251628C")]
				get
				{
					return default(NpMatching2SessionPassword);
				}
			}

			[Token(Token = "0x17000173")]
			public NpSessionId BoundSessionId
			{
				[Token(Token = "0x6000430")]
				[Address(RVA = "0x2516294", Offset = "0x2516294", VA = "0x2516294")]
				get
				{
					return default(NpSessionId);
				}
			}

			[Token(Token = "0x17000174")]
			public bool IsSystemJoinable
			{
				[Token(Token = "0x6000431")]
				[Address(RVA = "0x251629C", Offset = "0x251629C", VA = "0x251629C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000175")]
			public bool DisplayOnSystem
			{
				[Token(Token = "0x6000432")]
				[Address(RVA = "0x25162A4", Offset = "0x25162A4", VA = "0x25162A4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000176")]
			public bool HasChangeableData
			{
				[Token(Token = "0x6000433")]
				[Address(RVA = "0x25162AC", Offset = "0x25162AC", VA = "0x25162AC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000177")]
			public bool HasFixedData
			{
				[Token(Token = "0x6000434")]
				[Address(RVA = "0x25162B4", Offset = "0x25162B4", VA = "0x25162B4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000178")]
			public bool IsCrossplatform
			{
				[Token(Token = "0x6000435")]
				[Address(RVA = "0x25162BC", Offset = "0x25162BC", VA = "0x25162BC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000179")]
			public bool IsClosed
			{
				[Token(Token = "0x6000436")]
				[Address(RVA = "0x25162C4", Offset = "0x25162C4", VA = "0x25162C4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000437")]
			[Address(RVA = "0x25162CC", Offset = "0x25162CC", VA = "0x25162CC")]
			public ushort FindRoomMemberId(Core.NpAccountId accountId)
			{
				return default(ushort);
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0x2516380", Offset = "0x2516380", VA = "0x2516380")]
			public ushort FindRoomMemberId(Core.OnlineID onlineId)
			{
				return default(ushort);
			}

			[Token(Token = "0x6000439")]
			[Address(RVA = "0x2516434", Offset = "0x2516434", VA = "0x2516434")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0x251673C", Offset = "0x251673C", VA = "0x251673C")]
			public Room()
			{
			}
		}

		[Token(Token = "0x20000D1")]
		public class WorldsResponse : ResponseBase
		{
			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal World[] worlds;

			[Token(Token = "0x1700017A")]
			public World[] Worlds
			{
				[Token(Token = "0x600043B")]
				[Address(RVA = "0x251931C", Offset = "0x251931C", VA = "0x251931C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600043C")]
			[Address(RVA = "0x2519324", Offset = "0x2519324", VA = "0x2519324", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x600043D")]
			[Address(RVA = "0x25194D0", Offset = "0x25194D0", VA = "0x25194D0")]
			public WorldsResponse()
			{
			}
		}

		[Token(Token = "0x20000D2")]
		public class RoomResponse : ResponseBase
		{
			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Room room;

			[Token(Token = "0x1700017B")]
			public Room Room
			{
				[Token(Token = "0x600043E")]
				[Address(RVA = "0x2516744", Offset = "0x2516744", VA = "0x2516744")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600043F")]
			[Address(RVA = "0x251674C", Offset = "0x251674C", VA = "0x251674C", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0x25168A0", Offset = "0x25168A0", VA = "0x25168A0")]
			public RoomResponse()
			{
			}
		}

		[Token(Token = "0x20000D3")]
		public class RoomsResponse : ResponseBase
		{
			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Room[] rooms;

			[Token(Token = "0x1700017C")]
			public Room[] Rooms
			{
				[Token(Token = "0x6000441")]
				[Address(RVA = "0x25168A8", Offset = "0x25168A8", VA = "0x25168A8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000442")]
			[Address(RVA = "0x25168B0", Offset = "0x25168B0", VA = "0x25168B0", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x6000443")]
			[Address(RVA = "0x2516AD8", Offset = "0x2516AD8", VA = "0x2516AD8")]
			public RoomsResponse()
			{
			}
		}

		[Token(Token = "0x20000D4")]
		public class GetRoomPingTimeResponse : ResponseBase
		{
			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private uint roundTripTime;

			[Token(Token = "0x1700017D")]
			public uint RoundTripTime
			{
				[Token(Token = "0x6000444")]
				[Address(RVA = "0x2513E80", Offset = "0x2513E80", VA = "0x2513E80")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x6000445")]
			[Address(RVA = "0x2513E88", Offset = "0x2513E88", VA = "0x2513E88", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x6000446")]
			[Address(RVA = "0x2513FB8", Offset = "0x2513FB8", VA = "0x2513FB8")]
			public GetRoomPingTimeResponse()
			{
			}
		}

		[Token(Token = "0x20000D5")]
		public class GetDataResponse : ResponseBase
		{
			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal byte[] data;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal DataType type;

			[Token(Token = "0x1700017E")]
			public byte[] Data
			{
				[Token(Token = "0x6000447")]
				[Address(RVA = "0x2513AF4", Offset = "0x2513AF4", VA = "0x2513AF4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700017F")]
			public DataType Type
			{
				[Token(Token = "0x6000448")]
				[Address(RVA = "0x2513AFC", Offset = "0x2513AFC", VA = "0x2513AFC")]
				get
				{
					return default(DataType);
				}
			}

			[Token(Token = "0x6000449")]
			[Address(RVA = "0x2513B04", Offset = "0x2513B04", VA = "0x2513B04", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x600044A")]
			[Address(RVA = "0x2513E58", Offset = "0x2513E58", VA = "0x2513E58")]
			public GetDataResponse()
			{
			}
		}

		[Token(Token = "0x20000D6")]
		public enum Reasons
		{
			[Token(Token = "0x4000705")]
			MemberJoined,
			[Token(Token = "0x4000706")]
			MemberLeft,
			[Token(Token = "0x4000707")]
			MemberSignalingUpdate,
			[Token(Token = "0x4000708")]
			MemberInfoUpdated,
			[Token(Token = "0x4000709")]
			OwnerChanged,
			[Token(Token = "0x400070A")]
			RoomDestroyed,
			[Token(Token = "0x400070B")]
			RoomKickedOut,
			[Token(Token = "0x400070C")]
			RoomExternalInfoUpdated,
			[Token(Token = "0x400070D")]
			RoomInternalInfoUpdated,
			[Token(Token = "0x400070E")]
			RoomTopologyUpdated,
			[Token(Token = "0x400070F")]
			RoomSessionInfoUpdated
		}

		[Token(Token = "0x20000D7")]
		public enum Causes
		{
			[Token(Token = "0x4000711")]
			Unknown = 1,
			[Token(Token = "0x4000712")]
			LeaveAction = 1,
			[Token(Token = "0x4000713")]
			KickoutAction = 2,
			[Token(Token = "0x4000714")]
			GrantOwnerAction = 3,
			[Token(Token = "0x4000715")]
			ServerOperation = 4,
			[Token(Token = "0x4000716")]
			MemberDisappeared = 5,
			[Token(Token = "0x4000717")]
			ServerInternal = 6,
			[Token(Token = "0x4000718")]
			ConnectionError = 7,
			[Token(Token = "0x4000719")]
			SignedOut = 8,
			[Token(Token = "0x400071A")]
			SystemError = 9,
			[Token(Token = "0x400071B")]
			ContextError = 10,
			[Token(Token = "0x400071C")]
			ContextAction = 11
		}

		[Token(Token = "0x20000D8")]
		public class RefreshRoomResponse : ResponseBase
		{
			[Token(Token = "0x2000174")]
			public class OwnerInformation
			{
				[Token(Token = "0x400098A")]
				public const int OWNER_EXCHANGE_SIZE = 2;

				[Token(Token = "0x400098B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				internal NpMatching2SessionPassword password;

				[Token(Token = "0x400098C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				internal ushort[] oldAndNewOwners;

				[Token(Token = "0x1700035C")]
				public NpMatching2SessionPassword Password
				{
					[Token(Token = "0x6000797")]
					[Address(RVA = "0x251619C", Offset = "0x251619C", VA = "0x251619C")]
					get
					{
						return default(NpMatching2SessionPassword);
					}
				}

				[Token(Token = "0x1700035D")]
				public ushort[] OldAndNewOwners
				{
					[Token(Token = "0x6000798")]
					[Address(RVA = "0x25161A4", Offset = "0x25161A4", VA = "0x25161A4")]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x6000799")]
				[Address(RVA = "0x2515D98", Offset = "0x2515D98", VA = "0x2515D98")]
				internal void Read(MemoryBuffer buffer)
				{
				}

				[Token(Token = "0x600079A")]
				[Address(RVA = "0x2515D34", Offset = "0x2515D34", VA = "0x2515D34")]
				internal OwnerInformation()
				{
				}
			}

			[Token(Token = "0x2000175")]
			public class RoomExternalInformation
			{
				[Token(Token = "0x400098D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				internal Attribute[] attributes;

				[Token(Token = "0x1700035E")]
				public Attribute[] Attributes
				{
					[Token(Token = "0x600079B")]
					[Address(RVA = "0x25161AC", Offset = "0x25161AC", VA = "0x25161AC")]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x600079C")]
				[Address(RVA = "0x2515ED8", Offset = "0x2515ED8", VA = "0x2515ED8")]
				internal void Read(MemoryBuffer buffer)
				{
				}

				[Token(Token = "0x600079D")]
				[Address(RVA = "0x2515ED0", Offset = "0x2515ED0", VA = "0x2515ED0")]
				public RoomExternalInformation()
				{
				}
			}

			[Token(Token = "0x2000176")]
			public class RoomInternalInformation
			{
				[Token(Token = "0x400098E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				internal Attribute[] attributes;

				[Token(Token = "0x400098F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				internal Core.OptionalBoolean allowBlockedUsersOfMembers;

				[Token(Token = "0x4000990")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				internal Core.OptionalBoolean joinAllLocalUsers;

				[Token(Token = "0x4000991")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				internal Core.OptionalBoolean isNatRestricted;

				[Token(Token = "0x4000992")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				internal uint numReservedSlots;

				[Token(Token = "0x4000993")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				internal RoomVisibility visibility;

				[Token(Token = "0x4000994")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				internal Core.OptionalBoolean closeRoom;

				[Token(Token = "0x1700035F")]
				public Attribute[] Attributes
				{
					[Token(Token = "0x600079E")]
					[Address(RVA = "0x25161B4", Offset = "0x25161B4", VA = "0x25161B4")]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x17000360")]
				public Core.OptionalBoolean AllowBlockedUsersOfMembers
				{
					[Token(Token = "0x600079F")]
					[Address(RVA = "0x25161BC", Offset = "0x25161BC", VA = "0x25161BC")]
					get
					{
						return default(Core.OptionalBoolean);
					}
				}

				[Token(Token = "0x17000361")]
				public Core.OptionalBoolean JoinAllLocalUsers
				{
					[Token(Token = "0x60007A0")]
					[Address(RVA = "0x25161C4", Offset = "0x25161C4", VA = "0x25161C4")]
					get
					{
						return default(Core.OptionalBoolean);
					}
				}

				[Token(Token = "0x17000362")]
				public Core.OptionalBoolean IsNatRestricted
				{
					[Token(Token = "0x60007A1")]
					[Address(RVA = "0x25161CC", Offset = "0x25161CC", VA = "0x25161CC")]
					get
					{
						return default(Core.OptionalBoolean);
					}
				}

				[Token(Token = "0x17000363")]
				public uint NumReservedSlots
				{
					[Token(Token = "0x60007A2")]
					[Address(RVA = "0x25161D4", Offset = "0x25161D4", VA = "0x25161D4")]
					get
					{
						return default(uint);
					}
				}

				[Token(Token = "0x17000364")]
				public RoomVisibility Visibility
				{
					[Token(Token = "0x60007A3")]
					[Address(RVA = "0x25161DC", Offset = "0x25161DC", VA = "0x25161DC")]
					get
					{
						return default(RoomVisibility);
					}
				}

				[Token(Token = "0x17000365")]
				public Core.OptionalBoolean CloseRoom
				{
					[Token(Token = "0x60007A4")]
					[Address(RVA = "0x25161E4", Offset = "0x25161E4", VA = "0x25161E4")]
					get
					{
						return default(Core.OptionalBoolean);
					}
				}

				[Token(Token = "0x60007A5")]
				[Address(RVA = "0x2515FE8", Offset = "0x2515FE8", VA = "0x2515FE8")]
				internal void Read(MemoryBuffer buffer)
				{
				}

				[Token(Token = "0x60007A6")]
				[Address(RVA = "0x2515FE0", Offset = "0x2515FE0", VA = "0x2515FE0")]
				public RoomInternalInformation()
				{
				}
			}

			[Token(Token = "0x2000177")]
			public class RoomSessionInformation
			{
				[Token(Token = "0x4000995")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				internal Core.OptionalBoolean displayOnSystem;

				[Token(Token = "0x4000996")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				internal Core.OptionalBoolean isSystemJoinable;

				[Token(Token = "0x4000997")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				internal Core.OptionalBoolean hasChangeableData;

				[Token(Token = "0x4000998")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				internal NpSessionId boundSessionId;

				[Token(Token = "0x17000366")]
				public Core.OptionalBoolean DisplayOnSystem
				{
					[Token(Token = "0x60007A7")]
					[Address(RVA = "0x25161EC", Offset = "0x25161EC", VA = "0x25161EC")]
					get
					{
						return default(Core.OptionalBoolean);
					}
				}

				[Token(Token = "0x17000367")]
				public Core.OptionalBoolean IsSystemJoinable
				{
					[Token(Token = "0x60007A8")]
					[Address(RVA = "0x25161F4", Offset = "0x25161F4", VA = "0x25161F4")]
					get
					{
						return default(Core.OptionalBoolean);
					}
				}

				[Token(Token = "0x17000368")]
				public Core.OptionalBoolean HasChangeableData
				{
					[Token(Token = "0x60007A9")]
					[Address(RVA = "0x25161FC", Offset = "0x25161FC", VA = "0x25161FC")]
					get
					{
						return default(Core.OptionalBoolean);
					}
				}

				[Token(Token = "0x17000369")]
				public NpSessionId BoundSessionId
				{
					[Token(Token = "0x60007AA")]
					[Address(RVA = "0x2516204", Offset = "0x2516204", VA = "0x2516204")]
					get
					{
						return default(NpSessionId);
					}
				}

				[Token(Token = "0x60007AB")]
				[Address(RVA = "0x2516140", Offset = "0x2516140", VA = "0x2516140")]
				internal void Read(MemoryBuffer buffer)
				{
				}

				[Token(Token = "0x60007AC")]
				[Address(RVA = "0x2516138", Offset = "0x2516138", VA = "0x2516138")]
				public RoomSessionInformation()
				{
				}
			}

			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal ulong roomId;

			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal PresenceOptionData notificationFromMember;

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal Reasons reason;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal Causes cause;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal OwnerInformation ownerInfo;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal Member memberInfo;

			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal long roomLeftError;

			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal RoomExternalInformation roomExternalInfo;

			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal RoomInternalInformation roomInternalInfo;

			[Token(Token = "0x4000726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			internal RoomSessionInformation roomSessionInfo;

			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			internal TopologyType roomTopology;

			[Token(Token = "0x17000180")]
			public ulong RoomId
			{
				[Token(Token = "0x600044B")]
				[Address(RVA = "0x2515A4C", Offset = "0x2515A4C", VA = "0x2515A4C")]
				get
				{
					return default(ulong);
				}
			}

			[Token(Token = "0x17000181")]
			public PresenceOptionData NotificationFromMember
			{
				[Token(Token = "0x600044C")]
				[Address(RVA = "0x2515A54", Offset = "0x2515A54", VA = "0x2515A54")]
				get
				{
					return default(PresenceOptionData);
				}
			}

			[Token(Token = "0x17000182")]
			public Reasons Reason
			{
				[Token(Token = "0x600044D")]
				[Address(RVA = "0x2515A60", Offset = "0x2515A60", VA = "0x2515A60")]
				get
				{
					return default(Reasons);
				}
			}

			[Token(Token = "0x17000183")]
			public Causes Cause
			{
				[Token(Token = "0x600044E")]
				[Address(RVA = "0x2515A68", Offset = "0x2515A68", VA = "0x2515A68")]
				get
				{
					return default(Causes);
				}
			}

			[Token(Token = "0x17000184")]
			public OwnerInformation OwnerInfo
			{
				[Token(Token = "0x600044F")]
				[Address(RVA = "0x2515A70", Offset = "0x2515A70", VA = "0x2515A70")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000185")]
			public Member MemberInfo
			{
				[Token(Token = "0x6000450")]
				[Address(RVA = "0x2515A78", Offset = "0x2515A78", VA = "0x2515A78")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000186")]
			public long RoomLeftError
			{
				[Token(Token = "0x6000451")]
				[Address(RVA = "0x2515A80", Offset = "0x2515A80", VA = "0x2515A80")]
				get
				{
					return default(long);
				}
			}

			[Token(Token = "0x17000187")]
			public RoomExternalInformation RoomExternalInfo
			{
				[Token(Token = "0x6000452")]
				[Address(RVA = "0x2515A88", Offset = "0x2515A88", VA = "0x2515A88")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000188")]
			public RoomInternalInformation RoomInternalInfo
			{
				[Token(Token = "0x6000453")]
				[Address(RVA = "0x2515A90", Offset = "0x2515A90", VA = "0x2515A90")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000189")]
			public RoomSessionInformation RoomSessionInfo
			{
				[Token(Token = "0x6000454")]
				[Address(RVA = "0x2515A98", Offset = "0x2515A98", VA = "0x2515A98")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700018A")]
			public TopologyType RoomTopology
			{
				[Token(Token = "0x6000455")]
				[Address(RVA = "0x2515AA0", Offset = "0x2515AA0", VA = "0x2515AA0")]
				get
				{
					return default(TopologyType);
				}
			}

			[Token(Token = "0x6000456")]
			[Address(RVA = "0x2515AA8", Offset = "0x2515AA8", VA = "0x2515AA8", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0x2516194", Offset = "0x2516194", VA = "0x2516194")]
			public RefreshRoomResponse()
			{
			}
		}

		[Token(Token = "0x20000D9")]
		public class NewRoomMessageResponse : ResponseBase
		{
			[Token(Token = "0x4000728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal ulong roomId;

			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal byte[] data;

			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal ushort sender;

			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
			internal bool isChatMsg;

			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
			internal bool isFiltered;

			[Token(Token = "0x1700018B")]
			public ulong RoomId
			{
				[Token(Token = "0x6000458")]
				[Address(RVA = "0x2514EC8", Offset = "0x2514EC8", VA = "0x2514EC8")]
				get
				{
					return default(ulong);
				}
			}

			[Token(Token = "0x1700018C")]
			public byte[] Data
			{
				[Token(Token = "0x6000459")]
				[Address(RVA = "0x2514ED0", Offset = "0x2514ED0", VA = "0x2514ED0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700018D")]
			public string DataAsString
			{
				[Token(Token = "0x600045A")]
				[Address(RVA = "0x2514ED8", Offset = "0x2514ED8", VA = "0x2514ED8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700018E")]
			public ushort Sender
			{
				[Token(Token = "0x600045B")]
				[Address(RVA = "0x2514FA8", Offset = "0x2514FA8", VA = "0x2514FA8")]
				get
				{
					return default(ushort);
				}
			}

			[Token(Token = "0x1700018F")]
			public bool IsChatMsg
			{
				[Token(Token = "0x600045C")]
				[Address(RVA = "0x2514FB0", Offset = "0x2514FB0", VA = "0x2514FB0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000190")]
			public bool IsFiltered
			{
				[Token(Token = "0x600045D")]
				[Address(RVA = "0x2514FB8", Offset = "0x2514FB8", VA = "0x2514FB8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600045E")]
			[Address(RVA = "0x2514FC0", Offset = "0x2514FC0", VA = "0x2514FC0", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x600045F")]
			[Address(RVA = "0x2515128", Offset = "0x2515128", VA = "0x2515128")]
			public NewRoomMessageResponse()
			{
			}
		}

		[Token(Token = "0x20000DA")]
		public enum CurrentPlatform
		{
			[Token(Token = "0x400072E")]
			NotSet,
			[Token(Token = "0x400072F")]
			PSVita,
			[Token(Token = "0x4000730")]
			PS4
		}

		[Token(Token = "0x20000DB")]
		public class InvitationReceivedResponse : ResponseBase
		{
			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Core.OnlineUser localUpdatedUser;

			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Core.OnlineUser remoteUser;

			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal CurrentPlatform platform;

			[Token(Token = "0x17000191")]
			public Core.OnlineUser LocalUpdatedUser
			{
				[Token(Token = "0x6000460")]
				[Address(RVA = "0x2513FD0", Offset = "0x2513FD0", VA = "0x2513FD0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000192")]
			public Core.OnlineUser RemoteUser
			{
				[Token(Token = "0x6000461")]
				[Address(RVA = "0x2513FD8", Offset = "0x2513FD8", VA = "0x2513FD8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000193")]
			public CurrentPlatform Platform
			{
				[Token(Token = "0x6000462")]
				[Address(RVA = "0x2513FE0", Offset = "0x2513FE0", VA = "0x2513FE0")]
				get
				{
					return default(CurrentPlatform);
				}
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0x2513FE8", Offset = "0x2513FE8", VA = "0x2513FE8", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x6000464")]
			[Address(RVA = "0x2514140", Offset = "0x2514140", VA = "0x2514140")]
			public InvitationReceivedResponse()
			{
			}
		}

		[Token(Token = "0x20000DC")]
		public struct NpInvitationId
		{
			[Token(Token = "0x4000734")]
			public const int NP_INVITATION_ID_MAX_SIZE = 60;

			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal string id;

			[Token(Token = "0x17000194")]
			public string Id
			{
				[Token(Token = "0x6000465")]
				[Address(RVA = "0x2515130", Offset = "0x2515130", VA = "0x2515130")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000466")]
			[Address(RVA = "0x2515138", Offset = "0x2515138", VA = "0x2515138")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x6000467")]
			[Address(RVA = "0x2515158", Offset = "0x2515158", VA = "0x2515158", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x20000DD")]
		public class SessionInvitationEventResponse : ResponseBase
		{
			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal NpSessionId sessionId;

			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal NpInvitationId invitationId;

			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal bool acceptedInvite;

			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal Core.OnlineID onlineId;

			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal Core.UserServiceUserId userId;

			[Token(Token = "0x400073B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal Core.OnlineID referralOnlineId;

			[Token(Token = "0x400073C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal Core.NpAccountId referralAccountId;

			[Token(Token = "0x17000195")]
			public NpSessionId SessionId
			{
				[Token(Token = "0x6000468")]
				[Address(RVA = "0x2517A60", Offset = "0x2517A60", VA = "0x2517A60")]
				get
				{
					return default(NpSessionId);
				}
			}

			[Token(Token = "0x17000196")]
			public NpInvitationId InvitationId
			{
				[Token(Token = "0x6000469")]
				[Address(RVA = "0x2517A68", Offset = "0x2517A68", VA = "0x2517A68")]
				get
				{
					return default(NpInvitationId);
				}
			}

			[Token(Token = "0x17000197")]
			public bool AcceptedInvite
			{
				[Token(Token = "0x600046A")]
				[Address(RVA = "0x2517A70", Offset = "0x2517A70", VA = "0x2517A70")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000198")]
			public Core.OnlineID OnlineId
			{
				[Token(Token = "0x600046B")]
				[Address(RVA = "0x2517A78", Offset = "0x2517A78", VA = "0x2517A78")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000199")]
			public Core.UserServiceUserId UserId
			{
				[Token(Token = "0x600046C")]
				[Address(RVA = "0x2517A80", Offset = "0x2517A80", VA = "0x2517A80")]
				get
				{
					return default(Core.UserServiceUserId);
				}
			}

			[Token(Token = "0x1700019A")]
			public Core.OnlineID ReferralOnlineId
			{
				[Token(Token = "0x600046D")]
				[Address(RVA = "0x2517A88", Offset = "0x2517A88", VA = "0x2517A88")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700019B")]
			public Core.NpAccountId ReferralAccountId
			{
				[Token(Token = "0x600046E")]
				[Address(RVA = "0x2517A90", Offset = "0x2517A90", VA = "0x2517A90")]
				get
				{
					return default(Core.NpAccountId);
				}
			}

			[Token(Token = "0x600046F")]
			[Address(RVA = "0x2517A98", Offset = "0x2517A98", VA = "0x2517A98", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x6000470")]
			[Address(RVA = "0x2517C30", Offset = "0x2517C30", VA = "0x2517C30")]
			public SessionInvitationEventResponse()
			{
			}
		}

		[Token(Token = "0x20000DE")]
		public struct NpPlayTogetherInvitee
		{
			[Token(Token = "0x400073D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Core.NpAccountId accountId;

			[Token(Token = "0x400073E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Core.OnlineID onlineId;

			[Token(Token = "0x1700019C")]
			public Core.NpAccountId AccountId
			{
				[Token(Token = "0x6000471")]
				[Address(RVA = "0x2515328", Offset = "0x2515328", VA = "0x2515328")]
				get
				{
					return default(Core.NpAccountId);
				}
			}

			[Token(Token = "0x1700019D")]
			public Core.OnlineID OnlineId
			{
				[Token(Token = "0x6000472")]
				[Address(RVA = "0x2515330", Offset = "0x2515330", VA = "0x2515330")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000473")]
			[Address(RVA = "0x2515338", Offset = "0x2515338", VA = "0x2515338")]
			internal void Read(MemoryBuffer buffer)
			{
			}
		}

		[Token(Token = "0x20000DF")]
		public class PlayTogetherHostEventResponse : ResponseBase
		{
			[Token(Token = "0x400073F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Core.UserServiceUserId userId;

			[Token(Token = "0x4000740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal NpPlayTogetherInvitee[] invitees;

			[Token(Token = "0x1700019E")]
			public Core.UserServiceUserId UserId
			{
				[Token(Token = "0x6000474")]
				[Address(RVA = "0x25154CC", Offset = "0x25154CC", VA = "0x25154CC")]
				get
				{
					return default(Core.UserServiceUserId);
				}
			}

			[Token(Token = "0x1700019F")]
			public NpPlayTogetherInvitee[] Invitees
			{
				[Token(Token = "0x6000475")]
				[Address(RVA = "0x25154D4", Offset = "0x25154D4", VA = "0x25154D4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000476")]
			[Address(RVA = "0x25154DC", Offset = "0x25154DC", VA = "0x25154DC", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x6000477")]
			[Address(RVA = "0x2515690", Offset = "0x2515690", VA = "0x2515690")]
			public PlayTogetherHostEventResponse()
			{
			}
		}

		[Token(Token = "0x40003B0")]
		public const int INVALID_ROOM_MEMBER_ID = 0;

		[PreserveSig]
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x24E3AA0", Offset = "0x24E3AA0", VA = "0x24E3AA0")]
		private static extern int PrxSetInitConfiguration(SetInitConfigurationRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x24E3B74", Offset = "0x24E3B74", VA = "0x24E3B74")]
		private static extern int PrxGetWorlds(GetWorldsRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x24E3C38", Offset = "0x24E3C38", VA = "0x24E3C38")]
		private static extern int PrxCreateRoom(CreateRoomRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x24E3D14", Offset = "0x24E3D14", VA = "0x24E3D14")]
		private static extern int PrxLeaveRoom(LeaveRoomRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x24E3DE4", Offset = "0x24E3DE4", VA = "0x24E3DE4")]
		private static extern int PrxSearchRooms(SearchRoomsRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x24E3EC0", Offset = "0x24E3EC0", VA = "0x24E3EC0")]
		private static extern int PrxJoinRoom(JoinRoomRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x24E3F9C", Offset = "0x24E3F9C", VA = "0x24E3F9C")]
		private static extern int PrxGetRoomPingTime(GetRoomPingTimeRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x24E4060", Offset = "0x24E4060", VA = "0x24E4060")]
		private static extern int PrxKickOutRoomMember(KickOutRoomMemberRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x24E4130", Offset = "0x24E4130", VA = "0x24E4130")]
		private static extern int PrxSendRoomMessage(SendRoomMessageRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x24E4204", Offset = "0x24E4204", VA = "0x24E4204")]
		private static extern int PrxGetAttributes(GetAttributesRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x24E42C8", Offset = "0x24E42C8", VA = "0x24E42C8")]
		private static extern int PrxSetRoomInfo(SetRoomInfoRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x24E43A4", Offset = "0x24E43A4", VA = "0x24E43A4")]
		private static extern int PrxSetMembersAsRecentlyMet(SetMembersAsRecentlyMetRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x24E4478", Offset = "0x24E4478", VA = "0x24E4478")]
		private static extern int PrxSendInvitation(SendInvitationRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x24E454C", Offset = "0x24E454C", VA = "0x24E454C")]
		private static extern int PrxGetData(GetDataRequest request, out APIResult result);

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x24E4614", Offset = "0x24E4614", VA = "0x24E4614")]
		public static int SetInitConfiguration(SetInitConfigurationRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x24E4720", Offset = "0x24E4720", VA = "0x24E4720")]
		public static int GetWorlds(GetWorldsRequest request, WorldsResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x24E482C", Offset = "0x24E482C", VA = "0x24E482C")]
		public static int CreateRoom(CreateRoomRequest request, RoomResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x24E49FC", Offset = "0x24E49FC", VA = "0x24E49FC")]
		public static int LeaveRoom(LeaveRoomRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x24E4B08", Offset = "0x24E4B08", VA = "0x24E4B08")]
		public static int SearchRooms(SearchRoomsRequest request, RoomsResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x24E4C14", Offset = "0x24E4C14", VA = "0x24E4C14")]
		public static int JoinRoom(JoinRoomRequest request, RoomResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x24E4D20", Offset = "0x24E4D20", VA = "0x24E4D20")]
		public static int GetRoomPingTime(GetRoomPingTimeRequest request, GetRoomPingTimeResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x24E4E2C", Offset = "0x24E4E2C", VA = "0x24E4E2C")]
		public static int KickOutRoomMember(KickOutRoomMemberRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x24E4F38", Offset = "0x24E4F38", VA = "0x24E4F38")]
		public static int SendRoomMessage(SendRoomMessageRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x24E5044", Offset = "0x24E5044", VA = "0x24E5044")]
		public static int GetAttributes(GetAttributesRequest request, RefreshRoomResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x24E5150", Offset = "0x24E5150", VA = "0x24E5150")]
		public static int GetData(GetDataRequest request, GetDataResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x24E525C", Offset = "0x24E525C", VA = "0x24E525C")]
		public static int SendInvitation(SendInvitationRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x24E5368", Offset = "0x24E5368", VA = "0x24E5368")]
		public static int SetRoomInfo(SetRoomInfoRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x24E5474", Offset = "0x24E5474", VA = "0x24E5474")]
		public static int SetMembersAsRecentlyMet(SetMembersAsRecentlyMetRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x24E55BC", Offset = "0x24E55BC", VA = "0x24E55BC")]
		public Matching()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class Messaging
	{
		[StructLayout(0)]
		[Token(Token = "0x20000E0")]
		public class SendInGameMessageRequest : RequestBase
		{
			[Token(Token = "0x4000741")]
			public const int NP_IN_GAME_MESSAGE_DATA_SIZE_MAX = 512;

			[Token(Token = "0x4000742")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ulong messageSize;

			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal byte[] message;

			[Token(Token = "0x4000744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal Core.NpAccountId recipientId;

			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal Core.PlatformType recipientPlatformType;

			[Token(Token = "0x170001A0")]
			public byte[] Message
			{
				[Token(Token = "0x6000478")]
				[Address(RVA = "0x24E55C4", Offset = "0x24E55C4", VA = "0x24E55C4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000479")]
				[Address(RVA = "0x24E565C", Offset = "0x24E565C", VA = "0x24E565C")]
				set
				{
				}
			}

			[Token(Token = "0x170001A1")]
			public Core.NpAccountId RecipientId
			{
				[Token(Token = "0x600047A")]
				[Address(RVA = "0x24E57CC", Offset = "0x24E57CC", VA = "0x24E57CC")]
				get
				{
					return default(Core.NpAccountId);
				}
				[Token(Token = "0x600047B")]
				[Address(RVA = "0x24E57D4", Offset = "0x24E57D4", VA = "0x24E57D4")]
				set
				{
				}
			}

			[Token(Token = "0x170001A2")]
			public Core.PlatformType RecipientPlatformType
			{
				[Token(Token = "0x600047C")]
				[Address(RVA = "0x24E57DC", Offset = "0x24E57DC", VA = "0x24E57DC")]
				get
				{
					return default(Core.PlatformType);
				}
				[Token(Token = "0x600047D")]
				[Address(RVA = "0x24E57E4", Offset = "0x24E57E4", VA = "0x24E57E4")]
				set
				{
				}
			}

			[Token(Token = "0x600047E")]
			[Address(RVA = "0x24E57EC", Offset = "0x24E57EC", VA = "0x24E57EC")]
			public SendInGameMessageRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x20000E1")]
		public class DisplayReceivedGameDataMessagesDialogRequest : RequestBase
		{
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x251B724", Offset = "0x251B724", VA = "0x251B724")]
			public DisplayReceivedGameDataMessagesDialogRequest()
			{
			}
		}

		[Token(Token = "0x20000E2")]
		public enum GameCustomDataTypes
		{
			[Token(Token = "0x4000747")]
			Invalid,
			[Token(Token = "0x4000748")]
			Url,
			[Token(Token = "0x4000749")]
			Attachment
		}

		[Token(Token = "0x20000E3")]
		public struct GameDataMessageImage
		{
			[Token(Token = "0x400074A")]
			public const int IMAGE_PATH_MAX_LEN = 255;

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal string imgPath;

			[Token(Token = "0x170001A3")]
			public string ImgPath
			{
				[Token(Token = "0x6000480")]
				[Address(RVA = "0x251BCD0", Offset = "0x251BCD0", VA = "0x251BCD0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000481")]
				[Address(RVA = "0x251BCD8", Offset = "0x251BCD8", VA = "0x251BCD8")]
				set
				{
				}
			}

			[Token(Token = "0x6000482")]
			[Address(RVA = "0x251AFDC", Offset = "0x251AFDC", VA = "0x251AFDC")]
			internal bool IsValid()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000E4")]
		public struct LocalizedMetadata
		{
			[Token(Token = "0x400074C")]
			public const int MAX_SIZE_DATA_NAME = 127;

			[Token(Token = "0x400074D")]
			public const int MAX_SIZE_DATA_DESCRIPTION = 511;

			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal string languageCode;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal string name;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal string description;

			[Token(Token = "0x170001A4")]
			public Core.LanguageCode LanguageCode
			{
				[Token(Token = "0x6000483")]
				[Address(RVA = "0x251C3C8", Offset = "0x251C3C8", VA = "0x251C3C8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000484")]
				[Address(RVA = "0x251C438", Offset = "0x251C438", VA = "0x251C438")]
				set
				{
				}
			}

			[Token(Token = "0x170001A5")]
			public string Name
			{
				[Token(Token = "0x6000485")]
				[Address(RVA = "0x251C454", Offset = "0x251C454", VA = "0x251C454")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000486")]
				[Address(RVA = "0x251C45C", Offset = "0x251C45C", VA = "0x251C45C")]
				set
				{
				}
			}

			[Token(Token = "0x170001A6")]
			public string Description
			{
				[Token(Token = "0x6000487")]
				[Address(RVA = "0x251C540", Offset = "0x251C540", VA = "0x251C540")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000488")]
				[Address(RVA = "0x251C548", Offset = "0x251C548", VA = "0x251C548")]
				set
				{
				}
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x20000E5")]
		public class SendGameDataMessageRequest : RequestBase
		{
			[Token(Token = "0x4000751")]
			public const int MAX_SIZE_TEXT_MESSAGE = 511;

			[Token(Token = "0x4000752")]
			public const int MAX_SIZE_DATA_NAME = 127;

			[Token(Token = "0x4000753")]
			public const int MAX_SIZE_DATA_DESCRIPTION = 511;

			[Token(Token = "0x4000754")]
			public const int MAX_NUM_RECIPIENTS = 16;

			[Token(Token = "0x4000755")]
			public const int MAX_SIZE_ATTACHMENT = 1048576;

			[Token(Token = "0x4000756")]
			public const int MAX_URL_SIZE = 1023;

			[Token(Token = "0x4000757")]
			public const int MAX_LOCALIZED_METADATA = 50;

			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal string textMessage;

			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal string dataName;

			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal string dataDescription;

			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal uint numRecipients;

			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal Core.NpAccountId[] recipients;

			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal GameCustomDataTypes dataType;

			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			internal uint expireMinutes;

			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal byte[] attachment;

			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal ulong attachmentSize;

			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			internal string url;

			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			internal ulong numDataLocalized;

			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			internal LocalizedMetadata[] localizedMetaData;

			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			internal GameDataMessageImage thumbnail;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			internal uint maxNumberRecipientsToAdd;

			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private bool enableDialog;

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
			private bool senderCanEditRecipients;

			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8E")]
			private bool isPS4Available;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8F")]
			private bool isPSVitaAvailable;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private bool addGameDataMsgIdToUrl;

			[Token(Token = "0x170001A7")]
			public string TextMessage
			{
				[Token(Token = "0x6000489")]
				[Address(RVA = "0x251CA30", Offset = "0x251CA30", VA = "0x251CA30")]
				get
				{
					return null;
				}
				[Token(Token = "0x600048A")]
				[Address(RVA = "0x251CA38", Offset = "0x251CA38", VA = "0x251CA38")]
				set
				{
				}
			}

			[Token(Token = "0x170001A8")]
			public string DataName
			{
				[Token(Token = "0x600048B")]
				[Address(RVA = "0x251CB1C", Offset = "0x251CB1C", VA = "0x251CB1C")]
				get
				{
					return null;
				}
				[Token(Token = "0x600048C")]
				[Address(RVA = "0x251CB24", Offset = "0x251CB24", VA = "0x251CB24")]
				set
				{
				}
			}

			[Token(Token = "0x170001A9")]
			public string DataDescription
			{
				[Token(Token = "0x600048D")]
				[Address(RVA = "0x251CC08", Offset = "0x251CC08", VA = "0x251CC08")]
				get
				{
					return null;
				}
				[Token(Token = "0x600048E")]
				[Address(RVA = "0x251CC10", Offset = "0x251CC10", VA = "0x251CC10")]
				set
				{
				}
			}

			[Token(Token = "0x170001AA")]
			public Core.NpAccountId[] Recipients
			{
				[Token(Token = "0x600048F")]
				[Address(RVA = "0x251CCF4", Offset = "0x251CCF4", VA = "0x251CCF4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000490")]
				[Address(RVA = "0x251CD74", Offset = "0x251CD74", VA = "0x251CD74")]
				set
				{
				}
			}

			[Token(Token = "0x170001AB")]
			public GameCustomDataTypes DataType
			{
				[Token(Token = "0x6000491")]
				[Address(RVA = "0x251CE68", Offset = "0x251CE68", VA = "0x251CE68")]
				get
				{
					return default(GameCustomDataTypes);
				}
			}

			[Token(Token = "0x170001AC")]
			public byte[] Attachment
			{
				[Token(Token = "0x6000492")]
				[Address(RVA = "0x251CE70", Offset = "0x251CE70", VA = "0x251CE70")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000493")]
				[Address(RVA = "0x251CE78", Offset = "0x251CE78", VA = "0x251CE78")]
				set
				{
				}
			}

			[Token(Token = "0x170001AD")]
			public uint ExpireMinutes
			{
				[Token(Token = "0x6000494")]
				[Address(RVA = "0x251CF64", Offset = "0x251CF64", VA = "0x251CF64")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x6000495")]
				[Address(RVA = "0x251CF6C", Offset = "0x251CF6C", VA = "0x251CF6C")]
				set
				{
				}
			}

			[Token(Token = "0x170001AE")]
			public string Url
			{
				[Token(Token = "0x6000496")]
				[Address(RVA = "0x251CF74", Offset = "0x251CF74", VA = "0x251CF74")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000497")]
				[Address(RVA = "0x251CF7C", Offset = "0x251CF7C", VA = "0x251CF7C")]
				set
				{
				}
			}

			[Token(Token = "0x170001AF")]
			public LocalizedMetadata[] LocalizedMetaData
			{
				[Token(Token = "0x6000498")]
				[Address(RVA = "0x251D068", Offset = "0x251D068", VA = "0x251D068")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000499")]
				[Address(RVA = "0x251D100", Offset = "0x251D100", VA = "0x251D100")]
				set
				{
				}
			}

			[Token(Token = "0x170001B0")]
			public GameDataMessageImage Thumbnail
			{
				[Token(Token = "0x600049A")]
				[Address(RVA = "0x251D1E4", Offset = "0x251D1E4", VA = "0x251D1E4")]
				get
				{
					return default(GameDataMessageImage);
				}
				[Token(Token = "0x600049B")]
				[Address(RVA = "0x251D1EC", Offset = "0x251D1EC", VA = "0x251D1EC")]
				set
				{
				}
			}

			[Token(Token = "0x170001B1")]
			public uint MaxNumberRecipientsToAdd
			{
				[Token(Token = "0x600049C")]
				[Address(RVA = "0x251D1F4", Offset = "0x251D1F4", VA = "0x251D1F4")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x600049D")]
				[Address(RVA = "0x251D1FC", Offset = "0x251D1FC", VA = "0x251D1FC")]
				set
				{
				}
			}

			[Token(Token = "0x170001B2")]
			public bool EnableDialog
			{
				[Token(Token = "0x600049E")]
				[Address(RVA = "0x251D204", Offset = "0x251D204", VA = "0x251D204")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600049F")]
				[Address(RVA = "0x251D20C", Offset = "0x251D20C", VA = "0x251D20C")]
				set
				{
				}
			}

			[Token(Token = "0x170001B3")]
			public bool SenderCanEditRecipients
			{
				[Token(Token = "0x60004A0")]
				[Address(RVA = "0x251D218", Offset = "0x251D218", VA = "0x251D218")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60004A1")]
				[Address(RVA = "0x251D220", Offset = "0x251D220", VA = "0x251D220")]
				set
				{
				}
			}

			[Token(Token = "0x170001B4")]
			public bool IsPS4Available
			{
				[Token(Token = "0x60004A2")]
				[Address(RVA = "0x251D22C", Offset = "0x251D22C", VA = "0x251D22C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60004A3")]
				[Address(RVA = "0x251D234", Offset = "0x251D234", VA = "0x251D234")]
				set
				{
				}
			}

			[Token(Token = "0x170001B5")]
			public bool IsPSVitaAvailable
			{
				[Token(Token = "0x60004A4")]
				[Address(RVA = "0x251D240", Offset = "0x251D240", VA = "0x251D240")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60004A5")]
				[Address(RVA = "0x251D248", Offset = "0x251D248", VA = "0x251D248")]
				set
				{
				}
			}

			[Token(Token = "0x170001B6")]
			public bool AddGameDataMsgIdToUrl
			{
				[Token(Token = "0x60004A6")]
				[Address(RVA = "0x251D254", Offset = "0x251D254", VA = "0x251D254")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60004A7")]
				[Address(RVA = "0x251D25C", Offset = "0x251D25C", VA = "0x251D25C")]
				set
				{
				}
			}

			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x251D268", Offset = "0x251D268", VA = "0x251D268")]
			public SendGameDataMessageRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x20000E6")]
		public class ConsumeGameDataMessageRequest : RequestBase
		{
			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ulong gameDataMsgId;

			[Token(Token = "0x170001B7")]
			public ulong GameDataMsgId
			{
				[Token(Token = "0x60004A9")]
				[Address(RVA = "0x251B704", Offset = "0x251B704", VA = "0x251B704")]
				get
				{
					return default(ulong);
				}
				[Token(Token = "0x60004AA")]
				[Address(RVA = "0x251B70C", Offset = "0x251B70C", VA = "0x251B70C")]
				set
				{
				}
			}

			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x251B714", Offset = "0x251B714", VA = "0x251B714")]
			public ConsumeGameDataMessageRequest()
			{
			}
		}

		[Token(Token = "0x20000E7")]
		public enum GameDataMessagesToRetrieve
		{
			[Token(Token = "0x400076D")]
			FromGameDataMsgIds,
			[Token(Token = "0x400076E")]
			All
		}

		[StructLayout(0)]
		[Token(Token = "0x20000E8")]
		public class GetReceivedGameDataMessagesRequest : RequestBase
		{
			[Token(Token = "0x400076F")]
			public const int MAX_NUM_GAME_DATA_MSG_IDS = 20;

			[Token(Token = "0x4000770")]
			public const int MAX_PAGE_SIZE = 100;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ulong numGameDataMsgIds;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal ulong[] gameDataMsgIds;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal uint pageSize;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal uint offset;

			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal GameDataMessagesToRetrieve retrieveType;

			[Token(Token = "0x170001B8")]
			public ulong[] GameDataMsgIds
			{
				[Token(Token = "0x60004AC")]
				[Address(RVA = "0x251C180", Offset = "0x251C180", VA = "0x251C180")]
				get
				{
					return null;
				}
				[Token(Token = "0x60004AD")]
				[Address(RVA = "0x251C218", Offset = "0x251C218", VA = "0x251C218")]
				set
				{
				}
			}

			[Token(Token = "0x170001B9")]
			public uint PageSize
			{
				[Token(Token = "0x60004AE")]
				[Address(RVA = "0x251C314", Offset = "0x251C314", VA = "0x251C314")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x60004AF")]
				[Address(RVA = "0x251C31C", Offset = "0x251C31C", VA = "0x251C31C")]
				set
				{
				}
			}

			[Token(Token = "0x170001BA")]
			public uint Offset
			{
				[Token(Token = "0x60004B0")]
				[Address(RVA = "0x251C32C", Offset = "0x251C32C", VA = "0x251C32C")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x60004B1")]
				[Address(RVA = "0x251C334", Offset = "0x251C334", VA = "0x251C334")]
				set
				{
				}
			}

			[Token(Token = "0x170001BB")]
			public GameDataMessagesToRetrieve RetrieveType
			{
				[Token(Token = "0x60004B2")]
				[Address(RVA = "0x251C340", Offset = "0x251C340", VA = "0x251C340")]
				get
				{
					return default(GameDataMessagesToRetrieve);
				}
			}

			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x251C348", Offset = "0x251C348", VA = "0x251C348")]
			public GetReceivedGameDataMessagesRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x20000E9")]
		public class GetGameDataMessageThumbnailRequest : RequestBase
		{
			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ulong gameDataMsgId;

			[Token(Token = "0x170001BC")]
			public ulong GameDataMsgId
			{
				[Token(Token = "0x60004B4")]
				[Address(RVA = "0x251C160", Offset = "0x251C160", VA = "0x251C160")]
				get
				{
					return default(ulong);
				}
				[Token(Token = "0x60004B5")]
				[Address(RVA = "0x251C168", Offset = "0x251C168", VA = "0x251C168")]
				set
				{
				}
			}

			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x251C170", Offset = "0x251C170", VA = "0x251C170")]
			public GetGameDataMessageThumbnailRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x20000EA")]
		public class GetGameDataMessageAttachmentRequest : RequestBase
		{
			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ulong gameDataMsgId;

			[Token(Token = "0x170001BD")]
			public ulong GameDataMsgId
			{
				[Token(Token = "0x60004B7")]
				[Address(RVA = "0x251C140", Offset = "0x251C140", VA = "0x251C140")]
				get
				{
					return default(ulong);
				}
				[Token(Token = "0x60004B8")]
				[Address(RVA = "0x251C148", Offset = "0x251C148", VA = "0x251C148")]
				set
				{
				}
			}

			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x251C150", Offset = "0x251C150", VA = "0x251C150")]
			public GetGameDataMessageAttachmentRequest()
			{
			}
		}

		[Token(Token = "0x20000EB")]
		public class GameDataMessageDetails
		{
			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal string dataName;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal string dataDescription;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal string textMessage;

			[Token(Token = "0x170001BE")]
			public string DataName
			{
				[Token(Token = "0x60004BA")]
				[Address(RVA = "0x251BCB8", Offset = "0x251BCB8", VA = "0x251BCB8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001BF")]
			public string DataDescription
			{
				[Token(Token = "0x60004BB")]
				[Address(RVA = "0x251BCC0", Offset = "0x251BCC0", VA = "0x251BCC0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001C0")]
			public string TextMessage
			{
				[Token(Token = "0x60004BC")]
				[Address(RVA = "0x251BCC8", Offset = "0x251BCC8", VA = "0x251BCC8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x251BA9C", Offset = "0x251BA9C", VA = "0x251BA9C")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x251BA94", Offset = "0x251BA94", VA = "0x251BA94")]
			public GameDataMessageDetails()
			{
			}
		}

		[Token(Token = "0x20000EC")]
		public class GameDataMessage
		{
			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal ulong gameDataMsgId;

			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Core.OnlineUser fromUser;

			[Token(Token = "0x400077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal string receivedDate;

			[Token(Token = "0x400077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal string expiredDate;

			[Token(Token = "0x400077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal bool isPS4Available;

			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
			internal bool isPSVitaAvailable;

			[Token(Token = "0x4000781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal GameCustomDataTypes dataType;

			[Token(Token = "0x4000782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal string url;

			[Token(Token = "0x4000783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal GameDataMessageDetails details;

			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal bool hasDetails;

			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
			internal bool isUsed;

			[Token(Token = "0x170001C1")]
			public ulong GameDataMsgId
			{
				[Token(Token = "0x60004BF")]
				[Address(RVA = "0x251B90C", Offset = "0x251B90C", VA = "0x251B90C")]
				get
				{
					return default(ulong);
				}
			}

			[Token(Token = "0x170001C2")]
			public Core.OnlineUser FromUser
			{
				[Token(Token = "0x60004C0")]
				[Address(RVA = "0x251B914", Offset = "0x251B914", VA = "0x251B914")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001C3")]
			public string ReceivedDate
			{
				[Token(Token = "0x60004C1")]
				[Address(RVA = "0x251B91C", Offset = "0x251B91C", VA = "0x251B91C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001C4")]
			public string ExpiredDate
			{
				[Token(Token = "0x60004C2")]
				[Address(RVA = "0x251B924", Offset = "0x251B924", VA = "0x251B924")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001C5")]
			public bool IsPS4Available
			{
				[Token(Token = "0x60004C3")]
				[Address(RVA = "0x251B92C", Offset = "0x251B92C", VA = "0x251B92C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170001C6")]
			public bool IsPSVitaAvailable
			{
				[Token(Token = "0x60004C4")]
				[Address(RVA = "0x251B934", Offset = "0x251B934", VA = "0x251B934")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170001C7")]
			public GameCustomDataTypes DataType
			{
				[Token(Token = "0x60004C5")]
				[Address(RVA = "0x251B93C", Offset = "0x251B93C", VA = "0x251B93C")]
				get
				{
					return default(GameCustomDataTypes);
				}
			}

			[Token(Token = "0x170001C8")]
			public string Url
			{
				[Token(Token = "0x60004C6")]
				[Address(RVA = "0x251B944", Offset = "0x251B944", VA = "0x251B944")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001C9")]
			public GameDataMessageDetails Details
			{
				[Token(Token = "0x60004C7")]
				[Address(RVA = "0x251B94C", Offset = "0x251B94C", VA = "0x251B94C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001CA")]
			public bool HasDetails
			{
				[Token(Token = "0x60004C8")]
				[Address(RVA = "0x251B954", Offset = "0x251B954", VA = "0x251B954")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170001CB")]
			public bool IsUsed
			{
				[Token(Token = "0x60004C9")]
				[Address(RVA = "0x251B95C", Offset = "0x251B95C", VA = "0x251B95C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x251B964", Offset = "0x251B964", VA = "0x251B964")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x251BAFC", Offset = "0x251BAFC", VA = "0x251BAFC")]
			public GameDataMessage()
			{
			}
		}

		[Token(Token = "0x20000ED")]
		public class GameDataMessagesResponse : ResponseBase
		{
			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal GameDataMessage[] gameDataMessages;

			[Token(Token = "0x170001CC")]
			public GameDataMessage[] GameDataMessages
			{
				[Token(Token = "0x60004CC")]
				[Address(RVA = "0x251BF10", Offset = "0x251BF10", VA = "0x251BF10")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x251BF18", Offset = "0x251BF18", VA = "0x251BF18", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x251C138", Offset = "0x251C138", VA = "0x251C138")]
			public GameDataMessagesResponse()
			{
			}
		}

		[Token(Token = "0x20000EE")]
		public class GameDataMessageThumbnailResponse : ResponseBase
		{
			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal ulong gameDataMsgId;

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal byte[] thumbnail;

			[Token(Token = "0x170001CD")]
			public ulong GameDataMsgId
			{
				[Token(Token = "0x60004CF")]
				[Address(RVA = "0x251BDBC", Offset = "0x251BDBC", VA = "0x251BDBC")]
				get
				{
					return default(ulong);
				}
			}

			[Token(Token = "0x170001CE")]
			public byte[] Thumbnail
			{
				[Token(Token = "0x60004D0")]
				[Address(RVA = "0x251BDC4", Offset = "0x251BDC4", VA = "0x251BDC4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x251BDCC", Offset = "0x251BDCC", VA = "0x251BDCC", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x251BF08", Offset = "0x251BF08", VA = "0x251BF08")]
			public GameDataMessageThumbnailResponse()
			{
			}
		}

		[Token(Token = "0x20000EF")]
		public class GameDataMessageAttachmentResponse : ResponseBase
		{
			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal ulong gameDataMsgId;

			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal byte[] attachment;

			[Token(Token = "0x170001CF")]
			public ulong GameDataMsgId
			{
				[Token(Token = "0x60004D3")]
				[Address(RVA = "0x251BB64", Offset = "0x251BB64", VA = "0x251BB64")]
				get
				{
					return default(ulong);
				}
			}

			[Token(Token = "0x170001D0")]
			public byte[] Attachment
			{
				[Token(Token = "0x60004D4")]
				[Address(RVA = "0x251BB6C", Offset = "0x251BB6C", VA = "0x251BB6C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x251BB74", Offset = "0x251BB74", VA = "0x251BB74", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x251BCB0", Offset = "0x251BCB0", VA = "0x251BCB0")]
			public GameDataMessageAttachmentResponse()
			{
			}
		}

		[Token(Token = "0x20000F0")]
		public class NewInGameMessageResponse : ResponseBase
		{
			[Token(Token = "0x400078B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal byte[] message;

			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Core.OnlineUser sender;

			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Core.OnlineUser recipient;

			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal Core.PlatformType senderPlatformType;

			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal Core.PlatformType recipientPlatformType;

			[Token(Token = "0x170001D1")]
			public byte[] Message
			{
				[Token(Token = "0x60004D7")]
				[Address(RVA = "0x251C810", Offset = "0x251C810", VA = "0x251C810")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001D2")]
			public Core.OnlineUser Sender
			{
				[Token(Token = "0x60004D8")]
				[Address(RVA = "0x251C818", Offset = "0x251C818", VA = "0x251C818")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001D3")]
			public Core.OnlineUser Recipient
			{
				[Token(Token = "0x60004D9")]
				[Address(RVA = "0x251C820", Offset = "0x251C820", VA = "0x251C820")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001D4")]
			public Core.PlatformType SenderPlatformType
			{
				[Token(Token = "0x60004DA")]
				[Address(RVA = "0x251C828", Offset = "0x251C828", VA = "0x251C828")]
				get
				{
					return default(Core.PlatformType);
				}
			}

			[Token(Token = "0x170001D5")]
			public Core.PlatformType RecipientPlatformType
			{
				[Token(Token = "0x60004DB")]
				[Address(RVA = "0x251C830", Offset = "0x251C830", VA = "0x251C830")]
				get
				{
					return default(Core.PlatformType);
				}
			}

			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x251C838", Offset = "0x251C838", VA = "0x251C838", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x251C9A8", Offset = "0x251C9A8", VA = "0x251C9A8")]
			public NewInGameMessageResponse()
			{
			}
		}

		[Token(Token = "0x20000F1")]
		public class NewGameDataMessageResponse : ResponseBase
		{
			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Core.OnlineUser to;

			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Core.OnlineUser from;

			[Token(Token = "0x170001D6")]
			public Core.OnlineUser To
			{
				[Token(Token = "0x60004DE")]
				[Address(RVA = "0x251C62C", Offset = "0x251C62C", VA = "0x251C62C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001D7")]
			public Core.OnlineUser From
			{
				[Token(Token = "0x60004DF")]
				[Address(RVA = "0x251C634", Offset = "0x251C634", VA = "0x251C634")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x251C63C", Offset = "0x251C63C", VA = "0x251C63C", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x251C788", Offset = "0x251C788", VA = "0x251C788")]
			public NewGameDataMessageResponse()
			{
			}
		}

		[Token(Token = "0x20000F2")]
		public class GameCustomDataEventResponse : ResponseBase
		{
			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal ulong itemId;

			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Core.OnlineID onlineId;

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Core.UserServiceUserId userId;

			[Token(Token = "0x170001D8")]
			public ulong ItemId
			{
				[Token(Token = "0x60004E2")]
				[Address(RVA = "0x251B734", Offset = "0x251B734", VA = "0x251B734")]
				get
				{
					return default(ulong);
				}
			}

			[Token(Token = "0x170001D9")]
			public Core.OnlineID OnlineId
			{
				[Token(Token = "0x60004E3")]
				[Address(RVA = "0x251B73C", Offset = "0x251B73C", VA = "0x251B73C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001DA")]
			public Core.UserServiceUserId UserId
			{
				[Token(Token = "0x60004E4")]
				[Address(RVA = "0x251B744", Offset = "0x251B744", VA = "0x251B744")]
				get
				{
					return default(Core.UserServiceUserId);
				}
			}

			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x251B74C", Offset = "0x251B74C", VA = "0x251B74C", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x251B8A4", Offset = "0x251B8A4", VA = "0x251B8A4")]
			public GameCustomDataEventResponse()
			{
			}
		}

		[PreserveSig]
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x251A590", Offset = "0x251A590", VA = "0x251A590")]
		private static extern int PrxSendInGameMessage(SendInGameMessageRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x251A664", Offset = "0x251A664", VA = "0x251A664")]
		private static extern int PrxDisplayReceivedGameDataMessagesDialog(DisplayReceivedGameDataMessagesDialogRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x251A720", Offset = "0x251A720", VA = "0x251A720")]
		private static extern int PrxSendGameDataMessage(SendGameDataMessageRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x251A808", Offset = "0x251A808", VA = "0x251A808")]
		private static extern int PrxConsumeGameDataMessage(ConsumeGameDataMessageRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x251A8CC", Offset = "0x251A8CC", VA = "0x251A8CC")]
		private static extern int PrxGetReceivedGameDataMessages(GetReceivedGameDataMessagesRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x251A990", Offset = "0x251A990", VA = "0x251A990")]
		private static extern int PrxGetGameDataMessageThumbnail(GetGameDataMessageThumbnailRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x251AA54", Offset = "0x251AA54", VA = "0x251AA54")]
		private static extern int PrxGetGameDataMessageAttachment(GetGameDataMessageAttachmentRequest request, out APIResult result);

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x251AB18", Offset = "0x251AB18", VA = "0x251AB18")]
		public static int SendInGameMessage(SendInGameMessageRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x251AC2C", Offset = "0x251AC2C", VA = "0x251AC2C")]
		public static int DisplayReceivedGameDataMessagesDialog(DisplayReceivedGameDataMessagesDialogRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x251ADEC", Offset = "0x251ADEC", VA = "0x251ADEC")]
		public static int SendGameDataMessage(SendGameDataMessageRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x251AFFC", Offset = "0x251AFFC", VA = "0x251AFFC")]
		public static int ConsumeGameDataMessage(ConsumeGameDataMessageRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x251B1BC", Offset = "0x251B1BC", VA = "0x251B1BC")]
		public static int GetReceivedGameDataMessages(GetReceivedGameDataMessagesRequest request, GameDataMessagesResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x251B37C", Offset = "0x251B37C", VA = "0x251B37C")]
		public static int GetGameDataMessageThumbnail(GetGameDataMessageThumbnailRequest request, GameDataMessageThumbnailResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x251B53C", Offset = "0x251B53C", VA = "0x251B53C")]
		public static int GetGameDataMessageAttachment(GetGameDataMessageAttachmentRequest request, GameDataMessageAttachmentResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x251B6FC", Offset = "0x251B6FC", VA = "0x251B6FC")]
		public Messaging()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class NetworkUtils
	{
		[StructLayout(0)]
		[Token(Token = "0x20000F3")]
		public class GetBandwidthInfoRequest : RequestBase
		{
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x24E699C", Offset = "0x24E699C", VA = "0x24E699C")]
			public GetBandwidthInfoRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x20000F4")]
		public class GetBasicNetworkInfoRequest : RequestBase
		{
			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x24E69A8", Offset = "0x24E69A8", VA = "0x24E69A8")]
			public GetBasicNetworkInfoRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x20000F5")]
		public class GetDetailedNetworkInfoRequest : RequestBase
		{
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x24E69B4", Offset = "0x24E69B4", VA = "0x24E69B4")]
			public GetDetailedNetworkInfoRequest()
			{
			}
		}

		[Token(Token = "0x20000F6")]
		public enum NetworkConnectionState
		{
			[Token(Token = "0x4000796")]
			Disconnected,
			[Token(Token = "0x4000797")]
			Connecting,
			[Token(Token = "0x4000798")]
			ObtainingIP,
			[Token(Token = "0x4000799")]
			ObtainedIP
		}

		[Token(Token = "0x20000F7")]
		public struct NpBandwidthTestResult
		{
			[Token(Token = "0x400079A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal double uploadBps;

			[Token(Token = "0x400079B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal double downloadBps;

			[Token(Token = "0x400079C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int result;

			[Token(Token = "0x170001DB")]
			public double UploadBps
			{
				[Token(Token = "0x60004EA")]
				[Address(RVA = "0x24E6F24", Offset = "0x24E6F24", VA = "0x24E6F24")]
				get
				{
					return default(double);
				}
			}

			[Token(Token = "0x170001DC")]
			public double DownloadBps
			{
				[Token(Token = "0x60004EB")]
				[Address(RVA = "0x24E6F2C", Offset = "0x24E6F2C", VA = "0x24E6F2C")]
				get
				{
					return default(double);
				}
			}

			[Token(Token = "0x60004EC")]
			[Address(RVA = "0x24E6370", Offset = "0x24E6370", VA = "0x24E6370")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x24E6F34", Offset = "0x24E6F34", VA = "0x24E6F34", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x20000F8")]
		public struct NetInAddr
		{
			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal uint addr;

			[Token(Token = "0x170001DD")]
			public uint Addr
			{
				[Token(Token = "0x60004EE")]
				[Address(RVA = "0x24E6DEC", Offset = "0x24E6DEC", VA = "0x24E6DEC")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x60004EF")]
				[Address(RVA = "0x24E6DF4", Offset = "0x24E6DF4", VA = "0x24E6DF4")]
				set
				{
				}
			}

			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x24E69D8", Offset = "0x24E69D8", VA = "0x24E69D8")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x24E6BF4", Offset = "0x24E6BF4", VA = "0x24E6BF4", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x20000F9")]
		public enum RouterNatType
		{
			[Token(Token = "0x400079F")]
			Type1 = 1,
			[Token(Token = "0x40007A0")]
			Type2,
			[Token(Token = "0x40007A1")]
			Type3
		}

		[Token(Token = "0x20000FA")]
		public enum RouterStun
		{
			[Token(Token = "0x40007A3")]
			Unchecked,
			[Token(Token = "0x40007A4")]
			Failed,
			[Token(Token = "0x40007A5")]
			OK
		}

		[Token(Token = "0x20000FB")]
		public struct NatRouterInfo
		{
			[Token(Token = "0x40007A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal RouterStun stunStatus;

			[Token(Token = "0x40007A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal RouterNatType natType;

			[Token(Token = "0x40007A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal NetInAddr mappedAddr;

			[Token(Token = "0x170001DE")]
			public RouterStun StunStatus
			{
				[Token(Token = "0x60004F2")]
				[Address(RVA = "0x24E69C0", Offset = "0x24E69C0", VA = "0x24E69C0")]
				get
				{
					return default(RouterStun);
				}
			}

			[Token(Token = "0x170001DF")]
			public RouterNatType NatType
			{
				[Token(Token = "0x60004F3")]
				[Address(RVA = "0x24E69C8", Offset = "0x24E69C8", VA = "0x24E69C8")]
				get
				{
					return default(RouterNatType);
				}
			}

			[Token(Token = "0x170001E0")]
			public NetInAddr MappedAddr
			{
				[Token(Token = "0x60004F4")]
				[Address(RVA = "0x24E69D0", Offset = "0x24E69D0", VA = "0x24E69D0")]
				get
				{
					return default(NetInAddr);
				}
			}

			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x24E6548", Offset = "0x24E6548", VA = "0x24E6548")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x24E6A0C", Offset = "0x24E6A0C", VA = "0x24E6A0C", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x20000FC")]
		public struct NetEtherAddr
		{
			[Token(Token = "0x40007A9")]
			public const int SCE_NET_ETHER_ADDR_LEN = 6;

			[Token(Token = "0x40007AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal byte[] data;

			[Token(Token = "0x170001E1")]
			public byte[] Data
			{
				[Token(Token = "0x60004F7")]
				[Address(RVA = "0x24E6D00", Offset = "0x24E6D00", VA = "0x24E6D00")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x24E68BC", Offset = "0x24E68BC", VA = "0x24E68BC")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x24E6D08", Offset = "0x24E6D08", VA = "0x24E6D08", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x20000FD")]
		public class BandwidthInfoResponse : ResponseBase
		{
			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal NpBandwidthTestResult bandwidth;

			[Token(Token = "0x170001E2")]
			public NpBandwidthTestResult Bandwidth
			{
				[Token(Token = "0x60004FA")]
				[Address(RVA = "0x24E5FD4", Offset = "0x24E5FD4", VA = "0x24E5FD4")]
				get
				{
					return default(NpBandwidthTestResult);
				}
			}

			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x24E5FE8", Offset = "0x24E5FE8", VA = "0x24E5FE8", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x24E63E4", Offset = "0x24E63E4", VA = "0x24E63E4")]
			public BandwidthInfoResponse()
			{
			}
		}

		[Token(Token = "0x20000FE")]
		public class BasicNetworkInfoResponse : ResponseBase
		{
			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal string ipAddress;

			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal NatRouterInfo natInfo;

			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal NetworkConnectionState connectionStatus;

			[Token(Token = "0x170001E3")]
			public string IpAddress
			{
				[Token(Token = "0x60004FD")]
				[Address(RVA = "0x24E63F4", Offset = "0x24E63F4", VA = "0x24E63F4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001E4")]
			public NatRouterInfo NatInfo
			{
				[Token(Token = "0x60004FE")]
				[Address(RVA = "0x24E63FC", Offset = "0x24E63FC", VA = "0x24E63FC")]
				get
				{
					return default(NatRouterInfo);
				}
			}

			[Token(Token = "0x170001E5")]
			public NetworkConnectionState ConnectionStatus
			{
				[Token(Token = "0x60004FF")]
				[Address(RVA = "0x24E640C", Offset = "0x24E640C", VA = "0x24E640C")]
				get
				{
					return default(NetworkConnectionState);
				}
			}

			[Token(Token = "0x6000500")]
			[Address(RVA = "0x24E6414", Offset = "0x24E6414", VA = "0x24E6414", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x6000501")]
			[Address(RVA = "0x24E65A0", Offset = "0x24E65A0", VA = "0x24E65A0")]
			public BasicNetworkInfoResponse()
			{
			}
		}

		[Token(Token = "0x20000FF")]
		public enum NetworkDevice
		{
			[Token(Token = "0x40007B0")]
			Wired,
			[Token(Token = "0x40007B1")]
			Wireless
		}

		[Token(Token = "0x2000100")]
		public enum NetworkLink
		{
			[Token(Token = "0x40007B3")]
			Disconnected,
			[Token(Token = "0x40007B4")]
			Connected
		}

		[Token(Token = "0x2000101")]
		public enum WfiSecurity
		{
			[Token(Token = "0x40007B6")]
			NoSecurity,
			[Token(Token = "0x40007B7")]
			WEP,
			[Token(Token = "0x40007B8")]
			WPAPSK_WPA2PSK,
			[Token(Token = "0x40007B9")]
			WPAPSK_TKIP,
			[Token(Token = "0x40007BA")]
			WPAPSK_AES,
			[Token(Token = "0x40007BB")]
			WPA2PSK_TKIP,
			[Token(Token = "0x40007BC")]
			WPA2PSK_AES,
			[Token(Token = "0x40007BD")]
			Unsupported
		}

		[Token(Token = "0x2000102")]
		public enum NetworkIPConfig
		{
			[Token(Token = "0x40007BF")]
			DHCP,
			[Token(Token = "0x40007C0")]
			Static,
			[Token(Token = "0x40007C1")]
			PPPoE
		}

		[Token(Token = "0x2000103")]
		public enum NetworkHTTPProxyConfig
		{
			[Token(Token = "0x40007C3")]
			Off,
			[Token(Token = "0x40007C4")]
			On
		}

		[Token(Token = "0x2000104")]
		public class DetailedNetworkInfoResponse : ResponseBase
		{
			[Token(Token = "0x40007C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal NatRouterInfo natInfo;

			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal NetworkConnectionState connectionStatus;

			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal NetworkDevice device;

			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal NetEtherAddr ethernetAddress;

			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal byte rssiPercentage;

			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
			internal byte channel;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			internal uint mtu;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal NetworkLink link;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			internal WfiSecurity wifiSecurity;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal NetworkIPConfig ipConfig;

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			internal NetworkHTTPProxyConfig httpProxyConfig;

			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal ushort httpProxyPort;

			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal NetEtherAddr bssid;

			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			internal string ssid;

			[Token(Token = "0x40007D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			internal string dhcpHostname;

			[Token(Token = "0x40007D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			internal string pppoeAuthName;

			[Token(Token = "0x40007D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			internal string ipAddress;

			[Token(Token = "0x40007D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			internal string netmask;

			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			internal string defaultRoute;

			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			internal string primaryDNS;

			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			internal string secondaryDNS;

			[Token(Token = "0x40007DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			internal string httpProxyServer;

			[Token(Token = "0x170001E6")]
			public NatRouterInfo NatInfo
			{
				[Token(Token = "0x6000502")]
				[Address(RVA = "0x24E65A8", Offset = "0x24E65A8", VA = "0x24E65A8")]
				get
				{
					return default(NatRouterInfo);
				}
			}

			[Token(Token = "0x170001E7")]
			public NetworkConnectionState ConnectionStatus
			{
				[Token(Token = "0x6000503")]
				[Address(RVA = "0x24E65B8", Offset = "0x24E65B8", VA = "0x24E65B8")]
				get
				{
					return default(NetworkConnectionState);
				}
			}

			[Token(Token = "0x170001E8")]
			public NetworkDevice Device
			{
				[Token(Token = "0x6000504")]
				[Address(RVA = "0x24E65C0", Offset = "0x24E65C0", VA = "0x24E65C0")]
				get
				{
					return default(NetworkDevice);
				}
			}

			[Token(Token = "0x170001E9")]
			public NetEtherAddr EthernetAddress
			{
				[Token(Token = "0x6000505")]
				[Address(RVA = "0x24E65C8", Offset = "0x24E65C8", VA = "0x24E65C8")]
				get
				{
					return default(NetEtherAddr);
				}
			}

			[Token(Token = "0x170001EA")]
			public byte RssiPercentage
			{
				[Token(Token = "0x6000506")]
				[Address(RVA = "0x24E65D0", Offset = "0x24E65D0", VA = "0x24E65D0")]
				get
				{
					return default(byte);
				}
			}

			[Token(Token = "0x170001EB")]
			public byte Channel
			{
				[Token(Token = "0x6000507")]
				[Address(RVA = "0x24E65D8", Offset = "0x24E65D8", VA = "0x24E65D8")]
				get
				{
					return default(byte);
				}
			}

			[Token(Token = "0x170001EC")]
			public uint MTU
			{
				[Token(Token = "0x6000508")]
				[Address(RVA = "0x24E65E0", Offset = "0x24E65E0", VA = "0x24E65E0")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x170001ED")]
			public NetworkLink Link
			{
				[Token(Token = "0x6000509")]
				[Address(RVA = "0x24E65E8", Offset = "0x24E65E8", VA = "0x24E65E8")]
				get
				{
					return default(NetworkLink);
				}
			}

			[Token(Token = "0x170001EE")]
			public WfiSecurity WifiSecurity
			{
				[Token(Token = "0x600050A")]
				[Address(RVA = "0x24E65F0", Offset = "0x24E65F0", VA = "0x24E65F0")]
				get
				{
					return default(WfiSecurity);
				}
			}

			[Token(Token = "0x170001EF")]
			public NetworkIPConfig IpConfig
			{
				[Token(Token = "0x600050B")]
				[Address(RVA = "0x24E65F8", Offset = "0x24E65F8", VA = "0x24E65F8")]
				get
				{
					return default(NetworkIPConfig);
				}
			}

			[Token(Token = "0x170001F0")]
			public NetworkHTTPProxyConfig HttpProxyConfig
			{
				[Token(Token = "0x600050C")]
				[Address(RVA = "0x24E6600", Offset = "0x24E6600", VA = "0x24E6600")]
				get
				{
					return default(NetworkHTTPProxyConfig);
				}
			}

			[Token(Token = "0x170001F1")]
			public ushort HttpProxyPort
			{
				[Token(Token = "0x600050D")]
				[Address(RVA = "0x24E6608", Offset = "0x24E6608", VA = "0x24E6608")]
				get
				{
					return default(ushort);
				}
			}

			[Token(Token = "0x170001F2")]
			public NetEtherAddr BSSID
			{
				[Token(Token = "0x600050E")]
				[Address(RVA = "0x24E6610", Offset = "0x24E6610", VA = "0x24E6610")]
				get
				{
					return default(NetEtherAddr);
				}
			}

			[Token(Token = "0x170001F3")]
			public string SSID
			{
				[Token(Token = "0x600050F")]
				[Address(RVA = "0x24E6618", Offset = "0x24E6618", VA = "0x24E6618")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001F4")]
			public string DhcpHostname
			{
				[Token(Token = "0x6000510")]
				[Address(RVA = "0x24E6620", Offset = "0x24E6620", VA = "0x24E6620")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001F5")]
			public string PPPoeAuthName
			{
				[Token(Token = "0x6000511")]
				[Address(RVA = "0x24E6628", Offset = "0x24E6628", VA = "0x24E6628")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001F6")]
			public string IpAddress
			{
				[Token(Token = "0x6000512")]
				[Address(RVA = "0x24E6630", Offset = "0x24E6630", VA = "0x24E6630")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001F7")]
			public string Netmask
			{
				[Token(Token = "0x6000513")]
				[Address(RVA = "0x24E6638", Offset = "0x24E6638", VA = "0x24E6638")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001F8")]
			public string DefaultRoute
			{
				[Token(Token = "0x6000514")]
				[Address(RVA = "0x24E6640", Offset = "0x24E6640", VA = "0x24E6640")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001F9")]
			public string PrimaryDNS
			{
				[Token(Token = "0x6000515")]
				[Address(RVA = "0x24E6648", Offset = "0x24E6648", VA = "0x24E6648")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001FA")]
			public string SecondaryDNS
			{
				[Token(Token = "0x6000516")]
				[Address(RVA = "0x24E6650", Offset = "0x24E6650", VA = "0x24E6650")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001FB")]
			public string HttpProxyServer
			{
				[Token(Token = "0x6000517")]
				[Address(RVA = "0x24E6658", Offset = "0x24E6658", VA = "0x24E6658")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000518")]
			[Address(RVA = "0x24E6660", Offset = "0x24E6660", VA = "0x24E6660", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x6000519")]
			[Address(RVA = "0x24E6934", Offset = "0x24E6934", VA = "0x24E6934")]
			public DetailedNetworkInfoResponse()
			{
			}
		}

		[Token(Token = "0x2000105")]
		public enum NetworkEvent
		{
			[Token(Token = "0x40007DC")]
			none,
			[Token(Token = "0x40007DD")]
			networkConnected,
			[Token(Token = "0x40007DE")]
			networkDisconnected
		}

		[Token(Token = "0x2000106")]
		public class NetStateChangeResponse : ResponseBase
		{
			[Token(Token = "0x40007DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal NetworkEvent netEvent;

			[Token(Token = "0x170001FC")]
			public NetworkEvent NetEvent
			{
				[Token(Token = "0x600051A")]
				[Address(RVA = "0x24E6DFC", Offset = "0x24E6DFC", VA = "0x24E6DFC")]
				get
				{
					return default(NetworkEvent);
				}
			}

			[Token(Token = "0x600051B")]
			[Address(RVA = "0x24E6E04", Offset = "0x24E6E04", VA = "0x24E6E04", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x600051C")]
			[Address(RVA = "0x24E6F1C", Offset = "0x24E6F1C", VA = "0x24E6F1C")]
			public NetStateChangeResponse()
			{
			}
		}

		[PreserveSig]
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x24E58BC", Offset = "0x24E58BC", VA = "0x24E58BC")]
		private static extern int PrxGetBandwidthInfo(GetBandwidthInfoRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x24E5978", Offset = "0x24E5978", VA = "0x24E5978")]
		private static extern int PrxGetBasicNetworkInfo(GetBasicNetworkInfoRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x24E5A34", Offset = "0x24E5A34", VA = "0x24E5A34")]
		private static extern int PrxGetDetailedNetworkInfo(GetDetailedNetworkInfoRequest request, out APIResult result);

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x24E5AF0", Offset = "0x24E5AF0", VA = "0x24E5AF0")]
		public static int GetBandwidthInfo(GetBandwidthInfoRequest request, BandwidthInfoResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x24E5DBC", Offset = "0x24E5DBC", VA = "0x24E5DBC")]
		public static int GetBasicNetworkInfoInfo(GetBasicNetworkInfoRequest request, BasicNetworkInfoResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x24E5EC4", Offset = "0x24E5EC4", VA = "0x24E5EC4")]
		public static int GetDetailedNetworkInfo(GetDetailedNetworkInfoRequest request, DetailedNetworkInfoResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x24E5FCC", Offset = "0x24E5FCC", VA = "0x24E5FCC")]
		public NetworkUtils()
		{
		}
	}
	[Token(Token = "0x2000035")]
	internal class Notifications
	{
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x24E70B4", Offset = "0x24E70B4", VA = "0x24E70B4")]
		internal static ResponseBase CreateNotificationResponse(FunctionTypes notificationType)
		{
			return null;
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x24E73AC", Offset = "0x24E73AC", VA = "0x24E73AC")]
		public Notifications()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class NpUtils
	{
		[StructLayout(0)]
		[Token(Token = "0x2000107")]
		public class SetTitleIdForDevelopmentRequest : RequestBase
		{
			[Token(Token = "0x40007E0")]
			private const int SCE_NP_TITLE_ID_LEN = 12;

			[Token(Token = "0x40007E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string titleId;

			[Token(Token = "0x40007E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string titleSecretString;

			[Token(Token = "0x40007E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public uint titleSecretStringSize;

			[Token(Token = "0x600051D")]
			[Address(RVA = "0x24E88A0", Offset = "0x24E88A0", VA = "0x24E88A0")]
			public SetTitleIdForDevelopmentRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x2000108")]
		public class DisplaySigninDialogRequest : RequestBase
		{
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x24E8714", Offset = "0x24E8714", VA = "0x24E8714")]
			public DisplaySigninDialogRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x2000109")]
		public class CheckAvailablityRequest : RequestBase
		{
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x24E85AC", Offset = "0x24E85AC", VA = "0x24E85AC")]
			public CheckAvailablityRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x200010A")]
		public class CheckPlusRequest : RequestBase
		{
			[Token(Token = "0x40007E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ulong features;

			[Token(Token = "0x6000520")]
			[Address(RVA = "0x24E85B8", Offset = "0x24E85B8", VA = "0x24E85B8")]
			public CheckPlusRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x200010B")]
		public class GetParentalControlInfoRequest : RequestBase
		{
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x24E8720", Offset = "0x24E8720", VA = "0x24E8720")]
			public GetParentalControlInfoRequest()
			{
			}
		}

		[Token(Token = "0x200010C")]
		public class CheckPlusResponse : ResponseBase
		{
			[Token(Token = "0x40007E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal bool authorized;

			[Token(Token = "0x170001FD")]
			public bool Authorized
			{
				[Token(Token = "0x6000522")]
				[Address(RVA = "0x24E85E8", Offset = "0x24E85E8", VA = "0x24E85E8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000523")]
			[Address(RVA = "0x24E85F0", Offset = "0x24E85F0", VA = "0x24E85F0", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x6000524")]
			[Address(RVA = "0x24E870C", Offset = "0x24E870C", VA = "0x24E870C")]
			public CheckPlusResponse()
			{
			}
		}

		[Token(Token = "0x200010D")]
		public class GetParentalControlInfoResponse : ResponseBase
		{
			[Token(Token = "0x40007E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int age;

			[Token(Token = "0x40007E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal bool contentRestriction;

			[Token(Token = "0x40007E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
			internal bool chatRestriction;

			[Token(Token = "0x40007E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
			internal bool ugcRestriction;

			[Token(Token = "0x170001FE")]
			public int Age
			{
				[Token(Token = "0x6000525")]
				[Address(RVA = "0x24E872C", Offset = "0x24E872C", VA = "0x24E872C")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x170001FF")]
			public bool ChatRestriction
			{
				[Token(Token = "0x6000526")]
				[Address(RVA = "0x24E8734", Offset = "0x24E8734", VA = "0x24E8734")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000200")]
			public bool UGCRestriction
			{
				[Token(Token = "0x6000527")]
				[Address(RVA = "0x24E873C", Offset = "0x24E873C", VA = "0x24E873C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000528")]
			[Address(RVA = "0x24E8744", Offset = "0x24E8744", VA = "0x24E8744", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x6000529")]
			[Address(RVA = "0x24E8898", Offset = "0x24E8898", VA = "0x24E8898")]
			public GetParentalControlInfoResponse()
			{
			}
		}

		[Token(Token = "0x200010E")]
		public enum SignInState
		{
			[Token(Token = "0x40007EB")]
			unknown,
			[Token(Token = "0x40007EC")]
			signedOut,
			[Token(Token = "0x40007ED")]
			signedIn
		}

		[Token(Token = "0x200010F")]
		public enum LogInState
		{
			[Token(Token = "0x40007EF")]
			loggedIn,
			[Token(Token = "0x40007F0")]
			loggedOut,
			[Token(Token = "0x40007F1")]
			unknown
		}

		[Token(Token = "0x2000110")]
		public enum StateChanged
		{
			[Token(Token = "0x40007F3")]
			none,
			[Token(Token = "0x40007F4")]
			signedInState,
			[Token(Token = "0x40007F5")]
			loggedInState
		}

		[Token(Token = "0x2000111")]
		public class UserStateChangeResponse : ResponseBase
		{
			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Core.UserServiceUserId userId;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal SignInState currentSignInState;

			[Token(Token = "0x40007F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal LogInState currentLogInState;

			[Token(Token = "0x40007F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal StateChanged stateChanged;

			[Token(Token = "0x17000201")]
			public Core.UserServiceUserId UserId
			{
				[Token(Token = "0x600052A")]
				[Address(RVA = "0x24E8904", Offset = "0x24E8904", VA = "0x24E8904")]
				get
				{
					return default(Core.UserServiceUserId);
				}
			}

			[Token(Token = "0x17000202")]
			public SignInState CurrentSignInState
			{
				[Token(Token = "0x600052B")]
				[Address(RVA = "0x24E890C", Offset = "0x24E890C", VA = "0x24E890C")]
				get
				{
					return default(SignInState);
				}
			}

			[Token(Token = "0x17000203")]
			public LogInState CurrentLogInState
			{
				[Token(Token = "0x600052C")]
				[Address(RVA = "0x24E8914", Offset = "0x24E8914", VA = "0x24E8914")]
				get
				{
					return default(LogInState);
				}
			}

			[Token(Token = "0x17000204")]
			public StateChanged StateChanged
			{
				[Token(Token = "0x600052D")]
				[Address(RVA = "0x24E891C", Offset = "0x24E891C", VA = "0x24E891C")]
				get
				{
					return default(StateChanged);
				}
			}

			[Token(Token = "0x600052E")]
			[Address(RVA = "0x24E8924", Offset = "0x24E8924", VA = "0x24E8924", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x600052F")]
			[Address(RVA = "0x24E730C", Offset = "0x24E730C", VA = "0x24E730C")]
			public UserStateChangeResponse()
			{
			}
		}

		[PreserveSig]
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x24E7B68", Offset = "0x24E7B68", VA = "0x24E7B68")]
		private static extern int PrxSetTitleIdForDevelopment(SetTitleIdForDevelopmentRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x24E7C40", Offset = "0x24E7C40", VA = "0x24E7C40")]
		private static extern int PrxDisplaySigninDialog(DisplaySigninDialogRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x24E7CFC", Offset = "0x24E7CFC", VA = "0x24E7CFC")]
		private static extern int PrxCheckAvailablity(CheckAvailablityRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x24E7DB8", Offset = "0x24E7DB8", VA = "0x24E7DB8")]
		private static extern int PrxCheckPlus(CheckPlusRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x24E7E7C", Offset = "0x24E7E7C", VA = "0x24E7E7C")]
		private static extern int PrxGetParentalControlInfo(GetParentalControlInfoRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x24E7F38", Offset = "0x24E7F38", VA = "0x24E7F38")]
		private static extern void PrxNotifyPlusFeature(int userId, ulong features, out APIResult result);

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x24E7FCC", Offset = "0x24E7FCC", VA = "0x24E7FCC")]
		public static int SetTitleIdForDevelopment(SetTitleIdForDevelopmentRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x24E80D4", Offset = "0x24E80D4", VA = "0x24E80D4")]
		public static int DisplaySigninDialog(DisplaySigninDialogRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x24E81DC", Offset = "0x24E81DC", VA = "0x24E81DC")]
		public static int CheckAvailablity(CheckAvailablityRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x24E82E4", Offset = "0x24E82E4", VA = "0x24E82E4")]
		public static int CheckPlus(CheckPlusRequest request, CheckPlusResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x24E83EC", Offset = "0x24E83EC", VA = "0x24E83EC")]
		public static int GetParentalControlInfo(GetParentalControlInfoRequest request, GetParentalControlInfoResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x24E84F4", Offset = "0x24E84F4", VA = "0x24E84F4")]
		public static void NotifyPlusFeature(Core.UserServiceUserId userId)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x24E85A4", Offset = "0x24E85A4", VA = "0x24E85A4")]
		public NpUtils()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class Presence
	{
		[StructLayout(0)]
		[Token(Token = "0x2000112")]
		public class DeletePresenceRequest : RequestBase
		{
			[Token(Token = "0x40007FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal bool deleteGameData;

			[Token(Token = "0x40007FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			internal bool deleteGameStatus;

			[Token(Token = "0x17000205")]
			public bool DeleteGameData
			{
				[Token(Token = "0x6000530")]
				[Address(RVA = "0x24EB060", Offset = "0x24EB060", VA = "0x24EB060")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000531")]
				[Address(RVA = "0x24EB068", Offset = "0x24EB068", VA = "0x24EB068")]
				set
				{
				}
			}

			[Token(Token = "0x17000206")]
			public bool DeleteGameStatus
			{
				[Token(Token = "0x6000532")]
				[Address(RVA = "0x24EB074", Offset = "0x24EB074", VA = "0x24EB074")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000533")]
				[Address(RVA = "0x24EB07C", Offset = "0x24EB07C", VA = "0x24EB07C")]
				set
				{
				}
			}

			[Token(Token = "0x6000534")]
			[Address(RVA = "0x24EB088", Offset = "0x24EB088", VA = "0x24EB088")]
			public DeletePresenceRequest()
			{
			}
		}

		[Token(Token = "0x2000113")]
		public struct LocalizedGameStatus
		{
			[Token(Token = "0x40007FC")]
			public const int MAX_SIZE_LOCALIZED_GAME_STATUS = 96;

			[Token(Token = "0x40007FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal string languageCode;

			[Token(Token = "0x40007FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal string gameStatus;

			[Token(Token = "0x17000207")]
			public Core.LanguageCode LanguageCode
			{
				[Token(Token = "0x6000535")]
				[Address(RVA = "0x24EB110", Offset = "0x24EB110", VA = "0x24EB110")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000536")]
				[Address(RVA = "0x24EB180", Offset = "0x24EB180", VA = "0x24EB180")]
				set
				{
				}
			}

			[Token(Token = "0x17000208")]
			public string GameStatus
			{
				[Token(Token = "0x6000537")]
				[Address(RVA = "0x24EB19C", Offset = "0x24EB19C", VA = "0x24EB19C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000538")]
				[Address(RVA = "0x24EB1A4", Offset = "0x24EB1A4", VA = "0x24EB1A4")]
				set
				{
				}
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x2000114")]
		public class SetPresenceRequest : RequestBase
		{
			[Token(Token = "0x40007FF")]
			public const int MAX_LOCALIZED_STATUSES = 50;

			[Token(Token = "0x4000800")]
			public const int MAX_SIZE_GAME_DATA = 128;

			[Token(Token = "0x4000801")]
			public const int MAX_SIZE_DEFAULT_GAME_STATUS = 191;

			[Token(Token = "0x4000802")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal string defaultGameStatus;

			[Token(Token = "0x4000803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal LocalizedGameStatus[] localizedGameStatuses;

			[Token(Token = "0x4000804")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal uint numLocalizedGameStatuses;

			[Token(Token = "0x4000805")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal byte[] binaryGameData;

			[Token(Token = "0x4000806")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal uint binaryGameDataSize;

			[Token(Token = "0x17000209")]
			public string DefaultGameStatus
			{
				[Token(Token = "0x6000539")]
				[Address(RVA = "0x24EBC38", Offset = "0x24EBC38", VA = "0x24EBC38")]
				get
				{
					return null;
				}
				[Token(Token = "0x600053A")]
				[Address(RVA = "0x24EBC40", Offset = "0x24EBC40", VA = "0x24EBC40")]
				set
				{
				}
			}

			[Token(Token = "0x1700020A")]
			public LocalizedGameStatus[] LocalizedGameStatuses
			{
				[Token(Token = "0x600053B")]
				[Address(RVA = "0x24EBD20", Offset = "0x24EBD20", VA = "0x24EBD20")]
				get
				{
					return null;
				}
				[Token(Token = "0x600053C")]
				[Address(RVA = "0x24EBDA0", Offset = "0x24EBDA0", VA = "0x24EBDA0")]
				set
				{
				}
			}

			[Token(Token = "0x1700020B")]
			public byte[] BinaryGameData
			{
				[Token(Token = "0x600053D")]
				[Address(RVA = "0x24EBE90", Offset = "0x24EBE90", VA = "0x24EBE90")]
				get
				{
					return null;
				}
				[Token(Token = "0x600053E")]
				[Address(RVA = "0x24EBF14", Offset = "0x24EBF14", VA = "0x24EBF14")]
				set
				{
				}
			}

			[Token(Token = "0x600053F")]
			[Address(RVA = "0x24EC010", Offset = "0x24EC010", VA = "0x24EC010")]
			public SetPresenceRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x2000115")]
		public class GetPresenceRequest : RequestBase
		{
			[Token(Token = "0x4000807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Core.NpAccountId fromUser;

			[Token(Token = "0x4000808")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal bool inContext;

			[Token(Token = "0x1700020C")]
			public Core.NpAccountId FromUser
			{
				[Token(Token = "0x6000540")]
				[Address(RVA = "0x24EB0B8", Offset = "0x24EB0B8", VA = "0x24EB0B8")]
				get
				{
					return default(Core.NpAccountId);
				}
				[Token(Token = "0x6000541")]
				[Address(RVA = "0x24EB0C0", Offset = "0x24EB0C0", VA = "0x24EB0C0")]
				set
				{
				}
			}

			[Token(Token = "0x1700020D")]
			public bool InContext
			{
				[Token(Token = "0x6000542")]
				[Address(RVA = "0x24EB0C8", Offset = "0x24EB0C8", VA = "0x24EB0C8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000543")]
				[Address(RVA = "0x24EB0D0", Offset = "0x24EB0D0", VA = "0x24EB0D0")]
				set
				{
				}
			}

			[Token(Token = "0x6000544")]
			[Address(RVA = "0x24EB0DC", Offset = "0x24EB0DC", VA = "0x24EB0DC")]
			public GetPresenceRequest()
			{
			}
		}

		[Token(Token = "0x2000116")]
		public class PlatformPresence
		{
			[Token(Token = "0x4000809")]
			public const int MAX_SIZE_TITLE_NAME = 127;

			[Token(Token = "0x400080A")]
			public const int MAX_SIZE_GAME_STATUS = 191;

			[Token(Token = "0x400080B")]
			public const int MAX_SIZE_GAME_DATA = 128;

			[Token(Token = "0x400080C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Core.OnlineStatus onlineStatusOnPlatform;

			[Token(Token = "0x400080D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal Core.PlatformType platform;

			[Token(Token = "0x400080E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Core.TitleId titleId;

			[Token(Token = "0x400080F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal string titleName;

			[Token(Token = "0x4000810")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal string gameStatus;

			[Token(Token = "0x4000811")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal byte[] binaryGameData;

			[Token(Token = "0x1700020E")]
			public Core.OnlineStatus OnlineStatusOnPlatform
			{
				[Token(Token = "0x6000545")]
				[Address(RVA = "0x24EB284", Offset = "0x24EB284", VA = "0x24EB284")]
				get
				{
					return default(Core.OnlineStatus);
				}
			}

			[Token(Token = "0x1700020F")]
			public Core.PlatformType Platform
			{
				[Token(Token = "0x6000546")]
				[Address(RVA = "0x24EB28C", Offset = "0x24EB28C", VA = "0x24EB28C")]
				get
				{
					return default(Core.PlatformType);
				}
			}

			[Token(Token = "0x17000210")]
			public Core.TitleId TitleId
			{
				[Token(Token = "0x6000547")]
				[Address(RVA = "0x24EB294", Offset = "0x24EB294", VA = "0x24EB294")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000211")]
			public string TitleName
			{
				[Token(Token = "0x6000548")]
				[Address(RVA = "0x24EB29C", Offset = "0x24EB29C", VA = "0x24EB29C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000212")]
			public string GameStatus
			{
				[Token(Token = "0x6000549")]
				[Address(RVA = "0x24EB2A4", Offset = "0x24EB2A4", VA = "0x24EB2A4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000213")]
			public byte[] BinaryGameData
			{
				[Token(Token = "0x600054A")]
				[Address(RVA = "0x24EB2AC", Offset = "0x24EB2AC", VA = "0x24EB2AC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600054B")]
			[Address(RVA = "0x24EB2B4", Offset = "0x24EB2B4", VA = "0x24EB2B4")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x600054C")]
			[Address(RVA = "0x24EB360", Offset = "0x24EB360", VA = "0x24EB360", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x600054D")]
			[Address(RVA = "0x24EB50C", Offset = "0x24EB50C", VA = "0x24EB50C")]
			public PlatformPresence()
			{
			}
		}

		[Token(Token = "0x2000117")]
		public class UserPresence
		{
			[Token(Token = "0x4000812")]
			public const int MAX_NUM_PLATFORM_PRESENCE = 3;

			[Token(Token = "0x4000813")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Core.OnlineUser user;

			[Token(Token = "0x4000814")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Core.OnlineStatus psnOnlineStatus;

			[Token(Token = "0x4000815")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal Core.PlatformType mostRelevantPlatform;

			[Token(Token = "0x4000816")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal PlatformPresence[] platforms;

			[Token(Token = "0x17000214")]
			public Core.OnlineUser User
			{
				[Token(Token = "0x600054E")]
				[Address(RVA = "0x24EC0A8", Offset = "0x24EC0A8", VA = "0x24EC0A8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000215")]
			public Core.OnlineStatus PsnOnlineStatus
			{
				[Token(Token = "0x600054F")]
				[Address(RVA = "0x24EC0B0", Offset = "0x24EC0B0", VA = "0x24EC0B0")]
				get
				{
					return default(Core.OnlineStatus);
				}
			}

			[Token(Token = "0x17000216")]
			public Core.PlatformType MostRelevantPlatform
			{
				[Token(Token = "0x6000550")]
				[Address(RVA = "0x24EC0B8", Offset = "0x24EC0B8", VA = "0x24EC0B8")]
				get
				{
					return default(Core.PlatformType);
				}
			}

			[Token(Token = "0x17000217")]
			public PlatformPresence[] Platforms
			{
				[Token(Token = "0x6000551")]
				[Address(RVA = "0x24EC0C0", Offset = "0x24EC0C0", VA = "0x24EC0C0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000552")]
			[Address(RVA = "0x24EB890", Offset = "0x24EB890", VA = "0x24EB890")]
			internal UserPresence()
			{
			}

			[Token(Token = "0x6000553")]
			[Address(RVA = "0x24EB684", Offset = "0x24EB684", VA = "0x24EB684")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x6000554")]
			[Address(RVA = "0x24EC0C8", Offset = "0x24EC0C8", VA = "0x24EC0C8", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x2000118")]
		public class PresenceResponse : ResponseBase
		{
			[Token(Token = "0x4000817")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal UserPresence userPresence;

			[Token(Token = "0x17000218")]
			public UserPresence UserPresence
			{
				[Token(Token = "0x6000555")]
				[Address(RVA = "0x24EB584", Offset = "0x24EB584", VA = "0x24EB584")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000556")]
			[Address(RVA = "0x24EB58C", Offset = "0x24EB58C", VA = "0x24EB58C", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x6000557")]
			[Address(RVA = "0x24EB82C", Offset = "0x24EB82C", VA = "0x24EB82C")]
			public PresenceResponse()
			{
			}
		}

		[Token(Token = "0x2000119")]
		public enum PresenceUpdateType
		{
			[Token(Token = "0x4000819")]
			invalid,
			[Token(Token = "0x400081A")]
			gameTitle,
			[Token(Token = "0x400081B")]
			gameStatus,
			[Token(Token = "0x400081C")]
			gameData
		}

		[Token(Token = "0x200011A")]
		public class PresenceUpdateResponse : ResponseBase
		{
			[Token(Token = "0x400081D")]
			public const int MAX_SIZE_GAME_STATUS = 191;

			[Token(Token = "0x400081E")]
			public const int MAX_SIZE_GAME_DATA = 128;

			[Token(Token = "0x400081F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Core.OnlineUser localUpdatedUser;

			[Token(Token = "0x4000820")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Core.OnlineUser remoteUser;

			[Token(Token = "0x4000821")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Core.UserServiceUserId userId;

			[Token(Token = "0x4000822")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal PresenceUpdateType updateType;

			[Token(Token = "0x4000823")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal string gameStatus;

			[Token(Token = "0x4000824")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal byte[] binaryGameData;

			[Token(Token = "0x4000825")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal Core.PlatformType platform;

			[Token(Token = "0x17000219")]
			public Core.OnlineUser LocalUpdatedUser
			{
				[Token(Token = "0x6000558")]
				[Address(RVA = "0x24EB8F8", Offset = "0x24EB8F8", VA = "0x24EB8F8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700021A")]
			public Core.OnlineUser RemoteUser
			{
				[Token(Token = "0x6000559")]
				[Address(RVA = "0x24EB900", Offset = "0x24EB900", VA = "0x24EB900")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700021B")]
			public Core.UserServiceUserId UserId
			{
				[Token(Token = "0x600055A")]
				[Address(RVA = "0x24EB908", Offset = "0x24EB908", VA = "0x24EB908")]
				get
				{
					return default(Core.UserServiceUserId);
				}
			}

			[Token(Token = "0x1700021C")]
			public PresenceUpdateType UpdateType
			{
				[Token(Token = "0x600055B")]
				[Address(RVA = "0x24EB910", Offset = "0x24EB910", VA = "0x24EB910")]
				get
				{
					return default(PresenceUpdateType);
				}
			}

			[Token(Token = "0x1700021D")]
			public string GameStatus
			{
				[Token(Token = "0x600055C")]
				[Address(RVA = "0x24EB918", Offset = "0x24EB918", VA = "0x24EB918")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700021E")]
			public byte[] BinaryGameData
			{
				[Token(Token = "0x600055D")]
				[Address(RVA = "0x24EB9E0", Offset = "0x24EB9E0", VA = "0x24EB9E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700021F")]
			public Core.PlatformType Platform
			{
				[Token(Token = "0x600055E")]
				[Address(RVA = "0x24EBAA8", Offset = "0x24EBAA8", VA = "0x24EBAA8")]
				get
				{
					return default(Core.PlatformType);
				}
			}

			[Token(Token = "0x600055F")]
			[Address(RVA = "0x24EBAB0", Offset = "0x24EBAB0", VA = "0x24EBAB0", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x6000560")]
			[Address(RVA = "0x24E7314", Offset = "0x24E7314", VA = "0x24E7314")]
			public PresenceUpdateResponse()
			{
			}
		}

		[PreserveSig]
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x24EAAD4", Offset = "0x24EAAD4", VA = "0x24EAAD4")]
		private static extern int PrxDeletePresence(DeletePresenceRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x24EABA4", Offset = "0x24EABA4", VA = "0x24EABA4")]
		private static extern int PrxSetPresence(SetPresenceRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x24EAC70", Offset = "0x24EAC70", VA = "0x24EAC70")]
		private static extern int PrxGetPresence(GetPresenceRequest request, out APIResult result);

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x24EAD40", Offset = "0x24EAD40", VA = "0x24EAD40")]
		public static int DeletePresence(DeletePresenceRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x24EAE48", Offset = "0x24EAE48", VA = "0x24EAE48")]
		public static int SetPresence(SetPresenceRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x24EAF50", Offset = "0x24EAF50", VA = "0x24EAF50")]
		public static int GetPresence(GetPresenceRequest request, PresenceResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x24EB058", Offset = "0x24EB058", VA = "0x24EB058")]
		public Presence()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class Profiles
	{
		[Token(Token = "0x200011B")]
		public class RealName
		{
			[Token(Token = "0x4000826")]
			public const int MAX_SIZE_FIRST_NAME = 16;

			[Token(Token = "0x4000827")]
			public const int MAX_SIZE_MIDDLE_NAME = 16;

			[Token(Token = "0x4000828")]
			public const int MAX_SIZE_LAST_NAME = 16;

			[Token(Token = "0x4000829")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal string firstName;

			[Token(Token = "0x400082A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal string middleName;

			[Token(Token = "0x400082B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal string lastName;

			[Token(Token = "0x17000220")]
			public string FirstName
			{
				[Token(Token = "0x6000561")]
				[Address(RVA = "0x24ECC0C", Offset = "0x24ECC0C", VA = "0x24ECC0C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000221")]
			public string MiddleName
			{
				[Token(Token = "0x6000562")]
				[Address(RVA = "0x24ECC14", Offset = "0x24ECC14", VA = "0x24ECC14")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000222")]
			public string LastName
			{
				[Token(Token = "0x6000563")]
				[Address(RVA = "0x24ECC1C", Offset = "0x24ECC1C", VA = "0x24ECC1C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000564")]
			[Address(RVA = "0x24EC894", Offset = "0x24EC894", VA = "0x24EC894")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x6000565")]
			[Address(RVA = "0x24EC838", Offset = "0x24EC838", VA = "0x24EC838")]
			public RealName()
			{
			}
		}

		[Token(Token = "0x200011C")]
		public class Profile
		{
			[Token(Token = "0x2000178")]
			public enum RelationTypes
			{
				[Token(Token = "0x400099A")]
				notSet,
				[Token(Token = "0x400099B")]
				me,
				[Token(Token = "0x400099C")]
				friends,
				[Token(Token = "0x400099D")]
				requestingFriend,
				[Token(Token = "0x400099E")]
				requestedFriend,
				[Token(Token = "0x400099F")]
				blocked,
				[Token(Token = "0x40009A0")]
				friendOfFriends,
				[Token(Token = "0x40009A1")]
				noRelationship
			}

			[Token(Token = "0x2000179")]
			public enum PersonalDetailsTypes
			{
				[Token(Token = "0x40009A3")]
				none,
				[Token(Token = "0x40009A4")]
				realName,
				[Token(Token = "0x40009A5")]
				verifiedAccountDisplayName
			}

			[Token(Token = "0x400082C")]
			public const int MAX_SIZE_ABOUT_ME = 140;

			[Token(Token = "0x400082D")]
			public const int MAX_SIZE_AVATAR_URL = 128;

			[Token(Token = "0x400082E")]
			public const int MAX_NUM_LANGUAGES_USED = 3;

			[Token(Token = "0x400082F")]
			public const int MAX_SIZE_VERIFIED_ACCOUNT_DISPLAY_NAME = 32;

			[Token(Token = "0x4000830")]
			public const int MAX_SIZE_PROFILE_PICTURE_URL = 256;

			[Token(Token = "0x4000831")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Core.OnlineUser onlineUser;

			[Token(Token = "0x4000832")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal RelationTypes relationType;

			[Token(Token = "0x4000833")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Core.LanguageCode[] languagesUsed;

			[Token(Token = "0x4000834")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Core.CountryCode country;

			[Token(Token = "0x4000835")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal PersonalDetailsTypes personalDetailsType;

			[Token(Token = "0x4000836")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal RealName realName;

			[Token(Token = "0x4000837")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal string verifiedAccountDisplayName;

			[Token(Token = "0x4000838")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal string aboutMe;

			[Token(Token = "0x4000839")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal string avatarUrl;

			[Token(Token = "0x400083A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal string profilePictureUrl;

			[Token(Token = "0x400083B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal bool isVerifiedAccount;

			[Token(Token = "0x17000223")]
			public Core.OnlineUser OnlineUser
			{
				[Token(Token = "0x6000566")]
				[Address(RVA = "0x24EC370", Offset = "0x24EC370", VA = "0x24EC370")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000224")]
			public RelationTypes RelationType
			{
				[Token(Token = "0x6000567")]
				[Address(RVA = "0x24EC378", Offset = "0x24EC378", VA = "0x24EC378")]
				get
				{
					return default(RelationTypes);
				}
			}

			[Token(Token = "0x17000225")]
			public Core.CountryCode Country
			{
				[Token(Token = "0x6000568")]
				[Address(RVA = "0x24EC380", Offset = "0x24EC380", VA = "0x24EC380")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000226")]
			public Core.LanguageCode[] LanguagesUsed
			{
				[Token(Token = "0x6000569")]
				[Address(RVA = "0x24EC388", Offset = "0x24EC388", VA = "0x24EC388")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000227")]
			public PersonalDetailsTypes PersonalDetailsType
			{
				[Token(Token = "0x600056A")]
				[Address(RVA = "0x24EC390", Offset = "0x24EC390", VA = "0x24EC390")]
				get
				{
					return default(PersonalDetailsTypes);
				}
			}

			[Token(Token = "0x17000228")]
			public RealName RealName
			{
				[Token(Token = "0x600056B")]
				[Address(RVA = "0x24EC398", Offset = "0x24EC398", VA = "0x24EC398")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000229")]
			public string VerifiedAccountDisplayName
			{
				[Token(Token = "0x600056C")]
				[Address(RVA = "0x24EC420", Offset = "0x24EC420", VA = "0x24EC420")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700022A")]
			public bool IsVerifiedAccount
			{
				[Token(Token = "0x600056D")]
				[Address(RVA = "0x24EC4A8", Offset = "0x24EC4A8", VA = "0x24EC4A8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700022B")]
			public string AboutMe
			{
				[Token(Token = "0x600056E")]
				[Address(RVA = "0x24EC4B0", Offset = "0x24EC4B0", VA = "0x24EC4B0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700022C")]
			public string AvatarUrl
			{
				[Token(Token = "0x600056F")]
				[Address(RVA = "0x24EC4B8", Offset = "0x24EC4B8", VA = "0x24EC4B8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700022D")]
			public string ProfilePictureUrl
			{
				[Token(Token = "0x6000570")]
				[Address(RVA = "0x24EC4C0", Offset = "0x24EC4C0", VA = "0x24EC4C0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000571")]
			[Address(RVA = "0x24EC4C8", Offset = "0x24EC4C8", VA = "0x24EC4C8")]
			public Profile()
			{
			}

			[Token(Token = "0x6000572")]
			[Address(RVA = "0x24EC60C", Offset = "0x24EC60C", VA = "0x24EC60C")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x6000573")]
			[Address(RVA = "0x24EC908", Offset = "0x24EC908", VA = "0x24EC908", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x24EC368", Offset = "0x24EC368", VA = "0x24EC368")]
		public Profiles()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class Ranking
	{
		[StructLayout(0)]
		[Token(Token = "0x200011D")]
		public class SetScoreRequest : RequestBase
		{
			[Token(Token = "0x400083C")]
			public const int NP_SCORE_COMMENT_MAXLEN = 63;

			[Token(Token = "0x400083D")]
			public const int NP_SCORE_GAMEINFO_MAXSIZE = 189;

			[Token(Token = "0x400083E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal long score;

			[Token(Token = "0x400083F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal string utf8Comment;

			[Token(Token = "0x4000840")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal byte[] gameInfoData;

			[Token(Token = "0x4000841")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal ulong dataLength;

			[Token(Token = "0x4000842")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal uint boardId;

			[Token(Token = "0x4000843")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			internal int pcId;

			[Token(Token = "0x1700022E")]
			public long Score
			{
				[Token(Token = "0x6000574")]
				[Address(RVA = "0x24EF004", Offset = "0x24EF004", VA = "0x24EF004")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6000575")]
				[Address(RVA = "0x24EF00C", Offset = "0x24EF00C", VA = "0x24EF00C")]
				set
				{
				}
			}

			[Token(Token = "0x1700022F")]
			public string Comment
			{
				[Token(Token = "0x6000576")]
				[Address(RVA = "0x24EF014", Offset = "0x24EF014", VA = "0x24EF014")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000577")]
				[Address(RVA = "0x24EF01C", Offset = "0x24EF01C", VA = "0x24EF01C")]
				set
				{
				}
			}

			[Token(Token = "0x17000230")]
			public byte[] GameInfoData
			{
				[Token(Token = "0x6000578")]
				[Address(RVA = "0x24EF0FC", Offset = "0x24EF0FC", VA = "0x24EF0FC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000579")]
				[Address(RVA = "0x24EF194", Offset = "0x24EF194", VA = "0x24EF194")]
				set
				{
				}
			}

			[Token(Token = "0x17000231")]
			public uint BoardId
			{
				[Token(Token = "0x600057A")]
				[Address(RVA = "0x24EF290", Offset = "0x24EF290", VA = "0x24EF290")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x600057B")]
				[Address(RVA = "0x24EF298", Offset = "0x24EF298", VA = "0x24EF298")]
				set
				{
				}
			}

			[Token(Token = "0x17000232")]
			public int PcId
			{
				[Token(Token = "0x600057C")]
				[Address(RVA = "0x24EF360", Offset = "0x24EF360", VA = "0x24EF360")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600057D")]
				[Address(RVA = "0x24EF368", Offset = "0x24EF368", VA = "0x24EF368")]
				set
				{
				}
			}

			[Token(Token = "0x600057E")]
			[Address(RVA = "0x24EF370", Offset = "0x24EF370", VA = "0x24EF370")]
			public SetScoreRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x200011E")]
		public class GetRangeOfRanksRequest : RequestBase
		{
			[Token(Token = "0x4000844")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal uint boardId;

			[Token(Token = "0x4000845")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal uint startRank;

			[Token(Token = "0x4000846")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal uint range;

			[Token(Token = "0x4000847")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal bool isCrossSaveInformation;

			[Token(Token = "0x17000233")]
			public uint BoardId
			{
				[Token(Token = "0x600057F")]
				[Address(RVA = "0x24EE0C4", Offset = "0x24EE0C4", VA = "0x24EE0C4")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x6000580")]
				[Address(RVA = "0x24EE0CC", Offset = "0x24EE0CC", VA = "0x24EE0CC")]
				set
				{
				}
			}

			[Token(Token = "0x17000234")]
			public uint StartRank
			{
				[Token(Token = "0x6000581")]
				[Address(RVA = "0x24EE194", Offset = "0x24EE194", VA = "0x24EE194")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x6000582")]
				[Address(RVA = "0x24EE19C", Offset = "0x24EE19C", VA = "0x24EE19C")]
				set
				{
				}
			}

			[Token(Token = "0x17000235")]
			public uint Range
			{
				[Token(Token = "0x6000583")]
				[Address(RVA = "0x24EE260", Offset = "0x24EE260", VA = "0x24EE260")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x6000584")]
				[Address(RVA = "0x24EE268", Offset = "0x24EE268", VA = "0x24EE268")]
				set
				{
				}
			}

			[Token(Token = "0x17000236")]
			public bool IsCrossSaveInformation
			{
				[Token(Token = "0x6000585")]
				[Address(RVA = "0x24EE3F4", Offset = "0x24EE3F4", VA = "0x24EE3F4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000586")]
				[Address(RVA = "0x24EE3FC", Offset = "0x24EE3FC", VA = "0x24EE3FC")]
				set
				{
				}
			}

			[Token(Token = "0x6000587")]
			[Address(RVA = "0x24EE408", Offset = "0x24EE408", VA = "0x24EE408")]
			public GetRangeOfRanksRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x200011F")]
		public class GetFriendsRanksRequest : RequestBase
		{
			[Token(Token = "0x4000848")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal uint boardId;

			[Token(Token = "0x4000849")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal uint startRank;

			[Token(Token = "0x400084A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal uint friendsWithPcId;

			[Token(Token = "0x400084B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal bool isCrossSaveInformation;

			[Token(Token = "0x400084C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
			internal bool addCallingUserRank;

			[Token(Token = "0x17000237")]
			public uint BoardId
			{
				[Token(Token = "0x6000588")]
				[Address(RVA = "0x24EDD50", Offset = "0x24EDD50", VA = "0x24EDD50")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x6000589")]
				[Address(RVA = "0x24EDD58", Offset = "0x24EDD58", VA = "0x24EDD58")]
				set
				{
				}
			}

			[Token(Token = "0x17000238")]
			public uint StartRank
			{
				[Token(Token = "0x600058A")]
				[Address(RVA = "0x24EDD60", Offset = "0x24EDD60", VA = "0x24EDD60")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x600058B")]
				[Address(RVA = "0x24EDD68", Offset = "0x24EDD68", VA = "0x24EDD68")]
				set
				{
				}
			}

			[Token(Token = "0x17000239")]
			public uint FriendsWithPcId
			{
				[Token(Token = "0x600058C")]
				[Address(RVA = "0x24EDD70", Offset = "0x24EDD70", VA = "0x24EDD70")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x600058D")]
				[Address(RVA = "0x24EDD78", Offset = "0x24EDD78", VA = "0x24EDD78")]
				set
				{
				}
			}

			[Token(Token = "0x1700023A")]
			public bool IsCrossSaveInformation
			{
				[Token(Token = "0x600058E")]
				[Address(RVA = "0x24EDD80", Offset = "0x24EDD80", VA = "0x24EDD80")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600058F")]
				[Address(RVA = "0x24EDD88", Offset = "0x24EDD88", VA = "0x24EDD88")]
				set
				{
				}
			}

			[Token(Token = "0x1700023B")]
			public bool AddCallingUserRank
			{
				[Token(Token = "0x6000590")]
				[Address(RVA = "0x24EDD94", Offset = "0x24EDD94", VA = "0x24EDD94")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000591")]
				[Address(RVA = "0x24EDD9C", Offset = "0x24EDD9C", VA = "0x24EDD9C")]
				set
				{
				}
			}

			[Token(Token = "0x6000592")]
			[Address(RVA = "0x24EDDA8", Offset = "0x24EDDA8", VA = "0x24EDDA8")]
			public GetFriendsRanksRequest()
			{
			}
		}

		[Token(Token = "0x2000120")]
		public struct ScoreAccountIdPcId
		{
			[Token(Token = "0x400084D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Core.NpAccountId accountId;

			[Token(Token = "0x400084E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int pcId;
		}

		[StructLayout(0)]
		[Token(Token = "0x2000121")]
		public class GetUsersRanksRequest : RequestBase
		{
			[Token(Token = "0x400084F")]
			public const int MAX_NUM_USERS = 101;

			[Token(Token = "0x4000850")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ScoreAccountIdPcId[] users;

			[Token(Token = "0x4000851")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal uint numUsers;

			[Token(Token = "0x4000852")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal uint boardId;

			[Token(Token = "0x4000853")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal bool isCrossSaveInformation;

			[Token(Token = "0x4000854")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
			internal bool ignorePcIds;

			[Token(Token = "0x1700023C")]
			public ScoreAccountIdPcId[] Users
			{
				[Token(Token = "0x6000593")]
				[Address(RVA = "0x24EE434", Offset = "0x24EE434", VA = "0x24EE434")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000594")]
				[Address(RVA = "0x24EE4B4", Offset = "0x24EE4B4", VA = "0x24EE4B4")]
				set
				{
				}
			}

			[Token(Token = "0x1700023D")]
			public uint BoardId
			{
				[Token(Token = "0x6000595")]
				[Address(RVA = "0x24EE61C", Offset = "0x24EE61C", VA = "0x24EE61C")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x6000596")]
				[Address(RVA = "0x24EE624", Offset = "0x24EE624", VA = "0x24EE624")]
				set
				{
				}
			}

			[Token(Token = "0x1700023E")]
			public bool IsCrossSaveInformation
			{
				[Token(Token = "0x6000597")]
				[Address(RVA = "0x24EE62C", Offset = "0x24EE62C", VA = "0x24EE62C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000598")]
				[Address(RVA = "0x24EE634", Offset = "0x24EE634", VA = "0x24EE634")]
				set
				{
				}
			}

			[Token(Token = "0x1700023F")]
			public bool IgnorePcIds
			{
				[Token(Token = "0x6000599")]
				[Address(RVA = "0x24EE640", Offset = "0x24EE640", VA = "0x24EE640")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600059A")]
				[Address(RVA = "0x24EE648", Offset = "0x24EE648", VA = "0x24EE648")]
				set
				{
				}
			}

			[Token(Token = "0x600059B")]
			[Address(RVA = "0x24EE654", Offset = "0x24EE654", VA = "0x24EE654")]
			public GetUsersRanksRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x2000122")]
		public class SetGameDataRequest : RequestBase
		{
			[Token(Token = "0x4000855")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal uint boardId;

			[Token(Token = "0x4000856")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal int idOfPrevChunk;

			[Token(Token = "0x4000857")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal long score;

			[Token(Token = "0x4000858")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal ulong totalSize;

			[Token(Token = "0x4000859")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal byte[] data;

			[Token(Token = "0x400085A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal ulong byteOffset;

			[Token(Token = "0x400085B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal ulong chunkDataSize;

			[Token(Token = "0x400085C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal int pcId;

			[Token(Token = "0x17000240")]
			public uint BoardId
			{
				[Token(Token = "0x600059C")]
				[Address(RVA = "0x24EEDAC", Offset = "0x24EEDAC", VA = "0x24EEDAC")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x600059D")]
				[Address(RVA = "0x24EEDB4", Offset = "0x24EEDB4", VA = "0x24EEDB4")]
				set
				{
				}
			}

			[Token(Token = "0x17000241")]
			public int IdOfPrevChunk
			{
				[Token(Token = "0x600059E")]
				[Address(RVA = "0x24EEDBC", Offset = "0x24EEDBC", VA = "0x24EEDBC")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600059F")]
				[Address(RVA = "0x24EEDC4", Offset = "0x24EEDC4", VA = "0x24EEDC4")]
				set
				{
				}
			}

			[Token(Token = "0x17000242")]
			public long Score
			{
				[Token(Token = "0x60005A0")]
				[Address(RVA = "0x24EEDCC", Offset = "0x24EEDCC", VA = "0x24EEDCC")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x60005A1")]
				[Address(RVA = "0x24EEDD4", Offset = "0x24EEDD4", VA = "0x24EEDD4")]
				set
				{
				}
			}

			[Token(Token = "0x17000243")]
			public ulong TotalSize
			{
				[Token(Token = "0x60005A2")]
				[Address(RVA = "0x24EEDDC", Offset = "0x24EEDDC", VA = "0x24EEDDC")]
				get
				{
					return default(ulong);
				}
			}

			[Token(Token = "0x17000244")]
			public byte[] Data
			{
				[Token(Token = "0x60005A3")]
				[Address(RVA = "0x24EEDE4", Offset = "0x24EEDE4", VA = "0x24EEDE4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000245")]
			public ulong StartIndex
			{
				[Token(Token = "0x60005A4")]
				[Address(RVA = "0x24EEDEC", Offset = "0x24EEDEC", VA = "0x24EEDEC")]
				get
				{
					return default(ulong);
				}
			}

			[Token(Token = "0x17000246")]
			public int PcId
			{
				[Token(Token = "0x60005A5")]
				[Address(RVA = "0x24EEDF4", Offset = "0x24EEDF4", VA = "0x24EEDF4")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60005A6")]
				[Address(RVA = "0x24EEDFC", Offset = "0x24EEDFC", VA = "0x24EEDFC")]
				set
				{
				}
			}

			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x24EEE04", Offset = "0x24EEE04", VA = "0x24EEE04")]
			public void SetDataChunk(byte[] data, ulong startIndex, ulong chunkSize)
			{
			}

			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x24EEE0C", Offset = "0x24EEE0C", VA = "0x24EEE0C")]
			public void SetDataChunk(byte[] data, ulong startIndex, ulong chunkSize, ulong totalSize)
			{
			}

			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x24EEED0", Offset = "0x24EEED0", VA = "0x24EEED0")]
			public SetGameDataRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x2000123")]
		public class GetGameDataRequest : RequestBase
		{
			[Token(Token = "0x400085D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal uint boardId;

			[Token(Token = "0x400085E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal int idOfPrevChunk;

			[Token(Token = "0x400085F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Core.NpAccountId accountId;

			[Token(Token = "0x4000860")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal byte[] rcvData;

			[Token(Token = "0x4000861")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal ulong byteOffset;

			[Token(Token = "0x4000862")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal ulong chunkToRcvDataSize;

			[Token(Token = "0x4000863")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal int pcId;

			[Token(Token = "0x17000247")]
			public uint BoardId
			{
				[Token(Token = "0x60005AA")]
				[Address(RVA = "0x24EDDD8", Offset = "0x24EDDD8", VA = "0x24EDDD8")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x60005AB")]
				[Address(RVA = "0x24EDDE0", Offset = "0x24EDDE0", VA = "0x24EDDE0")]
				set
				{
				}
			}

			[Token(Token = "0x17000248")]
			public int IdOfPrevChunk
			{
				[Token(Token = "0x60005AC")]
				[Address(RVA = "0x24EDDE8", Offset = "0x24EDDE8", VA = "0x24EDDE8")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60005AD")]
				[Address(RVA = "0x24EDDF0", Offset = "0x24EDDF0", VA = "0x24EDDF0")]
				set
				{
				}
			}

			[Token(Token = "0x17000249")]
			public Core.NpAccountId AccountId
			{
				[Token(Token = "0x60005AE")]
				[Address(RVA = "0x24EDDF8", Offset = "0x24EDDF8", VA = "0x24EDDF8")]
				get
				{
					return default(Core.NpAccountId);
				}
				[Token(Token = "0x60005AF")]
				[Address(RVA = "0x24EDE00", Offset = "0x24EDE00", VA = "0x24EDE00")]
				set
				{
				}
			}

			[Token(Token = "0x1700024A")]
			public byte[] RcvData
			{
				[Token(Token = "0x60005B0")]
				[Address(RVA = "0x24EDE08", Offset = "0x24EDE08", VA = "0x24EDE08")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700024B")]
			public int PcId
			{
				[Token(Token = "0x60005B1")]
				[Address(RVA = "0x24EDE10", Offset = "0x24EDE10", VA = "0x24EDE10")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60005B2")]
				[Address(RVA = "0x24EDE18", Offset = "0x24EDE18", VA = "0x24EDE18")]
				set
				{
				}
			}

			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x24EDE20", Offset = "0x24EDE20", VA = "0x24EDE20")]
			public void SetRcvDataChunk(byte[] data, ulong startIndex, ulong chunkSize)
			{
			}

			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x24EDED4", Offset = "0x24EDED4", VA = "0x24EDED4")]
			public GetGameDataRequest()
			{
			}
		}

		[Token(Token = "0x2000124")]
		public class TempRankResponse : ResponseBase
		{
			[Token(Token = "0x4000864")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal uint tempRank;

			[Token(Token = "0x1700024C")]
			public uint TempRank
			{
				[Token(Token = "0x60005B5")]
				[Address(RVA = "0x24EF3D8", Offset = "0x24EF3D8", VA = "0x24EF3D8")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x24EF3E0", Offset = "0x24EF3E0", VA = "0x24EF3E0", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x24EF4F8", Offset = "0x24EF4F8", VA = "0x24EF4F8")]
			public TempRankResponse()
			{
			}
		}

		[Token(Token = "0x2000125")]
		public class ScoreRankDataBase
		{
			[Token(Token = "0x4000865")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal string utf8Comment;

			[Token(Token = "0x4000866")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal byte[] gameInfo;

			[Token(Token = "0x4000867")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal int pcId;

			[Token(Token = "0x4000868")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal uint serialRank;

			[Token(Token = "0x4000869")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal uint rank;

			[Token(Token = "0x400086A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal uint highestRank;

			[Token(Token = "0x400086B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal bool hasGameData;

			[Token(Token = "0x400086C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal long scoreValue;

			[Token(Token = "0x400086D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal DateTime recordDate;

			[Token(Token = "0x400086E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal Core.NpAccountId accountId;

			[Token(Token = "0x1700024D")]
			public string Comment
			{
				[Token(Token = "0x60005B8")]
				[Address(RVA = "0x24EED50", Offset = "0x24EED50", VA = "0x24EED50")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700024E")]
			public byte[] GameInfo
			{
				[Token(Token = "0x60005B9")]
				[Address(RVA = "0x24EED58", Offset = "0x24EED58", VA = "0x24EED58")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700024F")]
			public int PcId
			{
				[Token(Token = "0x60005BA")]
				[Address(RVA = "0x24EED60", Offset = "0x24EED60", VA = "0x24EED60")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000250")]
			public uint SerialRank
			{
				[Token(Token = "0x60005BB")]
				[Address(RVA = "0x24EED68", Offset = "0x24EED68", VA = "0x24EED68")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x17000251")]
			public uint Rank
			{
				[Token(Token = "0x60005BC")]
				[Address(RVA = "0x24EED70", Offset = "0x24EED70", VA = "0x24EED70")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x17000252")]
			public uint HighestRank
			{
				[Token(Token = "0x60005BD")]
				[Address(RVA = "0x24EED78", Offset = "0x24EED78", VA = "0x24EED78")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x17000253")]
			public bool HasGameData
			{
				[Token(Token = "0x60005BE")]
				[Address(RVA = "0x24EED80", Offset = "0x24EED80", VA = "0x24EED80")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000254")]
			public long ScoreValue
			{
				[Token(Token = "0x60005BF")]
				[Address(RVA = "0x24EED88", Offset = "0x24EED88", VA = "0x24EED88")]
				get
				{
					return default(long);
				}
			}

			[Token(Token = "0x17000255")]
			public DateTime RecordDate
			{
				[Token(Token = "0x60005C0")]
				[Address(RVA = "0x24EED90", Offset = "0x24EED90", VA = "0x24EED90")]
				get
				{
					return default(DateTime);
				}
			}

			[Token(Token = "0x17000256")]
			public Core.NpAccountId AccountId
			{
				[Token(Token = "0x60005C1")]
				[Address(RVA = "0x24EED98", Offset = "0x24EED98", VA = "0x24EED98")]
				get
				{
					return default(Core.NpAccountId);
				}
			}

			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x24EEC9C", Offset = "0x24EEC9C", VA = "0x24EEC9C")]
			internal void ReadBase(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x24EDC70", Offset = "0x24EDC70", VA = "0x24EDC70")]
			internal void ReadAdditionalData(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x24EED48", Offset = "0x24EED48", VA = "0x24EED48")]
			public ScoreRankDataBase()
			{
			}
		}

		[Token(Token = "0x2000126")]
		public class ScoreRankData : ScoreRankDataBase
		{
			[Token(Token = "0x400086F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal Core.OnlineID onlineId;

			[Token(Token = "0x17000257")]
			public Core.OnlineID OnlineId
			{
				[Token(Token = "0x60005C5")]
				[Address(RVA = "0x24EEC94", Offset = "0x24EEC94", VA = "0x24EEC94")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x24EDCBC", Offset = "0x24EDCBC", VA = "0x24EDCBC")]
			internal void ReadData(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x24EDCB4", Offset = "0x24EDCB4", VA = "0x24EDCB4")]
			public ScoreRankData()
			{
			}
		}

		[Token(Token = "0x2000127")]
		public class ScoreRankDataForCrossSave : ScoreRankDataBase
		{
			[Token(Token = "0x4000870")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal Core.NpId npId;

			[Token(Token = "0x17000258")]
			public Core.NpId NpId
			{
				[Token(Token = "0x60005C8")]
				[Address(RVA = "0x24EEDA0", Offset = "0x24EEDA0", VA = "0x24EEDA0")]
				get
				{
					return default(Core.NpId);
				}
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x24EDC40", Offset = "0x24EDC40", VA = "0x24EDC40")]
			internal void ReadData(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x24EDC38", Offset = "0x24EDC38", VA = "0x24EDC38")]
			public ScoreRankDataForCrossSave()
			{
			}
		}

		[Token(Token = "0x2000128")]
		public class ScorePlayerRankData : ScoreRankData
		{
			[Token(Token = "0x4000871")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal bool hasData;

			[Token(Token = "0x17000259")]
			public bool HasData
			{
				[Token(Token = "0x60005CB")]
				[Address(RVA = "0x24EEBBC", Offset = "0x24EEBBC", VA = "0x24EEBBC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x24EEBC4", Offset = "0x24EEBC4", VA = "0x24EEBC4")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x24EEC18", Offset = "0x24EEC18", VA = "0x24EEC18")]
			public ScorePlayerRankData()
			{
			}
		}

		[Token(Token = "0x2000129")]
		public class ScorePlayerRankDataForCrossSave : ScoreRankDataForCrossSave
		{
			[Token(Token = "0x4000872")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal bool hasData;

			[Token(Token = "0x1700025A")]
			public bool HasData
			{
				[Token(Token = "0x60005CE")]
				[Address(RVA = "0x24EEC20", Offset = "0x24EEC20", VA = "0x24EEC20")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x24EEC28", Offset = "0x24EEC28", VA = "0x24EEC28")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x24EEC8C", Offset = "0x24EEC8C", VA = "0x24EEC8C")]
			public ScorePlayerRankDataForCrossSave()
			{
			}
		}

		[Token(Token = "0x200012A")]
		public class RangeOfRanksResponse : ResponseBase
		{
			[Token(Token = "0x4000873")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal ScoreRankData[] scoreRankData;

			[Token(Token = "0x4000874")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ScoreRankDataForCrossSave[] scoreRankDataForCrossSave;

			[Token(Token = "0x4000875")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal bool isCrossSaveInformation;

			[Token(Token = "0x4000876")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal ulong numValidEntries;

			[Token(Token = "0x4000877")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal DateTime updateTime;

			[Token(Token = "0x4000878")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal uint totalEntriesOnBoard;

			[Token(Token = "0x4000879")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			internal uint boardId;

			[Token(Token = "0x400087A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal int startRank;

			[Token(Token = "0x1700025B")]
			public ScoreRankData[] RankData
			{
				[Token(Token = "0x60005D1")]
				[Address(RVA = "0x24EE6C4", Offset = "0x24EE6C4", VA = "0x24EE6C4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700025C")]
			public ScoreRankDataForCrossSave[] RankDataForCrossSave
			{
				[Token(Token = "0x60005D2")]
				[Address(RVA = "0x24EE748", Offset = "0x24EE748", VA = "0x24EE748")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700025D")]
			public bool IsCrossSaveInformation
			{
				[Token(Token = "0x60005D3")]
				[Address(RVA = "0x24EE7CC", Offset = "0x24EE7CC", VA = "0x24EE7CC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700025E")]
			public DateTime UpdateTime
			{
				[Token(Token = "0x60005D4")]
				[Address(RVA = "0x24EE7D4", Offset = "0x24EE7D4", VA = "0x24EE7D4")]
				get
				{
					return default(DateTime);
				}
			}

			[Token(Token = "0x1700025F")]
			public uint TotalEntriesOnBoard
			{
				[Token(Token = "0x60005D5")]
				[Address(RVA = "0x24EE7DC", Offset = "0x24EE7DC", VA = "0x24EE7DC")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x17000260")]
			public uint BoardId
			{
				[Token(Token = "0x60005D6")]
				[Address(RVA = "0x24EE7E4", Offset = "0x24EE7E4", VA = "0x24EE7E4")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x17000261")]
			public ulong NumValidEntries
			{
				[Token(Token = "0x60005D7")]
				[Address(RVA = "0x24EE7EC", Offset = "0x24EE7EC", VA = "0x24EE7EC")]
				get
				{
					return default(ulong);
				}
			}

			[Token(Token = "0x17000262")]
			public int StartRank
			{
				[Token(Token = "0x60005D8")]
				[Address(RVA = "0x24EE7F4", Offset = "0x24EE7F4", VA = "0x24EE7F4")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x24EE7FC", Offset = "0x24EE7FC", VA = "0x24EE7FC", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x24EEBB4", Offset = "0x24EEBB4", VA = "0x24EEBB4")]
			public RangeOfRanksResponse()
			{
			}
		}

		[Token(Token = "0x200012B")]
		public class FriendsRanksResponse : ResponseBase
		{
			[Token(Token = "0x400087B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal ScoreRankData[] scoreRankData;

			[Token(Token = "0x400087C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ScoreRankDataForCrossSave[] scoreRankDataForCrossSave;

			[Token(Token = "0x400087D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal bool isCrossSaveInformation;

			[Token(Token = "0x400087E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal ulong numFriends;

			[Token(Token = "0x400087F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal DateTime updateTime;

			[Token(Token = "0x4000880")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal uint boardId;

			[Token(Token = "0x4000881")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			internal uint totalEntriesOnBoard;

			[Token(Token = "0x4000882")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal uint totalFriendsOnBoard;

			[Token(Token = "0x4000883")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			internal int friendsWithPcId;

			[Token(Token = "0x17000263")]
			public ScoreRankData[] RankData
			{
				[Token(Token = "0x60005DB")]
				[Address(RVA = "0x24ED738", Offset = "0x24ED738", VA = "0x24ED738")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000264")]
			public ScoreRankDataForCrossSave[] RankDataForCrossSave
			{
				[Token(Token = "0x60005DC")]
				[Address(RVA = "0x24ED7BC", Offset = "0x24ED7BC", VA = "0x24ED7BC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000265")]
			public bool IsCrossSaveInformation
			{
				[Token(Token = "0x60005DD")]
				[Address(RVA = "0x24ED840", Offset = "0x24ED840", VA = "0x24ED840")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000266")]
			public ulong NumFriends
			{
				[Token(Token = "0x60005DE")]
				[Address(RVA = "0x24ED848", Offset = "0x24ED848", VA = "0x24ED848")]
				get
				{
					return default(ulong);
				}
			}

			[Token(Token = "0x17000267")]
			public DateTime UpdateTime
			{
				[Token(Token = "0x60005DF")]
				[Address(RVA = "0x24ED850", Offset = "0x24ED850", VA = "0x24ED850")]
				get
				{
					return default(DateTime);
				}
			}

			[Token(Token = "0x17000268")]
			public uint BoardId
			{
				[Token(Token = "0x60005E0")]
				[Address(RVA = "0x24ED858", Offset = "0x24ED858", VA = "0x24ED858")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x17000269")]
			public uint TotalEntriesOnBoard
			{
				[Token(Token = "0x60005E1")]
				[Address(RVA = "0x24ED860", Offset = "0x24ED860", VA = "0x24ED860")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x1700026A")]
			public uint TotalFriendsOnBoard
			{
				[Token(Token = "0x60005E2")]
				[Address(RVA = "0x24ED868", Offset = "0x24ED868", VA = "0x24ED868")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x1700026B")]
			public int FriendsWithPcId
			{
				[Token(Token = "0x60005E3")]
				[Address(RVA = "0x24ED870", Offset = "0x24ED870", VA = "0x24ED870")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x24ED878", Offset = "0x24ED878", VA = "0x24ED878", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x24EDD48", Offset = "0x24EDD48", VA = "0x24EDD48")]
			public FriendsRanksResponse()
			{
			}
		}

		[Token(Token = "0x200012C")]
		public class UsersRanksResponse : ResponseBase
		{
			[Token(Token = "0x4000884")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal ScorePlayerRankData[] users;

			[Token(Token = "0x4000885")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ScorePlayerRankDataForCrossSave[] usersForCrossSave;

			[Token(Token = "0x4000886")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal bool isCrossSaveInformation;

			[Token(Token = "0x4000887")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal ulong numUsers;

			[Token(Token = "0x4000888")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal ulong numValidUsers;

			[Token(Token = "0x4000889")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal DateTime updateTime;

			[Token(Token = "0x400088A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal uint boardId;

			[Token(Token = "0x400088B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			internal uint totalEntriesOnBoard;

			[Token(Token = "0x1700026C")]
			public ScorePlayerRankData[] Users
			{
				[Token(Token = "0x60005E6")]
				[Address(RVA = "0x24EF500", Offset = "0x24EF500", VA = "0x24EF500")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700026D")]
			public ScorePlayerRankDataForCrossSave[] UsersForCrossSave
			{
				[Token(Token = "0x60005E7")]
				[Address(RVA = "0x24EF584", Offset = "0x24EF584", VA = "0x24EF584")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700026E")]
			public bool IsCrossSaveInformation
			{
				[Token(Token = "0x60005E8")]
				[Address(RVA = "0x24EF608", Offset = "0x24EF608", VA = "0x24EF608")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700026F")]
			public ulong NumUsers
			{
				[Token(Token = "0x60005E9")]
				[Address(RVA = "0x24EF610", Offset = "0x24EF610", VA = "0x24EF610")]
				get
				{
					return default(ulong);
				}
			}

			[Token(Token = "0x17000270")]
			public ulong NumValidUsers
			{
				[Token(Token = "0x60005EA")]
				[Address(RVA = "0x24EF618", Offset = "0x24EF618", VA = "0x24EF618")]
				get
				{
					return default(ulong);
				}
			}

			[Token(Token = "0x17000271")]
			public DateTime UpdateTime
			{
				[Token(Token = "0x60005EB")]
				[Address(RVA = "0x24EF620", Offset = "0x24EF620", VA = "0x24EF620")]
				get
				{
					return default(DateTime);
				}
			}

			[Token(Token = "0x17000272")]
			public uint BoardId
			{
				[Token(Token = "0x60005EC")]
				[Address(RVA = "0x24EF628", Offset = "0x24EF628", VA = "0x24EF628")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x17000273")]
			public uint TotalEntriesOnBoard
			{
				[Token(Token = "0x60005ED")]
				[Address(RVA = "0x24EF630", Offset = "0x24EF630", VA = "0x24EF630")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x24EF638", Offset = "0x24EF638", VA = "0x24EF638", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x24EF9E4", Offset = "0x24EF9E4", VA = "0x24EF9E4")]
			public UsersRanksResponse()
			{
			}
		}

		[Token(Token = "0x200012D")]
		public class SetGameDataResultResponse : ResponseBase
		{
			[Token(Token = "0x400088C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal int chunkId;

			[Token(Token = "0x17000274")]
			public int ChunkId
			{
				[Token(Token = "0x60005F0")]
				[Address(RVA = "0x24EEEDC", Offset = "0x24EEEDC", VA = "0x24EEEDC")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x24EEEE4", Offset = "0x24EEEE4", VA = "0x24EEEE4", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x24EEFFC", Offset = "0x24EEFFC", VA = "0x24EEFFC")]
			public SetGameDataResultResponse()
			{
			}
		}

		[Token(Token = "0x200012E")]
		public class GetGameDataResultResponse : ResponseBase
		{
			[Token(Token = "0x400088D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal ulong totalSize;

			[Token(Token = "0x400088E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ulong rcvDataSize;

			[Token(Token = "0x400088F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal ulong rcvDataValidSize;

			[Token(Token = "0x4000890")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal ulong startIndex;

			[Token(Token = "0x4000891")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal int chunkId;

			[Token(Token = "0x4000892")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal byte[] rcvData;

			[Token(Token = "0x17000275")]
			public ulong TotalSize
			{
				[Token(Token = "0x60005F3")]
				[Address(RVA = "0x24EDEE0", Offset = "0x24EDEE0", VA = "0x24EDEE0")]
				get
				{
					return default(ulong);
				}
			}

			[Token(Token = "0x17000276")]
			public ulong RcvDataSize
			{
				[Token(Token = "0x60005F4")]
				[Address(RVA = "0x24EDEE8", Offset = "0x24EDEE8", VA = "0x24EDEE8")]
				get
				{
					return default(ulong);
				}
			}

			[Token(Token = "0x17000277")]
			public ulong RcvDataValidSize
			{
				[Token(Token = "0x60005F5")]
				[Address(RVA = "0x24EDEF0", Offset = "0x24EDEF0", VA = "0x24EDEF0")]
				get
				{
					return default(ulong);
				}
			}

			[Token(Token = "0x17000278")]
			public ulong StartIndex
			{
				[Token(Token = "0x60005F6")]
				[Address(RVA = "0x24EDEF8", Offset = "0x24EDEF8", VA = "0x24EDEF8")]
				get
				{
					return default(ulong);
				}
			}

			[Token(Token = "0x17000279")]
			public byte[] RcvData
			{
				[Token(Token = "0x60005F7")]
				[Address(RVA = "0x24EDF00", Offset = "0x24EDF00", VA = "0x24EDF00")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700027A")]
			public int ChunkId
			{
				[Token(Token = "0x60005F8")]
				[Address(RVA = "0x24EDF08", Offset = "0x24EDF08", VA = "0x24EDF08")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x24EDF10", Offset = "0x24EDF10", VA = "0x24EDF10", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x24EE0BC", Offset = "0x24EE0BC", VA = "0x24EE0BC")]
			public GetGameDataResultResponse()
			{
			}
		}

		[Token(Token = "0x40003B1")]
		public const int MAX_NUM_BOARDS = 1000;

		[Token(Token = "0x40003B2")]
		public const int MIN_PCID = 0;

		[Token(Token = "0x40003B3")]
		public const int MAX_PCID = 9;

		[Token(Token = "0x40003B4")]
		public const int MAX_RANGE = 100;

		[Token(Token = "0x40003B5")]
		public const int MIN_RANGE = 1;

		[Token(Token = "0x40003B6")]
		public const int FIRST_RANK = 1;

		[PreserveSig]
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x24ECC24", Offset = "0x24ECC24", VA = "0x24ECC24")]
		private static extern int PrxSetScore(SetScoreRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x24ECCE8", Offset = "0x24ECCE8", VA = "0x24ECCE8")]
		private static extern int PrxGetRangeOfRanks(GetRangeOfRanksRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x24ECDB0", Offset = "0x24ECDB0", VA = "0x24ECDB0")]
		private static extern int PrxGetFriendsRanks(GetFriendsRanksRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x24ECE80", Offset = "0x24ECE80", VA = "0x24ECE80")]
		private static extern int PrxGetUsersRanks(GetUsersRanksRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x24ECF40", Offset = "0x24ECF40", VA = "0x24ECF40")]
		private static extern int PrxSetGameData(SetGameDataRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x24ED020", Offset = "0x24ED020", VA = "0x24ED020")]
		private static extern int PrxGetGameData(GetGameDataRequest request, out APIResult result);

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x24ED100", Offset = "0x24ED100", VA = "0x24ED100")]
		public static int SetScore(SetScoreRequest request, TempRankResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x24ED208", Offset = "0x24ED208", VA = "0x24ED208")]
		public static int GetRangeOfRanks(GetRangeOfRanksRequest request, RangeOfRanksResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x24ED310", Offset = "0x24ED310", VA = "0x24ED310")]
		public static int GetFriendsRanks(GetFriendsRanksRequest request, FriendsRanksResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x24ED418", Offset = "0x24ED418", VA = "0x24ED418")]
		public static int GetUsersRanks(GetUsersRanksRequest request, UsersRanksResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x24ED520", Offset = "0x24ED520", VA = "0x24ED520")]
		public static int SetGameData(SetGameDataRequest request, SetGameDataResultResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x24ED628", Offset = "0x24ED628", VA = "0x24ED628")]
		public static int GetGameData(GetGameDataRequest request, GetGameDataResultResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x24ED730", Offset = "0x24ED730", VA = "0x24ED730")]
		public Ranking()
		{
		}
	}
	[Token(Token = "0x200003A")]
	internal static class PopulateThread
	{
		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Thread populateThread;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool stopThread;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Semaphore workLoad;

		[PreserveSig]
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x24E9A70", Offset = "0x24E9A70", VA = "0x24E9A70")]
		private static extern bool PrxPopFirstResponse(out int service, out int apiCalled, out uint npRequestId, out int userId, out int customReturnCode);

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x24E9B28", Offset = "0x24E9B28", VA = "0x24E9B28")]
		public static void Start()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x24E9C2C", Offset = "0x24E9C2C", VA = "0x24E9C2C")]
		private static void RunProc()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x24EA960", Offset = "0x24EA960", VA = "0x24EA960")]
		public static void Execute()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x24EA9D4", Offset = "0x24EA9D4", VA = "0x24EA9D4")]
		public static void Stop()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x24E9A14", Offset = "0x24E9A14", VA = "0x24E9A14")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xCE1B5C", Offset = "0xCE1B5C")]
		public static void OnPrxNpToolkitEvent()
		{
		}
	}
	[Token(Token = "0x200003B")]
	internal static class NpRequestsThread
	{
		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Thread requestsThread;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool stopThread;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Semaphore workLoad;

		[PreserveSig]
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x24E7448", Offset = "0x24E7448", VA = "0x24E7448")]
		private static extern bool PrxPollFirstRequest();

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x24E74C4", Offset = "0x24E74C4", VA = "0x24E74C4")]
		public static void Start()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x24E75C8", Offset = "0x24E75C8", VA = "0x24E75C8")]
		private static void RunProc()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x24E769C", Offset = "0x24E769C", VA = "0x24E769C")]
		public static void Execute()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x24E7710", Offset = "0x24E7710", VA = "0x24E7710")]
		public static void Stop()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x24E73EC", Offset = "0x24E73EC", VA = "0x24E73EC")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xCE1BC0", Offset = "0xCE1BC0")]
		public static void OnPrxNpRequestEvent()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class Trophies
	{
		[StructLayout(0)]
		[Token(Token = "0x200012F")]
		public class RegisterTrophyPackRequest : RequestBase
		{
			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x24F1998", Offset = "0x24F1998", VA = "0x24F1998")]
			public RegisterTrophyPackRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x2000130")]
		public class UnlockTrophyRequest : RequestBase
		{
			[Token(Token = "0x4000893")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal int trophyId;

			[Token(Token = "0x1700027B")]
			public int TrophyId
			{
				[Token(Token = "0x60005FC")]
				[Address(RVA = "0x24F1FD0", Offset = "0x24F1FD0", VA = "0x24F1FD0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60005FD")]
				[Address(RVA = "0x24F1FD8", Offset = "0x24F1FD8", VA = "0x24F1FD8")]
				set
				{
				}
			}

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x24F1FE0", Offset = "0x24F1FE0", VA = "0x24F1FE0")]
			public UnlockTrophyRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x2000131")]
		public class SetScreenshotRequest : RequestBase
		{
			[Token(Token = "0x4000894")]
			public const int INVALID_TROPHY_ID = -1;

			[Token(Token = "0x4000895")]
			public const int MAX_NUMBER_TROPHIES = 4;

			[Token(Token = "0x4000896")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal int[] trophiesIds;

			[Token(Token = "0x4000897")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal uint numTrophiesIds;

			[Token(Token = "0x4000898")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal bool assignToAllUsers;

			[Token(Token = "0x1700027C")]
			public int[] TrophiesIds
			{
				[Token(Token = "0x60005FF")]
				[Address(RVA = "0x24F19A4", Offset = "0x24F19A4", VA = "0x24F19A4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000600")]
				[Address(RVA = "0x24F1A24", Offset = "0x24F1A24", VA = "0x24F1A24")]
				set
				{
				}
			}

			[Token(Token = "0x1700027D")]
			public bool AssignToAllUsers
			{
				[Token(Token = "0x6000601")]
				[Address(RVA = "0x24F1B14", Offset = "0x24F1B14", VA = "0x24F1B14")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000602")]
				[Address(RVA = "0x24F1B1C", Offset = "0x24F1B1C", VA = "0x24F1B1C")]
				set
				{
				}
			}

			[Token(Token = "0x6000603")]
			[Address(RVA = "0x24F1B28", Offset = "0x24F1B28", VA = "0x24F1B28")]
			public SetScreenshotRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x2000132")]
		public class GetUnlockedTrophiesRequest : RequestBase
		{
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x24F1510", Offset = "0x24F1510", VA = "0x24F1510")]
			public GetUnlockedTrophiesRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x2000133")]
		public class DisplayTrophyListDialogRequest : RequestBase
		{
			[Token(Token = "0x6000605")]
			[Address(RVA = "0x24F1414", Offset = "0x24F1414", VA = "0x24F1414")]
			public DisplayTrophyListDialogRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x2000134")]
		public class GetTrophyPackSummaryRequest : RequestBase
		{
			[Token(Token = "0x4000899")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal bool retrieveTrophyPackSummaryIcon;

			[Token(Token = "0x1700027E")]
			public bool RetrieveTrophyPackSummaryIcon
			{
				[Token(Token = "0x6000606")]
				[Address(RVA = "0x24F1478", Offset = "0x24F1478", VA = "0x24F1478")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000607")]
				[Address(RVA = "0x24F1480", Offset = "0x24F1480", VA = "0x24F1480")]
				set
				{
				}
			}

			[Token(Token = "0x6000608")]
			[Address(RVA = "0x24F148C", Offset = "0x24F148C", VA = "0x24F148C")]
			public GetTrophyPackSummaryRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x2000135")]
		public class GetTrophyPackGroupRequest : RequestBase
		{
			[Token(Token = "0x400089A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal int groupId;

			[Token(Token = "0x400089B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal bool retrieveTrophyPackGroupIcon;

			[Token(Token = "0x1700027F")]
			public int GroupId
			{
				[Token(Token = "0x6000609")]
				[Address(RVA = "0x24F1420", Offset = "0x24F1420", VA = "0x24F1420")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600060A")]
				[Address(RVA = "0x24F1428", Offset = "0x24F1428", VA = "0x24F1428")]
				set
				{
				}
			}

			[Token(Token = "0x17000280")]
			public bool RetrieveTrophyPackGroupIcon
			{
				[Token(Token = "0x600060B")]
				[Address(RVA = "0x24F1430", Offset = "0x24F1430", VA = "0x24F1430")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600060C")]
				[Address(RVA = "0x24F1438", Offset = "0x24F1438", VA = "0x24F1438")]
				set
				{
				}
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0x24F1444", Offset = "0x24F1444", VA = "0x24F1444")]
			public GetTrophyPackGroupRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x2000136")]
		public class GetTrophyPackTrophyRequest : RequestBase
		{
			[Token(Token = "0x400089C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal int trophyId;

			[Token(Token = "0x400089D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal bool retrieveTrophyPackTrophyIcon;

			[Token(Token = "0x17000281")]
			public int TrophyId
			{
				[Token(Token = "0x600060E")]
				[Address(RVA = "0x24F14B8", Offset = "0x24F14B8", VA = "0x24F14B8")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600060F")]
				[Address(RVA = "0x24F14C0", Offset = "0x24F14C0", VA = "0x24F14C0")]
				set
				{
				}
			}

			[Token(Token = "0x17000282")]
			public bool RetrieveTrophyPackTrophyIcon
			{
				[Token(Token = "0x6000610")]
				[Address(RVA = "0x24F14C8", Offset = "0x24F14C8", VA = "0x24F14C8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000611")]
				[Address(RVA = "0x24F14D0", Offset = "0x24F14D0", VA = "0x24F14D0")]
				set
				{
				}
			}

			[Token(Token = "0x6000612")]
			[Address(RVA = "0x24F14DC", Offset = "0x24F14DC", VA = "0x24F14DC")]
			public GetTrophyPackTrophyRequest()
			{
			}
		}

		[Token(Token = "0x2000137")]
		public class UnlockedTrophiesResponse : ResponseBase
		{
			[Token(Token = "0x400089E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal int[] trophyIds;

			[Token(Token = "0x17000283")]
			public int[] TrophyIds
			{
				[Token(Token = "0x6000613")]
				[Address(RVA = "0x24F2010", Offset = "0x24F2010", VA = "0x24F2010")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000614")]
			[Address(RVA = "0x24F2018", Offset = "0x24F2018", VA = "0x24F2018", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x6000615")]
			[Address(RVA = "0x24F21C0", Offset = "0x24F21C0", VA = "0x24F21C0")]
			public UnlockedTrophiesResponse()
			{
			}
		}

		[Token(Token = "0x2000138")]
		public struct NpTrophyGameDetails
		{
			[Token(Token = "0x400089F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal uint numGroups;

			[Token(Token = "0x40008A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal uint numTrophies;

			[Token(Token = "0x40008A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal uint numPlatinum;

			[Token(Token = "0x40008A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal uint numGold;

			[Token(Token = "0x40008A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal uint numSilver;

			[Token(Token = "0x40008A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal uint numBronze;

			[Token(Token = "0x40008A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal string title;

			[Token(Token = "0x40008A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal string description;

			[Token(Token = "0x17000284")]
			public uint NumGroups
			{
				[Token(Token = "0x6000616")]
				[Address(RVA = "0x24F1700", Offset = "0x24F1700", VA = "0x24F1700")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x17000285")]
			public uint NumTrophies
			{
				[Token(Token = "0x6000617")]
				[Address(RVA = "0x24F1708", Offset = "0x24F1708", VA = "0x24F1708")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x17000286")]
			public uint NumPlatinum
			{
				[Token(Token = "0x6000618")]
				[Address(RVA = "0x24F1710", Offset = "0x24F1710", VA = "0x24F1710")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x17000287")]
			public uint NumGold
			{
				[Token(Token = "0x6000619")]
				[Address(RVA = "0x24F1718", Offset = "0x24F1718", VA = "0x24F1718")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x17000288")]
			public uint NumSilver
			{
				[Token(Token = "0x600061A")]
				[Address(RVA = "0x24F1720", Offset = "0x24F1720", VA = "0x24F1720")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x17000289")]
			public uint NumBronze
			{
				[Token(Token = "0x600061B")]
				[Address(RVA = "0x24F1728", Offset = "0x24F1728", VA = "0x24F1728")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x1700028A")]
			public string Title
			{
				[Token(Token = "0x600061C")]
				[Address(RVA = "0x24F1730", Offset = "0x24F1730", VA = "0x24F1730")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700028B")]
			public string Description
			{
				[Token(Token = "0x600061D")]
				[Address(RVA = "0x24F1738", Offset = "0x24F1738", VA = "0x24F1738")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600061E")]
			[Address(RVA = "0x24F1740", Offset = "0x24F1740", VA = "0x24F1740")]
			internal void Read(MemoryBuffer buffer)
			{
			}
		}

		[Token(Token = "0x2000139")]
		public struct NpTrophyGameData
		{
			[Token(Token = "0x40008A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal uint unlockedTrophies;

			[Token(Token = "0x40008A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal uint unlockedPlatinum;

			[Token(Token = "0x40008A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal uint unlockedGold;

			[Token(Token = "0x40008AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal uint unlockedSilver;

			[Token(Token = "0x40008AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal uint unlockedBronze;

			[Token(Token = "0x40008AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal uint progressPercentage;

			[Token(Token = "0x1700028C")]
			public uint UnlockedTrophies
			{
				[Token(Token = "0x600061F")]
				[Address(RVA = "0x24F1648", Offset = "0x24F1648", VA = "0x24F1648")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x1700028D")]
			public uint UnlockedPlatinum
			{
				[Token(Token = "0x6000620")]
				[Address(RVA = "0x24F1650", Offset = "0x24F1650", VA = "0x24F1650")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x1700028E")]
			public uint UnlockedGold
			{
				[Token(Token = "0x6000621")]
				[Address(RVA = "0x24F1658", Offset = "0x24F1658", VA = "0x24F1658")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x1700028F")]
			public uint UnlockedSilver
			{
				[Token(Token = "0x6000622")]
				[Address(RVA = "0x24F1660", Offset = "0x24F1660", VA = "0x24F1660")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x17000290")]
			public uint UnlockedBronze
			{
				[Token(Token = "0x6000623")]
				[Address(RVA = "0x24F1668", Offset = "0x24F1668", VA = "0x24F1668")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x17000291")]
			public uint ProgressPercentage
			{
				[Token(Token = "0x6000624")]
				[Address(RVA = "0x24F1670", Offset = "0x24F1670", VA = "0x24F1670")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x6000625")]
			[Address(RVA = "0x24F1678", Offset = "0x24F1678", VA = "0x24F1678")]
			internal void Read(MemoryBuffer buffer)
			{
			}
		}

		[Token(Token = "0x200013A")]
		public class TrophyPackSummaryResponse : ResponseBase
		{
			[Token(Token = "0x40008AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Icon icon;

			[Token(Token = "0x40008AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal NpTrophyGameDetails staticConfiguration;

			[Token(Token = "0x40008AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal NpTrophyGameData userProgress;

			[Token(Token = "0x17000292")]
			public Icon Icon
			{
				[Token(Token = "0x6000626")]
				[Address(RVA = "0x24F1D08", Offset = "0x24F1D08", VA = "0x24F1D08")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000293")]
			public NpTrophyGameDetails StaticConfiguration
			{
				[Token(Token = "0x6000627")]
				[Address(RVA = "0x24F1D10", Offset = "0x24F1D10", VA = "0x24F1D10")]
				get
				{
					return default(NpTrophyGameDetails);
				}
			}

			[Token(Token = "0x17000294")]
			public NpTrophyGameData UserProgress
			{
				[Token(Token = "0x6000628")]
				[Address(RVA = "0x24F1D28", Offset = "0x24F1D28", VA = "0x24F1D28")]
				get
				{
					return default(NpTrophyGameData);
				}
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x24F1D3C", Offset = "0x24F1D3C", VA = "0x24F1D3C", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x24F1E6C", Offset = "0x24F1E6C", VA = "0x24F1E6C")]
			public TrophyPackSummaryResponse()
			{
			}
		}

		[Token(Token = "0x200013B")]
		public struct NpTrophyGroupDetails
		{
			[Token(Token = "0x40008B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int groupId;

			[Token(Token = "0x40008B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal uint numTrophies;

			[Token(Token = "0x40008B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal uint numPlatinum;

			[Token(Token = "0x40008B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal uint numGold;

			[Token(Token = "0x40008B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal uint numSilver;

			[Token(Token = "0x40008B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal uint numBronze;

			[Token(Token = "0x40008B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal string title;

			[Token(Token = "0x40008B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal string description;

			[Token(Token = "0x17000295")]
			public int GroupId
			{
				[Token(Token = "0x600062B")]
				[Address(RVA = "0x24F18B4", Offset = "0x24F18B4", VA = "0x24F18B4")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000296")]
			public uint NumTrophies
			{
				[Token(Token = "0x600062C")]
				[Address(RVA = "0x24F18BC", Offset = "0x24F18BC", VA = "0x24F18BC")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x17000297")]
			public uint NumPlatinum
			{
				[Token(Token = "0x600062D")]
				[Address(RVA = "0x24F18C4", Offset = "0x24F18C4", VA = "0x24F18C4")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x17000298")]
			public uint NumGold
			{
				[Token(Token = "0x600062E")]
				[Address(RVA = "0x24F18CC", Offset = "0x24F18CC", VA = "0x24F18CC")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x17000299")]
			public uint NumSilver
			{
				[Token(Token = "0x600062F")]
				[Address(RVA = "0x24F18D4", Offset = "0x24F18D4", VA = "0x24F18D4")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x1700029A")]
			public uint NumBronze
			{
				[Token(Token = "0x6000630")]
				[Address(RVA = "0x24F18DC", Offset = "0x24F18DC", VA = "0x24F18DC")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x1700029B")]
			public string Title
			{
				[Token(Token = "0x6000631")]
				[Address(RVA = "0x24F18E4", Offset = "0x24F18E4", VA = "0x24F18E4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700029C")]
			public string Description
			{
				[Token(Token = "0x6000632")]
				[Address(RVA = "0x24F18EC", Offset = "0x24F18EC", VA = "0x24F18EC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000633")]
			[Address(RVA = "0x24F18F4", Offset = "0x24F18F4", VA = "0x24F18F4")]
			internal void Read(MemoryBuffer buffer)
			{
			}
		}

		[Token(Token = "0x200013C")]
		public struct NpTrophyGroupData
		{
			[Token(Token = "0x40008B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int groupId;

			[Token(Token = "0x40008B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal uint unlockedTrophies;

			[Token(Token = "0x40008BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal uint unlockedPlatinum;

			[Token(Token = "0x40008BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal uint unlockedGold;

			[Token(Token = "0x40008BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal uint unlockedSilver;

			[Token(Token = "0x40008BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal uint unlockedBronze;

			[Token(Token = "0x40008BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal uint progressPercentage;

			[Token(Token = "0x1700029D")]
			public int GroupId
			{
				[Token(Token = "0x6000634")]
				[Address(RVA = "0x24F17E4", Offset = "0x24F17E4", VA = "0x24F17E4")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700029E")]
			public uint UnlockedTrophies
			{
				[Token(Token = "0x6000635")]
				[Address(RVA = "0x24F17EC", Offset = "0x24F17EC", VA = "0x24F17EC")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x1700029F")]
			public uint UnlockedPlatinum
			{
				[Token(Token = "0x6000636")]
				[Address(RVA = "0x24F17F4", Offset = "0x24F17F4", VA = "0x24F17F4")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x170002A0")]
			public uint UnlockedGold
			{
				[Token(Token = "0x6000637")]
				[Address(RVA = "0x24F17FC", Offset = "0x24F17FC", VA = "0x24F17FC")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x170002A1")]
			public uint UnlockedSilver
			{
				[Token(Token = "0x6000638")]
				[Address(RVA = "0x24F1804", Offset = "0x24F1804", VA = "0x24F1804")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x170002A2")]
			public uint UnlockedBronze
			{
				[Token(Token = "0x6000639")]
				[Address(RVA = "0x24F180C", Offset = "0x24F180C", VA = "0x24F180C")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x170002A3")]
			public uint ProgressPercentage
			{
				[Token(Token = "0x600063A")]
				[Address(RVA = "0x24F1814", Offset = "0x24F1814", VA = "0x24F1814")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x600063B")]
			[Address(RVA = "0x24F181C", Offset = "0x24F181C", VA = "0x24F181C")]
			internal void Read(MemoryBuffer buffer)
			{
			}
		}

		[Token(Token = "0x200013D")]
		public class TrophyPackGroupResponse : ResponseBase
		{
			[Token(Token = "0x40008BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Icon icon;

			[Token(Token = "0x40008C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal NpTrophyGroupDetails staticConfiguration;

			[Token(Token = "0x40008C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal NpTrophyGroupData userProgress;

			[Token(Token = "0x170002A4")]
			public Icon Icon
			{
				[Token(Token = "0x600063C")]
				[Address(RVA = "0x24F1B9C", Offset = "0x24F1B9C", VA = "0x24F1B9C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002A5")]
			public NpTrophyGroupDetails StaticConfiguration
			{
				[Token(Token = "0x600063D")]
				[Address(RVA = "0x24F1BA4", Offset = "0x24F1BA4", VA = "0x24F1BA4")]
				get
				{
					return default(NpTrophyGroupDetails);
				}
			}

			[Token(Token = "0x170002A6")]
			public NpTrophyGroupData UserProgress
			{
				[Token(Token = "0x600063E")]
				[Address(RVA = "0x24F1BBC", Offset = "0x24F1BBC", VA = "0x24F1BBC")]
				get
				{
					return default(NpTrophyGroupData);
				}
			}

			[Token(Token = "0x600063F")]
			[Address(RVA = "0x24F1BD0", Offset = "0x24F1BD0", VA = "0x24F1BD0", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x6000640")]
			[Address(RVA = "0x24F1D00", Offset = "0x24F1D00", VA = "0x24F1D00")]
			public TrophyPackGroupResponse()
			{
			}
		}

		[Token(Token = "0x200013E")]
		public enum TrophyGrade
		{
			[Token(Token = "0x40008C3")]
			Unknown,
			[Token(Token = "0x40008C4")]
			Platinum,
			[Token(Token = "0x40008C5")]
			Gold,
			[Token(Token = "0x40008C6")]
			Silver,
			[Token(Token = "0x40008C7")]
			Bronze
		}

		[Token(Token = "0x200013F")]
		public struct NpTrophyDetails
		{
			[Token(Token = "0x40008C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int trophyId;

			[Token(Token = "0x40008C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal TrophyGrade trophyGrade;

			[Token(Token = "0x40008CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal int groupId;

			[Token(Token = "0x40008CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal bool hidden;

			[Token(Token = "0x40008CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal string name;

			[Token(Token = "0x40008CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal string description;

			[Token(Token = "0x170002A7")]
			public int TrophyId
			{
				[Token(Token = "0x6000641")]
				[Address(RVA = "0x24F1590", Offset = "0x24F1590", VA = "0x24F1590")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x170002A8")]
			public TrophyGrade TrophyGrade
			{
				[Token(Token = "0x6000642")]
				[Address(RVA = "0x24F1598", Offset = "0x24F1598", VA = "0x24F1598")]
				get
				{
					return default(TrophyGrade);
				}
			}

			[Token(Token = "0x170002A9")]
			public int GroupId
			{
				[Token(Token = "0x6000643")]
				[Address(RVA = "0x24F15A0", Offset = "0x24F15A0", VA = "0x24F15A0")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x170002AA")]
			public bool Hidden
			{
				[Token(Token = "0x6000644")]
				[Address(RVA = "0x24F15A8", Offset = "0x24F15A8", VA = "0x24F15A8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170002AB")]
			public string Name
			{
				[Token(Token = "0x6000645")]
				[Address(RVA = "0x24F15B0", Offset = "0x24F15B0", VA = "0x24F15B0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002AC")]
			public string Description
			{
				[Token(Token = "0x6000646")]
				[Address(RVA = "0x24F15B8", Offset = "0x24F15B8", VA = "0x24F15B8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0x24F15C0", Offset = "0x24F15C0", VA = "0x24F15C0")]
			internal void Read(MemoryBuffer buffer)
			{
			}
		}

		[Token(Token = "0x2000140")]
		public struct NpTrophyData
		{
			[Token(Token = "0x40008CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int trophyId;

			[Token(Token = "0x40008CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal bool unlocked;

			[Token(Token = "0x40008D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal DateTime timestamp;

			[Token(Token = "0x170002AD")]
			public int TrophyId
			{
				[Token(Token = "0x6000648")]
				[Address(RVA = "0x24F151C", Offset = "0x24F151C", VA = "0x24F151C")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x170002AE")]
			public bool Unlocked
			{
				[Token(Token = "0x6000649")]
				[Address(RVA = "0x24F1524", Offset = "0x24F1524", VA = "0x24F1524")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170002AF")]
			public DateTime Timestamp
			{
				[Token(Token = "0x600064A")]
				[Address(RVA = "0x24F152C", Offset = "0x24F152C", VA = "0x24F152C")]
				get
				{
					return default(DateTime);
				}
			}

			[Token(Token = "0x600064B")]
			[Address(RVA = "0x24F1534", Offset = "0x24F1534", VA = "0x24F1534")]
			internal void Read(MemoryBuffer buffer)
			{
			}
		}

		[Token(Token = "0x2000141")]
		public class TrophyPackTrophyResponse : ResponseBase
		{
			[Token(Token = "0x40008D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Icon icon;

			[Token(Token = "0x40008D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal NpTrophyDetails staticConfiguration;

			[Token(Token = "0x40008D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal NpTrophyData userProgress;

			[Token(Token = "0x170002B0")]
			public Icon Icon
			{
				[Token(Token = "0x600064C")]
				[Address(RVA = "0x24F1E74", Offset = "0x24F1E74", VA = "0x24F1E74")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002B1")]
			public NpTrophyDetails StaticConfiguration
			{
				[Token(Token = "0x600064D")]
				[Address(RVA = "0x24F1E7C", Offset = "0x24F1E7C", VA = "0x24F1E7C")]
				get
				{
					return default(NpTrophyDetails);
				}
			}

			[Token(Token = "0x170002B2")]
			public NpTrophyData UserProgress
			{
				[Token(Token = "0x600064E")]
				[Address(RVA = "0x24F1E8C", Offset = "0x24F1E8C", VA = "0x24F1E8C")]
				get
				{
					return default(NpTrophyData);
				}
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0x24F1E98", Offset = "0x24F1E98", VA = "0x24F1E98", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x6000650")]
			[Address(RVA = "0x24F1FC8", Offset = "0x24F1FC8", VA = "0x24F1FC8")]
			public TrophyPackTrophyResponse()
			{
			}
		}

		[PreserveSig]
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x24F05B0", Offset = "0x24F05B0", VA = "0x24F05B0")]
		private static extern int PrxRegisterTrophyPack(RegisterTrophyPackRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x24F066C", Offset = "0x24F066C", VA = "0x24F066C")]
		private static extern int PrxUnlockTrophy(UnlockTrophyRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x24F0728", Offset = "0x24F0728", VA = "0x24F0728")]
		private static extern int PrxSetScreenshot(SetScreenshotRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x24F07DC", Offset = "0x24F07DC", VA = "0x24F07DC")]
		private static extern int PrxGetUnlockedTrophies(GetUnlockedTrophiesRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x24F0898", Offset = "0x24F0898", VA = "0x24F0898")]
		private static extern int PrxDisplayTrophyListDialog(DisplayTrophyListDialogRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x24F0954", Offset = "0x24F0954", VA = "0x24F0954")]
		private static extern int PrxGetTrophyPackSummary(GetTrophyPackSummaryRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x24F0A1C", Offset = "0x24F0A1C", VA = "0x24F0A1C")]
		private static extern int PrxGetTrophyPackGroup(GetTrophyPackGroupRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x24F0AE0", Offset = "0x24F0AE0", VA = "0x24F0AE0")]
		private static extern int PrxGetTrophyPackTrophy(GetTrophyPackTrophyRequest request, out APIResult result);

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x24F0BA4", Offset = "0x24F0BA4", VA = "0x24F0BA4")]
		public static int RegisterTrophyPack(RegisterTrophyPackRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x24F0CAC", Offset = "0x24F0CAC", VA = "0x24F0CAC")]
		public static int SetScreenshot(SetScreenshotRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x24F0DB4", Offset = "0x24F0DB4", VA = "0x24F0DB4")]
		public static int UnlockTrophy(UnlockTrophyRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x24F0EE4", Offset = "0x24F0EE4", VA = "0x24F0EE4")]
		public static int GetUnlockedTrophies(GetUnlockedTrophiesRequest request, UnlockedTrophiesResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x24F0FEC", Offset = "0x24F0FEC", VA = "0x24F0FEC")]
		public static int DisplayTrophyListDialog(DisplayTrophyListDialogRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x24F10F4", Offset = "0x24F10F4", VA = "0x24F10F4")]
		public static int GetTrophyPackSummary(GetTrophyPackSummaryRequest request, TrophyPackSummaryResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x24F11FC", Offset = "0x24F11FC", VA = "0x24F11FC")]
		public static int GetTrophyPackGroup(GetTrophyPackGroupRequest request, TrophyPackGroupResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x24F1304", Offset = "0x24F1304", VA = "0x24F1304")]
		public static int GetTrophyPackTrophy(GetTrophyPackTrophyRequest request, TrophyPackTrophyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x24F140C", Offset = "0x24F140C", VA = "0x24F140C")]
		public Trophies()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class Tss
	{
		[StructLayout(0)]
		[Token(Token = "0x2000142")]
		public class GetDataRequest : RequestBase
		{
			[Token(Token = "0x40008D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ulong offset;

			[Token(Token = "0x40008D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal ulong length;

			[Token(Token = "0x40008D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal ulong lastModifiedTicks;

			[Token(Token = "0x40008D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal int tssSlotId;

			[Token(Token = "0x40008D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			internal bool retrieveStatusOnly;

			[Token(Token = "0x170002B3")]
			public ulong Offset
			{
				[Token(Token = "0x6000651")]
				[Address(RVA = "0x24F23BC", Offset = "0x24F23BC", VA = "0x24F23BC")]
				get
				{
					return default(ulong);
				}
				[Token(Token = "0x6000652")]
				[Address(RVA = "0x24F23C4", Offset = "0x24F23C4", VA = "0x24F23C4")]
				set
				{
				}
			}

			[Token(Token = "0x170002B4")]
			public ulong Length
			{
				[Token(Token = "0x6000653")]
				[Address(RVA = "0x24F23CC", Offset = "0x24F23CC", VA = "0x24F23CC")]
				get
				{
					return default(ulong);
				}
				[Token(Token = "0x6000654")]
				[Address(RVA = "0x24F23D4", Offset = "0x24F23D4", VA = "0x24F23D4")]
				set
				{
				}
			}

			[Token(Token = "0x170002B5")]
			public DateTime LastModifiedTicks
			{
				[Token(Token = "0x6000655")]
				[Address(RVA = "0x24F23DC", Offset = "0x24F23DC", VA = "0x24F23DC")]
				get
				{
					return default(DateTime);
				}
				[Token(Token = "0x6000656")]
				[Address(RVA = "0x24F23E8", Offset = "0x24F23E8", VA = "0x24F23E8")]
				set
				{
				}
			}

			[Token(Token = "0x170002B6")]
			public int TssSlotId
			{
				[Token(Token = "0x6000657")]
				[Address(RVA = "0x24F2414", Offset = "0x24F2414", VA = "0x24F2414")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000658")]
				[Address(RVA = "0x24F241C", Offset = "0x24F241C", VA = "0x24F241C")]
				set
				{
				}
			}

			[Token(Token = "0x170002B7")]
			public bool RetrieveStatusOnly
			{
				[Token(Token = "0x6000659")]
				[Address(RVA = "0x24F2424", Offset = "0x24F2424", VA = "0x24F2424")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600065A")]
				[Address(RVA = "0x24F242C", Offset = "0x24F242C", VA = "0x24F242C")]
				set
				{
				}
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0x24F2438", Offset = "0x24F2438", VA = "0x24F2438")]
			public GetDataRequest()
			{
			}
		}

		[Token(Token = "0x2000143")]
		public enum TssStatusCodes
		{
			[Token(Token = "0x40008DA")]
			Ok,
			[Token(Token = "0x40008DB")]
			Partial,
			[Token(Token = "0x40008DC")]
			NotModified
		}

		[Token(Token = "0x2000144")]
		public class TssDataResponse : ResponseBase
		{
			[Token(Token = "0x40008DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal byte[] data;

			[Token(Token = "0x40008DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal DateTime lastModified;

			[Token(Token = "0x40008DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal TssStatusCodes statusCode;

			[Token(Token = "0x40008E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal long contentLength;

			[Token(Token = "0x170002B8")]
			public byte[] Data
			{
				[Token(Token = "0x600065C")]
				[Address(RVA = "0x24F2444", Offset = "0x24F2444", VA = "0x24F2444")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002B9")]
			public DateTime LastModified
			{
				[Token(Token = "0x600065D")]
				[Address(RVA = "0x24F244C", Offset = "0x24F244C", VA = "0x24F244C")]
				get
				{
					return default(DateTime);
				}
			}

			[Token(Token = "0x170002BA")]
			public TssStatusCodes StatusCode
			{
				[Token(Token = "0x600065E")]
				[Address(RVA = "0x24F2454", Offset = "0x24F2454", VA = "0x24F2454")]
				get
				{
					return default(TssStatusCodes);
				}
			}

			[Token(Token = "0x170002BB")]
			public long ContentLength
			{
				[Token(Token = "0x600065F")]
				[Address(RVA = "0x24F245C", Offset = "0x24F245C", VA = "0x24F245C")]
				get
				{
					return default(long);
				}
			}

			[Token(Token = "0x6000660")]
			[Address(RVA = "0x24F2464", Offset = "0x24F2464", VA = "0x24F2464", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0x24F25AC", Offset = "0x24F25AC", VA = "0x24F25AC")]
			public TssDataResponse()
			{
			}
		}

		[PreserveSig]
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x24F21C8", Offset = "0x24F21C8", VA = "0x24F21C8")]
		private static extern int PrxTssGetData(GetDataRequest request, out APIResult result);

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x24F22AC", Offset = "0x24F22AC", VA = "0x24F22AC")]
		public static int GetData(GetDataRequest request, TssDataResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x24F23B4", Offset = "0x24F23B4", VA = "0x24F23B4")]
		public Tss()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class Tus
	{
		[Token(Token = "0x2000145")]
		public struct VirtualUserID
		{
			[Token(Token = "0x40008E1")]
			public const int NP_ONLINEID_MAX_LENGTH = 16;

			[Token(Token = "0x40008E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal string name;

			[Token(Token = "0x170002BC")]
			public string Name
			{
				[Token(Token = "0x6000662")]
				[Address(RVA = "0x2521670", Offset = "0x2521670", VA = "0x2521670")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000663")]
				[Address(RVA = "0x2521678", Offset = "0x2521678", VA = "0x2521678")]
				set
				{
				}
			}

			[Token(Token = "0x6000664")]
			[Address(RVA = "0x252175C", Offset = "0x252175C", VA = "0x252175C")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x6000665")]
			[Address(RVA = "0x2521780", Offset = "0x2521780", VA = "0x2521780", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x2000146")]
		public struct VariableInput
		{
			[Token(Token = "0x40008E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal long varValue;

			[Token(Token = "0x40008E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal int slotId;

			[Token(Token = "0x170002BD")]
			public long Value
			{
				[Token(Token = "0x6000666")]
				[Address(RVA = "0x2521270", Offset = "0x2521270", VA = "0x2521270")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6000667")]
				[Address(RVA = "0x2521278", Offset = "0x2521278", VA = "0x2521278")]
				set
				{
				}
			}

			[Token(Token = "0x170002BE")]
			public int SlotId
			{
				[Token(Token = "0x6000668")]
				[Address(RVA = "0x2521280", Offset = "0x2521280", VA = "0x2521280")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000669")]
				[Address(RVA = "0x2521288", Offset = "0x2521288", VA = "0x2521288")]
				set
				{
				}
			}
		}

		[Token(Token = "0x2000147")]
		public struct UserInput
		{
			[Token(Token = "0x40008E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal VirtualUserID virtualId;

			[Token(Token = "0x40008E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Core.NpAccountId realId;

			[Token(Token = "0x40008E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool isVirtual;

			[Token(Token = "0x170002BF")]
			public VirtualUserID VirtualId
			{
				[Token(Token = "0x600066A")]
				[Address(RVA = "0x25210E0", Offset = "0x25210E0", VA = "0x25210E0")]
				get
				{
					return default(VirtualUserID);
				}
				[Token(Token = "0x600066B")]
				[Address(RVA = "0x2521168", Offset = "0x2521168", VA = "0x2521168")]
				set
				{
				}
			}

			[Token(Token = "0x170002C0")]
			public Core.NpAccountId RealId
			{
				[Token(Token = "0x600066C")]
				[Address(RVA = "0x2521178", Offset = "0x2521178", VA = "0x2521178")]
				get
				{
					return default(Core.NpAccountId);
				}
				[Token(Token = "0x600066D")]
				[Address(RVA = "0x2521200", Offset = "0x2521200", VA = "0x2521200")]
				set
				{
				}
			}

			[Token(Token = "0x170002C1")]
			public bool IsVirtual
			{
				[Token(Token = "0x600066E")]
				[Address(RVA = "0x252120C", Offset = "0x252120C", VA = "0x252120C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600066F")]
			[Address(RVA = "0x2521214", Offset = "0x2521214", VA = "0x2521214")]
			public UserInput(VirtualUserID id)
			{
			}

			[Token(Token = "0x6000670")]
			[Address(RVA = "0x252124C", Offset = "0x252124C", VA = "0x252124C")]
			public UserInput(Core.NpAccountId id)
			{
			}
		}

		[Token(Token = "0x2000148")]
		public class NpVariableBase
		{
			[Token(Token = "0x40008E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool hasData;

			[Token(Token = "0x40008E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal DateTime lastChangedDate;

			[Token(Token = "0x40008EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal long variable;

			[Token(Token = "0x40008EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal long oldVariable;

			[Token(Token = "0x40008EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Core.NpAccountId ownerAccountId;

			[Token(Token = "0x40008ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal Core.NpAccountId lastChangedAuthorAccountId;

			[Token(Token = "0x170002C2")]
			public bool HasData
			{
				[Token(Token = "0x6000671")]
				[Address(RVA = "0x2520A8C", Offset = "0x2520A8C", VA = "0x2520A8C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170002C3")]
			public DateTime LastChangedDate
			{
				[Token(Token = "0x6000672")]
				[Address(RVA = "0x2520A94", Offset = "0x2520A94", VA = "0x2520A94")]
				get
				{
					return default(DateTime);
				}
			}

			[Token(Token = "0x170002C4")]
			public long Variable
			{
				[Token(Token = "0x6000673")]
				[Address(RVA = "0x2520A9C", Offset = "0x2520A9C", VA = "0x2520A9C")]
				get
				{
					return default(long);
				}
			}

			[Token(Token = "0x170002C5")]
			public long OldVariable
			{
				[Token(Token = "0x6000674")]
				[Address(RVA = "0x2520AA4", Offset = "0x2520AA4", VA = "0x2520AA4")]
				get
				{
					return default(long);
				}
			}

			[Token(Token = "0x170002C6")]
			public Core.NpAccountId OwnerAccountId
			{
				[Token(Token = "0x6000675")]
				[Address(RVA = "0x2520AAC", Offset = "0x2520AAC", VA = "0x2520AAC")]
				get
				{
					return default(Core.NpAccountId);
				}
			}

			[Token(Token = "0x170002C7")]
			public Core.NpAccountId LastChangedAuthorAccountId
			{
				[Token(Token = "0x6000676")]
				[Address(RVA = "0x2520AB4", Offset = "0x2520AB4", VA = "0x2520AB4")]
				get
				{
					return default(Core.NpAccountId);
				}
			}

			[Token(Token = "0x6000677")]
			[Address(RVA = "0x25209FC", Offset = "0x25209FC", VA = "0x25209FC")]
			internal void ReadBase(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x6000678")]
			[Address(RVA = "0x2520A84", Offset = "0x2520A84", VA = "0x2520A84")]
			public NpVariableBase()
			{
			}
		}

		[Token(Token = "0x2000149")]
		public class NpVariable : NpVariableBase
		{
			[Token(Token = "0x40008EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal Core.OnlineID ownerId;

			[Token(Token = "0x40008EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal Core.OnlineID lastChangedAuthorId;

			[Token(Token = "0x170002C8")]
			public Core.OnlineID OwnerId
			{
				[Token(Token = "0x6000679")]
				[Address(RVA = "0x25209EC", Offset = "0x25209EC", VA = "0x25209EC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002C9")]
			public Core.OnlineID LastChangedAuthorId
			{
				[Token(Token = "0x600067A")]
				[Address(RVA = "0x25209F4", Offset = "0x25209F4", VA = "0x25209F4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600067B")]
			[Address(RVA = "0x251E6C0", Offset = "0x251E6C0", VA = "0x251E6C0")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x600067C")]
			[Address(RVA = "0x251E6B8", Offset = "0x251E6B8", VA = "0x251E6B8")]
			public NpVariable()
			{
			}
		}

		[Token(Token = "0x200014A")]
		public class NpVariableForCrossSave : NpVariableBase
		{
			[Token(Token = "0x40008F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal Core.NpId ownerId;

			[Token(Token = "0x40008F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal Core.NpId lastChangedAuthorId;

			[Token(Token = "0x170002CA")]
			public Core.NpId OwnerId
			{
				[Token(Token = "0x600067D")]
				[Address(RVA = "0x2520ABC", Offset = "0x2520ABC", VA = "0x2520ABC")]
				get
				{
					return default(Core.NpId);
				}
			}

			[Token(Token = "0x170002CB")]
			public Core.NpId LastChangedAuthorId
			{
				[Token(Token = "0x600067E")]
				[Address(RVA = "0x2520AC8", Offset = "0x2520AC8", VA = "0x2520AC8")]
				get
				{
					return default(Core.NpId);
				}
			}

			[Token(Token = "0x600067F")]
			[Address(RVA = "0x251E678", Offset = "0x251E678", VA = "0x251E678")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x6000680")]
			[Address(RVA = "0x251E670", Offset = "0x251E670", VA = "0x251E670")]
			public NpVariableForCrossSave()
			{
			}
		}

		[Token(Token = "0x200014B")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE1954", Offset = "0xCE1954")]
		public class NpTusDataStatusBase
		{
			[Token(Token = "0x170002CC")]
			public bool HasData
			{
				[Token(Token = "0x6000681")]
				[Address(RVA = "0x2520994", Offset = "0x2520994", VA = "0x2520994")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170002CD")]
			public DateTime LastChangedDate
			{
				[Token(Token = "0x6000682")]
				[Address(RVA = "0x252099C", Offset = "0x252099C", VA = "0x252099C")]
				get
				{
					return default(DateTime);
				}
			}

			[Token(Token = "0x170002CE")]
			public byte[] Data
			{
				[Token(Token = "0x6000683")]
				[Address(RVA = "0x25209A4", Offset = "0x25209A4", VA = "0x25209A4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002CF")]
			public byte[] SupplementaryInfo
			{
				[Token(Token = "0x6000684")]
				[Address(RVA = "0x25209AC", Offset = "0x25209AC", VA = "0x25209AC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002D0")]
			public Core.NpAccountId OwnerAccountId
			{
				[Token(Token = "0x6000685")]
				[Address(RVA = "0x25209B4", Offset = "0x25209B4", VA = "0x25209B4")]
				get
				{
					return default(Core.NpAccountId);
				}
			}

			[Token(Token = "0x170002D1")]
			public Core.NpAccountId LastChangedAuthorAccountId
			{
				[Token(Token = "0x6000686")]
				[Address(RVA = "0x25209C0", Offset = "0x25209C0", VA = "0x25209C0")]
				get
				{
					return default(Core.NpAccountId);
				}
			}

			[Token(Token = "0x6000687")]
			[Address(RVA = "0x252098C", Offset = "0x252098C", VA = "0x252098C")]
			public NpTusDataStatusBase()
			{
			}
		}

		[Token(Token = "0x200014C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE198C", Offset = "0xCE198C")]
		public class NpTusDataStatus : NpTusDataStatusBase
		{
			[Token(Token = "0x170002D2")]
			public Core.OnlineID OwnerId
			{
				[Token(Token = "0x6000688")]
				[Address(RVA = "0x25208CC", Offset = "0x25208CC", VA = "0x25208CC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002D3")]
			public Core.OnlineID LastChangedAuthorId
			{
				[Token(Token = "0x6000689")]
				[Address(RVA = "0x2520928", Offset = "0x2520928", VA = "0x2520928")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600068A")]
			[Address(RVA = "0x2520984", Offset = "0x2520984", VA = "0x2520984")]
			public NpTusDataStatus()
			{
			}
		}

		[Token(Token = "0x200014D")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE19C4", Offset = "0xCE19C4")]
		public class NpTusDataStatusForCrossSave : NpTusDataStatusBase
		{
			[Token(Token = "0x170002D4")]
			public Core.NpId OwnerId
			{
				[Token(Token = "0x600068B")]
				[Address(RVA = "0x25209CC", Offset = "0x25209CC", VA = "0x25209CC")]
				get
				{
					return default(Core.NpId);
				}
			}

			[Token(Token = "0x170002D5")]
			public Core.NpId LastChangedAuthorId
			{
				[Token(Token = "0x600068C")]
				[Address(RVA = "0x25209D8", Offset = "0x25209D8", VA = "0x25209D8")]
				get
				{
					return default(Core.NpId);
				}
			}

			[Token(Token = "0x600068D")]
			[Address(RVA = "0x25209E4", Offset = "0x25209E4", VA = "0x25209E4")]
			public NpTusDataStatusForCrossSave()
			{
			}
		}

		[Token(Token = "0x200014E")]
		public class TusDataStatusBase
		{
			[Token(Token = "0x40008F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool hasData;

			[Token(Token = "0x40008F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal DateTime lastChangedDate;

			[Token(Token = "0x40008F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal byte[] supplementaryInfo;

			[Token(Token = "0x170002D6")]
			public bool HasData
			{
				[Token(Token = "0x600068E")]
				[Address(RVA = "0x25210A0", Offset = "0x25210A0", VA = "0x25210A0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170002D7")]
			public DateTime LastChangedDate
			{
				[Token(Token = "0x600068F")]
				[Address(RVA = "0x25210A8", Offset = "0x25210A8", VA = "0x25210A8")]
				get
				{
					return default(DateTime);
				}
			}

			[Token(Token = "0x170002D8")]
			public byte[] SupplementaryInfo
			{
				[Token(Token = "0x6000690")]
				[Address(RVA = "0x25210B0", Offset = "0x25210B0", VA = "0x25210B0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000691")]
			[Address(RVA = "0x2521040", Offset = "0x2521040", VA = "0x2521040")]
			internal void ReadBase(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x6000692")]
			[Address(RVA = "0x2521098", Offset = "0x2521098", VA = "0x2521098")]
			public TusDataStatusBase()
			{
			}
		}

		[Token(Token = "0x200014F")]
		public class TusDataStatus : TusDataStatusBase
		{
			[Token(Token = "0x40008F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Core.OnlineUser owner;

			[Token(Token = "0x40008F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Core.OnlineUser lastChangedBy;

			[Token(Token = "0x170002D9")]
			public Core.OnlineUser Owner
			{
				[Token(Token = "0x6000693")]
				[Address(RVA = "0x2521030", Offset = "0x2521030", VA = "0x2521030")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170002DA")]
			public Core.OnlineUser LastChangedBy
			{
				[Token(Token = "0x6000694")]
				[Address(RVA = "0x2521038", Offset = "0x2521038", VA = "0x2521038")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000695")]
			[Address(RVA = "0x251EBB4", Offset = "0x251EBB4", VA = "0x251EBB4")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x6000696")]
			[Address(RVA = "0x251EBAC", Offset = "0x251EBAC", VA = "0x251EBAC")]
			public TusDataStatus()
			{
			}
		}

		[Token(Token = "0x2000150")]
		public class TusDataStatusForCrossSave : TusDataStatusBase
		{
			[Token(Token = "0x40008F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Core.NpAccountId ownerAccountId;

			[Token(Token = "0x40008F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Core.NpAccountId lastChangedByAccountId;

			[Token(Token = "0x40008F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal Core.NpId ownerNpId;

			[Token(Token = "0x40008FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal Core.NpId lastChangedByNpId;

			[Token(Token = "0x170002DB")]
			public Core.NpAccountId OwnerAccountId
			{
				[Token(Token = "0x6000697")]
				[Address(RVA = "0x25210B8", Offset = "0x25210B8", VA = "0x25210B8")]
				get
				{
					return default(Core.NpAccountId);
				}
			}

			[Token(Token = "0x170002DC")]
			public Core.NpAccountId LastChangedByAccountId
			{
				[Token(Token = "0x6000698")]
				[Address(RVA = "0x25210C0", Offset = "0x25210C0", VA = "0x25210C0")]
				get
				{
					return default(Core.NpAccountId);
				}
			}

			[Token(Token = "0x170002DD")]
			public Core.NpId OwnerNpId
			{
				[Token(Token = "0x6000699")]
				[Address(RVA = "0x25210C8", Offset = "0x25210C8", VA = "0x25210C8")]
				get
				{
					return default(Core.NpId);
				}
			}

			[Token(Token = "0x170002DE")]
			public Core.NpId LastChangedByNpId
			{
				[Token(Token = "0x600069A")]
				[Address(RVA = "0x25210D4", Offset = "0x25210D4", VA = "0x25210D4")]
				get
				{
					return default(Core.NpId);
				}
			}

			[Token(Token = "0x600069B")]
			[Address(RVA = "0x251EB4C", Offset = "0x251EB4C", VA = "0x251EB4C")]
			internal void Read(MemoryBuffer buffer)
			{
			}

			[Token(Token = "0x600069C")]
			[Address(RVA = "0x251EB44", Offset = "0x251EB44", VA = "0x251EB44")]
			public TusDataStatusForCrossSave()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x2000151")]
		public class SetVariablesRequest : RequestBase
		{
			[Token(Token = "0x40008FB")]
			public const int MAX_VARIABLE_SLOTS = 256;

			[Token(Token = "0x40008FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal UserInput tusUser;

			[Token(Token = "0x40008FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal ulong numVars;

			[Token(Token = "0x40008FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private VariableInput[] variables;

			[Token(Token = "0x170002DF")]
			public VariableInput[] Vars
			{
				[Token(Token = "0x600069D")]
				[Address(RVA = "0x2520D5C", Offset = "0x2520D5C", VA = "0x2520D5C")]
				get
				{
					return null;
				}
				[Token(Token = "0x600069E")]
				[Address(RVA = "0x2520DF4", Offset = "0x2520DF4", VA = "0x2520DF4")]
				set
				{
				}
			}

			[Token(Token = "0x170002E0")]
			public UserInput TusUser
			{
				[Token(Token = "0x600069F")]
				[Address(RVA = "0x2520EE8", Offset = "0x2520EE8", VA = "0x2520EE8")]
				get
				{
					return default(UserInput);
				}
				[Token(Token = "0x60006A0")]
				[Address(RVA = "0x2520EFC", Offset = "0x2520EFC", VA = "0x2520EFC")]
				set
				{
				}
			}

			[Token(Token = "0x170002E1")]
			[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE1C94", Offset = "0xCE1C94")]
			public Core.NpAccountId TargetUser
			{
				[Token(Token = "0x60006A1")]
				[Address(RVA = "0x2520F10", Offset = "0x2520F10", VA = "0x2520F10")]
				get
				{
					return default(Core.NpAccountId);
				}
				[Token(Token = "0x60006A2")]
				[Address(RVA = "0x2520F1C", Offset = "0x2520F1C", VA = "0x2520F1C")]
				set
				{
				}
			}

			[Token(Token = "0x170002E2")]
			[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE1CCC", Offset = "0xCE1CCC")]
			public VirtualUserID VirtualUserID
			{
				[Token(Token = "0x60006A3")]
				[Address(RVA = "0x2520F20", Offset = "0x2520F20", VA = "0x2520F20")]
				get
				{
					return default(VirtualUserID);
				}
				[Token(Token = "0x60006A4")]
				[Address(RVA = "0x2520F28", Offset = "0x2520F28", VA = "0x2520F28")]
				set
				{
				}
			}

			[Token(Token = "0x170002E3")]
			[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE1D04", Offset = "0xCE1D04")]
			public bool IsVirtualUser
			{
				[Token(Token = "0x60006A5")]
				[Address(RVA = "0x2520F2C", Offset = "0x2520F2C", VA = "0x2520F2C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x2520F34", Offset = "0x2520F34", VA = "0x2520F34")]
			public SetVariablesRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x2000152")]
		public class GetVariablesRequest : RequestBase
		{
			[Token(Token = "0x40008FF")]
			public const int MAX_VARIABLE_SLOTS = 256;

			[Token(Token = "0x4000900")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal UserInput tusUser;

			[Token(Token = "0x4000901")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal ulong numSlots;

			[Token(Token = "0x4000902")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal int[] slotIds;

			[Token(Token = "0x4000903")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal bool forCrossSave;

			[Token(Token = "0x170002E4")]
			public int[] SlotIds
			{
				[Token(Token = "0x60006A7")]
				[Address(RVA = "0x252068C", Offset = "0x252068C", VA = "0x252068C")]
				get
				{
					return null;
				}
				[Token(Token = "0x60006A8")]
				[Address(RVA = "0x2520724", Offset = "0x2520724", VA = "0x2520724")]
				set
				{
				}
			}

			[Token(Token = "0x170002E5")]
			public UserInput TusUser
			{
				[Token(Token = "0x60006A9")]
				[Address(RVA = "0x2520818", Offset = "0x2520818", VA = "0x2520818")]
				get
				{
					return default(UserInput);
				}
				[Token(Token = "0x60006AA")]
				[Address(RVA = "0x252082C", Offset = "0x252082C", VA = "0x252082C")]
				set
				{
				}
			}

			[Token(Token = "0x170002E6")]
			[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE1D3C", Offset = "0xCE1D3C")]
			public Core.NpAccountId TargetUser
			{
				[Token(Token = "0x60006AB")]
				[Address(RVA = "0x2520840", Offset = "0x2520840", VA = "0x2520840")]
				get
				{
					return default(Core.NpAccountId);
				}
				[Token(Token = "0x60006AC")]
				[Address(RVA = "0x252084C", Offset = "0x252084C", VA = "0x252084C")]
				set
				{
				}
			}

			[Token(Token = "0x170002E7")]
			[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE1D74", Offset = "0xCE1D74")]
			public VirtualUserID VirtualUserID
			{
				[Token(Token = "0x60006AD")]
				[Address(RVA = "0x2520850", Offset = "0x2520850", VA = "0x2520850")]
				get
				{
					return default(VirtualUserID);
				}
				[Token(Token = "0x60006AE")]
				[Address(RVA = "0x2520858", Offset = "0x2520858", VA = "0x2520858")]
				set
				{
				}
			}

			[Token(Token = "0x170002E8")]
			[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE1DAC", Offset = "0xCE1DAC")]
			public bool IsVirtualUser
			{
				[Token(Token = "0x60006AF")]
				[Address(RVA = "0x252085C", Offset = "0x252085C", VA = "0x252085C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x2520864", Offset = "0x2520864", VA = "0x2520864")]
			public GetVariablesRequest()
			{
			}
		}

		[Token(Token = "0x2000153")]
		public struct DataContention
		{
			[Token(Token = "0x4000904")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ulong lastChangedDateTicks;

			[Token(Token = "0x4000905")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Core.NpAccountId requiredLastChangeUser;

			[Token(Token = "0x170002E9")]
			public DateTime LastChangedDate
			{
				[Token(Token = "0x60006B1")]
				[Address(RVA = "0x251E780", Offset = "0x251E780", VA = "0x251E780")]
				get
				{
					return default(DateTime);
				}
				[Token(Token = "0x60006B2")]
				[Address(RVA = "0x251E78C", Offset = "0x251E78C", VA = "0x251E78C")]
				set
				{
				}
			}

			[Token(Token = "0x170002EA")]
			public Core.NpAccountId RequiredLastChangeUser
			{
				[Token(Token = "0x60006B3")]
				[Address(RVA = "0x251E7B8", Offset = "0x251E7B8", VA = "0x251E7B8")]
				get
				{
					return default(Core.NpAccountId);
				}
				[Token(Token = "0x60006B4")]
				[Address(RVA = "0x251E7C0", Offset = "0x251E7C0", VA = "0x251E7C0")]
				set
				{
				}
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x2000154")]
		public class AddToAndGetVariableRequest : RequestBase
		{
			[Token(Token = "0x4000906")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal UserInput tusUser;

			[Token(Token = "0x4000907")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal VariableInput var;

			[Token(Token = "0x4000908")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal DataContention dataContention;

			[Token(Token = "0x4000909")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal bool forCrossSave;

			[Token(Token = "0x170002EB")]
			public UserInput TusUser
			{
				[Token(Token = "0x60006B5")]
				[Address(RVA = "0x251E2E8", Offset = "0x251E2E8", VA = "0x251E2E8")]
				get
				{
					return default(UserInput);
				}
				[Token(Token = "0x60006B6")]
				[Address(RVA = "0x251E2FC", Offset = "0x251E2FC", VA = "0x251E2FC")]
				set
				{
				}
			}

			[Token(Token = "0x170002EC")]
			public VariableInput Var
			{
				[Token(Token = "0x60006B7")]
				[Address(RVA = "0x251E310", Offset = "0x251E310", VA = "0x251E310")]
				get
				{
					return default(VariableInput);
				}
				[Token(Token = "0x60006B8")]
				[Address(RVA = "0x251E31C", Offset = "0x251E31C", VA = "0x251E31C")]
				set
				{
				}
			}

			[Token(Token = "0x170002ED")]
			public DataContention DataContention
			{
				[Token(Token = "0x60006B9")]
				[Address(RVA = "0x251E324", Offset = "0x251E324", VA = "0x251E324")]
				get
				{
					return default(DataContention);
				}
				[Token(Token = "0x60006BA")]
				[Address(RVA = "0x251E330", Offset = "0x251E330", VA = "0x251E330")]
				set
				{
				}
			}

			[Token(Token = "0x170002EE")]
			public bool ForCrossSave
			{
				[Token(Token = "0x60006BB")]
				[Address(RVA = "0x251E338", Offset = "0x251E338", VA = "0x251E338")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60006BC")]
				[Address(RVA = "0x251E340", Offset = "0x251E340", VA = "0x251E340")]
				set
				{
				}
			}

			[Token(Token = "0x170002EF")]
			[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE1DE4", Offset = "0xCE1DE4")]
			public Core.NpAccountId TargetUser
			{
				[Token(Token = "0x60006BD")]
				[Address(RVA = "0x251E34C", Offset = "0x251E34C", VA = "0x251E34C")]
				get
				{
					return default(Core.NpAccountId);
				}
				[Token(Token = "0x60006BE")]
				[Address(RVA = "0x251E358", Offset = "0x251E358", VA = "0x251E358")]
				set
				{
				}
			}

			[Token(Token = "0x170002F0")]
			[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE1E1C", Offset = "0xCE1E1C")]
			public VirtualUserID VirtualUserID
			{
				[Token(Token = "0x60006BF")]
				[Address(RVA = "0x251E35C", Offset = "0x251E35C", VA = "0x251E35C")]
				get
				{
					return default(VirtualUserID);
				}
				[Token(Token = "0x60006C0")]
				[Address(RVA = "0x251E364", Offset = "0x251E364", VA = "0x251E364")]
				set
				{
				}
			}

			[Token(Token = "0x170002F1")]
			[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE1E54", Offset = "0xCE1E54")]
			public bool IsVirtualUser
			{
				[Token(Token = "0x60006C1")]
				[Address(RVA = "0x251E368", Offset = "0x251E368", VA = "0x251E368")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x251E370", Offset = "0x251E370", VA = "0x251E370")]
			public AddToAndGetVariableRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x2000155")]
		public class SetDataRequest : RequestBase
		{
			[Token(Token = "0x400090A")]
			public const int NP_TUS_DATA_INFO_MAX_SIZE = 384;

			[Token(Token = "0x400090B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal UserInput tusUser;

			[Token(Token = "0x400090C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal byte[] data;

			[Token(Token = "0x400090D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal ulong dataSize;

			[Token(Token = "0x400090E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal ulong supplementaryInfoSize;

			[Token(Token = "0x400090F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal byte[] supplementaryInfo;

			[Token(Token = "0x4000910")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal DataContention dataContention;

			[Token(Token = "0x4000911")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			internal int slotId;

			[Token(Token = "0x170002F2")]
			public UserInput TusUser
			{
				[Token(Token = "0x60006C3")]
				[Address(RVA = "0x2520AD4", Offset = "0x2520AD4", VA = "0x2520AD4")]
				get
				{
					return default(UserInput);
				}
				[Token(Token = "0x60006C4")]
				[Address(RVA = "0x2520AE8", Offset = "0x2520AE8", VA = "0x2520AE8")]
				set
				{
				}
			}

			[Token(Token = "0x170002F3")]
			public byte[] Data
			{
				[Token(Token = "0x60006C5")]
				[Address(RVA = "0x2520AFC", Offset = "0x2520AFC", VA = "0x2520AFC")]
				get
				{
					return null;
				}
				[Token(Token = "0x60006C6")]
				[Address(RVA = "0x2520B04", Offset = "0x2520B04", VA = "0x2520B04")]
				set
				{
				}
			}

			[Token(Token = "0x170002F4")]
			public byte[] SupplementaryInfo
			{
				[Token(Token = "0x60006C7")]
				[Address(RVA = "0x2520B20", Offset = "0x2520B20", VA = "0x2520B20")]
				get
				{
					return null;
				}
				[Token(Token = "0x60006C8")]
				[Address(RVA = "0x2520BB8", Offset = "0x2520BB8", VA = "0x2520BB8")]
				set
				{
				}
			}

			[Token(Token = "0x170002F5")]
			public int SlotId
			{
				[Token(Token = "0x60006C9")]
				[Address(RVA = "0x2520CAC", Offset = "0x2520CAC", VA = "0x2520CAC")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60006CA")]
				[Address(RVA = "0x2520CB4", Offset = "0x2520CB4", VA = "0x2520CB4")]
				set
				{
				}
			}

			[Token(Token = "0x170002F6")]
			public DataContention DataContention
			{
				[Token(Token = "0x60006CB")]
				[Address(RVA = "0x2520CBC", Offset = "0x2520CBC", VA = "0x2520CBC")]
				get
				{
					return default(DataContention);
				}
				[Token(Token = "0x60006CC")]
				[Address(RVA = "0x2520CC8", Offset = "0x2520CC8", VA = "0x2520CC8")]
				set
				{
				}
			}

			[Token(Token = "0x170002F7")]
			[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE1E8C", Offset = "0xCE1E8C")]
			public Core.NpAccountId TargetUser
			{
				[Token(Token = "0x60006CD")]
				[Address(RVA = "0x2520CD0", Offset = "0x2520CD0", VA = "0x2520CD0")]
				get
				{
					return default(Core.NpAccountId);
				}
				[Token(Token = "0x60006CE")]
				[Address(RVA = "0x2520CDC", Offset = "0x2520CDC", VA = "0x2520CDC")]
				set
				{
				}
			}

			[Token(Token = "0x170002F8")]
			[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE1EC4", Offset = "0xCE1EC4")]
			public VirtualUserID VirtualUserID
			{
				[Token(Token = "0x60006CF")]
				[Address(RVA = "0x2520CE0", Offset = "0x2520CE0", VA = "0x2520CE0")]
				get
				{
					return default(VirtualUserID);
				}
				[Token(Token = "0x60006D0")]
				[Address(RVA = "0x2520CE8", Offset = "0x2520CE8", VA = "0x2520CE8")]
				set
				{
				}
			}

			[Token(Token = "0x170002F9")]
			[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE1EFC", Offset = "0xCE1EFC")]
			public bool IsVirtualUser
			{
				[Token(Token = "0x60006D1")]
				[Address(RVA = "0x2520CEC", Offset = "0x2520CEC", VA = "0x2520CEC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x2520CF4", Offset = "0x2520CF4", VA = "0x2520CF4")]
			public SetDataRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x2000156")]
		public class GetDataRequest : RequestBase
		{
			[Token(Token = "0x4000912")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal UserInput tusUser;

			[Token(Token = "0x4000913")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal int slotId;

			[Token(Token = "0x4000914")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			internal bool forCrossSave;

			[Token(Token = "0x4000915")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
			internal bool retrieveStatusOnly;

			[Token(Token = "0x170002FA")]
			public UserInput TusUser
			{
				[Token(Token = "0x60006D3")]
				[Address(RVA = "0x251F6C4", Offset = "0x251F6C4", VA = "0x251F6C4")]
				get
				{
					return default(UserInput);
				}
				[Token(Token = "0x60006D4")]
				[Address(RVA = "0x251F6D8", Offset = "0x251F6D8", VA = "0x251F6D8")]
				set
				{
				}
			}

			[Token(Token = "0x170002FB")]
			public int SlotId
			{
				[Token(Token = "0x60006D5")]
				[Address(RVA = "0x251F6EC", Offset = "0x251F6EC", VA = "0x251F6EC")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60006D6")]
				[Address(RVA = "0x251F6F4", Offset = "0x251F6F4", VA = "0x251F6F4")]
				set
				{
				}
			}

			[Token(Token = "0x170002FC")]
			public bool ForCrossSave
			{
				[Token(Token = "0x60006D7")]
				[Address(RVA = "0x251F6FC", Offset = "0x251F6FC", VA = "0x251F6FC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60006D8")]
				[Address(RVA = "0x251F704", Offset = "0x251F704", VA = "0x251F704")]
				set
				{
				}
			}

			[Token(Token = "0x170002FD")]
			public bool RetrieveStatusOnly
			{
				[Token(Token = "0x60006D9")]
				[Address(RVA = "0x251F710", Offset = "0x251F710", VA = "0x251F710")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60006DA")]
				[Address(RVA = "0x251F718", Offset = "0x251F718", VA = "0x251F718")]
				set
				{
				}
			}

			[Token(Token = "0x170002FE")]
			[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE1F34", Offset = "0xCE1F34")]
			public Core.NpAccountId TargetUser
			{
				[Token(Token = "0x60006DB")]
				[Address(RVA = "0x251F724", Offset = "0x251F724", VA = "0x251F724")]
				get
				{
					return default(Core.NpAccountId);
				}
				[Token(Token = "0x60006DC")]
				[Address(RVA = "0x251F730", Offset = "0x251F730", VA = "0x251F730")]
				set
				{
				}
			}

			[Token(Token = "0x170002FF")]
			[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE1F6C", Offset = "0xCE1F6C")]
			public VirtualUserID VirtualUserID
			{
				[Token(Token = "0x60006DD")]
				[Address(RVA = "0x251F734", Offset = "0x251F734", VA = "0x251F734")]
				get
				{
					return default(VirtualUserID);
				}
				[Token(Token = "0x60006DE")]
				[Address(RVA = "0x251F73C", Offset = "0x251F73C", VA = "0x251F73C")]
				set
				{
				}
			}

			[Token(Token = "0x17000300")]
			[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE1FA4", Offset = "0xCE1FA4")]
			public bool IsVirtualUser
			{
				[Token(Token = "0x60006DF")]
				[Address(RVA = "0x251F740", Offset = "0x251F740", VA = "0x251F740")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x251F748", Offset = "0x251F748", VA = "0x251F748")]
			public GetDataRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x2000157")]
		public class DeleteDataRequest : RequestBase
		{
			[Token(Token = "0x4000916")]
			public const int MAX_DATA_SLOTS = 64;

			[Token(Token = "0x4000917")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal UserInput tusUser;

			[Token(Token = "0x4000918")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal ulong numSlots;

			[Token(Token = "0x4000919")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int[] slotIds;

			[Token(Token = "0x17000301")]
			public UserInput TusUser
			{
				[Token(Token = "0x60006E1")]
				[Address(RVA = "0x251ED84", Offset = "0x251ED84", VA = "0x251ED84")]
				get
				{
					return default(UserInput);
				}
				[Token(Token = "0x60006E2")]
				[Address(RVA = "0x251ED98", Offset = "0x251ED98", VA = "0x251ED98")]
				set
				{
				}
			}

			[Token(Token = "0x17000302")]
			public int[] SlotIds
			{
				[Token(Token = "0x60006E3")]
				[Address(RVA = "0x251EDAC", Offset = "0x251EDAC", VA = "0x251EDAC")]
				get
				{
					return null;
				}
				[Token(Token = "0x60006E4")]
				[Address(RVA = "0x251EE44", Offset = "0x251EE44", VA = "0x251EE44")]
				set
				{
				}
			}

			[Token(Token = "0x17000303")]
			[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE1FDC", Offset = "0xCE1FDC")]
			public Core.NpAccountId TargetUser
			{
				[Token(Token = "0x60006E5")]
				[Address(RVA = "0x251EF38", Offset = "0x251EF38", VA = "0x251EF38")]
				get
				{
					return default(Core.NpAccountId);
				}
				[Token(Token = "0x60006E6")]
				[Address(RVA = "0x251EF44", Offset = "0x251EF44", VA = "0x251EF44")]
				set
				{
				}
			}

			[Token(Token = "0x17000304")]
			[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE2014", Offset = "0xCE2014")]
			public VirtualUserID VirtualUserID
			{
				[Token(Token = "0x60006E7")]
				[Address(RVA = "0x251EF48", Offset = "0x251EF48", VA = "0x251EF48")]
				get
				{
					return default(VirtualUserID);
				}
				[Token(Token = "0x60006E8")]
				[Address(RVA = "0x251EF50", Offset = "0x251EF50", VA = "0x251EF50")]
				set
				{
				}
			}

			[Token(Token = "0x17000305")]
			[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE204C", Offset = "0xCE204C")]
			public bool IsVirtualUser
			{
				[Token(Token = "0x60006E9")]
				[Address(RVA = "0x251EF54", Offset = "0x251EF54", VA = "0x251EF54")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006EA")]
			[Address(RVA = "0x251EF5C", Offset = "0x251EF5C", VA = "0x251EF5C")]
			public DeleteDataRequest()
			{
			}
		}

		[Token(Token = "0x2000158")]
		public enum TryAndSetCompareOperator
		{
			[Token(Token = "0x400091B")]
			None,
			[Token(Token = "0x400091C")]
			Equal,
			[Token(Token = "0x400091D")]
			NotEqual,
			[Token(Token = "0x400091E")]
			GreaterThan,
			[Token(Token = "0x400091F")]
			GreaterThanOrEqualTo,
			[Token(Token = "0x4000920")]
			LessThan,
			[Token(Token = "0x4000921")]
			LessThanOrEqualTo
		}

		[StructLayout(0)]
		[Token(Token = "0x2000159")]
		public class TryAndSetVariableRequest : RequestBase
		{
			[Token(Token = "0x4000922")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal UserInput tusUser;

			[Token(Token = "0x4000923")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal VariableInput varToUpdate;

			[Token(Token = "0x4000924")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal DataContention dataContention;

			[Token(Token = "0x4000925")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal long compareValue;

			[Token(Token = "0x4000926")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			internal TryAndSetCompareOperator compareOperator;

			[Token(Token = "0x4000927")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			internal bool forCrossSave;

			[Token(Token = "0x17000306")]
			public UserInput TusUser
			{
				[Token(Token = "0x60006EB")]
				[Address(RVA = "0x2520F9C", Offset = "0x2520F9C", VA = "0x2520F9C")]
				get
				{
					return default(UserInput);
				}
				[Token(Token = "0x60006EC")]
				[Address(RVA = "0x2520FB0", Offset = "0x2520FB0", VA = "0x2520FB0")]
				set
				{
				}
			}

			[Token(Token = "0x17000307")]
			public VariableInput VarToUpdate
			{
				[Token(Token = "0x60006ED")]
				[Address(RVA = "0x2520FC4", Offset = "0x2520FC4", VA = "0x2520FC4")]
				get
				{
					return default(VariableInput);
				}
				[Token(Token = "0x60006EE")]
				[Address(RVA = "0x2520FD0", Offset = "0x2520FD0", VA = "0x2520FD0")]
				set
				{
				}
			}

			[Token(Token = "0x17000308")]
			public DataContention DataContention
			{
				[Token(Token = "0x60006EF")]
				[Address(RVA = "0x2520FD8", Offset = "0x2520FD8", VA = "0x2520FD8")]
				get
				{
					return default(DataContention);
				}
				[Token(Token = "0x60006F0")]
				[Address(RVA = "0x2520FE4", Offset = "0x2520FE4", VA = "0x2520FE4")]
				set
				{
				}
			}

			[Token(Token = "0x17000309")]
			public long CompareValue
			{
				[Token(Token = "0x60006F1")]
				[Address(RVA = "0x2520FEC", Offset = "0x2520FEC", VA = "0x2520FEC")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x60006F2")]
				[Address(RVA = "0x2520FF4", Offset = "0x2520FF4", VA = "0x2520FF4")]
				set
				{
				}
			}

			[Token(Token = "0x1700030A")]
			public TryAndSetCompareOperator CompareOperator
			{
				[Token(Token = "0x60006F3")]
				[Address(RVA = "0x2520FFC", Offset = "0x2520FFC", VA = "0x2520FFC")]
				get
				{
					return default(TryAndSetCompareOperator);
				}
				[Token(Token = "0x60006F4")]
				[Address(RVA = "0x2521004", Offset = "0x2521004", VA = "0x2521004")]
				set
				{
				}
			}

			[Token(Token = "0x1700030B")]
			public bool ForCrossSave
			{
				[Token(Token = "0x60006F5")]
				[Address(RVA = "0x252100C", Offset = "0x252100C", VA = "0x252100C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60006F6")]
				[Address(RVA = "0x2521014", Offset = "0x2521014", VA = "0x2521014")]
				set
				{
				}
			}

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x2521020", Offset = "0x2521020", VA = "0x2521020")]
			public TryAndSetVariableRequest()
			{
			}
		}

		[Token(Token = "0x200015A")]
		public enum FriendsVariableSortingOrder
		{
			[Token(Token = "0x4000929")]
			DescDate = 1,
			[Token(Token = "0x400092A")]
			AscDate,
			[Token(Token = "0x400092B")]
			DescValue,
			[Token(Token = "0x400092C")]
			AscValue
		}

		[StructLayout(0)]
		[Token(Token = "0x200015B")]
		public class GetFriendsVariableRequest : RequestBase
		{
			[Token(Token = "0x400092D")]
			public const int MAX_PAGE_SIZE = 100;

			[Token(Token = "0x400092E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal uint pageSize;

			[Token(Token = "0x400092F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal int slotId;

			[Token(Token = "0x4000930")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal FriendsVariableSortingOrder sortingOrder;

			[Token(Token = "0x4000931")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal uint startIndex;

			[Token(Token = "0x4000932")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal bool forCrossSave;

			[Token(Token = "0x4000933")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
			internal bool includeMeIfFound;

			[Token(Token = "0x1700030C")]
			public int SlotId
			{
				[Token(Token = "0x60006F8")]
				[Address(RVA = "0x251FCB8", Offset = "0x251FCB8", VA = "0x251FCB8")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60006F9")]
				[Address(RVA = "0x251FCC0", Offset = "0x251FCC0", VA = "0x251FCC0")]
				set
				{
				}
			}

			[Token(Token = "0x1700030D")]
			public FriendsVariableSortingOrder SortingOrder
			{
				[Token(Token = "0x60006FA")]
				[Address(RVA = "0x251FCC8", Offset = "0x251FCC8", VA = "0x251FCC8")]
				get
				{
					return default(FriendsVariableSortingOrder);
				}
				[Token(Token = "0x60006FB")]
				[Address(RVA = "0x251FCD0", Offset = "0x251FCD0", VA = "0x251FCD0")]
				set
				{
				}
			}

			[Token(Token = "0x1700030E")]
			public uint StartIndex
			{
				[Token(Token = "0x60006FC")]
				[Address(RVA = "0x251FCD8", Offset = "0x251FCD8", VA = "0x251FCD8")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x60006FD")]
				[Address(RVA = "0x251FCE0", Offset = "0x251FCE0", VA = "0x251FCE0")]
				set
				{
				}
			}

			[Token(Token = "0x1700030F")]
			public uint PageSize
			{
				[Token(Token = "0x60006FE")]
				[Address(RVA = "0x251FCE8", Offset = "0x251FCE8", VA = "0x251FCE8")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x60006FF")]
				[Address(RVA = "0x251FCF0", Offset = "0x251FCF0", VA = "0x251FCF0")]
				set
				{
				}
			}

			[Token(Token = "0x17000310")]
			public bool ForCrossSave
			{
				[Token(Token = "0x6000700")]
				[Address(RVA = "0x251FDBC", Offset = "0x251FDBC", VA = "0x251FDBC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000701")]
				[Address(RVA = "0x251FDC4", Offset = "0x251FDC4", VA = "0x251FDC4")]
				set
				{
				}
			}

			[Token(Token = "0x17000311")]
			public bool IncludeMeIfFound
			{
				[Token(Token = "0x6000702")]
				[Address(RVA = "0x251FDD0", Offset = "0x251FDD0", VA = "0x251FDD0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000703")]
				[Address(RVA = "0x251FDD8", Offset = "0x251FDD8", VA = "0x251FDD8")]
				set
				{
				}
			}

			[Token(Token = "0x6000704")]
			[Address(RVA = "0x251FDE4", Offset = "0x251FDE4", VA = "0x251FDE4")]
			public GetFriendsVariableRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x200015C")]
		public class GetUsersVariableRequest : RequestBase
		{
			[Token(Token = "0x4000934")]
			public const int MAX_NUM_USERS = 100;

			[Token(Token = "0x4000935")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal uint maxUsersToObtain;

			[Token(Token = "0x4000936")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal VirtualUserID[] virtualUsersIds;

			[Token(Token = "0x4000937")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal Core.NpAccountId[] realUsersIds;

			[Token(Token = "0x4000938")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal int slotId;

			[Token(Token = "0x4000939")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			internal bool areVirtualUsers;

			[Token(Token = "0x400093A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
			internal bool forCrossSave;

			[Token(Token = "0x17000312")]
			public VirtualUserID[] VirtualUsersIds
			{
				[Token(Token = "0x6000705")]
				[Address(RVA = "0x2520258", Offset = "0x2520258", VA = "0x2520258")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000706")]
				[Address(RVA = "0x252031C", Offset = "0x252031C", VA = "0x252031C")]
				set
				{
				}
			}

			[Token(Token = "0x17000313")]
			public Core.NpAccountId[] RealUsersIds
			{
				[Token(Token = "0x6000707")]
				[Address(RVA = "0x252041C", Offset = "0x252041C", VA = "0x252041C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000708")]
				[Address(RVA = "0x25204E0", Offset = "0x25204E0", VA = "0x25204E0")]
				set
				{
				}
			}

			[Token(Token = "0x17000314")]
			public int SlotId
			{
				[Token(Token = "0x6000709")]
				[Address(RVA = "0x25205D8", Offset = "0x25205D8", VA = "0x25205D8")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600070A")]
				[Address(RVA = "0x25205E0", Offset = "0x25205E0", VA = "0x25205E0")]
				set
				{
				}
			}

			[Token(Token = "0x17000315")]
			public bool ForCrossSave
			{
				[Token(Token = "0x600070B")]
				[Address(RVA = "0x25205E8", Offset = "0x25205E8", VA = "0x25205E8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600070C")]
				[Address(RVA = "0x25205F0", Offset = "0x25205F0", VA = "0x25205F0")]
				set
				{
				}
			}

			[Token(Token = "0x17000316")]
			public bool AreVirtualUsers
			{
				[Token(Token = "0x600070D")]
				[Address(RVA = "0x25205FC", Offset = "0x25205FC", VA = "0x25205FC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600070E")]
			[Address(RVA = "0x2520604", Offset = "0x2520604", VA = "0x2520604")]
			public GetUsersVariableRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x200015D")]
		public class GetUsersDataStatusRequest : RequestBase
		{
			[Token(Token = "0x400093B")]
			public const int MAX_NUM_USERS = 100;

			[Token(Token = "0x400093C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal uint maxUsersToObtain;

			[Token(Token = "0x400093D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal VirtualUserID[] virtualUsersIds;

			[Token(Token = "0x400093E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal Core.NpAccountId[] realUsersIds;

			[Token(Token = "0x400093F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal int slotId;

			[Token(Token = "0x4000940")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			internal bool areVirtualUsers;

			[Token(Token = "0x4000941")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
			internal bool forCrossSave;

			[Token(Token = "0x17000317")]
			public VirtualUserID[] VirtualUsersIds
			{
				[Token(Token = "0x600070F")]
				[Address(RVA = "0x251FE24", Offset = "0x251FE24", VA = "0x251FE24")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000710")]
				[Address(RVA = "0x251FEE8", Offset = "0x251FEE8", VA = "0x251FEE8")]
				set
				{
				}
			}

			[Token(Token = "0x17000318")]
			public Core.NpAccountId[] RealUsersIds
			{
				[Token(Token = "0x6000711")]
				[Address(RVA = "0x251FFE8", Offset = "0x251FFE8", VA = "0x251FFE8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000712")]
				[Address(RVA = "0x25200AC", Offset = "0x25200AC", VA = "0x25200AC")]
				set
				{
				}
			}

			[Token(Token = "0x17000319")]
			public int SlotId
			{
				[Token(Token = "0x6000713")]
				[Address(RVA = "0x25201A4", Offset = "0x25201A4", VA = "0x25201A4")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000714")]
				[Address(RVA = "0x25201AC", Offset = "0x25201AC", VA = "0x25201AC")]
				set
				{
				}
			}

			[Token(Token = "0x1700031A")]
			public bool ForCrossSave
			{
				[Token(Token = "0x6000715")]
				[Address(RVA = "0x25201B4", Offset = "0x25201B4", VA = "0x25201B4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000716")]
				[Address(RVA = "0x25201BC", Offset = "0x25201BC", VA = "0x25201BC")]
				set
				{
				}
			}

			[Token(Token = "0x1700031B")]
			public bool AreVirtualUsers
			{
				[Token(Token = "0x6000717")]
				[Address(RVA = "0x25201C8", Offset = "0x25201C8", VA = "0x25201C8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000718")]
			[Address(RVA = "0x25201D0", Offset = "0x25201D0", VA = "0x25201D0")]
			public GetUsersDataStatusRequest()
			{
			}
		}

		[Token(Token = "0x200015E")]
		public enum FriendsDataStatusSortingOrder
		{
			[Token(Token = "0x4000943")]
			DescDate = 1,
			[Token(Token = "0x4000944")]
			AscDate
		}

		[StructLayout(0)]
		[Token(Token = "0x200015F")]
		public class GetFriendsDataStatusRequest : RequestBase
		{
			[Token(Token = "0x4000945")]
			public const int MAX_PAGE_SIZE = 100;

			[Token(Token = "0x4000946")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private uint pageSize;

			[Token(Token = "0x4000947")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int slotId;

			[Token(Token = "0x4000948")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private FriendsDataStatusSortingOrder sortingOrder;

			[Token(Token = "0x4000949")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private uint startIndex;

			[Token(Token = "0x400094A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool forCrossSave;

			[Token(Token = "0x400094B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
			private bool includeMeIfFound;

			[Token(Token = "0x1700031C")]
			public uint PageSize
			{
				[Token(Token = "0x6000719")]
				[Address(RVA = "0x251FB48", Offset = "0x251FB48", VA = "0x251FB48")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x600071A")]
				[Address(RVA = "0x251FB50", Offset = "0x251FB50", VA = "0x251FB50")]
				set
				{
				}
			}

			[Token(Token = "0x1700031D")]
			public int SlotId
			{
				[Token(Token = "0x600071B")]
				[Address(RVA = "0x251FC1C", Offset = "0x251FC1C", VA = "0x251FC1C")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600071C")]
				[Address(RVA = "0x251FC24", Offset = "0x251FC24", VA = "0x251FC24")]
				set
				{
				}
			}

			[Token(Token = "0x1700031E")]
			public FriendsDataStatusSortingOrder SortingOrder
			{
				[Token(Token = "0x600071D")]
				[Address(RVA = "0x251FC2C", Offset = "0x251FC2C", VA = "0x251FC2C")]
				get
				{
					return default(FriendsDataStatusSortingOrder);
				}
				[Token(Token = "0x600071E")]
				[Address(RVA = "0x251FC34", Offset = "0x251FC34", VA = "0x251FC34")]
				set
				{
				}
			}

			[Token(Token = "0x1700031F")]
			public uint StartIndex
			{
				[Token(Token = "0x600071F")]
				[Address(RVA = "0x251FC3C", Offset = "0x251FC3C", VA = "0x251FC3C")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x6000720")]
				[Address(RVA = "0x251FC44", Offset = "0x251FC44", VA = "0x251FC44")]
				set
				{
				}
			}

			[Token(Token = "0x17000320")]
			public bool ForCrossSave
			{
				[Token(Token = "0x6000721")]
				[Address(RVA = "0x251FC4C", Offset = "0x251FC4C", VA = "0x251FC4C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000722")]
				[Address(RVA = "0x251FC54", Offset = "0x251FC54", VA = "0x251FC54")]
				set
				{
				}
			}

			[Token(Token = "0x17000321")]
			public bool IncludeMeIfFound
			{
				[Token(Token = "0x6000723")]
				[Address(RVA = "0x251FC60", Offset = "0x251FC60", VA = "0x251FC60")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000724")]
				[Address(RVA = "0x251FC68", Offset = "0x251FC68", VA = "0x251FC68")]
				set
				{
				}
			}

			[Token(Token = "0x6000725")]
			[Address(RVA = "0x251FC74", Offset = "0x251FC74", VA = "0x251FC74")]
			public GetFriendsDataStatusRequest()
			{
			}
		}

		[Token(Token = "0x2000160")]
		public class VariablesResponse : ResponseBase
		{
			[Token(Token = "0x400094C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal bool forCrossSave;

			[Token(Token = "0x400094D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal NpVariable[] vars;

			[Token(Token = "0x400094E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal NpVariableForCrossSave[] varsForCrossSave;

			[Token(Token = "0x17000322")]
			public bool ForCrossSave
			{
				[Token(Token = "0x6000726")]
				[Address(RVA = "0x2521290", Offset = "0x2521290", VA = "0x2521290")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000323")]
			public NpVariable[] Vars
			{
				[Token(Token = "0x6000727")]
				[Address(RVA = "0x2521298", Offset = "0x2521298", VA = "0x2521298")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000324")]
			public NpVariableForCrossSave[] VarsForCrossSave
			{
				[Token(Token = "0x6000728")]
				[Address(RVA = "0x2521320", Offset = "0x2521320", VA = "0x2521320")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000729")]
			[Address(RVA = "0x25213A8", Offset = "0x25213A8", VA = "0x25213A8", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x600072A")]
			[Address(RVA = "0x2521668", Offset = "0x2521668", VA = "0x2521668")]
			public VariablesResponse()
			{
			}
		}

		[Token(Token = "0x2000161")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE19FC", Offset = "0xCE19FC")]
		public class AtomicAddToAndGetVariableResponse : ResponseBase
		{
			[Token(Token = "0x400094F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal bool forCrossSave;

			[Token(Token = "0x4000950")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal NpVariable var;

			[Token(Token = "0x4000951")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal NpVariableForCrossSave varForCrossSave;

			[Token(Token = "0x17000325")]
			public bool ForCrossSave
			{
				[Token(Token = "0x600072B")]
				[Address(RVA = "0x251E3B0", Offset = "0x251E3B0", VA = "0x251E3B0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000326")]
			public NpVariable Var
			{
				[Token(Token = "0x600072C")]
				[Address(RVA = "0x251E3B8", Offset = "0x251E3B8", VA = "0x251E3B8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000327")]
			public NpVariableForCrossSave VarForCrossSave
			{
				[Token(Token = "0x600072D")]
				[Address(RVA = "0x251E440", Offset = "0x251E440", VA = "0x251E440")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600072E")]
			[Address(RVA = "0x251E4C8", Offset = "0x251E4C8", VA = "0x251E4C8", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x600072F")]
			[Address(RVA = "0x251E778", Offset = "0x251E778", VA = "0x251E778")]
			public AtomicAddToAndGetVariableResponse()
			{
			}
		}

		[Token(Token = "0x2000162")]
		public class GetDataResponse : ResponseBase
		{
			[Token(Token = "0x4000952")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal bool forCrossSave;

			[Token(Token = "0x4000953")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal TusDataStatus tusDataStatus;

			[Token(Token = "0x4000954")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal TusDataStatusForCrossSave tusDataStatusForCrossSave;

			[Token(Token = "0x4000955")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal byte[] data;

			[Token(Token = "0x17000328")]
			public byte[] Data
			{
				[Token(Token = "0x6000730")]
				[Address(RVA = "0x251F758", Offset = "0x251F758", VA = "0x251F758")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000329")]
			public bool ForCrossSave
			{
				[Token(Token = "0x6000731")]
				[Address(RVA = "0x251F760", Offset = "0x251F760", VA = "0x251F760")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700032A")]
			[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE2084", Offset = "0xCE2084")]
			public NpTusDataStatus Status
			{
				[Token(Token = "0x6000732")]
				[Address(RVA = "0x251F768", Offset = "0x251F768", VA = "0x251F768")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700032B")]
			[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE20BC", Offset = "0xCE20BC")]
			public NpTusDataStatusForCrossSave StatusForCrossSave
			{
				[Token(Token = "0x6000733")]
				[Address(RVA = "0x251F7F0", Offset = "0x251F7F0", VA = "0x251F7F0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700032C")]
			public TusDataStatus DataStatus
			{
				[Token(Token = "0x6000734")]
				[Address(RVA = "0x251F878", Offset = "0x251F878", VA = "0x251F878")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700032D")]
			public TusDataStatusForCrossSave DataStatusForCrossSave
			{
				[Token(Token = "0x6000735")]
				[Address(RVA = "0x251F900", Offset = "0x251F900", VA = "0x251F900")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000736")]
			[Address(RVA = "0x251F988", Offset = "0x251F988", VA = "0x251F988", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x6000737")]
			[Address(RVA = "0x251FB40", Offset = "0x251FB40", VA = "0x251FB40")]
			public GetDataResponse()
			{
			}
		}

		[Token(Token = "0x2000163")]
		public class FriendsVariablesResponse : ResponseBase
		{
			[Token(Token = "0x4000956")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal uint totalFriends;

			[Token(Token = "0x4000957")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal bool forCrossSave;

			[Token(Token = "0x4000958")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal NpVariable[] vars;

			[Token(Token = "0x4000959")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal NpVariableForCrossSave[] varsForCrossSave;

			[Token(Token = "0x1700032E")]
			public uint TotalFriends
			{
				[Token(Token = "0x6000738")]
				[Address(RVA = "0x251F2CC", Offset = "0x251F2CC", VA = "0x251F2CC")]
				get
				{
					return default(uint);
				}
			}

			[Token(Token = "0x1700032F")]
			public bool ForCrossSave
			{
				[Token(Token = "0x6000739")]
				[Address(RVA = "0x251F2D4", Offset = "0x251F2D4", VA = "0x251F2D4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000330")]
			public NpVariable[] Vars
			{
				[Token(Token = "0x600073A")]
				[Address(RVA = "0x251F2DC", Offset = "0x251F2DC", VA = "0x251F2DC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000331")]
			public NpVariableForCrossSave[] VarsForCrossSave
			{
				[Token(Token = "0x600073B")]
				[Address(RVA = "0x251F364", Offset = "0x251F364", VA = "0x251F364")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600073C")]
			[Address(RVA = "0x251F3EC", Offset = "0x251F3EC", VA = "0x251F3EC", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x600073D")]
			[Address(RVA = "0x251F6BC", Offset = "0x251F6BC", VA = "0x251F6BC")]
			public FriendsVariablesResponse()
			{
			}
		}

		[Token(Token = "0x2000164")]
		public class DataStatusesResponse : ResponseBase
		{
			[Token(Token = "0x400095A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal bool forCrossSave;

			[Token(Token = "0x400095B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal TusDataStatus[] statuses;

			[Token(Token = "0x400095C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal TusDataStatusForCrossSave[] statusesForCrossSave;

			[Token(Token = "0x17000332")]
			public bool ForCrossSave
			{
				[Token(Token = "0x600073E")]
				[Address(RVA = "0x251E7C8", Offset = "0x251E7C8", VA = "0x251E7C8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000333")]
			public TusDataStatus[] Statuses
			{
				[Token(Token = "0x600073F")]
				[Address(RVA = "0x251E7D0", Offset = "0x251E7D0", VA = "0x251E7D0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000334")]
			public TusDataStatusForCrossSave[] StatusesForCrossSave
			{
				[Token(Token = "0x6000740")]
				[Address(RVA = "0x251E858", Offset = "0x251E858", VA = "0x251E858")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000741")]
			[Address(RVA = "0x251E8E0", Offset = "0x251E8E0", VA = "0x251E8E0")]
			internal void Read(MemoryBuffer readBuffer)
			{
			}

			[Token(Token = "0x6000742")]
			[Address(RVA = "0x251EC6C", Offset = "0x251EC6C", VA = "0x251EC6C", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x6000743")]
			[Address(RVA = "0x251ED7C", Offset = "0x251ED7C", VA = "0x251ED7C")]
			public DataStatusesResponse()
			{
			}
		}

		[Token(Token = "0x2000165")]
		public class FriendsDataStatusesResponse : ResponseBase
		{
			[Token(Token = "0x400095D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal ulong totalFriends;

			[Token(Token = "0x400095E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal DataStatusesResponse friendsStatuses;

			[Token(Token = "0x17000335")]
			public ulong TotalFriends
			{
				[Token(Token = "0x6000744")]
				[Address(RVA = "0x251EFC4", Offset = "0x251EFC4", VA = "0x251EFC4")]
				get
				{
					return default(ulong);
				}
			}

			[Token(Token = "0x17000336")]
			public bool ForCrossSave
			{
				[Token(Token = "0x6000745")]
				[Address(RVA = "0x251EFCC", Offset = "0x251EFCC", VA = "0x251EFCC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000337")]
			public TusDataStatus[] Statuses
			{
				[Token(Token = "0x6000746")]
				[Address(RVA = "0x251EFE8", Offset = "0x251EFE8", VA = "0x251EFE8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000338")]
			public TusDataStatusForCrossSave[] StatusesForCrossSave
			{
				[Token(Token = "0x6000747")]
				[Address(RVA = "0x251F07C", Offset = "0x251F07C", VA = "0x251F07C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000748")]
			[Address(RVA = "0x251F110", Offset = "0x251F110", VA = "0x251F110", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x6000749")]
			[Address(RVA = "0x251F264", Offset = "0x251F264", VA = "0x251F264")]
			public FriendsDataStatusesResponse()
			{
			}
		}

		[Token(Token = "0x2000166")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE1A34", Offset = "0xCE1A34")]
		public struct Variable
		{
			[Token(Token = "0x17000339")]
			public long Value
			{
				[Token(Token = "0x600074A")]
				[Address(RVA = "0x2521258", Offset = "0x2521258", VA = "0x2521258")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x600074B")]
				[Address(RVA = "0x2521260", Offset = "0x2521260", VA = "0x2521260")]
				set
				{
				}
			}

			[Token(Token = "0x1700033A")]
			public int SlotId
			{
				[Token(Token = "0x600074C")]
				[Address(RVA = "0x2521264", Offset = "0x2521264", VA = "0x2521264")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600074D")]
				[Address(RVA = "0x252126C", Offset = "0x252126C", VA = "0x252126C")]
				set
				{
				}
			}
		}

		[PreserveSig]
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x24F25B4", Offset = "0x24F25B4", VA = "0x24F25B4")]
		private static extern int PrxTusSetVariables(SetVariablesRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x24F2690", Offset = "0x24F2690", VA = "0x24F2690")]
		private static extern int PrxTusGetVariables(GetVariablesRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x24F2764", Offset = "0x24F2764", VA = "0x24F2764")]
		private static extern int PrxTusAddToAndGetVariable(AddToAndGetVariableRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x24F2838", Offset = "0x24F2838", VA = "0x24F2838")]
		private static extern int PrxTusSetData(SetDataRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x24F290C", Offset = "0x24F290C", VA = "0x24F290C")]
		private static extern int PrxTusGetData(GetDataRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x24F29E0", Offset = "0x24F29E0", VA = "0x24F29E0")]
		private static extern int PrxTusDeleteData(DeleteDataRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x24F2AB0", Offset = "0x24F2AB0", VA = "0x24F2AB0")]
		private static extern int PrxTusTryAndSetVariable(TryAndSetVariableRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x24F2B84", Offset = "0x24F2B84", VA = "0x24F2B84")]
		private static extern int PrxTusGetFriendsVariable(GetFriendsVariableRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x24F2C50", Offset = "0x24F2C50", VA = "0x24F2C50")]
		private static extern int PrxTusGetUsersVariable(GetUsersVariableRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x24F2D24", Offset = "0x24F2D24", VA = "0x24F2D24")]
		private static extern int PrxTusGetUsersDataStatus(GetUsersDataStatusRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x24F2DF8", Offset = "0x24F2DF8", VA = "0x24F2DF8")]
		private static extern int PrxTusGetFriendsDataStatus(GetFriendsDataStatusRequest request, out APIResult result);

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x24F2EC0", Offset = "0x24F2EC0", VA = "0x24F2EC0")]
		public static int SetVariables(SetVariablesRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x24F2FC8", Offset = "0x24F2FC8", VA = "0x24F2FC8")]
		public static int GetVariables(GetVariablesRequest request, VariablesResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x24F30D0", Offset = "0x24F30D0", VA = "0x24F30D0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xCE1C24", Offset = "0xCE1C24")]
		public static int AddToAndGetVariable(AddToAndGetVariableRequest request, AtomicAddToAndGetVariableResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x24F3138", Offset = "0x24F3138", VA = "0x24F3138")]
		public static int AddToAndGetVariable(AddToAndGetVariableRequest request, VariablesResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x24F3240", Offset = "0x24F3240", VA = "0x24F3240")]
		public static int SetData(SetDataRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x24F3348", Offset = "0x24F3348", VA = "0x24F3348")]
		public static int GetData(GetDataRequest request, GetDataResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x24F3450", Offset = "0x24F3450", VA = "0x24F3450")]
		public static int DeleteData(DeleteDataRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x24F3558", Offset = "0x24F3558", VA = "0x24F3558")]
		public static int TryAndSetVariable(TryAndSetVariableRequest request, VariablesResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x24F36FC", Offset = "0x24F36FC", VA = "0x24F36FC")]
		public static int GetFriendsVariable(GetFriendsVariableRequest request, FriendsVariablesResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x24F38A0", Offset = "0x24F38A0", VA = "0x24F38A0")]
		public static int GetUsersVariable(GetUsersVariableRequest request, VariablesResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x24F3A44", Offset = "0x24F3A44", VA = "0x24F3A44")]
		public static int GetUsersDataStatus(GetUsersDataStatusRequest request, DataStatusesResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x24F3BE8", Offset = "0x24F3BE8", VA = "0x24F3BE8")]
		public static int GetFriendsDataStatus(GetFriendsDataStatusRequest request, FriendsDataStatusesResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x24F3D8C", Offset = "0x24F3D8C", VA = "0x24F3D8C")]
		public Tus()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class UserProfiles
	{
		[Token(Token = "0x2000167")]
		public class LocalUsers
		{
			[Token(Token = "0x400095F")]
			public const int MaxLocalUsers = 4;

			[Token(Token = "0x4000960")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal LocalLoginUserId[] localUsers;

			[Token(Token = "0x1700033B")]
			public LocalLoginUserId[] LocalUsersIds
			{
				[Token(Token = "0x600074E")]
				[Address(RVA = "0x2522400", Offset = "0x2522400", VA = "0x2522400")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600074F")]
			[Address(RVA = "0x2522408", Offset = "0x2522408", VA = "0x2522408")]
			public LocalUsers()
			{
			}
		}

		[Token(Token = "0x2000168")]
		public struct LocalLoginUserId
		{
			[Token(Token = "0x4000961")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Core.UserServiceUserId userId;

			[Token(Token = "0x4000962")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Core.NpAccountId accountId;

			[Token(Token = "0x4000963")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int sceErrorCode;

			[Token(Token = "0x1700033C")]
			public Core.UserServiceUserId UserId
			{
				[Token(Token = "0x6000750")]
				[Address(RVA = "0x25223E8", Offset = "0x25223E8", VA = "0x25223E8")]
				get
				{
					return default(Core.UserServiceUserId);
				}
			}

			[Token(Token = "0x1700033D")]
			public Core.NpAccountId AccountId
			{
				[Token(Token = "0x6000751")]
				[Address(RVA = "0x25223F0", Offset = "0x25223F0", VA = "0x25223F0")]
				get
				{
					return default(Core.NpAccountId);
				}
			}

			[Token(Token = "0x1700033E")]
			public int SceErrorCode
			{
				[Token(Token = "0x6000752")]
				[Address(RVA = "0x25223F8", Offset = "0x25223F8", VA = "0x25223F8")]
				get
				{
					return default(int);
				}
			}
		}

		[Token(Token = "0x2000169")]
		public class NpProfilesResponse : ResponseBase
		{
			[Token(Token = "0x4000964")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Profiles.Profile[] profiles;

			[Token(Token = "0x1700033F")]
			public Profiles.Profile[] Profiles
			{
				[Token(Token = "0x6000753")]
				[Address(RVA = "0x2522468", Offset = "0x2522468", VA = "0x2522468")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000754")]
			[Address(RVA = "0x2522470", Offset = "0x2522470", VA = "0x2522470", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x6000755")]
			[Address(RVA = "0x25226A4", Offset = "0x25226A4", VA = "0x25226A4")]
			public NpProfilesResponse()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x200016A")]
		public class GetNpProfilesRquest : RequestBase
		{
			[Token(Token = "0x4000965")]
			public const int MAX_SIZE_ACCOUNT_IDS = 50;

			[Token(Token = "0x4000966")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Core.NpAccountId[] accountIds;

			[Token(Token = "0x4000967")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal uint numValidAccountIds;

			[Token(Token = "0x17000340")]
			public Core.NpAccountId[] AccountIds
			{
				[Token(Token = "0x6000756")]
				[Address(RVA = "0x25221C0", Offset = "0x25221C0", VA = "0x25221C0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000757")]
				[Address(RVA = "0x2522240", Offset = "0x2522240", VA = "0x2522240")]
				set
				{
				}
			}

			[Token(Token = "0x6000758")]
			[Address(RVA = "0x2522334", Offset = "0x2522334", VA = "0x2522334")]
			public GetNpProfilesRquest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x200016B")]
		public class GetVerifiedAccountsForTitleRequest : RequestBase
		{
			[Token(Token = "0x4000968")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal uint limit;

			[Token(Token = "0x17000341")]
			public uint Limit
			{
				[Token(Token = "0x6000759")]
				[Address(RVA = "0x25223A4", Offset = "0x25223A4", VA = "0x25223A4")]
				get
				{
					return default(uint);
				}
				[Token(Token = "0x600075A")]
				[Address(RVA = "0x25223AC", Offset = "0x25223AC", VA = "0x25223AC")]
				set
				{
				}
			}

			[Token(Token = "0x600075B")]
			[Address(RVA = "0x25223B4", Offset = "0x25223B4", VA = "0x25223B4")]
			public GetVerifiedAccountsForTitleRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x200016C")]
		public class DisplayUserProfileDialogRequest : RequestBase
		{
			[Token(Token = "0x4000969")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Core.NpAccountId targetAccountId;

			[Token(Token = "0x17000342")]
			public Core.NpAccountId TargetAccountId
			{
				[Token(Token = "0x600075C")]
				[Address(RVA = "0x25221A0", Offset = "0x25221A0", VA = "0x25221A0")]
				get
				{
					return default(Core.NpAccountId);
				}
				[Token(Token = "0x600075D")]
				[Address(RVA = "0x25221A8", Offset = "0x25221A8", VA = "0x25221A8")]
				set
				{
				}
			}

			[Token(Token = "0x600075E")]
			[Address(RVA = "0x25221B0", Offset = "0x25221B0", VA = "0x25221B0")]
			public DisplayUserProfileDialogRequest()
			{
			}
		}

		[StructLayout(0)]
		[Token(Token = "0x200016D")]
		public class DisplayGriefReportingDialogRequest : RequestBase
		{
			[Token(Token = "0x400096A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Core.NpAccountId targetAccountId;

			[Token(Token = "0x400096B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool reportOnlineId;

			[Token(Token = "0x400096C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
			public bool reportName;

			[Token(Token = "0x400096D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
			public bool reportPicture;

			[Token(Token = "0x400096E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
			public bool reportAboutMe;

			[Token(Token = "0x17000343")]
			public Core.NpAccountId TargetAccountId
			{
				[Token(Token = "0x600075F")]
				[Address(RVA = "0x2522130", Offset = "0x2522130", VA = "0x2522130")]
				get
				{
					return default(Core.NpAccountId);
				}
				[Token(Token = "0x6000760")]
				[Address(RVA = "0x2522138", Offset = "0x2522138", VA = "0x2522138")]
				set
				{
				}
			}

			[Token(Token = "0x17000344")]
			public bool ReportOnlineId
			{
				[Token(Token = "0x6000761")]
				[Address(RVA = "0x2522140", Offset = "0x2522140", VA = "0x2522140")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000762")]
				[Address(RVA = "0x2522148", Offset = "0x2522148", VA = "0x2522148")]
				set
				{
				}
			}

			[Token(Token = "0x17000345")]
			public bool ReportName
			{
				[Token(Token = "0x6000763")]
				[Address(RVA = "0x2522154", Offset = "0x2522154", VA = "0x2522154")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000764")]
				[Address(RVA = "0x252215C", Offset = "0x252215C", VA = "0x252215C")]
				set
				{
				}
			}

			[Token(Token = "0x17000346")]
			public bool ReportPicture
			{
				[Token(Token = "0x6000765")]
				[Address(RVA = "0x2522168", Offset = "0x2522168", VA = "0x2522168")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000766")]
				[Address(RVA = "0x2522170", Offset = "0x2522170", VA = "0x2522170")]
				set
				{
				}
			}

			[Token(Token = "0x17000347")]
			public bool ReportAboutMe
			{
				[Token(Token = "0x6000767")]
				[Address(RVA = "0x252217C", Offset = "0x252217C", VA = "0x252217C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000768")]
				[Address(RVA = "0x2522184", Offset = "0x2522184", VA = "0x2522184")]
				set
				{
				}
			}

			[Token(Token = "0x6000769")]
			[Address(RVA = "0x2522190", Offset = "0x2522190", VA = "0x2522190")]
			public DisplayGriefReportingDialogRequest()
			{
			}
		}

		[PreserveSig]
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2521788", Offset = "0x2521788", VA = "0x2521788")]
		private static extern void PrxGetLocalLoginUserIds([Out] LocalLoginUserId[] users, int maxSize, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x25218B8", Offset = "0x25218B8", VA = "0x25218B8")]
		private static extern int PrxGetNpProfiles(GetNpProfilesRquest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x2521978", Offset = "0x2521978", VA = "0x2521978")]
		private static extern int PrxGetVerifiedAccountsForTitle(GetVerifiedAccountsForTitleRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2521A38", Offset = "0x2521A38", VA = "0x2521A38")]
		private static extern int PrxDisplayUserProfileDialog(DisplayUserProfileDialogRequest request, out APIResult result);

		[PreserveSig]
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x2521AFC", Offset = "0x2521AFC", VA = "0x2521AFC")]
		private static extern int PrxDisplayGriefReportingDialog(DisplayGriefReportingDialogRequest request, out APIResult result);

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2521BE4", Offset = "0x2521BE4", VA = "0x2521BE4")]
		public static void GetLocalUsers(LocalUsers users)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2521CA0", Offset = "0x2521CA0", VA = "0x2521CA0")]
		public static int GetNpProfiles(GetNpProfilesRquest request, NpProfilesResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x2521DB4", Offset = "0x2521DB4", VA = "0x2521DB4")]
		public static int GetVerifiedAccountsForTitle(GetVerifiedAccountsForTitleRequest request, NpProfilesResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x2521EC8", Offset = "0x2521EC8", VA = "0x2521EC8")]
		public static int DisplayUserProfileDialog(DisplayUserProfileDialogRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x2521FDC", Offset = "0x2521FDC", VA = "0x2521FDC")]
		public static int DisplayGriefReportingDialog(DisplayGriefReportingDialogRequest request, Core.EmptyResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x2522128", Offset = "0x2522128", VA = "0x2522128")]
		public UserProfiles()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class WordFilter
	{
		[StructLayout(0)]
		[Token(Token = "0x200016E")]
		public class FilterCommentRequest : RequestBase
		{
			[Token(Token = "0x400096F")]
			public const int MAX_SIZE_COMMENT = 1024;

			[Token(Token = "0x4000970")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal string comment;

			[Token(Token = "0x17000348")]
			public string Comment
			{
				[Token(Token = "0x600076A")]
				[Address(RVA = "0x25228A4", Offset = "0x25228A4", VA = "0x25228A4")]
				get
				{
					return null;
				}
				[Token(Token = "0x600076B")]
				[Address(RVA = "0x25228AC", Offset = "0x25228AC", VA = "0x25228AC")]
				set
				{
				}
			}

			[Token(Token = "0x600076C")]
			[Address(RVA = "0x2522990", Offset = "0x2522990", VA = "0x2522990")]
			public FilterCommentRequest()
			{
			}
		}

		[Token(Token = "0x200016F")]
		public class SanitizedCommentResponse : ResponseBase
		{
			[Token(Token = "0x4000971")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal string resultComment;

			[Token(Token = "0x4000972")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal bool isCommentChanged;

			[Token(Token = "0x17000349")]
			public string ResultComment
			{
				[Token(Token = "0x600076D")]
				[Address(RVA = "0x25229A0", Offset = "0x25229A0", VA = "0x25229A0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700034A")]
			public bool IsCommentChanged
			{
				[Token(Token = "0x600076E")]
				[Address(RVA = "0x25229A8", Offset = "0x25229A8", VA = "0x25229A8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600076F")]
			[Address(RVA = "0x25229B0", Offset = "0x25229B0", VA = "0x25229B0", Slot = "4")]
			protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
			{
			}

			[Token(Token = "0x6000770")]
			[Address(RVA = "0x2522B00", Offset = "0x2522B00", VA = "0x2522B00")]
			public SanitizedCommentResponse()
			{
			}
		}

		[PreserveSig]
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x25226AC", Offset = "0x25226AC", VA = "0x25226AC")]
		private static extern int PrxFilterComment(FilterCommentRequest request, out APIResult result);

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x2522788", Offset = "0x2522788", VA = "0x2522788")]
		public static int FilterComment(FilterCommentRequest request, SanitizedCommentResponse response)
		{
			return default(int);
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x252289C", Offset = "0x252289C", VA = "0x252289C")]
		public WordFilter()
		{
		}
	}
}
