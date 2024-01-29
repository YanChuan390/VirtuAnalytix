using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using DarkTonic.MasterAudio;
using HutongGames.PlayMaker;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Video;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class PlaymakerScene : MonoBehaviour
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x24368A4", Offset = "0x24368A4", VA = "0x24368A4")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2436958", Offset = "0x2436958", VA = "0x2436958")]
	public PlaymakerScene()
	{
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0ABBC", Offset = "0xA0ABBC")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0ABBC", Offset = "0xA0ABBC")]
public class MasterAudioBusFade : FsmStateAction
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0C270", Offset = "0xA0C270")]
	public FsmBool allBuses;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0C2A8", Offset = "0xA0C2A8")]
	public FsmString busName;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[RequiredField]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0xA0C2E0", Offset = "0xA0C2E0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0C2E0", Offset = "0xA0C2E0")]
	public FsmFloat targetVolume;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[RequiredField]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0xA0C344", Offset = "0xA0C344")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0C344", Offset = "0xA0C344")]
	public FsmFloat fadeTime;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0C3A8", Offset = "0xA0C3A8")]
	public FsmBool stopBusAfterFade;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0C3E0", Offset = "0xA0C3E0")]
	public FsmBool restoreVolumeAfterFade;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2347DB4", Offset = "0x2347DB4", VA = "0x2347DB4", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x234808C", Offset = "0x234808C", VA = "0x234808C", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x23481C8", Offset = "0x23481C8", VA = "0x23481C8")]
	public MasterAudioBusFade()
	{
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0AC0C", Offset = "0xA0AC0C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0AC0C", Offset = "0xA0AC0C")]
public class MasterAudioBusGetProps : FsmStateAction
{
	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0C418", Offset = "0xA0C418")]
	public FsmString busName;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0C464", Offset = "0xA0C464")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0xA0C464", Offset = "0xA0C464")]
	public FsmFloat BusVolume;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0C4B4", Offset = "0xA0C4B4")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0xA0C4B4", Offset = "0xA0C4B4")]
	public FsmBool BusIsMuted;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0C504", Offset = "0xA0C504")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0xA0C504", Offset = "0xA0C504")]
	public FsmBool BusIsSoloed;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0C554", Offset = "0xA0C554")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0xA0C554", Offset = "0xA0C554")]
	public FsmInt VoiceLimit;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0C5A4", Offset = "0xA0C5A4")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0xA0C5A4", Offset = "0xA0C5A4")]
	public FsmInt ActiveVoices;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0C5F4", Offset = "0xA0C5F4")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0xA0C5F4", Offset = "0xA0C5F4")]
	public FsmBool VoiceLimitReached;

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x23481D0", Offset = "0x23481D0", VA = "0x23481D0", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x234844C", Offset = "0x234844C", VA = "0x234844C", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x23485F0", Offset = "0x23485F0", VA = "0x23485F0")]
	public MasterAudioBusGetProps()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0AC5C", Offset = "0xA0AC5C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0AC5C", Offset = "0xA0AC5C")]
public class MasterAudioBusMute : FsmStateAction
{
	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0C644", Offset = "0xA0C644")]
	public FsmBool allBuses;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0C67C", Offset = "0xA0C67C")]
	public FsmString busName;

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x23485F8", Offset = "0x23485F8", VA = "0x23485F8", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x23487E0", Offset = "0x23487E0", VA = "0x23487E0", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x23488C0", Offset = "0x23488C0", VA = "0x23488C0")]
	public MasterAudioBusMute()
	{
	}
}
[Token(Token = "0x2000006")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0ACAC", Offset = "0xA0ACAC")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0ACAC", Offset = "0xA0ACAC")]
public class MasterAudioBusPause : FsmStateAction
{
	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0C6B4", Offset = "0xA0C6B4")]
	public FsmBool allBuses;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0C6EC", Offset = "0xA0C6EC")]
	public FsmString busName;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x23488C8", Offset = "0x23488C8", VA = "0x23488C8", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2348AB0", Offset = "0x2348AB0", VA = "0x2348AB0", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2348B90", Offset = "0x2348B90", VA = "0x2348B90")]
	public MasterAudioBusPause()
	{
	}
}
[Token(Token = "0x2000007")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0ACFC", Offset = "0xA0ACFC")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0ACFC", Offset = "0xA0ACFC")]
public class MasterAudioBusSetVolume : FsmStateAction
{
	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0C724", Offset = "0xA0C724")]
	public FsmBool allBuses;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0C75C", Offset = "0xA0C75C")]
	public FsmString busName;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[RequiredField]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0xA0C794", Offset = "0xA0C794")]
	public FsmFloat volume;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0C7D4", Offset = "0xA0C7D4")]
	public bool everyFrame;

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2348B98", Offset = "0x2348B98", VA = "0x2348B98", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2348E00", Offset = "0x2348E00", VA = "0x2348E00", Slot = "34")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x2348BD4", Offset = "0x2348BD4", VA = "0x2348BD4")]
	private void SetVolume()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x2348E04", Offset = "0x2348E04", VA = "0x2348E04", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x2348F34", Offset = "0x2348F34", VA = "0x2348F34")]
	public MasterAudioBusSetVolume()
	{
	}
}
[Token(Token = "0x2000008")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0AD4C", Offset = "0xA0AD4C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0AD4C", Offset = "0xA0AD4C")]
public class MasterAudioBusSolo : FsmStateAction
{
	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0C80C", Offset = "0xA0C80C")]
	public FsmBool allBuses;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0C844", Offset = "0xA0C844")]
	public FsmString busName;

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x2348FC4", Offset = "0x2348FC4", VA = "0x2348FC4", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x23491AC", Offset = "0x23491AC", VA = "0x23491AC", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x234928C", Offset = "0x234928C", VA = "0x234928C")]
	public MasterAudioBusSolo()
	{
	}
}
[Token(Token = "0x2000009")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0AD9C", Offset = "0xA0AD9C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0AD9C", Offset = "0xA0AD9C")]
public class MasterAudioBusStop : FsmStateAction
{
	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0C87C", Offset = "0xA0C87C")]
	public FsmBool allBuses;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0C8B4", Offset = "0xA0C8B4")]
	public FsmString busName;

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x2349294", Offset = "0x2349294", VA = "0x2349294", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x234947C", Offset = "0x234947C", VA = "0x234947C", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x234955C", Offset = "0x234955C", VA = "0x234955C")]
	public MasterAudioBusStop()
	{
	}
}
[Token(Token = "0x200000A")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0ADEC", Offset = "0xA0ADEC")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0ADEC", Offset = "0xA0ADEC")]
public class MasterAudioBusUnmute : FsmStateAction
{
	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0C8EC", Offset = "0xA0C8EC")]
	public FsmBool allBuses;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0C924", Offset = "0xA0C924")]
	public FsmString busName;

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2349564", Offset = "0x2349564", VA = "0x2349564", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2349754", Offset = "0x2349754", VA = "0x2349754", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2349834", Offset = "0x2349834", VA = "0x2349834")]
	public MasterAudioBusUnmute()
	{
	}
}
[Token(Token = "0x200000B")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0AE3C", Offset = "0xA0AE3C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0AE3C", Offset = "0xA0AE3C")]
public class MasterAudioBusUnpause : FsmStateAction
{
	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0C95C", Offset = "0xA0C95C")]
	public FsmBool allBuses;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0C994", Offset = "0xA0C994")]
	public FsmString busName;

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x234983C", Offset = "0x234983C", VA = "0x234983C", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2349A24", Offset = "0x2349A24", VA = "0x2349A24", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2349B04", Offset = "0x2349B04", VA = "0x2349B04")]
	public MasterAudioBusUnpause()
	{
	}
}
[Token(Token = "0x200000C")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0AE8C", Offset = "0xA0AE8C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0AE8C", Offset = "0xA0AE8C")]
public class MasterAudioBusUnsolo : FsmStateAction
{
	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0C9CC", Offset = "0xA0C9CC")]
	public FsmBool allBuses;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0CA04", Offset = "0xA0CA04")]
	public FsmString busName;

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2349B0C", Offset = "0x2349B0C", VA = "0x2349B0C", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2349CFC", Offset = "0x2349CFC", VA = "0x2349CFC", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x2349DDC", Offset = "0x2349DDC", VA = "0x2349DDC")]
	public MasterAudioBusUnsolo()
	{
	}
}
[Token(Token = "0x200000D")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0AEDC", Offset = "0xA0AEDC")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0AEDC", Offset = "0xA0AEDC")]
public class MasterAudioDuckingAddGroup : FsmStateAction
{
	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0CA3C", Offset = "0xA0CA3C")]
	public FsmString soundGroupName;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[RequiredField]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0xA0CA88", Offset = "0xA0CA88")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0CA88", Offset = "0xA0CA88")]
	public FsmFloat riseVolumeStart;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[RequiredField]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0xA0CAEC", Offset = "0xA0CAEC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0CAEC", Offset = "0xA0CAEC")]
	public FsmFloat beginUnduck;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[RequiredField]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0xA0CB50", Offset = "0xA0CB50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0CB50", Offset = "0xA0CB50")]
	public FsmFloat unduckTime;

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x2349DE4", Offset = "0x2349DE4", VA = "0x2349DE4", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x2349ECC", Offset = "0x2349ECC", VA = "0x2349ECC", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x234A0BC", Offset = "0x234A0BC", VA = "0x234A0BC")]
	public MasterAudioDuckingAddGroup()
	{
	}
}
[Token(Token = "0x200000E")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0AF2C", Offset = "0xA0AF2C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0AF2C", Offset = "0xA0AF2C")]
public class MasterAudioDuckingRemoveGroup : FsmStateAction
{
	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0CBB4", Offset = "0xA0CBB4")]
	public FsmString soundGroupName;

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x234A0C4", Offset = "0x234A0C4", VA = "0x234A0C4", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x234A150", Offset = "0x234A150", VA = "0x234A150", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x234A1E0", Offset = "0x234A1E0", VA = "0x234A1E0")]
	public MasterAudioDuckingRemoveGroup()
	{
	}
}
[Token(Token = "0x200000F")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0AF7C", Offset = "0xA0AF7C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0AF7C", Offset = "0xA0AF7C")]
public class MasterAudioDuckingToggle : FsmStateAction
{
	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0CC00", Offset = "0xA0CC00")]
	public FsmBool enableDucking;

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x234A1E8", Offset = "0x234A1E8", VA = "0x234A1E8", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x234A27C", Offset = "0x234A27C", VA = "0x234A27C", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x234A300", Offset = "0x234A300", VA = "0x234A300")]
	public MasterAudioDuckingToggle()
	{
	}
}
[Token(Token = "0x2000010")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0AFCC", Offset = "0xA0AFCC")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0AFCC", Offset = "0xA0AFCC")]
public class MasterAudioEverythingMute : FsmStateAction
{
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x234A308", Offset = "0x234A308", VA = "0x234A308", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x234A374", Offset = "0x234A374", VA = "0x234A374", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x234A378", Offset = "0x234A378", VA = "0x234A378")]
	public MasterAudioEverythingMute()
	{
	}
}
[Token(Token = "0x2000011")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B01C", Offset = "0xA0B01C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B01C", Offset = "0xA0B01C")]
public class MasterAudioEverythingPause : FsmStateAction
{
	[Token(Token = "0x600002F")]
	[Address(RVA = "0x234A380", Offset = "0x234A380", VA = "0x234A380", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x234A3EC", Offset = "0x234A3EC", VA = "0x234A3EC", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x234A3F0", Offset = "0x234A3F0", VA = "0x234A3F0")]
	public MasterAudioEverythingPause()
	{
	}
}
[Token(Token = "0x2000012")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B06C", Offset = "0xA0B06C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B06C", Offset = "0xA0B06C")]
public class MasterAudioEverythingStop : FsmStateAction
{
	[Token(Token = "0x6000032")]
	[Address(RVA = "0x234A3F8", Offset = "0x234A3F8", VA = "0x234A3F8", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x234A464", Offset = "0x234A464", VA = "0x234A464", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x234A468", Offset = "0x234A468", VA = "0x234A468")]
	public MasterAudioEverythingStop()
	{
	}
}
[Token(Token = "0x2000013")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B0BC", Offset = "0xA0B0BC")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B0BC", Offset = "0xA0B0BC")]
public class MasterAudioEverythingUnmute : FsmStateAction
{
	[Token(Token = "0x6000035")]
	[Address(RVA = "0x234A470", Offset = "0x234A470", VA = "0x234A470", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x234A4DC", Offset = "0x234A4DC", VA = "0x234A4DC", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x234A4E0", Offset = "0x234A4E0", VA = "0x234A4E0")]
	public MasterAudioEverythingUnmute()
	{
	}
}
[Token(Token = "0x2000014")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B10C", Offset = "0xA0B10C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B10C", Offset = "0xA0B10C")]
public class MasterAudioEverythingUnpause : FsmStateAction
{
	[Token(Token = "0x6000038")]
	[Address(RVA = "0x234A4E8", Offset = "0x234A4E8", VA = "0x234A4E8", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x234A554", Offset = "0x234A554", VA = "0x234A554", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x234A558", Offset = "0x234A558", VA = "0x234A558")]
	public MasterAudioEverythingUnpause()
	{
	}
}
[Token(Token = "0x2000015")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B15C", Offset = "0xA0B15C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B15C", Offset = "0xA0B15C")]
public class MasterAudioFadeOutAllOfSound : FsmStateAction
{
	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0CC4C", Offset = "0xA0CC4C")]
	public FsmBool allGroups;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0CC84", Offset = "0xA0CC84")]
	public FsmString soundGroupName;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[RequiredField]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0xA0CCBC", Offset = "0xA0CCBC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0CCBC", Offset = "0xA0CCBC")]
	public FsmFloat fadeTime;

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x234A560", Offset = "0x234A560", VA = "0x234A560", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x234A784", Offset = "0x234A784", VA = "0x234A784", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x234A89C", Offset = "0x234A89C", VA = "0x234A89C")]
	public MasterAudioFadeOutAllOfSound()
	{
	}
}
[Token(Token = "0x2000016")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B1AC", Offset = "0xA0B1AC")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B1AC", Offset = "0xA0B1AC")]
public class MasterAudioFireCustomEvent : FsmStateAction
{
	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0CD20", Offset = "0xA0CD20")]
	public FsmString customEventName;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0CD6C", Offset = "0xA0CD6C")]
	public FsmOwnerDefault eventOrigin;

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x234A8A4", Offset = "0x234A8A4", VA = "0x234A8A4", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x234A9D8", Offset = "0x234A9D8", VA = "0x234A9D8", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x234AA78", Offset = "0x234AA78", VA = "0x234AA78")]
	public MasterAudioFireCustomEvent()
	{
	}
}
[Token(Token = "0x2000017")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B1FC", Offset = "0xA0B1FC")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B1FC", Offset = "0xA0B1FC")]
public class MasterAudioGroupFade : FsmStateAction
{
	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0CDA4", Offset = "0xA0CDA4")]
	public FsmBool allGroups;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0CDDC", Offset = "0xA0CDDC")]
	public FsmString soundGroupName;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[RequiredField]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0xA0CE14", Offset = "0xA0CE14")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0CE14", Offset = "0xA0CE14")]
	public FsmFloat targetVolume;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[RequiredField]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0xA0CE78", Offset = "0xA0CE78")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0CE78", Offset = "0xA0CE78")]
	public FsmFloat fadeTime;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0CEDC", Offset = "0xA0CEDC")]
	public FsmBool stopGroupAfterFade;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0CF14", Offset = "0xA0CF14")]
	public FsmBool restoreVolumeAfterFade;

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x234B69C", Offset = "0x234B69C", VA = "0x234B69C", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x234B974", Offset = "0x234B974", VA = "0x234B974", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x234BAB0", Offset = "0x234BAB0", VA = "0x234BAB0")]
	public MasterAudioGroupFade()
	{
	}
}
[Token(Token = "0x2000018")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B24C", Offset = "0xA0B24C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B24C", Offset = "0xA0B24C")]
public class MasterAudioGroupIsPlaying : FsmStateAction
{
	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0CF4C", Offset = "0xA0CF4C")]
	public FsmString soundGroupName;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0CF98", Offset = "0xA0CF98")]
	public FsmEvent isPlayingEvent;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0CFD0", Offset = "0xA0CFD0")]
	public FsmEvent notPlayingEvent;

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x234BAB8", Offset = "0x234BAB8", VA = "0x234BAB8", Slot = "34")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x234BBA4", Offset = "0x234BBA4", VA = "0x234BBA4")]
	public MasterAudioGroupIsPlaying()
	{
	}
}
[Token(Token = "0x2000019")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B29C", Offset = "0xA0B29C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B29C", Offset = "0xA0B29C")]
public class MasterAudioGroupMute : FsmStateAction
{
	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D008", Offset = "0xA0D008")]
	public FsmBool allGroups;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D040", Offset = "0xA0D040")]
	public FsmString soundGroupName;

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x234BBAC", Offset = "0x234BBAC", VA = "0x234BBAC", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x234BD9C", Offset = "0x234BD9C", VA = "0x234BD9C", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x234BE7C", Offset = "0x234BE7C", VA = "0x234BE7C")]
	public MasterAudioGroupMute()
	{
	}
}
[Token(Token = "0x200001A")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B2EC", Offset = "0xA0B2EC")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B2EC", Offset = "0xA0B2EC")]
public class MasterAudioGroupPause : FsmStateAction
{
	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D078", Offset = "0xA0D078")]
	public FsmBool allGroups;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D0B0", Offset = "0xA0D0B0")]
	public FsmString soundGroupName;

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x234BE84", Offset = "0x234BE84", VA = "0x234BE84", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x234C06C", Offset = "0x234C06C", VA = "0x234C06C", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x234C14C", Offset = "0x234C14C", VA = "0x234C14C")]
	public MasterAudioGroupPause()
	{
	}
}
[Token(Token = "0x200001B")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B33C", Offset = "0xA0B33C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B33C", Offset = "0xA0B33C")]
public class MasterAudioGroupSetPitch : FsmStateAction
{
	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D0E8", Offset = "0xA0D0E8")]
	public FsmString soundGroupName;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D134", Offset = "0xA0D134")]
	public FsmBool allVariations;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D16C", Offset = "0xA0D16C")]
	public FsmString variationName;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[RequiredField]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0xA0D1A4", Offset = "0xA0D1A4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D1A4", Offset = "0xA0D1A4")]
	public FsmFloat pitch;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D208", Offset = "0xA0D208")]
	public bool everyFrame;

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x234C154", Offset = "0x234C154", VA = "0x234C154", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x234C22C", Offset = "0x234C22C", VA = "0x234C22C", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x234C428", Offset = "0x234C428", VA = "0x234C428", Slot = "34")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x234C268", Offset = "0x234C268", VA = "0x234C268")]
	private void SetPitch()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x234C42C", Offset = "0x234C42C", VA = "0x234C42C")]
	public MasterAudioGroupSetPitch()
	{
	}
}
[Token(Token = "0x200001C")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B38C", Offset = "0xA0B38C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B38C", Offset = "0xA0B38C")]
public class MasterAudioGroupSetVolume : FsmStateAction
{
	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D240", Offset = "0xA0D240")]
	public FsmBool allGroups;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D278", Offset = "0xA0D278")]
	public FsmString soundGroupName;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[RequiredField]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0xA0D2B0", Offset = "0xA0D2B0")]
	public FsmFloat volume;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D2F0", Offset = "0xA0D2F0")]
	public bool everyFrame;

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x234C4BC", Offset = "0x234C4BC", VA = "0x234C4BC", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x234C724", Offset = "0x234C724", VA = "0x234C724", Slot = "34")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x234C4F8", Offset = "0x234C4F8", VA = "0x234C4F8")]
	private void SetVolume()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x234C728", Offset = "0x234C728", VA = "0x234C728", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x234C858", Offset = "0x234C858", VA = "0x234C858")]
	public MasterAudioGroupSetVolume()
	{
	}
}
[Token(Token = "0x200001D")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B3DC", Offset = "0xA0B3DC")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B3DC", Offset = "0xA0B3DC")]
public class MasterAudioGroupSolo : FsmStateAction
{
	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D328", Offset = "0xA0D328")]
	public FsmBool allGroups;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D360", Offset = "0xA0D360")]
	public FsmString soundGroupName;

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x234C8E8", Offset = "0x234C8E8", VA = "0x234C8E8", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x234CAD8", Offset = "0x234CAD8", VA = "0x234CAD8", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x234CBB8", Offset = "0x234CBB8", VA = "0x234CBB8")]
	public MasterAudioGroupSolo()
	{
	}
}
[Token(Token = "0x200001E")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B42C", Offset = "0xA0B42C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B42C", Offset = "0xA0B42C")]
public class MasterAudioGroupToggleMute : FsmStateAction
{
	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D398", Offset = "0xA0D398")]
	public FsmBool allGroups;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D3D0", Offset = "0xA0D3D0")]
	public FsmString soundGroupName;

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x234CBC0", Offset = "0x234CBC0", VA = "0x234CBC0", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x234CF18", Offset = "0x234CF18", VA = "0x234CF18", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x234CFF8", Offset = "0x234CFF8", VA = "0x234CFF8")]
	public MasterAudioGroupToggleMute()
	{
	}
}
[Token(Token = "0x200001F")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B47C", Offset = "0xA0B47C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B47C", Offset = "0xA0B47C")]
public class MasterAudioGroupToggleSolo : FsmStateAction
{
	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D408", Offset = "0xA0D408")]
	public FsmBool allGroups;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D440", Offset = "0xA0D440")]
	public FsmString soundGroupName;

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x234D000", Offset = "0x234D000", VA = "0x234D000", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x234D358", Offset = "0x234D358", VA = "0x234D358", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x234D438", Offset = "0x234D438", VA = "0x234D438")]
	public MasterAudioGroupToggleSolo()
	{
	}
}
[Token(Token = "0x2000020")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B4CC", Offset = "0xA0B4CC")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B4CC", Offset = "0xA0B4CC")]
public class MasterAudioGroupUnmute : FsmStateAction
{
	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D478", Offset = "0xA0D478")]
	public FsmBool allGroups;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D4B0", Offset = "0xA0D4B0")]
	public FsmString soundGroupName;

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x234D440", Offset = "0x234D440", VA = "0x234D440", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x234D630", Offset = "0x234D630", VA = "0x234D630", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x234D710", Offset = "0x234D710", VA = "0x234D710")]
	public MasterAudioGroupUnmute()
	{
	}
}
[Token(Token = "0x2000021")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B51C", Offset = "0xA0B51C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B51C", Offset = "0xA0B51C")]
public class MasterAudioGroupUnpause : FsmStateAction
{
	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D4E8", Offset = "0xA0D4E8")]
	public FsmBool allGroups;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D520", Offset = "0xA0D520")]
	public FsmString soundGroupName;

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x234D718", Offset = "0x234D718", VA = "0x234D718", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x234D900", Offset = "0x234D900", VA = "0x234D900", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x234D9E0", Offset = "0x234D9E0", VA = "0x234D9E0")]
	public MasterAudioGroupUnpause()
	{
	}
}
[Token(Token = "0x2000022")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B56C", Offset = "0xA0B56C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B56C", Offset = "0xA0B56C")]
public class MasterAudioGroupUnsolo : FsmStateAction
{
	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D558", Offset = "0xA0D558")]
	public FsmBool allGroups;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D590", Offset = "0xA0D590")]
	public FsmString soundGroupName;

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x234D9E8", Offset = "0x234D9E8", VA = "0x234D9E8", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x234DBD8", Offset = "0x234DBD8", VA = "0x234DBD8", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x234DCB8", Offset = "0x234DCB8", VA = "0x234DCB8")]
	public MasterAudioGroupUnsolo()
	{
	}
}
[Token(Token = "0x2000023")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B5BC", Offset = "0xA0B5BC")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B5BC", Offset = "0xA0B5BC")]
public class MasterAudioMixerPause : FsmStateAction
{
	[Token(Token = "0x6000068")]
	[Address(RVA = "0x234DCC0", Offset = "0x234DCC0", VA = "0x234DCC0", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x234DD2C", Offset = "0x234DD2C", VA = "0x234DD2C", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x234DD30", Offset = "0x234DD30", VA = "0x234DD30")]
	public MasterAudioMixerPause()
	{
	}
}
[Token(Token = "0x2000024")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B60C", Offset = "0xA0B60C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B60C", Offset = "0xA0B60C")]
public class MasterAudioMixerStop : FsmStateAction
{
	[Token(Token = "0x600006B")]
	[Address(RVA = "0x234DD38", Offset = "0x234DD38", VA = "0x234DD38", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x234DDA4", Offset = "0x234DDA4", VA = "0x234DDA4", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x234DDA8", Offset = "0x234DDA8", VA = "0x234DDA8")]
	public MasterAudioMixerStop()
	{
	}
}
[Token(Token = "0x2000025")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B65C", Offset = "0xA0B65C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B65C", Offset = "0xA0B65C")]
public class MasterAudioMixerUnpause : FsmStateAction
{
	[Token(Token = "0x600006E")]
	[Address(RVA = "0x234DDB0", Offset = "0x234DDB0", VA = "0x234DDB0", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x234DE1C", Offset = "0x234DE1C", VA = "0x234DE1C", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x234DE20", Offset = "0x234DE20", VA = "0x234DE20")]
	public MasterAudioMixerUnpause()
	{
	}
}
[Token(Token = "0x2000026")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B6AC", Offset = "0xA0B6AC")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B6AC", Offset = "0xA0B6AC")]
public class MasterAudioPlaySound : FsmStateAction
{
	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D5C8", Offset = "0xA0D5C8")]
	public FsmOwnerDefault gameObject;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D614", Offset = "0xA0D614")]
	public FsmString soundGroupName;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D660", Offset = "0xA0D660")]
	public FsmString variationName;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[RequiredField]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0xA0D698", Offset = "0xA0D698")]
	public FsmFloat volume;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0xA0D6D8", Offset = "0xA0D6D8")]
	public FsmFloat delaySound;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public FsmBool useThisLocation;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public FsmBool attachToGameObject;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public FsmBool useFixedPitch;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D6F0", Offset = "0xA0D6F0")]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0xA0D6F0", Offset = "0xA0D6F0")]
	public FsmFloat fixedPitch;

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x234DE28", Offset = "0x234DE28", VA = "0x234DE28", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x234E130", Offset = "0x234E130", VA = "0x234E130", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x234E3A8", Offset = "0x234E3A8", VA = "0x234E3A8")]
	public MasterAudioPlaySound()
	{
	}
}
[Token(Token = "0x2000027")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B6FC", Offset = "0xA0B6FC")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B6FC", Offset = "0xA0B6FC")]
public class MasterAudioPlaySoundWithEvent : FsmStateAction
{
	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D744", Offset = "0xA0D744")]
	public FsmOwnerDefault gameObject;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D790", Offset = "0xA0D790")]
	public FsmString soundGroupName;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D7DC", Offset = "0xA0D7DC")]
	public FsmString variationName;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[RequiredField]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0xA0D814", Offset = "0xA0D814")]
	public FsmFloat volume;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0xA0D854", Offset = "0xA0D854")]
	public FsmFloat delaySound;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public FsmBool useThisLocation;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public FsmBool attachToGameObject;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public FsmBool useFixedPitch;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D86C", Offset = "0xA0D86C")]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0xA0D86C", Offset = "0xA0D86C")]
	public FsmFloat fixedPitch;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D8C0", Offset = "0xA0D8C0")]
	public FsmEvent finishedEvent;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private PlaySoundResult sound;

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x234E58C", Offset = "0x234E58C", VA = "0x234E58C", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x234E5D0", Offset = "0x234E5D0", VA = "0x234E5D0", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x234E90C", Offset = "0x234E90C", VA = "0x234E90C", Slot = "34")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x234E978", Offset = "0x234E978", VA = "0x234E978")]
	public MasterAudioPlaySoundWithEvent()
	{
	}
}
[Token(Token = "0x2000028")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B74C", Offset = "0xA0B74C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B74C", Offset = "0xA0B74C")]
public class MasterAudioPlaylistChange : FsmStateAction
{
	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D8F8", Offset = "0xA0D8F8")]
	public FsmString playlistControllerName;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D930", Offset = "0xA0D930")]
	public FsmString playlistName;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D97C", Offset = "0xA0D97C")]
	public FsmBool playFirstSong;

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x234EB5C", Offset = "0x234EB5C", VA = "0x234EB5C", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x234ECA8", Offset = "0x234ECA8", VA = "0x234ECA8", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x234EDAC", Offset = "0x234EDAC", VA = "0x234EDAC")]
	public MasterAudioPlaylistChange()
	{
	}
}
[Token(Token = "0x2000029")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B79C", Offset = "0xA0B79C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B79C", Offset = "0xA0B79C")]
public class MasterAudioPlaylistClipByName : FsmStateAction
{
	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0D9C8", Offset = "0xA0D9C8")]
	public FsmString playlistControllerName;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0DA00", Offset = "0xA0DA00")]
	public FsmString clipName;

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x234EDB4", Offset = "0x234EDB4", VA = "0x234EDB4", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x234EEC8", Offset = "0x234EEC8", VA = "0x234EEC8", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x234EF94", Offset = "0x234EF94", VA = "0x234EF94")]
	public MasterAudioPlaylistClipByName()
	{
	}
}
[Token(Token = "0x200002A")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B7EC", Offset = "0xA0B7EC")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B7EC", Offset = "0xA0B7EC")]
public class MasterAudioPlaylistClipNext : FsmStateAction
{
	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0DA4C", Offset = "0xA0DA4C")]
	public FsmBool allPlaylistControllers;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0DA84", Offset = "0xA0DA84")]
	public FsmString playlistControllerName;

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x234EF9C", Offset = "0x234EF9C", VA = "0x234EF9C", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x234F330", Offset = "0x234F330", VA = "0x234F330", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x234F410", Offset = "0x234F410", VA = "0x234F410")]
	public MasterAudioPlaylistClipNext()
	{
	}
}
[Token(Token = "0x200002B")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B83C", Offset = "0xA0B83C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B83C", Offset = "0xA0B83C")]
public class MasterAudioPlaylistClipRandom : FsmStateAction
{
	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0DABC", Offset = "0xA0DABC")]
	public FsmBool allPlaylistControllers;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0DAF4", Offset = "0xA0DAF4")]
	public FsmString playlistControllerName;

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x234F418", Offset = "0x234F418", VA = "0x234F418", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x234F5B4", Offset = "0x234F5B4", VA = "0x234F5B4", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x234F694", Offset = "0x234F694", VA = "0x234F694")]
	public MasterAudioPlaylistClipRandom()
	{
	}
}
[Token(Token = "0x200002C")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B88C", Offset = "0xA0B88C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B88C", Offset = "0xA0B88C")]
public class MasterAudioPlaylistControllerGetProps : FsmStateAction
{
	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0DB2C", Offset = "0xA0DB2C")]
	public FsmString PlaylistControllerName;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0DB64", Offset = "0xA0DB64")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0xA0DB64", Offset = "0xA0DB64")]
	public FsmFloat ControllerVolume;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0DBB4", Offset = "0xA0DBB4")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0xA0DBB4", Offset = "0xA0DBB4")]
	public FsmFloat CurrentAudioClipPitch;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0DC04", Offset = "0xA0DC04")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0xA0DC04", Offset = "0xA0DC04")]
	public FsmFloat CurrentAudioClipVolume;

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x234F69C", Offset = "0x234F69C", VA = "0x234F69C", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x234FC84", Offset = "0x234FC84", VA = "0x234FC84", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x234FD94", Offset = "0x234FD94", VA = "0x234FD94")]
	public MasterAudioPlaylistControllerGetProps()
	{
	}
}
[Token(Token = "0x200002D")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B8DC", Offset = "0xA0B8DC")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B8DC", Offset = "0xA0B8DC")]
public class MasterAudioPlaylistFade : FsmStateAction
{
	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0DC54", Offset = "0xA0DC54")]
	public FsmString playlistControllerName;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[RequiredField]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0xA0DC8C", Offset = "0xA0DC8C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0DC8C", Offset = "0xA0DC8C")]
	public FsmFloat targetVolume;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[RequiredField]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0xA0DCF0", Offset = "0xA0DCF0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0DCF0", Offset = "0xA0DCF0")]
	public FsmFloat fadeTime;

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x234FD9C", Offset = "0x234FD9C", VA = "0x234FD9C", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x234FED8", Offset = "0x234FED8", VA = "0x234FED8", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x234FFC4", Offset = "0x234FFC4", VA = "0x234FFC4")]
	public MasterAudioPlaylistFade()
	{
	}
}
[Token(Token = "0x200002E")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B92C", Offset = "0xA0B92C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B92C", Offset = "0xA0B92C")]
public class MasterAudioPlaylistGetCurrentClipName : FsmStateAction
{
	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0DD54", Offset = "0xA0DD54")]
	public FsmString playlistControllerName;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0DD8C", Offset = "0xA0DD8C")]
	[RequiredField]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0xA0DD8C", Offset = "0xA0DD8C")]
	public FsmString storeResult;

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x234FFCC", Offset = "0x234FFCC", VA = "0x234FFCC", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x23501B4", Offset = "0x23501B4", VA = "0x23501B4", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x2350280", Offset = "0x2350280", VA = "0x2350280")]
	public MasterAudioPlaylistGetCurrentClipName()
	{
	}
}
[Token(Token = "0x200002F")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B97C", Offset = "0xA0B97C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B97C", Offset = "0xA0B97C")]
public class MasterAudioPlaylistMute : FsmStateAction
{
	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0DDEC", Offset = "0xA0DDEC")]
	public FsmBool allPlaylistControllers;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0DE24", Offset = "0xA0DE24")]
	public FsmString playlistControllerName;

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x2350288", Offset = "0x2350288", VA = "0x2350288", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x23503DC", Offset = "0x23503DC", VA = "0x23503DC", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x23504BC", Offset = "0x23504BC", VA = "0x23504BC")]
	public MasterAudioPlaylistMute()
	{
	}
}
[Token(Token = "0x2000030")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0B9CC", Offset = "0xA0B9CC")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0B9CC", Offset = "0xA0B9CC")]
public class MasterAudioPlaylistPause : FsmStateAction
{
	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0DE5C", Offset = "0xA0DE5C")]
	public FsmBool allPlaylistControllers;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0DE94", Offset = "0xA0DE94")]
	public FsmString playlistControllerName;

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x23504C4", Offset = "0x23504C4", VA = "0x23504C4", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x2350660", Offset = "0x2350660", VA = "0x2350660", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x2350740", Offset = "0x2350740", VA = "0x2350740")]
	public MasterAudioPlaylistPause()
	{
	}
}
[Token(Token = "0x2000031")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0BA1C", Offset = "0xA0BA1C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0BA1C", Offset = "0xA0BA1C")]
public class MasterAudioPlaylistSetVolume : FsmStateAction
{
	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[RequiredField]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0xA0DECC", Offset = "0xA0DECC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0DECC", Offset = "0xA0DECC")]
	public FsmFloat newVolume;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0DF30", Offset = "0xA0DF30")]
	public bool everyFrame;

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x2350748", Offset = "0x2350748", VA = "0x2350748", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x2350808", Offset = "0x2350808", VA = "0x2350808", Slot = "34")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x2350784", Offset = "0x2350784", VA = "0x2350784")]
	private void SetVolume()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x235080C", Offset = "0x235080C", VA = "0x235080C", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x2350870", Offset = "0x2350870", VA = "0x2350870")]
	public MasterAudioPlaylistSetVolume()
	{
	}
}
[Token(Token = "0x2000032")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0BA6C", Offset = "0xA0BA6C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0BA6C", Offset = "0xA0BA6C")]
public class MasterAudioPlaylistStartByName : FsmStateAction
{
	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0DF68", Offset = "0xA0DF68")]
	public FsmString playlistControllerName;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0DFA0", Offset = "0xA0DFA0")]
	public FsmString playlistName;

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x2350878", Offset = "0x2350878", VA = "0x2350878", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x2350990", Offset = "0x2350990", VA = "0x2350990", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x2350A5C", Offset = "0x2350A5C", VA = "0x2350A5C")]
	public MasterAudioPlaylistStartByName()
	{
	}
}
[Token(Token = "0x2000033")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0BABC", Offset = "0xA0BABC")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0BABC", Offset = "0xA0BABC")]
public class MasterAudioPlaylistStop : FsmStateAction
{
	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0DFEC", Offset = "0xA0DFEC")]
	public FsmBool allPlaylistControllers;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E024", Offset = "0xA0E024")]
	public FsmString playlistControllerName;

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x2350A64", Offset = "0x2350A64", VA = "0x2350A64", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x2350C00", Offset = "0x2350C00", VA = "0x2350C00", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x2350CE0", Offset = "0x2350CE0", VA = "0x2350CE0")]
	public MasterAudioPlaylistStop()
	{
	}
}
[Token(Token = "0x2000034")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0BB0C", Offset = "0xA0BB0C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0BB0C", Offset = "0xA0BB0C")]
public class MasterAudioPlaylistToggleMute : FsmStateAction
{
	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E05C", Offset = "0xA0E05C")]
	public FsmBool allPlaylistControllers;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E094", Offset = "0xA0E094")]
	public FsmString playlistControllerName;

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x2350CE8", Offset = "0x2350CE8", VA = "0x2350CE8", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x2350E3C", Offset = "0x2350E3C", VA = "0x2350E3C", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x2350F1C", Offset = "0x2350F1C", VA = "0x2350F1C")]
	public MasterAudioPlaylistToggleMute()
	{
	}
}
[Token(Token = "0x2000035")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0BB5C", Offset = "0xA0BB5C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0BB5C", Offset = "0xA0BB5C")]
public class MasterAudioPlaylistUnmute : FsmStateAction
{
	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E0CC", Offset = "0xA0E0CC")]
	public FsmBool allPlaylistControllers;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E104", Offset = "0xA0E104")]
	public FsmString playlistControllerName;

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x2350F24", Offset = "0x2350F24", VA = "0x2350F24", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x2351078", Offset = "0x2351078", VA = "0x2351078", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x2351158", Offset = "0x2351158", VA = "0x2351158")]
	public MasterAudioPlaylistUnmute()
	{
	}
}
[Token(Token = "0x2000036")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0BBAC", Offset = "0xA0BBAC")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0BBAC", Offset = "0xA0BBAC")]
public class MasterAudioPlaylistUnpause : FsmStateAction
{
	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E13C", Offset = "0xA0E13C")]
	public FsmBool allPlaylistControllers;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E174", Offset = "0xA0E174")]
	public FsmString playlistControllerName;

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x2351160", Offset = "0x2351160", VA = "0x2351160", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x23512FC", Offset = "0x23512FC", VA = "0x23512FC", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x23513DC", Offset = "0x23513DC", VA = "0x23513DC")]
	public MasterAudioPlaylistUnpause()
	{
	}
}
[Token(Token = "0x2000037")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0BBFC", Offset = "0xA0BBFC")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0BBFC", Offset = "0xA0BBFC")]
public class MasterAudioSetMasterVolume : FsmStateAction
{
	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[RequiredField]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0xA0E1AC", Offset = "0xA0E1AC")]
	public FsmFloat volume;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E1EC", Offset = "0xA0E1EC")]
	public bool everyFrame;

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x23513E4", Offset = "0x23513E4", VA = "0x23513E4", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x23514A4", Offset = "0x23514A4", VA = "0x23514A4", Slot = "34")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x2351420", Offset = "0x2351420", VA = "0x2351420")]
	private void SetVolume()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x23514A8", Offset = "0x23514A8", VA = "0x23514A8", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x235152C", Offset = "0x235152C", VA = "0x235152C")]
	public MasterAudioSetMasterVolume()
	{
	}
}
[Token(Token = "0x2000038")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0BC4C", Offset = "0xA0BC4C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0BC4C", Offset = "0xA0BC4C")]
public class MasterAudioStopAllOfSound : FsmStateAction
{
	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E224", Offset = "0xA0E224")]
	public FsmBool allGroups;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E25C", Offset = "0xA0E25C")]
	public FsmString soundGroupName;

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x23515BC", Offset = "0x23515BC", VA = "0x23515BC", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x23517A4", Offset = "0x23517A4", VA = "0x23517A4", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x2351884", Offset = "0x2351884", VA = "0x2351884")]
	public MasterAudioStopAllOfSound()
	{
	}
}
[Token(Token = "0x2000039")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0BC9C", Offset = "0xA0BC9C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0BC9C", Offset = "0xA0BC9C")]
public class MasterAudioStopTransformSound : FsmStateAction
{
	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E294", Offset = "0xA0E294")]
	public FsmOwnerDefault gameObject;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E2E0", Offset = "0xA0E2E0")]
	public FsmBool allGroups;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E318", Offset = "0xA0E318")]
	public FsmString soundGroupName;

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x235188C", Offset = "0x235188C", VA = "0x235188C", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x2351AB0", Offset = "0x2351AB0", VA = "0x2351AB0", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x2351BC8", Offset = "0x2351BC8", VA = "0x2351BC8")]
	public MasterAudioStopTransformSound()
	{
	}
}
[Token(Token = "0x200003A")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0xA0BCEC", Offset = "0xA0BCEC")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0BCEC", Offset = "0xA0BCEC")]
public class MasterAudioVariationGetProps : FsmStateAction
{
	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E350", Offset = "0xA0E350")]
	public FsmString SoundGroupName;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E39C", Offset = "0xA0E39C")]
	public FsmString VariationName;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E3E8", Offset = "0xA0E3E8")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0xA0E3E8", Offset = "0xA0E3E8")]
	public FsmFloat VariationPitch;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E438", Offset = "0xA0E438")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0xA0E438", Offset = "0xA0E438")]
	public FsmFloat VariationVolume;

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x2351C38", Offset = "0x2351C38", VA = "0x2351C38", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x23520C8", Offset = "0x23520C8", VA = "0x23520C8", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x23521D8", Offset = "0x23521D8", VA = "0x23521D8")]
	public MasterAudioVariationGetProps()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x23521E0", Offset = "0x23521E0", VA = "0x23521E0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F094", Offset = "0xA0F094")]
	private bool <OnEnter>b__4_0(MasterAudio.AudioInfo obj)
	{
		return default(bool);
	}
}
[Token(Token = "0x200003B")]
[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0xA0BD3C", Offset = "0xA0BD3C")]
public class ListenerFollower : MonoBehaviour
{
	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform _transToFollow;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _goToFollow;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform _trans;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject _go;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SphereCollider _collider;

	[Token(Token = "0x17000001")]
	public SphereCollider Trigger
	{
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x19CAD3C", Offset = "0x19CAD3C", VA = "0x19CAD3C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public GameObject GameObj
	{
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x19CB17C", Offset = "0x19CB17C", VA = "0x19CB17C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	public Transform Trans
	{
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x19CAF64", Offset = "0x19CAF64", VA = "0x19CAF64")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x19CACC4", Offset = "0x19CACC4", VA = "0x19CACC4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x19AC5C8", Offset = "0x19AC5C8", VA = "0x19AC5C8")]
	public void StartFollowing(Transform transToFollow, float trigRadius)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x19AC97C", Offset = "0x19AC97C", VA = "0x19AC97C")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x19CAE10", Offset = "0x19CAE10", VA = "0x19CAE10")]
	private void BatchOcclusionRaycasts()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x19CB21C", Offset = "0x19CB21C", VA = "0x19CB21C")]
	public ListenerFollower()
	{
	}
}
[Token(Token = "0x200003C")]
public static class OculusAudioHelper
{
	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x2353FAC", Offset = "0x2353FAC", VA = "0x2353FAC")]
	public static bool DarkTonicOculusAudioPackageInstalled()
	{
		return default(bool);
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x2353FB4", Offset = "0x2353FB4", VA = "0x2353FB4")]
	public static void AddOculusAudioSourceToVariation(SoundGroupVariation variation)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x2353FB8", Offset = "0x2353FB8", VA = "0x2353FB8")]
	public static void AddOculusAudioSourceToAllVariations()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x2353FBC", Offset = "0x2353FBC", VA = "0x2353FBC")]
	public static void RemoveOculusAudioSourceFromAllVariations()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x2353FC0", Offset = "0x2353FC0", VA = "0x2353FC0")]
	public static void CopyOculusAudioSource(DynamicGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x2353FC4", Offset = "0x2353FC4", VA = "0x2353FC4")]
	public static void CopyOculusAudioSource(DynamicGroupVariation sourceVariation, SoundGroupVariation destVariation)
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x2353FC8", Offset = "0x2353FC8", VA = "0x2353FC8")]
	public static void CopyOculusAudioSource(SoundGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}
}
[Token(Token = "0x200003D")]
public static class ResonanceAudioHelper
{
	[Token(Token = "0x17000004")]
	public static bool ResonanceAudioOptionExists
	{
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2436970", Offset = "0x2436970", VA = "0x2436970")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x2436978", Offset = "0x2436978", VA = "0x2436978")]
	public static bool DarkTonicResonanceAudioPackageInstalled()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x2436980", Offset = "0x2436980", VA = "0x2436980")]
	public static void AddResonanceAudioSourceToVariation(SoundGroupVariation variation)
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x2436984", Offset = "0x2436984", VA = "0x2436984")]
	public static void AddResonanceAudioSourceToAllVariations()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x2436988", Offset = "0x2436988", VA = "0x2436988")]
	public static void RemoveResonanceAudioSourceFromAllVariations()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x243698C", Offset = "0x243698C", VA = "0x243698C")]
	public static void CopyResonanceAudioSource(DynamicGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x2436990", Offset = "0x2436990", VA = "0x2436990")]
	public static void CopyResonanceAudioSource(DynamicGroupVariation sourceVariation, SoundGroupVariation destVariation)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x2436994", Offset = "0x2436994", VA = "0x2436994")]
	public static void CopyResonanceAudioSource(SoundGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}
}
[Token(Token = "0x200003E")]
public class TransformFollower : MonoBehaviour
{
	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E488", Offset = "0xA0E488")]
	public Transform RuntimeFollowingTransform;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _goToFollow;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform _trans;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject _go;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SphereCollider _collider;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string _soundType;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string _variationName;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _willFollowSource;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	private bool _isInsideTrigger;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
	private bool _hasPlayedSound;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float _playVolume;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool _positionAtClosestColliderPoint;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private MasterAudio.AmbientSoundExitMode _exitMode;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float _exitFadeTime;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private MasterAudio.AmbientSoundReEnterMode _reEnterMode;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float _reEnterFadeTime;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly List<Collider> _actorColliders;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 _lastListenerPos;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly Dictionary<Collider, Vector3> _lastPositionByCollider;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private PlaySoundResult playingVariation;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private PlaySoundResult fadingVariation;

	[Token(Token = "0x17000005")]
	public SphereCollider Trigger
	{
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x243EDF8", Offset = "0x243EDF8", VA = "0x243EDF8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000006")]
	public GameObject GameObj
	{
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x243FA64", Offset = "0x243FA64", VA = "0x243FA64")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000007")]
	public Transform Trans
	{
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x244004C", Offset = "0x244004C", VA = "0x244004C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x243ED24", Offset = "0x243ED24", VA = "0x243ED24")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x243EECC", Offset = "0x243EECC", VA = "0x243EECC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x243F0B0", Offset = "0x243F0B0", VA = "0x243F0B0")]
	public void StartFollowing(Transform transToFollow, string soundType, string variationName, float volume, float trigRadius, bool willFollowSource, bool positionAtClosestColliderPoint, bool useTopCollider, bool useChildColliders, MasterAudio.AmbientSoundExitMode exitMode, float exitFadeTime, MasterAudio.AmbientSoundReEnterMode reEnterMode, float reEnterFadeTime)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x243F9E0", Offset = "0x243F9E0", VA = "0x243F9E0")]
	private void StopFollowing()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x243FB04", Offset = "0x243FB04", VA = "0x243FB04")]
	private void PlaySound()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x243FF5C", Offset = "0x243FF5C", VA = "0x243FF5C")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x243F54C", Offset = "0x243F54C", VA = "0x243F54C")]
	public bool RecalcClosestColliderPosition(bool forceRecalc = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x24400EC", Offset = "0x24400EC", VA = "0x24400EC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x2440208", Offset = "0x2440208", VA = "0x2440208")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x243EF38", Offset = "0x243EF38", VA = "0x243EF38")]
	private void PerformTriggerExit()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x2440300", Offset = "0x2440300", VA = "0x2440300")]
	public TransformFollower()
	{
	}
}
namespace RelationsInspector.Backend.AutoBackend
{
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xA0BD50", Offset = "0xA0BD50")]
	public class AutoBackendAttribute : Attribute
	{
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x19B23A8", Offset = "0x19B23A8", VA = "0x19B23A8")]
		public AutoBackendAttribute()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xA0BD64", Offset = "0xA0BD64")]
	public class RelatedAttribute : Attribute
	{
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2436960", Offset = "0x2436960", VA = "0x2436960")]
		public RelatedAttribute()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xA0BD78", Offset = "0xA0BD78")]
	public class RelatingAttribute : Attribute
	{
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2436968", Offset = "0x2436968", VA = "0x2436968")]
		public RelatingAttribute()
		{
		}
	}
}
namespace DarkTonic.MasterAudio
{
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA0BD8C", Offset = "0xA0BD8C")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0xA0BD8C", Offset = "0xA0BD8C")]
	public class AmbientSound : MonoBehaviour
	{
		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SoundGroup]
		public string AmbientSoundGroup;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string variationName;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float playVolume;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public MasterAudio.AmbientSoundExitMode exitMode;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float exitFadeTime;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AmbientSoundReEnterMode reEnterMode;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float reEnterFadeTime;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E4D0", Offset = "0xA0E4D0")]
		public bool FollowCaller;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E508", Offset = "0xA0E508")]
		public bool UseClosestColliderPosition;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
		public bool UseTopCollider;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x47")]
		public bool IncludeChildColliders;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E540", Offset = "0xA0E540")]
		public Transform RuntimeFollower;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _trans;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float colliderMaxDistance;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public long lastTimeMaxDistanceCalced;

		[Token(Token = "0x17000008")]
		public bool IsValidSoundGroup
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x19A9098", Offset = "0x19A9098", VA = "0x19A9098")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000009")]
		public Transform Trans
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x19A98D0", Offset = "0x19A98D0", VA = "0x19A98D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x19A8C5C", Offset = "0x19A8C5C", VA = "0x19A8C5C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x19A8F48", Offset = "0x19A8F48", VA = "0x19A8F48")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x19A94C8", Offset = "0x19A94C8", VA = "0x19A94C8")]
		private void StopTrackers()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x19A9DD4", Offset = "0x19A9DD4", VA = "0x19A9DD4")]
		public void CalculateRadius()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x19A9EC8", Offset = "0x19A9EC8", VA = "0x19A9EC8")]
		public AudioSource GetNamedOrFirstAudioSource()
		{
			return null;
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x19AA2D4", Offset = "0x19AA2D4", VA = "0x19AA2D4")]
		public List<AudioSource> GetAllVariationAudioSources()
		{
			return null;
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x19AA4FC", Offset = "0x19AA4FC", VA = "0x19AA4FC")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x19AA76C", Offset = "0x19AA76C", VA = "0x19AA76C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x19AA9DC", Offset = "0x19AA9DC", VA = "0x19AA9DC")]
		public void StartTrackers()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x19AB920", Offset = "0x19AB920", VA = "0x19AB920")]
		public AmbientSound()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA0BDDC", Offset = "0xA0BDDC")]
	public class ButtonClicker : MonoBehaviour
	{
		[Token(Token = "0x40000B8")]
		public const float SmallSizeMultiplier = 0.9f;

		[Token(Token = "0x40000B9")]
		public const float LargeSizeMultiplier = 1.1f;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool resizeOnClick;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool resizeClickAllSiblings;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool resizeOnHover;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool resizeHoverAllSiblings;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string mouseDownSound;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string mouseUpSound;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string mouseClickSound;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string mouseOverSound;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mouseOutSound;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _originalSize;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _smallerSize;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 _largerSize;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _trans;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly Dictionary<Transform, Vector3> _siblingClickScaleByTransform;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly Dictionary<Transform, Vector3> _siblingHoverScaleByTransform;

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x19B23D0", Offset = "0x19B23D0", VA = "0x19B23D0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x19B2644", Offset = "0x19B2644", VA = "0x19B2644")]
		private void OnPress(bool isDown)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x19B2A5C", Offset = "0x19B2A5C", VA = "0x19B2A5C")]
		private void OnClick()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x19B2AF4", Offset = "0x19B2AF4", VA = "0x19B2AF4")]
		private void OnHover(bool isOver)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x19B2D40", Offset = "0x19B2D40", VA = "0x19B2D40")]
		public ButtonClicker()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0xA0BE14", Offset = "0xA0BE14")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA0BE14", Offset = "0xA0BE14")]
	public class EventSounds : MonoBehaviour, ICustomEventReceiver
	{
		[Token(Token = "0x2000097")]
		public enum UnityUIVersion
		{
			[Token(Token = "0x40004E7")]
			Legacy,
			[Token(Token = "0x40004E8")]
			uGUI
		}

		[Token(Token = "0x2000098")]
		public enum EventType
		{
			[Token(Token = "0x40004EA")]
			OnStart,
			[Token(Token = "0x40004EB")]
			OnVisible,
			[Token(Token = "0x40004EC")]
			OnInvisible,
			[Token(Token = "0x40004ED")]
			OnCollision,
			[Token(Token = "0x40004EE")]
			OnTriggerEnter,
			[Token(Token = "0x40004EF")]
			OnTriggerExit,
			[Token(Token = "0x40004F0")]
			OnMouseEnter,
			[Token(Token = "0x40004F1")]
			OnMouseClick,
			[Token(Token = "0x40004F2")]
			OnSpawned,
			[Token(Token = "0x40004F3")]
			OnDespawned,
			[Token(Token = "0x40004F4")]
			OnEnable,
			[Token(Token = "0x40004F5")]
			OnDisable,
			[Token(Token = "0x40004F6")]
			OnCollision2D,
			[Token(Token = "0x40004F7")]
			OnTriggerEnter2D,
			[Token(Token = "0x40004F8")]
			OnTriggerExit2D,
			[Token(Token = "0x40004F9")]
			OnParticleCollision,
			[Token(Token = "0x40004FA")]
			UserDefinedEvent,
			[Token(Token = "0x40004FB")]
			OnCollisionExit,
			[Token(Token = "0x40004FC")]
			OnCollisionExit2D,
			[Token(Token = "0x40004FD")]
			OnMouseUp,
			[Token(Token = "0x40004FE")]
			OnMouseExit,
			[Token(Token = "0x40004FF")]
			OnMouseDrag,
			[Token(Token = "0x4000500")]
			NGUIOnClick,
			[Token(Token = "0x4000501")]
			NGUIMouseDown,
			[Token(Token = "0x4000502")]
			NGUIMouseUp,
			[Token(Token = "0x4000503")]
			NGUIMouseEnter,
			[Token(Token = "0x4000504")]
			NGUIMouseExit,
			[Token(Token = "0x4000505")]
			MechanimStateChanged,
			[Token(Token = "0x4000506")]
			UnitySliderChanged,
			[Token(Token = "0x4000507")]
			UnityButtonClicked,
			[Token(Token = "0x4000508")]
			UnityPointerDown,
			[Token(Token = "0x4000509")]
			UnityPointerUp,
			[Token(Token = "0x400050A")]
			UnityPointerEnter,
			[Token(Token = "0x400050B")]
			UnityPointerExit,
			[Token(Token = "0x400050C")]
			UnityDrag,
			[Token(Token = "0x400050D")]
			UnityDrop,
			[Token(Token = "0x400050E")]
			UnityScroll,
			[Token(Token = "0x400050F")]
			UnityUpdateSelected,
			[Token(Token = "0x4000510")]
			UnitySelect,
			[Token(Token = "0x4000511")]
			UnityDeselect,
			[Token(Token = "0x4000512")]
			UnityMove,
			[Token(Token = "0x4000513")]
			UnityInitializePotentialDrag,
			[Token(Token = "0x4000514")]
			UnityBeginDrag,
			[Token(Token = "0x4000515")]
			UnityEndDrag,
			[Token(Token = "0x4000516")]
			UnitySubmit,
			[Token(Token = "0x4000517")]
			UnityCancel,
			[Token(Token = "0x4000518")]
			UnityToggle,
			[Token(Token = "0x4000519")]
			OnTriggerStay,
			[Token(Token = "0x400051A")]
			OnTriggerStay2D,
			[Token(Token = "0x400051B")]
			CodeTriggeredEvent1,
			[Token(Token = "0x400051C")]
			CodeTriggeredEvent2
		}

		[Token(Token = "0x2000099")]
		public enum GlidePitchType
		{
			[Token(Token = "0x400051E")]
			None,
			[Token(Token = "0x400051F")]
			RaisePitch,
			[Token(Token = "0x4000520")]
			LowerPitch
		}

		[Token(Token = "0x200009A")]
		public enum VariationType
		{
			[Token(Token = "0x4000522")]
			PlaySpecific,
			[Token(Token = "0x4000523")]
			PlayRandom
		}

		[Token(Token = "0x200009B")]
		public enum PreviousSoundStopMode
		{
			[Token(Token = "0x4000525")]
			None,
			[Token(Token = "0x4000526")]
			Stop,
			[Token(Token = "0x4000527")]
			FadeOut
		}

		[Token(Token = "0x200009C")]
		public enum RetriggerLimMode
		{
			[Token(Token = "0x4000529")]
			None,
			[Token(Token = "0x400052A")]
			FrameBased,
			[Token(Token = "0x400052B")]
			TimeBased
		}

		[Token(Token = "0x200009D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C000", Offset = "0xA0C000")]
		private sealed class <CoUpdate>d__127 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400052E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EventSounds <>4__this;

			[Token(Token = "0x170000B9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004B8")]
				[Address(RVA = "0x244192C", Offset = "0x244192C", VA = "0x244192C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004BA")]
				[Address(RVA = "0x2441974", Offset = "0x2441974", VA = "0x2441974", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x2441760", Offset = "0x2441760", VA = "0x2441760")]
			[DebuggerHidden]
			public <CoUpdate>d__127(int <>1__state)
			{
			}

			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x244178C", Offset = "0x244178C", VA = "0x244178C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x2441790", Offset = "0x2441790", VA = "0x2441790", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x2441934", Offset = "0x2441934", VA = "0x2441934", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200009E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C010", Offset = "0xA0C010")]
		private sealed class <>c__DisplayClass176_0
		{
			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string stateName;

			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x2441734", Offset = "0x2441734", VA = "0x2441734")]
			public <>c__DisplayClass176_0()
			{
			}

			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x244173C", Offset = "0x244173C", VA = "0x244173C")]
			internal bool <GetMechanimAudioEventGroup>b__0(AudioEventGroup grp)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.SoundSpawnLocationMode soundSpawnMode;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool disableSounds;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool showPoolManager;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		public bool showNGUI;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioEvent eventToGizmo;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityUIVersion unityUIMode;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool logMissingEvents;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<string> LayerTagFilterEvents;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static List<MasterAudio.PlaylistCommand> PlaylistCommandsWithAll;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioEventGroup startSound;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioEventGroup visibleSound;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioEventGroup invisibleSound;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioEventGroup collisionSound;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudioEventGroup collisionExitSound;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioEventGroup triggerSound;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AudioEventGroup triggerExitSound;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioEventGroup triggerStaySound;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AudioEventGroup mouseEnterSound;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AudioEventGroup mouseExitSound;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AudioEventGroup mouseClickSound;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AudioEventGroup mouseUpSound;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public AudioEventGroup mouseDragSound;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AudioEventGroup spawnedSound;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public AudioEventGroup despawnedSound;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AudioEventGroup enableSound;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AudioEventGroup disableSound;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public AudioEventGroup collision2dSound;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public AudioEventGroup collisionExit2dSound;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public AudioEventGroup triggerEnter2dSound;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public AudioEventGroup triggerStay2dSound;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public AudioEventGroup triggerExit2dSound;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public AudioEventGroup particleCollisionSound;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public AudioEventGroup nguiOnClickSound;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public AudioEventGroup nguiMouseDownSound;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public AudioEventGroup nguiMouseUpSound;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public AudioEventGroup nguiMouseEnterSound;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public AudioEventGroup nguiMouseExitSound;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public AudioEventGroup codeTriggeredEvent1Sound;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public AudioEventGroup codeTriggeredEvent2Sound;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public AudioEventGroup unitySliderChangedSound;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public AudioEventGroup unityButtonClickedSound;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public AudioEventGroup unityPointerDownSound;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public AudioEventGroup unityDragSound;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public AudioEventGroup unityPointerUpSound;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public AudioEventGroup unityPointerEnterSound;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public AudioEventGroup unityPointerExitSound;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public AudioEventGroup unityDropSound;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public AudioEventGroup unityScrollSound;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public AudioEventGroup unityUpdateSelectedSound;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public AudioEventGroup unitySelectSound;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public AudioEventGroup unityDeselectSound;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public AudioEventGroup unityMoveSound;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public AudioEventGroup unityInitializePotentialDragSound;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public AudioEventGroup unityBeginDragSound;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public AudioEventGroup unityEndDragSound;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public AudioEventGroup unitySubmitSound;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public AudioEventGroup unityCancelSound;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public AudioEventGroup unityToggleSound;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public List<AudioEventGroup> userDefinedSounds;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public List<AudioEventGroup> mechanimStateChangedSounds;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public bool useStartSound;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C9")]
		public bool useVisibleSound;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CA")]
		public bool useInvisibleSound;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CB")]
		public bool useCollisionSound;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		public bool useCollisionExitSound;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CD")]
		public bool useTriggerEnterSound;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CE")]
		public bool useTriggerExitSound;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CF")]
		public bool useTriggerStaySound;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public bool useMouseEnterSound;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D1")]
		public bool useMouseExitSound;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D2")]
		public bool useMouseClickSound;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D3")]
		public bool useMouseUpSound;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		public bool useMouseDragSound;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D5")]
		public bool useSpawnedSound;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D6")]
		public bool useDespawnedSound;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D7")]
		public bool useEnableSound;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public bool useDisableSound;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D9")]
		public bool useCollision2dSound;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DA")]
		public bool useCollisionExit2dSound;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DB")]
		public bool useTriggerEnter2dSound;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		public bool useTriggerStay2dSound;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DD")]
		public bool useTriggerExit2dSound;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DE")]
		public bool useParticleCollisionSound;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DF")]
		public bool useNguiOnClickSound;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public bool useNguiMouseDownSound;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		public bool useNguiMouseUpSound;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E2")]
		public bool useNguiMouseEnterSound;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E3")]
		public bool useNguiMouseExitSound;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		public bool useCodeTriggeredEvent1Sound;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		public bool useCodeTriggeredEvent2Sound;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E6")]
		public bool useUnitySliderChangedSound;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E7")]
		public bool useUnityButtonClickedSound;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		public bool useUnityPointerDownSound;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E9")]
		public bool useUnityDragSound;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EA")]
		public bool useUnityPointerUpSound;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EB")]
		public bool useUnityPointerEnterSound;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
		public bool useUnityPointerExitSound;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1ED")]
		public bool useUnityDropSound;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EE")]
		public bool useUnityScrollSound;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EF")]
		public bool useUnityUpdateSelectedSound;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		public bool useUnitySelectSound;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F1")]
		public bool useUnityDeselectSound;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F2")]
		public bool useUnityMoveSound;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F3")]
		public bool useUnityInitializePotentialDragSound;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
		public bool useUnityBeginDragSound;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F5")]
		public bool useUnityEndDragSound;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F6")]
		public bool useUnitySubmitSound;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F7")]
		public bool useUnityCancelSound;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		public bool useUnityToggleSound;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private Slider _slider;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private Toggle _toggle;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private Button _button;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private bool _isVisible;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x219")]
		private bool _needsCoroutine;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
		private float? _triggerEnterTime;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		private float? _triggerEnter2dTime;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private Transform _trans;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private readonly List<AudioEventGroup> _validMechanimStateChangedSounds;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private Animator _anim;

		[Token(Token = "0x1700000A")]
		private bool IsSetToUGUI
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x19B8628", Offset = "0x19B8628", VA = "0x19B8628")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		private bool IsSetToLegacyUI
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x19BA54C", Offset = "0x19BA54C", VA = "0x19BA54C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x19B8500", Offset = "0x19B8500", VA = "0x19B8500")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x19B88A4", Offset = "0x19B88A4", VA = "0x19B88A4", Slot = "10")]
		protected virtual void SpawnedOrAwake()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x19B8A04", Offset = "0x19B8A04", VA = "0x19B8A04")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0F0A4", Offset = "0xA0F0A4")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x19B8A7C", Offset = "0x19B8A7C", VA = "0x19B8A7C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x19B9154", Offset = "0x19B9154", VA = "0x19B9154")]
		private void OnBecameVisible()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x19B917C", Offset = "0x19B917C", VA = "0x19B917C")]
		private void OnBecameInvisible()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x19B9198", Offset = "0x19B9198", VA = "0x19B9198")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x19B9454", Offset = "0x19B9454", VA = "0x19B9454")]
		private void RestorePersistentSliders()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x19B97E0", Offset = "0x19B97E0", VA = "0x19B97E0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x19B9C24", Offset = "0x19B9C24", VA = "0x19B9C24")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x19B9D40", Offset = "0x19B9D40", VA = "0x19B9D40")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x19B9E5C", Offset = "0x19B9E5C", VA = "0x19B9E5C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x19B9FA4", Offset = "0x19B9FA4", VA = "0x19B9FA4")]
		private void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x19BA0A0", Offset = "0x19BA0A0", VA = "0x19BA0A0")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x19BA1C4", Offset = "0x19BA1C4", VA = "0x19BA1C4")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x19BA2E0", Offset = "0x19BA2E0", VA = "0x19BA2E0")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x19BA300", Offset = "0x19BA300", VA = "0x19BA300")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x19BA320", Offset = "0x19BA320", VA = "0x19BA320")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x19BA340", Offset = "0x19BA340", VA = "0x19BA340")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x19BA360", Offset = "0x19BA360", VA = "0x19BA360")]
		private void OnDrag(Vector2 delta)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x19BA364", Offset = "0x19BA364", VA = "0x19BA364")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x19BA384", Offset = "0x19BA384", VA = "0x19BA384")]
		private void OnDrop(GameObject go)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x19BA388", Offset = "0x19BA388", VA = "0x19BA388")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x19BA3A8", Offset = "0x19BA3A8", VA = "0x19BA3A8")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x19BA3C8", Offset = "0x19BA3C8", VA = "0x19BA3C8")]
		public void OnUpdateSelected(BaseEventData data)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x19BA3E8", Offset = "0x19BA3E8", VA = "0x19BA3E8")]
		private void OnSelect(bool isSelected)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x19BA3EC", Offset = "0x19BA3EC", VA = "0x19BA3EC")]
		public void OnSelect(BaseEventData data)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x19BA40C", Offset = "0x19BA40C", VA = "0x19BA40C")]
		public void OnDeselect(BaseEventData data)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x19BA42C", Offset = "0x19BA42C", VA = "0x19BA42C")]
		public void OnMove(AxisEventData data)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x19BA44C", Offset = "0x19BA44C", VA = "0x19BA44C")]
		public void OnInitializePotentialDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x19BA46C", Offset = "0x19BA46C", VA = "0x19BA46C")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x19BA48C", Offset = "0x19BA48C", VA = "0x19BA48C")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x19BA4AC", Offset = "0x19BA4AC", VA = "0x19BA4AC")]
		public void OnSubmit(BaseEventData data)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x19BA4CC", Offset = "0x19BA4CC", VA = "0x19BA4CC")]
		public void OnCancel(BaseEventData data)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x19BA4EC", Offset = "0x19BA4EC", VA = "0x19BA4EC")]
		private void SliderChanged(float newValue)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x19BA51C", Offset = "0x19BA51C", VA = "0x19BA51C")]
		private void ToggleChanged(bool newValue)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x19BA534", Offset = "0x19BA534", VA = "0x19BA534")]
		private void ButtonClicked()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x19BA55C", Offset = "0x19BA55C", VA = "0x19BA55C")]
		private void OnPress(bool isDown)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x19BA594", Offset = "0x19BA594", VA = "0x19BA594")]
		private void OnClick()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x19BA5B4", Offset = "0x19BA5B4", VA = "0x19BA5B4")]
		private void OnHover(bool isOver)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x19BA5EC", Offset = "0x19BA5EC", VA = "0x19BA5EC")]
		private void OnSpawned()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x19BA63C", Offset = "0x19BA63C", VA = "0x19BA63C")]
		private void OnDespawned()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x19BA65C", Offset = "0x19BA65C", VA = "0x19BA65C")]
		public void ActivateCodeTriggeredEvent1()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x19BA674", Offset = "0x19BA674", VA = "0x19BA674")]
		public void ActivateCodeTriggeredEvent2()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x19BA68C", Offset = "0x19BA68C", VA = "0x19BA68C")]
		public void CalculateRadius(AudioEvent anEvent)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x19BA734", Offset = "0x19BA734", VA = "0x19BA734")]
		public AudioSource GetNamedOrFirstAudioSource(AudioEvent anEvent)
		{
			return null;
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x19BA918", Offset = "0x19BA918", VA = "0x19BA918")]
		public List<AudioSource> GetAllVariationAudioSources(AudioEvent anEvent)
		{
			return null;
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x19BAB44", Offset = "0x19BAB44", VA = "0x19BAB44")]
		public AudioEventGroup GetMechanimAudioEventGroup(string stateName)
		{
			return null;
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x19B8EF4", Offset = "0x19B8EF4", VA = "0x19B8EF4")]
		public bool PlaySounds(AudioEventGroup eventGrp, EventType eType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x19BD21C", Offset = "0x19BD21C", VA = "0x19BD21C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x19BD404", Offset = "0x19BD404", VA = "0x19BD404")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x19BAC40", Offset = "0x19BAC40", VA = "0x19BAC40")]
		private static bool CheckForRetriggerLimit(AudioEventGroup grp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x19BADB4", Offset = "0x19BADB4", VA = "0x19BADB4")]
		private void PerformSingleAction(AudioEventGroup grp, AudioEvent aEvent, EventType eType)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x19C60AC", Offset = "0x19C60AC", VA = "0x19C60AC")]
		private void LogIfCustomEventMissing(AudioEventGroup eventGroup)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x19B8ABC", Offset = "0x19B8ABC", VA = "0x19B8ABC", Slot = "4")]
		public void CheckForIllegalCustomEvents()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x19C655C", Offset = "0x19C655C", VA = "0x19C655C", Slot = "5")]
		public void ReceiveEvent(string customEventName, Vector3 originPoint)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x19C6638", Offset = "0x19C6638", VA = "0x19C6638", Slot = "6")]
		public bool SubscribesToEvent(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x19B9748", Offset = "0x19B9748", VA = "0x19B9748", Slot = "7")]
		public void RegisterReceiver()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x19B9B94", Offset = "0x19B9B94", VA = "0x19B9B94", Slot = "8")]
		public void UnregisterReceiver()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x19C7050", Offset = "0x19C7050", VA = "0x19C7050", Slot = "9")]
		public IList<AudioEventGroup> GetAllEvents()
		{
			return null;
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x19B8638", Offset = "0x19B8638", VA = "0x19B8638")]
		private void AddUGUIComponents()
		{
		}

		[Token(Token = "0x600012E")]
		private void AddUGUIHandler<T>(bool useSound) where T : EventSoundsUGUIHandler
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x19C70A4", Offset = "0x19C70A4", VA = "0x19C70A4")]
		public EventSounds()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class EventSoundsUGUIHandler : MonoBehaviour
	{
		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0E578", Offset = "0xA0E578")]
		private EventSounds <eventSounds>k__BackingField;

		[Token(Token = "0x1700000C")]
		public EventSounds eventSounds
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x19C804C", Offset = "0x19C804C", VA = "0x19C804C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F104", Offset = "0xA0F104")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x19C8054", Offset = "0x19C8054", VA = "0x19C8054")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F114", Offset = "0xA0F114")]
			set
			{
			}
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x19C76DC", Offset = "0x19C76DC", VA = "0x19C76DC")]
		public EventSoundsUGUIHandler()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class EventSoundsPointerEnterHandler : EventSoundsUGUIHandler, IPointerEnterHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x19C7C44", Offset = "0x19C7C44", VA = "0x19C7C44", Slot = "4")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x19C7CE8", Offset = "0x19C7CE8", VA = "0x19C7CE8")]
		public EventSoundsPointerEnterHandler()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class EventSoundsPointerExitHandler : EventSoundsUGUIHandler, IPointerExitHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x19C7CF0", Offset = "0x19C7CF0", VA = "0x19C7CF0", Slot = "4")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x19C7D94", Offset = "0x19C7D94", VA = "0x19C7D94")]
		public EventSoundsPointerExitHandler()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class EventSoundsPointerDownHandler : EventSoundsUGUIHandler, IPointerDownHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x19C7B98", Offset = "0x19C7B98", VA = "0x19C7B98", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x19C7C3C", Offset = "0x19C7C3C", VA = "0x19C7C3C")]
		public EventSoundsPointerDownHandler()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class EventSoundsPointerUpHandler : EventSoundsUGUIHandler, IPointerUpHandler, IEventSystemHandler
	{
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x19C7D9C", Offset = "0x19C7D9C", VA = "0x19C7D9C", Slot = "4")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x19C7E40", Offset = "0x19C7E40", VA = "0x19C7E40")]
		public EventSoundsPointerUpHandler()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class EventSoundsDragHandler : EventSoundsUGUIHandler, IDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x19C783C", Offset = "0x19C783C", VA = "0x19C783C", Slot = "4")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x19C78E0", Offset = "0x19C78E0", VA = "0x19C78E0")]
		public EventSoundsDragHandler()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class EventSoundsDropHandler : EventSoundsUGUIHandler, IDropHandler, IEventSystemHandler
	{
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x19C78E8", Offset = "0x19C78E8", VA = "0x19C78E8", Slot = "4")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x19C798C", Offset = "0x19C798C", VA = "0x19C798C")]
		public EventSoundsDropHandler()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class EventSoundsScrollHandler : EventSoundsUGUIHandler, IScrollHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x19C7E48", Offset = "0x19C7E48", VA = "0x19C7E48", Slot = "4")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x19C7EEC", Offset = "0x19C7EEC", VA = "0x19C7EEC")]
		public EventSoundsScrollHandler()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class EventSoundsUpdateSelectedHandler : EventSoundsUGUIHandler, IUpdateSelectedHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x19C805C", Offset = "0x19C805C", VA = "0x19C805C", Slot = "4")]
		public void OnUpdateSelected(BaseEventData data)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x19C8100", Offset = "0x19C8100", VA = "0x19C8100")]
		public EventSoundsUpdateSelectedHandler()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class EventSoundsSelectHandler : EventSoundsUGUIHandler, ISelectHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x19C7EF4", Offset = "0x19C7EF4", VA = "0x19C7EF4", Slot = "4")]
		public void OnSelect(BaseEventData data)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x19C7F98", Offset = "0x19C7F98", VA = "0x19C7F98")]
		public EventSoundsSelectHandler()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class EventSoundsDeselectHandler : EventSoundsUGUIHandler, IDeselectHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x19C7790", Offset = "0x19C7790", VA = "0x19C7790", Slot = "4")]
		public void OnDeselect(BaseEventData data)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x19C7834", Offset = "0x19C7834", VA = "0x19C7834")]
		public EventSoundsDeselectHandler()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class EventSoundsMoveHandler : EventSoundsUGUIHandler, IMoveHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x19C7AEC", Offset = "0x19C7AEC", VA = "0x19C7AEC", Slot = "4")]
		public void OnMove(AxisEventData data)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x19C7B90", Offset = "0x19C7B90", VA = "0x19C7B90")]
		public EventSoundsMoveHandler()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class EventSoundsInitializePotentialDragHandler : EventSoundsUGUIHandler, IInitializePotentialDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x19C7A40", Offset = "0x19C7A40", VA = "0x19C7A40", Slot = "4")]
		public void OnInitializePotentialDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x19C7AE4", Offset = "0x19C7AE4", VA = "0x19C7AE4")]
		public EventSoundsInitializePotentialDragHandler()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class EventSoundsBeginDragHandler : EventSoundsUGUIHandler, IBeginDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x19C7630", Offset = "0x19C7630", VA = "0x19C7630", Slot = "4")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x19C76D4", Offset = "0x19C76D4", VA = "0x19C76D4")]
		public EventSoundsBeginDragHandler()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class EventSoundsEndDragHandler : EventSoundsUGUIHandler, IEndDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x19C7994", Offset = "0x19C7994", VA = "0x19C7994", Slot = "4")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x19C7A38", Offset = "0x19C7A38", VA = "0x19C7A38")]
		public EventSoundsEndDragHandler()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class EventSoundsSubmitHandler : EventSoundsUGUIHandler, ISubmitHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x19C7FA0", Offset = "0x19C7FA0", VA = "0x19C7FA0", Slot = "4")]
		public void OnSubmit(BaseEventData data)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x19C8044", Offset = "0x19C8044", VA = "0x19C8044")]
		public EventSoundsSubmitHandler()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class EventSoundsCancelHandler : EventSoundsUGUIHandler, ICancelHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x19C76E4", Offset = "0x19C76E4", VA = "0x19C76E4", Slot = "4")]
		public void OnCancel(BaseEventData data)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x19C7788", Offset = "0x19C7788", VA = "0x19C7788")]
		public EventSoundsCancelHandler()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA0BE64", Offset = "0xA0BE64")]
	public class FootstepSounds : MonoBehaviour
	{
		[Token(Token = "0x200009F")]
		public enum FootstepTriggerMode
		{
			[Token(Token = "0x4000531")]
			None,
			[Token(Token = "0x4000532")]
			OnCollision,
			[Token(Token = "0x4000533")]
			OnTriggerEnter,
			[Token(Token = "0x4000534")]
			OnCollision2D,
			[Token(Token = "0x4000535")]
			OnTriggerEnter2D
		}

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.SoundSpawnLocationMode soundSpawnMode;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public FootstepTriggerMode footstepEvent;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<FootstepGroup> footstepGroups;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EventSounds.RetriggerLimMode retriggerLimitMode;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int limitPerXFrm;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float limitPerXSec;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int triggeredLastFrame;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float triggeredLastTime;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform _trans;

		[Token(Token = "0x1700000D")]
		private Transform Trans
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x19CA8EC", Offset = "0x19CA8EC", VA = "0x19CA8EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x19CA490", Offset = "0x19CA490", VA = "0x19CA490")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x19CA80C", Offset = "0x19CA80C", VA = "0x19CA80C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x19CA85C", Offset = "0x19CA85C", VA = "0x19CA85C")]
		private bool CheckForRetriggerLimit()
		{
			return default(bool);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x19CA4E0", Offset = "0x19CA4E0", VA = "0x19CA4E0")]
		private void PlaySoundsIfMatch(GameObject go)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x19CA98C", Offset = "0x19CA98C", VA = "0x19CA98C")]
		public FootstepSounds()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class MechanimStateCustomEvents : StateMachineBehaviour
	{
		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E588", Offset = "0xA0E588")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA0E588", Offset = "0xA0E588")]
		public bool RetriggerWhenStateLoops;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E5E8", Offset = "0xA0E5E8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA0E5E8", Offset = "0xA0E5E8")]
		public bool fireEnterEvent;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[MasterCustomEvent]
		public string enterCustomEvent;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E658", Offset = "0xA0E658")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA0E658", Offset = "0xA0E658")]
		public bool fireExitEvent;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[MasterCustomEvent]
		public string exitCustomEvent;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E6C8", Offset = "0xA0E6C8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA0E6C8", Offset = "0xA0E6C8")]
		public bool fireAnimTimeEvent;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E728", Offset = "0xA0E728")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0E728", Offset = "0xA0E728")]
		public float whenToFireEvent;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[MasterCustomEvent]
		public string timedCustomEvent;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E78C", Offset = "0xA0E78C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA0E78C", Offset = "0xA0E78C")]
		public bool fireMultiAnimTimeEvent;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0E7EC", Offset = "0xA0E7EC")]
		public int numOfMultiEventsToFire;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E804", Offset = "0xA0E804")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0E804", Offset = "0xA0E804")]
		public float whenToFireMultiEvent1;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E858", Offset = "0xA0E858")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0E858", Offset = "0xA0E858")]
		public float whenToFireMultiEvent2;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E8AC", Offset = "0xA0E8AC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0E8AC", Offset = "0xA0E8AC")]
		public float whenToFireMultiEvent3;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E900", Offset = "0xA0E900")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0E900", Offset = "0xA0E900")]
		public float whenToFireMultiEvent4;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[MasterCustomEvent]
		public string MultiTimedEvent;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _playMultiEvent1;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool _playMultiEvent2;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool _playMultiEvent3;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		private bool _playMultiEvent4;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool _fireTimedEvent;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _actorTrans;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _lastRepetition;

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x2352244", Offset = "0x2352244", VA = "0x2352244", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x23523DC", Offset = "0x23523DC", VA = "0x23523DC", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x23526EC", Offset = "0x23526EC", VA = "0x23526EC", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x2352334", Offset = "0x2352334", VA = "0x2352334")]
		private Transform ActorTrans(Animator anim)
		{
			return null;
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x23527CC", Offset = "0x23527CC", VA = "0x23527CC")]
		public MechanimStateCustomEvents()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public class MechanimStateSounds : StateMachineBehaviour
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA0E964", Offset = "0xA0E964")]
		public bool SoundFollowsObject;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E99C", Offset = "0xA0E99C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA0E99C", Offset = "0xA0E99C")]
		public bool RetriggerWhenStateLoops;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0E9FC", Offset = "0xA0E9FC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA0E9FC", Offset = "0xA0E9FC")]
		public bool playEnterSound;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool stopEnterSoundOnExit;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SoundGroup]
		public string enterSoundGroup;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0EA6C", Offset = "0xA0EA6C")]
		public string enterVariationName;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool wasEnterSoundPlayed;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0EAA4", Offset = "0xA0EAA4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA0EAA4", Offset = "0xA0EAA4")]
		public bool playExitSound;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SoundGroup]
		public string exitSoundGroup;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0EB14", Offset = "0xA0EB14")]
		public string exitVariationName;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0EB4C", Offset = "0xA0EB4C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA0EB4C", Offset = "0xA0EB4C")]
		public bool playAnimTimeSound;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool stopAnimTimeSoundOnExit;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0EBAC", Offset = "0xA0EBAC")]
		public bool useStopTime;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0EBE4", Offset = "0xA0EBE4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0EBE4", Offset = "0xA0EBE4")]
		public float whenToStartSound;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0EC38", Offset = "0xA0EC38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0EC38", Offset = "0xA0EC38")]
		public float whenToStopSound;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SoundGroup]
		public string TimedSoundGroup;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0EC9C", Offset = "0xA0EC9C")]
		public string timedVariationName;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool playSoundStart;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool playSoundStop;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0ECD4", Offset = "0xA0ECD4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA0ECD4", Offset = "0xA0ECD4")]
		public bool playMultiAnimTimeSounds;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		public bool StopMultiAnimTimeSoundsOnExit;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0ED34", Offset = "0xA0ED34")]
		public int numOfMultiSoundsToPlay;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0ED4C", Offset = "0xA0ED4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0ED4C", Offset = "0xA0ED4C")]
		public float whenToStartMultiSound1;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0EDA0", Offset = "0xA0EDA0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0EDA0", Offset = "0xA0EDA0")]
		public float whenToStartMultiSound2;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0EDF4", Offset = "0xA0EDF4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0EDF4", Offset = "0xA0EDF4")]
		public float whenToStartMultiSound3;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0EE48", Offset = "0xA0EE48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0EE48", Offset = "0xA0EE48")]
		public float whenToStartMultiSound4;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SoundGroup]
		public string MultiSoundsTimedGroup;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA0EEAC", Offset = "0xA0EEAC")]
		public string multiTimedVariationName;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool playMultiSound1;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		private bool playMultiSound2;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
		private bool playMultiSound3;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x93")]
		private bool playMultiSound4;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Transform _actorTrans;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int _lastRepetition;

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x2352870", Offset = "0x2352870", VA = "0x2352870", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2352AF8", Offset = "0x2352AF8", VA = "0x2352AF8", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2353298", Offset = "0x2353298", VA = "0x2353298", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x23529F8", Offset = "0x23529F8", VA = "0x23529F8")]
		private Transform ActorTrans(Animator anim)
		{
			return null;
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x2352AA0", Offset = "0x2352AA0", VA = "0x2352AA0")]
		private static string GetVariationName(string varName)
		{
			return null;
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x23534E0", Offset = "0x23534E0", VA = "0x23534E0")]
		public MechanimStateSounds()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[SerializeField]
	public class PlaySoundResult
	{
		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0EEE4", Offset = "0xA0EEE4")]
		private bool <SoundPlayed>k__BackingField;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0EEF4", Offset = "0xA0EEF4")]
		private bool <SoundScheduled>k__BackingField;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0EF04", Offset = "0xA0EF04")]
		private SoundGroupVariation <ActingVariation>k__BackingField;

		[Token(Token = "0x1700000E")]
		public bool SoundPlayed
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x2355070", Offset = "0x2355070", VA = "0x2355070")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F124", Offset = "0xA0F124")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x2355078", Offset = "0x2355078", VA = "0x2355078")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F134", Offset = "0xA0F134")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public bool SoundScheduled
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x2355084", Offset = "0x2355084", VA = "0x2355084")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F144", Offset = "0xA0F144")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x235508C", Offset = "0x235508C", VA = "0x235508C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F154", Offset = "0xA0F154")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public SoundGroupVariation ActingVariation
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x2355098", Offset = "0x2355098", VA = "0x2355098")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F164", Offset = "0xA0F164")]
			get
			{
				return null;
			}
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x23550A0", Offset = "0x23550A0", VA = "0x23550A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F174", Offset = "0xA0F174")]
			set
			{
			}
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x235503C", Offset = "0x235503C", VA = "0x235503C")]
		public PlaySoundResult()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005A")]
	public class AmbientSoundToTriggerInfo
	{
		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int frameToTrigger;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AmbientSound ambient;

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x19AB9C8", Offset = "0x19AB9C8", VA = "0x19AB9C8")]
		public AmbientSoundToTriggerInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005B")]
	public class AudioEvent
	{
		[Token(Token = "0x20000A0")]
		public enum TargetVolumeMode
		{
			[Token(Token = "0x4000537")]
			UseSliderValue,
			[Token(Token = "0x4000538")]
			UseSpecificValue
		}

		[Serializable]
		[Token(Token = "0x20000A1")]
		public class MA_SnapshotInfo
		{
			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixerSnapshot snapshot;

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float weight;

			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x2440614", Offset = "0x2440614", VA = "0x2440614")]
			public MA_SnapshotInfo(AudioMixerSnapshot snap, float wt)
			{
			}
		}

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string actionName;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isExpanded;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string soundType;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool allPlaylistControllersForGroupCmd;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool allSoundTypesForGroupCmd;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool allSoundTypesForBusCmd;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float volume;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useFixedPitch;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float pitch;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public EventSounds.GlidePitchType glidePitchType;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float targetGlidePitch;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pitchGlideTime;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float delaySound;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MasterAudio.EventSoundFunctionType currentSoundFunctionType;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public MasterAudio.PlaylistCommand currentPlaylistCommand;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MasterAudio.SoundGroupCommand currentSoundGroupCommand;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public MasterAudio.BusCommand currentBusCommand;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MasterAudio.CustomEventCommand currentCustomEventCommand;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public MasterAudio.GlobalCommand currentGlobalCommand;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public MasterAudio.UnityMixerCommand currentMixerCommand;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioMixerSnapshot snapshotToTransitionTo;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float snapshotTransitionTime;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<MA_SnapshotInfo> snapshotsToBlend;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public MasterAudio.PersistentSettingsCommand currentPersistentSettingsCommand;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string busName;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string playlistName;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string playlistControllerName;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool startPlaylist;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float fadeVolume;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float fadeTime;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float minAge;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool stopAfterFade;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool restoreVolumeAfterFade;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetVolumeMode targetVolMode;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public string clipName;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public string variationName;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float colliderMaxDistance;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public bool showSphereGizmo;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public string theCustomEventName;

		[Token(Token = "0x17000011")]
		public bool IsFadeCommand
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x19ACD9C", Offset = "0x19ACD9C", VA = "0x19ACD9C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x19ACE04", Offset = "0x19ACE04", VA = "0x19ACE04")]
		public AudioEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005C")]
	public class AudioEventGroup
	{
		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isExpanded;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool allPlayersShouldHear;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool useLayerFilter;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		public bool useTagFilter;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> matchingLayers;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> matchingTags;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool customSoundActive;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool isCustomEvent;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string customEventName;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool mechanimEventActive;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool isMechanimStateCheckEvent;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mechanimStateName;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool mechEventPlayedForState;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<AudioEvent> SoundEvents;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public EventSounds.PreviousSoundStopMode mouseDragStopMode;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float mouseDragFadeOutTime;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public EventSounds.RetriggerLimMode retriggerLimitMode;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int limitPerXFrm;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float limitPerXSec;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int triggeredLastFrame;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float triggeredLastTime;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float triggerStayForTime;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool doesTriggerStayRepeat;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float sliderValue;

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x19AD010", Offset = "0x19AD010", VA = "0x19AD010")]
		public AudioEventGroup()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class AudioScriptOrder : Attribute
	{
		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Order;

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x19AF3C4", Offset = "0x19AF3C4", VA = "0x19AF3C4")]
		public AudioScriptOrder(int order)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005E")]
	public class BusFadeInfo
	{
		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string NameOfBus;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GroupBus ActingBus;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartVolume;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TargetVolume;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float StartTime;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float CompletionTime;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool IsActive;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool WillStopGroupAfterFade;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool WillResetVolumeAfterFade;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action completionAction;

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x19B23B0", Offset = "0x19B23B0", VA = "0x19B23B0")]
		public BusFadeInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005F")]
	public class BusPitchGlideInfo
	{
		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string NameOfBus;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float CompletionTime;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool IsActive;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<SoundGroupVariation> GlidingVariations;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action completionAction;

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x19B23C0", Offset = "0x19B23C0", VA = "0x19B23C0")]
		public BusPitchGlideInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000060")]
	public class CustomEvent
	{
		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string EventName;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string ProspectiveName;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool IsEditing;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool eventExpanded;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public MasterAudio.CustomEventReceiveMode eventReceiveMode;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float distanceThreshold;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public MasterAudio.EventReceiveFilter eventRcvFilterMode;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int filterModeQty;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool isTemporary;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int frameLastFired;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string categoryName;

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x19B2EF8", Offset = "0x19B2EF8", VA = "0x19B2EF8")]
		public CustomEvent(string eventName)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000061")]
	public class CustomEventCategory
	{
		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string CatName;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsExpanded;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool IsEditing;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool IsTemporary;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ProspectiveName;

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x19B2F9C", Offset = "0x19B2F9C", VA = "0x19B2F9C")]
		public CustomEventCategory()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000062")]
	public class CustomEventToFireInfo
	{
		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string eventName;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform eventOrigin;

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x19B3010", Offset = "0x19B3010", VA = "0x19B3010")]
		public CustomEventToFireInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000063")]
	public class DuckGroupInfo
	{
		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string soundType;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float riseVolStart;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float unduckTime;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float duckedVolumeCut;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isTemporary;

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x19B32AC", Offset = "0x19B32AC", VA = "0x19B32AC")]
		public DuckGroupInfo()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class DynamicGroupVariation : MonoBehaviour
	{
		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0EF14", Offset = "0xA0EF14")]
		public int probabilityToPlay;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0EF2C", Offset = "0xA0EF2C")]
		public int importance;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isUninterruptible;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool useLocalization;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool useRandomPitch;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public SoundGroupVariation.RandomPitchMode randomPitchMode;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float randomPitchMin;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float randomPitchMax;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useRandomVolume;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public SoundGroupVariation.RandomVolumeMode randomVolumeMode;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float randomVolumeMin;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float randomVolumeMax;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int weight;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string resourceFileName;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool isExpanded;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool isChecked;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		public bool useFades;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float fadeInTime;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float fadeOutTime;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool useCustomLooping;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int minCustomLoops;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxCustomLoops;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useIntroSilence;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float introSilenceMin;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float introSilenceMax;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool useRandomStartTime;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float randomStartMinPercent;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float randomStartMaxPercent;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float randomEndPercent;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AudioDistortionFilter _distFilter;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AudioEchoFilter _echoFilter;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AudioHighPassFilter _hpFilter;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AudioLowPassFilter _lpFilter;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private AudioReverbFilter _reverbFilter;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AudioChorusFilter _chorusFilter;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private DynamicSoundGroup _parentGroupScript;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Transform _trans;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private AudioSource _aud;

		[Token(Token = "0x17000012")]
		public AudioDistortionFilter DistortionFilter
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x19B331C", Offset = "0x19B331C", VA = "0x19B331C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		public AudioReverbFilter ReverbFilter
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x19B33D0", Offset = "0x19B33D0", VA = "0x19B33D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		public AudioChorusFilter ChorusFilter
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x19B3484", Offset = "0x19B3484", VA = "0x19B3484")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public AudioEchoFilter EchoFilter
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x19B3538", Offset = "0x19B3538", VA = "0x19B3538")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public AudioLowPassFilter LowPassFilter
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x19B35EC", Offset = "0x19B35EC", VA = "0x19B35EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public AudioHighPassFilter HighPassFilter
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x19B36A0", Offset = "0x19B36A0", VA = "0x19B36A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		public DynamicSoundGroup ParentGroup
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x19B3754", Offset = "0x19B3754", VA = "0x19B3754")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public Transform Trans
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x19B38DC", Offset = "0x19B38DC", VA = "0x19B38DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public bool HasActiveFXFilter
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x19B397C", Offset = "0x19B397C", VA = "0x19B397C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001B")]
		public AudioSource VarAudio
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x19B3BD0", Offset = "0x19B3BD0", VA = "0x19B3BD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x19B3C84", Offset = "0x19B3C84", VA = "0x19B3C84")]
		public DynamicGroupVariation()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class DynamicSoundGroup : MonoBehaviour
	{
		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject variationTemplate;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool alwaysHighestPriority;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float groupMasterVolume;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int retriggerPercentage;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public MasterAudioGroup.VariationSequence curVariationSequence;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useNoRepeatRefill;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool useInactivePeriodPoolRefill;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float inactivePeriodSeconds;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MasterAudioGroup.VariationMode curVariationMode;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float chainLoopDelayMin;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float chainLoopDelayMax;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MasterAudioGroup.ChainedLoopLoopMode chainLoopMode;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int chainLoopNumLoops;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool useDialogFadeOut;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float dialogFadeOutTime;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string comments;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool logSound;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool soundPlayedEventActive;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string soundPlayedCustomEvent;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int busIndex;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0EF44", Offset = "0xA0EF44")]
		public int importance;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool isUninterruptible;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float spatialBlend;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public MasterAudio.DefaultGroupPlayType groupPlayType;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string busName;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool isExistingBus;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		public bool isCopiedFromDGSC;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public MasterAudioGroup.LimitMode limitMode;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int limitPerXFrames;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float minimumTimeBetween;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool limitPolyphony;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public int voiceLimitCount;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public MasterAudioGroup.TargetDespawnedBehavior targetDespawnedBehavior;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float despawnFadeTime;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool isUsingOcclusion;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool willOcclusionOverrideRaycastOffset;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public bool willOcclusionOverrideFrequencies;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public bool copySettingsExpanded;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC5")]
		public bool expandLinkedGroups;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public List<string> childSoundGroups;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public List<string> endLinkedGroups;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public MasterAudio.LinkedGroupSelectionType linkedStartGroupSelectionType;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public MasterAudio.LinkedGroupSelectionType linkedStopGroupSelectionType;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public List<DynamicGroupVariation> groupVariations;

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x19B3CC0", Offset = "0x19B3CC0", VA = "0x19B3CC0")]
		public DynamicSoundGroup()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000066")]
	public class FootstepGroup
	{
		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isExpanded;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool useLayerFilter;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool useTagFilter;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> matchingLayers;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> matchingTags;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string soundType;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string variationName;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float volume;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useFixedPitch;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float pitch;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float delaySound;

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x19CA2EC", Offset = "0x19CA2EC", VA = "0x19CA2EC")]
		public FootstepGroup()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000067")]
	public class GroupBus
	{
		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string busName;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float volume;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool isSoloed;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool isMuted;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int voiceLimit;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isExisting;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isTemporary;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool isUsingOcclusion;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MasterAudio.BusVoiceLimitExceededMode busVoiceLimitExceededMode;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color busColor;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioMixerGroup mixerChannel;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool forceTo2D;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly List<int> _activeAudioSourcesIds;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float _originalVolume;

		[Token(Token = "0x1700001C")]
		public int ActiveVoices
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x19CAB2C", Offset = "0x19CAB2C", VA = "0x19CAB2C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001D")]
		public bool BusVoiceLimitReached
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x19CAB78", Offset = "0x19CAB78", VA = "0x19CAB78")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001E")]
		public float OriginalVolume
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x19CABE0", Offset = "0x19CABE0", VA = "0x19CABE0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x19CABE8", Offset = "0x19CABE8", VA = "0x19CABE8")]
			set
			{
			}
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x19CAA28", Offset = "0x19CAA28", VA = "0x19CAA28")]
		public void AddActiveAudioSourceId(int id)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x19CAAC8", Offset = "0x19CAAC8", VA = "0x19CAAC8")]
		public void RemoveActiveAudioSourceId(int id)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x19CABF0", Offset = "0x19CABF0", VA = "0x19CABF0")]
		public GroupBus()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000068")]
	public class GroupFadeInfo
	{
		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MasterAudioGroup ActingGroup;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string NameOfGroup;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartVolume;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TargetVolume;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float StartTime;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float CompletionTime;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool IsActive;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool WillStopGroupAfterFade;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool WillResetVolumeAfterFade;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action completionAction;

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x19CACA4", Offset = "0x19CACA4", VA = "0x19CACA4")]
		public GroupFadeInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000069")]
	public class GroupPitchGlideInfo
	{
		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MasterAudioGroup ActingGroup;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string NameOfGroup;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CompletionTime;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool IsActive;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<SoundGroupVariation> GlidingVariations;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action completionAction;

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x19CACB4", Offset = "0x19CACB4", VA = "0x19CACB4")]
		public GroupPitchGlideInfo()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public interface ICustomEventReceiver
	{
		[Token(Token = "0x600018D")]
		void CheckForIllegalCustomEvents();

		[Token(Token = "0x600018E")]
		void ReceiveEvent(string customEventName, Vector3 originPoint);

		[Token(Token = "0x600018F")]
		bool SubscribesToEvent(string customEventName);

		[Token(Token = "0x6000190")]
		void RegisterReceiver();

		[Token(Token = "0x6000191")]
		void UnregisterReceiver();

		[Token(Token = "0x6000192")]
		IList<AudioEventGroup> GetAllEvents();
	}
	[Token(Token = "0x200006B")]
	public class MasterAudioGroup : MonoBehaviour
	{
		[Token(Token = "0x20000A2")]
		public enum TargetDespawnedBehavior
		{
			[Token(Token = "0x400053C")]
			None,
			[Token(Token = "0x400053D")]
			Stop,
			[Token(Token = "0x400053E")]
			FadeOut
		}

		[Token(Token = "0x20000A3")]
		public enum VariationSequence
		{
			[Token(Token = "0x4000540")]
			Randomized,
			[Token(Token = "0x4000541")]
			TopToBottom
		}

		[Token(Token = "0x20000A4")]
		public enum VariationMode
		{
			[Token(Token = "0x4000543")]
			Normal,
			[Token(Token = "0x4000544")]
			LoopedChain,
			[Token(Token = "0x4000545")]
			Dialog
		}

		[Token(Token = "0x20000A5")]
		public enum ChainedLoopLoopMode
		{
			[Token(Token = "0x4000547")]
			Endless,
			[Token(Token = "0x4000548")]
			NumberOfLoops
		}

		[Token(Token = "0x20000A6")]
		public enum LimitMode
		{
			[Token(Token = "0x400054A")]
			None,
			[Token(Token = "0x400054B")]
			FrameBased,
			[Token(Token = "0x400054C")]
			TimeBased
		}

		[Token(Token = "0x4000270")]
		public const float UseCurveSpatialBlend = -99f;

		[Token(Token = "0x4000271")]
		public const string NoBus = "[NO BUS]";

		[Token(Token = "0x4000272")]
		public const int MinNoRepeatVariations = 3;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int busIndex;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float spatialBlend;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public MasterAudio.DefaultGroupPlayType groupPlayType;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isSelected;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool isExpanded;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float groupMasterVolume;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int retriggerPercentage;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public VariationMode curVariationMode;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool alwaysHighestPriority;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0EF5C", Offset = "0xA0EF5C")]
		public int importance;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool isUninterruptible;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float chainLoopDelayMin;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float chainLoopDelayMax;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public ChainedLoopLoopMode chainLoopMode;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int chainLoopNumLoops;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool useDialogFadeOut;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float dialogFadeOutTime;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public VariationSequence curVariationSequence;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool useNoRepeatRefill;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool useInactivePeriodPoolRefill;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float inactivePeriodSeconds;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<SoundGroupVariation> groupVariations;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public string comments;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool logSound;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		public bool copySettingsExpanded;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
		public bool expandLinkedGroups;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<string> childSoundGroups;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<string> endLinkedGroups;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public MasterAudio.LinkedGroupSelectionType linkedStartGroupSelectionType;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public MasterAudio.LinkedGroupSelectionType linkedStopGroupSelectionType;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public LimitMode limitMode;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public int limitPerXFrames;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float minimumTimeBetween;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public bool useClipAgePriority;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		public bool limitPolyphony;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public int voiceLimitCount;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetDespawnedBehavior targetDespawnedBehavior;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float despawnFadeTime;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool isUsingOcclusion;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public bool willOcclusionOverrideRaycastOffset;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public bool willOcclusionOverrideFrequencies;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public bool isSoloed;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
		public bool isMuted;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD2")]
		public bool soundPlayedEventActive;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public string soundPlayedCustomEvent;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public bool willCleanUpDelegatesAfterStop;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public int frames;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private List<int> _activeAudioSourcesIds;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private string _objectName;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Transform _trans;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float _originalVolume;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0EF84", Offset = "0xA0EF84")]
		private int <ChainLoopCount>k__BackingField;

		[Token(Token = "0x1700001F")]
		public float SpatialBlendForGroup
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x234B070", Offset = "0x234B070", VA = "0x234B070")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000020")]
		public int ActiveVoices
		{
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x234B15C", Offset = "0x234B15C", VA = "0x234B15C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000021")]
		public int TotalVoices
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x234B1AC", Offset = "0x234B1AC", VA = "0x234B1AC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000022")]
		public bool WillCleanUpDelegatesAfterStop
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x234B1D0", Offset = "0x234B1D0", VA = "0x234B1D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public GroupBus BusForGroup
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x234AEF4", Offset = "0x234AEF4", VA = "0x234AEF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		public float OriginalVolume
		{
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x234B1DC", Offset = "0x234B1DC", VA = "0x234B1DC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x234B1E4", Offset = "0x234B1E4", VA = "0x234B1E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public bool LoggingEnabledForGroup
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x234B1EC", Offset = "0x234B1EC", VA = "0x234B1EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000026")]
		public int ChainLoopCount
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x234B2B8", Offset = "0x234B2B8", VA = "0x234B2B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F1A4", Offset = "0xA0F1A4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x234B2C0", Offset = "0x234B2C0", VA = "0x234B2C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F1B4", Offset = "0xA0F1B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public string GameObjectName
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x234B2C8", Offset = "0x234B2C8", VA = "0x234B2C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		public MasterAudio.GroupPlayType GroupPlayType
		{
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x234B318", Offset = "0x234B318", VA = "0x234B318")]
			get
			{
				return default(MasterAudio.GroupPlayType);
			}
		}

		[Token(Token = "0x17000029")]
		public bool UsesNoRepeat
		{
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x234B464", Offset = "0x234B464", VA = "0x234B464")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002A")]
		private Transform Trans
		{
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x234AD94", Offset = "0x234AD94", VA = "0x234AD94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		private List<int> ActiveAudioSourceIds
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x234ACDC", Offset = "0x234ACDC", VA = "0x234ACDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000001")]
		public event Action LastVariationFinishedPlay
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x234AA80", Offset = "0x234AA80", VA = "0x234AA80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F184", Offset = "0xA0F184")]
			add
			{
			}
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x234AB20", Offset = "0x234AB20", VA = "0x234AB20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F194", Offset = "0xA0F194")]
			remove
			{
			}
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x234ABC0", Offset = "0x234ABC0", VA = "0x234ABC0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x234AE34", Offset = "0x234AE34", VA = "0x234AE34")]
		public void AddActiveAudioSourceId(int varInstanceId)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x234AFE0", Offset = "0x234AFE0", VA = "0x234AFE0")]
		public void RemoveActiveAudioSourceId(int varInstanceId)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x234B264", Offset = "0x234B264", VA = "0x234B264")]
		public void FireLastVariationFinishedPlay()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x234B278", Offset = "0x234B278", VA = "0x234B278")]
		public void SubscribeToLastVariationFinishedPlay(Action finishedCallback)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x234B2AC", Offset = "0x234B2AC", VA = "0x234B2AC")]
		public void UnsubscribeFromLastVariationFinishedPlay()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x234B4D4", Offset = "0x234B4D4", VA = "0x234B4D4")]
		public MasterAudioGroup()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class MasterCustomEventAttribute : PropertyAttribute
	{
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x235223C", Offset = "0x235223C", VA = "0x235223C")]
		public MasterCustomEventAttribute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006D")]
	public class MusicSetting
	{
		[Token(Token = "0x20000A7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C020", Offset = "0xA0C020")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataStringValue valToClone;

			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x2442E74", Offset = "0x2442E74", VA = "0x2442E74")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x2442E7C", Offset = "0x2442E7C", VA = "0x2442E7C")]
			internal bool <Clone>b__0(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C030", Offset = "0xA0C030")]
		private sealed class <>c__DisplayClass32_1
		{
			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataFloatValue valToClone;

			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x2442EA8", Offset = "0x2442EA8", VA = "0x2442EA8")]
			public <>c__DisplayClass32_1()
			{
			}

			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x2442EB0", Offset = "0x2442EB0", VA = "0x2442EB0")]
			internal bool <Clone>b__1(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000A9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C040", Offset = "0xA0C040")]
		private sealed class <>c__DisplayClass32_2
		{
			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataBoolValue valToClone;

			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x2442EDC", Offset = "0x2442EDC", VA = "0x2442EDC")]
			public <>c__DisplayClass32_2()
			{
			}

			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x2442EE4", Offset = "0x2442EE4", VA = "0x2442EE4")]
			internal bool <Clone>b__2(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000AA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C050", Offset = "0xA0C050")]
		private sealed class <>c__DisplayClass32_3
		{
			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataIntValue valToClone;

			[Token(Token = "0x60004C4")]
			[Address(RVA = "0x2442F10", Offset = "0x2442F10", VA = "0x2442F10")]
			public <>c__DisplayClass32_3()
			{
			}

			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x2442F18", Offset = "0x2442F18", VA = "0x2442F18")]
			internal bool <Clone>b__3(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string alias;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip clip;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string songName;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string resourceFileName;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float volume;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float pitch;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool isExpanded;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool isLoop;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		public bool isChecked;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<SongMetadataStringValue> metadataStringValues;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<SongMetadataBoolValue> metadataBoolValues;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<SongMetadataIntValue> metadataIntValues;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SongMetadataFloatValue> metadataFloatValues;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool metadataExpanded;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public MasterAudio.CustomSongStartTimeMode songStartTimeMode;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float customStartTime;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float customStartTimeMax;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int lastKnownTimePoint;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool wasLastKnownTimePointSet;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int songIndex;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool songStartedEventExpanded;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string songStartedCustomEvent;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool songChangedEventExpanded;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string songChangedCustomEvent;

		[Token(Token = "0x1700002C")]
		public bool HasMetadataProperties
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x23537A0", Offset = "0x23537A0", VA = "0x23537A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002D")]
		public int MetadataPropertyCount
		{
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x23537BC", Offset = "0x23537BC", VA = "0x23537BC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002E")]
		public float SongStartTime
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x235385C", Offset = "0x235385C", VA = "0x235385C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x2353584", Offset = "0x2353584", VA = "0x2353584")]
		public MusicSetting()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2353888", Offset = "0x2353888", VA = "0x2353888")]
		public static MusicSetting Clone(MusicSetting mus, MasterAudio.Playlist aList)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200006E")]
	public class OcclusionFreqChangeInfo
	{
		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SoundGroupVariation ActingVariation;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float StartFrequency;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float TargetFrequency;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartTime;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float CompletionTime;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsActive;

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2353F9C", Offset = "0x2353F9C", VA = "0x2353F9C")]
		public OcclusionFreqChangeInfo()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class PlaylistAttribute : PropertyAttribute
	{
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x23550A8", Offset = "0x23550A8", VA = "0x23550A8")]
		public PlaylistAttribute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000070")]
	public class SongMetadataBoolValue
	{
		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Value;

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x2436998", Offset = "0x2436998", VA = "0x2436998")]
		public SongMetadataBoolValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000071")]
	public class SongMetadataFloatValue
	{
		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Value;

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x24369DC", Offset = "0x24369DC", VA = "0x24369DC")]
		public SongMetadataFloatValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000072")]
	public class SongMetadataIntValue
	{
		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Value;

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x2436A20", Offset = "0x2436A20", VA = "0x2436A20")]
		public SongMetadataIntValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000073")]
	public class SongMetadataProperty
	{
		[Token(Token = "0x20000AB")]
		public enum MetadataPropertyType
		{
			[Token(Token = "0x4000552")]
			Boolean,
			[Token(Token = "0x4000553")]
			String,
			[Token(Token = "0x4000554")]
			Integer,
			[Token(Token = "0x4000555")]
			Float
		}

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MetadataPropertyType PropertyType;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string PropertyName;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ProspectiveName;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsEditing;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool PropertyExpanded;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool AllSongsMustContain;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		public bool CanSongHaveMultiple;

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2436A64", Offset = "0x2436A64", VA = "0x2436A64")]
		public SongMetadataProperty(string propertyName, MetadataPropertyType propertyType, bool allSongsMustContain, bool canSongHaveMultiple)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000074")]
	public class SongMetadataStringValue
	{
		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Value;

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2436AE4", Offset = "0x2436AE4", VA = "0x2436AE4")]
		public SongMetadataStringValue(SongMetadataProperty prop)
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class SoundGroupAttribute : PropertyAttribute
	{
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2436B28", Offset = "0x2436B28", VA = "0x2436B28")]
		public SoundGroupAttribute()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0xA0BEAC", Offset = "0xA0BEAC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA0BEAC", Offset = "0xA0BEAC")]
	public class SoundGroupVariation : MonoBehaviour
	{
		[Token(Token = "0x20000AC")]
		public delegate void SoundFinishedEventHandler();

		[Token(Token = "0x20000AD")]
		public delegate void SoundLoopedEventHandler(int loopNumberStarted);

		[Token(Token = "0x20000AE")]
		public class PlaySoundParams
		{
			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string SoundType;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float VolumePercentage;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float? Pitch;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public double? TimeToSchedulePlay;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform SourceTrans;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool AttachToSource;

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float DelaySoundTime;

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public bool IsChainLoop;

			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
			public bool IsSingleSubscribedPlay;

			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float GroupCalcVolume;

			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public bool IsPlaying;

			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x243C6F8", Offset = "0x243C6F8", VA = "0x243C6F8")]
			public PlaySoundParams(string soundType, float volPercent, float groupCalcVolume, float? pitch, Transform sourceTrans, bool attach, float delaySoundTime, double? timeToSchedulePlay, bool isChainLoop, bool isSingleSubscribedPlay)
			{
			}
		}

		[Token(Token = "0x20000AF")]
		public enum PitchMode
		{
			[Token(Token = "0x4000562")]
			None,
			[Token(Token = "0x4000563")]
			Gliding
		}

		[Token(Token = "0x20000B0")]
		public enum FadeMode
		{
			[Token(Token = "0x4000565")]
			None,
			[Token(Token = "0x4000566")]
			FadeInOut,
			[Token(Token = "0x4000567")]
			FadeOutEarly,
			[Token(Token = "0x4000568")]
			GradualFade
		}

		[Token(Token = "0x20000B1")]
		public enum RandomPitchMode
		{
			[Token(Token = "0x400056A")]
			AddToClipPitch,
			[Token(Token = "0x400056B")]
			IgnoreClipPitch
		}

		[Token(Token = "0x20000B2")]
		public enum RandomVolumeMode
		{
			[Token(Token = "0x400056D")]
			AddToClipVolume,
			[Token(Token = "0x400056E")]
			IgnoreClipVolume
		}

		[Token(Token = "0x20000B3")]
		public enum DetectEndMode
		{
			[Token(Token = "0x4000570")]
			None,
			[Token(Token = "0x4000571")]
			DetectEnd
		}

		[Token(Token = "0x20000B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C060", Offset = "0xA0C060")]
		private sealed class <WaitForLoadToUnloadClipAndDeactivate>d__110 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoundGroupVariation <>4__this;

			[Token(Token = "0x170000BB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004D2")]
				[Address(RVA = "0x2444054", Offset = "0x2444054", VA = "0x2444054", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004D4")]
				[Address(RVA = "0x244409C", Offset = "0x244409C", VA = "0x244409C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x243AFA0", Offset = "0x243AFA0", VA = "0x243AFA0")]
			[DebuggerHidden]
			public <WaitForLoadToUnloadClipAndDeactivate>d__110(int <>1__state)
			{
			}

			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x2443F7C", Offset = "0x2443F7C", VA = "0x2443F7C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x2443F80", Offset = "0x2443F80", VA = "0x2443F80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x244405C", Offset = "0x244405C", VA = "0x244405C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int weight;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0EF94", Offset = "0xA0EF94")]
		public int probabilityToPlay;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA0EFAC", Offset = "0xA0EFAC")]
		public int importance;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isUninterruptible;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool useLocalization;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool useRandomPitch;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RandomPitchMode randomPitchMode;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float randomPitchMin;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float randomPitchMax;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool useRandomVolume;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RandomVolumeMode randomVolumeMode;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float randomVolumeMin;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float randomVolumeMax;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string resourceFileName;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float original_pitch;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float original_volume;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool isExpanded;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool isChecked;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public bool useFades;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float fadeInTime;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float fadeOutTime;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool useCustomLooping;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int minCustomLoops;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int maxCustomLoops;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool useRandomStartTime;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float randomStartMinPercent;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float randomStartMaxPercent;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float randomEndPercent;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool useIntroSilence;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float introSilenceMin;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float introSilenceMax;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float fadeMaxVolume;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public FadeMode curFadeMode;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public PitchMode curPitchMode;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public DetectEndMode curDetectEndMode;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int frames;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AudioSource _audioSource;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly PlaySoundParams _playSndParam;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AudioDistortionFilter _distFilter;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AudioEchoFilter _echoFilter;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioHighPassFilter _hpFilter;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private AudioLowPassFilter _lpFilter;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private AudioReverbFilter _reverbFilter;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private AudioChorusFilter _chorusFilter;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float _maxVol;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private int _instanceId;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool? _audioLoops;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private int _maxLoops;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private SoundGroupVariationUpdater _varUpdater;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int _previousSoundFinishedFrame;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private string _soundGroupName;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private MasterAudio.VariationLoadStatus _loadStatus;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool _isStopRequested;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10D")]
		private bool _isPaused;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10E")]
		private bool _isWarmingPlay;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Transform _trans;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private GameObject _go;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Transform _objectToFollow;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Transform _objectToTriggerFrom;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private MasterAudioGroup _parentGroupScript;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private bool _attachToSource;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private string _resFileName;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private bool _hasStartedEndLinkedGroups;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Coroutine _loadResourceFileCoroutine;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Coroutine _loadAddressableCoroutine;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private bool _isUnloadAddressableCoroutineRunning;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0EFE4", Offset = "0xA0EFE4")]
		private float <LastTimePlayed>k__BackingField;

		[Token(Token = "0x1700002F")]
		public AudioDistortionFilter DistortionFilter
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x243B9E8", Offset = "0x243B9E8", VA = "0x243B9E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public AudioReverbFilter ReverbFilter
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x243BA9C", Offset = "0x243BA9C", VA = "0x243BA9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public AudioChorusFilter ChorusFilter
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x243BB50", Offset = "0x243BB50", VA = "0x243BB50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public AudioEchoFilter EchoFilter
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x243BC04", Offset = "0x243BC04", VA = "0x243BC04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public AudioLowPassFilter LowPassFilter
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x243BCB8", Offset = "0x243BCB8", VA = "0x243BCB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x243BCC0", Offset = "0x243BCC0", VA = "0x243BCC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public AudioHighPassFilter HighPassFilter
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x243BCC8", Offset = "0x243BCC8", VA = "0x243BCC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public Transform ObjectToFollow
		{
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x243BD7C", Offset = "0x243BD7C", VA = "0x243BD7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x243BD84", Offset = "0x243BD84", VA = "0x243BD84")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public Transform ObjectToTriggerFrom
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x243BEF8", Offset = "0x243BEF8", VA = "0x243BEF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x243BF00", Offset = "0x243BF00", VA = "0x243BF00")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public bool HasActiveFXFilter
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x243BF30", Offset = "0x243BF30", VA = "0x243BF30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000038")]
		public MasterAudioGroup ParentGroup
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x2437AA8", Offset = "0x2437AA8", VA = "0x2437AA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public float OriginalPitch
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x2438F10", Offset = "0x2438F10", VA = "0x2438F10")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003A")]
		public float OriginalVolume
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x243C174", Offset = "0x243C174", VA = "0x243C174")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003B")]
		public string SoundGroupName
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x243C1B4", Offset = "0x243C1B4", VA = "0x243C1B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public bool IsAvailableToPlay
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x243C208", Offset = "0x243C208", VA = "0x243C208")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003D")]
		public float LastTimePlayed
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x243C2B0", Offset = "0x243C2B0", VA = "0x243C2B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F264", Offset = "0xA0F264")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x243C2B8", Offset = "0x243C2B8", VA = "0x243C2B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F274", Offset = "0xA0F274")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public bool ClipIsLoaded
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x243C2C0", Offset = "0x243C2C0", VA = "0x243C2C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003F")]
		public bool IsPlaying
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x2439F64", Offset = "0x2439F64", VA = "0x2439F64")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000040")]
		public MasterAudio.VariationLoadStatus LoadStatus
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x243C2D0", Offset = "0x243C2D0", VA = "0x243C2D0")]
			get
			{
				return default(MasterAudio.VariationLoadStatus);
			}
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x2438D70", Offset = "0x2438D70", VA = "0x2438D70")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public int InstanceId
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x2439678", Offset = "0x2439678", VA = "0x2439678")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000042")]
		public bool IsStopRequested
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x243C2D8", Offset = "0x243C2D8", VA = "0x243C2D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000043")]
		public Transform Trans
		{
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x243AB70", Offset = "0x243AB70", VA = "0x243AB70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public GameObject GameObj
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x243736C", Offset = "0x243736C", VA = "0x243736C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public AudioSource VarAudio
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x24372B8", Offset = "0x24372B8", VA = "0x24372B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public bool AudioLoops
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x24395BC", Offset = "0x24395BC", VA = "0x24395BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		public string ResFileName
		{
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x2439284", Offset = "0x2439284", VA = "0x2439284")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public SoundGroupVariationUpdater VariationUpdater
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x2438138", Offset = "0x2438138", VA = "0x2438138")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public PlaySoundParams PlaySoundParm
		{
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x243C2E0", Offset = "0x243C2E0", VA = "0x243C2E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public float SetGroupVolume
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x243C2E8", Offset = "0x243C2E8", VA = "0x243C2E8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x243C304", Offset = "0x243C304", VA = "0x243C304")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public int MaxLoops
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x243C320", Offset = "0x243C320", VA = "0x243C320")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004C")]
		private bool Is2D
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x243C328", Offset = "0x243C328", VA = "0x243C328")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004D")]
		public bool UsesOcclusion
		{
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x2438310", Offset = "0x2438310", VA = "0x2438310")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004E")]
		public bool IsPaused
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x243C354", Offset = "0x243C354", VA = "0x243C354")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000002")]
		public event SoundFinishedEventHandler SoundFinished
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x2436E3C", Offset = "0x2436E3C", VA = "0x2436E3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F1C4", Offset = "0xA0F1C4")]
			add
			{
			}
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x2436EE0", Offset = "0x2436EE0", VA = "0x2436EE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F1D4", Offset = "0xA0F1D4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event SoundLoopedEventHandler SoundLooped
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x2436F84", Offset = "0x2436F84", VA = "0x2436F84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F1E4", Offset = "0xA0F1E4")]
			add
			{
			}
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x2437028", Offset = "0x2437028", VA = "0x2437028")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F1F4", Offset = "0xA0F1F4")]
			remove
			{
			}
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x24370CC", Offset = "0x24370CC", VA = "0x24370CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x243740C", Offset = "0x243740C", VA = "0x243740C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x2437C80", Offset = "0x2437C80", VA = "0x2437C80")]
		public void SetMixerGroup()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x2437CD8", Offset = "0x2437CD8", VA = "0x2437CD8")]
		public void SetSpatialBlend()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x2437E88", Offset = "0x2437E88", VA = "0x2437E88")]
		private void SetOcclusion()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x2437DDC", Offset = "0x2437DDC", VA = "0x2437DDC")]
		private void SetPriority()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x2438510", Offset = "0x2438510", VA = "0x2438510")]
		public void DisableUpdater()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x24385B4", Offset = "0x24385B4", VA = "0x24385B4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x2438680", Offset = "0x2438680", VA = "0x2438680")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x24385B8", Offset = "0x24385B8", VA = "0x24385B8")]
		private void StopSoundEarly()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x2438A20", Offset = "0x2438A20", VA = "0x2438A20")]
		public void Play(float? pitch, float maxVolume, string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, double? timeToSchedulePlay, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x2438DDC", Offset = "0x2438DDC", VA = "0x2438DDC")]
		public void SetPlaySoundParams(string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, double? timeToSchedulePlay, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x2438D84", Offset = "0x2438D84", VA = "0x2438D84")]
		private void MaybeCleanupFinishedDelegate()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x2439364", Offset = "0x2439364", VA = "0x2439364")]
		private void ResourceFailedToLoad()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x2438F50", Offset = "0x2438F50", VA = "0x2438F50")]
		private void FinishSetupToPlay()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x243978C", Offset = "0x243978C", VA = "0x243978C")]
		public void JumpToTime(float timeToJumpTo)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x24397D8", Offset = "0x24397D8", VA = "0x24397D8")]
		public void GlideByPitch(float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x2439AD4", Offset = "0x2439AD4", VA = "0x2439AD4")]
		public void AdjustVolume(float volumePercentage)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x2439C60", Offset = "0x2439C60", VA = "0x2439C60")]
		public void Pause()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x2439DE0", Offset = "0x2439DE0", VA = "0x2439DE0")]
		public void PlayVideo()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x2439E30", Offset = "0x2439E30", VA = "0x2439E30")]
		public void StopVideo()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x2439E80", Offset = "0x2439E80", VA = "0x2439E80")]
		public void Unpause()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x243A07C", Offset = "0x243A07C", VA = "0x243A07C")]
		public void DoNextChain(float volumePercentage, float? pitch, Transform transActor, bool attach)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x243A484", Offset = "0x243A484", VA = "0x243A484")]
		public void PlayEndLinkedGroups([Optional] double? timeToPlayClip)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x2439384", Offset = "0x2439384", VA = "0x2439384")]
		private void EnableUpdater(bool waitForSoundFinish = true)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x243AA3C", Offset = "0x243AA3C", VA = "0x243AA3C")]
		private void MaybeUnloadClip()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x243A720", Offset = "0x243A720", VA = "0x243A720")]
		private void PlayEndLinkedGroup(string sType, [Optional] double? timeToPlayClip)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x2438684", Offset = "0x2438684", VA = "0x2438684")]
		public void Stop(bool stopEndDetection = false, bool skipLinked = false)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x243AEE4", Offset = "0x243AEE4", VA = "0x243AEE4")]
		private void StopEndCleanup()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x243AF28", Offset = "0x243AF28", VA = "0x243AF28")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0F204", Offset = "0xA0F204")]
		private IEnumerator WaitForLoadToUnloadClipAndDeactivate()
		{
			return null;
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x243AFCC", Offset = "0x243AFCC", VA = "0x243AFCC")]
		public void FadeToVolume(float newVolume, float fadeTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x243B3F8", Offset = "0x243B3F8", VA = "0x243B3F8")]
		public void FadeOutNowAndStop([Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x243B6D8", Offset = "0x243B6D8", VA = "0x243B6D8")]
		public void FadeOutNowAndStop(float fadeTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x243B820", Offset = "0x243B820", VA = "0x243B820")]
		public bool WasTriggeredFromTransform(Transform trans)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x243B8DC", Offset = "0x243B8DC", VA = "0x243B8DC")]
		public bool WasTriggeredFromAnyOfTransformMap(HashSet<Transform> transMap)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x243BDB4", Offset = "0x243BDB4", VA = "0x243BDB4")]
		public void UpdateTransformTracker(Transform sourceTrans)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x243C35C", Offset = "0x243C35C", VA = "0x243C35C")]
		public void SoundLoopStarted(int numberOfLoops)
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x243932C", Offset = "0x243932C", VA = "0x243932C")]
		public void ClearSubscribers()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x243C598", Offset = "0x243C598", VA = "0x243C598")]
		public SoundGroupVariation()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x243C7C8", Offset = "0x243C7C8", VA = "0x243C7C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F284", Offset = "0xA0F284")]
		private bool <Start>b__82_0(VideoPlayer vid)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0xA0BF20", Offset = "0xA0BF20")]
	public class SoundGroupVariationUpdater : MonoBehaviour
	{
		[Token(Token = "0x20000B5")]
		private enum WaitForSoundFinishMode
		{
			[Token(Token = "0x4000576")]
			None,
			[Token(Token = "0x4000577")]
			Play,
			[Token(Token = "0x4000578")]
			WaitForEnd,
			[Token(Token = "0x4000579")]
			StopOrRepeat
		}

		[Token(Token = "0x4000321")]
		private const float TimeEarlyToScheduleNextClip = 0.1f;

		[Token(Token = "0x4000322")]
		private const float FakeNegativeFloatValue = -10f;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform _objectToFollow;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject _objectToFollowGo;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _isFollowing;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SoundGroupVariation _variation;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _priorityLastUpdated;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool _useClipAgePriority;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WaitForSoundFinishMode _waitMode;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AudioSource _varAudio;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MasterAudioGroup _parentGrp;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _trans;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _frameNum;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool _inited;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _fadeOutStartTime;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool _fadeInOutWillFadeOut;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		private bool _hasFadeInOutSetMaxVolume;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _fadeInOutInFactor;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float _fadeInOutOutFactor;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Action _fadeOutEarlyCompletionCallback;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _fadeOutEarlyTotalFrames;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float _fadeOutEarlyFrameVolChange;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _fadeOutEarlyFrameNumber;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float _fadeOutEarlyOrigVol;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float _fadeToTargetFrameVolChange;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int _fadeToTargetFrameNumber;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _fadeToTargetOrigVol;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Action _fadeToTargetCompletionCallback;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int _fadeToTargetTotalFrames;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private float _fadeToTargetVolume;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool _fadeOutStarted;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float _lastFrameClipTime;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool _isPlayingBackward;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int _pitchGlideToTargetTotalFrames;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float _pitchGlideToTargetFramePitchChange;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int _pitchGlideToTargetFrameNumber;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float _glideToTargetPitch;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float _glideToTargetOrigPitch;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Action _glideToPitchCompletionCallback;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool _hasStartedNextInChain;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		private bool _isWaitingForQueuedOcclusionRay;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private int _framesPlayed;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float? _clipStartPosition;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float? _clipEndPosition;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private double? _clipSchedEndTime;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool _hasScheduledNextClip;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x101")]
		private bool _hasScheduledEndLinkedGroups;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private int _lastFrameClipPosition;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int _timesLooped;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool _isPaused;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private double _pauseTime;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _maCachedFromFrame;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static MasterAudio _maThisFrame;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Transform _listenerThisFrame;

		[Token(Token = "0x1700004F")]
		public float ClipStartPosition
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x243DCC0", Offset = "0x243DCC0", VA = "0x243DCC0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000050")]
		public float ClipEndPosition
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x243C970", Offset = "0x243C970", VA = "0x243C970")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000051")]
		public int FramesPlayed
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x243E990", Offset = "0x243E990", VA = "0x243E990")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000052")]
		public MasterAudio MAThisFrame
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x243E998", Offset = "0x243E998", VA = "0x243E998")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public float MaxOcclusionFreq
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x243E9FC", Offset = "0x243E9FC", VA = "0x243E9FC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000054")]
		public float MinOcclusionFreq
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x243EAB0", Offset = "0x243EAB0", VA = "0x243EAB0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000055")]
		private Transform Trans
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x243D018", Offset = "0x243D018", VA = "0x243D018")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		private AudioSource VarAudio
		{
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x243C8C8", Offset = "0x243C8C8", VA = "0x243C8C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		private MasterAudioGroup ParentGroup
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x243D0C0", Offset = "0x243D0C0", VA = "0x243D0C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		private SoundGroupVariation GrpVariation
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x243C814", Offset = "0x243C814", VA = "0x243C814")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		private float RayCastOriginOffset
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x243DC0C", Offset = "0x243DC0C", VA = "0x243DC0C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700005A")]
		private bool IsOcclusionMeasuringPaused
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x243D374", Offset = "0x243D374", VA = "0x243D374")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		private bool HasEndLinkedGroups
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x243E928", Offset = "0x243E928", VA = "0x243E928")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x2439A24", Offset = "0x2439A24", VA = "0x2439A24")]
		public void GlidePitch(float targetPitch, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x243B270", Offset = "0x243B270", VA = "0x243B270")]
		public void FadeOverTimeToVolume(float targetVolume, float fadeTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x243B538", Offset = "0x243B538", VA = "0x243B538")]
		public void FadeOutEarly(float fadeTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x243A980", Offset = "0x243A980", VA = "0x243A980")]
		public void Initialize()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x2439490", Offset = "0x2439490", VA = "0x2439490")]
		public void FadeInOut()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x24396AC", Offset = "0x24396AC", VA = "0x24396AC")]
		public void FollowObject(bool follow, Transform objToFollow, bool clipAgePriority)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x243A9BC", Offset = "0x243A9BC", VA = "0x243A9BC")]
		public void WaitForSoundFinish()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x243AC84", Offset = "0x243AC84", VA = "0x243AC84")]
		public void StopPitchGliding()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x243AC54", Offset = "0x243AC54", VA = "0x243AC54")]
		public void StopFading()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x243A450", Offset = "0x243A450", VA = "0x243A450")]
		public void StopWaitingForFinish()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x243AC10", Offset = "0x243AC10", VA = "0x243AC10")]
		public void StopFollowing()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x243CF9C", Offset = "0x243CF9C", VA = "0x243CF9C")]
		private void DisableIfFinished()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x243CAB4", Offset = "0x243CAB4", VA = "0x243CAB4")]
		private void UpdateAudioLocationAndPriority(bool rePrioritize)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x243D168", Offset = "0x243D168", VA = "0x243D168")]
		private void ResetToNonOcclusionSetting()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x243D210", Offset = "0x243D210", VA = "0x243D210")]
		private void UpdateOcclusion()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x243D400", Offset = "0x243D400", VA = "0x243D400")]
		private void DoneWithOcclusion()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x243D478", Offset = "0x243D478", VA = "0x243D478")]
		public bool RayCastForOcclusion()
		{
			return default(bool);
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x243CC44", Offset = "0x243CC44", VA = "0x243CC44")]
		private void PlaySoundAndWait()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x243DE10", Offset = "0x243DE10", VA = "0x243DE10")]
		private void DuckIfNotSilent()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x243DF88", Offset = "0x243DF88", VA = "0x243DF88")]
		private void StopOrChain()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x2439D68", Offset = "0x2439D68", VA = "0x2439D68")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x2439F80", Offset = "0x2439F80", VA = "0x2439F80")]
		public void Unpause()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x243A130", Offset = "0x243A130", VA = "0x243A130")]
		public void MaybeChain()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x243E024", Offset = "0x243E024", VA = "0x243E024")]
		private void UpdatePitch()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x243E0E8", Offset = "0x243E0E8", VA = "0x243E0E8")]
		private void PerformFading()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x243E3CC", Offset = "0x243E3CC", VA = "0x243E3CC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x243E454", Offset = "0x243E454", VA = "0x243E454")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x24381EC", Offset = "0x24381EC", VA = "0x24381EC")]
		public void UpdateCachedObjects()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x243E53C", Offset = "0x243E53C", VA = "0x243E53C")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x243EB64", Offset = "0x243EB64", VA = "0x243EB64")]
		public SoundGroupVariationUpdater()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public static class AudioLoaderOptimizer
	{
		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, List<GameObject>> PlayingGameObjectsByClipName;

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x19AD200", Offset = "0x19AD200", VA = "0x19AD200")]
		public static void AddNonPreloadedPlayingClip(AudioClip clip, GameObject maHolderGameObject)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x19AD450", Offset = "0x19AD450", VA = "0x19AD450")]
		public static void RemoveNonPreloadedPlayingClip(AudioClip clip, GameObject maHolderGameObject)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x19AD620", Offset = "0x19AD620", VA = "0x19AD620")]
		public static bool IsAnyOfNonPreloadedClipPlaying(AudioClip clip)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000079")]
	public static class AudioPrioritizer
	{
		[Token(Token = "0x4000358")]
		private const int MaxPriority = 0;

		[Token(Token = "0x4000359")]
		private const int HighestPriority = 16;

		[Token(Token = "0x400035A")]
		private const int LowestPriority = 128;

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x19AD810", Offset = "0x19AD810", VA = "0x19AD810")]
		public static void Set2DSoundPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x19AD82C", Offset = "0x19AD82C", VA = "0x19AD82C")]
		public static void SetSoundGroupInitialPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x19AD848", Offset = "0x19AD848", VA = "0x19AD848")]
		public static void SetPreviewPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x19AD864", Offset = "0x19AD864", VA = "0x19AD864")]
		public static void Set3DPriority(SoundGroupVariation variation, bool useClipAgePriority)
		{
		}
	}
	[Token(Token = "0x200007A")]
	public static class AudioResourceOptimizer
	{
		[Token(Token = "0x20000B6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C070", Offset = "0xA0C070")]
		private sealed class <PopulateResourceSongToPlaylistControllerAsync>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string songResourceName;

			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string playlistName;

			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public PlaylistController controller;

			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public MusicSetting songSetting;

			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public PlaylistController.AudioPlayType playType;

			[Token(Token = "0x4000581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private ResourceRequest <asyncRes>5__2;

			[Token(Token = "0x170000BD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004D8")]
				[Address(RVA = "0x2440C68", Offset = "0x2440C68", VA = "0x2440C68", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004DA")]
				[Address(RVA = "0x2440CB0", Offset = "0x2440CB0", VA = "0x2440CB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x244065C", Offset = "0x244065C", VA = "0x244065C")]
			[DebuggerHidden]
			public <PopulateResourceSongToPlaylistControllerAsync>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x2440688", Offset = "0x2440688", VA = "0x2440688", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x244068C", Offset = "0x244068C", VA = "0x244068C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x2440C70", Offset = "0x2440C70", VA = "0x2440C70", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000B7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C080", Offset = "0xA0C080")]
		private sealed class <PopulateSourcesWithResourceClipAsync>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string clipName;

			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action successAction;

			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action failureAction;

			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public SoundGroupVariation variation;

			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ResourceRequest <asyncRes>5__2;

			[Token(Token = "0x170000BF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004DE")]
				[Address(RVA = "0x244136C", Offset = "0x244136C", VA = "0x244136C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004E0")]
				[Address(RVA = "0x24413B4", Offset = "0x24413B4", VA = "0x24413B4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x2440CB8", Offset = "0x2440CB8", VA = "0x2440CB8")]
			[DebuggerHidden]
			public <PopulateSourcesWithResourceClipAsync>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x2440CE4", Offset = "0x2440CE4", VA = "0x2440CE4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x2440CE8", Offset = "0x2440CE8", VA = "0x2440CE8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x2441374", Offset = "0x2441374", VA = "0x2441374", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, List<AudioSource>> AudioResourceTargetsByName;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<string, AudioClip> AudioClipsByName;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<string, List<AudioClip>> PlaylistClipsByPlaylistName;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static string _supportedLanguageFolder;

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x19ADC20", Offset = "0x19ADC20", VA = "0x19ADC20")]
		public static void ClearAudioClips()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x19ADCD0", Offset = "0x19ADCD0", VA = "0x19ADCD0")]
		public static string GetLocalizedDynamicSoundGroupFileName(SystemLanguage localLanguage, bool useLocalization, string resourceFileName)
		{
			return null;
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x19ADE4C", Offset = "0x19ADE4C", VA = "0x19ADE4C")]
		public static string GetLocalizedFileName(bool useLocalization, string resourceFileName)
		{
			return null;
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x19AE1D8", Offset = "0x19AE1D8", VA = "0x19AE1D8")]
		public static void AddTargetForClip(string clipName, AudioSource source)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x19ADEF0", Offset = "0x19ADEF0", VA = "0x19ADEF0")]
		private static string SupportedLanguageFolder()
		{
			return null;
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x19AE64C", Offset = "0x19AE64C", VA = "0x19AE64C")]
		public static void ClearSupportLanguageFolder()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x19AE6D4", Offset = "0x19AE6D4", VA = "0x19AE6D4")]
		private static void FinishRecordingPlaylistClip(string controllerName, AudioClip resAudioClip)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x19AE878", Offset = "0x19AE878", VA = "0x19AE878")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0F294", Offset = "0xA0F294")]
		public static IEnumerator PopulateResourceSongToPlaylistControllerAsync(MusicSetting songSetting, string songResourceName, string playlistName, PlaylistController controller, PlaylistController.AudioPlayType playType)
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x19AE944", Offset = "0x19AE944", VA = "0x19AE944")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0F2F4", Offset = "0xA0F2F4")]
		public static IEnumerator PopulateSourcesWithResourceClipAsync(string clipName, SoundGroupVariation variation, Action successAction, Action failureAction)
		{
			return null;
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x19AEA08", Offset = "0x19AEA08", VA = "0x19AEA08")]
		public static void UnloadPlaylistSongIfUnused(string controllerName, AudioClip clipToRemove)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x19AEBAC", Offset = "0x19AEBAC", VA = "0x19AEBAC")]
		public static void DeleteAudioSourceFromList(string clipName, AudioSource source)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x19AEE58", Offset = "0x19AEE58", VA = "0x19AEE58")]
		public static void UnloadClipIfUnused(string clipName)
		{
		}
	}
	[Token(Token = "0x200007B")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0xA0BF34", Offset = "0xA0BF34")]
	public class MasterAudio : MonoBehaviour
	{
		[Token(Token = "0x20000B8")]
		public enum BusVoiceLimitExceededMode
		{
			[Token(Token = "0x400058A")]
			DoNotPlayNewSound,
			[Token(Token = "0x400058B")]
			StopOldestSound,
			[Token(Token = "0x400058C")]
			StopFarthestSound,
			[Token(Token = "0x400058D")]
			StopLeastImportantSound
		}

		[Token(Token = "0x20000B9")]
		public enum AmbientSoundExitMode
		{
			[Token(Token = "0x400058F")]
			StopSound,
			[Token(Token = "0x4000590")]
			FadeSound
		}

		[Token(Token = "0x20000BA")]
		public enum AmbientSoundReEnterMode
		{
			[Token(Token = "0x4000592")]
			StopExistingSound,
			[Token(Token = "0x4000593")]
			FadeInSameSound
		}

		[Token(Token = "0x20000BB")]
		public enum VariationFollowerType
		{
			[Token(Token = "0x4000595")]
			LateUpdate,
			[Token(Token = "0x4000596")]
			FixedUpdate
		}

		[Token(Token = "0x20000BC")]
		public enum LinkedGroupSelectionType
		{
			[Token(Token = "0x4000598")]
			All,
			[Token(Token = "0x4000599")]
			OneAtRandom
		}

		[Token(Token = "0x20000BD")]
		public enum OcclusionSelectionType
		{
			[Token(Token = "0x400059B")]
			AllGroups,
			[Token(Token = "0x400059C")]
			TurnOnPerBusOrGroup
		}

		[Token(Token = "0x20000BE")]
		public enum RaycastMode
		{
			[Token(Token = "0x400059E")]
			Physics3D,
			[Token(Token = "0x400059F")]
			Physics2D
		}

		[Token(Token = "0x20000BF")]
		public enum AllMusicSpatialBlendType
		{
			[Token(Token = "0x40005A1")]
			ForceAllTo2D,
			[Token(Token = "0x40005A2")]
			ForceAllTo3D,
			[Token(Token = "0x40005A3")]
			ForceAllToCustom,
			[Token(Token = "0x40005A4")]
			AllowDifferentPerController
		}

		[Token(Token = "0x20000C0")]
		public enum AllMixerSpatialBlendType
		{
			[Token(Token = "0x40005A6")]
			ForceAllTo2D,
			[Token(Token = "0x40005A7")]
			ForceAllTo3D,
			[Token(Token = "0x40005A8")]
			ForceAllToCustom,
			[Token(Token = "0x40005A9")]
			AllowDifferentPerGroup
		}

		[Token(Token = "0x20000C1")]
		public enum ItemSpatialBlendType
		{
			[Token(Token = "0x40005AB")]
			ForceTo2D,
			[Token(Token = "0x40005AC")]
			ForceTo3D,
			[Token(Token = "0x40005AD")]
			ForceToCustom,
			[Token(Token = "0x40005AE")]
			UseCurveFromAudioSource
		}

		[Token(Token = "0x20000C2")]
		public enum GroupPlayType
		{
			[Token(Token = "0x40005B0")]
			Always,
			[Token(Token = "0x40005B1")]
			WhenActorInAudibleRange,
			[Token(Token = "0x40005B2")]
			AllowDifferentPerGroup
		}

		[Token(Token = "0x20000C3")]
		public enum DefaultGroupPlayType
		{
			[Token(Token = "0x40005B4")]
			Always,
			[Token(Token = "0x40005B5")]
			WhenActorInAudibleRange
		}

		[Token(Token = "0x20000C4")]
		public enum MixerWidthMode
		{
			[Token(Token = "0x40005B7")]
			Narrow,
			[Token(Token = "0x40005B8")]
			Normal,
			[Token(Token = "0x40005B9")]
			Wide
		}

		[Token(Token = "0x20000C5")]
		public enum CustomEventReceiveMode
		{
			[Token(Token = "0x40005BB")]
			Always,
			[Token(Token = "0x40005BC")]
			WhenDistanceLessThan,
			[Token(Token = "0x40005BD")]
			WhenDistanceMoreThan,
			[Token(Token = "0x40005BE")]
			Never,
			[Token(Token = "0x40005BF")]
			OnSameGameObject,
			[Token(Token = "0x40005C0")]
			OnChildGameObject,
			[Token(Token = "0x40005C1")]
			OnParentGameObject,
			[Token(Token = "0x40005C2")]
			OnSameOrChildGameObject,
			[Token(Token = "0x40005C3")]
			OnSameOrParentGameObject
		}

		[Token(Token = "0x20000C6")]
		public enum EventReceiveFilter
		{
			[Token(Token = "0x40005C5")]
			All,
			[Token(Token = "0x40005C6")]
			Closest,
			[Token(Token = "0x40005C7")]
			Random
		}

		[Token(Token = "0x20000C7")]
		public enum VariationLoadStatus
		{
			[Token(Token = "0x40005C9")]
			None,
			[Token(Token = "0x40005CA")]
			Loading,
			[Token(Token = "0x40005CB")]
			Loaded,
			[Token(Token = "0x40005CC")]
			LoadFailed
		}

		[Token(Token = "0x20000C8")]
		public enum AudioLocation
		{
			[Token(Token = "0x40005CE")]
			Clip,
			[Token(Token = "0x40005CF")]
			ResourceFile
		}

		[Token(Token = "0x20000C9")]
		public enum CustomSongStartTimeMode
		{
			[Token(Token = "0x40005D1")]
			Beginning,
			[Token(Token = "0x40005D2")]
			SpecificTime,
			[Token(Token = "0x40005D3")]
			RandomTime
		}

		[Token(Token = "0x20000CA")]
		public enum BusCommand
		{
			[Token(Token = "0x40005D5")]
			None,
			[Token(Token = "0x40005D6")]
			FadeToVolume,
			[Token(Token = "0x40005D7")]
			Mute,
			[Token(Token = "0x40005D8")]
			Pause,
			[Token(Token = "0x40005D9")]
			Solo,
			[Token(Token = "0x40005DA")]
			Unmute,
			[Token(Token = "0x40005DB")]
			Unpause,
			[Token(Token = "0x40005DC")]
			Unsolo,
			[Token(Token = "0x40005DD")]
			Stop,
			[Token(Token = "0x40005DE")]
			ChangePitch,
			[Token(Token = "0x40005DF")]
			ToggleMute,
			[Token(Token = "0x40005E0")]
			StopBusOfTransform,
			[Token(Token = "0x40005E1")]
			PauseBusOfTransform,
			[Token(Token = "0x40005E2")]
			UnpauseBusOfTransform,
			[Token(Token = "0x40005E3")]
			GlideByPitch,
			[Token(Token = "0x40005E4")]
			StopOldBusVoices,
			[Token(Token = "0x40005E5")]
			FadeOutOldBusVoices
		}

		[Token(Token = "0x20000CB")]
		public enum DragGroupMode
		{
			[Token(Token = "0x40005E7")]
			OneGroupPerClip,
			[Token(Token = "0x40005E8")]
			OneGroupWithVariations
		}

		[Token(Token = "0x20000CC")]
		public enum EventSoundFunctionType
		{
			[Token(Token = "0x40005EA")]
			PlaySound,
			[Token(Token = "0x40005EB")]
			GroupControl,
			[Token(Token = "0x40005EC")]
			BusControl,
			[Token(Token = "0x40005ED")]
			PlaylistControl,
			[Token(Token = "0x40005EE")]
			CustomEventControl,
			[Token(Token = "0x40005EF")]
			GlobalControl,
			[Token(Token = "0x40005F0")]
			UnityMixerControl,
			[Token(Token = "0x40005F1")]
			PersistentSettingsControl
		}

		[Token(Token = "0x20000CD")]
		public enum LanguageMode
		{
			[Token(Token = "0x40005F3")]
			UseDeviceSetting,
			[Token(Token = "0x40005F4")]
			SpecificLanguage,
			[Token(Token = "0x40005F5")]
			DynamicallySet
		}

		[Token(Token = "0x20000CE")]
		public enum UnityMixerCommand
		{
			[Token(Token = "0x40005F7")]
			None,
			[Token(Token = "0x40005F8")]
			TransitionToSnapshot,
			[Token(Token = "0x40005F9")]
			TransitionToSnapshotBlend
		}

		[Token(Token = "0x20000CF")]
		public enum PlaylistCommand
		{
			[Token(Token = "0x40005FB")]
			None,
			[Token(Token = "0x40005FC")]
			ChangePlaylist,
			[Token(Token = "0x40005FD")]
			FadeToVolume,
			[Token(Token = "0x40005FE")]
			PlaySong,
			[Token(Token = "0x40005FF")]
			PlayRandomSong,
			[Token(Token = "0x4000600")]
			PlayNextSong,
			[Token(Token = "0x4000601")]
			Pause,
			[Token(Token = "0x4000602")]
			Resume,
			[Token(Token = "0x4000603")]
			Stop,
			[Token(Token = "0x4000604")]
			Mute,
			[Token(Token = "0x4000605")]
			Unmute,
			[Token(Token = "0x4000606")]
			ToggleMute,
			[Token(Token = "0x4000607")]
			Restart,
			[Token(Token = "0x4000608")]
			Start,
			[Token(Token = "0x4000609")]
			StopLoopingCurrentSong,
			[Token(Token = "0x400060A")]
			StopPlaylistAfterCurrentSong,
			[Token(Token = "0x400060B")]
			AddSongToQueue
		}

		[Token(Token = "0x20000D0")]
		public enum CustomEventCommand
		{
			[Token(Token = "0x400060D")]
			None,
			[Token(Token = "0x400060E")]
			FireEvent
		}

		[Token(Token = "0x20000D1")]
		public enum GlobalCommand
		{
			[Token(Token = "0x4000610")]
			None,
			[Token(Token = "0x4000611")]
			PauseMixer,
			[Token(Token = "0x4000612")]
			UnpauseMixer,
			[Token(Token = "0x4000613")]
			StopMixer,
			[Token(Token = "0x4000614")]
			StopEverything,
			[Token(Token = "0x4000615")]
			PauseEverything,
			[Token(Token = "0x4000616")]
			UnpauseEverything,
			[Token(Token = "0x4000617")]
			MuteEverything,
			[Token(Token = "0x4000618")]
			UnmuteEverything,
			[Token(Token = "0x4000619")]
			SetMasterMixerVolume,
			[Token(Token = "0x400061A")]
			SetMasterPlaylistVolume
		}

		[Token(Token = "0x20000D2")]
		public enum SoundGroupCommand
		{
			[Token(Token = "0x400061C")]
			None,
			[Token(Token = "0x400061D")]
			FadeToVolume,
			[Token(Token = "0x400061E")]
			FadeOutAllOfSound,
			[Token(Token = "0x400061F")]
			Mute,
			[Token(Token = "0x4000620")]
			Pause,
			[Token(Token = "0x4000621")]
			Solo,
			[Token(Token = "0x4000622")]
			StopAllOfSound,
			[Token(Token = "0x4000623")]
			Unmute,
			[Token(Token = "0x4000624")]
			Unpause,
			[Token(Token = "0x4000625")]
			Unsolo,
			[Token(Token = "0x4000626")]
			StopAllSoundsOfTransform,
			[Token(Token = "0x4000627")]
			PauseAllSoundsOfTransform,
			[Token(Token = "0x4000628")]
			UnpauseAllSoundsOfTransform,
			[Token(Token = "0x4000629")]
			StopSoundGroupOfTransform,
			[Token(Token = "0x400062A")]
			PauseSoundGroupOfTransform,
			[Token(Token = "0x400062B")]
			UnpauseSoundGroupOfTransform,
			[Token(Token = "0x400062C")]
			FadeOutSoundGroupOfTransform,
			[Token(Token = "0x400062D")]
			RefillSoundGroupPool,
			[Token(Token = "0x400062E")]
			RouteToBus,
			[Token(Token = "0x400062F")]
			GlideByPitch,
			[Token(Token = "0x4000630")]
			ToggleSoundGroup,
			[Token(Token = "0x4000631")]
			ToggleSoundGroupOfTransform,
			[Token(Token = "0x4000632")]
			FadeOutAllSoundsOfTransform,
			[Token(Token = "0x4000633")]
			StopOldSoundGroupVoices,
			[Token(Token = "0x4000634")]
			FadeOutOldSoundGroupVoices
		}

		[Token(Token = "0x20000D3")]
		public enum PersistentSettingsCommand
		{
			[Token(Token = "0x4000636")]
			None,
			[Token(Token = "0x4000637")]
			SetBusVolume,
			[Token(Token = "0x4000638")]
			SetGroupVolume,
			[Token(Token = "0x4000639")]
			SetMixerVolume,
			[Token(Token = "0x400063A")]
			SetMusicVolume,
			[Token(Token = "0x400063B")]
			MixerMuteToggle,
			[Token(Token = "0x400063C")]
			MusicMuteToggle
		}

		[Token(Token = "0x20000D4")]
		public enum SongFadeInPosition
		{
			[Token(Token = "0x400063E")]
			NewClipFromBeginning = 1,
			[Token(Token = "0x400063F")]
			NewClipFromLastKnownPosition = 3,
			[Token(Token = "0x4000640")]
			SynchronizeClips = 5
		}

		[Token(Token = "0x20000D5")]
		public enum SoundSpawnLocationMode
		{
			[Token(Token = "0x4000642")]
			MasterAudioLocation,
			[Token(Token = "0x4000643")]
			CallerLocation,
			[Token(Token = "0x4000644")]
			AttachToCaller
		}

		[Token(Token = "0x20000D6")]
		public enum VariationCommand
		{
			[Token(Token = "0x4000646")]
			None,
			[Token(Token = "0x4000647")]
			Stop,
			[Token(Token = "0x4000648")]
			Pause,
			[Token(Token = "0x4000649")]
			Unpause
		}

		[Serializable]
		[Token(Token = "0x20000D7")]
		public struct CustomEventCandidate
		{
			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float DistanceAway;

			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ICustomEventReceiver Receiver;

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform Trans;

			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int RandomId;

			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x2442CB4", Offset = "0x2442CB4", VA = "0x2442CB4")]
			public CustomEventCandidate(float distance, ICustomEventReceiver rec, Transform trans, int randomId)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D8")]
		public class AudioGroupInfo
		{
			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<AudioInfo> Sources;

			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int LastFramePlayed;

			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float LastTimePlayed;

			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MasterAudioGroup Group;

			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool PlayedForWarming;

			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x2442BDC", Offset = "0x2442BDC", VA = "0x2442BDC")]
			public AudioGroupInfo(List<AudioInfo> sources, MasterAudioGroup groupScript)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D9")]
		public class AudioInfo
		{
			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource Source;

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float OriginalVolume;

			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float LastPercentageVolume;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float LastRandomVolume;

			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SoundGroupVariation Variation;

			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x2442C44", Offset = "0x2442C44", VA = "0x2442C44")]
			public AudioInfo(SoundGroupVariation variation, AudioSource source, float origVol)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DA")]
		public class Playlist
		{
			[Token(Token = "0x2000107")]
			public enum CrossfadeTimeMode
			{
				[Token(Token = "0x40006D6")]
				UseMasterSetting,
				[Token(Token = "0x40006D7")]
				Override
			}

			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isExpanded;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string playlistName;

			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SongFadeInPosition songTransitionType;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<MusicSetting> MusicSettings;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public AudioLocation bulkLocationMode;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public CrossfadeTimeMode crossfadeMode;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float crossFadeTime;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public bool fadeInFirstSong;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
			public bool fadeOutLastSong;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
			public bool bulkEditMode;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
			public bool isTemporary;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool showMetadata;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public List<SongMetadataProperty> songMetadataProps;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string newMetadataPropName;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public SongMetadataProperty.MetadataPropertyType newMetadataPropType;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public bool newMetadataPropRequired;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
			public bool newMetadataPropCanHaveMult;

			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x2442D00", Offset = "0x2442D00", VA = "0x2442D00")]
			public Playlist()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DB")]
		public class SoundGroupRefillInfo
		{
			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float LastTimePlayed;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float InactivePeriodSeconds;

			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x2442E3C", Offset = "0x2442E3C", VA = "0x2442E3C")]
			public SoundGroupRefillInfo(float lastTimePlayed, float inactivePeriodSeconds)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C090", Offset = "0xA0C090")]
		private sealed class <>c
		{
			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<OcclusionFreqChangeInfo> <>9__239_0;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Predicate<BusFadeInfo> <>9__240_0;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Predicate<GroupFadeInfo> <>9__241_0;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Predicate<AmbientSoundToTriggerInfo> <>9__242_0;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Predicate<GroupPitchGlideInfo> <>9__243_0;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Predicate<BusPitchGlideInfo> <>9__244_0;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static Predicate<AudioInfo> <>9__260_0;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static Comparison<CustomEventCandidate> <>9__465_0;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static Comparison<CustomEventCandidate> <>9__465_1;

			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x24419E0", Offset = "0x24419E0", VA = "0x24419E0")]
			public <>c()
			{
			}

			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x24419E8", Offset = "0x24419E8", VA = "0x24419E8")]
			internal bool <PerformOcclusionFrequencyChanges>b__239_0(OcclusionFreqChangeInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x2441A08", Offset = "0x2441A08", VA = "0x2441A08")]
			internal bool <PerformBusFades>b__240_0(BusFadeInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x2441A28", Offset = "0x2441A28", VA = "0x2441A28")]
			internal bool <PerformGroupFades>b__241_0(GroupFadeInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x2441A48", Offset = "0x2441A48", VA = "0x2441A48")]
			internal bool <PerformDelayedAmbientTriggers>b__242_0(AmbientSoundToTriggerInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60004EC")]
			[Address(RVA = "0x2441A80", Offset = "0x2441A80", VA = "0x2441A80")]
			internal bool <PerformGroupPitchGlides>b__243_0(GroupPitchGlideInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x2441AA0", Offset = "0x2441AA0", VA = "0x2441AA0")]
			internal bool <PerformBusPitchGlides>b__244_0(BusPitchGlideInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x2441AC0", Offset = "0x2441AC0", VA = "0x2441AC0")]
			internal bool <CanPlayDialogBasedOnImportanceOrIsNotDialog>b__260_0(AudioInfo info)
			{
				return default(bool);
			}

			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x2441AEC", Offset = "0x2441AEC", VA = "0x2441AEC")]
			internal int <FireCustomEvent>b__465_0(CustomEventCandidate x, CustomEventCandidate y)
			{
				return default(int);
			}

			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x2441AFC", Offset = "0x2441AFC", VA = "0x2441AFC")]
			internal int <FireCustomEvent>b__465_1(CustomEventCandidate x, CustomEventCandidate y)
			{
				return default(int);
			}
		}

		[Token(Token = "0x20000DD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C0A0", Offset = "0xA0C0A0")]
		private sealed class <>c__DisplayClass254_0
		{
			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x2441B10", Offset = "0x2441B10", VA = "0x2441B10")]
			public <>c__DisplayClass254_0()
			{
			}

			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x2441B18", Offset = "0x2441B18", VA = "0x2441B18")]
			internal void <PlaySoundAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x20000DE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C0B0", Offset = "0xA0C0B0")]
		private sealed class <PlaySoundAndWaitUntilFinished>d__254 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float volumePercentage;

			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float? pitch;

			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float delaySoundTime;

			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string variationName;

			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private <>c__DisplayClass254_0 <>8__1;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Action completedAction;

			[Token(Token = "0x170000C1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004F6")]
				[Address(RVA = "0x2442B8C", Offset = "0x2442B8C", VA = "0x2442B8C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004F8")]
				[Address(RVA = "0x2442BD4", Offset = "0x2442BD4", VA = "0x2442BD4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x2442868", Offset = "0x2442868", VA = "0x2442868")]
			[DebuggerHidden]
			public <PlaySoundAndWaitUntilFinished>d__254(int <>1__state)
			{
			}

			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x2442894", Offset = "0x2442894", VA = "0x2442894", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x2442898", Offset = "0x2442898", VA = "0x2442898", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x2442B94", Offset = "0x2442B94", VA = "0x2442B94", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000DF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C0C0", Offset = "0xA0C0C0")]
		private sealed class <>c__DisplayClass255_0
		{
			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x2441B24", Offset = "0x2441B24", VA = "0x2441B24")]
			public <>c__DisplayClass255_0()
			{
			}

			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x2441B2C", Offset = "0x2441B2C", VA = "0x2441B2C")]
			internal void <PlaySound3DAtTransformAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x20000E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C0D0", Offset = "0xA0C0D0")]
		private sealed class <PlaySound3DAtTransformAndWaitUntilFinished>d__255 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform sourceTrans;

			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float volumePercentage;

			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float? pitch;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float delaySoundTime;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string variationName;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public double? timeToSchedulePlay;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private <>c__DisplayClass255_0 <>8__1;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Action completedAction;

			[Token(Token = "0x170000C3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004FE")]
				[Address(RVA = "0x2442488", Offset = "0x2442488", VA = "0x2442488", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000500")]
				[Address(RVA = "0x24424D0", Offset = "0x24424D0", VA = "0x24424D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x2442134", Offset = "0x2442134", VA = "0x2442134")]
			[DebuggerHidden]
			public <PlaySound3DAtTransformAndWaitUntilFinished>d__255(int <>1__state)
			{
			}

			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x2442160", Offset = "0x2442160", VA = "0x2442160", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x2442164", Offset = "0x2442164", VA = "0x2442164", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x2442490", Offset = "0x2442490", VA = "0x2442490", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000E1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C0E0", Offset = "0xA0C0E0")]
		private sealed class <>c__DisplayClass256_0
		{
			[Token(Token = "0x400068B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x6000501")]
			[Address(RVA = "0x2441B38", Offset = "0x2441B38", VA = "0x2441B38")]
			public <>c__DisplayClass256_0()
			{
			}

			[Token(Token = "0x6000502")]
			[Address(RVA = "0x2441B40", Offset = "0x2441B40", VA = "0x2441B40")]
			internal void <PlaySound3DFollowTransformAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x20000E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C0F0", Offset = "0xA0C0F0")]
		private sealed class <PlaySound3DFollowTransformAndWaitUntilFinished>d__256 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400068E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x400068F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform sourceTrans;

			[Token(Token = "0x4000690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float volumePercentage;

			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float? pitch;

			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float delaySoundTime;

			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string variationName;

			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public double? timeToSchedulePlay;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private <>c__DisplayClass256_0 <>8__1;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Action completedAction;

			[Token(Token = "0x170000C5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000506")]
				[Address(RVA = "0x2442818", Offset = "0x2442818", VA = "0x2442818", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000508")]
				[Address(RVA = "0x2442860", Offset = "0x2442860", VA = "0x2442860", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000503")]
			[Address(RVA = "0x24424D8", Offset = "0x24424D8", VA = "0x24424D8")]
			[DebuggerHidden]
			public <PlaySound3DFollowTransformAndWaitUntilFinished>d__256(int <>1__state)
			{
			}

			[Token(Token = "0x6000504")]
			[Address(RVA = "0x2442504", Offset = "0x2442504", VA = "0x2442504", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000505")]
			[Address(RVA = "0x2442508", Offset = "0x2442508", VA = "0x2442508", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000507")]
			[Address(RVA = "0x2442820", Offset = "0x2442820", VA = "0x2442820", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000E3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C100", Offset = "0xA0C100")]
		private sealed class <>c__DisplayClass270_0
		{
			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MasterAudioGroup maGroup;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string variationName;

			[Token(Token = "0x6000509")]
			[Address(RVA = "0x2441B4C", Offset = "0x2441B4C", VA = "0x2441B4C")]
			public <>c__DisplayClass270_0()
			{
			}

			[Token(Token = "0x600050A")]
			[Address(RVA = "0x2441B54", Offset = "0x2441B54", VA = "0x2441B54")]
			internal bool <FindRetriggerableVariationInGroup>b__0(AudioInfo info)
			{
				return default(bool);
			}

			[Token(Token = "0x600050B")]
			[Address(RVA = "0x2441BD0", Offset = "0x2441BD0", VA = "0x2441BD0")]
			internal bool <FindRetriggerableVariationInGroup>b__1(AudioInfo info)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C110", Offset = "0xA0C110")]
		private sealed class <>c__DisplayClass308_0
		{
			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x600050C")]
			[Address(RVA = "0x2441C6C", Offset = "0x2441C6C", VA = "0x2441C6C")]
			public <>c__DisplayClass308_0()
			{
			}

			[Token(Token = "0x600050D")]
			[Address(RVA = "0x2441C74", Offset = "0x2441C74", VA = "0x2441C74")]
			internal bool <RouteGroupToBus>b__1(GroupBus x)
			{
				return default(bool);
			}

			[Token(Token = "0x600050E")]
			[Address(RVA = "0x2441C98", Offset = "0x2441C98", VA = "0x2441C98")]
			internal bool <RouteGroupToBus>b__0(GroupBus x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000E5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C120", Offset = "0xA0C120")]
		private sealed class <>c__DisplayClass316_0
		{
			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string sType;

			[Token(Token = "0x600050F")]
			[Address(RVA = "0x2441CBC", Offset = "0x2441CBC", VA = "0x2441CBC")]
			public <>c__DisplayClass316_0()
			{
			}

			[Token(Token = "0x6000510")]
			[Address(RVA = "0x2441CC4", Offset = "0x2441CC4", VA = "0x2441CC4")]
			internal bool <FadeSoundGroupToVolume>b__0(GroupFadeInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000E6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C130", Offset = "0xA0C130")]
		private sealed class <>c__DisplayClass319_0
		{
			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string sType;

			[Token(Token = "0x6000511")]
			[Address(RVA = "0x2441CE8", Offset = "0x2441CE8", VA = "0x2441CE8")]
			public <>c__DisplayClass319_0()
			{
			}

			[Token(Token = "0x6000512")]
			[Address(RVA = "0x2441CF0", Offset = "0x2441CF0", VA = "0x2441CF0")]
			internal bool <GlideSoundGroupByPitch>b__0(GroupPitchGlideInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000E7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C140", Offset = "0xA0C140")]
		private sealed class <>c__DisplayClass373_0
		{
			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x6000513")]
			[Address(RVA = "0x2441D14", Offset = "0x2441D14", VA = "0x2441D14")]
			public <>c__DisplayClass373_0()
			{
			}

			[Token(Token = "0x6000514")]
			[Address(RVA = "0x2441D1C", Offset = "0x2441D1C", VA = "0x2441D1C")]
			internal bool <CreateBus>b__0(GroupBus obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C150", Offset = "0xA0C150")]
		private sealed class <>c__DisplayClass377_0
		{
			[Token(Token = "0x400069D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x6000515")]
			[Address(RVA = "0x2441D40", Offset = "0x2441D40", VA = "0x2441D40")]
			public <>c__DisplayClass377_0()
			{
			}

			[Token(Token = "0x6000516")]
			[Address(RVA = "0x2441D48", Offset = "0x2441D48", VA = "0x2441D48")]
			internal bool <FadeBusToVolume>b__0(BusFadeInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000E9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C160", Offset = "0xA0C160")]
		private sealed class <>c__DisplayClass380_0
		{
			[Token(Token = "0x400069E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x6000517")]
			[Address(RVA = "0x2441D6C", Offset = "0x2441D6C", VA = "0x2441D6C")]
			public <>c__DisplayClass380_0()
			{
			}

			[Token(Token = "0x6000518")]
			[Address(RVA = "0x2441D74", Offset = "0x2441D74", VA = "0x2441D74")]
			internal bool <GlideBusByPitch>b__0(BusPitchGlideInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000EA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C170", Offset = "0xA0C170")]
		private sealed class <>c__DisplayClass461_0
		{
			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string categoryName;

			[Token(Token = "0x6000519")]
			[Address(RVA = "0x2441D98", Offset = "0x2441D98", VA = "0x2441D98")]
			public <>c__DisplayClass461_0()
			{
			}

			[Token(Token = "0x600051A")]
			[Address(RVA = "0x2441DA0", Offset = "0x2441DA0", VA = "0x2441DA0")]
			internal bool <CreateCustomEventCategoryIfNotThere>b__0(CustomEventCategory cat)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000EB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C180", Offset = "0xA0C180")]
		private sealed class <>c__DisplayClass462_0
		{
			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x600051B")]
			[Address(RVA = "0x2441DC4", Offset = "0x2441DC4", VA = "0x2441DC4")]
			public <>c__DisplayClass462_0()
			{
			}

			[Token(Token = "0x600051C")]
			[Address(RVA = "0x2441DCC", Offset = "0x2441DCC", VA = "0x2441DCC")]
			internal bool <CreateCustomEvent>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C190", Offset = "0xA0C190")]
		private sealed class <>c__DisplayClass463_0
		{
			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x600051D")]
			[Address(RVA = "0x2441DF0", Offset = "0x2441DF0", VA = "0x2441DF0")]
			public <>c__DisplayClass463_0()
			{
			}

			[Token(Token = "0x600051E")]
			[Address(RVA = "0x2441DF8", Offset = "0x2441DF8", VA = "0x2441DF8")]
			internal bool <DeleteCustomEvent>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000ED")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C1A0", Offset = "0xA0C1A0")]
		private sealed class <>c__DisplayClass464_0
		{
			[Token(Token = "0x40006A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x600051F")]
			[Address(RVA = "0x2441E1C", Offset = "0x2441E1C", VA = "0x2441E1C")]
			public <>c__DisplayClass464_0()
			{
			}

			[Token(Token = "0x6000520")]
			[Address(RVA = "0x2441E24", Offset = "0x2441E24", VA = "0x2441E24")]
			internal bool <GetCustomEventByName>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000EE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C1B0", Offset = "0xA0C1B0")]
		private sealed class <>c__DisplayClass466_0
		{
			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x6000521")]
			[Address(RVA = "0x2441E48", Offset = "0x2441E48", VA = "0x2441E48")]
			public <>c__DisplayClass466_0()
			{
			}

			[Token(Token = "0x6000522")]
			[Address(RVA = "0x2441E50", Offset = "0x2441E50", VA = "0x2441E50")]
			internal bool <CustomEventExists>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000EF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C1C0", Offset = "0xA0C1C0")]
		private sealed class <>c__DisplayClass467_0
		{
			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string eventName;

			[Token(Token = "0x6000523")]
			[Address(RVA = "0x2441E74", Offset = "0x2441E74", VA = "0x2441E74")]
			public <>c__DisplayClass467_0()
			{
			}

			[Token(Token = "0x6000524")]
			[Address(RVA = "0x2441E7C", Offset = "0x2441E7C", VA = "0x2441E7C")]
			internal bool <GetChildReceivers>b__0(ICustomEventReceiver rec)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C1D0", Offset = "0xA0C1D0")]
		private sealed class <>c__DisplayClass468_0
		{
			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string eventName;

			[Token(Token = "0x6000525")]
			[Address(RVA = "0x2441F48", Offset = "0x2441F48", VA = "0x2441F48")]
			public <>c__DisplayClass468_0()
			{
			}

			[Token(Token = "0x6000526")]
			[Address(RVA = "0x2441F50", Offset = "0x2441F50", VA = "0x2441F50")]
			internal bool <GetParentReceivers>b__0(ICustomEventReceiver rec)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000F1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C1E0", Offset = "0xA0C1E0")]
		private sealed class <>c__DisplayClass483_0
		{
			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AmbientSound ambient;

			[Token(Token = "0x6000527")]
			[Address(RVA = "0x244201C", Offset = "0x244201C", VA = "0x244201C")]
			public <>c__DisplayClass483_0()
			{
			}

			[Token(Token = "0x6000528")]
			[Address(RVA = "0x2442024", Offset = "0x2442024", VA = "0x2442024")]
			internal bool <SetupAmbientNextFrame>b__0(AmbientSoundToTriggerInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000F2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C1F0", Offset = "0xA0C1F0")]
		private sealed class <>c__DisplayClass484_0
		{
			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AmbientSound ambient;

			[Token(Token = "0x6000529")]
			[Address(RVA = "0x24420A8", Offset = "0x24420A8", VA = "0x24420A8")]
			public <>c__DisplayClass484_0()
			{
			}

			[Token(Token = "0x600052A")]
			[Address(RVA = "0x24420B0", Offset = "0x24420B0", VA = "0x24420B0")]
			internal bool <RemoveDelayedAmbient>b__0(AmbientSoundToTriggerInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400035F")]
		public const string VideoPlayersSoundGroupSelectedError = "Can't use specially named Sound Group for Video Players. Please select another.";

		[Token(Token = "0x4000360")]
		public const string VideoPlayerSoundGroupName = "_VideoPlayers";

		[Token(Token = "0x4000361")]
		public const string VideoPlayerBusName = "_VideoPlayers";

		[Token(Token = "0x4000362")]
		public const string MasterAudioDefaultFolder = "Assets/Plugins/DarkTonic/MasterAudio";

		[Token(Token = "0x4000363")]
		public const string PreviewText = "Random delay, custom fading & start/end position settings are ignored by preview in edit mode.";

		[Token(Token = "0x4000364")]
		public const string LoopDisabledLoopedChain = "Loop Clip is always OFF for Looped Chain Groups";

		[Token(Token = "0x4000365")]
		public const string LoopDisabledCustomEnd = "Loop Clip is always OFF when using Custom End Position";

		[Token(Token = "0x4000366")]
		public const string DragAudioTip = "Drag Audio clips or a folder containing some here";

		[Token(Token = "0x4000367")]
		public const string NoCategory = "[Uncategorized]";

		[Token(Token = "0x4000368")]
		public const float SemiTonePitchFactor = 1.05946f;

		[Token(Token = "0x4000369")]
		public const float SpatialBlend_2DValue = 0f;

		[Token(Token = "0x400036A")]
		public const float SpatialBlend_3DValue = 1f;

		[Token(Token = "0x400036B")]
		public const float MaxCrossFadeTimeSeconds = 120f;

		[Token(Token = "0x400036C")]
		public const float DefaultDuckVolCut = -6f;

		[Token(Token = "0x400036D")]
		public const int ERROR_MA_LAYER_COLLISIONS_DISABLED = 1;

		[Token(Token = "0x400036E")]
		public const int PHYSICS_DISABLED = 2;

		[Token(Token = "0x400036F")]
		public const string StoredLanguageNameKey = "~MA_Language_Key~";

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly YieldInstruction EndOfFrameDelay;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly List<string> ExemptChildNames;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly HashSet<int> ErrorNumbersLogged;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static List<string> ImportanceChoices;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Action NumberOfAudioSourcesChanged;

		[Token(Token = "0x4000375")]
		public const int HardCodedBusOptions = 2;

		[Token(Token = "0x4000376")]
		public const string AllBusesName = "[All]";

		[Token(Token = "0x4000377")]
		public const string NoGroupName = "[None]";

		[Token(Token = "0x4000378")]
		public const string DynamicGroupName = "[Type In]";

		[Token(Token = "0x4000379")]
		public const string NoPlaylistName = "[No Playlist]";

		[Token(Token = "0x400037A")]
		public const string NoVoiceLimitName = "[NO LMT]";

		[Token(Token = "0x400037B")]
		public const string OnlyPlaylistControllerName = "~only~";

		[Token(Token = "0x400037C")]
		public const float InnerLoopCheckInterval = 0.1f;

		[Token(Token = "0x400037D")]
		private const int MaxComponents = 20;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioLocation bulkLocationMode;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string groupTemplateName;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string audioSourceTemplateName;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool showGroupCreation;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool useGroupTemplates;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public DragGroupMode curDragGroupMode;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<GameObject> groupTemplates;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<GameObject> audioSourceTemplates;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool mixerMuted;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool playlistsMuted;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public LanguageMode langMode;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SystemLanguage testLanguage;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public SystemLanguage defaultLanguage;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<SystemLanguage> supportedLanguages;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string busFilter;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useTextGroupFilter;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string textGroupFilter;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool resourceClipsPauseDoNotUnload;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform playlistControllerPrefab;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool persistBetweenScenes;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public bool shouldLogDestroys;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
		public bool showBusColors;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8B")]
		public bool showGroupImportance;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public bool areGroupsExpanded;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform soundGroupTemplate;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Transform soundGroupVariationTemplate;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public List<GroupBus> groupBuses;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool groupByBus;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		public bool sortAlpha;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAA")]
		public bool showRangeSoundGizmos;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAB")]
		public bool showSelectedRangeSoundGizmos;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public Color rangeGizmoColor;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public Color selectedRangeGizmoColor;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public bool showAdvancedSettings;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		public bool showLocalization;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCE")]
		public bool showVideoPlayerSettings;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public List<VideoPlayer> videoPlayers;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public bool playListExpanded;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		public bool playlistsExpanded;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public AllMusicSpatialBlendType musicSpatialBlendType;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float musicSpatialBlend;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public AllMixerSpatialBlendType mixerSpatialBlendType;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public float mixerSpatialBlend;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public GroupPlayType groupPlayType;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public DefaultGroupPlayType defaultGroupPlayType;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public ItemSpatialBlendType newGroupSpatialType;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public float newGroupSpatialBlend;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public List<Playlist> musicPlaylists;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public float _masterAudioVolume;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public bool vrSettingsExpanded;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10D")]
		public bool useSpatializer;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10E")]
		public bool useSpatializerPostFX;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10F")]
		public bool addOculusAudioSources;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public bool addResonanceAudioSources;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x111")]
		public bool ignoreTimeScale;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x112")]
		public bool useGaplessPlaylists;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x113")]
		public bool useGaplessAutoReschedule;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public bool saveRuntimeChanges;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x115")]
		public bool prioritizeOnDistance;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public int rePrioritizeEverySecIndex;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public bool useOcclusion;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public float occlusionFreqChangeSeconds;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public OcclusionSelectionType occlusionSelectType;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public int occlusionMaxRayCastsPerFrame;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public bool occlusionUseLayerMask;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		public LayerMask occlusionLayerMask;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public bool occlusionShowRaycasts;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x141")]
		public bool occlusionShowCategories;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public RaycastMode occlusionRaycastMode;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public bool occlusionIncludeStartRaycast2DCollider;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x149")]
		public bool occlusionRaycastsHitTriggers;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14A")]
		public bool ambientAdvancedExpanded;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public int ambientMaxRecalcsPerFrame;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public bool visualAdvancedExpanded;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x151")]
		public bool logAdvancedExpanded;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x152")]
		public bool listenerAdvancedExpanded;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x153")]
		public bool listenerFollowerHasRigidBody;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		public VariationFollowerType variationFollowerType;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public bool showFadingSettings;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x159")]
		public bool stopZeroVolumeGroups;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15A")]
		public bool stopZeroVolumeBuses;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15B")]
		public bool stopZeroVolumePlaylists;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		public float stopOldestBusFadeTime;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public bool resourceAdvancedExpanded;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x161")]
		public bool useClipAgePriority;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x162")]
		public bool logOutOfVoices;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x163")]
		public bool LogSounds;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		public bool logCustomEvents;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x165")]
		public bool disableLogging;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x166")]
		public bool showMusicDucking;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x167")]
		public bool enableMusicDucking;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public List<DuckGroupInfo> musicDuckingSounds;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public float defaultRiseVolStart;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		public float defaultUnduckTime;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public float defaultDuckedVolumeCut;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		public float crossFadeTime;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public float _masterPlaylistVolume;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		public bool showGroupSelect;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x185")]
		public bool hideGroupsWithNoActiveVars;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x186")]
		public bool logPerfExpanded;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x187")]
		public bool willWarm;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public string newEventName;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public bool showCustomEvents;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public List<CustomEvent> customEvents;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public Dictionary<string, DuckGroupInfo> duckingBySoundType;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public int frames;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		public bool showUnityMixerGroupAssignment;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly PlaySoundResult AndForgetSuccessResult;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly PlaySoundResult failedResultDuringInit;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private readonly Dictionary<string, AudioGroupInfo> AudioSourcesBySoundType;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Dictionary<string, List<int>> _randomizer;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private Dictionary<string, List<int>> _randomizerOrigin;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private Dictionary<string, List<int>> _randomizerLeftovers;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private Dictionary<string, List<int>> _clipsPlayedBySoundTypeOldestFirst;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private readonly List<SoundGroupVariationUpdater> ActiveVariationUpdaters;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private readonly List<SoundGroupVariationUpdater> ActiveUpdatersToRemove;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private readonly List<CustomEventCandidate> ValidReceivers;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private readonly List<MasterAudioGroup> SoloedGroups;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private readonly List<AmbientSoundToTriggerInfo> AmbientsToDelayedTrigger;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private readonly Queue<CustomEventToFireInfo> CustomEventsToFire;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private readonly Queue<TransformFollower> TransFollowerColliderPositionRecalcs;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private readonly List<TransformFollower> ProcessedColliderPositionRecalcs;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private readonly List<BusFadeInfo> BusFades;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private readonly List<GroupFadeInfo> GroupFades;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private readonly List<GroupPitchGlideInfo> GroupPitchGlides;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private readonly List<BusPitchGlideInfo> BusPitchGlides;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private readonly List<OcclusionFreqChangeInfo> VariationOcclusionFreqChanges;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private readonly List<AudioSource> AllAudioSources;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private readonly Dictionary<string, Dictionary<ICustomEventReceiver, Transform>> ReceiversByEventName;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private readonly Dictionary<string, PlaylistController> PlaylistControllersByName;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private readonly Dictionary<string, SoundGroupRefillInfo> LastTimeSoundGroupPlayed;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private readonly List<GameObject> OcclusionSourcesInRange;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private readonly List<GameObject> OcclusionSourcesOutOfRange;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private readonly List<GameObject> OcclusionSourcesBlocked;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private readonly Queue<SoundGroupVariationUpdater> QueuedOcclusionRays;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private readonly List<VideoPlayerTracker> VideoPlayerTrackers;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private readonly List<SoundGroupVariation> VariationsStartedDuringMultiStop;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private bool _isStoppingMultiple;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2AC")]
		private float _repriTime;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private List<string> _groupsToRemove;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private bool _mustRescanGroups;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private Transform _trans;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private bool _soundsLoaded;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C9")]
		private bool _warming;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static MasterAudio _instance;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static string _prospectiveMAFolder;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static Transform _listenerTrans;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static readonly List<SoundGroupCommand> GroupCommandsWithNoGroupSelector;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static readonly List<SoundGroupCommand> GroupCommandsWithNoAllGroupSelector;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0EFF4", Offset = "0xA0EFF4")]
		private static bool <AppIsShuttingDown>k__BackingField;

		[Token(Token = "0x1700005C")]
		public static float PlaylistMasterVolume
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x19DEF9C", Offset = "0x19DEF9C", VA = "0x19DEF9C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x19C57AC", Offset = "0x19C57AC", VA = "0x19C57AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public static bool LogSoundsEnabled
		{
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x19DFC3C", Offset = "0x19DFC3C", VA = "0x19DFC3C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x19DFCA4", Offset = "0x19DFCA4", VA = "0x19DFCA4")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public static bool LogOutOfVoices
		{
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x19D3554", Offset = "0x19D3554", VA = "0x19D3554")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000348")]
			[Address(RVA = "0x19DFD14", Offset = "0x19DFD14", VA = "0x19DFD14")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public static Transform VideoPlayerSoundGroupTransform
		{
			[Token(Token = "0x600035D")]
			[Address(RVA = "0x19CEC3C", Offset = "0x19CEC3C", VA = "0x19CEC3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		public static List<AudioSource> MasterAudioSources
		{
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x19E0E54", Offset = "0x19E0E54", VA = "0x19E0E54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		public static Transform ListenerTrans
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x19ABF44", Offset = "0x19ABF44", VA = "0x19ABF44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		public static PlaylistController OnlyPlaylistController
		{
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x19E0FB4", Offset = "0x19E0FB4", VA = "0x19E0FB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		public static bool IsWarming
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x19BACD8", Offset = "0x19BACD8", VA = "0x19BACD8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000064")]
		public static bool MixerMuted
		{
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x19E106C", Offset = "0x19E106C", VA = "0x19E106C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x19DC848", Offset = "0x19DC848", VA = "0x19DC848")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public static bool PlaylistsMuted
		{
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x19E10D4", Offset = "0x19E10D4", VA = "0x19E10D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x19DDB04", Offset = "0x19DDB04", VA = "0x19DDB04")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public bool EnableMusicDucking
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x19E113C", Offset = "0x19E113C", VA = "0x19E113C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x19E1144", Offset = "0x19E1144", VA = "0x19E1144")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public float MasterCrossFadeTime
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x19E1150", Offset = "0x19E1150", VA = "0x19E1150")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000068")]
		public static List<Playlist> MusicPlaylists
		{
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x19DD730", Offset = "0x19DD730", VA = "0x19DD730")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		public static List<GroupBus> GroupBuses
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x19D9F38", Offset = "0x19D9F38", VA = "0x19D9F38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		public static List<string> RuntimeSoundGroupNames
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x19BFBF8", Offset = "0x19BFBF8", VA = "0x19BFBF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		public static List<string> RuntimeBusNames
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x19C27E0", Offset = "0x19C27E0", VA = "0x19C27E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006C")]
		public static MasterAudio SafeInstance
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x19A9128", Offset = "0x19A9128", VA = "0x19A9128")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		public static MasterAudio Instance
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x19AA0A8", Offset = "0x19AA0A8", VA = "0x19AA0A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x19E1158", Offset = "0x19E1158", VA = "0x19E1158")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public static bool SoundsReady
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x19B4594", Offset = "0x19B4594", VA = "0x19B4594")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006F")]
		public static bool AppIsShuttingDown
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x19E11C0", Offset = "0x19E11C0", VA = "0x19E11C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F488", Offset = "0xA0F488")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x19E1224", Offset = "0x19E1224", VA = "0x19E1224")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F498", Offset = "0xA0F498")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public List<string> GroupNames
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x19E1290", Offset = "0x19E1290", VA = "0x19E1290")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		public static List<string> SoundGroupHardCodedNames
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x19AB850", Offset = "0x19AB850", VA = "0x19AB850")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		public List<string> BusNames
		{
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x19E164C", Offset = "0x19E164C", VA = "0x19E164C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		public List<string> PlaylistNames
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x19E179C", Offset = "0x19E179C", VA = "0x19E179C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		public List<string> PlaylistNamesOnly
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x19E18EC", Offset = "0x19E18EC", VA = "0x19E18EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		public Transform Trans
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x19AC6D8", Offset = "0x19AC6D8", VA = "0x19AC6D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			[Token(Token = "0x600037A")]
			[Address(RVA = "0x19E1A04", Offset = "0x19E1A04", VA = "0x19E1A04")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000077")]
		public List<string> CustomEventNames
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x19E1A0C", Offset = "0x19E1A0C", VA = "0x19E1A0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		public List<string> CustomEventNamesOnly
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x19E1BDC", Offset = "0x19E1BDC", VA = "0x19E1BDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		public static List<string> CustomEventHardCodedNames
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x19E1B0C", Offset = "0x19E1B0C", VA = "0x19E1B0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		public static float MasterVolumeLevel
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x19E1D24", Offset = "0x19E1D24", VA = "0x19E1D24")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x19C5638", Offset = "0x19C5638", VA = "0x19C5638")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		private static bool SceneHasMasterAudio
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x19D19BC", Offset = "0x19D19BC", VA = "0x19D19BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007C")]
		public static bool IgnoreTimeScale
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x19E1D8C", Offset = "0x19E1D8C", VA = "0x19E1D8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007D")]
		public static SystemLanguage DynamicLanguage
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x19AE49C", Offset = "0x19AE49C", VA = "0x19AE49C")]
			get
			{
				return default(SystemLanguage);
			}
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x19E1DF4", Offset = "0x19E1DF4", VA = "0x19E1DF4")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public static float ReprioritizeTime
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x19E1ECC", Offset = "0x19E1ECC", VA = "0x19E1ECC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700007F")]
		public static bool ShouldRescanGroups
		{
			[Token(Token = "0x6000387")]
			[Address(RVA = "0x19E2010", Offset = "0x19E2010", VA = "0x19E2010")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000080")]
		public static string ProspectiveMAPath
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0x19E20EC", Offset = "0x19E20EC", VA = "0x19E20EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x19E2150", Offset = "0x19E2150", VA = "0x19E2150")]
			set
			{
			}
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x19CC904", Offset = "0x19CC904", VA = "0x19CC904")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xA0F354", Offset = "0xA0F354")]
		private static void Init()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x19CC9A0", Offset = "0x19CC9A0", VA = "0x19CC9A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x19CEE8C", Offset = "0x19CEE8C", VA = "0x19CEE8C")]
		private void Start()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x19CF034", Offset = "0x19CF034", VA = "0x19CF034")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x19CF320", Offset = "0x19CF320", VA = "0x19CF320")]
		private void Update()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x19D0BC0", Offset = "0x19D0BC0", VA = "0x19D0BC0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x19D0C64", Offset = "0x19D0C64", VA = "0x19D0C64")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x19D0BD0", Offset = "0x19D0BD0", VA = "0x19D0BD0")]
		private void ManualUpdate()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x19CECC8", Offset = "0x19CECC8", VA = "0x19CECC8")]
		public string SoundGroupForWarming()
		{
			return null;
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x19D119C", Offset = "0x19D119C", VA = "0x19D119C")]
		public static void RegisterUpdaterForUpdates(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x19D1280", Offset = "0x19D1280", VA = "0x19D1280")]
		public static void UnregisterUpdaterForUpdates(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x19D0FDC", Offset = "0x19D0FDC", VA = "0x19D0FDC")]
		private void UpdateActiveVariations()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x19D130C", Offset = "0x19D130C", VA = "0x19D130C")]
		private static void UpdateRefillTime(string sType, float inactivePeriodSeconds)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x19D0C78", Offset = "0x19D0C78", VA = "0x19D0C78")]
		private static void RecalcClosestColliderPositions()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x19D0A34", Offset = "0x19D0A34", VA = "0x19D0A34")]
		private static void TrackVideoPlayers()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x19D0954", Offset = "0x19D0954", VA = "0x19D0954")]
		private static void FireCustomEventsWaiting()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x19D0624", Offset = "0x19D0624", VA = "0x19D0624")]
		private static void RefillInactiveGroupPools()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x19CF3B8", Offset = "0x19CF3B8", VA = "0x19CF3B8")]
		private static void PerformOcclusionFrequencyChanges()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x19CF71C", Offset = "0x19CF71C", VA = "0x19CF71C")]
		private void PerformBusFades()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x19CFC90", Offset = "0x19CFC90", VA = "0x19CFC90")]
		private void PerformGroupFades()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x19D0268", Offset = "0x19D0268", VA = "0x19D0268")]
		public static void PerformDelayedAmbientTriggers()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x19D0054", Offset = "0x19D0054", VA = "0x19D0054")]
		private void PerformGroupPitchGlides()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x19CFA80", Offset = "0x19CFA80", VA = "0x19CFA80")]
		private void PerformBusPitchGlides()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x19D191C", Offset = "0x19D191C", VA = "0x19D191C")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x19B2890", Offset = "0x19B2890", VA = "0x19B2890")]
		public static bool PlaySoundAndForget(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x19BD5EC", Offset = "0x19BD5EC", VA = "0x19BD5EC")]
		public static PlaySoundResult PlaySound(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x19D2654", Offset = "0x19D2654", VA = "0x19D2654")]
		public static bool PlaySound3DAtVector3AndForget(string sType, Vector3 sourcePosition, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x19D2818", Offset = "0x19D2818", VA = "0x19D2818")]
		public static PlaySoundResult PlaySound3DAtVector3(string sType, Vector3 sourcePosition, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return null;
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x19AF8E0", Offset = "0x19AF8E0", VA = "0x19AF8E0")]
		public static bool PlaySound3DAtTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x19AFB74", Offset = "0x19AFB74", VA = "0x19AFB74")]
		public static PlaySoundResult PlaySound3DAtTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x19AFE34", Offset = "0x19AFE34", VA = "0x19AFE34")]
		public static bool PlaySound3DFollowTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x19B00C8", Offset = "0x19B00C8", VA = "0x19B00C8")]
		public static PlaySoundResult PlaySound3DFollowTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x19D2A04", Offset = "0x19D2A04", VA = "0x19D2A04")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0F368", Offset = "0xA0F368")]
		public static IEnumerator PlaySoundAndWaitUntilFinished(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x19B03A0", Offset = "0x19B03A0", VA = "0x19B03A0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0F3C8", Offset = "0xA0F3C8")]
		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x19B0558", Offset = "0x19B0558", VA = "0x19B0558")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0F428", Offset = "0xA0F428")]
		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x19D2630", Offset = "0x19D2630", VA = "0x19D2630")]
		public static bool PSRAsSuccessBool(PlaySoundResult psr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x19D1A58", Offset = "0x19D1A58", VA = "0x19D1A58")]
		private static PlaySoundResult PlaySoundAtVolume(string sType, float volumePercentage, Vector3 sourcePosition, double? timeToSchedulePlay, [Optional] float? pitch, [Optional] Transform sourceTrans, [Optional] string variationName, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, bool isChaining = false, bool isSingleSubscribedPlay = false, bool triggeredAsChildGroup = false)
		{
			return null;
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x19D4F24", Offset = "0x19D4F24", VA = "0x19D4F24")]
		private static PlaySoundResult TryPlayVariationOrOtherMatches(string sType, float volumePercentage, Vector3 sourcePosition, double? timeToSchedulePlay, float? pitch, Transform sourceTrans, bool attachToSource, float delaySoundTime, bool useVector3, bool makePlaySoundResult, bool isChaining, bool isSingleSubscribedPlay, AudioInfo randomSource, SoundGroupVariation busVoiceToStop, GroupBus groupBus, bool canUseBusVoiceToStop, bool forgetSoundPlayedOrScheduled, AudioGroupInfo group, bool isNonSpecific, int? randomIndex, List<int> choices, int pickedChoice, bool loggingEnabledForGrp, bool isSingleVarLoop, List<int> otherChoices, bool hasRefilledPool, List<AudioInfo> sources, out bool soundSuccess)
		{
			return null;
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x19D4AEC", Offset = "0x19D4AEC", VA = "0x19D4AEC")]
		private static bool CanPlayDialogBasedOnImportanceOrIsNotDialog(string sType, AudioGroupInfo group, bool loggingEnabledForGrp, AudioInfo randomSource)
		{
			return default(bool);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x19D3C1C", Offset = "0x19D3C1C", VA = "0x19D3C1C")]
		private static AudioInfo UseOnlyVariationIfOnlyOne(string sType, List<AudioInfo> sources, bool loggingEnabledForGrp, AudioInfo randomSource, MasterAudioGroup maGroup, ref bool isSingleVarLoop)
		{
			return null;
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x19D481C", Offset = "0x19D481C", VA = "0x19D481C")]
		private static bool IsActorTooFarAwayToPlay(string sType, Transform sourceTrans, AudioGroupInfo group, AudioInfo randomSource, bool loggingEnabledForGrp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x19D469C", Offset = "0x19D469C", VA = "0x19D469C")]
		private static bool VariationPassesProbabilityToPlayCheck(string sType, float volumePercentage, float? pitch, Transform sourceTrans, bool attachToSource, bool isChaining, AudioInfo randomSource, bool loggingEnabledForGrp, AudioGroupInfo group, bool isNonSpecific, int? randomIndex, List<int> choices, int pickedChoice)
		{
			return default(bool);
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x19D44A4", Offset = "0x19D44A4", VA = "0x19D44A4")]
		private static bool IsNoClipSilentPlay(string sType, float volumePercentage, float? pitch, Transform sourceTrans, bool attachToSource, bool isChaining, AudioInfo randomSource, bool loggingEnabledForGrp, AudioGroupInfo group, bool isNonSpecific, int? randomIndex, List<int> choices, int pickedChoice)
		{
			return default(bool);
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x19D42F8", Offset = "0x19D42F8", VA = "0x19D42F8")]
		private static bool VariationIsUsable(AudioInfo randomSource)
		{
			return default(bool);
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x19D3D44", Offset = "0x19D3D44", VA = "0x19D3D44")]
		private static bool CanFindVariationToPlay(string sType, string variationName, bool isNonSpecific, bool canUseBusVoiceToStop, List<AudioInfo> sources, bool loggingEnabledForGrp, SoundGroupVariation busVoiceToStop, ref AudioInfo randomSource, ref List<int> choices, ref int? randomIndex, ref int pickedChoice, ref List<int> otherChoices)
		{
			return default(bool);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x19D3814", Offset = "0x19D3814", VA = "0x19D3814")]
		private static SoundGroupVariation FindBusVoiceToStop(GroupBus groupBus, MasterAudioGroup group)
		{
			return null;
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x19D36FC", Offset = "0x19D36FC", VA = "0x19D36FC")]
		private static bool CanStopLimitedBusVoice(GroupBus groupBus, bool loggingEnabledForGrp, AudioGroupInfo group)
		{
			return default(bool);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x19D36D4", Offset = "0x19D36D4", VA = "0x19D36D4")]
		private static bool IsBusVoiceLimited(GroupBus groupBus)
		{
			return default(bool);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x19D334C", Offset = "0x19D334C", VA = "0x19D334C")]
		private static AudioInfo FindRetriggerableVariationInGroup(string variationName, bool isNonSpecific, List<AudioInfo> sources, MasterAudioGroup maGroup)
		{
			return null;
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x19D32E8", Offset = "0x19D32E8", VA = "0x19D32E8")]
		private static bool IsGroupPolyphonyLimited(MasterAudioGroup maGroup, AudioGroupInfo group)
		{
			return default(bool);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x19D316C", Offset = "0x19D316C", VA = "0x19D316C")]
		private static bool IsReplayLimited(string sType, MasterAudioGroup maGroup, AudioGroupInfo group, bool loggingEnabledForGrp)
		{
			return default(bool);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x19D2F54", Offset = "0x19D2F54", VA = "0x19D2F54")]
		private static void LogIfSilentPlay(string sType, bool loggingEnabledForGrp, MasterAudioGroup maGroup)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x19D2E70", Offset = "0x19D2E70", VA = "0x19D2E70")]
		private static bool SoundGroupHasVariations(string sType, List<AudioInfo> sources, bool loggingEnabledForGrp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x19D2AD4", Offset = "0x19D2AD4", VA = "0x19D2AD4")]
		private static bool IsSoundGroupValidAndReady(string sType, Transform sourceTrans)
		{
			return default(bool);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x19D5EB0", Offset = "0x19D5EB0", VA = "0x19D5EB0")]
		private static void MaybeChainNextVar(bool isChaining, SoundGroupVariation variation, float volumePercentage, float? pitch, Transform sourceTrans, bool attachToSource)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x19D5508", Offset = "0x19D5508", VA = "0x19D5508")]
		private static void SetLastPlayed(AudioGroupInfo grp)
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x19D5C58", Offset = "0x19D5C58", VA = "0x19D5C58")]
		private static void RemoveClipAndRefillIfEmpty(AudioGroupInfo grp, bool isNonSpecific, int? randomIndex, List<int> choices, string sType, int pickedChoice, bool loggingEnabledForGrp, bool isSingleVarLoop)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x19D5544", Offset = "0x19D5544", VA = "0x19D5544")]
		private static PlaySoundResult PlaySoundIfAvailable(AudioInfo info, Vector3 sourcePosition, float volumePercentage, SoundGroupVariation busVoiceToStop, GroupBus groupBus, bool canUseBusVoiceToStop, ref bool forgetSoundPlayed, [Optional] float? pitch, [Optional] AudioGroupInfo audioGroup, [Optional] Transform sourceTrans, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x19D6844", Offset = "0x19D6844", VA = "0x19D6844")]
		private static void FadeOldestOrFarthestBusVoice(SoundGroupVariation busVoiceToStop, GroupBus groupBus)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x19D6930", Offset = "0x19D6930", VA = "0x19D6930")]
		public static void EndDucking(SoundGroupVariationUpdater actorUpdater)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x19D69E0", Offset = "0x19D69E0", VA = "0x19D69E0")]
		public static void DuckSoundGroup(string soundGroupName, AudioSource aSource, SoundGroupVariationUpdater actorUpdater)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x19D6BD8", Offset = "0x19D6BD8", VA = "0x19D6BD8")]
		private static void StopPauseOrUnpauseSoundsOfTransform(Transform trans, List<AudioInfo> varList, VariationCommand varCmd)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x19B0E10", Offset = "0x19B0E10", VA = "0x19B0E10")]
		public static void StopAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x19A9970", Offset = "0x19A9970", VA = "0x19A9970")]
		public static void StopSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x19B06B0", Offset = "0x19B06B0", VA = "0x19B06B0")]
		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x19B0BC0", Offset = "0x19B0BC0", VA = "0x19B0BC0")]
		public static void PauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x19B1440", Offset = "0x19B1440", VA = "0x19B1440")]
		public static void UnpauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x19B1950", Offset = "0x19B1950", VA = "0x19B1950")]
		public static void UnpauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x19C1578", Offset = "0x19C1578", VA = "0x19C1578")]
		public static void FadeOutAllSoundsOfTransform(Transform sourceTrans, float fadeTime)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x19A9B60", Offset = "0x19A9B60", VA = "0x19A9B60")]
		public static void FadeOutSoundGroupOfTransform(Transform sourceTrans, string sType, float fadeTime)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x19C0DE0", Offset = "0x19C0DE0", VA = "0x19C0DE0")]
		public static void StopAllOfSound(string sType)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x19BFE48", Offset = "0x19BFE48", VA = "0x19BFE48")]
		public static void FadeOutAllOfSound(string sType, float fadeTime)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x19D6E94", Offset = "0x19D6E94", VA = "0x19D6E94")]
		public static List<SoundGroupVariation> GetAllPlayingVariations()
		{
			return null;
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x19AF4D0", Offset = "0x19AF4D0", VA = "0x19AF4D0")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(Transform sourceTrans)
		{
			return null;
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x19D718C", Offset = "0x19D718C", VA = "0x19D718C")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransformList(List<Transform> sourceTransList)
		{
			return null;
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x19D756C", Offset = "0x19D756C", VA = "0x19D756C")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsInBus(string busName)
		{
			return null;
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x19D77A4", Offset = "0x19D77A4", VA = "0x19D77A4")]
		public static void DeleteGroupVariation(string sType, string variationName)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x19D8628", Offset = "0x19D8628", VA = "0x19D8628")]
		public static void CreateGroupVariationFromClip(string sType, AudioClip clip, string variationName, float volume = 1f, float pitch = 1f)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x19D8CF0", Offset = "0x19D8CF0", VA = "0x19D8CF0")]
		public static void ChangeVariationPitch(string sType, bool changeAllVariations, string variationName, float pitch)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x19D90B4", Offset = "0x19D90B4", VA = "0x19D90B4")]
		public static void ChangeVariationVolume(string sType, bool changeAllVariations, string variationName, float volume)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x19D9404", Offset = "0x19D9404", VA = "0x19D9404")]
		public static void ChangeVariationClipFromResources(string sType, bool changeAllVariations, string variationName, string resourceFileName)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x19D95F8", Offset = "0x19D95F8", VA = "0x19D95F8")]
		public static void ChangeVariationClip(string sType, bool changeAllVariations, string variationName, AudioClip clip)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x19D98CC", Offset = "0x19D98CC", VA = "0x19D98CC")]
		public static void GradualOcclusionFreqChange(SoundGroupVariation variation, float fadeTime, float newCutoffFreq)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x19D9BE0", Offset = "0x19D9BE0", VA = "0x19D9BE0")]
		public static AudioSource GetNextVariationForSoundGroup(string sType)
		{
			return null;
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x19BFD0C", Offset = "0x19BFD0C", VA = "0x19BFD0C")]
		public static bool IsSoundGroupPlaying(string sType)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x19B1BB0", Offset = "0x19B1BB0", VA = "0x19B1BB0")]
		public static bool IsTransformPlayingSoundGroup(string sType, Transform sourceTrans)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x19C1794", Offset = "0x19C1794", VA = "0x19C1794")]
		public static void RouteGroupToBus(string sType, string busName)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x19DA240", Offset = "0x19DA240", VA = "0x19DA240")]
		public static float GetVariationLength(string sType, string variationName)
		{
			return default(float);
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x19C00D0", Offset = "0x19C00D0", VA = "0x19C00D0")]
		public static void RefillSoundGroupPool(string sType)
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x19DAA38", Offset = "0x19DAA38", VA = "0x19DAA38")]
		public static bool SoundGroupExists(string sType)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x19C0AE4", Offset = "0x19C0AE4", VA = "0x19C0AE4")]
		public static void PauseSoundGroup(string sType)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x19DAAE0", Offset = "0x19DAAE0", VA = "0x19DAAE0")]
		public static void SetGroupSpatialBlend(string sType)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x19DAC58", Offset = "0x19DAC58", VA = "0x19DAC58")]
		public static void RouteGroupToUnityMixerGroup(string sType, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x19C1290", Offset = "0x19C1290", VA = "0x19C1290")]
		public static void UnpauseSoundGroup(string sType)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x19C0570", Offset = "0x19C0570", VA = "0x19C0570")]
		public static void FadeSoundGroupToVolume(string sType, float newVolume, float fadeTime, [Optional] Action completionCallback, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x19C2600", Offset = "0x19C2600", VA = "0x19C2600")]
		public static void FadeOutOldSoundGroupVoices(string sType, float minimumPlayTime, float fadeTime)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x19C2440", Offset = "0x19C2440", VA = "0x19C2440")]
		public static void StopOldSoundGroupVoices(string sType, float minimumPlayTime)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x19C1E84", Offset = "0x19C1E84", VA = "0x19C1E84")]
		public static void GlideSoundGroupByPitch(string sType, float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x19B5448", Offset = "0x19B5448", VA = "0x19B5448")]
		public static void DeleteSoundGroup(string sType)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x19B6358", Offset = "0x19B6358", VA = "0x19B6358")]
		public static Transform CreateSoundGroup(DynamicSoundGroup aGroup, string creatorObjectName, bool errorOnExisting = true)
		{
			return null;
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x19DB06C", Offset = "0x19DB06C", VA = "0x19DB06C")]
		public static float GetGroupVolume(string sType)
		{
			return default(float);
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x19D14AC", Offset = "0x19D14AC", VA = "0x19D14AC")]
		public static void SetGroupVolume(string sType, float volumeLevel)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x19C0998", Offset = "0x19C0998", VA = "0x19C0998")]
		public static void MuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x19C1180", Offset = "0x19C1180", VA = "0x19C1180")]
		public static void UnmuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x19CE978", Offset = "0x19CE978", VA = "0x19CE978")]
		private static void AddRuntimeGroupInfo(string groupName, AudioGroupInfo groupInfo)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x19DB3D8", Offset = "0x19DB3D8", VA = "0x19DB3D8")]
		private static void FireAudioSourcesNumberChangedEvent()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x19DB250", Offset = "0x19DB250", VA = "0x19DB250")]
		public static void TrackRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x19CF0D8", Offset = "0x19CF0D8", VA = "0x19CF0D8")]
		public static void StopTrackingRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x19DADF0", Offset = "0x19DADF0", VA = "0x19DADF0")]
		private static void RemoveRuntimeGroupInfo(string groupName)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x19DB47C", Offset = "0x19DB47C", VA = "0x19DB47C")]
		private static void RescanChildren(MasterAudioGroup group)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x19DB12C", Offset = "0x19DB12C", VA = "0x19DB12C")]
		private static void SetGroupMuteStatus(MasterAudioGroup aGroup, string sType, bool isMute)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x19C0C90", Offset = "0x19C0C90", VA = "0x19C0C90")]
		public static void SoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x19B5C18", Offset = "0x19B5C18", VA = "0x19B5C18")]
		public static void SilenceOrUnsilenceGroupsFromSoloChange()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x19DB818", Offset = "0x19DB818", VA = "0x19DB818")]
		private static void UnsilenceNonSoloedGroups()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x19DB9C8", Offset = "0x19DB9C8", VA = "0x19DB9C8")]
		private static void UnsilenceGroup(string sType)
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x19DB660", Offset = "0x19DB660", VA = "0x19DB660")]
		private static void SilenceNonSoloedGroups()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x19DBB24", Offset = "0x19DBB24", VA = "0x19DBB24")]
		private static void SilenceGroup(string sType)
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x19C143C", Offset = "0x19C143C", VA = "0x19C143C")]
		public static void UnsoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x19A9624", Offset = "0x19A9624", VA = "0x19A9624")]
		public static MasterAudioGroup GrabGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x19DBC80", Offset = "0x19DBC80", VA = "0x19DBC80")]
		public static int VoicesForGroup(string sType)
		{
			return default(int);
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x19DBD80", Offset = "0x19DBD80", VA = "0x19DBD80")]
		public static Transform FindGroupTransform(string sType)
		{
			return null;
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x19DBFA0", Offset = "0x19DBFA0", VA = "0x19DBFA0")]
		public static List<AudioInfo> GetAllVariationsOfGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x19DC118", Offset = "0x19DC118", VA = "0x19DC118")]
		public static AudioGroupInfo GetGroupInfo(string sType)
		{
			return null;
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x19DC1FC", Offset = "0x19DC1FC", VA = "0x19DC1FC")]
		public static void SubscribeToLastVariationPlayed(string sType, Action finishedCallback)
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x19DC380", Offset = "0x19DC380", VA = "0x19DC380")]
		public static void UnsubscribeFromLastVariationPlayed(string sType)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x19DC478", Offset = "0x19DC478", VA = "0x19DC478")]
		public void SetSpatialBlendForMixer()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x19C5890", Offset = "0x19C5890", VA = "0x19C5890")]
		public static void PauseMixer()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x19C5A88", Offset = "0x19C5A88", VA = "0x19C5A88")]
		public static void UnpauseMixer()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x19C5C80", Offset = "0x19C5C80", VA = "0x19C5C80")]
		public static void StopMixer()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x19DC5D8", Offset = "0x19DC5D8", VA = "0x19DC5D8")]
		public static void UnsubscribeFromAllVariations()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x19C6050", Offset = "0x19C6050", VA = "0x19C6050")]
		public static void StopEverything()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x19C5F98", Offset = "0x19C5F98", VA = "0x19C5F98")]
		public static void PauseEverything()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x19C5FF4", Offset = "0x19C5FF4", VA = "0x19C5FF4")]
		public static void UnpauseEverything()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x19C5ED8", Offset = "0x19C5ED8", VA = "0x19C5ED8")]
		public static void MuteEverything()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x19C5F38", Offset = "0x19C5F38", VA = "0x19C5F38")]
		public static void UnmuteEverything()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x19DCC34", Offset = "0x19DCC34", VA = "0x19DCC34")]
		public static List<string> ListOfAudioClipsInGroupsEditTime()
		{
			return null;
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x19D1780", Offset = "0x19D1780", VA = "0x19D1780")]
		private static int GetBusIndex(string busName, bool alertMissing)
		{
			return default(int);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x19D9FA0", Offset = "0x19D9FA0", VA = "0x19D9FA0")]
		private static GroupBus GetBusByIndex(int busIndex)
		{
			return null;
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x19C41B4", Offset = "0x19C41B4", VA = "0x19C41B4")]
		public static void ChangeBusPitch(string busName, float pitch)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x19C39A0", Offset = "0x19C39A0", VA = "0x19C39A0")]
		public static void MuteBus(string busName)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x19C3B8C", Offset = "0x19C3B8C", VA = "0x19C3B8C")]
		public static void UnmuteBus(string busName, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x19C3D34", Offset = "0x19C3D34", VA = "0x19C3D34")]
		public static void ToggleMuteBus(string busName)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x19C34C0", Offset = "0x19C34C0", VA = "0x19C34C0")]
		public static void PauseBus(string busName)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x19C3E20", Offset = "0x19C3E20", VA = "0x19C3E20")]
		public static void SoloBus(string busName)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x19C400C", Offset = "0x19C400C", VA = "0x19C400C")]
		public static void UnsoloBus(string busName, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x19DCF00", Offset = "0x19DCF00", VA = "0x19DCF00")]
		public static void RouteBusToUnityMixerGroup(string busName, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x19D6494", Offset = "0x19D6494", VA = "0x19D6494")]
		private static SoundGroupVariation FindLeastImportantSoundOnBus(GroupBus bus, MasterAudioGroup group)
		{
			return null;
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x19D6164", Offset = "0x19D6164", VA = "0x19D6164")]
		private static SoundGroupVariation FindFarthestSoundOnBus(GroupBus bus)
		{
			return null;
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x19D5EE4", Offset = "0x19D5EE4", VA = "0x19D5EE4")]
		private static SoundGroupVariation FindOldestSoundOnBus(GroupBus bus)
		{
			return null;
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x19C3648", Offset = "0x19C3648", VA = "0x19C3648")]
		public static void StopBus(string busName)
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x19C3838", Offset = "0x19C3838", VA = "0x19C3838")]
		public static void UnpauseBus(string busName)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x19B6064", Offset = "0x19B6064", VA = "0x19B6064")]
		public static bool CreateBus(string busName, bool errorOnExisting = true, bool isTemporary = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x19B5290", Offset = "0x19B5290", VA = "0x19B5290")]
		public static void DeleteBusByName(string busName)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x19DD084", Offset = "0x19DD084", VA = "0x19DD084")]
		public static void DeleteBusByIndex(int busIndex)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x19D6784", Offset = "0x19D6784", VA = "0x19D6784")]
		public static float GetBusVolume(MasterAudioGroup maGroup)
		{
			return default(float);
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x19C2954", Offset = "0x19C2954", VA = "0x19C2954")]
		public static void FadeBusToVolume(string busName, float newVolume, float fadeTime, [Optional] Action completionCallback, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x19C4578", Offset = "0x19C4578", VA = "0x19C4578")]
		public static void FadeOutOldBusVoices(string busName, float minimumPlayTime, float fadeTime)
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x19C4368", Offset = "0x19C4368", VA = "0x19C4368")]
		public static void StopOldBusVoices(string busName, float minimumPlayTime)
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x19C2DA8", Offset = "0x19C2DA8", VA = "0x19C2DA8")]
		public static void GlideBusByPitch(string busName, float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x19CEB10", Offset = "0x19CEB10", VA = "0x19CEB10")]
		public static void SetBusVolumeByName(string busName, float newVolume)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x19DD39C", Offset = "0x19DD39C", VA = "0x19DD39C")]
		private static void RecalculateGroupVolumes(AudioGroupInfo aGroup, GroupBus bus)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x19DA048", Offset = "0x19DA048", VA = "0x19DA048")]
		private static void SetBusVolume(GroupBus bus, float newVolume)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x19B5F60", Offset = "0x19B5F60", VA = "0x19B5F60")]
		public static GroupBus GrabBusByName(string busName)
		{
			return null;
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x19B0978", Offset = "0x19B0978", VA = "0x19B0978")]
		public static void PauseBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x19B1708", Offset = "0x19B1708", VA = "0x19B1708")]
		public static void UnpauseBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x19B1138", Offset = "0x19B1138", VA = "0x19B1138")]
		public static void StopBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x19B7564", Offset = "0x19B7564", VA = "0x19B7564")]
		public static void AddSoundGroupToDuckList(string sType, float riseVolumeStart, float duckedVolCut, float unduckTime, bool isTemporary = false)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x19B532C", Offset = "0x19B532C", VA = "0x19B532C")]
		public static void RemoveSoundGroupFromDuckList(string sType)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x19DD574", Offset = "0x19DD574", VA = "0x19DD574")]
		public static Playlist GrabPlaylist(string playlistName, bool logErrorIfNotFound = true)
		{
			return null;
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x19DD798", Offset = "0x19DD798", VA = "0x19DD798")]
		public static void ChangePlaylistPitch(string playlistName, float pitch, [Optional] string songName)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x19DD8C8", Offset = "0x19DD8C8", VA = "0x19DD8C8")]
		public static void MutePlaylist()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x19BE624", Offset = "0x19BE624", VA = "0x19BE624")]
		public static void MutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x19BE5B8", Offset = "0x19BE5B8", VA = "0x19BE5B8")]
		public static void MuteAllPlaylists()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x19DDA1C", Offset = "0x19DDA1C", VA = "0x19DDA1C")]
		private static void MutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x19DDBF8", Offset = "0x19DDBF8", VA = "0x19DDBF8")]
		public static void UnmutePlaylist()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x19BE884", Offset = "0x19BE884", VA = "0x19BE884")]
		public static void UnmutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x19BE818", Offset = "0x19BE818", VA = "0x19BE818")]
		public static void UnmuteAllPlaylists()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x19DDC68", Offset = "0x19DDC68", VA = "0x19DDC68")]
		private static void UnmutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x19DDD50", Offset = "0x19DDD50", VA = "0x19DDD50")]
		public static void ToggleMutePlaylist()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x19BEAE4", Offset = "0x19BEAE4", VA = "0x19BEAE4")]
		public static void ToggleMutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x19BEA78", Offset = "0x19BEA78", VA = "0x19BEA78")]
		public static void ToggleMuteAllPlaylists()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x19DDDC0", Offset = "0x19DDDC0", VA = "0x19DDDC0")]
		private static void ToggleMutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x19DDE58", Offset = "0x19DDE58", VA = "0x19DDE58")]
		public static void PausePlaylist()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x19BF544", Offset = "0x19BF544", VA = "0x19BF544")]
		public static void PausePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x19BF4D8", Offset = "0x19BF4D8", VA = "0x19BF4D8")]
		public static void PauseAllPlaylists()
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x19DDEC8", Offset = "0x19DDEC8", VA = "0x19DDEC8")]
		private static void PausePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x19DDF60", Offset = "0x19DDF60", VA = "0x19DDF60")]
		public static void UnpausePlaylist()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x19BFA04", Offset = "0x19BFA04", VA = "0x19BFA04")]
		public static void UnpausePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x19BF998", Offset = "0x19BF998", VA = "0x19BF998")]
		public static void UnpauseAllPlaylists()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x19DDFD0", Offset = "0x19DDFD0", VA = "0x19DDFD0")]
		private static void UnpausePlaylists(List<PlaylistController> controllers)
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x19DE068", Offset = "0x19DE068", VA = "0x19DE068")]
		public static void StopPlaylist()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x19BF7A4", Offset = "0x19BF7A4", VA = "0x19BF7A4")]
		public static void StopPlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x19BF738", Offset = "0x19BF738", VA = "0x19BF738")]
		public static void StopAllPlaylists()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x19DE0D8", Offset = "0x19DE0D8", VA = "0x19DE0D8")]
		private static void StopPlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x19DE174", Offset = "0x19DE174", VA = "0x19DE174")]
		public static void TriggerNextPlaylistClip()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x19BF2E4", Offset = "0x19BF2E4", VA = "0x19BF2E4")]
		public static void TriggerNextPlaylistClip(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x19BF278", Offset = "0x19BF278", VA = "0x19BF278")]
		public static void TriggerNextClipAllPlaylists()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x19DE1E4", Offset = "0x19DE1E4", VA = "0x19DE1E4")]
		private static void NextPlaylistClips(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x19DE27C", Offset = "0x19DE27C", VA = "0x19DE27C")]
		public static void TriggerRandomPlaylistClip()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x19BF084", Offset = "0x19BF084", VA = "0x19BF084")]
		public static void TriggerRandomPlaylistClip(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x19BF018", Offset = "0x19BF018", VA = "0x19BF018")]
		public static void TriggerRandomClipAllPlaylists()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x19DE2EC", Offset = "0x19DE2EC", VA = "0x19DE2EC")]
		private static void RandomPlaylistClips(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x19DE384", Offset = "0x19DE384", VA = "0x19DE384")]
		public static void RestartPlaylist()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x19BD864", Offset = "0x19BD864", VA = "0x19BD864")]
		public static void RestartPlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x19BD7F8", Offset = "0x19BD7F8", VA = "0x19BD7F8")]
		public static void RestartAllPlaylists()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x19DE3F4", Offset = "0x19DE3F4", VA = "0x19DE3F4")]
		private static void RestartPlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x19DE490", Offset = "0x19DE490", VA = "0x19DE490")]
		public static void StartPlaylist(string playlistName)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x19DE50C", Offset = "0x19DE50C", VA = "0x19DE50C")]
		public static void StartPlaylistOnClip(string playlistName, string clipName)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x19BDA68", Offset = "0x19BDA68", VA = "0x19BDA68")]
		public static void StartPlaylist(string playlistControllerName, string playlistName, [Optional] string clipName)
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x19BDE44", Offset = "0x19BDE44", VA = "0x19BDE44")]
		public static void StopLoopingAllCurrentSongs()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x19DE62C", Offset = "0x19DE62C", VA = "0x19DE62C")]
		public static void StopLoopingCurrentSong()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x19BDEB0", Offset = "0x19BDEB0", VA = "0x19BDEB0")]
		public static void StopLoopingCurrentSong(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x19DE594", Offset = "0x19DE594", VA = "0x19DE594")]
		private static void StopLoopingCurrentSongs(List<PlaylistController> playlistControllers)
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x19BE0B4", Offset = "0x19BE0B4", VA = "0x19BE0B4")]
		public static void StopAllPlaylistsAfterCurrentSongs()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x19DE734", Offset = "0x19DE734", VA = "0x19DE734")]
		public static void StopPlaylistAfterCurrentSong()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x19BE120", Offset = "0x19BE120", VA = "0x19BE120")]
		public static void StopPlaylistAfterCurrentSong(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x19DE69C", Offset = "0x19DE69C", VA = "0x19DE69C")]
		private static void StopPlaylistAfterCurrentSongs(List<PlaylistController> playlistControllers)
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x19DE7A4", Offset = "0x19DE7A4", VA = "0x19DE7A4")]
		public static void QueuePlaylistClip(string clipName)
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x19BEE78", Offset = "0x19BEE78", VA = "0x19BEE78")]
		public static void QueuePlaylistClip(string playlistControllerName, string clipName)
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x19DE81C", Offset = "0x19DE81C", VA = "0x19DE81C")]
		public static bool TriggerPlaylistClip(string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x19BECD8", Offset = "0x19BECD8", VA = "0x19BECD8")]
		public static bool TriggerPlaylistClip(string playlistControllerName, string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x19DE894", Offset = "0x19DE894", VA = "0x19DE894")]
		public static void ChangePlaylistByName(string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x19BDC9C", Offset = "0x19BDC9C", VA = "0x19BDC9C")]
		public static void ChangePlaylistByName(string playlistControllerName, string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x19DE91C", Offset = "0x19DE91C", VA = "0x19DE91C")]
		public static void FadePlaylistToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x19BE3A8", Offset = "0x19BE3A8", VA = "0x19BE3A8")]
		public static void FadePlaylistToVolume(string playlistControllerName, float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x19BE324", Offset = "0x19BE324", VA = "0x19BE324")]
		public static void FadeAllPlaylistsToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x19DE9A4", Offset = "0x19DE9A4", VA = "0x19DE9A4")]
		private static void FadePlaylists(List<PlaylistController> playlists, float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x19B7D08", Offset = "0x19B7D08", VA = "0x19B7D08")]
		public static void CreatePlaylist(Playlist playlist, bool errorOnDuplicate)
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x19B5A38", Offset = "0x19B5A38", VA = "0x19B5A38")]
		public static void DeletePlaylist(string playlistName)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x19DEB08", Offset = "0x19DEB08", VA = "0x19DEB08")]
		public static void AddSongToPlaylist(string playlistName, AudioClip song, bool loopSong = false, float songPitch = 1f, float songVolume = 1f, [Optional] string alias)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x19DEC00", Offset = "0x19DEC00", VA = "0x19DEC00")]
		public static void AddSongToPlaylist(string playlistName, MusicSetting newSong)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x19DF004", Offset = "0x19DF004", VA = "0x19DF004")]
		public static void AudioListenerChanged(AudioListener listener)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x19B7ED0", Offset = "0x19B7ED0", VA = "0x19B7ED0")]
		public static void FireCustomEventNextFrame(string customEventName, Transform eventOrigin)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x19C6710", Offset = "0x19C6710", VA = "0x19C6710")]
		public static void AddCustomEventReceiver(ICustomEventReceiver receiver, Transform receiverTrans)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x19C6BA4", Offset = "0x19C6BA4", VA = "0x19C6BA4")]
		public static void RemoveCustomEventReceiver(ICustomEventReceiver receiver)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x19DF15C", Offset = "0x19DF15C", VA = "0x19DF15C")]
		public static List<Transform> ReceiversForEvent(string customEventName)
		{
			return null;
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x19B76E4", Offset = "0x19B76E4", VA = "0x19B76E4")]
		public static CustomEventCategory CreateCustomEventCategoryIfNotThere(string categoryName, bool isTemporary)
		{
			return null;
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x19B7944", Offset = "0x19B7944", VA = "0x19B7944")]
		public static void CreateCustomEvent(string customEventName, CustomEventReceiveMode eventReceiveMode, float distanceThreshold, EventReceiveFilter receiveFilter, int filterModeQty, string categoryName = "", bool isTemporary = false, bool errorOnDuplicate = true)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x19B583C", Offset = "0x19B583C", VA = "0x19B583C")]
		public static void DeleteCustomEvent(string customEventName)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x19DF474", Offset = "0x19DF474", VA = "0x19DF474")]
		public static CustomEvent GetCustomEventByName(string customEventName)
		{
			return null;
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x19C47A8", Offset = "0x19C47A8", VA = "0x19C47A8")]
		public static void FireCustomEvent(string customEventName, Transform originObject, bool logDupe = true)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x19C63AC", Offset = "0x19C63AC", VA = "0x19C63AC")]
		public static bool CustomEventExists(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x19DF5DC", Offset = "0x19DF5DC", VA = "0x19DF5DC")]
		private static List<ICustomEventReceiver> GetChildReceivers(Transform origin, string eventName, bool includeSelf)
		{
			return null;
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x19DF77C", Offset = "0x19DF77C", VA = "0x19DF77C")]
		private static List<ICustomEventReceiver> GetParentReceivers(Transform origin, string eventName, bool includeSelf)
		{
			return null;
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x19DF91C", Offset = "0x19DF91C", VA = "0x19DF91C")]
		private static List<ICustomEventReceiver> FilterOutSelf(List<ICustomEventReceiver> sourceList, Transform origin)
		{
			return null;
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x19D2D58", Offset = "0x19D2D58", VA = "0x19D2D58")]
		private static bool LoggingEnabledForGroup(MasterAudioGroup grp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x19D35BC", Offset = "0x19D35BC", VA = "0x19D35BC")]
		private static void LogMessage(string message)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x19AB104", Offset = "0x19AB104", VA = "0x19AB104")]
		public static void LogWarning(string msg)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x19AAEA8", Offset = "0x19AAEA8", VA = "0x19AAEA8")]
		public static void LogWarningIfNeverLogged(string msg, int errorNumber)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x19AEDA8", Offset = "0x19AEDA8", VA = "0x19AEDA8")]
		public static void LogError(string msg)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x19DFD84", Offset = "0x19DFD84", VA = "0x19DFD84")]
		public static void LogNoPlaylist(string playlistControllerName, string methodName)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x19DD938", Offset = "0x19DD938", VA = "0x19DD938")]
		private static bool IsOkToCallOnlyPlaylistMethod(List<PlaylistController> pcs, string methodName)
		{
			return default(bool);
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x19A8CBC", Offset = "0x19A8CBC", VA = "0x19A8CBC")]
		public static void SetupAmbientNextFrame(AmbientSound ambient)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x19A92E4", Offset = "0x19A92E4", VA = "0x19A92E4")]
		public static void RemoveDelayedAmbient(AmbientSound ambient)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x19DFF9C", Offset = "0x19DFF9C", VA = "0x19DFF9C")]
		public static void QueueTransformFollowerForColliderPositionRecalc(TransformFollower follower)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x19E01F8", Offset = "0x19E01F8", VA = "0x19E01F8")]
		public static void AddToQueuedOcclusionRays(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x19E0454", Offset = "0x19E0454", VA = "0x19E0454")]
		public static void AddToOcclusionInRangeSources(GameObject src)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x19E065C", Offset = "0x19E065C", VA = "0x19E065C")]
		public static void AddToOcclusionOutOfRangeSources(GameObject src)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x19E0A0C", Offset = "0x19E0A0C", VA = "0x19E0A0C")]
		public static void AddToBlockedOcclusionSources(GameObject src)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x19CB004", Offset = "0x19CB004", VA = "0x19CB004")]
		public static bool HasQueuedOcclusionRays()
		{
			return default(bool);
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x19CB088", Offset = "0x19CB088", VA = "0x19CB088")]
		public static SoundGroupVariationUpdater OldestQueuedOcclusionRay()
		{
			return null;
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x19D9A98", Offset = "0x19D9A98", VA = "0x19D9A98")]
		public static bool IsOcclusionFreqencyTransitioning(SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x19D8490", Offset = "0x19D8490", VA = "0x19D8490")]
		public static void RemoveFromOcclusionFrequencyTransitioning(SoundGroupVariation variation)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x19E0884", Offset = "0x19E0884", VA = "0x19E0884")]
		public static void RemoveFromBlockedOcclusionSources(GameObject src)
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x19E0B94", Offset = "0x19E0B94", VA = "0x19E0B94")]
		public static void StopTrackingOcclusionForSource(GameObject src)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x19E0E04", Offset = "0x19E0E04", VA = "0x19E0E04")]
		public static bool IsVideoPlayersGroup(string groupName)
		{
			return default(bool);
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x19D6DD0", Offset = "0x19D6DD0", VA = "0x19D6DD0")]
		private static bool IsLinkedGroupPlay(SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x19E0EBC", Offset = "0x19E0EBC", VA = "0x19E0EBC")]
		public static int RemainingClipsInGroup(string sType)
		{
			return default(int);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x19DB000", Offset = "0x19DB000", VA = "0x19DB000")]
		public static void RescanGroupsNow()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x19E1FA8", Offset = "0x19E1FA8", VA = "0x19E1FA8")]
		public static void DoneRescanningGroups()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x19E21BC", Offset = "0x19E21BC", VA = "0x19E21BC")]
		public static GameObject CreateMasterAudio()
		{
			return null;
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x19E2378", Offset = "0x19E2378", VA = "0x19E2378")]
		public static GameObject CreatePlaylistController()
		{
			return null;
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x19E2534", Offset = "0x19E2534", VA = "0x19E2534")]
		public static GameObject CreateDynamicSoundGroupCreator()
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x19E26F0", Offset = "0x19E26F0", VA = "0x19E26F0")]
		public static GameObject CreateSoundGroupOrganizer()
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x19E28AC", Offset = "0x19E28AC", VA = "0x19E28AC")]
		public MasterAudio()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public static class PersistentAudioSettings
	{
		[Token(Token = "0x400041A")]
		public const string SfxVolKey = "MA_sfxVolume";

		[Token(Token = "0x400041B")]
		public const string MusicVolKey = "MA_musicVolume";

		[Token(Token = "0x400041C")]
		public const string SfxMuteKey = "MA_sfxMute";

		[Token(Token = "0x400041D")]
		public const string MusicMuteKey = "MA_musicMute";

		[Token(Token = "0x400041E")]
		public const string BusVolKey = "MA_BusVolume_";

		[Token(Token = "0x400041F")]
		public const string GroupVolKey = "MA_GroupVolume_";

		[Token(Token = "0x4000420")]
		public const string BusKeysKey = "MA_BusKeys";

		[Token(Token = "0x4000421")]
		public const string GroupKeysKey = "MA_GroupsKeys";

		[Token(Token = "0x4000422")]
		public const string Separator = ";";

		[Token(Token = "0x17000081")]
		public static string BusesUpdatedKeys
		{
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x23541B4", Offset = "0x23541B4", VA = "0x23541B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x2354230", Offset = "0x2354230", VA = "0x2354230")]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public static string GroupsUpdatedKeys
		{
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x2354360", Offset = "0x2354360", VA = "0x2354360")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x23543DC", Offset = "0x23543DC", VA = "0x23543DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public static bool? MixerMuted
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0x2354688", Offset = "0x2354688", VA = "0x2354688")]
			get
			{
				return null;
			}
			[Token(Token = "0x600039B")]
			[Address(RVA = "0x2354720", Offset = "0x2354720", VA = "0x2354720")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public static float? MixerVolume
		{
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x2354880", Offset = "0x2354880", VA = "0x2354880")]
			get
			{
				return null;
			}
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x2354910", Offset = "0x2354910", VA = "0x2354910")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public static bool? MusicMuted
		{
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x2354A64", Offset = "0x2354A64", VA = "0x2354A64")]
			get
			{
				return null;
			}
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x2354AFC", Offset = "0x2354AFC", VA = "0x2354AFC")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public static float? MusicVolume
		{
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x2354C5C", Offset = "0x2354C5C", VA = "0x2354C5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x2354CEC", Offset = "0x2354CEC", VA = "0x2354CEC")]
			set
			{
			}
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x2353FCC", Offset = "0x2353FCC", VA = "0x2353FCC")]
		public static void SetBusVolume(string busName, float vol)
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x2354164", Offset = "0x2354164", VA = "0x2354164")]
		public static string MakeBusKey(string busName)
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x2354280", Offset = "0x2354280", VA = "0x2354280")]
		public static float? GetBusVolume(string busName)
		{
			return null;
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x2354310", Offset = "0x2354310", VA = "0x2354310")]
		public static string GetGroupKey(string groupName)
		{
			return null;
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x235442C", Offset = "0x235442C", VA = "0x235442C")]
		public static void SetGroupVolume(string grpName, float vol)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x23545F8", Offset = "0x23545F8", VA = "0x23545F8")]
		public static float? GetGroupVolume(string grpName)
		{
			return null;
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x2354E40", Offset = "0x2354E40", VA = "0x2354E40")]
		public static void RestoreMasterSettings()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class SoundGroupOrganizer : MonoBehaviour
	{
		[Token(Token = "0x20000F3")]
		public class CustomEventSelection
		{
			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CustomEvent Event;

			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool IsSelected;

			[Token(Token = "0x600052B")]
			[Address(RVA = "0x2443EE4", Offset = "0x2443EE4", VA = "0x2443EE4")]
			public CustomEventSelection(CustomEvent cEvent, bool isSelected)
			{
			}
		}

		[Token(Token = "0x20000F4")]
		public class SoundGroupSelection
		{
			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject Go;

			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool IsSelected;

			[Token(Token = "0x600052C")]
			[Address(RVA = "0x2443F30", Offset = "0x2443F30", VA = "0x2443F30")]
			public SoundGroupSelection(GameObject go, bool isSelected)
			{
			}
		}

		[Token(Token = "0x20000F5")]
		public enum MAItemType
		{
			[Token(Token = "0x40006AD")]
			SoundGroups,
			[Token(Token = "0x40006AE")]
			CustomEvents
		}

		[Token(Token = "0x20000F6")]
		public enum TransferMode
		{
			[Token(Token = "0x40006B0")]
			None,
			[Token(Token = "0x40006B1")]
			Import,
			[Token(Token = "0x40006B2")]
			Export
		}

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject dynGroupTemplate;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject dynVariationTemplate;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject maGroupTemplate;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject maVariationTemplate;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MasterAudio.DragGroupMode curDragGroupMode;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SystemLanguage previewLanguage;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useTextGroupFilter;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string textGroupFilter;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TransferMode transMode;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject sourceObject;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SoundGroupSelection> selectedSourceSoundGroups;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject destObject;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<SoundGroupSelection> selectedDestSoundGroups;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public MAItemType itemType;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<CustomEventSelection> selectedSourceCustomEvents;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<CustomEventSelection> selectedDestCustomEvents;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<CustomEvent> customEvents;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string newEventName;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x2436B30", Offset = "0x2436B30", VA = "0x2436B30")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x2436BA4", Offset = "0x2436BA4", VA = "0x2436BA4")]
		public SoundGroupOrganizer()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public static class AmbientUtil
	{
		[Token(Token = "0x20000F7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C200", Offset = "0xA0C200")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string variationName;

			[Token(Token = "0x600052D")]
			[Address(RVA = "0x24405D4", Offset = "0x24405D4", VA = "0x24405D4")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x600052E")]
			[Address(RVA = "0x24405DC", Offset = "0x24405DC", VA = "0x24405DC")]
			internal bool <InitAudioSourceFollower>b__0(SoundGroupVariation v)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000439")]
		public const string FollowerHolderName = "_Followers";

		[Token(Token = "0x400043A")]
		public const string ListenerFollowerName = "~ListenerFollower~";

		[Token(Token = "0x400043B")]
		public const float ListenerFollowerTrigRadius = 0.01f;

		[Token(Token = "0x400043C")]
		public const int IgnoreRaycastLayerNumber = 2;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Transform _followerHolder;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ListenerFollower _listenerFollower;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Rigidbody _listenerFollowerRB;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static List<TransformFollower> _transformFollowers;

		[Token(Token = "0x17000087")]
		public static ListenerFollower ListenerFollower
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x19AC160", Offset = "0x19AC160", VA = "0x19AC160")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000088")]
		public static Transform FollowerHolder
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x19ABA84", Offset = "0x19ABA84", VA = "0x19ABA84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		public static bool HasListenerFollower
		{
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x19ACA44", Offset = "0x19ACA44", VA = "0x19ACA44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008A")]
		public static int AmbientCount
		{
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x19ACAE4", Offset = "0x19ACAE4", VA = "0x19ACAE4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700008B")]
		public static bool HasListenerFolowerRigidBody
		{
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x19AB1B4", Offset = "0x19AB1B4", VA = "0x19AB1B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x19AB9D0", Offset = "0x19AB9D0", VA = "0x19AB9D0")]
		public static void InitFollowerHolder()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x19AAFD4", Offset = "0x19AAFD4", VA = "0x19AAFD4")]
		public static bool InitListenerFollower()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x19AC634", Offset = "0x19AC634", VA = "0x19AC634")]
		public static void RemoveTransformFollower(TransformFollower follower)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x19AB254", Offset = "0x19AB254", VA = "0x19AB254")]
		public static Transform InitAudioSourceFollower(Transform transToFollow, string followerName, string soundGroupName, string variationName, float volume, bool willFollowSource, bool willPositionOnClosestColliderPoint, bool useTopCollider, bool useChildColliders, MasterAudio.AmbientSoundExitMode exitMode, float exitFadeTime, MasterAudio.AmbientSoundReEnterMode reEnterMode, float reEnterFadeTime)
		{
			return null;
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x19AC78C", Offset = "0x19AC78C", VA = "0x19AC78C")]
		public static void ManualUpdate()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x19AC89C", Offset = "0x19AC89C", VA = "0x19AC89C")]
		private static void UpdateListenerFollower()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public static class ArrayListUtil
	{
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x19ACBEC", Offset = "0x19ACBEC", VA = "0x19ACBEC")]
		public static void SortIntArray(ref List<int> list)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x19ACD10", Offset = "0x19ACD10", VA = "0x19ACD10")]
		public static bool IsExcludedChildName(string name)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000080")]
	public static class AudioTransformExtensions
	{
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x19AF3F0", Offset = "0x19AF3F0", VA = "0x19AF3F0")]
		public static void FadeOutSoundGroupOfTransform(this Transform sourceTrans, string sType, float fadeTime)
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x19AF470", Offset = "0x19AF470", VA = "0x19AF470")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(this Transform sourceTrans)
		{
			return null;
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x19AF838", Offset = "0x19AF838", VA = "0x19AF838")]
		public static bool PlaySound3DAtTransformAndForget(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x19AFAB8", Offset = "0x19AFAB8", VA = "0x19AFAB8")]
		public static PlaySoundResult PlaySound3DAtTransform(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x19AFD8C", Offset = "0x19AFD8C", VA = "0x19AFD8C")]
		public static bool PlaySound3DFollowTransformAndForget(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x19B000C", Offset = "0x19B000C", VA = "0x19B000C")]
		public static PlaySoundResult PlaySound3DFollowTransform(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x19B02E0", Offset = "0x19B02E0", VA = "0x19B02E0")]
		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x19B0498", Offset = "0x19B0498", VA = "0x19B0498")]
		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x19B0650", Offset = "0x19B0650", VA = "0x19B0650")]
		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x19B0908", Offset = "0x19B0908", VA = "0x19B0908")]
		public static void PauseBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x19B0B50", Offset = "0x19B0B50", VA = "0x19B0B50")]
		public static void PauseSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x19B0DB0", Offset = "0x19B0DB0", VA = "0x19B0DB0")]
		public static void StopAllSoundsOfTransform(this Transform sourceTrans)
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x19B10C8", Offset = "0x19B10C8", VA = "0x19B10C8")]
		public static void StopBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x19B1370", Offset = "0x19B1370", VA = "0x19B1370")]
		public static void StopSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x19B13E0", Offset = "0x19B13E0", VA = "0x19B13E0")]
		public static void UnpauseAllSoundsOfTransform(this Transform sourceTrans)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x19B1698", Offset = "0x19B1698", VA = "0x19B1698")]
		public static void UnpauseBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x19B18E0", Offset = "0x19B18E0", VA = "0x19B18E0")]
		public static void UnpauseSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x19B1B40", Offset = "0x19B1B40", VA = "0x19B1B40")]
		public static bool IsTransformPlayingSoundGroup(this Transform sourceTrans, string sType)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000081")]
	public class AudioTransformTracker : MonoBehaviour
	{
		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int _frames;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform _trans;

		[Token(Token = "0x1700008C")]
		public Transform Trans
		{
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x19B1DC0", Offset = "0x19B1DC0", VA = "0x19B1DC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x19B1E60", Offset = "0x19B1E60", VA = "0x19B1E60")]
		private void Update()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x19B1E70", Offset = "0x19B1E70", VA = "0x19B1E70")]
		public AudioTransformTracker()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public static class AudioUtil
	{
		[Token(Token = "0x4000443")]
		public const float DefaultMinOcclusionCutoffFrequency = 22000f;

		[Token(Token = "0x4000444")]
		public const float DefaultMaxOcclusionCutoffFrequency = 0f;

		[Token(Token = "0x4000445")]
		private const float SemitonePitchChangeAmt = 1.0594635f;

		[Token(Token = "0x1700008D")]
		public static float FixedDeltaTime
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x19B1EF0", Offset = "0x19B1EF0", VA = "0x19B1EF0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700008E")]
		public static float FrameTime
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x19B1EF8", Offset = "0x19B1EF8", VA = "0x19B1EF8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700008F")]
		public static float Time
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x19B1F00", Offset = "0x19B1F00", VA = "0x19B1F00")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000090")]
		public static int FrameCount
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x19B1F08", Offset = "0x19B1F08", VA = "0x19B1F08")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x19B1E78", Offset = "0x19B1E78", VA = "0x19B1E78")]
		private static float CutoffRange(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x19B1EC0", Offset = "0x19B1EC0", VA = "0x19B1EC0")]
		private static float MaxCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x19B1ED8", Offset = "0x19B1ED8", VA = "0x19B1ED8")]
		public static float MinCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x19B1F10", Offset = "0x19B1F10", VA = "0x19B1F10")]
		public static float GetOcclusionCutoffFrequencyByDistanceRatio(float distRatio, SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x19B1F5C", Offset = "0x19B1F5C", VA = "0x19B1F5C")]
		public static float GetSemitonesFromPitch(float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x19B1FA8", Offset = "0x19B1FA8", VA = "0x19B1FA8")]
		public static float GetPitchFromSemitones(float semitones)
		{
			return default(float);
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x19B1FE8", Offset = "0x19B1FE8", VA = "0x19B1FE8")]
		public static float GetDbFromFloatVolume(float vol)
		{
			return default(float);
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x19B2004", Offset = "0x19B2004", VA = "0x19B2004")]
		public static float GetFloatVolumeFromDb(float db)
		{
			return default(float);
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x19ADB38", Offset = "0x19ADB38", VA = "0x19ADB38")]
		public static float GetAudioPlayedPercentage(AudioSource source)
		{
			return default(float);
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x19B2014", Offset = "0x19B2014", VA = "0x19B2014")]
		public static bool IsClipPaused(AudioSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x19B205C", Offset = "0x19B205C", VA = "0x19B205C")]
		public static void ClipPlayed(AudioClip clip, GameObject actor)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x19B2178", Offset = "0x19B2178", VA = "0x19B2178")]
		public static void UnloadNonPreloadedAudioData(AudioClip clip, GameObject actor)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x19B20E8", Offset = "0x19B20E8", VA = "0x19B20E8")]
		public static bool AudioClipWillPreload(AudioClip clip)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x19B2264", Offset = "0x19B2264", VA = "0x19B2264")]
		public static bool IsClipReadyToPlay(this AudioClip clip)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x19B22F8", Offset = "0x19B22F8", VA = "0x19B22F8")]
		private static float GetPositiveUsablePitch(AudioSource source)
		{
			return default(float);
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x19B2324", Offset = "0x19B2324", VA = "0x19B2324")]
		private static float GetPositiveUsablePitch(float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x19B2334", Offset = "0x19B2334", VA = "0x19B2334")]
		public static float AdjustAudioClipDurationForPitch(float duration, AudioSource sourceWithPitch)
		{
			return default(float);
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x19B2370", Offset = "0x19B2370", VA = "0x19B2370")]
		public static float AdjustAudioClipDurationForPitch(float duration, float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x19B2384", Offset = "0x19B2384", VA = "0x19B2384")]
		public static float AdjustEndLeadTimeForPitch(float duration, AudioSource sourceWithPitch)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000083")]
	public static class CoroutineHelper
	{
		[Token(Token = "0x20000F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C210", Offset = "0xA0C210")]
		private sealed class <WaitForActualSeconds>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float time;

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float <start>5__2;

			[Token(Token = "0x170000C7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000532")]
				[Address(RVA = "0x24414B8", Offset = "0x24414B8", VA = "0x24414B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000534")]
				[Address(RVA = "0x2441500", Offset = "0x2441500", VA = "0x2441500", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600052F")]
			[Address(RVA = "0x24413BC", Offset = "0x24413BC", VA = "0x24413BC")]
			[DebuggerHidden]
			public <WaitForActualSeconds>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x6000530")]
			[Address(RVA = "0x24413E8", Offset = "0x24413E8", VA = "0x24413E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000531")]
			[Address(RVA = "0x24413EC", Offset = "0x24413EC", VA = "0x24413EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000533")]
			[Address(RVA = "0x24414C0", Offset = "0x24414C0", VA = "0x24414C0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x19B2E84", Offset = "0x19B2E84", VA = "0x19B2E84")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0F5C8", Offset = "0xA0F5C8")]
		public static IEnumerator WaitForActualSeconds(float time)
		{
			return null;
		}
	}
	[Token(Token = "0x2000084")]
	public static class DTMonoHelper
	{
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x19AC6C0", Offset = "0x19AC6C0", VA = "0x19AC6C0")]
		public static Transform GetChildTransform(this Transform transParent, string childName)
		{
			return null;
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x19B3018", Offset = "0x19B3018", VA = "0x19B3018")]
		public static bool IsActive(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x19B3030", Offset = "0x19B3030", VA = "0x19B3030")]
		public static void SetActive(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x19ABD7C", Offset = "0x19ABD7C", VA = "0x19ABD7C")]
		public static void DestroyAllChildren(this Transform tran)
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class DelayBetweenSongs : MonoBehaviour
	{
		[Token(Token = "0x20000F9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C220", Offset = "0xA0C220")]
		private sealed class <PlaySongWithDelay>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DelayBetweenSongs <>4__this;

			[Token(Token = "0x170000C9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000538")]
				[Address(RVA = "0x2441688", Offset = "0x2441688", VA = "0x2441688", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600053A")]
				[Address(RVA = "0x24416D0", Offset = "0x24416D0", VA = "0x24416D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000535")]
			[Address(RVA = "0x2441508", Offset = "0x2441508", VA = "0x2441508")]
			[DebuggerHidden]
			public <PlaySongWithDelay>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000536")]
			[Address(RVA = "0x2441534", Offset = "0x2441534", VA = "0x2441534", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000537")]
			[Address(RVA = "0x2441538", Offset = "0x2441538", VA = "0x2441538", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000539")]
			[Address(RVA = "0x2441690", Offset = "0x2441690", VA = "0x2441690", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minTimeToWait;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxTimeToWait;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string playlistControllerName;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PlaylistController _controller;

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x19B304C", Offset = "0x19B304C", VA = "0x19B304C")]
		private void Start()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x19B3100", Offset = "0x19B3100", VA = "0x19B3100")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x19B3194", Offset = "0x19B3194", VA = "0x19B3194")]
		private void SongEnded(string songName)
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x19B31CC", Offset = "0x19B31CC", VA = "0x19B31CC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA0F648", Offset = "0xA0F648")]
		private IEnumerator PlaySongWithDelay()
		{
			return null;
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x19B3244", Offset = "0x19B3244", VA = "0x19B3244")]
		public DelayBetweenSongs()
		{
		}
	}
	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0xA0BF78", Offset = "0xA0BF78")]
	public class DynamicSoundGroupCreator : MonoBehaviour
	{
		[Token(Token = "0x20000FA")]
		public enum CreateItemsWhen
		{
			[Token(Token = "0x40006BC")]
			FirstEnableOnly,
			[Token(Token = "0x40006BD")]
			EveryEnable
		}

		[Token(Token = "0x20000FB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C230", Offset = "0xA0C230")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CustomEventCategory aCat;

			[Token(Token = "0x600053B")]
			[Address(RVA = "0x24416D8", Offset = "0x24416D8", VA = "0x24416D8")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x600053C")]
			[Address(RVA = "0x24416E0", Offset = "0x24416E0", VA = "0x24416E0")]
			internal bool <RemoveItems>b__0(CustomEventCategory cat)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400044A")]
		public const int ExtraHardCodedBusOptions = 1;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SystemLanguage previewLanguage;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MasterAudio.DragGroupMode curDragGroupMode;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject groupTemplate;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject variationTemplate;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool errorOnDuplicates;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool createOnAwake;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool soundGroupsAreExpanded;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		public bool removeGroupsOnSceneChange;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public CreateItemsWhen reUseMode;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool showCustomEvents;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<CustomEvent> customEventsToCreate;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string newEventName;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool showMusicDucking;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<DuckGroupInfo> musicDuckingSounds;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<GroupBus> groupBuses;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool playListExpanded;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		public bool playlistEditorExp;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<MasterAudio.Playlist> musicPlaylists;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<GameObject> audioSourceTemplates;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string audioSourceTemplateName;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool groupByBus;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool itemsCreatedEventExpanded;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string itemsCreatedCustomEvent;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool showUnityMixerGroupAssignment;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		private bool _hasCreated;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly List<Transform> _groupsToRemove;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Transform _trans;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private readonly List<DynamicSoundGroup> _groupsToCreate;

		[Token(Token = "0x17000091")]
		public static int HardCodedBusOptions
		{
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x19B6350", Offset = "0x19B6350", VA = "0x19B6350")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000092")]
		public List<DynamicSoundGroup> GroupsToCreate
		{
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x19B812C", Offset = "0x19B812C", VA = "0x19B812C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000093")]
		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x19B8134", Offset = "0x19B8134", VA = "0x19B8134")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x19B3E70", Offset = "0x19B3E70", VA = "0x19B3E70")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x19B3F54", Offset = "0x19B3F54", VA = "0x19B3F54")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x19B404C", Offset = "0x19B404C", VA = "0x19B404C")]
		private void Start()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x19B4050", Offset = "0x19B4050", VA = "0x19B4050")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x19B3F58", Offset = "0x19B3F58", VA = "0x19B3F58")]
		private void CreateItemsIfReady()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x19B4178", Offset = "0x19B4178", VA = "0x19B4178")]
		public void RemoveItems()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x19B4670", Offset = "0x19B4670", VA = "0x19B4670")]
		public void CreateItems()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x19B7E64", Offset = "0x19B7E64", VA = "0x19B7E64")]
		private void FireEvents()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x19B5CD0", Offset = "0x19B5CD0", VA = "0x19B5CD0")]
		public void PopulateGroupData()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x19B813C", Offset = "0x19B813C", VA = "0x19B813C")]
		public DynamicSoundGroupCreator()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public static class FilePlayerPrefs
	{
		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Hashtable PlayerPrefsHashtable;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool _hashTableChanged;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string _serializedOutput;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly string SerializedInput;

		[Token(Token = "0x400046F")]
		private const string ParametersSeperator = ";";

		[Token(Token = "0x4000470")]
		private const string KeyValueSeperator = ":";

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly string FileName;

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x19C8108", Offset = "0x19C8108", VA = "0x19C8108")]
		static FilePlayerPrefs()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x19C85B4", Offset = "0x19C85B4", VA = "0x19C85B4")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x19C8634", Offset = "0x19C8634", VA = "0x19C8634")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x19C8768", Offset = "0x19C8768", VA = "0x19C8768")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x19C88E8", Offset = "0x19C88E8", VA = "0x19C88E8")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x19C8A70", Offset = "0x19C8A70", VA = "0x19C8A70")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x19C8BF4", Offset = "0x19C8BF4", VA = "0x19C8BF4")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x19C8CD4", Offset = "0x19C8CD4", VA = "0x19C8CD4")]
		public static string GetString(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x19C8E14", Offset = "0x19C8E14", VA = "0x19C8E14")]
		public static int GetInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x19C8FBC", Offset = "0x19C8FBC", VA = "0x19C8FBC")]
		public static int GetInt(string key, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x19C9144", Offset = "0x19C9144", VA = "0x19C9144")]
		public static float GetFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x19C92EC", Offset = "0x19C92EC", VA = "0x19C92EC")]
		public static float GetFloat(string key, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x19C947C", Offset = "0x19C947C", VA = "0x19C947C")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x19C958C", Offset = "0x19C958C", VA = "0x19C958C")]
		public static bool GetBool(string key, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x19C9720", Offset = "0x19C9720", VA = "0x19C9720")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x19C97A0", Offset = "0x19C97A0", VA = "0x19C97A0")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x19C9818", Offset = "0x19C9818", VA = "0x19C9818")]
		public static void Flush()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x19C99C4", Offset = "0x19C99C4", VA = "0x19C99C4")]
		private static void Serialize()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x19C82AC", Offset = "0x19C82AC", VA = "0x19C82AC")]
		private static void Deserialize()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x19C9F38", Offset = "0x19C9F38", VA = "0x19C9F38")]
		private static string EscapeNonSeperators(string inputToEscape)
		{
			return null;
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x19C9FE4", Offset = "0x19C9FE4", VA = "0x19C9FE4")]
		private static string DeEscapeNonSeperators(string inputToDeEscape)
		{
			return null;
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x19CA090", Offset = "0x19CA090", VA = "0x19CA090")]
		public static object GetTypeValue(string typeName, string value)
		{
			return null;
		}
	}
	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0xA0BF8C", Offset = "0xA0BF8C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA0BF8C", Offset = "0xA0BF8C")]
	public class PlaylistController : MonoBehaviour
	{
		[Token(Token = "0x20000FC")]
		public enum AudioPlayType
		{
			[Token(Token = "0x40006C0")]
			PlayNow,
			[Token(Token = "0x40006C1")]
			Schedule,
			[Token(Token = "0x40006C2")]
			AlreadyScheduled
		}

		[Token(Token = "0x20000FD")]
		public enum PlaylistStates
		{
			[Token(Token = "0x40006C4")]
			NotInScene,
			[Token(Token = "0x40006C5")]
			Stopped,
			[Token(Token = "0x40006C6")]
			Playing,
			[Token(Token = "0x40006C7")]
			Paused,
			[Token(Token = "0x40006C8")]
			Crossfading
		}

		[Token(Token = "0x20000FE")]
		public enum FadeMode
		{
			[Token(Token = "0x40006CA")]
			None,
			[Token(Token = "0x40006CB")]
			GradualFade
		}

		[Token(Token = "0x20000FF")]
		public enum AudioDuckingMode
		{
			[Token(Token = "0x40006CD")]
			NotDucking,
			[Token(Token = "0x40006CE")]
			SetToDuck,
			[Token(Token = "0x40006CF")]
			Ducked,
			[Token(Token = "0x40006D0")]
			Unducking
		}

		[Token(Token = "0x2000100")]
		public delegate void SongChangedEventHandler(string newSongName, MusicSetting song);

		[Token(Token = "0x2000101")]
		public delegate void SongEndedEventHandler(string songName);

		[Token(Token = "0x2000102")]
		public delegate void SongLoopedEventHandler(string songName);

		[Token(Token = "0x2000103")]
		public delegate void PlaylistEndedEventHandler();

		[Token(Token = "0x2000104")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C240", Offset = "0xA0C240")]
		private sealed class <>c__DisplayClass110_0
		{
			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string clipName;

			[Token(Token = "0x600054D")]
			[Address(RVA = "0x2442F44", Offset = "0x2442F44", VA = "0x2442F44")]
			public <>c__DisplayClass110_0()
			{
			}

			[Token(Token = "0x600054E")]
			[Address(RVA = "0x2442F4C", Offset = "0x2442F4C", VA = "0x2442F4C")]
			internal bool <FindSongByAliasOrName>b__0(MusicSetting obj)
			{
				return default(bool);
			}

			[Token(Token = "0x600054F")]
			[Address(RVA = "0x2442F70", Offset = "0x2442F70", VA = "0x2442F70")]
			internal bool <FindSongByAliasOrName>b__1(MusicSetting obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000105")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C250", Offset = "0xA0C250")]
		private sealed class <>c__DisplayClass120_0
		{
			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string playlistControllerName;

			[Token(Token = "0x6000550")]
			[Address(RVA = "0x244303C", Offset = "0x244303C", VA = "0x244303C")]
			public <>c__DisplayClass120_0()
			{
			}

			[Token(Token = "0x6000551")]
			[Address(RVA = "0x2443044", Offset = "0x2443044", VA = "0x2443044")]
			internal bool <InstanceByName>b__0(PlaylistController obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000106")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0C260", Offset = "0xA0C260")]
		private sealed class <>c__DisplayClass151_0
		{
			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PlaylistController <>4__this;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volumeBeforeFade;

			[Token(Token = "0x6000552")]
			[Address(RVA = "0x24430F0", Offset = "0x24430F0", VA = "0x24430F0")]
			public <>c__DisplayClass151_0()
			{
			}

			[Token(Token = "0x6000553")]
			[Address(RVA = "0x24430F8", Offset = "0x24430F8", VA = "0x24430F8")]
			internal void <FadeOutPlaylist>b__0()
			{
			}
		}

		[Token(Token = "0x4000472")]
		public const float ScheduledSongMinBadOffset = 0.5f;

		[Token(Token = "0x4000473")]
		public const int FramesEarlyToTrigger = 2;

		[Token(Token = "0x4000474")]
		public const int FramesEarlyToBeSyncable = 10;

		[Token(Token = "0x4000475")]
		private const int NextScheduleTimeRecalcConsecutiveFrameCount = 5;

		[Token(Token = "0x4000476")]
		private const string NotReadyMessage = "Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.";

		[Token(Token = "0x4000477")]
		private const float MinSongLength = 0.5f;

		[Token(Token = "0x4000478")]
		private const float SlowestFrameTimeForCalc = 0.3f;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool startPlaylistOnAwake;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool isShuffle;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool isAutoAdvance;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool loopPlaylist;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float _playlistVolume;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isMuted;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string startPlaylistName;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int syncGroupNum;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioMixerGroup mixerChannel;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float spatialBlend;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool initializedEventExpanded;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string initializedCustomEvent;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool crossfadeStartedExpanded;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string crossfadeStartedCustomEvent;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool songChangedEventExpanded;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string songChangedCustomEvent;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool songEndedEventExpanded;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string songEndedCustomEvent;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool songLoopedEventExpanded;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string songLoopedCustomEvent;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool playlistStartedEventExpanded;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string playlistStartedCustomEvent;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool playlistEndedEventExpanded;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string playlistEndedCustomEvent;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AudioSource _activeAudio;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioSource _transitioningAudio;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float _activeAudioEndVolume;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float _transitioningAudioStartVolume;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float _crossFadeStartTime;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly List<int> _clipsRemaining;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int _currentSequentialClipIndex;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private AudioDuckingMode _duckingMode;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _timeToStartUnducking;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _timeToFinishUnducking;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float _originalMusicVolume;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float _initialDuckVolume;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float _duckRange;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private SoundGroupVariationUpdater _actorUpdater;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private float _unduckTime;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private MusicSetting _currentSong;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private GameObject _go;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private string _name;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private FadeMode _curFadeMode;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private float _slowFadeStartTime;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float _slowFadeCompletionTime;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private float _slowFadeStartVolume;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float _slowFadeTargetVolume;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private MasterAudio.Playlist _currentPlaylist;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private float _lastTimeMissingPlaylistLogged;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Action _fadeCompleteCallback;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private readonly List<MusicSetting> _queuedSongs;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private bool _lostFocus;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x161")]
		private bool _autoStartedPlaylist;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private AudioSource _audioClip;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private AudioSource _transClip;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private MusicSetting _newSongSetting;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private bool _nextSongRequested;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x181")]
		private bool _nextSongScheduled;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		private int _lastRandomClipIndex;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private float _lastTimeSongRequested;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private float _currentDuckVolCut;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private int? _lastSongPosition;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private double? _currentSchedSongDspStartTime;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private double? _currentSchedSongDspEndTime;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private int _lastFrameSongPosition;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private int _nextScheduleTimeRecalcDifferentFirstFrameNum;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private double? _nextScheduledTimeRecalcStart;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private readonly Dictionary<AudioSource, double> _scheduledSongOffsetByAudioSource;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public int _frames;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<PlaylistController> _instances;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private Coroutine _resourceCoroutine;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private int _songsPlayedFromPlaylist;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private AudioSource _audio1;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private AudioSource _audio2;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private string _activeSongAlias;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private Transform _trans;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private bool _willPersist;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private double? _songPauseTime;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private int framesOfSongPlayed;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F044", Offset = "0xA0F044")]
		private bool <ControllerIsReady>k__BackingField;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x251")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F054", Offset = "0xA0F054")]
		private bool <IsCrossFading>k__BackingField;

		[Token(Token = "0x17000094")]
		private bool SongIsNonAdvancible
		{
			[Token(Token = "0x6000453")]
			[Address(RVA = "0x235C070", Offset = "0x235C070", VA = "0x235C070")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000095")]
		public bool ControllerIsReady
		{
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x235C0C8", Offset = "0x235C0C8", VA = "0x235C0C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F728", Offset = "0xA0F728")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x235C0D0", Offset = "0x235C0D0", VA = "0x235C0D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F738", Offset = "0xA0F738")]
			private set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public PlaylistStates PlaylistState
		{
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x2357F48", Offset = "0x2357F48", VA = "0x2357F48")]
			get
			{
				return default(PlaylistStates);
			}
		}

		[Token(Token = "0x17000097")]
		public AudioSource ActiveAudioSource
		{
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x234FBB0", Offset = "0x234FBB0", VA = "0x234FBB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000098")]
		public static List<PlaylistController> Instances
		{
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x234F138", Offset = "0x234F138", VA = "0x234F138")]
			get
			{
				return null;
			}
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x235C0DC", Offset = "0x235C0DC", VA = "0x235C0DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public GameObject PlaylistControllerGameObject
		{
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x235C130", Offset = "0x235C130", VA = "0x235C130")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009A")]
		public AudioSource CurrentPlaylistSource
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x235C138", Offset = "0x235C138", VA = "0x235C138")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		public AudioClip CurrentPlaylistClip
		{
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x2350120", Offset = "0x2350120", VA = "0x2350120")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009C")]
		public AudioClip FadingPlaylistClip
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x235C140", Offset = "0x235C140", VA = "0x235C140")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		public AudioSource FadingSource
		{
			[Token(Token = "0x600045F")]
			[Address(RVA = "0x235C1DC", Offset = "0x235C1DC", VA = "0x235C1DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009E")]
		public bool IsCrossFading
		{
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x235C1F4", Offset = "0x235C1F4", VA = "0x235C1F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F748", Offset = "0xA0F748")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000461")]
			[Address(RVA = "0x235C1FC", Offset = "0x235C1FC", VA = "0x235C1FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F758", Offset = "0xA0F758")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public bool IsFading
		{
			[Token(Token = "0x6000462")]
			[Address(RVA = "0x235C208", Offset = "0x235C208", VA = "0x235C208")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A0")]
		public float PlaylistVolume
		{
			[Token(Token = "0x6000463")]
			[Address(RVA = "0x234FB44", Offset = "0x234FB44", VA = "0x234FB44")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000464")]
			[Address(RVA = "0x235C228", Offset = "0x235C228", VA = "0x235C228")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public MasterAudio.Playlist CurrentPlaylist
		{
			[Token(Token = "0x6000466")]
			[Address(RVA = "0x235B0D4", Offset = "0x235B0D4", VA = "0x235B0D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A2")]
		public bool HasPlaylist
		{
			[Token(Token = "0x6000467")]
			[Address(RVA = "0x23583A4", Offset = "0x23583A4", VA = "0x23583A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A3")]
		public string PlaylistName
		{
			[Token(Token = "0x6000468")]
			[Address(RVA = "0x235C274", Offset = "0x235C274", VA = "0x235C274")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A4")]
		public MusicSetting CurrentSong
		{
			[Token(Token = "0x6000469")]
			[Address(RVA = "0x235C2E8", Offset = "0x235C2E8", VA = "0x235C2E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A5")]
		private bool IsMuted
		{
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x235C2F0", Offset = "0x235C2F0", VA = "0x235C2F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A6")]
		private bool PlaylistIsMuted
		{
			[Token(Token = "0x600046B")]
			[Address(RVA = "0x2358520", Offset = "0x2358520", VA = "0x2358520")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		private float CrossFadeTime
		{
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x2357D5C", Offset = "0x2357D5C", VA = "0x2357D5C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A8")]
		private bool IsAutoAdvance
		{
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x2357DE8", Offset = "0x2357DE8", VA = "0x2357DE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A9")]
		public GameObject GameObj
		{
			[Token(Token = "0x600046E")]
			[Address(RVA = "0x2358DB4", Offset = "0x2358DB4", VA = "0x2358DB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AA")]
		public string ControllerName
		{
			[Token(Token = "0x600046F")]
			[Address(RVA = "0x2355BB4", Offset = "0x2355BB4", VA = "0x2355BB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AB")]
		public bool CanSchedule
		{
			[Token(Token = "0x6000470")]
			[Address(RVA = "0x2356178", Offset = "0x2356178", VA = "0x2356178")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AC")]
		private bool IsFrameFastEnough
		{
			[Token(Token = "0x6000471")]
			[Address(RVA = "0x2356900", Offset = "0x2356900", VA = "0x2356900")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AD")]
		private bool ShouldNotSwitchEarly
		{
			[Token(Token = "0x6000472")]
			[Address(RVA = "0x2357F0C", Offset = "0x2357F0C", VA = "0x2357F0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AE")]
		private Transform Trans
		{
			[Token(Token = "0x6000473")]
			[Address(RVA = "0x23567F8", Offset = "0x23567F8", VA = "0x23567F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AF")]
		public int ClipsRemainingInCurrentPlaylist
		{
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x235C2F8", Offset = "0x235C2F8", VA = "0x235C2F8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000004")]
		public event SongChangedEventHandler SongChanged
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0x23550B0", Offset = "0x23550B0", VA = "0x23550B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F6A8", Offset = "0xA0F6A8")]
			add
			{
			}
			[Token(Token = "0x600040D")]
			[Address(RVA = "0x2355154", Offset = "0x2355154", VA = "0x2355154")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F6B8", Offset = "0xA0F6B8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event SongEndedEventHandler SongEnded
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0x23551F8", Offset = "0x23551F8", VA = "0x23551F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F6C8", Offset = "0xA0F6C8")]
			add
			{
			}
			[Token(Token = "0x600040F")]
			[Address(RVA = "0x235529C", Offset = "0x235529C", VA = "0x235529C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F6D8", Offset = "0xA0F6D8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event SongLoopedEventHandler SongLooped
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x2355340", Offset = "0x2355340", VA = "0x2355340")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F6E8", Offset = "0xA0F6E8")]
			add
			{
			}
			[Token(Token = "0x6000411")]
			[Address(RVA = "0x23553E4", Offset = "0x23553E4", VA = "0x23553E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F6F8", Offset = "0xA0F6F8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event PlaylistEndedEventHandler PlaylistEnded
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0x2355488", Offset = "0x2355488", VA = "0x2355488")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F708", Offset = "0xA0F708")]
			add
			{
			}
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x235552C", Offset = "0x235552C", VA = "0x235552C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F718", Offset = "0xA0F718")]
			remove
			{
			}
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x23555D0", Offset = "0x23555D0", VA = "0x23555D0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x2355C08", Offset = "0x2355C08", VA = "0x2355C08")]
		public void SetSpatialBlend()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x2355E24", Offset = "0x2355E24", VA = "0x2355E24")]
		private void DetectAndRescheduleNextGaplessSongIfOff()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x2356394", Offset = "0x2356394", VA = "0x2356394")]
		private MusicSetting FindSongByAliasOrName(string clipName)
		{
			return null;
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x2356514", Offset = "0x2356514", VA = "0x2356514")]
		private void SetAudiosIfEmpty()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x2355D74", Offset = "0x2355D74", VA = "0x2355D74")]
		private void SetAudioSpatialBlend(float blend)
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x23565AC", Offset = "0x23565AC", VA = "0x23565AC")]
		private void Start()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x2356898", Offset = "0x2356898", VA = "0x2356898")]
		private void AutoStartPlaylist()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x23569D0", Offset = "0x23569D0", VA = "0x23569D0")]
		private void CoUpdate()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x2356EA0", Offset = "0x2356EA0", VA = "0x2356EA0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x2356FAC", Offset = "0x2356FAC", VA = "0x2356FAC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x2357228", Offset = "0x2357228", VA = "0x2357228")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x2357234", Offset = "0x2357234", VA = "0x2357234")]
		private void Update()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x234F958", Offset = "0x234F958", VA = "0x234F958")]
		public static PlaylistController InstanceByName(string playlistControllerName, bool errorIfNotFound = true)
		{
			return null;
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x235826C", Offset = "0x235826C", VA = "0x235826C")]
		public bool IsSongPlaying(string songName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x23583B4", Offset = "0x23583B4", VA = "0x23583B4")]
		public void ClearQueue()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x2358464", Offset = "0x2358464", VA = "0x2358464")]
		public void ToggleMutePlaylist()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x23568F8", Offset = "0x23568F8", VA = "0x23568F8")]
		public void MutePlaylist()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x2358518", Offset = "0x2358518", VA = "0x2358518")]
		public void UnmutePlaylist()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x2358690", Offset = "0x2358690", VA = "0x2358690")]
		public void PausePlaylist()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x23588A0", Offset = "0x23588A0", VA = "0x23588A0")]
		public bool UnpausePlaylist()
		{
			return default(bool);
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x2356D60", Offset = "0x2356D60", VA = "0x2356D60")]
		public void StopPlaylist(bool onlyFadingClip = false)
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x2358E54", Offset = "0x2358E54", VA = "0x2358E54")]
		public void FadeToVolume(float targetVolume, float fadeTime, [Optional] Action callback)
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x2358F98", Offset = "0x2358F98", VA = "0x2358F98")]
		public void PlayRandomSong()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x235902C", Offset = "0x235902C", VA = "0x235902C")]
		public void PlayARandomSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x2359228", Offset = "0x2359228", VA = "0x2359228")]
		private void RemoveRandomClip(int randIndex)
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x2359A88", Offset = "0x2359A88", VA = "0x2359A88")]
		private void PlayFirstQueuedSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x2359BC4", Offset = "0x2359BC4", VA = "0x2359BC4")]
		public void PlayNextSong()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x2359C58", Offset = "0x2359C58", VA = "0x2359C58")]
		public void PlayTheNextSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x2359E04", Offset = "0x2359E04", VA = "0x2359E04")]
		private void AdvanceSongCounter()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x2359E78", Offset = "0x2359E78", VA = "0x2359E78")]
		public void StopPlaylistAfterCurrentSong()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x235A074", Offset = "0x235A074", VA = "0x235A074")]
		public void StopLoopingCurrentSong()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x235A228", Offset = "0x235A228", VA = "0x235A228")]
		public void QueuePlaylistClip(string clipName, bool scheduleNow = true)
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x235A5D0", Offset = "0x235A5D0", VA = "0x235A5D0")]
		public bool TriggerPlaylistClip(string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x235A8EC", Offset = "0x235A8EC", VA = "0x235A8EC")]
		public void EndDucking(SoundGroupVariationUpdater actorUpdater)
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x235A98C", Offset = "0x235A98C", VA = "0x235A98C")]
		public void DuckMusicForTime(SoundGroupVariationUpdater actorUpdater, float duckLength, float unduckTime, float pitch, float duckedTimePercentage, float duckedVolCut)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x235AB34", Offset = "0x235AB34", VA = "0x235AB34")]
		private void InitControllerIfNot()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x2356C30", Offset = "0x2356C30", VA = "0x2356C30")]
		public void UpdateMasterVolume()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x235AB64", Offset = "0x235AB64", VA = "0x235AB64")]
		public void StartPlaylist(string playlistName, [Optional] string clipName)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x235ACF0", Offset = "0x235ACF0", VA = "0x235ACF0")]
		public void ChangePlaylist(string playlistName, bool playFirstClip = true, [Optional] string clipName)
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x2358CAC", Offset = "0x2358CAC", VA = "0x2358CAC")]
		private void FinishPlaylistInit(bool playFirstClip = true, [Optional] string clipName)
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x235AC48", Offset = "0x235AC48", VA = "0x235AC48")]
		public void RestartPlaylist([Optional] string clipName)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x235AE60", Offset = "0x235AE60", VA = "0x235AE60")]
		private void CheckIfPlaylistStarted()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x235AF58", Offset = "0x235AF58", VA = "0x235AF58")]
		private PlaylistController FindOtherControllerInSameSyncGroup()
		{
			return null;
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x2358050", Offset = "0x2358050", VA = "0x2358050")]
		private void FadeOutPlaylist()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x23567C4", Offset = "0x23567C4", VA = "0x23567C4")]
		private void InitializePlaylist()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x2356928", Offset = "0x2356928", VA = "0x2356928")]
		private void PlayNextOrRandom(AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x2357E20", Offset = "0x2357E20", VA = "0x2357E20")]
		private void FirePlaylistEndedEventIfAny()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x23598AC", Offset = "0x23598AC", VA = "0x23598AC")]
		private void FillClips()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x23592C8", Offset = "0x23592C8", VA = "0x23592C8")]
		private void PlaySong(MusicSetting setting, AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x235BC54", Offset = "0x235BC54", VA = "0x235BC54")]
		public double? ScheduledGaplessNextSongStartTime()
		{
			return null;
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x235B184", Offset = "0x235B184", VA = "0x235B184")]
		public void FinishLoadingNewSong(MusicSetting songSetting, AudioClip clipToPlay, AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x235BF34", Offset = "0x235BF34", VA = "0x235BF34")]
		private void RemoveScheduledClip()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x235A220", Offset = "0x235A220", VA = "0x235A220")]
		private void ScheduleNextSong()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x2358158", Offset = "0x2358158", VA = "0x2358158")]
		private void FadeInScheduledSong()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x235BD14", Offset = "0x235BD14", VA = "0x235BD14")]
		private double CalculateNextTrackStartTimeOffset()
		{
			return default(double);
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x235BFDC", Offset = "0x235BFDC", VA = "0x235BFDC")]
		private double GetClipDuration(AudioSource src)
		{
			return default(double);
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x235620C", Offset = "0x235620C", VA = "0x235620C")]
		private void ScheduleClipPlay(double scheduledPlayTimeOffset, AudioSource source, bool calledAfterPause, bool addDspTime = true)
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x235BDF8", Offset = "0x235BDF8", VA = "0x235BDF8")]
		private void CrossFadeNow(AudioSource audioClip)
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x23578D0", Offset = "0x23578D0", VA = "0x23578D0")]
		private void CeaseAudioSource(AudioSource source)
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x2357C70", Offset = "0x2357C70", VA = "0x2357C70")]
		private void SetDuckProperties()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x2358160", Offset = "0x2358160", VA = "0x2358160")]
		private void AudioDucking()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x235C058", Offset = "0x235C058", VA = "0x235C058")]
		private void ResetDuckingState()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x235B048", Offset = "0x235B048", VA = "0x235B048")]
		private bool SongShouldLoop(MusicSetting setting)
		{
			return default(bool);
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x235C230", Offset = "0x235C230", VA = "0x235C230")]
		public void RouteToMixerChannel(AudioMixerGroup group)
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x235C344", Offset = "0x235C344", VA = "0x235C344")]
		public PlaylistController()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x235C584", Offset = "0x235C584", VA = "0x235C584")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F768", Offset = "0xA0F768")]
		private bool <FindOtherControllerInSameSyncGroup>b__150_0(PlaylistController obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x235C678", Offset = "0x235C678", VA = "0x235C678")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F778", Offset = "0xA0F778")]
		private bool <FinishLoadingNewSong>b__158_0(MusicSetting obj)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000089")]
	public static class SpatializerHelper
	{
		[Token(Token = "0x40004CF")]
		private const string OculusSpatializer = "OculusSpatializer";

		[Token(Token = "0x40004D0")]
		private const string ResonanceAudioSpatializer = "Resonance Audio";

		[Token(Token = "0x170000B0")]
		public static bool IsSupportedSpatializer
		{
			[Token(Token = "0x6000478")]
			[Address(RVA = "0x243EBE0", Offset = "0x243EBE0", VA = "0x243EBE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B1")]
		public static bool IsOculusAudioSpatializer
		{
			[Token(Token = "0x6000479")]
			[Address(RVA = "0x243EC7C", Offset = "0x243EC7C", VA = "0x243EC7C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B2")]
		public static bool IsResonanceAudioSpatializer
		{
			[Token(Token = "0x600047A")]
			[Address(RVA = "0x243ECCC", Offset = "0x243ECCC", VA = "0x243ECCC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B3")]
		public static string SelectedSpatializer
		{
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x243EC74", Offset = "0x243EC74", VA = "0x243EC74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B4")]
		public static bool SpatializerOptionExists
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x243ED1C", Offset = "0x243ED1C", VA = "0x243ED1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x2437FF8", Offset = "0x2437FF8", VA = "0x2437FF8")]
		public static void TurnOnSpatializerIfEnabled(AudioSource source)
		{
		}
	}
	[Token(Token = "0x200008A")]
	public static class UtilStrings
	{
		[Token(Token = "0x600047E")]
		[Address(RVA = "0x24403E0", Offset = "0x24403E0", VA = "0x24403E0")]
		public static string TrimSpace(string untrimmed)
		{
			return null;
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x244045C", Offset = "0x244045C", VA = "0x244045C")]
		public static string ReplaceUnsafeChars(string source)
		{
			return null;
		}
	}
	[Token(Token = "0x200008B")]
	public class VideoPlayerTracker
	{
		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F064", Offset = "0xA0F064")]
		private readonly VideoPlayer <Player>k__BackingField;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F074", Offset = "0xA0F074")]
		private bool <IsPlaying>k__BackingField;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F084", Offset = "0xA0F084")]
		private readonly SoundGroupVariation <Variation>k__BackingField;

		[Token(Token = "0x170000B5")]
		public VideoPlayer Player
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x244059C", Offset = "0x244059C", VA = "0x244059C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F788", Offset = "0xA0F788")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B6")]
		public bool IsPlaying
		{
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x24405A4", Offset = "0x24405A4", VA = "0x24405A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F798", Offset = "0xA0F798")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x24405AC", Offset = "0x24405AC", VA = "0x24405AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F7A8", Offset = "0xA0F7A8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B7")]
		public SoundGroupVariation Variation
		{
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x24405B8", Offset = "0x24405B8", VA = "0x24405B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA0F7B8", Offset = "0xA0F7B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x2440544", Offset = "0x2440544", VA = "0x2440544")]
		private VideoPlayerTracker()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x244054C", Offset = "0x244054C", VA = "0x244054C")]
		public VideoPlayerTracker(VideoPlayer player, SoundGroupVariation variation)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x24405C0", Offset = "0x24405C0", VA = "0x24405C0")]
		public void StartedPlaying()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x24405CC", Offset = "0x24405CC", VA = "0x24405CC")]
		public void StoppedPlayings()
		{
		}
	}
}
namespace DarkTonic.MasterAudio.Examples
{
	[Token(Token = "0x200008C")]
	public class MA_Bootstrapper : MonoBehaviour
	{
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x19CB224", Offset = "0x19CB224", VA = "0x19CB224")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x19CB228", Offset = "0x19CB228", VA = "0x19CB228")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x19CB368", Offset = "0x19CB368", VA = "0x19CB368")]
		public MA_Bootstrapper()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class MA_DestroyFinishedParticle : MonoBehaviour
	{
		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ParticleSystem particles;

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x19CB370", Offset = "0x19CB370", VA = "0x19CB370")]
		private void Awake()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x19CB3DC", Offset = "0x19CB3DC", VA = "0x19CB3DC")]
		private void Update()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x19CB478", Offset = "0x19CB478", VA = "0x19CB478")]
		public MA_DestroyFinishedParticle()
		{
		}
	}
	[Token(Token = "0x200008E")]
	public class MA_EnemyOne : MonoBehaviour
	{
		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject ExplosionParticlePrefab;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform _trans;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _speed;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _horizSpeed;

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x19CB480", Offset = "0x19CB480", VA = "0x19CB480")]
		private void Awake()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x19CB514", Offset = "0x19CB514", VA = "0x19CB514")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x19CB604", Offset = "0x19CB604", VA = "0x19CB604")]
		private void Update()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x19CB740", Offset = "0x19CB740", VA = "0x19CB740")]
		public MA_EnemyOne()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class MA_EnemySpawner : MonoBehaviour
	{
		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject Enemy;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool spawnerEnabled;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform trans;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float nextSpawnTime;

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x19CB748", Offset = "0x19CB748", VA = "0x19CB748")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x19CB7C0", Offset = "0x19CB7C0", VA = "0x19CB7C0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x19CB968", Offset = "0x19CB968", VA = "0x19CB968")]
		public MA_EnemySpawner()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class MA_GameScene : MonoBehaviour
	{
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x19CB970", Offset = "0x19CB970", VA = "0x19CB970")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x19CBA24", Offset = "0x19CBA24", VA = "0x19CBA24")]
		public MA_GameScene()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class MA_Laser : MonoBehaviour
	{
		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform _trans;

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x19CBA2C", Offset = "0x19CBA2C", VA = "0x19CBA2C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x19CBA6C", Offset = "0x19CBA6C", VA = "0x19CBA6C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x19CBB5C", Offset = "0x19CBB5C", VA = "0x19CBB5C")]
		private void Update()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x19CBC44", Offset = "0x19CBC44", VA = "0x19CBC44")]
		public MA_Laser()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class MA_LocalizationUI : MonoBehaviour
	{
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x19CBC4C", Offset = "0x19CBC4C", VA = "0x19CBC4C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x19CBD00", Offset = "0x19CBD00", VA = "0x19CBD00")]
		public MA_LocalizationUI()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class MA_PlayerControl : MonoBehaviour
	{
		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject ProjectilePrefab;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool canShoot;

		[Token(Token = "0x40004E0")]
		private const float MoveSpeed = 10f;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform _trans;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _lastMoveAmt;

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x19CBD08", Offset = "0x19CBD08", VA = "0x19CBD08")]
		private void Awake()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x19CBD48", Offset = "0x19CBD48", VA = "0x19CBD48")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x19CBDF4", Offset = "0x19CBDF4", VA = "0x19CBDF4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x19CBDF8", Offset = "0x19CBDF8", VA = "0x19CBDF8")]
		private void OnBecameInvisible()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x19CBDFC", Offset = "0x19CBDFC", VA = "0x19CBDFC")]
		private void OnBecameVisible()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x19CBE00", Offset = "0x19CBE00", VA = "0x19CBE00")]
		private void Update()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x19CBFDC", Offset = "0x19CBFDC", VA = "0x19CBFDC")]
		public MA_PlayerControl()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class MA_PlayerSpawnerControl : MonoBehaviour
	{
		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject Player;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float nextSpawnTime;

		[Token(Token = "0x170000B8")]
		private bool PlayerActive
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x19CC01C", Offset = "0x19CC01C", VA = "0x19CC01C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x19CBFEC", Offset = "0x19CBFEC", VA = "0x19CBFEC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x19CC038", Offset = "0x19CC038", VA = "0x19CC038")]
		private void Update()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x19CC0BC", Offset = "0x19CC0BC", VA = "0x19CC0BC")]
		public MA_PlayerSpawnerControl()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class MA_SampleICustomEventReceiver : MonoBehaviour, ICustomEventReceiver
	{
		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<string> _eventsSubscribedTo;

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x19CC0C4", Offset = "0x19CC0C4", VA = "0x19CC0C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x19CC0C8", Offset = "0x19CC0C8", VA = "0x19CC0C8")]
		private void Start()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x19CC238", Offset = "0x19CC238", VA = "0x19CC238")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x19CC2B4", Offset = "0x19CC2B4", VA = "0x19CC2B4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x19CC0CC", Offset = "0x19CC0CC", VA = "0x19CC0CC", Slot = "4")]
		public void CheckForIllegalCustomEvents()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x19CC438", Offset = "0x19CC438", VA = "0x19CC438", Slot = "5")]
		public void ReceiveEvent(string customEventName, Vector3 originPoint)
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x19CC584", Offset = "0x19CC584", VA = "0x19CC584", Slot = "6")]
		public bool SubscribesToEvent(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x19CC23C", Offset = "0x19CC23C", VA = "0x19CC23C", Slot = "7")]
		public void RegisterReceiver()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x19CC3D8", Offset = "0x19CC3D8", VA = "0x19CC3D8", Slot = "8")]
		public void UnregisterReceiver()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x19CC60C", Offset = "0x19CC60C", VA = "0x19CC60C", Slot = "9")]
		public IList<AudioEventGroup> GetAllEvents()
		{
			return null;
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x19CC758", Offset = "0x19CC758", VA = "0x19CC758")]
		public MA_SampleICustomEventReceiver()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class MA_TestUI : MonoBehaviour
	{
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x19CC848", Offset = "0x19CC848", VA = "0x19CC848")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x19CC8FC", Offset = "0x19CC8FC", VA = "0x19CC8FC")]
		public MA_TestUI()
		{
		}
	}
}
