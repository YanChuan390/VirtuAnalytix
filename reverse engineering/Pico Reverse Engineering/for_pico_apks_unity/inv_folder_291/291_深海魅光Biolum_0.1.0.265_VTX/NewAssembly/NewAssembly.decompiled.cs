using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using pfc.DialogueSystem;
using pfc.mars;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x6F1560", Offset = "0x6F1560")]
public class CollectableItemList : ScriptableObject
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	public List<pfc.mars.CollectableItemList> items;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1A36998", Offset = "0x1A36998", VA = "0x1A36998")]
	public CollectableItemList GetByGuid(string guid)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1A369A0", Offset = "0x1A369A0", VA = "0x1A369A0")]
	public CollectableItemList()
	{
	}
}
[Token(Token = "0x2000003")]
public class KeepLeveled : MonoBehaviour
{
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1A36B7C", Offset = "0x1A36B7C", VA = "0x1A36B7C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1A36BB8", Offset = "0x1A36BB8", VA = "0x1A36BB8")]
	public KeepLeveled()
	{
	}
}
namespace pfc.mars;

[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x6F1570", Offset = "0x6F1570")]
public class CollectableItemList : ScriptableObject
{
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6F1590", Offset = "0x6F1590")]
	public string collectableName;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x20")]
	public string description;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x28")]
	public string taskDescription;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x30")]
	public string guid;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x38")]
	public string informationSource;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6F15C8", Offset = "0x6F15C8")]
	public DialogueLine audioGeneration;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x48")]
	public AudioClip foundAudio;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x50")]
	public DateTime dateTimeFound;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6F1600", Offset = "0x6F1600")]
	public GameObject pinPrefab;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x60")]
	public float pinScaleMultiplier;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x68")]
	public CollectableType type;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x70")]
	public Vector3 positionInWreck;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x7C")]
	public Vector3 size;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1A369A8", Offset = "0x1A369A8", VA = "0x1A369A8")]
	public bool IsValid()
	{
		return default(bool);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1A36A40", Offset = "0x1A36A40", VA = "0x1A36A40")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x6F1638", Offset = "0x6F1638")]
	public void PrintTime()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1A36AE0", Offset = "0x1A36AE0", VA = "0x1A36AE0")]
	public CollectableItemList()
	{
	}
}
[Token(Token = "0x2000005")]
public class CollectableItemHolder : MonoBehaviour
{
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x0")]
	public static List<CollectableItemHolder> allCollectables;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x18")]
	public CollectableItemList data;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x20")]
	public Transform heroTransform;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x28")]
	public bool useHeroTransformAndChunk;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x30")]
	private Vector3[] _corners;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x38")]
	private Animator animator;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x8")]
	private static Vector3[] points;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x40")]
	private BoxCollider _collider;

	[Token(Token = "0x17000001")]
	public Vector3[] corners
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x1A35DF4", Offset = "0x1A35DF4", VA = "0x1A35DF4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public BoxCollider collider
	{
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x1A36378", Offset = "0x1A36378", VA = "0x1A36378")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1A35DFC", Offset = "0x1A35DFC", VA = "0x1A35DFC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1A35E58", Offset = "0x1A35E58", VA = "0x1A35E58")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1A362C0", Offset = "0x1A362C0", VA = "0x1A362C0")]
	public void Mark(bool mark)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1A35FD0", Offset = "0x1A35FD0", VA = "0x1A35FD0")]
	private void CalculateCornerPoints()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1A36484", Offset = "0x1A36484", VA = "0x1A36484")]
	private Vector3 Scale(Vector3 a, Vector3 b)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1A36494", Offset = "0x1A36494", VA = "0x1A36494")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1A365A0", Offset = "0x1A365A0", VA = "0x1A365A0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1A366C4", Offset = "0x1A366C4", VA = "0x1A366C4")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1A36850", Offset = "0x1A36850", VA = "0x1A36850")]
	public CollectableItemHolder()
	{
	}
}
[Token(Token = "0x2000006")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x6F1580", Offset = "0x6F1580")]
public class CollectableType : ScriptableObject
{
	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x18")]
	public string typeName;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x20")]
	public Texture2D icon;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x28")]
	public AudioClip[] foundAudio;

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1A36AF0", Offset = "0x1A36AF0", VA = "0x1A36AF0")]
	public AudioClip GetRandomClip(float probability)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1A36B74", Offset = "0x1A36B74", VA = "0x1A36B74")]
	public CollectableType()
	{
	}
}
