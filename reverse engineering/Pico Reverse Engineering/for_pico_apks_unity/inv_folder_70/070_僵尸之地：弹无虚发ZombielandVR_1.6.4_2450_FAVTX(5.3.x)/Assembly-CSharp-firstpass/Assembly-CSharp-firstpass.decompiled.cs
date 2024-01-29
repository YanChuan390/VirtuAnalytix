using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using Il2CppDummyDll;
using Rewired.Components;
using Rewired.UI;
using Rewired.Utils.Interfaces;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x59B0C8", Offset = "0x59B0C8")]
public class CFX_AutoDestructShuriken : MonoBehaviour
{
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59BFDC", Offset = "0x59BFDC")]
	private sealed class <CheckIfAlive>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int <>1__state;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private object <>2__current;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CFX_AutoDestructShuriken <>4__this;

		[Token(Token = "0x17000310")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600088B")]
			[Address(RVA = "0x238DBF4", Offset = "0x238DBF4", VA = "0x238DBF4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000311")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600088D")]
			[Address(RVA = "0x238DC44", Offset = "0x238DC44", VA = "0x238DC44", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x238DA18", Offset = "0x238DA18", VA = "0x238DA18")]
		[DebuggerHidden]
		public <CheckIfAlive>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x238DA38", Offset = "0x238DA38", VA = "0x238DA38", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x238DA3C", Offset = "0x238DA3C", VA = "0x238DA3C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x238DBFC", Offset = "0x238DBFC", VA = "0x238DBFC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public bool OnlyDeactivate;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1336B70", Offset = "0x1336B70", VA = "0x1336B70")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1336BCC", Offset = "0x1336BCC", VA = "0x1336BCC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5A0500", Offset = "0x5A0500")]
	private IEnumerator CheckIfAlive()
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1336C50", Offset = "0x1336C50", VA = "0x1336C50")]
	public CFX_AutoDestructShuriken()
	{
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x59B134", Offset = "0x59B134")]
public class CFX_LightIntensityFade : MonoBehaviour
{
	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float duration;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float delay;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float finalIntensity;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float baseIntensity;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool autodestruct;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float p_lifetime;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float p_delay;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1336C58", Offset = "0x1336C58", VA = "0x1336C58")]
	private void Start()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1336CD0", Offset = "0x1336CD0", VA = "0x1336CD0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1336D64", Offset = "0x1336D64", VA = "0x1336D64")]
	private void Update()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1336F1C", Offset = "0x1336F1C", VA = "0x1336F1C")]
	public CFX_LightIntensityFade()
	{
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x59B1A0", Offset = "0x59B1A0")]
public class WFX_BulletHoleDecal : MonoBehaviour
{
	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59BFEC", Offset = "0x59BFEC")]
	private sealed class <holeUpdate>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int <>1__state;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private object <>2__current;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public WFX_BulletHoleDecal <>4__this;

		[Token(Token = "0x17000312")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000891")]
			[Address(RVA = "0x239BD20", Offset = "0x239BD20", VA = "0x239BD20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000313")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000893")]
			[Address(RVA = "0x239BD70", Offset = "0x239BD70", VA = "0x239BD70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0x239BB78", Offset = "0x239BB78", VA = "0x239BB78")]
		[DebuggerHidden]
		public <holeUpdate>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x239BB98", Offset = "0x239BB98", VA = "0x239BB98", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x239BB9C", Offset = "0x239BB9C", VA = "0x239BB9C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x239BD28", Offset = "0x239BD28", VA = "0x239BD28", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Vector2[] quadUVs;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float lifetime;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float fadeoutpercent;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Vector2 frames;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool randomRotation;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool deactivate;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float life;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float fadeout;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Color color;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float orgAlpha;

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1A2A954", Offset = "0x1A2A954", VA = "0x1A2A954")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1A2AA2C", Offset = "0x1A2AA2C", VA = "0x1A2AA2C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1A2AE24", Offset = "0x1A2AE24", VA = "0x1A2AE24")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5A056C", Offset = "0x5A056C")]
	private IEnumerator holeUpdate()
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1A2AEA8", Offset = "0x1A2AEA8", VA = "0x1A2AEA8")]
	public WFX_BulletHoleDecal()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x59B20C", Offset = "0x59B20C")]
public class WFX_LightFlicker : MonoBehaviour
{
	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59BFFC", Offset = "0x59BFFC")]
	private sealed class <Flicker>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int <>1__state;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private object <>2__current;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public WFX_LightFlicker <>4__this;

		[Token(Token = "0x17000314")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000897")]
			[Address(RVA = "0x239BF3C", Offset = "0x239BF3C", VA = "0x239BF3C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000315")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000899")]
			[Address(RVA = "0x239BF8C", Offset = "0x239BF8C", VA = "0x239BF8C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x239BD78", Offset = "0x239BD78", VA = "0x239BD78")]
		[DebuggerHidden]
		public <Flicker>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x239BD98", Offset = "0x239BD98", VA = "0x239BD98", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x239BD9C", Offset = "0x239BD9C", VA = "0x239BD9C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x239BF44", Offset = "0x239BF44", VA = "0x239BF44", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float time;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private float timer;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1A2AFE8", Offset = "0x1A2AFE8", VA = "0x1A2AFE8")]
	private void Start()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1A2B04C", Offset = "0x1A2B04C", VA = "0x1A2B04C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5A05D8", Offset = "0x5A05D8")]
	private IEnumerator Flicker()
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1A2B0D0", Offset = "0x1A2B0D0", VA = "0x1A2B0D0")]
	public WFX_LightFlicker()
	{
	}
}
[Token(Token = "0x2000006")]
public class CFX_SpawnSystem : MonoBehaviour
{
	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static CFX_SpawnSystem instance;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public GameObject[] objectsToPreload;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int[] objectsToPreloadTimes;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public bool hideObjectsInHierarchy;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
	public bool spawnAsChildren;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
	public bool onlyGetInactiveObjects;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
	public bool instantiateIfNeeded;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool allObjectsLoaded;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Dictionary<int, List<GameObject>> instantiatedObjects;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<int, int> poolCursors;

	[Token(Token = "0x17000001")]
	public static bool AllObjectsLoaded
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x13384AC", Offset = "0x13384AC", VA = "0x13384AC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1336F2C", Offset = "0x1336F2C", VA = "0x1336F2C")]
	public static GameObject GetNextObject(GameObject sourceObj, bool activateObject = true)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1337A00", Offset = "0x1337A00", VA = "0x1337A00")]
	public static void PreloadObject(GameObject sourceObj, int poolSize = 1)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1337ED4", Offset = "0x1337ED4", VA = "0x1337ED4")]
	public static void UnloadObjects(GameObject sourceObj)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1337A78", Offset = "0x1337A78", VA = "0x1337A78")]
	private void addObjectToPool(GameObject sourceObject, int number)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1337F44", Offset = "0x1337F44", VA = "0x1337F44")]
	private void removeObjectsFromPool(GameObject sourceObject)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x13377FC", Offset = "0x13377FC", VA = "0x13377FC")]
	private void increasePoolCursor(int uniqueId)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1338510", Offset = "0x1338510", VA = "0x1338510")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1338648", Offset = "0x1338648", VA = "0x1338648")]
	private void Start()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x13386F4", Offset = "0x13386F4", VA = "0x13386F4")]
	public CFX_SpawnSystem()
	{
	}
}
[Token(Token = "0x2000007")]
public class DirectionPointer : MonoBehaviour
{
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x133E844", Offset = "0x133E844", VA = "0x133E844")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x133E960", Offset = "0x133E960", VA = "0x133E960")]
	public DirectionPointer()
	{
	}
}
[Token(Token = "0x2000008")]
[ExecuteInEditMode]
public class Generator : MonoBehaviour
{
	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector2Int castRows;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float shaftSpacing;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool meshCast;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Mesh castMesh;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject lightShaftPrefab;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public string savePath;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool shaftSettings;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Material shaftMat;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x59C22C", Offset = "0x59C22C")]
	public Color pointer_shaftColor;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float pointer_shaftIntensity;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector2 pointer_noiseDirection;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float pointer_noiseScale;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float pointer_noiseUpdateSpeed;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float pointer_maxLength;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public LayerMask pointer_layerMask;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float pointer_shaftWidth;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector2 pointer_shaftWidthMinMax;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Texture pointer_shaftTexture;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Transform pointer_shaftDirection;

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x13469A8", Offset = "0x13469A8", VA = "0x13469A8")]
	public Generator()
	{
	}
}
[Serializable]
[Token(Token = "0x2000009")]
public class SaveVariables
{
	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float pointer_shaftIntensity;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float pointer_shaftColorR;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float pointer_shaftColorG;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float pointer_shaftColorB;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float pointer_shaftColorA;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float pointer_noiseDirectionX;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float pointer_noiseDirectionY;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float pointer_noiseScale;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float pointer_noiseUpdateSpeed;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float pointer_maxLength;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float pointer_shaftWidth;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float pointer_shaftWidthMinMaxX;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float pointer_shaftWidthMinMaxY;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float pointer_shaftDirectionX;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float pointer_shaftDirectionY;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float pointer_shaftDirectionZ;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int castRowsX;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int castRowsY;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float shaftSpacing;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool meshCast;

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x22D9120", Offset = "0x22D9120", VA = "0x22D9120")]
	public SaveVariables()
	{
	}
}
[Token(Token = "0x200000A")]
public class Shaft_Behavior : MonoBehaviour
{
	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Color shaftColor;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float shaftIntensity;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector2 noiseDirection;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float noiseScale;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float noiseUpdateSpeed;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float maxLength;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public LayerMask layerMask;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector2 shaftWidthMinMax;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float shaftAdjustY;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Texture shaftTexture;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform shaftDirection;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Material shaftMat;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float randomRotZ;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float randomWidth;

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x22D9A88", Offset = "0x22D9A88", VA = "0x22D9A88")]
	private void Start()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x22DA528", Offset = "0x22DA528", VA = "0x22DA528")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x22DA100", Offset = "0x22DA100", VA = "0x22DA100")]
	private void ShaftLength_and_Width()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x22DA348", Offset = "0x22DA348", VA = "0x22DA348")]
	private void Shaft_Color_Intensity_TexOffset()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x22D9F18", Offset = "0x22D9F18", VA = "0x22D9F18")]
	private void OrientShaft()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x22D9CB0", Offset = "0x22D9CB0", VA = "0x22D9CB0")]
	private void SyncVariables()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x22DA554", Offset = "0x22DA554", VA = "0x22DA554")]
	public Shaft_Behavior()
	{
	}
}
[Token(Token = "0x200000B")]
public static class MaterialModifier
{
	[Token(Token = "0x200008A")]
	public interface Interface
	{
		[Token(Token = "0x600089A")]
		void SetMaterialProp(int nameID, float value);

		[Token(Token = "0x600089B")]
		void SetMaterialProp(int nameID, Vector4 value);

		[Token(Token = "0x600089C")]
		void SetMaterialProp(int nameID, Color value);

		[Token(Token = "0x600089D")]
		void SetMaterialProp(int nameID, Matrix4x4 value);

		[Token(Token = "0x600089E")]
		void SetMaterialProp(int nameID, Texture value);
	}

	[Token(Token = "0x200008B")]
	public delegate void Callback(Interface owner);
}
[Token(Token = "0x200000C")]
public static class SRPHelper
{
	[Token(Token = "0x200008C")]
	public enum RenderPipeline
	{
		[Token(Token = "0x400051C")]
		BuiltIn,
		[Token(Token = "0x400051D")]
		URP,
		[Token(Token = "0x400051E")]
		LWRP,
		[Token(Token = "0x400051F")]
		HDRP
	}

	[Token(Token = "0x17000002")]
	public static RenderPipeline renderPipelineType
	{
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x22CE22C", Offset = "0x22CE22C", VA = "0x22CE22C")]
		get
		{
			return default(RenderPipeline);
		}
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x22CE3D4", Offset = "0x22CE3D4", VA = "0x22CE3D4")]
	public static bool IsUsingCustomRenderPipeline()
	{
		return default(bool);
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x22CE4FC", Offset = "0x22CE4FC", VA = "0x22CE4FC")]
	public static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x22CE58C", Offset = "0x22CE58C", VA = "0x22CE58C")]
	public static void UnregisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
	{
	}
}
namespace VLB
{
	[Token(Token = "0x200000D")]
	public static class BatchingHelper
	{
		[Token(Token = "0x4000054")]
		public const bool isGpuInstancingSupported = true;

		[Token(Token = "0x17000003")]
		public static bool forceEnableDepthBlend
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x133194C", Offset = "0x133194C", VA = "0x133194C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1331AF4", Offset = "0x1331AF4", VA = "0x1331AF4")]
		public static bool IsGpuInstancingEnabled(Material material)
		{
			return default(bool);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1331B1C", Offset = "0x1331B1C", VA = "0x1331B1C")]
		public static void SetMaterialProperties(Material material, bool enableGpuInstancing)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1331B4C", Offset = "0x1331B4C", VA = "0x1331B4C")]
		public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1331FEC", Offset = "0x1331FEC", VA = "0x1331FEC")]
		public static bool CanBeBatched(VolumetricLightBeam beam, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x13321DC", Offset = "0x13321DC", VA = "0x13321DC")]
		private static void AppendErrorMessage(ref string message, string toAppend)
		{
		}
	}
	[Token(Token = "0x200000E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59B288", Offset = "0x59B288")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x59B288", Offset = "0x59B288")]
	public class BeamGeometry : MonoBehaviour, MaterialModifier.Interface
	{
		[Token(Token = "0x200008D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C00C", Offset = "0x59C00C")]
		private sealed class <CoUpdateFadeOut>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public BeamGeometry <>4__this;

			[Token(Token = "0x17000316")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008A6")]
				[Address(RVA = "0x238D9C0", Offset = "0x238D9C0", VA = "0x238D9C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000317")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008A8")]
				[Address(RVA = "0x238DA10", Offset = "0x238DA10", VA = "0x238DA10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x238D8EC", Offset = "0x238D8EC", VA = "0x238D8EC")]
			[DebuggerHidden]
			public <CoUpdateFadeOut>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x238D90C", Offset = "0x238D90C", VA = "0x238D90C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x238D910", Offset = "0x238D910", VA = "0x238D910", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x238D9C8", Offset = "0x238D9C8", VA = "0x238D9C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Matrix4x4 m_ColorGradientMatrix;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MeshType m_CurrentMeshType;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Material m_CustomMaterial;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MaterialModifier.Callback m_MaterialModifierCallback;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Coroutine m_CoFadeOut;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C244", Offset = "0x59C244")]
		private MeshRenderer <meshRenderer>k__BackingField;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C254", Offset = "0x59C254")]
		private MeshFilter <meshFilter>k__BackingField;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C264", Offset = "0x59C264")]
		private Mesh <coneMesh>k__BackingField;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Camera m_CurrentCameraRenderingSRP;

		[Token(Token = "0x17000004")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x13322C0", Offset = "0x13322C0", VA = "0x13322C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0644", Offset = "0x5A0644")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x13322C8", Offset = "0x13322C8", VA = "0x13322C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0654", Offset = "0x5A0654")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x13322D0", Offset = "0x13322D0", VA = "0x13322D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0664", Offset = "0x5A0664")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x13322D8", Offset = "0x13322D8", VA = "0x13322D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0674", Offset = "0x5A0674")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public Mesh coneMesh
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x13322E0", Offset = "0x13322E0", VA = "0x13322E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0684", Offset = "0x5A0684")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x13322E8", Offset = "0x13322E8", VA = "0x13322E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0694", Offset = "0x5A0694")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public bool visible
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x13322F0", Offset = "0x13322F0", VA = "0x13322F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x1332318", Offset = "0x1332318", VA = "0x1332318")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public int sortingLayerID
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x1332348", Offset = "0x1332348", VA = "0x1332348")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x1332370", Offset = "0x1332370", VA = "0x1332370")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public int sortingOrder
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x13323A0", Offset = "0x13323A0", VA = "0x13323A0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x13323C8", Offset = "0x13323C8", VA = "0x13323C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public bool _INTERNAL_IsFadeOutCoroutineRunning
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x13323F8", Offset = "0x13323F8", VA = "0x13323F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public static bool isCustomRenderPipelineSupported
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x1332EE0", Offset = "0x1332EE0", VA = "0x1332EE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000C")]
		private bool shouldUseGPUInstancedMaterial
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x1332EE8", Offset = "0x1332EE8", VA = "0x1332EE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000D")]
		private bool isNoiseEnabled
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x13356F4", Offset = "0x13356F4", VA = "0x13356F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000E")]
		private bool isDepthBlendEnabled
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x13357B4", Offset = "0x13357B4", VA = "0x13357B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1332408", Offset = "0x1332408", VA = "0x1332408")]
		private float ComputeFadeOutFactor(Transform camTransform)
		{
			return default(float);
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1332590", Offset = "0x1332590", VA = "0x1332590")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5A06A4", Offset = "0x5A06A4")]
		private IEnumerator CoUpdateFadeOut()
		{
			return null;
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1332614", Offset = "0x1332614", VA = "0x1332614")]
		private void ComputeFadeOutFactor()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x13327A8", Offset = "0x13327A8", VA = "0x13327A8")]
		private void SetFadeOutFactorProp(float value)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x1332B88", Offset = "0x1332B88", VA = "0x1332B88")]
		public void RestartFadeOutCoroutine()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1332C8C", Offset = "0x1332C8C", VA = "0x1332C8C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x1332D50", Offset = "0x1332D50", VA = "0x1332D50")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x1332E1C", Offset = "0x1332E1C", VA = "0x1332E1C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1332F9C", Offset = "0x1332F9C", VA = "0x1332F9C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1333054", Offset = "0x1333054", VA = "0x1333054")]
		public void Initialize(VolumetricLightBeam master)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1333A04", Offset = "0x1333A04", VA = "0x1333A04")]
		public void RegenerateMesh()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x13355D0", Offset = "0x13355D0", VA = "0x13355D0")]
		private void ComputeLocalMatrix()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1333770", Offset = "0x1333770", VA = "0x1333770")]
		private bool ApplyMaterial()
		{
			return default(bool);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x133297C", Offset = "0x133297C", VA = "0x133297C", Slot = "4")]
		public void SetMaterialProp(int nameID, float value)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1335B40", Offset = "0x1335B40", VA = "0x1335B40", Slot = "5")]
		public void SetMaterialProp(int nameID, Vector4 value)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1335C94", Offset = "0x1335C94", VA = "0x1335C94", Slot = "6")]
		public void SetMaterialProp(int nameID, Color value)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1335DE8", Offset = "0x1335DE8", VA = "0x1335DE8", Slot = "7")]
		public void SetMaterialProp(int nameID, Matrix4x4 value)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1335FFC", Offset = "0x1335FFC", VA = "0x1335FFC", Slot = "8")]
		public void SetMaterialProp(int nameID, Texture value)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x133288C", Offset = "0x133288C", VA = "0x133288C")]
		private void MaterialChangeStart()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1332A98", Offset = "0x1332A98", VA = "0x1332A98")]
		private void MaterialChangeStop()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1336114", Offset = "0x1336114", VA = "0x1336114")]
		public void SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1334D7C", Offset = "0x1334D7C", VA = "0x1334D7C")]
		public void UpdateMaterialAndBounds()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1336238", Offset = "0x1336238", VA = "0x1336238")]
		private void UpdateMatricesPropertiesForGPUInstancingSRP()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x13364AC", Offset = "0x13364AC", VA = "0x13364AC")]
		private void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x13364B8", Offset = "0x13364B8", VA = "0x13364B8")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x13364F4", Offset = "0x13364F4", VA = "0x13364F4")]
		private void OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1336600", Offset = "0x1336600", VA = "0x1336600")]
		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1336B44", Offset = "0x1336B44", VA = "0x1336B44")]
		public BeamGeometry()
		{
		}
	}
	[Token(Token = "0x200000F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x59B2F8", Offset = "0x59B2F8")]
	public class Config : ScriptableObject
	{
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool geometryOverrideLayer;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int geometryLayerID;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public string geometryTag;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int geometryRenderQueue;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x59C274", Offset = "0x59C274")]
		[SerializeField]
		private RenderPipeline _RenderPipeline;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x59C2BC", Offset = "0x59C2BC")]
		[SerializeField]
		private RenderingMode _RenderingMode;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int sharedMeshSides;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int sharedMeshSegments;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C304", Offset = "0x59C304")]
		public float globalNoiseScale;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 globalNoiseVelocity;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public string fadeOutCameraTag;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HighlightNull]
		public TextAsset noise3DData;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int noise3DSize;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HighlightNull]
		public ParticleSystem dustParticlesPrefab;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Material _DummyMaterial;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Shader _BeamShader;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform m_CachedFadeOutCamera;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Config m_Instance;

		[Token(Token = "0x1700000F")]
		public RenderPipeline renderPipeline
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x133C5AC", Offset = "0x133C5AC", VA = "0x133C5AC")]
			get
			{
				return default(RenderPipeline);
			}
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x133C5B4", Offset = "0x133C5B4", VA = "0x133C5B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public RenderingMode renderingMode
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x133C644", Offset = "0x133C644", VA = "0x133C644")]
			get
			{
				return default(RenderingMode);
			}
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x133C64C", Offset = "0x133C64C", VA = "0x133C64C")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public RenderingMode actualRenderingMode
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x1331A98", Offset = "0x1331A98", VA = "0x1331A98")]
			get
			{
				return default(RenderingMode);
			}
		}

		[Token(Token = "0x17000012")]
		public bool useSinglePassShader
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x1333EB0", Offset = "0x1333EB0", VA = "0x1333EB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000013")]
		public Shader beamShader
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x133C708", Offset = "0x133C708", VA = "0x133C708")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		public Vector4 globalNoiseParam
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x133C710", Offset = "0x133C710", VA = "0x133C710")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x17000015")]
		public Transform fadeOutCameraTransform
		{
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x1332718", Offset = "0x1332718", VA = "0x1332718")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public static Config Instance
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x1331A28", Offset = "0x1331A28", VA = "0x1331A28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x133C6DC", Offset = "0x133C6DC", VA = "0x133C6DC")]
		public bool IsSRPBatcherSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x133C750", Offset = "0x133C750", VA = "0x133C750")]
		public void ForceUpdateFadeOutCamera()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x133C808", Offset = "0x133C808", VA = "0x133C808")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x5A0710", Offset = "0x5A0710")]
		private static void OnStartup()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x133C898", Offset = "0x133C898", VA = "0x133C898")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x133C988", Offset = "0x133C988", VA = "0x133C988")]
		public void ResetInternalData()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x133CB34", Offset = "0x133CB34", VA = "0x133CB34")]
		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x133CDB4", Offset = "0x133CDB4", VA = "0x133CDB4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x133CDC0", Offset = "0x133CDC0", VA = "0x133CDC0")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x133CDC4", Offset = "0x133CDC4", VA = "0x133CDC4")]
		private static Config GetInstance(bool assertIfNotFound)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x133CF6C", Offset = "0x133CF6C", VA = "0x133CF6C")]
		public Config()
		{
		}
	}
	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x59B32C", Offset = "0x59B32C")]
	public class ConfigOverride : Config
	{
		[Token(Token = "0x4000072")]
		public const string kAssetName = "VLBConfigOverride";

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x133D09C", Offset = "0x133D09C", VA = "0x133D09C")]
		public ConfigOverride()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public static class Consts
	{
		[Token(Token = "0x4000073")]
		private const string HelpUrlBase = "http://saladgamer.com/vlb-doc/";

		[Token(Token = "0x4000074")]
		public const string HelpUrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam/";

		[Token(Token = "0x4000075")]
		public const string HelpUrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/";

		[Token(Token = "0x4000076")]
		public const string HelpUrlDynamicOcclusionRaycasting = "http://saladgamer.com/vlb-doc/comp-dynocclusion-raycasting/";

		[Token(Token = "0x4000077")]
		public const string HelpUrlDynamicOcclusionDepthBuffer = "http://saladgamer.com/vlb-doc/comp-dynocclusion-depthbuffer/";

		[Token(Token = "0x4000078")]
		public const string HelpUrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/";

		[Token(Token = "0x4000079")]
		public const string HelpUrlConfig = "http://saladgamer.com/vlb-doc/config/";

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly bool ProceduralObjectsVisibleInEditor;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly Color FlatColor;

		[Token(Token = "0x400007C")]
		public const ColorMode ColorModeDefault = ColorMode.Flat;

		[Token(Token = "0x400007D")]
		public const float IntensityDefault = 1f;

		[Token(Token = "0x400007E")]
		public const float IntensityMin = 0f;

		[Token(Token = "0x400007F")]
		public const float IntensityMax = 8f;

		[Token(Token = "0x4000080")]
		public const float SpotAngleDefault = 35f;

		[Token(Token = "0x4000081")]
		public const float SpotAngleMin = 0.1f;

		[Token(Token = "0x4000082")]
		public const float SpotAngleMax = 179.9f;

		[Token(Token = "0x4000083")]
		public const float ConeRadiusStart = 0.1f;

		[Token(Token = "0x4000084")]
		public const MeshType GeomMeshType = MeshType.Shared;

		[Token(Token = "0x4000085")]
		public const int GeomSidesDefault = 18;

		[Token(Token = "0x4000086")]
		public const int GeomSidesMin = 3;

		[Token(Token = "0x4000087")]
		public const int GeomSidesMax = 256;

		[Token(Token = "0x4000088")]
		public const int GeomSegmentsDefault = 5;

		[Token(Token = "0x4000089")]
		public const int GeomSegmentsMin = 0;

		[Token(Token = "0x400008A")]
		public const int GeomSegmentsMax = 64;

		[Token(Token = "0x400008B")]
		public const bool GeomCap = false;

		[Token(Token = "0x400008C")]
		public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic;

		[Token(Token = "0x400008D")]
		public const float AttenuationCustomBlending = 0.5f;

		[Token(Token = "0x400008E")]
		public const float FallOffStart = 0f;

		[Token(Token = "0x400008F")]
		public const float FallOffEnd = 3f;

		[Token(Token = "0x4000090")]
		public const float FallOffDistancesMinThreshold = 0.01f;

		[Token(Token = "0x4000091")]
		public const float DepthBlendDistance = 2f;

		[Token(Token = "0x4000092")]
		public const float CameraClippingDistance = 0.5f;

		[Token(Token = "0x4000093")]
		public const float FresnelPowMaxValue = 10f;

		[Token(Token = "0x4000094")]
		public const float FresnelPow = 8f;

		[Token(Token = "0x4000095")]
		public const float GlareFrontal = 0.5f;

		[Token(Token = "0x4000096")]
		public const float GlareBehind = 0.5f;

		[Token(Token = "0x4000097")]
		public const NoiseMode NoiseModeDefault = NoiseMode.Disabled;

		[Token(Token = "0x4000098")]
		public const float NoiseIntensityMin = 0f;

		[Token(Token = "0x4000099")]
		public const float NoiseIntensityMax = 1f;

		[Token(Token = "0x400009A")]
		public const float NoiseIntensityDefault = 0.5f;

		[Token(Token = "0x400009B")]
		public const float NoiseScaleMin = 0.01f;

		[Token(Token = "0x400009C")]
		public const float NoiseScaleMax = 2f;

		[Token(Token = "0x400009D")]
		public const float NoiseScaleDefault = 0.5f;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static readonly Vector3 NoiseVelocityDefault;

		[Token(Token = "0x400009F")]
		public const BlendingMode BlendingModeDefault = BlendingMode.Additive;

		[Token(Token = "0x40000A0")]
		public const float FadeOutBeginDefault = -150f;

		[Token(Token = "0x40000A1")]
		public const float FadeOutEndDefault = -200f;

		[Token(Token = "0x40000A2")]
		public const Dimensions BeamDimensions = Dimensions.Dim3D;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly LayerMask DynOcclusionLayerMaskDefault;

		[Token(Token = "0x40000A4")]
		public const float DynOcclusionFadeDistanceToSurfaceDefault = 0.25f;

		[Token(Token = "0x40000A5")]
		public const DynamicOcclusionUpdateRate DynamicOcclusionUpdateRateDefault = DynamicOcclusionUpdateRate.EveryXFrames;

		[Token(Token = "0x40000A6")]
		public const int DynOcclusionWaitFramesCountDefault = 3;

		[Token(Token = "0x40000A7")]
		public const Dimensions DynOcclusionRaycastingDimensionsDefault = Dimensions.Dim3D;

		[Token(Token = "0x40000A8")]
		public const bool DynOcclusionRaycastingConsiderTriggersDefault = false;

		[Token(Token = "0x40000A9")]
		public const float DynOcclusionRaycastingMinOccluderAreaDefault = 0f;

		[Token(Token = "0x40000AA")]
		public const float DynOcclusionRaycastingMinSurfaceRatioDefault = 0.5f;

		[Token(Token = "0x40000AB")]
		public const float DynOcclusionRaycastingMinSurfaceRatioMin = 50f;

		[Token(Token = "0x40000AC")]
		public const float DynOcclusionRaycastingMinSurfaceRatioMax = 100f;

		[Token(Token = "0x40000AD")]
		public const float DynOcclusionRaycastingMaxSurfaceDotDefault = 0.25f;

		[Token(Token = "0x40000AE")]
		public const float DynOcclusionRaycastingMaxSurfaceAngleMin = 45f;

		[Token(Token = "0x40000AF")]
		public const float DynOcclusionRaycastingMaxSurfaceAngleMax = 90f;

		[Token(Token = "0x40000B0")]
		public const PlaneAlignment DynOcclusionRaycastingPlaneAlignmentDefault = PlaneAlignment.Surface;

		[Token(Token = "0x40000B1")]
		public const float DynOcclusionRaycastingPlaneOffsetDefault = 0.1f;

		[Token(Token = "0x40000B2")]
		public const int DynOcclusionDepthBufferDepthMapResolutionDefault = 32;

		[Token(Token = "0x40000B3")]
		public const bool DynOcclusionDepthBufferOcclusionCullingDefault = true;

		[Token(Token = "0x40000B4")]
		public const bool ConfigGeometryOverrideLayerDefault = true;

		[Token(Token = "0x40000B5")]
		public const int ConfigGeometryLayerIDDefault = 1;

		[Token(Token = "0x40000B6")]
		public const string ConfigGeometryTagDefault = "Untagged";

		[Token(Token = "0x40000B7")]
		public const string ConfigFadeOutCameraTagDefault = "MainCamera";

		[Token(Token = "0x40000B8")]
		public const RenderQueue ConfigGeometryRenderQueueDefault = RenderQueue.Transparent;

		[Token(Token = "0x40000B9")]
		public const RenderPipeline ConfigGeometryRenderPipelineDefault = RenderPipeline.BuiltIn;

		[Token(Token = "0x40000BA")]
		public const RenderingMode ConfigGeometryRenderingModeDefault = RenderingMode.SinglePass;

		[Token(Token = "0x40000BB")]
		public const int ConfigNoise3DSizeDefault = 64;

		[Token(Token = "0x40000BC")]
		public const int ConfigSharedMeshSides = 24;

		[Token(Token = "0x40000BD")]
		public const int ConfigSharedMeshSegments = 5;

		[Token(Token = "0x17000017")]
		public static HideFlags ProceduralObjectsHideFlags
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x1333518", Offset = "0x1333518", VA = "0x1333518")]
			get
			{
				return default(HideFlags);
			}
		}
	}
	[Token(Token = "0x2000012")]
	public static class DummyMaterial
	{
	}
	[Token(Token = "0x2000013")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59B360", Offset = "0x59B360")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x59B360", Offset = "0x59B360")]
	public abstract class DynamicOcclusionAbstractBase : MonoBehaviour
	{
		[Token(Token = "0x200008E")]
		protected enum ProcessOcclusionSource
		{
			[Token(Token = "0x4000524")]
			RenderLoop,
			[Token(Token = "0x4000525")]
			OnEnable,
			[Token(Token = "0x4000526")]
			EditorUpdate,
			[Token(Token = "0x4000527")]
			User
		}

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public DynamicOcclusionUpdateRate updateRate;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x59C370", Offset = "0x59C370")]
		public int waitXFrames;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool _INTERNAL_ApplyRandomFrameOffset;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TransformUtils.Packed m_TransformPacked;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int m_LastFrameRendered;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected VolumetricLightBeam m_Master;

		[Token(Token = "0x17000018")]
		public int _INTERNAL_LastFrameRendered
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x133EF08", Offset = "0x133EF08", VA = "0x133EF08")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000001")]
		public event Action onOcclusionProcessed
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x133EDB0", Offset = "0x133EDB0", VA = "0x133EDB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0720", Offset = "0x5A0720")]
			add
			{
			}
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x133EE5C", Offset = "0x133EE5C", VA = "0x133EE5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0730", Offset = "0x5A0730")]
			remove
			{
			}
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x133EB48", Offset = "0x133EB48", VA = "0x133EB48")]
		public void ProcessOcclusionManually()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x133EB50", Offset = "0x133EB50", VA = "0x133EB50")]
		protected void ProcessOcclusion(ProcessOcclusionSource source)
		{
		}

		[Token(Token = "0x6000079")]
		protected abstract string GetShaderKeyword();

		[Token(Token = "0x600007A")]
		protected abstract MaterialManager.DynamicOcclusion GetDynamicOcclusionMode();

		[Token(Token = "0x600007B")]
		protected abstract bool OnProcessOcclusion(ProcessOcclusionSource source);

		[Token(Token = "0x600007C")]
		protected abstract void OnModifyMaterialCallback(MaterialModifier.Interface owner);

		[Token(Token = "0x600007D")]
		protected abstract void OnEnablePostValidate();

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x133EF10", Offset = "0x133EF10", VA = "0x133EF10", Slot = "9")]
		protected virtual void OnValidateProperties()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x133EF38", Offset = "0x133EF38", VA = "0x133EF38", Slot = "10")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x133EFCC", Offset = "0x133EFCC", VA = "0x133EFCC", Slot = "11")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x133F040", Offset = "0x133F040", VA = "0x133F040", Slot = "12")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x133F200", Offset = "0x133F200", VA = "0x133F200", Slot = "13")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x133F2B0", Offset = "0x133F2B0", VA = "0x133F2B0")]
		private void OnWillCameraRender(Camera cam)
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x133EFFC", Offset = "0x133EFFC", VA = "0x133EFFC")]
		private void DisableOcclusion()
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x133F480", Offset = "0x133F480", VA = "0x133F480")]
		protected DynamicOcclusionAbstractBase()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x133F4F8", Offset = "0x133F4F8", VA = "0x133F4F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0740", Offset = "0x5A0740")]
		private void <OnEnable>b__22_0()
		{
		}
	}
	[Token(Token = "0x2000014")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x59B404", Offset = "0x59B404")]
	public class DynamicOcclusionDepthBuffer : DynamicOcclusionAbstractBase
	{
		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public LayerMask layerMask;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool useOcclusionCulling;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int depthMapResolution;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float fadeDistanceToSurface;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Camera m_DepthCamera;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_NeedToUpdateOcclusionNextFrame;

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x133F500", Offset = "0x133F500", VA = "0x133F500", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x133F54C", Offset = "0x133F54C", VA = "0x133F54C", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x133F554", Offset = "0x133F554", VA = "0x133F554")]
		private void ProcessOcclusionInternal()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x133F804", Offset = "0x133F804", VA = "0x133F804", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x133F844", Offset = "0x133F844", VA = "0x133F844")]
		private void Update()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x133F584", Offset = "0x133F584", VA = "0x133F584")]
		private void UpdateDepthCameraPropertiesAccordingToBeam()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x133F91C", Offset = "0x133F91C", VA = "0x133F91C")]
		public bool HasLayerMaskIssues()
		{
			return default(bool);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x133FA08", Offset = "0x133FA08", VA = "0x133FA08", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x133FA6C", Offset = "0x133FA6C", VA = "0x133FA6C")]
		private void InstantiateOrActivateDepthCamera()
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x133FE74", Offset = "0x133FE74", VA = "0x133FE74", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x133FE78", Offset = "0x133FE78", VA = "0x133FE78", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x133FF40", Offset = "0x133FF40", VA = "0x133FF40", Slot = "10")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x133FF44", Offset = "0x133FF44", VA = "0x133FF44", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x133FF60", Offset = "0x133FF60", VA = "0x133FF60")]
		private void DestroyDepthCamera()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1340140", Offset = "0x1340140", VA = "0x1340140", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1340330", Offset = "0x1340330", VA = "0x1340330")]
		public DynamicOcclusionDepthBuffer()
		{
		}
	}
	[Token(Token = "0x2000015")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x59B44C", Offset = "0x59B44C")]
	public class DynamicOcclusionRaycasting : DynamicOcclusionAbstractBase
	{
		[Token(Token = "0x200008F")]
		public class HitResult
		{
			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3 point;

			[Token(Token = "0x4000529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 normal;

			[Token(Token = "0x400052A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float distance;

			[Token(Token = "0x400052B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Collider2D collider2D;

			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Collider collider3D;

			[Token(Token = "0x17000318")]
			public bool hasCollider
			{
				[Token(Token = "0x60008AC")]
				[Address(RVA = "0x238E1CC", Offset = "0x238E1CC", VA = "0x238E1CC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000319")]
			public string name
			{
				[Token(Token = "0x60008AD")]
				[Address(RVA = "0x238E288", Offset = "0x238E288", VA = "0x238E288")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700031A")]
			public Bounds bounds
			{
				[Token(Token = "0x60008AE")]
				[Address(RVA = "0x238E38C", Offset = "0x238E38C", VA = "0x238E38C")]
				get
				{
					return default(Bounds);
				}
			}

			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x238DFA4", Offset = "0x238DFA4", VA = "0x238DFA4")]
			public HitResult(RaycastHit hit3D)
			{
			}

			[Token(Token = "0x60008AA")]
			[Address(RVA = "0x238E084", Offset = "0x238E084", VA = "0x238E084")]
			public HitResult(RaycastHit2D hit2D)
			{
			}

			[Token(Token = "0x60008AB")]
			[Address(RVA = "0x238E158", Offset = "0x238E158", VA = "0x238E158")]
			public HitResult()
			{
			}
		}

		[Token(Token = "0x2000090")]
		private enum Direction
		{
			[Token(Token = "0x400052E")]
			Up = 0,
			[Token(Token = "0x400052F")]
			Down = 1,
			[Token(Token = "0x4000530")]
			Left = 2,
			[Token(Token = "0x4000531")]
			Right = 3,
			[Token(Token = "0x4000532")]
			Max2D = 1,
			[Token(Token = "0x4000533")]
			Max3D = 3
		}

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Dimensions dimensions;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LayerMask layerMask;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool considerTriggers;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float minOccluderArea;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minSurfaceRatio;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxSurfaceDot;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public PlaneAlignment planeAlignment;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float planeOffset;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x59C3B4", Offset = "0x59C3B4")]
		public float fadeDistanceToSurface;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C3E8", Offset = "0x59C3E8")]
		private HitResult <currentHit>k__BackingField;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_RangeMultiplier;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C3F8", Offset = "0x59C3F8")]
		private Plane <planeEquationWS>k__BackingField;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private uint m_PrevNonSubHitDirectionId;

		[Token(Token = "0x17000019")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5A1D10", Offset = "0x5A1D10")]
		public float fadeDistanceToPlane
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x1340424", Offset = "0x1340424", VA = "0x1340424")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x134042C", Offset = "0x134042C", VA = "0x134042C")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public HitResult currentHit
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x1340598", Offset = "0x1340598", VA = "0x1340598")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0750", Offset = "0x5A0750")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x13405A0", Offset = "0x13405A0", VA = "0x13405A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0760", Offset = "0x5A0760")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public Plane planeEquationWS
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x13405FC", Offset = "0x13405FC", VA = "0x13405FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0770", Offset = "0x5A0770")]
			get
			{
				return default(Plane);
			}
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x134060C", Offset = "0x134060C", VA = "0x134060C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0780", Offset = "0x5A0780")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		private QueryTriggerInteraction queryTriggerInteraction
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x1340954", Offset = "0x1340954", VA = "0x1340954")]
			get
			{
				return default(QueryTriggerInteraction);
			}
		}

		[Token(Token = "0x1700001D")]
		private float raycastMaxDistance
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x1340968", Offset = "0x1340968", VA = "0x1340968")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1340434", Offset = "0x1340434", VA = "0x1340434")]
		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x13405A8", Offset = "0x13405A8", VA = "0x13405A8", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x13405F4", Offset = "0x13405F4", VA = "0x13405F4", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x134061C", Offset = "0x134061C", VA = "0x134061C", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1340674", Offset = "0x1340674", VA = "0x1340674", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1340684", Offset = "0x1340684", VA = "0x1340684", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x13407B8", Offset = "0x13407B8", VA = "0x13407B8")]
		private void Start()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1340894", Offset = "0x1340894", VA = "0x1340894")]
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x13409E0", Offset = "0x13409E0", VA = "0x13409E0")]
		private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1340A2C", Offset = "0x1340A2C", VA = "0x1340A2C")]
		private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1340E08", Offset = "0x1340E08", VA = "0x1340E08")]
		private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1341248", Offset = "0x1341248", VA = "0x1341248")]
		private uint GetDirectionCount()
		{
			return default(uint);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x134125C", Offset = "0x134125C", VA = "0x134125C")]
		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x134135C", Offset = "0x134135C", VA = "0x134135C")]
		private bool IsHitValid(HitResult hit)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x134140C", Offset = "0x134140C", VA = "0x134140C", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x13406B4", Offset = "0x13406B4", VA = "0x13406B4")]
		private void SetHit(HitResult hit)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1341958", Offset = "0x1341958", VA = "0x1341958", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x13417C0", Offset = "0x13417C0", VA = "0x13417C0")]
		private void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1341770", Offset = "0x1341770", VA = "0x1341770")]
		private void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1341BEC", Offset = "0x1341BEC", VA = "0x1341BEC")]
		private void SetPlaneWS(Plane planeWS)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1341BFC", Offset = "0x1341BFC", VA = "0x1341BFC")]
		public DynamicOcclusionRaycasting()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public enum ColorMode
	{
		[Token(Token = "0x40000D9")]
		Flat,
		[Token(Token = "0x40000DA")]
		Gradient
	}
	[Token(Token = "0x2000017")]
	public enum AttenuationEquation
	{
		[Token(Token = "0x40000DC")]
		Linear,
		[Token(Token = "0x40000DD")]
		Quadratic,
		[Token(Token = "0x40000DE")]
		Blend
	}
	[Token(Token = "0x2000018")]
	public enum BlendingMode
	{
		[Token(Token = "0x40000E0")]
		Additive,
		[Token(Token = "0x40000E1")]
		SoftAdditive,
		[Token(Token = "0x40000E2")]
		TraditionalTransparency
	}
	[Token(Token = "0x2000019")]
	public enum NoiseMode
	{
		[Token(Token = "0x40000E4")]
		Disabled,
		[Token(Token = "0x40000E5")]
		WorldSpace,
		[Token(Token = "0x40000E6")]
		LocalSpace
	}
	[Token(Token = "0x200001A")]
	public enum MeshType
	{
		[Token(Token = "0x40000E8")]
		Shared,
		[Token(Token = "0x40000E9")]
		Custom
	}
	[Token(Token = "0x200001B")]
	public enum RenderPipeline
	{
		[Token(Token = "0x40000EB")]
		BuiltIn,
		[Token(Token = "0x40000EC")]
		URP_or_LWRP,
		[Token(Token = "0x40000ED")]
		HDRP
	}
	[Token(Token = "0x200001C")]
	public enum RenderingMode
	{
		[Token(Token = "0x40000EF")]
		MultiPass,
		[Token(Token = "0x40000F0")]
		SinglePass,
		[Token(Token = "0x40000F1")]
		GPUInstancing,
		[Token(Token = "0x40000F2")]
		SRPBatcher
	}
	[Token(Token = "0x200001D")]
	public enum RenderQueue
	{
		[Token(Token = "0x40000F4")]
		Custom = 0,
		[Token(Token = "0x40000F5")]
		Background = 1000,
		[Token(Token = "0x40000F6")]
		Geometry = 2000,
		[Token(Token = "0x40000F7")]
		AlphaTest = 2450,
		[Token(Token = "0x40000F8")]
		GeometryLast = 2500,
		[Token(Token = "0x40000F9")]
		Transparent = 3000,
		[Token(Token = "0x40000FA")]
		Overlay = 4000
	}
	[Token(Token = "0x200001E")]
	public enum Dimensions
	{
		[Token(Token = "0x40000FC")]
		Dim3D,
		[Token(Token = "0x40000FD")]
		Dim2D
	}
	[Token(Token = "0x200001F")]
	public enum PlaneAlignment
	{
		[Token(Token = "0x40000FF")]
		Surface,
		[Token(Token = "0x4000100")]
		Beam
	}
	[Token(Token = "0x2000020")]
	[Flags]
	public enum DynamicOcclusionUpdateRate
	{
		[Token(Token = "0x4000102")]
		Never = 1,
		[Token(Token = "0x4000103")]
		OnEnable = 2,
		[Token(Token = "0x4000104")]
		OnBeamMove = 4,
		[Token(Token = "0x4000105")]
		EveryXFrames = 8,
		[Token(Token = "0x4000106")]
		OnBeamMoveAndEveryXFrames = 0xC
	}
	[Token(Token = "0x2000021")]
	public static class GlobalMesh
	{
		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh ms_Mesh;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static bool ms_DoubleSided;

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1334AA8", Offset = "0x1334AA8", VA = "0x1334AA8")]
		public static Mesh Get()
		{
			return null;
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1346A7C", Offset = "0x1346A7C", VA = "0x1346A7C")]
		public static void Destroy()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1348C00", Offset = "0x1348C00", VA = "0x1348C00")]
		public HighlightNullAttribute()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public static class MaterialManager
	{
		[Token(Token = "0x2000091")]
		public enum BlendingMode
		{
			[Token(Token = "0x4000535")]
			Additive,
			[Token(Token = "0x4000536")]
			SoftAdditive,
			[Token(Token = "0x4000537")]
			TraditionalTransparency,
			[Token(Token = "0x4000538")]
			Count
		}

		[Token(Token = "0x2000092")]
		public enum Noise3D
		{
			[Token(Token = "0x400053A")]
			Off,
			[Token(Token = "0x400053B")]
			On,
			[Token(Token = "0x400053C")]
			Count
		}

		[Token(Token = "0x2000093")]
		public enum DepthBlend
		{
			[Token(Token = "0x400053E")]
			Off,
			[Token(Token = "0x400053F")]
			On,
			[Token(Token = "0x4000540")]
			Count
		}

		[Token(Token = "0x2000094")]
		public enum ColorGradient
		{
			[Token(Token = "0x4000542")]
			Off,
			[Token(Token = "0x4000543")]
			MatrixLow,
			[Token(Token = "0x4000544")]
			MatrixHigh,
			[Token(Token = "0x4000545")]
			Count
		}

		[Token(Token = "0x2000095")]
		public enum DynamicOcclusion
		{
			[Token(Token = "0x4000547")]
			Off,
			[Token(Token = "0x4000548")]
			ClippingPlane,
			[Token(Token = "0x4000549")]
			DepthTexture,
			[Token(Token = "0x400054A")]
			Count
		}

		[Token(Token = "0x2000096")]
		public class StaticProperties
		{
			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public BlendingMode blendingMode;

			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Noise3D noise3D;

			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DepthBlend depthBlend;

			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public ColorGradient colorGradient;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DynamicOcclusion dynamicOcclusion;

			[Token(Token = "0x1700031B")]
			public int materialID
			{
				[Token(Token = "0x60008AF")]
				[Address(RVA = "0x238E75C", Offset = "0x238E75C", VA = "0x238E75C")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x238E784", Offset = "0x238E784", VA = "0x238E784")]
			public void ApplyToMaterial(Material mat)
			{
			}

			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x238EB20", Offset = "0x238EB20", VA = "0x238EB20")]
			public StaticProperties()
			{
			}
		}

		[Token(Token = "0x2000097")]
		private class MaterialsGroup
		{
			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Material[] materials;

			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x238E6A4", Offset = "0x238E6A4", VA = "0x238E6A4")]
			public MaterialsGroup()
			{
			}
		}

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static MaterialPropertyBlock materialPropertyBlock;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly BlendMode[] BlendingMode_SrcFactor;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly BlendMode[] BlendingMode_DstFactor;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly bool[] BlendingMode_AlphaAsBlack;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static int kStaticPropertiesCount;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static Hashtable ms_MaterialsGroup;

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1333598", Offset = "0x1333598", VA = "0x1333598")]
		public static Material NewMaterialTransient(bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1349790", Offset = "0x1349790", VA = "0x1349790")]
		public static Material NewMaterialPersistent(Shader shader, bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x13357FC", Offset = "0x13357FC", VA = "0x13357FC")]
		public static Material GetInstancedMaterial(uint groupID, StaticProperties staticProps)
		{
			return null;
		}
	}
	[Token(Token = "0x2000024")]
	public static class MeshGenerator
	{
		[Token(Token = "0x400010F")]
		private const float kMinTruncatedRadius = 0.001f;

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x134C9AC", Offset = "0x134C9AC", VA = "0x134C9AC")]
		private static float GetAngleOffset(int numSides)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x134C9C8", Offset = "0x134C9C8", VA = "0x134C9C8")]
		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x134CA34", Offset = "0x134CA34", VA = "0x134CA34")]
		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1333EC8", Offset = "0x1333EC8", VA = "0x1333EC8")]
		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x134CAA4", Offset = "0x134CAA4", VA = "0x134CAA4")]
		public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x134CAC0", Offset = "0x134CAC0", VA = "0x134CAC0")]
		public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x134CAE4", Offset = "0x134CAE4", VA = "0x134CAE4")]
		public static int GetSharedMeshVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x134CBB0", Offset = "0x134CBB0", VA = "0x134CBB0")]
		public static int GetSharedMeshIndicesCount()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000025")]
	public static class Noise3D
	{
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool ms_IsSupportedChecked;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool ms_IsSupported;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static Texture3D ms_NoiseTexture;

		[Token(Token = "0x4000113")]
		private const HideFlags kHideFlags = HideFlags.HideAndDontSave;

		[Token(Token = "0x4000114")]
		private const int kMinShaderLevel = 35;

		[Token(Token = "0x1700001E")]
		public static bool isSupported
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x1AA76D0", Offset = "0x1AA76D0", VA = "0x1AA76D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001F")]
		public static bool isProperlyLoaded
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x1AA7920", Offset = "0x1AA7920", VA = "0x1AA7920")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		public static string isNotSupportedString
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x1AA786C", Offset = "0x1AA786C", VA = "0x1AA786C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1AA79E4", Offset = "0x1AA79E4", VA = "0x1AA79E4")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x5A0790", Offset = "0x5A0790")]
		private static void OnStartUp()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1AA7A50", Offset = "0x1AA7A50", VA = "0x1AA7A50")]
		public static void LoadIfNeeded()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1AA7D6C", Offset = "0x1AA7D6C", VA = "0x1AA7D6C")]
		private static Texture3D LoadTexture3D(TextAsset textData, int size)
		{
			return null;
		}
	}
	[Token(Token = "0x2000026")]
	public class PolygonHelper : MonoBehaviour
	{
		[Token(Token = "0x2000098")]
		public struct Plane2D
		{
			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector2 normal;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float distance;

			[Token(Token = "0x60008B3")]
			[Address(RVA = "0x2391844", Offset = "0x2391844", VA = "0x2391844")]
			public float Distance(Vector2 point)
			{
				return default(float);
			}

			[Token(Token = "0x60008B4")]
			[Address(RVA = "0x239186C", Offset = "0x239186C", VA = "0x239186C")]
			public Vector2 ClosestPoint(Vector2 pt)
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008B5")]
			[Address(RVA = "0x23918A0", Offset = "0x23918A0", VA = "0x23918A0")]
			public Vector2 Intersect(Vector2 p1, Vector2 p2)
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x23919B8", Offset = "0x23919B8", VA = "0x23919B8")]
			public bool GetSide(Vector2 point)
			{
				return default(bool);
			}

			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x23919EC", Offset = "0x23919EC", VA = "0x23919EC")]
			public static Plane2D FromPoints(Vector3 p1, Vector3 p2)
			{
				return default(Plane2D);
			}

			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x2391A6C", Offset = "0x2391A6C", VA = "0x2391A6C")]
			public static Plane2D FromNormalAndPoint(Vector3 normalizedNormal, Vector3 p1)
			{
				return default(Plane2D);
			}

			[Token(Token = "0x60008B9")]
			[Address(RVA = "0x2391A90", Offset = "0x2391A90", VA = "0x2391A90")]
			public void Flip()
			{
			}

			[Token(Token = "0x60008BA")]
			[Address(RVA = "0x2391AB0", Offset = "0x2391AB0", VA = "0x2391AB0")]
			public Vector2[] CutConvex(Vector2[] poly)
			{
				return null;
			}

			[Token(Token = "0x60008BB")]
			[Address(RVA = "0x2391DF4", Offset = "0x2391DF4", VA = "0x2391DF4", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1AB420C", Offset = "0x1AB420C", VA = "0x1AB420C")]
		public PolygonHelper()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public static class ShaderProperties
	{
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int FadeOutFactor;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly int ClippingPlaneWS;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int ClippingPlaneProps;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly int ConeSlopeCosSin;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly int ConeRadius;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static readonly int ConeApexOffsetZ;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly int ColorFlat;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static readonly int AlphaInside;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly int AlphaOutside;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static readonly int AttenuationLerpLinearQuad;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly int DistanceFadeStart;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static readonly int DistanceFadeEnd;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly int DistanceCamClipping;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static readonly int FresnelPow;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly int GlareBehind;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static readonly int GlareFrontal;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly int DrawCap;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static readonly int DepthBlendDistance;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly int NoiseLocal;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public static readonly int NoiseParam;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static readonly int CameraParams;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public static readonly int CameraBufferSizeSRP;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static readonly int ColorGradientMatrix;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public static readonly int LocalToWorldMatrix;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static readonly int WorldToLocalMatrix;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public static readonly int BlendSrcFactor;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static readonly int BlendDstFactor;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public static readonly int DynamicOcclusionDepthTexture;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static readonly int DynamicOcclusionDepthProps;

		[Token(Token = "0x4000132")]
		public const string KeywordSRP = "VLB_SRP_API";
	}
	[Token(Token = "0x2000028")]
	public static class TransformUtils
	{
		[Token(Token = "0x2000099")]
		public class Packed
		{
			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3 position;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Quaternion rotation;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 lossyScale;

			[Token(Token = "0x60008BC")]
			[Address(RVA = "0x239ADD8", Offset = "0x239ADD8", VA = "0x239ADD8")]
			public Packed()
			{
			}
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1A19808", Offset = "0x1A19808", VA = "0x1A19808")]
		public static Packed GetWorldPacked(this Transform self)
		{
			return null;
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1A19924", Offset = "0x1A19924", VA = "0x1A19924")]
		public static bool IsSame(this Transform self, Packed packed)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000029")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x59B4B4", Offset = "0x59B4B4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x59B4B4", Offset = "0x59B4B4")]
	public class TriggerZone : MonoBehaviour
	{
		[Token(Token = "0x200009A")]
		private enum TriggerZoneUpdateRate
		{
			[Token(Token = "0x4000557")]
			OnEnable,
			[Token(Token = "0x4000558")]
			OnOcclusionChange
		}

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool setIsTrigger;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float rangeMultiplier;

		[Token(Token = "0x4000135")]
		private const int kMeshColliderNumSides = 8;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private VolumetricLightBeam m_Beam;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DynamicOcclusionRaycasting m_DynamicOcclusionRaycasting;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private PolygonCollider2D m_PolygonCollider2D;

		[Token(Token = "0x17000021")]
		private TriggerZoneUpdateRate updateRate
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x1A19CB4", Offset = "0x1A19CB4", VA = "0x1A19CB4")]
			get
			{
				return default(TriggerZoneUpdateRate);
			}
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1A19D58", Offset = "0x1A19D58", VA = "0x1A19D58")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1A1A784", Offset = "0x1A1A784", VA = "0x1A1A784")]
		private void OnOcclusionProcessed()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1A19F00", Offset = "0x1A19F00", VA = "0x1A19F00")]
		private void ComputeZone()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1A1A95C", Offset = "0x1A1A95C", VA = "0x1A1A95C")]
		public TriggerZone()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public static class Utils
	{
		[Token(Token = "0x200009B")]
		public enum FloatPackingPrecision
		{
			[Token(Token = "0x400055A")]
			High = 64,
			[Token(Token = "0x400055B")]
			Low = 8,
			[Token(Token = "0x400055C")]
			Undef = 0
		}

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static FloatPackingPrecision ms_FloatPackingPrecision;

		[Token(Token = "0x400013A")]
		private const int kFloatPackingHighMinShaderLevel = 35;

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1A25E2C", Offset = "0x1A25E2C", VA = "0x1A25E2C")]
		public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
		{
			return default(float);
		}

		[Token(Token = "0x60000D6")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1A25E6C", Offset = "0x1A25E6C", VA = "0x1A25E6C")]
		public static string GetPath(Transform current)
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		public static T NewWithComponent<T>(string name) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60000D9")]
		public static T GetOrAddComponent<T>(this GameObject self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60000DA")]
		public static T GetOrAddComponent<T>(this MonoBehaviour self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1A25FE8", Offset = "0x1A25FE8", VA = "0x1A25FE8")]
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1A260EC", Offset = "0x1A260EC", VA = "0x1A260EC")]
		public static Vector2 xy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1A260F4", Offset = "0x1A260F4", VA = "0x1A260F4")]
		public static Vector2 xz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1A260FC", Offset = "0x1A260FC", VA = "0x1A260FC")]
		public static Vector2 yz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1A26104", Offset = "0x1A26104", VA = "0x1A26104")]
		public static Vector2 yx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1A26110", Offset = "0x1A26110", VA = "0x1A26110")]
		public static Vector2 zx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1A2611C", Offset = "0x1A2611C", VA = "0x1A2611C")]
		public static Vector2 zy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1A26128", Offset = "0x1A26128", VA = "0x1A26128")]
		public static float GetVolumeCubic(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1A261A0", Offset = "0x1A261A0", VA = "0x1A261A0")]
		public static float GetMaxArea2D(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1A26278", Offset = "0x1A26278", VA = "0x1A26278")]
		public static Color Opaque(this Color self)
		{
			return default(Color);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1A262A8", Offset = "0x1A262A8", VA = "0x1A262A8")]
		public static void GizmosDrawPlane(Vector3 normal, Vector3 position, Color color, float size = 1f)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1A265D8", Offset = "0x1A265D8", VA = "0x1A265D8")]
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			return default(Plane);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1A1A8C0", Offset = "0x1A1A8C0", VA = "0x1A1A8C0")]
		public static Vector3 ClosestPointOnPlaneCustom(this Plane plane, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1A1A89C", Offset = "0x1A1A89C", VA = "0x1A1A89C")]
		public static bool IsAlmostZero(float f)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1A1A82C", Offset = "0x1A1A82C", VA = "0x1A1A82C")]
		public static bool IsValid(this Plane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1A266A8", Offset = "0x1A266A8", VA = "0x1A266A8")]
		public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1A266EC", Offset = "0x1A266EC", VA = "0x1A266EC")]
		public static void SetShaderKeywordEnabled(string name, bool enabled)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1A26704", Offset = "0x1A26704", VA = "0x1A26704")]
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1A269E0", Offset = "0x1A269E0", VA = "0x1A269E0")]
		public static Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			return null;
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1A26AFC", Offset = "0x1A26AFC", VA = "0x1A26AFC")]
		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1A2685C", Offset = "0x1A2685C", VA = "0x1A2685C")]
		public static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			return default(float);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1A26B74", Offset = "0x1A26B74", VA = "0x1A26B74")]
		public static FloatPackingPrecision GetFloatPackingPrecision()
		{
			return default(FloatPackingPrecision);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1A26C60", Offset = "0x1A26C60", VA = "0x1A26C60")]
		public static void MarkCurrentSceneDirty()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1A26C64", Offset = "0x1A26C64", VA = "0x1A26C64")]
		public static void MarkObjectDirty(UnityEngine.Object obj)
		{
		}
	}
	[Token(Token = "0x200002B")]
	public static class Version
	{
		[Token(Token = "0x400013B")]
		public const int Current = 1840;
	}
	[Token(Token = "0x200002C")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x59B568", Offset = "0x59B568")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x59B568", Offset = "0x59B568")]
	public class VolumetricDustParticles : MonoBehaviour
	{
		[Token(Token = "0x200009C")]
		public enum Direction
		{
			[Token(Token = "0x400055E")]
			Beam,
			[Token(Token = "0x400055F")]
			Random
		}

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C408", Offset = "0x59C408")]
		public float alpha;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C420", Offset = "0x59C420")]
		public float size;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Direction direction;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float speed;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float density;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C440", Offset = "0x59C440")]
		public float spawnMinDistance;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C458", Offset = "0x59C458")]
		public float spawnMaxDistance;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool cullingEnabled;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float cullingMaxDistance;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C470", Offset = "0x59C470")]
		private bool <isCulled>k__BackingField;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool isFeatureSupported;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private ParticleSystem m_Particles;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ParticleSystemRenderer m_Renderer;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool ms_NoMainCameraLogged;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static Camera ms_MainCamera;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x17000022")]
		public bool isCulled
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x1A26C6C", Offset = "0x1A26C6C", VA = "0x1A26C6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A08F0", Offset = "0x5A08F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x1A26C74", Offset = "0x1A26C74", VA = "0x1A26C74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0900", Offset = "0x5A0900")]
			private set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public bool particlesAreInstantiated
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x1A26C7C", Offset = "0x1A26C7C", VA = "0x1A26C7C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000024")]
		public int particlesCurrentCount
		{
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x1A26CF8", Offset = "0x1A26CF8", VA = "0x1A26CF8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000025")]
		public int particlesMaxCount
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x1A26DA0", Offset = "0x1A26DA0", VA = "0x1A26DA0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000026")]
		public Camera mainCamera
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x1A26E68", Offset = "0x1A26E68", VA = "0x1A26E68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x1A27178", Offset = "0x1A27178", VA = "0x1A27178")]
		private void Start()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1A271F8", Offset = "0x1A271F8", VA = "0x1A271F8")]
		private void InstantiateParticleSystem()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1A2765C", Offset = "0x1A2765C", VA = "0x1A2765C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1A274E8", Offset = "0x1A274E8", VA = "0x1A274E8")]
		private void SetActiveAndPlay()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1A27FA0", Offset = "0x1A27FA0", VA = "0x1A27FA0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1A28060", Offset = "0x1A28060", VA = "0x1A28060")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1A28144", Offset = "0x1A28144", VA = "0x1A28144")]
		private void Update()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1A27660", Offset = "0x1A27660", VA = "0x1A27660")]
		private void SetParticleProperties()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1A28170", Offset = "0x1A28170", VA = "0x1A28170")]
		private void UpdateCulling()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1A286CC", Offset = "0x1A286CC", VA = "0x1A286CC")]
		public VolumetricDustParticles()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[SelectionBase]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x59B61C", Offset = "0x59B61C")]
	public class VolumetricLightBeam : MonoBehaviour
	{
		[Token(Token = "0x200009D")]
		public delegate void OnWillCameraRenderCB(Camera cam);

		[Token(Token = "0x200009E")]
		public delegate void OnBeamGeometryInitialized();

		[Token(Token = "0x200009F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C01C", Offset = "0x59C01C")]
		private sealed class <CoPlaytimeUpdate>d__162 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public VolumetricLightBeam <>4__this;

			[Token(Token = "0x1700031C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008C8")]
				[Address(RVA = "0x239B460", Offset = "0x239B460", VA = "0x239B460", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700031D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008CA")]
				[Address(RVA = "0x239B4B0", Offset = "0x239B4B0", VA = "0x239B4B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x239B398", Offset = "0x239B398", VA = "0x239B398")]
			[DebuggerHidden]
			public <CoPlaytimeUpdate>d__162(int <>1__state)
			{
			}

			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x239B3B8", Offset = "0x239B3B8", VA = "0x239B3B8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x239B3BC", Offset = "0x239B3BC", VA = "0x239B3BC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x239B468", Offset = "0x239B468", VA = "0x239B468", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool colorFromLight;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ColorMode colorMode;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x59C480", Offset = "0x59C480")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x59C480", Offset = "0x59C480")]
		public Color color;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Gradient colorGradient;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool intensityFromLight;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool intensityModeAdvanced;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x59C4D0", Offset = "0x59C4D0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C4D0", Offset = "0x59C4D0")]
		public float intensityInside;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x59C520", Offset = "0x59C520")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x59C520", Offset = "0x59C520")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C520", Offset = "0x59C520")]
		public float intensityOutside;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public BlendingMode blendingMode;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x59C598", Offset = "0x59C598")]
		public bool spotAngleFromLight;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C5CC", Offset = "0x59C5CC")]
		public float spotAngle;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x59C5EC", Offset = "0x59C5EC")]
		public float coneRadiusStart;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public MeshType geomMeshType;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x59C620", Offset = "0x59C620")]
		public int geomCustomSides;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int geomCustomSegments;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool geomCap;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x59C654", Offset = "0x59C654")]
		public bool fallOffEndFromLight;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public AttenuationEquation attenuationEquation;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C688", Offset = "0x59C688")]
		public float attenuationCustomBlending;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x59C6A0", Offset = "0x59C6A0")]
		public float fallOffStart;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x59C6D4", Offset = "0x59C6D4")]
		public float fallOffEnd;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float depthBlendDistance;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float cameraClippingDistance;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C708", Offset = "0x59C708")]
		public float glareFrontal;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C720", Offset = "0x59C720")]
		public float glareBehind;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x59C738", Offset = "0x59C738")]
		public float fresnelPow;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public NoiseMode noiseMode;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x59C76C", Offset = "0x59C76C")]
		[SerializeField]
		private bool _DEPRECATED_NoiseEnabled;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C7B4", Offset = "0x59C7B4")]
		public float noiseIntensity;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool noiseScaleUseGlobal;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C7CC", Offset = "0x59C7CC")]
		public float noiseScaleLocal;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public bool noiseVelocityUseGlobal;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 noiseVelocityLocal;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Dimensions dimensions;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C7E8", Offset = "0x59C7E8")]
		private MaterialManager.DynamicOcclusion <_INTERNAL_DynamicOcclusionMode>k__BackingField;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool m_IsDynamicOcclusionEnabled;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private OnBeamGeometryInitialized m_OnBeamGeometryInitialized;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x59C818", Offset = "0x59C818")]
		[SerializeField]
		private bool _TrackChangesDuringPlaytime;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private int _SortingLayerID;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private int _SortingOrder;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x59C880", Offset = "0x59C880")]
		[SerializeField]
		private float _FadeOutBegin;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x59C8C8", Offset = "0x59C8C8")]
		[SerializeField]
		private float _FadeOutEnd;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C910", Offset = "0x59C910")]
		private uint <_INTERNAL_InstancedMaterialGroupID>k__BackingField;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private BeamGeometry m_BeamGeom;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Coroutine m_CoPlaytimeUpdate;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Light _CachedLight;

		[Token(Token = "0x17000027")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5A1D44", Offset = "0x5A1D44")]
		public float alphaInside
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x1A287AC", Offset = "0x1A287AC", VA = "0x1A287AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x1A287B4", Offset = "0x1A287B4", VA = "0x1A287B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5A1D78", Offset = "0x5A1D78")]
		public float alphaOutside
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x1A287BC", Offset = "0x1A287BC", VA = "0x1A287BC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x1A287C4", Offset = "0x1A287C4", VA = "0x1A287C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public float intensityGlobal
		{
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x1A287CC", Offset = "0x1A287CC", VA = "0x1A287CC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x1A287D4", Offset = "0x1A287D4", VA = "0x1A287D4")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public float coneAngle
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x1A284A0", Offset = "0x1A284A0", VA = "0x1A284A0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002B")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x1A1A788", Offset = "0x1A1A788", VA = "0x1A1A788")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002C")]
		public float coneVolume
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x1A287E0", Offset = "0x1A287E0", VA = "0x1A287E0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002D")]
		public float coneApexOffsetZ
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x1A28828", Offset = "0x1A28828", VA = "0x1A28828")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002E")]
		public int geomSides
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x1A28880", Offset = "0x1A28880", VA = "0x1A28880")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x1A28920", Offset = "0x1A28920", VA = "0x1A28920")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public int geomSegments
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x1A289BC", Offset = "0x1A289BC", VA = "0x1A289BC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x1A28A5C", Offset = "0x1A28A5C", VA = "0x1A28A5C")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5A1DAC", Offset = "0x5A1DAC")]
		public bool fadeEndFromLight
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x1A28AF8", Offset = "0x1A28AF8", VA = "0x1A28AF8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x1A28B00", Offset = "0x1A28B00", VA = "0x1A28B00")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public float attenuationLerpLinearQuad
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x1A28B08", Offset = "0x1A28B08", VA = "0x1A28B08")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000032")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5A1DE0", Offset = "0x5A1DE0")]
		public float fadeStart
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x1A28B34", Offset = "0x1A28B34", VA = "0x1A28B34")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x1A28B3C", Offset = "0x1A28B3C", VA = "0x1A28B3C")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5A1E14", Offset = "0x5A1E14")]
		public float fadeEnd
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x1A28B44", Offset = "0x1A28B44", VA = "0x1A28B44")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x1A28B4C", Offset = "0x1A28B4C", VA = "0x1A28B4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public bool isNoiseEnabled
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x1A28B54", Offset = "0x1A28B54", VA = "0x1A28B54")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000035")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5A1E48", Offset = "0x5A1E48")]
		public bool noiseEnabled
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x1A28B64", Offset = "0x1A28B64", VA = "0x1A28B64")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x1A28B74", Offset = "0x1A28B74", VA = "0x1A28B74")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public float fadeOutBegin
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x1A28B98", Offset = "0x1A28B98", VA = "0x1A28B98")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x1A28BA0", Offset = "0x1A28BA0", VA = "0x1A28BA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public float fadeOutEnd
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x1A28C20", Offset = "0x1A28C20", VA = "0x1A28C20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x1A28C28", Offset = "0x1A28C28", VA = "0x1A28C28")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public bool isFadeOutEnabled
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x1A284E4", Offset = "0x1A284E4", VA = "0x1A284E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000039")]
		public int sortingLayerID
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x1A28C34", Offset = "0x1A28C34", VA = "0x1A28C34")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x1A28C3C", Offset = "0x1A28C3C", VA = "0x1A28C3C")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public string sortingLayerName
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x1A28CEC", Offset = "0x1A28CEC", VA = "0x1A28CEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x1A28CF8", Offset = "0x1A28CF8", VA = "0x1A28CF8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public int sortingOrder
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x1A28D20", Offset = "0x1A28D20", VA = "0x1A28D20")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x1A28D28", Offset = "0x1A28D28", VA = "0x1A28D28")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public bool trackChangesDuringPlaytime
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x1A28DD8", Offset = "0x1A28DD8", VA = "0x1A28DD8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x1A28DE0", Offset = "0x1A28DE0", VA = "0x1A28DE0")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public bool isCurrentlyTrackingChanges
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x1A28E4C", Offset = "0x1A28E4C", VA = "0x1A28E4C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003E")]
		public bool hasGeometry
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x1A28514", Offset = "0x1A28514", VA = "0x1A28514")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003F")]
		public Bounds bounds
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x1A28594", Offset = "0x1A28594", VA = "0x1A28594")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x17000040")]
		public int blendingModeAsInt
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x1A28E5C", Offset = "0x1A28E5C", VA = "0x1A28E5C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000041")]
		public Quaternion beamInternalLocalRotation
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x1A275D0", Offset = "0x1A275D0", VA = "0x1A275D0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000042")]
		public Vector3 beamLocalForward
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x1A28F74", Offset = "0x1A28F74", VA = "0x1A28F74")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000043")]
		public Vector3 beamGlobalForward
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x1A28FC4", Offset = "0x1A28FC4", VA = "0x1A28FC4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000044")]
		public Vector3 beamGlobalUp
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x1A2905C", Offset = "0x1A2905C", VA = "0x1A2905C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000045")]
		public Vector3 beamGlobalRight
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x1A290F4", Offset = "0x1A290F4", VA = "0x1A290F4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000046")]
		public Vector3 lossyScale
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x1A2918C", Offset = "0x1A2918C", VA = "0x1A2918C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000047")]
		public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x1A29268", Offset = "0x1A29268", VA = "0x1A29268")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0910", Offset = "0x5A0910")]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x1A29270", Offset = "0x1A29270", VA = "0x1A29270")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0920", Offset = "0x5A0920")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public MaterialManager.DynamicOcclusion _INTERNAL_EnabledDynamicOcclusionMode
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x1A29278", Offset = "0x1A29278", VA = "0x1A29278")]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
		}

		[Token(Token = "0x17000049")]
		public uint _INTERNAL_InstancedMaterialGroupID
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x1A296B8", Offset = "0x1A296B8", VA = "0x1A296B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0950", Offset = "0x5A0950")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x1A296C0", Offset = "0x1A296C0", VA = "0x1A296C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0960", Offset = "0x5A0960")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public string meshStats
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x1A296C8", Offset = "0x1A296C8", VA = "0x1A296C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public int meshVerticesCount
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x1A298F8", Offset = "0x1A298F8", VA = "0x1A298F8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004C")]
		public int meshTrianglesCount
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x1A299F8", Offset = "0x1A299F8", VA = "0x1A299F8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004D")]
		private Light lightSpotAttached
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x1A29B20", Offset = "0x1A29B20", VA = "0x1A29B20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000002")]
		public event OnWillCameraRenderCB onWillCameraRenderThisBeam
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x1A29350", Offset = "0x1A29350", VA = "0x1A29350")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0930", Offset = "0x5A0930")]
			add
			{
			}
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x1A293FC", Offset = "0x1A293FC", VA = "0x1A293FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0940", Offset = "0x5A0940")]
			remove
			{
			}
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1A2928C", Offset = "0x1A2928C", VA = "0x1A2928C")]
		public void _INTERNAL_SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1A294A8", Offset = "0x1A294A8", VA = "0x1A294A8")]
		public void _INTERNAL_OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1A294BC", Offset = "0x1A294BC", VA = "0x1A294BC")]
		public void RegisterOnBeamGeometryInitializedCallback(OnBeamGeometryInitialized cb)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1A295B8", Offset = "0x1A295B8", VA = "0x1A295B8")]
		private void CallOnBeamGeometryInitializedCallback()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1A28BAC", Offset = "0x1A28BAC", VA = "0x1A28BAC")]
		private void SetFadeOutValue(ref float propToChange, float value)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1A295F4", Offset = "0x1A295F4", VA = "0x1A295F4")]
		private void OnFadeOutStateChanged()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1A29C4C", Offset = "0x1A29C4C", VA = "0x1A29C4C")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return default(float);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1A29CB4", Offset = "0x1A29CB4", VA = "0x1A29CB4")]
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return default(float);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1A29E6C", Offset = "0x1A29E6C", VA = "0x1A29E6C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5A0970", Offset = "0x5A0970")]
		public void Generate()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1A29E7C", Offset = "0x1A29E7C", VA = "0x1A29E7C", Slot = "4")]
		public virtual void GenerateGeometry()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1A2A15C", Offset = "0x1A2A15C", VA = "0x1A2A15C", Slot = "5")]
		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1A2A204", Offset = "0x1A2A204", VA = "0x1A2A204")]
		private void Start()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1A2A214", Offset = "0x1A2A214", VA = "0x1A2A214")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1A2A2C0", Offset = "0x1A2A2C0", VA = "0x1A2A2C0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1A28DE8", Offset = "0x1A28DE8", VA = "0x1A28DE8")]
		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1A2A378", Offset = "0x1A2A378", VA = "0x1A2A378")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5A09A4", Offset = "0x5A09A4")]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1A2A3FC", Offset = "0x1A2A3FC", VA = "0x1A2A3FC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1A2A400", Offset = "0x1A2A400", VA = "0x1A2A400")]
		private void DestroyBeam()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1A2A4E4", Offset = "0x1A2A4E4", VA = "0x1A2A4E4")]
		private void AssignPropertiesFromSpotLight(Light lightSpot)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1A2A658", Offset = "0x1A2A658", VA = "0x1A2A658")]
		private void ClampProperties()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1A2A134", Offset = "0x1A2A134", VA = "0x1A2A134")]
		private void ValidateProperties()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1A2A02C", Offset = "0x1A2A02C", VA = "0x1A2A02C")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1A2A7F0", Offset = "0x1A2A7F0", VA = "0x1A2A7F0")]
		public VolumetricLightBeam()
		{
		}
	}
}
namespace Rewired
{
	[Token(Token = "0x200002E")]
	public interface IGamepadTemplate : IControllerTemplate
	{
		[Token(Token = "0x1700004E")]
		IControllerTemplateButton actionBottomRow1
		{
			[Token(Token = "0x6000156")]
			get;
		}

		[Token(Token = "0x1700004F")]
		IControllerTemplateButton a
		{
			[Token(Token = "0x6000157")]
			get;
		}

		[Token(Token = "0x17000050")]
		IControllerTemplateButton actionBottomRow2
		{
			[Token(Token = "0x6000158")]
			get;
		}

		[Token(Token = "0x17000051")]
		IControllerTemplateButton b
		{
			[Token(Token = "0x6000159")]
			get;
		}

		[Token(Token = "0x17000052")]
		IControllerTemplateButton actionBottomRow3
		{
			[Token(Token = "0x600015A")]
			get;
		}

		[Token(Token = "0x17000053")]
		IControllerTemplateButton c
		{
			[Token(Token = "0x600015B")]
			get;
		}

		[Token(Token = "0x17000054")]
		IControllerTemplateButton actionTopRow1
		{
			[Token(Token = "0x600015C")]
			get;
		}

		[Token(Token = "0x17000055")]
		IControllerTemplateButton x
		{
			[Token(Token = "0x600015D")]
			get;
		}

		[Token(Token = "0x17000056")]
		IControllerTemplateButton actionTopRow2
		{
			[Token(Token = "0x600015E")]
			get;
		}

		[Token(Token = "0x17000057")]
		IControllerTemplateButton y
		{
			[Token(Token = "0x600015F")]
			get;
		}

		[Token(Token = "0x17000058")]
		IControllerTemplateButton actionTopRow3
		{
			[Token(Token = "0x6000160")]
			get;
		}

		[Token(Token = "0x17000059")]
		IControllerTemplateButton z
		{
			[Token(Token = "0x6000161")]
			get;
		}

		[Token(Token = "0x1700005A")]
		IControllerTemplateButton leftShoulder1
		{
			[Token(Token = "0x6000162")]
			get;
		}

		[Token(Token = "0x1700005B")]
		IControllerTemplateButton leftBumper
		{
			[Token(Token = "0x6000163")]
			get;
		}

		[Token(Token = "0x1700005C")]
		IControllerTemplateAxis leftShoulder2
		{
			[Token(Token = "0x6000164")]
			get;
		}

		[Token(Token = "0x1700005D")]
		IControllerTemplateAxis leftTrigger
		{
			[Token(Token = "0x6000165")]
			get;
		}

		[Token(Token = "0x1700005E")]
		IControllerTemplateButton rightShoulder1
		{
			[Token(Token = "0x6000166")]
			get;
		}

		[Token(Token = "0x1700005F")]
		IControllerTemplateButton rightBumper
		{
			[Token(Token = "0x6000167")]
			get;
		}

		[Token(Token = "0x17000060")]
		IControllerTemplateAxis rightShoulder2
		{
			[Token(Token = "0x6000168")]
			get;
		}

		[Token(Token = "0x17000061")]
		IControllerTemplateAxis rightTrigger
		{
			[Token(Token = "0x6000169")]
			get;
		}

		[Token(Token = "0x17000062")]
		IControllerTemplateButton center1
		{
			[Token(Token = "0x600016A")]
			get;
		}

		[Token(Token = "0x17000063")]
		IControllerTemplateButton back
		{
			[Token(Token = "0x600016B")]
			get;
		}

		[Token(Token = "0x17000064")]
		IControllerTemplateButton center2
		{
			[Token(Token = "0x600016C")]
			get;
		}

		[Token(Token = "0x17000065")]
		IControllerTemplateButton start
		{
			[Token(Token = "0x600016D")]
			get;
		}

		[Token(Token = "0x17000066")]
		IControllerTemplateButton center3
		{
			[Token(Token = "0x600016E")]
			get;
		}

		[Token(Token = "0x17000067")]
		IControllerTemplateButton guide
		{
			[Token(Token = "0x600016F")]
			get;
		}

		[Token(Token = "0x17000068")]
		IControllerTemplateThumbStick leftStick
		{
			[Token(Token = "0x6000170")]
			get;
		}

		[Token(Token = "0x17000069")]
		IControllerTemplateThumbStick rightStick
		{
			[Token(Token = "0x6000171")]
			get;
		}

		[Token(Token = "0x1700006A")]
		IControllerTemplateDPad dPad
		{
			[Token(Token = "0x6000172")]
			get;
		}
	}
	[Token(Token = "0x200002F")]
	public interface IRacingWheelTemplate : IControllerTemplate
	{
		[Token(Token = "0x1700006B")]
		IControllerTemplateAxis wheel
		{
			[Token(Token = "0x6000173")]
			get;
		}

		[Token(Token = "0x1700006C")]
		IControllerTemplateAxis accelerator
		{
			[Token(Token = "0x6000174")]
			get;
		}

		[Token(Token = "0x1700006D")]
		IControllerTemplateAxis brake
		{
			[Token(Token = "0x6000175")]
			get;
		}

		[Token(Token = "0x1700006E")]
		IControllerTemplateAxis clutch
		{
			[Token(Token = "0x6000176")]
			get;
		}

		[Token(Token = "0x1700006F")]
		IControllerTemplateButton shiftDown
		{
			[Token(Token = "0x6000177")]
			get;
		}

		[Token(Token = "0x17000070")]
		IControllerTemplateButton shiftUp
		{
			[Token(Token = "0x6000178")]
			get;
		}

		[Token(Token = "0x17000071")]
		IControllerTemplateButton wheelButton1
		{
			[Token(Token = "0x6000179")]
			get;
		}

		[Token(Token = "0x17000072")]
		IControllerTemplateButton wheelButton2
		{
			[Token(Token = "0x600017A")]
			get;
		}

		[Token(Token = "0x17000073")]
		IControllerTemplateButton wheelButton3
		{
			[Token(Token = "0x600017B")]
			get;
		}

		[Token(Token = "0x17000074")]
		IControllerTemplateButton wheelButton4
		{
			[Token(Token = "0x600017C")]
			get;
		}

		[Token(Token = "0x17000075")]
		IControllerTemplateButton wheelButton5
		{
			[Token(Token = "0x600017D")]
			get;
		}

		[Token(Token = "0x17000076")]
		IControllerTemplateButton wheelButton6
		{
			[Token(Token = "0x600017E")]
			get;
		}

		[Token(Token = "0x17000077")]
		IControllerTemplateButton wheelButton7
		{
			[Token(Token = "0x600017F")]
			get;
		}

		[Token(Token = "0x17000078")]
		IControllerTemplateButton wheelButton8
		{
			[Token(Token = "0x6000180")]
			get;
		}

		[Token(Token = "0x17000079")]
		IControllerTemplateButton wheelButton9
		{
			[Token(Token = "0x6000181")]
			get;
		}

		[Token(Token = "0x1700007A")]
		IControllerTemplateButton wheelButton10
		{
			[Token(Token = "0x6000182")]
			get;
		}

		[Token(Token = "0x1700007B")]
		IControllerTemplateButton consoleButton1
		{
			[Token(Token = "0x6000183")]
			get;
		}

		[Token(Token = "0x1700007C")]
		IControllerTemplateButton consoleButton2
		{
			[Token(Token = "0x6000184")]
			get;
		}

		[Token(Token = "0x1700007D")]
		IControllerTemplateButton consoleButton3
		{
			[Token(Token = "0x6000185")]
			get;
		}

		[Token(Token = "0x1700007E")]
		IControllerTemplateButton consoleButton4
		{
			[Token(Token = "0x6000186")]
			get;
		}

		[Token(Token = "0x1700007F")]
		IControllerTemplateButton consoleButton5
		{
			[Token(Token = "0x6000187")]
			get;
		}

		[Token(Token = "0x17000080")]
		IControllerTemplateButton consoleButton6
		{
			[Token(Token = "0x6000188")]
			get;
		}

		[Token(Token = "0x17000081")]
		IControllerTemplateButton consoleButton7
		{
			[Token(Token = "0x6000189")]
			get;
		}

		[Token(Token = "0x17000082")]
		IControllerTemplateButton consoleButton8
		{
			[Token(Token = "0x600018A")]
			get;
		}

		[Token(Token = "0x17000083")]
		IControllerTemplateButton consoleButton9
		{
			[Token(Token = "0x600018B")]
			get;
		}

		[Token(Token = "0x17000084")]
		IControllerTemplateButton consoleButton10
		{
			[Token(Token = "0x600018C")]
			get;
		}

		[Token(Token = "0x17000085")]
		IControllerTemplateButton shifter1
		{
			[Token(Token = "0x600018D")]
			get;
		}

		[Token(Token = "0x17000086")]
		IControllerTemplateButton shifter2
		{
			[Token(Token = "0x600018E")]
			get;
		}

		[Token(Token = "0x17000087")]
		IControllerTemplateButton shifter3
		{
			[Token(Token = "0x600018F")]
			get;
		}

		[Token(Token = "0x17000088")]
		IControllerTemplateButton shifter4
		{
			[Token(Token = "0x6000190")]
			get;
		}

		[Token(Token = "0x17000089")]
		IControllerTemplateButton shifter5
		{
			[Token(Token = "0x6000191")]
			get;
		}

		[Token(Token = "0x1700008A")]
		IControllerTemplateButton shifter6
		{
			[Token(Token = "0x6000192")]
			get;
		}

		[Token(Token = "0x1700008B")]
		IControllerTemplateButton shifter7
		{
			[Token(Token = "0x6000193")]
			get;
		}

		[Token(Token = "0x1700008C")]
		IControllerTemplateButton shifter8
		{
			[Token(Token = "0x6000194")]
			get;
		}

		[Token(Token = "0x1700008D")]
		IControllerTemplateButton shifter9
		{
			[Token(Token = "0x6000195")]
			get;
		}

		[Token(Token = "0x1700008E")]
		IControllerTemplateButton shifter10
		{
			[Token(Token = "0x6000196")]
			get;
		}

		[Token(Token = "0x1700008F")]
		IControllerTemplateButton reverseGear
		{
			[Token(Token = "0x6000197")]
			get;
		}

		[Token(Token = "0x17000090")]
		IControllerTemplateButton select
		{
			[Token(Token = "0x6000198")]
			get;
		}

		[Token(Token = "0x17000091")]
		IControllerTemplateButton start
		{
			[Token(Token = "0x6000199")]
			get;
		}

		[Token(Token = "0x17000092")]
		IControllerTemplateButton systemButton
		{
			[Token(Token = "0x600019A")]
			get;
		}

		[Token(Token = "0x17000093")]
		IControllerTemplateButton horn
		{
			[Token(Token = "0x600019B")]
			get;
		}

		[Token(Token = "0x17000094")]
		IControllerTemplateDPad dPad
		{
			[Token(Token = "0x600019C")]
			get;
		}
	}
	[Token(Token = "0x2000030")]
	public interface IHOTASTemplate : IControllerTemplate
	{
		[Token(Token = "0x17000095")]
		IControllerTemplateButton stickTrigger
		{
			[Token(Token = "0x600019D")]
			get;
		}

		[Token(Token = "0x17000096")]
		IControllerTemplateButton stickTriggerStage2
		{
			[Token(Token = "0x600019E")]
			get;
		}

		[Token(Token = "0x17000097")]
		IControllerTemplateButton stickPinkyButton
		{
			[Token(Token = "0x600019F")]
			get;
		}

		[Token(Token = "0x17000098")]
		IControllerTemplateButton stickPinkyTrigger
		{
			[Token(Token = "0x60001A0")]
			get;
		}

		[Token(Token = "0x17000099")]
		IControllerTemplateButton stickButton1
		{
			[Token(Token = "0x60001A1")]
			get;
		}

		[Token(Token = "0x1700009A")]
		IControllerTemplateButton stickButton2
		{
			[Token(Token = "0x60001A2")]
			get;
		}

		[Token(Token = "0x1700009B")]
		IControllerTemplateButton stickButton3
		{
			[Token(Token = "0x60001A3")]
			get;
		}

		[Token(Token = "0x1700009C")]
		IControllerTemplateButton stickButton4
		{
			[Token(Token = "0x60001A4")]
			get;
		}

		[Token(Token = "0x1700009D")]
		IControllerTemplateButton stickButton5
		{
			[Token(Token = "0x60001A5")]
			get;
		}

		[Token(Token = "0x1700009E")]
		IControllerTemplateButton stickButton6
		{
			[Token(Token = "0x60001A6")]
			get;
		}

		[Token(Token = "0x1700009F")]
		IControllerTemplateButton stickButton7
		{
			[Token(Token = "0x60001A7")]
			get;
		}

		[Token(Token = "0x170000A0")]
		IControllerTemplateButton stickButton8
		{
			[Token(Token = "0x60001A8")]
			get;
		}

		[Token(Token = "0x170000A1")]
		IControllerTemplateButton stickButton9
		{
			[Token(Token = "0x60001A9")]
			get;
		}

		[Token(Token = "0x170000A2")]
		IControllerTemplateButton stickButton10
		{
			[Token(Token = "0x60001AA")]
			get;
		}

		[Token(Token = "0x170000A3")]
		IControllerTemplateButton stickBaseButton1
		{
			[Token(Token = "0x60001AB")]
			get;
		}

		[Token(Token = "0x170000A4")]
		IControllerTemplateButton stickBaseButton2
		{
			[Token(Token = "0x60001AC")]
			get;
		}

		[Token(Token = "0x170000A5")]
		IControllerTemplateButton stickBaseButton3
		{
			[Token(Token = "0x60001AD")]
			get;
		}

		[Token(Token = "0x170000A6")]
		IControllerTemplateButton stickBaseButton4
		{
			[Token(Token = "0x60001AE")]
			get;
		}

		[Token(Token = "0x170000A7")]
		IControllerTemplateButton stickBaseButton5
		{
			[Token(Token = "0x60001AF")]
			get;
		}

		[Token(Token = "0x170000A8")]
		IControllerTemplateButton stickBaseButton6
		{
			[Token(Token = "0x60001B0")]
			get;
		}

		[Token(Token = "0x170000A9")]
		IControllerTemplateButton stickBaseButton7
		{
			[Token(Token = "0x60001B1")]
			get;
		}

		[Token(Token = "0x170000AA")]
		IControllerTemplateButton stickBaseButton8
		{
			[Token(Token = "0x60001B2")]
			get;
		}

		[Token(Token = "0x170000AB")]
		IControllerTemplateButton stickBaseButton9
		{
			[Token(Token = "0x60001B3")]
			get;
		}

		[Token(Token = "0x170000AC")]
		IControllerTemplateButton stickBaseButton10
		{
			[Token(Token = "0x60001B4")]
			get;
		}

		[Token(Token = "0x170000AD")]
		IControllerTemplateButton stickBaseButton11
		{
			[Token(Token = "0x60001B5")]
			get;
		}

		[Token(Token = "0x170000AE")]
		IControllerTemplateButton stickBaseButton12
		{
			[Token(Token = "0x60001B6")]
			get;
		}

		[Token(Token = "0x170000AF")]
		IControllerTemplateButton mode1
		{
			[Token(Token = "0x60001B7")]
			get;
		}

		[Token(Token = "0x170000B0")]
		IControllerTemplateButton mode2
		{
			[Token(Token = "0x60001B8")]
			get;
		}

		[Token(Token = "0x170000B1")]
		IControllerTemplateButton mode3
		{
			[Token(Token = "0x60001B9")]
			get;
		}

		[Token(Token = "0x170000B2")]
		IControllerTemplateButton throttleButton1
		{
			[Token(Token = "0x60001BA")]
			get;
		}

		[Token(Token = "0x170000B3")]
		IControllerTemplateButton throttleButton2
		{
			[Token(Token = "0x60001BB")]
			get;
		}

		[Token(Token = "0x170000B4")]
		IControllerTemplateButton throttleButton3
		{
			[Token(Token = "0x60001BC")]
			get;
		}

		[Token(Token = "0x170000B5")]
		IControllerTemplateButton throttleButton4
		{
			[Token(Token = "0x60001BD")]
			get;
		}

		[Token(Token = "0x170000B6")]
		IControllerTemplateButton throttleButton5
		{
			[Token(Token = "0x60001BE")]
			get;
		}

		[Token(Token = "0x170000B7")]
		IControllerTemplateButton throttleButton6
		{
			[Token(Token = "0x60001BF")]
			get;
		}

		[Token(Token = "0x170000B8")]
		IControllerTemplateButton throttleButton7
		{
			[Token(Token = "0x60001C0")]
			get;
		}

		[Token(Token = "0x170000B9")]
		IControllerTemplateButton throttleButton8
		{
			[Token(Token = "0x60001C1")]
			get;
		}

		[Token(Token = "0x170000BA")]
		IControllerTemplateButton throttleButton9
		{
			[Token(Token = "0x60001C2")]
			get;
		}

		[Token(Token = "0x170000BB")]
		IControllerTemplateButton throttleButton10
		{
			[Token(Token = "0x60001C3")]
			get;
		}

		[Token(Token = "0x170000BC")]
		IControllerTemplateButton throttleBaseButton1
		{
			[Token(Token = "0x60001C4")]
			get;
		}

		[Token(Token = "0x170000BD")]
		IControllerTemplateButton throttleBaseButton2
		{
			[Token(Token = "0x60001C5")]
			get;
		}

		[Token(Token = "0x170000BE")]
		IControllerTemplateButton throttleBaseButton3
		{
			[Token(Token = "0x60001C6")]
			get;
		}

		[Token(Token = "0x170000BF")]
		IControllerTemplateButton throttleBaseButton4
		{
			[Token(Token = "0x60001C7")]
			get;
		}

		[Token(Token = "0x170000C0")]
		IControllerTemplateButton throttleBaseButton5
		{
			[Token(Token = "0x60001C8")]
			get;
		}

		[Token(Token = "0x170000C1")]
		IControllerTemplateButton throttleBaseButton6
		{
			[Token(Token = "0x60001C9")]
			get;
		}

		[Token(Token = "0x170000C2")]
		IControllerTemplateButton throttleBaseButton7
		{
			[Token(Token = "0x60001CA")]
			get;
		}

		[Token(Token = "0x170000C3")]
		IControllerTemplateButton throttleBaseButton8
		{
			[Token(Token = "0x60001CB")]
			get;
		}

		[Token(Token = "0x170000C4")]
		IControllerTemplateButton throttleBaseButton9
		{
			[Token(Token = "0x60001CC")]
			get;
		}

		[Token(Token = "0x170000C5")]
		IControllerTemplateButton throttleBaseButton10
		{
			[Token(Token = "0x60001CD")]
			get;
		}

		[Token(Token = "0x170000C6")]
		IControllerTemplateButton throttleBaseButton11
		{
			[Token(Token = "0x60001CE")]
			get;
		}

		[Token(Token = "0x170000C7")]
		IControllerTemplateButton throttleBaseButton12
		{
			[Token(Token = "0x60001CF")]
			get;
		}

		[Token(Token = "0x170000C8")]
		IControllerTemplateButton throttleBaseButton13
		{
			[Token(Token = "0x60001D0")]
			get;
		}

		[Token(Token = "0x170000C9")]
		IControllerTemplateButton throttleBaseButton14
		{
			[Token(Token = "0x60001D1")]
			get;
		}

		[Token(Token = "0x170000CA")]
		IControllerTemplateButton throttleBaseButton15
		{
			[Token(Token = "0x60001D2")]
			get;
		}

		[Token(Token = "0x170000CB")]
		IControllerTemplateAxis throttleSlider1
		{
			[Token(Token = "0x60001D3")]
			get;
		}

		[Token(Token = "0x170000CC")]
		IControllerTemplateAxis throttleSlider2
		{
			[Token(Token = "0x60001D4")]
			get;
		}

		[Token(Token = "0x170000CD")]
		IControllerTemplateAxis throttleSlider3
		{
			[Token(Token = "0x60001D5")]
			get;
		}

		[Token(Token = "0x170000CE")]
		IControllerTemplateAxis throttleSlider4
		{
			[Token(Token = "0x60001D6")]
			get;
		}

		[Token(Token = "0x170000CF")]
		IControllerTemplateAxis throttleDial1
		{
			[Token(Token = "0x60001D7")]
			get;
		}

		[Token(Token = "0x170000D0")]
		IControllerTemplateAxis throttleDial2
		{
			[Token(Token = "0x60001D8")]
			get;
		}

		[Token(Token = "0x170000D1")]
		IControllerTemplateAxis throttleDial3
		{
			[Token(Token = "0x60001D9")]
			get;
		}

		[Token(Token = "0x170000D2")]
		IControllerTemplateAxis throttleDial4
		{
			[Token(Token = "0x60001DA")]
			get;
		}

		[Token(Token = "0x170000D3")]
		IControllerTemplateButton throttleWheel1Forward
		{
			[Token(Token = "0x60001DB")]
			get;
		}

		[Token(Token = "0x170000D4")]
		IControllerTemplateButton throttleWheel1Back
		{
			[Token(Token = "0x60001DC")]
			get;
		}

		[Token(Token = "0x170000D5")]
		IControllerTemplateButton throttleWheel1Press
		{
			[Token(Token = "0x60001DD")]
			get;
		}

		[Token(Token = "0x170000D6")]
		IControllerTemplateButton throttleWheel2Forward
		{
			[Token(Token = "0x60001DE")]
			get;
		}

		[Token(Token = "0x170000D7")]
		IControllerTemplateButton throttleWheel2Back
		{
			[Token(Token = "0x60001DF")]
			get;
		}

		[Token(Token = "0x170000D8")]
		IControllerTemplateButton throttleWheel2Press
		{
			[Token(Token = "0x60001E0")]
			get;
		}

		[Token(Token = "0x170000D9")]
		IControllerTemplateButton throttleWheel3Forward
		{
			[Token(Token = "0x60001E1")]
			get;
		}

		[Token(Token = "0x170000DA")]
		IControllerTemplateButton throttleWheel3Back
		{
			[Token(Token = "0x60001E2")]
			get;
		}

		[Token(Token = "0x170000DB")]
		IControllerTemplateButton throttleWheel3Press
		{
			[Token(Token = "0x60001E3")]
			get;
		}

		[Token(Token = "0x170000DC")]
		IControllerTemplateAxis leftPedal
		{
			[Token(Token = "0x60001E4")]
			get;
		}

		[Token(Token = "0x170000DD")]
		IControllerTemplateAxis rightPedal
		{
			[Token(Token = "0x60001E5")]
			get;
		}

		[Token(Token = "0x170000DE")]
		IControllerTemplateAxis slidePedals
		{
			[Token(Token = "0x60001E6")]
			get;
		}

		[Token(Token = "0x170000DF")]
		IControllerTemplateStick stick
		{
			[Token(Token = "0x60001E7")]
			get;
		}

		[Token(Token = "0x170000E0")]
		IControllerTemplateThumbStick stickMiniStick1
		{
			[Token(Token = "0x60001E8")]
			get;
		}

		[Token(Token = "0x170000E1")]
		IControllerTemplateThumbStick stickMiniStick2
		{
			[Token(Token = "0x60001E9")]
			get;
		}

		[Token(Token = "0x170000E2")]
		IControllerTemplateHat stickHat1
		{
			[Token(Token = "0x60001EA")]
			get;
		}

		[Token(Token = "0x170000E3")]
		IControllerTemplateHat stickHat2
		{
			[Token(Token = "0x60001EB")]
			get;
		}

		[Token(Token = "0x170000E4")]
		IControllerTemplateHat stickHat3
		{
			[Token(Token = "0x60001EC")]
			get;
		}

		[Token(Token = "0x170000E5")]
		IControllerTemplateHat stickHat4
		{
			[Token(Token = "0x60001ED")]
			get;
		}

		[Token(Token = "0x170000E6")]
		IControllerTemplateThrottle throttle1
		{
			[Token(Token = "0x60001EE")]
			get;
		}

		[Token(Token = "0x170000E7")]
		IControllerTemplateThrottle throttle2
		{
			[Token(Token = "0x60001EF")]
			get;
		}

		[Token(Token = "0x170000E8")]
		IControllerTemplateThumbStick throttleMiniStick
		{
			[Token(Token = "0x60001F0")]
			get;
		}

		[Token(Token = "0x170000E9")]
		IControllerTemplateHat throttleHat1
		{
			[Token(Token = "0x60001F1")]
			get;
		}

		[Token(Token = "0x170000EA")]
		IControllerTemplateHat throttleHat2
		{
			[Token(Token = "0x60001F2")]
			get;
		}

		[Token(Token = "0x170000EB")]
		IControllerTemplateHat throttleHat3
		{
			[Token(Token = "0x60001F3")]
			get;
		}

		[Token(Token = "0x170000EC")]
		IControllerTemplateHat throttleHat4
		{
			[Token(Token = "0x60001F4")]
			get;
		}
	}
	[Token(Token = "0x2000031")]
	public interface IFlightYokeTemplate : IControllerTemplate
	{
		[Token(Token = "0x170000ED")]
		IControllerTemplateButton leftPaddle
		{
			[Token(Token = "0x60001F5")]
			get;
		}

		[Token(Token = "0x170000EE")]
		IControllerTemplateButton rightPaddle
		{
			[Token(Token = "0x60001F6")]
			get;
		}

		[Token(Token = "0x170000EF")]
		IControllerTemplateButton leftGripButton1
		{
			[Token(Token = "0x60001F7")]
			get;
		}

		[Token(Token = "0x170000F0")]
		IControllerTemplateButton leftGripButton2
		{
			[Token(Token = "0x60001F8")]
			get;
		}

		[Token(Token = "0x170000F1")]
		IControllerTemplateButton leftGripButton3
		{
			[Token(Token = "0x60001F9")]
			get;
		}

		[Token(Token = "0x170000F2")]
		IControllerTemplateButton leftGripButton4
		{
			[Token(Token = "0x60001FA")]
			get;
		}

		[Token(Token = "0x170000F3")]
		IControllerTemplateButton leftGripButton5
		{
			[Token(Token = "0x60001FB")]
			get;
		}

		[Token(Token = "0x170000F4")]
		IControllerTemplateButton leftGripButton6
		{
			[Token(Token = "0x60001FC")]
			get;
		}

		[Token(Token = "0x170000F5")]
		IControllerTemplateButton rightGripButton1
		{
			[Token(Token = "0x60001FD")]
			get;
		}

		[Token(Token = "0x170000F6")]
		IControllerTemplateButton rightGripButton2
		{
			[Token(Token = "0x60001FE")]
			get;
		}

		[Token(Token = "0x170000F7")]
		IControllerTemplateButton rightGripButton3
		{
			[Token(Token = "0x60001FF")]
			get;
		}

		[Token(Token = "0x170000F8")]
		IControllerTemplateButton rightGripButton4
		{
			[Token(Token = "0x6000200")]
			get;
		}

		[Token(Token = "0x170000F9")]
		IControllerTemplateButton rightGripButton5
		{
			[Token(Token = "0x6000201")]
			get;
		}

		[Token(Token = "0x170000FA")]
		IControllerTemplateButton rightGripButton6
		{
			[Token(Token = "0x6000202")]
			get;
		}

		[Token(Token = "0x170000FB")]
		IControllerTemplateButton centerButton1
		{
			[Token(Token = "0x6000203")]
			get;
		}

		[Token(Token = "0x170000FC")]
		IControllerTemplateButton centerButton2
		{
			[Token(Token = "0x6000204")]
			get;
		}

		[Token(Token = "0x170000FD")]
		IControllerTemplateButton centerButton3
		{
			[Token(Token = "0x6000205")]
			get;
		}

		[Token(Token = "0x170000FE")]
		IControllerTemplateButton centerButton4
		{
			[Token(Token = "0x6000206")]
			get;
		}

		[Token(Token = "0x170000FF")]
		IControllerTemplateButton centerButton5
		{
			[Token(Token = "0x6000207")]
			get;
		}

		[Token(Token = "0x17000100")]
		IControllerTemplateButton centerButton6
		{
			[Token(Token = "0x6000208")]
			get;
		}

		[Token(Token = "0x17000101")]
		IControllerTemplateButton centerButton7
		{
			[Token(Token = "0x6000209")]
			get;
		}

		[Token(Token = "0x17000102")]
		IControllerTemplateButton centerButton8
		{
			[Token(Token = "0x600020A")]
			get;
		}

		[Token(Token = "0x17000103")]
		IControllerTemplateButton wheel1Up
		{
			[Token(Token = "0x600020B")]
			get;
		}

		[Token(Token = "0x17000104")]
		IControllerTemplateButton wheel1Down
		{
			[Token(Token = "0x600020C")]
			get;
		}

		[Token(Token = "0x17000105")]
		IControllerTemplateButton wheel1Press
		{
			[Token(Token = "0x600020D")]
			get;
		}

		[Token(Token = "0x17000106")]
		IControllerTemplateButton wheel2Up
		{
			[Token(Token = "0x600020E")]
			get;
		}

		[Token(Token = "0x17000107")]
		IControllerTemplateButton wheel2Down
		{
			[Token(Token = "0x600020F")]
			get;
		}

		[Token(Token = "0x17000108")]
		IControllerTemplateButton wheel2Press
		{
			[Token(Token = "0x6000210")]
			get;
		}

		[Token(Token = "0x17000109")]
		IControllerTemplateButton consoleButton1
		{
			[Token(Token = "0x6000211")]
			get;
		}

		[Token(Token = "0x1700010A")]
		IControllerTemplateButton consoleButton2
		{
			[Token(Token = "0x6000212")]
			get;
		}

		[Token(Token = "0x1700010B")]
		IControllerTemplateButton consoleButton3
		{
			[Token(Token = "0x6000213")]
			get;
		}

		[Token(Token = "0x1700010C")]
		IControllerTemplateButton consoleButton4
		{
			[Token(Token = "0x6000214")]
			get;
		}

		[Token(Token = "0x1700010D")]
		IControllerTemplateButton consoleButton5
		{
			[Token(Token = "0x6000215")]
			get;
		}

		[Token(Token = "0x1700010E")]
		IControllerTemplateButton consoleButton6
		{
			[Token(Token = "0x6000216")]
			get;
		}

		[Token(Token = "0x1700010F")]
		IControllerTemplateButton consoleButton7
		{
			[Token(Token = "0x6000217")]
			get;
		}

		[Token(Token = "0x17000110")]
		IControllerTemplateButton consoleButton8
		{
			[Token(Token = "0x6000218")]
			get;
		}

		[Token(Token = "0x17000111")]
		IControllerTemplateButton consoleButton9
		{
			[Token(Token = "0x6000219")]
			get;
		}

		[Token(Token = "0x17000112")]
		IControllerTemplateButton consoleButton10
		{
			[Token(Token = "0x600021A")]
			get;
		}

		[Token(Token = "0x17000113")]
		IControllerTemplateButton mode1
		{
			[Token(Token = "0x600021B")]
			get;
		}

		[Token(Token = "0x17000114")]
		IControllerTemplateButton mode2
		{
			[Token(Token = "0x600021C")]
			get;
		}

		[Token(Token = "0x17000115")]
		IControllerTemplateButton mode3
		{
			[Token(Token = "0x600021D")]
			get;
		}

		[Token(Token = "0x17000116")]
		IControllerTemplateYoke yoke
		{
			[Token(Token = "0x600021E")]
			get;
		}

		[Token(Token = "0x17000117")]
		IControllerTemplateThrottle lever1
		{
			[Token(Token = "0x600021F")]
			get;
		}

		[Token(Token = "0x17000118")]
		IControllerTemplateThrottle lever2
		{
			[Token(Token = "0x6000220")]
			get;
		}

		[Token(Token = "0x17000119")]
		IControllerTemplateThrottle lever3
		{
			[Token(Token = "0x6000221")]
			get;
		}

		[Token(Token = "0x1700011A")]
		IControllerTemplateThrottle lever4
		{
			[Token(Token = "0x6000222")]
			get;
		}

		[Token(Token = "0x1700011B")]
		IControllerTemplateThrottle lever5
		{
			[Token(Token = "0x6000223")]
			get;
		}

		[Token(Token = "0x1700011C")]
		IControllerTemplateHat leftGripHat
		{
			[Token(Token = "0x6000224")]
			get;
		}

		[Token(Token = "0x1700011D")]
		IControllerTemplateHat rightGripHat
		{
			[Token(Token = "0x6000225")]
			get;
		}
	}
	[Token(Token = "0x2000032")]
	public interface IFlightPedalsTemplate : IControllerTemplate
	{
		[Token(Token = "0x1700011E")]
		IControllerTemplateAxis leftPedal
		{
			[Token(Token = "0x6000226")]
			get;
		}

		[Token(Token = "0x1700011F")]
		IControllerTemplateAxis rightPedal
		{
			[Token(Token = "0x6000227")]
			get;
		}

		[Token(Token = "0x17000120")]
		IControllerTemplateAxis slide
		{
			[Token(Token = "0x6000228")]
			get;
		}
	}
	[Token(Token = "0x2000033")]
	public interface ISixDofControllerTemplate : IControllerTemplate
	{
		[Token(Token = "0x17000121")]
		IControllerTemplateAxis extraAxis1
		{
			[Token(Token = "0x6000229")]
			get;
		}

		[Token(Token = "0x17000122")]
		IControllerTemplateAxis extraAxis2
		{
			[Token(Token = "0x600022A")]
			get;
		}

		[Token(Token = "0x17000123")]
		IControllerTemplateAxis extraAxis3
		{
			[Token(Token = "0x600022B")]
			get;
		}

		[Token(Token = "0x17000124")]
		IControllerTemplateAxis extraAxis4
		{
			[Token(Token = "0x600022C")]
			get;
		}

		[Token(Token = "0x17000125")]
		IControllerTemplateButton button1
		{
			[Token(Token = "0x600022D")]
			get;
		}

		[Token(Token = "0x17000126")]
		IControllerTemplateButton button2
		{
			[Token(Token = "0x600022E")]
			get;
		}

		[Token(Token = "0x17000127")]
		IControllerTemplateButton button3
		{
			[Token(Token = "0x600022F")]
			get;
		}

		[Token(Token = "0x17000128")]
		IControllerTemplateButton button4
		{
			[Token(Token = "0x6000230")]
			get;
		}

		[Token(Token = "0x17000129")]
		IControllerTemplateButton button5
		{
			[Token(Token = "0x6000231")]
			get;
		}

		[Token(Token = "0x1700012A")]
		IControllerTemplateButton button6
		{
			[Token(Token = "0x6000232")]
			get;
		}

		[Token(Token = "0x1700012B")]
		IControllerTemplateButton button7
		{
			[Token(Token = "0x6000233")]
			get;
		}

		[Token(Token = "0x1700012C")]
		IControllerTemplateButton button8
		{
			[Token(Token = "0x6000234")]
			get;
		}

		[Token(Token = "0x1700012D")]
		IControllerTemplateButton button9
		{
			[Token(Token = "0x6000235")]
			get;
		}

		[Token(Token = "0x1700012E")]
		IControllerTemplateButton button10
		{
			[Token(Token = "0x6000236")]
			get;
		}

		[Token(Token = "0x1700012F")]
		IControllerTemplateButton button11
		{
			[Token(Token = "0x6000237")]
			get;
		}

		[Token(Token = "0x17000130")]
		IControllerTemplateButton button12
		{
			[Token(Token = "0x6000238")]
			get;
		}

		[Token(Token = "0x17000131")]
		IControllerTemplateButton button13
		{
			[Token(Token = "0x6000239")]
			get;
		}

		[Token(Token = "0x17000132")]
		IControllerTemplateButton button14
		{
			[Token(Token = "0x600023A")]
			get;
		}

		[Token(Token = "0x17000133")]
		IControllerTemplateButton button15
		{
			[Token(Token = "0x600023B")]
			get;
		}

		[Token(Token = "0x17000134")]
		IControllerTemplateButton button16
		{
			[Token(Token = "0x600023C")]
			get;
		}

		[Token(Token = "0x17000135")]
		IControllerTemplateButton button17
		{
			[Token(Token = "0x600023D")]
			get;
		}

		[Token(Token = "0x17000136")]
		IControllerTemplateButton button18
		{
			[Token(Token = "0x600023E")]
			get;
		}

		[Token(Token = "0x17000137")]
		IControllerTemplateButton button19
		{
			[Token(Token = "0x600023F")]
			get;
		}

		[Token(Token = "0x17000138")]
		IControllerTemplateButton button20
		{
			[Token(Token = "0x6000240")]
			get;
		}

		[Token(Token = "0x17000139")]
		IControllerTemplateButton button21
		{
			[Token(Token = "0x6000241")]
			get;
		}

		[Token(Token = "0x1700013A")]
		IControllerTemplateButton button22
		{
			[Token(Token = "0x6000242")]
			get;
		}

		[Token(Token = "0x1700013B")]
		IControllerTemplateButton button23
		{
			[Token(Token = "0x6000243")]
			get;
		}

		[Token(Token = "0x1700013C")]
		IControllerTemplateButton button24
		{
			[Token(Token = "0x6000244")]
			get;
		}

		[Token(Token = "0x1700013D")]
		IControllerTemplateButton button25
		{
			[Token(Token = "0x6000245")]
			get;
		}

		[Token(Token = "0x1700013E")]
		IControllerTemplateButton button26
		{
			[Token(Token = "0x6000246")]
			get;
		}

		[Token(Token = "0x1700013F")]
		IControllerTemplateButton button27
		{
			[Token(Token = "0x6000247")]
			get;
		}

		[Token(Token = "0x17000140")]
		IControllerTemplateButton button28
		{
			[Token(Token = "0x6000248")]
			get;
		}

		[Token(Token = "0x17000141")]
		IControllerTemplateButton button29
		{
			[Token(Token = "0x6000249")]
			get;
		}

		[Token(Token = "0x17000142")]
		IControllerTemplateButton button30
		{
			[Token(Token = "0x600024A")]
			get;
		}

		[Token(Token = "0x17000143")]
		IControllerTemplateButton button31
		{
			[Token(Token = "0x600024B")]
			get;
		}

		[Token(Token = "0x17000144")]
		IControllerTemplateButton button32
		{
			[Token(Token = "0x600024C")]
			get;
		}

		[Token(Token = "0x17000145")]
		IControllerTemplateHat hat1
		{
			[Token(Token = "0x600024D")]
			get;
		}

		[Token(Token = "0x17000146")]
		IControllerTemplateHat hat2
		{
			[Token(Token = "0x600024E")]
			get;
		}

		[Token(Token = "0x17000147")]
		IControllerTemplateThrottle throttle1
		{
			[Token(Token = "0x600024F")]
			get;
		}

		[Token(Token = "0x17000148")]
		IControllerTemplateThrottle throttle2
		{
			[Token(Token = "0x6000250")]
			get;
		}

		[Token(Token = "0x17000149")]
		IControllerTemplateStick6D stick
		{
			[Token(Token = "0x6000251")]
			get;
		}
	}
	[Token(Token = "0x2000034")]
	public sealed class GamepadTemplate : ControllerTemplate, IGamepadTemplate, IControllerTemplate
	{
		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Guid typeGuid;

		[Token(Token = "0x400017D")]
		public const int elementId_leftStickX = 0;

		[Token(Token = "0x400017E")]
		public const int elementId_leftStickY = 1;

		[Token(Token = "0x400017F")]
		public const int elementId_rightStickX = 2;

		[Token(Token = "0x4000180")]
		public const int elementId_rightStickY = 3;

		[Token(Token = "0x4000181")]
		public const int elementId_actionBottomRow1 = 4;

		[Token(Token = "0x4000182")]
		public const int elementId_a = 4;

		[Token(Token = "0x4000183")]
		public const int elementId_actionBottomRow2 = 5;

		[Token(Token = "0x4000184")]
		public const int elementId_b = 5;

		[Token(Token = "0x4000185")]
		public const int elementId_actionBottomRow3 = 6;

		[Token(Token = "0x4000186")]
		public const int elementId_c = 6;

		[Token(Token = "0x4000187")]
		public const int elementId_actionTopRow1 = 7;

		[Token(Token = "0x4000188")]
		public const int elementId_x = 7;

		[Token(Token = "0x4000189")]
		public const int elementId_actionTopRow2 = 8;

		[Token(Token = "0x400018A")]
		public const int elementId_y = 8;

		[Token(Token = "0x400018B")]
		public const int elementId_actionTopRow3 = 9;

		[Token(Token = "0x400018C")]
		public const int elementId_z = 9;

		[Token(Token = "0x400018D")]
		public const int elementId_leftShoulder1 = 10;

		[Token(Token = "0x400018E")]
		public const int elementId_leftBumper = 10;

		[Token(Token = "0x400018F")]
		public const int elementId_leftShoulder2 = 11;

		[Token(Token = "0x4000190")]
		public const int elementId_leftTrigger = 11;

		[Token(Token = "0x4000191")]
		public const int elementId_rightShoulder1 = 12;

		[Token(Token = "0x4000192")]
		public const int elementId_rightBumper = 12;

		[Token(Token = "0x4000193")]
		public const int elementId_rightShoulder2 = 13;

		[Token(Token = "0x4000194")]
		public const int elementId_rightTrigger = 13;

		[Token(Token = "0x4000195")]
		public const int elementId_center1 = 14;

		[Token(Token = "0x4000196")]
		public const int elementId_back = 14;

		[Token(Token = "0x4000197")]
		public const int elementId_center2 = 15;

		[Token(Token = "0x4000198")]
		public const int elementId_start = 15;

		[Token(Token = "0x4000199")]
		public const int elementId_center3 = 16;

		[Token(Token = "0x400019A")]
		public const int elementId_guide = 16;

		[Token(Token = "0x400019B")]
		public const int elementId_leftStickButton = 17;

		[Token(Token = "0x400019C")]
		public const int elementId_rightStickButton = 18;

		[Token(Token = "0x400019D")]
		public const int elementId_dPadUp = 19;

		[Token(Token = "0x400019E")]
		public const int elementId_dPadRight = 20;

		[Token(Token = "0x400019F")]
		public const int elementId_dPadDown = 21;

		[Token(Token = "0x40001A0")]
		public const int elementId_dPadLeft = 22;

		[Token(Token = "0x40001A1")]
		public const int elementId_leftStick = 23;

		[Token(Token = "0x40001A2")]
		public const int elementId_rightStick = 24;

		[Token(Token = "0x40001A3")]
		public const int elementId_dPad = 25;

		[Token(Token = "0x1700014A")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.actionBottomRow1
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x1345EA0", Offset = "0x1345EA0", VA = "0x1345EA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014B")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.a
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x1345EFC", Offset = "0x1345EFC", VA = "0x1345EFC", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014C")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.actionBottomRow2
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x1345F58", Offset = "0x1345F58", VA = "0x1345F58", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014D")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.b
		{
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x1345FB4", Offset = "0x1345FB4", VA = "0x1345FB4", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014E")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.actionBottomRow3
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x1346010", Offset = "0x1346010", VA = "0x1346010", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014F")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.c
		{
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x134606C", Offset = "0x134606C", VA = "0x134606C", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000150")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.actionTopRow1
		{
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x13460C8", Offset = "0x13460C8", VA = "0x13460C8", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000151")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.x
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x1346124", Offset = "0x1346124", VA = "0x1346124", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000152")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.actionTopRow2
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x1346180", Offset = "0x1346180", VA = "0x1346180", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000153")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.y
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x13461DC", Offset = "0x13461DC", VA = "0x13461DC", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000154")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.actionTopRow3
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x1346238", Offset = "0x1346238", VA = "0x1346238", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000155")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.z
		{
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x1346294", Offset = "0x1346294", VA = "0x1346294", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000156")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.leftShoulder1
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x13462F0", Offset = "0x13462F0", VA = "0x13462F0", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000157")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.leftBumper
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x134634C", Offset = "0x134634C", VA = "0x134634C", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000158")]
		private IControllerTemplateAxis Rewired.IGamepadTemplate.leftShoulder2
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x13463A8", Offset = "0x13463A8", VA = "0x13463A8", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000159")]
		private IControllerTemplateAxis Rewired.IGamepadTemplate.leftTrigger
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x1346404", Offset = "0x1346404", VA = "0x1346404", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015A")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.rightShoulder1
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x1346460", Offset = "0x1346460", VA = "0x1346460", Slot = "28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015B")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.rightBumper
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x13464BC", Offset = "0x13464BC", VA = "0x13464BC", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015C")]
		private IControllerTemplateAxis Rewired.IGamepadTemplate.rightShoulder2
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x1346518", Offset = "0x1346518", VA = "0x1346518", Slot = "30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015D")]
		private IControllerTemplateAxis Rewired.IGamepadTemplate.rightTrigger
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x1346574", Offset = "0x1346574", VA = "0x1346574", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015E")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.center1
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x13465D0", Offset = "0x13465D0", VA = "0x13465D0", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015F")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.back
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x134662C", Offset = "0x134662C", VA = "0x134662C", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000160")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.center2
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x1346688", Offset = "0x1346688", VA = "0x1346688", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000161")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.start
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x13466E4", Offset = "0x13466E4", VA = "0x13466E4", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000162")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.center3
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x1346740", Offset = "0x1346740", VA = "0x1346740", Slot = "36")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000163")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.guide
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x134679C", Offset = "0x134679C", VA = "0x134679C", Slot = "37")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000164")]
		private IControllerTemplateThumbStick Rewired.IGamepadTemplate.leftStick
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x13467F8", Offset = "0x13467F8", VA = "0x13467F8", Slot = "38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000165")]
		private IControllerTemplateThumbStick Rewired.IGamepadTemplate.rightStick
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x1346854", Offset = "0x1346854", VA = "0x1346854", Slot = "39")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000166")]
		private IControllerTemplateDPad Rewired.IGamepadTemplate.dPad
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x13468B0", Offset = "0x13468B0", VA = "0x13468B0", Slot = "40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x133D778", Offset = "0x133D778", VA = "0x133D778")]
		public GamepadTemplate(object payload)
		{
		}
	}
	[Token(Token = "0x2000035")]
	public sealed class RacingWheelTemplate : ControllerTemplate, IRacingWheelTemplate, IControllerTemplate
	{
		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Guid typeGuid;

		[Token(Token = "0x40001A5")]
		public const int elementId_wheel = 0;

		[Token(Token = "0x40001A6")]
		public const int elementId_accelerator = 1;

		[Token(Token = "0x40001A7")]
		public const int elementId_brake = 2;

		[Token(Token = "0x40001A8")]
		public const int elementId_clutch = 3;

		[Token(Token = "0x40001A9")]
		public const int elementId_shiftDown = 4;

		[Token(Token = "0x40001AA")]
		public const int elementId_shiftUp = 5;

		[Token(Token = "0x40001AB")]
		public const int elementId_wheelButton1 = 6;

		[Token(Token = "0x40001AC")]
		public const int elementId_wheelButton2 = 7;

		[Token(Token = "0x40001AD")]
		public const int elementId_wheelButton3 = 8;

		[Token(Token = "0x40001AE")]
		public const int elementId_wheelButton4 = 9;

		[Token(Token = "0x40001AF")]
		public const int elementId_wheelButton5 = 10;

		[Token(Token = "0x40001B0")]
		public const int elementId_wheelButton6 = 11;

		[Token(Token = "0x40001B1")]
		public const int elementId_wheelButton7 = 12;

		[Token(Token = "0x40001B2")]
		public const int elementId_wheelButton8 = 13;

		[Token(Token = "0x40001B3")]
		public const int elementId_wheelButton9 = 14;

		[Token(Token = "0x40001B4")]
		public const int elementId_wheelButton10 = 15;

		[Token(Token = "0x40001B5")]
		public const int elementId_consoleButton1 = 16;

		[Token(Token = "0x40001B6")]
		public const int elementId_consoleButton2 = 17;

		[Token(Token = "0x40001B7")]
		public const int elementId_consoleButton3 = 18;

		[Token(Token = "0x40001B8")]
		public const int elementId_consoleButton4 = 19;

		[Token(Token = "0x40001B9")]
		public const int elementId_consoleButton5 = 20;

		[Token(Token = "0x40001BA")]
		public const int elementId_consoleButton6 = 21;

		[Token(Token = "0x40001BB")]
		public const int elementId_consoleButton7 = 22;

		[Token(Token = "0x40001BC")]
		public const int elementId_consoleButton8 = 23;

		[Token(Token = "0x40001BD")]
		public const int elementId_consoleButton9 = 24;

		[Token(Token = "0x40001BE")]
		public const int elementId_consoleButton10 = 25;

		[Token(Token = "0x40001BF")]
		public const int elementId_shifter1 = 26;

		[Token(Token = "0x40001C0")]
		public const int elementId_shifter2 = 27;

		[Token(Token = "0x40001C1")]
		public const int elementId_shifter3 = 28;

		[Token(Token = "0x40001C2")]
		public const int elementId_shifter4 = 29;

		[Token(Token = "0x40001C3")]
		public const int elementId_shifter5 = 30;

		[Token(Token = "0x40001C4")]
		public const int elementId_shifter6 = 31;

		[Token(Token = "0x40001C5")]
		public const int elementId_shifter7 = 32;

		[Token(Token = "0x40001C6")]
		public const int elementId_shifter8 = 33;

		[Token(Token = "0x40001C7")]
		public const int elementId_shifter9 = 34;

		[Token(Token = "0x40001C8")]
		public const int elementId_shifter10 = 35;

		[Token(Token = "0x40001C9")]
		public const int elementId_reverseGear = 44;

		[Token(Token = "0x40001CA")]
		public const int elementId_select = 36;

		[Token(Token = "0x40001CB")]
		public const int elementId_start = 37;

		[Token(Token = "0x40001CC")]
		public const int elementId_systemButton = 38;

		[Token(Token = "0x40001CD")]
		public const int elementId_horn = 43;

		[Token(Token = "0x40001CE")]
		public const int elementId_dPadUp = 39;

		[Token(Token = "0x40001CF")]
		public const int elementId_dPadRight = 40;

		[Token(Token = "0x40001D0")]
		public const int elementId_dPadDown = 41;

		[Token(Token = "0x40001D1")]
		public const int elementId_dPadLeft = 42;

		[Token(Token = "0x40001D2")]
		public const int elementId_dPad = 45;

		[Token(Token = "0x17000167")]
		private IControllerTemplateAxis Rewired.IRacingWheelTemplate.wheel
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x1AB4214", Offset = "0x1AB4214", VA = "0x1AB4214", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000168")]
		private IControllerTemplateAxis Rewired.IRacingWheelTemplate.accelerator
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x1AB4270", Offset = "0x1AB4270", VA = "0x1AB4270", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000169")]
		private IControllerTemplateAxis Rewired.IRacingWheelTemplate.brake
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x1AB42CC", Offset = "0x1AB42CC", VA = "0x1AB42CC", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016A")]
		private IControllerTemplateAxis Rewired.IRacingWheelTemplate.clutch
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x1AB4328", Offset = "0x1AB4328", VA = "0x1AB4328", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016B")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.shiftDown
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x1AB4384", Offset = "0x1AB4384", VA = "0x1AB4384", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016C")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.shiftUp
		{
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x1AB43E0", Offset = "0x1AB43E0", VA = "0x1AB43E0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016D")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton1
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x1AB443C", Offset = "0x1AB443C", VA = "0x1AB443C", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016E")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton2
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x1AB4498", Offset = "0x1AB4498", VA = "0x1AB4498", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016F")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton3
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x1AB44F4", Offset = "0x1AB44F4", VA = "0x1AB44F4", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000170")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton4
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x1AB4550", Offset = "0x1AB4550", VA = "0x1AB4550", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000171")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton5
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x1AB45AC", Offset = "0x1AB45AC", VA = "0x1AB45AC", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000172")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton6
		{
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x1AB4608", Offset = "0x1AB4608", VA = "0x1AB4608", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000173")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton7
		{
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x1AB4664", Offset = "0x1AB4664", VA = "0x1AB4664", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000174")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton8
		{
			[Token(Token = "0x600027E")]
			[Address(RVA = "0x1AB46C0", Offset = "0x1AB46C0", VA = "0x1AB46C0", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000175")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton9
		{
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x1AB471C", Offset = "0x1AB471C", VA = "0x1AB471C", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000176")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton10
		{
			[Token(Token = "0x6000280")]
			[Address(RVA = "0x1AB4778", Offset = "0x1AB4778", VA = "0x1AB4778", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000177")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton1
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0x1AB47D4", Offset = "0x1AB47D4", VA = "0x1AB47D4", Slot = "28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000178")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton2
		{
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x1AB4830", Offset = "0x1AB4830", VA = "0x1AB4830", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000179")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton3
		{
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x1AB488C", Offset = "0x1AB488C", VA = "0x1AB488C", Slot = "30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017A")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton4
		{
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x1AB48E8", Offset = "0x1AB48E8", VA = "0x1AB48E8", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017B")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton5
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x1AB4944", Offset = "0x1AB4944", VA = "0x1AB4944", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017C")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton6
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x1AB49A0", Offset = "0x1AB49A0", VA = "0x1AB49A0", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017D")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton7
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x1AB49FC", Offset = "0x1AB49FC", VA = "0x1AB49FC", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017E")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton8
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x1AB4A58", Offset = "0x1AB4A58", VA = "0x1AB4A58", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017F")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton9
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x1AB4AB4", Offset = "0x1AB4AB4", VA = "0x1AB4AB4", Slot = "36")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000180")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton10
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x1AB4B10", Offset = "0x1AB4B10", VA = "0x1AB4B10", Slot = "37")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000181")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter1
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x1AB4B6C", Offset = "0x1AB4B6C", VA = "0x1AB4B6C", Slot = "38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000182")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter2
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x1AB4BC8", Offset = "0x1AB4BC8", VA = "0x1AB4BC8", Slot = "39")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000183")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter3
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x1AB4C24", Offset = "0x1AB4C24", VA = "0x1AB4C24", Slot = "40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000184")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter4
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x1AB4C80", Offset = "0x1AB4C80", VA = "0x1AB4C80", Slot = "41")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000185")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter5
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x1AB4CDC", Offset = "0x1AB4CDC", VA = "0x1AB4CDC", Slot = "42")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000186")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter6
		{
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x1AB4D38", Offset = "0x1AB4D38", VA = "0x1AB4D38", Slot = "43")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000187")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter7
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x1AB4D94", Offset = "0x1AB4D94", VA = "0x1AB4D94", Slot = "44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000188")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter8
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x1AB4DF0", Offset = "0x1AB4DF0", VA = "0x1AB4DF0", Slot = "45")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000189")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter9
		{
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x1AB4E4C", Offset = "0x1AB4E4C", VA = "0x1AB4E4C", Slot = "46")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018A")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter10
		{
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x1AB4EA8", Offset = "0x1AB4EA8", VA = "0x1AB4EA8", Slot = "47")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018B")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.reverseGear
		{
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x1AB4F04", Offset = "0x1AB4F04", VA = "0x1AB4F04", Slot = "48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018C")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.select
		{
			[Token(Token = "0x6000296")]
			[Address(RVA = "0x1AB4F60", Offset = "0x1AB4F60", VA = "0x1AB4F60", Slot = "49")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018D")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.start
		{
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x1AB4FBC", Offset = "0x1AB4FBC", VA = "0x1AB4FBC", Slot = "50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018E")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.systemButton
		{
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x1AB5018", Offset = "0x1AB5018", VA = "0x1AB5018", Slot = "51")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018F")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.horn
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x1AB5074", Offset = "0x1AB5074", VA = "0x1AB5074", Slot = "52")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000190")]
		private IControllerTemplateDPad Rewired.IRacingWheelTemplate.dPad
		{
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x1AB50D0", Offset = "0x1AB50D0", VA = "0x1AB50D0", Slot = "53")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x1AB512C", Offset = "0x1AB512C", VA = "0x1AB512C")]
		public RacingWheelTemplate(object payload)
		{
		}
	}
	[Token(Token = "0x2000036")]
	public sealed class HOTASTemplate : ControllerTemplate, IHOTASTemplate, IControllerTemplate
	{
		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Guid typeGuid;

		[Token(Token = "0x40001D4")]
		public const int elementId_stickX = 0;

		[Token(Token = "0x40001D5")]
		public const int elementId_stickY = 1;

		[Token(Token = "0x40001D6")]
		public const int elementId_stickRotate = 2;

		[Token(Token = "0x40001D7")]
		public const int elementId_stickMiniStick1X = 78;

		[Token(Token = "0x40001D8")]
		public const int elementId_stickMiniStick1Y = 79;

		[Token(Token = "0x40001D9")]
		public const int elementId_stickMiniStick1Press = 80;

		[Token(Token = "0x40001DA")]
		public const int elementId_stickMiniStick2X = 81;

		[Token(Token = "0x40001DB")]
		public const int elementId_stickMiniStick2Y = 82;

		[Token(Token = "0x40001DC")]
		public const int elementId_stickMiniStick2Press = 83;

		[Token(Token = "0x40001DD")]
		public const int elementId_stickTrigger = 3;

		[Token(Token = "0x40001DE")]
		public const int elementId_stickTriggerStage2 = 4;

		[Token(Token = "0x40001DF")]
		public const int elementId_stickPinkyButton = 5;

		[Token(Token = "0x40001E0")]
		public const int elementId_stickPinkyTrigger = 154;

		[Token(Token = "0x40001E1")]
		public const int elementId_stickButton1 = 6;

		[Token(Token = "0x40001E2")]
		public const int elementId_stickButton2 = 7;

		[Token(Token = "0x40001E3")]
		public const int elementId_stickButton3 = 8;

		[Token(Token = "0x40001E4")]
		public const int elementId_stickButton4 = 9;

		[Token(Token = "0x40001E5")]
		public const int elementId_stickButton5 = 10;

		[Token(Token = "0x40001E6")]
		public const int elementId_stickButton6 = 11;

		[Token(Token = "0x40001E7")]
		public const int elementId_stickButton7 = 12;

		[Token(Token = "0x40001E8")]
		public const int elementId_stickButton8 = 13;

		[Token(Token = "0x40001E9")]
		public const int elementId_stickButton9 = 14;

		[Token(Token = "0x40001EA")]
		public const int elementId_stickButton10 = 15;

		[Token(Token = "0x40001EB")]
		public const int elementId_stickBaseButton1 = 18;

		[Token(Token = "0x40001EC")]
		public const int elementId_stickBaseButton2 = 19;

		[Token(Token = "0x40001ED")]
		public const int elementId_stickBaseButton3 = 20;

		[Token(Token = "0x40001EE")]
		public const int elementId_stickBaseButton4 = 21;

		[Token(Token = "0x40001EF")]
		public const int elementId_stickBaseButton5 = 22;

		[Token(Token = "0x40001F0")]
		public const int elementId_stickBaseButton6 = 23;

		[Token(Token = "0x40001F1")]
		public const int elementId_stickBaseButton7 = 24;

		[Token(Token = "0x40001F2")]
		public const int elementId_stickBaseButton8 = 25;

		[Token(Token = "0x40001F3")]
		public const int elementId_stickBaseButton9 = 26;

		[Token(Token = "0x40001F4")]
		public const int elementId_stickBaseButton10 = 27;

		[Token(Token = "0x40001F5")]
		public const int elementId_stickBaseButton11 = 161;

		[Token(Token = "0x40001F6")]
		public const int elementId_stickBaseButton12 = 162;

		[Token(Token = "0x40001F7")]
		public const int elementId_stickHat1Up = 28;

		[Token(Token = "0x40001F8")]
		public const int elementId_stickHat1UpRight = 29;

		[Token(Token = "0x40001F9")]
		public const int elementId_stickHat1Right = 30;

		[Token(Token = "0x40001FA")]
		public const int elementId_stickHat1DownRight = 31;

		[Token(Token = "0x40001FB")]
		public const int elementId_stickHat1Down = 32;

		[Token(Token = "0x40001FC")]
		public const int elementId_stickHat1DownLeft = 33;

		[Token(Token = "0x40001FD")]
		public const int elementId_stickHat1Left = 34;

		[Token(Token = "0x40001FE")]
		public const int elementId_stickHat1Up_Left = 35;

		[Token(Token = "0x40001FF")]
		public const int elementId_stickHat2Up = 36;

		[Token(Token = "0x4000200")]
		public const int elementId_stickHat2Up_right = 37;

		[Token(Token = "0x4000201")]
		public const int elementId_stickHat2Right = 38;

		[Token(Token = "0x4000202")]
		public const int elementId_stickHat2Down_Right = 39;

		[Token(Token = "0x4000203")]
		public const int elementId_stickHat2Down = 40;

		[Token(Token = "0x4000204")]
		public const int elementId_stickHat2Down_Left = 41;

		[Token(Token = "0x4000205")]
		public const int elementId_stickHat2Left = 42;

		[Token(Token = "0x4000206")]
		public const int elementId_stickHat2Up_Left = 43;

		[Token(Token = "0x4000207")]
		public const int elementId_stickHat3Up = 84;

		[Token(Token = "0x4000208")]
		public const int elementId_stickHat3Up_Right = 85;

		[Token(Token = "0x4000209")]
		public const int elementId_stickHat3Right = 86;

		[Token(Token = "0x400020A")]
		public const int elementId_stickHat3Down_Right = 87;

		[Token(Token = "0x400020B")]
		public const int elementId_stickHat3Down = 88;

		[Token(Token = "0x400020C")]
		public const int elementId_stickHat3Down_Left = 89;

		[Token(Token = "0x400020D")]
		public const int elementId_stickHat3Left = 90;

		[Token(Token = "0x400020E")]
		public const int elementId_stickHat3Up_Left = 91;

		[Token(Token = "0x400020F")]
		public const int elementId_stickHat4Up = 92;

		[Token(Token = "0x4000210")]
		public const int elementId_stickHat4Up_Right = 93;

		[Token(Token = "0x4000211")]
		public const int elementId_stickHat4Right = 94;

		[Token(Token = "0x4000212")]
		public const int elementId_stickHat4Down_Right = 95;

		[Token(Token = "0x4000213")]
		public const int elementId_stickHat4Down = 96;

		[Token(Token = "0x4000214")]
		public const int elementId_stickHat4Down_Left = 97;

		[Token(Token = "0x4000215")]
		public const int elementId_stickHat4Left = 98;

		[Token(Token = "0x4000216")]
		public const int elementId_stickHat4Up_Left = 99;

		[Token(Token = "0x4000217")]
		public const int elementId_mode1 = 44;

		[Token(Token = "0x4000218")]
		public const int elementId_mode2 = 45;

		[Token(Token = "0x4000219")]
		public const int elementId_mode3 = 46;

		[Token(Token = "0x400021A")]
		public const int elementId_throttle1Axis = 49;

		[Token(Token = "0x400021B")]
		public const int elementId_throttle2Axis = 155;

		[Token(Token = "0x400021C")]
		public const int elementId_throttle1MinDetent = 166;

		[Token(Token = "0x400021D")]
		public const int elementId_throttle2MinDetent = 167;

		[Token(Token = "0x400021E")]
		public const int elementId_throttleButton1 = 50;

		[Token(Token = "0x400021F")]
		public const int elementId_throttleButton2 = 51;

		[Token(Token = "0x4000220")]
		public const int elementId_throttleButton3 = 52;

		[Token(Token = "0x4000221")]
		public const int elementId_throttleButton4 = 53;

		[Token(Token = "0x4000222")]
		public const int elementId_throttleButton5 = 54;

		[Token(Token = "0x4000223")]
		public const int elementId_throttleButton6 = 55;

		[Token(Token = "0x4000224")]
		public const int elementId_throttleButton7 = 56;

		[Token(Token = "0x4000225")]
		public const int elementId_throttleButton8 = 57;

		[Token(Token = "0x4000226")]
		public const int elementId_throttleButton9 = 58;

		[Token(Token = "0x4000227")]
		public const int elementId_throttleButton10 = 59;

		[Token(Token = "0x4000228")]
		public const int elementId_throttleBaseButton1 = 60;

		[Token(Token = "0x4000229")]
		public const int elementId_throttleBaseButton2 = 61;

		[Token(Token = "0x400022A")]
		public const int elementId_throttleBaseButton3 = 62;

		[Token(Token = "0x400022B")]
		public const int elementId_throttleBaseButton4 = 63;

		[Token(Token = "0x400022C")]
		public const int elementId_throttleBaseButton5 = 64;

		[Token(Token = "0x400022D")]
		public const int elementId_throttleBaseButton6 = 65;

		[Token(Token = "0x400022E")]
		public const int elementId_throttleBaseButton7 = 66;

		[Token(Token = "0x400022F")]
		public const int elementId_throttleBaseButton8 = 67;

		[Token(Token = "0x4000230")]
		public const int elementId_throttleBaseButton9 = 68;

		[Token(Token = "0x4000231")]
		public const int elementId_throttleBaseButton10 = 69;

		[Token(Token = "0x4000232")]
		public const int elementId_throttleBaseButton11 = 132;

		[Token(Token = "0x4000233")]
		public const int elementId_throttleBaseButton12 = 133;

		[Token(Token = "0x4000234")]
		public const int elementId_throttleBaseButton13 = 134;

		[Token(Token = "0x4000235")]
		public const int elementId_throttleBaseButton14 = 135;

		[Token(Token = "0x4000236")]
		public const int elementId_throttleBaseButton15 = 136;

		[Token(Token = "0x4000237")]
		public const int elementId_throttleSlider1 = 70;

		[Token(Token = "0x4000238")]
		public const int elementId_throttleSlider2 = 71;

		[Token(Token = "0x4000239")]
		public const int elementId_throttleSlider3 = 72;

		[Token(Token = "0x400023A")]
		public const int elementId_throttleSlider4 = 73;

		[Token(Token = "0x400023B")]
		public const int elementId_throttleDial1 = 74;

		[Token(Token = "0x400023C")]
		public const int elementId_throttleDial2 = 142;

		[Token(Token = "0x400023D")]
		public const int elementId_throttleDial3 = 143;

		[Token(Token = "0x400023E")]
		public const int elementId_throttleDial4 = 144;

		[Token(Token = "0x400023F")]
		public const int elementId_throttleMiniStickX = 75;

		[Token(Token = "0x4000240")]
		public const int elementId_throttleMiniStickY = 76;

		[Token(Token = "0x4000241")]
		public const int elementId_throttleMiniStickPress = 77;

		[Token(Token = "0x4000242")]
		public const int elementId_throttleWheel1Forward = 145;

		[Token(Token = "0x4000243")]
		public const int elementId_throttleWheel1Back = 146;

		[Token(Token = "0x4000244")]
		public const int elementId_throttleWheel1Press = 147;

		[Token(Token = "0x4000245")]
		public const int elementId_throttleWheel2Forward = 148;

		[Token(Token = "0x4000246")]
		public const int elementId_throttleWheel2Back = 149;

		[Token(Token = "0x4000247")]
		public const int elementId_throttleWheel2Press = 150;

		[Token(Token = "0x4000248")]
		public const int elementId_throttleWheel3Forward = 151;

		[Token(Token = "0x4000249")]
		public const int elementId_throttleWheel3Back = 152;

		[Token(Token = "0x400024A")]
		public const int elementId_throttleWheel3Press = 153;

		[Token(Token = "0x400024B")]
		public const int elementId_throttleHat1Up = 100;

		[Token(Token = "0x400024C")]
		public const int elementId_throttleHat1Up_Right = 101;

		[Token(Token = "0x400024D")]
		public const int elementId_throttleHat1Right = 102;

		[Token(Token = "0x400024E")]
		public const int elementId_throttleHat1Down_Right = 103;

		[Token(Token = "0x400024F")]
		public const int elementId_throttleHat1Down = 104;

		[Token(Token = "0x4000250")]
		public const int elementId_throttleHat1Down_Left = 105;

		[Token(Token = "0x4000251")]
		public const int elementId_throttleHat1Left = 106;

		[Token(Token = "0x4000252")]
		public const int elementId_throttleHat1Up_Left = 107;

		[Token(Token = "0x4000253")]
		public const int elementId_throttleHat2Up = 108;

		[Token(Token = "0x4000254")]
		public const int elementId_throttleHat2Up_Right = 109;

		[Token(Token = "0x4000255")]
		public const int elementId_throttleHat2Right = 110;

		[Token(Token = "0x4000256")]
		public const int elementId_throttleHat2Down_Right = 111;

		[Token(Token = "0x4000257")]
		public const int elementId_throttleHat2Down = 112;

		[Token(Token = "0x4000258")]
		public const int elementId_throttleHat2Down_Left = 113;

		[Token(Token = "0x4000259")]
		public const int elementId_throttleHat2Left = 114;

		[Token(Token = "0x400025A")]
		public const int elementId_throttleHat2Up_Left = 115;

		[Token(Token = "0x400025B")]
		public const int elementId_throttleHat3Up = 116;

		[Token(Token = "0x400025C")]
		public const int elementId_throttleHat3Up_Right = 117;

		[Token(Token = "0x400025D")]
		public const int elementId_throttleHat3Right = 118;

		[Token(Token = "0x400025E")]
		public const int elementId_throttleHat3Down_Right = 119;

		[Token(Token = "0x400025F")]
		public const int elementId_throttleHat3Down = 120;

		[Token(Token = "0x4000260")]
		public const int elementId_throttleHat3Down_Left = 121;

		[Token(Token = "0x4000261")]
		public const int elementId_throttleHat3Left = 122;

		[Token(Token = "0x4000262")]
		public const int elementId_throttleHat3Up_Left = 123;

		[Token(Token = "0x4000263")]
		public const int elementId_throttleHat4Up = 124;

		[Token(Token = "0x4000264")]
		public const int elementId_throttleHat4Up_Right = 125;

		[Token(Token = "0x4000265")]
		public const int elementId_throttleHat4Right = 126;

		[Token(Token = "0x4000266")]
		public const int elementId_throttleHat4Down_Right = 127;

		[Token(Token = "0x4000267")]
		public const int elementId_throttleHat4Down = 128;

		[Token(Token = "0x4000268")]
		public const int elementId_throttleHat4Down_Left = 129;

		[Token(Token = "0x4000269")]
		public const int elementId_throttleHat4Left = 130;

		[Token(Token = "0x400026A")]
		public const int elementId_throttleHat4Up_Left = 131;

		[Token(Token = "0x400026B")]
		public const int elementId_leftPedal = 168;

		[Token(Token = "0x400026C")]
		public const int elementId_rightPedal = 169;

		[Token(Token = "0x400026D")]
		public const int elementId_slidePedals = 170;

		[Token(Token = "0x400026E")]
		public const int elementId_stick = 171;

		[Token(Token = "0x400026F")]
		public const int elementId_stickMiniStick1 = 172;

		[Token(Token = "0x4000270")]
		public const int elementId_stickMiniStick2 = 173;

		[Token(Token = "0x4000271")]
		public const int elementId_stickHat1 = 174;

		[Token(Token = "0x4000272")]
		public const int elementId_stickHat2 = 175;

		[Token(Token = "0x4000273")]
		public const int elementId_stickHat3 = 176;

		[Token(Token = "0x4000274")]
		public const int elementId_stickHat4 = 177;

		[Token(Token = "0x4000275")]
		public const int elementId_throttle1 = 178;

		[Token(Token = "0x4000276")]
		public const int elementId_throttle2 = 179;

		[Token(Token = "0x4000277")]
		public const int elementId_throttleMiniStick = 180;

		[Token(Token = "0x4000278")]
		public const int elementId_throttleHat1 = 181;

		[Token(Token = "0x4000279")]
		public const int elementId_throttleHat2 = 182;

		[Token(Token = "0x400027A")]
		public const int elementId_throttleHat3 = 183;

		[Token(Token = "0x400027B")]
		public const int elementId_throttleHat4 = 184;

		[Token(Token = "0x17000191")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickTrigger
		{
			[Token(Token = "0x600029D")]
			[Address(RVA = "0x1346BC4", Offset = "0x1346BC4", VA = "0x1346BC4", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000192")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickTriggerStage2
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x1346C20", Offset = "0x1346C20", VA = "0x1346C20", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000193")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickPinkyButton
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x1346C7C", Offset = "0x1346C7C", VA = "0x1346C7C", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000194")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickPinkyTrigger
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x1346CD8", Offset = "0x1346CD8", VA = "0x1346CD8", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000195")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton1
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x1346D34", Offset = "0x1346D34", VA = "0x1346D34", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000196")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton2
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x1346D90", Offset = "0x1346D90", VA = "0x1346D90", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000197")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton3
		{
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x1346DEC", Offset = "0x1346DEC", VA = "0x1346DEC", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000198")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton4
		{
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x1346E48", Offset = "0x1346E48", VA = "0x1346E48", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000199")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton5
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x1346EA4", Offset = "0x1346EA4", VA = "0x1346EA4", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019A")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton6
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x1346F00", Offset = "0x1346F00", VA = "0x1346F00", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019B")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton7
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x1346F5C", Offset = "0x1346F5C", VA = "0x1346F5C", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019C")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton8
		{
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x1346FB8", Offset = "0x1346FB8", VA = "0x1346FB8", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019D")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton9
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x1347014", Offset = "0x1347014", VA = "0x1347014", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019E")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton10
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x1347070", Offset = "0x1347070", VA = "0x1347070", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019F")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton1
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x13470CC", Offset = "0x13470CC", VA = "0x13470CC", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A0")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton2
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x1347128", Offset = "0x1347128", VA = "0x1347128", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A1")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton3
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x1347184", Offset = "0x1347184", VA = "0x1347184", Slot = "28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A2")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton4
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x13471E0", Offset = "0x13471E0", VA = "0x13471E0", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A3")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton5
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x134723C", Offset = "0x134723C", VA = "0x134723C", Slot = "30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A4")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton6
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x1347298", Offset = "0x1347298", VA = "0x1347298", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A5")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton7
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x13472F4", Offset = "0x13472F4", VA = "0x13472F4", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A6")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton8
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x1347350", Offset = "0x1347350", VA = "0x1347350", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A7")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton9
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x13473AC", Offset = "0x13473AC", VA = "0x13473AC", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A8")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton10
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x1347408", Offset = "0x1347408", VA = "0x1347408", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A9")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton11
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x1347464", Offset = "0x1347464", VA = "0x1347464", Slot = "36")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AA")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton12
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x13474C0", Offset = "0x13474C0", VA = "0x13474C0", Slot = "37")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AB")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.mode1
		{
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x134751C", Offset = "0x134751C", VA = "0x134751C", Slot = "38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AC")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.mode2
		{
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x1347578", Offset = "0x1347578", VA = "0x1347578", Slot = "39")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AD")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.mode3
		{
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x13475D4", Offset = "0x13475D4", VA = "0x13475D4", Slot = "40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AE")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton1
		{
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x1347630", Offset = "0x1347630", VA = "0x1347630", Slot = "41")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AF")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton2
		{
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x134768C", Offset = "0x134768C", VA = "0x134768C", Slot = "42")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B0")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton3
		{
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x13476E8", Offset = "0x13476E8", VA = "0x13476E8", Slot = "43")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B1")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton4
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x1347744", Offset = "0x1347744", VA = "0x1347744", Slot = "44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B2")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton5
		{
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x13477A0", Offset = "0x13477A0", VA = "0x13477A0", Slot = "45")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B3")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton6
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x13477FC", Offset = "0x13477FC", VA = "0x13477FC", Slot = "46")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B4")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton7
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x1347858", Offset = "0x1347858", VA = "0x1347858", Slot = "47")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B5")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton8
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x13478B4", Offset = "0x13478B4", VA = "0x13478B4", Slot = "48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B6")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton9
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x1347910", Offset = "0x1347910", VA = "0x1347910", Slot = "49")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B7")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton10
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x134796C", Offset = "0x134796C", VA = "0x134796C", Slot = "50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B8")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton1
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x13479C8", Offset = "0x13479C8", VA = "0x13479C8", Slot = "51")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B9")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton2
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x1347A24", Offset = "0x1347A24", VA = "0x1347A24", Slot = "52")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BA")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton3
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x1347A80", Offset = "0x1347A80", VA = "0x1347A80", Slot = "53")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BB")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton4
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x1347ADC", Offset = "0x1347ADC", VA = "0x1347ADC", Slot = "54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BC")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton5
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x1347B38", Offset = "0x1347B38", VA = "0x1347B38", Slot = "55")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BD")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton6
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x1347B94", Offset = "0x1347B94", VA = "0x1347B94", Slot = "56")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BE")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton7
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x1347BF0", Offset = "0x1347BF0", VA = "0x1347BF0", Slot = "57")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BF")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton8
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x1347C4C", Offset = "0x1347C4C", VA = "0x1347C4C", Slot = "58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C0")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton9
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x1347CA8", Offset = "0x1347CA8", VA = "0x1347CA8", Slot = "59")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C1")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton10
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x1347D04", Offset = "0x1347D04", VA = "0x1347D04", Slot = "60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C2")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton11
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x1347D60", Offset = "0x1347D60", VA = "0x1347D60", Slot = "61")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C3")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton12
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x1347DBC", Offset = "0x1347DBC", VA = "0x1347DBC", Slot = "62")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C4")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton13
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x1347E18", Offset = "0x1347E18", VA = "0x1347E18", Slot = "63")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C5")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton14
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x1347E74", Offset = "0x1347E74", VA = "0x1347E74", Slot = "64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C6")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton15
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x1347ED0", Offset = "0x1347ED0", VA = "0x1347ED0", Slot = "65")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C7")]
		private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleSlider1
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x1347F2C", Offset = "0x1347F2C", VA = "0x1347F2C", Slot = "66")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C8")]
		private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleSlider2
		{
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x1347F88", Offset = "0x1347F88", VA = "0x1347F88", Slot = "67")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C9")]
		private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleSlider3
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x1347FE4", Offset = "0x1347FE4", VA = "0x1347FE4", Slot = "68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CA")]
		private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleSlider4
		{
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x1348040", Offset = "0x1348040", VA = "0x1348040", Slot = "69")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CB")]
		private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleDial1
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x134809C", Offset = "0x134809C", VA = "0x134809C", Slot = "70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CC")]
		private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleDial2
		{
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x13480F8", Offset = "0x13480F8", VA = "0x13480F8", Slot = "71")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CD")]
		private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleDial3
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x1348154", Offset = "0x1348154", VA = "0x1348154", Slot = "72")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CE")]
		private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleDial4
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x13481B0", Offset = "0x13481B0", VA = "0x13481B0", Slot = "73")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CF")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel1Forward
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x134820C", Offset = "0x134820C", VA = "0x134820C", Slot = "74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D0")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel1Back
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x1348268", Offset = "0x1348268", VA = "0x1348268", Slot = "75")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D1")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel1Press
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x13482C4", Offset = "0x13482C4", VA = "0x13482C4", Slot = "76")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D2")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel2Forward
		{
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x1348320", Offset = "0x1348320", VA = "0x1348320", Slot = "77")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D3")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel2Back
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x134837C", Offset = "0x134837C", VA = "0x134837C", Slot = "78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D4")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel2Press
		{
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x13483D8", Offset = "0x13483D8", VA = "0x13483D8", Slot = "79")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D5")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel3Forward
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x1348434", Offset = "0x1348434", VA = "0x1348434", Slot = "80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D6")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel3Back
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x1348490", Offset = "0x1348490", VA = "0x1348490", Slot = "81")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D7")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel3Press
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x13484EC", Offset = "0x13484EC", VA = "0x13484EC", Slot = "82")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D8")]
		private IControllerTemplateAxis Rewired.IHOTASTemplate.leftPedal
		{
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x1348548", Offset = "0x1348548", VA = "0x1348548", Slot = "83")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D9")]
		private IControllerTemplateAxis Rewired.IHOTASTemplate.rightPedal
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x13485A4", Offset = "0x13485A4", VA = "0x13485A4", Slot = "84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001DA")]
		private IControllerTemplateAxis Rewired.IHOTASTemplate.slidePedals
		{
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x1348600", Offset = "0x1348600", VA = "0x1348600", Slot = "85")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001DB")]
		private IControllerTemplateStick Rewired.IHOTASTemplate.stick
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x134865C", Offset = "0x134865C", VA = "0x134865C", Slot = "86")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001DC")]
		private IControllerTemplateThumbStick Rewired.IHOTASTemplate.stickMiniStick1
		{
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x13486B8", Offset = "0x13486B8", VA = "0x13486B8", Slot = "87")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001DD")]
		private IControllerTemplateThumbStick Rewired.IHOTASTemplate.stickMiniStick2
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x1348714", Offset = "0x1348714", VA = "0x1348714", Slot = "88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001DE")]
		private IControllerTemplateHat Rewired.IHOTASTemplate.stickHat1
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x1348770", Offset = "0x1348770", VA = "0x1348770", Slot = "89")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001DF")]
		private IControllerTemplateHat Rewired.IHOTASTemplate.stickHat2
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x13487CC", Offset = "0x13487CC", VA = "0x13487CC", Slot = "90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E0")]
		private IControllerTemplateHat Rewired.IHOTASTemplate.stickHat3
		{
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x1348828", Offset = "0x1348828", VA = "0x1348828", Slot = "91")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E1")]
		private IControllerTemplateHat Rewired.IHOTASTemplate.stickHat4
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x1348884", Offset = "0x1348884", VA = "0x1348884", Slot = "92")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E2")]
		private IControllerTemplateThrottle Rewired.IHOTASTemplate.throttle1
		{
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x13488E0", Offset = "0x13488E0", VA = "0x13488E0", Slot = "93")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E3")]
		private IControllerTemplateThrottle Rewired.IHOTASTemplate.throttle2
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x134893C", Offset = "0x134893C", VA = "0x134893C", Slot = "94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E4")]
		private IControllerTemplateThumbStick Rewired.IHOTASTemplate.throttleMiniStick
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x1348998", Offset = "0x1348998", VA = "0x1348998", Slot = "95")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E5")]
		private IControllerTemplateHat Rewired.IHOTASTemplate.throttleHat1
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x13489F4", Offset = "0x13489F4", VA = "0x13489F4", Slot = "96")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E6")]
		private IControllerTemplateHat Rewired.IHOTASTemplate.throttleHat2
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x1348A50", Offset = "0x1348A50", VA = "0x1348A50", Slot = "97")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E7")]
		private IControllerTemplateHat Rewired.IHOTASTemplate.throttleHat3
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x1348AAC", Offset = "0x1348AAC", VA = "0x1348AAC", Slot = "98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E8")]
		private IControllerTemplateHat Rewired.IHOTASTemplate.throttleHat4
		{
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x1348B08", Offset = "0x1348B08", VA = "0x1348B08", Slot = "99")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x133D780", Offset = "0x133D780", VA = "0x133D780")]
		public HOTASTemplate(object payload)
		{
		}
	}
	[Token(Token = "0x2000037")]
	public sealed class FlightYokeTemplate : ControllerTemplate, IFlightYokeTemplate, IControllerTemplate
	{
		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Guid typeGuid;

		[Token(Token = "0x400027D")]
		public const int elementId_rotateYoke = 0;

		[Token(Token = "0x400027E")]
		public const int elementId_yokeZ = 1;

		[Token(Token = "0x400027F")]
		public const int elementId_leftPaddle = 59;

		[Token(Token = "0x4000280")]
		public const int elementId_rightPaddle = 60;

		[Token(Token = "0x4000281")]
		public const int elementId_lever1Axis = 2;

		[Token(Token = "0x4000282")]
		public const int elementId_lever1MinDetent = 64;

		[Token(Token = "0x4000283")]
		public const int elementId_lever2Axis = 3;

		[Token(Token = "0x4000284")]
		public const int elementId_lever2MinDetent = 65;

		[Token(Token = "0x4000285")]
		public const int elementId_lever3Axis = 4;

		[Token(Token = "0x4000286")]
		public const int elementId_lever3MinDetent = 66;

		[Token(Token = "0x4000287")]
		public const int elementId_lever4Axis = 5;

		[Token(Token = "0x4000288")]
		public const int elementId_lever4MinDetent = 67;

		[Token(Token = "0x4000289")]
		public const int elementId_lever5Axis = 6;

		[Token(Token = "0x400028A")]
		public const int elementId_lever5MinDetent = 68;

		[Token(Token = "0x400028B")]
		public const int elementId_leftGripButton1 = 7;

		[Token(Token = "0x400028C")]
		public const int elementId_leftGripButton2 = 8;

		[Token(Token = "0x400028D")]
		public const int elementId_leftGripButton3 = 9;

		[Token(Token = "0x400028E")]
		public const int elementId_leftGripButton4 = 10;

		[Token(Token = "0x400028F")]
		public const int elementId_leftGripButton5 = 11;

		[Token(Token = "0x4000290")]
		public const int elementId_leftGripButton6 = 12;

		[Token(Token = "0x4000291")]
		public const int elementId_rightGripButton1 = 13;

		[Token(Token = "0x4000292")]
		public const int elementId_rightGripButton2 = 14;

		[Token(Token = "0x4000293")]
		public const int elementId_rightGripButton3 = 15;

		[Token(Token = "0x4000294")]
		public const int elementId_rightGripButton4 = 16;

		[Token(Token = "0x4000295")]
		public const int elementId_rightGripButton5 = 17;

		[Token(Token = "0x4000296")]
		public const int elementId_rightGripButton6 = 18;

		[Token(Token = "0x4000297")]
		public const int elementId_centerButton1 = 19;

		[Token(Token = "0x4000298")]
		public const int elementId_centerButton2 = 20;

		[Token(Token = "0x4000299")]
		public const int elementId_centerButton3 = 21;

		[Token(Token = "0x400029A")]
		public const int elementId_centerButton4 = 22;

		[Token(Token = "0x400029B")]
		public const int elementId_centerButton5 = 23;

		[Token(Token = "0x400029C")]
		public const int elementId_centerButton6 = 24;

		[Token(Token = "0x400029D")]
		public const int elementId_centerButton7 = 25;

		[Token(Token = "0x400029E")]
		public const int elementId_centerButton8 = 26;

		[Token(Token = "0x400029F")]
		public const int elementId_wheel1Up = 53;

		[Token(Token = "0x40002A0")]
		public const int elementId_wheel1Down = 54;

		[Token(Token = "0x40002A1")]
		public const int elementId_wheel1Press = 55;

		[Token(Token = "0x40002A2")]
		public const int elementId_wheel2Up = 56;

		[Token(Token = "0x40002A3")]
		public const int elementId_wheel2Down = 57;

		[Token(Token = "0x40002A4")]
		public const int elementId_wheel2Press = 58;

		[Token(Token = "0x40002A5")]
		public const int elementId_leftGripHatUp = 27;

		[Token(Token = "0x40002A6")]
		public const int elementId_leftGripHatUpRight = 28;

		[Token(Token = "0x40002A7")]
		public const int elementId_leftGripHatRight = 29;

		[Token(Token = "0x40002A8")]
		public const int elementId_leftGripHatDownRight = 30;

		[Token(Token = "0x40002A9")]
		public const int elementId_leftGripHatDown = 31;

		[Token(Token = "0x40002AA")]
		public const int elementId_leftGripHatDownLeft = 32;

		[Token(Token = "0x40002AB")]
		public const int elementId_leftGripHatLeft = 33;

		[Token(Token = "0x40002AC")]
		public const int elementId_leftGripHatUpLeft = 34;

		[Token(Token = "0x40002AD")]
		public const int elementId_rightGripHatUp = 35;

		[Token(Token = "0x40002AE")]
		public const int elementId_rightGripHatUpRight = 36;

		[Token(Token = "0x40002AF")]
		public const int elementId_rightGripHatRight = 37;

		[Token(Token = "0x40002B0")]
		public const int elementId_rightGripHatDownRight = 38;

		[Token(Token = "0x40002B1")]
		public const int elementId_rightGripHatDown = 39;

		[Token(Token = "0x40002B2")]
		public const int elementId_rightGripHatDownLeft = 40;

		[Token(Token = "0x40002B3")]
		public const int elementId_rightGripHatLeft = 41;

		[Token(Token = "0x40002B4")]
		public const int elementId_rightGripHatUpLeft = 42;

		[Token(Token = "0x40002B5")]
		public const int elementId_consoleButton1 = 43;

		[Token(Token = "0x40002B6")]
		public const int elementId_consoleButton2 = 44;

		[Token(Token = "0x40002B7")]
		public const int elementId_consoleButton3 = 45;

		[Token(Token = "0x40002B8")]
		public const int elementId_consoleButton4 = 46;

		[Token(Token = "0x40002B9")]
		public const int elementId_consoleButton5 = 47;

		[Token(Token = "0x40002BA")]
		public const int elementId_consoleButton6 = 48;

		[Token(Token = "0x40002BB")]
		public const int elementId_consoleButton7 = 49;

		[Token(Token = "0x40002BC")]
		public const int elementId_consoleButton8 = 50;

		[Token(Token = "0x40002BD")]
		public const int elementId_consoleButton9 = 51;

		[Token(Token = "0x40002BE")]
		public const int elementId_consoleButton10 = 52;

		[Token(Token = "0x40002BF")]
		public const int elementId_mode1 = 61;

		[Token(Token = "0x40002C0")]
		public const int elementId_mode2 = 62;

		[Token(Token = "0x40002C1")]
		public const int elementId_mode3 = 63;

		[Token(Token = "0x40002C2")]
		public const int elementId_yoke = 69;

		[Token(Token = "0x40002C3")]
		public const int elementId_lever1 = 70;

		[Token(Token = "0x40002C4")]
		public const int elementId_lever2 = 71;

		[Token(Token = "0x40002C5")]
		public const int elementId_lever3 = 72;

		[Token(Token = "0x40002C6")]
		public const int elementId_lever4 = 73;

		[Token(Token = "0x40002C7")]
		public const int elementId_lever5 = 74;

		[Token(Token = "0x40002C8")]
		public const int elementId_leftGripHat = 75;

		[Token(Token = "0x40002C9")]
		public const int elementId_rightGripHat = 76;

		[Token(Token = "0x170001E9")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.leftPaddle
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x1344C68", Offset = "0x1344C68", VA = "0x1344C68", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001EA")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.rightPaddle
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x1344CC4", Offset = "0x1344CC4", VA = "0x1344CC4", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001EB")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton1
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x1344D20", Offset = "0x1344D20", VA = "0x1344D20", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001EC")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton2
		{
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x1344D7C", Offset = "0x1344D7C", VA = "0x1344D7C", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001ED")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton3
		{
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x1344DD8", Offset = "0x1344DD8", VA = "0x1344DD8", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001EE")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton4
		{
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x1344E34", Offset = "0x1344E34", VA = "0x1344E34", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001EF")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton5
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x1344E90", Offset = "0x1344E90", VA = "0x1344E90", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F0")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton6
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x1344EEC", Offset = "0x1344EEC", VA = "0x1344EEC", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F1")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton1
		{
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x1344F48", Offset = "0x1344F48", VA = "0x1344F48", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F2")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton2
		{
			[Token(Token = "0x6000300")]
			[Address(RVA = "0x1344FA4", Offset = "0x1344FA4", VA = "0x1344FA4", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F3")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton3
		{
			[Token(Token = "0x6000301")]
			[Address(RVA = "0x1345000", Offset = "0x1345000", VA = "0x1345000", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F4")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton4
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x134505C", Offset = "0x134505C", VA = "0x134505C", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F5")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton5
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x13450B8", Offset = "0x13450B8", VA = "0x13450B8", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F6")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton6
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x1345114", Offset = "0x1345114", VA = "0x1345114", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F7")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton1
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x1345170", Offset = "0x1345170", VA = "0x1345170", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F8")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton2
		{
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x13451CC", Offset = "0x13451CC", VA = "0x13451CC", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F9")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton3
		{
			[Token(Token = "0x6000307")]
			[Address(RVA = "0x1345228", Offset = "0x1345228", VA = "0x1345228", Slot = "28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001FA")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton4
		{
			[Token(Token = "0x6000308")]
			[Address(RVA = "0x1345284", Offset = "0x1345284", VA = "0x1345284", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001FB")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton5
		{
			[Token(Token = "0x6000309")]
			[Address(RVA = "0x13452E0", Offset = "0x13452E0", VA = "0x13452E0", Slot = "30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001FC")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton6
		{
			[Token(Token = "0x600030A")]
			[Address(RVA = "0x134533C", Offset = "0x134533C", VA = "0x134533C", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001FD")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton7
		{
			[Token(Token = "0x600030B")]
			[Address(RVA = "0x1345398", Offset = "0x1345398", VA = "0x1345398", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001FE")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton8
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0x13453F4", Offset = "0x13453F4", VA = "0x13453F4", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001FF")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel1Up
		{
			[Token(Token = "0x600030D")]
			[Address(RVA = "0x1345450", Offset = "0x1345450", VA = "0x1345450", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000200")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel1Down
		{
			[Token(Token = "0x600030E")]
			[Address(RVA = "0x13454AC", Offset = "0x13454AC", VA = "0x13454AC", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000201")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel1Press
		{
			[Token(Token = "0x600030F")]
			[Address(RVA = "0x1345508", Offset = "0x1345508", VA = "0x1345508", Slot = "36")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000202")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel2Up
		{
			[Token(Token = "0x6000310")]
			[Address(RVA = "0x1345564", Offset = "0x1345564", VA = "0x1345564", Slot = "37")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000203")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel2Down
		{
			[Token(Token = "0x6000311")]
			[Address(RVA = "0x13455C0", Offset = "0x13455C0", VA = "0x13455C0", Slot = "38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000204")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel2Press
		{
			[Token(Token = "0x6000312")]
			[Address(RVA = "0x134561C", Offset = "0x134561C", VA = "0x134561C", Slot = "39")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000205")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton1
		{
			[Token(Token = "0x6000313")]
			[Address(RVA = "0x1345678", Offset = "0x1345678", VA = "0x1345678", Slot = "40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000206")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton2
		{
			[Token(Token = "0x6000314")]
			[Address(RVA = "0x13456D4", Offset = "0x13456D4", VA = "0x13456D4", Slot = "41")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000207")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton3
		{
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x1345730", Offset = "0x1345730", VA = "0x1345730", Slot = "42")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000208")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton4
		{
			[Token(Token = "0x6000316")]
			[Address(RVA = "0x134578C", Offset = "0x134578C", VA = "0x134578C", Slot = "43")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000209")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton5
		{
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x13457E8", Offset = "0x13457E8", VA = "0x13457E8", Slot = "44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700020A")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton6
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x1345844", Offset = "0x1345844", VA = "0x1345844", Slot = "45")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700020B")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton7
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x13458A0", Offset = "0x13458A0", VA = "0x13458A0", Slot = "46")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700020C")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton8
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x13458FC", Offset = "0x13458FC", VA = "0x13458FC", Slot = "47")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700020D")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton9
		{
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x1345958", Offset = "0x1345958", VA = "0x1345958", Slot = "48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700020E")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton10
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x13459B4", Offset = "0x13459B4", VA = "0x13459B4", Slot = "49")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700020F")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.mode1
		{
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x1345A10", Offset = "0x1345A10", VA = "0x1345A10", Slot = "50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000210")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.mode2
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x1345A6C", Offset = "0x1345A6C", VA = "0x1345A6C", Slot = "51")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000211")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.mode3
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x1345AC8", Offset = "0x1345AC8", VA = "0x1345AC8", Slot = "52")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000212")]
		private IControllerTemplateYoke Rewired.IFlightYokeTemplate.yoke
		{
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x1345B24", Offset = "0x1345B24", VA = "0x1345B24", Slot = "53")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000213")]
		private IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever1
		{
			[Token(Token = "0x6000321")]
			[Address(RVA = "0x1345B80", Offset = "0x1345B80", VA = "0x1345B80", Slot = "54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000214")]
		private IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever2
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x1345BDC", Offset = "0x1345BDC", VA = "0x1345BDC", Slot = "55")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000215")]
		private IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever3
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x1345C38", Offset = "0x1345C38", VA = "0x1345C38", Slot = "56")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000216")]
		private IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever4
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x1345C94", Offset = "0x1345C94", VA = "0x1345C94", Slot = "57")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000217")]
		private IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever5
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x1345CF0", Offset = "0x1345CF0", VA = "0x1345CF0", Slot = "58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000218")]
		private IControllerTemplateHat Rewired.IFlightYokeTemplate.leftGripHat
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x1345D4C", Offset = "0x1345D4C", VA = "0x1345D4C", Slot = "59")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000219")]
		private IControllerTemplateHat Rewired.IFlightYokeTemplate.rightGripHat
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x1345DA8", Offset = "0x1345DA8", VA = "0x1345DA8", Slot = "60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x133D788", Offset = "0x133D788", VA = "0x133D788")]
		public FlightYokeTemplate(object payload)
		{
		}
	}
	[Token(Token = "0x2000038")]
	public sealed class FlightPedalsTemplate : ControllerTemplate, IFlightPedalsTemplate, IControllerTemplate
	{
		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Guid typeGuid;

		[Token(Token = "0x40002CB")]
		public const int elementId_leftPedal = 0;

		[Token(Token = "0x40002CC")]
		public const int elementId_rightPedal = 1;

		[Token(Token = "0x40002CD")]
		public const int elementId_slide = 2;

		[Token(Token = "0x1700021A")]
		private IControllerTemplateAxis Rewired.IFlightPedalsTemplate.leftPedal
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x1344AB8", Offset = "0x1344AB8", VA = "0x1344AB8", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700021B")]
		private IControllerTemplateAxis Rewired.IFlightPedalsTemplate.rightPedal
		{
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x1344B14", Offset = "0x1344B14", VA = "0x1344B14", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700021C")]
		private IControllerTemplateAxis Rewired.IFlightPedalsTemplate.slide
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x1344B70", Offset = "0x1344B70", VA = "0x1344B70", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x133D790", Offset = "0x133D790", VA = "0x133D790")]
		public FlightPedalsTemplate(object payload)
		{
		}
	}
	[Token(Token = "0x2000039")]
	public sealed class SixDofControllerTemplate : ControllerTemplate, ISixDofControllerTemplate, IControllerTemplate
	{
		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Guid typeGuid;

		[Token(Token = "0x40002CF")]
		public const int elementId_positionX = 1;

		[Token(Token = "0x40002D0")]
		public const int elementId_positionY = 2;

		[Token(Token = "0x40002D1")]
		public const int elementId_positionZ = 0;

		[Token(Token = "0x40002D2")]
		public const int elementId_rotationX = 3;

		[Token(Token = "0x40002D3")]
		public const int elementId_rotationY = 5;

		[Token(Token = "0x40002D4")]
		public const int elementId_rotationZ = 4;

		[Token(Token = "0x40002D5")]
		public const int elementId_throttle1Axis = 6;

		[Token(Token = "0x40002D6")]
		public const int elementId_throttle1MinDetent = 50;

		[Token(Token = "0x40002D7")]
		public const int elementId_throttle2Axis = 7;

		[Token(Token = "0x40002D8")]
		public const int elementId_throttle2MinDetent = 51;

		[Token(Token = "0x40002D9")]
		public const int elementId_extraAxis1 = 8;

		[Token(Token = "0x40002DA")]
		public const int elementId_extraAxis2 = 9;

		[Token(Token = "0x40002DB")]
		public const int elementId_extraAxis3 = 10;

		[Token(Token = "0x40002DC")]
		public const int elementId_extraAxis4 = 11;

		[Token(Token = "0x40002DD")]
		public const int elementId_button1 = 12;

		[Token(Token = "0x40002DE")]
		public const int elementId_button2 = 13;

		[Token(Token = "0x40002DF")]
		public const int elementId_button3 = 14;

		[Token(Token = "0x40002E0")]
		public const int elementId_button4 = 15;

		[Token(Token = "0x40002E1")]
		public const int elementId_button5 = 16;

		[Token(Token = "0x40002E2")]
		public const int elementId_button6 = 17;

		[Token(Token = "0x40002E3")]
		public const int elementId_button7 = 18;

		[Token(Token = "0x40002E4")]
		public const int elementId_button8 = 19;

		[Token(Token = "0x40002E5")]
		public const int elementId_button9 = 20;

		[Token(Token = "0x40002E6")]
		public const int elementId_button10 = 21;

		[Token(Token = "0x40002E7")]
		public const int elementId_button11 = 22;

		[Token(Token = "0x40002E8")]
		public const int elementId_button12 = 23;

		[Token(Token = "0x40002E9")]
		public const int elementId_button13 = 24;

		[Token(Token = "0x40002EA")]
		public const int elementId_button14 = 25;

		[Token(Token = "0x40002EB")]
		public const int elementId_button15 = 26;

		[Token(Token = "0x40002EC")]
		public const int elementId_button16 = 27;

		[Token(Token = "0x40002ED")]
		public const int elementId_button17 = 28;

		[Token(Token = "0x40002EE")]
		public const int elementId_button18 = 29;

		[Token(Token = "0x40002EF")]
		public const int elementId_button19 = 30;

		[Token(Token = "0x40002F0")]
		public const int elementId_button20 = 31;

		[Token(Token = "0x40002F1")]
		public const int elementId_button21 = 55;

		[Token(Token = "0x40002F2")]
		public const int elementId_button22 = 56;

		[Token(Token = "0x40002F3")]
		public const int elementId_button23 = 57;

		[Token(Token = "0x40002F4")]
		public const int elementId_button24 = 58;

		[Token(Token = "0x40002F5")]
		public const int elementId_button25 = 59;

		[Token(Token = "0x40002F6")]
		public const int elementId_button26 = 60;

		[Token(Token = "0x40002F7")]
		public const int elementId_button27 = 61;

		[Token(Token = "0x40002F8")]
		public const int elementId_button28 = 62;

		[Token(Token = "0x40002F9")]
		public const int elementId_button29 = 63;

		[Token(Token = "0x40002FA")]
		public const int elementId_button30 = 64;

		[Token(Token = "0x40002FB")]
		public const int elementId_button31 = 65;

		[Token(Token = "0x40002FC")]
		public const int elementId_button32 = 66;

		[Token(Token = "0x40002FD")]
		public const int elementId_hat1Up = 32;

		[Token(Token = "0x40002FE")]
		public const int elementId_hat1UpRight = 33;

		[Token(Token = "0x40002FF")]
		public const int elementId_hat1Right = 34;

		[Token(Token = "0x4000300")]
		public const int elementId_hat1DownRight = 35;

		[Token(Token = "0x4000301")]
		public const int elementId_hat1Down = 36;

		[Token(Token = "0x4000302")]
		public const int elementId_hat1DownLeft = 37;

		[Token(Token = "0x4000303")]
		public const int elementId_hat1Left = 38;

		[Token(Token = "0x4000304")]
		public const int elementId_hat1UpLeft = 39;

		[Token(Token = "0x4000305")]
		public const int elementId_hat2Up = 40;

		[Token(Token = "0x4000306")]
		public const int elementId_hat2UpRight = 41;

		[Token(Token = "0x4000307")]
		public const int elementId_hat2Right = 42;

		[Token(Token = "0x4000308")]
		public const int elementId_hat2DownRight = 43;

		[Token(Token = "0x4000309")]
		public const int elementId_hat2Down = 44;

		[Token(Token = "0x400030A")]
		public const int elementId_hat2DownLeft = 45;

		[Token(Token = "0x400030B")]
		public const int elementId_hat2Left = 46;

		[Token(Token = "0x400030C")]
		public const int elementId_hat2UpLeft = 47;

		[Token(Token = "0x400030D")]
		public const int elementId_hat1 = 48;

		[Token(Token = "0x400030E")]
		public const int elementId_hat2 = 49;

		[Token(Token = "0x400030F")]
		public const int elementId_throttle1 = 52;

		[Token(Token = "0x4000310")]
		public const int elementId_throttle2 = 53;

		[Token(Token = "0x4000311")]
		public const int elementId_stick = 54;

		[Token(Token = "0x1700021D")]
		private IControllerTemplateAxis Rewired.ISixDofControllerTemplate.extraAxis1
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x22DA600", Offset = "0x22DA600", VA = "0x22DA600", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700021E")]
		private IControllerTemplateAxis Rewired.ISixDofControllerTemplate.extraAxis2
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x22DA65C", Offset = "0x22DA65C", VA = "0x22DA65C", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700021F")]
		private IControllerTemplateAxis Rewired.ISixDofControllerTemplate.extraAxis3
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x22DA6B8", Offset = "0x22DA6B8", VA = "0x22DA6B8", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000220")]
		private IControllerTemplateAxis Rewired.ISixDofControllerTemplate.extraAxis4
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x22DA714", Offset = "0x22DA714", VA = "0x22DA714", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000221")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button1
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x22DA770", Offset = "0x22DA770", VA = "0x22DA770", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000222")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button2
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x22DA7CC", Offset = "0x22DA7CC", VA = "0x22DA7CC", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000223")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button3
		{
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x22DA828", Offset = "0x22DA828", VA = "0x22DA828", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000224")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button4
		{
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x22DA884", Offset = "0x22DA884", VA = "0x22DA884", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000225")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button5
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x22DA8E0", Offset = "0x22DA8E0", VA = "0x22DA8E0", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000226")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button6
		{
			[Token(Token = "0x6000338")]
			[Address(RVA = "0x22DA93C", Offset = "0x22DA93C", VA = "0x22DA93C", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000227")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button7
		{
			[Token(Token = "0x6000339")]
			[Address(RVA = "0x22DA998", Offset = "0x22DA998", VA = "0x22DA998", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000228")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button8
		{
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x22DA9F4", Offset = "0x22DA9F4", VA = "0x22DA9F4", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000229")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button9
		{
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x22DAA50", Offset = "0x22DAA50", VA = "0x22DAA50", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700022A")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button10
		{
			[Token(Token = "0x600033C")]
			[Address(RVA = "0x22DAAAC", Offset = "0x22DAAAC", VA = "0x22DAAAC", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700022B")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button11
		{
			[Token(Token = "0x600033D")]
			[Address(RVA = "0x22DAB08", Offset = "0x22DAB08", VA = "0x22DAB08", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700022C")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button12
		{
			[Token(Token = "0x600033E")]
			[Address(RVA = "0x22DAB64", Offset = "0x22DAB64", VA = "0x22DAB64", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700022D")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button13
		{
			[Token(Token = "0x600033F")]
			[Address(RVA = "0x22DABC0", Offset = "0x22DABC0", VA = "0x22DABC0", Slot = "28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700022E")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button14
		{
			[Token(Token = "0x6000340")]
			[Address(RVA = "0x22DAC1C", Offset = "0x22DAC1C", VA = "0x22DAC1C", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700022F")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button15
		{
			[Token(Token = "0x6000341")]
			[Address(RVA = "0x22DAC78", Offset = "0x22DAC78", VA = "0x22DAC78", Slot = "30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000230")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button16
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0x22DACD4", Offset = "0x22DACD4", VA = "0x22DACD4", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000231")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button17
		{
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x22DAD30", Offset = "0x22DAD30", VA = "0x22DAD30", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000232")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button18
		{
			[Token(Token = "0x6000344")]
			[Address(RVA = "0x22DAD8C", Offset = "0x22DAD8C", VA = "0x22DAD8C", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000233")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button19
		{
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x22DADE8", Offset = "0x22DADE8", VA = "0x22DADE8", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000234")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button20
		{
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x22DAE44", Offset = "0x22DAE44", VA = "0x22DAE44", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000235")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button21
		{
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x22DAEA0", Offset = "0x22DAEA0", VA = "0x22DAEA0", Slot = "36")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000236")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button22
		{
			[Token(Token = "0x6000348")]
			[Address(RVA = "0x22DAEFC", Offset = "0x22DAEFC", VA = "0x22DAEFC", Slot = "37")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000237")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button23
		{
			[Token(Token = "0x6000349")]
			[Address(RVA = "0x22DAF58", Offset = "0x22DAF58", VA = "0x22DAF58", Slot = "38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000238")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button24
		{
			[Token(Token = "0x600034A")]
			[Address(RVA = "0x22DAFB4", Offset = "0x22DAFB4", VA = "0x22DAFB4", Slot = "39")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000239")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button25
		{
			[Token(Token = "0x600034B")]
			[Address(RVA = "0x22DB010", Offset = "0x22DB010", VA = "0x22DB010", Slot = "40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700023A")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button26
		{
			[Token(Token = "0x600034C")]
			[Address(RVA = "0x22DB06C", Offset = "0x22DB06C", VA = "0x22DB06C", Slot = "41")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700023B")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button27
		{
			[Token(Token = "0x600034D")]
			[Address(RVA = "0x22DB0C8", Offset = "0x22DB0C8", VA = "0x22DB0C8", Slot = "42")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700023C")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button28
		{
			[Token(Token = "0x600034E")]
			[Address(RVA = "0x22DB124", Offset = "0x22DB124", VA = "0x22DB124", Slot = "43")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700023D")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button29
		{
			[Token(Token = "0x600034F")]
			[Address(RVA = "0x22DB180", Offset = "0x22DB180", VA = "0x22DB180", Slot = "44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700023E")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button30
		{
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x22DB1DC", Offset = "0x22DB1DC", VA = "0x22DB1DC", Slot = "45")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700023F")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button31
		{
			[Token(Token = "0x6000351")]
			[Address(RVA = "0x22DB238", Offset = "0x22DB238", VA = "0x22DB238", Slot = "46")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000240")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button32
		{
			[Token(Token = "0x6000352")]
			[Address(RVA = "0x22DB294", Offset = "0x22DB294", VA = "0x22DB294", Slot = "47")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000241")]
		private IControllerTemplateHat Rewired.ISixDofControllerTemplate.hat1
		{
			[Token(Token = "0x6000353")]
			[Address(RVA = "0x22DB2F0", Offset = "0x22DB2F0", VA = "0x22DB2F0", Slot = "48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000242")]
		private IControllerTemplateHat Rewired.ISixDofControllerTemplate.hat2
		{
			[Token(Token = "0x6000354")]
			[Address(RVA = "0x22DB34C", Offset = "0x22DB34C", VA = "0x22DB34C", Slot = "49")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000243")]
		private IControllerTemplateThrottle Rewired.ISixDofControllerTemplate.throttle1
		{
			[Token(Token = "0x6000355")]
			[Address(RVA = "0x22DB3A8", Offset = "0x22DB3A8", VA = "0x22DB3A8", Slot = "50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000244")]
		private IControllerTemplateThrottle Rewired.ISixDofControllerTemplate.throttle2
		{
			[Token(Token = "0x6000356")]
			[Address(RVA = "0x22DB404", Offset = "0x22DB404", VA = "0x22DB404", Slot = "51")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000245")]
		private IControllerTemplateStick6D Rewired.ISixDofControllerTemplate.stick
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x22DB460", Offset = "0x22DB460", VA = "0x22DB460", Slot = "52")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x22DB4BC", Offset = "0x22DB4BC", VA = "0x22DB4BC")]
		public SixDofControllerTemplate(object payload)
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59B684", Offset = "0x59B684")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x59B684", Offset = "0x59B684")]
	public sealed class InputManager : InputManager_Base
	{
		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool ignoreRecompile;

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x1348C08", Offset = "0x1348C08", VA = "0x1348C08", Slot = "4")]
		protected override void OnInitialized()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x1348D00", Offset = "0x1348D00", VA = "0x1348D00", Slot = "5")]
		protected override void OnDeinitialized()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x1348DF0", Offset = "0x1348DF0", VA = "0x1348DF0", Slot = "6")]
		protected override void DetectPlatform()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x134903C", Offset = "0x134903C", VA = "0x134903C", Slot = "7")]
		protected override void CheckRecompile()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x1349040", Offset = "0x1349040", VA = "0x1349040", Slot = "8")]
		protected override IExternalTools GetExternalTools()
		{
			return null;
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1348F70", Offset = "0x1348F70", VA = "0x1348F70")]
		private bool CheckDeviceName(string searchPattern, string deviceName, string deviceModel)
		{
			return default(bool);
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x1348C0C", Offset = "0x1348C0C", VA = "0x1348C0C")]
		private void SubscribeEvents()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x1348D04", Offset = "0x1348D04", VA = "0x1348D04")]
		private void UnsubscribeEvents()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x13490A0", Offset = "0x13490A0", VA = "0x13490A0")]
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x13490A8", Offset = "0x13490A8", VA = "0x13490A8")]
		public InputManager()
		{
		}
	}
}
namespace Rewired.Utils
{
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x59B6D0", Offset = "0x59B6D0")]
	public class ExternalTools : IExternalTools
	{
		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Func<object> _getPlatformInitializerDelegate;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private bool _isEditorPaused;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private Action<bool> _EditorPausedStateChangedEvent;

		[Token(Token = "0x4000317")]
		private const int API_LEVEL_HONEYCOMB = 9;

		[Token(Token = "0x4000318")]
		private const int API_LEVEL_KITKAT = 19;

		[Token(Token = "0x17000246")]
		public static Func<object> getPlatformInitializerDelegate
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x13430CC", Offset = "0x13430CC", VA = "0x13430CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x1343120", Offset = "0x1343120", VA = "0x1343120")]
			set
			{
			}
		}

		[Token(Token = "0x17000247")]
		public bool isEditorPaused
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x134318C", Offset = "0x134318C", VA = "0x134318C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000248")]
		public bool UnityInput_IsTouchPressureSupported
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x1344874", Offset = "0x1344874", VA = "0x1344874", Slot = "81")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000003")]
		public event Action<bool> EditorPausedStateChangedEvent
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x1343194", Offset = "0x1343194", VA = "0x1343194", Slot = "5")]
			add
			{
			}
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x134322C", Offset = "0x134322C", VA = "0x134322C", Slot = "6")]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event Action<uint, bool> XboxOneInput_OnGamepadStateChange
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x1343330", Offset = "0x1343330", VA = "0x1343330", Slot = "14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0A10", Offset = "0x5A0A10")]
			add
			{
			}
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x13433DC", Offset = "0x13433DC", VA = "0x13433DC", Slot = "15")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0A20", Offset = "0x5A0A20")]
			remove
			{
			}
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x1343180", Offset = "0x1343180", VA = "0x1343180")]
		public ExternalTools()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x1343188", Offset = "0x1343188", VA = "0x1343188", Slot = "7")]
		public void Destroy()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x13432C4", Offset = "0x13432C4", VA = "0x13432C4", Slot = "8")]
		public object GetPlatformInitializer()
		{
			return null;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x13432CC", Offset = "0x13432CC", VA = "0x13432CC", Slot = "9")]
		public string GetFocusedEditorWindowTitle()
		{
			return null;
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x1343320", Offset = "0x1343320", VA = "0x1343320", Slot = "10")]
		public bool IsEditorSceneViewFocused()
		{
			return default(bool);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x1343328", Offset = "0x1343328", VA = "0x1343328", Slot = "11")]
		public bool LinuxInput_IsJoystickPreconfigured(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x1343488", Offset = "0x1343488", VA = "0x1343488", Slot = "12")]
		public int XboxOneInput_GetUserIdForGamepad(uint id)
		{
			return default(int);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x1343490", Offset = "0x1343490", VA = "0x1343490", Slot = "13")]
		public ulong XboxOneInput_GetControllerId(uint unityJoystickId)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x134349C", Offset = "0x134349C", VA = "0x134349C", Slot = "16")]
		public bool XboxOneInput_IsGamepadActive(uint unityJoystickId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x13434A4", Offset = "0x13434A4", VA = "0x13434A4", Slot = "17")]
		public string XboxOneInput_GetControllerType(ulong xboxControllerId)
		{
			return null;
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x13434F8", Offset = "0x13434F8", VA = "0x13434F8", Slot = "18")]
		public uint XboxOneInput_GetJoystickId(ulong xboxControllerId)
		{
			return default(uint);
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x1343500", Offset = "0x1343500", VA = "0x1343500", Slot = "19")]
		public void XboxOne_Gamepad_UpdatePlugin()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1343504", Offset = "0x1343504", VA = "0x1343504", Slot = "20")]
		public bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel)
		{
			return default(bool);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x134350C", Offset = "0x134350C", VA = "0x134350C", Slot = "21")]
		public void XboxOne_Gamepad_PulseVibrateMotor(ulong xboxOneJoystickId, int motorInt, float startLevel, float endLevel, ulong durationMS)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1343510", Offset = "0x1343510", VA = "0x1343510", Slot = "22")]
		public Vector3 PS4Input_GetLastAcceleration(int id)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1343544", Offset = "0x1343544", VA = "0x1343544", Slot = "23")]
		public Vector3 PS4Input_GetLastGyro(int id)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1343578", Offset = "0x1343578", VA = "0x1343578", Slot = "24")]
		public Vector4 PS4Input_GetLastOrientation(int id)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x13435A8", Offset = "0x13435A8", VA = "0x13435A8", Slot = "25")]
		public void PS4Input_GetLastTouchData(int id, out int touchNum, out int touch0x, out int touch0y, out int touch0id, out int touch1x, out int touch1y, out int touch1id)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x13435E8", Offset = "0x13435E8", VA = "0x13435E8", Slot = "26")]
		public void PS4Input_GetPadControllerInformation(int id, out float touchpixelDensity, out int touchResolutionX, out int touchResolutionY, out int analogDeadZoneLeft, out int analogDeadZoneright, out int connectionType)
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x134361C", Offset = "0x134361C", VA = "0x134361C", Slot = "27")]
		public void PS4Input_PadSetMotionSensorState(int id, bool bEnable)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x1343620", Offset = "0x1343620", VA = "0x1343620", Slot = "28")]
		public void PS4Input_PadSetTiltCorrectionState(int id, bool bEnable)
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x1343624", Offset = "0x1343624", VA = "0x1343624", Slot = "29")]
		public void PS4Input_PadSetAngularVelocityDeadbandState(int id, bool bEnable)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x1343628", Offset = "0x1343628", VA = "0x1343628", Slot = "30")]
		public void PS4Input_PadSetLightBar(int id, int red, int green, int blue)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x134362C", Offset = "0x134362C", VA = "0x134362C", Slot = "31")]
		public void PS4Input_PadResetLightBar(int id)
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1343630", Offset = "0x1343630", VA = "0x1343630", Slot = "32")]
		public void PS4Input_PadSetVibration(int id, int largeMotor, int smallMotor)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x1343634", Offset = "0x1343634", VA = "0x1343634", Slot = "33")]
		public void PS4Input_PadResetOrientation(int id)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1343638", Offset = "0x1343638", VA = "0x1343638", Slot = "34")]
		public bool PS4Input_PadIsConnected(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1343640", Offset = "0x1343640", VA = "0x1343640", Slot = "35")]
		public void PS4Input_GetUsersDetails(int slot, object loggedInUser)
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1343644", Offset = "0x1343644", VA = "0x1343644", Slot = "36")]
		public int PS4Input_GetDeviceClassForHandle(int handle)
		{
			return default(int);
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x134364C", Offset = "0x134364C", VA = "0x134364C", Slot = "37")]
		public string PS4Input_GetDeviceClassString(int intValue)
		{
			return null;
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1343654", Offset = "0x1343654", VA = "0x1343654", Slot = "38")]
		public int PS4Input_PadGetUsersHandles2(int maxControllers, int[] handles)
		{
			return default(int);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x134365C", Offset = "0x134365C", VA = "0x134365C", Slot = "39")]
		public void PS4Input_GetSpecialControllerInformation(int id, int padIndex, object controllerInformation)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1343660", Offset = "0x1343660", VA = "0x1343660", Slot = "40")]
		public Vector3 PS4Input_SpecialGetLastAcceleration(int id)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x1343694", Offset = "0x1343694", VA = "0x1343694", Slot = "41")]
		public Vector3 PS4Input_SpecialGetLastGyro(int id)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x13436C8", Offset = "0x13436C8", VA = "0x13436C8", Slot = "42")]
		public Vector4 PS4Input_SpecialGetLastOrientation(int id)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x13436F8", Offset = "0x13436F8", VA = "0x13436F8", Slot = "43")]
		public int PS4Input_SpecialGetUsersHandles(int maxNumberControllers, int[] handles)
		{
			return default(int);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x1343700", Offset = "0x1343700", VA = "0x1343700", Slot = "44")]
		public int PS4Input_SpecialGetUsersHandles2(int maxNumberControllers, int[] handles)
		{
			return default(int);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x1343708", Offset = "0x1343708", VA = "0x1343708", Slot = "45")]
		public bool PS4Input_SpecialIsConnected(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x1343710", Offset = "0x1343710", VA = "0x1343710", Slot = "46")]
		public void PS4Input_SpecialResetLightSphere(int id)
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1343714", Offset = "0x1343714", VA = "0x1343714", Slot = "47")]
		public void PS4Input_SpecialResetOrientation(int id)
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1343718", Offset = "0x1343718", VA = "0x1343718", Slot = "48")]
		public void PS4Input_SpecialSetAngularVelocityDeadbandState(int id, bool bEnable)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x134371C", Offset = "0x134371C", VA = "0x134371C", Slot = "49")]
		public void PS4Input_SpecialSetLightSphere(int id, int red, int green, int blue)
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1343720", Offset = "0x1343720", VA = "0x1343720", Slot = "50")]
		public void PS4Input_SpecialSetMotionSensorState(int id, bool bEnable)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x1343724", Offset = "0x1343724", VA = "0x1343724", Slot = "51")]
		public void PS4Input_SpecialSetTiltCorrectionState(int id, bool bEnable)
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x1343728", Offset = "0x1343728", VA = "0x1343728", Slot = "52")]
		public void PS4Input_SpecialSetVibration(int id, int largeMotor, int smallMotor)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x134372C", Offset = "0x134372C", VA = "0x134372C", Slot = "53")]
		public Vector3 PS4Input_AimGetLastAcceleration(int id)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1343760", Offset = "0x1343760", VA = "0x1343760", Slot = "54")]
		public Vector3 PS4Input_AimGetLastGyro(int id)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x1343794", Offset = "0x1343794", VA = "0x1343794", Slot = "55")]
		public Vector4 PS4Input_AimGetLastOrientation(int id)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x13437C4", Offset = "0x13437C4", VA = "0x13437C4", Slot = "56")]
		public int PS4Input_AimGetUsersHandles(int maxNumberControllers, int[] handles)
		{
			return default(int);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x13437CC", Offset = "0x13437CC", VA = "0x13437CC", Slot = "57")]
		public int PS4Input_AimGetUsersHandles2(int maxNumberControllers, int[] handles)
		{
			return default(int);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x13437D4", Offset = "0x13437D4", VA = "0x13437D4", Slot = "58")]
		public bool PS4Input_AimIsConnected(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x13437DC", Offset = "0x13437DC", VA = "0x13437DC", Slot = "59")]
		public void PS4Input_AimResetLightSphere(int id)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x13437E0", Offset = "0x13437E0", VA = "0x13437E0", Slot = "60")]
		public void PS4Input_AimResetOrientation(int id)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x13437E4", Offset = "0x13437E4", VA = "0x13437E4", Slot = "61")]
		public void PS4Input_AimSetAngularVelocityDeadbandState(int id, bool bEnable)
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x13437E8", Offset = "0x13437E8", VA = "0x13437E8", Slot = "62")]
		public void PS4Input_AimSetLightSphere(int id, int red, int green, int blue)
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x13437EC", Offset = "0x13437EC", VA = "0x13437EC", Slot = "63")]
		public void PS4Input_AimSetMotionSensorState(int id, bool bEnable)
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x13437F0", Offset = "0x13437F0", VA = "0x13437F0", Slot = "64")]
		public void PS4Input_AimSetTiltCorrectionState(int id, bool bEnable)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x13437F4", Offset = "0x13437F4", VA = "0x13437F4", Slot = "65")]
		public void PS4Input_AimSetVibration(int id, int largeMotor, int smallMotor)
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x13437F8", Offset = "0x13437F8", VA = "0x13437F8", Slot = "66")]
		public Vector3 PS4Input_GetLastMoveAcceleration(int id, int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x134382C", Offset = "0x134382C", VA = "0x134382C", Slot = "67")]
		public Vector3 PS4Input_GetLastMoveGyro(int id, int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x1343860", Offset = "0x1343860", VA = "0x1343860", Slot = "68")]
		public int PS4Input_MoveGetButtons(int id, int index)
		{
			return default(int);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x1343868", Offset = "0x1343868", VA = "0x1343868", Slot = "69")]
		public int PS4Input_MoveGetAnalogButton(int id, int index)
		{
			return default(int);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x1343870", Offset = "0x1343870", VA = "0x1343870", Slot = "70")]
		public bool PS4Input_MoveIsConnected(int id, int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x1343878", Offset = "0x1343878", VA = "0x1343878", Slot = "71")]
		public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers, int[] primaryHandles, int[] secondaryHandles)
		{
			return default(int);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1343880", Offset = "0x1343880", VA = "0x1343880", Slot = "72")]
		public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers, int[] primaryHandles)
		{
			return default(int);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1343888", Offset = "0x1343888", VA = "0x1343888", Slot = "73")]
		public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers)
		{
			return default(int);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x1343890", Offset = "0x1343890", VA = "0x1343890", Slot = "74")]
		public IntPtr PS4Input_MoveGetControllerInputForTracking()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x13438D0", Offset = "0x13438D0", VA = "0x13438D0", Slot = "75")]
		public int PS4Input_MoveSetLightSphere(int id, int index, int red, int green, int blue)
		{
			return default(int);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x13438D8", Offset = "0x13438D8", VA = "0x13438D8", Slot = "76")]
		public int PS4Input_MoveSetVibration(int id, int index, int motor)
		{
			return default(int);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x13438E0", Offset = "0x13438E0", VA = "0x13438E0", Slot = "77")]
		public void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x1344358", Offset = "0x1344358", VA = "0x1344358", Slot = "78")]
		public int GetAndroidAPILevel()
		{
			return default(int);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x13445D0", Offset = "0x13445D0", VA = "0x13445D0", Slot = "79")]
		public bool UnityUI_Graphic_GetRaycastTarget(object graphic)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x1344720", Offset = "0x1344720", VA = "0x1344720", Slot = "80")]
		public void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value)
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x134487C", Offset = "0x134487C", VA = "0x134487C", Slot = "82")]
		public float UnityInput_GetTouchPressure(ref Touch touch)
		{
			return default(float);
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x1344888", Offset = "0x1344888", VA = "0x1344888", Slot = "83")]
		public float UnityInput_GetTouchMaximumPossiblePressure(ref Touch touch)
		{
			return default(float);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x1344894", Offset = "0x1344894", VA = "0x1344894", Slot = "84")]
		public IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload)
		{
			return null;
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x1344930", Offset = "0x1344930", VA = "0x1344930", Slot = "85")]
		public Type[] GetControllerTemplateTypes()
		{
			return null;
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x13449F4", Offset = "0x13449F4", VA = "0x13449F4", Slot = "86")]
		public Type[] GetControllerTemplateInterfaceTypes()
		{
			return null;
		}
	}
}
namespace Rewired.Data
{
	[Token(Token = "0x200003C")]
	public class UserDataStore_PlayerPrefs : UserDataStore
	{
		[Token(Token = "0x20000A0")]
		private class ControllerAssignmentSaveInfo
		{
			[Token(Token = "0x200010B")]
			public class PlayerInfo
			{
				[Token(Token = "0x400070F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public int id;

				[Token(Token = "0x4000710")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public bool hasKeyboard;

				[Token(Token = "0x4000711")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
				public bool hasMouse;

				[Token(Token = "0x4000712")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public JoystickInfo[] joysticks;

				[Token(Token = "0x17000372")]
				public int joystickCount
				{
					[Token(Token = "0x6000A15")]
					[Address(RVA = "0x23A05D4", Offset = "0x23A05D4", VA = "0x23A05D4")]
					get
					{
						return default(int);
					}
				}

				[Token(Token = "0x6000A16")]
				[Address(RVA = "0x23A05E8", Offset = "0x23A05E8", VA = "0x23A05E8")]
				public int IndexOfJoystick(int joystickId)
				{
					return default(int);
				}

				[Token(Token = "0x6000A17")]
				[Address(RVA = "0x23A06A0", Offset = "0x23A06A0", VA = "0x23A06A0")]
				public bool ContainsJoystick(int joystickId)
				{
					return default(bool);
				}

				[Token(Token = "0x6000A18")]
				[Address(RVA = "0x239B22C", Offset = "0x239B22C", VA = "0x239B22C")]
				public PlayerInfo()
				{
				}
			}

			[Token(Token = "0x200010C")]
			public class JoystickInfo
			{
				[Token(Token = "0x4000713")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public Guid instanceGuid;

				[Token(Token = "0x4000714")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public string hardwareIdentifier;

				[Token(Token = "0x4000715")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				public int id;

				[Token(Token = "0x6000A19")]
				[Address(RVA = "0x23A05CC", Offset = "0x23A05CC", VA = "0x23A05CC")]
				public JoystickInfo()
				{
				}
			}

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public PlayerInfo[] players;

			[Token(Token = "0x1700031E")]
			public int playerCount
			{
				[Token(Token = "0x60008CB")]
				[Address(RVA = "0x239B0D4", Offset = "0x239B0D4", VA = "0x239B0D4")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x60008CC")]
			[Address(RVA = "0x239B0E8", Offset = "0x239B0E8", VA = "0x239B0E8")]
			public ControllerAssignmentSaveInfo()
			{
			}

			[Token(Token = "0x60008CD")]
			[Address(RVA = "0x239B0F0", Offset = "0x239B0F0", VA = "0x239B0F0")]
			public ControllerAssignmentSaveInfo(int playerCount)
			{
			}

			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x239B234", Offset = "0x239B234", VA = "0x239B234")]
			public int IndexOfPlayer(int playerId)
			{
				return default(int);
			}

			[Token(Token = "0x60008CF")]
			[Address(RVA = "0x239B2EC", Offset = "0x239B2EC", VA = "0x239B2EC")]
			public bool ContainsPlayer(int playerId)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000A1")]
		private class JoystickAssignmentHistoryInfo
		{
			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public readonly Joystick joystick;

			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public readonly int oldJoystickId;

			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x239B304", Offset = "0x239B304", VA = "0x239B304")]
			public JoystickAssignmentHistoryInfo(Joystick joystick, int oldJoystickId)
			{
			}
		}

		[Token(Token = "0x20000A2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C02C", Offset = "0x59C02C")]
		private sealed class <>c__DisplayClass78_0
		{
			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Joystick joystick;

			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x239ADE0", Offset = "0x239ADE0", VA = "0x239ADE0")]
			public <>c__DisplayClass78_0()
			{
			}

			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x239ADE8", Offset = "0x239ADE8", VA = "0x239ADE8")]
			internal bool <LoadJoystickAssignmentsNow>b__0(JoystickAssignmentHistoryInfo x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C03C", Offset = "0x59C03C")]
		private sealed class <>c__DisplayClass78_1
		{
			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ControllerAssignmentSaveInfo.JoystickInfo joystickInfo;

			[Token(Token = "0x60008D3")]
			[Address(RVA = "0x239AE1C", Offset = "0x239AE1C", VA = "0x239AE1C")]
			public <>c__DisplayClass78_1()
			{
			}

			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x239AE24", Offset = "0x239AE24", VA = "0x239AE24")]
			internal bool <LoadJoystickAssignmentsNow>b__1(JoystickAssignmentHistoryInfo x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C04C", Offset = "0x59C04C")]
		private sealed class <>c__DisplayClass78_2
		{
			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Joystick match;

			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x239AE68", Offset = "0x239AE68", VA = "0x239AE68")]
			public <>c__DisplayClass78_2()
			{
			}

			[Token(Token = "0x60008D6")]
			[Address(RVA = "0x239AE70", Offset = "0x239AE70", VA = "0x239AE70")]
			internal bool <LoadJoystickAssignmentsNow>b__2(JoystickAssignmentHistoryInfo x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000A5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C05C", Offset = "0x59C05C")]
		private sealed class <LoadJoystickAssignmentsDeferred>d__80 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UserDataStore_PlayerPrefs <>4__this;

			[Token(Token = "0x1700031F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008DA")]
				[Address(RVA = "0x239B07C", Offset = "0x239B07C", VA = "0x239B07C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000320")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008DC")]
				[Address(RVA = "0x239B0CC", Offset = "0x239B0CC", VA = "0x239B0CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x239AEA4", Offset = "0x239AEA4", VA = "0x239AEA4")]
			[DebuggerHidden]
			public <LoadJoystickAssignmentsDeferred>d__80(int <>1__state)
			{
			}

			[Token(Token = "0x60008D8")]
			[Address(RVA = "0x239AEC4", Offset = "0x239AEC4", VA = "0x239AEC4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008D9")]
			[Address(RVA = "0x239AEC8", Offset = "0x239AEC8", VA = "0x239AEC8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008DB")]
			[Address(RVA = "0x239B084", Offset = "0x239B084", VA = "0x239B084", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000319")]
		private const string thisScriptName = "UserDataStore_PlayerPrefs";

		[Token(Token = "0x400031A")]
		private const string logPrefix = "Rewired: ";

		[Token(Token = "0x400031B")]
		private const string editorLoadedMessage = "\n***IMPORTANT:*** Changes made to the Rewired Input Manager configuration after the last time XML data was saved WILL NOT be used because the loaded old saved data has overwritten these values. If you change something in the Rewired Input Manager such as a Joystick Map or Input Behavior settings, you will not see these changes reflected in the current configuration. Clear PlayerPrefs using the inspector option on the UserDataStore_PlayerPrefs component.";

		[Token(Token = "0x400031C")]
		private const string playerPrefsKeySuffix_controllerAssignments = "ControllerAssignments";

		[Token(Token = "0x400031D")]
		private const int controllerMapPPKeyVersion_original = 0;

		[Token(Token = "0x400031E")]
		private const int controllerMapPPKeyVersion_includeDuplicateJoystickIndex = 1;

		[Token(Token = "0x400031F")]
		private const int controllerMapPPKeyVersion_supportDisconnectedControllers = 2;

		[Token(Token = "0x4000320")]
		private const int controllerMapPPKeyVersion_includeFormatVersion = 2;

		[Token(Token = "0x4000321")]
		private const int controllerMapPPKeyVersion = 2;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C930", Offset = "0x59C930")]
		[SerializeField]
		private bool isEnabled;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C978", Offset = "0x59C978")]
		[SerializeField]
		private bool loadDataOnStart;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C9C0", Offset = "0x59C9C0")]
		[SerializeField]
		private bool loadJoystickAssignments;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CA08", Offset = "0x59CA08")]
		[SerializeField]
		private bool loadKeyboardAssignments;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CA50", Offset = "0x59CA50")]
		[SerializeField]
		private bool loadMouseAssignments;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CA98", Offset = "0x59CA98")]
		[SerializeField]
		private string playerPrefsKeyPrefix;

		[NonSerialized]
		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool allowImpreciseJoystickAssignmentMatching;

		[NonSerialized]
		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool deferredJoystickAssignmentLoadPending;

		[NonSerialized]
		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		private bool wasJoystickEverDetected;

		[NonSerialized]
		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private List<int> __allActionIds;

		[NonSerialized]
		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string __allActionIdsString;

		[Token(Token = "0x17000249")]
		public bool IsEnabled
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x1A1D2F0", Offset = "0x1A1D2F0", VA = "0x1A1D2F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x1A1D2F8", Offset = "0x1A1D2F8", VA = "0x1A1D2F8")]
			set
			{
			}
		}

		[Token(Token = "0x1700024A")]
		public bool LoadDataOnStart
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x1A1D300", Offset = "0x1A1D300", VA = "0x1A1D300")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x1A1D308", Offset = "0x1A1D308", VA = "0x1A1D308")]
			set
			{
			}
		}

		[Token(Token = "0x1700024B")]
		public bool LoadJoystickAssignments
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x1A1D310", Offset = "0x1A1D310", VA = "0x1A1D310")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x1A1D318", Offset = "0x1A1D318", VA = "0x1A1D318")]
			set
			{
			}
		}

		[Token(Token = "0x1700024C")]
		public bool LoadKeyboardAssignments
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x1A1D320", Offset = "0x1A1D320", VA = "0x1A1D320")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x1A1D328", Offset = "0x1A1D328", VA = "0x1A1D328")]
			set
			{
			}
		}

		[Token(Token = "0x1700024D")]
		public bool LoadMouseAssignments
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x1A1D330", Offset = "0x1A1D330", VA = "0x1A1D330")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x1A1D338", Offset = "0x1A1D338", VA = "0x1A1D338")]
			set
			{
			}
		}

		[Token(Token = "0x1700024E")]
		public string PlayerPrefsKeyPrefix
		{
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x1A1D340", Offset = "0x1A1D340", VA = "0x1A1D340")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x1A1D348", Offset = "0x1A1D348", VA = "0x1A1D348")]
			set
			{
			}
		}

		[Token(Token = "0x1700024F")]
		private string playerPrefsKey_controllerAssignments
		{
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x1A1D350", Offset = "0x1A1D350", VA = "0x1A1D350")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000250")]
		private bool loadControllerAssignments
		{
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x1A1D3CC", Offset = "0x1A1D3CC", VA = "0x1A1D3CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000251")]
		private List<int> allActionIds
		{
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x1A1D3FC", Offset = "0x1A1D3FC", VA = "0x1A1D3FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000252")]
		private string allActionIdsString
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x1A1D698", Offset = "0x1A1D698", VA = "0x1A1D698")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x1A1D810", Offset = "0x1A1D810", VA = "0x1A1D810", Slot = "21")]
		public override void Save()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x1A1DAE4", Offset = "0x1A1DAE4", VA = "0x1A1DAE4", Slot = "22")]
		public override void SaveControllerData(int playerId, ControllerType controllerType, int controllerId)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x1A1DC00", Offset = "0x1A1DC00", VA = "0x1A1DC00", Slot = "23")]
		public override void SaveControllerData(ControllerType controllerType, int controllerId)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x1A1DCF0", Offset = "0x1A1DCF0", VA = "0x1A1DCF0", Slot = "24")]
		public override void SavePlayerData(int playerId)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x1A1DE54", Offset = "0x1A1DE54", VA = "0x1A1DE54", Slot = "25")]
		public override void SaveInputBehavior(int playerId, int behaviorId)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x1A1E02C", Offset = "0x1A1E02C", VA = "0x1A1E02C", Slot = "16")]
		public override void Load()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x1A1E308", Offset = "0x1A1E308", VA = "0x1A1E308", Slot = "17")]
		public override void LoadControllerData(int playerId, ControllerType controllerType, int controllerId)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x1A1E42C", Offset = "0x1A1E42C", VA = "0x1A1E42C", Slot = "18")]
		public override void LoadControllerData(ControllerType controllerType, int controllerId)
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x1A1E508", Offset = "0x1A1E508", VA = "0x1A1E508", Slot = "19")]
		public override void LoadPlayerData(int playerId)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x1A1E664", Offset = "0x1A1E664", VA = "0x1A1E664", Slot = "20")]
		public override void LoadInputBehavior(int playerId, int behaviorId)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1A1E838", Offset = "0x1A1E838", VA = "0x1A1E838", Slot = "28")]
		protected override void OnInitialize()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x1A1F028", Offset = "0x1A1F028", VA = "0x1A1F028", Slot = "29")]
		protected override void OnControllerConnected(ControllerStatusChangedEventArgs args)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1A1F3BC", Offset = "0x1A1F3BC", VA = "0x1A1F3BC", Slot = "32")]
		protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1A1F64C", Offset = "0x1A1F64C", VA = "0x1A1F64C", Slot = "30")]
		protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1A1F690", Offset = "0x1A1F690", VA = "0x1A1F690", Slot = "26")]
		public override void SaveControllerMap(int playerId, ControllerMap controllerMap)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1A1F9CC", Offset = "0x1A1F9CC", VA = "0x1A1F9CC", Slot = "27")]
		public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			return null;
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x1A1E0DC", Offset = "0x1A1E0DC", VA = "0x1A1E0DC")]
		private int LoadAll()
		{
			return default(int);
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x1A1E5C0", Offset = "0x1A1E5C0", VA = "0x1A1E5C0")]
		private int LoadPlayerDataNow(int playerId)
		{
			return default(int);
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x1A1FDD0", Offset = "0x1A1FDD0", VA = "0x1A1FDD0")]
		private int LoadPlayerDataNow(Player player)
		{
			return default(int);
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x1A201D4", Offset = "0x1A201D4", VA = "0x1A201D4")]
		private int LoadAllJoystickCalibrationData()
		{
			return default(int);
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x1A20D10", Offset = "0x1A20D10", VA = "0x1A20D10")]
		private int LoadJoystickCalibrationData(Joystick joystick)
		{
			return default(int);
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x1A20DCC", Offset = "0x1A20DCC", VA = "0x1A20DCC")]
		private int LoadJoystickCalibrationData(int joystickId)
		{
			return default(int);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1A1F0CC", Offset = "0x1A1F0CC", VA = "0x1A1F0CC")]
		private int LoadJoystickData(int joystickId)
		{
			return default(int);
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x1A1E3DC", Offset = "0x1A1E3DC", VA = "0x1A1E3DC")]
		private int LoadControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
		{
			return default(int);
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1A1E4F4", Offset = "0x1A1E4F4", VA = "0x1A1E4F4")]
		private int LoadControllerDataNow(ControllerType controllerType, int controllerId)
		{
			return default(int);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x1A20630", Offset = "0x1A20630", VA = "0x1A20630")]
		private int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId)
		{
			return default(int);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x1A1FAE0", Offset = "0x1A1FAE0", VA = "0x1A1FAE0")]
		private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			return null;
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x1A203C8", Offset = "0x1A203C8", VA = "0x1A203C8")]
		private int LoadInputBehaviors(int playerId)
		{
			return default(int);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x1A1E724", Offset = "0x1A1E724", VA = "0x1A1E724")]
		private int LoadInputBehaviorNow(int playerId, int behaviorId)
		{
			return default(int);
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x1A219A8", Offset = "0x1A219A8", VA = "0x1A219A8")]
		private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior)
		{
			return default(int);
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x1A1FCE0", Offset = "0x1A1FCE0", VA = "0x1A1FCE0")]
		private bool LoadControllerAssignmentsNow()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1A21C8C", Offset = "0x1A21C8C", VA = "0x1A21C8C")]
		private bool LoadKeyboardAndMouseAssignmentsNow(ControllerAssignmentSaveInfo data)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x1A22254", Offset = "0x1A22254", VA = "0x1A22254")]
		private bool LoadJoystickAssignmentsNow(ControllerAssignmentSaveInfo data)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x1A21AF0", Offset = "0x1A21AF0", VA = "0x1A21AF0")]
		private ControllerAssignmentSaveInfo LoadControllerAssignmentData()
		{
			return null;
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1A1F338", Offset = "0x1A1F338", VA = "0x1A1F338")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5A0A30", Offset = "0x5A0A30")]
		private IEnumerator LoadJoystickAssignmentsDeferred()
		{
			return null;
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1A1D8C0", Offset = "0x1A1D8C0", VA = "0x1A1D8C0")]
		private void SaveAll()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x1A1DDA8", Offset = "0x1A1DDA8", VA = "0x1A1DDA8")]
		private void SavePlayerDataNow(int playerId)
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x1A23F74", Offset = "0x1A23F74", VA = "0x1A23F74")]
		private void SavePlayerDataNow(Player player)
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x1A23FEC", Offset = "0x1A23FEC", VA = "0x1A23FEC")]
		private void SaveAllJoystickCalibrationData()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1A24628", Offset = "0x1A24628", VA = "0x1A24628")]
		private void SaveJoystickCalibrationData(int joystickId)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1A245B4", Offset = "0x1A245B4", VA = "0x1A245B4")]
		private void SaveJoystickCalibrationData(Joystick joystick)
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1A1F404", Offset = "0x1A1F404", VA = "0x1A1F404")]
		private void SaveJoystickData(int joystickId)
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1A1DBB8", Offset = "0x1A1DBB8", VA = "0x1A1DBB8")]
		private void SaveControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1A1DCCC", Offset = "0x1A1DCCC", VA = "0x1A1DCCC")]
		private void SaveControllerDataNow(ControllerType controllerType, int controllerId)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x1A24240", Offset = "0x1A24240", VA = "0x1A24240")]
		private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData)
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x1A248BC", Offset = "0x1A248BC", VA = "0x1A248BC")]
		private void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1A1F750", Offset = "0x1A1F750", VA = "0x1A1F750")]
		private void SaveControllerMap(Player player, ControllerMap controllerMap)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1A241D4", Offset = "0x1A241D4", VA = "0x1A241D4")]
		private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1A1DF14", Offset = "0x1A1DF14", VA = "0x1A1DF14")]
		private void SaveInputBehaviorNow(int playerId, int behaviorId)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1A24CB0", Offset = "0x1A24CB0", VA = "0x1A24CB0")]
		private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1A1E924", Offset = "0x1A1E924", VA = "0x1A1E924")]
		private bool SaveControllerAssignments()
		{
			return default(bool);
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1A24DA8", Offset = "0x1A24DA8", VA = "0x1A24DA8")]
		private bool ControllerAssignmentSaveDataExists()
		{
			return default(bool);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1A24DF0", Offset = "0x1A24DF0", VA = "0x1A24DF0")]
		private string GetBasePlayerPrefsKey(Player player)
		{
			return null;
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1A24A48", Offset = "0x1A24A48", VA = "0x1A24A48")]
		private string GetControllerMapPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
		{
			return null;
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1A24B7C", Offset = "0x1A24B7C", VA = "0x1A24B7C")]
		private string GetControllerMapKnownActionIdsPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
		{
			return null;
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1A24E70", Offset = "0x1A24E70", VA = "0x1A24E70")]
		private static string GetControllerMapPlayerPrefsKeyCommonSuffix(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
		{
			return null;
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1A246CC", Offset = "0x1A246CC", VA = "0x1A246CC")]
		private string GetJoystickCalibrationMapPlayerPrefsKey(Joystick joystick)
		{
			return null;
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1A24CF4", Offset = "0x1A24CF4", VA = "0x1A24CF4")]
		private string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId)
		{
			return null;
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x1A20E70", Offset = "0x1A20E70", VA = "0x1A20E70")]
		private string GetControllerMapXml(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			return null;
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x1A20F60", Offset = "0x1A20F60", VA = "0x1A20F60")]
		private List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			return null;
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1A20D40", Offset = "0x1A20D40", VA = "0x1A20D40")]
		private string GetJoystickCalibrationMapXml(Joystick joystick)
		{
			return null;
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x1A21A5C", Offset = "0x1A21A5C", VA = "0x1A21A5C")]
		private string GetInputBehaviorXml(Player player, int id)
		{
			return null;
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1A211F0", Offset = "0x1A211F0", VA = "0x1A211F0")]
		private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1A237F8", Offset = "0x1A237F8", VA = "0x1A237F8")]
		private Joystick FindJoystickPrecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo)
		{
			return null;
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1A23BCC", Offset = "0x1A23BCC", VA = "0x1A23BCC")]
		private bool TryFindJoysticksImprecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Joystick> matches)
		{
			return default(bool);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x1A2567C", Offset = "0x1A2567C", VA = "0x1A2567C")]
		private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier)
		{
			return default(int);
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x1A20C34", Offset = "0x1A20C34", VA = "0x1A20C34")]
		private void RefreshLayoutManager(int playerId)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x1A25430", Offset = "0x1A25430", VA = "0x1A25430")]
		private static Type GetControllerMapType(ControllerType controllerType)
		{
			return null;
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x1A25DAC", Offset = "0x1A25DAC", VA = "0x1A25DAC")]
		public UserDataStore_PlayerPrefs()
		{
		}
	}
}
namespace Rewired.Internal
{
	[Token(Token = "0x200003D")]
	public static class ControllerTemplateFactory
	{
		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Type[] _defaultTemplateTypes;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly Type[] _defaultTemplateInterfaceTypes;

		[Token(Token = "0x17000253")]
		public static Type[] templateTypes
		{
			[Token(Token = "0x600040F")]
			[Address(RVA = "0x133D1D8", Offset = "0x133D1D8", VA = "0x133D1D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000254")]
		public static Type[] templateInterfaceTypes
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x133D24C", Offset = "0x133D24C", VA = "0x133D24C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x133D2C0", Offset = "0x133D2C0", VA = "0x133D2C0")]
		public static IControllerTemplate Create(Guid typeGuid, object payload)
		{
			return null;
		}
	}
}
namespace Rewired.Integration.UnityUI
{
	[Token(Token = "0x200003E")]
	public class PlayerPointerEventData : PointerEventData
	{
		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59CAE0", Offset = "0x59CAE0")]
		private int <playerId>k__BackingField;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59CAF0", Offset = "0x59CAF0")]
		private int <inputSourceIndex>k__BackingField;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59CB00", Offset = "0x59CB00")]
		private IMouseInputSource <mouseSource>k__BackingField;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59CB10", Offset = "0x59CB10")]
		private ITouchInputSource <touchSource>k__BackingField;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59CB20", Offset = "0x59CB20")]
		private PointerEventType <sourceType>k__BackingField;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59CB30", Offset = "0x59CB30")]
		private int <buttonIndex>k__BackingField;

		[Token(Token = "0x17000255")]
		public int playerId
		{
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x1AB3498", Offset = "0x1AB3498", VA = "0x1AB3498")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0A9C", Offset = "0x5A0A9C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000414")]
			[Address(RVA = "0x1AB34A0", Offset = "0x1AB34A0", VA = "0x1AB34A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0AAC", Offset = "0x5A0AAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000256")]
		public int inputSourceIndex
		{
			[Token(Token = "0x6000415")]
			[Address(RVA = "0x1AB34A8", Offset = "0x1AB34A8", VA = "0x1AB34A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0ABC", Offset = "0x5A0ABC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000416")]
			[Address(RVA = "0x1AB34B0", Offset = "0x1AB34B0", VA = "0x1AB34B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0ACC", Offset = "0x5A0ACC")]
			set
			{
			}
		}

		[Token(Token = "0x17000257")]
		public IMouseInputSource mouseSource
		{
			[Token(Token = "0x6000417")]
			[Address(RVA = "0x1AB34B8", Offset = "0x1AB34B8", VA = "0x1AB34B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0ADC", Offset = "0x5A0ADC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000418")]
			[Address(RVA = "0x1AB34C0", Offset = "0x1AB34C0", VA = "0x1AB34C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0AEC", Offset = "0x5A0AEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000258")]
		public ITouchInputSource touchSource
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0x1AB34C8", Offset = "0x1AB34C8", VA = "0x1AB34C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0AFC", Offset = "0x5A0AFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600041A")]
			[Address(RVA = "0x1AB34D0", Offset = "0x1AB34D0", VA = "0x1AB34D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0B0C", Offset = "0x5A0B0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000259")]
		public PointerEventType sourceType
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x1AB34D8", Offset = "0x1AB34D8", VA = "0x1AB34D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0B1C", Offset = "0x5A0B1C")]
			get
			{
				return default(PointerEventType);
			}
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x1AB34E0", Offset = "0x1AB34E0", VA = "0x1AB34E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0B2C", Offset = "0x5A0B2C")]
			set
			{
			}
		}

		[Token(Token = "0x1700025A")]
		public int buttonIndex
		{
			[Token(Token = "0x600041D")]
			[Address(RVA = "0x1AB34E8", Offset = "0x1AB34E8", VA = "0x1AB34E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0B3C", Offset = "0x5A0B3C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600041E")]
			[Address(RVA = "0x1AB34F0", Offset = "0x1AB34F0", VA = "0x1AB34F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0B4C", Offset = "0x5A0B4C")]
			set
			{
			}
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x1AB34F8", Offset = "0x1AB34F8", VA = "0x1AB34F8")]
		public PlayerPointerEventData(EventSystem eventSystem)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x1AB3520", Offset = "0x1AB3520", VA = "0x1AB3520", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59B6E4", Offset = "0x59B6E4")]
	public class RewiredEventSystem : EventSystem
	{
		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CB40", Offset = "0x59CB40")]
		[SerializeField]
		private bool _alwaysUpdate;

		[Token(Token = "0x1700025B")]
		public bool alwaysUpdate
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x1AB5DCC", Offset = "0x1AB5DCC", VA = "0x1AB5DCC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x1AB5DD4", Offset = "0x1AB5DD4", VA = "0x1AB5DD4")]
			set
			{
			}
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1AB5DDC", Offset = "0x1AB5DDC", VA = "0x1AB5DDC", Slot = "18")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x1AB5FD8", Offset = "0x1AB5FD8", VA = "0x1AB5FD8")]
		public RewiredEventSystem()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public abstract class RewiredPointerInputModule : BaseInputModule
	{
		[Token(Token = "0x20000A6")]
		protected class MouseState
		{
			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private List<ButtonState> m_TrackedButtons;

			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x2391F24", Offset = "0x2391F24", VA = "0x2391F24")]
			public bool AnyPressesThisFrame()
			{
				return default(bool);
			}

			[Token(Token = "0x60008DE")]
			[Address(RVA = "0x2392000", Offset = "0x2392000", VA = "0x2392000")]
			public bool AnyReleasesThisFrame()
			{
				return default(bool);
			}

			[Token(Token = "0x60008DF")]
			[Address(RVA = "0x23920DC", Offset = "0x23920DC", VA = "0x23920DC")]
			public ButtonState GetButtonState(int button)
			{
				return null;
			}

			[Token(Token = "0x60008E0")]
			[Address(RVA = "0x23922A4", Offset = "0x23922A4", VA = "0x23922A4")]
			public void SetButtonState(int button, PointerEventData.FramePressState stateForMouseButton, PlayerPointerEventData data)
			{
			}

			[Token(Token = "0x60008E1")]
			[Address(RVA = "0x2392300", Offset = "0x2392300", VA = "0x2392300")]
			public MouseState()
			{
			}
		}

		[Token(Token = "0x20000A7")]
		public class MouseButtonEventData
		{
			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public PointerEventData.FramePressState buttonState;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public PlayerPointerEventData buttonData;

			[Token(Token = "0x60008E2")]
			[Address(RVA = "0x2391EEC", Offset = "0x2391EEC", VA = "0x2391EEC")]
			public bool PressedThisFrame()
			{
				return default(bool);
			}

			[Token(Token = "0x60008E3")]
			[Address(RVA = "0x2391F04", Offset = "0x2391F04", VA = "0x2391F04")]
			public bool ReleasedThisFrame()
			{
				return default(bool);
			}

			[Token(Token = "0x60008E4")]
			[Address(RVA = "0x2391F1C", Offset = "0x2391F1C", VA = "0x2391F1C")]
			public MouseButtonEventData()
			{
			}
		}

		[Token(Token = "0x20000A8")]
		protected class ButtonState
		{
			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int m_Button;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private MouseButtonEventData m_EventData;

			[Token(Token = "0x17000321")]
			public MouseButtonEventData eventData
			{
				[Token(Token = "0x60008E5")]
				[Address(RVA = "0x2391EC4", Offset = "0x2391EC4", VA = "0x2391EC4")]
				get
				{
					return null;
				}
				[Token(Token = "0x60008E6")]
				[Address(RVA = "0x2391ECC", Offset = "0x2391ECC", VA = "0x2391ECC")]
				set
				{
				}
			}

			[Token(Token = "0x17000322")]
			public int button
			{
				[Token(Token = "0x60008E7")]
				[Address(RVA = "0x2391ED4", Offset = "0x2391ED4", VA = "0x2391ED4")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60008E8")]
				[Address(RVA = "0x2391EDC", Offset = "0x2391EDC", VA = "0x2391EDC")]
				set
				{
				}
			}

			[Token(Token = "0x60008E9")]
			[Address(RVA = "0x2391EE4", Offset = "0x2391EE4", VA = "0x2391EE4")]
			public ButtonState()
			{
			}
		}

		[Token(Token = "0x20000A9")]
		private sealed class UnityInputSource : IMouseInputSource, ITouchInputSource
		{
			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private Vector2 m_MousePosition;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Vector2 m_MousePositionPrev;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private int m_LastUpdatedFrame;

			[Token(Token = "0x17000323")]
			private int Rewired.UI.IMouseInputSource.playerId
			{
				[Token(Token = "0x60008EA")]
				[Address(RVA = "0x239239C", Offset = "0x239239C", VA = "0x239239C", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000324")]
			private int Rewired.UI.ITouchInputSource.playerId
			{
				[Token(Token = "0x60008EB")]
				[Address(RVA = "0x2392410", Offset = "0x2392410", VA = "0x2392410", Slot = "14")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000325")]
			private bool Rewired.UI.IMouseInputSource.enabled
			{
				[Token(Token = "0x60008EC")]
				[Address(RVA = "0x2392424", Offset = "0x2392424", VA = "0x2392424", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000326")]
			private bool Rewired.UI.IMouseInputSource.locked
			{
				[Token(Token = "0x60008ED")]
				[Address(RVA = "0x2392438", Offset = "0x2392438", VA = "0x2392438", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000327")]
			private int Rewired.UI.IMouseInputSource.buttonCount
			{
				[Token(Token = "0x60008EE")]
				[Address(RVA = "0x239245C", Offset = "0x239245C", VA = "0x239245C", Slot = "7")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000328")]
			private Vector2 Rewired.UI.IMouseInputSource.screenPosition
			{
				[Token(Token = "0x60008F2")]
				[Address(RVA = "0x23924D0", Offset = "0x23924D0", VA = "0x23924D0", Slot = "11")]
				get
				{
					return default(Vector2);
				}
			}

			[Token(Token = "0x17000329")]
			private Vector2 Rewired.UI.IMouseInputSource.screenPositionDelta
			{
				[Token(Token = "0x60008F3")]
				[Address(RVA = "0x2392504", Offset = "0x2392504", VA = "0x2392504", Slot = "12")]
				get
				{
					return default(Vector2);
				}
			}

			[Token(Token = "0x1700032A")]
			private Vector2 Rewired.UI.IMouseInputSource.wheelDelta
			{
				[Token(Token = "0x60008F4")]
				[Address(RVA = "0x2392540", Offset = "0x2392540", VA = "0x2392540", Slot = "13")]
				get
				{
					return default(Vector2);
				}
			}

			[Token(Token = "0x1700032B")]
			private bool Rewired.UI.ITouchInputSource.touchSupported
			{
				[Token(Token = "0x60008F5")]
				[Address(RVA = "0x2392574", Offset = "0x2392574", VA = "0x2392574", Slot = "15")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700032C")]
			private int Rewired.UI.ITouchInputSource.touchCount
			{
				[Token(Token = "0x60008F6")]
				[Address(RVA = "0x239258C", Offset = "0x239258C", VA = "0x239258C", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x60008EF")]
			[Address(RVA = "0x2392470", Offset = "0x2392470", VA = "0x2392470", Slot = "8")]
			private bool Rewired.UI.IMouseInputSource.GetButtonDown(int button)
			{
				return default(bool);
			}

			[Token(Token = "0x60008F0")]
			[Address(RVA = "0x2392490", Offset = "0x2392490", VA = "0x2392490", Slot = "9")]
			private bool Rewired.UI.IMouseInputSource.GetButtonUp(int button)
			{
				return default(bool);
			}

			[Token(Token = "0x60008F1")]
			[Address(RVA = "0x23924B0", Offset = "0x23924B0", VA = "0x23924B0", Slot = "10")]
			private bool Rewired.UI.IMouseInputSource.GetButton(int button)
			{
				return default(bool);
			}

			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x23925A4", Offset = "0x23925A4", VA = "0x23925A4", Slot = "17")]
			private Touch Rewired.UI.ITouchInputSource.GetTouch(int index)
			{
				return default(Touch);
			}

			[Token(Token = "0x60008F8")]
			[Address(RVA = "0x23923B0", Offset = "0x23923B0", VA = "0x23923B0")]
			private void TryUpdate()
			{
			}

			[Token(Token = "0x60008F9")]
			[Address(RVA = "0x23925EC", Offset = "0x23925EC", VA = "0x23925EC")]
			public UnityInputSource()
			{
			}
		}

		[Token(Token = "0x4000336")]
		public const int kMouseLeftId = -1;

		[Token(Token = "0x4000337")]
		public const int kMouseRightId = -2;

		[Token(Token = "0x4000338")]
		public const int kMouseMiddleId = -3;

		[Token(Token = "0x4000339")]
		public const int kFakeTouchesId = -4;

		[Token(Token = "0x400033A")]
		private const int customButtonsStartingId = -2147483520;

		[Token(Token = "0x400033B")]
		private const int customButtonsMaxCount = 128;

		[Token(Token = "0x400033C")]
		private const int customButtonsLastId = -2147483392;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private readonly List<IMouseInputSource> m_MouseInputSourcesList;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<int, Dictionary<int, PlayerPointerEventData>[]> m_PlayerPointerData;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private ITouchInputSource m_UserDefaultTouchInputSource;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private UnityInputSource __m_DefaultInputSource;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private readonly MouseState m_MouseState;

		[Token(Token = "0x1700025C")]
		private UnityInputSource defaultInputSource
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x1AB6050", Offset = "0x1AB6050", VA = "0x1AB6050")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700025D")]
		private IMouseInputSource defaultMouseInputSource
		{
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x1AB60D0", Offset = "0x1AB60D0", VA = "0x1AB60D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700025E")]
		protected ITouchInputSource defaultTouchInputSource
		{
			[Token(Token = "0x6000427")]
			[Address(RVA = "0x1AB60D4", Offset = "0x1AB60D4", VA = "0x1AB60D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700025F")]
		protected virtual bool isMouseSupported
		{
			[Token(Token = "0x6000432")]
			[Address(RVA = "0x1AB6AC4", Offset = "0x1AB6AC4", VA = "0x1AB6AC4", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1AB60D8", Offset = "0x1AB60D8", VA = "0x1AB60D8")]
		protected bool IsDefaultMouse(IMouseInputSource mouse)
		{
			return default(bool);
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1AB60F8", Offset = "0x1AB60F8", VA = "0x1AB60F8")]
		public IMouseInputSource GetMouseInputSource(int playerId, int mouseIndex)
		{
			return null;
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x1AB63CC", Offset = "0x1AB63CC", VA = "0x1AB63CC")]
		public void RemoveMouseInputSource(IMouseInputSource source)
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x1AB649C", Offset = "0x1AB649C", VA = "0x1AB649C")]
		public void AddMouseInputSource(IMouseInputSource source)
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x1AB65D0", Offset = "0x1AB65D0", VA = "0x1AB65D0")]
		public int GetMouseInputSourceCount(int playerId)
		{
			return default(int);
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1AB6804", Offset = "0x1AB6804", VA = "0x1AB6804")]
		public ITouchInputSource GetTouchInputSource(int playerId, int sourceIndex)
		{
			return null;
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1AB68B4", Offset = "0x1AB68B4", VA = "0x1AB68B4")]
		public void RemoveTouchInputSource(ITouchInputSource source)
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1AB6938", Offset = "0x1AB6938", VA = "0x1AB6938")]
		public void AddTouchInputSource(ITouchInputSource source)
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x1AB6A40", Offset = "0x1AB6A40", VA = "0x1AB6A40")]
		public int GetTouchInputSourceCount(int playerId)
		{
			return default(int);
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x1AB6A5C", Offset = "0x1AB6A5C", VA = "0x1AB6A5C")]
		protected void ClearMouseInputSources()
		{
		}

		[Token(Token = "0x6000433")]
		protected abstract bool IsDefaultPlayer(int playerId);

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1AB6CC0", Offset = "0x1AB6CC0", VA = "0x1AB6CC0")]
		protected bool GetPointerData(int playerId, int pointerIndex, int pointerTypeId, out PlayerPointerEventData data, bool create, PointerEventType pointerEventType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x1AB7214", Offset = "0x1AB7214", VA = "0x1AB7214")]
		private PlayerPointerEventData CreatePointerEventData(int playerId, int pointerIndex, int pointerTypeId, PointerEventType pointerEventType)
		{
			return null;
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1AB7350", Offset = "0x1AB7350", VA = "0x1AB7350")]
		protected void RemovePointerData(PlayerPointerEventData data)
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1AB747C", Offset = "0x1AB747C", VA = "0x1AB747C")]
		protected PlayerPointerEventData GetTouchPointerEventData(int playerId, int touchDeviceIndex, Touch input, out bool pressed, out bool released)
		{
			return null;
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1AB7780", Offset = "0x1AB7780", VA = "0x1AB7780", Slot = "28")]
		protected virtual MouseState GetMousePointerEventData(int playerId, int mouseIndex)
		{
			return null;
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x1AB82C0", Offset = "0x1AB82C0", VA = "0x1AB82C0")]
		protected PlayerPointerEventData GetLastPointerEventData(int playerId, int pointerIndex, int pointerTypeId, bool ignorePointerTypeId, PointerEventType pointerEventType)
		{
			return null;
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1AB8500", Offset = "0x1AB8500", VA = "0x1AB8500")]
		private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
		{
			return default(bool);
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1AB8584", Offset = "0x1AB8584", VA = "0x1AB8584", Slot = "29")]
		protected virtual void ProcessMove(PlayerPointerEventData pointerEvent)
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x1AB8798", Offset = "0x1AB8798", VA = "0x1AB8798", Slot = "30")]
		protected virtual void ProcessDrag(PlayerPointerEventData pointerEvent)
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x1AB8CA8", Offset = "0x1AB8CA8", VA = "0x1AB8CA8", Slot = "20")]
		public override bool IsPointerOverGameObject(int pointerTypeId)
		{
			return default(bool);
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x1AB8F64", Offset = "0x1AB8F64", VA = "0x1AB8F64")]
		protected void ClearSelection()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x1AB93F4", Offset = "0x1AB93F4", VA = "0x1AB93F4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x1AB9A1C", Offset = "0x1AB9A1C", VA = "0x1AB9A1C")]
		protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x1AB8044", Offset = "0x1AB8044", VA = "0x1AB8044")]
		protected void CopyFromTo(PointerEventData from, PointerEventData to)
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x1AB8134", Offset = "0x1AB8134", VA = "0x1AB8134")]
		protected PointerEventData.FramePressState StateForMouseButton(int playerId, int mouseIndex, int buttonId)
		{
			return default(PointerEventData.FramePressState);
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x1AB9B4C", Offset = "0x1AB9B4C", VA = "0x1AB9B4C")]
		protected RewiredPointerInputModule()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public enum PointerEventType
	{
		[Token(Token = "0x4000343")]
		Mouse,
		[Token(Token = "0x4000344")]
		Touch
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59B718", Offset = "0x59B718")]
	public sealed class RewiredStandaloneInputModule : RewiredPointerInputModule
	{
		[Serializable]
		[Token(Token = "0x20000AA")]
		public class PlayerSetting
		{
			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int playerId;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public List<Rewired.Components.PlayerMouse> playerMice;

			[Token(Token = "0x60008FA")]
			[Address(RVA = "0x23925FC", Offset = "0x23925FC", VA = "0x23925FC")]
			public PlayerSetting()
			{
			}

			[Token(Token = "0x60008FB")]
			[Address(RVA = "0x2392698", Offset = "0x2392698", VA = "0x2392698")]
			private PlayerSetting(PlayerSetting other)
			{
			}

			[Token(Token = "0x60008FC")]
			[Address(RVA = "0x2392908", Offset = "0x2392908", VA = "0x2392908")]
			public PlayerSetting Clone()
			{
				return null;
			}
		}

		[Token(Token = "0x4000345")]
		private const string DEFAULT_ACTION_MOVE_HORIZONTAL = "UIHorizontal";

		[Token(Token = "0x4000346")]
		private const string DEFAULT_ACTION_MOVE_VERTICAL = "UIVertical";

		[Token(Token = "0x4000347")]
		private const string DEFAULT_ACTION_SUBMIT = "UISubmit";

		[Token(Token = "0x4000348")]
		private const string DEFAULT_ACTION_CANCEL = "UICancel";

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CB88", Offset = "0x59CB88")]
		[SerializeField]
		private InputManager_Base rewiredInputManager;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CBD0", Offset = "0x59CBD0")]
		private bool useAllRewiredGamePlayers;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CC18", Offset = "0x59CC18")]
		private bool useRewiredSystemPlayer;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CC60", Offset = "0x59CC60")]
		private int[] rewiredPlayerIds;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CCA8", Offset = "0x59CCA8")]
		private bool usePlayingPlayersOnly;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CCF0", Offset = "0x59CCF0")]
		private List<Rewired.Components.PlayerMouse> playerMice;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CD38", Offset = "0x59CD38")]
		private bool moveOneElementPerAxisPress;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CD80", Offset = "0x59CD80")]
		private bool setActionsById;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CDC8", Offset = "0x59CDC8")]
		private int horizontalActionId;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CE10", Offset = "0x59CE10")]
		private int verticalActionId;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CE58", Offset = "0x59CE58")]
		private int submitActionId;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CEA0", Offset = "0x59CEA0")]
		private int cancelActionId;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CEE8", Offset = "0x59CEE8")]
		private string m_HorizontalAxis;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CF30", Offset = "0x59CF30")]
		private string m_VerticalAxis;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CF78", Offset = "0x59CF78")]
		private string m_SubmitButton;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CFC0", Offset = "0x59CFC0")]
		private string m_CancelButton;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59D008", Offset = "0x59D008")]
		private float m_InputActionsPerSecond;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59D050", Offset = "0x59D050")]
		private float m_RepeatDelay;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59D098", Offset = "0x59D098")]
		private bool m_allowMouseInput;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59D0E0", Offset = "0x59D0E0")]
		private bool m_allowMouseInputIfTouchSupported;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59D128", Offset = "0x59D128")]
		private bool m_allowTouchInput;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7B")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59D170", Offset = "0x59D170")]
		private bool m_deselectIfBackgroundClicked;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59D1B8", Offset = "0x59D1B8")]
		private bool m_deselectBeforeSelecting;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x59D200", Offset = "0x59D200")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59D200", Offset = "0x59D200")]
		private bool m_ForceModuleActive;

		[NonSerialized]
		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int[] playerIds;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool recompiling;

		[NonSerialized]
		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool isTouchSupported;

		[NonSerialized]
		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private double m_PrevActionTime;

		[NonSerialized]
		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector2 m_LastMoveVector;

		[NonSerialized]
		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int m_ConsecutiveMoveCount;

		[NonSerialized]
		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool m_HasFocus;

		[Token(Token = "0x17000260")]
		public InputManager_Base RewiredInputManager
		{
			[Token(Token = "0x6000444")]
			[Address(RVA = "0x1AB9C88", Offset = "0x1AB9C88", VA = "0x1AB9C88")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000445")]
			[Address(RVA = "0x1AB9C90", Offset = "0x1AB9C90", VA = "0x1AB9C90")]
			set
			{
			}
		}

		[Token(Token = "0x17000261")]
		public bool UseAllRewiredGamePlayers
		{
			[Token(Token = "0x6000446")]
			[Address(RVA = "0x1AB9C98", Offset = "0x1AB9C98", VA = "0x1AB9C98")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000447")]
			[Address(RVA = "0x1AB9CA0", Offset = "0x1AB9CA0", VA = "0x1AB9CA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000262")]
		public bool UseRewiredSystemPlayer
		{
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x1ABA380", Offset = "0x1ABA380", VA = "0x1ABA380")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x1ABA388", Offset = "0x1ABA388", VA = "0x1ABA388")]
			set
			{
			}
		}

		[Token(Token = "0x17000263")]
		public int[] RewiredPlayerIds
		{
			[Token(Token = "0x600044A")]
			[Address(RVA = "0x1ABA3A8", Offset = "0x1ABA3A8", VA = "0x1ABA3A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x1ABA450", Offset = "0x1ABA450", VA = "0x1ABA450")]
			set
			{
			}
		}

		[Token(Token = "0x17000264")]
		public bool UsePlayingPlayersOnly
		{
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x1ABA534", Offset = "0x1ABA534", VA = "0x1ABA534")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x1ABA53C", Offset = "0x1ABA53C", VA = "0x1ABA53C")]
			set
			{
			}
		}

		[Token(Token = "0x17000265")]
		public List<Rewired.Components.PlayerMouse> PlayerMice
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x1ABA544", Offset = "0x1ABA544", VA = "0x1ABA544")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x1ABA5D0", Offset = "0x1ABA5D0", VA = "0x1ABA5D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000266")]
		public bool MoveOneElementPerAxisPress
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x1ABA6A4", Offset = "0x1ABA6A4", VA = "0x1ABA6A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x1ABA6AC", Offset = "0x1ABA6AC", VA = "0x1ABA6AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000267")]
		public bool allowMouseInput
		{
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x1ABA6B4", Offset = "0x1ABA6B4", VA = "0x1ABA6B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000453")]
			[Address(RVA = "0x1ABA6BC", Offset = "0x1ABA6BC", VA = "0x1ABA6BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000268")]
		public bool allowMouseInputIfTouchSupported
		{
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x1ABA6C4", Offset = "0x1ABA6C4", VA = "0x1ABA6C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x1ABA6CC", Offset = "0x1ABA6CC", VA = "0x1ABA6CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000269")]
		public bool allowTouchInput
		{
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x1ABA6D4", Offset = "0x1ABA6D4", VA = "0x1ABA6D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x1ABA6DC", Offset = "0x1ABA6DC", VA = "0x1ABA6DC")]
			set
			{
			}
		}

		[Token(Token = "0x1700026A")]
		public bool deselectIfBackgroundClicked
		{
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x1ABA6E4", Offset = "0x1ABA6E4", VA = "0x1ABA6E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x1ABA6EC", Offset = "0x1ABA6EC", VA = "0x1ABA6EC")]
			set
			{
			}
		}

		[Token(Token = "0x1700026B")]
		private bool deselectBeforeSelecting
		{
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x1ABA6F4", Offset = "0x1ABA6F4", VA = "0x1ABA6F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x1ABA6FC", Offset = "0x1ABA6FC", VA = "0x1ABA6FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700026C")]
		public bool SetActionsById
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x1ABA704", Offset = "0x1ABA704", VA = "0x1ABA704")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x1ABA70C", Offset = "0x1ABA70C", VA = "0x1ABA70C")]
			set
			{
			}
		}

		[Token(Token = "0x1700026D")]
		public int HorizontalActionId
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x1ABA728", Offset = "0x1ABA728", VA = "0x1ABA728")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600045F")]
			[Address(RVA = "0x1ABA730", Offset = "0x1ABA730", VA = "0x1ABA730")]
			set
			{
			}
		}

		[Token(Token = "0x1700026E")]
		public int VerticalActionId
		{
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x1ABA8F8", Offset = "0x1ABA8F8", VA = "0x1ABA8F8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000461")]
			[Address(RVA = "0x1ABA900", Offset = "0x1ABA900", VA = "0x1ABA900")]
			set
			{
			}
		}

		[Token(Token = "0x1700026F")]
		public int SubmitActionId
		{
			[Token(Token = "0x6000462")]
			[Address(RVA = "0x1ABAAC8", Offset = "0x1ABAAC8", VA = "0x1ABAAC8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000463")]
			[Address(RVA = "0x1ABAAD0", Offset = "0x1ABAAD0", VA = "0x1ABAAD0")]
			set
			{
			}
		}

		[Token(Token = "0x17000270")]
		public int CancelActionId
		{
			[Token(Token = "0x6000464")]
			[Address(RVA = "0x1ABAC98", Offset = "0x1ABAC98", VA = "0x1ABAC98")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000465")]
			[Address(RVA = "0x1ABACA0", Offset = "0x1ABACA0", VA = "0x1ABACA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000271")]
		protected override bool isMouseSupported
		{
			[Token(Token = "0x6000466")]
			[Address(RVA = "0x1ABAE68", Offset = "0x1ABAE68", VA = "0x1ABAE68", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000272")]
		private bool isTouchAllowed
		{
			[Token(Token = "0x6000467")]
			[Address(RVA = "0x1ABAEB8", Offset = "0x1ABAEB8", VA = "0x1ABAEB8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000273")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5A1E7C", Offset = "0x5A1E7C")]
		public bool allowActivationOnMobileDevice
		{
			[Token(Token = "0x6000468")]
			[Address(RVA = "0x1ABAEC0", Offset = "0x1ABAEC0", VA = "0x1ABAEC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000469")]
			[Address(RVA = "0x1ABAEC8", Offset = "0x1ABAEC8", VA = "0x1ABAEC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000274")]
		public bool forceModuleActive
		{
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x1ABAED0", Offset = "0x1ABAED0", VA = "0x1ABAED0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600046B")]
			[Address(RVA = "0x1ABAED8", Offset = "0x1ABAED8", VA = "0x1ABAED8")]
			set
			{
			}
		}

		[Token(Token = "0x17000275")]
		public float inputActionsPerSecond
		{
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x1ABAEE0", Offset = "0x1ABAEE0", VA = "0x1ABAEE0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x1ABAEE8", Offset = "0x1ABAEE8", VA = "0x1ABAEE8")]
			set
			{
			}
		}

		[Token(Token = "0x17000276")]
		public float repeatDelay
		{
			[Token(Token = "0x600046E")]
			[Address(RVA = "0x1ABAEF0", Offset = "0x1ABAEF0", VA = "0x1ABAEF0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600046F")]
			[Address(RVA = "0x1ABAEF8", Offset = "0x1ABAEF8", VA = "0x1ABAEF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000277")]
		public string horizontalAxis
		{
			[Token(Token = "0x6000470")]
			[Address(RVA = "0x1ABAF00", Offset = "0x1ABAF00", VA = "0x1ABAF00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000471")]
			[Address(RVA = "0x1ABAF08", Offset = "0x1ABAF08", VA = "0x1ABAF08")]
			set
			{
			}
		}

		[Token(Token = "0x17000278")]
		public string verticalAxis
		{
			[Token(Token = "0x6000472")]
			[Address(RVA = "0x1ABB050", Offset = "0x1ABB050", VA = "0x1ABB050")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000473")]
			[Address(RVA = "0x1ABB058", Offset = "0x1ABB058", VA = "0x1ABB058")]
			set
			{
			}
		}

		[Token(Token = "0x17000279")]
		public string submitButton
		{
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x1ABB1A0", Offset = "0x1ABB1A0", VA = "0x1ABB1A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000475")]
			[Address(RVA = "0x1ABB1A8", Offset = "0x1ABB1A8", VA = "0x1ABB1A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700027A")]
		public string cancelButton
		{
			[Token(Token = "0x6000476")]
			[Address(RVA = "0x1ABB2F0", Offset = "0x1ABB2F0", VA = "0x1ABB2F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000477")]
			[Address(RVA = "0x1ABB2F8", Offset = "0x1ABB2F8", VA = "0x1ABB2F8")]
			set
			{
			}
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x1ABB440", Offset = "0x1ABB440", VA = "0x1ABB440")]
		private RewiredStandaloneInputModule()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x1ABB5F8", Offset = "0x1ABB5F8", VA = "0x1ABB5F8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x1ABBA70", Offset = "0x1ABBA70", VA = "0x1ABBA70", Slot = "24")]
		public override void UpdateModule()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x1ABBD64", Offset = "0x1ABBD64", VA = "0x1ABBD64", Slot = "25")]
		public override bool IsModuleSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x1ABBD6C", Offset = "0x1ABBD6C", VA = "0x1ABBD6C", Slot = "21")]
		public override bool ShouldActivateModule()
		{
			return default(bool);
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x1ABC7C4", Offset = "0x1ABC7C4", VA = "0x1ABC7C4", Slot = "23")]
		public override void ActivateModule()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x1ABC8D4", Offset = "0x1ABC8D4", VA = "0x1ABC8D4", Slot = "22")]
		public override void DeactivateModule()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x1ABC8F4", Offset = "0x1ABC8F4", VA = "0x1ABC8F4", Slot = "17")]
		public override void Process()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x1ABD388", Offset = "0x1ABD388", VA = "0x1ABD388")]
		private bool ProcessTouchEvents()
		{
			return default(bool);
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x1ABD898", Offset = "0x1ABD898", VA = "0x1ABD898")]
		private void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x1ABCFE8", Offset = "0x1ABCFE8", VA = "0x1ABCFE8")]
		private bool SendSubmitEventToSelectedObject()
		{
			return default(bool);
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x1ABE5EC", Offset = "0x1ABE5EC", VA = "0x1ABE5EC")]
		private Vector2 GetRawMoveVector()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x1ABCC4C", Offset = "0x1ABCC4C", VA = "0x1ABCC4C")]
		private bool SendMoveEventToSelectedObject()
		{
			return default(bool);
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x1ABEA14", Offset = "0x1ABEA14", VA = "0x1ABEA14")]
		private void CheckButtonOrKeyMovement(out bool downHorizontal, out bool downVertical)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x1ABD6F8", Offset = "0x1ABD6F8", VA = "0x1ABD6F8")]
		private void ProcessMouseEvents()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x1ABEBEC", Offset = "0x1ABEBEC", VA = "0x1ABEBEC")]
		private void ProcessMouseEvent(int playerId, int pointerIndex)
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x1ABCA9C", Offset = "0x1ABCA9C", VA = "0x1ABCA9C")]
		private bool SendUpdateEventToSelectedObject()
		{
			return default(bool);
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x1ABF050", Offset = "0x1ABF050", VA = "0x1ABF050")]
		private void ProcessMousePress(MouseButtonEventData data)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x1ABE3C0", Offset = "0x1ABE3C0", VA = "0x1ABE3C0")]
		private void HandleMouseTouchDeselectionOnSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x1ABFA7C", Offset = "0x1ABFA7C", VA = "0x1ABFA7C")]
		private void OnApplicationFocus(bool hasFocus)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x1ABBC50", Offset = "0x1ABBC50", VA = "0x1ABBC50")]
		private bool ShouldIgnoreEventsOnNoFocus()
		{
			return default(bool);
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x1ABFA84", Offset = "0x1ABFA84", VA = "0x1ABFA84", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x1ABFBF0", Offset = "0x1ABFBF0", VA = "0x1ABFBF0", Slot = "27")]
		protected override bool IsDefaultPlayer(int playerId)
		{
			return default(bool);
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x1ABB81C", Offset = "0x1ABB81C", VA = "0x1ABB81C")]
		private void InitializeRewired()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x1AB9CC0", Offset = "0x1AB9CC0", VA = "0x1AB9CC0")]
		private void SetupRewiredVars()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x1AC0248", Offset = "0x1AC0248", VA = "0x1AC0248")]
		private void SetUpRewiredPlayerMice()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x1ABFE40", Offset = "0x1ABFE40", VA = "0x1ABFE40")]
		private void SetUpRewiredActions()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x1ABE99C", Offset = "0x1ABE99C", VA = "0x1ABE99C")]
		private bool GetButton(Player player, int actionId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x1ABC2D8", Offset = "0x1ABC2D8", VA = "0x1ABC2D8")]
		private bool GetButtonDown(Player player, int actionId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x1ABE9D8", Offset = "0x1ABE9D8", VA = "0x1ABE9D8")]
		private bool GetNegativeButton(Player player, int actionId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x1ABC314", Offset = "0x1ABC314", VA = "0x1ABC314")]
		private bool GetNegativeButtonDown(Player player, int actionId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x1ABC350", Offset = "0x1ABC350", VA = "0x1ABC350")]
		private float GetAxis(Player player, int actionId)
		{
			return default(float);
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x1ABBB60", Offset = "0x1ABBB60", VA = "0x1ABBB60")]
		private void CheckEditorRecompile()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x1AC0410", Offset = "0x1AC0410", VA = "0x1AC0410")]
		private void OnEditorRecompile()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x1AC041C", Offset = "0x1AC041C", VA = "0x1AC041C")]
		private void ClearRewiredVars()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x1ABC38C", Offset = "0x1ABC38C", VA = "0x1ABC38C")]
		private bool DidAnyMouseMove()
		{
			return default(bool);
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x1ABC5BC", Offset = "0x1ABC5BC", VA = "0x1ABC5BC")]
		private bool GetMouseButtonDownOnAnyMouse(int buttonIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x1AC0458", Offset = "0x1AC0458", VA = "0x1AC0458")]
		private void OnRewiredInitialized()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x1AC045C", Offset = "0x1AC045C", VA = "0x1AC045C")]
		private void OnRewiredShutDown()
		{
		}
	}
}
namespace EpicToonFX
{
	[Token(Token = "0x2000043")]
	public class ETFXLightFade : MonoBehaviour
	{
		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x59D270", Offset = "0x59D270")]
		public float life;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool killAfterLife;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Light li;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float initIntensity;

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x1341D00", Offset = "0x1341D00", VA = "0x1341D00")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x1341E6C", Offset = "0x1341E6C", VA = "0x1341E6C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x134202C", Offset = "0x134202C", VA = "0x134202C")]
		public ETFXLightFade()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class ETFXPitchRandomizer : MonoBehaviour
	{
		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float randomPercent;

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x1342048", Offset = "0x1342048", VA = "0x1342048")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x1342140", Offset = "0x1342140", VA = "0x1342140")]
		public ETFXPitchRandomizer()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class ETFXRotation : MonoBehaviour
	{
		[Token(Token = "0x20000AB")]
		public enum spaceEnum
		{
			[Token(Token = "0x4000577")]
			Local,
			[Token(Token = "0x4000578")]
			World
		}

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x59D2A4", Offset = "0x59D2A4")]
		public Vector3 rotateVector;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public spaceEnum rotateSpace;

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x1342154", Offset = "0x1342154", VA = "0x1342154")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x1342158", Offset = "0x1342158", VA = "0x1342158")]
		private void Update()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x1342264", Offset = "0x1342264", VA = "0x1342264")]
		public ETFXRotation()
		{
		}
	}
}
namespace Dreamteck
{
	[Token(Token = "0x2000046")]
	public static class ArrayUtility
	{
		[Token(Token = "0x60004A7")]
		public static void Add<T>(ref T[] array, T item)
		{
		}

		[Token(Token = "0x60004A8")]
		public static bool Contains<T>(T[] array, T item)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A9")]
		public static int IndexOf<T>(T[] array, T value)
		{
			return default(int);
		}

		[Token(Token = "0x60004AA")]
		public static void Insert<T>(ref T[] array, int index, T item)
		{
		}

		[Token(Token = "0x60004AB")]
		public static void RemoveAt<T>(ref T[] array, int index)
		{
		}
	}
	[Token(Token = "0x2000047")]
	public static class DMath
	{
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x133DE9C", Offset = "0x133DE9C", VA = "0x133DE9C")]
		public static double Sin(double a)
		{
			return default(double);
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x133DF18", Offset = "0x133DF18", VA = "0x133DF18")]
		public static double Cos(double a)
		{
			return default(double);
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x133DF94", Offset = "0x133DF94", VA = "0x133DF94")]
		public static double Tan(double a)
		{
			return default(double);
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x133E010", Offset = "0x133E010", VA = "0x133E010")]
		public static double Pow(double x, double y)
		{
			return default(double);
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x133E0AC", Offset = "0x133E0AC", VA = "0x133E0AC")]
		public static double Log(double a, double newBase)
		{
			return default(double);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x133E148", Offset = "0x133E148", VA = "0x133E148")]
		public static double Log10(double a)
		{
			return default(double);
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x133E1C4", Offset = "0x133E1C4", VA = "0x133E1C4")]
		public static double Clamp01(double a)
		{
			return default(double);
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x133E1F4", Offset = "0x133E1F4", VA = "0x133E1F4")]
		public static double Clamp(double a, double min, double max)
		{
			return default(double);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x133E224", Offset = "0x133E224", VA = "0x133E224")]
		public static double Lerp(double a, double b, double t)
		{
			return default(double);
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x133E264", Offset = "0x133E264", VA = "0x133E264")]
		public static double InverseLerp(double a, double b, double t)
		{
			return default(double);
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x133E2B8", Offset = "0x133E2B8", VA = "0x133E2B8")]
		public static Vector3 LerpVector3(Vector3 a, Vector3 b, double t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x133E344", Offset = "0x133E344", VA = "0x133E344")]
		public static double Round(double a)
		{
			return default(double);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x133E458", Offset = "0x133E458", VA = "0x133E458")]
		public static int RoundInt(double a)
		{
			return default(int);
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x133E58C", Offset = "0x133E58C", VA = "0x133E58C")]
		public static double Ceil(double a)
		{
			return default(double);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x133E608", Offset = "0x133E608", VA = "0x133E608")]
		public static int CeilInt(double a)
		{
			return default(int);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x133E6B4", Offset = "0x133E6B4", VA = "0x133E6B4")]
		public static double Floor(double a)
		{
			return default(double);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x133E730", Offset = "0x133E730", VA = "0x133E730")]
		public static int FloorInt(double a)
		{
			return default(int);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x133E7DC", Offset = "0x133E7DC", VA = "0x133E7DC")]
		public static double Move(double current, double target, double amount)
		{
			return default(double);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x133E824", Offset = "0x133E824", VA = "0x133E824")]
		public static double Abs(double a)
		{
			return default(double);
		}
	}
	[Token(Token = "0x2000048")]
	public static class DuplicateUtility
	{
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x133E968", Offset = "0x133E968", VA = "0x133E968")]
		public static AnimationCurve DuplicateCurve(AnimationCurve input)
		{
			return null;
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x133EB40", Offset = "0x133EB40", VA = "0x133EB40")]
		public static Gradient DuplicateGradient(Gradient input)
		{
			return null;
		}
	}
	[Token(Token = "0x2000049")]
	public static class LinearAlgebraUtility
	{
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x13495E4", Offset = "0x13495E4", VA = "0x13495E4")]
		public static Vector3 ProjectOnLine(Vector3 fromPoint, Vector3 toPoint, Vector3 project)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1349730", Offset = "0x1349730", VA = "0x1349730")]
		public static float InverseLerp(Vector3 a, Vector3 b, Vector3 value)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200004A")]
	public class MeshUtility
	{
		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3[] tan1;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static Vector3[] tan2;

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x134D41C", Offset = "0x134D41C", VA = "0x134D41C")]
		public static int[] GeneratePlaneTriangles(int x, int z, bool flip, int startTriangleIndex = 0, int startVertex = 0)
		{
			return null;
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x134D4FC", Offset = "0x134D4FC", VA = "0x134D4FC")]
		public static int[] GeneratePlaneTriangles(ref int[] triangles, int x, int z, bool flip, int startTriangleIndex = 0, int startVertex = 0, bool reallocateArray = false)
		{
			return null;
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x134B618", Offset = "0x134B618", VA = "0x134B618")]
		public static void CalculateTangents(TS_Mesh mesh)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x134D9F8", Offset = "0x134D9F8", VA = "0x134D9F8")]
		public static void MakeDoublesided(Mesh input)
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x134E90C", Offset = "0x134E90C", VA = "0x134E90C")]
		public static void MakeDoublesided(TS_Mesh input)
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x134AAD4", Offset = "0x134AAD4", VA = "0x134AAD4")]
		public static void MakeDoublesidedHalf(TS_Mesh input)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x134F770", Offset = "0x134F770", VA = "0x134F770")]
		public static void InverseTransformMesh(TS_Mesh input, TS_Transform transform)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x134F92C", Offset = "0x134F92C", VA = "0x134F92C")]
		public static void TransformMesh(TS_Mesh input, TS_Transform transform)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x134A918", Offset = "0x134A918", VA = "0x134A918")]
		public static void InverseTransformMesh(TS_Mesh input, Transform transform)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x134FAE8", Offset = "0x134FAE8", VA = "0x134FAE8")]
		public static void TransformMesh(TS_Mesh input, Transform transform)
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x134FCA4", Offset = "0x134FCA4", VA = "0x134FCA4")]
		public static void InverseTransformMesh(Mesh input, Transform transform)
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x134FF04", Offset = "0x134FF04", VA = "0x134FF04")]
		public static void TransformMesh(Mesh input, Transform transform)
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x13501AC", Offset = "0x13501AC", VA = "0x13501AC")]
		public static void TransformVertices(Vector3[] vertices, Transform transform)
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x1350264", Offset = "0x1350264", VA = "0x1350264")]
		public static void InverseTransformVertices(Vector3[] vertices, Transform transform)
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x135031C", Offset = "0x135031C", VA = "0x135031C")]
		public static void TransformNormals(Vector3[] normals, Transform transform)
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x13503D4", Offset = "0x13503D4", VA = "0x13503D4")]
		public static void InverseTransformNormals(Vector3[] normals, Transform transform)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x135048C", Offset = "0x135048C", VA = "0x135048C")]
		public static string ToOBJString(Mesh mesh, Material[] materials)
		{
			return null;
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x13511EC", Offset = "0x13511EC", VA = "0x13511EC")]
		public static Mesh Copy(Mesh input)
		{
			return null;
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x1351594", Offset = "0x1351594", VA = "0x1351594")]
		public static void Triangulate(Vector2[] points, ref int[] output)
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x1351E28", Offset = "0x1351E28", VA = "0x1351E28")]
		public static void FlipTriangles(ref int[] triangles)
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x134B460", Offset = "0x134B460", VA = "0x134B460")]
		public static void FlipFaces(TS_Mesh input)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1351F20", Offset = "0x1351F20", VA = "0x1351F20")]
		public static void BreakMesh(Mesh input, bool keepNormals = true)
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1351A74", Offset = "0x1351A74", VA = "0x1351A74")]
		private static float Area(Vector2[] points, int maxCount)
		{
			return default(float);
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x1351B40", Offset = "0x1351B40", VA = "0x1351B40")]
		private static bool Snip(Vector2[] points, int u, int v, int w, int n, int[] V)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x135330C", Offset = "0x135330C", VA = "0x135330C")]
		private static bool InsideTriangle(Vector2 A, Vector2 B, Vector2 C, Vector2 P)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x13533AC", Offset = "0x13533AC", VA = "0x13533AC")]
		public MeshUtility()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public static class ResourceUtility
	{
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x1AB561C", Offset = "0x1AB561C", VA = "0x1AB561C")]
		public static string FindFolder(string dir, string folderPattern)
		{
			return null;
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x1AB5B10", Offset = "0x1AB5B10", VA = "0x1AB5B10")]
		public static Texture2D LoadTexture(string dreamteckPath, string textureFileName)
		{
			return null;
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1AB5CB4", Offset = "0x1AB5CB4", VA = "0x1AB5CB4")]
		public static Texture2D LoadTexture(string path)
		{
			return null;
		}
	}
	[Token(Token = "0x200004C")]
	public static class SceneUtility
	{
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x22D9128", Offset = "0x22D9128", VA = "0x22D9128")]
		public static void GetChildrenRecursively(Transform current, ref List<Transform> transformList)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public class TS_Bounds
	{
		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector3 center;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 extents;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 max;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 min;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 size;

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x269FA88", Offset = "0x269FA88", VA = "0x269FA88")]
		public TS_Bounds()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x269FB24", Offset = "0x269FB24", VA = "0x269FB24")]
		public TS_Bounds(Bounds bounds)
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x269FC70", Offset = "0x269FC70", VA = "0x269FC70")]
		public TS_Bounds(Vector3 c, Vector3 s)
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x269FDA0", Offset = "0x269FDA0", VA = "0x269FDA0")]
		public TS_Bounds(Vector3 min, Vector3 max, Vector3 center)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x269FECC", Offset = "0x269FECC", VA = "0x269FECC")]
		public void CreateFromMinMax(Vector3 min, Vector3 max)
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x269FF74", Offset = "0x269FF74", VA = "0x269FF74")]
		public bool Contains(Vector3 point)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200004E")]
	public class TS_Mesh
	{
		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector3[] vertices;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3[] normals;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector4[] tangents;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Color[] colors;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2[] uv;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector2[] uv2;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2[] uv3;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector2[] uv4;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int[] triangles;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public List<int[]> subMeshes;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TS_Bounds bounds;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool hasUpdate;

		[Token(Token = "0x1700027B")]
		public int vertexCount
		{
			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x26913A8", Offset = "0x26913A8", VA = "0x26913A8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x269FFF0", Offset = "0x269FFF0", VA = "0x269FFF0")]
			set
			{
			}
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x268DC24", Offset = "0x268DC24", VA = "0x268DC24")]
		public TS_Mesh()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x269FFF4", Offset = "0x269FFF4", VA = "0x269FFF4")]
		public TS_Mesh(Mesh mesh)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x268D934", Offset = "0x268D934", VA = "0x268D934")]
		public void Clear()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x26A02B4", Offset = "0x26A02B4", VA = "0x26A02B4")]
		public void CreateFromMesh(Mesh mesh)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x268F2E4", Offset = "0x268F2E4", VA = "0x268F2E4")]
		public void Combine(List<TS_Mesh> newMeshes, bool overwrite = false)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x26A05E0", Offset = "0x26A05E0", VA = "0x26A05E0")]
		public void Combine(TS_Mesh newMesh)
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x26A10E0", Offset = "0x26A10E0", VA = "0x26A10E0")]
		public static TS_Mesh Copy(TS_Mesh input)
		{
			return null;
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x26A1754", Offset = "0x26A1754", VA = "0x26A1754")]
		public void Absorb(TS_Mesh input)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x26A2170", Offset = "0x26A2170", VA = "0x26A2170")]
		public void WriteMesh(ref Mesh input)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004F")]
	public class TS_Transform
	{
		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private bool setPosition;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		private bool setRotation;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		private bool setScale;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
		private bool setLocalPosition;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private bool setLocalRotation;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[HideInInspector]
		private Transform _transform;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		[HideInInspector]
		private float posX;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private float posY;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[HideInInspector]
		private float posZ;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private float scaleX;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[HideInInspector]
		private float scaleY;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[HideInInspector]
		private float scaleZ;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[HideInInspector]
		private float lossyScaleX;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private float lossyScaleY;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[HideInInspector]
		private float lossyScaleZ;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private float rotX;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[HideInInspector]
		private float rotY;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		private float rotZ;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		[HideInInspector]
		private float rotW;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		private float lposX;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[HideInInspector]
		private float lposY;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		private float lposZ;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		[HideInInspector]
		private float lrotX;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[HideInInspector]
		private float lrotY;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[HideInInspector]
		private float lrotZ;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[HideInInspector]
		private float lrotW;

		[Token(Token = "0x1700027C")]
		public Vector3 position
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x1A16BE8", Offset = "0x1A16BE8", VA = "0x1A16BE8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x1A16C1C", Offset = "0x1A16C1C", VA = "0x1A16C1C")]
			set
			{
			}
		}

		[Token(Token = "0x1700027D")]
		public Quaternion rotation
		{
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x1A16C60", Offset = "0x1A16C60", VA = "0x1A16C60")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x1A16CCC", Offset = "0x1A16CCC", VA = "0x1A16CCC")]
			set
			{
			}
		}

		[Token(Token = "0x1700027E")]
		public Vector3 scale
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x1A16D1C", Offset = "0x1A16D1C", VA = "0x1A16D1C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x1A16D50", Offset = "0x1A16D50", VA = "0x1A16D50")]
			set
			{
			}
		}

		[Token(Token = "0x1700027F")]
		public Vector3 lossyScale
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x1A16D8C", Offset = "0x1A16D8C", VA = "0x1A16D8C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x1A16DC0", Offset = "0x1A16DC0", VA = "0x1A16DC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000280")]
		public Vector3 localPosition
		{
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x1A16DFC", Offset = "0x1A16DFC", VA = "0x1A16DFC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x1A16E30", Offset = "0x1A16E30", VA = "0x1A16E30")]
			set
			{
			}
		}

		[Token(Token = "0x17000281")]
		public Quaternion localRotation
		{
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x1A16E74", Offset = "0x1A16E74", VA = "0x1A16E74")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x1A16EE0", Offset = "0x1A16EE0", VA = "0x1A16EE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000282")]
		public Transform transform
		{
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x1A16F30", Offset = "0x1A16F30", VA = "0x1A16F30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1A16F38", Offset = "0x1A16F38", VA = "0x1A16F38")]
		public TS_Transform(Transform input)
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1A16FDC", Offset = "0x1A16FDC", VA = "0x1A16FDC")]
		public void Update()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1A16FB0", Offset = "0x1A16FB0", VA = "0x1A16FB0")]
		public void SetTransform(Transform input)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1A17350", Offset = "0x1A17350", VA = "0x1A17350")]
		public bool HasChange()
		{
			return default(bool);
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x1A1738C", Offset = "0x1A1738C", VA = "0x1A1738C")]
		public bool HasPositionChange()
		{
			return default(bool);
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x1A17460", Offset = "0x1A17460", VA = "0x1A17460")]
		public bool HasRotationChange()
		{
			return default(bool);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x1A1756C", Offset = "0x1A1756C", VA = "0x1A1756C")]
		public bool HasScaleChange()
		{
			return default(bool);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x1A17640", Offset = "0x1A17640", VA = "0x1A17640")]
		public Vector3 TransformPoint(Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x1A17710", Offset = "0x1A17710", VA = "0x1A17710")]
		public Vector3 TransformDirection(Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x1A17780", Offset = "0x1A17780", VA = "0x1A17780")]
		public Vector3 InverseTransformPoint(Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x1A1780C", Offset = "0x1A1780C", VA = "0x1A1780C")]
		public Vector3 InverseTransformDirection(Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600050B")]
		public T GetComponent<T>()
		{
			return (T)null;
		}
	}
	[Token(Token = "0x2000050")]
	public static class TransformUtility
	{
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1A190A4", Offset = "0x1A190A4", VA = "0x1A190A4")]
		public static Vector3 GetPosition(Matrix4x4 m)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1A19164", Offset = "0x1A19164", VA = "0x1A19164")]
		public static Quaternion GetRotation(Matrix4x4 m)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1A19278", Offset = "0x1A19278", VA = "0x1A19278")]
		public static Vector3 GetScale(Matrix4x4 m)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1A19398", Offset = "0x1A19398", VA = "0x1A19398")]
		public static void SetPosition(ref Matrix4x4 m, ref Vector3 p)
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1A19400", Offset = "0x1A19400", VA = "0x1A19400")]
		public static void GetChildCount(Transform parent, ref int count)
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x1A19704", Offset = "0x1A19704", VA = "0x1A19704")]
		public static bool IsParent(Transform child, Transform parent)
		{
			return default(bool);
		}
	}
}
namespace Dreamteck.Splines
{
	[Token(Token = "0x2000051")]
	public class BlankUser : SplineUser
	{
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1336B4C", Offset = "0x1336B4C", VA = "0x1336B4C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x1336B50", Offset = "0x1336B50", VA = "0x1336B50", Slot = "13")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x1336B58", Offset = "0x1336B58", VA = "0x1336B58", Slot = "14")]
		protected override void Build()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x1336B60", Offset = "0x1336B60", VA = "0x1336B60", Slot = "15")]
		protected override void PostBuild()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x1336B68", Offset = "0x1336B68", VA = "0x1336B68")]
		public BlankUser()
		{
		}
	}
	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59B74C", Offset = "0x59B74C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x59B74C", Offset = "0x59B74C")]
	public class EdgeColliderGenerator : SplineUser
	{
		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		[HideInInspector]
		private float _offset;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[HideInInspector]
		protected EdgeCollider2D edgeCollider;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[HideInInspector]
		protected Vector2[] vertices;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public float updateRate;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		protected float lastUpdateTime;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool updateCollider;

		[Token(Token = "0x17000283")]
		public float offset
		{
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x13422A0", Offset = "0x13422A0", VA = "0x13422A0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x13422A8", Offset = "0x13422A8", VA = "0x13422A8")]
			set
			{
			}
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x13422D0", Offset = "0x13422D0", VA = "0x13422D0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1342344", Offset = "0x1342344", VA = "0x1342344", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x134234C", Offset = "0x134234C", VA = "0x134234C", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1342354", Offset = "0x1342354", VA = "0x1342354", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x134235C", Offset = "0x134235C", VA = "0x134235C", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1342364", Offset = "0x1342364", VA = "0x1342364", Slot = "13")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x1342464", Offset = "0x1342464", VA = "0x1342464", Slot = "14")]
		protected override void Build()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x1342688", Offset = "0x1342688", VA = "0x1342688", Slot = "15")]
		protected override void PostBuild()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1342844", Offset = "0x1342844", VA = "0x1342844")]
		public EdgeColliderGenerator()
		{
		}
	}
	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59B7E0", Offset = "0x59B7E0")]
	public class LengthCalculator : SplineUser
	{
		[Serializable]
		[Token(Token = "0x20000AC")]
		public class LengthEvent
		{
			[Token(Token = "0x200010D")]
			public enum Type
			{
				[Token(Token = "0x4000717")]
				Growing,
				[Token(Token = "0x4000718")]
				Shrinking,
				[Token(Token = "0x4000719")]
				Both
			}

			[Token(Token = "0x4000579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool enabled;

			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float targetLength;

			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UnityEvent onChange;

			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Type type;

			[Token(Token = "0x60008FD")]
			[Address(RVA = "0x238E4CC", Offset = "0x238E4CC", VA = "0x238E4CC")]
			public LengthEvent()
			{
			}

			[Token(Token = "0x60008FE")]
			[Address(RVA = "0x238E558", Offset = "0x238E558", VA = "0x238E558")]
			public LengthEvent(Type t)
			{
			}

			[Token(Token = "0x60008FF")]
			[Address(RVA = "0x238E5EC", Offset = "0x238E5EC", VA = "0x238E5EC")]
			public void Check(float fromLength, float toLength)
			{
			}
		}

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[HideInInspector]
		public LengthEvent[] lengthEvents;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public float idealLength;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float _length;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float lastLength;

		[Token(Token = "0x17000284")]
		public float length
		{
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x13490B0", Offset = "0x13490B0", VA = "0x13490B0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x13490B8", Offset = "0x13490B8", VA = "0x13490B8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x13491D0", Offset = "0x13491D0", VA = "0x13491D0", Slot = "14")]
		protected override void Build()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x13492B8", Offset = "0x13492B8", VA = "0x13492B8")]
		private void AddEvent(LengthEvent lengthEvent)
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x13493C8", Offset = "0x13493C8", VA = "0x13493C8")]
		public LengthCalculator()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class MeshGenerator : SplineUser
	{
		[Token(Token = "0x20000AD")]
		public enum UVMode
		{
			[Token(Token = "0x400057E")]
			Clip,
			[Token(Token = "0x400057F")]
			UniformClip,
			[Token(Token = "0x4000580")]
			Clamp,
			[Token(Token = "0x4000581")]
			UniformClamp
		}

		[Token(Token = "0x20000AE")]
		public enum NormalMethod
		{
			[Token(Token = "0x4000583")]
			Recalculate,
			[Token(Token = "0x4000584")]
			SplineNormals
		}

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
		[SerializeField]
		[HideInInspector]
		private bool _baked;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		[HideInInspector]
		private bool _markDynamic;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[HideInInspector]
		private float _size;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[HideInInspector]
		private Color _color;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		[HideInInspector]
		private Vector3 _offset;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[HideInInspector]
		private NormalMethod _normalMethod;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		[HideInInspector]
		private bool _calculateTangents;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59D8D8", Offset = "0x59D8D8")]
		private float _rotation;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[SerializeField]
		[HideInInspector]
		private bool _flipFaces;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		[SerializeField]
		[HideInInspector]
		private bool _doubleSided;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		[HideInInspector]
		private UVMode _uvMode;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[SerializeField]
		[HideInInspector]
		private Vector2 _uvScale;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		[HideInInspector]
		private Vector2 _uvOffset;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[SerializeField]
		[HideInInspector]
		private float _uvRotation;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[HideInInspector]
		protected MeshCollider meshCollider;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[SerializeField]
		[HideInInspector]
		protected MeshFilter filter;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[HideInInspector]
		protected MeshRenderer meshRenderer;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[SerializeField]
		[HideInInspector]
		protected TS_Mesh tsMesh;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[HideInInspector]
		protected Mesh mesh;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[HideInInspector]
		public float colliderUpdateRate;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected bool updateCollider;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		protected float lastUpdateTime;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float vDist;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static Vector2 uvs;

		[Token(Token = "0x17000285")]
		public float size
		{
			[Token(Token = "0x6000527")]
			[Address(RVA = "0x1349AFC", Offset = "0x1349AFC", VA = "0x1349AFC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000528")]
			[Address(RVA = "0x1349B04", Offset = "0x1349B04", VA = "0x1349B04")]
			set
			{
			}
		}

		[Token(Token = "0x17000286")]
		public Color color
		{
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x1349B2C", Offset = "0x1349B2C", VA = "0x1349B2C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600052A")]
			[Address(RVA = "0x1349B3C", Offset = "0x1349B3C", VA = "0x1349B3C")]
			set
			{
			}
		}

		[Token(Token = "0x17000287")]
		public Vector3 offset
		{
			[Token(Token = "0x600052B")]
			[Address(RVA = "0x1349BC0", Offset = "0x1349BC0", VA = "0x1349BC0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600052C")]
			[Address(RVA = "0x1349BD4", Offset = "0x1349BD4", VA = "0x1349BD4")]
			set
			{
			}
		}

		[Token(Token = "0x17000288")]
		public NormalMethod normalMethod
		{
			[Token(Token = "0x600052D")]
			[Address(RVA = "0x1349C4C", Offset = "0x1349C4C", VA = "0x1349C4C")]
			get
			{
				return default(NormalMethod);
			}
			[Token(Token = "0x600052E")]
			[Address(RVA = "0x1349C54", Offset = "0x1349C54", VA = "0x1349C54")]
			set
			{
			}
		}

		[Token(Token = "0x17000289")]
		public bool calculateTangents
		{
			[Token(Token = "0x600052F")]
			[Address(RVA = "0x1349C74", Offset = "0x1349C74", VA = "0x1349C74")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000530")]
			[Address(RVA = "0x1349C7C", Offset = "0x1349C7C", VA = "0x1349C7C")]
			set
			{
			}
		}

		[Token(Token = "0x1700028A")]
		public float rotation
		{
			[Token(Token = "0x6000531")]
			[Address(RVA = "0x1349CA8", Offset = "0x1349CA8", VA = "0x1349CA8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000532")]
			[Address(RVA = "0x1349CB0", Offset = "0x1349CB0", VA = "0x1349CB0")]
			set
			{
			}
		}

		[Token(Token = "0x1700028B")]
		public bool flipFaces
		{
			[Token(Token = "0x6000533")]
			[Address(RVA = "0x1349CD8", Offset = "0x1349CD8", VA = "0x1349CD8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000534")]
			[Address(RVA = "0x1349CE0", Offset = "0x1349CE0", VA = "0x1349CE0")]
			set
			{
			}
		}

		[Token(Token = "0x1700028C")]
		public bool doubleSided
		{
			[Token(Token = "0x6000535")]
			[Address(RVA = "0x1349D0C", Offset = "0x1349D0C", VA = "0x1349D0C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000536")]
			[Address(RVA = "0x1349D14", Offset = "0x1349D14", VA = "0x1349D14")]
			set
			{
			}
		}

		[Token(Token = "0x1700028D")]
		public UVMode uvMode
		{
			[Token(Token = "0x6000537")]
			[Address(RVA = "0x1349D40", Offset = "0x1349D40", VA = "0x1349D40")]
			get
			{
				return default(UVMode);
			}
			[Token(Token = "0x6000538")]
			[Address(RVA = "0x1349D48", Offset = "0x1349D48", VA = "0x1349D48")]
			set
			{
			}
		}

		[Token(Token = "0x1700028E")]
		public Vector2 uvScale
		{
			[Token(Token = "0x6000539")]
			[Address(RVA = "0x1349D68", Offset = "0x1349D68", VA = "0x1349D68")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600053A")]
			[Address(RVA = "0x1349D7C", Offset = "0x1349D7C", VA = "0x1349D7C")]
			set
			{
			}
		}

		[Token(Token = "0x1700028F")]
		public Vector2 uvOffset
		{
			[Token(Token = "0x600053B")]
			[Address(RVA = "0x1349DC8", Offset = "0x1349DC8", VA = "0x1349DC8")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600053C")]
			[Address(RVA = "0x1349DDC", Offset = "0x1349DDC", VA = "0x1349DDC")]
			set
			{
			}
		}

		[Token(Token = "0x17000290")]
		public float uvRotation
		{
			[Token(Token = "0x600053D")]
			[Address(RVA = "0x1349E28", Offset = "0x1349E28", VA = "0x1349E28")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600053E")]
			[Address(RVA = "0x1349E30", Offset = "0x1349E30", VA = "0x1349E30")]
			set
			{
			}
		}

		[Token(Token = "0x17000291")]
		public bool baked
		{
			[Token(Token = "0x600053F")]
			[Address(RVA = "0x1349E58", Offset = "0x1349E58", VA = "0x1349E58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000292")]
		public bool markDynamic
		{
			[Token(Token = "0x6000540")]
			[Address(RVA = "0x1349E60", Offset = "0x1349E60", VA = "0x1349E60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x1349E68", Offset = "0x1349E68", VA = "0x1349E68")]
			set
			{
			}
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x1349F68", Offset = "0x1349F68", VA = "0x1349F68", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x134A0E8", Offset = "0x134A0E8", VA = "0x134A0E8", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x134A0F0", Offset = "0x134A0F0", VA = "0x134A0F0")]
		public void CloneMesh()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x134A280", Offset = "0x134A280", VA = "0x134A280", Slot = "10")]
		public override void Rebuild()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x134A294", Offset = "0x134A294", VA = "0x134A294", Slot = "11")]
		public override void RebuildImmediate()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x134A2A8", Offset = "0x134A2A8", VA = "0x134A2A8", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x134A2B0", Offset = "0x134A2B0", VA = "0x134A2B0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x134A2B8", Offset = "0x134A2B8", VA = "0x134A2B8", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x134A414", Offset = "0x134A414", VA = "0x134A414")]
		public void UpdateCollider()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x134A56C", Offset = "0x134A56C", VA = "0x134A56C", Slot = "13")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x134A694", Offset = "0x134A694", VA = "0x134A694", Slot = "14")]
		protected override void Build()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x134A6D0", Offset = "0x134A6D0", VA = "0x134A6D0", Slot = "15")]
		protected override void PostBuild()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x134A6FC", Offset = "0x134A6FC", VA = "0x134A6FC", Slot = "18")]
		protected virtual void BuildMesh()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x134A700", Offset = "0x134A700", VA = "0x134A700", Slot = "19")]
		protected virtual void WriteMesh()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x134C294", Offset = "0x134C294", VA = "0x134C294", Slot = "20")]
		protected virtual void AllocateMesh(int vertexCount, int trisCount)
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x134C4E4", Offset = "0x134C4E4", VA = "0x134C4E4")]
		protected void ResetUVDistance()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x134C56C", Offset = "0x134C56C", VA = "0x134C56C")]
		protected void AddUVDistance(int sampleIndex)
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x134C614", Offset = "0x134C614", VA = "0x134C614")]
		protected void CalculateUVs(double percent, float u)
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x134C834", Offset = "0x134C834", VA = "0x134C834")]
		public MeshGenerator()
		{
		}
	}
	[Token(Token = "0x2000055")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59B814", Offset = "0x59B814")]
	public class Node : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000AF")]
		public class Connection
		{
			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool invertTangents;

			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[SerializeField]
			private int _pointIndex;

			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private SplineComputer _computer;

			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[SerializeField]
			[HideInInspector]
			internal SplinePoint point;

			[Token(Token = "0x1700032D")]
			public SplineComputer spline
			{
				[Token(Token = "0x6000900")]
				[Address(RVA = "0x238EFC0", Offset = "0x238EFC0", VA = "0x238EFC0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700032E")]
			public int pointIndex
			{
				[Token(Token = "0x6000901")]
				[Address(RVA = "0x238EFC8", Offset = "0x238EFC8", VA = "0x238EFC8")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700032F")]
			internal bool isValid
			{
				[Token(Token = "0x6000902")]
				[Address(RVA = "0x238EFD0", Offset = "0x238EFD0", VA = "0x238EFD0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000903")]
			[Address(RVA = "0x238F090", Offset = "0x238F090", VA = "0x238F090")]
			internal Connection(SplineComputer comp, int index, SplinePoint inputPoint)
			{
			}
		}

		[Token(Token = "0x20000B0")]
		public enum Type
		{
			[Token(Token = "0x400058A")]
			Smooth,
			[Token(Token = "0x400058B")]
			Free
		}

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[HideInInspector]
		public Type type;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[HideInInspector]
		protected Connection[] connections;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		[HideInInspector]
		private bool _transformSize;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		[SerializeField]
		[HideInInspector]
		private bool _transformNormals;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
		[SerializeField]
		[HideInInspector]
		private bool _transformTangents;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 lastPosition;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastScale;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion lastRotation;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform trs;

		[Token(Token = "0x17000293")]
		public bool transformNormals
		{
			[Token(Token = "0x6000556")]
			[Address(RVA = "0x1AA4BD0", Offset = "0x1AA4BD0", VA = "0x1AA4BD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000557")]
			[Address(RVA = "0x1AA4BD8", Offset = "0x1AA4BD8", VA = "0x1AA4BD8")]
			set
			{
			}
		}

		[Token(Token = "0x17000294")]
		public bool transformSize
		{
			[Token(Token = "0x6000558")]
			[Address(RVA = "0x1AA4E50", Offset = "0x1AA4E50", VA = "0x1AA4E50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000559")]
			[Address(RVA = "0x1AA4E58", Offset = "0x1AA4E58", VA = "0x1AA4E58")]
			set
			{
			}
		}

		[Token(Token = "0x17000295")]
		public bool transformTangents
		{
			[Token(Token = "0x600055A")]
			[Address(RVA = "0x1AA4E78", Offset = "0x1AA4E78", VA = "0x1AA4E78")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x1AA4E80", Offset = "0x1AA4E80", VA = "0x1AA4E80")]
			set
			{
			}
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x1AA4EA0", Offset = "0x1AA4EA0", VA = "0x1AA4EA0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x1AA4F74", Offset = "0x1AA4F74", VA = "0x1AA4F74")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x1AA4FA8", Offset = "0x1AA4FA8", VA = "0x1AA4FA8")]
		private void Update()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x1AA4FAC", Offset = "0x1AA4FAC", VA = "0x1AA4FAC")]
		private bool TransformChanged()
		{
			return default(bool);
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x1AA4ED0", Offset = "0x1AA4ED0", VA = "0x1AA4ED0")]
		private void SampleTransform()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x1AA4F78", Offset = "0x1AA4F78", VA = "0x1AA4F78")]
		private void Run()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x1AA5884", Offset = "0x1AA5884", VA = "0x1AA5884")]
		public SplinePoint GetPoint(int connectionIndex, bool swapTangents)
		{
			return default(SplinePoint);
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x1AA5CD0", Offset = "0x1AA5CD0", VA = "0x1AA5CD0")]
		public void SetPoint(int connectionIndex, SplinePoint worldPoint, bool swappedTangents)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x1AA65CC", Offset = "0x1AA65CC", VA = "0x1AA65CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x1AA65D0", Offset = "0x1AA65D0", VA = "0x1AA65D0")]
		public void ClearConnections()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x1AA50D0", Offset = "0x1AA50D0", VA = "0x1AA50D0")]
		public void UpdateConnectedComputers([Optional] SplineComputer excludeComputer)
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x1AA69FC", Offset = "0x1AA69FC", VA = "0x1AA69FC")]
		public void UpdatePoint(SplineComputer computer, int pointIndex, SplinePoint point, bool updatePosition = true)
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x1AA4BF8", Offset = "0x1AA4BF8", VA = "0x1AA4BF8")]
		private void UpdatePoints()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x1AA6C24", Offset = "0x1AA6C24", VA = "0x1AA6C24")]
		protected void RemoveInvalidConnections()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1AA6CFC", Offset = "0x1AA6CFC", VA = "0x1AA6CFC", Slot = "4")]
		public virtual void AddConnection(SplineComputer computer, int pointIndex)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x1AA63BC", Offset = "0x1AA63BC", VA = "0x1AA63BC")]
		protected SplinePoint PointToLocal(SplinePoint worldPoint)
		{
			return default(SplinePoint);
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x1AA5AA4", Offset = "0x1AA5AA4", VA = "0x1AA5AA4")]
		protected SplinePoint PointToWorld(SplinePoint localPoint)
		{
			return default(SplinePoint);
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x1AA7330", Offset = "0x1AA7330", VA = "0x1AA7330", Slot = "5")]
		public virtual void RemoveConnection(SplineComputer computer, int pointIndex)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x1AA6798", Offset = "0x1AA6798", VA = "0x1AA6798")]
		private void RemoveConnection(int index)
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x1AA748C", Offset = "0x1AA748C", VA = "0x1AA748C", Slot = "6")]
		public virtual bool HasConnection(SplineComputer computer, int pointIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x1AA7644", Offset = "0x1AA7644", VA = "0x1AA7644")]
		public Connection[] GetConnections()
		{
			return null;
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x1AA764C", Offset = "0x1AA764C", VA = "0x1AA764C")]
		public Node()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59B85C", Offset = "0x59B85C")]
	public class ObjectBender : SplineUser
	{
		[Token(Token = "0x20000B1")]
		public enum Axis
		{
			[Token(Token = "0x400058D")]
			X,
			[Token(Token = "0x400058E")]
			Y,
			[Token(Token = "0x400058F")]
			Z
		}

		[Token(Token = "0x20000B2")]
		public enum NormalMode
		{
			[Token(Token = "0x4000591")]
			Spline,
			[Token(Token = "0x4000592")]
			Auto,
			[Token(Token = "0x4000593")]
			Custom
		}

		[Token(Token = "0x20000B3")]
		public enum ForwardMode
		{
			[Token(Token = "0x4000595")]
			Spline,
			[Token(Token = "0x4000596")]
			Custom
		}

		[Serializable]
		[Token(Token = "0x20000B4")]
		public class BendProperty
		{
			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool enabled;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public TS_Transform transform;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool applyRotation;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public bool applyScale;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			public bool generateLightmapUVs;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
			[SerializeField]
			[HideInInspector]
			private bool _bendMesh;

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[SerializeField]
			[HideInInspector]
			private bool _bendSpline;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[SerializeField]
			[HideInInspector]
			private bool _bendCollider;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float colliderUpdateDue;

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float colliderUpdateRate;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private bool updateCollider;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 originalPosition;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 originalScale;

			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion originalRotation;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public Quaternion parentRotation;

			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 positionPercent;

			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Vector3[] vertexPercents;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Vector3[] normals;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Vector3[] colliderVertexPercents;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3[] colliderNormals;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[SerializeField]
			[HideInInspector]
			private Mesh originalMesh;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[SerializeField]
			[HideInInspector]
			private Mesh originalColliderMesh;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private Spline _originalSpline;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[SerializeField]
			[HideInInspector]
			private Mesh destinationMesh;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[SerializeField]
			[HideInInspector]
			private Mesh destinationColliderMesh;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public Spline destinationSpline;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public TS_Mesh _editMesh;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			public TS_Mesh _editColliderMesh;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public MeshFilter filter;

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			public MeshCollider collider;

			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public SplineComputer splineComputer;

			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			public Vector3[] splinePointPercents;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public Vector3[] primaryTangentPercents;

			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			public Vector3[] secondaryTangentPercents;

			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[SerializeField]
			[HideInInspector]
			private bool parent;

			[Token(Token = "0x17000330")]
			public bool isValid
			{
				[Token(Token = "0x6000904")]
				[Address(RVA = "0x238F0EC", Offset = "0x238F0EC", VA = "0x238F0EC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000331")]
			public bool bendMesh
			{
				[Token(Token = "0x6000905")]
				[Address(RVA = "0x238F180", Offset = "0x238F180", VA = "0x238F180")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000906")]
				[Address(RVA = "0x238F188", Offset = "0x238F188", VA = "0x238F188")]
				set
				{
				}
			}

			[Token(Token = "0x17000332")]
			public bool bendCollider
			{
				[Token(Token = "0x6000907")]
				[Address(RVA = "0x238F490", Offset = "0x238F490", VA = "0x238F490")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000908")]
				[Address(RVA = "0x238F498", Offset = "0x238F498", VA = "0x238F498")]
				set
				{
				}
			}

			[Token(Token = "0x17000333")]
			public bool bendSpline
			{
				[Token(Token = "0x6000909")]
				[Address(RVA = "0x238F6F8", Offset = "0x238F6F8", VA = "0x238F6F8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600090A")]
				[Address(RVA = "0x238F700", Offset = "0x238F700", VA = "0x238F700")]
				set
				{
				}
			}

			[Token(Token = "0x17000334")]
			public TS_Mesh editMesh
			{
				[Token(Token = "0x600090B")]
				[Address(RVA = "0x238F708", Offset = "0x238F708", VA = "0x238F708")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000335")]
			public TS_Mesh editColliderMesh
			{
				[Token(Token = "0x600090C")]
				[Address(RVA = "0x238F850", Offset = "0x238F850", VA = "0x238F850")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000336")]
			public Spline originalSpline
			{
				[Token(Token = "0x600090D")]
				[Address(RVA = "0x238F9D8", Offset = "0x238F9D8", VA = "0x238F9D8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600090E")]
			[Address(RVA = "0x238FB80", Offset = "0x238FB80", VA = "0x238FB80")]
			public BendProperty(Transform t, bool isParent = false)
			{
			}

			[Token(Token = "0x600090F")]
			[Address(RVA = "0x23906A4", Offset = "0x23906A4", VA = "0x23906A4")]
			public void Revert()
			{
			}

			[Token(Token = "0x6000910")]
			[Address(RVA = "0x238F3D0", Offset = "0x238F3D0", VA = "0x238F3D0")]
			private void RevertMesh()
			{
			}

			[Token(Token = "0x6000911")]
			[Address(RVA = "0x2390790", Offset = "0x2390790", VA = "0x2390790")]
			private void RevertTransform()
			{
			}

			[Token(Token = "0x6000912")]
			[Address(RVA = "0x238F638", Offset = "0x238F638", VA = "0x238F638")]
			private void RevertCollider()
			{
			}

			[Token(Token = "0x6000913")]
			[Address(RVA = "0x2390880", Offset = "0x2390880", VA = "0x2390880")]
			public void Apply(bool applyTransform)
			{
			}

			[Token(Token = "0x6000914")]
			[Address(RVA = "0x2390CA0", Offset = "0x2390CA0", VA = "0x2390CA0")]
			public void Update()
			{
			}

			[Token(Token = "0x6000915")]
			[Address(RVA = "0x2390A58", Offset = "0x2390A58", VA = "0x2390A58")]
			private void ApplyMesh()
			{
			}

			[Token(Token = "0x6000916")]
			[Address(RVA = "0x2390CEC", Offset = "0x2390CEC", VA = "0x2390CEC")]
			private void ApplyCollider()
			{
			}

			[Token(Token = "0x6000917")]
			[Address(RVA = "0x2390C60", Offset = "0x2390C60", VA = "0x2390C60")]
			private void ApplySpline()
			{
			}
		}

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
		[SerializeField]
		[HideInInspector]
		private bool _bend;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[HideInInspector]
		public BendProperty[] bendProperties;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[HideInInspector]
		private TS_Bounds bounds;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[HideInInspector]
		private Axis _axis;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[HideInInspector]
		private NormalMode _normalMode;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		[HideInInspector]
		private ForwardMode _forwardMode;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x59DD18", Offset = "0x59DD18")]
		private Vector3 _customNormal;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[HideInInspector]
		private Vector3 _customForward;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Matrix4x4 normalMatrix;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quaternion bendRotation;

		[Token(Token = "0x17000296")]
		public bool bend
		{
			[Token(Token = "0x6000572")]
			[Address(RVA = "0x1AA81F8", Offset = "0x1AA81F8", VA = "0x1AA81F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000573")]
			[Address(RVA = "0x1AA8200", Offset = "0x1AA8200", VA = "0x1AA8200")]
			set
			{
			}
		}

		[Token(Token = "0x17000297")]
		public Axis axis
		{
			[Token(Token = "0x6000574")]
			[Address(RVA = "0x1AA8508", Offset = "0x1AA8508", VA = "0x1AA8508")]
			get
			{
				return default(Axis);
			}
			[Token(Token = "0x6000575")]
			[Address(RVA = "0x1AA8510", Offset = "0x1AA8510", VA = "0x1AA8510")]
			set
			{
			}
		}

		[Token(Token = "0x17000298")]
		public NormalMode upMode
		{
			[Token(Token = "0x6000576")]
			[Address(RVA = "0x1AA85CC", Offset = "0x1AA85CC", VA = "0x1AA85CC")]
			get
			{
				return default(NormalMode);
			}
			[Token(Token = "0x6000577")]
			[Address(RVA = "0x1AA85D4", Offset = "0x1AA85D4", VA = "0x1AA85D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000299")]
		public Vector3 customNormal
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x1AA8688", Offset = "0x1AA8688", VA = "0x1AA8688")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000579")]
			[Address(RVA = "0x1AA869C", Offset = "0x1AA869C", VA = "0x1AA869C")]
			set
			{
			}
		}

		[Token(Token = "0x1700029A")]
		public ForwardMode forwardMode
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x1AA8798", Offset = "0x1AA8798", VA = "0x1AA8798")]
			get
			{
				return default(ForwardMode);
			}
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x1AA87A0", Offset = "0x1AA87A0", VA = "0x1AA87A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700029B")]
		public Vector3 customForward
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x1AA8854", Offset = "0x1AA8854", VA = "0x1AA8854")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600057D")]
			[Address(RVA = "0x1AA8868", Offset = "0x1AA8868", VA = "0x1AA8868")]
			set
			{
			}
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x1AA8964", Offset = "0x1AA8964", VA = "0x1AA8964")]
		private void GetTransformsRecursively(Transform current, ref List<Transform> transformList)
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x1AA8CA0", Offset = "0x1AA8CA0", VA = "0x1AA8CA0")]
		private void GetObjects()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x1AA93CC", Offset = "0x1AA93CC", VA = "0x1AA93CC")]
		public TS_Bounds GetBounds()
		{
			return null;
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x1AA8E2C", Offset = "0x1AA8E2C", VA = "0x1AA8E2C")]
		private void CreateProperty(ref BendProperty property, Transform t)
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x1AA94C4", Offset = "0x1AA94C4", VA = "0x1AA94C4")]
		private void CalculateBounds()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x1AA96B8", Offset = "0x1AA96B8", VA = "0x1AA96B8")]
		private void CalculatePropertyBounds(ref BendProperty property)
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x1AAA36C", Offset = "0x1AAA36C", VA = "0x1AAA36C")]
		public void CalculatePercents(BendProperty property)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x1AA8488", Offset = "0x1AA8488", VA = "0x1AA8488")]
		private void Revert()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x1AA825C", Offset = "0x1AA825C", VA = "0x1AA825C")]
		public void UpdateReferences()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x1AAAE44", Offset = "0x1AAAE44", VA = "0x1AAAE44")]
		private void GetevalResult(Vector3 percentage)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x1AAACCC", Offset = "0x1AAACCC", VA = "0x1AAACCC")]
		private Vector3 GetPercentage(Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x1AAB534", Offset = "0x1AAB534", VA = "0x1AAB534", Slot = "14")]
		protected override void Build()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x1AAADAC", Offset = "0x1AAADAC", VA = "0x1AAADAC")]
		private void Bend()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x1AAB564", Offset = "0x1AAB564", VA = "0x1AAB564")]
		public void BendObject(BendProperty p)
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x1AAC0BC", Offset = "0x1AAC0BC", VA = "0x1AAC0BC")]
		private void BendMesh(Vector3[] vertexPercents, Vector3[] originalNormals, TS_Mesh mesh, Matrix4x4 worldToLocalMatrix)
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x1AAC3F4", Offset = "0x1AAC3F4", VA = "0x1AAC3F4", Slot = "15")]
		protected override void PostBuild()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x1AAC57C", Offset = "0x1AAC57C", VA = "0x1AAC57C", Slot = "13")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x1AAC604", Offset = "0x1AAC604", VA = "0x1AAC604")]
		public ObjectBender()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59B890", Offset = "0x59B890")]
	public class ObjectController : SplineUser
	{
		[Serializable]
		[Token(Token = "0x20000B5")]
		internal class ObjectControl
		{
			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public GameObject gameObject;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 position;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Quaternion rotation;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 scale;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public bool active;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 baseScale;

			[Token(Token = "0x17000337")]
			public bool isNull
			{
				[Token(Token = "0x6000918")]
				[Address(RVA = "0x239115C", Offset = "0x239115C", VA = "0x239115C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000338")]
			public Transform transform
			{
				[Token(Token = "0x6000919")]
				[Address(RVA = "0x23911DC", Offset = "0x23911DC", VA = "0x23911DC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600091A")]
			[Address(RVA = "0x2391288", Offset = "0x2391288", VA = "0x2391288")]
			public ObjectControl(GameObject input)
			{
			}

			[Token(Token = "0x600091B")]
			[Address(RVA = "0x239137C", Offset = "0x239137C", VA = "0x239137C")]
			public void Destroy()
			{
			}

			[Token(Token = "0x600091C")]
			[Address(RVA = "0x2391438", Offset = "0x2391438", VA = "0x2391438")]
			public void DestroyImmediate()
			{
			}

			[Token(Token = "0x600091D")]
			[Address(RVA = "0x23914F4", Offset = "0x23914F4", VA = "0x23914F4")]
			public void Apply()
			{
			}
		}

		[Token(Token = "0x20000B6")]
		public enum ObjectMethod
		{
			[Token(Token = "0x40005C1")]
			Instantiate,
			[Token(Token = "0x40005C2")]
			GetChildren
		}

		[Token(Token = "0x20000B7")]
		public enum Positioning
		{
			[Token(Token = "0x40005C4")]
			Stretch,
			[Token(Token = "0x40005C5")]
			Clip
		}

		[Token(Token = "0x20000B8")]
		public enum Iteration
		{
			[Token(Token = "0x40005C7")]
			Ordered,
			[Token(Token = "0x40005C8")]
			Random
		}

		[Token(Token = "0x20000B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C06C", Offset = "0x59C06C")]
		private sealed class <InstantiateAllWithDelay>d__94 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ObjectController <>4__this;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private int <i>5__2;

			[Token(Token = "0x17000339")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000921")]
				[Address(RVA = "0x2391104", Offset = "0x2391104", VA = "0x2391104", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700033A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000923")]
				[Address(RVA = "0x2391154", Offset = "0x2391154", VA = "0x2391154", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600091E")]
			[Address(RVA = "0x2390F5C", Offset = "0x2390F5C", VA = "0x2390F5C")]
			[DebuggerHidden]
			public <InstantiateAllWithDelay>d__94(int <>1__state)
			{
			}

			[Token(Token = "0x600091F")]
			[Address(RVA = "0x2390F7C", Offset = "0x2390F7C", VA = "0x2390F7C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000920")]
			[Address(RVA = "0x2390F80", Offset = "0x2390F80", VA = "0x2390F80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000922")]
			[Address(RVA = "0x239110C", Offset = "0x239110C", VA = "0x239110C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		[HideInInspector]
		public GameObject[] objects;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[HideInInspector]
		private float _evaluateOffset;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[HideInInspector]
		private int _spawnCount;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[HideInInspector]
		private Positioning _objectPositioning;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		[HideInInspector]
		private Iteration _iteration;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[HideInInspector]
		private int _randomSeed;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		[HideInInspector]
		private Vector3 _minOffset;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[HideInInspector]
		private Vector3 _maxOffset;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[SerializeField]
		[HideInInspector]
		private bool _offsetUseWorldCoords;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		[HideInInspector]
		private Vector3 _minRotation;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		[HideInInspector]
		private Vector3 _maxRotation;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[HideInInspector]
		private bool _uniformScaleLerp;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[SerializeField]
		[HideInInspector]
		private Vector3 _minScaleMultiplier;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[HideInInspector]
		private Vector3 _maxScaleMultiplier;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		[HideInInspector]
		private bool _shellOffset;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		[SerializeField]
		[HideInInspector]
		private bool _applyRotation;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBE")]
		[SerializeField]
		[HideInInspector]
		private bool _rotateByOffset;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBF")]
		[SerializeField]
		[HideInInspector]
		private bool _applyScale;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[HideInInspector]
		private ObjectMethod _objectMethod;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[HideInInspector]
		public bool delayedSpawn;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[HideInInspector]
		public float spawnDelay;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		[HideInInspector]
		private int lastChildCount;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[HideInInspector]
		private ObjectControl[] spawned;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private System.Random offsetRandomizer;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private System.Random shellRandomizer;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private System.Random rotationRandomizer;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private System.Random scaleRandomizer;

		[Token(Token = "0x1700029C")]
		public ObjectMethod objectMethod
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x1AAC6E0", Offset = "0x1AAC6E0", VA = "0x1AAC6E0")]
			get
			{
				return default(ObjectMethod);
			}
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x1AAC6E8", Offset = "0x1AAC6E8", VA = "0x1AAC6E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700029D")]
		public int spawnCount
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x1AAC7D0", Offset = "0x1AAC7D0", VA = "0x1AAC7D0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x1AAC7D8", Offset = "0x1AAC7D8", VA = "0x1AAC7D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700029E")]
		public Positioning objectPositioning
		{
			[Token(Token = "0x6000594")]
			[Address(RVA = "0x1AACB98", Offset = "0x1AACB98", VA = "0x1AACB98")]
			get
			{
				return default(Positioning);
			}
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x1AACBA0", Offset = "0x1AACBA0", VA = "0x1AACBA0")]
			set
			{
			}
		}

		[Token(Token = "0x1700029F")]
		public Iteration iteration
		{
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x1AACBC0", Offset = "0x1AACBC0", VA = "0x1AACBC0")]
			get
			{
				return default(Iteration);
			}
			[Token(Token = "0x6000597")]
			[Address(RVA = "0x1AACBC8", Offset = "0x1AACBC8", VA = "0x1AACBC8")]
			set
			{
			}
		}

		[Token(Token = "0x170002A0")]
		public int randomSeed
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x1AACBE8", Offset = "0x1AACBE8", VA = "0x1AACBE8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x1AACBF0", Offset = "0x1AACBF0", VA = "0x1AACBF0")]
			set
			{
			}
		}

		[Token(Token = "0x170002A1")]
		public Vector3 minOffset
		{
			[Token(Token = "0x600059A")]
			[Address(RVA = "0x1AACC10", Offset = "0x1AACC10", VA = "0x1AACC10")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x1AACC24", Offset = "0x1AACC24", VA = "0x1AACC24")]
			set
			{
			}
		}

		[Token(Token = "0x170002A2")]
		public Vector3 maxOffset
		{
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x1AACC9C", Offset = "0x1AACC9C", VA = "0x1AACC9C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600059D")]
			[Address(RVA = "0x1AACCB0", Offset = "0x1AACCB0", VA = "0x1AACCB0")]
			set
			{
			}
		}

		[Token(Token = "0x170002A3")]
		public bool offsetUseWorldCoords
		{
			[Token(Token = "0x600059E")]
			[Address(RVA = "0x1AACD28", Offset = "0x1AACD28", VA = "0x1AACD28")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600059F")]
			[Address(RVA = "0x1AACD30", Offset = "0x1AACD30", VA = "0x1AACD30")]
			set
			{
			}
		}

		[Token(Token = "0x170002A4")]
		public Vector3 minRotation
		{
			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x1AACD5C", Offset = "0x1AACD5C", VA = "0x1AACD5C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x1AACD70", Offset = "0x1AACD70", VA = "0x1AACD70")]
			set
			{
			}
		}

		[Token(Token = "0x170002A5")]
		public Vector3 maxRotation
		{
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x1AACDE8", Offset = "0x1AACDE8", VA = "0x1AACDE8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x1AACDFC", Offset = "0x1AACDFC", VA = "0x1AACDFC")]
			set
			{
			}
		}

		[Token(Token = "0x170002A6")]
		public Vector3 rotationOffset
		{
			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x1AACE74", Offset = "0x1AACE74", VA = "0x1AACE74")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x1AACEB8", Offset = "0x1AACEB8", VA = "0x1AACEB8")]
			set
			{
			}
		}

		[Token(Token = "0x170002A7")]
		public Vector3 minScaleMultiplier
		{
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x1AACF64", Offset = "0x1AACF64", VA = "0x1AACF64")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x1AACF78", Offset = "0x1AACF78", VA = "0x1AACF78")]
			set
			{
			}
		}

		[Token(Token = "0x170002A8")]
		public Vector3 maxScaleMultiplier
		{
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x1AACFF0", Offset = "0x1AACFF0", VA = "0x1AACFF0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x1AAD004", Offset = "0x1AAD004", VA = "0x1AAD004")]
			set
			{
			}
		}

		[Token(Token = "0x170002A9")]
		public bool uniformScaleLerp
		{
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x1AAD07C", Offset = "0x1AAD07C", VA = "0x1AAD07C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x1AAD084", Offset = "0x1AAD084", VA = "0x1AAD084")]
			set
			{
			}
		}

		[Token(Token = "0x170002AA")]
		public bool shellOffset
		{
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x1AAD0B0", Offset = "0x1AAD0B0", VA = "0x1AAD0B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x1AAD0B8", Offset = "0x1AAD0B8", VA = "0x1AAD0B8")]
			set
			{
			}
		}

		[Token(Token = "0x170002AB")]
		public bool applyRotation
		{
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x1AAD0E4", Offset = "0x1AAD0E4", VA = "0x1AAD0E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x1AAD0EC", Offset = "0x1AAD0EC", VA = "0x1AAD0EC")]
			set
			{
			}
		}

		[Token(Token = "0x170002AC")]
		public bool rotateByOffset
		{
			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x1AAD118", Offset = "0x1AAD118", VA = "0x1AAD118")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x1AAD120", Offset = "0x1AAD120", VA = "0x1AAD120")]
			set
			{
			}
		}

		[Token(Token = "0x170002AD")]
		public bool applyScale
		{
			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x1AAD14C", Offset = "0x1AAD14C", VA = "0x1AAD14C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x1AAD154", Offset = "0x1AAD154", VA = "0x1AAD154")]
			set
			{
			}
		}

		[Token(Token = "0x170002AE")]
		public float evaluateOffset
		{
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x1AAD180", Offset = "0x1AAD180", VA = "0x1AAD180")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x1AAD188", Offset = "0x1AAD188", VA = "0x1AAD188")]
			set
			{
			}
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1AAD1B0", Offset = "0x1AAD1B0", VA = "0x1AAD1B0")]
		public void Clear()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x1AAD45C", Offset = "0x1AAD45C", VA = "0x1AAD45C")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x1AAC810", Offset = "0x1AAC810", VA = "0x1AAC810")]
		private void Remove()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1AAD470", Offset = "0x1AAD470", VA = "0x1AAD470")]
		public void GetAll()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x1AAC708", Offset = "0x1AAC708", VA = "0x1AAC708")]
		public void Spawn()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1AADC8C", Offset = "0x1AADC8C", VA = "0x1AADC8C", Slot = "13")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x1AADB30", Offset = "0x1AADB30", VA = "0x1AADB30")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5A0B5C", Offset = "0x5A0B5C")]
		private IEnumerator InstantiateAllWithDelay()
		{
			return null;
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x1AADBB4", Offset = "0x1AADBB4", VA = "0x1AADBB4")]
		private void InstantiateAll()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x1AADD18", Offset = "0x1AADD18", VA = "0x1AADD18")]
		private void InstantiateSingle()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x1AAE150", Offset = "0x1AAE150", VA = "0x1AAE150", Slot = "14")]
		protected override void Build()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x1AAEE20", Offset = "0x1AAEE20", VA = "0x1AAEE20", Slot = "15")]
		protected override void PostBuild()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x1AAEEA8", Offset = "0x1AAEEA8", VA = "0x1AAEEA8")]
		public ObjectController()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59B8C4", Offset = "0x59B8C4")]
	public class ParticleController : SplineUser
	{
		[Token(Token = "0x20000BA")]
		public enum EmitPoint
		{
			[Token(Token = "0x40005CE")]
			Beginning,
			[Token(Token = "0x40005CF")]
			Ending,
			[Token(Token = "0x40005D0")]
			Random,
			[Token(Token = "0x40005D1")]
			Ordered
		}

		[Token(Token = "0x20000BB")]
		public enum MotionType
		{
			[Token(Token = "0x40005D3")]
			None,
			[Token(Token = "0x40005D4")]
			UseParticleSystem,
			[Token(Token = "0x40005D5")]
			FollowForward,
			[Token(Token = "0x40005D6")]
			FollowBackward,
			[Token(Token = "0x40005D7")]
			ByNormal,
			[Token(Token = "0x40005D8")]
			ByNormalRandomized
		}

		[Token(Token = "0x20000BC")]
		public enum Wrap
		{
			[Token(Token = "0x40005DA")]
			Default,
			[Token(Token = "0x40005DB")]
			Loop
		}

		[Token(Token = "0x20000BD")]
		public class Particle
		{
			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Vector2 startOffset;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Vector2 endOffset;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal float cycleSpeed;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal float startLifetime;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Color startColor;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal float remainingLifetime;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal float lifeTime;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal double startPercent;

			[Token(Token = "0x6000924")]
			[Address(RVA = "0x23916D4", Offset = "0x23916D4", VA = "0x23916D4")]
			internal double GetSplinePercent(Wrap wrap, ParticleSystem.Particle particle)
			{
				return default(double);
			}

			[Token(Token = "0x6000925")]
			[Address(RVA = "0x23917D8", Offset = "0x23917D8", VA = "0x23917D8")]
			public Particle()
			{
			}
		}

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[HideInInspector]
		public ParticleSystem _particleSystem;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public bool volumetric;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		[HideInInspector]
		public bool emitFromShell;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[HideInInspector]
		public Vector2 scale;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[HideInInspector]
		public EmitPoint emitPoint;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public MotionType motionType;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[HideInInspector]
		public Wrap wrapMode;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public float minCycles;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[HideInInspector]
		public float maxCycles;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ParticleSystem.Particle[] particles;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Particle[] controllers;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int particleCount;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private int birthIndex;

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x1AAF7AC", Offset = "0x1AAF7AC", VA = "0x1AAF7AC", Slot = "13")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x1AAFEA4", Offset = "0x1AAFEA4", VA = "0x1AAFEA4")]
		private void TransformParticle(ref ParticleSystem.Particle particle, Transform trs)
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x1AB1040", Offset = "0x1AB1040", VA = "0x1AB1040")]
		private void InverseTransformParticle(ref ParticleSystem.Particle particle, Transform trs)
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x1AB1850", Offset = "0x1AB1850", VA = "0x1AB1850", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x1AB1108", Offset = "0x1AB1108", VA = "0x1AB1108")]
		private void HandleParticle(int index)
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x1AB192C", Offset = "0x1AB192C", VA = "0x1AB192C")]
		private void OnParticleDie(int index)
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x1AAFF6C", Offset = "0x1AAFF6C", VA = "0x1AAFF6C")]
		private void OnParticleBorn(int index)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x1AB1930", Offset = "0x1AB1930", VA = "0x1AB1930")]
		public ParticleController()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x59B90C", Offset = "0x59B90C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x59B90C", Offset = "0x59B90C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59B90C", Offset = "0x59B90C")]
	public class PathGenerator : MeshGenerator
	{
		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[HideInInspector]
		private int _slices;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[HideInInspector]
		private bool _useShapeCurve;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		[HideInInspector]
		private AnimationCurve _shape;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[HideInInspector]
		private AnimationCurve _lastShape;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[SerializeField]
		[HideInInspector]
		private float _shapeExposure;

		[Token(Token = "0x170002AF")]
		public int slices
		{
			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x1AB1A10", Offset = "0x1AB1A10", VA = "0x1AB1A10")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x1AB1A18", Offset = "0x1AB1A18", VA = "0x1AB1A18")]
			set
			{
			}
		}

		[Token(Token = "0x170002B0")]
		public bool useShapeCurve
		{
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x1AB1A40", Offset = "0x1AB1A40", VA = "0x1AB1A40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x1AB1A48", Offset = "0x1AB1A48", VA = "0x1AB1A48")]
			set
			{
			}
		}

		[Token(Token = "0x170002B1")]
		public float shapeExposure
		{
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x1AB1BF8", Offset = "0x1AB1BF8", VA = "0x1AB1BF8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x1AB1C00", Offset = "0x1AB1C00", VA = "0x1AB1C00")]
			set
			{
			}
		}

		[Token(Token = "0x170002B2")]
		public AnimationCurve shape
		{
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x1AB1CBC", Offset = "0x1AB1CBC", VA = "0x1AB1CBC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x1AB1CC4", Offset = "0x1AB1CC4", VA = "0x1AB1CC4")]
			set
			{
			}
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x1AB2238", Offset = "0x1AB2238", VA = "0x1AB2238", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x1AB22B0", Offset = "0x1AB22B0", VA = "0x1AB22B0", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x1AB22B8", Offset = "0x1AB22B8", VA = "0x1AB22B8", Slot = "18")]
		protected override void BuildMesh()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x1AB2390", Offset = "0x1AB2390", VA = "0x1AB2390")]
		private void GenerateVertices()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x1AB3410", Offset = "0x1AB3410", VA = "0x1AB3410")]
		public PathGenerator()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59B9DC", Offset = "0x59B9DC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x59B9DC", Offset = "0x59B9DC")]
	public class PolygonColliderGenerator : SplineUser
	{
		[Token(Token = "0x20000BE")]
		public enum Type
		{
			[Token(Token = "0x40005E5")]
			Path,
			[Token(Token = "0x40005E6")]
			Shape
		}

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		[HideInInspector]
		private Type _type;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[HideInInspector]
		private float _size;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[HideInInspector]
		private float _offset;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[HideInInspector]
		protected PolygonCollider2D polygonCollider;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		[HideInInspector]
		protected Vector2[] vertices;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public float updateRate;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		protected float lastUpdateTime;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool updateCollider;

		[Token(Token = "0x170002B3")]
		public Type type
		{
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x1AB38AC", Offset = "0x1AB38AC", VA = "0x1AB38AC")]
			get
			{
				return default(Type);
			}
			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x1AB38B4", Offset = "0x1AB38B4", VA = "0x1AB38B4")]
			set
			{
			}
		}

		[Token(Token = "0x170002B4")]
		public float size
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x1AB38D4", Offset = "0x1AB38D4", VA = "0x1AB38D4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x1AB38DC", Offset = "0x1AB38DC", VA = "0x1AB38DC")]
			set
			{
			}
		}

		[Token(Token = "0x170002B5")]
		public float offset
		{
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x1AB3904", Offset = "0x1AB3904", VA = "0x1AB3904")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x1AB390C", Offset = "0x1AB390C", VA = "0x1AB390C")]
			set
			{
			}
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x1AB3934", Offset = "0x1AB3934", VA = "0x1AB3934", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x1AB39A8", Offset = "0x1AB39A8", VA = "0x1AB39A8", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x1AB39B0", Offset = "0x1AB39B0", VA = "0x1AB39B0", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x1AB39B8", Offset = "0x1AB39B8", VA = "0x1AB39B8", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x1AB39C0", Offset = "0x1AB39C0", VA = "0x1AB39C0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x1AB39C8", Offset = "0x1AB39C8", VA = "0x1AB39C8", Slot = "13")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x1AB3ACC", Offset = "0x1AB3ACC", VA = "0x1AB3ACC", Slot = "14")]
		protected override void Build()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x1AB3FC4", Offset = "0x1AB3FC4", VA = "0x1AB3FC4", Slot = "15")]
		protected override void PostBuild()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x1AB3B1C", Offset = "0x1AB3B1C", VA = "0x1AB3B1C")]
		private void GeneratePath()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x1AB3DB8", Offset = "0x1AB3DB8", VA = "0x1AB3DB8")]
		private void GenerateShape()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x1AB4184", Offset = "0x1AB4184", VA = "0x1AB4184")]
		public PolygonColliderGenerator()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005B")]
	public class ColorModifier : SplineSampleModifier
	{
		[Serializable]
		[Token(Token = "0x20000BF")]
		public class ColorKey : Key
		{
			[Token(Token = "0x200010E")]
			public enum BlendMode
			{
				[Token(Token = "0x400071B")]
				Lerp,
				[Token(Token = "0x400071C")]
				Multiply,
				[Token(Token = "0x400071D")]
				Add,
				[Token(Token = "0x400071E")]
				Subtract
			}

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Color color;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public BlendMode blendMode;

			[Token(Token = "0x6000926")]
			[Address(RVA = "0x238DC4C", Offset = "0x238DC4C", VA = "0x238DC4C")]
			public ColorKey(double f, double t, ColorModifier modifier)
			{
			}

			[Token(Token = "0x6000927")]
			[Address(RVA = "0x238DD94", Offset = "0x238DD94", VA = "0x238DD94")]
			public Color Blend(Color input, float percent)
			{
				return default(Color);
			}
		}

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public List<ColorKey> keys;

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x133BF6C", Offset = "0x133BF6C", VA = "0x133BF6C")]
		public ColorModifier()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x133C02C", Offset = "0x133C02C", VA = "0x133C02C", Slot = "4")]
		public override List<Key> GetKeys()
		{
			return null;
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x133C160", Offset = "0x133C160", VA = "0x133C160", Slot = "5")]
		public override void SetKeys(List<Key> input)
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x133C310", Offset = "0x133C310", VA = "0x133C310")]
		public void AddKey(double f, double t)
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x133C3E0", Offset = "0x133C3E0", VA = "0x133C3E0", Slot = "6")]
		public override void Apply(SplineSample result)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005C")]
	public class MeshScaleModifier : SplineSampleModifier
	{
		[Serializable]
		[Token(Token = "0x20000C0")]
		public class ScaleKey : Key
		{
			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector2 scale;

			[Token(Token = "0x6000928")]
			[Address(RVA = "0x238EF64", Offset = "0x238EF64", VA = "0x238EF64")]
			public ScaleKey(double f, double t, MeshScaleModifier modifier)
			{
			}
		}

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public List<ScaleKey> keys;

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x134CC80", Offset = "0x134CC80", VA = "0x134CC80")]
		public MeshScaleModifier()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x134CD40", Offset = "0x134CD40", VA = "0x134CD40", Slot = "4")]
		public override List<Key> GetKeys()
		{
			return null;
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x134CE74", Offset = "0x134CE74", VA = "0x134CE74", Slot = "5")]
		public override void SetKeys(List<Key> input)
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x134D048", Offset = "0x134D048", VA = "0x134D048")]
		public void AddKey(double f, double t)
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x134D118", Offset = "0x134D118", VA = "0x134D118", Slot = "6")]
		public override void Apply(SplineSample result)
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x134D284", Offset = "0x134D284", VA = "0x134D284")]
		public Vector2 GetScale(SplineSample sample)
		{
			return default(Vector2);
		}
	}
	[Serializable]
	[Token(Token = "0x200005D")]
	public class OffsetModifier : SplineSampleModifier
	{
		[Serializable]
		[Token(Token = "0x20000C1")]
		public class OffsetKey : Key
		{
			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector2 offset;

			[Token(Token = "0x6000929")]
			[Address(RVA = "0x2391670", Offset = "0x2391670", VA = "0x2391670")]
			public OffsetKey(Vector2 o, double f, double t, OffsetModifier modifier)
			{
			}
		}

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public List<OffsetKey> keys;

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x1AAF008", Offset = "0x1AAF008", VA = "0x1AAF008")]
		public OffsetModifier()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x1AAF0C8", Offset = "0x1AAF0C8", VA = "0x1AAF0C8", Slot = "4")]
		public override List<Key> GetKeys()
		{
			return null;
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x1AAF1FC", Offset = "0x1AAF1FC", VA = "0x1AAF1FC", Slot = "5")]
		public override void SetKeys(List<Key> input)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x1AAF3AC", Offset = "0x1AAF3AC", VA = "0x1AAF3AC")]
		public void AddKey(Vector2 offset, double f, double t)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x1AAF484", Offset = "0x1AAF484", VA = "0x1AAF484", Slot = "6")]
		public override void Apply(SplineSample result)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x1AAF5E4", Offset = "0x1AAF5E4", VA = "0x1AAF5E4")]
		private Vector2 Evaluate(double time)
		{
			return default(Vector2);
		}
	}
	[Serializable]
	[Token(Token = "0x200005E")]
	public class RotationModifier : SplineSampleModifier
	{
		[Serializable]
		[Token(Token = "0x20000C2")]
		public class RotationKey : Key
		{
			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public bool useLookTarget;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform target;

			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 rotation;

			[Token(Token = "0x600092A")]
			[Address(RVA = "0x239296C", Offset = "0x239296C", VA = "0x239296C")]
			public RotationKey(Vector3 rotation, double f, double t, RotationModifier modifier)
			{
			}
		}

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public List<RotationKey> keys;

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x22CCA6C", Offset = "0x22CCA6C", VA = "0x22CCA6C")]
		public RotationModifier()
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x22CCB2C", Offset = "0x22CCB2C", VA = "0x22CCB2C", Slot = "4")]
		public override List<Key> GetKeys()
		{
			return null;
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x22CCC60", Offset = "0x22CCC60", VA = "0x22CCC60", Slot = "5")]
		public override void SetKeys(List<Key> input)
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x22CCE10", Offset = "0x22CCE10", VA = "0x22CCE10")]
		public void AddKey(Vector3 rotation, double f, double t)
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x22CCEF0", Offset = "0x22CCEF0", VA = "0x22CCEF0", Slot = "6")]
		public override void Apply(SplineSample result)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005F")]
	public class SizeModifier : SplineSampleModifier
	{
		[Serializable]
		[Token(Token = "0x20000C3")]
		public class SizeKey : Key
		{
			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float size;

			[Token(Token = "0x600092B")]
			[Address(RVA = "0x2392B80", Offset = "0x2392B80", VA = "0x2392B80")]
			public SizeKey(double f, double t, SizeModifier modifier)
			{
			}
		}

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public List<SizeKey> keys;

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x22DB560", Offset = "0x22DB560", VA = "0x22DB560")]
		public SizeModifier()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x22DB620", Offset = "0x22DB620", VA = "0x22DB620", Slot = "4")]
		public override List<Key> GetKeys()
		{
			return null;
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x22DB754", Offset = "0x22DB754", VA = "0x22DB754", Slot = "5")]
		public override void SetKeys(List<Key> input)
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x22DB928", Offset = "0x22DB928", VA = "0x22DB928")]
		public void AddKey(double f, double t)
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x22DB9F8", Offset = "0x22DB9F8", VA = "0x22DB9F8", Slot = "6")]
		public override void Apply(SplineSample result)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000060")]
	public class SplineSampleModifier
	{
		[Serializable]
		[Token(Token = "0x20000C4")]
		public class Key
		{
			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			private double _featherStart;

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private double _featherEnd;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private double _centerStart;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private double _centerEnd;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[SerializeField]
			internal SplineSampleModifier modifier;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public AnimationCurve interpolation;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float blend;

			[Token(Token = "0x1700033B")]
			public double start
			{
				[Token(Token = "0x600092C")]
				[Address(RVA = "0x2399C28", Offset = "0x2399C28", VA = "0x2399C28")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x600092D")]
				[Address(RVA = "0x2399C34", Offset = "0x2399C34", VA = "0x2399C34")]
				set
				{
				}
			}

			[Token(Token = "0x1700033C")]
			public double end
			{
				[Token(Token = "0x600092E")]
				[Address(RVA = "0x2399C6C", Offset = "0x2399C6C", VA = "0x2399C6C")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x600092F")]
				[Address(RVA = "0x2399C78", Offset = "0x2399C78", VA = "0x2399C78")]
				set
				{
				}
			}

			[Token(Token = "0x1700033D")]
			public double centerStart
			{
				[Token(Token = "0x6000930")]
				[Address(RVA = "0x2399CB0", Offset = "0x2399CB0", VA = "0x2399CB0")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x6000931")]
				[Address(RVA = "0x2399CBC", Offset = "0x2399CBC", VA = "0x2399CBC")]
				set
				{
				}
			}

			[Token(Token = "0x1700033E")]
			public double centerEnd
			{
				[Token(Token = "0x6000932")]
				[Address(RVA = "0x2399D08", Offset = "0x2399D08", VA = "0x2399D08")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x6000933")]
				[Address(RVA = "0x2399D14", Offset = "0x2399D14", VA = "0x2399D14")]
				set
				{
				}
			}

			[Token(Token = "0x1700033F")]
			public double globalCenterStart
			{
				[Token(Token = "0x6000934")]
				[Address(RVA = "0x2399D60", Offset = "0x2399D60", VA = "0x2399D60")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x6000935")]
				[Address(RVA = "0x2399E14", Offset = "0x2399E14", VA = "0x2399E14")]
				set
				{
				}
			}

			[Token(Token = "0x17000340")]
			public double globalCenterEnd
			{
				[Token(Token = "0x6000936")]
				[Address(RVA = "0x2399F00", Offset = "0x2399F00", VA = "0x2399F00")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x6000937")]
				[Address(RVA = "0x2399F20", Offset = "0x2399F20", VA = "0x2399F20")]
				set
				{
				}
			}

			[Token(Token = "0x17000341")]
			public double position
			{
				[Token(Token = "0x6000938")]
				[Address(RVA = "0x2399F78", Offset = "0x2399F78", VA = "0x2399F78")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x6000939")]
				[Address(RVA = "0x239A02C", Offset = "0x239A02C", VA = "0x239A02C")]
				set
				{
				}
			}

			[Token(Token = "0x600093A")]
			[Address(RVA = "0x238DCAC", Offset = "0x238DCAC", VA = "0x238DCAC")]
			internal Key(double f, double t, SplineSampleModifier modifier)
			{
			}

			[Token(Token = "0x600093B")]
			[Address(RVA = "0x2399E6C", Offset = "0x2399E6C", VA = "0x2399E6C")]
			private double GlobalToLocalPercent(double t)
			{
				return default(double);
			}

			[Token(Token = "0x600093C")]
			[Address(RVA = "0x2399D80", Offset = "0x2399D80", VA = "0x2399D80")]
			private double LocalToGlobalPercent(double t)
			{
				return default(double);
			}

			[Token(Token = "0x600093D")]
			[Address(RVA = "0x239A09C", Offset = "0x239A09C", VA = "0x239A09C")]
			public float Evaluate(double t)
			{
				return default(float);
			}

			[Token(Token = "0x600093E")]
			[Address(RVA = "0x239A180", Offset = "0x239A180", VA = "0x239A180", Slot = "4")]
			public virtual Key Duplicate()
			{
				return null;
			}
		}

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float blend;

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x2698B18", Offset = "0x2698B18", VA = "0x2698B18", Slot = "4")]
		public virtual List<Key> GetKeys()
		{
			return null;
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x2698B98", Offset = "0x2698B98", VA = "0x2698B98", Slot = "5")]
		public virtual void SetKeys(List<Key> input)
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x2698C48", Offset = "0x2698C48", VA = "0x2698C48", Slot = "6")]
		public virtual void Apply(SplineSample result)
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x2698C4C", Offset = "0x2698C4C", VA = "0x2698C4C", Slot = "7")]
		public virtual void Apply(SplineSample source, SplineSample destination)
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x2698C94", Offset = "0x2698C94", VA = "0x2698C94")]
		public SplineSampleModifier()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public delegate void EmptySplineHandler();
	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59BA70", Offset = "0x59BA70")]
	[ExecuteInEditMode]
	public class SplineComputer : MonoBehaviour
	{
		[Token(Token = "0x20000C5")]
		public enum Space
		{
			[Token(Token = "0x40005F7")]
			World,
			[Token(Token = "0x40005F8")]
			Local
		}

		[Token(Token = "0x20000C6")]
		public enum EvaluateMode
		{
			[Token(Token = "0x40005FA")]
			Cached,
			[Token(Token = "0x40005FB")]
			Calculate
		}

		[Token(Token = "0x20000C7")]
		public enum SampleMode
		{
			[Token(Token = "0x40005FD")]
			Default,
			[Token(Token = "0x40005FE")]
			Uniform,
			[Token(Token = "0x40005FF")]
			Optimized
		}

		[Token(Token = "0x20000C8")]
		public enum UpdateMode
		{
			[Token(Token = "0x4000601")]
			Update,
			[Token(Token = "0x4000602")]
			FixedUpdate,
			[Token(Token = "0x4000603")]
			LateUpdate,
			[Token(Token = "0x4000604")]
			AllUpdate,
			[Token(Token = "0x4000605")]
			None
		}

		[Serializable]
		[Token(Token = "0x20000C9")]
		internal class NodeLink
		{
			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			internal Node node;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[SerializeField]
			internal int pointIndex;

			[Token(Token = "0x600093F")]
			[Address(RVA = "0x2392BA8", Offset = "0x2392BA8", VA = "0x2392BA8")]
			internal List<Node.Connection> GetConnections(SplineComputer exclude)
			{
				return null;
			}

			[Token(Token = "0x6000940")]
			[Address(RVA = "0x2392D44", Offset = "0x2392D44", VA = "0x2392D44")]
			public NodeLink()
			{
			}
		}

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[HideInInspector]
		public bool multithreaded;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		[HideInInspector]
		public bool rebuildOnAwake;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public UpdateMode updateMode;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[HideInInspector]
		public TriggerGroup[] triggerGroups;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		[SerializeField]
		private Spline spline;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[HideInInspector]
		[SerializeField]
		private SplineSample[] _rawSamples;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		private SplineSample[] _transformedSamples;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		[SerializeField]
		private SampleCollection sampleCollection;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		[SerializeField]
		private double[] originalSamplePercents;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool[] sampleFlter;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		[SerializeField]
		private int _sampleCount;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[HideInInspector]
		[SerializeField]
		private bool _is2D;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		[HideInInspector]
		[SerializeField]
		private bool hasSamples;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		[SerializeField]
		private bool[] pointsDirty;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[HideInInspector]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59E620", Offset = "0x59E620")]
		private float _optimizeAngleThreshold;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
		private Space _space;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		[SerializeField]
		private SampleMode _sampleMode;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		[SerializeField]
		private SplineUser[] subscribers;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[HideInInspector]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x59E700", Offset = "0x59E700")]
		private NodeLink[] nodes;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool rebuildPending;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool _trsCheck;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Transform _trs;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Matrix4x4 transformMatrix;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Matrix4x4 inverseTransformMatrix;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool queueResample;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		private bool queueRebuild;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector3 lastScale;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private bool uniformScale;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion lastRotation;

		[Token(Token = "0x170002B6")]
		public Space space
		{
			[Token(Token = "0x600060C")]
			[Address(RVA = "0x22E16E8", Offset = "0x22E16E8", VA = "0x22E16E8")]
			get
			{
				return default(Space);
			}
			[Token(Token = "0x600060D")]
			[Address(RVA = "0x22E16F0", Offset = "0x22E16F0", VA = "0x22E16F0")]
			set
			{
			}
		}

		[Token(Token = "0x170002B7")]
		public Spline.Type type
		{
			[Token(Token = "0x600060E")]
			[Address(RVA = "0x22CEFE0", Offset = "0x22CEFE0", VA = "0x22CEFE0")]
			get
			{
				return default(Spline.Type);
			}
			[Token(Token = "0x600060F")]
			[Address(RVA = "0x22E1D98", Offset = "0x22E1D98", VA = "0x22E1D98")]
			set
			{
			}
		}

		[Token(Token = "0x170002B8")]
		public bool linearAverageDirection
		{
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x22E1DF4", Offset = "0x22E1DF4", VA = "0x22E1DF4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000611")]
			[Address(RVA = "0x22E1E14", Offset = "0x22E1E14", VA = "0x22E1E14")]
			set
			{
			}
		}

		[Token(Token = "0x170002B9")]
		public bool is2D
		{
			[Token(Token = "0x6000612")]
			[Address(RVA = "0x22E1E7C", Offset = "0x22E1E7C", VA = "0x22E1E7C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000613")]
			[Address(RVA = "0x22E1E84", Offset = "0x22E1E84", VA = "0x22E1E84")]
			set
			{
			}
		}

		[Token(Token = "0x170002BA")]
		public int sampleRate
		{
			[Token(Token = "0x6000614")]
			[Address(RVA = "0x22CF000", Offset = "0x22CF000", VA = "0x22CF000")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000615")]
			[Address(RVA = "0x22E1ECC", Offset = "0x22E1ECC", VA = "0x22E1ECC")]
			set
			{
			}
		}

		[Token(Token = "0x170002BB")]
		public float optimizeAngleThreshold
		{
			[Token(Token = "0x6000616")]
			[Address(RVA = "0x22E1F30", Offset = "0x22E1F30", VA = "0x22E1F30")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000617")]
			[Address(RVA = "0x22E1F38", Offset = "0x22E1F38", VA = "0x22E1F38")]
			set
			{
			}
		}

		[Token(Token = "0x170002BC")]
		public SampleMode sampleMode
		{
			[Token(Token = "0x6000618")]
			[Address(RVA = "0x22E1F90", Offset = "0x22E1F90", VA = "0x22E1F90")]
			get
			{
				return default(SampleMode);
			}
			[Token(Token = "0x6000619")]
			[Address(RVA = "0x22E1F98", Offset = "0x22E1F98", VA = "0x22E1F98")]
			set
			{
			}
		}

		[Token(Token = "0x170002BD")]
		public AnimationCurve customValueInterpolation
		{
			[Token(Token = "0x600061A")]
			[Address(RVA = "0x22E1FD0", Offset = "0x22E1FD0", VA = "0x22E1FD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600061B")]
			[Address(RVA = "0x22E1FF0", Offset = "0x22E1FF0", VA = "0x22E1FF0")]
			set
			{
			}
		}

		[Token(Token = "0x170002BE")]
		public AnimationCurve customNormalInterpolation
		{
			[Token(Token = "0x600061C")]
			[Address(RVA = "0x22E2034", Offset = "0x22E2034", VA = "0x22E2034")]
			get
			{
				return null;
			}
			[Token(Token = "0x600061D")]
			[Address(RVA = "0x22E2054", Offset = "0x22E2054", VA = "0x22E2054")]
			set
			{
			}
		}

		[Token(Token = "0x170002BF")]
		public int iterations
		{
			[Token(Token = "0x600061E")]
			[Address(RVA = "0x22E2098", Offset = "0x22E2098", VA = "0x22E2098")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170002C0")]
		public double moveStep
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0x22E20BC", Offset = "0x22E20BC", VA = "0x22E20BC")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170002C1")]
		public bool isClosed
		{
			[Token(Token = "0x6000620")]
			[Address(RVA = "0x22CFAC0", Offset = "0x22CFAC0", VA = "0x22CFAC0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170002C2")]
		public int pointCount
		{
			[Token(Token = "0x6000621")]
			[Address(RVA = "0x22E20E0", Offset = "0x22E20E0", VA = "0x22E20E0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170002C3")]
		public SplineSample[] samples
		{
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x22E2110", Offset = "0x22E2110", VA = "0x22E2110")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002C4")]
		public int sampleCount
		{
			[Token(Token = "0x6000623")]
			[Address(RVA = "0x22E2130", Offset = "0x22E2130", VA = "0x22E2130")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170002C5")]
		public SplineSample[] rawSamples
		{
			[Token(Token = "0x6000624")]
			[Address(RVA = "0x22E2138", Offset = "0x22E2138", VA = "0x22E2138")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002C6")]
		public Vector3 position
		{
			[Token(Token = "0x6000625")]
			[Address(RVA = "0x22E2140", Offset = "0x22E2140", VA = "0x22E2140")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170002C7")]
		public Quaternion rotation
		{
			[Token(Token = "0x6000626")]
			[Address(RVA = "0x22E2154", Offset = "0x22E2154", VA = "0x22E2154")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x170002C8")]
		public Vector3 scale
		{
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x22E2164", Offset = "0x22E2164", VA = "0x22E2164")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170002C9")]
		public int subscriberCount
		{
			[Token(Token = "0x6000628")]
			[Address(RVA = "0x22E2178", Offset = "0x22E2178", VA = "0x22E2178")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170002CA")]
		public Transform trs
		{
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x22E2198", Offset = "0x22E2198", VA = "0x22E2198")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002CB")]
		private bool useMultithreading
		{
			[Token(Token = "0x600062C")]
			[Address(RVA = "0x22E2338", Offset = "0x22E2338", VA = "0x22E2338")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000005")]
		public event EmptySplineHandler onRebuild
		{
			[Token(Token = "0x600062A")]
			[Address(RVA = "0x22E21E0", Offset = "0x22E21E0", VA = "0x22E21E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0BC8", Offset = "0x5A0BC8")]
			add
			{
			}
			[Token(Token = "0x600062B")]
			[Address(RVA = "0x22E228C", Offset = "0x22E228C", VA = "0x22E228C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0BD8", Offset = "0x5A0BD8")]
			remove
			{
			}
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x22E2340", Offset = "0x22E2340", VA = "0x22E2340")]
		private void Awake()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x22E25E4", Offset = "0x22E25E4", VA = "0x22E25E4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x22E2894", Offset = "0x22E2894", VA = "0x22E2894")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x22E28A8", Offset = "0x22E28A8", VA = "0x22E28A8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x22E25F8", Offset = "0x22E25F8", VA = "0x22E25F8")]
		private void RunUpdate()
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x22E4024", Offset = "0x22E4024", VA = "0x22E4024")]
		private void TransformSamplesThreaded()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x22E402C", Offset = "0x22E402C", VA = "0x22E402C")]
		private void CalculateAndTransformSamples()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x22E28C0", Offset = "0x22E28C0", VA = "0x22E28C0")]
		private bool TransformHasChanged()
		{
			return default(bool);
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x22E404C", Offset = "0x22E404C", VA = "0x22E404C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x22E4074", Offset = "0x22E4074", VA = "0x22E4074")]
		public void GetSamples(SampleCollection collection)
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x22E23C0", Offset = "0x22E23C0", VA = "0x22E23C0")]
		public void ResampleTransform()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x22E40E0", Offset = "0x22E40E0", VA = "0x22E40E0")]
		public void Subscribe(SplineUser input)
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x22E41F0", Offset = "0x22E41F0", VA = "0x22E41F0")]
		public void Unsubscribe(SplineUser input)
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x22E4304", Offset = "0x22E4304", VA = "0x22E4304")]
		public bool IsSubscribed(SplineUser user)
		{
			return default(bool);
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x22E43EC", Offset = "0x22E43EC", VA = "0x22E43EC")]
		public SplineUser[] GetSubscribers()
		{
			return null;
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x22CF0DC", Offset = "0x22CF0DC", VA = "0x22CF0DC")]
		public SplinePoint[] GetPoints(Space getSpace = Space.World)
		{
			return null;
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x22E4508", Offset = "0x22E4508", VA = "0x22E4508")]
		public SplinePoint GetPoint(int index, Space getSpace = Space.World)
		{
			return default(SplinePoint);
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x22E4770", Offset = "0x22E4770", VA = "0x22E4770")]
		public Vector3 GetPointPosition(int index, Space getSpace = Space.World)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x22E4858", Offset = "0x22E4858", VA = "0x22E4858")]
		public Vector3 GetPointNormal(int index, Space getSpace = Space.World)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x22E495C", Offset = "0x22E495C", VA = "0x22E495C")]
		public Vector3 GetPointTangent(int index, Space getSpace = Space.World)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x22E4A44", Offset = "0x22E4A44", VA = "0x22E4A44")]
		public Vector3 GetPointTangent2(int index, Space getSpace = Space.World)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x22E4B2C", Offset = "0x22E4B2C", VA = "0x22E4B2C")]
		public float GetPointSize(int index, Space getSpace = Space.World)
		{
			return default(float);
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x22E4B80", Offset = "0x22E4B80", VA = "0x22E4B80")]
		public Color GetPointColor(int index, Space getSpace = Space.World)
		{
			return default(Color);
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x22E4BE0", Offset = "0x22E4BE0", VA = "0x22E4BE0")]
		private void Make2D(ref SplinePoint point)
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x22E188C", Offset = "0x22E188C", VA = "0x22E188C")]
		public void SetPoints(SplinePoint[] points, Space setSpace = Space.World)
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x22E5108", Offset = "0x22E5108", VA = "0x22E5108")]
		public void SetPointPosition(int index, Vector3 pos, Space setSpace = Space.World)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x22E55D0", Offset = "0x22E55D0", VA = "0x22E55D0")]
		public void SetPointTangents(int index, Vector3 tan1, Vector3 tan2, Space setSpace = Space.World)
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x22E59E0", Offset = "0x22E59E0", VA = "0x22E59E0")]
		public void SetPointNormal(int index, Vector3 nrm, Space setSpace = Space.World)
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x22E5CAC", Offset = "0x22E5CAC", VA = "0x22E5CAC")]
		public void SetPointSize(int index, float size)
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x22E5EA0", Offset = "0x22E5EA0", VA = "0x22E5EA0")]
		public void SetPointColor(int index, Color color)
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x22E60C8", Offset = "0x22E60C8", VA = "0x22E60C8")]
		public void SetPoint(int index, SplinePoint point, Space setSpace = Space.World)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x22E5360", Offset = "0x22E5360", VA = "0x22E5360")]
		private void AppendPoints(int count)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x22E63F8", Offset = "0x22E63F8", VA = "0x22E63F8")]
		public double GetPointPercent(int pointIndex)
		{
			return default(double);
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x22E6640", Offset = "0x22E6640", VA = "0x22E6640")]
		public int PercentToPointIndex(double percent, Spline.Direction direction = Spline.Direction.Forward)
		{
			return default(int);
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x22E6824", Offset = "0x22E6824", VA = "0x22E6824")]
		public Vector3 EvaluatePosition(double percent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x22E685C", Offset = "0x22E685C", VA = "0x22E685C")]
		public Vector3 EvaluatePosition(double percent, EvaluateMode mode = EvaluateMode.Cached)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x22E6908", Offset = "0x22E6908", VA = "0x22E6908")]
		public Vector3 EvaluatePosition(int pointIndex, EvaluateMode mode = EvaluateMode.Cached)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x22E695C", Offset = "0x22E695C", VA = "0x22E695C")]
		public SplineSample Evaluate(double percent)
		{
			return null;
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x22E697C", Offset = "0x22E697C", VA = "0x22E697C")]
		public SplineSample Evaluate(double percent, EvaluateMode mode = EvaluateMode.Cached)
		{
			return null;
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x22E6A94", Offset = "0x22E6A94", VA = "0x22E6A94")]
		public SplineSample Evaluate(int pointIndex)
		{
			return null;
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x22E6B0C", Offset = "0x22E6B0C", VA = "0x22E6B0C")]
		public void Evaluate(int pointIndex, SplineSample result)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x22E6B58", Offset = "0x22E6B58", VA = "0x22E6B58")]
		public void Evaluate(double percent, SplineSample result)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x22E6A08", Offset = "0x22E6A08", VA = "0x22E6A08")]
		public void Evaluate(double percent, SplineSample result, EvaluateMode mode = EvaluateMode.Cached)
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x22E6CF0", Offset = "0x22E6CF0", VA = "0x22E6CF0")]
		public void Evaluate(ref SplineSample[] results, double from = 0.0, double to = 1.0)
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x22E6D44", Offset = "0x22E6D44", VA = "0x22E6D44")]
		public void EvaluatePositions(ref Vector3[] positions, double from = 0.0, double to = 1.0)
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x22E6D98", Offset = "0x22E6D98", VA = "0x22E6D98")]
		public double Travel(double start, float distance, out float moved, Spline.Direction direction = Spline.Direction.Forward)
		{
			return default(double);
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x22E6DF4", Offset = "0x22E6DF4", VA = "0x22E6DF4")]
		public double Travel(double start, float distance, Spline.Direction direction = Spline.Direction.Forward)
		{
			return default(double);
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x22E6E58", Offset = "0x22E6E58", VA = "0x22E6E58")]
		public void Project(SplineSample result, Vector3 position, double from = 0.0, double to = 1.0, EvaluateMode mode = EvaluateMode.Cached, int subdivisions = 4)
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x22E6F7C", Offset = "0x22E6F7C", VA = "0x22E6F7C")]
		public SplineSample Project(Vector3 point, double from = 0.0, double to = 1.0)
		{
			return null;
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x22E7034", Offset = "0x22E7034", VA = "0x22E7034")]
		public float CalculateLength(double from = 0.0, double to = 1.0)
		{
			return default(float);
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x22E6B9C", Offset = "0x22E6B9C", VA = "0x22E6B9C")]
		private void TransformResult(SplineSample result)
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x22E1D6C", Offset = "0x22E1D6C", VA = "0x22E1D6C")]
		public void Rebuild(bool forceUpdateAll = false)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x22E237C", Offset = "0x22E237C", VA = "0x22E237C")]
		public void RebuildImmediate(bool calculateSamples = true, bool forceUpdateAll = false)
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x22E2E04", Offset = "0x22E2E04", VA = "0x22E2E04")]
		private void RebuildUsers()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x22E7090", Offset = "0x22E7090", VA = "0x22E7090")]
		private void UnsetPointsDirty()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x22E3EFC", Offset = "0x22E3EFC", VA = "0x22E3EFC")]
		private void SetPointsDirty()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x22E4CB0", Offset = "0x22E4CB0", VA = "0x22E4CB0")]
		private void SetDirty(int index)
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x22E3008", Offset = "0x22E3008", VA = "0x22E3008")]
		private void CalculateSamples()
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x22E36C0", Offset = "0x22E36C0", VA = "0x22E36C0")]
		private void TransformSamples(bool forceTransformAll = false)
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x22E759C", Offset = "0x22E759C", VA = "0x22E759C")]
		private void OptimizeSamples()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x22E71B8", Offset = "0x22E71B8", VA = "0x22E71B8")]
		private bool IsDirtyBezier(double samplePercent)
		{
			return default(bool);
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x22E733C", Offset = "0x22E733C", VA = "0x22E733C")]
		private bool IsDirtyHermite(double samplePercent)
		{
			return default(bool);
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x22E4C20", Offset = "0x22E4C20", VA = "0x22E4C20")]
		public void Break()
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x22E7B04", Offset = "0x22E7B04", VA = "0x22E7B04")]
		public void Break(int at)
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x22E7BAC", Offset = "0x22E7BAC", VA = "0x22E7BAC")]
		public void Close()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x22E7C3C", Offset = "0x22E7C3C", VA = "0x22E7C3C")]
		public void CatToBezierTangents()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x22E7C84", Offset = "0x22E7C84", VA = "0x22E7C84")]
		public bool Raycast(out RaycastHit hit, out double hitPercent, LayerMask layerMask, double resolution = 1.0, double from = 0.0, double to = 1.0, QueryTriggerInteraction hitTriggers = QueryTriggerInteraction.UseGlobal)
		{
			return default(bool);
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x22E7F70", Offset = "0x22E7F70", VA = "0x22E7F70")]
		public bool RaycastAll(out RaycastHit[] hits, out double[] hitPercents, LayerMask layerMask, double resolution = 1.0, double from = 0.0, double to = 1.0, QueryTriggerInteraction hitTriggers = QueryTriggerInteraction.UseGlobal)
		{
			return default(bool);
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x22E84B4", Offset = "0x22E84B4", VA = "0x22E84B4")]
		public void CheckTriggers(double start, double end, [Optional] SplineUser user)
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x22E8564", Offset = "0x22E8564", VA = "0x22E8564")]
		public void CheckTriggers(int group, double start, double end)
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x22E86E0", Offset = "0x22E86E0", VA = "0x22E86E0")]
		public void ResetTriggers()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x22E8760", Offset = "0x22E8760", VA = "0x22E8760")]
		public void ResetTriggers(int group)
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x22E8954", Offset = "0x22E8954", VA = "0x22E8954")]
		public List<Node.Connection> GetJunctions(int pointIndex)
		{
			return null;
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x22E8A98", Offset = "0x22E8A98", VA = "0x22E8A98")]
		public Dictionary<int, List<Node.Connection>> GetJunctions(double start = 0.0, double end = 1.0)
		{
			return null;
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x22E8EA8", Offset = "0x22E8EA8", VA = "0x22E8EA8")]
		public void ConnectNode(Node node, int pointIndex)
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x22E9704", Offset = "0x22E9704", VA = "0x22E9704")]
		public void DisconnectNode(int pointIndex)
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x22E962C", Offset = "0x22E962C", VA = "0x22E962C")]
		private void AddNodeLink(Node node, int pointIndex)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x22E984C", Offset = "0x22E984C", VA = "0x22E984C")]
		public Dictionary<int, Node> GetNodes(double start = 0.0, double end = 1.0)
		{
			return null;
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x22E9C4C", Offset = "0x22E9C4C", VA = "0x22E9C4C")]
		public Node GetNode(int pointIndex)
		{
			return null;
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x22E9D30", Offset = "0x22E9D30", VA = "0x22E9D30")]
		public void TransferNode(int pointIndex, int newPointIndex)
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x22E9F70", Offset = "0x22E9F70", VA = "0x22E9F70")]
		public void ShiftNodes(int startIndex, int endIndex, int shift)
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x22EA09C", Offset = "0x22EA09C", VA = "0x22EA09C")]
		public void GetConnectedComputers(List<SplineComputer> computers, List<int> connectionIndices, List<int> connectedIndices, double percent, Spline.Direction direction, bool includeEqual)
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x22EA570", Offset = "0x22EA570", VA = "0x22EA570")]
		public List<SplineComputer> GetConnectedComputers()
		{
			return null;
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x22E67DC", Offset = "0x22E67DC", VA = "0x22E67DC")]
		public void GetSamplingValues(double percent, out int index, out double lerp)
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x22EA65C", Offset = "0x22EA65C", VA = "0x22EA65C")]
		private void GetConnectedComputers(ref List<SplineComputer> computers)
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x22EAA48", Offset = "0x22EAA48", VA = "0x22EAA48")]
		private void RemoveNodeLinkAt(int index)
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x22E5450", Offset = "0x22E5450", VA = "0x22E5450")]
		private void SetNodeForPoint(int index, SplinePoint worldPoint)
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x22E4D64", Offset = "0x22E4D64", VA = "0x22E4D64")]
		private void UpdateConnectedNodes(SplinePoint[] worldPoints)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x22E29F8", Offset = "0x22E29F8", VA = "0x22E29F8")]
		private void UpdateConnectedNodes()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x22E4480", Offset = "0x22E4480", VA = "0x22E4480")]
		public Vector3 TransformPoint(Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x22E4C28", Offset = "0x22E4C28", VA = "0x22E4C28")]
		public Vector3 InverseTransformPoint(Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x22E44C4", Offset = "0x22E44C4", VA = "0x22E44C4")]
		public Vector3 TransformDirection(Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x22E4C6C", Offset = "0x22E4C6C", VA = "0x22E4C6C")]
		public Vector3 InverseTransformDirection(Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x22EABCC", Offset = "0x22EABCC", VA = "0x22EABCC")]
		public SplineComputer()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public delegate void SplineReachHandler();
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59BAB8", Offset = "0x59BAB8")]
	public class SplineFollower : SplineTracer
	{
		[Token(Token = "0x20000CA")]
		public enum FollowMode
		{
			[Token(Token = "0x4000609")]
			Uniform,
			[Token(Token = "0x400060A")]
			Time
		}

		[Token(Token = "0x20000CB")]
		public enum Wrap
		{
			[Token(Token = "0x400060C")]
			Default,
			[Token(Token = "0x400060D")]
			Loop,
			[Token(Token = "0x400060E")]
			PingPong
		}

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public Wrap wrapMode;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[HideInInspector]
		public FollowMode followMode;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		public bool autoStartPosition;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		[HideInInspector]
		public bool follow;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[SerializeField]
		[HideInInspector]
		private float _followSpeed;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[HideInInspector]
		private float _followDuration;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59E828", Offset = "0x59E828")]
		private double _startPosition;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private double lastClippedPercent;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool followStarted;

		[Token(Token = "0x170002CC")]
		public float followSpeed
		{
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x268A0C0", Offset = "0x268A0C0", VA = "0x268A0C0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x268A0C8", Offset = "0x268A0C8", VA = "0x268A0C8")]
			set
			{
			}
		}

		[Token(Token = "0x170002CD")]
		public double startPosition
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x268A0F0", Offset = "0x268A0F0", VA = "0x268A0F0")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x268A0FC", Offset = "0x268A0FC", VA = "0x268A0FC")]
			set
			{
			}
		}

		[Token(Token = "0x170002CE")]
		public float followDuration
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x268A178", Offset = "0x268A178", VA = "0x268A178")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x268A180", Offset = "0x268A180", VA = "0x268A180")]
			set
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event SplineReachHandler onEndReached
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x268A1A8", Offset = "0x268A1A8", VA = "0x268A1A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0BE8", Offset = "0x5A0BE8")]
			add
			{
			}
			[Token(Token = "0x6000696")]
			[Address(RVA = "0x268A254", Offset = "0x268A254", VA = "0x268A254")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0BF8", Offset = "0x5A0BF8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event SplineReachHandler onBeginningReached
		{
			[Token(Token = "0x6000697")]
			[Address(RVA = "0x268A300", Offset = "0x268A300", VA = "0x268A300")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0C08", Offset = "0x5A0C08")]
			add
			{
			}
			[Token(Token = "0x6000698")]
			[Address(RVA = "0x268A3AC", Offset = "0x268A3AC", VA = "0x268A3AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0C18", Offset = "0x5A0C18")]
			remove
			{
			}
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x268A458", Offset = "0x268A458", VA = "0x268A458", Slot = "18")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x268A54C", Offset = "0x268A54C", VA = "0x268A54C", Slot = "13")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x268A6D0", Offset = "0x268A6D0", VA = "0x268A6D0", Slot = "15")]
		protected override void PostBuild()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x268A560", Offset = "0x268A560", VA = "0x268A560")]
		private void Follow()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x268B418", Offset = "0x268B418", VA = "0x268B418")]
		public void Restart(double startPosition = 0.0)
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x268B450", Offset = "0x268B450", VA = "0x268B450", Slot = "19")]
		public override void SetPercent(double percent, bool checkTriggers = false, bool handleJuncitons = false)
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x268B53C", Offset = "0x268B53C", VA = "0x268B53C", Slot = "20")]
		public override void SetDistance(float distance, bool checkTriggers = false, bool handleJuncitons = false)
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x268B0B8", Offset = "0x268B0B8", VA = "0x268B0B8")]
		public void Move(double percent)
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x268AC34", Offset = "0x268AC34", VA = "0x268AC34")]
		public void Move(float distance)
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x268C4D4", Offset = "0x268C4D4", VA = "0x268C4D4")]
		public SplineFollower()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x59BAEC", Offset = "0x59BAEC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x59BAEC", Offset = "0x59BAEC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59BAEC", Offset = "0x59BAEC")]
	public class SplineMesh : MeshGenerator
	{
		[Serializable]
		[Token(Token = "0x20000CC")]
		public class Channel
		{
			[Token(Token = "0x200010F")]
			public delegate float FloatHandler(double percent);

			[Token(Token = "0x2000110")]
			public delegate Vector2 Vector2Handler(double percent);

			[Token(Token = "0x2000111")]
			public delegate Vector3 Vector3Handler(double percent);

			[Token(Token = "0x2000112")]
			public delegate Quaternion QuaternionHandler(double percent);

			[Token(Token = "0x2000113")]
			public enum Type
			{
				[Token(Token = "0x4000720")]
				Extrude,
				[Token(Token = "0x4000721")]
				Place
			}

			[Token(Token = "0x2000114")]
			public enum UVOverride
			{
				[Token(Token = "0x4000723")]
				None,
				[Token(Token = "0x4000724")]
				ClampU,
				[Token(Token = "0x4000725")]
				ClampV,
				[Token(Token = "0x4000726")]
				UniformU,
				[Token(Token = "0x4000727")]
				UniformV
			}

			[Serializable]
			[Token(Token = "0x2000115")]
			public class MeshDefinition
			{
				[Token(Token = "0x200011A")]
				public enum MirrorMethod
				{
					[Token(Token = "0x400074B")]
					None,
					[Token(Token = "0x400074C")]
					X,
					[Token(Token = "0x400074D")]
					Y,
					[Token(Token = "0x400074E")]
					Z
				}

				[Serializable]
				[Token(Token = "0x200011B")]
				public class Submesh
				{
					[Token(Token = "0x400074F")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
					public int[] triangles;

					[Token(Token = "0x6000A54")]
					[Address(RVA = "0x23A06B8", Offset = "0x23A06B8", VA = "0x23A06B8")]
					public Submesh()
					{
					}

					[Token(Token = "0x6000A55")]
					[Address(RVA = "0x239C428", Offset = "0x239C428", VA = "0x239C428")]
					public Submesh(int[] input)
					{
					}
				}

				[Serializable]
				[Token(Token = "0x200011C")]
				public class VertexGroup
				{
					[Token(Token = "0x4000750")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
					public float value;

					[Token(Token = "0x4000751")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
					public double percent;

					[Token(Token = "0x4000752")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
					public int[] ids;

					[Token(Token = "0x6000A56")]
					[Address(RVA = "0x239FEF0", Offset = "0x239FEF0", VA = "0x239FEF0")]
					public VertexGroup(float val, double perc, int[] vertIds)
					{
					}

					[Token(Token = "0x6000A57")]
					[Address(RVA = "0x239FF2C", Offset = "0x239FF2C", VA = "0x239FF2C")]
					public void AddId(int id)
					{
					}
				}

				[Token(Token = "0x4000728")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[SerializeField]
				[HideInInspector]
				internal Vector3[] vertices;

				[Token(Token = "0x4000729")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[SerializeField]
				[HideInInspector]
				internal Vector3[] normals;

				[Token(Token = "0x400072A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[SerializeField]
				[HideInInspector]
				internal Vector4[] tangents;

				[Token(Token = "0x400072B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[SerializeField]
				[HideInInspector]
				internal Color[] colors;

				[Token(Token = "0x400072C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[SerializeField]
				[HideInInspector]
				internal Vector2[] uv;

				[Token(Token = "0x400072D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				[SerializeField]
				[HideInInspector]
				internal Vector2[] uv2;

				[Token(Token = "0x400072E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				[SerializeField]
				[HideInInspector]
				internal Vector2[] uv3;

				[Token(Token = "0x400072F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				[SerializeField]
				[HideInInspector]
				internal Vector2[] uv4;

				[Token(Token = "0x4000730")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				[SerializeField]
				[HideInInspector]
				internal int[] triangles;

				[Token(Token = "0x4000731")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				[SerializeField]
				[HideInInspector]
				internal List<Submesh> subMeshes;

				[Token(Token = "0x4000732")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				[SerializeField]
				[HideInInspector]
				internal TS_Bounds bounds;

				[Token(Token = "0x4000733")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
				[SerializeField]
				[HideInInspector]
				internal List<VertexGroup> vertexGroups;

				[Token(Token = "0x4000734")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				[SerializeField]
				[HideInInspector]
				private Mesh _mesh;

				[Token(Token = "0x4000735")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
				[SerializeField]
				[HideInInspector]
				private Vector3 _rotation;

				[Token(Token = "0x4000736")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				[SerializeField]
				[HideInInspector]
				private Vector3 _offset;

				[Token(Token = "0x4000737")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
				[SerializeField]
				[HideInInspector]
				private Vector3 _scale;

				[Token(Token = "0x4000738")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				[SerializeField]
				[HideInInspector]
				private Vector2 _uvScale;

				[Token(Token = "0x4000739")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				[SerializeField]
				[HideInInspector]
				private Vector2 _uvOffset;

				[Token(Token = "0x400073A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				[SerializeField]
				[HideInInspector]
				private float _uvRotation;

				[Token(Token = "0x400073B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
				[SerializeField]
				[HideInInspector]
				private MirrorMethod _mirror;

				[Token(Token = "0x400073C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				[SerializeField]
				[HideInInspector]
				private float _vertexGroupingMargin;

				[Token(Token = "0x400073D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
				[SerializeField]
				[HideInInspector]
				private bool _removeInnerFaces;

				[Token(Token = "0x400073E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
				[SerializeField]
				[HideInInspector]
				private bool _flipFaces;

				[Token(Token = "0x400073F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x7E")]
				[SerializeField]
				[HideInInspector]
				private bool _doubleSided;

				[Token(Token = "0x17000373")]
				public Mesh mesh
				{
					[Token(Token = "0x6000A2A")]
					[Address(RVA = "0x239C070", Offset = "0x239C070", VA = "0x239C070")]
					get
					{
						return null;
					}
					[Token(Token = "0x6000A2B")]
					[Address(RVA = "0x239C078", Offset = "0x239C078", VA = "0x239C078")]
					set
					{
					}
				}

				[Token(Token = "0x17000374")]
				public Vector3 rotation
				{
					[Token(Token = "0x6000A2C")]
					[Address(RVA = "0x239C124", Offset = "0x239C124", VA = "0x239C124")]
					get
					{
						return default(Vector3);
					}
					[Token(Token = "0x6000A2D")]
					[Address(RVA = "0x239C138", Offset = "0x239C138", VA = "0x239C138")]
					set
					{
					}
				}

				[Token(Token = "0x17000375")]
				public Vector3 offset
				{
					[Token(Token = "0x6000A2E")]
					[Address(RVA = "0x239C1A4", Offset = "0x239C1A4", VA = "0x239C1A4")]
					get
					{
						return default(Vector3);
					}
					[Token(Token = "0x6000A2F")]
					[Address(RVA = "0x239C1B8", Offset = "0x239C1B8", VA = "0x239C1B8")]
					set
					{
					}
				}

				[Token(Token = "0x17000376")]
				public Vector3 scale
				{
					[Token(Token = "0x6000A30")]
					[Address(RVA = "0x239C224", Offset = "0x239C224", VA = "0x239C224")]
					get
					{
						return default(Vector3);
					}
					[Token(Token = "0x6000A31")]
					[Address(RVA = "0x239C238", Offset = "0x239C238", VA = "0x239C238")]
					set
					{
					}
				}

				[Token(Token = "0x17000377")]
				public Vector2 uvScale
				{
					[Token(Token = "0x6000A32")]
					[Address(RVA = "0x239C2A4", Offset = "0x239C2A4", VA = "0x239C2A4")]
					get
					{
						return default(Vector2);
					}
					[Token(Token = "0x6000A33")]
					[Address(RVA = "0x239C2B8", Offset = "0x239C2B8", VA = "0x239C2B8")]
					set
					{
					}
				}

				[Token(Token = "0x17000378")]
				public Vector2 uvOffset
				{
					[Token(Token = "0x6000A34")]
					[Address(RVA = "0x239C2F8", Offset = "0x239C2F8", VA = "0x239C2F8")]
					get
					{
						return default(Vector2);
					}
					[Token(Token = "0x6000A35")]
					[Address(RVA = "0x239C30C", Offset = "0x239C30C", VA = "0x239C30C")]
					set
					{
					}
				}

				[Token(Token = "0x17000379")]
				public float uvRotation
				{
					[Token(Token = "0x6000A36")]
					[Address(RVA = "0x239C34C", Offset = "0x239C34C", VA = "0x239C34C")]
					get
					{
						return default(float);
					}
					[Token(Token = "0x6000A37")]
					[Address(RVA = "0x239C354", Offset = "0x239C354", VA = "0x239C354")]
					set
					{
					}
				}

				[Token(Token = "0x1700037A")]
				public float vertexGroupingMargin
				{
					[Token(Token = "0x6000A38")]
					[Address(RVA = "0x239C370", Offset = "0x239C370", VA = "0x239C370")]
					get
					{
						return default(float);
					}
					[Token(Token = "0x6000A39")]
					[Address(RVA = "0x239C378", Offset = "0x239C378", VA = "0x239C378")]
					set
					{
					}
				}

				[Token(Token = "0x1700037B")]
				public MirrorMethod mirror
				{
					[Token(Token = "0x6000A3A")]
					[Address(RVA = "0x239C394", Offset = "0x239C394", VA = "0x239C394")]
					get
					{
						return default(MirrorMethod);
					}
					[Token(Token = "0x6000A3B")]
					[Address(RVA = "0x239C39C", Offset = "0x239C39C", VA = "0x239C39C")]
					set
					{
					}
				}

				[Token(Token = "0x1700037C")]
				public bool removeInnerFaces
				{
					[Token(Token = "0x6000A3C")]
					[Address(RVA = "0x239C3B0", Offset = "0x239C3B0", VA = "0x239C3B0")]
					get
					{
						return default(bool);
					}
					[Token(Token = "0x6000A3D")]
					[Address(RVA = "0x239C3B8", Offset = "0x239C3B8", VA = "0x239C3B8")]
					set
					{
					}
				}

				[Token(Token = "0x1700037D")]
				public bool flipFaces
				{
					[Token(Token = "0x6000A3E")]
					[Address(RVA = "0x239C3D8", Offset = "0x239C3D8", VA = "0x239C3D8")]
					get
					{
						return default(bool);
					}
					[Token(Token = "0x6000A3F")]
					[Address(RVA = "0x239C3E0", Offset = "0x239C3E0", VA = "0x239C3E0")]
					set
					{
					}
				}

				[Token(Token = "0x1700037E")]
				public bool doubleSided
				{
					[Token(Token = "0x6000A40")]
					[Address(RVA = "0x239C400", Offset = "0x239C400", VA = "0x239C400")]
					get
					{
						return default(bool);
					}
					[Token(Token = "0x6000A41")]
					[Address(RVA = "0x239C408", Offset = "0x239C408", VA = "0x239C408")]
					set
					{
					}
				}

				[Token(Token = "0x6000A42")]
				[Address(RVA = "0x239413C", Offset = "0x239413C", VA = "0x239413C")]
				internal MeshDefinition Copy()
				{
					return null;
				}

				[Token(Token = "0x6000A43")]
				[Address(RVA = "0x2393AF8", Offset = "0x2393AF8", VA = "0x2393AF8")]
				public MeshDefinition(Mesh input)
				{
				}

				[Token(Token = "0x6000A44")]
				[Address(RVA = "0x23960B8", Offset = "0x23960B8", VA = "0x23960B8")]
				public void Refresh()
				{
				}

				[Token(Token = "0x6000A45")]
				[Address(RVA = "0x239D9D4", Offset = "0x239D9D4", VA = "0x239D9D4")]
				private void RemoveInnerFaces()
				{
				}

				[Token(Token = "0x6000A46")]
				[Address(RVA = "0x239CF40", Offset = "0x239CF40", VA = "0x239CF40")]
				private void FlipFaces()
				{
				}

				[Token(Token = "0x6000A47")]
				[Address(RVA = "0x239CB24", Offset = "0x239CB24", VA = "0x239CB24")]
				private void DoubleSided()
				{
				}

				[Token(Token = "0x6000A48")]
				[Address(RVA = "0x239E5A8", Offset = "0x239E5A8", VA = "0x239E5A8")]
				public void Write(TS_Mesh target, int forceMaterialId = -1)
				{
				}

				[Token(Token = "0x6000A49")]
				[Address(RVA = "0x239D6A4", Offset = "0x239D6A4", VA = "0x239D6A4")]
				private void CalculateBounds()
				{
				}

				[Token(Token = "0x6000A4A")]
				[Address(RVA = "0x239C4F0", Offset = "0x239C4F0", VA = "0x239C4F0")]
				private void Mirror()
				{
				}

				[Token(Token = "0x6000A4B")]
				[Address(RVA = "0x239D10C", Offset = "0x239D10C", VA = "0x239D10C")]
				private void TransformVertices()
				{
				}

				[Token(Token = "0x6000A4C")]
				[Address(RVA = "0x239E000", Offset = "0x239E000", VA = "0x239E000")]
				private void GroupVertices()
				{
				}

				[Token(Token = "0x6000A4D")]
				[Address(RVA = "0x239FDAC", Offset = "0x239FDAC", VA = "0x239FDAC")]
				private int FindInsertIndex(Vector3 pos, float value)
				{
					return default(int);
				}

				[Token(Token = "0x6000A4E")]
				[Address(RVA = "0x239F18C", Offset = "0x239F18C", VA = "0x239F18C")]
				private void CalculateTangents()
				{
				}
			}

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string name;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private System.Random iterationRandom;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			[HideInInspector]
			private int _iterationSeed;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[SerializeField]
			[HideInInspector]
			private int _offsetSeed;

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private System.Random offsetRandom;

			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Vector2Handler _offsetHandler;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[HideInInspector]
			private int _rotationSeed;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private System.Random rotationRandom;

			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private QuaternionHandler _placeRotationHandler;

			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private FloatHandler _extrudeRotationHandler;

			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[SerializeField]
			[HideInInspector]
			private int _scaleSeed;

			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private System.Random scaleRandom;

			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Vector3Handler _scaleHandler;

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[SerializeField]
			internal SplineMesh owner;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[SerializeField]
			[HideInInspector]
			private List<MeshDefinition> meshes;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[SerializeField]
			[HideInInspector]
			private double _clipFrom;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[SerializeField]
			[HideInInspector]
			private double _clipTo;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[SerializeField]
			[HideInInspector]
			private bool _randomOrder;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[SerializeField]
			[HideInInspector]
			private UVOverride _overrideUVs;

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[SerializeField]
			[HideInInspector]
			private Vector2 _uvScale;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[SerializeField]
			[HideInInspector]
			private Vector2 _uvOffset;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[SerializeField]
			[HideInInspector]
			private bool _overrideNormal;

			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[SerializeField]
			[HideInInspector]
			private Vector3 _customNormal;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[SerializeField]
			[HideInInspector]
			private Type _type;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[SerializeField]
			[HideInInspector]
			private int _count;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[SerializeField]
			[HideInInspector]
			private bool _autoCount;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[SerializeField]
			[HideInInspector]
			private double _spacing;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[SerializeField]
			[HideInInspector]
			private bool _randomRotation;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[SerializeField]
			[HideInInspector]
			private Vector3 _minRotation;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[SerializeField]
			[HideInInspector]
			private Vector3 _maxRotation;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[SerializeField]
			[HideInInspector]
			private bool _randomOffset;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[SerializeField]
			[HideInInspector]
			private Vector2 _minOffset;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[SerializeField]
			[HideInInspector]
			private Vector2 _maxOffset;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[SerializeField]
			[HideInInspector]
			private bool _randomScale;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
			[SerializeField]
			[HideInInspector]
			private bool _uniformRandomScale;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[SerializeField]
			[HideInInspector]
			private Vector3 _minScale;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[SerializeField]
			[HideInInspector]
			private Vector3 _maxScale;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			private int iterator;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			[SerializeField]
			[HideInInspector]
			private bool _overrideMaterialID;

			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[SerializeField]
			[HideInInspector]
			private int _targetMaterialID;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[SerializeField]
			[HideInInspector]
			protected MeshScaleModifier _scaleModifier;

			[Token(Token = "0x17000342")]
			public double clipFrom
			{
				[Token(Token = "0x6000941")]
				[Address(RVA = "0x2392D4C", Offset = "0x2392D4C", VA = "0x2392D4C")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x6000942")]
				[Address(RVA = "0x2392D58", Offset = "0x2392D58", VA = "0x2392D58")]
				set
				{
				}
			}

			[Token(Token = "0x17000343")]
			public double clipTo
			{
				[Token(Token = "0x6000943")]
				[Address(RVA = "0x2392E20", Offset = "0x2392E20", VA = "0x2392E20")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x6000944")]
				[Address(RVA = "0x2392E2C", Offset = "0x2392E2C", VA = "0x2392E2C")]
				set
				{
				}
			}

			[Token(Token = "0x17000344")]
			public bool randomOffset
			{
				[Token(Token = "0x6000945")]
				[Address(RVA = "0x2392E48", Offset = "0x2392E48", VA = "0x2392E48")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000946")]
				[Address(RVA = "0x2392E50", Offset = "0x2392E50", VA = "0x2392E50")]
				set
				{
				}
			}

			[Token(Token = "0x17000345")]
			public Vector2Handler offsetHandler
			{
				[Token(Token = "0x6000947")]
				[Address(RVA = "0x2392E70", Offset = "0x2392E70", VA = "0x2392E70")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000948")]
				[Address(RVA = "0x2392E78", Offset = "0x2392E78", VA = "0x2392E78")]
				set
				{
				}
			}

			[Token(Token = "0x17000346")]
			public bool overrideMaterialID
			{
				[Token(Token = "0x6000949")]
				[Address(RVA = "0x2392EC4", Offset = "0x2392EC4", VA = "0x2392EC4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600094A")]
				[Address(RVA = "0x2392ECC", Offset = "0x2392ECC", VA = "0x2392ECC")]
				set
				{
				}
			}

			[Token(Token = "0x17000347")]
			public int targetMaterialID
			{
				[Token(Token = "0x600094B")]
				[Address(RVA = "0x2392EEC", Offset = "0x2392EEC", VA = "0x2392EEC")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600094C")]
				[Address(RVA = "0x2392EF4", Offset = "0x2392EF4", VA = "0x2392EF4")]
				set
				{
				}
			}

			[Token(Token = "0x17000348")]
			public bool randomRotation
			{
				[Token(Token = "0x600094D")]
				[Address(RVA = "0x2392F08", Offset = "0x2392F08", VA = "0x2392F08")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600094E")]
				[Address(RVA = "0x2392F10", Offset = "0x2392F10", VA = "0x2392F10")]
				set
				{
				}
			}

			[Token(Token = "0x17000349")]
			public QuaternionHandler placeRotationHandler
			{
				[Token(Token = "0x600094F")]
				[Address(RVA = "0x2392F30", Offset = "0x2392F30", VA = "0x2392F30")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000950")]
				[Address(RVA = "0x2392F38", Offset = "0x2392F38", VA = "0x2392F38")]
				set
				{
				}
			}

			[Token(Token = "0x1700034A")]
			public FloatHandler extrudeRotationHandler
			{
				[Token(Token = "0x6000951")]
				[Address(RVA = "0x2392F84", Offset = "0x2392F84", VA = "0x2392F84")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000952")]
				[Address(RVA = "0x2392F8C", Offset = "0x2392F8C", VA = "0x2392F8C")]
				set
				{
				}
			}

			[Token(Token = "0x1700034B")]
			public bool randomScale
			{
				[Token(Token = "0x6000953")]
				[Address(RVA = "0x2392FD8", Offset = "0x2392FD8", VA = "0x2392FD8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000954")]
				[Address(RVA = "0x2392FE0", Offset = "0x2392FE0", VA = "0x2392FE0")]
				set
				{
				}
			}

			[Token(Token = "0x1700034C")]
			public Vector3Handler scaleHandler
			{
				[Token(Token = "0x6000955")]
				[Address(RVA = "0x2393000", Offset = "0x2393000", VA = "0x2393000")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000956")]
				[Address(RVA = "0x2393008", Offset = "0x2393008", VA = "0x2393008")]
				set
				{
				}
			}

			[Token(Token = "0x1700034D")]
			public bool uniformRandomScale
			{
				[Token(Token = "0x6000957")]
				[Address(RVA = "0x2393054", Offset = "0x2393054", VA = "0x2393054")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000958")]
				[Address(RVA = "0x239305C", Offset = "0x239305C", VA = "0x239305C")]
				set
				{
				}
			}

			[Token(Token = "0x1700034E")]
			public int offsetSeed
			{
				[Token(Token = "0x6000959")]
				[Address(RVA = "0x239307C", Offset = "0x239307C", VA = "0x239307C")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600095A")]
				[Address(RVA = "0x2393084", Offset = "0x2393084", VA = "0x2393084")]
				set
				{
				}
			}

			[Token(Token = "0x1700034F")]
			public int rotationSeed
			{
				[Token(Token = "0x600095B")]
				[Address(RVA = "0x2393098", Offset = "0x2393098", VA = "0x2393098")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600095C")]
				[Address(RVA = "0x23930A0", Offset = "0x23930A0", VA = "0x23930A0")]
				set
				{
				}
			}

			[Token(Token = "0x17000350")]
			public int scaleSeed
			{
				[Token(Token = "0x600095D")]
				[Address(RVA = "0x23930B4", Offset = "0x23930B4", VA = "0x23930B4")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600095E")]
				[Address(RVA = "0x23930BC", Offset = "0x23930BC", VA = "0x23930BC")]
				set
				{
				}
			}

			[Token(Token = "0x17000351")]
			public double spacing
			{
				[Token(Token = "0x600095F")]
				[Address(RVA = "0x23930D0", Offset = "0x23930D0", VA = "0x23930D0")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x6000960")]
				[Address(RVA = "0x23930DC", Offset = "0x23930DC", VA = "0x23930DC")]
				set
				{
				}
			}

			[Token(Token = "0x17000352")]
			public Vector2 minOffset
			{
				[Token(Token = "0x6000961")]
				[Address(RVA = "0x23930F8", Offset = "0x23930F8", VA = "0x23930F8")]
				get
				{
					return default(Vector2);
				}
				[Token(Token = "0x6000962")]
				[Address(RVA = "0x2393104", Offset = "0x2393104", VA = "0x2393104")]
				set
				{
				}
			}

			[Token(Token = "0x17000353")]
			public Vector2 maxOffset
			{
				[Token(Token = "0x6000963")]
				[Address(RVA = "0x2393148", Offset = "0x2393148", VA = "0x2393148")]
				get
				{
					return default(Vector2);
				}
				[Token(Token = "0x6000964")]
				[Address(RVA = "0x2393154", Offset = "0x2393154", VA = "0x2393154")]
				set
				{
				}
			}

			[Token(Token = "0x17000354")]
			public Vector3 minRotation
			{
				[Token(Token = "0x6000965")]
				[Address(RVA = "0x2393198", Offset = "0x2393198", VA = "0x2393198")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000966")]
				[Address(RVA = "0x23931AC", Offset = "0x23931AC", VA = "0x23931AC")]
				set
				{
				}
			}

			[Token(Token = "0x17000355")]
			public Vector3 maxRotation
			{
				[Token(Token = "0x6000967")]
				[Address(RVA = "0x2393218", Offset = "0x2393218", VA = "0x2393218")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000968")]
				[Address(RVA = "0x239322C", Offset = "0x239322C", VA = "0x239322C")]
				set
				{
				}
			}

			[Token(Token = "0x17000356")]
			public Vector3 minScale
			{
				[Token(Token = "0x6000969")]
				[Address(RVA = "0x2393298", Offset = "0x2393298", VA = "0x2393298")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600096A")]
				[Address(RVA = "0x23932AC", Offset = "0x23932AC", VA = "0x23932AC")]
				set
				{
				}
			}

			[Token(Token = "0x17000357")]
			public Vector3 maxScale
			{
				[Token(Token = "0x600096B")]
				[Address(RVA = "0x2393318", Offset = "0x2393318", VA = "0x2393318")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600096C")]
				[Address(RVA = "0x239332C", Offset = "0x239332C", VA = "0x239332C")]
				set
				{
				}
			}

			[Token(Token = "0x17000358")]
			public Type type
			{
				[Token(Token = "0x600096D")]
				[Address(RVA = "0x2393398", Offset = "0x2393398", VA = "0x2393398")]
				get
				{
					return default(Type);
				}
				[Token(Token = "0x600096E")]
				[Address(RVA = "0x23933A0", Offset = "0x23933A0", VA = "0x23933A0")]
				set
				{
				}
			}

			[Token(Token = "0x17000359")]
			public bool randomOrder
			{
				[Token(Token = "0x600096F")]
				[Address(RVA = "0x23933B4", Offset = "0x23933B4", VA = "0x23933B4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000970")]
				[Address(RVA = "0x23933BC", Offset = "0x23933BC", VA = "0x23933BC")]
				set
				{
				}
			}

			[Token(Token = "0x1700035A")]
			public int randomSeed
			{
				[Token(Token = "0x6000971")]
				[Address(RVA = "0x23933DC", Offset = "0x23933DC", VA = "0x23933DC")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000972")]
				[Address(RVA = "0x23933E4", Offset = "0x23933E4", VA = "0x23933E4")]
				set
				{
				}
			}

			[Token(Token = "0x1700035B")]
			public int count
			{
				[Token(Token = "0x6000973")]
				[Address(RVA = "0x2393408", Offset = "0x2393408", VA = "0x2393408")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000974")]
				[Address(RVA = "0x2393410", Offset = "0x2393410", VA = "0x2393410")]
				set
				{
				}
			}

			[Token(Token = "0x1700035C")]
			public bool autoCount
			{
				[Token(Token = "0x6000975")]
				[Address(RVA = "0x239342C", Offset = "0x239342C", VA = "0x239342C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000976")]
				[Address(RVA = "0x2393434", Offset = "0x2393434", VA = "0x2393434")]
				set
				{
				}
			}

			[Token(Token = "0x1700035D")]
			public UVOverride overrideUVs
			{
				[Token(Token = "0x6000977")]
				[Address(RVA = "0x2393454", Offset = "0x2393454", VA = "0x2393454")]
				get
				{
					return default(UVOverride);
				}
				[Token(Token = "0x6000978")]
				[Address(RVA = "0x239345C", Offset = "0x239345C", VA = "0x239345C")]
				set
				{
				}
			}

			[Token(Token = "0x1700035E")]
			public Vector2 uvOffset
			{
				[Token(Token = "0x6000979")]
				[Address(RVA = "0x2393470", Offset = "0x2393470", VA = "0x2393470")]
				get
				{
					return default(Vector2);
				}
				[Token(Token = "0x600097A")]
				[Address(RVA = "0x239347C", Offset = "0x239347C", VA = "0x239347C")]
				set
				{
				}
			}

			[Token(Token = "0x1700035F")]
			public Vector2 uvScale
			{
				[Token(Token = "0x600097B")]
				[Address(RVA = "0x23934C0", Offset = "0x23934C0", VA = "0x23934C0")]
				get
				{
					return default(Vector2);
				}
				[Token(Token = "0x600097C")]
				[Address(RVA = "0x23934CC", Offset = "0x23934CC", VA = "0x23934CC")]
				set
				{
				}
			}

			[Token(Token = "0x17000360")]
			public bool overrideNormal
			{
				[Token(Token = "0x600097D")]
				[Address(RVA = "0x2393510", Offset = "0x2393510", VA = "0x2393510")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600097E")]
				[Address(RVA = "0x2393518", Offset = "0x2393518", VA = "0x2393518")]
				set
				{
				}
			}

			[Token(Token = "0x17000361")]
			public Vector3 customNormal
			{
				[Token(Token = "0x600097F")]
				[Address(RVA = "0x2393538", Offset = "0x2393538", VA = "0x2393538")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000980")]
				[Address(RVA = "0x239354C", Offset = "0x239354C", VA = "0x239354C")]
				set
				{
				}
			}

			[Token(Token = "0x17000362")]
			public MeshScaleModifier scaleModifier
			{
				[Token(Token = "0x6000981")]
				[Address(RVA = "0x23935B8", Offset = "0x23935B8", VA = "0x23935B8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000982")]
			[Address(RVA = "0x23935C0", Offset = "0x23935C0", VA = "0x23935C0")]
			public Channel(string n, SplineMesh parent)
			{
			}

			[Token(Token = "0x6000983")]
			[Address(RVA = "0x239385C", Offset = "0x239385C", VA = "0x239385C")]
			public Channel(string n, Mesh inputMesh, SplineMesh parent)
			{
			}

			[Token(Token = "0x6000984")]
			[Address(RVA = "0x23937E4", Offset = "0x23937E4", VA = "0x23937E4")]
			private void Init()
			{
			}

			[Token(Token = "0x6000985")]
			[Address(RVA = "0x2393EC0", Offset = "0x2393EC0", VA = "0x2393EC0")]
			public void CopyTo(Channel target)
			{
			}

			[Token(Token = "0x6000986")]
			[Address(RVA = "0x23948D0", Offset = "0x23948D0", VA = "0x23948D0")]
			public int GetMeshCount()
			{
				return default(int);
			}

			[Token(Token = "0x6000987")]
			[Address(RVA = "0x2394924", Offset = "0x2394924", VA = "0x2394924")]
			public void SwapMeshes(int a, int b)
			{
			}

			[Token(Token = "0x6000988")]
			[Address(RVA = "0x2394A7C", Offset = "0x2394A7C", VA = "0x2394A7C")]
			public void DuplicateMesh(int index)
			{
			}

			[Token(Token = "0x6000989")]
			[Address(RVA = "0x2394B70", Offset = "0x2394B70", VA = "0x2394B70")]
			public MeshDefinition GetMesh(int index)
			{
				return null;
			}

			[Token(Token = "0x600098A")]
			[Address(RVA = "0x2394BE4", Offset = "0x2394BE4", VA = "0x2394BE4")]
			public void AddMesh(Mesh input)
			{
			}

			[Token(Token = "0x600098B")]
			[Address(RVA = "0x2394C8C", Offset = "0x2394C8C", VA = "0x2394C8C")]
			public void RemoveMesh(int index)
			{
			}

			[Token(Token = "0x600098C")]
			[Address(RVA = "0x2394D04", Offset = "0x2394D04", VA = "0x2394D04")]
			public void ResetIteration()
			{
			}

			[Token(Token = "0x600098D")]
			[Address(RVA = "0x2394E5C", Offset = "0x2394E5C", VA = "0x2394E5C")]
			public Vector2 NextOffset(double percent)
			{
				return default(Vector2);
			}

			[Token(Token = "0x600098E")]
			[Address(RVA = "0x23951F8", Offset = "0x23951F8", VA = "0x23951F8")]
			public Quaternion NextPlaceRotation(double percent)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600098F")]
			[Address(RVA = "0x2395600", Offset = "0x2395600", VA = "0x2395600")]
			public float NextExtrudeRotation(double percent)
			{
				return default(float);
			}

			[Token(Token = "0x6000990")]
			[Address(RVA = "0x2395914", Offset = "0x2395914", VA = "0x2395914")]
			public Vector3 NextExtrudeScale(double percent)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000991")]
			[Address(RVA = "0x2395D44", Offset = "0x2395D44", VA = "0x2395D44")]
			public Vector3 NextPlaceScale()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000992")]
			[Address(RVA = "0x2395EF4", Offset = "0x2395EF4", VA = "0x2395EF4")]
			public MeshDefinition NextMesh()
			{
				return null;
			}

			[Token(Token = "0x6000993")]
			[Address(RVA = "0x2392D74", Offset = "0x2392D74", VA = "0x2392D74")]
			internal void Rebuild()
			{
			}

			[Token(Token = "0x6000994")]
			[Address(RVA = "0x2395FF4", Offset = "0x2395FF4", VA = "0x2395FF4")]
			private void Refresh()
			{
			}
		}

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[HideInInspector]
		private List<Channel> channels;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool useLastResult;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private List<TS_Mesh> combineMeshes;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int meshCount;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Matrix4x4 vertexMatrix;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Matrix4x4 normalMatrix;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private SplineSample lastResult;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private SplineSample modifiedResult;

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x268C638", Offset = "0x268C638", VA = "0x268C638", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x268C6B0", Offset = "0x268C6B0", VA = "0x268C6B0", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x268C7C0", Offset = "0x268C7C0", VA = "0x268C7C0")]
		public void RemoveChannel(int index)
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x268C844", Offset = "0x268C844", VA = "0x268C844")]
		public void SwapChannels(int a, int b)
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x268C9A8", Offset = "0x268C9A8", VA = "0x268C9A8")]
		public Channel AddChannel(Mesh inputMesh, string name)
		{
			return null;
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x268C714", Offset = "0x268C714", VA = "0x268C714")]
		public Channel AddChannel(string name)
		{
			return null;
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x268CA6C", Offset = "0x268CA6C", VA = "0x268CA6C")]
		public int GetChannelCount()
		{
			return default(int);
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x268CAC0", Offset = "0x268CAC0", VA = "0x268CAC0")]
		public Channel GetChannel(int index)
		{
			return null;
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x268CB34", Offset = "0x268CB34", VA = "0x268CB34", Slot = "18")]
		protected override void BuildMesh()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x268CB68", Offset = "0x268CB68", VA = "0x268CB68")]
		private void Generate()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x268EB38", Offset = "0x268EB38", VA = "0x268EB38")]
		private void Place(Channel channel, TS_Mesh target, double percent)
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x268DECC", Offset = "0x268DECC", VA = "0x268DECC")]
		private void Stretch(Channel channel, TS_Mesh target, double from, double to)
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x2691404", Offset = "0x2691404", VA = "0x2691404")]
		public SplineMesh()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59BBBC", Offset = "0x59BBBC")]
	public class SplineMorph : MonoBehaviour
	{
		[Token(Token = "0x20000CD")]
		public enum CycleMode
		{
			[Token(Token = "0x4000639")]
			Default,
			[Token(Token = "0x400063A")]
			Loop,
			[Token(Token = "0x400063B")]
			PingPong
		}

		[Token(Token = "0x20000CE")]
		public enum UpdateMode
		{
			[Token(Token = "0x400063D")]
			Update,
			[Token(Token = "0x400063E")]
			FixedUpdate,
			[Token(Token = "0x400063F")]
			LateUpdate
		}

		[Serializable]
		[Token(Token = "0x20000CF")]
		public class Channel
		{
			[Token(Token = "0x2000116")]
			public enum Interpolation
			{
				[Token(Token = "0x4000741")]
				Linear,
				[Token(Token = "0x4000742")]
				Spherical
			}

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			internal SplinePoint[] points;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[SerializeField]
			internal float percent;

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public AnimationCurve curve;

			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Interpolation interpolation;

			[Token(Token = "0x6000995")]
			[Address(RVA = "0x2396E60", Offset = "0x2396E60", VA = "0x2396E60")]
			public Channel()
			{
			}
		}

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[HideInInspector]
		public SplineComputer.Space space;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public bool cycle;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[HideInInspector]
		public CycleMode cycleMode;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public UpdateMode cycleUpdateMode;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[HideInInspector]
		public float cycleDuration;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private SplineComputer _spline;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private SplinePoint[] points;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float cycleValue;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private short cycleDirection;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x59E920", Offset = "0x59E920")]
		private Channel[] channels;

		[Token(Token = "0x170002CF")]
		public SplineComputer spline
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x2691630", Offset = "0x2691630", VA = "0x2691630")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x2691638", Offset = "0x2691638", VA = "0x2691638")]
			set
			{
			}
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x2691758", Offset = "0x2691758", VA = "0x2691758")]
		private void Reset()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x26917BC", Offset = "0x26917BC", VA = "0x26917BC")]
		private void Update()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x2691900", Offset = "0x2691900", VA = "0x2691900")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x2691910", Offset = "0x2691910", VA = "0x2691910")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x26917CC", Offset = "0x26917CC", VA = "0x26917CC")]
		private void RunUpdate()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x2691A50", Offset = "0x2691A50", VA = "0x2691A50")]
		public void SetCycle(float value)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x2691A70", Offset = "0x2691A70", VA = "0x2691A70")]
		public void SetWeight(int index, float weight)
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x2693204", Offset = "0x2693204", VA = "0x2693204")]
		public void SetWeight(string name, float weight)
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x2691920", Offset = "0x2691920", VA = "0x2691920")]
		public void SetWeight(float percent, bool loop = false)
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x26933B0", Offset = "0x26933B0", VA = "0x26933B0")]
		public void CaptureSnapshot(string name)
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x26933D0", Offset = "0x26933D0", VA = "0x26933D0")]
		public void CaptureSnapshot(int index)
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x2693624", Offset = "0x2693624", VA = "0x2693624")]
		public void Clear()
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x269368C", Offset = "0x269368C", VA = "0x269368C")]
		public SplinePoint[] GetSnapshot(int index)
		{
			return null;
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x26936DC", Offset = "0x26936DC", VA = "0x26936DC")]
		public SplinePoint[] GetSnapshot(string name)
		{
			return null;
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x2693734", Offset = "0x2693734", VA = "0x2693734")]
		public float GetWeight(int index)
		{
			return default(float);
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x2693784", Offset = "0x2693784", VA = "0x2693784")]
		public float GetWeight(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x26937DC", Offset = "0x26937DC", VA = "0x26937DC")]
		public void AddChannel(string name)
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x2693C14", Offset = "0x2693C14", VA = "0x2693C14")]
		public void RemoveChannel(string name)
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x2693C34", Offset = "0x2693C34", VA = "0x2693C34")]
		public void RemoveChannel(int index)
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x2693280", Offset = "0x2693280", VA = "0x2693280")]
		private int GetChannelIndex(string name)
		{
			return default(int);
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x2693DF8", Offset = "0x2693DF8", VA = "0x2693DF8")]
		public int GetChannelCount()
		{
			return default(int);
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x2693E0C", Offset = "0x2693E0C", VA = "0x2693E0C")]
		public Channel GetChannel(int index)
		{
			return null;
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x2693E4C", Offset = "0x2693E4C", VA = "0x2693E4C")]
		public Channel GetChannel(string name)
		{
			return null;
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x2691AE8", Offset = "0x2691AE8", VA = "0x2691AE8")]
		public void UpdateMorph()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x2693EDC", Offset = "0x2693EDC", VA = "0x2693EDC")]
		public SplineMorph()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59BBF0", Offset = "0x59BBF0")]
	public class SplinePositioner : SplineTracer
	{
		[Token(Token = "0x20000D0")]
		public enum Mode
		{
			[Token(Token = "0x4000646")]
			Percent,
			[Token(Token = "0x4000647")]
			Distance
		}

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[HideInInspector]
		private GameObject _targetObject;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[HideInInspector]
		private double _position;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[HideInInspector]
		private float animPosition;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[SerializeField]
		[HideInInspector]
		private Mode _mode;

		[Token(Token = "0x170002D0")]
		public GameObject targetObject
		{
			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x269523C", Offset = "0x269523C", VA = "0x269523C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x26952D8", Offset = "0x26952D8", VA = "0x26952D8")]
			set
			{
			}
		}

		[Token(Token = "0x170002D1")]
		public double position
		{
			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x269540C", Offset = "0x269540C", VA = "0x269540C")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x2695418", Offset = "0x2695418", VA = "0x2695418")]
			set
			{
			}
		}

		[Token(Token = "0x170002D2")]
		public Mode mode
		{
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x2695498", Offset = "0x2695498", VA = "0x2695498")]
			get
			{
				return default(Mode);
			}
			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x26954A0", Offset = "0x26954A0", VA = "0x26954A0")]
			set
			{
			}
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x26954C0", Offset = "0x26954C0", VA = "0x26954C0", Slot = "9")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x26955D8", Offset = "0x26955D8", VA = "0x26955D8", Slot = "23")]
		protected override Transform GetTransform()
		{
			return null;
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x2695604", Offset = "0x2695604", VA = "0x2695604", Slot = "21")]
		protected override Rigidbody GetRigidbody()
		{
			return null;
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x2695674", Offset = "0x2695674", VA = "0x2695674", Slot = "22")]
		protected override Rigidbody2D GetRigidbody2D()
		{
			return null;
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x26956E4", Offset = "0x26956E4", VA = "0x26956E4", Slot = "15")]
		protected override void PostBuild()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x26957A0", Offset = "0x26957A0", VA = "0x26957A0", Slot = "19")]
		public override void SetPercent(double percent, bool checkTriggers = false, bool handleJuncitons = false)
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x26957DC", Offset = "0x26957DC", VA = "0x26957DC", Slot = "20")]
		public override void SetDistance(float distance, bool checkTriggers = false, bool handleJuncitons = false)
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x2695808", Offset = "0x2695808", VA = "0x2695808")]
		public SplinePositioner()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59BC24", Offset = "0x59BC24")]
	public class SplineProjector : SplineTracer
	{
		[Token(Token = "0x20000D1")]
		public enum Mode
		{
			[Token(Token = "0x4000649")]
			Accurate,
			[Token(Token = "0x400064A")]
			Cached
		}

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[HideInInspector]
		private Mode _mode;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[SerializeField]
		[HideInInspector]
		private bool _autoProject;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59EA98", Offset = "0x59EA98")]
		private int _subdivide;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[SerializeField]
		[HideInInspector]
		private Transform _projectTarget;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[HideInInspector]
		private Transform applyTarget;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[SerializeField]
		[HideInInspector]
		private GameObject _targetObject;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[HideInInspector]
		public Vector2 _offset;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[HideInInspector]
		public Vector3 _rotationOffset;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[SerializeField]
		[HideInInspector]
		private Vector3 lastPosition;

		[Token(Token = "0x170002D3")]
		public Mode mode
		{
			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x26963DC", Offset = "0x26963DC", VA = "0x26963DC")]
			get
			{
				return default(Mode);
			}
			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x26963E4", Offset = "0x26963E4", VA = "0x26963E4")]
			set
			{
			}
		}

		[Token(Token = "0x170002D4")]
		public bool autoProject
		{
			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x2696404", Offset = "0x2696404", VA = "0x2696404")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x269640C", Offset = "0x269640C", VA = "0x269640C")]
			set
			{
			}
		}

		[Token(Token = "0x170002D5")]
		public int subdivide
		{
			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x2696444", Offset = "0x2696444", VA = "0x2696444")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x269644C", Offset = "0x269644C", VA = "0x269644C")]
			set
			{
			}
		}

		[Token(Token = "0x170002D6")]
		public Transform projectTarget
		{
			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x269647C", Offset = "0x269647C", VA = "0x269647C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x2696518", Offset = "0x2696518", VA = "0x2696518")]
			set
			{
			}
		}

		[Token(Token = "0x170002D7")]
		public GameObject targetObject
		{
			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x26965D0", Offset = "0x26965D0", VA = "0x26965D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x26966DC", Offset = "0x26966DC", VA = "0x26966DC")]
			set
			{
			}
		}

		[Token(Token = "0x14000008")]
		public event SplineReachHandler onEndReached
		{
			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x269679C", Offset = "0x269679C", VA = "0x269679C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0C28", Offset = "0x5A0C28")]
			add
			{
			}
			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x2696848", Offset = "0x2696848", VA = "0x2696848")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0C38", Offset = "0x5A0C38")]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public event SplineReachHandler onBeginningReached
		{
			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x26968F4", Offset = "0x26968F4", VA = "0x26968F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0C48", Offset = "0x5A0C48")]
			add
			{
			}
			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x26969A0", Offset = "0x26969A0", VA = "0x26969A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0C58", Offset = "0x5A0C58")]
			remove
			{
			}
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x2696A4C", Offset = "0x2696A4C", VA = "0x2696A4C", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x2696A78", Offset = "0x2696A78", VA = "0x2696A78", Slot = "23")]
		protected override Transform GetTransform()
		{
			return null;
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x2696B34", Offset = "0x2696B34", VA = "0x2696B34", Slot = "21")]
		protected override Rigidbody GetRigidbody()
		{
			return null;
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x2696C10", Offset = "0x2696C10", VA = "0x2696C10", Slot = "22")]
		protected override Rigidbody2D GetRigidbody2D()
		{
			return null;
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x2696CEC", Offset = "0x2696CEC", VA = "0x2696CEC", Slot = "13")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x26971A8", Offset = "0x26971A8", VA = "0x26971A8", Slot = "15")]
		protected override void PostBuild()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x2697204", Offset = "0x2697204", VA = "0x2697204", Slot = "16")]
		protected override void OnSplineChanged()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x2697418", Offset = "0x2697418", VA = "0x2697418")]
		private void Project()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x2696E2C", Offset = "0x2696E2C", VA = "0x2696E2C")]
		public void CalculateProjection()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x2697620", Offset = "0x2697620", VA = "0x2697620")]
		public SplineProjector()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x59BC6C", Offset = "0x59BC6C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x59BC6C", Offset = "0x59BC6C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59BC6C", Offset = "0x59BC6C")]
	[ExecuteInEditMode]
	public class SplineRenderer : MeshGenerator
	{
		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[HideInInspector]
		public bool autoOrient;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[HideInInspector]
		public int updateFrameInterval;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int currentFrame;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[HideInInspector]
		private int _slices;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[SerializeField]
		[HideInInspector]
		private Vector3 vertexDirection;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool orthographic;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		private bool init;

		[Token(Token = "0x170002D8")]
		public int slices
		{
			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x26976D0", Offset = "0x26976D0", VA = "0x26976D0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x26976D8", Offset = "0x26976D8", VA = "0x26976D8")]
			set
			{
			}
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x2697700", Offset = "0x2697700", VA = "0x2697700", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x2697778", Offset = "0x2697778", VA = "0x2697778")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x2697830", Offset = "0x2697830", VA = "0x2697830", Slot = "13")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x2697854", Offset = "0x2697854", VA = "0x2697854", Slot = "18")]
		protected override void BuildMesh()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x26980D0", Offset = "0x26980D0", VA = "0x26980D0")]
		public void RenderWithCamera(Camera cam)
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x2698258", Offset = "0x2698258", VA = "0x2698258")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x2697930", Offset = "0x2697930", VA = "0x2697930")]
		public void GenerateVertices(Vector3 vertexDirection, bool orthoGraphic)
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x2698304", Offset = "0x2698304", VA = "0x2698304")]
		public SplineRenderer()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class SplineTracer : SplineUser
	{
		[Token(Token = "0x20000D2")]
		public class NodeConnection
		{
			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Node node;

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int point;

			[Token(Token = "0x6000996")]
			[Address(RVA = "0x239AD64", Offset = "0x239AD64", VA = "0x239AD64")]
			public NodeConnection(Node node, int point)
			{
			}
		}

		[Token(Token = "0x20000D3")]
		public enum PhysicsMode
		{
			[Token(Token = "0x400064E")]
			Transform,
			[Token(Token = "0x400064F")]
			Rigidbody,
			[Token(Token = "0x4000650")]
			Rigidbody2D
		}

		[Token(Token = "0x20000D4")]
		public delegate void JunctionHandler(List<NodeConnection> passed);

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private SplineTrigger[] triggerInvokeQueue;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<NodeConnection> nodeConnectionQueue;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int addTriggerIndex;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public bool applyDirectionRotation;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[HideInInspector]
		public bool useTriggers;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[HideInInspector]
		public int triggerGroup;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[HideInInspector]
		protected Spline.Direction _direction;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		[HideInInspector]
		protected PhysicsMode _physicsMode;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[HideInInspector]
		protected TransformModule _motion;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[HideInInspector]
		protected Rigidbody targetRigidbody;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[HideInInspector]
		protected Rigidbody2D targetRigidbody2D;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		[HideInInspector]
		protected Transform targetTransform;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[HideInInspector]
		protected SplineSample _result;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[SerializeField]
		[HideInInspector]
		protected SplineSample _finalResult;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool setPercentOnRebuild;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private double targetPercentOnRebuild;

		[Token(Token = "0x4000470")]
		private const double MIN_DELTA = 1E-06;

		[Token(Token = "0x170002D9")]
		public PhysicsMode physicsMode
		{
			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x2699B70", Offset = "0x2699B70", VA = "0x2699B70")]
			get
			{
				return default(PhysicsMode);
			}
			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x2699B78", Offset = "0x2699B78", VA = "0x2699B78")]
			set
			{
			}
		}

		[Token(Token = "0x170002DA")]
		public TransformModule motion
		{
			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x2699B80", Offset = "0x2699B80", VA = "0x2699B80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002DB")]
		public SplineSample result
		{
			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x2699C00", Offset = "0x2699C00", VA = "0x2699C00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002DC")]
		public SplineSample modifiedResult
		{
			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x2699C08", Offset = "0x2699C08", VA = "0x2699C08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002DD")]
		public Spline.Direction direction
		{
			[Token(Token = "0x6000700")]
			[Address(RVA = "0x2699C10", Offset = "0x2699C10", VA = "0x2699C10")]
			get
			{
				return default(Spline.Direction);
			}
			[Token(Token = "0x6000701")]
			[Address(RVA = "0x2699C18", Offset = "0x2699C18", VA = "0x2699C18")]
			set
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public event JunctionHandler onNode
		{
			[Token(Token = "0x6000702")]
			[Address(RVA = "0x2699C2C", Offset = "0x2699C2C", VA = "0x2699C2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0C68", Offset = "0x5A0C68")]
			add
			{
			}
			[Token(Token = "0x6000703")]
			[Address(RVA = "0x2699CD8", Offset = "0x2699CD8", VA = "0x2699CD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0C78", Offset = "0x5A0C78")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		public event EmptySplineHandler onMotionApplied
		{
			[Token(Token = "0x6000704")]
			[Address(RVA = "0x2699D84", Offset = "0x2699D84", VA = "0x2699D84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0C88", Offset = "0x5A0C88")]
			add
			{
			}
			[Token(Token = "0x6000705")]
			[Address(RVA = "0x2699E30", Offset = "0x2699E30", VA = "0x2699E30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0C98", Offset = "0x5A0C98")]
			remove
			{
			}
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x268A548", Offset = "0x268A548", VA = "0x268A548", Slot = "18")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x268B48C", Offset = "0x268B48C", VA = "0x268B48C", Slot = "19")]
		public virtual void SetPercent(double percent, bool checkTriggers = false, bool handleJunctions = false)
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x268B608", Offset = "0x268B608", VA = "0x268B608", Slot = "20")]
		public virtual void SetDistance(float distance, bool checkTriggers = false, bool handleJunctions = false)
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x268A784", Offset = "0x268A784", VA = "0x268A784", Slot = "15")]
		protected override void PostBuild()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x2699F14", Offset = "0x2699F14", VA = "0x2699F14", Slot = "21")]
		protected virtual Rigidbody GetRigidbody()
		{
			return null;
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x2699F6C", Offset = "0x2699F6C", VA = "0x2699F6C", Slot = "22")]
		protected virtual Rigidbody2D GetRigidbody2D()
		{
			return null;
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x2699FC4", Offset = "0x2699FC4", VA = "0x2699FC4", Slot = "23")]
		protected virtual Transform GetTransform()
		{
			return null;
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x268A850", Offset = "0x268A850", VA = "0x268A850")]
		protected void ApplyMotion()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x268BD48", Offset = "0x268BD48", VA = "0x268BD48")]
		protected void CheckNodes(double from, double to)
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x268C338", Offset = "0x268C338", VA = "0x268C338")]
		protected void InvokeNodes()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x268BA60", Offset = "0x268BA60", VA = "0x268BA60")]
		protected void CheckTriggers(double from, double to)
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x2699FFC", Offset = "0x2699FFC", VA = "0x2699FFC")]
		private NodeConnection GetJunction(int pointIndex)
		{
			return null;
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x268C27C", Offset = "0x268C27C", VA = "0x268C27C")]
		protected void InvokeTriggers()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x2695398", Offset = "0x2695398", VA = "0x2695398")]
		protected void RefreshTargets()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x269A194", Offset = "0x269A194", VA = "0x269A194")]
		private void AddTriggerToQueue(SplineTrigger trigger)
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x268C500", Offset = "0x268C500", VA = "0x268C500")]
		public SplineTracer()
		{
		}
	}
	[Token(Token = "0x200006B")]
	[ExecuteInEditMode]
	public class SplineUser : MonoBehaviour
	{
		[Token(Token = "0x20000D5")]
		public enum UpdateMethod
		{
			[Token(Token = "0x4000652")]
			Update,
			[Token(Token = "0x4000653")]
			FixedUpdate,
			[Token(Token = "0x4000654")]
			LateUpdate
		}

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[HideInInspector]
		public UpdateMethod updateMethod;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x59EE84", Offset = "0x59EE84")]
		private SplineComputer _spline;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		[HideInInspector]
		private bool _autoUpdate;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		protected RotationModifier _rotationModifier;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[HideInInspector]
		protected OffsetModifier _offsetModifier;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		protected ColorModifier _colorModifier;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[HideInInspector]
		protected SizeModifier _sizeModifier;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[HideInInspector]
		private SampleCollection sampleCollection;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[HideInInspector]
		private SplineSample clipFromSample;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private SplineSample clipToSample;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[HideInInspector]
		private float animClipFrom;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private float animClipTo;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool rebuild;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool getSamples;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
		private bool postBuild;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform trs;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		[HideInInspector]
		private int _sampleCount;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		private int startSampleIndex;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		protected SplineSample evalResult;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public bool multithreaded;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		[HideInInspector]
		public bool buildOnAwake;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		[HideInInspector]
		public bool buildOnEnable;

		[Token(Token = "0x170002DE")]
		public SplineComputer spline
		{
			[Token(Token = "0x6000716")]
			[Address(RVA = "0x269A8C0", Offset = "0x269A8C0", VA = "0x269A8C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000717")]
			[Address(RVA = "0x269A8C8", Offset = "0x269A8C8", VA = "0x269A8C8")]
			set
			{
			}
		}

		[Token(Token = "0x170002DF")]
		public double clipFrom
		{
			[Token(Token = "0x6000718")]
			[Address(RVA = "0x268B760", Offset = "0x268B760", VA = "0x268B760")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000719")]
			[Address(RVA = "0x269AA4C", Offset = "0x269AA4C", VA = "0x269AA4C")]
			set
			{
			}
		}

		[Token(Token = "0x170002E0")]
		public double clipTo
		{
			[Token(Token = "0x600071A")]
			[Address(RVA = "0x268B784", Offset = "0x268B784", VA = "0x268B784")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x600071B")]
			[Address(RVA = "0x269AB80", Offset = "0x269AB80", VA = "0x269AB80")]
			set
			{
			}
		}

		[Token(Token = "0x170002E1")]
		public bool autoUpdate
		{
			[Token(Token = "0x600071C")]
			[Address(RVA = "0x269ACB4", Offset = "0x269ACB4", VA = "0x269ACB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600071D")]
			[Address(RVA = "0x269ACBC", Offset = "0x269ACBC", VA = "0x269ACBC")]
			set
			{
			}
		}

		[Token(Token = "0x170002E2")]
		public bool loopSamples
		{
			[Token(Token = "0x600071E")]
			[Address(RVA = "0x269ACF4", Offset = "0x269ACF4", VA = "0x269ACF4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600071F")]
			[Address(RVA = "0x269AD14", Offset = "0x269AD14", VA = "0x269AD14")]
			set
			{
			}
		}

		[Token(Token = "0x170002E3")]
		public double span
		{
			[Token(Token = "0x6000720")]
			[Address(RVA = "0x269AE24", Offset = "0x269AE24", VA = "0x269AE24")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170002E4")]
		public bool samplesAreLooped
		{
			[Token(Token = "0x6000721")]
			[Address(RVA = "0x268B738", Offset = "0x268B738", VA = "0x268B738")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170002E5")]
		public RotationModifier rotationModifier
		{
			[Token(Token = "0x6000722")]
			[Address(RVA = "0x269AEBC", Offset = "0x269AEBC", VA = "0x269AEBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002E6")]
		public OffsetModifier offsetModifier
		{
			[Token(Token = "0x6000723")]
			[Address(RVA = "0x269AEC4", Offset = "0x269AEC4", VA = "0x269AEC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002E7")]
		public ColorModifier colorModifier
		{
			[Token(Token = "0x6000724")]
			[Address(RVA = "0x269AECC", Offset = "0x269AECC", VA = "0x269AECC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002E8")]
		public SizeModifier sizeModifier
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x269AED4", Offset = "0x269AED4", VA = "0x269AED4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002E9")]
		public int sampleCount
		{
			[Token(Token = "0x6000726")]
			[Address(RVA = "0x269AEDC", Offset = "0x269AEDC", VA = "0x269AEDC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x269AEE4", Offset = "0x269AEE4", VA = "0x269AEE4", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x2696A74", Offset = "0x2696A74", VA = "0x2696A74", Slot = "5")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x269B02C", Offset = "0x269B02C", VA = "0x269B02C", Slot = "6")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x269B0F8", Offset = "0x269B0F8", VA = "0x269B0F8", Slot = "7")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x269B1A0", Offset = "0x269B1A0", VA = "0x269B1A0", Slot = "8")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x2695500", Offset = "0x2695500", VA = "0x2695500", Slot = "9")]
		protected virtual void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x268B7A8", Offset = "0x268B7A8", VA = "0x268B7A8")]
		public SplineSample GetSampleRaw(int index)
		{
			return null;
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x26982DC", Offset = "0x26982DC", VA = "0x26982DC")]
		public void GetSample(int index, SplineSample target)
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x269B348", Offset = "0x269B348", VA = "0x269B348", Slot = "10")]
		public virtual void Rebuild()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x269B35C", Offset = "0x269B35C", VA = "0x269B35C", Slot = "11")]
		public virtual void RebuildImmediate()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x269B49C", Offset = "0x269B49C", VA = "0x269B49C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x269B678", Offset = "0x269B678", VA = "0x269B678")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x269B6C4", Offset = "0x269B6C4", VA = "0x269B6C4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x269B4E8", Offset = "0x269B4E8", VA = "0x269B4E8")]
		private void RunUpdate()
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x269B710", Offset = "0x269B710", VA = "0x269B710")]
		private void BuildThreaded()
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x269B73C", Offset = "0x269B73C", VA = "0x269B73C")]
		private void ResampleAndBuildThreaded()
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x269B76C", Offset = "0x269B76C", VA = "0x269B76C", Slot = "12")]
		protected virtual void Run()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x268A55C", Offset = "0x268A55C", VA = "0x268A55C", Slot = "13")]
		protected virtual void LateRun()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x269B770", Offset = "0x269B770", VA = "0x269B770", Slot = "14")]
		protected virtual void Build()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x269B774", Offset = "0x269B774", VA = "0x269B774", Slot = "15")]
		protected virtual void PostBuild()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x269B778", Offset = "0x269B778", VA = "0x269B778", Slot = "16")]
		protected virtual void OnSplineChanged()
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x26913C8", Offset = "0x26913C8", VA = "0x26913C8")]
		public void ModifySample(SplineSample source, SplineSample destination)
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x2691080", Offset = "0x2691080", VA = "0x2691080")]
		public void ModifySample(SplineSample sample)
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x269B77C", Offset = "0x269B77C", VA = "0x269B77C")]
		public void SetClipRange(double from, double to)
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x269B1A4", Offset = "0x269B1A4", VA = "0x269B1A4")]
		private void GetSamples()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x268B700", Offset = "0x268B700", VA = "0x268B700")]
		public double ClipPercent(double percent)
		{
			return default(double);
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x269B840", Offset = "0x269B840", VA = "0x269B840")]
		public void ClipPercent(ref double percent)
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x269B870", Offset = "0x269B870", VA = "0x269B870")]
		public double UnclipPercent(double percent)
		{
			return default(double);
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x2699FCC", Offset = "0x2699FCC", VA = "0x2699FCC")]
		public void UnclipPercent(ref double percent)
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x269B8A8", Offset = "0x269B8A8", VA = "0x269B8A8")]
		private int GetSampleIndex(double percent)
		{
			return default(int);
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x269B8F8", Offset = "0x269B8F8", VA = "0x269B8F8")]
		public Vector3 EvaluatePosition(double percent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x268A7D8", Offset = "0x268A7D8", VA = "0x268A7D8")]
		public void Evaluate(double percent, SplineSample result)
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x269B954", Offset = "0x269B954", VA = "0x269B954")]
		public SplineSample Evaluate(double percent)
		{
			return null;
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x269BA04", Offset = "0x269BA04", VA = "0x269BA04")]
		public void Evaluate(ref SplineSample[] results, double from = 0.0, double to = 1.0)
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x269BAE8", Offset = "0x269BAE8", VA = "0x269BAE8")]
		public void EvaluatePositions(ref Vector3[] positions, double from = 0.0, double to = 1.0)
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x268C3F4", Offset = "0x268C3F4", VA = "0x268C3F4")]
		public double Travel(double start, float distance, Spline.Direction direction, out float moved)
		{
			return default(double);
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x2699EDC", Offset = "0x2699EDC", VA = "0x2699EDC")]
		public double Travel(double start, float distance, Spline.Direction direction = Spline.Direction.Forward)
		{
			return default(double);
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x269BB44", Offset = "0x269BB44", VA = "0x269BB44", Slot = "17")]
		public virtual void Project(Vector3 position, SplineSample result, double from = 0.0, double to = 1.0)
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x268DBD0", Offset = "0x268DBD0", VA = "0x268DBD0")]
		public float CalculateLength(double from = 0.0, double to = 1.0)
		{
			return default(float);
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x269A408", Offset = "0x269A408", VA = "0x269A408")]
		public SplineUser()
		{
		}
	}
	[Token(Token = "0x200006C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x59BD5C", Offset = "0x59BD5C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x59BD5C", Offset = "0x59BD5C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59BD5C", Offset = "0x59BD5C")]
	public class SurfaceGenerator : MeshGenerator
	{
		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[HideInInspector]
		private float _expand;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[HideInInspector]
		private float _extrude;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		[HideInInspector]
		private Vector2 _sideUvScale;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[SerializeField]
		[HideInInspector]
		private Vector2 _sideUvOffset;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		[HideInInspector]
		private SplineComputer _extrudeSpline;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[HideInInspector]
		private SplineSample[] extrudeResults;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		[HideInInspector]
		private Vector3[] identityVertices;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[HideInInspector]
		private Vector3[] identityNormals;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[SerializeField]
		[HideInInspector]
		private Vector2[] projectedVerts;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[HideInInspector]
		private int[] surfaceTris;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[SerializeField]
		[HideInInspector]
		private int[] wallTris;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[HideInInspector]
		private double _extrudeFrom;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		[HideInInspector]
		private double _extrudeTo;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		[HideInInspector]
		private bool _uniformUvs;

		[Token(Token = "0x170002EA")]
		public float expand
		{
			[Token(Token = "0x600074F")]
			[Address(RVA = "0x269BF20", Offset = "0x269BF20", VA = "0x269BF20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000750")]
			[Address(RVA = "0x269BF28", Offset = "0x269BF28", VA = "0x269BF28")]
			set
			{
			}
		}

		[Token(Token = "0x170002EB")]
		public float extrude
		{
			[Token(Token = "0x6000751")]
			[Address(RVA = "0x269BF50", Offset = "0x269BF50", VA = "0x269BF50")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000752")]
			[Address(RVA = "0x269BF58", Offset = "0x269BF58", VA = "0x269BF58")]
			set
			{
			}
		}

		[Token(Token = "0x170002EC")]
		public double extrudeClipFrom
		{
			[Token(Token = "0x6000753")]
			[Address(RVA = "0x269BF80", Offset = "0x269BF80", VA = "0x269BF80")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000754")]
			[Address(RVA = "0x269BF8C", Offset = "0x269BF8C", VA = "0x269BF8C")]
			set
			{
			}
		}

		[Token(Token = "0x170002ED")]
		public double extrudeClipTo
		{
			[Token(Token = "0x6000755")]
			[Address(RVA = "0x269BFB4", Offset = "0x269BFB4", VA = "0x269BFB4")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000756")]
			[Address(RVA = "0x269BFC0", Offset = "0x269BFC0", VA = "0x269BFC0")]
			set
			{
			}
		}

		[Token(Token = "0x170002EE")]
		public Vector2 sideUvScale
		{
			[Token(Token = "0x6000757")]
			[Address(RVA = "0x269BFE8", Offset = "0x269BFE8", VA = "0x269BFE8")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000758")]
			[Address(RVA = "0x269BFFC", Offset = "0x269BFFC", VA = "0x269BFFC")]
			set
			{
			}
		}

		[Token(Token = "0x170002EF")]
		public Vector2 sideUvOffset
		{
			[Token(Token = "0x6000759")]
			[Address(RVA = "0x269C048", Offset = "0x269C048", VA = "0x269C048")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600075A")]
			[Address(RVA = "0x269C05C", Offset = "0x269C05C", VA = "0x269C05C")]
			set
			{
			}
		}

		[Token(Token = "0x170002F0")]
		public SplineComputer extrudeSpline
		{
			[Token(Token = "0x600075B")]
			[Address(RVA = "0x269C0A8", Offset = "0x269C0A8", VA = "0x269C0A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600075C")]
			[Address(RVA = "0x269C0B0", Offset = "0x269C0B0", VA = "0x269C0B0")]
			set
			{
			}
		}

		[Token(Token = "0x170002F1")]
		public bool uniformUvs
		{
			[Token(Token = "0x600075D")]
			[Address(RVA = "0x269C21C", Offset = "0x269C21C", VA = "0x269C21C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600075E")]
			[Address(RVA = "0x269C224", Offset = "0x269C224", VA = "0x269C224")]
			set
			{
			}
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x269C250", Offset = "0x269C250", VA = "0x269C250", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x269C2C8", Offset = "0x269C2C8", VA = "0x269C2C8", Slot = "18")]
		protected override void BuildMesh()
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x269C314", Offset = "0x269C314", VA = "0x269C314")]
		public void Generate()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x269F120", Offset = "0x269F120", VA = "0x269F120")]
		private void GenerateSurfaceTris(bool flip)
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x269F53C", Offset = "0x269F53C", VA = "0x269F53C")]
		private int WriteTris(ref int[] tris, ref int[] target, int vertexOffset, int trisOffset, bool flip)
		{
			return default(int);
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x269EF94", Offset = "0x269EF94", VA = "0x269EF94")]
		private bool IsClockwise(Vector2[] points2D)
		{
			return default(bool);
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x269F1E0", Offset = "0x269F1E0", VA = "0x269F1E0")]
		private void GetIdentityVerts(Vector3 center, Vector3 normal, bool clockwise)
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x269E9EC", Offset = "0x269E9EC", VA = "0x269E9EC")]
		private void GetProjectedVertices(int count, out Vector3 center, out Vector3 normal)
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x269F8AC", Offset = "0x269F8AC", VA = "0x269F8AC")]
		public SurfaceGenerator()
		{
		}
	}
	[Token(Token = "0x200006D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x59BE2C", Offset = "0x59BE2C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x59BE2C", Offset = "0x59BE2C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59BE2C", Offset = "0x59BE2C")]
	public class TubeGenerator : MeshGenerator
	{
		[Token(Token = "0x20000D6")]
		public enum CapMethod
		{
			[Token(Token = "0x4000656")]
			None,
			[Token(Token = "0x4000657")]
			Flat,
			[Token(Token = "0x4000658")]
			Round
		}

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[HideInInspector]
		private int _sides;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[HideInInspector]
		private int _roundCapLatitude;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		[HideInInspector]
		private CapMethod _capMode;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59F47C", Offset = "0x59F47C")]
		private float _revolve;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[SerializeField]
		[HideInInspector]
		private float _capUVScale;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int bodyVertexCount;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private int bodyTrisCount;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int capVertexCount;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private int capTrisCount;

		[Token(Token = "0x170002F2")]
		public int sides
		{
			[Token(Token = "0x6000768")]
			[Address(RVA = "0x1A1A974", Offset = "0x1A1A974", VA = "0x1A1A974")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000769")]
			[Address(RVA = "0x1A1A97C", Offset = "0x1A1A97C", VA = "0x1A1A97C")]
			set
			{
			}
		}

		[Token(Token = "0x170002F3")]
		public CapMethod capMode
		{
			[Token(Token = "0x600076A")]
			[Address(RVA = "0x1A1A9A4", Offset = "0x1A1A9A4", VA = "0x1A1A9A4")]
			get
			{
				return default(CapMethod);
			}
			[Token(Token = "0x600076B")]
			[Address(RVA = "0x1A1A9AC", Offset = "0x1A1A9AC", VA = "0x1A1A9AC")]
			set
			{
			}
		}

		[Token(Token = "0x170002F4")]
		public int roundCapLatitude
		{
			[Token(Token = "0x600076C")]
			[Address(RVA = "0x1A1A9CC", Offset = "0x1A1A9CC", VA = "0x1A1A9CC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600076D")]
			[Address(RVA = "0x1A1A9D4", Offset = "0x1A1A9D4", VA = "0x1A1A9D4")]
			set
			{
			}
		}

		[Token(Token = "0x170002F5")]
		public float revolve
		{
			[Token(Token = "0x600076E")]
			[Address(RVA = "0x1A1AA0C", Offset = "0x1A1AA0C", VA = "0x1A1AA0C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600076F")]
			[Address(RVA = "0x1A1AA14", Offset = "0x1A1AA14", VA = "0x1A1AA14")]
			set
			{
			}
		}

		[Token(Token = "0x170002F6")]
		public float capUVScale
		{
			[Token(Token = "0x6000770")]
			[Address(RVA = "0x1A1AA3C", Offset = "0x1A1AA3C", VA = "0x1A1AA3C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000771")]
			[Address(RVA = "0x1A1AA44", Offset = "0x1A1AA44", VA = "0x1A1AA44")]
			set
			{
			}
		}

		[Token(Token = "0x170002F7")]
		private bool useCap
		{
			[Token(Token = "0x6000772")]
			[Address(RVA = "0x1A1AA6C", Offset = "0x1A1AA6C", VA = "0x1A1AA6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x1A1AB60", Offset = "0x1A1AB60", VA = "0x1A1AB60", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x1A1AB68", Offset = "0x1A1AB68", VA = "0x1A1AB68", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x1A1ABE0", Offset = "0x1A1ABE0", VA = "0x1A1ABE0", Slot = "18")]
		protected override void BuildMesh()
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x1A1ACF8", Offset = "0x1A1ACF8", VA = "0x1A1ACF8")]
		private void Generate()
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x1A1B494", Offset = "0x1A1B494", VA = "0x1A1B494")]
		private void GenerateFlatCaps()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x1A1BDEC", Offset = "0x1A1BDEC", VA = "0x1A1BDEC")]
		private void GenerateRoundCaps()
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x1A1D254", Offset = "0x1A1D254", VA = "0x1A1D254")]
		public TubeGenerator()
		{
		}
	}
	[Token(Token = "0x200006E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x59BEFC", Offset = "0x59BEFC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x59BEFC", Offset = "0x59BEFC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59BEFC", Offset = "0x59BEFC")]
	public class WaveformGenerator : MeshGenerator
	{
		[Token(Token = "0x20000D7")]
		public enum Axis
		{
			[Token(Token = "0x400065A")]
			X,
			[Token(Token = "0x400065B")]
			Y,
			[Token(Token = "0x400065C")]
			Z
		}

		[Token(Token = "0x20000D8")]
		public enum Space
		{
			[Token(Token = "0x400065E")]
			World,
			[Token(Token = "0x400065F")]
			Local
		}

		[Token(Token = "0x20000D9")]
		public enum UVWrapMode
		{
			[Token(Token = "0x4000661")]
			Clamp,
			[Token(Token = "0x4000662")]
			UniformX,
			[Token(Token = "0x4000663")]
			UniformY,
			[Token(Token = "0x4000664")]
			Uniform
		}

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[HideInInspector]
		private Axis _axis;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[HideInInspector]
		private bool _symmetry;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		[HideInInspector]
		private UVWrapMode _uvWrapMode;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[HideInInspector]
		private int _slices;

		[Token(Token = "0x170002F8")]
		public Axis axis
		{
			[Token(Token = "0x600077A")]
			[Address(RVA = "0x1A2B0E4", Offset = "0x1A2B0E4", VA = "0x1A2B0E4")]
			get
			{
				return default(Axis);
			}
			[Token(Token = "0x600077B")]
			[Address(RVA = "0x1A2B0EC", Offset = "0x1A2B0EC", VA = "0x1A2B0EC")]
			set
			{
			}
		}

		[Token(Token = "0x170002F9")]
		public bool symmetry
		{
			[Token(Token = "0x600077C")]
			[Address(RVA = "0x1A2B10C", Offset = "0x1A2B10C", VA = "0x1A2B10C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600077D")]
			[Address(RVA = "0x1A2B114", Offset = "0x1A2B114", VA = "0x1A2B114")]
			set
			{
			}
		}

		[Token(Token = "0x170002FA")]
		public UVWrapMode uvWrapMode
		{
			[Token(Token = "0x600077E")]
			[Address(RVA = "0x1A2B140", Offset = "0x1A2B140", VA = "0x1A2B140")]
			get
			{
				return default(UVWrapMode);
			}
			[Token(Token = "0x600077F")]
			[Address(RVA = "0x1A2B148", Offset = "0x1A2B148", VA = "0x1A2B148")]
			set
			{
			}
		}

		[Token(Token = "0x170002FB")]
		public int slices
		{
			[Token(Token = "0x6000780")]
			[Address(RVA = "0x1A2B168", Offset = "0x1A2B168", VA = "0x1A2B168")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000781")]
			[Address(RVA = "0x1A2B170", Offset = "0x1A2B170", VA = "0x1A2B170")]
			set
			{
			}
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x1A2B198", Offset = "0x1A2B198", VA = "0x1A2B198", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x1A2B210", Offset = "0x1A2B210", VA = "0x1A2B210", Slot = "18")]
		protected override void BuildMesh()
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x1A2BC00", Offset = "0x1A2BC00", VA = "0x1A2BC00", Slot = "14")]
		protected override void Build()
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x1A2BC08", Offset = "0x1A2BC08", VA = "0x1A2BC08", Slot = "13")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x1A2B230", Offset = "0x1A2B230", VA = "0x1A2B230")]
		private void Generate()
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x1A2BC10", Offset = "0x1A2BC10", VA = "0x1A2BC10")]
		public WaveformGenerator()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006F")]
	public class ObjectSequence<T>
	{
		[Token(Token = "0x20000DA")]
		public enum Iteration
		{
			[Token(Token = "0x4000666")]
			Ordered,
			[Token(Token = "0x4000667")]
			Random
		}

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T startObject;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T endObject;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T[] objects;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Iteration iteration;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		private int _randomSeed;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		private int index;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		private System.Random randomizer;

		[Token(Token = "0x170002FC")]
		public int randomSeed
		{
			[Token(Token = "0x6000788")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000789")]
			set
			{
			}
		}

		[Token(Token = "0x600078A")]
		public ObjectSequence()
		{
		}

		[Token(Token = "0x600078B")]
		public T GetFirst()
		{
			return (T)null;
		}

		[Token(Token = "0x600078C")]
		public T GetLast()
		{
			return (T)null;
		}

		[Token(Token = "0x600078D")]
		public T Next()
		{
			return (T)null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000070")]
	public class SampleCollection
	{
		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[HideInInspector]
		public SplineSample[] samples;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int[] optimizedIndices;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SplineComputer.SampleMode sampleMode;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public double clipFrom;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public double clipTo;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool loopSamples;

		[Token(Token = "0x170002FD")]
		public int Count
		{
			[Token(Token = "0x600078E")]
			[Address(RVA = "0x22D6324", Offset = "0x22D6324", VA = "0x22D6324")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170002FE")]
		private bool hasSamples
		{
			[Token(Token = "0x600078F")]
			[Address(RVA = "0x22D6344", Offset = "0x22D6344", VA = "0x22D6344")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170002FF")]
		public bool samplesAreLooped
		{
			[Token(Token = "0x6000790")]
			[Address(RVA = "0x22D6370", Offset = "0x22D6370", VA = "0x22D6370")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000300")]
		public double span
		{
			[Token(Token = "0x6000791")]
			[Address(RVA = "0x22D639C", Offset = "0x22D639C", VA = "0x22D639C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x22D63E0", Offset = "0x22D63E0", VA = "0x22D63E0")]
		public SampleCollection()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x22D649C", Offset = "0x22D649C", VA = "0x22D649C")]
		public SampleCollection(SampleCollection input)
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x22D65F4", Offset = "0x22D65F4", VA = "0x22D65F4")]
		public int GetClippedSampleCount(out int startIndex, out int endIndex)
		{
			return default(int);
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x22D6A10", Offset = "0x22D6A10", VA = "0x22D6A10")]
		public double ClipPercent(double percent)
		{
			return default(double);
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x22D6A30", Offset = "0x22D6A30", VA = "0x22D6A30")]
		public void ClipPercent(ref double percent)
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x22D6B3C", Offset = "0x22D6B3C", VA = "0x22D6B3C")]
		public double UnclipPercent(double percent)
		{
			return default(double);
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x22D6B5C", Offset = "0x22D6B5C", VA = "0x22D6B5C")]
		public void UnclipPercent(ref double percent)
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x22D6788", Offset = "0x22D6788", VA = "0x22D6788")]
		public void GetSamplingValues(double percent, out int sampleIndex, out double lerp)
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x22D6C58", Offset = "0x22D6C58", VA = "0x22D6C58")]
		public Vector3 EvaluatePosition(double percent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x22D6DEC", Offset = "0x22D6DEC", VA = "0x22D6DEC")]
		public SplineSample Evaluate(double percent)
		{
			return null;
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x22D6E74", Offset = "0x22D6E74", VA = "0x22D6E74")]
		public void Evaluate(double percent, SplineSample result)
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x22D6FF8", Offset = "0x22D6FF8", VA = "0x22D6FF8")]
		public void Evaluate(ref SplineSample[] results, double from = 0.0, double to = 1.0)
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x22D742C", Offset = "0x22D742C", VA = "0x22D742C")]
		public void EvaluatePositions(ref Vector3[] positions, double from = 0.0, double to = 1.0)
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x22D778C", Offset = "0x22D778C", VA = "0x22D778C")]
		public double Travel(double start, float distance, Spline.Direction direction, out float moved)
		{
			return default(double);
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x22D7DAC", Offset = "0x22D7DAC", VA = "0x22D7DAC")]
		public double Travel(double start, float distance, Spline.Direction direction = Spline.Direction.Forward)
		{
			return default(double);
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x22D7DE4", Offset = "0x22D7DE4", VA = "0x22D7DE4")]
		public void Project(Vector3 position, int controlPointCount, SplineSample result, double from = 0.0, double to = 1.0)
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x22D8DCC", Offset = "0x22D8DCC", VA = "0x22D8DCC")]
		private double GetSamplePercent(int sampleIndex)
		{
			return default(double);
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x22D8E88", Offset = "0x22D8E88", VA = "0x22D8E88")]
		public float CalculateLength(double from = 0.0, double to = 1.0)
		{
			return default(float);
		}
	}
	[Serializable]
	[Token(Token = "0x2000071")]
	public class Spline
	{
		[Token(Token = "0x20000DB")]
		public enum Direction
		{
			[Token(Token = "0x4000669")]
			Forward = 1,
			[Token(Token = "0x400066A")]
			Backward = -1
		}

		[Token(Token = "0x20000DC")]
		public enum Type
		{
			[Token(Token = "0x400066C")]
			CatmullRom,
			[Token(Token = "0x400066D")]
			BSpline,
			[Token(Token = "0x400066E")]
			Bezier,
			[Token(Token = "0x400066F")]
			Linear
		}

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public SplinePoint[] points;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private bool closed;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Type type;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool linearAverageDirection;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve customValueInterpolation;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AnimationCurve customNormalInterpolation;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int sampleRate;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3[] catPoints;

		[Token(Token = "0x17000301")]
		public bool isClosed
		{
			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x22DC350", Offset = "0x22DC350", VA = "0x22DC350")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x22DC38C", Offset = "0x22DC38C", VA = "0x22DC38C")]
			set
			{
			}
		}

		[Token(Token = "0x17000302")]
		public double moveStep
		{
			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x22DC390", Offset = "0x22DC390", VA = "0x22DC390")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x22DC450", Offset = "0x22DC450", VA = "0x22DC450")]
			set
			{
			}
		}

		[Token(Token = "0x17000303")]
		public int iterations
		{
			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x22DC3E0", Offset = "0x22DC3E0", VA = "0x22DC3E0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x22DC454", Offset = "0x22DC454", VA = "0x22DC454")]
		public Spline(Type type)
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x22CF020", Offset = "0x22CF020", VA = "0x22CF020")]
		public Spline(Type type, int sampleRate)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x22DC508", Offset = "0x22DC508", VA = "0x22DC508")]
		public float CalculateLength(double from = 0.0, double to = 1.0, double resolution = 1.0)
		{
			return default(float);
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x22DC760", Offset = "0x22DC760", VA = "0x22DC760")]
		public double Project(Vector3 position, int subdivide = 4, double from = 0.0, double to = 1.0)
		{
			return default(double);
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x22DCC58", Offset = "0x22DCC58", VA = "0x22DCC58")]
		public bool Raycast(out RaycastHit hit, out double hitPercent, LayerMask layerMask, double resolution = 1.0, double from = 0.0, double to = 1.0, QueryTriggerInteraction hitTriggers = QueryTriggerInteraction.UseGlobal)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x22DCF2C", Offset = "0x22DCF2C", VA = "0x22DCF2C")]
		public bool RaycastAll(out RaycastHit[] hits, out double[] hitPercents, LayerMask layerMask, double resolution = 1.0, double from = 0.0, double to = 1.0, QueryTriggerInteraction hitTriggers = QueryTriggerInteraction.UseGlobal)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x22DD504", Offset = "0x22DD504", VA = "0x22DD504")]
		public double GetPointPercent(int pointIndex)
		{
			return default(double);
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x22DC6C4", Offset = "0x22DC6C4", VA = "0x22DC6C4")]
		public Vector3 EvaluatePosition(double percent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x22DD620", Offset = "0x22DD620", VA = "0x22DD620")]
		public SplineSample Evaluate(double percent)
		{
			return null;
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x22DE070", Offset = "0x22DE070", VA = "0x22DE070")]
		public SplineSample Evaluate(int pointIndex)
		{
			return null;
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x22DE100", Offset = "0x22DE100", VA = "0x22DE100")]
		public void Evaluate(SplineSample result, int pointIndex)
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x22DD6A8", Offset = "0x22DD6A8", VA = "0x22DD6A8")]
		public void Evaluate(SplineSample result, double percent)
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x22DE20C", Offset = "0x22DE20C", VA = "0x22DE20C")]
		public void Evaluate(ref SplineSample[] samples, double from = 0.0, double to = 1.0)
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x22DE494", Offset = "0x22DE494", VA = "0x22DE494")]
		public void EvaluateUniform(ref SplineSample[] samples, ref double[] originalSamplePercents, double from = 0.0, double to = 1.0)
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x22DED48", Offset = "0x22DED48", VA = "0x22DED48")]
		public void EvaluatePositions(ref Vector3[] positions, double from = 0.0, double to = 1.0)
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x22DEAF4", Offset = "0x22DEAF4", VA = "0x22DEAF4")]
		public double Travel(double start, float distance, out float moved, Direction direction)
		{
			return default(double);
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x22DEFD0", Offset = "0x22DEFD0", VA = "0x22DEFD0")]
		public double Travel(double start, float distance, Direction direction = Direction.Forward)
		{
			return default(double);
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x22DD54C", Offset = "0x22DD54C", VA = "0x22DD54C")]
		public void EvaluatePosition(ref Vector3 point, double percent)
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x22DE138", Offset = "0x22DE138", VA = "0x22DE138")]
		public void EvaluateTangent(ref Vector3 tangent, double percent)
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x22DC9D4", Offset = "0x22DC9D4", VA = "0x22DC9D4")]
		private double GetClosestPoint(int iterations, Vector3 point, double start, double end, int slices)
		{
			return default(double);
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x22DF2A4", Offset = "0x22DF2A4", VA = "0x22DF2A4")]
		public void Break()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x22DF2AC", Offset = "0x22DF2AC", VA = "0x22DF2AC")]
		public void Break(int at)
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x22CFB10", Offset = "0x22CFB10", VA = "0x22CFB10")]
		public void Close()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x22CF3DC", Offset = "0x22CF3DC", VA = "0x22CF3DC")]
		public void CatToBezierTangents()
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x22DF004", Offset = "0x22DF004", VA = "0x22DF004")]
		private void GetPoint(ref Vector3 point, double percent, int pointIndex)
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x22DF24C", Offset = "0x22DF24C", VA = "0x22DF24C")]
		private void GetTangent(ref Vector3 tangent, double percent, int pointIndex)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x22E0B84", Offset = "0x22E0B84", VA = "0x22E0B84")]
		private void LinearGetPoint(ref Vector3 point, double t, int i)
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x22E138C", Offset = "0x22E138C", VA = "0x22E138C")]
		private void LinearGetTangent(ref Vector3 tangent, double t, int i)
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x22E0640", Offset = "0x22E0640", VA = "0x22E0640")]
		private void BSPGetPoint(ref Vector3 point, double time, int i)
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x22E03E4", Offset = "0x22E03E4", VA = "0x22E03E4")]
		private void BezierGetPoint(ref Vector3 point, double t, int i)
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x22E109C", Offset = "0x22E109C", VA = "0x22E109C")]
		private void BezierGetTangent(ref Vector3 tangent, double t, int i)
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x22DFED4", Offset = "0x22DFED4", VA = "0x22DFED4")]
		private void CatmullRomGetPoint(ref Vector3 point, double t, int i)
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x22E0D60", Offset = "0x22E0D60", VA = "0x22E0D60")]
		private void GetCatmullRomTangent(ref Vector3 direction, double t, int i)
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x22DF600", Offset = "0x22DF600", VA = "0x22DF600")]
		private void GetCatPoints(int i)
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x22D7398", Offset = "0x22D7398", VA = "0x22D7398")]
		public static void FormatFromTo(ref double from, ref double to, bool preventInvert = true)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000072")]
	public struct SplinePoint
	{
		[Token(Token = "0x20000DD")]
		public enum Type
		{
			[Token(Token = "0x4000671")]
			SmoothMirrored,
			[Token(Token = "0x4000672")]
			Broken,
			[Token(Token = "0x4000673")]
			SmoothFree
		}

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x59F668", Offset = "0x59F668")]
		[SerializeField]
		[HideInInspector]
		private Type _type;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public Vector3 position;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color color;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 normal;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float size;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 tangent;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 tangent2;

		[Token(Token = "0x17000304")]
		public Type type
		{
			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x2694738", Offset = "0x2694738", VA = "0x2694738")]
			get
			{
				return default(Type);
			}
			[Token(Token = "0x60007CE")]
			[Address(RVA = "0x2693E90", Offset = "0x2693E90", VA = "0x2693E90")]
			set
			{
			}
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x2694780", Offset = "0x2694780", VA = "0x2694780")]
		public static SplinePoint Lerp(SplinePoint a, SplinePoint b, float t)
		{
			return default(SplinePoint);
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x2694984", Offset = "0x2694984", VA = "0x2694984")]
		private static void GetInterpolatedTangents(SplinePoint a, SplinePoint b, float t, out Vector3 t1, out Vector3 t2)
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x2694A88", Offset = "0x2694A88", VA = "0x2694A88")]
		public static bool AreDifferent(ref SplinePoint a, ref SplinePoint b)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x2694BA4", Offset = "0x2694BA4", VA = "0x2694BA4")]
		public void SetPosition(Vector3 pos)
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x2694C18", Offset = "0x2694C18", VA = "0x2694C18")]
		public void SetTangentPosition(Vector3 pos)
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x2694D44", Offset = "0x2694D44", VA = "0x2694D44")]
		public void SetTangent2Position(Vector3 pos)
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x2694EB0", Offset = "0x2694EB0", VA = "0x2694EB0")]
		public SplinePoint(Vector3 p)
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x2694F5C", Offset = "0x2694F5C", VA = "0x2694F5C")]
		public SplinePoint(Vector3 p, Vector3 t)
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x269504C", Offset = "0x269504C", VA = "0x269504C")]
		public SplinePoint(Vector3 pos, Vector3 tan, Vector3 nor, float s, Color col)
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x26950F8", Offset = "0x26950F8", VA = "0x26950F8")]
		public SplinePoint(Vector3 pos, Vector3 tan, Vector3 tan2, Vector3 nor, float s, Color col)
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x2695170", Offset = "0x2695170", VA = "0x2695170")]
		public SplinePoint(SplinePoint source)
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x2694740", Offset = "0x2694740", VA = "0x2694740")]
		private void SmoothMirrorTangent2()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x2694DA8", Offset = "0x2694DA8", VA = "0x2694DA8")]
		private void SmoothMirrorTangent()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x2694C7C", Offset = "0x2694C7C", VA = "0x2694C7C")]
		private void SmoothFreeTangent2()
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x2694DE8", Offset = "0x2694DE8", VA = "0x2694DE8")]
		private void SmoothFreeTangent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000073")]
	public class SplineSample
	{
		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector3 position;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 up;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 forward;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color color;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float size;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public double percent;

		[Token(Token = "0x17000305")]
		public Quaternion rotation
		{
			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x269125C", Offset = "0x269125C", VA = "0x269125C")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000306")]
		public Vector3 right
		{
			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x2691134", Offset = "0x2691134", VA = "0x2691134")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x26983A8", Offset = "0x26983A8", VA = "0x26983A8")]
		public static SplineSample Lerp(SplineSample a, SplineSample b, float t)
		{
			return null;
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x2698610", Offset = "0x2698610", VA = "0x2698610")]
		public static SplineSample Lerp(SplineSample a, SplineSample b, double t)
		{
			return null;
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x269869C", Offset = "0x269869C", VA = "0x269869C")]
		public static void Lerp(SplineSample a, SplineSample b, double t, SplineSample target)
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x269842C", Offset = "0x269842C", VA = "0x269842C")]
		public static void Lerp(SplineSample a, SplineSample b, float t, SplineSample target)
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x26988A0", Offset = "0x26988A0", VA = "0x26988A0")]
		public void Lerp(SplineSample b, double t)
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x26988BC", Offset = "0x26988BC", VA = "0x26988BC")]
		public void Lerp(SplineSample b, float t)
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x268B9A4", Offset = "0x268B9A4", VA = "0x268B9A4")]
		public void CopyFrom(SplineSample input)
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x269159C", Offset = "0x269159C", VA = "0x269159C")]
		public SplineSample()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x26988D8", Offset = "0x26988D8", VA = "0x26988D8")]
		public SplineSample(Vector3 position, Vector3 normal, Vector3 direction, Color color, float size, double percent)
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x26989E0", Offset = "0x26989E0", VA = "0x26989E0")]
		public SplineSample(SplineSample input)
		{
		}
	}
	[Token(Token = "0x2000074")]
	public static class SplineThreading
	{
		[Token(Token = "0x20000DE")]
		public delegate void EmptyHandler();

		[Token(Token = "0x20000DF")]
		internal class ThreadDef
		{
			[Token(Token = "0x2000117")]
			internal class Worker
			{
				[Token(Token = "0x4000743")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				internal bool computing;

				[Token(Token = "0x4000744")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				internal Queue<EmptyHandler> instructions;

				[Token(Token = "0x6000A4F")]
				[Address(RVA = "0x239A618", Offset = "0x239A618", VA = "0x239A618")]
				public Worker()
				{
				}
			}

			[Token(Token = "0x2000118")]
			internal delegate void BoolHandler(bool flag);

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private ParameterizedThreadStart start;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Thread thread;

			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Worker worker;

			[Token(Token = "0x17000363")]
			internal bool isAlive
			{
				[Token(Token = "0x600099F")]
				[Address(RVA = "0x239A500", Offset = "0x239A500", VA = "0x239A500")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000364")]
			internal bool computing
			{
				[Token(Token = "0x60009A0")]
				[Address(RVA = "0x239A518", Offset = "0x239A518", VA = "0x239A518")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60009A1")]
			[Address(RVA = "0x239A538", Offset = "0x239A538", VA = "0x239A538")]
			internal ThreadDef()
			{
			}

			[Token(Token = "0x60009A2")]
			[Address(RVA = "0x239A6B4", Offset = "0x239A6B4", VA = "0x239A6B4")]
			internal void Queue(EmptyHandler handler)
			{
			}

			[Token(Token = "0x60009A3")]
			[Address(RVA = "0x239A734", Offset = "0x239A734", VA = "0x239A734")]
			internal void Interrupt()
			{
			}

			[Token(Token = "0x60009A4")]
			[Address(RVA = "0x239A75C", Offset = "0x239A75C", VA = "0x239A75C")]
			internal void Restart()
			{
			}

			[Token(Token = "0x60009A5")]
			[Address(RVA = "0x239A85C", Offset = "0x239A85C", VA = "0x239A85C")]
			internal void Abort()
			{
			}
		}

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static ThreadDef[] threads;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		internal static readonly object locker;

		[Token(Token = "0x17000307")]
		public static int threadCount
		{
			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x2698CA4", Offset = "0x2698CA4", VA = "0x2698CA4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x2698D28", Offset = "0x2698D28", VA = "0x2698D28")]
			set
			{
			}
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x2698E98", Offset = "0x2698E98", VA = "0x2698E98")]
		static SplineThreading()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x2699034", Offset = "0x2699034", VA = "0x2699034")]
		private static void Quitting()
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x26991A8", Offset = "0x26991A8", VA = "0x26991A8")]
		private static void RunThread(object o)
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x269966C", Offset = "0x269966C", VA = "0x269966C")]
		public static void Run(EmptyHandler handler)
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x26999F4", Offset = "0x26999F4", VA = "0x26999F4")]
		public static void PrewarmThreads()
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x26990A0", Offset = "0x26990A0", VA = "0x26990A0")]
		public static void Stop()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000075")]
	public class TriggerGroup
	{
		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool enabled;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string name;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color color;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SplineTrigger[] triggers;

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x1A19A2C", Offset = "0x1A19A2C", VA = "0x1A19A2C")]
		public void Check(double start, double end, [Optional] SplineUser user)
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x1A19B64", Offset = "0x1A19B64", VA = "0x1A19B64")]
		public void Reset()
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x1A19BE4", Offset = "0x1A19BE4", VA = "0x1A19BE4")]
		public TriggerGroup()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000076")]
	public class SplineTrigger
	{
		[Token(Token = "0x20000E0")]
		public enum Type
		{
			[Token(Token = "0x4000678")]
			Double,
			[Token(Token = "0x4000679")]
			Forward,
			[Token(Token = "0x400067A")]
			Backward
		}

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string name;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		public Type type;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool workOnce;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		private bool worked;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59F6D0", Offset = "0x59F6D0")]
		public double position;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public bool enabled;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		public Color color;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[HideInInspector]
		public UnityEvent onCross;

		[Token(Token = "0x1400000C")]
		public event Action<SplineUser> onUserCross
		{
			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x269A610", Offset = "0x269A610", VA = "0x269A610")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0CA8", Offset = "0x5A0CA8")]
			add
			{
			}
			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x269A6BC", Offset = "0x269A6BC", VA = "0x269A6BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A0CB8", Offset = "0x5A0CB8")]
			remove
			{
			}
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x269A768", Offset = "0x269A768", VA = "0x269A768")]
		public SplineTrigger(Type t)
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x269A884", Offset = "0x269A884", VA = "0x269A884")]
		public void AddListener(UnityAction action)
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x269A8B4", Offset = "0x269A8B4", VA = "0x269A8B4")]
		public void Reset()
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x269A0E8", Offset = "0x269A0E8", VA = "0x269A0E8")]
		public bool Check(double previousPercent, double currentPercent)
		{
			return default(bool);
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x269A338", Offset = "0x269A338", VA = "0x269A338")]
		public void Invoke([Optional] SplineUser user)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000077")]
	public class TransformModule
	{
		[Token(Token = "0x20000E1")]
		public enum VelocityHandleMode
		{
			[Token(Token = "0x400067C")]
			Zero,
			[Token(Token = "0x400067D")]
			Preserve,
			[Token(Token = "0x400067E")]
			Align,
			[Token(Token = "0x400067F")]
			AlignRealistic
		}

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x59F748", Offset = "0x59F748")]
		private Vector2 _offset;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x59F7A0", Offset = "0x59F7A0")]
		private Vector3 _rotationOffset;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x59F7F8", Offset = "0x59F7F8")]
		private Vector3 _baseScale;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public VelocityHandleMode velocityHandleMode;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private SplineSample _splineResult;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool applyPositionX;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool applyPositionY;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool applyPositionZ;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Spline.Direction direction;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool applyRotationX;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool applyRotationY;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		public bool applyRotationZ;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
		public bool applyScaleX;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool applyScaleY;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		public bool applyScaleZ;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public SplineUser targetUser;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3 position;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static Quaternion rotation;

		[Token(Token = "0x17000308")]
		public Vector2 offset
		{
			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x1A17AF0", Offset = "0x1A17AF0", VA = "0x1A17AF0")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x1A17B04", Offset = "0x1A17B04", VA = "0x1A17B04")]
			set
			{
			}
		}

		[Token(Token = "0x17000309")]
		public Vector3 rotationOffset
		{
			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x1A17BF8", Offset = "0x1A17BF8", VA = "0x1A17BF8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x1A17C0C", Offset = "0x1A17C0C", VA = "0x1A17C0C")]
			set
			{
			}
		}

		[Token(Token = "0x1700030A")]
		public Vector3 baseScale
		{
			[Token(Token = "0x6000800")]
			[Address(RVA = "0x1A17D0C", Offset = "0x1A17D0C", VA = "0x1A17D0C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000801")]
			[Address(RVA = "0x1A17D20", Offset = "0x1A17D20", VA = "0x1A17D20")]
			set
			{
			}
		}

		[Token(Token = "0x1700030B")]
		public SplineSample splineResult
		{
			[Token(Token = "0x6000802")]
			[Address(RVA = "0x1A17E20", Offset = "0x1A17E20", VA = "0x1A17E20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000803")]
			[Address(RVA = "0x1A17EA0", Offset = "0x1A17EA0", VA = "0x1A17EA0")]
			set
			{
			}
		}

		[Token(Token = "0x1700030C")]
		public bool applyPosition
		{
			[Token(Token = "0x6000804")]
			[Address(RVA = "0x1A17F34", Offset = "0x1A17F34", VA = "0x1A17F34")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000805")]
			[Address(RVA = "0x1A17F64", Offset = "0x1A17F64", VA = "0x1A17F64")]
			set
			{
			}
		}

		[Token(Token = "0x1700030D")]
		public bool applyRotation
		{
			[Token(Token = "0x6000806")]
			[Address(RVA = "0x1A17F74", Offset = "0x1A17F74", VA = "0x1A17F74")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000807")]
			[Address(RVA = "0x1A17FA4", Offset = "0x1A17FA4", VA = "0x1A17FA4")]
			set
			{
			}
		}

		[Token(Token = "0x1700030E")]
		public bool applyScale
		{
			[Token(Token = "0x6000808")]
			[Address(RVA = "0x1A17FB4", Offset = "0x1A17FB4", VA = "0x1A17FB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000809")]
			[Address(RVA = "0x1A17FE4", Offset = "0x1A17FE4", VA = "0x1A17FE4")]
			set
			{
			}
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x1A17FF4", Offset = "0x1A17FF4", VA = "0x1A17FF4")]
		public void ApplyTransform(Transform input)
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x1A1881C", Offset = "0x1A1881C", VA = "0x1A1881C")]
		public void ApplyRigidbody(Rigidbody input)
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x1A18D1C", Offset = "0x1A18D1C", VA = "0x1A18D1C")]
		public void ApplyRigidbody2D(Rigidbody2D input)
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x1A18B50", Offset = "0x1A18B50", VA = "0x1A18B50")]
		private Vector3 HandleVelocity(Vector3 velocity)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x1A1817C", Offset = "0x1A1817C", VA = "0x1A1817C")]
		private Vector3 GetPosition(Vector3 inputPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x1A18430", Offset = "0x1A18430", VA = "0x1A18430")]
		private Quaternion GetRotation(Quaternion inputRotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x1A18760", Offset = "0x1A18760", VA = "0x1A18760")]
		private Vector3 GetScale(Vector3 inputScale)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x1A18FA0", Offset = "0x1A18FA0", VA = "0x1A18FA0")]
		public TransformModule()
		{
		}
	}
}
namespace Dreamteck.Splines.Primitives
{
	[Token(Token = "0x2000078")]
	public class Capsule : SplinePrimitive
	{
		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float radius;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float height;

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x133B608", Offset = "0x133B608", VA = "0x133B608", Slot = "6")]
		public override Spline.Type GetSplineType()
		{
			return default(Spline.Type);
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x133B610", Offset = "0x133B610", VA = "0x133B610", Slot = "5")]
		protected override void Generate()
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x133BF54", Offset = "0x133BF54", VA = "0x133BF54")]
		public Capsule()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class Ellipse : SplinePrimitive
	{
		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float xRadius;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float yRadius;

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x13428C4", Offset = "0x13428C4", VA = "0x13428C4", Slot = "6")]
		public override Spline.Type GetSplineType()
		{
			return default(Spline.Type);
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x13428CC", Offset = "0x13428CC", VA = "0x13428CC", Slot = "5")]
		protected override void Generate()
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x1342E34", Offset = "0x1342E34", VA = "0x1342E34")]
		public Ellipse()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class Line : SplinePrimitive
	{
		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool mirror;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float length;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int segments;

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x1349444", Offset = "0x1349444", VA = "0x1349444", Slot = "6")]
		public override Spline.Type GetSplineType()
		{
			return default(Spline.Type);
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x134944C", Offset = "0x134944C", VA = "0x134944C", Slot = "5")]
		protected override void Generate()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x13495C8", Offset = "0x13495C8", VA = "0x13495C8")]
		public Line()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class Ngon : SplinePrimitive
	{
		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float radius;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int sides;

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x1AA4990", Offset = "0x1AA4990", VA = "0x1AA4990", Slot = "6")]
		public override Spline.Type GetSplineType()
		{
			return default(Spline.Type);
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x1AA4998", Offset = "0x1AA4998", VA = "0x1AA4998", Slot = "5")]
		protected override void Generate()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x1AA4BB8", Offset = "0x1AA4BB8", VA = "0x1AA4BB8")]
		public Ngon()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class Rectangle : SplinePrimitive
	{
		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector2 size;

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x1AB51D0", Offset = "0x1AB51D0", VA = "0x1AB51D0", Slot = "6")]
		public override Spline.Type GetSplineType()
		{
			return default(Spline.Type);
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x1AB51D8", Offset = "0x1AB51D8", VA = "0x1AB51D8", Slot = "5")]
		protected override void Generate()
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x1AB55E0", Offset = "0x1AB55E0", VA = "0x1AB55E0")]
		public Rectangle()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class RoundedRectangle : SplinePrimitive
	{
		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector2 size;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float xRadius;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float yRadius;

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x22CD5F0", Offset = "0x22CD5F0", VA = "0x22CD5F0", Slot = "6")]
		public override Spline.Type GetSplineType()
		{
			return default(Spline.Type);
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x22CD5F8", Offset = "0x22CD5F8", VA = "0x22CD5F8", Slot = "5")]
		protected override void Generate()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x22CE1E8", Offset = "0x22CE1E8", VA = "0x22CE1E8")]
		public RoundedRectangle()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class Spiral : SplinePrimitive
	{
		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float startRadius;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float endRadius;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float stretch;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int iterations;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool clockwise;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve curve;

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x22DBB68", Offset = "0x22DBB68", VA = "0x22DBB68", Slot = "6")]
		public override Spline.Type GetSplineType()
		{
			return default(Spline.Type);
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x22DBB70", Offset = "0x22DBB70", VA = "0x22DBB70", Slot = "5")]
		protected override void Generate()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x22DC2B4", Offset = "0x22DC2B4", VA = "0x22DC2B4")]
		public Spiral()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class SplinePrimitive
	{
		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected bool closed;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		protected SplinePoint[] points;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 offset;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 rotation;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool is2D;

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x269580C", Offset = "0x269580C", VA = "0x269580C", Slot = "4")]
		public virtual void Calculate()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x2695C98", Offset = "0x2695C98", VA = "0x2695C98", Slot = "5")]
		protected virtual void Generate()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x2695C9C", Offset = "0x2695C9C", VA = "0x2695C9C")]
		public Spline CreateSpline()
		{
			return null;
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x2695D70", Offset = "0x2695D70", VA = "0x2695D70")]
		public void UpdateSpline(Spline spline)
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x2695E48", Offset = "0x2695E48", VA = "0x2695E48")]
		public SplineComputer CreateSplineComputer(string name, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x2696000", Offset = "0x2696000", VA = "0x2696000")]
		public void UpdateSplineComputer(SplineComputer comp)
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x26960F0", Offset = "0x26960F0", VA = "0x26960F0")]
		public SplinePoint[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x26960F8", Offset = "0x26960F8", VA = "0x26960F8", Slot = "6")]
		public virtual Spline.Type GetSplineType()
		{
			return default(Spline.Type);
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x2696100", Offset = "0x2696100", VA = "0x2696100")]
		public bool GetIsClosed()
		{
			return default(bool);
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x2695838", Offset = "0x2695838", VA = "0x2695838")]
		private void ApplyOffset()
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x2696108", Offset = "0x2696108", VA = "0x2696108")]
		protected void CreatePoints(int count, SplinePoint.Type type)
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x2696330", Offset = "0x2696330", VA = "0x2696330")]
		public SplinePrimitive()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class Star : SplinePrimitive
	{
		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float radius;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float depth;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int sides;

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x269BC94", Offset = "0x269BC94", VA = "0x269BC94", Slot = "6")]
		public override Spline.Type GetSplineType()
		{
			return default(Spline.Type);
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x269BC9C", Offset = "0x269BC9C", VA = "0x269BC9C", Slot = "5")]
		protected override void Generate()
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x269BF04", Offset = "0x269BF04", VA = "0x269BF04")]
		public Star()
		{
		}
	}
}
namespace Dreamteck.Splines.IO
{
	[Token(Token = "0x2000081")]
	public class CSV : SplineParser
	{
		[Token(Token = "0x20000E2")]
		public enum ColumnType
		{
			[Token(Token = "0x4000681")]
			Position,
			[Token(Token = "0x4000682")]
			Tangent,
			[Token(Token = "0x4000683")]
			Tangent2,
			[Token(Token = "0x4000684")]
			Normal,
			[Token(Token = "0x4000685")]
			Size,
			[Token(Token = "0x4000686")]
			Color
		}

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<ColumnType> columns;

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x1338868", Offset = "0x1338868", VA = "0x1338868")]
		public CSV(SplineComputer computer)
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x1338B30", Offset = "0x1338B30", VA = "0x1338B30")]
		public CSV(string filePath, [Optional] List<ColumnType> customColumns)
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x1338EB8", Offset = "0x1338EB8", VA = "0x1338EB8")]
		private void Read(string[] lines)
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x1339CAC", Offset = "0x1339CAC", VA = "0x1339CAC")]
		public SplineComputer CreateSplineComputer(Vector3 position, Quaternion rotation)
		{
			return null;
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x1339D18", Offset = "0x1339D18", VA = "0x1339D18")]
		public Spline CreateSpline()
		{
			return null;
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x1339D40", Offset = "0x1339D40", VA = "0x1339D40")]
		public void FlatX()
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x133A024", Offset = "0x133A024", VA = "0x133A024")]
		public void FlatY()
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x133A2FC", Offset = "0x133A2FC", VA = "0x133A2FC")]
		public void FlatZ()
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x133A5D0", Offset = "0x133A5D0", VA = "0x133A5D0")]
		private void AddTitle(ref string[] content, string title)
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x133A6EC", Offset = "0x133A6EC", VA = "0x133A6EC")]
		private void AddVector3Title(ref string[] content, string prefix)
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x133A9C8", Offset = "0x133A9C8", VA = "0x133A9C8")]
		private void AddColorTitle(ref string[] content, string prefix)
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x133AD6C", Offset = "0x133AD6C", VA = "0x133AD6C")]
		private void AddVector3(ref string[] content, int index, Vector3 vector)
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x133AEF0", Offset = "0x133AEF0", VA = "0x133AEF0")]
		private void AddColor(ref string[] content, int index, Color color)
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x133ADAC", Offset = "0x133ADAC", VA = "0x133ADAC")]
		private void AddFloat(ref string[] content, int index, float value)
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x133AF40", Offset = "0x133AF40", VA = "0x133AF40")]
		public void Write(string filePath)
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class SVG : SplineParser
	{
		[Token(Token = "0x20000E3")]
		public enum Axis
		{
			[Token(Token = "0x4000688")]
			X,
			[Token(Token = "0x4000689")]
			Y,
			[Token(Token = "0x400068A")]
			Z
		}

		[Token(Token = "0x20000E4")]
		internal class PathSegment
		{
			[Token(Token = "0x2000119")]
			internal enum Type
			{
				[Token(Token = "0x4000746")]
				Cubic,
				[Token(Token = "0x4000747")]
				CubicShort,
				[Token(Token = "0x4000748")]
				Quadratic,
				[Token(Token = "0x4000749")]
				QuadraticShort
			}

			[Token(Token = "0x400068B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Vector3 startTangent;

			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal Vector3 endTangent;

			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Vector3 endPoint;

			[Token(Token = "0x60009A6")]
			[Address(RVA = "0x2392A6C", Offset = "0x2392A6C", VA = "0x2392A6C")]
			internal PathSegment(Vector2 s, Vector2 e, Vector2 c)
			{
			}

			[Token(Token = "0x60009A7")]
			[Address(RVA = "0x2392B14", Offset = "0x2392B14", VA = "0x2392B14")]
			internal PathSegment()
			{
			}
		}

		[Token(Token = "0x20000E5")]
		public enum Element
		{
			[Token(Token = "0x400068F")]
			All,
			[Token(Token = "0x4000690")]
			Path,
			[Token(Token = "0x4000691")]
			Polygon,
			[Token(Token = "0x4000692")]
			Ellipse,
			[Token(Token = "0x4000693")]
			Rectangle,
			[Token(Token = "0x4000694")]
			Line
		}

		[Serializable]
		[Token(Token = "0x20000E6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C07C", Offset = "0x59C07C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static Func<string, bool> <>9__23_0;

			[Token(Token = "0x60009A9")]
			[Address(RVA = "0x2392A48", Offset = "0x2392A48", VA = "0x2392A48")]
			public <>c()
			{
			}

			[Token(Token = "0x60009AA")]
			[Address(RVA = "0x2392A50", Offset = "0x2392A50", VA = "0x2392A50")]
			internal bool <ReadPath>b__23_0(string t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<SplineDefinition> paths;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private List<SplineDefinition> polygons;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<SplineDefinition> ellipses;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private List<SplineDefinition> rectangles;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<SplineDefinition> lines;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private List<Transformation> transformBuffer;

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x22CE610", Offset = "0x22CE610", VA = "0x22CE610")]
		public SVG(string filePath)
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x22CEB18", Offset = "0x22CEB18", VA = "0x22CEB18")]
		public SVG(List<SplineComputer> computers)
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x22CFBCC", Offset = "0x22CFBCC", VA = "0x22CFBCC")]
		public void Write(string filePath, Axis ax = Axis.Z)
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x22D0E70", Offset = "0x22D0E70", VA = "0x22D0E70")]
		private Vector2 MapPoint(Vector3 original, Axis ax)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x22CEA80", Offset = "0x22CEA80", VA = "0x22CEA80")]
		private void Read(XmlDocument doc)
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x22D0EBC", Offset = "0x22D0EBC", VA = "0x22D0EBC")]
		private void Traverse(XmlNodeList nodes)
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x22D30E8", Offset = "0x22D30E8", VA = "0x22D30E8")]
		public List<SplineComputer> CreateSplineComputers(Vector3 position, Quaternion rotation, Element elements = Element.All)
		{
			return null;
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x22D399C", Offset = "0x22D399C", VA = "0x22D399C")]
		public List<Spline> CreateSplines(Element elements = Element.All)
		{
			return null;
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x22D2AF8", Offset = "0x22D2AF8", VA = "0x22D2AF8")]
		private int ReadRectangle(XmlNode rectNode)
		{
			return default(int);
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x22D2788", Offset = "0x22D2788", VA = "0x22D2788")]
		private int ReadLine(XmlNode lineNode)
		{
			return default(int);
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x22D2364", Offset = "0x22D2364", VA = "0x22D2364")]
		private int ReadEllipse(XmlNode ellipseNode)
		{
			return default(int);
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x22D1FA8", Offset = "0x22D1FA8", VA = "0x22D1FA8")]
		private int ReadPolygon(XmlNode polyNode, bool closed)
		{
			return default(int);
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x22D15A0", Offset = "0x22D15A0", VA = "0x22D15A0")]
		private int ParseTransformation(XmlNode node)
		{
			return default(int);
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x22D4344", Offset = "0x22D4344", VA = "0x22D4344")]
		private List<Transformation> ParseTransformations(string transformContent)
		{
			return null;
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x22D16A4", Offset = "0x22D16A4", VA = "0x22D16A4")]
		private int ReadPath(XmlNode pathNode)
		{
			return default(int);
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x22D5094", Offset = "0x22D5094", VA = "0x22D5094")]
		private void PathStart(string name, string coords, bool relative)
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x22D522C", Offset = "0x22D522C", VA = "0x22D522C")]
		private void PathClose()
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x22D5250", Offset = "0x22D5250", VA = "0x22D5250")]
		private void PathLineTo(string coords, bool relative)
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x22D5358", Offset = "0x22D5358", VA = "0x22D5358")]
		private void PathHorizontalLineTo(string coords, bool relative)
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x22D5400", Offset = "0x22D5400", VA = "0x22D5400")]
		private void PathVerticalLineTo(string coords, bool relative)
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x22D54AC", Offset = "0x22D54AC", VA = "0x22D54AC")]
		private void PathCurveTo(string coords, PathSegment.Type type, bool relative)
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x22D429C", Offset = "0x22D429C", VA = "0x22D429C")]
		private void WriteBufferTo(List<SplineDefinition> list)
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x22D5AA4", Offset = "0x22D5AA4", VA = "0x22D5AA4")]
		private PathSegment[] ParsePathSegment(string coord, PathSegment.Type type)
		{
			return null;
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x22D0644", Offset = "0x22D0644", VA = "0x22D0644")]
		private string EncodePath(SplineDefinition definition, Axis ax)
		{
			return null;
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x22D0460", Offset = "0x22D0460", VA = "0x22D0460")]
		private string EncodePolygon(SplineDefinition definition, Axis ax)
		{
			return null;
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x22D4128", Offset = "0x22D4128", VA = "0x22D4128")]
		private string GetAttributeContent(XmlNode node, string attributeName)
		{
			return null;
		}
	}
	[Token(Token = "0x2000083")]
	public class SplineParser
	{
		[Token(Token = "0x20000E7")]
		internal class Transformation
		{
			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected static Matrix4x4 matrix;

			[Token(Token = "0x60009AB")]
			[Address(RVA = "0x2399544", Offset = "0x2399544", VA = "0x2399544")]
			internal static void ResetMatrix()
			{
			}

			[Token(Token = "0x60009AC")]
			[Address(RVA = "0x23998A8", Offset = "0x23998A8", VA = "0x23998A8", Slot = "4")]
			internal virtual void Push()
			{
			}

			[Token(Token = "0x60009AD")]
			[Address(RVA = "0x2399634", Offset = "0x2399634", VA = "0x2399634")]
			internal static void Apply(SplinePoint[] points)
			{
			}

			[Token(Token = "0x60009AE")]
			[Address(RVA = "0x23970D8", Offset = "0x23970D8", VA = "0x23970D8")]
			public Transformation()
			{
			}
		}

		[Token(Token = "0x20000E8")]
		internal class Translate : Transformation
		{
			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private Vector2 offset;

			[Token(Token = "0x60009B0")]
			[Address(RVA = "0x23998B0", Offset = "0x23998B0", VA = "0x23998B0")]
			public Translate(Vector2 o)
			{
			}

			[Token(Token = "0x60009B1")]
			[Address(RVA = "0x2399958", Offset = "0x2399958", VA = "0x2399958", Slot = "4")]
			internal override void Push()
			{
			}
		}

		[Token(Token = "0x20000E9")]
		internal class Rotate : Transformation
		{
			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private float angle;

			[Token(Token = "0x60009B2")]
			[Address(RVA = "0x239731C", Offset = "0x239731C", VA = "0x239731C")]
			public Rotate(float a)
			{
			}

			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x23973A8", Offset = "0x23973A8", VA = "0x23973A8", Slot = "4")]
			internal override void Push()
			{
			}
		}

		[Token(Token = "0x20000EA")]
		internal class Scale : Transformation
		{
			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private Vector2 multiplier;

			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x239769C", Offset = "0x239769C", VA = "0x239769C")]
			public Scale(Vector2 s)
			{
			}

			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x2397744", Offset = "0x2397744", VA = "0x2397744", Slot = "4")]
			internal override void Push()
			{
			}
		}

		[Token(Token = "0x20000EB")]
		internal class SkewX : Transformation
		{
			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private float amount;

			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x23979FC", Offset = "0x23979FC", VA = "0x23979FC")]
			public SkewX(float a)
			{
			}

			[Token(Token = "0x60009B7")]
			[Address(RVA = "0x2397A88", Offset = "0x2397A88", VA = "0x2397A88", Slot = "4")]
			internal override void Push()
			{
			}
		}

		[Token(Token = "0x20000EC")]
		internal class SkewY : Transformation
		{
			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private float amount;

			[Token(Token = "0x60009B8")]
			[Address(RVA = "0x2397D80", Offset = "0x2397D80", VA = "0x2397D80")]
			public SkewY(float a)
			{
			}

			[Token(Token = "0x60009B9")]
			[Address(RVA = "0x2397E0C", Offset = "0x2397E0C", VA = "0x2397E0C", Slot = "4")]
			internal override void Push()
			{
			}
		}

		[Token(Token = "0x20000ED")]
		internal class MatrixTransform : Transformation
		{
			[Token(Token = "0x400069D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private Matrix4x4 transformMatrix;

			[Token(Token = "0x60009BA")]
			[Address(RVA = "0x2396F08", Offset = "0x2396F08", VA = "0x2396F08")]
			public MatrixTransform(float a, float b, float c, float d, float e, float f)
			{
			}

			[Token(Token = "0x60009BB")]
			[Address(RVA = "0x23970E0", Offset = "0x23970E0", VA = "0x23970E0", Slot = "4")]
			internal override void Push()
			{
			}
		}

		[Token(Token = "0x20000EE")]
		internal class SplineDefinition
		{
			[Token(Token = "0x400069E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal string name;

			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Spline.Type type;

			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal List<SplinePoint> points;

			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal bool closed;

			[Token(Token = "0x40006A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Vector3 position;

			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal Vector3 tangent;

			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Vector3 tangent2;

			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal Vector3 normal;

			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal float size;

			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			internal Color color;

			[Token(Token = "0x17000365")]
			internal int pointCount
			{
				[Token(Token = "0x60009BC")]
				[Address(RVA = "0x2398104", Offset = "0x2398104", VA = "0x2398104")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x60009BD")]
			[Address(RVA = "0x2398158", Offset = "0x2398158", VA = "0x2398158")]
			internal SplineDefinition(string n, Spline.Type t)
			{
			}

			[Token(Token = "0x60009BE")]
			[Address(RVA = "0x23982D4", Offset = "0x23982D4", VA = "0x23982D4")]
			internal SplineDefinition(string n, Spline spline)
			{
			}

			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x23984E0", Offset = "0x23984E0", VA = "0x23984E0")]
			internal SplinePoint GetLastPoint()
			{
				return default(SplinePoint);
			}

			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x23985BC", Offset = "0x23985BC", VA = "0x23985BC")]
			internal void SetLastPoint(SplinePoint point)
			{
			}

			[Token(Token = "0x60009C1")]
			[Address(RVA = "0x2398740", Offset = "0x2398740", VA = "0x2398740")]
			internal void CreateClosingPoint()
			{
			}

			[Token(Token = "0x60009C2")]
			[Address(RVA = "0x2398944", Offset = "0x2398944", VA = "0x2398944")]
			internal void CreateSmooth()
			{
			}

			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x2398B10", Offset = "0x2398B10", VA = "0x2398B10")]
			internal void CreateBroken()
			{
			}

			[Token(Token = "0x60009C4")]
			[Address(RVA = "0x2398DD4", Offset = "0x2398DD4", VA = "0x2398DD4")]
			internal void CreateLinear()
			{
			}

			[Token(Token = "0x60009C5")]
			[Address(RVA = "0x2398DE8", Offset = "0x2398DE8", VA = "0x2398DE8")]
			internal SplineComputer CreateSplineComputer(Vector3 position, Quaternion rotation)
			{
				return null;
			}

			[Token(Token = "0x60009C6")]
			[Address(RVA = "0x23990A4", Offset = "0x23990A4", VA = "0x23990A4")]
			internal Spline CreateSpline()
			{
				return null;
			}

			[Token(Token = "0x60009C7")]
			[Address(RVA = "0x2399180", Offset = "0x2399180", VA = "0x2399180")]
			internal void Transform(List<Transformation> trs)
			{
			}
		}

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected string fileName;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal SplineDefinition buffer;

		[Token(Token = "0x1700030F")]
		public string name
		{
			[Token(Token = "0x6000860")]
			[Address(RVA = "0x2693F9C", Offset = "0x2693F9C", VA = "0x2693F9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x2693FA4", Offset = "0x2693FA4", VA = "0x2693FA4")]
		internal Vector2[] ParseVector2(string coord)
		{
			return null;
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x26944B8", Offset = "0x26944B8", VA = "0x26944B8")]
		internal float[] ParseFloat(string coord)
		{
			return null;
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x2694204", Offset = "0x2694204", VA = "0x2694204")]
		internal List<float> ParseFloatArray(string content)
		{
			return null;
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x269460C", Offset = "0x269460C", VA = "0x269460C")]
		public bool IsWHiteSpace(string s)
		{
			return default(bool);
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x26946D0", Offset = "0x26946D0", VA = "0x26946D0")]
		public SplineParser()
		{
		}
	}
}
namespace UnityAsyncAwaitUtil
{
	[Token(Token = "0x2000084")]
	public class AsyncUtilTests : MonoBehaviour
	{
		[Token(Token = "0x20000EF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C08C", Offset = "0x59C08C")]
		private sealed class <RunAsyncFromCoroutineTest>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x17000366")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009CB")]
				[Address(RVA = "0x1A2D1DC", Offset = "0x1A2D1DC", VA = "0x1A2D1DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000367")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009CD")]
				[Address(RVA = "0x1A2D22C", Offset = "0x1A2D22C", VA = "0x1A2D22C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009C8")]
			[Address(RVA = "0x1A2CFA8", Offset = "0x1A2CFA8", VA = "0x1A2CFA8")]
			[DebuggerHidden]
			public <RunAsyncFromCoroutineTest>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60009C9")]
			[Address(RVA = "0x1A2CFC8", Offset = "0x1A2CFC8", VA = "0x1A2CFC8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009CA")]
			[Address(RVA = "0x1A2CFCC", Offset = "0x1A2CFCC", VA = "0x1A2CFCC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x1A2D1E4", Offset = "0x1A2D1E4", VA = "0x1A2D1E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C09C", Offset = "0x59C09C")]
		private struct <RunMultipleThreadsTestAsync>d__7 : IAsyncStateMachine
		{
			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__3;

			[Token(Token = "0x60009CE")]
			[Address(RVA = "0x1A2E820", Offset = "0x1A2E820", VA = "0x1A2E820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009CF")]
			[Address(RVA = "0x1A2F004", Offset = "0x1A2F004", VA = "0x1A2F004", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C0AC", Offset = "0x59C0AC")]
		private struct <RunMultipleThreadsTestAsyncWait>d__8 : IAsyncStateMachine
		{
			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private object <>u__1;

			[Token(Token = "0x60009D0")]
			[Address(RVA = "0x1A2F010", Offset = "0x1A2F010", VA = "0x1A2F010", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009D1")]
			[Address(RVA = "0x1A2F2E8", Offset = "0x1A2F2E8", VA = "0x1A2F2E8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C0BC", Offset = "0x59C0BC")]
		private struct <RunAsyncFromCoroutineTest2>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private object <>u__1;

			[Token(Token = "0x60009D2")]
			[Address(RVA = "0x1A2CD40", Offset = "0x1A2CD40", VA = "0x1A2CD40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009D3")]
			[Address(RVA = "0x1A2CF9C", Offset = "0x1A2CF9C", VA = "0x1A2CF9C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C0CC", Offset = "0x59C0CC")]
		private struct <RunWwwAsync>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private object <>u__1;

			[Token(Token = "0x60009D4")]
			[Address(RVA = "0x1A2FDE4", Offset = "0x1A2FDE4", VA = "0x1A2FDE4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x1A301E0", Offset = "0x1A301E0", VA = "0x1A301E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C0DC", Offset = "0x59C0DC")]
		private struct <RunOpenNotepadTestAsync>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private TaskAwaiter<int> <>u__1;

			[Token(Token = "0x60009D6")]
			[Address(RVA = "0x1A2F2F4", Offset = "0x1A2F2F4", VA = "0x1A2F2F4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009D7")]
			[Address(RVA = "0x1A2F5AC", Offset = "0x1A2F5AC", VA = "0x1A2F5AC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C0EC", Offset = "0x59C0EC")]
		private struct <RunUnhandledExceptionTestAsync>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x60009D8")]
			[Address(RVA = "0x1A2FC08", Offset = "0x1A2FC08", VA = "0x1A2FC08", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009D9")]
			[Address(RVA = "0x1A2FDD8", Offset = "0x1A2FDD8", VA = "0x1A2FDD8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C0FC", Offset = "0x59C0FC")]
		private struct <RunTryCatchExceptionTestAsync>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x60009DA")]
			[Address(RVA = "0x1A2F8C4", Offset = "0x1A2F8C4", VA = "0x1A2F8C4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009DB")]
			[Address(RVA = "0x1A2FBFC", Offset = "0x1A2FBFC", VA = "0x1A2FBFC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C10C", Offset = "0x59C10C")]
		private struct <NestedRunAsync>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private object <>u__1;

			[Token(Token = "0x60009DC")]
			[Address(RVA = "0x1A2CA94", Offset = "0x1A2CA94", VA = "0x1A2CA94", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x1A2CD34", Offset = "0x1A2CD34", VA = "0x1A2CD34", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C11C", Offset = "0x59C11C")]
		private struct <WaitThenThrowException>d__16 : IAsyncStateMachine
		{
			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private object <>u__1;

			[Token(Token = "0x60009DE")]
			[Address(RVA = "0x238D464", Offset = "0x238D464", VA = "0x238D464", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009DF")]
			[Address(RVA = "0x238D704", Offset = "0x238D704", VA = "0x238D704", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C12C", Offset = "0x59C12C")]
		private struct <RunAsyncOperationAsync>d__17 : IAsyncStateMachine
		{
			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x60009E0")]
			[Address(RVA = "0x1A2D234", Offset = "0x1A2D234", VA = "0x1A2D234", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009E1")]
			[Address(RVA = "0x1A2D444", Offset = "0x1A2D444", VA = "0x1A2D444", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000FA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C13C", Offset = "0x59C13C")]
		private struct <InstantiateAssetBundleAsync>d__18 : IAsyncStateMachine
		{
			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public string abUrl;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string assetName;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private AssetBundle <assetBundle>5__2;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private TaskAwaiter<byte[]> <>u__1;

			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private object <>u__2;

			[Token(Token = "0x60009E2")]
			[Address(RVA = "0x1A2C33C", Offset = "0x1A2C33C", VA = "0x1A2C33C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x1A2CA88", Offset = "0x1A2CA88", VA = "0x1A2CA88", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000FB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C14C", Offset = "0x59C14C")]
		private struct <DownloadRawDataAsync>d__19 : IAsyncStateMachine
		{
			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder<byte[]> <>t__builder;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string url;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private UnityWebRequest <request>5__2;

			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>u__1;

			[Token(Token = "0x60009E4")]
			[Address(RVA = "0x1A2BC94", Offset = "0x1A2BC94", VA = "0x1A2BC94", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009E5")]
			[Address(RVA = "0x1A2BFD4", Offset = "0x1A2BFD4", VA = "0x1A2BFD4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C15C", Offset = "0x59C15C")]
		private struct <RunIEnumeratorTryCatchExceptionAsync>d__20 : IAsyncStateMachine
		{
			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private object <>u__1;

			[Token(Token = "0x60009E6")]
			[Address(RVA = "0x1A2DE20", Offset = "0x1A2DE20", VA = "0x1A2DE20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x1A2E1FC", Offset = "0x1A2E1FC", VA = "0x1A2E1FC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000FD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C16C", Offset = "0x59C16C")]
		private struct <RunIEnumeratorUnhandledExceptionAsync>d__21 : IAsyncStateMachine
		{
			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private object <>u__1;

			[Token(Token = "0x60009E8")]
			[Address(RVA = "0x1A2E208", Offset = "0x1A2E208", VA = "0x1A2E208", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009E9")]
			[Address(RVA = "0x1A2E47C", Offset = "0x1A2E47C", VA = "0x1A2E47C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20000FE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C17C", Offset = "0x59C17C")]
		private sealed class <WaitThenThrow>d__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x17000368")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009ED")]
				[Address(RVA = "0x238D40C", Offset = "0x238D40C", VA = "0x238D40C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000369")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009EF")]
				[Address(RVA = "0x238D45C", Offset = "0x238D45C", VA = "0x238D45C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009EA")]
			[Address(RVA = "0x238D378", Offset = "0x238D378", VA = "0x238D378")]
			[DebuggerHidden]
			public <WaitThenThrow>d__22(int <>1__state)
			{
			}

			[Token(Token = "0x60009EB")]
			[Address(RVA = "0x238D398", Offset = "0x238D398", VA = "0x238D398", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009EC")]
			[Address(RVA = "0x238D39C", Offset = "0x238D39C", VA = "0x238D39C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x238D414", Offset = "0x238D414", VA = "0x238D414", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000FF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C18C", Offset = "0x59C18C")]
		private sealed class <WaitThenThrowNested>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x1700036A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009F3")]
				[Address(RVA = "0x238D894", Offset = "0x238D894", VA = "0x238D894", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700036B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009F5")]
				[Address(RVA = "0x238D8E4", Offset = "0x238D8E4", VA = "0x238D8E4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009F0")]
			[Address(RVA = "0x238D710", Offset = "0x238D710", VA = "0x238D710")]
			[DebuggerHidden]
			public <WaitThenThrowNested>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x238D730", Offset = "0x238D730", VA = "0x238D730", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009F2")]
			[Address(RVA = "0x238D734", Offset = "0x238D734", VA = "0x238D734", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009F4")]
			[Address(RVA = "0x238D89C", Offset = "0x238D89C", VA = "0x238D89C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C19C", Offset = "0x59C19C")]
		private struct <RunIEnumeratorStringTestAsync>d__24 : IAsyncStateMachine
		{
			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private object <>u__1;

			[Token(Token = "0x60009F6")]
			[Address(RVA = "0x1A2D774", Offset = "0x1A2D774", VA = "0x1A2D774", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009F7")]
			[Address(RVA = "0x1A2DAD8", Offset = "0x1A2DAD8", VA = "0x1A2DAD8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000101")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C1AC", Offset = "0x59C1AC")]
		private struct <RunIEnumeratorUntypedStringTestAsync>d__25 : IAsyncStateMachine
		{
			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private object <>u__1;

			[Token(Token = "0x60009F8")]
			[Address(RVA = "0x1A2E488", Offset = "0x1A2E488", VA = "0x1A2E488", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009F9")]
			[Address(RVA = "0x1A2E814", Offset = "0x1A2E814", VA = "0x1A2E814", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000102")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C1BC", Offset = "0x59C1BC")]
		private struct <RunIEnumeratorTestAsync>d__26 : IAsyncStateMachine
		{
			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private object <>u__1;

			[Token(Token = "0x60009FA")]
			[Address(RVA = "0x1A2DAE4", Offset = "0x1A2DAE4", VA = "0x1A2DAE4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009FB")]
			[Address(RVA = "0x1A2DE14", Offset = "0x1A2DE14", VA = "0x1A2DE14", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000103")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C1CC", Offset = "0x59C1CC")]
		private sealed class <WaitForString>d__27 : IEnumerator<string>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private string <>2__current;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private float <startTime>5__2;

			[Token(Token = "0x1700036C")]
			private string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[Token(Token = "0x60009FF")]
				[Address(RVA = "0x1A3042C", Offset = "0x1A3042C", VA = "0x1A3042C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700036D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A01")]
				[Address(RVA = "0x1A3047C", Offset = "0x1A3047C", VA = "0x1A3047C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009FC")]
			[Address(RVA = "0x1A30310", Offset = "0x1A30310", VA = "0x1A30310")]
			[DebuggerHidden]
			public <WaitForString>d__27(int <>1__state)
			{
			}

			[Token(Token = "0x60009FD")]
			[Address(RVA = "0x1A30330", Offset = "0x1A30330", VA = "0x1A30330", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009FE")]
			[Address(RVA = "0x1A30334", Offset = "0x1A30334", VA = "0x1A30334", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A00")]
			[Address(RVA = "0x1A30434", Offset = "0x1A30434", VA = "0x1A30434", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000104")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C1DC", Offset = "0x59C1DC")]
		private sealed class <WaitForStringUntyped>d__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x1700036E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A05")]
				[Address(RVA = "0x1A30580", Offset = "0x1A30580", VA = "0x1A30580", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700036F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A07")]
				[Address(RVA = "0x1A305D0", Offset = "0x1A305D0", VA = "0x1A305D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A02")]
			[Address(RVA = "0x1A30484", Offset = "0x1A30484", VA = "0x1A30484")]
			[DebuggerHidden]
			public <WaitForStringUntyped>d__28(int <>1__state)
			{
			}

			[Token(Token = "0x6000A03")]
			[Address(RVA = "0x1A304A4", Offset = "0x1A304A4", VA = "0x1A304A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A04")]
			[Address(RVA = "0x1A304A8", Offset = "0x1A304A8", VA = "0x1A304A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A06")]
			[Address(RVA = "0x1A30588", Offset = "0x1A30588", VA = "0x1A30588", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000105")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C1EC", Offset = "0x59C1EC")]
		private sealed class <WaitABit>d__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x17000370")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A0B")]
				[Address(RVA = "0x1A302B8", Offset = "0x1A302B8", VA = "0x1A302B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000371")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A0D")]
				[Address(RVA = "0x1A30308", Offset = "0x1A30308", VA = "0x1A30308", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A08")]
			[Address(RVA = "0x1A301EC", Offset = "0x1A301EC", VA = "0x1A301EC")]
			[DebuggerHidden]
			public <WaitABit>d__29(int <>1__state)
			{
			}

			[Token(Token = "0x6000A09")]
			[Address(RVA = "0x1A3020C", Offset = "0x1A3020C", VA = "0x1A3020C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0x1A30210", Offset = "0x1A30210", VA = "0x1A30210", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0x1A302C0", Offset = "0x1A302C0", VA = "0x1A302C0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000106")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C1FC", Offset = "0x59C1FC")]
		private struct <RunReturnValueTestAsync>d__30 : IAsyncStateMachine
		{
			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private TaskAwaiter<string> <>u__1;

			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0x1A2F5B8", Offset = "0x1A2F5B8", VA = "0x1A2F5B8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0x1A2F8B8", Offset = "0x1A2F8B8", VA = "0x1A2F8B8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000107")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C20C", Offset = "0x59C20C")]
		private struct <GetValueExampleAsync>d__31 : IAsyncStateMachine
		{
			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder<string> <>t__builder;

			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private object <>u__1;

			[Token(Token = "0x6000A10")]
			[Address(RVA = "0x1A2C034", Offset = "0x1A2C034", VA = "0x1A2C034", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000A11")]
			[Address(RVA = "0x1A2C2DC", Offset = "0x1A2C2DC", VA = "0x1A2C2DC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59C21C", Offset = "0x59C21C")]
		private struct <RunAwaitSecondsTestAsync>d__32 : IAsyncStateMachine
		{
			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private object <>u__1;

			[Token(Token = "0x6000A12")]
			[Address(RVA = "0x1A2D450", Offset = "0x1A2D450", VA = "0x1A2D450", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000A13")]
			[Address(RVA = "0x1A2D768", Offset = "0x1A2D768", VA = "0x1A2D768", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000509")]
		private const string AssetBundleSampleUrl = "http://www.stevevermeulen.com/wp-content/uploads/2017/09/teapot.unity3d";

		[Token(Token = "0x400050A")]
		private const string AssetBundleSampleAssetName = "Teapot";

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private TestButtonHandler.Settings _buttonSettings;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private TestButtonHandler _buttonHandler;

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x132F62C", Offset = "0x132F62C", VA = "0x132F62C")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x132F6A4", Offset = "0x132F6A4", VA = "0x132F6A4")]
		public void OnGUI()
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x1330A60", Offset = "0x1330A60", VA = "0x1330A60")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5A0CC8", Offset = "0x5A0CC8")]
		private IEnumerator RunAsyncFromCoroutineTest()
		{
			return null;
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x1330AE4", Offset = "0x1330AE4", VA = "0x1330AE4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x5A0D34", Offset = "0x5A0D34")]
		private Task RunMultipleThreadsTestAsync()
		{
			return null;
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x1330C24", Offset = "0x1330C24", VA = "0x1330C24")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x5A0DA0", Offset = "0x5A0DA0")]
		private Task RunMultipleThreadsTestAsyncWait()
		{
			return null;
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x1330D68", Offset = "0x1330D68", VA = "0x1330D68")]
		private void PrintCurrentThreadContext([Optional] string prefix)
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x1330F58", Offset = "0x1330F58", VA = "0x1330F58")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x5A0E0C", Offset = "0x5A0E0C")]
		private Task RunAsyncFromCoroutineTest2()
		{
			return null;
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x1330938", Offset = "0x1330938", VA = "0x1330938")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x5A0E78", Offset = "0x5A0E78")]
		private Task RunWwwAsync()
		{
			return null;
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x1330810", Offset = "0x1330810", VA = "0x1330810")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x5A0EE4", Offset = "0x5A0EE4")]
		private Task RunOpenNotepadTestAsync()
		{
			return null;
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x132FF34", Offset = "0x132FF34", VA = "0x132FF34")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x5A0F50", Offset = "0x5A0F50")]
		private Task RunUnhandledExceptionTestAsync()
		{
			return null;
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x132FDF0", Offset = "0x132FDF0", VA = "0x132FDF0")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x5A0FBC", Offset = "0x5A0FBC")]
		private Task RunTryCatchExceptionTestAsync()
		{
			return null;
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x1331080", Offset = "0x1331080", VA = "0x1331080")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x5A1028", Offset = "0x5A1028")]
		private Task NestedRunAsync()
		{
			return null;
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x13311A8", Offset = "0x13311A8", VA = "0x13311A8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x5A1094", Offset = "0x5A1094")]
		private Task WaitThenThrowException()
		{
			return null;
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x13306CC", Offset = "0x13306CC", VA = "0x13306CC")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x5A1100", Offset = "0x5A1100")]
		private Task RunAsyncOperationAsync()
		{
			return null;
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x13312D0", Offset = "0x13312D0", VA = "0x13312D0")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x5A116C", Offset = "0x5A116C")]
		private Task InstantiateAssetBundleAsync(string abUrl, string assetName)
		{
			return null;
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x133143C", Offset = "0x133143C", VA = "0x133143C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x5A11D8", Offset = "0x5A11D8")]
		private Task<byte[]> DownloadRawDataAsync(string url)
		{
			return null;
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x1330588", Offset = "0x1330588", VA = "0x1330588")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x5A1244", Offset = "0x5A1244")]
		private Task RunIEnumeratorTryCatchExceptionAsync()
		{
			return null;
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x1330444", Offset = "0x1330444", VA = "0x1330444")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x5A12B0", Offset = "0x5A12B0")]
		private Task RunIEnumeratorUnhandledExceptionAsync()
		{
			return null;
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x13315B0", Offset = "0x13315B0", VA = "0x13315B0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5A131C", Offset = "0x5A131C")]
		private IEnumerator WaitThenThrow()
		{
			return null;
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x1331634", Offset = "0x1331634", VA = "0x1331634")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5A1388", Offset = "0x5A1388")]
		private IEnumerator WaitThenThrowNested()
		{
			return null;
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x1330300", Offset = "0x1330300", VA = "0x1330300")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x5A13F4", Offset = "0x5A13F4")]
		private Task RunIEnumeratorStringTestAsync()
		{
			return null;
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x13301BC", Offset = "0x13301BC", VA = "0x13301BC")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x5A1460", Offset = "0x5A1460")]
		private Task RunIEnumeratorUntypedStringTestAsync()
		{
			return null;
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x1330078", Offset = "0x1330078", VA = "0x1330078")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x5A14CC", Offset = "0x5A14CC")]
		private Task RunIEnumeratorTestAsync()
		{
			return null;
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x1331698", Offset = "0x1331698", VA = "0x1331698")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5A1538", Offset = "0x5A1538")]
		private IEnumerator<string> WaitForString()
		{
			return null;
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x13316FC", Offset = "0x13316FC", VA = "0x13316FC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5A15A4", Offset = "0x5A15A4")]
		private IEnumerator WaitForStringUntyped()
		{
			return null;
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x1331780", Offset = "0x1331780", VA = "0x1331780")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5A1610", Offset = "0x5A1610")]
		private IEnumerator WaitABit()
		{
			return null;
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x132FCAC", Offset = "0x132FCAC", VA = "0x132FCAC")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x5A167C", Offset = "0x5A167C")]
		private Task RunReturnValueTestAsync()
		{
			return null;
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x13317E4", Offset = "0x13317E4", VA = "0x13317E4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x5A16E8", Offset = "0x5A16E8")]
		private Task<string> GetValueExampleAsync()
		{
			return null;
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x132FB84", Offset = "0x132FB84", VA = "0x132FB84")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x5A1754", Offset = "0x5A1754")]
		private Task RunAwaitSecondsTestAsync()
		{
			return null;
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x1331944", Offset = "0x1331944", VA = "0x1331944")]
		public AsyncUtilTests()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class TestButtonHandler
	{
		[Serializable]
		[Token(Token = "0x2000109")]
		public class Settings
		{
			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int NumPerColumn;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float VerticalMargin;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float VerticalSpacing;

			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float HorizontalSpacing;

			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float HorizontalMargin;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float ButtonWidth;

			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float ButtonHeight;

			[Token(Token = "0x6000A14")]
			[Address(RVA = "0x239AD98", Offset = "0x239AD98", VA = "0x239AD98")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly Settings _settings;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private int _buttonVCount;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _buttonHCount;

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x1A178C0", Offset = "0x1A178C0", VA = "0x1A178C0")]
		public TestButtonHandler(Settings settings)
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x1A178EC", Offset = "0x1A178EC", VA = "0x1A178EC")]
		public void Restart()
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x1A178FC", Offset = "0x1A178FC", VA = "0x1A178FC")]
		public bool Display(string text)
		{
			return default(bool);
		}
	}
}
