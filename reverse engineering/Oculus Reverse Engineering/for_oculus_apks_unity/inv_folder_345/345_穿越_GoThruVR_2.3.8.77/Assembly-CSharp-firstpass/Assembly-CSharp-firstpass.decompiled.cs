using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using ImaginationOverflow.UniversalDeepLinking;
using InfinityCode.uPano.Controls;
using InfinityCode.uPano.Directions;
using InfinityCode.uPano.Enums;
using InfinityCode.uPano.HotSpots;
using InfinityCode.uPano.InteractiveElements;
using InfinityCode.uPano.Json;
using InfinityCode.uPano.Net;
using InfinityCode.uPano.Plugins;
using InfinityCode.uPano.Renderers;
using InfinityCode.uPano.Renderers.Base;
using InfinityCode.uPano.Requests;
using InfinityCode.uPano.Services;
using InfinityCode.uPano.Transitions;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class DeeplinkingExample : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject Panel;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject Reference;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject obj;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject InstructionText;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x14BE03C", Offset = "0x14BE03C", VA = "0x14BE03C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x14BE134", Offset = "0x14BE134", VA = "0x14BE134")]
	private void SetupUi()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x14BE154", Offset = "0x14BE154", VA = "0x14BE154")]
	private void Instance_LinkActivated(LinkActivation s)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x14BE310", Offset = "0x14BE310", VA = "0x14BE310")]
	private void UpdateContentSize()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x14BE3C4", Offset = "0x14BE3C4", VA = "0x14BE3C4")]
	public DeeplinkingExample()
	{
	}
}
[Token(Token = "0x2000003")]
public class OpenLinkBehaviour : MonoBehaviour
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string Url;

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1B5B804", Offset = "0x1B5B804", VA = "0x1B5B804")]
	private void Start()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1B5B8A8", Offset = "0x1B5B8A8", VA = "0x1B5B8A8")]
	public void Open()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1B5B8B4", Offset = "0x1B5B8B4", VA = "0x1B5B8B4")]
	public OpenLinkBehaviour()
	{
	}
}
namespace InfinityCode.uPano
{
	[Token(Token = "0x2000004")]
	public static class CanvasUtils
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x14BFBFC", Offset = "0x14BFBFC", VA = "0x14BFBFC")]
		public static int CalculateWidthOfMessage(string text, Font font, int fontSize)
		{
			return default(int);
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x14BFA48", Offset = "0x14BFA48", VA = "0x14BFA48")]
		public static Canvas GetCanvas()
		{
			return null;
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x14C3088", Offset = "0x14C3088", VA = "0x14C3088")]
		public static EventSystem GetEventSystem()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000005")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xA69708", Offset = "0xA69708")]
	public class CubeUV : IEnumerable
	{
		[Token(Token = "0x200007D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6A88C", Offset = "0xA6A88C")]
		private sealed class <GetEnumerator>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000206")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000207")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CubeUV <>4__this;

			[Token(Token = "0x170000AB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600036C")]
				[Address(RVA = "0x14C560C", Offset = "0x14C560C", VA = "0x14C560C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600036E")]
				[Address(RVA = "0x14C5674", Offset = "0x14C5674", VA = "0x14C5674", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000369")]
			[Address(RVA = "0x14C5228", Offset = "0x14C5228", VA = "0x14C5228")]
			[DebuggerHidden]
			public <GetEnumerator>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x600036A")]
			[Address(RVA = "0x14C5410", Offset = "0x14C5410", VA = "0x14C5410", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600036B")]
			[Address(RVA = "0x14C5414", Offset = "0x14C5414", VA = "0x14C5414", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600036D")]
			[Address(RVA = "0x14C5614", Offset = "0x14C5614", VA = "0x14C5614", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] sides;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RotatableRectUV top;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public RotatableRectUV front;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RotatableRectUV left;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public RotatableRectUV back;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public RotatableRectUV right;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public RotatableRectUV bottom;

		[Token(Token = "0x17000001")]
		public RotatableRectUV Item
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x14C4E60", Offset = "0x14C4E60", VA = "0x14C4E60")]
			get
			{
				return default(RotatableRectUV);
			}
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x14C4F58", Offset = "0x14C4F58", VA = "0x14C4F58")]
			set
			{
			}
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x14C5078", Offset = "0x14C5078", VA = "0x14C5078")]
		public CubeUV(RotatableRectUV top, RotatableRectUV front, RotatableRectUV left, RotatableRectUV back, RotatableRectUV right, RotatableRectUV bottom)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x14C512C", Offset = "0x14C512C", VA = "0x14C512C")]
		public int GetSideIndex(Vector2 uv)
		{
			return default(int);
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x14C51B8", Offset = "0x14C51B8", VA = "0x14C51B8", Slot = "4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA6AECC", Offset = "0xA6AECC")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x2000006")]
	public static class CubeUVPresets
	{
		[Token(Token = "0x17000002")]
		public static CubeUV horizontalCrossPreset
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x14C567C", Offset = "0x14C567C", VA = "0x14C567C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		public static CubeUV verticalCrossPreset
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x14C58FC", Offset = "0x14C58FC", VA = "0x14C58FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		public static CubeUV youtubePreset
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x14C5B7C", Offset = "0x14C5B7C", VA = "0x14C5B7C")]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x2000007")]
	public static class CultureHelper
	{
		[Token(Token = "0x17000005")]
		public static CultureInfo cultureInfo
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x14C5DFC", Offset = "0x14C5DFC", VA = "0x14C5DFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public static NumberFormatInfo numberFormat
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x14C5E5C", Offset = "0x14C5E5C", VA = "0x14C5E5C")]
			get
			{
				return null;
			}
		}
	}
	[Serializable]
	[Token(Token = "0x2000008")]
	public class FloatRange
	{
		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float min;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float max;

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x14C8B00", Offset = "0x14C8B00", VA = "0x14C8B00")]
		public FloatRange()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x14C8B08", Offset = "0x14C8B08", VA = "0x14C8B08")]
		public FloatRange(float min, float max)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x14C8B40", Offset = "0x14C8B40", VA = "0x14C8B40")]
		public float Clamp(float value)
		{
			return default(float);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x14C8BC8", Offset = "0x14C8BC8", VA = "0x14C8BC8")]
		public float Repeat(float value)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000009")]
	public static class GeoHelper
	{
		[Token(Token = "0x400000F")]
		public const double R = 6371.0;

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x14C8C58", Offset = "0x14C8C58", VA = "0x14C8C58")]
		public static double Clip(double n, double minValue, double maxValue)
		{
			return default(double);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x14C8C74", Offset = "0x14C8C74", VA = "0x14C8C74")]
		public static void CoordinatesToTile(double lng, double lat, int zoom, out double tx, out double ty)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x14C8F7C", Offset = "0x14C8F7C", VA = "0x14C8F7C")]
		public static double Distance(double lng1, double lat1, double lng2, double lat2)
		{
			return default(double);
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x14C904C", Offset = "0x14C904C", VA = "0x14C904C")]
		public static void Distance(double lng1, double lat1, double lng2, double lat2, out double dx, out double dy)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x14C8E04", Offset = "0x14C8E04", VA = "0x14C8E04")]
		public static double Repeat(double n, double minValue, double maxValue)
		{
			return default(double);
		}
	}
	[Token(Token = "0x200000A")]
	public class GlobalSettings : Plugin
	{
		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static GlobalSettings _instance;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject defaultHotSpotPrefab;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject defaultDirectionPrefab;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject beforeTransitionPrefab;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject afterTransitionPrefab;

		[Token(Token = "0x17000007")]
		public static GlobalSettings instance
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x14C9208", Offset = "0x14C9208", VA = "0x14C9208")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x14C9258", Offset = "0x14C9258", VA = "0x14C9258", Slot = "7")]
		protected override void OnEnableLate()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x14C92B8", Offset = "0x14C92B8", VA = "0x14C92B8", Slot = "4")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x14C2E48", Offset = "0x14C2E48", VA = "0x14C2E48")]
		public static Transition GetAfterTransition()
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x14C2B34", Offset = "0x14C2B34", VA = "0x14C2B34")]
		public static Transition GetBeforeTransition()
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		public static GameObject GetDefaultPrefab<T>() where T : InteractiveElement
		{
			return null;
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x14C9308", Offset = "0x14C9308", VA = "0x14C9308")]
		public GlobalSettings()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public static class MathHelper
	{
		[Token(Token = "0x4000015")]
		public const double Deg2Rad = Math.PI / 180.0;

		[Token(Token = "0x4000016")]
		public const double Rad2Deg = 180.0 / Math.PI;

		[Token(Token = "0x4000017")]
		public const double PID4 = Math.PI / 4.0;

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x14C6914", Offset = "0x14C6914", VA = "0x14C6914")]
		public static float Angle2D(Vector3 point1, Vector3 point2)
		{
			return default(float);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x14D2B54", Offset = "0x14D2B54", VA = "0x14D2B54")]
		public static float Angle2D(float p1x, float p1y, float p2x, float p2y)
		{
			return default(float);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x14D2BE8", Offset = "0x14D2BE8", VA = "0x14D2BE8")]
		public static double Angle2D(double p1x, double p1y, double p2x, double p2y)
		{
			return default(double);
		}
	}
	[Serializable]
	[Token(Token = "0x200000C")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xA69740", Offset = "0xA69740")]
	public struct RectUV
	{
		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] sides;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float left;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float top;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float right;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float bottom;

		[Token(Token = "0x17000008")]
		public static RectUV full
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x1B4CDB0", Offset = "0x1B4CDB0", VA = "0x1B4CDB0")]
			get
			{
				return default(RectUV);
			}
		}

		[Token(Token = "0x17000009")]
		public float height
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0xB6B420", Offset = "0xB6B420", VA = "0xB6B420")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000A")]
		public float width
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0xB6B430", Offset = "0xB6B430", VA = "0xB6B430")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000B")]
		public float Item
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0xB6B440", Offset = "0xB6B440", VA = "0xB6B440")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600002E")]
			[Address(RVA = "0xB6B448", Offset = "0xB6B448", VA = "0xB6B448")]
			set
			{
			}
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xB6B450", Offset = "0xB6B450", VA = "0xB6B450")]
		public RectUV(float left, float top, float right, float bottom)
		{
		}
	}
	[Token(Token = "0x200000D")]
	public static class ReflectionHelper
	{
		[Token(Token = "0x400001D")]
		private const BindingFlags DefaultLookup = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public;

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1B4D0D0", Offset = "0x1B4D0D0", VA = "0x1B4D0D0")]
		public static bool CheckIfAnonymousType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1B4D288", Offset = "0x1B4D288", VA = "0x1B4D288")]
		public static TypeAttributes GetAttributes(Type type)
		{
			return default(TypeAttributes);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1B4D2A0", Offset = "0x1B4D2A0", VA = "0x1B4D2A0")]
		public static IEnumerable<FieldInfo> GetFields(Type type, BindingFlags bindingAttr = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public)
		{
			return null;
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1B4D2C0", Offset = "0x1B4D2C0", VA = "0x1B4D2C0")]
		public static Type[] GetGenericArguments(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1B4D2E0", Offset = "0x1B4D2E0", VA = "0x1B4D2E0")]
		public static IEnumerable<MemberInfo> GetMembers(Type type, BindingFlags bindingAttr = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public)
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1B4D300", Offset = "0x1B4D300", VA = "0x1B4D300")]
		public static MethodInfo GetMethod(Type type, string name)
		{
			return null;
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1B4D318", Offset = "0x1B4D318", VA = "0x1B4D318")]
		public static MethodInfo GetMethod(Type type, string name, Type[] types)
		{
			return null;
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1B4D268", Offset = "0x1B4D268", VA = "0x1B4D268")]
		public static bool IsGenericType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1B4D330", Offset = "0x1B4D330", VA = "0x1B4D330")]
		public static bool IsValueType(Type type)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x200000E")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xA69778", Offset = "0xA69778")]
	public struct RotatableRectUV
	{
		[Token(Token = "0x200007E")]
		public enum Rotation
		{
			[Token(Token = "0x4000209")]
			rotation0,
			[Token(Token = "0x400020A")]
			rotation90,
			[Token(Token = "0x400020B")]
			rotation180,
			[Token(Token = "0x400020C")]
			rotation270
		}

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float left;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float top;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float right;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float bottom;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rotation rotation;

		[Token(Token = "0x1700000C")]
		public static RotatableRectUV full
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x1B52E4C", Offset = "0x1B52E4C", VA = "0x1B52E4C")]
			get
			{
				return default(RotatableRectUV);
			}
		}

		[Token(Token = "0x1700000D")]
		public float height
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0xB6B45C", Offset = "0xB6B45C", VA = "0xB6B45C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000E")]
		public float width
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0xB6B46C", Offset = "0xB6B46C", VA = "0xB6B46C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000F")]
		public float Item
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0xB6B47C", Offset = "0xB6B47C", VA = "0xB6B47C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600003E")]
			[Address(RVA = "0xB6B484", Offset = "0xB6B484", VA = "0xB6B484")]
			set
			{
			}
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xB6B48C", Offset = "0xB6B48C", VA = "0xB6B48C")]
		public RotatableRectUV(float left, float top, float right, float bottom, Rotation rotation = Rotation.rotation0)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xB6B49C", Offset = "0xB6B49C", VA = "0xB6B49C")]
		public bool Contain(Vector2 uv)
		{
			return default(bool);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xB6B4A4", Offset = "0xB6B4A4", VA = "0xB6B4A4")]
		public Vector2 GetUVBilinear(float rx, float ry)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xB6B4AC", Offset = "0xB6B4AC", VA = "0xB6B4AC")]
		public Vector3 GetWorldPosition(Vector2 uv, CubeSide cubeSide)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xB6B4B4", Offset = "0xB6B4B4", VA = "0xB6B4B4")]
		public void SetUVToArray(Vector2[] uv, int index)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA697B0", Offset = "0xA697B0")]
	public class Pano : MonoBehaviour
	{
		[Token(Token = "0x200007F")]
		public enum CameraType
		{
			[Token(Token = "0x400020E")]
			existing,
			[Token(Token = "0x400020F")]
			createNew
		}

		[Token(Token = "0x2000080")]
		public enum NewCameraDepthType
		{
			[Token(Token = "0x4000211")]
			autoDetect,
			[Token(Token = "0x4000212")]
			manual
		}

		[Token(Token = "0x2000081")]
		public enum Projection
		{
			[Token(Token = "0x4000214")]
			perspective,
			[Token(Token = "0x4000215")]
			orthographic
		}

		[Token(Token = "0x2000082")]
		public enum RotationMode
		{
			[Token(Token = "0x4000217")]
			rotatePanorama,
			[Token(Token = "0x4000218")]
			rotateCamera,
			[Token(Token = "0x4000219")]
			rotateGameObject
		}

		[Token(Token = "0x4000023")]
		public const string version = "2.1.1.1";

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<float> OnFOVChanged;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<float> OnPanChanged;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<float> OnTiltChanged;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Func<float, float> OnVerifyFOV;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Func<float, float> OnVerifyPan;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Func<float, float> OnVerifyTilt;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<Pano> OnPanoEnabled;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<Pano> OnPanoDestroy;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static bool isPreview;

		[NonSerialized]
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool locked;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _fov;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _pan;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _tilt;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _northPan;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Camera _camera;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private LayerMask _cameraCullingMask;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private CameraType _cameraType;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected Camera _existingCamera;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private int _newCameraDepth;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private NewCameraDepthType _newCameraDepthType;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Projection _newCameraProjection;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[SerializeField]
		private RotationMode _rotationMode;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _rotateGameObject;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool _addPhysicsRaycaster;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private PanoRenderer _panoRenderer;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool lockCamera;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		private bool started;

		[Token(Token = "0x17000010")]
		public Camera activeCamera
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x14D3178", Offset = "0x14D3178", VA = "0x14D3178")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public bool addPhysicsRaycaster
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x14D3180", Offset = "0x14D3180", VA = "0x14D3180")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x14D3188", Offset = "0x14D3188", VA = "0x14D3188")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public CameraType cameraType
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x14D3194", Offset = "0x14D3194", VA = "0x14D3194")]
			get
			{
				return default(CameraType);
			}
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x14D319C", Offset = "0x14D319C", VA = "0x14D319C")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public Camera existingCamera
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x14D31A4", Offset = "0x14D31A4", VA = "0x14D31A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x14D31AC", Offset = "0x14D31AC", VA = "0x14D31AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public float fov
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x14D31B4", Offset = "0x14D31B4", VA = "0x14D31B4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x14C118C", Offset = "0x14C118C", VA = "0x14C118C")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public float northPan
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x14D31BC", Offset = "0x14D31BC", VA = "0x14D31BC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x14D31C4", Offset = "0x14D31C4", VA = "0x14D31C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public float localPan
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x14D343C", Offset = "0x14D343C", VA = "0x14D343C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x14D3444", Offset = "0x14D3444", VA = "0x14D3444")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public float pan
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x14BE4CC", Offset = "0x14BE4CC", VA = "0x14BE4CC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x14BE4DC", Offset = "0x14BE4DC", VA = "0x14BE4DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public PanoRenderer panoRenderer
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x14C687C", Offset = "0x14C687C", VA = "0x14C687C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public float tilt
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x14D352C", Offset = "0x14D352C", VA = "0x14D352C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x14BE4E8", Offset = "0x14BE4E8", VA = "0x14BE4E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public RotationMode rotationMode
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x14D3534", Offset = "0x14D3534", VA = "0x14D3534")]
			get
			{
				return default(RotationMode);
			}
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x14D353C", Offset = "0x14D353C", VA = "0x14D353C")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public GameObject rotateGameObject
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x14D3544", Offset = "0x14D3544", VA = "0x14D3544")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x14D354C", Offset = "0x14D354C", VA = "0x14D354C")]
			set
			{
			}
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x14D3554", Offset = "0x14D3554", VA = "0x14D3554")]
		private void CreateNewCamera()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x14D37F0", Offset = "0x14D37F0", VA = "0x14D37F0")]
		public void LookAt(float pan, float tilt)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x14D3840", Offset = "0x14D3840", VA = "0x14D3840")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x14D38B4", Offset = "0x14D38B4", VA = "0x14D38B4")]
		protected void OnEnable()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x14D3984", Offset = "0x14D3984", VA = "0x14D3984")]
		private void Awake()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x14D39B0", Offset = "0x14D39B0", VA = "0x14D39B0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x14D3268", Offset = "0x14D3268", VA = "0x14D3268")]
		public void UpdateRotation()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x14D39BC", Offset = "0x14D39BC", VA = "0x14D39BC")]
		public void VerifyFOV()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x14D3A28", Offset = "0x14D3A28", VA = "0x14D3A28")]
		public void VerifyPan()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x14D3A9C", Offset = "0x14D3A9C", VA = "0x14D3A9C")]
		public void VerifyTilt()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x14D3B08", Offset = "0x14D3B08", VA = "0x14D3B08")]
		public Pano()
		{
		}
	}
}
namespace InfinityCode.uPano.Transitions
{
	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA69800", Offset = "0xA69800")]
	public class SetFov : TimeBasedTransition
	{
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float fromFov;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool fromIsOriginal;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float toFov;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool toIsOriginal;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Pano pano;

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1B5A500", Offset = "0x1B5A500", VA = "0x1B5A500", Slot = "6")]
		public override void Init()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1B5A5C4", Offset = "0x1B5A5C4", VA = "0x1B5A5C4", Slot = "8")]
		public override void Process()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1B5A670", Offset = "0x1B5A670", VA = "0x1B5A670")]
		public SetFov()
		{
		}
	}
	[Token(Token = "0x2000011")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA69838", Offset = "0xA69838")]
	public class SetPanTilt : TimeBasedTransition
	{
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float fromPan;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool fromPanIsOriginal;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float toPan;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool toPanIsOriginal;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float fromTilt;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool fromTiltIsOriginal;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float toTilt;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool toTiltIsOriginal;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Pano pano;

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1B5A6C4", Offset = "0x1B5A6C4", VA = "0x1B5A6C4", Slot = "6")]
		public override void Init()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1B5A7C0", Offset = "0x1B5A7C0", VA = "0x1B5A7C0", Slot = "8")]
		public override void Process()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1B5A8A4", Offset = "0x1B5A8A4", VA = "0x1B5A8A4")]
		public SetPanTilt()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public abstract class TimeBasedTransition : Transition
	{
		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _duration;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AnimationCurve _curve;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float progress;

		[Token(Token = "0x1700001C")]
		public float duration
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x1B5A8EC", Offset = "0x1B5A8EC", VA = "0x1B5A8EC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001D")]
		public AnimationCurve curve
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x1B5A8F4", Offset = "0x1B5A8F4", VA = "0x1B5A8F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		public float curvedProgress
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x1B59BEC", Offset = "0x1B59BEC", VA = "0x1B59BEC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1B5A8FC", Offset = "0x1B5A8FC", VA = "0x1B5A8FC", Slot = "7")]
		protected override void OnProcess()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1B59578", Offset = "0x1B59578", VA = "0x1B59578")]
		protected TimeBasedTransition()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public abstract class Transition : MonoBehaviour
	{
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<Transition> OnFinish;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool started;

		[NonSerialized]
		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public InteractiveElement element;

		[NonSerialized]
		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public bool finished;

		[NonSerialized]
		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public Transition parent;

		[Token(Token = "0x1700001F")]
		public Transition rootTransition
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x1B5A964", Offset = "0x1B5A964", VA = "0x1B5A964")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1B59C70", Offset = "0x1B59C70", VA = "0x1B59C70", Slot = "4")]
		protected virtual void Dispose()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1B5A9F8", Offset = "0x1B5A9F8", VA = "0x1B5A9F8")]
		public void Execute(InteractiveElement element)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1B5AA40", Offset = "0x1B5AA40", VA = "0x1B5AA40", Slot = "5")]
		protected virtual void Finish()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1B5930C", Offset = "0x1B5930C", VA = "0x1B5930C", Slot = "6")]
		public virtual void Init()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1B5AA6C", Offset = "0x1B5AA6C", VA = "0x1B5AA6C", Slot = "7")]
		protected virtual void OnProcess()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1B5AA78", Offset = "0x1B5AA78", VA = "0x1B5AA78", Slot = "8")]
		public virtual void Process()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1B5AA7C", Offset = "0x1B5AA7C", VA = "0x1B5AA7C", Slot = "9")]
		public virtual void StartTransition()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1B5AA88", Offset = "0x1B5AA88", VA = "0x1B5AA88")]
		private void Update()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1B59318", Offset = "0x1B59318", VA = "0x1B59318")]
		protected Transition()
		{
		}
	}
}
namespace InfinityCode.uPano.Transitions.UI
{
	[Token(Token = "0x2000014")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA69870", Offset = "0xA69870")]
	public class BlurTransition : UITransition
	{
		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Material blurMaterial;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string radiusFieldName;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float fromRadius;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float toRadius;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Material material;

		[Token(Token = "0x17000020")]
		protected override string containerName
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x1B5AB1C", Offset = "0x1B5AB1C", VA = "0x1B5AB1C", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1B5AB64", Offset = "0x1B5AB64", VA = "0x1B5AB64", Slot = "4")]
		protected override void Dispose()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1B5AC50", Offset = "0x1B5AC50", VA = "0x1B5AC50", Slot = "5")]
		protected override void Finish()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1B5AC58", Offset = "0x1B5AC58", VA = "0x1B5AC58", Slot = "6")]
		public override void Init()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1B5B0F4", Offset = "0x1B5B0F4", VA = "0x1B5B0F4", Slot = "8")]
		public override void Process()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1B5B1FC", Offset = "0x1B5B1FC", VA = "0x1B5B1FC")]
		public BlurTransition()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1B5B2AC", Offset = "0x1B5B2AC", VA = "0x1B5B2AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6AF30", Offset = "0xA6AF30")]
		private void <Init>b__9_0(Transition t)
		{
		}
	}
	[Token(Token = "0x2000015")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA698A8", Offset = "0xA698A8")]
	public class TintTransition : UITransition
	{
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Color fromColor;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Color toColor;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Image image;

		[Token(Token = "0x17000021")]
		protected override string containerName
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x1B5B2B8", Offset = "0x1B5B2B8", VA = "0x1B5B2B8", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1B5B300", Offset = "0x1B5B300", VA = "0x1B5B300", Slot = "4")]
		protected override void Dispose()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1B5B324", Offset = "0x1B5B324", VA = "0x1B5B324", Slot = "5")]
		protected override void Finish()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1B5B32C", Offset = "0x1B5B32C", VA = "0x1B5B32C", Slot = "6")]
		public override void Init()
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1B5B424", Offset = "0x1B5B424", VA = "0x1B5B424", Slot = "8")]
		public override void Process()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1B5B4CC", Offset = "0x1B5B4CC", VA = "0x1B5B4CC")]
		public TintTransition()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1B5B548", Offset = "0x1B5B548", VA = "0x1B5B548")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6AF40", Offset = "0xA6AF40")]
		private void <Init>b__7_0(Transition t)
		{
		}
	}
	[Token(Token = "0x2000016")]
	public abstract class UITransition : TimeBasedTransition
	{
		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool underUI;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float sizeMultiplier;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected GameObject displayGameObject;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Canvas canvas;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Graphic graphic;

		[Token(Token = "0x17000022")]
		protected abstract string containerName
		{
			[Token(Token = "0x6000088")]
			get;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1B5ABD8", Offset = "0x1B5ABD8", VA = "0x1B5ABD8", Slot = "4")]
		protected override void Dispose()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1B5AF20", Offset = "0x1B5AF20", VA = "0x1B5AF20")]
		protected void FitToScreen(Graphic g)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1B5B554", Offset = "0x1B5B554", VA = "0x1B5B554")]
		private void FitWorldSpace()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1B5AE18", Offset = "0x1B5AE18", VA = "0x1B5AE18", Slot = "6")]
		public override void Init()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1B5B1B4", Offset = "0x1B5B1B4", VA = "0x1B5B1B4", Slot = "8")]
		public override void Process()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1B5B258", Offset = "0x1B5B258", VA = "0x1B5B258")]
		protected UITransition()
		{
		}
	}
}
namespace InfinityCode.uPano.Transitions.InteractiveElements
{
	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA698E0", Offset = "0xA698E0")]
	public class LookAtActiveElement : TimeBasedTransition
	{
		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool useFov;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float targetFov;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float targetPan;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float targetTilt;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float originalPan;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float originalTilt;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float originalFov;

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1B599B8", Offset = "0x1B599B8", VA = "0x1B599B8", Slot = "6")]
		public override void Init()
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1B59AB8", Offset = "0x1B59AB8", VA = "0x1B59AB8", Slot = "8")]
		public override void Process()
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1B59C10", Offset = "0x1B59C10", VA = "0x1B59C10")]
		public LookAtActiveElement()
		{
		}
	}
	[Token(Token = "0x2000018")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA69918", Offset = "0xA69918")]
	public class ScaleInteractiveElements : TimeBasedTransition
	{
		[Token(Token = "0x2000083")]
		public enum ElementType
		{
			[Token(Token = "0x400021B")]
			activeElement,
			[Token(Token = "0x400021C")]
			allElements,
			[Token(Token = "0x400021D")]
			allSameTypeElements
		}

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public ElementType elementType;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 fromScale;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool fromScaleIsOriginal;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Vector3 toScale;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool toScaleIsOriginal;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<InteractiveElement> elements;

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1B59C60", Offset = "0x1B59C60", VA = "0x1B59C60", Slot = "4")]
		protected override void Dispose()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1B59C7C", Offset = "0x1B59C7C", VA = "0x1B59C7C", Slot = "6")]
		public override void Init()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1B5A17C", Offset = "0x1B5A17C", VA = "0x1B5A17C", Slot = "8")]
		public override void Process()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1B5A458", Offset = "0x1B5A458", VA = "0x1B5A458")]
		public ScaleInteractiveElements()
		{
		}
	}
}
namespace InfinityCode.uPano.Transitions.Helpers
{
	[Token(Token = "0x2000019")]
	public abstract class CombinedTransition : Transition
	{
		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transition[] transitions;

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1B59234", Offset = "0x1B59234", VA = "0x1B59234", Slot = "6")]
		public override void Init()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1B59310", Offset = "0x1B59310", VA = "0x1B59310")]
		protected CombinedTransition()
		{
		}
	}
	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA69950", Offset = "0xA69950")]
	public class ConsecutiveTransitions : CombinedTransition
	{
		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int index;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transition active;

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1B59320", Offset = "0x1B59320", VA = "0x1B59320")]
		private Transition GetNextTransition()
		{
			return null;
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1B59404", Offset = "0x1B59404", VA = "0x1B59404", Slot = "7")]
		protected override void OnProcess()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1B59520", Offset = "0x1B59520", VA = "0x1B59520")]
		public ConsecutiveTransitions()
		{
		}
	}
	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA69988", Offset = "0xA69988")]
	public class DelayTransition : TimeBasedTransition
	{
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1B59530", Offset = "0x1B59530", VA = "0x1B59530")]
		public DelayTransition()
		{
		}
	}
	[Token(Token = "0x200001C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA699C0", Offset = "0xA699C0")]
	public class SimultaneouslyTransitions : CombinedTransition
	{
		[Serializable]
		[Token(Token = "0x2000084")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6A89C", Offset = "0xA6A89C")]
		private sealed class <>c
		{
			[Token(Token = "0x400021E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400021F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Transition, bool> <>9__1_0;

			[Token(Token = "0x6000370")]
			[Address(RVA = "0x1B59920", Offset = "0x1B59920", VA = "0x1B59920")]
			public <>c()
			{
			}

			[Token(Token = "0x6000371")]
			[Address(RVA = "0x1B59928", Offset = "0x1B59928", VA = "0x1B59928")]
			internal bool <OnProcess>b__1_0(Transition t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1B595C0", Offset = "0x1B595C0", VA = "0x1B595C0", Slot = "6")]
		public override void Init()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1B596B4", Offset = "0x1B596B4", VA = "0x1B596B4", Slot = "7")]
		protected override void OnProcess()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1B597B8", Offset = "0x1B597B8", VA = "0x1B597B8", Slot = "9")]
		public override void StartTransition()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1B598B4", Offset = "0x1B598B4", VA = "0x1B598B4")]
		public SimultaneouslyTransitions()
		{
		}
	}
}
namespace InfinityCode.uPano.Tours
{
	[Serializable]
	[Token(Token = "0x200001D")]
	public class Tour : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000085")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6A8AC", Offset = "0xA6A8AC")]
		private sealed class <>c
		{
			[Token(Token = "0x4000220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000221")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<TourItem, bool> <>9__8_0;

			[Token(Token = "0x6000373")]
			[Address(RVA = "0x1B58ABC", Offset = "0x1B58ABC", VA = "0x1B58ABC")]
			public <>c()
			{
			}

			[Token(Token = "0x6000374")]
			[Address(RVA = "0x1B58AC4", Offset = "0x1B58AC4", VA = "0x1B58AC4")]
			internal bool <get_startItem>b__8_0(TourItem i)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 center;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float scale;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public TourPreset preset;

		[NonSerialized]
		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<TourItem> _items;

		[NonSerialized]
		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TourItem _startItem;

		[Token(Token = "0x17000023")]
		public List<TourItem> items
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x1B58744", Offset = "0x1B58744", VA = "0x1B58744")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		public TourItem startItem
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x1B587B8", Offset = "0x1B587B8", VA = "0x1B587B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x1B58980", Offset = "0x1B58980", VA = "0x1B58980")]
			set
			{
			}
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1B58A48", Offset = "0x1B58A48", VA = "0x1B58A48")]
		public Tour()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001E")]
	public class TourItem : MonoBehaviour
	{
		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 position;

		[NonSerialized]
		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private PanoRenderer _panoRenderer;

		[NonSerialized]
		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Tour _tour;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<TourItem> _outLinks;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HotSpotManager _hotSpotManager;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private DirectionManager _directionManager;

		[Token(Token = "0x17000025")]
		public DirectionManager directionManager
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x1B58AF0", Offset = "0x1B58AF0", VA = "0x1B58AF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		public HotSpotManager hotSpotManager
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x1B58AF8", Offset = "0x1B58AF8", VA = "0x1B58AF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		public List<TourItem> outLinks
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x1B58B00", Offset = "0x1B58B00", VA = "0x1B58B00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		public PanoRenderer panoRenderer
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x1B58DC8", Offset = "0x1B58DC8", VA = "0x1B58DC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		public Tour tour
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x1B58DD0", Offset = "0x1B58DD0", VA = "0x1B58DD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x1B58DD8", Offset = "0x1B58DD8", VA = "0x1B58DD8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public Texture texture
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x1B58DE0", Offset = "0x1B58DE0", VA = "0x1B58DE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x1B58EA4", Offset = "0x1B58EA4", VA = "0x1B58EA4")]
			set
			{
			}
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1B58F80", Offset = "0x1B58F80", VA = "0x1B58F80")]
		public void Init()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1B5900C", Offset = "0x1B5900C", VA = "0x1B5900C")]
		public static TourItem Create(Tour tour)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1B58B30", Offset = "0x1B58B30", VA = "0x1B58B30")]
		public void UpdateOutLinks()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1B5922C", Offset = "0x1B5922C", VA = "0x1B5922C")]
		public TourItem()
		{
		}
	}
}
namespace InfinityCode.uPano.Services
{
	[Token(Token = "0x200001F")]
	[AttributeAttribute(Name = "RequirePanoRendererAttribute", RVA = "0xA699F8", Offset = "0xA699F8")]
	[AttributeAttribute(Name = "WizardEnabledAttribute", RVA = "0xA699F8", Offset = "0xA699F8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA699F8", Offset = "0xA699F8")]
	public class GoogleStreetView : Plugin
	{
		[Token(Token = "0x2000086")]
		public enum LoadType
		{
			[Token(Token = "0x4000223")]
			id,
			[Token(Token = "0x4000224")]
			location
		}

		[Token(Token = "0x2000087")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6A8BC", Offset = "0xA6A8BC")]
		private sealed class <TestPanoLoading>d__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000225")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000226")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000227")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GoogleStreetView <>4__this;

			[Token(Token = "0x170000AD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000378")]
				[Address(RVA = "0x1B57DD4", Offset = "0x1B57DD4", VA = "0x1B57DD4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600037A")]
				[Address(RVA = "0x1B57E3C", Offset = "0x1B57E3C", VA = "0x1B57E3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000375")]
			[Address(RVA = "0x1B57BFC", Offset = "0x1B57BFC", VA = "0x1B57BFC")]
			[DebuggerHidden]
			public <TestPanoLoading>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x6000376")]
			[Address(RVA = "0x1B57C44", Offset = "0x1B57C44", VA = "0x1B57C44", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000377")]
			[Address(RVA = "0x1B57C48", Offset = "0x1B57C48", VA = "0x1B57C48", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000379")]
			[Address(RVA = "0x1B57DDC", Offset = "0x1B57DDC", VA = "0x1B57DDC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string apiKey;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool directions;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject directionPrefab;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public LoadType loadType;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public double locationLat;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public double locationLng;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string panoID;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool progressive;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6AA8C", Offset = "0xA6AA8C")]
		public int zoom;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int currentZoom;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GoogleStreetViewRequest currentRequest;

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1B56FEC", Offset = "0x1B56FEC", VA = "0x1B56FEC")]
		private void CreateDirections(GoogleStreetViewRequest request, SphericalPanoRenderer panoRenderer)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1B57534", Offset = "0x1B57534", VA = "0x1B57534")]
		public GoogleStreetViewRequest Download()
		{
			return null;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1B57624", Offset = "0x1B57624", VA = "0x1B57624")]
		public static GoogleStreetViewRequest DownloadByID(string key, string id, int zoom = 3)
		{
			return null;
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1B57590", Offset = "0x1B57590", VA = "0x1B57590")]
		public static GoogleStreetViewRequest DownloadByLocation(string key, double lng, double lat, int zoom = 3)
		{
			return null;
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1B576AC", Offset = "0x1B576AC", VA = "0x1B576AC")]
		private void LoadNextPanorama(InteractiveElement element)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1B5781C", Offset = "0x1B5781C", VA = "0x1B5781C")]
		private void OnRequestComplete(GoogleStreetViewRequest request)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1B57A84", Offset = "0x1B57A84", VA = "0x1B57A84", Slot = "8")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1B57B8C", Offset = "0x1B57B8C", VA = "0x1B57B8C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA6AF50", Offset = "0xA6AF50")]
		private IEnumerator TestPanoLoading()
		{
			return null;
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1B57C28", Offset = "0x1B57C28", VA = "0x1B57C28")]
		public GoogleStreetView()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class GoogleStreetViewDirection
	{
		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public double altitude;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string id;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public double longitude;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public double latitude;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string title;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public double distance;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pan;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public JSONArray json;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool broken;

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1B57E44", Offset = "0x1B57E44", VA = "0x1B57E44")]
		public GoogleStreetViewDirection(JSONArray json, double currentLongitude, double currentLatitude)
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class GoogleStreetViewMeta
	{
		[Token(Token = "0x2000088")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6A8CC", Offset = "0xA6A8CC")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x4000228")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GoogleStreetViewDirection item;

			[Token(Token = "0x600037B")]
			[Address(RVA = "0x1B5869C", Offset = "0x1B5869C", VA = "0x1B5869C")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x600037C")]
			[Address(RVA = "0x1B586B4", Offset = "0x1B586B4", VA = "0x1B586B4")]
			internal bool <get_nearestDirections>b__0(float p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private double? _altitude;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string _data;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string _id;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private JSONItem _json;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private double? _latitude;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private double? _longitude;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private JSONItem _nextItems;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float? _northPan;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _requestById;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GoogleStreetViewDirection[] _directions;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GoogleStreetViewDirection[] _nearestDirections;

		[Token(Token = "0x1700002B")]
		public double altitude
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x1B58038", Offset = "0x1B58038", VA = "0x1B58038")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700002C")]
		public GoogleStreetViewDirection[] directions
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x1B58184", Offset = "0x1B58184", VA = "0x1B58184")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public JSONItem json
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x1B583F8", Offset = "0x1B583F8", VA = "0x1B583F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public string id
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x1B56538", Offset = "0x1B56538", VA = "0x1B56538")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public double latitude
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x1B585C4", Offset = "0x1B585C4", VA = "0x1B585C4")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000030")]
		public double longitude
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x1B584EC", Offset = "0x1B584EC", VA = "0x1B584EC")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000031")]
		public GoogleStreetViewDirection[] nearestDirections
		{
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x1B5731C", Offset = "0x1B5731C", VA = "0x1B5731C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		private JSONItem nextItems
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x1B580F4", Offset = "0x1B580F4", VA = "0x1B580F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public float northPan
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x1B565F4", Offset = "0x1B565F4", VA = "0x1B565F4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000034")]
		public string rawData
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x1B586A4", Offset = "0x1B586A4", VA = "0x1B586A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public bool requestById
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x1B586AC", Offset = "0x1B586AC", VA = "0x1B586AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1B55574", Offset = "0x1B55574", VA = "0x1B55574")]
		public GoogleStreetViewMeta(string data, bool requestById)
		{
		}
	}
}
namespace InfinityCode.uPano.Requests
{
	[Token(Token = "0x2000022")]
	public class GoogleStreetViewMetaRequest : StatusRequest<GoogleStreetViewMetaRequest>
	{
		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string _error;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GoogleStreetViewMeta _meta;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool isDone;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool requestByID;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		private bool isUserContent;

		[Token(Token = "0x17000036")]
		public override string error
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x1B55000", Offset = "0x1B55000", VA = "0x1B55000", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public override bool hasErrors
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x1B55008", Offset = "0x1B55008", VA = "0x1B55008", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000038")]
		public override bool keepWaiting
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x1B5502C", Offset = "0x1B5502C", VA = "0x1B5502C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000039")]
		public GoogleStreetViewMeta meta
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x1B55034", Offset = "0x1B55034", VA = "0x1B55034")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1B5503C", Offset = "0x1B5503C", VA = "0x1B5503C")]
		public GoogleStreetViewMetaRequest(string key, string id, string language)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1B55210", Offset = "0x1B55210", VA = "0x1B55210")]
		public GoogleStreetViewMetaRequest(string key, double longitude, double latitude, string language)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1B5538C", Offset = "0x1B5538C", VA = "0x1B5538C")]
		private void OnRequestComplete(WWWRequest request)
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1B5519C", Offset = "0x1B5519C", VA = "0x1B5519C")]
		private void RegisterRequest(string key)
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class GoogleStreetViewRequest : StatusRequest<GoogleStreetViewRequest>
	{
		[Token(Token = "0x2000089")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6A8DC", Offset = "0xA6A8DC")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x4000229")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public WWWRequest request;

			[Token(Token = "0x400022A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int px;

			[Token(Token = "0x400022B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int py;

			[Token(Token = "0x400022C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GoogleStreetViewRequest <>4__this;

			[Token(Token = "0x600037D")]
			[Address(RVA = "0x1B5604C", Offset = "0x1B5604C", VA = "0x1B5604C")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x600037E")]
			[Address(RVA = "0x1B569E0", Offset = "0x1B569E0", VA = "0x1B569E0")]
			internal void <DownloadByID>b__0(WWWRequest <p0>)
			{
			}
		}

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string _error;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _isUserContent;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GoogleStreetViewMeta _meta;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _northPan;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string _panoID;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Texture2D _texture;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int countSuccess;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool isDone;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int maxX;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int maxY;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<WWWRequest> requests;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Texture2D tempTexture;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int zoom;

		[Token(Token = "0x1700003A")]
		public override string error
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x1B555B4", Offset = "0x1B555B4", VA = "0x1B555B4", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public override bool hasErrors
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x1B555BC", Offset = "0x1B555BC", VA = "0x1B555BC", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003C")]
		public bool isUserContent
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x1B555E0", Offset = "0x1B555E0", VA = "0x1B555E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003D")]
		public override bool keepWaiting
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x1B555E8", Offset = "0x1B555E8", VA = "0x1B555E8", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003E")]
		public GoogleStreetViewMeta meta
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x1B555F0", Offset = "0x1B555F0", VA = "0x1B555F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public float northPan
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x1B555F8", Offset = "0x1B555F8", VA = "0x1B555F8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000040")]
		public string panoID
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x1B55600", Offset = "0x1B55600", VA = "0x1B55600")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public Texture2D texture
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x1B55608", Offset = "0x1B55608", VA = "0x1B55608")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1B55610", Offset = "0x1B55610", VA = "0x1B55610")]
		public GoogleStreetViewRequest(string key, string id, int zoom, bool downloadMeta = false, string language = "en")
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1B55DA8", Offset = "0x1B55DA8", VA = "0x1B55DA8")]
		public GoogleStreetViewRequest(string key, double longitude, double latitude, int zoom, string language = "en")
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1B55EE8", Offset = "0x1B55EE8", VA = "0x1B55EE8", Slot = "10")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1B55774", Offset = "0x1B55774", VA = "0x1B55774")]
		private void DownloadByID(string panoID)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1B56054", Offset = "0x1B56054", VA = "0x1B56054")]
		private void FinalizeTexture()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1B56368", Offset = "0x1B56368", VA = "0x1B56368")]
		public static bool IsEmptyColor(Color32 c)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1B563B0", Offset = "0x1B563B0", VA = "0x1B563B0")]
		private void OnDownloadMetaComplete(GoogleStreetViewMetaRequest request)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1B56710", Offset = "0x1B56710", VA = "0x1B56710")]
		private void OnPanoPartDownloaded(WWWRequest www, int x, int y)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1B568A0", Offset = "0x1B568A0", VA = "0x1B568A0")]
		private void TryFinalize()
		{
		}
	}
	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xA69A94", Offset = "0xA69A94")]
	public abstract class Request<T> : CustomYieldInstruction, IDisposable where T : Request<T>
	{
		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Action<T> OnComplete;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Dictionary<string, object> _customFields;

		[Token(Token = "0x17000042")]
		public object Item
		{
			[Token(Token = "0x60000DF")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public Dictionary<string, object> customFields
		{
			[Token(Token = "0x60000E1")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E2")]
		protected void BroadcastAction(Action<T> action)
		{
		}

		[Token(Token = "0x60000E3")]
		protected virtual void BroadcastActions()
		{
		}

		[Token(Token = "0x60000E4")]
		public virtual void Dispose()
		{
		}

		[Token(Token = "0x60000E5")]
		protected Request()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public abstract class StatusRequest<T> : Request<T> where T : StatusRequest<T>
	{
		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Action<T> OnSuccess;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Action<T> OnError;

		[Token(Token = "0x17000044")]
		public abstract bool hasErrors
		{
			[Token(Token = "0x60000E6")]
			get;
		}

		[Token(Token = "0x17000045")]
		public abstract string error
		{
			[Token(Token = "0x60000E7")]
			get;
		}

		[Token(Token = "0x60000E8")]
		protected override void BroadcastActions()
		{
		}

		[Token(Token = "0x60000E9")]
		protected StatusRequest()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class WWWRequest : StatusRequest<WWWRequest>
	{
		[Token(Token = "0x200008A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6A8EC", Offset = "0xA6A8EC")]
		private sealed class <Download>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400022D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400022E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400022F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WWWRequest <>4__this;

			[Token(Token = "0x4000230")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UnityWebRequestAsyncOperation <asyncOperation>5__2;

			[Token(Token = "0x170000AF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000382")]
				[Address(RVA = "0x1B56D68", Offset = "0x1B56D68", VA = "0x1B56D68", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000384")]
				[Address(RVA = "0x1B56DD0", Offset = "0x1B56DD0", VA = "0x1B56DD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600037F")]
			[Address(RVA = "0x1B56BAC", Offset = "0x1B56BAC", VA = "0x1B56BAC")]
			[DebuggerHidden]
			public <Download>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x6000380")]
			[Address(RVA = "0x1B56C80", Offset = "0x1B56C80", VA = "0x1B56C80", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000381")]
			[Address(RVA = "0x1B56C84", Offset = "0x1B56C84", VA = "0x1B56C84", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000383")]
			[Address(RVA = "0x1B56D70", Offset = "0x1B56D70", VA = "0x1B56D70", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Func<string, string> OnPrepareURL;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly string url;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IEnumerator routine;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WWWClient client;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest www;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Texture2D _texture;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _isDone;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string _error;

		[Token(Token = "0x17000046")]
		public byte[] bytes
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x1B56A04", Offset = "0x1B56A04", VA = "0x1B56A04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public override string error
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x1B56A44", Offset = "0x1B56A44", VA = "0x1B56A44", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public override bool hasErrors
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x1B56A5C", Offset = "0x1B56A5C", VA = "0x1B56A5C", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000049")]
		public bool isDone
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x1B56A88", Offset = "0x1B56A88", VA = "0x1B56A88")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004A")]
		public override bool keepWaiting
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x1B56A90", Offset = "0x1B56A90", VA = "0x1B56A90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004B")]
		public string text
		{
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x1B55534", Offset = "0x1B55534", VA = "0x1B55534")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public Texture2D texture
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x1B4F5F8", Offset = "0x1B4F5F8", VA = "0x1B4F5F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1B4EF70", Offset = "0x1B4EF70", VA = "0x1B4EF70")]
		public WWWRequest(string url)
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1B56AA0", Offset = "0x1B56AA0", VA = "0x1B56AA0")]
		internal WWWRequest(WWWClient client, string url)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1B56B3C", Offset = "0x1B56B3C", VA = "0x1B56B3C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA6AFB4", Offset = "0xA6AFB4")]
		internal IEnumerator Download()
		{
			return null;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1B56BD8", Offset = "0x1B56BD8", VA = "0x1B56BD8", Slot = "10")]
		public override void Dispose()
		{
		}
	}
}
namespace InfinityCode.uPano.Renderers
{
	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA69ACC", Offset = "0xA69ACC")]
	public class CubeFacesPanoRenderer : CubePanoRenderer<CubeFacesPanoRenderer>
	{
		[Token(Token = "0x200008B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6A8FC", Offset = "0xA6A8FC")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000231")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int i;

			[Token(Token = "0x4000232")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CubeFacesPanoRenderer <>4__this;

			[Token(Token = "0x6000385")]
			[Address(RVA = "0x1B4EF68", Offset = "0x1B4EF68", VA = "0x1B4EF68")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000386")]
			[Address(RVA = "0x1B4F474", Offset = "0x1B4F474", VA = "0x1B4F474")]
			internal void <Download>b__0(WWWRequest r)
			{
			}
		}

		[Token(Token = "0x200008C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6A90C", Offset = "0xA6A90C")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x4000233")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CubeFacesPanoRenderer <>4__this;

			[Token(Token = "0x4000234")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string[] urls;

			[Token(Token = "0x6000387")]
			[Address(RVA = "0x1B4F1EC", Offset = "0x1B4F1EC", VA = "0x1B4F1EC")]
			public <>c__DisplayClass11_0()
			{
			}
		}

		[Token(Token = "0x200008D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6A91C", Offset = "0xA6A91C")]
		private sealed class <>c__DisplayClass11_1
		{
			[Token(Token = "0x4000235")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int j;

			[Token(Token = "0x4000236")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass11_0 CS$<>8__locals1;

			[Token(Token = "0x4000237")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<WWWRequest> <>9__1;

			[Token(Token = "0x6000388")]
			[Address(RVA = "0x1B4F1F4", Offset = "0x1B4F1F4", VA = "0x1B4F1F4")]
			public <>c__DisplayClass11_1()
			{
			}

			[Token(Token = "0x6000389")]
			[Address(RVA = "0x1B4F6C4", Offset = "0x1B4F6C4", VA = "0x1B4F6C4")]
			internal void <Download>b__0(WWWRequest r)
			{
			}

			[Token(Token = "0x600038A")]
			[Address(RVA = "0x1B4F91C", Offset = "0x1B4F91C", VA = "0x1B4F91C")]
			internal void <Download>b__1(WWWRequest r2)
			{
			}
		}

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Texture2D[] _textures;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Material[] materials;

		[Token(Token = "0x1700004D")]
		public Texture2D[] textures
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x1B4E590", Offset = "0x1B4E590", VA = "0x1B4E590")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x1B4E5FC", Offset = "0x1B4E5FC", VA = "0x1B4E5FC")]
			set
			{
			}
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1B4E734", Offset = "0x1B4E734", VA = "0x1B4E734")]
		public static CubeFacesPanoRenderer Create(Texture2D[] textures, Vector3 size)
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1B4E81C", Offset = "0x1B4E81C", VA = "0x1B4E81C", Slot = "5")]
		protected override void CreateMaterial()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x1B4EA48", Offset = "0x1B4EA48", VA = "0x1B4EA48", Slot = "6")]
		public override bool CreateMesh()
		{
			return default(bool);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x1B4EB10", Offset = "0x1B4EB10", VA = "0x1B4EB10", Slot = "16")]
		protected override int[][] CreateTriangles()
		{
			return null;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1B4EC48", Offset = "0x1B4EC48", VA = "0x1B4EC48", Slot = "17")]
		protected override Vector2[] CreateUV()
		{
			return null;
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1B4EDB4", Offset = "0x1B4EDB4", VA = "0x1B4EDB4")]
		public void Download(string[] urls)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1B4F014", Offset = "0x1B4F014", VA = "0x1B4F014")]
		public void Download(string[] lowresURLs, string[] urls)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1B4F1FC", Offset = "0x1B4F1FC", VA = "0x1B4F1FC")]
		public void SetSide(int index, Texture2D texture)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1B4F328", Offset = "0x1B4F328", VA = "0x1B4F328", Slot = "15")]
		protected override bool ValidateFields()
		{
			return default(bool);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1B4F330", Offset = "0x1B4F330", VA = "0x1B4F330", Slot = "14")]
		protected override void UpdateShader()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1B4F424", Offset = "0x1B4F424", VA = "0x1B4F424")]
		public CubeFacesPanoRenderer()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA69B04", Offset = "0xA69B04")]
	public class CubemapPanoRenderer : CubePanoRenderer<CubemapPanoRenderer>
	{
		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Cubemap _cubemap;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected Material material;

		[Token(Token = "0x1700004E")]
		public override Shader defaultShader
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x1B4FAB0", Offset = "0x1B4FAB0", VA = "0x1B4FAB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public Cubemap cubemap
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x1B4FAFC", Offset = "0x1B4FAFC", VA = "0x1B4FAFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x1B4FB04", Offset = "0x1B4FB04", VA = "0x1B4FB04")]
			set
			{
			}
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1B4FBA8", Offset = "0x1B4FBA8", VA = "0x1B4FBA8")]
		public static CubemapPanoRenderer Create(Cubemap cubemap, Vector3 size)
		{
			return null;
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1B4FC98", Offset = "0x1B4FC98", VA = "0x1B4FC98", Slot = "5")]
		protected override void CreateMaterial()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1B4FDA0", Offset = "0x1B4FDA0", VA = "0x1B4FDA0", Slot = "6")]
		public override bool CreateMesh()
		{
			return default(bool);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1B4FE7C", Offset = "0x1B4FE7C", VA = "0x1B4FE7C", Slot = "17")]
		protected override Vector2[] CreateUV()
		{
			return null;
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1B50148", Offset = "0x1B50148", VA = "0x1B50148", Slot = "15")]
		protected override bool ValidateFields()
		{
			return default(bool);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1B50150", Offset = "0x1B50150", VA = "0x1B50150")]
		public CubemapPanoRenderer()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA69B3C", Offset = "0xA69B3C")]
	public class CylindricalPanoRenderer : SingleTexturePanoRenderer<CylindricalPanoRenderer>
	{
		[Token(Token = "0x40000BE")]
		public const float minRadius = 0.0001f;

		[Token(Token = "0x40000BF")]
		public const int minSides = 3;

		[Token(Token = "0x40000C0")]
		public const int maxSides = 1024;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		protected float _height;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		protected float _radius;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		protected int _sides;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[SerializeField]
		protected RectUV _uv;

		[Token(Token = "0x17000050")]
		public float height
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x1B501A0", Offset = "0x1B501A0", VA = "0x1B501A0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x1B501A8", Offset = "0x1B501A8", VA = "0x1B501A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public float radius
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x1B501C8", Offset = "0x1B501C8", VA = "0x1B501C8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x1B501D0", Offset = "0x1B501D0", VA = "0x1B501D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public int sides
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x1B501FC", Offset = "0x1B501FC", VA = "0x1B501FC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x1B50204", Offset = "0x1B50204", VA = "0x1B50204")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public RectUV uv
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x1B502B0", Offset = "0x1B502B0", VA = "0x1B502B0")]
			get
			{
				return default(RectUV);
			}
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x1B502BC", Offset = "0x1B502BC", VA = "0x1B502BC")]
			set
			{
			}
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1B502D0", Offset = "0x1B502D0", VA = "0x1B502D0")]
		public static CylindricalPanoRenderer Create(Texture2D texture, float radius, float height, int sides)
		{
			return null;
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1B50520", Offset = "0x1B50520", VA = "0x1B50520", Slot = "6")]
		public override bool CreateMesh()
		{
			return default(bool);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1B50A54", Offset = "0x1B50A54", VA = "0x1B50A54", Slot = "22")]
		public override bool GetPanTiltByUV(Vector2 uv, out float pan, out float tilt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1B50A88", Offset = "0x1B50A88", VA = "0x1B50A88", Slot = "8")]
		public override void GetPanTiltByWorldPosition(Vector3 worldPosition, out float pan, out float tilt)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1B50C34", Offset = "0x1B50C34", VA = "0x1B50C34", Slot = "23")]
		public override Vector2 GetUV(float pan, float tilt)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1B50C84", Offset = "0x1B50C84", VA = "0x1B50C84", Slot = "9")]
		public override Vector3 GetWorldPosition(float pan, float tilt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1B50E88", Offset = "0x1B50E88", VA = "0x1B50E88", Slot = "13")]
		public override void UpdateRotation(Camera activeCamera, float pan, float tilt)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1B51458", Offset = "0x1B51458", VA = "0x1B51458", Slot = "15")]
		protected override bool ValidateFields()
		{
			return default(bool);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1B51488", Offset = "0x1B51488", VA = "0x1B51488")]
		public CylindricalPanoRenderer()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA69B74", Offset = "0xA69B74")]
	public class SingleTextureCubeFacesPanoRenderer : SingleTexturePanoRenderer<SingleTextureCubeFacesPanoRenderer>
	{
		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		protected CubeUV _cubeUV;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		protected Vector3 _size;

		[Token(Token = "0x17000054")]
		public Vector3 size
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x1B51514", Offset = "0x1B51514", VA = "0x1B51514")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x1B51520", Offset = "0x1B51520", VA = "0x1B51520")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public CubeUV cubeUV
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x1B515FC", Offset = "0x1B515FC", VA = "0x1B515FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x1B51604", Offset = "0x1B51604", VA = "0x1B51604")]
			set
			{
			}
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1B51628", Offset = "0x1B51628", VA = "0x1B51628")]
		public static SingleTextureCubeFacesPanoRenderer Create(Texture2D texture, Vector3 size, CubeUV cubeUV)
		{
			return null;
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1B516B8", Offset = "0x1B516B8", VA = "0x1B516B8", Slot = "6")]
		public override bool CreateMesh()
		{
			return default(bool);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1B51FCC", Offset = "0x1B51FCC", VA = "0x1B51FCC")]
		protected int[][] CreateTriangles()
		{
			return null;
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1B52114", Offset = "0x1B52114", VA = "0x1B52114")]
		protected Vector2[] CreateUV()
		{
			return null;
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1B51934", Offset = "0x1B51934", VA = "0x1B51934")]
		protected Vector3[] CreateVertices()
		{
			return null;
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1B524D8", Offset = "0x1B524D8", VA = "0x1B524D8", Slot = "22")]
		public override bool GetPanTiltByUV(Vector2 uv, out float pan, out float tilt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1B52734", Offset = "0x1B52734", VA = "0x1B52734", Slot = "23")]
		public override Vector2 GetUV(float pan, float tilt)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1B52B84", Offset = "0x1B52B84", VA = "0x1B52B84", Slot = "9")]
		public override Vector3 GetWorldPosition(float pan, float tilt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1B52D28", Offset = "0x1B52D28", VA = "0x1B52D28", Slot = "15")]
		protected override bool ValidateFields()
		{
			return default(bool);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1B52D30", Offset = "0x1B52D30", VA = "0x1B52D30")]
		public SingleTextureCubeFacesPanoRenderer()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA69BAC", Offset = "0xA69BAC")]
	public class SphericalPanoRenderer : SingleTexturePanoRenderer<SphericalPanoRenderer>
	{
		[Token(Token = "0x200008E")]
		public enum MeshType
		{
			[Token(Token = "0x4000239")]
			sphere,
			[Token(Token = "0x400023A")]
			icosahedron
		}

		[Token(Token = "0x40000C7")]
		public const int maxQuality = 4;

		[Token(Token = "0x40000C8")]
		public const float minRadius = 0.001f;

		[Token(Token = "0x40000C9")]
		public const int minSegments = 4;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private MeshType _meshType;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6AB34", Offset = "0xA6AB34")]
		private int _quality;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		protected float _radius;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private int _segments;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		protected RectUV _uv;

		[Token(Token = "0x17000056")]
		public MeshType meshType
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x1B52E60", Offset = "0x1B52E60", VA = "0x1B52E60")]
			get
			{
				return default(MeshType);
			}
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x1B52E68", Offset = "0x1B52E68", VA = "0x1B52E68")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public int quality
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x1B52E70", Offset = "0x1B52E70", VA = "0x1B52E70")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x1B52E78", Offset = "0x1B52E78", VA = "0x1B52E78")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public float radius
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x1B52F24", Offset = "0x1B52F24", VA = "0x1B52F24")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x1B52F2C", Offset = "0x1B52F2C", VA = "0x1B52F2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public int segments
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x1B52FDC", Offset = "0x1B52FDC", VA = "0x1B52FDC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x1B52FE4", Offset = "0x1B52FE4", VA = "0x1B52FE4")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public RectUV uv
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x1B53010", Offset = "0x1B53010", VA = "0x1B53010")]
			get
			{
				return default(RectUV);
			}
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x1B5301C", Offset = "0x1B5301C", VA = "0x1B5301C")]
			set
			{
			}
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1B53030", Offset = "0x1B53030", VA = "0x1B53030")]
		public static SphericalPanoRenderer CreateIcosahedron(Texture texture, float radius, int quality)
		{
			return null;
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1B53180", Offset = "0x1B53180", VA = "0x1B53180")]
		private void CreateIcosahedronMesh()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1B5426C", Offset = "0x1B5426C", VA = "0x1B5426C", Slot = "6")]
		public override bool CreateMesh()
		{
			return default(bool);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1B547E0", Offset = "0x1B547E0", VA = "0x1B547E0")]
		public static SphericalPanoRenderer CreateSphere(Texture texture, float radius, int segments)
		{
			return null;
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1B5434C", Offset = "0x1B5434C", VA = "0x1B5434C")]
		private void CreateSphereMesh()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1B54024", Offset = "0x1B54024", VA = "0x1B54024")]
		private void FixWrappedUV(int[] triangles, List<Vector3> vertices, List<Vector2> uv, int[] cache, ref int ci, int i1, int i2, int v1, int v2, Vector2 uv1, Vector2 uv2)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1B5492C", Offset = "0x1B5492C", VA = "0x1B5492C")]
		private int GetMidpointIndex(List<Vector3> vertices, int i0, int i1, int[] cache, ref int ci)
		{
			return default(int);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1B54B80", Offset = "0x1B54B80", VA = "0x1B54B80", Slot = "22")]
		public override bool GetPanTiltByUV(Vector2 uv, out float pan, out float tilt)
		{
			return default(bool);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1B54C5C", Offset = "0x1B54C5C", VA = "0x1B54C5C", Slot = "23")]
		public override Vector2 GetUV(float pan, float tilt)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1B54D60", Offset = "0x1B54D60", VA = "0x1B54D60", Slot = "9")]
		public override Vector3 GetWorldPosition(float pan, float tilt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1B53D50", Offset = "0x1B53D50", VA = "0x1B53D50")]
		private void SubdivideIcosahedron(List<Vector3> vertices, ref int[] triangles, int[] cache)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1B54F2C", Offset = "0x1B54F2C", VA = "0x1B54F2C", Slot = "15")]
		protected override bool ValidateFields()
		{
			return default(bool);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1B54F70", Offset = "0x1B54F70", VA = "0x1B54F70")]
		public SphericalPanoRenderer()
		{
		}
	}
}
namespace InfinityCode.uPano.Renderers.Base
{
	[Token(Token = "0x200002C")]
	public abstract class CubePanoRenderer<T> : PanoRenderer<T> where T : CubePanoRenderer<T>
	{
		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected Vector3 _size;

		[Token(Token = "0x1700005B")]
		public Vector3 size
		{
			[Token(Token = "0x6000141")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000142")]
			set
			{
			}
		}

		[Token(Token = "0x6000143")]
		protected virtual int[][] CreateTriangles()
		{
			return null;
		}

		[Token(Token = "0x6000144")]
		protected abstract Vector2[] CreateUV();

		[Token(Token = "0x6000145")]
		protected Vector3[] CreateVertices()
		{
			return null;
		}

		[Token(Token = "0x6000146")]
		public override bool CreateMesh()
		{
			return default(bool);
		}

		[Token(Token = "0x6000147")]
		public override Vector3 GetWorldPosition(float pan, float tilt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000148")]
		protected CubePanoRenderer()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public abstract class PanoRenderer<T> : PanoRenderer where T : PanoRenderer<T>
	{
		[Token(Token = "0x6000149")]
		protected static T CreatePanoInstance()
		{
			return null;
		}

		[Token(Token = "0x600014A")]
		protected PanoRenderer()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public interface ISingleTexturePanoRenderer
	{
		[Token(Token = "0x1700005C")]
		Texture texture
		{
			[Token(Token = "0x600014B")]
			get;
			[Token(Token = "0x600014C")]
			set;
		}

		[Token(Token = "0x600014D")]
		void Download(string url);

		[Token(Token = "0x600014E")]
		void Download(string lowresURL, string url);

		[Token(Token = "0x600014F")]
		bool GetPanTiltByUV(Vector2 uv, out float pan, out float tilt);

		[Token(Token = "0x6000150")]
		Vector2 GetUV(float pan, float tilt);
	}
	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA69BE4", Offset = "0xA69BE4")]
	[DisallowMultipleComponent]
	public abstract class PanoRenderer : MonoBehaviour
	{
		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action OnStart;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action OnUpdate;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected Material _defaultMaterial;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Pano _pano;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected Shader _shader;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected string _mainTex;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool hasMesh;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected GameObject _meshGameObject;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected MeshRenderer meshRenderer;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected MeshFilter meshFilter;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected Mesh mesh;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected MeshCollider meshCollider;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool isFirstCreate;

		[Token(Token = "0x1700005D")]
		public Material defaultMaterial
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x1B4D348", Offset = "0x1B4D348", VA = "0x1B4D348")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x1B4D350", Offset = "0x1B4D350", VA = "0x1B4D350")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public virtual Shader defaultShader
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x1B4D3F4", Offset = "0x1B4D3F4", VA = "0x1B4D3F4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		public Pano pano
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x1B4D440", Offset = "0x1B4D440", VA = "0x1B4D440")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		public GameObject meshGameObject
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x1B4D4D8", Offset = "0x1B4D4D8", VA = "0x1B4D4D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		public Shader shader
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x1B4D4E0", Offset = "0x1B4D4E0", VA = "0x1B4D4E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x1B4D574", Offset = "0x1B4D574", VA = "0x1B4D574")]
			set
			{
			}
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1B4D65C", Offset = "0x1B4D65C", VA = "0x1B4D65C", Slot = "5")]
		protected virtual void CreateMaterial()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1B4D660", Offset = "0x1B4D660", VA = "0x1B4D660", Slot = "6")]
		public virtual bool CreateMesh()
		{
			return default(bool);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1B4DA74", Offset = "0x1B4DA74", VA = "0x1B4DA74")]
		public void DestroyMesh()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1B4DAA0", Offset = "0x1B4DAA0", VA = "0x1B4DAA0", Slot = "7")]
		protected virtual void DestroyMeshItems()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1B4DCB4", Offset = "0x1B4DCB4", VA = "0x1B4DCB4")]
		public bool GetPanTiltByScreenPosition(float screenPosX, float screenPosY, out float pan, out float tilt)
		{
			return default(bool);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1B4DD08", Offset = "0x1B4DD08", VA = "0x1B4DD08")]
		public bool GetPanTiltByScreenPosition(Vector2 screenPoint, out float pan, out float tilt)
		{
			return default(bool);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x1B4DE30", Offset = "0x1B4DE30", VA = "0x1B4DE30", Slot = "8")]
		public virtual void GetPanTiltByWorldPosition(Vector3 worldPosition, out float pan, out float tilt)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1B4E088", Offset = "0x1B4E088", VA = "0x1B4E088")]
		public bool GetPanTiltUnderCursor(out float pan, out float tilt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x1B4E13C", Offset = "0x1B4E13C", VA = "0x1B4E13C")]
		public Vector3 GetScreenPosition(float pan, float tilt, [Optional] Camera cam)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000161")]
		public abstract Vector3 GetWorldPosition(float pan, float tilt);

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1B4D6F0", Offset = "0x1B4D6F0", VA = "0x1B4D6F0")]
		protected void InitMesh()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1B4E204", Offset = "0x1B4E204", VA = "0x1B4E204")]
		protected void OnEnable()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1B4E25C", Offset = "0x1B4E25C", VA = "0x1B4E25C", Slot = "10")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1B4E388", Offset = "0x1B4E388", VA = "0x1B4E388", Slot = "11")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1B4E394", Offset = "0x1B4E394", VA = "0x1B4E394")]
		protected void SetMainTexture(Material m, Texture t)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1B4E458", Offset = "0x1B4E458", VA = "0x1B4E458", Slot = "12")]
		public virtual void UpdateMesh()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1B4E498", Offset = "0x1B4E498", VA = "0x1B4E498", Slot = "13")]
		public virtual void UpdateRotation(Camera activeCamera, float pan, float tilt)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x1B4E52C", Offset = "0x1B4E52C", VA = "0x1B4E52C", Slot = "14")]
		protected virtual void UpdateShader()
		{
		}

		[Token(Token = "0x600016A")]
		protected abstract bool ValidateFields();

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x1B4E530", Offset = "0x1B4E530", VA = "0x1B4E530")]
		protected PanoRenderer()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public abstract class SingleTexturePanoRenderer<T> : PanoRenderer<T>, ISingleTexturePanoRenderer where T : SingleTexturePanoRenderer<T>
	{
		[Token(Token = "0x200008F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6A92C", Offset = "0xA6A92C")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x400023B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SingleTexturePanoRenderer<T> <>4__this;

			[Token(Token = "0x400023C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string url;

			[Token(Token = "0x600038B")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x600038C")]
			internal void <Download>b__0(WWWRequest r)
			{
			}
		}

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected Texture _texture;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Material _material;

		[Token(Token = "0x17000062")]
		public Texture texture
		{
			[Token(Token = "0x600016C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600016D")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public Material material
		{
			[Token(Token = "0x600016E")]
			get
			{
				return null;
			}
			[Token(Token = "0x600016F")]
			set
			{
			}
		}

		[Token(Token = "0x6000170")]
		protected override void CreateMaterial()
		{
		}

		[Token(Token = "0x6000171")]
		public override bool CreateMesh()
		{
			return default(bool);
		}

		[Token(Token = "0x6000172")]
		protected override void DestroyMeshItems()
		{
		}

		[Token(Token = "0x6000173")]
		public void Download(string url)
		{
		}

		[Token(Token = "0x6000174")]
		public void Download(string lowresURL, string url)
		{
		}

		[Token(Token = "0x6000175")]
		public abstract bool GetPanTiltByUV(Vector2 uv, out float pan, out float tilt);

		[Token(Token = "0x6000176")]
		public abstract Vector2 GetUV(float pan, float tilt);

		[Token(Token = "0x6000177")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000178")]
		private void OnLowResRequestComplete(WWWRequest request)
		{
		}

		[Token(Token = "0x6000179")]
		private void OnRequestComplete(WWWRequest request)
		{
		}

		[Token(Token = "0x600017A")]
		protected override void UpdateShader()
		{
		}

		[Token(Token = "0x600017B")]
		protected SingleTexturePanoRenderer()
		{
		}
	}
}
namespace InfinityCode.uPano.Plugins
{
	[Serializable]
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA69C58", Offset = "0xA69C58")]
	public class AutoRotate : Plugin
	{
		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool stopOnInput;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool restoreByTimer;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float restoreAfter;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float panSpeed;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float tiltSpeed;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float pauseTimer;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool _paused;

		[Token(Token = "0x17000064")]
		public bool paused
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x14D3B4C", Offset = "0x14D3B4C", VA = "0x14D3B4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x14C4110", Offset = "0x14C4110", VA = "0x14C4110")]
			set
			{
			}
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x14D3B54", Offset = "0x14D3B54", VA = "0x14D3B54")]
		private void OnControlStarted(PanoControl control)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x14D3D00", Offset = "0x14D3D00", VA = "0x14D3D00")]
		private void OnControlInput(PanoControl control)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x14D3D1C", Offset = "0x14D3D1C", VA = "0x14D3D1C", Slot = "7")]
		protected override void OnEnableLate()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x14D4020", Offset = "0x14D4020", VA = "0x14D4020")]
		private void OnPanoEnabled(Pano newPano)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x14D4100", Offset = "0x14D4100", VA = "0x14D4100")]
		private void Update()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x14D4240", Offset = "0x14D4240", VA = "0x14D4240")]
		public AutoRotate()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA69C90", Offset = "0xA69C90")]
	public class Downloader : Plugin
	{
		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool useLowRes;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string url;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string lowresUrl;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string[] sidesURLs;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string[] lowresSidesURLs;

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x14D4268", Offset = "0x14D4268", VA = "0x14D4268", Slot = "8")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x14D44BC", Offset = "0x14D44BC", VA = "0x14D44BC")]
		public Downloader()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "WizardEnabledAttribute", RVA = "0xA69CC8", Offset = "0xA69CC8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA69CC8", Offset = "0xA69CC8")]
	public class Limits : Plugin
	{
		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private FloatRange _fovLimits;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private FloatRange _panLimits;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private FloatRange _tiltLimits;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _limitFOV;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		[SerializeField]
		private bool _limitPan;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		[SerializeField]
		private bool _limitTilt;

		[Token(Token = "0x17000065")]
		public FloatRange fovLimits
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x14D4534", Offset = "0x14D4534", VA = "0x14D4534")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x14D45AC", Offset = "0x14D45AC", VA = "0x14D45AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public FloatRange panLimits
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x14D45DC", Offset = "0x14D45DC", VA = "0x14D45DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x14D4654", Offset = "0x14D4654", VA = "0x14D4654")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public FloatRange tiltLimits
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x14D4684", Offset = "0x14D4684", VA = "0x14D4684")]
			get
			{
				return null;
			}
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x14D46FC", Offset = "0x14D46FC", VA = "0x14D46FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public bool limitFOV
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x14D472C", Offset = "0x14D472C", VA = "0x14D472C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x14D4734", Offset = "0x14D4734", VA = "0x14D4734")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public bool limitPan
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x14D4770", Offset = "0x14D4770", VA = "0x14D4770")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x14D4778", Offset = "0x14D4778", VA = "0x14D4778")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public bool limitTilt
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x14D47B4", Offset = "0x14D47B4", VA = "0x14D47B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x14D47BC", Offset = "0x14D47BC", VA = "0x14D47BC")]
			set
			{
			}
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x14D47F8", Offset = "0x14D47F8", VA = "0x14D47F8", Slot = "7")]
		protected override void OnEnableLate()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x14D49AC", Offset = "0x14D49AC", VA = "0x14D49AC")]
		private float VerifyFOV(float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x14D4A78", Offset = "0x14D4A78", VA = "0x14D4A78")]
		private float VerifyPan(float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x14D4BB8", Offset = "0x14D4BB8", VA = "0x14D4BB8")]
		private float VerifyTilt(float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x14D4C84", Offset = "0x14D4C84", VA = "0x14D4C84")]
		public Limits()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA69D18", Offset = "0xA69D18")]
	public class MultiCamera : Plugin
	{
		[Token(Token = "0x2000090")]
		public enum ItemsType
		{
			[Token(Token = "0x400023E")]
			manual,
			[Token(Token = "0x400023F")]
			childsOfGameObject
		}

		[Token(Token = "0x2000091")]
		public enum InitType
		{
			[Token(Token = "0x4000241")]
			Start,
			[Token(Token = "0x4000242")]
			LateUpdate
		}

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Camera[] cameras;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ItemsType itemsType;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public InitType initType;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool excludeContainer;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject camerasContainer;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool updateDistance;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve distanceCurve;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool inited;

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x14D4D54", Offset = "0x14D4D54", VA = "0x14D4D54")]
		private void InitCameras()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x14D4F58", Offset = "0x14D4F58", VA = "0x14D4F58")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x14D4F74", Offset = "0x14D4F74", VA = "0x14D4F74", Slot = "7")]
		protected override void OnEnableLate()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x14D50A0", Offset = "0x14D50A0", VA = "0x14D50A0", Slot = "9")]
		protected virtual void OnFovChanged(float value)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x14D52D0", Offset = "0x14D52D0", VA = "0x14D52D0", Slot = "8")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x14D51C0", Offset = "0x14D51C0", VA = "0x14D51C0")]
		protected void UpdateDistance(Camera cam, float distanceValue)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x14D5324", Offset = "0x14D5324", VA = "0x14D5324")]
		public MultiCamera()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x14D5374", Offset = "0x14D5374", VA = "0x14D5374")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6B018", Offset = "0xA6B018")]
		private bool <InitCameras>b__10_0(Camera c)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA69D50", Offset = "0xA69D50")]
	public class OrthographicCameras : MultiCamera
	{
		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve orthographicSizeCurve;

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1B4C1F0", Offset = "0x1B4C1F0", VA = "0x1B4C1F0", Slot = "9")]
		protected override void OnFovChanged(float value)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1B4C32C", Offset = "0x1B4C32C", VA = "0x1B4C32C")]
		public OrthographicCameras()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public abstract class Plugin : MonoBehaviour
	{
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<Plugin> OnPluginStarted;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Pano _pano;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected PanoRenderer _panoRenderer;

		[Token(Token = "0x1700006B")]
		public Pano pano
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x1B4C370", Offset = "0x1B4C370", VA = "0x1B4C370")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006C")]
		public PanoRenderer panoRenderer
		{
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x1B4C378", Offset = "0x1B4C378", VA = "0x1B4C378")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1B4C380", Offset = "0x1B4C380", VA = "0x1B4C380", Slot = "4")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1B4C384", Offset = "0x1B4C384", VA = "0x1B4C384", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1B4C388", Offset = "0x1B4C388", VA = "0x1B4C388")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1B4C4A8", Offset = "0x1B4C4A8", VA = "0x1B4C4A8", Slot = "6")]
		protected virtual void GetPanoInstance()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1B4C500", Offset = "0x1B4C500", VA = "0x1B4C500", Slot = "7")]
		protected virtual void OnEnableLate()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1B4C504", Offset = "0x1B4C504", VA = "0x1B4C504", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1B4C578", Offset = "0x1B4C578", VA = "0x1B4C578")]
		protected Plugin()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA69D88", Offset = "0xA69D88")]
	public class TimedGaze : Plugin
	{
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject gazeCircle;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Image frontCircleImage;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Component disableComponent;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject disableGameObject;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float delayBefore;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float delayAfter;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float time;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool started;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float t;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private HotSpotGlobalActions hsga;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private DirectionGlobalActions dga;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private InteractiveElement targetElement;

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1B4C580", Offset = "0x1B4C580", VA = "0x1B4C580")]
		private void HideCircle(InteractiveElement element)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1B4C6F4", Offset = "0x1B4C6F4", VA = "0x1B4C6F4")]
		private void ShowCircle(InteractiveElement element)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x1B4CB98", Offset = "0x1B4CB98", VA = "0x1B4CB98", Slot = "8")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x1B4CD48", Offset = "0x1B4CD48", VA = "0x1B4CD48")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1B4C86C", Offset = "0x1B4C86C", VA = "0x1B4C86C")]
		private void UpdateProgress()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1B4CD90", Offset = "0x1B4CD90", VA = "0x1B4CD90")]
		public TimedGaze()
		{
		}
	}
}
namespace InfinityCode.uPano.Net
{
	[Token(Token = "0x2000038")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA69E08", Offset = "0xA69E08")]
	public class WWWClient : MonoBehaviour
	{
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static WWWClient instance;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<WWWRequest> requests;

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x14D2C7C", Offset = "0x14D2C7C", VA = "0x14D2C7C")]
		private WWWRequest AddRequest(WWWRequest request)
		{
			return null;
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x14D2D5C", Offset = "0x14D2D5C", VA = "0x14D2D5C")]
		internal static WWWClient Add(WWWRequest request)
		{
			return null;
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x14D2EB4", Offset = "0x14D2EB4", VA = "0x14D2EB4")]
		public static WWWRequest Get(string url)
		{
			return null;
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x14D2DD0", Offset = "0x14D2DD0", VA = "0x14D2DD0")]
		private static void Init()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x14D2F18", Offset = "0x14D2F18", VA = "0x14D2F18")]
		private WWWRequest GetInternal(string url)
		{
			return null;
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x14D2F90", Offset = "0x14D2F90", VA = "0x14D2F90")]
		internal static void Remove(WWWRequest request)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x14D3048", Offset = "0x14D3048", VA = "0x14D3048")]
		internal void RemoveRequest(WWWRequest request)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x14D3170", Offset = "0x14D3170", VA = "0x14D3170")]
		public WWWClient()
		{
		}
	}
}
namespace InfinityCode.uPano.Json
{
	[Token(Token = "0x2000039")]
	public class JSON
	{
		[Token(Token = "0x2000092")]
		private enum Token
		{
			[Token(Token = "0x4000244")]
			None = -1,
			[Token(Token = "0x4000245")]
			Curly_Open,
			[Token(Token = "0x4000246")]
			Curly_Close,
			[Token(Token = "0x4000247")]
			Squared_Open,
			[Token(Token = "0x4000248")]
			Squared_Close,
			[Token(Token = "0x4000249")]
			Colon,
			[Token(Token = "0x400024A")]
			Comma,
			[Token(Token = "0x400024B")]
			String,
			[Token(Token = "0x400024C")]
			Number,
			[Token(Token = "0x400024D")]
			True,
			[Token(Token = "0x400024E")]
			False,
			[Token(Token = "0x400024F")]
			Null
		}

		[Token(Token = "0x2000093")]
		public class AliasAttribute : Attribute
		{
			[Token(Token = "0x4000250")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly string[] aliases;

			[Token(Token = "0x4000251")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public readonly bool ignoreFieldName;

			[Token(Token = "0x600038D")]
			[Address(RVA = "0x14CECD8", Offset = "0x14CECD8", VA = "0x14CECD8")]
			public AliasAttribute(bool ignoreFieldName, params string[] aliases)
			{
			}

			[Token(Token = "0x600038E")]
			[Address(RVA = "0x14CED88", Offset = "0x14CED88", VA = "0x14CED88")]
			public AliasAttribute(params string[] aliases)
			{
			}
		}

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string json;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int index;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Token lookAheadToken;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private StringBuilder s;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int length;

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x14CB99C", Offset = "0x14CB99C", VA = "0x14CB99C")]
		protected JSON(string json)
		{
		}

		[Token(Token = "0x60001B9")]
		public static T Deserialize<T>(string json)
		{
			return (T)null;
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x14CBA30", Offset = "0x14CBA30", VA = "0x14CBA30")]
		private static object DeserializeValue(Type type, object obj)
		{
			return null;
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x14CBBB0", Offset = "0x14CBBB0", VA = "0x14CBBB0")]
		private static object DeserializeArray(Type type, List<object> list)
		{
			return null;
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x14CC030", Offset = "0x14CC030", VA = "0x14CC030")]
		private static object DeserializeObject(Type type, Dictionary<string, object> table)
		{
			return null;
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x14CC524", Offset = "0x14CC524", VA = "0x14CC524")]
		private static void DeserializeValue(MemberTypes memberType, MemberInfo member, object item, object v)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x14CC844", Offset = "0x14CC844", VA = "0x14CC844")]
		private Token LookAhead()
		{
			return default(Token);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x14CCCF8", Offset = "0x14CCCF8", VA = "0x14CCCF8")]
		private Token NextToken()
		{
			return default(Token);
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x14CC878", Offset = "0x14CC878", VA = "0x14CC878")]
		private Token NextTokenCore()
		{
			return default(Token);
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x14CCD30", Offset = "0x14CCD30", VA = "0x14CCD30")]
		public static JSONItem Parse(string json)
		{
			return null;
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x14CCFE8", Offset = "0x14CCFE8", VA = "0x14CCFE8")]
		public static object ParseDirect(string json)
		{
			return null;
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x14CD1D0", Offset = "0x14CD1D0", VA = "0x14CD1D0")]
		private JSONArray ParseArray()
		{
			return null;
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x14CD374", Offset = "0x14CD374", VA = "0x14CD374")]
		private List<object> ParseArrayDirect()
		{
			return null;
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x14CD454", Offset = "0x14CD454", VA = "0x14CD454")]
		private object ParseNumber()
		{
			return null;
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x14CD6F4", Offset = "0x14CD6F4", VA = "0x14CD6F4")]
		private JSONObject ParseObject()
		{
			return null;
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x14CDCCC", Offset = "0x14CDCCC", VA = "0x14CDCCC")]
		private Dictionary<string, object> ParseObjectDirect()
		{
			return null;
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x14CDE60", Offset = "0x14CDE60", VA = "0x14CDE60")]
		private uint ParseSingleChar(char c1, uint multipliyer)
		{
			return default(uint);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x14CD8E4", Offset = "0x14CD8E4", VA = "0x14CD8E4")]
		private string ParseString()
		{
			return null;
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x14CDEB8", Offset = "0x14CDEB8", VA = "0x14CDEB8")]
		private uint ParseUnicode(char c1, char c2, char c3, char c4)
		{
			return default(uint);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x14CCD98", Offset = "0x14CCD98", VA = "0x14CCD98")]
		private JSONItem ParseValue()
		{
			return null;
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x14CD050", Offset = "0x14CD050", VA = "0x14CD050")]
		private object ParseValueDirect()
		{
			return null;
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x14CE064", Offset = "0x14CE064", VA = "0x14CE064")]
		public static JSONItem Serialize(object obj)
		{
			return null;
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xA69E54", Offset = "0xA69E54")]
	public class JSONArray : JSONItem
	{
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<JSONItem> array;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _count;

		[Token(Token = "0x1700006D")]
		public int count
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x14CED94", Offset = "0x14CED94", VA = "0x14CED94")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700006E")]
		public override JSONItem Item
		{
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x14CED9C", Offset = "0x14CED9C", VA = "0x14CED9C", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		public override JSONItem Item
		{
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x14CEE2C", Offset = "0x14CEE2C", VA = "0x14CEE2C", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x14CD288", Offset = "0x14CD288", VA = "0x14CD288")]
		public JSONArray()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x14CD2FC", Offset = "0x14CD2FC", VA = "0x14CD2FC")]
		public void Add(JSONItem item)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x14CEF2C", Offset = "0x14CEF2C", VA = "0x14CEF2C")]
		public void AddRange(JSONArray collection)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x14CEFAC", Offset = "0x14CEFAC", VA = "0x14CEFAC")]
		public void AddRange(JSONItem collection)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x14CF03C", Offset = "0x14CF03C", VA = "0x14CF03C", Slot = "9")]
		public override object Deserialize(Type type)
		{
			return null;
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x14CEE30", Offset = "0x14CEE30", VA = "0x14CEE30")]
		private JSONItem Get(string key)
		{
			return null;
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x14CF758", Offset = "0x14CF758", VA = "0x14CF758")]
		private JSONItem GetThis(string key)
		{
			return null;
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x14CF988", Offset = "0x14CF988", VA = "0x14CF988", Slot = "10")]
		public override JSONItem GetAll(string k)
		{
			return null;
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x14CFAE0", Offset = "0x14CFAE0", VA = "0x14CFAE0", Slot = "12")]
		public override IEnumerator<JSONItem> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x14CFB6C", Offset = "0x14CFB6C", VA = "0x14CFB6C")]
		public static JSONArray ParseArray(string json)
		{
			return null;
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x14CFBF4", Offset = "0x14CFBF4", VA = "0x14CFBF4", Slot = "11")]
		public override void ToJSON(StringBuilder b)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x14CFCF4", Offset = "0x14CFCF4", VA = "0x14CFCF4", Slot = "13")]
		public override object Value(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xA69E8C", Offset = "0xA69E8C")]
	public abstract class JSONItem : IEnumerable<JSONItem>, IEnumerable
	{
		[Token(Token = "0x17000070")]
		public abstract JSONItem Item
		{
			[Token(Token = "0x60001DD")]
			get;
		}

		[Token(Token = "0x17000071")]
		public JSONItem Item
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x14CFD38", Offset = "0x14CFD38", VA = "0x14CFD38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		public JSONItem Item
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x14CFD7C", Offset = "0x14CFD7C", VA = "0x14CFD7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		public JSONItem Item
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x14CFDDC", Offset = "0x14CFDDC", VA = "0x14CFDDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		public JSONItem Item
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x14CFE60", Offset = "0x14CFE60", VA = "0x14CFE60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		public JSONItem Item
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x14CFEFC", Offset = "0x14CFEFC", VA = "0x14CFEFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		public JSONItem Item
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x14CFFBC", Offset = "0x14CFFBC", VA = "0x14CFFBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		public abstract JSONItem Item
		{
			[Token(Token = "0x60001E4")]
			get;
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x14D0094", Offset = "0x14D0094", VA = "0x14D0094", Slot = "8")]
		public virtual JSONItem AppendObject(object obj)
		{
			return null;
		}

		[Token(Token = "0x60001E6")]
		public T ChildValue<T>(string childName)
		{
			return (T)null;
		}

		[Token(Token = "0x60001E7")]
		public T Deserialize<T>()
		{
			return (T)null;
		}

		[Token(Token = "0x60001E8")]
		public abstract object Deserialize(Type type);

		[Token(Token = "0x60001E9")]
		public abstract JSONItem GetAll(string key);

		[Token(Token = "0x60001EA")]
		public abstract void ToJSON(StringBuilder b);

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x14D0100", Offset = "0x14D0100", VA = "0x14D0100", Slot = "5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x14D010C", Offset = "0x14D010C", VA = "0x14D010C", Slot = "12")]
		public virtual IEnumerator<JSONItem> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x14D0114", Offset = "0x14D0114", VA = "0x14D0114", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001EE")]
		public abstract object Value(Type type);

		[Token(Token = "0x60001EF")]
		public virtual T Value<T>()
		{
			return (T)null;
		}

		[Token(Token = "0x60001F0")]
		public T V<T>()
		{
			return (T)null;
		}

		[Token(Token = "0x60001F1")]
		public T V<T>(string childName)
		{
			return (T)null;
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x14CEF24", Offset = "0x14CEF24", VA = "0x14CEF24")]
		protected JSONItem()
		{
		}
	}
	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xA69EC4", Offset = "0xA69EC4")]
	public class JSONObject : JSONItem
	{
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, JSONItem> _table;

		[Token(Token = "0x17000078")]
		public Dictionary<string, JSONItem> table
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x14D0198", Offset = "0x14D0198", VA = "0x14D0198")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		public override JSONItem Item
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x14D01A0", Offset = "0x14D01A0", VA = "0x14D01A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		public override JSONItem Item
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x14D02C8", Offset = "0x14D02C8", VA = "0x14D02C8", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x14CD870", Offset = "0x14CD870", VA = "0x14CD870")]
		public JSONObject()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x14CDC5C", Offset = "0x14CDC5C", VA = "0x14CDC5C")]
		public void Add(string name, JSONItem value)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x14D03DC", Offset = "0x14D03DC", VA = "0x14D03DC")]
		public void Add(string name, object value)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x14D05F4", Offset = "0x14D05F4", VA = "0x14D05F4")]
		public void Add(string name, object value, JSONValue.ValueType valueType)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x14D0698", Offset = "0x14D0698", VA = "0x14D0698", Slot = "8")]
		public override JSONItem AppendObject(object obj)
		{
			return null;
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x14D06D0", Offset = "0x14D06D0", VA = "0x14D06D0")]
		public void Combine(JSONItem other, bool overwriteExistingValues = false)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x14D08A8", Offset = "0x14D08A8", VA = "0x14D08A8", Slot = "9")]
		public override object Deserialize(Type type)
		{
			return null;
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x14CF70C", Offset = "0x14CF70C", VA = "0x14CF70C")]
		public object Deserialize(Type type, IEnumerable<MemberInfo> members)
		{
			return null;
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x14D110C", Offset = "0x14D110C", VA = "0x14D110C")]
		public void DeserializeObject(object obj, BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Public)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x14D0908", Offset = "0x14D0908", VA = "0x14D0908")]
		public void DeserializeObject(object obj, IEnumerable<MemberInfo> members)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x14D01A4", Offset = "0x14D01A4", VA = "0x14D01A4")]
		private JSONItem Get(string key)
		{
			return null;
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x14D1164", Offset = "0x14D1164", VA = "0x14D1164")]
		private JSONItem GetThis(string key)
		{
			return null;
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x14D12C0", Offset = "0x14D12C0", VA = "0x14D12C0", Slot = "10")]
		public override JSONItem GetAll(string k)
		{
			return null;
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x14D1438", Offset = "0x14D1438", VA = "0x14D1438", Slot = "12")]
		public override IEnumerator<JSONItem> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x14D14D8", Offset = "0x14D14D8", VA = "0x14D14D8")]
		public static JSONObject ParseObject(string json)
		{
			return null;
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x14D1560", Offset = "0x14D1560", VA = "0x14D1560", Slot = "11")]
		public override void ToJSON(StringBuilder b)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x14D178C", Offset = "0x14D178C", VA = "0x14D178C", Slot = "13")]
		public override object Value(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xA69EFC", Offset = "0xA69EFC")]
	public class JSONValue : JSONItem
	{
		[Token(Token = "0x2000094")]
		public enum ValueType
		{
			[Token(Token = "0x4000253")]
			DOUBLE,
			[Token(Token = "0x4000254")]
			LONG,
			[Token(Token = "0x4000255")]
			STRING,
			[Token(Token = "0x4000256")]
			BOOLEAN,
			[Token(Token = "0x4000257")]
			NULL
		}

		[Token(Token = "0x2000095")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6A93C", Offset = "0xA6A93C")]
		private sealed class <GetEnumerator>d__17 : IEnumerator<JSONItem>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000258")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000259")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONItem <>2__current;

			[Token(Token = "0x400025A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public JSONValue <>4__this;

			[Token(Token = "0x170000B1")]
			private JSONItem System.Collections.Generic.IEnumerator<InfinityCode.uPano.Json.JSONItem>.Current
			{
				[Token(Token = "0x6000392")]
				[Address(RVA = "0x14D2AE4", Offset = "0x14D2AE4", VA = "0x14D2AE4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000394")]
				[Address(RVA = "0x14D2B4C", Offset = "0x14D2B4C", VA = "0x14D2B4C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600038F")]
			[Address(RVA = "0x14D1DF4", Offset = "0x14D1DF4", VA = "0x14D1DF4")]
			[DebuggerHidden]
			public <GetEnumerator>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000390")]
			[Address(RVA = "0x14D2AA8", Offset = "0x14D2AA8", VA = "0x14D2AA8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000391")]
			[Address(RVA = "0x14D2AAC", Offset = "0x14D2AAC", VA = "0x14D2AAC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000393")]
			[Address(RVA = "0x14D2AEC", Offset = "0x14D2AEC", VA = "0x14D2AEC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ValueType _type;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _value;

		[Token(Token = "0x1700007B")]
		public override JSONItem Item
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x14D17E0", Offset = "0x14D17E0", VA = "0x14D17E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		public override JSONItem Item
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x14D17E8", Offset = "0x14D17E8", VA = "0x14D17E8", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		public object value
		{
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x14D17F0", Offset = "0x14D17F0", VA = "0x14D17F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x14D17F8", Offset = "0x14D17F8", VA = "0x14D17F8")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public ValueType type
		{
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x14D1A54", Offset = "0x14D1A54", VA = "0x14D1A54")]
			get
			{
				return default(ValueType);
			}
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x14CECA8", Offset = "0x14CECA8", VA = "0x14CECA8")]
		public JSONValue(object value)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x14CE028", Offset = "0x14CE028", VA = "0x14CE028")]
		public JSONValue(object value, ValueType type)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x14D1A5C", Offset = "0x14D1A5C", VA = "0x14D1A5C", Slot = "9")]
		public override object Deserialize(Type type)
		{
			return null;
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x14D1A6C", Offset = "0x14D1A6C", VA = "0x14D1A6C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x14D1D64", Offset = "0x14D1D64", VA = "0x14D1D64", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x14D1D7C", Offset = "0x14D1D7C", VA = "0x14D1D7C", Slot = "10")]
		public override JSONItem GetAll(string key)
		{
			return null;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x14D1D84", Offset = "0x14D1D84", VA = "0x14D1D84", Slot = "12")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA6B028", Offset = "0xA6B028")]
		public override IEnumerator<JSONItem> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x14D1E20", Offset = "0x14D1E20", VA = "0x14D1E20", Slot = "11")]
		public override void ToJSON(StringBuilder b)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x14D21BC", Offset = "0x14D21BC", VA = "0x14D21BC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x14D2280", Offset = "0x14D2280", VA = "0x14D2280", Slot = "13")]
		public override object Value(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x14D1F88", Offset = "0x14D1F88", VA = "0x14D1F88")]
		private void WriteString(StringBuilder b)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x14D2A8C", Offset = "0x14D2A8C", VA = "0x14D2A8C")]
		public static implicit operator string(JSONValue val)
		{
			return null;
		}
	}
}
namespace InfinityCode.uPano.InteractiveElements
{
	[Token(Token = "0x200003E")]
	public interface IInteractiveElementList
	{
		[Token(Token = "0x1700007F")]
		int Count
		{
			[Token(Token = "0x6000218")]
			get;
		}

		[Token(Token = "0x6000219")]
		InteractiveElement GetItemAt(int index);
	}
	[Token(Token = "0x200003F")]
	internal interface IScalableElement
	{
		[Token(Token = "0x17000080")]
		Vector3 scale
		{
			[Token(Token = "0x600021A")]
			get;
			[Token(Token = "0x600021B")]
			set;
		}
	}
	[Serializable]
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xA69F34", Offset = "0xA69F34")]
	public abstract class InteractiveElement
	{
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		public InteractiveElementEvent OnClick;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public InteractiveElementEvent OnPointerDown;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public InteractiveElementEvent OnPointerUp;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		public InteractiveElementEvent OnPointerEnter;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public InteractiveElementEvent OnPointerExit;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool ignoreGlobalActions;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xA6ACA4", Offset = "0xA6ACA4")]
		public GameObject loadPanoramaPrefab;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject switchToPanorama;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool copyPanTilt;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject beforeTransitionPrefab;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public GameObject afterTransitionPrefab;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected bool _expanded;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		[SerializeField]
		protected bool _expandedEvents;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		[SerializeField]
		protected bool _expandedQuickActions;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected GameObject _prefab;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		protected string _title;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		protected bool _visible;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Dictionary<string, object> _runtimeFields;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Pano _pano;

		[Token(Token = "0x17000081")]
		public abstract GameObject prefab
		{
			[Token(Token = "0x600021C")]
			get;
			[Token(Token = "0x600021D")]
			set;
		}

		[Token(Token = "0x17000082")]
		public Pano pano
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x14CB910", Offset = "0x14CB910", VA = "0x14CB910")]
			get
			{
				return null;
			}
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x14CB918", Offset = "0x14CB918", VA = "0x14CB918")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public object Item
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x14C8468", Offset = "0x14C8468", VA = "0x14C8468")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x14C8A58", Offset = "0x14C8A58", VA = "0x14C8A58")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public virtual string title
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x14CB920", Offset = "0x14CB920", VA = "0x14CB920", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x14CB928", Offset = "0x14CB928", VA = "0x14CB928", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public virtual bool visible
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x14CB930", Offset = "0x14CB930", VA = "0x14CB930", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x14CB938", Offset = "0x14CB938", VA = "0x14CB938", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x14CA0A0", Offset = "0x14CA0A0", VA = "0x14CA0A0", Slot = "10")]
		public virtual void Destroy()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x14CA38C", Offset = "0x14CA38C", VA = "0x14CA38C", Slot = "11")]
		protected virtual void InitQuickActions(GameObject target)
		{
		}

		[Token(Token = "0x6000228")]
		public abstract void GetPanTilt(out float pan, out float tilt);

		[Token(Token = "0x6000229")]
		public T GetRuntimeField<T>(string key)
		{
			return (T)null;
		}

		[Token(Token = "0x600022A")]
		public abstract void Reinit();

		[Token(Token = "0x600022B")]
		public abstract void SetPanTilt(float pan, float tilt);

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x14C62D8", Offset = "0x14C62D8", VA = "0x14C62D8")]
		protected InteractiveElement()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000041")]
	public class InteractiveElementEvent : UnityEvent<InteractiveElement>
	{
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x14CB944", Offset = "0x14CB944", VA = "0x14CB944")]
		public InteractiveElementEvent()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public abstract class InteractiveElementGlobalActions : Plugin
	{
		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		public InteractiveElementEvent OnClick;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public InteractiveElementEvent OnPointerDown;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		public InteractiveElementEvent OnPointerUp;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		public InteractiveElementEvent OnPointerEnter;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		public InteractiveElementEvent OnPointerExit;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected bool hasOwner;

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x14C6B2C", Offset = "0x14C6B2C", VA = "0x14C6B2C")]
		protected InteractiveElementGlobalActions()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public abstract class InteractiveElementInstance : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
	{
		[Token(Token = "0x600022F")]
		public abstract void OnPointerClick(PointerEventData eventData);

		[Token(Token = "0x6000230")]
		public abstract void OnPointerDown(PointerEventData eventData);

		[Token(Token = "0x6000231")]
		public abstract void OnPointerUp(PointerEventData eventData);

		[Token(Token = "0x6000232")]
		public abstract void OnPointerEnter(PointerEventData eventData);

		[Token(Token = "0x6000233")]
		public abstract void OnPointerExit(PointerEventData eventData);

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x14CB994", Offset = "0x14CB994", VA = "0x14CB994")]
		protected InteractiveElementInstance()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public abstract class InteractiveElementInstance<T> : InteractiveElementInstance where T : InteractiveElement
	{
		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T element;

		[Token(Token = "0x17000086")]
		public virtual InteractiveElementGlobalActions globalActions
		{
			[Token(Token = "0x6000235")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000236")]
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000237")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000238")]
		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000239")]
		public override void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600023A")]
		public override void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600023B")]
		protected InteractiveElementInstance()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xA69F6C", Offset = "0xA69F6C")]
	public abstract class InteractiveElementList<T> : Plugin, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IInteractiveElementList where T : InteractiveElement
	{
		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected List<T> _items;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected GameObject _defaultPrefab;

		[Token(Token = "0x17000087")]
		public List<T> items
		{
			[Token(Token = "0x600023C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000088")]
		public T Item
		{
			[Token(Token = "0x600023D")]
			get
			{
				return null;
			}
			[Token(Token = "0x600023E")]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public int Count
		{
			[Token(Token = "0x600023F")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700008A")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000240")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008B")]
		public GameObject defaultPrefab
		{
			[Token(Token = "0x6000241")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000242")]
			set
			{
			}
		}

		[Token(Token = "0x6000243")]
		public virtual void Add(T item)
		{
		}

		[Token(Token = "0x6000244")]
		public virtual void Clear()
		{
		}

		[Token(Token = "0x6000245")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000246")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000247")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000248")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000249")]
		public InteractiveElement GetItemAt(int index)
		{
			return null;
		}

		[Token(Token = "0x600024A")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Token(Token = "0x600024B")]
		public virtual void Insert(int index, T item)
		{
		}

		[Token(Token = "0x600024C")]
		public virtual bool Remove(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x600024D")]
		public virtual void RemoveAt(int index)
		{
		}

		[Token(Token = "0x600024E")]
		public abstract int RemoveAll(Predicate<T> match);

		[Token(Token = "0x600024F")]
		protected InteractiveElementList()
		{
		}
	}
}
namespace InfinityCode.uPano.HotSpots
{
	[Serializable]
	[Token(Token = "0x2000046")]
	public class HotSpot : InteractiveElement, IScalableElement
	{
		[Token(Token = "0x2000096")]
		public enum TooltipAction
		{
			[Token(Token = "0x400025C")]
			UICanvas,
			[Token(Token = "0x400025D")]
			textMesh,
			[Token(Token = "0x400025E")]
			multiCamera
		}

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string tooltip;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public TooltipAction tooltipAction;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public GameObject tooltipPrefab;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private bool _lookToCenter;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private float _pan;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float _tilt;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private Vector3 _scale;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Quaternion _rotation;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private float _distanceMultiplier;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private HotSpotInstance _instance;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private HotSpotManager _manager;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private PanoRenderer previewRenderer;

		[Token(Token = "0x1700008C")]
		public float distanceMultiplier
		{
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x14C9310", Offset = "0x14C9310", VA = "0x14C9310")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x14C9318", Offset = "0x14C9318", VA = "0x14C9318")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public bool lookToCenter
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x14C94C4", Offset = "0x14C94C4", VA = "0x14C94C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x14C94CC", Offset = "0x14C94CC", VA = "0x14C94CC")]
			set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public float pan
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x14C94D8", Offset = "0x14C94D8", VA = "0x14C94D8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x14C94E0", Offset = "0x14C94E0", VA = "0x14C94E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public float tilt
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x14C94E8", Offset = "0x14C94E8", VA = "0x14C94E8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x14C94F0", Offset = "0x14C94F0", VA = "0x14C94F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public Vector3 scale
		{
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x14C94F8", Offset = "0x14C94F8", VA = "0x14C94F8", Slot = "15")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x14C9504", Offset = "0x14C9504", VA = "0x14C9504", Slot = "16")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public Quaternion rotation
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x14C95DC", Offset = "0x14C95DC", VA = "0x14C95DC")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x14BEB1C", Offset = "0x14BEB1C", VA = "0x14BEB1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public override GameObject prefab
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x14C95E8", Offset = "0x14C95E8", VA = "0x14C95E8", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x14C96C4", Offset = "0x14C96C4", VA = "0x14C96C4", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public override string title
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x14C99F0", Offset = "0x14C99F0", VA = "0x14C99F0", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x14C99F8", Offset = "0x14C99F8", VA = "0x14C99F8", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public override bool visible
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x14C9AA4", Offset = "0x14C9AA4", VA = "0x14C9AA4", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x14C9AAC", Offset = "0x14C9AAC", VA = "0x14C9AAC", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public HotSpotInstance instance
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x14C9B68", Offset = "0x14C9B68", VA = "0x14C9B68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		public HotSpotManager manager
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x14C9B70", Offset = "0x14C9B70", VA = "0x14C9B70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		public Vector3 screenPosition
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x14BFB74", Offset = "0x14BFB74", VA = "0x14BFB74")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000098")]
		public Vector3 worldPosition
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x14C9B78", Offset = "0x14C9B78", VA = "0x14C9B78")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x14C9BAC", Offset = "0x14C9BAC", VA = "0x14C9BAC")]
		internal HotSpot(float pan, float tilt, GameObject prefab, HotSpotManager manager)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x14C980C", Offset = "0x14C980C", VA = "0x14C980C")]
		internal void CreateInstance(HotSpotManager manager, Transform parent)
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x14C9CF8", Offset = "0x14C9CF8", VA = "0x14C9CF8")]
		internal void CreatePreview(PanoRenderer panoRenderer, Transform parent)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x14CA05C", Offset = "0x14CA05C", VA = "0x14CA05C", Slot = "10")]
		public override void Destroy()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x14CA0A8", Offset = "0x14CA0A8", VA = "0x14CA0A8")]
		internal void DestroyInstance()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x14CA16C", Offset = "0x14CA16C", VA = "0x14CA16C", Slot = "12")]
		public override void GetPanTilt(out float pan, out float tilt)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x14C08E0", Offset = "0x14C08E0", VA = "0x14C08E0")]
		public Vector2 GetScreenPosition([Optional] Camera camera)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x14CA180", Offset = "0x14CA180", VA = "0x14CA180", Slot = "11")]
		protected override void InitQuickActions(GameObject target)
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x14CA6F4", Offset = "0x14CA6F4", VA = "0x14CA6F4")]
		private void InstantiatePrefab(Transform parent)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x14CA8E4", Offset = "0x14CA8E4", VA = "0x14CA8E4", Slot = "13")]
		public override void Reinit()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x14CAA20", Offset = "0x14CAA20", VA = "0x14CAA20", Slot = "14")]
		public override void SetPanTilt(float pan, float tilt)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x14C9320", Offset = "0x14C9320", VA = "0x14C9320")]
		public void UpdatePosition()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x14C9EA4", Offset = "0x14C9EA4", VA = "0x14C9EA4")]
		public void UpdatePreviewPosition()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x14CAA58", Offset = "0x14CAA58", VA = "0x14CAA58")]
		private void UpdateRotation()
		{
		}
	}
	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA69FA4", Offset = "0xA69FA4")]
	public class HotSpotGlobalActions : InteractiveElementGlobalActions
	{
		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static HotSpotGlobalActions _instance;

		[Token(Token = "0x17000099")]
		public static HotSpotGlobalActions instance
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x14CABF0", Offset = "0x14CABF0", VA = "0x14CABF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x14CAC40", Offset = "0x14CAC40", VA = "0x14CAC40", Slot = "4")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x14CACA8", Offset = "0x14CACA8", VA = "0x14CACA8", Slot = "7")]
		protected override void OnEnableLate()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x14CAD70", Offset = "0x14CAD70", VA = "0x14CAD70")]
		public HotSpotGlobalActions()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA69FDC", Offset = "0xA69FDC")]
	public class HotSpotInstance : InteractiveElementInstance<HotSpot>
	{
		[Token(Token = "0x1700009A")]
		public override InteractiveElementGlobalActions globalActions
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x14CAD74", Offset = "0x14CAD74", VA = "0x14CAD74", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x14CADE0", Offset = "0x14CADE0", VA = "0x14CADE0")]
		public HotSpotInstance()
		{
		}
	}
	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "WizardEnabledAttribute", RVA = "0xA6A014", Offset = "0xA6A014")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A014", Offset = "0xA6A014")]
	public class HotSpotManager : InteractiveElementList<HotSpot>
	{
		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform _container;

		[NonSerialized]
		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool isPreview;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal HotSpotGlobalActions globalActions;

		[Token(Token = "0x1700009B")]
		public Transform container
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x14CAE30", Offset = "0x14CAE30", VA = "0x14CAE30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x14CAE38", Offset = "0x14CAE38", VA = "0x14CAE38", Slot = "25")]
		public override void Add(HotSpot item)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x14CAED4", Offset = "0x14CAED4", VA = "0x14CAED4", Slot = "26")]
		public override void Clear()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x14C89B8", Offset = "0x14C89B8", VA = "0x14C89B8")]
		public HotSpot Create(float pan, float tilt, GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x14CB000", Offset = "0x14CB000", VA = "0x14CB000", Slot = "27")]
		public override void Insert(int index, HotSpot item)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x14CB0A4", Offset = "0x14CB0A4", VA = "0x14CB0A4", Slot = "7")]
		protected override void OnEnableLate()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x14CB1C4", Offset = "0x14CB1C4", VA = "0x14CB1C4", Slot = "28")]
		public override bool Remove(HotSpot item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x14CB25C", Offset = "0x14CB25C", VA = "0x14CB25C", Slot = "29")]
		public override void RemoveAt(int index)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x14CB340", Offset = "0x14CB340", VA = "0x14CB340", Slot = "30")]
		public override int RemoveAll(Predicate<HotSpot> match)
		{
			return default(int);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x14CB49C", Offset = "0x14CB49C", VA = "0x14CB49C", Slot = "8")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x14CB60C", Offset = "0x14CB60C", VA = "0x14CB60C")]
		public void StartPreview(PanoRenderer panoRenderer)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x14CB7D4", Offset = "0x14CB7D4", VA = "0x14CB7D4")]
		public void StopPreview()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x14CB8C0", Offset = "0x14CB8C0", VA = "0x14CB8C0")]
		public HotSpotManager()
		{
		}
	}
}
namespace InfinityCode.uPano.Enums
{
	[Token(Token = "0x200004A")]
	public enum CubeSide
	{
		[Token(Token = "0x4000142")]
		up,
		[Token(Token = "0x4000143")]
		front,
		[Token(Token = "0x4000144")]
		left,
		[Token(Token = "0x4000145")]
		back,
		[Token(Token = "0x4000146")]
		right,
		[Token(Token = "0x4000147")]
		down
	}
	[Token(Token = "0x200004B")]
	public enum TourPreset
	{
		[Token(Token = "0x4000149")]
		standard,
		[Token(Token = "0x400014A")]
		googleVR
	}
}
namespace InfinityCode.uPano.Directions
{
	[Serializable]
	[Token(Token = "0x200004C")]
	public class Direction : InteractiveElement, IScalableElement
	{
		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _pan;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private Vector3 _scale;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private DirectionManager _manager;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private DirectionInstance _instance;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public string PanoId;

		[Token(Token = "0x1700009C")]
		public DirectionInstance instance
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x14C5E84", Offset = "0x14C5E84", VA = "0x14C5E84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		public DirectionManager manager
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x14C5E8C", Offset = "0x14C5E8C", VA = "0x14C5E8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009E")]
		public float pan
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x14C5E94", Offset = "0x14C5E94", VA = "0x14C5E94")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x14C5E9C", Offset = "0x14C5E9C", VA = "0x14C5E9C")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public override GameObject prefab
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x14C60CC", Offset = "0x14C60CC", VA = "0x14C60CC", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x14C60D4", Offset = "0x14C60D4", VA = "0x14C60D4", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public Vector3 scale
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x14C60E8", Offset = "0x14C60E8", VA = "0x14C60E8", Slot = "15")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x14C60F4", Offset = "0x14C60F4", VA = "0x14C60F4", Slot = "16")]
			set
			{
			}
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x14C61CC", Offset = "0x14C61CC", VA = "0x14C61CC")]
		public Direction(float pan, GameObject prefab, DirectionManager manager)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x14C63A4", Offset = "0x14C63A4", VA = "0x14C63A4")]
		internal void CreateInstance(DirectionManager manager, Transform parent)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x14C6664", Offset = "0x14C6664", VA = "0x14C6664")]
		internal void DestroyInstance()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x14C6728", Offset = "0x14C6728", VA = "0x14C6728", Slot = "12")]
		public override void GetPanTilt(out float pan, out float tilt)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x14C6488", Offset = "0x14C6488", VA = "0x14C6488")]
		private void InstantiatePrefab(Transform parent)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x14C6738", Offset = "0x14C6738", VA = "0x14C6738", Slot = "13")]
		public override void Reinit()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x14C6874", Offset = "0x14C6874", VA = "0x14C6874", Slot = "14")]
		public override void SetPanTilt(float pan, float tilt)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x14C5EA4", Offset = "0x14C5EA4", VA = "0x14C5EA4")]
		public void UpdatePosition()
		{
		}
	}
	[Token(Token = "0x200004D")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A064", Offset = "0xA6A064")]
	public class DirectionGlobalActions : InteractiveElementGlobalActions
	{
		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DirectionGlobalActions _instance;

		[Token(Token = "0x170000A1")]
		public static DirectionGlobalActions instance
		{
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x14C69A8", Offset = "0x14C69A8", VA = "0x14C69A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x14C69F8", Offset = "0x14C69F8", VA = "0x14C69F8", Slot = "4")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x14C6A60", Offset = "0x14C6A60", VA = "0x14C6A60", Slot = "7")]
		protected override void OnEnableLate()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x14C6B28", Offset = "0x14C6B28", VA = "0x14C6B28")]
		public DirectionGlobalActions()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A09C", Offset = "0xA6A09C")]
	public class DirectionInstance : InteractiveElementInstance<Direction>
	{
		[Token(Token = "0x170000A2")]
		public override InteractiveElementGlobalActions globalActions
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x14C6BE8", Offset = "0x14C6BE8", VA = "0x14C6BE8", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x14C6C54", Offset = "0x14C6C54", VA = "0x14C6C54")]
		public DirectionInstance()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A0D4", Offset = "0xA6A0D4")]
	public class DirectionManager : InteractiveElementList<Direction>
	{
		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _externalRadius;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _internalRadius;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _verticalOffset;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform _container;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal DirectionGlobalActions globalActions;

		[Token(Token = "0x170000A3")]
		public float externalRadius
		{
			[Token(Token = "0x600029D")]
			[Address(RVA = "0x14C6CA4", Offset = "0x14C6CA4", VA = "0x14C6CA4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x14C6CAC", Offset = "0x14C6CAC", VA = "0x14C6CAC")]
			set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public float internalRadius
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x14C6F24", Offset = "0x14C6F24", VA = "0x14C6F24")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x14C6F2C", Offset = "0x14C6F2C", VA = "0x14C6F2C")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public float verticalOffset
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x14C6F34", Offset = "0x14C6F34", VA = "0x14C6F34")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x14C6F3C", Offset = "0x14C6F3C", VA = "0x14C6F3C")]
			set
			{
			}
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x14C6F44", Offset = "0x14C6F44", VA = "0x14C6F44", Slot = "25")]
		public override void Add(Direction item)
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x14C6FE8", Offset = "0x14C6FE8", VA = "0x14C6FE8")]
		public Direction Create(float pan, GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x14C7080", Offset = "0x14C7080", VA = "0x14C7080", Slot = "26")]
		public override void Clear()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x14C71AC", Offset = "0x14C71AC", VA = "0x14C71AC", Slot = "7")]
		protected override void OnEnableLate()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x14C73BC", Offset = "0x14C73BC", VA = "0x14C73BC")]
		private void OnPanoChanged(float f)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x14C73C0", Offset = "0x14C73C0", VA = "0x14C73C0", Slot = "8")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x14C7534", Offset = "0x14C7534", VA = "0x14C7534", Slot = "28")]
		public override bool Remove(Direction item)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x14C75CC", Offset = "0x14C75CC", VA = "0x14C75CC", Slot = "29")]
		public override void RemoveAt(int index)
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x14C76B0", Offset = "0x14C76B0", VA = "0x14C76B0", Slot = "30")]
		public override int RemoveAll(Predicate<Direction> match)
		{
			return default(int);
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x14C6CB4", Offset = "0x14C6CB4", VA = "0x14C6CB4")]
		public void UpdatePosition()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x14C780C", Offset = "0x14C780C", VA = "0x14C780C")]
		public DirectionManager()
		{
		}
	}
}
namespace InfinityCode.uPano.Controls
{
	[Serializable]
	[Token(Token = "0x2000050")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A10C", Offset = "0xA6A10C")]
	public class CompassControl : PanoControl
	{
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<float> OnChanged;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Compass compass;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private double timestamp;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float lastHeading;

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x14C3164", Offset = "0x14C3164", VA = "0x14C3164", Slot = "8")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x14C32F8", Offset = "0x14C32F8", VA = "0x14C32F8")]
		private void Update()
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x14C355C", Offset = "0x14C355C", VA = "0x14C355C")]
		public CompassControl()
		{
		}
	}
	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A144", Offset = "0xA6A144")]
	public class GyroControl : PanoControl
	{
		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Gyroscope gyro;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 rotationRate;

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x14C356C", Offset = "0x14C356C", VA = "0x14C356C", Slot = "8")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x14C35C0", Offset = "0x14C35C0", VA = "0x14C35C0")]
		private void Update()
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x14C38AC", Offset = "0x14C38AC", VA = "0x14C38AC")]
		public GyroControl()
		{
		}
	}
	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "WizardCreateMethodAttribute", RVA = "0xA6A17C", Offset = "0xA6A17C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A17C", Offset = "0xA6A17C")]
	public class JoystickControl : UIControl
	{
		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Pano panoInstance;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Image center;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float panSpeed;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float tiltSpeed;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool isDrag;

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x14C38B4", Offset = "0x14C38B4", VA = "0x14C38B4", Slot = "6")]
		protected override void GetPanoInstance()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x14C38C0", Offset = "0x14C38C0", VA = "0x14C38C0")]
		public void OnCenterPress()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x14C38CC", Offset = "0x14C38CC", VA = "0x14C38CC")]
		public void OnCenterRelease()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x14C3960", Offset = "0x14C3960", VA = "0x14C3960")]
		private void Update()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x14C3CF0", Offset = "0x14C3CF0", VA = "0x14C3CF0")]
		public JoystickControl()
		{
		}
	}
	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "WizardEnabledAttribute", RVA = "0xA6A1DC", Offset = "0xA6A1DC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A1DC", Offset = "0xA6A1DC")]
	public class KeyboardControl : SensitivityControl
	{
		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private EventSystem eventSystem;

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x14C3D0C", Offset = "0x14C3D0C", VA = "0x14C3D0C")]
		public KeyboardControl()
		{
		}
	}
	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "WizardEnabledAttribute", RVA = "0xA6A22C", Offset = "0xA6A22C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A22C", Offset = "0xA6A22C")]
	public class MouseControl : SensitivityControl
	{
		[Token(Token = "0x2000097")]
		public enum Mode
		{
			[Token(Token = "0x4000260")]
			Free,
			[Token(Token = "0x4000261")]
			LeftMouseButtonDown,
			[Token(Token = "0x4000262")]
			Drag
		}

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Mode mode;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool notInteractUnderUI;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		public bool wheelZoom;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
		public bool pinchToZoom;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x47")]
		public bool inertia;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float inertiaLerpSpeed;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float lastPan;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float lastTilt;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool isPressed;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		private bool pinchToZoomStarted;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float lastTouchDistance;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int lastTouchCount;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector2 inertiaSpeed;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector2 avgInertiaSpeed;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector2 lastInputPosition;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector2 inputPosition;

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x14C3D3C", Offset = "0x14C3D3C", VA = "0x14C3D3C")]
		private void ApplyInertia(ref float pan, ref float tilt)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x14C3D40", Offset = "0x14C3D40", VA = "0x14C3D40")]
		private void CalculateInertiaSpeed()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x14C3D44", Offset = "0x14C3D44", VA = "0x14C3D44")]
		private void Drag(ref bool changed)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x14C3D48", Offset = "0x14C3D48", VA = "0x14C3D48")]
		private void PinchToZoom()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x14C3D4C", Offset = "0x14C3D4C", VA = "0x14C3D4C")]
		private bool TryStartDrag(float pan, float tilt)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x14C3D54", Offset = "0x14C3D54", VA = "0x14C3D54")]
		private void UpdateFov(ref bool changed)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x14C3D58", Offset = "0x14C3D58", VA = "0x14C3D58")]
		private void WheelZoom()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x14C3D5C", Offset = "0x14C3D5C", VA = "0x14C3D5C")]
		public MouseControl()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public abstract class PanoControl : Plugin
	{
		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<PanoControl> OnControlStarted;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<PanoControl> OnInput;

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x14C3D94", Offset = "0x14C3D94", VA = "0x14C3D94", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x14C3E70", Offset = "0x14C3E70", VA = "0x14C3E70", Slot = "9")]
		protected virtual void OnPanoEnabled(Pano pano)
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x14C31E0", Offset = "0x14C31E0", VA = "0x14C31E0", Slot = "8")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x14C3564", Offset = "0x14C3564", VA = "0x14C3564")]
		protected PanoControl()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public abstract class SensitivityControl : PanoControl
	{
		[Token(Token = "0x2000098")]
		public enum Axes
		{
			[Token(Token = "0x4000264")]
			PanTilt,
			[Token(Token = "0x4000265")]
			Pan,
			[Token(Token = "0x4000266")]
			Tilt
		}

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Axes axes;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float sensitivityPan;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float sensitivityTilt;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float sensitivityFov;

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x14C3D24", Offset = "0x14C3D24", VA = "0x14C3D24")]
		protected SensitivityControl()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "WizardCreateMethodAttribute", RVA = "0xA6A27C", Offset = "0xA6A27C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A27C", Offset = "0xA6A27C")]
	public class UIButtonsControl : UIControl
	{
		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Pano panoInstance;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject autoRotateButton;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float panSpeed;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float tiltSpeed;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float fovSpeed;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float widthWithAutoRotate;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float widthWithoutAutoRotate;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool isLeft;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		private bool isRight;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		private bool isUp;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
		private bool isDown;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool isZoomIn;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool isZoomOut;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private AutoRotate autoRotate;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool restoreByTimer;

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x14C3E78", Offset = "0x14C3E78", VA = "0x14C3E78", Slot = "6")]
		protected override void GetPanoInstance()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x14C3E84", Offset = "0x14C3E84", VA = "0x14C3E84")]
		private void InitAutoRotate()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x14C4064", Offset = "0x14C4064", VA = "0x14C4064")]
		public void OnAutoRotateClick()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x14C4120", Offset = "0x14C4120", VA = "0x14C4120")]
		public void OnDownPressed()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x14C412C", Offset = "0x14C412C", VA = "0x14C412C")]
		public void OnDownReleased()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x14C4134", Offset = "0x14C4134", VA = "0x14C4134")]
		public void OnLeftPressed()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x14C4140", Offset = "0x14C4140", VA = "0x14C4140")]
		public void OnLeftReleased()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x14C4148", Offset = "0x14C4148", VA = "0x14C4148")]
		public void OnRightPressed()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x14C4154", Offset = "0x14C4154", VA = "0x14C4154")]
		public void OnRightReleased()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x14C415C", Offset = "0x14C415C", VA = "0x14C415C")]
		public void OnUpPressed()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x14C4168", Offset = "0x14C4168", VA = "0x14C4168")]
		public void OnUpReleased()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x14C4170", Offset = "0x14C4170", VA = "0x14C4170", Slot = "9")]
		protected override void OnPanoEnabled(Pano pano)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x14C4178", Offset = "0x14C4178", VA = "0x14C4178")]
		public void OnZoomInPressed()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x14C4184", Offset = "0x14C4184", VA = "0x14C4184")]
		public void OnZoomInReleased()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x14C418C", Offset = "0x14C418C", VA = "0x14C418C")]
		public void OnZoomOutPressed()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x14C4198", Offset = "0x14C4198", VA = "0x14C4198")]
		public void OnZoomOutReleased()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x14C41A0", Offset = "0x14C41A0", VA = "0x14C41A0", Slot = "8")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x14C429C", Offset = "0x14C429C", VA = "0x14C429C")]
		private void Update()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x14C44AC", Offset = "0x14C44AC", VA = "0x14C44AC")]
		public UIButtonsControl()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "WizardCreateMethodAttribute", RVA = "0xA6A2DC", Offset = "0xA6A2DC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A2DC", Offset = "0xA6A2DC")]
	public class UICompassControl : UIControl
	{
		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Pano panoInstance;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Image arrow;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool animated;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float duration;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float startPan;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float targetPan;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isAnim;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float progress;

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x14C44C8", Offset = "0x14C44C8", VA = "0x14C44C8", Slot = "6")]
		protected override void GetPanoInstance()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x14C44D4", Offset = "0x14C44D4", VA = "0x14C44D4", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x14C4674", Offset = "0x14C4674", VA = "0x14C4674")]
		private void OnPanChanged(float f)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x14C4724", Offset = "0x14C4724", VA = "0x14C4724", Slot = "10")]
		protected override void OnPanoDestroy(Pano pano)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x14C48F8", Offset = "0x14C48F8", VA = "0x14C48F8", Slot = "9")]
		protected override void OnPanoEnabled(Pano pano)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x14C4A6C", Offset = "0x14C4A6C", VA = "0x14C4A6C")]
		public void RotateLeft()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x14C4BDC", Offset = "0x14C4BDC", VA = "0x14C4BDC")]
		public void RotateRight()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x14C4C20", Offset = "0x14C4C20", VA = "0x14C4C20")]
		public void SetNorth()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x14C4B14", Offset = "0x14C4B14", VA = "0x14C4B14")]
		private void SetPan(float pan)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x14C4C60", Offset = "0x14C4C60", VA = "0x14C4C60", Slot = "8")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x14C4D40", Offset = "0x14C4D40", VA = "0x14C4D40")]
		private void Update()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x14C4E44", Offset = "0x14C4E44", VA = "0x14C4E44")]
		public UICompassControl()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public abstract class UIControl : PanoControl
	{
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool destroyWithPanorama;

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x14C459C", Offset = "0x14C459C", VA = "0x14C459C", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x14C4828", Offset = "0x14C4828", VA = "0x14C4828", Slot = "10")]
		protected virtual void OnPanoDestroy(Pano pano)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x14C41C4", Offset = "0x14C41C4", VA = "0x14C41C4", Slot = "8")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x14C3D04", Offset = "0x14C3D04", VA = "0x14C3D04")]
		protected UIControl()
		{
		}
	}
}
namespace InfinityCode.uPano.Attributes
{
	[Token(Token = "0x200005A")]
	public class RequirePanoRendererAttribute : Attribute
	{
		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Type type;

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x14C3000", Offset = "0x14C3000", VA = "0x14C3000")]
		public RequirePanoRendererAttribute(Type type)
		{
		}
	}
	[Token(Token = "0x200005B")]
	public class WizardCreateMethodAttribute : Attribute
	{
		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string methodName;

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x14C302C", Offset = "0x14C302C", VA = "0x14C302C")]
		public WizardCreateMethodAttribute(string methodName)
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class WizardEnabledAttribute : Attribute
	{
		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool enabled;

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x14C3058", Offset = "0x14C3058", VA = "0x14C3058")]
		public WizardEnabledAttribute(bool enabled)
		{
		}
	}
}
namespace InfinityCode.uPano.Actions
{
	[Token(Token = "0x200005D")]
	public abstract class AnimatedAction<T, U> : InteractiveElementAction where T : AnimatedAction<T, U>
	{
		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool animated;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AnimationCurve curve;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float delay;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float duration;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static AnimatedAction<T, U> activeAnimation;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected bool started;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected float time;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected InteractiveElement element;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected U initialValue;

		[Token(Token = "0x170000A6")]
		public float totalDuration
		{
			[Token(Token = "0x60002ED")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60002EE")]
		public override void Invoke(InteractiveElement element)
		{
		}

		[Token(Token = "0x60002EF")]
		protected abstract void SetAnimatedValue(float f);

		[Token(Token = "0x60002F0")]
		protected abstract void SetFixedValue();

		[Token(Token = "0x60002F1")]
		protected virtual void StopPreviousAnimation()
		{
		}

		[Token(Token = "0x60002F2")]
		protected abstract void StoreInitialValue();

		[Token(Token = "0x60002F3")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60002F4")]
		protected AnimatedAction()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class CopyPanTilt : TransitionAction
	{
		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Pano source;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Pano target;

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x14BE3CC", Offset = "0x14BE3CC", VA = "0x14BE3CC", Slot = "6")]
		protected override void InvokeAction(InteractiveElement element)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x14BE594", Offset = "0x14BE594", VA = "0x14BE594")]
		public CopyPanTilt()
		{
		}
	}
	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A33C", Offset = "0xA6A33C")]
	public class DestroyCurrentPanorama : TransitionAction
	{
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x14BE5A4", Offset = "0x14BE5A4", VA = "0x14BE5A4", Slot = "6")]
		protected override void InvokeAction(InteractiveElement element)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x14BE62C", Offset = "0x14BE62C", VA = "0x14BE62C")]
		public DestroyCurrentPanorama()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A374", Offset = "0xA6A374")]
	public class InstantiatePrefab : InteractiveElementAction
	{
		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject prefab;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform parent;

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x14C0C5C", Offset = "0x14C0C5C", VA = "0x14C0C5C", Slot = "4")]
		public override void Invoke(InteractiveElement element)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x14C0D1C", Offset = "0x14C0D1C", VA = "0x14C0D1C")]
		public InstantiatePrefab()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000061")]
	public abstract class InteractiveElementAction : MonoBehaviour
	{
		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<InteractiveElementAction> OnActionStarted;

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x14C0D24", Offset = "0x14C0D24", VA = "0x14C0D24")]
		public void Invoke()
		{
		}

		[Token(Token = "0x60002FC")]
		public abstract void Invoke(InteractiveElement element);

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x14C0D34", Offset = "0x14C0D34", VA = "0x14C0D34", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x14BE6FC", Offset = "0x14BE6FC", VA = "0x14BE6FC")]
		protected InteractiveElementAction()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A3AC", Offset = "0xA6A3AC")]
	public class LoadAnotherPanorama : TransitionAction
	{
		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject prefab;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool keepOrientation;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float pan;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float tilt;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fov;

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x14C0DA8", Offset = "0x14C0DA8", VA = "0x14C0DA8", Slot = "4")]
		public override void Invoke(InteractiveElement element)
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x14C1070", Offset = "0x14C1070", VA = "0x14C1070", Slot = "6")]
		protected override void InvokeAction(InteractiveElement element)
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x14C1074", Offset = "0x14C1074", VA = "0x14C1074")]
		private void LoadPano(InteractiveElement element)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x14C0E7C", Offset = "0x14C0E7C", VA = "0x14C0E7C")]
		private void SaveOrientation(InteractiveElement element)
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x14C12A0", Offset = "0x14C12A0", VA = "0x14C12A0")]
		public LoadAnotherPanorama()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A3E4", Offset = "0xA6A3E4")]
	public class LoadScene : TransitionAction
	{
		[Token(Token = "0x2000099")]
		public enum LoadType
		{
			[Token(Token = "0x4000268")]
			name,
			[Token(Token = "0x4000269")]
			index
		}

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LoadType loadType;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int sceneIndex;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string sceneName;

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x14C12B0", Offset = "0x14C12B0", VA = "0x14C12B0", Slot = "6")]
		protected override void InvokeAction(InteractiveElement element)
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x14C12B4", Offset = "0x14C12B4", VA = "0x14C12B4")]
		private void TryLoadScene()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x14C1364", Offset = "0x14C1364", VA = "0x14C1364")]
		public LoadScene()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A41C", Offset = "0xA6A41C")]
	public class OpenURL : InteractiveElementAction
	{
		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string url;

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x14C1374", Offset = "0x14C1374", VA = "0x14C1374", Slot = "4")]
		public override void Invoke(InteractiveElement element)
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x14C1380", Offset = "0x14C1380", VA = "0x14C1380")]
		public OpenURL()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A454", Offset = "0xA6A454")]
	public class PlaySound : InteractiveElementAction
	{
		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip audioClip;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource audioSource;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool oneShot;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool ignoreIfPlayed;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected AudioClip currentClip;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected AudioSource currentSource;

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x14C1388", Offset = "0x14C1388", VA = "0x14C1388", Slot = "4")]
		public override void Invoke(InteractiveElement element)
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x14C1594", Offset = "0x14C1594", VA = "0x14C1594")]
		public void PlaySolo(InteractiveElement element)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x14C16B4", Offset = "0x14C16B4", VA = "0x14C16B4")]
		public void Stop(InteractiveElement element)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x14C1748", Offset = "0x14C1748", VA = "0x14C1748")]
		public void StopAllSounds(InteractiveElement element)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x14C1804", Offset = "0x14C1804", VA = "0x14C1804")]
		public PlaySound()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A48C", Offset = "0xA6A48C")]
	public class SetCursor : InteractiveElementAction
	{
		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture2D texture;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2 offset;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CursorMode cursorMode;

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x14C1814", Offset = "0x14C1814", VA = "0x14C1814", Slot = "4")]
		public override void Invoke(InteractiveElement element)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x14C182C", Offset = "0x14C182C", VA = "0x14C182C")]
		public SetCursor()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A4C4", Offset = "0xA6A4C4")]
	public class SetFov : AnimatedAction<SetFov, float>
	{
		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Pano pano;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float fov;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Pano _pano;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float initialFov;

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x14C1834", Offset = "0x14C1834", VA = "0x14C1834", Slot = "6")]
		protected override void SetAnimatedValue(float f)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x14C1920", Offset = "0x14C1920", VA = "0x14C1920", Slot = "7")]
		protected override void SetFixedValue()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x14C19B4", Offset = "0x14C19B4", VA = "0x14C19B4", Slot = "9")]
		protected override void StoreInitialValue()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x14C1A5C", Offset = "0x14C1A5C", VA = "0x14C1A5C")]
		public SetFov()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A4FC", Offset = "0xA6A4FC")]
	public class SetGameObjectActive : TransitionAction
	{
		[Serializable]
		[Token(Token = "0x200009A")]
		public class Item
		{
			[Token(Token = "0x400026A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject target;

			[Token(Token = "0x400026B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool value;

			[Token(Token = "0x6000395")]
			[Address(RVA = "0x14C1B9C", Offset = "0x14C1B9C", VA = "0x14C1B9C")]
			public Item()
			{
			}
		}

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Item[] items;

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x14C1AAC", Offset = "0x14C1AAC", VA = "0x14C1AAC", Slot = "6")]
		protected override void InvokeAction(InteractiveElement element)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x14C1B94", Offset = "0x14C1B94", VA = "0x14C1B94")]
		public SetGameObjectActive()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A534", Offset = "0xA6A534")]
	public class SetPanTilt : AnimatedAction<SetPanTilt, float>
	{
		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Pano pano;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float pan;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float tilt;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Pano _pano;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float initialPan;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float initialTilt;

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x14C1BA4", Offset = "0x14C1BA4", VA = "0x14C1BA4", Slot = "6")]
		protected override void SetAnimatedValue(float f)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x14C1CBC", Offset = "0x14C1CBC", VA = "0x14C1CBC", Slot = "7")]
		protected override void SetFixedValue()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x14C1D68", Offset = "0x14C1D68", VA = "0x14C1D68", Slot = "9")]
		protected override void StoreInitialValue()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x14C1E20", Offset = "0x14C1E20", VA = "0x14C1E20")]
		public SetPanTilt()
		{
		}
	}
	[Token(Token = "0x200006A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A56C", Offset = "0xA6A56C")]
	public class SetScale : AnimatedAction<SetScale, Vector3>
	{
		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 scale;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IScalableElement scalableElement;

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x14C1E70", Offset = "0x14C1E70", VA = "0x14C1E70", Slot = "4")]
		public override void Invoke(InteractiveElement element)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x14C1EE8", Offset = "0x14C1EE8", VA = "0x14C1EE8", Slot = "7")]
		protected override void SetFixedValue()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x14C1FD0", Offset = "0x14C1FD0", VA = "0x14C1FD0", Slot = "6")]
		protected override void SetAnimatedValue(float f)
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x14C2128", Offset = "0x14C2128", VA = "0x14C2128", Slot = "9")]
		protected override void StoreInitialValue()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x14C21E0", Offset = "0x14C21E0", VA = "0x14C21E0")]
		public SetScale()
		{
		}
	}
	[Token(Token = "0x200006B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A5A4", Offset = "0xA6A5A4")]
	public class SetText : InteractiveElementAction
	{
		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text textfield;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string value;

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x14C2260", Offset = "0x14C2260", VA = "0x14C2260", Slot = "4")]
		public override void Invoke(InteractiveElement element)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x14C2300", Offset = "0x14C2300", VA = "0x14C2300")]
		public SetText()
		{
		}
	}
	[Token(Token = "0x200006C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A5DC", Offset = "0xA6A5DC")]
	public class SetTransformPosition : AnimatedAction<SetTransformPosition, Vector3>
	{
		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform target;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool fromIsOriginal;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 fromPosition;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool toIsDelta;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 toPosition;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool useLocalSpace;

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x14C2308", Offset = "0x14C2308", VA = "0x14C2308", Slot = "6")]
		protected override void SetAnimatedValue(float f)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x14C24A8", Offset = "0x14C24A8", VA = "0x14C24A8", Slot = "7")]
		protected override void SetFixedValue()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x14C25B0", Offset = "0x14C25B0", VA = "0x14C25B0", Slot = "9")]
		protected override void StoreInitialValue()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x14C2618", Offset = "0x14C2618", VA = "0x14C2618")]
		public SetTransformPosition()
		{
		}
	}
	[Token(Token = "0x200006D")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A614", Offset = "0xA6A614")]
	public class SetTransformRotation : AnimatedAction<SetTransformPosition, Vector3>
	{
		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform target;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool fromIsOriginal;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 fromRotation;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool toIsDelta;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 toRotation;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool useLocalSpace;

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x14C2674", Offset = "0x14C2674", VA = "0x14C2674", Slot = "6")]
		protected override void SetAnimatedValue(float f)
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x14C2864", Offset = "0x14C2864", VA = "0x14C2864", Slot = "7")]
		protected override void SetFixedValue()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x14C2988", Offset = "0x14C2988", VA = "0x14C2988", Slot = "9")]
		protected override void StoreInitialValue()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x14C2A10", Offset = "0x14C2A10", VA = "0x14C2A10")]
		public SetTransformRotation()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public abstract class TransitionAction : InteractiveElementAction
	{
		[Token(Token = "0x200009B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6A94C", Offset = "0xA6A94C")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400026C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InteractiveElement element;

			[Token(Token = "0x400026D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TransitionAction <>4__this;

			[Token(Token = "0x400026E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transition beforeTransition;

			[Token(Token = "0x6000396")]
			[Address(RVA = "0x14C2A6C", Offset = "0x14C2A6C", VA = "0x14C2A6C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000397")]
			[Address(RVA = "0x14C2C68", Offset = "0x14C2C68", VA = "0x14C2C68")]
			internal void <Invoke>b__0(Transition t)
			{
			}
		}

		[Token(Token = "0x200009C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6A95C", Offset = "0xA6A95C")]
		private sealed class <>c__DisplayClass2_1
		{
			[Token(Token = "0x400026F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transition afterTransition;

			[Token(Token = "0x6000398")]
			[Address(RVA = "0x14C2E40", Offset = "0x14C2E40", VA = "0x14C2E40")]
			public <>c__DisplayClass2_1()
			{
			}

			[Token(Token = "0x6000399")]
			[Address(RVA = "0x14C2F7C", Offset = "0x14C2F7C", VA = "0x14C2F7C")]
			internal void <Invoke>b__1(Transition t2)
			{
			}
		}

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject beforeTransitionPrefab;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject afterTransitionPrefab;

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x14C0EBC", Offset = "0x14C0EBC", VA = "0x14C0EBC", Slot = "4")]
		public override void Invoke(InteractiveElement element)
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x14C2A74", Offset = "0x14C2A74", VA = "0x14C2A74")]
		protected Transition GetTransition(GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x600032B")]
		protected abstract void InvokeAction(InteractiveElement element);

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x14BE59C", Offset = "0x14BE59C", VA = "0x14BE59C")]
		protected TransitionAction()
		{
		}
	}
}
namespace InfinityCode.uPano.Actions.HotSpots
{
	[Token(Token = "0x200006F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A64C", Offset = "0xA6A64C")]
	public class DestroyCurrentHotSpot : HotSpotAction
	{
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x14BE634", Offset = "0x14BE634", VA = "0x14BE634", Slot = "6")]
		public override void Invoke(HotSpot hotSpot)
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x14BE654", Offset = "0x14BE654", VA = "0x14BE654")]
		public DestroyCurrentHotSpot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000070")]
	public abstract class HotSpotAction : InteractiveElementAction
	{
		[Token(Token = "0x600032F")]
		public abstract void Invoke(HotSpot hotSpot);

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x14BE664", Offset = "0x14BE664", VA = "0x14BE664", Slot = "4")]
		public override void Invoke(InteractiveElement element)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x14BE65C", Offset = "0x14BE65C", VA = "0x14BE65C")]
		protected HotSpotAction()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public abstract class HotSpotAnimatedAction<T, U> : AnimatedAction<T, U> where T : HotSpotAnimatedAction<T, U>
	{
		[Token(Token = "0x170000A7")]
		protected HotSpot hotSpot
		{
			[Token(Token = "0x6000332")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000333")]
		protected HotSpotAnimatedAction()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000072")]
	public abstract class HotSpotTooltipAction : HotSpotAction
	{
		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject tooltipPrefab;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string text;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static HotSpot owner;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static GameObject instance;

		[Token(Token = "0x6000334")]
		public abstract void Hide(InteractiveElement element);

		[Token(Token = "0x6000335")]
		public abstract void Show(InteractiveElement element);

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x14BE704", Offset = "0x14BE704", VA = "0x14BE704")]
		protected HotSpotTooltipAction()
		{
		}
	}
	[Token(Token = "0x2000073")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A684", Offset = "0xA6A684")]
	public class SetHotSpotColor : HotSpotAnimatedAction<SetHotSpotColor, Color>
	{
		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Color color;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Renderer _renderer;

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x14BE70C", Offset = "0x14BE70C", VA = "0x14BE70C", Slot = "6")]
		protected override void SetAnimatedValue(float f)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x14BE804", Offset = "0x14BE804", VA = "0x14BE804", Slot = "7")]
		protected override void SetFixedValue()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x14BE8C8", Offset = "0x14BE8C8", VA = "0x14BE8C8", Slot = "9")]
		protected override void StoreInitialValue()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x14BE9B8", Offset = "0x14BE9B8", VA = "0x14BE9B8")]
		public SetHotSpotColor()
		{
		}
	}
	[Token(Token = "0x2000074")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A6BC", Offset = "0xA6A6BC")]
	public class SetHotSpotRotation : HotSpotAnimatedAction<SetHotSpotRotation, Quaternion>
	{
		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 rotation;

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x14BEA18", Offset = "0x14BEA18", VA = "0x14BEA18", Slot = "6")]
		protected override void SetAnimatedValue(float f)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x14BEBD4", Offset = "0x14BEBD4", VA = "0x14BEBD4", Slot = "7")]
		protected override void SetFixedValue()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x14BEC88", Offset = "0x14BEC88", VA = "0x14BEC88", Slot = "9")]
		protected override void StoreInitialValue()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x14BECEC", Offset = "0x14BECEC", VA = "0x14BECEC")]
		public SetHotSpotRotation()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A6F4", Offset = "0xA6A6F4")]
	public class ShowTextMeshTooltip : HotSpotTooltipAction
	{
		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float tiltOffset;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool getTextFromElement;

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x14BED6C", Offset = "0x14BED6C", VA = "0x14BED6C", Slot = "7")]
		public override void Hide(InteractiveElement element)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x14BEE4C", Offset = "0x14BEE4C", VA = "0x14BEE4C", Slot = "6")]
		public override void Invoke(HotSpot hotSpot)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x14BF098", Offset = "0x14BF098", VA = "0x14BF098", Slot = "8")]
		public override void Show(InteractiveElement element)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x14BEE50", Offset = "0x14BEE50", VA = "0x14BEE50")]
		public void Show(HotSpot hotSpot)
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x14BF128", Offset = "0x14BF128", VA = "0x14BF128")]
		private void Update()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x14BF328", Offset = "0x14BF328", VA = "0x14BF328")]
		public ShowTextMeshTooltip()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A72C", Offset = "0xA6A72C")]
	public class ShowTooltip : HotSpotTooltipAction
	{
		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float yOffset;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6AE5C", Offset = "0xA6AE5C")]
		public bool adjustSize;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool getTextFromElement;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Canvas canvas;

		[Token(Token = "0x170000A8")]
		private Camera worldCamera
		{
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x14BF338", Offset = "0x14BF338", VA = "0x14BF338")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x14BF3C0", Offset = "0x14BF3C0", VA = "0x14BF3C0", Slot = "7")]
		public override void Hide(InteractiveElement element)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x14BF4A0", Offset = "0x14BF4A0", VA = "0x14BF4A0", Slot = "6")]
		public override void Invoke(HotSpot hotSpot)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x14BF9B8", Offset = "0x14BF9B8", VA = "0x14BF9B8", Slot = "8")]
		public override void Show(InteractiveElement element)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x14BF4A4", Offset = "0x14BF4A4", VA = "0x14BF4A4")]
		public void Show(HotSpot hotSpot)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x14BFCD8", Offset = "0x14BFCD8", VA = "0x14BFCD8")]
		private void Update()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x14BFF58", Offset = "0x14BFF58", VA = "0x14BFF58")]
		public ShowTooltip()
		{
		}
	}
	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A764", Offset = "0xA6A764")]
	public class ShowTooltipMultiCamera : HotSpotTooltipAction
	{
		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MultiCamera multiCamera;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float yOffset;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6AE94", Offset = "0xA6AE94")]
		public bool adjustSize;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool hasInstances;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static GameObject[] instances;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Canvas canvas;

		[Token(Token = "0x170000A9")]
		private Camera worldCamera
		{
			[Token(Token = "0x600034C")]
			[Address(RVA = "0x14BFF70", Offset = "0x14BFF70", VA = "0x14BFF70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x14BFFC0", Offset = "0x14BFFC0", VA = "0x14BFFC0", Slot = "7")]
		public override void Hide(InteractiveElement hotSpot)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x14C0158", Offset = "0x14C0158", VA = "0x14C0158", Slot = "6")]
		public override void Invoke(HotSpot hotSpot)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x14C0850", Offset = "0x14C0850", VA = "0x14C0850", Slot = "8")]
		public override void Show(InteractiveElement element)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x14C015C", Offset = "0x14C015C", VA = "0x14C015C")]
		public void Show(HotSpot hotSpot)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x14C099C", Offset = "0x14C099C", VA = "0x14C099C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x14C0C40", Offset = "0x14C0C40", VA = "0x14C0C40")]
		public ShowTooltipMultiCamera()
		{
		}
	}
}
namespace InfinityCode.uPano.Examples
{
	[Token(Token = "0x2000078")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A79C", Offset = "0xA6A79C")]
	public class AnimatedFadeExample : MonoBehaviour
	{
		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SphericalPanoRenderer panoRenderer;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve curve;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float duration;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float progress;

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x14C7870", Offset = "0x14C7870", VA = "0x14C7870")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x14C7960", Offset = "0x14C7960", VA = "0x14C7960")]
		private void Start()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x14C79F0", Offset = "0x14C79F0", VA = "0x14C79F0")]
		public AnimatedFadeExample()
		{
		}
	}
	[Token(Token = "0x2000079")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A7D4", Offset = "0xA6A7D4")]
	public class DynamicCreationExample : MonoBehaviour
	{
		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture sphericalTexture;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Texture2D cylindricalTexture;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture2D horizontalCrossTexture;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture2D[] cubeFacesTextures;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Cubemap cubemap;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader shader;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CubeUV horizontalCrossUV;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float radius;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int sphericalSegments;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int icosahedronQuality;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float cylindricalHeight;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int cylindricalSides;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector3 cubeSize;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private PanoRenderer panoRenderer;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool hasPrevValues;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float pan;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float tilt;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float fov;

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x14C7A38", Offset = "0x14C7A38", VA = "0x14C7A38")]
		public void CreateSphericalPano()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x14C7D38", Offset = "0x14C7D38", VA = "0x14C7D38")]
		public void CreateIconsahedron()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x14C7D74", Offset = "0x14C7D74", VA = "0x14C7D74")]
		public void CreateCylindrical()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x14C7DB4", Offset = "0x14C7DB4", VA = "0x14C7DB4")]
		public void CreateHorizontalCross()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x14C7DF4", Offset = "0x14C7DF4", VA = "0x14C7DF4")]
		public void CreateCubeFaces()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x14C7E30", Offset = "0x14C7E30", VA = "0x14C7E30")]
		public void CreateCubemap()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x14C7A74", Offset = "0x14C7A74", VA = "0x14C7A74")]
		private void DestroyPrevPano()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x14C7B9C", Offset = "0x14C7B9C", VA = "0x14C7B9C")]
		private void InitPano()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x14C7E6C", Offset = "0x14C7E6C", VA = "0x14C7E6C")]
		public DynamicCreationExample()
		{
		}
	}
	[Token(Token = "0x200007A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A80C", Offset = "0xA6A80C")]
	public class InstantiateGameObjectsUnderCursorExample : MonoBehaviour
	{
		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject prefab;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text text;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PanoRenderer panoRenderer;

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x14C7F30", Offset = "0x14C7F30", VA = "0x14C7F30")]
		private void Start()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x14C7F88", Offset = "0x14C7F88", VA = "0x14C7F88")]
		private void Update()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x14C8240", Offset = "0x14C8240", VA = "0x14C8240")]
		public InstantiateGameObjectsUnderCursorExample()
		{
		}
	}
	[Token(Token = "0x200007B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6A844", Offset = "0xA6A844")]
	public class PositioningUIElementExample : MonoBehaviour
	{
		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject tooltipGameObject;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RectTransform tooltipBackground;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Text textfield;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject hotSpotPrefab;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Pano pano;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private HotSpot activeHotSpot;

		[Token(Token = "0x170000AA")]
		private Camera worldCamera
		{
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x14C8248", Offset = "0x14C8248", VA = "0x14C8248")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x14C82B0", Offset = "0x14C82B0", VA = "0x14C82B0")]
		private void OnPointerEnter(InteractiveElement hotSpot)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x14C8678", Offset = "0x14C8678", VA = "0x14C8678")]
		private void OnPointerExit(InteractiveElement hotSpot)
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x14C86A0", Offset = "0x14C86A0", VA = "0x14C86A0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x14C84DC", Offset = "0x14C84DC", VA = "0x14C84DC")]
		private void UpdateTooltipPosition(float value)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x14C8AF8", Offset = "0x14C8AF8", VA = "0x14C8AF8")]
		public PositioningUIElementExample()
		{
		}
	}
}
