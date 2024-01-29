using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000002")]
	public class FollowTarget : MonoBehaviour
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x1793E34", Offset = "0x1793E34", VA = "0x1793E34")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x1793E90", Offset = "0x1793E90", VA = "0x1793E90")]
		public FollowTarget()
		{
		}
	}
	[Token(Token = "0x2000003")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float height;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float rotationDamping;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float heightDamping;

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x1793EA8", Offset = "0x1793EA8", VA = "0x1793EA8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x1793EAC", Offset = "0x1793EAC", VA = "0x1793EAC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x17941E0", Offset = "0x17941E0", VA = "0x17941E0")]
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
		[Address(RVA = "0x17941F4", Offset = "0x17941F4", VA = "0x17941F4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x17943F0", Offset = "0x17943F0", VA = "0x17943F0")]
		public WaterBasic()
		{
		}
	}
}
