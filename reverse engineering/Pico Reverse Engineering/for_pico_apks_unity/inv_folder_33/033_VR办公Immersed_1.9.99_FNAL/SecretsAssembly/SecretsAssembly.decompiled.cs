using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace ImmersedVR.Secrets;

[Serializable]
[Token(Token = "0x2000002")]
public class SecretObject
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x10")]
	public Secrets.Tokens tokenType;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x18")]
	public string tokenValue;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2198560", Offset = "0x2198560", VA = "0x2198560")]
	public SecretObject()
	{
	}
}
[Token(Token = "0x2000003")]
[CreateAssetMenu(menuName = "Data/RuntimeSecrets")]
public class RuntimeSecrets : ScriptableObject
{
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<SecretObject> secrets;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x0")]
	private static RuntimeSecrets instance;

	[Token(Token = "0x17000001")]
	public static RuntimeSecrets Instance
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2198568", Offset = "0x2198568", VA = "0x2198568")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2198644", Offset = "0x2198644", VA = "0x2198644")]
	public void Set(Secrets.Tokens type, string value)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x219881C", Offset = "0x219881C", VA = "0x219881C")]
	public string Get(Secrets.Tokens type)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2198A44", Offset = "0x2198A44", VA = "0x2198A44")]
	public RuntimeSecrets()
	{
	}
}
[Token(Token = "0x2000006")]
public static class Secrets
{
	[Token(Token = "0x2000007")]
	public enum Tokens
	{
		[Token(Token = "0x4000008")]
		KeystorePassword,
		[Token(Token = "0x4000009")]
		KeystoreAlias,
		[Token(Token = "0x400000A")]
		KeystoreAliasPassword,
		[Token(Token = "0x400000B")]
		AppIdQuest,
		[Token(Token = "0x400000C")]
		AppIdGo,
		[Token(Token = "0x400000D")]
		LocalUsername,
		[Token(Token = "0x400000E")]
		AppSecretQuest,
		[Token(Token = "0x400000F")]
		AppSecretGo,
		[Token(Token = "0x4000010")]
		AmplitudeProduction,
		[Token(Token = "0x4000011")]
		AmplitudeTest,
		[Token(Token = "0x4000012")]
		TurnServerUser,
		[Token(Token = "0x4000013")]
		TurnServerPassword,
		[Token(Token = "0x4000014")]
		ViveportAppID,
		[Token(Token = "0x4000015")]
		PicoAppID,
		[Token(Token = "0x4000016")]
		AESEncryptor,
		[Token(Token = "0x4000017")]
		AESDecryptor
	}
}
