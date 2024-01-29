using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BrainFailProductions.PolyFew.AsImpL;
using BrainFailProductions.PolyFewRuntime;
using Il2CppDummyDll;
using Microsoft.CodeAnalysis;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityMeshSimplifier;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Token(Token = "0x2000002")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64010C", Offset = "0x64010C")]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x15BF090", Offset = "0x15BF090", VA = "0x15BF090")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640144", Offset = "0x640144")]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsReadOnlyAttribute : Attribute
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x12CA0A8", Offset = "0x12CA0A8", VA = "0x12CA0A8")]
		public IsReadOnlyAttribute()
		{
		}
	}
}
[Token(Token = "0x2000004")]
public static class ConsoleProDebug
{
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x15BCA00", Offset = "0x15BCA00", VA = "0x15BCA00")]
	public static void Clear()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x15BCA04", Offset = "0x15BCA04", VA = "0x15BCA04")]
	public static void LogToFilter(string inLog, string inFilterName, [Optional] UnityEngine.Object inContext)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x15BCAC4", Offset = "0x15BCAC4", VA = "0x15BCAC4")]
	public static void LogAsType(string inLog, string inTypeName, [Optional] UnityEngine.Object inContext)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x15BCB84", Offset = "0x15BCB84", VA = "0x15BCB84")]
	public static void Watch(string inName, string inValue)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x15BCDD4", Offset = "0x15BCDD4", VA = "0x15BCDD4")]
	public static void Search(string inText)
	{
	}
}
[Token(Token = "0x2000005")]
public static class JsonUtilityArrays
{
	[Serializable]
	[Token(Token = "0x2000006")]
	private class Wrapper<T>
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T[] Items;

		[Token(Token = "0x600000B")]
		public Wrapper()
		{
		}
	}

	[Token(Token = "0x6000008")]
	public static T[] FromJson<T>(string json)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	public static string ToJson<T>(T[] array)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	public static string ToJson<T>(T[] array, bool prettyPrint)
	{
		return null;
	}
}
[Token(Token = "0x2000007")]
[ExecuteInEditMode]
public class Skeleton : MonoBehaviour
{
	[Token(Token = "0x2000008")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64018C", Offset = "0x64018C")]
	private sealed class <>c__DisplayClass6_0
	{
		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string bone;

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1682D20", Offset = "0x1682D20", VA = "0x1682D20")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1682D28", Offset = "0x1682D28", VA = "0x1682D28")]
		internal bool <EquipSkin>b__0(BoneDefintion d)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000009")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64019C", Offset = "0x64019C")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string e;

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1682D48", Offset = "0x1682D48", VA = "0x1682D48")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1682D50", Offset = "0x1682D50", VA = "0x1682D50")]
		internal bool <ReassignSkin>b__0(BoneDefintion d)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<BoneDefintion> rigDefinition;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform rootBone;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SkeletonSkin[] skins;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xE7EDAC", Offset = "0xE7EDAC", VA = "0xE7EDAC")]
	[AttributeAttribute(Name = "ButtonAttribute", RVA = "0x6488E8", Offset = "0x6488E8")]
	public void PrecacheRig()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xE7EF40", Offset = "0xE7EF40", VA = "0xE7EF40")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x648900", Offset = "0x648900")]
	public void PrecacheRigCM()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xE7EF44", Offset = "0xE7EF44", VA = "0xE7EF44")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x648938", Offset = "0x648938")]
	public void BindAllSkins()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xE7EFBC", Offset = "0xE7EFBC", VA = "0xE7EFBC")]
	public void EquipSkin(SkeletonSkin skin)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xE7F34C", Offset = "0xE7F34C", VA = "0xE7F34C")]
	public void ReassignSkin(SkeletonSkin equip, Skeleton skel)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xE7F710", Offset = "0xE7F710", VA = "0xE7F710")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x648970", Offset = "0x648970")]
	public void LogRigDef()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xE7F7E0", Offset = "0xE7F7E0", VA = "0xE7F7E0")]
	public Skeleton()
	{
	}
}
[Serializable]
[Token(Token = "0x200000A")]
public class BoneDefintion
{
	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int index;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string name;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform gameObject;

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x15BB9F8", Offset = "0x15BB9F8", VA = "0x15BB9F8")]
	public BoneDefintion()
	{
	}
}
[Token(Token = "0x200000B")]
public class SkeletonSkin : MonoBehaviour
{
	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<string> skeleton;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SkinnedMeshRenderer smr;

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xE7F864", Offset = "0xE7F864", VA = "0xE7F864")]
	[AttributeAttribute(Name = "ButtonAttribute", RVA = "0x6489A8", Offset = "0x6489A8")]
	public void PrecacheBones()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xE7F9C8", Offset = "0xE7F9C8", VA = "0xE7F9C8")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x6489C0", Offset = "0x6489C0")]
	public void PrecacheBonesCM()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xE7F9CC", Offset = "0xE7F9CC", VA = "0xE7F9CC")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x6489F8", Offset = "0x6489F8")]
	public void LogRigDef()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xE7FA9C", Offset = "0xE7FA9C", VA = "0xE7FA9C")]
	public SkeletonSkin()
	{
	}
}
namespace RootMotion
{
	[Token(Token = "0x200000C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6401AC", Offset = "0x6401AC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6401AC", Offset = "0x6401AC")]
	public abstract class Baker : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200000D")]
		public enum Mode
		{
			[Token(Token = "0x400001B")]
			AnimationClips,
			[Token(Token = "0x400001C")]
			AnimationStates,
			[Token(Token = "0x400001D")]
			PlayableDirector,
			[Token(Token = "0x400001E")]
			Realtime
		}

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64116C", Offset = "0x64116C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64116C", Offset = "0x64116C")]
		public int frameRate;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6411C4", Offset = "0x6411C4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6411C4", Offset = "0x6411C4")]
		public float keyReductionError;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64121C", Offset = "0x64121C")]
		public Mode mode;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641254", Offset = "0x641254")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64128C", Offset = "0x64128C")]
		public string[] animationStates;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6412C4", Offset = "0x6412C4")]
		public bool loop;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6412FC", Offset = "0x6412FC")]
		public string saveToFolder;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641334", Offset = "0x641334")]
		public string appendName;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64136C", Offset = "0x64136C")]
		public string saveName;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6413A4", Offset = "0x6413A4")]
		private bool <isBaking>k__BackingField;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6413B4", Offset = "0x6413B4")]
		private float <bakingProgress>k__BackingField;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[HideInInspector]
		public Animator animator;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[HideInInspector]
		public PlayableDirector director;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x641434", Offset = "0x641434")]
		private float <clipLength>k__BackingField;

		[Token(Token = "0x17000001")]
		public bool isBaking
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x15AFD10", Offset = "0x15AFD10", VA = "0x15AFD10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x648B10", Offset = "0x648B10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x15AFD18", Offset = "0x15AFD18", VA = "0x15AFD18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x648B20", Offset = "0x648B20")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x15AFD24", Offset = "0x15AFD24", VA = "0x15AFD24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x648B30", Offset = "0x648B30")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x15AFD2C", Offset = "0x15AFD2C", VA = "0x15AFD2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x648B40", Offset = "0x648B40")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x15AFD34", Offset = "0x15AFD34", VA = "0x15AFD34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x648B50", Offset = "0x648B50")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x15AFD3C", Offset = "0x15AFD3C", VA = "0x15AFD3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x648B60", Offset = "0x648B60")]
			private set
			{
			}
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x15AFBF0", Offset = "0x15AFBF0", VA = "0x15AFBF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x648A30", Offset = "0x648A30")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x15AFC38", Offset = "0x15AFC38", VA = "0x15AFC38")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x648A68", Offset = "0x648A68")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x15AFC80", Offset = "0x15AFC80", VA = "0x15AFC80")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x648AA0", Offset = "0x648AA0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x15AFCC8", Offset = "0x15AFCC8", VA = "0x15AFCC8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x648AD8", Offset = "0x648AD8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000024")]
		protected abstract Transform GetCharacterRoot();

		[Token(Token = "0x6000025")]
		protected abstract void OnStartBaking();

		[Token(Token = "0x6000026")]
		protected abstract void OnSetLoopFrame(float time);

		[Token(Token = "0x6000027")]
		protected abstract void OnSetCurves(ref AnimationClip clip);

		[Token(Token = "0x6000028")]
		protected abstract void OnSetKeyframes(float time, bool lastFrame);

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x15AFD44", Offset = "0x15AFD44", VA = "0x15AFD44")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x15AFD48", Offset = "0x15AFD48", VA = "0x15AFD48")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x15AFD4C", Offset = "0x15AFD4C", VA = "0x15AFD4C")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x15AFD50", Offset = "0x15AFD50", VA = "0x15AFD50")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641444", Offset = "0x641444")]
		public bool markAsLegacy;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64147C", Offset = "0x64147C")]
		public Transform root;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6414B4", Offset = "0x6414B4")]
		public Transform rootNode;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6414EC", Offset = "0x6414EC")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641524", Offset = "0x641524")]
		public Transform[] bakePositionList;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerTransform[] children;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerTransform rootChild;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int rootChildIndex;

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1690FE4", Offset = "0x1690FE4", VA = "0x1690FE4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x16913E8", Offset = "0x16913E8", VA = "0x16913E8", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x16913F0", Offset = "0x16913F0", VA = "0x16913F0", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1691500", Offset = "0x1691500", VA = "0x1691500", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x169157C", Offset = "0x169157C", VA = "0x169157C", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x16915F8", Offset = "0x16915F8", VA = "0x16915F8", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1691240", Offset = "0x1691240", VA = "0x1691240")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1691314", Offset = "0x1691314", VA = "0x1691314")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1691674", Offset = "0x1691674", VA = "0x1691674")]
		public GenericBaker()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class TQ
	{
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 t;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion q;

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xE82864", Offset = "0xE82864", VA = "0xE82864")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class AvatarUtility
	{
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x15AEFC4", Offset = "0x15AEFC4", VA = "0x15AEFC4")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x15AF22C", Offset = "0x15AF22C", VA = "0x15AF22C")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x15AF20C", Offset = "0x15AF20C", VA = "0x15AF20C")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x15AF7F0", Offset = "0x15AF7F0", VA = "0x15AF7F0")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public static class BakerUtilities
	{
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x15B1020", Offset = "0x15B1020", VA = "0x15B1020")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x15B2950", Offset = "0x15B2950", VA = "0x15B2950")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x15B0A74", Offset = "0x15B0A74", VA = "0x15B0A74")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x15B1068", Offset = "0x15B1068", VA = "0x15B1068")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x15B05A4", Offset = "0x15B05A4", VA = "0x15B05A4")]
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x2000012")]
	public class BakerHumanoidQT
	{
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform transform;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string Qx;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string Qy;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string Qz;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string Qw;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string Tx;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string Ty;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string Tz;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve rotX;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve rotY;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AnimationCurve rotW;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve posX;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AnimationCurve posY;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AnimationCurve posZ;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AvatarIKGoal goal;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion lastQ;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool lastQSet;

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x15AFE6C", Offset = "0x15AFE6C", VA = "0x15AFE6C")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x15B0180", Offset = "0x15B0180", VA = "0x15B0180")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x15B0024", Offset = "0x15B0024", VA = "0x15B0024")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x15B035C", Offset = "0x15B035C", VA = "0x15B035C")]
		public void SetIKKeyframes(float time, Avatar avatar, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x15B0808", Offset = "0x15B0808", VA = "0x15B0808")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x15B0904", Offset = "0x15B0904", VA = "0x15B0904")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x15B0A00", Offset = "0x15B0A00", VA = "0x15B0A00")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x15B0978", Offset = "0x15B0978", VA = "0x15B0978")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x15B0C6C", Offset = "0x15B0C6C", VA = "0x15B0C6C")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x15B0D20", Offset = "0x15B0D20", VA = "0x15B0D20")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000013")]
	public class BakerMuscle
	{
		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int muscleIndex;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string propertyName;

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x15B106C", Offset = "0x15B106C", VA = "0x15B106C")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x15B10E8", Offset = "0x15B10E8", VA = "0x15B10E8")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x15B1B84", Offset = "0x15B1B84", VA = "0x15B1B84")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x15B1C38", Offset = "0x15B1C38", VA = "0x15B1C38")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x15B1B20", Offset = "0x15B1B20", VA = "0x15B1B20")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x15B1D30", Offset = "0x15B1D30", VA = "0x15B1D30")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x15B1D78", Offset = "0x15B1D78", VA = "0x15B1D78")]
		public void SetLoopFrame(float time)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000014")]
	public class BakerTransform
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve posX;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve posY;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve posZ;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve rotX;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve rotY;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve rotW;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string relativePath;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool recordPosition;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 relativePosition;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isRootNode;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion relativeRotation;

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x15B1D80", Offset = "0x15B1D80", VA = "0x15B1D80")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x15B1F70", Offset = "0x15B1F70", VA = "0x15B1F70")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x15B1F84", Offset = "0x15B1F84", VA = "0x15B1F84")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x15B2270", Offset = "0x15B2270", VA = "0x15B2270")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x15B1E2C", Offset = "0x15B1E2C", VA = "0x15B1E2C")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x15B2524", Offset = "0x15B2524", VA = "0x15B2524")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x15B2598", Offset = "0x15B2598", VA = "0x15B2598")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x15B274C", Offset = "0x15B274C", VA = "0x15B274C")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64155C", Offset = "0x64155C")]
		public bool bakeHandIK;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x641594", Offset = "0x641594")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641594", Offset = "0x641594")]
		public float IKKeyReductionError;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6415EC", Offset = "0x6415EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6415EC", Offset = "0x6415EC")]
		public int muscleFrameRateDiv;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private BakerMuscle[] bakerMuscles;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private BakerHumanoidQT rootQT;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private BakerHumanoidQT leftFootQT;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerHumanoidQT rightFootQT;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerHumanoidQT leftHandQT;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private BakerHumanoidQT rightHandQT;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float[] muscles;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private HumanPose pose;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private HumanPoseHandler handler;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector3 bodyPosition;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion bodyRotation;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private int mN;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion lastBodyRotation;

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x169A4E8", Offset = "0x169A4E8", VA = "0x169A4E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x169AA7C", Offset = "0x169AA7C", VA = "0x169AA7C", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x169AA98", Offset = "0x169AA98", VA = "0x169AA98", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x169AB74", Offset = "0x169AB74", VA = "0x169AB74", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x169AC50", Offset = "0x169AC50", VA = "0x169AC50", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x169AE20", Offset = "0x169AE20", VA = "0x169AE20", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x169B0E8", Offset = "0x169B0E8", VA = "0x169B0E8")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x169B1C4", Offset = "0x169B1C4", VA = "0x169B1C4")]
		public HumanoidBaker()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000016")]
	public enum Axis
	{
		[Token(Token = "0x400005C")]
		X,
		[Token(Token = "0x400005D")]
		Y,
		[Token(Token = "0x400005E")]
		Z
	}
	[Token(Token = "0x2000017")]
	public class AxisTools
	{
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x15AF7F8", Offset = "0x15AF7F8", VA = "0x15AF7F8")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x15AF81C", Offset = "0x15AF81C", VA = "0x15AF81C")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x15AF854", Offset = "0x15AF854", VA = "0x15AF854")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x15AF944", Offset = "0x15AF944", VA = "0x15AF944")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x15AF8EC", Offset = "0x15AF8EC", VA = "0x15AF8EC")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x15AF9DC", Offset = "0x15AF9DC", VA = "0x15AF9DC")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x15AFA24", Offset = "0x15AFA24", VA = "0x15AFA24")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x15AFBE8", Offset = "0x15AFBE8", VA = "0x15AFBE8")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000018")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x2000019")]
		public class LimbOrientation
		{
			[Token(Token = "0x4000063")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x4000064")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x4000065")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x600006E")]
			[Address(RVA = "0xE8B4AC", Offset = "0xE8B4AC", VA = "0xE8B4AC")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000004")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x15B430C", Offset = "0x15B430C", VA = "0x15B430C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x15B457C", Offset = "0x15B457C", VA = "0x15B457C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x15B428C", Offset = "0x15B428C", VA = "0x15B428C")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x200001A")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x200001B")]
		public enum BoneType
		{
			[Token(Token = "0x4000079")]
			Unassigned,
			[Token(Token = "0x400007A")]
			Spine,
			[Token(Token = "0x400007B")]
			Head,
			[Token(Token = "0x400007C")]
			Arm,
			[Token(Token = "0x400007D")]
			Leg,
			[Token(Token = "0x400007E")]
			Tail,
			[Token(Token = "0x400007F")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x200001C")]
		public enum BoneSide
		{
			[Token(Token = "0x4000081")]
			Center,
			[Token(Token = "0x4000082")]
			Left,
			[Token(Token = "0x4000083")]
			Right
		}

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x15B47EC", Offset = "0x15B47EC", VA = "0x15B47EC")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x15B4B10", Offset = "0x15B4B10", VA = "0x15B4B10")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x15B4D84", Offset = "0x15B4D84", VA = "0x15B4D84")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x15B4E04", Offset = "0x15B4E04", VA = "0x15B4E04")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x15B4EAC", Offset = "0x15B4EAC", VA = "0x15B4EAC")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x15B49C4", Offset = "0x15B49C4", VA = "0x15B49C4")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x15B4CE8", Offset = "0x15B4CE8", VA = "0x15B4CE8")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x15B56DC", Offset = "0x15B56DC", VA = "0x15B56DC")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x15B54E4", Offset = "0x15B54E4", VA = "0x15B54E4")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x15B55E0", Offset = "0x15B55E0", VA = "0x15B55E0")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x15B50C4", Offset = "0x15B50C4", VA = "0x15B50C4")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x15B5174", Offset = "0x15B5174", VA = "0x15B5174")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x15B5224", Offset = "0x15B5224", VA = "0x15B5224")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x15B52D4", Offset = "0x15B52D4", VA = "0x15B52D4")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x15B5384", Offset = "0x15B5384", VA = "0x15B5384")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x15B5434", Offset = "0x15B5434", VA = "0x15B5434")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x15B58E4", Offset = "0x15B58E4", VA = "0x15B58E4")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x15B4FDC", Offset = "0x15B4FDC", VA = "0x15B4FDC")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x15B5854", Offset = "0x15B5854", VA = "0x15B5854")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x15B5950", Offset = "0x15B5950", VA = "0x15B5950")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x15B5A24", Offset = "0x15B5A24", VA = "0x15B5A24")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x15B57DC", Offset = "0x15B57DC", VA = "0x15B57DC")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x15B5768", Offset = "0x15B5768", VA = "0x15B5768")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200001D")]
	public class BipedReferences
	{
		[Token(Token = "0x200001E")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x4000095")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x4000096")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x17000008")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x60000A0")]
				[Address(RVA = "0xE8B538", Offset = "0xE8B538", VA = "0xE8B538")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x600009F")]
			[Address(RVA = "0xE8B524", Offset = "0xE8B524", VA = "0xE8B524")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x17000006")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x15B828C", Offset = "0x15B828C", VA = "0x15B828C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000007")]
		public bool isEmpty
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x15B8674", Offset = "0x15B8674", VA = "0x15B8674")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x15B8684", Offset = "0x15B8684", VA = "0x15B8684", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x15B8AAC", Offset = "0x15B8AAC", VA = "0x15B8AAC", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x15B8EE0", Offset = "0x15B8EE0", VA = "0x15B8EE0")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x15B95B0", Offset = "0x15B95B0", VA = "0x15B95B0")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x15B910C", Offset = "0x15B910C", VA = "0x15B910C")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x15B367C", Offset = "0x15B367C", VA = "0x15B367C")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x15B9E34", Offset = "0x15B9E34", VA = "0x15B9E34")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x15BA3F0", Offset = "0x15BA3F0", VA = "0x15BA3F0")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x15BA1D0", Offset = "0x15BA1D0", VA = "0x15BA1D0")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x15BA04C", Offset = "0x15BA04C", VA = "0x15BA04C")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x15B9ED4", Offset = "0x15B9ED4", VA = "0x15B9ED4")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x15BA2DC", Offset = "0x15BA2DC", VA = "0x15BA2DC")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x15BA4E8", Offset = "0x15BA4E8", VA = "0x15BA4E8")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x15BB0D0", Offset = "0x15BB0D0", VA = "0x15BB0D0")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x15BAB40", Offset = "0x15BAB40", VA = "0x15BAB40")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x15BB3CC", Offset = "0x15BB3CC", VA = "0x15BB3CC")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x15BAEB8", Offset = "0x15BAEB8", VA = "0x15BAEB8")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x15BB3D4", Offset = "0x15BB3D4", VA = "0x15BB3D4")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x15BB3DC", Offset = "0x15BB3DC", VA = "0x15BB3DC")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x15BB5B0", Offset = "0x15BB5B0", VA = "0x15BB5B0")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x15BB778", Offset = "0x15BB778", VA = "0x15BB778")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x15B3E00", Offset = "0x15B3E00", VA = "0x15B3E00")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x15BC9F8", Offset = "0x15BC9F8", VA = "0x15BC9F8")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x15BED9C", Offset = "0x15BED9C", VA = "0x15BED9C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x15BEEE4", Offset = "0x15BEEE4", VA = "0x15BEEE4")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class Hierarchy
	{
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1698EF8", Offset = "0x1698EF8", VA = "0x1698EF8")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x16990E4", Offset = "0x16990E4", VA = "0x16990E4")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1698F90", Offset = "0x1698F90", VA = "0x1698F90")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1699204", Offset = "0x1699204", VA = "0x1699204")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1699330", Offset = "0x1699330", VA = "0x1699330")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1699584", Offset = "0x1699584", VA = "0x1699584")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x169968C", Offset = "0x169968C", VA = "0x169968C")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1699800", Offset = "0x1699800", VA = "0x1699800")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1699BDC", Offset = "0x1699BDC", VA = "0x1699BDC")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x16999A0", Offset = "0x16999A0", VA = "0x16999A0")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1699D90", Offset = "0x1699D90", VA = "0x1699D90")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string color;

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x12C169C", Offset = "0x12C169C", VA = "0x12C169C")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x12C1728", Offset = "0x12C1728", VA = "0x12C1728")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000023")]
	public enum InterpolationMode
	{
		[Token(Token = "0x400009D")]
		None,
		[Token(Token = "0x400009E")]
		InOutCubic,
		[Token(Token = "0x400009F")]
		InOutQuintic,
		[Token(Token = "0x40000A0")]
		InOutSine,
		[Token(Token = "0x40000A1")]
		InQuintic,
		[Token(Token = "0x40000A2")]
		InQuartic,
		[Token(Token = "0x40000A3")]
		InCubic,
		[Token(Token = "0x40000A4")]
		InQuadratic,
		[Token(Token = "0x40000A5")]
		InElastic,
		[Token(Token = "0x40000A6")]
		InElasticSmall,
		[Token(Token = "0x40000A7")]
		InElasticBig,
		[Token(Token = "0x40000A8")]
		InSine,
		[Token(Token = "0x40000A9")]
		InBack,
		[Token(Token = "0x40000AA")]
		OutQuintic,
		[Token(Token = "0x40000AB")]
		OutQuartic,
		[Token(Token = "0x40000AC")]
		OutCubic,
		[Token(Token = "0x40000AD")]
		OutInCubic,
		[Token(Token = "0x40000AE")]
		OutInQuartic,
		[Token(Token = "0x40000AF")]
		OutElastic,
		[Token(Token = "0x40000B0")]
		OutElasticSmall,
		[Token(Token = "0x40000B1")]
		OutElasticBig,
		[Token(Token = "0x40000B2")]
		OutSine,
		[Token(Token = "0x40000B3")]
		OutBack,
		[Token(Token = "0x40000B4")]
		OutBackCubic,
		[Token(Token = "0x40000B5")]
		OutBackQuartic,
		[Token(Token = "0x40000B6")]
		BackInCubic,
		[Token(Token = "0x40000B7")]
		BackInQuartic
	}
	[Token(Token = "0x2000024")]
	public class Interp
	{
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x12C4404", Offset = "0x12C4404", VA = "0x12C4404")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x12C9ED8", Offset = "0x12C9ED8", VA = "0x12C9ED8")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x12C9F4C", Offset = "0x12C9F4C", VA = "0x12C9F4C")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x12C9940", Offset = "0x12C9940", VA = "0x12C9940")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x12C994C", Offset = "0x12C994C", VA = "0x12C994C")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x12C9970", Offset = "0x12C9970", VA = "0x12C9970")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x12C99AC", Offset = "0x12C99AC", VA = "0x12C99AC")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x12C99C4", Offset = "0x12C99C4", VA = "0x12C99C4")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x12C99D8", Offset = "0x12C99D8", VA = "0x12C99D8")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x12C99EC", Offset = "0x12C99EC", VA = "0x12C99EC")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x12C99FC", Offset = "0x12C99FC", VA = "0x12C99FC")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x12C9A44", Offset = "0x12C9A44", VA = "0x12C9A44")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x12C9A7C", Offset = "0x12C9A7C", VA = "0x12C9A7C")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x12C9AA4", Offset = "0x12C9AA4", VA = "0x12C9AA4")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x12C9FD8", Offset = "0x12C9FD8", VA = "0x12C9FD8")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x12C9AD8", Offset = "0x12C9AD8", VA = "0x12C9AD8")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x12C9B00", Offset = "0x12C9B00", VA = "0x12C9B00")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x12C9B30", Offset = "0x12C9B30", VA = "0x12C9B30")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x12C9B64", Offset = "0x12C9B64", VA = "0x12C9B64")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x12C9BA8", Offset = "0x12C9BA8", VA = "0x12C9BA8")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x12C9C0C", Offset = "0x12C9C0C", VA = "0x12C9C0C")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x12C9C70", Offset = "0x12C9C70", VA = "0x12C9C70")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x12C9CC4", Offset = "0x12C9CC4", VA = "0x12C9CC4")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x12C9D18", Offset = "0x12C9D18", VA = "0x12C9D18")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x12C9D54", Offset = "0x12C9D54", VA = "0x12C9D54")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x12C9D8C", Offset = "0x12C9D8C", VA = "0x12C9D8C")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x12CA00C", Offset = "0x12CA00C", VA = "0x12CA00C")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x12C9DD4", Offset = "0x12C9DD4", VA = "0x12C9DD4")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x12C9E68", Offset = "0x12C9E68", VA = "0x12C9E68")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x12C9E98", Offset = "0x12C9E98", VA = "0x12C9E98")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x12CA0A0", Offset = "0x12CA0A0", VA = "0x12CA0A0")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string color;

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x12CA0B0", Offset = "0x12CA0B0", VA = "0x12CA0B0")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x12CA13C", Offset = "0x12CA13C", VA = "0x12CA13C")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000026")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x12CA1CC", Offset = "0x12CA1CC", VA = "0x12CA1CC")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x12CA224", Offset = "0x12CA224", VA = "0x12CA224")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x12CA2F0", Offset = "0x12CA2F0", VA = "0x12CA2F0")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x12CA23C", Offset = "0x12CA23C", VA = "0x12CA23C")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x12CA308", Offset = "0x12CA308", VA = "0x12CA308")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x12CA3AC", Offset = "0x12CA3AC", VA = "0x12CA3AC")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x12CA3D8", Offset = "0x12CA3D8", VA = "0x12CA3D8")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x12CA428", Offset = "0x12CA428", VA = "0x12CA428")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x12CA494", Offset = "0x12CA494", VA = "0x12CA494")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x12CA5A8", Offset = "0x12CA5A8", VA = "0x12CA5A8")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x12CA6A0", Offset = "0x12CA6A0", VA = "0x12CA6A0")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x12CA6FC", Offset = "0x12CA6FC", VA = "0x12CA6FC")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000027")]
	public static class QuaTools
	{
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xE79510", Offset = "0xE79510", VA = "0xE79510")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xE79560", Offset = "0xE79560", VA = "0xE79560")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xE795B0", Offset = "0xE795B0", VA = "0xE795B0")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xE79658", Offset = "0xE79658", VA = "0xE79658")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xE79700", Offset = "0xE79700", VA = "0xE79700")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xE797E0", Offset = "0xE797E0", VA = "0xE797E0")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xE79834", Offset = "0xE79834", VA = "0xE79834")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xE79908", Offset = "0xE79908", VA = "0xE79908")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xE79A18", Offset = "0xE79A18", VA = "0xE79A18")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xE79BA8", Offset = "0xE79BA8", VA = "0xE79BA8")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xE79C9C", Offset = "0xE79C9C", VA = "0xE79C9C")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xE79DA8", Offset = "0xE79DA8", VA = "0xE79DA8")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xE79E94", Offset = "0xE79E94", VA = "0xE79E94")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000028")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000009")]
		public static T instance
		{
			[Token(Token = "0x60000EB")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000EC")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60000ED")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641650", Offset = "0x641650")]
		public bool fixTransforms;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700000A")]
		private bool animatePhysics
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0xE7FC60", Offset = "0xE7FC60", VA = "0xE7FC60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		private bool isAnimated
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0xE7FFAC", Offset = "0xE7FFAC", VA = "0xE7FFAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xE7FB20", Offset = "0xE7FB20", VA = "0xE7FB20")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xE7FBC0", Offset = "0xE7FBC0", VA = "0xE7FBC0", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xE7FBC4", Offset = "0xE7FBC4", VA = "0xE7FBC4", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xE7FBC8", Offset = "0xE7FBC8", VA = "0xE7FBC8", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xE7FBCC", Offset = "0xE7FBCC", VA = "0xE7FBCC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xE7FC5C", Offset = "0xE7FC5C", VA = "0xE7FC5C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xE7FC04", Offset = "0xE7FC04", VA = "0xE7FC04")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xE7FF60", Offset = "0xE7FF60", VA = "0xE7FF60")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xE7FD4C", Offset = "0xE7FD4C", VA = "0xE7FD4C")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xE80064", Offset = "0xE80064", VA = "0xE80064")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xE800C0", Offset = "0xE800C0", VA = "0xE800C0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xE8011C", Offset = "0xE8011C", VA = "0xE8011C")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xE79500", Offset = "0xE79500", VA = "0xE79500")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xE85334", Offset = "0xE85334", VA = "0xE85334")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xE853F4", Offset = "0xE853F4", VA = "0xE853F4")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xE854B4", Offset = "0xE854B4", VA = "0xE854B4")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xE85574", Offset = "0xE85574", VA = "0xE85574")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public static class V3Tools
	{
		[Token(Token = "0x6000102")]
		[Address(RVA = "0xE86CC8", Offset = "0xE86CC8", VA = "0xE86CC8")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xE86D68", Offset = "0xE86D68", VA = "0xE86D68")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xE86DA4", Offset = "0xE86DA4", VA = "0xE86DA4")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xE86DE8", Offset = "0xE86DE8", VA = "0xE86DE8")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xE86E84", Offset = "0xE86E84", VA = "0xE86E84")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xE86FE0", Offset = "0xE86FE0", VA = "0xE86FE0")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xE8715C", Offset = "0xE8715C", VA = "0xE8715C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xE872E0", Offset = "0xE872E0", VA = "0xE872E0")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xE8739C", Offset = "0xE8739C", VA = "0xE8739C")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xE8749C", Offset = "0xE8749C", VA = "0xE8749C")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xE87524", Offset = "0xE87524", VA = "0xE87524")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x200002C")]
	public static class Warning
	{
		[Token(Token = "0x200002D")]
		public delegate void Logger(string message);

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xE8ADCC", Offset = "0xE8ADCC", VA = "0xE8ADCC")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xE7C254", Offset = "0xE7C254", VA = "0xE7C254")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x64021C", Offset = "0x64021C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x64021C", Offset = "0x64021C")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x15B2D20", Offset = "0x15B2D20", VA = "0x15B2D20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x648BE0", Offset = "0x648BE0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x15B2D68", Offset = "0x15B2D68", VA = "0x15B2D68")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x648C18", Offset = "0x648C18")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x15B2DB0", Offset = "0x15B2DB0", VA = "0x15B2DB0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x648C50", Offset = "0x648C50")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x15B2DF8", Offset = "0x15B2DF8", VA = "0x15B2DF8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x648C88", Offset = "0x648C88")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x15B2E40", Offset = "0x15B2E40", VA = "0x15B2E40")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x15B2EDC", Offset = "0x15B2EDC", VA = "0x15B2EDC")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x15B2EFC", Offset = "0x15B2EFC", VA = "0x15B2EFC")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x15B2F2C", Offset = "0x15B2F2C", VA = "0x15B2F2C")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x15B2F5C", Offset = "0x15B2F5C", VA = "0x15B2F5C")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x15B2F9C", Offset = "0x15B2F9C", VA = "0x15B2F9C")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x15B2FE0", Offset = "0x15B2FE0", VA = "0x15B2FE0")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x15B3004", Offset = "0x15B3004", VA = "0x15B3004")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x15B3028", Offset = "0x15B3028", VA = "0x15B3028")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x15B3050", Offset = "0x15B3050", VA = "0x15B3050")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x15B307C", Offset = "0x15B307C", VA = "0x15B307C")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x15B30A8", Offset = "0x15B30A8", VA = "0x15B30A8")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x15B2E60", Offset = "0x15B2E60", VA = "0x15B2E60")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x15B30D0", Offset = "0x15B30D0", VA = "0x15B30D0")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x15B30DC", Offset = "0x15B30DC", VA = "0x15B30DC")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x15B30E8", Offset = "0x15B30E8", VA = "0x15B30E8")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x15B340C", Offset = "0x15B340C", VA = "0x15B340C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x15B34B4", Offset = "0x15B34B4", VA = "0x15B34B4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x15B38F4", Offset = "0x15B38F4", VA = "0x15B38F4", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x15B3D2C", Offset = "0x15B3D2C", VA = "0x15B3D2C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x15B3D60", Offset = "0x15B3D60", VA = "0x15B3D60")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002F")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x1700000C")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x15B3288", Offset = "0x15B3288", VA = "0x15B3288")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x15B4058", Offset = "0x15B4058", VA = "0x15B4058")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x15B3778", Offset = "0x15B3778", VA = "0x15B3778")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x15B3E84", Offset = "0x15B3E84", VA = "0x15B3E84")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000030")]
	public abstract class Constraint
	{
		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x1700000E")]
		public bool isValid
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x15BCF00", Offset = "0x15BCF00", VA = "0x15BCF00")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000131")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x15BCF6C", Offset = "0x15BCF6C", VA = "0x15BCF6C")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000031")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x15BCF74", Offset = "0x15BCF74", VA = "0x15BCF74", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x15BD034", Offset = "0x15BD034", VA = "0x15BD034")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x15BD03C", Offset = "0x15BD03C", VA = "0x15BD03C")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000032")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x1700000F")]
		private bool positionChanged
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x15BD178", Offset = "0x15BD178", VA = "0x15BD178")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x15BD070", Offset = "0x15BD070", VA = "0x15BD070", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x15BD1B4", Offset = "0x15BD1B4", VA = "0x15BD1B4")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x15BD1BC", Offset = "0x15BD1BC", VA = "0x15BD1BC")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000033")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x15BD1F0", Offset = "0x15BD1F0", VA = "0x15BD1F0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x15BD270", Offset = "0x15BD270", VA = "0x15BD270")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x15BD278", Offset = "0x15BD278", VA = "0x15BD278")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000034")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x17000010")]
		private bool rotationChanged
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x15BD3B4", Offset = "0x15BD3B4", VA = "0x15BD3B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x15BD2AC", Offset = "0x15BD2AC", VA = "0x15BD2AC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x15BD3F0", Offset = "0x15BD3F0", VA = "0x15BD3F0")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x15BD3F8", Offset = "0x15BD3F8", VA = "0x15BD3F8")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000035")]
	public class Constraints
	{
		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x641688", Offset = "0x641688")]
		public float positionWeight;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6416A0", Offset = "0x6416A0")]
		public float rotationWeight;

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x15BD42C", Offset = "0x15BD42C", VA = "0x15BD42C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x15B389C", Offset = "0x15B389C", VA = "0x15B389C")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x15B3A7C", Offset = "0x15B3A7C", VA = "0x15B3A7C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x15B4284", Offset = "0x15B4284", VA = "0x15B4284")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000036")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x2000037")]
		public enum DOF
		{
			[Token(Token = "0x40000F7")]
			One,
			[Token(Token = "0x40000F8")]
			Three
		}

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6416B8", Offset = "0x6416B8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6416B8", Offset = "0x6416B8")]
		public float weight;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64170C", Offset = "0x64170C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64170C", Offset = "0x64170C")]
		public float rotationWeight;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641760", Offset = "0x641760")]
		public DOF rotationDOF;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641798", Offset = "0x641798")]
		public bool fixBone1Twist;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6417D0", Offset = "0x6417D0")]
		public Transform bone1;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641808", Offset = "0x641808")]
		public Transform bone2;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641840", Offset = "0x641840")]
		public Transform bone3;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641878", Offset = "0x641878")]
		public Transform tip;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6418B0", Offset = "0x6418B0")]
		public Transform target;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6418E8", Offset = "0x6418E8")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 bone1TwistAxis;

		[Token(Token = "0x17000011")]
		public bool initiated
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x168EBB0", Offset = "0x168EBB0", VA = "0x168EBB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x648CC0", Offset = "0x648CC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x168EBB8", Offset = "0x168EBB8", VA = "0x168EBB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x648CD0", Offset = "0x648CD0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x168EBC4", Offset = "0x168EBC4", VA = "0x168EBC4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x168EBE4", Offset = "0x168EBE4", VA = "0x168EBE4")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x168EC04", Offset = "0x168EC04", VA = "0x168EC04")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x168EC24", Offset = "0x168EC24", VA = "0x168EC24")]
			set
			{
			}
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x168EC44", Offset = "0x168EC44", VA = "0x168EC44")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x168ED58", Offset = "0x168ED58", VA = "0x168ED58")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x168F214", Offset = "0x168F214", VA = "0x168F214")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x168F2EC", Offset = "0x168F2EC", VA = "0x168F2EC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x168F3B0", Offset = "0x168F3B0", VA = "0x168F3B0")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x168F8FC", Offset = "0x168F8FC", VA = "0x168F8FC")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6418F8", Offset = "0x6418F8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6418F8", Offset = "0x6418F8")]
		public float weight;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64194C", Offset = "0x64194C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000014")]
		public bool initiated
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x168F90C", Offset = "0x168F90C", VA = "0x168F90C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x648CE0", Offset = "0x648CE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x168F914", Offset = "0x168F914", VA = "0x168F914")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x648CF0", Offset = "0x648CF0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x168F920", Offset = "0x168F920", VA = "0x168F920")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x168F9A8", Offset = "0x168F9A8", VA = "0x168F9A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x648D00", Offset = "0x648D00")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x168FD34", Offset = "0x168FD34", VA = "0x168FD34")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x168FEF8", Offset = "0x168FEF8", VA = "0x168FEF8")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x168FC30", Offset = "0x168FC30", VA = "0x168FC30")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1690084", Offset = "0x1690084", VA = "0x1690084", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1690144", Offset = "0x1690144", VA = "0x1690144")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x16901BC", Offset = "0x16901BC", VA = "0x16901BC")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1690230", Offset = "0x1690230", VA = "0x1690230")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1690298", Offset = "0x1690298", VA = "0x1690298", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x169029C", Offset = "0x169029C", VA = "0x169029C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x16902B0", Offset = "0x16902B0", VA = "0x16902B0")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x200003A")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64195C", Offset = "0x64195C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64195C", Offset = "0x64195C")]
		public float weight;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6419B0", Offset = "0x6419B0")]
		public Grounding solver;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6419E8", Offset = "0x6419E8")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000015")]
		public bool initiated
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x1691BF4", Offset = "0x1691BF4", VA = "0x1691BF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x648D38", Offset = "0x648D38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x1691BFC", Offset = "0x1691BFC", VA = "0x1691BFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x648D48", Offset = "0x648D48")]
			protected set
			{
			}
		}

		[Token(Token = "0x600015F")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1691C08", Offset = "0x1691C08", VA = "0x1691C08")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1691DB4", Offset = "0x1691DB4", VA = "0x1691DB4")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1691CB4", Offset = "0x1691CB4", VA = "0x1691CB4")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1691DE8", Offset = "0x1691DE8", VA = "0x1691DE8")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000166")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000167")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1691F24", Offset = "0x1691F24", VA = "0x1691F24")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x64027C", Offset = "0x64027C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x64027C", Offset = "0x64027C")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6419F8", Offset = "0x6419F8")]
		public BipedIK ik;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641A30", Offset = "0x641A30")]
		public float spineBend;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641A68", Offset = "0x641A68")]
		public float spineSpeed;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1692040", Offset = "0x1692040", VA = "0x1692040", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x648D58", Offset = "0x648D58")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x1692088", Offset = "0x1692088", VA = "0x1692088", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x648D90", Offset = "0x648D90")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x16920D0", Offset = "0x16920D0", VA = "0x16920D0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x1692198", Offset = "0x1692198", VA = "0x1692198")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x1692244", Offset = "0x1692244", VA = "0x1692244")]
		private void Update()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x16922A4", Offset = "0x16922A4", VA = "0x16922A4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1692890", Offset = "0x1692890", VA = "0x1692890")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x16928E4", Offset = "0x16928E4", VA = "0x16928E4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x1692F20", Offset = "0x1692F20", VA = "0x1692F20")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x1693038", Offset = "0x1693038", VA = "0x1693038")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1693178", Offset = "0x1693178", VA = "0x1693178")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x169333C", Offset = "0x169333C", VA = "0x169333C")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6402DC", Offset = "0x6402DC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6402DC", Offset = "0x6402DC")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x200003D")]
		public class SpineEffector
		{
			[Token(Token = "0x4000111")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641B48", Offset = "0x641B48")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000112")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641B80", Offset = "0x641B80")]
			public float horizontalWeight;

			[Token(Token = "0x4000113")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641BB8", Offset = "0x641BB8")]
			public float verticalWeight;

			[Token(Token = "0x6000187")]
			[Address(RVA = "0x173E958", Offset = "0x173E958", VA = "0x173E958")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x6000188")]
			[Address(RVA = "0x173E968", Offset = "0x173E968", VA = "0x173E968")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641AA0", Offset = "0x641AA0")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641AD8", Offset = "0x641AD8")]
		public float spineBend;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641B10", Offset = "0x641B10")]
		public float spineSpeed;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x16933DC", Offset = "0x16933DC", VA = "0x16933DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x648DC8", Offset = "0x648DC8")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x1693424", Offset = "0x1693424", VA = "0x1693424", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x648E00", Offset = "0x648E00")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x169346C", Offset = "0x169346C", VA = "0x169346C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x648E38", Offset = "0x648E38")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x16934B4", Offset = "0x16934B4", VA = "0x16934B4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x16934F0", Offset = "0x16934F0", VA = "0x16934F0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x1693584", Offset = "0x1693584", VA = "0x1693584")]
		private void Update()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x169383C", Offset = "0x169383C", VA = "0x169383C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x1693848", Offset = "0x1693848", VA = "0x1693848")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x16935EC", Offset = "0x16935EC", VA = "0x16935EC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x1693854", Offset = "0x1693854", VA = "0x1693854")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1693B70", Offset = "0x1693B70", VA = "0x1693B70")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1693C80", Offset = "0x1693C80", VA = "0x1693C80")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1693DFC", Offset = "0x1693DFC", VA = "0x1693DFC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1693F34", Offset = "0x1693F34", VA = "0x1693F34")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x64033C", Offset = "0x64033C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x64033C", Offset = "0x64033C")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641BF0", Offset = "0x641BF0")]
		public Transform pelvis;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641C28", Offset = "0x641C28")]
		public Transform characterRoot;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641C60", Offset = "0x641C60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x641C60", Offset = "0x641C60")]
		public float rootRotationWeight;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641CB4", Offset = "0x641CB4")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641CEC", Offset = "0x641CEC")]
		public float maxRootRotationAngle;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x1693FD4", Offset = "0x1693FD4", VA = "0x1693FD4", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x648E70", Offset = "0x648E70")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x169401C", Offset = "0x169401C", VA = "0x169401C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x648EA8", Offset = "0x648EA8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1694064", Offset = "0x1694064", VA = "0x1694064", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x169407C", Offset = "0x169407C", VA = "0x169407C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x16942B0", Offset = "0x16942B0", VA = "0x16942B0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x16943AC", Offset = "0x16943AC", VA = "0x16943AC")]
		private void Update()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1694954", Offset = "0x1694954", VA = "0x1694954")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1694DB8", Offset = "0x1694DB8", VA = "0x1694DB8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x1694F44", Offset = "0x1694F44", VA = "0x1694F44")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x1695248", Offset = "0x1695248", VA = "0x1695248")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x1695394", Offset = "0x1695394", VA = "0x1695394")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x16955A0", Offset = "0x16955A0", VA = "0x16955A0")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x64039C", Offset = "0x64039C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x64039C", Offset = "0x64039C")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x2000040")]
		public struct Foot
		{
			[Token(Token = "0x400013F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x4000140")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x4000141")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x4000142")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x173E9B0", Offset = "0x173E9B0", VA = "0x173E9B0")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641D24", Offset = "0x641D24")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641D5C", Offset = "0x641D5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x641D5C", Offset = "0x641D5C")]
		public float rootRotationWeight;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x641DB0", Offset = "0x641DB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641DB0", Offset = "0x641DB0")]
		public float minRootRotation;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641E08", Offset = "0x641E08")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x641E08", Offset = "0x641E08")]
		public float maxRootRotation;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641E60", Offset = "0x641E60")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641E98", Offset = "0x641E98")]
		public float maxLegOffset;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641ED0", Offset = "0x641ED0")]
		public float maxForeLegOffset;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641F08", Offset = "0x641F08")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x641F08", Offset = "0x641F08")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641F5C", Offset = "0x641F5C")]
		public Transform characterRoot;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641F94", Offset = "0x641F94")]
		public Transform pelvis;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641FCC", Offset = "0x641FCC")]
		public Transform lastSpineBone;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642004", Offset = "0x642004")]
		public Transform head;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x1695640", Offset = "0x1695640", VA = "0x1695640", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x648EE0", Offset = "0x648EE0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x1695688", Offset = "0x1695688", VA = "0x1695688", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x648F18", Offset = "0x648F18")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x16956D0", Offset = "0x16956D0", VA = "0x16956D0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x1695704", Offset = "0x1695704", VA = "0x1695704")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1695830", Offset = "0x1695830", VA = "0x1695830")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1695A34", Offset = "0x1695A34", VA = "0x1695A34")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1695A9C", Offset = "0x1695A9C", VA = "0x1695A9C")]
		private void Update()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1695B00", Offset = "0x1695B00", VA = "0x1695B00")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1695E60", Offset = "0x1695E60", VA = "0x1695E60")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x16961F8", Offset = "0x16961F8", VA = "0x16961F8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x16962F0", Offset = "0x16962F0", VA = "0x16962F0")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x16966BC", Offset = "0x16966BC", VA = "0x16966BC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1696CD8", Offset = "0x1696CD8", VA = "0x1696CD8")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1696EA8", Offset = "0x1696EA8", VA = "0x1696EA8")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1696F84", Offset = "0x1696F84", VA = "0x1696F84")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x16971CC", Offset = "0x16971CC", VA = "0x16971CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1697204", Offset = "0x1697204", VA = "0x1697204")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1697408", Offset = "0x1697408", VA = "0x1697408")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6403FC", Offset = "0x6403FC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6403FC", Offset = "0x6403FC")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64204C", Offset = "0x64204C")]
		public VRIK ik;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1697520", Offset = "0x1697520", VA = "0x1697520")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x648F50", Offset = "0x648F50")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1697568", Offset = "0x1697568", VA = "0x1697568", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x648F88", Offset = "0x648F88")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x16975B0", Offset = "0x16975B0", VA = "0x16975B0", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x648FC0", Offset = "0x648FC0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x16975F8", Offset = "0x16975F8", VA = "0x16975F8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x1697610", Offset = "0x1697610", VA = "0x1697610")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x16976A4", Offset = "0x16976A4", VA = "0x16976A4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1697704", Offset = "0x1697704", VA = "0x1697704")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1697970", Offset = "0x1697970", VA = "0x1697970")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x1697B60", Offset = "0x1697B60", VA = "0x1697B60")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x1697BF0", Offset = "0x1697BF0", VA = "0x1697BF0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x1697DAC", Offset = "0x1697DAC", VA = "0x1697DAC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1697F28", Offset = "0x1697F28", VA = "0x1697F28")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x16980DC", Offset = "0x16980DC", VA = "0x16980DC")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000042")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x2000043")]
		public enum Quality
		{
			[Token(Token = "0x400015E")]
			Fastest,
			[Token(Token = "0x400015F")]
			Simple,
			[Token(Token = "0x4000160")]
			Best
		}

		[Token(Token = "0x2000044")]
		public class Leg
		{
			[Token(Token = "0x4000161")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642530", Offset = "0x642530")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x4000162")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642540", Offset = "0x642540")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x4000163")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x4000164")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642550", Offset = "0x642550")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x4000165")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642560", Offset = "0x642560")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x4000166")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642570", Offset = "0x642570")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x4000167")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642580", Offset = "0x642580")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x4000168")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642590", Offset = "0x642590")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x4000169")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x400016A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6425A0", Offset = "0x6425A0")]
			private RaycastHit <heelHit>k__BackingField;

			[Token(Token = "0x400016B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6425B0", Offset = "0x6425B0")]
			private RaycastHit <capsuleHit>k__BackingField;

			[Token(Token = "0x400016C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Grounding grounding;

			[Token(Token = "0x400016D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float lastTime;

			[Token(Token = "0x400016E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float deltaTime;

			[Token(Token = "0x400016F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000170")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private Quaternion toHitNormal;

			[Token(Token = "0x4000171")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Quaternion r;

			[Token(Token = "0x4000172")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 up;

			[Token(Token = "0x4000173")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool doOverrideFootPosition;

			[Token(Token = "0x4000174")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 overrideFootPosition;

			[Token(Token = "0x4000175")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 transformPosition;

			[Token(Token = "0x1700001E")]
			public bool isGrounded
			{
				[Token(Token = "0x60001CD")]
				[Address(RVA = "0x173EA14", Offset = "0x173EA14", VA = "0x173EA14")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649098", Offset = "0x649098")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001CE")]
				[Address(RVA = "0x173EA1C", Offset = "0x173EA1C", VA = "0x173EA1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6490A8", Offset = "0x6490A8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700001F")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60001CF")]
				[Address(RVA = "0x173EA28", Offset = "0x173EA28", VA = "0x173EA28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6490B8", Offset = "0x6490B8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001D0")]
				[Address(RVA = "0x173EA34", Offset = "0x173EA34", VA = "0x173EA34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6490C8", Offset = "0x6490C8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000020")]
			public bool initiated
			{
				[Token(Token = "0x60001D1")]
				[Address(RVA = "0x173EA40", Offset = "0x173EA40", VA = "0x173EA40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6490D8", Offset = "0x6490D8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001D2")]
				[Address(RVA = "0x173EA48", Offset = "0x173EA48", VA = "0x173EA48")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6490E8", Offset = "0x6490E8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000021")]
			public float heightFromGround
			{
				[Token(Token = "0x60001D3")]
				[Address(RVA = "0x173EA54", Offset = "0x173EA54", VA = "0x173EA54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6490F8", Offset = "0x6490F8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001D4")]
				[Address(RVA = "0x173EA5C", Offset = "0x173EA5C", VA = "0x173EA5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649108", Offset = "0x649108")]
				private set
				{
				}
			}

			[Token(Token = "0x17000022")]
			public Vector3 velocity
			{
				[Token(Token = "0x60001D5")]
				[Address(RVA = "0x173EA64", Offset = "0x173EA64", VA = "0x173EA64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649118", Offset = "0x649118")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001D6")]
				[Address(RVA = "0x173EA70", Offset = "0x173EA70", VA = "0x173EA70")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649128", Offset = "0x649128")]
				private set
				{
				}
			}

			[Token(Token = "0x17000023")]
			public Transform transform
			{
				[Token(Token = "0x60001D7")]
				[Address(RVA = "0x173EA7C", Offset = "0x173EA7C", VA = "0x173EA7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649138", Offset = "0x649138")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001D8")]
				[Address(RVA = "0x173EA84", Offset = "0x173EA84", VA = "0x173EA84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649148", Offset = "0x649148")]
				private set
				{
				}
			}

			[Token(Token = "0x17000024")]
			public float IKOffset
			{
				[Token(Token = "0x60001D9")]
				[Address(RVA = "0x173EA8C", Offset = "0x173EA8C", VA = "0x173EA8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649158", Offset = "0x649158")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001DA")]
				[Address(RVA = "0x173EA94", Offset = "0x173EA94", VA = "0x173EA94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649168", Offset = "0x649168")]
				private set
				{
				}
			}

			[Token(Token = "0x17000025")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x60001DB")]
				[Address(RVA = "0x173EA9C", Offset = "0x173EA9C", VA = "0x173EA9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649178", Offset = "0x649178")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001DC")]
				[Address(RVA = "0x173EAB4", Offset = "0x173EAB4", VA = "0x173EAB4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649188", Offset = "0x649188")]
				private set
				{
				}
			}

			[Token(Token = "0x17000026")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x60001DD")]
				[Address(RVA = "0x173EAD4", Offset = "0x173EAD4", VA = "0x173EAD4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649198", Offset = "0x649198")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001DE")]
				[Address(RVA = "0x173EAEC", Offset = "0x173EAEC", VA = "0x173EAEC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6491A8", Offset = "0x6491A8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000027")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x60001DF")]
				[Address(RVA = "0x173EB0C", Offset = "0x173EB0C", VA = "0x173EB0C")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x17000028")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60001E5")]
				[Address(RVA = "0x173FB24", Offset = "0x173FB24", VA = "0x173FB24")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000029")]
			private float rootYOffset
			{
				[Token(Token = "0x60001EE")]
				[Address(RVA = "0x173FC88", Offset = "0x173FC88", VA = "0x173FC88")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x173EB54", Offset = "0x173EB54", VA = "0x173EB54")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x173EB68", Offset = "0x173EB68", VA = "0x173EB68")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x173EBF8", Offset = "0x173EBF8", VA = "0x173EBF8")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x173EC44", Offset = "0x173EC44", VA = "0x173EC44")]
			public void Reset()
			{
			}

			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x173ECB4", Offset = "0x173ECB4", VA = "0x173ECB4")]
			public void Process()
			{
			}

			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x173F79C", Offset = "0x173F79C", VA = "0x173F79C")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x173F33C", Offset = "0x173F33C", VA = "0x173F33C")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x173FBB8", Offset = "0x173FBB8", VA = "0x173FBB8")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x173F5D8", Offset = "0x173F5D8", VA = "0x173F5D8")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x173F664", Offset = "0x173F664", VA = "0x173F664")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x173FC28", Offset = "0x173FC28", VA = "0x173FC28")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x173FB4C", Offset = "0x173FB4C", VA = "0x173FB4C")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x173FD1C", Offset = "0x173FD1C", VA = "0x173FD1C")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x173FDA8", Offset = "0x173FDA8", VA = "0x173FDA8")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x2000045")]
		public class Pelvis
		{
			[Token(Token = "0x4000176")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6425C0", Offset = "0x6425C0")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x4000177")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6425D0", Offset = "0x6425D0")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x4000178")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x4000179")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x400017A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x400017B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x400017C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x1700002A")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x60001F0")]
				[Address(RVA = "0x173FDEC", Offset = "0x173FDEC", VA = "0x173FDEC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6491B8", Offset = "0x6491B8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001F1")]
				[Address(RVA = "0x173FDF8", Offset = "0x173FDF8", VA = "0x173FDF8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6491C8", Offset = "0x6491C8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002B")]
			public float heightOffset
			{
				[Token(Token = "0x60001F2")]
				[Address(RVA = "0x173FE04", Offset = "0x173FE04", VA = "0x173FE04")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6491D8", Offset = "0x6491D8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001F3")]
				[Address(RVA = "0x173FE0C", Offset = "0x173FE0C", VA = "0x173FE0C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6491E8", Offset = "0x6491E8")]
				private set
				{
				}
			}

			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x173FE14", Offset = "0x173FE14", VA = "0x173FE14")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x173FEA4", Offset = "0x173FEA4", VA = "0x173FEA4")]
			public void Reset()
			{
			}

			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x173FE44", Offset = "0x173FE44", VA = "0x173FE44")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x173FF10", Offset = "0x173FF10", VA = "0x173FF10")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x17400B0", Offset = "0x17400B0", VA = "0x17400B0")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642084", Offset = "0x642084")]
		public LayerMask layers;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6420BC", Offset = "0x6420BC")]
		public float maxStep;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6420F4", Offset = "0x6420F4")]
		public float heightOffset;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64212C", Offset = "0x64212C")]
		public float footSpeed;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642164", Offset = "0x642164")]
		public float footRadius;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64219C", Offset = "0x64219C")]
		public float footCenterOffset;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6421E8", Offset = "0x6421E8")]
		public float prediction;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642220", Offset = "0x642220")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x642220", Offset = "0x642220")]
		public float footRotationWeight;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642274", Offset = "0x642274")]
		public float footRotationSpeed;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6422AC", Offset = "0x6422AC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6422AC", Offset = "0x6422AC")]
		public float maxFootRotationAngle;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642304", Offset = "0x642304")]
		public bool rotateSolver;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64233C", Offset = "0x64233C")]
		public float pelvisSpeed;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642374", Offset = "0x642374")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x642374", Offset = "0x642374")]
		public float pelvisDamper;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6423C8", Offset = "0x6423C8")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642400", Offset = "0x642400")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642438", Offset = "0x642438")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642470", Offset = "0x642470")]
		public bool overstepFallsDown;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6424A8", Offset = "0x6424A8")]
		public Quality quality;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6424E0", Offset = "0x6424E0")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6424F0", Offset = "0x6424F0")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642500", Offset = "0x642500")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642510", Offset = "0x642510")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642520", Offset = "0x642520")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000016")]
		public Leg[] legs
		{
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x1698140", Offset = "0x1698140", VA = "0x1698140")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x648FF8", Offset = "0x648FF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x1698148", Offset = "0x1698148", VA = "0x1698148")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649008", Offset = "0x649008")]
			private set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x1698150", Offset = "0x1698150", VA = "0x1698150")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649018", Offset = "0x649018")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x1698158", Offset = "0x1698158", VA = "0x1698158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649028", Offset = "0x649028")]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public bool isGrounded
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x1698160", Offset = "0x1698160", VA = "0x1698160")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649038", Offset = "0x649038")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x1698168", Offset = "0x1698168", VA = "0x1698168")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649048", Offset = "0x649048")]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public Transform root
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x1698174", Offset = "0x1698174", VA = "0x1698174")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649058", Offset = "0x649058")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x169817C", Offset = "0x169817C", VA = "0x169817C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649068", Offset = "0x649068")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x1698184", Offset = "0x1698184", VA = "0x1698184")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649078", Offset = "0x649078")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x169819C", Offset = "0x169819C", VA = "0x169819C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649088", Offset = "0x649088")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x16981BC", Offset = "0x16981BC", VA = "0x16981BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001C")]
		public Vector3 up
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x1692FF4", Offset = "0x1692FF4", VA = "0x1692FF4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700001D")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x1698588", Offset = "0x1698588", VA = "0x1698588")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x1698210", Offset = "0x1698210", VA = "0x1698210")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x169845C", Offset = "0x169845C", VA = "0x169845C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x16925C0", Offset = "0x16925C0", VA = "0x16925C0")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x1692CD8", Offset = "0x1692CD8", VA = "0x1692CD8")]
		public void Update()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x16947F4", Offset = "0x16947F4", VA = "0x16947F4")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x169210C", Offset = "0x169210C", VA = "0x169210C")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1698570", Offset = "0x1698570", VA = "0x1698570")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1698608", Offset = "0x1698608", VA = "0x1698608")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x1698698", Offset = "0x1698698", VA = "0x1698698")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x1698754", Offset = "0x1698754", VA = "0x1698754")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1691FEC", Offset = "0x1691FEC", VA = "0x1691FEC")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000046")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x64045C", Offset = "0x64045C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x64045C", Offset = "0x64045C")]
	public class AimIK : IK
	{
		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x15AE93C", Offset = "0x15AE93C", VA = "0x15AE93C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6491F8", Offset = "0x6491F8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x15AE984", Offset = "0x15AE984", VA = "0x15AE984", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649230", Offset = "0x649230")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x15AE9CC", Offset = "0x15AE9CC", VA = "0x15AE9CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649268", Offset = "0x649268")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x15AEA14", Offset = "0x15AEA14", VA = "0x15AEA14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6492A0", Offset = "0x6492A0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x15AEA5C", Offset = "0x15AEA5C", VA = "0x15AEA5C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6492D8", Offset = "0x6492D8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x15AEAA4", Offset = "0x15AEAA4", VA = "0x15AEAA4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x15AEAAC", Offset = "0x15AEAAC", VA = "0x15AEAAC")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6404BC", Offset = "0x6404BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6404BC", Offset = "0x6404BC")]
	public class ArmIK : IK
	{
		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x15AEE2C", Offset = "0x15AEE2C", VA = "0x15AEE2C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649310", Offset = "0x649310")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x15AEE74", Offset = "0x15AEE74", VA = "0x15AEE74", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649348", Offset = "0x649348")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x15AEEBC", Offset = "0x15AEEBC", VA = "0x15AEEBC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649380", Offset = "0x649380")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x15AEF04", Offset = "0x15AEF04", VA = "0x15AEF04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6493B8", Offset = "0x6493B8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x15AEF4C", Offset = "0x15AEF4C", VA = "0x15AEF4C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x15AEF54", Offset = "0x15AEF54", VA = "0x15AEF54")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x64051C", Offset = "0x64051C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x64051C", Offset = "0x64051C")]
	public class CCDIK : IK
	{
		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x15BBA00", Offset = "0x15BBA00", VA = "0x15BBA00", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6493F0", Offset = "0x6493F0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x15BBA48", Offset = "0x15BBA48", VA = "0x15BBA48", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649428", Offset = "0x649428")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x15BBA90", Offset = "0x15BBA90", VA = "0x15BBA90")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649460", Offset = "0x649460")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x15BBAD8", Offset = "0x15BBAD8", VA = "0x15BBAD8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649498", Offset = "0x649498")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x15BBB20", Offset = "0x15BBB20", VA = "0x15BBB20", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x15BBB28", Offset = "0x15BBB28", VA = "0x15BBB28")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x64057C", Offset = "0x64057C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x64057C", Offset = "0x64057C")]
	public class FABRIK : IK
	{
		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x15BF098", Offset = "0x15BF098", VA = "0x15BF098", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6494D0", Offset = "0x6494D0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x15BF0E0", Offset = "0x15BF0E0", VA = "0x15BF0E0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649508", Offset = "0x649508")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x15BF128", Offset = "0x15BF128", VA = "0x15BF128")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649540", Offset = "0x649540")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x15BF170", Offset = "0x15BF170", VA = "0x15BF170")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649578", Offset = "0x649578")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x15BF1B8", Offset = "0x15BF1B8", VA = "0x15BF1B8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x15BF1C0", Offset = "0x15BF1C0", VA = "0x15BF1C0")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6405DC", Offset = "0x6405DC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6405DC", Offset = "0x6405DC")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x15BF708", Offset = "0x15BF708", VA = "0x15BF708", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6495B0", Offset = "0x6495B0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x15BF750", Offset = "0x15BF750", VA = "0x15BF750", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6495E8", Offset = "0x6495E8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x15BF798", Offset = "0x15BF798", VA = "0x15BF798")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649620", Offset = "0x649620")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x15BF7E0", Offset = "0x15BF7E0", VA = "0x15BF7E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649658", Offset = "0x649658")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x15BF828", Offset = "0x15BF828", VA = "0x15BF828", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x15BF830", Offset = "0x15BF830", VA = "0x15BF830")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x64063C", Offset = "0x64063C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x64063C", Offset = "0x64063C")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x16907A0", Offset = "0x16907A0", VA = "0x16907A0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649690", Offset = "0x649690")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x16907E8", Offset = "0x16907E8", VA = "0x16907E8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6496C8", Offset = "0x6496C8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x1690830", Offset = "0x1690830", VA = "0x1690830")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649700", Offset = "0x649700")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1690878", Offset = "0x1690878", VA = "0x1690878")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649738", Offset = "0x649738")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x16908C0", Offset = "0x16908C0", VA = "0x16908C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649770", Offset = "0x649770")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x1690908", Offset = "0x1690908", VA = "0x1690908")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6497A8", Offset = "0x6497A8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1690950", Offset = "0x1690950", VA = "0x1690950")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x1690994", Offset = "0x1690994", VA = "0x1690994", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x169099C", Offset = "0x169099C", VA = "0x169099C")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x1690B84", Offset = "0x1690B84", VA = "0x1690B84")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1690E24", Offset = "0x1690E24", VA = "0x1690E24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6497E0", Offset = "0x6497E0")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x1690E44", Offset = "0x1690E44", VA = "0x1690E44")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649818", Offset = "0x649818")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1690F34", Offset = "0x1690F34", VA = "0x1690F34")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000225")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x169B260", Offset = "0x169B260", VA = "0x169B260", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x169B2E8", Offset = "0x169B2E8", VA = "0x169B2E8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x169B35C", Offset = "0x169B35C", VA = "0x169B35C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000229")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600022A")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1690FDC", Offset = "0x1690FDC", VA = "0x1690FDC")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6425E0", Offset = "0x6425E0")]
		public IK[] IKComponents;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642618", Offset = "0x642618")]
		public Animator animator;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x1700002C")]
		private bool animatePhysics
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x169D9E8", Offset = "0x169D9E8", VA = "0x169D9E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x169DA80", Offset = "0x169DA80", VA = "0x169DA80")]
		private void Start()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x169DAF0", Offset = "0x169DAF0", VA = "0x169DAF0")]
		private void Update()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x169DBAC", Offset = "0x169DBAC", VA = "0x169DBAC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x169DBE8", Offset = "0x169DBE8", VA = "0x169DBE8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x169DB24", Offset = "0x169DB24", VA = "0x169DB24")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x169DC78", Offset = "0x169DC78", VA = "0x169DC78")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x64069C", Offset = "0x64069C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x64069C", Offset = "0x64069C")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x12CA72C", Offset = "0x12CA72C", VA = "0x12CA72C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649850", Offset = "0x649850")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x12CA774", Offset = "0x12CA774", VA = "0x12CA774", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649888", Offset = "0x649888")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x12CA7BC", Offset = "0x12CA7BC", VA = "0x12CA7BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6498C0", Offset = "0x6498C0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x12CA804", Offset = "0x12CA804", VA = "0x12CA804")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6498F8", Offset = "0x6498F8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x12CA84C", Offset = "0x12CA84C", VA = "0x12CA84C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x12CA854", Offset = "0x12CA854", VA = "0x12CA854")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x200004F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6406FC", Offset = "0x6406FC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6406FC", Offset = "0x6406FC")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x12CA8C4", Offset = "0x12CA8C4", VA = "0x12CA8C4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649930", Offset = "0x649930")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x12CA90C", Offset = "0x12CA90C", VA = "0x12CA90C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649968", Offset = "0x649968")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x12CA954", Offset = "0x12CA954", VA = "0x12CA954")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6499A0", Offset = "0x6499A0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x12CA99C", Offset = "0x12CA99C", VA = "0x12CA99C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6499D8", Offset = "0x6499D8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x12CA9E4", Offset = "0x12CA9E4", VA = "0x12CA9E4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x12CA9EC", Offset = "0x12CA9EC", VA = "0x12CA9EC")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000050")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x64075C", Offset = "0x64075C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x64075C", Offset = "0x64075C")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xC46088", Offset = "0xC46088", VA = "0xC46088", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649A10", Offset = "0x649A10")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xC460D0", Offset = "0xC460D0", VA = "0xC460D0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649A48", Offset = "0x649A48")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xC46118", Offset = "0xC46118", VA = "0xC46118")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649A80", Offset = "0x649A80")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xC46160", Offset = "0xC46160", VA = "0xC46160")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649AB8", Offset = "0x649AB8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xC461A8", Offset = "0xC461A8", VA = "0xC461A8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xC461B0", Offset = "0xC461B0", VA = "0xC461B0")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6407BC", Offset = "0x6407BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6407BC", Offset = "0x6407BC")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xE8557C", Offset = "0xE8557C", VA = "0xE8557C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649AF0", Offset = "0x649AF0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xE855C4", Offset = "0xE855C4", VA = "0xE855C4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649B28", Offset = "0x649B28")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xE8560C", Offset = "0xE8560C", VA = "0xE8560C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649B60", Offset = "0x649B60")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xE85654", Offset = "0xE85654", VA = "0xE85654")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649B98", Offset = "0x649B98")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xE8569C", Offset = "0xE8569C", VA = "0xE8569C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xE856A4", Offset = "0xE856A4", VA = "0xE856A4")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x64081C", Offset = "0x64081C")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x2000053")]
		public class References
		{
			[Token(Token = "0x400018D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x400018E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x4000190")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6426FC", Offset = "0x6426FC")]
			public Transform chest;

			[Token(Token = "0x4000191")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642734", Offset = "0x642734")]
			public Transform neck;

			[Token(Token = "0x4000192")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x4000193")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64276C", Offset = "0x64276C")]
			public Transform leftShoulder;

			[Token(Token = "0x4000194")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x4000195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x4000196")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x4000197")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6427A4", Offset = "0x6427A4")]
			public Transform rightShoulder;

			[Token(Token = "0x4000198")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x4000199")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x400019A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x400019B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6427DC", Offset = "0x6427DC")]
			public Transform leftThigh;

			[Token(Token = "0x400019C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642814", Offset = "0x642814")]
			public Transform leftCalf;

			[Token(Token = "0x400019D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64284C", Offset = "0x64284C")]
			public Transform leftFoot;

			[Token(Token = "0x400019E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642884", Offset = "0x642884")]
			public Transform leftToes;

			[Token(Token = "0x400019F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6428BC", Offset = "0x6428BC")]
			public Transform rightThigh;

			[Token(Token = "0x40001A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6428F4", Offset = "0x6428F4")]
			public Transform rightCalf;

			[Token(Token = "0x40001A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64292C", Offset = "0x64292C")]
			public Transform rightFoot;

			[Token(Token = "0x40001A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642964", Offset = "0x642964")]
			public Transform rightToes;

			[Token(Token = "0x1700002D")]
			public bool isFilled
			{
				[Token(Token = "0x6000255")]
				[Address(RVA = "0x168A2A0", Offset = "0x168A2A0", VA = "0x168A2A0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700002E")]
			public bool isEmpty
			{
				[Token(Token = "0x6000256")]
				[Address(RVA = "0x168A718", Offset = "0x168A718", VA = "0x168A718")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000254")]
			[Address(RVA = "0x1689D50", Offset = "0x1689D50", VA = "0x1689D50")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x6000257")]
			[Address(RVA = "0x168AB90", Offset = "0x168AB90", VA = "0x168AB90")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x6000258")]
			[Address(RVA = "0x168B03C", Offset = "0x168B03C", VA = "0x168B03C")]
			public References()
			{
			}
		}

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642650", Offset = "0x642650")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x642650", Offset = "0x642650")]
		public References references;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6426C4", Offset = "0x6426C4")]
		public IKSolverVR solver;

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xE875C0", Offset = "0xE875C0", VA = "0xE875C0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649BD0", Offset = "0x649BD0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xE87608", Offset = "0xE87608", VA = "0xE87608", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649C08", Offset = "0x649C08")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xE87650", Offset = "0xE87650", VA = "0xE87650")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649C40", Offset = "0x649C40")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xE87698", Offset = "0xE87698", VA = "0xE87698")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649C78", Offset = "0x649C78")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xE876C4", Offset = "0xE876C4", VA = "0xE876C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649CB0", Offset = "0x649CB0")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xE876EC", Offset = "0xE876EC", VA = "0xE876EC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xE876F4", Offset = "0xE876F4", VA = "0xE876F4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xE87774", Offset = "0xE87774", VA = "0xE87774", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xE878E0", Offset = "0xE878E0", VA = "0xE878E0")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000054")]
	public class FABRIKChain
	{
		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64299C", Offset = "0x64299C")]
		public float pull;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6429B4", Offset = "0x6429B4")]
		public float pin;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x15BF230", Offset = "0x15BF230", VA = "0x15BF230")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x15BF30C", Offset = "0x15BF30C", VA = "0x15BF30C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x15BF32C", Offset = "0x15BF32C", VA = "0x15BF32C")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x15BF5A0", Offset = "0x15BF5A0", VA = "0x15BF5A0")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x15BF400", Offset = "0x15BF400", VA = "0x15BF400")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x15BF698", Offset = "0x15BF698", VA = "0x15BF698")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x15BF8A0", Offset = "0x15BF8A0", VA = "0x15BF8A0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x15BFD18", Offset = "0x15BFD18", VA = "0x15BFD18")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x15BFED4", Offset = "0x15BFED4", VA = "0x15BFED4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x15C0004", Offset = "0x15C0004", VA = "0x15C0004")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000057")]
		public class BendBone
		{
			[Token(Token = "0x40001DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64300C", Offset = "0x64300C")]
			public Transform transform;

			[Token(Token = "0x40001DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643044", Offset = "0x643044")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643044", Offset = "0x643044")]
			public float weight;

			[Token(Token = "0x40001DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000271")]
			[Address(RVA = "0x173DDC0", Offset = "0x173DDC0", VA = "0x173DDC0")]
			public BendBone()
			{
			}

			[Token(Token = "0x6000272")]
			[Address(RVA = "0x173DDFC", Offset = "0x173DDFC", VA = "0x173DDFC")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000273")]
			[Address(RVA = "0x173DE60", Offset = "0x173DE60", VA = "0x173DE60")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000274")]
			[Address(RVA = "0x173DE98", Offset = "0x173DE98", VA = "0x173DE98")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6429CC", Offset = "0x6429CC")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x642A04", Offset = "0x642A04")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642A04", Offset = "0x642A04")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x642A04", Offset = "0x642A04")]
		public float positionWeight;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x642A7C", Offset = "0x642A7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642A7C", Offset = "0x642A7C")]
		public float bodyWeight;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x642AD0", Offset = "0x642AD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642AD0", Offset = "0x642AD0")]
		public float thighWeight;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642B24", Offset = "0x642B24")]
		public bool handsPullBody;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642B5C", Offset = "0x642B5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x642B5C", Offset = "0x642B5C")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x642B5C", Offset = "0x642B5C")]
		public float rotationWeight;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642BD4", Offset = "0x642BD4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x642BD4", Offset = "0x642BD4")]
		public float bodyClampWeight;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642C28", Offset = "0x642C28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x642C28", Offset = "0x642C28")]
		public float headClampWeight;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x642C7C", Offset = "0x642C7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642C7C", Offset = "0x642C7C")]
		public float bendWeight;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642CD0", Offset = "0x642CD0")]
		public BendBone[] bendBones;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x642D08", Offset = "0x642D08")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x642D08", Offset = "0x642D08")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642D08", Offset = "0x642D08")]
		public float CCDWeight;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642D80", Offset = "0x642D80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x642D80", Offset = "0x642D80")]
		public float roll;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642DD4", Offset = "0x642DD4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x642DD4", Offset = "0x642DD4")]
		public float damper;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642E2C", Offset = "0x642E2C")]
		public Transform[] CCDBones;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x642E64", Offset = "0x642E64")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x642E64", Offset = "0x642E64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642E64", Offset = "0x642E64")]
		public float postStretchWeight;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642EDC", Offset = "0x642EDC")]
		public float maxStretch;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642F14", Offset = "0x642F14")]
		public float stretchDamper;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642F4C", Offset = "0x642F4C")]
		public bool fixHead;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642F84", Offset = "0x642F84")]
		public Transform[] stretchBones;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x642FBC", Offset = "0x642FBC")]
		public Vector3 chestDirection;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x642FF4", Offset = "0x642FF4")]
		public float chestDirectionWeight;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x15C000C", Offset = "0x15C000C", VA = "0x15C000C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x15C0394", Offset = "0x15C0394", VA = "0x15C0394")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x15C0870", Offset = "0x15C0870", VA = "0x15C0870")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x15C0C3C", Offset = "0x15C0C3C", VA = "0x15C0C3C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x15C13C8", Offset = "0x15C13C8", VA = "0x15C13C8")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x15C16A8", Offset = "0x15C16A8", VA = "0x15C16A8")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x15C19AC", Offset = "0x15C19AC", VA = "0x15C19AC")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x15C2180", Offset = "0x15C2180", VA = "0x15C2180")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x15C11AC", Offset = "0x15C11AC", VA = "0x15C11AC")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x15C2348", Offset = "0x15C2348", VA = "0x15C2348")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x15C2098", Offset = "0x15C2098", VA = "0x15C2098")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x15C1FCC", Offset = "0x15C1FCC", VA = "0x15C1FCC")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x15C25CC", Offset = "0x15C25CC", VA = "0x15C25CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x15C2900", Offset = "0x15C2900", VA = "0x15C2900")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000058")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x2000059")]
		public class ChildConstraint
		{
			[Token(Token = "0x40001F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x40001F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x40001F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x40001FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x40001FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643130", Offset = "0x643130")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x40001FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643140", Offset = "0x643140")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x40001FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x40001FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x40001FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x4000200")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x1700002F")]
			public float nominalDistance
			{
				[Token(Token = "0x6000289")]
				[Address(RVA = "0x173DEC0", Offset = "0x173DEC0", VA = "0x173DEC0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649CE8", Offset = "0x649CE8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600028A")]
				[Address(RVA = "0x173DEC8", Offset = "0x173DEC8", VA = "0x173DEC8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649CF8", Offset = "0x649CF8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000030")]
			public bool isRigid
			{
				[Token(Token = "0x600028B")]
				[Address(RVA = "0x173DED0", Offset = "0x173DED0", VA = "0x173DED0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649D08", Offset = "0x649D08")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600028C")]
				[Address(RVA = "0x173DED8", Offset = "0x173DED8", VA = "0x173DED8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649D18", Offset = "0x649D18")]
				private set
				{
				}
			}

			[Token(Token = "0x600028D")]
			[Address(RVA = "0x173DEE4", Offset = "0x173DEE4", VA = "0x173DEE4")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x600028E")]
			[Address(RVA = "0x173DF4C", Offset = "0x173DF4C", VA = "0x173DF4C")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600028F")]
			[Address(RVA = "0x173DFA4", Offset = "0x173DFA4", VA = "0x173DFA4")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000290")]
			[Address(RVA = "0x173E148", Offset = "0x173E148", VA = "0x173E148")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200005A")]
		public enum Smoothing
		{
			[Token(Token = "0x4000202")]
			None,
			[Token(Token = "0x4000203")]
			Exponential,
			[Token(Token = "0x4000204")]
			Cubic
		}

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643098", Offset = "0x643098")]
		public float pin;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6430B0", Offset = "0x6430B0")]
		public float pull;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6430C8", Offset = "0x6430C8")]
		public float push;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6430E0", Offset = "0x6430E0")]
		public float pushParent;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6430F8", Offset = "0x6430F8")]
		public float reach;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x40001F6")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x15C2AE8", Offset = "0x15C2AE8", VA = "0x15C2AE8")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x15C2C04", Offset = "0x15C2C04", VA = "0x15C2C04")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x15C2D74", Offset = "0x15C2D74", VA = "0x15C2D74")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x15C2EB0", Offset = "0x15C2EB0", VA = "0x15C2EB0")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x15C2F88", Offset = "0x15C2F88", VA = "0x15C2F88")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x15C30AC", Offset = "0x15C30AC", VA = "0x15C30AC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x15C377C", Offset = "0x15C377C", VA = "0x15C377C")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x15C3248", Offset = "0x15C3248", VA = "0x15C3248")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x15C3B6C", Offset = "0x15C3B6C", VA = "0x15C3B6C")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x15C3DCC", Offset = "0x15C3DCC", VA = "0x15C3DCC")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x15C4038", Offset = "0x15C4038", VA = "0x15C4038")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x15C43DC", Offset = "0x15C43DC", VA = "0x15C43DC")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x15C4870", Offset = "0x15C4870", VA = "0x15C4870")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x15C4A94", Offset = "0x15C4A94", VA = "0x15C4A94")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x15C4800", Offset = "0x15C4800", VA = "0x15C4800")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x15C4268", Offset = "0x15C4268", VA = "0x15C4268")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x15C4784", Offset = "0x15C4784", VA = "0x15C4784")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x15C4B7C", Offset = "0x15C4B7C", VA = "0x15C4B7C")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x15C46A4", Offset = "0x15C46A4", VA = "0x15C46A4")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x15C497C", Offset = "0x15C497C", VA = "0x15C497C")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005B")]
	public class IKConstraintBend
	{
		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643150", Offset = "0x643150")]
		public float weight;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643168", Offset = "0x643168")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000031")]
		public bool initiated
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x169B5A4", Offset = "0x169B5A4", VA = "0x169B5A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649D28", Offset = "0x649D28")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x169B5AC", Offset = "0x169B5AC", VA = "0x169B5AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649D38", Offset = "0x649D38")]
			private set
			{
			}
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x169B3BC", Offset = "0x169B3BC", VA = "0x169B3BC")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x169B5B8", Offset = "0x169B5B8", VA = "0x169B5B8")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x169B5F8", Offset = "0x169B5F8", VA = "0x169B5F8")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x169B660", Offset = "0x169B660", VA = "0x169B660")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x169B6B0", Offset = "0x169B6B0", VA = "0x169B6B0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x169B9C4", Offset = "0x169B9C4", VA = "0x169B9C4")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x169BBB4", Offset = "0x169BBB4", VA = "0x169BBB4")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x169BF00", Offset = "0x169BF00", VA = "0x169BF00")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x169B874", Offset = "0x169B874", VA = "0x169B874")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x169B91C", Offset = "0x169B91C", VA = "0x169B91C")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200005C")]
	public class IKEffector
	{
		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643178", Offset = "0x643178")]
		public float positionWeight;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643190", Offset = "0x643190")]
		public float rotationWeight;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6431A8", Offset = "0x6431A8")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6431B8", Offset = "0x6431B8")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000032")]
		public bool isEndEffector
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x169C39C", Offset = "0x169C39C", VA = "0x169C39C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649D48", Offset = "0x649D48")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x169C3A4", Offset = "0x169C3A4", VA = "0x169C3A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649D58", Offset = "0x649D58")]
			private set
			{
			}
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x169C334", Offset = "0x169C334", VA = "0x169C334")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x169C3B0", Offset = "0x169C3B0", VA = "0x169C3B0")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x169C440", Offset = "0x169C440", VA = "0x169C440")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x169C584", Offset = "0x169C584", VA = "0x169C584")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x169C704", Offset = "0x169C704", VA = "0x169C704")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x169CA2C", Offset = "0x169CA2C", VA = "0x169CA2C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x169CCF8", Offset = "0x169CCF8", VA = "0x169CCF8")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x169CDCC", Offset = "0x169CDCC", VA = "0x169CDCC")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x169CE74", Offset = "0x169CE74", VA = "0x169CE74")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x169D3B0", Offset = "0x169D3B0", VA = "0x169D3B0")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x169D3DC", Offset = "0x169D3DC", VA = "0x169D3DC")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x169D53C", Offset = "0x169D53C", VA = "0x169D53C")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x169D7C8", Offset = "0x169D7C8", VA = "0x169D7C8")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200005D")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x200005E")]
		public class BoneMap
		{
			[Token(Token = "0x4000237")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000238")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x4000239")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x400023A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400023B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x400023C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x400023D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x400023E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x400023F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x4000240")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x4000241")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x4000242")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x4000243")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x4000244")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x4000245")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x4000246")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x4000247")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x4000248")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x4000249")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x400024A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x400024B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x400024C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x17000033")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x60002B2")]
				[Address(RVA = "0x1741454", Offset = "0x1741454", VA = "0x1741454")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000034")]
			public bool isNodeBone
			{
				[Token(Token = "0x60002B5")]
				[Address(RVA = "0x1741530", Offset = "0x1741530", VA = "0x1741530")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000035")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60002C9")]
				[Address(RVA = "0x1741900", Offset = "0x1741900", VA = "0x1741900")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x1741404", Offset = "0x1741404", VA = "0x1741404")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x1741490", Offset = "0x1741490", VA = "0x1741490")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x17414E0", Offset = "0x17414E0", VA = "0x17414E0")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x1741540", Offset = "0x1741540", VA = "0x1741540")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x17415C8", Offset = "0x17415C8", VA = "0x17415C8")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x17415D0", Offset = "0x17415D0", VA = "0x17415D0")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x17416A8", Offset = "0x17416A8", VA = "0x17416A8")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x1741720", Offset = "0x1741720", VA = "0x1741720")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x17417E4", Offset = "0x17417E4", VA = "0x17417E4")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x1741A40", Offset = "0x1741A40", VA = "0x1741A40")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x1741A78", Offset = "0x1741A78", VA = "0x1741A78")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x1741AB0", Offset = "0x1741AB0", VA = "0x1741AB0")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x1741AD8", Offset = "0x1741AD8", VA = "0x1741AD8")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x1741BC4", Offset = "0x1741BC4", VA = "0x1741BC4")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x1741D50", Offset = "0x1741D50", VA = "0x1741D50")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x1741D80", Offset = "0x1741D80", VA = "0x1741D80")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x1741E48", Offset = "0x1741E48", VA = "0x1741E48")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x1741EB8", Offset = "0x1741EB8", VA = "0x1741EB8")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x1742008", Offset = "0x1742008", VA = "0x1742008")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x1742158", Offset = "0x1742158", VA = "0x1742158")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x17421D8", Offset = "0x17421D8", VA = "0x17421D8")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x1741C40", Offset = "0x1741C40", VA = "0x1741C40")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x1742310", Offset = "0x1742310", VA = "0x1742310")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x169DC80", Offset = "0x169DC80", VA = "0x169DC80", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x169DC88", Offset = "0x169DC88", VA = "0x169DC88", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x169DC8C", Offset = "0x169DC8C", VA = "0x169DC8C")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x169DDDC", Offset = "0x169DDDC", VA = "0x169DDDC")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x169DE4C", Offset = "0x169DE4C", VA = "0x169DE4C")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005F")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6431D0", Offset = "0x6431D0")]
		public float maintainRotationWeight;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x169DE54", Offset = "0x169DE54", VA = "0x169DE54", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x169DF08", Offset = "0x169DF08", VA = "0x169DF08")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x169DF80", Offset = "0x169DF80", VA = "0x169DF80")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x169E014", Offset = "0x169E014", VA = "0x169E014")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x169E030", Offset = "0x169E030", VA = "0x169E030")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x169E050", Offset = "0x169E050", VA = "0x169E050", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x169E0E8", Offset = "0x169E0E8", VA = "0x169E0E8")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x169E104", Offset = "0x169E104", VA = "0x169E104")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000060")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000061")]
		public enum BoneMapType
		{
			[Token(Token = "0x400025C")]
			Parent,
			[Token(Token = "0x400025D")]
			Bone1,
			[Token(Token = "0x400025E")]
			Bone2,
			[Token(Token = "0x400025F")]
			Bone3
		}

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6431E8", Offset = "0x6431E8")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643200", Offset = "0x643200")]
		public float weight;

		[NonSerialized]
		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool updatePlaneRotations;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMapParent;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap1;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap2;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap boneMap3;

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x169E12C", Offset = "0x169E12C", VA = "0x169E12C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x169E1B0", Offset = "0x169E1B0", VA = "0x169E1B0")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x169E28C", Offset = "0x169E28C", VA = "0x169E28C")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x169E4B0", Offset = "0x169E4B0", VA = "0x169E4B0")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x169E5A4", Offset = "0x169E5A4", VA = "0x169E5A4")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x169E6D0", Offset = "0x169E6D0", VA = "0x169E6D0")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x169E734", Offset = "0x169E734", VA = "0x169E734")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x169E7E8", Offset = "0x169E7E8", VA = "0x169E7E8")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x169E8AC", Offset = "0x169E8AC", VA = "0x169E8AC", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x169EB44", Offset = "0x169EB44", VA = "0x169EB44")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x169EBB8", Offset = "0x169EBB8", VA = "0x169EBB8")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000062")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643218", Offset = "0x643218")]
		public int iterations;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643230", Offset = "0x643230")]
		public float twistWeight;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x169ED38", Offset = "0x169ED38", VA = "0x169ED38", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x169F0A4", Offset = "0x169F0A4", VA = "0x169F0A4")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x169F1C4", Offset = "0x169F1C4", VA = "0x169F1C4")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x169F324", Offset = "0x169F324", VA = "0x169F324")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x169F3A4", Offset = "0x169F3A4", VA = "0x169F3A4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x169F410", Offset = "0x169F410", VA = "0x169F410")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x169F494", Offset = "0x169F494", VA = "0x169F494", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x169FAD8", Offset = "0x169FAD8", VA = "0x169FAD8")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x169FB10", Offset = "0x169FB10", VA = "0x169FB10")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x169FD94", Offset = "0x169FD94", VA = "0x169FD94")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x16A009C", Offset = "0x16A009C", VA = "0x16A009C")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x16A0188", Offset = "0x16A0188", VA = "0x16A0188")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x16A0250", Offset = "0x16A0250", VA = "0x16A0250")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000063")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000064")]
		public class Point
		{
			[Token(Token = "0x4000277")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000278")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6432F4", Offset = "0x6432F4")]
			public float weight;

			[Token(Token = "0x4000279")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x400027A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x400027B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400027C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000301")]
			[Address(RVA = "0x1742E5C", Offset = "0x1742E5C", VA = "0x1742E5C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000302")]
			[Address(RVA = "0x1742EAC", Offset = "0x1742EAC", VA = "0x1742EAC")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000303")]
			[Address(RVA = "0x1742F4C", Offset = "0x1742F4C", VA = "0x1742F4C")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000304")]
			[Address(RVA = "0x1742F84", Offset = "0x1742F84", VA = "0x1742F84")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000305")]
			[Address(RVA = "0x1742FBC", Offset = "0x1742FBC", VA = "0x1742FBC")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000306")]
			[Address(RVA = "0x174300C", Offset = "0x174300C", VA = "0x174300C")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000307")]
			[Address(RVA = "0x1742A10", Offset = "0x1742A10", VA = "0x1742A10")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000065")]
		public class Bone : Point
		{
			[Token(Token = "0x400027D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x400027E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x400027F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x4000280")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x4000281")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x17000037")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x6000308")]
				[Address(RVA = "0x174232C", Offset = "0x174232C", VA = "0x174232C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000309")]
				[Address(RVA = "0x1742430", Offset = "0x1742430", VA = "0x1742430")]
				set
				{
				}
			}

			[Token(Token = "0x600030A")]
			[Address(RVA = "0x17424C0", Offset = "0x17424C0", VA = "0x17424C0")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600030B")]
			[Address(RVA = "0x1742670", Offset = "0x1742670", VA = "0x1742670")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600030C")]
			[Address(RVA = "0x1742844", Offset = "0x1742844", VA = "0x1742844")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600030D")]
			[Address(RVA = "0x17429A4", Offset = "0x17429A4", VA = "0x17429A4")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x600030E")]
			[Address(RVA = "0x17429CC", Offset = "0x17429CC", VA = "0x17429CC")]
			public Bone()
			{
			}

			[Token(Token = "0x600030F")]
			[Address(RVA = "0x1742A4C", Offset = "0x1742A4C", VA = "0x1742A4C")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000310")]
			[Address(RVA = "0x1742AA4", Offset = "0x1742AA4", VA = "0x1742AA4")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000066")]
		public class Node : Point
		{
			[Token(Token = "0x4000282")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000283")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x4000284")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x4000285")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x6000311")]
			[Address(RVA = "0x1742DE4", Offset = "0x1742DE4", VA = "0x1742DE4")]
			public Node()
			{
			}

			[Token(Token = "0x6000312")]
			[Address(RVA = "0x1742DE8", Offset = "0x1742DE8", VA = "0x1742DE8")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000313")]
			[Address(RVA = "0x1742E18", Offset = "0x1742E18", VA = "0x1742E18")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x2000067")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x2000068")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643258", Offset = "0x643258")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643258", Offset = "0x643258")]
		public float IKPositionWeight;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6432AC", Offset = "0x6432AC")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		protected Transform root;

		[Token(Token = "0x17000036")]
		public bool initiated
		{
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x17BCDE4", Offset = "0x17BCDE4", VA = "0x17BCDE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649D68", Offset = "0x649D68")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x17BCDEC", Offset = "0x17BCDEC", VA = "0x17BCDEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649D78", Offset = "0x649D78")]
			private set
			{
			}
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x17BCB24", Offset = "0x17BCB24", VA = "0x17BCB24")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60002EC")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x17BCB9C", Offset = "0x17BCB9C", VA = "0x17BCB9C")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x17BCD1C", Offset = "0x17BCD1C", VA = "0x17BCD1C")]
		public void Update()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x17BCD8C", Offset = "0x17BCD8C", VA = "0x17BCD8C", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x17BCD98", Offset = "0x17BCD98", VA = "0x17BCD98")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x17BCDA4", Offset = "0x17BCDA4", VA = "0x17BCDA4")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x17BCDAC", Offset = "0x17BCDAC", VA = "0x17BCDAC")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x17BCDDC", Offset = "0x17BCDDC", VA = "0x17BCDDC")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x60002F6")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x60002F7")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x60002F8")]
		public abstract void FixTransforms();

		[Token(Token = "0x60002F9")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x60002FA")]
		protected abstract void OnInitiate();

		[Token(Token = "0x60002FB")]
		protected abstract void OnUpdate();

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x17BCDF8", Offset = "0x17BCDF8", VA = "0x17BCDF8")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x17BCE10", Offset = "0x17BCE10", VA = "0x17BCE10")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x17BCF48", Offset = "0x17BCF48", VA = "0x17BCF48")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x17BCFF4", Offset = "0x17BCFF4", VA = "0x17BCFF4")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x17BD27C", Offset = "0x17BD27C", VA = "0x17BD27C")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000069")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64330C", Offset = "0x64330C")]
		public float poleWeight;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643324", Offset = "0x643324")]
		public float clampWeight;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64333C", Offset = "0x64333C")]
		public int clampSmoothing;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x17000038")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x17BD310", Offset = "0x17BD310", VA = "0x17BD310")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000039")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x17BD34C", Offset = "0x17BD34C", VA = "0x17BD34C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003A")]
		protected override int minBones
		{
			[Token(Token = "0x6000321")]
			[Address(RVA = "0x17BDDFC", Offset = "0x17BDDFC", VA = "0x17BDDFC", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003B")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x17BE1E0", Offset = "0x17BE1E0", VA = "0x17BE1E0", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x17BD294", Offset = "0x17BD294", VA = "0x17BD294")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x17BD388", Offset = "0x17BD388", VA = "0x17BD388", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x17BD5A8", Offset = "0x17BD5A8", VA = "0x17BD5A8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x17BDD48", Offset = "0x17BDD48", VA = "0x17BDD48")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x17BDAD8", Offset = "0x17BDAD8", VA = "0x17BDAD8")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x17BDE04", Offset = "0x17BDE04", VA = "0x17BDE04")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x17BE254", Offset = "0x17BE254", VA = "0x17BE254")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006A")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643354", Offset = "0x643354")]
		public float IKRotationWeight;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x17BE328", Offset = "0x17BE328", VA = "0x17BE328", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x17BE710", Offset = "0x17BE710", VA = "0x17BE710")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x17BE7C4", Offset = "0x17BE7C4", VA = "0x17BE7C4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x17BE958", Offset = "0x17BE958", VA = "0x17BE958", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x17BEAEC", Offset = "0x17BEAEC", VA = "0x17BEAEC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x17BEB48", Offset = "0x17BEB48", VA = "0x17BEB48", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x17BEBB8", Offset = "0x17BEBB8", VA = "0x17BEBB8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x17BEF28", Offset = "0x17BEF28", VA = "0x17BEF28", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x17BEF54", Offset = "0x17BEF54", VA = "0x17BEF54")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x17BEC1C", Offset = "0x17BEC1C", VA = "0x17BEC1C")]
		private void Read()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x17BEFC0", Offset = "0x17BEFC0", VA = "0x17BEFC0")]
		private void Write()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x17BF14C", Offset = "0x17BF14C", VA = "0x17BF14C")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006B")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x17BF310", Offset = "0x17BF310", VA = "0x17BF310")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x17BF3C0", Offset = "0x17BF3C0", VA = "0x17BF3C0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x17BF8B8", Offset = "0x17BF8B8", VA = "0x17BF8B8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x17BFEB0", Offset = "0x17BFEB0", VA = "0x17BFEB0")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x17C048C", Offset = "0x17C048C", VA = "0x17C048C")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006C")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x1700003C")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x600033D")]
			[Address(RVA = "0x17C13DC", Offset = "0x17C13DC", VA = "0x17C13DC", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x17C0490", Offset = "0x17C0490", VA = "0x17C0490")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x17C0A54", Offset = "0x17C0A54", VA = "0x17C0A54")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x17C0B94", Offset = "0x17C0B94", VA = "0x17C0B94", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x17C0C28", Offset = "0x17C0C28", VA = "0x17C0C28", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x17C111C", Offset = "0x17C111C", VA = "0x17C111C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x17C13E4", Offset = "0x17C13E4", VA = "0x17C13E4")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x17C056C", Offset = "0x17C056C", VA = "0x17C056C")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x17C0B40", Offset = "0x17C0B40", VA = "0x17C0B40")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x17C1380", Offset = "0x17C1380", VA = "0x17C1380")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x17C08C8", Offset = "0x17C08C8", VA = "0x17C08C8")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x17C1A34", Offset = "0x17C1A34", VA = "0x17C1A34")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x17C1AA8", Offset = "0x17C1AA8", VA = "0x17C1AA8")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x17C1B70", Offset = "0x17C1B70", VA = "0x17C1B70")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x17C1C20", Offset = "0x17C1C20", VA = "0x17C1C20")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x17C0ECC", Offset = "0x17C0ECC", VA = "0x17C0ECC")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x17C0FF4", Offset = "0x17C0FF4", VA = "0x17C0FF4")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x17C1D24", Offset = "0x17C1D24", VA = "0x17C1D24")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x17C1604", Offset = "0x17C1604", VA = "0x17C1604")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x17C0B30", Offset = "0x17C0B30", VA = "0x17C0B30")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x17C22B4", Offset = "0x17C22B4", VA = "0x17C22B4")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x17C1E68", Offset = "0x17C1E68", VA = "0x17C1E68")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x17C1460", Offset = "0x17C1460", VA = "0x17C1460")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x17C1540", Offset = "0x17C1540", VA = "0x17C1540")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x17C2380", Offset = "0x17C2380", VA = "0x17C2380")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006D")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64336C", Offset = "0x64336C")]
		public float rootPin;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x17C2414", Offset = "0x17C2414", VA = "0x17C2414", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x17C2AA0", Offset = "0x17C2AA0", VA = "0x17C2AA0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x17C2B38", Offset = "0x17C2B38", VA = "0x17C2B38", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x17C2BD8", Offset = "0x17C2BD8", VA = "0x17C2BD8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x17C2CE4", Offset = "0x17C2CE4", VA = "0x17C2CE4")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x17C2D80", Offset = "0x17C2D80", VA = "0x17C2D80", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x17C31B0", Offset = "0x17C31B0", VA = "0x17C31B0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x17C33C0", Offset = "0x17C33C0", VA = "0x17C33C0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x17C325C", Offset = "0x17C325C", VA = "0x17C325C")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x17C2F6C", Offset = "0x17C2F6C", VA = "0x17C2F6C")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x17C3458", Offset = "0x17C3458", VA = "0x17C3458")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006E")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643384", Offset = "0x643384")]
		public int iterations;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x17C34D8", Offset = "0x17C34D8", VA = "0x17C34D8")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x17C35C8", Offset = "0x17C35C8", VA = "0x17C35C8")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x17C3624", Offset = "0x17C3624", VA = "0x17C3624")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x17C3754", Offset = "0x17C3754", VA = "0x17C3754")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x17C37B0", Offset = "0x17C37B0", VA = "0x17C37B0")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x17C3830", Offset = "0x17C3830", VA = "0x17C3830", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x17C39DC", Offset = "0x17C39DC", VA = "0x17C39DC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x17C3B4C", Offset = "0x17C3B4C", VA = "0x17C3B4C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x17C3D5C", Offset = "0x17C3D5C", VA = "0x17C3D5C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x17C3E34", Offset = "0x17C3E34", VA = "0x17C3E34", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x17C3F20", Offset = "0x17C3F20", VA = "0x17C3F20", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x17C4094", Offset = "0x17C4094", VA = "0x17C4094", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x17C41EC", Offset = "0x17C41EC", VA = "0x17C41EC", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x17C4438", Offset = "0x17C4438", VA = "0x17C4438", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x17C4714", Offset = "0x17C4714", VA = "0x17C4714", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x17C4758", Offset = "0x17C4758", VA = "0x17C4758", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x17C4848", Offset = "0x17C4848", VA = "0x17C4848")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006F")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x40002B8")]
		Body,
		[Token(Token = "0x40002B9")]
		LeftShoulder,
		[Token(Token = "0x40002BA")]
		RightShoulder,
		[Token(Token = "0x40002BB")]
		LeftThigh,
		[Token(Token = "0x40002BC")]
		RightThigh,
		[Token(Token = "0x40002BD")]
		LeftHand,
		[Token(Token = "0x40002BE")]
		RightHand,
		[Token(Token = "0x40002BF")]
		LeftFoot,
		[Token(Token = "0x40002C0")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x2000070")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x40002C2")]
		LeftArm,
		[Token(Token = "0x40002C3")]
		RightArm,
		[Token(Token = "0x40002C4")]
		LeftLeg,
		[Token(Token = "0x40002C5")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x2000071")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64339C", Offset = "0x64339C")]
		public float spineStiffness;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6433B4", Offset = "0x6433B4")]
		public float pullBodyVertical;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6433CC", Offset = "0x6433CC")]
		public float pullBodyHorizontal;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6433E4", Offset = "0x6433E4")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x1700003D")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x17C4994", Offset = "0x17C4994", VA = "0x17C4994")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x17C4ADC", Offset = "0x17C4ADC", VA = "0x17C4ADC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x17C4AE4", Offset = "0x17C4AE4", VA = "0x17C4AE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x17C4AEC", Offset = "0x17C4AEC", VA = "0x17C4AEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x17C4AF4", Offset = "0x17C4AF4", VA = "0x17C4AF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x17C4AFC", Offset = "0x17C4AFC", VA = "0x17C4AFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x17C4B04", Offset = "0x17C4B04", VA = "0x17C4B04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x17C4B0C", Offset = "0x17C4B0C", VA = "0x17C4B0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x17C4B14", Offset = "0x17C4B14", VA = "0x17C4B14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x17C4B1C", Offset = "0x17C4B1C", VA = "0x17C4B1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x17C4B54", Offset = "0x17C4B54", VA = "0x17C4B54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x17C4B8C", Offset = "0x17C4B8C", VA = "0x17C4B8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x17C4BC4", Offset = "0x17C4BC4", VA = "0x17C4BC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x600037A")]
			[Address(RVA = "0x17C4BFC", Offset = "0x17C4BFC", VA = "0x17C4BFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x17C4C30", Offset = "0x17C4C30", VA = "0x17C4C30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x17C4C68", Offset = "0x17C4C68", VA = "0x17C4C68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x17C4CA0", Offset = "0x17C4CA0", VA = "0x17C4CA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x17C4CD8", Offset = "0x17C4CD8", VA = "0x17C4CD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x17C6E64", Offset = "0x17C6E64", VA = "0x17C6E64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649D88", Offset = "0x649D88")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x17C6E70", Offset = "0x17C6E70", VA = "0x17C6E70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649D98", Offset = "0x649D98")]
			private set
			{
			}
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x17C4D0C", Offset = "0x17C4D0C", VA = "0x17C4D0C")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x17C4E18", Offset = "0x17C4E18", VA = "0x17C4E18")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x17C4D60", Offset = "0x17C4D60", VA = "0x17C4D60")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x17C4EA4", Offset = "0x17C4EA4", VA = "0x17C4EA4")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x17C499C", Offset = "0x17C499C", VA = "0x17C499C")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x17C4F74", Offset = "0x17C4F74", VA = "0x17C4F74")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x17C502C", Offset = "0x17C502C", VA = "0x17C502C")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x17C50E0", Offset = "0x17C50E0", VA = "0x17C50E0")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x17C5194", Offset = "0x17C5194", VA = "0x17C5194")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x17C519C", Offset = "0x17C519C", VA = "0x17C519C")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x17C51D0", Offset = "0x17C51D0", VA = "0x17C51D0")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x17C5298", Offset = "0x17C5298", VA = "0x17C5298", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x17C5440", Offset = "0x17C5440", VA = "0x17C5440")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x17C68E0", Offset = "0x17C68E0", VA = "0x17C68E0")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x17C6CF4", Offset = "0x17C6CF4", VA = "0x17C6CF4")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x17C6D54", Offset = "0x17C6D54", VA = "0x17C6D54")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x17C6B7C", Offset = "0x17C6B7C", VA = "0x17C6B7C")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x17C6C38", Offset = "0x17C6C38", VA = "0x17C6C38")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x17C6E7C", Offset = "0x17C6E7C", VA = "0x17C6E7C")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x17C6F54", Offset = "0x17C6F54", VA = "0x17C6F54", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x17C7050", Offset = "0x17C7050", VA = "0x17C7050")]
		private void PullBody()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x17C7178", Offset = "0x17C7178", VA = "0x17C7178")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x17C72BC", Offset = "0x17C72BC", VA = "0x17C72BC")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x17C73EC", Offset = "0x17C73EC", VA = "0x17C73EC", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x17C762C", Offset = "0x17C762C", VA = "0x17C762C", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x17C76B0", Offset = "0x17C76B0", VA = "0x17C76B0")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000072")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x17000050")]
		protected virtual int minBones
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x17C7F64", Offset = "0x17C7F64", VA = "0x17C7F64", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000051")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x17C7F6C", Offset = "0x17C7F6C", VA = "0x17C7F6C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000052")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x17C7F74", Offset = "0x17C7F74", VA = "0x17C7F74", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000053")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x17C7F84", Offset = "0x17C7F84", VA = "0x17C7F84", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000054")]
		protected float positionOffset
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x17BFE5C", Offset = "0x17BFE5C", VA = "0x17BFE5C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x17C76BC", Offset = "0x17C76BC", VA = "0x17C76BC")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x17C7874", Offset = "0x17C7874", VA = "0x17C7874")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x17C79D4", Offset = "0x17C79D4", VA = "0x17C79D4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x17C7A40", Offset = "0x17C7A40", VA = "0x17C7A40", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x17C7AC0", Offset = "0x17C7AC0", VA = "0x17C7AC0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x17C7E6C", Offset = "0x17C7E6C", VA = "0x17C7E6C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x17C7E74", Offset = "0x17C7E74", VA = "0x17C7E74", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x17C7F7C", Offset = "0x17C7F7C", VA = "0x17C7F7C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x17C7F80", Offset = "0x17C7F80", VA = "0x17C7F80", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x17BF440", Offset = "0x17BF440", VA = "0x17BF440")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x17BFB44", Offset = "0x17BFB44", VA = "0x17BFB44")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x17C804C", Offset = "0x17C804C", VA = "0x17C804C")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x17BE2A4", Offset = "0x17BE2A4", VA = "0x17BE2A4")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000073")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6433F4", Offset = "0x6433F4")]
		public float IKRotationWeight;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x17C8240", Offset = "0x17C8240", VA = "0x17C8240", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x17C8628", Offset = "0x17C8628", VA = "0x17C8628")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x17C86DC", Offset = "0x17C86DC", VA = "0x17C86DC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x17C8870", Offset = "0x17C8870", VA = "0x17C8870", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x17C8A04", Offset = "0x17C8A04", VA = "0x17C8A04", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x17C8A60", Offset = "0x17C8A60", VA = "0x17C8A60", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x17C8AD0", Offset = "0x17C8AD0", VA = "0x17C8AD0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x17C8E40", Offset = "0x17C8E40", VA = "0x17C8E40", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x17C8E6C", Offset = "0x17C8E6C", VA = "0x17C8E6C")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x17C8B34", Offset = "0x17C8B34", VA = "0x17C8B34")]
		private void Read()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x17C8F00", Offset = "0x17C8F00", VA = "0x17C8F00")]
		private void Write()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x17C908C", Offset = "0x17C908C", VA = "0x17C908C")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000074")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x2000075")]
		public enum BendModifier
		{
			[Token(Token = "0x40002F0")]
			Animation,
			[Token(Token = "0x40002F1")]
			Target,
			[Token(Token = "0x40002F2")]
			Parent,
			[Token(Token = "0x40002F3")]
			Arm,
			[Token(Token = "0x40002F4")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x2000076")]
		public struct AxisDirection
		{
			[Token(Token = "0x40002F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x40002F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x40002F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x17432B4", Offset = "0x17432B4", VA = "0x17432B4")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64340C", Offset = "0x64340C")]
		public float maintainRotationWeight;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643424", Offset = "0x643424")]
		public float bendModifierWeight;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000055")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x17CA3D4", Offset = "0x17CA3D4", VA = "0x17CA3D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x17C9250", Offset = "0x17C9250", VA = "0x17C9250")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x17C92A0", Offset = "0x17C92A0", VA = "0x17C92A0")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x17C92EC", Offset = "0x17C92EC", VA = "0x17C92EC", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x17C97C0", Offset = "0x17C97C0", VA = "0x17C97C0", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x17CA10C", Offset = "0x17CA10C", VA = "0x17CA10C", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x17CA1B8", Offset = "0x17CA1B8", VA = "0x17CA1B8")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x17CA338", Offset = "0x17CA338", VA = "0x17CA338")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x17C95E8", Offset = "0x17C95E8", VA = "0x17C95E8")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x17C98A4", Offset = "0x17C98A4", VA = "0x17C98A4")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000077")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000078")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x4000308")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 baseForwardOffsetEuler;

			[Token(Token = "0x1700005C")]
			public Vector3 forward
			{
				[Token(Token = "0x60003E2")]
				[Address(RVA = "0x1743548", Offset = "0x1743548", VA = "0x1743548")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x1743314", Offset = "0x1743314", VA = "0x1743314")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x1743318", Offset = "0x1743318", VA = "0x1743318")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x1743348", Offset = "0x1743348", VA = "0x1743348")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x1743440", Offset = "0x1743440", VA = "0x1743440")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64343C", Offset = "0x64343C")]
		public float bodyWeight;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643454", Offset = "0x643454")]
		public float headWeight;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64346C", Offset = "0x64346C")]
		public float eyesWeight;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643484", Offset = "0x643484")]
		public float clampWeight;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64349C", Offset = "0x64349C")]
		public float clampWeightHead;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6434B4", Offset = "0x6434B4")]
		public float clampWeightEyes;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6434CC", Offset = "0x6434CC")]
		public int clampSmoothing;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Vector3[] spineForwards;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected Vector3[] headForwards;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected Vector3[] eyeForward;

		[Token(Token = "0x17000056")]
		protected bool spineIsValid
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x17CAB78", Offset = "0x17CAB78", VA = "0x17CAB78")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000057")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x17CAD48", Offset = "0x17CAD48", VA = "0x17CAD48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000058")]
		protected bool headIsValid
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x17CAC58", Offset = "0x17CAC58", VA = "0x17CAC58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000059")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x17CAD6C", Offset = "0x17CAD6C", VA = "0x17CAD6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005A")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x17CAC68", Offset = "0x17CAC68", VA = "0x17CAC68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x17CADE4", Offset = "0x17CADE4", VA = "0x17CADE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x17CA3F0", Offset = "0x17CA3F0", VA = "0x17CA3F0")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x17CA420", Offset = "0x17CA420", VA = "0x17CA420")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x17CA478", Offset = "0x17CA478", VA = "0x17CA478")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x17CA4F4", Offset = "0x17CA4F4", VA = "0x17CA4F4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x17CA58C", Offset = "0x17CA58C", VA = "0x17CA58C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x17CA64C", Offset = "0x17CA64C", VA = "0x17CA64C")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x17CA748", Offset = "0x17CA748", VA = "0x17CA748", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x17CA874", Offset = "0x17CA874", VA = "0x17CA874", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x17CA9B4", Offset = "0x17CA9B4", VA = "0x17CA9B4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x17CAE08", Offset = "0x17CAE08", VA = "0x17CAE08", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x17CB078", Offset = "0x17CB078", VA = "0x17CB078", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x17CB214", Offset = "0x17CB214", VA = "0x17CB214")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x17CB474", Offset = "0x17CB474", VA = "0x17CB474", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x17CB788", Offset = "0x17CB788", VA = "0x17CB788", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x17CB858", Offset = "0x17CB858", VA = "0x17CB858")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x17CB9F8", Offset = "0x17CB9F8", VA = "0x17CB9F8")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x17CBC1C", Offset = "0x17CBC1C", VA = "0x17CBC1C")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x17CBFD0", Offset = "0x17CBFD0", VA = "0x17CBFD0")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x17CB2C8", Offset = "0x17CB2C8", VA = "0x17CB2C8")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x17CC240", Offset = "0x17CC240", VA = "0x17CC240")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000079")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200007A")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x4000312")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x4000313")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x1743584", Offset = "0x1743584", VA = "0x1743584")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x1743680", Offset = "0x1743680", VA = "0x1743680")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x17436B0", Offset = "0x17436B0", VA = "0x17436B0")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x17436EC", Offset = "0x17436EC", VA = "0x17436EC")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6434E4", Offset = "0x6434E4")]
		public float IKRotationWeight;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x17CC4B4", Offset = "0x17CC4B4", VA = "0x17CC4B4")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x17CC610", Offset = "0x17CC610", VA = "0x17CC610")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x17CC754", Offset = "0x17CC754", VA = "0x17CC754")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x17CC760", Offset = "0x17CC760", VA = "0x17CC760")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x17CC790", Offset = "0x17CC790", VA = "0x17CC790")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x17CC79C", Offset = "0x17CC79C", VA = "0x17CC79C")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x17CC7A4", Offset = "0x17CC7A4", VA = "0x17CC7A4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x17CC8C8", Offset = "0x17CC8C8", VA = "0x17CC8C8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x17CC9E4", Offset = "0x17CC9E4", VA = "0x17CC9E4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x17CCA30", Offset = "0x17CCA30", VA = "0x17CCA30", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x17CCA90", Offset = "0x17CCA90", VA = "0x17CCA90", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x17CCE88", Offset = "0x17CCE88", VA = "0x17CCE88")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x17CCF04", Offset = "0x17CCF04", VA = "0x17CCF04")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x17CD2C0", Offset = "0x17CD2C0", VA = "0x17CD2C0")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x17CD428", Offset = "0x17CD428", VA = "0x17CD428", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x17CD590", Offset = "0x17CD590", VA = "0x17CD590")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x17CD504", Offset = "0x17CD504", VA = "0x17CD504")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x17CD694", Offset = "0x17CD694", VA = "0x17CD694", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x17CDE6C", Offset = "0x17CDE6C", VA = "0x17CDE6C", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x17CDE70", Offset = "0x17CDE70", VA = "0x17CDE70", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x17CDE74", Offset = "0x17CDE74", VA = "0x17CDE74", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x17CDC84", Offset = "0x17CDC84", VA = "0x17CDC84")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x17CA240", Offset = "0x17CA240", VA = "0x17CA240")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007B")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200007C")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x200007D")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x4000356")]
				YawPitch,
				[Token(Token = "0x4000357")]
				FromTo
			}

			[Token(Token = "0x4000338")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6436E8", Offset = "0x6436E8")]
			public Transform target;

			[Token(Token = "0x4000339")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643720", Offset = "0x643720")]
			public Transform bendGoal;

			[Token(Token = "0x400033A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643758", Offset = "0x643758")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643758", Offset = "0x643758")]
			public float positionWeight;

			[Token(Token = "0x400033B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6437AC", Offset = "0x6437AC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6437AC", Offset = "0x6437AC")]
			public float rotationWeight;

			[Token(Token = "0x400033C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643800", Offset = "0x643800")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x400033D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643838", Offset = "0x643838")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643838", Offset = "0x643838")]
			public float shoulderRotationWeight;

			[Token(Token = "0x400033E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64388C", Offset = "0x64388C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64388C", Offset = "0x64388C")]
			public float shoulderTwistWeight;

			[Token(Token = "0x400033F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6438E0", Offset = "0x6438E0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6438E0", Offset = "0x6438E0")]
			public float bendGoalWeight;

			[Token(Token = "0x4000340")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643934", Offset = "0x643934")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643934", Offset = "0x643934")]
			public float swivelOffset;

			[Token(Token = "0x4000341")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643990", Offset = "0x643990")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000342")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6439C8", Offset = "0x6439C8")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x4000343")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643A00", Offset = "0x643A00")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643A00", Offset = "0x643A00")]
			public float armLengthMlp;

			[Token(Token = "0x4000344")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643A58", Offset = "0x643A58")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000345")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000346")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000347")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x4000348")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x4000349")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643AD0", Offset = "0x643AD0")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x400034A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643AE0", Offset = "0x643AE0")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x400034B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x400034C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x400034D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x400034E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x400034F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x4000350")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x4000351")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x4000352")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x4000353")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x4000354")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x1700005E")]
			public Vector3 position
			{
				[Token(Token = "0x600041C")]
				[Address(RVA = "0x17436F0", Offset = "0x17436F0", VA = "0x17436F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649DC8", Offset = "0x649DC8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600041D")]
				[Address(RVA = "0x17436FC", Offset = "0x17436FC", VA = "0x17436FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649DD8", Offset = "0x649DD8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700005F")]
			public Quaternion rotation
			{
				[Token(Token = "0x600041E")]
				[Address(RVA = "0x1743708", Offset = "0x1743708", VA = "0x1743708")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649DE8", Offset = "0x649DE8")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600041F")]
				[Address(RVA = "0x1743714", Offset = "0x1743714", VA = "0x1743714")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649DF8", Offset = "0x649DF8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000060")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000420")]
				[Address(RVA = "0x1743720", Offset = "0x1743720", VA = "0x1743720")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000061")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000421")]
				[Address(RVA = "0x1743754", Offset = "0x1743754", VA = "0x1743754")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000062")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000422")]
				[Address(RVA = "0x1743794", Offset = "0x1743794", VA = "0x1743794")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000063")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000423")]
				[Address(RVA = "0x17437E0", Offset = "0x17437E0", VA = "0x17437E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000424")]
			[Address(RVA = "0x174382C", Offset = "0x174382C", VA = "0x174382C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000425")]
			[Address(RVA = "0x174415C", Offset = "0x174415C", VA = "0x174415C", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000426")]
			[Address(RVA = "0x1744318", Offset = "0x1744318", VA = "0x1744318", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000427")]
			[Address(RVA = "0x174433C", Offset = "0x174433C", VA = "0x174433C")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000428")]
			[Address(RVA = "0x17445DC", Offset = "0x17445DC", VA = "0x17445DC")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000429")]
			[Address(RVA = "0x174605C", Offset = "0x174605C", VA = "0x174605C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600042A")]
			[Address(RVA = "0x1746088", Offset = "0x1746088", VA = "0x1746088", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600042B")]
			[Address(RVA = "0x174555C", Offset = "0x174555C", VA = "0x174555C")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x600042C")]
			[Address(RVA = "0x1745714", Offset = "0x1745714", VA = "0x1745714")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600042D")]
			[Address(RVA = "0x17462A8", Offset = "0x17462A8", VA = "0x17462A8")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x600042E")]
			[Address(RVA = "0x17463CC", Offset = "0x17463CC", VA = "0x17463CC")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007E")]
		public abstract class BodyPart
		{
			[Token(Token = "0x4000358")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643AF0", Offset = "0x643AF0")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x4000359")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643B00", Offset = "0x643B00")]
			private float <mag>k__BackingField;

			[Token(Token = "0x400035A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x400035B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x400035C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x400035D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x400035E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x400035F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			protected int LOD;

			[Token(Token = "0x17000064")]
			public float sqrMag
			{
				[Token(Token = "0x6000434")]
				[Address(RVA = "0x174653C", Offset = "0x174653C", VA = "0x174653C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649E08", Offset = "0x649E08")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000435")]
				[Address(RVA = "0x1746544", Offset = "0x1746544", VA = "0x1746544")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649E18", Offset = "0x649E18")]
				private set
				{
				}
			}

			[Token(Token = "0x17000065")]
			public float mag
			{
				[Token(Token = "0x6000436")]
				[Address(RVA = "0x174654C", Offset = "0x174654C", VA = "0x174654C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649E28", Offset = "0x649E28")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000437")]
				[Address(RVA = "0x1746554", Offset = "0x1746554", VA = "0x1746554")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649E38", Offset = "0x649E38")]
				private set
				{
				}
			}

			[Token(Token = "0x600042F")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x6000430")]
			public abstract void PreSolve();

			[Token(Token = "0x6000431")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x6000432")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x6000433")]
			public abstract void ResetOffsets();

			[Token(Token = "0x6000438")]
			[Address(RVA = "0x174655C", Offset = "0x174655C", VA = "0x174655C")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x6000439")]
			[Address(RVA = "0x1746564", Offset = "0x1746564", VA = "0x1746564")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0x1746824", Offset = "0x1746824", VA = "0x1746824")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x600043B")]
			[Address(RVA = "0x17468B8", Offset = "0x17468B8", VA = "0x17468B8")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x600043C")]
			[Address(RVA = "0x1746A88", Offset = "0x1746A88", VA = "0x1746A88")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600043D")]
			[Address(RVA = "0x1746ADC", Offset = "0x1746ADC", VA = "0x1746ADC")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x600043E")]
			[Address(RVA = "0x1745F1C", Offset = "0x1745F1C", VA = "0x1745F1C")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x600043F")]
			[Address(RVA = "0x1746C14", Offset = "0x1746C14", VA = "0x1746C14")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0x1746D54", Offset = "0x1746D54", VA = "0x1746D54")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000441")]
			[Address(RVA = "0x17464BC", Offset = "0x17464BC", VA = "0x17464BC")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007F")]
		public class Footstep
		{
			[Token(Token = "0x4000360")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x4000361")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643B20", Offset = "0x643B20")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x17000066")]
			public bool isStepping
			{
				[Token(Token = "0x6000442")]
				[Address(RVA = "0x1746D7C", Offset = "0x1746D7C", VA = "0x1746D7C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000067")]
			public float stepProgress
			{
				[Token(Token = "0x6000443")]
				[Address(RVA = "0x1746D90", Offset = "0x1746D90", VA = "0x1746D90")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649E48", Offset = "0x649E48")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000444")]
				[Address(RVA = "0x1746D98", Offset = "0x1746D98", VA = "0x1746D98")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649E58", Offset = "0x649E58")]
				private set
				{
				}
			}

			[Token(Token = "0x6000445")]
			[Address(RVA = "0x1746DA0", Offset = "0x1746DA0", VA = "0x1746DA0")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000446")]
			[Address(RVA = "0x1746ED8", Offset = "0x1746ED8", VA = "0x1746ED8")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000447")]
			[Address(RVA = "0x1746F20", Offset = "0x1746F20", VA = "0x1746F20")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x6000448")]
			[Address(RVA = "0x17470E4", Offset = "0x17470E4", VA = "0x17470E4")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000449")]
			[Address(RVA = "0x1747258", Offset = "0x1747258", VA = "0x1747258")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x600044A")]
			[Address(RVA = "0x17473B0", Offset = "0x17473B0", VA = "0x17473B0")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000080")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643B30", Offset = "0x643B30")]
			public Transform target;

			[Token(Token = "0x400036F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643B68", Offset = "0x643B68")]
			public Transform bendGoal;

			[Token(Token = "0x4000370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643BA0", Offset = "0x643BA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643BA0", Offset = "0x643BA0")]
			public float positionWeight;

			[Token(Token = "0x4000371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643BF4", Offset = "0x643BF4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643BF4", Offset = "0x643BF4")]
			public float rotationWeight;

			[Token(Token = "0x4000372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643C48", Offset = "0x643C48")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643C48", Offset = "0x643C48")]
			public float bendGoalWeight;

			[Token(Token = "0x4000373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643C9C", Offset = "0x643C9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643C9C", Offset = "0x643C9C")]
			public float swivelOffset;

			[Token(Token = "0x4000374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643CF8", Offset = "0x643CF8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643CF8", Offset = "0x643CF8")]
			public float bendToTargetWeight;

			[Token(Token = "0x4000375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643D4C", Offset = "0x643D4C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643D4C", Offset = "0x643D4C")]
			public float legLengthMlp;

			[Token(Token = "0x4000376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643DA4", Offset = "0x643DA4")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000377")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000379")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400037A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400037B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400037C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x400037D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x400037E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643E4C", Offset = "0x643E4C")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x400037F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643E5C", Offset = "0x643E5C")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000380")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643E6C", Offset = "0x643E6C")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x4000381")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643E7C", Offset = "0x643E7C")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x4000385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x4000386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x4000387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x4000388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x17000068")]
			public Vector3 position
			{
				[Token(Token = "0x600044B")]
				[Address(RVA = "0x17474EC", Offset = "0x17474EC", VA = "0x17474EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649E68", Offset = "0x649E68")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600044C")]
				[Address(RVA = "0x17474F8", Offset = "0x17474F8", VA = "0x17474F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649E78", Offset = "0x649E78")]
				private set
				{
				}
			}

			[Token(Token = "0x17000069")]
			public Quaternion rotation
			{
				[Token(Token = "0x600044D")]
				[Address(RVA = "0x1747504", Offset = "0x1747504", VA = "0x1747504")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649E88", Offset = "0x649E88")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600044E")]
				[Address(RVA = "0x1747510", Offset = "0x1747510", VA = "0x1747510")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649E98", Offset = "0x649E98")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006A")]
			public bool hasToes
			{
				[Token(Token = "0x600044F")]
				[Address(RVA = "0x174751C", Offset = "0x174751C", VA = "0x174751C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649EA8", Offset = "0x649EA8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000450")]
				[Address(RVA = "0x1747524", Offset = "0x1747524", VA = "0x1747524")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649EB8", Offset = "0x649EB8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006B")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000451")]
				[Address(RVA = "0x1747530", Offset = "0x1747530", VA = "0x1747530")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006C")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000452")]
				[Address(RVA = "0x1747564", Offset = "0x1747564", VA = "0x1747564")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006D")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000453")]
				[Address(RVA = "0x174759C", Offset = "0x174759C", VA = "0x174759C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006E")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000454")]
				[Address(RVA = "0x17475D4", Offset = "0x17475D4", VA = "0x17475D4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006F")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000455")]
				[Address(RVA = "0x174760C", Offset = "0x174760C", VA = "0x174760C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000070")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000456")]
				[Address(RVA = "0x174764C", Offset = "0x174764C", VA = "0x174764C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649EC8", Offset = "0x649EC8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000457")]
				[Address(RVA = "0x1747658", Offset = "0x1747658", VA = "0x1747658")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649ED8", Offset = "0x649ED8")]
				private set
				{
				}
			}

			[Token(Token = "0x6000458")]
			[Address(RVA = "0x1747664", Offset = "0x1747664", VA = "0x1747664", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000459")]
			[Address(RVA = "0x1747C84", Offset = "0x1747C84", VA = "0x1747C84", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600045A")]
			[Address(RVA = "0x1748240", Offset = "0x1748240", VA = "0x1748240", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x600045B")]
			[Address(RVA = "0x17481F0", Offset = "0x17481F0", VA = "0x17481F0")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x600045C")]
			[Address(RVA = "0x1748080", Offset = "0x1748080", VA = "0x1748080")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x600045D")]
			[Address(RVA = "0x1748628", Offset = "0x1748628", VA = "0x1748628")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x600045E")]
			[Address(RVA = "0x1748AD0", Offset = "0x1748AD0", VA = "0x1748AD0")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x600045F")]
			[Address(RVA = "0x17487B0", Offset = "0x17487B0", VA = "0x17487B0")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000460")]
			[Address(RVA = "0x1748DC8", Offset = "0x1748DC8", VA = "0x1748DC8", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0x1748FE4", Offset = "0x1748FE4", VA = "0x1748FE4", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0x1749030", Offset = "0x1749030", VA = "0x1749030")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000081")]
		public class Locomotion
		{
			[Token(Token = "0x4000389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x643E8C", Offset = "0x643E8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643E8C", Offset = "0x643E8C")]
			public float weight;

			[Token(Token = "0x400038A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643EE0", Offset = "0x643EE0")]
			public float footDistance;

			[Token(Token = "0x400038B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643F18", Offset = "0x643F18")]
			public float stepThreshold;

			[Token(Token = "0x400038C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643F50", Offset = "0x643F50")]
			public float angleThreshold;

			[Token(Token = "0x400038D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643F88", Offset = "0x643F88")]
			public float comAngleMlp;

			[Token(Token = "0x400038E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643FC0", Offset = "0x643FC0")]
			public float maxVelocity;

			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643FF8", Offset = "0x643FF8")]
			public float velocityFactor;

			[Token(Token = "0x4000390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644030", Offset = "0x644030")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x644030", Offset = "0x644030")]
			public float maxLegStretch;

			[Token(Token = "0x4000391")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644088", Offset = "0x644088")]
			public float rootSpeed;

			[Token(Token = "0x4000392")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6440C0", Offset = "0x6440C0")]
			public float stepSpeed;

			[Token(Token = "0x4000393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6440F8", Offset = "0x6440F8")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644130", Offset = "0x644130")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644168", Offset = "0x644168")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x644168", Offset = "0x644168")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6441C0", Offset = "0x6441C0")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6441F8", Offset = "0x6441F8")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644230", Offset = "0x644230")]
			public Vector3 offset;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6442A8", Offset = "0x6442A8")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6442E0", Offset = "0x6442E0")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x644318", Offset = "0x644318")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x17000071")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x6000463")]
				[Address(RVA = "0x174910C", Offset = "0x174910C", VA = "0x174910C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649EE8", Offset = "0x649EE8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000464")]
				[Address(RVA = "0x1749118", Offset = "0x1749118", VA = "0x1749118")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649EF8", Offset = "0x649EF8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000072")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x600046A")]
				[Address(RVA = "0x174AC24", Offset = "0x174AC24", VA = "0x174AC24")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000073")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x600046B")]
				[Address(RVA = "0x174AC64", Offset = "0x174AC64", VA = "0x174AC64")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000074")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x600046C")]
				[Address(RVA = "0x174ACA8", Offset = "0x174ACA8", VA = "0x174ACA8")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000075")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x600046D")]
				[Address(RVA = "0x174ACE8", Offset = "0x174ACE8", VA = "0x174ACE8")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000465")]
			[Address(RVA = "0x1749124", Offset = "0x1749124", VA = "0x1749124")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x6000466")]
			[Address(RVA = "0x17493E4", Offset = "0x17493E4", VA = "0x17493E4")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000467")]
			[Address(RVA = "0x17495B4", Offset = "0x17495B4", VA = "0x17495B4")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000468")]
			[Address(RVA = "0x17497FC", Offset = "0x17497FC", VA = "0x17497FC")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0x17498C0", Offset = "0x17498C0", VA = "0x17498C0")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x600046E")]
			[Address(RVA = "0x174A99C", Offset = "0x174A99C", VA = "0x174A99C")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x600046F")]
			[Address(RVA = "0x174AAD4", Offset = "0x174AAD4", VA = "0x174AAD4")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000470")]
			[Address(RVA = "0x174AB58", Offset = "0x174AB58", VA = "0x174AB58")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000471")]
			[Address(RVA = "0x174AD2C", Offset = "0x174AD2C", VA = "0x174AD2C")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000082")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644328", Offset = "0x644328")]
			public Transform headTarget;

			[Token(Token = "0x40003A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644360", Offset = "0x644360")]
			public Transform pelvisTarget;

			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644398", Offset = "0x644398")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x644398", Offset = "0x644398")]
			public float positionWeight;

			[Token(Token = "0x40003A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6443EC", Offset = "0x6443EC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6443EC", Offset = "0x6443EC")]
			public float rotationWeight;

			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644440", Offset = "0x644440")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x644440", Offset = "0x644440")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644494", Offset = "0x644494")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x644494", Offset = "0x644494")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6444E8", Offset = "0x6444E8")]
			public Transform chestGoal;

			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644520", Offset = "0x644520")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x644520", Offset = "0x644520")]
			public float chestGoalWeight;

			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644574", Offset = "0x644574")]
			public float minHeadHeight;

			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6445AC", Offset = "0x6445AC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6445AC", Offset = "0x6445AC")]
			public float bodyPosStiffness;

			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644600", Offset = "0x644600")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x644600", Offset = "0x644600")]
			public float bodyRotStiffness;

			[Token(Token = "0x40003B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x644654", Offset = "0x644654")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644654", Offset = "0x644654")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x644654", Offset = "0x644654")]
			public float neckStiffness;

			[Token(Token = "0x40003B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6446CC", Offset = "0x6446CC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6446CC", Offset = "0x6446CC")]
			public float rotateChestByHands;

			[Token(Token = "0x40003B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644720", Offset = "0x644720")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x644720", Offset = "0x644720")]
			public float chestClampWeight;

			[Token(Token = "0x40003B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644774", Offset = "0x644774")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x644774", Offset = "0x644774")]
			public float headClampWeight;

			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6447C8", Offset = "0x6447C8")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x644800", Offset = "0x644800")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644800", Offset = "0x644800")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x644854", Offset = "0x644854")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644854", Offset = "0x644854")]
			public float maxRootAngle;

			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6448AC", Offset = "0x6448AC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6448AC", Offset = "0x6448AC")]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x40003C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6449E8", Offset = "0x6449E8")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6449F8", Offset = "0x6449F8")]
			private Quaternion <anchorRelativeToHead>k__BackingField;

			[Token(Token = "0x40003C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private Quaternion headRotation;

			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int pelvisIndex;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int spineIndex;

			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int chestIndex;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int neckIndex;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private int headIndex;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private float length;

			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private bool hasChest;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x211")]
			private bool hasNeck;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x212")]
			private bool hasLegs;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float headHeight;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private float sizeMlp;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			private Vector3 chestForward;

			[Token(Token = "0x17000076")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x6000472")]
				[Address(RVA = "0x174A91C", Offset = "0x174A91C", VA = "0x174A91C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000077")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000473")]
				[Address(RVA = "0x174AE3C", Offset = "0x174AE3C", VA = "0x174AE3C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000078")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000474")]
				[Address(RVA = "0x174AE7C", Offset = "0x174AE7C", VA = "0x174AE7C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000079")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000475")]
				[Address(RVA = "0x174AED0", Offset = "0x174AED0", VA = "0x174AED0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007A")]
			public VirtualBone head
			{
				[Token(Token = "0x6000476")]
				[Address(RVA = "0x174A95C", Offset = "0x174A95C", VA = "0x174A95C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000477")]
				[Address(RVA = "0x174AF10", Offset = "0x174AF10", VA = "0x174AF10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649F08", Offset = "0x649F08")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000478")]
				[Address(RVA = "0x174AF24", Offset = "0x174AF24", VA = "0x174AF24")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649F18", Offset = "0x649F18")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007C")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x6000479")]
				[Address(RVA = "0x174AF38", Offset = "0x174AF38", VA = "0x174AF38")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649F28", Offset = "0x649F28")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600047A")]
				[Address(RVA = "0x174AF4C", Offset = "0x174AF4C", VA = "0x174AF4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649F38", Offset = "0x649F38")]
				private set
				{
				}
			}

			[Token(Token = "0x600047B")]
			[Address(RVA = "0x174AF60", Offset = "0x174AF60", VA = "0x174AF60", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600047C")]
			[Address(RVA = "0x174B9AC", Offset = "0x174B9AC", VA = "0x174B9AC", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0x174BBB8", Offset = "0x174BBB8", VA = "0x174BBB8", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x600047E")]
			[Address(RVA = "0x174BFFC", Offset = "0x174BFFC", VA = "0x174BFFC")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x600047F")]
			[Address(RVA = "0x174C438", Offset = "0x174C438", VA = "0x174C438")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000480")]
			[Address(RVA = "0x174CB8C", Offset = "0x174CB8C", VA = "0x174CB8C")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x6000481")]
			[Address(RVA = "0x174D20C", Offset = "0x174D20C", VA = "0x174D20C")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000482")]
			[Address(RVA = "0x174D80C", Offset = "0x174D80C", VA = "0x174D80C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000483")]
			[Address(RVA = "0x174D9E8", Offset = "0x174D9E8", VA = "0x174D9E8", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000484")]
			[Address(RVA = "0x174C194", Offset = "0x174C194", VA = "0x174C194")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000485")]
			[Address(RVA = "0x174CF5C", Offset = "0x174CF5C", VA = "0x174CF5C")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000486")]
			[Address(RVA = "0x174C848", Offset = "0x174C848", VA = "0x174C848")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x6000487")]
			[Address(RVA = "0x174DA80", Offset = "0x174DA80", VA = "0x174DA80")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000488")]
			[Address(RVA = "0x174D038", Offset = "0x174D038", VA = "0x174D038")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000489")]
			[Address(RVA = "0x174CD08", Offset = "0x174CD08", VA = "0x174CD08")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0x174DC74", Offset = "0x174DC74", VA = "0x174DC74")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000083")]
		public enum PositionOffset
		{
			[Token(Token = "0x40003DD")]
			Pelvis,
			[Token(Token = "0x40003DE")]
			Chest,
			[Token(Token = "0x40003DF")]
			Head,
			[Token(Token = "0x40003E0")]
			LeftHand,
			[Token(Token = "0x40003E1")]
			RightHand,
			[Token(Token = "0x40003E2")]
			LeftFoot,
			[Token(Token = "0x40003E3")]
			RightFoot,
			[Token(Token = "0x40003E4")]
			LeftHeel,
			[Token(Token = "0x40003E5")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x2000084")]
		public enum RotationOffset
		{
			[Token(Token = "0x40003E7")]
			Pelvis,
			[Token(Token = "0x40003E8")]
			Chest,
			[Token(Token = "0x40003E9")]
			Head
		}

		[Serializable]
		[Token(Token = "0x2000085")]
		public class VirtualBone
		{
			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x600048B")]
			[Address(RVA = "0x17440C0", Offset = "0x17440C0", VA = "0x17440C0")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600048C")]
			[Address(RVA = "0x174413C", Offset = "0x174413C", VA = "0x174413C")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0x174DDE4", Offset = "0x174DDE4", VA = "0x174DDE4")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600048E")]
			[Address(RVA = "0x1746634", Offset = "0x1746634", VA = "0x1746634")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x600048F")]
			[Address(RVA = "0x1746960", Offset = "0x1746960", VA = "0x1746960")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000490")]
			[Address(RVA = "0x174DF68", Offset = "0x174DF68", VA = "0x174DF68")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000491")]
			[Address(RVA = "0x17455D8", Offset = "0x17455D8", VA = "0x17455D8")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0x174E0C8", Offset = "0x174E0C8", VA = "0x174E0C8")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000493")]
			[Address(RVA = "0x1745B18", Offset = "0x1745B18", VA = "0x1745B18")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0x174E180", Offset = "0x174E180", VA = "0x174E180")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000495")]
			[Address(RVA = "0x174D47C", Offset = "0x174D47C", VA = "0x174D47C")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000496")]
			[Address(RVA = "0x174E2E8", Offset = "0x174E2E8", VA = "0x174E2E8")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000497")]
			[Address(RVA = "0x174E358", Offset = "0x174E358", VA = "0x174E358")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int lastLOD;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6434FC", Offset = "0x6434FC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6434FC", Offset = "0x6434FC")]
		public int LOD;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643550", Offset = "0x643550")]
		public bool plantFeet;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643588", Offset = "0x643588")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643598", Offset = "0x643598")]
		public Spine spine;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6435D0", Offset = "0x6435D0")]
		public Arm leftArm;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643608", Offset = "0x643608")]
		public Arm rightArm;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643640", Offset = "0x643640")]
		public Leg leftLeg;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x643678", Offset = "0x643678")]
		public Leg rightLeg;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6436B0", Offset = "0x6436B0")]
		public Locomotion locomotion;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Leg[] legs;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Arm[] arms;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 headPosition;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private Vector3 lastOffset;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector3 debugPos1;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Vector3 debugPos2;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 debugPos3;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Vector3 debugPos4;

		[Token(Token = "0x1700005D")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x6000417")]
			[Address(RVA = "0x12C1210", Offset = "0x12C1210", VA = "0x12C1210")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649DA8", Offset = "0x649DA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000418")]
			[Address(RVA = "0x12C1218", Offset = "0x12C1218", VA = "0x12C1218")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649DB8", Offset = "0x649DB8")]
			private set
			{
			}
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x12BD5F0", Offset = "0x12BD5F0", VA = "0x12BD5F0")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x12BDAAC", Offset = "0x12BDAAC", VA = "0x12BDAAC")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x12BD938", Offset = "0x12BD938", VA = "0x12BD938")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x12BE20C", Offset = "0x12BE20C", VA = "0x12BE20C")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x12BE350", Offset = "0x12BE350", VA = "0x12BE350")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x12BE380", Offset = "0x12BE380", VA = "0x12BE380")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x12BE430", Offset = "0x12BE430", VA = "0x12BE430")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x12BE518", Offset = "0x12BE518", VA = "0x12BE518")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x12BECD0", Offset = "0x12BECD0", VA = "0x12BECD0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x12BEE40", Offset = "0x12BEE40", VA = "0x12BEE40", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x12BF044", Offset = "0x12BF044", VA = "0x12BF044", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x12BF0C0", Offset = "0x12BF0C0", VA = "0x12BF0C0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x12BF13C", Offset = "0x12BF13C", VA = "0x12BF13C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x12BF320", Offset = "0x12BF320", VA = "0x12BF320")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x12BDCE0", Offset = "0x12BDCE0", VA = "0x12BDCE0")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x12BDDD0", Offset = "0x12BDDD0", VA = "0x12BDDD0")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x12BE0EC", Offset = "0x12BE0EC", VA = "0x12BE0EC")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x12BE60C", Offset = "0x12BE60C", VA = "0x12BE60C")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x12BF4E0", Offset = "0x12BF4E0", VA = "0x12BF4E0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x12BF528", Offset = "0x12BF528", VA = "0x12BF528", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x12C0940", Offset = "0x12C0940", VA = "0x12C0940")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x12BE770", Offset = "0x12BE770", VA = "0x12BE770")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x12BF89C", Offset = "0x12BF89C", VA = "0x12BF89C")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x12C0CF0", Offset = "0x12C0CF0", VA = "0x12C0CF0")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x12C0D38", Offset = "0x12C0D38", VA = "0x12C0D38")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x12C07F0", Offset = "0x12C07F0", VA = "0x12C07F0")]
		private void Write()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x12C0D7C", Offset = "0x12C0D7C", VA = "0x12C0D7C")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x12C1220", Offset = "0x12C1220", VA = "0x12C1220")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644A08", Offset = "0x644A08")]
		public Transform parent;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644A40", Offset = "0x644A40")]
		public Transform child;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x644A78", Offset = "0x644A78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644A78", Offset = "0x644A78")]
		public float weight;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x644ACC", Offset = "0x644ACC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644ACC", Offset = "0x644ACC")]
		public float parentChildCrossfade;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x644B20", Offset = "0x644B20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644B20", Offset = "0x644B20")]
		public float twistAngleOffset;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 twistAxis;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 axis;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xE85714", Offset = "0xE85714", VA = "0xE85714")]
		public void Relax()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xE85A30", Offset = "0xE85A30", VA = "0xE85A30")]
		private void Start()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xE85E44", Offset = "0xE85E44", VA = "0xE85E44")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xE85EC8", Offset = "0xE85EC8", VA = "0xE85EC8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xE85F4C", Offset = "0xE85F4C", VA = "0xE85F4C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xE86088", Offset = "0xE86088", VA = "0xE86088")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000087")]
	public class InteractionEffector
	{
		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x644B7C", Offset = "0x644B7C")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x644B8C", Offset = "0x644B8C")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x644B9C", Offset = "0x644B9C")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x1700007D")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x12C17B8", Offset = "0x12C17B8", VA = "0x12C17B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649F48", Offset = "0x649F48")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x12C17C0", Offset = "0x12C17C0", VA = "0x12C17C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649F58", Offset = "0x649F58")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public bool isPaused
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x12C17C8", Offset = "0x12C17C8", VA = "0x12C17C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649F68", Offset = "0x649F68")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x12C17D0", Offset = "0x12C17D0", VA = "0x12C17D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649F78", Offset = "0x649F78")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x12C17DC", Offset = "0x12C17DC", VA = "0x12C17DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649F88", Offset = "0x649F88")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x12C17E4", Offset = "0x12C17E4", VA = "0x12C17E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x649F98", Offset = "0x649F98")]
			private set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public bool inInteraction
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x12C17EC", Offset = "0x12C17EC", VA = "0x12C17EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000081")]
		public float progress
		{
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x12C3CB4", Offset = "0x12C3CB4", VA = "0x12C3CB4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x12C1858", Offset = "0x12C1858", VA = "0x12C1858")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x12C18F0", Offset = "0x12C18F0", VA = "0x12C18F0")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x12C19BC", Offset = "0x12C19BC", VA = "0x12C19BC")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x12C1B34", Offset = "0x12C1B34", VA = "0x12C1B34")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x12C1E98", Offset = "0x12C1E98", VA = "0x12C1E98")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x12C1F54", Offset = "0x12C1F54", VA = "0x12C1F54")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x12C1FAC", Offset = "0x12C1FAC", VA = "0x12C1FAC")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x12C29F8", Offset = "0x12C29F8", VA = "0x12C29F8")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x12C34A8", Offset = "0x12C34A8", VA = "0x12C34A8")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x12C36EC", Offset = "0x12C36EC", VA = "0x12C36EC")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x12C3B44", Offset = "0x12C3B44", VA = "0x12C3B44")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x12C3E14", Offset = "0x12C3E14", VA = "0x12C3E14")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000088")]
	public class InteractionLookAt
	{
		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644BAC", Offset = "0x644BAC")]
		public LookAtIK ik;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644BE4", Offset = "0x644BE4")]
		public float lerpSpeed;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644C1C", Offset = "0x644C1C")]
		public float weightSpeed;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x12C4004", Offset = "0x12C4004", VA = "0x12C4004")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x12C412C", Offset = "0x12C412C", VA = "0x12C412C")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x12C41D0", Offset = "0x12C41D0", VA = "0x12C41D0")]
		public void Update()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x12C4818", Offset = "0x12C4818", VA = "0x12C4818")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x12C490C", Offset = "0x12C490C", VA = "0x12C490C")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x12C49D4", Offset = "0x12C49D4", VA = "0x12C49D4")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x640854", Offset = "0x640854")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x640854", Offset = "0x640854")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200008A")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000430")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644D2C", Offset = "0x644D2C")]
			public float time;

			[Token(Token = "0x4000431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644D64", Offset = "0x644D64")]
			public bool pause;

			[Token(Token = "0x4000432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644D9C", Offset = "0x644D9C")]
			public bool pickUp;

			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644DD4", Offset = "0x644DD4")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644E0C", Offset = "0x644E0C")]
			public Message[] messages;

			[Token(Token = "0x4000435")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644E44", Offset = "0x644E44")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x10D0548", Offset = "0x10D0548", VA = "0x10D0548")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x10D071C", Offset = "0x10D071C", VA = "0x10D071C")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008B")]
		public class Message
		{
			[Token(Token = "0x4000436")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644E7C", Offset = "0x644E7C")]
			public string function;

			[Token(Token = "0x4000437")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644EB4", Offset = "0x644EB4")]
			public GameObject recipient;

			[Token(Token = "0x4000438")]
			private const string empty = "";

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x10D0618", Offset = "0x10D0618", VA = "0x10D0618")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x10D0724", Offset = "0x10D0724", VA = "0x10D0724")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008C")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000439")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644EEC", Offset = "0x644EEC")]
			public Animator animator;

			[Token(Token = "0x400043A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644F24", Offset = "0x644F24")]
			public Animation animation;

			[Token(Token = "0x400043B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644F5C", Offset = "0x644F5C")]
			public string animationState;

			[Token(Token = "0x400043C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644F94", Offset = "0x644F94")]
			public float crossfadeTime;

			[Token(Token = "0x400043D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644FCC", Offset = "0x644FCC")]
			public int layer;

			[Token(Token = "0x400043E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645004", Offset = "0x645004")]
			public bool resetNormalizedTime;

			[Token(Token = "0x400043F")]
			private const string empty = "";

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x10D02B4", Offset = "0x10D02B4", VA = "0x10D02B4")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x10D03A4", Offset = "0x10D03A4", VA = "0x10D03A4")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x10D0458", Offset = "0x10D0458", VA = "0x10D0458")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x10D0534", Offset = "0x10D0534", VA = "0x10D0534")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008D")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x200008E")]
			public enum Type
			{
				[Token(Token = "0x4000443")]
				PositionWeight,
				[Token(Token = "0x4000444")]
				RotationWeight,
				[Token(Token = "0x4000445")]
				PositionOffsetX,
				[Token(Token = "0x4000446")]
				PositionOffsetY,
				[Token(Token = "0x4000447")]
				PositionOffsetZ,
				[Token(Token = "0x4000448")]
				Pull,
				[Token(Token = "0x4000449")]
				Reach,
				[Token(Token = "0x400044A")]
				RotateBoneWeight,
				[Token(Token = "0x400044B")]
				Push,
				[Token(Token = "0x400044C")]
				PushParent,
				[Token(Token = "0x400044D")]
				PoserWeight,
				[Token(Token = "0x400044E")]
				BendGoalWeight
			}

			[Token(Token = "0x4000440")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64503C", Offset = "0x64503C")]
			public Type type;

			[Token(Token = "0x4000441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645074", Offset = "0x645074")]
			public AnimationCurve curve;

			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x10D0768", Offset = "0x10D0768", VA = "0x10D0768")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x10D0794", Offset = "0x10D0794", VA = "0x10D0794")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008F")]
		public class Multiplier
		{
			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6450AC", Offset = "0x6450AC")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6450E4", Offset = "0x6450E4")]
			public float multiplier;

			[Token(Token = "0x4000451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64511C", Offset = "0x64511C")]
			public WeightCurve.Type result;

			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x10D072C", Offset = "0x10D072C", VA = "0x10D072C")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x10D0784", Offset = "0x10D0784", VA = "0x10D0784")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644C64", Offset = "0x644C64")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644C9C", Offset = "0x644C9C")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x644CD4", Offset = "0x644CD4")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x644D0C", Offset = "0x644D0C")]
		private float <length>k__BackingField;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x644D1C", Offset = "0x644D1C")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000082")]
		public float length
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x12C4C28", Offset = "0x12C4C28", VA = "0x12C4C28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64A168", Offset = "0x64A168")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x12C4C30", Offset = "0x12C4C30", VA = "0x12C4C30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64A178", Offset = "0x64A178")]
			private set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x12C4C38", Offset = "0x12C4C38", VA = "0x12C4C38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64A188", Offset = "0x64A188")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x12C4C40", Offset = "0x12C4C40", VA = "0x12C4C40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64A198", Offset = "0x64A198")]
			private set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x12C4E10", Offset = "0x12C4E10", VA = "0x12C4E10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x12C3CF0", Offset = "0x12C3CF0", VA = "0x12C3CF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x12C49E8", Offset = "0x12C49E8", VA = "0x12C49E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649FA8", Offset = "0x649FA8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x12C4A30", Offset = "0x12C4A30", VA = "0x12C4A30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x649FE0", Offset = "0x649FE0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x12C4A78", Offset = "0x12C4A78", VA = "0x12C4A78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A018", Offset = "0x64A018")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x12C4AC0", Offset = "0x12C4AC0", VA = "0x12C4AC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A050", Offset = "0x64A050")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x12C4B08", Offset = "0x12C4B08", VA = "0x12C4B08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A088", Offset = "0x64A088")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x12C4B50", Offset = "0x12C4B50", VA = "0x12C4B50")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A0C0", Offset = "0x64A0C0")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x12C4B98", Offset = "0x12C4B98", VA = "0x12C4B98")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A0F8", Offset = "0x64A0F8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x12C4BE0", Offset = "0x12C4BE0", VA = "0x12C4BE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A130", Offset = "0x64A130")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x12C4C48", Offset = "0x12C4C48", VA = "0x12C4C48")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x12C4E9C", Offset = "0x12C4E9C", VA = "0x12C4E9C")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x12C2568", Offset = "0x12C2568", VA = "0x12C2568")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x12C5028", Offset = "0x12C5028", VA = "0x12C5028")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x12C2414", Offset = "0x12C2414", VA = "0x12C2414")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x12C2560", Offset = "0x12C2560", VA = "0x12C2560")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x12C304C", Offset = "0x12C304C", VA = "0x12C304C")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x12C3924", Offset = "0x12C3924", VA = "0x12C3924")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x12C560C", Offset = "0x12C560C", VA = "0x12C560C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x12C5110", Offset = "0x12C5110", VA = "0x12C5110")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x12C5030", Offset = "0x12C5030", VA = "0x12C5030")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x12C55A4", Offset = "0x12C55A4", VA = "0x12C55A4")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x12C5610", Offset = "0x12C5610", VA = "0x12C5610")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x12C5678", Offset = "0x12C5678", VA = "0x12C5678")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6408B4", Offset = "0x6408B4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6408B4", Offset = "0x6408B4")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x2000091")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x2000092")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645154", Offset = "0x645154")]
		public string targetTag;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64518C", Offset = "0x64518C")]
		public float fadeInTime;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6451C4", Offset = "0x6451C4")]
		public float speed;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6451FC", Offset = "0x6451FC")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x645234", Offset = "0x645234")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645234", Offset = "0x645234")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x645234", Offset = "0x645234")]
		public Collider characterCollider;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6452B8", Offset = "0x6452B8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6452B8", Offset = "0x6452B8")]
		public Transform FPSCamera;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645318", Offset = "0x645318")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645350", Offset = "0x645350")]
		public float camRaycastDistance;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x645388", Offset = "0x645388")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645398", Offset = "0x645398")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x645398", Offset = "0x645398")]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6453F8", Offset = "0x6453F8")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x17000086")]
		public bool inInteraction
		{
			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x12C5920", Offset = "0x12C5920", VA = "0x12C5920")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000087")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000502")]
			[Address(RVA = "0x12C760C", Offset = "0x12C760C", VA = "0x12C760C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000503")]
			[Address(RVA = "0x12C7614", Offset = "0x12C7614", VA = "0x12C7614")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000504")]
			[Address(RVA = "0x12C761C", Offset = "0x12C761C", VA = "0x12C761C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64A368", Offset = "0x64A368")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000505")]
			[Address(RVA = "0x12C7624", Offset = "0x12C7624", VA = "0x12C7624")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64A378", Offset = "0x64A378")]
			private set
			{
			}
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x12C56E0", Offset = "0x12C56E0", VA = "0x12C56E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A1A8", Offset = "0x64A1A8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x12C5728", Offset = "0x12C5728", VA = "0x12C5728")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A1E0", Offset = "0x64A1E0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x12C5770", Offset = "0x12C5770", VA = "0x12C5770")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A218", Offset = "0x64A218")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x12C57B8", Offset = "0x12C57B8", VA = "0x12C57B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A250", Offset = "0x64A250")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x12C5800", Offset = "0x12C5800", VA = "0x12C5800")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A288", Offset = "0x64A288")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x12C5848", Offset = "0x12C5848", VA = "0x12C5848")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A2C0", Offset = "0x64A2C0")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x12C5890", Offset = "0x12C5890", VA = "0x12C5890")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A2F8", Offset = "0x64A2F8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x12C58D8", Offset = "0x12C58D8", VA = "0x12C58D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A330", Offset = "0x64A330")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x12C5AC4", Offset = "0x12C5AC4", VA = "0x12C5AC4")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x12C5B90", Offset = "0x12C5B90", VA = "0x12C5B90")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x12C5C5C", Offset = "0x12C5C5C", VA = "0x12C5C5C")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x12C5D08", Offset = "0x12C5D08", VA = "0x12C5D08")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x12C5E00", Offset = "0x12C5E00", VA = "0x12C5E00")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x12C5F18", Offset = "0x12C5F18", VA = "0x12C5F18")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x12C5FA8", Offset = "0x12C5FA8", VA = "0x12C5FA8")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x12C6038", Offset = "0x12C6038", VA = "0x12C6038")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x12C60C8", Offset = "0x12C60C8", VA = "0x12C60C8")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x12C613C", Offset = "0x12C613C", VA = "0x12C613C")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x12C61B0", Offset = "0x12C61B0", VA = "0x12C61B0")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x12C6218", Offset = "0x12C6218", VA = "0x12C6218")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x12C62A4", Offset = "0x12C62A4", VA = "0x12C62A4")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x12C6358", Offset = "0x12C6358", VA = "0x12C6358")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x12C643C", Offset = "0x12C643C", VA = "0x12C643C")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x12C6714", Offset = "0x12C6714", VA = "0x12C6714")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x12C690C", Offset = "0x12C690C", VA = "0x12C690C")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x12C6BB0", Offset = "0x12C6BB0", VA = "0x12C6BB0")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x12C6E88", Offset = "0x12C6E88", VA = "0x12C6E88")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x12C6ECC", Offset = "0x12C6ECC", VA = "0x12C6ECC")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x12C6F44", Offset = "0x12C6F44", VA = "0x12C6F44")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x12C7078", Offset = "0x12C7078", VA = "0x12C7078")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x12C721C", Offset = "0x12C721C", VA = "0x12C721C")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x12C74C0", Offset = "0x12C74C0", VA = "0x12C74C0")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x12C6CC4", Offset = "0x12C6CC4", VA = "0x12C6CC4")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x12C762C", Offset = "0x12C762C", VA = "0x12C762C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x12C7E54", Offset = "0x12C7E54", VA = "0x12C7E54")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x12C7E74", Offset = "0x12C7E74", VA = "0x12C7E74")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x12C7E90", Offset = "0x12C7E90", VA = "0x12C7E90")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x12C7EAC", Offset = "0x12C7EAC", VA = "0x12C7EAC")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x12C7F0C", Offset = "0x12C7F0C", VA = "0x12C7F0C")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x12C8048", Offset = "0x12C8048", VA = "0x12C8048")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x12C8158", Offset = "0x12C8158", VA = "0x12C8158")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x12C84FC", Offset = "0x12C84FC", VA = "0x12C84FC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x12C8628", Offset = "0x12C8628", VA = "0x12C8628")]
		public void Update()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x12C88B8", Offset = "0x12C88B8", VA = "0x12C88B8")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x12C7BA0", Offset = "0x12C7BA0", VA = "0x12C7BA0")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x12C89F4", Offset = "0x12C89F4", VA = "0x12C89F4")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x12C8B1C", Offset = "0x12C8B1C", VA = "0x12C8B1C")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x12C8BB0", Offset = "0x12C8BB0", VA = "0x12C8BB0")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x12C8C84", Offset = "0x12C8C84", VA = "0x12C8C84")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x12C8C9C", Offset = "0x12C8C9C", VA = "0x12C8C9C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x12C59CC", Offset = "0x12C59CC", VA = "0x12C59CC")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x12C65E4", Offset = "0x12C65E4", VA = "0x12C65E4")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x12C9098", Offset = "0x12C9098", VA = "0x12C9098")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x2000093")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x640914", Offset = "0x640914")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x640914", Offset = "0x640914")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000094")]
		public class Multiplier
		{
			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6455F0", Offset = "0x6455F0")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645628", Offset = "0x645628")]
			public float multiplier;

			[Token(Token = "0x600052E")]
			[Address(RVA = "0x10D0E08", Offset = "0x10D0E08", VA = "0x10D0E08")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645430", Offset = "0x645430")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645468", Offset = "0x645468")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6454A0", Offset = "0x6454A0")]
		public float interactionSpeedMlp;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6454D8", Offset = "0x6454D8")]
		public Transform pivot;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645510", Offset = "0x645510")]
		public Vector3 twistAxis;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645548", Offset = "0x645548")]
		public float twistWeight;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645580", Offset = "0x645580")]
		public float swingWeight;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6455B8", Offset = "0x6455B8")]
		public bool rotateOnce;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x12C94E4", Offset = "0x12C94E4", VA = "0x12C94E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A388", Offset = "0x64A388")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x12C952C", Offset = "0x12C952C", VA = "0x12C952C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A3C0", Offset = "0x64A3C0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x12C9574", Offset = "0x12C9574", VA = "0x12C9574")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A3F8", Offset = "0x64A3F8")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x12C95BC", Offset = "0x12C95BC", VA = "0x12C95BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A430", Offset = "0x64A430")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x12C9604", Offset = "0x12C9604", VA = "0x12C9604")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A468", Offset = "0x64A468")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x12C964C", Offset = "0x12C964C", VA = "0x12C964C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A4A0", Offset = "0x64A4A0")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x12C9694", Offset = "0x12C9694", VA = "0x12C9694")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A4D8", Offset = "0x64A4D8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x12C96DC", Offset = "0x12C96DC", VA = "0x12C96DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A510", Offset = "0x64A510")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x12C50A0", Offset = "0x12C50A0", VA = "0x12C50A0")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x12C3D7C", Offset = "0x12C3D7C", VA = "0x12C3D7C")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x12C261C", Offset = "0x12C261C", VA = "0x12C261C")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x12C9724", Offset = "0x12C9724", VA = "0x12C9724")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000095")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x640974", Offset = "0x640974")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x640974", Offset = "0x640974")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000096")]
		public class CharacterPosition
		{
			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645698", Offset = "0x645698")]
			public bool use;

			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6456D0", Offset = "0x6456D0")]
			public Vector2 offset;

			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645708", Offset = "0x645708")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x645708", Offset = "0x645708")]
			public float angleOffset;

			[Token(Token = "0x400047A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x645764", Offset = "0x645764")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645764", Offset = "0x645764")]
			public float maxAngle;

			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6457BC", Offset = "0x6457BC")]
			public float radius;

			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6457F4", Offset = "0x6457F4")]
			public bool orbit;

			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64582C", Offset = "0x64582C")]
			public bool fixYAxis;

			[Token(Token = "0x17000089")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000537")]
				[Address(RVA = "0x10D1178", Offset = "0x10D1178", VA = "0x10D1178")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008A")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000538")]
				[Address(RVA = "0x10D1184", Offset = "0x10D1184", VA = "0x10D1184")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000539")]
			[Address(RVA = "0x10D120C", Offset = "0x10D120C", VA = "0x10D120C")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600053A")]
			[Address(RVA = "0x10D1650", Offset = "0x10D1650", VA = "0x10D1650")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000097")]
		public class CameraPosition
		{
			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645864", Offset = "0x645864")]
			public Collider lookAtTarget;

			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64589C", Offset = "0x64589C")]
			public Vector3 direction;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6458D4", Offset = "0x6458D4")]
			public float maxDistance;

			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64590C", Offset = "0x64590C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64590C", Offset = "0x64590C")]
			public float maxAngle;

			[Token(Token = "0x4000482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645964", Offset = "0x645964")]
			public bool fixYAxis;

			[Token(Token = "0x600053B")]
			[Address(RVA = "0x10D0E10", Offset = "0x10D0E10", VA = "0x10D0E10")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600053C")]
			[Address(RVA = "0x10D0F04", Offset = "0x10D0F04", VA = "0x10D0F04")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600053D")]
			[Address(RVA = "0x10D112C", Offset = "0x10D112C", VA = "0x10D112C")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000098")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x2000099")]
			public class Interaction
			{
				[Token(Token = "0x4000488")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645AB4", Offset = "0x645AB4")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000489")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645AEC", Offset = "0x645AEC")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000540")]
				[Address(RVA = "0x168B8D4", Offset = "0x168B8D4", VA = "0x168B8D4")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x4000483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			[HideInInspector]
			public string name;

			[Token(Token = "0x4000484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			[HideInInspector]
			public bool show;

			[Token(Token = "0x4000485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645A0C", Offset = "0x645A0C")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000486")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645A44", Offset = "0x645A44")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000487")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645A7C", Offset = "0x645A7C")]
			public Interaction[] interactions;

			[Token(Token = "0x600053E")]
			[Address(RVA = "0x10D1664", Offset = "0x10D1664", VA = "0x10D1664")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x600053F")]
			[Address(RVA = "0x10D1718", Offset = "0x10D1718", VA = "0x10D1718")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645660", Offset = "0x645660")]
		public Range[] ranges;

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x12C976C", Offset = "0x12C976C", VA = "0x12C976C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A548", Offset = "0x64A548")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x12C97B4", Offset = "0x12C97B4", VA = "0x12C97B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A580", Offset = "0x64A580")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x12C97FC", Offset = "0x12C97FC", VA = "0x12C97FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A5B8", Offset = "0x64A5B8")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x12C9844", Offset = "0x12C9844", VA = "0x12C9844")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A5F0", Offset = "0x64A5F0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x12C988C", Offset = "0x12C988C", VA = "0x12C988C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A628", Offset = "0x64A628")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x12C98D4", Offset = "0x12C98D4", VA = "0x12C98D4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x12C8328", Offset = "0x12C8328", VA = "0x12C8328")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x12C98D8", Offset = "0x12C98D8", VA = "0x12C98D8")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x200009B")]
		public class Map
		{
			[Token(Token = "0x400048B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x400048C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x400048D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x400048E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000548")]
			[Address(RVA = "0x173E4DC", Offset = "0x173E4DC", VA = "0x173E4DC")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000549")]
			[Address(RVA = "0x173E534", Offset = "0x173E534", VA = "0x173E534")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x600054A")]
			[Address(RVA = "0x173E584", Offset = "0x173E584", VA = "0x173E584")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600054B")]
			[Address(RVA = "0x173E5D0", Offset = "0x173E5D0", VA = "0x173E5D0")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x16916E4", Offset = "0x16916E4", VA = "0x16916E4", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A660", Offset = "0x64A660")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x1691A74", Offset = "0x1691A74", VA = "0x1691A74", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x1691A78", Offset = "0x1691A78", VA = "0x1691A78", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x1691B80", Offset = "0x1691B80", VA = "0x1691B80", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1691A08", Offset = "0x1691A08", VA = "0x1691A08")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1691968", Offset = "0x1691968", VA = "0x1691968")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x1691BEC", Offset = "0x1691BEC", VA = "0x1691BEC")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x16987D0", Offset = "0x16987D0", VA = "0x16987D0", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x16988AC", Offset = "0x16988AC", VA = "0x16988AC", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x1698A94", Offset = "0x1698A94", VA = "0x1698A94", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x1698B90", Offset = "0x1698B90", VA = "0x1698B90", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x1698910", Offset = "0x1698910", VA = "0x1698910")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x1698EF0", Offset = "0x1698EF0", VA = "0x1698EF0")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x645B24", Offset = "0x645B24")]
		public float weight;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x645B3C", Offset = "0x645B3C")]
		public float localRotationWeight;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x645B54", Offset = "0x645B54")]
		public float localPositionWeight;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x6000552")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xE79434", Offset = "0xE79434", VA = "0xE79434")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x6000554")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x6000555")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x6000556")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xE79440", Offset = "0xE79440", VA = "0xE79440", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xE79494", Offset = "0xE79494", VA = "0xE79494", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xE794D0", Offset = "0xE794D0", VA = "0xE794D0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xE794E8", Offset = "0xE794E8", VA = "0xE794E8")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6409D4", Offset = "0x6409D4")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x200009F")]
		public class Rigidbone
		{
			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x600056D")]
			[Address(RVA = "0x16822D8", Offset = "0x16822D8", VA = "0x16822D8")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x600056E")]
			[Address(RVA = "0x168249C", Offset = "0x168249C", VA = "0x168249C")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x600056F")]
			[Address(RVA = "0x168257C", Offset = "0x168257C", VA = "0x168257C")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20000A0")]
		public class Child
		{
			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x6000570")]
			[Address(RVA = "0x16820D0", Offset = "0x16820D0", VA = "0x16820D0")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000571")]
			[Address(RVA = "0x1682148", Offset = "0x1682148", VA = "0x1682148")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000572")]
			[Address(RVA = "0x1682288", Offset = "0x1682288", VA = "0x1682288")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000A1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640A34", Offset = "0x640A34")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x1700008D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000576")]
				[Address(RVA = "0x1682080", Offset = "0x1682080", VA = "0x1682080", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000578")]
				[Address(RVA = "0x16820C8", Offset = "0x16820C8", VA = "0x16820C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000573")]
			[Address(RVA = "0x1681E44", Offset = "0x1681E44", VA = "0x1681E44")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000574")]
			[Address(RVA = "0x1681E70", Offset = "0x1681E70", VA = "0x1681E70", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000575")]
			[Address(RVA = "0x1681E74", Offset = "0x1681E74", VA = "0x1681E74", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000577")]
			[Address(RVA = "0x1682088", Offset = "0x1682088", VA = "0x1682088", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645B6C", Offset = "0x645B6C")]
		public IK ik;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645BA4", Offset = "0x645BA4")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645BDC", Offset = "0x645BDC")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645C14", Offset = "0x645C14")]
		public float applyVelocity;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645C4C", Offset = "0x645C4C")]
		public float applyAngularVelocity;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x1700008B")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000566")]
			[Address(RVA = "0xE79F28", Offset = "0xE79F28", VA = "0xE79F28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008C")]
		private bool ikUsed
		{
			[Token(Token = "0x6000568")]
			[Address(RVA = "0xE7A95C", Offset = "0xE7A95C", VA = "0xE7A95C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xE79EF0", Offset = "0xE79EF0", VA = "0xE79EF0")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xE79FA0", Offset = "0xE79FA0", VA = "0xE79FA0")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xE7A0DC", Offset = "0xE7A0DC", VA = "0xE7A0DC")]
		public void Start()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xE7A064", Offset = "0xE7A064", VA = "0xE7A064")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x64A698", Offset = "0x64A698")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xE7A598", Offset = "0xE7A598", VA = "0xE7A598")]
		private void Update()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xE7A7E4", Offset = "0xE7A7E4", VA = "0xE7A7E4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xE7A8A0", Offset = "0xE7A8A0", VA = "0xE7A8A0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xE7AADC", Offset = "0xE7AADC", VA = "0xE7AADC")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xE7A920", Offset = "0xE7A920", VA = "0xE7A920")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xE7AA98", Offset = "0xE7AA98", VA = "0xE7AA98")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xE7AB7C", Offset = "0xE7AB7C", VA = "0xE7AB7C")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xE7AB10", Offset = "0xE7AB10", VA = "0xE7AB10")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xE79FF8", Offset = "0xE79FF8", VA = "0xE79FF8")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xE7A824", Offset = "0xE7A824", VA = "0xE7A824")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xE7ADA8", Offset = "0xE7ADA8", VA = "0xE7ADA8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xE7AEE4", Offset = "0xE7AEE4", VA = "0xE7AEE4")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x645C94", Offset = "0x645C94")]
		private bool <defaultLocalRotationOverride>k__BackingField;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x1700008F")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x600057E")]
			[Address(RVA = "0xE7C1E4", Offset = "0xE7C1E4", VA = "0xE7C1E4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000090")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x600057F")]
			[Address(RVA = "0xE7C1F0", Offset = "0xE7C1F0", VA = "0xE7C1F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000091")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x6000580")]
			[Address(RVA = "0xE7C20C", Offset = "0xE7C20C", VA = "0xE7C20C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64A748", Offset = "0x64A748")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000581")]
			[Address(RVA = "0xE7C214", Offset = "0xE7C214", VA = "0xE7C214")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64A758", Offset = "0x64A758")]
			private set
			{
			}
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xE7BEE4", Offset = "0xE7BEE4", VA = "0xE7BEE4")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xE7BF2C", Offset = "0xE7BF2C", VA = "0xE7BF2C")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xE7BF44", Offset = "0xE7BF44", VA = "0xE7BF44")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xE7C13C", Offset = "0xE7C13C", VA = "0xE7C13C")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xE7C1AC", Offset = "0xE7C1AC", VA = "0xE7C1AC")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000582")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xE7C064", Offset = "0xE7C064", VA = "0xE7C064")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xE7C220", Offset = "0xE7C220", VA = "0xE7C220")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xE7C224", Offset = "0xE7C224", VA = "0xE7C224")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xE7C314", Offset = "0xE7C314", VA = "0xE7C314")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xE7C390", Offset = "0xE7C390", VA = "0xE7C390")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xE7C524", Offset = "0xE7C524", VA = "0xE7C524")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xE7C594", Offset = "0xE7C594", VA = "0xE7C594")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x640A44", Offset = "0x640A44")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x640A44", Offset = "0x640A44")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x645CA4", Offset = "0x645CA4")]
		public float limit;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x645CC0", Offset = "0x645CC0")]
		public float twistLimit;

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xE7C5C8", Offset = "0xE7C5C8", VA = "0xE7C5C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A768", Offset = "0x64A768")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xE7C610", Offset = "0xE7C610", VA = "0xE7C610")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A7A0", Offset = "0x64A7A0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xE7C658", Offset = "0xE7C658", VA = "0xE7C658")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A7D8", Offset = "0x64A7D8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xE7C6A0", Offset = "0xE7C6A0", VA = "0xE7C6A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A810", Offset = "0x64A810")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xE7C6E8", Offset = "0xE7C6E8", VA = "0xE7C6E8", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xE7C72C", Offset = "0xE7C72C", VA = "0xE7C72C")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xE7C8EC", Offset = "0xE7C8EC", VA = "0xE7C8EC")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x640AA4", Offset = "0x640AA4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x640AA4", Offset = "0x640AA4")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion lastRotation;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float lastAngle;

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xE7C92C", Offset = "0xE7C92C", VA = "0xE7C92C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A848", Offset = "0x64A848")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xE7C974", Offset = "0xE7C974", VA = "0xE7C974")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A880", Offset = "0x64A880")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xE7C9BC", Offset = "0xE7C9BC", VA = "0xE7C9BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A8B8", Offset = "0x64A8B8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xE7CA04", Offset = "0xE7CA04", VA = "0xE7CA04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A8F0", Offset = "0x64A8F0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xE7CA4C", Offset = "0xE7CA4C", VA = "0xE7CA4C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xE7CA74", Offset = "0xE7CA74", VA = "0xE7CA74")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xE7CC70", Offset = "0xE7CC70", VA = "0xE7CC70")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x640B04", Offset = "0x640B04")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x640B04", Offset = "0x640B04")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000A6")]
		public class ReachCone
		{
			[Token(Token = "0x40004CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x17000092")]
			public Vector3 o
			{
				[Token(Token = "0x60005A8")]
				[Address(RVA = "0x1682984", Offset = "0x1682984", VA = "0x1682984")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000093")]
			public Vector3 a
			{
				[Token(Token = "0x60005A9")]
				[Address(RVA = "0x16829BC", Offset = "0x16829BC", VA = "0x16829BC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000094")]
			public Vector3 b
			{
				[Token(Token = "0x60005AA")]
				[Address(RVA = "0x16829F8", Offset = "0x16829F8", VA = "0x16829F8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000095")]
			public Vector3 c
			{
				[Token(Token = "0x60005AB")]
				[Address(RVA = "0x1682A34", Offset = "0x1682A34", VA = "0x1682A34")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000096")]
			public bool isValid
			{
				[Token(Token = "0x60005AD")]
				[Address(RVA = "0x1682BC0", Offset = "0x1682BC0", VA = "0x1682BC0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x1682A70", Offset = "0x1682A70", VA = "0x1682A70")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x1682BD0", Offset = "0x1682BD0", VA = "0x1682BD0")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A7")]
		public class LimitPoint
		{
			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x1682948", Offset = "0x1682948", VA = "0x1682948")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x645CEC", Offset = "0x645CEC")]
		public float twistLimit;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x645D08", Offset = "0x645D08")]
		public int smoothIterations;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
		public LimitPoint[] points;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		public ReachCone[] reachCones;

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xE7CCC8", Offset = "0xE7CCC8", VA = "0xE7CCC8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A928", Offset = "0x64A928")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xE7CD10", Offset = "0xE7CD10", VA = "0xE7CD10")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A960", Offset = "0x64A960")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xE7CD58", Offset = "0xE7CD58", VA = "0xE7CD58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A998", Offset = "0x64A998")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xE7CDA0", Offset = "0xE7CDA0", VA = "0xE7CDA0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64A9D0", Offset = "0x64A9D0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xE7CDE8", Offset = "0xE7CDE8", VA = "0xE7CDE8")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xE7D2E0", Offset = "0xE7D2E0", VA = "0xE7D2E0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xE7D374", Offset = "0xE7D374", VA = "0xE7D374")]
		private void Start()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xE7D8E0", Offset = "0xE7D8E0", VA = "0xE7D8E0")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xE7CE8C", Offset = "0xE7CE8C", VA = "0xE7CE8C")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xE7DC8C", Offset = "0xE7DC8C", VA = "0xE7DC8C")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xE7E098", Offset = "0xE7E098", VA = "0xE7E098")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xE7E0DC", Offset = "0xE7E0DC", VA = "0xE7E0DC")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xE7E13C", Offset = "0xE7E13C", VA = "0xE7E13C")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xE7D674", Offset = "0xE7D674", VA = "0xE7D674")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xE7E1A8", Offset = "0xE7E1A8", VA = "0xE7E1A8")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xE7E284", Offset = "0xE7E284", VA = "0xE7E284")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x640B64", Offset = "0x640B64")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x640B64", Offset = "0x640B64")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x645DC8", Offset = "0x645DC8")]
		public float twistLimit;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xE7E304", Offset = "0xE7E304", VA = "0xE7E304")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64AA08", Offset = "0x64AA08")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xE7E34C", Offset = "0xE7E34C", VA = "0xE7E34C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64AA40", Offset = "0x64AA40")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xE7E394", Offset = "0xE7E394", VA = "0xE7E394")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64AA78", Offset = "0x64AA78")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xE7E3DC", Offset = "0xE7E3DC", VA = "0xE7E3DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x64AAB0", Offset = "0x64AAB0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xE7E424", Offset = "0xE7E424", VA = "0xE7E424")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xE7E440", Offset = "0xE7E440", VA = "0xE7E440", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xE7E484", Offset = "0xE7E484", VA = "0xE7E484")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xE7E6A8", Offset = "0xE7E6A8", VA = "0xE7E6A8")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000AA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640BC4", Offset = "0x640BC4")]
		private sealed class <TurnToTarget>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x17000098")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005C2")]
				[Address(RVA = "0xE8AF60", Offset = "0xE8AF60", VA = "0xE8AF60", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000099")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005C4")]
				[Address(RVA = "0xE8AFA8", Offset = "0xE8AFA8", VA = "0xE8AFA8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005BF")]
			[Address(RVA = "0xE8AE64", Offset = "0xE8AE64", VA = "0xE8AE64")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0xE8AE90", Offset = "0xE8AE90", VA = "0xE8AE90", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005C1")]
			[Address(RVA = "0xE8AE94", Offset = "0xE8AE94", VA = "0xE8AE94", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005C3")]
			[Address(RVA = "0xE8AF68", Offset = "0xE8AF68", VA = "0xE8AF68", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645E1C", Offset = "0x645E1C")]
		public AimIK ik;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645E54", Offset = "0x645E54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x645E54", Offset = "0x645E54")]
		public float weight;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x645EA8", Offset = "0x645EA8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645EA8", Offset = "0x645EA8")]
		public Transform target;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645F08", Offset = "0x645F08")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645F40", Offset = "0x645F40")]
		public float weightSmoothTime;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x645F78", Offset = "0x645F78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645F78", Offset = "0x645F78")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x645FD8", Offset = "0x645FD8")]
		public float maxRadiansDelta;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646010", Offset = "0x646010")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646048", Offset = "0x646048")]
		public float slerpSpeed;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646080", Offset = "0x646080")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6460B8", Offset = "0x6460B8")]
		public float minDistance;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6460F0", Offset = "0x6460F0")]
		public Vector3 offset;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x646128", Offset = "0x646128")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646128", Offset = "0x646128")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x646128", Offset = "0x646128")]
		public float maxRootAngle;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6461A4", Offset = "0x6461A4")]
		public bool turnToTarget;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6461DC", Offset = "0x6461DC")]
		public float turnToTargetTime;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x646214", Offset = "0x646214")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646214", Offset = "0x646214")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646274", Offset = "0x646274")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform lastTarget;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float switchWeight;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float switchWeightV;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float weightV;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 lastPosition;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 dir;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool turningToTarget;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float turnToTargetMlp;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float turnToTargetMlpV;

		[Token(Token = "0x17000097")]
		private Vector3 pivot
		{
			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x15ADEFC", Offset = "0x15ADEFC", VA = "0x15ADEFC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x15ADE70", Offset = "0x15ADE70", VA = "0x15ADE70")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x15ADF8C", Offset = "0x15ADF8C", VA = "0x15ADF8C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x15AE4F8", Offset = "0x15AE4F8", VA = "0x15AE4F8")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x15AE5E4", Offset = "0x15AE5E4", VA = "0x15AE5E4")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x15AE834", Offset = "0x15AE834", VA = "0x15AE834")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x64AAE8", Offset = "0x64AAE8")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x15AE8AC", Offset = "0x15AE8AC", VA = "0x15AE8AC")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000AC")]
		public class Pose
		{
			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x40004F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x40004FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0xE8AFB0", Offset = "0xE8AFB0", VA = "0xE8AFB0")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0xE8B13C", Offset = "0xE8B13C", VA = "0xE8B13C")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60005CA")]
			[Address(RVA = "0xE8B144", Offset = "0xE8B144", VA = "0xE8B144")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x15AEB1C", Offset = "0x15AEB1C", VA = "0x15AEB1C")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x15AEBFC", Offset = "0x15AEBFC", VA = "0x15AEBFC")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x15AEC68", Offset = "0x15AEC68", VA = "0x15AEC68")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000AE")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000AF")]
			public class EffectorLink
			{
				[Token(Token = "0x4000505")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646434", Offset = "0x646434")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000506")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64646C", Offset = "0x64646C")]
				public float weight;

				[Token(Token = "0x60005D0")]
				[Address(RVA = "0x168B4B8", Offset = "0x168B4B8", VA = "0x168B4B8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6462E4", Offset = "0x6462E4")]
			public Transform transform;

			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64631C", Offset = "0x64631C")]
			public Transform relativeTo;

			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646354", Offset = "0x646354")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64638C", Offset = "0x64638C")]
			public float verticalWeight;

			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6463C4", Offset = "0x6463C4")]
			public float horizontalWeight;

			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6463FC", Offset = "0x6463FC")]
			public float speed;

			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x60005CD")]
			[Address(RVA = "0xE8B160", Offset = "0xE8B160", VA = "0xE8B160")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60005CE")]
			[Address(RVA = "0xE8B484", Offset = "0xE8B484", VA = "0xE8B484")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005CF")]
			[Address(RVA = "0xE8B494", Offset = "0xE8B494", VA = "0xE8B494")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6462AC", Offset = "0x6462AC")]
		public Body[] bodies;

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x15AECD8", Offset = "0x15AECD8", VA = "0x15AECD8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x15AEE24", Offset = "0x15AEE24", VA = "0x15AEE24")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6464A4", Offset = "0x6464A4")]
		public float tiltSpeed;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6464DC", Offset = "0x6464DC")]
		public float tiltSensitivity;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646514", Offset = "0x646514")]
		public OffsetPose poseLeft;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64654C", Offset = "0x64654C")]
		public OffsetPose poseRight;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x15BB7E4", Offset = "0x15BB7E4", VA = "0x15BB7E4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x15BB82C", Offset = "0x15BB82C", VA = "0x15BB82C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x15BB9E4", Offset = "0x15BB9E4", VA = "0x15BB9E4")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IK ik;

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x15BEF18", Offset = "0x15BEF18", VA = "0x15BEF18")]
		private void Start()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x15BEFBC", Offset = "0x15BEFBC", VA = "0x15BEFBC")]
		private void Update()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x15BF088", Offset = "0x15BF088", VA = "0x15BF088")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000B3")]
		public abstract class HitPoint
		{
			[Token(Token = "0x4000510")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6465F4", Offset = "0x6465F4")]
			public string name;

			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64662C", Offset = "0x64662C")]
			public Collider collider;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646664", Offset = "0x646664")]
			private float crossFadeTime;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6466B0", Offset = "0x6466B0")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6466C0", Offset = "0x6466C0")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6466D0", Offset = "0x6466D0")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6466E0", Offset = "0x6466E0")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x1700009B")]
			public bool inProgress
			{
				[Token(Token = "0x60005DB")]
				[Address(RVA = "0x17400B8", Offset = "0x17400B8", VA = "0x17400B8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700009C")]
			protected float crossFader
			{
				[Token(Token = "0x60005DC")]
				[Address(RVA = "0x17400CC", Offset = "0x17400CC", VA = "0x17400CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64AB98", Offset = "0x64AB98")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005DD")]
				[Address(RVA = "0x17400D4", Offset = "0x17400D4", VA = "0x17400D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64ABA8", Offset = "0x64ABA8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009D")]
			protected float timer
			{
				[Token(Token = "0x60005DE")]
				[Address(RVA = "0x17400DC", Offset = "0x17400DC", VA = "0x17400DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64ABB8", Offset = "0x64ABB8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005DF")]
				[Address(RVA = "0x17400E4", Offset = "0x17400E4", VA = "0x17400E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64ABC8", Offset = "0x64ABC8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009E")]
			protected Vector3 force
			{
				[Token(Token = "0x60005E0")]
				[Address(RVA = "0x17400EC", Offset = "0x17400EC", VA = "0x17400EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64ABD8", Offset = "0x64ABD8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005E1")]
				[Address(RVA = "0x17400F8", Offset = "0x17400F8", VA = "0x17400F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64ABE8", Offset = "0x64ABE8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009F")]
			protected Vector3 point
			{
				[Token(Token = "0x60005E2")]
				[Address(RVA = "0x1740104", Offset = "0x1740104", VA = "0x1740104")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64ABF8", Offset = "0x64ABF8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005E3")]
				[Address(RVA = "0x1740110", Offset = "0x1740110", VA = "0x1740110")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64AC08", Offset = "0x64AC08")]
				private set
				{
				}
			}

			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x174011C", Offset = "0x174011C", VA = "0x174011C")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x1740250", Offset = "0x1740250", VA = "0x1740250")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005E6")]
			protected abstract float GetLength();

			[Token(Token = "0x60005E7")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x60005E8")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x1740324", Offset = "0x1740324", VA = "0x1740324")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B4")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000B5")]
			public class EffectorLink
			{
				[Token(Token = "0x400051D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646798", Offset = "0x646798")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400051E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6467D0", Offset = "0x6467D0")]
				public float weight;

				[Token(Token = "0x400051F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000520")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x60005EE")]
				[Address(RVA = "0x168B628", Offset = "0x168B628", VA = "0x168B628")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60005EF")]
				[Address(RVA = "0x168B6D8", Offset = "0x168B6D8", VA = "0x168B6D8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60005F0")]
				[Address(RVA = "0x168B6EC", Offset = "0x168B6EC", VA = "0x168B6EC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6466F0", Offset = "0x6466F0")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646728", Offset = "0x646728")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646760", Offset = "0x646760")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x1740660", Offset = "0x1740660", VA = "0x1740660", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x1740790", Offset = "0x1740790", VA = "0x1740790", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x17407FC", Offset = "0x17407FC", VA = "0x17407FC", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x1740964", Offset = "0x1740964", VA = "0x1740964")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B6")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000B7")]
			public class BoneLink
			{
				[Token(Token = "0x4000524")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646878", Offset = "0x646878")]
				public Transform bone;

				[Token(Token = "0x4000525")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6468B0", Offset = "0x6468B0")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6468B0", Offset = "0x6468B0")]
				public float weight;

				[Token(Token = "0x4000526")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000527")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x60005F5")]
				[Address(RVA = "0x168B4C0", Offset = "0x168B4C0", VA = "0x168B4C0")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60005F6")]
				[Address(RVA = "0x168B5D8", Offset = "0x168B5D8", VA = "0x168B5D8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60005F7")]
				[Address(RVA = "0x168B5E4", Offset = "0x168B5E4", VA = "0x168B5E4")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646808", Offset = "0x646808")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646840", Offset = "0x646840")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x1740338", Offset = "0x1740338", VA = "0x1740338", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x17403DC", Offset = "0x17403DC", VA = "0x17403DC", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x1740448", Offset = "0x1740448", VA = "0x1740448", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x174064C", Offset = "0x174064C", VA = "0x174064C")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646584", Offset = "0x646584")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6465BC", Offset = "0x6465BC")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x1700009A")]
		public bool inProgress
		{
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x1699D98", Offset = "0x1699D98", VA = "0x1699D98")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x1699E68", Offset = "0x1699E68", VA = "0x1699E68", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x1699F44", Offset = "0x1699F44", VA = "0x1699F44")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x169A1A0", Offset = "0x169A1A0", VA = "0x169A1A0")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000B9")]
		public abstract class Offset
		{
			[Token(Token = "0x400052B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646974", Offset = "0x646974")]
			public string name;

			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6469AC", Offset = "0x6469AC")]
			public Collider collider;

			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6469E4", Offset = "0x6469E4")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x400052E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x646A30", Offset = "0x646A30")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x646A40", Offset = "0x646A40")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x646A50", Offset = "0x646A50")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x646A60", Offset = "0x646A60")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000A0")]
			protected float crossFader
			{
				[Token(Token = "0x60005FB")]
				[Address(RVA = "0x1740978", Offset = "0x1740978", VA = "0x1740978")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64AC18", Offset = "0x64AC18")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005FC")]
				[Address(RVA = "0x1740980", Offset = "0x1740980", VA = "0x1740980")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64AC28", Offset = "0x64AC28")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A1")]
			protected float timer
			{
				[Token(Token = "0x60005FD")]
				[Address(RVA = "0x1740988", Offset = "0x1740988", VA = "0x1740988")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64AC38", Offset = "0x64AC38")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005FE")]
				[Address(RVA = "0x1740990", Offset = "0x1740990", VA = "0x1740990")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64AC48", Offset = "0x64AC48")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A2")]
			protected Vector3 force
			{
				[Token(Token = "0x60005FF")]
				[Address(RVA = "0x1740998", Offset = "0x1740998", VA = "0x1740998")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64AC58", Offset = "0x64AC58")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000600")]
				[Address(RVA = "0x17409A4", Offset = "0x17409A4", VA = "0x17409A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64AC68", Offset = "0x64AC68")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A3")]
			protected Vector3 point
			{
				[Token(Token = "0x6000601")]
				[Address(RVA = "0x17409B0", Offset = "0x17409B0", VA = "0x17409B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64AC78", Offset = "0x64AC78")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000602")]
				[Address(RVA = "0x17409BC", Offset = "0x17409BC", VA = "0x17409BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64AC88", Offset = "0x64AC88")]
				private set
				{
				}
			}

			[Token(Token = "0x6000603")]
			[Address(RVA = "0x17409C8", Offset = "0x17409C8", VA = "0x17409C8")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000604")]
			[Address(RVA = "0x1740B10", Offset = "0x1740B10", VA = "0x1740B10")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000605")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000606")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000607")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x6000608")]
			[Address(RVA = "0x1740BF8", Offset = "0x1740BF8", VA = "0x1740BF8")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BA")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000BB")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x4000538")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646B18", Offset = "0x646B18")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000539")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646B50", Offset = "0x646B50")]
				public float weight;

				[Token(Token = "0x400053A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400053B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600060D")]
				[Address(RVA = "0x168B6F4", Offset = "0x168B6F4", VA = "0x168B6F4")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600060E")]
				[Address(RVA = "0x168B784", Offset = "0x168B784", VA = "0x168B784")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600060F")]
				[Address(RVA = "0x168B798", Offset = "0x168B798", VA = "0x168B798")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646A70", Offset = "0x646A70")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646AA8", Offset = "0x646AA8")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646AE0", Offset = "0x646AE0")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000609")]
			[Address(RVA = "0x1740C0C", Offset = "0x1740C0C", VA = "0x1740C0C", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600060A")]
			[Address(RVA = "0x1740DBC", Offset = "0x1740DBC", VA = "0x1740DBC", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x1740E28", Offset = "0x1740E28", VA = "0x1740E28", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x1740FC8", Offset = "0x1740FC8", VA = "0x1740FC8")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BC")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000BD")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x400053F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646BF8", Offset = "0x646BF8")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000540")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x646C30", Offset = "0x646C30")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646C30", Offset = "0x646C30")]
				public float weight;

				[Token(Token = "0x4000541")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000542")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000614")]
				[Address(RVA = "0x168B7A0", Offset = "0x168B7A0", VA = "0x168B7A0")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000615")]
				[Address(RVA = "0x168B87C", Offset = "0x168B87C", VA = "0x168B87C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000616")]
				[Address(RVA = "0x168B888", Offset = "0x168B888", VA = "0x168B888")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646B88", Offset = "0x646B88")]
			public int curveIndex;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646BC0", Offset = "0x646BC0")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000610")]
			[Address(RVA = "0x1740FE4", Offset = "0x1740FE4", VA = "0x1740FE4", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000611")]
			[Address(RVA = "0x17410C8", Offset = "0x17410C8", VA = "0x17410C8", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000612")]
			[Address(RVA = "0x1741134", Offset = "0x1741134", VA = "0x1741134", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000613")]
			[Address(RVA = "0x17413F0", Offset = "0x17413F0", VA = "0x17413F0")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646904", Offset = "0x646904")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64693C", Offset = "0x64693C")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x169A1A8", Offset = "0x169A1A8", VA = "0x169A1A8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x169A27C", Offset = "0x169A27C", VA = "0x169A27C")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x169A4E0", Offset = "0x169A4E0", VA = "0x169A4E0")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000BF")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000C0")]
			public class EffectorLink
			{
				[Token(Token = "0x4000550")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646E60", Offset = "0x646E60")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000551")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646E98", Offset = "0x646E98")]
				public float weight;

				[Token(Token = "0x600061D")]
				[Address(RVA = "0x168B8CC", Offset = "0x168B8CC", VA = "0x168B8CC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646CF4", Offset = "0x646CF4")]
			public Transform transform;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646D2C", Offset = "0x646D2C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646D64", Offset = "0x646D64")]
			public float speed;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646D9C", Offset = "0x646D9C")]
			public float acceleration;

			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646DD4", Offset = "0x646DD4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x646DD4", Offset = "0x646DD4")]
			public float matchVelocity;

			[Token(Token = "0x400054A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646E28", Offset = "0x646E28")]
			public float gravity;

			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x600061A")]
			[Address(RVA = "0x10CFF24", Offset = "0x10CFF24", VA = "0x10CFF24")]
			public void Reset()
			{
			}

			[Token(Token = "0x600061B")]
			[Address(RVA = "0x10CFFDC", Offset = "0x10CFFDC", VA = "0x10CFFDC")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x600061C")]
			[Address(RVA = "0x10D0298", Offset = "0x10D0298", VA = "0x10D0298")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646C84", Offset = "0x646C84")]
		public Body[] bodies;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646CBC", Offset = "0x646CBC")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x12C1558", Offset = "0x12C1558", VA = "0x12C1558")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x12C15D4", Offset = "0x12C15D4", VA = "0x12C15D4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x12C1694", Offset = "0x12C1694", VA = "0x12C1694")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x646ED0", Offset = "0x646ED0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646ED0", Offset = "0x646ED0")]
		public Transform target;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x646F30", Offset = "0x646F30")]
		public float weight;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646F48", Offset = "0x646F48")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646F80", Offset = "0x646F80")]
		public float weightSmoothTime;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x646FB8", Offset = "0x646FB8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x646FB8", Offset = "0x646FB8")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647018", Offset = "0x647018")]
		public float maxRadiansDelta;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647050", Offset = "0x647050")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647088", Offset = "0x647088")]
		public float slerpSpeed;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6470C0", Offset = "0x6470C0")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6470F8", Offset = "0x6470F8")]
		public float minDistance;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x647130", Offset = "0x647130")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647130", Offset = "0x647130")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x647130", Offset = "0x647130")]
		public float maxRootAngle;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x170000A4")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000620")]
			[Address(RVA = "0xC45770", Offset = "0xC45770", VA = "0xC45770")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xC456FC", Offset = "0xC456FC", VA = "0xC456FC")]
		private void Start()
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xC45800", Offset = "0xC45800", VA = "0xC45800")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xC45D34", Offset = "0xC45D34", VA = "0xC45D34")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xC45E20", Offset = "0xC45E20", VA = "0xC45E20")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xC46018", Offset = "0xC46018", VA = "0xC46018")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C3")]
		public class OffsetLimits
		{
			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64721C", Offset = "0x64721C")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647254", Offset = "0x647254")]
			public float spring;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64728C", Offset = "0x64728C")]
			public bool x;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6472C4", Offset = "0x6472C4")]
			public bool y;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6472FC", Offset = "0x6472FC")]
			public bool z;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647334", Offset = "0x647334")]
			public float minX;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64736C", Offset = "0x64736C")]
			public float maxX;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6473A4", Offset = "0x6473A4")]
			public float minY;

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6473DC", Offset = "0x6473DC")]
			public float maxY;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647414", Offset = "0x647414")]
			public float minZ;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64744C", Offset = "0x64744C")]
			public float maxZ;

			[Token(Token = "0x600062C")]
			[Address(RVA = "0x10DDAD0", Offset = "0x10DDAD0", VA = "0x10DDAD0")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600062D")]
			[Address(RVA = "0x10DDC28", Offset = "0x10DDC28", VA = "0x10DDC28")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x600062E")]
			[Address(RVA = "0x10DDCA0", Offset = "0x10DDCA0", VA = "0x10DDCA0")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x600062F")]
			[Address(RVA = "0x10DDCF8", Offset = "0x10DDCF8", VA = "0x10DDCF8")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640BE4", Offset = "0x640BE4")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000A6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000633")]
				[Address(RVA = "0x10DDA80", Offset = "0x10DDA80", VA = "0x10DDA80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000635")]
				[Address(RVA = "0x10DDAC8", Offset = "0x10DDAC8", VA = "0x10DDAC8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000630")]
			[Address(RVA = "0x10DD8E0", Offset = "0x10DD8E0", VA = "0x10DD8E0")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000631")]
			[Address(RVA = "0x10DD90C", Offset = "0x10DD90C", VA = "0x10DD90C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000632")]
			[Address(RVA = "0x10DD910", Offset = "0x10DD910", VA = "0x10DD910", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000634")]
			[Address(RVA = "0x10DDA88", Offset = "0x10DDA88", VA = "0x10DDA88", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6471AC", Offset = "0x6471AC")]
		public float weight;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6471E4", Offset = "0x6471E4")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000A5")]
		protected float deltaTime
		{
			[Token(Token = "0x6000624")]
			[Address(RVA = "0xC53844", Offset = "0xC53844", VA = "0xC53844")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000625")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xC53870", Offset = "0xC53870", VA = "0xC53870", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xC5389C", Offset = "0xC5389C", VA = "0xC5389C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x64AC98", Offset = "0x64AC98")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xC53914", Offset = "0xC53914", VA = "0xC53914")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xC539F0", Offset = "0xC539F0", VA = "0xC539F0")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xC53AB0", Offset = "0xC53AB0", VA = "0xC53AB0", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xC53BE0", Offset = "0xC53BE0", VA = "0xC53BE0")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640BF4", Offset = "0x640BF4")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000A9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000640")]
				[Address(RVA = "0x10DDEA0", Offset = "0x10DDEA0", VA = "0x10DDEA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000642")]
				[Address(RVA = "0x10DDEE8", Offset = "0x10DDEE8", VA = "0x10DDEE8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600063D")]
			[Address(RVA = "0x10DDD00", Offset = "0x10DDD00", VA = "0x10DDD00")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600063E")]
			[Address(RVA = "0x10DDD2C", Offset = "0x10DDD2C", VA = "0x10DDD2C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600063F")]
			[Address(RVA = "0x10DDD30", Offset = "0x10DDD30", VA = "0x10DDD30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000641")]
			[Address(RVA = "0x10DDEA8", Offset = "0x10DDEA8", VA = "0x10DDEA8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647484", Offset = "0x647484")]
		public float weight;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6474BC", Offset = "0x6474BC")]
		public VRIK ik;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000A8")]
		protected float deltaTime
		{
			[Token(Token = "0x6000636")]
			[Address(RVA = "0xC53BF0", Offset = "0xC53BF0", VA = "0xC53BF0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000637")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xC53C1C", Offset = "0xC53C1C", VA = "0xC53C1C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xC53C48", Offset = "0xC53C48", VA = "0xC53C48")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x64AD48", Offset = "0x64AD48")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xC53CC0", Offset = "0xC53CC0", VA = "0xC53CC0")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xC53D9C", Offset = "0xC53D9C", VA = "0xC53D9C", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xC53ECC", Offset = "0xC53ECC", VA = "0xC53ECC")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C8")]
		public class EffectorLink
		{
			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x4000581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000646")]
			[Address(RVA = "0x10DDEF0", Offset = "0x10DDEF0", VA = "0x10DDEF0")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0x10DE10C", Offset = "0x10DE10C", VA = "0x10DE10C")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xC53EDC", Offset = "0xC53EDC", VA = "0xC53EDC")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0xC53FA0", Offset = "0xC53FA0", VA = "0xC53FA0")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xC5405C", Offset = "0xC5405C", VA = "0xC5405C")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000CA")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x20000CB")]
			public class EffectorLink
			{
				[Token(Token = "0x400058D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6476D0", Offset = "0x6476D0")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400058E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647708", Offset = "0x647708")]
				public float weight;

				[Token(Token = "0x600064E")]
				[Address(RVA = "0x168B8DC", Offset = "0x168B8DC", VA = "0x168B8DC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64752C", Offset = "0x64752C")]
			public Transform[] raycastFrom;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647564", Offset = "0x647564")]
			public Transform raycastTo;

			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64759C", Offset = "0x64759C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64759C", Offset = "0x64759C")]
			public float raycastRadius;

			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6475F0", Offset = "0x6475F0")]
			public EffectorLink[] effectors;

			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647628", Offset = "0x647628")]
			public float smoothTimeIn;

			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647660", Offset = "0x647660")]
			public float smoothTimeOut;

			[Token(Token = "0x4000589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647698", Offset = "0x647698")]
			public LayerMask layers;

			[Token(Token = "0x400058A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x600064A")]
			[Address(RVA = "0x10DE114", Offset = "0x10DE114", VA = "0x10DE114")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600064B")]
			[Address(RVA = "0x10DE258", Offset = "0x10DE258", VA = "0x10DE258")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600064C")]
			[Address(RVA = "0x10DE350", Offset = "0x10DE350", VA = "0x10DE350")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600064D")]
			[Address(RVA = "0x10DE520", Offset = "0x10DE520", VA = "0x10DE520")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6474F4", Offset = "0x6474F4")]
		public Avoider[] avoiders;

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xC542A4", Offset = "0xC542A4", VA = "0xC542A4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xC5432C", Offset = "0xC5432C", VA = "0xC5432C")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000CD")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20000CE")]
			public class EffectorLink
			{
				[Token(Token = "0x40005AC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647A94", Offset = "0x647A94")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005AD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647ACC", Offset = "0x647ACC")]
				public float weight;

				[Token(Token = "0x600065E")]
				[Address(RVA = "0x168B8E4", Offset = "0x168B8E4", VA = "0x168B8E4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647998", Offset = "0x647998")]
			public Vector3 offset;

			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6479D0", Offset = "0x6479D0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6479D0", Offset = "0x6479D0")]
			public float additivity;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647A24", Offset = "0x647A24")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647A5C", Offset = "0x647A5C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x600065B")]
			[Address(RVA = "0x1682720", Offset = "0x1682720", VA = "0x1682720")]
			public void Start()
			{
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0x1682770", Offset = "0x1682770", VA = "0x1682770")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0x1682934", Offset = "0x1682934", VA = "0x1682934")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CF")]
		public enum Handedness
		{
			[Token(Token = "0x40005AF")]
			Right,
			[Token(Token = "0x40005B0")]
			Left
		}

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647740", Offset = "0x647740")]
		public AimIK aimIK;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647778", Offset = "0x647778")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6477B0", Offset = "0x6477B0")]
		public Handedness handedness;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6477E8", Offset = "0x6477E8")]
		public bool twoHanded;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647820", Offset = "0x647820")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647858", Offset = "0x647858")]
		public float magnitudeRandom;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647890", Offset = "0x647890")]
		public Vector3 rotationRandom;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6478C8", Offset = "0x6478C8")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647900", Offset = "0x647900")]
		public float blendTime;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x647938", Offset = "0x647938")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647938", Offset = "0x647938")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x170000AB")]
		public bool isFinished
		{
			[Token(Token = "0x600064F")]
			[Address(RVA = "0xE7B00C", Offset = "0xE7B00C", VA = "0xE7B00C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AC")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000655")]
			[Address(RVA = "0xE7BAA8", Offset = "0xE7BAA8", VA = "0xE7BAA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AD")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000656")]
			[Address(RVA = "0xE7BAE8", Offset = "0xE7BAE8", VA = "0xE7BAE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AE")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000657")]
			[Address(RVA = "0xE7BA68", Offset = "0xE7BA68", VA = "0xE7BA68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AF")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6000658")]
			[Address(RVA = "0xE7BA88", Offset = "0xE7BA88", VA = "0xE7BA88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xE7B03C", Offset = "0xE7B03C", VA = "0xE7B03C")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xE7B068", Offset = "0xE7B068", VA = "0xE7B068")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xE7B1B0", Offset = "0xE7B1B0", VA = "0xE7B1B0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xE7BB28", Offset = "0xE7BB28", VA = "0xE7BB28")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xE7BBDC", Offset = "0xE7BBDC", VA = "0xE7BBDC")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xE7BC18", Offset = "0xE7BC18", VA = "0xE7BC18", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0xE7BE08", Offset = "0xE7BE08", VA = "0xE7BE08")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647B04", Offset = "0x647B04")]
		public float weight;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647B3C", Offset = "0x647B3C")]
		public float offset;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xE7E6E4", Offset = "0xE7E6E4", VA = "0xE7E6E4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xE7E7EC", Offset = "0xE7E7EC", VA = "0xE7E7EC")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xE7E8D4", Offset = "0xE7E8D4", VA = "0xE7E8D4")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xE7EC28", Offset = "0xE7EC28", VA = "0xE7EC28")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xE7EC60", Offset = "0xE7EC60", VA = "0xE7EC60")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xE7ED90", Offset = "0xE7ED90", VA = "0xE7ED90")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x20000D2")]
		public class Settings
		{
			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647B74", Offset = "0x647B74")]
			public float scaleMlp;

			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647BAC", Offset = "0x647BAC")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647BE4", Offset = "0x647BE4")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647C1C", Offset = "0x647C1C")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647C54", Offset = "0x647C54")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647C8C", Offset = "0x647C8C")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647CC4", Offset = "0x647CC4")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647CFC", Offset = "0x647CFC")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647D34", Offset = "0x647D34")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x647D6C", Offset = "0x647D6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647D6C", Offset = "0x647D6C")]
			public Vector3 headOffset;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647DBC", Offset = "0x647DBC")]
			public Vector3 handOffset;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647DF4", Offset = "0x647DF4")]
			public float footForwardOffset;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647E2C", Offset = "0x647E2C")]
			public float footInwardOffset;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x647E64", Offset = "0x647E64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647E64", Offset = "0x647E64")]
			public float footHeadingOffset;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x647EC0", Offset = "0x647EC0")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x647ED8", Offset = "0x647ED8")]
			public float pelvisRotationWeight;

			[Token(Token = "0x600066A")]
			[Address(RVA = "0x168B04C", Offset = "0x168B04C", VA = "0x168B04C")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D3")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x20000D4")]
			public class Target
			{
				[Token(Token = "0x40005D1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x40005D2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x40005D3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x600066C")]
				[Address(RVA = "0x168E8CC", Offset = "0x168E8CC", VA = "0x168E8CC")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x600066D")]
				[Address(RVA = "0x168E98C", Offset = "0x168E98C", VA = "0x168E98C")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x600066B")]
			[Address(RVA = "0x168B044", Offset = "0x168B044", VA = "0x168B044")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xE87988", Offset = "0xE87988", VA = "0xE87988")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xE87A80", Offset = "0xE87A80", VA = "0xE87A80")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xE88D04", Offset = "0xE88D04", VA = "0xE88D04")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xE89548", Offset = "0xE89548", VA = "0xE89548")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xE8A048", Offset = "0xE8A048", VA = "0xE8A048")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xE8A49C", Offset = "0xE8A49C", VA = "0xE8A49C")]
		private void Start()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xE8A4F8", Offset = "0xE8A4F8", VA = "0xE8A4F8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xE8A52C", Offset = "0xE8A52C", VA = "0xE8A52C")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xE8A668", Offset = "0xE8A668", VA = "0xE8A668")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647EF0", Offset = "0x647EF0")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x170000B0")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x6000672")]
			[Address(RVA = "0xE8A680", Offset = "0xE8A680", VA = "0xE8A680")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64ADF8", Offset = "0x64ADF8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000673")]
			[Address(RVA = "0xE8A68C", Offset = "0xE8A68C", VA = "0xE8A68C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64AE08", Offset = "0x64AE08")]
			private set
			{
			}
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xE8A698", Offset = "0xE8A698", VA = "0xE8A698")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xE89318", Offset = "0xE89318", VA = "0xE89318")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xE8A2E0", Offset = "0xE8A2E0", VA = "0xE8A2E0")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xE8A7A8", Offset = "0xE8A7A8", VA = "0xE8A7A8")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xE8ABC4", Offset = "0xE8ABC4", VA = "0xE8ABC4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xE8ACF4", Offset = "0xE8ACF4", VA = "0xE8ACF4")]
		public VRIKRootController()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x20000D7")]
	public class FKOffset : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D8")]
		public class Offset
		{
			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x600067E")]
			[Address(RVA = "0x173E360", Offset = "0x173E360", VA = "0x173E360")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x600067F")]
			[Address(RVA = "0x173E4D4", Offset = "0x173E4D4", VA = "0x173E4D4")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Offset[] offsets;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x168E9EC", Offset = "0x168E9EC", VA = "0x168E9EC")]
		private void Start()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x168EA48", Offset = "0x168EA48", VA = "0x168EA48")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x168EAC4", Offset = "0x168EAC4", VA = "0x168EAC4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x168EBA8", Offset = "0x168EBA8", VA = "0x168EBA8")]
		public FKOffset()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D9")]
	public class Navigator
	{
		[Token(Token = "0x20000DA")]
		public enum State
		{
			[Token(Token = "0x40005F2")]
			Idle,
			[Token(Token = "0x40005F3")]
			Seeking,
			[Token(Token = "0x40005F4")]
			OnPath
		}

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647F38", Offset = "0x647F38")]
		public bool activeTargetSeeking;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647F70", Offset = "0x647F70")]
		public float cornerRadius;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647FA8", Offset = "0x647FA8")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x647FE0", Offset = "0x647FE0")]
		public float maxSampleDistance;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x648018", Offset = "0x648018")]
		public float nextPathInterval;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x648050", Offset = "0x648050")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x648060", Offset = "0x648060")]
		private State <state>k__BackingField;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x170000B1")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x6000680")]
			[Address(RVA = "0xC4D0FC", Offset = "0xC4D0FC", VA = "0xC4D0FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64AE18", Offset = "0x64AE18")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000681")]
			[Address(RVA = "0xC4D108", Offset = "0xC4D108", VA = "0xC4D108")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64AE28", Offset = "0x64AE28")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B2")]
		public State state
		{
			[Token(Token = "0x6000682")]
			[Address(RVA = "0xC4D114", Offset = "0xC4D114", VA = "0xC4D114")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64AE38", Offset = "0x64AE38")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x6000683")]
			[Address(RVA = "0xC4D11C", Offset = "0xC4D11C", VA = "0xC4D11C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64AE48", Offset = "0x64AE48")]
			private set
			{
			}
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xC4D124", Offset = "0xC4D124", VA = "0xC4D124")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xC4D1F8", Offset = "0xC4D1F8", VA = "0xC4D1F8")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xC4D5F8", Offset = "0xC4D5F8", VA = "0xC4D5F8")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xC4D674", Offset = "0xC4D674", VA = "0xC4D674")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xC4D5B4", Offset = "0xC4D5B4", VA = "0xC4D5B4")]
		private void Stop()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xC4D5E4", Offset = "0xC4D5E4", VA = "0xC4D5E4")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xC4D7C0", Offset = "0xC4D7C0", VA = "0xC4D7C0")]
		public void Visualize()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xC4D970", Offset = "0xC4D970", VA = "0xC4D970")]
		public Navigator()
		{
		}
	}
}
namespace BrainFailProductions.PolyFewRuntime
{
	[Token(Token = "0x20000DB")]
	public static class MeshCombiner
	{
		[Token(Token = "0x20000DC")]
		public struct StaticRenderer
		{
			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool isNewMesh;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Mesh mesh;

			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Material[] materials;
		}

		[Token(Token = "0x20000DD")]
		public struct SkinnedRenderer
		{
			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool hasBlendShapes;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string name;

			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isNewMesh;

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform transform;

			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Mesh mesh;

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Material[] materials;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform rootBone;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform[] bones;
		}

		[Serializable]
		[Token(Token = "0x20000DE")]
		public struct BlendShape
		{
			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string ShapeName;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public BlendShapeFrame[] Frames;

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x10DBBDC", Offset = "0x10DBBDC", VA = "0x10DBBDC")]
			public BlendShape(string shapeName, BlendShapeFrame[] frames)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DF")]
		public struct BlendShapeFrame
		{
			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string shapeName;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float frameWeight;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] deltaVertices;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3[] deltaNormals;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3[] deltaTangents;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int vertexOffset;

			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x10DBC10", Offset = "0x10DBC10", VA = "0x10DBC10")]
			public BlendShapeFrame(float frameWeight, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents)
			{
			}

			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x10DBCC8", Offset = "0x10DBCC8", VA = "0x10DBCC8")]
			public BlendShapeFrame(string shapeName, float frameWeight, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents, int vertexOffset)
			{
			}
		}

		[Token(Token = "0x20000E0")]
		public static class MeshUtils
		{
			[Token(Token = "0x400060E")]
			public const int UVChannelCount = 8;

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x10DBD50", Offset = "0x10DBD50", VA = "0x10DBD50")]
			public static Mesh CreateMesh(Vector3[] vertices, int[][] indices, Vector3[] normals, Vector4[] tangents, Color[] colors, BoneWeight[] boneWeights, List<Vector2>[] uvs, Matrix4x4[] bindposes, BlendShape[] blendShapes)
			{
				return null;
			}

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x10DC128", Offset = "0x10DC128", VA = "0x10DC128")]
			public static Mesh CreateMesh(Vector3[] vertices, int[][] indices, Vector3[] normals, Vector4[] tangents, Color[] colors, BoneWeight[] boneWeights, List<Vector4>[] uvs, Matrix4x4[] bindposes, BlendShape[] blendShapes)
			{
				return null;
			}

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x10DBD7C", Offset = "0x10DBD7C", VA = "0x10DBD7C")]
			public static Mesh CreateMesh(Vector3[] vertices, int[][] indices, Vector3[] normals, Vector4[] tangents, Color[] colors, BoneWeight[] boneWeights, List<Vector2>[] uvs2D, List<Vector3>[] uvs3D, List<Vector4>[] uvs4D, Matrix4x4[] bindposes, BlendShape[] blendShapes)
			{
				return null;
			}

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x10DC424", Offset = "0x10DC424", VA = "0x10DC424")]
			public static BlendShape[] GetMeshBlendShapes(Mesh mesh)
			{
				return null;
			}

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x10DC2A4", Offset = "0x10DC2A4", VA = "0x10DC2A4")]
			public static void ApplyMeshBlendShapes(Mesh mesh, BlendShape[] blendShapes)
			{
			}

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x10DC754", Offset = "0x10DC754", VA = "0x10DC754")]
			public static List<Vector4>[] GetMeshUVs(Mesh mesh)
			{
				return null;
			}

			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x10DC8C4", Offset = "0x10DC8C4", VA = "0x10DC8C4")]
			public static List<Vector4> GetMeshUVs(Mesh mesh, int channel)
			{
				return null;
			}

			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x10DCA38", Offset = "0x10DCA38", VA = "0x10DCA38")]
			public static int GetUsedUVComponents(List<Vector4> uvs)
			{
				return default(int);
			}

			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x10DCBB8", Offset = "0x10DCBB8", VA = "0x10DCBB8")]
			public static Vector2[] ConvertUVsTo2D(List<Vector4> uvs)
			{
				return null;
			}

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x10DCCB0", Offset = "0x10DCCB0", VA = "0x10DCCB0")]
			public static Vector3[] ConvertUVsTo3D(List<Vector4> uvs)
			{
				return null;
			}

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x10DC158", Offset = "0x10DC158", VA = "0x10DC158")]
			public static Vector2Int[] GetSubMeshIndexMinMax(int[][] indices, out IndexFormat indexFormat)
			{
				return null;
			}

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x10DCDB4", Offset = "0x10DCDB4", VA = "0x10DCDB4")]
			private static void GetIndexMinMax(int[] indices, out int minIndex, out int maxIndex)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640C04", Offset = "0x640C04")]
		private sealed class <>c
		{
			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<MeshRenderer, bool> <>9__11_0;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<MeshRenderer, MeshFilter> <>9__11_1;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<SkinnedMeshRenderer, bool> <>9__12_0;

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<SkinnedMeshRenderer, bool> <>9__12_1;

			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x10DB978", Offset = "0x10DB978", VA = "0x10DB978")]
			public <>c()
			{
			}

			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x10DB980", Offset = "0x10DB980", VA = "0x10DB980")]
			internal bool <CombineStaticMeshes>b__11_0(MeshRenderer renderer)
			{
				return default(bool);
			}

			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x10DBA80", Offset = "0x10DBA80", VA = "0x10DBA80")]
			internal MeshFilter <CombineStaticMeshes>b__11_1(MeshRenderer renderer)
			{
				return null;
			}

			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x10DBAD4", Offset = "0x10DBAD4", VA = "0x10DBAD4")]
			internal bool <CombineSkinnedMeshes>b__12_0(SkinnedMeshRenderer renderer)
			{
				return default(bool);
			}

			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x10DBB58", Offset = "0x10DBB58", VA = "0x10DBB58")]
			internal bool <CombineSkinnedMeshes>b__12_1(SkinnedMeshRenderer renderer)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static MeshRenderer[] unityCombinedMeshRenderers;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Material[] unityCombinedMeshesMats;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static bool didUseUnityCombine;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public static bool generateUV2;

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xC46370", Offset = "0xC46370", VA = "0xC46370")]
		public static StaticRenderer[] GetStaticRenderers(MeshRenderer[] renderers)
		{
			return null;
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xC46690", Offset = "0xC46690", VA = "0xC46690")]
		public static SkinnedRenderer[] GetSkinnedRenderers(SkinnedMeshRenderer[] renderers)
		{
			return null;
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xC46960", Offset = "0xC46960", VA = "0xC46960")]
		public static StaticRenderer[] CombineStaticMeshes(Transform transform, int levelIndex, MeshRenderer[] renderers, bool autoName = true, string combinedBaseName = "")
		{
			return null;
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xC48634", Offset = "0xC48634", VA = "0xC48634")]
		public static SkinnedRenderer[] CombineSkinnedMeshes(Transform transform, int levelIndex, SkinnedMeshRenderer[] renderers, ref SkinnedMeshRenderer[] renderersActuallyCombined, bool autoName = true, string combinedBaseName = "")
		{
			return null;
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xC47E04", Offset = "0xC47E04", VA = "0xC47E04")]
		public static Mesh CombineMeshes(Transform rootTransform, MeshRenderer[] renderers, out Material[] resultMaterials, [Optional] Dictionary<Transform, Transform> topLevelParents, [Optional] Dictionary<string, BlendShapeFrame> blendShapes)
		{
			return null;
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xC48DD8", Offset = "0xC48DD8", VA = "0xC48DD8")]
		public static Mesh CombineMeshes(Transform rootTransform, SkinnedMeshRenderer[] renderers, out Material[] resultMaterials, out Transform[] resultBones)
		{
			return null;
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xC49CE8", Offset = "0xC49CE8", VA = "0xC49CE8")]
		public static Mesh CombineMeshes(Mesh[] meshes, Matrix4x4[] transforms, Tuple<Matrix4x4, bool>[] normalsTransforms, Material[][] materials, out Material[] resultMaterials, [Optional] Dictionary<string, BlendShapeFrame> blendShapes)
		{
			return null;
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xC49E34", Offset = "0xC49E34", VA = "0xC49E34")]
		public static Mesh CombineMeshes(Mesh[] meshes, Matrix4x4[] transforms, Tuple<Matrix4x4, bool>[] normalsTransforms, Material[][] materials, Transform[][] bones, out Material[] resultMaterials, out Transform[] resultBones, [Optional] Dictionary<string, BlendShapeFrame> blendShapes)
		{
			return null;
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xC4BAFC", Offset = "0xC4BAFC", VA = "0xC4BAFC")]
		private static void ParentAndResetTransform(Transform transform, Transform parentTransform)
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xC4BB60", Offset = "0xC4BB60", VA = "0xC4BB60")]
		private static void ParentAndOffsetTransform(Transform transform, Transform parentTransform, Transform originalTransform)
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xC49B10", Offset = "0xC49B10", VA = "0xC49B10")]
		private static Transform FindBestRootBone(Transform transform, SkinnedMeshRenderer[] skinnedMeshRenderers)
		{
			return null;
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xC4BBF0", Offset = "0xC4BBF0", VA = "0xC4BBF0")]
		private static Transform FindBestRootBone(Dictionary<Transform, Transform> topLevelParents, SkinnedMeshRenderer[] skinnedMeshRenderers)
		{
			return null;
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xC4BE18", Offset = "0xC4BE18", VA = "0xC4BE18")]
		private static Transform GetTopLevelParent(Transform forObject)
		{
			return null;
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xC4BA48", Offset = "0xC4BA48", VA = "0xC4BA48")]
		private static void CopyVertexPositions(List<Vector3> list, Vector3[] arr)
		{
		}

		[Token(Token = "0x600069A")]
		private static void CopyVertexAttributes<T>(ref List<T> dest, IEnumerable<T> src, int previousVertexCount, int meshVertexCount, int totalVertexCount, T defaultValue)
		{
		}

		[Token(Token = "0x600069B")]
		private static T[] MergeArrays<T>(T[] arr1, T[] arr2)
		{
			return null;
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xC4B6E0", Offset = "0xC4B6E0", VA = "0xC4B6E0")]
		private static void TransformVertices(Vector3[] vertices, ref Matrix4x4 transform)
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xC4B770", Offset = "0xC4B770", VA = "0xC4B770")]
		private static void TransformNormals(Vector3[] normals, ref Tuple<Matrix4x4, bool> transform)
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xC4B94C", Offset = "0xC4B94C", VA = "0xC4B94C")]
		private static void TransformTangents(Vector4[] tangents, ref Tuple<Matrix4x4, bool> transform)
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xC4B4DC", Offset = "0xC4B4DC", VA = "0xC4B4DC")]
		private static void RemapBones(BoneWeight[] boneWeights, int[] boneIndices)
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xC4BEC4", Offset = "0xC4BEC4", VA = "0xC4BEC4")]
		private static Matrix4x4 ScaleMatrix(ref Matrix4x4 matrix, float scale)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xC47128", Offset = "0xC47128", VA = "0xC47128")]
		private static void CombineMeshesUnity(Transform parentTransform, MeshFilter[] meshFilters)
		{
		}
	}
	[Token(Token = "0x20000E2")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x640C14", Offset = "0x640C14")]
	public class PolyfewRuntime : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E3")]
		public class ObjectMeshPairs : Dictionary<GameObject, MeshRendererPair>
		{
			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x10E2380", Offset = "0x10E2380", VA = "0x10E2380")]
			public ObjectMeshPairs()
			{
			}
		}

		[Token(Token = "0x20000E4")]
		public enum MeshCombineTarget
		{
			[Token(Token = "0x4000616")]
			SkinnedAndStatic,
			[Token(Token = "0x4000617")]
			StaticOnly,
			[Token(Token = "0x4000618")]
			SkinnedOnly
		}

		[Serializable]
		[Token(Token = "0x20000E5")]
		public class MeshRendererPair
		{
			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool attachedToMeshFilter;

			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Mesh mesh;

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x10DFE9C", Offset = "0x10DFE9C", VA = "0x10DFE9C")]
			public MeshRendererPair(bool attachedToMeshFilter, Mesh mesh)
			{
			}

			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x10E2248", Offset = "0x10E2248", VA = "0x10E2248")]
			public void Destruct()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E6")]
		public class CustomMeshActionStructure
		{
			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MeshRendererPair meshRendererPair;

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject gameObject;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action action;

			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x10DF7AC", Offset = "0x10DF7AC", VA = "0x10DF7AC")]
			public CustomMeshActionStructure(MeshRendererPair meshRendererPair, GameObject gameObject, Action action)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E7")]
		public class SimplificationOptions
		{
			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float simplificationStrength;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool simplifyMeshLossless;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			public bool enableSmartlinking;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
			public bool recalculateNormals;

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
			public bool preserveUVSeamEdges;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool preserveUVFoldoverEdges;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool preserveBorderEdges;

			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			public bool regardPreservationSpheres;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<PreservationSphere> preservationSpheres;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool regardCurvature;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int maxIterations;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float aggressiveness;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public bool useEdgeSort;

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x10E2430", Offset = "0x10E2430", VA = "0x10E2430")]
			public SimplificationOptions()
			{
			}

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x10E24C8", Offset = "0x10E24C8", VA = "0x10E24C8")]
			public SimplificationOptions(float simplificationStrength, bool simplifyOptimal, bool enableSmartlink, bool recalculateNormals, bool preserveUVSeamEdges, bool preserveUVFoldoverEdges, bool preserveBorderEdges, bool regardToleranceSphere, List<PreservationSphere> preservationSpheres, bool regardCurvature, int maxIterations, float aggressiveness, bool useEdgeSort)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E8")]
		public class PreservationSphere
		{
			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 worldPosition;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float diameter;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float preservationStrength;

			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x10E23CC", Offset = "0x10E23CC", VA = "0x10E23CC")]
			public PreservationSphere(Vector3 worldPosition, float diameter, float preservationStrength)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E9")]
		public class OBJImportOptions : ImportOptions
		{
			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x10E2378", Offset = "0x10E2378", VA = "0x10E2378")]
			public OBJImportOptions()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EA")]
		public class OBJExportOptions
		{
			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly bool applyPosition;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public readonly bool applyRotation;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			public readonly bool applyScale;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
			public readonly bool generateMaterials;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public readonly bool exportTextures;

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x10E22F8", Offset = "0x10E22F8", VA = "0x10E22F8")]
			public OBJExportOptions(bool applyPosition, bool applyRotation, bool applyScale, bool generateMaterials, bool exportTextures)
			{
			}
		}

		[Token(Token = "0x20000EB")]
		public class ReferencedNumeric<T> where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
		{
			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T val;

			[Token(Token = "0x170000B3")]
			public T Value
			{
				[Token(Token = "0x60006D6")]
				get
				{
					return (T)null;
				}
				[Token(Token = "0x60006D7")]
				set
				{
				}
			}

			[Token(Token = "0x60006D8")]
			public ReferencedNumeric(T value)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EC")]
		public class MaterialProperties
		{
			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly int texArrIndex;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public readonly int matIndex;

			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public readonly string materialName;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public readonly Material originalMaterial;

			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Color albedoTint;

			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector4 uvTileOffset;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float normalIntensity;

			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float occlusionIntensity;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public float smoothnessIntensity;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float glossMapScale;

			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float metalIntensity;

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Color emissionColor;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Vector4 detailUVTileOffset;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public float alphaCutoff;

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Color specularColor;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public float detailNormalScale;

			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			public float heightIntensity;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public readonly float uvSec;

			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x10E1BE0", Offset = "0x10E1BE0", VA = "0x10E1BE0")]
			public MaterialProperties(int texArrIndex, int matIndex, string materialName, Material originalMaterial, Color albedoTint, Vector4 uvTileOffset, float normalIntensity, float occlusionIntensity, float smoothnessIntensity, float glossMapScale, float metalIntensity, Color emissionColor, Vector4 detailUVTileOffset, float alphaCutoff, Color specularColor, float detailNormalScale, float heightIntensity, float uvSec)
			{
			}

			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x10E1E3C", Offset = "0x10E1E3C", VA = "0x10E1E3C")]
			public void BurnAttrToImg(ref Texture2D burnOn, int index, int textureArrayIndex)
			{
			}
		}

		[Token(Token = "0x20000ED")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640C4C", Offset = "0x640C4C")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int totalTriangles;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SimplificationOptions simplificationOptions;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float quality;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object threadLock1;

			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int threadsRunning;

			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int meshesHandled;

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public object threadLock3;

			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public object threadLock2;

			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public bool isError;

			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string error;

			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public List<CustomMeshActionStructure> meshAssignments;

			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public List<CustomMeshActionStructure> callbackFlusher;

			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x10DF1A0", Offset = "0x10DF1A0", VA = "0x10DF1A0")]
			public <>c__DisplayClass11_0()
			{
			}
		}

		[Token(Token = "0x20000EE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640C5C", Offset = "0x640C5C")]
		private sealed class <>c__DisplayClass11_1
		{
			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MeshRendererPair meshRendererPair;

			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject gameObject;

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MeshSimplifier meshSimplifier;

			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public <>c__DisplayClass11_0 CS$<>8__locals1;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action <>9__1;

			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x10DF1A8", Offset = "0x10DF1A8", VA = "0x10DF1A8")]
			public <>c__DisplayClass11_1()
			{
			}

			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x10DF1B0", Offset = "0x10DF1B0", VA = "0x10DF1B0")]
			internal void <SimplifyObjectDeep>b__0()
			{
			}

			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x10DF810", Offset = "0x10DF810", VA = "0x10DF810")]
			internal void <SimplifyObjectDeep>b__1()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640C6C", Offset = "0x640C6C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action <>9__11_2;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Action <>9__13_2;

			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Action <>9__14_2;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<Renderer, bool> <>9__16_0;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<Renderer, MeshRenderer> <>9__16_1;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Func<Renderer, bool> <>9__16_2;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static Func<Renderer, SkinnedMeshRenderer> <>9__16_3;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static Func<Renderer, bool> <>9__16_4;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static Func<Renderer, MeshRenderer> <>9__16_5;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static Func<Renderer, bool> <>9__16_6;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public static Func<Renderer, SkinnedMeshRenderer> <>9__16_7;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public static Func<SkinnedMeshRenderer, bool> <>9__16_8;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public static Func<MeshRenderer, bool> <>9__17_0;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public static Func<MeshRenderer, MeshRenderer> <>9__17_1;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public static Func<SkinnedMeshRenderer, bool> <>9__17_2;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public static Func<SkinnedMeshRenderer, SkinnedMeshRenderer> <>9__17_3;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public static Func<SkinnedMeshRenderer, bool> <>9__18_0;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public static Func<SkinnedMeshRenderer, bool> <>9__18_1;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public static Func<SkinnedMeshRenderer, bool> <>9__19_0;

			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x10DE598", Offset = "0x10DE598", VA = "0x10DE598")]
			public <>c()
			{
			}

			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x10DE5A0", Offset = "0x10DE5A0", VA = "0x10DE5A0")]
			internal void <SimplifyObjectDeep>b__11_2()
			{
			}

			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x10DE5A4", Offset = "0x10DE5A4", VA = "0x10DE5A4")]
			internal void <SimplifyObjectDeep>b__13_2()
			{
			}

			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x10DE5A8", Offset = "0x10DE5A8", VA = "0x10DE5A8")]
			internal void <SimplifyMeshes>b__14_2()
			{
			}

			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x10DE5AC", Offset = "0x10DE5AC", VA = "0x10DE5AC")]
			internal bool <CombineMeshesInGameObject>b__16_0(Renderer renderer)
			{
				return default(bool);
			}

			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x10DE760", Offset = "0x10DE760", VA = "0x10DE760")]
			internal MeshRenderer <CombineMeshesInGameObject>b__16_1(Renderer renderer)
			{
				return null;
			}

			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x10DE7DC", Offset = "0x10DE7DC", VA = "0x10DE7DC")]
			internal bool <CombineMeshesInGameObject>b__16_2(Renderer renderer)
			{
				return default(bool);
			}

			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x10DE938", Offset = "0x10DE938", VA = "0x10DE938")]
			internal SkinnedMeshRenderer <CombineMeshesInGameObject>b__16_3(Renderer renderer)
			{
				return null;
			}

			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x10DE9B4", Offset = "0x10DE9B4", VA = "0x10DE9B4")]
			internal bool <CombineMeshesInGameObject>b__16_4(Renderer renderer)
			{
				return default(bool);
			}

			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x10DEB48", Offset = "0x10DEB48", VA = "0x10DEB48")]
			internal MeshRenderer <CombineMeshesInGameObject>b__16_5(Renderer renderer)
			{
				return null;
			}

			[Token(Token = "0x60006EA")]
			[Address(RVA = "0x10DEBC4", Offset = "0x10DEBC4", VA = "0x10DEBC4")]
			internal bool <CombineMeshesInGameObject>b__16_6(Renderer renderer)
			{
				return default(bool);
			}

			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x10DED00", Offset = "0x10DED00", VA = "0x10DED00")]
			internal SkinnedMeshRenderer <CombineMeshesInGameObject>b__16_7(Renderer renderer)
			{
				return null;
			}

			[Token(Token = "0x60006EC")]
			[Address(RVA = "0x10DED7C", Offset = "0x10DED7C", VA = "0x10DED7C")]
			internal bool <CombineMeshesInGameObject>b__16_8(SkinnedMeshRenderer renderer)
			{
				return default(bool);
			}

			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x10DEE00", Offset = "0x10DEE00", VA = "0x10DEE00")]
			internal bool <CombineMeshesFromRenderers>b__17_0(MeshRenderer renderer)
			{
				return default(bool);
			}

			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x10DEF18", Offset = "0x10DEF18", VA = "0x10DEF18")]
			internal MeshRenderer <CombineMeshesFromRenderers>b__17_1(MeshRenderer renderer)
			{
				return null;
			}

			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x10DEF20", Offset = "0x10DEF20", VA = "0x10DEF20")]
			internal bool <CombineMeshesFromRenderers>b__17_2(SkinnedMeshRenderer renderer)
			{
				return default(bool);
			}

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x10DEFD0", Offset = "0x10DEFD0", VA = "0x10DEFD0")]
			internal SkinnedMeshRenderer <CombineMeshesFromRenderers>b__17_3(SkinnedMeshRenderer renderer)
			{
				return null;
			}

			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x10DEFD8", Offset = "0x10DEFD8", VA = "0x10DEFD8")]
			internal bool <ConvertSkinnedMeshesInGameObject>b__18_0(SkinnedMeshRenderer renderer)
			{
				return default(bool);
			}

			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x10DF098", Offset = "0x10DF098", VA = "0x10DF098")]
			internal bool <ConvertSkinnedMeshesInGameObject>b__18_1(SkinnedMeshRenderer renderer)
			{
				return default(bool);
			}

			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x10DF11C", Offset = "0x10DF11C", VA = "0x10DF11C")]
			internal bool <ConvertSkinnedMeshesFromRenderers>b__19_0(SkinnedMeshRenderer renderer)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640C7C", Offset = "0x640C7C")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ObjectMeshPairs toReturn;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SimplificationOptions simplificationOptions;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float quality;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object threadLock1;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int threadsRunning;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int meshesHandled;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public object threadLock2;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool isError;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string error;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public List<CustomMeshActionStructure> meshAssignments;

			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x10DF8E0", Offset = "0x10DF8E0", VA = "0x10DF8E0")]
			public <>c__DisplayClass12_0()
			{
			}
		}

		[Token(Token = "0x20000F1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640C8C", Offset = "0x640C8C")]
		private sealed class <>c__DisplayClass12_1
		{
			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MeshRendererPair meshRendererPair;

			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject gameObject;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MeshSimplifier meshSimplifier;

			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public <>c__DisplayClass12_0 CS$<>8__locals1;

			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action <>9__1;

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x10DF8E8", Offset = "0x10DF8E8", VA = "0x10DF8E8")]
			public <>c__DisplayClass12_1()
			{
			}

			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x10DF8F0", Offset = "0x10DF8F0", VA = "0x10DF8F0")]
			internal void <SimplifyObjectDeep>b__0()
			{
			}

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x10DFD10", Offset = "0x10DFD10", VA = "0x10DFD10")]
			internal void <SimplifyObjectDeep>b__1()
			{
			}
		}

		[Token(Token = "0x20000F2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640C9C", Offset = "0x640C9C")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int totalTriangles;

			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SimplificationOptions simplificationOptions;

			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float quality;

			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object threadLock1;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int threadsRunning;

			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int meshesHandled;

			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public object threadLock3;

			[Token(Token = "0x4000681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public object threadLock2;

			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public bool isError;

			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string error;

			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public List<CustomMeshActionStructure> meshAssignments;

			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public List<CustomMeshActionStructure> callbackFlusher;

			[Token(Token = "0x60006F8")]
			[Address(RVA = "0x10DFEE4", Offset = "0x10DFEE4", VA = "0x10DFEE4")]
			public <>c__DisplayClass13_0()
			{
			}
		}

		[Token(Token = "0x20000F3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640CAC", Offset = "0x640CAC")]
		private sealed class <>c__DisplayClass13_1
		{
			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MeshRendererPair meshRendererPair;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject gameObject;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MeshSimplifier meshSimplifier;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public <>c__DisplayClass13_0 CS$<>8__locals1;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action <>9__1;

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x10DFEEC", Offset = "0x10DFEEC", VA = "0x10DFEEC")]
			public <>c__DisplayClass13_1()
			{
			}

			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x10DFEF4", Offset = "0x10DFEF4", VA = "0x10DFEF4")]
			internal void <SimplifyObjectDeep>b__0()
			{
			}

			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x10E04F0", Offset = "0x10E04F0", VA = "0x10E04F0")]
			internal void <SimplifyObjectDeep>b__1()
			{
			}
		}

		[Token(Token = "0x20000F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640CBC", Offset = "0x640CBC")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x400068B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Mesh> simplifiedMeshes;

			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SimplificationOptions simplificationOptions;

			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float quality;

			[Token(Token = "0x400068E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object threadLock1;

			[Token(Token = "0x400068F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int threadsRunning;

			[Token(Token = "0x4000690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int meshesHandled;

			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public object threadLock3;

			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public object threadLock2;

			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public bool isError;

			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string error;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public List<CustomMeshActionStructure> meshAssignments;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public List<CustomMeshActionStructure> callbackFlusher;

			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x10E05C0", Offset = "0x10E05C0", VA = "0x10E05C0")]
			public <>c__DisplayClass14_0()
			{
			}
		}

		[Token(Token = "0x20000F5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640CCC", Offset = "0x640CCC")]
		private sealed class <>c__DisplayClass14_1
		{
			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Mesh meshToSimplify;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MeshSimplifier meshSimplifier;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public <>c__DisplayClass14_0 CS$<>8__locals1;

			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action <>9__1;

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x10E05C8", Offset = "0x10E05C8", VA = "0x10E05C8")]
			public <>c__DisplayClass14_1()
			{
			}

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x10E05D0", Offset = "0x10E05D0", VA = "0x10E05D0")]
			internal void <SimplifyMeshes>b__0()
			{
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x10E0C00", Offset = "0x10E0C00", VA = "0x10E0C00")]
			internal void <SimplifyMeshes>b__1()
			{
			}
		}

		[Token(Token = "0x20000F6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640CDC", Offset = "0x640CDC")]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<GameObject> OnSuccess;

			[Token(Token = "0x6000700")]
			[Address(RVA = "0x10E0D34", Offset = "0x10E0D34", VA = "0x10E0D34")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x6000701")]
			[Address(RVA = "0x10E0D3C", Offset = "0x10E0D3C", VA = "0x10E0D3C")]
			internal void <ImportOBJFromFileSystem>b__0(GameObject importedObject)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640CEC", Offset = "0x640CEC")]
		private struct <ImportOBJFromFileSystem>d__20 : IAsyncStateMachine
		{
			[Token(Token = "0x400069D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400069E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<GameObject> OnSuccess;

			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string objAbsolutePath;

			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string texturesFolderPath;

			[Token(Token = "0x40006A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string materialsFolderPath;

			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public OBJImportOptions importOptions;

			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private <>c__DisplayClass20_0 <>8__1;

			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Action<Exception> OnError;

			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x6000702")]
			[Address(RVA = "0x10E12E4", Offset = "0x10E12E4", VA = "0x10E12E4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0x10E17D0", Offset = "0x10E17D0", VA = "0x10E17D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20000F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640CFC", Offset = "0x640CFC")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<GameObject> OnSuccess;

			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<Exception> OnError;

			[Token(Token = "0x6000704")]
			[Address(RVA = "0x10E0DA4", Offset = "0x10E0DA4", VA = "0x10E0DA4")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0x10E0DAC", Offset = "0x10E0DAC", VA = "0x10E0DAC")]
			internal void <ImportOBJFromNetwork>b__0(GameObject importedObject)
			{
			}

			[Token(Token = "0x6000706")]
			[Address(RVA = "0x10E0E14", Offset = "0x10E0E14", VA = "0x10E0E14")]
			internal void <ImportOBJFromNetwork>b__1(Exception ex)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640D0C", Offset = "0x640D0C")]
		private struct <ImportOBJFromNetwork>d__21 : IAsyncStateMachine
		{
			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<GameObject> OnSuccess;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<Exception> OnError;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string objURL;

			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string objName;

			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string diffuseTexURL;

			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string bumpTexURL;

			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public string specularTexURL;

			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public string opacityTexURL;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public string materialURL;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public ReferencedNumeric<float> downloadProgress;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public OBJImportOptions importOptions;

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private <>c__DisplayClass21_0 <>8__1;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x6000707")]
			[Address(RVA = "0x10E17DC", Offset = "0x10E17DC", VA = "0x10E17DC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000708")]
			[Address(RVA = "0x10E1BD4", Offset = "0x10E1BD4", VA = "0x10E1BD4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20000FA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640D1C", Offset = "0x640D1C")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action OnSuccess;

			[Token(Token = "0x6000709")]
			[Address(RVA = "0x10E0E7C", Offset = "0x10E0E7C", VA = "0x10E0E7C")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x600070A")]
			[Address(RVA = "0x10E0E84", Offset = "0x10E0E84", VA = "0x10E0E84")]
			internal void <ExportGameObjectToOBJ>b__0()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000FB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640D2C", Offset = "0x640D2C")]
		private struct <ExportGameObjectToOBJ>d__22 : IAsyncStateMachine
		{
			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action OnSuccess;

			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GameObject toExport;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string exportPath;

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public OBJExportOptions exportOptions;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Action<Exception> OnError;

			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private <>c__DisplayClass22_0 <>8__1;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x600070B")]
			[Address(RVA = "0x10E0EA8", Offset = "0x10E0EA8", VA = "0x10E0EA8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600070C")]
			[Address(RVA = "0x10E12D8", Offset = "0x10E12D8", VA = "0x10E12D8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000614")]
		private const int MAX_LOD_COUNT = 8;

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xC54344", Offset = "0xC54344", VA = "0xC54344")]
		public static int SimplifyObjectDeep(GameObject toSimplify, SimplificationOptions simplificationOptions, Action<GameObject, MeshRendererPair> OnEachMeshSimplified)
		{
			return default(int);
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xC56B08", Offset = "0xC56B08", VA = "0xC56B08")]
		public static ObjectMeshPairs SimplifyObjectDeep(GameObject toSimplify, SimplificationOptions simplificationOptions)
		{
			return null;
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xC587C0", Offset = "0xC587C0", VA = "0xC587C0")]
		public static int SimplifyObjectDeep(ObjectMeshPairs objectMeshPairs, SimplificationOptions simplificationOptions, Action<GameObject, MeshRendererPair> OnEachMeshSimplified)
		{
			return default(int);
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xC5A5FC", Offset = "0xC5A5FC", VA = "0xC5A5FC")]
		public static List<Mesh> SimplifyMeshes(List<Mesh> meshesToSimplify, SimplificationOptions simplificationOptions, Action<Mesh> OnEachMeshSimplified)
		{
			return null;
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xC56220", Offset = "0xC56220", VA = "0xC56220")]
		public static ObjectMeshPairs GetObjectMeshPairs(GameObject forObject, bool includeInactive)
		{
			return null;
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xC5B524", Offset = "0xC5B524", VA = "0xC5B524")]
		public static void CombineMeshesInGameObject(GameObject forObject, bool skipInactiveRenderers, Action<string, string> OnError, MeshCombineTarget combineTarget = MeshCombineTarget.SkinnedAndStatic)
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xC5C8F4", Offset = "0xC5C8F4", VA = "0xC5C8F4")]
		public static GameObject CombineMeshesFromRenderers(Transform rootTransform, MeshRenderer[] originalMeshRenderers, SkinnedMeshRenderer[] originalSkinnedMeshRenderers, Action<string, string> OnError)
		{
			return null;
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xC5D14C", Offset = "0xC5D14C", VA = "0xC5D14C")]
		public static void ConvertSkinnedMeshesInGameObject(GameObject forObject, bool skipInactiveRenderers, Action<string, string> OnError)
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xC5D958", Offset = "0xC5D958", VA = "0xC5D958")]
		public static Tuple<SkinnedMeshRenderer, MeshRenderer, Mesh>[] ConvertSkinnedMeshesFromRenderers(SkinnedMeshRenderer[] renderersToConvert, Action<string, string> OnError)
		{
			return null;
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xC5DF18", Offset = "0xC5DF18", VA = "0xC5DF18")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x64AE58", Offset = "0x64AE58")]
		public static void ImportOBJFromFileSystem(string objAbsolutePath, string texturesFolderPath, string materialsFolderPath, Action<GameObject> OnSuccess, Action<Exception> OnError, [Optional] OBJImportOptions importOptions)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xC5E06C", Offset = "0xC5E06C", VA = "0xC5E06C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x64AEB8", Offset = "0x64AEB8")]
		public static void ImportOBJFromNetwork(string objURL, string objName, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, ReferencedNumeric<float> downloadProgress, Action<GameObject> OnSuccess, Action<Exception> OnError, [Optional] OBJImportOptions importOptions)
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xC5E22C", Offset = "0xC5E22C", VA = "0xC5E22C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x64AF18", Offset = "0x64AF18")]
		public static void ExportGameObjectToOBJ(GameObject toExport, string exportPath, Action OnSuccess, Action<Exception> OnError, [Optional] OBJExportOptions exportOptions)
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xC5E364", Offset = "0xC5E364", VA = "0xC5E364")]
		public static int CountTriangles(bool countDeep, GameObject forObject)
		{
			return default(int);
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xC5B354", Offset = "0xC5B354", VA = "0xC5B354")]
		public static int CountTriangles(List<Mesh> toCount)
		{
			return default(int);
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xC5E74C", Offset = "0xC5E74C", VA = "0xC5E74C")]
		public static List<MaterialProperties> GetMaterialsProperties(GameObject forObject)
		{
			return null;
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xC5EC18", Offset = "0xC5EC18", VA = "0xC5EC18")]
		public static void ChangeMaterialProperties(MaterialProperties changeTo, GameObject forObject)
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xC56AA0", Offset = "0xC56AA0", VA = "0xC56AA0")]
		private static void SetParametersForSimplifier(SimplificationOptions simplificationOptions, MeshSimplifier meshSimplifier)
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xC56574", Offset = "0xC56574", VA = "0xC56574")]
		private static bool AreAnyFeasibleMeshes(ObjectMeshPairs objectMeshPairs)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xC5ED10", Offset = "0xC5ED10", VA = "0xC5ED10")]
		private static void AssignReducedMesh(GameObject gameObject, Mesh originalMesh, Mesh reducedMesh, bool attachedToMeshfilter, bool assignBindposes)
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xC56888", Offset = "0xC56888", VA = "0xC56888")]
		private static int CountTriangles(ObjectMeshPairs objectMeshPairs)
		{
			return default(int);
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xC5EF10", Offset = "0xC5EF10", VA = "0xC5EF10")]
		public PolyfewRuntime()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class UtilityServicesRuntime : MonoBehaviour
	{
		[Token(Token = "0x20000FD")]
		public class OBJExporterImporter
		{
			[StructLayout(3)]
			[Token(Token = "0x20000FE")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640D3C", Offset = "0x640D3C")]
			private struct <ExportMeshToOBJ>d__15 : IAsyncStateMachine
			{
				[Token(Token = "0x40006CD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int <>1__state;

				[Token(Token = "0x40006CE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Token(Token = "0x40006CF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public OBJExporterImporter <>4__this;

				[Token(Token = "0x40006D0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public Mesh mesh;

				[Token(Token = "0x40006D1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public string exportPath;

				[Token(Token = "0x40006D2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private string <objectName>5__2;

				[Token(Token = "0x40006D3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private StringBuilder <sb>5__3;

				[Token(Token = "0x40006D4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private int <lastIndex>5__4;

				[Token(Token = "0x40006D5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
				private int <faceOrder>5__5;

				[Token(Token = "0x40006D6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private Vector3[] <>7__wrap5;

				[Token(Token = "0x40006D7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private int <>7__wrap6;

				[Token(Token = "0x40006D8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
				private Vector3 <vx>5__8;

				[Token(Token = "0x40006D9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				private TaskAwaiter <>u__1;

				[Token(Token = "0x40006DA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				private Vector2[] <>7__wrap8;

				[Token(Token = "0x40006DB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				private Vector2 <v>5__10;

				[Token(Token = "0x40006DC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
				private int[] <tris>5__11;

				[Token(Token = "0x40006DD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
				private int <t>5__12;

				[Token(Token = "0x6000723")]
				[Address(RVA = "0x168BA34", Offset = "0x168BA34", VA = "0x168BA34", Slot = "4")]
				private void MoveNext()
				{
				}

				[Token(Token = "0x6000724")]
				[Address(RVA = "0x168D010", Offset = "0x168D010", VA = "0x168D010", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout(3)]
			[Token(Token = "0x20000FF")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640D4C", Offset = "0x640D4C")]
			private struct <ImportFromLocalFileSystem>d__20 : IAsyncStateMachine
			{
				[Token(Token = "0x40006DE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int <>1__state;

				[Token(Token = "0x40006DF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Token(Token = "0x40006E0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public string objPath;

				[Token(Token = "0x40006E1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public string texturesFolderPath;

				[Token(Token = "0x40006E2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public string materialsFolderPath;

				[Token(Token = "0x40006E3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				public PolyfewRuntime.OBJImportOptions importOptions;

				[Token(Token = "0x40006E4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				public Action<GameObject> Callback;

				[Token(Token = "0x40006E5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private GameObject <objectToPopulate>5__2;

				[Token(Token = "0x40006E6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private ObjectImporter <objImporter>5__3;

				[Token(Token = "0x40006E7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				private TaskAwaiter<GameObject> <>u__1;

				[Token(Token = "0x6000725")]
				[Address(RVA = "0x168D01C", Offset = "0x168D01C", VA = "0x168D01C", Slot = "4")]
				private void MoveNext()
				{
				}

				[Token(Token = "0x6000726")]
				[Address(RVA = "0x168DCF8", Offset = "0x168DCF8", VA = "0x168DCF8", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout(3)]
			[Token(Token = "0x2000100")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640D5C", Offset = "0x640D5C")]
			private struct <ImportFromNetwork>d__21 : IAsyncStateMachine
			{
				[Token(Token = "0x40006E8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int <>1__state;

				[Token(Token = "0x40006E9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Token(Token = "0x40006EA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public string objURL;

				[Token(Token = "0x40006EB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public string diffuseTexURL;

				[Token(Token = "0x40006EC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				public string materialURL;

				[Token(Token = "0x40006ED")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				public PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

				[Token(Token = "0x40006EE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				public PolyfewRuntime.OBJImportOptions importOptions;

				[Token(Token = "0x40006EF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				public string objName;

				[Token(Token = "0x40006F0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				public string bumpTexURL;

				[Token(Token = "0x40006F1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				public string specularTexURL;

				[Token(Token = "0x40006F2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				public string opacityTexURL;

				[Token(Token = "0x40006F3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				public Action<GameObject> OnSuccess;

				[Token(Token = "0x40006F4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				public Action<Exception> OnError;

				[Token(Token = "0x40006F5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
				private GameObject <objectToPopulate>5__2;

				[Token(Token = "0x40006F6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
				private ObjectImporter <objImporter>5__3;

				[Token(Token = "0x40006F7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
				private TaskAwaiter<GameObject> <>u__1;

				[Token(Token = "0x6000727")]
				[Address(RVA = "0x168DD04", Offset = "0x168DD04", VA = "0x168DD04", Slot = "4")]
				private void MoveNext()
				{
				}

				[Token(Token = "0x6000728")]
				[Address(RVA = "0x168E36C", Offset = "0x168E36C", VA = "0x168E36C", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Token(Token = "0x2000101")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640D6C", Offset = "0x640D6C")]
			private sealed class <>c__DisplayClass22_0
			{
				[Token(Token = "0x40006F8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public ObjectImporter objImporter;

				[Token(Token = "0x40006F9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public Action<GameObject> OnSuccess;

				[Token(Token = "0x40006FA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public GameObject objectToPopulate;

				[Token(Token = "0x40006FB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public Action<Exception> OnError;

				[Token(Token = "0x6000729")]
				[Address(RVA = "0x168B8EC", Offset = "0x168B8EC", VA = "0x168B8EC")]
				public <>c__DisplayClass22_0()
				{
				}

				[Token(Token = "0x600072A")]
				[Address(RVA = "0x168B8F4", Offset = "0x168B8F4", VA = "0x168B8F4")]
				internal void <ImportFromNetworkWebGL>b__0(GameObject imported)
				{
				}

				[Token(Token = "0x600072B")]
				[Address(RVA = "0x168B994", Offset = "0x168B994", VA = "0x168B994")]
				internal void <ImportFromNetworkWebGL>b__1(Exception exception)
				{
				}
			}

			[StructLayout(3)]
			[Token(Token = "0x2000102")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640D7C", Offset = "0x640D7C")]
			private struct <ImportFromNetworkWebGL>d__22 : IAsyncStateMachine
			{
				[Token(Token = "0x40006FC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int <>1__state;

				[Token(Token = "0x40006FD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Token(Token = "0x40006FE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public Action<GameObject> OnSuccess;

				[Token(Token = "0x40006FF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public Action<Exception> OnError;

				[Token(Token = "0x4000700")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				public string objURL;

				[Token(Token = "0x4000701")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				public string diffuseTexURL;

				[Token(Token = "0x4000702")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				public string materialURL;

				[Token(Token = "0x4000703")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				public PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

				[Token(Token = "0x4000704")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				public PolyfewRuntime.OBJImportOptions importOptions;

				[Token(Token = "0x4000705")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				public string objName;

				[Token(Token = "0x4000706")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				public string bumpTexURL;

				[Token(Token = "0x4000707")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				public string specularTexURL;

				[Token(Token = "0x4000708")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				public string opacityTexURL;

				[Token(Token = "0x600072C")]
				[Address(RVA = "0x168E378", Offset = "0x168E378", VA = "0x168E378", Slot = "4")]
				private void MoveNext()
				{
				}

				[Token(Token = "0x600072D")]
				[Address(RVA = "0x168E8C0", Offset = "0x168E8C0", VA = "0x168E8C0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private bool applyPosition;

			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			private bool applyRotation;

			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			private bool applyScale;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
			private bool generateMaterials;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private bool exportTextures;

			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private string exportPath;

			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private MeshFilter meshFilter;

			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Mesh meshToExport;

			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private MeshRenderer meshRenderer;

			[Token(Token = "0x6000715")]
			[Address(RVA = "0x1687090", Offset = "0x1687090", VA = "0x1687090")]
			public OBJExporterImporter()
			{
			}

			[Token(Token = "0x6000716")]
			[Address(RVA = "0x16870A8", Offset = "0x16870A8", VA = "0x16870A8")]
			private void InitializeExporter(GameObject toExport, string exportPath, PolyfewRuntime.OBJExportOptions exportOptions)
			{
			}

			[Token(Token = "0x6000717")]
			[Address(RVA = "0x1687490", Offset = "0x1687490", VA = "0x1687490")]
			private void InitializeExporter(Mesh toExport, string exportPath)
			{
			}

			[Token(Token = "0x6000718")]
			[Address(RVA = "0x1687678", Offset = "0x1687678", VA = "0x1687678")]
			private Vector3 RotateAroundPoint(Vector3 point, Vector3 pivot, Quaternion angle)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000719")]
			[Address(RVA = "0x16876D8", Offset = "0x16876D8", VA = "0x16876D8")]
			private Vector3 MultiplyVec3s(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600071A")]
			[Address(RVA = "0x16876E8", Offset = "0x16876E8", VA = "0x16876E8")]
			public void ExportGameObjectToOBJ(GameObject toExport, string exportPath, [Optional] PolyfewRuntime.OBJExportOptions exportOptions, [Optional] Action OnSuccess)
			{
			}

			[Token(Token = "0x600071B")]
			[Address(RVA = "0x1689220", Offset = "0x1689220", VA = "0x1689220")]
			[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x64AFA8", Offset = "0x64AFA8")]
			public Task ExportMeshToOBJ(Mesh mesh, string exportPath)
			{
				return null;
			}

			[Token(Token = "0x600071C")]
			[Address(RVA = "0x1689378", Offset = "0x1689378", VA = "0x1689378")]
			private string TryExportTexture(string propertyName, Material m, string exportPath)
			{
				return null;
			}

			[Token(Token = "0x600071D")]
			[Address(RVA = "0x168948C", Offset = "0x168948C", VA = "0x168948C")]
			private string ExportTexture(Texture2D t, string exportPath)
			{
				return null;
			}

			[Token(Token = "0x600071E")]
			[Address(RVA = "0x1689060", Offset = "0x1689060", VA = "0x1689060")]
			private string ConstructOBJString(int index)
			{
				return null;
			}

			[Token(Token = "0x600071F")]
			[Address(RVA = "0x1688884", Offset = "0x1688884", VA = "0x1688884")]
			private string MaterialToString(Material m)
			{
				return null;
			}

			[Token(Token = "0x6000720")]
			[Address(RVA = "0x1689840", Offset = "0x1689840", VA = "0x1689840")]
			[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x64B008", Offset = "0x64B008")]
			public Task ImportFromLocalFileSystem(string objPath, string texturesFolderPath, string materialsFolderPath, Action<GameObject> Callback, [Optional] PolyfewRuntime.OBJImportOptions importOptions)
			{
				return null;
			}

			[Token(Token = "0x6000721")]
			[Address(RVA = "0x16899C8", Offset = "0x16899C8", VA = "0x16899C8")]
			[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x64B068", Offset = "0x64B068")]
			public void ImportFromNetwork(string objURL, string objName, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Action<GameObject> OnSuccess, Action<Exception> OnError, [Optional] PolyfewRuntime.OBJImportOptions importOptions)
			{
			}

			[Token(Token = "0x6000722")]
			[Address(RVA = "0x1689B8C", Offset = "0x1689B8C", VA = "0x1689B8C")]
			[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x64B0C8", Offset = "0x64B0C8")]
			public void ImportFromNetworkWebGL(string objURL, string objName, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Action<GameObject> OnSuccess, Action<Exception> OnError, [Optional] PolyfewRuntime.OBJImportOptions importOptions)
			{
			}
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xE860D8", Offset = "0xE860D8", VA = "0xE860D8")]
		public static Texture2D DuplicateTexture(Texture2D source)
		{
			return null;
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xE862B0", Offset = "0xE862B0", VA = "0xE862B0")]
		public static Renderer[] GetChildRenderersForCombining(GameObject forObject, bool skipInactiveChildObjects)
		{
			return null;
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xE866FC", Offset = "0xE866FC", VA = "0xE866FC")]
		public static MeshRenderer CreateStaticLevelRenderer(string name, Transform parentTransform, Transform originalTransform, Mesh mesh, Material[] materials)
		{
			return null;
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xE86A7C", Offset = "0xE86A7C", VA = "0xE86A7C")]
		public static SkinnedMeshRenderer CreateSkinnedLevelRenderer(string name, Transform parentTransform, Transform originalTransform, Mesh mesh, Material[] materials, Transform rootBone, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xE864B8", Offset = "0xE864B8", VA = "0xE864B8")]
		private static void CollectChildRenderersForCombining(Transform transform, List<Renderer> resultRenderers, bool skipInactiveChildObjects)
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xE86A18", Offset = "0xE86A18", VA = "0xE86A18")]
		private static void ParentAndResetTransform(Transform transform, Transform parentTransform)
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xE86988", Offset = "0xE86988", VA = "0xE86988")]
		public static void ParentAndOffsetTransform(Transform transform, Transform parentTransform, Transform originalTransform)
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xE86CC0", Offset = "0xE86CC0", VA = "0xE86CC0")]
		public UtilityServicesRuntime()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class FlyCamera : MonoBehaviour
	{
		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float distance;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float xSpeed;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float ySpeed;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float panSpeed;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float yMinLimit;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float yMaxLimit;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float distanceMin;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float distanceMax;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody rigidbody;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float x;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float y;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool deactivated;

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x1690320", Offset = "0x1690320", VA = "0x1690320")]
		private void Start()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x1690404", Offset = "0x1690404", VA = "0x1690404")]
		private void Update()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x1690750", Offset = "0x1690750", VA = "0x1690750")]
		public static float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x1690780", Offset = "0x1690780", VA = "0x1690780")]
		public FlyCamera()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class PolygonReduction : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000105")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640D8C", Offset = "0x640D8C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<GameObject, PolyfewRuntime.MeshRendererPair> <>9__29_0;

			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Action<GameObject, PolyfewRuntime.MeshRendererPair> <>9__30_0;

			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Action<Exception> <>9__31_1;

			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Action<Exception> <>9__33_1;

			[Token(Token = "0x6000746")]
			[Address(RVA = "0x10E26AC", Offset = "0x10E26AC", VA = "0x10E26AC")]
			public <>c()
			{
			}

			[Token(Token = "0x6000747")]
			[Address(RVA = "0x10E26B4", Offset = "0x10E26B4", VA = "0x10E26B4")]
			internal void <OnReductionChange>b__29_0(GameObject go, PolyfewRuntime.MeshRendererPair mInfo)
			{
			}

			[Token(Token = "0x6000748")]
			[Address(RVA = "0x10E26B8", Offset = "0x10E26B8", VA = "0x10E26B8")]
			internal void <SimplifyLossless>b__30_0(GameObject go, PolyfewRuntime.MeshRendererPair mInfo)
			{
			}

			[Token(Token = "0x6000749")]
			[Address(RVA = "0x10E26BC", Offset = "0x10E26BC", VA = "0x10E26BC")]
			internal void <ImportOBJ>b__31_1(Exception ex)
			{
			}

			[Token(Token = "0x600074A")]
			[Address(RVA = "0x10E2768", Offset = "0x10E2768", VA = "0x10E2768")]
			internal void <ExportGameObjectToOBJ>b__33_1(Exception ex)
			{
			}
		}

		[Token(Token = "0x2000106")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640D9C", Offset = "0x640D9C")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject importedObject;

			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PolygonReduction <>4__this;

			[Token(Token = "0x600074B")]
			[Address(RVA = "0x10E2814", Offset = "0x10E2814", VA = "0x10E2814")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x600074C")]
			[Address(RVA = "0x10E281C", Offset = "0x10E281C", VA = "0x10E281C")]
			internal void <ImportOBJ>b__0(GameObject imp)
			{
			}
		}

		[Token(Token = "0x2000107")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640DAC", Offset = "0x640DAC")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PolygonReduction <>4__this;

			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject importedObject;

			[Token(Token = "0x600074D")]
			[Address(RVA = "0x1681694", Offset = "0x1681694", VA = "0x1681694")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x600074E")]
			[Address(RVA = "0x168169C", Offset = "0x168169C", VA = "0x168169C")]
			internal void <ImportOBJFromNetwork>b__0(GameObject imp)
			{
			}

			[Token(Token = "0x600074F")]
			[Address(RVA = "0x16818C0", Offset = "0x16818C0", VA = "0x16818C0")]
			internal void <ImportOBJFromNetwork>b__1(Exception ex)
			{
			}
		}

		[Token(Token = "0x2000108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640DBC", Offset = "0x640DBC")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject exportObject;

			[Token(Token = "0x400073B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PolygonReduction <>4__this;

			[Token(Token = "0x6000750")]
			[Address(RVA = "0x16819A0", Offset = "0x16819A0", VA = "0x16819A0")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x6000751")]
			[Address(RVA = "0x16819A8", Offset = "0x16819A8", VA = "0x16819A8")]
			internal void <ExportGameObjectToOBJ>b__0()
			{
			}
		}

		[Token(Token = "0x2000109")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640DCC", Offset = "0x640DCC")]
		private sealed class <ShowMessage>d__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400073C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400073D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400073E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string message;

			[Token(Token = "0x400073F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PolygonReduction <>4__this;

			[Token(Token = "0x170000B4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000755")]
				[Address(RVA = "0x1681C14", Offset = "0x1681C14", VA = "0x1681C14", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000757")]
				[Address(RVA = "0x1681C5C", Offset = "0x1681C5C", VA = "0x1681C5C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000752")]
			[Address(RVA = "0x1681AA8", Offset = "0x1681AA8", VA = "0x1681AA8")]
			[DebuggerHidden]
			public <ShowMessage>d__40(int <>1__state)
			{
			}

			[Token(Token = "0x6000753")]
			[Address(RVA = "0x1681AD4", Offset = "0x1681AD4", VA = "0x1681AD4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000754")]
			[Address(RVA = "0x1681AD8", Offset = "0x1681AD8", VA = "0x1681AD8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000756")]
			[Address(RVA = "0x1681C1C", Offset = "0x1681C1C", VA = "0x1681C1C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200010A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640DDC", Offset = "0x640DDC")]
		private sealed class <UpdateProgress>d__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000741")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000742")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PolygonReduction <>4__this;

			[Token(Token = "0x170000B6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600075B")]
				[Address(RVA = "0x1681DF4", Offset = "0x1681DF4", VA = "0x1681DF4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600075D")]
				[Address(RVA = "0x1681E3C", Offset = "0x1681E3C", VA = "0x1681E3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000758")]
			[Address(RVA = "0x1681C64", Offset = "0x1681C64", VA = "0x1681C64")]
			[DebuggerHidden]
			public <UpdateProgress>d__42(int <>1__state)
			{
			}

			[Token(Token = "0x6000759")]
			[Address(RVA = "0x1681C90", Offset = "0x1681C90", VA = "0x1681C90", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600075A")]
			[Address(RVA = "0x1681C94", Offset = "0x1681C94", VA = "0x1681C94", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0x1681DFC", Offset = "0x1681DFC", VA = "0x1681DFC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Slider reductionStrength;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Slider preservationStrength;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Toggle preserveUVFoldover;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Toggle preserveUVSeams;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Toggle preserveBorders;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Toggle enableSmartLinking;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Toggle preserveFace;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Toggle recalculateNormals;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Toggle regardCurvature;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InputField trianglesCount;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Text message;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Text progress;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Button exportButton;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Button importFromFileSystem;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Button importFromWeb;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Slider progressSlider;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public GameObject uninteractivePanel;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public GameObject targetObject;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Transform preservationSphere;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public EventSystem eventSystem;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private PolyfewRuntime.ObjectMeshPairs objectMeshPairs;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool didApplyLosslessLast;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool disableTemporary;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private GameObject barabarianRef;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool isImportingFromNetwork;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		private bool isWebGL;

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xE778E8", Offset = "0xE778E8", VA = "0xE778E8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xE779EC", Offset = "0xE779EC", VA = "0xE779EC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xE77BB4", Offset = "0xE77BB4", VA = "0xE77BB4")]
		public void OnReductionChange(float value)
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0xE78280", Offset = "0xE78280", VA = "0xE78280")]
		public void SimplifyLossless()
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0xE784C0", Offset = "0xE784C0", VA = "0xE784C0")]
		public void ImportOBJ()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0xE78768", Offset = "0xE78768", VA = "0xE78768")]
		public void ImportOBJFromNetwork()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xE78ACC", Offset = "0xE78ACC", VA = "0xE78ACC")]
		public void ExportGameObjectToOBJ()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0xE78E00", Offset = "0xE78E00", VA = "0xE78E00")]
		public void OnToggleStateChanged(bool isOn)
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0xE78EAC", Offset = "0xE78EAC", VA = "0xE78EAC")]
		public void OnPreservationStrengthChange(float value)
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0xE78EB4", Offset = "0xE78EB4", VA = "0xE78EB4")]
		public void Reset()
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0xE791CC", Offset = "0xE791CC", VA = "0xE791CC")]
		public static void OnSliderSelect()
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xE79234", Offset = "0xE79234", VA = "0xE79234")]
		public static void OnSliderDeselect()
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xE79298", Offset = "0xE79298", VA = "0xE79298")]
		private bool IsMouseOverUI(RectTransform uiElement)
		{
			return default(bool);
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0xE79318", Offset = "0xE79318", VA = "0xE79318")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x64B168", Offset = "0x64B168")]
		private IEnumerator ShowMessage(string message)
		{
			return null;
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xE790E4", Offset = "0xE790E4", VA = "0xE790E4")]
		private void ResetSettings()
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0xE78A54", Offset = "0xE78A54", VA = "0xE78A54")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x64B1C8", Offset = "0x64B1C8")]
		private IEnumerator UpdateProgress()
		{
			return null;
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0xE77F50", Offset = "0xE77F50", VA = "0xE77F50")]
		private void AssignMeshesFromPairs()
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0xE793AC", Offset = "0xE793AC", VA = "0xE793AC")]
		public PolygonReduction()
		{
		}
	}
}
namespace BrainFailProductions.PolyFew
{
	[Token(Token = "0x200010B")]
	public class CombiningInformation
	{
		[Token(Token = "0x200010C")]
		public enum DiffuseColorSpace
		{
			[Token(Token = "0x4000748")]
			NON_LINEAR,
			[Token(Token = "0x4000749")]
			LINEAR
		}

		[Token(Token = "0x200010D")]
		public enum CompressionType
		{
			[Token(Token = "0x400074B")]
			UNCOMPRESSED,
			[Token(Token = "0x400074C")]
			DXT1,
			[Token(Token = "0x400074D")]
			ETC2_RGB,
			[Token(Token = "0x400074E")]
			PVRTC_RGB4,
			[Token(Token = "0x400074F")]
			ASTC_RGB
		}

		[Token(Token = "0x200010E")]
		public enum CompressionQuality
		{
			[Token(Token = "0x4000751")]
			LOW,
			[Token(Token = "0x4000752")]
			MEDIUM,
			[Token(Token = "0x4000753")]
			HIGH
		}

		[Serializable]
		[Token(Token = "0x200010F")]
		public struct Resolution
		{
			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int width;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int height;
		}

		[Serializable]
		[Token(Token = "0x2000110")]
		public class TextureArrayUserSettings
		{
			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Resolution resolution;

			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FilterMode filteringMode;

			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public CompressionType compressionType;

			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CompressionQuality compressionQuality;

			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int anisotropicFilteringLevel;

			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int choiceResolutionW;

			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int choiceResolutionH;

			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int choiceFilteringMode;

			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int choiceCompressionQuality;

			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int choiceCompressionType;

			[Token(Token = "0x6000768")]
			[Address(RVA = "0x173DBAC", Offset = "0x173DBAC", VA = "0x173DBAC")]
			public TextureArrayUserSettings(Resolution resolution, FilterMode filteringMode, CompressionType compressionType, CompressionQuality compressionQuality = CompressionQuality.MEDIUM, int anisotropicFilteringLevel = 1)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000111")]
		public class TextureArrayGroup
		{
			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TextureArrayUserSettings diffuseArraySettings;

			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TextureArrayUserSettings metallicArraySettings;

			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TextureArrayUserSettings specularArraySettings;

			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TextureArrayUserSettings normalArraySettings;

			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public TextureArrayUserSettings heightArraySettings;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public TextureArrayUserSettings occlusionArraySettings;

			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public TextureArrayUserSettings emissiveArraySettings;

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public TextureArrayUserSettings detailMaskArraySettings;

			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public TextureArrayUserSettings detailAlbedoArraySettings;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public TextureArrayUserSettings detailNormalArraySettings;

			[Token(Token = "0x6000769")]
			[Address(RVA = "0x173D8F8", Offset = "0x173D8F8", VA = "0x173D8F8")]
			public void InitializeDefaultArraySettings(Resolution resolution, FilterMode filteringMode, CompressionType compressionType, CompressionQuality compressionQuality = CompressionQuality.MEDIUM, int anisotropicFilteringLevel = 1)
			{
			}

			[Token(Token = "0x600076A")]
			[Address(RVA = "0x173DC10", Offset = "0x173DC10", VA = "0x173DC10")]
			public TextureArrayGroup()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000112")]
		public class MaterialProperties
		{
			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool foldOut;

			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int texArrIndex;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int matIndex;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string materialName;

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Material originalMaterial;

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Color albedoTint;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Vector4 uvTileOffset;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public float normalIntensity;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float occlusionIntensity;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float smoothnessIntensity;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float glossMapScale;

			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public float metalIntensity;

			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public Color emissionColor;

			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector4 detailUVTileOffset;

			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			public float alphaCutoff;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public Color specularColor;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public float detailNormalScale;

			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			public float heightIntensity;

			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public float uvSec;

			[Token(Token = "0x400077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			public int alphaMode;

			[Token(Token = "0x400077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public bool specularWorkflow;

			[Token(Token = "0x600076B")]
			[Address(RVA = "0xE8B880", Offset = "0xE8B880", VA = "0xE8B880")]
			public bool IsSameAs(MaterialProperties toCompare)
			{
				return default(bool);
			}

			[Token(Token = "0x600076C")]
			[Address(RVA = "0xE8BA88", Offset = "0xE8BA88", VA = "0xE8BA88")]
			public static Texture2D NewTexture()
			{
				return null;
			}

			[Token(Token = "0x600076D")]
			[Address(RVA = "0xE8BB4C", Offset = "0xE8BB4C", VA = "0xE8BB4C")]
			public void BurnAttrToImg(ref Texture2D burnOn, int index, int textureArrayIndex)
			{
			}

			[Token(Token = "0x600076E")]
			[Address(RVA = "0xE8BF58", Offset = "0xE8BF58", VA = "0xE8BF58")]
			public void FillPropertiesFromMaterial(Material material, CombiningInformation combineInfo)
			{
			}

			[Token(Token = "0x600076F")]
			[Address(RVA = "0xE8C5DC", Offset = "0xE8C5DC", VA = "0xE8C5DC")]
			public MaterialProperties()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000113")]
		public class MeshData
		{
			[Token(Token = "0x400077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<MeshFilter> meshFilters;

			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<MeshRenderer> meshRenderers;

			[Token(Token = "0x4000781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<SkinnedMeshRenderer> skinnedMeshRenderers;

			[Token(Token = "0x4000782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Material[] originalMaterials;

			[Token(Token = "0x4000783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Mesh[] outputMeshes;

			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Matrix4x4[] outputMatrices;

			[Token(Token = "0x6000770")]
			[Address(RVA = "0x173D8F0", Offset = "0x173D8F0", VA = "0x173D8F0")]
			public MeshData()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000114")]
		public class CombineMetaData
		{
			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material material;

			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MaterialProperties materialProperties;

			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MaterialProperties tempMaterialProperties;

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<MeshData> meshesData;

			[Token(Token = "0x6000771")]
			[Address(RVA = "0xE8B540", Offset = "0xE8B540", VA = "0xE8B540")]
			public CombineMetaData()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000115")]
		public class MaterialEntity
		{
			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<CombineMetaData> combinedMats;

			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int textArrIndex;

			[Token(Token = "0x400078B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Texture2D diffuseMap;

			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Texture2D metallicMap;

			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Texture2D specularMap;

			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Texture2D normalMap;

			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Texture2D heightMap;

			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Texture2D occlusionMap;

			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Texture2D emissionMap;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Texture2D detailMaskMap;

			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Texture2D detailAlbedoMap;

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Texture2D detailNormalMap;

			[Token(Token = "0x6000772")]
			[Address(RVA = "0xE8B5C4", Offset = "0xE8B5C4", VA = "0xE8B5C4")]
			public bool HasAnyTextures()
			{
				return default(bool);
			}

			[Token(Token = "0x6000773")]
			[Address(RVA = "0xE8B7FC", Offset = "0xE8B7FC", VA = "0xE8B7FC")]
			public MaterialEntity()
			{
			}
		}

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<MaterialEntity> materialEntities;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextureArrayGroup textureArraysSettings;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DiffuseColorSpace diffuseColorSpace;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Material[] combinedMaterials;

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x15BBB98", Offset = "0x15BBB98", VA = "0x15BBB98")]
		public bool ShouldGenerateMetallicArray()
		{
			return default(bool);
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x15BBD1C", Offset = "0x15BBD1C", VA = "0x15BBD1C")]
		public bool ShouldGenerateSpecularArray()
		{
			return default(bool);
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x15BBEA0", Offset = "0x15BBEA0", VA = "0x15BBEA0")]
		public bool ShouldGenerateNormalArray()
		{
			return default(bool);
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x15BC024", Offset = "0x15BC024", VA = "0x15BC024")]
		public bool ShouldGenerateHeightArray()
		{
			return default(bool);
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x15BC1A8", Offset = "0x15BC1A8", VA = "0x15BC1A8")]
		public bool ShouldGenerateOcclusionArray()
		{
			return default(bool);
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x15BC32C", Offset = "0x15BC32C", VA = "0x15BC32C")]
		public bool ShouldGenerateEmissionArray()
		{
			return default(bool);
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x15BC4B0", Offset = "0x15BC4B0", VA = "0x15BC4B0")]
		public bool ShouldGenerateDetailMaskArray()
		{
			return default(bool);
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x15BC634", Offset = "0x15BC634", VA = "0x15BC634")]
		public bool ShouldGenerateDetailAlbedoArray()
		{
			return default(bool);
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x15BC7B8", Offset = "0x15BC7B8", VA = "0x15BC7B8")]
		public bool ShouldGenerateDetailNormalArray()
		{
			return default(bool);
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x15BC93C", Offset = "0x15BC93C", VA = "0x15BC93C")]
		public CombiningInformation()
		{
		}
	}
	[Token(Token = "0x2000116")]
	[ExecuteInEditMode]
	public class ObjectMaterialLinks : MonoBehaviour
	{
		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<CombiningInformation.MaterialEntity> linkedEntities;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<PolyfewRuntime.MaterialProperties> materialsProperties;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture2D linkedAttrImg;

		[Token(Token = "0x170000B8")]
		public List<CombiningInformation.MaterialEntity> linkedMaterialEntities
		{
			[Token(Token = "0x6000774")]
			[Address(RVA = "0xC53204", Offset = "0xC53204", VA = "0xC53204")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000775")]
			[Address(RVA = "0xC5320C", Offset = "0xC5320C", VA = "0xC5320C")]
			set
			{
			}
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0xC53528", Offset = "0xC53528", VA = "0xC53528")]
		private void Start()
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xC5383C", Offset = "0xC5383C", VA = "0xC5383C")]
		public ObjectMaterialLinks()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class PolyFew : MonoBehaviour
	{
		[Token(Token = "0x6000778")]
		[Address(RVA = "0xC5433C", Offset = "0xC5433C", VA = "0xC5433C")]
		public PolyFew()
		{
		}
	}
	[Token(Token = "0x2000118")]
	[ExecuteInEditMode]
	public class RefreshEnforcer : MonoBehaviour
	{
		[Token(Token = "0x6000779")]
		[Address(RVA = "0xE7BE74", Offset = "0xE7BE74", VA = "0xE7BE74")]
		private void Start()
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0xE7BED8", Offset = "0xE7BED8", VA = "0xE7BED8")]
		private void Update()
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0xE7BEDC", Offset = "0xE7BEDC", VA = "0xE7BEDC")]
		public RefreshEnforcer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000119")]
	[AttributeAttribute(Name = "DebuggerDisplayAttribute", RVA = "0x640E0C", Offset = "0x640E0C")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x640E0C", Offset = "0x640E0C")]
	public class SerializableDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
	{
		[Token(Token = "0x200011A")]
		private static class PrimeHelper
		{
			[Token(Token = "0x40007A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly int[] Primes;

			[Token(Token = "0x600079C")]
			public static bool IsPrime(int candidate)
			{
				return default(bool);
			}

			[Token(Token = "0x600079D")]
			public static int GetPrime(int min)
			{
				return default(int);
			}

			[Token(Token = "0x600079E")]
			public static int ExpandPrime(int oldSize)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200011B")]
		public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly SerializableDictionary<TKey, TValue> _Dictionary;

			[Token(Token = "0x40007A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int _Version;

			[Token(Token = "0x40007A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int _Index;

			[Token(Token = "0x40007A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private KeyValuePair<TKey, TValue> _Current;

			[Token(Token = "0x170000C0")]
			public KeyValuePair<TKey, TValue> Current
			{
				[Token(Token = "0x60007A0")]
				get
				{
					return default(KeyValuePair<TKey, TValue>);
				}
			}

			[Token(Token = "0x170000C1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007A4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007A1")]
			internal Enumerator(SerializableDictionary<TKey, TValue> dictionary)
			{
			}

			[Token(Token = "0x60007A2")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007A3")]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60007A5")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		private int[] _Buckets;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		private int[] _HashCodes;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[HideInInspector]
		[SerializeField]
		private int[] _Next;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[HideInInspector]
		[SerializeField]
		private int _Count;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[HideInInspector]
		[SerializeField]
		private int _Version;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[HideInInspector]
		[SerializeField]
		private int _FreeList;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		private int _FreeCount;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		private TKey[] _Keys;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		private TValue[] _Values;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly IEqualityComparer<TKey> _Comparer;

		[Token(Token = "0x170000B9")]
		public Dictionary<TKey, TValue> AsDictionary
		{
			[Token(Token = "0x600077C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BA")]
		public int Count
		{
			[Token(Token = "0x600077D")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000BB")]
		public TValue Item
		{
			[Token(Token = "0x600077E")]
			get
			{
				return (TValue)null;
			}
		}

		[Token(Token = "0x170000BC")]
		public TValue Item
		{
			[Token(Token = "0x600077F")]
			get
			{
				return (TValue)null;
			}
			[Token(Token = "0x6000780")]
			set
			{
			}
		}

		[Token(Token = "0x170000BD")]
		public ICollection<TKey> Keys
		{
			[Token(Token = "0x6000792")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BE")]
		public ICollection<TValue> Values
		{
			[Token(Token = "0x6000793")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BF")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000797")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000781")]
		public SerializableDictionary()
		{
		}

		[Token(Token = "0x6000782")]
		public SerializableDictionary(int capacity)
		{
		}

		[Token(Token = "0x6000783")]
		public SerializableDictionary(IEqualityComparer<TKey> comparer)
		{
		}

		[Token(Token = "0x6000784")]
		public SerializableDictionary(int capacity, IEqualityComparer<TKey> comparer)
		{
		}

		[Token(Token = "0x6000785")]
		public SerializableDictionary(IDictionary<TKey, TValue> dictionary)
		{
		}

		[Token(Token = "0x6000786")]
		public SerializableDictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer)
		{
		}

		[Token(Token = "0x6000787")]
		public bool ContainsValue(TValue value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000788")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000789")]
		public void Clear()
		{
		}

		[Token(Token = "0x600078A")]
		public void Add(TKey key, TValue value)
		{
		}

		[Token(Token = "0x600078B")]
		private void Resize(int newSize, bool forceNewHashCodes)
		{
		}

		[Token(Token = "0x600078C")]
		private void Resize()
		{
		}

		[Token(Token = "0x600078D")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x600078E")]
		private void Insert(TKey key, TValue value, bool add)
		{
		}

		[Token(Token = "0x600078F")]
		private void Initialize(int capacity)
		{
		}

		[Token(Token = "0x6000790")]
		private int FindIndex(TKey key)
		{
			return default(int);
		}

		[Token(Token = "0x6000791")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000794")]
		public void Add(KeyValuePair<TKey, TValue> item)
		{
		}

		[Token(Token = "0x6000795")]
		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000796")]
		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
		}

		[Token(Token = "0x6000798")]
		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000799")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x600079A")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600079B")]
		private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200011C")]
	public class ToleranceSphere : ScriptableObject
	{
		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 worldPosition;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float diameter;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color color;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float preservationStrength;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool isHidden;

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xE83A44", Offset = "0xE83A44", VA = "0xE83A44")]
		public ToleranceSphere(Vector3 worldPosition, float diameter, Color color, float preservationStrength, bool isHidden = false)
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xE83AD8", Offset = "0xE83AD8", VA = "0xE83AD8")]
		public void SetProperties(ToleranceSphereJson tSphereJson)
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xE83B1C", Offset = "0xE83B1C", VA = "0xE83B1C")]
		public void SetProperties(Vector3 worldPosition, float diameter, Color color, float preservationStrength, bool isHidden = false)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200011D")]
	public class ToleranceSphereJson
	{
		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 worldPosition;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float diameter;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float preservationStrength;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool isHidden;

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xE83B40", Offset = "0xE83B40", VA = "0xE83B40")]
		public ToleranceSphereJson(Vector3 worldPosition, float diameter, Color color, float preservationStrength, bool isHidden = false)
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xE83BD4", Offset = "0xE83BD4", VA = "0xE83BD4")]
		public ToleranceSphereJson(ToleranceSphere toleranceSphere)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xE83D28", Offset = "0xE83D28", VA = "0xE83D28")]
		public void SetProperties(Vector3 worldPosition, float diameter, Color color, float preservationStrength, bool isHidden = false)
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xE83C74", Offset = "0xE83C74", VA = "0xE83C74")]
		public void DumpFromToleranceSphere(ToleranceSphere toleranceSphere)
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xE83D4C", Offset = "0xE83D4C", VA = "0xE83D4C")]
		public void DumpToToleranceSphere(ref ToleranceSphere toleranceSphere)
		{
		}
	}
	[Token(Token = "0x200011E")]
	public static class SystemServices
	{
		[Serializable]
		[Token(Token = "0x200011F")]
		public struct RegexPatterns
		{
			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string netError;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string nullOrEmpty;

			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string generalError;

			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string apiMistmatch;

			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string parametersMismatch;

			[Token(Token = "0x40007B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string nothing;
		}

		[Token(Token = "0x2000120")]
		public struct MessagePatternPair
		{
			[Token(Token = "0x40007B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x648278", Offset = "0x648278")]
			private string <patternAppended>k__BackingField;

			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x648288", Offset = "0x648288")]
			private string <parsedMessage>k__BackingField;

			[Token(Token = "0x170000C2")]
			public string patternAppended
			{
				[Token(Token = "0x60007C0")]
				[Address(RVA = "0x168703C", Offset = "0x168703C", VA = "0x168703C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64B5D8", Offset = "0x64B5D8")]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x60007BF")]
				[Address(RVA = "0x1687034", Offset = "0x1687034", VA = "0x1687034")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64B5C8", Offset = "0x64B5C8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C3")]
			public string parsedMessage
			{
				[Token(Token = "0x60007C2")]
				[Address(RVA = "0x168704C", Offset = "0x168704C", VA = "0x168704C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64B620", Offset = "0x64B620")]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x60007C1")]
				[Address(RVA = "0x1687044", Offset = "0x1687044", VA = "0x1687044")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64B610", Offset = "0x64B610")]
				private set
				{
				}
			}

			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x1687054", Offset = "0x1687054", VA = "0x1687054")]
			public MessagePatternPair(string patternAppended, string parsedMessage)
			{
			}
		}

		[Token(Token = "0x2000121")]
		public class HTTPMethod
		{
			[Token(Token = "0x2000122")]
			public enum HTTPMethods
			{
				[Token(Token = "0x40007BC")]
				POST,
				[Token(Token = "0x40007BD")]
				GET
			}

			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly string methodName;

			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x1683424", Offset = "0x1683424", VA = "0x1683424")]
			public HTTPMethod(HTTPMethods method)
			{
			}
		}

		[Token(Token = "0x2000123")]
		public enum ImageFormat
		{
			[Token(Token = "0x40007BF")]
			PNG,
			[Token(Token = "0x40007C0")]
			JPG,
			[Token(Token = "0x40007C1")]
			EXR
		}

		[Token(Token = "0x2000124")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640E6C", Offset = "0x640E6C")]
		private sealed class <UnityAsyncGETRequest>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string encodedUrl;

			[Token(Token = "0x40007C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int? timeout;

			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Dictionary<string, string> headers;

			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action<string, long> callback;

			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UnityWebRequest <webRequest>5__2;

			[Token(Token = "0x170000C4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007C8")]
				[Address(RVA = "0x1685DDC", Offset = "0x1685DDC", VA = "0x1685DDC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007CA")]
				[Address(RVA = "0x1685E24", Offset = "0x1685E24", VA = "0x1685E24", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x16859C8", Offset = "0x16859C8", VA = "0x16859C8")]
			[DebuggerHidden]
			public <UnityAsyncGETRequest>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x16859F4", Offset = "0x16859F4", VA = "0x16859F4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x16859F8", Offset = "0x16859F8", VA = "0x16859F8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007C9")]
			[Address(RVA = "0x1685DE4", Offset = "0x1685DE4", VA = "0x1685DE4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000125")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640E7C", Offset = "0x640E7C")]
		private sealed class <UnityAsyncPOSTRequest>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string baseUrl;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int? timeout;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public byte[] data;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Dictionary<string, string> headers;

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action<string, long> callback;

			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UnityWebRequest <webRequest>5__2;

			[Token(Token = "0x170000C6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007CE")]
				[Address(RVA = "0x16862C4", Offset = "0x16862C4", VA = "0x16862C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007D0")]
				[Address(RVA = "0x168630C", Offset = "0x168630C", VA = "0x168630C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007CB")]
			[Address(RVA = "0x1685E2C", Offset = "0x1685E2C", VA = "0x1685E2C")]
			[DebuggerHidden]
			public <UnityAsyncPOSTRequest>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x1685E58", Offset = "0x1685E58", VA = "0x1685E58", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x1685E5C", Offset = "0x1685E5C", VA = "0x1685E5C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007CF")]
			[Address(RVA = "0x16862CC", Offset = "0x16862CC", VA = "0x16862CC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000126")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640E8C", Offset = "0x640E8C")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public HttpWebRequest request;

			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public byte[] postData;

			[Token(Token = "0x40007D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HttpWebResponse httpResponse;

			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x1682EC0", Offset = "0x1682EC0", VA = "0x1682EC0")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60007D2")]
			[Address(RVA = "0x1682EC8", Offset = "0x1682EC8", VA = "0x1682EC8")]
			internal void <SendHTTPRequestAsync>b__0()
			{
			}

			[Token(Token = "0x60007D3")]
			[Address(RVA = "0x168302C", Offset = "0x168302C", VA = "0x168302C")]
			internal void <SendHTTPRequestAsync>b__1()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000127")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640E9C", Offset = "0x640E9C")]
		private struct <SendHTTPRequestAsync>d__7 : IAsyncStateMachine
		{
			[Token(Token = "0x40007D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40007D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40007D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public byte[] postData;

			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private <>c__DisplayClass7_0 <>8__1;

			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string baseUrl;

			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action<string, HttpStatusCode?> callback;

			[Token(Token = "0x40007DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public int? timeout;

			[Token(Token = "0x40007DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public HTTPMethod requestMethod;

			[Token(Token = "0x40007DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Dictionary<string, string> header;

			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Dictionary<string, string> requestParameters;

			[Token(Token = "0x40007DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x40007DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private byte[] <paramsData>5__2;

			[Token(Token = "0x40007E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private TaskAwaiter<Stream> <>u__2;

			[Token(Token = "0x40007E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private TaskAwaiter<string> <>u__3;

			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x1684524", Offset = "0x1684524", VA = "0x1684524", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x16859BC", Offset = "0x16859BC", VA = "0x16859BC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000128")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640EAC", Offset = "0x640EAC")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x40007E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public HttpWebResponse httpResponse;

			[Token(Token = "0x40007E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HttpWebRequest request;

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x16830D4", Offset = "0x16830D4", VA = "0x16830D4")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x16830DC", Offset = "0x16830DC", VA = "0x16830DC")]
			internal void <AsyncResourceDownload>b__0()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000129")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640EBC", Offset = "0x640EBC")]
		private struct <AsyncResourceDownload>d__9 : IAsyncStateMachine
		{
			[Token(Token = "0x40007E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40007E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40007E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private <>c__DisplayClass9_0 <>8__1;

			[Token(Token = "0x40007E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string resourceUrl;

			[Token(Token = "0x40007E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<byte[], string, HttpStatusCode?> callback;

			[Token(Token = "0x40007E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int? timeout;

			[Token(Token = "0x40007EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x1683544", Offset = "0x1683544", VA = "0x1683544", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x1684310", Offset = "0x1684310", VA = "0x1684310", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x200012A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640ECC", Offset = "0x640ECC")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x40007EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<bool> callback;

			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x1682D70", Offset = "0x1682D70", VA = "0x1682D70")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x1682D78", Offset = "0x1682D78", VA = "0x1682D78")]
			internal void <AsyncReachabilityCheck>b__0(string response, HttpStatusCode? statusCode)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200012B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640EDC", Offset = "0x640EDC")]
		private struct <AsyncReachabilityCheck>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x40007EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40007ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40007EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<bool> callback;

			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string testUrl;

			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x1683184", Offset = "0x1683184", VA = "0x1683184", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x1683538", Offset = "0x1683538", VA = "0x1683538", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x200012C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640EEC", Offset = "0x640EEC")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<bool> callback;

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x1682E18", Offset = "0x1682E18", VA = "0x1682E18")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x1682E20", Offset = "0x1682E20", VA = "0x1682E20")]
			internal void <BlockingReachabilityCheck>b__0(string response, HttpStatusCode? statusCode)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200012D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640EFC", Offset = "0x640EFC")]
		private struct <RunDelayedCommand>d__17 : IAsyncStateMachine
		{
			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40007F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float secs;

			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action command;

			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x168431C", Offset = "0x168431C", VA = "0x168431C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x1684518", Offset = "0x1684518", VA = "0x1684518", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200012E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640F0C", Offset = "0x640F0C")]
		private struct <WriteTextureAsync>d__19 : IAsyncStateMachine
		{
			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40007F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40007F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ImageFormat format;

			[Token(Token = "0x40007FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Texture2D texture;

			[Token(Token = "0x40007FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string fileName;

			[Token(Token = "0x40007FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string path;

			[Token(Token = "0x40007FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action<string> callback;

			[Token(Token = "0x40007FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private byte[] <data>5__2;

			[Token(Token = "0x40007FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private FileStream <fileStream>5__3;

			[Token(Token = "0x4000800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x1686820", Offset = "0x1686820", VA = "0x1686820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x1687028", Offset = "0x1687028", VA = "0x1687028", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200012F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640F1C", Offset = "0x640F1C")]
		private struct <WriteBytesAsync>d__20 : IAsyncStateMachine
		{
			[Token(Token = "0x4000801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000802")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string fullPath;

			[Token(Token = "0x4000804")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public byte[] data;

			[Token(Token = "0x4000805")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<string> callback;

			[Token(Token = "0x4000806")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private FileStream <fileStream>5__2;

			[Token(Token = "0x4000807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x1686314", Offset = "0x1686314", VA = "0x1686314", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60007E5")]
			[Address(RVA = "0x1686814", Offset = "0x1686814", VA = "0x1686814", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static RegexPatterns regexPatterns;

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xE80164", Offset = "0xE80164", VA = "0xE80164")]
		private static void SetPatterns()
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xE80290", Offset = "0xE80290", VA = "0xE80290")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x64B2C8", Offset = "0x64B2C8")]
		public static IEnumerator UnityAsyncGETRequest(string encodedUrl, Action<string, long> callback, [Optional] int? timeout, [Optional] Dictionary<string, string> headers)
		{
			return null;
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xE80348", Offset = "0xE80348", VA = "0xE80348")]
		public static void UnityBlockingGETRequest(string encodedUrl, Action<string, long> callback, [Optional] int? timeout, [Optional] Dictionary<string, string> headers)
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xE806B0", Offset = "0xE806B0", VA = "0xE806B0")]
		public static void UnityBlockingPOSTRequest(string baseUrl, Action<string, long> callback, byte[] data, [Optional] int? timeout, [Optional] Dictionary<string, string> headers)
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0xE80A94", Offset = "0xE80A94", VA = "0xE80A94")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x64B328", Offset = "0x64B328")]
		public static IEnumerator UnityAsyncPOSTRequest(string baseUrl, Action<string, long> callback, byte[] data, [Optional] int? timeout, [Optional] Dictionary<string, string> headers)
		{
			return null;
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0xE80B60", Offset = "0xE80B60", VA = "0xE80B60")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x64B388", Offset = "0x64B388")]
		public static Task SendHTTPRequestAsync(string baseUrl, HTTPMethod requestMethod, Action<string, HttpStatusCode?> callback, Dictionary<string, string> requestParameters, byte[] postData, string contentType, [Optional] int? timeout, [Optional] Dictionary<string, string> header)
		{
			return null;
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0xE80D0C", Offset = "0xE80D0C", VA = "0xE80D0C")]
		public static void SendHTTPRequestBlocking(string baseUrl, HTTPMethod requestMethod, Action<string, HttpStatusCode?> callback, Dictionary<string, string> requestParameters, byte[] postData, string contentType, [Optional] int? timeout, [Optional] Dictionary<string, string> header)
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xE81AEC", Offset = "0xE81AEC", VA = "0xE81AEC")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x64B3E8", Offset = "0x64B3E8")]
		public static Task AsyncResourceDownload(string resourceUrl, Action<byte[], string, HttpStatusCode?> callback, [Optional] int? timeout)
		{
			return null;
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xE81C38", Offset = "0xE81C38", VA = "0xE81C38")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x64B448", Offset = "0x64B448")]
		public static Task AsyncReachabilityCheck(string testUrl, Action<bool> callback)
		{
			return null;
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xE81D80", Offset = "0xE81D80", VA = "0xE81D80")]
		public static void BlockingReachabilityCheck(string url, Action<bool> callback)
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xE81EC0", Offset = "0xE81EC0", VA = "0xE81EC0")]
		public static MessagePatternPair ParseResponseMessage(string message)
		{
			return default(MessagePatternPair);
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xE82210", Offset = "0xE82210", VA = "0xE82210")]
		public static bool IsSuccessStatusCode(long statusCode)
		{
			return default(bool);
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xE818B8", Offset = "0xE818B8", VA = "0xE818B8")]
		public static string GetQueryStringFromKeyValues(Dictionary<string, string> parameters)
		{
			return null;
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xE82220", Offset = "0xE82220", VA = "0xE82220")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x64B4A8", Offset = "0x64B4A8")]
		public static Task RunDelayedCommand(float secs, Action command)
		{
			return null;
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xE82360", Offset = "0xE82360", VA = "0xE82360")]
		public static byte[] ReadAllBytes(Stream source)
		{
			return null;
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0xE82590", Offset = "0xE82590", VA = "0xE82590")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x64B508", Offset = "0x64B508")]
		public static Task WriteTextureAsync(Texture2D texture, ImageFormat format, string fileName, string path, Action<string> callback)
		{
			return null;
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xE8270C", Offset = "0xE8270C", VA = "0xE8270C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x64B568", Offset = "0x64B568")]
		public static Task WriteBytesAsync(byte[] data, string fullPath, Action<string> callback)
		{
			return null;
		}
	}
}
namespace BrainFailProductions.PolyFew.AsImpL
{
	[Token(Token = "0x2000130")]
	public class DataSet
	{
		[Token(Token = "0x2000131")]
		public struct FaceIndices
		{
			[Token(Token = "0x4000811")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int vertIdx;

			[Token(Token = "0x4000812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int uvIdx;

			[Token(Token = "0x4000813")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int normIdx;
		}

		[Token(Token = "0x2000132")]
		public class ObjectData
		{
			[Token(Token = "0x4000814")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x4000815")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<FaceGroupData> faceGroups;

			[Token(Token = "0x4000816")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<FaceIndices> allFaces;

			[Token(Token = "0x4000817")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool hasNormals;

			[Token(Token = "0x4000818")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			public bool hasColors;

			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x173DCF0", Offset = "0x173DCF0", VA = "0x173DCF0")]
			public ObjectData()
			{
			}
		}

		[Token(Token = "0x2000133")]
		public class FaceGroupData
		{
			[Token(Token = "0x4000819")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x400081A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string materialName;

			[Token(Token = "0x400081B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<FaceIndices> faces;

			[Token(Token = "0x170000CA")]
			public bool IsEmpty
			{
				[Token(Token = "0x60007F6")]
				[Address(RVA = "0x173DC9C", Offset = "0x173DC9C", VA = "0x173DC9C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x173DC18", Offset = "0x173DC18", VA = "0x173DC18")]
			public FaceGroupData()
			{
			}
		}

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<ObjectData> objectList;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Vector3> vertList;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<Vector2> uvList;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<Vector3> normalList;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<Color> colorList;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int unnamedGroupIndex;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ObjectData currObjData;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private FaceGroupData currGroup;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool noFaceDefined;

		[Token(Token = "0x170000C8")]
		public string CurrGroupName
		{
			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x15BD498", Offset = "0x15BD498", VA = "0x15BD498")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C9")]
		public bool IsEmpty
		{
			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x15BD4F0", Offset = "0x15BD4F0", VA = "0x15BD4F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x15BD544", Offset = "0x15BD544", VA = "0x15BD544")]
		public static string GetFaceIndicesKey(FaceIndices fi)
		{
			return null;
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x15BD738", Offset = "0x15BD738", VA = "0x15BD738")]
		public static string FixMaterialName(string mtlName)
		{
			return null;
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x15BD7E8", Offset = "0x15BD7E8", VA = "0x15BD7E8")]
		public DataSet()
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x15BDA94", Offset = "0x15BDA94", VA = "0x15BDA94")]
		public void AddObject(string objectName)
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x15BDC78", Offset = "0x15BDC78", VA = "0x15BDC78")]
		public void AddGroup(string groupName)
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x15BDE28", Offset = "0x15BDE28", VA = "0x15BDE28")]
		public void AddMaterialName(string matName)
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x15BDEDC", Offset = "0x15BDEDC", VA = "0x15BDEDC")]
		public void AddVertex(Vector3 vertex)
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x15BDF58", Offset = "0x15BDF58", VA = "0x15BDF58")]
		public void AddUV(Vector2 uv)
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x15BDFC4", Offset = "0x15BDFC4", VA = "0x15BDFC4")]
		public void AddNormal(Vector3 normal)
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x15BE040", Offset = "0x15BE040", VA = "0x15BE040")]
		public void AddColor(Color color)
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x15BE0D8", Offset = "0x15BE0D8", VA = "0x15BE0D8")]
		public void AddFaceIndices(FaceIndices faceIdx)
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x15BE194", Offset = "0x15BE194", VA = "0x15BE194")]
		public void PrintSummary()
		{
		}
	}
	[Token(Token = "0x2000134")]
	public class MaterialData
	{
		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string materialName;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Color ambientColor;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color diffuseColor;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color specularColor;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color emissiveColor;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float shininess;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float overallAlpha;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int illumType;

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool hasReflectionTex;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string diffuseTexPath;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Texture2D diffuseTex;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public string bumpTexPath;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Texture2D bumpTex;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string specularTexPath;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Texture2D specularTex;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string opacityTexPath;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Texture2D opacityTex;

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0xC46220", Offset = "0xC46220", VA = "0xC46220")]
		public MaterialData()
		{
		}
	}
	[Token(Token = "0x2000135")]
	public class ModelUtil
	{
		[Token(Token = "0x2000136")]
		public enum MtlBlendMode
		{
			[Token(Token = "0x400082E")]
			OPAQUE,
			[Token(Token = "0x400082F")]
			CUTOUT,
			[Token(Token = "0x4000830")]
			FADE,
			[Token(Token = "0x4000831")]
			TRANSPARENT
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0xC4BEF4", Offset = "0xC4BEF4", VA = "0xC4BEF4")]
		public static void SetupMaterialWithBlendMode(Material mtl, MtlBlendMode mode)
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0xC4C3AC", Offset = "0xC4C3AC", VA = "0xC4C3AC")]
		public static bool ScanTransparentPixels(Texture2D texture, ref MtlBlendMode mode)
		{
			return default(bool);
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0xC4C574", Offset = "0xC4C574", VA = "0xC4C574")]
		public static void DetectMtlBlendFadeOrCutout(float alpha, ref MtlBlendMode mode, ref bool noDoubt)
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0xC4C5BC", Offset = "0xC4C5BC", VA = "0xC4C5BC")]
		public static Texture2D HeightToNormalMap(Texture2D bumpMap, float amount = 1f)
		{
			return null;
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0xC4C978", Offset = "0xC4C978", VA = "0xC4C978")]
		private static int WrapInt(int pos, int boundary)
		{
			return default(int);
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0xC4C994", Offset = "0xC4C994", VA = "0xC4C994")]
		public ModelUtil()
		{
		}
	}
	[Token(Token = "0x2000137")]
	public class ObjectBuilder
	{
		[Token(Token = "0x2000138")]
		public class ProgressInfo
		{
			[Token(Token = "0x400083B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int materialsLoaded;

			[Token(Token = "0x400083C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int objectsLoaded;

			[Token(Token = "0x400083D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int groupsLoaded;

			[Token(Token = "0x400083E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int numGroups;

			[Token(Token = "0x600080C")]
			[Address(RVA = "0x10D26C0", Offset = "0x10D26C0", VA = "0x10D26C0")]
			public ProgressInfo()
			{
			}
		}

		[Token(Token = "0x2000139")]
		private class BuildStatus
		{
			[Token(Token = "0x400083F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool newObject;

			[Token(Token = "0x4000840")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int objCount;

			[Token(Token = "0x4000841")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int subObjCount;

			[Token(Token = "0x4000842")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int idxCount;

			[Token(Token = "0x4000843")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int grpIdx;

			[Token(Token = "0x4000844")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int numGroups;

			[Token(Token = "0x4000845")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int grpFaceIdx;

			[Token(Token = "0x4000846")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int meshPartIdx;

			[Token(Token = "0x4000847")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int totFaceIdxCount;

			[Token(Token = "0x4000848")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public GameObject currObjGameObject;

			[Token(Token = "0x4000849")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal GameObject subObjParent;

			[Token(Token = "0x600080D")]
			[Address(RVA = "0x10DCE5C", Offset = "0x10DCE5C", VA = "0x10DCE5C")]
			public BuildStatus()
			{
			}
		}

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ImportOptions buildOptions;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private BuildStatus buildStatus;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DataSet currDataSet;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject currParentObj;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<string, Material> currMaterials;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<MaterialData> materialData;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int MAX_VERTICES_LIMIT_FOR_A_MESH;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int MAX_INDICES_LIMIT_FOR_A_MESH;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int MAX_VERT_COUNT;

		[Token(Token = "0x170000CB")]
		public Dictionary<string, Material> ImportedMaterials
		{
			[Token(Token = "0x60007FE")]
			[Address(RVA = "0xC4D9E4", Offset = "0xC4D9E4", VA = "0xC4D9E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CC")]
		public int NumImportedMaterials
		{
			[Token(Token = "0x60007FF")]
			[Address(RVA = "0xC4D9EC", Offset = "0xC4D9EC", VA = "0xC4D9EC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xC4DA48", Offset = "0xC4DA48", VA = "0xC4DA48")]
		public void InitBuildMaterials(List<MaterialData> materialData, bool hasColors)
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xC4DCD8", Offset = "0xC4DCD8", VA = "0xC4DCD8")]
		public bool BuildMaterials(ProgressInfo info)
		{
			return default(bool);
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xC4EA8C", Offset = "0xC4EA8C", VA = "0xC4EA8C")]
		public void StartBuildObjectAsync(DataSet dataSet, GameObject parentObj, [Optional] Dictionary<string, Material> materials)
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0xC4EAF0", Offset = "0xC4EAF0", VA = "0xC4EAF0")]
		public bool BuildObjectAsync(ref ProgressInfo info)
		{
			return default(bool);
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0xC4F834", Offset = "0xC4F834", VA = "0xC4F834")]
		public static void Solve(Mesh origMesh)
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0xC50000", Offset = "0xC50000", VA = "0xC50000")]
		public static void BuildMeshCollider(GameObject targetObject, bool convex = false, bool isTrigger = false, bool inflateMesh = false, float skinWidth = 0.01f)
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0xC4EB6C", Offset = "0xC4EB6C", VA = "0xC4EB6C")]
		protected bool BuildNextObject(GameObject parentObj, Dictionary<string, Material> mats)
		{
			return default(bool);
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xC50220", Offset = "0xC50220", VA = "0xC50220")]
		private GameObject ImportSubObject(GameObject parentObj, DataSet.ObjectData objData, Dictionary<string, Material> mats)
		{
			return null;
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xC4DED0", Offset = "0xC4DED0", VA = "0xC4DED0")]
		private Material BuildMaterial(MaterialData md)
		{
			return null;
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xC50174", Offset = "0xC50174", VA = "0xC50174")]
		private bool Using32bitIndices()
		{
			return default(bool);
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xC512AC", Offset = "0xC512AC", VA = "0xC512AC")]
		public ObjectBuilder()
		{
		}
	}
	[Token(Token = "0x200013A")]
	public static class Triangulator
	{
		[Token(Token = "0x600080E")]
		[Address(RVA = "0xE84D44", Offset = "0xE84D44", VA = "0xE84D44")]
		public static void Triangulate(DataSet dataSet, DataSet.FaceIndices[] face)
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xE85078", Offset = "0xE85078", VA = "0xE85078")]
		public static Vector3 FindPlaneNormal(DataSet dataSet, DataSet.FaceIndices[] face)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200013B")]
	public class ImportOptions
	{
		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x648298", Offset = "0x648298")]
		public bool zUp;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6482D0", Offset = "0x6482D0")]
		public bool litDiffuse;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x648308", Offset = "0x648308")]
		public bool convertToDoubleSided;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x648340", Offset = "0x648340")]
		public float modelScaling;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x648378", Offset = "0x648378")]
		public bool reuseLoaded;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6483B0", Offset = "0x6483B0")]
		public bool inheritLayer;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6483E8", Offset = "0x6483E8")]
		public bool buildColliders;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x648420", Offset = "0x648420")]
		public bool colliderConvex;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x648458", Offset = "0x648458")]
		public bool colliderTrigger;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x648490", Offset = "0x648490")]
		public bool use32bitIndices;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6484C8", Offset = "0x6484C8")]
		public bool hideWhileLoading;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x648500", Offset = "0x648500")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x648500", Offset = "0x648500")]
		public Vector3 localPosition;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x648560", Offset = "0x648560")]
		public Vector3 localEulerAngles;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x648598", Offset = "0x648598")]
		public Vector3 localScale;

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x12C14F0", Offset = "0x12C14F0", VA = "0x12C14F0")]
		public ImportOptions()
		{
		}
	}
	[Token(Token = "0x200013C")]
	public abstract class Loader : MonoBehaviour
	{
		[Token(Token = "0x200013D")]
		protected struct BuildStats
		{
			[Token(Token = "0x400086A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float texturesTime;

			[Token(Token = "0x400086B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float materialsTime;

			[Token(Token = "0x400086C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float objectsTime;
		}

		[Token(Token = "0x200013E")]
		protected struct Stats
		{
			[Token(Token = "0x400086D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float modelParseTime;

			[Token(Token = "0x400086E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float materialsParseTime;

			[Token(Token = "0x400086F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float buildTime;

			[Token(Token = "0x4000870")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public BuildStats buildStats;

			[Token(Token = "0x4000871")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float totalTime;
		}

		[StructLayout(3)]
		[Token(Token = "0x200013F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640F2C", Offset = "0x640F2C")]
		private struct <Load>d__33 : IAsyncStateMachine
		{
			[Token(Token = "0x4000872")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000873")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<GameObject> <>t__builder;

			[Token(Token = "0x4000874")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string objAbsolutePath;

			[Token(Token = "0x4000875")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string objName;

			[Token(Token = "0x4000876")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Loader <>4__this;

			[Token(Token = "0x4000877")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string texturesFolderPath;

			[Token(Token = "0x4000878")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string materialsFolderPath;

			[Token(Token = "0x4000879")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform parentObj;

			[Token(Token = "0x400087A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float <lastTime>5__2;

			[Token(Token = "0x400087B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private float <startTime>5__3;

			[Token(Token = "0x400087C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x400087D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private TaskAwaiter <>u__2;

			[Token(Token = "0x6000839")]
			[Address(RVA = "0x10D3628", Offset = "0x10D3628", VA = "0x10D3628", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600083A")]
			[Address(RVA = "0x10D3E8C", Offset = "0x10D3E8C", VA = "0x10D3E8C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000140")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640F3C", Offset = "0x640F3C")]
		private struct <LoadFromNetwork>d__34 : IAsyncStateMachine
		{
			[Token(Token = "0x400087E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400087F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<GameObject> <>t__builder;

			[Token(Token = "0x4000880")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string objName;

			[Token(Token = "0x4000881")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Loader <>4__this;

			[Token(Token = "0x4000882")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string objURL;

			[Token(Token = "0x4000883")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string materialURL;

			[Token(Token = "0x4000884")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string diffuseTexURL;

			[Token(Token = "0x4000885")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string bumpTexURL;

			[Token(Token = "0x4000886")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string specularTexURL;

			[Token(Token = "0x4000887")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public string opacityTexURL;

			[Token(Token = "0x4000888")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float <lastTime>5__2;

			[Token(Token = "0x4000889")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private float <startTime>5__3;

			[Token(Token = "0x400088A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x400088B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private TaskAwaiter <>u__2;

			[Token(Token = "0x600083B")]
			[Address(RVA = "0x10D3EE8", Offset = "0x10D3EE8", VA = "0x10D3EE8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600083C")]
			[Address(RVA = "0x10D4924", Offset = "0x10D4924", VA = "0x10D4924", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000141")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640F4C", Offset = "0x640F4C")]
		private sealed class <LoadFromNetworkWebGL>d__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400088C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400088D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400088E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string objName;

			[Token(Token = "0x400088F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Loader <>4__this;

			[Token(Token = "0x4000890")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string objURL;

			[Token(Token = "0x4000891")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action<Exception> OnError;

			[Token(Token = "0x4000892")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string materialURL;

			[Token(Token = "0x4000893")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string diffuseTexURL;

			[Token(Token = "0x4000894")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string bumpTexURL;

			[Token(Token = "0x4000895")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public string specularTexURL;

			[Token(Token = "0x4000896")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public string opacityTexURL;

			[Token(Token = "0x4000897")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Action<GameObject> OnSuccess;

			[Token(Token = "0x4000898")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private float <lastTime>5__2;

			[Token(Token = "0x4000899")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private float <startTime>5__3;

			[Token(Token = "0x170000D0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000840")]
				[Address(RVA = "0x10D4FA8", Offset = "0x10D4FA8", VA = "0x10D4FA8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000842")]
				[Address(RVA = "0x10D4FF0", Offset = "0x10D4FF0", VA = "0x10D4FF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600083D")]
			[Address(RVA = "0x10D4980", Offset = "0x10D4980", VA = "0x10D4980")]
			[DebuggerHidden]
			public <LoadFromNetworkWebGL>d__35(int <>1__state)
			{
			}

			[Token(Token = "0x600083E")]
			[Address(RVA = "0x10D49AC", Offset = "0x10D49AC", VA = "0x10D49AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600083F")]
			[Address(RVA = "0x10D49B0", Offset = "0x10D49B0", VA = "0x10D49B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000841")]
			[Address(RVA = "0x10D4FB0", Offset = "0x10D4FB0", VA = "0x10D4FB0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000142")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640F5C", Offset = "0x640F5C")]
		private struct <Build>d__43 : IAsyncStateMachine
		{
			[Token(Token = "0x400089A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400089B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400089C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Loader <>4__this;

			[Token(Token = "0x400089D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string absolutePath;

			[Token(Token = "0x400089E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string texturesFolderPath;

			[Token(Token = "0x400089F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string objName;

			[Token(Token = "0x40008A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Transform parentTransform;

			[Token(Token = "0x40008A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float <prevTime>5__2;

			[Token(Token = "0x40008A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private string <basePath>5__3;

			[Token(Token = "0x40008A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private int <count>5__4;

			[Token(Token = "0x40008A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private List<MaterialData>.Enumerator <>7__wrap4;

			[Token(Token = "0x40008A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private MaterialData <mtl>5__6;

			[Token(Token = "0x40008A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x6000843")]
			[Address(RVA = "0x10D18F8", Offset = "0x10D18F8", VA = "0x10D18F8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000844")]
			[Address(RVA = "0x10D26C8", Offset = "0x10D26C8", VA = "0x10D26C8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000143")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640F6C", Offset = "0x640F6C")]
		private struct <NetworkedBuild>d__44 : IAsyncStateMachine
		{
			[Token(Token = "0x40008A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40008A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40008A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Loader <>4__this;

			[Token(Token = "0x40008AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string diffuseTexURL;

			[Token(Token = "0x40008AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string bumpTexURL;

			[Token(Token = "0x40008AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string specularTexURL;

			[Token(Token = "0x40008AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string opacityTexURL;

			[Token(Token = "0x40008AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string objName;

			[Token(Token = "0x40008AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform parentTransform;

			[Token(Token = "0x40008B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public string objURL;

			[Token(Token = "0x40008B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float <prevTime>5__2;

			[Token(Token = "0x40008B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private ObjectBuilder.ProgressInfo <info>5__3;

			[Token(Token = "0x40008B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private float <objInitPerc>5__4;

			[Token(Token = "0x40008B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private GameObject <newObj>5__5;

			[Token(Token = "0x40008B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private float <initProgress>5__6;

			[Token(Token = "0x40008B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private int <count>5__7;

			[Token(Token = "0x40008B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private List<MaterialData>.Enumerator <>7__wrap7;

			[Token(Token = "0x40008B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private MaterialData <mtl>5__9;

			[Token(Token = "0x40008B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x6000845")]
			[Address(RVA = "0x10D646C", Offset = "0x10D646C", VA = "0x10D646C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000846")]
			[Address(RVA = "0x10D7988", Offset = "0x10D7988", VA = "0x10D7988", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640F7C", Offset = "0x640F7C")]
		private sealed class <NetworkedBuildWebGL>d__45 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Loader <>4__this;

			[Token(Token = "0x40008BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string diffuseTexURL;

			[Token(Token = "0x40008BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string bumpTexURL;

			[Token(Token = "0x40008BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string specularTexURL;

			[Token(Token = "0x40008C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string opacityTexURL;

			[Token(Token = "0x40008C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string objName;

			[Token(Token = "0x40008C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform parentTransform;

			[Token(Token = "0x40008C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public string objURL;

			[Token(Token = "0x40008C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float <prevTime>5__2;

			[Token(Token = "0x40008C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private int <count>5__3;

			[Token(Token = "0x40008C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private List<MaterialData>.Enumerator <>7__wrap3;

			[Token(Token = "0x40008C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private MaterialData <mtl>5__5;

			[Token(Token = "0x170000D2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600084B")]
				[Address(RVA = "0x10D879C", Offset = "0x10D879C", VA = "0x10D879C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600084D")]
				[Address(RVA = "0x10D87E4", Offset = "0x10D87E4", VA = "0x10D87E4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000847")]
			[Address(RVA = "0x10D7994", Offset = "0x10D7994", VA = "0x10D7994")]
			[DebuggerHidden]
			public <NetworkedBuildWebGL>d__45(int <>1__state)
			{
			}

			[Token(Token = "0x6000848")]
			[Address(RVA = "0x10D79C0", Offset = "0x10D79C0", VA = "0x10D79C0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000849")]
			[Address(RVA = "0x10D7A34", Offset = "0x10D7A34", VA = "0x10D7A34", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600084A")]
			[Address(RVA = "0x10D79E0", Offset = "0x10D79E0", VA = "0x10D79E0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600084C")]
			[Address(RVA = "0x10D87A4", Offset = "0x10D87A4", VA = "0x10D87A4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000145")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640F8C", Offset = "0x640F8C")]
		private struct <LoadMaterialTexture>d__51 : IAsyncStateMachine
		{
			[Token(Token = "0x40008C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40008C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40008CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Loader <>4__this;

			[Token(Token = "0x40008CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string texturesFolderPath;

			[Token(Token = "0x40008CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string basePath;

			[Token(Token = "0x40008CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string path;

			[Token(Token = "0x40008CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private byte[] <result>5__2;

			[Token(Token = "0x40008CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private FileStream <stream>5__3;

			[Token(Token = "0x40008D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private TaskAwaiter<int> <>u__1;

			[Token(Token = "0x600084E")]
			[Address(RVA = "0x10D4FF8", Offset = "0x10D4FF8", VA = "0x10D4FF8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600084F")]
			[Address(RVA = "0x10D57D8", Offset = "0x10D57D8", VA = "0x10D57D8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000146")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640F9C", Offset = "0x640F9C")]
		private sealed class <>c__DisplayClass52_0
		{
			[Token(Token = "0x40008D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			[Token(Token = "0x40008D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public byte[] downloadedBytes;

			[Token(Token = "0x6000850")]
			[Address(RVA = "0x10D1728", Offset = "0x10D1728", VA = "0x10D1728")]
			public <>c__DisplayClass52_0()
			{
			}

			[Token(Token = "0x6000851")]
			[Address(RVA = "0x10D1730", Offset = "0x10D1730", VA = "0x10D1730")]
			internal void <LoadMaterialTexture>b__0(byte[] bytes)
			{
			}

			[Token(Token = "0x6000852")]
			[Address(RVA = "0x10D173C", Offset = "0x10D173C", VA = "0x10D173C")]
			internal void <LoadMaterialTexture>b__1(string error)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000147")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640FAC", Offset = "0x640FAC")]
		private struct <LoadMaterialTexture>d__52 : IAsyncStateMachine
		{
			[Token(Token = "0x40008D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40008D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40008D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Loader <>4__this;

			[Token(Token = "0x40008D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string textureURL;

			[Token(Token = "0x40008D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private <>c__DisplayClass52_0 <>8__1;

			[Token(Token = "0x40008D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x6000853")]
			[Address(RVA = "0x10D57E4", Offset = "0x10D57E4", VA = "0x10D57E4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000854")]
			[Address(RVA = "0x10D5EF8", Offset = "0x10D5EF8", VA = "0x10D5EF8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000148")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640FBC", Offset = "0x640FBC")]
		private sealed class <>c__DisplayClass53_0
		{
			[Token(Token = "0x40008D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			[Token(Token = "0x40008DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Loader <>4__this;

			[Token(Token = "0x6000855")]
			[Address(RVA = "0x10D1804", Offset = "0x10D1804", VA = "0x10D1804")]
			public <>c__DisplayClass53_0()
			{
			}

			[Token(Token = "0x6000856")]
			[Address(RVA = "0x10D180C", Offset = "0x10D180C", VA = "0x10D180C")]
			internal void <LoadMaterialTextureWebGL>b__0(Texture2D texture)
			{
			}

			[Token(Token = "0x6000857")]
			[Address(RVA = "0x10D1830", Offset = "0x10D1830", VA = "0x10D1830")]
			internal void <LoadMaterialTextureWebGL>b__1(string error)
			{
			}
		}

		[Token(Token = "0x2000149")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640FCC", Offset = "0x640FCC")]
		private sealed class <LoadMaterialTextureWebGL>d__53 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Loader <>4__this;

			[Token(Token = "0x40008DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string textureURL;

			[Token(Token = "0x40008DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private <>c__DisplayClass53_0 <>8__1;

			[Token(Token = "0x170000D4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600085B")]
				[Address(RVA = "0x10D641C", Offset = "0x10D641C", VA = "0x10D641C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600085D")]
				[Address(RVA = "0x10D6464", Offset = "0x10D6464", VA = "0x10D6464", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000858")]
			[Address(RVA = "0x10D5F04", Offset = "0x10D5F04", VA = "0x10D5F04")]
			[DebuggerHidden]
			public <LoadMaterialTextureWebGL>d__53(int <>1__state)
			{
			}

			[Token(Token = "0x6000859")]
			[Address(RVA = "0x10D5F30", Offset = "0x10D5F30", VA = "0x10D5F30", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600085A")]
			[Address(RVA = "0x10D5F34", Offset = "0x10D5F34", VA = "0x10D5F34", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600085C")]
			[Address(RVA = "0x10D6424", Offset = "0x10D6424", VA = "0x10D6424", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200014A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640FDC", Offset = "0x640FDC")]
		private sealed class <DownloadFile>d__57 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

			[Token(Token = "0x40008E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string url;

			[Token(Token = "0x40008E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<string> OnError;

			[Token(Token = "0x40008E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Loader <>4__this;

			[Token(Token = "0x40008E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action<byte[]> DownloadComplete;

			[Token(Token = "0x40008E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private WWW <www>5__2;

			[Token(Token = "0x40008E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float <oldProgress>5__3;

			[Token(Token = "0x40008E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Coroutine <progress>5__4;

			[Token(Token = "0x170000D6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000861")]
				[Address(RVA = "0x10D2A9C", Offset = "0x10D2A9C", VA = "0x10D2A9C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000863")]
				[Address(RVA = "0x10D2AE4", Offset = "0x10D2AE4", VA = "0x10D2AE4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600085E")]
			[Address(RVA = "0x10D26D4", Offset = "0x10D26D4", VA = "0x10D26D4")]
			[DebuggerHidden]
			public <DownloadFile>d__57(int <>1__state)
			{
			}

			[Token(Token = "0x600085F")]
			[Address(RVA = "0x10D2700", Offset = "0x10D2700", VA = "0x10D2700", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000860")]
			[Address(RVA = "0x10D2704", Offset = "0x10D2704", VA = "0x10D2704", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000862")]
			[Address(RVA = "0x10D2AA4", Offset = "0x10D2AA4", VA = "0x10D2AA4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200014B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640FEC", Offset = "0x640FEC")]
		private sealed class <GetProgress>d__58 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

			[Token(Token = "0x40008ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public WWW www;

			[Token(Token = "0x40008EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <oldProgress>5__2;

			[Token(Token = "0x170000D8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000867")]
				[Address(RVA = "0x10D35D8", Offset = "0x10D35D8", VA = "0x10D35D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000869")]
				[Address(RVA = "0x10D3620", Offset = "0x10D3620", VA = "0x10D3620", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000864")]
			[Address(RVA = "0x10D3378", Offset = "0x10D3378", VA = "0x10D3378")]
			[DebuggerHidden]
			public <GetProgress>d__58(int <>1__state)
			{
			}

			[Token(Token = "0x6000865")]
			[Address(RVA = "0x10D33A4", Offset = "0x10D33A4", VA = "0x10D33A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000866")]
			[Address(RVA = "0x10D33A8", Offset = "0x10D33A8", VA = "0x10D33A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000868")]
			[Address(RVA = "0x10D35E0", Offset = "0x10D35E0", VA = "0x10D35E0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200014C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640FFC", Offset = "0x640FFC")]
		private sealed class <DownloadFileWebGL>d__59 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

			[Token(Token = "0x40008F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string url;

			[Token(Token = "0x40008F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<string> OnError;

			[Token(Token = "0x40008F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Loader <>4__this;

			[Token(Token = "0x40008F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action<string> DownloadComplete;

			[Token(Token = "0x40008F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private WWW <www>5__2;

			[Token(Token = "0x40008F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float <oldProgress>5__3;

			[Token(Token = "0x40008F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Coroutine <progress>5__4;

			[Token(Token = "0x170000DA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600086D")]
				[Address(RVA = "0x10D2F10", Offset = "0x10D2F10", VA = "0x10D2F10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600086F")]
				[Address(RVA = "0x10D2F58", Offset = "0x10D2F58", VA = "0x10D2F58", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600086A")]
			[Address(RVA = "0x10D2AEC", Offset = "0x10D2AEC", VA = "0x10D2AEC")]
			[DebuggerHidden]
			public <DownloadFileWebGL>d__59(int <>1__state)
			{
			}

			[Token(Token = "0x600086B")]
			[Address(RVA = "0x10D2B18", Offset = "0x10D2B18", VA = "0x10D2B18", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600086C")]
			[Address(RVA = "0x10D2B1C", Offset = "0x10D2B1C", VA = "0x10D2B1C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600086E")]
			[Address(RVA = "0x10D2F18", Offset = "0x10D2F18", VA = "0x10D2F18", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200014D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64100C", Offset = "0x64100C")]
		private sealed class <DownloadTexFileWebGL>d__60 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

			[Token(Token = "0x40008FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string url;

			[Token(Token = "0x40008FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<string> OnError;

			[Token(Token = "0x40008FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Loader <>4__this;

			[Token(Token = "0x40008FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action<Texture2D> DownloadComplete;

			[Token(Token = "0x4000900")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private WWW <www>5__2;

			[Token(Token = "0x4000901")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float <oldProgress>5__3;

			[Token(Token = "0x4000902")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Coroutine <progress>5__4;

			[Token(Token = "0x170000DC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000873")]
				[Address(RVA = "0x10D3328", Offset = "0x10D3328", VA = "0x10D3328", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000875")]
				[Address(RVA = "0x10D3370", Offset = "0x10D3370", VA = "0x10D3370", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000870")]
			[Address(RVA = "0x10D2F60", Offset = "0x10D2F60", VA = "0x10D2F60")]
			[DebuggerHidden]
			public <DownloadTexFileWebGL>d__60(int <>1__state)
			{
			}

			[Token(Token = "0x6000871")]
			[Address(RVA = "0x10D2F8C", Offset = "0x10D2F8C", VA = "0x10D2F8C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000872")]
			[Address(RVA = "0x10D2F90", Offset = "0x10D2F90", VA = "0x10D2F90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000874")]
			[Address(RVA = "0x10D3330", Offset = "0x10D3330", VA = "0x10D3330", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static LoadingProgress totalProgress;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ImportOptions buildOptions;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PolyfewRuntime.ReferencedNumeric<float> individualProgress;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static float LOAD_PHASE_PERC;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		protected static float TEXTURE_PHASE_PERC;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected static float MATERIAL_PHASE_PERC;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		protected static float BUILD_PHASE_PERC;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected static Dictionary<string, GameObject> loadedModels;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected static Dictionary<string, int> instanceCount;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected DataSet dataSet;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected ObjectBuilder objectBuilder;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected List<MaterialData> materialData;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected SingleLoadingProgress objLoadingProgress;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Stats loadStats;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Texture2D loadedTexture;

		[Token(Token = "0x170000CD")]
		public bool ConvertVertAxis
		{
			[Token(Token = "0x6000811")]
			[Address(RVA = "0x12CAA5C", Offset = "0x12CAA5C", VA = "0x12CAA5C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000812")]
			[Address(RVA = "0x12CAA7C", Offset = "0x12CAA7C", VA = "0x12CAA7C")]
			set
			{
			}
		}

		[Token(Token = "0x170000CE")]
		public float Scaling
		{
			[Token(Token = "0x6000813")]
			[Address(RVA = "0x12CAB08", Offset = "0x12CAB08", VA = "0x12CAB08")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000814")]
			[Address(RVA = "0x12CAB20", Offset = "0x12CAB20", VA = "0x12CAB20")]
			set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		protected abstract bool HasMaterialLibrary
		{
			[Token(Token = "0x6000815")]
			get;
		}

		[Token(Token = "0x14000001")]
		public event Action<GameObject, string> ModelCreated
		{
			[Token(Token = "0x6000816")]
			[Address(RVA = "0x12CABA8", Offset = "0x12CABA8", VA = "0x12CABA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64B758", Offset = "0x64B758")]
			add
			{
			}
			[Token(Token = "0x6000817")]
			[Address(RVA = "0x12CAC48", Offset = "0x12CAC48", VA = "0x12CAC48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64B768", Offset = "0x64B768")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event Action<GameObject, string> ModelLoaded
		{
			[Token(Token = "0x6000818")]
			[Address(RVA = "0x12CACE8", Offset = "0x12CACE8", VA = "0x12CACE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64B778", Offset = "0x64B778")]
			add
			{
			}
			[Token(Token = "0x6000819")]
			[Address(RVA = "0x12CAD88", Offset = "0x12CAD88", VA = "0x12CAD88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64B788", Offset = "0x64B788")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event Action<string> ModelError
		{
			[Token(Token = "0x600081A")]
			[Address(RVA = "0x12CAE28", Offset = "0x12CAE28", VA = "0x12CAE28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64B798", Offset = "0x64B798")]
			add
			{
			}
			[Token(Token = "0x600081B")]
			[Address(RVA = "0x12CAEC8", Offset = "0x12CAEC8", VA = "0x12CAEC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64B7A8", Offset = "0x64B7A8")]
			remove
			{
			}
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x12CAF68", Offset = "0x12CAF68", VA = "0x12CAF68")]
		public static GameObject GetModelByPath(string absolutePath)
		{
			return null;
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x12CB04C", Offset = "0x12CB04C", VA = "0x12CB04C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x64B7B8", Offset = "0x64B7B8")]
		public Task<GameObject> Load(string objName, string objAbsolutePath, Transform parentObj, string texturesFolderPath = "", string materialsFolderPath = "")
		{
			return null;
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x12CB204", Offset = "0x12CB204", VA = "0x12CB204")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x64B818", Offset = "0x64B818")]
		public Task<GameObject> LoadFromNetwork(string objURL, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, string objName)
		{
			return null;
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x12CB3EC", Offset = "0x12CB3EC", VA = "0x12CB3EC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x64B878", Offset = "0x64B878")]
		public IEnumerator LoadFromNetworkWebGL(string objURL, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, string objName, Action<GameObject> OnSuccess, Action<Exception> OnError)
		{
			return null;
		}

		[Token(Token = "0x6000820")]
		public abstract string[] ParseTexturePaths(string absolutePath);

		[Token(Token = "0x6000821")]
		protected abstract Task LoadModelFile(string absolutePath, string texturesFolderPath = "", string materialsFolderPath = "");

		[Token(Token = "0x6000822")]
		protected abstract Task LoadModelFileNetworked(string objURL);

		[Token(Token = "0x6000823")]
		protected abstract IEnumerator LoadModelFileNetworkedWebGL(string objURL, Action<Exception> OnError);

		[Token(Token = "0x6000824")]
		protected abstract Task LoadMaterialLibrary(string absolutePath, string materialsFolderPath = "");

		[Token(Token = "0x6000825")]
		protected abstract Task LoadMaterialLibrary(string materialURL);

		[Token(Token = "0x6000826")]
		protected abstract IEnumerator LoadMaterialLibraryWebGL(string materialURL);

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x12CB53C", Offset = "0x12CB53C", VA = "0x12CB53C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x64B8D8", Offset = "0x64B8D8")]
		protected Task Build(string absolutePath, string objName, Transform parentTransform, string texturesFolderPath = "")
		{
			return null;
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x12CB6CC", Offset = "0x12CB6CC", VA = "0x12CB6CC")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x64B938", Offset = "0x64B938")]
		protected Task NetworkedBuild(Transform parentTransform, string objName, string objURL, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL)
		{
			return null;
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x12CB898", Offset = "0x12CB898", VA = "0x12CB898")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x64B998", Offset = "0x64B998")]
		protected IEnumerator NetworkedBuildWebGL(Transform parentTransform, string objName, string objURL, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL)
		{
			return null;
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x12CB9BC", Offset = "0x12CB9BC", VA = "0x12CB9BC")]
		protected string GetDirName(string absolutePath)
		{
			return null;
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x12CBAF0", Offset = "0x12CBAF0", VA = "0x12CBAF0", Slot = "12")]
		protected virtual void OnLoaded(GameObject obj, string absolutePath)
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x12CBDBC", Offset = "0x12CBDBC", VA = "0x12CBDBC", Slot = "13")]
		protected virtual void OnCreated(GameObject obj, string absolutePath)
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x12CBEA8", Offset = "0x12CBEA8", VA = "0x12CBEA8", Slot = "14")]
		protected virtual void OnLoadFailed(string absolutePath)
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x12CBF18", Offset = "0x12CBF18", VA = "0x12CBF18")]
		private string GetTextureUrl(string basePath, string texturePath)
		{
			return null;
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x12CC0A4", Offset = "0x12CC0A4", VA = "0x12CC0A4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x64B9F8", Offset = "0x64B9F8")]
		private Task LoadMaterialTexture(string basePath, string path, string texturesFolderPath = "")
		{
			return null;
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x12CC210", Offset = "0x12CC210", VA = "0x12CC210")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x64BA58", Offset = "0x64BA58")]
		private Task LoadMaterialTexture(string textureURL)
		{
			return null;
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x12CC354", Offset = "0x12CC354", VA = "0x12CC354")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x64BAB8", Offset = "0x64BAB8")]
		private IEnumerator LoadMaterialTextureWebGL(string textureURL)
		{
			return null;
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x12CC3E8", Offset = "0x12CC3E8", VA = "0x12CC3E8")]
		private Texture2D LoadTexture(UnityWebRequest loader)
		{
			return null;
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x12CC6BC", Offset = "0x12CC6BC", VA = "0x12CC6BC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x64BB18", Offset = "0x64BB18")]
		public IEnumerator DownloadFile(string url, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Action<byte[]> DownloadComplete, Action<string> OnError)
		{
			return null;
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x12CC794", Offset = "0x12CC794", VA = "0x12CC794")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x64BB78", Offset = "0x64BB78")]
		private IEnumerator GetProgress(WWW www, PolyfewRuntime.ReferencedNumeric<float> downloadProgress)
		{
			return null;
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x12CC828", Offset = "0x12CC828", VA = "0x12CC828")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x64BBD8", Offset = "0x64BBD8")]
		public IEnumerator DownloadFileWebGL(string url, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Action<string> DownloadComplete, Action<string> OnError)
		{
			return null;
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x12CC900", Offset = "0x12CC900", VA = "0x12CC900")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x64BC38", Offset = "0x64BC38")]
		public IEnumerator DownloadTexFileWebGL(string url, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, Action<Texture2D> DownloadComplete, Action<string> OnError)
		{
			return null;
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x12CC9D8", Offset = "0x12CC9D8", VA = "0x12CC9D8")]
		protected Loader()
		{
		}
	}
	[Token(Token = "0x200014E")]
	public class LoaderObj : Loader
	{
		[Token(Token = "0x200014F")]
		private class BumpParamDef
		{
			[Token(Token = "0x4000905")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string optionName;

			[Token(Token = "0x4000906")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string valueType;

			[Token(Token = "0x4000907")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int valueNumMin;

			[Token(Token = "0x4000908")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int valueNumMax;

			[Token(Token = "0x6000889")]
			[Address(RVA = "0x10DB8AC", Offset = "0x10DB8AC", VA = "0x10DB8AC")]
			public BumpParamDef(string name, string type, int numMin, int numMax)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64101C", Offset = "0x64101C")]
		private struct <LoadModelFile>d__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4000909")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400090A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400090B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string absolutePath;

			[Token(Token = "0x400090C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public LoaderObj <>4__this;

			[Token(Token = "0x400090D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private StreamReader <sr>5__2;

			[Token(Token = "0x400090E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter<string> <>u__1;

			[Token(Token = "0x600088A")]
			[Address(RVA = "0x10D9F40", Offset = "0x10D9F40", VA = "0x10D9F40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600088B")]
			[Address(RVA = "0x10DA430", Offset = "0x10DA430", VA = "0x10DA430", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000151")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64102C", Offset = "0x64102C")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400090F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			[Token(Token = "0x4000910")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public byte[] downloadedBytes;

			[Token(Token = "0x4000911")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Exception ex;

			[Token(Token = "0x600088C")]
			[Address(RVA = "0x10D87EC", Offset = "0x10D87EC", VA = "0x10D87EC")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x600088D")]
			[Address(RVA = "0x10D87F4", Offset = "0x10D87F4", VA = "0x10D87F4")]
			internal void <LoadModelFileNetworked>b__0(byte[] bytes)
			{
			}

			[Token(Token = "0x600088E")]
			[Address(RVA = "0x10D8800", Offset = "0x10D8800", VA = "0x10D8800")]
			internal void <LoadModelFileNetworked>b__1(string error)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000152")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64103C", Offset = "0x64103C")]
		private struct <LoadModelFileNetworked>d__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4000912")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000913")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000914")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LoaderObj <>4__this;

			[Token(Token = "0x4000915")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string objURL;

			[Token(Token = "0x4000916")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private <>c__DisplayClass4_0 <>8__1;

			[Token(Token = "0x4000917")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x4000918")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private StreamReader <sr>5__2;

			[Token(Token = "0x4000919")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private TaskAwaiter<string> <>u__2;

			[Token(Token = "0x600088F")]
			[Address(RVA = "0x10DA43C", Offset = "0x10DA43C", VA = "0x10DA43C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000890")]
			[Address(RVA = "0x10DAF88", Offset = "0x10DAF88", VA = "0x10DAF88", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000153")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64104C", Offset = "0x64104C")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x400091A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			[Token(Token = "0x400091B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public LoaderObj <>4__this;

			[Token(Token = "0x400091C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Exception ex;

			[Token(Token = "0x400091D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<Exception> OnError;

			[Token(Token = "0x6000891")]
			[Address(RVA = "0x10D88D0", Offset = "0x10D88D0", VA = "0x10D88D0")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000892")]
			[Address(RVA = "0x10D88D8", Offset = "0x10D88D8", VA = "0x10D88D8")]
			internal void <LoadModelFileNetworkedWebGL>b__0(string text)
			{
			}

			[Token(Token = "0x6000893")]
			[Address(RVA = "0x10D88FC", Offset = "0x10D88FC", VA = "0x10D88FC")]
			internal void <LoadModelFileNetworkedWebGL>b__1(string error)
			{
			}
		}

		[Token(Token = "0x2000154")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64105C", Offset = "0x64105C")]
		private sealed class <LoadModelFileNetworkedWebGL>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400091E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400091F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000920")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LoaderObj <>4__this;

			[Token(Token = "0x4000921")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<Exception> OnError;

			[Token(Token = "0x4000922")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string objURL;

			[Token(Token = "0x4000923")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private <>c__DisplayClass5_0 <>8__1;

			[Token(Token = "0x170000DF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000897")]
				[Address(RVA = "0x10DB670", Offset = "0x10DB670", VA = "0x10DB670", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000899")]
				[Address(RVA = "0x10DB6B8", Offset = "0x10DB6B8", VA = "0x10DB6B8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000894")]
			[Address(RVA = "0x10DAF94", Offset = "0x10DAF94", VA = "0x10DAF94")]
			[DebuggerHidden]
			public <LoadModelFileNetworkedWebGL>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000895")]
			[Address(RVA = "0x10DAFC0", Offset = "0x10DAFC0", VA = "0x10DAFC0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000896")]
			[Address(RVA = "0x10DAFC4", Offset = "0x10DAFC4", VA = "0x10DAFC4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000898")]
			[Address(RVA = "0x10DB678", Offset = "0x10DB678", VA = "0x10DB678", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000155")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64106C", Offset = "0x64106C")]
		private struct <LoadMaterialLibrary>d__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4000924")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000925")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000926")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LoaderObj <>4__this;

			[Token(Token = "0x4000927")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string absolutePath;

			[Token(Token = "0x4000928")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string materialsFolderPath;

			[Token(Token = "0x4000929")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private StreamReader <sr>5__2;

			[Token(Token = "0x400092A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter<string> <>u__1;

			[Token(Token = "0x600089A")]
			[Address(RVA = "0x10D8BDC", Offset = "0x10D8BDC", VA = "0x10D8BDC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600089B")]
			[Address(RVA = "0x10D9220", Offset = "0x10D9220", VA = "0x10D9220", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000156")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64107C", Offset = "0x64107C")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x400092B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			[Token(Token = "0x400092C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public byte[] downloadedBytes;

			[Token(Token = "0x600089C")]
			[Address(RVA = "0x10D8A0C", Offset = "0x10D8A0C", VA = "0x10D8A0C")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600089D")]
			[Address(RVA = "0x10D8A14", Offset = "0x10D8A14", VA = "0x10D8A14")]
			internal void <LoadMaterialLibrary>b__0(byte[] bytes)
			{
			}

			[Token(Token = "0x600089E")]
			[Address(RVA = "0x10D8A20", Offset = "0x10D8A20", VA = "0x10D8A20")]
			internal void <LoadMaterialLibrary>b__1(string error)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000157")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64108C", Offset = "0x64108C")]
		private struct <LoadMaterialLibrary>d__7 : IAsyncStateMachine
		{
			[Token(Token = "0x400092D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400092E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400092F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LoaderObj <>4__this;

			[Token(Token = "0x4000930")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string materialURL;

			[Token(Token = "0x4000931")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private <>c__DisplayClass7_0 <>8__1;

			[Token(Token = "0x4000932")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x4000933")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private StreamReader <sr>5__2;

			[Token(Token = "0x4000934")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private TaskAwaiter<string> <>u__2;

			[Token(Token = "0x600089F")]
			[Address(RVA = "0x10D922C", Offset = "0x10D922C", VA = "0x10D922C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x10D9BBC", Offset = "0x10D9BBC", VA = "0x10D9BBC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000158")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64109C", Offset = "0x64109C")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000935")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isWorking;

			[Token(Token = "0x4000936")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public LoaderObj <>4__this;

			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x10D8AE8", Offset = "0x10D8AE8", VA = "0x10D8AE8")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x10D8AF0", Offset = "0x10D8AF0", VA = "0x10D8AF0")]
			internal void <LoadMaterialLibraryWebGL>b__0(string text)
			{
			}

			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x10D8B14", Offset = "0x10D8B14", VA = "0x10D8B14")]
			internal void <LoadMaterialLibraryWebGL>b__1(string error)
			{
			}
		}

		[Token(Token = "0x2000159")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6410AC", Offset = "0x6410AC")]
		private sealed class <LoadMaterialLibraryWebGL>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000937")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000938")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000939")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LoaderObj <>4__this;

			[Token(Token = "0x400093A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string materialURL;

			[Token(Token = "0x400093B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private <>c__DisplayClass8_0 <>8__1;

			[Token(Token = "0x170000E1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008A7")]
				[Address(RVA = "0x10D9EF0", Offset = "0x10D9EF0", VA = "0x10D9EF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008A9")]
				[Address(RVA = "0x10D9F38", Offset = "0x10D9F38", VA = "0x10D9F38", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x10D9BC8", Offset = "0x10D9BC8", VA = "0x10D9BC8")]
			[DebuggerHidden]
			public <LoadMaterialLibraryWebGL>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x10D9BF4", Offset = "0x10D9BF4", VA = "0x10D9BF4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x10D9BF8", Offset = "0x10D9BF8", VA = "0x10D9BF8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008A8")]
			[Address(RVA = "0x10D9EF8", Offset = "0x10D9EF8", VA = "0x10D9EF8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200015A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6410BC", Offset = "0x6410BC")]
		private sealed class <LoadOrDownloadText>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400093C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400093D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400093E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LoaderObj <>4__this;

			[Token(Token = "0x400093F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string url;

			[Token(Token = "0x4000940")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool notifyErrors;

			[Token(Token = "0x4000941")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UnityWebRequest <uwr>5__2;

			[Token(Token = "0x170000E3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008AD")]
				[Address(RVA = "0x10DB85C", Offset = "0x10DB85C", VA = "0x10DB85C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008AF")]
				[Address(RVA = "0x10DB8A4", Offset = "0x10DB8A4", VA = "0x10DB8A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008AA")]
			[Address(RVA = "0x10DB6C0", Offset = "0x10DB6C0", VA = "0x10DB6C0")]
			[DebuggerHidden]
			public <LoadOrDownloadText>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x60008AB")]
			[Address(RVA = "0x10DB6EC", Offset = "0x10DB6EC", VA = "0x10DB6EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008AC")]
			[Address(RVA = "0x10DB6F0", Offset = "0x10DB6F0", VA = "0x10DB6F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008AE")]
			[Address(RVA = "0x10DB864", Offset = "0x10DB864", VA = "0x10DB864", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private string mtlLib;

		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string loadedText;

		[Token(Token = "0x170000DE")]
		protected override bool HasMaterialLibrary
		{
			[Token(Token = "0x6000882")]
			[Address(RVA = "0x12CF1B0", Offset = "0x12CF1B0", VA = "0x12CF1B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x12CCC50", Offset = "0x12CCC50", VA = "0x12CCC50", Slot = "5")]
		public override string[] ParseTexturePaths(string absolutePath)
		{
			return null;
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x12CDE00", Offset = "0x12CDE00", VA = "0x12CDE00", Slot = "6")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x64BF28", Offset = "0x64BF28")]
		protected override Task LoadModelFile(string absolutePath, string texturesFolderPath = "", string materialsFolderPath = "")
		{
			return null;
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x12CDF44", Offset = "0x12CDF44", VA = "0x12CDF44", Slot = "7")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x64BF88", Offset = "0x64BF88")]
		protected override Task LoadModelFileNetworked(string objURL)
		{
			return null;
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x12CE080", Offset = "0x12CE080", VA = "0x12CE080", Slot = "8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x64BFE8", Offset = "0x64BFE8")]
		protected override IEnumerator LoadModelFileNetworkedWebGL(string objURL, Action<Exception> OnError)
		{
			return null;
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x12CE128", Offset = "0x12CE128", VA = "0x12CE128", Slot = "9")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x64C048", Offset = "0x64C048")]
		protected override Task LoadMaterialLibrary(string absolutePath, string materialsFolderPath = "")
		{
			return null;
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x12CE280", Offset = "0x12CE280", VA = "0x12CE280", Slot = "10")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x64C0A8", Offset = "0x64C0A8")]
		protected override Task LoadMaterialLibrary(string materialURL)
		{
			return null;
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x12CE3BC", Offset = "0x12CE3BC", VA = "0x12CE3BC", Slot = "11")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x64C108", Offset = "0x64C108")]
		protected override IEnumerator LoadMaterialLibraryWebGL(string materialURL)
		{
			return null;
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x12CE450", Offset = "0x12CE450", VA = "0x12CE450")]
		private void GetFaceIndicesByOneFaceLine(DataSet.FaceIndices[] faces, string[] p, bool isFaceIndexPlus)
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x12CE7CC", Offset = "0x12CE7CC", VA = "0x12CE7CC")]
		private Vector3 ConvertVec3(float x, float y, float z)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x12CE814", Offset = "0x12CE814", VA = "0x12CE814")]
		private float ParseFloat(string floatString)
		{
			return default(float);
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x12CE89C", Offset = "0x12CE89C", VA = "0x12CE89C")]
		protected void ParseGeometryData(string objDataText)
		{
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x12CCF50", Offset = "0x12CCF50", VA = "0x12CCF50")]
		private string ParseMaterialLibName(string path)
		{
			return null;
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x12CF1C0", Offset = "0x12CF1C0", VA = "0x12CF1C0")]
		private void ParseMaterialData(string data)
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x12CD078", Offset = "0x12CD078", VA = "0x12CD078")]
		private void ParseMaterialData(string[] lines, List<MaterialData> mtlData)
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x12CF36C", Offset = "0x12CF36C", VA = "0x12CF36C")]
		private void ParseBumpParameters(string[] param, MaterialData mtlData)
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x12CF2C4", Offset = "0x12CF2C4", VA = "0x12CF2C4")]
		private Color StringsToColor(string[] p)
		{
			return default(Color);
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x12CFD74", Offset = "0x12CFD74", VA = "0x12CFD74")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x64C168", Offset = "0x64C168")]
		private IEnumerator LoadOrDownloadText(string url, bool notifyErrors = true)
		{
			return null;
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x12CFE14", Offset = "0x12CFE14", VA = "0x12CFE14")]
		public LoaderObj()
		{
		}
	}
	[Token(Token = "0x200015B")]
	public class TextureLoader : MonoBehaviour
	{
		[Token(Token = "0x200015C")]
		private class TgaHeader
		{
			[Token(Token = "0x4000942")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public byte identSize;

			[Token(Token = "0x4000943")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public byte colorMapType;

			[Token(Token = "0x4000944")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			public byte imageType;

			[Token(Token = "0x4000945")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public ushort colorMapStart;

			[Token(Token = "0x4000946")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
			public ushort colorMapLength;

			[Token(Token = "0x4000947")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public byte colorMapBits;

			[Token(Token = "0x4000948")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			public ushort xStart;

			[Token(Token = "0x4000949")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public ushort ySstart;

			[Token(Token = "0x400094A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
			public ushort width;

			[Token(Token = "0x400094B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ushort height;

			[Token(Token = "0x400094C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
			public byte bits;

			[Token(Token = "0x400094D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
			public byte descriptor;

			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x1687088", Offset = "0x1687088", VA = "0x1687088")]
			public TgaHeader()
			{
			}
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0xE828D4", Offset = "0xE828D4", VA = "0xE828D4")]
		public static Texture2D LoadTextureFromUrl(string url)
		{
			return null;
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0xE82988", Offset = "0xE82988", VA = "0xE82988")]
		public static Texture2D LoadTexture(string fileName)
		{
			return null;
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0xE82F14", Offset = "0xE82F14", VA = "0xE82F14")]
		public static Texture2D LoadTGA(string fileName)
		{
			return null;
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0xE82B7C", Offset = "0xE82B7C", VA = "0xE82B7C")]
		public static Texture2D LoadDDSManual(string ddsPath)
		{
			return null;
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0xE83054", Offset = "0xE83054", VA = "0xE83054")]
		public static Texture2D LoadTGA(Stream TGAStream)
		{
			return null;
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0xE8362C", Offset = "0xE8362C", VA = "0xE8362C")]
		private static TgaHeader LoadTgaHeader(BinaryReader r)
		{
			return null;
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0xE83A3C", Offset = "0xE83A3C", VA = "0xE83A3C")]
		public TextureLoader()
		{
		}
	}
	[Token(Token = "0x200015D")]
	public class SingleLoadingProgress
	{
		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string fileName;

		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string message;

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float percentage;

		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int numObjects;

		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int numSubObjects;

		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool error;

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xE7EDA4", Offset = "0xE7EDA4", VA = "0xE7EDA4")]
		public SingleLoadingProgress()
		{
		}
	}
	[Token(Token = "0x200015E")]
	public class LoadingProgress
	{
		[Token(Token = "0x4000954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<SingleLoadingProgress> singleProgress;

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0xC45678", Offset = "0xC45678", VA = "0xC45678")]
		public LoadingProgress()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200015F")]
	public class ModelImportInfo
	{
		[Token(Token = "0x4000955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x648600", Offset = "0x648600")]
		public string name;

		[Token(Token = "0x4000956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x648638", Offset = "0x648638")]
		public string path;

		[Token(Token = "0x4000957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x648670", Offset = "0x648670")]
		public bool skip;

		[Token(Token = "0x4000958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ImportOptions loaderOptions;

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0xC4BEEC", Offset = "0xC4BEEC", VA = "0xC4BEEC")]
		public ModelImportInfo()
		{
		}
	}
	[Token(Token = "0x2000160")]
	public class MultiObjectImporter : ObjectImporter
	{
		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6486A8", Offset = "0x6486A8")]
		public bool autoLoadOnStart;

		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6486E0", Offset = "0x6486E0")]
		public List<ModelImportInfo> objectsList;

		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x648718", Offset = "0x648718")]
		public ImportOptions defaultImportOptions;

		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private PathSettings pathSettings;

		[Token(Token = "0x170000E5")]
		public string RootPath
		{
			[Token(Token = "0x60008BB")]
			[Address(RVA = "0xC4C99C", Offset = "0xC4C99C", VA = "0xC4C99C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0xC4CB00", Offset = "0xC4CB00", VA = "0xC4CB00")]
		public void ImportModelListAsync(ModelImportInfo[] modelsInfo)
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0xC4CEF8", Offset = "0xC4CEF8", VA = "0xC4CEF8", Slot = "10")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0xC4CF6C", Offset = "0xC4CF6C", VA = "0xC4CF6C")]
		public MultiObjectImporter()
		{
		}
	}
	[Token(Token = "0x2000161")]
	public class ObjectImporter : MonoBehaviour
	{
		[Token(Token = "0x2000162")]
		private enum ImportPhase
		{
			[Token(Token = "0x400096E")]
			Idle,
			[Token(Token = "0x400096F")]
			TextureImport,
			[Token(Token = "0x4000970")]
			ObjLoad,
			[Token(Token = "0x4000971")]
			AssetBuild,
			[Token(Token = "0x4000972")]
			Done
		}

		[StructLayout(3)]
		[Token(Token = "0x2000163")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6410CC", Offset = "0x6410CC")]
		private struct <ImportModelAsync>d__31 : IAsyncStateMachine
		{
			[Token(Token = "0x4000973")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000974")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<GameObject> <>t__builder;

			[Token(Token = "0x4000975")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ObjectImporter <>4__this;

			[Token(Token = "0x4000976")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string filePath;

			[Token(Token = "0x4000977")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ImportOptions options;

			[Token(Token = "0x4000978")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string objName;

			[Token(Token = "0x4000979")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Transform parentObj;

			[Token(Token = "0x400097A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string texturesFolderPath;

			[Token(Token = "0x400097B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string materialsFolderPath;

			[Token(Token = "0x400097C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private TaskAwaiter<GameObject> <>u__1;

			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x10DCE6C", Offset = "0x10DCE6C", VA = "0x10DCE6C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60008D6")]
			[Address(RVA = "0x10DD324", Offset = "0x10DD324", VA = "0x10DD324", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000164")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6410DC", Offset = "0x6410DC")]
		private struct <ImportModelFromNetwork>d__32 : IAsyncStateMachine
		{
			[Token(Token = "0x400097D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400097E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<GameObject> <>t__builder;

			[Token(Token = "0x400097F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ObjectImporter <>4__this;

			[Token(Token = "0x4000980")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ImportOptions options;

			[Token(Token = "0x4000981")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string objName;

			[Token(Token = "0x4000982")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

			[Token(Token = "0x4000983")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string objURL;

			[Token(Token = "0x4000984")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string diffuseTexURL;

			[Token(Token = "0x4000985")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string bumpTexURL;

			[Token(Token = "0x4000986")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public string specularTexURL;

			[Token(Token = "0x4000987")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public string opacityTexURL;

			[Token(Token = "0x4000988")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public string materialURL;

			[Token(Token = "0x4000989")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private TaskAwaiter<GameObject> <>u__1;

			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x10DD380", Offset = "0x10DD380", VA = "0x10DD380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60008D8")]
			[Address(RVA = "0x10DD884", Offset = "0x10DD884", VA = "0x10DD884", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static int activeDownloads;

		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static float objDownloadProgress;

		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static float textureDownloadProgress;

		[Token(Token = "0x4000961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static float materialDownloadProgress;

		[Token(Token = "0x4000962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static bool isException;

		[Token(Token = "0x4000963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected int numTotalImports;

		[Token(Token = "0x4000964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		protected bool allLoaded;

		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected ImportOptions buildOptions;

		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected List<Loader> loaderList;

		[Token(Token = "0x4000967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ImportPhase importPhase;

		[Token(Token = "0x170000E6")]
		public int NumImportRequests
		{
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0xC519E8", Offset = "0xC519E8", VA = "0xC519E8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000004")]
		public event Action ImportingStart
		{
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0xC513A8", Offset = "0xC513A8", VA = "0xC513A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64C2F8", Offset = "0x64C2F8")]
			add
			{
			}
			[Token(Token = "0x60008C1")]
			[Address(RVA = "0xC51448", Offset = "0xC51448", VA = "0xC51448")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64C308", Offset = "0x64C308")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event Action ImportingComplete
		{
			[Token(Token = "0x60008C2")]
			[Address(RVA = "0xC514E8", Offset = "0xC514E8", VA = "0xC514E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64C318", Offset = "0x64C318")]
			add
			{
			}
			[Token(Token = "0x60008C3")]
			[Address(RVA = "0xC51588", Offset = "0xC51588", VA = "0xC51588")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64C328", Offset = "0x64C328")]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event Action<GameObject, string> CreatedModel
		{
			[Token(Token = "0x60008C4")]
			[Address(RVA = "0xC51628", Offset = "0xC51628", VA = "0xC51628")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64C338", Offset = "0x64C338")]
			add
			{
			}
			[Token(Token = "0x60008C5")]
			[Address(RVA = "0xC516C8", Offset = "0xC516C8", VA = "0xC516C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64C348", Offset = "0x64C348")]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event Action<GameObject, string> ImportedModel
		{
			[Token(Token = "0x60008C6")]
			[Address(RVA = "0xC51768", Offset = "0xC51768", VA = "0xC51768")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64C358", Offset = "0x64C358")]
			add
			{
			}
			[Token(Token = "0x60008C7")]
			[Address(RVA = "0xC51808", Offset = "0xC51808", VA = "0xC51808")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64C368", Offset = "0x64C368")]
			remove
			{
			}
		}

		[Token(Token = "0x14000008")]
		public event Action<string> ImportError
		{
			[Token(Token = "0x60008C8")]
			[Address(RVA = "0xC518A8", Offset = "0xC518A8", VA = "0xC518A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64C378", Offset = "0x64C378")]
			add
			{
			}
			[Token(Token = "0x60008C9")]
			[Address(RVA = "0xC51948", Offset = "0xC51948", VA = "0xC51948")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64C388", Offset = "0x64C388")]
			remove
			{
			}
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0xC4D024", Offset = "0xC4D024", VA = "0xC4D024")]
		public ObjectImporter()
		{
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0xC519F0", Offset = "0xC519F0", VA = "0xC519F0")]
		private Loader CreateLoader(string absolutePath, bool isNetwork = false)
		{
			return null;
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0xC4CD24", Offset = "0xC4CD24", VA = "0xC4CD24")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x64C398", Offset = "0x64C398")]
		public Task<GameObject> ImportModelAsync(string objName, string filePath, Transform parentObj, ImportOptions options, string texturesFolderPath = "", string materialsFolderPath = "")
		{
			return null;
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0xC51CEC", Offset = "0xC51CEC", VA = "0xC51CEC")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x64C3F8", Offset = "0x64C3F8")]
		public Task<GameObject> ImportModelFromNetwork(string objURL, string objName, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, ImportOptions options)
		{
			return null;
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0xC51F00", Offset = "0xC51F00", VA = "0xC51F00")]
		public void ImportModelFromNetworkWebGL(string objURL, string objName, string diffuseTexURL, string bumpTexURL, string specularTexURL, string opacityTexURL, string materialURL, PolyfewRuntime.ReferencedNumeric<float> downloadProgress, ImportOptions options, Action<GameObject> OnSuccess, Action<Exception> OnError)
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0xC5220C", Offset = "0xC5220C", VA = "0xC5220C", Slot = "4")]
		public virtual void UpdateStatus()
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0xC523FC", Offset = "0xC523FC", VA = "0xC523FC", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0xC52408", Offset = "0xC52408", VA = "0xC52408", Slot = "6")]
		protected virtual void OnImportingComplete()
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0xC5241C", Offset = "0xC5241C", VA = "0xC5241C", Slot = "7")]
		protected virtual void OnModelCreated(GameObject obj, string absolutePath)
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0xC52494", Offset = "0xC52494", VA = "0xC52494", Slot = "8")]
		protected virtual void OnImported(GameObject obj, string absolutePath)
		{
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0xC5250C", Offset = "0xC5250C", VA = "0xC5250C", Slot = "9")]
		protected virtual void OnImportError(string absolutePath)
		{
		}
	}
	[Token(Token = "0x2000165")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6410EC", Offset = "0x6410EC")]
	public class ObjectImporterUI : MonoBehaviour
	{
		[Token(Token = "0x400098A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6487B0", Offset = "0x6487B0")]
		public Text progressText;

		[Token(Token = "0x400098B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6487E8", Offset = "0x6487E8")]
		public Slider progressSlider;

		[Token(Token = "0x400098C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x648820", Offset = "0x648820")]
		public Image progressImage;

		[Token(Token = "0x400098D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ObjectImporter objImporter;

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0xC5257C", Offset = "0xC5257C", VA = "0xC5257C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0xC52700", Offset = "0xC52700", VA = "0xC52700")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0xC527D4", Offset = "0xC527D4", VA = "0xC527D4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0xC528A8", Offset = "0xC528A8", VA = "0xC528A8")]
		private void Update()
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0xC53070", Offset = "0xC53070", VA = "0xC53070")]
		private void OnImportStart()
		{
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0xC52EE0", Offset = "0xC52EE0", VA = "0xC52EE0")]
		private void OnImportComplete()
		{
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0xC531FC", Offset = "0xC531FC", VA = "0xC531FC")]
		public ObjectImporterUI()
		{
		}
	}
	[Token(Token = "0x2000166")]
	public enum RootPathEnum
	{
		[Token(Token = "0x400098F")]
		Url,
		[Token(Token = "0x4000990")]
		DataPath,
		[Token(Token = "0x4000991")]
		DataPathParent,
		[Token(Token = "0x4000992")]
		PersistentDataPath,
		[Token(Token = "0x4000993")]
		CurrentPath
	}
	[Token(Token = "0x2000167")]
	public class PathSettings : MonoBehaviour
	{
		[Token(Token = "0x4000994")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x648858", Offset = "0x648858")]
		public RootPathEnum defaultRootPath;

		[Token(Token = "0x4000995")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x648890", Offset = "0x648890")]
		public RootPathEnum mobileRootPath;

		[Token(Token = "0x170000E7")]
		public string RootPath
		{
			[Token(Token = "0x60008E0")]
			[Address(RVA = "0xC4CA40", Offset = "0xC4CA40", VA = "0xC4CA40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0xC540C4", Offset = "0xC540C4", VA = "0xC540C4")]
		public static PathSettings FindPathComponent(GameObject obj)
		{
			return null;
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0xC54200", Offset = "0xC54200", VA = "0xC54200")]
		public string FullPath(string path)
		{
			return null;
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0xC5429C", Offset = "0xC5429C", VA = "0xC5429C")]
		public PathSettings()
		{
		}
	}
}
namespace BrainFailProductions.PolyFew.AsImpL.MathUtil
{
	[Token(Token = "0x2000168")]
	public class Triangle
	{
		[Token(Token = "0x4000996")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vertex v1;

		[Token(Token = "0x4000997")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vertex v2;

		[Token(Token = "0x4000998")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vertex v3;

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0xE83E28", Offset = "0xE83E28", VA = "0xE83E28")]
		public Triangle(Vertex v1, Vertex v2, Vertex v3)
		{
		}
	}
	[Token(Token = "0x2000169")]
	public class Vertex
	{
		[Token(Token = "0x4000999")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Vertex prevVertex;

		[Token(Token = "0x400099A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vertex nextVertex;

		[Token(Token = "0x400099B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float triangleArea;

		[Token(Token = "0x400099C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool triangleHasChanged;

		[Token(Token = "0x400099D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6488C8", Offset = "0x6488C8")]
		private Vector3 <Position>k__BackingField;

		[Token(Token = "0x400099E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6488D8", Offset = "0x6488D8")]
		private int <OriginalIndex>k__BackingField;

		[Token(Token = "0x170000E8")]
		public Vector3 Position
		{
			[Token(Token = "0x60008E5")]
			[Address(RVA = "0xE8ACFC", Offset = "0xE8ACFC", VA = "0xE8ACFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64C478", Offset = "0x64C478")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60008E6")]
			[Address(RVA = "0xE8AD08", Offset = "0xE8AD08", VA = "0xE8AD08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64C488", Offset = "0x64C488")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		public int OriginalIndex
		{
			[Token(Token = "0x60008E7")]
			[Address(RVA = "0xE8AD14", Offset = "0xE8AD14", VA = "0xE8AD14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64C498", Offset = "0x64C498")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008E8")]
			[Address(RVA = "0xE8AD1C", Offset = "0xE8AD1C", VA = "0xE8AD1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64C4A8", Offset = "0x64C4A8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		public Vertex PreviousVertex
		{
			[Token(Token = "0x60008E9")]
			[Address(RVA = "0xE8AD24", Offset = "0xE8AD24", VA = "0xE8AD24")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008EA")]
			[Address(RVA = "0xE846C0", Offset = "0xE846C0", VA = "0xE846C0")]
			set
			{
			}
		}

		[Token(Token = "0x170000EB")]
		public Vertex NextVertex
		{
			[Token(Token = "0x60008EB")]
			[Address(RVA = "0xE8AD2C", Offset = "0xE8AD2C", VA = "0xE8AD2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008EC")]
			[Address(RVA = "0xE846D8", Offset = "0xE846D8", VA = "0xE846D8")]
			set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		public float TriangleArea
		{
			[Token(Token = "0x60008ED")]
			[Address(RVA = "0xE84BCC", Offset = "0xE84BCC", VA = "0xE84BCC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0xE852E4", Offset = "0xE852E4", VA = "0xE852E4")]
		public Vertex(int originalIndex, Vector3 position)
		{
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0xE84CBC", Offset = "0xE84CBC", VA = "0xE84CBC")]
		public Vector2 GetPosOnPlane(Vector3 planeNormal)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0xE8AD34", Offset = "0xE8AD34", VA = "0xE8AD34")]
		private void ComputeTriangleArea()
		{
		}
	}
	[Token(Token = "0x200016A")]
	public static class MathUtility
	{
		[Token(Token = "0x60008F1")]
		[Address(RVA = "0xC46230", Offset = "0xC46230", VA = "0xC46230")]
		public static int ClampListIndex(int index, int listSize)
		{
			return default(int);
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0xC46248", Offset = "0xC46248", VA = "0xC46248")]
		public static bool IsPointInTriangle(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p)
		{
			return default(bool);
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0xC462D8", Offset = "0xC462D8", VA = "0xC462D8")]
		public static bool IsTriangleOrientedClockwise(Vector2 v1, Vector2 v2, Vector2 v3)
		{
			return default(bool);
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0xC46310", Offset = "0xC46310", VA = "0xC46310")]
		public static Vector3 ComputeNormal(Vector3 vert, Vector3 vNext, Vector3 vPrev)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x200016B")]
	public static class Triangulation
	{
		[Token(Token = "0x60008F5")]
		[Address(RVA = "0xE83E8C", Offset = "0xE83E8C", VA = "0xE83E8C")]
		public static List<Triangle> TriangulateConvexPolygon(List<Vertex> vertices, bool preserveOriginalVertices = true)
		{
			return null;
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0xE842A0", Offset = "0xE842A0", VA = "0xE842A0")]
		public static List<Triangle> TriangulateByEarClipping(List<Vertex> origVertices, Vector3 planeNormal, string meshName, bool preserveOriginalVertices = true)
		{
			return null;
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0xE841AC", Offset = "0xE841AC", VA = "0xE841AC")]
		public static Triangle ClipTriangle(Vertex vertex, List<Vertex> vertices)
		{
			return null;
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0xE84844", Offset = "0xE84844", VA = "0xE84844")]
		private static Triangle ClipEar(Vertex earVertex, List<Vertex> earVertices, List<Vertex> vertices, Vector3 planeNormal)
		{
			return null;
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0xE84020", Offset = "0xE84020", VA = "0xE84020")]
		private static Vertex FindMaxAreaEarVertex(List<Vertex> earVertices)
		{
			return null;
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0xE846F0", Offset = "0xE846F0", VA = "0xE846F0")]
		private static List<Vertex> FindEarVertices(List<Vertex> vertices, Vector3 planeNormal)
		{
			return null;
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0xE84BFC", Offset = "0xE84BFC", VA = "0xE84BFC")]
		private static bool IsVertexReflex(Vertex v, Vector3 vNormal)
		{
			return default(bool);
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0xE84994", Offset = "0xE84994", VA = "0xE84994")]
		private static bool IsVertexEar(Vertex v, List<Vertex> vertices, Vector3 planeNormal)
		{
			return default(bool);
		}
	}
}
namespace FlyingWormConsole3
{
	[Token(Token = "0x200016C")]
	public class ConsoleProRemoteServer : MonoBehaviour
	{
		[Token(Token = "0x400099F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool useNATPunch;

		[Token(Token = "0x40009A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int port;

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x15BCE7C", Offset = "0x15BCE7C", VA = "0x15BCE7C")]
		public void Awake()
		{
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x15BCEF0", Offset = "0x15BCEF0", VA = "0x15BCEF0")]
		public ConsoleProRemoteServer()
		{
		}
	}
}
