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
[AttributeAttribute(Name = "RequireComponent", RVA = "0xBB0AD0", Offset = "0xBB0AD0")]
public class CFX_AutoDestructShuriken : MonoBehaviour
{
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB191C", Offset = "0xBB191C")]
	private sealed class <CheckIfAlive>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CFX_AutoDestructShuriken <>4__this;

		[Token(Token = "0x17000310")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600088B")]
			[Address(RVA = "0x26A480C", Offset = "0x26A480C", VA = "0x26A480C", Slot = "4")]
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
			[Address(RVA = "0x26A4854", Offset = "0x26A4854", VA = "0x26A4854", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x26A468C", Offset = "0x26A468C", VA = "0x26A468C")]
		[DebuggerHidden]
		public <CheckIfAlive>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x26A46B8", Offset = "0x26A46B8", VA = "0x26A46B8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x26A46BC", Offset = "0x26A46BC", VA = "0x26A46BC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x26A4814", Offset = "0x26A4814", VA = "0x26A4814", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool OnlyDeactivate;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x19BADA0", Offset = "0x19BADA0", VA = "0x19BADA0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x19BADF0", Offset = "0x19BADF0", VA = "0x19BADF0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBB6638", Offset = "0xBB6638")]
	private IEnumerator CheckIfAlive()
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x19BAE68", Offset = "0x19BAE68", VA = "0x19BAE68")]
	public CFX_AutoDestructShuriken()
	{
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xBB0B30", Offset = "0xBB0B30")]
public class CFX_LightIntensityFade : MonoBehaviour
{
	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float duration;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float delay;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float finalIntensity;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float baseIntensity;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool autodestruct;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float p_lifetime;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float p_delay;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x19BAE70", Offset = "0x19BAE70", VA = "0x19BAE70")]
	private void Start()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x19BAED4", Offset = "0x19BAED4", VA = "0x19BAED4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x19BAF54", Offset = "0x19BAF54", VA = "0x19BAF54")]
	private void Update()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x19BB0C0", Offset = "0x19BB0C0", VA = "0x19BB0C0")]
	public CFX_LightIntensityFade()
	{
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xBB0B90", Offset = "0xBB0B90")]
public class WFX_BulletHoleDecal : MonoBehaviour
{
	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB192C", Offset = "0xBB192C")]
	private sealed class <holeUpdate>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WFX_BulletHoleDecal <>4__this;

		[Token(Token = "0x17000312")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000891")]
			[Address(RVA = "0x26AF838", Offset = "0x26AF838", VA = "0x26AF838", Slot = "4")]
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
			[Address(RVA = "0x26AF880", Offset = "0x26AF880", VA = "0x26AF880", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0x26AF6F8", Offset = "0x26AF6F8", VA = "0x26AF6F8")]
		[DebuggerHidden]
		public <holeUpdate>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x26AF724", Offset = "0x26AF724", VA = "0x26AF724", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x26AF728", Offset = "0x26AF728", VA = "0x26AF728", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x26AF840", Offset = "0x26AF840", VA = "0x26AF840", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Vector2[] quadUVs;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float lifetime;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float fadeoutpercent;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector2 frames;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool randomRotation;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool deactivate;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float life;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float fadeout;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Color color;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float orgAlpha;

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1FB2FD4", Offset = "0x1FB2FD4", VA = "0x1FB2FD4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1FB3064", Offset = "0x1FB3064", VA = "0x1FB3064")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1FB3364", Offset = "0x1FB3364", VA = "0x1FB3364")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBB6698", Offset = "0xBB6698")]
	private IEnumerator holeUpdate()
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1FB33DC", Offset = "0x1FB33DC", VA = "0x1FB33DC")]
	public WFX_BulletHoleDecal()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xBB0BF0", Offset = "0xBB0BF0")]
public class WFX_LightFlicker : MonoBehaviour
{
	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB193C", Offset = "0xBB193C")]
	private sealed class <Flicker>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WFX_LightFlicker <>4__this;

		[Token(Token = "0x17000314")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000897")]
			[Address(RVA = "0x26AF9C8", Offset = "0x26AF9C8", VA = "0x26AF9C8", Slot = "4")]
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
			[Address(RVA = "0x26AFA10", Offset = "0x26AFA10", VA = "0x26AFA10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x26AF888", Offset = "0x26AF888", VA = "0x26AF888")]
		[DebuggerHidden]
		public <Flicker>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x26AF8B4", Offset = "0x26AF8B4", VA = "0x26AF8B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x26AF8B8", Offset = "0x26AF8B8", VA = "0x26AF8B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x26AF9D0", Offset = "0x26AF9D0", VA = "0x26AF9D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float time;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float timer;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1FB34B8", Offset = "0x1FB34B8", VA = "0x1FB34B8")]
	private void Start()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1FB3510", Offset = "0x1FB3510", VA = "0x1FB3510")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBB66F8", Offset = "0xBB66F8")]
	private IEnumerator Flicker()
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1FB3588", Offset = "0x1FB3588", VA = "0x1FB3588")]
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
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] objectsToPreload;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int[] objectsToPreloadTimes;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool hideObjectsInHierarchy;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool spawnAsChildren;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool onlyGetInactiveObjects;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	public bool instantiateIfNeeded;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool allObjectsLoaded;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<int, List<GameObject>> instantiatedObjects;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<int, int> poolCursors;

	[Token(Token = "0x17000001")]
	public static bool AllObjectsLoaded
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x19BC0B0", Offset = "0x19BC0B0", VA = "0x19BC0B0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x19BB0D0", Offset = "0x19BB0D0", VA = "0x19BB0D0")]
	public static GameObject GetNextObject(GameObject sourceObj, bool activateObject = true)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x19BB8B8", Offset = "0x19BB8B8", VA = "0x19BB8B8")]
	public static void PreloadObject(GameObject sourceObj, int poolSize = 1)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x19BBC40", Offset = "0x19BBC40", VA = "0x19BBC40")]
	public static void UnloadObjects(GameObject sourceObj)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x19BB924", Offset = "0x19BB924", VA = "0x19BB924")]
	private void addObjectToPool(GameObject sourceObject, int number)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x19BBC9C", Offset = "0x19BBC9C", VA = "0x19BBC9C")]
	private void removeObjectsFromPool(GameObject sourceObject)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x19BB748", Offset = "0x19BB748", VA = "0x19BB748")]
	private void increasePoolCursor(int uniqueId)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x19BC108", Offset = "0x19BC108", VA = "0x19BC108")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x19BC214", Offset = "0x19BC214", VA = "0x19BC214")]
	private void Start()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x19BC2A0", Offset = "0x19BC2A0", VA = "0x19BC2A0")]
	public CFX_SpawnSystem()
	{
	}
}
[Token(Token = "0x2000007")]
public class DirectionPointer : MonoBehaviour
{
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x19C0CA4", Offset = "0x19C0CA4", VA = "0x19C0CA4")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x19C0D84", Offset = "0x19C0D84", VA = "0x19C0D84")]
	public DirectionPointer()
	{
	}
}
[Token(Token = "0x2000008")]
[ExecuteInEditMode]
public class Generator : MonoBehaviour
{
	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector2Int castRows;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float shaftSpacing;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool meshCast;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Mesh castMesh;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject lightShaftPrefab;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string savePath;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool shaftSettings;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material shaftMat;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0xBB1B6C", Offset = "0xBB1B6C")]
	public Color pointer_shaftColor;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float pointer_shaftIntensity;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public Vector2 pointer_noiseDirection;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float pointer_noiseScale;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float pointer_noiseUpdateSpeed;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float pointer_maxLength;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public LayerMask pointer_layerMask;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float pointer_shaftWidth;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Vector2 pointer_shaftWidthMinMax;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Texture pointer_shaftTexture;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Transform pointer_shaftDirection;

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x19C75A0", Offset = "0x19C75A0", VA = "0x19C75A0")]
	public Generator()
	{
	}
}
[Serializable]
[Token(Token = "0x2000009")]
public class SaveVariables
{
	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float pointer_shaftIntensity;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float pointer_shaftColorR;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float pointer_shaftColorG;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float pointer_shaftColorB;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float pointer_shaftColorA;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float pointer_noiseDirectionX;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float pointer_noiseDirectionY;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float pointer_noiseScale;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float pointer_noiseUpdateSpeed;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float pointer_maxLength;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float pointer_shaftWidth;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float pointer_shaftWidthMinMaxX;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float pointer_shaftWidthMinMaxY;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float pointer_shaftDirectionX;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float pointer_shaftDirectionY;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float pointer_shaftDirectionZ;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int castRowsX;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int castRowsY;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float shaftSpacing;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public bool meshCast;

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x26FAE28", Offset = "0x26FAE28", VA = "0x26FAE28")]
	public SaveVariables()
	{
	}
}
[Token(Token = "0x200000A")]
public class Shaft_Behavior : MonoBehaviour
{
	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color shaftColor;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float shaftIntensity;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Vector2 noiseDirection;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float noiseScale;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float noiseUpdateSpeed;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float maxLength;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LayerMask layerMask;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector2 shaftWidthMinMax;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float shaftAdjustY;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Texture shaftTexture;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform shaftDirection;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material shaftMat;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float randomRotZ;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float randomWidth;

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x26FB624", Offset = "0x26FB624", VA = "0x26FB624")]
	private void Start()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x26FBD30", Offset = "0x26FBD30", VA = "0x26FBD30")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x26FBA54", Offset = "0x26FBA54", VA = "0x26FBA54")]
	private void ShaftLength_and_Width()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x26FBBF0", Offset = "0x26FBBF0", VA = "0x26FBBF0")]
	private void Shaft_Color_Intensity_TexOffset()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x26FB918", Offset = "0x26FB918", VA = "0x26FB918")]
	private void OrientShaft()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x26FB7C0", Offset = "0x26FB7C0", VA = "0x26FB7C0")]
	private void SyncVariables()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x26FBD64", Offset = "0x26FBD64", VA = "0x26FBD64")]
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
		[Address(RVA = "0x26F2A1C", Offset = "0x26F2A1C", VA = "0x26F2A1C")]
		get
		{
			return default(RenderPipeline);
		}
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x26F2B50", Offset = "0x26F2B50", VA = "0x26F2B50")]
	public static bool IsUsingCustomRenderPipeline()
	{
		return default(bool);
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x26F2C48", Offset = "0x26F2C48", VA = "0x26F2C48")]
	public static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x26F2CCC", Offset = "0x26F2CCC", VA = "0x26F2CCC")]
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
			[Address(RVA = "0x19B7040", Offset = "0x19B7040", VA = "0x19B7040")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x19B7198", Offset = "0x19B7198", VA = "0x19B7198")]
		public static bool IsGpuInstancingEnabled(Material material)
		{
			return default(bool);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x19B71B0", Offset = "0x19B71B0", VA = "0x19B71B0")]
		public static void SetMaterialProperties(Material material, bool enableGpuInstancing)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x19B71CC", Offset = "0x19B71CC", VA = "0x19B71CC")]
		public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x19B756C", Offset = "0x19B756C", VA = "0x19B756C")]
		public static bool CanBeBatched(VolumetricLightBeam beam, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x19B76F4", Offset = "0x19B76F4", VA = "0x19B76F4")]
		private static void AppendErrorMessage(ref string message, string toAppend)
		{
		}
	}
	[Token(Token = "0x200000E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB0C60", Offset = "0xBB0C60")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBB0C60", Offset = "0xBB0C60")]
	public class BeamGeometry : MonoBehaviour, MaterialModifier.Interface
	{
		[Token(Token = "0x200008D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB194C", Offset = "0xBB194C")]
		private sealed class <CoUpdateFadeOut>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BeamGeometry <>4__this;

			[Token(Token = "0x17000316")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008A6")]
				[Address(RVA = "0x26A463C", Offset = "0x26A463C", VA = "0x26A463C", Slot = "4")]
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
				[Address(RVA = "0x26A4684", Offset = "0x26A4684", VA = "0x26A4684", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x26A4570", Offset = "0x26A4570", VA = "0x26A4570")]
			[DebuggerHidden]
			public <CoUpdateFadeOut>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x26A459C", Offset = "0x26A459C", VA = "0x26A459C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x26A45A0", Offset = "0x26A45A0", VA = "0x26A45A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x26A4644", Offset = "0x26A4644", VA = "0x26A4644", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Matrix4x4 m_ColorGradientMatrix;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MeshType m_CurrentMeshType;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_CustomMaterial;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private MaterialModifier.Callback m_MaterialModifierCallback;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Coroutine m_CoFadeOut;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB1B84", Offset = "0xBB1B84")]
		private MeshRenderer <meshRenderer>k__BackingField;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB1B94", Offset = "0xBB1B94")]
		private MeshFilter <meshFilter>k__BackingField;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB1BA4", Offset = "0xBB1BA4")]
		private Mesh <coneMesh>k__BackingField;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Camera m_CurrentCameraRenderingSRP;

		[Token(Token = "0x17000004")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x19B77C0", Offset = "0x19B77C0", VA = "0x19B77C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6758", Offset = "0xBB6758")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x19B77C8", Offset = "0x19B77C8", VA = "0x19B77C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6768", Offset = "0xBB6768")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x19B77D0", Offset = "0x19B77D0", VA = "0x19B77D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6778", Offset = "0xBB6778")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x19B77D8", Offset = "0x19B77D8", VA = "0x19B77D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6788", Offset = "0xBB6788")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public Mesh coneMesh
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x19B77E0", Offset = "0x19B77E0", VA = "0x19B77E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6798", Offset = "0xBB6798")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x19B77E8", Offset = "0x19B77E8", VA = "0x19B77E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB67A8", Offset = "0xBB67A8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public bool visible
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x19B77F0", Offset = "0x19B77F0", VA = "0x19B77F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x19B780C", Offset = "0x19B780C", VA = "0x19B780C")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public int sortingLayerID
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x19B782C", Offset = "0x19B782C", VA = "0x19B782C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x19B7848", Offset = "0x19B7848", VA = "0x19B7848")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public int sortingOrder
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x19B7864", Offset = "0x19B7864", VA = "0x19B7864")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x19B7880", Offset = "0x19B7880", VA = "0x19B7880")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public bool _INTERNAL_IsFadeOutCoroutineRunning
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x19B789C", Offset = "0x19B789C", VA = "0x19B789C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public static bool isCustomRenderPipelineSupported
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x19B81B0", Offset = "0x19B81B0", VA = "0x19B81B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000C")]
		private bool shouldUseGPUInstancedMaterial
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x19B81B8", Offset = "0x19B81B8", VA = "0x19B81B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000D")]
		private bool isNoiseEnabled
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x19B9E94", Offset = "0x19B9E94", VA = "0x19B9E94")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000E")]
		private bool isDepthBlendEnabled
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x19B9F30", Offset = "0x19B9F30", VA = "0x19B9F30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x19B78AC", Offset = "0x19B78AC", VA = "0x19B78AC")]
		private float ComputeFadeOutFactor(Transform camTransform)
		{
			return default(float);
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x19B7994", Offset = "0x19B7994", VA = "0x19B7994")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBB67B8", Offset = "0xBB67B8")]
		private IEnumerator CoUpdateFadeOut()
		{
			return null;
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x19B7A0C", Offset = "0x19B7A0C", VA = "0x19B7A0C")]
		private void ComputeFadeOutFactor()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x19B7B54", Offset = "0x19B7B54", VA = "0x19B7B54")]
		private void SetFadeOutFactorProp(float value)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x19B7EAC", Offset = "0x19B7EAC", VA = "0x19B7EAC")]
		public void RestartFadeOutCoroutine()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x19B7F98", Offset = "0x19B7F98", VA = "0x19B7F98")]
		private void Start()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x19B8054", Offset = "0x19B8054", VA = "0x19B8054")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x19B8110", Offset = "0x19B8110", VA = "0x19B8110")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x19B8248", Offset = "0x19B8248", VA = "0x19B8248")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x19B82E0", Offset = "0x19B82E0", VA = "0x19B82E0")]
		public void Initialize(VolumetricLightBeam master)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x19B8A70", Offset = "0x19B8A70", VA = "0x19B8A70")]
		public void RegenerateMesh()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x19B9DE8", Offset = "0x19B9DE8", VA = "0x19B9DE8")]
		private void ComputeLocalMatrix()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x19B8880", Offset = "0x19B8880", VA = "0x19B8880")]
		private bool ApplyMaterial()
		{
			return default(bool);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x19B7CE4", Offset = "0x19B7CE4", VA = "0x19B7CE4", Slot = "4")]
		public void SetMaterialProp(int nameID, float value)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x19BA22C", Offset = "0x19BA22C", VA = "0x19BA22C", Slot = "5")]
		public void SetMaterialProp(int nameID, Vector4 value)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x19BA358", Offset = "0x19BA358", VA = "0x19BA358", Slot = "6")]
		public void SetMaterialProp(int nameID, Color value)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x19BA484", Offset = "0x19BA484", VA = "0x19BA484", Slot = "7")]
		public void SetMaterialProp(int nameID, Matrix4x4 value)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x19BA5B8", Offset = "0x19BA5B8", VA = "0x19BA5B8", Slot = "8")]
		public void SetMaterialProp(int nameID, Texture value)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x19B7C18", Offset = "0x19B7C18", VA = "0x19B7C18")]
		private void MaterialChangeStart()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x19B7DE0", Offset = "0x19B7DE0", VA = "0x19B7DE0")]
		private void MaterialChangeStop()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x19BA6A8", Offset = "0x19BA6A8", VA = "0x19BA6A8")]
		public void SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x19B9848", Offset = "0x19B9848", VA = "0x19B9848")]
		public void UpdateMaterialAndBounds()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x19BA7B8", Offset = "0x19BA7B8", VA = "0x19BA7B8")]
		private void UpdateMatricesPropertiesForGPUInstancingSRP()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x19BA904", Offset = "0x19BA904", VA = "0x19BA904")]
		private void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x19BA910", Offset = "0x19BA910", VA = "0x19BA910")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x19BA950", Offset = "0x19BA950", VA = "0x19BA950")]
		private void OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x19BAA38", Offset = "0x19BAA38", VA = "0x19BAA38")]
		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x19BAD74", Offset = "0x19BAD74", VA = "0x19BAD74")]
		public BeamGeometry()
		{
		}
	}
	[Token(Token = "0x200000F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBB0CD0", Offset = "0xBB0CD0")]
	public class Config : ScriptableObject
	{
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool geometryOverrideLayer;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int geometryLayerID;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string geometryTag;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int geometryRenderQueue;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBB1BB4", Offset = "0xBB1BB4")]
		[SerializeField]
		private RenderPipeline _RenderPipeline;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBB1C00", Offset = "0xBB1C00")]
		[SerializeField]
		private RenderingMode _RenderingMode;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int sharedMeshSides;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int sharedMeshSegments;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBB1C4C", Offset = "0xBB1C4C")]
		public float globalNoiseScale;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 globalNoiseVelocity;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string fadeOutCameraTag;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HighlightNull]
		public TextAsset noise3DData;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int noise3DSize;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HighlightNull]
		public ParticleSystem dustParticlesPrefab;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Material _DummyMaterial;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Shader _BeamShader;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform m_CachedFadeOutCamera;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Config m_Instance;

		[Token(Token = "0x1700000F")]
		public RenderPipeline renderPipeline
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x19BF20C", Offset = "0x19BF20C", VA = "0x19BF20C")]
			get
			{
				return default(RenderPipeline);
			}
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x19BF214", Offset = "0x19BF214", VA = "0x19BF214")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public RenderingMode renderingMode
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x19BF288", Offset = "0x19BF288", VA = "0x19BF288")]
			get
			{
				return default(RenderingMode);
			}
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x19BF290", Offset = "0x19BF290", VA = "0x19BF290")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public RenderingMode actualRenderingMode
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x19B7140", Offset = "0x19B7140", VA = "0x19B7140")]
			get
			{
				return default(RenderingMode);
			}
		}

		[Token(Token = "0x17000012")]
		public bool useSinglePassShader
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x19B8DAC", Offset = "0x19B8DAC", VA = "0x19B8DAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000013")]
		public Shader beamShader
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x19BF334", Offset = "0x19BF334", VA = "0x19BF334")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		public Vector4 globalNoiseParam
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x19BF33C", Offset = "0x19BF33C", VA = "0x19BF33C")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x17000015")]
		public Transform fadeOutCameraTransform
		{
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x19B7AD4", Offset = "0x19B7AD4", VA = "0x19B7AD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public static Config Instance
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x19B70E4", Offset = "0x19B70E4", VA = "0x19B70E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x19BF304", Offset = "0x19BF304", VA = "0x19BF304")]
		public bool IsSRPBatcherSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x19BF374", Offset = "0x19BF374", VA = "0x19BF374")]
		public void ForceUpdateFadeOutCamera()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x19BF420", Offset = "0x19BF420", VA = "0x19BF420")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xBB6818", Offset = "0xBB6818")]
		private static void OnStartup()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x19BF48C", Offset = "0x19BF48C", VA = "0x19BF48C")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x19BF558", Offset = "0x19BF558", VA = "0x19BF558")]
		public void ResetInternalData()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x19BF6BC", Offset = "0x19BF6BC", VA = "0x19BF6BC")]
		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x19BF888", Offset = "0x19BF888", VA = "0x19BF888")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x19BF894", Offset = "0x19BF894", VA = "0x19BF894")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x19BF898", Offset = "0x19BF898", VA = "0x19BF898")]
		private static Config GetInstance(bool assertIfNotFound)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x19BF9FC", Offset = "0x19BF9FC", VA = "0x19BF9FC")]
		public Config()
		{
		}
	}
	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBB0D08", Offset = "0xBB0D08")]
	public class ConfigOverride : Config
	{
		[Token(Token = "0x4000072")]
		public const string kAssetName = "VLBConfigOverride";

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x19BFB00", Offset = "0x19BFB00", VA = "0x19BFB00")]
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
			[Address(RVA = "0x19B86A4", Offset = "0x19B86A4", VA = "0x19B86A4")]
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
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB0D40", Offset = "0xBB0D40")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBB0D40", Offset = "0xBB0D40")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DynamicOcclusionUpdateRate updateRate;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBB1CB8", Offset = "0xBB1CB8")]
		public int waitXFrames;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool _INTERNAL_ApplyRandomFrameOffset;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TransformUtils.Packed m_TransformPacked;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_LastFrameRendered;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected VolumetricLightBeam m_Master;

		[Token(Token = "0x17000018")]
		public int _INTERNAL_LastFrameRendered
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x19C122C", Offset = "0x19C122C", VA = "0x19C122C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000001")]
		public event Action onOcclusionProcessed
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x19C10EC", Offset = "0x19C10EC", VA = "0x19C10EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6828", Offset = "0xBB6828")]
			add
			{
			}
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x19C118C", Offset = "0x19C118C", VA = "0x19C118C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6838", Offset = "0xBB6838")]
			remove
			{
			}
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x19C0ED4", Offset = "0x19C0ED4", VA = "0x19C0ED4")]
		public void ProcessOcclusionManually()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x19C0EDC", Offset = "0x19C0EDC", VA = "0x19C0EDC")]
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
		[Address(RVA = "0x19C1234", Offset = "0x19C1234", VA = "0x19C1234", Slot = "9")]
		protected virtual void OnValidateProperties()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x19C1268", Offset = "0x19C1268", VA = "0x19C1268", Slot = "10")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x19C12E8", Offset = "0x19C12E8", VA = "0x19C12E8", Slot = "11")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x19C1344", Offset = "0x19C1344", VA = "0x19C1344", Slot = "12")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x19C14B0", Offset = "0x19C14B0", VA = "0x19C14B0", Slot = "13")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x19C154C", Offset = "0x19C154C", VA = "0x19C154C")]
		private void OnWillCameraRender(Camera cam)
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x19C1304", Offset = "0x19C1304", VA = "0x19C1304")]
		private void DisableOcclusion()
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x19C16D4", Offset = "0x19C16D4", VA = "0x19C16D4")]
		protected DynamicOcclusionAbstractBase()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x19C1740", Offset = "0x19C1740", VA = "0x19C1740")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6848", Offset = "0xBB6848")]
		private void <OnEnable>b__22_0()
		{
		}
	}
	[Token(Token = "0x2000014")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBB0DD4", Offset = "0xBB0DD4")]
	public class DynamicOcclusionDepthBuffer : DynamicOcclusionAbstractBase
	{
		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public LayerMask layerMask;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useOcclusionCulling;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int depthMapResolution;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float fadeDistanceToSurface;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Camera m_DepthCamera;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_NeedToUpdateOcclusionNextFrame;

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x19C1748", Offset = "0x19C1748", VA = "0x19C1748", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x19C178C", Offset = "0x19C178C", VA = "0x19C178C", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x19C1794", Offset = "0x19C1794", VA = "0x19C1794")]
		private void ProcessOcclusionInternal()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x19C1958", Offset = "0x19C1958", VA = "0x19C1958", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x19C199C", Offset = "0x19C199C", VA = "0x19C199C")]
		private void Update()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x19C17C4", Offset = "0x19C17C4", VA = "0x19C17C4")]
		private void UpdateDepthCameraPropertiesAccordingToBeam()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x19C1A54", Offset = "0x19C1A54", VA = "0x19C1A54")]
		public bool HasLayerMaskIssues()
		{
			return default(bool);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x19C1B0C", Offset = "0x19C1B0C", VA = "0x19C1B0C", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x19C1B78", Offset = "0x19C1B78", VA = "0x19C1B78")]
		private void InstantiateOrActivateDepthCamera()
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x19C1E74", Offset = "0x19C1E74", VA = "0x19C1E74", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x19C1E78", Offset = "0x19C1E78", VA = "0x19C1E78", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x19C1F1C", Offset = "0x19C1F1C", VA = "0x19C1F1C", Slot = "10")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x19C1F20", Offset = "0x19C1F20", VA = "0x19C1F20", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x19C1F44", Offset = "0x19C1F44", VA = "0x19C1F44")]
		private void DestroyDepthCamera()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x19C20C4", Offset = "0x19C20C4", VA = "0x19C20C4", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x19C225C", Offset = "0x19C225C", VA = "0x19C225C")]
		public DynamicOcclusionDepthBuffer()
		{
		}
	}
	[Token(Token = "0x2000015")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBB0E20", Offset = "0xBB0E20")]
	public class DynamicOcclusionRaycasting : DynamicOcclusionAbstractBase
	{
		[Token(Token = "0x200008F")]
		public class HitResult
		{
			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 normal;

			[Token(Token = "0x400052A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x400052B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Collider2D collider2D;

			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Collider collider3D;

			[Token(Token = "0x17000318")]
			public bool hasCollider
			{
				[Token(Token = "0x60008AC")]
				[Address(RVA = "0x26A4C70", Offset = "0x26A4C70", VA = "0x26A4C70")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000319")]
			public string name
			{
				[Token(Token = "0x60008AD")]
				[Address(RVA = "0x26A4D20", Offset = "0x26A4D20", VA = "0x26A4D20")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700031A")]
			public Bounds bounds
			{
				[Token(Token = "0x60008AE")]
				[Address(RVA = "0x26A4E04", Offset = "0x26A4E04", VA = "0x26A4E04")]
				get
				{
					return default(Bounds);
				}
			}

			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x26A4AFC", Offset = "0x26A4AFC", VA = "0x26A4AFC")]
			public HitResult(RaycastHit hit3D)
			{
			}

			[Token(Token = "0x60008AA")]
			[Address(RVA = "0x26A4B84", Offset = "0x26A4B84", VA = "0x26A4B84")]
			public HitResult(RaycastHit2D hit2D)
			{
			}

			[Token(Token = "0x60008AB")]
			[Address(RVA = "0x26A4C0C", Offset = "0x26A4C0C", VA = "0x26A4C0C")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Dimensions dimensions;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public LayerMask layerMask;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool considerTriggers;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float minOccluderArea;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float minSurfaceRatio;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float maxSurfaceDot;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public PlaneAlignment planeAlignment;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float planeOffset;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBB1D00", Offset = "0xBB1D00")]
		public float fadeDistanceToSurface;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB1D38", Offset = "0xBB1D38")]
		private HitResult <currentHit>k__BackingField;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_RangeMultiplier;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB1D48", Offset = "0xBB1D48")]
		private Plane <planeEquationWS>k__BackingField;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private uint m_PrevNonSubHitDirectionId;

		[Token(Token = "0x17000019")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBB7CC0", Offset = "0xBB7CC0")]
		public float fadeDistanceToPlane
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x19C2324", Offset = "0x19C2324", VA = "0x19C2324")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x19C232C", Offset = "0x19C232C", VA = "0x19C232C")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public HitResult currentHit
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x19C2464", Offset = "0x19C2464", VA = "0x19C2464")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6858", Offset = "0xBB6858")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x19C246C", Offset = "0x19C246C", VA = "0x19C246C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6868", Offset = "0xBB6868")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public Plane planeEquationWS
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x19C24C0", Offset = "0x19C24C0", VA = "0x19C24C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6878", Offset = "0xBB6878")]
			get
			{
				return default(Plane);
			}
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x19C24CC", Offset = "0x19C24CC", VA = "0x19C24CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6888", Offset = "0xBB6888")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		private QueryTriggerInteraction queryTriggerInteraction
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x19C2788", Offset = "0x19C2788", VA = "0x19C2788")]
			get
			{
				return default(QueryTriggerInteraction);
			}
		}

		[Token(Token = "0x1700001D")]
		private float raycastMaxDistance
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x19C279C", Offset = "0x19C279C", VA = "0x19C279C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x19C2334", Offset = "0x19C2334", VA = "0x19C2334")]
		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x19C2474", Offset = "0x19C2474", VA = "0x19C2474", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x19C24B8", Offset = "0x19C24B8", VA = "0x19C24B8", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x19C24D8", Offset = "0x19C24D8", VA = "0x19C24D8", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x19C2538", Offset = "0x19C2538", VA = "0x19C2538", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x19C2544", Offset = "0x19C2544", VA = "0x19C2544", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x19C2624", Offset = "0x19C2624", VA = "0x19C2624")]
		private void Start()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x19C26E0", Offset = "0x19C26E0", VA = "0x19C26E0")]
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x19C27DC", Offset = "0x19C27DC", VA = "0x19C27DC")]
		private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x19C27F0", Offset = "0x19C27F0", VA = "0x19C27F0")]
		private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x19C2AF8", Offset = "0x19C2AF8", VA = "0x19C2AF8")]
		private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x19C2E40", Offset = "0x19C2E40", VA = "0x19C2E40")]
		private uint GetDirectionCount()
		{
			return default(uint);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x19C2E58", Offset = "0x19C2E58", VA = "0x19C2E58")]
		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x19C2EF0", Offset = "0x19C2EF0", VA = "0x19C2EF0")]
		private bool IsHitValid(HitResult hit)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x19C2F78", Offset = "0x19C2F78", VA = "0x19C2F78", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x19C2578", Offset = "0x19C2578", VA = "0x19C2578")]
		private void SetHit(HitResult hit)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x19C3404", Offset = "0x19C3404", VA = "0x19C3404", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x19C32A4", Offset = "0x19C32A4", VA = "0x19C32A4")]
		private void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x19C325C", Offset = "0x19C325C", VA = "0x19C325C")]
		private void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x19C3610", Offset = "0x19C3610", VA = "0x19C3610")]
		private void SetPlaneWS(Plane planeWS)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x19C361C", Offset = "0x19C361C", VA = "0x19C361C")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool ms_DoubleSided;

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x19B960C", Offset = "0x19B960C", VA = "0x19B960C")]
		public static Mesh Get()
		{
			return null;
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x19C7654", Offset = "0x19C7654", VA = "0x19C7654")]
		public static void Destroy()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x19C9374", Offset = "0x19C9374", VA = "0x19C9374")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public BlendingMode blendingMode;

			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Noise3D noise3D;

			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DepthBlend depthBlend;

			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public ColorGradient colorGradient;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DynamicOcclusion dynamicOcclusion;

			[Token(Token = "0x1700031B")]
			public int materialID
			{
				[Token(Token = "0x60008AF")]
				[Address(RVA = "0x26A5130", Offset = "0x26A5130", VA = "0x26A5130")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x26A5158", Offset = "0x26A5158", VA = "0x26A5158")]
			public void ApplyToMaterial(Material mat)
			{
			}

			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x26A541C", Offset = "0x26A541C", VA = "0x26A541C")]
			public StaticProperties()
			{
			}
		}

		[Token(Token = "0x2000097")]
		private class MaterialsGroup
		{
			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material[] materials;

			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x26A5094", Offset = "0x26A5094", VA = "0x26A5094")]
			public MaterialsGroup()
			{
			}
		}

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static MaterialPropertyBlock materialPropertyBlock;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly BlendMode[] BlendingMode_SrcFactor;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly BlendMode[] BlendingMode_DstFactor;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly bool[] BlendingMode_AlphaAsBlack;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static int kStaticPropertiesCount;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Hashtable ms_MaterialsGroup;

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x19B8714", Offset = "0x19B8714", VA = "0x19B8714")]
		public static Material NewMaterialTransient(bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x19C9CD4", Offset = "0x19C9CD4", VA = "0x19C9CD4")]
		public static Material NewMaterialPersistent(Shader shader, bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x19B9F74", Offset = "0x19B9F74", VA = "0x19B9F74")]
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
		[Address(RVA = "0x19CC0A0", Offset = "0x19CC0A0", VA = "0x19CC0A0")]
		private static float GetAngleOffset(int numSides)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x19CC0B8", Offset = "0x19CC0B8", VA = "0x19CC0B8")]
		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x19CC12C", Offset = "0x19CC12C", VA = "0x19CC12C")]
		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x19B8DC8", Offset = "0x19B8DC8", VA = "0x19B8DC8")]
		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x19CC19C", Offset = "0x19CC19C", VA = "0x19CC19C")]
		public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x19CC1B8", Offset = "0x19CC1B8", VA = "0x19CC1B8")]
		public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x19CC1E0", Offset = "0x19CC1E0", VA = "0x19CC1E0")]
		public static int GetSharedMeshVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x19CC278", Offset = "0x19CC278", VA = "0x19CC278")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Texture3D ms_NoiseTexture;

		[Token(Token = "0x4000113")]
		private const HideFlags kHideFlags = HideFlags.HideAndDontSave;

		[Token(Token = "0x4000114")]
		private const int kMinShaderLevel = 35;

		[Token(Token = "0x1700001E")]
		public static bool isSupported
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x2101D94", Offset = "0x2101D94", VA = "0x2101D94")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001F")]
		public static bool isProperlyLoaded
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x2101F94", Offset = "0x2101F94", VA = "0x2101F94")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		public static string isNotSupportedString
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x2101EEC", Offset = "0x2101EEC", VA = "0x2101EEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2102034", Offset = "0x2102034", VA = "0x2102034")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xBB6898", Offset = "0xBB6898")]
		private static void OnStartUp()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x210208C", Offset = "0x210208C", VA = "0x210208C")]
		public static void LoadIfNeeded()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x21022F8", Offset = "0x21022F8", VA = "0x21022F8")]
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
			[Address(RVA = "0x26A7790", Offset = "0x26A7790", VA = "0x26A7790")]
			public float Distance(Vector2 point)
			{
				return default(float);
			}

			[Token(Token = "0x60008B4")]
			[Address(RVA = "0x26A77AC", Offset = "0x26A77AC", VA = "0x26A77AC")]
			public Vector2 ClosestPoint(Vector2 pt)
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008B5")]
			[Address(RVA = "0x26A77D8", Offset = "0x26A77D8", VA = "0x26A77D8")]
			public Vector2 Intersect(Vector2 p1, Vector2 p2)
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x26A78D0", Offset = "0x26A78D0", VA = "0x26A78D0")]
			public bool GetSide(Vector2 point)
			{
				return default(bool);
			}

			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x26A78F4", Offset = "0x26A78F4", VA = "0x26A78F4")]
			public static Plane2D FromPoints(Vector3 p1, Vector3 p2)
			{
				return default(Plane2D);
			}

			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x26A7954", Offset = "0x26A7954", VA = "0x26A7954")]
			public static Plane2D FromNormalAndPoint(Vector3 normalizedNormal, Vector3 p1)
			{
				return default(Plane2D);
			}

			[Token(Token = "0x60008B9")]
			[Address(RVA = "0x26A7964", Offset = "0x26A7964", VA = "0x26A7964")]
			public void Flip()
			{
			}

			[Token(Token = "0x60008BA")]
			[Address(RVA = "0x26A7980", Offset = "0x26A7980", VA = "0x26A7980")]
			public Vector2[] CutConvex(Vector2[] poly)
			{
				return null;
			}

			[Token(Token = "0x60008BB")]
			[Address(RVA = "0x26A7B6C", Offset = "0x26A7B6C", VA = "0x26A7B6C", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x210ABFC", Offset = "0x210ABFC", VA = "0x210ABFC")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 position;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion rotation;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 lossyScale;

			[Token(Token = "0x60008BC")]
			[Address(RVA = "0x26AEAE8", Offset = "0x26AEAE8", VA = "0x26AEAE8")]
			public Packed()
			{
			}
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1FA5918", Offset = "0x1FA5918", VA = "0x1FA5918")]
		public static Packed GetWorldPacked(this Transform self)
		{
			return null;
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1FA59BC", Offset = "0x1FA59BC", VA = "0x1FA59BC")]
		public static bool IsSame(this Transform self, Packed packed)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000029")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBB0E8C", Offset = "0xBB0E8C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBB0E8C", Offset = "0xBB0E8C")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool setIsTrigger;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float rangeMultiplier;

		[Token(Token = "0x4000135")]
		private const int kMeshColliderNumSides = 8;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private VolumetricLightBeam m_Beam;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private DynamicOcclusionRaycasting m_DynamicOcclusionRaycasting;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PolygonCollider2D m_PolygonCollider2D;

		[Token(Token = "0x17000021")]
		private TriggerZoneUpdateRate updateRate
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x1FA5C1C", Offset = "0x1FA5C1C", VA = "0x1FA5C1C")]
			get
			{
				return default(TriggerZoneUpdateRate);
			}
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1FA5CAC", Offset = "0x1FA5CAC", VA = "0x1FA5CAC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1FA6418", Offset = "0x1FA6418", VA = "0x1FA6418")]
		private void OnOcclusionProcessed()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1FA5E2C", Offset = "0x1FA5E2C", VA = "0x1FA5E2C")]
		private void ComputeZone()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1FA6584", Offset = "0x1FA6584", VA = "0x1FA6584")]
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
		[Address(RVA = "0x1FAF2A8", Offset = "0x1FAF2A8", VA = "0x1FAF2A8")]
		public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
		{
			return default(float);
		}

		[Token(Token = "0x60000D6")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1FAF2E0", Offset = "0x1FAF2E0", VA = "0x1FAF2E0")]
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
		[Address(RVA = "0x1FAF418", Offset = "0x1FAF418", VA = "0x1FAF418")]
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1FAF4F8", Offset = "0x1FAF4F8", VA = "0x1FAF4F8")]
		public static Vector2 xy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1FAF4FC", Offset = "0x1FAF4FC", VA = "0x1FAF4FC")]
		public static Vector2 xz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1FAF504", Offset = "0x1FAF504", VA = "0x1FAF504")]
		public static Vector2 yz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1FAF510", Offset = "0x1FAF510", VA = "0x1FAF510")]
		public static Vector2 yx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1FAF520", Offset = "0x1FAF520", VA = "0x1FAF520")]
		public static Vector2 zx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1FAF52C", Offset = "0x1FAF52C", VA = "0x1FAF52C")]
		public static Vector2 zy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1FAF534", Offset = "0x1FAF534", VA = "0x1FAF534")]
		public static float GetVolumeCubic(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1FAF588", Offset = "0x1FAF588", VA = "0x1FAF588")]
		public static float GetMaxArea2D(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1FAF628", Offset = "0x1FAF628", VA = "0x1FAF628")]
		public static Color Opaque(this Color self)
		{
			return default(Color);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1FAF65C", Offset = "0x1FAF65C", VA = "0x1FAF65C")]
		public static void GizmosDrawPlane(Vector3 normal, Vector3 position, Color color, float size = 1f)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1FAF8E8", Offset = "0x1FAF8E8", VA = "0x1FAF8E8")]
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			return default(Plane);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1FA6508", Offset = "0x1FA6508", VA = "0x1FA6508")]
		public static Vector3 ClosestPointOnPlaneCustom(this Plane plane, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1FA64F0", Offset = "0x1FA64F0", VA = "0x1FA64F0")]
		public static bool IsAlmostZero(float f)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1FA64A4", Offset = "0x1FA64A4", VA = "0x1FA64A4")]
		public static bool IsValid(this Plane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1FAF990", Offset = "0x1FAF990", VA = "0x1FAF990")]
		public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1FAF9B4", Offset = "0x1FAF9B4", VA = "0x1FAF9B4")]
		public static void SetShaderKeywordEnabled(string name, bool enabled)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1FAF9C8", Offset = "0x1FAF9C8", VA = "0x1FAF9C8")]
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1FAFBE4", Offset = "0x1FAFBE4", VA = "0x1FAFBE4")]
		public static Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			return null;
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1FAFCC8", Offset = "0x1FAFCC8", VA = "0x1FAFCC8")]
		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1FAFAEC", Offset = "0x1FAFAEC", VA = "0x1FAFAEC")]
		public static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			return default(float);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1FAFD08", Offset = "0x1FAFD08", VA = "0x1FAFD08")]
		public static FloatPackingPrecision GetFloatPackingPrecision()
		{
			return default(FloatPackingPrecision);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1FAFDD4", Offset = "0x1FAFDD4", VA = "0x1FAFDD4")]
		public static void MarkCurrentSceneDirty()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1FAFDD8", Offset = "0x1FAFDD8", VA = "0x1FAFDD8")]
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
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBB0F30", Offset = "0xBB0F30")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBB0F30", Offset = "0xBB0F30")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBB1D58", Offset = "0xBB1D58")]
		public float alpha;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBB1D70", Offset = "0xBB1D70")]
		public float size;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Direction direction;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speed;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float density;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBB1D90", Offset = "0xBB1D90")]
		public float spawnMinDistance;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBB1DA8", Offset = "0xBB1DA8")]
		public float spawnMaxDistance;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool cullingEnabled;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float cullingMaxDistance;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB1DC0", Offset = "0xBB1DC0")]
		private bool <isCulled>k__BackingField;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool isFeatureSupported;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ParticleSystem m_Particles;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ParticleSystemRenderer m_Renderer;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool ms_NoMainCameraLogged;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Camera ms_MainCamera;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x17000022")]
		public bool isCulled
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x1FAFDE0", Offset = "0x1FAFDE0", VA = "0x1FAFDE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB69F8", Offset = "0xBB69F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x1FAFDE8", Offset = "0x1FAFDE8", VA = "0x1FAFDE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6A08", Offset = "0xBB6A08")]
			private set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public bool particlesAreInstantiated
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x1FAFDF4", Offset = "0x1FAFDF4", VA = "0x1FAFDF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000024")]
		public int particlesCurrentCount
		{
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x1FAFE5C", Offset = "0x1FAFE5C", VA = "0x1FAFE5C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000025")]
		public int particlesMaxCount
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x1FAFEEC", Offset = "0x1FAFEEC", VA = "0x1FAFEEC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000026")]
		public Camera mainCamera
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x1FAFF94", Offset = "0x1FAFF94", VA = "0x1FAFF94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x1FB0224", Offset = "0x1FB0224", VA = "0x1FB0224")]
		private void Start()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1FB0294", Offset = "0x1FB0294", VA = "0x1FB0294")]
		private void InstantiateParticleSystem()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1FB05EC", Offset = "0x1FB05EC", VA = "0x1FB05EC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1FB04CC", Offset = "0x1FB04CC", VA = "0x1FB04CC")]
		private void SetActiveAndPlay()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1FB0CBC", Offset = "0x1FB0CBC", VA = "0x1FB0CBC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1FB0D58", Offset = "0x1FB0D58", VA = "0x1FB0D58")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1FB0E1C", Offset = "0x1FB0E1C", VA = "0x1FB0E1C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1FB05F0", Offset = "0x1FB05F0", VA = "0x1FB05F0")]
		private void SetParticleProperties()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1FB0E50", Offset = "0x1FB0E50", VA = "0x1FB0E50")]
		private void UpdateCulling()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1FB1250", Offset = "0x1FB1250", VA = "0x1FB1250")]
		public VolumetricDustParticles()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[SelectionBase]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBB0FD4", Offset = "0xBB0FD4")]
	public class VolumetricLightBeam : MonoBehaviour
	{
		[Token(Token = "0x200009D")]
		public delegate void OnWillCameraRenderCB(Camera cam);

		[Token(Token = "0x200009E")]
		public delegate void OnBeamGeometryInitialized();

		[Token(Token = "0x200009F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB195C", Offset = "0xBB195C")]
		private sealed class <CoPlaytimeUpdate>d__162 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VolumetricLightBeam <>4__this;

			[Token(Token = "0x1700031C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008C8")]
				[Address(RVA = "0x26AF098", Offset = "0x26AF098", VA = "0x26AF098", Slot = "4")]
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
				[Address(RVA = "0x26AF0E0", Offset = "0x26AF0E0", VA = "0x26AF0E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x26AEFD4", Offset = "0x26AEFD4", VA = "0x26AEFD4")]
			[DebuggerHidden]
			public <CoPlaytimeUpdate>d__162(int <>1__state)
			{
			}

			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x26AF000", Offset = "0x26AF000", VA = "0x26AF000", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x26AF004", Offset = "0x26AF004", VA = "0x26AF004", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x26AF0A0", Offset = "0x26AF0A0", VA = "0x26AF0A0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool colorFromLight;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ColorMode colorMode;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0xBB1DD0", Offset = "0xBB1DD0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBB1DD0", Offset = "0xBB1DD0")]
		public Color color;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Gradient colorGradient;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool intensityFromLight;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool intensityModeAdvanced;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBB1E24", Offset = "0xBB1E24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBB1E24", Offset = "0xBB1E24")]
		public float intensityInside;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBB1E78", Offset = "0xBB1E78")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBB1E78", Offset = "0xBB1E78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBB1E78", Offset = "0xBB1E78")]
		public float intensityOutside;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public BlendingMode blendingMode;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBB1EF0", Offset = "0xBB1EF0")]
		public bool spotAngleFromLight;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBB1F28", Offset = "0xBB1F28")]
		public float spotAngle;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBB1F48", Offset = "0xBB1F48")]
		public float coneRadiusStart;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public MeshType geomMeshType;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBB1F80", Offset = "0xBB1F80")]
		public int geomCustomSides;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int geomCustomSegments;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool geomCap;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBB1FB8", Offset = "0xBB1FB8")]
		public bool fallOffEndFromLight;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public AttenuationEquation attenuationEquation;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBB1FF0", Offset = "0xBB1FF0")]
		public float attenuationCustomBlending;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBB2008", Offset = "0xBB2008")]
		public float fallOffStart;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBB2040", Offset = "0xBB2040")]
		public float fallOffEnd;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float depthBlendDistance;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float cameraClippingDistance;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBB2078", Offset = "0xBB2078")]
		public float glareFrontal;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBB2090", Offset = "0xBB2090")]
		public float glareBehind;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBB20A8", Offset = "0xBB20A8")]
		public float fresnelPow;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public NoiseMode noiseMode;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBB20E0", Offset = "0xBB20E0")]
		[SerializeField]
		private bool _DEPRECATED_NoiseEnabled;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBB212C", Offset = "0xBB212C")]
		public float noiseIntensity;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public bool noiseScaleUseGlobal;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBB2144", Offset = "0xBB2144")]
		public float noiseScaleLocal;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool noiseVelocityUseGlobal;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 noiseVelocityLocal;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public Dimensions dimensions;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB2160", Offset = "0xBB2160")]
		private MaterialManager.DynamicOcclusion <_INTERNAL_DynamicOcclusionMode>k__BackingField;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private bool m_IsDynamicOcclusionEnabled;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private OnBeamGeometryInitialized m_OnBeamGeometryInitialized;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBB2190", Offset = "0xBB2190")]
		[SerializeField]
		private bool _TrackChangesDuringPlaytime;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private int _SortingLayerID;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private int _SortingOrder;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBB21FC", Offset = "0xBB21FC")]
		[SerializeField]
		private float _FadeOutBegin;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBB2248", Offset = "0xBB2248")]
		[SerializeField]
		private float _FadeOutEnd;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB2294", Offset = "0xBB2294")]
		private uint <_INTERNAL_InstancedMaterialGroupID>k__BackingField;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private BeamGeometry m_BeamGeom;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Coroutine m_CoPlaytimeUpdate;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Light _CachedLight;

		[Token(Token = "0x17000027")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBB7CF8", Offset = "0xBB7CF8")]
		public float alphaInside
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x1FB12FC", Offset = "0x1FB12FC", VA = "0x1FB12FC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x1FB1304", Offset = "0x1FB1304", VA = "0x1FB1304")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBB7D30", Offset = "0xBB7D30")]
		public float alphaOutside
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x1FB130C", Offset = "0x1FB130C", VA = "0x1FB130C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x1FB1314", Offset = "0x1FB1314", VA = "0x1FB1314")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public float intensityGlobal
		{
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x1FB131C", Offset = "0x1FB131C", VA = "0x1FB131C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x1FB1324", Offset = "0x1FB1324", VA = "0x1FB1324")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public float coneAngle
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x1FB1058", Offset = "0x1FB1058", VA = "0x1FB1058")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002B")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x1FA641C", Offset = "0x1FA641C", VA = "0x1FA641C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002C")]
		public float coneVolume
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x1FB132C", Offset = "0x1FB132C", VA = "0x1FB132C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002D")]
		public float coneApexOffsetZ
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x1FB1380", Offset = "0x1FB1380", VA = "0x1FB1380")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002E")]
		public int geomSides
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x1FB13D8", Offset = "0x1FB13D8", VA = "0x1FB13D8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x1FB1460", Offset = "0x1FB1460", VA = "0x1FB1460")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public int geomSegments
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x1FB14E8", Offset = "0x1FB14E8", VA = "0x1FB14E8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x1FB1570", Offset = "0x1FB1570", VA = "0x1FB1570")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBB7D68", Offset = "0xBB7D68")]
		public bool fadeEndFromLight
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x1FB15F8", Offset = "0x1FB15F8", VA = "0x1FB15F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x1FB1600", Offset = "0x1FB1600", VA = "0x1FB1600")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public float attenuationLerpLinearQuad
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x1FB160C", Offset = "0x1FB160C", VA = "0x1FB160C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000032")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBB7DA0", Offset = "0xBB7DA0")]
		public float fadeStart
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x1FB1634", Offset = "0x1FB1634", VA = "0x1FB1634")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x1FB163C", Offset = "0x1FB163C", VA = "0x1FB163C")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBB7DD8", Offset = "0xBB7DD8")]
		public float fadeEnd
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x1FB1644", Offset = "0x1FB1644", VA = "0x1FB1644")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x1FB164C", Offset = "0x1FB164C", VA = "0x1FB164C")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public bool isNoiseEnabled
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x1FB1654", Offset = "0x1FB1654", VA = "0x1FB1654")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000035")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBB7E10", Offset = "0xBB7E10")]
		public bool noiseEnabled
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x1FB1664", Offset = "0x1FB1664", VA = "0x1FB1664")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x1FB1674", Offset = "0x1FB1674", VA = "0x1FB1674")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public float fadeOutBegin
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x1FB1690", Offset = "0x1FB1690", VA = "0x1FB1690")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x1FB1698", Offset = "0x1FB1698", VA = "0x1FB1698")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public float fadeOutEnd
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x1FB16F4", Offset = "0x1FB16F4", VA = "0x1FB16F4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x1FB16FC", Offset = "0x1FB16FC", VA = "0x1FB16FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public bool isFadeOutEnabled
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x1FB1098", Offset = "0x1FB1098", VA = "0x1FB1098")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000039")]
		public int sortingLayerID
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x1FB1704", Offset = "0x1FB1704", VA = "0x1FB1704")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x1FB170C", Offset = "0x1FB170C", VA = "0x1FB170C")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public string sortingLayerName
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x1FB17B0", Offset = "0x1FB17B0", VA = "0x1FB17B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x1FB17BC", Offset = "0x1FB17BC", VA = "0x1FB17BC")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public int sortingOrder
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x1FB17EC", Offset = "0x1FB17EC", VA = "0x1FB17EC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x1FB17F4", Offset = "0x1FB17F4", VA = "0x1FB17F4")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public bool trackChangesDuringPlaytime
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x1FB1898", Offset = "0x1FB1898", VA = "0x1FB1898")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x1FB18A0", Offset = "0x1FB18A0", VA = "0x1FB18A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public bool isCurrentlyTrackingChanges
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x1FB1918", Offset = "0x1FB1918", VA = "0x1FB1918")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003E")]
		public bool hasGeometry
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x1FB10BC", Offset = "0x1FB10BC", VA = "0x1FB10BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003F")]
		public Bounds bounds
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x1FB1128", Offset = "0x1FB1128", VA = "0x1FB1128")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x17000040")]
		public int blendingModeAsInt
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x1FB1928", Offset = "0x1FB1928", VA = "0x1FB1928")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000041")]
		public Quaternion beamInternalLocalRotation
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x1FB0584", Offset = "0x1FB0584", VA = "0x1FB0584")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000042")]
		public Vector3 beamLocalForward
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x1FB1A0C", Offset = "0x1FB1A0C", VA = "0x1FB1A0C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000043")]
		public Vector3 beamGlobalForward
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x1FB1A24", Offset = "0x1FB1A24", VA = "0x1FB1A24")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000044")]
		public Vector3 beamGlobalUp
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x1FB1AA0", Offset = "0x1FB1AA0", VA = "0x1FB1AA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000045")]
		public Vector3 beamGlobalRight
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x1FB1B1C", Offset = "0x1FB1B1C", VA = "0x1FB1B1C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000046")]
		public Vector3 lossyScale
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x1FB1B98", Offset = "0x1FB1B98", VA = "0x1FB1B98")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000047")]
		public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x1FB1C30", Offset = "0x1FB1C30", VA = "0x1FB1C30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6A18", Offset = "0xBB6A18")]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x1FB1C38", Offset = "0x1FB1C38", VA = "0x1FB1C38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6A28", Offset = "0xBB6A28")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public MaterialManager.DynamicOcclusion _INTERNAL_EnabledDynamicOcclusionMode
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x1FB1C40", Offset = "0x1FB1C40", VA = "0x1FB1C40")]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
		}

		[Token(Token = "0x17000049")]
		public uint _INTERNAL_InstancedMaterialGroupID
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x1FB2030", Offset = "0x1FB2030", VA = "0x1FB2030")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6A58", Offset = "0xBB6A58")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x1FB2038", Offset = "0x1FB2038", VA = "0x1FB2038")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6A68", Offset = "0xBB6A68")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public string meshStats
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x1FB2040", Offset = "0x1FB2040", VA = "0x1FB2040")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public int meshVerticesCount
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x1FB2214", Offset = "0x1FB2214", VA = "0x1FB2214")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004C")]
		public int meshTrianglesCount
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x1FB22EC", Offset = "0x1FB22EC", VA = "0x1FB22EC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004D")]
		private Light lightSpotAttached
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x1FB23DC", Offset = "0x1FB23DC", VA = "0x1FB23DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000002")]
		public event OnWillCameraRenderCB onWillCameraRenderThisBeam
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x1FB1D0C", Offset = "0x1FB1D0C", VA = "0x1FB1D0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6A38", Offset = "0xBB6A38")]
			add
			{
			}
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x1FB1DAC", Offset = "0x1FB1DAC", VA = "0x1FB1DAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6A48", Offset = "0xBB6A48")]
			remove
			{
			}
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1FB1C58", Offset = "0x1FB1C58", VA = "0x1FB1C58")]
		public void _INTERNAL_SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1FB1E4C", Offset = "0x1FB1E4C", VA = "0x1FB1E4C")]
		public void _INTERNAL_OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1FB1E60", Offset = "0x1FB1E60", VA = "0x1FB1E60")]
		public void RegisterOnBeamGeometryInitializedCallback(OnBeamGeometryInitialized cb)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1FB1F48", Offset = "0x1FB1F48", VA = "0x1FB1F48")]
		private void CallOnBeamGeometryInitializedCallback()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1FB16A0", Offset = "0x1FB16A0", VA = "0x1FB16A0")]
		private void SetFadeOutValue(ref float propToChange, float value)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1FB1F8C", Offset = "0x1FB1F8C", VA = "0x1FB1F8C")]
		private void OnFadeOutStateChanged()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1FB24E4", Offset = "0x1FB24E4", VA = "0x1FB24E4")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return default(float);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1FB2544", Offset = "0x1FB2544", VA = "0x1FB2544")]
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return default(float);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1FB269C", Offset = "0x1FB269C", VA = "0x1FB269C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBB6A78", Offset = "0xBB6A78")]
		public void Generate()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1FB26A8", Offset = "0x1FB26A8", VA = "0x1FB26A8", Slot = "4")]
		public virtual void GenerateGeometry()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1FB2920", Offset = "0x1FB2920", VA = "0x1FB2920", Slot = "5")]
		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1FB29B4", Offset = "0x1FB29B4", VA = "0x1FB29B4")]
		private void Start()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1FB29C0", Offset = "0x1FB29C0", VA = "0x1FB29C0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1FB2A4C", Offset = "0x1FB2A4C", VA = "0x1FB2A4C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1FB18AC", Offset = "0x1FB18AC", VA = "0x1FB18AC")]
		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1FB2AE0", Offset = "0x1FB2AE0", VA = "0x1FB2AE0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBB6AB0", Offset = "0xBB6AB0")]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1FB2B58", Offset = "0x1FB2B58", VA = "0x1FB2B58")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1FB2B5C", Offset = "0x1FB2B5C", VA = "0x1FB2B5C")]
		private void DestroyBeam()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1FB2C20", Offset = "0x1FB2C20", VA = "0x1FB2C20")]
		private void AssignPropertiesFromSpotLight(Light lightSpot)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1FB2D1C", Offset = "0x1FB2D1C", VA = "0x1FB2D1C")]
		private void ClampProperties()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1FB28F0", Offset = "0x1FB28F0", VA = "0x1FB28F0")]
		private void ValidateProperties()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1FB2808", Offset = "0x1FB2808", VA = "0x1FB2808")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1FB2EC0", Offset = "0x1FB2EC0", VA = "0x1FB2EC0")]
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
			[Address(RVA = "0x19C6C10", Offset = "0x19C6C10", VA = "0x19C6C10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014B")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.a
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x19C6C60", Offset = "0x19C6C60", VA = "0x19C6C60", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014C")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.actionBottomRow2
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x19C6CB0", Offset = "0x19C6CB0", VA = "0x19C6CB0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014D")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.b
		{
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x19C6D00", Offset = "0x19C6D00", VA = "0x19C6D00", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014E")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.actionBottomRow3
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x19C6D50", Offset = "0x19C6D50", VA = "0x19C6D50", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014F")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.c
		{
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x19C6DA0", Offset = "0x19C6DA0", VA = "0x19C6DA0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000150")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.actionTopRow1
		{
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x19C6DF0", Offset = "0x19C6DF0", VA = "0x19C6DF0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000151")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.x
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x19C6E40", Offset = "0x19C6E40", VA = "0x19C6E40", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000152")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.actionTopRow2
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x19C6E90", Offset = "0x19C6E90", VA = "0x19C6E90", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000153")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.y
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x19C6EE0", Offset = "0x19C6EE0", VA = "0x19C6EE0", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000154")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.actionTopRow3
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x19C6F30", Offset = "0x19C6F30", VA = "0x19C6F30", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000155")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.z
		{
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x19C6F80", Offset = "0x19C6F80", VA = "0x19C6F80", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000156")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.leftShoulder1
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x19C6FD0", Offset = "0x19C6FD0", VA = "0x19C6FD0", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000157")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.leftBumper
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x19C7020", Offset = "0x19C7020", VA = "0x19C7020", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000158")]
		private IControllerTemplateAxis Rewired.IGamepadTemplate.leftShoulder2
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x19C7070", Offset = "0x19C7070", VA = "0x19C7070", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000159")]
		private IControllerTemplateAxis Rewired.IGamepadTemplate.leftTrigger
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x19C70C0", Offset = "0x19C70C0", VA = "0x19C70C0", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015A")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.rightShoulder1
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x19C7110", Offset = "0x19C7110", VA = "0x19C7110", Slot = "28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015B")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.rightBumper
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x19C7160", Offset = "0x19C7160", VA = "0x19C7160", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015C")]
		private IControllerTemplateAxis Rewired.IGamepadTemplate.rightShoulder2
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x19C71B0", Offset = "0x19C71B0", VA = "0x19C71B0", Slot = "30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015D")]
		private IControllerTemplateAxis Rewired.IGamepadTemplate.rightTrigger
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x19C7200", Offset = "0x19C7200", VA = "0x19C7200", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015E")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.center1
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x19C7250", Offset = "0x19C7250", VA = "0x19C7250", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015F")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.back
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x19C72A0", Offset = "0x19C72A0", VA = "0x19C72A0", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000160")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.center2
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x19C72F0", Offset = "0x19C72F0", VA = "0x19C72F0", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000161")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.start
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x19C7340", Offset = "0x19C7340", VA = "0x19C7340", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000162")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.center3
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x19C7390", Offset = "0x19C7390", VA = "0x19C7390", Slot = "36")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000163")]
		private IControllerTemplateButton Rewired.IGamepadTemplate.guide
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x19C73E0", Offset = "0x19C73E0", VA = "0x19C73E0", Slot = "37")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000164")]
		private IControllerTemplateThumbStick Rewired.IGamepadTemplate.leftStick
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x19C7430", Offset = "0x19C7430", VA = "0x19C7430", Slot = "38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000165")]
		private IControllerTemplateThumbStick Rewired.IGamepadTemplate.rightStick
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x19C7480", Offset = "0x19C7480", VA = "0x19C7480", Slot = "39")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000166")]
		private IControllerTemplateDPad Rewired.IGamepadTemplate.dPad
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x19C74D0", Offset = "0x19C74D0", VA = "0x19C74D0", Slot = "40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x19C0024", Offset = "0x19C0024", VA = "0x19C0024")]
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
			[Address(RVA = "0x210AC04", Offset = "0x210AC04", VA = "0x210AC04", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000168")]
		private IControllerTemplateAxis Rewired.IRacingWheelTemplate.accelerator
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x210AC54", Offset = "0x210AC54", VA = "0x210AC54", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000169")]
		private IControllerTemplateAxis Rewired.IRacingWheelTemplate.brake
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x210ACA4", Offset = "0x210ACA4", VA = "0x210ACA4", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016A")]
		private IControllerTemplateAxis Rewired.IRacingWheelTemplate.clutch
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x210ACF4", Offset = "0x210ACF4", VA = "0x210ACF4", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016B")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.shiftDown
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x210AD44", Offset = "0x210AD44", VA = "0x210AD44", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016C")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.shiftUp
		{
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x210AD94", Offset = "0x210AD94", VA = "0x210AD94", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016D")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton1
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x210ADE4", Offset = "0x210ADE4", VA = "0x210ADE4", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016E")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton2
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x210AE34", Offset = "0x210AE34", VA = "0x210AE34", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016F")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton3
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x210AE84", Offset = "0x210AE84", VA = "0x210AE84", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000170")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton4
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x210AED4", Offset = "0x210AED4", VA = "0x210AED4", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000171")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton5
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x210AF24", Offset = "0x210AF24", VA = "0x210AF24", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000172")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton6
		{
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x210AF74", Offset = "0x210AF74", VA = "0x210AF74", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000173")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton7
		{
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x210AFC4", Offset = "0x210AFC4", VA = "0x210AFC4", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000174")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton8
		{
			[Token(Token = "0x600027E")]
			[Address(RVA = "0x210B014", Offset = "0x210B014", VA = "0x210B014", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000175")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton9
		{
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x210B064", Offset = "0x210B064", VA = "0x210B064", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000176")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.wheelButton10
		{
			[Token(Token = "0x6000280")]
			[Address(RVA = "0x210B0B4", Offset = "0x210B0B4", VA = "0x210B0B4", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000177")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton1
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0x210B104", Offset = "0x210B104", VA = "0x210B104", Slot = "28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000178")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton2
		{
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x210B154", Offset = "0x210B154", VA = "0x210B154", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000179")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton3
		{
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x210B1A4", Offset = "0x210B1A4", VA = "0x210B1A4", Slot = "30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017A")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton4
		{
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x210B1F4", Offset = "0x210B1F4", VA = "0x210B1F4", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017B")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton5
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x210B244", Offset = "0x210B244", VA = "0x210B244", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017C")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton6
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x210B294", Offset = "0x210B294", VA = "0x210B294", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017D")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton7
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x210B2E4", Offset = "0x210B2E4", VA = "0x210B2E4", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017E")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton8
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x210B334", Offset = "0x210B334", VA = "0x210B334", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017F")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton9
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x210B384", Offset = "0x210B384", VA = "0x210B384", Slot = "36")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000180")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.consoleButton10
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x210B3D4", Offset = "0x210B3D4", VA = "0x210B3D4", Slot = "37")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000181")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter1
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x210B424", Offset = "0x210B424", VA = "0x210B424", Slot = "38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000182")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter2
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x210B474", Offset = "0x210B474", VA = "0x210B474", Slot = "39")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000183")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter3
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x210B4C4", Offset = "0x210B4C4", VA = "0x210B4C4", Slot = "40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000184")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter4
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x210B514", Offset = "0x210B514", VA = "0x210B514", Slot = "41")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000185")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter5
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x210B564", Offset = "0x210B564", VA = "0x210B564", Slot = "42")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000186")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter6
		{
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x210B5B4", Offset = "0x210B5B4", VA = "0x210B5B4", Slot = "43")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000187")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter7
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x210B604", Offset = "0x210B604", VA = "0x210B604", Slot = "44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000188")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter8
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x210B654", Offset = "0x210B654", VA = "0x210B654", Slot = "45")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000189")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter9
		{
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x210B6A4", Offset = "0x210B6A4", VA = "0x210B6A4", Slot = "46")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018A")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.shifter10
		{
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x210B6F4", Offset = "0x210B6F4", VA = "0x210B6F4", Slot = "47")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018B")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.reverseGear
		{
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x210B744", Offset = "0x210B744", VA = "0x210B744", Slot = "48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018C")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.select
		{
			[Token(Token = "0x6000296")]
			[Address(RVA = "0x210B794", Offset = "0x210B794", VA = "0x210B794", Slot = "49")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018D")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.start
		{
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x210B7E4", Offset = "0x210B7E4", VA = "0x210B7E4", Slot = "50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018E")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.systemButton
		{
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x210B834", Offset = "0x210B834", VA = "0x210B834", Slot = "51")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018F")]
		private IControllerTemplateButton Rewired.IRacingWheelTemplate.horn
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x210B884", Offset = "0x210B884", VA = "0x210B884", Slot = "52")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000190")]
		private IControllerTemplateDPad Rewired.IRacingWheelTemplate.dPad
		{
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x210B8D4", Offset = "0x210B8D4", VA = "0x210B8D4", Slot = "53")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x210B924", Offset = "0x210B924", VA = "0x210B924")]
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
			[Address(RVA = "0x19C7774", Offset = "0x19C7774", VA = "0x19C7774", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000192")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickTriggerStage2
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x19C77C4", Offset = "0x19C77C4", VA = "0x19C77C4", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000193")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickPinkyButton
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x19C7814", Offset = "0x19C7814", VA = "0x19C7814", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000194")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickPinkyTrigger
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x19C7864", Offset = "0x19C7864", VA = "0x19C7864", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000195")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton1
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x19C78B4", Offset = "0x19C78B4", VA = "0x19C78B4", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000196")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton2
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x19C7904", Offset = "0x19C7904", VA = "0x19C7904", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000197")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton3
		{
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x19C7954", Offset = "0x19C7954", VA = "0x19C7954", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000198")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton4
		{
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x19C79A4", Offset = "0x19C79A4", VA = "0x19C79A4", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000199")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton5
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x19C79F4", Offset = "0x19C79F4", VA = "0x19C79F4", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019A")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton6
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x19C7A44", Offset = "0x19C7A44", VA = "0x19C7A44", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019B")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton7
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x19C7A94", Offset = "0x19C7A94", VA = "0x19C7A94", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019C")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton8
		{
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x19C7AE4", Offset = "0x19C7AE4", VA = "0x19C7AE4", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019D")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton9
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x19C7B34", Offset = "0x19C7B34", VA = "0x19C7B34", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019E")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickButton10
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x19C7B84", Offset = "0x19C7B84", VA = "0x19C7B84", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019F")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton1
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x19C7BD4", Offset = "0x19C7BD4", VA = "0x19C7BD4", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A0")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton2
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x19C7C24", Offset = "0x19C7C24", VA = "0x19C7C24", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A1")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton3
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x19C7C74", Offset = "0x19C7C74", VA = "0x19C7C74", Slot = "28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A2")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton4
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x19C7CC4", Offset = "0x19C7CC4", VA = "0x19C7CC4", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A3")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton5
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x19C7D14", Offset = "0x19C7D14", VA = "0x19C7D14", Slot = "30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A4")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton6
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x19C7D64", Offset = "0x19C7D64", VA = "0x19C7D64", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A5")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton7
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x19C7DB4", Offset = "0x19C7DB4", VA = "0x19C7DB4", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A6")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton8
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x19C7E04", Offset = "0x19C7E04", VA = "0x19C7E04", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A7")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton9
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x19C7E54", Offset = "0x19C7E54", VA = "0x19C7E54", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A8")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton10
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x19C7EA4", Offset = "0x19C7EA4", VA = "0x19C7EA4", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A9")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton11
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x19C7EF4", Offset = "0x19C7EF4", VA = "0x19C7EF4", Slot = "36")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AA")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.stickBaseButton12
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x19C7F44", Offset = "0x19C7F44", VA = "0x19C7F44", Slot = "37")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AB")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.mode1
		{
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x19C7F94", Offset = "0x19C7F94", VA = "0x19C7F94", Slot = "38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AC")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.mode2
		{
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x19C7FE4", Offset = "0x19C7FE4", VA = "0x19C7FE4", Slot = "39")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AD")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.mode3
		{
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x19C8034", Offset = "0x19C8034", VA = "0x19C8034", Slot = "40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AE")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton1
		{
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x19C8084", Offset = "0x19C8084", VA = "0x19C8084", Slot = "41")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AF")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton2
		{
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x19C80D4", Offset = "0x19C80D4", VA = "0x19C80D4", Slot = "42")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B0")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton3
		{
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x19C8124", Offset = "0x19C8124", VA = "0x19C8124", Slot = "43")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B1")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton4
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x19C8174", Offset = "0x19C8174", VA = "0x19C8174", Slot = "44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B2")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton5
		{
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x19C81C4", Offset = "0x19C81C4", VA = "0x19C81C4", Slot = "45")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B3")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton6
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x19C8214", Offset = "0x19C8214", VA = "0x19C8214", Slot = "46")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B4")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton7
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x19C8264", Offset = "0x19C8264", VA = "0x19C8264", Slot = "47")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B5")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton8
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x19C82B4", Offset = "0x19C82B4", VA = "0x19C82B4", Slot = "48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B6")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton9
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x19C8304", Offset = "0x19C8304", VA = "0x19C8304", Slot = "49")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B7")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleButton10
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x19C8354", Offset = "0x19C8354", VA = "0x19C8354", Slot = "50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B8")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton1
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x19C83A4", Offset = "0x19C83A4", VA = "0x19C83A4", Slot = "51")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B9")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton2
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x19C83F4", Offset = "0x19C83F4", VA = "0x19C83F4", Slot = "52")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BA")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton3
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x19C8444", Offset = "0x19C8444", VA = "0x19C8444", Slot = "53")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BB")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton4
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x19C8494", Offset = "0x19C8494", VA = "0x19C8494", Slot = "54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BC")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton5
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x19C84E4", Offset = "0x19C84E4", VA = "0x19C84E4", Slot = "55")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BD")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton6
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x19C8534", Offset = "0x19C8534", VA = "0x19C8534", Slot = "56")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BE")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton7
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x19C8584", Offset = "0x19C8584", VA = "0x19C8584", Slot = "57")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BF")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton8
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x19C85D4", Offset = "0x19C85D4", VA = "0x19C85D4", Slot = "58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C0")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton9
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x19C8624", Offset = "0x19C8624", VA = "0x19C8624", Slot = "59")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C1")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton10
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x19C8674", Offset = "0x19C8674", VA = "0x19C8674", Slot = "60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C2")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton11
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x19C86C4", Offset = "0x19C86C4", VA = "0x19C86C4", Slot = "61")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C3")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton12
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x19C8714", Offset = "0x19C8714", VA = "0x19C8714", Slot = "62")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C4")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton13
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x19C8764", Offset = "0x19C8764", VA = "0x19C8764", Slot = "63")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C5")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton14
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x19C87B4", Offset = "0x19C87B4", VA = "0x19C87B4", Slot = "64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C6")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleBaseButton15
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x19C8804", Offset = "0x19C8804", VA = "0x19C8804", Slot = "65")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C7")]
		private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleSlider1
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x19C8854", Offset = "0x19C8854", VA = "0x19C8854", Slot = "66")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C8")]
		private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleSlider2
		{
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x19C88A4", Offset = "0x19C88A4", VA = "0x19C88A4", Slot = "67")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C9")]
		private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleSlider3
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x19C88F4", Offset = "0x19C88F4", VA = "0x19C88F4", Slot = "68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CA")]
		private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleSlider4
		{
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x19C8944", Offset = "0x19C8944", VA = "0x19C8944", Slot = "69")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CB")]
		private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleDial1
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x19C8994", Offset = "0x19C8994", VA = "0x19C8994", Slot = "70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CC")]
		private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleDial2
		{
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x19C89E4", Offset = "0x19C89E4", VA = "0x19C89E4", Slot = "71")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CD")]
		private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleDial3
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x19C8A34", Offset = "0x19C8A34", VA = "0x19C8A34", Slot = "72")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CE")]
		private IControllerTemplateAxis Rewired.IHOTASTemplate.throttleDial4
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x19C8A84", Offset = "0x19C8A84", VA = "0x19C8A84", Slot = "73")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CF")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel1Forward
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x19C8AD4", Offset = "0x19C8AD4", VA = "0x19C8AD4", Slot = "74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D0")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel1Back
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x19C8B24", Offset = "0x19C8B24", VA = "0x19C8B24", Slot = "75")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D1")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel1Press
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x19C8B74", Offset = "0x19C8B74", VA = "0x19C8B74", Slot = "76")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D2")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel2Forward
		{
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x19C8BC4", Offset = "0x19C8BC4", VA = "0x19C8BC4", Slot = "77")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D3")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel2Back
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x19C8C14", Offset = "0x19C8C14", VA = "0x19C8C14", Slot = "78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D4")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel2Press
		{
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x19C8C64", Offset = "0x19C8C64", VA = "0x19C8C64", Slot = "79")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D5")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel3Forward
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x19C8CB4", Offset = "0x19C8CB4", VA = "0x19C8CB4", Slot = "80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D6")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel3Back
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x19C8D04", Offset = "0x19C8D04", VA = "0x19C8D04", Slot = "81")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D7")]
		private IControllerTemplateButton Rewired.IHOTASTemplate.throttleWheel3Press
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x19C8D54", Offset = "0x19C8D54", VA = "0x19C8D54", Slot = "82")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D8")]
		private IControllerTemplateAxis Rewired.IHOTASTemplate.leftPedal
		{
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x19C8DA4", Offset = "0x19C8DA4", VA = "0x19C8DA4", Slot = "83")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D9")]
		private IControllerTemplateAxis Rewired.IHOTASTemplate.rightPedal
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x19C8DF4", Offset = "0x19C8DF4", VA = "0x19C8DF4", Slot = "84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001DA")]
		private IControllerTemplateAxis Rewired.IHOTASTemplate.slidePedals
		{
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x19C8E44", Offset = "0x19C8E44", VA = "0x19C8E44", Slot = "85")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001DB")]
		private IControllerTemplateStick Rewired.IHOTASTemplate.stick
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x19C8E94", Offset = "0x19C8E94", VA = "0x19C8E94", Slot = "86")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001DC")]
		private IControllerTemplateThumbStick Rewired.IHOTASTemplate.stickMiniStick1
		{
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x19C8EE4", Offset = "0x19C8EE4", VA = "0x19C8EE4", Slot = "87")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001DD")]
		private IControllerTemplateThumbStick Rewired.IHOTASTemplate.stickMiniStick2
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x19C8F34", Offset = "0x19C8F34", VA = "0x19C8F34", Slot = "88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001DE")]
		private IControllerTemplateHat Rewired.IHOTASTemplate.stickHat1
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x19C8F84", Offset = "0x19C8F84", VA = "0x19C8F84", Slot = "89")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001DF")]
		private IControllerTemplateHat Rewired.IHOTASTemplate.stickHat2
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x19C8FD4", Offset = "0x19C8FD4", VA = "0x19C8FD4", Slot = "90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E0")]
		private IControllerTemplateHat Rewired.IHOTASTemplate.stickHat3
		{
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x19C9024", Offset = "0x19C9024", VA = "0x19C9024", Slot = "91")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E1")]
		private IControllerTemplateHat Rewired.IHOTASTemplate.stickHat4
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x19C9074", Offset = "0x19C9074", VA = "0x19C9074", Slot = "92")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E2")]
		private IControllerTemplateThrottle Rewired.IHOTASTemplate.throttle1
		{
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x19C90C4", Offset = "0x19C90C4", VA = "0x19C90C4", Slot = "93")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E3")]
		private IControllerTemplateThrottle Rewired.IHOTASTemplate.throttle2
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x19C9114", Offset = "0x19C9114", VA = "0x19C9114", Slot = "94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E4")]
		private IControllerTemplateThumbStick Rewired.IHOTASTemplate.throttleMiniStick
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x19C9164", Offset = "0x19C9164", VA = "0x19C9164", Slot = "95")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E5")]
		private IControllerTemplateHat Rewired.IHOTASTemplate.throttleHat1
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x19C91B4", Offset = "0x19C91B4", VA = "0x19C91B4", Slot = "96")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E6")]
		private IControllerTemplateHat Rewired.IHOTASTemplate.throttleHat2
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x19C9204", Offset = "0x19C9204", VA = "0x19C9204", Slot = "97")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E7")]
		private IControllerTemplateHat Rewired.IHOTASTemplate.throttleHat3
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x19C9254", Offset = "0x19C9254", VA = "0x19C9254", Slot = "98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E8")]
		private IControllerTemplateHat Rewired.IHOTASTemplate.throttleHat4
		{
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x19C92A4", Offset = "0x19C92A4", VA = "0x19C92A4", Slot = "99")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x19C002C", Offset = "0x19C002C", VA = "0x19C002C")]
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
			[Address(RVA = "0x19C5C40", Offset = "0x19C5C40", VA = "0x19C5C40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001EA")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.rightPaddle
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x19C5C90", Offset = "0x19C5C90", VA = "0x19C5C90", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001EB")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton1
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x19C5CE0", Offset = "0x19C5CE0", VA = "0x19C5CE0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001EC")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton2
		{
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x19C5D30", Offset = "0x19C5D30", VA = "0x19C5D30", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001ED")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton3
		{
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x19C5D80", Offset = "0x19C5D80", VA = "0x19C5D80", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001EE")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton4
		{
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x19C5DD0", Offset = "0x19C5DD0", VA = "0x19C5DD0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001EF")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton5
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x19C5E20", Offset = "0x19C5E20", VA = "0x19C5E20", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F0")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.leftGripButton6
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x19C5E70", Offset = "0x19C5E70", VA = "0x19C5E70", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F1")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton1
		{
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x19C5EC0", Offset = "0x19C5EC0", VA = "0x19C5EC0", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F2")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton2
		{
			[Token(Token = "0x6000300")]
			[Address(RVA = "0x19C5F10", Offset = "0x19C5F10", VA = "0x19C5F10", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F3")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton3
		{
			[Token(Token = "0x6000301")]
			[Address(RVA = "0x19C5F60", Offset = "0x19C5F60", VA = "0x19C5F60", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F4")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton4
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x19C5FB0", Offset = "0x19C5FB0", VA = "0x19C5FB0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F5")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton5
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x19C6000", Offset = "0x19C6000", VA = "0x19C6000", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F6")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.rightGripButton6
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x19C6050", Offset = "0x19C6050", VA = "0x19C6050", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F7")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton1
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x19C60A0", Offset = "0x19C60A0", VA = "0x19C60A0", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F8")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton2
		{
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x19C60F0", Offset = "0x19C60F0", VA = "0x19C60F0", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F9")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton3
		{
			[Token(Token = "0x6000307")]
			[Address(RVA = "0x19C6140", Offset = "0x19C6140", VA = "0x19C6140", Slot = "28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001FA")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton4
		{
			[Token(Token = "0x6000308")]
			[Address(RVA = "0x19C6190", Offset = "0x19C6190", VA = "0x19C6190", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001FB")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton5
		{
			[Token(Token = "0x6000309")]
			[Address(RVA = "0x19C61E0", Offset = "0x19C61E0", VA = "0x19C61E0", Slot = "30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001FC")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton6
		{
			[Token(Token = "0x600030A")]
			[Address(RVA = "0x19C6230", Offset = "0x19C6230", VA = "0x19C6230", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001FD")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton7
		{
			[Token(Token = "0x600030B")]
			[Address(RVA = "0x19C6280", Offset = "0x19C6280", VA = "0x19C6280", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001FE")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.centerButton8
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0x19C62D0", Offset = "0x19C62D0", VA = "0x19C62D0", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001FF")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel1Up
		{
			[Token(Token = "0x600030D")]
			[Address(RVA = "0x19C6320", Offset = "0x19C6320", VA = "0x19C6320", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000200")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel1Down
		{
			[Token(Token = "0x600030E")]
			[Address(RVA = "0x19C6370", Offset = "0x19C6370", VA = "0x19C6370", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000201")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel1Press
		{
			[Token(Token = "0x600030F")]
			[Address(RVA = "0x19C63C0", Offset = "0x19C63C0", VA = "0x19C63C0", Slot = "36")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000202")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel2Up
		{
			[Token(Token = "0x6000310")]
			[Address(RVA = "0x19C6410", Offset = "0x19C6410", VA = "0x19C6410", Slot = "37")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000203")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel2Down
		{
			[Token(Token = "0x6000311")]
			[Address(RVA = "0x19C6460", Offset = "0x19C6460", VA = "0x19C6460", Slot = "38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000204")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.wheel2Press
		{
			[Token(Token = "0x6000312")]
			[Address(RVA = "0x19C64B0", Offset = "0x19C64B0", VA = "0x19C64B0", Slot = "39")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000205")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton1
		{
			[Token(Token = "0x6000313")]
			[Address(RVA = "0x19C6500", Offset = "0x19C6500", VA = "0x19C6500", Slot = "40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000206")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton2
		{
			[Token(Token = "0x6000314")]
			[Address(RVA = "0x19C6550", Offset = "0x19C6550", VA = "0x19C6550", Slot = "41")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000207")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton3
		{
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x19C65A0", Offset = "0x19C65A0", VA = "0x19C65A0", Slot = "42")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000208")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton4
		{
			[Token(Token = "0x6000316")]
			[Address(RVA = "0x19C65F0", Offset = "0x19C65F0", VA = "0x19C65F0", Slot = "43")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000209")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton5
		{
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x19C6640", Offset = "0x19C6640", VA = "0x19C6640", Slot = "44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700020A")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton6
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x19C6690", Offset = "0x19C6690", VA = "0x19C6690", Slot = "45")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700020B")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton7
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x19C66E0", Offset = "0x19C66E0", VA = "0x19C66E0", Slot = "46")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700020C")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton8
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x19C6730", Offset = "0x19C6730", VA = "0x19C6730", Slot = "47")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700020D")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton9
		{
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x19C6780", Offset = "0x19C6780", VA = "0x19C6780", Slot = "48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700020E")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.consoleButton10
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x19C67D0", Offset = "0x19C67D0", VA = "0x19C67D0", Slot = "49")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700020F")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.mode1
		{
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x19C6820", Offset = "0x19C6820", VA = "0x19C6820", Slot = "50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000210")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.mode2
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x19C6870", Offset = "0x19C6870", VA = "0x19C6870", Slot = "51")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000211")]
		private IControllerTemplateButton Rewired.IFlightYokeTemplate.mode3
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x19C68C0", Offset = "0x19C68C0", VA = "0x19C68C0", Slot = "52")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000212")]
		private IControllerTemplateYoke Rewired.IFlightYokeTemplate.yoke
		{
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x19C6910", Offset = "0x19C6910", VA = "0x19C6910", Slot = "53")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000213")]
		private IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever1
		{
			[Token(Token = "0x6000321")]
			[Address(RVA = "0x19C6960", Offset = "0x19C6960", VA = "0x19C6960", Slot = "54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000214")]
		private IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever2
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x19C69B0", Offset = "0x19C69B0", VA = "0x19C69B0", Slot = "55")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000215")]
		private IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever3
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x19C6A00", Offset = "0x19C6A00", VA = "0x19C6A00", Slot = "56")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000216")]
		private IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever4
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x19C6A50", Offset = "0x19C6A50", VA = "0x19C6A50", Slot = "57")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000217")]
		private IControllerTemplateThrottle Rewired.IFlightYokeTemplate.lever5
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x19C6AA0", Offset = "0x19C6AA0", VA = "0x19C6AA0", Slot = "58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000218")]
		private IControllerTemplateHat Rewired.IFlightYokeTemplate.leftGripHat
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x19C6AF0", Offset = "0x19C6AF0", VA = "0x19C6AF0", Slot = "59")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000219")]
		private IControllerTemplateHat Rewired.IFlightYokeTemplate.rightGripHat
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x19C6B40", Offset = "0x19C6B40", VA = "0x19C6B40", Slot = "60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x19C0034", Offset = "0x19C0034", VA = "0x19C0034")]
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
			[Address(RVA = "0x19C5AD0", Offset = "0x19C5AD0", VA = "0x19C5AD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700021B")]
		private IControllerTemplateAxis Rewired.IFlightPedalsTemplate.rightPedal
		{
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x19C5B20", Offset = "0x19C5B20", VA = "0x19C5B20", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700021C")]
		private IControllerTemplateAxis Rewired.IFlightPedalsTemplate.slide
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x19C5B70", Offset = "0x19C5B70", VA = "0x19C5B70", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x19C003C", Offset = "0x19C003C", VA = "0x19C003C")]
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
			[Address(RVA = "0x26FBDFC", Offset = "0x26FBDFC", VA = "0x26FBDFC", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700021E")]
		private IControllerTemplateAxis Rewired.ISixDofControllerTemplate.extraAxis2
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x26FBE4C", Offset = "0x26FBE4C", VA = "0x26FBE4C", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700021F")]
		private IControllerTemplateAxis Rewired.ISixDofControllerTemplate.extraAxis3
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x26FBE9C", Offset = "0x26FBE9C", VA = "0x26FBE9C", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000220")]
		private IControllerTemplateAxis Rewired.ISixDofControllerTemplate.extraAxis4
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x26FBEEC", Offset = "0x26FBEEC", VA = "0x26FBEEC", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000221")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button1
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x26FBF3C", Offset = "0x26FBF3C", VA = "0x26FBF3C", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000222")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button2
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x26FBF8C", Offset = "0x26FBF8C", VA = "0x26FBF8C", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000223")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button3
		{
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x26FBFDC", Offset = "0x26FBFDC", VA = "0x26FBFDC", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000224")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button4
		{
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x26FC02C", Offset = "0x26FC02C", VA = "0x26FC02C", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000225")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button5
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x26FC07C", Offset = "0x26FC07C", VA = "0x26FC07C", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000226")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button6
		{
			[Token(Token = "0x6000338")]
			[Address(RVA = "0x26FC0CC", Offset = "0x26FC0CC", VA = "0x26FC0CC", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000227")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button7
		{
			[Token(Token = "0x6000339")]
			[Address(RVA = "0x26FC11C", Offset = "0x26FC11C", VA = "0x26FC11C", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000228")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button8
		{
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x26FC16C", Offset = "0x26FC16C", VA = "0x26FC16C", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000229")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button9
		{
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x26FC1BC", Offset = "0x26FC1BC", VA = "0x26FC1BC", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700022A")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button10
		{
			[Token(Token = "0x600033C")]
			[Address(RVA = "0x26FC20C", Offset = "0x26FC20C", VA = "0x26FC20C", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700022B")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button11
		{
			[Token(Token = "0x600033D")]
			[Address(RVA = "0x26FC25C", Offset = "0x26FC25C", VA = "0x26FC25C", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700022C")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button12
		{
			[Token(Token = "0x600033E")]
			[Address(RVA = "0x26FC2AC", Offset = "0x26FC2AC", VA = "0x26FC2AC", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700022D")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button13
		{
			[Token(Token = "0x600033F")]
			[Address(RVA = "0x26FC2FC", Offset = "0x26FC2FC", VA = "0x26FC2FC", Slot = "28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700022E")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button14
		{
			[Token(Token = "0x6000340")]
			[Address(RVA = "0x26FC34C", Offset = "0x26FC34C", VA = "0x26FC34C", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700022F")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button15
		{
			[Token(Token = "0x6000341")]
			[Address(RVA = "0x26FC39C", Offset = "0x26FC39C", VA = "0x26FC39C", Slot = "30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000230")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button16
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0x26FC3EC", Offset = "0x26FC3EC", VA = "0x26FC3EC", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000231")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button17
		{
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x26FC43C", Offset = "0x26FC43C", VA = "0x26FC43C", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000232")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button18
		{
			[Token(Token = "0x6000344")]
			[Address(RVA = "0x26FC48C", Offset = "0x26FC48C", VA = "0x26FC48C", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000233")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button19
		{
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x26FC4DC", Offset = "0x26FC4DC", VA = "0x26FC4DC", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000234")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button20
		{
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x26FC52C", Offset = "0x26FC52C", VA = "0x26FC52C", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000235")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button21
		{
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x26FC57C", Offset = "0x26FC57C", VA = "0x26FC57C", Slot = "36")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000236")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button22
		{
			[Token(Token = "0x6000348")]
			[Address(RVA = "0x26FC5CC", Offset = "0x26FC5CC", VA = "0x26FC5CC", Slot = "37")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000237")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button23
		{
			[Token(Token = "0x6000349")]
			[Address(RVA = "0x26FC61C", Offset = "0x26FC61C", VA = "0x26FC61C", Slot = "38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000238")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button24
		{
			[Token(Token = "0x600034A")]
			[Address(RVA = "0x26FC66C", Offset = "0x26FC66C", VA = "0x26FC66C", Slot = "39")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000239")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button25
		{
			[Token(Token = "0x600034B")]
			[Address(RVA = "0x26FC6BC", Offset = "0x26FC6BC", VA = "0x26FC6BC", Slot = "40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700023A")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button26
		{
			[Token(Token = "0x600034C")]
			[Address(RVA = "0x26FC70C", Offset = "0x26FC70C", VA = "0x26FC70C", Slot = "41")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700023B")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button27
		{
			[Token(Token = "0x600034D")]
			[Address(RVA = "0x26FC75C", Offset = "0x26FC75C", VA = "0x26FC75C", Slot = "42")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700023C")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button28
		{
			[Token(Token = "0x600034E")]
			[Address(RVA = "0x26FC7AC", Offset = "0x26FC7AC", VA = "0x26FC7AC", Slot = "43")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700023D")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button29
		{
			[Token(Token = "0x600034F")]
			[Address(RVA = "0x26FC7FC", Offset = "0x26FC7FC", VA = "0x26FC7FC", Slot = "44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700023E")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button30
		{
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x26FC84C", Offset = "0x26FC84C", VA = "0x26FC84C", Slot = "45")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700023F")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button31
		{
			[Token(Token = "0x6000351")]
			[Address(RVA = "0x26FC89C", Offset = "0x26FC89C", VA = "0x26FC89C", Slot = "46")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000240")]
		private IControllerTemplateButton Rewired.ISixDofControllerTemplate.button32
		{
			[Token(Token = "0x6000352")]
			[Address(RVA = "0x26FC8EC", Offset = "0x26FC8EC", VA = "0x26FC8EC", Slot = "47")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000241")]
		private IControllerTemplateHat Rewired.ISixDofControllerTemplate.hat1
		{
			[Token(Token = "0x6000353")]
			[Address(RVA = "0x26FC93C", Offset = "0x26FC93C", VA = "0x26FC93C", Slot = "48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000242")]
		private IControllerTemplateHat Rewired.ISixDofControllerTemplate.hat2
		{
			[Token(Token = "0x6000354")]
			[Address(RVA = "0x26FC98C", Offset = "0x26FC98C", VA = "0x26FC98C", Slot = "49")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000243")]
		private IControllerTemplateThrottle Rewired.ISixDofControllerTemplate.throttle1
		{
			[Token(Token = "0x6000355")]
			[Address(RVA = "0x26FC9DC", Offset = "0x26FC9DC", VA = "0x26FC9DC", Slot = "50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000244")]
		private IControllerTemplateThrottle Rewired.ISixDofControllerTemplate.throttle2
		{
			[Token(Token = "0x6000356")]
			[Address(RVA = "0x26FCA2C", Offset = "0x26FCA2C", VA = "0x26FCA2C", Slot = "51")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000245")]
		private IControllerTemplateStick6D Rewired.ISixDofControllerTemplate.stick
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x26FCA7C", Offset = "0x26FCA7C", VA = "0x26FCA7C", Slot = "52")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x26FCACC", Offset = "0x26FCACC", VA = "0x26FCACC")]
		public SixDofControllerTemplate(object payload)
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB1040", Offset = "0xBB1040")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBB1040", Offset = "0xBB1040")]
	public sealed class InputManager : InputManager_Base
	{
		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		private bool ignoreRecompile;

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x19C937C", Offset = "0x19C937C", VA = "0x19C937C", Slot = "4")]
		protected override void OnInitialized()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x19C9444", Offset = "0x19C9444", VA = "0x19C9444", Slot = "5")]
		protected override void OnDeinitialized()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x19C9504", Offset = "0x19C9504", VA = "0x19C9504", Slot = "6")]
		protected override void DetectPlatform()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x19C96FC", Offset = "0x19C96FC", VA = "0x19C96FC", Slot = "7")]
		protected override void CheckRecompile()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x19C9700", Offset = "0x19C9700", VA = "0x19C9700", Slot = "8")]
		protected override IExternalTools GetExternalTools()
		{
			return null;
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x19C963C", Offset = "0x19C963C", VA = "0x19C963C")]
		private bool CheckDeviceName(string searchPattern, string deviceName, string deviceModel)
		{
			return default(bool);
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x19C9380", Offset = "0x19C9380", VA = "0x19C9380")]
		private void SubscribeEvents()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x19C9448", Offset = "0x19C9448", VA = "0x19C9448")]
		private void UnsubscribeEvents()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x19C9758", Offset = "0x19C9758", VA = "0x19C9758")]
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x19C9760", Offset = "0x19C9760", VA = "0x19C9760")]
		public InputManager()
		{
		}
	}
}
namespace Rewired.Utils
{
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0xBB1090", Offset = "0xBB1090")]
	public class ExternalTools : IExternalTools
	{
		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Func<object> _getPlatformInitializerDelegate;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool _isEditorPaused;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Action<bool> _EditorPausedStateChangedEvent;

		[Token(Token = "0x4000317")]
		private const int API_LEVEL_HONEYCOMB = 9;

		[Token(Token = "0x4000318")]
		private const int API_LEVEL_KITKAT = 19;

		[Token(Token = "0x17000246")]
		public static Func<object> getPlatformInitializerDelegate
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x19C4618", Offset = "0x19C4618", VA = "0x19C4618")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x19C4664", Offset = "0x19C4664", VA = "0x19C4664")]
			set
			{
			}
		}

		[Token(Token = "0x17000247")]
		public bool isEditorPaused
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x19C46C4", Offset = "0x19C46C4", VA = "0x19C46C4", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000248")]
		public bool UnityInput_IsTouchPressureSupported
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x19C5900", Offset = "0x19C5900", VA = "0x19C5900", Slot = "81")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000003")]
		public event Action<bool> EditorPausedStateChangedEvent
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x19C46CC", Offset = "0x19C46CC", VA = "0x19C46CC", Slot = "5")]
			add
			{
			}
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x19C4758", Offset = "0x19C4758", VA = "0x19C4758", Slot = "6")]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event Action<uint, bool> XboxOneInput_OnGamepadStateChange
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x19C4848", Offset = "0x19C4848", VA = "0x19C4848", Slot = "14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6B10", Offset = "0xBB6B10")]
			add
			{
			}
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x19C48E8", Offset = "0x19C48E8", VA = "0x19C48E8", Slot = "15")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6B20", Offset = "0xBB6B20")]
			remove
			{
			}
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x19C46B8", Offset = "0x19C46B8", VA = "0x19C46B8")]
		public ExternalTools()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x19C46C0", Offset = "0x19C46C0", VA = "0x19C46C0", Slot = "7")]
		public void Destroy()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x19C47E4", Offset = "0x19C47E4", VA = "0x19C47E4", Slot = "8")]
		public object GetPlatformInitializer()
		{
			return null;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x19C47EC", Offset = "0x19C47EC", VA = "0x19C47EC", Slot = "9")]
		public string GetFocusedEditorWindowTitle()
		{
			return null;
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x19C4838", Offset = "0x19C4838", VA = "0x19C4838", Slot = "10")]
		public bool IsEditorSceneViewFocused()
		{
			return default(bool);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x19C4840", Offset = "0x19C4840", VA = "0x19C4840", Slot = "11")]
		public bool LinuxInput_IsJoystickPreconfigured(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x19C4988", Offset = "0x19C4988", VA = "0x19C4988", Slot = "12")]
		public int XboxOneInput_GetUserIdForGamepad(uint id)
		{
			return default(int);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x19C4990", Offset = "0x19C4990", VA = "0x19C4990", Slot = "13")]
		public ulong XboxOneInput_GetControllerId(uint unityJoystickId)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x19C4998", Offset = "0x19C4998", VA = "0x19C4998", Slot = "16")]
		public bool XboxOneInput_IsGamepadActive(uint unityJoystickId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x19C49A0", Offset = "0x19C49A0", VA = "0x19C49A0", Slot = "17")]
		public string XboxOneInput_GetControllerType(ulong xboxControllerId)
		{
			return null;
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x19C49EC", Offset = "0x19C49EC", VA = "0x19C49EC", Slot = "18")]
		public uint XboxOneInput_GetJoystickId(ulong xboxControllerId)
		{
			return default(uint);
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x19C49F4", Offset = "0x19C49F4", VA = "0x19C49F4", Slot = "19")]
		public void XboxOne_Gamepad_UpdatePlugin()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x19C49F8", Offset = "0x19C49F8", VA = "0x19C49F8", Slot = "20")]
		public bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel)
		{
			return default(bool);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x19C4A00", Offset = "0x19C4A00", VA = "0x19C4A00", Slot = "21")]
		public void XboxOne_Gamepad_PulseVibrateMotor(ulong xboxOneJoystickId, int motorInt, float startLevel, float endLevel, ulong durationMS)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x19C4A04", Offset = "0x19C4A04", VA = "0x19C4A04", Slot = "22")]
		public Vector3 PS4Input_GetLastAcceleration(int id)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x19C4A0C", Offset = "0x19C4A0C", VA = "0x19C4A0C", Slot = "23")]
		public Vector3 PS4Input_GetLastGyro(int id)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x19C4A14", Offset = "0x19C4A14", VA = "0x19C4A14", Slot = "24")]
		public Vector4 PS4Input_GetLastOrientation(int id)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x19C4A1C", Offset = "0x19C4A1C", VA = "0x19C4A1C", Slot = "25")]
		public void PS4Input_GetLastTouchData(int id, out int touchNum, out int touch0x, out int touch0y, out int touch0id, out int touch1x, out int touch1y, out int touch1id)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x19C4A40", Offset = "0x19C4A40", VA = "0x19C4A40", Slot = "26")]
		public void PS4Input_GetPadControllerInformation(int id, out float touchpixelDensity, out int touchResolutionX, out int touchResolutionY, out int analogDeadZoneLeft, out int analogDeadZoneright, out int connectionType)
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x19C4A5C", Offset = "0x19C4A5C", VA = "0x19C4A5C", Slot = "27")]
		public void PS4Input_PadSetMotionSensorState(int id, bool bEnable)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x19C4A60", Offset = "0x19C4A60", VA = "0x19C4A60", Slot = "28")]
		public void PS4Input_PadSetTiltCorrectionState(int id, bool bEnable)
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x19C4A64", Offset = "0x19C4A64", VA = "0x19C4A64", Slot = "29")]
		public void PS4Input_PadSetAngularVelocityDeadbandState(int id, bool bEnable)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x19C4A68", Offset = "0x19C4A68", VA = "0x19C4A68", Slot = "30")]
		public void PS4Input_PadSetLightBar(int id, int red, int green, int blue)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x19C4A6C", Offset = "0x19C4A6C", VA = "0x19C4A6C", Slot = "31")]
		public void PS4Input_PadResetLightBar(int id)
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x19C4A70", Offset = "0x19C4A70", VA = "0x19C4A70", Slot = "32")]
		public void PS4Input_PadSetVibration(int id, int largeMotor, int smallMotor)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x19C4A74", Offset = "0x19C4A74", VA = "0x19C4A74", Slot = "33")]
		public void PS4Input_PadResetOrientation(int id)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x19C4A78", Offset = "0x19C4A78", VA = "0x19C4A78", Slot = "34")]
		public bool PS4Input_PadIsConnected(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x19C4A80", Offset = "0x19C4A80", VA = "0x19C4A80", Slot = "35")]
		public void PS4Input_GetUsersDetails(int slot, object loggedInUser)
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x19C4A84", Offset = "0x19C4A84", VA = "0x19C4A84", Slot = "36")]
		public int PS4Input_GetDeviceClassForHandle(int handle)
		{
			return default(int);
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x19C4A8C", Offset = "0x19C4A8C", VA = "0x19C4A8C", Slot = "37")]
		public string PS4Input_GetDeviceClassString(int intValue)
		{
			return null;
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x19C4A94", Offset = "0x19C4A94", VA = "0x19C4A94", Slot = "38")]
		public int PS4Input_PadGetUsersHandles2(int maxControllers, int[] handles)
		{
			return default(int);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x19C4A9C", Offset = "0x19C4A9C", VA = "0x19C4A9C", Slot = "39")]
		public void PS4Input_GetSpecialControllerInformation(int id, int padIndex, object controllerInformation)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x19C4AA0", Offset = "0x19C4AA0", VA = "0x19C4AA0", Slot = "40")]
		public Vector3 PS4Input_SpecialGetLastAcceleration(int id)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x19C4AA8", Offset = "0x19C4AA8", VA = "0x19C4AA8", Slot = "41")]
		public Vector3 PS4Input_SpecialGetLastGyro(int id)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x19C4AB0", Offset = "0x19C4AB0", VA = "0x19C4AB0", Slot = "42")]
		public Vector4 PS4Input_SpecialGetLastOrientation(int id)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x19C4AB8", Offset = "0x19C4AB8", VA = "0x19C4AB8", Slot = "43")]
		public int PS4Input_SpecialGetUsersHandles(int maxNumberControllers, int[] handles)
		{
			return default(int);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x19C4AC0", Offset = "0x19C4AC0", VA = "0x19C4AC0", Slot = "44")]
		public int PS4Input_SpecialGetUsersHandles2(int maxNumberControllers, int[] handles)
		{
			return default(int);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x19C4AC8", Offset = "0x19C4AC8", VA = "0x19C4AC8", Slot = "45")]
		public bool PS4Input_SpecialIsConnected(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x19C4AD0", Offset = "0x19C4AD0", VA = "0x19C4AD0", Slot = "46")]
		public void PS4Input_SpecialResetLightSphere(int id)
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x19C4AD4", Offset = "0x19C4AD4", VA = "0x19C4AD4", Slot = "47")]
		public void PS4Input_SpecialResetOrientation(int id)
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x19C4AD8", Offset = "0x19C4AD8", VA = "0x19C4AD8", Slot = "48")]
		public void PS4Input_SpecialSetAngularVelocityDeadbandState(int id, bool bEnable)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x19C4ADC", Offset = "0x19C4ADC", VA = "0x19C4ADC", Slot = "49")]
		public void PS4Input_SpecialSetLightSphere(int id, int red, int green, int blue)
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x19C4AE0", Offset = "0x19C4AE0", VA = "0x19C4AE0", Slot = "50")]
		public void PS4Input_SpecialSetMotionSensorState(int id, bool bEnable)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x19C4AE4", Offset = "0x19C4AE4", VA = "0x19C4AE4", Slot = "51")]
		public void PS4Input_SpecialSetTiltCorrectionState(int id, bool bEnable)
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x19C4AE8", Offset = "0x19C4AE8", VA = "0x19C4AE8", Slot = "52")]
		public void PS4Input_SpecialSetVibration(int id, int largeMotor, int smallMotor)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x19C4AEC", Offset = "0x19C4AEC", VA = "0x19C4AEC", Slot = "53")]
		public Vector3 PS4Input_AimGetLastAcceleration(int id)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x19C4AF4", Offset = "0x19C4AF4", VA = "0x19C4AF4", Slot = "54")]
		public Vector3 PS4Input_AimGetLastGyro(int id)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x19C4AFC", Offset = "0x19C4AFC", VA = "0x19C4AFC", Slot = "55")]
		public Vector4 PS4Input_AimGetLastOrientation(int id)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x19C4B04", Offset = "0x19C4B04", VA = "0x19C4B04", Slot = "56")]
		public int PS4Input_AimGetUsersHandles(int maxNumberControllers, int[] handles)
		{
			return default(int);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x19C4B0C", Offset = "0x19C4B0C", VA = "0x19C4B0C", Slot = "57")]
		public int PS4Input_AimGetUsersHandles2(int maxNumberControllers, int[] handles)
		{
			return default(int);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x19C4B14", Offset = "0x19C4B14", VA = "0x19C4B14", Slot = "58")]
		public bool PS4Input_AimIsConnected(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x19C4B1C", Offset = "0x19C4B1C", VA = "0x19C4B1C", Slot = "59")]
		public void PS4Input_AimResetLightSphere(int id)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x19C4B20", Offset = "0x19C4B20", VA = "0x19C4B20", Slot = "60")]
		public void PS4Input_AimResetOrientation(int id)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x19C4B24", Offset = "0x19C4B24", VA = "0x19C4B24", Slot = "61")]
		public void PS4Input_AimSetAngularVelocityDeadbandState(int id, bool bEnable)
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x19C4B28", Offset = "0x19C4B28", VA = "0x19C4B28", Slot = "62")]
		public void PS4Input_AimSetLightSphere(int id, int red, int green, int blue)
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x19C4B2C", Offset = "0x19C4B2C", VA = "0x19C4B2C", Slot = "63")]
		public void PS4Input_AimSetMotionSensorState(int id, bool bEnable)
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x19C4B30", Offset = "0x19C4B30", VA = "0x19C4B30", Slot = "64")]
		public void PS4Input_AimSetTiltCorrectionState(int id, bool bEnable)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x19C4B34", Offset = "0x19C4B34", VA = "0x19C4B34", Slot = "65")]
		public void PS4Input_AimSetVibration(int id, int largeMotor, int smallMotor)
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x19C4B38", Offset = "0x19C4B38", VA = "0x19C4B38", Slot = "66")]
		public Vector3 PS4Input_GetLastMoveAcceleration(int id, int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x19C4B40", Offset = "0x19C4B40", VA = "0x19C4B40", Slot = "67")]
		public Vector3 PS4Input_GetLastMoveGyro(int id, int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x19C4B48", Offset = "0x19C4B48", VA = "0x19C4B48", Slot = "68")]
		public int PS4Input_MoveGetButtons(int id, int index)
		{
			return default(int);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x19C4B50", Offset = "0x19C4B50", VA = "0x19C4B50", Slot = "69")]
		public int PS4Input_MoveGetAnalogButton(int id, int index)
		{
			return default(int);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x19C4B58", Offset = "0x19C4B58", VA = "0x19C4B58", Slot = "70")]
		public bool PS4Input_MoveIsConnected(int id, int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x19C4B60", Offset = "0x19C4B60", VA = "0x19C4B60", Slot = "71")]
		public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers, int[] primaryHandles, int[] secondaryHandles)
		{
			return default(int);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x19C4B68", Offset = "0x19C4B68", VA = "0x19C4B68", Slot = "72")]
		public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers, int[] primaryHandles)
		{
			return default(int);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x19C4B70", Offset = "0x19C4B70", VA = "0x19C4B70", Slot = "73")]
		public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers)
		{
			return default(int);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x19C4B78", Offset = "0x19C4B78", VA = "0x19C4B78", Slot = "74")]
		public IntPtr PS4Input_MoveGetControllerInputForTracking()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x19C4BB4", Offset = "0x19C4BB4", VA = "0x19C4BB4", Slot = "75")]
		public int PS4Input_MoveSetLightSphere(int id, int index, int red, int green, int blue)
		{
			return default(int);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x19C4BBC", Offset = "0x19C4BBC", VA = "0x19C4BBC", Slot = "76")]
		public int PS4Input_MoveSetVibration(int id, int index, int motor)
		{
			return default(int);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x19C4BC4", Offset = "0x19C4BC4", VA = "0x19C4BC4", Slot = "77")]
		public void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x19C54B4", Offset = "0x19C54B4", VA = "0x19C54B4", Slot = "78")]
		public int GetAndroidAPILevel()
		{
			return default(int);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x19C56E0", Offset = "0x19C56E0", VA = "0x19C56E0", Slot = "79")]
		public bool UnityUI_Graphic_GetRaycastTarget(object graphic)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x19C57E8", Offset = "0x19C57E8", VA = "0x19C57E8", Slot = "80")]
		public void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value)
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x19C5908", Offset = "0x19C5908", VA = "0x19C5908", Slot = "82")]
		public float UnityInput_GetTouchPressure(ref Touch touch)
		{
			return default(float);
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x19C5914", Offset = "0x19C5914", VA = "0x19C5914", Slot = "83")]
		public float UnityInput_GetTouchMaximumPossiblePressure(ref Touch touch)
		{
			return default(float);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x19C5920", Offset = "0x19C5920", VA = "0x19C5920", Slot = "84")]
		public IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload)
		{
			return null;
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x19C5998", Offset = "0x19C5998", VA = "0x19C5998", Slot = "85")]
		public Type[] GetControllerTemplateTypes()
		{
			return null;
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x19C5A34", Offset = "0x19C5A34", VA = "0x19C5A34", Slot = "86")]
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
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public int id;

				[Token(Token = "0x4000710")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public bool hasKeyboard;

				[Token(Token = "0x4000711")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
				public bool hasMouse;

				[Token(Token = "0x4000712")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public JoystickInfo[] joysticks;

				[Token(Token = "0x17000372")]
				public int joystickCount
				{
					[Token(Token = "0x6000A15")]
					[Address(RVA = "0x26B2A0C", Offset = "0x26B2A0C", VA = "0x26B2A0C")]
					get
					{
						return default(int);
					}
				}

				[Token(Token = "0x6000A16")]
				[Address(RVA = "0x26B2A24", Offset = "0x26B2A24", VA = "0x26B2A24")]
				public int IndexOfJoystick(int joystickId)
				{
					return default(int);
				}

				[Token(Token = "0x6000A17")]
				[Address(RVA = "0x26B2A9C", Offset = "0x26B2A9C", VA = "0x26B2A9C")]
				public bool ContainsJoystick(int joystickId)
				{
					return default(bool);
				}

				[Token(Token = "0x6000A18")]
				[Address(RVA = "0x26AEEA4", Offset = "0x26AEEA4", VA = "0x26AEEA4")]
				public PlayerInfo()
				{
				}
			}

			[Token(Token = "0x200010C")]
			public class JoystickInfo
			{
				[Token(Token = "0x4000713")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public Guid instanceGuid;

				[Token(Token = "0x4000714")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public string hardwareIdentifier;

				[Token(Token = "0x4000715")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public int id;

				[Token(Token = "0x6000A19")]
				[Address(RVA = "0x26B2A04", Offset = "0x26B2A04", VA = "0x26B2A04")]
				public JoystickInfo()
				{
				}
			}

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PlayerInfo[] players;

			[Token(Token = "0x1700031E")]
			public int playerCount
			{
				[Token(Token = "0x60008CB")]
				[Address(RVA = "0x26AED54", Offset = "0x26AED54", VA = "0x26AED54")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x60008CC")]
			[Address(RVA = "0x26AED6C", Offset = "0x26AED6C", VA = "0x26AED6C")]
			public ControllerAssignmentSaveInfo()
			{
			}

			[Token(Token = "0x60008CD")]
			[Address(RVA = "0x26AED74", Offset = "0x26AED74", VA = "0x26AED74")]
			public ControllerAssignmentSaveInfo(int playerCount)
			{
			}

			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x26AEEAC", Offset = "0x26AEEAC", VA = "0x26AEEAC")]
			public int IndexOfPlayer(int playerId)
			{
				return default(int);
			}

			[Token(Token = "0x60008CF")]
			[Address(RVA = "0x26AEF24", Offset = "0x26AEF24", VA = "0x26AEF24")]
			public bool ContainsPlayer(int playerId)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000A1")]
		private class JoystickAssignmentHistoryInfo
		{
			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly Joystick joystick;

			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public readonly int oldJoystickId;

			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x26AEF40", Offset = "0x26AEF40", VA = "0x26AEF40")]
			public JoystickAssignmentHistoryInfo(Joystick joystick, int oldJoystickId)
			{
			}
		}

		[Token(Token = "0x20000A2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB196C", Offset = "0xBB196C")]
		private sealed class <>c__DisplayClass78_0
		{
			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Joystick joystick;

			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x26AEAF0", Offset = "0x26AEAF0", VA = "0x26AEAF0")]
			public <>c__DisplayClass78_0()
			{
			}

			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x26AEAF8", Offset = "0x26AEAF8", VA = "0x26AEAF8")]
			internal bool <LoadJoystickAssignmentsNow>b__0(JoystickAssignmentHistoryInfo x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB197C", Offset = "0xBB197C")]
		private sealed class <>c__DisplayClass78_1
		{
			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ControllerAssignmentSaveInfo.JoystickInfo joystickInfo;

			[Token(Token = "0x60008D3")]
			[Address(RVA = "0x26AEB1C", Offset = "0x26AEB1C", VA = "0x26AEB1C")]
			public <>c__DisplayClass78_1()
			{
			}

			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x26AEB24", Offset = "0x26AEB24", VA = "0x26AEB24")]
			internal bool <LoadJoystickAssignmentsNow>b__1(JoystickAssignmentHistoryInfo x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB198C", Offset = "0xBB198C")]
		private sealed class <>c__DisplayClass78_2
		{
			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Joystick match;

			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x26AEB54", Offset = "0x26AEB54", VA = "0x26AEB54")]
			public <>c__DisplayClass78_2()
			{
			}

			[Token(Token = "0x60008D6")]
			[Address(RVA = "0x26AEB5C", Offset = "0x26AEB5C", VA = "0x26AEB5C")]
			internal bool <LoadJoystickAssignmentsNow>b__2(JoystickAssignmentHistoryInfo x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000A5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB199C", Offset = "0xBB199C")]
		private sealed class <LoadJoystickAssignmentsDeferred>d__80 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UserDataStore_PlayerPrefs <>4__this;

			[Token(Token = "0x1700031F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008DA")]
				[Address(RVA = "0x26AED04", Offset = "0x26AED04", VA = "0x26AED04", Slot = "4")]
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
				[Address(RVA = "0x26AED4C", Offset = "0x26AED4C", VA = "0x26AED4C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x26AEB80", Offset = "0x26AEB80", VA = "0x26AEB80")]
			[DebuggerHidden]
			public <LoadJoystickAssignmentsDeferred>d__80(int <>1__state)
			{
			}

			[Token(Token = "0x60008D8")]
			[Address(RVA = "0x26AEBAC", Offset = "0x26AEBAC", VA = "0x26AEBAC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008D9")]
			[Address(RVA = "0x26AEBB0", Offset = "0x26AEBB0", VA = "0x26AEBB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008DB")]
			[Address(RVA = "0x26AED0C", Offset = "0x26AED0C", VA = "0x26AED0C", Slot = "8")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB22B4", Offset = "0xBB22B4")]
		[SerializeField]
		private bool isEnabled;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB2300", Offset = "0xBB2300")]
		[SerializeField]
		private bool loadDataOnStart;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB234C", Offset = "0xBB234C")]
		[SerializeField]
		private bool loadJoystickAssignments;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB2398", Offset = "0xBB2398")]
		[SerializeField]
		private bool loadKeyboardAssignments;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB23E4", Offset = "0xBB23E4")]
		[SerializeField]
		private bool loadMouseAssignments;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB2430", Offset = "0xBB2430")]
		[SerializeField]
		private string playerPrefsKeyPrefix;

		[NonSerialized]
		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool allowImpreciseJoystickAssignmentMatching;

		[NonSerialized]
		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool deferredJoystickAssignmentLoadPending;

		[NonSerialized]
		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		private bool wasJoystickEverDetected;

		[NonSerialized]
		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<int> __allActionIds;

		[NonSerialized]
		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string __allActionIdsString;

		[Token(Token = "0x17000249")]
		public bool IsEnabled
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x1FA8184", Offset = "0x1FA8184", VA = "0x1FA8184")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x1FA818C", Offset = "0x1FA818C", VA = "0x1FA818C")]
			set
			{
			}
		}

		[Token(Token = "0x1700024A")]
		public bool LoadDataOnStart
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x1FA8198", Offset = "0x1FA8198", VA = "0x1FA8198")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x1FA81A0", Offset = "0x1FA81A0", VA = "0x1FA81A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700024B")]
		public bool LoadJoystickAssignments
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x1FA81AC", Offset = "0x1FA81AC", VA = "0x1FA81AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x1FA81B4", Offset = "0x1FA81B4", VA = "0x1FA81B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700024C")]
		public bool LoadKeyboardAssignments
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x1FA81C0", Offset = "0x1FA81C0", VA = "0x1FA81C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x1FA81C8", Offset = "0x1FA81C8", VA = "0x1FA81C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700024D")]
		public bool LoadMouseAssignments
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x1FA81D4", Offset = "0x1FA81D4", VA = "0x1FA81D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x1FA81DC", Offset = "0x1FA81DC", VA = "0x1FA81DC")]
			set
			{
			}
		}

		[Token(Token = "0x1700024E")]
		public string PlayerPrefsKeyPrefix
		{
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x1FA81E8", Offset = "0x1FA81E8", VA = "0x1FA81E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x1FA81F0", Offset = "0x1FA81F0", VA = "0x1FA81F0")]
			set
			{
			}
		}

		[Token(Token = "0x1700024F")]
		private string playerPrefsKey_controllerAssignments
		{
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x1FA81F8", Offset = "0x1FA81F8", VA = "0x1FA81F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000250")]
		private bool loadControllerAssignments
		{
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x1FA8260", Offset = "0x1FA8260", VA = "0x1FA8260")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000251")]
		private List<int> allActionIds
		{
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x1FA8288", Offset = "0x1FA8288", VA = "0x1FA8288")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000252")]
		private string allActionIdsString
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x1FA84A0", Offset = "0x1FA84A0", VA = "0x1FA84A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x1FA85EC", Offset = "0x1FA85EC", VA = "0x1FA85EC", Slot = "21")]
		public override void Save()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x1FA8844", Offset = "0x1FA8844", VA = "0x1FA8844", Slot = "22")]
		public override void SaveControllerData(int playerId, ControllerType controllerType, int controllerId)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x1FA8958", Offset = "0x1FA8958", VA = "0x1FA8958", Slot = "23")]
		public override void SaveControllerData(ControllerType controllerType, int controllerId)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x1FA8A38", Offset = "0x1FA8A38", VA = "0x1FA8A38", Slot = "24")]
		public override void SavePlayerData(int playerId)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x1FA8B74", Offset = "0x1FA8B74", VA = "0x1FA8B74", Slot = "25")]
		public override void SaveInputBehavior(int playerId, int behaviorId)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x1FA8D1C", Offset = "0x1FA8D1C", VA = "0x1FA8D1C", Slot = "16")]
		public override void Load()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x1FA8F84", Offset = "0x1FA8F84", VA = "0x1FA8F84", Slot = "17")]
		public override void LoadControllerData(int playerId, ControllerType controllerType, int controllerId)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x1FA90B0", Offset = "0x1FA90B0", VA = "0x1FA90B0", Slot = "18")]
		public override void LoadControllerData(ControllerType controllerType, int controllerId)
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x1FA918C", Offset = "0x1FA918C", VA = "0x1FA918C", Slot = "19")]
		public override void LoadPlayerData(int playerId)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x1FA92C0", Offset = "0x1FA92C0", VA = "0x1FA92C0", Slot = "20")]
		public override void LoadInputBehavior(int playerId, int behaviorId)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1FA9464", Offset = "0x1FA9464", VA = "0x1FA9464", Slot = "28")]
		protected override void OnInitialize()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x1FA9AFC", Offset = "0x1FA9AFC", VA = "0x1FA9AFC", Slot = "29")]
		protected override void OnControllerConnected(ControllerStatusChangedEventArgs args)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1FA9E0C", Offset = "0x1FA9E0C", VA = "0x1FA9E0C", Slot = "32")]
		protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1FAA020", Offset = "0x1FAA020", VA = "0x1FAA020", Slot = "30")]
		protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1FAA048", Offset = "0x1FAA048", VA = "0x1FAA048", Slot = "26")]
		public override void SaveControllerMap(int playerId, ControllerMap controllerMap)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1FAA220", Offset = "0x1FAA220", VA = "0x1FAA220", Slot = "27")]
		public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			return null;
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x1FA8DB0", Offset = "0x1FA8DB0", VA = "0x1FA8DB0")]
		private int LoadAll()
		{
			return default(int);
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x1FA9234", Offset = "0x1FA9234", VA = "0x1FA9234")]
		private int LoadPlayerDataNow(int playerId)
		{
			return default(int);
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x1FAA508", Offset = "0x1FAA508", VA = "0x1FAA508")]
		private int LoadPlayerDataNow(Player player)
		{
			return default(int);
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x1FAA898", Offset = "0x1FAA898", VA = "0x1FAA898")]
		private int LoadAllJoystickCalibrationData()
		{
			return default(int);
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x1FAB10C", Offset = "0x1FAB10C", VA = "0x1FAB10C")]
		private int LoadJoystickCalibrationData(Joystick joystick)
		{
			return default(int);
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x1FAB1DC", Offset = "0x1FAB1DC", VA = "0x1FAB1DC")]
		private int LoadJoystickCalibrationData(int joystickId)
		{
			return default(int);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1FA9B8C", Offset = "0x1FA9B8C", VA = "0x1FA9B8C")]
		private int LoadJoystickData(int joystickId)
		{
			return default(int);
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x1FA9048", Offset = "0x1FA9048", VA = "0x1FA9048")]
		private int LoadControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
		{
			return default(int);
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1FA9174", Offset = "0x1FA9174", VA = "0x1FA9174")]
		private int LoadControllerDataNow(ControllerType controllerType, int controllerId)
		{
			return default(int);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x1FAAC48", Offset = "0x1FAAC48", VA = "0x1FAAC48")]
		private int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId)
		{
			return default(int);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x1FAA2EC", Offset = "0x1FAA2EC", VA = "0x1FAA2EC")]
		private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			return null;
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x1FAAA3C", Offset = "0x1FAAA3C", VA = "0x1FAAA3C")]
		private int LoadInputBehaviors(int playerId)
		{
			return default(int);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x1FA9370", Offset = "0x1FA9370", VA = "0x1FA9370")]
		private int LoadInputBehaviorNow(int playerId, int behaviorId)
		{
			return default(int);
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x1FABB64", Offset = "0x1FABB64", VA = "0x1FABB64")]
		private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior)
		{
			return default(int);
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x1FAA42C", Offset = "0x1FAA42C", VA = "0x1FAA42C")]
		private bool LoadControllerAssignmentsNow()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1FABE00", Offset = "0x1FABE00", VA = "0x1FABE00")]
		private bool LoadKeyboardAndMouseAssignmentsNow(ControllerAssignmentSaveInfo data)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x1FAC2B8", Offset = "0x1FAC2B8", VA = "0x1FAC2B8")]
		private bool LoadJoystickAssignmentsNow(ControllerAssignmentSaveInfo data)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x1FABCA4", Offset = "0x1FABCA4", VA = "0x1FABCA4")]
		private ControllerAssignmentSaveInfo LoadControllerAssignmentData()
		{
			return null;
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1FA9D94", Offset = "0x1FA9D94", VA = "0x1FA9D94")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBB6B30", Offset = "0xBB6B30")]
		private IEnumerator LoadJoystickAssignmentsDeferred()
		{
			return null;
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1FA8680", Offset = "0x1FA8680", VA = "0x1FA8680")]
		private void SaveAll()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x1FA8AE0", Offset = "0x1FA8AE0", VA = "0x1FA8AE0")]
		private void SavePlayerDataNow(int playerId)
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x1FAD9C8", Offset = "0x1FAD9C8", VA = "0x1FAD9C8")]
		private void SavePlayerDataNow(Player player)
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x1FADA64", Offset = "0x1FADA64", VA = "0x1FADA64")]
		private void SaveAllJoystickCalibrationData()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1FADFE8", Offset = "0x1FADFE8", VA = "0x1FADFE8")]
		private void SaveJoystickCalibrationData(int joystickId)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1FADF68", Offset = "0x1FADF68", VA = "0x1FADF68")]
		private void SaveJoystickCalibrationData(Joystick joystick)
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1FA9E3C", Offset = "0x1FA9E3C", VA = "0x1FA9E3C")]
		private void SaveJoystickData(int joystickId)
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1FA8908", Offset = "0x1FA8908", VA = "0x1FA8908")]
		private void SaveControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1FA8A14", Offset = "0x1FA8A14", VA = "0x1FA8A14")]
		private void SaveControllerDataNow(ControllerType controllerType, int controllerId)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x1FADC88", Offset = "0x1FADC88", VA = "0x1FADC88")]
		private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData)
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x1FAE1F4", Offset = "0x1FAE1F4", VA = "0x1FAE1F4")]
		private void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1FAA0F4", Offset = "0x1FAA0F4", VA = "0x1FAA0F4")]
		private void SaveControllerMap(Player player, ControllerMap controllerMap)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1FADBFC", Offset = "0x1FADBFC", VA = "0x1FADBFC")]
		private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1FA8C24", Offset = "0x1FA8C24", VA = "0x1FA8C24")]
		private void SaveInputBehaviorNow(int playerId, int behaviorId)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1FAE4C0", Offset = "0x1FAE4C0", VA = "0x1FAE4C0")]
		private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1FA952C", Offset = "0x1FA952C", VA = "0x1FA952C")]
		private bool SaveControllerAssignments()
		{
			return default(bool);
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1FAE5B8", Offset = "0x1FAE5B8", VA = "0x1FAE5B8")]
		private bool ControllerAssignmentSaveDataExists()
		{
			return default(bool);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1FAE60C", Offset = "0x1FAE60C", VA = "0x1FAE60C")]
		private string GetBasePlayerPrefsKey(Player player)
		{
			return null;
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1FAE330", Offset = "0x1FAE330", VA = "0x1FAE330")]
		private string GetControllerMapPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
		{
			return null;
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1FAE3F8", Offset = "0x1FAE3F8", VA = "0x1FAE3F8")]
		private string GetControllerMapKnownActionIdsPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
		{
			return null;
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1FAE684", Offset = "0x1FAE684", VA = "0x1FAE684")]
		private static string GetControllerMapPlayerPrefsKeyCommonSuffix(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
		{
			return null;
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1FAE074", Offset = "0x1FAE074", VA = "0x1FAE074")]
		private string GetJoystickCalibrationMapPlayerPrefsKey(Joystick joystick)
		{
			return null;
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1FAE514", Offset = "0x1FAE514", VA = "0x1FAE514")]
		private string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId)
		{
			return null;
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x1FAB268", Offset = "0x1FAB268", VA = "0x1FAB268")]
		private string GetControllerMapXml(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			return null;
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x1FAB328", Offset = "0x1FAB328", VA = "0x1FAB328")]
		private List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			return null;
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1FAB14C", Offset = "0x1FAB14C", VA = "0x1FAB14C")]
		private string GetJoystickCalibrationMapXml(Joystick joystick)
		{
			return null;
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x1FABC0C", Offset = "0x1FABC0C", VA = "0x1FABC0C")]
		private string GetInputBehaviorXml(Player player, int id)
		{
			return null;
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1FAB520", Offset = "0x1FAB520", VA = "0x1FAB520")]
		private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1FAD42C", Offset = "0x1FAD42C", VA = "0x1FAD42C")]
		private Joystick FindJoystickPrecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo)
		{
			return null;
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1FAD6EC", Offset = "0x1FAD6EC", VA = "0x1FAD6EC")]
		private bool TryFindJoysticksImprecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Joystick> matches)
		{
			return default(bool);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x1FAECC8", Offset = "0x1FAECC8", VA = "0x1FAECC8")]
		private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier)
		{
			return default(int);
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x1FAB068", Offset = "0x1FAB068", VA = "0x1FAB068")]
		private void RefreshLayoutManager(int playerId)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x1FAEAEC", Offset = "0x1FAEAEC", VA = "0x1FAEAEC")]
		private static Type GetControllerMapType(ControllerType controllerType)
		{
			return null;
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x1FAF238", Offset = "0x1FAF238", VA = "0x1FAF238")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Type[] _defaultTemplateInterfaceTypes;

		[Token(Token = "0x17000253")]
		public static Type[] templateTypes
		{
			[Token(Token = "0x600040F")]
			[Address(RVA = "0x19BFC00", Offset = "0x19BFC00", VA = "0x19BFC00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000254")]
		public static Type[] templateInterfaceTypes
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x19BFC64", Offset = "0x19BFC64", VA = "0x19BFC64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x19BFCC8", Offset = "0x19BFCC8", VA = "0x19BFCC8")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB247C", Offset = "0xBB247C")]
		private int <playerId>k__BackingField;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB248C", Offset = "0xBB248C")]
		private int <inputSourceIndex>k__BackingField;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB249C", Offset = "0xBB249C")]
		private IMouseInputSource <mouseSource>k__BackingField;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB24AC", Offset = "0xBB24AC")]
		private ITouchInputSource <touchSource>k__BackingField;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB24BC", Offset = "0xBB24BC")]
		private PointerEventType <sourceType>k__BackingField;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB24CC", Offset = "0xBB24CC")]
		private int <buttonIndex>k__BackingField;

		[Token(Token = "0x17000255")]
		public int playerId
		{
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x210A1A8", Offset = "0x210A1A8", VA = "0x210A1A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6B90", Offset = "0xBB6B90")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000414")]
			[Address(RVA = "0x210A1B0", Offset = "0x210A1B0", VA = "0x210A1B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6BA0", Offset = "0xBB6BA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000256")]
		public int inputSourceIndex
		{
			[Token(Token = "0x6000415")]
			[Address(RVA = "0x210A1B8", Offset = "0x210A1B8", VA = "0x210A1B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6BB0", Offset = "0xBB6BB0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000416")]
			[Address(RVA = "0x210A1C0", Offset = "0x210A1C0", VA = "0x210A1C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6BC0", Offset = "0xBB6BC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000257")]
		public IMouseInputSource mouseSource
		{
			[Token(Token = "0x6000417")]
			[Address(RVA = "0x210A1C8", Offset = "0x210A1C8", VA = "0x210A1C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6BD0", Offset = "0xBB6BD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000418")]
			[Address(RVA = "0x210A1D0", Offset = "0x210A1D0", VA = "0x210A1D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6BE0", Offset = "0xBB6BE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000258")]
		public ITouchInputSource touchSource
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0x210A1E0", Offset = "0x210A1E0", VA = "0x210A1E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6BF0", Offset = "0xBB6BF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600041A")]
			[Address(RVA = "0x210A1E8", Offset = "0x210A1E8", VA = "0x210A1E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6C00", Offset = "0xBB6C00")]
			set
			{
			}
		}

		[Token(Token = "0x17000259")]
		public PointerEventType sourceType
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x210A1F8", Offset = "0x210A1F8", VA = "0x210A1F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6C10", Offset = "0xBB6C10")]
			get
			{
				return default(PointerEventType);
			}
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x210A200", Offset = "0x210A200", VA = "0x210A200")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6C20", Offset = "0xBB6C20")]
			set
			{
			}
		}

		[Token(Token = "0x1700025A")]
		public int buttonIndex
		{
			[Token(Token = "0x600041D")]
			[Address(RVA = "0x210A208", Offset = "0x210A208", VA = "0x210A208")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6C30", Offset = "0xBB6C30")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600041E")]
			[Address(RVA = "0x210A210", Offset = "0x210A210", VA = "0x210A210")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6C40", Offset = "0xBB6C40")]
			set
			{
			}
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x210A218", Offset = "0x210A218", VA = "0x210A218")]
		public PlayerPointerEventData(EventSystem eventSystem)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x210A24C", Offset = "0x210A24C", VA = "0x210A24C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB10A4", Offset = "0xBB10A4")]
	public class RewiredEventSystem : EventSystem
	{
		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB24DC", Offset = "0xBB24DC")]
		[SerializeField]
		private bool _alwaysUpdate;

		[Token(Token = "0x1700025B")]
		public bool alwaysUpdate
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x210C364", Offset = "0x210C364", VA = "0x210C364")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x210C36C", Offset = "0x210C36C", VA = "0x210C36C")]
			set
			{
			}
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x210C378", Offset = "0x210C378", VA = "0x210C378", Slot = "18")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x210C538", Offset = "0x210C538", VA = "0x210C538")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private List<ButtonState> m_TrackedButtons;

			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x26A7C8C", Offset = "0x26A7C8C", VA = "0x26A7C8C")]
			public bool AnyPressesThisFrame()
			{
				return default(bool);
			}

			[Token(Token = "0x60008DE")]
			[Address(RVA = "0x26A7D48", Offset = "0x26A7D48", VA = "0x26A7D48")]
			public bool AnyReleasesThisFrame()
			{
				return default(bool);
			}

			[Token(Token = "0x60008DF")]
			[Address(RVA = "0x26A7E04", Offset = "0x26A7E04", VA = "0x26A7E04")]
			public ButtonState GetButtonState(int button)
			{
				return null;
			}

			[Token(Token = "0x60008E0")]
			[Address(RVA = "0x26A7F74", Offset = "0x26A7F74", VA = "0x26A7F74")]
			public void SetButtonState(int button, PointerEventData.FramePressState stateForMouseButton, PlayerPointerEventData data)
			{
			}

			[Token(Token = "0x60008E1")]
			[Address(RVA = "0x26A7FBC", Offset = "0x26A7FBC", VA = "0x26A7FBC")]
			public MouseState()
			{
			}
		}

		[Token(Token = "0x20000A7")]
		public class MouseButtonEventData
		{
			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PointerEventData.FramePressState buttonState;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PlayerPointerEventData buttonData;

			[Token(Token = "0x60008E2")]
			[Address(RVA = "0x26A7C5C", Offset = "0x26A7C5C", VA = "0x26A7C5C")]
			public bool PressedThisFrame()
			{
				return default(bool);
			}

			[Token(Token = "0x60008E3")]
			[Address(RVA = "0x26A7C70", Offset = "0x26A7C70", VA = "0x26A7C70")]
			public bool ReleasedThisFrame()
			{
				return default(bool);
			}

			[Token(Token = "0x60008E4")]
			[Address(RVA = "0x26A7C84", Offset = "0x26A7C84", VA = "0x26A7C84")]
			public MouseButtonEventData()
			{
			}
		}

		[Token(Token = "0x20000A8")]
		protected class ButtonState
		{
			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int m_Button;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private MouseButtonEventData m_EventData;

			[Token(Token = "0x17000321")]
			public MouseButtonEventData eventData
			{
				[Token(Token = "0x60008E5")]
				[Address(RVA = "0x26A7C34", Offset = "0x26A7C34", VA = "0x26A7C34")]
				get
				{
					return null;
				}
				[Token(Token = "0x60008E6")]
				[Address(RVA = "0x26A7C3C", Offset = "0x26A7C3C", VA = "0x26A7C3C")]
				set
				{
				}
			}

			[Token(Token = "0x17000322")]
			public int button
			{
				[Token(Token = "0x60008E7")]
				[Address(RVA = "0x26A7C44", Offset = "0x26A7C44", VA = "0x26A7C44")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60008E8")]
				[Address(RVA = "0x26A7C4C", Offset = "0x26A7C4C", VA = "0x26A7C4C")]
				set
				{
				}
			}

			[Token(Token = "0x60008E9")]
			[Address(RVA = "0x26A7C54", Offset = "0x26A7C54", VA = "0x26A7C54")]
			public ButtonState()
			{
			}
		}

		[Token(Token = "0x20000A9")]
		private sealed class UnityInputSource : IMouseInputSource, ITouchInputSource
		{
			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Vector2 m_MousePosition;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector2 m_MousePositionPrev;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_LastUpdatedFrame;

			[Token(Token = "0x17000323")]
			private int Rewired.UI.IMouseInputSource.playerId
			{
				[Token(Token = "0x60008EA")]
				[Address(RVA = "0x26A8040", Offset = "0x26A8040", VA = "0x26A8040", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000324")]
			private int Rewired.UI.ITouchInputSource.playerId
			{
				[Token(Token = "0x60008EB")]
				[Address(RVA = "0x26A80A8", Offset = "0x26A80A8", VA = "0x26A80A8", Slot = "14")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000325")]
			private bool Rewired.UI.IMouseInputSource.enabled
			{
				[Token(Token = "0x60008EC")]
				[Address(RVA = "0x26A80C0", Offset = "0x26A80C0", VA = "0x26A80C0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000326")]
			private bool Rewired.UI.IMouseInputSource.locked
			{
				[Token(Token = "0x60008ED")]
				[Address(RVA = "0x26A80D8", Offset = "0x26A80D8", VA = "0x26A80D8", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000327")]
			private int Rewired.UI.IMouseInputSource.buttonCount
			{
				[Token(Token = "0x60008EE")]
				[Address(RVA = "0x26A80FC", Offset = "0x26A80FC", VA = "0x26A80FC", Slot = "7")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000328")]
			private Vector2 Rewired.UI.IMouseInputSource.screenPosition
			{
				[Token(Token = "0x60008F2")]
				[Address(RVA = "0x26A818C", Offset = "0x26A818C", VA = "0x26A818C", Slot = "11")]
				get
				{
					return default(Vector2);
				}
			}

			[Token(Token = "0x17000329")]
			private Vector2 Rewired.UI.IMouseInputSource.screenPositionDelta
			{
				[Token(Token = "0x60008F3")]
				[Address(RVA = "0x26A81A4", Offset = "0x26A81A4", VA = "0x26A81A4", Slot = "12")]
				get
				{
					return default(Vector2);
				}
			}

			[Token(Token = "0x1700032A")]
			private Vector2 Rewired.UI.IMouseInputSource.wheelDelta
			{
				[Token(Token = "0x60008F4")]
				[Address(RVA = "0x26A81D0", Offset = "0x26A81D0", VA = "0x26A81D0", Slot = "13")]
				get
				{
					return default(Vector2);
				}
			}

			[Token(Token = "0x1700032B")]
			private bool Rewired.UI.ITouchInputSource.touchSupported
			{
				[Token(Token = "0x60008F5")]
				[Address(RVA = "0x26A81E8", Offset = "0x26A81E8", VA = "0x26A81E8", Slot = "15")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700032C")]
			private int Rewired.UI.ITouchInputSource.touchCount
			{
				[Token(Token = "0x60008F6")]
				[Address(RVA = "0x26A8200", Offset = "0x26A8200", VA = "0x26A8200", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x60008EF")]
			[Address(RVA = "0x26A8114", Offset = "0x26A8114", VA = "0x26A8114", Slot = "8")]
			private bool Rewired.UI.IMouseInputSource.GetButtonDown(int button)
			{
				return default(bool);
			}

			[Token(Token = "0x60008F0")]
			[Address(RVA = "0x26A813C", Offset = "0x26A813C", VA = "0x26A813C", Slot = "9")]
			private bool Rewired.UI.IMouseInputSource.GetButtonUp(int button)
			{
				return default(bool);
			}

			[Token(Token = "0x60008F1")]
			[Address(RVA = "0x26A8164", Offset = "0x26A8164", VA = "0x26A8164", Slot = "10")]
			private bool Rewired.UI.IMouseInputSource.GetButton(int button)
			{
				return default(bool);
			}

			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x26A8218", Offset = "0x26A8218", VA = "0x26A8218", Slot = "17")]
			private Touch Rewired.UI.ITouchInputSource.GetTouch(int index)
			{
				return default(Touch);
			}

			[Token(Token = "0x60008F8")]
			[Address(RVA = "0x26A8058", Offset = "0x26A8058", VA = "0x26A8058")]
			private void TryUpdate()
			{
			}

			[Token(Token = "0x60008F9")]
			[Address(RVA = "0x26A8264", Offset = "0x26A8264", VA = "0x26A8264")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly List<IMouseInputSource> m_MouseInputSourcesList;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<int, Dictionary<int, PlayerPointerEventData>[]> m_PlayerPointerData;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ITouchInputSource m_UserDefaultTouchInputSource;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private UnityInputSource __m_DefaultInputSource;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly MouseState m_MouseState;

		[Token(Token = "0x1700025C")]
		private UnityInputSource defaultInputSource
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x210C59C", Offset = "0x210C59C", VA = "0x210C59C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700025D")]
		private IMouseInputSource defaultMouseInputSource
		{
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x210C610", Offset = "0x210C610", VA = "0x210C610")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700025E")]
		protected ITouchInputSource defaultTouchInputSource
		{
			[Token(Token = "0x6000427")]
			[Address(RVA = "0x210C614", Offset = "0x210C614", VA = "0x210C614")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700025F")]
		protected virtual bool isMouseSupported
		{
			[Token(Token = "0x6000432")]
			[Address(RVA = "0x210CE50", Offset = "0x210CE50", VA = "0x210CE50", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x210C618", Offset = "0x210C618", VA = "0x210C618")]
		protected bool IsDefaultMouse(IMouseInputSource mouse)
		{
			return default(bool);
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x210C640", Offset = "0x210C640", VA = "0x210C640")]
		public IMouseInputSource GetMouseInputSource(int playerId, int mouseIndex)
		{
			return null;
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x210C874", Offset = "0x210C874", VA = "0x210C874")]
		public void RemoveMouseInputSource(IMouseInputSource source)
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x210C924", Offset = "0x210C924", VA = "0x210C924")]
		public void AddMouseInputSource(IMouseInputSource source)
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x210CA20", Offset = "0x210CA20", VA = "0x210CA20")]
		public int GetMouseInputSourceCount(int playerId)
		{
			return default(int);
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x210CBF0", Offset = "0x210CBF0", VA = "0x210CBF0")]
		public ITouchInputSource GetTouchInputSource(int playerId, int sourceIndex)
		{
			return null;
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x210CC84", Offset = "0x210CC84", VA = "0x210CC84")]
		public void RemoveTouchInputSource(ITouchInputSource source)
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x210CCF8", Offset = "0x210CCF8", VA = "0x210CCF8")]
		public void AddTouchInputSource(ITouchInputSource source)
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x210CDD8", Offset = "0x210CDD8", VA = "0x210CDD8")]
		public int GetTouchInputSourceCount(int playerId)
		{
			return default(int);
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x210CDFC", Offset = "0x210CDFC", VA = "0x210CDFC")]
		protected void ClearMouseInputSources()
		{
		}

		[Token(Token = "0x6000433")]
		protected abstract bool IsDefaultPlayer(int playerId);

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x210D018", Offset = "0x210D018", VA = "0x210D018")]
		protected bool GetPointerData(int playerId, int pointerIndex, int pointerTypeId, out PlayerPointerEventData data, bool create, PointerEventType pointerEventType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x210D440", Offset = "0x210D440", VA = "0x210D440")]
		private PlayerPointerEventData CreatePointerEventData(int playerId, int pointerIndex, int pointerTypeId, PointerEventType pointerEventType)
		{
			return null;
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x210D55C", Offset = "0x210D55C", VA = "0x210D55C")]
		protected void RemovePointerData(PlayerPointerEventData data)
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x210D618", Offset = "0x210D618", VA = "0x210D618")]
		protected PlayerPointerEventData GetTouchPointerEventData(int playerId, int touchDeviceIndex, Touch input, out bool pressed, out bool released)
		{
			return null;
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x210D85C", Offset = "0x210D85C", VA = "0x210D85C", Slot = "28")]
		protected virtual MouseState GetMousePointerEventData(int playerId, int mouseIndex)
		{
			return null;
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x210E0E0", Offset = "0x210E0E0", VA = "0x210E0E0")]
		protected PlayerPointerEventData GetLastPointerEventData(int playerId, int pointerIndex, int pointerTypeId, bool ignorePointerTypeId, PointerEventType pointerEventType)
		{
			return null;
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x210E2A0", Offset = "0x210E2A0", VA = "0x210E2A0")]
		private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
		{
			return default(bool);
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x210E2F0", Offset = "0x210E2F0", VA = "0x210E2F0", Slot = "29")]
		protected virtual void ProcessMove(PlayerPointerEventData pointerEvent)
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x210E48C", Offset = "0x210E48C", VA = "0x210E48C", Slot = "30")]
		protected virtual void ProcessDrag(PlayerPointerEventData pointerEvent)
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x210E890", Offset = "0x210E890", VA = "0x210E890", Slot = "20")]
		public override bool IsPointerOverGameObject(int pointerTypeId)
		{
			return default(bool);
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x210EADC", Offset = "0x210EADC", VA = "0x210EADC")]
		protected void ClearSelection()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x210EE74", Offset = "0x210EE74", VA = "0x210EE74", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x210F354", Offset = "0x210F354", VA = "0x210F354")]
		protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x210DEF0", Offset = "0x210DEF0", VA = "0x210DEF0")]
		protected void CopyFromTo(PointerEventData from, PointerEventData to)
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x210DF68", Offset = "0x210DF68", VA = "0x210DF68")]
		protected PointerEventData.FramePressState StateForMouseButton(int playerId, int mouseIndex, int buttonId)
		{
			return default(PointerEventData.FramePressState);
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x210F458", Offset = "0x210F458", VA = "0x210F458")]
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
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB10DC", Offset = "0xBB10DC")]
	public sealed class RewiredStandaloneInputModule : RewiredPointerInputModule
	{
		[Serializable]
		[Token(Token = "0x20000AA")]
		public class PlayerSetting
		{
			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int playerId;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<Rewired.Components.PlayerMouse> playerMice;

			[Token(Token = "0x60008FA")]
			[Address(RVA = "0x26A8274", Offset = "0x26A8274", VA = "0x26A8274")]
			public PlayerSetting()
			{
			}

			[Token(Token = "0x60008FB")]
			[Address(RVA = "0x26A82F8", Offset = "0x26A82F8", VA = "0x26A82F8")]
			private PlayerSetting(PlayerSetting other)
			{
			}

			[Token(Token = "0x60008FC")]
			[Address(RVA = "0x26A850C", Offset = "0x26A850C", VA = "0x26A850C")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB2528", Offset = "0xBB2528")]
		[SerializeField]
		private InputManager_Base rewiredInputManager;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB2574", Offset = "0xBB2574")]
		private bool useAllRewiredGamePlayers;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB25C0", Offset = "0xBB25C0")]
		private bool useRewiredSystemPlayer;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB260C", Offset = "0xBB260C")]
		private int[] rewiredPlayerIds;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB2658", Offset = "0xBB2658")]
		private bool usePlayingPlayersOnly;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB26A4", Offset = "0xBB26A4")]
		private List<Rewired.Components.PlayerMouse> playerMice;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB26F0", Offset = "0xBB26F0")]
		private bool moveOneElementPerAxisPress;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB273C", Offset = "0xBB273C")]
		private bool setActionsById;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB2788", Offset = "0xBB2788")]
		private int horizontalActionId;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB27D4", Offset = "0xBB27D4")]
		private int verticalActionId;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB2820", Offset = "0xBB2820")]
		private int submitActionId;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB286C", Offset = "0xBB286C")]
		private int cancelActionId;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB28B8", Offset = "0xBB28B8")]
		private string m_HorizontalAxis;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB2904", Offset = "0xBB2904")]
		private string m_VerticalAxis;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB2950", Offset = "0xBB2950")]
		private string m_SubmitButton;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB299C", Offset = "0xBB299C")]
		private string m_CancelButton;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB29E8", Offset = "0xBB29E8")]
		private float m_InputActionsPerSecond;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB2A34", Offset = "0xBB2A34")]
		private float m_RepeatDelay;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB2A80", Offset = "0xBB2A80")]
		private bool m_allowMouseInput;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB2ACC", Offset = "0xBB2ACC")]
		private bool m_allowMouseInputIfTouchSupported;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDA")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB2B18", Offset = "0xBB2B18")]
		private bool m_allowTouchInput;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDB")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB2B64", Offset = "0xBB2B64")]
		private bool m_deselectIfBackgroundClicked;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB2BB0", Offset = "0xBB2BB0")]
		private bool m_deselectBeforeSelecting;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDD")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBB2BFC", Offset = "0xBB2BFC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBB2BFC", Offset = "0xBB2BFC")]
		private bool m_ForceModuleActive;

		[NonSerialized]
		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] playerIds;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool recompiling;

		[NonSerialized]
		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
		private bool isTouchSupported;

		[NonSerialized]
		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private double m_PrevActionTime;

		[NonSerialized]
		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Vector2 m_LastMoveVector;

		[NonSerialized]
		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private int m_ConsecutiveMoveCount;

		[NonSerialized]
		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private bool m_HasFocus;

		[Token(Token = "0x17000260")]
		public InputManager_Base RewiredInputManager
		{
			[Token(Token = "0x6000444")]
			[Address(RVA = "0x210F560", Offset = "0x210F560", VA = "0x210F560")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000445")]
			[Address(RVA = "0x210F568", Offset = "0x210F568", VA = "0x210F568")]
			set
			{
			}
		}

		[Token(Token = "0x17000261")]
		public bool UseAllRewiredGamePlayers
		{
			[Token(Token = "0x6000446")]
			[Address(RVA = "0x210F570", Offset = "0x210F570", VA = "0x210F570")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000447")]
			[Address(RVA = "0x210F578", Offset = "0x210F578", VA = "0x210F578")]
			set
			{
			}
		}

		[Token(Token = "0x17000262")]
		public bool UseRewiredSystemPlayer
		{
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x210FAC4", Offset = "0x210FAC4", VA = "0x210FAC4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x210FACC", Offset = "0x210FACC", VA = "0x210FACC")]
			set
			{
			}
		}

		[Token(Token = "0x17000263")]
		public int[] RewiredPlayerIds
		{
			[Token(Token = "0x600044A")]
			[Address(RVA = "0x210FAF0", Offset = "0x210FAF0", VA = "0x210FAF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x210FB6C", Offset = "0x210FB6C", VA = "0x210FB6C")]
			set
			{
			}
		}

		[Token(Token = "0x17000264")]
		public bool UsePlayingPlayersOnly
		{
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x210FC2C", Offset = "0x210FC2C", VA = "0x210FC2C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x210FC34", Offset = "0x210FC34", VA = "0x210FC34")]
			set
			{
			}
		}

		[Token(Token = "0x17000265")]
		public List<Rewired.Components.PlayerMouse> PlayerMice
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x210FC40", Offset = "0x210FC40", VA = "0x210FC40")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x210FCB8", Offset = "0x210FCB8", VA = "0x210FCB8")]
			set
			{
			}
		}

		[Token(Token = "0x17000266")]
		public bool MoveOneElementPerAxisPress
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x210FD74", Offset = "0x210FD74", VA = "0x210FD74")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x210FD7C", Offset = "0x210FD7C", VA = "0x210FD7C")]
			set
			{
			}
		}

		[Token(Token = "0x17000267")]
		public bool allowMouseInput
		{
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x210FD88", Offset = "0x210FD88", VA = "0x210FD88")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000453")]
			[Address(RVA = "0x210FD90", Offset = "0x210FD90", VA = "0x210FD90")]
			set
			{
			}
		}

		[Token(Token = "0x17000268")]
		public bool allowMouseInputIfTouchSupported
		{
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x210FD9C", Offset = "0x210FD9C", VA = "0x210FD9C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x210FDA4", Offset = "0x210FDA4", VA = "0x210FDA4")]
			set
			{
			}
		}

		[Token(Token = "0x17000269")]
		public bool allowTouchInput
		{
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x210FDB0", Offset = "0x210FDB0", VA = "0x210FDB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x210FDB8", Offset = "0x210FDB8", VA = "0x210FDB8")]
			set
			{
			}
		}

		[Token(Token = "0x1700026A")]
		public bool deselectIfBackgroundClicked
		{
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x210FDC4", Offset = "0x210FDC4", VA = "0x210FDC4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x210FDCC", Offset = "0x210FDCC", VA = "0x210FDCC")]
			set
			{
			}
		}

		[Token(Token = "0x1700026B")]
		private bool deselectBeforeSelecting
		{
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x210FDD8", Offset = "0x210FDD8", VA = "0x210FDD8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x210FDE0", Offset = "0x210FDE0", VA = "0x210FDE0")]
			set
			{
			}
		}

		[Token(Token = "0x1700026C")]
		public bool SetActionsById
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x210FDEC", Offset = "0x210FDEC", VA = "0x210FDEC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x210FDF4", Offset = "0x210FDF4", VA = "0x210FDF4")]
			set
			{
			}
		}

		[Token(Token = "0x1700026D")]
		public int HorizontalActionId
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x210FE18", Offset = "0x210FE18", VA = "0x210FE18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600045F")]
			[Address(RVA = "0x210FE20", Offset = "0x210FE20", VA = "0x210FE20")]
			set
			{
			}
		}

		[Token(Token = "0x1700026E")]
		public int VerticalActionId
		{
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x210FF88", Offset = "0x210FF88", VA = "0x210FF88")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000461")]
			[Address(RVA = "0x210FF90", Offset = "0x210FF90", VA = "0x210FF90")]
			set
			{
			}
		}

		[Token(Token = "0x1700026F")]
		public int SubmitActionId
		{
			[Token(Token = "0x6000462")]
			[Address(RVA = "0x21100F8", Offset = "0x21100F8", VA = "0x21100F8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000463")]
			[Address(RVA = "0x2110100", Offset = "0x2110100", VA = "0x2110100")]
			set
			{
			}
		}

		[Token(Token = "0x17000270")]
		public int CancelActionId
		{
			[Token(Token = "0x6000464")]
			[Address(RVA = "0x2110268", Offset = "0x2110268", VA = "0x2110268")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000465")]
			[Address(RVA = "0x2110270", Offset = "0x2110270", VA = "0x2110270")]
			set
			{
			}
		}

		[Token(Token = "0x17000271")]
		protected override bool isMouseSupported
		{
			[Token(Token = "0x6000466")]
			[Address(RVA = "0x21103D8", Offset = "0x21103D8", VA = "0x21103D8", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000272")]
		private bool isTouchAllowed
		{
			[Token(Token = "0x6000467")]
			[Address(RVA = "0x2110428", Offset = "0x2110428", VA = "0x2110428")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000273")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xBB7E48", Offset = "0xBB7E48")]
		public bool allowActivationOnMobileDevice
		{
			[Token(Token = "0x6000468")]
			[Address(RVA = "0x2110430", Offset = "0x2110430", VA = "0x2110430")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000469")]
			[Address(RVA = "0x2110438", Offset = "0x2110438", VA = "0x2110438")]
			set
			{
			}
		}

		[Token(Token = "0x17000274")]
		public bool forceModuleActive
		{
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x2110444", Offset = "0x2110444", VA = "0x2110444")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600046B")]
			[Address(RVA = "0x211044C", Offset = "0x211044C", VA = "0x211044C")]
			set
			{
			}
		}

		[Token(Token = "0x17000275")]
		public float inputActionsPerSecond
		{
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x2110458", Offset = "0x2110458", VA = "0x2110458")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x2110460", Offset = "0x2110460", VA = "0x2110460")]
			set
			{
			}
		}

		[Token(Token = "0x17000276")]
		public float repeatDelay
		{
			[Token(Token = "0x600046E")]
			[Address(RVA = "0x2110468", Offset = "0x2110468", VA = "0x2110468")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600046F")]
			[Address(RVA = "0x2110470", Offset = "0x2110470", VA = "0x2110470")]
			set
			{
			}
		}

		[Token(Token = "0x17000277")]
		public string horizontalAxis
		{
			[Token(Token = "0x6000470")]
			[Address(RVA = "0x2110478", Offset = "0x2110478", VA = "0x2110478")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000471")]
			[Address(RVA = "0x2110480", Offset = "0x2110480", VA = "0x2110480")]
			set
			{
			}
		}

		[Token(Token = "0x17000278")]
		public string verticalAxis
		{
			[Token(Token = "0x6000472")]
			[Address(RVA = "0x211058C", Offset = "0x211058C", VA = "0x211058C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000473")]
			[Address(RVA = "0x2110594", Offset = "0x2110594", VA = "0x2110594")]
			set
			{
			}
		}

		[Token(Token = "0x17000279")]
		public string submitButton
		{
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x21106A0", Offset = "0x21106A0", VA = "0x21106A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000475")]
			[Address(RVA = "0x21106A8", Offset = "0x21106A8", VA = "0x21106A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700027A")]
		public string cancelButton
		{
			[Token(Token = "0x6000476")]
			[Address(RVA = "0x21107B4", Offset = "0x21107B4", VA = "0x21107B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000477")]
			[Address(RVA = "0x21107BC", Offset = "0x21107BC", VA = "0x21107BC")]
			set
			{
			}
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x21108C8", Offset = "0x21108C8", VA = "0x21108C8")]
		private RewiredStandaloneInputModule()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x2110A38", Offset = "0x2110A38", VA = "0x2110A38", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x2110E0C", Offset = "0x2110E0C", VA = "0x2110E0C", Slot = "24")]
		public override void UpdateModule()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x2111084", Offset = "0x2111084", VA = "0x2111084", Slot = "25")]
		public override bool IsModuleSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x211108C", Offset = "0x211108C", VA = "0x211108C", Slot = "21")]
		public override bool ShouldActivateModule()
		{
			return default(bool);
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x2111958", Offset = "0x2111958", VA = "0x2111958", Slot = "23")]
		public override void ActivateModule()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x2111A40", Offset = "0x2111A40", VA = "0x2111A40", Slot = "22")]
		public override void DeactivateModule()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x2111A68", Offset = "0x2111A68", VA = "0x2111A68", Slot = "17")]
		public override void Process()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x21122F4", Offset = "0x21122F4", VA = "0x21122F4")]
		private bool ProcessTouchEvents()
		{
			return default(bool);
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x21126FC", Offset = "0x21126FC", VA = "0x21126FC")]
		private void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x2112018", Offset = "0x2112018", VA = "0x2112018")]
		private bool SendSubmitEventToSelectedObject()
		{
			return default(bool);
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x2113180", Offset = "0x2113180", VA = "0x2113180")]
		private Vector2 GetRawMoveVector()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x2111D28", Offset = "0x2111D28", VA = "0x2111D28")]
		private bool SendMoveEventToSelectedObject()
		{
			return default(bool);
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x21134A8", Offset = "0x21134A8", VA = "0x21134A8")]
		private void CheckButtonOrKeyMovement(out bool downHorizontal, out bool downVertical)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x21125AC", Offset = "0x21125AC", VA = "0x21125AC")]
		private void ProcessMouseEvents()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x2113648", Offset = "0x2113648", VA = "0x2113648")]
		private void ProcessMouseEvent(int playerId, int pointerIndex)
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x2111BC4", Offset = "0x2111BC4", VA = "0x2111BC4")]
		private bool SendUpdateEventToSelectedObject()
		{
			return default(bool);
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x21139AC", Offset = "0x21139AC", VA = "0x21139AC")]
		private void ProcessMousePress(MouseButtonEventData data)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x2112FA0", Offset = "0x2112FA0", VA = "0x2112FA0")]
		private void HandleMouseTouchDeselectionOnSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x211412C", Offset = "0x211412C", VA = "0x211412C")]
		private void OnApplicationFocus(bool hasFocus)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x2110FAC", Offset = "0x2110FAC", VA = "0x2110FAC")]
		private bool ShouldIgnoreEventsOnNoFocus()
		{
			return default(bool);
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x2114138", Offset = "0x2114138", VA = "0x2114138", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x211426C", Offset = "0x211426C", VA = "0x211426C", Slot = "27")]
		protected override bool IsDefaultPlayer(int playerId)
		{
			return default(bool);
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x2110C04", Offset = "0x2110C04", VA = "0x2110C04")]
		private void InitializeRewired()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x210F59C", Offset = "0x210F59C", VA = "0x210F59C")]
		private void SetupRewiredVars()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x2114728", Offset = "0x2114728", VA = "0x2114728")]
		private void SetUpRewiredPlayerMice()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x2114434", Offset = "0x2114434", VA = "0x2114434")]
		private void SetUpRewiredActions()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x2113450", Offset = "0x2113450", VA = "0x2113450")]
		private bool GetButton(Player player, int actionId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x2111544", Offset = "0x2111544", VA = "0x2111544")]
		private bool GetButtonDown(Player player, int actionId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x211347C", Offset = "0x211347C", VA = "0x211347C")]
		private bool GetNegativeButton(Player player, int actionId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x2111570", Offset = "0x2111570", VA = "0x2111570")]
		private bool GetNegativeButtonDown(Player player, int actionId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x211159C", Offset = "0x211159C", VA = "0x211159C")]
		private float GetAxis(Player player, int actionId)
		{
			return default(float);
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x2110EE0", Offset = "0x2110EE0", VA = "0x2110EE0")]
		private void CheckEditorRecompile()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x21148A0", Offset = "0x21148A0", VA = "0x21148A0")]
		private void OnEditorRecompile()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x21148AC", Offset = "0x21148AC", VA = "0x21148AC")]
		private void ClearRewiredVars()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x21115C8", Offset = "0x21115C8", VA = "0x21115C8")]
		private bool DidAnyMouseMove()
		{
			return default(bool);
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x2111798", Offset = "0x2111798", VA = "0x2111798")]
		private bool GetMouseButtonDownOnAnyMouse(int buttonIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x21148E8", Offset = "0x21148E8", VA = "0x21148E8")]
		private void OnRewiredInitialized()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x21148EC", Offset = "0x21148EC", VA = "0x21148EC")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xBB2C6C", Offset = "0xBB2C6C")]
		public float life;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool killAfterLife;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Light li;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float initIntensity;

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x19C36F0", Offset = "0x19C36F0", VA = "0x19C36F0")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x19C3824", Offset = "0x19C3824", VA = "0x19C3824")]
		private void Update()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x19C398C", Offset = "0x19C398C", VA = "0x19C398C")]
		public ETFXLightFade()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class ETFXPitchRandomizer : MonoBehaviour
	{
		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float randomPercent;

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x19C39A8", Offset = "0x19C39A8", VA = "0x19C39A8")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x19C3A5C", Offset = "0x19C3A5C", VA = "0x19C3A5C")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xBB2CA4", Offset = "0xBB2CA4")]
		public Vector3 rotateVector;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public spaceEnum rotateSpace;

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x19C3A6C", Offset = "0x19C3A6C", VA = "0x19C3A6C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x19C3A70", Offset = "0x19C3A70", VA = "0x19C3A70")]
		private void Update()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x19C3B48", Offset = "0x19C3B48", VA = "0x19C3B48")]
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
		[Address(RVA = "0x19C0558", Offset = "0x19C0558", VA = "0x19C0558")]
		public static double Sin(double a)
		{
			return default(double);
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x19C05C0", Offset = "0x19C05C0", VA = "0x19C05C0")]
		public static double Cos(double a)
		{
			return default(double);
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x19C0628", Offset = "0x19C0628", VA = "0x19C0628")]
		public static double Tan(double a)
		{
			return default(double);
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x19C0690", Offset = "0x19C0690", VA = "0x19C0690")]
		public static double Pow(double x, double y)
		{
			return default(double);
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x19C0704", Offset = "0x19C0704", VA = "0x19C0704")]
		public static double Log(double a, double newBase)
		{
			return default(double);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x19C0778", Offset = "0x19C0778", VA = "0x19C0778")]
		public static double Log10(double a)
		{
			return default(double);
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x19C07E0", Offset = "0x19C07E0", VA = "0x19C07E0")]
		public static double Clamp01(double a)
		{
			return default(double);
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x19C0800", Offset = "0x19C0800", VA = "0x19C0800")]
		public static double Clamp(double a, double min, double max)
		{
			return default(double);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x19C081C", Offset = "0x19C081C", VA = "0x19C081C")]
		public static double Lerp(double a, double b, double t)
		{
			return default(double);
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x19C0840", Offset = "0x19C0840", VA = "0x19C0840")]
		public static double InverseLerp(double a, double b, double t)
		{
			return default(double);
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x19C0874", Offset = "0x19C0874", VA = "0x19C0874")]
		public static Vector3 LerpVector3(Vector3 a, Vector3 b, double t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x19C08D4", Offset = "0x19C08D4", VA = "0x19C08D4")]
		public static double Round(double a)
		{
			return default(double);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x19C09A8", Offset = "0x19C09A8", VA = "0x19C09A8")]
		public static int RoundInt(double a)
		{
			return default(int);
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x19C0A94", Offset = "0x19C0A94", VA = "0x19C0A94")]
		public static double Ceil(double a)
		{
			return default(double);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x19C0AFC", Offset = "0x19C0AFC", VA = "0x19C0AFC")]
		public static int CeilInt(double a)
		{
			return default(int);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x19C0B7C", Offset = "0x19C0B7C", VA = "0x19C0B7C")]
		public static double Floor(double a)
		{
			return default(double);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x19C0BE4", Offset = "0x19C0BE4", VA = "0x19C0BE4")]
		public static int FloorInt(double a)
		{
			return default(int);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x19C0C64", Offset = "0x19C0C64", VA = "0x19C0C64")]
		public static double Move(double current, double target, double amount)
		{
			return default(double);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x19C0C94", Offset = "0x19C0C94", VA = "0x19C0C94")]
		public static double Abs(double a)
		{
			return default(double);
		}
	}
	[Token(Token = "0x2000048")]
	public static class DuplicateUtility
	{
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x19C0D8C", Offset = "0x19C0D8C", VA = "0x19C0D8C")]
		public static AnimationCurve DuplicateCurve(AnimationCurve input)
		{
			return null;
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x19C0ECC", Offset = "0x19C0ECC", VA = "0x19C0ECC")]
		public static Gradient DuplicateGradient(Gradient input)
		{
			return null;
		}
	}
	[Token(Token = "0x2000049")]
	public static class LinearAlgebraUtility
	{
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x19C9B78", Offset = "0x19C9B78", VA = "0x19C9B78")]
		public static Vector3 ProjectOnLine(Vector3 fromPoint, Vector3 toPoint, Vector3 project)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x19C9C84", Offset = "0x19C9C84", VA = "0x19C9C84")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Vector3[] tan2;

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x19CC988", Offset = "0x19CC988", VA = "0x19CC988")]
		public static int[] GeneratePlaneTriangles(int x, int z, bool flip, int startTriangleIndex = 0, int startVertex = 0)
		{
			return null;
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x19CCA54", Offset = "0x19CCA54", VA = "0x19CCA54")]
		public static int[] GeneratePlaneTriangles(ref int[] triangles, int x, int z, bool flip, int startTriangleIndex = 0, int startVertex = 0, bool reallocateArray = false)
		{
			return null;
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x19CB414", Offset = "0x19CB414", VA = "0x19CB414")]
		public static void CalculateTangents(TS_Mesh mesh)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x19CCD64", Offset = "0x19CCD64", VA = "0x19CCD64")]
		public static void MakeDoublesided(Mesh input)
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x19CD7C8", Offset = "0x19CD7C8", VA = "0x19CD7C8")]
		public static void MakeDoublesided(TS_Mesh input)
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x19CACE4", Offset = "0x19CACE4", VA = "0x19CACE4")]
		public static void MakeDoublesidedHalf(TS_Mesh input)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x19CE118", Offset = "0x19CE118", VA = "0x19CE118")]
		public static void InverseTransformMesh(TS_Mesh input, TS_Transform transform)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x19CE208", Offset = "0x19CE208", VA = "0x19CE208")]
		public static void TransformMesh(TS_Mesh input, TS_Transform transform)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x19CABF4", Offset = "0x19CABF4", VA = "0x19CABF4")]
		public static void InverseTransformMesh(TS_Mesh input, Transform transform)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x19CE2F8", Offset = "0x19CE2F8", VA = "0x19CE2F8")]
		public static void TransformMesh(TS_Mesh input, Transform transform)
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x19CE3E8", Offset = "0x19CE3E8", VA = "0x19CE3E8")]
		public static void InverseTransformMesh(Mesh input, Transform transform)
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x19CE53C", Offset = "0x19CE53C", VA = "0x19CE53C")]
		public static void TransformMesh(Mesh input, Transform transform)
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x19CE6D4", Offset = "0x19CE6D4", VA = "0x19CE6D4")]
		public static void TransformVertices(Vector3[] vertices, Transform transform)
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x19CE768", Offset = "0x19CE768", VA = "0x19CE768")]
		public static void InverseTransformVertices(Vector3[] vertices, Transform transform)
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x19CE7FC", Offset = "0x19CE7FC", VA = "0x19CE7FC")]
		public static void TransformNormals(Vector3[] normals, Transform transform)
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x19CE890", Offset = "0x19CE890", VA = "0x19CE890")]
		public static void InverseTransformNormals(Vector3[] normals, Transform transform)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x19CE924", Offset = "0x19CE924", VA = "0x19CE924")]
		public static string ToOBJString(Mesh mesh, Material[] materials)
		{
			return null;
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x19CF314", Offset = "0x19CF314", VA = "0x19CF314")]
		public static Mesh Copy(Mesh input)
		{
			return null;
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x19CF544", Offset = "0x19CF544", VA = "0x19CF544")]
		public static void Triangulate(Vector2[] points, ref int[] output)
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x19CFBF4", Offset = "0x19CFBF4", VA = "0x19CFBF4")]
		public static void FlipTriangles(ref int[] triangles)
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x19CB2B0", Offset = "0x19CB2B0", VA = "0x19CB2B0")]
		public static void FlipFaces(TS_Mesh input)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x19CFC7C", Offset = "0x19CFC7C", VA = "0x19CFC7C")]
		public static void BreakMesh(Mesh input, bool keepNormals = true)
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x19CF94C", Offset = "0x19CF94C", VA = "0x19CF94C")]
		private static float Area(Vector2[] points, int maxCount)
		{
			return default(float);
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x19CF9E4", Offset = "0x19CF9E4", VA = "0x19CF9E4")]
		private static bool Snip(Vector2[] points, int u, int v, int w, int n, int[] V)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x19D07AC", Offset = "0x19D07AC", VA = "0x19D07AC")]
		private static bool InsideTriangle(Vector2 A, Vector2 B, Vector2 C, Vector2 P)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x19D0828", Offset = "0x19D0828", VA = "0x19D0828")]
		public MeshUtility()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public static class ResourceUtility
	{
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x210BCA0", Offset = "0x210BCA0", VA = "0x210BCA0")]
		public static string FindFolder(string dir, string folderPattern)
		{
			return null;
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x210C0E4", Offset = "0x210C0E4", VA = "0x210C0E4")]
		public static Texture2D LoadTexture(string dreamteckPath, string textureFileName)
		{
			return null;
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x210C268", Offset = "0x210C268", VA = "0x210C268")]
		public static Texture2D LoadTexture(string path)
		{
			return null;
		}
	}
	[Token(Token = "0x200004C")]
	public static class SceneUtility
	{
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x26FAE30", Offset = "0x26FAE30", VA = "0x26FAE30")]
		public static void GetChildrenRecursively(Transform current, ref List<Transform> transformList)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public class TS_Bounds
	{
		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 center;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 extents;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 max;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 min;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 size;

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x290B028", Offset = "0x290B028", VA = "0x290B028")]
		public TS_Bounds()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x290B09C", Offset = "0x290B09C", VA = "0x290B09C")]
		public TS_Bounds(Bounds bounds)
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x290B17C", Offset = "0x290B17C", VA = "0x290B17C")]
		public TS_Bounds(Vector3 c, Vector3 s)
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x290B26C", Offset = "0x290B26C", VA = "0x290B26C")]
		public TS_Bounds(Vector3 min, Vector3 max, Vector3 center)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x290B360", Offset = "0x290B360", VA = "0x290B360")]
		public void CreateFromMinMax(Vector3 min, Vector3 max)
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x290B3FC", Offset = "0x290B3FC", VA = "0x290B3FC")]
		public bool Contains(Vector3 point)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200004E")]
	public class TS_Mesh
	{
		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3[] vertices;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] normals;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector4[] tangents;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color[] colors;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2[] uv;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector2[] uv2;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector2[] uv3;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector2[] uv4;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int[] triangles;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<int[]> subMeshes;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public TS_Bounds bounds;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool hasUpdate;

		[Token(Token = "0x1700027B")]
		public int vertexCount
		{
			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x2900EB4", Offset = "0x2900EB4", VA = "0x2900EB4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x290B450", Offset = "0x290B450", VA = "0x290B450")]
			set
			{
			}
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x28FE6AC", Offset = "0x28FE6AC", VA = "0x28FE6AC")]
		public TS_Mesh()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x290B454", Offset = "0x290B454", VA = "0x290B454")]
		public TS_Mesh(Mesh mesh)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x28FE42C", Offset = "0x28FE42C", VA = "0x28FE42C")]
		public void Clear()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x290B6DC", Offset = "0x290B6DC", VA = "0x290B6DC")]
		public void CreateFromMesh(Mesh mesh)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x28FF638", Offset = "0x28FF638", VA = "0x28FF638")]
		public void Combine(List<TS_Mesh> newMeshes, bool overwrite = false)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x290B904", Offset = "0x290B904", VA = "0x290B904")]
		public void Combine(TS_Mesh newMesh)
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x290C0CC", Offset = "0x290C0CC", VA = "0x290C0CC")]
		public static TS_Mesh Copy(TS_Mesh input)
		{
			return null;
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x290C5B0", Offset = "0x290C5B0", VA = "0x290C5B0")]
		public void Absorb(TS_Mesh input)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x290CCDC", Offset = "0x290CCDC", VA = "0x290CCDC")]
		public void WriteMesh(ref Mesh input)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004F")]
	public class TS_Transform
	{
		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool setPosition;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		private bool setRotation;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		private bool setScale;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		private bool setLocalPosition;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private bool setLocalRotation;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private Transform _transform;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private float posX;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[HideInInspector]
		private float posY;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[HideInInspector]
		private float posZ;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[HideInInspector]
		private float scaleX;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private float scaleY;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[HideInInspector]
		private float scaleZ;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private float lossyScaleX;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[HideInInspector]
		private float lossyScaleY;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		private float lossyScaleZ;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		[HideInInspector]
		private float rotX;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		private float rotY;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[HideInInspector]
		private float rotZ;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		private float rotW;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		[HideInInspector]
		private float lposX;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[HideInInspector]
		private float lposY;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[HideInInspector]
		private float lposZ;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[HideInInspector]
		private float lrotX;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		[HideInInspector]
		private float lrotY;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[HideInInspector]
		private float lrotZ;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		[HideInInspector]
		private float lrotW;

		[Token(Token = "0x1700027C")]
		public Vector3 position
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x1FA392C", Offset = "0x1FA392C", VA = "0x1FA392C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x1FA397C", Offset = "0x1FA397C", VA = "0x1FA397C")]
			set
			{
			}
		}

		[Token(Token = "0x1700027D")]
		public Quaternion rotation
		{
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x1FA39D8", Offset = "0x1FA39D8", VA = "0x1FA39D8")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x1FA3A54", Offset = "0x1FA3A54", VA = "0x1FA3A54")]
			set
			{
			}
		}

		[Token(Token = "0x1700027E")]
		public Vector3 scale
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x1FA3ABC", Offset = "0x1FA3ABC", VA = "0x1FA3ABC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x1FA3B0C", Offset = "0x1FA3B0C", VA = "0x1FA3B0C")]
			set
			{
			}
		}

		[Token(Token = "0x1700027F")]
		public Vector3 lossyScale
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x1FA3B64", Offset = "0x1FA3B64", VA = "0x1FA3B64")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x1FA3BB4", Offset = "0x1FA3BB4", VA = "0x1FA3BB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000280")]
		public Vector3 localPosition
		{
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x1FA3C0C", Offset = "0x1FA3C0C", VA = "0x1FA3C0C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x1FA3C5C", Offset = "0x1FA3C5C", VA = "0x1FA3C5C")]
			set
			{
			}
		}

		[Token(Token = "0x17000281")]
		public Quaternion localRotation
		{
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x1FA3CB8", Offset = "0x1FA3CB8", VA = "0x1FA3CB8")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x1FA3D34", Offset = "0x1FA3D34", VA = "0x1FA3D34")]
			set
			{
			}
		}

		[Token(Token = "0x17000282")]
		public Transform transform
		{
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x1FA3D9C", Offset = "0x1FA3D9C", VA = "0x1FA3D9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1FA3DA4", Offset = "0x1FA3DA4", VA = "0x1FA3DA4")]
		public TS_Transform(Transform input)
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1FA3E58", Offset = "0x1FA3E58", VA = "0x1FA3E58")]
		public void Update()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1FA3E28", Offset = "0x1FA3E28", VA = "0x1FA3E28")]
		public void SetTransform(Transform input)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1FA4030", Offset = "0x1FA4030", VA = "0x1FA4030")]
		public bool HasChange()
		{
			return default(bool);
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x1FA4074", Offset = "0x1FA4074", VA = "0x1FA4074")]
		public bool HasPositionChange()
		{
			return default(bool);
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x1FA4104", Offset = "0x1FA4104", VA = "0x1FA4104")]
		public bool HasRotationChange()
		{
			return default(bool);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x1FA41B4", Offset = "0x1FA41B4", VA = "0x1FA41B4")]
		public bool HasScaleChange()
		{
			return default(bool);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x1FA4244", Offset = "0x1FA4244", VA = "0x1FA4244")]
		public Vector3 TransformPoint(Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x1FA42E4", Offset = "0x1FA42E4", VA = "0x1FA42E4")]
		public Vector3 TransformDirection(Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x1FA4334", Offset = "0x1FA4334", VA = "0x1FA4334")]
		public Vector3 InverseTransformPoint(Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x1FA4380", Offset = "0x1FA4380", VA = "0x1FA4380")]
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
		[Address(RVA = "0x1FA53F8", Offset = "0x1FA53F8", VA = "0x1FA53F8")]
		public static Vector3 GetPosition(Matrix4x4 m)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1FA5418", Offset = "0x1FA5418", VA = "0x1FA5418")]
		public static Quaternion GetRotation(Matrix4x4 m)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1FA5498", Offset = "0x1FA5498", VA = "0x1FA5498")]
		public static Vector3 GetScale(Matrix4x4 m)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1FA5540", Offset = "0x1FA5540", VA = "0x1FA5540")]
		public static void SetPosition(ref Matrix4x4 m, ref Vector3 p)
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1FA5598", Offset = "0x1FA5598", VA = "0x1FA5598")]
		public static void GetChildCount(Transform parent, ref int count)
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x1FA5834", Offset = "0x1FA5834", VA = "0x1FA5834")]
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
		[Address(RVA = "0x19BAD7C", Offset = "0x19BAD7C", VA = "0x19BAD7C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x19BAD80", Offset = "0x19BAD80", VA = "0x19BAD80", Slot = "13")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x19BAD88", Offset = "0x19BAD88", VA = "0x19BAD88", Slot = "14")]
		protected override void Build()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x19BAD90", Offset = "0x19BAD90", VA = "0x19BAD90", Slot = "15")]
		protected override void PostBuild()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x19BAD98", Offset = "0x19BAD98", VA = "0x19BAD98")]
		public BlankUser()
		{
		}
	}
	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB1114", Offset = "0xBB1114")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBB1114", Offset = "0xBB1114")]
	public class EdgeColliderGenerator : SplineUser
	{
		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		[HideInInspector]
		private float _offset;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		[HideInInspector]
		protected EdgeCollider2D edgeCollider;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[HideInInspector]
		protected Vector2[] vertices;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		public float updateRate;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		protected float lastUpdateTime;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool updateCollider;

		[Token(Token = "0x17000283")]
		public float offset
		{
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x19C3B7C", Offset = "0x19C3B7C", VA = "0x19C3B7C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x19C3B84", Offset = "0x19C3B84", VA = "0x19C3B84")]
			set
			{
			}
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x19C3BA4", Offset = "0x19C3BA4", VA = "0x19C3BA4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x19C3C0C", Offset = "0x19C3C0C", VA = "0x19C3C0C", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x19C3C14", Offset = "0x19C3C14", VA = "0x19C3C14", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x19C3C1C", Offset = "0x19C3C1C", VA = "0x19C3C1C", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x19C3C24", Offset = "0x19C3C24", VA = "0x19C3C24", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x19C3C2C", Offset = "0x19C3C2C", VA = "0x19C3C2C", Slot = "13")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x19C3CFC", Offset = "0x19C3CFC", VA = "0x19C3CFC", Slot = "14")]
		protected override void Build()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x19C3E80", Offset = "0x19C3E80", VA = "0x19C3E80", Slot = "15")]
		protected override void PostBuild()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x19C3FC8", Offset = "0x19C3FC8", VA = "0x19C3FC8")]
		public EdgeColliderGenerator()
		{
		}
	}
	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB1198", Offset = "0xBB1198")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float targetLength;

			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UnityEvent onChange;

			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Type type;

			[Token(Token = "0x60008FD")]
			[Address(RVA = "0x26A4F00", Offset = "0x26A4F00", VA = "0x26A4F00")]
			public LengthEvent()
			{
			}

			[Token(Token = "0x60008FE")]
			[Address(RVA = "0x26A4F80", Offset = "0x26A4F80", VA = "0x26A4F80")]
			public LengthEvent(Type t)
			{
			}

			[Token(Token = "0x60008FF")]
			[Address(RVA = "0x26A5014", Offset = "0x26A5014", VA = "0x26A5014")]
			public void Check(float fromLength, float toLength)
			{
			}
		}

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public LengthEvent[] lengthEvents;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public float idealLength;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float _length;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float lastLength;

		[Token(Token = "0x17000284")]
		public float length
		{
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x19C9768", Offset = "0x19C9768", VA = "0x19C9768")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x19C9770", Offset = "0x19C9770", VA = "0x19C9770", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x19C9814", Offset = "0x19C9814", VA = "0x19C9814", Slot = "14")]
		protected override void Build()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x19C98B8", Offset = "0x19C98B8", VA = "0x19C98B8")]
		private void AddEvent(LengthEvent lengthEvent)
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x19C99A4", Offset = "0x19C99A4", VA = "0x19C99A4")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x93")]
		[SerializeField]
		[HideInInspector]
		private bool _baked;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		[HideInInspector]
		private bool _markDynamic;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		[HideInInspector]
		private float _size;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[SerializeField]
		[HideInInspector]
		private Color _color;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[SerializeField]
		[HideInInspector]
		private Vector3 _offset;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[HideInInspector]
		private NormalMethod _normalMethod;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		[HideInInspector]
		private bool _calculateTangents;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBB33D4", Offset = "0xBB33D4")]
		private float _rotation;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[HideInInspector]
		private bool _flipFaces;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC5")]
		[SerializeField]
		[HideInInspector]
		private bool _doubleSided;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[HideInInspector]
		private UVMode _uvMode;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		[HideInInspector]
		private Vector2 _uvScale;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[SerializeField]
		[HideInInspector]
		private Vector2 _uvOffset;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		[HideInInspector]
		private float _uvRotation;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[HideInInspector]
		protected MeshCollider meshCollider;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[HideInInspector]
		protected MeshFilter filter;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[HideInInspector]
		protected MeshRenderer meshRenderer;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[HideInInspector]
		protected TS_Mesh tsMesh;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		[HideInInspector]
		protected Mesh mesh;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[HideInInspector]
		public float colliderUpdateRate;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		protected bool updateCollider;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		protected float lastUpdateTime;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private float vDist;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static Vector2 uvs;

		[Token(Token = "0x17000285")]
		public float size
		{
			[Token(Token = "0x6000527")]
			[Address(RVA = "0x19C9FB8", Offset = "0x19C9FB8", VA = "0x19C9FB8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000528")]
			[Address(RVA = "0x19C9FC0", Offset = "0x19C9FC0", VA = "0x19C9FC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000286")]
		public Color color
		{
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x19C9FE0", Offset = "0x19C9FE0", VA = "0x19C9FE0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600052A")]
			[Address(RVA = "0x19C9FEC", Offset = "0x19C9FEC", VA = "0x19C9FEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000287")]
		public Vector3 offset
		{
			[Token(Token = "0x600052B")]
			[Address(RVA = "0x19CA064", Offset = "0x19CA064", VA = "0x19CA064")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600052C")]
			[Address(RVA = "0x19CA070", Offset = "0x19CA070", VA = "0x19CA070")]
			set
			{
			}
		}

		[Token(Token = "0x17000288")]
		public NormalMethod normalMethod
		{
			[Token(Token = "0x600052D")]
			[Address(RVA = "0x19CA0E4", Offset = "0x19CA0E4", VA = "0x19CA0E4")]
			get
			{
				return default(NormalMethod);
			}
			[Token(Token = "0x600052E")]
			[Address(RVA = "0x19CA0EC", Offset = "0x19CA0EC", VA = "0x19CA0EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000289")]
		public bool calculateTangents
		{
			[Token(Token = "0x600052F")]
			[Address(RVA = "0x19CA10C", Offset = "0x19CA10C", VA = "0x19CA10C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000530")]
			[Address(RVA = "0x19CA114", Offset = "0x19CA114", VA = "0x19CA114")]
			set
			{
			}
		}

		[Token(Token = "0x1700028A")]
		public float rotation
		{
			[Token(Token = "0x6000531")]
			[Address(RVA = "0x19CA140", Offset = "0x19CA140", VA = "0x19CA140")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000532")]
			[Address(RVA = "0x19CA148", Offset = "0x19CA148", VA = "0x19CA148")]
			set
			{
			}
		}

		[Token(Token = "0x1700028B")]
		public bool flipFaces
		{
			[Token(Token = "0x6000533")]
			[Address(RVA = "0x19CA168", Offset = "0x19CA168", VA = "0x19CA168")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000534")]
			[Address(RVA = "0x19CA170", Offset = "0x19CA170", VA = "0x19CA170")]
			set
			{
			}
		}

		[Token(Token = "0x1700028C")]
		public bool doubleSided
		{
			[Token(Token = "0x6000535")]
			[Address(RVA = "0x19CA19C", Offset = "0x19CA19C", VA = "0x19CA19C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000536")]
			[Address(RVA = "0x19CA1A4", Offset = "0x19CA1A4", VA = "0x19CA1A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700028D")]
		public UVMode uvMode
		{
			[Token(Token = "0x6000537")]
			[Address(RVA = "0x19CA1D0", Offset = "0x19CA1D0", VA = "0x19CA1D0")]
			get
			{
				return default(UVMode);
			}
			[Token(Token = "0x6000538")]
			[Address(RVA = "0x19CA1D8", Offset = "0x19CA1D8", VA = "0x19CA1D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700028E")]
		public Vector2 uvScale
		{
			[Token(Token = "0x6000539")]
			[Address(RVA = "0x19CA1F8", Offset = "0x19CA1F8", VA = "0x19CA1F8")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600053A")]
			[Address(RVA = "0x19CA200", Offset = "0x19CA200", VA = "0x19CA200")]
			set
			{
			}
		}

		[Token(Token = "0x1700028F")]
		public Vector2 uvOffset
		{
			[Token(Token = "0x600053B")]
			[Address(RVA = "0x19CA23C", Offset = "0x19CA23C", VA = "0x19CA23C")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600053C")]
			[Address(RVA = "0x19CA244", Offset = "0x19CA244", VA = "0x19CA244")]
			set
			{
			}
		}

		[Token(Token = "0x17000290")]
		public float uvRotation
		{
			[Token(Token = "0x600053D")]
			[Address(RVA = "0x19CA280", Offset = "0x19CA280", VA = "0x19CA280")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600053E")]
			[Address(RVA = "0x19CA288", Offset = "0x19CA288", VA = "0x19CA288")]
			set
			{
			}
		}

		[Token(Token = "0x17000291")]
		public bool baked
		{
			[Token(Token = "0x600053F")]
			[Address(RVA = "0x19CA2A8", Offset = "0x19CA2A8", VA = "0x19CA2A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000292")]
		public bool markDynamic
		{
			[Token(Token = "0x6000540")]
			[Address(RVA = "0x19CA2B0", Offset = "0x19CA2B0", VA = "0x19CA2B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x19CA2B8", Offset = "0x19CA2B8", VA = "0x19CA2B8")]
			set
			{
			}
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x19CA3A8", Offset = "0x19CA3A8", VA = "0x19CA3A8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x19CA4F8", Offset = "0x19CA4F8", VA = "0x19CA4F8", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x19CA500", Offset = "0x19CA500", VA = "0x19CA500")]
		public void CloneMesh()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x19CA65C", Offset = "0x19CA65C", VA = "0x19CA65C", Slot = "10")]
		public override void Rebuild()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x19CA670", Offset = "0x19CA670", VA = "0x19CA670", Slot = "11")]
		public override void RebuildImmediate()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x19CA684", Offset = "0x19CA684", VA = "0x19CA684", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x19CA68C", Offset = "0x19CA68C", VA = "0x19CA68C", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x19CA694", Offset = "0x19CA694", VA = "0x19CA694", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x19CA7C8", Offset = "0x19CA7C8", VA = "0x19CA7C8")]
		public void UpdateCollider()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x19CA8DC", Offset = "0x19CA8DC", VA = "0x19CA8DC", Slot = "13")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x19CA9CC", Offset = "0x19CA9CC", VA = "0x19CA9CC", Slot = "14")]
		protected override void Build()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x19CAA18", Offset = "0x19CAA18", VA = "0x19CAA18", Slot = "15")]
		protected override void PostBuild()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x19CAA4C", Offset = "0x19CAA4C", VA = "0x19CAA4C", Slot = "18")]
		protected virtual void BuildMesh()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x19CAA50", Offset = "0x19CAA50", VA = "0x19CAA50", Slot = "19")]
		protected virtual void WriteMesh()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x19CBAEC", Offset = "0x19CBAEC", VA = "0x19CBAEC", Slot = "20")]
		protected virtual void AllocateMesh(int vertexCount, int trisCount)
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x19CBCB8", Offset = "0x19CBCB8", VA = "0x19CBCB8")]
		protected void ResetUVDistance()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x19CBD18", Offset = "0x19CBD18", VA = "0x19CBD18")]
		protected void AddUVDistance(int sampleIndex)
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x19CBDA0", Offset = "0x19CBDA0", VA = "0x19CBDA0")]
		protected void CalculateUVs(double percent, float u)
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x19CBF80", Offset = "0x19CBF80", VA = "0x19CBF80")]
		public MeshGenerator()
		{
		}
	}
	[Token(Token = "0x2000055")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB11D0", Offset = "0xBB11D0")]
	public class Node : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000AF")]
		public class Connection
		{
			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool invertTangents;

			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[SerializeField]
			private int _pointIndex;

			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private SplineComputer _computer;

			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[HideInInspector]
			internal SplinePoint point;

			[Token(Token = "0x1700032D")]
			public SplineComputer spline
			{
				[Token(Token = "0x6000900")]
				[Address(RVA = "0x26A5828", Offset = "0x26A5828", VA = "0x26A5828")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700032E")]
			public int pointIndex
			{
				[Token(Token = "0x6000901")]
				[Address(RVA = "0x26A5830", Offset = "0x26A5830", VA = "0x26A5830")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700032F")]
			internal bool isValid
			{
				[Token(Token = "0x6000902")]
				[Address(RVA = "0x26A5838", Offset = "0x26A5838", VA = "0x26A5838")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000903")]
			[Address(RVA = "0x26A58D4", Offset = "0x26A58D4", VA = "0x26A58D4")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public Type type;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		protected Connection[] connections;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[HideInInspector]
		private bool _transformSize;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[SerializeField]
		[HideInInspector]
		private bool _transformNormals;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		[SerializeField]
		[HideInInspector]
		private bool _transformTangents;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 lastPosition;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 lastScale;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion lastRotation;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform trs;

		[Token(Token = "0x17000293")]
		public bool transformNormals
		{
			[Token(Token = "0x6000556")]
			[Address(RVA = "0x2100390", Offset = "0x2100390", VA = "0x2100390")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000557")]
			[Address(RVA = "0x2100398", Offset = "0x2100398", VA = "0x2100398")]
			set
			{
			}
		}

		[Token(Token = "0x17000294")]
		public bool transformSize
		{
			[Token(Token = "0x6000558")]
			[Address(RVA = "0x21004F8", Offset = "0x21004F8", VA = "0x21004F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000559")]
			[Address(RVA = "0x2100500", Offset = "0x2100500", VA = "0x2100500")]
			set
			{
			}
		}

		[Token(Token = "0x17000295")]
		public bool transformTangents
		{
			[Token(Token = "0x600055A")]
			[Address(RVA = "0x2100524", Offset = "0x2100524", VA = "0x2100524")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x210052C", Offset = "0x210052C", VA = "0x210052C")]
			set
			{
			}
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x2100550", Offset = "0x2100550", VA = "0x2100550")]
		private void Awake()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x21005F0", Offset = "0x21005F0", VA = "0x21005F0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x2100634", Offset = "0x2100634", VA = "0x2100634")]
		private void Update()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x2100638", Offset = "0x2100638", VA = "0x2100638")]
		private bool TransformChanged()
		{
			return default(bool);
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x2100588", Offset = "0x2100588", VA = "0x2100588")]
		private void SampleTransform()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x21005F4", Offset = "0x21005F4", VA = "0x21005F4")]
		private void Run()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x2100AD0", Offset = "0x2100AD0", VA = "0x2100AD0")]
		public SplinePoint GetPoint(int connectionIndex, bool swapTangents)
		{
			return default(SplinePoint);
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x2100D40", Offset = "0x2100D40", VA = "0x2100D40")]
		public void SetPoint(int connectionIndex, SplinePoint worldPoint, bool swappedTangents)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x2101224", Offset = "0x2101224", VA = "0x2101224")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x2101228", Offset = "0x2101228", VA = "0x2101228")]
		public void ClearConnections()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x2100734", Offset = "0x2100734", VA = "0x2100734")]
		public void UpdateConnectedComputers([Optional] SplineComputer excludeComputer)
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x21014F8", Offset = "0x21014F8", VA = "0x21014F8")]
		public void UpdatePoint(SplineComputer computer, int pointIndex, SplinePoint point, bool updatePosition = true)
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x21003BC", Offset = "0x21003BC", VA = "0x21003BC")]
		private void UpdatePoints()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x2101644", Offset = "0x2101644", VA = "0x2101644")]
		protected void RemoveInvalidConnections()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x21016D8", Offset = "0x21016D8", VA = "0x21016D8", Slot = "4")]
		public virtual void AddConnection(SplineComputer computer, int pointIndex)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x21010E4", Offset = "0x21010E4", VA = "0x21010E4")]
		protected SplinePoint PointToLocal(SplinePoint worldPoint)
		{
			return default(SplinePoint);
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x2100BF4", Offset = "0x2100BF4", VA = "0x2100BF4")]
		protected SplinePoint PointToWorld(SplinePoint localPoint)
		{
			return default(SplinePoint);
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x2101AC4", Offset = "0x2101AC4", VA = "0x2101AC4", Slot = "5")]
		public virtual void RemoveConnection(SplineComputer computer, int pointIndex)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x210135C", Offset = "0x210135C", VA = "0x210135C")]
		private void RemoveConnection(int index)
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x2101BC0", Offset = "0x2101BC0", VA = "0x2101BC0", Slot = "6")]
		public virtual bool HasConnection(SplineComputer computer, int pointIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x2101D14", Offset = "0x2101D14", VA = "0x2101D14")]
		public Connection[] GetConnections()
		{
			return null;
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x2101D1C", Offset = "0x2101D1C", VA = "0x2101D1C")]
		public Node()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB121C", Offset = "0xBB121C")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TS_Transform transform;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool applyRotation;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			public bool applyScale;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
			public bool generateLightmapUVs;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
			[SerializeField]
			[HideInInspector]
			private bool _bendMesh;

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[SerializeField]
			[HideInInspector]
			private bool _bendSpline;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
			[SerializeField]
			[HideInInspector]
			private bool _bendCollider;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float colliderUpdateDue;

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float colliderUpdateRate;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private bool updateCollider;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 originalPosition;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Vector3 originalScale;

			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public Quaternion originalRotation;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Quaternion parentRotation;

			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Vector3 positionPercent;

			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Vector3[] vertexPercents;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Vector3[] normals;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public Vector3[] colliderVertexPercents;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Vector3[] colliderNormals;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[SerializeField]
			[HideInInspector]
			private Mesh originalMesh;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[SerializeField]
			[HideInInspector]
			private Mesh originalColliderMesh;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Spline _originalSpline;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[SerializeField]
			[HideInInspector]
			private Mesh destinationMesh;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[SerializeField]
			[HideInInspector]
			private Mesh destinationColliderMesh;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			public Spline destinationSpline;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			public TS_Mesh _editMesh;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			public TS_Mesh _editColliderMesh;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			public MeshFilter filter;

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			public MeshCollider collider;

			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			public SplineComputer splineComputer;

			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			public Vector3[] splinePointPercents;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			public Vector3[] primaryTangentPercents;

			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			public Vector3[] secondaryTangentPercents;

			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[SerializeField]
			[HideInInspector]
			private bool parent;

			[Token(Token = "0x17000330")]
			public bool isValid
			{
				[Token(Token = "0x6000904")]
				[Address(RVA = "0x26A5930", Offset = "0x26A5930", VA = "0x26A5930")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000331")]
			public bool bendMesh
			{
				[Token(Token = "0x6000905")]
				[Address(RVA = "0x26A59B4", Offset = "0x26A59B4", VA = "0x26A59B4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000906")]
				[Address(RVA = "0x26A59BC", Offset = "0x26A59BC", VA = "0x26A59BC")]
				set
				{
				}
			}

			[Token(Token = "0x17000332")]
			public bool bendCollider
			{
				[Token(Token = "0x6000907")]
				[Address(RVA = "0x26A5BF8", Offset = "0x26A5BF8", VA = "0x26A5BF8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000908")]
				[Address(RVA = "0x26A5C00", Offset = "0x26A5C00", VA = "0x26A5C00")]
				set
				{
				}
			}

			[Token(Token = "0x17000333")]
			public bool bendSpline
			{
				[Token(Token = "0x6000909")]
				[Address(RVA = "0x26A5E08", Offset = "0x26A5E08", VA = "0x26A5E08")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600090A")]
				[Address(RVA = "0x26A5E10", Offset = "0x26A5E10", VA = "0x26A5E10")]
				set
				{
				}
			}

			[Token(Token = "0x17000334")]
			public TS_Mesh editMesh
			{
				[Token(Token = "0x600090B")]
				[Address(RVA = "0x26A5E1C", Offset = "0x26A5E1C", VA = "0x26A5E1C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000335")]
			public TS_Mesh editColliderMesh
			{
				[Token(Token = "0x600090C")]
				[Address(RVA = "0x26A5F38", Offset = "0x26A5F38", VA = "0x26A5F38")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000336")]
			public Spline originalSpline
			{
				[Token(Token = "0x600090D")]
				[Address(RVA = "0x26A6084", Offset = "0x26A6084", VA = "0x26A6084")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600090E")]
			[Address(RVA = "0x26A61E4", Offset = "0x26A61E4", VA = "0x26A61E4")]
			public BendProperty(Transform t, bool isParent = false)
			{
			}

			[Token(Token = "0x600090F")]
			[Address(RVA = "0x26A6944", Offset = "0x26A6944", VA = "0x26A6944")]
			public void Revert()
			{
			}

			[Token(Token = "0x6000910")]
			[Address(RVA = "0x26A5B60", Offset = "0x26A5B60", VA = "0x26A5B60")]
			private void RevertMesh()
			{
			}

			[Token(Token = "0x6000911")]
			[Address(RVA = "0x26A6A08", Offset = "0x26A6A08", VA = "0x26A6A08")]
			private void RevertTransform()
			{
			}

			[Token(Token = "0x6000912")]
			[Address(RVA = "0x26A5D70", Offset = "0x26A5D70", VA = "0x26A5D70")]
			private void RevertCollider()
			{
			}

			[Token(Token = "0x6000913")]
			[Address(RVA = "0x26A6A8C", Offset = "0x26A6A8C", VA = "0x26A6A8C")]
			public void Apply(bool applyTransform)
			{
			}

			[Token(Token = "0x6000914")]
			[Address(RVA = "0x26A6DE8", Offset = "0x26A6DE8", VA = "0x26A6DE8")]
			public void Update()
			{
			}

			[Token(Token = "0x6000915")]
			[Address(RVA = "0x26A6C14", Offset = "0x26A6C14", VA = "0x26A6C14")]
			private void ApplyMesh()
			{
			}

			[Token(Token = "0x6000916")]
			[Address(RVA = "0x26A6E34", Offset = "0x26A6E34", VA = "0x26A6E34")]
			private void ApplyCollider()
			{
			}

			[Token(Token = "0x6000917")]
			[Address(RVA = "0x26A6DB8", Offset = "0x26A6DB8", VA = "0x26A6DB8")]
			private void ApplySpline()
			{
			}
		}

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x93")]
		[SerializeField]
		[HideInInspector]
		private bool _bend;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public BendProperty[] bendProperties;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[HideInInspector]
		private TS_Bounds bounds;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[HideInInspector]
		private Axis _axis;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[SerializeField]
		[HideInInspector]
		private NormalMode _normalMode;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[HideInInspector]
		private ForwardMode _forwardMode;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBB38BC", Offset = "0xBB38BC")]
		private Vector3 _customNormal;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[HideInInspector]
		private Vector3 _customForward;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Matrix4x4 normalMatrix;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private Quaternion bendRotation;

		[Token(Token = "0x17000296")]
		public bool bend
		{
			[Token(Token = "0x6000572")]
			[Address(RVA = "0x2102688", Offset = "0x2102688", VA = "0x2102688")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000573")]
			[Address(RVA = "0x2102690", Offset = "0x2102690", VA = "0x2102690")]
			set
			{
			}
		}

		[Token(Token = "0x17000297")]
		public Axis axis
		{
			[Token(Token = "0x6000574")]
			[Address(RVA = "0x2102920", Offset = "0x2102920", VA = "0x2102920")]
			get
			{
				return default(Axis);
			}
			[Token(Token = "0x6000575")]
			[Address(RVA = "0x2102928", Offset = "0x2102928", VA = "0x2102928")]
			set
			{
			}
		}

		[Token(Token = "0x17000298")]
		public NormalMode upMode
		{
			[Token(Token = "0x6000576")]
			[Address(RVA = "0x21029E0", Offset = "0x21029E0", VA = "0x21029E0")]
			get
			{
				return default(NormalMode);
			}
			[Token(Token = "0x6000577")]
			[Address(RVA = "0x21029E8", Offset = "0x21029E8", VA = "0x21029E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000299")]
		public Vector3 customNormal
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x2102A98", Offset = "0x2102A98", VA = "0x2102A98")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000579")]
			[Address(RVA = "0x2102AA4", Offset = "0x2102AA4", VA = "0x2102AA4")]
			set
			{
			}
		}

		[Token(Token = "0x1700029A")]
		public ForwardMode forwardMode
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x2102B84", Offset = "0x2102B84", VA = "0x2102B84")]
			get
			{
				return default(ForwardMode);
			}
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x2102B8C", Offset = "0x2102B8C", VA = "0x2102B8C")]
			set
			{
			}
		}

		[Token(Token = "0x1700029B")]
		public Vector3 customForward
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x2102C3C", Offset = "0x2102C3C", VA = "0x2102C3C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600057D")]
			[Address(RVA = "0x2102C48", Offset = "0x2102C48", VA = "0x2102C48")]
			set
			{
			}
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x2102D28", Offset = "0x2102D28", VA = "0x2102D28")]
		private void GetTransformsRecursively(Transform current, ref List<Transform> transformList)
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x2102FF4", Offset = "0x2102FF4", VA = "0x2102FF4")]
		private void GetObjects()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x21034D8", Offset = "0x21034D8", VA = "0x21034D8")]
		public TS_Bounds GetBounds()
		{
			return null;
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x2103150", Offset = "0x2103150", VA = "0x2103150")]
		private void CreateProperty(ref BendProperty property, Transform t)
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x210359C", Offset = "0x210359C", VA = "0x210359C")]
		private void CalculateBounds()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x2103720", Offset = "0x2103720", VA = "0x2103720")]
		private void CalculatePropertyBounds(ref BendProperty property)
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x2103D08", Offset = "0x2103D08", VA = "0x2103D08")]
		public void CalculatePercents(BendProperty property)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x21028B4", Offset = "0x21028B4", VA = "0x21028B4")]
		private void Revert()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x21026FC", Offset = "0x21026FC", VA = "0x21026FC")]
		public void UpdateReferences()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x210438C", Offset = "0x210438C", VA = "0x210438C")]
		private void GetevalResult(Vector3 percentage)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x2104268", Offset = "0x2104268", VA = "0x2104268")]
		private Vector3 GetPercentage(Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x210490C", Offset = "0x210490C", VA = "0x210490C", Slot = "14")]
		protected override void Build()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x2104308", Offset = "0x2104308", VA = "0x2104308")]
		private void Bend()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x2104948", Offset = "0x2104948", VA = "0x2104948")]
		public void BendObject(BendProperty p)
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x2104EA4", Offset = "0x2104EA4", VA = "0x2104EA4")]
		private void BendMesh(Vector3[] vertexPercents, Vector3[] originalNormals, TS_Mesh mesh, Matrix4x4 worldToLocalMatrix)
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x21050A4", Offset = "0x21050A4", VA = "0x21050A4", Slot = "15")]
		protected override void PostBuild()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x21051E8", Offset = "0x21051E8", VA = "0x21051E8", Slot = "13")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x210525C", Offset = "0x210525C", VA = "0x210525C")]
		public ObjectBender()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB1254", Offset = "0xBB1254")]
	public class ObjectController : SplineUser
	{
		[Serializable]
		[Token(Token = "0x20000B5")]
		internal class ObjectControl
		{
			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject gameObject;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 position;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion rotation;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 scale;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool active;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Vector3 baseScale;

			[Token(Token = "0x17000337")]
			public bool isNull
			{
				[Token(Token = "0x6000918")]
				[Address(RVA = "0x26A71F8", Offset = "0x26A71F8", VA = "0x26A71F8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000338")]
			public Transform transform
			{
				[Token(Token = "0x6000919")]
				[Address(RVA = "0x26A7264", Offset = "0x26A7264", VA = "0x26A7264")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600091A")]
			[Address(RVA = "0x26A72F8", Offset = "0x26A72F8", VA = "0x26A72F8")]
			public ObjectControl(GameObject input)
			{
			}

			[Token(Token = "0x600091B")]
			[Address(RVA = "0x26A73B0", Offset = "0x26A73B0", VA = "0x26A73B0")]
			public void Destroy()
			{
			}

			[Token(Token = "0x600091C")]
			[Address(RVA = "0x26A7460", Offset = "0x26A7460", VA = "0x26A7460")]
			public void DestroyImmediate()
			{
			}

			[Token(Token = "0x600091D")]
			[Address(RVA = "0x26A7510", Offset = "0x26A7510", VA = "0x26A7510")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB19AC", Offset = "0xBB19AC")]
		private sealed class <InstantiateAllWithDelay>d__94 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ObjectController <>4__this;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x17000339")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000921")]
				[Address(RVA = "0x26A71A8", Offset = "0x26A71A8", VA = "0x26A71A8", Slot = "4")]
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
				[Address(RVA = "0x26A71F0", Offset = "0x26A71F0", VA = "0x26A71F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600091E")]
			[Address(RVA = "0x26A702C", Offset = "0x26A702C", VA = "0x26A702C")]
			[DebuggerHidden]
			public <InstantiateAllWithDelay>d__94(int <>1__state)
			{
			}

			[Token(Token = "0x600091F")]
			[Address(RVA = "0x26A7058", Offset = "0x26A7058", VA = "0x26A7058", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000920")]
			[Address(RVA = "0x26A705C", Offset = "0x26A705C", VA = "0x26A705C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000922")]
			[Address(RVA = "0x26A71B0", Offset = "0x26A71B0", VA = "0x26A71B0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		[HideInInspector]
		public GameObject[] objects;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[HideInInspector]
		private float _evaluateOffset;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[SerializeField]
		[HideInInspector]
		private int _spawnCount;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[HideInInspector]
		private Positioning _objectPositioning;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[SerializeField]
		[HideInInspector]
		private Iteration _iteration;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[HideInInspector]
		private int _randomSeed;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[SerializeField]
		[HideInInspector]
		private Vector3 _minOffset;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[HideInInspector]
		private Vector3 _maxOffset;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		[HideInInspector]
		private bool _offsetUseWorldCoords;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[HideInInspector]
		private Vector3 _minRotation;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		[HideInInspector]
		private Vector3 _maxRotation;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[HideInInspector]
		private bool _uniformScaleLerp;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[SerializeField]
		[HideInInspector]
		private Vector3 _minScaleMultiplier;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[HideInInspector]
		private Vector3 _maxScaleMultiplier;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[SerializeField]
		[HideInInspector]
		private bool _shellOffset;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x105")]
		[SerializeField]
		[HideInInspector]
		private bool _applyRotation;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x106")]
		[SerializeField]
		[HideInInspector]
		private bool _rotateByOffset;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x107")]
		[SerializeField]
		[HideInInspector]
		private bool _applyScale;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		[HideInInspector]
		private ObjectMethod _objectMethod;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[HideInInspector]
		public bool delayedSpawn;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[HideInInspector]
		public float spawnDelay;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[SerializeField]
		[HideInInspector]
		private int lastChildCount;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		[HideInInspector]
		private ObjectControl[] spawned;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private System.Random offsetRandomizer;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private System.Random shellRandomizer;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private System.Random rotationRandomizer;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private System.Random scaleRandomizer;

		[Token(Token = "0x1700029C")]
		public ObjectMethod objectMethod
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x2105308", Offset = "0x2105308", VA = "0x2105308")]
			get
			{
				return default(ObjectMethod);
			}
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x2105310", Offset = "0x2105310", VA = "0x2105310")]
			set
			{
			}
		}

		[Token(Token = "0x1700029D")]
		public int spawnCount
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x21053DC", Offset = "0x21053DC", VA = "0x21053DC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x21053E4", Offset = "0x21053E4", VA = "0x21053E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700029E")]
		public Positioning objectPositioning
		{
			[Token(Token = "0x6000594")]
			[Address(RVA = "0x2105684", Offset = "0x2105684", VA = "0x2105684")]
			get
			{
				return default(Positioning);
			}
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x210568C", Offset = "0x210568C", VA = "0x210568C")]
			set
			{
			}
		}

		[Token(Token = "0x1700029F")]
		public Iteration iteration
		{
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x21056AC", Offset = "0x21056AC", VA = "0x21056AC")]
			get
			{
				return default(Iteration);
			}
			[Token(Token = "0x6000597")]
			[Address(RVA = "0x21056B4", Offset = "0x21056B4", VA = "0x21056B4")]
			set
			{
			}
		}

		[Token(Token = "0x170002A0")]
		public int randomSeed
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x21056D4", Offset = "0x21056D4", VA = "0x21056D4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x21056DC", Offset = "0x21056DC", VA = "0x21056DC")]
			set
			{
			}
		}

		[Token(Token = "0x170002A1")]
		public Vector3 minOffset
		{
			[Token(Token = "0x600059A")]
			[Address(RVA = "0x21056FC", Offset = "0x21056FC", VA = "0x21056FC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x2105708", Offset = "0x2105708", VA = "0x2105708")]
			set
			{
			}
		}

		[Token(Token = "0x170002A2")]
		public Vector3 maxOffset
		{
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x210577C", Offset = "0x210577C", VA = "0x210577C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600059D")]
			[Address(RVA = "0x2105788", Offset = "0x2105788", VA = "0x2105788")]
			set
			{
			}
		}

		[Token(Token = "0x170002A3")]
		public bool offsetUseWorldCoords
		{
			[Token(Token = "0x600059E")]
			[Address(RVA = "0x21057FC", Offset = "0x21057FC", VA = "0x21057FC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600059F")]
			[Address(RVA = "0x2105804", Offset = "0x2105804", VA = "0x2105804")]
			set
			{
			}
		}

		[Token(Token = "0x170002A4")]
		public Vector3 minRotation
		{
			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x2105830", Offset = "0x2105830", VA = "0x2105830")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x210583C", Offset = "0x210583C", VA = "0x210583C")]
			set
			{
			}
		}

		[Token(Token = "0x170002A5")]
		public Vector3 maxRotation
		{
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x21058B0", Offset = "0x21058B0", VA = "0x21058B0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x21058BC", Offset = "0x21058BC", VA = "0x21058BC")]
			set
			{
			}
		}

		[Token(Token = "0x170002A6")]
		public Vector3 rotationOffset
		{
			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x2105930", Offset = "0x2105930", VA = "0x2105930")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x2105960", Offset = "0x2105960", VA = "0x2105960")]
			set
			{
			}
		}

		[Token(Token = "0x170002A7")]
		public Vector3 minScaleMultiplier
		{
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x21059F8", Offset = "0x21059F8", VA = "0x21059F8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x2105A04", Offset = "0x2105A04", VA = "0x2105A04")]
			set
			{
			}
		}

		[Token(Token = "0x170002A8")]
		public Vector3 maxScaleMultiplier
		{
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x2105A78", Offset = "0x2105A78", VA = "0x2105A78")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x2105A84", Offset = "0x2105A84", VA = "0x2105A84")]
			set
			{
			}
		}

		[Token(Token = "0x170002A9")]
		public bool uniformScaleLerp
		{
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x2105AF8", Offset = "0x2105AF8", VA = "0x2105AF8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x2105B00", Offset = "0x2105B00", VA = "0x2105B00")]
			set
			{
			}
		}

		[Token(Token = "0x170002AA")]
		public bool shellOffset
		{
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x2105B2C", Offset = "0x2105B2C", VA = "0x2105B2C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x2105B34", Offset = "0x2105B34", VA = "0x2105B34")]
			set
			{
			}
		}

		[Token(Token = "0x170002AB")]
		public bool applyRotation
		{
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x2105B60", Offset = "0x2105B60", VA = "0x2105B60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x2105B68", Offset = "0x2105B68", VA = "0x2105B68")]
			set
			{
			}
		}

		[Token(Token = "0x170002AC")]
		public bool rotateByOffset
		{
			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x2105B94", Offset = "0x2105B94", VA = "0x2105B94")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x2105B9C", Offset = "0x2105B9C", VA = "0x2105B9C")]
			set
			{
			}
		}

		[Token(Token = "0x170002AD")]
		public bool applyScale
		{
			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x2105BC8", Offset = "0x2105BC8", VA = "0x2105BC8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x2105BD0", Offset = "0x2105BD0", VA = "0x2105BD0")]
			set
			{
			}
		}

		[Token(Token = "0x170002AE")]
		public float evaluateOffset
		{
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x2105BFC", Offset = "0x2105BFC", VA = "0x2105BFC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x2105C04", Offset = "0x2105C04", VA = "0x2105C04")]
			set
			{
			}
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x2105C24", Offset = "0x2105C24", VA = "0x2105C24")]
		public void Clear()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x2105DC8", Offset = "0x2105DC8", VA = "0x2105DC8")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x2105418", Offset = "0x2105418", VA = "0x2105418")]
		private void Remove()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x2105DDC", Offset = "0x2105DDC", VA = "0x2105DDC")]
		public void GetAll()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x2105330", Offset = "0x2105330", VA = "0x2105330")]
		public void Spawn()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x21064E0", Offset = "0x21064E0", VA = "0x21064E0", Slot = "13")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x21063B0", Offset = "0x21063B0", VA = "0x21063B0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBB6C50", Offset = "0xBB6C50")]
		private IEnumerator InstantiateAllWithDelay()
		{
			return null;
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x2106428", Offset = "0x2106428", VA = "0x2106428")]
		private void InstantiateAll()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x210655C", Offset = "0x210655C", VA = "0x210655C")]
		private void InstantiateSingle()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x2106884", Offset = "0x2106884", VA = "0x2106884", Slot = "14")]
		protected override void Build()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x21070AC", Offset = "0x21070AC", VA = "0x21070AC", Slot = "15")]
		protected override void PostBuild()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x2107120", Offset = "0x2107120", VA = "0x2107120")]
		public ObjectController()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB128C", Offset = "0xBB128C")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Vector2 startOffset;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Vector2 endOffset;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal float cycleSpeed;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal float startLifetime;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Color startColor;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal float remainingLifetime;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal float lifeTime;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal double startPercent;

			[Token(Token = "0x6000924")]
			[Address(RVA = "0x26A765C", Offset = "0x26A765C", VA = "0x26A765C")]
			internal double GetSplinePercent(Wrap wrap, ParticleSystem.Particle particle)
			{
				return default(double);
			}

			[Token(Token = "0x6000925")]
			[Address(RVA = "0x26A7744", Offset = "0x26A7744", VA = "0x26A7744")]
			public Particle()
			{
			}
		}

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public ParticleSystem _particleSystem;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public bool volumetric;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		[HideInInspector]
		public bool emitFromShell;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[HideInInspector]
		public Vector2 scale;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[HideInInspector]
		public EmitPoint emitPoint;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		public MotionType motionType;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[HideInInspector]
		public Wrap wrapMode;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		public float minCycles;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[HideInInspector]
		public float maxCycles;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private ParticleSystem.Particle[] particles;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Particle[] controllers;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int particleCount;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int birthIndex;

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x2107844", Offset = "0x2107844", VA = "0x2107844", Slot = "13")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x2107D20", Offset = "0x2107D20", VA = "0x2107D20")]
		private void TransformParticle(ref ParticleSystem.Particle particle, Transform trs)
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x2108910", Offset = "0x2108910", VA = "0x2108910")]
		private void InverseTransformParticle(ref ParticleSystem.Particle particle, Transform trs)
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x2108DCC", Offset = "0x2108DCC", VA = "0x2108DCC", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x210897C", Offset = "0x210897C", VA = "0x210897C")]
		private void HandleParticle(int index)
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x2108E9C", Offset = "0x2108E9C", VA = "0x2108E9C")]
		private void OnParticleDie(int index)
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x2107D8C", Offset = "0x2107D8C", VA = "0x2107D8C")]
		private void OnParticleBorn(int index)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x2108EA0", Offset = "0x2108EA0", VA = "0x2108EA0")]
		public ParticleController()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBB12D8", Offset = "0xBB12D8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBB12D8", Offset = "0xBB12D8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB12D8", Offset = "0xBB12D8")]
	public class PathGenerator : MeshGenerator
	{
		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		[HideInInspector]
		private int _slices;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[SerializeField]
		[HideInInspector]
		private bool _useShapeCurve;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		[HideInInspector]
		private AnimationCurve _shape;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		[HideInInspector]
		private AnimationCurve _lastShape;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		[HideInInspector]
		private float _shapeExposure;

		[Token(Token = "0x170002AF")]
		public int slices
		{
			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x2108F54", Offset = "0x2108F54", VA = "0x2108F54")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x2108F5C", Offset = "0x2108F5C", VA = "0x2108F5C")]
			set
			{
			}
		}

		[Token(Token = "0x170002B0")]
		public bool useShapeCurve
		{
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x2108F84", Offset = "0x2108F84", VA = "0x2108F84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x2108F8C", Offset = "0x2108F8C", VA = "0x2108F8C")]
			set
			{
			}
		}

		[Token(Token = "0x170002B1")]
		public float shapeExposure
		{
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x21090E4", Offset = "0x21090E4", VA = "0x21090E4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x21090EC", Offset = "0x21090EC", VA = "0x21090EC")]
			set
			{
			}
		}

		[Token(Token = "0x170002B2")]
		public AnimationCurve shape
		{
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x2109198", Offset = "0x2109198", VA = "0x2109198")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x21091A0", Offset = "0x21091A0", VA = "0x21091A0")]
			set
			{
			}
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x2109524", Offset = "0x2109524", VA = "0x2109524", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x2109588", Offset = "0x2109588", VA = "0x2109588", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x2109590", Offset = "0x2109590", VA = "0x2109590", Slot = "18")]
		protected override void BuildMesh()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x2109658", Offset = "0x2109658", VA = "0x2109658")]
		private void GenerateVertices()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x210A134", Offset = "0x210A134", VA = "0x210A134")]
		public PathGenerator()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB1390", Offset = "0xBB1390")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBB1390", Offset = "0xBB1390")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		[HideInInspector]
		private Type _type;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		[HideInInspector]
		private float _size;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[SerializeField]
		[HideInInspector]
		private float _offset;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[HideInInspector]
		protected PolygonCollider2D polygonCollider;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[HideInInspector]
		protected Vector2[] vertices;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		public float updateRate;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		protected float lastUpdateTime;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool updateCollider;

		[Token(Token = "0x170002B3")]
		public Type type
		{
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x210A4FC", Offset = "0x210A4FC", VA = "0x210A4FC")]
			get
			{
				return default(Type);
			}
			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x210A504", Offset = "0x210A504", VA = "0x210A504")]
			set
			{
			}
		}

		[Token(Token = "0x170002B4")]
		public float size
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x210A524", Offset = "0x210A524", VA = "0x210A524")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x210A52C", Offset = "0x210A52C", VA = "0x210A52C")]
			set
			{
			}
		}

		[Token(Token = "0x170002B5")]
		public float offset
		{
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x210A54C", Offset = "0x210A54C", VA = "0x210A54C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x210A554", Offset = "0x210A554", VA = "0x210A554")]
			set
			{
			}
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x210A574", Offset = "0x210A574", VA = "0x210A574", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x210A5DC", Offset = "0x210A5DC", VA = "0x210A5DC", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x210A5E4", Offset = "0x210A5E4", VA = "0x210A5E4", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x210A5EC", Offset = "0x210A5EC", VA = "0x210A5EC", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x210A5F4", Offset = "0x210A5F4", VA = "0x210A5F4", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x210A5FC", Offset = "0x210A5FC", VA = "0x210A5FC", Slot = "13")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x210A6D0", Offset = "0x210A6D0", VA = "0x210A6D0", Slot = "14")]
		protected override void Build()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x210AA34", Offset = "0x210AA34", VA = "0x210AA34", Slot = "15")]
		protected override void PostBuild()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x210A72C", Offset = "0x210A72C", VA = "0x210A72C")]
		private void GeneratePath()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x210A8D0", Offset = "0x210A8D0", VA = "0x210A8D0")]
		private void GenerateShape()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x210AB80", Offset = "0x210AB80", VA = "0x210AB80")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Color color;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public BlendMode blendMode;

			[Token(Token = "0x6000926")]
			[Address(RVA = "0x26A485C", Offset = "0x26A485C", VA = "0x26A485C")]
			public ColorKey(double f, double t, ColorModifier modifier)
			{
			}

			[Token(Token = "0x6000927")]
			[Address(RVA = "0x26A4970", Offset = "0x26A4970", VA = "0x26A4970")]
			public Color Blend(Color input, float percent)
			{
				return default(Color);
			}
		}

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<ColorKey> keys;

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x19BECEC", Offset = "0x19BECEC", VA = "0x19BECEC")]
		public ColorModifier()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x19BEDA8", Offset = "0x19BEDA8", VA = "0x19BEDA8", Slot = "4")]
		public override List<Key> GetKeys()
		{
			return null;
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x19BEEAC", Offset = "0x19BEEAC", VA = "0x19BEEAC", Slot = "5")]
		public override void SetKeys(List<Key> input)
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x19BF028", Offset = "0x19BF028", VA = "0x19BF028")]
		public void AddKey(double f, double t)
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x19BF0D0", Offset = "0x19BF0D0", VA = "0x19BF0D0", Slot = "6")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Vector2 scale;

			[Token(Token = "0x6000928")]
			[Address(RVA = "0x26A57DC", Offset = "0x26A57DC", VA = "0x26A57DC")]
			public ScaleKey(double f, double t, MeshScaleModifier modifier)
			{
			}
		}

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<ScaleKey> keys;

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x19CC314", Offset = "0x19CC314", VA = "0x19CC314")]
		public MeshScaleModifier()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x19CC3D0", Offset = "0x19CC3D0", VA = "0x19CC3D0", Slot = "4")]
		public override List<Key> GetKeys()
		{
			return null;
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x19CC4D4", Offset = "0x19CC4D4", VA = "0x19CC4D4", Slot = "5")]
		public override void SetKeys(List<Key> input)
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x19CC66C", Offset = "0x19CC66C", VA = "0x19CC66C")]
		public void AddKey(double f, double t)
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x19CC714", Offset = "0x19CC714", VA = "0x19CC714", Slot = "6")]
		public override void Apply(SplineSample result)
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x19CC830", Offset = "0x19CC830", VA = "0x19CC830")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Vector2 offset;

			[Token(Token = "0x6000929")]
			[Address(RVA = "0x26A75F8", Offset = "0x26A75F8", VA = "0x26A75F8")]
			public OffsetKey(Vector2 o, double f, double t, OffsetModifier modifier)
			{
			}
		}

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<OffsetKey> keys;

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x2107234", Offset = "0x2107234", VA = "0x2107234")]
		public OffsetModifier()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x21072F0", Offset = "0x21072F0", VA = "0x21072F0", Slot = "4")]
		public override List<Key> GetKeys()
		{
			return null;
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x21073F4", Offset = "0x21073F4", VA = "0x21073F4", Slot = "5")]
		public override void SetKeys(List<Key> input)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x2107570", Offset = "0x2107570", VA = "0x2107570")]
		public void AddKey(Vector2 offset, double f, double t)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x2107630", Offset = "0x2107630", VA = "0x2107630", Slot = "6")]
		public override void Apply(SplineSample result)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x2107714", Offset = "0x2107714", VA = "0x2107714")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool useLookTarget;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform target;

			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 rotation;

			[Token(Token = "0x600092A")]
			[Address(RVA = "0x26A8568", Offset = "0x26A8568", VA = "0x26A8568")]
			public RotationKey(Vector3 rotation, double f, double t, RotationModifier modifier)
			{
			}
		}

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<RotationKey> keys;

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x26F1A00", Offset = "0x26F1A00", VA = "0x26F1A00")]
		public RotationModifier()
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x26F1ABC", Offset = "0x26F1ABC", VA = "0x26F1ABC", Slot = "4")]
		public override List<Key> GetKeys()
		{
			return null;
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x26F1BC0", Offset = "0x26F1BC0", VA = "0x26F1BC0", Slot = "5")]
		public override void SetKeys(List<Key> input)
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x26F1D3C", Offset = "0x26F1D3C", VA = "0x26F1D3C")]
		public void AddKey(Vector3 rotation, double f, double t)
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x26F1E0C", Offset = "0x26F1E0C", VA = "0x26F1E0C", Slot = "6")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float size;

			[Token(Token = "0x600092B")]
			[Address(RVA = "0x26A8764", Offset = "0x26A8764", VA = "0x26A8764")]
			public SizeKey(double f, double t, SizeModifier modifier)
			{
			}
		}

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<SizeKey> keys;

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x26FCB54", Offset = "0x26FCB54", VA = "0x26FCB54")]
		public SizeModifier()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x26FCC10", Offset = "0x26FCC10", VA = "0x26FCC10", Slot = "4")]
		public override List<Key> GetKeys()
		{
			return null;
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x26FCD14", Offset = "0x26FCD14", VA = "0x26FCD14", Slot = "5")]
		public override void SetKeys(List<Key> input)
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x26FCEAC", Offset = "0x26FCEAC", VA = "0x26FCEAC")]
		public void AddKey(double f, double t)
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x26FCF54", Offset = "0x26FCF54", VA = "0x26FCF54", Slot = "6")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private double _featherStart;

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private double _featherEnd;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private double _centerStart;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[SerializeField]
			private double _centerEnd;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[SerializeField]
			internal SplineSampleModifier modifier;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public AnimationCurve interpolation;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float blend;

			[Token(Token = "0x1700033B")]
			public double start
			{
				[Token(Token = "0x600092C")]
				[Address(RVA = "0x26ADC4C", Offset = "0x26ADC4C", VA = "0x26ADC4C")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x600092D")]
				[Address(RVA = "0x26ADC54", Offset = "0x26ADC54", VA = "0x26ADC54")]
				set
				{
				}
			}

			[Token(Token = "0x1700033C")]
			public double end
			{
				[Token(Token = "0x600092E")]
				[Address(RVA = "0x26ADC88", Offset = "0x26ADC88", VA = "0x26ADC88")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x600092F")]
				[Address(RVA = "0x26ADC90", Offset = "0x26ADC90", VA = "0x26ADC90")]
				set
				{
				}
			}

			[Token(Token = "0x1700033D")]
			public double centerStart
			{
				[Token(Token = "0x6000930")]
				[Address(RVA = "0x26ADCC4", Offset = "0x26ADCC4", VA = "0x26ADCC4")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x6000931")]
				[Address(RVA = "0x26ADCCC", Offset = "0x26ADCCC", VA = "0x26ADCCC")]
				set
				{
				}
			}

			[Token(Token = "0x1700033E")]
			public double centerEnd
			{
				[Token(Token = "0x6000932")]
				[Address(RVA = "0x26ADD0C", Offset = "0x26ADD0C", VA = "0x26ADD0C")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x6000933")]
				[Address(RVA = "0x26ADD14", Offset = "0x26ADD14", VA = "0x26ADD14")]
				set
				{
				}
			}

			[Token(Token = "0x1700033F")]
			public double globalCenterStart
			{
				[Token(Token = "0x6000934")]
				[Address(RVA = "0x26ADD54", Offset = "0x26ADD54", VA = "0x26ADD54")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x6000935")]
				[Address(RVA = "0x26ADDBC", Offset = "0x26ADDBC", VA = "0x26ADDBC")]
				set
				{
				}
			}

			[Token(Token = "0x17000340")]
			public double globalCenterEnd
			{
				[Token(Token = "0x6000936")]
				[Address(RVA = "0x26ADE60", Offset = "0x26ADE60", VA = "0x26ADE60")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x6000937")]
				[Address(RVA = "0x26ADE68", Offset = "0x26ADE68", VA = "0x26ADE68")]
				set
				{
				}
			}

			[Token(Token = "0x17000341")]
			public double position
			{
				[Token(Token = "0x6000938")]
				[Address(RVA = "0x26ADEB4", Offset = "0x26ADEB4", VA = "0x26ADEB4")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x6000939")]
				[Address(RVA = "0x26ADF3C", Offset = "0x26ADF3C", VA = "0x26ADF3C")]
				set
				{
				}
			}

			[Token(Token = "0x600093A")]
			[Address(RVA = "0x26A48AC", Offset = "0x26A48AC", VA = "0x26A48AC")]
			internal Key(double f, double t, SplineSampleModifier modifier)
			{
			}

			[Token(Token = "0x600093B")]
			[Address(RVA = "0x26ADE08", Offset = "0x26ADE08", VA = "0x26ADE08")]
			private double GlobalToLocalPercent(double t)
			{
				return default(double);
			}

			[Token(Token = "0x600093C")]
			[Address(RVA = "0x26ADD5C", Offset = "0x26ADD5C", VA = "0x26ADD5C")]
			private double LocalToGlobalPercent(double t)
			{
				return default(double);
			}

			[Token(Token = "0x600093D")]
			[Address(RVA = "0x26ADFA4", Offset = "0x26ADFA4", VA = "0x26ADFA4")]
			public float Evaluate(double t)
			{
				return default(float);
			}

			[Token(Token = "0x600093E")]
			[Address(RVA = "0x26AE03C", Offset = "0x26AE03C", VA = "0x26AE03C", Slot = "4")]
			public virtual Key Duplicate()
			{
				return null;
			}
		}

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float blend;

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x290635C", Offset = "0x290635C", VA = "0x290635C", Slot = "4")]
		public virtual List<Key> GetKeys()
		{
			return null;
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x29063C8", Offset = "0x29063C8", VA = "0x29063C8", Slot = "5")]
		public virtual void SetKeys(List<Key> input)
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x2906470", Offset = "0x2906470", VA = "0x2906470", Slot = "6")]
		public virtual void Apply(SplineSample result)
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x2906474", Offset = "0x2906474", VA = "0x2906474", Slot = "7")]
		public virtual void Apply(SplineSample source, SplineSample destination)
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x29064B4", Offset = "0x29064B4", VA = "0x29064B4")]
		public SplineSampleModifier()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public delegate void EmptySplineHandler();
	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB1414", Offset = "0xBB1414")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			internal Node node;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			internal int pointIndex;

			[Token(Token = "0x600093F")]
			[Address(RVA = "0x26A8768", Offset = "0x26A8768", VA = "0x26A8768")]
			internal List<Node.Connection> GetConnections(SplineComputer exclude)
			{
				return null;
			}

			[Token(Token = "0x6000940")]
			[Address(RVA = "0x26A88C0", Offset = "0x26A88C0", VA = "0x26A88C0")]
			public NodeLink()
			{
			}
		}

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public bool multithreaded;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[HideInInspector]
		public bool rebuildOnAwake;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[HideInInspector]
		public UpdateMode updateMode;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public TriggerGroup[] triggerGroups;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		[SerializeField]
		private Spline spline;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		[SerializeField]
		private SplineSample[] _rawSamples;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		[SerializeField]
		private SplineSample[] _transformedSamples;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
		private SampleCollection sampleCollection;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		[SerializeField]
		private double[] originalSamplePercents;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool[] sampleFlter;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		[SerializeField]
		private int _sampleCount;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[HideInInspector]
		[SerializeField]
		private bool _is2D;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		[HideInInspector]
		[SerializeField]
		private bool hasSamples;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[SerializeField]
		private bool[] pointsDirty;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBB4310", Offset = "0xBB4310")]
		private float _optimizeAngleThreshold;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[HideInInspector]
		[SerializeField]
		private Space _space;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		[SerializeField]
		private SampleMode _sampleMode;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		[SerializeField]
		private SplineUser[] subscribers;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBB4410", Offset = "0xBB4410")]
		private NodeLink[] nodes;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool rebuildPending;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		private bool _trsCheck;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Transform _trs;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Matrix4x4 transformMatrix;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Matrix4x4 inverseTransformMatrix;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private bool queueResample;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x119")]
		private bool queueRebuild;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 lastScale;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private bool uniformScale;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Quaternion lastRotation;

		[Token(Token = "0x170002B6")]
		public Space space
		{
			[Token(Token = "0x600060C")]
			[Address(RVA = "0x2700A58", Offset = "0x2700A58", VA = "0x2700A58")]
			get
			{
				return default(Space);
			}
			[Token(Token = "0x600060D")]
			[Address(RVA = "0x2700A60", Offset = "0x2700A60", VA = "0x2700A60")]
			set
			{
			}
		}

		[Token(Token = "0x170002B7")]
		public Spline.Type type
		{
			[Token(Token = "0x600060E")]
			[Address(RVA = "0x26F35A4", Offset = "0x26F35A4", VA = "0x26F35A4")]
			get
			{
				return default(Spline.Type);
			}
			[Token(Token = "0x600060F")]
			[Address(RVA = "0x2700F40", Offset = "0x2700F40", VA = "0x2700F40")]
			set
			{
			}
		}

		[Token(Token = "0x170002B8")]
		public bool linearAverageDirection
		{
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x2700F8C", Offset = "0x2700F8C", VA = "0x2700F8C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000611")]
			[Address(RVA = "0x2700FA8", Offset = "0x2700FA8", VA = "0x2700FA8")]
			set
			{
			}
		}

		[Token(Token = "0x170002B9")]
		public bool is2D
		{
			[Token(Token = "0x6000612")]
			[Address(RVA = "0x2701000", Offset = "0x2701000", VA = "0x2701000")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000613")]
			[Address(RVA = "0x2701008", Offset = "0x2701008", VA = "0x2701008")]
			set
			{
			}
		}

		[Token(Token = "0x170002BA")]
		public int sampleRate
		{
			[Token(Token = "0x6000614")]
			[Address(RVA = "0x26F35C0", Offset = "0x26F35C0", VA = "0x26F35C0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000615")]
			[Address(RVA = "0x2701058", Offset = "0x2701058", VA = "0x2701058")]
			set
			{
			}
		}

		[Token(Token = "0x170002BB")]
		public float optimizeAngleThreshold
		{
			[Token(Token = "0x6000616")]
			[Address(RVA = "0x27010B0", Offset = "0x27010B0", VA = "0x27010B0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000617")]
			[Address(RVA = "0x27010B8", Offset = "0x27010B8", VA = "0x27010B8")]
			set
			{
			}
		}

		[Token(Token = "0x170002BC")]
		public SampleMode sampleMode
		{
			[Token(Token = "0x6000618")]
			[Address(RVA = "0x2701114", Offset = "0x2701114", VA = "0x2701114")]
			get
			{
				return default(SampleMode);
			}
			[Token(Token = "0x6000619")]
			[Address(RVA = "0x270111C", Offset = "0x270111C", VA = "0x270111C")]
			set
			{
			}
		}

		[Token(Token = "0x170002BD")]
		public AnimationCurve customValueInterpolation
		{
			[Token(Token = "0x600061A")]
			[Address(RVA = "0x270115C", Offset = "0x270115C", VA = "0x270115C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600061B")]
			[Address(RVA = "0x2701178", Offset = "0x2701178", VA = "0x2701178")]
			set
			{
			}
		}

		[Token(Token = "0x170002BE")]
		public AnimationCurve customNormalInterpolation
		{
			[Token(Token = "0x600061C")]
			[Address(RVA = "0x27011B8", Offset = "0x27011B8", VA = "0x27011B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600061D")]
			[Address(RVA = "0x27011D4", Offset = "0x27011D4", VA = "0x27011D4")]
			set
			{
			}
		}

		[Token(Token = "0x170002BF")]
		public int iterations
		{
			[Token(Token = "0x600061E")]
			[Address(RVA = "0x2701214", Offset = "0x2701214", VA = "0x2701214")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170002C0")]
		public double moveStep
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0x270122C", Offset = "0x270122C", VA = "0x270122C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170002C1")]
		public bool isClosed
		{
			[Token(Token = "0x6000620")]
			[Address(RVA = "0x26F3C0C", Offset = "0x26F3C0C", VA = "0x26F3C0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170002C2")]
		public int pointCount
		{
			[Token(Token = "0x6000621")]
			[Address(RVA = "0x2701244", Offset = "0x2701244", VA = "0x2701244")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170002C3")]
		public SplineSample[] samples
		{
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x270126C", Offset = "0x270126C", VA = "0x270126C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002C4")]
		public int sampleCount
		{
			[Token(Token = "0x6000623")]
			[Address(RVA = "0x2701288", Offset = "0x2701288", VA = "0x2701288")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170002C5")]
		public SplineSample[] rawSamples
		{
			[Token(Token = "0x6000624")]
			[Address(RVA = "0x2701290", Offset = "0x2701290", VA = "0x2701290")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002C6")]
		public Vector3 position
		{
			[Token(Token = "0x6000625")]
			[Address(RVA = "0x2701298", Offset = "0x2701298", VA = "0x2701298")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170002C7")]
		public Quaternion rotation
		{
			[Token(Token = "0x6000626")]
			[Address(RVA = "0x27012A8", Offset = "0x27012A8", VA = "0x27012A8")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x170002C8")]
		public Vector3 scale
		{
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x27012BC", Offset = "0x27012BC", VA = "0x27012BC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170002C9")]
		public int subscriberCount
		{
			[Token(Token = "0x6000628")]
			[Address(RVA = "0x27012CC", Offset = "0x27012CC", VA = "0x27012CC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170002CA")]
		public Transform trs
		{
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x27012E8", Offset = "0x27012E8", VA = "0x27012E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002CB")]
		private bool useMultithreading
		{
			[Token(Token = "0x600062C")]
			[Address(RVA = "0x2701480", Offset = "0x2701480", VA = "0x2701480")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000005")]
		public event EmptySplineHandler onRebuild
		{
			[Token(Token = "0x600062A")]
			[Address(RVA = "0x2701338", Offset = "0x2701338", VA = "0x2701338")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6CB0", Offset = "0xBB6CB0")]
			add
			{
			}
			[Token(Token = "0x600062B")]
			[Address(RVA = "0x27013DC", Offset = "0x27013DC", VA = "0x27013DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6CC0", Offset = "0xBB6CC0")]
			remove
			{
			}
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x2701488", Offset = "0x2701488", VA = "0x2701488")]
		private void Awake()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x2701690", Offset = "0x2701690", VA = "0x2701690")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x27018A8", Offset = "0x27018A8", VA = "0x27018A8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x27018C0", Offset = "0x27018C0", VA = "0x27018C0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x27016A8", Offset = "0x27016A8", VA = "0x27016A8")]
		private void RunUpdate()
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x2702878", Offset = "0x2702878", VA = "0x2702878")]
		private void TransformSamplesThreaded()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x2702880", Offset = "0x2702880", VA = "0x2702880")]
		private void CalculateAndTransformSamples()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x27018D8", Offset = "0x27018D8", VA = "0x27018D8")]
		private bool TransformHasChanged()
		{
			return default(bool);
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x27028A8", Offset = "0x27028A8", VA = "0x27028A8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x27028C8", Offset = "0x27028C8", VA = "0x27028C8")]
		public void GetSamples(SampleCollection collection)
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x2701508", Offset = "0x2701508", VA = "0x2701508")]
		public void ResampleTransform()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x2702928", Offset = "0x2702928", VA = "0x2702928")]
		public void Subscribe(SplineUser input)
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x2702A24", Offset = "0x2702A24", VA = "0x2702A24")]
		public void Unsubscribe(SplineUser input)
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x2702B20", Offset = "0x2702B20", VA = "0x2702B20")]
		public bool IsSubscribed(SplineUser user)
		{
			return default(bool);
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x2702BF4", Offset = "0x2702BF4", VA = "0x2702BF4")]
		public SplineUser[] GetSubscribers()
		{
			return null;
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x26F369C", Offset = "0x26F369C", VA = "0x26F369C")]
		public SplinePoint[] GetPoints(Space getSpace = Space.World)
		{
			return null;
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x2702C8C", Offset = "0x2702C8C", VA = "0x2702C8C")]
		public SplinePoint GetPoint(int index, Space getSpace = Space.World)
		{
			return default(SplinePoint);
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x2702E48", Offset = "0x2702E48", VA = "0x2702E48")]
		public Vector3 GetPointPosition(int index, Space getSpace = Space.World)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x2702EDC", Offset = "0x2702EDC", VA = "0x2702EDC")]
		public Vector3 GetPointNormal(int index, Space getSpace = Space.World)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x2702F74", Offset = "0x2702F74", VA = "0x2702F74")]
		public Vector3 GetPointTangent(int index, Space getSpace = Space.World)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x2703008", Offset = "0x2703008", VA = "0x2703008")]
		public Vector3 GetPointTangent2(int index, Space getSpace = Space.World)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x270309C", Offset = "0x270309C", VA = "0x270309C")]
		public float GetPointSize(int index, Space getSpace = Space.World)
		{
			return default(float);
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x27030E4", Offset = "0x27030E4", VA = "0x27030E4")]
		public Color GetPointColor(int index, Space getSpace = Space.World)
		{
			return default(Color);
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x2703130", Offset = "0x2703130", VA = "0x2703130")]
		private void Make2D(ref SplinePoint point)
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x2700BE0", Offset = "0x2700BE0", VA = "0x2700BE0")]
		public void SetPoints(SplinePoint[] points, Space setSpace = Space.World)
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x2703484", Offset = "0x2703484", VA = "0x2703484")]
		public void SetPointPosition(int index, Vector3 pos, Space setSpace = Space.World)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x2703790", Offset = "0x2703790", VA = "0x2703790")]
		public void SetPointTangents(int index, Vector3 tan1, Vector3 tan2, Space setSpace = Space.World)
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x2703A38", Offset = "0x2703A38", VA = "0x2703A38")]
		public void SetPointNormal(int index, Vector3 nrm, Space setSpace = Space.World)
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x2703BF8", Offset = "0x2703BF8", VA = "0x2703BF8")]
		public void SetPointSize(int index, float size)
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x2703D10", Offset = "0x2703D10", VA = "0x2703D10")]
		public void SetPointColor(int index, Color color)
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x2703E58", Offset = "0x2703E58", VA = "0x2703E58")]
		public void SetPoint(int index, SplinePoint point, Space setSpace = Space.World)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x27035FC", Offset = "0x27035FC", VA = "0x27035FC")]
		private void AppendPoints(int count)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x270406C", Offset = "0x270406C", VA = "0x270406C")]
		public double GetPointPercent(int pointIndex)
		{
			return default(double);
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x27041A4", Offset = "0x27041A4", VA = "0x27041A4")]
		public int PercentToPointIndex(double percent, Spline.Direction direction = Spline.Direction.Forward)
		{
			return default(int);
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x27042E8", Offset = "0x27042E8", VA = "0x27042E8")]
		public Vector3 EvaluatePosition(double percent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x27042F0", Offset = "0x27042F0", VA = "0x27042F0")]
		public Vector3 EvaluatePosition(double percent, EvaluateMode mode = EvaluateMode.Cached)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x2704340", Offset = "0x2704340", VA = "0x2704340")]
		public Vector3 EvaluatePosition(int pointIndex, EvaluateMode mode = EvaluateMode.Cached)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x270436C", Offset = "0x270436C", VA = "0x270436C")]
		public SplineSample Evaluate(double percent)
		{
			return null;
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x2704374", Offset = "0x2704374", VA = "0x2704374")]
		public SplineSample Evaluate(double percent, EvaluateMode mode = EvaluateMode.Cached)
		{
			return null;
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x2704458", Offset = "0x2704458", VA = "0x2704458")]
		public SplineSample Evaluate(int pointIndex)
		{
			return null;
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x27044D0", Offset = "0x27044D0", VA = "0x27044D0")]
		public void Evaluate(int pointIndex, SplineSample result)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x2704504", Offset = "0x2704504", VA = "0x2704504")]
		public void Evaluate(double percent, SplineSample result)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x27043FC", Offset = "0x27043FC", VA = "0x27043FC")]
		public void Evaluate(double percent, SplineSample result, EvaluateMode mode = EvaluateMode.Cached)
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x27045E8", Offset = "0x27045E8", VA = "0x27045E8")]
		public void Evaluate(ref SplineSample[] results, double from = 0.0, double to = 1.0)
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x2704600", Offset = "0x2704600", VA = "0x2704600")]
		public void EvaluatePositions(ref Vector3[] positions, double from = 0.0, double to = 1.0)
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x2704618", Offset = "0x2704618", VA = "0x2704618")]
		public double Travel(double start, float distance, out float moved, Spline.Direction direction = Spline.Direction.Forward)
		{
			return default(double);
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x270463C", Offset = "0x270463C", VA = "0x270463C")]
		public double Travel(double start, float distance, Spline.Direction direction = Spline.Direction.Forward)
		{
			return default(double);
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x270466C", Offset = "0x270466C", VA = "0x270466C")]
		public void Project(SplineSample result, Vector3 position, double from = 0.0, double to = 1.0, EvaluateMode mode = EvaluateMode.Cached, int subdivisions = 4)
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x2704764", Offset = "0x2704764", VA = "0x2704764")]
		public SplineSample Project(Vector3 point, double from = 0.0, double to = 1.0)
		{
			return null;
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x2704814", Offset = "0x2704814", VA = "0x2704814")]
		public float CalculateLength(double from = 0.0, double to = 1.0)
		{
			return default(float);
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x270451C", Offset = "0x270451C", VA = "0x270451C")]
		private void TransformResult(SplineSample result)
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x2700F08", Offset = "0x2700F08", VA = "0x2700F08")]
		public void Rebuild(bool forceUpdateAll = false)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x27014C8", Offset = "0x27014C8", VA = "0x27014C8")]
		public void RebuildImmediate(bool calculateSamples = true, bool forceUpdateAll = false)
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x2701C48", Offset = "0x2701C48", VA = "0x2701C48")]
		private void RebuildUsers()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x270483C", Offset = "0x270483C", VA = "0x270483C")]
		private void UnsetPointsDirty()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x27027A8", Offset = "0x27027A8", VA = "0x27027A8")]
		private void SetPointsDirty()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x2703188", Offset = "0x2703188", VA = "0x2703188")]
		private void SetDirty(int index)
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x2701DFC", Offset = "0x2701DFC", VA = "0x2701DFC")]
		private void CalculateSamples()
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x27022A0", Offset = "0x27022A0", VA = "0x27022A0")]
		private void TransformSamples(bool forceTransformAll = false)
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x2704C18", Offset = "0x2704C18", VA = "0x2704C18")]
		private void OptimizeSamples()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x2704908", Offset = "0x2704908", VA = "0x2704908")]
		private bool IsDirtyBezier(double samplePercent)
		{
			return default(bool);
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x2704A4C", Offset = "0x2704A4C", VA = "0x2704A4C")]
		private bool IsDirtyHermite(double samplePercent)
		{
			return default(bool);
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x2703168", Offset = "0x2703168", VA = "0x2703168")]
		public void Break()
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x2704FB0", Offset = "0x2704FB0", VA = "0x2704FB0")]
		public void Break(int at)
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x2705038", Offset = "0x2705038", VA = "0x2705038")]
		public void Close()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x27050B0", Offset = "0x27050B0", VA = "0x27050B0")]
		public void CatToBezierTangents()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x27050F0", Offset = "0x27050F0", VA = "0x27050F0")]
		public bool Raycast(out RaycastHit hit, out double hitPercent, LayerMask layerMask, double resolution = 1.0, double from = 0.0, double to = 1.0, QueryTriggerInteraction hitTriggers = QueryTriggerInteraction.UseGlobal)
		{
			return default(bool);
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x2705300", Offset = "0x2705300", VA = "0x2705300")]
		public bool RaycastAll(out RaycastHit[] hits, out double[] hitPercents, LayerMask layerMask, double resolution = 1.0, double from = 0.0, double to = 1.0, QueryTriggerInteraction hitTriggers = QueryTriggerInteraction.UseGlobal)
		{
			return default(bool);
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x27056D0", Offset = "0x27056D0", VA = "0x27056D0")]
		public void CheckTriggers(double start, double end, [Optional] SplineUser user)
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x2705758", Offset = "0x2705758", VA = "0x2705758")]
		public void CheckTriggers(int group, double start, double end)
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x2705890", Offset = "0x2705890", VA = "0x2705890")]
		public void ResetTriggers()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x27058FC", Offset = "0x27058FC", VA = "0x27058FC")]
		public void ResetTriggers(int group)
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x2705A58", Offset = "0x2705A58", VA = "0x2705A58")]
		public List<Node.Connection> GetJunctions(int pointIndex)
		{
			return null;
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x2705B40", Offset = "0x2705B40", VA = "0x2705B40")]
		public Dictionary<int, List<Node.Connection>> GetJunctions(double start = 0.0, double end = 1.0)
		{
			return null;
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x2705D30", Offset = "0x2705D30", VA = "0x2705D30")]
		public void ConnectNode(Node node, int pointIndex)
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x2706358", Offset = "0x2706358", VA = "0x2706358")]
		public void DisconnectNode(int pointIndex)
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x27062AC", Offset = "0x27062AC", VA = "0x27062AC")]
		private void AddNodeLink(Node node, int pointIndex)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x2706438", Offset = "0x2706438", VA = "0x2706438")]
		public Dictionary<int, Node> GetNodes(double start = 0.0, double end = 1.0)
		{
			return null;
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x2706610", Offset = "0x2706610", VA = "0x2706610")]
		public Node GetNode(int pointIndex)
		{
			return null;
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x27066A0", Offset = "0x27066A0", VA = "0x27066A0")]
		public void TransferNode(int pointIndex, int newPointIndex)
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x27068A8", Offset = "0x27068A8", VA = "0x27068A8")]
		public void ShiftNodes(int startIndex, int endIndex, int shift)
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x27069CC", Offset = "0x27069CC", VA = "0x27069CC")]
		public void GetConnectedComputers(List<SplineComputer> computers, List<int> connectionIndices, List<int> connectedIndices, double percent, Spline.Direction direction, bool includeEqual)
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x2706D28", Offset = "0x2706D28", VA = "0x2706D28")]
		public List<SplineComputer> GetConnectedComputers()
		{
			return null;
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x27042D0", Offset = "0x27042D0", VA = "0x27042D0")]
		public void GetSamplingValues(double percent, out int index, out double lerp)
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x2706DEC", Offset = "0x2706DEC", VA = "0x2706DEC")]
		private void GetConnectedComputers(ref List<SplineComputer> computers)
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x27070B8", Offset = "0x27070B8", VA = "0x27070B8")]
		private void RemoveNodeLinkAt(int index)
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x27036C0", Offset = "0x27036C0", VA = "0x27036C0")]
		private void SetNodeForPoint(int index, SplinePoint worldPoint)
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x2703224", Offset = "0x2703224", VA = "0x2703224")]
		private void UpdateConnectedNodes(SplinePoint[] worldPoints)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x27019EC", Offset = "0x27019EC", VA = "0x27019EC")]
		private void UpdateConnectedNodes()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x2702C74", Offset = "0x2702C74", VA = "0x2702C74")]
		public Vector3 TransformPoint(Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x2703170", Offset = "0x2703170", VA = "0x2703170")]
		public Vector3 InverseTransformPoint(Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x2702C80", Offset = "0x2702C80", VA = "0x2702C80")]
		public Vector3 TransformDirection(Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x270317C", Offset = "0x270317C", VA = "0x270317C")]
		public Vector3 InverseTransformDirection(Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x270720C", Offset = "0x270720C", VA = "0x270720C")]
		public SplineComputer()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public delegate void SplineReachHandler();
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB1460", Offset = "0xBB1460")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[HideInInspector]
		public Wrap wrapMode;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[HideInInspector]
		public FollowMode followMode;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[HideInInspector]
		public bool autoStartPosition;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x119")]
		[HideInInspector]
		public bool follow;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		[HideInInspector]
		private float _followSpeed;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		[SerializeField]
		[HideInInspector]
		private float _followDuration;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBB454C", Offset = "0xBB454C")]
		private double _startPosition;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private double lastClippedPercent;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private bool followStarted;

		[Token(Token = "0x170002CC")]
		public float followSpeed
		{
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x28FB9A4", Offset = "0x28FB9A4", VA = "0x28FB9A4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x28FB9AC", Offset = "0x28FB9AC", VA = "0x28FB9AC")]
			set
			{
			}
		}

		[Token(Token = "0x170002CD")]
		public double startPosition
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x28FB9C8", Offset = "0x28FB9C8", VA = "0x28FB9C8")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x28FB9D0", Offset = "0x28FB9D0", VA = "0x28FB9D0")]
			set
			{
			}
		}

		[Token(Token = "0x170002CE")]
		public float followDuration
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x28FBA30", Offset = "0x28FBA30", VA = "0x28FBA30")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x28FBA38", Offset = "0x28FBA38", VA = "0x28FBA38")]
			set
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event SplineReachHandler onEndReached
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x28FBA54", Offset = "0x28FBA54", VA = "0x28FBA54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6CD0", Offset = "0xBB6CD0")]
			add
			{
			}
			[Token(Token = "0x6000696")]
			[Address(RVA = "0x28FBAF8", Offset = "0x28FBAF8", VA = "0x28FBAF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6CE0", Offset = "0xBB6CE0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event SplineReachHandler onBeginningReached
		{
			[Token(Token = "0x6000697")]
			[Address(RVA = "0x28FBB9C", Offset = "0x28FBB9C", VA = "0x28FBB9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6CF0", Offset = "0xBB6CF0")]
			add
			{
			}
			[Token(Token = "0x6000698")]
			[Address(RVA = "0x28FBC40", Offset = "0x28FBC40", VA = "0x28FBC40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6D00", Offset = "0xBB6D00")]
			remove
			{
			}
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x28FBCE4", Offset = "0x28FBCE4", VA = "0x28FBCE4", Slot = "18")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x28FBD84", Offset = "0x28FBD84", VA = "0x28FBD84", Slot = "13")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x28FBEC0", Offset = "0x28FBEC0", VA = "0x28FBEC0", Slot = "15")]
		protected override void PostBuild()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x28FBD98", Offset = "0x28FBD98", VA = "0x28FBD98")]
		private void Follow()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x28FC898", Offset = "0x28FC898", VA = "0x28FC898")]
		public void Restart(double startPosition = 0.0)
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x28FC8B4", Offset = "0x28FC8B4", VA = "0x28FC8B4", Slot = "19")]
		public override void SetPercent(double percent, bool checkTriggers = false, bool handleJuncitons = false)
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x28FC98C", Offset = "0x28FC98C", VA = "0x28FC98C", Slot = "20")]
		public override void SetDistance(float distance, bool checkTriggers = false, bool handleJuncitons = false)
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x28FC5BC", Offset = "0x28FC5BC", VA = "0x28FC5BC")]
		public void Move(double percent)
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x28FC2F4", Offset = "0x28FC2F4", VA = "0x28FC2F4")]
		public void Move(float distance)
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x28FD44C", Offset = "0x28FD44C", VA = "0x28FD44C")]
		public SplineFollower()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBB1498", Offset = "0xBB1498")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBB1498", Offset = "0xBB1498")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB1498", Offset = "0xBB1498")]
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
					[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
					public int[] triangles;

					[Token(Token = "0x6000A54")]
					[Address(RVA = "0x26B2AB8", Offset = "0x26B2AB8", VA = "0x26B2AB8")]
					public Submesh()
					{
					}

					[Token(Token = "0x6000A55")]
					[Address(RVA = "0x26AFE84", Offset = "0x26AFE84", VA = "0x26AFE84")]
					public Submesh(int[] input)
					{
					}
				}

				[Serializable]
				[Token(Token = "0x200011C")]
				public class VertexGroup
				{
					[Token(Token = "0x4000750")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
					public float value;

					[Token(Token = "0x4000751")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
					public double percent;

					[Token(Token = "0x4000752")]
					[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
					public int[] ids;

					[Token(Token = "0x6000A56")]
					[Address(RVA = "0x26B23C0", Offset = "0x26B23C0", VA = "0x26B23C0")]
					public VertexGroup(float val, double perc, int[] vertIds)
					{
					}

					[Token(Token = "0x6000A57")]
					[Address(RVA = "0x26B240C", Offset = "0x26B240C", VA = "0x26B240C")]
					public void AddId(int id)
					{
					}
				}

				[Token(Token = "0x4000728")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[SerializeField]
				[HideInInspector]
				internal Vector3[] vertices;

				[Token(Token = "0x4000729")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[SerializeField]
				[HideInInspector]
				internal Vector3[] normals;

				[Token(Token = "0x400072A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				[SerializeField]
				[HideInInspector]
				internal Vector4[] tangents;

				[Token(Token = "0x400072B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				[SerializeField]
				[HideInInspector]
				internal Color[] colors;

				[Token(Token = "0x400072C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				[SerializeField]
				[HideInInspector]
				internal Vector2[] uv;

				[Token(Token = "0x400072D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				[SerializeField]
				[HideInInspector]
				internal Vector2[] uv2;

				[Token(Token = "0x400072E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				[SerializeField]
				[HideInInspector]
				internal Vector2[] uv3;

				[Token(Token = "0x400072F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				[SerializeField]
				[HideInInspector]
				internal Vector2[] uv4;

				[Token(Token = "0x4000730")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				[SerializeField]
				[HideInInspector]
				internal int[] triangles;

				[Token(Token = "0x4000731")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				[SerializeField]
				[HideInInspector]
				internal List<Submesh> subMeshes;

				[Token(Token = "0x4000732")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				[SerializeField]
				[HideInInspector]
				internal TS_Bounds bounds;

				[Token(Token = "0x4000733")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				[SerializeField]
				[HideInInspector]
				internal List<VertexGroup> vertexGroups;

				[Token(Token = "0x4000734")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				[SerializeField]
				[HideInInspector]
				private Mesh _mesh;

				[Token(Token = "0x4000735")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				[SerializeField]
				[HideInInspector]
				private Vector3 _rotation;

				[Token(Token = "0x4000736")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
				[SerializeField]
				[HideInInspector]
				private Vector3 _offset;

				[Token(Token = "0x4000737")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
				[SerializeField]
				[HideInInspector]
				private Vector3 _scale;

				[Token(Token = "0x4000738")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
				[SerializeField]
				[HideInInspector]
				private Vector2 _uvScale;

				[Token(Token = "0x4000739")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
				[SerializeField]
				[HideInInspector]
				private Vector2 _uvOffset;

				[Token(Token = "0x400073A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
				[SerializeField]
				[HideInInspector]
				private float _uvRotation;

				[Token(Token = "0x400073B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
				[SerializeField]
				[HideInInspector]
				private MirrorMethod _mirror;

				[Token(Token = "0x400073C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
				[SerializeField]
				[HideInInspector]
				private float _vertexGroupingMargin;

				[Token(Token = "0x400073D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
				[SerializeField]
				[HideInInspector]
				private bool _removeInnerFaces;

				[Token(Token = "0x400073E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
				[SerializeField]
				[HideInInspector]
				private bool _flipFaces;

				[Token(Token = "0x400073F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xBA")]
				[SerializeField]
				[HideInInspector]
				private bool _doubleSided;

				[Token(Token = "0x17000373")]
				public Mesh mesh
				{
					[Token(Token = "0x6000A2A")]
					[Address(RVA = "0x26AFAE0", Offset = "0x26AFAE0", VA = "0x26AFAE0")]
					get
					{
						return null;
					}
					[Token(Token = "0x6000A2B")]
					[Address(RVA = "0x26AFAE8", Offset = "0x26AFAE8", VA = "0x26AFAE8")]
					set
					{
					}
				}

				[Token(Token = "0x17000374")]
				public Vector3 rotation
				{
					[Token(Token = "0x6000A2C")]
					[Address(RVA = "0x26AFB90", Offset = "0x26AFB90", VA = "0x26AFB90")]
					get
					{
						return default(Vector3);
					}
					[Token(Token = "0x6000A2D")]
					[Address(RVA = "0x26AFB9C", Offset = "0x26AFB9C", VA = "0x26AFB9C")]
					set
					{
					}
				}

				[Token(Token = "0x17000375")]
				public Vector3 offset
				{
					[Token(Token = "0x6000A2E")]
					[Address(RVA = "0x26AFC18", Offset = "0x26AFC18", VA = "0x26AFC18")]
					get
					{
						return default(Vector3);
					}
					[Token(Token = "0x6000A2F")]
					[Address(RVA = "0x26AFC24", Offset = "0x26AFC24", VA = "0x26AFC24")]
					set
					{
					}
				}

				[Token(Token = "0x17000376")]
				public Vector3 scale
				{
					[Token(Token = "0x6000A30")]
					[Address(RVA = "0x26AFCA0", Offset = "0x26AFCA0", VA = "0x26AFCA0")]
					get
					{
						return default(Vector3);
					}
					[Token(Token = "0x6000A31")]
					[Address(RVA = "0x26AFCAC", Offset = "0x26AFCAC", VA = "0x26AFCAC")]
					set
					{
					}
				}

				[Token(Token = "0x17000377")]
				public Vector2 uvScale
				{
					[Token(Token = "0x6000A32")]
					[Address(RVA = "0x26AFD28", Offset = "0x26AFD28", VA = "0x26AFD28")]
					get
					{
						return default(Vector2);
					}
					[Token(Token = "0x6000A33")]
					[Address(RVA = "0x26AFD30", Offset = "0x26AFD30", VA = "0x26AFD30")]
					set
					{
					}
				}

				[Token(Token = "0x17000378")]
				public Vector2 uvOffset
				{
					[Token(Token = "0x6000A34")]
					[Address(RVA = "0x26AFD64", Offset = "0x26AFD64", VA = "0x26AFD64")]
					get
					{
						return default(Vector2);
					}
					[Token(Token = "0x6000A35")]
					[Address(RVA = "0x26AFD6C", Offset = "0x26AFD6C", VA = "0x26AFD6C")]
					set
					{
					}
				}

				[Token(Token = "0x17000379")]
				public float uvRotation
				{
					[Token(Token = "0x6000A36")]
					[Address(RVA = "0x26AFDA0", Offset = "0x26AFDA0", VA = "0x26AFDA0")]
					get
					{
						return default(float);
					}
					[Token(Token = "0x6000A37")]
					[Address(RVA = "0x26AFDA8", Offset = "0x26AFDA8", VA = "0x26AFDA8")]
					set
					{
					}
				}

				[Token(Token = "0x1700037A")]
				public float vertexGroupingMargin
				{
					[Token(Token = "0x6000A38")]
					[Address(RVA = "0x26AFDC0", Offset = "0x26AFDC0", VA = "0x26AFDC0")]
					get
					{
						return default(float);
					}
					[Token(Token = "0x6000A39")]
					[Address(RVA = "0x26AFDC8", Offset = "0x26AFDC8", VA = "0x26AFDC8")]
					set
					{
					}
				}

				[Token(Token = "0x1700037B")]
				public MirrorMethod mirror
				{
					[Token(Token = "0x6000A3A")]
					[Address(RVA = "0x26AFDE0", Offset = "0x26AFDE0", VA = "0x26AFDE0")]
					get
					{
						return default(MirrorMethod);
					}
					[Token(Token = "0x6000A3B")]
					[Address(RVA = "0x26AFDE8", Offset = "0x26AFDE8", VA = "0x26AFDE8")]
					set
					{
					}
				}

				[Token(Token = "0x1700037C")]
				public bool removeInnerFaces
				{
					[Token(Token = "0x6000A3C")]
					[Address(RVA = "0x26AFE00", Offset = "0x26AFE00", VA = "0x26AFE00")]
					get
					{
						return default(bool);
					}
					[Token(Token = "0x6000A3D")]
					[Address(RVA = "0x26AFE08", Offset = "0x26AFE08", VA = "0x26AFE08")]
					set
					{
					}
				}

				[Token(Token = "0x1700037D")]
				public bool flipFaces
				{
					[Token(Token = "0x6000A3E")]
					[Address(RVA = "0x26AFE2C", Offset = "0x26AFE2C", VA = "0x26AFE2C")]
					get
					{
						return default(bool);
					}
					[Token(Token = "0x6000A3F")]
					[Address(RVA = "0x26AFE34", Offset = "0x26AFE34", VA = "0x26AFE34")]
					set
					{
					}
				}

				[Token(Token = "0x1700037E")]
				public bool doubleSided
				{
					[Token(Token = "0x6000A40")]
					[Address(RVA = "0x26AFE58", Offset = "0x26AFE58", VA = "0x26AFE58")]
					get
					{
						return default(bool);
					}
					[Token(Token = "0x6000A41")]
					[Address(RVA = "0x26AFE60", Offset = "0x26AFE60", VA = "0x26AFE60")]
					set
					{
					}
				}

				[Token(Token = "0x6000A42")]
				[Address(RVA = "0x26A9AE8", Offset = "0x26A9AE8", VA = "0x26A9AE8")]
				internal MeshDefinition Copy()
				{
					return null;
				}

				[Token(Token = "0x6000A43")]
				[Address(RVA = "0x26A9590", Offset = "0x26A9590", VA = "0x26A9590")]
				public MeshDefinition(Mesh input)
				{
				}

				[Token(Token = "0x6000A44")]
				[Address(RVA = "0x26AB4D8", Offset = "0x26AB4D8", VA = "0x26AB4D8")]
				public void Refresh()
				{
				}

				[Token(Token = "0x6000A45")]
				[Address(RVA = "0x26B0C18", Offset = "0x26B0C18", VA = "0x26B0C18")]
				private void RemoveInnerFaces()
				{
				}

				[Token(Token = "0x6000A46")]
				[Address(RVA = "0x26B0648", Offset = "0x26B0648", VA = "0x26B0648")]
				private void FlipFaces()
				{
				}

				[Token(Token = "0x6000A47")]
				[Address(RVA = "0x26B0320", Offset = "0x26B0320", VA = "0x26B0320")]
				private void DoubleSided()
				{
				}

				[Token(Token = "0x6000A48")]
				[Address(RVA = "0x26B1434", Offset = "0x26B1434", VA = "0x26B1434")]
				public void Write(TS_Mesh target, int forceMaterialId = -1)
				{
				}

				[Token(Token = "0x6000A49")]
				[Address(RVA = "0x26B0B00", Offset = "0x26B0B00", VA = "0x26B0B00")]
				private void CalculateBounds()
				{
				}

				[Token(Token = "0x6000A4A")]
				[Address(RVA = "0x26AFF34", Offset = "0x26AFF34", VA = "0x26AFF34")]
				private void Mirror()
				{
				}

				[Token(Token = "0x6000A4B")]
				[Address(RVA = "0x26B07A8", Offset = "0x26B07A8", VA = "0x26B07A8")]
				private void TransformVertices()
				{
				}

				[Token(Token = "0x6000A4C")]
				[Address(RVA = "0x26B1038", Offset = "0x26B1038", VA = "0x26B1038")]
				private void GroupVertices()
				{
				}

				[Token(Token = "0x6000A4D")]
				[Address(RVA = "0x26B229C", Offset = "0x26B229C", VA = "0x26B229C")]
				private int FindInsertIndex(Vector3 pos, float value)
				{
					return default(int);
				}

				[Token(Token = "0x6000A4E")]
				[Address(RVA = "0x26B1C5C", Offset = "0x26B1C5C", VA = "0x26B1C5C")]
				private void CalculateTangents()
				{
				}
			}

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private System.Random iterationRandom;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[HideInInspector]
			private int _iterationSeed;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[SerializeField]
			[HideInInspector]
			private int _offsetSeed;

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private System.Random offsetRandom;

			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector2Handler _offsetHandler;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[SerializeField]
			[HideInInspector]
			private int _rotationSeed;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private System.Random rotationRandom;

			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private QuaternionHandler _placeRotationHandler;

			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private FloatHandler _extrudeRotationHandler;

			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[SerializeField]
			[HideInInspector]
			private int _scaleSeed;

			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private System.Random scaleRandom;

			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector3Handler _scaleHandler;

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[SerializeField]
			internal SplineMesh owner;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[SerializeField]
			[HideInInspector]
			private List<MeshDefinition> meshes;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[SerializeField]
			[HideInInspector]
			private double _clipFrom;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[SerializeField]
			[HideInInspector]
			private double _clipTo;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[SerializeField]
			[HideInInspector]
			private bool _randomOrder;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[SerializeField]
			[HideInInspector]
			private UVOverride _overrideUVs;

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[SerializeField]
			[HideInInspector]
			private Vector2 _uvScale;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[SerializeField]
			[HideInInspector]
			private Vector2 _uvOffset;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[SerializeField]
			[HideInInspector]
			private bool _overrideNormal;

			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[SerializeField]
			[HideInInspector]
			private Vector3 _customNormal;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[SerializeField]
			[HideInInspector]
			private Type _type;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[SerializeField]
			[HideInInspector]
			private int _count;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[SerializeField]
			[HideInInspector]
			private bool _autoCount;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[SerializeField]
			[HideInInspector]
			private double _spacing;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[SerializeField]
			[HideInInspector]
			private bool _randomRotation;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			[SerializeField]
			[HideInInspector]
			private Vector3 _minRotation;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[SerializeField]
			[HideInInspector]
			private Vector3 _maxRotation;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[SerializeField]
			[HideInInspector]
			private bool _randomOffset;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[SerializeField]
			[HideInInspector]
			private Vector2 _minOffset;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[SerializeField]
			[HideInInspector]
			private Vector2 _maxOffset;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			[SerializeField]
			[HideInInspector]
			private bool _randomScale;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x101")]
			[SerializeField]
			[HideInInspector]
			private bool _uniformRandomScale;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			[SerializeField]
			[HideInInspector]
			private Vector3 _minScale;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			[SerializeField]
			[HideInInspector]
			private Vector3 _maxScale;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
			private int iterator;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			[SerializeField]
			[HideInInspector]
			private bool _overrideMaterialID;

			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			[SerializeField]
			[HideInInspector]
			private int _targetMaterialID;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[SerializeField]
			[HideInInspector]
			protected MeshScaleModifier _scaleModifier;

			[Token(Token = "0x17000342")]
			public double clipFrom
			{
				[Token(Token = "0x6000941")]
				[Address(RVA = "0x26A88C8", Offset = "0x26A88C8", VA = "0x26A88C8")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x6000942")]
				[Address(RVA = "0x26A88D0", Offset = "0x26A88D0", VA = "0x26A88D0")]
				set
				{
				}
			}

			[Token(Token = "0x17000343")]
			public double clipTo
			{
				[Token(Token = "0x6000943")]
				[Address(RVA = "0x26A897C", Offset = "0x26A897C", VA = "0x26A897C")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x6000944")]
				[Address(RVA = "0x26A8984", Offset = "0x26A8984", VA = "0x26A8984")]
				set
				{
				}
			}

			[Token(Token = "0x17000344")]
			public bool randomOffset
			{
				[Token(Token = "0x6000945")]
				[Address(RVA = "0x26A899C", Offset = "0x26A899C", VA = "0x26A899C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000946")]
				[Address(RVA = "0x26A89A4", Offset = "0x26A89A4", VA = "0x26A89A4")]
				set
				{
				}
			}

			[Token(Token = "0x17000345")]
			public Vector2Handler offsetHandler
			{
				[Token(Token = "0x6000947")]
				[Address(RVA = "0x26A89C8", Offset = "0x26A89C8", VA = "0x26A89C8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000948")]
				[Address(RVA = "0x26A89D0", Offset = "0x26A89D0", VA = "0x26A89D0")]
				set
				{
				}
			}

			[Token(Token = "0x17000346")]
			public bool overrideMaterialID
			{
				[Token(Token = "0x6000949")]
				[Address(RVA = "0x26A8A38", Offset = "0x26A8A38", VA = "0x26A8A38")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600094A")]
				[Address(RVA = "0x26A8A40", Offset = "0x26A8A40", VA = "0x26A8A40")]
				set
				{
				}
			}

			[Token(Token = "0x17000347")]
			public int targetMaterialID
			{
				[Token(Token = "0x600094B")]
				[Address(RVA = "0x26A8A64", Offset = "0x26A8A64", VA = "0x26A8A64")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600094C")]
				[Address(RVA = "0x26A8A6C", Offset = "0x26A8A6C", VA = "0x26A8A6C")]
				set
				{
				}
			}

			[Token(Token = "0x17000348")]
			public bool randomRotation
			{
				[Token(Token = "0x600094D")]
				[Address(RVA = "0x26A8A84", Offset = "0x26A8A84", VA = "0x26A8A84")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600094E")]
				[Address(RVA = "0x26A8A8C", Offset = "0x26A8A8C", VA = "0x26A8A8C")]
				set
				{
				}
			}

			[Token(Token = "0x17000349")]
			public QuaternionHandler placeRotationHandler
			{
				[Token(Token = "0x600094F")]
				[Address(RVA = "0x26A8AB0", Offset = "0x26A8AB0", VA = "0x26A8AB0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000950")]
				[Address(RVA = "0x26A8AB8", Offset = "0x26A8AB8", VA = "0x26A8AB8")]
				set
				{
				}
			}

			[Token(Token = "0x1700034A")]
			public FloatHandler extrudeRotationHandler
			{
				[Token(Token = "0x6000951")]
				[Address(RVA = "0x26A8B20", Offset = "0x26A8B20", VA = "0x26A8B20")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000952")]
				[Address(RVA = "0x26A8B28", Offset = "0x26A8B28", VA = "0x26A8B28")]
				set
				{
				}
			}

			[Token(Token = "0x1700034B")]
			public bool randomScale
			{
				[Token(Token = "0x6000953")]
				[Address(RVA = "0x26A8B90", Offset = "0x26A8B90", VA = "0x26A8B90")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000954")]
				[Address(RVA = "0x26A8B98", Offset = "0x26A8B98", VA = "0x26A8B98")]
				set
				{
				}
			}

			[Token(Token = "0x1700034C")]
			public Vector3Handler scaleHandler
			{
				[Token(Token = "0x6000955")]
				[Address(RVA = "0x26A8BBC", Offset = "0x26A8BBC", VA = "0x26A8BBC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000956")]
				[Address(RVA = "0x26A8BC4", Offset = "0x26A8BC4", VA = "0x26A8BC4")]
				set
				{
				}
			}

			[Token(Token = "0x1700034D")]
			public bool uniformRandomScale
			{
				[Token(Token = "0x6000957")]
				[Address(RVA = "0x26A8C2C", Offset = "0x26A8C2C", VA = "0x26A8C2C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000958")]
				[Address(RVA = "0x26A8C34", Offset = "0x26A8C34", VA = "0x26A8C34")]
				set
				{
				}
			}

			[Token(Token = "0x1700034E")]
			public int offsetSeed
			{
				[Token(Token = "0x6000959")]
				[Address(RVA = "0x26A8C58", Offset = "0x26A8C58", VA = "0x26A8C58")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600095A")]
				[Address(RVA = "0x26A8C60", Offset = "0x26A8C60", VA = "0x26A8C60")]
				set
				{
				}
			}

			[Token(Token = "0x1700034F")]
			public int rotationSeed
			{
				[Token(Token = "0x600095B")]
				[Address(RVA = "0x26A8C78", Offset = "0x26A8C78", VA = "0x26A8C78")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600095C")]
				[Address(RVA = "0x26A8C80", Offset = "0x26A8C80", VA = "0x26A8C80")]
				set
				{
				}
			}

			[Token(Token = "0x17000350")]
			public int scaleSeed
			{
				[Token(Token = "0x600095D")]
				[Address(RVA = "0x26A8C98", Offset = "0x26A8C98", VA = "0x26A8C98")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600095E")]
				[Address(RVA = "0x26A8CA0", Offset = "0x26A8CA0", VA = "0x26A8CA0")]
				set
				{
				}
			}

			[Token(Token = "0x17000351")]
			public double spacing
			{
				[Token(Token = "0x600095F")]
				[Address(RVA = "0x26A8CB8", Offset = "0x26A8CB8", VA = "0x26A8CB8")]
				get
				{
					return default(double);
				}
				[Token(Token = "0x6000960")]
				[Address(RVA = "0x26A8CC0", Offset = "0x26A8CC0", VA = "0x26A8CC0")]
				set
				{
				}
			}

			[Token(Token = "0x17000352")]
			public Vector2 minOffset
			{
				[Token(Token = "0x6000961")]
				[Address(RVA = "0x26A8CD8", Offset = "0x26A8CD8", VA = "0x26A8CD8")]
				get
				{
					return default(Vector2);
				}
				[Token(Token = "0x6000962")]
				[Address(RVA = "0x26A8CE0", Offset = "0x26A8CE0", VA = "0x26A8CE0")]
				set
				{
				}
			}

			[Token(Token = "0x17000353")]
			public Vector2 maxOffset
			{
				[Token(Token = "0x6000963")]
				[Address(RVA = "0x26A8D14", Offset = "0x26A8D14", VA = "0x26A8D14")]
				get
				{
					return default(Vector2);
				}
				[Token(Token = "0x6000964")]
				[Address(RVA = "0x26A8D1C", Offset = "0x26A8D1C", VA = "0x26A8D1C")]
				set
				{
				}
			}

			[Token(Token = "0x17000354")]
			public Vector3 minRotation
			{
				[Token(Token = "0x6000965")]
				[Address(RVA = "0x26A8D50", Offset = "0x26A8D50", VA = "0x26A8D50")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000966")]
				[Address(RVA = "0x26A8D5C", Offset = "0x26A8D5C", VA = "0x26A8D5C")]
				set
				{
				}
			}

			[Token(Token = "0x17000355")]
			public Vector3 maxRotation
			{
				[Token(Token = "0x6000967")]
				[Address(RVA = "0x26A8DC8", Offset = "0x26A8DC8", VA = "0x26A8DC8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000968")]
				[Address(RVA = "0x26A8DD4", Offset = "0x26A8DD4", VA = "0x26A8DD4")]
				set
				{
				}
			}

			[Token(Token = "0x17000356")]
			public Vector3 minScale
			{
				[Token(Token = "0x6000969")]
				[Address(RVA = "0x26A8E40", Offset = "0x26A8E40", VA = "0x26A8E40")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600096A")]
				[Address(RVA = "0x26A8E50", Offset = "0x26A8E50", VA = "0x26A8E50")]
				set
				{
				}
			}

			[Token(Token = "0x17000357")]
			public Vector3 maxScale
			{
				[Token(Token = "0x600096B")]
				[Address(RVA = "0x26A8EC4", Offset = "0x26A8EC4", VA = "0x26A8EC4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600096C")]
				[Address(RVA = "0x26A8ED4", Offset = "0x26A8ED4", VA = "0x26A8ED4")]
				set
				{
				}
			}

			[Token(Token = "0x17000358")]
			public Type type
			{
				[Token(Token = "0x600096D")]
				[Address(RVA = "0x26A8F48", Offset = "0x26A8F48", VA = "0x26A8F48")]
				get
				{
					return default(Type);
				}
				[Token(Token = "0x600096E")]
				[Address(RVA = "0x26A8F50", Offset = "0x26A8F50", VA = "0x26A8F50")]
				set
				{
				}
			}

			[Token(Token = "0x17000359")]
			public bool randomOrder
			{
				[Token(Token = "0x600096F")]
				[Address(RVA = "0x26A8F68", Offset = "0x26A8F68", VA = "0x26A8F68")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000970")]
				[Address(RVA = "0x26A8F70", Offset = "0x26A8F70", VA = "0x26A8F70")]
				set
				{
				}
			}

			[Token(Token = "0x1700035A")]
			public int randomSeed
			{
				[Token(Token = "0x6000971")]
				[Address(RVA = "0x26A8F94", Offset = "0x26A8F94", VA = "0x26A8F94")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000972")]
				[Address(RVA = "0x26A8F9C", Offset = "0x26A8F9C", VA = "0x26A8F9C")]
				set
				{
				}
			}

			[Token(Token = "0x1700035B")]
			public int count
			{
				[Token(Token = "0x6000973")]
				[Address(RVA = "0x26A8FBC", Offset = "0x26A8FBC", VA = "0x26A8FBC")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000974")]
				[Address(RVA = "0x26A8FC4", Offset = "0x26A8FC4", VA = "0x26A8FC4")]
				set
				{
				}
			}

			[Token(Token = "0x1700035C")]
			public bool autoCount
			{
				[Token(Token = "0x6000975")]
				[Address(RVA = "0x26A8FE4", Offset = "0x26A8FE4", VA = "0x26A8FE4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000976")]
				[Address(RVA = "0x26A8FEC", Offset = "0x26A8FEC", VA = "0x26A8FEC")]
				set
				{
				}
			}

			[Token(Token = "0x1700035D")]
			public UVOverride overrideUVs
			{
				[Token(Token = "0x6000977")]
				[Address(RVA = "0x26A9010", Offset = "0x26A9010", VA = "0x26A9010")]
				get
				{
					return default(UVOverride);
				}
				[Token(Token = "0x6000978")]
				[Address(RVA = "0x26A9018", Offset = "0x26A9018", VA = "0x26A9018")]
				set
				{
				}
			}

			[Token(Token = "0x1700035E")]
			public Vector2 uvOffset
			{
				[Token(Token = "0x6000979")]
				[Address(RVA = "0x26A9030", Offset = "0x26A9030", VA = "0x26A9030")]
				get
				{
					return default(Vector2);
				}
				[Token(Token = "0x600097A")]
				[Address(RVA = "0x26A9038", Offset = "0x26A9038", VA = "0x26A9038")]
				set
				{
				}
			}

			[Token(Token = "0x1700035F")]
			public Vector2 uvScale
			{
				[Token(Token = "0x600097B")]
				[Address(RVA = "0x26A906C", Offset = "0x26A906C", VA = "0x26A906C")]
				get
				{
					return default(Vector2);
				}
				[Token(Token = "0x600097C")]
				[Address(RVA = "0x26A9074", Offset = "0x26A9074", VA = "0x26A9074")]
				set
				{
				}
			}

			[Token(Token = "0x17000360")]
			public bool overrideNormal
			{
				[Token(Token = "0x600097D")]
				[Address(RVA = "0x26A90A8", Offset = "0x26A90A8", VA = "0x26A90A8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600097E")]
				[Address(RVA = "0x26A90B0", Offset = "0x26A90B0", VA = "0x26A90B0")]
				set
				{
				}
			}

			[Token(Token = "0x17000361")]
			public Vector3 customNormal
			{
				[Token(Token = "0x600097F")]
				[Address(RVA = "0x26A90D4", Offset = "0x26A90D4", VA = "0x26A90D4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000980")]
				[Address(RVA = "0x26A90E0", Offset = "0x26A90E0", VA = "0x26A90E0")]
				set
				{
				}
			}

			[Token(Token = "0x17000362")]
			public MeshScaleModifier scaleModifier
			{
				[Token(Token = "0x6000981")]
				[Address(RVA = "0x26A914C", Offset = "0x26A914C", VA = "0x26A914C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000982")]
			[Address(RVA = "0x26A9154", Offset = "0x26A9154", VA = "0x26A9154")]
			public Channel(string n, SplineMesh parent)
			{
			}

			[Token(Token = "0x6000983")]
			[Address(RVA = "0x26A9370", Offset = "0x26A9370", VA = "0x26A9370")]
			public Channel(string n, Mesh inputMesh, SplineMesh parent)
			{
			}

			[Token(Token = "0x6000984")]
			[Address(RVA = "0x26A9310", Offset = "0x26A9310", VA = "0x26A9310")]
			private void Init()
			{
			}

			[Token(Token = "0x6000985")]
			[Address(RVA = "0x26A98BC", Offset = "0x26A98BC", VA = "0x26A98BC")]
			public void CopyTo(Channel target)
			{
			}

			[Token(Token = "0x6000986")]
			[Address(RVA = "0x26AA098", Offset = "0x26AA098", VA = "0x26AA098")]
			public int GetMeshCount()
			{
				return default(int);
			}

			[Token(Token = "0x6000987")]
			[Address(RVA = "0x26AA0E4", Offset = "0x26AA0E4", VA = "0x26AA0E4")]
			public void SwapMeshes(int a, int b)
			{
			}

			[Token(Token = "0x6000988")]
			[Address(RVA = "0x26AA218", Offset = "0x26AA218", VA = "0x26AA218")]
			public void DuplicateMesh(int index)
			{
			}

			[Token(Token = "0x6000989")]
			[Address(RVA = "0x26AA2E0", Offset = "0x26AA2E0", VA = "0x26AA2E0")]
			public MeshDefinition GetMesh(int index)
			{
				return null;
			}

			[Token(Token = "0x600098A")]
			[Address(RVA = "0x26AA354", Offset = "0x26AA354", VA = "0x26AA354")]
			public void AddMesh(Mesh input)
			{
			}

			[Token(Token = "0x600098B")]
			[Address(RVA = "0x26AA3EC", Offset = "0x26AA3EC", VA = "0x26AA3EC")]
			public void RemoveMesh(int index)
			{
			}

			[Token(Token = "0x600098C")]
			[Address(RVA = "0x26AA458", Offset = "0x26AA458", VA = "0x26AA458")]
			public void ResetIteration()
			{
			}

			[Token(Token = "0x600098D")]
			[Address(RVA = "0x26AA590", Offset = "0x26AA590", VA = "0x26AA590")]
			public Vector2 NextOffset(double percent)
			{
				return default(Vector2);
			}

			[Token(Token = "0x600098E")]
			[Address(RVA = "0x26AA890", Offset = "0x26AA890", VA = "0x26AA890")]
			public Quaternion NextPlaceRotation(double percent)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600098F")]
			[Address(RVA = "0x26AABE0", Offset = "0x26AABE0", VA = "0x26AABE0")]
			public float NextExtrudeRotation(double percent)
			{
				return default(float);
			}

			[Token(Token = "0x6000990")]
			[Address(RVA = "0x26AAE98", Offset = "0x26AAE98", VA = "0x26AAE98")]
			public Vector3 NextExtrudeScale(double percent)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000991")]
			[Address(RVA = "0x26AB204", Offset = "0x26AB204", VA = "0x26AB204")]
			public Vector3 NextPlaceScale()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000992")]
			[Address(RVA = "0x26AB360", Offset = "0x26AB360", VA = "0x26AB360")]
			public MeshDefinition NextMesh()
			{
				return null;
			}

			[Token(Token = "0x6000993")]
			[Address(RVA = "0x26A88E8", Offset = "0x26A88E8", VA = "0x26A88E8")]
			internal void Rebuild()
			{
			}

			[Token(Token = "0x6000994")]
			[Address(RVA = "0x26AB438", Offset = "0x26AB438", VA = "0x26AB438")]
			private void Refresh()
			{
			}
		}

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		[HideInInspector]
		private List<Channel> channels;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private bool useLastResult;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private List<TS_Mesh> combineMeshes;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private int meshCount;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Matrix4x4 vertexMatrix;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private Matrix4x4 normalMatrix;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private SplineSample lastResult;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private SplineSample modifiedResult;

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x28FD580", Offset = "0x28FD580", VA = "0x28FD580", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x28FD5E4", Offset = "0x28FD5E4", VA = "0x28FD5E4", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x28FD6D8", Offset = "0x28FD6D8", VA = "0x28FD6D8")]
		public void RemoveChannel(int index)
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x28FD74C", Offset = "0x28FD74C", VA = "0x28FD74C")]
		public void SwapChannels(int a, int b)
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x28FD888", Offset = "0x28FD888", VA = "0x28FD888")]
		public Channel AddChannel(Mesh inputMesh, string name)
		{
			return null;
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x28FD63C", Offset = "0x28FD63C", VA = "0x28FD63C")]
		public Channel AddChannel(string name)
		{
			return null;
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x28FD92C", Offset = "0x28FD92C", VA = "0x28FD92C")]
		public int GetChannelCount()
		{
			return default(int);
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x28FD978", Offset = "0x28FD978", VA = "0x28FD978")]
		public Channel GetChannel(int index)
		{
			return null;
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x28FD9EC", Offset = "0x28FD9EC", VA = "0x28FD9EC", Slot = "18")]
		protected override void BuildMesh()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x28FDA20", Offset = "0x28FDA20", VA = "0x28FDA20")]
		private void Generate()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x28FF0F4", Offset = "0x28FF0F4", VA = "0x28FF0F4")]
		private void Place(Channel channel, TS_Mesh target, double percent)
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x28FE91C", Offset = "0x28FE91C", VA = "0x28FE91C")]
		private void Stretch(Channel channel, TS_Mesh target, double from, double to)
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x2900F08", Offset = "0x2900F08", VA = "0x2900F08")]
		public SplineMesh()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB1550", Offset = "0xBB1550")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			internal SplinePoint[] points;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			internal float percent;

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string name;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AnimationCurve curve;

			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Interpolation interpolation;

			[Token(Token = "0x6000995")]
			[Address(RVA = "0x26ABF00", Offset = "0x26ABF00", VA = "0x26ABF00")]
			public Channel()
			{
			}
		}

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public SplineComputer.Space space;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[HideInInspector]
		public bool cycle;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public CycleMode cycleMode;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public UpdateMode cycleUpdateMode;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public float cycleDuration;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private SplineComputer _spline;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SplinePoint[] points;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float cycleValue;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private short cycleDirection;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBB465C", Offset = "0xBB465C")]
		private Channel[] channels;

		[Token(Token = "0x170002CF")]
		public SplineComputer spline
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x29010CC", Offset = "0x29010CC", VA = "0x29010CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x29010D4", Offset = "0x29010D4", VA = "0x29010D4")]
			set
			{
			}
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x2901178", Offset = "0x2901178", VA = "0x2901178")]
		private void Reset()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x29011D0", Offset = "0x29011D0", VA = "0x29011D0")]
		private void Update()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x29012E8", Offset = "0x29012E8", VA = "0x29012E8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x29012FC", Offset = "0x29012FC", VA = "0x29012FC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x29011E0", Offset = "0x29011E0", VA = "0x29011E0")]
		private void RunUpdate()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x29013FC", Offset = "0x29013FC", VA = "0x29013FC")]
		public void SetCycle(float value)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x2901424", Offset = "0x2901424", VA = "0x2901424")]
		public void SetWeight(int index, float weight)
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x2901F18", Offset = "0x2901F18", VA = "0x2901F18")]
		public void SetWeight(string name, float weight)
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x2901310", Offset = "0x2901310", VA = "0x2901310")]
		public void SetWeight(float percent, bool loop = false)
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x290208C", Offset = "0x290208C", VA = "0x290208C")]
		public void CaptureSnapshot(string name)
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x29020B4", Offset = "0x29020B4", VA = "0x29020B4")]
		public void CaptureSnapshot(int index)
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x2902264", Offset = "0x2902264", VA = "0x2902264")]
		public void Clear()
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x29022C0", Offset = "0x29022C0", VA = "0x29022C0")]
		public SplinePoint[] GetSnapshot(int index)
		{
			return null;
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x2902304", Offset = "0x2902304", VA = "0x2902304")]
		public SplinePoint[] GetSnapshot(string name)
		{
			return null;
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x2902358", Offset = "0x2902358", VA = "0x2902358")]
		public float GetWeight(int index)
		{
			return default(float);
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x290239C", Offset = "0x290239C", VA = "0x290239C")]
		public float GetWeight(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x29023F0", Offset = "0x29023F0", VA = "0x29023F0")]
		public void AddChannel(string name)
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x29026CC", Offset = "0x29026CC", VA = "0x29026CC")]
		public void RemoveChannel(string name)
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x29026F4", Offset = "0x29026F4", VA = "0x29026F4")]
		public void RemoveChannel(int index)
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x2901F88", Offset = "0x2901F88", VA = "0x2901F88")]
		private int GetChannelIndex(string name)
		{
			return default(int);
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x2902878", Offset = "0x2902878", VA = "0x2902878")]
		public int GetChannelCount()
		{
			return default(int);
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x2902890", Offset = "0x2902890", VA = "0x2902890")]
		public Channel GetChannel(int index)
		{
			return null;
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x29028CC", Offset = "0x29028CC", VA = "0x29028CC")]
		public Channel GetChannel(string name)
		{
			return null;
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x2901480", Offset = "0x2901480", VA = "0x2901480")]
		public void UpdateMorph()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x290294C", Offset = "0x290294C", VA = "0x290294C")]
		public SplineMorph()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB1588", Offset = "0xBB1588")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		[HideInInspector]
		private GameObject _targetObject;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		[HideInInspector]
		private double _position;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		[HideInInspector]
		private float animPosition;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[SerializeField]
		[HideInInspector]
		private Mode _mode;

		[Token(Token = "0x170002D0")]
		public GameObject targetObject
		{
			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x2903894", Offset = "0x2903894", VA = "0x2903894")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x2903920", Offset = "0x2903920", VA = "0x2903920")]
			set
			{
			}
		}

		[Token(Token = "0x170002D1")]
		public double position
		{
			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x2903A58", Offset = "0x2903A58", VA = "0x2903A58")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x2903A60", Offset = "0x2903A60", VA = "0x2903A60")]
			set
			{
			}
		}

		[Token(Token = "0x170002D2")]
		public Mode mode
		{
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x2903AB8", Offset = "0x2903AB8", VA = "0x2903AB8")]
			get
			{
				return default(Mode);
			}
			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x2903AC0", Offset = "0x2903AC0", VA = "0x2903AC0")]
			set
			{
			}
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x2903AE0", Offset = "0x2903AE0", VA = "0x2903AE0", Slot = "9")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x2903BB4", Offset = "0x2903BB4", VA = "0x2903BB4", Slot = "23")]
		protected override Transform GetTransform()
		{
			return null;
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x2903BD4", Offset = "0x2903BD4", VA = "0x2903BD4", Slot = "21")]
		protected override Rigidbody GetRigidbody()
		{
			return null;
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x2903C2C", Offset = "0x2903C2C", VA = "0x2903C2C", Slot = "22")]
		protected override Rigidbody2D GetRigidbody2D()
		{
			return null;
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x2903C84", Offset = "0x2903C84", VA = "0x2903C84", Slot = "15")]
		protected override void PostBuild()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x2903D1C", Offset = "0x2903D1C", VA = "0x2903D1C", Slot = "19")]
		public override void SetPercent(double percent, bool checkTriggers = false, bool handleJuncitons = false)
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x2903D54", Offset = "0x2903D54", VA = "0x2903D54", Slot = "20")]
		public override void SetDistance(float distance, bool checkTriggers = false, bool handleJuncitons = false)
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x2903D90", Offset = "0x2903D90", VA = "0x2903D90")]
		public SplinePositioner()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB15C0", Offset = "0xBB15C0")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		[HideInInspector]
		private Mode _mode;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[SerializeField]
		[HideInInspector]
		private bool _autoProject;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBB4808", Offset = "0xBB4808")]
		private int _subdivide;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		[HideInInspector]
		private Transform _projectTarget;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		[HideInInspector]
		private Transform applyTarget;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		[HideInInspector]
		private GameObject _targetObject;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		[HideInInspector]
		public Vector2 _offset;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		[HideInInspector]
		public Vector3 _rotationOffset;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[SerializeField]
		[HideInInspector]
		private Vector3 lastPosition;

		[Token(Token = "0x170002D3")]
		public Mode mode
		{
			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x2904610", Offset = "0x2904610", VA = "0x2904610")]
			get
			{
				return default(Mode);
			}
			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x2904618", Offset = "0x2904618", VA = "0x2904618")]
			set
			{
			}
		}

		[Token(Token = "0x170002D4")]
		public bool autoProject
		{
			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x2904638", Offset = "0x2904638", VA = "0x2904638")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x2904640", Offset = "0x2904640", VA = "0x2904640")]
			set
			{
			}
		}

		[Token(Token = "0x170002D5")]
		public int subdivide
		{
			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x2904670", Offset = "0x2904670", VA = "0x2904670")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x2904678", Offset = "0x2904678", VA = "0x2904678")]
			set
			{
			}
		}

		[Token(Token = "0x170002D6")]
		public Transform projectTarget
		{
			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x29046A0", Offset = "0x29046A0", VA = "0x29046A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x290472C", Offset = "0x290472C", VA = "0x290472C")]
			set
			{
			}
		}

		[Token(Token = "0x170002D7")]
		public GameObject targetObject
		{
			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x29047D8", Offset = "0x29047D8", VA = "0x29047D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x29048C4", Offset = "0x29048C4", VA = "0x29048C4")]
			set
			{
			}
		}

		[Token(Token = "0x14000008")]
		public event SplineReachHandler onEndReached
		{
			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x2904978", Offset = "0x2904978", VA = "0x2904978")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6D10", Offset = "0xBB6D10")]
			add
			{
			}
			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x2904A1C", Offset = "0x2904A1C", VA = "0x2904A1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6D20", Offset = "0xBB6D20")]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public event SplineReachHandler onBeginningReached
		{
			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x2904AC0", Offset = "0x2904AC0", VA = "0x2904AC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6D30", Offset = "0xBB6D30")]
			add
			{
			}
			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x2904B64", Offset = "0x2904B64", VA = "0x2904B64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6D40", Offset = "0xBB6D40")]
			remove
			{
			}
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x2904C08", Offset = "0x2904C08", VA = "0x2904C08", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x2904C3C", Offset = "0x2904C3C", VA = "0x2904C3C", Slot = "23")]
		protected override Transform GetTransform()
		{
			return null;
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x2904CE0", Offset = "0x2904CE0", VA = "0x2904CE0", Slot = "21")]
		protected override Rigidbody GetRigidbody()
		{
			return null;
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x2904D94", Offset = "0x2904D94", VA = "0x2904D94", Slot = "22")]
		protected override Rigidbody2D GetRigidbody2D()
		{
			return null;
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x2904E48", Offset = "0x2904E48", VA = "0x2904E48", Slot = "13")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x29051A4", Offset = "0x29051A4", VA = "0x29051A4", Slot = "15")]
		protected override void PostBuild()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x29051F0", Offset = "0x29051F0", VA = "0x29051F0", Slot = "16")]
		protected override void OnSplineChanged()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x29052E8", Offset = "0x29052E8", VA = "0x29052E8")]
		private void Project()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x2904F5C", Offset = "0x2904F5C", VA = "0x2904F5C")]
		public void CalculateProjection()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x2905404", Offset = "0x2905404", VA = "0x2905404")]
		public SplineProjector()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBB160C", Offset = "0xBB160C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBB160C", Offset = "0xBB160C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB160C", Offset = "0xBB160C")]
	[ExecuteInEditMode]
	public class SplineRenderer : MeshGenerator
	{
		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[HideInInspector]
		public bool autoOrient;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[HideInInspector]
		public int updateFrameInterval;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private int currentFrame;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[SerializeField]
		[HideInInspector]
		private int _slices;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		[HideInInspector]
		private Vector3 vertexDirection;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private bool orthographic;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x135")]
		private bool init;

		[Token(Token = "0x170002D8")]
		public int slices
		{
			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x29054AC", Offset = "0x29054AC", VA = "0x29054AC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x29054B4", Offset = "0x29054B4", VA = "0x29054B4")]
			set
			{
			}
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x29054DC", Offset = "0x29054DC", VA = "0x29054DC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x2905540", Offset = "0x2905540", VA = "0x2905540")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x29055E0", Offset = "0x29055E0", VA = "0x29055E0", Slot = "13")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x2905604", Offset = "0x2905604", VA = "0x2905604", Slot = "18")]
		protected override void BuildMesh()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x2905C0C", Offset = "0x2905C0C", VA = "0x2905C0C")]
		public void RenderWithCamera(Camera cam)
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x2905D34", Offset = "0x2905D34", VA = "0x2905D34")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x29056C4", Offset = "0x29056C4", VA = "0x29056C4")]
		public void GenerateVertices(Vector3 vertexDirection, bool orthoGraphic)
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x2905DE4", Offset = "0x2905DE4", VA = "0x2905DE4")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Node node;

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int point;

			[Token(Token = "0x6000996")]
			[Address(RVA = "0x26AEA78", Offset = "0x26AEA78", VA = "0x26AEA78")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private SplineTrigger[] triggerInvokeQueue;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<NodeConnection> nodeConnectionQueue;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int addTriggerIndex;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[HideInInspector]
		public bool applyDirectionRotation;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		[HideInInspector]
		public bool useTriggers;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		public int triggerGroup;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[SerializeField]
		[HideInInspector]
		protected Spline.Direction _direction;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[HideInInspector]
		protected PhysicsMode _physicsMode;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[HideInInspector]
		protected TransformModule _motion;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[HideInInspector]
		protected Rigidbody targetRigidbody;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[HideInInspector]
		protected Rigidbody2D targetRigidbody2D;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[HideInInspector]
		protected Transform targetTransform;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[HideInInspector]
		protected SplineSample _result;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[HideInInspector]
		protected SplineSample _finalResult;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool setPercentOnRebuild;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private double targetPercentOnRebuild;

		[Token(Token = "0x4000470")]
		private const double MIN_DELTA = 1E-06;

		[Token(Token = "0x170002D9")]
		public PhysicsMode physicsMode
		{
			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x29070EC", Offset = "0x29070EC", VA = "0x29070EC")]
			get
			{
				return default(PhysicsMode);
			}
			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x29070F4", Offset = "0x29070F4", VA = "0x29070F4")]
			set
			{
			}
		}

		[Token(Token = "0x170002DA")]
		public TransformModule motion
		{
			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x29070FC", Offset = "0x29070FC", VA = "0x29070FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002DB")]
		public SplineSample result
		{
			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x2907170", Offset = "0x2907170", VA = "0x2907170")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002DC")]
		public SplineSample modifiedResult
		{
			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x2907178", Offset = "0x2907178", VA = "0x2907178")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002DD")]
		public Spline.Direction direction
		{
			[Token(Token = "0x6000700")]
			[Address(RVA = "0x2907180", Offset = "0x2907180", VA = "0x2907180")]
			get
			{
				return default(Spline.Direction);
			}
			[Token(Token = "0x6000701")]
			[Address(RVA = "0x2907188", Offset = "0x2907188", VA = "0x2907188")]
			set
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public event JunctionHandler onNode
		{
			[Token(Token = "0x6000702")]
			[Address(RVA = "0x29071A0", Offset = "0x29071A0", VA = "0x29071A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6D50", Offset = "0xBB6D50")]
			add
			{
			}
			[Token(Token = "0x6000703")]
			[Address(RVA = "0x2907244", Offset = "0x2907244", VA = "0x2907244")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6D60", Offset = "0xBB6D60")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		public event EmptySplineHandler onMotionApplied
		{
			[Token(Token = "0x6000704")]
			[Address(RVA = "0x29072E8", Offset = "0x29072E8", VA = "0x29072E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6D70", Offset = "0xBB6D70")]
			add
			{
			}
			[Token(Token = "0x6000705")]
			[Address(RVA = "0x290738C", Offset = "0x290738C", VA = "0x290738C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6D80", Offset = "0xBB6D80")]
			remove
			{
			}
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x28FBD80", Offset = "0x28FBD80", VA = "0x28FBD80", Slot = "18")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x28FC8EC", Offset = "0x28FC8EC", VA = "0x28FC8EC", Slot = "19")]
		public virtual void SetPercent(double percent, bool checkTriggers = false, bool handleJunctions = false)
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x28FCA20", Offset = "0x28FCA20", VA = "0x28FCA20", Slot = "20")]
		public virtual void SetDistance(float distance, bool checkTriggers = false, bool handleJunctions = false)
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x28FBF48", Offset = "0x28FBF48", VA = "0x28FBF48", Slot = "15")]
		protected override void PostBuild()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x2907454", Offset = "0x2907454", VA = "0x2907454", Slot = "21")]
		protected virtual Rigidbody GetRigidbody()
		{
			return null;
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x29074A0", Offset = "0x29074A0", VA = "0x29074A0", Slot = "22")]
		protected virtual Rigidbody2D GetRigidbody2D()
		{
			return null;
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x29074EC", Offset = "0x29074EC", VA = "0x29074EC", Slot = "23")]
		protected virtual Transform GetTransform()
		{
			return null;
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x28FBFDC", Offset = "0x28FBFDC", VA = "0x28FBFDC")]
		protected void ApplyMotion()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x28FCE78", Offset = "0x28FCE78", VA = "0x28FCE78")]
		protected void CheckNodes(double from, double to)
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x28FD334", Offset = "0x28FD334", VA = "0x28FD334")]
		protected void InvokeNodes()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x28FCD20", Offset = "0x28FCD20", VA = "0x28FCD20")]
		protected void CheckTriggers(double from, double to)
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x2907510", Offset = "0x2907510", VA = "0x2907510")]
		private NodeConnection GetJunction(int pointIndex)
		{
			return null;
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x28FD2BC", Offset = "0x28FD2BC", VA = "0x28FD2BC")]
		protected void InvokeTriggers()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x29039D4", Offset = "0x29039D4", VA = "0x29039D4")]
		protected void RefreshTargets()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x2907678", Offset = "0x2907678", VA = "0x2907678")]
		private void AddTriggerToQueue(SplineTrigger trigger)
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x28FD468", Offset = "0x28FD468", VA = "0x28FD468")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public UpdateMethod updateMethod;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBB4C78", Offset = "0xBB4C78")]
		private SplineComputer _spline;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[HideInInspector]
		private bool _autoUpdate;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		protected RotationModifier _rotationModifier;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		protected OffsetModifier _offsetModifier;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		protected ColorModifier _colorModifier;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		protected SizeModifier _sizeModifier;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		private SampleCollection sampleCollection;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[HideInInspector]
		private SplineSample clipFromSample;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[HideInInspector]
		private SplineSample clipToSample;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[HideInInspector]
		private float animClipFrom;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		[HideInInspector]
		private float animClipTo;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool rebuild;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool getSamples;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
		private bool postBuild;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Transform trs;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[HideInInspector]
		private int _sampleCount;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[SerializeField]
		[HideInInspector]
		private int startSampleIndex;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected SplineSample evalResult;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[HideInInspector]
		public bool multithreaded;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		[HideInInspector]
		public bool buildOnAwake;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
		[HideInInspector]
		public bool buildOnEnable;

		[Token(Token = "0x170002DE")]
		public SplineComputer spline
		{
			[Token(Token = "0x6000716")]
			[Address(RVA = "0x2907CC0", Offset = "0x2907CC0", VA = "0x2907CC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000717")]
			[Address(RVA = "0x2907CC8", Offset = "0x2907CC8", VA = "0x2907CC8")]
			set
			{
			}
		}

		[Token(Token = "0x170002DF")]
		public double clipFrom
		{
			[Token(Token = "0x6000718")]
			[Address(RVA = "0x28FCB38", Offset = "0x28FCB38", VA = "0x28FCB38")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000719")]
			[Address(RVA = "0x2907E24", Offset = "0x2907E24", VA = "0x2907E24")]
			set
			{
			}
		}

		[Token(Token = "0x170002E0")]
		public double clipTo
		{
			[Token(Token = "0x600071A")]
			[Address(RVA = "0x28FCB54", Offset = "0x28FCB54", VA = "0x28FCB54")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x600071B")]
			[Address(RVA = "0x2907EC4", Offset = "0x2907EC4", VA = "0x2907EC4")]
			set
			{
			}
		}

		[Token(Token = "0x170002E1")]
		public bool autoUpdate
		{
			[Token(Token = "0x600071C")]
			[Address(RVA = "0x2907F64", Offset = "0x2907F64", VA = "0x2907F64")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600071D")]
			[Address(RVA = "0x2907F6C", Offset = "0x2907F6C", VA = "0x2907F6C")]
			set
			{
			}
		}

		[Token(Token = "0x170002E2")]
		public bool loopSamples
		{
			[Token(Token = "0x600071E")]
			[Address(RVA = "0x2907F9C", Offset = "0x2907F9C", VA = "0x2907F9C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600071F")]
			[Address(RVA = "0x2907FB8", Offset = "0x2907FB8", VA = "0x2907FB8")]
			set
			{
			}
		}

		[Token(Token = "0x170002E3")]
		public double span
		{
			[Token(Token = "0x6000720")]
			[Address(RVA = "0x290802C", Offset = "0x290802C", VA = "0x290802C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170002E4")]
		public bool samplesAreLooped
		{
			[Token(Token = "0x6000721")]
			[Address(RVA = "0x28FCB1C", Offset = "0x28FCB1C", VA = "0x28FCB1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170002E5")]
		public RotationModifier rotationModifier
		{
			[Token(Token = "0x6000722")]
			[Address(RVA = "0x2908084", Offset = "0x2908084", VA = "0x2908084")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002E6")]
		public OffsetModifier offsetModifier
		{
			[Token(Token = "0x6000723")]
			[Address(RVA = "0x290808C", Offset = "0x290808C", VA = "0x290808C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002E7")]
		public ColorModifier colorModifier
		{
			[Token(Token = "0x6000724")]
			[Address(RVA = "0x2908094", Offset = "0x2908094", VA = "0x2908094")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002E8")]
		public SizeModifier sizeModifier
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x290809C", Offset = "0x290809C", VA = "0x290809C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002E9")]
		public int sampleCount
		{
			[Token(Token = "0x6000726")]
			[Address(RVA = "0x29080A4", Offset = "0x29080A4", VA = "0x29080A4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x29080AC", Offset = "0x29080AC", VA = "0x29080AC", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x2904C38", Offset = "0x2904C38", VA = "0x2904C38", Slot = "5")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x29081BC", Offset = "0x29081BC", VA = "0x29081BC", Slot = "6")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x2908268", Offset = "0x2908268", VA = "0x2908268", Slot = "7")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x29082FC", Offset = "0x29082FC", VA = "0x29082FC", Slot = "8")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x2903B1C", Offset = "0x2903B1C", VA = "0x2903B1C", Slot = "9")]
		protected virtual void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x28FCB70", Offset = "0x28FCB70", VA = "0x28FCB70")]
		public SplineSample GetSampleRaw(int index)
		{
			return null;
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x2905DB4", Offset = "0x2905DB4", VA = "0x2905DB4")]
		public void GetSample(int index, SplineSample target)
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x2908408", Offset = "0x2908408", VA = "0x2908408", Slot = "10")]
		public virtual void Rebuild()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x290841C", Offset = "0x290841C", VA = "0x290841C", Slot = "11")]
		public virtual void RebuildImmediate()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x290853C", Offset = "0x290853C", VA = "0x290853C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x29086D8", Offset = "0x29086D8", VA = "0x29086D8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x2908728", Offset = "0x2908728", VA = "0x2908728")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x2908588", Offset = "0x2908588", VA = "0x2908588")]
		private void RunUpdate()
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x2908778", Offset = "0x2908778", VA = "0x2908778")]
		private void BuildThreaded()
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x29087AC", Offset = "0x29087AC", VA = "0x29087AC")]
		private void ResampleAndBuildThreaded()
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x29087E8", Offset = "0x29087E8", VA = "0x29087E8", Slot = "12")]
		protected virtual void Run()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x28FBD94", Offset = "0x28FBD94", VA = "0x28FBD94", Slot = "13")]
		protected virtual void LateRun()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x29087EC", Offset = "0x29087EC", VA = "0x29087EC", Slot = "14")]
		protected virtual void Build()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x29087F0", Offset = "0x29087F0", VA = "0x29087F0", Slot = "15")]
		protected virtual void PostBuild()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x29087F4", Offset = "0x29087F4", VA = "0x29087F4", Slot = "16")]
		protected virtual void OnSplineChanged()
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x2900ED0", Offset = "0x2900ED0", VA = "0x2900ED0")]
		public void ModifySample(SplineSample source, SplineSample destination)
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x2900C8C", Offset = "0x2900C8C", VA = "0x2900C8C")]
		public void ModifySample(SplineSample sample)
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x29087F8", Offset = "0x29087F8", VA = "0x29087F8")]
		public void SetClipRange(double from, double to)
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x2908300", Offset = "0x2908300", VA = "0x2908300")]
		private void GetSamples()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x28FCAE4", Offset = "0x28FCAE4", VA = "0x28FCAE4")]
		public double ClipPercent(double percent)
		{
			return default(double);
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x2908894", Offset = "0x2908894", VA = "0x2908894")]
		public void ClipPercent(ref double percent)
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x29088B0", Offset = "0x29088B0", VA = "0x29088B0")]
		public double UnclipPercent(double percent)
		{
			return default(double);
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x29074F4", Offset = "0x29074F4", VA = "0x29074F4")]
		public void UnclipPercent(ref double percent)
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x29088E8", Offset = "0x29088E8", VA = "0x29088E8")]
		private int GetSampleIndex(double percent)
		{
			return default(int);
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x2908928", Offset = "0x2908928", VA = "0x2908928")]
		public Vector3 EvaluatePosition(double percent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x28FBF8C", Offset = "0x28FBF8C", VA = "0x28FBF8C")]
		public void Evaluate(double percent, SplineSample result)
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x2908944", Offset = "0x2908944", VA = "0x2908944")]
		public SplineSample Evaluate(double percent)
		{
			return null;
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x29089D0", Offset = "0x29089D0", VA = "0x29089D0")]
		public void Evaluate(ref SplineSample[] results, double from = 0.0, double to = 1.0)
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x2908A64", Offset = "0x2908A64", VA = "0x2908A64")]
		public void EvaluatePositions(ref Vector3[] positions, double from = 0.0, double to = 1.0)
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x28FD3C4", Offset = "0x28FD3C4", VA = "0x28FD3C4")]
		public double Travel(double start, float distance, Spline.Direction direction, out float moved)
		{
			return default(double);
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x2907430", Offset = "0x2907430", VA = "0x2907430")]
		public double Travel(double start, float distance, Spline.Direction direction = Spline.Direction.Forward)
		{
			return default(double);
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x2908A80", Offset = "0x2908A80", VA = "0x2908A80", Slot = "17")]
		public virtual void Project(Vector3 position, SplineSample result, double from = 0.0, double to = 1.0)
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x28FE690", Offset = "0x28FE690", VA = "0x28FE690")]
		public float CalculateLength(double from = 0.0, double to = 1.0)
		{
			return default(float);
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x2907888", Offset = "0x2907888", VA = "0x2907888")]
		public SplineUser()
		{
		}
	}
	[Token(Token = "0x200006C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBB16E4", Offset = "0xBB16E4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBB16E4", Offset = "0xBB16E4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB16E4", Offset = "0xBB16E4")]
	public class SurfaceGenerator : MeshGenerator
	{
		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		[HideInInspector]
		private float _expand;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[SerializeField]
		[HideInInspector]
		private float _extrude;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		[HideInInspector]
		private Vector2 _sideUvScale;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		[HideInInspector]
		private Vector2 _sideUvOffset;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		[HideInInspector]
		private SplineComputer _extrudeSpline;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		[HideInInspector]
		private SplineSample[] extrudeResults;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		[HideInInspector]
		private Vector3[] identityVertices;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		[HideInInspector]
		private Vector3[] identityNormals;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[SerializeField]
		[HideInInspector]
		private Vector2[] projectedVerts;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[SerializeField]
		[HideInInspector]
		private int[] surfaceTris;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[SerializeField]
		[HideInInspector]
		private int[] wallTris;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[SerializeField]
		[HideInInspector]
		private double _extrudeFrom;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[SerializeField]
		[HideInInspector]
		private double _extrudeTo;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[SerializeField]
		[HideInInspector]
		private bool _uniformUvs;

		[Token(Token = "0x170002EA")]
		public float expand
		{
			[Token(Token = "0x600074F")]
			[Address(RVA = "0x2908D6C", Offset = "0x2908D6C", VA = "0x2908D6C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000750")]
			[Address(RVA = "0x2908D74", Offset = "0x2908D74", VA = "0x2908D74")]
			set
			{
			}
		}

		[Token(Token = "0x170002EB")]
		public float extrude
		{
			[Token(Token = "0x6000751")]
			[Address(RVA = "0x2908D94", Offset = "0x2908D94", VA = "0x2908D94")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000752")]
			[Address(RVA = "0x2908D9C", Offset = "0x2908D9C", VA = "0x2908D9C")]
			set
			{
			}
		}

		[Token(Token = "0x170002EC")]
		public double extrudeClipFrom
		{
			[Token(Token = "0x6000753")]
			[Address(RVA = "0x2908DBC", Offset = "0x2908DBC", VA = "0x2908DBC")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000754")]
			[Address(RVA = "0x2908DC4", Offset = "0x2908DC4", VA = "0x2908DC4")]
			set
			{
			}
		}

		[Token(Token = "0x170002ED")]
		public double extrudeClipTo
		{
			[Token(Token = "0x6000755")]
			[Address(RVA = "0x2908DE4", Offset = "0x2908DE4", VA = "0x2908DE4")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000756")]
			[Address(RVA = "0x2908DEC", Offset = "0x2908DEC", VA = "0x2908DEC")]
			set
			{
			}
		}

		[Token(Token = "0x170002EE")]
		public Vector2 sideUvScale
		{
			[Token(Token = "0x6000757")]
			[Address(RVA = "0x2908E0C", Offset = "0x2908E0C", VA = "0x2908E0C")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000758")]
			[Address(RVA = "0x2908E18", Offset = "0x2908E18", VA = "0x2908E18")]
			set
			{
			}
		}

		[Token(Token = "0x170002EF")]
		public Vector2 sideUvOffset
		{
			[Token(Token = "0x6000759")]
			[Address(RVA = "0x2908E5C", Offset = "0x2908E5C", VA = "0x2908E5C")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600075A")]
			[Address(RVA = "0x2908E68", Offset = "0x2908E68", VA = "0x2908E68")]
			set
			{
			}
		}

		[Token(Token = "0x170002F0")]
		public SplineComputer extrudeSpline
		{
			[Token(Token = "0x600075B")]
			[Address(RVA = "0x2908EAC", Offset = "0x2908EAC", VA = "0x2908EAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600075C")]
			[Address(RVA = "0x2908EB4", Offset = "0x2908EB4", VA = "0x2908EB4")]
			set
			{
			}
		}

		[Token(Token = "0x170002F1")]
		public bool uniformUvs
		{
			[Token(Token = "0x600075D")]
			[Address(RVA = "0x2908FF8", Offset = "0x2908FF8", VA = "0x2908FF8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600075E")]
			[Address(RVA = "0x2909000", Offset = "0x2909000", VA = "0x2909000")]
			set
			{
			}
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x290902C", Offset = "0x290902C", VA = "0x290902C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x2909090", Offset = "0x2909090", VA = "0x2909090", Slot = "18")]
		protected override void BuildMesh()
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x29090E0", Offset = "0x29090E0", VA = "0x29090E0")]
		public void Generate()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x290A9C4", Offset = "0x290A9C4", VA = "0x290A9C4")]
		private void GenerateSurfaceTris(bool flip)
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x290ACD0", Offset = "0x290ACD0", VA = "0x290ACD0")]
		private int WriteTris(ref int[] tris, ref int[] target, int vertexOffset, int trisOffset, bool flip)
		{
			return default(int);
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x290A8F8", Offset = "0x290A8F8", VA = "0x290A8F8")]
		private bool IsClockwise(Vector2[] points2D)
		{
			return default(bool);
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x290AA78", Offset = "0x290AA78", VA = "0x290AA78")]
		private void GetIdentityVerts(Vector3 center, Vector3 normal, bool clockwise)
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x290A4B0", Offset = "0x290A4B0", VA = "0x290A4B0")]
		private void GetProjectedVertices(int count, out Vector3 center, out Vector3 normal)
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x290AEA4", Offset = "0x290AEA4", VA = "0x290AEA4")]
		public SurfaceGenerator()
		{
		}
	}
	[Token(Token = "0x200006D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBB179C", Offset = "0xBB179C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBB179C", Offset = "0xBB179C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB179C", Offset = "0xBB179C")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		[HideInInspector]
		private int _sides;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[SerializeField]
		[HideInInspector]
		private int _roundCapLatitude;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		[HideInInspector]
		private CapMethod _capMode;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBB535C", Offset = "0xBB535C")]
		private float _revolve;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		[HideInInspector]
		private float _capUVScale;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int bodyVertexCount;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private int bodyTrisCount;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private int capVertexCount;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private int capTrisCount;

		[Token(Token = "0x170002F2")]
		public int sides
		{
			[Token(Token = "0x6000768")]
			[Address(RVA = "0x1FA659C", Offset = "0x1FA659C", VA = "0x1FA659C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000769")]
			[Address(RVA = "0x1FA65A4", Offset = "0x1FA65A4", VA = "0x1FA65A4")]
			set
			{
			}
		}

		[Token(Token = "0x170002F3")]
		public CapMethod capMode
		{
			[Token(Token = "0x600076A")]
			[Address(RVA = "0x1FA65D0", Offset = "0x1FA65D0", VA = "0x1FA65D0")]
			get
			{
				return default(CapMethod);
			}
			[Token(Token = "0x600076B")]
			[Address(RVA = "0x1FA65D8", Offset = "0x1FA65D8", VA = "0x1FA65D8")]
			set
			{
			}
		}

		[Token(Token = "0x170002F4")]
		public int roundCapLatitude
		{
			[Token(Token = "0x600076C")]
			[Address(RVA = "0x1FA65F8", Offset = "0x1FA65F8", VA = "0x1FA65F8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600076D")]
			[Address(RVA = "0x1FA6600", Offset = "0x1FA6600", VA = "0x1FA6600")]
			set
			{
			}
		}

		[Token(Token = "0x170002F5")]
		public float revolve
		{
			[Token(Token = "0x600076E")]
			[Address(RVA = "0x1FA6634", Offset = "0x1FA6634", VA = "0x1FA6634")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600076F")]
			[Address(RVA = "0x1FA663C", Offset = "0x1FA663C", VA = "0x1FA663C")]
			set
			{
			}
		}

		[Token(Token = "0x170002F6")]
		public float capUVScale
		{
			[Token(Token = "0x6000770")]
			[Address(RVA = "0x1FA665C", Offset = "0x1FA665C", VA = "0x1FA665C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000771")]
			[Address(RVA = "0x1FA6664", Offset = "0x1FA6664", VA = "0x1FA6664")]
			set
			{
			}
		}

		[Token(Token = "0x170002F7")]
		private bool useCap
		{
			[Token(Token = "0x6000772")]
			[Address(RVA = "0x1FA6684", Offset = "0x1FA6684", VA = "0x1FA6684")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x1FA6750", Offset = "0x1FA6750", VA = "0x1FA6750", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x1FA6758", Offset = "0x1FA6758", VA = "0x1FA6758", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x1FA67BC", Offset = "0x1FA67BC", VA = "0x1FA67BC", Slot = "18")]
		protected override void BuildMesh()
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x1FA68F0", Offset = "0x1FA68F0", VA = "0x1FA68F0")]
		private void Generate()
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x1FA6DD4", Offset = "0x1FA6DD4", VA = "0x1FA6DD4")]
		private void GenerateFlatCaps()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x1FA740C", Offset = "0x1FA740C", VA = "0x1FA740C")]
		private void GenerateRoundCaps()
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x1FA8104", Offset = "0x1FA8104", VA = "0x1FA8104")]
		public TubeGenerator()
		{
		}
	}
	[Token(Token = "0x200006E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBB1854", Offset = "0xBB1854")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBB1854", Offset = "0xBB1854")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB1854", Offset = "0xBB1854")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		[HideInInspector]
		private Axis _axis;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[SerializeField]
		[HideInInspector]
		private bool _symmetry;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		[HideInInspector]
		private UVWrapMode _uvWrapMode;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[SerializeField]
		[HideInInspector]
		private int _slices;

		[Token(Token = "0x170002F8")]
		public Axis axis
		{
			[Token(Token = "0x600077A")]
			[Address(RVA = "0x1FB359C", Offset = "0x1FB359C", VA = "0x1FB359C")]
			get
			{
				return default(Axis);
			}
			[Token(Token = "0x600077B")]
			[Address(RVA = "0x1FB35A4", Offset = "0x1FB35A4", VA = "0x1FB35A4")]
			set
			{
			}
		}

		[Token(Token = "0x170002F9")]
		public bool symmetry
		{
			[Token(Token = "0x600077C")]
			[Address(RVA = "0x1FB35C4", Offset = "0x1FB35C4", VA = "0x1FB35C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600077D")]
			[Address(RVA = "0x1FB35CC", Offset = "0x1FB35CC", VA = "0x1FB35CC")]
			set
			{
			}
		}

		[Token(Token = "0x170002FA")]
		public UVWrapMode uvWrapMode
		{
			[Token(Token = "0x600077E")]
			[Address(RVA = "0x1FB35F8", Offset = "0x1FB35F8", VA = "0x1FB35F8")]
			get
			{
				return default(UVWrapMode);
			}
			[Token(Token = "0x600077F")]
			[Address(RVA = "0x1FB3600", Offset = "0x1FB3600", VA = "0x1FB3600")]
			set
			{
			}
		}

		[Token(Token = "0x170002FB")]
		public int slices
		{
			[Token(Token = "0x6000780")]
			[Address(RVA = "0x1FB3620", Offset = "0x1FB3620", VA = "0x1FB3620")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000781")]
			[Address(RVA = "0x1FB3628", Offset = "0x1FB3628", VA = "0x1FB3628")]
			set
			{
			}
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x1FB3650", Offset = "0x1FB3650", VA = "0x1FB3650", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x1FB36B4", Offset = "0x1FB36B4", VA = "0x1FB36B4", Slot = "18")]
		protected override void BuildMesh()
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x1FB3E1C", Offset = "0x1FB3E1C", VA = "0x1FB3E1C", Slot = "14")]
		protected override void Build()
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x1FB3E24", Offset = "0x1FB3E24", VA = "0x1FB3E24", Slot = "13")]
		protected override void LateRun()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x1FB36DC", Offset = "0x1FB36DC", VA = "0x1FB36DC")]
		private void Generate()
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x1FB3E2C", Offset = "0x1FB3E2C", VA = "0x1FB3E2C")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public SplineSample[] samples;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int[] optimizedIndices;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SplineComputer.SampleMode sampleMode;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public double clipFrom;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public double clipTo;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool loopSamples;

		[Token(Token = "0x170002FD")]
		public int Count
		{
			[Token(Token = "0x600078E")]
			[Address(RVA = "0x26F8F54", Offset = "0x26F8F54", VA = "0x26F8F54")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170002FE")]
		private bool hasSamples
		{
			[Token(Token = "0x600078F")]
			[Address(RVA = "0x26F8F70", Offset = "0x26F8F70", VA = "0x26F8F70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170002FF")]
		public bool samplesAreLooped
		{
			[Token(Token = "0x6000790")]
			[Address(RVA = "0x26F8F94", Offset = "0x26F8F94", VA = "0x26F8F94")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000300")]
		public double span
		{
			[Token(Token = "0x6000791")]
			[Address(RVA = "0x26F8FB4", Offset = "0x26F8FB4", VA = "0x26F8FB4")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x26F8FE4", Offset = "0x26F8FE4", VA = "0x26F8FE4")]
		public SampleCollection()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x26F9084", Offset = "0x26F9084", VA = "0x26F9084")]
		public SampleCollection(SampleCollection input)
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x26F917C", Offset = "0x26F917C", VA = "0x26F917C")]
		public int GetClippedSampleCount(out int startIndex, out int endIndex)
		{
			return default(int);
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x26F944C", Offset = "0x26F944C", VA = "0x26F944C")]
		public double ClipPercent(double percent)
		{
			return default(double);
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x26F9474", Offset = "0x26F9474", VA = "0x26F9474")]
		public void ClipPercent(ref double percent)
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x26F9538", Offset = "0x26F9538", VA = "0x26F9538")]
		public double UnclipPercent(double percent)
		{
			return default(double);
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x26F9560", Offset = "0x26F9560", VA = "0x26F9560")]
		public void UnclipPercent(ref double percent)
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x26F92C4", Offset = "0x26F92C4", VA = "0x26F92C4")]
		public void GetSamplingValues(double percent, out int sampleIndex, out double lerp)
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x26F961C", Offset = "0x26F961C", VA = "0x26F961C")]
		public Vector3 EvaluatePosition(double percent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x26F9740", Offset = "0x26F9740", VA = "0x26F9740")]
		public SplineSample Evaluate(double percent)
		{
			return null;
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x26F97B8", Offset = "0x26F97B8", VA = "0x26F97B8")]
		public void Evaluate(double percent, SplineSample result)
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x26F98DC", Offset = "0x26F98DC", VA = "0x26F98DC")]
		public void Evaluate(ref SplineSample[] results, double from = 0.0, double to = 1.0)
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x26F9C14", Offset = "0x26F9C14", VA = "0x26F9C14")]
		public void EvaluatePositions(ref Vector3[] positions, double from = 0.0, double to = 1.0)
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x26F9E68", Offset = "0x26F9E68", VA = "0x26F9E68")]
		public double Travel(double start, float distance, Spline.Direction direction, out float moved)
		{
			return default(double);
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x26FA208", Offset = "0x26FA208", VA = "0x26FA208")]
		public double Travel(double start, float distance, Spline.Direction direction = Spline.Direction.Forward)
		{
			return default(double);
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x26FA22C", Offset = "0x26FA22C", VA = "0x26FA22C")]
		public void Project(Vector3 position, int controlPointCount, SplineSample result, double from = 0.0, double to = 1.0)
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x26FABAC", Offset = "0x26FABAC", VA = "0x26FABAC")]
		private double GetSamplePercent(int sampleIndex)
		{
			return default(double);
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x26FAC34", Offset = "0x26FAC34", VA = "0x26FAC34")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SplinePoint[] points;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool closed;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Type type;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool linearAverageDirection;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve customValueInterpolation;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve customNormalInterpolation;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int sampleRate;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3[] catPoints;

		[Token(Token = "0x17000301")]
		public bool isClosed
		{
			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x26FD574", Offset = "0x26FD574", VA = "0x26FD574")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x26FD5A8", Offset = "0x26FD5A8", VA = "0x26FD5A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000302")]
		public double moveStep
		{
			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x26FD5AC", Offset = "0x26FD5AC", VA = "0x26FD5AC")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x26FD644", Offset = "0x26FD644", VA = "0x26FD644")]
			set
			{
			}
		}

		[Token(Token = "0x17000303")]
		public int iterations
		{
			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x26FD5F4", Offset = "0x26FD5F4", VA = "0x26FD5F4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x26FD648", Offset = "0x26FD648", VA = "0x26FD648")]
		public Spline(Type type)
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x26F35DC", Offset = "0x26F35DC", VA = "0x26F35DC")]
		public Spline(Type type, int sampleRate)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x26FD6F8", Offset = "0x26FD6F8", VA = "0x26FD6F8")]
		public float CalculateLength(double from = 0.0, double to = 1.0, double resolution = 1.0)
		{
			return default(float);
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x26FD898", Offset = "0x26FD898", VA = "0x26FD898")]
		public double Project(Vector3 position, int subdivide = 4, double from = 0.0, double to = 1.0)
		{
			return default(double);
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x26FDC34", Offset = "0x26FDC34", VA = "0x26FDC34")]
		public bool Raycast(out RaycastHit hit, out double hitPercent, LayerMask layerMask, double resolution = 1.0, double from = 0.0, double to = 1.0, QueryTriggerInteraction hitTriggers = QueryTriggerInteraction.UseGlobal)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x26FDE2C", Offset = "0x26FDE2C", VA = "0x26FDE2C")]
		public bool RaycastAll(out RaycastHit[] hits, out double[] hitPercents, LayerMask layerMask, double resolution = 1.0, double from = 0.0, double to = 1.0, QueryTriggerInteraction hitTriggers = QueryTriggerInteraction.UseGlobal)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x26FE254", Offset = "0x26FE254", VA = "0x26FE254")]
		public double GetPointPercent(int pointIndex)
		{
			return default(double);
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x26FD840", Offset = "0x26FD840", VA = "0x26FD840")]
		public Vector3 EvaluatePosition(double percent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x26FE33C", Offset = "0x26FE33C", VA = "0x26FE33C")]
		public SplineSample Evaluate(double percent)
		{
			return null;
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x26FE978", Offset = "0x26FE978", VA = "0x26FE978")]
		public SplineSample Evaluate(int pointIndex)
		{
			return null;
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x26FE9F8", Offset = "0x26FE9F8", VA = "0x26FE9F8")]
		public void Evaluate(SplineSample result, int pointIndex)
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x26FE3B4", Offset = "0x26FE3B4", VA = "0x26FE3B4")]
		public void Evaluate(SplineSample result, double percent)
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x26FEAE0", Offset = "0x26FEAE0", VA = "0x26FEAE0")]
		public void Evaluate(ref SplineSample[] samples, double from = 0.0, double to = 1.0)
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x26FECFC", Offset = "0x26FECFC", VA = "0x26FECFC")]
		public void EvaluateUniform(ref SplineSample[] samples, ref double[] originalSamplePercents, double from = 0.0, double to = 1.0)
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x26FF304", Offset = "0x26FF304", VA = "0x26FF304")]
		public void EvaluatePositions(ref Vector3[] positions, double from = 0.0, double to = 1.0)
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x26FF11C", Offset = "0x26FF11C", VA = "0x26FF11C")]
		public double Travel(double start, float distance, out float moved, Direction direction)
		{
			return default(double);
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x26FF4F0", Offset = "0x26FF4F0", VA = "0x26FF4F0")]
		public double Travel(double start, float distance, Direction direction = Direction.Forward)
		{
			return default(double);
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x26FE284", Offset = "0x26FE284", VA = "0x26FE284")]
		public void EvaluatePosition(ref Vector3 point, double percent)
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x26FEA28", Offset = "0x26FEA28", VA = "0x26FEA28")]
		public void EvaluateTangent(ref Vector3 tangent, double percent)
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x26FDA48", Offset = "0x26FDA48", VA = "0x26FDA48")]
		private double GetClosestPoint(int iterations, Vector3 point, double start, double end, int slices)
		{
			return default(double);
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x26FF6C0", Offset = "0x26FF6C0", VA = "0x26FF6C0")]
		public void Break()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x26FF6C8", Offset = "0x26FF6C8", VA = "0x26FF6C8")]
		public void Break(int at)
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x26F3C4C", Offset = "0x26F3C4C", VA = "0x26F3C4C")]
		public void Close()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x26F3884", Offset = "0x26F3884", VA = "0x26F3884")]
		public void CatToBezierTangents()
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x26FF518", Offset = "0x26FF518", VA = "0x26FF518")]
		private void GetPoint(ref Vector3 point, double percent, int pointIndex)
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x26FF698", Offset = "0x26FF698", VA = "0x26FF698")]
		private void GetTangent(ref Vector3 tangent, double percent, int pointIndex)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x27003EC", Offset = "0x27003EC", VA = "0x27003EC")]
		private void LinearGetPoint(ref Vector3 point, double t, int i)
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x270088C", Offset = "0x270088C", VA = "0x270088C")]
		private void LinearGetTangent(ref Vector3 tangent, double t, int i)
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x27001EC", Offset = "0x27001EC", VA = "0x27001EC")]
		private void BSPGetPoint(ref Vector3 point, double time, int i)
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x2700074", Offset = "0x2700074", VA = "0x2700074")]
		private void BezierGetPoint(ref Vector3 point, double t, int i)
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x27006EC", Offset = "0x27006EC", VA = "0x27006EC")]
		private void BezierGetTangent(ref Vector3 tangent, double t, int i)
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x26FFE80", Offset = "0x26FFE80", VA = "0x26FFE80")]
		private void CatmullRomGetPoint(ref Vector3 point, double t, int i)
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x2700528", Offset = "0x2700528", VA = "0x2700528")]
		private void GetCatmullRomTangent(ref Vector3 direction, double t, int i)
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x26FF918", Offset = "0x26FF918", VA = "0x26FF918")]
		private void GetCatPoints(int i)
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x26F9B98", Offset = "0x26F9B98", VA = "0x26F9B98")]
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
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBB5590", Offset = "0xBB5590")]
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
			[Address(RVA = "0x2903074", Offset = "0x2903074", VA = "0x2903074")]
			get
			{
				return default(Type);
			}
			[Token(Token = "0x60007CE")]
			[Address(RVA = "0x2902914", Offset = "0x2902914", VA = "0x2902914")]
			set
			{
			}
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x29030A8", Offset = "0x29030A8", VA = "0x29030A8")]
		public static SplinePoint Lerp(SplinePoint a, SplinePoint b, float t)
		{
			return default(SplinePoint);
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x2903264", Offset = "0x2903264", VA = "0x2903264")]
		private static void GetInterpolatedTangents(SplinePoint a, SplinePoint b, float t, out Vector3 t1, out Vector3 t2)
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x2903318", Offset = "0x2903318", VA = "0x2903318")]
		public static bool AreDifferent(ref SplinePoint a, ref SplinePoint b)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x29033EC", Offset = "0x29033EC", VA = "0x29033EC")]
		public void SetPosition(Vector3 pos)
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x2903434", Offset = "0x2903434", VA = "0x2903434")]
		public void SetTangentPosition(Vector3 pos)
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x2903530", Offset = "0x2903530", VA = "0x2903530")]
		public void SetTangent2Position(Vector3 pos)
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x2903658", Offset = "0x2903658", VA = "0x2903658")]
		public SplinePoint(Vector3 p)
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x29036DC", Offset = "0x29036DC", VA = "0x29036DC")]
		public SplinePoint(Vector3 p, Vector3 t)
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x2903778", Offset = "0x2903778", VA = "0x2903778")]
		public SplinePoint(Vector3 pos, Vector3 tan, Vector3 nor, float s, Color col)
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x29037C8", Offset = "0x29037C8", VA = "0x29037C8")]
		public SplinePoint(Vector3 pos, Vector3 tan, Vector3 tan2, Vector3 nor, float s, Color col)
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x2903810", Offset = "0x2903810", VA = "0x2903810")]
		public SplinePoint(SplinePoint source)
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x290307C", Offset = "0x290307C", VA = "0x290307C")]
		private void SmoothMirrorTangent2()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x2903574", Offset = "0x2903574", VA = "0x2903574")]
		private void SmoothMirrorTangent()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x2903478", Offset = "0x2903478", VA = "0x2903478")]
		private void SmoothFreeTangent2()
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x29035A0", Offset = "0x29035A0", VA = "0x29035A0")]
		private void SmoothFreeTangent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000073")]
	public class SplineSample
	{
		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 position;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 up;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 forward;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Color color;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float size;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public double percent;

		[Token(Token = "0x17000305")]
		public Quaternion rotation
		{
			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x2900DE0", Offset = "0x2900DE0", VA = "0x2900DE0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000306")]
		public Vector3 right
		{
			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x2900D08", Offset = "0x2900D08", VA = "0x2900D08")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x2905E68", Offset = "0x2905E68", VA = "0x2905E68")]
		public static SplineSample Lerp(SplineSample a, SplineSample b, float t)
		{
			return null;
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x2906000", Offset = "0x2906000", VA = "0x2906000")]
		public static SplineSample Lerp(SplineSample a, SplineSample b, double t)
		{
			return null;
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x2906084", Offset = "0x2906084", VA = "0x2906084")]
		public static void Lerp(SplineSample a, SplineSample b, double t, SplineSample target)
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x2905EEC", Offset = "0x2905EEC", VA = "0x2905EEC")]
		public static void Lerp(SplineSample a, SplineSample b, float t, SplineSample target)
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x2906198", Offset = "0x2906198", VA = "0x2906198")]
		public void Lerp(SplineSample b, double t)
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x29061A0", Offset = "0x29061A0", VA = "0x29061A0")]
		public void Lerp(SplineSample b, float t)
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x28FCCC4", Offset = "0x28FCCC4", VA = "0x28FCCC4")]
		public void CopyFrom(SplineSample input)
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x2901060", Offset = "0x2901060", VA = "0x2901060")]
		public SplineSample()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x29061A8", Offset = "0x29061A8", VA = "0x29061A8")]
		public SplineSample(Vector3 position, Vector3 normal, Vector3 direction, Color color, float size, double percent)
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x2906298", Offset = "0x2906298", VA = "0x2906298")]
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
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				internal bool computing;

				[Token(Token = "0x4000744")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				internal Queue<EmptyHandler> instructions;

				[Token(Token = "0x6000A4F")]
				[Address(RVA = "0x26AE43C", Offset = "0x26AE43C", VA = "0x26AE43C")]
				public Worker()
				{
				}
			}

			[Token(Token = "0x2000118")]
			internal delegate void BoolHandler(bool flag);

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private ParameterizedThreadStart start;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Thread thread;

			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Worker worker;

			[Token(Token = "0x17000363")]
			internal bool isAlive
			{
				[Token(Token = "0x600099F")]
				[Address(RVA = "0x26AE34C", Offset = "0x26AE34C", VA = "0x26AE34C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000364")]
			internal bool computing
			{
				[Token(Token = "0x60009A0")]
				[Address(RVA = "0x26AE360", Offset = "0x26AE360", VA = "0x26AE360")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60009A1")]
			[Address(RVA = "0x26AE37C", Offset = "0x26AE37C", VA = "0x26AE37C")]
			internal ThreadDef()
			{
			}

			[Token(Token = "0x60009A2")]
			[Address(RVA = "0x26AE4C0", Offset = "0x26AE4C0", VA = "0x26AE4C0")]
			internal void Queue(EmptyHandler handler)
			{
			}

			[Token(Token = "0x60009A3")]
			[Address(RVA = "0x26AE52C", Offset = "0x26AE52C", VA = "0x26AE52C")]
			internal void Interrupt()
			{
			}

			[Token(Token = "0x60009A4")]
			[Address(RVA = "0x26AE548", Offset = "0x26AE548", VA = "0x26AE548")]
			internal void Restart()
			{
			}

			[Token(Token = "0x60009A5")]
			[Address(RVA = "0x26AE620", Offset = "0x26AE620", VA = "0x26AE620")]
			internal void Abort()
			{
			}
		}

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static ThreadDef[] threads;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly object locker;

		[Token(Token = "0x17000307")]
		public static int threadCount
		{
			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x29064C4", Offset = "0x29064C4", VA = "0x29064C4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x2906534", Offset = "0x2906534", VA = "0x2906534")]
			set
			{
			}
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x2906670", Offset = "0x2906670", VA = "0x2906670")]
		static SplineThreading()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x29067EC", Offset = "0x29067EC", VA = "0x29067EC")]
		private static void Quitting()
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x2906918", Offset = "0x2906918", VA = "0x2906918")]
		private static void RunThread(object o)
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x2906D28", Offset = "0x2906D28", VA = "0x2906D28")]
		public static void Run(EmptyHandler handler)
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x2906FC0", Offset = "0x2906FC0", VA = "0x2906FC0")]
		public static void PrewarmThreads()
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x2906844", Offset = "0x2906844", VA = "0x2906844")]
		public static void Stop()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000075")]
	public class TriggerGroup
	{
		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool enabled;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SplineTrigger[] triggers;

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x1FA5A50", Offset = "0x1FA5A50", VA = "0x1FA5A50")]
		public void Check(double start, double end, [Optional] SplineUser user)
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x1FA5B0C", Offset = "0x1FA5B0C", VA = "0x1FA5B0C")]
		public void Reset()
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x1FA5B78", Offset = "0x1FA5B78", VA = "0x1FA5B78")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public Type type;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool workOnce;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		private bool worked;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBB55FC", Offset = "0xBB55FC")]
		public double position;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		public bool enabled;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		public Color color;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public UnityEvent onCross;

		[Token(Token = "0x1400000C")]
		public event Action<SplineUser> onUserCross
		{
			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x2907A64", Offset = "0x2907A64", VA = "0x2907A64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6D90", Offset = "0xBB6D90")]
			add
			{
			}
			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x2907B04", Offset = "0x2907B04", VA = "0x2907B04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB6DA0", Offset = "0xBB6DA0")]
			remove
			{
			}
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x2907BA4", Offset = "0x2907BA4", VA = "0x2907BA4")]
		public SplineTrigger(Type t)
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x2907C9C", Offset = "0x2907C9C", VA = "0x2907C9C")]
		public void AddListener(UnityAction action)
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x2907CB8", Offset = "0x2907CB8", VA = "0x2907CB8")]
		public void Reset()
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x29075E4", Offset = "0x29075E4", VA = "0x29075E4")]
		public bool Check(double previousPercent, double currentPercent)
		{
			return default(bool);
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x29077C8", Offset = "0x29077C8", VA = "0x29077C8")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBB567C", Offset = "0xBB567C")]
		private Vector2 _offset;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBB56D8", Offset = "0xBB56D8")]
		private Vector3 _rotationOffset;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBB5734", Offset = "0xBB5734")]
		private Vector3 _baseScale;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public VelocityHandleMode velocityHandleMode;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SplineSample _splineResult;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool applyPositionX;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool applyPositionY;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		public bool applyPositionZ;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Spline.Direction direction;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool applyRotationX;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool applyRotationY;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		public bool applyRotationZ;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
		public bool applyScaleX;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool applyScaleY;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool applyScaleZ;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
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
			[Address(RVA = "0x1FA4548", Offset = "0x1FA4548", VA = "0x1FA4548")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x1FA4550", Offset = "0x1FA4550", VA = "0x1FA4550")]
			set
			{
			}
		}

		[Token(Token = "0x17000309")]
		public Vector3 rotationOffset
		{
			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x1FA4624", Offset = "0x1FA4624", VA = "0x1FA4624")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x1FA4630", Offset = "0x1FA4630", VA = "0x1FA4630")]
			set
			{
			}
		}

		[Token(Token = "0x1700030A")]
		public Vector3 baseScale
		{
			[Token(Token = "0x6000800")]
			[Address(RVA = "0x1FA4710", Offset = "0x1FA4710", VA = "0x1FA4710")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000801")]
			[Address(RVA = "0x1FA471C", Offset = "0x1FA471C", VA = "0x1FA471C")]
			set
			{
			}
		}

		[Token(Token = "0x1700030B")]
		public SplineSample splineResult
		{
			[Token(Token = "0x6000802")]
			[Address(RVA = "0x1FA47FC", Offset = "0x1FA47FC", VA = "0x1FA47FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000803")]
			[Address(RVA = "0x1FA4870", Offset = "0x1FA4870", VA = "0x1FA4870")]
			set
			{
			}
		}

		[Token(Token = "0x1700030C")]
		public bool applyPosition
		{
			[Token(Token = "0x6000804")]
			[Address(RVA = "0x1FA4904", Offset = "0x1FA4904", VA = "0x1FA4904")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000805")]
			[Address(RVA = "0x1FA492C", Offset = "0x1FA492C", VA = "0x1FA492C")]
			set
			{
			}
		}

		[Token(Token = "0x1700030D")]
		public bool applyRotation
		{
			[Token(Token = "0x6000806")]
			[Address(RVA = "0x1FA4940", Offset = "0x1FA4940", VA = "0x1FA4940")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000807")]
			[Address(RVA = "0x1FA4968", Offset = "0x1FA4968", VA = "0x1FA4968")]
			set
			{
			}
		}

		[Token(Token = "0x1700030E")]
		public bool applyScale
		{
			[Token(Token = "0x6000808")]
			[Address(RVA = "0x1FA497C", Offset = "0x1FA497C", VA = "0x1FA497C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000809")]
			[Address(RVA = "0x1FA49A4", Offset = "0x1FA49A4", VA = "0x1FA49A4")]
			set
			{
			}
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x1FA49B8", Offset = "0x1FA49B8", VA = "0x1FA49B8")]
		public void ApplyTransform(Transform input)
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x1FA4F34", Offset = "0x1FA4F34", VA = "0x1FA4F34")]
		public void ApplyRigidbody(Rigidbody input)
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x1FA5200", Offset = "0x1FA5200", VA = "0x1FA5200")]
		public void ApplyRigidbody2D(Rigidbody2D input)
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x1FA5058", Offset = "0x1FA5058", VA = "0x1FA5058")]
		private Vector3 HandleVelocity(Vector3 velocity)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x1FA4A3C", Offset = "0x1FA4A3C", VA = "0x1FA4A3C")]
		private Vector3 GetPosition(Vector3 inputPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x1FA4C5C", Offset = "0x1FA4C5C", VA = "0x1FA4C5C")]
		private Quaternion GetRotation(Quaternion inputRotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x1FA4ECC", Offset = "0x1FA4ECC", VA = "0x1FA4ECC")]
		private Vector3 GetScale(Vector3 inputScale)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x1FA5328", Offset = "0x1FA5328", VA = "0x1FA5328")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float radius;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float height;

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x19BE628", Offset = "0x19BE628", VA = "0x19BE628", Slot = "6")]
		public override Spline.Type GetSplineType()
		{
			return default(Spline.Type);
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x19BE630", Offset = "0x19BE630", VA = "0x19BE630", Slot = "5")]
		protected override void Generate()
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x19BECD8", Offset = "0x19BECD8", VA = "0x19BECD8")]
		public Capsule()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class Ellipse : SplinePrimitive
	{
		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float xRadius;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float yRadius;

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x19C403C", Offset = "0x19C403C", VA = "0x19C403C", Slot = "6")]
		public override Spline.Type GetSplineType()
		{
			return default(Spline.Type);
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x19C4044", Offset = "0x19C4044", VA = "0x19C4044", Slot = "5")]
		protected override void Generate()
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x19C43B0", Offset = "0x19C43B0", VA = "0x19C43B0")]
		public Ellipse()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class Line : SplinePrimitive
	{
		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool mirror;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float length;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int segments;

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x19C9A14", Offset = "0x19C9A14", VA = "0x19C9A14", Slot = "6")]
		public override Spline.Type GetSplineType()
		{
			return default(Spline.Type);
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x19C9A1C", Offset = "0x19C9A1C", VA = "0x19C9A1C", Slot = "5")]
		protected override void Generate()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x19C9B5C", Offset = "0x19C9B5C", VA = "0x19C9B5C")]
		public Line()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class Ngon : SplinePrimitive
	{
		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float radius;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int sides;

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x21001FC", Offset = "0x21001FC", VA = "0x21001FC", Slot = "6")]
		public override Spline.Type GetSplineType()
		{
			return default(Spline.Type);
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x2100204", Offset = "0x2100204", VA = "0x2100204", Slot = "5")]
		protected override void Generate()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x210037C", Offset = "0x210037C", VA = "0x210037C")]
		public Ngon()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class Rectangle : SplinePrimitive
	{
		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector2 size;

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x210B9AC", Offset = "0x210B9AC", VA = "0x210B9AC", Slot = "6")]
		public override Spline.Type GetSplineType()
		{
			return default(Spline.Type);
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x210B9B4", Offset = "0x210B9B4", VA = "0x210B9B4", Slot = "5")]
		protected override void Generate()
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x210BC70", Offset = "0x210BC70", VA = "0x210BC70")]
		public Rectangle()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class RoundedRectangle : SplinePrimitive
	{
		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector2 size;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float xRadius;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yRadius;

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x26F2270", Offset = "0x26F2270", VA = "0x26F2270", Slot = "6")]
		public override Spline.Type GetSplineType()
		{
			return default(Spline.Type);
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x26F2278", Offset = "0x26F2278", VA = "0x26F2278", Slot = "5")]
		protected override void Generate()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x26F29E4", Offset = "0x26F29E4", VA = "0x26F29E4")]
		public RoundedRectangle()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class Spiral : SplinePrimitive
	{
		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float startRadius;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float endRadius;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float stretch;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int iterations;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool clockwise;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve curve;

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x26FD070", Offset = "0x26FD070", VA = "0x26FD070", Slot = "6")]
		public override Spline.Type GetSplineType()
		{
			return default(Spline.Type);
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x26FD078", Offset = "0x26FD078", VA = "0x26FD078", Slot = "5")]
		protected override void Generate()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x26FD4E8", Offset = "0x26FD4E8", VA = "0x26FD4E8")]
		public Spiral()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class SplinePrimitive
	{
		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected bool closed;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected SplinePoint[] points;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 rotation;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool is2D;

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x2903D94", Offset = "0x2903D94", VA = "0x2903D94", Slot = "4")]
		public virtual void Calculate()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x290407C", Offset = "0x290407C", VA = "0x290407C", Slot = "5")]
		protected virtual void Generate()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x2904080", Offset = "0x2904080", VA = "0x2904080")]
		public Spline CreateSpline()
		{
			return null;
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x2904144", Offset = "0x2904144", VA = "0x2904144")]
		public void UpdateSpline(Spline spline)
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x29041E8", Offset = "0x29041E8", VA = "0x29041E8")]
		public SplineComputer CreateSplineComputer(string name, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x2904348", Offset = "0x2904348", VA = "0x2904348")]
		public void UpdateSplineComputer(SplineComputer comp)
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x29043FC", Offset = "0x29043FC", VA = "0x29043FC")]
		public SplinePoint[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x2904404", Offset = "0x2904404", VA = "0x2904404", Slot = "6")]
		public virtual Spline.Type GetSplineType()
		{
			return default(Spline.Type);
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x290440C", Offset = "0x290440C", VA = "0x290440C")]
		public bool GetIsClosed()
		{
			return default(bool);
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x2903DC0", Offset = "0x2903DC0", VA = "0x2903DC0")]
		private void ApplyOffset()
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x2904414", Offset = "0x2904414", VA = "0x2904414")]
		protected void CreatePoints(int count, SplinePoint.Type type)
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x2904588", Offset = "0x2904588", VA = "0x2904588")]
		public SplinePrimitive()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class Star : SplinePrimitive
	{
		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float radius;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float depth;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int sides;

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x2908BA0", Offset = "0x2908BA0", VA = "0x2908BA0", Slot = "6")]
		public override Spline.Type GetSplineType()
		{
			return default(Spline.Type);
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x2908BA8", Offset = "0x2908BA8", VA = "0x2908BA8", Slot = "5")]
		protected override void Generate()
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x2908D54", Offset = "0x2908D54", VA = "0x2908D54")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<ColumnType> columns;

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x19BC3D8", Offset = "0x19BC3D8", VA = "0x19BC3D8")]
		public CSV(SplineComputer computer)
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x19BC5F0", Offset = "0x19BC5F0", VA = "0x19BC5F0")]
		public CSV(string filePath, [Optional] List<ColumnType> customColumns)
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x19BC8D0", Offset = "0x19BC8D0", VA = "0x19BC8D0")]
		private void Read(string[] lines)
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x19BD438", Offset = "0x19BD438", VA = "0x19BD438")]
		public SplineComputer CreateSplineComputer(Vector3 position, Quaternion rotation)
		{
			return null;
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x19BD454", Offset = "0x19BD454", VA = "0x19BD454")]
		public Spline CreateSpline()
		{
			return null;
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x19BD470", Offset = "0x19BD470", VA = "0x19BD470")]
		public void FlatX()
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x19BD5DC", Offset = "0x19BD5DC", VA = "0x19BD5DC")]
		public void FlatY()
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x19BD74C", Offset = "0x19BD74C", VA = "0x19BD74C")]
		public void FlatZ()
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x19BD8F4", Offset = "0x19BD8F4", VA = "0x19BD8F4")]
		private void AddTitle(ref string[] content, string title)
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x19BD9D0", Offset = "0x19BD9D0", VA = "0x19BD9D0")]
		private void AddVector3Title(ref string[] content, string prefix)
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x19BDBEC", Offset = "0x19BDBEC", VA = "0x19BDBEC")]
		private void AddColorTitle(ref string[] content, string prefix)
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x19BDE8C", Offset = "0x19BDE8C", VA = "0x19BDE8C")]
		private void AddVector3(ref string[] content, int index, Vector3 vector)
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x19BDFF4", Offset = "0x19BDFF4", VA = "0x19BDFF4")]
		private void AddColor(ref string[] content, int index, Color color)
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x19BDEDC", Offset = "0x19BDEDC", VA = "0x19BDEDC")]
		private void AddFloat(ref string[] content, int index, float value)
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x19BE060", Offset = "0x19BE060", VA = "0x19BE060")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Vector3 startTangent;

			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal Vector3 endTangent;

			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Vector3 endPoint;

			[Token(Token = "0x60009A6")]
			[Address(RVA = "0x26A8670", Offset = "0x26A8670", VA = "0x26A8670")]
			internal PathSegment(Vector2 s, Vector2 e, Vector2 c)
			{
			}

			[Token(Token = "0x60009A7")]
			[Address(RVA = "0x26A8710", Offset = "0x26A8710", VA = "0x26A8710")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB19BC", Offset = "0xBB19BC")]
		private sealed class <>c
		{
			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, bool> <>9__23_0;

			[Token(Token = "0x60009A9")]
			[Address(RVA = "0x26A8644", Offset = "0x26A8644", VA = "0x26A8644")]
			public <>c()
			{
			}

			[Token(Token = "0x60009AA")]
			[Address(RVA = "0x26A864C", Offset = "0x26A864C", VA = "0x26A864C")]
			internal bool <ReadPath>b__23_0(string t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<SplineDefinition> paths;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<SplineDefinition> polygons;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<SplineDefinition> ellipses;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<SplineDefinition> rectangles;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<SplineDefinition> lines;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Transformation> transformBuffer;

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x26F2D44", Offset = "0x26F2D44", VA = "0x26F2D44")]
		public SVG(string filePath)
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x26F31A0", Offset = "0x26F31A0", VA = "0x26F31A0")]
		public SVG(List<SplineComputer> computers)
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x26F3CF0", Offset = "0x26F3CF0", VA = "0x26F3CF0")]
		public void Write(string filePath, Axis ax = Axis.Z)
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x26F4B50", Offset = "0x26F4B50", VA = "0x26F4B50")]
		private Vector2 MapPoint(Vector3 original, Axis ax)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x26F3120", Offset = "0x26F3120", VA = "0x26F3120")]
		private void Read(XmlDocument doc)
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x26F4B80", Offset = "0x26F4B80", VA = "0x26F4B80")]
		private void Traverse(XmlNodeList nodes)
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x26F67F4", Offset = "0x26F67F4", VA = "0x26F67F4")]
		public List<SplineComputer> CreateSplineComputers(Vector3 position, Quaternion rotation, Element elements = Element.All)
		{
			return null;
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x26F6F0C", Offset = "0x26F6F0C", VA = "0x26F6F0C")]
		public List<Spline> CreateSplines(Element elements = Element.All)
		{
			return null;
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x26F6374", Offset = "0x26F6374", VA = "0x26F6374")]
		private int ReadRectangle(XmlNode rectNode)
		{
			return default(int);
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x26F6090", Offset = "0x26F6090", VA = "0x26F6090")]
		private int ReadLine(XmlNode lineNode)
		{
			return default(int);
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x26F5D24", Offset = "0x26F5D24", VA = "0x26F5D24")]
		private int ReadEllipse(XmlNode ellipseNode)
		{
			return default(int);
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x26F5A0C", Offset = "0x26F5A0C", VA = "0x26F5A0C")]
		private int ReadPolygon(XmlNode polyNode, bool closed)
		{
			return default(int);
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x26F517C", Offset = "0x26F517C", VA = "0x26F517C")]
		private int ParseTransformation(XmlNode node)
		{
			return default(int);
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x26F771C", Offset = "0x26F771C", VA = "0x26F771C")]
		private List<Transformation> ParseTransformations(string transformContent)
		{
			return null;
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x26F5258", Offset = "0x26F5258", VA = "0x26F5258")]
		private int ReadPath(XmlNode pathNode)
		{
			return default(int);
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x26F8268", Offset = "0x26F8268", VA = "0x26F8268")]
		private void PathStart(string name, string coords, bool relative)
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x26F83B4", Offset = "0x26F83B4", VA = "0x26F83B4")]
		private void PathClose()
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x26F83D4", Offset = "0x26F83D4", VA = "0x26F83D4")]
		private void PathLineTo(string coords, bool relative)
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x26F84A4", Offset = "0x26F84A4", VA = "0x26F84A4")]
		private void PathHorizontalLineTo(string coords, bool relative)
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x26F8550", Offset = "0x26F8550", VA = "0x26F8550")]
		private void PathVerticalLineTo(string coords, bool relative)
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x26F8604", Offset = "0x26F8604", VA = "0x26F8604")]
		private void PathCurveTo(string coords, PathSegment.Type type, bool relative)
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x26F7690", Offset = "0x26F7690", VA = "0x26F7690")]
		private void WriteBufferTo(List<SplineDefinition> list)
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x26F88AC", Offset = "0x26F88AC", VA = "0x26F88AC")]
		private PathSegment[] ParsePathSegment(string coord, PathSegment.Type type)
		{
			return null;
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x26F4530", Offset = "0x26F4530", VA = "0x26F4530")]
		private string EncodePath(SplineDefinition definition, Axis ax)
		{
			return null;
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x26F4388", Offset = "0x26F4388", VA = "0x26F4388")]
		private string EncodePolygon(SplineDefinition definition, Axis ax)
		{
			return null;
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x26F755C", Offset = "0x26F755C", VA = "0x26F755C")]
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
			[Address(RVA = "0x26AD7CC", Offset = "0x26AD7CC", VA = "0x26AD7CC")]
			internal static void ResetMatrix()
			{
			}

			[Token(Token = "0x60009AC")]
			[Address(RVA = "0x26ADA60", Offset = "0x26ADA60", VA = "0x26ADA60", Slot = "4")]
			internal virtual void Push()
			{
			}

			[Token(Token = "0x60009AD")]
			[Address(RVA = "0x26AD8B4", Offset = "0x26AD8B4", VA = "0x26AD8B4")]
			internal static void Apply(SplinePoint[] points)
			{
			}

			[Token(Token = "0x60009AE")]
			[Address(RVA = "0x26AC11C", Offset = "0x26AC11C", VA = "0x26AC11C")]
			public Transformation()
			{
			}
		}

		[Token(Token = "0x20000E8")]
		internal class Translate : Transformation
		{
			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Vector2 offset;

			[Token(Token = "0x60009B0")]
			[Address(RVA = "0x26ADA68", Offset = "0x26ADA68", VA = "0x26ADA68")]
			public Translate(Vector2 o)
			{
			}

			[Token(Token = "0x60009B1")]
			[Address(RVA = "0x26ADAF0", Offset = "0x26ADAF0", VA = "0x26ADAF0", Slot = "4")]
			internal override void Push()
			{
			}
		}

		[Token(Token = "0x20000E9")]
		internal class Rotate : Transformation
		{
			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private float angle;

			[Token(Token = "0x60009B2")]
			[Address(RVA = "0x26AC204", Offset = "0x26AC204", VA = "0x26AC204")]
			public Rotate(float a)
			{
			}

			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x26AC27C", Offset = "0x26AC27C", VA = "0x26AC27C", Slot = "4")]
			internal override void Push()
			{
			}
		}

		[Token(Token = "0x20000EA")]
		internal class Scale : Transformation
		{
			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Vector2 multiplier;

			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x26AC414", Offset = "0x26AC414", VA = "0x26AC414")]
			public Scale(Vector2 s)
			{
			}

			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x26AC49C", Offset = "0x26AC49C", VA = "0x26AC49C", Slot = "4")]
			internal override void Push()
			{
			}
		}

		[Token(Token = "0x20000EB")]
		internal class SkewX : Transformation
		{
			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private float amount;

			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x26AC5F8", Offset = "0x26AC5F8", VA = "0x26AC5F8")]
			public SkewX(float a)
			{
			}

			[Token(Token = "0x60009B7")]
			[Address(RVA = "0x26AC670", Offset = "0x26AC670", VA = "0x26AC670", Slot = "4")]
			internal override void Push()
			{
			}
		}

		[Token(Token = "0x20000EC")]
		internal class SkewY : Transformation
		{
			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private float amount;

			[Token(Token = "0x60009B8")]
			[Address(RVA = "0x26AC7F0", Offset = "0x26AC7F0", VA = "0x26AC7F0")]
			public SkewY(float a)
			{
			}

			[Token(Token = "0x60009B9")]
			[Address(RVA = "0x26AC868", Offset = "0x26AC868", VA = "0x26AC868", Slot = "4")]
			internal override void Push()
			{
			}
		}

		[Token(Token = "0x20000ED")]
		internal class MatrixTransform : Transformation
		{
			[Token(Token = "0x400069D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Matrix4x4 transformMatrix;

			[Token(Token = "0x60009BA")]
			[Address(RVA = "0x26ABF94", Offset = "0x26ABF94", VA = "0x26ABF94")]
			public MatrixTransform(float a, float b, float c, float d, float e, float f)
			{
			}

			[Token(Token = "0x60009BB")]
			[Address(RVA = "0x26AC124", Offset = "0x26AC124", VA = "0x26AC124", Slot = "4")]
			internal override void Push()
			{
			}
		}

		[Token(Token = "0x20000EE")]
		internal class SplineDefinition
		{
			[Token(Token = "0x400069E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal string name;

			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Spline.Type type;

			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal List<SplinePoint> points;

			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal bool closed;

			[Token(Token = "0x40006A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal Vector3 position;

			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal Vector3 tangent;

			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			internal Vector3 tangent2;

			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal Vector3 normal;

			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			internal float size;

			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal Color color;

			[Token(Token = "0x17000365")]
			internal int pointCount
			{
				[Token(Token = "0x60009BC")]
				[Address(RVA = "0x26AC9E8", Offset = "0x26AC9E8", VA = "0x26AC9E8")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x60009BD")]
			[Address(RVA = "0x26ACA34", Offset = "0x26ACA34", VA = "0x26ACA34")]
			internal SplineDefinition(string n, Spline.Type t)
			{
			}

			[Token(Token = "0x60009BE")]
			[Address(RVA = "0x26ACB70", Offset = "0x26ACB70", VA = "0x26ACB70")]
			internal SplineDefinition(string n, Spline spline)
			{
			}

			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x26ACD14", Offset = "0x26ACD14", VA = "0x26ACD14")]
			internal SplinePoint GetLastPoint()
			{
				return default(SplinePoint);
			}

			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x26ACDB0", Offset = "0x26ACDB0", VA = "0x26ACDB0")]
			internal void SetLastPoint(SplinePoint point)
			{
			}

			[Token(Token = "0x60009C1")]
			[Address(RVA = "0x26ACE64", Offset = "0x26ACE64", VA = "0x26ACE64")]
			internal void CreateClosingPoint()
			{
			}

			[Token(Token = "0x60009C2")]
			[Address(RVA = "0x26ACF50", Offset = "0x26ACF50", VA = "0x26ACF50")]
			internal void CreateSmooth()
			{
			}

			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x26AD070", Offset = "0x26AD070", VA = "0x26AD070")]
			internal void CreateBroken()
			{
			}

			[Token(Token = "0x60009C4")]
			[Address(RVA = "0x26AD20C", Offset = "0x26AD20C", VA = "0x26AD20C")]
			internal void CreateLinear()
			{
			}

			[Token(Token = "0x60009C5")]
			[Address(RVA = "0x26AD220", Offset = "0x26AD220", VA = "0x26AD220")]
			internal SplineComputer CreateSplineComputer(Vector3 position, Quaternion rotation)
			{
				return null;
			}

			[Token(Token = "0x60009C6")]
			[Address(RVA = "0x26AD44C", Offset = "0x26AD44C", VA = "0x26AD44C")]
			internal Spline CreateSpline()
			{
				return null;
			}

			[Token(Token = "0x60009C7")]
			[Address(RVA = "0x26AD508", Offset = "0x26AD508", VA = "0x26AD508")]
			internal void Transform(List<Transformation> trs)
			{
			}
		}

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected string fileName;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal SplineDefinition buffer;

		[Token(Token = "0x1700030F")]
		public string name
		{
			[Token(Token = "0x6000860")]
			[Address(RVA = "0x29029F8", Offset = "0x29029F8", VA = "0x29029F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x2902A00", Offset = "0x2902A00", VA = "0x2902A00")]
		internal Vector2[] ParseVector2(string coord)
		{
			return null;
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x2902E34", Offset = "0x2902E34", VA = "0x2902E34")]
		internal float[] ParseFloat(string coord)
		{
			return null;
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x2902BF8", Offset = "0x2902BF8", VA = "0x2902BF8")]
		internal List<float> ParseFloatArray(string content)
		{
			return null;
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x2902F58", Offset = "0x2902F58", VA = "0x2902F58")]
		public bool IsWHiteSpace(string s)
		{
			return default(bool);
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x2903018", Offset = "0x2903018", VA = "0x2903018")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB19CC", Offset = "0xBB19CC")]
		private sealed class <RunAsyncFromCoroutineTest>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x17000366")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009CB")]
				[Address(RVA = "0x1FB50AC", Offset = "0x1FB50AC", VA = "0x1FB50AC", Slot = "4")]
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
				[Address(RVA = "0x1FB50F4", Offset = "0x1FB50F4", VA = "0x1FB50F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009C8")]
			[Address(RVA = "0x1FB4EC4", Offset = "0x1FB4EC4", VA = "0x1FB4EC4")]
			[DebuggerHidden]
			public <RunAsyncFromCoroutineTest>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60009C9")]
			[Address(RVA = "0x1FB4EF0", Offset = "0x1FB4EF0", VA = "0x1FB4EF0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009CA")]
			[Address(RVA = "0x1FB4EF4", Offset = "0x1FB4EF4", VA = "0x1FB4EF4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x1FB50B4", Offset = "0x1FB50B4", VA = "0x1FB50B4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB19DC", Offset = "0xBB19DC")]
		private struct <RunMultipleThreadsTestAsync>d__7 : IAsyncStateMachine
		{
			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private object <>u__3;

			[Token(Token = "0x60009CE")]
			[Address(RVA = "0x1FB63BC", Offset = "0x1FB63BC", VA = "0x1FB63BC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009CF")]
			[Address(RVA = "0x1FB6A20", Offset = "0x1FB6A20", VA = "0x1FB6A20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB19EC", Offset = "0xBB19EC")]
		private struct <RunMultipleThreadsTestAsyncWait>d__8 : IAsyncStateMachine
		{
			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x60009D0")]
			[Address(RVA = "0x1FB6A2C", Offset = "0x1FB6A2C", VA = "0x1FB6A2C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009D1")]
			[Address(RVA = "0x1FB6CA0", Offset = "0x1FB6CA0", VA = "0x1FB6CA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB19FC", Offset = "0xBB19FC")]
		private struct <RunAsyncFromCoroutineTest2>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__1;

			[Token(Token = "0x60009D2")]
			[Address(RVA = "0x1FB4CA8", Offset = "0x1FB4CA8", VA = "0x1FB4CA8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009D3")]
			[Address(RVA = "0x1FB4EB8", Offset = "0x1FB4EB8", VA = "0x1FB4EB8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB1A0C", Offset = "0xBB1A0C")]
		private struct <RunWwwAsync>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__1;

			[Token(Token = "0x60009D4")]
			[Address(RVA = "0x1FB7620", Offset = "0x1FB7620", VA = "0x1FB7620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x1FB7974", Offset = "0x1FB7974", VA = "0x1FB7974", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB1A1C", Offset = "0xBB1A1C")]
		private struct <RunOpenNotepadTestAsync>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private TaskAwaiter<int> <>u__1;

			[Token(Token = "0x60009D6")]
			[Address(RVA = "0x1FB6CAC", Offset = "0x1FB6CAC", VA = "0x1FB6CAC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009D7")]
			[Address(RVA = "0x1FB6EFC", Offset = "0x1FB6EFC", VA = "0x1FB6EFC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB1A2C", Offset = "0xBB1A2C")]
		private struct <RunUnhandledExceptionTestAsync>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x60009D8")]
			[Address(RVA = "0x1FB747C", Offset = "0x1FB747C", VA = "0x1FB747C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009D9")]
			[Address(RVA = "0x1FB7614", Offset = "0x1FB7614", VA = "0x1FB7614", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB1A3C", Offset = "0xBB1A3C")]
		private struct <RunTryCatchExceptionTestAsync>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x60009DA")]
			[Address(RVA = "0x1FB7194", Offset = "0x1FB7194", VA = "0x1FB7194", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009DB")]
			[Address(RVA = "0x1FB7470", Offset = "0x1FB7470", VA = "0x1FB7470", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB1A4C", Offset = "0xBB1A4C")]
		private struct <NestedRunAsync>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__1;

			[Token(Token = "0x60009DC")]
			[Address(RVA = "0x1FB4A5C", Offset = "0x1FB4A5C", VA = "0x1FB4A5C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x1FB4C9C", Offset = "0x1FB4C9C", VA = "0x1FB4C9C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB1A5C", Offset = "0xBB1A5C")]
		private struct <WaitThenThrowException>d__16 : IAsyncStateMachine
		{
			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__1;

			[Token(Token = "0x60009DE")]
			[Address(RVA = "0x26A4174", Offset = "0x26A4174", VA = "0x26A4174", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009DF")]
			[Address(RVA = "0x26A43B4", Offset = "0x26A43B4", VA = "0x26A43B4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000F9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB1A6C", Offset = "0xBB1A6C")]
		private struct <RunAsyncOperationAsync>d__17 : IAsyncStateMachine
		{
			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x60009E0")]
			[Address(RVA = "0x1FB50FC", Offset = "0x1FB50FC", VA = "0x1FB50FC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009E1")]
			[Address(RVA = "0x1FB52C4", Offset = "0x1FB52C4", VA = "0x1FB52C4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000FA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB1A7C", Offset = "0xBB1A7C")]
		private struct <InstantiateAssetBundleAsync>d__18 : IAsyncStateMachine
		{
			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string abUrl;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string assetName;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private AssetBundle <assetBundle>5__2;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter<byte[]> <>u__1;

			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private object <>u__2;

			[Token(Token = "0x60009E2")]
			[Address(RVA = "0x1FB445C", Offset = "0x1FB445C", VA = "0x1FB445C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x1FB4A50", Offset = "0x1FB4A50", VA = "0x1FB4A50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000FB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB1A8C", Offset = "0xBB1A8C")]
		private struct <DownloadRawDataAsync>d__19 : IAsyncStateMachine
		{
			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<byte[]> <>t__builder;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string url;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UnityWebRequest <request>5__2;

			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private object <>u__1;

			[Token(Token = "0x60009E4")]
			[Address(RVA = "0x1FB3E9C", Offset = "0x1FB3E9C", VA = "0x1FB3E9C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009E5")]
			[Address(RVA = "0x1FB415C", Offset = "0x1FB415C", VA = "0x1FB415C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB1A9C", Offset = "0xBB1A9C")]
		private struct <RunIEnumeratorTryCatchExceptionAsync>d__20 : IAsyncStateMachine
		{
			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x60009E6")]
			[Address(RVA = "0x1FB5B20", Offset = "0x1FB5B20", VA = "0x1FB5B20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x1FB5E80", Offset = "0x1FB5E80", VA = "0x1FB5E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000FD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB1AAC", Offset = "0xBB1AAC")]
		private struct <RunIEnumeratorUnhandledExceptionAsync>d__21 : IAsyncStateMachine
		{
			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x60009E8")]
			[Address(RVA = "0x1FB5E8C", Offset = "0x1FB5E8C", VA = "0x1FB5E8C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009E9")]
			[Address(RVA = "0x1FB60A8", Offset = "0x1FB60A8", VA = "0x1FB60A8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20000FE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB1ABC", Offset = "0xBB1ABC")]
		private sealed class <WaitThenThrow>d__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x17000368")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009ED")]
				[Address(RVA = "0x26A4124", Offset = "0x26A4124", VA = "0x26A4124", Slot = "4")]
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
				[Address(RVA = "0x26A416C", Offset = "0x26A416C", VA = "0x26A416C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009EA")]
			[Address(RVA = "0x26A4084", Offset = "0x26A4084", VA = "0x26A4084")]
			[DebuggerHidden]
			public <WaitThenThrow>d__22(int <>1__state)
			{
			}

			[Token(Token = "0x60009EB")]
			[Address(RVA = "0x26A40B0", Offset = "0x26A40B0", VA = "0x26A40B0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009EC")]
			[Address(RVA = "0x26A40B4", Offset = "0x26A40B4", VA = "0x26A40B4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x26A412C", Offset = "0x26A412C", VA = "0x26A412C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000FF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB1ACC", Offset = "0xBB1ACC")]
		private sealed class <WaitThenThrowNested>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x1700036A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009F3")]
				[Address(RVA = "0x26A4520", Offset = "0x26A4520", VA = "0x26A4520", Slot = "4")]
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
				[Address(RVA = "0x26A4568", Offset = "0x26A4568", VA = "0x26A4568", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009F0")]
			[Address(RVA = "0x26A43C0", Offset = "0x26A43C0", VA = "0x26A43C0")]
			[DebuggerHidden]
			public <WaitThenThrowNested>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x26A43EC", Offset = "0x26A43EC", VA = "0x26A43EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009F2")]
			[Address(RVA = "0x26A43F0", Offset = "0x26A43F0", VA = "0x26A43F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009F4")]
			[Address(RVA = "0x26A4528", Offset = "0x26A4528", VA = "0x26A4528", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB1ADC", Offset = "0xBB1ADC")]
		private struct <RunIEnumeratorStringTestAsync>d__24 : IAsyncStateMachine
		{
			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x60009F6")]
			[Address(RVA = "0x1FB557C", Offset = "0x1FB557C", VA = "0x1FB557C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009F7")]
			[Address(RVA = "0x1FB5858", Offset = "0x1FB5858", VA = "0x1FB5858", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000101")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB1AEC", Offset = "0xBB1AEC")]
		private struct <RunIEnumeratorUntypedStringTestAsync>d__25 : IAsyncStateMachine
		{
			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x60009F8")]
			[Address(RVA = "0x1FB60B4", Offset = "0x1FB60B4", VA = "0x1FB60B4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009F9")]
			[Address(RVA = "0x1FB63B0", Offset = "0x1FB63B0", VA = "0x1FB63B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000102")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB1AFC", Offset = "0xBB1AFC")]
		private struct <RunIEnumeratorTestAsync>d__26 : IAsyncStateMachine
		{
			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object <>u__1;

			[Token(Token = "0x60009FA")]
			[Address(RVA = "0x1FB5864", Offset = "0x1FB5864", VA = "0x1FB5864", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60009FB")]
			[Address(RVA = "0x1FB5B14", Offset = "0x1FB5B14", VA = "0x1FB5B14", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000103")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB1B0C", Offset = "0xBB1B0C")]
		private sealed class <WaitForString>d__27 : IEnumerator<string>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private string <>2__current;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private float <startTime>5__2;

			[Token(Token = "0x1700036C")]
			private string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[Token(Token = "0x60009FF")]
				[Address(RVA = "0x1FB7BB0", Offset = "0x1FB7BB0", VA = "0x1FB7BB0", Slot = "4")]
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
				[Address(RVA = "0x1FB7BF8", Offset = "0x1FB7BF8", VA = "0x1FB7BF8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009FC")]
			[Address(RVA = "0x1FB7A9C", Offset = "0x1FB7A9C", VA = "0x1FB7A9C")]
			[DebuggerHidden]
			public <WaitForString>d__27(int <>1__state)
			{
			}

			[Token(Token = "0x60009FD")]
			[Address(RVA = "0x1FB7AC8", Offset = "0x1FB7AC8", VA = "0x1FB7AC8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009FE")]
			[Address(RVA = "0x1FB7ACC", Offset = "0x1FB7ACC", VA = "0x1FB7ACC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A00")]
			[Address(RVA = "0x1FB7BB8", Offset = "0x1FB7BB8", VA = "0x1FB7BB8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000104")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB1B1C", Offset = "0xBB1B1C")]
		private sealed class <WaitForStringUntyped>d__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x1700036E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A05")]
				[Address(RVA = "0x1FB7CF4", Offset = "0x1FB7CF4", VA = "0x1FB7CF4", Slot = "4")]
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
				[Address(RVA = "0x1FB7D3C", Offset = "0x1FB7D3C", VA = "0x1FB7D3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A02")]
			[Address(RVA = "0x1FB7C00", Offset = "0x1FB7C00", VA = "0x1FB7C00")]
			[DebuggerHidden]
			public <WaitForStringUntyped>d__28(int <>1__state)
			{
			}

			[Token(Token = "0x6000A03")]
			[Address(RVA = "0x1FB7C2C", Offset = "0x1FB7C2C", VA = "0x1FB7C2C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A04")]
			[Address(RVA = "0x1FB7C30", Offset = "0x1FB7C30", VA = "0x1FB7C30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A06")]
			[Address(RVA = "0x1FB7CFC", Offset = "0x1FB7CFC", VA = "0x1FB7CFC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000105")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB1B2C", Offset = "0xBB1B2C")]
		private sealed class <WaitABit>d__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x17000370")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A0B")]
				[Address(RVA = "0x1FB7A4C", Offset = "0x1FB7A4C", VA = "0x1FB7A4C", Slot = "4")]
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
				[Address(RVA = "0x1FB7A94", Offset = "0x1FB7A94", VA = "0x1FB7A94", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A08")]
			[Address(RVA = "0x1FB7980", Offset = "0x1FB7980", VA = "0x1FB7980")]
			[DebuggerHidden]
			public <WaitABit>d__29(int <>1__state)
			{
			}

			[Token(Token = "0x6000A09")]
			[Address(RVA = "0x1FB79AC", Offset = "0x1FB79AC", VA = "0x1FB79AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0x1FB79B0", Offset = "0x1FB79B0", VA = "0x1FB79B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0x1FB7A54", Offset = "0x1FB7A54", VA = "0x1FB7A54", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000106")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB1B3C", Offset = "0xBB1B3C")]
		private struct <RunReturnValueTestAsync>d__30 : IAsyncStateMachine
		{
			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncUtilTests <>4__this;

			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter<string> <>u__1;

			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0x1FB6F08", Offset = "0x1FB6F08", VA = "0x1FB6F08", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0x1FB7188", Offset = "0x1FB7188", VA = "0x1FB7188", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000107")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB1B4C", Offset = "0xBB1B4C")]
		private struct <GetValueExampleAsync>d__31 : IAsyncStateMachine
		{
			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<string> <>t__builder;

			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__1;

			[Token(Token = "0x6000A10")]
			[Address(RVA = "0x1FB41B8", Offset = "0x1FB41B8", VA = "0x1FB41B8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000A11")]
			[Address(RVA = "0x1FB4400", Offset = "0x1FB4400", VA = "0x1FB4400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBB1B5C", Offset = "0xBB1B5C")]
		private struct <RunAwaitSecondsTestAsync>d__32 : IAsyncStateMachine
		{
			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object <>u__1;

			[Token(Token = "0x6000A12")]
			[Address(RVA = "0x1FB52D0", Offset = "0x1FB52D0", VA = "0x1FB52D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000A13")]
			[Address(RVA = "0x1FB5570", Offset = "0x1FB5570", VA = "0x1FB5570", Slot = "5")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TestButtonHandler.Settings _buttonSettings;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TestButtonHandler _buttonHandler;

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x19B51C4", Offset = "0x19B51C4", VA = "0x19B51C4")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x19B5238", Offset = "0x19B5238", VA = "0x19B5238")]
		public void OnGUI()
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x19B62F4", Offset = "0x19B62F4", VA = "0x19B62F4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBB6DB0", Offset = "0xBB6DB0")]
		private IEnumerator RunAsyncFromCoroutineTest()
		{
			return null;
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x19B636C", Offset = "0x19B636C", VA = "0x19B636C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xBB6E10", Offset = "0xBB6E10")]
		private Task RunMultipleThreadsTestAsync()
		{
			return null;
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x19B648C", Offset = "0x19B648C", VA = "0x19B648C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xBB6E70", Offset = "0xBB6E70")]
		private Task RunMultipleThreadsTestAsyncWait()
		{
			return null;
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x19B65A8", Offset = "0x19B65A8", VA = "0x19B65A8")]
		private void PrintCurrentThreadContext([Optional] string prefix)
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x19B6728", Offset = "0x19B6728", VA = "0x19B6728")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xBB6ED0", Offset = "0xBB6ED0")]
		private Task RunAsyncFromCoroutineTest2()
		{
			return null;
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x19B61E4", Offset = "0x19B61E4", VA = "0x19B61E4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xBB6F30", Offset = "0xBB6F30")]
		private Task RunWwwAsync()
		{
			return null;
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x19B60D4", Offset = "0x19B60D4", VA = "0x19B60D4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xBB6F90", Offset = "0xBB6F90")]
		private Task RunOpenNotepadTestAsync()
		{
			return null;
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x19B5910", Offset = "0x19B5910", VA = "0x19B5910")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xBB6FF0", Offset = "0xBB6FF0")]
		private Task RunUnhandledExceptionTestAsync()
		{
			return null;
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x19B57F4", Offset = "0x19B57F4", VA = "0x19B57F4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xBB7050", Offset = "0xBB7050")]
		private Task RunTryCatchExceptionTestAsync()
		{
			return null;
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x19B6838", Offset = "0x19B6838", VA = "0x19B6838")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xBB70B0", Offset = "0xBB70B0")]
		private Task NestedRunAsync()
		{
			return null;
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x19B6948", Offset = "0x19B6948", VA = "0x19B6948")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xBB7110", Offset = "0xBB7110")]
		private Task WaitThenThrowException()
		{
			return null;
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x19B5FB8", Offset = "0x19B5FB8", VA = "0x19B5FB8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xBB7170", Offset = "0xBB7170")]
		private Task RunAsyncOperationAsync()
		{
			return null;
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x19B6A58", Offset = "0x19B6A58", VA = "0x19B6A58")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xBB71D0", Offset = "0xBB71D0")]
		private Task InstantiateAssetBundleAsync(string abUrl, string assetName)
		{
			return null;
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x19B6BB0", Offset = "0x19B6BB0", VA = "0x19B6BB0")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xBB7230", Offset = "0xBB7230")]
		private Task<byte[]> DownloadRawDataAsync(string url)
		{
			return null;
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x19B5E9C", Offset = "0x19B5E9C", VA = "0x19B5E9C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xBB7290", Offset = "0xBB7290")]
		private Task RunIEnumeratorTryCatchExceptionAsync()
		{
			return null;
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x19B5D80", Offset = "0x19B5D80", VA = "0x19B5D80")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xBB72F0", Offset = "0xBB72F0")]
		private Task RunIEnumeratorUnhandledExceptionAsync()
		{
			return null;
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x19B6D08", Offset = "0x19B6D08", VA = "0x19B6D08")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBB7350", Offset = "0xBB7350")]
		private IEnumerator WaitThenThrow()
		{
			return null;
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x19B6D80", Offset = "0x19B6D80", VA = "0x19B6D80")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBB73B0", Offset = "0xBB73B0")]
		private IEnumerator WaitThenThrowNested()
		{
			return null;
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x19B5C64", Offset = "0x19B5C64", VA = "0x19B5C64")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xBB7410", Offset = "0xBB7410")]
		private Task RunIEnumeratorStringTestAsync()
		{
			return null;
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x19B5B48", Offset = "0x19B5B48", VA = "0x19B5B48")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xBB7470", Offset = "0xBB7470")]
		private Task RunIEnumeratorUntypedStringTestAsync()
		{
			return null;
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x19B5A2C", Offset = "0x19B5A2C", VA = "0x19B5A2C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xBB74D0", Offset = "0xBB74D0")]
		private Task RunIEnumeratorTestAsync()
		{
			return null;
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x19B6DDC", Offset = "0x19B6DDC", VA = "0x19B6DDC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBB7530", Offset = "0xBB7530")]
		private IEnumerator<string> WaitForString()
		{
			return null;
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x19B6E38", Offset = "0x19B6E38", VA = "0x19B6E38")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBB7590", Offset = "0xBB7590")]
		private IEnumerator WaitForStringUntyped()
		{
			return null;
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x19B6EB0", Offset = "0x19B6EB0", VA = "0x19B6EB0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBB75F0", Offset = "0xBB75F0")]
		private IEnumerator WaitABit()
		{
			return null;
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x19B56D8", Offset = "0x19B56D8", VA = "0x19B56D8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xBB7650", Offset = "0xBB7650")]
		private Task RunReturnValueTestAsync()
		{
			return null;
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x19B6F0C", Offset = "0x19B6F0C", VA = "0x19B6F0C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xBB76B0", Offset = "0xBB76B0")]
		private Task<string> GetValueExampleAsync()
		{
			return null;
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x19B55C8", Offset = "0x19B55C8", VA = "0x19B55C8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xBB7710", Offset = "0xBB7710")]
		private Task RunAwaitSecondsTestAsync()
		{
			return null;
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x19B7038", Offset = "0x19B7038", VA = "0x19B7038")]
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
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int NumPerColumn;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float VerticalMargin;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float VerticalSpacing;

			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float HorizontalSpacing;

			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float HorizontalMargin;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float ButtonWidth;

			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float ButtonHeight;

			[Token(Token = "0x6000A14")]
			[Address(RVA = "0x26AEAC0", Offset = "0x26AEAC0", VA = "0x26AEAC0")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Settings _settings;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _buttonVCount;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int _buttonHCount;

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x1FA4410", Offset = "0x1FA4410", VA = "0x1FA4410")]
		public TestButtonHandler(Settings settings)
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x1FA4444", Offset = "0x1FA4444", VA = "0x1FA4444")]
		public void Restart()
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x1FA444C", Offset = "0x1FA444C", VA = "0x1FA444C")]
		public bool Display(string text)
		{
			return default(bool);
		}
	}
}
