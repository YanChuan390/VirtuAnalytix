using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class ReadOnlyDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x0")]
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
	public bool TryGetValue(TKey key, out TValue value)
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
	[FieldOffset(Offset = "0x0")]
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
	[FieldOffset(Offset = "0x0")]
	public static InstantiateDelegate InstantiateDelegates;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x8")]
	public static DestroyDelegate DestroyDelegates;

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x9DEBC8", Offset = "0x9DEBC8", VA = "0x9DEBC8")]
	internal static GameObject InstantiatePrefab(GameObject prefab, Vector3 pos, Quaternion rot)
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x9DECF8", Offset = "0x9DECF8", VA = "0x9DECF8")]
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
	[FieldOffset(Offset = "0x10")]
	internal Dictionary<string, OnCreatedDelegate> onCreatedDelegates;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, SpawnPool> _pools;

	[Token(Token = "0x17000007")]
	public int Count
	{
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x9DFF0C", Offset = "0x9DFF0C", VA = "0x9DFF0C", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000008")]
	public SpawnPool this[string key]
	{
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x9E0014", Offset = "0x9E0014", VA = "0x9E0014", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x9E0154", Offset = "0x9E0154", VA = "0x9E0154", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public ICollection<string> Keys
	{
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x9E01A4", Offset = "0x9E01A4", VA = "0x9E01A4", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000A")]
	public ICollection<SpawnPool> Values
	{
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x9E01F4", Offset = "0x9E01F4", VA = "0x9E01F4", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000B")]
	private bool IsReadOnly
	{
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x9E0244", Offset = "0x9E0244", VA = "0x9E0244")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000C")]
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,PathologicalGames.SpawnPool>>.IsReadOnly
	{
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x9E024C", Offset = "0x9E024C", VA = "0x9E024C", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x9DF004", Offset = "0x9DF004", VA = "0x9DF004")]
	public void AddOnCreatedDelegate(string poolName, OnCreatedDelegate createdDelegate)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x9DF194", Offset = "0x9DF194", VA = "0x9DF194")]
	public void RemoveOnCreatedDelegate(string poolName, OnCreatedDelegate createdDelegate)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x9DF364", Offset = "0x9DF364", VA = "0x9DF364")]
	public SpawnPool Create(string poolName)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x9DF414", Offset = "0x9DF414", VA = "0x9DF414")]
	public SpawnPool Create(string poolName, GameObject owner)
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x9DF56C", Offset = "0x9DF56C", VA = "0x9DF56C")]
	private bool assertValidPoolName(string poolName)
	{
		return default(bool);
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x9DF720", Offset = "0x9DF720", VA = "0x9DF720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x9DF834", Offset = "0x9DF834", VA = "0x9DF834")]
	public bool Destroy(string poolName)
	{
		return default(bool);
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x9DF984", Offset = "0x9DF984", VA = "0x9DF984")]
	public void DestroyAll()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x9DFBD8", Offset = "0x9DFBD8", VA = "0x9DFBD8")]
	internal void Add(SpawnPool spawnPool)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x9DFD28", Offset = "0x9DFD28", VA = "0x9DFD28", Slot = "9")]
	public void Add(string key, SpawnPool value)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x9DFD78", Offset = "0x9DFD78", VA = "0x9DFD78")]
	internal bool Remove(SpawnPool spawnPool)
	{
		return default(bool);
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x9DFEBC", Offset = "0x9DFEBC", VA = "0x9DFEBC", Slot = "10")]
	public bool Remove(string poolName)
	{
		return default(bool);
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x9DF6C8", Offset = "0x9DF6C8", VA = "0x9DF6C8", Slot = "8")]
	public bool ContainsKey(string poolName)
	{
		return default(bool);
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x9DFE64", Offset = "0x9DFE64", VA = "0x9DFE64")]
	public bool ContainsValue(SpawnPool pool)
	{
		return default(bool);
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x9DFF5C", Offset = "0x9DFF5C", VA = "0x9DFF5C", Slot = "11")]
	public bool TryGetValue(string poolName, out SpawnPool spawnPool)
	{
		return default(bool);
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x9DFFC4", Offset = "0x9DFFC4", VA = "0x9DFFC4", Slot = "16")]
	public bool Contains(KeyValuePair<string, SpawnPool> item)
	{
		return default(bool);
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x9E0254", Offset = "0x9E0254", VA = "0x9E0254", Slot = "14")]
	public void Add(KeyValuePair<string, SpawnPool> item)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x9E02A4", Offset = "0x9E02A4", VA = "0x9E02A4", Slot = "15")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x9E02F4", Offset = "0x9E02F4", VA = "0x9E02F4")]
	private void CopyTo(KeyValuePair<string, SpawnPool>[] array, int arrayIndex)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x9E0344", Offset = "0x9E0344", VA = "0x9E0344", Slot = "17")]
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,PathologicalGames.SpawnPool>>.CopyTo(KeyValuePair<string, SpawnPool>[] array, int arrayIndex)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x9E0394", Offset = "0x9E0394", VA = "0x9E0394", Slot = "18")]
	public bool Remove(KeyValuePair<string, SpawnPool> item)
	{
		return default(bool);
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x9E03E4", Offset = "0x9E03E4", VA = "0x9E03E4", Slot = "19")]
	public IEnumerator<KeyValuePair<string, SpawnPool>> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x9E0478", Offset = "0x9E0478", VA = "0x9E0478", Slot = "20")]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x9DEB08", Offset = "0x9DEB08", VA = "0x9DEB08")]
	public SpawnPoolsDict()
	{
	}
}
[Token(Token = "0x2000009")]
[AddComponentMenu("Path-o-logical/PoolManager/Pre-Runtime Pool Item")]
public class PreRuntimePoolItem : MonoBehaviour
{
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x18")]
	public string poolName;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x20")]
	public string prefabName;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x28")]
	public bool despawnOnStart;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x29")]
	public bool doNotReparent;

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x9E05F0", Offset = "0x9E05F0", VA = "0x9E05F0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x9E0A50", Offset = "0x9E0A50", VA = "0x9E0A50")]
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
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x20")]
		public Transform instance;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x28")]
		public float seconds;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x2C")]
		public bool useParent;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x30")]
		public SpawnPool <>4__this;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x38")]
		public Transform parent;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x40")]
		private GameObject <go>5__2;

		[Token(Token = "0x17000013")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x9E4B00", Offset = "0x9E4B00", VA = "0x9E4B00", Slot = "4")]
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
			[Address(RVA = "0x9E4B48", Offset = "0x9E4B48", VA = "0x9E4B48", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x9E38D0", Offset = "0x9E38D0", VA = "0x9E38D0")]
		[DebuggerHidden]
		public <DoDespawnAfterSeconds>d__56(int <>1__state)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x9E4A28", Offset = "0x9E4A28", VA = "0x9E4A28", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x9E4A2C", Offset = "0x9E4A2C", VA = "0x9E4A2C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x9E4B08", Offset = "0x9E4B08", VA = "0x9E4B08", Slot = "8")]
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
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x20")]
		public AudioSource src;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x28")]
		public SpawnPool <>4__this;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x30")]
		private GameObject <srcGameObject>5__2;

		[Token(Token = "0x17000015")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x9E4C38", Offset = "0x9E4C38", VA = "0x9E4C38", Slot = "4")]
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
			[Address(RVA = "0x9E4C80", Offset = "0x9E4C80", VA = "0x9E4C80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x9E3EB0", Offset = "0x9E3EB0", VA = "0x9E3EB0")]
		[DebuggerHidden]
		public <ListForAudioStop>d__63(int <>1__state)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x9E4B50", Offset = "0x9E4B50", VA = "0x9E4B50", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x9E4B54", Offset = "0x9E4B54", VA = "0x9E4B54", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x9E4C40", Offset = "0x9E4C40", VA = "0x9E4C40", Slot = "8")]
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
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x20")]
		public ParticleSystem emitter;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x28")]
		public SpawnPool <>4__this;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x30")]
		private float <safetimer>5__2;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x38")]
		private GameObject <emitterGO>5__3;

		[Token(Token = "0x17000017")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x9E4EEC", Offset = "0x9E4EEC", VA = "0x9E4EEC", Slot = "4")]
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
			[Address(RVA = "0x9E4F34", Offset = "0x9E4F34", VA = "0x9E4F34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x9E3ED8", Offset = "0x9E3ED8", VA = "0x9E3ED8")]
		[DebuggerHidden]
		public <ListenForEmitDespawn>d__64(int <>1__state)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x9E4C88", Offset = "0x9E4C88", VA = "0x9E4C88", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x9E4C8C", Offset = "0x9E4C8C", VA = "0x9E4C8C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x9E4EF4", Offset = "0x9E4EF4", VA = "0x9E4EF4", Slot = "8")]
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
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x18")]
		private Transform <>2__current;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x20")]
		public SpawnPool <>4__this;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x28")]
		private int <i>5__2;

		[Token(Token = "0x17000019")]
		private Transform System.Collections.Generic.IEnumerator<UnityEngine.Transform>.Current
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x9E5004", Offset = "0x9E5004", VA = "0x9E5004", Slot = "4")]
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
			[Address(RVA = "0x9E504C", Offset = "0x9E504C", VA = "0x9E504C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x9E4364", Offset = "0x9E4364", VA = "0x9E4364")]
		[DebuggerHidden]
		public <GetEnumerator>d__73(int <>1__state)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x9E4F3C", Offset = "0x9E4F3C", VA = "0x9E4F3C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x9E4F40", Offset = "0x9E4F40", VA = "0x9E4F40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x9E500C", Offset = "0x9E500C", VA = "0x9E500C", Slot = "8")]
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
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x20")]
		public SpawnPool <>4__this;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x28")]
		private int <i>5__2;

		[Token(Token = "0x1700001B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x9E511C", Offset = "0x9E511C", VA = "0x9E511C", Slot = "4")]
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
			[Address(RVA = "0x9E5164", Offset = "0x9E5164", VA = "0x9E5164", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x9E43F4", Offset = "0x9E43F4", VA = "0x9E43F4")]
		[DebuggerHidden]
		public <System-Collections-IEnumerable-GetEnumerator>d__74(int <>1__state)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x9E5054", Offset = "0x9E5054", VA = "0x9E5054", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x9E5058", Offset = "0x9E5058", VA = "0x9E5058", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x9E5124", Offset = "0x9E5124", VA = "0x9E5124", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x18")]
	public string poolName;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x20")]
	public bool matchPoolScale;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x21")]
	public bool matchPoolLayer;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x22")]
	public bool dontReparent;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x23")]
	public bool _dontDestroyOnLoad;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x24")]
	public bool logMessages;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x28")]
	public List<PrefabPool> _perPrefabPoolOptions;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x30")]
	public Dictionary<object, bool> prefabsFoldOutStates;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x38")]
	public float maxParticleDespawnTime;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x48")]
	public PrefabsDict prefabs;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x50")]
	public Dictionary<object, bool> _editorListItemStates;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x58")]
	private List<PrefabPool> _prefabPools;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x60")]
	internal List<Transform> _spawned;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x68")]
	public InstantiateDelegate instantiateDelegates;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x70")]
	public DestroyDelegate destroyDelegates;

	[Token(Token = "0x1700000D")]
	public bool dontDestroyOnLoad
	{
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x9E0AA8", Offset = "0x9E0AA8", VA = "0x9E0AA8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x9E0AB0", Offset = "0x9E0AB0", VA = "0x9E0AB0")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public Transform group
	{
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x9E0B6C", Offset = "0x9E0B6C", VA = "0x9E0B6C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x9E0B74", Offset = "0x9E0B74", VA = "0x9E0B74")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public Dictionary<string, PrefabPool> prefabPools
	{
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x9E0B7C", Offset = "0x9E0B7C", VA = "0x9E0B7C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000010")]
	public Transform this[int index]
	{
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x9E4154", Offset = "0x9E4154", VA = "0x9E4154", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x9E41AC", Offset = "0x9E41AC", VA = "0x9E41AC", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public int Count
	{
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x9E42B4", Offset = "0x9E42B4", VA = "0x9E42B4", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000012")]
	public bool IsReadOnly
	{
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x9E451C", Offset = "0x9E451C", VA = "0x9E451C", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x9E0CA8", Offset = "0x9E0CA8", VA = "0x9E0CA8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x9E1250", Offset = "0x9E1250", VA = "0x9E1250")]
	internal GameObject InstantiatePrefab(GameObject prefab, Vector3 pos, Quaternion rot)
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x9E1270", Offset = "0x9E1270", VA = "0x9E1270")]
	internal void DestroyInstance(GameObject instance)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x9E1290", Offset = "0x9E1290", VA = "0x9E1290")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x9E1030", Offset = "0x9E1030", VA = "0x9E1030")]
	public void CreatePrefabPool(PrefabPool prefabPool)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x9E0718", Offset = "0x9E0718", VA = "0x9E0718")]
	public void Add(Transform instance, string prefabName, bool despawn, bool parent)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x9E2080", Offset = "0x9E2080", VA = "0x9E2080", Slot = "11")]
	public void Add(Transform item)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x9E20D0", Offset = "0x9E20D0", VA = "0x9E20D0")]
	public void Remove(Transform item)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x9E2120", Offset = "0x9E2120", VA = "0x9E2120")]
	public Transform Spawn(Transform prefab, Vector3 pos, Quaternion rot, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x9E29C0", Offset = "0x9E29C0", VA = "0x9E29C0")]
	public Transform Spawn(Transform prefab, Vector3 pos, Quaternion rot)
	{
		return null;
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x9E2AA4", Offset = "0x9E2AA4", VA = "0x9E2AA4")]
	public Transform Spawn(Transform prefab)
	{
		return null;
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x9E2B54", Offset = "0x9E2B54", VA = "0x9E2B54")]
	public Transform Spawn(Transform prefab, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x9E2C14", Offset = "0x9E2C14", VA = "0x9E2C14")]
	public Transform Spawn(GameObject prefab, Vector3 pos, Quaternion rot, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x9E2CA8", Offset = "0x9E2CA8", VA = "0x9E2CA8")]
	public Transform Spawn(GameObject prefab, Vector3 pos, Quaternion rot)
	{
		return null;
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x9E2D2C", Offset = "0x9E2D2C", VA = "0x9E2D2C")]
	public Transform Spawn(GameObject prefab)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x9E2D58", Offset = "0x9E2D58", VA = "0x9E2D58")]
	public Transform Spawn(GameObject prefab, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x9E2D94", Offset = "0x9E2D94", VA = "0x9E2D94")]
	public Transform Spawn(string prefabName)
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x9E2EFC", Offset = "0x9E2EFC", VA = "0x9E2EFC")]
	public Transform Spawn(string prefabName, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x9E2F34", Offset = "0x9E2F34", VA = "0x9E2F34")]
	public Transform Spawn(string prefabName, Vector3 pos, Quaternion rot)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x9E2FB4", Offset = "0x9E2FB4", VA = "0x9E2FB4")]
	public Transform Spawn(string prefabName, Vector3 pos, Quaternion rot, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x9E3044", Offset = "0x9E3044", VA = "0x9E3044")]
	public AudioSource Spawn(AudioSource prefab, Vector3 pos, Quaternion rot)
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x9E319C", Offset = "0x9E319C", VA = "0x9E319C")]
	public AudioSource Spawn(AudioSource prefab)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x9E3250", Offset = "0x9E3250", VA = "0x9E3250")]
	public AudioSource Spawn(AudioSource prefab, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x9E304C", Offset = "0x9E304C", VA = "0x9E304C")]
	public AudioSource Spawn(AudioSource prefab, Vector3 pos, Quaternion rot, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x9E3384", Offset = "0x9E3384", VA = "0x9E3384")]
	public ParticleSystem Spawn(ParticleSystem prefab, Vector3 pos, Quaternion rot)
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x9E338C", Offset = "0x9E338C", VA = "0x9E338C")]
	public ParticleSystem Spawn(ParticleSystem prefab, Vector3 pos, Quaternion rot, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x9E3548", Offset = "0x9E3548", VA = "0x9E3548")]
	public void Despawn(Transform instance)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x9E3760", Offset = "0x9E3760", VA = "0x9E3760")]
	public void Despawn(Transform instance, Transform parent)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x9E37E0", Offset = "0x9E37E0", VA = "0x9E37E0")]
	public void Despawn(Transform instance, float seconds)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x9E38A8", Offset = "0x9E38A8", VA = "0x9E38A8")]
	public void Despawn(Transform instance, float seconds, Transform parent)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x9E3808", Offset = "0x9E3808", VA = "0x9E3808")]
	[IteratorStateMachine(typeof(<DoDespawnAfterSeconds>d__56))]
	private IEnumerator DoDespawnAfterSeconds(Transform instance, float seconds, bool useParent, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x9E38F8", Offset = "0x9E38F8", VA = "0x9E38F8")]
	public void DespawnAll()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x9E39D4", Offset = "0x9E39D4", VA = "0x9E39D4")]
	public bool IsSpawned(Transform instance)
	{
		return default(bool);
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x9E19D4", Offset = "0x9E19D4", VA = "0x9E19D4")]
	public PrefabPool GetPrefabPool(Transform prefab)
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x9E3A2C", Offset = "0x9E3A2C", VA = "0x9E3A2C")]
	public PrefabPool GetPrefabPool(GameObject prefab)
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x9E3BDC", Offset = "0x9E3BDC", VA = "0x9E3BDC")]
	public Transform GetPrefab(Transform instance)
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x9E3DD4", Offset = "0x9E3DD4", VA = "0x9E3DD4")]
	public GameObject GetPrefab(GameObject instance)
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x9E3310", Offset = "0x9E3310", VA = "0x9E3310")]
	[IteratorStateMachine(typeof(<ListForAudioStop>d__63))]
	private IEnumerator ListForAudioStop(AudioSource src)
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x9E34D4", Offset = "0x9E34D4", VA = "0x9E34D4")]
	[IteratorStateMachine(typeof(<ListenForEmitDespawn>d__64))]
	private IEnumerator ListenForEmitDespawn(ParticleSystem emitter)
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x9E3F00", Offset = "0x9E3F00", VA = "0x9E3F00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x9E41FC", Offset = "0x9E41FC", VA = "0x9E41FC", Slot = "13")]
	public bool Contains(Transform item)
	{
		return default(bool);
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x9E424C", Offset = "0x9E424C", VA = "0x9E424C", Slot = "14")]
	public void CopyTo(Transform[] array, int arrayIndex)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x9E42FC", Offset = "0x9E42FC", VA = "0x9E42FC", Slot = "16")]
	[IteratorStateMachine(typeof(<GetEnumerator>d__73))]
	public IEnumerator<Transform> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x9E438C", Offset = "0x9E438C", VA = "0x9E438C", Slot = "17")]
	[IteratorStateMachine(typeof(<System-Collections-IEnumerable-GetEnumerator>d__74))]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x9E441C", Offset = "0x9E441C", VA = "0x9E441C", Slot = "6")]
	public int IndexOf(Transform item)
	{
		return default(int);
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x9E445C", Offset = "0x9E445C", VA = "0x9E445C", Slot = "7")]
	public void Insert(int index, Transform item)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x9E449C", Offset = "0x9E449C", VA = "0x9E449C", Slot = "8")]
	public void RemoveAt(int index)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x9E44DC", Offset = "0x9E44DC", VA = "0x9E44DC", Slot = "12")]
	public void Clear()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x9E455C", Offset = "0x9E455C", VA = "0x9E455C", Slot = "15")]
	private bool System.Collections.Generic.ICollection<UnityEngine.Transform>.Remove(Transform item)
	{
		return default(bool);
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x9E459C", Offset = "0x9E459C", VA = "0x9E459C")]
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
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x20")]
		public PrefabPool <>4__this;

		[Token(Token = "0x17000022")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x9E6598", Offset = "0x9E6598", VA = "0x9E6598", Slot = "4")]
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
			[Address(RVA = "0x9E65E0", Offset = "0x9E65E0", VA = "0x9E65E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x9E5690", Offset = "0x9E5690", VA = "0x9E5690")]
		[DebuggerHidden]
		public <CullDespawned>d__37(int <>1__state)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x9E6004", Offset = "0x9E6004", VA = "0x9E6004", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x9E6008", Offset = "0x9E6008", VA = "0x9E6008", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x9E65A0", Offset = "0x9E65A0", VA = "0x9E65A0", Slot = "8")]
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
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x20")]
		public PrefabPool <>4__this;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x28")]
		private int <remainder>5__2;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x2C")]
		private int <numPerFrame>5__3;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x30")]
		private int <numThisFrame>5__4;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x34")]
		private int <i>5__5;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x38")]
		private int <n>5__6;

		[Token(Token = "0x17000024")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x9E67CC", Offset = "0x9E67CC", VA = "0x9E67CC", Slot = "4")]
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
			[Address(RVA = "0x9E6814", Offset = "0x9E6814", VA = "0x9E6814", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x9E5FDC", Offset = "0x9E5FDC", VA = "0x9E5FDC")]
		[DebuggerHidden]
		public <PreloadOverTime>d__44(int <>1__state)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x9E65E8", Offset = "0x9E65E8", VA = "0x9E65E8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x9E65EC", Offset = "0x9E65EC", VA = "0x9E65EC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x9E67D4", Offset = "0x9E67D4", VA = "0x9E67D4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x10")]
	public Transform prefab;

	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x18")]
	internal GameObject prefabGO;

	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x20")]
	public int preloadAmount;

	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x24")]
	public bool preloadTime;

	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x28")]
	public int preloadFrames;

	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x2C")]
	public float preloadDelay;

	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x30")]
	public bool limitInstances;

	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x34")]
	public int limitAmount;

	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x38")]
	public bool limitFIFO;

	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x39")]
	public bool cullDespawned;

	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x3C")]
	public int cullAbove;

	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x40")]
	public int cullDelay;

	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x44")]
	public int cullMaxPerPass;

	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x48")]
	public bool _logMessages;

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x49")]
	private bool forceLoggingSilent;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x50")]
	public SpawnPool spawnPool;

	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x58")]
	private bool cullingActive;

	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x60")]
	internal List<Transform> _spawned;

	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x68")]
	internal List<Transform> _despawned;

	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x70")]
	private bool _preloaded;

	[Token(Token = "0x1700001D")]
	public bool logMessages
	{
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x9E516C", Offset = "0x9E516C", VA = "0x9E516C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001E")]
	public List<Transform> spawned
	{
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x9E527C", Offset = "0x9E527C", VA = "0x9E527C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001F")]
	public List<Transform> despawned
	{
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x9E52F8", Offset = "0x9E52F8", VA = "0x9E52F8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000020")]
	public int totalCount
	{
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x9E5374", Offset = "0x9E5374", VA = "0x9E5374")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000021")]
	internal bool preloaded
	{
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x9E53CC", Offset = "0x9E53CC", VA = "0x9E53CC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x9E53D4", Offset = "0x9E53D4", VA = "0x9E53D4")]
		private set
		{
		}
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x9E28D4", Offset = "0x9E28D4", VA = "0x9E28D4")]
	public PrefabPool(Transform prefab)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x9E51B0", Offset = "0x9E51B0", VA = "0x9E51B0")]
	public PrefabPool()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x9E0F84", Offset = "0x9E0F84", VA = "0x9E0F84")]
	internal void inspectorInstanceConstructor()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x9E152C", Offset = "0x9E152C", VA = "0x9E152C")]
	internal void SelfDestruct()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x9E3748", Offset = "0x9E3748", VA = "0x9E3748")]
	internal bool DespawnInstance(Transform xform)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x9E53E0", Offset = "0x9E53E0", VA = "0x9E53E0")]
	internal bool DespawnInstance(Transform xform, bool sendEventMessage)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x9E5628", Offset = "0x9E5628", VA = "0x9E5628")]
	[IteratorStateMachine(typeof(<CullDespawned>d__37))]
	internal IEnumerator CullDespawned()
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x9E24A8", Offset = "0x9E24A8", VA = "0x9E24A8")]
	internal Transform SpawnInstance(Vector3 pos, Quaternion rot)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x9E5B24", Offset = "0x9E5B24", VA = "0x9E5B24")]
	public Transform SpawnNew()
	{
		return null;
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x9E56B8", Offset = "0x9E56B8", VA = "0x9E56B8")]
	public Transform SpawnNew(Vector3 pos, Quaternion rot)
	{
		return null;
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x9E5C74", Offset = "0x9E5C74", VA = "0x9E5C74")]
	private void SetRecursively(Transform xform, int layer)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x9E1F8C", Offset = "0x9E1F8C", VA = "0x9E1F8C")]
	internal void AddUnpooled(Transform inst, bool despawn)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x9E1C00", Offset = "0x9E1C00", VA = "0x9E1C00")]
	internal void PreloadInstances()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x9E5F74", Offset = "0x9E5F74", VA = "0x9E5F74")]
	[IteratorStateMachine(typeof(<PreloadOverTime>d__44))]
	private IEnumerator PreloadOverTime()
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x9E3CA0", Offset = "0x9E3CA0", VA = "0x9E3CA0")]
	public bool Contains(Transform transform)
	{
		return default(bool);
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x9E5BCC", Offset = "0x9E5BCC", VA = "0x9E5BCC")]
	private void nameInstance(Transform instance)
	{
	}
}
[Token(Token = "0x2000015")]
public class PrefabsDict : IDictionary<string, Transform>, ICollection<KeyValuePair<string, Transform>>, IEnumerable<KeyValuePair<string, Transform>>, IEnumerable
{
	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, Transform> _prefabs;

	[Token(Token = "0x17000026")]
	public int Count
	{
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x9E6988", Offset = "0x9E6988", VA = "0x9E6988", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000027")]
	public Transform this[string key]
	{
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x9E2DBC", Offset = "0x9E2DBC", VA = "0x9E2DBC", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x9E6B88", Offset = "0x9E6B88", VA = "0x9E6B88", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000028")]
	public ICollection<string> Keys
	{
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x9E6BD8", Offset = "0x9E6BD8", VA = "0x9E6BD8", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000029")]
	public ICollection<Transform> Values
	{
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x9E6C28", Offset = "0x9E6C28", VA = "0x9E6C28", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002A")]
	private bool IsReadOnly
	{
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x9E6C78", Offset = "0x9E6C78", VA = "0x9E6C78")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002B")]
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Transform>>.IsReadOnly
	{
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x9E6C80", Offset = "0x9E6C80", VA = "0x9E6C80", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x9E681C", Offset = "0x9E681C", VA = "0x9E681C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x9E1B98", Offset = "0x9E1B98", VA = "0x9E1B98")]
	internal void _Add(string prefabName, Transform prefab)
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x9E6930", Offset = "0x9E6930", VA = "0x9E6930")]
	internal bool _Remove(string prefabName)
	{
		return default(bool);
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x9E1984", Offset = "0x9E1984", VA = "0x9E1984")]
	internal void _Clear()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x9E69D8", Offset = "0x9E69D8", VA = "0x9E69D8", Slot = "8")]
	public bool ContainsKey(string prefabName)
	{
		return default(bool);
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x9E6A30", Offset = "0x9E6A30", VA = "0x9E6A30", Slot = "11")]
	public bool TryGetValue(string prefabName, out Transform prefab)
	{
		return default(bool);
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x9E6A98", Offset = "0x9E6A98", VA = "0x9E6A98", Slot = "9")]
	public void Add(string key, Transform value)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x9E6AE8", Offset = "0x9E6AE8", VA = "0x9E6AE8", Slot = "10")]
	public bool Remove(string prefabName)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x9E6B38", Offset = "0x9E6B38", VA = "0x9E6B38", Slot = "16")]
	public bool Contains(KeyValuePair<string, Transform> item)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x9E6C88", Offset = "0x9E6C88", VA = "0x9E6C88", Slot = "14")]
	public void Add(KeyValuePair<string, Transform> item)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x9E6CD8", Offset = "0x9E6CD8", VA = "0x9E6CD8", Slot = "15")]
	public void Clear()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x9E6D18", Offset = "0x9E6D18", VA = "0x9E6D18")]
	private void CopyTo(KeyValuePair<string, Transform>[] array, int arrayIndex)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x9E6D68", Offset = "0x9E6D68", VA = "0x9E6D68", Slot = "17")]
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Transform>>.CopyTo(KeyValuePair<string, Transform>[] array, int arrayIndex)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x9E6DB8", Offset = "0x9E6DB8", VA = "0x9E6DB8", Slot = "18")]
	public bool Remove(KeyValuePair<string, Transform> item)
	{
		return default(bool);
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x9E6E08", Offset = "0x9E6E08", VA = "0x9E6E08", Slot = "19")]
	public IEnumerator<KeyValuePair<string, Transform>> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x9E6E9C", Offset = "0x9E6E9C", VA = "0x9E6E9C", Slot = "20")]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x9E4738", Offset = "0x9E4738", VA = "0x9E4738")]
	public PrefabsDict()
	{
	}
}
