using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Malee.List;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using VolumetricFogAndMist2;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class RotateSeeker : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float Speed;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform trans;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1325FB0", Offset = "0x1325FB0", VA = "0x1325FB0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x132600C", Offset = "0x132600C", VA = "0x132600C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x132605C", Offset = "0x132605C", VA = "0x132605C")]
	public RotateSeeker()
	{
	}
}
[Token(Token = "0x2000003")]
public class ApplyProceduralTextureProperties : MonoBehaviour
{
	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA73D7C", Offset = "0xA73D7C")]
	public Material m_Material;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA73D90", Offset = "0xA73D90")]
	public ProceduralTexture2D proceduralTexAssetAlbedo;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ProceduralTexture2D proceduralTexAssetNormal;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ProceduralTexture2D proceduralTexAssetMask;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x131776C", Offset = "0x131776C", VA = "0x131776C")]
	public void SyncMatWithProceduralTextureAsset()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1317E80", Offset = "0x1317E80", VA = "0x1317E80")]
	public ApplyProceduralTextureProperties()
	{
	}
}
[Serializable]
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xA73A00", Offset = "0xA73A00")]
public class ProceduralTexture2D : ScriptableObject
{
	[Token(Token = "0x2000005")]
	public enum TextureType
	{
		[Token(Token = "0x400001E")]
		Color,
		[Token(Token = "0x400001F")]
		Normal,
		[Token(Token = "0x4000020")]
		Other
	}

	[Token(Token = "0x2000006")]
	public enum CompressionLevel
	{
		[Token(Token = "0x4000022")]
		None = -1,
		[Token(Token = "0x4000023")]
		LowQuality = 0,
		[Token(Token = "0x4000024")]
		NormalQuality = 50,
		[Token(Token = "0x4000025")]
		HighQuality = 100
	}

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D input;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextureType type;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool includeAlpha;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool generateMipMaps;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public FilterMode filterMode;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int anisoLevel;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public CompressionLevel compressionQuality;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Texture2D Tinput;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Texture2D invT;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3 colorSpaceOrigin;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public Vector3 colorSpaceVector1;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector3 colorSpaceVector2;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Vector3 colorSpaceVector3;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Vector4 compressionScalers;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public long memoryUsageBytes;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Texture2D currentInput;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public TextureType currentType;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public bool currentIncludeAlpha;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
	public bool currentGenerateMipMaps;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public FilterMode currentFilterMode;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public int currentAnisoLevel;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public CompressionLevel currentCompressionQuality;

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1325C98", Offset = "0x1325C98", VA = "0x1325C98")]
	public ProceduralTexture2D()
	{
	}
}
[Token(Token = "0x2000007")]
public class Example : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000008")]
	public class ExampleChild
	{
		[Token(Token = "0x2000009")]
		public enum ExampleEnum
		{
			[Token(Token = "0x4000033")]
			EnumValue1,
			[Token(Token = "0x4000034")]
			EnumValue2,
			[Token(Token = "0x4000035")]
			EnumValue3
		}

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float value;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ExampleEnum myEnum;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LayerMask layerMask;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public long longValue;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public char charValue;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public byte byteValue;

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x16D8228", Offset = "0x16D8228", VA = "0x16D8228")]
		public ExampleChild()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200000A")]
	public class ExampleChildList : ReorderableArray<ExampleChild>
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x16D8230", Offset = "0x16D8230", VA = "0x16D8230")]
		public ExampleChildList()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200000B")]
	public class StringList : ReorderableArray<string>
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x16D827C", Offset = "0x16D827C", VA = "0x16D827C")]
		public StringList()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200000C")]
	public class VectorList : ReorderableArray<Vector4>
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x16D82C8", Offset = "0x16D82C8", VA = "0x16D82C8")]
		public VectorList()
		{
		}
	}

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<ExampleChild> list1;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "ReorderableAttribute", RVA = "0xA73DA4", Offset = "0xA73DA4")]
	public ExampleChildList list2;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "ReorderableAttribute", RVA = "0xA73DB4", Offset = "0xA73DB4")]
	public ExampleChildList list3;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "ReorderableAttribute", RVA = "0xA73DC4", Offset = "0xA73DC4")]
	public StringList list4;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "ReorderableAttribute", RVA = "0xA73DD4", Offset = "0xA73DD4")]
	public VectorList list5;

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1318A68", Offset = "0x1318A68", VA = "0x1318A68")]
	public Example()
	{
	}
}
[Token(Token = "0x200000D")]
public class GameObjectExample : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200000E")]
	public class GameObjectList : ReorderableArray<GameObject>
	{
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x16D8314", Offset = "0x16D8314", VA = "0x16D8314")]
		public GameObjectList()
		{
		}
	}

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "ReorderableAttribute", RVA = "0xA73DE4", Offset = "0xA73DE4")]
	public GameObjectList list;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x131A35C", Offset = "0x131A35C", VA = "0x131A35C")]
	private void Update()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x131A3E0", Offset = "0x131A3E0", VA = "0x131A3E0")]
	public GameObjectExample()
	{
	}
}
[Token(Token = "0x200000F")]
public class NameOverride : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000010")]
	public class ExampleChild
	{
		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "ReorderableAttribute", RVA = "0xA73E70", Offset = "0xA73E70")]
		public StringList nested;

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x16D83C8", Offset = "0x16D83C8", VA = "0x16D83C8")]
		public ExampleChild()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000011")]
	public class DynamicExampleChild
	{
		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "ReorderableAttribute", RVA = "0xA73EB0", Offset = "0xA73EB0")]
		public StringList nested;

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x16D8374", Offset = "0x16D8374", VA = "0x16D8374")]
		public DynamicExampleChild()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000012")]
	public class ExampleChildList : ReorderableArray<ExampleChild>
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x16D83D0", Offset = "0x16D83D0", VA = "0x16D83D0")]
		public ExampleChildList()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000013")]
	public class DynamicExampleChildList : ReorderableArray<DynamicExampleChild>
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x16D837C", Offset = "0x16D837C", VA = "0x16D837C")]
		public DynamicExampleChildList()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000014")]
	public class StringList : ReorderableArray<string>
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x16D841C", Offset = "0x16D841C", VA = "0x16D841C")]
		public StringList()
		{
		}
	}

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string nameOverride;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string nestedNameOverride;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "ReorderableAttribute", RVA = "0xA73E20", Offset = "0xA73E20")]
	public ExampleChildList autoNameList;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "ReorderableAttribute", RVA = "0xA73E60", Offset = "0xA73E60")]
	public DynamicExampleChildList dynamicNameList;

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x131C2E8", Offset = "0x131C2E8", VA = "0x131C2E8")]
	public NameOverride()
	{
	}
}
[Token(Token = "0x2000015")]
public class NestedExample : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000016")]
	public class ExampleChild
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "ReorderableAttribute", RVA = "0xA73ED0", Offset = "0xA73ED0")]
		public NestedChildList nested;

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x16D8468", Offset = "0x16D8468", VA = "0x16D8468")]
		public ExampleChild()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000017")]
	public class NestedChild
	{
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float myValue;

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x16D84BC", Offset = "0x16D84BC", VA = "0x16D84BC")]
		public NestedChild()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000018")]
	public class NestedChildCustomDrawer
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool myBool;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject myGameObject;

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x16D84C4", Offset = "0x16D84C4", VA = "0x16D84C4")]
		public NestedChildCustomDrawer()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000019")]
	public class ExampleChildList : ReorderableArray<ExampleChild>
	{
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x16D8470", Offset = "0x16D8470", VA = "0x16D8470")]
		public ExampleChildList()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200001A")]
	public class NestedChildList : ReorderableArray<NestedChildCustomDrawer>
	{
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x16D84CC", Offset = "0x16D84CC", VA = "0x16D84CC")]
		public NestedChildList()
		{
		}
	}

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "ReorderableAttribute", RVA = "0xA73EC0", Offset = "0xA73EC0")]
	public ExampleChildList list;

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x131C368", Offset = "0x131C368", VA = "0x131C368")]
	public NestedExample()
	{
	}
}
[Token(Token = "0x200001B")]
public class RecursionTest : MonoBehaviour
{
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1325D28", Offset = "0x1325D28", VA = "0x1325D28")]
	public RecursionTest()
	{
	}
}
[Token(Token = "0x200001C")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xA73A6C", Offset = "0xA73A6C")]
public class ScriptableObjectExample : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x200001D")]
	private struct MyObject
	{
		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool myBool;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float myValue;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string myString;

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x16D8564", Offset = "0x16D8564", VA = "0x16D8564")]
		public MyObject(bool myBool, float myValue, string myString)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200001E")]
	private class MyList : ReorderableArray<MyObject>
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x16D8518", Offset = "0x16D8518", VA = "0x16D8518")]
		public MyList()
		{
		}
	}

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "ReorderableAttribute", RVA = "0xA73F04", Offset = "0xA73F04")]
	[SerializeField]
	private MyList list;

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x132606C", Offset = "0x132606C", VA = "0x132606C")]
	public ScriptableObjectExample()
	{
	}
}
[Token(Token = "0x200001F")]
public class SurrogateTest : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000020")]
	public class MyClass
	{
		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject gameObject;

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x16D857C", Offset = "0x16D857C", VA = "0x16D857C")]
		public MyClass()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000021")]
	public class MyClassArray : ReorderableArray<MyClass>
	{
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x16D8584", Offset = "0x16D8584", VA = "0x16D8584")]
		public MyClassArray()
		{
		}
	}

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private MyClass[] objects;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[AttributeAttribute(Name = "ReorderableAttribute", RVA = "0xA73F78", Offset = "0xA73F78")]
	private MyClassArray myClassArray;

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x13269D0", Offset = "0x13269D0", VA = "0x13269D0")]
	public SurrogateTest()
	{
	}
}
namespace VolumetricFogAndMist2
{
	[Token(Token = "0x2000022")]
	[ExecuteInEditMode]
	public class FogPointLight : MonoBehaviour
	{
		[NonSerialized]
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Light pointLight;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA74010", Offset = "0xA74010")]
		public float inscattering;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA74048", Offset = "0xA74048")]
		public float intensity;

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1319260", Offset = "0x1319260", VA = "0x1319260")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1319384", Offset = "0x1319384", VA = "0x1319384")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1319500", Offset = "0x1319500", VA = "0x1319500")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1319544", Offset = "0x1319544", VA = "0x1319544")]
		public FogPointLight()
		{
		}
	}
	[Token(Token = "0x2000023")]
	[ExecuteInEditMode]
	public class FogVoid : MonoBehaviour
	{
		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA74080", Offset = "0xA74080")]
		public float roundness;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA74098", Offset = "0xA74098")]
		public float falloff;

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1319554", Offset = "0x1319554", VA = "0x1319554")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1319634", Offset = "0x1319634", VA = "0x1319634")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x13197B0", Offset = "0x13197B0", VA = "0x13197B0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1319874", Offset = "0x1319874", VA = "0x1319874")]
		public FogVoid()
		{
		}
	}
	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0xA73AEC", Offset = "0xA73AEC")]
	[ExecuteInEditMode]
	public class FogVoidManager : MonoBehaviour, IVolumetricFogManager
	{
		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool usingVoids;

		[Token(Token = "0x4000050")]
		public const int MAX_FOG_VOID = 8;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA740B0", Offset = "0xA740B0")]
		public Transform trackingCenter;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA740E8", Offset = "0xA740E8")]
		public float distanceSortTimeInterval;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly List<FogVoid> fogVoids;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector4[] fogVoidPositions;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector4[] fogVoidSizes;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float distanceSortLastTime;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool requireRefresh;

		[Token(Token = "0x17000001")]
		public string managerName
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x1319884", Offset = "0x1319884", VA = "0x1319884", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x13198C8", Offset = "0x13198C8", VA = "0x13198C8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1319C04", Offset = "0x1319C04", VA = "0x1319C04")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1319E28", Offset = "0x1319E28", VA = "0x1319E28")]
		private void SubmitFogVoidData()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1319584", Offset = "0x1319584", VA = "0x1319584")]
		public void RegisterFogVoid(FogVoid fogVoid)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x13196D4", Offset = "0x13196D4", VA = "0x13196D4")]
		public void UnregisterFogVoid(FogVoid fogVoid)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1319CB0", Offset = "0x1319CB0", VA = "0x1319CB0")]
		public void TrackFogVoids(bool forceImmediateUpdate = false)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x131A1C0", Offset = "0x131A1C0", VA = "0x131A1C0")]
		private int fogVoidDistanceComparer(FogVoid v1, FogVoid v2)
		{
			return default(int);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x131A2C4", Offset = "0x131A2C4", VA = "0x131A2C4")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x131A2D0", Offset = "0x131A2D0", VA = "0x131A2D0")]
		public FogVoidManager()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public interface IVolumetricFogManager
	{
		[Token(Token = "0x17000002")]
		string managerName
		{
			[Token(Token = "0x6000034")]
			get;
		}
	}
	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0xA73B28", Offset = "0xA73B28")]
	[ExecuteInEditMode]
	public class PointLightManager : MonoBehaviour, IVolumetricFogManager
	{
		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool usingPointLights;

		[Token(Token = "0x4000059")]
		public const int MAX_POINT_LIGHTS = 16;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA74120", Offset = "0xA74120")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA74120", Offset = "0xA74120")]
		public Transform trackingCenter;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA74180", Offset = "0xA74180")]
		public float distanceSortTimeInterval;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA741B8", Offset = "0xA741B8")]
		public bool excludeLightsBehind;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA741F0", Offset = "0xA741F0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA741F0", Offset = "0xA741F0")]
		public float inscattering;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA74250", Offset = "0xA74250")]
		public float intensity;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA74288", Offset = "0xA74288")]
		public float insideAtten;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly List<FogPointLight> pointLights;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector4[] pointLightColorBuffer;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector4[] pointLightPositionBuffer;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float distanceSortLastTime;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool requireRefresh;

		[Token(Token = "0x17000003")]
		public string managerName
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x13251EC", Offset = "0x13251EC", VA = "0x13251EC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1325230", Offset = "0x1325230", VA = "0x1325230")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x13253C8", Offset = "0x13253C8", VA = "0x13253C8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x13255EC", Offset = "0x13255EC", VA = "0x13255EC")]
		private void SubmitPointLightData()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x13192D4", Offset = "0x13192D4", VA = "0x13192D4")]
		public void RegisterPointLight(FogPointLight fogPointLight)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1319424", Offset = "0x1319424", VA = "0x1319424")]
		public void UnregisterPointLight(FogPointLight fogPointLight)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1325474", Offset = "0x1325474", VA = "0x1325474")]
		public void TrackPointLights(bool forceImmediateUpdate = false)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1325AEC", Offset = "0x1325AEC", VA = "0x1325AEC")]
		private int pointLightsDistanceComparer(FogPointLight l1, FogPointLight l2)
		{
			return default(int);
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1325BF0", Offset = "0x1325BF0", VA = "0x1325BF0")]
		public void Refresh()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1325BFC", Offset = "0x1325BFC", VA = "0x1325BFC")]
		public PointLightManager()
		{
		}
	}
	[Token(Token = "0x2000027")]
	[ExecuteInEditMode]
	public class VolumetricFogManager : MonoBehaviour, IVolumetricFogManager
	{
		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static PointLightManager _pointLightManager;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static FogVoidManager _fogVoidManager;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static VolumetricFogManager _instance;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera mainCamera;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Light sun;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA742C0", Offset = "0xA742C0")]
		public int fogLayer;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA742F8", Offset = "0xA742F8")]
		public bool flipDepthTexture;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA74330", Offset = "0xA74330")]
		public LayerMask includeTransparent;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA74368", Offset = "0xA74368")]
		public LayerMask includeSemiTransparent;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA743A0", Offset = "0xA743A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA743A0", Offset = "0xA743A0")]
		public float alphaCutOff;

		[Token(Token = "0x400006F")]
		private const string SKW_FLIP_DEPTH_TEXTURE = "VF2_FLIP_DEPTH_TEXTURE";

		[Token(Token = "0x17000004")]
		public string managerName
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x16D5AFC", Offset = "0x16D5AFC", VA = "0x16D5AFC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		public static VolumetricFogManager instance
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x16D5B40", Offset = "0x16D5B40", VA = "0x16D5B40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public static PointLightManager pointLightManager
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x16D5D10", Offset = "0x16D5D10", VA = "0x16D5D10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000007")]
		public static FogVoidManager fogVoidManager
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x16D5DAC", Offset = "0x16D5DAC", VA = "0x16D5DAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x16D5C24", Offset = "0x16D5C24", VA = "0x16D5C24")]
		public static VolumetricFogManager GetManagerIfExists()
		{
			return null;
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x16D5E4C", Offset = "0x16D5E4C", VA = "0x16D5E4C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x16D6204", Offset = "0x16D6204", VA = "0x16D6204")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x16D5F1C", Offset = "0x16D5F1C", VA = "0x16D5F1C")]
		private void SetupCamera()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x16D5FFC", Offset = "0x16D5FFC", VA = "0x16D5FFC")]
		private void SetupLights()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x16D6138", Offset = "0x16D6138", VA = "0x16D6138")]
		private void SetupDepthPrePass()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x16D62AC", Offset = "0x16D62AC", VA = "0x16D62AC")]
		public static GameObject CreateFogVolume(string name)
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x16D6380", Offset = "0x16D6380", VA = "0x16D6380")]
		public static GameObject CreateFogVoid(string name)
		{
			return null;
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x16D64B8", Offset = "0x16D64B8", VA = "0x16D64B8")]
		public static GameObject CreateFogSubVolume(string name)
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x16D658C", Offset = "0x16D658C", VA = "0x16D658C")]
		public VolumetricFogManager()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class DepthRenderPrePassFeature : ScriptableRendererFeature
	{
		[Token(Token = "0x2000029")]
		public class DepthRenderPass : ScriptableRenderPass
		{
			[Token(Token = "0x4000072")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly List<Renderer> cutOutRenderers;

			[Token(Token = "0x4000073")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static int transparentLayerMask;

			[Token(Token = "0x4000074")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static int alphaCutoutLayerMask;

			[Token(Token = "0x4000075")]
			private const string m_ProfilerTag = "CustomDepthPrePass";

			[Token(Token = "0x4000076")]
			private const string m_DepthOnlyShader = "Hidden/VolumetricFog2/DepthOnly";

			[Token(Token = "0x4000077")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private FilteringSettings m_FilteringSettings;

			[Token(Token = "0x4000078")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private int currentCutoutLayerMask;

			[Token(Token = "0x4000079")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private readonly List<ShaderTagId> m_ShaderTagIdList;

			[Token(Token = "0x400007A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private RenderTargetHandle m_Depth;

			[Token(Token = "0x400007B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private Material depthOnlyMaterial;

			[Token(Token = "0x400007C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private Material depthOnlyMaterialCutOff;

			[Token(Token = "0x400007D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private Material[] depthOverrideMaterials;

			[Token(Token = "0x6000051")]
			[Address(RVA = "0x16D7188", Offset = "0x16D7188", VA = "0x16D7188")]
			public DepthRenderPass()
			{
			}

			[Token(Token = "0x6000052")]
			[Address(RVA = "0x16D73EC", Offset = "0x16D73EC", VA = "0x16D73EC")]
			private void SetupKeywords()
			{
			}

			[Token(Token = "0x6000053")]
			[Address(RVA = "0x16D6208", Offset = "0x16D6208", VA = "0x16D6208")]
			public static void SetupLayerMasks(int transparentLayerMask, int alphaCutoutLayerMask)
			{
			}

			[Token(Token = "0x6000054")]
			[Address(RVA = "0x16D74B0", Offset = "0x16D74B0", VA = "0x16D74B0")]
			public static void FindAlphaClippingRenderers()
			{
			}

			[Token(Token = "0x6000055")]
			[Address(RVA = "0x16D7694", Offset = "0x16D7694", VA = "0x16D7694", Slot = "6")]
			public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
			{
			}

			[Token(Token = "0x6000056")]
			[Address(RVA = "0x16D7998", Offset = "0x16D7998", VA = "0x16D7998", Slot = "9")]
			public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
			{
			}

			[Token(Token = "0x6000057")]
			[Address(RVA = "0x16D8180", Offset = "0x16D8180", VA = "0x16D8180", Slot = "4")]
			public override void FrameCleanup(CommandBuffer cmd)
			{
			}
		}

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DepthRenderPass m_ScriptablePass;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool installed;

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x131892C", Offset = "0x131892C", VA = "0x131892C", Slot = "5")]
		public override void Create()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x13189A0", Offset = "0x13189A0", VA = "0x13189A0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x13189EC", Offset = "0x13189EC", VA = "0x13189EC", Slot = "6")]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1318A60", Offset = "0x1318A60", VA = "0x1318A60")]
		public DepthRenderPrePassFeature()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public static class Tools
	{
		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Color ColorBlack;

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1319A60", Offset = "0x1319A60", VA = "0x1319A60")]
		public static void CheckCamera(ref Camera cam)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1326BB0", Offset = "0x1326BB0", VA = "0x1326BB0")]
		public static VolumetricFogManager CheckMainManager()
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		public static void CheckManager<T>(ref T manager) where T : Component
		{
		}
	}
	[Token(Token = "0x200002B")]
	public enum MASK_TEXTURE_BRUSH_MODE
	{
		[Token(Token = "0x4000080")]
		AddFog,
		[Token(Token = "0x4000081")]
		RemoveFog,
		[Token(Token = "0x4000082")]
		ColorFog
	}
	[Token(Token = "0x200002C")]
	[ExecuteInEditMode]
	public class VolumetricFog : MonoBehaviour
	{
		[Token(Token = "0x200002D")]
		private struct FogOfWarTransition
		{
			[Token(Token = "0x40000C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool enabled;

			[Token(Token = "0x40000C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int x;

			[Token(Token = "0x40000CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int y;

			[Token(Token = "0x40000CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float startTime;

			[Token(Token = "0x40000CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float startDelay;

			[Token(Token = "0x40000CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float duration;

			[Token(Token = "0x40000CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int initialAlpha;

			[Token(Token = "0x40000CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int targetAlpha;
		}

		[Token(Token = "0x200002E")]
		public enum HeightmapCaptureResolution
		{
			[Token(Token = "0x40000D1")]
			_64 = 0x40,
			[Token(Token = "0x40000D2")]
			_128 = 0x80,
			[Token(Token = "0x40000D3")]
			_256 = 0x100,
			[Token(Token = "0x40000D4")]
			_512 = 0x200,
			[Token(Token = "0x40000D5")]
			_1024 = 0x400
		}

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool enableFogOfWar;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 fogOfWarCenter;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool fogOfWarIsLocal;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 fogOfWarSize;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA743F4", Offset = "0xA743F4")]
		public int fogOfWarTextureSize;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA74414", Offset = "0xA74414")]
		public float fogOfWarRestoreDelay;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA74430", Offset = "0xA74430")]
		public float fogOfWarRestoreDuration;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA74448", Offset = "0xA74448")]
		public float fogOfWarSmoothness;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool fogOfWarBlur;

		[Token(Token = "0x400008C")]
		private const int MAX_SIMULTANEOUS_TRANSITIONS = 10000;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool canDestroyFOWTexture;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		public bool maskEditorEnabled;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public MASK_TEXTURE_BRUSH_MODE maskBrushMode;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Color maskBrushColor;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA74460", Offset = "0xA74460")]
		public int maskBrushWidth;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA7447C", Offset = "0xA7447C")]
		public float maskBrushFuzziness;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA74494", Offset = "0xA74494")]
		public float maskBrushOpacity;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Texture2D _fogOfWarTexture;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Color32[] fogOfWarColorBuffer;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private FogOfWarTransition[] fowTransitionList;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int lastTransitionPos;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Dictionary<int, int> fowTransitionIndices;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool requiresTextureUpload;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Material fowBlur;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private RenderTexture fowBlur1;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private RenderTexture fowBlur2;

		[Token(Token = "0x400009D")]
		private const string SURFACE_CAM_NAME = "SurfaceCam";

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private RenderTexture rt;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Camera cam;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int camStartFrameCount;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Matrix4x4 camMatrix;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private Vector3 lastCamPos;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Matrix4x4 identityMatrix;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public VolumetricFogProfile profile;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA744BC", Offset = "0xA744BC")]
		public bool enableNativeLights;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x121")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA744F4", Offset = "0xA744F4")]
		public bool enablePointLights;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x122")]
		public bool enableSpotLights;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x123")]
		public bool enableVoids;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA7452C", Offset = "0xA7452C")]
		public bool enableFade;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public float fadeDistance;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA74564", Offset = "0xA74564")]
		public bool fadeOut;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA7459C", Offset = "0xA7459C")]
		public Transform fadeController;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA745D4", Offset = "0xA745D4")]
		public bool enableSubVolumes;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA7460C", Offset = "0xA7460C")]
		public List<VolumetricFogSubVolume> subVolumes;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA74644", Offset = "0xA74644")]
		public bool showBoundary;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Renderer r;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Material fogMat;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Material noiseMat;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Material turbulenceMat;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Material fogMat2D;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Material noiseMat2D;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Material turbulenceMat2D;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private RenderTexture rtNoise;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private RenderTexture rtTurbulence;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float turbAcum;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private Vector3 windAcum;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private Vector3 sunDir;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private float dayLight;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private List<string> shaderKeywords;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Texture3D detailTex;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Texture3D refDetailTex;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Mesh debugMesh;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private Material fogDebugMat;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private VolumetricFogProfile activeProfile;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private VolumetricFogProfile lerpProfile;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private Vector3 lastControllerPosition;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
		private float alphaMultiplier;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private bool profileIsInstanced;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x201")]
		private bool requireUpdateMaterial;

		[Token(Token = "0x17000008")]
		public Vector3 anchoredFogOfWarCenter
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x1326D04", Offset = "0x1326D04", VA = "0x1326D04")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000009")]
		public Texture2D fogOfWarTexture
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x1326D64", Offset = "0x1326D64", VA = "0x1326D64")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x1326D6C", Offset = "0x1326D6C", VA = "0x1326D6C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public Color32[] fogOfWarTextureData
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x1329610", Offset = "0x1329610", VA = "0x1329610")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x1329618", Offset = "0x1329618", VA = "0x1329618")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public VolumetricFogProfile settings
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x132A940", Offset = "0x132A940", VA = "0x132A940")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x132AA28", Offset = "0x132AA28", VA = "0x132AA28")]
			set
			{
			}
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1327020", Offset = "0x1327020", VA = "0x1327020")]
		private void FogOfWarInit()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x132734C", Offset = "0x132734C", VA = "0x132734C")]
		private void FogOfWarDestroy()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1326EE0", Offset = "0x1326EE0", VA = "0x1326EE0")]
		public void ReloadFogOfWarTexture()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x13271AC", Offset = "0x13271AC", VA = "0x13271AC")]
		private void FogOfWarUpdateTexture()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1327B90", Offset = "0x1327B90", VA = "0x1327B90")]
		private int GetScaledSize(int size, float factor)
		{
			return default(int);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1327D7C", Offset = "0x1327D7C", VA = "0x1327D7C")]
		public void UpdateFogOfWar(bool forceUpload = false)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x13282D8", Offset = "0x13282D8", VA = "0x13282D8")]
		private void SetFowBlurTexture()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1328718", Offset = "0x1328718", VA = "0x1328718")]
		private void CreateFoWBlurRTs()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x132892C", Offset = "0x132892C", VA = "0x132892C")]
		public void SetFogOfWarAlpha(Vector3 worldPosition, float radius, float fogNewAlpha)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1318044", Offset = "0x1318044", VA = "0x1318044")]
		public void SetFogOfWarAlpha(Vector3 worldPosition, float radius, float fogNewAlpha, float duration)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1328CD4", Offset = "0x1328CD4", VA = "0x1328CD4")]
		public void SetFogOfWarAlpha(Vector3 worldPosition, float radius, float fogNewAlpha, float duration, float smoothness)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x132895C", Offset = "0x132895C", VA = "0x132895C")]
		public void SetFogOfWarAlpha(Vector3 worldPosition, float radius, float fogNewAlpha, bool blendAlpha, float duration, float smoothness, float restoreDelay, float restoreDuration)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1328CFC", Offset = "0x1328CFC", VA = "0x1328CFC")]
		public void SetFogOfWarAlpha(Bounds bounds, float fogNewAlpha, float duration)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1329130", Offset = "0x1329130", VA = "0x1329130")]
		public void SetFogOfWarAlpha(Bounds bounds, float fogNewAlpha, float duration, float smoothness)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1328D38", Offset = "0x1328D38", VA = "0x1328D38")]
		public void SetFogOfWarAlpha(Bounds bounds, float fogNewAlpha, bool blendAlpha, float duration, float smoothness, float restoreDelay, float restoreDuration)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1329168", Offset = "0x1329168", VA = "0x1329168")]
		public void ResetFogOfWarAlpha(Vector3 worldPosition, float radius)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x132937C", Offset = "0x132937C", VA = "0x132937C")]
		public void ResetFogOfWarAlpha(Bounds bounds)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1329600", Offset = "0x1329600", VA = "0x1329600")]
		public void ResetFogOfWarAlpha(Vector3 position, Vector3 size)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x13293F8", Offset = "0x13293F8", VA = "0x13293F8")]
		public void ResetFogOfWarAlpha(Vector3 position, float extentsX, float extentsZ)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1327BBC", Offset = "0x1327BBC", VA = "0x1327BBC")]
		public void ResetFogOfWar(byte alpha = byte.MaxValue)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1328008", Offset = "0x1328008", VA = "0x1328008")]
		private void AddFogOfWarTransitionSlot(int x, int y, byte initialAlpha, byte targetAlpha, float delay, float duration)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1329728", Offset = "0x1329728", VA = "0x1329728")]
		public float GetFogOfWarAlpha(Vector3 worldPosition)
		{
			return default(float);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x13298CC", Offset = "0x13298CC", VA = "0x13298CC")]
		private void DisposeSurfaceCapture()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1329A2C", Offset = "0x1329A2C", VA = "0x1329A2C")]
		private void CheckSurfaceCapture()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1329998", Offset = "0x1329998", VA = "0x1329998")]
		private void DisableSurfaceCapture()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1329BBC", Offset = "0x1329BBC", VA = "0x1329BBC")]
		private void SurfaceCaptureSupportCheck()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x132A27C", Offset = "0x132A27C", VA = "0x132A27C")]
		public void ScheduleShadowCapture()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x132A360", Offset = "0x132A360", VA = "0x132A360")]
		private void SetupCameraCaptureMatrix()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x132A7B8", Offset = "0x132A7B8", VA = "0x132A7B8")]
		private void SurfaceCaptureUpdate()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x132A624", Offset = "0x132A624", VA = "0x132A624")]
		private void ComputeSufaceTransform(Matrix4x4 proj, Matrix4x4 view)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x132AA54", Offset = "0x132AA54", VA = "0x132AA54")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x132AAF0", Offset = "0x132AAF0", VA = "0x132AAF0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x132ABDC", Offset = "0x132ABDC", VA = "0x132ABDC")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x132ABE0", Offset = "0x132ABE0", VA = "0x132ABE0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x132AD28", Offset = "0x132AD28", VA = "0x132AD28")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x132ADEC", Offset = "0x132ADEC", VA = "0x132ADEC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x132C544", Offset = "0x132C544", VA = "0x132C544")]
		private void UpdateNoise()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1327460", Offset = "0x1327460", VA = "0x1327460")]
		public void UpdateMaterialProperties()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x132B780", Offset = "0x132B780", VA = "0x132B780")]
		private void ComputeActiveProfile()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x132CC2C", Offset = "0x132CC2C", VA = "0x132CC2C")]
		private float ComputeVolumeFade(Transform transform, float fadeDistance)
		{
			return default(float);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x132BC28", Offset = "0x132BC28", VA = "0x132BC28")]
		private void ApplyProfileSettings()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x13285C4", Offset = "0x13285C4", VA = "0x13285C4")]
		private void UpdateFogOfWarMaterialBoundsProperties()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x132CD0C", Offset = "0x132CD0C", VA = "0x132CD0C")]
		public static void FindAlphaClippingObjects()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x132CD68", Offset = "0x132CD68", VA = "0x132CD68")]
		public VolumetricFog()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public static class ShaderParams
	{
		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int DetailOffset;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static int DetailColor;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static int DetailData;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static int Density;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static int ShadowIntensity;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static int LightDiffusionIntensity;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static int LightDiffusionPower;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static int DeepObscurance;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static int NoiseScale;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static int SpecularThreshold;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static int SpecularIntensity;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static int SpecularColor;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static int NoiseFinalMultiplier;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static int NoiseStrength;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static int TurbulenceAmount;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static int BoundsVerticalOffset;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static int FogOfWarCenterAdjusted;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static int FogOfWarSize;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static int FogOfWarCenter;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public static int FogOfWarTexture;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static int DistanceData;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public static int DetailTexture;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static int RaymarchSettings;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public static int SunDir;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static int Color;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public static int MainTex;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static int WindDirection;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public static int LightColor;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static int BoundsBorder;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public static int BoundsExtents;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static int BoundsCenter;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public static int SurfaceCaptureMatrix;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static int SurfaceDepthTexture;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public static int SurfaceData;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static int PointLightCount;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public static int PointLightInsideAtten;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static int PointLightPositions;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public static int PointLightColors;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public static int VoidCount;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public static int VoidSizes;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public static int VoidPositions;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public static int CustomDepthTexture;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public static int CustomDepthAlphaCutoff;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public static int CustomDepthBaseMap;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public static int SpotLightCount;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public static int SpotLightPositions;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public static int SpotLightDirections;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public static int SpotLightColors;

		[Token(Token = "0x4000106")]
		public const string SKW_CUSTOM_DEPTH_ALPHA_TEST = "DEPTH_PREPASS_ALPHA_TEST";

		[Token(Token = "0x4000107")]
		public const string SKW_SHAPE_BOX = "V2F_SHAPE_BOX";

		[Token(Token = "0x4000108")]
		public const string SKW_SHAPE_SPHERE = "V2F_SHAPE_SPHERE";

		[Token(Token = "0x4000109")]
		public const string SKW_POINT_LIGHTS = "VF2_POINT_LIGHTS";

		[Token(Token = "0x400010A")]
		public const string SKW_NATIVE_LIGHTS = "VF2_NATIVE_LIGHTS";

		[Token(Token = "0x400010B")]
		public const string SKW_VOIDS = "VF2_VOIDS";

		[Token(Token = "0x400010C")]
		public const string SKW_FOW = "VF2_FOW";

		[Token(Token = "0x400010D")]
		public const string SKW_RECEIVE_SHADOWS = "VF2_RECEIVE_SHADOWS";

		[Token(Token = "0x400010E")]
		public const string SKW_DISTANCE = "VF2_DISTANCE";

		[Token(Token = "0x400010F")]
		public const string SKW_DETAIL_NOISE = "V2F_DETAIL_NOISE";

		[Token(Token = "0x4000110")]
		public const string SKW_SURFACE = "V2F_SURFACE";

		[Token(Token = "0x4000111")]
		public const string SKW_DEPTH_PREPASS = "VF2_DEPTH_PREPASS";
	}
	[Token(Token = "0x2000030")]
	public enum VolumetricFogShape
	{
		[Token(Token = "0x4000113")]
		Box,
		[Token(Token = "0x4000114")]
		Sphere
	}
	[Token(Token = "0x2000031")]
	public delegate void OnSettingsChanged();
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xA73B84", Offset = "0xA73B84")]
	public class VolumetricFogProfile : ScriptableObject
	{
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA7467C", Offset = "0xA7467C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA7467C", Offset = "0xA7467C")]
		public int raymarchQuality;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA746D0", Offset = "0xA746D0")]
		public float raymarchMinStep;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float jittering;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA74708", Offset = "0xA74708")]
		public float dithering;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA74720", Offset = "0xA74720")]
		public int renderQueue;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA74758", Offset = "0xA74758")]
		public int sortingLayerID;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA74790", Offset = "0xA74790")]
		public int sortingOrder;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA747C8", Offset = "0xA747C8")]
		public Texture2D noiseTexture;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA74800", Offset = "0xA74800")]
		public float noiseStrength;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float noiseScale;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float noiseFinalMultiplier;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool useDetailNoise;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Texture3D detailTexture;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float detailScale;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA74818", Offset = "0xA74818")]
		public float detailStrength;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float detailOffset;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float density;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA74830", Offset = "0xA74830")]
		public VolumetricFogShape shape;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA74868", Offset = "0xA74868")]
		public float border;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float verticalOffset;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA74880", Offset = "0xA74880")]
		public float distance;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA748B8", Offset = "0xA748B8")]
		public float distanceFallOff;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA748D0", Offset = "0xA748D0")]
		public bool terrainFit;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public VolumetricFog.HeightmapCaptureResolution terrainFitResolution;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA74908", Offset = "0xA74908")]
		public LayerMask terrainLayerMask;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA74940", Offset = "0xA74940")]
		public float terrainFogHeight;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float terrainFogMinAltitude;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float terrainFogMaxAltitude;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA74978", Offset = "0xA74978")]
		public Color albedo;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float brightness;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA749B0", Offset = "0xA749B0")]
		public float deepObscurance;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public Color specularColor;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA749C8", Offset = "0xA749C8")]
		public float specularThreshold;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA749E0", Offset = "0xA749E0")]
		public float specularIntensity;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA749F8", Offset = "0xA749F8")]
		public float turbulence;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Vector3 windDirection;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA74A30", Offset = "0xA74A30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA74A30", Offset = "0xA74A30")]
		public float lightDiffusionPower;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA74A88", Offset = "0xA74A88")]
		public float lightDiffusionIntensity;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public bool receiveShadows;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA74AA0", Offset = "0xA74AA0")]
		public float shadowIntensity;

		[Token(Token = "0x14000001")]
		public event OnSettingsChanged onSettingsChanged
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x16D659C", Offset = "0x16D659C", VA = "0x16D659C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA74D84", Offset = "0xA74D84")]
			add
			{
			}
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x16D663C", Offset = "0x16D663C", VA = "0x16D663C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA74D94", Offset = "0xA74D94")]
			remove
			{
			}
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x16D66DC", Offset = "0x16D66DC", VA = "0x16D66DC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x16D681C", Offset = "0x16D681C", VA = "0x16D681C")]
		public void ValidateSettings()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x16D68EC", Offset = "0x16D68EC", VA = "0x16D68EC")]
		public void Lerp(VolumetricFogProfile p1, VolumetricFogProfile p2, float t)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x16D6D54", Offset = "0x16D6D54", VA = "0x16D6D54")]
		public VolumetricFogProfile()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class VolumetricFogSubVolume : MonoBehaviour
	{
		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VolumetricFogProfile profile;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float fadeDistance;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<VolumetricFogSubVolume> subVolumes;

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x16D6E8C", Offset = "0x16D6E8C", VA = "0x16D6E8C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x16D6F24", Offset = "0x16D6F24", VA = "0x16D6F24")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x16D7008", Offset = "0x16D7008", VA = "0x16D7008")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x16D70EC", Offset = "0x16D70EC", VA = "0x16D70EC")]
		public VolumetricFogSubVolume()
		{
		}
	}
}
namespace VoluemtricFogAndMist2.Demos
{
	[Token(Token = "0x2000034")]
	public class CapsuleController : MonoBehaviour
	{
		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VolumetricFog fogVolume;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float moveSpeed;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float fogHoleRadius;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float clearDuration;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 lastPos;

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1317E88", Offset = "0x1317E88", VA = "0x1317E88")]
		private void Update()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1318070", Offset = "0x1318070", VA = "0x1318070")]
		public CapsuleController()
		{
		}
	}
}
namespace Malee.List
{
	[Token(Token = "0x2000035")]
	public class ReorderableAttribute : PropertyAttribute
	{
		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool add;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		public bool remove;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
		public bool draggable;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
		public bool singleLine;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool paginate;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool sortable;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool labels;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int pageSize;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string elementNameProperty;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string elementNameOverride;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string elementIconPath;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Type surrogateType;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string surrogateProperty;

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1325D30", Offset = "0x1325D30", VA = "0x1325D30")]
		public ReorderableAttribute()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1325D4C", Offset = "0x1325D4C", VA = "0x1325D4C")]
		public ReorderableAttribute(string elementNameProperty)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1325E0C", Offset = "0x1325E0C", VA = "0x1325E0C")]
		public ReorderableAttribute(string elementNameProperty, string elementIconPath)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1325E28", Offset = "0x1325E28", VA = "0x1325E28")]
		public ReorderableAttribute(string elementNameProperty, string elementNameOverride, string elementIconPath)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1325E44", Offset = "0x1325E44", VA = "0x1325E44")]
		public ReorderableAttribute(bool add, bool remove, bool draggable, [Optional] string elementNameProperty, [Optional] string elementIconPath)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1325D68", Offset = "0x1325D68", VA = "0x1325D68")]
		public ReorderableAttribute(bool add, bool remove, bool draggable, [Optional] string elementNameProperty, [Optional] string elementNameOverride, [Optional] string elementIconPath)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xA73BF0", Offset = "0xA73BF0")]
	public abstract class ReorderableArray<T> : ICloneable, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<T> array;

		[Token(Token = "0x1700000C")]
		public T Item
		{
			[Token(Token = "0x60000AB")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x60000AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public int Length
		{
			[Token(Token = "0x60000AD")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700000E")]
		public bool IsReadOnly
		{
			[Token(Token = "0x60000AE")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		public int Count
		{
			[Token(Token = "0x60000AF")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60000A9")]
		public ReorderableArray()
		{
		}

		[Token(Token = "0x60000AA")]
		public ReorderableArray(int length)
		{
		}

		[Token(Token = "0x60000B0")]
		public object Clone()
		{
			return null;
		}

		[Token(Token = "0x60000B1")]
		public void CopyFrom(IEnumerable<T> value)
		{
		}

		[Token(Token = "0x60000B2")]
		public bool Contains(T value)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B3")]
		public int IndexOf(T value)
		{
			return default(int);
		}

		[Token(Token = "0x60000B4")]
		public void Insert(int index, T item)
		{
		}

		[Token(Token = "0x60000B5")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x60000B6")]
		public void Add(T item)
		{
		}

		[Token(Token = "0x60000B7")]
		public void Clear()
		{
		}

		[Token(Token = "0x60000B8")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x60000B9")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BA")]
		public T[] ToArray()
		{
			return null;
		}

		[Token(Token = "0x60000BB")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
namespace LuxURPEssentials
{
	[Token(Token = "0x2000037")]
	public class DecalManager : MonoBehaviour
	{
		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Gizmos;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool DrawDecalGizmos;

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1318860", Offset = "0x1318860", VA = "0x1318860")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x13188CC", Offset = "0x13188CC", VA = "0x13188CC")]
		public DecalManager()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class LuxURP_HelpBtn : PropertyAttribute
	{
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string URL;

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x131B058", Offset = "0x131B058", VA = "0x131B058")]
		public LuxURP_HelpBtn(string URL)
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class LuxURP_LayerBasedCulling : MonoBehaviour
	{
		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LuxURP_HelpBtn", RVA = "0xA74AD8", Offset = "0xA74AD8")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA74AD8", Offset = "0xA74AD8")]
		public LayerMask SmallDetailsLayer;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SmallDetailsDistance;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LayerMask MediumDetailsLayer;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float MediumDetailsDistance;

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x131B08C", Offset = "0x131B08C", VA = "0x131B08C")]
		private int GetLayerNumber(int LayerValue)
		{
			return default(int);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x131B0AC", Offset = "0x131B0AC", VA = "0x131B0AC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x131B254", Offset = "0x131B254", VA = "0x131B254")]
		public LuxURP_LayerBasedCulling()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003A")]
	public enum RTSize
	{
		[Token(Token = "0x400015C")]
		_128 = 0x80,
		[Token(Token = "0x400015D")]
		_256 = 0x100,
		[Token(Token = "0x400015E")]
		_512 = 0x200
	}
	[Serializable]
	[Token(Token = "0x200003B")]
	public enum RTFormat
	{
		[Token(Token = "0x4000160")]
		ARGB32,
		[Token(Token = "0x4000161")]
		ARGBHalf
	}
	[Serializable]
	[Token(Token = "0x200003C")]
	public enum GustMixLayer
	{
		[Token(Token = "0x4000163")]
		Layer_0,
		[Token(Token = "0x4000164")]
		Layer_1,
		[Token(Token = "0x4000165")]
		Layer_2
	}
	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA73C28", Offset = "0xA73C28")]
	[ExecuteInEditMode]
	public class LuxURP_Wind : MonoBehaviour
	{
		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA74B3C", Offset = "0xA74B3C")]
		[AttributeAttribute(Name = "LuxURP_HelpBtn", RVA = "0xA74B3C", Offset = "0xA74B3C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA74B3C", Offset = "0xA74B3C")]
		public bool UpdateInEditMode;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA74BA0", Offset = "0xA74BA0")]
		public RTSize Resolution;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RTFormat Format;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture WindBaseTex;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader WindCompositeShader;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA74BD8", Offset = "0xA74BD8")]
		public float Grass;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float Foliage;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA74C10", Offset = "0xA74C10")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA74C10", Offset = "0xA74C10")]
		public float BaseWindSpeed;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA74C70", Offset = "0xA74C70")]
		public float SizeInWorldSpace;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA74CA8", Offset = "0xA74CA8")]
		public float speedLayer0;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float speedLayer1;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float speedLayer2;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA74CBC", Offset = "0xA74CBC")]
		public int GrassGustTiling;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float GrassGustSpeed;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public GustMixLayer LayerToMixWith;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA74CF4", Offset = "0xA74CF4")]
		public float JitterFrequency;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float JitterHighFrequency;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RenderTexture WindRenderTexture;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_material;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector2 uvs;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector2 uvs1;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector2 uvs2;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector2 uvs3;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int WindRTPID;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Transform trans;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private WindZone windZone;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float mainWind;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float turbulence;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int LuxLWRPWindDirSizePID;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int LuxLWRPWindStrengthMultipliersPID;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int LuxLWRPSinTimePID;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int LuxLWRPGustPID;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int LuxLWRPGustMixLayerPID;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int LuxLWRPWindUVsPID;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int LuxLWRPWindUVs1PID;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int LuxLWRPWindUVs2PID;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int LuxLWRPWindUVs3PID;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private int previousRTSize;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int previousRTFormat;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector4 WindDirectionSize;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3[] MixLayers;

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x131B26C", Offset = "0x131B26C", VA = "0x131B26C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x131B75C", Offset = "0x131B75C", VA = "0x131B75C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x131B434", Offset = "0x131B434", VA = "0x131B434")]
		private void SetupRT()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x131B5C4", Offset = "0x131B5C4", VA = "0x131B5C4")]
		private void GetPIDs()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x131B8CC", Offset = "0x131B8CC", VA = "0x131B8CC")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x131BADC", Offset = "0x131BADC", VA = "0x131BADC")]
		private void Update()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x131BEF8", Offset = "0x131BEF8", VA = "0x131BEF8")]
		public LuxURP_Wind()
		{
		}
	}
	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA73C98", Offset = "0xA73C98")]
	public class GetTerrainHeightNormalMap : MonoBehaviour
	{
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TerrainData targetTerrainData;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string savePathTerrainHeightNormalMap;

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x131A3E8", Offset = "0x131A3E8", VA = "0x131A3E8")]
		public void GetTerData()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x131A4BC", Offset = "0x131A4BC", VA = "0x131A4BC")]
		public GetTerrainHeightNormalMap()
		{
		}
	}
}
namespace Lux_SRP_GrassDisplacement
{
	[Token(Token = "0x200003F")]
	public class RotateAndMove : MonoBehaviour
	{
		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Rotate;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool MoveUpDown;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float posy;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform trans;

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1325E5C", Offset = "0x1325E5C", VA = "0x1325E5C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1325ED4", Offset = "0x1325ED4", VA = "0x1325ED4")]
		private void Update()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1325FA0", Offset = "0x1325FA0", VA = "0x1325FA0")]
		public RotateAndMove()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform targetTransform;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float smoothTime;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 velocity;

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x13268F4", Offset = "0x13268F4", VA = "0x13268F4")]
		private void Update()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1326990", Offset = "0x1326990", VA = "0x1326990")]
		public SmoothFollow()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[ExecuteInEditMode]
	public class ControlDisplacer : MonoBehaviour
	{
		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxDistance;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float fallOff;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Layer]
		public int layerMask;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA74D3C", Offset = "0xA74D3C")]
		public bool DebugRay;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform trans;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Renderer rend;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private MaterialPropertyBlock mpb;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RaycastHit hit;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float alpha;

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x13181F4", Offset = "0x13181F4", VA = "0x13181F4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x13182F0", Offset = "0x13182F0", VA = "0x13182F0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1318330", Offset = "0x1318330", VA = "0x1318330")]
		private void Update()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x13184BC", Offset = "0x13184BC", VA = "0x13184BC")]
		public ControlDisplacer()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA73D08", Offset = "0xA73D08")]
	public class ControlDisplacerParticleSys : MonoBehaviour
	{
		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxDistance;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float fallOff;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Layer]
		public int layerMask;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA74D60", Offset = "0xA74D60")]
		public bool DebugRay;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform trans;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParticleSystem ps;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ParticleSystem.MainModule main;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RaycastHit hit;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float alpha;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float min_alpha;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float max_alpha;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Color min_StartColor;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Color max_StartColor;

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x13184D8", Offset = "0x13184D8", VA = "0x13184D8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x131862C", Offset = "0x131862C", VA = "0x131862C")]
		private void Update()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x131882C", Offset = "0x131882C", VA = "0x131882C")]
		public ControlDisplacerParticleSys()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class DebugGrassDisplacementTex : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000044")]
		public enum DebugSize
		{
			[Token(Token = "0x40001B1")]
			_128 = 0x80,
			[Token(Token = "0x40001B2")]
			_256 = 0x100,
			[Token(Token = "0x40001B3")]
			_512 = 0x200,
			[Token(Token = "0x40001B4")]
			_1024 = 0x400
		}

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool m_EnableDebug;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public DebugSize currentDebugSize;

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1318848", Offset = "0x1318848", VA = "0x1318848")]
		public DebugGrassDisplacementTex()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class GrassDisplacementRenderFeature : ScriptableRendererFeature
	{
		[Serializable]
		[Token(Token = "0x2000046")]
		public enum RTDisplacementSize
		{
			[Token(Token = "0x40001B8")]
			_128 = 0x80,
			[Token(Token = "0x40001B9")]
			_256 = 0x100,
			[Token(Token = "0x40001BA")]
			_512 = 0x200,
			[Token(Token = "0x40001BB")]
			_1024 = 0x400
		}

		[Serializable]
		[Token(Token = "0x2000047")]
		public class GrassDisplacementSettings
		{
			[Token(Token = "0x40001BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RTDisplacementSize Resolution;

			[Token(Token = "0x40001BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float Size;

			[Token(Token = "0x40001BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool ShiftRenderTex;

			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x16D8360", Offset = "0x16D8360", VA = "0x16D8360")]
			public GrassDisplacementSettings()
			{
			}
		}

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GrassDisplacementSettings settings;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GrassDisplacementPass m_GrassDisplacementPass;

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x131AEF0", Offset = "0x131AEF0", VA = "0x131AEF0", Slot = "5")]
		public override void Create()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x131AFBC", Offset = "0x131AFBC", VA = "0x131AFBC", Slot = "6")]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x131AFE0", Offset = "0x131AFE0", VA = "0x131AFE0")]
		public GrassDisplacementRenderFeature()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class GrassDisplacementPass : ScriptableRenderPass
	{
		[Token(Token = "0x40001BF")]
		private const string k_RenderGrassDisplacementFXTag = "Render Lux Grass Displacement FX";

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ShaderTagId m_GrassDisplacementFXShaderTag;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Color m_ClearColor;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RenderTargetHandle m_GrassDisplacementFX;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Matrix4x4 projectionMatrix;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Matrix4x4 worldToCameraMatrix;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public float m_Size;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		public int m_Resolution;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public bool m_ShiftRenderTex;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private float stepSize;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private float oneOverStepSize;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector4 posSize;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int DisplacementTexPosSizePID;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA74D74", Offset = "0xA74D74")]
		private FilteringSettings <transparentFilterSettings>k__BackingField;

		[Token(Token = "0x17000010")]
		private FilteringSettings transparentFilterSettings
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x131A4C4", Offset = "0x131A4C4", VA = "0x131A4C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA74DA4", Offset = "0xA74DA4")]
			get
			{
				return default(FilteringSettings);
			}
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x131A4E0", Offset = "0x131A4E0", VA = "0x131A4E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA74DB4", Offset = "0xA74DB4")]
			set
			{
			}
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x131A4FC", Offset = "0x131A4FC", VA = "0x131A4FC")]
		public GrassDisplacementPass()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x131A6D0", Offset = "0x131A6D0", VA = "0x131A6D0", Slot = "6")]
		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x131A98C", Offset = "0x131A98C", VA = "0x131A98C", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x131AE60", Offset = "0x131AE60", VA = "0x131AE60", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}
	}
	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xA73D68", Offset = "0xA73D68")]
	public class LayerAttribute : PropertyAttribute
	{
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x131B050", Offset = "0x131B050", VA = "0x131B050")]
		public LayerAttribute()
		{
		}
	}
}
namespace LuxLWRPEssentials.Demo
{
	[Token(Token = "0x200004A")]
	public class AnimateSphere : MonoBehaviour
	{
		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform trans;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float yPos;

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1317678", Offset = "0x1317678", VA = "0x1317678")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x13176F0", Offset = "0x13176F0", VA = "0x13176F0")]
		private void Update()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1317764", Offset = "0x1317764", VA = "0x1317764")]
		public AnimateSphere()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class CheckSettings : MonoBehaviour
	{
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1318088", Offset = "0x1318088", VA = "0x1318088")]
		private void Start()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x13181E8", Offset = "0x13181E8", VA = "0x13181E8")]
		private void Update()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x13181EC", Offset = "0x13181EC", VA = "0x13181EC")]
		public CheckSettings()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class ExtendedFlycam : MonoBehaviour
	{
		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float cameraSensitivity;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float climbSpeed;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float normalMoveSpeed;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoveFactor;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fastMoveFactor;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float rotationX;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float rotationY;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool isOrtho;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Camera cam;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool isActive;

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1318A70", Offset = "0x1318A70", VA = "0x1318A70")]
		private void Start()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1318B58", Offset = "0x1318B58", VA = "0x1318B58")]
		private void Update()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x131923C", Offset = "0x131923C", VA = "0x131923C")]
		public ExtendedFlycam()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class MouseSelect : MonoBehaviour
	{
		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform selectedTransform;

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x131C048", Offset = "0x131C048", VA = "0x131C048")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x131C2E0", Offset = "0x131C2E0", VA = "0x131C2E0")]
		public MouseSelect()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class ToggleOutlineSelection : MonoBehaviour
	{
		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material SelectionMaterial;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Material OutlineMaterial;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Renderer rend;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material[] BaseMatArray;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material[] SelectedMatArray;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool Selected;

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x13269D8", Offset = "0x13269D8", VA = "0x13269D8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x131C284", Offset = "0x131C284", VA = "0x131C284")]
		public void Select()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1326B2C", Offset = "0x1326B2C", VA = "0x1326B2C")]
		public ToggleOutlineSelection()
		{
		}
	}
}
namespace CrazyMinnow.SALSA.OneClicks
{
	[Token(Token = "0x200004F")]
	public class OneClickBase : MonoBehaviour
	{
		[Token(Token = "0x40001E0")]
		public const string RESOURCE_CLIP = "Assets/Crazy Minnow Studio/Examples/Audio/Promo-male.mp3";

		[Token(Token = "0x40001E1")]
		public const string PREFAB_ALERT_TITLE = "Prefab Unpack Warning";

		[Token(Token = "0x40001E2")]
		public const string PREFAB_ALERT_MSG = "Your selection is a prefab and must be unpacked to apply this setup. You can create a new prefab once the setup is complete. Do you want to proceed?";

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static List<SkinnedMeshRenderer> requiredSmrs;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static List<OneClickConfiguration> oneClickConfigurations;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected static Salsa salsa;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected static Emoter emoter;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected static UmaUepProxy uepProxy;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected static GameObject selectedObject;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected static float emphasizerTrigger;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		protected static bool autoAdjustAnalysis;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		protected static bool autoAdjustMicrophone;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected static float audioUpdateDelay;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected static float loCutoff;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected static float hiCutoff;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected static bool useAdvDyn;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected static float advDynPrimaryBias;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		protected static bool useAdvDynJitter;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected static float advDynJitterAmount;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected static float advDynJitterProb;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected static float advDynSecondaryMix;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		protected static float emphasisChance;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected static bool useRandomEmotes;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		protected static bool isChancePerEmote;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		protected static int numRandomEmotesPerCycle;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected static float randomEmoteMinTimer;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		protected static float randomEmoteMaxTimer;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected static float randomChance;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		protected static bool useRandomFrac;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected static float randomFracBias;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		protected static bool useRandomHoldDuration;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected static float randomHoldDurationMin;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected static float randomHoldDurationMax;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected static LerpEasings.EasingType easingType;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static OneClickConfiguration currentConfiguration;

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x131C66C", Offset = "0x131C66C", VA = "0x131C66C")]
		protected static void NewConfiguration(OneClickConfiguration.ConfigType configType)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x131C8C0", Offset = "0x131C8C0", VA = "0x131C8C0")]
		protected static void AddSmrSearch(string search)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x131C954", Offset = "0x131C954", VA = "0x131C954")]
		protected static void NewExpression(string expressionName)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x131CBAC", Offset = "0x131CBAC", VA = "0x131CBAC")]
		protected static void AddShapeComponent(string[] blendshapeNames, float durOn, float durHold, float durOff, string componentName = "", float amount = 1f, bool useRegex = false)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x131CDA0", Offset = "0x131CDA0", VA = "0x131CDA0")]
		protected static void AddUepPoseComponent(string poseName, float durOn, float durHold, float durOff, string componentName = "", float amount = 1f)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x131CF70", Offset = "0x131CF70", VA = "0x131CF70")]
		protected static void AddAnimatorComponent(string componentName, string animatorSearch, float durOn, float durHold, float durOff, int parmIndex, bool isTriggereParmBiDir = false)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x131D0C8", Offset = "0x131D0C8", VA = "0x131D0C8")]
		protected static void AddBoneComponent(string componentSearchName, TformBase maxTform, float durOn, float durHold, float durOff, string componentName = "", bool constrainPos = false, bool constrainRot = true, bool constrainScl = false)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x131D318", Offset = "0x131D318", VA = "0x131D318")]
		protected static void AddEmoteFlags(bool isRandom, bool isEmph, bool isRepeater, float frac = 1f, bool isAlwaysEmph = false)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x131D484", Offset = "0x131D484", VA = "0x131D484")]
		protected static void DoOneClickiness(GameObject go, AudioClip clip)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x131D7C0", Offset = "0x131D7C0", VA = "0x131D7C0")]
		private static bool FindSkinnedMeshRenderers(OneClickConfiguration configuration)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x131E168", Offset = "0x131E168", VA = "0x131E168")]
		private static void ConfigEmoterSettings(QueueProcessor qp)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x131DD38", Offset = "0x131DD38", VA = "0x131DD38")]
		private static void ConfigureSalsaSettings(AudioClip clip, QueueProcessor qp)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x131EFBC", Offset = "0x131EFBC", VA = "0x131EFBC")]
		protected static void Init()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x131E4A0", Offset = "0x131E4A0", VA = "0x131E4A0")]
		private static void ConfigureModuleExpressions(OneClickConfiguration configuration)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x131F06C", Offset = "0x131F06C", VA = "0x131F06C")]
		private static Expression InitializeExpressionType(OneClickConfiguration configuration, int exp)
		{
			return null;
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x131F4A4", Offset = "0x131F4A4", VA = "0x131F4A4")]
		private static int RegexFindBlendshapeName(SkinnedMeshRenderer smr, string bName)
		{
			return default(int);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x131FB80", Offset = "0x131FB80", VA = "0x131FB80")]
		private static string[] GetBlendshapeNames(SkinnedMeshRenderer smr)
		{
			return null;
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x131F910", Offset = "0x131F910", VA = "0x131F910")]
		private static TformBase ConvertBoneToTform(Transform bone)
		{
			return default(TformBase);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x131F7CC", Offset = "0x131F7CC", VA = "0x131F7CC")]
		private static Transform FindBone(string componentSearchName)
		{
			return null;
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x131FA3C", Offset = "0x131FA3C", VA = "0x131FA3C")]
		private static Animator FindAnimator(string componentSearchName)
		{
			return null;
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x131F6CC", Offset = "0x131F6CC", VA = "0x131F6CC")]
		private static void ApplyCommonSettingsToComponent(ExpressionComponent component, OneClickComponent oneClickComponent, int componentNumber)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x131F5B4", Offset = "0x131F5B4", VA = "0x131F5B4")]
		private static int CreateNewComponent(int componentCount, Expression expression)
		{
			return default(int);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x131FCC0", Offset = "0x131FCC0", VA = "0x131FCC0")]
		public OneClickBase()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class OneClickBoxHead : OneClickBase
	{
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x131FEAC", Offset = "0x131FEAC", VA = "0x131FEAC")]
		public static void Setup(GameObject gameObject, AudioClip clip)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1320684", Offset = "0x1320684", VA = "0x1320684")]
		public OneClickBoxHead()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class OneClickBoxHeadEyes : MonoBehaviour
	{
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x13206E8", Offset = "0x13206E8", VA = "0x13206E8")]
		public static void Setup(GameObject go)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1321194", Offset = "0x1321194", VA = "0x1321194")]
		public OneClickBoxHeadEyes()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class OneClickCC3 : OneClickBase
	{
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x132119C", Offset = "0x132119C", VA = "0x132119C")]
		public static void Setup(GameObject gameObject, AudioClip clip)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1323EF8", Offset = "0x1323EF8", VA = "0x1323EF8")]
		public OneClickCC3()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class OneClickCC3Eyes : MonoBehaviour
	{
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1323F5C", Offset = "0x1323F5C", VA = "0x1323F5C")]
		public static void Setup(GameObject go)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x13251DC", Offset = "0x13251DC", VA = "0x13251DC")]
		public OneClickCC3Eyes()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class OneClickComponent
	{
		[Token(Token = "0x2000055")]
		public enum ComponentType
		{
			[Token(Token = "0x4000209")]
			Shape,
			[Token(Token = "0x400020A")]
			UMA,
			[Token(Token = "0x400020B")]
			Bone,
			[Token(Token = "0x400020C")]
			Animator
		}

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ComponentType type;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string componentName;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float durOn;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float durHold;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float durOff;

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x131C664", Offset = "0x131C664", VA = "0x131C664")]
		public OneClickComponent()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class OneClickShapeComponent : OneClickComponent
	{
		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string[] blendshapeNames;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxAmount;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool useRegex;

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x131CD04", Offset = "0x131CD04", VA = "0x131CD04")]
		public OneClickShapeComponent(string componentName, string[] blendshapeNames, float maxAmount, float durOn, float durHold, float durOff, ComponentType type, bool useRegex)
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class OneClickBoneComponent : OneClickComponent
	{
		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string componentSearchName;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TformBase max;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool usePos;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool useRot;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		public bool useScl;

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x131D250", Offset = "0x131D250", VA = "0x131D250")]
		public OneClickBoneComponent(string componentName, string boneSearchName, TformBase max, bool usePos, bool useRot, bool useScl, float durOn, float durHold, float durOff, ComponentType type)
		{
		}
	}
	[Token(Token = "0x2000058")]
	public class OneClickUepComponent : OneClickComponent
	{
		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string poseName;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxAmount;

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x131CEE8", Offset = "0x131CEE8", VA = "0x131CEE8")]
		public OneClickUepComponent(string componentName, string poseName, float maxAmount, float durOn, float durHold, float durOff, ComponentType type)
		{
		}
	}
	[Token(Token = "0x2000059")]
	public class OneClickAnimatorComponent : OneClickComponent
	{
		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string componentSearchName;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int animationParmIndex;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool isTriggerParmBiDirectional;

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x131C5C8", Offset = "0x131C5C8", VA = "0x131C5C8")]
		public OneClickAnimatorComponent(string componentName, string animatorSearchName, int animationParmIndex, bool isTriggerParmBiDirectional, float durOn, float durHold, float durOff, ComponentType type)
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class OneClickConfiguration
	{
		[Token(Token = "0x200005B")]
		public enum ConfigType
		{
			[Token(Token = "0x400021E")]
			Salsa,
			[Token(Token = "0x400021F")]
			Emoter
		}

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ConfigType type;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<string> smrSearches;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<OneClickExpression> oneClickExpressions;

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x131C784", Offset = "0x131C784", VA = "0x131C784")]
		public OneClickConfiguration(ConfigType type)
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class OneClickExpression
	{
		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<OneClickComponent> components;

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x13251E4", Offset = "0x13251E4", VA = "0x13251E4")]
		public OneClickExpression()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x131CB04", Offset = "0x131CB04", VA = "0x131CB04")]
		public OneClickExpression(string name, List<OneClickComponent> components)
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class OneClickEmoterExpression : OneClickExpression
	{
		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isRandom;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool isEmphasis;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool isAlwaysEmphasis;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool isRepeater;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float expressionDynamics;

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x131CB54", Offset = "0x131CB54", VA = "0x131CB54")]
		public OneClickEmoterExpression(string name, List<OneClickComponent> components)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x131D45C", Offset = "0x131D45C", VA = "0x131D45C")]
		public void SetEmoterBools(bool isRand, bool isEmph, bool isRep, float frac, bool isAlwaysEmph = false)
		{
		}
	}
}
