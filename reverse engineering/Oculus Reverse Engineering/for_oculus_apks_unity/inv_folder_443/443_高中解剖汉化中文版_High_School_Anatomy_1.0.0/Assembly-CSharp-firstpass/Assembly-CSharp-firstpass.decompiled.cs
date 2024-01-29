using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using Google.Play.Billing;
using Google.Play.Billing.Internal;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;

[assembly: AssemblyVersion("3.7.1.6")]
namespace VE.IAP
{
	[Token(Token = "0x2000002")]
	public interface IPurchaseController
	{
		[Token(Token = "0x14000001")]
		event Action<string> PurchaseSuccessful;

		[Token(Token = "0x14000002")]
		event Action<string> PurchaseFailed;

		[Token(Token = "0x14000003")]
		event Action Initialized;

		[Token(Token = "0x6000007")]
		void InitiatePurchase(string productId);

		[Token(Token = "0x6000008")]
		Subscription GetSubscription(string productId);

		[Token(Token = "0x6000009")]
		Product GetProduct(string productId);

		[Token(Token = "0x600000A")]
		bool IsInitialized();

		[Token(Token = "0x600000B")]
		bool IsPurchased(string productId);

		[Token(Token = "0x600000C")]
		bool IsSubscribed(string productId);

		[Token(Token = "0x600000D")]
		void RestoreTransactions(Action<bool> callback);
	}
	[Token(Token = "0x2000003")]
	public class Product
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9943D8", Offset = "0x9943D8")]
		private string <Id>k__BackingField;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9943E8", Offset = "0x9943E8")]
		private string <Title>k__BackingField;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9943F8", Offset = "0x9943F8")]
		private string <Description>k__BackingField;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994408", Offset = "0x994408")]
		private decimal <Price>k__BackingField;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994418", Offset = "0x994418")]
		private string <PriceString>k__BackingField;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994428", Offset = "0x994428")]
		private decimal <OriginalPrice>k__BackingField;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994438", Offset = "0x994438")]
		private string <OriginalPriceString>k__BackingField;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994448", Offset = "0x994448")]
		private string <Currency>k__BackingField;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994458", Offset = "0x994458")]
		private string <IconUrl>k__BackingField;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994468", Offset = "0x994468")]
		private Receipt <Receipt>k__BackingField;

		[Token(Token = "0x17000001")]
		public string Id
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x2143210", Offset = "0x2143210", VA = "0x2143210")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994698", Offset = "0x994698")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x2143218", Offset = "0x2143218", VA = "0x2143218")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9946A8", Offset = "0x9946A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public string Title
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x2143220", Offset = "0x2143220", VA = "0x2143220")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9946B8", Offset = "0x9946B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x2143228", Offset = "0x2143228", VA = "0x2143228")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9946C8", Offset = "0x9946C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public string Description
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x2143230", Offset = "0x2143230", VA = "0x2143230")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9946D8", Offset = "0x9946D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x2143238", Offset = "0x2143238", VA = "0x2143238")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9946E8", Offset = "0x9946E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public decimal Price
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x2143240", Offset = "0x2143240", VA = "0x2143240")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9946F8", Offset = "0x9946F8")]
			get
			{
				return default(decimal);
			}
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x214324C", Offset = "0x214324C", VA = "0x214324C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994708", Offset = "0x994708")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public string PriceString
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x2143254", Offset = "0x2143254", VA = "0x2143254")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994718", Offset = "0x994718")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x214325C", Offset = "0x214325C", VA = "0x214325C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994728", Offset = "0x994728")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public decimal OriginalPrice
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x2143264", Offset = "0x2143264", VA = "0x2143264")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994738", Offset = "0x994738")]
			get
			{
				return default(decimal);
			}
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x2143270", Offset = "0x2143270", VA = "0x2143270")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994748", Offset = "0x994748")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public string OriginalPriceString
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x2143278", Offset = "0x2143278", VA = "0x2143278")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994758", Offset = "0x994758")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x2143280", Offset = "0x2143280", VA = "0x2143280")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994768", Offset = "0x994768")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public string Currency
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x2143288", Offset = "0x2143288", VA = "0x2143288")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994778", Offset = "0x994778")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x2143290", Offset = "0x2143290", VA = "0x2143290")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994788", Offset = "0x994788")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public string IconUrl
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x2143298", Offset = "0x2143298", VA = "0x2143298")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994798", Offset = "0x994798")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x21432A0", Offset = "0x21432A0", VA = "0x21432A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9947A8", Offset = "0x9947A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public Receipt Receipt
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x21432A8", Offset = "0x21432A8", VA = "0x21432A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9947B8", Offset = "0x9947B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x21432B0", Offset = "0x21432B0", VA = "0x21432B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9947C8", Offset = "0x9947C8")]
			set
			{
			}
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x21432B8", Offset = "0x21432B8", VA = "0x21432B8")]
		public Product()
		{
		}
	}
	[Token(Token = "0x2000004")]
	public class Receipt
	{
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994478", Offset = "0x994478")]
		private string <ProductId>k__BackingField;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994488", Offset = "0x994488")]
		private DateTime <OriginalPurchaseDate>k__BackingField;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994498", Offset = "0x994498")]
		private DateTime <PurchaseDate>k__BackingField;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9944A8", Offset = "0x9944A8")]
		private int <Quantity>k__BackingField;

		[Token(Token = "0x1700000B")]
		public string ProductId
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x2146150", Offset = "0x2146150", VA = "0x2146150")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9947D8", Offset = "0x9947D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x2146158", Offset = "0x2146158", VA = "0x2146158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9947E8", Offset = "0x9947E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public DateTime OriginalPurchaseDate
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x2146160", Offset = "0x2146160", VA = "0x2146160")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9947F8", Offset = "0x9947F8")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x2146168", Offset = "0x2146168", VA = "0x2146168")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994808", Offset = "0x994808")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public DateTime PurchaseDate
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x2146170", Offset = "0x2146170", VA = "0x2146170")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994818", Offset = "0x994818")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x2146178", Offset = "0x2146178", VA = "0x2146178")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994828", Offset = "0x994828")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public int Quantity
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x2146180", Offset = "0x2146180", VA = "0x2146180")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994838", Offset = "0x994838")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x2146188", Offset = "0x2146188", VA = "0x2146188")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994848", Offset = "0x994848")]
			set
			{
			}
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2139108", Offset = "0x2139108", VA = "0x2139108")]
		public Receipt()
		{
		}
	}
	[Token(Token = "0x2000005")]
	public enum SubscriptionPeriod
	{
		[Token(Token = "0x4000010")]
		Undefined,
		[Token(Token = "0x4000011")]
		Weekly,
		[Token(Token = "0x4000012")]
		Every4Weeks,
		[Token(Token = "0x4000013")]
		Monthly,
		[Token(Token = "0x4000014")]
		Every3Months,
		[Token(Token = "0x4000015")]
		Every6Months,
		[Token(Token = "0x4000016")]
		Yearly
	}
	[Token(Token = "0x2000006")]
	public class Subscription : Product
	{
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9944B8", Offset = "0x9944B8")]
		private TimeSpan <Period>k__BackingField;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9944C8", Offset = "0x9944C8")]
		private bool <HasFreeTrial>k__BackingField;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9944D8", Offset = "0x9944D8")]
		private TimeSpan <FreeTrialPeriod>k__BackingField;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9944E8", Offset = "0x9944E8")]
		private TimeSpan <RemainingTime>k__BackingField;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9944F8", Offset = "0x9944F8")]
		private decimal <IntroductoryPrice>k__BackingField;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994508", Offset = "0x994508")]
		private TimeSpan <IntroductoryPricePeriod>k__BackingField;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994518", Offset = "0x994518")]
		private string <IntroductoryPriceString>k__BackingField;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994528", Offset = "0x994528")]
		private long <IntroductoryPriceCycles>k__BackingField;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994538", Offset = "0x994538")]
		private DateTime <ExpireDate>k__BackingField;

		[Token(Token = "0x1700000F")]
		public TimeSpan Period
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x2146428", Offset = "0x2146428", VA = "0x2146428")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994858", Offset = "0x994858")]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x2146430", Offset = "0x2146430", VA = "0x2146430")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994868", Offset = "0x994868")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public bool HasFreeTrial
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x2146438", Offset = "0x2146438", VA = "0x2146438")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994878", Offset = "0x994878")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x2146440", Offset = "0x2146440", VA = "0x2146440")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994888", Offset = "0x994888")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public TimeSpan FreeTrialPeriod
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x214644C", Offset = "0x214644C", VA = "0x214644C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994898", Offset = "0x994898")]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x2146454", Offset = "0x2146454", VA = "0x2146454")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9948A8", Offset = "0x9948A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public TimeSpan RemainingTime
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x214645C", Offset = "0x214645C", VA = "0x214645C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9948B8", Offset = "0x9948B8")]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x2146464", Offset = "0x2146464", VA = "0x2146464")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9948C8", Offset = "0x9948C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public decimal IntroductoryPrice
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x214646C", Offset = "0x214646C", VA = "0x214646C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9948D8", Offset = "0x9948D8")]
			get
			{
				return default(decimal);
			}
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x2146478", Offset = "0x2146478", VA = "0x2146478")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9948E8", Offset = "0x9948E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public TimeSpan IntroductoryPricePeriod
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x2146480", Offset = "0x2146480", VA = "0x2146480")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9948F8", Offset = "0x9948F8")]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x2146488", Offset = "0x2146488", VA = "0x2146488")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994908", Offset = "0x994908")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public string IntroductoryPriceString
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x2146490", Offset = "0x2146490", VA = "0x2146490")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994918", Offset = "0x994918")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x2146498", Offset = "0x2146498", VA = "0x2146498")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994928", Offset = "0x994928")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public long IntroductoryPriceCycles
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x21464A0", Offset = "0x21464A0", VA = "0x21464A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994938", Offset = "0x994938")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x21464A8", Offset = "0x21464A8", VA = "0x21464A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994948", Offset = "0x994948")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public DateTime ExpireDate
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x21464B0", Offset = "0x21464B0", VA = "0x21464B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994958", Offset = "0x994958")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x21464B8", Offset = "0x21464B8", VA = "0x21464B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994968", Offset = "0x994968")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public int MonthsCount
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x21464C0", Offset = "0x21464C0", VA = "0x21464C0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000019")]
		public SubscriptionPeriod SubscriptionPeriod
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x2146508", Offset = "0x2146508", VA = "0x2146508")]
			get
			{
				return default(SubscriptionPeriod);
			}
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2137704", Offset = "0x2137704", VA = "0x2137704")]
		public Subscription()
		{
		}
	}
}
namespace VE.IAP.View
{
	[Token(Token = "0x2000007")]
	public interface IPurchaseModalView
	{
		[Token(Token = "0x14000004")]
		event Action<string> Confirmed;

		[Token(Token = "0x14000005")]
		event Action<string> Declined;

		[Token(Token = "0x6000045")]
		void DisplayPurchaseModal(Product product);

		[Token(Token = "0x6000046")]
		void DisplayPurchaseModal(Subscription subscription);

		[Token(Token = "0x6000047")]
		void ClosePurchaseModal();
	}
	[Token(Token = "0x2000008")]
	public class PurchaseControllerView
	{
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x10")]
		public readonly IPurchaseController PurchaseController;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x18")]
		public readonly IPurchaseModalView PurchaseModalView;

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2145A18", Offset = "0x2145A18", VA = "0x2145A18")]
		public PurchaseControllerView(IPurchaseController purchaseController, IPurchaseModalView purchaseModalView)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2145C08", Offset = "0x2145C08", VA = "0x2145C08")]
		private void OnPurchaseModalViewDeclined(string productId)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2145CB8", Offset = "0x2145CB8", VA = "0x2145CB8")]
		private void OnPurchaseModalViewConfirmed(string productId)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2145DF8", Offset = "0x2145DF8", VA = "0x2145DF8")]
		public void StartPurchase(string productId)
		{
		}
	}
}
namespace VE.IAP.PurchaseControllers
{
	[Token(Token = "0x2000009")]
	public class PurchaseControllerBlank : IPurchaseController
	{
		[Token(Token = "0x14000006")]
		public event Action<string> PurchaseSuccessful
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x21434AC", Offset = "0x21434AC", VA = "0x21434AC", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9949B8", Offset = "0x9949B8")]
			add
			{
			}
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x214354C", Offset = "0x214354C", VA = "0x214354C", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9949C8", Offset = "0x9949C8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event Action<string> PurchaseFailed
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x21435EC", Offset = "0x21435EC", VA = "0x21435EC", Slot = "6")]
			add
			{
			}
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x21435F0", Offset = "0x21435F0", VA = "0x21435F0", Slot = "7")]
			remove
			{
			}
		}

		[Token(Token = "0x14000008")]
		public event Action Initialized
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x21435F4", Offset = "0x21435F4", VA = "0x21435F4", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9949D8", Offset = "0x9949D8")]
			add
			{
			}
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x2143694", Offset = "0x2143694", VA = "0x2143694", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9949E8", Offset = "0x9949E8")]
			remove
			{
			}
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2143734", Offset = "0x2143734", VA = "0x2143734")]
		public PurchaseControllerBlank()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2143770", Offset = "0x2143770", VA = "0x2143770", Slot = "10")]
		public void InitiatePurchase(string productId)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x21437E0", Offset = "0x21437E0", VA = "0x21437E0", Slot = "11")]
		public Subscription GetSubscription(string productId)
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2143854", Offset = "0x2143854", VA = "0x2143854", Slot = "12")]
		public Product GetProduct(string productId)
		{
			return null;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x21438C8", Offset = "0x21438C8", VA = "0x21438C8", Slot = "13")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x21438D0", Offset = "0x21438D0", VA = "0x21438D0", Slot = "14")]
		public bool IsPurchased(string productId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x21438D8", Offset = "0x21438D8", VA = "0x21438D8", Slot = "15")]
		public bool IsSubscribed(string productId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x21438E0", Offset = "0x21438E0", VA = "0x21438E0", Slot = "16")]
		public void RestoreTransactions(Action<bool> callback)
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class PurchaseControllerDebug : IPurchaseController
	{
		[Token(Token = "0x2000025")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994278", Offset = "0x994278")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x40000AD")]
			[FieldOffset(Offset = "0x10")]
			public string productId;

			[Token(Token = "0x600011B")]
			[Address(RVA = "0x2143ECC", Offset = "0x2143ECC", VA = "0x2143ECC")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x600011C")]
			[Address(RVA = "0x2147B54", Offset = "0x2147B54", VA = "0x2147B54")]
			internal bool <GetProduct>b__0(Product val)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000026")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994288", Offset = "0x994288")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x40000AE")]
			[FieldOffset(Offset = "0x10")]
			public string productId;

			[Token(Token = "0x600011D")]
			[Address(RVA = "0x21440A0", Offset = "0x21440A0", VA = "0x21440A0")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x600011E")]
			[Address(RVA = "0x2147B78", Offset = "0x2147B78", VA = "0x2147B78")]
			internal bool <GetSubscription>b__0(Subscription val)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<string> _purchasedProducts;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x28")]
		private readonly Subscription[] _subscriptions;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x30")]
		private readonly Product[] _products;

		[Token(Token = "0x14000009")]
		public event Action<string> PurchaseSuccessful
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x2143940", Offset = "0x2143940", VA = "0x2143940", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9949F8", Offset = "0x9949F8")]
			add
			{
			}
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x21439E0", Offset = "0x21439E0", VA = "0x21439E0", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994A08", Offset = "0x994A08")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public event Action<string> PurchaseFailed
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x2143A80", Offset = "0x2143A80", VA = "0x2143A80", Slot = "6")]
			add
			{
			}
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x2143A84", Offset = "0x2143A84", VA = "0x2143A84", Slot = "7")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		public event Action Initialized
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x2143A88", Offset = "0x2143A88", VA = "0x2143A88", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994A18", Offset = "0x994A18")]
			add
			{
			}
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x2143B28", Offset = "0x2143B28", VA = "0x2143B28", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994A28", Offset = "0x994A28")]
			remove
			{
			}
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2143BC8", Offset = "0x2143BC8", VA = "0x2143BC8")]
		public PurchaseControllerDebug(Product[] products, Subscription[] subscriptions)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2143C9C", Offset = "0x2143C9C", VA = "0x2143C9C", Slot = "15")]
		public bool IsSubscribed(string productId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2143D74", Offset = "0x2143D74", VA = "0x2143D74", Slot = "16")]
		public void RestoreTransactions(Action<bool> callback)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2143DD4", Offset = "0x2143DD4", VA = "0x2143DD4", Slot = "12")]
		public Product GetProduct(string productId)
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2143ED4", Offset = "0x2143ED4", VA = "0x2143ED4", Slot = "13")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2143EDC", Offset = "0x2143EDC", VA = "0x2143EDC", Slot = "10")]
		public void InitiatePurchase(string productId)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2143FA8", Offset = "0x2143FA8", VA = "0x2143FA8", Slot = "11")]
		public Subscription GetSubscription(string productId)
		{
			return null;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2143CA0", Offset = "0x2143CA0", VA = "0x2143CA0", Slot = "14")]
		public bool IsPurchased(string productId)
		{
			return default(bool);
		}
	}
}
namespace VE.IAP.PurchaseControllers.Unity
{
	[Token(Token = "0x200000B")]
	public class AppleExtensions
	{
		[Token(Token = "0x2000027")]
		private enum SubscriptionPeriodUnit
		{
			[Token(Token = "0x40000B0")]
			Day,
			[Token(Token = "0x40000B1")]
			Week,
			[Token(Token = "0x40000B2")]
			Month,
			[Token(Token = "0x40000B3")]
			Year,
			[Token(Token = "0x40000B4")]
			NotAvailable
		}

		[Token(Token = "0x2000028")]
		private class ProductDetails
		{
			[Token(Token = "0x40000B5")]
			[FieldOffset(Offset = "0x10")]
			public int subscriptionNumberOfUnits;

			[Token(Token = "0x40000B6")]
			[FieldOffset(Offset = "0x14")]
			public SubscriptionPeriodUnit subscriptionPeriodUnit;

			[Token(Token = "0x40000B7")]
			[FieldOffset(Offset = "0x18")]
			public float localizedPrice;

			[Token(Token = "0x40000B8")]
			[FieldOffset(Offset = "0x20")]
			public string isoCurrencyCode;

			[Token(Token = "0x40000B9")]
			[FieldOffset(Offset = "0x28")]
			public string localizedPriceString;

			[Token(Token = "0x40000BA")]
			[FieldOffset(Offset = "0x30")]
			public string localizedTitle;

			[Token(Token = "0x40000BB")]
			[FieldOffset(Offset = "0x38")]
			public string localizedDescription;

			[Token(Token = "0x40000BC")]
			[FieldOffset(Offset = "0x40")]
			public float introductoryPrice;

			[Token(Token = "0x40000BD")]
			[FieldOffset(Offset = "0x48")]
			public string introductoryPriceLocale;

			[Token(Token = "0x40000BE")]
			[FieldOffset(Offset = "0x50")]
			public int introductoryPriceNumberOfPeriods;

			[Token(Token = "0x40000BF")]
			[FieldOffset(Offset = "0x54")]
			public int numberOfUnits;

			[Token(Token = "0x40000C0")]
			[FieldOffset(Offset = "0x58")]
			public SubscriptionPeriodUnit unit;

			[Token(Token = "0x600011F")]
			[Address(RVA = "0x2146B1C", Offset = "0x2146B1C", VA = "0x2146B1C")]
			public ProductDetails()
			{
			}
		}

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x10")]
		private readonly IAppleExtensions _appleExtensions;

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x21373B8", Offset = "0x21373B8", VA = "0x21373B8")]
		public AppleExtensions(IExtensionProvider extensions)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x21374A0", Offset = "0x21374A0", VA = "0x21374A0")]
		public Subscription GetSubscription(UnityEngine.Purchasing.Product product)
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x21379B8", Offset = "0x21379B8", VA = "0x21379B8")]
		public void RestoreTransactions(Action<bool> callback)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x21377FC", Offset = "0x21377FC", VA = "0x21377FC")]
		private static TimeSpan GetSubscriptionPeriod(SubscriptionPeriodUnit unit, int numberOfUnits)
		{
			return default(TimeSpan);
		}
	}
	[Token(Token = "0x200000C")]
	public class GooglePlayBillingExtensions
	{
		[Serializable]
		[Token(Token = "0x2000029")]
		public class PurchaseReceipt
		{
			[Token(Token = "0x40000C1")]
			[FieldOffset(Offset = "0x10")]
			public string json;

			[Token(Token = "0x40000C2")]
			[FieldOffset(Offset = "0x18")]
			public string signature;

			[Token(Token = "0x6000120")]
			[Address(RVA = "0x2146C08", Offset = "0x2146C08", VA = "0x2146C08")]
			public PurchaseReceipt(string jsonPurchaseData, string signature)
			{
			}
		}

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x10")]
		private readonly IGooglePlayStoreExtensions _googlePlayStoreExtensions;

		[Token(Token = "0x1700001A")]
		public static IPurchasingModule Module
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x2138460", Offset = "0x2138460", VA = "0x2138460")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2138378", Offset = "0x2138378", VA = "0x2138378")]
		public GooglePlayBillingExtensions(IExtensionProvider extensions)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x21385D0", Offset = "0x21385D0", VA = "0x21385D0")]
		public Subscription GetSubscriptionFromGooglePlayJson(string productId, string receipt)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x213912C", Offset = "0x213912C", VA = "0x213912C")]
		public void RestoreTransactions(Action<bool> callback)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x2138C90", Offset = "0x2138C90", VA = "0x2138C90")]
		public static TimeSpan ISO8601ToTimeSpan(string value)
		{
			return default(TimeSpan);
		}
	}
	[Token(Token = "0x200000D")]
	public class PurchaseControllerUnity : IPurchaseController, IStoreListener
	{
		[Token(Token = "0x200002A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994298", Offset = "0x994298")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x40000C3")]
			[FieldOffset(Offset = "0x10")]
			public string productId;

			[Token(Token = "0x6000121")]
			[Address(RVA = "0x2145408", Offset = "0x2145408", VA = "0x2145408")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x6000122")]
			[Address(RVA = "0x2147CB8", Offset = "0x2147CB8", VA = "0x2147CB8")]
			internal bool <IsPurchased>b__0(UnityEngine.Purchasing.Product val)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x200002B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9942A8", Offset = "0x9942A8")]
		private sealed class <>c
		{
			[Token(Token = "0x40000C4")]
			[FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000C5")]
			[FieldOffset(Offset = "0x8")]
			public static Func<UnityEngine.Purchasing.Product, string> <>9__21_0;

			[Token(Token = "0x6000124")]
			[Address(RVA = "0x2147C00", Offset = "0x2147C00", VA = "0x2147C00")]
			public <>c()
			{
			}

			[Token(Token = "0x6000125")]
			[Address(RVA = "0x2147C08", Offset = "0x2147C08", VA = "0x2147C08")]
			internal string <OnInitialized>b__21_0(UnityEngine.Purchasing.Product val)
			{
				return null;
			}
		}

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x28")]
		private ProductCatalog _catalog;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x30")]
		private IStoreController _controller;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x38")]
		private IExtensionProvider _extensions;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x40")]
		private GooglePlayBillingExtensions _googlePlayBillingExtensions;

		[Token(Token = "0x1400000C")]
		public event Action<string> PurchaseSuccessful
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x21440A8", Offset = "0x21440A8", VA = "0x21440A8", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994A38", Offset = "0x994A38")]
			add
			{
			}
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x2144148", Offset = "0x2144148", VA = "0x2144148", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994A48", Offset = "0x994A48")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000D")]
		public event Action<string> PurchaseFailed
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x21441E8", Offset = "0x21441E8", VA = "0x21441E8", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994A58", Offset = "0x994A58")]
			add
			{
			}
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x2144288", Offset = "0x2144288", VA = "0x2144288", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994A68", Offset = "0x994A68")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public event Action Initialized
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x2144328", Offset = "0x2144328", VA = "0x2144328", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994A78", Offset = "0x994A78")]
			add
			{
			}
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x21443C8", Offset = "0x21443C8", VA = "0x21443C8", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994A88", Offset = "0x994A88")]
			remove
			{
			}
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2144468", Offset = "0x2144468", VA = "0x2144468")]
		public PurchaseControllerUnity()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2144D08", Offset = "0x2144D08", VA = "0x2144D08", Slot = "10")]
		public void InitiatePurchase(string productId)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2144FDC", Offset = "0x2144FDC", VA = "0x2144FDC", Slot = "12")]
		public Product GetProduct(string productId)
		{
			return null;
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x21451BC", Offset = "0x21451BC", VA = "0x21451BC", Slot = "11")]
		public Subscription GetSubscription(string productId)
		{
			return null;
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x214501C", Offset = "0x214501C", VA = "0x214501C")]
		public UnityEngine.Purchasing.Product GetUnityProduct(string productId)
		{
			return null;
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2145260", Offset = "0x2145260", VA = "0x2145260", Slot = "14")]
		public bool IsPurchased(string productId)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2145410", Offset = "0x2145410", VA = "0x2145410", Slot = "15")]
		public bool IsSubscribed(string productId)
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2145414", Offset = "0x2145414", VA = "0x2145414", Slot = "18")]
		public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
		{
			return default(PurchaseProcessingResult);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2145494", Offset = "0x2145494", VA = "0x2145494", Slot = "20")]
		public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x21457FC", Offset = "0x21457FC", VA = "0x21457FC", Slot = "17")]
		public void OnInitializeFailed(InitializationFailureReason error)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x21458E4", Offset = "0x21458E4", VA = "0x21458E4", Slot = "19")]
		public void OnPurchaseFailed(UnityEngine.Purchasing.Product product, PurchaseFailureReason failureReason)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x2144490", Offset = "0x2144490", VA = "0x2144490")]
		private void InitializePurchasing()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2144FBC", Offset = "0x2144FBC", VA = "0x2144FBC", Slot = "13")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2145A08", Offset = "0x2145A08", VA = "0x2145A08", Slot = "16")]
		public void RestoreTransactions(Action<bool> callback)
		{
		}
	}
	[Token(Token = "0x200000E")]
	public static class UnityIAPExtensions
	{
		[Serializable]
		[Token(Token = "0x200002C")]
		public class JsonReceipt
		{
			[Token(Token = "0x40000C6")]
			[FieldOffset(Offset = "0x10")]
			public string Store;

			[Token(Token = "0x40000C7")]
			[FieldOffset(Offset = "0x18")]
			public string TransactionID;

			[Token(Token = "0x40000C8")]
			[FieldOffset(Offset = "0x20")]
			public string Payload;

			[Token(Token = "0x6000126")]
			[Address(RVA = "0x2138ED4", Offset = "0x2138ED4", VA = "0x2138ED4")]
			public static bool FromJson(string value, out JsonReceipt jsonReceipt)
			{
				return default(bool);
			}

			[Token(Token = "0x6000127")]
			[Address(RVA = "0x2147DF4", Offset = "0x2147DF4", VA = "0x2147DF4")]
			public JsonReceipt()
			{
			}
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x213770C", Offset = "0x213770C", VA = "0x213770C")]
		public static Product SetFromUnityProduct(this Product product, UnityEngine.Purchasing.Product unityProduct)
		{
			return null;
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2146710", Offset = "0x2146710", VA = "0x2146710")]
		public static Product GetProduct(UnityEngine.Purchasing.Product unityProduct)
		{
			return null;
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x2146784", Offset = "0x2146784", VA = "0x2146784")]
		private static bool CheckIfProductIsAvailableForSubscriptionManager(string receipt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2146914", Offset = "0x2146914", VA = "0x2146914")]
		public static SubscriptionInfo GetSubscriptionInfo(UnityEngine.Purchasing.Product product)
		{
			return null;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x21469C0", Offset = "0x21469C0", VA = "0x21469C0")]
		public static Subscription GetSubscription(UnityEngine.Purchasing.Product unityProduct)
		{
			return null;
		}
	}
}
namespace Google.Play.Billing
{
	[Token(Token = "0x200000F")]
	public class GooglePlayStoreImpl : IStore, IGooglePlayStoreExtensions, IStoreExtension, IGooglePlayConfiguration, IStoreConfiguration
	{
		[Token(Token = "0x200002D")]
		private enum AsyncRequestStatus
		{
			[Token(Token = "0x40000CA")]
			Pending,
			[Token(Token = "0x40000CB")]
			Failed,
			[Token(Token = "0x40000CC")]
			Succeed
		}

		[Token(Token = "0x200002E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9942B8", Offset = "0x9942B8")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x40000CD")]
			[FieldOffset(Offset = "0x10")]
			public GooglePlayStoreImpl <>4__this;

			[Token(Token = "0x40000CE")]
			[FieldOffset(Offset = "0x18")]
			public ReadOnlyCollection<ProductDefinition> products;

			[Token(Token = "0x40000CF")]
			[FieldOffset(Offset = "0x20")]
			public Action <>9__2;

			[Token(Token = "0x40000D0")]
			[FieldOffset(Offset = "0x28")]
			public Action <>9__3;

			[Token(Token = "0x6000128")]
			[Address(RVA = "0x213BDCC", Offset = "0x213BDCC", VA = "0x213BDCC")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x6000129")]
			[Address(RVA = "0x2146E28", Offset = "0x2146E28", VA = "0x2146E28")]
			internal void <RetrieveProducts>b__0()
			{
			}

			[Token(Token = "0x600012A")]
			[Address(RVA = "0x2146F40", Offset = "0x2146F40", VA = "0x2146F40")]
			internal void <RetrieveProducts>b__1(AndroidJavaObject billingResult)
			{
			}

			[Token(Token = "0x600012B")]
			[Address(RVA = "0x2147150", Offset = "0x2147150", VA = "0x2147150")]
			internal void <RetrieveProducts>b__2()
			{
			}

			[Token(Token = "0x600012C")]
			[Address(RVA = "0x2147170", Offset = "0x2147170", VA = "0x2147170")]
			internal void <RetrieveProducts>b__3()
			{
			}
		}

		[Token(Token = "0x200002F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9942C8", Offset = "0x9942C8")]
		private sealed class <>c__DisplayClass17_0
		{
			[Token(Token = "0x40000D1")]
			[FieldOffset(Offset = "0x10")]
			public GooglePlayStoreImpl <>4__this;

			[Token(Token = "0x40000D2")]
			[FieldOffset(Offset = "0x18")]
			public ProductDefinition product;

			[Token(Token = "0x600012D")]
			[Address(RVA = "0x213D4B4", Offset = "0x213D4B4", VA = "0x213D4B4")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x600012E")]
			[Address(RVA = "0x214722C", Offset = "0x214722C", VA = "0x214722C")]
			internal void <Purchase>b__0()
			{
			}
		}

		[Token(Token = "0x2000030")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9942D8", Offset = "0x9942D8")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x40000D3")]
			[FieldOffset(Offset = "0x10")]
			public Action<bool> callback;

			[Token(Token = "0x40000D4")]
			[FieldOffset(Offset = "0x18")]
			public GooglePlayStoreImpl <>4__this;

			[Token(Token = "0x600012F")]
			[Address(RVA = "0x213EBF8", Offset = "0x213EBF8", VA = "0x213EBF8")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6000130")]
			[Address(RVA = "0x2147368", Offset = "0x2147368", VA = "0x2147368")]
			internal void <ConfirmSubscriptionPriceChange>b__0()
			{
			}

			[Token(Token = "0x6000131")]
			[Address(RVA = "0x21473C0", Offset = "0x21473C0", VA = "0x21473C0")]
			internal void <ConfirmSubscriptionPriceChange>b__1()
			{
			}

			[Token(Token = "0x6000132")]
			[Address(RVA = "0x2147418", Offset = "0x2147418", VA = "0x2147418")]
			internal void <ConfirmSubscriptionPriceChange>b__2(AndroidJavaObject billingResult)
			{
			}
		}

		[Token(Token = "0x2000031")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9942E8", Offset = "0x9942E8")]
		private sealed class <>c__DisplayClass21_1
		{
			[Token(Token = "0x40000D5")]
			[FieldOffset(Offset = "0x10")]
			public AndroidJavaObject billingResult;

			[Token(Token = "0x40000D6")]
			[FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass21_0 CS$<>8__locals1;

			[Token(Token = "0x6000133")]
			[Address(RVA = "0x21474FC", Offset = "0x21474FC", VA = "0x21474FC")]
			public <>c__DisplayClass21_1()
			{
			}

			[Token(Token = "0x6000134")]
			[Address(RVA = "0x2147504", Offset = "0x2147504", VA = "0x2147504")]
			internal void <ConfirmSubscriptionPriceChange>b__3()
			{
			}
		}

		[Token(Token = "0x2000032")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9942F8", Offset = "0x9942F8")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x40000D7")]
			[FieldOffset(Offset = "0x10")]
			public GooglePlayStoreImpl <>4__this;

			[Token(Token = "0x40000D8")]
			[FieldOffset(Offset = "0x18")]
			public Product newProduct;

			[Token(Token = "0x6000135")]
			[Address(RVA = "0x213F9CC", Offset = "0x213F9CC", VA = "0x213F9CC")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x6000136")]
			[Address(RVA = "0x2147534", Offset = "0x2147534", VA = "0x2147534")]
			internal void <UpdateSubscription>b__0()
			{
			}
		}

		[Token(Token = "0x2000033")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994308", Offset = "0x994308")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x40000D9")]
			[FieldOffset(Offset = "0x10")]
			public GooglePlayStoreImpl <>4__this;

			[Token(Token = "0x40000DA")]
			[FieldOffset(Offset = "0x18")]
			public Action<bool> callback;

			[Token(Token = "0x6000137")]
			[Address(RVA = "0x213FDE4", Offset = "0x213FDE4", VA = "0x213FDE4")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x6000138")]
			[Address(RVA = "0x2147678", Offset = "0x2147678", VA = "0x2147678")]
			internal void <RestoreTransactions>b__0()
			{
			}

			[Token(Token = "0x6000139")]
			[Address(RVA = "0x2147744", Offset = "0x2147744", VA = "0x2147744")]
			internal void <RestoreTransactions>b__1()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000034")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994318", Offset = "0x994318")]
		private sealed class <>c
		{
			[Token(Token = "0x40000DB")]
			[FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000DC")]
			[FieldOffset(Offset = "0x8")]
			public static Func<ProductDefinition, bool> <>9__34_0;

			[Token(Token = "0x40000DD")]
			[FieldOffset(Offset = "0x10")]
			public static Func<ProductDefinition, string> <>9__34_1;

			[Token(Token = "0x40000DE")]
			[FieldOffset(Offset = "0x18")]
			public static Func<ProductDefinition, bool> <>9__34_2;

			[Token(Token = "0x40000DF")]
			[FieldOffset(Offset = "0x20")]
			public static Func<ProductDefinition, string> <>9__34_3;

			[Token(Token = "0x600013B")]
			[Address(RVA = "0x2146DB0", Offset = "0x2146DB0", VA = "0x2146DB0")]
			public <>c()
			{
			}

			[Token(Token = "0x600013C")]
			[Address(RVA = "0x2146DB8", Offset = "0x2146DB8", VA = "0x2146DB8")]
			internal bool <QuerySkuDetailsForSkuType>b__34_0(ProductDefinition p)
			{
				return default(bool);
			}

			[Token(Token = "0x600013D")]
			[Address(RVA = "0x2146DD8", Offset = "0x2146DD8", VA = "0x2146DD8")]
			internal string <QuerySkuDetailsForSkuType>b__34_1(ProductDefinition p)
			{
				return null;
			}

			[Token(Token = "0x600013E")]
			[Address(RVA = "0x2146DF0", Offset = "0x2146DF0", VA = "0x2146DF0")]
			internal bool <QuerySkuDetailsForSkuType>b__34_2(ProductDefinition p)
			{
				return default(bool);
			}

			[Token(Token = "0x600013F")]
			[Address(RVA = "0x2146E10", Offset = "0x2146E10", VA = "0x2146E10")]
			internal string <QuerySkuDetailsForSkuType>b__34_3(ProductDefinition p)
			{
				return null;
			}
		}

		[Token(Token = "0x2000035")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994328", Offset = "0x994328")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x40000E0")]
			[FieldOffset(Offset = "0x10")]
			public GooglePlayStoreImpl <>4__this;

			[Token(Token = "0x40000E1")]
			[FieldOffset(Offset = "0x18")]
			public string debugMessage;

			[Token(Token = "0x6000140")]
			[Address(RVA = "0x2141F2C", Offset = "0x2141F2C", VA = "0x2141F2C")]
			public <>c__DisplayClass38_0()
			{
			}
		}

		[Token(Token = "0x2000036")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994338", Offset = "0x994338")]
		private sealed class <>c__DisplayClass38_1
		{
			[Token(Token = "0x40000E2")]
			[FieldOffset(Offset = "0x10")]
			public Purchase purchase;

			[Token(Token = "0x40000E3")]
			[FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass38_0 CS$<>8__locals1;

			[Token(Token = "0x6000141")]
			[Address(RVA = "0x2141F34", Offset = "0x2141F34", VA = "0x2141F34")]
			public <>c__DisplayClass38_1()
			{
			}

			[Token(Token = "0x6000142")]
			[Address(RVA = "0x214779C", Offset = "0x214779C", VA = "0x214779C")]
			internal void <ParsePurchaseResult>b__0()
			{
			}
		}

		[Token(Token = "0x2000037")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994348", Offset = "0x994348")]
		private sealed class <>c__DisplayClass38_2
		{
			[Token(Token = "0x40000E4")]
			[FieldOffset(Offset = "0x10")]
			public string unityProductId;

			[Token(Token = "0x40000E5")]
			[FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass38_1 CS$<>8__locals2;

			[Token(Token = "0x6000143")]
			[Address(RVA = "0x21423D8", Offset = "0x21423D8", VA = "0x21423D8")]
			public <>c__DisplayClass38_2()
			{
			}

			[Token(Token = "0x6000144")]
			[Address(RVA = "0x21478A8", Offset = "0x21478A8", VA = "0x21478A8")]
			internal void <ParsePurchaseResult>b__1()
			{
			}
		}

		[Token(Token = "0x2000038")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994358", Offset = "0x994358")]
		private sealed class <>c__DisplayClass38_3
		{
			[Token(Token = "0x40000E6")]
			[FieldOffset(Offset = "0x10")]
			public string productId;

			[Token(Token = "0x40000E7")]
			[FieldOffset(Offset = "0x18")]
			public PurchaseFailureReason purchaseFailureReason;

			[Token(Token = "0x40000E8")]
			[FieldOffset(Offset = "0x20")]
			public <>c__DisplayClass38_0 CS$<>8__locals3;

			[Token(Token = "0x6000145")]
			[Address(RVA = "0x21423E0", Offset = "0x21423E0", VA = "0x21423E0")]
			public <>c__DisplayClass38_3()
			{
			}

			[Token(Token = "0x6000146")]
			[Address(RVA = "0x21479B0", Offset = "0x21479B0", VA = "0x21479B0")]
			internal void <ParsePurchaseResult>b__2()
			{
			}
		}

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x10")]
		private AndroidJavaObject _billingClient;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x18")]
		private BillingClientStateListener _billingClientStateListener;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x20")]
		private Action<Product> _deferredPurchaseListener;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x28")]
		private IStoreCallback _callback;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x30")]
		private readonly GooglePlayBillingInventory _inventory;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x38")]
		private readonly GooglePlayBillingUtil _billingUtil;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x40")]
		private readonly JniUtils _jniUtils;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<SkuType, AsyncRequestStatus> _billingClientQuerySkuDetailsCallStatus;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x50")]
		private bool _billingClientReady;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x58")]
		private ProductDefinition _productInPurchaseFlow;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x60")]
		private string _obfuscatedProfileId;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x68")]
		private string _obfuscatedAccountId;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x70")]
		private bool _deferredPurchasesEnabled;

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x213BA50", Offset = "0x213BA50", VA = "0x213BA50")]
		public GooglePlayStoreImpl(GooglePlayBillingUtil googlePlayBillingUtil)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x213BC30", Offset = "0x213BC30", VA = "0x213BC30", Slot = "4")]
		public void Initialize(IStoreCallback callback)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x213BC38", Offset = "0x213BC38", VA = "0x213BC38", Slot = "5")]
		public void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x213C124", Offset = "0x213C124", VA = "0x213C124")]
		private void RetrieveProductsInternal(ReadOnlyCollection<ProductDefinition> products)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x213CD48", Offset = "0x213CD48", VA = "0x213CD48", Slot = "6")]
		public void Purchase(ProductDefinition product, string developerPayload)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x213D8E4", Offset = "0x213D8E4", VA = "0x213D8E4", Slot = "7")]
		public void FinishTransaction(ProductDefinition product, string transactionId)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x213E3F8", Offset = "0x213E3F8", VA = "0x213E3F8", Slot = "8")]
		public void SetObfuscatedAccountId(string accountId)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x213E480", Offset = "0x213E480", VA = "0x213E480", Slot = "9")]
		public void SetObfuscatedProfileId(string profileId)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x213E508", Offset = "0x213E508", VA = "0x213E508", Slot = "15")]
		public void ConfirmSubscriptionPriceChange(string productId, Action<bool> callback)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x213EFC0", Offset = "0x213EFC0", VA = "0x213EFC0", Slot = "17")]
		public void EndConnection()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x213F0FC", Offset = "0x213F0FC", VA = "0x213F0FC", Slot = "11")]
		public void UpgradeDowngradeSubscription(string oldSkuMetadata, string newSku)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x213F1C0", Offset = "0x213F1C0", VA = "0x213F1C0", Slot = "12")]
		public void UpdateSubscription(Product oldProduct, Product newProduct, GooglePlayStoreProrationMode prorationMode)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x213FA24", Offset = "0x213FA24", VA = "0x213FA24", Slot = "13")]
		public void RestoreTransactions(Action<bool> callback)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x21402A8", Offset = "0x21402A8", VA = "0x21402A8", Slot = "14")]
		public void FinishAdditionalTransaction(string productId, string transactionId)
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2140358", Offset = "0x2140358", VA = "0x2140358", Slot = "10")]
		public Dictionary<string, string> GetProductJSONDictionary()
		{
			return null;
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2140398", Offset = "0x2140398", VA = "0x2140398", Slot = "16")]
		public void SetDeferredPurchaseListener(Action<Product> callback)
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2140420", Offset = "0x2140420", VA = "0x2140420", Slot = "18")]
		public void EnableDeferredPurchase()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x213EC00", Offset = "0x213EC00", VA = "0x213EC00")]
		private bool IsGooglePlayInAppBillingServiceAvailable()
		{
			return default(bool);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x213BDD4", Offset = "0x213BDD4", VA = "0x213BDD4")]
		private void InstantiateBillingClientAndMakeConnection()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x214075C", Offset = "0x214075C", VA = "0x214075C")]
		private void MarkBillingClientStartConnectionCallComplete(AndroidJavaObject billingResult)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x213C45C", Offset = "0x213C45C", VA = "0x213C45C")]
		private void QuerySkuDetailsForSkuType(ReadOnlyCollection<ProductDefinition> products, SkuType skuType)
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2141404", Offset = "0x2141404", VA = "0x2141404")]
		private void ParseSkuDetailsResults(SkuType skuType, AndroidJavaObject billingResult, AndroidJavaObject skuDetailsList)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2140DD0", Offset = "0x2140DD0", VA = "0x2140DD0")]
		private void NotifyUnityRetrieveProductsResults()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x213C318", Offset = "0x213C318", VA = "0x213C318")]
		private BillingResponseCode QueryPurchasesForSkuType(SkuType skuType)
		{
			return default(BillingResponseCode);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2141A48", Offset = "0x2141A48", VA = "0x2141A48")]
		private void ParsePurchaseResult(AndroidJavaObject billingResult, AndroidJavaObject javaPurchasesList)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x21423E8", Offset = "0x21423E8", VA = "0x21423E8")]
		private void ProcessAcknowledgePurchaseResult(string skuId, SkuType skuType, AndroidJavaObject billingResult)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2142818", Offset = "0x2142818", VA = "0x2142818")]
		private void ProcessConsumePurchaseResult(string skuId, AndroidJavaObject billingResult)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x213D5AC", Offset = "0x213D5AC", VA = "0x213D5AC")]
		private void LaunchBillingFlow(AndroidJavaObject billingFlowParamBuilder)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x213D940", Offset = "0x213D940", VA = "0x213D940")]
		private void FinishTransactionInternal(Purchase purchase, ProductType productType)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x21429C0", Offset = "0x21429C0", VA = "0x21429C0")]
		private void ProcessPriceChangeResult(AndroidJavaObject billingResult, Action<bool> callback)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2142B5C", Offset = "0x2142B5C", VA = "0x2142B5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994AA8", Offset = "0x994AA8")]
		private void <RetrieveProductsInternal>b__16_0()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2142C10", Offset = "0x2142C10", VA = "0x2142C10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994AB8", Offset = "0x994AB8")]
		private void <RetrieveProductsInternal>b__16_1()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2142CC4", Offset = "0x2142CC4", VA = "0x2142CC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994AC8", Offset = "0x994AC8")]
		private void <NotifyUnityRetrieveProductsResults>b__36_0()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2142D88", Offset = "0x2142D88", VA = "0x2142D88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994AD8", Offset = "0x994AD8")]
		private void <NotifyUnityRetrieveProductsResults>b__36_1()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class GooglePlayStoreModule : AbstractPurchasingModule
	{
		[Token(Token = "0x400003F")]
		public const string StoreName = "GooglePlay";

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x18")]
		private IStore _storeInstance;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x0")]
		private static GooglePlayStoreModule _moduleInstance;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x8")]
		private static GooglePlayBillingUtil _util;

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2138464", Offset = "0x2138464", VA = "0x2138464")]
		public static AbstractPurchasingModule Instance()
		{
			return null;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2142E44", Offset = "0x2142E44", VA = "0x2142E44", Slot = "5")]
		public override void Configure()
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2142EA0", Offset = "0x2142EA0", VA = "0x2142EA0")]
		private IStore InstantiateGooglePlayBilling()
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2142E3C", Offset = "0x2142E3C", VA = "0x2142E3C")]
		public GooglePlayStoreModule()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public enum GooglePlayStoreProrationMode
	{
		[Token(Token = "0x4000044")]
		Unknown,
		[Token(Token = "0x4000045")]
		ImmediateWithTimeProration,
		[Token(Token = "0x4000046")]
		ImmediateAndChargeProratedPrice,
		[Token(Token = "0x4000047")]
		ImmediateWithoutProration
	}
	[Token(Token = "0x2000012")]
	public class GooglePlayStoreUnsupportedException : Exception
	{
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x213F14C", Offset = "0x213F14C", VA = "0x213F14C")]
		public GooglePlayStoreUnsupportedException(string message)
		{
		}
	}
	[Token(Token = "0x2000013")]
	public interface IGooglePlayConfiguration : IStoreConfiguration
	{
		[Token(Token = "0x60000B1")]
		void EnableDeferredPurchase();
	}
	[Token(Token = "0x2000014")]
	public interface IGooglePlayStoreExtensions : IStoreExtension
	{
		[Token(Token = "0x60000B2")]
		void SetObfuscatedAccountId(string obfuscatedAccountId);

		[Token(Token = "0x60000B3")]
		void SetObfuscatedProfileId(string obfuscatedProfileId);

		[Token(Token = "0x60000B4")]
		Dictionary<string, string> GetProductJSONDictionary();

		[Token(Token = "0x60000B5")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x994AE8", Offset = "0x994AE8")]
		void UpgradeDowngradeSubscription(string oldSkuMetadata, string newSku);

		[Token(Token = "0x60000B6")]
		void UpdateSubscription(Product oldProduct, Product newProduct, GooglePlayStoreProrationMode prorationMode = GooglePlayStoreProrationMode.Unknown);

		[Token(Token = "0x60000B7")]
		void RestoreTransactions(Action<bool> callback);

		[Token(Token = "0x60000B8")]
		void FinishAdditionalTransaction(string productId, string transactionId);

		[Token(Token = "0x60000B9")]
		void ConfirmSubscriptionPriceChange(string productId, Action<bool> callback);

		[Token(Token = "0x60000BA")]
		void SetDeferredPurchaseListener(Action<Product> callback);

		[Token(Token = "0x60000BB")]
		void EndConnection();
	}
	[Token(Token = "0x2000015")]
	public class FakeGooglePlayConfiguration : IGooglePlayConfiguration, IStoreConfiguration
	{
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2138338", Offset = "0x2138338", VA = "0x2138338", Slot = "4")]
		public void EnableDeferredPurchase()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x213833C", Offset = "0x213833C", VA = "0x213833C")]
		public FakeGooglePlayConfiguration()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class FakeGooglePlayStoreExtensions : IGooglePlayStoreExtensions, IStoreExtension
	{
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x2138344", Offset = "0x2138344", VA = "0x2138344", Slot = "7")]
		public void UpgradeDowngradeSubscription(string oldSku, string newSku)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x2138348", Offset = "0x2138348", VA = "0x2138348", Slot = "8")]
		public void UpdateSubscription(Product oldProduct, Product newProduct, GooglePlayStoreProrationMode prorationMode = GooglePlayStoreProrationMode.Unknown)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x213834C", Offset = "0x213834C", VA = "0x213834C", Slot = "9")]
		public void RestoreTransactions(Action<bool> callback)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x2138350", Offset = "0x2138350", VA = "0x2138350", Slot = "4")]
		public void SetObfuscatedAccountId(string obfuscatedAccountId)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x2138354", Offset = "0x2138354", VA = "0x2138354", Slot = "5")]
		public void SetObfuscatedProfileId(string obfuscatedProfileId)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2138358", Offset = "0x2138358", VA = "0x2138358", Slot = "6")]
		public Dictionary<string, string> GetProductJSONDictionary()
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2138360", Offset = "0x2138360", VA = "0x2138360", Slot = "10")]
		public void FinishAdditionalTransaction(string productId, string transactionId)
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2138364", Offset = "0x2138364", VA = "0x2138364", Slot = "11")]
		public void ConfirmSubscriptionPriceChange(string productId, Action<bool> callback)
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x2138368", Offset = "0x2138368", VA = "0x2138368", Slot = "12")]
		public void SetDeferredPurchaseListener(Action<Product> callback)
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x213836C", Offset = "0x213836C", VA = "0x213836C", Slot = "13")]
		public void EndConnection()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2138370", Offset = "0x2138370", VA = "0x2138370")]
		public FakeGooglePlayStoreExtensions()
		{
		}
	}
}
namespace Google.Play.Billing.Internal
{
	[Token(Token = "0x2000017")]
	public class AcknowledgeResponseListener : AndroidJavaProxy
	{
		[Serializable]
		[Token(Token = "0x2000039")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994368", Offset = "0x994368")]
		private sealed class <>c
		{
			[Token(Token = "0x40000E9")]
			[FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000EA")]
			[FieldOffset(Offset = "0x8")]
			public static Action<string, SkuType, AndroidJavaObject> <>9__5_0;

			[Token(Token = "0x6000148")]
			[Address(RVA = "0x2146B10", Offset = "0x2146B10", VA = "0x2146B10")]
			public <>c()
			{
			}

			[Token(Token = "0x6000149")]
			[Address(RVA = "0x2146B18", Offset = "0x2146B18", VA = "0x2146B18")]
			internal void <.ctor>b__5_0(string <p0>, SkuType <p1>, AndroidJavaObject <p2>)
			{
			}
		}

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x20")]
		private readonly string _skuId;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x28")]
		private readonly SkuType _skuType;

		[Token(Token = "0x1400000F")]
		public event Action<string, SkuType, AndroidJavaObject> OnAcknowledgeResponse
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x213707C", Offset = "0x213707C", VA = "0x213707C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994B20", Offset = "0x994B20")]
			add
			{
			}
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x213711C", Offset = "0x213711C", VA = "0x213711C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994B30", Offset = "0x994B30")]
			remove
			{
			}
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x21371BC", Offset = "0x21371BC", VA = "0x21371BC")]
		public AcknowledgeResponseListener(string skuId, SkuType skuType)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x2137350", Offset = "0x2137350", VA = "0x2137350")]
		private void onAcknowledgePurchaseResponse(AndroidJavaObject billingResult)
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class BillingClientStateListener : AndroidJavaProxy
	{
		[Serializable]
		[Token(Token = "0x200003A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994378", Offset = "0x994378")]
		private sealed class <>c
		{
			[Token(Token = "0x40000EB")]
			[FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000EC")]
			[FieldOffset(Offset = "0x8")]
			public static Action <>9__6_0;

			[Token(Token = "0x40000ED")]
			[FieldOffset(Offset = "0x10")]
			public static Action<AndroidJavaObject> <>9__6_1;

			[Token(Token = "0x600014B")]
			[Address(RVA = "0x2146B88", Offset = "0x2146B88", VA = "0x2146B88")]
			public <>c()
			{
			}

			[Token(Token = "0x600014C")]
			[Address(RVA = "0x2146B90", Offset = "0x2146B90", VA = "0x2146B90")]
			internal void <.ctor>b__6_0()
			{
			}

			[Token(Token = "0x600014D")]
			[Address(RVA = "0x2146B94", Offset = "0x2146B94", VA = "0x2146B94")]
			internal void <.ctor>b__6_1(AndroidJavaObject <p0>)
			{
			}
		}

		[Token(Token = "0x14000010")]
		public event Action OnBillingServiceDisconnected
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x2137A74", Offset = "0x2137A74", VA = "0x2137A74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994B40", Offset = "0x994B40")]
			add
			{
			}
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x2137B14", Offset = "0x2137B14", VA = "0x2137B14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994B50", Offset = "0x994B50")]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event Action<AndroidJavaObject> OnBillingSetupFinished
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x2137BB4", Offset = "0x2137BB4", VA = "0x2137BB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994B60", Offset = "0x994B60")]
			add
			{
			}
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x2137C54", Offset = "0x2137C54", VA = "0x2137C54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994B70", Offset = "0x994B70")]
			remove
			{
			}
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x2137CF4", Offset = "0x2137CF4", VA = "0x2137CF4")]
		public BillingClientStateListener()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x2137F08", Offset = "0x2137F08", VA = "0x2137F08")]
		private void onBillingServiceDisconnected()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x2137F24", Offset = "0x2137F24", VA = "0x2137F24")]
		private void onBillingSetupFinished(AndroidJavaObject billingResult)
		{
		}
	}
	[Token(Token = "0x2000019")]
	public enum BillingResponseCode
	{
		[Token(Token = "0x400004E")]
		ServiceTimeout = -3,
		[Token(Token = "0x400004F")]
		FeatureNotSupported,
		[Token(Token = "0x4000050")]
		ServiceDisconnected,
		[Token(Token = "0x4000051")]
		Ok,
		[Token(Token = "0x4000052")]
		UserCancelled,
		[Token(Token = "0x4000053")]
		ServiceUnavailable,
		[Token(Token = "0x4000054")]
		BillingUnavailable,
		[Token(Token = "0x4000055")]
		ItemUnavailable,
		[Token(Token = "0x4000056")]
		DeveloperError,
		[Token(Token = "0x4000057")]
		Error,
		[Token(Token = "0x4000058")]
		ItemAlreadyOwned,
		[Token(Token = "0x4000059")]
		ItemNotOwned
	}
	[Token(Token = "0x200001A")]
	internal static class Constants
	{
		[Token(Token = "0x400005A")]
		public const string Version = "3.0.0-unity";

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly TimeSpan BillingClientAsyncTimeout;

		[Token(Token = "0x400005C")]
		public const string BuildMethod = "build";

		[Token(Token = "0x400005D")]
		public const string BillingClient = "com.android.billingclient.api.BillingClientImpl";

		[Token(Token = "0x400005E")]
		public const string BillingClientSetUpMethod = "initialize";

		[Token(Token = "0x400005F")]
		public const string BillingClientStartConnectionMethod = "startConnection";

		[Token(Token = "0x4000060")]
		public const string BillingClientLaunchBillingFlowMethod = "launchBillingFlow";

		[Token(Token = "0x4000061")]
		public const string BillingClientConsumePurchaseMethod = "consumeAsync";

		[Token(Token = "0x4000062")]
		public const string BillingClientAcknowledgePurchaseMethod = "acknowledgePurchase";

		[Token(Token = "0x4000063")]
		public const string BillingClientEndConnectionMethod = "endConnection";

		[Token(Token = "0x4000064")]
		public const string AcknowledgeResponseListener = "com.android.billingclient.api.AcknowledgePurchaseResponseListener";

		[Token(Token = "0x4000065")]
		public const string BillingClientStateListener = "com.android.billingclient.api.BillingClientStateListener";

		[Token(Token = "0x4000066")]
		public const string ConsumeResponseListener = "com.android.billingclient.api.ConsumeResponseListener";

		[Token(Token = "0x4000067")]
		public const string PurchaseUpdatedListener = "com.android.billingclient.api.PurchasesUpdatedListener";

		[Token(Token = "0x4000068")]
		public const string AcknowledgeParamsBuilder = "com.android.billingclient.api.AcknowledgePurchaseParams$Builder";

		[Token(Token = "0x4000069")]
		public const string AcknowledgeParamsBuilderSetPurchaseTokenMethod = "setPurchaseToken";

		[Token(Token = "0x400006A")]
		public const string ConsumeParamsBuilder = "com.android.billingclient.api.ConsumeParams$Builder";

		[Token(Token = "0x400006B")]
		public const string ConsumeParamsBuilderSetPurchaseTokenMethod = "setPurchaseToken";

		[Token(Token = "0x400006C")]
		public const string BillingFlowParamsBuilder = "com.android.billingclient.api.BillingFlowParams$Builder";

		[Token(Token = "0x400006D")]
		public const string BillingFlowParamsBuilderSetSkuDetailsMethod = "setSkuDetails";

		[Token(Token = "0x400006E")]
		public const string BillingFlowParamsBuilderSetObfuscatedAccountIdMethod = "setObfuscatedAccountId";

		[Token(Token = "0x400006F")]
		public const string BillingFlowParamsBuilderSetObfuscatedProfileIdMethod = "setObfuscatedProfileId";

		[Token(Token = "0x4000070")]
		public const string BillingFlowParamsBuilderSetOldSkuMethod = "setOldSku";

		[Token(Token = "0x4000071")]
		public const string BillingFlowParamsBuilderSetReplaceSkusProrationModeMethod = "setReplaceSkusProrationMode";

		[Token(Token = "0x4000072")]
		public const string PurchaseGetOriginalJsonMethod = "getOriginalJson";

		[Token(Token = "0x4000073")]
		public const string PurchaseGetSignatureMethod = "getSignature";

		[Token(Token = "0x4000074")]
		public const string QueryPurchasesMethod = "queryPurchases";

		[Token(Token = "0x4000075")]
		public const string PurchasesResultGetBillingResultMethod = "getBillingResult";

		[Token(Token = "0x4000076")]
		public const string PurchasesResultGetPurchasesListMethod = "getPurchasesList";

		[Token(Token = "0x4000077")]
		public const string SkuDetailsClass = "com.android.billingclient.api.SkuDetails";

		[Token(Token = "0x4000078")]
		public const string SkuDetailsGetOriginalJson = "getOriginalJson";

		[Token(Token = "0x4000079")]
		public const string SkuDetailsParamBuilder = "com.android.billingclient.api.SkuDetailsParams$Builder";

		[Token(Token = "0x400007A")]
		public const string SkuDetailsParamBuilderSetSkuListMethod = "setSkusList";

		[Token(Token = "0x400007B")]
		public const string SkuDetailsParamBuilderSetTypeMethod = "setType";

		[Token(Token = "0x400007C")]
		public const string QuerySkuDetailsMethod = "querySkuDetailsAsync";

		[Token(Token = "0x400007D")]
		public const string SkuDetailsResponseListener = "com.android.billingclient.api.SkuDetailsResponseListener";

		[Token(Token = "0x400007E")]
		public const string PriceChangeFlowParamsBuilder = "com.android.billingclient.api.PriceChangeFlowParams$Builder";

		[Token(Token = "0x400007F")]
		public const string PriceChangeFlowParamsBuilderSetSkuDetailsMethod = "setSkuDetails";

		[Token(Token = "0x4000080")]
		public const string LaunchPriceChangeConfirmationFlowMethod = "launchPriceChangeConfirmationFlow";

		[Token(Token = "0x4000081")]
		public const string PriceChangeConfirmationListener = "com.android.billingclient.api.PriceChangeConfirmationListener";
	}
	[Token(Token = "0x200001B")]
	public class ConsumeResponseListener : AndroidJavaProxy
	{
		[Serializable]
		[Token(Token = "0x200003B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994388", Offset = "0x994388")]
		private sealed class <>c
		{
			[Token(Token = "0x40000EE")]
			[FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000EF")]
			[FieldOffset(Offset = "0x8")]
			public static Action<string, AndroidJavaObject> <>9__4_0;

			[Token(Token = "0x600014F")]
			[Address(RVA = "0x2146BFC", Offset = "0x2146BFC", VA = "0x2146BFC")]
			public <>c()
			{
			}

			[Token(Token = "0x6000150")]
			[Address(RVA = "0x2146C04", Offset = "0x2146C04", VA = "0x2146C04")]
			internal void <.ctor>b__4_0(string <p0>, AndroidJavaObject <p1>)
			{
			}
		}

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x20")]
		private readonly string _skuId;

		[Token(Token = "0x14000012")]
		public event Action<string, AndroidJavaObject> OnConsumeResponse
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x2138010", Offset = "0x2138010", VA = "0x2138010")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994B80", Offset = "0x994B80")]
			add
			{
			}
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x21380B0", Offset = "0x21380B0", VA = "0x21380B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994B90", Offset = "0x994B90")]
			remove
			{
			}
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x2138150", Offset = "0x2138150", VA = "0x2138150")]
		public ConsumeResponseListener(string skuId)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x21382D0", Offset = "0x21382D0", VA = "0x21382D0")]
		private void onConsumeResponse(AndroidJavaObject billingResult, string purchaseToken)
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class GooglePlayBillingInventory
	{
		[Serializable]
		[Token(Token = "0x200003C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994398", Offset = "0x994398")]
		private sealed class <>c
		{
			[Token(Token = "0x40000F0")]
			[FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000F1")]
			[FieldOffset(Offset = "0x8")]
			public static Func<KeyValuePair<string, SkuDetails>, string> <>9__13_0;

			[Token(Token = "0x40000F2")]
			[FieldOffset(Offset = "0x10")]
			public static Func<KeyValuePair<string, SkuDetails>, string> <>9__13_1;

			[Token(Token = "0x6000152")]
			[Address(RVA = "0x2146CBC", Offset = "0x2146CBC", VA = "0x2146CBC")]
			public <>c()
			{
			}

			[Token(Token = "0x6000153")]
			[Address(RVA = "0x2146CC4", Offset = "0x2146CC4", VA = "0x2146CC4")]
			internal string <GetAllSkuDetails>b__13_0(KeyValuePair<string, SkuDetails> pair)
			{
				return null;
			}

			[Token(Token = "0x6000154")]
			[Address(RVA = "0x2146D04", Offset = "0x2146D04", VA = "0x2146D04")]
			internal string <GetAllSkuDetails>b__13_1(KeyValuePair<string, SkuDetails> pair)
			{
				return null;
			}
		}

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x0")]
		private static readonly decimal Micros;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x10")]
		private readonly object _inventoryLock;

		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<string, ProductDefinition> _catalog;

		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x20")]
		private readonly Dictionary<string, string> _googlePlaySkuIdToUnityProductId;

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<string, SkuDetails> _skuDetailsInventory;

		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x30")]
		private readonly Dictionary<string, Purchase> _purchaseInventory;

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x38")]
		private readonly Dictionary<string, Purchase> _pendingPurchaseInventory;

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x21391EC", Offset = "0x21391EC", VA = "0x21391EC")]
		public void UpdateCatalog(IEnumerable<ProductDefinition> products)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x213958C", Offset = "0x213958C", VA = "0x213958C")]
		public void UpdateSkuDetailsInventory(IEnumerable<SkuDetails> skuDetailsList)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x21398EC", Offset = "0x21398EC", VA = "0x21398EC")]
		public void UpdatePurchaseInventory(IEnumerable<Purchase> purchaseList)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2139DB8", Offset = "0x2139DB8", VA = "0x2139DB8")]
		public bool GetUnityProductDefinition(string unityProductId, out ProductDefinition unityProduct)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2139ED4", Offset = "0x2139ED4", VA = "0x2139ED4")]
		public bool GetUnityProductId(string googlePlaySkuId, out string unityProductId)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2139FF0", Offset = "0x2139FF0", VA = "0x2139FF0")]
		public bool GetSkuDetails(string sku, out SkuDetails skuDetails)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x213A10C", Offset = "0x213A10C", VA = "0x213A10C")]
		public Dictionary<string, string> GetAllSkuDetails()
		{
			return null;
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x213A39C", Offset = "0x213A39C", VA = "0x213A39C")]
		public bool GetPurchase(ProductDefinition product, out Purchase purchase)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x213A3B4", Offset = "0x213A3B4", VA = "0x213A3B4")]
		public bool GetPurchase(string googlePlaySkuId, out Purchase purchase)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x213A4D0", Offset = "0x213A4D0", VA = "0x213A4D0")]
		public bool RemovePurchase(string skuId)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x213A660", Offset = "0x213A660", VA = "0x213A660")]
		public List<ProductDescription> CreateProductDescriptionList()
		{
			return null;
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x213AAFC", Offset = "0x213AAFC", VA = "0x213AAFC")]
		public List<ProductDescription> UpdateProductDescriptionList(IEnumerable<string> googlePlaySkuIds)
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x213A8BC", Offset = "0x213A8BC", VA = "0x213A8BC")]
		private ProductDescription GetProductDescriptionForSku(string skuId)
		{
			return null;
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x213AF44", Offset = "0x213AF44", VA = "0x213AF44")]
		public GooglePlayBillingInventory()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class GooglePlayBillingUtil : MonoBehaviour
	{
		[Token(Token = "0x400008B")]
		private const string GooglePlayBillingLoggingTag = "Google Play Store: ";

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x18")]
		private readonly ILogger _logger;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<Action> _callbacks;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x8")]
		private static bool _callbacksPending;

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x213B180", Offset = "0x213B180", VA = "0x213B180")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x213B1F8", Offset = "0x213B1F8", VA = "0x213B1F8")]
		private void Update()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x213B4C4", Offset = "0x213B4C4", VA = "0x213B4C4")]
		public void RunOnMainThread(Action runnable)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x213B62C", Offset = "0x213B62C", VA = "0x213B62C")]
		public void LogFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x213B720", Offset = "0x213B720", VA = "0x213B720")]
		public void LogWarningFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x213B814", Offset = "0x213B814", VA = "0x213B814")]
		public void LogErrorFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x213B908", Offset = "0x213B908", VA = "0x213B908")]
		public GooglePlayBillingUtil()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class JniUtils
	{
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x10")]
		private GooglePlayBillingUtil _util;

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x213BBFC", Offset = "0x213BBFC", VA = "0x213BBFC")]
		public JniUtils(GooglePlayBillingUtil util)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x213EF18", Offset = "0x213EF18", VA = "0x213EF18")]
		public static AndroidJavaObject GetUnityAndroidActivity()
		{
			return null;
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x2140448", Offset = "0x2140448", VA = "0x2140448")]
		public static AndroidJavaObject GetApplicationContext()
		{
			return null;
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x21408D0", Offset = "0x21408D0", VA = "0x21408D0")]
		public BillingResponseCode GetResponseCodeFromBillingResult(AndroidJavaObject billingResult)
		{
			return default(BillingResponseCode);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x2140CC4", Offset = "0x2140CC4", VA = "0x2140CC4")]
		public static string GetDebugMessageFromBillingResult(AndroidJavaObject billingResult)
		{
			return null;
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x213FDEC", Offset = "0x213FDEC", VA = "0x213FDEC")]
		public BillingResponseCode GetResponseCodeFromQueryPurchasesResult(AndroidJavaObject javaPurchasesResult)
		{
			return default(BillingResponseCode);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2140FC8", Offset = "0x2140FC8", VA = "0x2140FC8")]
		public static AndroidJavaObject CreateJavaArrayList(params string[] inputs)
		{
			return null;
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x21414D0", Offset = "0x21414D0", VA = "0x21414D0")]
		public IEnumerable<SkuDetails> ParseSkuDetailsResult(AndroidJavaObject billingResult, AndroidJavaObject skuDetailsList)
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x213FF08", Offset = "0x213FF08", VA = "0x213FF08")]
		public IEnumerable<Purchase> ParseQueryPurchasesResult(AndroidJavaObject javaPurchasesResult)
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2141F3C", Offset = "0x2141F3C", VA = "0x2141F3C")]
		public IEnumerable<Purchase> ParseJavaPurchaseList(AndroidJavaObject javaPurchasesList)
		{
			return null;
		}
	}
	[Token(Token = "0x200001F")]
	public class PriceChangeConfirmationListener : AndroidJavaProxy
	{
		[Serializable]
		[Token(Token = "0x200003D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9943A8", Offset = "0x9943A8")]
		private sealed class <>c
		{
			[Token(Token = "0x40000F3")]
			[FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000F4")]
			[FieldOffset(Offset = "0x8")]
			public static Action<AndroidJavaObject> <>9__3_0;

			[Token(Token = "0x6000156")]
			[Address(RVA = "0x2147B28", Offset = "0x2147B28", VA = "0x2147B28")]
			public <>c()
			{
			}

			[Token(Token = "0x6000157")]
			[Address(RVA = "0x2147B30", Offset = "0x2147B30", VA = "0x2147B30")]
			internal void <.ctor>b__3_0(AndroidJavaObject <p0>)
			{
			}
		}

		[Token(Token = "0x14000013")]
		public event Action<AndroidJavaObject> OnPriceChangeConfirmationResult
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x213EE78", Offset = "0x213EE78", VA = "0x213EE78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994BA0", Offset = "0x994BA0")]
			add
			{
			}
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x214310C", Offset = "0x214310C", VA = "0x214310C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994BB0", Offset = "0x994BB0")]
			remove
			{
			}
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x213ED14", Offset = "0x213ED14", VA = "0x213ED14")]
		public PriceChangeConfirmationListener()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x21431AC", Offset = "0x21431AC", VA = "0x21431AC")]
		private void onPriceChangeConfirmationResult(AndroidJavaObject billingResult)
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class Purchase
	{
		[Token(Token = "0x200003E")]
		public class Identifiers
		{
			[Token(Token = "0x40000F5")]
			[FieldOffset(Offset = "0x10")]
			private string _obfuscatedAccountId;

			[Token(Token = "0x40000F6")]
			[FieldOffset(Offset = "0x18")]
			private string _obfuscatedProfileId;

			[Token(Token = "0x17000027")]
			public string ObfuscatedAccountId
			{
				[Token(Token = "0x6000158")]
				[Address(RVA = "0x2147B34", Offset = "0x2147B34", VA = "0x2147B34")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000028")]
			public string ObfuscatedProfileId
			{
				[Token(Token = "0x6000159")]
				[Address(RVA = "0x2147B3C", Offset = "0x2147B3C", VA = "0x2147B3C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600015A")]
			[Address(RVA = "0x214340C", Offset = "0x214340C", VA = "0x214340C")]
			public Identifiers(string obfuscatedAccountId, string obfuscatedProfileId)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200003F")]
		private class PurchaseData
		{
			[Token(Token = "0x40000F7")]
			[FieldOffset(Offset = "0x10")]
			public string productId;

			[Token(Token = "0x40000F8")]
			[FieldOffset(Offset = "0x18")]
			public string packageName;

			[Token(Token = "0x40000F9")]
			[FieldOffset(Offset = "0x20")]
			public string orderId;

			[Token(Token = "0x40000FA")]
			[FieldOffset(Offset = "0x28")]
			public string token;

			[Token(Token = "0x40000FB")]
			[FieldOffset(Offset = "0x30")]
			public string purchaseToken;

			[Token(Token = "0x40000FC")]
			[FieldOffset(Offset = "0x38")]
			public int purchaseState;

			[Token(Token = "0x40000FD")]
			[FieldOffset(Offset = "0x40")]
			public long purchaseTime;

			[Token(Token = "0x40000FE")]
			[FieldOffset(Offset = "0x48")]
			public bool acknowledged;

			[Token(Token = "0x40000FF")]
			[FieldOffset(Offset = "0x49")]
			public bool autoRenewing;

			[Token(Token = "0x4000100")]
			[FieldOffset(Offset = "0x50")]
			public string obfuscatedAccountId;

			[Token(Token = "0x4000101")]
			[FieldOffset(Offset = "0x58")]
			public string obfuscatedProfileId;

			[Token(Token = "0x600015B")]
			[Address(RVA = "0x2147B44", Offset = "0x2147B44", VA = "0x2147B44")]
			public PurchaseData()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000040")]
		private class PurchaseReceipt
		{
			[Token(Token = "0x4000102")]
			[FieldOffset(Offset = "0x10")]
			public string json;

			[Token(Token = "0x4000103")]
			[FieldOffset(Offset = "0x18")]
			public string signature;

			[Token(Token = "0x600015C")]
			[Address(RVA = "0x214345C", Offset = "0x214345C", VA = "0x214345C")]
			public PurchaseReceipt(string jsonPurchaseData, string signature)
			{
			}
		}

		[Token(Token = "0x2000041")]
		public enum State
		{
			[Token(Token = "0x4000105")]
			UnspecifiedState,
			[Token(Token = "0x4000106")]
			Purchased,
			[Token(Token = "0x4000107")]
			Pending
		}

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x10")]
		private readonly PurchaseData _purchaseData;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x18")]
		private readonly Identifiers _identifiers;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x20")]
		private readonly PurchaseReceipt _purchaseReceipt;

		[Token(Token = "0x1700001B")]
		public string ProductId
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x2139D9C", Offset = "0x2139D9C", VA = "0x2139D9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public string PackageName
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x21432C0", Offset = "0x21432C0", VA = "0x21432C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public string OrderId
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x21432DC", Offset = "0x21432DC", VA = "0x21432DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		public string PurchaseToken
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x213F9D4", Offset = "0x213F9D4", VA = "0x213F9D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		public State PurchaseState
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x2139D74", Offset = "0x2139D74", VA = "0x2139D74")]
			get
			{
				return default(State);
			}
		}

		[Token(Token = "0x17000020")]
		public long PurchaseTime
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x2139110", Offset = "0x2139110", VA = "0x2139110")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000021")]
		public bool Acknowledged
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x21429A4", Offset = "0x21429A4", VA = "0x21429A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000022")]
		public bool AutoRenewing
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x21432F8", Offset = "0x21432F8", VA = "0x21432F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000023")]
		public Identifiers AccountIdentifiers
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x2143314", Offset = "0x2143314", VA = "0x2143314")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		public string JsonReceipt
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x213AEE4", Offset = "0x213AEE4", VA = "0x213AEE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		public string TransactionId
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x213AEF0", Offset = "0x213AEF0", VA = "0x213AEF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x2138FD0", Offset = "0x2138FD0", VA = "0x2138FD0")]
		public static bool FromJson(string jsonPurchaseData, string signature, out Purchase purchase)
		{
			return default(bool);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x214331C", Offset = "0x214331C", VA = "0x214331C")]
		private Purchase(PurchaseData purchaseData, string jsonPurchaseData, string signature)
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class PurchasesUpdatedListener : AndroidJavaProxy
	{
		[Serializable]
		[Token(Token = "0x2000042")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9943B8", Offset = "0x9943B8")]
		private sealed class <>c
		{
			[Token(Token = "0x4000108")]
			[FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000109")]
			[FieldOffset(Offset = "0x8")]
			public static Action<AndroidJavaObject, AndroidJavaObject> <>9__3_0;

			[Token(Token = "0x600015E")]
			[Address(RVA = "0x2147D78", Offset = "0x2147D78", VA = "0x2147D78")]
			public <>c()
			{
			}

			[Token(Token = "0x600015F")]
			[Address(RVA = "0x2147D80", Offset = "0x2147D80", VA = "0x2147D80")]
			internal void <.ctor>b__3_0(AndroidJavaObject <p0>, AndroidJavaObject <p1>)
			{
			}
		}

		[Token(Token = "0x14000014")]
		public event Action<AndroidJavaObject, AndroidJavaObject> OnPurchasesUpdated
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x21406BC", Offset = "0x21406BC", VA = "0x21406BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994BC0", Offset = "0x994BC0")]
			add
			{
			}
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x2146044", Offset = "0x2146044", VA = "0x2146044")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994BD0", Offset = "0x994BD0")]
			remove
			{
			}
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x2140558", Offset = "0x2140558", VA = "0x2140558")]
		public PurchasesUpdatedListener()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x21460E4", Offset = "0x21460E4", VA = "0x21460E4")]
		private void onPurchasesUpdated(AndroidJavaObject billingResult, AndroidJavaObject purchasesList)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000022")]
	public class SkuDetails
	{
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x10")]
		public string productId;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x18")]
		public string type;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x20")]
		public string title;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x28")]
		public string description;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x30")]
		public string skuDetailsToken;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x38")]
		public string iconUrl;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x40")]
		public string price;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x48")]
		public long price_amount_micros;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x50")]
		public string price_currency_code;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x58")]
		public string original_price;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x60")]
		public long original_price_amount_micros;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x68")]
		public string subscriptionPeriod;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x70")]
		public string freeTrialPeriod;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x78")]
		public string introductoryPrice;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x80")]
		public long introductoryPriceAmountMicros;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x88")]
		public string introductoryPricePeriod;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x90")]
		public int introductoryPriceCycles;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994618", Offset = "0x994618")]
		private string <JsonSkuDetails>k__BackingField;

		[Token(Token = "0x17000026")]
		public string JsonSkuDetails
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x2146190", Offset = "0x2146190", VA = "0x2146190")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994BE0", Offset = "0x994BE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x2146198", Offset = "0x2146198", VA = "0x2146198")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994BF0", Offset = "0x994BF0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2138B80", Offset = "0x2138B80", VA = "0x2138B80")]
		public static bool FromJson(string jsonSkuDetails, out SkuDetails skuDetails)
		{
			return default(bool);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x213D4BC", Offset = "0x213D4BC", VA = "0x213D4BC")]
		public AndroidJavaObject ToJava()
		{
			return null;
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x21461A0", Offset = "0x21461A0", VA = "0x21461A0")]
		public SkuDetails()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class SkuDetailsResponseListener : AndroidJavaProxy
	{
		[Serializable]
		[Token(Token = "0x2000043")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9943C8", Offset = "0x9943C8")]
		private sealed class <>c
		{
			[Token(Token = "0x400010A")]
			[FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400010B")]
			[FieldOffset(Offset = "0x8")]
			public static Action<SkuType, AndroidJavaObject, AndroidJavaObject> <>9__4_0;

			[Token(Token = "0x6000161")]
			[Address(RVA = "0x2147DE8", Offset = "0x2147DE8", VA = "0x2147DE8")]
			public <>c()
			{
			}

			[Token(Token = "0x6000162")]
			[Address(RVA = "0x2147DF0", Offset = "0x2147DF0", VA = "0x2147DF0")]
			internal void <.ctor>b__4_0(SkuType <p0>, AndroidJavaObject <p1>, AndroidJavaObject <p2>)
			{
			}
		}

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x20")]
		private readonly SkuType _skuType;

		[Token(Token = "0x14000015")]
		public event Action<SkuType, AndroidJavaObject, AndroidJavaObject> OnSkuDetailsResponse
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x2141364", Offset = "0x2141364", VA = "0x2141364")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994C00", Offset = "0x994C00")]
			add
			{
			}
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x21461A8", Offset = "0x21461A8", VA = "0x21461A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x994C10", Offset = "0x994C10")]
			remove
			{
			}
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x21411E4", Offset = "0x21411E4", VA = "0x21411E4")]
		public SkuDetailsResponseListener(SkuType skuType)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2146248", Offset = "0x2146248", VA = "0x2146248")]
		private void onSkuDetailsResponse(AndroidJavaObject billingResult, AndroidJavaObject skuDetailsList)
		{
		}
	}
	[Token(Token = "0x2000024")]
	public sealed class SkuType
	{
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x10")]
		private readonly string _description;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SkuType Unknown;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x8")]
		public static readonly SkuType InApp;

		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x10")]
		public static readonly SkuType Subs;

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x21462B8", Offset = "0x21462B8", VA = "0x21462B8")]
		private SkuType(string description)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x21462EC", Offset = "0x21462EC", VA = "0x21462EC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
