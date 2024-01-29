using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class ReadOnlyDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly IDictionary<TKey, TValue> _dictionary;

	[Token(Token = "0x17000001")]
	public ICollection<TKey> Keys
	{
		[Token(Token = "0x6000004")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public ICollection<TValue> Values
	{
		[Token(Token = "0x6000007")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	public TValue this[TKey key]
	{
		[Token(Token = "0x6000008")]
		get
		{
			return (TValue)null;
		}
	}

	[Token(Token = "0x17000004")]
	private TValue System.Collections.Generic.IDictionary<TKey,TValue>.Item
	{
		[Token(Token = "0x6000009")]
		get
		{
			return (TValue)null;
		}
		[Token(Token = "0x600000A")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public int Count
	{
		[Token(Token = "0x600000F")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000006")]
	public bool IsReadOnly
	{
		[Token(Token = "0x6000010")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000001")]
	public ReadOnlyDictionary(IDictionary<TKey, TValue> dictionary)
	{
	}

	[Token(Token = "0x6000002")]
	private void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value)
	{
	}

	[Token(Token = "0x6000003")]
	public bool ContainsKey(TKey key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000005")]
	private bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000006")]
	public bool TryGetValue(TKey key, [Out] TValue value)
	{
		return default(bool);
	}

	[Token(Token = "0x600000B")]
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> item)
	{
	}

	[Token(Token = "0x600000C")]
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear()
	{
	}

	[Token(Token = "0x600000D")]
	public bool Contains(KeyValuePair<TKey, TValue> item)
	{
		return default(bool);
	}

	[Token(Token = "0x600000E")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
	{
	}

	[Token(Token = "0x6000011")]
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> item)
	{
		return default(bool);
	}

	[Token(Token = "0x6000012")]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	private static Exception ReadOnlyException()
	{
		return null;
	}
}
namespace PathologicalGames;

[Token(Token = "0x2000003")]
public static class PoolManager
{
	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly SpawnPoolsDict Pools;
}
[Token(Token = "0x2000004")]
public static class InstanceHandler
{
	[Token(Token = "0x2000005")]
	public delegate GameObject InstantiateDelegate(GameObject prefab, Vector3 pos, Quaternion rot);

	[Token(Token = "0x2000006")]
	public delegate void DestroyDelegate(GameObject instance);

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static InstantiateDelegate InstantiateDelegates;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static DestroyDelegate DestroyDelegates;

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x7B0A68", Offset = "0x7B0A68", VA = "0x7B0A68")]
	internal static GameObject InstantiatePrefab(GameObject prefab, Vector3 pos, Quaternion rot)
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x7B0B94", Offset = "0x7B0B94", VA = "0x7B0B94")]
	internal static void DestroyInstance(GameObject instance)
	{
	}
}
[Token(Token = "0x2000007")]
public class SpawnPoolsDict : IDictionary<string, SpawnPool>, ICollection<KeyValuePair<string, SpawnPool>>, IEnumerable<KeyValuePair<string, SpawnPool>>, IEnumerable
{
	[Token(Token = "0x2000008")]
	public delegate void OnCreatedDelegate(SpawnPool pool);

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal Dictionary<string, OnCreatedDelegate> onCreatedDelegates;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<string, SpawnPool> _pools;

	[Token(Token = "0x17000007")]
	public int Count
	{
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x7B1DA8", Offset = "0x7B1DA8", VA = "0x7B1DA8", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000008")]
	public SpawnPool this[string key]
	{
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x7B1EB0", Offset = "0x7B1EB0", VA = "0x7B1EB0", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x7B1FF0", Offset = "0x7B1FF0", VA = "0x7B1FF0", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public ICollection<string> Keys
	{
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x7B2040", Offset = "0x7B2040", VA = "0x7B2040", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000A")]
	public ICollection<SpawnPool> Values
	{
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x7B2090", Offset = "0x7B2090", VA = "0x7B2090", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000B")]
	private bool IsReadOnly
	{
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x7B20E0", Offset = "0x7B20E0", VA = "0x7B20E0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000C")]
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,PathologicalGames.SpawnPool>>.IsReadOnly
	{
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x7B20E8", Offset = "0x7B20E8", VA = "0x7B20E8", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x7B0EA0", Offset = "0x7B0EA0", VA = "0x7B0EA0")]
	public void AddOnCreatedDelegate(string poolName, OnCreatedDelegate createdDelegate)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x7B1030", Offset = "0x7B1030", VA = "0x7B1030")]
	public void RemoveOnCreatedDelegate(string poolName, OnCreatedDelegate createdDelegate)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x7B1200", Offset = "0x7B1200", VA = "0x7B1200")]
	public SpawnPool Create(string poolName)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x7B12B0", Offset = "0x7B12B0", VA = "0x7B12B0")]
	public SpawnPool Create(string poolName, GameObject owner)
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x7B140C", Offset = "0x7B140C", VA = "0x7B140C")]
	private bool assertValidPoolName(string poolName)
	{
		return default(bool);
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x7B15C0", Offset = "0x7B15C0", VA = "0x7B15C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x7B16D4", Offset = "0x7B16D4", VA = "0x7B16D4")]
	public bool Destroy(string poolName)
	{
		return default(bool);
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x7B1824", Offset = "0x7B1824", VA = "0x7B1824")]
	public void DestroyAll()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x7B1A7C", Offset = "0x7B1A7C", VA = "0x7B1A7C")]
	internal void Add(SpawnPool spawnPool)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x7B1BC4", Offset = "0x7B1BC4", VA = "0x7B1BC4", Slot = "9")]
	public void Add(string key, SpawnPool value)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x7B1C14", Offset = "0x7B1C14", VA = "0x7B1C14")]
	internal bool Remove(SpawnPool spawnPool)
	{
		return default(bool);
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x7B1D58", Offset = "0x7B1D58", VA = "0x7B1D58", Slot = "10")]
	public bool Remove(string poolName)
	{
		return default(bool);
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x7B1568", Offset = "0x7B1568", VA = "0x7B1568", Slot = "8")]
	public bool ContainsKey(string poolName)
	{
		return default(bool);
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x7B1D00", Offset = "0x7B1D00", VA = "0x7B1D00")]
	public bool ContainsValue(SpawnPool pool)
	{
		return default(bool);
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x7B1DF8", Offset = "0x7B1DF8", VA = "0x7B1DF8", Slot = "11")]
	public bool TryGetValue(string poolName, [Out] SpawnPool spawnPool)
	{
		return default(bool);
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x7B1E60", Offset = "0x7B1E60", VA = "0x7B1E60", Slot = "16")]
	public bool Contains(KeyValuePair<string, SpawnPool> item)
	{
		return default(bool);
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x7B20F0", Offset = "0x7B20F0", VA = "0x7B20F0", Slot = "14")]
	public void Add(KeyValuePair<string, SpawnPool> item)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x7B2140", Offset = "0x7B2140", VA = "0x7B2140", Slot = "15")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x7B2190", Offset = "0x7B2190", VA = "0x7B2190")]
	private void CopyTo(KeyValuePair<string, SpawnPool>[] array, int arrayIndex)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x7B21E0", Offset = "0x7B21E0", VA = "0x7B21E0", Slot = "17")]
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,PathologicalGames.SpawnPool>>.CopyTo(KeyValuePair<string, SpawnPool>[] array, int arrayIndex)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x7B2230", Offset = "0x7B2230", VA = "0x7B2230", Slot = "18")]
	public bool Remove(KeyValuePair<string, SpawnPool> item)
	{
		return default(bool);
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x7B2280", Offset = "0x7B2280", VA = "0x7B2280", Slot = "19")]
	public IEnumerator<KeyValuePair<string, SpawnPool>> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x7B2314", Offset = "0x7B2314", VA = "0x7B2314", Slot = "20")]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x7B09A8", Offset = "0x7B09A8", VA = "0x7B09A8")]
	public SpawnPoolsDict()
	{
	}
}
[Token(Token = "0x2000009")]
[AddComponentMenu("Path-o-logical/PoolManager/Pre-Runtime Pool Item")]
public class PreRuntimePoolItem : MonoBehaviour
{
	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string poolName;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string prefabName;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool despawnOnStart;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool doNotReparent;

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x7B2490", Offset = "0x7B2490", VA = "0x7B2490")]
	private void Start()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x7B28F0", Offset = "0x7B28F0", VA = "0x7B28F0")]
	public PreRuntimePoolItem()
	{
	}
}
[Token(Token = "0x200000A")]
[AddComponentMenu("Path-o-logical/PoolManager/SpawnPool")]
public sealed class SpawnPool : MonoBehaviour, IList<Transform>, ICollection<Transform>, IEnumerable<Transform>, IEnumerable
{
	[Token(Token = "0x200000B")]
	public delegate GameObject InstantiateDelegate(GameObject prefab, Vector3 pos, Quaternion rot);

	[Token(Token = "0x200000C")]
	public delegate void DestroyDelegate(GameObject instance);

	[Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class <DoDespawnAfterSeconds>d__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform instance;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float seconds;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool useParent;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SpawnPool <>4__this;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform parent;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject <go>5__2;

		[Token(Token = "0x17000013")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x7B69AC", Offset = "0x7B69AC", VA = "0x7B69AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x7B69F4", Offset = "0x7B69F4", VA = "0x7B69F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x7B5774", Offset = "0x7B5774", VA = "0x7B5774")]
		[DebuggerHidden]
		public <DoDespawnAfterSeconds>d__56(int <>1__state)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x7B68D4", Offset = "0x7B68D4", VA = "0x7B68D4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x7B68D8", Offset = "0x7B68D8", VA = "0x7B68D8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x7B69B4", Offset = "0x7B69B4", VA = "0x7B69B4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class <ListForAudioStop>d__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource src;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SpawnPool <>4__this;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject <srcGameObject>5__2;

		[Token(Token = "0x17000015")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x7B6AE4", Offset = "0x7B6AE4", VA = "0x7B6AE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x7B6B2C", Offset = "0x7B6B2C", VA = "0x7B6B2C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x7B5D54", Offset = "0x7B5D54", VA = "0x7B5D54")]
		[DebuggerHidden]
		public <ListForAudioStop>d__63(int <>1__state)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x7B69FC", Offset = "0x7B69FC", VA = "0x7B69FC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x7B6A00", Offset = "0x7B6A00", VA = "0x7B6A00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x7B6AEC", Offset = "0x7B6AEC", VA = "0x7B6AEC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class <ListenForEmitDespawn>d__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ParticleSystem emitter;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SpawnPool <>4__this;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <safetimer>5__2;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject <emitterGO>5__3;

		[Token(Token = "0x17000017")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x7B6D98", Offset = "0x7B6D98", VA = "0x7B6D98", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x7B6DE0", Offset = "0x7B6DE0", VA = "0x7B6DE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x7B5D7C", Offset = "0x7B5D7C", VA = "0x7B5D7C")]
		[DebuggerHidden]
		public <ListenForEmitDespawn>d__64(int <>1__state)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x7B6B34", Offset = "0x7B6B34", VA = "0x7B6B34", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x7B6B38", Offset = "0x7B6B38", VA = "0x7B6B38", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x7B6DA0", Offset = "0x7B6DA0", VA = "0x7B6DA0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__73 : IEnumerator<Transform>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform <>2__current;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpawnPool <>4__this;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <i>5__2;

		[Token(Token = "0x17000019")]
		private Transform System.Collections.Generic.IEnumerator<UnityEngine.Transform>.Current
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x7B6EB0", Offset = "0x7B6EB0", VA = "0x7B6EB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x7B6EF8", Offset = "0x7B6EF8", VA = "0x7B6EF8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x7B620C", Offset = "0x7B620C", VA = "0x7B620C")]
		[DebuggerHidden]
		public <GetEnumerator>d__73(int <>1__state)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x7B6DE8", Offset = "0x7B6DE8", VA = "0x7B6DE8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x7B6DEC", Offset = "0x7B6DEC", VA = "0x7B6DEC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x7B6EB8", Offset = "0x7B6EB8", VA = "0x7B6EB8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class <System-Collections-IEnumerable-GetEnumerator>d__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpawnPool <>4__this;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <i>5__2;

		[Token(Token = "0x1700001B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x7B6FC8", Offset = "0x7B6FC8", VA = "0x7B6FC8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x7B7010", Offset = "0x7B7010", VA = "0x7B7010", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x7B629C", Offset = "0x7B629C", VA = "0x7B629C")]
		[DebuggerHidden]
		public <System-Collections-IEnumerable-GetEnumerator>d__74(int <>1__state)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x7B6F00", Offset = "0x7B6F00", VA = "0x7B6F00", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x7B6F04", Offset = "0x7B6F04", VA = "0x7B6F04", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x7B6FD0", Offset = "0x7B6FD0", VA = "0x7B6FD0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string poolName;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool matchPoolScale;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool matchPoolLayer;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	public bool dontReparent;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
	public bool _dontDestroyOnLoad;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool logMessages;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<PrefabPool> _perPrefabPoolOptions;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Dictionary<object, bool> prefabsFoldOutStates;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float maxParticleDespawnTime;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public PrefabsDict prefabs;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Dictionary<object, bool> _editorListItemStates;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<PrefabPool> _prefabPools;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	internal List<Transform> _spawned;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public InstantiateDelegate instantiateDelegates;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public DestroyDelegate destroyDelegates;

	[Token(Token = "0x1700000D")]
	public bool dontDestroyOnLoad
	{
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x7B2948", Offset = "0x7B2948", VA = "0x7B2948")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x7B2950", Offset = "0x7B2950", VA = "0x7B2950")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public Transform group
	{
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x7B2A0C", Offset = "0x7B2A0C", VA = "0x7B2A0C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x7B2A14", Offset = "0x7B2A14", VA = "0x7B2A14")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public Dictionary<string, PrefabPool> prefabPools
	{
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x7B2A1C", Offset = "0x7B2A1C", VA = "0x7B2A1C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000010")]
	public Transform this[int index]
	{
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x7B5FFC", Offset = "0x7B5FFC", VA = "0x7B5FFC", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x7B6054", Offset = "0x7B6054", VA = "0x7B6054", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public int Count
	{
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x7B615C", Offset = "0x7B615C", VA = "0x7B615C", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000012")]
	public bool IsReadOnly
	{
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x7B63C4", Offset = "0x7B63C4", VA = "0x7B63C4", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x7B2B48", Offset = "0x7B2B48", VA = "0x7B2B48")]
	private void Awake()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x7B30F0", Offset = "0x7B30F0", VA = "0x7B30F0")]
	internal GameObject InstantiatePrefab(GameObject prefab, Vector3 pos, Quaternion rot)
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x7B310C", Offset = "0x7B310C", VA = "0x7B310C")]
	internal void DestroyInstance(GameObject instance)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x7B3128", Offset = "0x7B3128", VA = "0x7B3128")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x7B2ED0", Offset = "0x7B2ED0", VA = "0x7B2ED0")]
	public void CreatePrefabPool(PrefabPool prefabPool)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x7B25B8", Offset = "0x7B25B8", VA = "0x7B25B8")]
	public void Add(Transform instance, string prefabName, bool despawn, bool parent)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x7B3F24", Offset = "0x7B3F24", VA = "0x7B3F24", Slot = "11")]
	public void Add(Transform item)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x7B3F74", Offset = "0x7B3F74", VA = "0x7B3F74")]
	public void Remove(Transform item)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x7B3FC4", Offset = "0x7B3FC4", VA = "0x7B3FC4")]
	public Transform Spawn(Transform prefab, Vector3 pos, Quaternion rot, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x7B4864", Offset = "0x7B4864", VA = "0x7B4864")]
	public Transform Spawn(Transform prefab, Vector3 pos, Quaternion rot)
	{
		return null;
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x7B4948", Offset = "0x7B4948", VA = "0x7B4948")]
	public Transform Spawn(Transform prefab)
	{
		return null;
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x7B49F8", Offset = "0x7B49F8", VA = "0x7B49F8")]
	public Transform Spawn(Transform prefab, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x7B4AB8", Offset = "0x7B4AB8", VA = "0x7B4AB8")]
	public Transform Spawn(GameObject prefab, Vector3 pos, Quaternion rot, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x7B4B4C", Offset = "0x7B4B4C", VA = "0x7B4B4C")]
	public Transform Spawn(GameObject prefab, Vector3 pos, Quaternion rot)
	{
		return null;
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x7B4BD0", Offset = "0x7B4BD0", VA = "0x7B4BD0")]
	public Transform Spawn(GameObject prefab)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x7B4BFC", Offset = "0x7B4BFC", VA = "0x7B4BFC")]
	public Transform Spawn(GameObject prefab, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x7B4C38", Offset = "0x7B4C38", VA = "0x7B4C38")]
	public Transform Spawn(string prefabName)
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x7B4DA0", Offset = "0x7B4DA0", VA = "0x7B4DA0")]
	public Transform Spawn(string prefabName, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x7B4DD8", Offset = "0x7B4DD8", VA = "0x7B4DD8")]
	public Transform Spawn(string prefabName, Vector3 pos, Quaternion rot)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x7B4E58", Offset = "0x7B4E58", VA = "0x7B4E58")]
	public Transform Spawn(string prefabName, Vector3 pos, Quaternion rot, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x7B4EE8", Offset = "0x7B4EE8", VA = "0x7B4EE8")]
	public AudioSource Spawn(AudioSource prefab, Vector3 pos, Quaternion rot)
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x7B5040", Offset = "0x7B5040", VA = "0x7B5040")]
	public AudioSource Spawn(AudioSource prefab)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x7B50F4", Offset = "0x7B50F4", VA = "0x7B50F4")]
	public AudioSource Spawn(AudioSource prefab, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x7B4EF0", Offset = "0x7B4EF0", VA = "0x7B4EF0")]
	public AudioSource Spawn(AudioSource prefab, Vector3 pos, Quaternion rot, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x7B5228", Offset = "0x7B5228", VA = "0x7B5228")]
	public ParticleSystem Spawn(ParticleSystem prefab, Vector3 pos, Quaternion rot)
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x7B5230", Offset = "0x7B5230", VA = "0x7B5230")]
	public ParticleSystem Spawn(ParticleSystem prefab, Vector3 pos, Quaternion rot, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x7B53EC", Offset = "0x7B53EC", VA = "0x7B53EC")]
	public void Despawn(Transform instance)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x7B5604", Offset = "0x7B5604", VA = "0x7B5604")]
	public void Despawn(Transform instance, Transform parent)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x7B5684", Offset = "0x7B5684", VA = "0x7B5684")]
	public void Despawn(Transform instance, float seconds)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x7B574C", Offset = "0x7B574C", VA = "0x7B574C")]
	public void Despawn(Transform instance, float seconds, Transform parent)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x7B56AC", Offset = "0x7B56AC", VA = "0x7B56AC")]
	[IteratorStateMachine(typeof(<DoDespawnAfterSeconds>d__56))]
	private IEnumerator DoDespawnAfterSeconds(Transform instance, float seconds, bool useParent, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x7B579C", Offset = "0x7B579C", VA = "0x7B579C")]
	public void DespawnAll()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x7B5878", Offset = "0x7B5878", VA = "0x7B5878")]
	public bool IsSpawned(Transform instance)
	{
		return default(bool);
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x7B3878", Offset = "0x7B3878", VA = "0x7B3878")]
	public PrefabPool GetPrefabPool(Transform prefab)
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x7B58D0", Offset = "0x7B58D0", VA = "0x7B58D0")]
	public PrefabPool GetPrefabPool(GameObject prefab)
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x7B5A80", Offset = "0x7B5A80", VA = "0x7B5A80")]
	public Transform GetPrefab(Transform instance)
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x7B5C78", Offset = "0x7B5C78", VA = "0x7B5C78")]
	public GameObject GetPrefab(GameObject instance)
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x7B51B4", Offset = "0x7B51B4", VA = "0x7B51B4")]
	[IteratorStateMachine(typeof(<ListForAudioStop>d__63))]
	private IEnumerator ListForAudioStop(AudioSource src)
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x7B5378", Offset = "0x7B5378", VA = "0x7B5378")]
	[IteratorStateMachine(typeof(<ListenForEmitDespawn>d__64))]
	private IEnumerator ListenForEmitDespawn(ParticleSystem emitter)
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x7B5DA4", Offset = "0x7B5DA4", VA = "0x7B5DA4", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x7B60A4", Offset = "0x7B60A4", VA = "0x7B60A4", Slot = "13")]
	public bool Contains(Transform item)
	{
		return default(bool);
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x7B60F4", Offset = "0x7B60F4", VA = "0x7B60F4", Slot = "14")]
	public void CopyTo(Transform[] array, int arrayIndex)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x7B61A4", Offset = "0x7B61A4", VA = "0x7B61A4", Slot = "16")]
	[IteratorStateMachine(typeof(<GetEnumerator>d__73))]
	public IEnumerator<Transform> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x7B6234", Offset = "0x7B6234", VA = "0x7B6234", Slot = "17")]
	[IteratorStateMachine(typeof(<System-Collections-IEnumerable-GetEnumerator>d__74))]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x7B62C4", Offset = "0x7B62C4", VA = "0x7B62C4", Slot = "6")]
	public int IndexOf(Transform item)
	{
		return default(int);
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x7B6304", Offset = "0x7B6304", VA = "0x7B6304", Slot = "7")]
	public void Insert(int index, Transform item)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x7B6344", Offset = "0x7B6344", VA = "0x7B6344", Slot = "8")]
	public void RemoveAt(int index)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x7B6384", Offset = "0x7B6384", VA = "0x7B6384", Slot = "12")]
	public void Clear()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x7B6404", Offset = "0x7B6404", VA = "0x7B6404", Slot = "15")]
	private bool System.Collections.Generic.ICollection<UnityEngine.Transform>.Remove(Transform item)
	{
		return default(bool);
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x7B6444", Offset = "0x7B6444", VA = "0x7B6444")]
	public SpawnPool()
	{
	}
}
[Serializable]
[Token(Token = "0x2000012")]
public class PrefabPool
{
	[Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class <CullDespawned>d__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PrefabPool <>4__this;

		[Token(Token = "0x17000022")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x7B8450", Offset = "0x7B8450", VA = "0x7B8450", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x7B8498", Offset = "0x7B8498", VA = "0x7B8498", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x7B753C", Offset = "0x7B753C", VA = "0x7B753C")]
		[DebuggerHidden]
		public <CullDespawned>d__37(int <>1__state)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x7B7EC0", Offset = "0x7B7EC0", VA = "0x7B7EC0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x7B7EC4", Offset = "0x7B7EC4", VA = "0x7B7EC4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x7B8458", Offset = "0x7B8458", VA = "0x7B8458", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class <PreloadOverTime>d__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PrefabPool <>4__this;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <remainder>5__2;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int <numPerFrame>5__3;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <numThisFrame>5__4;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <i>5__5;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <n>5__6;

		[Token(Token = "0x17000024")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x7B8684", Offset = "0x7B8684", VA = "0x7B8684", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x7B86CC", Offset = "0x7B86CC", VA = "0x7B86CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x7B7E98", Offset = "0x7B7E98", VA = "0x7B7E98")]
		[DebuggerHidden]
		public <PreloadOverTime>d__44(int <>1__state)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x7B84A0", Offset = "0x7B84A0", VA = "0x7B84A0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x7B84A4", Offset = "0x7B84A4", VA = "0x7B84A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x7B868C", Offset = "0x7B868C", VA = "0x7B868C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Transform prefab;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal GameObject prefabGO;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int preloadAmount;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool preloadTime;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int preloadFrames;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float preloadDelay;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool limitInstances;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int limitAmount;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool limitFIFO;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool cullDespawned;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int cullAbove;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int cullDelay;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int cullMaxPerPass;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool _logMessages;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	private bool forceLoggingSilent;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public SpawnPool spawnPool;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool cullingActive;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	internal List<Transform> _spawned;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	internal List<Transform> _despawned;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool _preloaded;

	[Token(Token = "0x1700001D")]
	public bool logMessages
	{
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x7B7018", Offset = "0x7B7018", VA = "0x7B7018")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001E")]
	public List<Transform> spawned
	{
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x7B7128", Offset = "0x7B7128", VA = "0x7B7128")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001F")]
	public List<Transform> despawned
	{
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x7B71A4", Offset = "0x7B71A4", VA = "0x7B71A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000020")]
	public int totalCount
	{
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x7B7220", Offset = "0x7B7220", VA = "0x7B7220")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000021")]
	internal bool preloaded
	{
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x7B7278", Offset = "0x7B7278", VA = "0x7B7278")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x7B7280", Offset = "0x7B7280", VA = "0x7B7280")]
		private set
		{
		}
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x7B4778", Offset = "0x7B4778", VA = "0x7B4778")]
	public PrefabPool(Transform prefab)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x7B705C", Offset = "0x7B705C", VA = "0x7B705C")]
	public PrefabPool()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x7B2E24", Offset = "0x7B2E24", VA = "0x7B2E24")]
	internal void inspectorInstanceConstructor()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x7B33C8", Offset = "0x7B33C8", VA = "0x7B33C8")]
	internal void SelfDestruct()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x7B55EC", Offset = "0x7B55EC", VA = "0x7B55EC")]
	internal bool DespawnInstance(Transform xform)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x7B728C", Offset = "0x7B728C", VA = "0x7B728C")]
	internal bool DespawnInstance(Transform xform, bool sendEventMessage)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x7B74D4", Offset = "0x7B74D4", VA = "0x7B74D4")]
	[IteratorStateMachine(typeof(<CullDespawned>d__37))]
	internal IEnumerator CullDespawned()
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x7B434C", Offset = "0x7B434C", VA = "0x7B434C")]
	internal Transform SpawnInstance(Vector3 pos, Quaternion rot)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x7B79D0", Offset = "0x7B79D0", VA = "0x7B79D0")]
	public Transform SpawnNew()
	{
		return null;
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x7B7564", Offset = "0x7B7564", VA = "0x7B7564")]
	public Transform SpawnNew(Vector3 pos, Quaternion rot)
	{
		return null;
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x7B7B20", Offset = "0x7B7B20", VA = "0x7B7B20")]
	private void SetRecursively(Transform xform, int layer)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x7B3E30", Offset = "0x7B3E30", VA = "0x7B3E30")]
	internal void AddUnpooled(Transform inst, bool despawn)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x7B3AA4", Offset = "0x7B3AA4", VA = "0x7B3AA4")]
	internal void PreloadInstances()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x7B7E30", Offset = "0x7B7E30", VA = "0x7B7E30")]
	[IteratorStateMachine(typeof(<PreloadOverTime>d__44))]
	private IEnumerator PreloadOverTime()
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x7B5B44", Offset = "0x7B5B44", VA = "0x7B5B44")]
	public bool Contains(Transform transform)
	{
		return default(bool);
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x7B7A78", Offset = "0x7B7A78", VA = "0x7B7A78")]
	private void nameInstance(Transform instance)
	{
	}
}
[Token(Token = "0x2000015")]
public class PrefabsDict : IDictionary<string, Transform>, ICollection<KeyValuePair<string, Transform>>, IEnumerable<KeyValuePair<string, Transform>>, IEnumerable
{
	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Dictionary<string, Transform> _prefabs;

	[Token(Token = "0x17000026")]
	public int Count
	{
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x7B8840", Offset = "0x7B8840", VA = "0x7B8840", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000027")]
	public Transform this[string key]
	{
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x7B4C60", Offset = "0x7B4C60", VA = "0x7B4C60", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x7B8A40", Offset = "0x7B8A40", VA = "0x7B8A40", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000028")]
	public ICollection<string> Keys
	{
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x7B8A90", Offset = "0x7B8A90", VA = "0x7B8A90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000029")]
	public ICollection<Transform> Values
	{
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x7B8AE0", Offset = "0x7B8AE0", VA = "0x7B8AE0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002A")]
	private bool IsReadOnly
	{
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x7B8B30", Offset = "0x7B8B30", VA = "0x7B8B30")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002B")]
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Transform>>.IsReadOnly
	{
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x7B8B38", Offset = "0x7B8B38", VA = "0x7B8B38", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x7B86D4", Offset = "0x7B86D4", VA = "0x7B86D4", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x7B3A3C", Offset = "0x7B3A3C", VA = "0x7B3A3C")]
	internal void _Add(string prefabName, Transform prefab)
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x7B87E8", Offset = "0x7B87E8", VA = "0x7B87E8")]
	internal bool _Remove(string prefabName)
	{
		return default(bool);
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x7B3828", Offset = "0x7B3828", VA = "0x7B3828")]
	internal void _Clear()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x7B8890", Offset = "0x7B8890", VA = "0x7B8890", Slot = "8")]
	public bool ContainsKey(string prefabName)
	{
		return default(bool);
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x7B88E8", Offset = "0x7B88E8", VA = "0x7B88E8", Slot = "11")]
	public bool TryGetValue(string prefabName, [Out] Transform prefab)
	{
		return default(bool);
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x7B8950", Offset = "0x7B8950", VA = "0x7B8950", Slot = "9")]
	public void Add(string key, Transform value)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x7B89A0", Offset = "0x7B89A0", VA = "0x7B89A0", Slot = "10")]
	public bool Remove(string prefabName)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x7B89F0", Offset = "0x7B89F0", VA = "0x7B89F0", Slot = "16")]
	public bool Contains(KeyValuePair<string, Transform> item)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x7B8B40", Offset = "0x7B8B40", VA = "0x7B8B40", Slot = "14")]
	public void Add(KeyValuePair<string, Transform> item)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x7B8B90", Offset = "0x7B8B90", VA = "0x7B8B90", Slot = "15")]
	public void Clear()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x7B8BD0", Offset = "0x7B8BD0", VA = "0x7B8BD0")]
	private void CopyTo(KeyValuePair<string, Transform>[] array, int arrayIndex)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x7B8C20", Offset = "0x7B8C20", VA = "0x7B8C20", Slot = "17")]
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Transform>>.CopyTo(KeyValuePair<string, Transform>[] array, int arrayIndex)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x7B8C70", Offset = "0x7B8C70", VA = "0x7B8C70", Slot = "18")]
	public bool Remove(KeyValuePair<string, Transform> item)
	{
		return default(bool);
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x7B8CC0", Offset = "0x7B8CC0", VA = "0x7B8CC0", Slot = "19")]
	public IEnumerator<KeyValuePair<string, Transform>> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x7B8D54", Offset = "0x7B8D54", VA = "0x7B8D54", Slot = "20")]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x7B65E0", Offset = "0x7B65E0", VA = "0x7B65E0")]
	public PrefabsDict()
	{
	}
}
