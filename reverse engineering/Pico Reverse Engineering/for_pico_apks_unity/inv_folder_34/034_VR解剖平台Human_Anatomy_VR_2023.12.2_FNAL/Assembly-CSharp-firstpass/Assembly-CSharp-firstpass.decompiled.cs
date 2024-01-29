using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using DG.Tweening.Core;
using DG.Tweening.Plugins;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Google.Play.Billing;
using Google.Play.Billing.Internal;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
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
		[Token(Token = "0x17000001")]
		public string Id
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x155542C", Offset = "0x155542C", VA = "0x155542C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x1555434", Offset = "0x1555434", VA = "0x1555434")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public string Title
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x155543C", Offset = "0x155543C", VA = "0x155543C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x1555444", Offset = "0x1555444", VA = "0x1555444")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public string Description
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x155544C", Offset = "0x155544C", VA = "0x155544C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x1555454", Offset = "0x1555454", VA = "0x1555454")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public decimal Price
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x155545C", Offset = "0x155545C", VA = "0x155545C")]
			[CompilerGenerated]
			get
			{
				return default(decimal);
			}
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x1555468", Offset = "0x1555468", VA = "0x1555468")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public string PriceString
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x1555470", Offset = "0x1555470", VA = "0x1555470")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x1555478", Offset = "0x1555478", VA = "0x1555478")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public decimal OriginalPrice
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x1555480", Offset = "0x1555480", VA = "0x1555480")]
			[CompilerGenerated]
			get
			{
				return default(decimal);
			}
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x155548C", Offset = "0x155548C", VA = "0x155548C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public string OriginalPriceString
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x1555494", Offset = "0x1555494", VA = "0x1555494")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x155549C", Offset = "0x155549C", VA = "0x155549C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public string Currency
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x15554A4", Offset = "0x15554A4", VA = "0x15554A4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x15554AC", Offset = "0x15554AC", VA = "0x15554AC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public string IconUrl
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x15554B4", Offset = "0x15554B4", VA = "0x15554B4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x15554BC", Offset = "0x15554BC", VA = "0x15554BC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public Receipt Receipt
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x15554C4", Offset = "0x15554C4", VA = "0x15554C4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x15554CC", Offset = "0x15554CC", VA = "0x15554CC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x15554D4", Offset = "0x15554D4", VA = "0x15554D4")]
		public Product()
		{
		}
	}
	[Token(Token = "0x2000004")]
	public class Receipt
	{
		[Token(Token = "0x1700000B")]
		public string ProductId
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x15554DC", Offset = "0x15554DC", VA = "0x15554DC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x15554E4", Offset = "0x15554E4", VA = "0x15554E4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public DateTime OriginalPurchaseDate
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x15554EC", Offset = "0x15554EC", VA = "0x15554EC")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x15554F4", Offset = "0x15554F4", VA = "0x15554F4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public DateTime PurchaseDate
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x15554FC", Offset = "0x15554FC", VA = "0x15554FC")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x1555504", Offset = "0x1555504", VA = "0x1555504")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public int Quantity
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x155550C", Offset = "0x155550C", VA = "0x155550C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x1555514", Offset = "0x1555514", VA = "0x1555514")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x155551C", Offset = "0x155551C", VA = "0x155551C")]
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
		[Token(Token = "0x1700000F")]
		public TimeSpan Period
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x1555524", Offset = "0x1555524", VA = "0x1555524")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x155552C", Offset = "0x155552C", VA = "0x155552C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public bool HasFreeTrial
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x1555534", Offset = "0x1555534", VA = "0x1555534")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x155553C", Offset = "0x155553C", VA = "0x155553C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public TimeSpan FreeTrialPeriod
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x1555548", Offset = "0x1555548", VA = "0x1555548")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x1555550", Offset = "0x1555550", VA = "0x1555550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public TimeSpan RemainingTime
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x1555558", Offset = "0x1555558", VA = "0x1555558")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x1555560", Offset = "0x1555560", VA = "0x1555560")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public decimal IntroductoryPrice
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x1555568", Offset = "0x1555568", VA = "0x1555568")]
			[CompilerGenerated]
			get
			{
				return default(decimal);
			}
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x1555574", Offset = "0x1555574", VA = "0x1555574")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public TimeSpan IntroductoryPricePeriod
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x155557C", Offset = "0x155557C", VA = "0x155557C")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x1555584", Offset = "0x1555584", VA = "0x1555584")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public string IntroductoryPriceString
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x155558C", Offset = "0x155558C", VA = "0x155558C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x1555594", Offset = "0x1555594", VA = "0x1555594")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public long IntroductoryPriceCycles
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x155559C", Offset = "0x155559C", VA = "0x155559C")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x15555A4", Offset = "0x15555A4", VA = "0x15555A4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public DateTime ExpireDate
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x15555AC", Offset = "0x15555AC", VA = "0x15555AC")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x15555B4", Offset = "0x15555B4", VA = "0x15555B4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public int MonthsCount
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x15555BC", Offset = "0x15555BC", VA = "0x15555BC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000019")]
		public SubscriptionPeriod SubscriptionPeriod
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x15555F8", Offset = "0x15555F8", VA = "0x15555F8")]
			get
			{
				return default(SubscriptionPeriod);
			}
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x15557CC", Offset = "0x15557CC", VA = "0x15557CC")]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly IPurchaseController PurchaseController;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly IPurchaseModalView PurchaseModalView;

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x15557D4", Offset = "0x15557D4", VA = "0x15557D4")]
		public PurchaseControllerView(IPurchaseController purchaseController, IPurchaseModalView purchaseModalView)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x15559A4", Offset = "0x15559A4", VA = "0x15559A4")]
		private void OnPurchaseModalViewDeclined(string productId)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1555A48", Offset = "0x1555A48", VA = "0x1555A48")]
		private void OnPurchaseModalViewConfirmed(string productId)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x1555B6C", Offset = "0x1555B6C", VA = "0x1555B6C")]
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
			[Address(RVA = "0x1555D8C", Offset = "0x1555D8C", VA = "0x1555D8C", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x1555E3C", Offset = "0x1555E3C", VA = "0x1555E3C", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event Action<string> PurchaseFailed
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x1555EEC", Offset = "0x1555EEC", VA = "0x1555EEC", Slot = "6")]
			add
			{
			}
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x1555EF0", Offset = "0x1555EF0", VA = "0x1555EF0", Slot = "7")]
			remove
			{
			}
		}

		[Token(Token = "0x14000008")]
		public event Action Initialized
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x1555EF4", Offset = "0x1555EF4", VA = "0x1555EF4", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x1555F90", Offset = "0x1555F90", VA = "0x1555F90", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x155602C", Offset = "0x155602C", VA = "0x155602C", Slot = "10")]
		public void InitiatePurchase(string productId)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1556048", Offset = "0x1556048", VA = "0x1556048", Slot = "11")]
		public Subscription GetSubscription(string productId)
		{
			return null;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x15560B8", Offset = "0x15560B8", VA = "0x15560B8", Slot = "12")]
		public Product GetProduct(string productId)
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1556128", Offset = "0x1556128", VA = "0x1556128", Slot = "13")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1556130", Offset = "0x1556130", VA = "0x1556130", Slot = "14")]
		public bool IsPurchased(string productId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1556138", Offset = "0x1556138", VA = "0x1556138", Slot = "15")]
		public bool IsSubscribed(string productId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1556140", Offset = "0x1556140", VA = "0x1556140", Slot = "16")]
		public void RestoreTransactions(Action<bool> callback)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x155615C", Offset = "0x155615C", VA = "0x155615C")]
		public PurchaseControllerBlank()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class PurchaseControllerDebug : IPurchaseController
	{
		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly List<string> _purchasedProducts;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Subscription[] _subscriptions;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Product[] _products;

		[Token(Token = "0x14000009")]
		public event Action<string> PurchaseSuccessful
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x1556164", Offset = "0x1556164", VA = "0x1556164", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x1556214", Offset = "0x1556214", VA = "0x1556214", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public event Action<string> PurchaseFailed
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x15562C4", Offset = "0x15562C4", VA = "0x15562C4", Slot = "6")]
			add
			{
			}
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x15562C8", Offset = "0x15562C8", VA = "0x15562C8", Slot = "7")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		public event Action Initialized
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x15562CC", Offset = "0x15562CC", VA = "0x15562CC", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x1556368", Offset = "0x1556368", VA = "0x1556368", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1556404", Offset = "0x1556404", VA = "0x1556404")]
		public PurchaseControllerDebug(Product[] products, Subscription[] subscriptions)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x15564BC", Offset = "0x15564BC", VA = "0x15564BC", Slot = "15")]
		public bool IsSubscribed(string productId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x155657C", Offset = "0x155657C", VA = "0x155657C", Slot = "16")]
		public void RestoreTransactions(Action<bool> callback)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1556598", Offset = "0x1556598", VA = "0x1556598", Slot = "12")]
		public Product GetProduct(string productId)
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1556684", Offset = "0x1556684", VA = "0x1556684", Slot = "13")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x155668C", Offset = "0x155668C", VA = "0x155668C", Slot = "10")]
		public void InitiatePurchase(string productId)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1556790", Offset = "0x1556790", VA = "0x1556790", Slot = "11")]
		public Subscription GetSubscription(string productId)
		{
			return null;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x15564C0", Offset = "0x15564C0", VA = "0x15564C0", Slot = "14")]
		public bool IsPurchased(string productId)
		{
			return default(bool);
		}
	}
}
namespace VE.IAP.PurchaseControllers.Unity
{
	[Token(Token = "0x200000D")]
	public class AppleExtensions
	{
		[Token(Token = "0x200000E")]
		private enum SubscriptionPeriodUnit
		{
			[Token(Token = "0x400002D")]
			Day,
			[Token(Token = "0x400002E")]
			Week,
			[Token(Token = "0x400002F")]
			Month,
			[Token(Token = "0x4000030")]
			Year,
			[Token(Token = "0x4000031")]
			NotAvailable
		}

		[Token(Token = "0x200000F")]
		private class ProductDetails
		{
			[Token(Token = "0x4000032")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int subscriptionNumberOfUnits;

			[Token(Token = "0x4000033")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public SubscriptionPeriodUnit subscriptionPeriodUnit;

			[Token(Token = "0x4000034")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float localizedPrice;

			[Token(Token = "0x4000035")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string isoCurrencyCode;

			[Token(Token = "0x4000036")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string localizedPriceString;

			[Token(Token = "0x4000037")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string localizedTitle;

			[Token(Token = "0x4000038")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string localizedDescription;

			[Token(Token = "0x4000039")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float introductoryPrice;

			[Token(Token = "0x400003A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string introductoryPriceLocale;

			[Token(Token = "0x400003B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public int introductoryPriceNumberOfPeriods;

			[Token(Token = "0x400003C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public int numberOfUnits;

			[Token(Token = "0x400003D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public SubscriptionPeriodUnit unit;

			[Token(Token = "0x6000070")]
			[Address(RVA = "0x1556F08", Offset = "0x1556F08", VA = "0x1556F08")]
			public ProductDetails()
			{
			}
		}

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IAppleExtensions _appleExtensions;

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x15568C4", Offset = "0x15568C4", VA = "0x15568C4")]
		public AppleExtensions(IExtensionProvider extensions)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x15569A4", Offset = "0x15569A4", VA = "0x15569A4")]
		public Subscription GetSubscription(UnityEngine.Purchasing.Product product)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1556E5C", Offset = "0x1556E5C", VA = "0x1556E5C")]
		public void RestoreTransactions(Action<bool> callback)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1556CE4", Offset = "0x1556CE4", VA = "0x1556CE4")]
		private static TimeSpan GetSubscriptionPeriod(SubscriptionPeriodUnit unit, int numberOfUnits)
		{
			return default(TimeSpan);
		}
	}
	[Token(Token = "0x2000010")]
	public class GooglePlayBillingExtensions
	{
		[Serializable]
		[Token(Token = "0x2000011")]
		public class PurchaseReceipt
		{
			[Token(Token = "0x400003F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string json;

			[Token(Token = "0x4000040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string signature;

			[Token(Token = "0x6000076")]
			[Address(RVA = "0x1557D3C", Offset = "0x1557D3C", VA = "0x1557D3C")]
			public PurchaseReceipt(string jsonPurchaseData, string signature)
			{
			}
		}

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Google.Play.Billing.IGooglePlayStoreExtensions _googlePlayStoreExtensions;

		[Token(Token = "0x1700001A")]
		public static IPurchasingModule Module
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x1556FF0", Offset = "0x1556FF0", VA = "0x1556FF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1556F10", Offset = "0x1556F10", VA = "0x1556F10")]
		public GooglePlayBillingExtensions(IExtensionProvider extensions)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1557168", Offset = "0x1557168", VA = "0x1557168")]
		public Subscription GetSubscriptionFromGooglePlayJson(string productId, string receipt)
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1557C90", Offset = "0x1557C90", VA = "0x1557C90")]
		public void RestoreTransactions(Action<bool> callback)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x155781C", Offset = "0x155781C", VA = "0x155781C")]
		public static TimeSpan ISO8601ToTimeSpan(string value)
		{
			return default(TimeSpan);
		}
	}
	[Token(Token = "0x2000012")]
	public class PurchaseControllerUnity : IPurchaseController, IStoreListener
	{
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ProductCatalog _catalog;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private IStoreController _controller;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IExtensionProvider _extensions;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GooglePlayBillingExtensions _googlePlayBillingExtensions;

		[Token(Token = "0x1400000C")]
		public event Action<string> PurchaseSuccessful
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x1557D80", Offset = "0x1557D80", VA = "0x1557D80", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x1557E30", Offset = "0x1557E30", VA = "0x1557E30", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000D")]
		public event Action<string> PurchaseFailed
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x1557EE0", Offset = "0x1557EE0", VA = "0x1557EE0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x1557F90", Offset = "0x1557F90", VA = "0x1557F90", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public event Action Initialized
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x1558040", Offset = "0x1558040", VA = "0x1558040", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x15580DC", Offset = "0x15580DC", VA = "0x15580DC", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1558178", Offset = "0x1558178", VA = "0x1558178")]
		public PurchaseControllerUnity()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x15589D8", Offset = "0x15589D8", VA = "0x15589D8", Slot = "10")]
		public void InitiatePurchase(string productId)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1558C5C", Offset = "0x1558C5C", VA = "0x1558C5C", Slot = "12")]
		public Product GetProduct(string productId)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1558E14", Offset = "0x1558E14", VA = "0x1558E14", Slot = "11")]
		public Subscription GetSubscription(string productId)
		{
			return null;
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1558C98", Offset = "0x1558C98", VA = "0x1558C98")]
		public UnityEngine.Purchasing.Product GetUnityProduct(string productId)
		{
			return null;
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1558EAC", Offset = "0x1558EAC", VA = "0x1558EAC", Slot = "14")]
		public bool IsPurchased(string productId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1559040", Offset = "0x1559040", VA = "0x1559040", Slot = "15")]
		public bool IsSubscribed(string productId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1559044", Offset = "0x1559044", VA = "0x1559044", Slot = "18")]
		public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
		{
			return default(PurchaseProcessingResult);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1559088", Offset = "0x1559088", VA = "0x1559088", Slot = "20")]
		public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x15593B8", Offset = "0x15593B8", VA = "0x15593B8", Slot = "17")]
		public void OnInitializeFailed(InitializationFailureReason error)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1559484", Offset = "0x1559484", VA = "0x1559484", Slot = "19")]
		public void OnPurchaseFailed(UnityEngine.Purchasing.Product product, PurchaseFailureReason failureReason)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1558194", Offset = "0x1558194", VA = "0x1558194")]
		private void InitializePurchasing()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1558C3C", Offset = "0x1558C3C", VA = "0x1558C3C", Slot = "13")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1559588", Offset = "0x1559588", VA = "0x1559588", Slot = "16")]
		public void RestoreTransactions(Action<bool> callback)
		{
		}
	}
	[Token(Token = "0x2000015")]
	public static class UnityIAPExtensions
	{
		[Serializable]
		[Token(Token = "0x2000016")]
		public class JsonReceipt
		{
			[Token(Token = "0x400004B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Store;

			[Token(Token = "0x400004C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string TransactionID;

			[Token(Token = "0x400004D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string Payload;

			[Token(Token = "0x6000095")]
			[Address(RVA = "0x1557A44", Offset = "0x1557A44", VA = "0x1557A44")]
			public static bool FromJson(string value, out JsonReceipt jsonReceipt)
			{
				return default(bool);
			}

			[Token(Token = "0x6000096")]
			[Address(RVA = "0x1559A84", Offset = "0x1559A84", VA = "0x1559A84")]
			public JsonReceipt()
			{
			}
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1556BF8", Offset = "0x1556BF8", VA = "0x1556BF8")]
		public static Product SetFromUnityProduct(this Product product, UnityEngine.Purchasing.Product unityProduct)
		{
			return null;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1559708", Offset = "0x1559708", VA = "0x1559708")]
		public static Product GetProduct(UnityEngine.Purchasing.Product unityProduct)
		{
			return null;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1559780", Offset = "0x1559780", VA = "0x1559780")]
		private static bool CheckIfProductIsAvailableForSubscriptionManager(string receipt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x15598FC", Offset = "0x15598FC", VA = "0x15598FC")]
		public static SubscriptionInfo GetSubscriptionInfo(UnityEngine.Purchasing.Product product)
		{
			return null;
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x15599A4", Offset = "0x15599A4", VA = "0x15599A4")]
		public static Subscription GetSubscription(UnityEngine.Purchasing.Product unityProduct)
		{
			return null;
		}
	}
}
namespace Google.Play.Billing
{
	[Token(Token = "0x2000017")]
	public class GooglePlayStoreImpl : IStore, IGooglePlayStoreExtensions, IStoreExtension, IGooglePlayConfiguration, IStoreConfiguration
	{
		[Token(Token = "0x2000018")]
		private enum AsyncRequestStatus
		{
			[Token(Token = "0x400005C")]
			Pending,
			[Token(Token = "0x400005D")]
			Failed,
			[Token(Token = "0x400005E")]
			Succeed
		}

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AndroidJavaObject _billingClient;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private BillingClientStateListener _billingClientStateListener;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Action<Product> _deferredPurchaseListener;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IStoreCallback _callback;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly GooglePlayBillingInventory _inventory;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly GooglePlayBillingUtil _billingUtil;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly JniUtils _jniUtils;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<SkuType, AsyncRequestStatus> _billingClientQuerySkuDetailsCallStatus;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _billingClientReady;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ProductDefinition _productInPurchaseFlow;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string _obfuscatedProfileId;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string _obfuscatedAccountId;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool _deferredPurchasesEnabled;

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1559A8C", Offset = "0x1559A8C", VA = "0x1559A8C")]
		public GooglePlayStoreImpl(GooglePlayBillingUtil googlePlayBillingUtil)
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1559E4C", Offset = "0x1559E4C", VA = "0x1559E4C", Slot = "4")]
		public void Initialize(IStoreCallback callback)
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1559E54", Offset = "0x1559E54", VA = "0x1559E54", Slot = "5")]
		public void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products)
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x155A644", Offset = "0x155A644", VA = "0x155A644")]
		private void RetrieveProductsInternal(ReadOnlyCollection<ProductDefinition> products)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x155B2BC", Offset = "0x155B2BC", VA = "0x155B2BC", Slot = "6")]
		public void Purchase(ProductDefinition product, string developerPayload)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x155C010", Offset = "0x155C010", VA = "0x155C010", Slot = "7")]
		public void FinishTransaction(ProductDefinition product, string transactionId)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x155CA54", Offset = "0x155CA54", VA = "0x155CA54", Slot = "8")]
		public void SetObfuscatedAccountId(string accountId)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x155CADC", Offset = "0x155CADC", VA = "0x155CADC", Slot = "9")]
		public void SetObfuscatedProfileId(string profileId)
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x155CB64", Offset = "0x155CB64", VA = "0x155CB64", Slot = "15")]
		public void ConfirmSubscriptionPriceChange(string productId, Action<bool> callback)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x155D650", Offset = "0x155D650", VA = "0x155D650", Slot = "17")]
		public void EndConnection()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x155D73C", Offset = "0x155D73C", VA = "0x155D73C", Slot = "11")]
		public void UpgradeDowngradeSubscription(string oldSkuMetadata, string newSku)
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x155D7F0", Offset = "0x155D7F0", VA = "0x155D7F0", Slot = "12")]
		public void UpdateSubscription(Product oldProduct, Product newProduct, GooglePlayStoreProrationMode prorationMode)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x155E014", Offset = "0x155E014", VA = "0x155E014", Slot = "13")]
		public void RestoreTransactions(Action<bool> callback)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x155EBEC", Offset = "0x155EBEC", VA = "0x155EBEC", Slot = "14")]
		public void FinishAdditionalTransaction(string productId, string transactionId)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x155EDF0", Offset = "0x155EDF0", VA = "0x155EDF0", Slot = "10")]
		public Dictionary<string, string> GetProductJSONDictionary()
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x155F094", Offset = "0x155F094", VA = "0x155F094", Slot = "16")]
		public void SetDeferredPurchaseListener(Action<Product> callback)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x155F114", Offset = "0x155F114", VA = "0x155F114", Slot = "18")]
		public void EnableDeferredPurchase()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x155D1EC", Offset = "0x155D1EC", VA = "0x155D1EC")]
		private bool IsGooglePlayInAppBillingServiceAvailable()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x155A30C", Offset = "0x155A30C", VA = "0x155A30C")]
		private void InstantiateBillingClientAndMakeConnection()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x155F3E4", Offset = "0x155F3E4", VA = "0x155F3E4")]
		private void MarkBillingClientStartConnectionCallComplete(AndroidJavaObject billingResult)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x155AAF8", Offset = "0x155AAF8", VA = "0x155AAF8")]
		private void QuerySkuDetailsForSkuType(ReadOnlyCollection<ProductDefinition> products, SkuType skuType)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x155FEE8", Offset = "0x155FEE8", VA = "0x155FEE8")]
		private void ParseSkuDetailsResults(SkuType skuType, AndroidJavaObject billingResult, AndroidJavaObject skuDetailsList)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x155F950", Offset = "0x155F950", VA = "0x155F950")]
		private void NotifyUnityRetrieveProductsResults()
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x155A814", Offset = "0x155A814", VA = "0x155A814")]
		private BillingResponseCode QueryPurchasesForSkuType(SkuType skuType)
		{
			return default(BillingResponseCode);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x156088C", Offset = "0x156088C", VA = "0x156088C")]
		private void ParsePurchaseResult(AndroidJavaObject billingResult, AndroidJavaObject javaPurchasesList)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1561284", Offset = "0x1561284", VA = "0x1561284")]
		private void ProcessAcknowledgePurchaseResult(string skuId, SkuType skuType, AndroidJavaObject billingResult)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1561B78", Offset = "0x1561B78", VA = "0x1561B78")]
		private void ProcessConsumePurchaseResult(string skuId, AndroidJavaObject billingResult)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x155BD48", Offset = "0x155BD48", VA = "0x155BD48")]
		private void LaunchBillingFlow(AndroidJavaObject billingFlowParamBuilder)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x155C078", Offset = "0x155C078", VA = "0x155C078")]
		private void FinishTransactionInternal(Purchase purchase, ProductType productType)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x15622B0", Offset = "0x15622B0", VA = "0x15622B0")]
		private void ProcessPriceChangeResult(AndroidJavaObject billingResult, Action<bool> callback)
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class GooglePlayStoreModule : AbstractPurchasingModule
	{
		[Token(Token = "0x400007B")]
		public const string StoreName = "GooglePlay";

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IStore _storeInstance;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static GooglePlayStoreModule _moduleInstance;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static GooglePlayBillingUtil _util;

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1556FF4", Offset = "0x1556FF4", VA = "0x1556FF4")]
		public static AbstractPurchasingModule Instance()
		{
			return null;
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x15639B8", Offset = "0x15639B8", VA = "0x15639B8", Slot = "5")]
		public override void Configure()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1563A10", Offset = "0x1563A10", VA = "0x1563A10")]
		private IStore InstantiateGooglePlayBilling()
		{
			return null;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x15639B0", Offset = "0x15639B0", VA = "0x15639B0")]
		public GooglePlayStoreModule()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public enum GooglePlayStoreProrationMode
	{
		[Token(Token = "0x4000080")]
		Unknown,
		[Token(Token = "0x4000081")]
		ImmediateWithTimeProration,
		[Token(Token = "0x4000082")]
		ImmediateAndChargeProratedPrice,
		[Token(Token = "0x4000083")]
		ImmediateWithoutProration
	}
	[Token(Token = "0x2000026")]
	public class GooglePlayStoreUnsupportedException : Exception
	{
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x155D788", Offset = "0x155D788", VA = "0x155D788")]
		public GooglePlayStoreUnsupportedException(string message)
		{
		}
	}
	[Token(Token = "0x2000027")]
	public interface IGooglePlayConfiguration : IStoreConfiguration
	{
		[Token(Token = "0x60000DD")]
		void EnableDeferredPurchase();
	}
	[Token(Token = "0x2000028")]
	public interface IGooglePlayStoreExtensions : IStoreExtension
	{
		[Token(Token = "0x60000DE")]
		void SetObfuscatedAccountId(string obfuscatedAccountId);

		[Token(Token = "0x60000DF")]
		void SetObfuscatedProfileId(string obfuscatedProfileId);

		[Token(Token = "0x60000E0")]
		Dictionary<string, string> GetProductJSONDictionary();

		[Token(Token = "0x60000E1")]
		[Obsolete("Deprecated, please use IGooglePlayStoreExtensions.UpdateSubscription(...) instead.")]
		void UpgradeDowngradeSubscription(string oldSkuMetadata, string newSku);

		[Token(Token = "0x60000E2")]
		void UpdateSubscription(Product oldProduct, Product newProduct, GooglePlayStoreProrationMode prorationMode = GooglePlayStoreProrationMode.Unknown);

		[Token(Token = "0x60000E3")]
		void RestoreTransactions(Action<bool> callback);

		[Token(Token = "0x60000E4")]
		void FinishAdditionalTransaction(string productId, string transactionId);

		[Token(Token = "0x60000E5")]
		void ConfirmSubscriptionPriceChange(string productId, Action<bool> callback);

		[Token(Token = "0x60000E6")]
		void SetDeferredPurchaseListener(Action<Product> callback);

		[Token(Token = "0x60000E7")]
		void EndConnection();
	}
	[Token(Token = "0x2000029")]
	public class FakeGooglePlayConfiguration : IGooglePlayConfiguration, IStoreConfiguration
	{
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1563C6C", Offset = "0x1563C6C", VA = "0x1563C6C", Slot = "4")]
		public void EnableDeferredPurchase()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1563C70", Offset = "0x1563C70", VA = "0x1563C70")]
		public FakeGooglePlayConfiguration()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class FakeGooglePlayStoreExtensions : IGooglePlayStoreExtensions, IStoreExtension
	{
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1563C78", Offset = "0x1563C78", VA = "0x1563C78", Slot = "7")]
		public void UpgradeDowngradeSubscription(string oldSku, string newSku)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1563C7C", Offset = "0x1563C7C", VA = "0x1563C7C", Slot = "8")]
		public void UpdateSubscription(Product oldProduct, Product newProduct, GooglePlayStoreProrationMode prorationMode = GooglePlayStoreProrationMode.Unknown)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1563C80", Offset = "0x1563C80", VA = "0x1563C80", Slot = "9")]
		public void RestoreTransactions(Action<bool> callback)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1563C84", Offset = "0x1563C84", VA = "0x1563C84", Slot = "4")]
		public void SetObfuscatedAccountId(string obfuscatedAccountId)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1563C88", Offset = "0x1563C88", VA = "0x1563C88", Slot = "5")]
		public void SetObfuscatedProfileId(string obfuscatedProfileId)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1563C8C", Offset = "0x1563C8C", VA = "0x1563C8C", Slot = "6")]
		public Dictionary<string, string> GetProductJSONDictionary()
		{
			return null;
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1563C94", Offset = "0x1563C94", VA = "0x1563C94", Slot = "10")]
		public void FinishAdditionalTransaction(string productId, string transactionId)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1563C98", Offset = "0x1563C98", VA = "0x1563C98", Slot = "11")]
		public void ConfirmSubscriptionPriceChange(string productId, Action<bool> callback)
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1563C9C", Offset = "0x1563C9C", VA = "0x1563C9C", Slot = "12")]
		public void SetDeferredPurchaseListener(Action<Product> callback)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1563CA0", Offset = "0x1563CA0", VA = "0x1563CA0", Slot = "13")]
		public void EndConnection()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1563CA4", Offset = "0x1563CA4", VA = "0x1563CA4")]
		public FakeGooglePlayStoreExtensions()
		{
		}
	}
}
namespace Google.Play.Billing.Internal
{
	[Token(Token = "0x200002B")]
	public class AcknowledgeResponseListener : AndroidJavaProxy
	{
		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string _skuId;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly SkuType _skuType;

		[Token(Token = "0x1400000F")]
		public event Action<string, SkuType, AndroidJavaObject> OnAcknowledgeResponse
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x1562200", Offset = "0x1562200", VA = "0x1562200")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x1563CAC", Offset = "0x1563CAC", VA = "0x1563CAC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1562098", Offset = "0x1562098", VA = "0x1562098")]
		public AcknowledgeResponseListener(string skuId, SkuType skuType)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1563D5C", Offset = "0x1563D5C", VA = "0x1563D5C")]
		private void onAcknowledgePurchaseResponse(AndroidJavaObject billingResult)
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class BillingClientStateListener : AndroidJavaProxy
	{
		[Token(Token = "0x14000010")]
		public event Action OnBillingServiceDisconnected
		{
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x155A1C0", Offset = "0x155A1C0", VA = "0x155A1C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x1563E04", Offset = "0x1563E04", VA = "0x1563E04")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event Action<AndroidJavaObject> OnBillingSetupFinished
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x155A25C", Offset = "0x155A25C", VA = "0x155A25C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x1563EA0", Offset = "0x1563EA0", VA = "0x1563EA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1559FE4", Offset = "0x1559FE4", VA = "0x1559FE4")]
		public BillingClientStateListener()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1563F50", Offset = "0x1563F50", VA = "0x1563F50")]
		private void onBillingServiceDisconnected()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1563F74", Offset = "0x1563F74", VA = "0x1563F74")]
		private void onBillingSetupFinished(AndroidJavaObject billingResult)
		{
		}
	}
	[Token(Token = "0x200002F")]
	public enum BillingResponseCode
	{
		[Token(Token = "0x400008F")]
		ServiceTimeout = -3,
		[Token(Token = "0x4000090")]
		FeatureNotSupported,
		[Token(Token = "0x4000091")]
		ServiceDisconnected,
		[Token(Token = "0x4000092")]
		Ok,
		[Token(Token = "0x4000093")]
		UserCancelled,
		[Token(Token = "0x4000094")]
		ServiceUnavailable,
		[Token(Token = "0x4000095")]
		BillingUnavailable,
		[Token(Token = "0x4000096")]
		ItemUnavailable,
		[Token(Token = "0x4000097")]
		DeveloperError,
		[Token(Token = "0x4000098")]
		Error,
		[Token(Token = "0x4000099")]
		ItemAlreadyOwned,
		[Token(Token = "0x400009A")]
		ItemNotOwned
	}
	[Token(Token = "0x2000030")]
	internal static class Constants
	{
		[Token(Token = "0x400009B")]
		public const string Version = "3.0.0-unity";

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly TimeSpan BillingClientAsyncTimeout;

		[Token(Token = "0x400009D")]
		public const string BuildMethod = "build";

		[Token(Token = "0x400009E")]
		public const string BillingClient = "com.android.billingclient.api.BillingClientImpl";

		[Token(Token = "0x400009F")]
		public const string BillingClientSetUpMethod = "initialize";

		[Token(Token = "0x40000A0")]
		public const string BillingClientStartConnectionMethod = "startConnection";

		[Token(Token = "0x40000A1")]
		public const string BillingClientLaunchBillingFlowMethod = "launchBillingFlow";

		[Token(Token = "0x40000A2")]
		public const string BillingClientConsumePurchaseMethod = "consumeAsync";

		[Token(Token = "0x40000A3")]
		public const string BillingClientAcknowledgePurchaseMethod = "acknowledgePurchase";

		[Token(Token = "0x40000A4")]
		public const string BillingClientEndConnectionMethod = "endConnection";

		[Token(Token = "0x40000A5")]
		public const string AcknowledgeResponseListener = "com.android.billingclient.api.AcknowledgePurchaseResponseListener";

		[Token(Token = "0x40000A6")]
		public const string BillingClientStateListener = "com.android.billingclient.api.BillingClientStateListener";

		[Token(Token = "0x40000A7")]
		public const string ConsumeResponseListener = "com.android.billingclient.api.ConsumeResponseListener";

		[Token(Token = "0x40000A8")]
		public const string PurchaseUpdatedListener = "com.android.billingclient.api.PurchasesUpdatedListener";

		[Token(Token = "0x40000A9")]
		public const string AcknowledgeParamsBuilder = "com.android.billingclient.api.AcknowledgePurchaseParams$Builder";

		[Token(Token = "0x40000AA")]
		public const string AcknowledgeParamsBuilderSetPurchaseTokenMethod = "setPurchaseToken";

		[Token(Token = "0x40000AB")]
		public const string ConsumeParamsBuilder = "com.android.billingclient.api.ConsumeParams$Builder";

		[Token(Token = "0x40000AC")]
		public const string ConsumeParamsBuilderSetPurchaseTokenMethod = "setPurchaseToken";

		[Token(Token = "0x40000AD")]
		public const string BillingFlowParamsBuilder = "com.android.billingclient.api.BillingFlowParams$Builder";

		[Token(Token = "0x40000AE")]
		public const string BillingFlowParamsBuilderSetSkuDetailsMethod = "setSkuDetails";

		[Token(Token = "0x40000AF")]
		public const string BillingFlowParamsBuilderSetObfuscatedAccountIdMethod = "setObfuscatedAccountId";

		[Token(Token = "0x40000B0")]
		public const string BillingFlowParamsBuilderSetObfuscatedProfileIdMethod = "setObfuscatedProfileId";

		[Token(Token = "0x40000B1")]
		public const string BillingFlowParamsBuilderSetOldSkuMethod = "setOldSku";

		[Token(Token = "0x40000B2")]
		public const string BillingFlowParamsBuilderSetReplaceSkusProrationModeMethod = "setReplaceSkusProrationMode";

		[Token(Token = "0x40000B3")]
		public const string PurchaseGetOriginalJsonMethod = "getOriginalJson";

		[Token(Token = "0x40000B4")]
		public const string PurchaseGetSignatureMethod = "getSignature";

		[Token(Token = "0x40000B5")]
		public const string QueryPurchasesMethod = "queryPurchases";

		[Token(Token = "0x40000B6")]
		public const string PurchasesResultGetBillingResultMethod = "getBillingResult";

		[Token(Token = "0x40000B7")]
		public const string PurchasesResultGetPurchasesListMethod = "getPurchasesList";

		[Token(Token = "0x40000B8")]
		public const string SkuDetailsClass = "com.android.billingclient.api.SkuDetails";

		[Token(Token = "0x40000B9")]
		public const string SkuDetailsGetOriginalJson = "getOriginalJson";

		[Token(Token = "0x40000BA")]
		public const string SkuDetailsParamBuilder = "com.android.billingclient.api.SkuDetailsParams$Builder";

		[Token(Token = "0x40000BB")]
		public const string SkuDetailsParamBuilderSetSkuListMethod = "setSkusList";

		[Token(Token = "0x40000BC")]
		public const string SkuDetailsParamBuilderSetTypeMethod = "setType";

		[Token(Token = "0x40000BD")]
		public const string QuerySkuDetailsMethod = "querySkuDetailsAsync";

		[Token(Token = "0x40000BE")]
		public const string SkuDetailsResponseListener = "com.android.billingclient.api.SkuDetailsResponseListener";

		[Token(Token = "0x40000BF")]
		public const string PriceChangeFlowParamsBuilder = "com.android.billingclient.api.PriceChangeFlowParams$Builder";

		[Token(Token = "0x40000C0")]
		public const string PriceChangeFlowParamsBuilderSetSkuDetailsMethod = "setSkuDetails";

		[Token(Token = "0x40000C1")]
		public const string LaunchPriceChangeConfirmationFlowMethod = "launchPriceChangeConfirmationFlow";

		[Token(Token = "0x40000C2")]
		public const string PriceChangeConfirmationListener = "com.android.billingclient.api.PriceChangeConfirmationListener";
	}
	[Token(Token = "0x2000031")]
	public class ConsumeResponseListener : AndroidJavaProxy
	{
		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string _skuId;

		[Token(Token = "0x14000012")]
		public event Action<string, AndroidJavaObject> OnConsumeResponse
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x1561FCC", Offset = "0x1561FCC", VA = "0x1561FCC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x1564094", Offset = "0x1564094", VA = "0x1564094")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1561E80", Offset = "0x1561E80", VA = "0x1561E80")]
		public ConsumeResponseListener(string skuId)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1564144", Offset = "0x1564144", VA = "0x1564144")]
		private void onConsumeResponse(AndroidJavaObject billingResult, string purchaseToken)
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class GooglePlayBillingInventory
	{
		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly decimal Micros;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly object _inventoryLock;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Dictionary<string, ProductDefinition> _catalog;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Dictionary<string, string> _googlePlaySkuIdToUnityProductId;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Dictionary<string, SkuDetails> _skuDetailsInventory;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Dictionary<string, Purchase> _purchaseInventory;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly Dictionary<string, Purchase> _pendingPurchaseInventory;

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1562C44", Offset = "0x1562C44", VA = "0x1562C44")]
		public void UpdateCatalog(IEnumerable<ProductDefinition> products)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x15604CC", Offset = "0x15604CC", VA = "0x15604CC")]
		public void UpdateSkuDetailsInventory(IEnumerable<SkuDetails> skuDetailsList)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x155E754", Offset = "0x155E754", VA = "0x155E754")]
		public void UpdatePurchaseInventory(IEnumerable<Purchase> purchaseList)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x155D2B0", Offset = "0x155D2B0", VA = "0x155D2B0")]
		public bool GetUnityProductDefinition(string unityProductId, out ProductDefinition unityProduct)
		{
			return default(bool);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1561168", Offset = "0x1561168", VA = "0x1561168")]
		public bool GetUnityProductId(string googlePlaySkuId, out string unityProductId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x155BA64", Offset = "0x155BA64", VA = "0x155BA64")]
		public bool GetSkuDetails(string sku, out SkuDetails skuDetails)
		{
			return default(bool);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x155EE20", Offset = "0x155EE20", VA = "0x155EE20")]
		public Dictionary<string, string> GetAllSkuDetails()
		{
			return null;
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x155C060", Offset = "0x155C060", VA = "0x155C060")]
		public bool GetPurchase(ProductDefinition product, out Purchase purchase)
		{
			return default(bool);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x155EC98", Offset = "0x155EC98", VA = "0x155EC98")]
		public bool GetPurchase(string googlePlaySkuId, out Purchase purchase)
		{
			return default(bool);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1561CF8", Offset = "0x1561CF8", VA = "0x1561CF8")]
		public bool RemovePurchase(string skuId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1562630", Offset = "0x1562630", VA = "0x1562630")]
		public List<ProductDescription> CreateProductDescriptionList()
		{
			return null;
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x15616DC", Offset = "0x15616DC", VA = "0x15616DC")]
		public List<ProductDescription> UpdateProductDescriptionList(IEnumerable<string> googlePlaySkuIds)
		{
			return null;
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x15641EC", Offset = "0x15641EC", VA = "0x15641EC")]
		private ProductDescription GetProductDescriptionForSku(string skuId)
		{
			return null;
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1559C38", Offset = "0x1559C38", VA = "0x1559C38")]
		public GooglePlayBillingInventory()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class GooglePlayBillingUtil : MonoBehaviour
	{
		[Token(Token = "0x40000D1")]
		private const string GooglePlayBillingLoggingTag = "Google Play Store: ";

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly ILogger _logger;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<Action> _callbacks;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool _callbacksPending;

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x15645C4", Offset = "0x15645C4", VA = "0x15645C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1564630", Offset = "0x1564630", VA = "0x1564630")]
		private void Update()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x155A94C", Offset = "0x155A94C", VA = "0x155A94C")]
		public void RunOnMainThread(Action runnable)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x15648E0", Offset = "0x15648E0", VA = "0x15648E0")]
		public void LogFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x155BB78", Offset = "0x155BB78", VA = "0x155BB78")]
		public void LogWarningFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x155B97C", Offset = "0x155B97C", VA = "0x155B97C")]
		public void LogErrorFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x15649C8", Offset = "0x15649C8", VA = "0x15649C8")]
		public GooglePlayBillingUtil()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class JniUtils
	{
		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private GooglePlayBillingUtil _util;

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1559E1C", Offset = "0x1559E1C", VA = "0x1559E1C")]
		public JniUtils(GooglePlayBillingUtil util)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x155D5AC", Offset = "0x155D5AC", VA = "0x155D5AC")]
		public static AndroidJavaObject GetUnityAndroidActivity()
		{
			return null;
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x155F130", Offset = "0x155F130", VA = "0x155F130")]
		public static AndroidJavaObject GetApplicationContext()
		{
			return null;
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x155F54C", Offset = "0x155F54C", VA = "0x155F54C")]
		public BillingResponseCode GetResponseCodeFromBillingResult(AndroidJavaObject billingResult)
		{
			return default(BillingResponseCode);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x155F894", Offset = "0x155F894", VA = "0x155F894")]
		public static string GetDebugMessageFromBillingResult(AndroidJavaObject billingResult)
		{
			return null;
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x155E3C4", Offset = "0x155E3C4", VA = "0x155E3C4")]
		public BillingResponseCode GetResponseCodeFromQueryPurchasesResult(AndroidJavaObject javaPurchasesResult)
		{
			return default(BillingResponseCode);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x155FB28", Offset = "0x155FB28", VA = "0x155FB28")]
		public static AndroidJavaObject CreateJavaArrayList(params string[] inputs)
		{
			return null;
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x155FFA8", Offset = "0x155FFA8", VA = "0x155FFA8")]
		public IEnumerable<SkuDetails> ParseSkuDetailsResult(AndroidJavaObject billingResult, AndroidJavaObject skuDetailsList)
		{
			return null;
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x155E498", Offset = "0x155E498", VA = "0x155E498")]
		public IEnumerable<Purchase> ParseQueryPurchasesResult(AndroidJavaObject javaPurchasesResult)
		{
			return null;
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1560D20", Offset = "0x1560D20", VA = "0x1560D20")]
		public IEnumerable<Purchase> ParseJavaPurchaseList(AndroidJavaObject javaPurchasesList)
		{
			return null;
		}
	}
	[Token(Token = "0x2000037")]
	public class PriceChangeConfirmationListener : AndroidJavaProxy
	{
		[Token(Token = "0x14000013")]
		public event Action<AndroidJavaObject> OnPriceChangeConfirmationResult
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x155D4FC", Offset = "0x155D4FC", VA = "0x155D4FC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x1564B00", Offset = "0x1564B00", VA = "0x1564B00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x155D3C4", Offset = "0x155D3C4", VA = "0x155D3C4")]
		public PriceChangeConfirmationListener()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1564BB0", Offset = "0x1564BB0", VA = "0x1564BB0")]
		private void onPriceChangeConfirmationResult(AndroidJavaObject billingResult)
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class Purchase
	{
		[Token(Token = "0x200003A")]
		public class Identifiers
		{
			[Token(Token = "0x40000DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private string _obfuscatedAccountId;

			[Token(Token = "0x40000DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private string _obfuscatedProfileId;

			[Token(Token = "0x17000026")]
			public string ObfuscatedAccountId
			{
				[Token(Token = "0x6000148")]
				[Address(RVA = "0x1564E28", Offset = "0x1564E28", VA = "0x1564E28")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000027")]
			public string ObfuscatedProfileId
			{
				[Token(Token = "0x6000149")]
				[Address(RVA = "0x1564E30", Offset = "0x1564E30", VA = "0x1564E30")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600014A")]
			[Address(RVA = "0x1564DA0", Offset = "0x1564DA0", VA = "0x1564DA0")]
			public Identifiers(string obfuscatedAccountId, string obfuscatedProfileId)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200003B")]
		private class PurchaseData
		{
			[Token(Token = "0x40000DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string productId;

			[Token(Token = "0x40000DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string packageName;

			[Token(Token = "0x40000E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string orderId;

			[Token(Token = "0x40000E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string token;

			[Token(Token = "0x40000E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string purchaseToken;

			[Token(Token = "0x40000E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int purchaseState;

			[Token(Token = "0x40000E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public long purchaseTime;

			[Token(Token = "0x40000E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public bool acknowledged;

			[Token(Token = "0x40000E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
			public bool autoRenewing;

			[Token(Token = "0x40000E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string obfuscatedAccountId;

			[Token(Token = "0x40000E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public string obfuscatedProfileId;

			[Token(Token = "0x600014B")]
			[Address(RVA = "0x1564E38", Offset = "0x1564E38", VA = "0x1564E38")]
			public PurchaseData()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200003C")]
		private class PurchaseReceipt
		{
			[Token(Token = "0x40000E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string json;

			[Token(Token = "0x40000EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string signature;

			[Token(Token = "0x600014C")]
			[Address(RVA = "0x1564DE4", Offset = "0x1564DE4", VA = "0x1564DE4")]
			public PurchaseReceipt(string jsonPurchaseData, string signature)
			{
			}
		}

		[Token(Token = "0x200003D")]
		public enum State
		{
			[Token(Token = "0x40000EC")]
			UnspecifiedState,
			[Token(Token = "0x40000ED")]
			Purchased,
			[Token(Token = "0x40000EE")]
			Pending
		}

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly PurchaseData _purchaseData;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Identifiers _identifiers;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly PurchaseReceipt _purchaseReceipt;

		[Token(Token = "0x1700001B")]
		public string ProductId
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x155DFB4", Offset = "0x155DFB4", VA = "0x155DFB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public string PackageName
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x1564C50", Offset = "0x1564C50", VA = "0x1564C50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public string OrderId
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x1564C6C", Offset = "0x1564C6C", VA = "0x1564C6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		public string PurchaseToken
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x155DFD0", Offset = "0x155DFD0", VA = "0x155DFD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		public State PurchaseState
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x1561138", Offset = "0x1561138", VA = "0x1561138")]
			get
			{
				return default(State);
			}
		}

		[Token(Token = "0x17000020")]
		public long PurchaseTime
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x1557C74", Offset = "0x1557C74", VA = "0x1557C74")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000021")]
		public bool Acknowledged
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x156207C", Offset = "0x156207C", VA = "0x156207C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000022")]
		public bool AutoRenewing
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x1564C88", Offset = "0x1564C88", VA = "0x1564C88")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000023")]
		public Identifiers AccountIdentifiers
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x1564CA4", Offset = "0x1564CA4", VA = "0x1564CA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		public string JsonReceipt
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x15637BC", Offset = "0x15637BC", VA = "0x15637BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		public string TransactionId
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x155EDAC", Offset = "0x155EDAC", VA = "0x155EDAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1557B3C", Offset = "0x1557B3C", VA = "0x1557B3C")]
		public static bool FromJson(string jsonPurchaseData, string signature, out Purchase purchase)
		{
			return default(bool);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1564CAC", Offset = "0x1564CAC", VA = "0x1564CAC")]
		private Purchase(PurchaseData purchaseData, string jsonPurchaseData, string signature)
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class PurchasesUpdatedListener : AndroidJavaProxy
	{
		[Token(Token = "0x14000014")]
		public event Action<AndroidJavaObject, AndroidJavaObject> OnPurchasesUpdated
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x155F334", Offset = "0x155F334", VA = "0x155F334")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x1564E48", Offset = "0x1564E48", VA = "0x1564E48")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x155F1FC", Offset = "0x155F1FC", VA = "0x155F1FC")]
		public PurchasesUpdatedListener()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1564EF8", Offset = "0x1564EF8", VA = "0x1564EF8")]
		private void onPurchasesUpdated(AndroidJavaObject billingResult, AndroidJavaObject purchasesList)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000040")]
	public class SkuDetails
	{
		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string productId;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string type;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string title;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string description;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string skuDetailsToken;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string iconUrl;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string price;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public long price_amount_micros;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string price_currency_code;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string original_price;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public long original_price_amount_micros;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string subscriptionPeriod;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string freeTrialPeriod;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public string introductoryPrice;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public long introductoryPriceAmountMicros;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string introductoryPricePeriod;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public int introductoryPriceCycles;

		[Token(Token = "0x17000028")]
		public string JsonSkuDetails
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x1564F98", Offset = "0x1564F98", VA = "0x1564F98")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x1564FA0", Offset = "0x1564FA0", VA = "0x1564FA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1557710", Offset = "0x1557710", VA = "0x1557710")]
		public static bool FromJson(string jsonSkuDetails, out SkuDetails skuDetails)
		{
			return default(bool);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x155BC60", Offset = "0x155BC60", VA = "0x155BC60")]
		public AndroidJavaObject ToJava()
		{
			return null;
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1564FA8", Offset = "0x1564FA8", VA = "0x1564FA8")]
		public SkuDetails()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class SkuDetailsResponseListener : AndroidJavaProxy
	{
		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly SkuType _skuType;

		[Token(Token = "0x14000015")]
		public event Action<SkuType, AndroidJavaObject, AndroidJavaObject> OnSkuDetailsResponse
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x155FE38", Offset = "0x155FE38", VA = "0x155FE38")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x1564FB0", Offset = "0x1564FB0", VA = "0x1564FB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x155FCEC", Offset = "0x155FCEC", VA = "0x155FCEC")]
		public SkuDetailsResponseListener(SkuType skuType)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1565060", Offset = "0x1565060", VA = "0x1565060")]
		private void onSkuDetailsResponse(AndroidJavaObject billingResult, AndroidJavaObject skuDetailsList)
		{
		}
	}
	[Token(Token = "0x2000043")]
	public sealed class SkuType
	{
		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string _description;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SkuType Unknown;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly SkuType InApp;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly SkuType Subs;

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x156510C", Offset = "0x156510C", VA = "0x156510C")]
		private SkuType(string description)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x156513C", Offset = "0x156513C", VA = "0x156513C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x2000044")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1565284", Offset = "0x1565284", VA = "0x1565284")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1565438", Offset = "0x1565438", VA = "0x1565438")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x15655C4", Offset = "0x15655C4", VA = "0x15655C4")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1565764", Offset = "0x1565764", VA = "0x1565764")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x15657CC", Offset = "0x15657CC", VA = "0x15657CC")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1565834", Offset = "0x1565834", VA = "0x1565834")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x156588C", Offset = "0x156588C", VA = "0x156588C")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1565904", Offset = "0x1565904", VA = "0x1565904")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x156595C", Offset = "0x156595C", VA = "0x156595C")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x15659B4", Offset = "0x15659B4", VA = "0x15659B4")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1565A0C", Offset = "0x1565A0C", VA = "0x1565A0C")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x1565A64", Offset = "0x1565A64", VA = "0x1565A64")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x1565AC4", Offset = "0x1565AC4", VA = "0x1565AC4")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x1565B20", Offset = "0x1565B20", VA = "0x1565B20")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x1565B78", Offset = "0x1565B78", VA = "0x1565B78")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000048")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x1565C98", Offset = "0x1565C98", VA = "0x1565C98")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x1565E50", Offset = "0x1565E50", VA = "0x1565E50")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x1565FFC", Offset = "0x1565FFC", VA = "0x1565FFC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x15661A8", Offset = "0x15661A8", VA = "0x15661A8")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x1566354", Offset = "0x1566354", VA = "0x1566354")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x1566508", Offset = "0x1566508", VA = "0x1566508")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1566770", Offset = "0x1566770", VA = "0x1566770")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x1566C7C", Offset = "0x1566C7C", VA = "0x1566C7C")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1566EF0", Offset = "0x1566EF0", VA = "0x1566EF0")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1567184", Offset = "0x1567184", VA = "0x1567184")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1567358", Offset = "0x1567358", VA = "0x1567358")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x2000054")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x156796C", Offset = "0x156796C", VA = "0x156796C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1567B1C", Offset = "0x1567B1C", VA = "0x1567B1C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1567CC4", Offset = "0x1567CC4", VA = "0x1567CC4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1567E6C", Offset = "0x1567E6C", VA = "0x1567E6C")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1567FFC", Offset = "0x1567FFC", VA = "0x1567FFC")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1568430", Offset = "0x1568430", VA = "0x1568430")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1568724", Offset = "0x1568724", VA = "0x1568724")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1568A3C", Offset = "0x1568A3C", VA = "0x1568A3C")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1568C10", Offset = "0x1568C10", VA = "0x1568C10")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x200005E")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x156923C", Offset = "0x156923C", VA = "0x156923C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x15693F0", Offset = "0x15693F0", VA = "0x15693F0")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x156957C", Offset = "0x156957C", VA = "0x156957C")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x1569758", Offset = "0x1569758", VA = "0x1569758")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000062")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x2000063")]
		public static class Utils
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x156E50C", Offset = "0x156E50C", VA = "0x156E50C")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1569A50", Offset = "0x1569A50", VA = "0x1569A50")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x1569BDC", Offset = "0x1569BDC", VA = "0x1569BDC")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x1569D90", Offset = "0x1569D90", VA = "0x1569D90")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1569F1C", Offset = "0x1569F1C", VA = "0x1569F1C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x156A0D0", Offset = "0x156A0D0", VA = "0x156A0D0")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x156A25C", Offset = "0x156A25C", VA = "0x156A25C")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x156A40C", Offset = "0x156A40C", VA = "0x156A40C")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x156A5F0", Offset = "0x156A5F0", VA = "0x156A5F0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x156A79C", Offset = "0x156A79C", VA = "0x156A79C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x156A948", Offset = "0x156A948", VA = "0x156A948")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x156AAF4", Offset = "0x156AAF4", VA = "0x156AAF4")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x156ACA8", Offset = "0x156ACA8", VA = "0x156ACA8")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x156AE34", Offset = "0x156AE34", VA = "0x156AE34")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x156AFD0", Offset = "0x156AFD0", VA = "0x156AFD0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x156B17C", Offset = "0x156B17C", VA = "0x156B17C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x156B320", Offset = "0x156B320", VA = "0x156B320")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x156B4C4", Offset = "0x156B4C4", VA = "0x156B4C4")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x156B678", Offset = "0x156B678", VA = "0x156B678")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x156B820", Offset = "0x156B820", VA = "0x156B820")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x156B9C8", Offset = "0x156B9C8", VA = "0x156B9C8")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x156BB70", Offset = "0x156BB70", VA = "0x156BB70")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x156BD1C", Offset = "0x156BD1C", VA = "0x156BD1C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x156BEC8", Offset = "0x156BEC8", VA = "0x156BEC8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x156C064", Offset = "0x156C064", VA = "0x156C064")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x156C204", Offset = "0x156C204", VA = "0x156C204")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x156C3A4", Offset = "0x156C3A4", VA = "0x156C3A4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x156C550", Offset = "0x156C550", VA = "0x156C550")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x156C70C", Offset = "0x156C70C", VA = "0x156C70C")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x156C8F0", Offset = "0x156C8F0", VA = "0x156C8F0")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x156CADC", Offset = "0x156CADC", VA = "0x156CADC")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x156CF04", Offset = "0x156CF04", VA = "0x156CF04")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x156D0A4", Offset = "0x156D0A4", VA = "0x156D0A4")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x156D234", Offset = "0x156D234", VA = "0x156D234")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x156D3C4", Offset = "0x156D3C4", VA = "0x156D3C4")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x156D560", Offset = "0x156D560", VA = "0x156D560")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x156D714", Offset = "0x156D714", VA = "0x156D714")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x156D90C", Offset = "0x156D90C", VA = "0x156D90C")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x156DA98", Offset = "0x156DA98", VA = "0x156DA98")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x156DCD0", Offset = "0x156DCD0", VA = "0x156DCD0")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x156DEE8", Offset = "0x156DEE8", VA = "0x156DEE8")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x156E100", Offset = "0x156E100", VA = "0x156E100")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x156E318", Offset = "0x156E318", VA = "0x156E318")]
		public static TweenerCore<Vector2, Vector2, CircleOptions> DOShapeCircle(this RectTransform target, Vector2 center, float endValueDegrees, float duration, bool relativeCenter = false, bool snapping = false)
		{
			return null;
		}
	}
	[Token(Token = "0x200008D")]
	public static class DOTweenModuleUnityVersion
	{
		[StructLayout(3)]
		[Token(Token = "0x2000090")]
		[CompilerGenerated]
		private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4000170")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000171")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000172")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000173")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000293")]
			[Address(RVA = "0x1570900", Offset = "0x1570900", VA = "0x1570900", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000294")]
			[Address(RVA = "0x1570B38", Offset = "0x1570B38", VA = "0x1570B38", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000091")]
		[CompilerGenerated]
		private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4000174")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000175")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000176")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000177")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000295")]
			[Address(RVA = "0x1570B44", Offset = "0x1570B44", VA = "0x1570B44", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000296")]
			[Address(RVA = "0x1570DA0", Offset = "0x1570DA0", VA = "0x1570DA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000092")]
		[CompilerGenerated]
		private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x4000178")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000179")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400017A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x400017B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000297")]
			[Address(RVA = "0x1570DAC", Offset = "0x1570DAC", VA = "0x1570DAC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000298")]
			[Address(RVA = "0x1570FD0", Offset = "0x1570FD0", VA = "0x1570FD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000093")]
		[CompilerGenerated]
		private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x400017C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400017D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400017E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x400017F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int elapsedLoops;

			[Token(Token = "0x4000180")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000299")]
			[Address(RVA = "0x1570FDC", Offset = "0x1570FDC", VA = "0x1570FDC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600029A")]
			[Address(RVA = "0x157121C", Offset = "0x157121C", VA = "0x157121C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000094")]
		[CompilerGenerated]
		private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x4000181")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000182")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000183")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000184")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float position;

			[Token(Token = "0x4000185")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x600029B")]
			[Address(RVA = "0x1571228", Offset = "0x1571228", VA = "0x1571228", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600029C")]
			[Address(RVA = "0x1571480", Offset = "0x1571480", VA = "0x1571480", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000095")]
		[CompilerGenerated]
		private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4000186")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000187")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000188")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x600029D")]
			[Address(RVA = "0x157148C", Offset = "0x157148C", VA = "0x157148C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600029E")]
			[Address(RVA = "0x15716B8", Offset = "0x15716B8", VA = "0x15716B8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x156F4CC", Offset = "0x156F4CC", VA = "0x156F4CC")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x156F6AC", Offset = "0x156F6AC", VA = "0x156F6AC")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x156F898", Offset = "0x156F898", VA = "0x156F898")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x156F994", Offset = "0x156F994", VA = "0x156F994")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x156FA90", Offset = "0x156FA90", VA = "0x156FA90")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x156FB8C", Offset = "0x156FB8C", VA = "0x156FB8C")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x156FC9C", Offset = "0x156FC9C", VA = "0x156FC9C")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x156FDBC", Offset = "0x156FDBC", VA = "0x156FDBC")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x156FEB8", Offset = "0x156FEB8", VA = "0x156FEB8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x15700C4", Offset = "0x15700C4", VA = "0x15700C4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x15702D0", Offset = "0x15702D0", VA = "0x15702D0")]
		[AsyncStateMachine(typeof(<AsyncWaitForCompletion>d__10))]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x15703BC", Offset = "0x15703BC", VA = "0x15703BC")]
		[AsyncStateMachine(typeof(<AsyncWaitForRewind>d__11))]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x15704A8", Offset = "0x15704A8", VA = "0x15704A8")]
		[AsyncStateMachine(typeof(<AsyncWaitForKill>d__12))]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x1570594", Offset = "0x1570594", VA = "0x1570594")]
		[AsyncStateMachine(typeof(<AsyncWaitForElapsedLoops>d__13))]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1570688", Offset = "0x1570688", VA = "0x1570688")]
		[AsyncStateMachine(typeof(<AsyncWaitForPosition>d__14))]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1570784", Offset = "0x1570784", VA = "0x1570784")]
		[AsyncStateMachine(typeof(<AsyncWaitForStart>d__15))]
		public static Task AsyncWaitForStart(this Tween t)
		{
			return null;
		}
	}
	[Token(Token = "0x2000096")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x2000097")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x400018A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000029")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600029F")]
				[Address(RVA = "0x15716C4", Offset = "0x15716C4", VA = "0x15716C4", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x156F964", Offset = "0x156F964", VA = "0x156F964")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000098")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x400018B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700002A")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60002A1")]
				[Address(RVA = "0x15716F4", Offset = "0x15716F4", VA = "0x15716F4", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x156FA60", Offset = "0x156FA60", VA = "0x156FA60")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000099")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x400018C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700002B")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60002A3")]
				[Address(RVA = "0x1571754", Offset = "0x1571754", VA = "0x1571754", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x156FB5C", Offset = "0x156FB5C", VA = "0x156FB5C")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x200009A")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x400018D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x400018E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x1700002C")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60002A5")]
				[Address(RVA = "0x1571770", Offset = "0x1571770", VA = "0x1571770", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x156FC60", Offset = "0x156FC60", VA = "0x156FC60")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x200009B")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x4000190")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x1700002D")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60002A7")]
				[Address(RVA = "0x15717B0", Offset = "0x15717B0", VA = "0x15717B0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x156FD78", Offset = "0x156FD78", VA = "0x156FD78")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x200009C")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x4000191")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700002E")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60002A9")]
				[Address(RVA = "0x1571808", Offset = "0x1571808", VA = "0x1571808", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x156FE88", Offset = "0x156FE88", VA = "0x156FE88")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x200009D")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x200009E")]
		public static class Physics
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x1571998", Offset = "0x1571998", VA = "0x1571998")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x1571A98", Offset = "0x1571A98", VA = "0x1571A98")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x1571B24", Offset = "0x1571B24", VA = "0x1571B24")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x1571BB0", Offset = "0x1571BB0", VA = "0x1571BB0")]
			[Preserve]
			public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x157183C", Offset = "0x157183C", VA = "0x157183C")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x15718F0", Offset = "0x15718F0", VA = "0x15718F0")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
}
