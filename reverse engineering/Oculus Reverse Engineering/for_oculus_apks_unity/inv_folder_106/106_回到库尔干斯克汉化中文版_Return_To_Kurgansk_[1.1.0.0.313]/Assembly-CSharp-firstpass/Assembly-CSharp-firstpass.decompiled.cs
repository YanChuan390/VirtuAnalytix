using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class AFInAppEvents
{
	[Token(Token = "0x4000001")]
	public const string LEVEL_ACHIEVED = "af_level_achieved";

	[Token(Token = "0x4000002")]
	public const string ADD_PAYMENT_INFO = "af_add_payment_info";

	[Token(Token = "0x4000003")]
	public const string ADD_TO_CART = "af_add_to_cart";

	[Token(Token = "0x4000004")]
	public const string ADD_TO_WISH_LIST = "af_add_to_wishlist";

	[Token(Token = "0x4000005")]
	public const string COMPLETE_REGISTRATION = "af_complete_registration";

	[Token(Token = "0x4000006")]
	public const string TUTORIAL_COMPLETION = "af_tutorial_completion";

	[Token(Token = "0x4000007")]
	public const string INITIATED_CHECKOUT = "af_initiated_checkout";

	[Token(Token = "0x4000008")]
	public const string PURCHASE = "af_purchase";

	[Token(Token = "0x4000009")]
	public const string RATE = "af_rate";

	[Token(Token = "0x400000A")]
	public const string SEARCH = "af_search";

	[Token(Token = "0x400000B")]
	public const string SPENT_CREDIT = "af_spent_credits";

	[Token(Token = "0x400000C")]
	public const string ACHIEVEMENT_UNLOCKED = "af_achievement_unlocked";

	[Token(Token = "0x400000D")]
	public const string CONTENT_VIEW = "af_content_view";

	[Token(Token = "0x400000E")]
	public const string TRAVEL_BOOKING = "af_travel_booking";

	[Token(Token = "0x400000F")]
	public const string SHARE = "af_share";

	[Token(Token = "0x4000010")]
	public const string INVITE = "af_invite";

	[Token(Token = "0x4000011")]
	public const string LOGIN = "af_login";

	[Token(Token = "0x4000012")]
	public const string RE_ENGAGE = "af_re_engage";

	[Token(Token = "0x4000013")]
	public const string UPDATE = "af_update";

	[Token(Token = "0x4000014")]
	public const string OPENED_FROM_PUSH_NOTIFICATION = "af_opened_from_push_notification";

	[Token(Token = "0x4000015")]
	public const string LOCATION_CHANGED = "af_location_changed";

	[Token(Token = "0x4000016")]
	public const string LOCATION_COORDINATES = "af_location_coordinates";

	[Token(Token = "0x4000017")]
	public const string ORDER_ID = "af_order_id";

	[Token(Token = "0x4000018")]
	public const string LEVEL = "af_level";

	[Token(Token = "0x4000019")]
	public const string SCORE = "af_score";

	[Token(Token = "0x400001A")]
	public const string SUCCESS = "af_success";

	[Token(Token = "0x400001B")]
	public const string PRICE = "af_price";

	[Token(Token = "0x400001C")]
	public const string CONTENT_TYPE = "af_content_type";

	[Token(Token = "0x400001D")]
	public const string CONTENT_ID = "af_content_id";

	[Token(Token = "0x400001E")]
	public const string CONTENT_LIST = "af_content_list";

	[Token(Token = "0x400001F")]
	public const string CURRENCY = "af_currency";

	[Token(Token = "0x4000020")]
	public const string QUANTITY = "af_quantity";

	[Token(Token = "0x4000021")]
	public const string REGSITRATION_METHOD = "af_registration_method";

	[Token(Token = "0x4000022")]
	public const string PAYMENT_INFO_AVAILIBLE = "af_payment_info_available";

	[Token(Token = "0x4000023")]
	public const string MAX_RATING_VALUE = "af_max_rating_value";

	[Token(Token = "0x4000024")]
	public const string RATING_VALUE = "af_rating_value";

	[Token(Token = "0x4000025")]
	public const string SEARCH_STRING = "af_search_string";

	[Token(Token = "0x4000026")]
	public const string DATE_A = "af_date_a";

	[Token(Token = "0x4000027")]
	public const string DATE_B = "af_date_b";

	[Token(Token = "0x4000028")]
	public const string DESTINATION_A = "af_destination_a";

	[Token(Token = "0x4000029")]
	public const string DESTINATION_B = "af_destination_b";

	[Token(Token = "0x400002A")]
	public const string DESCRIPTION = "af_description";

	[Token(Token = "0x400002B")]
	public const string CLASS = "af_class";

	[Token(Token = "0x400002C")]
	public const string EVENT_START = "af_event_start";

	[Token(Token = "0x400002D")]
	public const string EVENT_END = "af_event_end";

	[Token(Token = "0x400002E")]
	public const string LATITUDE = "af_lat";

	[Token(Token = "0x400002F")]
	public const string LONGTITUDE = "af_long";

	[Token(Token = "0x4000030")]
	public const string CUSTOMER_USER_ID = "af_customer_user_id";

	[Token(Token = "0x4000031")]
	public const string VALIDATED = "af_validated";

	[Token(Token = "0x4000032")]
	public const string REVENUE = "af_revenue";

	[Token(Token = "0x4000033")]
	public const string RECEIPT_ID = "af_receipt_id";

	[Token(Token = "0x4000034")]
	public const string PARAM_1 = "af_param_1";

	[Token(Token = "0x4000035")]
	public const string PARAM_2 = "af_param_2";

	[Token(Token = "0x4000036")]
	public const string PARAM_3 = "af_param_3";

	[Token(Token = "0x4000037")]
	public const string PARAM_4 = "af_param_4";

	[Token(Token = "0x4000038")]
	public const string PARAM_5 = "af_param_5";

	[Token(Token = "0x4000039")]
	public const string PARAM_6 = "af_param_6";

	[Token(Token = "0x400003A")]
	public const string PARAM_7 = "af_param_7";

	[Token(Token = "0x400003B")]
	public const string PARAM_8 = "af_param_8";

	[Token(Token = "0x400003C")]
	public const string PARAM_9 = "af_param_9";

	[Token(Token = "0x400003D")]
	public const string PARAM_10 = "af_param_10";

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1C76094", Offset = "0x1C76094", VA = "0x1C76094")]
	public AFInAppEvents()
	{
	}
}
[Token(Token = "0x2000003")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0x84B968", Offset = "0x84B968")]
public class BlurEffect : MonoBehaviour
{
	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x18")]
	public int iterations;

	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x1C")]
	public float blurSpread;

	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x20")]
	public Shader blurShader;

	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x0")]
	private static Material m_Material;

	[Token(Token = "0x17000001")]
	protected Material material
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x1C76488", Offset = "0x1C76488", VA = "0x1C76488")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1C765DC", Offset = "0x1C765DC", VA = "0x1C765DC")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1C766E0", Offset = "0x1C766E0", VA = "0x1C766E0")]
	protected void Start()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1C7679C", Offset = "0x1C7679C", VA = "0x1C7679C")]
	public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1C768C0", Offset = "0x1C768C0", VA = "0x1C768C0")]
	private void DownSample4x(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1C769D0", Offset = "0x1C769D0", VA = "0x1C769D0")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1C76B38", Offset = "0x1C76B38", VA = "0x1C76B38")]
	public BlurEffect()
	{
	}
}
[Token(Token = "0x2000004")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0x84B9B4", Offset = "0x84B9B4")]
public class ColorCorrectionEffect : ImageEffectBase
{
	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x28")]
	public Texture textureRamp;

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1C76B54", Offset = "0x1C76B54", VA = "0x1C76B54")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1C76CF0", Offset = "0x1C76CF0", VA = "0x1C76CF0")]
	public ColorCorrectionEffect()
	{
	}
}
[Token(Token = "0x2000005")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0x84BA00", Offset = "0x84BA00")]
public class ContrastStretchEffect : MonoBehaviour
{
	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x18")]
	public float adaptationSpeed;

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x1C")]
	public float limitMinimum;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x20")]
	public float limitMaximum;

	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x28")]
	private RenderTexture[] adaptRenderTex;

	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x30")]
	private int curAdaptIndex;

	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x38")]
	public Shader shaderLum;

	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x40")]
	private Material m_materialLum;

	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x48")]
	public Shader shaderReduce;

	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x50")]
	private Material m_materialReduce;

	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x58")]
	public Shader shaderAdapt;

	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x60")]
	private Material m_materialAdapt;

	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x68")]
	public Shader shaderApply;

	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x70")]
	private Material m_materialApply;

	[Token(Token = "0x17000002")]
	protected Material materialLum
	{
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x1C79084", Offset = "0x1C79084", VA = "0x1C79084")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	protected Material materialReduce
	{
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x1C79160", Offset = "0x1C79160", VA = "0x1C79160")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	protected Material materialAdapt
	{
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x1C7923C", Offset = "0x1C7923C", VA = "0x1C7923C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000005")]
	protected Material materialApply
	{
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x1C79318", Offset = "0x1C79318", VA = "0x1C79318")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1C793F4", Offset = "0x1C793F4", VA = "0x1C793F4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1C79488", Offset = "0x1C79488", VA = "0x1C79488")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1C795E8", Offset = "0x1C795E8", VA = "0x1C795E8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1C79814", Offset = "0x1C79814", VA = "0x1C79814")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1C79A78", Offset = "0x1C79A78", VA = "0x1C79A78")]
	private void CalculateAdaptation(Texture curTexture)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1C79C74", Offset = "0x1C79C74", VA = "0x1C79C74")]
	public ContrastStretchEffect()
	{
	}
}
[Token(Token = "0x2000006")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0x84BA4C", Offset = "0x84BA4C")]
public class EdgeDetectEffect : ImageEffectBase
{
	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x28")]
	public float threshold;

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1C7CBEC", Offset = "0x1C7CBEC", VA = "0x1C7CBEC")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1C7CCB0", Offset = "0x1C7CCB0", VA = "0x1C7CCB0")]
	public EdgeDetectEffect()
	{
	}
}
[Token(Token = "0x2000007")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0x84BA98", Offset = "0x84BA98")]
[Attribute(Name = "AddComponentMenu", RVA = "0x84BA98", Offset = "0x84BA98")]
public class GlowEffect : MonoBehaviour
{
	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x18")]
	public float glowIntensity;

	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x1C")]
	public int blurIterations;

	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x20")]
	public float blurSpread;

	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x24")]
	public Color glowTint;

	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x38")]
	public Shader compositeShader;

	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x40")]
	private Material m_CompositeMaterial;

	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x48")]
	public Shader blurShader;

	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x50")]
	private Material m_BlurMaterial;

	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x58")]
	public Shader downsampleShader;

	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x60")]
	private Material m_DownsampleMaterial;

	[Token(Token = "0x17000006")]
	protected Material compositeMaterial
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1C7CCCC", Offset = "0x1C7CCCC", VA = "0x1C7CCCC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000007")]
	protected Material blurMaterial
	{
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1C7CDA8", Offset = "0x1C7CDA8", VA = "0x1C7CDA8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000008")]
	protected Material downsampleMaterial
	{
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1C7CE84", Offset = "0x1C7CE84", VA = "0x1C7CE84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1C7CF60", Offset = "0x1C7CF60", VA = "0x1C7CF60")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1C7D0B4", Offset = "0x1C7D0B4", VA = "0x1C7D0B4")]
	protected void Start()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1C7D22C", Offset = "0x1C7D22C", VA = "0x1C7D22C")]
	public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1C7D350", Offset = "0x1C7D350", VA = "0x1C7D350")]
	private void DownSample4x(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1C7D430", Offset = "0x1C7D430", VA = "0x1C7D430")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1C7D668", Offset = "0x1C7D668", VA = "0x1C7D668")]
	public void BlitGlow(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1C7D754", Offset = "0x1C7D754", VA = "0x1C7D754")]
	public GlowEffect()
	{
	}
}
[Token(Token = "0x2000008")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0x84BB2C", Offset = "0x84BB2C")]
public class GrayscaleEffect : ImageEffectBase
{
	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x28")]
	public Texture textureRamp;

	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x30")]
	public float rampOffset;

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1C7D7C4", Offset = "0x1C7D7C4", VA = "0x1C7D7C4")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1C7D8B4", Offset = "0x1C7D8B4", VA = "0x1C7D8B4")]
	public GrayscaleEffect()
	{
	}
}
[Token(Token = "0x2000009")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0x84BB78", Offset = "0x84BB78")]
[Attribute(Name = "RequireComponent", RVA = "0x84BB78", Offset = "0x84BB78")]
public class MotionBlur : ImageEffectBase
{
	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x28")]
	public float blurAmount;

	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x2C")]
	public bool extraBlur;

	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x30")]
	private RenderTexture accumTexture;

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1C7E2AC", Offset = "0x1C7E2AC", VA = "0x1C7E2AC", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1C7E2F0", Offset = "0x1C7E2F0", VA = "0x1C7E2F0", Slot = "5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1C7E360", Offset = "0x1C7E360", VA = "0x1C7E360")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1C7E6FC", Offset = "0x1C7E6FC", VA = "0x1C7E6FC")]
	public MotionBlur()
	{
	}
}
[Token(Token = "0x200000A")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0x84BC0C", Offset = "0x84BC0C")]
[Attribute(Name = "AddComponentMenu", RVA = "0x84BC0C", Offset = "0x84BC0C")]
public class NoiseEffect : MonoBehaviour
{
	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x18")]
	public bool monochrome;

	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x19")]
	private bool rgbFallback;

	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x1C")]
	public float grainIntensityMin;

	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x20")]
	public float grainIntensityMax;

	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x24")]
	public float grainSize;

	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x28")]
	public float scratchIntensityMin;

	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x2C")]
	public float scratchIntensityMax;

	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x30")]
	public float scratchFPS;

	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x34")]
	public float scratchJitter;

	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x38")]
	public Texture grainTexture;

	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0x40")]
	public Texture scratchTexture;

	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0x48")]
	public Shader shaderRGB;

	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x50")]
	public Shader shaderYUV;

	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x58")]
	private Material m_MaterialRGB;

	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x60")]
	private Material m_MaterialYUV;

	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x68")]
	private float scratchTimeLeft;

	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x6C")]
	private float scratchX;

	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x70")]
	private float scratchY;

	[Token(Token = "0x17000009")]
	protected Material material
	{
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1C7EB24", Offset = "0x1C7EB24", VA = "0x1C7EB24")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1C7E9D0", Offset = "0x1C7E9D0", VA = "0x1C7E9D0")]
	protected void Start()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1C7ECA0", Offset = "0x1C7ECA0", VA = "0x1C7ECA0")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1C7EDA0", Offset = "0x1C7EDA0", VA = "0x1C7EDA0")]
	private void SanitizeParameters()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1C7EE94", Offset = "0x1C7EE94", VA = "0x1C7EE94")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1C7F214", Offset = "0x1C7F214", VA = "0x1C7F214")]
	public NoiseEffect()
	{
	}
}
[Token(Token = "0x200000B")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0x84BCA0", Offset = "0x84BCA0")]
[Attribute(Name = "AddComponentMenu", RVA = "0x84BCA0", Offset = "0x84BCA0")]
public class SSAOEffect : MonoBehaviour
{
	[Token(Token = "0x2000021")]
	public enum SSAOSamples
	{
		[Token(Token = "0x40000F1")]
		Low,
		[Token(Token = "0x40000F2")]
		Medium,
		[Token(Token = "0x40000F3")]
		High
	}

	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x18")]
	public float m_Radius;

	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x1C")]
	public SSAOSamples m_SampleCount;

	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x20")]
	public float m_OcclusionIntensity;

	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x24")]
	public int m_Blur;

	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x28")]
	public int m_Downsampling;

	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x2C")]
	public float m_OcclusionAttenuation;

	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x30")]
	public float m_MinZ;

	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x38")]
	public Shader m_SSAOShader;

	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x40")]
	private Material m_SSAOMaterial;

	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x48")]
	public Texture2D m_RandomTexture;

	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x50")]
	private bool m_Supported;

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1C809C4", Offset = "0x1C809C4", VA = "0x1C809C4")]
	private static Material CreateMaterial(Shader shader)
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1C80A7C", Offset = "0x1C80A7C", VA = "0x1C80A7C")]
	private static void DestroyMaterial(Material mat)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1C80B14", Offset = "0x1C80B14", VA = "0x1C80B14")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1C80B1C", Offset = "0x1C80B1C", VA = "0x1C80B1C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1C80CD4", Offset = "0x1C80CD4", VA = "0x1C80CD4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1C80BF0", Offset = "0x1C80BF0", VA = "0x1C80BF0")]
	private void CreateMaterials()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1C80D44", Offset = "0x1C80D44", VA = "0x1C80D44")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1C813BC", Offset = "0x1C813BC", VA = "0x1C813BC")]
	public SSAOEffect()
	{
	}
}
[Token(Token = "0x200000C")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0x84BD34", Offset = "0x84BD34")]
public class SepiaToneEffect : ImageEffectBase
{
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1C813F0", Offset = "0x1C813F0", VA = "0x1C813F0")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1C8147C", Offset = "0x1C8147C", VA = "0x1C8147C")]
	public SepiaToneEffect()
	{
	}
}
[Token(Token = "0x200000D")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0x84BD80", Offset = "0x84BD80")]
public class TwirlEffect : ImageEffectBase
{
	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 radius;

	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0x30")]
	public float angle;

	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 center;

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1C817C4", Offset = "0x1C817C4", VA = "0x1C817C4")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1C81808", Offset = "0x1C81808", VA = "0x1C81808")]
	public TwirlEffect()
	{
	}
}
[Token(Token = "0x200000E")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0x84BDCC", Offset = "0x84BDCC")]
public class VortexEffect : ImageEffectBase
{
	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 radius;

	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x30")]
	public float angle;

	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 center;

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1C81824", Offset = "0x1C81824", VA = "0x1C81824")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x1C81868", Offset = "0x1C81868", VA = "0x1C81868")]
	public VortexEffect()
	{
	}
}
[Token(Token = "0x200000F")]
[Attribute(Name = "AddComponentMenu", RVA = "0x84BE18", Offset = "0x84BE18")]
public class MouseLook : MonoBehaviour
{
	[Token(Token = "0x2000022")]
	public enum RotationAxes
	{
		[Token(Token = "0x40000F5")]
		MouseXAndY,
		[Token(Token = "0x40000F6")]
		MouseX,
		[Token(Token = "0x40000F7")]
		MouseY
	}

	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x18")]
	public RotationAxes axes;

	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x1C")]
	public float sensitivityX;

	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x20")]
	public float sensitivityY;

	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0x24")]
	public float minimumX;

	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0x28")]
	public float maximumX;

	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x2C")]
	public float minimumY;

	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0x30")]
	public float maximumY;

	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x34")]
	private float rotationY;

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1C7E710", Offset = "0x1C7E710", VA = "0x1C7E710")]
	private void Update()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1C7E8E8", Offset = "0x1C7E8E8", VA = "0x1C7E8E8")]
	private void Start()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x1C7E9B0", Offset = "0x1C7E9B0", VA = "0x1C7E9B0")]
	public MouseLook()
	{
	}
}
[Token(Token = "0x2000010")]
public class Decal : MonoBehaviour
{
	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x18")]
	public bool isCreate;

	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x0")]
	public static int dCount;

	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public GameObject[] affectedObjects;

	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x28")]
	public float maxAngle;

	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x2C")]
	private float angleCosine;

	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Bounds bounds;

	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public float previousUVAngle;

	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x4C")]
	[HideInInspector]
	public Vector3 previousPosition;

	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public Quaternion previousRotation;

	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public Vector3 previousScale;

	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x74")]
	[HideInInspector]
	public float previousMaxAngle;

	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x78")]
	[HideInInspector]
	public float previousPushDistance;

	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0x7C")]
	[HideInInspector]
	public Vector2 previousTiling;

	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x84")]
	[HideInInspector]
	public Vector2 previousOffset;

	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0x8C")]
	[HideInInspector]
	public bool useMeshCollider;

	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x90")]
	public Vector2 tiling;

	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0x98")]
	public Vector2 offset;

	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	public float uvAngle;

	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0xA4")]
	private float uCos;

	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0xA8")]
	private float vSin;

	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0xB0")]
	public Material decalMaterial;

	[Token(Token = "0x40000A0")]
	[FieldOffset(Offset = "0xB8")]
	[HideInInspector]
	public DecalMode decalMode;

	[Token(Token = "0x40000A1")]
	[FieldOffset(Offset = "0xC0")]
	private List<DecalPolygon> startPolygons;

	[Token(Token = "0x40000A2")]
	[FieldOffset(Offset = "0xC8")]
	private List<DecalPolygon> clippedPolygons;

	[Token(Token = "0x40000A3")]
	[FieldOffset(Offset = "0xD0")]
	[HideInInspector]
	public Vector4 bottomPlane;

	[Token(Token = "0x40000A4")]
	[FieldOffset(Offset = "0xE0")]
	[HideInInspector]
	public Vector4 topPlane;

	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0xF0")]
	[HideInInspector]
	public Vector4 leftPlane;

	[Token(Token = "0x40000A6")]
	[FieldOffset(Offset = "0x100")]
	[HideInInspector]
	public Vector4 rightPlane;

	[Token(Token = "0x40000A7")]
	[FieldOffset(Offset = "0x110")]
	[HideInInspector]
	public Vector4 frontPlane;

	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0x120")]
	[HideInInspector]
	public Vector4 backPlane;

	[Token(Token = "0x40000A9")]
	[FieldOffset(Offset = "0x130")]
	[HideInInspector]
	public Vector3 decalNormal;

	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x13C")]
	[HideInInspector]
	public Vector3 decalCenter;

	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0x148")]
	[HideInInspector]
	public Vector3 decalTangent;

	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0x154")]
	[HideInInspector]
	public Vector3 decalBinormal;

	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0x160")]
	[HideInInspector]
	public Vector3 decalSize;

	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0x16C")]
	public float pushDistance;

	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0x170")]
	private List<MeshCombineUtility.MeshInstance> instancesList;

	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0x178")]
	public bool checkAutomatically;

	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0x17C")]
	public LayerMask affectedLayers;

	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0x180")]
	public bool affectOtherDecals;

	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0x181")]
	public bool affectInactiveRenderers;

	[Token(Token = "0x40000B4")]
	[FieldOffset(Offset = "0x182")]
	[HideInInspector]
	public bool showAffectedObjectsOptions;

	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x183")]
	[HideInInspector]
	public bool showObjects;

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x1C79CF4", Offset = "0x1C79CF4", VA = "0x1C79CF4")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x1C79DA4", Offset = "0x1C79DA4", VA = "0x1C79DA4")]
	public void CalculateBounds()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x1C79E58", Offset = "0x1C79E58", VA = "0x1C79E58")]
	public void CalculateDecal()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1C7AAAC", Offset = "0x1C7AAAC", VA = "0x1C7AAAC")]
	public void ClearDecals()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x1C7AC34", Offset = "0x1C7AC34", VA = "0x1C7AC34")]
	public void CalculateObjectDecal(GameObject obj, Matrix4x4 cTransform)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1C7BA94", Offset = "0x1C7BA94", VA = "0x1C7BA94")]
	private Mesh CreateMesh(int totalVertices, Transform to)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x1C7B8CC", Offset = "0x1C7B8CC", VA = "0x1C7B8CC")]
	private int ClipMesh()
	{
		return default(int);
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1C7C890", Offset = "0x1C7C890", VA = "0x1C7C890")]
	public bool HasChanged()
	{
		return default(bool);
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x1C7CA9C", Offset = "0x1C7CA9C", VA = "0x1C7CA9C")]
	public Decal()
	{
	}
}
[Token(Token = "0x2000011")]
public enum DecalMode
{
	[Token(Token = "0x40000B7")]
	MESH_COLLIDER,
	[Token(Token = "0x40000B8")]
	MESH_FILTER
}
[Token(Token = "0x2000012")]
public class DecalPolygon
{
	[Token(Token = "0x40000B9")]
	[FieldOffset(Offset = "0x10")]
	public int verticeCount;

	[Token(Token = "0x40000BA")]
	[FieldOffset(Offset = "0x18")]
	public Vector3[] normal;

	[Token(Token = "0x40000BB")]
	[FieldOffset(Offset = "0x20")]
	public Vector3[] vertice;

	[Token(Token = "0x40000BC")]
	[FieldOffset(Offset = "0x28")]
	public Vector4[] tangent;

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1C7B814", Offset = "0x1C7B814", VA = "0x1C7B814")]
	public DecalPolygon()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x1C7C078", Offset = "0x1C7C078", VA = "0x1C7C078")]
	public static DecalPolygon ClipPolygonAgainstPlane(DecalPolygon polygon, Vector4 plane)
	{
		return null;
	}
}
[Token(Token = "0x2000013")]
[Attribute(Name = "AddComponentMenu", RVA = "0x84BE50", Offset = "0x84BE50")]
public class CombineChildren : MonoBehaviour
{
	[Token(Token = "0x40000BD")]
	[FieldOffset(Offset = "0x18")]
	public bool generateTriangleStrips;

	[Token(Token = "0x40000BE")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> currentMeshes;

	[Token(Token = "0x40000BF")]
	[FieldOffset(Offset = "0x28")]
	public List<Renderer> allRenderers;

	[Token(Token = "0x40000C0")]
	[FieldOffset(Offset = "0x30")]
	public bool combineAtStart;

	[Token(Token = "0x40000C1")]
	[FieldOffset(Offset = "0x31")]
	public bool destroyOnDisable;

	[Token(Token = "0x40000C2")]
	[FieldOffset(Offset = "0x32")]
	[HideInInspector]
	public bool areaCombine;

	[Token(Token = "0x40000C3")]
	[FieldOffset(Offset = "0x33")]
	public bool removeColliders;

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1C76D00", Offset = "0x1C76D00", VA = "0x1C76D00")]
	private void Start()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1C77DBC", Offset = "0x1C77DBC", VA = "0x1C77DBC")]
	public void DisableCombine()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1C76D10", Offset = "0x1C76D10", VA = "0x1C76D10")]
	public void Combine()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1C79074", Offset = "0x1C79074", VA = "0x1C79074")]
	public CombineChildren()
	{
	}
}
[Token(Token = "0x2000014")]
public class ActivateTrigger : MonoBehaviour
{
	[Token(Token = "0x2000023")]
	public enum Mode
	{
		[Token(Token = "0x40000F9")]
		Trigger,
		[Token(Token = "0x40000FA")]
		Replace,
		[Token(Token = "0x40000FB")]
		Activate,
		[Token(Token = "0x40000FC")]
		Enable,
		[Token(Token = "0x40000FD")]
		Animate,
		[Token(Token = "0x40000FE")]
		Deactivate
	}

	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0x18")]
	public Mode action;

	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0x20")]
	public Object target;

	[Token(Token = "0x40000C6")]
	[FieldOffset(Offset = "0x28")]
	public GameObject source;

	[Token(Token = "0x40000C7")]
	[FieldOffset(Offset = "0x30")]
	public int triggerCount;

	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0x34")]
	public bool repeatTrigger;

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1C7609C", Offset = "0x1C7609C", VA = "0x1C7609C")]
	private void DoActivateTrigger()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x1C7646C", Offset = "0x1C7646C", VA = "0x1C7646C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1C76470", Offset = "0x1C76470", VA = "0x1C76470")]
	public ActivateTrigger()
	{
	}
}
[Token(Token = "0x2000015")]
public class MeshCombineUtility
{
	[Token(Token = "0x2000024")]
	public struct MeshInstance
	{
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x0")]
		public Mesh mesh;

		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x8")]
		public int subMeshIndex;

		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0xC")]
		public Matrix4x4 transform;
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1C782C0", Offset = "0x1C782C0", VA = "0x1C782C0")]
	public static Mesh Combine(MeshInstance[] combines, bool generateStrips)
	{
		return null;
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x1C7DD58", Offset = "0x1C7DD58", VA = "0x1C7DD58")]
	private static void Copy(int vertexcount, Vector3[] src, Vector3[] dst, ref int offset, Matrix4x4 transform)
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1C7DE38", Offset = "0x1C7DE38", VA = "0x1C7DE38")]
	private static void CopyNormal(int vertexcount, Vector3[] src, Vector3[] dst, ref int offset, Matrix4x4 transform)
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1C7E04C", Offset = "0x1C7E04C", VA = "0x1C7E04C")]
	private static void Copy(int vertexcount, Vector2[] src, Vector2[] dst, ref int offset)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1C7E0D0", Offset = "0x1C7E0D0", VA = "0x1C7E0D0")]
	private static void CopyUV2(int vertexcount, Vector2[] src, Vector2[] dst, ref int offset, float influence, float x)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x1C7E168", Offset = "0x1C7E168", VA = "0x1C7E168")]
	private static void CopyColors(int vertexcount, Color[] src, Color[] dst, ref int offset)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1C7DF3C", Offset = "0x1C7DF3C", VA = "0x1C7DF3C")]
	private static void CopyTangents(int vertexcount, Vector4[] src, Vector4[] dst, ref int offset, Matrix4x4 transform)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1C7E1EC", Offset = "0x1C7E1EC", VA = "0x1C7E1EC")]
	public MeshCombineUtility()
	{
	}
}
namespace UnityStandardAssets.Water
{
	[Token(Token = "0x2000016")]
	[ExecuteInEditMode]
	public class Water : MonoBehaviour
	{
		[Token(Token = "0x2000025")]
		public enum WaterMode
		{
			[Token(Token = "0x4000103")]
			Simple,
			[Token(Token = "0x4000104")]
			Reflective,
			[Token(Token = "0x4000105")]
			Refractive
		}

		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x18")]
		public WaterMode waterMode;

		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x1C")]
		public bool disablePixelLights;

		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x20")]
		public int textureSize;

		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x24")]
		public float clipPlaneOffset;

		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x28")]
		public LayerMask reflectLayers;

		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x2C")]
		public LayerMask refractLayers;

		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<Camera, Camera> m_ReflectionCameras;

		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<Camera, Camera> m_RefractionCameras;

		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x40")]
		private RenderTexture m_ReflectionTexture;

		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x48")]
		private RenderTexture m_RefractionTexture;

		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x50")]
		private WaterMode m_HardwareWaterSupport;

		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x54")]
		private int m_OldReflectionTextureSize;

		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x58")]
		private int m_OldRefractionTextureSize;

		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x0")]
		private static bool s_InsideWater;

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1C81884", Offset = "0x1C81884", VA = "0x1C81884")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1C8339C", Offset = "0x1C8339C", VA = "0x1C8339C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1C83734", Offset = "0x1C83734", VA = "0x1C83734")]
		private void Update()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1C82D68", Offset = "0x1C82D68", VA = "0x1C82D68")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1C823BC", Offset = "0x1C823BC", VA = "0x1C823BC")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1C823A8", Offset = "0x1C823A8", VA = "0x1C823A8")]
		private WaterMode GetWaterMode()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1C82234", Offset = "0x1C82234", VA = "0x1C82234")]
		private WaterMode FindHardwareWaterSupport()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1C83270", Offset = "0x1C83270", VA = "0x1C83270")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1C82FCC", Offset = "0x1C82FCC", VA = "0x1C82FCC")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1C83A04", Offset = "0x1C83A04", VA = "0x1C83A04")]
		public Water()
		{
		}
	}
	[Token(Token = "0x2000017")]
	[ExecuteInEditMode]
	[Attribute(Name = "RequireComponent", RVA = "0x84BE98", Offset = "0x84BE98")]
	public class Displace : MonoBehaviour
	{
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1C7CAF0", Offset = "0x1C7CAF0", VA = "0x1C7CAF0")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1C7CB14", Offset = "0x1C7CB14", VA = "0x1C7CB14")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1C7CB7C", Offset = "0x1C7CB7C", VA = "0x1C7CB7C")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1C7CBE4", Offset = "0x1C7CBE4", VA = "0x1C7CBE4")]
		public Displace()
		{
		}
	}
	[Token(Token = "0x2000018")]
	[ExecuteInEditMode]
	[Attribute(Name = "RequireComponent", RVA = "0x84BF08", Offset = "0x84BF08")]
	public class GerstnerDisplace : Displace
	{
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1C7CCC4", Offset = "0x1C7CCC4", VA = "0x1C7CCC4")]
		public GerstnerDisplace()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class MeshContainer
	{
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x10")]
		public Mesh mesh;

		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x18")]
		public Vector3[] vertices;

		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x20")]
		public Vector3[] normals;

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1C7E1F4", Offset = "0x1C7E1F4", VA = "0x1C7E1F4")]
		public MeshContainer(Mesh m)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1C7E268", Offset = "0x1C7E268", VA = "0x1C7E268")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x200001A")]
	[ExecuteInEditMode]
	[Attribute(Name = "RequireComponent", RVA = "0x84BF78", Offset = "0x84BF78")]
	public class PlanarReflection : MonoBehaviour
	{
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x18")]
		public LayerMask reflectionMask;

		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x1C")]
		public bool reflectSkybox;

		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x20")]
		public Color clearColor;

		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x30")]
		public string reflectionSampler;

		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x38")]
		public float clipPlaneOffset;

		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 m_Oldpos;

		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x48")]
		private Camera m_ReflectionCamera;

		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x50")]
		private Material m_SharedMaterial;

		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<Camera, bool> m_HelperCameras;

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1C7F248", Offset = "0x1C7F248", VA = "0x1C7F248")]
		public void Start()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1C7F350", Offset = "0x1C7F350", VA = "0x1C7F350")]
		private Camera CreateReflectionCameraFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1C7F6A8", Offset = "0x1C7F6A8", VA = "0x1C7F6A8")]
		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1C7F758", Offset = "0x1C7F758", VA = "0x1C7F758")]
		private RenderTexture CreateTextureFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1C7F834", Offset = "0x1C7F834", VA = "0x1C7F834")]
		public void RenderHelpCameras(Camera currentCam)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1C80100", Offset = "0x1C80100", VA = "0x1C80100")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1C8015C", Offset = "0x1C8015C", VA = "0x1C8015C")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1C80250", Offset = "0x1C80250", VA = "0x1C80250")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1C802B8", Offset = "0x1C802B8", VA = "0x1C802B8")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1C7F9F8", Offset = "0x1C7F9F8", VA = "0x1C7F9F8")]
		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1C80320", Offset = "0x1C80320", VA = "0x1C80320")]
		private void SaneCameraSettings(Camera helperCam)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1C80768", Offset = "0x1C80768", VA = "0x1C80768")]
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1C80384", Offset = "0x1C80384", VA = "0x1C80384")]
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1C8092C", Offset = "0x1C8092C", VA = "0x1C8092C")]
		private static float Sgn(float a)
		{
			return default(float);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1C8063C", Offset = "0x1C8063C", VA = "0x1C8063C")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1C8094C", Offset = "0x1C8094C", VA = "0x1C8094C")]
		public PlanarReflection()
		{
		}
	}
	[Token(Token = "0x200001B")]
	[Attribute(Name = "RequireComponent", RVA = "0x84BFE8", Offset = "0x84BFE8")]
	[ExecuteInEditMode]
	public class SpecularLighting : MonoBehaviour
	{
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x18")]
		public Transform specularLight;

		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x20")]
		private WaterBase m_WaterBase;

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1C81484", Offset = "0x1C81484", VA = "0x1C81484")]
		public void Start()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1C81594", Offset = "0x1C81594", VA = "0x1C81594")]
		public void Update()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1C817BC", Offset = "0x1C817BC", VA = "0x1C817BC")]
		public SpecularLighting()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public enum WaterQuality
	{
		[Token(Token = "0x40000E6")]
		High = 2,
		[Token(Token = "0x40000E7")]
		Medium = 1,
		[Token(Token = "0x40000E8")]
		Low = 0
	}
	[Token(Token = "0x200001D")]
	[ExecuteInEditMode]
	public class WaterBase : MonoBehaviour
	{
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x18")]
		public Material sharedMaterial;

		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x20")]
		public WaterQuality waterQuality;

		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x24")]
		public bool edgeBlend;

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1C83B00", Offset = "0x1C83B00", VA = "0x1C83B00")]
		public void UpdateShader()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1C83C94", Offset = "0x1C83C94", VA = "0x1C83C94")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1C83D44", Offset = "0x1C83D44", VA = "0x1C83D44")]
		public void Update()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1C83DC4", Offset = "0x1C83DC4", VA = "0x1C83DC4")]
		public WaterBase()
		{
		}
	}
	[Token(Token = "0x200001E")]
	[ExecuteInEditMode]
	public class WaterTile : MonoBehaviour
	{
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x18")]
		public PlanarReflection reflection;

		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x20")]
		public WaterBase waterBase;

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1C83DDC", Offset = "0x1C83DDC", VA = "0x1C83DDC")]
		public void Start()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1C83DE0", Offset = "0x1C83DE0", VA = "0x1C83DE0")]
		private void AcquireComponents()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1C83FC4", Offset = "0x1C83FC4", VA = "0x1C83FC4")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1C840C8", Offset = "0x1C840C8", VA = "0x1C840C8")]
		public WaterTile()
		{
		}
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x200001F")]
	[Attribute(Name = "RequireComponent", RVA = "0x84C078", Offset = "0x84C078")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x84C078", Offset = "0x84C078")]
	public class ImageEffectBase : MonoBehaviour
	{
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x18")]
		public Shader shader;

		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x1700000A")]
		protected Material material
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x1C76C14", Offset = "0x1C76C14", VA = "0x1C76C14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1C7D8BC", Offset = "0x1C7D8BC", VA = "0x1C7D8BC", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1C7D968", Offset = "0x1C7D968", VA = "0x1C7D968", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1C76CF8", Offset = "0x1C76CF8", VA = "0x1C76CF8")]
		public ImageEffectBase()
		{
		}
	}
	[Token(Token = "0x2000020")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x84C0FC", Offset = "0x84C0FC")]
	public class ImageEffects
	{
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1C7DA14", Offset = "0x1C7DA14", VA = "0x1C7DA14")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1C7DC60", Offset = "0x1C7DC60", VA = "0x1C7DC60")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x84C2F4", Offset = "0x84C2F4")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1C7DCD4", Offset = "0x1C7DCD4", VA = "0x1C7DCD4")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x84C32C", Offset = "0x84C32C")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1C7DD50", Offset = "0x1C7DD50", VA = "0x1C7DD50")]
		public ImageEffects()
		{
		}
	}
}
