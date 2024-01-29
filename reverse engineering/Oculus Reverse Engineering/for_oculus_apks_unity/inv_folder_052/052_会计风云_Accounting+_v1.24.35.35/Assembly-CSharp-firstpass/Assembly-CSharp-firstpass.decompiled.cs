using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Core.Tokens;
using YamlDotNet.Serialization.TypeInspectors;
using YamlDotNet.Serialization.Utilities;

[assembly: AssemblyVersion("0.0.0.0")]
namespace YamlDotNet.Core
{
	[Serializable]
	[Token(Token = "0x2000002")]
	public class AnchorNotFoundException : YamlException
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0xAEC048", Offset = "0xAEC048", VA = "0xAEC048")]
		public AnchorNotFoundException()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0xAEC058", Offset = "0xAEC058", VA = "0xAEC058")]
		public AnchorNotFoundException(string message)
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0xAEC068", Offset = "0xAEC068", VA = "0xAEC068")]
		public AnchorNotFoundException(Mark start, Mark end, string message)
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0xAEC078", Offset = "0xAEC078", VA = "0xAEC078")]
		public AnchorNotFoundException(string message, Exception inner)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000003")]
	internal class CharacterAnalyzer<TBuffer> where TBuffer : ILookAheadBuffer
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly TBuffer buffer;

		[Token(Token = "0x17000001")]
		public TBuffer Buffer
		{
			[Token(Token = "0x6000006")]
			get
			{
				return (TBuffer)null;
			}
		}

		[Token(Token = "0x17000002")]
		public bool EndOfInput
		{
			[Token(Token = "0x6000007")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000005")]
		public CharacterAnalyzer(TBuffer buffer)
		{
		}

		[Token(Token = "0x6000008")]
		public char Peek(int offset)
		{
			return default(char);
		}

		[Token(Token = "0x6000009")]
		public void Skip(int length)
		{
		}

		[Token(Token = "0x600000A")]
		public bool IsAlphaNumericDashOrUnderscore(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x600000B")]
		public bool IsAscii(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x600000C")]
		public bool IsPrintable(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x600000D")]
		public bool IsDigit(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x600000E")]
		public int AsDigit(int offset = 0)
		{
			return default(int);
		}

		[Token(Token = "0x600000F")]
		public bool IsHex(int offset)
		{
			return default(bool);
		}

		[Token(Token = "0x6000010")]
		public int AsHex(int offset)
		{
			return default(int);
		}

		[Token(Token = "0x6000011")]
		public bool IsSpace(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000012")]
		public bool IsZero(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000013")]
		public bool IsTab(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000014")]
		public bool IsWhite(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000015")]
		public bool IsBreak(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000016")]
		public bool IsCrLf(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000017")]
		public bool IsBreakOrZero(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000018")]
		public bool IsWhiteBreakOrZero(int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000019")]
		public bool Check(char expected, int offset = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x600001A")]
		public bool Check(string expectedCharacters, int offset = 0)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000004")]
	internal static class Constants
	{
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly TagDirective[] DefaultTagDirectives;

		[Token(Token = "0x4000003")]
		public const int MajorVersion = 1;

		[Token(Token = "0x4000004")]
		public const int MinorVersion = 1;

		[Token(Token = "0x4000005")]
		public const char HandleCharacter = '!';

		[Token(Token = "0x4000006")]
		public const string DefaultHandle = "!";
	}
	[Serializable]
	[Token(Token = "0x2000005")]
	internal class Cursor
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x580CD4", Offset = "0x580CD4")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x580CD4", Offset = "0x580CD4")]
		private int <Index>k__BackingField;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x580D10", Offset = "0x580D10")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x580D10", Offset = "0x580D10")]
		private int <Line>k__BackingField;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x580D4C", Offset = "0x580D4C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x580D4C", Offset = "0x580D4C")]
		private int <LineOffset>k__BackingField;

		[Token(Token = "0x17000003")]
		public int Index
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0xAEC308", Offset = "0xAEC308", VA = "0xAEC308")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x580D88", Offset = "0x580D88")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600001F")]
			[Address(RVA = "0xAEC310", Offset = "0xAEC310", VA = "0xAEC310")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x580D98", Offset = "0x580D98")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public int Line
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0xAEC318", Offset = "0xAEC318", VA = "0xAEC318")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x580DA8", Offset = "0x580DA8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000021")]
			[Address(RVA = "0xAEC294", Offset = "0xAEC294", VA = "0xAEC294")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x580DB8", Offset = "0x580DB8")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public int LineOffset
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0xAEC320", Offset = "0xAEC320", VA = "0xAEC320")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x580DC8", Offset = "0x580DC8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000023")]
			[Address(RVA = "0xAEC328", Offset = "0xAEC328", VA = "0xAEC328")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x580DD8", Offset = "0x580DD8")]
			set
			{
			}
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xAEC268", Offset = "0xAEC268", VA = "0xAEC268")]
		public Cursor()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xAEC29C", Offset = "0xAEC29C", VA = "0xAEC29C")]
		public Cursor(Cursor cursor)
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xAEC330", Offset = "0xAEC330", VA = "0xAEC330")]
		public Mark Mark()
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xAEC4C0", Offset = "0xAEC4C0", VA = "0xAEC4C0")]
		public void Skip()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xAEC4DC", Offset = "0xAEC4DC", VA = "0xAEC4DC")]
		public void SkipLineByOffset(int offset)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xAEC4F4", Offset = "0xAEC4F4", VA = "0xAEC4F4")]
		public void ForceSkipLineAfterNonBreak()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000006")]
	public class DuplicateAnchorException : YamlException
	{
		[Token(Token = "0x6000028")]
		[Address(RVA = "0xAEC50C", Offset = "0xAEC50C", VA = "0xAEC50C")]
		public DuplicateAnchorException()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xAEC514", Offset = "0xAEC514", VA = "0xAEC514")]
		public DuplicateAnchorException(string message)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xAEC51C", Offset = "0xAEC51C", VA = "0xAEC51C")]
		public DuplicateAnchorException(Mark start, Mark end, string message)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xAEC524", Offset = "0xAEC524", VA = "0xAEC524")]
		public DuplicateAnchorException(string message, Exception inner)
		{
		}
	}
	[Token(Token = "0x2000007")]
	public class Emitter : IEmitter
	{
		[Token(Token = "0x2000008")]
		private class AnchorData
		{
			[Token(Token = "0x4000026")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string anchor;

			[Token(Token = "0x4000027")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool isAlias;

			[Token(Token = "0x600006B")]
			[Address(RVA = "0xAEC948", Offset = "0xAEC948", VA = "0xAEC948")]
			public AnchorData()
			{
			}
		}

		[Token(Token = "0x2000009")]
		private class TagData
		{
			[Token(Token = "0x4000028")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string handle;

			[Token(Token = "0x4000029")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string suffix;

			[Token(Token = "0x600006C")]
			[Address(RVA = "0xAEC950", Offset = "0xAEC950", VA = "0xAEC950")]
			public TagData()
			{
			}
		}

		[Token(Token = "0x200000A")]
		private class ScalarData
		{
			[Token(Token = "0x400002A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string value;

			[Token(Token = "0x400002B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool isMultiline;

			[Token(Token = "0x400002C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool isFlowPlainAllowed;

			[Token(Token = "0x400002D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			public bool isBlockPlainAllowed;

			[Token(Token = "0x400002E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
			public bool isSingleQuotedAllowed;

			[Token(Token = "0x400002F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool isBlockAllowed;

			[Token(Token = "0x4000030")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ScalarStyle style;

			[Token(Token = "0x600006D")]
			[Address(RVA = "0xAEC958", Offset = "0xAEC958", VA = "0xAEC958")]
			public ScalarData()
			{
			}
		}

		[Token(Token = "0x400000A")]
		private const int MinBestIndent = 2;

		[Token(Token = "0x400000B")]
		private const int MaxBestIndent = 9;

		[Token(Token = "0x400000C")]
		private const int MaxAliasLength = 128;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Regex uriReplacer;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly TextWriter output;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly bool outputUsesUnicodeEncoding;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private readonly bool isCanonical;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private readonly int bestIndent;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly int bestWidth;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private EmitterState state;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Stack<EmitterState> states;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Queue<ParsingEvent> events;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly Stack<int> indents;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly TagDirectiveCollection tagDirectives;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int indent;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int flowLevel;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool isMappingContext;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool isSimpleKeyContext;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		private bool isRootContext;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int column;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isWhitespace;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool isIndentation;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool isOpenEnded;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
		private bool isDocumentEndWritten;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly AnchorData anchorData;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly TagData tagData;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly ScalarData scalarData;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x580DE8", Offset = "0x580DE8")]
		private static MatchEvaluator <>f__am$cache0;

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xAEC52C", Offset = "0xAEC52C", VA = "0xAEC52C")]
		public Emitter(TextWriter output)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xAEC53C", Offset = "0xAEC53C", VA = "0xAEC53C")]
		public Emitter(TextWriter output, int bestIndent)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xAEC548", Offset = "0xAEC548", VA = "0xAEC548")]
		public Emitter(TextWriter output, int bestIndent, int bestWidth)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xAEC550", Offset = "0xAEC550", VA = "0xAEC550")]
		public Emitter(TextWriter output, int bestIndent, int bestWidth, bool isCanonical)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xAECA68", Offset = "0xAECA68", VA = "0xAECA68", Slot = "4")]
		public void Emit(ParsingEvent @event)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xAECFB8", Offset = "0xAECFB8", VA = "0xAECFB8")]
		private bool NeedMoreEvents()
		{
			return default(bool);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xAECB9C", Offset = "0xAECB9C", VA = "0xAECB9C")]
		private void AnalyzeEvent(ParsingEvent evt)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xAED210", Offset = "0xAED210", VA = "0xAED210")]
		private void AnalyzeAnchor(string anchor, bool isAlias)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xAED260", Offset = "0xAED260", VA = "0xAED260")]
		private void AnalyzeScalar(YamlDotNet.Core.Events.Scalar scalar)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xAEDE28", Offset = "0xAEDE28", VA = "0xAEDE28")]
		private bool ValueIsRepresentableInOutputEncoding(string value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xAEC960", Offset = "0xAEC960", VA = "0xAEC960")]
		private bool IsUnicode(Encoding encoding)
		{
			return default(bool);
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xAEDB20", Offset = "0xAEDB20", VA = "0xAEDB20")]
		private void AnalyzeTag(string tag)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xAECD4C", Offset = "0xAECD4C", VA = "0xAECD4C")]
		private void StateMachine(ParsingEvent evt)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xAEE010", Offset = "0xAEE010", VA = "0xAEE010")]
		private void EmitComment(YamlDotNet.Core.Events.Comment comment)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xAEE0D0", Offset = "0xAEE0D0", VA = "0xAEE0D0")]
		private void EmitStreamStart(ParsingEvent evt)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xAEE1C0", Offset = "0xAEE1C0", VA = "0xAEE1C0")]
		private void EmitDocumentStart(ParsingEvent evt, bool isFirst)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xAEF670", Offset = "0xAEF670", VA = "0xAEF670")]
		private TagDirectiveCollection NonDefaultTagsAmong(IEnumerable<TagDirective> tagCollection)
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xAEFAA0", Offset = "0xAEFAA0", VA = "0xAEFAA0")]
		private void AnalyzeVersionDirective(VersionDirective versionDirective)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xAEFB60", Offset = "0xAEFB60", VA = "0xAEFB60")]
		private void AppendTagDirectiveTo(TagDirective value, bool allowDuplicates, TagDirectiveCollection tagDirectives)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xAEEA98", Offset = "0xAEEA98", VA = "0xAEEA98")]
		private void EmitDocumentContent(ParsingEvent evt)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xAEFEF4", Offset = "0xAEFEF4", VA = "0xAEFEF4")]
		private void EmitNode(ParsingEvent evt, bool isRoot, bool isMapping, bool isSimpleKey)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xAF00E4", Offset = "0xAF00E4", VA = "0xAF00E4")]
		private void EmitAlias()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xAF0150", Offset = "0xAF0150", VA = "0xAF0150")]
		private void EmitScalar(ParsingEvent evt)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xAF04F8", Offset = "0xAF04F8", VA = "0xAF04F8")]
		private void SelectScalarStyle(ParsingEvent evt)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xAF09A8", Offset = "0xAF09A8", VA = "0xAF09A8")]
		private void ProcessScalar()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xAF0B34", Offset = "0xAF0B34", VA = "0xAF0B34")]
		private void WritePlainScalar(string value, bool allowBreaks)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xAF0DAC", Offset = "0xAF0DAC", VA = "0xAF0DAC")]
		private void WriteSingleQuotedScalar(string value, bool allowBreaks)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xAF1038", Offset = "0xAF1038", VA = "0xAF1038")]
		private void WriteDoubleQuotedScalar(string value, bool allowBreaks)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xAF14A4", Offset = "0xAF14A4", VA = "0xAF14A4")]
		private void WriteLiteralScalar(string value)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xAF1650", Offset = "0xAF1650", VA = "0xAF1650")]
		private void WriteFoldedScalar(string value)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xAF1A54", Offset = "0xAF1A54", VA = "0xAF1A54")]
		private static bool IsSpace(char character)
		{
			return default(bool);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xAF1A64", Offset = "0xAF1A64", VA = "0xAF1A64")]
		private static bool IsBreak(char character)
		{
			return default(bool);
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xAF1E08", Offset = "0xAF1E08", VA = "0xAF1E08")]
		private static bool IsBlank(char character)
		{
			return default(bool);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xAF1AAC", Offset = "0xAF1AAC", VA = "0xAF1AAC")]
		private static bool IsPrintable(char character)
		{
			return default(bool);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xAF0218", Offset = "0xAF0218", VA = "0xAF0218")]
		private void EmitSequenceStart(ParsingEvent evt)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xAF0330", Offset = "0xAF0330", VA = "0xAF0330")]
		private void EmitMappingStart(ParsingEvent evt)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xAF0448", Offset = "0xAF0448", VA = "0xAF0448")]
		private void ProcessAnchor()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xAF07C8", Offset = "0xAF07C8", VA = "0xAF07C8")]
		private void ProcessTag()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xAEEB1C", Offset = "0xAEEB1C", VA = "0xAEEB1C")]
		private void EmitDocumentEnd(ParsingEvent evt)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xAEEC44", Offset = "0xAEEC44", VA = "0xAEEC44")]
		private void EmitFlowSequenceItem(ParsingEvent evt, bool isFirst)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xAEEE38", Offset = "0xAEEE38", VA = "0xAEEE38")]
		private void EmitFlowMappingKey(ParsingEvent evt, bool isFirst)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xAEF094", Offset = "0xAEF094", VA = "0xAEF094")]
		private void EmitFlowMappingValue(ParsingEvent evt, bool isSimple)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xAEF180", Offset = "0xAEF180", VA = "0xAEF180")]
		private void EmitBlockSequenceItem(ParsingEvent evt, bool isFirst)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xAEF2EC", Offset = "0xAEF2EC", VA = "0xAEF2EC")]
		private void EmitBlockMappingKey(ParsingEvent evt, bool isFirst)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xAEF480", Offset = "0xAEF480", VA = "0xAEF480")]
		private void EmitBlockMappingValue(ParsingEvent evt, bool isSimple)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xAF08F8", Offset = "0xAF08F8", VA = "0xAF08F8")]
		private void IncreaseIndent(bool isFlow, bool isIndentless)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xAEFCD0", Offset = "0xAEFCD0", VA = "0xAEFCD0")]
		private bool CheckEmptyDocument()
		{
			return default(bool);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xAF20F8", Offset = "0xAF20F8", VA = "0xAF20F8")]
		private bool CheckSimpleKey()
		{
			return default(bool);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xAF2358", Offset = "0xAF2358", VA = "0xAF2358")]
		private int SafeStringLength(string value)
		{
			return default(int);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xAF1E2C", Offset = "0xAF1E2C", VA = "0xAF1E2C")]
		private bool CheckEmptySequence()
		{
			return default(bool);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xAF1F80", Offset = "0xAF1F80", VA = "0xAF1F80")]
		private bool CheckEmptyMapping()
		{
			return default(bool);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xAF1B14", Offset = "0xAF1B14", VA = "0xAF1B14")]
		private void WriteBlockScalarHints(string value)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xAEF984", Offset = "0xAEF984", VA = "0xAEF984")]
		private void WriteIndicator(string indicator, bool needWhitespace, bool whitespace, bool indentation)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xAEF9F8", Offset = "0xAEF9F8", VA = "0xAEF9F8")]
		private void WriteIndent()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xAF20CC", Offset = "0xAF20CC", VA = "0xAF20CC")]
		private void WriteAnchor(string value)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xAEFC3C", Offset = "0xAEFC3C", VA = "0xAEFC3C")]
		private void WriteTagHandle(string value)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xAEFC80", Offset = "0xAEFC80", VA = "0xAEFC80")]
		private void WriteTagContent(string value, bool needsWhitespace)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xAF2374", Offset = "0xAF2374", VA = "0xAF2374")]
		private string UrlEncode(string text)
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xAEF55C", Offset = "0xAEF55C", VA = "0xAEF55C")]
		private void Write(char value)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xAEF5F0", Offset = "0xAEF5F0", VA = "0xAEF5F0")]
		private void Write(string value)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xAEF5B0", Offset = "0xAEF5B0", VA = "0xAEF5B0")]
		private void WriteBreak()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xAF2500", Offset = "0xAF2500", VA = "0xAF2500")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x580DF8", Offset = "0x580DF8")]
		private static string <UrlEncode>m__0(Match match)
		{
			return null;
		}
	}
	[Token(Token = "0x200000B")]
	internal enum EmitterState
	{
		[Token(Token = "0x4000032")]
		StreamStart,
		[Token(Token = "0x4000033")]
		StreamEnd,
		[Token(Token = "0x4000034")]
		FirstDocumentStart,
		[Token(Token = "0x4000035")]
		DocumentStart,
		[Token(Token = "0x4000036")]
		DocumentContent,
		[Token(Token = "0x4000037")]
		DocumentEnd,
		[Token(Token = "0x4000038")]
		FlowSequenceFirstItem,
		[Token(Token = "0x4000039")]
		FlowSequenceItem,
		[Token(Token = "0x400003A")]
		FlowMappingFirstKey,
		[Token(Token = "0x400003B")]
		FlowMappingKey,
		[Token(Token = "0x400003C")]
		FlowMappingSimpleValue,
		[Token(Token = "0x400003D")]
		FlowMappingValue,
		[Token(Token = "0x400003E")]
		BlockSequenceFirstItem,
		[Token(Token = "0x400003F")]
		BlockSequenceItem,
		[Token(Token = "0x4000040")]
		BlockMappingFirstKey,
		[Token(Token = "0x4000041")]
		BlockMappingKey,
		[Token(Token = "0x4000042")]
		BlockMappingSimpleValue,
		[Token(Token = "0x4000043")]
		BlockMappingValue
	}
	[Token(Token = "0x200000C")]
	public class EventReader
	{
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IParser parser;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool endOfStream;

		[Token(Token = "0x17000006")]
		public IParser Parser
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0xAF276C", Offset = "0xAF276C", VA = "0xAF276C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xAF2678", Offset = "0xAF2678", VA = "0xAF2678")]
		public EventReader(IParser parser)
		{
		}

		[Token(Token = "0x6000070")]
		public T Expect<T>() where T : ParsingEvent
		{
			return null;
		}

		[Token(Token = "0x6000071")]
		public bool Accept<T>() where T : ParsingEvent
		{
			return default(bool);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xAF2774", Offset = "0xAF2774", VA = "0xAF2774")]
		private void ThrowIfAtEndOfStream()
		{
		}

		[Token(Token = "0x6000073")]
		public T Allow<T>() where T : ParsingEvent
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		public T Peek<T>() where T : ParsingEvent
		{
			return null;
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xAF27F0", Offset = "0xAF27F0", VA = "0xAF27F0")]
		public void SkipThisAndNestedEvents()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xAF26A8", Offset = "0xAF26A8", VA = "0xAF26A8")]
		private void MoveNext()
		{
		}
	}
}
namespace YamlDotNet.Core.Events
{
	[Token(Token = "0x200000D")]
	public class AnchorAlias : ParsingEvent
	{
		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string value;

		[Token(Token = "0x17000007")]
		internal override EventType Type
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0xAF2A98", Offset = "0xAF2A98", VA = "0xAF2A98", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x17000008")]
		public string Value
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0xAED208", Offset = "0xAED208", VA = "0xAED208")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xAF2888", Offset = "0xAF2888", VA = "0xAF2888")]
		public AnchorAlias(string value, Mark start, Mark end)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xAF2A14", Offset = "0xAF2A14", VA = "0xAF2A14")]
		public AnchorAlias(string value)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xAF2AA0", Offset = "0xAF2AA0", VA = "0xAF2AA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xAF2BC0", Offset = "0xAF2BC0", VA = "0xAF2BC0", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class Comment : ParsingEvent
	{
		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x580E08", Offset = "0x580E08")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x580E08", Offset = "0x580E08")]
		private string <Value>k__BackingField;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x580E44", Offset = "0x580E44")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x580E44", Offset = "0x580E44")]
		private bool <IsInline>k__BackingField;

		[Token(Token = "0x17000009")]
		public string Value
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0xAEF658", Offset = "0xAEF658", VA = "0xAEF658")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x580E80", Offset = "0x580E80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000080")]
			[Address(RVA = "0xAF2D68", Offset = "0xAF2D68", VA = "0xAF2D68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x580E90", Offset = "0x580E90")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public bool IsInline
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0xAEF554", Offset = "0xAEF554", VA = "0xAEF554")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x580EA0", Offset = "0x580EA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000082")]
			[Address(RVA = "0xAF2D70", Offset = "0xAF2D70", VA = "0xAF2D70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x580EB0", Offset = "0x580EB0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		internal override EventType Type
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0xAF2D7C", Offset = "0xAF2D7C", VA = "0xAF2D7C", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xAF2C7C", Offset = "0xAF2C7C", VA = "0xAF2C7C")]
		public Comment(string value, bool isInline)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xAF2D14", Offset = "0xAF2D14", VA = "0xAF2D14")]
		public Comment(string value, bool isInline, Mark start, Mark end)
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xAF2D84", Offset = "0xAF2D84", VA = "0xAF2D84", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class DocumentEnd : ParsingEvent
	{
		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly bool isImplicit;

		[Token(Token = "0x1700000C")]
		public override int NestingIncrease
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0xAF2F18", Offset = "0xAF2F18", VA = "0xAF2F18", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700000D")]
		internal override EventType Type
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0xAF2F20", Offset = "0xAF2F20", VA = "0xAF2F20", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x1700000E")]
		public bool IsImplicit
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0xAF20F0", Offset = "0xAF20F0", VA = "0xAF20F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xAF2E44", Offset = "0xAF2E44", VA = "0xAF2E44")]
		public DocumentEnd(bool isImplicit, Mark start, Mark end)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xAF2E88", Offset = "0xAF2E88", VA = "0xAF2E88")]
		public DocumentEnd(bool isImplicit)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xAF2F28", Offset = "0xAF2F28", VA = "0xAF2F28", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xAF3074", Offset = "0xAF3074", VA = "0xAF3074", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class DocumentStart : ParsingEvent
	{
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly TagDirectiveCollection tags;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly VersionDirective version;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly bool isImplicit;

		[Token(Token = "0x1700000F")]
		public override int NestingIncrease
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0xAF32FC", Offset = "0xAF32FC", VA = "0xAF32FC", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000010")]
		internal override EventType Type
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0xAF3304", Offset = "0xAF3304", VA = "0xAF3304", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x17000011")]
		public TagDirectiveCollection Tags
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0xAEF668", Offset = "0xAEF668", VA = "0xAEF668")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		public VersionDirective Version
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0xAEF97C", Offset = "0xAEF97C", VA = "0xAEF97C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		public bool IsImplicit
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0xAEF660", Offset = "0xAEF660", VA = "0xAEF660")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xAF3134", Offset = "0xAF3134", VA = "0xAF3134")]
		public DocumentStart(VersionDirective version, TagDirectiveCollection tags, bool isImplicit, Mark start, Mark end)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xAF318C", Offset = "0xAF318C", VA = "0xAF318C")]
		public DocumentStart(VersionDirective version, TagDirectiveCollection tags, bool isImplicit)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xAF3230", Offset = "0xAF3230", VA = "0xAF3230")]
		public DocumentStart(Mark start, Mark end)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xAF3274", Offset = "0xAF3274", VA = "0xAF3274")]
		public DocumentStart()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xAF330C", Offset = "0xAF330C", VA = "0xAF330C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xAF3458", Offset = "0xAF3458", VA = "0xAF3458", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x2000011")]
	internal enum EventType
	{
		[Token(Token = "0x400004E")]
		None,
		[Token(Token = "0x400004F")]
		StreamStart,
		[Token(Token = "0x4000050")]
		StreamEnd,
		[Token(Token = "0x4000051")]
		DocumentStart,
		[Token(Token = "0x4000052")]
		DocumentEnd,
		[Token(Token = "0x4000053")]
		Alias,
		[Token(Token = "0x4000054")]
		Scalar,
		[Token(Token = "0x4000055")]
		SequenceStart,
		[Token(Token = "0x4000056")]
		SequenceEnd,
		[Token(Token = "0x4000057")]
		MappingStart,
		[Token(Token = "0x4000058")]
		MappingEnd,
		[Token(Token = "0x4000059")]
		Comment
	}
	[Token(Token = "0x2000012")]
	public interface IParsingEventVisitor
	{
		[Token(Token = "0x6000097")]
		void Visit(AnchorAlias e);

		[Token(Token = "0x6000098")]
		void Visit(StreamStart e);

		[Token(Token = "0x6000099")]
		void Visit(StreamEnd e);

		[Token(Token = "0x600009A")]
		void Visit(DocumentStart e);

		[Token(Token = "0x600009B")]
		void Visit(DocumentEnd e);

		[Token(Token = "0x600009C")]
		void Visit(Scalar e);

		[Token(Token = "0x600009D")]
		void Visit(SequenceStart e);

		[Token(Token = "0x600009E")]
		void Visit(SequenceEnd e);

		[Token(Token = "0x600009F")]
		void Visit(MappingStart e);

		[Token(Token = "0x60000A0")]
		void Visit(MappingEnd e);

		[Token(Token = "0x60000A1")]
		void Visit(Comment e);
	}
	[Token(Token = "0x2000013")]
	public class MappingEnd : ParsingEvent
	{
		[Token(Token = "0x17000014")]
		public override int NestingIncrease
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0xAF35CC", Offset = "0xAF35CC", VA = "0xAF35CC", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000015")]
		internal override EventType Type
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0xAF35D4", Offset = "0xAF35D4", VA = "0xAF35D4", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xAF3518", Offset = "0xAF3518", VA = "0xAF3518")]
		public MappingEnd(Mark start, Mark end)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xAF3550", Offset = "0xAF3550", VA = "0xAF3550")]
		public MappingEnd()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xAF35DC", Offset = "0xAF35DC", VA = "0xAF35DC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xAF3624", Offset = "0xAF3624", VA = "0xAF3624", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class MappingStart : NodeEvent
	{
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly bool isImplicit;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private readonly MappingStyle style;

		[Token(Token = "0x17000016")]
		public override int NestingIncrease
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0xAF3A34", Offset = "0xAF3A34", VA = "0xAF3A34", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000017")]
		internal override EventType Type
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0xAF3A3C", Offset = "0xAF3A3C", VA = "0xAF3A3C", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x17000018")]
		public bool IsImplicit
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0xAF3A44", Offset = "0xAF3A44", VA = "0xAF3A44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000019")]
		public override bool IsCanonical
		{
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0xAF3A4C", Offset = "0xAF3A4C", VA = "0xAF3A4C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001A")]
		public MappingStyle Style
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0xAF1F78", Offset = "0xAF1F78", VA = "0xAF1F78")]
			get
			{
				return default(MappingStyle);
			}
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xAF36E4", Offset = "0xAF36E4", VA = "0xAF36E4")]
		public MappingStart(string anchor, string tag, bool isImplicit, MappingStyle style, Mark start, Mark end)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xAF390C", Offset = "0xAF390C", VA = "0xAF390C")]
		public MappingStart(string anchor, string tag, bool isImplicit, MappingStyle style)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xAF39B0", Offset = "0xAF39B0", VA = "0xAF39B0")]
		public MappingStart()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xAF3A5C", Offset = "0xAF3A5C", VA = "0xAF3A5C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xAF3C8C", Offset = "0xAF3C8C", VA = "0xAF3C8C", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x2000015")]
	public enum MappingStyle
	{
		[Token(Token = "0x400005D")]
		Any,
		[Token(Token = "0x400005E")]
		Block,
		[Token(Token = "0x400005F")]
		Flow
	}
	[Token(Token = "0x2000016")]
	public abstract class NodeEvent : ParsingEvent
	{
		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly Regex anchorValidator;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string anchor;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly string tag;

		[Token(Token = "0x1700001B")]
		public string Anchor
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0xAEDB10", Offset = "0xAEDB10", VA = "0xAEDB10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public string Tag
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0xAEDB18", Offset = "0xAEDB18", VA = "0xAEDB18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public abstract bool IsCanonical
		{
			[Token(Token = "0x60000B6")]
			get;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xAF3798", Offset = "0xAF3798", VA = "0xAF3798")]
		protected NodeEvent(string anchor, string tag, Mark start, Mark end)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xAF3D4C", Offset = "0xAF3D4C", VA = "0xAF3D4C")]
		protected NodeEvent(string anchor, string tag)
		{
		}
	}
	[Token(Token = "0x2000017")]
	public abstract class ParsingEvent
	{
		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Mark start;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Mark end;

		[Token(Token = "0x1700001E")]
		public virtual int NestingIncrease
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0xAF3E54", Offset = "0xAF3E54", VA = "0xAF3E54", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001F")]
		internal abstract EventType Type
		{
			[Token(Token = "0x60000BA")]
			get;
		}

		[Token(Token = "0x17000020")]
		public Mark Start
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0xAF3E5C", Offset = "0xAF3E5C", VA = "0xAF3E5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		public Mark End
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0xAF3E64", Offset = "0xAF3E64", VA = "0xAF3E64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xAF29DC", Offset = "0xAF29DC", VA = "0xAF29DC")]
		internal ParsingEvent(Mark start, Mark end)
		{
		}

		[Token(Token = "0x60000BD")]
		public abstract void Accept(IParsingEventVisitor visitor);
	}
	[Token(Token = "0x2000018")]
	public class Scalar : NodeEvent
	{
		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly string value;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly ScalarStyle style;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private readonly bool isPlainImplicit;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private readonly bool isQuotedImplicit;

		[Token(Token = "0x17000022")]
		internal override EventType Type
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0xAF4204", Offset = "0xAF4204", VA = "0xAF4204", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x17000023")]
		public string Value
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0xAEDDF4", Offset = "0xAEDDF4", VA = "0xAEDDF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		public ScalarStyle Style
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0xAF0B1C", Offset = "0xAF0B1C", VA = "0xAF0B1C")]
			get
			{
				return default(ScalarStyle);
			}
		}

		[Token(Token = "0x17000025")]
		public bool IsPlainImplicit
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0xAF0B24", Offset = "0xAF0B24", VA = "0xAF0B24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000026")]
		public bool IsQuotedImplicit
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0xAF0B2C", Offset = "0xAF0B2C", VA = "0xAF0B2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000027")]
		public override bool IsCanonical
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0xAF420C", Offset = "0xAF420C", VA = "0xAF420C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xAF3E6C", Offset = "0xAF3E6C", VA = "0xAF3E6C")]
		public Scalar(string anchor, string tag, string value, ScalarStyle style, bool isPlainImplicit, bool isQuotedImplicit, Mark start, Mark end)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xAF3F3C", Offset = "0xAF3F3C", VA = "0xAF3F3C")]
		public Scalar(string anchor, string tag, string value, ScalarStyle style, bool isPlainImplicit, bool isQuotedImplicit)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xAF4004", Offset = "0xAF4004", VA = "0xAF4004")]
		public Scalar(string value)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xAF40A8", Offset = "0xAF40A8", VA = "0xAF40A8")]
		public Scalar(string tag, string value)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xAF4150", Offset = "0xAF4150", VA = "0xAF4150")]
		public Scalar(string anchor, string tag, string value)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xAF422C", Offset = "0xAF422C", VA = "0xAF422C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xAF4500", Offset = "0xAF4500", VA = "0xAF4500", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class SequenceEnd : ParsingEvent
	{
		[Token(Token = "0x17000028")]
		public override int NestingIncrease
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0xAF4674", Offset = "0xAF4674", VA = "0xAF4674", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000029")]
		internal override EventType Type
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0xAF467C", Offset = "0xAF467C", VA = "0xAF467C", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xAF45C0", Offset = "0xAF45C0", VA = "0xAF45C0")]
		public SequenceEnd(Mark start, Mark end)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xAF45F8", Offset = "0xAF45F8", VA = "0xAF45F8")]
		public SequenceEnd()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xAF4684", Offset = "0xAF4684", VA = "0xAF4684", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xAF46CC", Offset = "0xAF46CC", VA = "0xAF46CC", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class SequenceStart : NodeEvent
	{
		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly bool isImplicit;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private readonly SequenceStyle style;

		[Token(Token = "0x1700002A")]
		public override int NestingIncrease
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0xAF48E4", Offset = "0xAF48E4", VA = "0xAF48E4", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002B")]
		internal override EventType Type
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0xAF48EC", Offset = "0xAF48EC", VA = "0xAF48EC", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x1700002C")]
		public bool IsImplicit
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0xAF48F4", Offset = "0xAF48F4", VA = "0xAF48F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002D")]
		public override bool IsCanonical
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0xAF48FC", Offset = "0xAF48FC", VA = "0xAF48FC", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002E")]
		public SequenceStyle Style
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0xAF1E24", Offset = "0xAF1E24", VA = "0xAF1E24")]
			get
			{
				return default(SequenceStyle);
			}
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xAF478C", Offset = "0xAF478C", VA = "0xAF478C")]
		public SequenceStart(string anchor, string tag, bool isImplicit, SequenceStyle style, Mark start, Mark end)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xAF4840", Offset = "0xAF4840", VA = "0xAF4840")]
		public SequenceStart(string anchor, string tag, bool isImplicit, SequenceStyle style)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xAF490C", Offset = "0xAF490C", VA = "0xAF490C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xAF4B3C", Offset = "0xAF4B3C", VA = "0xAF4B3C", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x200001B")]
	public enum SequenceStyle
	{
		[Token(Token = "0x400006C")]
		Any,
		[Token(Token = "0x400006D")]
		Block,
		[Token(Token = "0x400006E")]
		Flow
	}
	[Token(Token = "0x200001C")]
	public class StreamEnd : ParsingEvent
	{
		[Token(Token = "0x1700002F")]
		public override int NestingIncrease
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0xAF4CB0", Offset = "0xAF4CB0", VA = "0xAF4CB0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000030")]
		internal override EventType Type
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0xAF4CB8", Offset = "0xAF4CB8", VA = "0xAF4CB8", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xAF4BFC", Offset = "0xAF4BFC", VA = "0xAF4BFC")]
		public StreamEnd(Mark start, Mark end)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xAF4C34", Offset = "0xAF4C34", VA = "0xAF4C34")]
		public StreamEnd()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xAF4CC0", Offset = "0xAF4CC0", VA = "0xAF4CC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xAF4D08", Offset = "0xAF4D08", VA = "0xAF4D08", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class StreamStart : ParsingEvent
	{
		[Token(Token = "0x17000031")]
		public override int NestingIncrease
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0xAF4E7C", Offset = "0xAF4E7C", VA = "0xAF4E7C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000032")]
		internal override EventType Type
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0xAF4E84", Offset = "0xAF4E84", VA = "0xAF4E84", Slot = "5")]
			get
			{
				return default(EventType);
			}
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xAF4DC8", Offset = "0xAF4DC8", VA = "0xAF4DC8")]
		public StreamStart()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xAF4E44", Offset = "0xAF4E44", VA = "0xAF4E44")]
		public StreamStart(Mark start, Mark end)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xAF4E8C", Offset = "0xAF4E8C", VA = "0xAF4E8C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xAF4ED4", Offset = "0xAF4ED4", VA = "0xAF4ED4", Slot = "6")]
		public override void Accept(IParsingEventVisitor visitor)
		{
		}
	}
}
namespace YamlDotNet.Core
{
	[Token(Token = "0x200001E")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x580EC0", Offset = "0x580EC0")]
	public class FakeList<T>
	{
		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly IEnumerator<T> collection;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int currentIndex;

		[Token(Token = "0x17000033")]
		public T Item
		{
			[Token(Token = "0x60000E8")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x60000E6")]
		public FakeList(IEnumerator<T> collection)
		{
		}

		[Token(Token = "0x60000E7")]
		public FakeList(IEnumerable<T> collection)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001F")]
	public class ForwardAnchorNotSupportedException : YamlException
	{
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xAF4F94", Offset = "0xAF4F94", VA = "0xAF4F94")]
		public ForwardAnchorNotSupportedException()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xAF4F9C", Offset = "0xAF4F9C", VA = "0xAF4F9C")]
		public ForwardAnchorNotSupportedException(string message)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xAF4FA4", Offset = "0xAF4FA4", VA = "0xAF4FA4")]
		public ForwardAnchorNotSupportedException(Mark start, Mark end, string message)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xAF4FAC", Offset = "0xAF4FAC", VA = "0xAF4FAC")]
		public ForwardAnchorNotSupportedException(string message, Exception inner)
		{
		}
	}
	[Token(Token = "0x2000020")]
	internal static class HashCode
	{
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xAF4FB4", Offset = "0xAF4FB4", VA = "0xAF4FB4")]
		public static int CombineHashCodes(int h1, int h2)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000021")]
	public interface IEmitter
	{
		[Token(Token = "0x60000EE")]
		void Emit(ParsingEvent @event);
	}
	[Token(Token = "0x2000022")]
	internal interface ILookAheadBuffer
	{
		[Token(Token = "0x17000034")]
		bool EndOfInput
		{
			[Token(Token = "0x60000EF")]
			get;
		}

		[Token(Token = "0x60000F0")]
		char Peek(int offset);

		[Token(Token = "0x60000F1")]
		void Skip(int length);
	}
	[Serializable]
	[Token(Token = "0x2000023")]
	public class InsertionQueue<T>
	{
		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly IList<T> items;

		[Token(Token = "0x17000035")]
		public int Count
		{
			[Token(Token = "0x60000F3")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60000F2")]
		public InsertionQueue()
		{
		}

		[Token(Token = "0x60000F4")]
		public void Enqueue(T item)
		{
		}

		[Token(Token = "0x60000F5")]
		public T Dequeue()
		{
			return (T)null;
		}

		[Token(Token = "0x60000F6")]
		public void Insert(int index, T item)
		{
		}
	}
	[Token(Token = "0x2000024")]
	public interface IParser
	{
		[Token(Token = "0x17000036")]
		ParsingEvent Current
		{
			[Token(Token = "0x60000F7")]
			get;
		}

		[Token(Token = "0x60000F8")]
		bool MoveNext();
	}
	[Token(Token = "0x2000025")]
	public interface IScanner
	{
		[Token(Token = "0x17000037")]
		Mark CurrentPosition
		{
			[Token(Token = "0x60000F9")]
			get;
		}

		[Token(Token = "0x17000038")]
		Token Current
		{
			[Token(Token = "0x60000FA")]
			get;
		}

		[Token(Token = "0x60000FB")]
		bool MoveNext();

		[Token(Token = "0x60000FC")]
		bool MoveNextWithoutConsuming();

		[Token(Token = "0x60000FD")]
		void ConsumeCurrent();
	}
	[Serializable]
	[Token(Token = "0x2000026")]
	public class LookAheadBuffer : ILookAheadBuffer
	{
		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly TextReader input;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly char[] buffer;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int firstIndex;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int count;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool endOfInput;

		[Token(Token = "0x17000039")]
		public bool EndOfInput
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0xAF50C8", Offset = "0xAF50C8", VA = "0xAF50C8", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xAF4FC0", Offset = "0xAF4FC0", VA = "0xAF4FC0")]
		public LookAheadBuffer(TextReader input, int capacity)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xAF50E8", Offset = "0xAF50E8", VA = "0xAF50E8")]
		private int GetIndexForOffset(int offset)
		{
			return default(int);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xAF5144", Offset = "0xAF5144", VA = "0xAF5144", Slot = "5")]
		public char Peek(int offset)
		{
			return default(char);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xAF5258", Offset = "0xAF5258", VA = "0xAF5258")]
		public void Cache(int length)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xAF5314", Offset = "0xAF5314", VA = "0xAF5314", Slot = "6")]
		public void Skip(int length)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000027")]
	public class Mark : IEquatable<Mark>, IComparable<Mark>, IComparable
	{
		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Mark Empty;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x580EF8", Offset = "0x580EF8")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x580EF8", Offset = "0x580EF8")]
		private int <Index>k__BackingField;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x580F34", Offset = "0x580F34")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x580F34", Offset = "0x580F34")]
		private int <Line>k__BackingField;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x580F70", Offset = "0x580F70")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x580F70", Offset = "0x580F70")]
		private int <Column>k__BackingField;

		[Token(Token = "0x1700003A")]
		public int Index
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0xAF541C", Offset = "0xAF541C", VA = "0xAF541C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x580FAC", Offset = "0x580FAC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000107")]
			[Address(RVA = "0xAF5414", Offset = "0xAF5414", VA = "0xAF5414")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x580FBC", Offset = "0x580FBC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public int Line
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0xAF5424", Offset = "0xAF5424", VA = "0xAF5424")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x580FCC", Offset = "0x580FCC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000109")]
			[Address(RVA = "0xAF5404", Offset = "0xAF5404", VA = "0xAF5404")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x580FDC", Offset = "0x580FDC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public int Column
		{
			[Token(Token = "0x600010A")]
			[Address(RVA = "0xAF542C", Offset = "0xAF542C", VA = "0xAF542C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x580FEC", Offset = "0x580FEC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600010B")]
			[Address(RVA = "0xAF540C", Offset = "0xAF540C", VA = "0xAF540C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x580FFC", Offset = "0x580FFC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xAF53D8", Offset = "0xAF53D8", VA = "0xAF53D8")]
		public Mark()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xAEC3A8", Offset = "0xAEC3A8", VA = "0xAEC3A8")]
		public Mark(int index, int line, int column)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xAF5434", Offset = "0xAF5434", VA = "0xAF5434", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xAF5524", Offset = "0xAF5524", VA = "0xAF5524", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xAF55E8", Offset = "0xAF55E8", VA = "0xAF55E8", Slot = "4")]
		public bool Equals(Mark other)
		{
			return default(bool);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xAF5628", Offset = "0xAF5628", VA = "0xAF5628", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xAF56A0", Offset = "0xAF56A0", VA = "0xAF56A0", Slot = "6")]
		public int CompareTo(object obj)
		{
			return default(int);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xAF5770", Offset = "0xAF5770", VA = "0xAF5770", Slot = "5")]
		public int CompareTo(Mark other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000028")]
	public sealed class MergingParser : IParser
	{
		[Token(Token = "0x2000029")]
		private class ParsingEventCloner : IParsingEventVisitor
		{
			[Token(Token = "0x4000080")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private ParsingEvent clonedEvent;

			[Token(Token = "0x6000119")]
			[Address(RVA = "0xAF61B4", Offset = "0xAF61B4", VA = "0xAF61B4")]
			public ParsingEventCloner()
			{
			}

			[Token(Token = "0x600011A")]
			[Address(RVA = "0xAF6330", Offset = "0xAF6330", VA = "0xAF6330")]
			public ParsingEvent Clone(ParsingEvent e)
			{
				return null;
			}

			[Token(Token = "0x600011B")]
			[Address(RVA = "0xAF6370", Offset = "0xAF6370", VA = "0xAF6370", Slot = "4")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(YamlDotNet.Core.Events.AnchorAlias e)
			{
			}

			[Token(Token = "0x600011C")]
			[Address(RVA = "0xAF641C", Offset = "0xAF641C", VA = "0xAF641C", Slot = "5")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(YamlDotNet.Core.Events.StreamStart e)
			{
			}

			[Token(Token = "0x600011D")]
			[Address(RVA = "0xAF6480", Offset = "0xAF6480", VA = "0xAF6480", Slot = "6")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(YamlDotNet.Core.Events.StreamEnd e)
			{
			}

			[Token(Token = "0x600011E")]
			[Address(RVA = "0xAF64E4", Offset = "0xAF64E4", VA = "0xAF64E4", Slot = "7")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(YamlDotNet.Core.Events.DocumentStart e)
			{
			}

			[Token(Token = "0x600011F")]
			[Address(RVA = "0xAF6548", Offset = "0xAF6548", VA = "0xAF6548", Slot = "8")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(YamlDotNet.Core.Events.DocumentEnd e)
			{
			}

			[Token(Token = "0x6000120")]
			[Address(RVA = "0xAF65AC", Offset = "0xAF65AC", VA = "0xAF65AC", Slot = "9")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(YamlDotNet.Core.Events.Scalar e)
			{
			}

			[Token(Token = "0x6000121")]
			[Address(RVA = "0xAF66D0", Offset = "0xAF66D0", VA = "0xAF66D0", Slot = "10")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(SequenceStart e)
			{
			}

			[Token(Token = "0x6000122")]
			[Address(RVA = "0xAF67B4", Offset = "0xAF67B4", VA = "0xAF67B4", Slot = "11")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(SequenceEnd e)
			{
			}

			[Token(Token = "0x6000123")]
			[Address(RVA = "0xAF6844", Offset = "0xAF6844", VA = "0xAF6844", Slot = "12")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(MappingStart e)
			{
			}

			[Token(Token = "0x6000124")]
			[Address(RVA = "0xAF6928", Offset = "0xAF6928", VA = "0xAF6928", Slot = "13")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(MappingEnd e)
			{
			}

			[Token(Token = "0x6000125")]
			[Address(RVA = "0xAF69B8", Offset = "0xAF69B8", VA = "0xAF69B8", Slot = "14")]
			private void YamlDotNet.Core.Events.IParsingEventVisitor.Visit(YamlDotNet.Core.Events.Comment e)
			{
			}
		}

		[Token(Token = "0x20000BA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581088", Offset = "0x581088")]
		private sealed class <GetMappingEvents>c__AnonStorey0
		{
			[Token(Token = "0x400015C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal string mappingAlias;

			[Token(Token = "0x400015D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int nesting;

			[Token(Token = "0x400015E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal ParsingEventCloner cloner;

			[Token(Token = "0x6000443")]
			[Address(RVA = "0xAF61AC", Offset = "0xAF61AC", VA = "0xAF61AC")]
			public <GetMappingEvents>c__AnonStorey0()
			{
			}

			[Token(Token = "0x6000444")]
			[Address(RVA = "0xAF61C4", Offset = "0xAF61C4", VA = "0xAF61C4")]
			internal bool <>m__0(ParsingEvent e)
			{
				return default(bool);
			}

			[Token(Token = "0x6000445")]
			[Address(RVA = "0xAF6294", Offset = "0xAF6294", VA = "0xAF6294")]
			internal bool <>m__1(ParsingEvent e)
			{
				return default(bool);
			}

			[Token(Token = "0x6000446")]
			[Address(RVA = "0xAF62E8", Offset = "0xAF62E8", VA = "0xAF62E8")]
			internal ParsingEvent <>m__2(ParsingEvent e)
			{
				return null;
			}
		}

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<ParsingEvent> _allEvents;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IParser _innerParser;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _currentIndex;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58100C", Offset = "0x58100C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x58100C", Offset = "0x58100C")]
		private ParsingEvent <Current>k__BackingField;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581048", Offset = "0x581048")]
		private static Func<IEnumerable<ParsingEvent>, IEnumerable<ParsingEvent>> <>f__am$cache0;

		[Token(Token = "0x1700003D")]
		public ParsingEvent Current
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0xAF5938", Offset = "0xAF5938", VA = "0xAF5938", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581058", Offset = "0x581058")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000115")]
			[Address(RVA = "0xAF5940", Offset = "0xAF5940", VA = "0xAF5940")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581068", Offset = "0x581068")]
			private set
			{
			}
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xAF58AC", Offset = "0xAF58AC", VA = "0xAF58AC")]
		public MergingParser(IParser innerParser)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xAF5948", Offset = "0xAF5948", VA = "0xAF5948", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xAF5FBC", Offset = "0xAF5FBC", VA = "0xAF5FBC")]
		private IEnumerable<ParsingEvent> GetMappingEvents(string mappingAlias)
		{
			return null;
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xAF61BC", Offset = "0xAF61BC", VA = "0xAF61BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581078", Offset = "0x581078")]
		private static IEnumerable<ParsingEvent> <MoveNext>m__0(IEnumerable<ParsingEvent> e)
		{
			return null;
		}
	}
	[Token(Token = "0x200002A")]
	public class Parser : IParser
	{
		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Stack<ParserState> states;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly TagDirectiveCollection tagDirectives;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParserState state;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly IScanner scanner;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParsingEvent current;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Token currentToken;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly Queue<ParsingEvent> pendingEvents;

		[Token(Token = "0x1700003E")]
		public ParsingEvent Current
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0xAF6ED0", Offset = "0xAF6ED0", VA = "0xAF6ED0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xAF6A1C", Offset = "0xAF6A1C", VA = "0xAF6A1C")]
		public Parser(TextReader input)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xAF6BE8", Offset = "0xAF6BE8", VA = "0xAF6BE8")]
		public Parser(IScanner scanner)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xAF6CB0", Offset = "0xAF6CB0", VA = "0xAF6CB0")]
		private Token GetCurrentToken()
		{
			return null;
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xAF6ED8", Offset = "0xAF6ED8", VA = "0xAF6ED8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xAF6FB4", Offset = "0xAF6FB4", VA = "0xAF6FB4")]
		private ParsingEvent StateMachine()
		{
			return null;
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xAF98B4", Offset = "0xAF98B4", VA = "0xAF98B4")]
		private void Skip()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xAF71AC", Offset = "0xAF71AC", VA = "0xAF71AC")]
		private ParsingEvent ParseStreamStart()
		{
			return null;
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xAF72E4", Offset = "0xAF72E4", VA = "0xAF72E4")]
		private ParsingEvent ParseDocumentStart(bool isImplicit)
		{
			return null;
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xAF9980", Offset = "0xAF9980", VA = "0xAF9980")]
		private VersionDirective ProcessDirectives(TagDirectiveCollection tags)
		{
			return null;
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xAF9BFC", Offset = "0xAF9BFC", VA = "0xAF9BFC")]
		private static void AddTagDirectives(TagDirectiveCollection directives, IEnumerable<TagDirective> source)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xAF77D8", Offset = "0xAF77D8", VA = "0xAF77D8")]
		private ParsingEvent ParseDocumentContent()
		{
			return null;
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xAF9EA4", Offset = "0xAF9EA4", VA = "0xAF9EA4")]
		private static ParsingEvent ProcessEmptyScalar(Mark position)
		{
			return null;
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xAF7B0C", Offset = "0xAF7B0C", VA = "0xAF7B0C")]
		private ParsingEvent ParseNode(bool isBlock, bool isIndentlessSequence)
		{
			return null;
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xAF7A0C", Offset = "0xAF7A0C", VA = "0xAF7A0C")]
		private ParsingEvent ParseDocumentEnd()
		{
			return null;
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xAF833C", Offset = "0xAF833C", VA = "0xAF833C")]
		private ParsingEvent ParseBlockSequenceEntry(bool isFirst)
		{
			return null;
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xAF8604", Offset = "0xAF8604", VA = "0xAF8604")]
		private ParsingEvent ParseIndentlessSequenceEntry()
		{
			return null;
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xAF8878", Offset = "0xAF8878", VA = "0xAF8878")]
		private ParsingEvent ParseBlockMappingKey(bool isFirst)
		{
			return null;
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xAF8B80", Offset = "0xAF8B80", VA = "0xAF8B80")]
		private ParsingEvent ParseBlockMappingValue()
		{
			return null;
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xAF8D50", Offset = "0xAF8D50", VA = "0xAF8D50")]
		private ParsingEvent ParseFlowSequenceEntry(bool isFirst)
		{
			return null;
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xAF9020", Offset = "0xAF9020", VA = "0xAF9020")]
		private ParsingEvent ParseFlowSequenceEntryMappingKey()
		{
			return null;
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xAF9188", Offset = "0xAF9188", VA = "0xAF9188")]
		private ParsingEvent ParseFlowSequenceEntryMappingValue()
		{
			return null;
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xAF92EC", Offset = "0xAF92EC", VA = "0xAF92EC")]
		private ParsingEvent ParseFlowSequenceEntryMappingEnd()
		{
			return null;
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xAF9390", Offset = "0xAF9390", VA = "0xAF9390")]
		private ParsingEvent ParseFlowMappingKey(bool isFirst)
		{
			return null;
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xAF973C", Offset = "0xAF973C", VA = "0xAF973C")]
		private ParsingEvent ParseFlowMappingValue(bool isEmpty)
		{
			return null;
		}
	}
	[Token(Token = "0x200002B")]
	internal enum ParserState
	{
		[Token(Token = "0x4000089")]
		StreamStart,
		[Token(Token = "0x400008A")]
		StreamEnd,
		[Token(Token = "0x400008B")]
		ImplicitDocumentStart,
		[Token(Token = "0x400008C")]
		DocumentStart,
		[Token(Token = "0x400008D")]
		DocumentContent,
		[Token(Token = "0x400008E")]
		DocumentEnd,
		[Token(Token = "0x400008F")]
		BlockNode,
		[Token(Token = "0x4000090")]
		BlockNodeOrIndentlessSequence,
		[Token(Token = "0x4000091")]
		FlowNode,
		[Token(Token = "0x4000092")]
		BlockSequenceFirstEntry,
		[Token(Token = "0x4000093")]
		BlockSequenceEntry,
		[Token(Token = "0x4000094")]
		IndentlessSequenceEntry,
		[Token(Token = "0x4000095")]
		BlockMappingFirstKey,
		[Token(Token = "0x4000096")]
		BlockMappingKey,
		[Token(Token = "0x4000097")]
		BlockMappingValue,
		[Token(Token = "0x4000098")]
		FlowSequenceFirstEntry,
		[Token(Token = "0x4000099")]
		FlowSequenceEntry,
		[Token(Token = "0x400009A")]
		FlowSequenceEntryMappingKey,
		[Token(Token = "0x400009B")]
		FlowSequenceEntryMappingValue,
		[Token(Token = "0x400009C")]
		FlowSequenceEntryMappingEnd,
		[Token(Token = "0x400009D")]
		FlowMappingFirstKey,
		[Token(Token = "0x400009E")]
		FlowMappingKey,
		[Token(Token = "0x400009F")]
		FlowMappingValue,
		[Token(Token = "0x40000A0")]
		FlowMappingEmptyValue
	}
	[Token(Token = "0x200002C")]
	public enum ScalarStyle
	{
		[Token(Token = "0x40000A2")]
		Any,
		[Token(Token = "0x40000A3")]
		Plain,
		[Token(Token = "0x40000A4")]
		SingleQuoted,
		[Token(Token = "0x40000A5")]
		DoubleQuoted,
		[Token(Token = "0x40000A6")]
		Literal,
		[Token(Token = "0x40000A7")]
		Folded
	}
	[Serializable]
	[Token(Token = "0x200002D")]
	public class Scanner : IScanner
	{
		[Token(Token = "0x40000A8")]
		private const int MaxVersionNumberLength = 9;

		[Token(Token = "0x40000A9")]
		private const int MaxBufferLength = 8;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly IDictionary<char, char> simpleEscapeCodes;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Stack<int> indents;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly InsertionQueue<Token> tokens;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Stack<SimpleKey> simpleKeys;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly CharacterAnalyzer<LookAheadBuffer> analyzer;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Cursor cursor;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool streamStartProduced;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool streamEndProduced;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int indent;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool simpleKeyAllowed;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int flowLevel;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int tokensParsed;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool tokenAvailable;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Token previous;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581098", Offset = "0x581098")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x581098", Offset = "0x581098")]
		private bool <SkipComments>k__BackingField;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5810D4", Offset = "0x5810D4")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x5810D4", Offset = "0x5810D4")]
		private Token <Current>k__BackingField;

		[Token(Token = "0x1700003F")]
		public bool SkipComments
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0xAF9F98", Offset = "0xAF9F98", VA = "0xAF9F98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581110", Offset = "0x581110")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000141")]
			[Address(RVA = "0xAF9F8C", Offset = "0xAF9F8C", VA = "0xAF9F8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581120", Offset = "0x581120")]
			private set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public Token Current
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0xAF9FA0", Offset = "0xAF9FA0", VA = "0xAF9FA0", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581130", Offset = "0x581130")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000143")]
			[Address(RVA = "0xAF9FA8", Offset = "0xAF9FA8", VA = "0xAF9FA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581140", Offset = "0x581140")]
			private set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public Mark CurrentPosition
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0xAF9FB0", Offset = "0xAF9FB0", VA = "0xAF9FB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xAF6A90", Offset = "0xAF6A90", VA = "0xAF6A90")]
		public Scanner(TextReader input, bool skipComments = true)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xAF9FD8", Offset = "0xAF9FD8", VA = "0xAF9FD8", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xAFA01C", Offset = "0xAFA01C", VA = "0xAFA01C", Slot = "7")]
		public bool MoveNextWithoutConsuming()
		{
			return default(bool);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xAF9FFC", Offset = "0xAF9FFC", VA = "0xAF9FFC", Slot = "8")]
		public void ConsumeCurrent()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xAFA244", Offset = "0xAFA244", VA = "0xAFA244")]
		private char ReadCurrentCharacter()
		{
			return default(char);
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xAFA350", Offset = "0xAFA350", VA = "0xAFA350")]
		private char ReadLine()
		{
			return default(char);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xAFA0D4", Offset = "0xAFA0D4", VA = "0xAFA0D4")]
		private void FetchMoreTokens()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xAFAFF4", Offset = "0xAFAFF4", VA = "0xAFAFF4")]
		private static bool StartsWith(StringBuilder what, char start)
		{
			return default(bool);
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xAFA5BC", Offset = "0xAFA5BC", VA = "0xAFA5BC")]
		private void StaleSimpleKeys()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xAFA7B8", Offset = "0xAFA7B8", VA = "0xAFA7B8")]
		private void FetchNextToken()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xAFC080", Offset = "0xAFC080", VA = "0xAFC080")]
		private bool CheckWhiteSpace()
		{
			return default(bool);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xAFC144", Offset = "0xAFC144", VA = "0xAFC144")]
		private bool IsDocumentIndicator()
		{
			return default(bool);
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xAFA2B8", Offset = "0xAFA2B8", VA = "0xAFA2B8")]
		private void Skip()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xAFA40C", Offset = "0xAFA40C", VA = "0xAFA40C")]
		private void SkipLine()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xAFB1B4", Offset = "0xAFB1B4", VA = "0xAFB1B4")]
		private void ScanToNextToken()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xAFC2D0", Offset = "0xAFC2D0", VA = "0xAFC2D0")]
		private void ProcessComment()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xAFB0C8", Offset = "0xAFB0C8", VA = "0xAFB0C8")]
		private void FetchStreamStart()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xAFB25C", Offset = "0xAFB25C", VA = "0xAFB25C")]
		private void UnrollIndent(int column)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xAFB358", Offset = "0xAFB358", VA = "0xAFB358")]
		private void FetchStreamEnd()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xAFB43C", Offset = "0xAFB43C", VA = "0xAFB43C")]
		private void FetchDirective()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xAFC7AC", Offset = "0xAFC7AC", VA = "0xAFC7AC")]
		private Token ScanDirective()
		{
			return null;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xAFB4C0", Offset = "0xAFB4C0", VA = "0xAFB4C0")]
		private void FetchDocumentIndicator(bool isStartToken)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xAFB5D8", Offset = "0xAFB5D8", VA = "0xAFB5D8")]
		private void FetchFlowCollectionStart(bool isSequenceToken)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xAFD074", Offset = "0xAFD074", VA = "0xAFD074")]
		private void IncreaseFlowLevel()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xAFB6B0", Offset = "0xAFB6B0", VA = "0xAFB6B0")]
		private void FetchFlowCollectionEnd(bool isSequenceToken)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xAFD174", Offset = "0xAFD174", VA = "0xAFD174")]
		private void DecreaseFlowLevel()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xAFB784", Offset = "0xAFB784", VA = "0xAFB784")]
		private void FetchFlowEntry()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xAFB858", Offset = "0xAFB858", VA = "0xAFB858")]
		private void FetchBlockEntry()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xAFB9D0", Offset = "0xAFB9D0", VA = "0xAFB9D0")]
		private void FetchKey()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xAFBB50", Offset = "0xAFBB50", VA = "0xAFBB50")]
		private void FetchValue()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xAFD294", Offset = "0xAFD294", VA = "0xAFD294")]
		private void RollIndent(int column, int number, bool isSequence, Mark position)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xAFBDF4", Offset = "0xAFBDF4", VA = "0xAFBDF4")]
		private void FetchAnchor(bool isAlias)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xAFD554", Offset = "0xAFD554", VA = "0xAFD554")]
		private Token ScanAnchor(bool isAlias)
		{
			return null;
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xAFBE7C", Offset = "0xAFBE7C", VA = "0xAFBE7C")]
		private void FetchTag()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xAFD80C", Offset = "0xAFD80C", VA = "0xAFD80C")]
		private Token ScanTag()
		{
			return null;
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xAFBEF4", Offset = "0xAFBEF4", VA = "0xAFBEF4")]
		private void FetchBlockScalar(bool isLiteral)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xAFDFF8", Offset = "0xAFDFF8", VA = "0xAFDFF8")]
		private Token ScanBlockScalar(bool isLiteral)
		{
			return null;
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xAFE6EC", Offset = "0xAFE6EC", VA = "0xAFE6EC")]
		private int ScanBlockScalarBreaks(int currentIndent, StringBuilder breaks, Mark start, ref Mark end)
		{
			return default(int);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xAFBF80", Offset = "0xAFBF80", VA = "0xAFBF80")]
		private void FetchFlowScalar(bool isSingleQuoted)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xAFE9A0", Offset = "0xAFE9A0", VA = "0xAFE9A0")]
		private Token ScanFlowScalar(bool isSingleQuoted)
		{
			return null;
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xAFC008", Offset = "0xAFC008", VA = "0xAFC008")]
		private void FetchPlainScalar()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xAFF324", Offset = "0xAFF324", VA = "0xAFF324")]
		private Token ScanPlainScalar()
		{
			return null;
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xAFC66C", Offset = "0xAFC66C", VA = "0xAFC66C")]
		private void RemoveSimpleKey()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xAFCA08", Offset = "0xAFCA08", VA = "0xAFCA08")]
		private string ScanDirectiveName(Mark start)
		{
			return null;
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xAFF9D4", Offset = "0xAFF9D4", VA = "0xAFF9D4")]
		private void SkipWhitespaces()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xAFCBC4", Offset = "0xAFCBC4", VA = "0xAFCBC4")]
		private Token ScanVersionDirectiveValue(Mark start)
		{
			return null;
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xAFCD20", Offset = "0xAFCD20", VA = "0xAFCD20")]
		private Token ScanTagDirectiveValue(Mark start)
		{
			return null;
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xAFDB38", Offset = "0xAFDB38", VA = "0xAFDB38")]
		private string ScanTagUri(string head, Mark start)
		{
			return null;
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xAFFE10", Offset = "0xAFFE10", VA = "0xAFFE10")]
		private char ScanUriEscapes(Mark start)
		{
			return default(char);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xAFDD44", Offset = "0xAFDD44", VA = "0xAFDD44")]
		private string ScanTagHandle(bool isDirective, Mark start)
		{
			return null;
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xAFFA4C", Offset = "0xAFFA4C", VA = "0xAFFA4C")]
		private int ScanVersionDirectiveNumber(Mark start)
		{
			return default(int);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xAFCF3C", Offset = "0xAFCF3C", VA = "0xAFCF3C")]
		private void SaveSimpleKey()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002E")]
	public class SemanticErrorException : YamlException
	{
		[Token(Token = "0x6000179")]
		[Address(RVA = "0xB005C8", Offset = "0xB005C8", VA = "0xB005C8")]
		public SemanticErrorException()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xB005D0", Offset = "0xB005D0", VA = "0xB005D0")]
		public SemanticErrorException(string message)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xAF61A4", Offset = "0xAF61A4", VA = "0xAF61A4")]
		public SemanticErrorException(Mark start, Mark end, string message)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xB005D8", Offset = "0xB005D8", VA = "0xB005D8")]
		public SemanticErrorException(string message, Exception inner)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002F")]
	internal class SimpleKey
	{
		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Cursor cursor;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581150", Offset = "0x581150")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x581150", Offset = "0x581150")]
		private bool <IsPossible>k__BackingField;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58118C", Offset = "0x58118C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x58118C", Offset = "0x58118C")]
		private bool <IsRequired>k__BackingField;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5811C8", Offset = "0x5811C8")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x5811C8", Offset = "0x5811C8")]
		private int <TokenNumber>k__BackingField;

		[Token(Token = "0x17000042")]
		public bool IsPossible
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0xAFA7A8", Offset = "0xAFA7A8", VA = "0xAFA7A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581204", Offset = "0x581204")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000180")]
			[Address(RVA = "0xAFB0BC", Offset = "0xAFB0BC", VA = "0xAFB0BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581214", Offset = "0x581214")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public bool IsRequired
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0xAFB0AC", Offset = "0xAFB0AC", VA = "0xAFB0AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581224", Offset = "0x581224")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000182")]
			[Address(RVA = "0xB005E0", Offset = "0xB005E0", VA = "0xB005E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581234", Offset = "0x581234")]
			private set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public int TokenNumber
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0xAFA7B0", Offset = "0xAFA7B0", VA = "0xAFA7B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581244", Offset = "0x581244")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000184")]
			[Address(RVA = "0xB005EC", Offset = "0xB005EC", VA = "0xB005EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581254", Offset = "0x581254")]
			private set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public int Index
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0xAFB084", Offset = "0xAFB084", VA = "0xAFB084")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000046")]
		public int Line
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0xAFB05C", Offset = "0xAFB05C", VA = "0xAFB05C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000047")]
		public int LineOffset
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0xAFD484", Offset = "0xAFD484", VA = "0xAFD484")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000048")]
		public Mark Mark
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0xAFD45C", Offset = "0xAFD45C", VA = "0xAFD45C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xAFC588", Offset = "0xAFC588", VA = "0xAFC588")]
		public SimpleKey()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xB00190", Offset = "0xB00190", VA = "0xB00190")]
		public SimpleKey(bool isPossible, bool isRequired, int tokenNumber, Cursor cursor)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000030")]
	internal class StringLookAheadBuffer : ILookAheadBuffer
	{
		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string value;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581264", Offset = "0x581264")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x581264", Offset = "0x581264")]
		private int <Position>k__BackingField;

		[Token(Token = "0x17000049")]
		public int Position
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0xAEDFCC", Offset = "0xAEDFCC", VA = "0xAEDFCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5812A0", Offset = "0x5812A0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600018B")]
			[Address(RVA = "0xB005F4", Offset = "0xB005F4", VA = "0xB005F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5812B0", Offset = "0x5812B0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public int Length
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0xAEDFD4", Offset = "0xAEDFD4", VA = "0xAEDFD4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004B")]
		public bool EndOfInput
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0xB005FC", Offset = "0xB005FC", VA = "0xB005FC", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xAEDDFC", Offset = "0xAEDDFC", VA = "0xAEDDFC")]
		public StringLookAheadBuffer(string value)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xB00674", Offset = "0xB00674", VA = "0xB00674", Slot = "5")]
		public char Peek(int offset)
		{
			return default(char);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xB00638", Offset = "0xB00638", VA = "0xB00638")]
		private bool IsOutside(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xB006EC", Offset = "0xB006EC", VA = "0xB006EC", Slot = "6")]
		public void Skip(int length)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000031")]
	public class SyntaxErrorException : YamlException
	{
		[Token(Token = "0x6000191")]
		[Address(RVA = "0xB00794", Offset = "0xB00794", VA = "0xB00794")]
		public SyntaxErrorException()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xB0079C", Offset = "0xB0079C", VA = "0xB0079C")]
		public SyntaxErrorException(string message)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xAFB0B4", Offset = "0xAFB0B4", VA = "0xAFB0B4")]
		public SyntaxErrorException(Mark start, Mark end, string message)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xB007A4", Offset = "0xB007A4", VA = "0xB007A4")]
		public SyntaxErrorException(string message, Exception inner)
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class TagDirectiveCollection : KeyedCollection<string, TagDirective>
	{
		[Token(Token = "0x6000195")]
		[Address(RVA = "0xAEC8F8", Offset = "0xAEC8F8", VA = "0xAEC8F8")]
		public TagDirectiveCollection()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xB007AC", Offset = "0xB007AC", VA = "0xB007AC")]
		public TagDirectiveCollection(IEnumerable<TagDirective> tagDirectives)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xB00A40", Offset = "0xB00A40", VA = "0xB00A40", Slot = "37")]
		protected override string GetKeyForItem(TagDirective item)
		{
			return null;
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xAEFE7C", Offset = "0xAEFE7C", VA = "0xAEFE7C")]
		public new bool Contains(TagDirective directive)
		{
			return default(bool);
		}
	}
}
namespace YamlDotNet.Core.Tokens
{
	[Serializable]
	[Token(Token = "0x2000033")]
	public class Anchor : Token
	{
		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string value;

		[Token(Token = "0x1700004C")]
		public string Value
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0xAF9F74", Offset = "0xAF9F74", VA = "0xAF9F74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xB00A68", Offset = "0xB00A68", VA = "0xB00A68")]
		public Anchor(string value)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xAFD7CC", Offset = "0xAFD7CC", VA = "0xAFD7CC")]
		public Anchor(string value, Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000034")]
	public class AnchorAlias : Token
	{
		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string value;

		[Token(Token = "0x1700004D")]
		public string Value
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0xAF9F5C", Offset = "0xAF9F5C", VA = "0xAF9F5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xB00B2C", Offset = "0xB00B2C", VA = "0xB00B2C")]
		public AnchorAlias(string value)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xAFD78C", Offset = "0xAFD78C", VA = "0xAFD78C")]
		public AnchorAlias(string value, Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000035")]
	public class BlockEnd : Token
	{
		[Token(Token = "0x600019F")]
		[Address(RVA = "0xB00BB8", Offset = "0xB00BB8", VA = "0xB00BB8")]
		public BlockEnd()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xAFC634", Offset = "0xAFC634", VA = "0xAFC634")]
		public BlockEnd(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000036")]
	public class BlockEntry : Token
	{
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xB00C34", Offset = "0xB00C34", VA = "0xB00C34")]
		public BlockEntry()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xAFD3EC", Offset = "0xAFD3EC", VA = "0xAFD3EC")]
		public BlockEntry(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000037")]
	public class BlockMappingStart : Token
	{
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xB00CB0", Offset = "0xB00CB0", VA = "0xB00CB0")]
		public BlockMappingStart()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xAFD51C", Offset = "0xAFD51C", VA = "0xAFD51C")]
		public BlockMappingStart(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000038")]
	public class BlockSequenceStart : Token
	{
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xB00D2C", Offset = "0xB00D2C", VA = "0xB00D2C")]
		public BlockSequenceStart()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xAFD4E4", Offset = "0xAFD4E4", VA = "0xAFD4E4")]
		public BlockSequenceStart(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000039")]
	public class Comment : Token
	{
		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5812C0", Offset = "0x5812C0")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x5812C0", Offset = "0x5812C0")]
		private string <Value>k__BackingField;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5812FC", Offset = "0x5812FC")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x5812FC", Offset = "0x5812FC")]
		private bool <IsInline>k__BackingField;

		[Token(Token = "0x1700004E")]
		public string Value
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0xAF6EB0", Offset = "0xAF6EB0", VA = "0xAF6EB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581338", Offset = "0x581338")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0xB00E4C", Offset = "0xB00E4C", VA = "0xB00E4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581348", Offset = "0x581348")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public bool IsInline
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0xAF6EB8", Offset = "0xAF6EB8", VA = "0xAF6EB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581358", Offset = "0x581358")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0xB00E40", Offset = "0xB00E40", VA = "0xB00E40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581368", Offset = "0x581368")]
			private set
			{
			}
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xB00DA8", Offset = "0xB00DA8", VA = "0xB00DA8")]
		public Comment(string value, bool isInline)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xAFC534", Offset = "0xAFC534", VA = "0xAFC534")]
		public Comment(string value, bool isInline, Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003A")]
	public class DocumentEnd : Token
	{
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xB00E54", Offset = "0xB00E54", VA = "0xB00E54")]
		public DocumentEnd()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xAFCF04", Offset = "0xAFCF04", VA = "0xAFCF04")]
		public DocumentEnd(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003B")]
	public class DocumentStart : Token
	{
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xB00ED0", Offset = "0xB00ED0", VA = "0xB00ED0")]
		public DocumentStart()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xAFCECC", Offset = "0xAFCECC", VA = "0xAFCECC")]
		public DocumentStart(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003C")]
	public class FlowEntry : Token
	{
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xB00F4C", Offset = "0xB00F4C", VA = "0xB00F4C")]
		public FlowEntry()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xAFD25C", Offset = "0xAFD25C", VA = "0xAFD25C")]
		public FlowEntry(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003D")]
	public class FlowMappingEnd : Token
	{
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xB00FC8", Offset = "0xB00FC8", VA = "0xB00FC8")]
		public FlowMappingEnd()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xAFD224", Offset = "0xAFD224", VA = "0xAFD224")]
		public FlowMappingEnd(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003E")]
	public class FlowMappingStart : Token
	{
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xB01044", Offset = "0xB01044", VA = "0xB01044")]
		public FlowMappingStart()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xAFD13C", Offset = "0xAFD13C", VA = "0xAFD13C")]
		public FlowMappingStart(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003F")]
	public class FlowSequenceEnd : Token
	{
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xB010C0", Offset = "0xB010C0", VA = "0xB010C0")]
		public FlowSequenceEnd()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xAFD1EC", Offset = "0xAFD1EC", VA = "0xAFD1EC")]
		public FlowSequenceEnd(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000040")]
	public class FlowSequenceStart : Token
	{
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xB0113C", Offset = "0xB0113C", VA = "0xB0113C")]
		public FlowSequenceStart()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xAFD104", Offset = "0xAFD104", VA = "0xAFD104")]
		public FlowSequenceStart(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000041")]
	public class Key : Token
	{
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xB011B8", Offset = "0xB011B8", VA = "0xB011B8")]
		public Key()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xAFD424", Offset = "0xAFD424", VA = "0xAFD424")]
		public Key(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000042")]
	public class Scalar : Token
	{
		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string value;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly ScalarStyle style;

		[Token(Token = "0x17000050")]
		public string Value
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0xAF9F84", Offset = "0xAF9F84", VA = "0xAF9F84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public ScalarStyle Style
		{
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0xAF9F7C", Offset = "0xAF9F7C", VA = "0xAF9F7C")]
			get
			{
				return default(ScalarStyle);
			}
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xB01234", Offset = "0xB01234", VA = "0xB01234")]
		public Scalar(string value)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xB0123C", Offset = "0xB0123C", VA = "0xB0123C")]
		public Scalar(string value, ScalarStyle style)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xAFE950", Offset = "0xAFE950", VA = "0xAFE950")]
		public Scalar(string value, ScalarStyle style, Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000043")]
	public class StreamEnd : Token
	{
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xB012D0", Offset = "0xB012D0", VA = "0xB012D0")]
		public StreamEnd()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xAFC774", Offset = "0xAFC774", VA = "0xAFC774")]
		public StreamEnd(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000044")]
	public class StreamStart : Token
	{
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xB0134C", Offset = "0xB0134C", VA = "0xB0134C")]
		public StreamStart()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xAFC5FC", Offset = "0xAFC5FC", VA = "0xAFC5FC")]
		public StreamStart(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000045")]
	public class Tag : Token
	{
		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string handle;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly string suffix;

		[Token(Token = "0x17000052")]
		public string Handle
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0xAF9F64", Offset = "0xAF9F64", VA = "0xAF9F64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public string Suffix
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0xAF9F6C", Offset = "0xAF9F6C", VA = "0xAF9F6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xB013C8", Offset = "0xB013C8", VA = "0xB013C8")]
		public Tag(string handle, string suffix)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xAFDFAC", Offset = "0xAFDFAC", VA = "0xAFDFAC")]
		public Tag(string handle, string suffix, Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000046")]
	public class TagDirective : Token
	{
		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string handle;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly string prefix;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Regex tagHandleValidator;

		[Token(Token = "0x17000054")]
		public string Handle
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0xAEE008", Offset = "0xAEE008", VA = "0xAEE008")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		public string Prefix
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0xAEE000", Offset = "0xAEE000", VA = "0xAEE000")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xAEC1DC", Offset = "0xAEC1DC", VA = "0xAEC1DC")]
		public TagDirective(string handle, string prefix)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xAFFC44", Offset = "0xAFFC44", VA = "0xAFFC44")]
		public TagDirective(string handle, string prefix, Mark start, Mark end)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xB01458", Offset = "0xB01458", VA = "0xB01458", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xB01530", Offset = "0xB01530", VA = "0xB01530", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xB0158C", Offset = "0xB0158C", VA = "0xB0158C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000047")]
	public abstract class Token
	{
		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Mark start;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Mark end;

		[Token(Token = "0x17000056")]
		public Mark Start
		{
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0xAF6EC0", Offset = "0xAF6EC0", VA = "0xAF6EC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		public Mark End
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0xAF6EC8", Offset = "0xAF6EC8", VA = "0xAF6EC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xB00AF4", Offset = "0xB00AF4", VA = "0xB00AF4")]
		protected Token(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000048")]
	public class Value : Token
	{
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xB0176C", Offset = "0xB0176C", VA = "0xB0176C")]
		public Value()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xAFD4AC", Offset = "0xAFD4AC", VA = "0xAFD4AC")]
		public Value(Mark start, Mark end)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000049")]
	public class VersionDirective : Token
	{
		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Version version;

		[Token(Token = "0x17000058")]
		public Version Version
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0xAEFE64", Offset = "0xAEFE64", VA = "0xAEFE64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xB017E8", Offset = "0xB017E8", VA = "0xB017E8")]
		public VersionDirective(Version version)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xAFFC04", Offset = "0xAFFC04", VA = "0xAFFC04")]
		public VersionDirective(Version version, Mark start, Mark end)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xB01874", Offset = "0xB01874", VA = "0xB01874", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xB0192C", Offset = "0xB0192C", VA = "0xB0192C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace YamlDotNet.Core
{
	[Serializable]
	[Token(Token = "0x200004A")]
	public class Version
	{
		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581378", Offset = "0x581378")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x581378", Offset = "0x581378")]
		private int <Major>k__BackingField;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5813B4", Offset = "0x5813B4")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x5813B4", Offset = "0x5813B4")]
		private int <Minor>k__BackingField;

		[Token(Token = "0x17000059")]
		public int Major
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0xAEFE6C", Offset = "0xAEFE6C", VA = "0xAEFE6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5813F0", Offset = "0x5813F0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0xB0195C", Offset = "0xB0195C", VA = "0xB0195C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581400", Offset = "0x581400")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public int Minor
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0xAEFE74", Offset = "0xAEFE74", VA = "0xAEFE74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581410", Offset = "0x581410")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0xB01964", Offset = "0xB01964", VA = "0xB01964")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581420", Offset = "0x581420")]
			private set
			{
			}
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xAFFBCC", Offset = "0xAFFBCC", VA = "0xAFFBCC")]
		public Version(int major, int minor)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xB0196C", Offset = "0xB0196C", VA = "0xB0196C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xB01A18", Offset = "0xB01A18", VA = "0xB01A18", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200004B")]
	public class YamlException : Exception
	{
		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581430", Offset = "0x581430")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x581430", Offset = "0x581430")]
		private Mark <Start>k__BackingField;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58146C", Offset = "0x58146C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x58146C", Offset = "0x58146C")]
		private Mark <End>k__BackingField;

		[Token(Token = "0x1700005B")]
		public Mark Start
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0xB01B38", Offset = "0xB01B38", VA = "0xB01B38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5814A8", Offset = "0x5814A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0xB01B28", Offset = "0xB01B28", VA = "0xB01B28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5814B8", Offset = "0x5814B8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public Mark End
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0xB01B40", Offset = "0xB01B40", VA = "0xB01B40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5814C8", Offset = "0x5814C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0xB01B30", Offset = "0xB01B30", VA = "0xB01B30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5814D8", Offset = "0x5814D8")]
			private set
			{
			}
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xAEC050", Offset = "0xAEC050", VA = "0xAEC050")]
		public YamlException()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xAEC060", Offset = "0xAEC060", VA = "0xAEC060")]
		public YamlException(string message)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xAEC070", Offset = "0xAEC070", VA = "0xAEC070")]
		public YamlException(Mark start, Mark end, string message)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xB01A6C", Offset = "0xB01A6C", VA = "0xB01A6C")]
		public YamlException(Mark start, Mark end, string message, Exception innerException)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xAEC080", Offset = "0xAEC080", VA = "0xAEC080")]
		public YamlException(string message, Exception inner)
		{
		}
	}
}
namespace YamlDotNet.Helpers
{
	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x5814E8", Offset = "0x5814E8")]
	internal sealed class GenericCollectionToNonGenericAdapter : IList, IEnumerable, ICollection
	{
		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly object genericCollection;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly MethodInfo addMethod;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly MethodInfo indexerSetter;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly MethodInfo countGetter;

		[Token(Token = "0x1700005D")]
		public bool IsFixedSize
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0xB02164", Offset = "0xB02164", VA = "0xB02164", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005E")]
		public bool IsReadOnly
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0xB021C8", Offset = "0xB021C8", VA = "0xB021C8", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		public object Item
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0xB022F4", Offset = "0xB022F4", VA = "0xB022F4", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0xB02358", Offset = "0xB02358", VA = "0xB02358", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public int Count
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0xB02508", Offset = "0xB02508", VA = "0xB02508", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000061")]
		public bool IsSynchronized
		{
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0xB0256C", Offset = "0xB0256C", VA = "0xB0256C", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000062")]
		public object SyncRoot
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0xB025D0", Offset = "0xB025D0", VA = "0xB025D0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xB01CA4", Offset = "0xB01CA4", VA = "0xB01CA4")]
		public GenericCollectionToNonGenericAdapter(object genericCollection, Type genericCollectionType, Type genericListType)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xB01E58", Offset = "0xB01E58", VA = "0xB01E58", Slot = "8")]
		public int Add(object value)
		{
			return default(int);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xB01FD4", Offset = "0xB01FD4", VA = "0xB01FD4", Slot = "9")]
		public void Clear()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xB02038", Offset = "0xB02038", VA = "0xB02038", Slot = "10")]
		public bool Contains(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xB0209C", Offset = "0xB0209C", VA = "0xB0209C", Slot = "11")]
		public int IndexOf(object value)
		{
			return default(int);
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xB02100", Offset = "0xB02100", VA = "0xB02100", Slot = "12")]
		public void Insert(int index, object value)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xB0222C", Offset = "0xB0222C", VA = "0xB0222C", Slot = "13")]
		public void Remove(object value)
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xB02290", Offset = "0xB02290", VA = "0xB02290", Slot = "14")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xB024A4", Offset = "0xB024A4", VA = "0xB024A4", Slot = "19")]
		public void CopyTo(Array array, int index)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xB02634", Offset = "0xB02634", VA = "0xB02634", Slot = "15")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x200004D")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x581520", Offset = "0x581520")]
	internal sealed class GenericDictionaryToNonGenericAdapter : IDictionary, IEnumerable, ICollection
	{
		[Token(Token = "0x200004E")]
		private class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
		{
			[Token(Token = "0x40000D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly IEnumerator enumerator;

			[Token(Token = "0x40000DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly MethodInfo getKeyMethod;

			[Token(Token = "0x40000DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private readonly MethodInfo getValueMethod;

			[Token(Token = "0x1700006B")]
			public DictionaryEntry Entry
			{
				[Token(Token = "0x600020F")]
				[Address(RVA = "0xB03320", Offset = "0xB03320", VA = "0xB03320", Slot = "4")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Token(Token = "0x1700006C")]
			public object Key
			{
				[Token(Token = "0x6000210")]
				[Address(RVA = "0xB03370", Offset = "0xB03370", VA = "0xB03370", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006D")]
			public object Value
			{
				[Token(Token = "0x6000211")]
				[Address(RVA = "0xB03440", Offset = "0xB03440", VA = "0xB03440", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006E")]
			public object Current
			{
				[Token(Token = "0x6000212")]
				[Address(RVA = "0xB03514", Offset = "0xB03514", VA = "0xB03514", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600020E")]
			[Address(RVA = "0xB029F8", Offset = "0xB029F8", VA = "0xB029F8")]
			public DictionaryEnumerator(object genericDictionary, Type genericDictionaryType)
			{
			}

			[Token(Token = "0x6000213")]
			[Address(RVA = "0xB03580", Offset = "0xB03580", VA = "0xB03580", Slot = "8")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000214")]
			[Address(RVA = "0xB03634", Offset = "0xB03634", VA = "0xB03634", Slot = "9")]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly object genericDictionary;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Type genericDictionaryType;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly MethodInfo indexerSetter;

		[Token(Token = "0x17000063")]
		public bool IsFixedSize
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0xB02CB0", Offset = "0xB02CB0", VA = "0xB02CB0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000064")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0xB02D14", Offset = "0xB02D14", VA = "0xB02D14", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000065")]
		public ICollection Keys
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0xB02D78", Offset = "0xB02D78", VA = "0xB02D78", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000066")]
		public ICollection Values
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0xB02E40", Offset = "0xB02E40", VA = "0xB02E40", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		public object Item
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0xB02EA4", Offset = "0xB02EA4", VA = "0xB02EA4", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000208")]
			[Address(RVA = "0xB02F08", Offset = "0xB02F08", VA = "0xB02F08", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public int Count
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0xB0308C", Offset = "0xB0308C", VA = "0xB0308C", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000069")]
		public bool IsSynchronized
		{
			[Token(Token = "0x600020B")]
			[Address(RVA = "0xB030F0", Offset = "0xB030F0", VA = "0xB030F0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006A")]
		public object SyncRoot
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0xB03154", Offset = "0xB03154", VA = "0xB03154", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xB0279C", Offset = "0xB0279C", VA = "0xB0279C")]
		public GenericDictionaryToNonGenericAdapter(object genericDictionary, Type genericDictionaryType)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xB0285C", Offset = "0xB0285C", VA = "0xB0285C", Slot = "6")]
		public void Add(object key, object value)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xB028C0", Offset = "0xB028C0", VA = "0xB028C0", Slot = "15")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xB02924", Offset = "0xB02924", VA = "0xB02924", Slot = "7")]
		public bool Contains(object key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xB02988", Offset = "0xB02988", VA = "0xB02988", Slot = "8")]
		public IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xB02DDC", Offset = "0xB02DDC", VA = "0xB02DDC", Slot = "9")]
		public void Remove(object key)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xB03028", Offset = "0xB03028", VA = "0xB03028", Slot = "14")]
		public void CopyTo(Array array, int index)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xB031B8", Offset = "0xB031B8", VA = "0xB031B8", Slot = "10")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
namespace YamlDotNet
{
	[Token(Token = "0x200004F")]
	internal static class StandardRegexOptions
	{
		[Token(Token = "0x40000DC")]
		public const RegexOptions Compiled = RegexOptions.None;
	}
	[Token(Token = "0x2000050")]
	internal static class ReflectionExtensions
	{
		[Token(Token = "0x20000BB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581638", Offset = "0x581638")]
		private sealed class <GetPublicProperties>c__AnonStorey0
		{
			[Token(Token = "0x400015F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal BindingFlags instancePublic;

			[Token(Token = "0x6000447")]
			[Address(RVA = "0xB03AD4", Offset = "0xB03AD4", VA = "0xB03AD4")]
			public <GetPublicProperties>c__AnonStorey0()
			{
			}

			[Token(Token = "0x6000448")]
			[Address(RVA = "0xB03D98", Offset = "0xB03D98", VA = "0xB03D98")]
			internal IEnumerable<PropertyInfo> <>m__0(Type i)
			{
				return null;
			}
		}

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly FieldInfo remoteStackTraceField;

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xB03738", Offset = "0xB03738", VA = "0xB03738")]
		public static bool IsValueType(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xB03764", Offset = "0xB03764", VA = "0xB03764")]
		public static bool IsGenericType(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xB03798", Offset = "0xB03798", VA = "0xB03798")]
		public static bool IsInterface(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xB037C4", Offset = "0xB037C4", VA = "0xB037C4")]
		public static bool IsEnum(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xB037F0", Offset = "0xB037F0", VA = "0xB037F0")]
		public static bool HasDefaultConstructor(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xB038AC", Offset = "0xB038AC", VA = "0xB038AC")]
		public static TypeCode GetTypeCode(this Type type)
		{
			return default(TypeCode);
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xB01E24", Offset = "0xB01E24", VA = "0xB01E24")]
		public static PropertyInfo GetPublicProperty(this Type type, string name)
		{
			return null;
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xB03918", Offset = "0xB03918", VA = "0xB03918")]
		public static IEnumerable<PropertyInfo> GetPublicProperties(this Type type)
		{
			return null;
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xB03ADC", Offset = "0xB03ADC", VA = "0xB03ADC")]
		public static IEnumerable<MethodInfo> GetPublicStaticMethods(this Type type)
		{
			return null;
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xB03B14", Offset = "0xB03B14", VA = "0xB03B14")]
		public static MethodInfo GetPublicStaticMethod(this Type type, string name, params Type[] parameterTypes)
		{
			return null;
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xB01DEC", Offset = "0xB01DEC", VA = "0xB01DEC")]
		public static MethodInfo GetPublicInstanceMethod(this Type type, string name)
		{
			return null;
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xB03B64", Offset = "0xB03B64", VA = "0xB03B64")]
		public static Exception Unwrap(this TargetInvocationException ex)
		{
			return null;
		}
	}
	[Token(Token = "0x2000051")]
	internal sealed class CultureInfoAdapter : CultureInfo
	{
		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly IFormatProvider _provider;

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xB01B48", Offset = "0xB01B48", VA = "0xB01B48")]
		public CultureInfoAdapter(CultureInfo baseCulture, IFormatProvider provider)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xB01BE4", Offset = "0xB01BE4", VA = "0xB01BE4", Slot = "18")]
		public override object GetFormat(Type formatType)
		{
			return null;
		}
	}
	[Token(Token = "0x2000052")]
	internal static class PropertyInfoExtensions
	{
		[Token(Token = "0x6000224")]
		[Address(RVA = "0xB036E8", Offset = "0xB036E8", VA = "0xB036E8")]
		public static object ReadValue(this PropertyInfo property, object target)
		{
			return null;
		}
	}
}
namespace YamlDotNet.RepresentationModel
{
	[Token(Token = "0x2000053")]
	internal class DocumentLoadingState
	{
		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IDictionary<string, YamlNode> anchors;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IList<YamlNode> nodesWithUnresolvedAliases;

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xB03DD4", Offset = "0xB03DD4", VA = "0xB03DD4")]
		public DocumentLoadingState()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xB03E6C", Offset = "0xB03E6C", VA = "0xB03E6C")]
		public void AddAnchor(YamlNode node)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xB04168", Offset = "0xB04168", VA = "0xB04168")]
		public YamlNode GetNode(string anchor, bool throwException, Mark start, Mark end)
		{
			return null;
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xB04388", Offset = "0xB04388", VA = "0xB04388")]
		public void AddNodeWithUnresolvedAliases(YamlNode node)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xB0444C", Offset = "0xB0444C", VA = "0xB0444C")]
		public void ResolveAliases()
		{
		}
	}
	[Token(Token = "0x2000054")]
	internal class EmitterState
	{
		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly HashSet<string> emittedAnchors;

		[Token(Token = "0x1700006F")]
		public HashSet<string> EmittedAnchors
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0xB04744", Offset = "0xB04744", VA = "0xB04744")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xB046D4", Offset = "0xB046D4", VA = "0xB046D4")]
		public EmitterState()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public interface IYamlVisitor
	{
		[Token(Token = "0x600022C")]
		void Visit(YamlStream stream);

		[Token(Token = "0x600022D")]
		void Visit(YamlDocument document);

		[Token(Token = "0x600022E")]
		void Visit(YamlScalarNode scalar);

		[Token(Token = "0x600022F")]
		void Visit(YamlSequenceNode sequence);

		[Token(Token = "0x6000230")]
		void Visit(YamlMappingNode mapping);
	}
	[Serializable]
	[Token(Token = "0x2000056")]
	internal class YamlAliasNode : YamlNode
	{
		[Token(Token = "0x20000BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581668", Offset = "0x581668")]
		private sealed class <>c__Iterator0 : IEnumerable, IEnumerable<YamlNode>, IEnumerator, IDisposable, IEnumerator<YamlNode>
		{
			[Token(Token = "0x4000160")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal YamlAliasNode $this;

			[Token(Token = "0x4000161")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal YamlNode $current;

			[Token(Token = "0x4000162")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal bool $disposing;

			[Token(Token = "0x4000163")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal int $PC;

			[Token(Token = "0x170000BB")]
			private YamlNode System.Collections.Generic.IEnumerator<YamlDotNet.RepresentationModel.YamlNode>.Current
			{
				[Token(Token = "0x600044B")]
				[Address(RVA = "0xB04C00", Offset = "0xB04C00", VA = "0xB04C00", Slot = "10")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600044C")]
				[Address(RVA = "0xB04C08", Offset = "0xB04C08", VA = "0xB04C08", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000449")]
			[Address(RVA = "0xB04B94", Offset = "0xB04B94", VA = "0xB04B94")]
			[DebuggerHidden]
			public <>c__Iterator0()
			{
			}

			[Token(Token = "0x600044A")]
			[Address(RVA = "0xB04B9C", Offset = "0xB04B9C", VA = "0xB04B9C", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600044D")]
			[Address(RVA = "0xB04C10", Offset = "0xB04C10", VA = "0xB04C10", Slot = "9")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x600044E")]
			[Address(RVA = "0xB04C24", Offset = "0xB04C24", VA = "0xB04C24", Slot = "8")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			[Token(Token = "0x600044F")]
			[Address(RVA = "0xB04C88", Offset = "0xB04C88", VA = "0xB04C88", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000450")]
			[Address(RVA = "0xB04C8C", Offset = "0xB04C8C", VA = "0xB04C8C", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator<YamlNode> System.Collections.Generic.IEnumerable<YamlDotNet.RepresentationModel.YamlNode>.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		public override IEnumerable<YamlNode> AllNodes
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0xB04B10", Offset = "0xB04B10", VA = "0xB04B10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xB0474C", Offset = "0xB0474C", VA = "0xB0474C")]
		internal YamlAliasNode(string anchor)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xB04788", Offset = "0xB04788", VA = "0xB04788", Slot = "4")]
		internal override void ResolveAliases(DocumentLoadingState state)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xB047F8", Offset = "0xB047F8", VA = "0xB047F8", Slot = "5")]
		internal override void Emit(IEmitter emitter, EmitterState state)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xB04868", Offset = "0xB04868", VA = "0xB04868", Slot = "6")]
		public override void Accept(IYamlVisitor visitor)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xB048D8", Offset = "0xB048D8", VA = "0xB048D8", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xB04A5C", Offset = "0xB04A5C", VA = "0xB04A5C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xB04A94", Offset = "0xB04A94", VA = "0xB04A94", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000057")]
	public class YamlDocument
	{
		[Token(Token = "0x2000058")]
		private class AnchorAssigningVisitor : YamlVisitor
		{
			[Token(Token = "0x40000E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly HashSet<string> existingAnchors;

			[Token(Token = "0x40000E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly Dictionary<YamlNode, bool> visitedNodes;

			[Token(Token = "0x6000242")]
			[Address(RVA = "0xB05200", Offset = "0xB05200", VA = "0xB05200")]
			public AnchorAssigningVisitor()
			{
			}

			[Token(Token = "0x6000243")]
			[Address(RVA = "0xB05298", Offset = "0xB05298", VA = "0xB05298")]
			public void AssignAnchors(YamlDocument document)
			{
			}

			[Token(Token = "0x6000244")]
			[Address(RVA = "0xB05948", Offset = "0xB05948", VA = "0xB05948")]
			private void VisitNode(YamlNode node)
			{
			}

			[Token(Token = "0x6000245")]
			[Address(RVA = "0xB05A9C", Offset = "0xB05A9C", VA = "0xB05A9C", Slot = "13")]
			protected override void Visit(YamlScalarNode scalar)
			{
			}

			[Token(Token = "0x6000246")]
			[Address(RVA = "0xB05AA0", Offset = "0xB05AA0", VA = "0xB05AA0", Slot = "17")]
			protected override void Visit(YamlMappingNode mapping)
			{
			}

			[Token(Token = "0x6000247")]
			[Address(RVA = "0xB05AA4", Offset = "0xB05AA4", VA = "0xB05AA4", Slot = "15")]
			protected override void Visit(YamlSequenceNode sequence)
			{
			}
		}

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5816E8", Offset = "0x5816E8")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x5816E8", Offset = "0x5816E8")]
		private YamlNode <RootNode>k__BackingField;

		[Token(Token = "0x17000071")]
		public YamlNode RootNode
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0xB05190", Offset = "0xB05190", VA = "0xB05190")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581724", Offset = "0x581724")]
			get
			{
				return null;
			}
			[Token(Token = "0x600023D")]
			[Address(RVA = "0xB04D50", Offset = "0xB04D50", VA = "0xB04D50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581734", Offset = "0x581734")]
			private set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public IEnumerable<YamlNode> AllNodes
		{
			[Token(Token = "0x6000241")]
			[Address(RVA = "0xB05910", Offset = "0xB05910", VA = "0xB05910")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xB04D24", Offset = "0xB04D24", VA = "0xB04D24")]
		public YamlDocument(YamlNode rootNode)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xB04D58", Offset = "0xB04D58", VA = "0xB04D58")]
		public YamlDocument(string rootNode)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xB04E00", Offset = "0xB04E00", VA = "0xB04E00")]
		internal YamlDocument(EventReader events)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xB05198", Offset = "0xB05198", VA = "0xB05198")]
		private void AssignAnchors()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xB0552C", Offset = "0xB0552C", VA = "0xB0552C")]
		internal void Save(IEmitter emitter, bool assignAnchors = true)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xB05850", Offset = "0xB05850", VA = "0xB05850")]
		public void Accept(IYamlVisitor visitor)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000059")]
	public class YamlMappingNode : YamlNode, IEnumerable<KeyValuePair<YamlNode, YamlNode>>, IEnumerable
	{
		[Token(Token = "0x20000BD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5817C0", Offset = "0x5817C0")]
		private sealed class <>c__Iterator0 : IEnumerable, IEnumerable<YamlNode>, IEnumerator, IDisposable, IEnumerator<YamlNode>
		{
			[Token(Token = "0x4000164")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal IEnumerator<KeyValuePair<YamlNode, YamlNode>> $locvar0;

			[Token(Token = "0x4000165")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal KeyValuePair<YamlNode, YamlNode> <child>__1;

			[Token(Token = "0x4000166")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal IEnumerator<YamlNode> $locvar1;

			[Token(Token = "0x4000167")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal YamlNode <node>__2;

			[Token(Token = "0x4000168")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal IEnumerator<YamlNode> $locvar2;

			[Token(Token = "0x4000169")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal YamlNode <node>__3;

			[Token(Token = "0x400016A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal YamlMappingNode $this;

			[Token(Token = "0x400016B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal YamlNode $current;

			[Token(Token = "0x400016C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal bool $disposing;

			[Token(Token = "0x400016D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			internal int $PC;

			[Token(Token = "0x170000BD")]
			private YamlNode System.Collections.Generic.IEnumerator<YamlDotNet.RepresentationModel.YamlNode>.Current
			{
				[Token(Token = "0x6000453")]
				[Address(RVA = "0xB08D1C", Offset = "0xB08D1C", VA = "0xB08D1C", Slot = "10")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000454")]
				[Address(RVA = "0xB08D24", Offset = "0xB08D24", VA = "0xB08D24", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000451")]
			[Address(RVA = "0xB08034", Offset = "0xB08034", VA = "0xB08034")]
			[DebuggerHidden]
			public <>c__Iterator0()
			{
			}

			[Token(Token = "0x6000452")]
			[Address(RVA = "0xB084CC", Offset = "0xB084CC", VA = "0xB084CC", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000455")]
			[Address(RVA = "0xB08D2C", Offset = "0xB08D2C", VA = "0xB08D2C", Slot = "9")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000456")]
			[Address(RVA = "0xB08F6C", Offset = "0xB08F6C", VA = "0xB08F6C", Slot = "8")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0xB08FD0", Offset = "0xB08FD0", VA = "0xB08FD0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000458")]
			[Address(RVA = "0xB08FD4", Offset = "0xB08FD4", VA = "0xB08FD4", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator<YamlNode> System.Collections.Generic.IEnumerable<YamlDotNet.RepresentationModel.YamlNode>.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly IDictionary<YamlNode, YamlNode> children;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581744", Offset = "0x581744")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x581744", Offset = "0x581744")]
		private MappingStyle <Style>k__BackingField;

		[Token(Token = "0x17000073")]
		public IDictionary<YamlNode, YamlNode> Children
		{
			[Token(Token = "0x600024E")]
			[Address(RVA = "0xB066A8", Offset = "0xB066A8", VA = "0xB066A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		public MappingStyle Style
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0xB066B0", Offset = "0xB066B0", VA = "0xB066B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5817A0", Offset = "0x5817A0")]
			get
			{
				return default(MappingStyle);
			}
			[Token(Token = "0x6000250")]
			[Address(RVA = "0xB066B8", Offset = "0xB066B8", VA = "0xB066B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5817B0", Offset = "0x5817B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public override IEnumerable<YamlNode> AllNodes
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0xB07FB0", Offset = "0xB07FB0", VA = "0xB07FB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xB05AA8", Offset = "0xB05AA8", VA = "0xB05AA8")]
		internal YamlMappingNode(EventReader events, DocumentLoadingState state)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xB05E64", Offset = "0xB05E64", VA = "0xB05E64")]
		public YamlMappingNode()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xB05ED4", Offset = "0xB05ED4", VA = "0xB05ED4")]
		public YamlMappingNode(params KeyValuePair<YamlNode, YamlNode>[] children)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xB05ED8", Offset = "0xB05ED8", VA = "0xB05ED8")]
		public YamlMappingNode(IEnumerable<KeyValuePair<YamlNode, YamlNode>> children)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xB06208", Offset = "0xB06208", VA = "0xB06208")]
		public YamlMappingNode(params YamlNode[] children)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xB0620C", Offset = "0xB0620C", VA = "0xB0620C")]
		public YamlMappingNode(IEnumerable<YamlNode> children)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xB065E0", Offset = "0xB065E0", VA = "0xB065E0")]
		public void Add(YamlNode key, YamlNode value)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xB066C0", Offset = "0xB066C0", VA = "0xB066C0")]
		public void Add(string key, YamlNode value)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xB067A8", Offset = "0xB067A8", VA = "0xB067A8")]
		public void Add(YamlNode key, string value)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xB06890", Offset = "0xB06890", VA = "0xB06890")]
		public void Add(string key, string value)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xB06998", Offset = "0xB06998", VA = "0xB06998", Slot = "4")]
		internal override void ResolveAliases(DocumentLoadingState state)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xB072F8", Offset = "0xB072F8", VA = "0xB072F8", Slot = "5")]
		internal override void Emit(IEmitter emitter, EmitterState state)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xB0770C", Offset = "0xB0770C", VA = "0xB0770C", Slot = "6")]
		public override void Accept(IYamlVisitor visitor)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xB077CC", Offset = "0xB077CC", VA = "0xB077CC", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xB07C8C", Offset = "0xB07C8C", VA = "0xB07C8C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xB0803C", Offset = "0xB0803C", VA = "0xB0803C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xB08418", Offset = "0xB08418", VA = "0xB08418", Slot = "8")]
		public IEnumerator<KeyValuePair<YamlNode, YamlNode>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xB084C8", Offset = "0xB084C8", VA = "0xB084C8", Slot = "9")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200005A")]
	public abstract class YamlNode
	{
		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581840", Offset = "0x581840")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x581840", Offset = "0x581840")]
		private string <Anchor>k__BackingField;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58187C", Offset = "0x58187C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x58187C", Offset = "0x58187C")]
		private string <Tag>k__BackingField;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5818B8", Offset = "0x5818B8")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x5818B8", Offset = "0x5818B8")]
		private Mark <Start>k__BackingField;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5818F4", Offset = "0x5818F4")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x5818F4", Offset = "0x5818F4")]
		private Mark <End>k__BackingField;

		[Token(Token = "0x17000076")]
		public string Anchor
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0xB04150", Offset = "0xB04150", VA = "0xB04150")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581930", Offset = "0x581930")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000260")]
			[Address(RVA = "0xB04780", Offset = "0xB04780", VA = "0xB04780")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581940", Offset = "0x581940")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public string Tag
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0xB07704", Offset = "0xB07704", VA = "0xB07704")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581950", Offset = "0x581950")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000262")]
			[Address(RVA = "0xB0906C", Offset = "0xB0906C", VA = "0xB0906C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581960", Offset = "0x581960")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public Mark Start
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0xB04158", Offset = "0xB04158", VA = "0xB04158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581970", Offset = "0x581970")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000264")]
			[Address(RVA = "0xB09074", Offset = "0xB09074", VA = "0xB09074")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581980", Offset = "0x581980")]
			private set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public Mark End
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0xB04160", Offset = "0xB04160", VA = "0xB04160")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581990", Offset = "0x581990")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000266")]
			[Address(RVA = "0xB0907C", Offset = "0xB0907C", VA = "0xB0907C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5819A0", Offset = "0x5819A0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public abstract IEnumerable<YamlNode> AllNodes
		{
			[Token(Token = "0x6000272")]
			get;
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xB04778", Offset = "0xB04778", VA = "0xB04778")]
		protected YamlNode()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xB05DC8", Offset = "0xB05DC8", VA = "0xB05DC8")]
		internal void Load(NodeEvent yamlEvent, DocumentLoadingState state)
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xB04F58", Offset = "0xB04F58", VA = "0xB04F58")]
		internal static YamlNode ParseNode(EventReader events, DocumentLoadingState state)
		{
			return null;
		}

		[Token(Token = "0x6000269")]
		internal abstract void ResolveAliases(DocumentLoadingState state);

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xB056CC", Offset = "0xB056CC", VA = "0xB056CC")]
		internal void Save(IEmitter emitter, EmitterState state)
		{
		}

		[Token(Token = "0x600026B")]
		internal abstract void Emit(IEmitter emitter, EmitterState state);

		[Token(Token = "0x600026C")]
		public abstract void Accept(IYamlVisitor visitor);

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xB049B8", Offset = "0xB049B8", VA = "0xB049B8")]
		protected bool Equals(YamlNode other)
		{
			return default(bool);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xB04A20", Offset = "0xB04A20", VA = "0xB04A20")]
		protected static bool SafeEquals(object first, object second)
		{
			return default(bool);
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xB04A78", Offset = "0xB04A78", VA = "0xB04A78", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xB07F88", Offset = "0xB07F88", VA = "0xB07F88")]
		protected static int GetHashCode(object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xB07FA4", Offset = "0xB07FA4", VA = "0xB07FA4")]
		protected static int CombineHashCodes(int h1, int h2)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200005B")]
	public sealed class YamlNodeIdentityEqualityComparer : IEqualityComparer<YamlNode>
	{
		[Token(Token = "0x6000273")]
		[Address(RVA = "0xB09338", Offset = "0xB09338", VA = "0xB09338")]
		public YamlNodeIdentityEqualityComparer()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xB09340", Offset = "0xB09340", VA = "0xB09340", Slot = "4")]
		public bool Equals(YamlNode x, YamlNode y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xB0934C", Offset = "0xB0934C", VA = "0xB0934C", Slot = "5")]
		public int GetHashCode(YamlNode obj)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200005C")]
	[AttributeAttribute(Name = "DebuggerDisplayAttribute", RVA = "0x5819B0", Offset = "0x5819B0")]
	public class YamlScalarNode : YamlNode
	{
		[Token(Token = "0x20000BE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581AA0", Offset = "0x581AA0")]
		private sealed class <>c__Iterator0 : IEnumerable, IEnumerable<YamlNode>, IEnumerator, IDisposable, IEnumerator<YamlNode>
		{
			[Token(Token = "0x400016E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal YamlScalarNode $this;

			[Token(Token = "0x400016F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal YamlNode $current;

			[Token(Token = "0x4000170")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal bool $disposing;

			[Token(Token = "0x4000171")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal int $PC;

			[Token(Token = "0x170000BF")]
			private YamlNode System.Collections.Generic.IEnumerator<YamlDotNet.RepresentationModel.YamlNode>.Current
			{
				[Token(Token = "0x600045B")]
				[Address(RVA = "0xB09894", Offset = "0xB09894", VA = "0xB09894", Slot = "10")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600045C")]
				[Address(RVA = "0xB0989C", Offset = "0xB0989C", VA = "0xB0989C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000459")]
			[Address(RVA = "0xB09828", Offset = "0xB09828", VA = "0xB09828")]
			[DebuggerHidden]
			public <>c__Iterator0()
			{
			}

			[Token(Token = "0x600045A")]
			[Address(RVA = "0xB09830", Offset = "0xB09830", VA = "0xB09830", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600045D")]
			[Address(RVA = "0xB098A4", Offset = "0xB098A4", VA = "0xB098A4", Slot = "9")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x600045E")]
			[Address(RVA = "0xB098B8", Offset = "0xB098B8", VA = "0xB098B8", Slot = "8")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			[Token(Token = "0x600045F")]
			[Address(RVA = "0xB0991C", Offset = "0xB0991C", VA = "0xB0991C", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000460")]
			[Address(RVA = "0xB09920", Offset = "0xB09920", VA = "0xB09920", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator<YamlNode> System.Collections.Generic.IEnumerable<YamlDotNet.RepresentationModel.YamlNode>.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5819E8", Offset = "0x5819E8")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x5819E8", Offset = "0x5819E8")]
		private string <Value>k__BackingField;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581A24", Offset = "0x581A24")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x581A24", Offset = "0x581A24")]
		private ScalarStyle <Style>k__BackingField;

		[Token(Token = "0x1700007B")]
		public string Value
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0xB09394", Offset = "0xB09394", VA = "0xB09394")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581A60", Offset = "0x581A60")]
			get
			{
				return null;
			}
			[Token(Token = "0x600027A")]
			[Address(RVA = "0xB0937C", Offset = "0xB0937C", VA = "0xB0937C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581A70", Offset = "0x581A70")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public ScalarStyle Style
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0xB0939C", Offset = "0xB0939C", VA = "0xB0939C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581A80", Offset = "0x581A80")]
			get
			{
				return default(ScalarStyle);
			}
			[Token(Token = "0x600027C")]
			[Address(RVA = "0xB09384", Offset = "0xB09384", VA = "0xB09384")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581A90", Offset = "0x581A90")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public override IEnumerable<YamlNode> AllNodes
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0xB097A4", Offset = "0xB097A4", VA = "0xB097A4", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xB09084", Offset = "0xB09084", VA = "0xB09084")]
		internal YamlScalarNode(EventReader events, DocumentLoadingState state)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xB0938C", Offset = "0xB0938C", VA = "0xB0938C")]
		public YamlScalarNode()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xB04DD4", Offset = "0xB04DD4", VA = "0xB04DD4")]
		public YamlScalarNode(string value)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xB093A4", Offset = "0xB093A4", VA = "0xB093A4", Slot = "4")]
		internal override void ResolveAliases(DocumentLoadingState state)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xB09414", Offset = "0xB09414", VA = "0xB09414", Slot = "5")]
		internal override void Emit(IEmitter emitter, EmitterState state)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xB09514", Offset = "0xB09514", VA = "0xB09514", Slot = "6")]
		public override void Accept(IYamlVisitor visitor)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xB095D4", Offset = "0xB095D4", VA = "0xB095D4", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xB096B4", Offset = "0xB096B4", VA = "0xB096B4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xB09710", Offset = "0xB09710", VA = "0xB09710")]
		public static implicit operator YamlScalarNode(string value)
		{
			return null;
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xB09774", Offset = "0xB09774", VA = "0xB09774")]
		public static explicit operator string(YamlScalarNode value)
		{
			return null;
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xB0979C", Offset = "0xB0979C", VA = "0xB0979C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "DebuggerDisplayAttribute", RVA = "0x581B20", Offset = "0x581B20")]
	public class YamlSequenceNode : YamlNode, IEnumerable<YamlNode>, IEnumerable
	{
		[Token(Token = "0x20000BF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581BC4", Offset = "0x581BC4")]
		private sealed class <>c__Iterator0 : IEnumerable, IEnumerable<YamlNode>, IEnumerator, IDisposable, IEnumerator<YamlNode>
		{
			[Token(Token = "0x4000172")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal IEnumerator<YamlNode> $locvar0;

			[Token(Token = "0x4000173")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal YamlNode <child>__1;

			[Token(Token = "0x4000174")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal IEnumerator<YamlNode> $locvar1;

			[Token(Token = "0x4000175")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal YamlNode <node>__2;

			[Token(Token = "0x4000176")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal YamlSequenceNode $this;

			[Token(Token = "0x4000177")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal YamlNode $current;

			[Token(Token = "0x4000178")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal bool $disposing;

			[Token(Token = "0x4000179")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			internal int $PC;

			[Token(Token = "0x170000C1")]
			private YamlNode System.Collections.Generic.IEnumerator<YamlDotNet.RepresentationModel.YamlNode>.Current
			{
				[Token(Token = "0x6000463")]
				[Address(RVA = "0xB0B714", Offset = "0xB0B714", VA = "0xB0B714", Slot = "10")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000464")]
				[Address(RVA = "0xB0B71C", Offset = "0xB0B71C", VA = "0xB0B71C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0xB0ADBC", Offset = "0xB0ADBC", VA = "0xB0ADBC")]
			[DebuggerHidden]
			public <>c__Iterator0()
			{
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0xB0B19C", Offset = "0xB0B19C", VA = "0xB0B19C", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000465")]
			[Address(RVA = "0xB0B724", Offset = "0xB0B724", VA = "0xB0B724", Slot = "9")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000466")]
			[Address(RVA = "0xB0B8A8", Offset = "0xB0B8A8", VA = "0xB0B8A8", Slot = "8")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			[Token(Token = "0x6000467")]
			[Address(RVA = "0xB0B90C", Offset = "0xB0B90C", VA = "0xB0B90C", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000468")]
			[Address(RVA = "0xB0B910", Offset = "0xB0B910", VA = "0xB0B910", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator<YamlNode> System.Collections.Generic.IEnumerable<YamlDotNet.RepresentationModel.YamlNode>.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly IList<YamlNode> children;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581B58", Offset = "0x581B58")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x581B58", Offset = "0x581B58")]
		private SequenceStyle <Style>k__BackingField;

		[Token(Token = "0x1700007E")]
		public IList<YamlNode> Children
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0xB09D54", Offset = "0xB09D54", VA = "0xB09D54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		public SequenceStyle Style
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0xB09D5C", Offset = "0xB09D5C", VA = "0xB09D5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581BA4", Offset = "0x581BA4")]
			get
			{
				return default(SequenceStyle);
			}
			[Token(Token = "0x600028C")]
			[Address(RVA = "0xB09D64", Offset = "0xB09D64", VA = "0xB09D64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581BB4", Offset = "0x581BB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public override IEnumerable<YamlNode> AllNodes
		{
			[Token(Token = "0x6000294")]
			[Address(RVA = "0xB0AD38", Offset = "0xB0AD38", VA = "0xB0AD38", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xB0913C", Offset = "0xB0913C", VA = "0xB0913C")]
		internal YamlSequenceNode(EventReader events, DocumentLoadingState state)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xB099B8", Offset = "0xB099B8", VA = "0xB099B8")]
		public YamlSequenceNode()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xB09A28", Offset = "0xB09A28", VA = "0xB09A28")]
		public YamlSequenceNode(params YamlNode[] children)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xB09A2C", Offset = "0xB09A2C", VA = "0xB09A2C")]
		public YamlSequenceNode(IEnumerable<YamlNode> children)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xB09D6C", Offset = "0xB09D6C", VA = "0xB09D6C")]
		public void Add(YamlNode child)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xB09E30", Offset = "0xB09E30", VA = "0xB09E30")]
		public void Add(string child)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xB09F14", Offset = "0xB09F14", VA = "0xB09F14", Slot = "4")]
		internal override void ResolveAliases(DocumentLoadingState state)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xB0A2DC", Offset = "0xB0A2DC", VA = "0xB0A2DC", Slot = "5")]
		internal override void Emit(IEmitter emitter, EmitterState state)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xB0A684", Offset = "0xB0A684", VA = "0xB0A684", Slot = "6")]
		public override void Accept(IYamlVisitor visitor)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xB0A744", Offset = "0xB0A744", VA = "0xB0A744", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xB0AAA0", Offset = "0xB0AAA0", VA = "0xB0AAA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xB0ADC4", Offset = "0xB0ADC4", VA = "0xB0ADC4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xB0B0E8", Offset = "0xB0B0E8", VA = "0xB0B0E8", Slot = "8")]
		public IEnumerator<YamlNode> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xB0B198", Offset = "0xB0B198", VA = "0xB0B198", Slot = "9")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200005E")]
	public class YamlStream : IEnumerable<YamlDocument>, IEnumerable
	{
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IList<YamlDocument> documents;

		[Token(Token = "0x17000081")]
		public IList<YamlDocument> Documents
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0xB0BD44", Offset = "0xB0BD44", VA = "0xB0BD44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xB0B9A8", Offset = "0xB0B9A8", VA = "0xB0B9A8")]
		public YamlStream()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xB0BA18", Offset = "0xB0BA18", VA = "0xB0BA18")]
		public YamlStream(params YamlDocument[] documents)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xB0BA1C", Offset = "0xB0BA1C", VA = "0xB0BA1C")]
		public YamlStream(IEnumerable<YamlDocument> documents)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xB0BD4C", Offset = "0xB0BD4C", VA = "0xB0BD4C")]
		public void Add(YamlDocument document)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xB0BE10", Offset = "0xB0BE10", VA = "0xB0BE10")]
		public void Load(TextReader input)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xB0BEA8", Offset = "0xB0BEA8", VA = "0xB0BEA8")]
		public void Load(EventReader reader)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xB0C068", Offset = "0xB0C068", VA = "0xB0C068")]
		public void Save(TextWriter output)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xB0C070", Offset = "0xB0C070", VA = "0xB0C070")]
		public void Save(TextWriter output, bool assignAnchors)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xB0C42C", Offset = "0xB0C42C", VA = "0xB0C42C")]
		public void Accept(IYamlVisitor visitor)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xB0C4E8", Offset = "0xB0C4E8", VA = "0xB0C4E8", Slot = "4")]
		public IEnumerator<YamlDocument> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xB0C598", Offset = "0xB0C598", VA = "0xB0C598", Slot = "5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x581C54", Offset = "0x581C54")]
	public abstract class YamlVisitor : IYamlVisitor
	{
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xB05940", Offset = "0xB05940", VA = "0xB05940")]
		protected YamlVisitor()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xB0C59C", Offset = "0xB0C59C", VA = "0xB0C59C", Slot = "9")]
		protected virtual void Visit(YamlStream stream)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xB0C5A0", Offset = "0xB0C5A0", VA = "0xB0C5A0", Slot = "10")]
		protected virtual void Visited(YamlStream stream)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xB0C5A4", Offset = "0xB0C5A4", VA = "0xB0C5A4", Slot = "11")]
		protected virtual void Visit(YamlDocument document)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xB0C5A8", Offset = "0xB0C5A8", VA = "0xB0C5A8", Slot = "12")]
		protected virtual void Visited(YamlDocument document)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xB0C5AC", Offset = "0xB0C5AC", VA = "0xB0C5AC", Slot = "13")]
		protected virtual void Visit(YamlScalarNode scalar)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xB0C5B0", Offset = "0xB0C5B0", VA = "0xB0C5B0", Slot = "14")]
		protected virtual void Visited(YamlScalarNode scalar)
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xB0C5B4", Offset = "0xB0C5B4", VA = "0xB0C5B4", Slot = "15")]
		protected virtual void Visit(YamlSequenceNode sequence)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xB0C5B8", Offset = "0xB0C5B8", VA = "0xB0C5B8", Slot = "16")]
		protected virtual void Visited(YamlSequenceNode sequence)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xB0C5BC", Offset = "0xB0C5BC", VA = "0xB0C5BC", Slot = "17")]
		protected virtual void Visit(YamlMappingNode mapping)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xB0C5C0", Offset = "0xB0C5C0", VA = "0xB0C5C0", Slot = "18")]
		protected virtual void Visited(YamlMappingNode mapping)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xB0C5C4", Offset = "0xB0C5C4", VA = "0xB0C5C4", Slot = "19")]
		protected virtual void VisitChildren(YamlStream stream)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xB0C850", Offset = "0xB0C850", VA = "0xB0C850", Slot = "20")]
		protected virtual void VisitChildren(YamlDocument document)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xB0C898", Offset = "0xB0C898", VA = "0xB0C898", Slot = "21")]
		protected virtual void VisitChildren(YamlSequenceNode sequence)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xB0CB2C", Offset = "0xB0CB2C", VA = "0xB0CB2C", Slot = "22")]
		protected virtual void VisitChildren(YamlMappingNode mapping)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xB0CE14", Offset = "0xB0CE14", VA = "0xB0CE14", Slot = "4")]
		private void YamlDotNet.RepresentationModel.IYamlVisitor.Visit(YamlStream stream)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xB0CE68", Offset = "0xB0CE68", VA = "0xB0CE68", Slot = "5")]
		private void YamlDotNet.RepresentationModel.IYamlVisitor.Visit(YamlDocument document)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xB0CEBC", Offset = "0xB0CEBC", VA = "0xB0CEBC", Slot = "6")]
		private void YamlDotNet.RepresentationModel.IYamlVisitor.Visit(YamlScalarNode scalar)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xB0CEF8", Offset = "0xB0CEF8", VA = "0xB0CEF8", Slot = "7")]
		private void YamlDotNet.RepresentationModel.IYamlVisitor.Visit(YamlSequenceNode sequence)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xB0CF54", Offset = "0xB0CF54", VA = "0xB0CF54", Slot = "8")]
		private void YamlDotNet.RepresentationModel.IYamlVisitor.Visit(YamlMappingNode mapping)
		{
		}
	}
	[Token(Token = "0x2000060")]
	public abstract class YamlVisitorBase : IYamlVisitor
	{
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xB0CFB0", Offset = "0xB0CFB0", VA = "0xB0CFB0")]
		protected YamlVisitorBase()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xB0CFB8", Offset = "0xB0CFB8", VA = "0xB0CFB8", Slot = "9")]
		protected virtual void Visit(YamlStream stream)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xB0CFC8", Offset = "0xB0CFC8", VA = "0xB0CFC8", Slot = "10")]
		protected virtual void Visited(YamlStream stream)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xB0CFCC", Offset = "0xB0CFCC", VA = "0xB0CFCC", Slot = "11")]
		protected virtual void Visit(YamlDocument document)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xB0CFDC", Offset = "0xB0CFDC", VA = "0xB0CFDC", Slot = "12")]
		protected virtual void Visited(YamlDocument document)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xB0CFE0", Offset = "0xB0CFE0", VA = "0xB0CFE0", Slot = "13")]
		protected virtual void Visit(YamlScalarNode scalar)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xB0CFE4", Offset = "0xB0CFE4", VA = "0xB0CFE4", Slot = "14")]
		protected virtual void Visited(YamlScalarNode scalar)
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xB0CFE8", Offset = "0xB0CFE8", VA = "0xB0CFE8", Slot = "15")]
		protected virtual void Visit(YamlSequenceNode sequence)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xB0CFF8", Offset = "0xB0CFF8", VA = "0xB0CFF8", Slot = "16")]
		protected virtual void Visited(YamlSequenceNode sequence)
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xB0CFFC", Offset = "0xB0CFFC", VA = "0xB0CFFC", Slot = "17")]
		protected virtual void Visit(YamlMappingNode mapping)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xB0D00C", Offset = "0xB0D00C", VA = "0xB0D00C", Slot = "18")]
		protected virtual void Visited(YamlMappingNode mapping)
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xB0D010", Offset = "0xB0D010", VA = "0xB0D010", Slot = "19")]
		protected virtual void VisitPair(YamlNode key, YamlNode value)
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xB0D070", Offset = "0xB0D070", VA = "0xB0D070", Slot = "20")]
		protected virtual void VisitChildren(YamlStream stream)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xB0D2FC", Offset = "0xB0D2FC", VA = "0xB0D2FC", Slot = "21")]
		protected virtual void VisitChildren(YamlDocument document)
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xB0D344", Offset = "0xB0D344", VA = "0xB0D344", Slot = "22")]
		protected virtual void VisitChildren(YamlSequenceNode sequence)
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xB0D5D8", Offset = "0xB0D5D8", VA = "0xB0D5D8", Slot = "23")]
		protected virtual void VisitChildren(YamlMappingNode mapping)
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xB0D8A0", Offset = "0xB0D8A0", VA = "0xB0D8A0", Slot = "4")]
		private void YamlDotNet.RepresentationModel.IYamlVisitor.Visit(YamlStream stream)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xB0D8DC", Offset = "0xB0D8DC", VA = "0xB0D8DC", Slot = "5")]
		private void YamlDotNet.RepresentationModel.IYamlVisitor.Visit(YamlDocument document)
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xB0D918", Offset = "0xB0D918", VA = "0xB0D918", Slot = "6")]
		private void YamlDotNet.RepresentationModel.IYamlVisitor.Visit(YamlScalarNode scalar)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xB0D954", Offset = "0xB0D954", VA = "0xB0D954", Slot = "7")]
		private void YamlDotNet.RepresentationModel.IYamlVisitor.Visit(YamlSequenceNode sequence)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xB0D998", Offset = "0xB0D998", VA = "0xB0D998", Slot = "8")]
		private void YamlDotNet.RepresentationModel.IYamlVisitor.Visit(YamlMappingNode mapping)
		{
		}
	}
}
namespace YamlDotNet.Serialization.Converters
{
	[Token(Token = "0x2000061")]
	public class GuidConverter : IYamlTypeConverter
	{
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xB0DA44", Offset = "0xB0DA44", VA = "0xB0DA44")]
		public GuidConverter()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xB0DA4C", Offset = "0xB0DA4C", VA = "0xB0DA4C", Slot = "4")]
		public bool Accepts(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xB0DAD0", Offset = "0xB0DAD0", VA = "0xB0DAD0", Slot = "5")]
		public object ReadYaml(IParser parser, Type type)
		{
			return null;
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xB0DD04", Offset = "0xB0DD04", VA = "0xB0DD04", Slot = "6")]
		public void WriteYaml(IEmitter emitter, object value, Type type)
		{
		}
	}
}
namespace YamlDotNet.Serialization
{
	[Token(Token = "0x2000062")]
	public sealed class Deserializer
	{
		[Token(Token = "0x2000063")]
		private class TypeDescriptorProxy : ITypeInspector
		{
			[Token(Token = "0x40000F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ITypeInspector TypeDescriptor;

			[Token(Token = "0x60002DF")]
			[Address(RVA = "0xB0EA04", Offset = "0xB0EA04", VA = "0xB0EA04")]
			public TypeDescriptorProxy()
			{
			}

			[Token(Token = "0x60002E0")]
			[Address(RVA = "0xB0F1D8", Offset = "0xB0F1D8", VA = "0xB0F1D8", Slot = "4")]
			public IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container)
			{
				return null;
			}

			[Token(Token = "0x60002E1")]
			[Address(RVA = "0xB0F2A0", Offset = "0xB0F2A0", VA = "0xB0F2A0", Slot = "5")]
			public IPropertyDescriptor GetProperty(Type type, object container, string name, bool ignoreUnmatched)
			{
				return null;
			}
		}

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, Type> predefinedTagMappings;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, Type> tagMappings;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<IYamlTypeConverter> converters;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TypeDescriptorProxy typeDescriptor;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IValueDeserializer valueDeserializer;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581C8C", Offset = "0x581C8C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x581C8C", Offset = "0x581C8C")]
		private IList<INodeDeserializer> <NodeDeserializers>k__BackingField;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581CC8", Offset = "0x581CC8")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x581CC8", Offset = "0x581CC8")]
		private IList<INodeTypeResolver> <TypeResolvers>k__BackingField;

		[Token(Token = "0x17000082")]
		public IList<INodeDeserializer> NodeDeserializers
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0xB0EA1C", Offset = "0xB0EA1C", VA = "0xB0EA1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581D04", Offset = "0x581D04")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0xB0EA14", Offset = "0xB0EA14", VA = "0xB0EA14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581D14", Offset = "0x581D14")]
			private set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public IList<INodeTypeResolver> TypeResolvers
		{
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0xB0EA34", Offset = "0xB0EA34", VA = "0xB0EA34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581D24", Offset = "0x581D24")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0xB0EA2C", Offset = "0xB0EA2C", VA = "0xB0EA2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581D34", Offset = "0x581D34")]
			private set
			{
			}
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xB0DE84", Offset = "0xB0DE84", VA = "0xB0DE84")]
		public Deserializer([Optional] IObjectFactory objectFactory, [Optional] INamingConvention namingConvention, bool ignoreUnmatched = false)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xB0EA3C", Offset = "0xB0EA3C", VA = "0xB0EA3C")]
		public void RegisterTagMapping(string tag, Type type)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xB0EAB0", Offset = "0xB0EAB0", VA = "0xB0EAB0")]
		public void RegisterTypeConverter(IYamlTypeConverter typeConverter)
		{
		}

		[Token(Token = "0x60002D8")]
		public T Deserialize<T>(TextReader input)
		{
			return (T)null;
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xB0EB1C", Offset = "0xB0EB1C", VA = "0xB0EB1C")]
		public object Deserialize(TextReader input)
		{
			return null;
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xB0EBB0", Offset = "0xB0EBB0", VA = "0xB0EBB0")]
		public object Deserialize(TextReader input, Type type)
		{
			return null;
		}

		[Token(Token = "0x60002DB")]
		public T Deserialize<T>(EventReader reader)
		{
			return (T)null;
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xB0EF1C", Offset = "0xB0EF1C", VA = "0xB0EF1C")]
		public object Deserialize(EventReader reader)
		{
			return null;
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xB0EC50", Offset = "0xB0EC50", VA = "0xB0EC50")]
		public object Deserialize(EventReader reader, Type type)
		{
			return null;
		}
	}
}
namespace YamlDotNet.Serialization.EventEmitters
{
	[Token(Token = "0x2000064")]
	public abstract class ChainedEventEmitter : IEventEmitter
	{
		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected readonly IEventEmitter nextEmitter;

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xB0F384", Offset = "0xB0F384", VA = "0xB0F384")]
		protected ChainedEventEmitter(IEventEmitter nextEmitter)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xB0F424", Offset = "0xB0F424", VA = "0xB0F424", Slot = "10")]
		public virtual void Emit(AliasEventInfo eventInfo)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xB0F4E4", Offset = "0xB0F4E4", VA = "0xB0F4E4", Slot = "11")]
		public virtual void Emit(ScalarEventInfo eventInfo)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xB0F5A8", Offset = "0xB0F5A8", VA = "0xB0F5A8", Slot = "12")]
		public virtual void Emit(MappingStartEventInfo eventInfo)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xB0F66C", Offset = "0xB0F66C", VA = "0xB0F66C", Slot = "13")]
		public virtual void Emit(MappingEndEventInfo eventInfo)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xB0F730", Offset = "0xB0F730", VA = "0xB0F730", Slot = "14")]
		public virtual void Emit(SequenceStartEventInfo eventInfo)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xB0F7F4", Offset = "0xB0F7F4", VA = "0xB0F7F4", Slot = "15")]
		public virtual void Emit(SequenceEndEventInfo eventInfo)
		{
		}
	}
	[Token(Token = "0x2000065")]
	public sealed class JsonEventEmitter : ChainedEventEmitter
	{
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xB0F8B8", Offset = "0xB0F8B8", VA = "0xB0F8B8")]
		public JsonEventEmitter(IEventEmitter nextEmitter)
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xB0F8BC", Offset = "0xB0F8BC", VA = "0xB0F8BC", Slot = "10")]
		public override void Emit(AliasEventInfo eventInfo)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xB0F92C", Offset = "0xB0F92C", VA = "0xB0F92C", Slot = "11")]
		public override void Emit(ScalarEventInfo eventInfo)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xB1012C", Offset = "0xB1012C", VA = "0xB1012C", Slot = "12")]
		public override void Emit(MappingStartEventInfo eventInfo)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xB1016C", Offset = "0xB1016C", VA = "0xB1016C", Slot = "14")]
		public override void Emit(SequenceStartEventInfo eventInfo)
		{
		}
	}
	[Token(Token = "0x2000066")]
	public sealed class TypeAssigningEventEmitter : ChainedEventEmitter
	{
		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly bool _assignTypeWhenDifferent;

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xB101AC", Offset = "0xB101AC", VA = "0xB101AC")]
		public TypeAssigningEventEmitter(IEventEmitter nextEmitter, bool assignTypeWhenDifferent)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xB101D8", Offset = "0xB101D8", VA = "0xB101D8", Slot = "11")]
		public override void Emit(ScalarEventInfo eventInfo)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xB10B5C", Offset = "0xB10B5C", VA = "0xB10B5C", Slot = "12")]
		public override void Emit(MappingStartEventInfo eventInfo)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xB10E5C", Offset = "0xB10E5C", VA = "0xB10E5C", Slot = "14")]
		public override void Emit(SequenceStartEventInfo eventInfo)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xB10B88", Offset = "0xB10B88", VA = "0xB10B88")]
		private void AssignTypeIfDifferent(ObjectEventInfo eventInfo)
		{
		}
	}
	[Token(Token = "0x2000067")]
	public sealed class WriterEventEmitter : IEventEmitter
	{
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IEmitter emitter;

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xB10E88", Offset = "0xB10E88", VA = "0xB10E88")]
		public WriterEventEmitter(IEmitter emitter)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xB10EB4", Offset = "0xB10EB4", VA = "0xB10EB4", Slot = "4")]
		private void YamlDotNet.Serialization.IEventEmitter.Emit(AliasEventInfo eventInfo)
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xB10F9C", Offset = "0xB10F9C", VA = "0xB10F9C", Slot = "5")]
		private void YamlDotNet.Serialization.IEventEmitter.Emit(ScalarEventInfo eventInfo)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xB11170", Offset = "0xB11170", VA = "0xB11170", Slot = "6")]
		private void YamlDotNet.Serialization.IEventEmitter.Emit(MappingStartEventInfo eventInfo)
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xB112E4", Offset = "0xB112E4", VA = "0xB112E4", Slot = "7")]
		private void YamlDotNet.Serialization.IEventEmitter.Emit(MappingEndEventInfo eventInfo)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xB113B0", Offset = "0xB113B0", VA = "0xB113B0", Slot = "8")]
		private void YamlDotNet.Serialization.IEventEmitter.Emit(SequenceStartEventInfo eventInfo)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xB1152C", Offset = "0xB1152C", VA = "0xB1152C", Slot = "9")]
		private void YamlDotNet.Serialization.IEventEmitter.Emit(SequenceEndEventInfo eventInfo)
		{
		}
	}
}
namespace YamlDotNet.Serialization
{
	[Token(Token = "0x2000068")]
	public abstract class EventInfo
	{
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581D44", Offset = "0x581D44")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x581D44", Offset = "0x581D44")]
		private IObjectDescriptor <Source>k__BackingField;

		[Token(Token = "0x17000084")]
		public IObjectDescriptor Source
		{
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0xB10124", Offset = "0xB10124", VA = "0xB10124")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581D80", Offset = "0x581D80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0xB115F8", Offset = "0xB115F8", VA = "0xB115F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581D90", Offset = "0x581D90")]
			private set
			{
			}
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xB0DA08", Offset = "0xB0DA08", VA = "0xB0DA08")]
		protected EventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class AliasEventInfo : EventInfo
	{
		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581DA0", Offset = "0x581DA0")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x581DA0", Offset = "0x581DA0")]
		private string <Alias>k__BackingField;

		[Token(Token = "0x17000085")]
		public string Alias
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0xB0DA34", Offset = "0xB0DA34", VA = "0xB0DA34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581DDC", Offset = "0x581DDC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0xB0DA3C", Offset = "0xB0DA3C", VA = "0xB0DA3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581DEC", Offset = "0x581DEC")]
			set
			{
			}
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xB0D9DC", Offset = "0xB0D9DC", VA = "0xB0D9DC")]
		public AliasEventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class ObjectEventInfo : EventInfo
	{
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581DFC", Offset = "0x581DFC")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x581DFC", Offset = "0x581DFC")]
		private string <Anchor>k__BackingField;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581E38", Offset = "0x581E38")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x581E38", Offset = "0x581E38")]
		private string <Tag>k__BackingField;

		[Token(Token = "0x17000086")]
		public string Anchor
		{
			[Token(Token = "0x6000301")]
			[Address(RVA = "0x100F078", Offset = "0x100F078", VA = "0x100F078")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581E74", Offset = "0x581E74")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x100F080", Offset = "0x100F080", VA = "0x100F080")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581E84", Offset = "0x581E84")]
			set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public string Tag
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x100F088", Offset = "0x100F088", VA = "0x100F088")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581E94", Offset = "0x581E94")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x100F090", Offset = "0x100F090", VA = "0x100F090")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581EA4", Offset = "0x581EA4")]
			set
			{
			}
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x100F070", Offset = "0x100F070", VA = "0x100F070")]
		protected ObjectEventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x200006B")]
	public sealed class ScalarEventInfo : ObjectEventInfo
	{
		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581EB4", Offset = "0x581EB4")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x581EB4", Offset = "0x581EB4")]
		private string <RenderedValue>k__BackingField;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581EF0", Offset = "0x581EF0")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x581EF0", Offset = "0x581EF0")]
		private ScalarStyle <Style>k__BackingField;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581F2C", Offset = "0x581F2C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x581F2C", Offset = "0x581F2C")]
		private bool <IsPlainImplicit>k__BackingField;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581F68", Offset = "0x581F68")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x581F68", Offset = "0x581F68")]
		private bool <IsQuotedImplicit>k__BackingField;

		[Token(Token = "0x17000088")]
		public string RenderedValue
		{
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x1014CE8", Offset = "0x1014CE8", VA = "0x1014CE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581FA4", Offset = "0x581FA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000307")]
			[Address(RVA = "0x1014CF0", Offset = "0x1014CF0", VA = "0x1014CF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581FB4", Offset = "0x581FB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public ScalarStyle Style
		{
			[Token(Token = "0x6000308")]
			[Address(RVA = "0x1014CF8", Offset = "0x1014CF8", VA = "0x1014CF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581FC4", Offset = "0x581FC4")]
			get
			{
				return default(ScalarStyle);
			}
			[Token(Token = "0x6000309")]
			[Address(RVA = "0x1014CE0", Offset = "0x1014CE0", VA = "0x1014CE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581FD4", Offset = "0x581FD4")]
			set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public bool IsPlainImplicit
		{
			[Token(Token = "0x600030A")]
			[Address(RVA = "0x1014D00", Offset = "0x1014D00", VA = "0x1014D00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581FE4", Offset = "0x581FE4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600030B")]
			[Address(RVA = "0x1014D08", Offset = "0x1014D08", VA = "0x1014D08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x581FF4", Offset = "0x581FF4")]
			set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public bool IsQuotedImplicit
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0x1014D14", Offset = "0x1014D14", VA = "0x1014D14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582004", Offset = "0x582004")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600030D")]
			[Address(RVA = "0x1014D1C", Offset = "0x1014D1C", VA = "0x1014D1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582014", Offset = "0x582014")]
			set
			{
			}
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x1013044", Offset = "0x1013044", VA = "0x1013044")]
		public ScalarEventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x200006C")]
	public sealed class MappingStartEventInfo : ObjectEventInfo
	{
		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582024", Offset = "0x582024")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x582024", Offset = "0x582024")]
		private bool <IsImplicit>k__BackingField;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582060", Offset = "0x582060")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x582060", Offset = "0x582060")]
		private MappingStyle <Style>k__BackingField;

		[Token(Token = "0x1700008C")]
		public bool IsImplicit
		{
			[Token(Token = "0x600030F")]
			[Address(RVA = "0xB112D4", Offset = "0xB112D4", VA = "0xB112D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58209C", Offset = "0x58209C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000310")]
			[Address(RVA = "0xB11634", Offset = "0xB11634", VA = "0xB11634")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5820AC", Offset = "0x5820AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public MappingStyle Style
		{
			[Token(Token = "0x6000311")]
			[Address(RVA = "0xB112DC", Offset = "0xB112DC", VA = "0xB112DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5820BC", Offset = "0x5820BC")]
			get
			{
				return default(MappingStyle);
			}
			[Token(Token = "0x6000312")]
			[Address(RVA = "0xB10164", Offset = "0xB10164", VA = "0xB10164")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5820CC", Offset = "0x5820CC")]
			set
			{
			}
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xB1162C", Offset = "0xB1162C", VA = "0xB1162C")]
		public MappingStartEventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x200006D")]
	public sealed class MappingEndEventInfo : EventInfo
	{
		[Token(Token = "0x6000313")]
		[Address(RVA = "0xB11600", Offset = "0xB11600", VA = "0xB11600")]
		public MappingEndEventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x200006E")]
	public sealed class SequenceStartEventInfo : ObjectEventInfo
	{
		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5820DC", Offset = "0x5820DC")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x5820DC", Offset = "0x5820DC")]
		private bool <IsImplicit>k__BackingField;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582118", Offset = "0x582118")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x582118", Offset = "0x582118")]
		private SequenceStyle <Style>k__BackingField;

		[Token(Token = "0x1700008E")]
		public bool IsImplicit
		{
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x1014D28", Offset = "0x1014D28", VA = "0x1014D28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582154", Offset = "0x582154")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000316")]
			[Address(RVA = "0x1014D30", Offset = "0x1014D30", VA = "0x1014D30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582164", Offset = "0x582164")]
			set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public SequenceStyle Style
		{
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x1014D3C", Offset = "0x1014D3C", VA = "0x1014D3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582174", Offset = "0x582174")]
			get
			{
				return default(SequenceStyle);
			}
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x1014D44", Offset = "0x1014D44", VA = "0x1014D44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582184", Offset = "0x582184")]
			set
			{
			}
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1012E60", Offset = "0x1012E60", VA = "0x1012E60")]
		public SequenceStartEventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x200006F")]
	public sealed class SequenceEndEventInfo : EventInfo
	{
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1014600", Offset = "0x1014600", VA = "0x1014600")]
		public SequenceEndEventInfo(IObjectDescriptor source)
		{
		}
	}
	[Token(Token = "0x2000070")]
	public interface IAliasProvider
	{
		[Token(Token = "0x600031A")]
		string GetAlias(object target);
	}
	[Token(Token = "0x2000071")]
	public interface IEventEmitter
	{
		[Token(Token = "0x600031B")]
		void Emit(AliasEventInfo eventInfo);

		[Token(Token = "0x600031C")]
		void Emit(ScalarEventInfo eventInfo);

		[Token(Token = "0x600031D")]
		void Emit(MappingStartEventInfo eventInfo);

		[Token(Token = "0x600031E")]
		void Emit(MappingEndEventInfo eventInfo);

		[Token(Token = "0x600031F")]
		void Emit(SequenceStartEventInfo eventInfo);

		[Token(Token = "0x6000320")]
		void Emit(SequenceEndEventInfo eventInfo);
	}
	[Token(Token = "0x2000072")]
	public interface INamingConvention
	{
		[Token(Token = "0x6000321")]
		string Apply(string value);
	}
	[Token(Token = "0x2000073")]
	public interface INodeDeserializer
	{
		[Token(Token = "0x6000322")]
		bool Deserialize(EventReader reader, Type expectedType, Func<EventReader, Type, object> nestedObjectDeserializer, out object value);
	}
	[Token(Token = "0x2000074")]
	public interface INodeTypeResolver
	{
		[Token(Token = "0x6000323")]
		bool Resolve(NodeEvent nodeEvent, ref Type currentType);
	}
	[Token(Token = "0x2000075")]
	public interface IObjectDescriptor
	{
		[Token(Token = "0x17000090")]
		object Value
		{
			[Token(Token = "0x6000324")]
			get;
		}

		[Token(Token = "0x17000091")]
		Type Type
		{
			[Token(Token = "0x6000325")]
			get;
		}

		[Token(Token = "0x17000092")]
		Type StaticType
		{
			[Token(Token = "0x6000326")]
			get;
		}

		[Token(Token = "0x17000093")]
		ScalarStyle ScalarStyle
		{
			[Token(Token = "0x6000327")]
			get;
		}
	}
	[Token(Token = "0x2000076")]
	public interface IObjectFactory
	{
		[Token(Token = "0x6000328")]
		object Create(Type type);
	}
	[Token(Token = "0x2000077")]
	public interface IObjectGraphTraversalStrategy
	{
		[Token(Token = "0x6000329")]
		void Traverse(IObjectDescriptor graph, IObjectGraphVisitor visitor);
	}
	[Token(Token = "0x2000078")]
	public interface IObjectGraphVisitor
	{
		[Token(Token = "0x600032A")]
		bool Enter(IObjectDescriptor value);

		[Token(Token = "0x600032B")]
		bool EnterMapping(IObjectDescriptor key, IObjectDescriptor value);

		[Token(Token = "0x600032C")]
		bool EnterMapping(IPropertyDescriptor key, IObjectDescriptor value);

		[Token(Token = "0x600032D")]
		void VisitScalar(IObjectDescriptor scalar);

		[Token(Token = "0x600032E")]
		void VisitMappingStart(IObjectDescriptor mapping, Type keyType, Type valueType);

		[Token(Token = "0x600032F")]
		void VisitMappingEnd(IObjectDescriptor mapping);

		[Token(Token = "0x6000330")]
		void VisitSequenceStart(IObjectDescriptor sequence, Type elementType);

		[Token(Token = "0x6000331")]
		void VisitSequenceEnd(IObjectDescriptor sequence);
	}
	[Token(Token = "0x2000079")]
	public interface IPropertyDescriptor
	{
		[Token(Token = "0x17000094")]
		string Name
		{
			[Token(Token = "0x6000332")]
			get;
		}

		[Token(Token = "0x17000095")]
		bool CanWrite
		{
			[Token(Token = "0x6000333")]
			get;
		}

		[Token(Token = "0x17000096")]
		Type Type
		{
			[Token(Token = "0x6000334")]
			get;
		}

		[Token(Token = "0x17000097")]
		Type TypeOverride
		{
			[Token(Token = "0x6000335")]
			get;
			[Token(Token = "0x6000336")]
			set;
		}

		[Token(Token = "0x17000098")]
		int Order
		{
			[Token(Token = "0x6000337")]
			get;
			[Token(Token = "0x6000338")]
			set;
		}

		[Token(Token = "0x17000099")]
		ScalarStyle ScalarStyle
		{
			[Token(Token = "0x6000339")]
			get;
			[Token(Token = "0x600033A")]
			set;
		}

		[Token(Token = "0x600033B")]
		T GetCustomAttribute<T>() where T : Attribute;

		[Token(Token = "0x600033C")]
		IObjectDescriptor Read(object target);

		[Token(Token = "0x600033D")]
		void Write(object target, object value);
	}
	[Token(Token = "0x200007A")]
	public interface ITypeInspector
	{
		[Token(Token = "0x600033E")]
		IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container);

		[Token(Token = "0x600033F")]
		IPropertyDescriptor GetProperty(Type type, object container, string name, bool ignoreUnmatched);
	}
	[Token(Token = "0x200007B")]
	public interface ITypeResolver
	{
		[Token(Token = "0x6000340")]
		Type Resolve(Type staticType, object actualValue);
	}
	[Token(Token = "0x200007C")]
	public interface IValueDeserializer
	{
		[Token(Token = "0x6000341")]
		object DeserializeValue(EventReader reader, Type expectedType, SerializerState state, IValueDeserializer nestedObjectDeserializer);
	}
	[Token(Token = "0x200007D")]
	public interface IValuePromise
	{
		[Token(Token = "0x14000001")]
		event Action<object> ValueAvailable;
	}
	[Token(Token = "0x200007E")]
	public interface IYamlSerializable
	{
		[Token(Token = "0x6000344")]
		void ReadYaml(IParser parser);

		[Token(Token = "0x6000345")]
		void WriteYaml(IEmitter emitter);
	}
	[Token(Token = "0x200007F")]
	public interface IYamlTypeConverter
	{
		[Token(Token = "0x6000346")]
		bool Accepts(Type type);

		[Token(Token = "0x6000347")]
		object ReadYaml(IParser parser, Type type);

		[Token(Token = "0x6000348")]
		void WriteYaml(IEmitter emitter, object value, Type type);
	}
}
namespace YamlDotNet.Serialization.NamingConventions
{
	[Token(Token = "0x2000080")]
	public sealed class CamelCaseNamingConvention : INamingConvention
	{
		[Token(Token = "0x6000349")]
		[Address(RVA = "0xB11640", Offset = "0xB11640", VA = "0xB11640")]
		public CamelCaseNamingConvention()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xB11648", Offset = "0xB11648", VA = "0xB11648", Slot = "4")]
		public string Apply(string value)
		{
			return null;
		}
	}
	[Token(Token = "0x2000081")]
	public sealed class HyphenatedNamingConvention : INamingConvention
	{
		[Token(Token = "0x600034B")]
		[Address(RVA = "0xB11654", Offset = "0xB11654", VA = "0xB11654")]
		public HyphenatedNamingConvention()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xB1165C", Offset = "0xB1165C", VA = "0xB1165C", Slot = "4")]
		public string Apply(string value)
		{
			return null;
		}
	}
	[Token(Token = "0x2000082")]
	public sealed class NullNamingConvention : INamingConvention
	{
		[Token(Token = "0x600034D")]
		[Address(RVA = "0xB0EA0C", Offset = "0xB0EA0C", VA = "0xB0EA0C")]
		public NullNamingConvention()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xB116B4", Offset = "0xB116B4", VA = "0xB116B4", Slot = "4")]
		public string Apply(string value)
		{
			return null;
		}
	}
	[Token(Token = "0x2000083")]
	public sealed class PascalCaseNamingConvention : INamingConvention
	{
		[Token(Token = "0x600034F")]
		[Address(RVA = "0xB116BC", Offset = "0xB116BC", VA = "0xB116BC")]
		public PascalCaseNamingConvention()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xB116C4", Offset = "0xB116C4", VA = "0xB116C4", Slot = "4")]
		public string Apply(string value)
		{
			return null;
		}
	}
	[Token(Token = "0x2000084")]
	public sealed class UnderscoredNamingConvention : INamingConvention
	{
		[Token(Token = "0x6000351")]
		[Address(RVA = "0xB116D0", Offset = "0xB116D0", VA = "0xB116D0")]
		public UnderscoredNamingConvention()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xB116D8", Offset = "0xB116D8", VA = "0xB116D8", Slot = "4")]
		public string Apply(string value)
		{
			return null;
		}
	}
}
namespace YamlDotNet.Serialization.NodeDeserializers
{
	[Token(Token = "0x2000085")]
	public sealed class ArrayNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x2000086")]
		[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x582194", Offset = "0x582194")]
		private sealed class ArrayList : IList, IEnumerable, ICollection
		{
			[Token(Token = "0x20000C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5821DC", Offset = "0x5821DC")]
			private sealed class <GetEnumerator>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
			{
				[Token(Token = "0x400017A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				internal int <i>__1;

				[Token(Token = "0x400017B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				internal ArrayList $this;

				[Token(Token = "0x400017C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				internal object $current;

				[Token(Token = "0x400017D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				internal bool $disposing;

				[Token(Token = "0x400017E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				internal int $PC;

				[Token(Token = "0x170000C3")]
				private object System.Collections.Generic.IEnumerator<object>.Current
				{
					[Token(Token = "0x600046B")]
					[Address(RVA = "0x100B6AC", Offset = "0x100B6AC", VA = "0x100B6AC", Slot = "8")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x170000C4")]
				private object System.Collections.IEnumerator.Current
				{
					[Token(Token = "0x600046C")]
					[Address(RVA = "0x100B6B4", Offset = "0x100B6B4", VA = "0x100B6B4", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x6000469")]
				[Address(RVA = "0x100B5B0", Offset = "0x100B5B0", VA = "0x100B5B0")]
				[DebuggerHidden]
				public <GetEnumerator>c__Iterator0()
				{
				}

				[Token(Token = "0x600046A")]
				[Address(RVA = "0x100B5B8", Offset = "0x100B5B8", VA = "0x100B5B8", Slot = "5")]
				public bool MoveNext()
				{
					return default(bool);
				}

				[Token(Token = "0x600046D")]
				[Address(RVA = "0x100B6BC", Offset = "0x100B6BC", VA = "0x100B6BC", Slot = "7")]
				[DebuggerHidden]
				public void Dispose()
				{
				}

				[Token(Token = "0x600046E")]
				[Address(RVA = "0x100B6D0", Offset = "0x100B6D0", VA = "0x100B6D0", Slot = "6")]
				[DebuggerHidden]
				public void Reset()
				{
				}
			}

			[Token(Token = "0x4000107")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private object[] data;

			[Token(Token = "0x4000108")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private int count;

			[Token(Token = "0x1700009A")]
			public bool IsFixedSize
			{
				[Token(Token = "0x600035B")]
				[Address(RVA = "0xB11BA4", Offset = "0xB11BA4", VA = "0xB11BA4", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700009B")]
			public bool IsReadOnly
			{
				[Token(Token = "0x600035C")]
				[Address(RVA = "0xB11BAC", Offset = "0xB11BAC", VA = "0xB11BAC", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700009C")]
			public object Item
			{
				[Token(Token = "0x600035F")]
				[Address(RVA = "0xB11C7C", Offset = "0xB11C7C", VA = "0xB11C7C", Slot = "6")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000360")]
				[Address(RVA = "0xB11CD0", Offset = "0xB11CD0", VA = "0xB11CD0", Slot = "7")]
				set
				{
				}
			}

			[Token(Token = "0x1700009D")]
			public int Count
			{
				[Token(Token = "0x6000362")]
				[Address(RVA = "0xB118DC", Offset = "0xB118DC", VA = "0xB118DC", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700009E")]
			public bool IsSynchronized
			{
				[Token(Token = "0x6000363")]
				[Address(RVA = "0xB11D4C", Offset = "0xB11D4C", VA = "0xB11D4C", Slot = "17")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700009F")]
			public object SyncRoot
			{
				[Token(Token = "0x6000364")]
				[Address(RVA = "0xB11D54", Offset = "0xB11D54", VA = "0xB11D54", Slot = "18")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000355")]
			[Address(RVA = "0xB118B4", Offset = "0xB118B4", VA = "0xB118B4")]
			public ArrayList()
			{
			}

			[Token(Token = "0x6000356")]
			[Address(RVA = "0xB11978", Offset = "0xB11978", VA = "0xB11978", Slot = "8")]
			public int Add(object value)
			{
				return default(int);
			}

			[Token(Token = "0x6000357")]
			[Address(RVA = "0xB11910", Offset = "0xB11910", VA = "0xB11910", Slot = "9")]
			public void Clear()
			{
			}

			[Token(Token = "0x6000358")]
			[Address(RVA = "0xB11A78", Offset = "0xB11A78", VA = "0xB11A78", Slot = "10")]
			public bool Contains(object value)
			{
				return default(bool);
			}

			[Token(Token = "0x6000359")]
			[Address(RVA = "0xB11ADC", Offset = "0xB11ADC", VA = "0xB11ADC", Slot = "11")]
			public int IndexOf(object value)
			{
				return default(int);
			}

			[Token(Token = "0x600035A")]
			[Address(RVA = "0xB11B40", Offset = "0xB11B40", VA = "0xB11B40", Slot = "12")]
			public void Insert(int index, object value)
			{
			}

			[Token(Token = "0x600035D")]
			[Address(RVA = "0xB11BB4", Offset = "0xB11BB4", VA = "0xB11BB4", Slot = "13")]
			public void Remove(object value)
			{
			}

			[Token(Token = "0x600035E")]
			[Address(RVA = "0xB11C18", Offset = "0xB11C18", VA = "0xB11C18", Slot = "14")]
			public void RemoveAt(int index)
			{
			}

			[Token(Token = "0x6000361")]
			[Address(RVA = "0xB118E4", Offset = "0xB118E4", VA = "0xB118E4", Slot = "19")]
			public void CopyTo(Array array, int index)
			{
			}

			[Token(Token = "0x6000365")]
			[Address(RVA = "0xB11D5C", Offset = "0xB11D5C", VA = "0xB11D5C", Slot = "15")]
			[DebuggerHidden]
			public IEnumerator GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xB0EA24", Offset = "0xB0EA24", VA = "0xB0EA24")]
		public ArrayNodeDeserializer()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xB11730", Offset = "0xB11730", VA = "0xB11730", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(EventReader reader, Type expectedType, Func<EventReader, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000087")]
	public sealed class CollectionNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x20000C1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58223C", Offset = "0x58223C")]
		private sealed class <DeserializeHelper>c__AnonStorey0
		{
			[Token(Token = "0x400017F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Type tItem;

			[Token(Token = "0x4000180")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal IList result;

			[Token(Token = "0x600046F")]
			[Address(RVA = "0x100C2FC", Offset = "0x100C2FC", VA = "0x100C2FC")]
			public <DeserializeHelper>c__AnonStorey0()
			{
			}
		}

		[Token(Token = "0x20000C2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58224C", Offset = "0x58224C")]
		private sealed class <DeserializeHelper>c__AnonStorey1
		{
			[Token(Token = "0x4000181")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int index;

			[Token(Token = "0x4000182")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal <DeserializeHelper>c__AnonStorey0 <>f__ref$0;

			[Token(Token = "0x6000470")]
			[Address(RVA = "0x100C388", Offset = "0x100C388", VA = "0x100C388")]
			public <DeserializeHelper>c__AnonStorey1()
			{
			}

			[Token(Token = "0x6000471")]
			[Address(RVA = "0x100C390", Offset = "0x100C390", VA = "0x100C390")]
			internal void <>m__0(object v)
			{
			}
		}

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IObjectFactory _objectFactory;

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x100B734", Offset = "0x100B734", VA = "0x100B734")]
		public CollectionNodeDeserializer(IObjectFactory objectFactory)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x100B760", Offset = "0x100B760", VA = "0x100B760", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(EventReader reader, Type expectedType, Func<EventReader, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x100BE10", Offset = "0x100BE10", VA = "0x100BE10")]
		internal static void DeserializeHelper(Type tItem, EventReader reader, Type expectedType, Func<EventReader, Type, object> nestedObjectDeserializer, IList result, bool canUpdate)
		{
		}
	}
	[Token(Token = "0x2000088")]
	public sealed class DictionaryNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x20000C3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58225C", Offset = "0x58225C")]
		private sealed class <DeserializeHelper>c__AnonStorey0
		{
			[Token(Token = "0x4000183")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal IDictionary result;

			[Token(Token = "0x6000472")]
			[Address(RVA = "0x100CD30", Offset = "0x100CD30", VA = "0x100CD30")]
			public <DeserializeHelper>c__AnonStorey0()
			{
			}
		}

		[Token(Token = "0x20000C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58226C", Offset = "0x58226C")]
		private sealed class <DeserializeHelper>c__AnonStorey1
		{
			[Token(Token = "0x4000184")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal object key;

			[Token(Token = "0x4000185")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal object value;

			[Token(Token = "0x4000186")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal <DeserializeHelper>c__AnonStorey0 <>f__ref$0;

			[Token(Token = "0x6000473")]
			[Address(RVA = "0x100CD38", Offset = "0x100CD38", VA = "0x100CD38")]
			public <DeserializeHelper>c__AnonStorey1()
			{
			}

			[Token(Token = "0x6000474")]
			[Address(RVA = "0x100CD48", Offset = "0x100CD48", VA = "0x100CD48")]
			internal void <>m__0(object v)
			{
			}

			[Token(Token = "0x6000475")]
			[Address(RVA = "0x100CE20", Offset = "0x100CE20", VA = "0x100CE20")]
			internal void <>m__1(object v)
			{
			}
		}

		[Token(Token = "0x20000C5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58227C", Offset = "0x58227C")]
		private sealed class <DeserializeHelper>c__AnonStorey2
		{
			[Token(Token = "0x4000187")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool hasFirstPart;

			[Token(Token = "0x4000188")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal <DeserializeHelper>c__AnonStorey0 <>f__ref$0;

			[Token(Token = "0x4000189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal <DeserializeHelper>c__AnonStorey1 <>f__ref$1;

			[Token(Token = "0x6000476")]
			[Address(RVA = "0x100CD40", Offset = "0x100CD40", VA = "0x100CD40")]
			public <DeserializeHelper>c__AnonStorey2()
			{
			}

			[Token(Token = "0x6000477")]
			[Address(RVA = "0x100CEF8", Offset = "0x100CEF8", VA = "0x100CEF8")]
			internal void <>m__0(object v)
			{
			}

			[Token(Token = "0x6000478")]
			[Address(RVA = "0x100D00C", Offset = "0x100D00C", VA = "0x100D00C")]
			internal void <>m__1(object v)
			{
			}
		}

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IObjectFactory _objectFactory;

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x100C488", Offset = "0x100C488", VA = "0x100C488")]
		public DictionaryNodeDeserializer(IObjectFactory objectFactory)
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x100C4B4", Offset = "0x100C4B4", VA = "0x100C4B4", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(EventReader reader, Type expectedType, Func<EventReader, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x100C840", Offset = "0x100C840", VA = "0x100C840")]
		private static void DeserializeHelper(Type tKey, Type tValue, EventReader reader, Type expectedType, Func<EventReader, Type, object> nestedObjectDeserializer, IDictionary result)
		{
		}
	}
	[Token(Token = "0x2000089")]
	public sealed class EnumerableNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x100D120", Offset = "0x100D120", VA = "0x100D120")]
		public EnumerableNodeDeserializer()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x100D128", Offset = "0x100D128", VA = "0x100D128", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(EventReader reader, Type expectedType, Func<EventReader, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200008A")]
	public sealed class NullNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x100D38C", Offset = "0x100D38C", VA = "0x100D38C")]
		public NullNodeDeserializer()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x100D394", Offset = "0x100D394", VA = "0x100D394", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(EventReader reader, Type expectedType, Func<EventReader, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x100D430", Offset = "0x100D430", VA = "0x100D430")]
		private bool NodeIsNull(NodeEvent nodeEvent)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200008B")]
	public sealed class ObjectNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x20000C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58228C", Offset = "0x58228C")]
		private sealed class <YamlDotNet_Serialization_INodeDeserializer_Deserialize>c__AnonStorey0
		{
			[Token(Token = "0x400018A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal IPropertyDescriptor property;

			[Token(Token = "0x6000479")]
			[Address(RVA = "0x100DC04", Offset = "0x100DC04", VA = "0x100DC04")]
			public <YamlDotNet_Serialization_INodeDeserializer_Deserialize>c__AnonStorey0()
			{
			}
		}

		[Token(Token = "0x20000C7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58229C", Offset = "0x58229C")]
		private sealed class <YamlDotNet_Serialization_INodeDeserializer_Deserialize>c__AnonStorey1
		{
			[Token(Token = "0x400018B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal object valueRef;

			[Token(Token = "0x400018C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal <YamlDotNet_Serialization_INodeDeserializer_Deserialize>c__AnonStorey0 <>f__ref$0;

			[Token(Token = "0x600047A")]
			[Address(RVA = "0x100DC0C", Offset = "0x100DC0C", VA = "0x100DC0C")]
			public <YamlDotNet_Serialization_INodeDeserializer_Deserialize>c__AnonStorey1()
			{
			}

			[Token(Token = "0x600047B")]
			[Address(RVA = "0x100DC14", Offset = "0x100DC14", VA = "0x100DC14")]
			internal void <>m__0(object v)
			{
			}
		}

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IObjectFactory _objectFactory;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly ITypeInspector _typeDescriptor;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly bool _ignoreUnmatched;

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x100D678", Offset = "0x100D678", VA = "0x100D678")]
		public ObjectNodeDeserializer(IObjectFactory objectFactory, ITypeInspector typeDescriptor, bool ignoreUnmatched)
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x100D6BC", Offset = "0x100D6BC", VA = "0x100D6BC", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(EventReader reader, Type expectedType, Func<EventReader, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200008C")]
	public sealed class ScalarNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x100DD78", Offset = "0x100DD78", VA = "0x100DD78")]
		public ScalarNodeDeserializer()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x100DD80", Offset = "0x100DD80", VA = "0x100DD80", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(EventReader reader, Type expectedType, Func<EventReader, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x100E214", Offset = "0x100E214", VA = "0x100E214")]
		private object DeserializeIntegerHelper(TypeCode typeCode, string value, IFormatProvider formatProvider)
		{
			return null;
		}
	}
	[Token(Token = "0x200008D")]
	public sealed class TypeConverterNodeDeserializer : INodeDeserializer
	{
		[Token(Token = "0x20000C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5822AC", Offset = "0x5822AC")]
		private sealed class <YamlDotNet_Serialization_INodeDeserializer_Deserialize>c__AnonStorey0
		{
			[Token(Token = "0x400018D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Type expectedType;

			[Token(Token = "0x600047C")]
			[Address(RVA = "0x100E970", Offset = "0x100E970", VA = "0x100E970")]
			public <YamlDotNet_Serialization_INodeDeserializer_Deserialize>c__AnonStorey0()
			{
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0x100E978", Offset = "0x100E978", VA = "0x100E978")]
			internal bool <>m__0(IYamlTypeConverter c)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IEnumerable<IYamlTypeConverter> converters;

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x100E744", Offset = "0x100E744", VA = "0x100E744")]
		public TypeConverterNodeDeserializer(IEnumerable<IYamlTypeConverter> converters)
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x100E7E4", Offset = "0x100E7E4", VA = "0x100E7E4", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeDeserializer.Deserialize(EventReader reader, Type expectedType, Func<EventReader, Type, object> nestedObjectDeserializer, out object value)
		{
			return default(bool);
		}
	}
}
namespace YamlDotNet.Serialization.NodeTypeResolvers
{
	[Token(Token = "0x200008E")]
	public sealed class DefaultContainersNodeTypeResolver : INodeTypeResolver
	{
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x100EA38", Offset = "0x100EA38", VA = "0x100EA38")]
		public DefaultContainersNodeTypeResolver()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x100EA40", Offset = "0x100EA40", VA = "0x100EA40", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeTypeResolver.Resolve(NodeEvent nodeEvent, ref Type currentType)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200008F")]
	public sealed class TagNodeTypeResolver : INodeTypeResolver
	{
		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IDictionary<string, Type> tagMappings;

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x100EB94", Offset = "0x100EB94", VA = "0x100EB94")]
		public TagNodeTypeResolver(IDictionary<string, Type> tagMappings)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x100EC34", Offset = "0x100EC34", VA = "0x100EC34", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeTypeResolver.Resolve(NodeEvent nodeEvent, ref Type currentType)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000090")]
	public sealed class TypeNameInTagNodeTypeResolver : INodeTypeResolver
	{
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x100ED94", Offset = "0x100ED94", VA = "0x100ED94")]
		public TypeNameInTagNodeTypeResolver()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x100ED9C", Offset = "0x100ED9C", VA = "0x100ED9C", Slot = "4")]
		private bool YamlDotNet.Serialization.INodeTypeResolver.Resolve(NodeEvent nodeEvent, ref Type currentType)
		{
			return default(bool);
		}
	}
}
namespace YamlDotNet.Serialization
{
	[Token(Token = "0x2000091")]
	public sealed class ObjectDescriptor : IObjectDescriptor
	{
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5822BC", Offset = "0x5822BC")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x5822BC", Offset = "0x5822BC")]
		private object <Value>k__BackingField;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5822F8", Offset = "0x5822F8")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x5822F8", Offset = "0x5822F8")]
		private Type <Type>k__BackingField;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582334", Offset = "0x582334")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x582334", Offset = "0x582334")]
		private Type <StaticType>k__BackingField;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582370", Offset = "0x582370")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x582370", Offset = "0x582370")]
		private ScalarStyle <ScalarStyle>k__BackingField;

		[Token(Token = "0x170000A0")]
		public object Value
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x100F050", Offset = "0x100F050", VA = "0x100F050", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5823AC", Offset = "0x5823AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x100F030", Offset = "0x100F030", VA = "0x100F030")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5823BC", Offset = "0x5823BC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public Type Type
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x100F058", Offset = "0x100F058", VA = "0x100F058", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5823CC", Offset = "0x5823CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x100F038", Offset = "0x100F038", VA = "0x100F038")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5823DC", Offset = "0x5823DC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public Type StaticType
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x100F060", Offset = "0x100F060", VA = "0x100F060", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5823EC", Offset = "0x5823EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x100F040", Offset = "0x100F040", VA = "0x100F040")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5823FC", Offset = "0x5823FC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public ScalarStyle ScalarStyle
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x100F068", Offset = "0x100F068", VA = "0x100F068", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58240C", Offset = "0x58240C")]
			get
			{
				return default(ScalarStyle);
			}
			[Token(Token = "0x6000387")]
			[Address(RVA = "0x100F048", Offset = "0x100F048", VA = "0x100F048")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58241C", Offset = "0x58241C")]
			private set
			{
			}
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x100EF48", Offset = "0x100EF48", VA = "0x100EF48")]
		public ObjectDescriptor(object value, Type type, Type staticType)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x100EF50", Offset = "0x100EF50", VA = "0x100EF50")]
		public ObjectDescriptor(object value, Type type, Type staticType, ScalarStyle scalarStyle)
		{
		}
	}
}
namespace YamlDotNet.Serialization.ObjectFactories
{
	[Token(Token = "0x2000092")]
	public sealed class DefaultObjectFactory : IObjectFactory
	{
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Type, Type> defaultInterfaceImplementations;

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x100F098", Offset = "0x100F098", VA = "0x100F098")]
		public DefaultObjectFactory()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x100F0A0", Offset = "0x100F0A0", VA = "0x100F0A0", Slot = "4")]
		public object Create(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x2000093")]
	public sealed class LambdaObjectFactory : IObjectFactory
	{
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Func<Type, object> _factory;

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x100F4D0", Offset = "0x100F4D0", VA = "0x100F4D0")]
		public LambdaObjectFactory(Func<Type, object> factory)
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x100F570", Offset = "0x100F570", VA = "0x100F570", Slot = "4")]
		public object Create(Type type)
		{
			return null;
		}
	}
}
namespace YamlDotNet.Serialization.ObjectGraphTraversalStrategies
{
	[Token(Token = "0x2000094")]
	public class FullObjectGraphTraversalStrategy : IObjectGraphTraversalStrategy
	{
		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected readonly Serializer serializer;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly int maxRecursion;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly ITypeInspector typeDescriptor;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly ITypeResolver typeResolver;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private INamingConvention namingConvention;

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x100F5DC", Offset = "0x100F5DC", VA = "0x100F5DC")]
		public FullObjectGraphTraversalStrategy(Serializer serializer, ITypeInspector typeDescriptor, ITypeResolver typeResolver, int maxRecursion, INamingConvention namingConvention)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x100F748", Offset = "0x100F748", VA = "0x100F748", Slot = "4")]
		private void YamlDotNet.Serialization.IObjectGraphTraversalStrategy.Traverse(IObjectDescriptor graph, IObjectGraphVisitor visitor)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x100F758", Offset = "0x100F758", VA = "0x100F758", Slot = "5")]
		protected virtual void Traverse(IObjectDescriptor value, IObjectGraphVisitor visitor, int currentDepth)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x100FFA8", Offset = "0x100FFA8", VA = "0x100FFA8", Slot = "6")]
		protected virtual void TraverseObject(IObjectDescriptor value, IObjectGraphVisitor visitor, int currentDepth)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x1010BB4", Offset = "0x1010BB4", VA = "0x1010BB4", Slot = "7")]
		protected virtual void TraverseDictionary(IObjectDescriptor dictionary, IObjectGraphVisitor visitor, int currentDepth, Type keyType, Type valueType)
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x10105C4", Offset = "0x10105C4", VA = "0x10105C4")]
		private void TraverseList(IObjectDescriptor value, IObjectGraphVisitor visitor, int currentDepth)
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1011470", Offset = "0x1011470", VA = "0x1011470", Slot = "8")]
		protected virtual void TraverseProperties(IObjectDescriptor value, IObjectGraphVisitor visitor, int currentDepth)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x1011370", Offset = "0x1011370", VA = "0x1011370")]
		private IObjectDescriptor GetObjectDescriptor(object value, Type staticType)
		{
			return null;
		}
	}
	[Token(Token = "0x2000095")]
	public class RoundtripObjectGraphTraversalStrategy : FullObjectGraphTraversalStrategy
	{
		[Token(Token = "0x20000C9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58242C", Offset = "0x58242C")]
		private sealed class <TraverseProperties>c__AnonStorey0
		{
			[Token(Token = "0x400018E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal IObjectDescriptor value;

			[Token(Token = "0x600047E")]
			[Address(RVA = "0x1011FC8", Offset = "0x1011FC8", VA = "0x1011FC8")]
			public <TraverseProperties>c__AnonStorey0()
			{
			}

			[Token(Token = "0x600047F")]
			[Address(RVA = "0x1011FD8", Offset = "0x1011FD8", VA = "0x1011FD8")]
			internal bool <>m__0(IYamlTypeConverter c)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1011C48", Offset = "0x1011C48", VA = "0x1011C48")]
		public RoundtripObjectGraphTraversalStrategy(Serializer serializer, ITypeInspector typeDescriptor, ITypeResolver typeResolver, int maxRecursion)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x1011C50", Offset = "0x1011C50", VA = "0x1011C50", Slot = "8")]
		protected override void TraverseProperties(IObjectDescriptor value, IObjectGraphVisitor visitor, int currentDepth)
		{
		}
	}
}
namespace YamlDotNet.Serialization.ObjectGraphVisitors
{
	[Token(Token = "0x2000096")]
	public sealed class AnchorAssigner : IObjectGraphVisitor, IAliasProvider
	{
		[Token(Token = "0x2000097")]
		private class AnchorAssignment
		{
			[Token(Token = "0x400011D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Anchor;

			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x10125BC", Offset = "0x10125BC", VA = "0x10125BC")]
			public AnchorAssignment()
			{
			}
		}

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IDictionary<object, AnchorAssignment> assignments;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private uint nextId;

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x1012110", Offset = "0x1012110", VA = "0x1012110")]
		public AnchorAssigner()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x1012180", Offset = "0x1012180", VA = "0x1012180", Slot = "4")]
		private bool YamlDotNet.Serialization.IObjectGraphVisitor.Enter(IObjectDescriptor value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x10125C4", Offset = "0x10125C4", VA = "0x10125C4", Slot = "5")]
		private bool YamlDotNet.Serialization.IObjectGraphVisitor.EnterMapping(IObjectDescriptor key, IObjectDescriptor value)
		{
			return default(bool);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x10125CC", Offset = "0x10125CC", VA = "0x10125CC", Slot = "6")]
		private bool YamlDotNet.Serialization.IObjectGraphVisitor.EnterMapping(IPropertyDescriptor key, IObjectDescriptor value)
		{
			return default(bool);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x10125D4", Offset = "0x10125D4", VA = "0x10125D4", Slot = "7")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor.VisitScalar(IObjectDescriptor scalar)
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x10125D8", Offset = "0x10125D8", VA = "0x10125D8", Slot = "8")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor.VisitMappingStart(IObjectDescriptor mapping, Type keyType, Type valueType)
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x10125DC", Offset = "0x10125DC", VA = "0x10125DC", Slot = "9")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor.VisitMappingEnd(IObjectDescriptor mapping)
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x10125E0", Offset = "0x10125E0", VA = "0x10125E0", Slot = "10")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor.VisitSequenceStart(IObjectDescriptor sequence, Type elementType)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x10125E4", Offset = "0x10125E4", VA = "0x10125E4", Slot = "11")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor.VisitSequenceEnd(IObjectDescriptor sequence)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x10125E8", Offset = "0x10125E8", VA = "0x10125E8", Slot = "12")]
		private string YamlDotNet.Serialization.IAliasProvider.GetAlias(object target)
		{
			return null;
		}
	}
	[Token(Token = "0x2000098")]
	public sealed class AnchorAssigningObjectGraphVisitor : ChainedObjectGraphVisitor
	{
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IEventEmitter eventEmitter;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly IAliasProvider aliasProvider;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly HashSet<string> emittedAliases;

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x10126E4", Offset = "0x10126E4", VA = "0x10126E4")]
		public AnchorAssigningObjectGraphVisitor(IObjectGraphVisitor nextVisitor, IEventEmitter eventEmitter, IAliasProvider aliasProvider)
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x10127A8", Offset = "0x10127A8", VA = "0x10127A8", Slot = "12")]
		public override bool Enter(IObjectDescriptor value)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x1012AA0", Offset = "0x1012AA0", VA = "0x1012AA0", Slot = "16")]
		public override void VisitMappingStart(IObjectDescriptor mapping, Type keyType, Type valueType)
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1012C80", Offset = "0x1012C80", VA = "0x1012C80", Slot = "18")]
		public override void VisitSequenceStart(IObjectDescriptor sequence, Type elementType)
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x1012E68", Offset = "0x1012E68", VA = "0x1012E68", Slot = "15")]
		public override void VisitScalar(IObjectDescriptor scalar)
		{
		}
	}
	[Token(Token = "0x2000099")]
	public abstract class ChainedObjectGraphVisitor : IObjectGraphVisitor
	{
		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IObjectGraphVisitor nextVisitor;

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x101277C", Offset = "0x101277C", VA = "0x101277C")]
		protected ChainedObjectGraphVisitor(IObjectGraphVisitor nextVisitor)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x10129E0", Offset = "0x10129E0", VA = "0x10129E0", Slot = "12")]
		public virtual bool Enter(IObjectDescriptor value)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x1013118", Offset = "0x1013118", VA = "0x1013118", Slot = "13")]
		public virtual bool EnterMapping(IObjectDescriptor key, IObjectDescriptor value)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x10131E4", Offset = "0x10131E4", VA = "0x10131E4", Slot = "14")]
		public virtual bool EnterMapping(IPropertyDescriptor key, IObjectDescriptor value)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x10132B0", Offset = "0x10132B0", VA = "0x10132B0", Slot = "15")]
		public virtual void VisitScalar(IObjectDescriptor scalar)
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1013374", Offset = "0x1013374", VA = "0x1013374", Slot = "16")]
		public virtual void VisitMappingStart(IObjectDescriptor mapping, Type keyType, Type valueType)
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x1013450", Offset = "0x1013450", VA = "0x1013450", Slot = "17")]
		public virtual void VisitMappingEnd(IObjectDescriptor mapping)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x1013514", Offset = "0x1013514", VA = "0x1013514", Slot = "18")]
		public virtual void VisitSequenceStart(IObjectDescriptor sequence, Type elementType)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x10135E0", Offset = "0x10135E0", VA = "0x10135E0", Slot = "19")]
		public virtual void VisitSequenceEnd(IObjectDescriptor sequence)
		{
		}
	}
	[Token(Token = "0x200009A")]
	public sealed class CustomSerializationObjectGraphVisitor : ChainedObjectGraphVisitor
	{
		[Token(Token = "0x20000CA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58243C", Offset = "0x58243C")]
		private sealed class <Enter>c__AnonStorey0
		{
			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal IObjectDescriptor value;

			[Token(Token = "0x6000480")]
			[Address(RVA = "0x1013A40", Offset = "0x1013A40", VA = "0x1013A40")]
			public <Enter>c__AnonStorey0()
			{
			}

			[Token(Token = "0x6000481")]
			[Address(RVA = "0x1013A48", Offset = "0x1013A48", VA = "0x1013A48")]
			internal bool <>m__0(IYamlTypeConverter t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IEmitter emitter;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly IEnumerable<IYamlTypeConverter> typeConverters;

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x10136A4", Offset = "0x10136A4", VA = "0x10136A4")]
		public CustomSerializationObjectGraphVisitor(IEmitter emitter, IObjectGraphVisitor nextVisitor, IEnumerable<IYamlTypeConverter> typeConverters)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x1013748", Offset = "0x1013748", VA = "0x1013748", Slot = "12")]
		public override bool Enter(IObjectDescriptor value)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200009B")]
	public sealed class DefaultExclusiveObjectGraphVisitor : ChainedObjectGraphVisitor
	{
		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly IEqualityComparer<object> _objectComparer;

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x1013B80", Offset = "0x1013B80", VA = "0x1013B80")]
		public DefaultExclusiveObjectGraphVisitor(IObjectGraphVisitor nextVisitor)
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x1013BAC", Offset = "0x1013BAC", VA = "0x1013BAC")]
		private static object GetDefault(Type type)
		{
			return null;
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x1013C3C", Offset = "0x1013C3C", VA = "0x1013C3C", Slot = "13")]
		public override bool EnterMapping(IObjectDescriptor key, IObjectDescriptor value)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x1013DE4", Offset = "0x1013DE4", VA = "0x1013DE4", Slot = "14")]
		public override bool EnterMapping(IPropertyDescriptor key, IObjectDescriptor value)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200009C")]
	public sealed class EmittingObjectGraphVisitor : IObjectGraphVisitor
	{
		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IEventEmitter eventEmitter;

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x101414C", Offset = "0x101414C", VA = "0x101414C")]
		public EmittingObjectGraphVisitor(IEventEmitter eventEmitter)
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x1014178", Offset = "0x1014178", VA = "0x1014178", Slot = "4")]
		private bool YamlDotNet.Serialization.IObjectGraphVisitor.Enter(IObjectDescriptor value)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x1014180", Offset = "0x1014180", VA = "0x1014180", Slot = "5")]
		private bool YamlDotNet.Serialization.IObjectGraphVisitor.EnterMapping(IObjectDescriptor key, IObjectDescriptor value)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x1014188", Offset = "0x1014188", VA = "0x1014188", Slot = "6")]
		private bool YamlDotNet.Serialization.IObjectGraphVisitor.EnterMapping(IPropertyDescriptor key, IObjectDescriptor value)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x1014190", Offset = "0x1014190", VA = "0x1014190", Slot = "7")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor.VisitScalar(IObjectDescriptor scalar)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x1014270", Offset = "0x1014270", VA = "0x1014270", Slot = "8")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor.VisitMappingStart(IObjectDescriptor mapping, Type keyType, Type valueType)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x1014354", Offset = "0x1014354", VA = "0x1014354", Slot = "9")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor.VisitMappingEnd(IObjectDescriptor mapping)
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x1014438", Offset = "0x1014438", VA = "0x1014438", Slot = "10")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor.VisitSequenceStart(IObjectDescriptor sequence, Type elementType)
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x101451C", Offset = "0x101451C", VA = "0x101451C", Slot = "11")]
		private void YamlDotNet.Serialization.IObjectGraphVisitor.VisitSequenceEnd(IObjectDescriptor sequence)
		{
		}
	}
}
namespace YamlDotNet.Serialization
{
	[Token(Token = "0x200009D")]
	public sealed class PropertyDescriptor : IPropertyDescriptor
	{
		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IPropertyDescriptor baseDescriptor;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58244C", Offset = "0x58244C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x58244C", Offset = "0x58244C")]
		private string <Name>k__BackingField;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582488", Offset = "0x582488")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x582488", Offset = "0x582488")]
		private int <Order>k__BackingField;

		[Token(Token = "0x170000A4")]
		public string Name
		{
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x10146E0", Offset = "0x10146E0", VA = "0x10146E0", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5824C4", Offset = "0x5824C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x10146D8", Offset = "0x10146D8", VA = "0x10146D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5824D4", Offset = "0x5824D4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public Type Type
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x10146E8", Offset = "0x10146E8", VA = "0x10146E8", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A6")]
		public Type TypeOverride
		{
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x101479C", Offset = "0x101479C", VA = "0x101479C", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x1014850", Offset = "0x1014850", VA = "0x1014850", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public int Order
		{
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x1014914", Offset = "0x1014914", VA = "0x1014914", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5824E4", Offset = "0x5824E4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x101491C", Offset = "0x101491C", VA = "0x101491C", Slot = "10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5824F4", Offset = "0x5824F4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public ScalarStyle ScalarStyle
		{
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x1014924", Offset = "0x1014924", VA = "0x1014924", Slot = "11")]
			get
			{
				return default(ScalarStyle);
			}
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x10149D8", Offset = "0x10149D8", VA = "0x10149D8", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public bool CanWrite
		{
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x1014A9C", Offset = "0x1014A9C", VA = "0x1014A9C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x1014608", Offset = "0x1014608", VA = "0x1014608")]
		public PropertyDescriptor(IPropertyDescriptor baseDescriptor)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x1014B50", Offset = "0x1014B50", VA = "0x1014B50", Slot = "15")]
		public void Write(object target, object value)
		{
		}

		[Token(Token = "0x60003CC")]
		public T GetCustomAttribute<T>() where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x1014C1C", Offset = "0x1014C1C", VA = "0x1014C1C", Slot = "14")]
		public IObjectDescriptor Read(object target)
		{
			return null;
		}
	}
	[Token(Token = "0x200009E")]
	[Flags]
	public enum SerializationOptions
	{
		[Token(Token = "0x400012A")]
		None = 0,
		[Token(Token = "0x400012B")]
		Roundtrip = 1,
		[Token(Token = "0x400012C")]
		DisableAliases = 2,
		[Token(Token = "0x400012D")]
		EmitDefaults = 4,
		[Token(Token = "0x400012E")]
		JsonCompatible = 8,
		[Token(Token = "0x400012F")]
		DefaultToStaticType = 0x10
	}
	[Token(Token = "0x200009F")]
	public sealed class Serializer
	{
		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582514", Offset = "0x582514")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x582514", Offset = "0x582514")]
		private IList<IYamlTypeConverter> <Converters>k__BackingField;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly SerializationOptions options;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly INamingConvention namingConvention;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly ITypeResolver typeResolver;

		[Token(Token = "0x170000AA")]
		internal IList<IYamlTypeConverter> Converters
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x1011FD0", Offset = "0x1011FD0", VA = "0x1011FD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582550", Offset = "0x582550")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x10150E8", Offset = "0x10150E8", VA = "0x10150E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582560", Offset = "0x582560")]
			private set
			{
			}
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x1014D4C", Offset = "0x1014D4C", VA = "0x1014D4C")]
		public Serializer(SerializationOptions options = SerializationOptions.None, [Optional] INamingConvention namingConvention)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x1015158", Offset = "0x1015158", VA = "0x1015158")]
		private bool IsOptionSet(SerializationOptions option)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x1015178", Offset = "0x1015178", VA = "0x1015178")]
		public void RegisterTypeConverter(IYamlTypeConverter converter)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x101523C", Offset = "0x101523C", VA = "0x101523C")]
		public void Serialize(TextWriter writer, object graph)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1015444", Offset = "0x1015444", VA = "0x1015444")]
		public void Serialize(TextWriter writer, object graph, Type type)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x10152B8", Offset = "0x10152B8", VA = "0x10152B8")]
		public void Serialize(IEmitter emitter, object graph)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x10154D0", Offset = "0x10154D0", VA = "0x10154D0")]
		public void Serialize(IEmitter emitter, object graph, Type type)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x10155C4", Offset = "0x10155C4", VA = "0x10155C4")]
		private void EmitDocument(IEmitter emitter, IObjectDescriptor graph)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1015B2C", Offset = "0x1015B2C", VA = "0x1015B2C")]
		private IObjectGraphVisitor CreateEmittingVisitor(IEmitter emitter, IObjectGraphTraversalStrategy traversalStrategy, IEventEmitter eventEmitter, IObjectDescriptor graph)
		{
			return null;
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1015A68", Offset = "0x1015A68", VA = "0x1015A68")]
		private IEventEmitter CreateEventEmitter(IEmitter emitter)
		{
			return null;
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x10158F4", Offset = "0x10158F4", VA = "0x10158F4")]
		private IObjectGraphTraversalStrategy CreateTraversalStrategy()
		{
			return null;
		}
	}
	[Token(Token = "0x20000A0")]
	public sealed class StreamFragment : IYamlSerializable
	{
		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<ParsingEvent> events;

		[Token(Token = "0x170000AB")]
		public IList<ParsingEvent> Events
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x1015FC4", Offset = "0x1015FC4", VA = "0x1015FC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x1015F54", Offset = "0x1015F54", VA = "0x1015F54")]
		public StreamFragment()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x1015FCC", Offset = "0x1015FCC", VA = "0x1015FCC", Slot = "4")]
		private void YamlDotNet.Serialization.IYamlSerializable.ReadYaml(IParser parser)
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x1016228", Offset = "0x1016228", VA = "0x1016228", Slot = "5")]
		private void YamlDotNet.Serialization.IYamlSerializable.WriteYaml(IEmitter emitter)
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public sealed class TagMappings
	{
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IDictionary<string, Type> mappings;

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x10163A0", Offset = "0x10163A0", VA = "0x10163A0")]
		public TagMappings()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1016414", Offset = "0x1016414", VA = "0x1016414")]
		public TagMappings(IDictionary<string, Type> mappings)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x1016498", Offset = "0x1016498", VA = "0x1016498")]
		public void Add(string tag, Type mapping)
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1016560", Offset = "0x1016560", VA = "0x1016560")]
		internal Type GetMapping(string tag)
		{
			return null;
		}
	}
}
namespace YamlDotNet.Serialization.TypeInspectors
{
	[Token(Token = "0x20000A2")]
	public sealed class CachedTypeInspector : TypeInspectorSkeleton
	{
		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ITypeInspector innerTypeDescriptor;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Dictionary<Type, List<IPropertyDescriptor>> cache;

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x1015E8C", Offset = "0x1015E8C", VA = "0x1015E8C")]
		public CachedTypeInspector(ITypeInspector innerTypeDescriptor)
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x101664C", Offset = "0x101664C", VA = "0x101664C", Slot = "6")]
		public override IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A3")]
	public sealed class NamingConventionTypeInspector : TypeInspectorSkeleton
	{
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ITypeInspector innerTypeDescriptor;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly INamingConvention namingConvention;

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x1015D98", Offset = "0x1015D98", VA = "0x1015D98")]
		public NamingConventionTypeInspector(ITypeInspector innerTypeDescriptor, INamingConvention namingConvention)
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x1016790", Offset = "0x1016790", VA = "0x1016790", Slot = "6")]
		public override IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container)
		{
			return null;
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x10168B4", Offset = "0x10168B4", VA = "0x10168B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582570", Offset = "0x582570")]
		private IPropertyDescriptor <GetProperties>m__0(IPropertyDescriptor p)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A4")]
	public sealed class ReadableAndWritablePropertiesTypeInspector : TypeInspectorSkeleton
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ITypeInspector _innerTypeDescriptor;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582580", Offset = "0x582580")]
		private static Func<IPropertyDescriptor, bool> <>f__am$cache0;

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x1015D6C", Offset = "0x1015D6C", VA = "0x1015D6C")]
		public ReadableAndWritablePropertiesTypeInspector(ITypeInspector innerTypeDescriptor)
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1016A1C", Offset = "0x1016A1C", VA = "0x1016A1C", Slot = "6")]
		public override IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container)
		{
			return null;
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x1016B68", Offset = "0x1016B68", VA = "0x1016B68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582590", Offset = "0x582590")]
		private static bool <GetProperties>m__0(IPropertyDescriptor p)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000A5")]
	public sealed class ReadablePropertiesTypeInspector : TypeInspectorSkeleton
	{
		[Token(Token = "0x20000A6")]
		private sealed class ReflectionPropertyDescriptor : IPropertyDescriptor
		{
			[Token(Token = "0x400013E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly PropertyInfo _propertyInfo;

			[Token(Token = "0x400013F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly ITypeResolver _typeResolver;

			[Token(Token = "0x4000140")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5825C0", Offset = "0x5825C0")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x5825C0", Offset = "0x5825C0")]
			private Type <TypeOverride>k__BackingField;

			[Token(Token = "0x4000141")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5825FC", Offset = "0x5825FC")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x5825FC", Offset = "0x5825FC")]
			private int <Order>k__BackingField;

			[Token(Token = "0x4000142")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582638", Offset = "0x582638")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x582638", Offset = "0x582638")]
			private ScalarStyle <ScalarStyle>k__BackingField;

			[Token(Token = "0x170000AC")]
			public string Name
			{
				[Token(Token = "0x60003F0")]
				[Address(RVA = "0x1016EBC", Offset = "0x1016EBC", VA = "0x1016EBC", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AD")]
			public Type Type
			{
				[Token(Token = "0x60003F1")]
				[Address(RVA = "0x1016EEC", Offset = "0x1016EEC", VA = "0x1016EEC", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AE")]
			public Type TypeOverride
			{
				[Token(Token = "0x60003F2")]
				[Address(RVA = "0x1016F20", Offset = "0x1016F20", VA = "0x1016F20", Slot = "7")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582674", Offset = "0x582674")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003F3")]
				[Address(RVA = "0x1016F28", Offset = "0x1016F28", VA = "0x1016F28", Slot = "8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582684", Offset = "0x582684")]
				set
				{
				}
			}

			[Token(Token = "0x170000AF")]
			public int Order
			{
				[Token(Token = "0x60003F4")]
				[Address(RVA = "0x1016F30", Offset = "0x1016F30", VA = "0x1016F30", Slot = "9")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582694", Offset = "0x582694")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60003F5")]
				[Address(RVA = "0x1016F38", Offset = "0x1016F38", VA = "0x1016F38", Slot = "10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5826A4", Offset = "0x5826A4")]
				set
				{
				}
			}

			[Token(Token = "0x170000B0")]
			public bool CanWrite
			{
				[Token(Token = "0x60003F6")]
				[Address(RVA = "0x1016F40", Offset = "0x1016F40", VA = "0x1016F40", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000B1")]
			public ScalarStyle ScalarStyle
			{
				[Token(Token = "0x60003F7")]
				[Address(RVA = "0x1016F74", Offset = "0x1016F74", VA = "0x1016F74", Slot = "11")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5826B4", Offset = "0x5826B4")]
				get
				{
					return default(ScalarStyle);
				}
				[Token(Token = "0x60003F8")]
				[Address(RVA = "0x1016EB4", Offset = "0x1016EB4", VA = "0x1016EB4", Slot = "12")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5826C4", Offset = "0x5826C4")]
				set
				{
				}
			}

			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x1016E78", Offset = "0x1016E78", VA = "0x1016E78")]
			public ReflectionPropertyDescriptor(PropertyInfo propertyInfo, ITypeResolver typeResolver)
			{
			}

			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x1016F7C", Offset = "0x1016F7C", VA = "0x1016F7C", Slot = "15")]
			public void Write(object target, object value)
			{
			}

			[Token(Token = "0x60003FA")]
			public T GetCustomAttribute<T>() where T : Attribute
			{
				return null;
			}

			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x1016FCC", Offset = "0x1016FCC", VA = "0x1016FCC", Slot = "14")]
			public IObjectDescriptor Read(object target)
			{
				return null;
			}
		}

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ITypeResolver _typeResolver;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5825A0", Offset = "0x5825A0")]
		private static Func<PropertyInfo, bool> <>f__mg$cache0;

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x1015CCC", Offset = "0x1015CCC", VA = "0x1015CCC")]
		public ReadablePropertiesTypeInspector(ITypeResolver typeResolver)
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1016C18", Offset = "0x1016C18", VA = "0x1016C18")]
		private static bool IsValidProperty(PropertyInfo property)
		{
			return default(bool);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1016CA0", Offset = "0x1016CA0", VA = "0x1016CA0", Slot = "6")]
		public override IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container)
		{
			return null;
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x1016E00", Offset = "0x1016E00", VA = "0x1016E00")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5825B0", Offset = "0x5825B0")]
		private IPropertyDescriptor <GetProperties>m__0(PropertyInfo p)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A7")]
	public abstract class TypeInspectorSkeleton : ITypeInspector
	{
		[Token(Token = "0x20000CB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5826F4", Offset = "0x5826F4")]
		private sealed class <GetProperty>c__AnonStorey0
		{
			[Token(Token = "0x4000190")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal string name;

			[Token(Token = "0x6000482")]
			[Address(RVA = "0x1017900", Offset = "0x1017900", VA = "0x1017900")]
			public <GetProperty>c__AnonStorey0()
			{
			}

			[Token(Token = "0x6000483")]
			[Address(RVA = "0x10179B4", Offset = "0x10179B4", VA = "0x10179B4")]
			internal bool <>m__0(IPropertyDescriptor p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5826D4", Offset = "0x5826D4")]
		private static Func<IPropertyDescriptor, string> <>f__am$cache0;

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1016644", Offset = "0x1016644", VA = "0x1016644")]
		protected TypeInspectorSkeleton()
		{
		}

		[Token(Token = "0x60003FD")]
		public abstract IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container);

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1017138", Offset = "0x1017138", VA = "0x1017138", Slot = "5")]
		public IPropertyDescriptor GetProperty(Type type, object container, string name, bool ignoreUnmatched)
		{
			return null;
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1017908", Offset = "0x1017908", VA = "0x1017908")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5826E4", Offset = "0x5826E4")]
		private static string <GetProperty>m__0(IPropertyDescriptor p)
		{
			return null;
		}
	}
}
namespace YamlDotNet.Serialization.TypeResolvers
{
	[Token(Token = "0x20000A8")]
	public sealed class DynamicTypeResolver : ITypeResolver
	{
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1015170", Offset = "0x1015170", VA = "0x1015170")]
		public DynamicTypeResolver()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1017AAC", Offset = "0x1017AAC", VA = "0x1017AAC", Slot = "4")]
		public Type Resolve(Type staticType, object actualValue)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A9")]
	public sealed class StaticTypeResolver : ITypeResolver
	{
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1015168", Offset = "0x1015168", VA = "0x1015168")]
		public StaticTypeResolver()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1017AC4", Offset = "0x1017AC4", VA = "0x1017AC4", Slot = "4")]
		public Type Resolve(Type staticType, object actualValue)
		{
			return null;
		}
	}
}
namespace YamlDotNet.Serialization.Utilities
{
	[Token(Token = "0x20000AA")]
	public interface IPostDeserializationCallback
	{
		[Token(Token = "0x6000404")]
		void OnDeserialization();
	}
	[Token(Token = "0x20000AB")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x582704", Offset = "0x582704")]
	internal sealed class ObjectAnchorCollection
	{
		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IDictionary<string, object> objectsByAnchor;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IDictionary<object, string> anchorsByObject;

		[Token(Token = "0x170000B2")]
		public object Item
		{
			[Token(Token = "0x6000408")]
			[Address(RVA = "0x1017D88", Offset = "0x1017D88", VA = "0x1017D88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x1017ACC", Offset = "0x1017ACC", VA = "0x1017ACC")]
		public ObjectAnchorCollection()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1017B64", Offset = "0x1017B64", VA = "0x1017B64")]
		public void Add(string anchor, object @object)
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x1017CBC", Offset = "0x1017CBC", VA = "0x1017CBC")]
		public bool TryGetAnchor(object @object, out string anchor)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000AC")]
	internal static class ReflectionUtility
	{
		[Token(Token = "0x20000CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58274C", Offset = "0x58274C")]
		private sealed class <GetImplementedInterfaces>c__Iterator0 : IEnumerable, IEnumerable<Type>, IEnumerator, IDisposable, IEnumerator<Type>
		{
			[Token(Token = "0x4000191")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Type type;

			[Token(Token = "0x4000192")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Type[] $locvar0;

			[Token(Token = "0x4000193")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal int $locvar1;

			[Token(Token = "0x4000194")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Type <implementedInterface>__1;

			[Token(Token = "0x4000195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Type $current;

			[Token(Token = "0x4000196")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal bool $disposing;

			[Token(Token = "0x4000197")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal int $PC;

			[Token(Token = "0x170000C5")]
			private Type System.Collections.Generic.IEnumerator<System.Type>.Current
			{
				[Token(Token = "0x6000486")]
				[Address(RVA = "0x10181B0", Offset = "0x10181B0", VA = "0x10181B0", Slot = "10")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000487")]
				[Address(RVA = "0x10181B8", Offset = "0x10181B8", VA = "0x10181B8", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000484")]
			[Address(RVA = "0x1018004", Offset = "0x1018004", VA = "0x1018004")]
			[DebuggerHidden]
			public <GetImplementedInterfaces>c__Iterator0()
			{
			}

			[Token(Token = "0x6000485")]
			[Address(RVA = "0x101800C", Offset = "0x101800C", VA = "0x101800C", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000488")]
			[Address(RVA = "0x10181C0", Offset = "0x10181C0", VA = "0x10181C0", Slot = "9")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000489")]
			[Address(RVA = "0x10181D4", Offset = "0x10181D4", VA = "0x10181D4", Slot = "8")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0x1018238", Offset = "0x1018238", VA = "0x1018238", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600048B")]
			[Address(RVA = "0x101823C", Offset = "0x101823C", VA = "0x101823C", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator<Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x100BB30", Offset = "0x100BB30", VA = "0x100BB30")]
		public static Type GetImplementedGenericInterface(Type type, Type genericInterfaceType)
		{
			return null;
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1017F80", Offset = "0x1017F80", VA = "0x1017F80")]
		[DebuggerHidden]
		public static IEnumerable<Type> GetImplementedInterfaces(Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AD")]
	public sealed class SerializerState : IDisposable
	{
		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IDictionary<Type, object> items;

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x10182D4", Offset = "0x10182D4", VA = "0x10182D4")]
		public SerializerState()
		{
		}

		[Token(Token = "0x600040C")]
		public T Get<T>() where T : class, new()
		{
			return null;
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x1018344", Offset = "0x1018344", VA = "0x1018344")]
		public void OnDeserialization()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x10186B0", Offset = "0x10186B0", VA = "0x10186B0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	internal static class StringExtensions
	{
		[Token(Token = "0x20000CD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58284C", Offset = "0x58284C")]
		private sealed class <FromCamelCase>c__AnonStorey0
		{
			[Token(Token = "0x4000198")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal string separator;

			[Token(Token = "0x600048C")]
			[Address(RVA = "0x1018EEC", Offset = "0x1018EEC", VA = "0x1018EEC")]
			public <FromCamelCase>c__AnonStorey0()
			{
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0x1018F9C", Offset = "0x1018F9C", VA = "0x1018F9C")]
			internal string <>m__0(Match match)
			{
				return null;
			}
		}

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5827DC", Offset = "0x5827DC")]
		private static MatchEvaluator <>f__am$cache0;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5827EC", Offset = "0x5827EC")]
		private static Func<char, char> <>f__mg$cache0;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5827FC", Offset = "0x5827FC")]
		private static Func<char, char> <>f__mg$cache1;

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x1018A14", Offset = "0x1018A14", VA = "0x1018A14")]
		private static string ToCamelOrPascalCase(string str, Func<char, char> firstLetterTransform)
		{
			return null;
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x1018BCC", Offset = "0x1018BCC", VA = "0x1018BCC")]
		public static string ToCamelCase(this string str)
		{
			return null;
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1018C80", Offset = "0x1018C80", VA = "0x1018C80")]
		public static string ToPascalCase(this string str)
		{
			return null;
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x1018D34", Offset = "0x1018D34", VA = "0x1018D34")]
		public static string FromCamelCase(this string str, string separator)
		{
			return null;
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1018EF4", Offset = "0x1018EF4", VA = "0x1018EF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58283C", Offset = "0x58283C")]
		private static string <ToCamelOrPascalCase>m__0(Match match)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AF")]
	public static class TypeConverter
	{
		[Token(Token = "0x6000414")]
		public static T ChangeType<T>(object value)
		{
			return (T)null;
		}

		[Token(Token = "0x6000415")]
		public static T ChangeType<T>(object value, IFormatProvider provider)
		{
			return (T)null;
		}

		[Token(Token = "0x6000416")]
		public static T ChangeType<T>(object value, CultureInfo culture)
		{
			return (T)null;
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x100C304", Offset = "0x100C304", VA = "0x100C304")]
		public static object ChangeType(object value, Type destinationType)
		{
			return null;
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x101A248", Offset = "0x101A248", VA = "0x101A248")]
		public static object ChangeType(object value, Type destinationType, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x1019090", Offset = "0x1019090", VA = "0x1019090")]
		public static object ChangeType(object value, Type destinationType, CultureInfo culture)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B0")]
	internal static class YamlTypeConverters
	{
		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly IEnumerable<IYamlTypeConverter> _builtInTypeConverters;

		[Token(Token = "0x170000B3")]
		public static IEnumerable<IYamlTypeConverter> BuiltInConverters
		{
			[Token(Token = "0x600041A")]
			[Address(RVA = "0x10150F0", Offset = "0x10150F0", VA = "0x10150F0")]
			get
			{
				return null;
			}
		}
	}
}
namespace YamlDotNet.Serialization.ValueDeserializers
{
	[Token(Token = "0x20000B1")]
	public sealed class AliasValueDeserializer : IValueDeserializer
	{
		[Token(Token = "0x20000B2")]
		private sealed class AliasState : Dictionary<string, ValuePromise>, IPostDeserializationCallback
		{
			[Token(Token = "0x600041E")]
			[Address(RVA = "0x101AA70", Offset = "0x101AA70", VA = "0x101AA70")]
			public AliasState()
			{
			}

			[Token(Token = "0x600041F")]
			[Address(RVA = "0x101AAC0", Offset = "0x101AAC0", VA = "0x101AAC0", Slot = "34")]
			public void OnDeserialization()
			{
			}
		}

		[Token(Token = "0x20000B3")]
		private sealed class ValuePromise : IValuePromise
		{
			[Token(Token = "0x400014D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582898", Offset = "0x582898")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x582898", Offset = "0x582898")]
			private bool <HasValue>k__BackingField;

			[Token(Token = "0x400014E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object value;

			[Token(Token = "0x400014F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public readonly YamlDotNet.Core.Events.AnchorAlias Alias;

			[Token(Token = "0x170000B4")]
			public bool HasValue
			{
				[Token(Token = "0x6000424")]
				[Address(RVA = "0x101A8E0", Offset = "0x101A8E0", VA = "0x101A8E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5828D4", Offset = "0x5828D4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000425")]
				[Address(RVA = "0x101ACD4", Offset = "0x101ACD4", VA = "0x101ACD4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5828E4", Offset = "0x5828E4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B5")]
			public object Value
			{
				[Token(Token = "0x6000426")]
				[Address(RVA = "0x101A8E8", Offset = "0x101A8E8", VA = "0x101A8E8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000427")]
				[Address(RVA = "0x101A9A8", Offset = "0x101A9A8", VA = "0x101A9A8")]
				set
				{
				}
			}

			[Token(Token = "0x14000002")]
			public event Action<object> ValueAvailable
			{
				[Token(Token = "0x6000422")]
				[Address(RVA = "0x101ACE0", Offset = "0x101ACE0", VA = "0x101ACE0", Slot = "4")]
				add
				{
				}
				[Token(Token = "0x6000423")]
				[Address(RVA = "0x101ADC8", Offset = "0x101ADC8", VA = "0x101ADC8", Slot = "5")]
				remove
				{
				}
			}

			[Token(Token = "0x6000420")]
			[Address(RVA = "0x101A8B4", Offset = "0x101A8B4", VA = "0x101A8B4")]
			public ValuePromise(YamlDotNet.Core.Events.AnchorAlias alias)
			{
			}

			[Token(Token = "0x6000421")]
			[Address(RVA = "0x101A974", Offset = "0x101A974", VA = "0x101A974")]
			public ValuePromise(object value)
			{
			}
		}

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IValueDeserializer innerDeserializer;

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x101A3DC", Offset = "0x101A3DC", VA = "0x101A3DC")]
		public AliasValueDeserializer(IValueDeserializer innerDeserializer)
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x101A47C", Offset = "0x101A47C", VA = "0x101A47C", Slot = "4")]
		public object DeserializeValue(EventReader reader, Type expectedType, SerializerState state, IValueDeserializer nestedObjectDeserializer)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B4")]
	public sealed class NodeValueDeserializer : IValueDeserializer
	{
		[Token(Token = "0x20000CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5828F4", Offset = "0x5828F4")]
		private sealed class <DeserializeValue>c__AnonStorey0
		{
			[Token(Token = "0x4000199")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal IValueDeserializer nestedObjectDeserializer;

			[Token(Token = "0x400019A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal SerializerState state;

			[Token(Token = "0x600048E")]
			[Address(RVA = "0x101B580", Offset = "0x101B580", VA = "0x101B580")]
			public <DeserializeValue>c__AnonStorey0()
			{
			}

			[Token(Token = "0x600048F")]
			[Address(RVA = "0x101B874", Offset = "0x101B874", VA = "0x101B874")]
			internal object <>m__0(EventReader r, Type t)
			{
				return null;
			}
		}

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IList<INodeDeserializer> deserializers;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IList<INodeTypeResolver> typeResolvers;

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x101AEB0", Offset = "0x101AEB0", VA = "0x101AEB0")]
		public NodeValueDeserializer(IList<INodeDeserializer> deserializers, IList<INodeTypeResolver> typeResolvers)
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x101AF78", Offset = "0x101AF78", VA = "0x101AF78", Slot = "4")]
		public object DeserializeValue(EventReader reader, Type expectedType, SerializerState state, IValueDeserializer nestedObjectDeserializer)
		{
			return null;
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x101B588", Offset = "0x101B588", VA = "0x101B588")]
		private Type GetTypeFromEvent(NodeEvent nodeEvent, Type currentType)
		{
			return null;
		}
	}
}
namespace YamlDotNet.Serialization
{
	[Token(Token = "0x20000B5")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x582904", Offset = "0x582904")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x582904", Offset = "0x582904")]
	public class YamlAliasAttribute : Attribute
	{
		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582968", Offset = "0x582968")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x582968", Offset = "0x582968")]
		private string <Alias>k__BackingField;

		[Token(Token = "0x170000B6")]
		public string Alias
		{
			[Token(Token = "0x600042C")]
			[Address(RVA = "0x101B978", Offset = "0x101B978", VA = "0x101B978")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5829A4", Offset = "0x5829A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600042D")]
			[Address(RVA = "0x101B970", Offset = "0x101B970", VA = "0x101B970")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5829B4", Offset = "0x5829B4")]
			set
			{
			}
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x101B944", Offset = "0x101B944", VA = "0x101B944")]
		public YamlAliasAttribute(string alias)
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public sealed class YamlAttributesTypeInspector : TypeInspectorSkeleton
	{
		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ITypeInspector innerTypeDescriptor;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5829C4", Offset = "0x5829C4")]
		private static Func<IPropertyDescriptor, bool> <>f__am$cache0;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5829D4", Offset = "0x5829D4")]
		private static Func<IPropertyDescriptor, IPropertyDescriptor> <>f__am$cache1;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5829E4", Offset = "0x5829E4")]
		private static Func<IPropertyDescriptor, int> <>f__am$cache2;

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1015E60", Offset = "0x1015E60", VA = "0x1015E60")]
		public YamlAttributesTypeInspector(ITypeInspector innerTypeDescriptor)
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x101B980", Offset = "0x101B980", VA = "0x101B980", Slot = "6")]
		public override IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container)
		{
			return null;
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x101BBC4", Offset = "0x101BBC4", VA = "0x101BBC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5829F4", Offset = "0x5829F4")]
		private static bool <GetProperties>m__0(IPropertyDescriptor p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x101BC98", Offset = "0x101BC98", VA = "0x101BC98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582A04", Offset = "0x582A04")]
		private static IPropertyDescriptor <GetProperties>m__1(IPropertyDescriptor p)
		{
			return null;
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x101BF00", Offset = "0x101BF00", VA = "0x101BF00")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582A14", Offset = "0x582A14")]
		private static int <GetProperties>m__2(IPropertyDescriptor p)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000B7")]
	internal static class YamlFormatter
	{
		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly NumberFormatInfo NumberFormat;

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x101BFB0", Offset = "0x101BFB0", VA = "0x101BFB0")]
		public static string FormatNumber(object number)
		{
			return null;
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x101C04C", Offset = "0x101C04C", VA = "0x101C04C")]
		public static string FormatBoolean(object boolean)
		{
			return null;
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x101C0EC", Offset = "0x101C0EC", VA = "0x101C0EC")]
		public static string FormatDateTime(object dateTime)
		{
			return null;
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x101C1F8", Offset = "0x101C1F8", VA = "0x101C1F8")]
		public static string FormatTimeSpan(object timeSpan)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B8")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x582A24", Offset = "0x582A24")]
	public sealed class YamlIgnoreAttribute : Attribute
	{
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x101C5C4", Offset = "0x101C5C4", VA = "0x101C5C4")]
		public YamlIgnoreAttribute()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x582A60", Offset = "0x582A60")]
	public sealed class YamlMemberAttribute : Attribute
	{
		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582A9C", Offset = "0x582A9C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x582A9C", Offset = "0x582A9C")]
		private Type <SerializeAs>k__BackingField;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582AD8", Offset = "0x582AD8")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x582AD8", Offset = "0x582AD8")]
		private int <Order>k__BackingField;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582B14", Offset = "0x582B14")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x582B14", Offset = "0x582B14")]
		private string <Alias>k__BackingField;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582B50", Offset = "0x582B50")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x582B50", Offset = "0x582B50")]
		private ScalarStyle <ScalarStyle>k__BackingField;

		[Token(Token = "0x170000B7")]
		public Type SerializeAs
		{
			[Token(Token = "0x600043B")]
			[Address(RVA = "0x101BEE0", Offset = "0x101BEE0", VA = "0x101BEE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582B8C", Offset = "0x582B8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x101C62C", Offset = "0x101C62C", VA = "0x101C62C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582B9C", Offset = "0x582B9C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		public int Order
		{
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x101BEE8", Offset = "0x101BEE8", VA = "0x101BEE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582BAC", Offset = "0x582BAC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600043E")]
			[Address(RVA = "0x101C634", Offset = "0x101C634", VA = "0x101C634")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582BBC", Offset = "0x582BBC")]
			set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public string Alias
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x101BEF8", Offset = "0x101BEF8", VA = "0x101BEF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582BCC", Offset = "0x582BCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x101C63C", Offset = "0x101C63C", VA = "0x101C63C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582BDC", Offset = "0x582BDC")]
			set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public ScalarStyle ScalarStyle
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x101BEF0", Offset = "0x101BEF0", VA = "0x101BEF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582BEC", Offset = "0x582BEC")]
			get
			{
				return default(ScalarStyle);
			}
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x101C5F4", Offset = "0x101C5F4", VA = "0x101C5F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x582BFC", Offset = "0x582BFC")]
			set
			{
			}
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x101C5CC", Offset = "0x101C5CC", VA = "0x101C5CC")]
		public YamlMemberAttribute()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x101C5FC", Offset = "0x101C5FC", VA = "0x101C5FC")]
		public YamlMemberAttribute(Type serializeAs)
		{
		}
	}
}
