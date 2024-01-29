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
	[Address(RVA = "0x1D24594", Offset = "0x1D24594", VA = "0x1D24594")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1D24648", Offset = "0x1D24648", VA = "0x1D24648")]
	public PlaymakerScene()
	{
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821298", Offset = "0x821298")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821298", Offset = "0x821298")]
public class MasterAudioBusFade : FsmStateAction
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82294C", Offset = "0x82294C")]
	public FsmBool allBuses;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822984", Offset = "0x822984")]
	public FsmString busName;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0x8229BC", Offset = "0x8229BC")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8229BC", Offset = "0x8229BC")]
	public FsmFloat targetVolume;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822A20", Offset = "0x822A20")]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0x822A20", Offset = "0x822A20")]
	public FsmFloat fadeTime;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822A84", Offset = "0x822A84")]
	public FsmBool stopBusAfterFade;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822ABC", Offset = "0x822ABC")]
	public FsmBool restoreVolumeAfterFade;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1C5E5D0", Offset = "0x1C5E5D0", VA = "0x1C5E5D0", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1C5E8A8", Offset = "0x1C5E8A8", VA = "0x1C5E8A8", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1C5E9E4", Offset = "0x1C5E9E4", VA = "0x1C5E9E4")]
	public MasterAudioBusFade()
	{
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8212E8", Offset = "0x8212E8")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x8212E8", Offset = "0x8212E8")]
public class MasterAudioBusGetProps : FsmStateAction
{
	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822AF4", Offset = "0x822AF4")]
	public FsmString busName;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x822B40", Offset = "0x822B40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822B40", Offset = "0x822B40")]
	public FsmFloat BusVolume;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x822B90", Offset = "0x822B90")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822B90", Offset = "0x822B90")]
	public FsmBool BusIsMuted;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822BE0", Offset = "0x822BE0")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x822BE0", Offset = "0x822BE0")]
	public FsmBool BusIsSoloed;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822C30", Offset = "0x822C30")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x822C30", Offset = "0x822C30")]
	public FsmInt VoiceLimit;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822C80", Offset = "0x822C80")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x822C80", Offset = "0x822C80")]
	public FsmInt ActiveVoices;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x822CD0", Offset = "0x822CD0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822CD0", Offset = "0x822CD0")]
	public FsmBool VoiceLimitReached;

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1C5E9EC", Offset = "0x1C5E9EC", VA = "0x1C5E9EC", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1C5EC68", Offset = "0x1C5EC68", VA = "0x1C5EC68", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1C5EE0C", Offset = "0x1C5EE0C", VA = "0x1C5EE0C")]
	public MasterAudioBusGetProps()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821338", Offset = "0x821338")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821338", Offset = "0x821338")]
public class MasterAudioBusMute : FsmStateAction
{
	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822D20", Offset = "0x822D20")]
	public FsmBool allBuses;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822D58", Offset = "0x822D58")]
	public FsmString busName;

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1C5EE14", Offset = "0x1C5EE14", VA = "0x1C5EE14", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1C5EFFC", Offset = "0x1C5EFFC", VA = "0x1C5EFFC", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1C5F0DC", Offset = "0x1C5F0DC", VA = "0x1C5F0DC")]
	public MasterAudioBusMute()
	{
	}
}
[Token(Token = "0x2000006")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821388", Offset = "0x821388")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821388", Offset = "0x821388")]
public class MasterAudioBusPause : FsmStateAction
{
	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822D90", Offset = "0x822D90")]
	public FsmBool allBuses;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822DC8", Offset = "0x822DC8")]
	public FsmString busName;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1C5F0E4", Offset = "0x1C5F0E4", VA = "0x1C5F0E4", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1C5F2CC", Offset = "0x1C5F2CC", VA = "0x1C5F2CC", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1C5F3AC", Offset = "0x1C5F3AC", VA = "0x1C5F3AC")]
	public MasterAudioBusPause()
	{
	}
}
[Token(Token = "0x2000007")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x8213D8", Offset = "0x8213D8")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8213D8", Offset = "0x8213D8")]
public class MasterAudioBusSetVolume : FsmStateAction
{
	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822E00", Offset = "0x822E00")]
	public FsmBool allBuses;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822E38", Offset = "0x822E38")]
	public FsmString busName;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0x822E70", Offset = "0x822E70")]
	[RequiredField]
	public FsmFloat volume;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822EB0", Offset = "0x822EB0")]
	public bool everyFrame;

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1C5F3B4", Offset = "0x1C5F3B4", VA = "0x1C5F3B4", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1C5F61C", Offset = "0x1C5F61C", VA = "0x1C5F61C", Slot = "34")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1C5F3F0", Offset = "0x1C5F3F0", VA = "0x1C5F3F0")]
	private void SetVolume()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1C5F620", Offset = "0x1C5F620", VA = "0x1C5F620", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1C5F750", Offset = "0x1C5F750", VA = "0x1C5F750")]
	public MasterAudioBusSetVolume()
	{
	}
}
[Token(Token = "0x2000008")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821428", Offset = "0x821428")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821428", Offset = "0x821428")]
public class MasterAudioBusSolo : FsmStateAction
{
	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822EE8", Offset = "0x822EE8")]
	public FsmBool allBuses;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822F20", Offset = "0x822F20")]
	public FsmString busName;

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1C5F7E0", Offset = "0x1C5F7E0", VA = "0x1C5F7E0", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1C5F9C8", Offset = "0x1C5F9C8", VA = "0x1C5F9C8", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1C5FAA8", Offset = "0x1C5FAA8", VA = "0x1C5FAA8")]
	public MasterAudioBusSolo()
	{
	}
}
[Token(Token = "0x2000009")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821478", Offset = "0x821478")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821478", Offset = "0x821478")]
public class MasterAudioBusStop : FsmStateAction
{
	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822F58", Offset = "0x822F58")]
	public FsmBool allBuses;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822F90", Offset = "0x822F90")]
	public FsmString busName;

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1C5FAB0", Offset = "0x1C5FAB0", VA = "0x1C5FAB0", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1C5FC98", Offset = "0x1C5FC98", VA = "0x1C5FC98", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1C5FD78", Offset = "0x1C5FD78", VA = "0x1C5FD78")]
	public MasterAudioBusStop()
	{
	}
}
[Token(Token = "0x200000A")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x8214C8", Offset = "0x8214C8")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8214C8", Offset = "0x8214C8")]
public class MasterAudioBusUnmute : FsmStateAction
{
	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822FC8", Offset = "0x822FC8")]
	public FsmBool allBuses;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823000", Offset = "0x823000")]
	public FsmString busName;

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1C5FD80", Offset = "0x1C5FD80", VA = "0x1C5FD80", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1C5FF70", Offset = "0x1C5FF70", VA = "0x1C5FF70", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1C60050", Offset = "0x1C60050", VA = "0x1C60050")]
	public MasterAudioBusUnmute()
	{
	}
}
[Token(Token = "0x200000B")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821518", Offset = "0x821518")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821518", Offset = "0x821518")]
public class MasterAudioBusUnpause : FsmStateAction
{
	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823038", Offset = "0x823038")]
	public FsmBool allBuses;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823070", Offset = "0x823070")]
	public FsmString busName;

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1C60058", Offset = "0x1C60058", VA = "0x1C60058", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1C60240", Offset = "0x1C60240", VA = "0x1C60240", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1C60320", Offset = "0x1C60320", VA = "0x1C60320")]
	public MasterAudioBusUnpause()
	{
	}
}
[Token(Token = "0x200000C")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821568", Offset = "0x821568")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821568", Offset = "0x821568")]
public class MasterAudioBusUnsolo : FsmStateAction
{
	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8230A8", Offset = "0x8230A8")]
	public FsmBool allBuses;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8230E0", Offset = "0x8230E0")]
	public FsmString busName;

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1C60328", Offset = "0x1C60328", VA = "0x1C60328", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1C60518", Offset = "0x1C60518", VA = "0x1C60518", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1C605F8", Offset = "0x1C605F8", VA = "0x1C605F8")]
	public MasterAudioBusUnsolo()
	{
	}
}
[Token(Token = "0x200000D")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x8215B8", Offset = "0x8215B8")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8215B8", Offset = "0x8215B8")]
public class MasterAudioDuckingAddGroup : FsmStateAction
{
	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823118", Offset = "0x823118")]
	[RequiredField]
	public FsmString soundGroupName;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0x823164", Offset = "0x823164")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823164", Offset = "0x823164")]
	[RequiredField]
	public FsmFloat riseVolumeStart;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8231C8", Offset = "0x8231C8")]
	[RequiredField]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0x8231C8", Offset = "0x8231C8")]
	public FsmFloat beginUnduck;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[RequiredField]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0x82322C", Offset = "0x82322C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82322C", Offset = "0x82322C")]
	public FsmFloat unduckTime;

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1C60600", Offset = "0x1C60600", VA = "0x1C60600", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1C606E8", Offset = "0x1C606E8", VA = "0x1C606E8", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1C608D8", Offset = "0x1C608D8", VA = "0x1C608D8")]
	public MasterAudioDuckingAddGroup()
	{
	}
}
[Token(Token = "0x200000E")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821608", Offset = "0x821608")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821608", Offset = "0x821608")]
public class MasterAudioDuckingRemoveGroup : FsmStateAction
{
	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823290", Offset = "0x823290")]
	[RequiredField]
	public FsmString soundGroupName;

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1C608E0", Offset = "0x1C608E0", VA = "0x1C608E0", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1C6096C", Offset = "0x1C6096C", VA = "0x1C6096C", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1C609FC", Offset = "0x1C609FC", VA = "0x1C609FC")]
	public MasterAudioDuckingRemoveGroup()
	{
	}
}
[Token(Token = "0x200000F")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821658", Offset = "0x821658")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821658", Offset = "0x821658")]
public class MasterAudioDuckingToggle : FsmStateAction
{
	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8232DC", Offset = "0x8232DC")]
	[RequiredField]
	public FsmBool enableDucking;

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1C60A04", Offset = "0x1C60A04", VA = "0x1C60A04", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1C60A98", Offset = "0x1C60A98", VA = "0x1C60A98", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1C60B1C", Offset = "0x1C60B1C", VA = "0x1C60B1C")]
	public MasterAudioDuckingToggle()
	{
	}
}
[Token(Token = "0x2000010")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x8216A8", Offset = "0x8216A8")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8216A8", Offset = "0x8216A8")]
public class MasterAudioEverythingMute : FsmStateAction
{
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1C60B24", Offset = "0x1C60B24", VA = "0x1C60B24", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1C60B90", Offset = "0x1C60B90", VA = "0x1C60B90", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1C60B94", Offset = "0x1C60B94", VA = "0x1C60B94")]
	public MasterAudioEverythingMute()
	{
	}
}
[Token(Token = "0x2000011")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x8216F8", Offset = "0x8216F8")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8216F8", Offset = "0x8216F8")]
public class MasterAudioEverythingPause : FsmStateAction
{
	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1C60B9C", Offset = "0x1C60B9C", VA = "0x1C60B9C", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1C60C08", Offset = "0x1C60C08", VA = "0x1C60C08", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1C60C0C", Offset = "0x1C60C0C", VA = "0x1C60C0C")]
	public MasterAudioEverythingPause()
	{
	}
}
[Token(Token = "0x2000012")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821748", Offset = "0x821748")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821748", Offset = "0x821748")]
public class MasterAudioEverythingStop : FsmStateAction
{
	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1C60C14", Offset = "0x1C60C14", VA = "0x1C60C14", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1C60C80", Offset = "0x1C60C80", VA = "0x1C60C80", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1C60C84", Offset = "0x1C60C84", VA = "0x1C60C84")]
	public MasterAudioEverythingStop()
	{
	}
}
[Token(Token = "0x2000013")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821798", Offset = "0x821798")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821798", Offset = "0x821798")]
public class MasterAudioEverythingUnmute : FsmStateAction
{
	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1C60C8C", Offset = "0x1C60C8C", VA = "0x1C60C8C", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1C60CF8", Offset = "0x1C60CF8", VA = "0x1C60CF8", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1C60CFC", Offset = "0x1C60CFC", VA = "0x1C60CFC")]
	public MasterAudioEverythingUnmute()
	{
	}
}
[Token(Token = "0x2000014")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8217E8", Offset = "0x8217E8")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x8217E8", Offset = "0x8217E8")]
public class MasterAudioEverythingUnpause : FsmStateAction
{
	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1C60D04", Offset = "0x1C60D04", VA = "0x1C60D04", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1C60D70", Offset = "0x1C60D70", VA = "0x1C60D70", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1C60D74", Offset = "0x1C60D74", VA = "0x1C60D74")]
	public MasterAudioEverythingUnpause()
	{
	}
}
[Token(Token = "0x2000015")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821838", Offset = "0x821838")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821838", Offset = "0x821838")]
public class MasterAudioFadeOutAllOfSound : FsmStateAction
{
	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823328", Offset = "0x823328")]
	public FsmBool allGroups;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823360", Offset = "0x823360")]
	public FsmString soundGroupName;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823398", Offset = "0x823398")]
	[RequiredField]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0x823398", Offset = "0x823398")]
	public FsmFloat fadeTime;

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x1C60D7C", Offset = "0x1C60D7C", VA = "0x1C60D7C", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1C60FA0", Offset = "0x1C60FA0", VA = "0x1C60FA0", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1C610B8", Offset = "0x1C610B8", VA = "0x1C610B8")]
	public MasterAudioFadeOutAllOfSound()
	{
	}
}
[Token(Token = "0x2000016")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821888", Offset = "0x821888")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821888", Offset = "0x821888")]
public class MasterAudioFireCustomEvent : FsmStateAction
{
	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8233FC", Offset = "0x8233FC")]
	public FsmString customEventName;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823448", Offset = "0x823448")]
	public FsmOwnerDefault eventOrigin;

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x1C610C0", Offset = "0x1C610C0", VA = "0x1C610C0", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x1C611F4", Offset = "0x1C611F4", VA = "0x1C611F4", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x1C61294", Offset = "0x1C61294", VA = "0x1C61294")]
	public MasterAudioFireCustomEvent()
	{
	}
}
[Token(Token = "0x2000017")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x8218D8", Offset = "0x8218D8")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8218D8", Offset = "0x8218D8")]
public class MasterAudioGroupFade : FsmStateAction
{
	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823480", Offset = "0x823480")]
	public FsmBool allGroups;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8234B8", Offset = "0x8234B8")]
	public FsmString soundGroupName;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[RequiredField]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0x8234F0", Offset = "0x8234F0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8234F0", Offset = "0x8234F0")]
	public FsmFloat targetVolume;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823554", Offset = "0x823554")]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0x823554", Offset = "0x823554")]
	public FsmFloat fadeTime;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8235B8", Offset = "0x8235B8")]
	public FsmBool stopGroupAfterFade;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8235F0", Offset = "0x8235F0")]
	public FsmBool restoreVolumeAfterFade;

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x1C61EB8", Offset = "0x1C61EB8", VA = "0x1C61EB8", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1C62190", Offset = "0x1C62190", VA = "0x1C62190", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x1C622CC", Offset = "0x1C622CC", VA = "0x1C622CC")]
	public MasterAudioGroupFade()
	{
	}
}
[Token(Token = "0x2000018")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821928", Offset = "0x821928")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821928", Offset = "0x821928")]
public class MasterAudioGroupIsPlaying : FsmStateAction
{
	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823628", Offset = "0x823628")]
	public FsmString soundGroupName;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823674", Offset = "0x823674")]
	public FsmEvent isPlayingEvent;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8236AC", Offset = "0x8236AC")]
	public FsmEvent notPlayingEvent;

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1C622D4", Offset = "0x1C622D4", VA = "0x1C622D4", Slot = "34")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x1C623C0", Offset = "0x1C623C0", VA = "0x1C623C0")]
	public MasterAudioGroupIsPlaying()
	{
	}
}
[Token(Token = "0x2000019")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821978", Offset = "0x821978")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821978", Offset = "0x821978")]
public class MasterAudioGroupMute : FsmStateAction
{
	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8236E4", Offset = "0x8236E4")]
	public FsmBool allGroups;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82371C", Offset = "0x82371C")]
	public FsmString soundGroupName;

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1C623C8", Offset = "0x1C623C8", VA = "0x1C623C8", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x1C625B8", Offset = "0x1C625B8", VA = "0x1C625B8", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1C62698", Offset = "0x1C62698", VA = "0x1C62698")]
	public MasterAudioGroupMute()
	{
	}
}
[Token(Token = "0x200001A")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x8219C8", Offset = "0x8219C8")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8219C8", Offset = "0x8219C8")]
public class MasterAudioGroupPause : FsmStateAction
{
	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823754", Offset = "0x823754")]
	public FsmBool allGroups;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82378C", Offset = "0x82378C")]
	public FsmString soundGroupName;

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x1C626A0", Offset = "0x1C626A0", VA = "0x1C626A0", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1C62888", Offset = "0x1C62888", VA = "0x1C62888", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1C62968", Offset = "0x1C62968", VA = "0x1C62968")]
	public MasterAudioGroupPause()
	{
	}
}
[Token(Token = "0x200001B")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821A18", Offset = "0x821A18")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821A18", Offset = "0x821A18")]
public class MasterAudioGroupSetPitch : FsmStateAction
{
	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8237C4", Offset = "0x8237C4")]
	[RequiredField]
	public FsmString soundGroupName;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823810", Offset = "0x823810")]
	public FsmBool allVariations;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823848", Offset = "0x823848")]
	public FsmString variationName;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823880", Offset = "0x823880")]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0x823880", Offset = "0x823880")]
	[RequiredField]
	public FsmFloat pitch;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8238E4", Offset = "0x8238E4")]
	public bool everyFrame;

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1C62970", Offset = "0x1C62970", VA = "0x1C62970", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1C62A48", Offset = "0x1C62A48", VA = "0x1C62A48", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1C62C44", Offset = "0x1C62C44", VA = "0x1C62C44", Slot = "34")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x1C62A84", Offset = "0x1C62A84", VA = "0x1C62A84")]
	private void SetPitch()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1C62C48", Offset = "0x1C62C48", VA = "0x1C62C48")]
	public MasterAudioGroupSetPitch()
	{
	}
}
[Token(Token = "0x200001C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821A68", Offset = "0x821A68")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821A68", Offset = "0x821A68")]
public class MasterAudioGroupSetVolume : FsmStateAction
{
	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82391C", Offset = "0x82391C")]
	public FsmBool allGroups;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823954", Offset = "0x823954")]
	public FsmString soundGroupName;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[RequiredField]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0x82398C", Offset = "0x82398C")]
	public FsmFloat volume;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8239CC", Offset = "0x8239CC")]
	public bool everyFrame;

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1C62CD8", Offset = "0x1C62CD8", VA = "0x1C62CD8", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x1C62F40", Offset = "0x1C62F40", VA = "0x1C62F40", Slot = "34")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1C62D14", Offset = "0x1C62D14", VA = "0x1C62D14")]
	private void SetVolume()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1C62F44", Offset = "0x1C62F44", VA = "0x1C62F44", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1C63074", Offset = "0x1C63074", VA = "0x1C63074")]
	public MasterAudioGroupSetVolume()
	{
	}
}
[Token(Token = "0x200001D")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821AB8", Offset = "0x821AB8")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821AB8", Offset = "0x821AB8")]
public class MasterAudioGroupSolo : FsmStateAction
{
	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823A04", Offset = "0x823A04")]
	public FsmBool allGroups;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823A3C", Offset = "0x823A3C")]
	public FsmString soundGroupName;

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x1C63104", Offset = "0x1C63104", VA = "0x1C63104", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1C632F4", Offset = "0x1C632F4", VA = "0x1C632F4", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1C633D4", Offset = "0x1C633D4", VA = "0x1C633D4")]
	public MasterAudioGroupSolo()
	{
	}
}
[Token(Token = "0x200001E")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821B08", Offset = "0x821B08")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821B08", Offset = "0x821B08")]
public class MasterAudioGroupToggleMute : FsmStateAction
{
	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823A74", Offset = "0x823A74")]
	public FsmBool allGroups;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823AAC", Offset = "0x823AAC")]
	public FsmString soundGroupName;

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x1C633DC", Offset = "0x1C633DC", VA = "0x1C633DC", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x1C63734", Offset = "0x1C63734", VA = "0x1C63734", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x1C63814", Offset = "0x1C63814", VA = "0x1C63814")]
	public MasterAudioGroupToggleMute()
	{
	}
}
[Token(Token = "0x200001F")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821B58", Offset = "0x821B58")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821B58", Offset = "0x821B58")]
public class MasterAudioGroupToggleSolo : FsmStateAction
{
	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823AE4", Offset = "0x823AE4")]
	public FsmBool allGroups;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823B1C", Offset = "0x823B1C")]
	public FsmString soundGroupName;

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x1C6381C", Offset = "0x1C6381C", VA = "0x1C6381C", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x1C63B74", Offset = "0x1C63B74", VA = "0x1C63B74", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x1C63C54", Offset = "0x1C63C54", VA = "0x1C63C54")]
	public MasterAudioGroupToggleSolo()
	{
	}
}
[Token(Token = "0x2000020")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821BA8", Offset = "0x821BA8")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821BA8", Offset = "0x821BA8")]
public class MasterAudioGroupUnmute : FsmStateAction
{
	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823B54", Offset = "0x823B54")]
	public FsmBool allGroups;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823B8C", Offset = "0x823B8C")]
	public FsmString soundGroupName;

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x1C63C5C", Offset = "0x1C63C5C", VA = "0x1C63C5C", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x1C63E4C", Offset = "0x1C63E4C", VA = "0x1C63E4C", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x1C63F2C", Offset = "0x1C63F2C", VA = "0x1C63F2C")]
	public MasterAudioGroupUnmute()
	{
	}
}
[Token(Token = "0x2000021")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821BF8", Offset = "0x821BF8")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821BF8", Offset = "0x821BF8")]
public class MasterAudioGroupUnpause : FsmStateAction
{
	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823BC4", Offset = "0x823BC4")]
	public FsmBool allGroups;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823BFC", Offset = "0x823BFC")]
	public FsmString soundGroupName;

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x1C63F34", Offset = "0x1C63F34", VA = "0x1C63F34", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x1C6411C", Offset = "0x1C6411C", VA = "0x1C6411C", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x1C641FC", Offset = "0x1C641FC", VA = "0x1C641FC")]
	public MasterAudioGroupUnpause()
	{
	}
}
[Token(Token = "0x2000022")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821C48", Offset = "0x821C48")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821C48", Offset = "0x821C48")]
public class MasterAudioGroupUnsolo : FsmStateAction
{
	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823C34", Offset = "0x823C34")]
	public FsmBool allGroups;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823C6C", Offset = "0x823C6C")]
	public FsmString soundGroupName;

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x1C64204", Offset = "0x1C64204", VA = "0x1C64204", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x1C643F4", Offset = "0x1C643F4", VA = "0x1C643F4", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x1C644D4", Offset = "0x1C644D4", VA = "0x1C644D4")]
	public MasterAudioGroupUnsolo()
	{
	}
}
[Token(Token = "0x2000023")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821C98", Offset = "0x821C98")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821C98", Offset = "0x821C98")]
public class MasterAudioMixerPause : FsmStateAction
{
	[Token(Token = "0x6000068")]
	[Address(RVA = "0x1C644DC", Offset = "0x1C644DC", VA = "0x1C644DC", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x1C64548", Offset = "0x1C64548", VA = "0x1C64548", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x1C6454C", Offset = "0x1C6454C", VA = "0x1C6454C")]
	public MasterAudioMixerPause()
	{
	}
}
[Token(Token = "0x2000024")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821CE8", Offset = "0x821CE8")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821CE8", Offset = "0x821CE8")]
public class MasterAudioMixerStop : FsmStateAction
{
	[Token(Token = "0x600006B")]
	[Address(RVA = "0x1C64554", Offset = "0x1C64554", VA = "0x1C64554", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x1C645C0", Offset = "0x1C645C0", VA = "0x1C645C0", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x1C645C4", Offset = "0x1C645C4", VA = "0x1C645C4")]
	public MasterAudioMixerStop()
	{
	}
}
[Token(Token = "0x2000025")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821D38", Offset = "0x821D38")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821D38", Offset = "0x821D38")]
public class MasterAudioMixerUnpause : FsmStateAction
{
	[Token(Token = "0x600006E")]
	[Address(RVA = "0x1C645CC", Offset = "0x1C645CC", VA = "0x1C645CC", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x1C64638", Offset = "0x1C64638", VA = "0x1C64638", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x1C6463C", Offset = "0x1C6463C", VA = "0x1C6463C")]
	public MasterAudioMixerUnpause()
	{
	}
}
[Token(Token = "0x2000026")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821D88", Offset = "0x821D88")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821D88", Offset = "0x821D88")]
public class MasterAudioPlaySound : FsmStateAction
{
	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823CA4", Offset = "0x823CA4")]
	[RequiredField]
	public FsmOwnerDefault gameObject;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823CF0", Offset = "0x823CF0")]
	[RequiredField]
	public FsmString soundGroupName;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823D3C", Offset = "0x823D3C")]
	public FsmString variationName;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0x823D74", Offset = "0x823D74")]
	[RequiredField]
	public FsmFloat volume;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0x823DB4", Offset = "0x823DB4")]
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
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0x823DCC", Offset = "0x823DCC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823DCC", Offset = "0x823DCC")]
	public FsmFloat fixedPitch;

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x1C64644", Offset = "0x1C64644", VA = "0x1C64644", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x1C6494C", Offset = "0x1C6494C", VA = "0x1C6494C", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x1C64BC4", Offset = "0x1C64BC4", VA = "0x1C64BC4")]
	public MasterAudioPlaySound()
	{
	}
}
[Token(Token = "0x2000027")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821DD8", Offset = "0x821DD8")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821DD8", Offset = "0x821DD8")]
public class MasterAudioPlaySoundWithEvent : FsmStateAction
{
	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823E20", Offset = "0x823E20")]
	public FsmOwnerDefault gameObject;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823E6C", Offset = "0x823E6C")]
	[RequiredField]
	public FsmString soundGroupName;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823EB8", Offset = "0x823EB8")]
	public FsmString variationName;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[RequiredField]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0x823EF0", Offset = "0x823EF0")]
	public FsmFloat volume;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0x823F30", Offset = "0x823F30")]
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
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823F48", Offset = "0x823F48")]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0x823F48", Offset = "0x823F48")]
	public FsmFloat fixedPitch;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823F9C", Offset = "0x823F9C")]
	public FsmEvent finishedEvent;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private PlaySoundResult sound;

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x1C64DA8", Offset = "0x1C64DA8", VA = "0x1C64DA8", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x1C64DEC", Offset = "0x1C64DEC", VA = "0x1C64DEC", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x1C65128", Offset = "0x1C65128", VA = "0x1C65128", Slot = "34")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x1C65194", Offset = "0x1C65194", VA = "0x1C65194")]
	public MasterAudioPlaySoundWithEvent()
	{
	}
}
[Token(Token = "0x2000028")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821E28", Offset = "0x821E28")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821E28", Offset = "0x821E28")]
public class MasterAudioPlaylistChange : FsmStateAction
{
	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x823FD4", Offset = "0x823FD4")]
	public FsmString playlistControllerName;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82400C", Offset = "0x82400C")]
	public FsmString playlistName;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824058", Offset = "0x824058")]
	public FsmBool playFirstSong;

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x1C65378", Offset = "0x1C65378", VA = "0x1C65378", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1C654C4", Offset = "0x1C654C4", VA = "0x1C654C4", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x1C655C8", Offset = "0x1C655C8", VA = "0x1C655C8")]
	public MasterAudioPlaylistChange()
	{
	}
}
[Token(Token = "0x2000029")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821E78", Offset = "0x821E78")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821E78", Offset = "0x821E78")]
public class MasterAudioPlaylistClipByName : FsmStateAction
{
	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8240A4", Offset = "0x8240A4")]
	public FsmString playlistControllerName;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8240DC", Offset = "0x8240DC")]
	public FsmString clipName;

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x1C655D0", Offset = "0x1C655D0", VA = "0x1C655D0", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x1C656E4", Offset = "0x1C656E4", VA = "0x1C656E4", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x1C657B0", Offset = "0x1C657B0", VA = "0x1C657B0")]
	public MasterAudioPlaylistClipByName()
	{
	}
}
[Token(Token = "0x200002A")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821EC8", Offset = "0x821EC8")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821EC8", Offset = "0x821EC8")]
public class MasterAudioPlaylistClipNext : FsmStateAction
{
	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824128", Offset = "0x824128")]
	public FsmBool allPlaylistControllers;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824160", Offset = "0x824160")]
	public FsmString playlistControllerName;

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x1C657B8", Offset = "0x1C657B8", VA = "0x1C657B8", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x1C65B4C", Offset = "0x1C65B4C", VA = "0x1C65B4C", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x1C65C2C", Offset = "0x1C65C2C", VA = "0x1C65C2C")]
	public MasterAudioPlaylistClipNext()
	{
	}
}
[Token(Token = "0x200002B")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821F18", Offset = "0x821F18")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821F18", Offset = "0x821F18")]
public class MasterAudioPlaylistClipRandom : FsmStateAction
{
	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824198", Offset = "0x824198")]
	public FsmBool allPlaylistControllers;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8241D0", Offset = "0x8241D0")]
	public FsmString playlistControllerName;

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1C65C34", Offset = "0x1C65C34", VA = "0x1C65C34", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1C65DD0", Offset = "0x1C65DD0", VA = "0x1C65DD0", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1C65EB0", Offset = "0x1C65EB0", VA = "0x1C65EB0")]
	public MasterAudioPlaylistClipRandom()
	{
	}
}
[Token(Token = "0x200002C")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821F68", Offset = "0x821F68")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821F68", Offset = "0x821F68")]
public class MasterAudioPlaylistControllerGetProps : FsmStateAction
{
	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824208", Offset = "0x824208")]
	public FsmString PlaylistControllerName;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824240", Offset = "0x824240")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x824240", Offset = "0x824240")]
	public FsmFloat ControllerVolume;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x824290", Offset = "0x824290")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824290", Offset = "0x824290")]
	public FsmFloat CurrentAudioClipPitch;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8242E0", Offset = "0x8242E0")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x8242E0", Offset = "0x8242E0")]
	public FsmFloat CurrentAudioClipVolume;

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1C65EB8", Offset = "0x1C65EB8", VA = "0x1C65EB8", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1C664A0", Offset = "0x1C664A0", VA = "0x1C664A0", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1C665B0", Offset = "0x1C665B0", VA = "0x1C665B0")]
	public MasterAudioPlaylistControllerGetProps()
	{
	}
}
[Token(Token = "0x200002D")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x821FB8", Offset = "0x821FB8")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x821FB8", Offset = "0x821FB8")]
public class MasterAudioPlaylistFade : FsmStateAction
{
	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824330", Offset = "0x824330")]
	public FsmString playlistControllerName;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824368", Offset = "0x824368")]
	[RequiredField]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0x824368", Offset = "0x824368")]
	public FsmFloat targetVolume;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8243CC", Offset = "0x8243CC")]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0x8243CC", Offset = "0x8243CC")]
	public FsmFloat fadeTime;

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1C665B8", Offset = "0x1C665B8", VA = "0x1C665B8", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1C666F4", Offset = "0x1C666F4", VA = "0x1C666F4", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x1C667E0", Offset = "0x1C667E0", VA = "0x1C667E0")]
	public MasterAudioPlaylistFade()
	{
	}
}
[Token(Token = "0x200002E")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822008", Offset = "0x822008")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x822008", Offset = "0x822008")]
public class MasterAudioPlaylistGetCurrentClipName : FsmStateAction
{
	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824430", Offset = "0x824430")]
	public FsmString playlistControllerName;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x824468", Offset = "0x824468")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824468", Offset = "0x824468")]
	public FsmString storeResult;

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x1C667E8", Offset = "0x1C667E8", VA = "0x1C667E8", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x1C669D0", Offset = "0x1C669D0", VA = "0x1C669D0", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x1C66A9C", Offset = "0x1C66A9C", VA = "0x1C66A9C")]
	public MasterAudioPlaylistGetCurrentClipName()
	{
	}
}
[Token(Token = "0x200002F")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822058", Offset = "0x822058")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x822058", Offset = "0x822058")]
public class MasterAudioPlaylistMute : FsmStateAction
{
	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8244C8", Offset = "0x8244C8")]
	public FsmBool allPlaylistControllers;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824500", Offset = "0x824500")]
	public FsmString playlistControllerName;

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x1C66AA4", Offset = "0x1C66AA4", VA = "0x1C66AA4", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x1C66BF8", Offset = "0x1C66BF8", VA = "0x1C66BF8", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x1C66CD8", Offset = "0x1C66CD8", VA = "0x1C66CD8")]
	public MasterAudioPlaylistMute()
	{
	}
}
[Token(Token = "0x2000030")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x8220A8", Offset = "0x8220A8")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8220A8", Offset = "0x8220A8")]
public class MasterAudioPlaylistPause : FsmStateAction
{
	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824538", Offset = "0x824538")]
	public FsmBool allPlaylistControllers;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824570", Offset = "0x824570")]
	public FsmString playlistControllerName;

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x1C66CE0", Offset = "0x1C66CE0", VA = "0x1C66CE0", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x1C66E7C", Offset = "0x1C66E7C", VA = "0x1C66E7C", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x1C66F5C", Offset = "0x1C66F5C", VA = "0x1C66F5C")]
	public MasterAudioPlaylistPause()
	{
	}
}
[Token(Token = "0x2000031")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x8220F8", Offset = "0x8220F8")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8220F8", Offset = "0x8220F8")]
public class MasterAudioPlaylistSetVolume : FsmStateAction
{
	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8245A8", Offset = "0x8245A8")]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0x8245A8", Offset = "0x8245A8")]
	[RequiredField]
	public FsmFloat newVolume;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82460C", Offset = "0x82460C")]
	public bool everyFrame;

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x1C66F64", Offset = "0x1C66F64", VA = "0x1C66F64", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x1C67024", Offset = "0x1C67024", VA = "0x1C67024", Slot = "34")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x1C66FA0", Offset = "0x1C66FA0", VA = "0x1C66FA0")]
	private void SetVolume()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x1C67028", Offset = "0x1C67028", VA = "0x1C67028", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x1C6708C", Offset = "0x1C6708C", VA = "0x1C6708C")]
	public MasterAudioPlaylistSetVolume()
	{
	}
}
[Token(Token = "0x2000032")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822148", Offset = "0x822148")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x822148", Offset = "0x822148")]
public class MasterAudioPlaylistStartByName : FsmStateAction
{
	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824644", Offset = "0x824644")]
	public FsmString playlistControllerName;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82467C", Offset = "0x82467C")]
	public FsmString playlistName;

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x1C67094", Offset = "0x1C67094", VA = "0x1C67094", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x1C671AC", Offset = "0x1C671AC", VA = "0x1C671AC", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x1C67278", Offset = "0x1C67278", VA = "0x1C67278")]
	public MasterAudioPlaylistStartByName()
	{
	}
}
[Token(Token = "0x2000033")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x822198", Offset = "0x822198")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822198", Offset = "0x822198")]
public class MasterAudioPlaylistStop : FsmStateAction
{
	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8246C8", Offset = "0x8246C8")]
	public FsmBool allPlaylistControllers;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824700", Offset = "0x824700")]
	public FsmString playlistControllerName;

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x1C67280", Offset = "0x1C67280", VA = "0x1C67280", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x1C6741C", Offset = "0x1C6741C", VA = "0x1C6741C", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x1C674FC", Offset = "0x1C674FC", VA = "0x1C674FC")]
	public MasterAudioPlaylistStop()
	{
	}
}
[Token(Token = "0x2000034")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x8221E8", Offset = "0x8221E8")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8221E8", Offset = "0x8221E8")]
public class MasterAudioPlaylistToggleMute : FsmStateAction
{
	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824738", Offset = "0x824738")]
	public FsmBool allPlaylistControllers;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824770", Offset = "0x824770")]
	public FsmString playlistControllerName;

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x1C67504", Offset = "0x1C67504", VA = "0x1C67504", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x1C67658", Offset = "0x1C67658", VA = "0x1C67658", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x1C67738", Offset = "0x1C67738", VA = "0x1C67738")]
	public MasterAudioPlaylistToggleMute()
	{
	}
}
[Token(Token = "0x2000035")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x822238", Offset = "0x822238")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822238", Offset = "0x822238")]
public class MasterAudioPlaylistUnmute : FsmStateAction
{
	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8247A8", Offset = "0x8247A8")]
	public FsmBool allPlaylistControllers;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8247E0", Offset = "0x8247E0")]
	public FsmString playlistControllerName;

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x1C67740", Offset = "0x1C67740", VA = "0x1C67740", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x1C67894", Offset = "0x1C67894", VA = "0x1C67894", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x1C67974", Offset = "0x1C67974", VA = "0x1C67974")]
	public MasterAudioPlaylistUnmute()
	{
	}
}
[Token(Token = "0x2000036")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x822288", Offset = "0x822288")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822288", Offset = "0x822288")]
public class MasterAudioPlaylistUnpause : FsmStateAction
{
	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824818", Offset = "0x824818")]
	public FsmBool allPlaylistControllers;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824850", Offset = "0x824850")]
	public FsmString playlistControllerName;

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x1C6797C", Offset = "0x1C6797C", VA = "0x1C6797C", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x1C67B18", Offset = "0x1C67B18", VA = "0x1C67B18", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x1C67BF8", Offset = "0x1C67BF8", VA = "0x1C67BF8")]
	public MasterAudioPlaylistUnpause()
	{
	}
}
[Token(Token = "0x2000037")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x8222D8", Offset = "0x8222D8")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8222D8", Offset = "0x8222D8")]
public class MasterAudioSetMasterVolume : FsmStateAction
{
	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "HasFloatSliderAttribute", RVA = "0x824888", Offset = "0x824888")]
	[RequiredField]
	public FsmFloat volume;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8248C8", Offset = "0x8248C8")]
	public bool everyFrame;

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x1C67C00", Offset = "0x1C67C00", VA = "0x1C67C00", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x1C67CC0", Offset = "0x1C67CC0", VA = "0x1C67CC0", Slot = "34")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x1C67C3C", Offset = "0x1C67C3C", VA = "0x1C67C3C")]
	private void SetVolume()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x1C67CC4", Offset = "0x1C67CC4", VA = "0x1C67CC4", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x1C67D48", Offset = "0x1C67D48", VA = "0x1C67D48")]
	public MasterAudioSetMasterVolume()
	{
	}
}
[Token(Token = "0x2000038")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x822328", Offset = "0x822328")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822328", Offset = "0x822328")]
public class MasterAudioStopAllOfSound : FsmStateAction
{
	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824900", Offset = "0x824900")]
	public FsmBool allGroups;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824938", Offset = "0x824938")]
	public FsmString soundGroupName;

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x1C67DD8", Offset = "0x1C67DD8", VA = "0x1C67DD8", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x1C67FC0", Offset = "0x1C67FC0", VA = "0x1C67FC0", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x1C680A0", Offset = "0x1C680A0", VA = "0x1C680A0")]
	public MasterAudioStopAllOfSound()
	{
	}
}
[Token(Token = "0x2000039")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x822378", Offset = "0x822378")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x822378", Offset = "0x822378")]
public class MasterAudioStopTransformSound : FsmStateAction
{
	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824970", Offset = "0x824970")]
	[RequiredField]
	public FsmOwnerDefault gameObject;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8249BC", Offset = "0x8249BC")]
	public FsmBool allGroups;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8249F4", Offset = "0x8249F4")]
	public FsmString soundGroupName;

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x1C680A8", Offset = "0x1C680A8", VA = "0x1C680A8", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x1C682CC", Offset = "0x1C682CC", VA = "0x1C682CC", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x1C683E4", Offset = "0x1C683E4", VA = "0x1C683E4")]
	public MasterAudioStopTransformSound()
	{
	}
}
[Token(Token = "0x200003A")]
[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8223C8", Offset = "0x8223C8")]
[AttributeAttribute(Name = "ActionCategoryAttribute", RVA = "0x8223C8", Offset = "0x8223C8")]
public class MasterAudioVariationGetProps : FsmStateAction
{
	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824A2C", Offset = "0x824A2C")]
	public FsmString SoundGroupName;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[RequiredField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824A78", Offset = "0x824A78")]
	public FsmString VariationName;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x824AC4", Offset = "0x824AC4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824AC4", Offset = "0x824AC4")]
	public FsmFloat VariationPitch;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "UIHintAttribute", RVA = "0x824B14", Offset = "0x824B14")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824B14", Offset = "0x824B14")]
	public FsmFloat VariationVolume;

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x1C68454", Offset = "0x1C68454", VA = "0x1C68454", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x1C688E4", Offset = "0x1C688E4", VA = "0x1C688E4", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x1C689F4", Offset = "0x1C689F4", VA = "0x1C689F4")]
	public MasterAudioVariationGetProps()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x1C689FC", Offset = "0x1C689FC", VA = "0x1C689FC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x825770", Offset = "0x825770")]
	private bool <OnEnter>b__4_0(MasterAudio.AudioInfo obj)
	{
		return default(bool);
	}
}
[Token(Token = "0x200003B")]
[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x822418", Offset = "0x822418")]
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
		[Address(RVA = "0x15B5470", Offset = "0x15B5470", VA = "0x15B5470")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public GameObject GameObj
	{
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x15B58B0", Offset = "0x15B58B0", VA = "0x15B58B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	public Transform Trans
	{
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x15B5698", Offset = "0x15B5698", VA = "0x15B5698")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x15B53F8", Offset = "0x15B53F8", VA = "0x15B53F8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x1596CFC", Offset = "0x1596CFC", VA = "0x1596CFC")]
	public void StartFollowing(Transform transToFollow, float trigRadius)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x15970B0", Offset = "0x15970B0", VA = "0x15970B0")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x15B5544", Offset = "0x15B5544", VA = "0x15B5544")]
	private void BatchOcclusionRaycasts()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x15B5950", Offset = "0x15B5950", VA = "0x15B5950")]
	public ListenerFollower()
	{
	}
}
[Token(Token = "0x200003C")]
public static class OculusAudioHelper
{
	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x1C6A7C8", Offset = "0x1C6A7C8", VA = "0x1C6A7C8")]
	public static bool DarkTonicOculusAudioPackageInstalled()
	{
		return default(bool);
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x1C6A7D0", Offset = "0x1C6A7D0", VA = "0x1C6A7D0")]
	public static void AddOculusAudioSourceToVariation(SoundGroupVariation variation)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x1C6A7D4", Offset = "0x1C6A7D4", VA = "0x1C6A7D4")]
	public static void AddOculusAudioSourceToAllVariations()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x1C6A7D8", Offset = "0x1C6A7D8", VA = "0x1C6A7D8")]
	public static void RemoveOculusAudioSourceFromAllVariations()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x1C6A7DC", Offset = "0x1C6A7DC", VA = "0x1C6A7DC")]
	public static void CopyOculusAudioSource(DynamicGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x1C6A7E0", Offset = "0x1C6A7E0", VA = "0x1C6A7E0")]
	public static void CopyOculusAudioSource(DynamicGroupVariation sourceVariation, SoundGroupVariation destVariation)
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x1C6A7E4", Offset = "0x1C6A7E4", VA = "0x1C6A7E4")]
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
		[Address(RVA = "0x1D24660", Offset = "0x1D24660", VA = "0x1D24660")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x1D24668", Offset = "0x1D24668", VA = "0x1D24668")]
	public static bool DarkTonicResonanceAudioPackageInstalled()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x1D24670", Offset = "0x1D24670", VA = "0x1D24670")]
	public static void AddResonanceAudioSourceToVariation(SoundGroupVariation variation)
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x1D24674", Offset = "0x1D24674", VA = "0x1D24674")]
	public static void AddResonanceAudioSourceToAllVariations()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x1D24678", Offset = "0x1D24678", VA = "0x1D24678")]
	public static void RemoveResonanceAudioSourceFromAllVariations()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x1D2467C", Offset = "0x1D2467C", VA = "0x1D2467C")]
	public static void CopyResonanceAudioSource(DynamicGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x1D24680", Offset = "0x1D24680", VA = "0x1D24680")]
	public static void CopyResonanceAudioSource(DynamicGroupVariation sourceVariation, SoundGroupVariation destVariation)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x1D24684", Offset = "0x1D24684", VA = "0x1D24684")]
	public static void CopyResonanceAudioSource(SoundGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}
}
[Token(Token = "0x200003E")]
public class TransformFollower : MonoBehaviour
{
	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824B64", Offset = "0x824B64")]
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
		[Address(RVA = "0x1D2CAE8", Offset = "0x1D2CAE8", VA = "0x1D2CAE8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000006")]
	public GameObject GameObj
	{
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1D2D754", Offset = "0x1D2D754", VA = "0x1D2D754")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000007")]
	public Transform Trans
	{
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1D2DD3C", Offset = "0x1D2DD3C", VA = "0x1D2DD3C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x1D2CA14", Offset = "0x1D2CA14", VA = "0x1D2CA14")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x1D2CBBC", Offset = "0x1D2CBBC", VA = "0x1D2CBBC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x1D2CDA0", Offset = "0x1D2CDA0", VA = "0x1D2CDA0")]
	public void StartFollowing(Transform transToFollow, string soundType, string variationName, float volume, float trigRadius, bool willFollowSource, bool positionAtClosestColliderPoint, bool useTopCollider, bool useChildColliders, MasterAudio.AmbientSoundExitMode exitMode, float exitFadeTime, MasterAudio.AmbientSoundReEnterMode reEnterMode, float reEnterFadeTime)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x1D2D6D0", Offset = "0x1D2D6D0", VA = "0x1D2D6D0")]
	private void StopFollowing()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x1D2D7F4", Offset = "0x1D2D7F4", VA = "0x1D2D7F4")]
	private void PlaySound()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x1D2DC4C", Offset = "0x1D2DC4C", VA = "0x1D2DC4C")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x1D2D23C", Offset = "0x1D2D23C", VA = "0x1D2D23C")]
	public bool RecalcClosestColliderPosition(bool forceRecalc = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x1D2DDDC", Offset = "0x1D2DDDC", VA = "0x1D2DDDC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x1D2DEF8", Offset = "0x1D2DEF8", VA = "0x1D2DEF8")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x1D2CC28", Offset = "0x1D2CC28", VA = "0x1D2CC28")]
	private void PerformTriggerExit()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x1D2DFF0", Offset = "0x1D2DFF0", VA = "0x1D2DFF0")]
	public TransformFollower()
	{
	}
}
namespace RelationsInspector.Backend.AutoBackend
{
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x82242C", Offset = "0x82242C")]
	public class AutoBackendAttribute : Attribute
	{
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x159CADC", Offset = "0x159CADC", VA = "0x159CADC")]
		public AutoBackendAttribute()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x822440", Offset = "0x822440")]
	public class RelatedAttribute : Attribute
	{
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1D24650", Offset = "0x1D24650", VA = "0x1D24650")]
		public RelatedAttribute()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x822454", Offset = "0x822454")]
	public class RelatingAttribute : Attribute
	{
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1D24658", Offset = "0x1D24658", VA = "0x1D24658")]
		public RelatingAttribute()
		{
		}
	}
}
namespace DarkTonic.MasterAudio
{
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x822468", Offset = "0x822468")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x822468", Offset = "0x822468")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824BAC", Offset = "0x824BAC")]
		public bool FollowCaller;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824BE4", Offset = "0x824BE4")]
		public bool UseClosestColliderPosition;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
		public bool UseTopCollider;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x47")]
		public bool IncludeChildColliders;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824C1C", Offset = "0x824C1C")]
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
			[Address(RVA = "0x15937CC", Offset = "0x15937CC", VA = "0x15937CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000009")]
		public Transform Trans
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x1594004", Offset = "0x1594004", VA = "0x1594004")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1593390", Offset = "0x1593390", VA = "0x1593390")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x159367C", Offset = "0x159367C", VA = "0x159367C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1593BFC", Offset = "0x1593BFC", VA = "0x1593BFC")]
		private void StopTrackers()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1594508", Offset = "0x1594508", VA = "0x1594508")]
		public void CalculateRadius()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x15945FC", Offset = "0x15945FC", VA = "0x15945FC")]
		public AudioSource GetNamedOrFirstAudioSource()
		{
			return null;
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1594A08", Offset = "0x1594A08", VA = "0x1594A08")]
		public List<AudioSource> GetAllVariationAudioSources()
		{
			return null;
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1594C30", Offset = "0x1594C30", VA = "0x1594C30")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1594EA0", Offset = "0x1594EA0", VA = "0x1594EA0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1595110", Offset = "0x1595110", VA = "0x1595110")]
		public void StartTrackers()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1596054", Offset = "0x1596054", VA = "0x1596054")]
		public AmbientSound()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8224B8", Offset = "0x8224B8")]
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
		[Address(RVA = "0x159CB04", Offset = "0x159CB04", VA = "0x159CB04")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x159CD78", Offset = "0x159CD78", VA = "0x159CD78")]
		private void OnPress(bool isDown)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x159D190", Offset = "0x159D190", VA = "0x159D190")]
		private void OnClick()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x159D228", Offset = "0x159D228", VA = "0x159D228")]
		private void OnHover(bool isOver)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x159D474", Offset = "0x159D474", VA = "0x159D474")]
		public ButtonClicker()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8224F0", Offset = "0x8224F0")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x8224F0", Offset = "0x8224F0")]
	public class EventSounds : MonoBehaviour, ICustomEventReceiver
	{
		[Token(Token = "0x2000045")]
		public enum UnityUIVersion
		{
			[Token(Token = "0x4000141")]
			Legacy,
			[Token(Token = "0x4000142")]
			uGUI
		}

		[Token(Token = "0x2000046")]
		public enum EventType
		{
			[Token(Token = "0x4000144")]
			OnStart,
			[Token(Token = "0x4000145")]
			OnVisible,
			[Token(Token = "0x4000146")]
			OnInvisible,
			[Token(Token = "0x4000147")]
			OnCollision,
			[Token(Token = "0x4000148")]
			OnTriggerEnter,
			[Token(Token = "0x4000149")]
			OnTriggerExit,
			[Token(Token = "0x400014A")]
			OnMouseEnter,
			[Token(Token = "0x400014B")]
			OnMouseClick,
			[Token(Token = "0x400014C")]
			OnSpawned,
			[Token(Token = "0x400014D")]
			OnDespawned,
			[Token(Token = "0x400014E")]
			OnEnable,
			[Token(Token = "0x400014F")]
			OnDisable,
			[Token(Token = "0x4000150")]
			OnCollision2D,
			[Token(Token = "0x4000151")]
			OnTriggerEnter2D,
			[Token(Token = "0x4000152")]
			OnTriggerExit2D,
			[Token(Token = "0x4000153")]
			OnParticleCollision,
			[Token(Token = "0x4000154")]
			UserDefinedEvent,
			[Token(Token = "0x4000155")]
			OnCollisionExit,
			[Token(Token = "0x4000156")]
			OnCollisionExit2D,
			[Token(Token = "0x4000157")]
			OnMouseUp,
			[Token(Token = "0x4000158")]
			OnMouseExit,
			[Token(Token = "0x4000159")]
			OnMouseDrag,
			[Token(Token = "0x400015A")]
			NGUIOnClick,
			[Token(Token = "0x400015B")]
			NGUIMouseDown,
			[Token(Token = "0x400015C")]
			NGUIMouseUp,
			[Token(Token = "0x400015D")]
			NGUIMouseEnter,
			[Token(Token = "0x400015E")]
			NGUIMouseExit,
			[Token(Token = "0x400015F")]
			MechanimStateChanged,
			[Token(Token = "0x4000160")]
			UnitySliderChanged,
			[Token(Token = "0x4000161")]
			UnityButtonClicked,
			[Token(Token = "0x4000162")]
			UnityPointerDown,
			[Token(Token = "0x4000163")]
			UnityPointerUp,
			[Token(Token = "0x4000164")]
			UnityPointerEnter,
			[Token(Token = "0x4000165")]
			UnityPointerExit,
			[Token(Token = "0x4000166")]
			UnityDrag,
			[Token(Token = "0x4000167")]
			UnityDrop,
			[Token(Token = "0x4000168")]
			UnityScroll,
			[Token(Token = "0x4000169")]
			UnityUpdateSelected,
			[Token(Token = "0x400016A")]
			UnitySelect,
			[Token(Token = "0x400016B")]
			UnityDeselect,
			[Token(Token = "0x400016C")]
			UnityMove,
			[Token(Token = "0x400016D")]
			UnityInitializePotentialDrag,
			[Token(Token = "0x400016E")]
			UnityBeginDrag,
			[Token(Token = "0x400016F")]
			UnityEndDrag,
			[Token(Token = "0x4000170")]
			UnitySubmit,
			[Token(Token = "0x4000171")]
			UnityCancel,
			[Token(Token = "0x4000172")]
			UnityToggle,
			[Token(Token = "0x4000173")]
			OnTriggerStay,
			[Token(Token = "0x4000174")]
			OnTriggerStay2D,
			[Token(Token = "0x4000175")]
			CodeTriggeredEvent1,
			[Token(Token = "0x4000176")]
			CodeTriggeredEvent2
		}

		[Token(Token = "0x2000047")]
		public enum GlidePitchType
		{
			[Token(Token = "0x4000178")]
			None,
			[Token(Token = "0x4000179")]
			RaisePitch,
			[Token(Token = "0x400017A")]
			LowerPitch
		}

		[Token(Token = "0x2000048")]
		public enum VariationType
		{
			[Token(Token = "0x400017C")]
			PlaySpecific,
			[Token(Token = "0x400017D")]
			PlayRandom
		}

		[Token(Token = "0x2000049")]
		public enum PreviousSoundStopMode
		{
			[Token(Token = "0x400017F")]
			None,
			[Token(Token = "0x4000180")]
			Stop,
			[Token(Token = "0x4000181")]
			FadeOut
		}

		[Token(Token = "0x200004A")]
		public enum RetriggerLimMode
		{
			[Token(Token = "0x4000183")]
			None,
			[Token(Token = "0x4000184")]
			FrameBased,
			[Token(Token = "0x4000185")]
			TimeBased
		}

		[Token(Token = "0x200004B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x822540", Offset = "0x822540")]
		private sealed class <CoUpdate>d__127 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000186")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000187")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000188")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EventSounds <>4__this;

			[Token(Token = "0x1700000C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000134")]
				[Address(RVA = "0x1D2F61C", Offset = "0x1D2F61C", VA = "0x1D2F61C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000136")]
				[Address(RVA = "0x1D2F664", Offset = "0x1D2F664", VA = "0x1D2F664", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000131")]
			[Address(RVA = "0x1D2F450", Offset = "0x1D2F450", VA = "0x1D2F450")]
			[DebuggerHidden]
			public <CoUpdate>d__127(int <>1__state)
			{
			}

			[Token(Token = "0x6000132")]
			[Address(RVA = "0x1D2F47C", Offset = "0x1D2F47C", VA = "0x1D2F47C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000133")]
			[Address(RVA = "0x1D2F480", Offset = "0x1D2F480", VA = "0x1D2F480", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000135")]
			[Address(RVA = "0x1D2F624", Offset = "0x1D2F624", VA = "0x1D2F624", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200004C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x822550", Offset = "0x822550")]
		private sealed class <>c__DisplayClass176_0
		{
			[Token(Token = "0x4000189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string stateName;

			[Token(Token = "0x6000137")]
			[Address(RVA = "0x1D2F424", Offset = "0x1D2F424", VA = "0x1D2F424")]
			public <>c__DisplayClass176_0()
			{
			}

			[Token(Token = "0x6000138")]
			[Address(RVA = "0x1D2F42C", Offset = "0x1D2F42C", VA = "0x1D2F42C")]
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
			[Address(RVA = "0x15A2D5C", Offset = "0x15A2D5C", VA = "0x15A2D5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		private bool IsSetToLegacyUI
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x15A4C80", Offset = "0x15A4C80", VA = "0x15A4C80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x15A2C34", Offset = "0x15A2C34", VA = "0x15A2C34")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x15A2FD8", Offset = "0x15A2FD8", VA = "0x15A2FD8", Slot = "10")]
		protected virtual void SpawnedOrAwake()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x15A3138", Offset = "0x15A3138", VA = "0x15A3138")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x825780", Offset = "0x825780")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x15A31B0", Offset = "0x15A31B0", VA = "0x15A31B0")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x15A3888", Offset = "0x15A3888", VA = "0x15A3888")]
		private void OnBecameVisible()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x15A38B0", Offset = "0x15A38B0", VA = "0x15A38B0")]
		private void OnBecameInvisible()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x15A38CC", Offset = "0x15A38CC", VA = "0x15A38CC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x15A3B88", Offset = "0x15A3B88", VA = "0x15A3B88")]
		private void RestorePersistentSliders()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x15A3F14", Offset = "0x15A3F14", VA = "0x15A3F14")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x15A4358", Offset = "0x15A4358", VA = "0x15A4358")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x15A4474", Offset = "0x15A4474", VA = "0x15A4474")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x15A4590", Offset = "0x15A4590", VA = "0x15A4590")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x15A46D8", Offset = "0x15A46D8", VA = "0x15A46D8")]
		private void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x15A47D4", Offset = "0x15A47D4", VA = "0x15A47D4")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x15A48F8", Offset = "0x15A48F8", VA = "0x15A48F8")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x15A4A14", Offset = "0x15A4A14", VA = "0x15A4A14")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x15A4A34", Offset = "0x15A4A34", VA = "0x15A4A34")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x15A4A54", Offset = "0x15A4A54", VA = "0x15A4A54")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x15A4A74", Offset = "0x15A4A74", VA = "0x15A4A74")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x15A4A94", Offset = "0x15A4A94", VA = "0x15A4A94")]
		private void OnDrag(Vector2 delta)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x15A4A98", Offset = "0x15A4A98", VA = "0x15A4A98")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x15A4AB8", Offset = "0x15A4AB8", VA = "0x15A4AB8")]
		private void OnDrop(GameObject go)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x15A4ABC", Offset = "0x15A4ABC", VA = "0x15A4ABC")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x15A4ADC", Offset = "0x15A4ADC", VA = "0x15A4ADC")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x15A4AFC", Offset = "0x15A4AFC", VA = "0x15A4AFC")]
		public void OnUpdateSelected(BaseEventData data)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x15A4B1C", Offset = "0x15A4B1C", VA = "0x15A4B1C")]
		private void OnSelect(bool isSelected)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x15A4B20", Offset = "0x15A4B20", VA = "0x15A4B20")]
		public void OnSelect(BaseEventData data)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x15A4B40", Offset = "0x15A4B40", VA = "0x15A4B40")]
		public void OnDeselect(BaseEventData data)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x15A4B60", Offset = "0x15A4B60", VA = "0x15A4B60")]
		public void OnMove(AxisEventData data)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x15A4B80", Offset = "0x15A4B80", VA = "0x15A4B80")]
		public void OnInitializePotentialDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x15A4BA0", Offset = "0x15A4BA0", VA = "0x15A4BA0")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x15A4BC0", Offset = "0x15A4BC0", VA = "0x15A4BC0")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x15A4BE0", Offset = "0x15A4BE0", VA = "0x15A4BE0")]
		public void OnSubmit(BaseEventData data)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x15A4C00", Offset = "0x15A4C00", VA = "0x15A4C00")]
		public void OnCancel(BaseEventData data)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x15A4C20", Offset = "0x15A4C20", VA = "0x15A4C20")]
		private void SliderChanged(float newValue)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x15A4C50", Offset = "0x15A4C50", VA = "0x15A4C50")]
		private void ToggleChanged(bool newValue)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x15A4C68", Offset = "0x15A4C68", VA = "0x15A4C68")]
		private void ButtonClicked()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x15A4C90", Offset = "0x15A4C90", VA = "0x15A4C90")]
		private void OnPress(bool isDown)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x15A4CC8", Offset = "0x15A4CC8", VA = "0x15A4CC8")]
		private void OnClick()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x15A4CE8", Offset = "0x15A4CE8", VA = "0x15A4CE8")]
		private void OnHover(bool isOver)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x15A4D20", Offset = "0x15A4D20", VA = "0x15A4D20")]
		private void OnSpawned()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x15A4D70", Offset = "0x15A4D70", VA = "0x15A4D70")]
		private void OnDespawned()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x15A4D90", Offset = "0x15A4D90", VA = "0x15A4D90")]
		public void ActivateCodeTriggeredEvent1()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x15A4DA8", Offset = "0x15A4DA8", VA = "0x15A4DA8")]
		public void ActivateCodeTriggeredEvent2()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x15A4DC0", Offset = "0x15A4DC0", VA = "0x15A4DC0")]
		public void CalculateRadius(AudioEvent anEvent)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x15A4E68", Offset = "0x15A4E68", VA = "0x15A4E68")]
		public AudioSource GetNamedOrFirstAudioSource(AudioEvent anEvent)
		{
			return null;
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x15A504C", Offset = "0x15A504C", VA = "0x15A504C")]
		public List<AudioSource> GetAllVariationAudioSources(AudioEvent anEvent)
		{
			return null;
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x15A5278", Offset = "0x15A5278", VA = "0x15A5278")]
		public AudioEventGroup GetMechanimAudioEventGroup(string stateName)
		{
			return null;
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x15A3628", Offset = "0x15A3628", VA = "0x15A3628")]
		public bool PlaySounds(AudioEventGroup eventGrp, EventType eType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x15A7950", Offset = "0x15A7950", VA = "0x15A7950")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x15A7B38", Offset = "0x15A7B38", VA = "0x15A7B38")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x15A5374", Offset = "0x15A5374", VA = "0x15A5374")]
		private static bool CheckForRetriggerLimit(AudioEventGroup grp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x15A54E8", Offset = "0x15A54E8", VA = "0x15A54E8")]
		private void PerformSingleAction(AudioEventGroup grp, AudioEvent aEvent, EventType eType)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x15B07E0", Offset = "0x15B07E0", VA = "0x15B07E0")]
		private void LogIfCustomEventMissing(AudioEventGroup eventGroup)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x15A31F0", Offset = "0x15A31F0", VA = "0x15A31F0", Slot = "4")]
		public void CheckForIllegalCustomEvents()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x15B0C90", Offset = "0x15B0C90", VA = "0x15B0C90", Slot = "5")]
		public void ReceiveEvent(string customEventName, Vector3 originPoint)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x15B0D6C", Offset = "0x15B0D6C", VA = "0x15B0D6C", Slot = "6")]
		public bool SubscribesToEvent(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x15A3E7C", Offset = "0x15A3E7C", VA = "0x15A3E7C", Slot = "7")]
		public void RegisterReceiver()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x15A42C8", Offset = "0x15A42C8", VA = "0x15A42C8", Slot = "8")]
		public void UnregisterReceiver()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x15B1784", Offset = "0x15B1784", VA = "0x15B1784", Slot = "9")]
		public IList<AudioEventGroup> GetAllEvents()
		{
			return null;
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x15A2D6C", Offset = "0x15A2D6C", VA = "0x15A2D6C")]
		private void AddUGUIComponents()
		{
		}

		[Token(Token = "0x600012E")]
		private void AddUGUIHandler<T>(bool useSound) where T : EventSoundsUGUIHandler
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x15B17D8", Offset = "0x15B17D8", VA = "0x15B17D8")]
		public EventSounds()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class EventSoundsUGUIHandler : MonoBehaviour
	{
		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x824C54", Offset = "0x824C54")]
		private EventSounds <eventSounds>k__BackingField;

		[Token(Token = "0x1700000E")]
		public EventSounds eventSounds
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x15B2780", Offset = "0x15B2780", VA = "0x15B2780")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x825830", Offset = "0x825830")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x15B2788", Offset = "0x15B2788", VA = "0x15B2788")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x825840", Offset = "0x825840")]
			set
			{
			}
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x15B1E10", Offset = "0x15B1E10", VA = "0x15B1E10")]
		public EventSoundsUGUIHandler()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class EventSoundsPointerEnterHandler : EventSoundsUGUIHandler, IPointerEnterHandler, IEventSystemHandler
	{
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x15B2378", Offset = "0x15B2378", VA = "0x15B2378", Slot = "4")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x15B241C", Offset = "0x15B241C", VA = "0x15B241C")]
		public EventSoundsPointerEnterHandler()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class EventSoundsPointerExitHandler : EventSoundsUGUIHandler, IPointerExitHandler, IEventSystemHandler
	{
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x15B2424", Offset = "0x15B2424", VA = "0x15B2424", Slot = "4")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x15B24C8", Offset = "0x15B24C8", VA = "0x15B24C8")]
		public EventSoundsPointerExitHandler()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class EventSoundsPointerDownHandler : EventSoundsUGUIHandler, IPointerDownHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x15B22CC", Offset = "0x15B22CC", VA = "0x15B22CC", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x15B2370", Offset = "0x15B2370", VA = "0x15B2370")]
		public EventSoundsPointerDownHandler()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class EventSoundsPointerUpHandler : EventSoundsUGUIHandler, IPointerUpHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x15B24D0", Offset = "0x15B24D0", VA = "0x15B24D0", Slot = "4")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x15B2574", Offset = "0x15B2574", VA = "0x15B2574")]
		public EventSoundsPointerUpHandler()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class EventSoundsDragHandler : EventSoundsUGUIHandler, IDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x15B1F70", Offset = "0x15B1F70", VA = "0x15B1F70", Slot = "4")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x15B2014", Offset = "0x15B2014", VA = "0x15B2014")]
		public EventSoundsDragHandler()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class EventSoundsDropHandler : EventSoundsUGUIHandler, IDropHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x15B201C", Offset = "0x15B201C", VA = "0x15B201C", Slot = "4")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x15B20C0", Offset = "0x15B20C0", VA = "0x15B20C0")]
		public EventSoundsDropHandler()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class EventSoundsScrollHandler : EventSoundsUGUIHandler, IScrollHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x15B257C", Offset = "0x15B257C", VA = "0x15B257C", Slot = "4")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x15B2620", Offset = "0x15B2620", VA = "0x15B2620")]
		public EventSoundsScrollHandler()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class EventSoundsUpdateSelectedHandler : EventSoundsUGUIHandler, IUpdateSelectedHandler, IEventSystemHandler
	{
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x15B2790", Offset = "0x15B2790", VA = "0x15B2790", Slot = "4")]
		public void OnUpdateSelected(BaseEventData data)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x15B2834", Offset = "0x15B2834", VA = "0x15B2834")]
		public EventSoundsUpdateSelectedHandler()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class EventSoundsSelectHandler : EventSoundsUGUIHandler, ISelectHandler, IEventSystemHandler
	{
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x15B2628", Offset = "0x15B2628", VA = "0x15B2628", Slot = "4")]
		public void OnSelect(BaseEventData data)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x15B26CC", Offset = "0x15B26CC", VA = "0x15B26CC")]
		public EventSoundsSelectHandler()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class EventSoundsDeselectHandler : EventSoundsUGUIHandler, IDeselectHandler, IEventSystemHandler
	{
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x15B1EC4", Offset = "0x15B1EC4", VA = "0x15B1EC4", Slot = "4")]
		public void OnDeselect(BaseEventData data)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x15B1F68", Offset = "0x15B1F68", VA = "0x15B1F68")]
		public EventSoundsDeselectHandler()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public class EventSoundsMoveHandler : EventSoundsUGUIHandler, IMoveHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x15B2220", Offset = "0x15B2220", VA = "0x15B2220", Slot = "4")]
		public void OnMove(AxisEventData data)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x15B22C4", Offset = "0x15B22C4", VA = "0x15B22C4")]
		public EventSoundsMoveHandler()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public class EventSoundsInitializePotentialDragHandler : EventSoundsUGUIHandler, IInitializePotentialDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x15B2174", Offset = "0x15B2174", VA = "0x15B2174", Slot = "4")]
		public void OnInitializePotentialDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x15B2218", Offset = "0x15B2218", VA = "0x15B2218")]
		public EventSoundsInitializePotentialDragHandler()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class EventSoundsBeginDragHandler : EventSoundsUGUIHandler, IBeginDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x15B1D64", Offset = "0x15B1D64", VA = "0x15B1D64", Slot = "4")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x15B1E08", Offset = "0x15B1E08", VA = "0x15B1E08")]
		public EventSoundsBeginDragHandler()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public class EventSoundsEndDragHandler : EventSoundsUGUIHandler, IEndDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x15B20C8", Offset = "0x15B20C8", VA = "0x15B20C8", Slot = "4")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x15B216C", Offset = "0x15B216C", VA = "0x15B216C")]
		public EventSoundsEndDragHandler()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class EventSoundsSubmitHandler : EventSoundsUGUIHandler, ISubmitHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x15B26D4", Offset = "0x15B26D4", VA = "0x15B26D4", Slot = "4")]
		public void OnSubmit(BaseEventData data)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x15B2778", Offset = "0x15B2778", VA = "0x15B2778")]
		public EventSoundsSubmitHandler()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class EventSoundsCancelHandler : EventSoundsUGUIHandler, ICancelHandler, IEventSystemHandler
	{
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x15B1E18", Offset = "0x15B1E18", VA = "0x15B1E18", Slot = "4")]
		public void OnCancel(BaseEventData data)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x15B1EBC", Offset = "0x15B1EBC", VA = "0x15B1EBC")]
		public EventSoundsCancelHandler()
		{
		}
	}
	[Token(Token = "0x200005E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x822560", Offset = "0x822560")]
	public class FootstepSounds : MonoBehaviour
	{
		[Token(Token = "0x200005F")]
		public enum FootstepTriggerMode
		{
			[Token(Token = "0x4000195")]
			None,
			[Token(Token = "0x4000196")]
			OnCollision,
			[Token(Token = "0x4000197")]
			OnTriggerEnter,
			[Token(Token = "0x4000198")]
			OnCollision2D,
			[Token(Token = "0x4000199")]
			OnTriggerEnter2D
		}

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.SoundSpawnLocationMode soundSpawnMode;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public FootstepTriggerMode footstepEvent;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<FootstepGroup> footstepGroups;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EventSounds.RetriggerLimMode retriggerLimitMode;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int limitPerXFrm;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float limitPerXSec;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int triggeredLastFrame;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float triggeredLastTime;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform _trans;

		[Token(Token = "0x1700000F")]
		private Transform Trans
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x15B5020", Offset = "0x15B5020", VA = "0x15B5020")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x15B4BC4", Offset = "0x15B4BC4", VA = "0x15B4BC4")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x15B4F40", Offset = "0x15B4F40", VA = "0x15B4F40")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x15B4F90", Offset = "0x15B4F90", VA = "0x15B4F90")]
		private bool CheckForRetriggerLimit()
		{
			return default(bool);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x15B4C14", Offset = "0x15B4C14", VA = "0x15B4C14")]
		private void PlaySoundsIfMatch(GameObject go)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x15B50C0", Offset = "0x15B50C0", VA = "0x15B50C0")]
		public FootstepSounds()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class MechanimStateCustomEvents : StateMachineBehaviour
	{
		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x824C64", Offset = "0x824C64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824C64", Offset = "0x824C64")]
		public bool RetriggerWhenStateLoops;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x824CC4", Offset = "0x824CC4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824CC4", Offset = "0x824CC4")]
		public bool fireEnterEvent;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[MasterCustomEvent]
		public string enterCustomEvent;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x824D34", Offset = "0x824D34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824D34", Offset = "0x824D34")]
		public bool fireExitEvent;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[MasterCustomEvent]
		public string exitCustomEvent;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x824DA4", Offset = "0x824DA4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824DA4", Offset = "0x824DA4")]
		public bool fireAnimTimeEvent;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824E04", Offset = "0x824E04")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x824E04", Offset = "0x824E04")]
		public float whenToFireEvent;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[MasterCustomEvent]
		public string timedCustomEvent;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824E68", Offset = "0x824E68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x824E68", Offset = "0x824E68")]
		public bool fireMultiAnimTimeEvent;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x824EC8", Offset = "0x824EC8")]
		public int numOfMultiEventsToFire;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824EE0", Offset = "0x824EE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x824EE0", Offset = "0x824EE0")]
		public float whenToFireMultiEvent1;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x824F34", Offset = "0x824F34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824F34", Offset = "0x824F34")]
		public float whenToFireMultiEvent2;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824F88", Offset = "0x824F88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x824F88", Offset = "0x824F88")]
		public float whenToFireMultiEvent3;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x824FDC", Offset = "0x824FDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x824FDC", Offset = "0x824FDC")]
		public float whenToFireMultiEvent4;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[MasterCustomEvent]
		public string MultiTimedEvent;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _playMultiEvent1;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool _playMultiEvent2;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool _playMultiEvent3;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		private bool _playMultiEvent4;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool _fireTimedEvent;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _actorTrans;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _lastRepetition;

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1C68A60", Offset = "0x1C68A60", VA = "0x1C68A60", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1C68BF8", Offset = "0x1C68BF8", VA = "0x1C68BF8", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1C68F08", Offset = "0x1C68F08", VA = "0x1C68F08", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1C68B50", Offset = "0x1C68B50", VA = "0x1C68B50")]
		private Transform ActorTrans(Animator anim)
		{
			return null;
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1C68FE8", Offset = "0x1C68FE8", VA = "0x1C68FE8")]
		public MechanimStateCustomEvents()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class MechanimStateSounds : StateMachineBehaviour
	{
		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x825040", Offset = "0x825040")]
		public bool SoundFollowsObject;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x825078", Offset = "0x825078")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x825078", Offset = "0x825078")]
		public bool RetriggerWhenStateLoops;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8250D8", Offset = "0x8250D8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8250D8", Offset = "0x8250D8")]
		public bool playEnterSound;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool stopEnterSoundOnExit;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SoundGroup]
		public string enterSoundGroup;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x825148", Offset = "0x825148")]
		public string enterVariationName;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool wasEnterSoundPlayed;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x825180", Offset = "0x825180")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x825180", Offset = "0x825180")]
		public bool playExitSound;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SoundGroup]
		public string exitSoundGroup;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8251F0", Offset = "0x8251F0")]
		public string exitVariationName;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x825228", Offset = "0x825228")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x825228", Offset = "0x825228")]
		public bool playAnimTimeSound;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool stopAnimTimeSoundOnExit;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x825288", Offset = "0x825288")]
		public bool useStopTime;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8252C0", Offset = "0x8252C0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8252C0", Offset = "0x8252C0")]
		public float whenToStartSound;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x825314", Offset = "0x825314")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x825314", Offset = "0x825314")]
		public float whenToStopSound;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SoundGroup]
		public string TimedSoundGroup;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x825378", Offset = "0x825378")]
		public string timedVariationName;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool playSoundStart;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool playSoundStop;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8253B0", Offset = "0x8253B0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8253B0", Offset = "0x8253B0")]
		public bool playMultiAnimTimeSounds;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		public bool StopMultiAnimTimeSoundsOnExit;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x825410", Offset = "0x825410")]
		public int numOfMultiSoundsToPlay;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x825428", Offset = "0x825428")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x825428", Offset = "0x825428")]
		public float whenToStartMultiSound1;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x82547C", Offset = "0x82547C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x82547C", Offset = "0x82547C")]
		public float whenToStartMultiSound2;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8254D0", Offset = "0x8254D0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8254D0", Offset = "0x8254D0")]
		public float whenToStartMultiSound3;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x825524", Offset = "0x825524")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x825524", Offset = "0x825524")]
		public float whenToStartMultiSound4;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SoundGroup]
		public string MultiSoundsTimedGroup;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x825588", Offset = "0x825588")]
		public string multiTimedVariationName;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool playMultiSound1;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		private bool playMultiSound2;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
		private bool playMultiSound3;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x93")]
		private bool playMultiSound4;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Transform _actorTrans;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int _lastRepetition;

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1C6908C", Offset = "0x1C6908C", VA = "0x1C6908C", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1C69314", Offset = "0x1C69314", VA = "0x1C69314", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x1C69AB4", Offset = "0x1C69AB4", VA = "0x1C69AB4", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1C69214", Offset = "0x1C69214", VA = "0x1C69214")]
		private Transform ActorTrans(Animator anim)
		{
			return null;
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x1C692BC", Offset = "0x1C692BC", VA = "0x1C692BC")]
		private static string GetVariationName(string varName)
		{
			return null;
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x1C69CFC", Offset = "0x1C69CFC", VA = "0x1C69CFC")]
		public MechanimStateSounds()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[SerializeField]
	public class PlaySoundResult
	{
		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8255C0", Offset = "0x8255C0")]
		private bool <SoundPlayed>k__BackingField;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8255D0", Offset = "0x8255D0")]
		private bool <SoundScheduled>k__BackingField;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8255E0", Offset = "0x8255E0")]
		private SoundGroupVariation <ActingVariation>k__BackingField;

		[Token(Token = "0x17000010")]
		public bool SoundPlayed
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x1C6B88C", Offset = "0x1C6B88C", VA = "0x1C6B88C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x825850", Offset = "0x825850")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x1C6B894", Offset = "0x1C6B894", VA = "0x1C6B894")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x825860", Offset = "0x825860")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public bool SoundScheduled
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x1C6B8A0", Offset = "0x1C6B8A0", VA = "0x1C6B8A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x825870", Offset = "0x825870")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x1C6B8A8", Offset = "0x1C6B8A8", VA = "0x1C6B8A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x825880", Offset = "0x825880")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public SoundGroupVariation ActingVariation
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x1C6B8B4", Offset = "0x1C6B8B4", VA = "0x1C6B8B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x825890", Offset = "0x825890")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x1C6B8BC", Offset = "0x1C6B8BC", VA = "0x1C6B8BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8258A0", Offset = "0x8258A0")]
			set
			{
			}
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1C6B858", Offset = "0x1C6B858", VA = "0x1C6B858")]
		public PlaySoundResult()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000063")]
	public class AmbientSoundToTriggerInfo
	{
		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int frameToTrigger;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AmbientSound ambient;

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x15960FC", Offset = "0x15960FC", VA = "0x15960FC")]
		public AmbientSoundToTriggerInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000064")]
	public class AudioEvent
	{
		[Token(Token = "0x2000065")]
		public enum TargetVolumeMode
		{
			[Token(Token = "0x4000200")]
			UseSliderValue,
			[Token(Token = "0x4000201")]
			UseSpecificValue
		}

		[Serializable]
		[Token(Token = "0x2000066")]
		public class MA_SnapshotInfo
		{
			[Token(Token = "0x4000202")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixerSnapshot snapshot;

			[Token(Token = "0x4000203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float weight;

			[Token(Token = "0x6000177")]
			[Address(RVA = "0x1D2E304", Offset = "0x1D2E304", VA = "0x1D2E304")]
			public MA_SnapshotInfo(AudioMixerSnapshot snap, float wt)
			{
			}
		}

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string actionName;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isExpanded;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string soundType;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool allPlaylistControllersForGroupCmd;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool allSoundTypesForGroupCmd;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool allSoundTypesForBusCmd;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float volume;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useFixedPitch;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float pitch;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public EventSounds.GlidePitchType glidePitchType;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float targetGlidePitch;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pitchGlideTime;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float delaySound;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MasterAudio.EventSoundFunctionType currentSoundFunctionType;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public MasterAudio.PlaylistCommand currentPlaylistCommand;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MasterAudio.SoundGroupCommand currentSoundGroupCommand;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public MasterAudio.BusCommand currentBusCommand;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MasterAudio.CustomEventCommand currentCustomEventCommand;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public MasterAudio.GlobalCommand currentGlobalCommand;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public MasterAudio.UnityMixerCommand currentMixerCommand;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioMixerSnapshot snapshotToTransitionTo;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float snapshotTransitionTime;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<MA_SnapshotInfo> snapshotsToBlend;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public MasterAudio.PersistentSettingsCommand currentPersistentSettingsCommand;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string busName;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string playlistName;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string playlistControllerName;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool startPlaylist;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float fadeVolume;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float fadeTime;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float minAge;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool stopAfterFade;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool restoreVolumeAfterFade;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetVolumeMode targetVolMode;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public string clipName;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public string variationName;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float colliderMaxDistance;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public bool showSphereGizmo;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public string theCustomEventName;

		[Token(Token = "0x17000013")]
		public bool IsFadeCommand
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x15974D0", Offset = "0x15974D0", VA = "0x15974D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x1597538", Offset = "0x1597538", VA = "0x1597538")]
		public AudioEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000067")]
	public class AudioEventGroup
	{
		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isExpanded;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool allPlayersShouldHear;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool useLayerFilter;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		public bool useTagFilter;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> matchingLayers;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> matchingTags;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool customSoundActive;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool isCustomEvent;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string customEventName;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool mechanimEventActive;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool isMechanimStateCheckEvent;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mechanimStateName;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool mechEventPlayedForState;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<AudioEvent> SoundEvents;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public EventSounds.PreviousSoundStopMode mouseDragStopMode;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float mouseDragFadeOutTime;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public EventSounds.RetriggerLimMode retriggerLimitMode;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int limitPerXFrm;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float limitPerXSec;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int triggeredLastFrame;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float triggeredLastTime;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float triggerStayForTime;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool doesTriggerStayRepeat;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float sliderValue;

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x1597744", Offset = "0x1597744", VA = "0x1597744")]
		public AudioEventGroup()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class AudioScriptOrder : Attribute
	{
		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Order;

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x1599AF8", Offset = "0x1599AF8", VA = "0x1599AF8")]
		public AudioScriptOrder(int order)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000069")]
	public class BusFadeInfo
	{
		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string NameOfBus;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GroupBus ActingBus;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartVolume;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TargetVolume;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float StartTime;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float CompletionTime;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool IsActive;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool WillStopGroupAfterFade;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool WillResetVolumeAfterFade;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action completionAction;

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x159CAE4", Offset = "0x159CAE4", VA = "0x159CAE4")]
		public BusFadeInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006A")]
	public class BusPitchGlideInfo
	{
		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string NameOfBus;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float CompletionTime;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool IsActive;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<SoundGroupVariation> GlidingVariations;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action completionAction;

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x159CAF4", Offset = "0x159CAF4", VA = "0x159CAF4")]
		public BusPitchGlideInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006B")]
	public class CustomEvent
	{
		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string EventName;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string ProspectiveName;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool IsEditing;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool eventExpanded;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public MasterAudio.CustomEventReceiveMode eventReceiveMode;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float distanceThreshold;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public MasterAudio.EventReceiveFilter eventRcvFilterMode;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int filterModeQty;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool isTemporary;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int frameLastFired;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string categoryName;

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x159D62C", Offset = "0x159D62C", VA = "0x159D62C")]
		public CustomEvent(string eventName)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006C")]
	public class CustomEventCategory
	{
		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string CatName;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsExpanded;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool IsEditing;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool IsTemporary;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ProspectiveName;

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x159D6D0", Offset = "0x159D6D0", VA = "0x159D6D0")]
		public CustomEventCategory()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006D")]
	public class CustomEventToFireInfo
	{
		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string eventName;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform eventOrigin;

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x159D744", Offset = "0x159D744", VA = "0x159D744")]
		public CustomEventToFireInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006E")]
	public class DuckGroupInfo
	{
		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string soundType;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float riseVolStart;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float unduckTime;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float duckedVolumeCut;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isTemporary;

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x159D9E0", Offset = "0x159D9E0", VA = "0x159D9E0")]
		public DuckGroupInfo()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class DynamicGroupVariation : MonoBehaviour
	{
		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8255F0", Offset = "0x8255F0")]
		public int probabilityToPlay;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x825608", Offset = "0x825608")]
		public int importance;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isUninterruptible;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool useLocalization;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool useRandomPitch;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public SoundGroupVariation.RandomPitchMode randomPitchMode;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float randomPitchMin;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float randomPitchMax;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useRandomVolume;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public SoundGroupVariation.RandomVolumeMode randomVolumeMode;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float randomVolumeMin;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float randomVolumeMax;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int weight;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string resourceFileName;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool isExpanded;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool isChecked;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		public bool useFades;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float fadeInTime;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float fadeOutTime;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool useCustomLooping;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int minCustomLoops;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxCustomLoops;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useIntroSilence;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float introSilenceMin;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float introSilenceMax;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool useRandomStartTime;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float randomStartMinPercent;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float randomStartMaxPercent;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float randomEndPercent;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AudioDistortionFilter _distFilter;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AudioEchoFilter _echoFilter;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AudioHighPassFilter _hpFilter;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AudioLowPassFilter _lpFilter;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private AudioReverbFilter _reverbFilter;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AudioChorusFilter _chorusFilter;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private DynamicSoundGroup _parentGroupScript;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Transform _trans;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private AudioSource _aud;

		[Token(Token = "0x17000014")]
		public AudioDistortionFilter DistortionFilter
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x159DA50", Offset = "0x159DA50", VA = "0x159DA50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public AudioReverbFilter ReverbFilter
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x159DB04", Offset = "0x159DB04", VA = "0x159DB04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public AudioChorusFilter ChorusFilter
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x159DBB8", Offset = "0x159DBB8", VA = "0x159DBB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public AudioEchoFilter EchoFilter
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x159DC6C", Offset = "0x159DC6C", VA = "0x159DC6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		public AudioLowPassFilter LowPassFilter
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x159DD20", Offset = "0x159DD20", VA = "0x159DD20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public AudioHighPassFilter HighPassFilter
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x159DDD4", Offset = "0x159DDD4", VA = "0x159DDD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public DynamicSoundGroup ParentGroup
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x159DE88", Offset = "0x159DE88", VA = "0x159DE88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		public Transform Trans
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x159E010", Offset = "0x159E010", VA = "0x159E010")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public bool HasActiveFXFilter
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x159E0B0", Offset = "0x159E0B0", VA = "0x159E0B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001D")]
		public AudioSource VarAudio
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x159E304", Offset = "0x159E304", VA = "0x159E304")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x159E3B8", Offset = "0x159E3B8", VA = "0x159E3B8")]
		public DynamicGroupVariation()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class DynamicSoundGroup : MonoBehaviour
	{
		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject variationTemplate;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool alwaysHighestPriority;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float groupMasterVolume;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int retriggerPercentage;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public MasterAudioGroup.VariationSequence curVariationSequence;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useNoRepeatRefill;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool useInactivePeriodPoolRefill;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float inactivePeriodSeconds;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MasterAudioGroup.VariationMode curVariationMode;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float chainLoopDelayMin;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float chainLoopDelayMax;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MasterAudioGroup.ChainedLoopLoopMode chainLoopMode;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int chainLoopNumLoops;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool useDialogFadeOut;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float dialogFadeOutTime;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string comments;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool logSound;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool soundPlayedEventActive;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string soundPlayedCustomEvent;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int busIndex;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x825620", Offset = "0x825620")]
		public int importance;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool isUninterruptible;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float spatialBlend;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public MasterAudio.DefaultGroupPlayType groupPlayType;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string busName;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool isExistingBus;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		public bool isCopiedFromDGSC;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public MasterAudioGroup.LimitMode limitMode;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int limitPerXFrames;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float minimumTimeBetween;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool limitPolyphony;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public int voiceLimitCount;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public MasterAudioGroup.TargetDespawnedBehavior targetDespawnedBehavior;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float despawnFadeTime;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool isUsingOcclusion;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool willOcclusionOverrideRaycastOffset;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public bool willOcclusionOverrideFrequencies;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public bool copySettingsExpanded;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC5")]
		public bool expandLinkedGroups;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public List<string> childSoundGroups;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public List<string> endLinkedGroups;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public MasterAudio.LinkedGroupSelectionType linkedStartGroupSelectionType;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public MasterAudio.LinkedGroupSelectionType linkedStopGroupSelectionType;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public List<DynamicGroupVariation> groupVariations;

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x159E3F4", Offset = "0x159E3F4", VA = "0x159E3F4")]
		public DynamicSoundGroup()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000071")]
	public class FootstepGroup
	{
		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isExpanded;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool useLayerFilter;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool useTagFilter;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> matchingLayers;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> matchingTags;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string soundType;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string variationName;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float volume;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useFixedPitch;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float pitch;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float delaySound;

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x15B4A20", Offset = "0x15B4A20", VA = "0x15B4A20")]
		public FootstepGroup()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000072")]
	public class GroupBus
	{
		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string busName;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float volume;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool isSoloed;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool isMuted;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int voiceLimit;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isExisting;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isTemporary;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool isUsingOcclusion;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MasterAudio.BusVoiceLimitExceededMode busVoiceLimitExceededMode;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color busColor;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioMixerGroup mixerChannel;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool forceTo2D;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly List<int> _activeAudioSourcesIds;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float _originalVolume;

		[Token(Token = "0x1700001E")]
		public int ActiveVoices
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x15B5260", Offset = "0x15B5260", VA = "0x15B5260")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001F")]
		public bool BusVoiceLimitReached
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x15B52AC", Offset = "0x15B52AC", VA = "0x15B52AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		public float OriginalVolume
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x15B5314", Offset = "0x15B5314", VA = "0x15B5314")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x15B531C", Offset = "0x15B531C", VA = "0x15B531C")]
			set
			{
			}
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x15B515C", Offset = "0x15B515C", VA = "0x15B515C")]
		public void AddActiveAudioSourceId(int id)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x15B51FC", Offset = "0x15B51FC", VA = "0x15B51FC")]
		public void RemoveActiveAudioSourceId(int id)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x15B5324", Offset = "0x15B5324", VA = "0x15B5324")]
		public GroupBus()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000073")]
	public class GroupFadeInfo
	{
		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MasterAudioGroup ActingGroup;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string NameOfGroup;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartVolume;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TargetVolume;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float StartTime;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float CompletionTime;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool IsActive;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool WillStopGroupAfterFade;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool WillResetVolumeAfterFade;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action completionAction;

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x15B53D8", Offset = "0x15B53D8", VA = "0x15B53D8")]
		public GroupFadeInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000074")]
	public class GroupPitchGlideInfo
	{
		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MasterAudioGroup ActingGroup;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string NameOfGroup;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CompletionTime;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool IsActive;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<SoundGroupVariation> GlidingVariations;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action completionAction;

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x15B53E8", Offset = "0x15B53E8", VA = "0x15B53E8")]
		public GroupPitchGlideInfo()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public interface ICustomEventReceiver
	{
		[Token(Token = "0x6000196")]
		void CheckForIllegalCustomEvents();

		[Token(Token = "0x6000197")]
		void ReceiveEvent(string customEventName, Vector3 originPoint);

		[Token(Token = "0x6000198")]
		bool SubscribesToEvent(string customEventName);

		[Token(Token = "0x6000199")]
		void RegisterReceiver();

		[Token(Token = "0x600019A")]
		void UnregisterReceiver();

		[Token(Token = "0x600019B")]
		IList<AudioEventGroup> GetAllEvents();
	}
	[Token(Token = "0x2000076")]
	public class MasterAudioGroup : MonoBehaviour
	{
		[Token(Token = "0x2000077")]
		public enum TargetDespawnedBehavior
		{
			[Token(Token = "0x4000303")]
			None,
			[Token(Token = "0x4000304")]
			Stop,
			[Token(Token = "0x4000305")]
			FadeOut
		}

		[Token(Token = "0x2000078")]
		public enum VariationSequence
		{
			[Token(Token = "0x4000307")]
			Randomized,
			[Token(Token = "0x4000308")]
			TopToBottom
		}

		[Token(Token = "0x2000079")]
		public enum VariationMode
		{
			[Token(Token = "0x400030A")]
			Normal,
			[Token(Token = "0x400030B")]
			LoopedChain,
			[Token(Token = "0x400030C")]
			Dialog
		}

		[Token(Token = "0x200007A")]
		public enum ChainedLoopLoopMode
		{
			[Token(Token = "0x400030E")]
			Endless,
			[Token(Token = "0x400030F")]
			NumberOfLoops
		}

		[Token(Token = "0x200007B")]
		public enum LimitMode
		{
			[Token(Token = "0x4000311")]
			None,
			[Token(Token = "0x4000312")]
			FrameBased,
			[Token(Token = "0x4000313")]
			TimeBased
		}

		[Token(Token = "0x40002C5")]
		public const float UseCurveSpatialBlend = -99f;

		[Token(Token = "0x40002C6")]
		public const string NoBus = "[NO BUS]";

		[Token(Token = "0x40002C7")]
		public const int MinNoRepeatVariations = 3;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int busIndex;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float spatialBlend;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public MasterAudio.DefaultGroupPlayType groupPlayType;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isSelected;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool isExpanded;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float groupMasterVolume;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int retriggerPercentage;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public VariationMode curVariationMode;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool alwaysHighestPriority;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x825638", Offset = "0x825638")]
		public int importance;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool isUninterruptible;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float chainLoopDelayMin;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float chainLoopDelayMax;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public ChainedLoopLoopMode chainLoopMode;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int chainLoopNumLoops;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool useDialogFadeOut;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float dialogFadeOutTime;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public VariationSequence curVariationSequence;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool useNoRepeatRefill;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool useInactivePeriodPoolRefill;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float inactivePeriodSeconds;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<SoundGroupVariation> groupVariations;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public string comments;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool logSound;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		public bool copySettingsExpanded;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
		public bool expandLinkedGroups;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<string> childSoundGroups;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<string> endLinkedGroups;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public MasterAudio.LinkedGroupSelectionType linkedStartGroupSelectionType;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public MasterAudio.LinkedGroupSelectionType linkedStopGroupSelectionType;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public LimitMode limitMode;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public int limitPerXFrames;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float minimumTimeBetween;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public bool useClipAgePriority;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		public bool limitPolyphony;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public int voiceLimitCount;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetDespawnedBehavior targetDespawnedBehavior;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float despawnFadeTime;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool isUsingOcclusion;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public bool willOcclusionOverrideRaycastOffset;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public bool willOcclusionOverrideFrequencies;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public bool isSoloed;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
		public bool isMuted;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD2")]
		public bool soundPlayedEventActive;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public string soundPlayedCustomEvent;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public bool willCleanUpDelegatesAfterStop;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public int frames;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private List<int> _activeAudioSourcesIds;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private string _objectName;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Transform _trans;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float _originalVolume;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x825660", Offset = "0x825660")]
		private int <ChainLoopCount>k__BackingField;

		[Token(Token = "0x17000021")]
		public float SpatialBlendForGroup
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x1C6188C", Offset = "0x1C6188C", VA = "0x1C6188C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000022")]
		public int ActiveVoices
		{
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x1C61978", Offset = "0x1C61978", VA = "0x1C61978")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000023")]
		public int TotalVoices
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x1C619C8", Offset = "0x1C619C8", VA = "0x1C619C8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000024")]
		public bool WillCleanUpDelegatesAfterStop
		{
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x1C619EC", Offset = "0x1C619EC", VA = "0x1C619EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public GroupBus BusForGroup
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x1C61710", Offset = "0x1C61710", VA = "0x1C61710")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		public float OriginalVolume
		{
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x1C619F8", Offset = "0x1C619F8", VA = "0x1C619F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x1C61A00", Offset = "0x1C61A00", VA = "0x1C61A00")]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public bool LoggingEnabledForGroup
		{
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x1C61A08", Offset = "0x1C61A08", VA = "0x1C61A08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000028")]
		public int ChainLoopCount
		{
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x1C61AD4", Offset = "0x1C61AD4", VA = "0x1C61AD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8258D0", Offset = "0x8258D0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x1C61ADC", Offset = "0x1C61ADC", VA = "0x1C61ADC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8258E0", Offset = "0x8258E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public string GameObjectName
		{
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x1C61AE4", Offset = "0x1C61AE4", VA = "0x1C61AE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		public MasterAudio.GroupPlayType GroupPlayType
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x1C61B34", Offset = "0x1C61B34", VA = "0x1C61B34")]
			get
			{
				return default(MasterAudio.GroupPlayType);
			}
		}

		[Token(Token = "0x1700002B")]
		public bool UsesNoRepeat
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x1C61C80", Offset = "0x1C61C80", VA = "0x1C61C80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002C")]
		private Transform Trans
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x1C615B0", Offset = "0x1C615B0", VA = "0x1C615B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		private List<int> ActiveAudioSourceIds
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x1C614F8", Offset = "0x1C614F8", VA = "0x1C614F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000001")]
		public event Action LastVariationFinishedPlay
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x1C6129C", Offset = "0x1C6129C", VA = "0x1C6129C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8258B0", Offset = "0x8258B0")]
			add
			{
			}
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x1C6133C", Offset = "0x1C6133C", VA = "0x1C6133C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8258C0", Offset = "0x8258C0")]
			remove
			{
			}
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1C613DC", Offset = "0x1C613DC", VA = "0x1C613DC")]
		private void Start()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1C61650", Offset = "0x1C61650", VA = "0x1C61650")]
		public void AddActiveAudioSourceId(int varInstanceId)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1C617FC", Offset = "0x1C617FC", VA = "0x1C617FC")]
		public void RemoveActiveAudioSourceId(int varInstanceId)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1C61A80", Offset = "0x1C61A80", VA = "0x1C61A80")]
		public void FireLastVariationFinishedPlay()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1C61A94", Offset = "0x1C61A94", VA = "0x1C61A94")]
		public void SubscribeToLastVariationFinishedPlay(Action finishedCallback)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1C61AC8", Offset = "0x1C61AC8", VA = "0x1C61AC8")]
		public void UnsubscribeFromLastVariationFinishedPlay()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1C61CF0", Offset = "0x1C61CF0", VA = "0x1C61CF0")]
		public MasterAudioGroup()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class MasterCustomEventAttribute : PropertyAttribute
	{
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1C68A58", Offset = "0x1C68A58", VA = "0x1C68A58")]
		public MasterCustomEventAttribute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007D")]
	public class MusicSetting
	{
		[Token(Token = "0x200007E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8225A8", Offset = "0x8225A8")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x400032D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataStringValue valToClone;

			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x1D30B64", Offset = "0x1D30B64", VA = "0x1D30B64")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x1D30B6C", Offset = "0x1D30B6C", VA = "0x1D30B6C")]
			internal bool <Clone>b__0(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200007F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8225B8", Offset = "0x8225B8")]
		private sealed class <>c__DisplayClass32_1
		{
			[Token(Token = "0x400032E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataFloatValue valToClone;

			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x1D30B98", Offset = "0x1D30B98", VA = "0x1D30B98")]
			public <>c__DisplayClass32_1()
			{
			}

			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x1D30BA0", Offset = "0x1D30BA0", VA = "0x1D30BA0")]
			internal bool <Clone>b__1(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000080")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8225C8", Offset = "0x8225C8")]
		private sealed class <>c__DisplayClass32_2
		{
			[Token(Token = "0x400032F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataBoolValue valToClone;

			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x1D30BCC", Offset = "0x1D30BCC", VA = "0x1D30BCC")]
			public <>c__DisplayClass32_2()
			{
			}

			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x1D30BD4", Offset = "0x1D30BD4", VA = "0x1D30BD4")]
			internal bool <Clone>b__2(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000081")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8225D8", Offset = "0x8225D8")]
		private sealed class <>c__DisplayClass32_3
		{
			[Token(Token = "0x4000330")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataIntValue valToClone;

			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x1D30C00", Offset = "0x1D30C00", VA = "0x1D30C00")]
			public <>c__DisplayClass32_3()
			{
			}

			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x1D30C08", Offset = "0x1D30C08", VA = "0x1D30C08")]
			internal bool <Clone>b__3(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string alias;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip clip;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string songName;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string resourceFileName;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float volume;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float pitch;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool isExpanded;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool isLoop;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		public bool isChecked;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<SongMetadataStringValue> metadataStringValues;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<SongMetadataBoolValue> metadataBoolValues;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<SongMetadataIntValue> metadataIntValues;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SongMetadataFloatValue> metadataFloatValues;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool metadataExpanded;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public MasterAudio.CustomSongStartTimeMode songStartTimeMode;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float customStartTime;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float customStartTimeMax;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int lastKnownTimePoint;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool wasLastKnownTimePointSet;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int songIndex;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool songStartedEventExpanded;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string songStartedCustomEvent;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool songChangedEventExpanded;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string songChangedCustomEvent;

		[Token(Token = "0x1700002E")]
		public bool HasMetadataProperties
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x1C69FBC", Offset = "0x1C69FBC", VA = "0x1C69FBC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002F")]
		public int MetadataPropertyCount
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x1C69FD8", Offset = "0x1C69FD8", VA = "0x1C69FD8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000030")]
		public float SongStartTime
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x1C6A078", Offset = "0x1C6A078", VA = "0x1C6A078")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x1C69DA0", Offset = "0x1C69DA0", VA = "0x1C69DA0")]
		public MusicSetting()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x1C6A0A4", Offset = "0x1C6A0A4", VA = "0x1C6A0A4")]
		public static MusicSetting Clone(MusicSetting mus, MasterAudio.Playlist aList)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000082")]
	public class OcclusionFreqChangeInfo
	{
		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SoundGroupVariation ActingVariation;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float StartFrequency;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float TargetFrequency;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartTime;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float CompletionTime;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsActive;

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x1C6A7B8", Offset = "0x1C6A7B8", VA = "0x1C6A7B8")]
		public OcclusionFreqChangeInfo()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class PlaylistAttribute : PropertyAttribute
	{
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x1C6B8C4", Offset = "0x1C6B8C4", VA = "0x1C6B8C4")]
		public PlaylistAttribute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000084")]
	public class SongMetadataBoolValue
	{
		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Value;

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x1D24688", Offset = "0x1D24688", VA = "0x1D24688")]
		public SongMetadataBoolValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000085")]
	public class SongMetadataFloatValue
	{
		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Value;

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x1D246CC", Offset = "0x1D246CC", VA = "0x1D246CC")]
		public SongMetadataFloatValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000086")]
	public class SongMetadataIntValue
	{
		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Value;

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1D24710", Offset = "0x1D24710", VA = "0x1D24710")]
		public SongMetadataIntValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000087")]
	public class SongMetadataProperty
	{
		[Token(Token = "0x2000088")]
		public enum MetadataPropertyType
		{
			[Token(Token = "0x4000345")]
			Boolean,
			[Token(Token = "0x4000346")]
			String,
			[Token(Token = "0x4000347")]
			Integer,
			[Token(Token = "0x4000348")]
			Float
		}

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MetadataPropertyType PropertyType;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string PropertyName;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ProspectiveName;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsEditing;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool PropertyExpanded;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool AllSongsMustContain;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		public bool CanSongHaveMultiple;

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1D24754", Offset = "0x1D24754", VA = "0x1D24754")]
		public SongMetadataProperty(string propertyName, MetadataPropertyType propertyType, bool allSongsMustContain, bool canSongHaveMultiple)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000089")]
	public class SongMetadataStringValue
	{
		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Value;

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1D247D4", Offset = "0x1D247D4", VA = "0x1D247D4")]
		public SongMetadataStringValue(SongMetadataProperty prop)
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class SoundGroupAttribute : PropertyAttribute
	{
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x1D24818", Offset = "0x1D24818", VA = "0x1D24818")]
		public SoundGroupAttribute()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8225E8", Offset = "0x8225E8")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x8225E8", Offset = "0x8225E8")]
	public class SoundGroupVariation : MonoBehaviour
	{
		[Token(Token = "0x200008C")]
		public delegate void SoundFinishedEventHandler();

		[Token(Token = "0x200008D")]
		public delegate void SoundLoopedEventHandler(int loopNumberStarted);

		[Token(Token = "0x200008E")]
		public class PlaySoundParams
		{
			[Token(Token = "0x4000391")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string SoundType;

			[Token(Token = "0x4000392")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float VolumePercentage;

			[Token(Token = "0x4000393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float? Pitch;

			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public double? TimeToSchedulePlay;

			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform SourceTrans;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool AttachToSource;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float DelaySoundTime;

			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public bool IsChainLoop;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
			public bool IsSingleSubscribedPlay;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float GroupCalcVolume;

			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public bool IsPlaying;

			[Token(Token = "0x6000224")]
			[Address(RVA = "0x1D2A3E8", Offset = "0x1D2A3E8", VA = "0x1D2A3E8")]
			public PlaySoundParams(string soundType, float volPercent, float groupCalcVolume, float? pitch, Transform sourceTrans, bool attach, float delaySoundTime, double? timeToSchedulePlay, bool isChainLoop, bool isSingleSubscribedPlay)
			{
			}
		}

		[Token(Token = "0x200008F")]
		public enum PitchMode
		{
			[Token(Token = "0x400039D")]
			None,
			[Token(Token = "0x400039E")]
			Gliding
		}

		[Token(Token = "0x2000090")]
		public enum FadeMode
		{
			[Token(Token = "0x40003A0")]
			None,
			[Token(Token = "0x40003A1")]
			FadeInOut,
			[Token(Token = "0x40003A2")]
			FadeOutEarly,
			[Token(Token = "0x40003A3")]
			GradualFade
		}

		[Token(Token = "0x2000091")]
		public enum RandomPitchMode
		{
			[Token(Token = "0x40003A5")]
			AddToClipPitch,
			[Token(Token = "0x40003A6")]
			IgnoreClipPitch
		}

		[Token(Token = "0x2000092")]
		public enum RandomVolumeMode
		{
			[Token(Token = "0x40003A8")]
			AddToClipVolume,
			[Token(Token = "0x40003A9")]
			IgnoreClipVolume
		}

		[Token(Token = "0x2000093")]
		public enum DetectEndMode
		{
			[Token(Token = "0x40003AB")]
			None,
			[Token(Token = "0x40003AC")]
			DetectEnd
		}

		[Token(Token = "0x2000094")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82265C", Offset = "0x82265C")]
		private sealed class <WaitForLoadToUnloadClipAndDeactivate>d__110 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoundGroupVariation <>4__this;

			[Token(Token = "0x17000051")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000228")]
				[Address(RVA = "0x1D31D44", Offset = "0x1D31D44", VA = "0x1D31D44", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000052")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600022A")]
				[Address(RVA = "0x1D31D8C", Offset = "0x1D31D8C", VA = "0x1D31D8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000225")]
			[Address(RVA = "0x1D28C90", Offset = "0x1D28C90", VA = "0x1D28C90")]
			[DebuggerHidden]
			public <WaitForLoadToUnloadClipAndDeactivate>d__110(int <>1__state)
			{
			}

			[Token(Token = "0x6000226")]
			[Address(RVA = "0x1D31C6C", Offset = "0x1D31C6C", VA = "0x1D31C6C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000227")]
			[Address(RVA = "0x1D31C70", Offset = "0x1D31C70", VA = "0x1D31C70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000229")]
			[Address(RVA = "0x1D31D4C", Offset = "0x1D31D4C", VA = "0x1D31D4C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int weight;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x825670", Offset = "0x825670")]
		public int probabilityToPlay;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x825688", Offset = "0x825688")]
		public int importance;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isUninterruptible;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool useLocalization;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool useRandomPitch;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RandomPitchMode randomPitchMode;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float randomPitchMin;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float randomPitchMax;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool useRandomVolume;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RandomVolumeMode randomVolumeMode;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float randomVolumeMin;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float randomVolumeMax;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string resourceFileName;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float original_pitch;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float original_volume;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool isExpanded;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool isChecked;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public bool useFades;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float fadeInTime;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float fadeOutTime;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool useCustomLooping;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int minCustomLoops;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int maxCustomLoops;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool useRandomStartTime;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float randomStartMinPercent;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float randomStartMaxPercent;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float randomEndPercent;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool useIntroSilence;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float introSilenceMin;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float introSilenceMax;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float fadeMaxVolume;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public FadeMode curFadeMode;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public PitchMode curPitchMode;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public DetectEndMode curDetectEndMode;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int frames;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AudioSource _audioSource;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly PlaySoundParams _playSndParam;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AudioDistortionFilter _distFilter;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AudioEchoFilter _echoFilter;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioHighPassFilter _hpFilter;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private AudioLowPassFilter _lpFilter;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private AudioReverbFilter _reverbFilter;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private AudioChorusFilter _chorusFilter;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float _maxVol;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private int _instanceId;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool? _audioLoops;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private int _maxLoops;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private SoundGroupVariationUpdater _varUpdater;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int _previousSoundFinishedFrame;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private string _soundGroupName;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private MasterAudio.VariationLoadStatus _loadStatus;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool _isStopRequested;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10D")]
		private bool _isPaused;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10E")]
		private bool _isWarmingPlay;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Transform _trans;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private GameObject _go;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Transform _objectToFollow;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Transform _objectToTriggerFrom;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private MasterAudioGroup _parentGroupScript;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private bool _attachToSource;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private string _resFileName;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private bool _hasStartedEndLinkedGroups;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Coroutine _loadResourceFileCoroutine;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Coroutine _loadAddressableCoroutine;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private bool _isUnloadAddressableCoroutineRunning;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8256C0", Offset = "0x8256C0")]
		private float <LastTimePlayed>k__BackingField;

		[Token(Token = "0x17000031")]
		public AudioDistortionFilter DistortionFilter
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x1D296D8", Offset = "0x1D296D8", VA = "0x1D296D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public AudioReverbFilter ReverbFilter
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x1D2978C", Offset = "0x1D2978C", VA = "0x1D2978C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public AudioChorusFilter ChorusFilter
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x1D29840", Offset = "0x1D29840", VA = "0x1D29840")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public AudioEchoFilter EchoFilter
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x1D298F4", Offset = "0x1D298F4", VA = "0x1D298F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public AudioLowPassFilter LowPassFilter
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x1D299A8", Offset = "0x1D299A8", VA = "0x1D299A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x1D299B0", Offset = "0x1D299B0", VA = "0x1D299B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public AudioHighPassFilter HighPassFilter
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x1D299B8", Offset = "0x1D299B8", VA = "0x1D299B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public Transform ObjectToFollow
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x1D29A6C", Offset = "0x1D29A6C", VA = "0x1D29A6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x1D29A74", Offset = "0x1D29A74", VA = "0x1D29A74")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public Transform ObjectToTriggerFrom
		{
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x1D29BE8", Offset = "0x1D29BE8", VA = "0x1D29BE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x1D29BF0", Offset = "0x1D29BF0", VA = "0x1D29BF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public bool HasActiveFXFilter
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x1D29C20", Offset = "0x1D29C20", VA = "0x1D29C20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003A")]
		public MasterAudioGroup ParentGroup
		{
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x1D25798", Offset = "0x1D25798", VA = "0x1D25798")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public float OriginalPitch
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x1D26C00", Offset = "0x1D26C00", VA = "0x1D26C00")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003C")]
		public float OriginalVolume
		{
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x1D29E64", Offset = "0x1D29E64", VA = "0x1D29E64")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003D")]
		public string SoundGroupName
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x1D29EA4", Offset = "0x1D29EA4", VA = "0x1D29EA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public bool IsAvailableToPlay
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x1D29EF8", Offset = "0x1D29EF8", VA = "0x1D29EF8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003F")]
		public float LastTimePlayed
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x1D29FA0", Offset = "0x1D29FA0", VA = "0x1D29FA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x825990", Offset = "0x825990")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x1D29FA8", Offset = "0x1D29FA8", VA = "0x1D29FA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8259A0", Offset = "0x8259A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public bool ClipIsLoaded
		{
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x1D29FB0", Offset = "0x1D29FB0", VA = "0x1D29FB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000041")]
		public bool IsPlaying
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x1D27C54", Offset = "0x1D27C54", VA = "0x1D27C54")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000042")]
		public MasterAudio.VariationLoadStatus LoadStatus
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x1D29FC0", Offset = "0x1D29FC0", VA = "0x1D29FC0")]
			get
			{
				return default(MasterAudio.VariationLoadStatus);
			}
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x1D26A60", Offset = "0x1D26A60", VA = "0x1D26A60")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public int InstanceId
		{
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x1D27368", Offset = "0x1D27368", VA = "0x1D27368")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000044")]
		public bool IsStopRequested
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x1D29FC8", Offset = "0x1D29FC8", VA = "0x1D29FC8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000045")]
		public Transform Trans
		{
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x1D28860", Offset = "0x1D28860", VA = "0x1D28860")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public GameObject GameObj
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0x1D2505C", Offset = "0x1D2505C", VA = "0x1D2505C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public AudioSource VarAudio
		{
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x1D24FA8", Offset = "0x1D24FA8", VA = "0x1D24FA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public bool AudioLoops
		{
			[Token(Token = "0x600020E")]
			[Address(RVA = "0x1D272AC", Offset = "0x1D272AC", VA = "0x1D272AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000049")]
		public string ResFileName
		{
			[Token(Token = "0x600020F")]
			[Address(RVA = "0x1D26F74", Offset = "0x1D26F74", VA = "0x1D26F74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public SoundGroupVariationUpdater VariationUpdater
		{
			[Token(Token = "0x6000210")]
			[Address(RVA = "0x1D25E28", Offset = "0x1D25E28", VA = "0x1D25E28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public PlaySoundParams PlaySoundParm
		{
			[Token(Token = "0x6000211")]
			[Address(RVA = "0x1D29FD0", Offset = "0x1D29FD0", VA = "0x1D29FD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public float SetGroupVolume
		{
			[Token(Token = "0x6000212")]
			[Address(RVA = "0x1D29FD8", Offset = "0x1D29FD8", VA = "0x1D29FD8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x1D29FF4", Offset = "0x1D29FF4", VA = "0x1D29FF4")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public int MaxLoops
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0x1D2A010", Offset = "0x1D2A010", VA = "0x1D2A010")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004E")]
		private bool Is2D
		{
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x1D2A018", Offset = "0x1D2A018", VA = "0x1D2A018")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004F")]
		public bool UsesOcclusion
		{
			[Token(Token = "0x6000216")]
			[Address(RVA = "0x1D26000", Offset = "0x1D26000", VA = "0x1D26000")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000050")]
		public bool IsPaused
		{
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x1D2A044", Offset = "0x1D2A044", VA = "0x1D2A044")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000002")]
		public event SoundFinishedEventHandler SoundFinished
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x1D24B2C", Offset = "0x1D24B2C", VA = "0x1D24B2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8258F0", Offset = "0x8258F0")]
			add
			{
			}
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x1D24BD0", Offset = "0x1D24BD0", VA = "0x1D24BD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x825900", Offset = "0x825900")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event SoundLoopedEventHandler SoundLooped
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x1D24C74", Offset = "0x1D24C74", VA = "0x1D24C74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x825910", Offset = "0x825910")]
			add
			{
			}
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x1D24D18", Offset = "0x1D24D18", VA = "0x1D24D18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x825920", Offset = "0x825920")]
			remove
			{
			}
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x1D24DBC", Offset = "0x1D24DBC", VA = "0x1D24DBC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x1D250FC", Offset = "0x1D250FC", VA = "0x1D250FC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x1D25970", Offset = "0x1D25970", VA = "0x1D25970")]
		public void SetMixerGroup()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1D259C8", Offset = "0x1D259C8", VA = "0x1D259C8")]
		public void SetSpatialBlend()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1D25B78", Offset = "0x1D25B78", VA = "0x1D25B78")]
		private void SetOcclusion()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1D25ACC", Offset = "0x1D25ACC", VA = "0x1D25ACC")]
		private void SetPriority()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x1D26200", Offset = "0x1D26200", VA = "0x1D26200")]
		public void DisableUpdater()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x1D262A4", Offset = "0x1D262A4", VA = "0x1D262A4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1D26370", Offset = "0x1D26370", VA = "0x1D26370")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x1D262A8", Offset = "0x1D262A8", VA = "0x1D262A8")]
		private void StopSoundEarly()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x1D26710", Offset = "0x1D26710", VA = "0x1D26710")]
		public void Play(float? pitch, float maxVolume, string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, double? timeToSchedulePlay, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1D26ACC", Offset = "0x1D26ACC", VA = "0x1D26ACC")]
		public void SetPlaySoundParams(string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, double? timeToSchedulePlay, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x1D26A74", Offset = "0x1D26A74", VA = "0x1D26A74")]
		private void MaybeCleanupFinishedDelegate()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1D27054", Offset = "0x1D27054", VA = "0x1D27054")]
		private void ResourceFailedToLoad()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1D26C40", Offset = "0x1D26C40", VA = "0x1D26C40")]
		private void FinishSetupToPlay()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x1D2747C", Offset = "0x1D2747C", VA = "0x1D2747C")]
		public void JumpToTime(float timeToJumpTo)
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x1D274C8", Offset = "0x1D274C8", VA = "0x1D274C8")]
		public void GlideByPitch(float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1D277C4", Offset = "0x1D277C4", VA = "0x1D277C4")]
		public void AdjustVolume(float volumePercentage)
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x1D27950", Offset = "0x1D27950", VA = "0x1D27950")]
		public void Pause()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x1D27AD0", Offset = "0x1D27AD0", VA = "0x1D27AD0")]
		public void PlayVideo()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1D27B20", Offset = "0x1D27B20", VA = "0x1D27B20")]
		public void StopVideo()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1D27B70", Offset = "0x1D27B70", VA = "0x1D27B70")]
		public void Unpause()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x1D27D6C", Offset = "0x1D27D6C", VA = "0x1D27D6C")]
		public void DoNextChain(float volumePercentage, float? pitch, Transform transActor, bool attach)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x1D28174", Offset = "0x1D28174", VA = "0x1D28174")]
		public void PlayEndLinkedGroups([Optional] double? timeToPlayClip)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x1D27074", Offset = "0x1D27074", VA = "0x1D27074")]
		private void EnableUpdater(bool waitForSoundFinish = true)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x1D2872C", Offset = "0x1D2872C", VA = "0x1D2872C")]
		private void MaybeUnloadClip()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x1D28410", Offset = "0x1D28410", VA = "0x1D28410")]
		private void PlayEndLinkedGroup(string sType, [Optional] double? timeToPlayClip)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x1D26374", Offset = "0x1D26374", VA = "0x1D26374")]
		public void Stop(bool stopEndDetection = false, bool skipLinked = false)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x1D28BD4", Offset = "0x1D28BD4", VA = "0x1D28BD4")]
		private void StopEndCleanup()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x1D28C18", Offset = "0x1D28C18", VA = "0x1D28C18")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x825930", Offset = "0x825930")]
		private IEnumerator WaitForLoadToUnloadClipAndDeactivate()
		{
			return null;
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x1D28CBC", Offset = "0x1D28CBC", VA = "0x1D28CBC")]
		public void FadeToVolume(float newVolume, float fadeTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x1D290E8", Offset = "0x1D290E8", VA = "0x1D290E8")]
		public void FadeOutNowAndStop([Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x1D293C8", Offset = "0x1D293C8", VA = "0x1D293C8")]
		public void FadeOutNowAndStop(float fadeTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x1D29510", Offset = "0x1D29510", VA = "0x1D29510")]
		public bool WasTriggeredFromTransform(Transform trans)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x1D295CC", Offset = "0x1D295CC", VA = "0x1D295CC")]
		public bool WasTriggeredFromAnyOfTransformMap(HashSet<Transform> transMap)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x1D29AA4", Offset = "0x1D29AA4", VA = "0x1D29AA4")]
		public void UpdateTransformTracker(Transform sourceTrans)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x1D2A04C", Offset = "0x1D2A04C", VA = "0x1D2A04C")]
		public void SoundLoopStarted(int numberOfLoops)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x1D2701C", Offset = "0x1D2701C", VA = "0x1D2701C")]
		public void ClearSubscribers()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x1D2A288", Offset = "0x1D2A288", VA = "0x1D2A288")]
		public SoundGroupVariation()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1D2A4B8", Offset = "0x1D2A4B8", VA = "0x1D2A4B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8259B0", Offset = "0x8259B0")]
		private bool <Start>b__82_0(VideoPlayer vid)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000095")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x82266C", Offset = "0x82266C")]
	public class SoundGroupVariationUpdater : MonoBehaviour
	{
		[Token(Token = "0x2000096")]
		private enum WaitForSoundFinishMode
		{
			[Token(Token = "0x40003E7")]
			None,
			[Token(Token = "0x40003E8")]
			Play,
			[Token(Token = "0x40003E9")]
			WaitForEnd,
			[Token(Token = "0x40003EA")]
			StopOrRepeat
		}

		[Token(Token = "0x40003B0")]
		private const float TimeEarlyToScheduleNextClip = 0.1f;

		[Token(Token = "0x40003B1")]
		private const float FakeNegativeFloatValue = -10f;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform _objectToFollow;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject _objectToFollowGo;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _isFollowing;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SoundGroupVariation _variation;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _priorityLastUpdated;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool _useClipAgePriority;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WaitForSoundFinishMode _waitMode;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AudioSource _varAudio;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MasterAudioGroup _parentGrp;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _trans;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _frameNum;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool _inited;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _fadeOutStartTime;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool _fadeInOutWillFadeOut;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		private bool _hasFadeInOutSetMaxVolume;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _fadeInOutInFactor;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float _fadeInOutOutFactor;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Action _fadeOutEarlyCompletionCallback;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _fadeOutEarlyTotalFrames;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float _fadeOutEarlyFrameVolChange;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _fadeOutEarlyFrameNumber;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float _fadeOutEarlyOrigVol;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float _fadeToTargetFrameVolChange;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int _fadeToTargetFrameNumber;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _fadeToTargetOrigVol;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Action _fadeToTargetCompletionCallback;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int _fadeToTargetTotalFrames;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private float _fadeToTargetVolume;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool _fadeOutStarted;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float _lastFrameClipTime;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool _isPlayingBackward;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int _pitchGlideToTargetTotalFrames;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float _pitchGlideToTargetFramePitchChange;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int _pitchGlideToTargetFrameNumber;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float _glideToTargetPitch;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float _glideToTargetOrigPitch;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Action _glideToPitchCompletionCallback;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool _hasStartedNextInChain;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		private bool _isWaitingForQueuedOcclusionRay;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private int _framesPlayed;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float? _clipStartPosition;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float? _clipEndPosition;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private double? _clipSchedEndTime;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool _hasScheduledNextClip;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x101")]
		private bool _hasScheduledEndLinkedGroups;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private int _lastFrameClipPosition;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int _timesLooped;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool _isPaused;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private double _pauseTime;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _maCachedFromFrame;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static MasterAudio _maThisFrame;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Transform _listenerThisFrame;

		[Token(Token = "0x17000053")]
		public float ClipStartPosition
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x1D2B9B0", Offset = "0x1D2B9B0", VA = "0x1D2B9B0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000054")]
		public float ClipEndPosition
		{
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x1D2A660", Offset = "0x1D2A660", VA = "0x1D2A660")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000055")]
		public int FramesPlayed
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x1D2C680", Offset = "0x1D2C680", VA = "0x1D2C680")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000056")]
		public MasterAudio MAThisFrame
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x1D2C688", Offset = "0x1D2C688", VA = "0x1D2C688")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		public float MaxOcclusionFreq
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x1D2C6EC", Offset = "0x1D2C6EC", VA = "0x1D2C6EC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000058")]
		public float MinOcclusionFreq
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x1D2C7A0", Offset = "0x1D2C7A0", VA = "0x1D2C7A0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000059")]
		private Transform Trans
		{
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x1D2AD08", Offset = "0x1D2AD08", VA = "0x1D2AD08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		private AudioSource VarAudio
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x1D2A5B8", Offset = "0x1D2A5B8", VA = "0x1D2A5B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		private MasterAudioGroup ParentGroup
		{
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x1D2ADB0", Offset = "0x1D2ADB0", VA = "0x1D2ADB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		private SoundGroupVariation GrpVariation
		{
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x1D2A504", Offset = "0x1D2A504", VA = "0x1D2A504")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		private float RayCastOriginOffset
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x1D2B8FC", Offset = "0x1D2B8FC", VA = "0x1D2B8FC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700005E")]
		private bool IsOcclusionMeasuringPaused
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x1D2B064", Offset = "0x1D2B064", VA = "0x1D2B064")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		private bool HasEndLinkedGroups
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x1D2C618", Offset = "0x1D2C618", VA = "0x1D2C618")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1D27714", Offset = "0x1D27714", VA = "0x1D27714")]
		public void GlidePitch(float targetPitch, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x1D28F60", Offset = "0x1D28F60", VA = "0x1D28F60")]
		public void FadeOverTimeToVolume(float targetVolume, float fadeTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1D29228", Offset = "0x1D29228", VA = "0x1D29228")]
		public void FadeOutEarly(float fadeTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1D28670", Offset = "0x1D28670", VA = "0x1D28670")]
		public void Initialize()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1D27180", Offset = "0x1D27180", VA = "0x1D27180")]
		public void FadeInOut()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x1D2739C", Offset = "0x1D2739C", VA = "0x1D2739C")]
		public void FollowObject(bool follow, Transform objToFollow, bool clipAgePriority)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1D286AC", Offset = "0x1D286AC", VA = "0x1D286AC")]
		public void WaitForSoundFinish()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x1D28974", Offset = "0x1D28974", VA = "0x1D28974")]
		public void StopPitchGliding()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x1D28944", Offset = "0x1D28944", VA = "0x1D28944")]
		public void StopFading()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x1D28140", Offset = "0x1D28140", VA = "0x1D28140")]
		public void StopWaitingForFinish()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1D28900", Offset = "0x1D28900", VA = "0x1D28900")]
		public void StopFollowing()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x1D2AC8C", Offset = "0x1D2AC8C", VA = "0x1D2AC8C")]
		private void DisableIfFinished()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x1D2A7A4", Offset = "0x1D2A7A4", VA = "0x1D2A7A4")]
		private void UpdateAudioLocationAndPriority(bool rePrioritize)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x1D2AE58", Offset = "0x1D2AE58", VA = "0x1D2AE58")]
		private void ResetToNonOcclusionSetting()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x1D2AF00", Offset = "0x1D2AF00", VA = "0x1D2AF00")]
		private void UpdateOcclusion()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1D2B0F0", Offset = "0x1D2B0F0", VA = "0x1D2B0F0")]
		private void DoneWithOcclusion()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x1D2B168", Offset = "0x1D2B168", VA = "0x1D2B168")]
		public bool RayCastForOcclusion()
		{
			return default(bool);
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1D2A934", Offset = "0x1D2A934", VA = "0x1D2A934")]
		private void PlaySoundAndWait()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1D2BB00", Offset = "0x1D2BB00", VA = "0x1D2BB00")]
		private void DuckIfNotSilent()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1D2BC78", Offset = "0x1D2BC78", VA = "0x1D2BC78")]
		private void StopOrChain()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1D27A58", Offset = "0x1D27A58", VA = "0x1D27A58")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1D27C70", Offset = "0x1D27C70", VA = "0x1D27C70")]
		public void Unpause()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1D27E20", Offset = "0x1D27E20", VA = "0x1D27E20")]
		public void MaybeChain()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1D2BD14", Offset = "0x1D2BD14", VA = "0x1D2BD14")]
		private void UpdatePitch()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x1D2BDD8", Offset = "0x1D2BDD8", VA = "0x1D2BDD8")]
		private void PerformFading()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x1D2C0BC", Offset = "0x1D2C0BC", VA = "0x1D2C0BC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1D2C144", Offset = "0x1D2C144", VA = "0x1D2C144")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1D25EDC", Offset = "0x1D25EDC", VA = "0x1D25EDC")]
		public void UpdateCachedObjects()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1D2C22C", Offset = "0x1D2C22C", VA = "0x1D2C22C")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1D2C854", Offset = "0x1D2C854", VA = "0x1D2C854")]
		public SoundGroupVariationUpdater()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public static class AudioLoaderOptimizer
	{
		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, List<GameObject>> PlayingGameObjectsByClipName;

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1597934", Offset = "0x1597934", VA = "0x1597934")]
		public static void AddNonPreloadedPlayingClip(AudioClip clip, GameObject maHolderGameObject)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1597B84", Offset = "0x1597B84", VA = "0x1597B84")]
		public static void RemoveNonPreloadedPlayingClip(AudioClip clip, GameObject maHolderGameObject)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x1597D54", Offset = "0x1597D54", VA = "0x1597D54")]
		public static bool IsAnyOfNonPreloadedClipPlaying(AudioClip clip)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000098")]
	public static class AudioPrioritizer
	{
		[Token(Token = "0x40003EC")]
		private const int MaxPriority = 0;

		[Token(Token = "0x40003ED")]
		private const int HighestPriority = 16;

		[Token(Token = "0x40003EE")]
		private const int LowestPriority = 128;

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1597F44", Offset = "0x1597F44", VA = "0x1597F44")]
		public static void Set2DSoundPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1597F60", Offset = "0x1597F60", VA = "0x1597F60")]
		public static void SetSoundGroupInitialPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x1597F7C", Offset = "0x1597F7C", VA = "0x1597F7C")]
		public static void SetPreviewPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1597F98", Offset = "0x1597F98", VA = "0x1597F98")]
		public static void Set3DPriority(SoundGroupVariation variation, bool useClipAgePriority)
		{
		}
	}
	[Token(Token = "0x2000099")]
	public static class AudioResourceOptimizer
	{
		[Token(Token = "0x200009A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x822680", Offset = "0x822680")]
		private sealed class <PopulateResourceSongToPlaylistControllerAsync>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string songResourceName;

			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string playlistName;

			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public PlaylistController controller;

			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public MusicSetting songSetting;

			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public PlaylistController.AudioPlayType playType;

			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private ResourceRequest <asyncRes>5__2;

			[Token(Token = "0x17000060")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600026F")]
				[Address(RVA = "0x1D2E958", Offset = "0x1D2E958", VA = "0x1D2E958", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000061")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000271")]
				[Address(RVA = "0x1D2E9A0", Offset = "0x1D2E9A0", VA = "0x1D2E9A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600026C")]
			[Address(RVA = "0x1D2E34C", Offset = "0x1D2E34C", VA = "0x1D2E34C")]
			[DebuggerHidden]
			public <PopulateResourceSongToPlaylistControllerAsync>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x600026D")]
			[Address(RVA = "0x1D2E378", Offset = "0x1D2E378", VA = "0x1D2E378", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600026E")]
			[Address(RVA = "0x1D2E37C", Offset = "0x1D2E37C", VA = "0x1D2E37C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000270")]
			[Address(RVA = "0x1D2E960", Offset = "0x1D2E960", VA = "0x1D2E960", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200009B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x822690", Offset = "0x822690")]
		private sealed class <PopulateSourcesWithResourceClipAsync>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string clipName;

			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action successAction;

			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action failureAction;

			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public SoundGroupVariation variation;

			[Token(Token = "0x4000401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ResourceRequest <asyncRes>5__2;

			[Token(Token = "0x17000062")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000275")]
				[Address(RVA = "0x1D2F05C", Offset = "0x1D2F05C", VA = "0x1D2F05C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000063")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000277")]
				[Address(RVA = "0x1D2F0A4", Offset = "0x1D2F0A4", VA = "0x1D2F0A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000272")]
			[Address(RVA = "0x1D2E9A8", Offset = "0x1D2E9A8", VA = "0x1D2E9A8")]
			[DebuggerHidden]
			public <PopulateSourcesWithResourceClipAsync>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x6000273")]
			[Address(RVA = "0x1D2E9D4", Offset = "0x1D2E9D4", VA = "0x1D2E9D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000274")]
			[Address(RVA = "0x1D2E9D8", Offset = "0x1D2E9D8", VA = "0x1D2E9D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000276")]
			[Address(RVA = "0x1D2F064", Offset = "0x1D2F064", VA = "0x1D2F064", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, List<AudioSource>> AudioResourceTargetsByName;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<string, AudioClip> AudioClipsByName;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<string, List<AudioClip>> PlaylistClipsByPlaylistName;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static string _supportedLanguageFolder;

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x1598354", Offset = "0x1598354", VA = "0x1598354")]
		public static void ClearAudioClips()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1598404", Offset = "0x1598404", VA = "0x1598404")]
		public static string GetLocalizedDynamicSoundGroupFileName(SystemLanguage localLanguage, bool useLocalization, string resourceFileName)
		{
			return null;
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x1598580", Offset = "0x1598580", VA = "0x1598580")]
		public static string GetLocalizedFileName(bool useLocalization, string resourceFileName)
		{
			return null;
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x159890C", Offset = "0x159890C", VA = "0x159890C")]
		public static void AddTargetForClip(string clipName, AudioSource source)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x1598624", Offset = "0x1598624", VA = "0x1598624")]
		private static string SupportedLanguageFolder()
		{
			return null;
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1598D80", Offset = "0x1598D80", VA = "0x1598D80")]
		public static void ClearSupportLanguageFolder()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x1598E08", Offset = "0x1598E08", VA = "0x1598E08")]
		private static void FinishRecordingPlaylistClip(string controllerName, AudioClip resAudioClip)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x1598FAC", Offset = "0x1598FAC", VA = "0x1598FAC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x825A10", Offset = "0x825A10")]
		public static IEnumerator PopulateResourceSongToPlaylistControllerAsync(MusicSetting songSetting, string songResourceName, string playlistName, PlaylistController controller, PlaylistController.AudioPlayType playType)
		{
			return null;
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x1599078", Offset = "0x1599078", VA = "0x1599078")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x825A70", Offset = "0x825A70")]
		public static IEnumerator PopulateSourcesWithResourceClipAsync(string clipName, SoundGroupVariation variation, Action successAction, Action failureAction)
		{
			return null;
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x159913C", Offset = "0x159913C", VA = "0x159913C")]
		public static void UnloadPlaylistSongIfUnused(string controllerName, AudioClip clipToRemove)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x15992E0", Offset = "0x15992E0", VA = "0x15992E0")]
		public static void DeleteAudioSourceFromList(string clipName, AudioSource source)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x159958C", Offset = "0x159958C", VA = "0x159958C")]
		public static void UnloadClipIfUnused(string clipName)
		{
		}
	}
	[Token(Token = "0x200009C")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x8226A0", Offset = "0x8226A0")]
	public class MasterAudio : MonoBehaviour
	{
		[Token(Token = "0x200009D")]
		public enum BusVoiceLimitExceededMode
		{
			[Token(Token = "0x40004BE")]
			DoNotPlayNewSound,
			[Token(Token = "0x40004BF")]
			StopOldestSound,
			[Token(Token = "0x40004C0")]
			StopFarthestSound,
			[Token(Token = "0x40004C1")]
			StopLeastImportantSound
		}

		[Token(Token = "0x200009E")]
		public enum AmbientSoundExitMode
		{
			[Token(Token = "0x40004C3")]
			StopSound,
			[Token(Token = "0x40004C4")]
			FadeSound
		}

		[Token(Token = "0x200009F")]
		public enum AmbientSoundReEnterMode
		{
			[Token(Token = "0x40004C6")]
			StopExistingSound,
			[Token(Token = "0x40004C7")]
			FadeInSameSound
		}

		[Token(Token = "0x20000A0")]
		public enum VariationFollowerType
		{
			[Token(Token = "0x40004C9")]
			LateUpdate,
			[Token(Token = "0x40004CA")]
			FixedUpdate
		}

		[Token(Token = "0x20000A1")]
		public enum LinkedGroupSelectionType
		{
			[Token(Token = "0x40004CC")]
			All,
			[Token(Token = "0x40004CD")]
			OneAtRandom
		}

		[Token(Token = "0x20000A2")]
		public enum OcclusionSelectionType
		{
			[Token(Token = "0x40004CF")]
			AllGroups,
			[Token(Token = "0x40004D0")]
			TurnOnPerBusOrGroup
		}

		[Token(Token = "0x20000A3")]
		public enum RaycastMode
		{
			[Token(Token = "0x40004D2")]
			Physics3D,
			[Token(Token = "0x40004D3")]
			Physics2D
		}

		[Token(Token = "0x20000A4")]
		public enum AllMusicSpatialBlendType
		{
			[Token(Token = "0x40004D5")]
			ForceAllTo2D,
			[Token(Token = "0x40004D6")]
			ForceAllTo3D,
			[Token(Token = "0x40004D7")]
			ForceAllToCustom,
			[Token(Token = "0x40004D8")]
			AllowDifferentPerController
		}

		[Token(Token = "0x20000A5")]
		public enum AllMixerSpatialBlendType
		{
			[Token(Token = "0x40004DA")]
			ForceAllTo2D,
			[Token(Token = "0x40004DB")]
			ForceAllTo3D,
			[Token(Token = "0x40004DC")]
			ForceAllToCustom,
			[Token(Token = "0x40004DD")]
			AllowDifferentPerGroup
		}

		[Token(Token = "0x20000A6")]
		public enum ItemSpatialBlendType
		{
			[Token(Token = "0x40004DF")]
			ForceTo2D,
			[Token(Token = "0x40004E0")]
			ForceTo3D,
			[Token(Token = "0x40004E1")]
			ForceToCustom,
			[Token(Token = "0x40004E2")]
			UseCurveFromAudioSource
		}

		[Token(Token = "0x20000A7")]
		public enum GroupPlayType
		{
			[Token(Token = "0x40004E4")]
			Always,
			[Token(Token = "0x40004E5")]
			WhenActorInAudibleRange,
			[Token(Token = "0x40004E6")]
			AllowDifferentPerGroup
		}

		[Token(Token = "0x20000A8")]
		public enum DefaultGroupPlayType
		{
			[Token(Token = "0x40004E8")]
			Always,
			[Token(Token = "0x40004E9")]
			WhenActorInAudibleRange
		}

		[Token(Token = "0x20000A9")]
		public enum MixerWidthMode
		{
			[Token(Token = "0x40004EB")]
			Narrow,
			[Token(Token = "0x40004EC")]
			Normal,
			[Token(Token = "0x40004ED")]
			Wide
		}

		[Token(Token = "0x20000AA")]
		public enum CustomEventReceiveMode
		{
			[Token(Token = "0x40004EF")]
			Always,
			[Token(Token = "0x40004F0")]
			WhenDistanceLessThan,
			[Token(Token = "0x40004F1")]
			WhenDistanceMoreThan,
			[Token(Token = "0x40004F2")]
			Never,
			[Token(Token = "0x40004F3")]
			OnSameGameObject,
			[Token(Token = "0x40004F4")]
			OnChildGameObject,
			[Token(Token = "0x40004F5")]
			OnParentGameObject,
			[Token(Token = "0x40004F6")]
			OnSameOrChildGameObject,
			[Token(Token = "0x40004F7")]
			OnSameOrParentGameObject
		}

		[Token(Token = "0x20000AB")]
		public enum EventReceiveFilter
		{
			[Token(Token = "0x40004F9")]
			All,
			[Token(Token = "0x40004FA")]
			Closest,
			[Token(Token = "0x40004FB")]
			Random
		}

		[Token(Token = "0x20000AC")]
		public enum VariationLoadStatus
		{
			[Token(Token = "0x40004FD")]
			None,
			[Token(Token = "0x40004FE")]
			Loading,
			[Token(Token = "0x40004FF")]
			Loaded,
			[Token(Token = "0x4000500")]
			LoadFailed
		}

		[Token(Token = "0x20000AD")]
		public enum AudioLocation
		{
			[Token(Token = "0x4000502")]
			Clip,
			[Token(Token = "0x4000503")]
			ResourceFile
		}

		[Token(Token = "0x20000AE")]
		public enum CustomSongStartTimeMode
		{
			[Token(Token = "0x4000505")]
			Beginning,
			[Token(Token = "0x4000506")]
			SpecificTime,
			[Token(Token = "0x4000507")]
			RandomTime
		}

		[Token(Token = "0x20000AF")]
		public enum BusCommand
		{
			[Token(Token = "0x4000509")]
			None,
			[Token(Token = "0x400050A")]
			FadeToVolume,
			[Token(Token = "0x400050B")]
			Mute,
			[Token(Token = "0x400050C")]
			Pause,
			[Token(Token = "0x400050D")]
			Solo,
			[Token(Token = "0x400050E")]
			Unmute,
			[Token(Token = "0x400050F")]
			Unpause,
			[Token(Token = "0x4000510")]
			Unsolo,
			[Token(Token = "0x4000511")]
			Stop,
			[Token(Token = "0x4000512")]
			ChangePitch,
			[Token(Token = "0x4000513")]
			ToggleMute,
			[Token(Token = "0x4000514")]
			StopBusOfTransform,
			[Token(Token = "0x4000515")]
			PauseBusOfTransform,
			[Token(Token = "0x4000516")]
			UnpauseBusOfTransform,
			[Token(Token = "0x4000517")]
			GlideByPitch,
			[Token(Token = "0x4000518")]
			StopOldBusVoices,
			[Token(Token = "0x4000519")]
			FadeOutOldBusVoices
		}

		[Token(Token = "0x20000B0")]
		public enum DragGroupMode
		{
			[Token(Token = "0x400051B")]
			OneGroupPerClip,
			[Token(Token = "0x400051C")]
			OneGroupWithVariations
		}

		[Token(Token = "0x20000B1")]
		public enum EventSoundFunctionType
		{
			[Token(Token = "0x400051E")]
			PlaySound,
			[Token(Token = "0x400051F")]
			GroupControl,
			[Token(Token = "0x4000520")]
			BusControl,
			[Token(Token = "0x4000521")]
			PlaylistControl,
			[Token(Token = "0x4000522")]
			CustomEventControl,
			[Token(Token = "0x4000523")]
			GlobalControl,
			[Token(Token = "0x4000524")]
			UnityMixerControl,
			[Token(Token = "0x4000525")]
			PersistentSettingsControl
		}

		[Token(Token = "0x20000B2")]
		public enum LanguageMode
		{
			[Token(Token = "0x4000527")]
			UseDeviceSetting,
			[Token(Token = "0x4000528")]
			SpecificLanguage,
			[Token(Token = "0x4000529")]
			DynamicallySet
		}

		[Token(Token = "0x20000B3")]
		public enum UnityMixerCommand
		{
			[Token(Token = "0x400052B")]
			None,
			[Token(Token = "0x400052C")]
			TransitionToSnapshot,
			[Token(Token = "0x400052D")]
			TransitionToSnapshotBlend
		}

		[Token(Token = "0x20000B4")]
		public enum PlaylistCommand
		{
			[Token(Token = "0x400052F")]
			None,
			[Token(Token = "0x4000530")]
			ChangePlaylist,
			[Token(Token = "0x4000531")]
			FadeToVolume,
			[Token(Token = "0x4000532")]
			PlaySong,
			[Token(Token = "0x4000533")]
			PlayRandomSong,
			[Token(Token = "0x4000534")]
			PlayNextSong,
			[Token(Token = "0x4000535")]
			Pause,
			[Token(Token = "0x4000536")]
			Resume,
			[Token(Token = "0x4000537")]
			Stop,
			[Token(Token = "0x4000538")]
			Mute,
			[Token(Token = "0x4000539")]
			Unmute,
			[Token(Token = "0x400053A")]
			ToggleMute,
			[Token(Token = "0x400053B")]
			Restart,
			[Token(Token = "0x400053C")]
			Start,
			[Token(Token = "0x400053D")]
			StopLoopingCurrentSong,
			[Token(Token = "0x400053E")]
			StopPlaylistAfterCurrentSong,
			[Token(Token = "0x400053F")]
			AddSongToQueue
		}

		[Token(Token = "0x20000B5")]
		public enum CustomEventCommand
		{
			[Token(Token = "0x4000541")]
			None,
			[Token(Token = "0x4000542")]
			FireEvent
		}

		[Token(Token = "0x20000B6")]
		public enum GlobalCommand
		{
			[Token(Token = "0x4000544")]
			None,
			[Token(Token = "0x4000545")]
			PauseMixer,
			[Token(Token = "0x4000546")]
			UnpauseMixer,
			[Token(Token = "0x4000547")]
			StopMixer,
			[Token(Token = "0x4000548")]
			StopEverything,
			[Token(Token = "0x4000549")]
			PauseEverything,
			[Token(Token = "0x400054A")]
			UnpauseEverything,
			[Token(Token = "0x400054B")]
			MuteEverything,
			[Token(Token = "0x400054C")]
			UnmuteEverything,
			[Token(Token = "0x400054D")]
			SetMasterMixerVolume,
			[Token(Token = "0x400054E")]
			SetMasterPlaylistVolume
		}

		[Token(Token = "0x20000B7")]
		public enum SoundGroupCommand
		{
			[Token(Token = "0x4000550")]
			None,
			[Token(Token = "0x4000551")]
			FadeToVolume,
			[Token(Token = "0x4000552")]
			FadeOutAllOfSound,
			[Token(Token = "0x4000553")]
			Mute,
			[Token(Token = "0x4000554")]
			Pause,
			[Token(Token = "0x4000555")]
			Solo,
			[Token(Token = "0x4000556")]
			StopAllOfSound,
			[Token(Token = "0x4000557")]
			Unmute,
			[Token(Token = "0x4000558")]
			Unpause,
			[Token(Token = "0x4000559")]
			Unsolo,
			[Token(Token = "0x400055A")]
			StopAllSoundsOfTransform,
			[Token(Token = "0x400055B")]
			PauseAllSoundsOfTransform,
			[Token(Token = "0x400055C")]
			UnpauseAllSoundsOfTransform,
			[Token(Token = "0x400055D")]
			StopSoundGroupOfTransform,
			[Token(Token = "0x400055E")]
			PauseSoundGroupOfTransform,
			[Token(Token = "0x400055F")]
			UnpauseSoundGroupOfTransform,
			[Token(Token = "0x4000560")]
			FadeOutSoundGroupOfTransform,
			[Token(Token = "0x4000561")]
			RefillSoundGroupPool,
			[Token(Token = "0x4000562")]
			RouteToBus,
			[Token(Token = "0x4000563")]
			GlideByPitch,
			[Token(Token = "0x4000564")]
			ToggleSoundGroup,
			[Token(Token = "0x4000565")]
			ToggleSoundGroupOfTransform,
			[Token(Token = "0x4000566")]
			FadeOutAllSoundsOfTransform,
			[Token(Token = "0x4000567")]
			StopOldSoundGroupVoices,
			[Token(Token = "0x4000568")]
			FadeOutOldSoundGroupVoices
		}

		[Token(Token = "0x20000B8")]
		public enum PersistentSettingsCommand
		{
			[Token(Token = "0x400056A")]
			None,
			[Token(Token = "0x400056B")]
			SetBusVolume,
			[Token(Token = "0x400056C")]
			SetGroupVolume,
			[Token(Token = "0x400056D")]
			SetMixerVolume,
			[Token(Token = "0x400056E")]
			SetMusicVolume,
			[Token(Token = "0x400056F")]
			MixerMuteToggle,
			[Token(Token = "0x4000570")]
			MusicMuteToggle
		}

		[Token(Token = "0x20000B9")]
		public enum SongFadeInPosition
		{
			[Token(Token = "0x4000572")]
			NewClipFromBeginning = 1,
			[Token(Token = "0x4000573")]
			NewClipFromLastKnownPosition = 3,
			[Token(Token = "0x4000574")]
			SynchronizeClips = 5
		}

		[Token(Token = "0x20000BA")]
		public enum SoundSpawnLocationMode
		{
			[Token(Token = "0x4000576")]
			MasterAudioLocation,
			[Token(Token = "0x4000577")]
			CallerLocation,
			[Token(Token = "0x4000578")]
			AttachToCaller
		}

		[Token(Token = "0x20000BB")]
		public enum VariationCommand
		{
			[Token(Token = "0x400057A")]
			None,
			[Token(Token = "0x400057B")]
			Stop,
			[Token(Token = "0x400057C")]
			Pause,
			[Token(Token = "0x400057D")]
			Unpause
		}

		[Serializable]
		[Token(Token = "0x20000BC")]
		public struct CustomEventCandidate
		{
			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float DistanceAway;

			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ICustomEventReceiver Receiver;

			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform Trans;

			[Token(Token = "0x4000581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int RandomId;

			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x1D309A4", Offset = "0x1D309A4", VA = "0x1D309A4")]
			public CustomEventCandidate(float distance, ICustomEventReceiver rec, Transform trans, int randomId)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BD")]
		public class AudioGroupInfo
		{
			[Token(Token = "0x4000582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<AudioInfo> Sources;

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int LastFramePlayed;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float LastTimePlayed;

			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MasterAudioGroup Group;

			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool PlayedForWarming;

			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x1D308CC", Offset = "0x1D308CC", VA = "0x1D308CC")]
			public AudioGroupInfo(List<AudioInfo> sources, MasterAudioGroup groupScript)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BE")]
		public class AudioInfo
		{
			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource Source;

			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float OriginalVolume;

			[Token(Token = "0x4000589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float LastPercentageVolume;

			[Token(Token = "0x400058A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float LastRandomVolume;

			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SoundGroupVariation Variation;

			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x1D30934", Offset = "0x1D30934", VA = "0x1D30934")]
			public AudioInfo(SoundGroupVariation variation, AudioSource source, float origVol)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BF")]
		public class Playlist
		{
			[Token(Token = "0x20000C0")]
			public enum CrossfadeTimeMode
			{
				[Token(Token = "0x400059E")]
				UseMasterSetting,
				[Token(Token = "0x400059F")]
				Override
			}

			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isExpanded;

			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string playlistName;

			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SongFadeInPosition songTransitionType;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<MusicSetting> MusicSettings;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public AudioLocation bulkLocationMode;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public CrossfadeTimeMode crossfadeMode;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float crossFadeTime;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public bool fadeInFirstSong;

			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
			public bool fadeOutLastSong;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
			public bool bulkEditMode;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
			public bool isTemporary;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool showMetadata;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public List<SongMetadataProperty> songMetadataProps;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string newMetadataPropName;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public SongMetadataProperty.MetadataPropertyType newMetadataPropType;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public bool newMetadataPropRequired;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
			public bool newMetadataPropCanHaveMult;

			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x1D309F0", Offset = "0x1D309F0", VA = "0x1D309F0")]
			public Playlist()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C1")]
		public class SoundGroupRefillInfo
		{
			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float LastTimePlayed;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float InactivePeriodSeconds;

			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x1D30B2C", Offset = "0x1D30B2C", VA = "0x1D30B2C")]
			public SoundGroupRefillInfo(float lastTimePlayed, float inactivePeriodSeconds)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8226B4", Offset = "0x8226B4")]
		private sealed class <>c
		{
			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<OcclusionFreqChangeInfo> <>9__239_0;

			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Predicate<BusFadeInfo> <>9__240_0;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Predicate<GroupFadeInfo> <>9__241_0;

			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Predicate<AmbientSoundToTriggerInfo> <>9__242_0;

			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Predicate<GroupPitchGlideInfo> <>9__243_0;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Predicate<BusPitchGlideInfo> <>9__244_0;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static Predicate<AudioInfo> <>9__260_0;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static Comparison<CustomEventCandidate> <>9__465_0;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static Comparison<CustomEventCandidate> <>9__465_1;

			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x1D2F6D0", Offset = "0x1D2F6D0", VA = "0x1D2F6D0")]
			public <>c()
			{
			}

			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x1D2F6D8", Offset = "0x1D2F6D8", VA = "0x1D2F6D8")]
			internal bool <PerformOcclusionFrequencyChanges>b__239_0(OcclusionFreqChangeInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x1D2F6F8", Offset = "0x1D2F6F8", VA = "0x1D2F6F8")]
			internal bool <PerformBusFades>b__240_0(BusFadeInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x1D2F718", Offset = "0x1D2F718", VA = "0x1D2F718")]
			internal bool <PerformGroupFades>b__241_0(GroupFadeInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x1D2F738", Offset = "0x1D2F738", VA = "0x1D2F738")]
			internal bool <PerformDelayedAmbientTriggers>b__242_0(AmbientSoundToTriggerInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x1D2F770", Offset = "0x1D2F770", VA = "0x1D2F770")]
			internal bool <PerformGroupPitchGlides>b__243_0(GroupPitchGlideInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x1D2F790", Offset = "0x1D2F790", VA = "0x1D2F790")]
			internal bool <PerformBusPitchGlides>b__244_0(BusPitchGlideInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x1D2F7B0", Offset = "0x1D2F7B0", VA = "0x1D2F7B0")]
			internal bool <CanPlayDialogBasedOnImportanceOrIsNotDialog>b__260_0(AudioInfo info)
			{
				return default(bool);
			}

			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x1D2F7DC", Offset = "0x1D2F7DC", VA = "0x1D2F7DC")]
			internal int <FireCustomEvent>b__465_0(CustomEventCandidate x, CustomEventCandidate y)
			{
				return default(int);
			}

			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x1D2F7EC", Offset = "0x1D2F7EC", VA = "0x1D2F7EC")]
			internal int <FireCustomEvent>b__465_1(CustomEventCandidate x, CustomEventCandidate y)
			{
				return default(int);
			}
		}

		[Token(Token = "0x20000C3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8226C4", Offset = "0x8226C4")]
		private sealed class <>c__DisplayClass254_0
		{
			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x1D2F800", Offset = "0x1D2F800", VA = "0x1D2F800")]
			public <>c__DisplayClass254_0()
			{
			}

			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x1D2F808", Offset = "0x1D2F808", VA = "0x1D2F808")]
			internal void <PlaySoundAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x20000C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8226D4", Offset = "0x8226D4")]
		private sealed class <PlaySoundAndWaitUntilFinished>d__254 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float volumePercentage;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float? pitch;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float delaySoundTime;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string variationName;

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private <>c__DisplayClass254_0 <>8__1;

			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Action completedAction;

			[Token(Token = "0x17000089")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003D1")]
				[Address(RVA = "0x1D3087C", Offset = "0x1D3087C", VA = "0x1D3087C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003D3")]
				[Address(RVA = "0x1D308C4", Offset = "0x1D308C4", VA = "0x1D308C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x1D30558", Offset = "0x1D30558", VA = "0x1D30558")]
			[DebuggerHidden]
			public <PlaySoundAndWaitUntilFinished>d__254(int <>1__state)
			{
			}

			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x1D30584", Offset = "0x1D30584", VA = "0x1D30584", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x1D30588", Offset = "0x1D30588", VA = "0x1D30588", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x1D30884", Offset = "0x1D30884", VA = "0x1D30884", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000C5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8226E4", Offset = "0x8226E4")]
		private sealed class <>c__DisplayClass255_0
		{
			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x1D2F814", Offset = "0x1D2F814", VA = "0x1D2F814")]
			public <>c__DisplayClass255_0()
			{
			}

			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x1D2F81C", Offset = "0x1D2F81C", VA = "0x1D2F81C")]
			internal void <PlaySound3DAtTransformAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x20000C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8226F4", Offset = "0x8226F4")]
		private sealed class <PlaySound3DAtTransformAndWaitUntilFinished>d__255 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform sourceTrans;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float volumePercentage;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float? pitch;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float delaySoundTime;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string variationName;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public double? timeToSchedulePlay;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private <>c__DisplayClass255_0 <>8__1;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Action completedAction;

			[Token(Token = "0x1700008B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003D9")]
				[Address(RVA = "0x1D30178", Offset = "0x1D30178", VA = "0x1D30178", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003DB")]
				[Address(RVA = "0x1D301C0", Offset = "0x1D301C0", VA = "0x1D301C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x1D2FE24", Offset = "0x1D2FE24", VA = "0x1D2FE24")]
			[DebuggerHidden]
			public <PlaySound3DAtTransformAndWaitUntilFinished>d__255(int <>1__state)
			{
			}

			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x1D2FE50", Offset = "0x1D2FE50", VA = "0x1D2FE50", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x1D2FE54", Offset = "0x1D2FE54", VA = "0x1D2FE54", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x1D30180", Offset = "0x1D30180", VA = "0x1D30180", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000C7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x822704", Offset = "0x822704")]
		private sealed class <>c__DisplayClass256_0
		{
			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x1D2F828", Offset = "0x1D2F828", VA = "0x1D2F828")]
			public <>c__DisplayClass256_0()
			{
			}

			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x1D2F830", Offset = "0x1D2F830", VA = "0x1D2F830")]
			internal void <PlaySound3DFollowTransformAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x20000C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x822714", Offset = "0x822714")]
		private sealed class <PlaySound3DFollowTransformAndWaitUntilFinished>d__256 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform sourceTrans;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float volumePercentage;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float? pitch;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float delaySoundTime;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string variationName;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public double? timeToSchedulePlay;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private <>c__DisplayClass256_0 <>8__1;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Action completedAction;

			[Token(Token = "0x1700008D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003E1")]
				[Address(RVA = "0x1D30508", Offset = "0x1D30508", VA = "0x1D30508", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003E3")]
				[Address(RVA = "0x1D30550", Offset = "0x1D30550", VA = "0x1D30550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x1D301C8", Offset = "0x1D301C8", VA = "0x1D301C8")]
			[DebuggerHidden]
			public <PlaySound3DFollowTransformAndWaitUntilFinished>d__256(int <>1__state)
			{
			}

			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x1D301F4", Offset = "0x1D301F4", VA = "0x1D301F4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x1D301F8", Offset = "0x1D301F8", VA = "0x1D301F8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x1D30510", Offset = "0x1D30510", VA = "0x1D30510", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000C9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x822724", Offset = "0x822724")]
		private sealed class <>c__DisplayClass270_0
		{
			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MasterAudioGroup maGroup;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string variationName;

			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x1D2F83C", Offset = "0x1D2F83C", VA = "0x1D2F83C")]
			public <>c__DisplayClass270_0()
			{
			}

			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x1D2F844", Offset = "0x1D2F844", VA = "0x1D2F844")]
			internal bool <FindRetriggerableVariationInGroup>b__0(AudioInfo info)
			{
				return default(bool);
			}

			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x1D2F8C0", Offset = "0x1D2F8C0", VA = "0x1D2F8C0")]
			internal bool <FindRetriggerableVariationInGroup>b__1(AudioInfo info)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000CA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x822734", Offset = "0x822734")]
		private sealed class <>c__DisplayClass308_0
		{
			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x1D2F95C", Offset = "0x1D2F95C", VA = "0x1D2F95C")]
			public <>c__DisplayClass308_0()
			{
			}

			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x1D2F964", Offset = "0x1D2F964", VA = "0x1D2F964")]
			internal bool <RouteGroupToBus>b__1(GroupBus x)
			{
				return default(bool);
			}

			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x1D2F988", Offset = "0x1D2F988", VA = "0x1D2F988")]
			internal bool <RouteGroupToBus>b__0(GroupBus x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000CB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x822744", Offset = "0x822744")]
		private sealed class <>c__DisplayClass316_0
		{
			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string sType;

			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x1D2F9AC", Offset = "0x1D2F9AC", VA = "0x1D2F9AC")]
			public <>c__DisplayClass316_0()
			{
			}

			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x1D2F9B4", Offset = "0x1D2F9B4", VA = "0x1D2F9B4")]
			internal bool <FadeSoundGroupToVolume>b__0(GroupFadeInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x822754", Offset = "0x822754")]
		private sealed class <>c__DisplayClass319_0
		{
			[Token(Token = "0x40005D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string sType;

			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x1D2F9D8", Offset = "0x1D2F9D8", VA = "0x1D2F9D8")]
			public <>c__DisplayClass319_0()
			{
			}

			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x1D2F9E0", Offset = "0x1D2F9E0", VA = "0x1D2F9E0")]
			internal bool <GlideSoundGroupByPitch>b__0(GroupPitchGlideInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000CD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x822764", Offset = "0x822764")]
		private sealed class <>c__DisplayClass373_0
		{
			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x1D2FA04", Offset = "0x1D2FA04", VA = "0x1D2FA04")]
			public <>c__DisplayClass373_0()
			{
			}

			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x1D2FA0C", Offset = "0x1D2FA0C", VA = "0x1D2FA0C")]
			internal bool <CreateBus>b__0(GroupBus obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x822774", Offset = "0x822774")]
		private sealed class <>c__DisplayClass377_0
		{
			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x1D2FA30", Offset = "0x1D2FA30", VA = "0x1D2FA30")]
			public <>c__DisplayClass377_0()
			{
			}

			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x1D2FA38", Offset = "0x1D2FA38", VA = "0x1D2FA38")]
			internal bool <FadeBusToVolume>b__0(BusFadeInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000CF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x822784", Offset = "0x822784")]
		private sealed class <>c__DisplayClass380_0
		{
			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x1D2FA5C", Offset = "0x1D2FA5C", VA = "0x1D2FA5C")]
			public <>c__DisplayClass380_0()
			{
			}

			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x1D2FA64", Offset = "0x1D2FA64", VA = "0x1D2FA64")]
			internal bool <GlideBusByPitch>b__0(BusPitchGlideInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x822794", Offset = "0x822794")]
		private sealed class <>c__DisplayClass461_0
		{
			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string categoryName;

			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x1D2FA88", Offset = "0x1D2FA88", VA = "0x1D2FA88")]
			public <>c__DisplayClass461_0()
			{
			}

			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x1D2FA90", Offset = "0x1D2FA90", VA = "0x1D2FA90")]
			internal bool <CreateCustomEventCategoryIfNotThere>b__0(CustomEventCategory cat)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000D1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8227A4", Offset = "0x8227A4")]
		private sealed class <>c__DisplayClass462_0
		{
			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x1D2FAB4", Offset = "0x1D2FAB4", VA = "0x1D2FAB4")]
			public <>c__DisplayClass462_0()
			{
			}

			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x1D2FABC", Offset = "0x1D2FABC", VA = "0x1D2FABC")]
			internal bool <CreateCustomEvent>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000D2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8227B4", Offset = "0x8227B4")]
		private sealed class <>c__DisplayClass463_0
		{
			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x1D2FAE0", Offset = "0x1D2FAE0", VA = "0x1D2FAE0")]
			public <>c__DisplayClass463_0()
			{
			}

			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x1D2FAE8", Offset = "0x1D2FAE8", VA = "0x1D2FAE8")]
			internal bool <DeleteCustomEvent>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000D3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8227C4", Offset = "0x8227C4")]
		private sealed class <>c__DisplayClass464_0
		{
			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x1D2FB0C", Offset = "0x1D2FB0C", VA = "0x1D2FB0C")]
			public <>c__DisplayClass464_0()
			{
			}

			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x1D2FB14", Offset = "0x1D2FB14", VA = "0x1D2FB14")]
			internal bool <GetCustomEventByName>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8227D4", Offset = "0x8227D4")]
		private sealed class <>c__DisplayClass466_0
		{
			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x1D2FB38", Offset = "0x1D2FB38", VA = "0x1D2FB38")]
			public <>c__DisplayClass466_0()
			{
			}

			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x1D2FB40", Offset = "0x1D2FB40", VA = "0x1D2FB40")]
			internal bool <CustomEventExists>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000D5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8227E4", Offset = "0x8227E4")]
		private sealed class <>c__DisplayClass467_0
		{
			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string eventName;

			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x1D2FB64", Offset = "0x1D2FB64", VA = "0x1D2FB64")]
			public <>c__DisplayClass467_0()
			{
			}

			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x1D2FB6C", Offset = "0x1D2FB6C", VA = "0x1D2FB6C")]
			internal bool <GetChildReceivers>b__0(ICustomEventReceiver rec)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000D6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8227F4", Offset = "0x8227F4")]
		private sealed class <>c__DisplayClass468_0
		{
			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string eventName;

			[Token(Token = "0x6000400")]
			[Address(RVA = "0x1D2FC38", Offset = "0x1D2FC38", VA = "0x1D2FC38")]
			public <>c__DisplayClass468_0()
			{
			}

			[Token(Token = "0x6000401")]
			[Address(RVA = "0x1D2FC40", Offset = "0x1D2FC40", VA = "0x1D2FC40")]
			internal bool <GetParentReceivers>b__0(ICustomEventReceiver rec)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x822804", Offset = "0x822804")]
		private sealed class <>c__DisplayClass483_0
		{
			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AmbientSound ambient;

			[Token(Token = "0x6000402")]
			[Address(RVA = "0x1D2FD0C", Offset = "0x1D2FD0C", VA = "0x1D2FD0C")]
			public <>c__DisplayClass483_0()
			{
			}

			[Token(Token = "0x6000403")]
			[Address(RVA = "0x1D2FD14", Offset = "0x1D2FD14", VA = "0x1D2FD14")]
			internal bool <SetupAmbientNextFrame>b__0(AmbientSoundToTriggerInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x822814", Offset = "0x822814")]
		private sealed class <>c__DisplayClass484_0
		{
			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AmbientSound ambient;

			[Token(Token = "0x6000404")]
			[Address(RVA = "0x1D2FD98", Offset = "0x1D2FD98", VA = "0x1D2FD98")]
			public <>c__DisplayClass484_0()
			{
			}

			[Token(Token = "0x6000405")]
			[Address(RVA = "0x1D2FDA0", Offset = "0x1D2FDA0", VA = "0x1D2FDA0")]
			internal bool <RemoveDelayedAmbient>b__0(AmbientSoundToTriggerInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000402")]
		public const string VideoPlayersSoundGroupSelectedError = "Can't use specially named Sound Group for Video Players. Please select another.";

		[Token(Token = "0x4000403")]
		public const string VideoPlayerSoundGroupName = "_VideoPlayers";

		[Token(Token = "0x4000404")]
		public const string VideoPlayerBusName = "_VideoPlayers";

		[Token(Token = "0x4000405")]
		public const string MasterAudioDefaultFolder = "Assets/Plugins/DarkTonic/MasterAudio";

		[Token(Token = "0x4000406")]
		public const string PreviewText = "Random delay, custom fading & start/end position settings are ignored by preview in edit mode.";

		[Token(Token = "0x4000407")]
		public const string LoopDisabledLoopedChain = "Loop Clip is always OFF for Looped Chain Groups";

		[Token(Token = "0x4000408")]
		public const string LoopDisabledCustomEnd = "Loop Clip is always OFF when using Custom End Position";

		[Token(Token = "0x4000409")]
		public const string DragAudioTip = "Drag Audio clips or a folder containing some here";

		[Token(Token = "0x400040A")]
		public const string NoCategory = "[Uncategorized]";

		[Token(Token = "0x400040B")]
		public const float SemiTonePitchFactor = 1.05946f;

		[Token(Token = "0x400040C")]
		public const float SpatialBlend_2DValue = 0f;

		[Token(Token = "0x400040D")]
		public const float SpatialBlend_3DValue = 1f;

		[Token(Token = "0x400040E")]
		public const float MaxCrossFadeTimeSeconds = 120f;

		[Token(Token = "0x400040F")]
		public const float DefaultDuckVolCut = -6f;

		[Token(Token = "0x4000410")]
		public const int ERROR_MA_LAYER_COLLISIONS_DISABLED = 1;

		[Token(Token = "0x4000411")]
		public const int PHYSICS_DISABLED = 2;

		[Token(Token = "0x4000412")]
		public const string StoredLanguageNameKey = "~MA_Language_Key~";

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly YieldInstruction EndOfFrameDelay;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly List<string> ExemptChildNames;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly HashSet<int> ErrorNumbersLogged;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static List<string> ImportanceChoices;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Action NumberOfAudioSourcesChanged;

		[Token(Token = "0x4000418")]
		public const int HardCodedBusOptions = 2;

		[Token(Token = "0x4000419")]
		public const string AllBusesName = "[All]";

		[Token(Token = "0x400041A")]
		public const string NoGroupName = "[None]";

		[Token(Token = "0x400041B")]
		public const string DynamicGroupName = "[Type In]";

		[Token(Token = "0x400041C")]
		public const string NoPlaylistName = "[No Playlist]";

		[Token(Token = "0x400041D")]
		public const string NoVoiceLimitName = "[NO LMT]";

		[Token(Token = "0x400041E")]
		public const string OnlyPlaylistControllerName = "~only~";

		[Token(Token = "0x400041F")]
		public const float InnerLoopCheckInterval = 0.1f;

		[Token(Token = "0x4000420")]
		private const int MaxComponents = 20;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioLocation bulkLocationMode;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string groupTemplateName;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string audioSourceTemplateName;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool showGroupCreation;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool useGroupTemplates;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public DragGroupMode curDragGroupMode;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<GameObject> groupTemplates;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<GameObject> audioSourceTemplates;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool mixerMuted;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool playlistsMuted;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public LanguageMode langMode;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SystemLanguage testLanguage;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public SystemLanguage defaultLanguage;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<SystemLanguage> supportedLanguages;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string busFilter;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useTextGroupFilter;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string textGroupFilter;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool resourceClipsPauseDoNotUnload;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform playlistControllerPrefab;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool persistBetweenScenes;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public bool shouldLogDestroys;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
		public bool showBusColors;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8B")]
		public bool showGroupImportance;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public bool areGroupsExpanded;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform soundGroupTemplate;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Transform soundGroupVariationTemplate;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public List<GroupBus> groupBuses;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool groupByBus;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		public bool sortAlpha;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAA")]
		public bool showRangeSoundGizmos;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAB")]
		public bool showSelectedRangeSoundGizmos;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public Color rangeGizmoColor;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public Color selectedRangeGizmoColor;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public bool showAdvancedSettings;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		public bool showLocalization;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCE")]
		public bool showVideoPlayerSettings;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public List<VideoPlayer> videoPlayers;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public bool playListExpanded;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		public bool playlistsExpanded;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public AllMusicSpatialBlendType musicSpatialBlendType;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float musicSpatialBlend;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public AllMixerSpatialBlendType mixerSpatialBlendType;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public float mixerSpatialBlend;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public GroupPlayType groupPlayType;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public DefaultGroupPlayType defaultGroupPlayType;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public ItemSpatialBlendType newGroupSpatialType;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public float newGroupSpatialBlend;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public List<Playlist> musicPlaylists;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public float _masterAudioVolume;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public bool vrSettingsExpanded;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10D")]
		public bool useSpatializer;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10E")]
		public bool useSpatializerPostFX;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10F")]
		public bool addOculusAudioSources;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public bool addResonanceAudioSources;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x111")]
		public bool ignoreTimeScale;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x112")]
		public bool useGaplessPlaylists;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x113")]
		public bool useGaplessAutoReschedule;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public bool saveRuntimeChanges;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x115")]
		public bool prioritizeOnDistance;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public int rePrioritizeEverySecIndex;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public bool useOcclusion;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public float occlusionFreqChangeSeconds;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public OcclusionSelectionType occlusionSelectType;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public int occlusionMaxRayCastsPerFrame;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public bool occlusionUseLayerMask;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		public LayerMask occlusionLayerMask;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public bool occlusionShowRaycasts;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x141")]
		public bool occlusionShowCategories;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public RaycastMode occlusionRaycastMode;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public bool occlusionIncludeStartRaycast2DCollider;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x149")]
		public bool occlusionRaycastsHitTriggers;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14A")]
		public bool ambientAdvancedExpanded;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public int ambientMaxRecalcsPerFrame;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public bool visualAdvancedExpanded;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x151")]
		public bool logAdvancedExpanded;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x152")]
		public bool listenerAdvancedExpanded;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x153")]
		public bool listenerFollowerHasRigidBody;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		public VariationFollowerType variationFollowerType;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public bool showFadingSettings;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x159")]
		public bool stopZeroVolumeGroups;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15A")]
		public bool stopZeroVolumeBuses;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15B")]
		public bool stopZeroVolumePlaylists;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		public float stopOldestBusFadeTime;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public bool resourceAdvancedExpanded;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x161")]
		public bool useClipAgePriority;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x162")]
		public bool logOutOfVoices;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x163")]
		public bool LogSounds;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		public bool logCustomEvents;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x165")]
		public bool disableLogging;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x166")]
		public bool showMusicDucking;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x167")]
		public bool enableMusicDucking;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public List<DuckGroupInfo> musicDuckingSounds;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public float defaultRiseVolStart;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		public float defaultUnduckTime;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public float defaultDuckedVolumeCut;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		public float crossFadeTime;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public float _masterPlaylistVolume;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		public bool showGroupSelect;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x185")]
		public bool hideGroupsWithNoActiveVars;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x186")]
		public bool logPerfExpanded;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x187")]
		public bool willWarm;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public string newEventName;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public bool showCustomEvents;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public List<CustomEvent> customEvents;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public Dictionary<string, DuckGroupInfo> duckingBySoundType;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public int frames;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		public bool showUnityMixerGroupAssignment;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly PlaySoundResult AndForgetSuccessResult;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly PlaySoundResult failedResultDuringInit;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private readonly Dictionary<string, AudioGroupInfo> AudioSourcesBySoundType;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Dictionary<string, List<int>> _randomizer;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private Dictionary<string, List<int>> _randomizerOrigin;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private Dictionary<string, List<int>> _randomizerLeftovers;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private Dictionary<string, List<int>> _clipsPlayedBySoundTypeOldestFirst;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private readonly List<SoundGroupVariationUpdater> ActiveVariationUpdaters;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private readonly List<SoundGroupVariationUpdater> ActiveUpdatersToRemove;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private readonly List<CustomEventCandidate> ValidReceivers;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private readonly List<MasterAudioGroup> SoloedGroups;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private readonly List<AmbientSoundToTriggerInfo> AmbientsToDelayedTrigger;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private readonly Queue<CustomEventToFireInfo> CustomEventsToFire;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private readonly Queue<TransformFollower> TransFollowerColliderPositionRecalcs;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private readonly List<TransformFollower> ProcessedColliderPositionRecalcs;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private readonly List<BusFadeInfo> BusFades;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private readonly List<GroupFadeInfo> GroupFades;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private readonly List<GroupPitchGlideInfo> GroupPitchGlides;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private readonly List<BusPitchGlideInfo> BusPitchGlides;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private readonly List<OcclusionFreqChangeInfo> VariationOcclusionFreqChanges;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private readonly List<AudioSource> AllAudioSources;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private readonly Dictionary<string, Dictionary<ICustomEventReceiver, Transform>> ReceiversByEventName;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private readonly Dictionary<string, PlaylistController> PlaylistControllersByName;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private readonly Dictionary<string, SoundGroupRefillInfo> LastTimeSoundGroupPlayed;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private readonly List<GameObject> OcclusionSourcesInRange;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private readonly List<GameObject> OcclusionSourcesOutOfRange;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private readonly List<GameObject> OcclusionSourcesBlocked;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private readonly Queue<SoundGroupVariationUpdater> QueuedOcclusionRays;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private readonly List<VideoPlayerTracker> VideoPlayerTrackers;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private readonly List<SoundGroupVariation> VariationsStartedDuringMultiStop;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private bool _isStoppingMultiple;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2AC")]
		private float _repriTime;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private List<string> _groupsToRemove;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private bool _mustRescanGroups;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private Transform _trans;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private bool _soundsLoaded;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C9")]
		private bool _warming;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static MasterAudio _instance;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static string _prospectiveMAFolder;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static Transform _listenerTrans;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static readonly List<SoundGroupCommand> GroupCommandsWithNoGroupSelector;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static readonly List<SoundGroupCommand> GroupCommandsWithNoAllGroupSelector;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8256D0", Offset = "0x8256D0")]
		private static bool <AppIsShuttingDown>k__BackingField;

		[Token(Token = "0x17000064")]
		public static float PlaylistMasterVolume
		{
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x15C96D0", Offset = "0x15C96D0", VA = "0x15C96D0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x15AFEE0", Offset = "0x15AFEE0", VA = "0x15AFEE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public static bool LogSoundsEnabled
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x15CA370", Offset = "0x15CA370", VA = "0x15CA370")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x15CA3D8", Offset = "0x15CA3D8", VA = "0x15CA3D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public static bool LogOutOfVoices
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x15BDC88", Offset = "0x15BDC88", VA = "0x15BDC88")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x15CA448", Offset = "0x15CA448", VA = "0x15CA448")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public static Transform VideoPlayerSoundGroupTransform
		{
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x15B9370", Offset = "0x15B9370", VA = "0x15B9370")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		public static List<AudioSource> MasterAudioSources
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x15CB588", Offset = "0x15CB588", VA = "0x15CB588")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		public static Transform ListenerTrans
		{
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x1596678", Offset = "0x1596678", VA = "0x1596678")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		public static PlaylistController OnlyPlaylistController
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x15CB6E8", Offset = "0x15CB6E8", VA = "0x15CB6E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		public static bool IsWarming
		{
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x15A540C", Offset = "0x15A540C", VA = "0x15A540C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006C")]
		public static bool MixerMuted
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x15CB7A0", Offset = "0x15CB7A0", VA = "0x15CB7A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x15C6F7C", Offset = "0x15C6F7C", VA = "0x15C6F7C")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public static bool PlaylistsMuted
		{
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x15CB808", Offset = "0x15CB808", VA = "0x15CB808")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x15C8238", Offset = "0x15C8238", VA = "0x15C8238")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public bool EnableMusicDucking
		{
			[Token(Token = "0x6000393")]
			[Address(RVA = "0x15CB870", Offset = "0x15CB870", VA = "0x15CB870")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x15CB878", Offset = "0x15CB878", VA = "0x15CB878")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public float MasterCrossFadeTime
		{
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x15CB884", Offset = "0x15CB884", VA = "0x15CB884")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000070")]
		public static List<Playlist> MusicPlaylists
		{
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x15C7E64", Offset = "0x15C7E64", VA = "0x15C7E64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		public static List<GroupBus> GroupBuses
		{
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x15C466C", Offset = "0x15C466C", VA = "0x15C466C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		public static List<string> RuntimeSoundGroupNames
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x15AA32C", Offset = "0x15AA32C", VA = "0x15AA32C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		public static List<string> RuntimeBusNames
		{
			[Token(Token = "0x6000399")]
			[Address(RVA = "0x15ACF14", Offset = "0x15ACF14", VA = "0x15ACF14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		public static MasterAudio SafeInstance
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0x159385C", Offset = "0x159385C", VA = "0x159385C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		public static MasterAudio Instance
		{
			[Token(Token = "0x600039B")]
			[Address(RVA = "0x15947DC", Offset = "0x15947DC", VA = "0x15947DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x15CB88C", Offset = "0x15CB88C", VA = "0x15CB88C")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public static bool SoundsReady
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x159ECC8", Offset = "0x159ECC8", VA = "0x159ECC8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000077")]
		public static bool AppIsShuttingDown
		{
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x15CB8F4", Offset = "0x15CB8F4", VA = "0x15CB8F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x825CA4", Offset = "0x825CA4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x15CB958", Offset = "0x15CB958", VA = "0x15CB958")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x825CB4", Offset = "0x825CB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public List<string> GroupNames
		{
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x15CB9C4", Offset = "0x15CB9C4", VA = "0x15CB9C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		public static List<string> SoundGroupHardCodedNames
		{
			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x1595F84", Offset = "0x1595F84", VA = "0x1595F84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		public List<string> BusNames
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x15CBD80", Offset = "0x15CBD80", VA = "0x15CBD80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007B")]
		public List<string> PlaylistNames
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x15CBED0", Offset = "0x15CBED0", VA = "0x15CBED0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		public List<string> PlaylistNamesOnly
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x15CC020", Offset = "0x15CC020", VA = "0x15CC020")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		public Transform Trans
		{
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x1596E0C", Offset = "0x1596E0C", VA = "0x1596E0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x15CC138", Offset = "0x15CC138", VA = "0x15CC138")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007F")]
		public List<string> CustomEventNames
		{
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x15CC140", Offset = "0x15CC140", VA = "0x15CC140")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		public List<string> CustomEventNamesOnly
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x15CC310", Offset = "0x15CC310", VA = "0x15CC310")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		public static List<string> CustomEventHardCodedNames
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x15CC240", Offset = "0x15CC240", VA = "0x15CC240")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		public static float MasterVolumeLevel
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x15CC458", Offset = "0x15CC458", VA = "0x15CC458")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x15AFD6C", Offset = "0x15AFD6C", VA = "0x15AFD6C")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		private static bool SceneHasMasterAudio
		{
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x15BC0F0", Offset = "0x15BC0F0", VA = "0x15BC0F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000084")]
		public static bool IgnoreTimeScale
		{
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x15CC4C0", Offset = "0x15CC4C0", VA = "0x15CC4C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000085")]
		public static SystemLanguage DynamicLanguage
		{
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x1598BD0", Offset = "0x1598BD0", VA = "0x1598BD0")]
			get
			{
				return default(SystemLanguage);
			}
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x15CC528", Offset = "0x15CC528", VA = "0x15CC528")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public static float ReprioritizeTime
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x15CC600", Offset = "0x15CC600", VA = "0x15CC600")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000087")]
		public static bool ShouldRescanGroups
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x15CC744", Offset = "0x15CC744", VA = "0x15CC744")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000088")]
		public static string ProspectiveMAPath
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x15CC820", Offset = "0x15CC820", VA = "0x15CC820")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x15CC884", Offset = "0x15CC884", VA = "0x15CC884")]
			set
			{
			}
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x15B7038", Offset = "0x15B7038", VA = "0x15B7038")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x825B70", Offset = "0x825B70")]
		private static void Init()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x15B70D4", Offset = "0x15B70D4", VA = "0x15B70D4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x15B95C0", Offset = "0x15B95C0", VA = "0x15B95C0")]
		private void Start()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x15B9768", Offset = "0x15B9768", VA = "0x15B9768")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x15B9A54", Offset = "0x15B9A54", VA = "0x15B9A54")]
		private void Update()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x15BB2F4", Offset = "0x15BB2F4", VA = "0x15BB2F4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x15BB398", Offset = "0x15BB398", VA = "0x15BB398")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x15BB304", Offset = "0x15BB304", VA = "0x15BB304")]
		private void ManualUpdate()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x15B93FC", Offset = "0x15B93FC", VA = "0x15B93FC")]
		public string SoundGroupForWarming()
		{
			return null;
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x15BB8D0", Offset = "0x15BB8D0", VA = "0x15BB8D0")]
		public static void RegisterUpdaterForUpdates(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x15BB9B4", Offset = "0x15BB9B4", VA = "0x15BB9B4")]
		public static void UnregisterUpdaterForUpdates(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x15BB710", Offset = "0x15BB710", VA = "0x15BB710")]
		private void UpdateActiveVariations()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x15BBA40", Offset = "0x15BBA40", VA = "0x15BBA40")]
		private static void UpdateRefillTime(string sType, float inactivePeriodSeconds)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x15BB3AC", Offset = "0x15BB3AC", VA = "0x15BB3AC")]
		private static void RecalcClosestColliderPositions()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x15BB168", Offset = "0x15BB168", VA = "0x15BB168")]
		private static void TrackVideoPlayers()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x15BB088", Offset = "0x15BB088", VA = "0x15BB088")]
		private static void FireCustomEventsWaiting()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x15BAD58", Offset = "0x15BAD58", VA = "0x15BAD58")]
		private static void RefillInactiveGroupPools()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x15B9AEC", Offset = "0x15B9AEC", VA = "0x15B9AEC")]
		private static void PerformOcclusionFrequencyChanges()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x15B9E50", Offset = "0x15B9E50", VA = "0x15B9E50")]
		private void PerformBusFades()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x15BA3C4", Offset = "0x15BA3C4", VA = "0x15BA3C4")]
		private void PerformGroupFades()
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x15BA99C", Offset = "0x15BA99C", VA = "0x15BA99C")]
		public static void PerformDelayedAmbientTriggers()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x15BA788", Offset = "0x15BA788", VA = "0x15BA788")]
		private void PerformGroupPitchGlides()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x15BA1B4", Offset = "0x15BA1B4", VA = "0x15BA1B4")]
		private void PerformBusPitchGlides()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x15BC050", Offset = "0x15BC050", VA = "0x15BC050")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x159CFC4", Offset = "0x159CFC4", VA = "0x159CFC4")]
		public static bool PlaySoundAndForget(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x15A7D20", Offset = "0x15A7D20", VA = "0x15A7D20")]
		public static PlaySoundResult PlaySound(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x15BCD88", Offset = "0x15BCD88", VA = "0x15BCD88")]
		public static bool PlaySound3DAtVector3AndForget(string sType, Vector3 sourcePosition, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x15BCF4C", Offset = "0x15BCF4C", VA = "0x15BCF4C")]
		public static PlaySoundResult PlaySound3DAtVector3(string sType, Vector3 sourcePosition, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return null;
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x159A014", Offset = "0x159A014", VA = "0x159A014")]
		public static bool PlaySound3DAtTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x159A2A8", Offset = "0x159A2A8", VA = "0x159A2A8")]
		public static PlaySoundResult PlaySound3DAtTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x159A568", Offset = "0x159A568", VA = "0x159A568")]
		public static bool PlaySound3DFollowTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x159A7FC", Offset = "0x159A7FC", VA = "0x159A7FC")]
		public static PlaySoundResult PlaySound3DFollowTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x15BD138", Offset = "0x15BD138", VA = "0x15BD138")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x825B84", Offset = "0x825B84")]
		public static IEnumerator PlaySoundAndWaitUntilFinished(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x159AAD4", Offset = "0x159AAD4", VA = "0x159AAD4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x825BE4", Offset = "0x825BE4")]
		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x159AC8C", Offset = "0x159AC8C", VA = "0x159AC8C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x825C44", Offset = "0x825C44")]
		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x15BCD64", Offset = "0x15BCD64", VA = "0x15BCD64")]
		public static bool PSRAsSuccessBool(PlaySoundResult psr)
		{
			return default(bool);
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x15BC18C", Offset = "0x15BC18C", VA = "0x15BC18C")]
		private static PlaySoundResult PlaySoundAtVolume(string sType, float volumePercentage, Vector3 sourcePosition, double? timeToSchedulePlay, [Optional] float? pitch, [Optional] Transform sourceTrans, [Optional] string variationName, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, bool isChaining = false, bool isSingleSubscribedPlay = false, bool triggeredAsChildGroup = false)
		{
			return null;
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x15BF658", Offset = "0x15BF658", VA = "0x15BF658")]
		private static PlaySoundResult TryPlayVariationOrOtherMatches(string sType, float volumePercentage, Vector3 sourcePosition, double? timeToSchedulePlay, float? pitch, Transform sourceTrans, bool attachToSource, float delaySoundTime, bool useVector3, bool makePlaySoundResult, bool isChaining, bool isSingleSubscribedPlay, AudioInfo randomSource, SoundGroupVariation busVoiceToStop, GroupBus groupBus, bool canUseBusVoiceToStop, bool forgetSoundPlayedOrScheduled, AudioGroupInfo group, bool isNonSpecific, int? randomIndex, List<int> choices, int pickedChoice, bool loggingEnabledForGrp, bool isSingleVarLoop, List<int> otherChoices, bool hasRefilledPool, List<AudioInfo> sources, out bool soundSuccess)
		{
			return null;
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x15BF220", Offset = "0x15BF220", VA = "0x15BF220")]
		private static bool CanPlayDialogBasedOnImportanceOrIsNotDialog(string sType, AudioGroupInfo group, bool loggingEnabledForGrp, AudioInfo randomSource)
		{
			return default(bool);
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x15BE350", Offset = "0x15BE350", VA = "0x15BE350")]
		private static AudioInfo UseOnlyVariationIfOnlyOne(string sType, List<AudioInfo> sources, bool loggingEnabledForGrp, AudioInfo randomSource, MasterAudioGroup maGroup, ref bool isSingleVarLoop)
		{
			return null;
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x15BEF50", Offset = "0x15BEF50", VA = "0x15BEF50")]
		private static bool IsActorTooFarAwayToPlay(string sType, Transform sourceTrans, AudioGroupInfo group, AudioInfo randomSource, bool loggingEnabledForGrp)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x15BEDD0", Offset = "0x15BEDD0", VA = "0x15BEDD0")]
		private static bool VariationPassesProbabilityToPlayCheck(string sType, float volumePercentage, float? pitch, Transform sourceTrans, bool attachToSource, bool isChaining, AudioInfo randomSource, bool loggingEnabledForGrp, AudioGroupInfo group, bool isNonSpecific, int? randomIndex, List<int> choices, int pickedChoice)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x15BEBD8", Offset = "0x15BEBD8", VA = "0x15BEBD8")]
		private static bool IsNoClipSilentPlay(string sType, float volumePercentage, float? pitch, Transform sourceTrans, bool attachToSource, bool isChaining, AudioInfo randomSource, bool loggingEnabledForGrp, AudioGroupInfo group, bool isNonSpecific, int? randomIndex, List<int> choices, int pickedChoice)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x15BEA2C", Offset = "0x15BEA2C", VA = "0x15BEA2C")]
		private static bool VariationIsUsable(AudioInfo randomSource)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x15BE478", Offset = "0x15BE478", VA = "0x15BE478")]
		private static bool CanFindVariationToPlay(string sType, string variationName, bool isNonSpecific, bool canUseBusVoiceToStop, List<AudioInfo> sources, bool loggingEnabledForGrp, SoundGroupVariation busVoiceToStop, ref AudioInfo randomSource, ref List<int> choices, ref int? randomIndex, ref int pickedChoice, ref List<int> otherChoices)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x15BDF48", Offset = "0x15BDF48", VA = "0x15BDF48")]
		private static SoundGroupVariation FindBusVoiceToStop(GroupBus groupBus, MasterAudioGroup group)
		{
			return null;
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x15BDE30", Offset = "0x15BDE30", VA = "0x15BDE30")]
		private static bool CanStopLimitedBusVoice(GroupBus groupBus, bool loggingEnabledForGrp, AudioGroupInfo group)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x15BDE08", Offset = "0x15BDE08", VA = "0x15BDE08")]
		private static bool IsBusVoiceLimited(GroupBus groupBus)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x15BDA80", Offset = "0x15BDA80", VA = "0x15BDA80")]
		private static AudioInfo FindRetriggerableVariationInGroup(string variationName, bool isNonSpecific, List<AudioInfo> sources, MasterAudioGroup maGroup)
		{
			return null;
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x15BDA1C", Offset = "0x15BDA1C", VA = "0x15BDA1C")]
		private static bool IsGroupPolyphonyLimited(MasterAudioGroup maGroup, AudioGroupInfo group)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x15BD8A0", Offset = "0x15BD8A0", VA = "0x15BD8A0")]
		private static bool IsReplayLimited(string sType, MasterAudioGroup maGroup, AudioGroupInfo group, bool loggingEnabledForGrp)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x15BD688", Offset = "0x15BD688", VA = "0x15BD688")]
		private static void LogIfSilentPlay(string sType, bool loggingEnabledForGrp, MasterAudioGroup maGroup)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x15BD5A4", Offset = "0x15BD5A4", VA = "0x15BD5A4")]
		private static bool SoundGroupHasVariations(string sType, List<AudioInfo> sources, bool loggingEnabledForGrp)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x15BD208", Offset = "0x15BD208", VA = "0x15BD208")]
		private static bool IsSoundGroupValidAndReady(string sType, Transform sourceTrans)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x15C05E4", Offset = "0x15C05E4", VA = "0x15C05E4")]
		private static void MaybeChainNextVar(bool isChaining, SoundGroupVariation variation, float volumePercentage, float? pitch, Transform sourceTrans, bool attachToSource)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x15BFC3C", Offset = "0x15BFC3C", VA = "0x15BFC3C")]
		private static void SetLastPlayed(AudioGroupInfo grp)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x15C038C", Offset = "0x15C038C", VA = "0x15C038C")]
		private static void RemoveClipAndRefillIfEmpty(AudioGroupInfo grp, bool isNonSpecific, int? randomIndex, List<int> choices, string sType, int pickedChoice, bool loggingEnabledForGrp, bool isSingleVarLoop)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x15BFC78", Offset = "0x15BFC78", VA = "0x15BFC78")]
		private static PlaySoundResult PlaySoundIfAvailable(AudioInfo info, Vector3 sourcePosition, float volumePercentage, SoundGroupVariation busVoiceToStop, GroupBus groupBus, bool canUseBusVoiceToStop, ref bool forgetSoundPlayed, [Optional] float? pitch, [Optional] AudioGroupInfo audioGroup, [Optional] Transform sourceTrans, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x15C0F78", Offset = "0x15C0F78", VA = "0x15C0F78")]
		private static void FadeOldestOrFarthestBusVoice(SoundGroupVariation busVoiceToStop, GroupBus groupBus)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x15C1064", Offset = "0x15C1064", VA = "0x15C1064")]
		public static void EndDucking(SoundGroupVariationUpdater actorUpdater)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x15C1114", Offset = "0x15C1114", VA = "0x15C1114")]
		public static void DuckSoundGroup(string soundGroupName, AudioSource aSource, SoundGroupVariationUpdater actorUpdater)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x15C130C", Offset = "0x15C130C", VA = "0x15C130C")]
		private static void StopPauseOrUnpauseSoundsOfTransform(Transform trans, List<AudioInfo> varList, VariationCommand varCmd)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x159B544", Offset = "0x159B544", VA = "0x159B544")]
		public static void StopAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x15940A4", Offset = "0x15940A4", VA = "0x15940A4")]
		public static void StopSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x159ADE4", Offset = "0x159ADE4", VA = "0x159ADE4")]
		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x159B2F4", Offset = "0x159B2F4", VA = "0x159B2F4")]
		public static void PauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x159BB74", Offset = "0x159BB74", VA = "0x159BB74")]
		public static void UnpauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x159C084", Offset = "0x159C084", VA = "0x159C084")]
		public static void UnpauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x15ABCAC", Offset = "0x15ABCAC", VA = "0x15ABCAC")]
		public static void FadeOutAllSoundsOfTransform(Transform sourceTrans, float fadeTime)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1594294", Offset = "0x1594294", VA = "0x1594294")]
		public static void FadeOutSoundGroupOfTransform(Transform sourceTrans, string sType, float fadeTime)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x15AB514", Offset = "0x15AB514", VA = "0x15AB514")]
		public static void StopAllOfSound(string sType)
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x15AA57C", Offset = "0x15AA57C", VA = "0x15AA57C")]
		public static void FadeOutAllOfSound(string sType, float fadeTime)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x15C15C8", Offset = "0x15C15C8", VA = "0x15C15C8")]
		public static List<SoundGroupVariation> GetAllPlayingVariations()
		{
			return null;
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1599C04", Offset = "0x1599C04", VA = "0x1599C04")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(Transform sourceTrans)
		{
			return null;
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x15C18C0", Offset = "0x15C18C0", VA = "0x15C18C0")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransformList(List<Transform> sourceTransList)
		{
			return null;
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x15C1CA0", Offset = "0x15C1CA0", VA = "0x15C1CA0")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsInBus(string busName)
		{
			return null;
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x15C1ED8", Offset = "0x15C1ED8", VA = "0x15C1ED8")]
		public static void DeleteGroupVariation(string sType, string variationName)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x15C2D5C", Offset = "0x15C2D5C", VA = "0x15C2D5C")]
		public static void CreateGroupVariationFromClip(string sType, AudioClip clip, string variationName, float volume = 1f, float pitch = 1f)
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x15C3424", Offset = "0x15C3424", VA = "0x15C3424")]
		public static void ChangeVariationPitch(string sType, bool changeAllVariations, string variationName, float pitch)
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x15C37E8", Offset = "0x15C37E8", VA = "0x15C37E8")]
		public static void ChangeVariationVolume(string sType, bool changeAllVariations, string variationName, float volume)
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x15C3B38", Offset = "0x15C3B38", VA = "0x15C3B38")]
		public static void ChangeVariationClipFromResources(string sType, bool changeAllVariations, string variationName, string resourceFileName)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x15C3D2C", Offset = "0x15C3D2C", VA = "0x15C3D2C")]
		public static void ChangeVariationClip(string sType, bool changeAllVariations, string variationName, AudioClip clip)
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x15C4000", Offset = "0x15C4000", VA = "0x15C4000")]
		public static void GradualOcclusionFreqChange(SoundGroupVariation variation, float fadeTime, float newCutoffFreq)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x15C4314", Offset = "0x15C4314", VA = "0x15C4314")]
		public static AudioSource GetNextVariationForSoundGroup(string sType)
		{
			return null;
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x15AA440", Offset = "0x15AA440", VA = "0x15AA440")]
		public static bool IsSoundGroupPlaying(string sType)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x159C2E4", Offset = "0x159C2E4", VA = "0x159C2E4")]
		public static bool IsTransformPlayingSoundGroup(string sType, Transform sourceTrans)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x15ABEC8", Offset = "0x15ABEC8", VA = "0x15ABEC8")]
		public static void RouteGroupToBus(string sType, string busName)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x15C4974", Offset = "0x15C4974", VA = "0x15C4974")]
		public static float GetVariationLength(string sType, string variationName)
		{
			return default(float);
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x15AA804", Offset = "0x15AA804", VA = "0x15AA804")]
		public static void RefillSoundGroupPool(string sType)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x15C516C", Offset = "0x15C516C", VA = "0x15C516C")]
		public static bool SoundGroupExists(string sType)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x15AB218", Offset = "0x15AB218", VA = "0x15AB218")]
		public static void PauseSoundGroup(string sType)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x15C5214", Offset = "0x15C5214", VA = "0x15C5214")]
		public static void SetGroupSpatialBlend(string sType)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x15C538C", Offset = "0x15C538C", VA = "0x15C538C")]
		public static void RouteGroupToUnityMixerGroup(string sType, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x15AB9C4", Offset = "0x15AB9C4", VA = "0x15AB9C4")]
		public static void UnpauseSoundGroup(string sType)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x15AACA4", Offset = "0x15AACA4", VA = "0x15AACA4")]
		public static void FadeSoundGroupToVolume(string sType, float newVolume, float fadeTime, [Optional] Action completionCallback, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x15ACD34", Offset = "0x15ACD34", VA = "0x15ACD34")]
		public static void FadeOutOldSoundGroupVoices(string sType, float minimumPlayTime, float fadeTime)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x15ACB74", Offset = "0x15ACB74", VA = "0x15ACB74")]
		public static void StopOldSoundGroupVoices(string sType, float minimumPlayTime)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x15AC5B8", Offset = "0x15AC5B8", VA = "0x15AC5B8")]
		public static void GlideSoundGroupByPitch(string sType, float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x159FB7C", Offset = "0x159FB7C", VA = "0x159FB7C")]
		public static void DeleteSoundGroup(string sType)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x15A0A8C", Offset = "0x15A0A8C", VA = "0x15A0A8C")]
		public static Transform CreateSoundGroup(DynamicSoundGroup aGroup, string creatorObjectName, bool errorOnExisting = true)
		{
			return null;
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x15C57A0", Offset = "0x15C57A0", VA = "0x15C57A0")]
		public static float GetGroupVolume(string sType)
		{
			return default(float);
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x15BBBE0", Offset = "0x15BBBE0", VA = "0x15BBBE0")]
		public static void SetGroupVolume(string sType, float volumeLevel)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x15AB0CC", Offset = "0x15AB0CC", VA = "0x15AB0CC")]
		public static void MuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x15AB8B4", Offset = "0x15AB8B4", VA = "0x15AB8B4")]
		public static void UnmuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x15B90AC", Offset = "0x15B90AC", VA = "0x15B90AC")]
		private static void AddRuntimeGroupInfo(string groupName, AudioGroupInfo groupInfo)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x15C5B0C", Offset = "0x15C5B0C", VA = "0x15C5B0C")]
		private static void FireAudioSourcesNumberChangedEvent()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x15C5984", Offset = "0x15C5984", VA = "0x15C5984")]
		public static void TrackRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x15B980C", Offset = "0x15B980C", VA = "0x15B980C")]
		public static void StopTrackingRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x15C5524", Offset = "0x15C5524", VA = "0x15C5524")]
		private static void RemoveRuntimeGroupInfo(string groupName)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x15C5BB0", Offset = "0x15C5BB0", VA = "0x15C5BB0")]
		private static void RescanChildren(MasterAudioGroup group)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x15C5860", Offset = "0x15C5860", VA = "0x15C5860")]
		private static void SetGroupMuteStatus(MasterAudioGroup aGroup, string sType, bool isMute)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x15AB3C4", Offset = "0x15AB3C4", VA = "0x15AB3C4")]
		public static void SoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x15A034C", Offset = "0x15A034C", VA = "0x15A034C")]
		public static void SilenceOrUnsilenceGroupsFromSoloChange()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x15C5F4C", Offset = "0x15C5F4C", VA = "0x15C5F4C")]
		private static void UnsilenceNonSoloedGroups()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x15C60FC", Offset = "0x15C60FC", VA = "0x15C60FC")]
		private static void UnsilenceGroup(string sType)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x15C5D94", Offset = "0x15C5D94", VA = "0x15C5D94")]
		private static void SilenceNonSoloedGroups()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x15C6258", Offset = "0x15C6258", VA = "0x15C6258")]
		private static void SilenceGroup(string sType)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x15ABB70", Offset = "0x15ABB70", VA = "0x15ABB70")]
		public static void UnsoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x1593D58", Offset = "0x1593D58", VA = "0x1593D58")]
		public static MasterAudioGroup GrabGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x15C63B4", Offset = "0x15C63B4", VA = "0x15C63B4")]
		public static int VoicesForGroup(string sType)
		{
			return default(int);
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x15C64B4", Offset = "0x15C64B4", VA = "0x15C64B4")]
		public static Transform FindGroupTransform(string sType)
		{
			return null;
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x15C66D4", Offset = "0x15C66D4", VA = "0x15C66D4")]
		public static List<AudioInfo> GetAllVariationsOfGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x15C684C", Offset = "0x15C684C", VA = "0x15C684C")]
		public static AudioGroupInfo GetGroupInfo(string sType)
		{
			return null;
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x15C6930", Offset = "0x15C6930", VA = "0x15C6930")]
		public static void SubscribeToLastVariationPlayed(string sType, Action finishedCallback)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x15C6AB4", Offset = "0x15C6AB4", VA = "0x15C6AB4")]
		public static void UnsubscribeFromLastVariationPlayed(string sType)
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x15C6BAC", Offset = "0x15C6BAC", VA = "0x15C6BAC")]
		public void SetSpatialBlendForMixer()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x15AFFC4", Offset = "0x15AFFC4", VA = "0x15AFFC4")]
		public static void PauseMixer()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x15B01BC", Offset = "0x15B01BC", VA = "0x15B01BC")]
		public static void UnpauseMixer()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x15B03B4", Offset = "0x15B03B4", VA = "0x15B03B4")]
		public static void StopMixer()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x15C6D0C", Offset = "0x15C6D0C", VA = "0x15C6D0C")]
		public static void UnsubscribeFromAllVariations()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x15B0784", Offset = "0x15B0784", VA = "0x15B0784")]
		public static void StopEverything()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x15B06CC", Offset = "0x15B06CC", VA = "0x15B06CC")]
		public static void PauseEverything()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x15B0728", Offset = "0x15B0728", VA = "0x15B0728")]
		public static void UnpauseEverything()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x15B060C", Offset = "0x15B060C", VA = "0x15B060C")]
		public static void MuteEverything()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x15B066C", Offset = "0x15B066C", VA = "0x15B066C")]
		public static void UnmuteEverything()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x15C7368", Offset = "0x15C7368", VA = "0x15C7368")]
		public static List<string> ListOfAudioClipsInGroupsEditTime()
		{
			return null;
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x15BBEB4", Offset = "0x15BBEB4", VA = "0x15BBEB4")]
		private static int GetBusIndex(string busName, bool alertMissing)
		{
			return default(int);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x15C46D4", Offset = "0x15C46D4", VA = "0x15C46D4")]
		private static GroupBus GetBusByIndex(int busIndex)
		{
			return null;
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x15AE8E8", Offset = "0x15AE8E8", VA = "0x15AE8E8")]
		public static void ChangeBusPitch(string busName, float pitch)
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x15AE0D4", Offset = "0x15AE0D4", VA = "0x15AE0D4")]
		public static void MuteBus(string busName)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x15AE2C0", Offset = "0x15AE2C0", VA = "0x15AE2C0")]
		public static void UnmuteBus(string busName, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x15AE468", Offset = "0x15AE468", VA = "0x15AE468")]
		public static void ToggleMuteBus(string busName)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x15ADBF4", Offset = "0x15ADBF4", VA = "0x15ADBF4")]
		public static void PauseBus(string busName)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x15AE554", Offset = "0x15AE554", VA = "0x15AE554")]
		public static void SoloBus(string busName)
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x15AE740", Offset = "0x15AE740", VA = "0x15AE740")]
		public static void UnsoloBus(string busName, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x15C7634", Offset = "0x15C7634", VA = "0x15C7634")]
		public static void RouteBusToUnityMixerGroup(string busName, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x15C0BC8", Offset = "0x15C0BC8", VA = "0x15C0BC8")]
		private static SoundGroupVariation FindLeastImportantSoundOnBus(GroupBus bus, MasterAudioGroup group)
		{
			return null;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x15C0898", Offset = "0x15C0898", VA = "0x15C0898")]
		private static SoundGroupVariation FindFarthestSoundOnBus(GroupBus bus)
		{
			return null;
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x15C0618", Offset = "0x15C0618", VA = "0x15C0618")]
		private static SoundGroupVariation FindOldestSoundOnBus(GroupBus bus)
		{
			return null;
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x15ADD7C", Offset = "0x15ADD7C", VA = "0x15ADD7C")]
		public static void StopBus(string busName)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x15ADF6C", Offset = "0x15ADF6C", VA = "0x15ADF6C")]
		public static void UnpauseBus(string busName)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x15A0798", Offset = "0x15A0798", VA = "0x15A0798")]
		public static bool CreateBus(string busName, bool errorOnExisting = true, bool isTemporary = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x159F9C4", Offset = "0x159F9C4", VA = "0x159F9C4")]
		public static void DeleteBusByName(string busName)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x15C77B8", Offset = "0x15C77B8", VA = "0x15C77B8")]
		public static void DeleteBusByIndex(int busIndex)
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x15C0EB8", Offset = "0x15C0EB8", VA = "0x15C0EB8")]
		public static float GetBusVolume(MasterAudioGroup maGroup)
		{
			return default(float);
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x15AD088", Offset = "0x15AD088", VA = "0x15AD088")]
		public static void FadeBusToVolume(string busName, float newVolume, float fadeTime, [Optional] Action completionCallback, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x15AECAC", Offset = "0x15AECAC", VA = "0x15AECAC")]
		public static void FadeOutOldBusVoices(string busName, float minimumPlayTime, float fadeTime)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x15AEA9C", Offset = "0x15AEA9C", VA = "0x15AEA9C")]
		public static void StopOldBusVoices(string busName, float minimumPlayTime)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x15AD4DC", Offset = "0x15AD4DC", VA = "0x15AD4DC")]
		public static void GlideBusByPitch(string busName, float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x15B9244", Offset = "0x15B9244", VA = "0x15B9244")]
		public static void SetBusVolumeByName(string busName, float newVolume)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x15C7AD0", Offset = "0x15C7AD0", VA = "0x15C7AD0")]
		private static void RecalculateGroupVolumes(AudioGroupInfo aGroup, GroupBus bus)
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x15C477C", Offset = "0x15C477C", VA = "0x15C477C")]
		private static void SetBusVolume(GroupBus bus, float newVolume)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x15A0694", Offset = "0x15A0694", VA = "0x15A0694")]
		public static GroupBus GrabBusByName(string busName)
		{
			return null;
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x159B0AC", Offset = "0x159B0AC", VA = "0x159B0AC")]
		public static void PauseBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x159BE3C", Offset = "0x159BE3C", VA = "0x159BE3C")]
		public static void UnpauseBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x159B86C", Offset = "0x159B86C", VA = "0x159B86C")]
		public static void StopBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x15A1C98", Offset = "0x15A1C98", VA = "0x15A1C98")]
		public static void AddSoundGroupToDuckList(string sType, float riseVolumeStart, float duckedVolCut, float unduckTime, bool isTemporary = false)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x159FA60", Offset = "0x159FA60", VA = "0x159FA60")]
		public static void RemoveSoundGroupFromDuckList(string sType)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x15C7CA8", Offset = "0x15C7CA8", VA = "0x15C7CA8")]
		public static Playlist GrabPlaylist(string playlistName, bool logErrorIfNotFound = true)
		{
			return null;
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x15C7ECC", Offset = "0x15C7ECC", VA = "0x15C7ECC")]
		public static void ChangePlaylistPitch(string playlistName, float pitch, [Optional] string songName)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x15C7FFC", Offset = "0x15C7FFC", VA = "0x15C7FFC")]
		public static void MutePlaylist()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x15A8D58", Offset = "0x15A8D58", VA = "0x15A8D58")]
		public static void MutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x15A8CEC", Offset = "0x15A8CEC", VA = "0x15A8CEC")]
		public static void MuteAllPlaylists()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x15C8150", Offset = "0x15C8150", VA = "0x15C8150")]
		private static void MutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x15C832C", Offset = "0x15C832C", VA = "0x15C832C")]
		public static void UnmutePlaylist()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x15A8FB8", Offset = "0x15A8FB8", VA = "0x15A8FB8")]
		public static void UnmutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x15A8F4C", Offset = "0x15A8F4C", VA = "0x15A8F4C")]
		public static void UnmuteAllPlaylists()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x15C839C", Offset = "0x15C839C", VA = "0x15C839C")]
		private static void UnmutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x15C8484", Offset = "0x15C8484", VA = "0x15C8484")]
		public static void ToggleMutePlaylist()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x15A9218", Offset = "0x15A9218", VA = "0x15A9218")]
		public static void ToggleMutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x15A91AC", Offset = "0x15A91AC", VA = "0x15A91AC")]
		public static void ToggleMuteAllPlaylists()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x15C84F4", Offset = "0x15C84F4", VA = "0x15C84F4")]
		private static void ToggleMutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x15C858C", Offset = "0x15C858C", VA = "0x15C858C")]
		public static void PausePlaylist()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x15A9C78", Offset = "0x15A9C78", VA = "0x15A9C78")]
		public static void PausePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x15A9C0C", Offset = "0x15A9C0C", VA = "0x15A9C0C")]
		public static void PauseAllPlaylists()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x15C85FC", Offset = "0x15C85FC", VA = "0x15C85FC")]
		private static void PausePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x15C8694", Offset = "0x15C8694", VA = "0x15C8694")]
		public static void UnpausePlaylist()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x15AA138", Offset = "0x15AA138", VA = "0x15AA138")]
		public static void UnpausePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x15AA0CC", Offset = "0x15AA0CC", VA = "0x15AA0CC")]
		public static void UnpauseAllPlaylists()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x15C8704", Offset = "0x15C8704", VA = "0x15C8704")]
		private static void UnpausePlaylists(List<PlaylistController> controllers)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x15C879C", Offset = "0x15C879C", VA = "0x15C879C")]
		public static void StopPlaylist()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x15A9ED8", Offset = "0x15A9ED8", VA = "0x15A9ED8")]
		public static void StopPlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x15A9E6C", Offset = "0x15A9E6C", VA = "0x15A9E6C")]
		public static void StopAllPlaylists()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x15C880C", Offset = "0x15C880C", VA = "0x15C880C")]
		private static void StopPlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x15C88A8", Offset = "0x15C88A8", VA = "0x15C88A8")]
		public static void TriggerNextPlaylistClip()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x15A9A18", Offset = "0x15A9A18", VA = "0x15A9A18")]
		public static void TriggerNextPlaylistClip(string playlistControllerName)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x15A99AC", Offset = "0x15A99AC", VA = "0x15A99AC")]
		public static void TriggerNextClipAllPlaylists()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x15C8918", Offset = "0x15C8918", VA = "0x15C8918")]
		private static void NextPlaylistClips(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x15C89B0", Offset = "0x15C89B0", VA = "0x15C89B0")]
		public static void TriggerRandomPlaylistClip()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x15A97B8", Offset = "0x15A97B8", VA = "0x15A97B8")]
		public static void TriggerRandomPlaylistClip(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x15A974C", Offset = "0x15A974C", VA = "0x15A974C")]
		public static void TriggerRandomClipAllPlaylists()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x15C8A20", Offset = "0x15C8A20", VA = "0x15C8A20")]
		private static void RandomPlaylistClips(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x15C8AB8", Offset = "0x15C8AB8", VA = "0x15C8AB8")]
		public static void RestartPlaylist()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x15A7F98", Offset = "0x15A7F98", VA = "0x15A7F98")]
		public static void RestartPlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x15A7F2C", Offset = "0x15A7F2C", VA = "0x15A7F2C")]
		public static void RestartAllPlaylists()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x15C8B28", Offset = "0x15C8B28", VA = "0x15C8B28")]
		private static void RestartPlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x15C8BC4", Offset = "0x15C8BC4", VA = "0x15C8BC4")]
		public static void StartPlaylist(string playlistName)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x15C8C40", Offset = "0x15C8C40", VA = "0x15C8C40")]
		public static void StartPlaylistOnClip(string playlistName, string clipName)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x15A819C", Offset = "0x15A819C", VA = "0x15A819C")]
		public static void StartPlaylist(string playlistControllerName, string playlistName, [Optional] string clipName)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x15A8578", Offset = "0x15A8578", VA = "0x15A8578")]
		public static void StopLoopingAllCurrentSongs()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x15C8D60", Offset = "0x15C8D60", VA = "0x15C8D60")]
		public static void StopLoopingCurrentSong()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x15A85E4", Offset = "0x15A85E4", VA = "0x15A85E4")]
		public static void StopLoopingCurrentSong(string playlistControllerName)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x15C8CC8", Offset = "0x15C8CC8", VA = "0x15C8CC8")]
		private static void StopLoopingCurrentSongs(List<PlaylistController> playlistControllers)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x15A87E8", Offset = "0x15A87E8", VA = "0x15A87E8")]
		public static void StopAllPlaylistsAfterCurrentSongs()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x15C8E68", Offset = "0x15C8E68", VA = "0x15C8E68")]
		public static void StopPlaylistAfterCurrentSong()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x15A8854", Offset = "0x15A8854", VA = "0x15A8854")]
		public static void StopPlaylistAfterCurrentSong(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x15C8DD0", Offset = "0x15C8DD0", VA = "0x15C8DD0")]
		private static void StopPlaylistAfterCurrentSongs(List<PlaylistController> playlistControllers)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x15C8ED8", Offset = "0x15C8ED8", VA = "0x15C8ED8")]
		public static void QueuePlaylistClip(string clipName)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x15A95AC", Offset = "0x15A95AC", VA = "0x15A95AC")]
		public static void QueuePlaylistClip(string playlistControllerName, string clipName)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x15C8F50", Offset = "0x15C8F50", VA = "0x15C8F50")]
		public static bool TriggerPlaylistClip(string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x15A940C", Offset = "0x15A940C", VA = "0x15A940C")]
		public static bool TriggerPlaylistClip(string playlistControllerName, string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x15C8FC8", Offset = "0x15C8FC8", VA = "0x15C8FC8")]
		public static void ChangePlaylistByName(string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x15A83D0", Offset = "0x15A83D0", VA = "0x15A83D0")]
		public static void ChangePlaylistByName(string playlistControllerName, string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x15C9050", Offset = "0x15C9050", VA = "0x15C9050")]
		public static void FadePlaylistToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x15A8ADC", Offset = "0x15A8ADC", VA = "0x15A8ADC")]
		public static void FadePlaylistToVolume(string playlistControllerName, float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x15A8A58", Offset = "0x15A8A58", VA = "0x15A8A58")]
		public static void FadeAllPlaylistsToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x15C90D8", Offset = "0x15C90D8", VA = "0x15C90D8")]
		private static void FadePlaylists(List<PlaylistController> playlists, float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x15A243C", Offset = "0x15A243C", VA = "0x15A243C")]
		public static void CreatePlaylist(Playlist playlist, bool errorOnDuplicate)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x15A016C", Offset = "0x15A016C", VA = "0x15A016C")]
		public static void DeletePlaylist(string playlistName)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x15C923C", Offset = "0x15C923C", VA = "0x15C923C")]
		public static void AddSongToPlaylist(string playlistName, AudioClip song, bool loopSong = false, float songPitch = 1f, float songVolume = 1f, [Optional] string alias)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x15C9334", Offset = "0x15C9334", VA = "0x15C9334")]
		public static void AddSongToPlaylist(string playlistName, MusicSetting newSong)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x15C9738", Offset = "0x15C9738", VA = "0x15C9738")]
		public static void AudioListenerChanged(AudioListener listener)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x15A2604", Offset = "0x15A2604", VA = "0x15A2604")]
		public static void FireCustomEventNextFrame(string customEventName, Transform eventOrigin)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x15B0E44", Offset = "0x15B0E44", VA = "0x15B0E44")]
		public static void AddCustomEventReceiver(ICustomEventReceiver receiver, Transform receiverTrans)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x15B12D8", Offset = "0x15B12D8", VA = "0x15B12D8")]
		public static void RemoveCustomEventReceiver(ICustomEventReceiver receiver)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x15C9890", Offset = "0x15C9890", VA = "0x15C9890")]
		public static List<Transform> ReceiversForEvent(string customEventName)
		{
			return null;
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x15A1E18", Offset = "0x15A1E18", VA = "0x15A1E18")]
		public static CustomEventCategory CreateCustomEventCategoryIfNotThere(string categoryName, bool isTemporary)
		{
			return null;
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x15A2078", Offset = "0x15A2078", VA = "0x15A2078")]
		public static void CreateCustomEvent(string customEventName, CustomEventReceiveMode eventReceiveMode, float distanceThreshold, EventReceiveFilter receiveFilter, int filterModeQty, string categoryName = "", bool isTemporary = false, bool errorOnDuplicate = true)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x159FF70", Offset = "0x159FF70", VA = "0x159FF70")]
		public static void DeleteCustomEvent(string customEventName)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x15C9BA8", Offset = "0x15C9BA8", VA = "0x15C9BA8")]
		public static CustomEvent GetCustomEventByName(string customEventName)
		{
			return null;
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x15AEEDC", Offset = "0x15AEEDC", VA = "0x15AEEDC")]
		public static void FireCustomEvent(string customEventName, Transform originObject, bool logDupe = true)
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x15B0AE0", Offset = "0x15B0AE0", VA = "0x15B0AE0")]
		public static bool CustomEventExists(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x15C9D10", Offset = "0x15C9D10", VA = "0x15C9D10")]
		private static List<ICustomEventReceiver> GetChildReceivers(Transform origin, string eventName, bool includeSelf)
		{
			return null;
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x15C9EB0", Offset = "0x15C9EB0", VA = "0x15C9EB0")]
		private static List<ICustomEventReceiver> GetParentReceivers(Transform origin, string eventName, bool includeSelf)
		{
			return null;
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x15CA050", Offset = "0x15CA050", VA = "0x15CA050")]
		private static List<ICustomEventReceiver> FilterOutSelf(List<ICustomEventReceiver> sourceList, Transform origin)
		{
			return null;
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x15BD48C", Offset = "0x15BD48C", VA = "0x15BD48C")]
		private static bool LoggingEnabledForGroup(MasterAudioGroup grp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x15BDCF0", Offset = "0x15BDCF0", VA = "0x15BDCF0")]
		private static void LogMessage(string message)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x1595838", Offset = "0x1595838", VA = "0x1595838")]
		public static void LogWarning(string msg)
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x15955DC", Offset = "0x15955DC", VA = "0x15955DC")]
		public static void LogWarningIfNeverLogged(string msg, int errorNumber)
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x15994DC", Offset = "0x15994DC", VA = "0x15994DC")]
		public static void LogError(string msg)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x15CA4B8", Offset = "0x15CA4B8", VA = "0x15CA4B8")]
		public static void LogNoPlaylist(string playlistControllerName, string methodName)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x15C806C", Offset = "0x15C806C", VA = "0x15C806C")]
		private static bool IsOkToCallOnlyPlaylistMethod(List<PlaylistController> pcs, string methodName)
		{
			return default(bool);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x15933F0", Offset = "0x15933F0", VA = "0x15933F0")]
		public static void SetupAmbientNextFrame(AmbientSound ambient)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1593A18", Offset = "0x1593A18", VA = "0x1593A18")]
		public static void RemoveDelayedAmbient(AmbientSound ambient)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x15CA6D0", Offset = "0x15CA6D0", VA = "0x15CA6D0")]
		public static void QueueTransformFollowerForColliderPositionRecalc(TransformFollower follower)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x15CA92C", Offset = "0x15CA92C", VA = "0x15CA92C")]
		public static void AddToQueuedOcclusionRays(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x15CAB88", Offset = "0x15CAB88", VA = "0x15CAB88")]
		public static void AddToOcclusionInRangeSources(GameObject src)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x15CAD90", Offset = "0x15CAD90", VA = "0x15CAD90")]
		public static void AddToOcclusionOutOfRangeSources(GameObject src)
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x15CB140", Offset = "0x15CB140", VA = "0x15CB140")]
		public static void AddToBlockedOcclusionSources(GameObject src)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x15B5738", Offset = "0x15B5738", VA = "0x15B5738")]
		public static bool HasQueuedOcclusionRays()
		{
			return default(bool);
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x15B57BC", Offset = "0x15B57BC", VA = "0x15B57BC")]
		public static SoundGroupVariationUpdater OldestQueuedOcclusionRay()
		{
			return null;
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x15C41CC", Offset = "0x15C41CC", VA = "0x15C41CC")]
		public static bool IsOcclusionFreqencyTransitioning(SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x15C2BC4", Offset = "0x15C2BC4", VA = "0x15C2BC4")]
		public static void RemoveFromOcclusionFrequencyTransitioning(SoundGroupVariation variation)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x15CAFB8", Offset = "0x15CAFB8", VA = "0x15CAFB8")]
		public static void RemoveFromBlockedOcclusionSources(GameObject src)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x15CB2C8", Offset = "0x15CB2C8", VA = "0x15CB2C8")]
		public static void StopTrackingOcclusionForSource(GameObject src)
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x15CB538", Offset = "0x15CB538", VA = "0x15CB538")]
		public static bool IsVideoPlayersGroup(string groupName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x15C1504", Offset = "0x15C1504", VA = "0x15C1504")]
		private static bool IsLinkedGroupPlay(SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x15CB5F0", Offset = "0x15CB5F0", VA = "0x15CB5F0")]
		public static int RemainingClipsInGroup(string sType)
		{
			return default(int);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x15C5734", Offset = "0x15C5734", VA = "0x15C5734")]
		public static void RescanGroupsNow()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x15CC6DC", Offset = "0x15CC6DC", VA = "0x15CC6DC")]
		public static void DoneRescanningGroups()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x15CC8F0", Offset = "0x15CC8F0", VA = "0x15CC8F0")]
		public static GameObject CreateMasterAudio()
		{
			return null;
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x15CCAAC", Offset = "0x15CCAAC", VA = "0x15CCAAC")]
		public static GameObject CreatePlaylistController()
		{
			return null;
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x15CCC68", Offset = "0x15CCC68", VA = "0x15CCC68")]
		public static GameObject CreateDynamicSoundGroupCreator()
		{
			return null;
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x15CCE24", Offset = "0x15CCE24", VA = "0x15CCE24")]
		public static GameObject CreateSoundGroupOrganizer()
		{
			return null;
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x15CCFE0", Offset = "0x15CCFE0", VA = "0x15CCFE0")]
		public MasterAudio()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public static class PersistentAudioSettings
	{
		[Token(Token = "0x40005DF")]
		public const string SfxVolKey = "MA_sfxVolume";

		[Token(Token = "0x40005E0")]
		public const string MusicVolKey = "MA_musicVolume";

		[Token(Token = "0x40005E1")]
		public const string SfxMuteKey = "MA_sfxMute";

		[Token(Token = "0x40005E2")]
		public const string MusicMuteKey = "MA_musicMute";

		[Token(Token = "0x40005E3")]
		public const string BusVolKey = "MA_BusVolume_";

		[Token(Token = "0x40005E4")]
		public const string GroupVolKey = "MA_GroupVolume_";

		[Token(Token = "0x40005E5")]
		public const string BusKeysKey = "MA_BusKeys";

		[Token(Token = "0x40005E6")]
		public const string GroupKeysKey = "MA_GroupsKeys";

		[Token(Token = "0x40005E7")]
		public const string Separator = ";";

		[Token(Token = "0x1700008F")]
		public static string BusesUpdatedKeys
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0x1C6A9D0", Offset = "0x1C6A9D0", VA = "0x1C6A9D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000408")]
			[Address(RVA = "0x1C6AA4C", Offset = "0x1C6AA4C", VA = "0x1C6AA4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public static string GroupsUpdatedKeys
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0x1C6AB7C", Offset = "0x1C6AB7C", VA = "0x1C6AB7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600040D")]
			[Address(RVA = "0x1C6ABF8", Offset = "0x1C6ABF8", VA = "0x1C6ABF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public static bool? MixerMuted
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x1C6AEA4", Offset = "0x1C6AEA4", VA = "0x1C6AEA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000411")]
			[Address(RVA = "0x1C6AF3C", Offset = "0x1C6AF3C", VA = "0x1C6AF3C")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public static float? MixerVolume
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0x1C6B09C", Offset = "0x1C6B09C", VA = "0x1C6B09C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x1C6B12C", Offset = "0x1C6B12C", VA = "0x1C6B12C")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public static bool? MusicMuted
		{
			[Token(Token = "0x6000414")]
			[Address(RVA = "0x1C6B280", Offset = "0x1C6B280", VA = "0x1C6B280")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000415")]
			[Address(RVA = "0x1C6B318", Offset = "0x1C6B318", VA = "0x1C6B318")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public static float? MusicVolume
		{
			[Token(Token = "0x6000416")]
			[Address(RVA = "0x1C6B478", Offset = "0x1C6B478", VA = "0x1C6B478")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000417")]
			[Address(RVA = "0x1C6B508", Offset = "0x1C6B508", VA = "0x1C6B508")]
			set
			{
			}
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1C6A7E8", Offset = "0x1C6A7E8", VA = "0x1C6A7E8")]
		public static void SetBusVolume(string busName, float vol)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1C6A980", Offset = "0x1C6A980", VA = "0x1C6A980")]
		public static string MakeBusKey(string busName)
		{
			return null;
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1C6AA9C", Offset = "0x1C6AA9C", VA = "0x1C6AA9C")]
		public static float? GetBusVolume(string busName)
		{
			return null;
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x1C6AB2C", Offset = "0x1C6AB2C", VA = "0x1C6AB2C")]
		public static string GetGroupKey(string groupName)
		{
			return null;
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x1C6AC48", Offset = "0x1C6AC48", VA = "0x1C6AC48")]
		public static void SetGroupVolume(string grpName, float vol)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x1C6AE14", Offset = "0x1C6AE14", VA = "0x1C6AE14")]
		public static float? GetGroupVolume(string grpName)
		{
			return null;
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x1C6B65C", Offset = "0x1C6B65C", VA = "0x1C6B65C")]
		public static void RestoreMasterSettings()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class SoundGroupOrganizer : MonoBehaviour
	{
		[Token(Token = "0x20000DB")]
		public class CustomEventSelection
		{
			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CustomEvent Event;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool IsSelected;

			[Token(Token = "0x600041B")]
			[Address(RVA = "0x1D31BD4", Offset = "0x1D31BD4", VA = "0x1D31BD4")]
			public CustomEventSelection(CustomEvent cEvent, bool isSelected)
			{
			}
		}

		[Token(Token = "0x20000DC")]
		public class SoundGroupSelection
		{
			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject Go;

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool IsSelected;

			[Token(Token = "0x600041C")]
			[Address(RVA = "0x1D31C20", Offset = "0x1D31C20", VA = "0x1D31C20")]
			public SoundGroupSelection(GameObject go, bool isSelected)
			{
			}
		}

		[Token(Token = "0x20000DD")]
		public enum MAItemType
		{
			[Token(Token = "0x4000603")]
			SoundGroups,
			[Token(Token = "0x4000604")]
			CustomEvents
		}

		[Token(Token = "0x20000DE")]
		public enum TransferMode
		{
			[Token(Token = "0x4000606")]
			None,
			[Token(Token = "0x4000607")]
			Import,
			[Token(Token = "0x4000608")]
			Export
		}

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject dynGroupTemplate;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject dynVariationTemplate;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject maGroupTemplate;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject maVariationTemplate;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MasterAudio.DragGroupMode curDragGroupMode;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SystemLanguage previewLanguage;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useTextGroupFilter;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string textGroupFilter;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TransferMode transMode;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject sourceObject;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SoundGroupSelection> selectedSourceSoundGroups;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject destObject;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<SoundGroupSelection> selectedDestSoundGroups;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public MAItemType itemType;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<CustomEventSelection> selectedSourceCustomEvents;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<CustomEventSelection> selectedDestCustomEvents;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<CustomEvent> customEvents;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string newEventName;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x1D24820", Offset = "0x1D24820", VA = "0x1D24820")]
		private void Awake()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x1D24894", Offset = "0x1D24894", VA = "0x1D24894")]
		public SoundGroupOrganizer()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public static class AmbientUtil
	{
		[Token(Token = "0x20000E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x822824", Offset = "0x822824")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string variationName;

			[Token(Token = "0x6000429")]
			[Address(RVA = "0x1D2E2C4", Offset = "0x1D2E2C4", VA = "0x1D2E2C4")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x600042A")]
			[Address(RVA = "0x1D2E2CC", Offset = "0x1D2E2CC", VA = "0x1D2E2CC")]
			internal bool <InitAudioSourceFollower>b__0(SoundGroupVariation v)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000609")]
		public const string FollowerHolderName = "_Followers";

		[Token(Token = "0x400060A")]
		public const string ListenerFollowerName = "~ListenerFollower~";

		[Token(Token = "0x400060B")]
		public const float ListenerFollowerTrigRadius = 0.01f;

		[Token(Token = "0x400060C")]
		public const int IgnoreRaycastLayerNumber = 2;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Transform _followerHolder;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ListenerFollower _listenerFollower;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Rigidbody _listenerFollowerRB;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static List<TransformFollower> _transformFollowers;

		[Token(Token = "0x17000095")]
		public static ListenerFollower ListenerFollower
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x1596894", Offset = "0x1596894", VA = "0x1596894")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		public static Transform FollowerHolder
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x15961B8", Offset = "0x15961B8", VA = "0x15961B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		public static bool HasListenerFollower
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x1597178", Offset = "0x1597178", VA = "0x1597178")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000098")]
		public static int AmbientCount
		{
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x1597218", Offset = "0x1597218", VA = "0x1597218")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000099")]
		public static bool HasListenerFolowerRigidBody
		{
			[Token(Token = "0x6000427")]
			[Address(RVA = "0x15958E8", Offset = "0x15958E8", VA = "0x15958E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x1596104", Offset = "0x1596104", VA = "0x1596104")]
		public static void InitFollowerHolder()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x1595708", Offset = "0x1595708", VA = "0x1595708")]
		public static bool InitListenerFollower()
		{
			return default(bool);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x1596D68", Offset = "0x1596D68", VA = "0x1596D68")]
		public static void RemoveTransformFollower(TransformFollower follower)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x1595988", Offset = "0x1595988", VA = "0x1595988")]
		public static Transform InitAudioSourceFollower(Transform transToFollow, string followerName, string soundGroupName, string variationName, float volume, bool willFollowSource, bool willPositionOnClosestColliderPoint, bool useTopCollider, bool useChildColliders, MasterAudio.AmbientSoundExitMode exitMode, float exitFadeTime, MasterAudio.AmbientSoundReEnterMode reEnterMode, float reEnterFadeTime)
		{
			return null;
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1596EC0", Offset = "0x1596EC0", VA = "0x1596EC0")]
		public static void ManualUpdate()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x1596FD0", Offset = "0x1596FD0", VA = "0x1596FD0")]
		private static void UpdateListenerFollower()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public static class ArrayListUtil
	{
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x1597320", Offset = "0x1597320", VA = "0x1597320")]
		public static void SortIntArray(ref List<int> list)
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x1597444", Offset = "0x1597444", VA = "0x1597444")]
		public static bool IsExcludedChildName(string name)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000E2")]
	public static class AudioTransformExtensions
	{
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1599B24", Offset = "0x1599B24", VA = "0x1599B24")]
		public static void FadeOutSoundGroupOfTransform(this Transform sourceTrans, string sType, float fadeTime)
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1599BA4", Offset = "0x1599BA4", VA = "0x1599BA4")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(this Transform sourceTrans)
		{
			return null;
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1599F6C", Offset = "0x1599F6C", VA = "0x1599F6C")]
		public static bool PlaySound3DAtTransformAndForget(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x159A1EC", Offset = "0x159A1EC", VA = "0x159A1EC")]
		public static PlaySoundResult PlaySound3DAtTransform(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x159A4C0", Offset = "0x159A4C0", VA = "0x159A4C0")]
		public static bool PlaySound3DFollowTransformAndForget(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x159A740", Offset = "0x159A740", VA = "0x159A740")]
		public static PlaySoundResult PlaySound3DFollowTransform(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x159AA14", Offset = "0x159AA14", VA = "0x159AA14")]
		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x159ABCC", Offset = "0x159ABCC", VA = "0x159ABCC")]
		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x159AD84", Offset = "0x159AD84", VA = "0x159AD84")]
		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x159B03C", Offset = "0x159B03C", VA = "0x159B03C")]
		public static void PauseBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x159B284", Offset = "0x159B284", VA = "0x159B284")]
		public static void PauseSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x159B4E4", Offset = "0x159B4E4", VA = "0x159B4E4")]
		public static void StopAllSoundsOfTransform(this Transform sourceTrans)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x159B7FC", Offset = "0x159B7FC", VA = "0x159B7FC")]
		public static void StopBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x159BAA4", Offset = "0x159BAA4", VA = "0x159BAA4")]
		public static void StopSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x159BB14", Offset = "0x159BB14", VA = "0x159BB14")]
		public static void UnpauseAllSoundsOfTransform(this Transform sourceTrans)
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x159BDCC", Offset = "0x159BDCC", VA = "0x159BDCC")]
		public static void UnpauseBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x159C014", Offset = "0x159C014", VA = "0x159C014")]
		public static void UnpauseSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x159C274", Offset = "0x159C274", VA = "0x159C274")]
		public static bool IsTransformPlayingSoundGroup(this Transform sourceTrans, string sType)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000E3")]
	public class AudioTransformTracker : MonoBehaviour
	{
		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int _frames;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform _trans;

		[Token(Token = "0x1700009A")]
		public Transform Trans
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x159C4F4", Offset = "0x159C4F4", VA = "0x159C4F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x159C594", Offset = "0x159C594", VA = "0x159C594")]
		private void Update()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x159C5A4", Offset = "0x159C5A4", VA = "0x159C5A4")]
		public AudioTransformTracker()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public static class AudioUtil
	{
		[Token(Token = "0x4000614")]
		public const float DefaultMinOcclusionCutoffFrequency = 22000f;

		[Token(Token = "0x4000615")]
		public const float DefaultMaxOcclusionCutoffFrequency = 0f;

		[Token(Token = "0x4000616")]
		private const float SemitonePitchChangeAmt = 1.0594635f;

		[Token(Token = "0x1700009B")]
		public static float FixedDeltaTime
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0x159C624", Offset = "0x159C624", VA = "0x159C624")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700009C")]
		public static float FrameTime
		{
			[Token(Token = "0x6000446")]
			[Address(RVA = "0x159C62C", Offset = "0x159C62C", VA = "0x159C62C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700009D")]
		public static float Time
		{
			[Token(Token = "0x6000447")]
			[Address(RVA = "0x159C634", Offset = "0x159C634", VA = "0x159C634")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700009E")]
		public static int FrameCount
		{
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x159C63C", Offset = "0x159C63C", VA = "0x159C63C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x159C5AC", Offset = "0x159C5AC", VA = "0x159C5AC")]
		private static float CutoffRange(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x159C5F4", Offset = "0x159C5F4", VA = "0x159C5F4")]
		private static float MaxCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x159C60C", Offset = "0x159C60C", VA = "0x159C60C")]
		public static float MinCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x159C644", Offset = "0x159C644", VA = "0x159C644")]
		public static float GetOcclusionCutoffFrequencyByDistanceRatio(float distRatio, SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x159C690", Offset = "0x159C690", VA = "0x159C690")]
		public static float GetSemitonesFromPitch(float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x159C6DC", Offset = "0x159C6DC", VA = "0x159C6DC")]
		public static float GetPitchFromSemitones(float semitones)
		{
			return default(float);
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x159C71C", Offset = "0x159C71C", VA = "0x159C71C")]
		public static float GetDbFromFloatVolume(float vol)
		{
			return default(float);
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x159C738", Offset = "0x159C738", VA = "0x159C738")]
		public static float GetFloatVolumeFromDb(float db)
		{
			return default(float);
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x159826C", Offset = "0x159826C", VA = "0x159826C")]
		public static float GetAudioPlayedPercentage(AudioSource source)
		{
			return default(float);
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x159C748", Offset = "0x159C748", VA = "0x159C748")]
		public static bool IsClipPaused(AudioSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x159C790", Offset = "0x159C790", VA = "0x159C790")]
		public static void ClipPlayed(AudioClip clip, GameObject actor)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x159C8AC", Offset = "0x159C8AC", VA = "0x159C8AC")]
		public static void UnloadNonPreloadedAudioData(AudioClip clip, GameObject actor)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x159C81C", Offset = "0x159C81C", VA = "0x159C81C")]
		public static bool AudioClipWillPreload(AudioClip clip)
		{
			return default(bool);
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x159C998", Offset = "0x159C998", VA = "0x159C998")]
		public static bool IsClipReadyToPlay(this AudioClip clip)
		{
			return default(bool);
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x159CA2C", Offset = "0x159CA2C", VA = "0x159CA2C")]
		private static float GetPositiveUsablePitch(AudioSource source)
		{
			return default(float);
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x159CA58", Offset = "0x159CA58", VA = "0x159CA58")]
		private static float GetPositiveUsablePitch(float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x159CA68", Offset = "0x159CA68", VA = "0x159CA68")]
		public static float AdjustAudioClipDurationForPitch(float duration, AudioSource sourceWithPitch)
		{
			return default(float);
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x159CAA4", Offset = "0x159CAA4", VA = "0x159CAA4")]
		public static float AdjustAudioClipDurationForPitch(float duration, float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x159CAB8", Offset = "0x159CAB8", VA = "0x159CAB8")]
		public static float AdjustEndLeadTimeForPitch(float duration, AudioSource sourceWithPitch)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000E5")]
	public static class CoroutineHelper
	{
		[Token(Token = "0x20000E6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x822854", Offset = "0x822854")]
		private sealed class <WaitForActualSeconds>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float time;

			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float <start>5__2;

			[Token(Token = "0x1700009F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600045D")]
				[Address(RVA = "0x1D2F1A8", Offset = "0x1D2F1A8", VA = "0x1D2F1A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600045F")]
				[Address(RVA = "0x1D2F1F0", Offset = "0x1D2F1F0", VA = "0x1D2F1F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600045A")]
			[Address(RVA = "0x1D2F0AC", Offset = "0x1D2F0AC", VA = "0x1D2F0AC")]
			[DebuggerHidden]
			public <WaitForActualSeconds>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x600045B")]
			[Address(RVA = "0x1D2F0D8", Offset = "0x1D2F0D8", VA = "0x1D2F0D8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600045C")]
			[Address(RVA = "0x1D2F0DC", Offset = "0x1D2F0DC", VA = "0x1D2F0DC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600045E")]
			[Address(RVA = "0x1D2F1B0", Offset = "0x1D2F1B0", VA = "0x1D2F1B0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x159D5B8", Offset = "0x159D5B8", VA = "0x159D5B8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x825ED4", Offset = "0x825ED4")]
		public static IEnumerator WaitForActualSeconds(float time)
		{
			return null;
		}
	}
	[Token(Token = "0x20000E7")]
	public static class DTMonoHelper
	{
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x1596DF4", Offset = "0x1596DF4", VA = "0x1596DF4")]
		public static Transform GetChildTransform(this Transform transParent, string childName)
		{
			return null;
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x159D74C", Offset = "0x159D74C", VA = "0x159D74C")]
		public static bool IsActive(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x159D764", Offset = "0x159D764", VA = "0x159D764")]
		public static void SetActive(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x15964B0", Offset = "0x15964B0", VA = "0x15964B0")]
		public static void DestroyAllChildren(this Transform tran)
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class DelayBetweenSongs : MonoBehaviour
	{
		[Token(Token = "0x20000E9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x822874", Offset = "0x822874")]
		private sealed class <PlaySongWithDelay>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DelayBetweenSongs <>4__this;

			[Token(Token = "0x170000A1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600046C")]
				[Address(RVA = "0x1D2F378", Offset = "0x1D2F378", VA = "0x1D2F378", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600046E")]
				[Address(RVA = "0x1D2F3C0", Offset = "0x1D2F3C0", VA = "0x1D2F3C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0x1D2F1F8", Offset = "0x1D2F1F8", VA = "0x1D2F1F8")]
			[DebuggerHidden]
			public <PlaySongWithDelay>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0x1D2F224", Offset = "0x1D2F224", VA = "0x1D2F224", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600046B")]
			[Address(RVA = "0x1D2F228", Offset = "0x1D2F228", VA = "0x1D2F228", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600046D")]
			[Address(RVA = "0x1D2F380", Offset = "0x1D2F380", VA = "0x1D2F380", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minTimeToWait;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxTimeToWait;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string playlistControllerName;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PlaylistController _controller;

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x159D780", Offset = "0x159D780", VA = "0x159D780")]
		private void Start()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x159D834", Offset = "0x159D834", VA = "0x159D834")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x159D8C8", Offset = "0x159D8C8", VA = "0x159D8C8")]
		private void SongEnded(string songName)
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x159D900", Offset = "0x159D900", VA = "0x159D900")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x825FA4", Offset = "0x825FA4")]
		private IEnumerator PlaySongWithDelay()
		{
			return null;
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x159D978", Offset = "0x159D978", VA = "0x159D978")]
		public DelayBetweenSongs()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x822884", Offset = "0x822884")]
	public class DynamicSoundGroupCreator : MonoBehaviour
	{
		[Token(Token = "0x20000EB")]
		public enum CreateItemsWhen
		{
			[Token(Token = "0x4000644")]
			FirstEnableOnly,
			[Token(Token = "0x4000645")]
			EveryEnable
		}

		[Token(Token = "0x20000EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x822898", Offset = "0x822898")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CustomEventCategory aCat;

			[Token(Token = "0x600047C")]
			[Address(RVA = "0x1D2F3C8", Offset = "0x1D2F3C8", VA = "0x1D2F3C8")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0x1D2F3D0", Offset = "0x1D2F3D0", VA = "0x1D2F3D0")]
			internal bool <RemoveItems>b__0(CustomEventCategory cat)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000622")]
		public const int ExtraHardCodedBusOptions = 1;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SystemLanguage previewLanguage;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MasterAudio.DragGroupMode curDragGroupMode;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject groupTemplate;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject variationTemplate;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool errorOnDuplicates;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool createOnAwake;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool soundGroupsAreExpanded;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		public bool removeGroupsOnSceneChange;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public CreateItemsWhen reUseMode;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool showCustomEvents;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<CustomEvent> customEventsToCreate;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string newEventName;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool showMusicDucking;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<DuckGroupInfo> musicDuckingSounds;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<GroupBus> groupBuses;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool playListExpanded;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		public bool playlistEditorExp;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<MasterAudio.Playlist> musicPlaylists;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<GameObject> audioSourceTemplates;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string audioSourceTemplateName;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool groupByBus;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool itemsCreatedEventExpanded;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string itemsCreatedCustomEvent;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool showUnityMixerGroupAssignment;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		private bool _hasCreated;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly List<Transform> _groupsToRemove;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Transform _trans;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private readonly List<DynamicSoundGroup> _groupsToCreate;

		[Token(Token = "0x170000A3")]
		public static int HardCodedBusOptions
		{
			[Token(Token = "0x6000478")]
			[Address(RVA = "0x15A0A84", Offset = "0x15A0A84", VA = "0x15A0A84")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A4")]
		public List<DynamicSoundGroup> GroupsToCreate
		{
			[Token(Token = "0x6000479")]
			[Address(RVA = "0x15A2860", Offset = "0x15A2860", VA = "0x15A2860")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A5")]
		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			[Token(Token = "0x600047A")]
			[Address(RVA = "0x15A2868", Offset = "0x15A2868", VA = "0x15A2868")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x159E5A4", Offset = "0x159E5A4", VA = "0x159E5A4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x159E688", Offset = "0x159E688", VA = "0x159E688")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x159E780", Offset = "0x159E780", VA = "0x159E780")]
		private void Start()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x159E784", Offset = "0x159E784", VA = "0x159E784")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x159E68C", Offset = "0x159E68C", VA = "0x159E68C")]
		private void CreateItemsIfReady()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x159E8AC", Offset = "0x159E8AC", VA = "0x159E8AC")]
		public void RemoveItems()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x159EDA4", Offset = "0x159EDA4", VA = "0x159EDA4")]
		public void CreateItems()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x15A2598", Offset = "0x15A2598", VA = "0x15A2598")]
		private void FireEvents()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x15A0404", Offset = "0x15A0404", VA = "0x15A0404")]
		public void PopulateGroupData()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x15A2870", Offset = "0x15A2870", VA = "0x15A2870")]
		public DynamicSoundGroupCreator()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public static class FilePlayerPrefs
	{
		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Hashtable PlayerPrefsHashtable;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool _hashTableChanged;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string _serializedOutput;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly string SerializedInput;

		[Token(Token = "0x400064B")]
		private const string ParametersSeperator = ";";

		[Token(Token = "0x400064C")]
		private const string KeyValueSeperator = ":";

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly string FileName;

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x15B283C", Offset = "0x15B283C", VA = "0x15B283C")]
		static FilePlayerPrefs()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x15B2CE8", Offset = "0x15B2CE8", VA = "0x15B2CE8")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x15B2D68", Offset = "0x15B2D68", VA = "0x15B2D68")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x15B2E9C", Offset = "0x15B2E9C", VA = "0x15B2E9C")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x15B301C", Offset = "0x15B301C", VA = "0x15B301C")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x15B31A4", Offset = "0x15B31A4", VA = "0x15B31A4")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x15B3328", Offset = "0x15B3328", VA = "0x15B3328")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x15B3408", Offset = "0x15B3408", VA = "0x15B3408")]
		public static string GetString(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x15B3548", Offset = "0x15B3548", VA = "0x15B3548")]
		public static int GetInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x15B36F0", Offset = "0x15B36F0", VA = "0x15B36F0")]
		public static int GetInt(string key, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x15B3878", Offset = "0x15B3878", VA = "0x15B3878")]
		public static float GetFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x15B3A20", Offset = "0x15B3A20", VA = "0x15B3A20")]
		public static float GetFloat(string key, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x15B3BB0", Offset = "0x15B3BB0", VA = "0x15B3BB0")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x15B3CC0", Offset = "0x15B3CC0", VA = "0x15B3CC0")]
		public static bool GetBool(string key, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x15B3E54", Offset = "0x15B3E54", VA = "0x15B3E54")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x15B3ED4", Offset = "0x15B3ED4", VA = "0x15B3ED4")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x15B3F4C", Offset = "0x15B3F4C", VA = "0x15B3F4C")]
		public static void Flush()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x15B40F8", Offset = "0x15B40F8", VA = "0x15B40F8")]
		private static void Serialize()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x15B29E0", Offset = "0x15B29E0", VA = "0x15B29E0")]
		private static void Deserialize()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x15B466C", Offset = "0x15B466C", VA = "0x15B466C")]
		private static string EscapeNonSeperators(string inputToEscape)
		{
			return null;
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x15B4718", Offset = "0x15B4718", VA = "0x15B4718")]
		private static string DeEscapeNonSeperators(string inputToDeEscape)
		{
			return null;
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x15B47C4", Offset = "0x15B47C4", VA = "0x15B47C4")]
		public static object GetTypeValue(string typeName, string value)
		{
			return null;
		}
	}
	[Token(Token = "0x20000EE")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x8228A8", Offset = "0x8228A8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8228A8", Offset = "0x8228A8")]
	public class PlaylistController : MonoBehaviour
	{
		[Token(Token = "0x20000EF")]
		public enum AudioPlayType
		{
			[Token(Token = "0x40006AC")]
			PlayNow,
			[Token(Token = "0x40006AD")]
			Schedule,
			[Token(Token = "0x40006AE")]
			AlreadyScheduled
		}

		[Token(Token = "0x20000F0")]
		public enum PlaylistStates
		{
			[Token(Token = "0x40006B0")]
			NotInScene,
			[Token(Token = "0x40006B1")]
			Stopped,
			[Token(Token = "0x40006B2")]
			Playing,
			[Token(Token = "0x40006B3")]
			Paused,
			[Token(Token = "0x40006B4")]
			Crossfading
		}

		[Token(Token = "0x20000F1")]
		public enum FadeMode
		{
			[Token(Token = "0x40006B6")]
			None,
			[Token(Token = "0x40006B7")]
			GradualFade
		}

		[Token(Token = "0x20000F2")]
		public enum AudioDuckingMode
		{
			[Token(Token = "0x40006B9")]
			NotDucking,
			[Token(Token = "0x40006BA")]
			SetToDuck,
			[Token(Token = "0x40006BB")]
			Ducked,
			[Token(Token = "0x40006BC")]
			Unducking
		}

		[Token(Token = "0x20000F3")]
		public delegate void SongChangedEventHandler(string newSongName, MusicSetting song);

		[Token(Token = "0x20000F4")]
		public delegate void SongEndedEventHandler(string songName);

		[Token(Token = "0x20000F5")]
		public delegate void SongLoopedEventHandler(string songName);

		[Token(Token = "0x20000F6")]
		public delegate void PlaylistEndedEventHandler();

		[Token(Token = "0x20000F7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82291C", Offset = "0x82291C")]
		private sealed class <>c__DisplayClass110_0
		{
			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string clipName;

			[Token(Token = "0x6000510")]
			[Address(RVA = "0x1D30C34", Offset = "0x1D30C34", VA = "0x1D30C34")]
			public <>c__DisplayClass110_0()
			{
			}

			[Token(Token = "0x6000511")]
			[Address(RVA = "0x1D30C3C", Offset = "0x1D30C3C", VA = "0x1D30C3C")]
			internal bool <FindSongByAliasOrName>b__0(MusicSetting obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000512")]
			[Address(RVA = "0x1D30C60", Offset = "0x1D30C60", VA = "0x1D30C60")]
			internal bool <FindSongByAliasOrName>b__1(MusicSetting obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82292C", Offset = "0x82292C")]
		private sealed class <>c__DisplayClass120_0
		{
			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string playlistControllerName;

			[Token(Token = "0x6000513")]
			[Address(RVA = "0x1D30D2C", Offset = "0x1D30D2C", VA = "0x1D30D2C")]
			public <>c__DisplayClass120_0()
			{
			}

			[Token(Token = "0x6000514")]
			[Address(RVA = "0x1D30D34", Offset = "0x1D30D34", VA = "0x1D30D34")]
			internal bool <InstanceByName>b__0(PlaylistController obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000F9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82293C", Offset = "0x82293C")]
		private sealed class <>c__DisplayClass151_0
		{
			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PlaylistController <>4__this;

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volumeBeforeFade;

			[Token(Token = "0x6000515")]
			[Address(RVA = "0x1D30DE0", Offset = "0x1D30DE0", VA = "0x1D30DE0")]
			public <>c__DisplayClass151_0()
			{
			}

			[Token(Token = "0x6000516")]
			[Address(RVA = "0x1D30DE8", Offset = "0x1D30DE8", VA = "0x1D30DE8")]
			internal void <FadeOutPlaylist>b__0()
			{
			}
		}

		[Token(Token = "0x400064E")]
		public const float ScheduledSongMinBadOffset = 0.5f;

		[Token(Token = "0x400064F")]
		public const int FramesEarlyToTrigger = 2;

		[Token(Token = "0x4000650")]
		public const int FramesEarlyToBeSyncable = 10;

		[Token(Token = "0x4000651")]
		private const int NextScheduleTimeRecalcConsecutiveFrameCount = 5;

		[Token(Token = "0x4000652")]
		private const string NotReadyMessage = "Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.";

		[Token(Token = "0x4000653")]
		private const float MinSongLength = 0.5f;

		[Token(Token = "0x4000654")]
		private const float SlowestFrameTimeForCalc = 0.3f;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool startPlaylistOnAwake;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool isShuffle;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool isAutoAdvance;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool loopPlaylist;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float _playlistVolume;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isMuted;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string startPlaylistName;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int syncGroupNum;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioMixerGroup mixerChannel;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float spatialBlend;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool initializedEventExpanded;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string initializedCustomEvent;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool crossfadeStartedExpanded;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string crossfadeStartedCustomEvent;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool songChangedEventExpanded;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string songChangedCustomEvent;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool songEndedEventExpanded;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string songEndedCustomEvent;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool songLoopedEventExpanded;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string songLoopedCustomEvent;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool playlistStartedEventExpanded;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string playlistStartedCustomEvent;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool playlistEndedEventExpanded;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string playlistEndedCustomEvent;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AudioSource _activeAudio;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioSource _transitioningAudio;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float _activeAudioEndVolume;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float _transitioningAudioStartVolume;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float _crossFadeStartTime;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly List<int> _clipsRemaining;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int _currentSequentialClipIndex;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private AudioDuckingMode _duckingMode;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _timeToStartUnducking;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _timeToFinishUnducking;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float _originalMusicVolume;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float _initialDuckVolume;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float _duckRange;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private SoundGroupVariationUpdater _actorUpdater;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private float _unduckTime;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private MusicSetting _currentSong;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private GameObject _go;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private string _name;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private FadeMode _curFadeMode;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private float _slowFadeStartTime;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float _slowFadeCompletionTime;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private float _slowFadeStartVolume;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float _slowFadeTargetVolume;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private MasterAudio.Playlist _currentPlaylist;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private float _lastTimeMissingPlaylistLogged;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Action _fadeCompleteCallback;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private readonly List<MusicSetting> _queuedSongs;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private bool _lostFocus;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x161")]
		private bool _autoStartedPlaylist;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private AudioSource _audioClip;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private AudioSource _transClip;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private MusicSetting _newSongSetting;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private bool _nextSongRequested;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x181")]
		private bool _nextSongScheduled;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		private int _lastRandomClipIndex;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private float _lastTimeSongRequested;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private float _currentDuckVolCut;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private int? _lastSongPosition;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private double? _currentSchedSongDspStartTime;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private double? _currentSchedSongDspEndTime;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private int _lastFrameSongPosition;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private int _nextScheduleTimeRecalcDifferentFirstFrameNum;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private double? _nextScheduledTimeRecalcStart;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private readonly Dictionary<AudioSource, double> _scheduledSongOffsetByAudioSource;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public int _frames;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<PlaylistController> _instances;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private Coroutine _resourceCoroutine;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private int _songsPlayedFromPlaylist;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private AudioSource _audio1;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private AudioSource _audio2;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private string _activeSongAlias;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private Transform _trans;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private bool _willPersist;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private double? _songPauseTime;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private int framesOfSongPlayed;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x825720", Offset = "0x825720")]
		private bool <ControllerIsReady>k__BackingField;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x251")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x825730", Offset = "0x825730")]
		private bool <IsCrossFading>k__BackingField;

		[Token(Token = "0x170000A6")]
		private bool SongIsNonAdvancible
		{
			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x1C7288C", Offset = "0x1C7288C", VA = "0x1C7288C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A7")]
		public bool ControllerIsReady
		{
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x1C728E4", Offset = "0x1C728E4", VA = "0x1C728E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8260D4", Offset = "0x8260D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x1C728EC", Offset = "0x1C728EC", VA = "0x1C728EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8260E4", Offset = "0x8260E4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public PlaylistStates PlaylistState
		{
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x1C6E764", Offset = "0x1C6E764", VA = "0x1C6E764")]
			get
			{
				return default(PlaylistStates);
			}
		}

		[Token(Token = "0x170000A9")]
		public AudioSource ActiveAudioSource
		{
			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x1C663CC", Offset = "0x1C663CC", VA = "0x1C663CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AA")]
		public static List<PlaylistController> Instances
		{
			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x1C65954", Offset = "0x1C65954", VA = "0x1C65954")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x1C728F8", Offset = "0x1C728F8", VA = "0x1C728F8")]
			set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public GameObject PlaylistControllerGameObject
		{
			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x1C7294C", Offset = "0x1C7294C", VA = "0x1C7294C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AC")]
		public AudioSource CurrentPlaylistSource
		{
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x1C72954", Offset = "0x1C72954", VA = "0x1C72954")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AD")]
		public AudioClip CurrentPlaylistClip
		{
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x1C6693C", Offset = "0x1C6693C", VA = "0x1C6693C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AE")]
		public AudioClip FadingPlaylistClip
		{
			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x1C7295C", Offset = "0x1C7295C", VA = "0x1C7295C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AF")]
		public AudioSource FadingSource
		{
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x1C729F8", Offset = "0x1C729F8", VA = "0x1C729F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B0")]
		public bool IsCrossFading
		{
			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x1C72A10", Offset = "0x1C72A10", VA = "0x1C72A10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8260F4", Offset = "0x8260F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x1C72A18", Offset = "0x1C72A18", VA = "0x1C72A18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x826104", Offset = "0x826104")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public bool IsFading
		{
			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x1C72A24", Offset = "0x1C72A24", VA = "0x1C72A24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B2")]
		public float PlaylistVolume
		{
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x1C66360", Offset = "0x1C66360", VA = "0x1C66360")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004EC")]
			[Address(RVA = "0x1C72A44", Offset = "0x1C72A44", VA = "0x1C72A44")]
			set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public MasterAudio.Playlist CurrentPlaylist
		{
			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x1C718F0", Offset = "0x1C718F0", VA = "0x1C718F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B4")]
		public bool HasPlaylist
		{
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x1C6EBC0", Offset = "0x1C6EBC0", VA = "0x1C6EBC0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B5")]
		public string PlaylistName
		{
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x1C72A90", Offset = "0x1C72A90", VA = "0x1C72A90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B6")]
		public MusicSetting CurrentSong
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x1C72B04", Offset = "0x1C72B04", VA = "0x1C72B04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B7")]
		private bool IsMuted
		{
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x1C72B0C", Offset = "0x1C72B0C", VA = "0x1C72B0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B8")]
		private bool PlaylistIsMuted
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x1C6ED3C", Offset = "0x1C6ED3C", VA = "0x1C6ED3C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		private float CrossFadeTime
		{
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x1C6E578", Offset = "0x1C6E578", VA = "0x1C6E578")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000BA")]
		private bool IsAutoAdvance
		{
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x1C6E604", Offset = "0x1C6E604", VA = "0x1C6E604")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BB")]
		public GameObject GameObj
		{
			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x1C6F5D0", Offset = "0x1C6F5D0", VA = "0x1C6F5D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BC")]
		public string ControllerName
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x1C6C3D0", Offset = "0x1C6C3D0", VA = "0x1C6C3D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BD")]
		public bool CanSchedule
		{
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x1C6C994", Offset = "0x1C6C994", VA = "0x1C6C994")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BE")]
		private bool IsFrameFastEnough
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x1C6D11C", Offset = "0x1C6D11C", VA = "0x1C6D11C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BF")]
		private bool ShouldNotSwitchEarly
		{
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x1C6E728", Offset = "0x1C6E728", VA = "0x1C6E728")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C0")]
		private Transform Trans
		{
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x1C6D014", Offset = "0x1C6D014", VA = "0x1C6D014")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C1")]
		public int ClipsRemainingInCurrentPlaylist
		{
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x1C72B14", Offset = "0x1C72B14", VA = "0x1C72B14")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000004")]
		public event SongChangedEventHandler SongChanged
		{
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x1C6B8CC", Offset = "0x1C6B8CC", VA = "0x1C6B8CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x826054", Offset = "0x826054")]
			add
			{
			}
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x1C6B970", Offset = "0x1C6B970", VA = "0x1C6B970")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x826064", Offset = "0x826064")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event SongEndedEventHandler SongEnded
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x1C6BA14", Offset = "0x1C6BA14", VA = "0x1C6BA14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x826074", Offset = "0x826074")]
			add
			{
			}
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x1C6BAB8", Offset = "0x1C6BAB8", VA = "0x1C6BAB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x826084", Offset = "0x826084")]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event SongLoopedEventHandler SongLooped
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x1C6BB5C", Offset = "0x1C6BB5C", VA = "0x1C6BB5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x826094", Offset = "0x826094")]
			add
			{
			}
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x1C6BC00", Offset = "0x1C6BC00", VA = "0x1C6BC00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8260A4", Offset = "0x8260A4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event PlaylistEndedEventHandler PlaylistEnded
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x1C6BCA4", Offset = "0x1C6BCA4", VA = "0x1C6BCA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8260B4", Offset = "0x8260B4")]
			add
			{
			}
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x1C6BD48", Offset = "0x1C6BD48", VA = "0x1C6BD48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8260C4", Offset = "0x8260C4")]
			remove
			{
			}
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x1C6BDEC", Offset = "0x1C6BDEC", VA = "0x1C6BDEC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x1C6C424", Offset = "0x1C6C424", VA = "0x1C6C424")]
		public void SetSpatialBlend()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x1C6C640", Offset = "0x1C6C640", VA = "0x1C6C640")]
		private void DetectAndRescheduleNextGaplessSongIfOff()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x1C6CBB0", Offset = "0x1C6CBB0", VA = "0x1C6CBB0")]
		private MusicSetting FindSongByAliasOrName(string clipName)
		{
			return null;
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x1C6CD30", Offset = "0x1C6CD30", VA = "0x1C6CD30")]
		private void SetAudiosIfEmpty()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x1C6C590", Offset = "0x1C6C590", VA = "0x1C6C590")]
		private void SetAudioSpatialBlend(float blend)
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x1C6CDC8", Offset = "0x1C6CDC8", VA = "0x1C6CDC8")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x1C6D0B4", Offset = "0x1C6D0B4", VA = "0x1C6D0B4")]
		private void AutoStartPlaylist()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x1C6D1EC", Offset = "0x1C6D1EC", VA = "0x1C6D1EC")]
		private void CoUpdate()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x1C6D6BC", Offset = "0x1C6D6BC", VA = "0x1C6D6BC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x1C6D7C8", Offset = "0x1C6D7C8", VA = "0x1C6D7C8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1C6DA44", Offset = "0x1C6DA44", VA = "0x1C6DA44")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1C6DA50", Offset = "0x1C6DA50", VA = "0x1C6DA50")]
		private void Update()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x1C66174", Offset = "0x1C66174", VA = "0x1C66174")]
		public static PlaylistController InstanceByName(string playlistControllerName, bool errorIfNotFound = true)
		{
			return null;
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x1C6EA88", Offset = "0x1C6EA88", VA = "0x1C6EA88")]
		public bool IsSongPlaying(string songName)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x1C6EBD0", Offset = "0x1C6EBD0", VA = "0x1C6EBD0")]
		public void ClearQueue()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x1C6EC80", Offset = "0x1C6EC80", VA = "0x1C6EC80")]
		public void ToggleMutePlaylist()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x1C6D114", Offset = "0x1C6D114", VA = "0x1C6D114")]
		public void MutePlaylist()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x1C6ED34", Offset = "0x1C6ED34", VA = "0x1C6ED34")]
		public void UnmutePlaylist()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x1C6EEAC", Offset = "0x1C6EEAC", VA = "0x1C6EEAC")]
		public void PausePlaylist()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x1C6F0BC", Offset = "0x1C6F0BC", VA = "0x1C6F0BC")]
		public bool UnpausePlaylist()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x1C6D57C", Offset = "0x1C6D57C", VA = "0x1C6D57C")]
		public void StopPlaylist(bool onlyFadingClip = false)
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x1C6F670", Offset = "0x1C6F670", VA = "0x1C6F670")]
		public void FadeToVolume(float targetVolume, float fadeTime, [Optional] Action callback)
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x1C6F7B4", Offset = "0x1C6F7B4", VA = "0x1C6F7B4")]
		public void PlayRandomSong()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x1C6F848", Offset = "0x1C6F848", VA = "0x1C6F848")]
		public void PlayARandomSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x1C6FA44", Offset = "0x1C6FA44", VA = "0x1C6FA44")]
		private void RemoveRandomClip(int randIndex)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x1C702A4", Offset = "0x1C702A4", VA = "0x1C702A4")]
		private void PlayFirstQueuedSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x1C703E0", Offset = "0x1C703E0", VA = "0x1C703E0")]
		public void PlayNextSong()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1C70474", Offset = "0x1C70474", VA = "0x1C70474")]
		public void PlayTheNextSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x1C70620", Offset = "0x1C70620", VA = "0x1C70620")]
		private void AdvanceSongCounter()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x1C70694", Offset = "0x1C70694", VA = "0x1C70694")]
		public void StopPlaylistAfterCurrentSong()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x1C70890", Offset = "0x1C70890", VA = "0x1C70890")]
		public void StopLoopingCurrentSong()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x1C70A44", Offset = "0x1C70A44", VA = "0x1C70A44")]
		public void QueuePlaylistClip(string clipName, bool scheduleNow = true)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x1C70DEC", Offset = "0x1C70DEC", VA = "0x1C70DEC")]
		public bool TriggerPlaylistClip(string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1C71108", Offset = "0x1C71108", VA = "0x1C71108")]
		public void EndDucking(SoundGroupVariationUpdater actorUpdater)
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x1C711A8", Offset = "0x1C711A8", VA = "0x1C711A8")]
		public void DuckMusicForTime(SoundGroupVariationUpdater actorUpdater, float duckLength, float unduckTime, float pitch, float duckedTimePercentage, float duckedVolCut)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x1C71350", Offset = "0x1C71350", VA = "0x1C71350")]
		private void InitControllerIfNot()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x1C6D44C", Offset = "0x1C6D44C", VA = "0x1C6D44C")]
		public void UpdateMasterVolume()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1C71380", Offset = "0x1C71380", VA = "0x1C71380")]
		public void StartPlaylist(string playlistName, [Optional] string clipName)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1C7150C", Offset = "0x1C7150C", VA = "0x1C7150C")]
		public void ChangePlaylist(string playlistName, bool playFirstClip = true, [Optional] string clipName)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1C6F4C8", Offset = "0x1C6F4C8", VA = "0x1C6F4C8")]
		private void FinishPlaylistInit(bool playFirstClip = true, [Optional] string clipName)
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x1C71464", Offset = "0x1C71464", VA = "0x1C71464")]
		public void RestartPlaylist([Optional] string clipName)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x1C7167C", Offset = "0x1C7167C", VA = "0x1C7167C")]
		private void CheckIfPlaylistStarted()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x1C71774", Offset = "0x1C71774", VA = "0x1C71774")]
		private PlaylistController FindOtherControllerInSameSyncGroup()
		{
			return null;
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1C6E86C", Offset = "0x1C6E86C", VA = "0x1C6E86C")]
		private void FadeOutPlaylist()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1C6CFE0", Offset = "0x1C6CFE0", VA = "0x1C6CFE0")]
		private void InitializePlaylist()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1C6D144", Offset = "0x1C6D144", VA = "0x1C6D144")]
		private void PlayNextOrRandom(AudioPlayType playType)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1C6E63C", Offset = "0x1C6E63C", VA = "0x1C6E63C")]
		private void FirePlaylistEndedEventIfAny()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x1C700C8", Offset = "0x1C700C8", VA = "0x1C700C8")]
		private void FillClips()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x1C6FAE4", Offset = "0x1C6FAE4", VA = "0x1C6FAE4")]
		private void PlaySong(MusicSetting setting, AudioPlayType playType)
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x1C72470", Offset = "0x1C72470", VA = "0x1C72470")]
		public double? ScheduledGaplessNextSongStartTime()
		{
			return null;
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x1C719A0", Offset = "0x1C719A0", VA = "0x1C719A0")]
		public void FinishLoadingNewSong(MusicSetting songSetting, AudioClip clipToPlay, AudioPlayType playType)
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x1C72750", Offset = "0x1C72750", VA = "0x1C72750")]
		private void RemoveScheduledClip()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x1C70A3C", Offset = "0x1C70A3C", VA = "0x1C70A3C")]
		private void ScheduleNextSong()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x1C6E974", Offset = "0x1C6E974", VA = "0x1C6E974")]
		private void FadeInScheduledSong()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x1C72530", Offset = "0x1C72530", VA = "0x1C72530")]
		private double CalculateNextTrackStartTimeOffset()
		{
			return default(double);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x1C727F8", Offset = "0x1C727F8", VA = "0x1C727F8")]
		private double GetClipDuration(AudioSource src)
		{
			return default(double);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x1C6CA28", Offset = "0x1C6CA28", VA = "0x1C6CA28")]
		private void ScheduleClipPlay(double scheduledPlayTimeOffset, AudioSource source, bool calledAfterPause, bool addDspTime = true)
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x1C72614", Offset = "0x1C72614", VA = "0x1C72614")]
		private void CrossFadeNow(AudioSource audioClip)
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1C6E0EC", Offset = "0x1C6E0EC", VA = "0x1C6E0EC")]
		private void CeaseAudioSource(AudioSource source)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1C6E48C", Offset = "0x1C6E48C", VA = "0x1C6E48C")]
		private void SetDuckProperties()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1C6E97C", Offset = "0x1C6E97C", VA = "0x1C6E97C")]
		private void AudioDucking()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x1C72874", Offset = "0x1C72874", VA = "0x1C72874")]
		private void ResetDuckingState()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1C71864", Offset = "0x1C71864", VA = "0x1C71864")]
		private bool SongShouldLoop(MusicSetting setting)
		{
			return default(bool);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x1C72A4C", Offset = "0x1C72A4C", VA = "0x1C72A4C")]
		public void RouteToMixerChannel(AudioMixerGroup group)
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1C72B60", Offset = "0x1C72B60", VA = "0x1C72B60")]
		public PlaylistController()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x1C72DA0", Offset = "0x1C72DA0", VA = "0x1C72DA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x826114", Offset = "0x826114")]
		private bool <FindOtherControllerInSameSyncGroup>b__150_0(PlaylistController obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1C72E94", Offset = "0x1C72E94", VA = "0x1C72E94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x826124", Offset = "0x826124")]
		private bool <FinishLoadingNewSong>b__158_0(MusicSetting obj)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000FA")]
	public static class SpatializerHelper
	{
		[Token(Token = "0x40006C1")]
		private const string OculusSpatializer = "OculusSpatializer";

		[Token(Token = "0x40006C2")]
		private const string ResonanceAudioSpatializer = "Resonance Audio";

		[Token(Token = "0x170000C2")]
		public static bool IsSupportedSpatializer
		{
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x1D2C8D0", Offset = "0x1D2C8D0", VA = "0x1D2C8D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C3")]
		public static bool IsOculusAudioSpatializer
		{
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x1D2C96C", Offset = "0x1D2C96C", VA = "0x1D2C96C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C4")]
		public static bool IsResonanceAudioSpatializer
		{
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x1D2C9BC", Offset = "0x1D2C9BC", VA = "0x1D2C9BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C5")]
		public static string SelectedSpatializer
		{
			[Token(Token = "0x600051A")]
			[Address(RVA = "0x1D2C964", Offset = "0x1D2C964", VA = "0x1D2C964")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C6")]
		public static bool SpatializerOptionExists
		{
			[Token(Token = "0x600051B")]
			[Address(RVA = "0x1D2CA0C", Offset = "0x1D2CA0C", VA = "0x1D2CA0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1D25CE8", Offset = "0x1D25CE8", VA = "0x1D25CE8")]
		public static void TurnOnSpatializerIfEnabled(AudioSource source)
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public static class UtilStrings
	{
		[Token(Token = "0x600051D")]
		[Address(RVA = "0x1D2E0D0", Offset = "0x1D2E0D0", VA = "0x1D2E0D0")]
		public static string TrimSpace(string untrimmed)
		{
			return null;
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1D2E14C", Offset = "0x1D2E14C", VA = "0x1D2E14C")]
		public static string ReplaceUnsafeChars(string source)
		{
			return null;
		}
	}
	[Token(Token = "0x20000FC")]
	public class VideoPlayerTracker
	{
		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x825740", Offset = "0x825740")]
		private readonly VideoPlayer <Player>k__BackingField;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x825750", Offset = "0x825750")]
		private bool <IsPlaying>k__BackingField;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x825760", Offset = "0x825760")]
		private readonly SoundGroupVariation <Variation>k__BackingField;

		[Token(Token = "0x170000C7")]
		public VideoPlayer Player
		{
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x1D2E28C", Offset = "0x1D2E28C", VA = "0x1D2E28C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x826134", Offset = "0x826134")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C8")]
		public bool IsPlaying
		{
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x1D2E294", Offset = "0x1D2E294", VA = "0x1D2E294")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x826144", Offset = "0x826144")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000523")]
			[Address(RVA = "0x1D2E29C", Offset = "0x1D2E29C", VA = "0x1D2E29C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x826154", Offset = "0x826154")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		public SoundGroupVariation Variation
		{
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x1D2E2A8", Offset = "0x1D2E2A8", VA = "0x1D2E2A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x826164", Offset = "0x826164")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x1D2E234", Offset = "0x1D2E234", VA = "0x1D2E234")]
		private VideoPlayerTracker()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x1D2E23C", Offset = "0x1D2E23C", VA = "0x1D2E23C")]
		public VideoPlayerTracker(VideoPlayer player, SoundGroupVariation variation)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1D2E2B0", Offset = "0x1D2E2B0", VA = "0x1D2E2B0")]
		public void StartedPlaying()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x1D2E2BC", Offset = "0x1D2E2BC", VA = "0x1D2E2BC")]
		public void StoppedPlayings()
		{
		}
	}
}
namespace DarkTonic.MasterAudio.Examples
{
	[Token(Token = "0x20000FD")]
	public class MA_Bootstrapper : MonoBehaviour
	{
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x15B5958", Offset = "0x15B5958", VA = "0x15B5958")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x15B595C", Offset = "0x15B595C", VA = "0x15B595C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x15B5A9C", Offset = "0x15B5A9C", VA = "0x15B5A9C")]
		public MA_Bootstrapper()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class MA_DestroyFinishedParticle : MonoBehaviour
	{
		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ParticleSystem particles;

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x15B5AA4", Offset = "0x15B5AA4", VA = "0x15B5AA4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x15B5B10", Offset = "0x15B5B10", VA = "0x15B5B10")]
		private void Update()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x15B5BAC", Offset = "0x15B5BAC", VA = "0x15B5BAC")]
		public MA_DestroyFinishedParticle()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class MA_EnemyOne : MonoBehaviour
	{
		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject ExplosionParticlePrefab;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform _trans;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _speed;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _horizSpeed;

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x15B5BB4", Offset = "0x15B5BB4", VA = "0x15B5BB4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x15B5C48", Offset = "0x15B5C48", VA = "0x15B5C48")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x15B5D38", Offset = "0x15B5D38", VA = "0x15B5D38")]
		private void Update()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x15B5E74", Offset = "0x15B5E74", VA = "0x15B5E74")]
		public MA_EnemyOne()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class MA_EnemySpawner : MonoBehaviour
	{
		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject Enemy;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool spawnerEnabled;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform trans;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float nextSpawnTime;

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x15B5E7C", Offset = "0x15B5E7C", VA = "0x15B5E7C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x15B5EF4", Offset = "0x15B5EF4", VA = "0x15B5EF4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x15B609C", Offset = "0x15B609C", VA = "0x15B609C")]
		public MA_EnemySpawner()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class MA_GameScene : MonoBehaviour
	{
		[Token(Token = "0x6000534")]
		[Address(RVA = "0x15B60A4", Offset = "0x15B60A4", VA = "0x15B60A4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x15B6158", Offset = "0x15B6158", VA = "0x15B6158")]
		public MA_GameScene()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class MA_Laser : MonoBehaviour
	{
		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform _trans;

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x15B6160", Offset = "0x15B6160", VA = "0x15B6160")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x15B61A0", Offset = "0x15B61A0", VA = "0x15B61A0")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x15B6290", Offset = "0x15B6290", VA = "0x15B6290")]
		private void Update()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x15B6378", Offset = "0x15B6378", VA = "0x15B6378")]
		public MA_Laser()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class MA_LocalizationUI : MonoBehaviour
	{
		[Token(Token = "0x600053A")]
		[Address(RVA = "0x15B6380", Offset = "0x15B6380", VA = "0x15B6380")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x15B6434", Offset = "0x15B6434", VA = "0x15B6434")]
		public MA_LocalizationUI()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class MA_PlayerControl : MonoBehaviour
	{
		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject ProjectilePrefab;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool canShoot;

		[Token(Token = "0x40006D2")]
		private const float MoveSpeed = 10f;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform _trans;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _lastMoveAmt;

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x15B643C", Offset = "0x15B643C", VA = "0x15B643C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x15B647C", Offset = "0x15B647C", VA = "0x15B647C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x15B6528", Offset = "0x15B6528", VA = "0x15B6528")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x15B652C", Offset = "0x15B652C", VA = "0x15B652C")]
		private void OnBecameInvisible()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x15B6530", Offset = "0x15B6530", VA = "0x15B6530")]
		private void OnBecameVisible()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x15B6534", Offset = "0x15B6534", VA = "0x15B6534")]
		private void Update()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x15B6710", Offset = "0x15B6710", VA = "0x15B6710")]
		public MA_PlayerControl()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class MA_PlayerSpawnerControl : MonoBehaviour
	{
		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject Player;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float nextSpawnTime;

		[Token(Token = "0x170000CA")]
		private bool PlayerActive
		{
			[Token(Token = "0x6000544")]
			[Address(RVA = "0x15B6750", Offset = "0x15B6750", VA = "0x15B6750")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x15B6720", Offset = "0x15B6720", VA = "0x15B6720")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x15B676C", Offset = "0x15B676C", VA = "0x15B676C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x15B67F0", Offset = "0x15B67F0", VA = "0x15B67F0")]
		public MA_PlayerSpawnerControl()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class MA_SampleICustomEventReceiver : MonoBehaviour, ICustomEventReceiver
	{
		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<string> _eventsSubscribedTo;

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x15B67F8", Offset = "0x15B67F8", VA = "0x15B67F8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x15B67FC", Offset = "0x15B67FC", VA = "0x15B67FC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x15B696C", Offset = "0x15B696C", VA = "0x15B696C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x15B69E8", Offset = "0x15B69E8", VA = "0x15B69E8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x15B6800", Offset = "0x15B6800", VA = "0x15B6800", Slot = "4")]
		public void CheckForIllegalCustomEvents()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x15B6B6C", Offset = "0x15B6B6C", VA = "0x15B6B6C", Slot = "5")]
		public void ReceiveEvent(string customEventName, Vector3 originPoint)
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x15B6CB8", Offset = "0x15B6CB8", VA = "0x15B6CB8", Slot = "6")]
		public bool SubscribesToEvent(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x15B6970", Offset = "0x15B6970", VA = "0x15B6970", Slot = "7")]
		public void RegisterReceiver()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x15B6B0C", Offset = "0x15B6B0C", VA = "0x15B6B0C", Slot = "8")]
		public void UnregisterReceiver()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x15B6D40", Offset = "0x15B6D40", VA = "0x15B6D40", Slot = "9")]
		public IList<AudioEventGroup> GetAllEvents()
		{
			return null;
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x15B6E8C", Offset = "0x15B6E8C", VA = "0x15B6E8C")]
		public MA_SampleICustomEventReceiver()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class MA_TestUI : MonoBehaviour
	{
		[Token(Token = "0x6000552")]
		[Address(RVA = "0x15B6F7C", Offset = "0x15B6F7C", VA = "0x15B6F7C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x15B7030", Offset = "0x15B7030", VA = "0x15B7030")]
		public MA_TestUI()
		{
		}
	}
}
